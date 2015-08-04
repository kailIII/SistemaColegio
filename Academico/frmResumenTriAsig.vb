Imports Microsoft.Office.Interop.Excel

Public Class frmResumenTriAsig

  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing
  Private Const CELDAINICIO As String = "A8"
  Private Const clave As String = "ceti"

  Private lAlu As List(Of Matricula) = Nothing
  Private vectorProm(70) As Double
  Private vectorPC(70, 5) As Double
  Private TieneNotas(70) As Boolean
  Private vectorPromedio(70) As Double
  Private vectorAlu(70) As Integer

  Private mDialogoGuardar As SaveFileDialog

  Public WriteOnly Property DialogoGuardar() As SaveFileDialog
    Set(ByVal value As SaveFileDialog)
      Me.mDialogoGuardar = value
    End Set
  End Property

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub frmResumenTriAsig_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    m_excel = Nothing
  End Sub

  Private Sub frmResumenTriAsig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.MostrarImagenes()
    Me.ListarAnios()
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
      'lg.Insert(0, New Grado(0, 0, "Seleccionar todos", 0))
      Me.cboGrado.DisplayMember = "Nombre"
      Me.cboGrado.ValueMember = "Nombre"
      Me.cboGrado.DataSource = lg
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
        Me.cboPeriodo.SelectedValue = modPrincipal.mOPeriodoActual.Siglas
      End If

      Me.ListarGrados()
    End If
  End Sub

  Private Sub cboSeccion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSeccion.SelectedIndexChanged
    If Me.cboSeccion.SelectedIndex > 0 Then
      Me.cboCursoSeccion.Enabled = True
      ListarDocentesSeccion()
    Else
      If Me.cboCursoSeccion.SelectedIndex > -1 Then
        Me.cboCursoSeccion.SelectedIndex = 0
      End If
      Me.cboCursoSeccion.Enabled = False
    End If
  End Sub

  Private Sub ListarDocentesSeccion()
    Dim obj As New RNDocenteCarga
    Dim ldc As List(Of DocenteCarga) = Nothing
    Dim anio As AnioLectivo

    If Me.cboSeccion.Items.Count > 0 Then
      anio = DirectCast(Me.cboAnio.SelectedItem, AnioLectivo)
      ldc = obj.ListarCursoDocente(
              New DocenteCarga(0, New CargaAcademica(0, Nothing,
                                                     New Seccion(anio, DirectCast(Me.cboGrado.SelectedItem, Grado),
                                                                 CType(Me.cboSeccion.SelectedItem, Seccion).Letra)
                                                               ), _
                              New PeriodoAcademico(CType(Me.cboPeriodo.SelectedItem, PeriodoAcademico).Codigo, _
                                      Now, Now, True, anio.Anio, "", "")))
      If ldc IsNot Nothing Then
        If ldc.Count > 0 Then
          ldc.Insert(0, New DocenteCarga(0, "", New Docente(0, "", "Todos", ""), _
                    New CargaAcademica(0, "Seleccionar"), New PeriodoAcademico()))
          Me.cboCursoSeccion.DisplayMember = "CursoDocente"
          Me.cboCursoSeccion.ValueMember = "CursoDocente"
          Me.cboCursoSeccion.DataSource = ldc
        End If
      End If
    End If
  End Sub

  Private Sub InicializarVectorAlumnos()
    For i As Integer = 0 To 70
      vectorAlu(i) = 0
    Next
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    If Me.tabListado.SelectedIndex = 1 Then
      Me.ExportarSeccion()
    Else
      If Me.cboDocente.SelectedIndex > -1 Then
        Me.ExportarDocente()
      End If
    End If
  End Sub

  Private Sub MostrarPromediosFinales(ByVal hoja As Worksheet, ByVal k As Integer, ByVal y As Integer, _
                                ByVal nroA As Integer, ByVal nroU As Integer, ByVal nroC As Integer)
    Dim m As Integer = 1

    For j As Integer = 1 To nroC
      hoja.Range(hoja.Cells(k - 1, y), hoja.Cells(k - 1, y)).ColumnWidth = 4
      hoja.Range(hoja.Cells(k - 1, y), hoja.Cells(k - 1, y)).Value = "PC" & m
      m = m + 1
      For i As Integer = 7 To nroA + 6
        'If vectorPC(i, j) > 0.0 Then
        If TieneNotas(i) = True Then
          'hoja.Range(hoja.Cells(k, y), hoja.Cells(k, y)).NumberFormat = "##.00"
          hoja.Range(hoja.Cells(k, y), hoja.Cells(k, y)).Value = System.Math.Round(vectorPC(i, j) / nroU, 2)
          vectorPromedio(k) = vectorPromedio(k) + System.Math.Round(vectorPC(i, j) / nroU, 2) '(vectorPC(i, j) / nroU)
        End If
        'm_excel.ScreenUpdating = True
        'm_excel.Visible = True
        k += 1
      Next
      k = 7
      y += 1
    Next

    hoja.Range(hoja.Cells(k - 1, y), hoja.Cells(k - 1, y)).ColumnWidth = 4
    hoja.Range(hoja.Cells(k - 1, y), hoja.Cells(k - 1, y)).Value = "PT"

    For i As Integer = 7 To nroA + 6
      If vectorPromedio(i) > 0.0 Then
        'hoja.Range(hoja.Cells(k, y), hoja.Cells(k, y)).NumberFormat = "##.00"
        hoja.Range(hoja.Cells(k, y), hoja.Cells(k, y)).Value = System.Math.Round(vectorPromedio(k) / nroC, 2)
      End If
      k += 1
    Next
    k = 7
    y += 1

    ''MOstrar el promedio trimestral final
    hoja.Range(hoja.Cells(k - 1, y), hoja.Cells(k - 1, y)).ColumnWidth = 4
    hoja.Range(hoja.Cells(k - 1, y), hoja.Cells(k - 1, y)).Value = "PTF"

    'm_excel.ScreenUpdating = True
    'm_excel.Visible = True
    For i As Integer = 7 To nroA + 6
      If vectorPromedio(i) > 0.0 Then
        hoja.Range(hoja.Cells(k, y), hoja.Cells(k, y)).NumberFormat = "##"
        hoja.Range(hoja.Cells(k, y), hoja.Cells(k, y)).Value = (vectorPromedio(k)) / nroC 'System.Math.Round((vectorPromedio(k)) / nroC, 0)
        hoja.Range(hoja.Cells(k, y), hoja.Cells(k, y)).Interior.Color = RGB(0, 255, 0)
      End If
      k += 1
    Next
    k = 7
    y += 1
    InicializarPromedioTotal()
    InicializarPromediosFinales()

    hoja.Range(hoja.Cells(k - 2, y - (nroC + 2)), hoja.Cells(k - 2, y - 1)).Merge()
    hoja.Range(hoja.Cells(k - 2, y - (nroC + 2)), hoja.Cells(k - 2, y - 1)).Value = "Prom. Finales"

    MostrarBordes(hoja, k, y)
  End Sub

  Private Sub InicializarPromedioTotal()
    For j As Integer = 0 To 70
      vectorPromedio(j) = 0
    Next
  End Sub

  Private Sub InicializarPromediosFinales()
    For i As Integer = 0 To 70
      For j As Integer = 0 To 5
        vectorPC(i, j) = 0
      Next
      TieneNotas(i) = True
    Next
  End Sub

  Private Sub InicializarPromedios()
    For i As Integer = 0 To 70
      vectorProm(i) = 0
    Next
  End Sub

  Private Sub MostrarBordes(ByVal hoja As Worksheet, ByVal k As Integer, ByVal y As Integer)
    k = 5
    'dibujar bordes de celdas
    With hoja.Range(hoja.Cells(k, 1), hoja.Cells(lAlu.Count + k + 1, y - 1))
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
        hoja.Range(hoja.Cells(k, y), hoja.Cells(k, y)).Interior.Color = RGB(255, 255, 102)
      Else
        TieneNotas(i) = False
      End If
      k += 1
    Next
  End Sub

  Private Sub MostrarAlumnosCurso(ByVal listAlu As List(Of Matricula), ByVal hoja As Worksheet)
    Dim j As Integer = 7
    Dim i As Integer = 0

    For Each a As Matricula In listAlu
      hoja.Range("A" & j).ColumnWidth = 3
      hoja.Range("A" & j).Value = a.NroOrden
      vectorAlu(i) = a.NroOrden
      hoja.Range("B" & j).Value = a.Alumno.NombreCompleto
      j += 1
      i += 1
    Next
  End Sub

  Private Sub cboPeriodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriodo.SelectedIndexChanged
    Me.cboDocente.SelectedIndex = -1
    Me.cboDocente.DataSource = Nothing

    Me.cboCursoSeccion.SelectedIndex = -1
    Me.cboCursoSeccion.DataSource = Nothing
  End Sub

  Private Sub ExportarSeccion()
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
    Dim i As Integer = -1
    Dim sw As Integer = 0
    Dim letra As String = "Z"
    Dim proc As Process()

    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing

    Try
      m_excel = New Microsoft.Office.Interop.Excel.Application
      'm_excel.ScreenUpdating = True
      'm_excel.Visible = True
      Me.pbAvance.Value = 5
      obj = CType(Me.cboGrado.SelectedItem, Grado)
      If Me.cboSeccion.SelectedIndex > 0 And Me.cboCursoSeccion.SelectedIndex > 0 Then
        lCur.Add(CType(Me.cboCursoSeccion.SelectedItem, DocenteCarga))
        sw = 1
      ElseIf Me.cboSeccion.SelectedIndex > 0 And Me.cboCursoSeccion.SelectedIndex = 0 Then
        lCur = rnD.ListarCursoDocente(New DocenteCarga(0, New CargaAcademica(0, New Curso() _
                              , New Seccion(New AnioLectivo(CType(Me.cboAnio.SelectedItem, AnioLectivo).Anio), _
                                New Grado(obj.Codigo), CType(Me.cboSeccion.SelectedItem, Seccion).Letra)), _
                              New PeriodoAcademico(CType(Me.cboPeriodo.SelectedItem, PeriodoAcademico).Codigo, _
                                      Now, Now, True, "", "", "")))
        sw = 2
      ElseIf Me.cboSeccion.SelectedIndex = 0 And (Me.cboCursoSeccion.SelectedIndex = 0 Or Me.cboCursoSeccion.SelectedIndex = -1) Then
        lCur = rnD.ListarCursoDocente2(New DocenteCarga(0, New CargaAcademica(0, New Curso() _
                              , New Seccion(New AnioLectivo(CType(Me.cboAnio.SelectedItem, AnioLectivo).Anio), _
                                New Grado(obj.Codigo), CChar(""))), _
                              New PeriodoAcademico(CType(Me.cboPeriodo.SelectedItem, PeriodoAcademico).Codigo, _
                                      Now, Now, True, "", "", "")))
        sw = 3
      End If

      'abrir un libro por cada seccion
      For Each Cur As DocenteCarga In lCur

        If letra <> Cur.Carga.Letra Then
          contCur = 1
          If sw = 4 Then
            Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
            Hoja.Select()
            Hoja.Delete()  ''borra la ultima hoja
            Hoja = CType(Libro.Worksheets(1), Worksheet)
            Hoja.Select()   ''selecciona la primera hoja

            m_excel.ScreenUpdating = True
            m_excel.ActiveWorkbook.SaveAs(Me.cboAnio.Text.Trim & "_" & Me.cboPeriodo.Text.Trim & "_" & "Sec_" & _
                        CType(Me.cboGrado.SelectedItem, Grado).Numero & letra & ".xls", _
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
          End If
          Libro = Nothing
          Hoja = Nothing

          Libro = m_excel.Workbooks.Add(AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Resumen_Trimestral_Sec.xls")
          m_excel.ScreenUpdating = False  ''habilitar
          m_excel.DisplayAlerts = False
          letra = Cur.Carga.Seccion.Letra
        End If
        Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
        Hoja.Select()
        Hoja.Copy(, Hoja)

        k = 7
        y = 6

        Hoja.Unprotect(clave)
        Hoja.Range("C3").Value = "Prof. " & Cur.Docente.NombreCompleto

        lAlu = rnM.ListarAlumnosCurso(New DocenteCarga(Cur.Codigo, New CargaAcademica(0, New Curso(Cur.Carga.Curso.Codigo), _
            New Seccion(New AnioLectivo(CType(Me.cboAnio.SelectedItem, AnioLectivo).Anio), New Grado(obj.Codigo), Cur.Carga.Letra)) _
            , New PeriodoAcademico(CType(Me.cboPeriodo.SelectedItem, PeriodoAcademico).Codigo)))

        Me.InicializarVectorAlumnos()
        Me.MostrarAlumnosCurso(lAlu, Hoja)

        lUni = rnU.ListarUnidadesCurso(New Unidad(0, "", False, New PeriodoAcademico(CType(Me.cboPeriodo.SelectedItem, PeriodoAcademico).Codigo) _
                , New DocenteCarga(0, "", New Docente(Cur.Docente.Codigo), New CargaAcademica(0, New Curso(Cur.Carga.Curso.Codigo), _
                New Seccion(New AnioLectivo(CType(Me.cboAnio.SelectedItem, AnioLectivo).Anio), New Grado(obj.Codigo), Cur.Carga.Letra)), _
                New PeriodoAcademico(CType(Me.cboPeriodo.SelectedItem, PeriodoAcademico).Codigo))))
        If lUni.Count > 0 Then
          InicializarPromediosFinales()
          For Each uni As Unidad In lUni
            lCap = rnC.ListarCapacidadesCurso(New Curso(Cur.Carga.Curso.Codigo))
            InicializarPromedios()
            c = 1

            For Each cap As Capacidad In lCap
              lNot = rnN.ListarNotasCurso(New NotaCapacidad(0, 0, Now, True, _
                      New Matricula(0, Now, obj, Nothing, Nothing, Cur.Carga.Seccion.Letra, 0, True), _
                      CType(Me.cboPeriodo.SelectedItem, PeriodoAcademico), _
                      Nothing, cap, New Unidad(uni.Numero, "", True, Nothing, Cur)))
              cont = lAlu.Count
              Hoja.Range(Hoja.Cells(k - 1, y), Hoja.Cells(k - 1, y)).Value = "C" & CStr(c)

              Hoja.Range(Hoja.Cells(k - 1, y), Hoja.Cells(k - 1, y)).ColumnWidth = 2

              For Each nc As NotaCapacidad In lNot
                Do
                  i += 1 'para avanzar el vector 
                  If vectorAlu(i) = nc.Matricula.NroOrden Then
                    Hoja.Range(Hoja.Cells(k, y), Hoja.Cells(k, y)).NumberFormat = "##"
                    Hoja.Range(Hoja.Cells(k, y), Hoja.Cells(k, y)).Value = nc.Promedio
                    vectorProm(k) = vectorProm(k) + nc.Promedio
                    vectorPC(k, c) = vectorPC(k, c) + nc.Promedio
                  Else
                    vectorProm(k) = vectorProm(k) + 0
                    vectorPC(k, c) = vectorPC(k, c) + 0
                  End If
                  k += 1
                Loop Until (vectorAlu(i) = nc.Matricula.NroOrden)
              Next
              i = -1
              k = 7
              y += 1
              c += 1 ''para el numero de capacidad
            Next

            'Mostrar el promedio de unidad
            Hoja.Range(Hoja.Cells(k, y), Hoja.Cells(k, y)).ColumnWidth = 4 ''col para promedio
            Hoja.Range(Hoja.Cells(k - 1, y), Hoja.Cells(k - 1, y)).Value = "PU" & CStr(uni.Numero)
            MostrarPromedio(Hoja, k, y, cont, lCap.Count)

            ''mostar cabecera unidad
            Hoja.Range(Hoja.Cells(k - 2, y - lCap.Count), Hoja.Cells(k - 2, y)).Merge()
            Hoja.Range(Hoja.Cells(k - 2, y - lCap.Count), Hoja.Cells(k - 2, y)).Value = "Unidad " & CStr(uni.Numero)

            y += 1
          Next
          Me.pbAvance.Value += 2
        End If
        If Me.pbAvance.Value > 90 And Me.pbAvance.Value <= 100 Then
          Me.pbAvance.Value -= 10
        End If
        Hoja.Range("C1:W1").Merge()
        Hoja.Range("C1").Value = "RESUMEN TRIMESTRAL DE NOTAS POR UNIDAD, EN CADA CURSO / " _
                                   & Me.cboAnio.Text & " - " & CType(Me.cboPeriodo.SelectedItem, PeriodoAcademico).Siglas.Chars(1)
        Hoja.Range("L3:S3").Merge()
        Hoja.Range("L3").Value = "Curso: " & Cur.Carga.Curso.Nombre & " - " & obj.Numero & " " & _
                                   Cur.Carga.Seccion.Letra & " Secundaria"
        If lCur.Count = 1 Then
          If Cur.Carga.Curso.Nombre.Length < 30 Then
            Hoja.Name = Cur.Carga.Curso.Nombre
          Else
            Hoja.Name = Cur.Carga.Curso.Nombre.Substring(0, 30)
          End If
        Else
          Hoja.Name = CStr(contCur) & "." & Cur.Carga.Curso.Nombre.Substring(0, 4)
        End If
        ''Mostrar los promedios finales
        contCur += 1
        If lUni.Count > 0 Then
          MostrarPromediosFinales(Hoja, k, y, lAlu.Count, lUni.Count, lCap.Count)
        End If
        Hoja.Protect(clave)
        ''guardar el archivo
        If sw = 1 Then
          Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
          Hoja.Select()
          Hoja.Delete()  ''borra la ultima hoja
          Hoja = CType(Libro.Worksheets(1), Worksheet)
          Hoja.Select()   ''selecciona la primera hoja

          m_excel.ScreenUpdating = True
          m_excel.ActiveWorkbook.SaveAs(Me.cboAnio.Text.Trim & "_" & Me.cboPeriodo.Text.Trim & "_" & _
                      Cur.Docente.Nombre.Chars(0) & Cur.Docente.ApellidoPaterno & "_" & _
                      Cur.Carga.Curso.Nombre.Substring(0, 5) & "_S" & _
                      CType(Me.cboGrado.SelectedItem, Grado).Numero & Cur.Carga.Letra & ".xls", _
                      Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
        ElseIf sw = 3 Then
          sw = 4
        End If
      Next

      If sw = 2 Then
        Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
        Hoja.Select()
        Hoja.Delete()   ''borra la ultima hoja
        Hoja = CType(Libro.Worksheets(1), Worksheet)
        Hoja.Select()   ''selecciona la primera hoja

        m_excel.ScreenUpdating = True
        m_excel.ActiveWorkbook.SaveAs(Me.cboAnio.Text.Trim & "_" & Me.cboPeriodo.Text.Trim & "_" & "Sec_" & _
                    CType(Me.cboGrado.SelectedItem, Grado).Numero & letra & ".xls", _
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
      End If

      If sw = 4 Then
        Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
        Hoja.Select()
        Hoja.Delete()  ''borra la primera hoja
        Hoja = CType(Libro.Worksheets(1), Worksheet)
        Hoja.Select()   ''selecciona la primera hoja

        m_excel.ScreenUpdating = True
        m_excel.ActiveWorkbook.SaveAs(Me.cboAnio.Text.Trim & "_" & Me.cboPeriodo.Text.Trim & "_" & "Sec_" & _
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
    End Try
  End Sub

  Private Sub ListarDocentesSecundaria()
    Dim rn As New RNDocente
    Dim docs As List(Of Docente)

    Try
      docs = rn.ListarDocentesSecundaria(DirectCast(Me.cboPeriodo.SelectedItem, PeriodoAcademico))
      If docs.Count > 0 Then
        Me.cboDocente.DataSource = docs
        Me.cboDocente.ValueMember = "Codigo"
        Me.cboDocente.DisplayMember = "NombreCompleto"
        Me.cboDocente.SelectedIndex = -1
      Else
        MessageBox.Show("No se han registrado docentes en este nivel", Me.Text, MessageBoxButtons.OK)
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK)
    Finally
      rn = Nothing
    End Try

  End Sub

  Private Sub cboDocente_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDocente.Enter
    If Me.cboDocente.DataSource Is Nothing Then
      Me.ListarDocentesSecundaria()
    End If
  End Sub

  Private Sub tabListado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabListado.SelectedIndexChanged
    If Me.tabListado.SelectedIndex = 1 Then
      Me.ListarGrados()
    End If
  End Sub

  Private Sub cboDocente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDocente.SelectedIndexChanged
    Me.cboCursoDocente.SelectedIndex = -1
    Me.cboCursoDocente.DataSource = Nothing
  End Sub

  Private Sub cboCursoDocente_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCursoDocente.Enter
    Dim objRN As RNDocenteCarga
    Dim cursos As List(Of DocenteCarga)

    If Me.cboDocente.SelectedIndex > -1 Then
      objRN = New RNDocenteCarga
      cursos = objRN.ListarCargaSeccion2(DirectCast(Me.cboPeriodo.SelectedItem, PeriodoAcademico), DirectCast(Me.cboDocente.SelectedItem, Docente))
      If cursos.Count > 0 Then
        Me.cboCursoDocente.DisplayMember = "CursoSeccion"
        Me.cboCursoDocente.ValueMember = "Codigo"
        Me.cboCursoDocente.DataSource = cursos
      Else
        Me.cboCursoDocente.DataSource = Nothing
      End If
    End If
  End Sub

  Private Sub cboCursoSeccion_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCursoSeccion.Enter
    If Me.cboPeriodo.SelectedIndex > -1 Then
      Me.ListarDocentesSeccion()
    End If
  End Sub

  Private Sub ExportarDocente()
    Dim rn As RNCargaAcademica
    Dim dt As Data.DataTable
    Dim unidades As New List(Of Unidad)
    Dim capacidades As New List(Of Capacidad)

    rn = New RNCargaAcademica
    Try
      dt = rn.ListarResumenPeriodo(unidades, capacidades, DirectCast(Me.cboCursoDocente.SelectedItem, DocenteCarga))
      Me.ExportarDatos(unidades, capacidades, dt)
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK)
    Finally
      rn = Nothing
    End Try
  End Sub

  Private Sub ExportarDatos(ByVal unidades As List(Of Unidad), ByVal capacidades As List(Of Capacidad), ByVal dt As Data.DataTable)
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing

    Try
      If unidades IsNot Nothing AndAlso unidades.Count > 0 AndAlso
        capacidades IsNot Nothing AndAlso capacidades.Count > 0 AndAlso
        dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

        Me.mDialogoGuardar.Filter = "Archivos (*.xlsx)|*.xlsx"
        Me.mDialogoGuardar.FileName = "Resumen de promedios - " & Me.cboCursoDocente.Text & " - " & Me.cboPeriodo.Text & " - " & Me.cboDocente.Text
        m_excel = CrearExcel()
        Libro = AbrirPlantilla(m_excel, Me.mDialogoGuardar, AppDomain.CurrentDomain.BaseDirectory & "Plantillas\ReportePromedioCapacidadesPeriodo.xlsx")
        If Libro IsNot Nothing Then
          Hoja = DirectCast(Libro.Worksheets.Item("Datos"), Worksheet)
          Hoja.Range("B5").Value = "Docente : " & Me.cboDocente.Text
          Hoja.Range("B6").Value = "Curso   : " & Me.cboCursoDocente.Text  'DirectCast(Me.cboCursoDocente.SelectedItem, DocenteCarga).Carga.Curso.Nombre
          Hoja.Range("L6").Value = "Periodo : " & Me.cboAnio.Text & "-" & Me.cboPeriodo.Text
          Me.ExportarCalificaciones(Hoja.Range(CELDAINICIO).Offset(2, 0), dt, unidades, capacidades)
          Me.CrearCabecera(Hoja.Range(CELDAINICIO), unidades, capacidades)
          modExcel.BordesTodo(Hoja.Range(Hoja.Range(CELDAINICIO), Hoja.Range(CELDAINICIO).Offset(dt.Rows.Count, 3 + (unidades.Count + 2) * capacidades.Count)))
          modExcel.CeldaFondo(Hoja.Range(Hoja.Range(CELDAINICIO).Address & ":" &
                                         Hoja.Range(CELDAINICIO).Offset(0, 3 + (unidades.Count + 2) * capacidades.Count).Address
                                         ), 15720111)

          m_excel.ActiveWorkbook.SaveAs(Me.mDialogoGuardar.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault)
          m_excel.ScreenUpdating = True
          MessageBox.Show("Archivo exportado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      Else
        MessageBox.Show("No se encontraron datos que exportar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      If m_excel IsNot Nothing Then
        m_excel.ScreenUpdating = True
        m_excel.Quit()
      End If
      Hoja = Nothing
      Libro = Nothing
      m_excel = Nothing
    End Try
  End Sub

  Private Sub ExportarCalificaciones(ByVal Celda As Range, ByVal dt As System.Data.DataTable, ByVal unidades As List(Of Unidad), ByVal capacidades As List(Of Capacidad))
    Dim celdaIni As Range = Celda
    Dim i As Integer
    Dim iuni As Integer, icap As Integer

    For Each dr As DataRow In dt.Rows
      Celda.Value = dr.Item("NroOrden")
      Celda.Offset(0, 1).Value = dr.Item("Alumno")
      i = 0
      iuni = 1
      For Each uni In unidades
        icap = 1
        For Each cap In capacidades
          With Celda.Offset(0, i + 2)
            .Value = dr.Item("U" & iuni & "C" & icap)
            .NumberFormat = "0"
            .HorizontalAlignment = XlHAlign.xlHAlignRight
          End With
          i += 1
          icap += 1
        Next
        With Celda.Offset(0, i + 2)
          .Value = dr.Item("PU" & iuni)
          .NumberFormat = "0.0000"
          .HorizontalAlignment = XlHAlign.xlHAlignRight
        End With
        modExcel.CeldaFondo(Celda.Offset(0, i + 2), 15720111)
        i += 1
        iuni += 1
      Next
      icap = 1
      For Each cap In capacidades
        With Celda.Offset(0, i + 2)
          .Value = dr.Item("C" & icap)
          .NumberFormat = "0.0000"
          .HorizontalAlignment = XlHAlign.xlHAlignRight
        End With
        i += 1
        icap += 1
      Next
      With Celda.Offset(0, i + 2)
        .Value = dr.Item("promedio")
        modExcel.CeldaFondo(Celda.Offset(0, i + 2), 15720111)
        .NumberFormat = "0.0000"
        .HorizontalAlignment = XlHAlign.xlHAlignRight
      End With
      i += 1
      With Celda.Offset(0, i + 2)
        .Value = dr.Item("promFinal")
        modExcel.CeldaFondo(Celda.Offset(0, i + 2), 15720111)
        .NumberFormat = "0"
        .HorizontalAlignment = XlHAlign.xlHAlignRight
      End With
      Celda = Celda.Offset(1, 0)
    Next
  End Sub

  Private Sub CrearCabecera(ByVal range As Range, ByVal unidades As List(Of Unidad), ByVal capacidades As List(Of Capacidad))
    Dim iuni As Integer, icap As Integer
    Dim i As Integer

    iuni = 1
    i = 1
    For Each uni In unidades
      modExcel.CombinarCeldasNegrita(range.Offset(0, 1 + i), range.Offset(0, 1 + capacidades.Count + i), "Unidad " & iuni)
      icap = 1
      For Each cap In capacidades
        With range.Offset(1, 1 + i)
          .Value = "C" & icap
          modExcel.CeldaFondo(range.Offset(1, 1 + i), 15720111)
          .ColumnWidth = 4.1
          .HorizontalAlignment = XlHAlign.xlHAlignCenter
        End With
        i += 1
        icap += 1
      Next
      With range.Offset(1, 1 + i)
        .Value = "PU" & iuni
        modExcel.CeldaFondo(range.Offset(1, 1 + i), 15720111)
        .ColumnWidth = 8
        .HorizontalAlignment = XlHAlign.xlHAlignCenter
      End With
      i += 1
      iuni += 1
    Next
    modExcel.CombinarCeldasNegrita(range.Offset(0, 1 + i), range.Offset(0, 1 + capacidades.Count - 1 + i), "Promedio")
    icap = 1
    For Each cap In capacidades
      With range.Offset(1, 1 + i)
        .Value = "C" & icap
        modExcel.CeldaFondo(range.Offset(1, 1 + i), 15720111)
        range.Offset(1, 1 + i).ColumnWidth = 8
        .HorizontalAlignment = XlHAlign.xlHAlignCenter
      End With
      i += 1
      icap += 1
    Next
    modExcel.CombinarCeldasNegrita(range.Offset(0, 1 + i), range.Offset(1, 1 + i), "Promedio")
    range.Offset(0, 1 + i).ColumnWidth = 8.5
    i += 1
    modExcel.CombinarCeldasNegrita(range.Offset(0, 1 + i), range.Offset(1, 1 + i), "Prom. Final")
    range.Offset(0, 1 + i).WrapText = True
    range.Offset(0, 1 + i).ColumnWidth = 7
    modExcel.CombinarCeldasNegrita(range.Offset(0, 1), range.Offset(1, 1), "Alumno")
    range.Offset(0, 1).ColumnWidth = 35
    modExcel.CombinarCeldasNegrita(range, range.Offset(1, 0), "N°")
    range.ColumnWidth = 3.9
  End Sub

End Class