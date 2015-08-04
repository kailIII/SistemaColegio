Public Class frmPrincipal

  Private Sub GestionDeServiciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDeServiciosToolStripMenuItem.Click
    Dim frm As frmGestionServicios

    frm = frmGestionServicios.crear()
    frm.presentar(Me)
  End Sub

  Private Sub GestionDeCuentasContablesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDeCuentasContablesToolStripMenuItem.Click
    Dim frm As New frmGestionCuentaContable

    frm.ShowDialog()
  End Sub

  Private Sub GestionDeProgramacionDePagosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDeProgramacionDePagosToolStripMenuItem.Click
    Dim frm As New frmGestionProgramacionPago
    frm.ShowDialog()
  End Sub

  Private Sub RegistrarBeneficioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
    Dim frm As frmGestionBeneficio

    frm = frmGestionBeneficio.crear
    frm.Presentar(Me)
  End Sub

  Private Sub RegistrarPagosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarPagoToolStripMenuItem.Click
    Dim frm As New frmRegistrarPago

    For Each FromHijo As Form In Me.MdiChildren
      If FromHijo.Name = "frmRegistrarPago" Then
        FromHijo.Select()
        Exit Sub
      End If
    Next

    frm.Reporte = modPrincipal.crpDocumento
    frm.Visor = modPrincipal.frmVisor
    frm.MdiParent = Me
    frm.WindowState = FormWindowState.Maximized
    frm.ControlError = Me.errGeneral
    frm.Registrar()
  End Sub

  Private Sub mnuMantenimientoDocumentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenimientoDeDocumentosToolStripMenuItem.Click
    Dim frm As New frmMantenimientoDocumentos
    Dim sw As Boolean = False

    For Each FromHijo As Form In Me.MdiChildren
      If FromHijo.Name = "frmAnularRecibo" Then
        sw = True
        FromHijo.Select()
      End If
    Next
    If sw = False Then
      frm.MdiParent = Me
      frm.WindowState = FormWindowState.Maximized
      frm.cargarDatos()
    End If
  End Sub

  Private Sub RegistrarEstadoDeCuentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadoDeCuentaToolStripMenuItem.Click
    Dim frm As New frmEstadoCuenta
    Dim sw As Boolean = False

    For Each FromHijo As Form In Me.MdiChildren
      If FromHijo.Name = "frmEstadoCuenta" Then
        sw = True
        FromHijo.Select()
      End If
    Next
    If sw = False Then
      frm.MdiParent = Me
      frm.WindowState = FormWindowState.Maximized
      frm.ControlError = Me.errGeneral
      frm.Presentar()
    End If
  End Sub

  Private Sub ImportarDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarDataToolStripMenuItem.Click
    Dim frm As New frmExportarData
    frm.ShowDialog()
  End Sub

  Private Sub ImportarDataToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportarDataToolStripMenuItem2.Click
    Dim frm As frmImportarData

    frm = frmImportarData.Crear
    frm.MdiParent = Me
    frm.CargarFormulario(Me.ofdAbrir)
  End Sub

  Private Sub mnuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSalir.Click
    Me.Close()
    Me.Dispose()
  End Sub

  Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
    GestionDeServiciosToolStripMenuItem_Click(Nothing, Nothing)
  End Sub

  Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
    RegistrarPagosToolStripMenuItem_Click(Nothing, Nothing)
  End Sub

  Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
    ImportarDataToolStripMenuItem1_Click(Nothing, Nothing)
  End Sub

  Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
    ImportarDataToolStripMenuItem_Click(Nothing, Nothing)
  End Sub

  Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
    RegistrarEstadoDeCuentaToolStripMenuItem_Click(Nothing, Nothing)
  End Sub

  Private Sub GenerarCartasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarCartasToolStripMenuItem.Click
    Dim frm As New frmCartaDeudores
    frm.ShowDialog()
  End Sub

  Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
    RegistrarBeneficioToolStripMenuItem_Click(Nothing, Nothing)
  End Sub

  Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
    GenerarCartasToolStripMenuItem_Click(Nothing, Nothing)
  End Sub

  Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Me.RegistrarPagosToolStripMenuItem.PerformClick()
  End Sub

  Private Sub timerHora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerHora.Tick
    tsslHora.Text = Date.Now.ToLongTimeString
  End Sub

  Private Sub LiquidacionDelDiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LiquidacionDelDiaToolStripMenuItem.Click
    frmLiquidacionDia.Presentar(Me, Me.sfdGuardar)
  End Sub

  Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
    Dim frm As New frmAsignarCodigoRecaudacion

    frm.ShowDialog()
  End Sub

  Private Sub mnuAsignarObligaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignarObligacionesToolStripMenuItem.Click
    Dim f As frmAsignarObligaciones = frmAsignarObligaciones.crear

    f.MdiParent = Me
    f.Registrar()
  End Sub

  Private Sub ResumenDebeneficiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumenDebeneficiosToolStripMenuItem.Click
    frmBeneficioResumenCantidad.Presentar(Me, Me.sfdGuardar)
  End Sub

  Private Sub mnuPagoInstitucional_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagoInstitucionalToolStripMenuItem.Click
    Dim frm As New frmPagoInstitucional

    frm.MdiParent = Me
    frm.ControlError = Me.errGeneral
    frm.Registrar()
  End Sub

  Private Sub ConsolidadoDePagosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsolidadoDePagosToolStripMenuItem.Click
    frmConsolidadoPagos.Presentar(Me, Me.sfdGuardar)
  End Sub

  Private Sub ResumenPagosProgramadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumenPagosProgramadosToolStripMenuItem.Click
    frmResumenPagosColegio.Presentar(Me, Me.sfdGuardar)
  End Sub

  Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
    Dim f As New frmModificarClave

    f.Gestionar()
  End Sub

  Private Sub ReporteDePagosPorServicioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDePagosPorServicioToolStripMenuItem.Click
    frmReportePagosServicio.Presentar(Me, Me.sfdGuardar)
  End Sub

  Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
    frmGestionarPersonas.presentar(Me)
  End Sub

  Private Sub ToolStripMenuItem8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
    frmListadoAlumnosBeneficiados.Presentar(Me, Me.sfdGuardar)
  End Sub

  Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
    frmListadoAlumnosMatriculados.Presentar(Me, Me.sfdGuardar)
  End Sub

  Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
    frmListadoPagosBanco.Presentar(Me, Me.sfdGuardar)
  End Sub

  Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
    frmListadoAlumnosPendientesPago.Presentar(Me, Me.sfdGuardar)
  End Sub

  Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem13.Click
    Dim frm As frmModificarCronogramaPago

    frm = frmModificarCronogramaPago.Crear(Me)
    frm.Show()
  End Sub

End Class