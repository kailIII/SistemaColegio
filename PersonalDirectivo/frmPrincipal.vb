Public Class frmPrincipal

  Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
    Me.Close()
    Me.Dispose()
  End Sub

  Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
    Dim f As New frmEstadisticaMatricula With {.DialogoGuardar = Me.sdfGuardar}

    f.MdiParent = Me
    f.Presentar()
  End Sub

  Private Sub DatosLaboralesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosLaboralesToolStripMenuItem.Click
    Dim f As New frmPadresPorTrabajo With {.ErrorReporte = Me.err}

    f.MdiParent = Me
    f.Presentar()
  End Sub

  Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'DatosLaboralesToolStripMenuItem_Click(Nothing, Nothing)
  End Sub

  Private Sub AlumnosPorSecciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlumnosPorSecciónToolStripMenuItem.Click
    Dim f As New frmAlumnosSeccion With {.ErrorReporte = Me.err}

    f.DialogoGuardar = Me.sdfGuardar
    f.MdiParent = Me
    f.Presentar()
  End Sub

  Private Sub DatosDeAlumnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosDeAlumnoToolStripMenuItem.Click
    Dim f As New frmInformacionAlumno

    f.Presentar()
  End Sub

  Private Sub DirectorioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectorioToolStripMenuItem.Click
    frmDirectorio.Presentar(Me, Me.sdfGuardar)
  End Sub

  Private Sub DirectorioEspecialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectorioEspecialToolStripMenuItem.Click
    frmInformacion_Apellidos.Presentar(Me, Me.sdfGuardar)
  End Sub

  Private Sub MadresEHijoMayorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MadresEHijoMayorToolStripMenuItem.Click
    Dim frm As New frmListadoMadresHijoMayor

    frm.DialogoGuardar = Me.sdfGuardar
    frm.Presentar()
  End Sub

  Private Sub MadresEHijoMenorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MadresEHijoMenorToolStripMenuItem.Click
    Dim frm As New frmListadoMadresHijoMenor

    frm.DialogoGuardar = Me.sdfGuardar
    frm.Presentar()
  End Sub

  Private Sub PadresEHijoMayorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PadresEHijoMayorToolStripMenuItem.Click
    Dim frm As New frmListadoPadresHijoMayor

    frm.DialogoGuardar = Me.sdfGuardar
    frm.Presentar()
  End Sub

  Private Sub PadresEHijoMenorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PadresEHijoMenorToolStripMenuItem.Click
    Dim frm As New frmListadoPadresHijoMenor

    frm.DialogoGuardar = Me.sdfGuardar
    frm.Presentar()
  End Sub

  Private Sub mnuAlumnosCumpleanios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAlumnosCumpleanios.Click
    Dim frm As frmListadoAlumnosCumpleanios

    frm = frmListadoAlumnosCumpleanios.Crear
    frm.DialogoGuardar = Me.sdfGuardar
    frm.MdiParent = Me
    frm.Presentar()
  End Sub

  Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
    Dim f As New frmModificarClave

    f.Gestionar()
    f = Nothing
  End Sub

  Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
    Dim f As New frmAlumnosPorPadre

    f.Presentar()
  End Sub

End Class
