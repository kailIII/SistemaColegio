Imports Microsoft.Office.Interop.Excel

Public Class frmPonderado
  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing
  Private Const clave As String = "12345678"
  Private lAlu As List(Of Matricula) = Nothing
  Private vectorAlu(70) As Integer
  Private l(10, 10) As List(Of Seccion)
  Private vectorNota(70) As Double

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub frmConsolidadoSec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    MostrarImagenes()
    ListarAnios()
    ListarGrados()

  End Sub

  Private Sub MostrarImagenes()
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\excel.bmp")

  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub ListarAnios()
    Dim obj As New RNAnioLectivo
    Dim la As List(Of AnioLectivo)

    la = obj.Listar
    If la.Count > 0 Then
      Me.cboAnio.DisplayMember = "anio"
      Me.cboAnio.ValueMember = "anio"
      Me.cboAnio.DataSource = la
    Else
      MessageBox.Show("Ingrese año lectivo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Me.Close()
    End If
  End Sub

  Private Sub cboAnio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnio.SelectedIndexChanged
    Dim obj As RNPeriodoAcademico = Nothing
    Dim lp As List(Of PeriodoAcademico) = Nothing

    If Me.cboAnio.SelectedIndex > -1 Then
      obj = New RNPeriodoAcademico
      lp = obj.ListarCodPeriodos(CType(Me.cboAnio.SelectedItem, AnioLectivo))

      If lp.Count > 0 Then
        Me.cboPeriodo.DisplayMember = "Siglas"
        Me.cboPeriodo.ValueMember = "Siglas"
        Me.cboPeriodo.DataSource = lp
      End If

      Me.ListarGrados()
    End If
  End Sub

  Private Sub ListarGrados()
    Dim obj As New RNGrado
    Dim lg As List(Of Grado)

    lg = obj.ListarGradosSec(CType(Me.cboAnio.SelectedItem, AnioLectivo))
    If lg.Count > 0 Then
      lg.Insert(0, New Grado(0, 0, "Seleccionar Todos", 0))
      Me.cboGrado.DisplayMember = "Nombre"
      Me.cboGrado.ValueMember = "Nombre"
      Me.cboGrado.DataSource = lg
    End If
  End Sub

  Private Sub cboGrado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrado.SelectedIndexChanged
    Dim objGrado As Grado = Nothing
    Dim objAnio As AnioLectivo = Nothing

    If cboAnio.SelectedIndex > -1 Then
      If Me.cboGrado.SelectedIndex = 0 Then
        If Me.cboSeccion.Items.Count > 0 Then
          Me.cboSeccion.SelectedIndex = 0
        End If
        Me.cboSeccion.Enabled = False
      Else
        Me.cboSeccion.Enabled = True
        objGrado = CType(Me.cboGrado.SelectedItem, Grado)
        objAnio = CType(Me.cboAnio.SelectedItem, AnioLectivo)
        ListarSecciones(objGrado.Codigo, objAnio.anio)
      End If
    End If
  End Sub

  Public Sub ListarSecciones(ByVal wCodigoGrado As Integer, ByVal wAnio As String)
    Dim obj As New RNSeccion
    Dim ls As List(Of Seccion)

    ls = obj.Listar2(New Seccion(New Grado(wCodigoGrado), wAnio, CChar("a"), New Docente(), "", 0, 0))
    If ls.Count > 0 Then
      ls.Insert(0, New Seccion(New AnioLectivo(), New Grado(), "S"))
      Me.cboSeccion.DisplayMember = "LetraCompleta"
      Me.cboSeccion.ValueMember = "Letra"
      Me.cboSeccion.DataSource = ls
    End If
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Dim lgra As New List(Of Grado)
    Dim lCur As New List(Of DocenteCarga)
    Dim lSec As New List(Of Seccion)
    Dim lUni As List(Of Unidad) = Nothing
    Dim lCap As List(Of Capacidad) = Nothing
    Dim lNot As List(Of NotaCapacidad) = Nothing
    Dim lAreas As List(Of AreaDRE) = Nothing

    Dim rnD As New RNDocenteCarga
    Dim rnS As New RNSeccion
    Dim rnA As New RNAlumno
    Dim rnU As New RNUnidad
    Dim rnC As New RNCapacidad
    Dim rnN As New RNNotaCapacidad
    Dim rnM As New RNMatricula
    Dim rnG As New RNGrado
    Dim rnAd As New RNAreaDRE

    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing
    Dim proc As Process()

    Dim k, y As Integer
    Dim i As Integer = -1
    Dim sw As Integer = 0
    Dim f As Integer = 0
    Dim letra As String = ""

    Try
      m_excel = New Microsoft.Office.Interop.Excel.Application
      Me.pbAvance.Value = 5
      lAreas = rnAd.ListarAreasSecundaria()
      If Me.cboGrado.SelectedIndex > 0 And Me.cboSeccion.SelectedIndex > 0 Then
        lgra.Insert(0, CType(Me.cboGrado.SelectedItem, Grado))
        lSec.Insert(0, New Seccion(New AnioLectivo(), New Grado(), Me.cboSeccion.Text.Trim))
        sw = 0
      ElseIf Me.cboGrado.SelectedIndex > 0 And Me.cboSeccion.SelectedIndex = 0 Then
        lgra.Insert(0, CType(Me.cboGrado.SelectedItem, Grado))
        lSec = rnS.Leer_Grado(New AnioLectivo(Me.cboAnio.Text.Trim), _
                              New Grado(lgra(0).Codigo), 1)
        sw = 0
      ElseIf Me.cboGrado.SelectedIndex = 0 And (Me.cboSeccion.SelectedIndex = 0 Or Me.cboSeccion.SelectedIndex = -1) Then
        lgra = rnG.ListarGradosSec(CType(Me.cboAnio.SelectedItem, AnioLectivo))
        sw = 1
      End If

      For Each g As Grado In lgra
        'abrir un libro excel por cada grado
        Libro = Nothing
        Hoja = Nothing
        Libro = m_excel.Workbooks.Add(AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Ponderados.xls")
        m_excel.ScreenUpdating = False
        m_excel.DisplayAlerts = False

        If sw = 1 Then
          lSec = rnS.Leer_Grado(New AnioLectivo(Me.cboAnio.Text.Trim), _
                              New Grado(g.Codigo), 1)
        End If
        For Each sec As Seccion In lSec
          lAlu = rnM.ListarAlumnosGradoSeccion(New Seccion(New AnioLectivo(Me.cboAnio.Text.Trim), _
                                    New Grado(g.Codigo), sec.Letra))
          Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
          Hoja.Select()
          Hoja.Copy(, Hoja)
          k = 17
          y = 5
          Hoja.Unprotect(clave)

          Hoja.Range("D2").Value = Me.cboAnio.Text.Trim & " - " & CType(Me.cboPeriodo.SelectedItem, PeriodoAcademico).Nombre
          Hoja.Range("D3").Value = g.Numero & "º " & sec.Letra & " - Secundaria"
          Inicializar(vectorAlu)
          MostrarAlumnosCurso(lAlu, Hoja)

          For Each a As AreaDRE In lAreas
            'j += 1
            If a.Nombre.Length <= 27 Then
              Hoja.Range(Hoja.Cells(5, y), Hoja.Cells(5, y)).Value = a.Nombre
            Else
              Hoja.Range(Hoja.Cells(5, y), Hoja.Cells(5, y)).Value = a.Nombre.Substring(0, 20)
            End If

            lCap = rnC.ListarCapacidadesArea(New AreaDRE(a.Codigo))
            For Each cap As Capacidad In lCap
              If Me.cboSeccion.SelectedIndex > 0 Then
                letra = CType(Me.cboSeccion.SelectedItem, Seccion).Letra
              Else
                letra = sec.Letra
              End If

              lCur = rnD.ListarCargasArea(New DocenteCarga(0, New CargaAcademica(0, New Curso(0, "", 0, New AreaDRE()) _
                              , New Seccion(New AnioLectivo(CType(Me.cboAnio.SelectedItem, AnioLectivo).anio), _
                                New Grado(g.Codigo), letra)), _
                              New PeriodoAcademico(CType(Me.cboPeriodo.SelectedItem, PeriodoAcademico).Codigo, _
                                      Now, Now, True, "", "", "")), New AreaDRE(a.Codigo))

              If lCur.Count > 1 Then
                For h As Integer = 0 To lCur.Count - 2
                  For p As Integer = h + 1 To lCur.Count - 1
                    If lCur(h).NombreCurso = lCur(p).NombreCurso Then
                      sw = 10
                    Else
                      sw = 0
                    End If
                  Next
                Next
              Else
                sw = 0
              End If

              If lCur.Count = 1 Or sw = 10 Then
                If sw = 10 Then
                  lNot = rnN.ListarConsolidadoNotasArea(New NotaCapacidad(0, CDbl(0), Now, True, _
                         New Matricula(0, Now, New Grado(g.Codigo), _
                         New Alumno(), New AnioLectivo(), sec.Letra, 0, True), _
                         New PeriodoAcademico(CType(Me.cboPeriodo.SelectedItem, PeriodoAcademico).Codigo), _
                         New Personal(), New Capacidad(cap.Codigo, "", New AreaDRE(a.Codigo), _
                        True), New Unidad(0, "", True, New PeriodoAcademico(), _
                                                   New DocenteCarga())))
                Else
                  lNot = rnN.ListarNotasArea(New NotaCapacidad(0, CDbl(0), Now, True, _
                    New Matricula(0, Now, New Grado(g.Codigo), _
                                  New Alumno(), New AnioLectivo(), lCur(0).Carga.Seccion.Letra _
                                  , 0, True), _
                    New PeriodoAcademico(CType(Me.cboPeriodo.SelectedItem, PeriodoAcademico).Codigo), _
                    New Personal(), New Capacidad(cap.Codigo), New Unidad(0, "", True, _
                                              New PeriodoAcademico(), _
                                              New DocenteCarga(lCur(0).Codigo))))
                End If
              Else
                Inicializar2(vectorNota)
                For Each d As DocenteCarga In lCur
                  lNot = rnN.ListarNotasArea(New NotaCapacidad(0, CDbl(0), Now, True, _
                  New Matricula(0, Now, New Grado(g.Codigo), _
                                New Alumno(), New AnioLectivo(), d.Carga.Seccion.Letra _
                                , 0, True), _
                  New PeriodoAcademico(CType(Me.cboPeriodo.SelectedItem, PeriodoAcademico).Codigo), _
                  New Personal(), New Capacidad(cap.Codigo), New Unidad(0, "", True, _
                                            New PeriodoAcademico(), _
                                            New DocenteCarga(d.Codigo))))
                  f = -1
                  For Each n As NotaCapacidad In lNot
                    Do
                      f += 1
                      If vectorAlu(f) = n.Matricula.NroOrden Then
                        vectorNota(f) = vectorNota(f) + System.Math.Round(n.Promedio, 2)
                      End If
                    Loop Until (vectorAlu(f) = n.Matricula.NroOrden)
                  Next
                Next
              End If

              For Each nc As NotaCapacidad In lNot
                Do
                  i += 1 'para avanzar el vector 
                  If vectorAlu(i) = nc.Matricula.NroOrden Then
                    If lCur.Count = 1 Or sw = 10 Then
                      Hoja.Range(Hoja.Cells(k, y), Hoja.Cells(k, y)).Value = System.Math.Round(nc.Promedio, 2)
                    Else
                      Hoja.Range(Hoja.Cells(k, y), Hoja.Cells(k, y)).Value = System.Math.Round(vectorNota(i) / lCur.Count, 2)
                    End If
                  End If
                  k += 1
                Loop Until (vectorAlu(i) = nc.Matricula.NroOrden)
              Next
              i = -1
              k = 17
              y += 1
            Next
            y += (6 - lCap.Count) 'para q salte las columnas en blanco y el promedio
            'Mostrar celda del promedio
            Hoja.Range(Hoja.Cells(k, y - 1), Hoja.Cells(k, y - 1)).ColumnWidth = 4
            Me.pbAvance.Value += 1
          Next
          If Me.pbAvance.Value > 90 And Me.pbAvance.Value <= 100 Then
            Me.pbAvance.Value -= 10
          End If
          Hoja.Name = g.Numero & "º " & sec.Letra
          'Colocar Orden de Mérito
          OrdenMerito(Hoja)

          Hoja.Protect(clave)
        Next
        Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
        Hoja.Select()
        Hoja.Delete()
        Hoja = CType(Libro.Worksheets(1), Worksheet)
        Hoja.Select()

        m_excel.ScreenUpdating = True
        If lSec.Count = 1 Then
          m_excel.ActiveWorkbook.SaveAs(Me.cboAnio.Text.Trim & "_" & Me.cboPeriodo.Text.Trim & "_Ponderado_" & _
                    g.Numero & " " & lSec(0).Letra & "º Sec" & ".xls", _
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
        Else
          m_excel.ActiveWorkbook.SaveAs(Me.cboAnio.Text.Trim & "_" & Me.cboPeriodo.Text.Trim & "_Ponderados_" & _
                    g.Numero & "º Secundaria" & ".xls", _
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
        End If
      Next

      Me.pbAvance.Value = Me.pbAvance.Maximum
      MessageBox.Show("Archivo exportado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Me.pbAvance.Value = 0
      Libro.Close()
      m_excel.Quit()
    Catch ex As Exception
      Hoja = Nothing
      Libro = Nothing
      m_excel = Nothing
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      If Hoja IsNot Nothing Then
        System.Runtime.InteropServices.Marshal.ReleaseComObject(Hoja)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(Libro)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(m_excel)
      End If

      Hoja = Nothing
      Libro = Nothing
      m_excel = Nothing

      proc = Process.GetProcessesByName("EXCEL")
      For Each p As Process In proc
        p.Kill()
      Next
      proc = Nothing
    End Try
  End Sub

  Private Sub OrdenMerito(ByVal hoja As Worksheet)
    Dim k As Integer = 17
    Dim y As Integer = 95
    Dim prom(70) As Double
    Dim merito(70) As Integer
    Dim op As Double
    Dim nota As Double = 0.0
    Dim puesto As Integer = 1

    For m As Integer = 0 To 70
      prom(m) = 0.0
      merito(m) = 0
    Next

    For i As Integer = 1 To lAlu.Count
      If hoja.Range(hoja.Cells(k, y), hoja.Cells(k, y)).Value.ToString <> "" Then
        prom(i) = System.Math.Round(CDbl(hoja.Range(hoja.Cells(k, y), hoja.Cells(k, y)).Value), 3)
      End If
      k += 1
    Next

    For p As Integer = 1 To lAlu.Count
      For e As Integer = 1 To lAlu.Count
        If prom(p) > prom(e) Then
          op = prom(p)
          prom(p) = prom(e)
          prom(e) = op
        End If
      Next
    Next

    For j As Integer = 1 To lAlu.Count
      merito(j) = puesto
      puesto += 1
      If prom(j) = prom(j - 1) And prom(j - 1) > 0.0 Then
        merito(j) = puesto - 2
        puesto = merito(j)
        puesto += 1
      End If
    Next

    For n As Integer = 1 To lAlu.Count
      k = 17
      y = 95
      For s As Integer = 1 To lAlu.Count
        If hoja.Range(hoja.Cells(k, y), hoja.Cells(k, y)).Value.ToString <> "" Then
          nota = System.Math.Round(CDbl(hoja.Range(hoja.Cells(k, y), hoja.Cells(k, y)).Value), 3)
        Else
          nota = 0.0
        End If

        If prom(n) = nota Then
          hoja.Range(hoja.Cells(k, y + 1), hoja.Cells(k, y + 1)).Value = merito(n)
        End If
        k += 1
      Next
    Next

  End Sub

  Private Sub Inicializar(ByVal vector() As Integer)
    For i As Integer = 0 To 70
      vector(i) = 0
    Next
  End Sub

  Private Sub Inicializar2(ByVal vector() As Double)
    For i As Integer = 0 To 70
      vector(i) = 0
    Next
  End Sub

  Private Sub MostrarAlumnosCurso(ByVal listAlu As List(Of Matricula), ByVal hoja As Worksheet)
    Dim j As Integer = 17
    Dim i As Integer = 0

    For Each a As Matricula In listAlu
      hoja.Range("A" & j).ColumnWidth = 3
      hoja.Range("A" & j).RowHeight = 9
      hoja.Range("A" & j).Value = a.NroOrden
      vectorAlu(i) = a.NroOrden
      hoja.Range("B" & j).Value = a.Alumno.NombreCompleto
      j += 1
      i += 1
    Next
  End Sub

End Class