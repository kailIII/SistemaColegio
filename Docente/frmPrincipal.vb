Public Class frmPrincipal

  Private Sub mnuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSalir.Click
    Me.Close()
  End Sub

  Private Sub frmPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Application.Exit()
  End Sub

  'Private Sub GestionDeIndicadoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestionDeIndicadores.Click
  '  Dim f As New frmGestionIndicadores
  '  f.Gestionar()
  'End Sub

  'Private Sub mnuGestionDeUnidades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestionDeUnidades.Click
  '  Dim f As New frmGestionUnidades
  '  f.Gestionar()
  'End Sub

  Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    With mOUsuario.Persona
      tslblUsuario.Text = .NombreCompleto
    End With
    If moAnioActual IsNot Nothing Then
      tslblPeriodo.Text = moAnioActual.anio
      If mOPeriodoActual IsNot Nothing Then
        tslblPeriodo.Text &= " - " & mOPeriodoActual.Nombre
      Else
        tslblPeriodo.Text &= " - Periodo no disponible"
      End If

    Else
      tslblPeriodo.Text = "Año no disponible"
    End If

    'If mOInstitucion IsNot Nothing Then
    '  Me.Text &= " - " & mOInstitucion.Nombre
    'End If
  End Sub

  Private Sub mnuRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRegistrar.Click
    Dim f As New frmGestionIndicadores
    f.Gestionar()
  End Sub

  Private Sub mnuRegistrarCapacidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRegistrarCapacidad.Click
    Dim f As New frmGestionUnidades
    f.Gestionar()
  End Sub

  Private Sub mnuNotasIndicador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNotasIndicador.Click
    Dim f As New frmRegistroNotasIndicadores
    Me.Visible = False
    f.Gestionar()
  End Sub

  Private Sub mnuNotasCapacidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNotasCapacidad.Click
    Dim f As New frmNotasSecundaria
    Me.Visible = False
    f.Gestionar()
  End Sub

  Private Sub mnuCambiarContrasenia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCambiarContrasenia.Click
    Dim frm As New frmCuentasUsuario
    frm.Gestionar()
  End Sub

  Private Sub mnuRegistroAuxiliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRegistroAuxiliar.Click
    Dim f As New frmRegistroAuxiliar
    f.Gestionar()
  End Sub

  Private Sub mnuExportarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExportarRegistro.Click
    Dim frm As New frmExportarRegistroSec
    frm.Gestionar()
  End Sub

  Private Sub mnuImportarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImportarRegistro.Click
    Dim frm As New frmImportarRegistroSec
    frm.Gestionar()
  End Sub

  Private Sub mnuImportarRegistroInd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImportarRegistroInd.Click
    Dim frm As New frmImportarRegInd
    frm.Gestionar()
  End Sub

  Private Sub RegistroAuxiliarSecundariaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroAuxiliarSecundariaToolStripMenuItem.Click
    Dim frm As New frmRegistroAuxSec
    frm.Gestionar()
  End Sub
End Class
