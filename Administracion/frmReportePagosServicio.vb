Imports Microsoft.Office.Interop.Excel

Public Class frmReportePagosServicio

  Private Shared frm As frmReportePagosServicio

  Private Const CELDAINICIO As String = "B9"
  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing

  Private dt As System.Data.DataTable

  Private mDialogoGuardar As SaveFileDialog

  Public WriteOnly Property DialogoGuardar() As SaveFileDialog
    Set(ByVal value As SaveFileDialog)
      Me.mDialogoGuardar = value
    End Set
  End Property

  Public Sub CargarImagenes()
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Excel.bmp")
  End Sub

  Public Shared Sub Presentar(ByVal frm As Form, ByVal wDialogoGuardar As SaveFileDialog)
    If frmReportePagosServicio.frm Is Nothing Then
      frmReportePagosServicio.frm = New frmReportePagosServicio
      With frmReportePagosServicio.frm
        .DialogoGuardar = wDialogoGuardar

        .MdiParent = frm
        .Show()
        .WindowState = FormWindowState.Maximized
      End With
    Else
      frmReportePagosServicio.frm.Activate()
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim rn As RNDocumentoIngreso
    Dim total As Double = 0

    If Me.cboServicio.SelectedIndex > -1 Then
      rn = New RNDocumentoIngreso
      Me.dt = rn.ListarPagosPorServicio(DirectCast(Me.cboServicio.SelectedItem, Servicio), Me.dtpInicio.Value, Me.dtpFin.Value)
      rn = Nothing
      Me.dgvConsolidadoPagos.AutoGenerateColumns = False
      Me.dgvConsolidadoPagos.DataSource = dt
      For Each dr As DataRow In Me.dt.Rows
        total += CDbl(dr.Item("Monto"))
      Next
      Me.txtTotal.Text = total.ToString("0.00")
    Else
      MessageBox.Show("Debe seleccionar un servicio", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Me.cboServicio.Focus()
    End If
  End Sub

  Private Sub frmConsolidadoPagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.dtpInicio.Value = DateAndTime.Now
    Me.dtpFin.Value = Me.dtpInicio.Value

    Me.CargarImagenes()
    Me.ListarServicios()
  End Sub

  Private Sub ListarServicios()
    Dim rn As New RNServicio
    Dim servicios As List(Of Servicio)

    servicios = rn.ListarServicioTodo()
    rn = Nothing

    Me.cboServicio.DisplayMember = "NombreConNivel"
    Me.cboServicio.ValueMember = "Codigo"
    Me.cboServicio.DataSource = servicios
    Me.cboServicio.SelectedIndex = -1
  End Sub

  Private Sub frmConsolidadoPagos_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmReportePagosServicio.frm = Nothing
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Me.ExportarReporte()
  End Sub

  Private Sub ExportarReporte()
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing

    Try

      Me.mDialogoGuardar.Filter = "Archivos (*.xls)|*.xls"
      Me.mDialogoGuardar.FileName = "Listado de pagos por servicio " & Me.cboServicio.Text

      m_excel = CrearExcel()
      Libro = AbrirPlantilla(m_excel, Me.mDialogoGuardar, AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\ListadoPagosPorServicio.xls")
      If Libro IsNot Nothing Then
        Hoja = DirectCast(Libro.Worksheets.Item("Datos"), Worksheet)

        Hoja.Range("C7").Value = Me.cboServicio.Text
        Hoja.Range("G7").Value = Me.dtpInicio.Value.ToString("dd.MM.yyyy") & " - " & Me.dtpFin.Value.ToString("dd.MM.yyyy")

        Me.ExportarReporte(Hoja.Range(CELDAINICIO).Offset(1, 0))

        BordesTodo(Hoja.Range(Hoja.Range(CELDAINICIO).Offset(1, 0), Hoja.Range(CELDAINICIO).Offset(Me.dt.Rows.Count, 7)))

        m_excel.ActiveWorkbook.SaveAs(Me.mDialogoGuardar.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
        m_excel.ScreenUpdating = True
        MessageBox.Show("Archivo exportado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

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

  Private Sub ExportarReporte(ByVal Celda As Range)
    Dim celdaIni As Range = Celda
    Dim total As Double
    Dim i As Integer = 1

    For Each dr As DataRow In Me.dt.Rows
      Celda.Value = i
      Celda.Offset(0, 1).Value = dr.Item("CodigoAlumno")
      Celda.Offset(0, 2).Value = dr.Item("Seccion")
      Celda.Offset(0, 3).Value = dr.Item("Persona")
      Celda.Offset(0, 4).Value = dr.Item("Documento")
      Celda.Offset(0, 5).Value = CDate(dr.Item("Fecha")).ToString("dd.MM.yyyy")
      Celda.Offset(0, 6).Value = dr.Item("Descripcion")
      Celda.Offset(0, 7).Value = dr.Item("Monto")

      Celda = Celda.Offset(1, 0)
      i = i + 1
      total += CDbl(dr.Item("Monto"))
    Next
    Celda = Celda.Offset(2, 0)
    Celda.Font.Bold = True
    Celda.Value = "Total"
    Celda.Offset(0, 1).Value = total
  End Sub

End Class