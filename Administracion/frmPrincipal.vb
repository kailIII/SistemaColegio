Public Class frmPrincipal

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


  Private Sub mnuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSalir.Click
    Me.Close()
    Me.Dispose()
  End Sub

  Private Sub timerHora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerHora.Tick
    tsslHora.Text = Date.Now.ToLongTimeString
  End Sub

  Private Sub LiquidacionDelDiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LiquidacionDelDiaToolStripMenuItem.Click
    frmLiquidacionDia.Presentar(Me, Me.sfdGuardar)
  End Sub

  Private Sub ResumenDebeneficiosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumenDebeneficiosToolStripMenuItem.Click
    frmBeneficioResumenCantidad.Presentar(Me, Me.sfdGuardar)
  End Sub

  Private Sub ConsolidadoDePagosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsolidadoDePagosToolStripMenuItem.Click
    frmConsolidadoPagos.Presentar(Me, Me.sfdGuardar)
  End Sub

  Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
    Dim f As New frmModificarClave

    f.Gestionar()
  End Sub

  Private Sub ReporteDePagosPorServicioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteDePagosPorServicioToolStripMenuItem.Click
    frmReportePagosServicio.Presentar(Me, Me.sfdGuardar)
  End Sub

  Private Sub ToolStripMenuItem8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
    frmListadoAlumnosBeneficiados.Presentar(Me, Me.sfdGuardar)
  End Sub

  Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
    frmListadoPagosBanco.Presentar(Me, Me.sfdGuardar)
  End Sub

  Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
    frmListadoAlumnosPendientesPago.Presentar(Me, Me.sfdGuardar)
  End Sub

End Class