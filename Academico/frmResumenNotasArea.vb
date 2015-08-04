Imports Microsoft.Office.Interop.Excel

Public Class frmResumenNotasArea
  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing
  Private Const clave As String = "12345678"
  Private lAlu As List(Of Matricula) = Nothing
  Private vectorAlu(70) As Integer
  Private vectorProm(70) As Double
  Private vectorPC(70) As Double
  Private vectorPCap(70, 5) As Double
  Private vectorF(70) As Double

  Private Sub frmResumenNotasArea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    MostrarImagenes()
    ListarAnios()
    ListarGrados()
    InicializarPromedios()
    InicializarPromediosFinales()
    InicializarVectorAlumnos()
    InicializarVectorPCap()
  End Sub

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub MostrarImagenes()
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
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

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
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

  Private Sub cboGrado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrado.SelectedIndexChanged
    Dim objGrado As Grado = Nothing
    Dim objAnio As AnioLectivo = Nothing

    If cboAnio.SelectedIndex > -1 Then
      objGrado = CType(Me.cboGrado.SelectedItem, Grado)
      objAnio = CType(Me.cboAnio.SelectedItem, AnioLectivo)
      ListarSecciones(objGrado.Codigo, objAnio.anio)
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
      Me.cboCurso.Enabled = True
      ListarAreas()
    Else
      If Me.cboCurso.SelectedIndex > -1 Then
        Me.cboCurso.SelectedIndex = 0
      End If
      Me.cboCurso.Enabled = False
    End If
  End Sub

  Private Sub ListarAreas()
    Dim obj As New RNAreaDRE
    Dim la As List(Of AreaDRE) = Nothing

    If Me.cboSeccion.Items.Count > 0 Then
      la = obj.ListarAreasSeccion(New AnioLectivo(Me.cboAnio.Text.Trim))
      If la IsNot Nothing Then
        If la.Count > 0 Then
          la.Insert(0, New AreaDRE(0, "Seleccionar Todos", New DRE(), New Nivel()))
          Me.cboCurso.DisplayMember = "Nombre"
          Me.cboCurso.ValueMember = "Codigo"
          Me.cboCurso.DataSource = la
        End If
      End If
    End If
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Dim obj As Grado = Nothing
    Dim lCur As New List(Of DocenteCarga)
    Dim lSec As List(Of Seccion) = Nothing
    Dim lUni As List(Of Unidad) = Nothing
    Dim lCap As List(Of Capacidad) = Nothing
    Dim lNot As List(Of NotaCapacidad) = Nothing
    Dim rnD As New RNDocenteCarga
    Dim rnS As New RNSeccion
    Dim rnA As New RNAlumno
    Dim rnU As New RNUnidad
    Dim rnC As New RNCapacidad
    Dim rnN As New RNNotaCapacidad
    Dim rnM As New RNMatricula

    Dim k As Integer = 7
    Dim y As Integer = 6
    Dim cont As Integer
    Dim c As Integer = 1
    Dim contCur As Integer = 1
    Dim contArea As Integer = 0
    Dim i As Integer = -1
    Dim sw As Integer = 0
    Dim cadena As String = ""
    Dim letra As String = "Z"
    Dim num As Integer = -1
    Dim nombreCur As String = "abc"
    Dim lmax As List(Of Alumno) = Nothing
    Dim max As Integer = 0
    Dim proc As Process()
    Dim contador As Integer = 0

    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing

    Try
      m_excel = New Microsoft.Office.Interop.Excel.Application

      obj = CType(Me.cboGrado.SelectedItem, Grado)
      If Me.cboSeccion.SelectedIndex > 0 And Me.cboCurso.SelectedIndex > 0 Then
        lCur = rnD.ListarCursosArea1(New DocenteCarga(0, New CargaAcademica(0, New Curso(0, "", 0, _
                                        New AreaDRE(CType(Me.cboCurso.SelectedItem, AreaDRE).Codigo)) _
                              , New Seccion(New AnioLectivo(CType(Me.cboAnio.SelectedItem, AnioLectivo).anio), _
                                New Grado(obj.Codigo), CType(Me.cboSeccion.SelectedItem, Seccion).Letra)), _
                              New PeriodoAcademico(CType(Me.cboPeriodo.SelectedItem, PeriodoAcademico).Codigo, _
                                      Now, Now, True, "", "", "")))
        sw = 1
      ElseIf Me.cboSeccion.SelectedIndex > 0 And Me.cboCurso.SelectedIndex = 0 Then
        lCur = rnD.ListarCursosArea2(New DocenteCarga(0, New CargaAcademica(0, New Curso(0, "", 0, New AreaDRE()) _
                              , New Seccion(New AnioLectivo(CType(Me.cboAnio.SelectedItem, AnioLectivo).anio), _
                                New Grado(obj.Codigo), CType(Me.cboSeccion.SelectedItem, Seccion).Letra)), _
                              New PeriodoAcademico(CType(Me.cboPeriodo.SelectedItem, PeriodoAcademico).Codigo, _
                                      Now, Now, True, "", "", "")))
        sw = 2
      ElseIf Me.cboSeccion.SelectedIndex = 0 And (Me.cboCurso.SelectedIndex = 0 Or Me.cboCurso.SelectedIndex = -1) Then
        lCur = rnD.ListarCursosArea3(New DocenteCarga(0, New CargaAcademica(0, New Curso() _
                              , New Seccion(New AnioLectivo(CType(Me.cboAnio.SelectedItem, AnioLectivo).anio), _
                                New Grado(obj.Codigo), CChar(""))), _
                              New PeriodoAcademico(CType(Me.cboPeriodo.SelectedItem, PeriodoAcademico).Codigo, _
                                      Now, Now, True, "", "", "")))
        sw = 3
      End If

      Libro = Nothing
      Hoja = Nothing

      Libro = m_excel.Workbooks.Add(AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Resumen_Trimestral_Sec.xls")
      Me.pbAvance.Value = 5
      'abrir un libro por cada seccion
      For Each Cur As DocenteCarga In lCur
        contador += 1
        If num <> Cur.Carga.Curso.CodigoAreaDre.Codigo And _
              (letra <> Cur.Carga.Seccion.Letra Or letra = Cur.Carga.Seccion.Letra) Then

          contArea += 1
          'para mostrar en el segundo caso
          If contCur > 1 Then
            MostrarPromedioFinal(Hoja, k, y, contCur - 1, cont, lCap.Count)
            Hoja.Protect(clave)
            InicializarPromediosFinales()
          End If
          'para mostrar en el segundo caso

          contCur = 1

          If sw = 4 And letra <> Cur.Carga.Seccion.Letra Then
            Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
            Hoja.Select()
            Hoja.Delete()
            Hoja = CType(Libro.Worksheets(1), Worksheet)
            Hoja.Select()

            m_excel.ScreenUpdating = True
            m_excel.ActiveWorkbook.SaveAs(Me.cboAnio.Text.Trim & "_" & Me.cboPeriodo.Text.Trim & "_Areas_Sec_" & _
                        CType(Me.cboGrado.SelectedItem, Grado).Numero & letra & ".xls", _
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)

            contArea = 1
            Libro = Nothing
            Hoja = Nothing

            Libro = m_excel.Workbooks.Add(AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Resumen_Trimestral_Sec.xls")
          End If

          m_excel.ScreenUpdating = False
          m_excel.DisplayAlerts = False

          letra = Cur.Carga.Seccion.Letra
          num = Cur.Carga.Curso.CodigoAreaDre.Codigo
          nombreCur = Cur.Carga.Curso.Nombre

          Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
          Hoja.Select()
          Hoja.Copy(, Hoja)

          k = 7
          y = 6

          lAlu = rnM.ListarAlumnosCurso(New DocenteCarga(Cur.Codigo, New CargaAcademica(0, New Curso(Cur.Carga.Curso.Codigo), _
            New Seccion(New AnioLectivo(CType(Me.cboAnio.SelectedItem, AnioLectivo).anio), New Grado(obj.Codigo), Cur.Carga.Letra)) _
            , New PeriodoAcademico(CType(Me.cboPeriodo.SelectedItem, PeriodoAcademico).Codigo)))

          lmax = rnA.ListarAlumnosSeccion(New Seccion(New AnioLectivo(Me.cboAnio.Text.Trim) _
                                            , New Grado(obj.Codigo), Cur.Carga.Letra))

          InicializarVectorAlumnos()
          Hoja.Unprotect(clave)
          MostrarAlumnosCurso(lAlu, Hoja)
        Else

          If num = Cur.Carga.Curso.CodigoAreaDre.Codigo And letra = Cur.Carga.Seccion.Letra _
                     And nombreCur = Cur.Carga.Curso.Nombre Then  'And (sw = 4 Or sw = 2)

            lAlu = rnM.ListarAlumnosCurso(New DocenteCarga(Cur.Codigo, New CargaAcademica(0, New Curso(Cur.Carga.Curso.Codigo), _
                          New Seccion(New AnioLectivo(CType(Me.cboAnio.SelectedItem, AnioLectivo).anio), New Grado(obj.Codigo), Cur.Carga.Letra)) _
                          , New PeriodoAcademico(CType(Me.cboPeriodo.SelectedItem, PeriodoAcademico).Codigo)))

            If lmax.count <> lAlu.Count Then
              MostrarPromedioFinal(Hoja, k, y, contCur - 1, cont, lCap.Count)
              Hoja.Protect(clave)
              InicializarPromediosFinales()

              m_excel.ScreenUpdating = False
              m_excel.DisplayAlerts = False

              contArea += 1

              contCur = 1

              'm_excel.ScreenUpdating = True
              'm_excel.DisplayAlerts = True

              letra = Cur.Carga.Seccion.Letra
              num = Cur.Carga.Curso.CodigoAreaDre.Codigo

              Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
              Hoja.Select()
              Hoja.Copy(, Hoja)

              k = 7
              y = 6

              InicializarVectorAlumnos()
              Hoja.Unprotect(clave)
              MostrarAlumnosCurso(lAlu, Hoja)

            Else
              Cur.Carga.Curso.Nombre = Cur.Nombre
            End If
          End If
        End If

        Hoja.Unprotect(clave)
        Hoja.Range("C3").Value = "Área: " & Cur.Carga.Curso.CodigoAreaDre.Nombre

        lCap = rnC.ListarCapacidadesCurso(New Curso(Cur.Carga.Curso.Codigo))

        c = 1

        InicializarPromedios()
        For Each cap As Capacidad In lCap
          lNot = rnN.ListarNotasArea(New NotaCapacidad(0, CDbl(0), Now, True, _
                  New Matricula(0, Now, New Grado(obj.Codigo), _
                                New Alumno(), New AnioLectivo(), Cur.Carga.Seccion.Letra _
                                , 0, True), _
                  New PeriodoAcademico(CType(Me.cboPeriodo.SelectedItem, PeriodoAcademico).Codigo), _
                  New Personal(), New Capacidad(cap.Codigo), New Unidad(0, "", True, _
                                            New PeriodoAcademico(), _
                                            New DocenteCarga(Cur.Codigo))))
          cont = lAlu.Count
          Hoja.Range(Hoja.Cells(k - 1, y), Hoja.Cells(k - 1, y)).Value = "C" & CStr(c)

          Hoja.Range(Hoja.Cells(k - 1, y), Hoja.Cells(k - 1, y)).ColumnWidth = 4
          For Each nc As NotaCapacidad In lNot
            Do
              i += 1 'para avanzar el vector 
              If vectorAlu(i) = nc.Matricula.NroOrden Then
                Hoja.Range(Hoja.Cells(k, y), Hoja.Cells(k, y)).Value = System.Math.Round(nc.Promedio, 2)
                vectorProm(k) = vectorProm(k) + System.Math.Round(nc.Promedio, 2)
                vectorPCap(k, c) = vectorPCap(k, c) + System.Math.Round(nc.Promedio, 2)
              Else
                vectorProm(k) = vectorProm(k) + 0.0
                vectorPCap(k, c) = vectorPCap(k, c) + 0.0
              End If
              k += 1
            Loop Until (vectorAlu(i) = nc.Matricula.NroOrden)
          Next
          i = -1
          k = 7
          y += 1
          c += 1 ''para el numero de capacidad

          If c <= lCap.Count Then
            Hoja.Range(Hoja.Cells(k - 1, y), Hoja.Cells(k - 1, y)).Value = "C" & CStr(c)
          End If
        Next

        If c > lCap.Count Then
          Hoja.Range(Hoja.Cells(k - 1, y), Hoja.Cells(k - 1, y)).ColumnWidth = 6
          Hoja.Range(Hoja.Cells(k - 1, y), Hoja.Cells(k - 1, y)).Value = "Prom."

          MostrarPromedio(Hoja, k, y, cont, lCap.Count)

          ''Mostrar el nombre del curso
          Hoja.Range(Hoja.Cells(k - 2, y - lCap.Count), Hoja.Cells(k - 2, y)).Merge()
          If InStr(Cur.Carga.Curso.Nombre, "Artistica") > 0 Or InStr(Cur.Carga.Curso.Nombre, "Artística") > 0 _
                    Or InStr(Cur.Carga.Curso.Nombre, "Arte") > 0 Or InStr(Cur.Carga.Curso.Nombre, "artistica") > 0 _
                    Or InStr(Cur.Carga.Curso.Nombre, "artística") > 0 _
                    Or InStr(Cur.Carga.Curso.Nombre, "arte") > 0 Then
            Cur.Carga.Curso.Nombre = Cur.Nombre
          End If
          Hoja.Range(Hoja.Cells(k - 2, y - lCap.Count), Hoja.Cells(k - 2, y)).Value = Cur.Carga.Curso.Nombre
          y += 1

          Me.pbAvance.Value += 1
        End If
        If Me.pbAvance.Value > 90 And Me.pbAvance.Value <= 100 Then
          Me.pbAvance.Value -= 10
        End If
        Hoja.Range("C1:W1").Merge()
        Hoja.Range("C1").Value = "RESUMEN TRIMESTRAL DE NOTAS POR AREA / " _
                                   & Me.cboAnio.Text & " - " & CType(Me.cboPeriodo.SelectedItem, PeriodoAcademico).Siglas.Chars(1)
        Hoja.Range("L3:S3").Merge()
        Hoja.Range("L3").Value = "Grado: " & obj.Numero & " " & _
                                   Cur.Carga.Seccion.Letra & " Secundaria"

        If lCur.Count = 1 Then
          If Cur.Carga.Curso.Nombre.Length < 30 Then
            Hoja.Name = Cur.Carga.Curso.CodigoAreaDre.Nombre
          Else
            Hoja.Name = Cur.Carga.Curso.CodigoAreaDre.Nombre.Substring(0, 30)
          End If
        Else
          Hoja.Name = CStr(contArea) & "." & Cur.Carga.Curso.CodigoAreaDre.Nombre.Substring(0, 4)
        End If

        ''Mostrar los promedios finales
        contCur += 1

        m_excel.DisplayAlerts = False
        ''guardar el archivo
        If sw = 1 And lCur.Count = contador Then
          MostrarPromedioFinal(Hoja, k, y, contCur - 1, cont, lCap.Count)
          Hoja.Protect(clave)
          InicializarPromediosFinales()

          Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
          Hoja.Select()
          Hoja.Delete()
          Hoja = CType(Libro.Worksheets(1), Worksheet)
          Hoja.Select()

          m_excel.ScreenUpdating = True


          If Cur.Carga.Curso.CodigoAreaDre.Nombre.Length <= 12 Then
            cadena = Cur.Carga.Curso.CodigoAreaDre.Nombre
          Else
            If InStr(Cur.Carga.Curso.CodigoAreaDre.Nombre, "Art") > 0 Or InStr(Cur.Carga.Curso.CodigoAreaDre.Nombre, "art") > 0 Then
              cadena = "Ed. Art."
            ElseIf InStr(Cur.Carga.Curso.CodigoAreaDre.Nombre, "Trab") > 0 Or InStr(Cur.Carga.Curso.CodigoAreaDre.Nombre, "trab") > 0 Then
              cadena = "Ed. Trab."
            ElseIf InStr(Cur.Carga.Curso.Nombre, "Rel") > 0 Or InStr(Cur.Carga.Curso.Nombre, "rel") > 0 Then
              cadena = "Ed. Relig."
            ElseIf InStr(Cur.Carga.Curso.Nombre, "Fís") > 0 Or InStr(Cur.Carga.Curso.Nombre, "fís") > 0 _
                Or InStr(Cur.Carga.Curso.Nombre, "Fis") > 0 Or InStr(Cur.Carga.Curso.Nombre, "fis") > 0 Then
              cadena = "Ed. Fís."
            ElseIf InStr(Cur.Carga.Curso.Nombre, "Inglés") > 0 Or InStr(Cur.Carga.Curso.Nombre, "inglés") > 0 _
                  Or InStr(Cur.Carga.Curso.Nombre, "Ingles") > 0 Or InStr(Cur.Carga.Curso.Nombre, "ingles") > 0 Then
              cadena = "Idio. Ext."
            ElseIf InStr(Cur.Carga.Curso.CodigoAreaDre.Nombre, "Tecno") > 0 Or InStr(Cur.Carga.Curso.CodigoAreaDre.Nombre, "tecno") > 0 Then
              cadena = "C.T.A."
            ElseIf Cur.Carga.Curso.CodigoAreaDre.Nombre.Length > 12 Then
              cadena = Cur.Carga.Curso.CodigoAreaDre.Nombre.Substring(0, 15)
            End If
          End If

          m_excel.ActiveWorkbook.SaveAs(Me.cboAnio.Text.Trim & "_" & Me.cboPeriodo.Text.Trim & "_Area_" & _
                              cadena & "_S" & _
                      CType(Me.cboGrado.SelectedItem, Grado).Numero & Cur.Carga.Letra & ".xls", _
                      Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)

        ElseIf sw = 3 Then
          sw = 4
        End If


      Next

      If sw = 2 Then
        MostrarPromedioFinal(Hoja, k, y, contCur - 1, lAlu.Count, lCap.Count)
        Hoja.Protect(clave)
        InicializarPromediosFinales()

        Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
        Hoja.Select()
        Hoja.Delete()
        Hoja = CType(Libro.Worksheets(1), Worksheet)
        Hoja.Select()

        m_excel.ScreenUpdating = True
        m_excel.ActiveWorkbook.SaveAs(Me.cboAnio.Text.Trim & "_" & Me.cboPeriodo.Text.Trim & "_Areas_Sec_" & _
                    CType(Me.cboGrado.SelectedItem, Grado).Numero & letra & ".xls", _
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
      End If

      If sw = 4 Then
        MostrarPromedioFinal(Hoja, k, y, contCur - 1, lAlu.Count, lCap.Count)
        Hoja.Protect(clave)
        InicializarPromediosFinales()

        Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
        Hoja.Select()
        Hoja.Delete()
        Hoja = CType(Libro.Worksheets(1), Worksheet)
        Hoja.Select()

        m_excel.ScreenUpdating = True
        m_excel.ActiveWorkbook.SaveAs(Me.cboAnio.Text.Trim & "_" & Me.cboPeriodo.Text.Trim & "_Areas_Sec_" & _
                    CType(Me.cboGrado.SelectedItem, Grado).Numero & letra & ".xls", _
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
      End If

      Me.pbAvance.Value = Me.pbAvance.Maximum
      MessageBox.Show("Archivo exportado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Me.pbAvance.Value = 0
      Libro.Close()
      m_excel.Quit()

    Catch ex As Exception
      Hoja = Nothing
      Libro = Nothing
      m_excel = Nothing
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Question)
      Me.pbAvance.Value = 0
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

      InicializarPromedios()
      InicializarPromediosFinales()
      InicializarVectorAlumnos()
      InicializarVectorPCap()
    End Try
  End Sub

  Private Sub MostrarPromedioFinal(ByVal hoja As Worksheet, ByVal k As Integer, _
                                  ByVal y As Integer, ByVal contCur As Integer, _
                                  ByVal nroAlu As Integer, ByVal nroCap As Integer)

    Dim m As Integer = 1

    For j As Integer = 1 To nroCap
      hoja.Range(hoja.Cells(k - 1, y), hoja.Cells(k - 1, y)).ColumnWidth = 4
      hoja.Range(hoja.Cells(k - 1, y), hoja.Cells(k - 1, y)).Value = "PC" & m
      m = m + 1
      For i As Integer = 7 To nroAlu + 6
        If vectorPCap(i, j) > 0.0 Then
          'hoja.Range(hoja.Cells(k, y), hoja.Cells(k, y)).NumberFormat = "##.00"
          hoja.Range(hoja.Cells(k, y), hoja.Cells(k, y)).Value = System.Math.Round(vectorPCap(i, j) / contCur, 2)
          vectorF(k) = vectorF(k) + System.Math.Round(vectorPCap(i, j) / contCur, 2) '(vectorPCap(i, j) / contCur)
        End If
        k += 1
      Next
      k = 7
      y += 1
    Next

    hoja.Range(hoja.Cells(k - 1, y), hoja.Cells(k - 1, y)).ColumnWidth = 4
    hoja.Range(hoja.Cells(k - 1, y), hoja.Cells(k - 1, y)).Value = "PTA"

    For i As Integer = 7 To nroAlu + 6
      If vectorF(i) > 0.0 Then
        'hoja.Range(hoja.Cells(k, y), hoja.Cells(k, y)).NumberFormat = "##.00"
        hoja.Range(hoja.Cells(k, y), hoja.Cells(k, y)).Value = System.Math.Round(vectorF(k) / nroCap, 2)
      End If
      k += 1
    Next
    k = 7
    y += 1

    ''MOstrar el promedio trimestral final

    hoja.Range(hoja.Cells(k - 2, y), hoja.Cells(k - 1, y)).ColumnWidth = 4
    hoja.Range(hoja.Cells(k - 2, y), hoja.Cells(k - 1, y)).Merge()
    hoja.Range(hoja.Cells(k - 2, y), hoja.Cells(k - 1, y)).Value = "FINAL"

    For i As Integer = 7 To nroAlu + 6
      If vectorF(i) > 0.0 Then
        hoja.Range(hoja.Cells(k, y), hoja.Cells(k, y)).NumberFormat = "##"
        hoja.Range(hoja.Cells(k, y), hoja.Cells(k, y)).Value = (vectorF(k)) / nroCap 'System.Math.Round((vectorF(k)) / nroCap, 0)
        hoja.Range(hoja.Cells(k, y), hoja.Cells(k, y)).Interior.Color = RGB(0, 255, 0)
      End If
      k += 1
    Next
    k = 7
    y += 1
    InicializarPromedioTotal()
    InicializarPromediosFinales()
    InicializarVectorPCap()


    hoja.Range(hoja.Cells(k - 2, y - (nroCap + 2)), hoja.Cells(k - 2, y - 2)).Merge()
    hoja.Range(hoja.Cells(k - 2, y - (nroCap + 2)), hoja.Cells(k - 2, y - 2)).Value = "Prom. Finales Cap."

    MostrarBordes(hoja, k, y, nroAlu)

  End Sub

  Private Sub InicializarVectorPCap()
    For i As Integer = 0 To 70
      For j As Integer = 0 To 5
        vectorPCap(i, j) = 0
      Next
    Next
  End Sub

  Private Sub InicializarPromedioTotal()
    For j As Integer = 0 To 70
      vectorF(j) = 0
    Next
  End Sub

  Private Sub MostrarBordes(ByVal hoja As Worksheet, ByVal k As Integer, _
                            ByVal y As Integer, ByVal nroAlu As Integer)
    k = 5
    'y += 1
    'dibujar bordes de celdas
    With hoja.Range(hoja.Cells(k, 1), hoja.Cells(nroAlu + k + 1, y - 1))
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
    With hoja.Range(hoja.Cells(k, 1), hoja.Cells(k + 1, y - 1))
      .Interior.Color = RGB(153, 204, 255)
    End With

  End Sub

  Private Sub MostrarPromedio(ByVal hoja As Worksheet, ByVal k As Integer, _
                              ByVal y As Integer, ByVal cont As Integer, ByVal nroCap As Integer)
    Dim prom As Double = -1

    For i As Integer = k To cont + 6
      If vectorProm(i) > 0.0 Then
        prom = System.Math.Round(vectorProm(i) / nroCap, 2)
        'hoja.Range(hoja.Cells(k, y), hoja.Cells(k, y)).NumberFormat = "##.00"
        hoja.Range(hoja.Cells(k, y), hoja.Cells(k, y)).Value = prom
        vectorPC(i) = vectorPC(i) + prom
        hoja.Range(hoja.Cells(k, y), hoja.Cells(k, y)).Interior.Color = RGB(255, 255, 102)
      End If
      k += 1
    Next
  End Sub

  Private Sub InicializarPromedios()
    For i As Integer = 0 To 70
      vectorProm(i) = 0
    Next
  End Sub

  Private Sub InicializarPromediosFinales()
    For i As Integer = 0 To 70
      vectorPC(i) = 0
    Next
  End Sub

  Private Sub MostrarAlumnosCurso(ByVal listAlu As List(Of Matricula), ByVal hoja As Worksheet)
    Dim j As Integer = 7
    Dim i As Integer = 0

    m_excel.ScreenUpdating = True
    For Each a As Matricula In listAlu
      'hoja.Range("A" & j).ColumnWidth = 3
      hoja.Range("A" & j).Value = a.NroOrden
      vectorAlu(i) = a.NroOrden
      hoja.Range("B" & j).Value = a.Alumno.NombreCompleto
      j += 1
      i += 1
    Next
  End Sub

  Private Sub InicializarVectorAlumnos()
    For i As Integer = 0 To 70
      vectorAlu(i) = 0
    Next
  End Sub

End Class