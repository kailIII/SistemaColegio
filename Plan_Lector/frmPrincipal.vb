Public Class frmPrincipal

  Private Sub mnuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSalir.Click
    Me.Close()
  End Sub


  Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    With mOUsuario.Persona
      tslblUsuario.Text = .NombreCompleto
    End With
    If moAnioActual IsNot Nothing Then
      tslblPeriodo.Text = moAnioActual.Anio
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

  Private Sub mnuCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCambiar.Click
    Dim frm As New frmCuentasUsuario

    frm.Gestionar()
  End Sub

  Private Sub mnuGestiónDeAutoes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestionAutores.Click
    Dim frm As New frmGestionAutor

    frm.Gestionar()
  End Sub

  Private Sub mnuLibrosPorGrado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLibrosPorGrado.Click
    frmGestionProgLectura.Gestionar(Me, Me.sfdGuardarArchivo, Me.ofdAbrirArchivo)
  End Sub

  Private Sub mnuAsignarPorGrado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAsignarLibroGrado.Click
    frmAsignacionLibroGrado.Gestionar(Me)
  End Sub

  Private Sub mnuGestiónDePresentaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestiónDePresentaciones.Click
    Dim frm As New frmGestionPresentacion
    frm.Gestionar()
  End Sub

  Private Sub mnuRegistrarLibro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRegistrarLibro.Click
    Dim frm As New frmGestionLibro
    frm.Gestionar()
  End Sub

  Private Sub mnuExportarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExportarRegistro.Click
    Dim frm As New frmExportarPlanLector
    frm.Gestionar()
  End Sub

  Private Sub mnuImportarRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImportarRegistro.Click
    Dim frm As New frmImportarPlanLector
    frm.Gestionar()
  End Sub

  Private Sub mnuNotas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNotas.Click
    Dim frm As New frmReporteNotasPlanLector

    frm.DialogoGuardar = Me.sfdGuardarArchivo
    frm.Gestionar()
  End Sub

  Private Sub AlumnosYPromedioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlumnosYPromedioToolStripMenuItem.Click
    Dim frm As New frmReporteAlumnosPlanLectorPromedio

    frm.Gestionar()
  End Sub

  Private Sub AlumnosNoProgramadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlumnosNoProgramadosToolStripMenuItem.Click
    Dim frm As New frmReporteAlumnosNoProgramados

    frm.MdiParent = Me
    frm.Gestionar()
  End Sub

  Private Sub mnuConsolidadoNotasSeccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConsolidadoNotasSeccion.Click
    Dim frm As frmConsolidadoNotasPLSeccion

    frm = frmConsolidadoNotasPLSeccion.Crear
    frm.MdiParent = Me
    frm.GuardarArchivos = Me.sfdGuardarArchivo
    frm.Presentar()
  End Sub

  Private Sub RegistroPorSecciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroPorSecciónToolStripMenuItem.Click
    frmGestionNotasPlanLectorSeccion.Gestionar(Me)
  End Sub

  Private Sub RegistroPorResponsableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroPorResponsableToolStripMenuItem.Click
    frmGestionNotasPlanLectorResponsable.Gestionar(Me, Me.sfdGuardarArchivo, Me.ofdAbrirArchivo)
  End Sub

End Class
