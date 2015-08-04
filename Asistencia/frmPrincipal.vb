Public Class frmPrincipal

  Private Sub mnuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSalir.Click
    Me.Close()
  End Sub


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

  Private Sub mnuGestionDeAsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestionDeAsistencia.Click
    Dim f As New frmGestionAsistencia
    f.Gestionar()
  End Sub

  Private Sub mnuCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCambiar.Click
    Dim f As New frmModificarClave
    f.Gestionar()
  End Sub

    Private Sub AsistenciaMensualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsistenciaMensualToolStripMenuItem.Click
        Dim f As New frmReporteAsistenciaMensual
        f.Gestionar()
    End Sub

  Private Sub ListadoDeAsistenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeAsistenciaToolStripMenuItem.Click
    Dim f As frmListadoAsistencia

    f = frmListadoAsistencia.Crear(Me)
    f.DialogoGuardar = Me.sfdGuardar
    f.Presentar()
  End Sub

End Class
