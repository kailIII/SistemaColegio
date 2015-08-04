Imports Microsoft.Office.Interop.Excel

Public Class frmEvolucionComportamiento

  Private Const clave As String = "CETI"
  Private Const CELDAINICIO As String = "A5"
  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing

  Private Shared frm As frmEvolucionComportamiento
  Private mDialogoGuardar As SaveFileDialog

  Private Alumnos As System.Data.DataTable

  Private Sub New()
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
  End Sub

  Public Shared Function Crear() As frmEvolucionComportamiento
    If frmEvolucionComportamiento.frm Is Nothing Then
      frmEvolucionComportamiento.frm = New frmEvolucionComportamiento
    End If

    Return frmEvolucionComportamiento.frm
  End Function

  Public WriteOnly Property DialogoGuardar() As SaveFileDialog
    Set(ByVal value As SaveFileDialog)
      Me.mDialogoGuardar = value
    End Set
  End Property

  Private Sub PresentarSecciones()
    Dim ListSec As List(Of Seccion)
    Dim objS As New RNSeccion

    ListSec = objS.Leer_NivelAcad(moAnioActual, moNivel, 1)
    'ListSec.Insert(0, New Seccion)
    cboSeccion.DisplayMember = "numeroletra"
    cboSeccion.ValueMember = "codigoG"
    cboSeccion.DataSource = ListSec
  End Sub

  Public Sub Presentar()
    Me.PresentarSecciones()
    Me.txtAnio.Text = moAnioActual.Anio
    Me.Show()
    Me.Activate()
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim rs As RNSeccion

    rs = New RNSeccion
    'Alumnos = rs.ListarEvolucionComportamiento(DirectCast(cboSeccion.SelectedItem, Seccion))
    rs = Nothing
    Me.ExportarEvolucionComportamiento()
  End Sub

  Private Sub ExportarEvolucionComportamiento()
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing
    Dim Cols As Hashtable

    Try
      If Me.Alumnos IsNot Nothing AndAlso Me.Alumnos.Rows.Count > 0 Then
        Me.mDialogoGuardar.Filter = "Archivos (*.xls)|*.xls"
        Me.mDialogoGuardar.FileName = "CONSOLIDADO ANUAL DE PROMEDIOS DE AREA POR PERIODO " & Me.cboSeccion.Text

        m_excel = CrearExcel()
        Libro = AbrirPlantilla(m_excel, Me.mDialogoGuardar, AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Consolidado_Anio_AreaPeriodo.xls")
        If Libro IsNot Nothing Then
          Hoja = DirectCast(Libro.Worksheets.Item(1), Worksheet)

          Hoja.Range("D2").Value = moAnioActual.Anio
          Hoja.Range("D3").Value = Me.cboSeccion.Text
          Hoja.Range("F3").Value = DateAndTime.Now.ToShortDateString
          Cols = New Hashtable
          'Me.CrearCabeceraReporte(Hoja.Range(CELDAINICIO), Me.Periodos, Cols)
          'Me.ExportarDatos(Me.Alumnos, Hoja.Range(CELDAINICIO).Offset(1, 0), Cols)

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

  Private Sub CrearCabeceraReporte(ByVal wCeldaIni As Range, ByVal wPeriodos As List(Of PeriodoAcademico), ByVal wCols As Hashtable)
    Dim hoja As Worksheet
    Dim celda As Range
    Dim cabeceras As Range
    Dim col As Integer = 0
    Dim cantPeriodos As Integer = wPeriodos.Count

    hoja = wCeldaIni.Worksheet
    celda = wCeldaIni
    modExcel.CombinarCeldasNegrita(celda, celda.Offset(11, 0), "N°")
    celda = celda.Offset(0, 1)
    modExcel.CombinarCeldasNegrita(celda, celda.Offset(11, 3), "ALUMNO")
    celda = celda.Offset(0, 1)
    For Each per In wPeriodos
      modExcel.CombinarCeldasNegrita(celda, celda.Offset(10, 0), per.Nombre).Orientation = -90
      celda = celda.Offset(-1, 1)
      col += 1
    Next
    cabeceras = hoja.Range(wCeldaIni, celda.Offset(11, -1))
    modExcel.CeldaFondo(cabeceras, 15720111)
    modExcel.BordesTodo(cabeceras)
  End Sub

  Private Sub ExportarDatos(ByVal wAlumnos As List(Of PromedioAnioArea), ByVal wIni As Range, ByVal wCols As Hashtable)
    Dim prom As Range = Nothing
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
        prom = alu.Offset(0, 5)
        fila = fila + 1
        nro = al.Matricula.NroOrden
      End If
      For Each pr In al.PromediosPeriodo
        If pr.Promedio < 200 Then
          With prom.Offset(0, wCols.Item(al.Area.Codigo & "-" & pr.Periodo.Codigo))
            .NumberFormat = "00"
            .Value = pr.Promedio
          End With
        End If
      Next
      If al.Promedio < 200 Then
        With prom.Offset(0, wCols.Item(al.Area.Nombre))
          .NumberFormat = "00"
          .Value = al.Promedio
        End With
      End If
      modExcel.CeldaFondo(prom.Offset(0, wCols.Item(al.Area.Nombre)), 65535)
      Me.pbAvance.Value += 1
    Next
    With wIni.Worksheet
      modExcel.BordesTodo(.Range(wIni, wIni.Offset(fila, wCols.Count + 4)))
    End With
    Me.pbAvance.Visible = False
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub frmConsolidadoAnioAreaPeriodo_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmEvolucionComportamiento.frm = Nothing
  End Sub

End Class