Imports Microsoft.Office.Interop.Excel

Public Class frmListadoAlumnosPendientesPago

  Private Shared frm As frmListadoAlumnosPendientesPago

  Private Const CELDAINICIO As String = "B9"

  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing

  Private mDialogoGuardar As SaveFileDialog

  Private dtAlumnos As Data.DataTable

  Private Sub New()
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
  End Sub

  Private Sub frmLiquidacionDia_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    frmListadoAlumnosPendientesPago.frm = Nothing
  End Sub

  Private Sub frmLiquidacionDia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.CargarIconos()
    Me.dtpFecha.Value = DateAndTime.Now
    Me.CargarAnios(modPrincipal.mOInstitucion)
    Me.cboAnio.SelectedValue = mOAnioActual.Anio
  End Sub

  Private Sub CargarAnios(ByVal wInst As Institucion)
    Dim rnA As New RNAnioLectivo
    Dim lA As List(Of AnioLectivo)

    lA = rnA.Listar(wInst)
    cboAnio.DisplayMember = "Anio"
    cboAnio.ValueMember = "Anio"
    cboAnio.DataSource = lA
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
    If frmListadoAlumnosPendientesPago.frm Is Nothing Then
      frmListadoAlumnosPendientesPago.frm = New frmListadoAlumnosPendientesPago
      With frmListadoAlumnosPendientesPago.frm
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
      If Me.dtAlumnos IsNot Nothing AndAlso Me.dtAlumnos.Rows.Count > 0 Then
        Me.mDialogoGuardar.Filter = "Archivos (*.xlsX)|*.xlsX"
        Me.mDialogoGuardar.FileName = "LISTADO DE ALUMNOS PENDIENTES DE PAGO - " & Me.cboServicio.Text

        m_excel = CrearExcel()
        Libro = AbrirPlantilla(m_excel, Me.mDialogoGuardar, AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\ListadoAlumnosPendientesPago.xls")
        If Libro IsNot Nothing Then
          Hoja = DirectCast(Libro.Worksheets.Item("Datos"), Worksheet)

          Hoja.Range("C7").Value = Me.cboServicio.Text
          Hoja.Range("G7").Value = DateAndTime.Now.ToShortDateString

          Me.ExportarDatos(Hoja.Range(CELDAINICIO).Offset(1, 0))

          BordesTodo(Hoja.Range(Hoja.Range(CELDAINICIO).Offset(1, 0), Hoja.Range(CELDAINICIO).Offset(Me.dtAlumnos.Rows.Count, 6)))

          m_excel.ActiveWorkbook.SaveAs(Me.mDialogoGuardar.FileName, XlFileFormat.xlWorkbookDefault)
          m_excel.ScreenUpdating = True
          MessageBox.Show("Archivo exportado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      Else
        MessageBox.Show("No se encontraron datos que exportar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      If Libro IsNot Nothing Then
        Libro.Close()
      End If
      If m_excel IsNot Nothing Then
        m_excel.ScreenUpdating = True
        m_excel.Quit()
      End If
      Hoja = Nothing
      Libro = Nothing
      m_excel = Nothing
    End Try

  End Sub

  Private Sub ExportarDatos(ByVal Celda As Range)
    Dim celdaIni As Range = Celda
    Dim i As Integer = 1
    Dim totalAsignado As Double = 0
    Dim totalPagado As Double = 0

    For Each dr As DataRow In Me.dtAlumnos.Rows
      Celda.Value = i
      Celda.Offset(0, 1).Value = dr.Item("CodigoRecaudacion")
      Celda.Offset(0, 2).Value = dr.Item("Seccion")
      Celda.Offset(0, 3).Value = dr.Item("Alumno")
      Celda.Offset(0, 4).Value = dr.Item("MontoAsignado")
      Celda.Offset(0, 5).Value = dr.Item("MontoPagado")
      Celda.Offset(0, 6).Value = dr.Item("Saldo")

      totalAsignado += CDbl(dr.Item("MontoAsignado"))
      totalPagado += CDbl(dr.Item("MontoPagado"))
      Celda = Celda.Offset(1, 0)
      i += 1
    Next
    Celda.Offset(0, 4).Value = totalAsignado
    Celda.Offset(0, 5).Value = totalPagado
    Celda.Offset(0, 6).FormulaR1C1 = totalAsignado - totalPagado
  End Sub

  Public Sub ListarServiciosProgramados()
    Dim servicios As New List(Of Servicio)
    Dim obj As New RNObligacion

    servicios = obj.ListarServiciosProgramados(DirectCast(Me.cboAnio.SelectedItem, AnioLectivo))
    obj = Nothing
    If servicios.Count > 0 Then
      Me.cboServicio.DisplayMember = "nombre"
      Me.cboServicio.ValueMember = "codigo"
      Me.cboServicio.DataSource = servicios
      Me.cboServicio.SelectedIndex = -1
      servicios = Nothing
    End If
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Dim rn As RNObligacion

    If Me.cboServicio.SelectedIndex > -1 Then
      rn = New RNObligacion
      Me.dtAlumnos = rn.ListarAlumnosPendientesPago(Me.cboServicio.Text)
      rn = Nothing
      Me.dgvDocumentos.DataSource = Me.dtAlumnos
    Else
      MessageBox.Show("Debe seleccionar servicio", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Me.cboServicio.Focus()
    End If
  End Sub

  Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
    Dim rep As New crpListadoAlumnosPendientesPago

    rep.SetDataSource(Me.dtAlumnos)
    With rep.Section1.ReportObjects
      DirectCast(.Item("txtServicio"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.cboServicio.Text
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

  Private Sub cboAnio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnio.SelectedIndexChanged
    Me.cboServicio.DataSource = Nothing
    Me.cboServicio.SelectedIndex = -1
  End Sub

  Private Sub cboServicio_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboServicio.Enter
    If Me.cboAnio.SelectedIndex > -1 Then
      Me.ListarServiciosProgramados()
    Else
      MessageBox.Show("Debe seleccionar el año lectivo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

End Class
