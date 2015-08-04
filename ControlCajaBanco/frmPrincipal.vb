Public Class frmPrincipal

 
  Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
    Me.Close()
  End Sub

  Private Sub tsbReposicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbReposicion.Click
    frmReposicion.Crear(Me)
  End Sub

  Private Sub tHoraFecha_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tHoraFecha.Tick
    Me.tsslHora.Text = Date.Now.ToLongTimeString
  End Sub

  Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
    frmCompra.Crear(Me)
  End Sub

  Private Sub mnuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSalir.Click
    Me.Close()
  End Sub
End Class