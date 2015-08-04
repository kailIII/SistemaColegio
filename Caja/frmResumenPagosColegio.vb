Imports Microsoft.Office.Interop.Excel

Public Class frmResumenPagosColegio

  Private Shared frm As frmResumenPagosColegio

  Private Const CELDAINICIO As String = "B10"
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
    If frmResumenPagosColegio.frm Is Nothing Then
      frmResumenPagosColegio.frm = New frmResumenPagosColegio
      With frmResumenPagosColegio.frm
        .DialogoGuardar = wDialogoGuardar

        .MdiParent = frm
        .Show()
        .WindowState = FormWindowState.Maximized
      End With
    Else
      frmResumenPagosColegio.frm.Activate()
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim rn As New RNObligacion

    Me.dt = rn.ListarResumenPagosAnioEntidad("I", Me.dtpInicio.Value, Me.dtpFin.Value)
    rn = Nothing

    Me.dgvConsolidadoPagos.AutoGenerateColumns = False
    Me.dgvConsolidadoPagos.DataSource = dt
  End Sub

  Private Sub frmConsolidadoPagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.dtpInicio.Value = DateAndTime.Now
    Me.dtpFin.Value = Me.dtpInicio.Value

    Me.CargarImagenes()
  End Sub

  Private Sub frmConsolidadoPagos_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmResumenPagosColegio.frm = Nothing
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Me.ExportarReporte()
  End Sub

  Private Sub ExportarReporte()
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing

    Try

      If Me.dt IsNot Nothing AndAlso Me.dt.Rows.Count > 0 Then
        Me.mDialogoGuardar.Filter = "Archivos (*.xls)|*.xls"
        Me.mDialogoGuardar.FileName = "RESUMEN DE PAGOS " & Me.dtpInicio.Value.ToString("yyyy-MM-dd") & " - " & Me.dtpFin.Value.ToString("yyyy-MM-dd")

        m_excel = CrearExcel()
        Libro = AbrirPlantilla(m_excel, Me.mDialogoGuardar, AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\ResumenPagos.xls")
        If Libro IsNot Nothing Then
          Hoja = DirectCast(Libro.Worksheets.Item("Datos"), Worksheet)

          Hoja.Range("C7").Value = Me.dtpInicio.Value.ToString("dd.MM.yyyy")
          Hoja.Range("C8").Value = Me.dtpFin.Value.ToString("dd.MM.yyyy")

          Me.ExportarReporte(Hoja.Range(CELDAINICIO).Offset(1, 0))

          'Hoja.Range(Hoja.Range(CELDAINICIO).Offset(1, 0), Hoja.Range(CELDAINICIO).Offset(Me.dt.Rows.Count, 3)).EntireColumn.AutoFit()
          BordesTodo(Hoja.Range(Hoja.Range(CELDAINICIO).Offset(1, 0), Hoja.Range(CELDAINICIO).Offset(Me.dt.Rows.Count, 2)))

          m_excel.ActiveWorkbook.SaveAs(Me.mDialogoGuardar.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
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
      Celda.Offset(0, 1).Value = dr.Item("Descripcion")
      Celda.Offset(0, 2).Value = dr.Item("Total")

      Celda = Celda.Offset(1, 0)
      i = i + 1
      total += CDbl(dr.Item("Total"))
    Next
    Celda = Celda.Offset(2, 0)
    Celda.Font.Bold = True
    Celda.Value = "Total"
    Celda.Offset(0, 1).Value = total
  End Sub

End Class