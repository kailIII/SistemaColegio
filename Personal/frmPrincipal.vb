
Public Class frmPrincipal

  Private Sub mnuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSalir.Click
    Me.Close()
  End Sub

  Private Sub mnuGestionService_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestionService.Click
    Dim f As New frmGestionService

    f.MdiParent = Me
    f.Show()
  End Sub

  Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
    Dim f As New frmGestionRegimenPension

    f.MdiParent = Me
    f.Show()
  End Sub
End Class
