Imports Microsoft.Office.Interop.Excel

Public Class frmConsolidadoPeriodoAreaCapacidad
  Implements iReporte

  Private Const clave As String = "CETI"
  Private Const CELDAINICIO As String = "A5"
  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing


  Private Shared frm As frmConsolidadoPeriodoAreaCapacidad
  Private mDialogoGuardar As SaveFileDialog

  Private Areas As List(Of AreaDRE)
  Private Alumnos As List(Of PromedioPeriodoArea)
  Private promediosFinales As List(Of PromedioPeriodo)

  Private Sub New()
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
  End Sub

  Public Shared Function Crear() As frmConsolidadoPeriodoAreaCapacidad
    If frmConsolidadoPeriodoAreaCapacidad.frm Is Nothing Then
      frmConsolidadoPeriodoAreaCapacidad.frm = New frmConsolidadoPeriodoAreaCapacidad
    End If

    Return frmConsolidadoPeriodoAreaCapacidad.frm
  End Function

  Public WriteOnly Property DialogoGuardar() As SaveFileDialog
    Set(ByVal value As SaveFileDialog)
      Me.mDialogoGuardar = value
    End Set
  End Property

  Private Sub PresentarSecciones()
    Dim ListSec As List(Of Seccion)
    Dim objS As New RNSeccion

    ListSec = objS.Leer_NivelAcad(moAnioActual, New Nivel(3), 1)
    cboSeccion.DisplayMember = "numeroletra"
    cboSeccion.ValueMember = "codigoG"
    cboSeccion.DataSource = ListSec
  End Sub

  Private Sub CargarPeriodos(ByVal wAnio As AnioLectivo)
    Dim rnA As New RNAnioLectivo
    Dim lPer As List(Of PeriodoAcademico)

    lPer = rnA.ListarPeriodos(wAnio)
    If lPer.Count > 0 Then
      cboPeriodo.DisplayMember = "Nombre"
      cboPeriodo.ValueMember = "Codigo"
      cboPeriodo.DataSource = lPer
      If mOPeriodoActual IsNot Nothing Then
        Me.cboPeriodo.SelectedValue = mOPeriodoActual.Codigo
      Else
        Me.cboPeriodo.SelectedIndex = -1
      End If
    End If
  End Sub

  Public Sub Presentar() Implements iReporte.Presentar
    Me.PresentarSecciones()
    Me.CargarPeriodos(moAnioActual)
    Me.Show()
    Me.Activate()
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim rs As RNSeccion

    Me.Alumnos = New List(Of PromedioPeriodoArea)
    Me.Areas = New List(Of AreaDRE)
    Me.promediosFinales = New List(Of PromedioPeriodo)
    rs = New RNSeccion
    rs.ListarPromediosCapacidadPeriodo(DirectCast(cboSeccion.SelectedItem, Seccion), DirectCast(Me.cboPeriodo.SelectedItem, PeriodoAcademico), Me.Alumnos, Me.Areas, Me.promediosFinales)
    rs = Nothing
    Me.ExportarPromedios()
  End Sub

  Private Sub ExportarPromedios()
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing
    Dim Cols As Hashtable

    Try
      If Me.Alumnos IsNot Nothing AndAlso Me.Alumnos.Count > 0 Then
        Me.mDialogoGuardar.Filter = "Archivos (*.xls)|*.xls"
        Me.mDialogoGuardar.FileName = "RESUMEN TRIMESTRAL DE NOTAS POR AREA Y SECCIÓN " & Me.cboSeccion.Text & "-" & Me.cboPeriodo.Text

        m_excel = CrearExcel()
        Libro = AbrirPlantilla(m_excel, Me.mDialogoGuardar, AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Consolidado_Periodo_AreaCapacidad.xls")
        If Libro IsNot Nothing Then
          Hoja = DirectCast(Libro.Worksheets.Item(1), Worksheet)

          Hoja.Range("D2").Value = moAnioActual.Anio & " - " & Me.cboPeriodo.Text
          Hoja.Range("D3").Value = Me.cboSeccion.Text
          Hoja.Range("F3").Value = DateAndTime.Now.ToShortDateString
          Cols = New Hashtable
          Me.CrearCabeceraReporte(Hoja.Range(CELDAINICIO), Me.Areas, Cols)
          Me.ExportarDatos(Me.Alumnos, Hoja.Range(CELDAINICIO).Offset(1, 0), Cols)

          Me.m_excel.ActiveWorkbook.SaveAs(Me.mDialogoGuardar.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
          MessageBox.Show("Archivo exportado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.m_excel.ScreenUpdating = True
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
      If Hoja IsNot Nothing Then
        System.Runtime.InteropServices.Marshal.ReleaseComObject(Hoja)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(Libro)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(m_excel)
      End If
      Hoja = Nothing
      Libro = Nothing
      m_excel = Nothing
    End Try
  End Sub

  Private Sub CrearCabeceraReporte(ByVal wCeldaIni As Range, ByVal wAreas As List(Of AreaDRE), ByVal wCols As Hashtable)
    Dim hoja As Worksheet
    Dim cap As Range
    Dim cabeceras As Range
    Dim col As Integer = 0

    hoja = wCeldaIni.Worksheet
    cap = wCeldaIni
    modExcel.CombinarCeldasNegrita(cap, cap.Offset(11, 0), "N°")
    cap = cap.Offset(0, 1)
    modExcel.CombinarCeldasNegrita(cap, cap.Offset(11, 3), "ALUMNO")
    cap = cap.Offset(0, 1)
    For Each a In wAreas
      modExcel.CombinarCeldasNegrita(cap, cap.Offset(0, a.Capacidades.Count), a.Nombre)
      cap = cap.Offset(1, 0)
      For Each c In a.Capacidades
        wCols.Add("C" & c.Codigo, col)
        modExcel.CombinarCeldasNegrita(cap, cap.Offset(10, 0), c.Nombre).Orientation = -90
        cap = cap.Offset(0, 1)
        col += 1
      Next
      wCols.Add(a.Nombre, col)
      col += 1
      modExcel.CombinarCeldasNegrita(cap, cap.Offset(10, 0), "PROMEDIO").Orientation = -90
      cap.ColumnWidth = 5.5
      cap = cap.Offset(-1, 1)
    Next
    modExcel.CombinarCeldasNegrita(cap, cap.Offset(11, 0), "PROMEDIO TRIMESTRE").Orientation = -90
    cap.ColumnWidth = "5.5"
    wCols.Add("PromF", col)
    cap = cap.Offset(0, 1)
    col += 1
    modExcel.CombinarCeldasNegrita(cap, cap.Offset(11, 0), "ORDEN DE MERITO").Orientation = -90
    cap.ColumnWidth = "5.5"
    wCols.Add("Merito", col)
    cap = cap.Offset(0, 1)

    cabeceras = hoja.Range(wCeldaIni, cap.Offset(11, -1))
    modExcel.CeldaFondo(cabeceras, 15720111)
    modExcel.BordesTodo(cabeceras)
  End Sub

  Private Sub ExportarDatos(ByVal wAlumnos As List(Of PromedioPeriodoArea), ByVal wIni As Range, ByVal wCols As Hashtable)
    Dim cap As Range = Nothing
    Dim alu As Range
    Dim fila As Integer = -1
    Dim nro As Integer = -1
    Dim num As Integer = 0

    alu = wIni.Offset(-1, 0)
    Me.pbAvance.Maximum = wAlumnos.Count
    Me.pbAvance.Value = 0
    Me.pbAvance.Visible = True
    For Each al In wAlumnos
      If nro <> al.Matricula.NroOrden Then
        alu = alu.Offset(1, 0)
        alu.Value = al.Matricula.NroOrden
        modExcel.CombinarCeldasNegrita(alu.Offset(0, 1), alu.Offset(0, 4), al.Matricula.Alumno.NombreCompleto).HorizontalAlignment = XlHAlign.xlHAlignLeft
        cap = alu.Offset(0, 5)
        fila = fila + 1
        nro = al.Matricula.NroOrden
      End If
      For Each c In al.PromediosCapacidades
        If c.Promedio < 200 Then
          With cap.Offset(0, CInt(wCols.Item("C" & c.Capacidad.Codigo)))
            .NumberFormat = "00.00"
            .Value = c.Promedio
          End With
        End If
      Next
      If al.Promedio < 200 Then
        With cap.Offset(0, CInt(wCols.Item(al.Area.Nombre)))
          .NumberFormat = "00"
          .Value = al.Promedio
        End With
      End If
      modExcel.CeldaFondo(cap.Offset(0, CInt(wCols.Item(al.Area.Nombre))), 65535)
      Me.pbAvance.Value += 1
    Next
    Me.PresentarPromedioArea(wIni, cap.Offset(1, 0), wCols)

    'alu = wIni.Offset(-1, 0)
    Me.PresentarMerito(wIni, wCols)

    With wIni.Worksheet
      modExcel.BordesTodo(.Range(wIni, wIni.Offset(fila, wCols.Count + 4)))
    End With
    Me.pbAvance.Visible = False
  End Sub

  Private Sub PresentarPromedioArea(ByVal alu As Range, ByVal wFin As Range, ByVal wcols As Hashtable)
    Dim col As Integer

    For Each are As AreaDRE In Me.Areas
      col = CInt(wcols.Item(are.Nombre))
      With wFin.Offset(0, col)
        .Font.Bold = True
        .NumberFormat = "00.00"
        .Formula = "=Promedio(" & alu.Offset(0, 5 + col).Address & ":" & wFin.Offset(-1, 0).Address & ")"
      End With

    Next
  End Sub

  Private Sub PresentarMerito(ByVal alu As Range, ByVal wcols As Hashtable)
    For Each prom As PromedioPeriodo In Me.promediosFinales
      With alu.Offset(0, 5 + CInt(wcols.Item("PromF")))
        .NumberFormat = "00.0000"
        .Value = prom.Promedio
      End With
      alu.Offset(0, 6 + CInt(wcols.Item("PromF"))).Value = prom.OrdenMerito

      alu = alu.Offset(1, 0)
    Next
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub frmConsolidadoPeriodoAreaCapacidad_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmConsolidadoPeriodoAreaCapacidad.frm = Nothing
  End Sub

End Class