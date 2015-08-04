Imports Microsoft.Office.Interop.Excel

Public Class frmLiquidacionDia

  Private docs As List(Of DetalleDocumentoIngreso)
  Private res As List(Of ResumenFormaPago)
  Private totEf As Double = 0
  Private totCuentas As Double = 0

  Private Shared frm As frmLiquidacionDia

  Private Const CELDAINICIO As String = "B9"
  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing

  Private mDialogoGuardar As SaveFileDialog

  Private Sub New()
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
  End Sub

  Private Sub frmLiquidacionDia_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    frmLiquidacionDia.frm = Nothing
  End Sub

  Private Sub frmLiquidacionDia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.CargarIconos()
    Me.cboEntidad.SelectedIndex = 0
    Me.dtpFecha.Value = DateAndTime.Now
  End Sub

  Public Sub CargarIconos()
    Me.btnBuscar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\ver2.gif")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\excel.bmp")
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    PresentarLiquidacion(Me.cboEntidad.Text.Substring(0, 1), Me.dtpFecha.Value)
  End Sub

  Private Sub PresentarLiquidacion(ByVal wEntidad As String, ByVal wFecha As Date)
    Dim rn As New RNDocumentoIngreso
    Dim rnL As New RNLiquidacion
    Dim liq As Liquidacion

    docs = rn.ListarPeriodo(wEntidad, wFecha, wFecha)
    res = rn.ResumenIngresosFormaPago(wEntidad, wFecha, wFecha)
    rn = Nothing
    liq = rnL.LeerNumero(New Liquidacion() With {.Entidad = wEntidad, .Fecha = wFecha})
    Me.nudNumero.Enabled = False
    Me.lblNumero.Visible = True
    Me.nudNumero.Visible = True
    If liq IsNot Nothing Then
      Me.nudNumero.Value = liq.Numero
    Else
      If Me.docs.Count > 0 Then
        liq = rnL.ObtenerNumero(wEntidad, wFecha.Year)
        Me.nudNumero.Value = liq.Numero
        Me.nudNumero.Enabled = False
      Else
        Me.lblNumero.Visible = False
        Me.nudNumero.Visible = False
      End If
    End If
    rnL = Nothing
    Me.txtTotalEfectivo.Text = "0.00"
    Me.txtTotalCheques.Text = "0.00"
    Me.txtTotalVouchers.Text = "0.00"
    Me.txtTotalCaja.Text = "0.00"
    Me.txtTotalBCP.Text = "0.00"
    Me.txtTotalBIF.Text = "0.00"
    Me.txtTotalCuentas.Text = "0.00"
    Me.txtTotalRecaudado.Text = "0.00"
    Me.totEf = 0
    Me.totCuentas = 0
    For Each r In res
      Select Case r.FormaPago
        Case "E"
          Me.txtTotalEfectivo.Text = r.Total.ToString("0.00")
          totEf += r.Total
        Case "C"
          Me.txtTotalCheques.Text = r.Total.ToString("0.00")
          totEf += r.Total
        Case "V"
          If r.EntidadFinanciera IsNot Nothing Then
            If r.EntidadFinanciera.Nombre.ToUpper.Contains("CREDITO") = True Then
              Me.txtTotalBCP.Text = r.Total.ToString("0.00")
            Else
              Me.txtTotalBIF.Text = r.Total.ToString("0.00")
            End If
            totCuentas += r.Total
          Else
            Me.txtTotalVouchers.Text = r.Total.ToString("0.00")
            totEf += r.Total
          End If
      End Select
    Next
    Me.txtTotalCaja.Text = totEf.ToString("0.00")
    Me.txtTotalCuentas.Text = totCuentas.ToString("0.00")
    Me.txtTotalRecaudado.Text = (totEf + totCuentas).ToString("0.00")
    Me.dgvDocumentos.AutoGenerateColumns = False
    Me.dgvDocumentos.DataSource = docs
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Close()
  End Sub

  Public Shared Sub Presentar(ByVal wPadre As Form, ByVal wDialogo As SaveFileDialog)
    If frmLiquidacionDia.frm Is Nothing Then
      frmLiquidacionDia.frm = New frmLiquidacionDia
      With frmLiquidacionDia.frm
        .mDialogoGuardar = wDialogo
        .MdiParent = wPadre
        .WindowState = FormWindowState.Maximized
      End With
    End If

    frm.Show()
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    ExportarReporte()
  End Sub

  Private Sub ExportarReporte()
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing

    Try

      If Me.docs IsNot Nothing AndAlso Me.docs.Count > 0 Then
        Me.mDialogoGuardar.Filter = "Archivos (*.xls)|*.xls"
        Me.mDialogoGuardar.FileName = "LIQUIDACIÓN " & Me.dtpFecha.Value.ToString("yyyy-MM-dd")

        m_excel = CrearExcel()
        Libro = AbrirPlantilla(m_excel, Me.mDialogoGuardar, AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Liquidacion.xls")
        If Libro IsNot Nothing Then
          Hoja = DirectCast(Libro.Worksheets.Item("Datos"), Worksheet)

          Hoja.Range("C7").Value = DateAndTime.Now.ToShortDateString

          Me.ExportarLiquidacion(Hoja.Range(CELDAINICIO).Offset(1, 0))
          Me.ExportarResumen(Hoja.Range(CELDAINICIO).Offset(Me.docs.Count + 1, 0))

          Hoja.Range(Hoja.Range(CELDAINICIO).Offset(1, 0), Hoja.Range(CELDAINICIO).Offset(Me.docs.Count, 23)).EntireColumn.AutoFit()
          BordesTodo(Hoja.Range(Hoja.Range(CELDAINICIO).Offset(1, 0), Hoja.Range(CELDAINICIO).Offset(Me.docs.Count, 7)))

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

  Private Sub ExportarLiquidacion(ByVal Celda As Range)
    Dim celdaIni As Range = Celda
    Dim i As Integer = 1

    For Each pago In Me.docs
      Celda.Value = i
      Celda.Offset(0, 1).Value = pago.DocumentoNumero
      Celda.Offset(0, 2).Value = pago.CodigoRecaudacionAlumno
      Celda.Offset(0, 3).Value = pago.NombrePersona
      Celda.Offset(0, 4).Value = pago.Descripcion
      Celda.Offset(0, 5).Value = pago.Monto
      Celda.Offset(0, 6).Value = pago.NumeroCuentaContable
      Celda.Offset(0, 7).Value = pago.DescripcionFormaPago
      Celda.Offset(0, 8).Value = pago.NumeroCuentaBancaria

      Celda = Celda.Offset(1, 0)
      i = i + 1
    Next
  End Sub

  Private Sub ExportarResumen(ByVal Celda As Range)
    Dim celdaIni As Range = Celda
    Dim texto As String = ""

    Celda = Celda.Offset(2, 0)
    For Each r In res
      Select Case r.FormaPago
        Case "E"
          texto = "EFECTIVO"
        Case "C"
          texto = "CHEQUE"
        Case "V"
          If r.EntidadFinanciera IsNot Nothing Then
            If r.EntidadFinanciera.Nombre.ToUpper.Contains("CREDITO") = True Then
              texto = "BCP"
            Else
              texto = "BIF"
            End If
          Else
            texto = "VOUCHERS"
          End If
      End Select
      Celda.Font.Bold = True
      Celda.Value = texto
      Celda.Offset(0, 2).Value = r.Total.ToString("0.00")
      Celda = Celda.Offset(1, 0)
    Next
    Celda = Celda.Offset(2, 0)
    Celda.Font.Bold = True

    Celda.Value = "TOTAL EFECTIVO"
    Celda.Offset(0, 2).Value = Me.totEf.ToString("0.00")
    Celda = Celda.Offset(1, 0)
    Celda.Font.Bold = True
    Celda.Value = "TOTAL BANCOS"
    Celda.Offset(0, 2).Value = Me.totCuentas.ToString("0.00")
    Celda = Celda.Offset(3, 0)
    Celda.Font.Bold = True
    Celda.Value = "TOTAL RECAUDADO"
    Celda.Offset(0, 2).Value = (Me.totEf + Me.totCuentas).ToString("0.00")
  End Sub

  'Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
  '  Dim rep As New crpLiquidacion
  '  Dim entidad As String

  '  rep.SetDataSource(Me.docs)
  '  With rep.Section1.ReportObjects
  '    If Me.cboEntidad.SelectedIndex = 0 Then
  '      entidad = "IEP SANTO TORIBIO DE MOGROVEJO"
  '    Else
  '      entidad = "COPAFA"
  '    End If
  '    DirectCast(.Item("txtTitulo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "LIQUIDACIÓN COBRANZAS N°  " & Me.nudNumero.Value.ToString("00000") & "-" & Me.dtpFecha.Value.Year
  '    DirectCast(.Item("txtEntidad"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = entidad
  '    DirectCast(.Item("txtFecha"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.dtpFecha.Value.ToString("dddd, dd-MM-yyyy")
  '  End With
  '  With rep.Section4.ReportObjects
  '    DirectCast(.Item("txtEfectivo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.txtTotalEfectivo.Text
  '    DirectCast(.Item("txtCheque"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.txtTotalCheques.Text
  '    DirectCast(.Item("txtVoucher"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.txtTotalVouchers.Text
  '    DirectCast(.Item("txtTotalCaja"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.txtTotalCaja.Text

  '    DirectCast(.Item("txtBCP"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.txtTotalBCP.Text
  '    DirectCast(.Item("txtBIF"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.txtTotalBIF.Text
  '    DirectCast(.Item("txtBancos"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.txtTotalCuentas.Text

  '    DirectCast(.Item("txtTotalRecaudado"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.txtTotalRecaudado.Text
  '  End With

  '  With frmVisor.crvVisor
  '    .ShowPrintButton = True
  '    .ReportSource = rep
  '    .ShowPageNavigateButtons = True

  '    frmVisor.ShowDialog()

  '    .ReportSource = Nothing
  '    .ShowPrintButton = False
  '    .ShowPageNavigateButtons = False
  '  End With

  'End Sub

  Private Sub btnImpresionMultiple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
    Me.dtpFecha.Value = Me.dtpFecha.Value.AddDays(1)
    Me.btnBuscar.PerformClick()
  End Sub

  Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
    Me.dtpFecha.Value = Me.dtpFecha.Value.AddDays(-1)
    Me.btnBuscar.PerformClick()
  End Sub

End Class
