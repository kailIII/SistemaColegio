Public Class frmPrincipal



  Private Sub RegistrarGrupoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarGrupoToolStripMenuItem.Click
    Dim grupo As New frmGestionGruposUsuario
    grupo.Show()
  End Sub

  Private Sub RegistrarUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarUsuarioToolStripMenuItem.Click
    Dim usuario As New frmGestionUsuarios
    usuario.Show()
  End Sub

  Private Sub RegistrarSistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarSistemaToolStripMenuItem.Click
    Dim sistema As New frmGestionSistemas
    sistema.Show()
  End Sub

  Private Sub RegistrarOpcionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarOpcionToolStripMenuItem.Click
    Dim opcion As New frmOpcion
    opcion.Show()
  End Sub

  Private Sub PermisosGrupalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermisosGrupalesToolStripMenuItem.Click
    Dim permiso As New frmPermisoGrupal
    permiso.Show()
  End Sub

  Private Sub PermisosIndividualesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermisosIndividualesToolStripMenuItem.Click
    Dim permiso As New frmPermisoIndividuales
    permiso.Show()
  End Sub

  Private Sub SalirToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
    Me.Dispose()
  End Sub

  Private Sub AsignarGrupoAUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignarGrupoAUsuarioToolStripMenuItem.Click
    Dim asignar As New frmAsignaGrupoaUsuario
    asignar.Show()
  End Sub
End Class