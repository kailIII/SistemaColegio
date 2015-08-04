Imports Microsoft.Office.Interop.Excel

Public Class frmListadoPagosBanco

  Private Shared frm As frmListadoPagosBanco

  Private Const CELDAINICIO As String = "B9"
  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing

  Private mDialogoGuardar As SaveFileDialog

  Private dtPagos As Data.DataTable

  Private Sub New()
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
  End Sub

  Private Sub frmLiquidacionDia_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    frmListadoPagosBanco.frm = Nothing
  End Sub

  Private Sub frmLiquidacionDia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.CargarIconos()
    Me.dtpFecha.Value = DateAndTime.Now
    Me.ListarEntidades()
  End Sub

  Public Sub CargarIconos()
    Me.btnBuscar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\ver2.gif")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\excel.bmp")
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Close()
  End Sub

  Public Shared Sub Presentar(ByVal wPadre As Form, ByVal wDialogo As SaveFileDialog)
    If frmListadoPagosBanco.frm Is Nothing Then
      frmListadoPagosBanco.frm = New frmListadoPagosBanco
      With frmListadoPagosBanco.frm
        .mDialogoGuardar = wDialogo
        .MdiParent = wPadre
        .WindowState = FormWindowState.Maximized
      End With
    End If

    frm.Show()
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Me.ExportarReporte()
  End Sub

  Private Sub ExportarReporte()
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing

    Try

      If Me.dtPagos IsNot Nothing AndAlso Me.dtPagos.Rows.Count > 0 Then
        Me.mDialogoGuardar.Filter = "Archivos (*.xls)|*.xls"
        Me.mDialogoGuardar.FileName = "LISTADO DE PAGOS REALIZADOS - " & Me.cboEntidadFinanciera.Text & "-" & Me.cboCuenta.Text.Trim & " - " & Me.dtpFecha.Value.ToString("yyyy-MM-dd")

        m_excel = CrearExcel()
        Libro = AbrirPlantilla(m_excel, Me.mDialogoGuardar, AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\ListadoPagosCuenta.xls")
        If Libro IsNot Nothing Then
          Hoja = DirectCast(Libro.Worksheets.Item("Datos"), Worksheet)

          Hoja.Range("C7").Value = Me.cboEntidadFinanciera.Text & " - " & Me.cboCuenta.Text.Trim
          Hoja.Range("G7").Value = DateAndTime.Now.ToShortDateString

          Me.ExportarDatos(Hoja.Range(CELDAINICIO).Offset(1, 0))

          BordesTodo(Hoja.Range(Hoja.Range(CELDAINICIO).Offset(1, 0), Hoja.Range(CELDAINICIO).Offset(Me.dtPagos.Rows.Count, 6)))

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

  Private Sub ExportarDatos(ByVal Celda As Range)
    Dim celdaIni As Range = Celda
    Dim i As Integer = 1

    For Each dr As DataRow In Me.dtPagos.Rows
      Celda.Value = i
      Celda.Offset(0, 1).Value = dr.Item("CodigoRecaudacion")
      Celda.Offset(0, 2).Value = dr.Item("Alumno")
      Celda.Offset(0, 3).Value = dr.Item("numOperacion")
      Celda.Offset(0, 4).Value = dr.Item("Documento")
      Celda.Offset(0, 5).Value = dr.Item("Descripcion")
      Celda.Offset(0, 6).Value = dr.Item("Monto")

      Celda = Celda.Offset(1, 0)
      i = i + 1
    Next
  End Sub

  Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
    Dim rep As New crpListadoPagosBanco

    rep.SetDataSource(Me.dtPagos)
    With rep.Section1.ReportObjects
      DirectCast(.Item("txtCuenta"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.cboEntidadFinanciera.Text & " " & Me.cboCuenta.Text.Trim
      DirectCast(.Item("txtFecha"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.dtpFecha.Value.ToString("dddd, dd-MM-yyyy")
    End With
    With rep.Section4.ReportObjects
      DirectCast(.Item("txtInstitucion"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.txtInstitucion.Text
      DirectCast(.Item("txtCOPAFA"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.txtCOPAFA.Text
    End With

    With frmVisor.crvVisor
      .ShowPrintButton = True
      .ReportSource = rep
      .ShowPageNavigateButtons = True

      frmVisor.ShowDialog()

      .ReportSource = Nothing
      .ShowPrintButton = False
      .ShowPageNavigateButtons = False
    End With
  End Sub

  Public Sub ListarEntidades()
    Dim ListA As New List(Of EntidadFinanciera)
    Dim objE As New RNEntidadFinanciera

    ListA = objE.Listar
    objE = Nothing
    If ListA.Count > 0 Then
      Me.cboEntidadFinanciera.DisplayMember = "nombre"
      Me.cboEntidadFinanciera.ValueMember = "codigo"
      Me.cboEntidadFinanciera.DataSource = ListA
      If ListA.Count = 1 Then
        Me.cboEntidadFinanciera.SelectedIndex = 0
        Me.cboCuenta.Focus()
      Else
        Me.cboEntidadFinanciera.SelectedIndex = -1
      End If
      ListA = Nothing
    End If
  End Sub

  Private Sub cboEntidadFinanciera_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEntidadFinanciera.SelectedIndexChanged
    Dim rn As RNEntidadFinanciera
    Dim cuentas As List(Of CuentaBancaria)

    If cboEntidadFinanciera.SelectedItem IsNot Nothing Then
      rn = New RNEntidadFinanciera
      cboCuenta.DisplayMember = "Numero"
      cboCuenta.ValueMember = "Numero"
      cuentas = rn.ListarCuentas(DirectCast(Me.cboEntidadFinanciera.SelectedItem, EntidadFinanciera))
      cboCuenta.DataSource = cuentas
      If cuentas.Count = 1 Then
        cboCuenta.SelectedIndex = 0
      Else
        cboCuenta.SelectedIndex = -1
      End If
    End If
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Dim rn As RNDocumentoIngreso
    Dim montoInst As Double = 0
    Dim montoCop As Double = 0

    If Me.cboEntidadFinanciera.SelectedIndex > -1 AndAlso Me.cboCuenta.SelectedIndex > -1 Then
      rn = New RNDocumentoIngreso
      Me.dtPagos = rn.ListarPagosCuenta(DirectCast(Me.cboCuenta.SelectedItem, CuentaBancaria), Me.dtpFecha.Value)
      rn = Nothing
      For Each dr As DataRow In Me.dtPagos.Rows
        If dr.Item("Entidad").Equals("C") = True Then
          montoCop += CDbl(dr.Item("Monto"))
        Else
          montoInst += CDbl(dr.Item("Monto"))
        End If

      Next
      Me.txtInstitucion.Text = montoInst.ToString("0.00")
      Me.txtCOPAFA.Text = montoCop.ToString("0.00")
      Me.txtTotalRecaudado.Text = (montoInst + montoCop).ToString("0.00")
      Me.dgvDocumentos.AutoGenerateColumns = False
      Me.dgvDocumentos.DataSource = Me.dtPagos
    ElseIf Me.cboEntidadFinanciera.SelectedIndex = -1 Then
      MessageBox.Show("Debe seleccionar la entidad bancaria", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Me.cboEntidadFinanciera.Focus()
    ElseIf Me.cboCuenta.SelectedIndex = -1 Then
      MessageBox.Show("Debe seleccionar la cuenta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Me.cboCuenta.Focus()
    End If

  End Sub

End Class
