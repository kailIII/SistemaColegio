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
  End Sub

  Private Sub mnuGestionDeAsistencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
    Dim f As New frmGestionAsistencia

    f.Gestionar()
  End Sub

  Private Sub mnuGestionDeComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestionDeComp.Click
    Dim frm As New frmComportamiento

    frm.Gestion()
  End Sub

  Private Sub mnuCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCambiar.Click
    Dim frm As New frmCuentasUsuario

    frm.Gestionar()
  End Sub

  Private Sub mnuNotasPlanLector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNotasPlanLector.Click
    Dim f As New frmGestionNotasPlanLector

    f.Gestionar()
  End Sub

  Private Sub mnuAsignarLibros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAsignarLibros.Click
    Dim f As New frmGestionProgLectura

    f.Gestionar()
  End Sub

  Private Sub mnuExportarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExportarRegistro.Click
    Dim f As New frmExportarPlanLector

    f.Gestionar()
  End Sub

  Private Sub mnuImportarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImportarRegistro.Click
    Dim f As New frmImportarPlanLector

    f.Gestionar()
  End Sub

  Private Sub ListadoDeAlumnosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeAlumnosToolStripMenuItem.Click
    Dim f As New frmAlumnosSeccion

    f.ErrorReporte = Me.errGeneral
    f.DialogoGuardar = Me.sfdGuardar
    f.MdiParent = Me

    f.Presentar()

  End Sub

End Class
