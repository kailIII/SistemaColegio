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

    If mOInstitucion IsNot Nothing Then
      Me.Text &= " - " & mOInstitucion.Nombre
    End If
  End Sub

  Private Sub mnuIndividual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIndividual.Click
    Dim f As New frmGestionIndicadores
    f.Gestionar()
  End Sub

  Private Sub mnuGrupal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGrupal.Click
    Dim f As New frmGestionIndicadoresGrupal
    f.Gestionar()
  End Sub

  Private Sub mnuNotasIndicador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNotasIndicador.Click
    Dim f As New frmRegistroNotasIndicadores

    f.Gestionar()
  End Sub

  Private Sub mnuNotasCapacidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNotasCapacidad.Click
    Dim f As New frmNotasSecundaria

    f.Gestionar()
  End Sub

  Private Sub IngresoDeCalificacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresoDeCalificacionesToolStripMenuItem.Click
    Dim f As New frmReporteIngresoCalificacionesSecundaria
    f.MdiParent = Me
    f.Presentar()
  End Sub

  Private Sub ResumenDeAsistenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumenDeAsistenciaToolStripMenuItem.Click
    Dim f As New frmReporteAsistencia

    f.MdiParent = Me
    f.Presentar()
  End Sub

  Private Sub RegistrarPromediosDeAreaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrarPromediosDeAreaToolStripMenuItem.Click
    Dim f As New frmImportarPromediosArea

    f.MdiParent = Me
    f.Show()
  End Sub

  Private Sub mnuConsolidadoTrimestralAreasCapacidades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConsolidadoTrimestralAreasCapacidades.Click
    With frmConsolidadoPeriodoAreaCapacidad.Crear
      .DialogoGuardar = Me.sfdDialogoGuardar
      .MdiParent = Me
      .Presentar()
    End With
  End Sub

  Private Sub mnuConsolidadoAnualAreaPeriodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConsolidadoAnualAreaPeriodo.Click
    With frmConsolidadoAnioAreaPeriodo.Crear
      .DialogoGuardar = Me.sfdDialogoGuardar
      .MdiParent = Me
      .Presentar()
    End With
  End Sub

  Private Sub mnuConsolidadoAnualCursoPeriodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConsolidadoAnualCursoPeriodo.Click
    With frmConsolidadoAnioCursoPeriodo.Crear
      .DialogoGuardar = Me.sfdDialogoGuardar
      .MdiParent = Me
      .Presentar()
    End With

  End Sub

  Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
    Dim f As New frmReporteIngresoCalificacionesPrimaria
    f.MdiParent = Me
    f.Presentar()
  End Sub

  Private Sub EvoluciónDeConductaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EvoluciónDeConductaToolStripMenuItem.Click
    With frmEvolucionComportamiento.Crear
      .DialogoGuardar = Me.sfdDialogoGuardar
      .MdiParent = Me
      .Presentar()
    End With
  End Sub

  Private Sub ResumenDeRegistroDeAsistenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumenDeRegistroDeAsistenciaToolStripMenuItem.Click
    With frmListadoAsistencia.Crear(Me)
      .DialogoGuardar = Me.sfdDialogoGuardar
      .Presentar()
    End With
  End Sub

End Class
