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

    If mOInstitucion IsNot Nothing Then
      Me.Text &= " - " & mOInstitucion.Nombre
    End If

  End Sub
    
    Private Sub AsignarDocenteAAreasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignarDocenteAAreasToolStripMenuItem.Click
    frmGestionDocenteArea.Crear(Me)

  End Sub

    Private Sub mnuCambiarContrasenia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCambiarContrasenia.Click
        Dim frm As New frmCuentasUsuario
        frm.Gestionar()
    End Sub

  Private Sub RegistrarNotaDeInvestigaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarNotaDeInvestigaciónToolStripMenuItem.Click
    frmNotaInvestigacion.Crear(Me, Me.sfdGuardarArchivo, Me.ofdAbrirArchivo)

  End Sub

  Private Sub mnuNotasInvestigacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNotasInvestigacion.Click
    frmReporteNotasInvestigacion.Gestionar(Me.sfdGuardarArchivo)
  End Sub

  Private Sub mnuNotasPlanLectorInvestigacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNotasPlanLectorInvestigacion.Click
    frmReporteNotasInvestigacionPlanLector.Gestionar(Me.sfdGuardarArchivo)
  End Sub
End Class
