Imports Microsoft.Office.Interop.Excel

Public Class frmLibretasSecundaria

  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing
  Private Const clave As String = "12345678"
  Private lAlu As List(Of Matricula) = Nothing
  Private lPer As List(Of PeriodoAcademico) = Nothing

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub frmLibretasSecundaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.MostrarImagenes()
    Me.ListarAnios()
    Me.ListarGrados()
    Me.ListarPeriodos()
  End Sub

  Private Sub ListarPeriodos()
    Dim obj As New RNPeriodoAcademico

    lPer.Clear()
    lPer = obj.ListarCodPeriodos(New AnioLectivo(Me.cboAnio.Text.Trim))
    obj = Nothing
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

  Private Sub ListarGrados()
    Dim obj As New RNGrado
    Dim lg As List(Of Grado)

    lg = obj.ListarGradosSec(CType(Me.cboAnio.SelectedItem, AnioLectivo))
    If lg.Count > 0 Then
      Me.cboGrado.DisplayMember = "Nombre"
      Me.cboGrado.ValueMember = "Nombre"
      Me.cboGrado.DataSource = lg
    End If
  End Sub

  Private Sub cboAnio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnio.SelectedIndexChanged
    Dim obj As RNPeriodoAcademico = Nothing
    Dim lp As List(Of PeriodoAcademico) = Nothing

    If Me.cboAnio.SelectedIndex > -1 Then
      obj = New RNPeriodoAcademico
      lp = obj.ListarCodPeriodos(CType(Me.cboAnio.SelectedItem, AnioLectivo))
      lPer = obj.ListarCodPeriodos(DirectCast(Me.cboAnio.SelectedItem, AnioLectivo))
      obj = Nothing
      If lp.Count > 0 Then
        Me.cboPeriodo.DisplayMember = "Siglas"
        Me.cboPeriodo.ValueMember = "Siglas"
        Me.cboPeriodo.DataSource = lp
      End If

      Me.ListarGrados()
    End If
  End Sub

  Private Sub cboGrado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrado.SelectedIndexChanged
    Dim objGrado As Grado = Nothing
    Dim objAnio As AnioLectivo = Nothing

    If cboAnio.SelectedIndex > -1 Then
      objGrado = CType(Me.cboGrado.SelectedItem, Grado)
      objAnio = CType(Me.cboAnio.SelectedItem, AnioLectivo)
      ListarSecciones(objGrado.Codigo, objAnio.Anio)
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

  Private Sub cboSeccion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSeccion.SelectedIndexChanged
    If Me.cboSeccion.SelectedIndex > 0 Then
      Me.cboAlumno.Enabled = True
      ListarAlumnos()
    Else
      If Me.cboAlumno.SelectedIndex > -1 Then
        Me.cboAlumno.SelectedIndex = 0
      End If
      Me.cboAlumno.Enabled = False
    End If
  End Sub

  Private Sub ListarAlumnos()
    Dim obj As New RNMatricula
    Dim la As List(Of Matricula) = Nothing

    la = obj.ListarAlumnosGradoSeccion(New Seccion(New AnioLectivo(Me.cboAnio.Text.Trim), _
                New Grado(CType(Me.cboGrado.SelectedItem, Grado).Codigo), CType(Me.cboSeccion.SelectedItem, Seccion).Letra))
    If la.Count > 0 Then
      la.Insert(0, New Matricula(0, Now, _
                          New Alumno(0, "", _
                             "Seleccionar Todos", "", ""), _
                             New Apoderado(), True, New Personal(), New AnioLectivo(), New Grado(), _
                              "", 0))
      Me.cboAlumno.DisplayMember = "NombreAlumno"
      Me.cboAlumno.ValueMember = "NombreAlumno"
      Me.cboAlumno.DataSource = la
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
    Dim proc As Process() = Nothing
    Dim k, y As Integer

    Dim sw As Integer = 0
    Dim swColor As Integer = 0
    Dim nombre As String = ""
    Dim contador As Integer = 0
    Dim a As Integer = 0
    Dim m As Integer = 6
    'Dim nota As Double = 0.0
    Dim nota As Decimal = 0D

    k = 10
    y = 2
    Try
      m_excel = New Microsoft.Office.Interop.Excel.Application
      lgra.Insert(0, CType(Me.cboGrado.SelectedItem, Grado))
      Me.pbAvance.Value = 5
      If Me.cboSeccion.SelectedIndex > 0 And Me.cboAlumno.SelectedIndex > 0 Then
        lSec.Insert(0, CType(Me.cboSeccion.SelectedItem, Seccion))
        lAlu = New List(Of Matricula)
        lAlu.Insert(0, CType(Me.cboAlumno.SelectedItem, Matricula))
        sw = 1
      ElseIf Me.cboSeccion.SelectedIndex > 0 And Me.cboAlumno.SelectedIndex = 0 Then
        lSec.Insert(0, CType(Me.cboSeccion.SelectedItem, Seccion))
        lAlu = rnM.ListarAlumnosGradoSeccion(New Seccion(New AnioLectivo(Me.cboAnio.Text.Trim), _
                New Grado(CType(Me.cboGrado.SelectedItem, Grado).Codigo), _
                CType(Me.cboSeccion.SelectedItem, Seccion).Letra))
        sw = 2
      ElseIf Me.cboSeccion.SelectedIndex = 0 And (Me.cboAlumno.SelectedIndex = 0 Or Me.cboAlumno.SelectedIndex = -1) Then
        lSec = rnS.Leer_Grado(New AnioLectivo(Me.cboAnio.Text.Trim), _
                              New Grado(lgra(0).Codigo), 1)
        sw = 3
      End If
      lAreas = rnAd.ListarAreasSecundaria()

      For Each g As Grado In lgra
        For Each s As Seccion In lSec
          'abrir un libro excel por cada seccion 
          Libro = Nothing
          Hoja = Nothing
          Libro = m_excel.Workbooks.Add(AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Libreta_Secundaria.xls")
          m_excel.ScreenUpdating = False
          'm_excel.Visible = True
          m_excel.DisplayAlerts = False

          If sw = 3 Then
            lAlu = rnM.ListarAlumnosGradoSeccion(New Seccion(New AnioLectivo(Me.cboAnio.Text.Trim), _
                New Grado(g.Codigo), s.Letra))
          End If

          For Each al As Matricula In lAlu
            contador = 0
            k = 10
            y = 2
            Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
            Hoja.Select()
            Hoja.Copy(, Hoja)
            Hoja.Unprotect(clave)
            For Each ar As AreaDRE In lAreas
              If contador = 8 Then
                MostrarBordes(Hoja, k, 2)
                m = 16
                k = 10
                y = 11
                swColor = 1
              ElseIf contador < 8 Then
                m = 6
                swColor = 0
              Else
                m = 16
              End If
              Hoja.Range(Hoja.Cells(k, y), Hoja.Cells(k, y + 1)).Merge()
              Hoja.Range(Hoja.Cells(k, y), Hoja.Cells(k, y + 1)).Value = ar.Nombre

              If swColor = 1 Then
                Hoja.Range(Hoja.Cells(k, y), Hoja.Cells(k, y + 1 + 7)).Interior.Color = RGB(165, 165, 165)
              Else
                Hoja.Range(Hoja.Cells(k, y), Hoja.Cells(k, y + 1 + 6)).Interior.Color = RGB(165, 165, 165)
              End If

              Hoja.Range(Hoja.Cells(k, y), Hoja.Cells(k, y + 1)).Font.Bold = True
              k += 1
              lCap = rnC.ListarCapacidadesArea(New AreaDRE(ar.Codigo))
              For Each c As Capacidad In lCap
                Hoja.Range(Hoja.Cells(k, y + 1), Hoja.Cells(k, y + 1)).Value = c.Nombre
                a = 0
                For Each p As PeriodoAcademico In lPer
                  'Hoja.Range(Hoja.Cells(k, m + a), Hoja.Cells(k, m + a)).NumberFormat = "##.00"
                  nota = CDec(rnN.LeerNotaFinalCapac(New NotaCapacidad(Nothing, _
                  New Capacidad(c.Codigo), New Matricula(al.Numero)), New PeriodoAcademico(p.Codigo)))
                  If nota > 0 And nota <= 20 Then
                    Hoja.Range(Hoja.Cells(k, m + a), Hoja.Cells(k, m + a)).Value = System.Math.Round(nota, 2)
                  End If
                  a += 1
                Next
                k += 1
              Next
              'promedio del area
              a = 0
              Dim prom As Decimal
              Dim cantNotas As Integer
              prom = 0
              cantNotas = 0
              For Each p As PeriodoAcademico In lPer
                Hoja.Range(Hoja.Cells(k, m + a), Hoja.Cells(k, m + a)).NumberFormat = "##"
                nota = CDec(rnN.LeerNotaFinalArea(New NotaCapacidad(Nothing, _
                  New Capacidad(0, "", New AreaDRE(ar.Codigo), True), New Matricula(al.Numero)), New PeriodoAcademico(p.Codigo)))
                If nota > 0 And nota <= 20 Then
                  Hoja.Range(Hoja.Cells(k, m + a), Hoja.Cells(k, m + a)).Value = nota
                  Hoja.Range(Hoja.Cells(k, m + a), Hoja.Cells(k, m + a)).Font.Bold = True
                  Hoja.Range(Hoja.Cells(k, m + a), Hoja.Cells(k, m + a)).Interior.Color = RGB(204, 255, 153)
                  cantNotas += 1
                End If
                prom += Math.Round(nota, 0)
                If (nota - Math.Floor(nota)) = 0.5 And (Math.Floor(nota) Mod 2 = 0) Then
                  prom += 1
                End If
                a += 1
              Next
              If cantNotas = 3 Then
                Dim promF As Integer
                promF = CInt(Math.Round(prom / 3, 0))
                If (prom / 3) - promF = 0.5 And (Math.Floor((prom / 3)) Mod 2 = 0) Then
                  promF += 1
                End If

                'Hoja.Range(Hoja.Cells(k, m + a), Hoja.Cells(k, m + a)).FormulaR1C1 = "=SUM(RC[-3]:RC[-1])"
                Hoja.Range(Hoja.Cells(k, m + a), Hoja.Cells(k, m + a)).Value = promF
                Hoja.Range(Hoja.Cells(k, m + a), Hoja.Cells(k, m + a)).Font.Bold = True
                Hoja.Range(Hoja.Cells(k, m + a), Hoja.Cells(k, m + a)).Interior.Color = RGB(204, 255, 153)
              End If
              k += 1
              contador += 1
            Next
            MostrarBordes2(Hoja, k, 11)
            MostrarAsistencia(Hoja, k, g.CodigoNivel, al.Numero)

            nombre = al.Alumno.Nombre.Chars(0) & al.Alumno.ApellidoPaterno
            Hoja.Range("E2").Value = "INFORME DE PROGRESO " & Me.cboAnio.Text.Trim
            Hoja.Range("E4").Value = CType(Me.cboPeriodo.SelectedItem, PeriodoAcademico).Nombre
            Hoja.Range("B5").Value = "Alumno(a): " & al.Alumno.Nombre & " " & al.Alumno.ApellidoPaterno & " " & al.Alumno.ApellidoMaterno
            Hoja.Range("K6").Value = "Grado: " & g.Numero & "º '" & s.Letra & "' de Secundaria"
            Hoja.Range("P6").Value = "Nº de Orden: " & al.NroOrden

            Hoja.Range("K46").Value = rnS.NombreTutor(s, Me.cboAnio.Text.Trim)
            Hoja.Range("O46").Value = rnS.NombreDirector(New Seccion(Nothing, _
                                          New Grado(g.CodigoNivel, ""), "S"c))
            Hoja.Name = al.NroOrden.ToString
            Hoja.Protect(clave)
            Me.pbAvance.Value += 1

            If Me.pbAvance.Value > 90 And Me.pbAvance.Value <= 100 Then
              Me.pbAvance.Value -= 10
            End If
          Next

          Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
          Hoja.Select()
          Hoja.Delete()
          Hoja = CType(Libro.Worksheets(1), Worksheet)
          Hoja.Select()

          m_excel.ScreenUpdating = True
          If sw = 1 Then
            m_excel.ActiveWorkbook.SaveAs(Me.cboAnio.Text.Trim & "_" & Me.cboPeriodo.Text.Trim & "_Libreta_" & _
                     nombre & "_" & g.Numero & "º " & s.Letra & " Sec." & ".xls", _
                     Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
          Else
            m_excel.ActiveWorkbook.SaveAs(Me.cboAnio.Text.Trim & "_" & Me.cboPeriodo.Text.Trim & "_Libretas_" & _
                      g.Numero & "º " & s.Letra & " Secundaria" & ".xls", _
                      Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
          End If

        Next
      Next

      Me.pbAvance.Value = Me.pbAvance.Maximum
      MessageBox.Show("Archivo exportado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Me.pbAvance.Value = 0
      Libro.Close()
      m_excel.Quit()

    Catch ex As Exception
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

  Private Sub MostrarAsistencia(ByVal hoja As Worksheet, ByVal k As Integer, _
                      ByVal codNivel As Integer, ByVal nroMat As Integer)
    Dim obj As New RNAsistencia
    Dim las As List(Of Asistencia) = Nothing
    Dim y As Integer = 4

    hoja.Range(hoja.Cells(k + 2, 11), hoja.Cells(k + 3, 12)).Merge()
    hoja.Range(hoja.Cells(k + 2, 11), hoja.Cells(k + 3, 12)).Value = "ASISTENCIA"
    hoja.Range(hoja.Cells(k + 2, 11), hoja.Cells(k + 3, 12)).Font.Bold = True
    hoja.Range(hoja.Cells(k + 2, 11), hoja.Cells(k + 3, 12)).HorizontalAlignment = XlHAlign.xlHAlignCenter

    hoja.Range(hoja.Cells(k + 2, 16), hoja.Cells(k + 2, 19)).Merge()
    hoja.Range(hoja.Cells(k + 2, 16), hoja.Cells(k + 2, 19)).Value = "TRIMESTRE"
    hoja.Range(hoja.Cells(k + 2, 16), hoja.Cells(k + 2, 19)).Font.Bold = True
    hoja.Range(hoja.Cells(k + 2, 16), hoja.Cells(k + 2, 19)).HorizontalAlignment = XlHAlign.xlHAlignCenter

    hoja.Range(hoja.Cells(k + 3, 16), hoja.Cells(k + 3, 16)).Value = "1º"
    hoja.Range(hoja.Cells(k + 3, 16), hoja.Cells(k + 3, 16)).Font.Bold = True
    hoja.Range(hoja.Cells(k + 3, 16), hoja.Cells(k + 3, 16)).HorizontalAlignment = XlHAlign.xlHAlignCenter

    hoja.Range(hoja.Cells(k + 3, 17), hoja.Cells(k + 3, 17)).Value = "2º"
    hoja.Range(hoja.Cells(k + 3, 17), hoja.Cells(k + 3, 17)).Font.Bold = True
    hoja.Range(hoja.Cells(k + 3, 17), hoja.Cells(k + 3, 17)).HorizontalAlignment = XlHAlign.xlHAlignCenter

    hoja.Range(hoja.Cells(k + 3, 18), hoja.Cells(k + 3, 18)).Value = "3º"
    hoja.Range(hoja.Cells(k + 3, 18), hoja.Cells(k + 3, 18)).Font.Bold = True
    hoja.Range(hoja.Cells(k + 3, 18), hoja.Cells(k + 3, 18)).HorizontalAlignment = XlHAlign.xlHAlignCenter

    hoja.Range(hoja.Cells(k + 3, 19), hoja.Cells(k + 3, 19)).Value = "PF"
    hoja.Range(hoja.Cells(k + 3, 19), hoja.Cells(k + 3, 19)).Font.Bold = True
    hoja.Range(hoja.Cells(k + 3, 19), hoja.Cells(k + 3, 19)).HorizontalAlignment = XlHAlign.xlHAlignCenter

    hoja.Range(hoja.Cells(k + 2, 11), hoja.Cells(k + 3, 19)).Interior.Color = RGB(127, 127, 127)

    hoja.Range(hoja.Cells(k + 4, 12), hoja.Cells(k + 4, 12)).Value = "Faltas Justificadas"
    hoja.Range(hoja.Cells(k + 4, 12), hoja.Cells(k + 4, 12)).HorizontalAlignment = XlHAlign.xlHAlignLeft
    For Each p As PeriodoAcademico In lPer
      hoja.Range(hoja.Cells(k + 4, 12 + y), hoja.Cells(k + 4, 12 + y)).NumberFormat = "##"
      hoja.Range(hoja.Cells(k + 4, 12 + y), hoja.Cells(k + 4, 12 + y)).Value = _
           obj.FaltasJusticadas(New Asistencia(0, "FJ", Nothing, New Matricula(nroMat), p.Codigo, Nothing))
      y += 1
    Next
    hoja.Range(hoja.Cells(k + 5, 12), hoja.Cells(k + 5, 12)).Value = "Faltas Injustificadas"
    hoja.Range(hoja.Cells(k + 5, 12), hoja.Cells(k + 5, 12)).HorizontalAlignment = XlHAlign.xlHAlignLeft
    y = 4
    For Each p As PeriodoAcademico In lPer
      hoja.Range(hoja.Cells(k + 5, 12 + y), hoja.Cells(k + 5, 12 + y)).NumberFormat = "##"
      hoja.Range(hoja.Cells(k + 5, 12 + y), hoja.Cells(k + 5, 12 + y)).Value = _
           obj.FaltasJusticadas(New Asistencia(0, "F", Nothing, New Matricula(nroMat), p.Codigo, Nothing))
      y += 1
    Next
    hoja.Range(hoja.Cells(k + 6, 12), hoja.Cells(k + 6, 12)).Value = "Tardanzas Justificadas"
    hoja.Range(hoja.Cells(k + 6, 12), hoja.Cells(k + 6, 12)).HorizontalAlignment = XlHAlign.xlHAlignLeft
    y = 4
    For Each p As PeriodoAcademico In lPer
      hoja.Range(hoja.Cells(k + 6, 12 + y), hoja.Cells(k + 6, 12 + y)).NumberFormat = "##"
      hoja.Range(hoja.Cells(k + 6, 12 + y), hoja.Cells(k + 6, 12 + y)).Value = _
      obj.FaltasJusticadas(New Asistencia(0, "TJ", Nothing, New Matricula(nroMat), p.Codigo, Nothing))
      y += 1
    Next
    hoja.Range(hoja.Cells(k + 7, 12), hoja.Cells(k + 7, 12)).Value = "Tardanzas Injustificadas"
    hoja.Range(hoja.Cells(k + 7, 12), hoja.Cells(k + 7, 12)).HorizontalAlignment = XlHAlign.xlHAlignLeft
    y = 4
    For Each p As PeriodoAcademico In lPer
      hoja.Range(hoja.Cells(k + 7, 12 + y), hoja.Cells(k + 7, 12 + y)).NumberFormat = "##"
      hoja.Range(hoja.Cells(k + 7, 12 + y), hoja.Cells(k + 7, 12 + y)).Value = _
      obj.FaltasJusticadas(New Asistencia(0, "T", Nothing, New Matricula(nroMat), p.Codigo, Nothing))
      y += 1
    Next

    MostrarBordesAsistencia(hoja, k + 2)
    MostrarComportamiento(hoja, k + 9, codNivel, nroMat)

  End Sub

  Private Sub MostrarBordesAsistencia(ByVal hoja As Worksheet, ByVal k As Integer)
    With hoja.Range(hoja.Cells(k, 11), hoja.Cells(k + 5, 19))
      .Borders(XlBordersIndex.xlInsideVertical).LineStyle = XlLineStyle.xlContinuous
      .Borders(XlBordersIndex.xlInsideVertical).Weight = XlBorderWeight.xlThin
      .Borders(XlBordersIndex.xlInsideVertical).ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic

      .Borders(XlBordersIndex.xlInsideHorizontal).LineStyle = XlLineStyle.xlLineStyleNone
      .Borders(XlBordersIndex.xlInsideHorizontal).Weight = XlBorderWeight.xlThin
      .Borders(XlBordersIndex.xlInsideHorizontal).ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic

      .Borders(XlBordersIndex.xlEdgeTop).LineStyle = XlLineStyle.xlContinuous
      .Borders(XlBordersIndex.xlEdgeTop).Weight = XlBorderWeight.xlThin
      .Borders(XlBordersIndex.xlEdgeTop).ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic

      .Borders(XlBordersIndex.xlEdgeBottom).LineStyle = XlLineStyle.xlDouble
      .Borders(XlBordersIndex.xlEdgeBottom).Weight = XlBorderWeight.xlThin
      .Borders(XlBordersIndex.xlEdgeBottom).ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic

      .Borders(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlDouble
      .Borders(XlBordersIndex.xlEdgeRight).Weight = XlBorderWeight.xlThin
      .Borders(XlBordersIndex.xlEdgeRight).ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic

      .Borders(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlDouble
      .Borders(XlBordersIndex.xlEdgeLeft).Weight = XlBorderWeight.xlThin
      .Borders(XlBordersIndex.xlEdgeLeft).ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic
    End With
  End Sub

  Private Sub MostrarComportamiento(ByVal hoja As Worksheet, ByVal k As Integer, _
              ByVal codNivel As Integer, ByVal nroMat As Integer)
    Dim obj As New RNVirtud
    Dim objN As New RNNotaComportamiento
    Dim lv As List(Of Virtud) = Nothing
    Dim a As Integer = 2
    Dim y As Integer = 4
    Dim nota As Double = 0.0

    hoja.Range(hoja.Cells(k, 11), hoja.Cells(k + 1, 12)).Merge()
    hoja.Range(hoja.Cells(k, 11), hoja.Cells(k + 1, 12)).Value = "EVALUACIÓN DE COMPORTAMIENTO"
    hoja.Range(hoja.Cells(k, 11), hoja.Cells(k + 1, 12)).Font.Bold = True
    hoja.Range(hoja.Cells(k, 11), hoja.Cells(k + 1, 12)).HorizontalAlignment = XlHAlign.xlHAlignCenter

    hoja.Range(hoja.Cells(k, 16), hoja.Cells(k, 19)).Merge()
    hoja.Range(hoja.Cells(k, 16), hoja.Cells(k, 19)).Value = "TRIMESTRE"
    hoja.Range(hoja.Cells(k, 16), hoja.Cells(k, 19)).Font.Bold = True
    hoja.Range(hoja.Cells(k, 16), hoja.Cells(k, 19)).HorizontalAlignment = XlHAlign.xlHAlignCenter

    hoja.Range(hoja.Cells(k + 1, 16), hoja.Cells(k + 1, 16)).Value = "1º"
    hoja.Range(hoja.Cells(k + 1, 16), hoja.Cells(k + 1, 16)).Font.Bold = True
    hoja.Range(hoja.Cells(k + 1, 16), hoja.Cells(k + 1, 16)).HorizontalAlignment = XlHAlign.xlHAlignCenter

    hoja.Range(hoja.Cells(k + 1, 17), hoja.Cells(k + 1, 17)).Value = "2º"
    hoja.Range(hoja.Cells(k + 1, 17), hoja.Cells(k + 1, 17)).Font.Bold = True
    hoja.Range(hoja.Cells(k + 1, 17), hoja.Cells(k + 1, 17)).HorizontalAlignment = XlHAlign.xlHAlignCenter

    hoja.Range(hoja.Cells(k + 1, 18), hoja.Cells(k + 1, 18)).Value = "3º"
    hoja.Range(hoja.Cells(k + 1, 18), hoja.Cells(k + 1, 18)).Font.Bold = True
    hoja.Range(hoja.Cells(k + 1, 18), hoja.Cells(k + 1, 18)).HorizontalAlignment = XlHAlign.xlHAlignCenter

    hoja.Range(hoja.Cells(k + 1, 19), hoja.Cells(k + 1, 19)).Value = "PF"
    hoja.Range(hoja.Cells(k + 1, 19), hoja.Cells(k + 1, 19)).Font.Bold = True
    hoja.Range(hoja.Cells(k + 1, 19), hoja.Cells(k + 1, 19)).HorizontalAlignment = XlHAlign.xlHAlignCenter

    hoja.Range(hoja.Cells(k, 11), hoja.Cells(k + 1, 19)).Interior.Color = RGB(127, 127, 127)

    'm_excel.Visible = True
    'm_excel.ScreenUpdating = True
    Dim totAnio As Integer
    totAnio = 0
    Dim cant As Integer
    cant = 0
    For Each p As PeriodoAcademico In lPer
      lv = obj.ListarVirtudesPeriodo(New Virtud(0, "", False, New AnioLectivo(Me.cboAnio.Text.Trim) _
                                      , New PeriodoAcademico(p.Codigo), New Nivel(codNivel), 0))
      If y <= 4 Then
        y = 4
        For Each v As Virtud In lv
          hoja.Range(hoja.Cells(k + a, 12), hoja.Cells(k + a, 12)).Value = v.Nombre
          hoja.Range(hoja.Cells(k + a, 12), hoja.Cells(k + a, 12)).HorizontalAlignment = XlHAlign.xlHAlignLeft
          a += 1
        Next
      End If

      a = 2
      Dim total As Integer
      Dim pt As Integer
      total = 0
      For Each v As Virtud In lv
        pt = objN.LeerPuntosComportamiento(New NotaComportamiento(Nothing, New Matricula(nroMat), _
                        New Virtud(v.Codigo)), New PeriodoAcademico(p.Codigo))
        hoja.Range(hoja.Cells(k + a, 12 + y), hoja.Cells(k + a, 12 + y)).NumberFormat = "##"
        hoja.Range(hoja.Cells(k + a, 12 + y), hoja.Cells(k + a, 12 + y)).Value = pt
        If pt > 0 Then
          cant += 1
        End If
        a += 1
        total += pt
      Next

      hoja.Range(hoja.Cells(k + a, 12 + y), hoja.Cells(k + a, 12 + y)).NumberFormat = "##"
      hoja.Range(hoja.Cells(k + a, 12 + y), hoja.Cells(k + a, 12 + y)).Value = total
      totAnio += total
      y += 1
    Next

    If cant = 12 Then
      Dim promComp As Double
      promComp = Math.Round(totAnio / 3, 0)
      If ((totAnio / 3) - Math.Floor(totAnio / 3) = 0.5) Then
        promComp += 1
      End If

      hoja.Range(hoja.Cells(k + a, 12 + y), hoja.Cells(k + a, 12 + y)).Value = promComp
      With hoja.Range(hoja.Cells(k + a, 12 + y - 3), hoja.Cells(k + a, 12 + y))
        .Interior.Color = RGB(204, 255, 153)
        .Font.Bold = True
      End With
    End If
    hoja.Range(hoja.Cells(k + a, 12), hoja.Cells(k + a, 12)).Value = "Nota de Comportamiento Acumulada"
    hoja.Range(hoja.Cells(k + a, 12), hoja.Cells(k + a, 12)).Font.Size = 8
    hoja.Range(hoja.Cells(k + a, 12), hoja.Cells(k + a, 12)).HorizontalAlignment = XlHAlign.xlHAlignLeft
    'Mostrar Acumulado de comportamiento
    y = 4
    For Each p As PeriodoAcademico In lPer
      nota = objN.LeerNotaFinalComportamiento(New NotaComportamiento(Nothing, New Matricula(nroMat), _
                    Nothing), New PeriodoAcademico(p.Codigo))
      hoja.Range(hoja.Cells(k + a, 12 + y), hoja.Cells(k + a, 12 + y)).NumberFormat = "##"
      If nota > 0 And nota <= 20 Then
        hoja.Range(hoja.Cells(k + a, 12 + y), hoja.Cells(k + a, 12 + y)).Value = nota
        hoja.Range(hoja.Cells(k + a, 12 + y), hoja.Cells(k + a, 12 + y)).Font.Bold = True
        hoja.Range(hoja.Cells(k + a, 12 + y), hoja.Cells(k + a, 12 + y)).Interior.Color = RGB(204, 255, 153)
        'ElseIf nota > 20 Then
        '  hoja.Range(hoja.Cells(k + a, 12 + y), hoja.Cells(k + a, 12 + y)).Value = nota / 2
        '  hoja.Range(hoja.Cells(k + a, 12 + y), hoja.Cells(k + a, 12 + y)).Font.Bold = True
        '  hoja.Range(hoja.Cells(k + a, 12 + y), hoja.Cells(k + a, 12 + y)).Interior.Color = RGB(204, 255, 153)
      End If
      y += 1
    Next

    MostrarBordesComportamiento(hoja, k)

  End Sub

  Private Sub MostrarBordesComportamiento(ByVal hoja As Worksheet, ByVal k As Integer)
    With hoja.Range(hoja.Cells(k, 11), hoja.Cells(k + 6, 19))
      .Borders(XlBordersIndex.xlInsideVertical).LineStyle = XlLineStyle.xlContinuous
      .Borders(XlBordersIndex.xlInsideVertical).Weight = XlBorderWeight.xlThin
      .Borders(XlBordersIndex.xlInsideVertical).ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic

      .Borders(XlBordersIndex.xlInsideHorizontal).LineStyle = XlLineStyle.xlLineStyleNone
      .Borders(XlBordersIndex.xlInsideHorizontal).Weight = XlBorderWeight.xlThin
      .Borders(XlBordersIndex.xlInsideHorizontal).ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic

      .Borders(XlBordersIndex.xlEdgeTop).LineStyle = XlLineStyle.xlContinuous
      .Borders(XlBordersIndex.xlEdgeTop).Weight = XlBorderWeight.xlThin
      .Borders(XlBordersIndex.xlEdgeTop).ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic

      .Borders(XlBordersIndex.xlEdgeBottom).LineStyle = XlLineStyle.xlDouble
      .Borders(XlBordersIndex.xlEdgeBottom).Weight = XlBorderWeight.xlThin
      .Borders(XlBordersIndex.xlEdgeBottom).ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic

      .Borders(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlDouble
      .Borders(XlBordersIndex.xlEdgeRight).Weight = XlBorderWeight.xlThin
      .Borders(XlBordersIndex.xlEdgeRight).ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic

      .Borders(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlDouble
      .Borders(XlBordersIndex.xlEdgeLeft).Weight = XlBorderWeight.xlThin
      .Borders(XlBordersIndex.xlEdgeLeft).ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic
    End With
  End Sub

  Private Sub MostrarBordes(ByVal hoja As Worksheet, ByVal k As Integer, _
                            ByVal y As Integer)
    'k = 10
    'y += 1
    'dibujar bordes de celdas
    With hoja.Range(hoja.Cells(10, 2), hoja.Cells(k - 1, y + 7))
      .Borders(XlBordersIndex.xlInsideVertical).LineStyle = XlLineStyle.xlContinuous
      .Borders(XlBordersIndex.xlInsideVertical).Weight = XlBorderWeight.xlThin
      .Borders(XlBordersIndex.xlInsideVertical).ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic

      .Borders(XlBordersIndex.xlInsideHorizontal).LineStyle = XlLineStyle.xlLineStyleNone
      .Borders(XlBordersIndex.xlInsideHorizontal).Weight = XlBorderWeight.xlThin
      .Borders(XlBordersIndex.xlInsideHorizontal).ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic

      .Borders(XlBordersIndex.xlEdgeTop).LineStyle = XlLineStyle.xlContinuous
      .Borders(XlBordersIndex.xlEdgeTop).Weight = XlBorderWeight.xlThin
      .Borders(XlBordersIndex.xlEdgeTop).ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic

      .Borders(XlBordersIndex.xlEdgeBottom).LineStyle = XlLineStyle.xlDouble
      .Borders(XlBordersIndex.xlEdgeBottom).Weight = XlBorderWeight.xlThin
      .Borders(XlBordersIndex.xlEdgeBottom).ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic

      .Borders(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlDouble
      .Borders(XlBordersIndex.xlEdgeRight).Weight = XlBorderWeight.xlThin
      .Borders(XlBordersIndex.xlEdgeRight).ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic

      .Borders(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlDouble
      .Borders(XlBordersIndex.xlEdgeLeft).Weight = XlBorderWeight.xlThin
      .Borders(XlBordersIndex.xlEdgeLeft).ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic
    End With

    'color de cabeceras
    'With hoja.Range(hoja.Cells(k, 1), hoja.Cells(k + 1, y - 1))
    '  .Interior.Color = RGB(153, 204, 255)
    'End With

  End Sub

  Private Sub MostrarBordes2(ByVal hoja As Worksheet, ByVal k As Integer, _
                            ByVal y As Integer)
    'k = 10
    'y += 1
    'dibujar bordes de celdas
    With hoja.Range(hoja.Cells(10, 11), hoja.Cells(k - 1, y + 8))
      .Borders(XlBordersIndex.xlInsideVertical).LineStyle = XlLineStyle.xlContinuous
      .Borders(XlBordersIndex.xlInsideVertical).Weight = XlBorderWeight.xlThin
      .Borders(XlBordersIndex.xlInsideVertical).ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic

      'If hoja.Range("P10").Value Is Nothing Then
      .Borders(XlBordersIndex.xlInsideHorizontal).LineStyle = XlLineStyle.xlLineStyleNone
      'Else
      '.Borders(XlBordersIndex.xlInsideHorizontal).LineStyle = XlLineStyle.xlDot
      'End If


      .Borders(XlBordersIndex.xlInsideHorizontal).Weight = XlBorderWeight.xlThin
      .Borders(XlBordersIndex.xlInsideHorizontal).ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic

      .Borders(XlBordersIndex.xlEdgeTop).LineStyle = XlLineStyle.xlContinuous
      .Borders(XlBordersIndex.xlEdgeTop).Weight = XlBorderWeight.xlThin
      .Borders(XlBordersIndex.xlEdgeTop).ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic

      .Borders(XlBordersIndex.xlEdgeBottom).LineStyle = XlLineStyle.xlDouble
      .Borders(XlBordersIndex.xlEdgeBottom).Weight = XlBorderWeight.xlThin
      .Borders(XlBordersIndex.xlEdgeBottom).ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic

      .Borders(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlDouble
      .Borders(XlBordersIndex.xlEdgeRight).Weight = XlBorderWeight.xlThin
      .Borders(XlBordersIndex.xlEdgeRight).ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic

      .Borders(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlDouble
      .Borders(XlBordersIndex.xlEdgeLeft).Weight = XlBorderWeight.xlThin
      .Borders(XlBordersIndex.xlEdgeLeft).ColorIndex = Microsoft.Office.Interop.Excel.Constants.xlAutomatic
    End With

    'color de cabeceras
    'With hoja.Range(hoja.Cells(k, 1), hoja.Cells(k + 1, y - 1))
    '  .Interior.Color = RGB(153, 204, 255)
    'End With

  End Sub

End Class