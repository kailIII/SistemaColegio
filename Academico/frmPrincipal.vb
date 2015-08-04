Public Class frmPrincipal

  Private Sub mnuGestionCursos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestionCursos.Click
    Dim obj As New RNNivel
    Dim objG As New RNGrado
    Dim f As frmGestionCurso

    If obj.Listar.Count > 0 Then
      If objG.Leer.Count > 0 Then
        f = New frmGestionCurso
        f.Show(Me)
      Else
        MessageBox.Show("No existen grados registrados", "Gestión de cursos", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

    Else
      MessageBox.Show("No existen niveles registrados", "Gestión de cursos", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
    obj = Nothing
    objG = Nothing
  End Sub

  Private Sub mnuGestionDocentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestionDocentes.Click
    Dim f As New frmGestionDocente

    f.Show(Me)
  End Sub

  Private Sub mnuCargaAcademica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCargaAcademica.Click
    Dim f As frmCargaAcademica = frmCargaAcademica.Crear

    f.MdiParent = Me
    f.WindowState = FormWindowState.Maximized
    f.Gestionar()
  End Sub

  Private Sub mnuAperturaAnioEscolar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAperturaAnioEscolar.Click
    Dim f As New frmAperturaAnio

    f.Show(Me)
  End Sub

  Private Sub mnuGestionAlumnos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestionAlumnos.Click
    Dim f As New frmGestionAlumno

    f.Show(Me)
  End Sub

  Private Sub mnuGestionLocales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestionLocales.Click
    Dim f As New frmGestionLocales

    f.Show(Me)
  End Sub

  Private Sub mnuActaMatricula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuActaMatricula.Click
    Dim f As frmNominaMatriculados

    f = New frmNominaMatriculados
    f.Show(Me)
  End Sub

  Private Sub mnuGestionMatriculas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestionMatriculas.Click
    Dim objNivel As New RNNivel
    Dim objGrado As New RNGrado
    Dim objSec As New RNSeccion
    Dim f As frmGestionMatricula

    If moAnioActual IsNot Nothing AndAlso (objNivel.Listar.Count > 0 And objGrado.Leer.Count > 0 And objSec.LeerSeccion_Anio(New AnioLectivo(moAnioActual.anio)).Count > 0) Then
      f = New frmGestionMatricula
      f.Show(Me)
    Else
      MessageBox.Show("Ingrese año lectivo, niveles académicos, grados y secciones", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
    objGrado = Nothing
    objNivel = Nothing
    objSec = Nothing
  End Sub

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

  Private Sub mnuGestionHorarios_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuGestionHorarios.Click
    Dim objSec As New RNSeccion
    Dim objLoc As New RNLocal
    Dim f As frmGestionHorarios

    If moAnioActual IsNot Nothing AndAlso objSec.LeerSeccion_Anio(New AnioLectivo(moAnioActual.anio)).Count > 0 AndAlso objLoc.LeerLocal IsNot Nothing Then
      f = New frmGestionHorarios
      f.Show(Me)
    Else
      MessageBox.Show("Registre local, año lectivo, nivel, grado, seccion, aula", "Gestión de horarios", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
    objSec = Nothing
    objLoc = Nothing
  End Sub

  Private Sub GestionDePadresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestionDePadresToolStripMenuItem.Click
    Dim f As New frmGestionApoderado

    f.Gestionar()
  End Sub

  Private Sub GestiónDeAmbientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestiónDeAmbientesToolStripMenuItem.Click
    Dim f As New frmGestionAmbientes

    f.Show(Me)
  End Sub

  Private Sub mnuGestionNiveles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestionNiveles.Click
    Dim f As New frmGestionNiveles

    f.Show(Me)
  End Sub

  Private Sub mnuGestionGrados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestionGrados.Click
    Dim obj As New RNNivel
    Dim f As frmGestionGrados

    If obj.Listar.Count > 0 Then
      f = New frmGestionGrados
      f.Show(Me)
    Else
      MessageBox.Show("No existen niveles registrados", "Gestión de grados", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
    obj = Nothing
  End Sub

  Private Sub GestiónDREToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestiónDREToolStripMenuItem.Click
    Dim f As New frmGestionDRE

    f.Gestionar()
  End Sub

  Private Sub GestiónÁreasDREToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestiónÁreasDREToolStripMenuItem.Click
    Dim f As New frmGestionAreasDRE
    f.Gestionar()
  End Sub

  Private Sub GestiónDeProfesionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestiónDeProfesionesToolStripMenuItem.Click
    Dim f As New frmGestionProfesion

    f.gestionar()
  End Sub

  Private Sub GestiónDeOcupacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestiónDeOcupacionesToolStripMenuItem.Click
    Dim f As New frmgestionOcupacion

    f.gestionar()
  End Sub

  Private Sub mnuGestionTurnos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestionTurnos.Click
    Dim f As New frmGestionTurno

    f.Gestionar()
  End Sub

  Private Sub GestiónUbicaciónGeográficaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestiónUbicaciónGeográficaToolStripMenuItem.Click
    Dim f As New frmGestionUbicacionGeografica

    f.Gestionar()
  End Sub

  Private Sub MatrículaAutomáticaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMatrículaAutomáticaToolStripMenuItem.Click
    Dim f As New frmMatriculaAutomatica

    f.Gestionar()
  End Sub

  Private Sub GestiónDeCapacidadesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestiónDeCapacidadesToolStripMenuItem.Click
    Dim frm As New frmGestionCapacidad

    frm.Gestionar()
  End Sub

  Private Sub mnuRegistroDeSeccionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRegistroDeSeccionesToolStripMenuItem.Click
    Dim f As frmGestionSecciones
    Dim objL As RNLocal
    Dim objA As RNAula

    If moAnioActual IsNot Nothing Then
      f = New frmGestionSecciones
      objL = New RNLocal
      If objL.Leer.Count > 0 Then
        objA = New RNAula
        If objA.ListarTodasAulas.Count > 0 Then
          f.Show(Me)
        Else
          MessageBox.Show("Registre aulas", "Gestión de secciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
      Else
        MessageBox.Show("Registre local y aulas", "Gestión de secciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If
    Else
      MessageBox.Show("registre año lectivo, local y aulas", "Gestión de secciones", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub GeneraciónDeNúmerosDeOrdenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGeneraciónDeNúmerosDeOrdenToolStripMenuItem.Click
    Dim f As New frmGenerarNumerosOrden

    f.Show(Me)
  End Sub

  Private Sub mnuTrasladoDeAlumnosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTrasladoDeAlumnosToolStripMenuItem.Click
    Dim f As New frmTrasladoAlumnos

    f.Gestionar()
  End Sub

  Private Sub mnuGestiónDeVirtudes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestiónDeVirtudes.Click
    Dim frm As New frmVirtudComportamiento

    frm.Gestion()
  End Sub

  Private Sub mnuGestionEquivalencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestionEquivalencias.Click
    Dim frm As New frmEquivNotasComp

    frm.Gestionar()
  End Sub

  Private Sub mnuCodigosEducando_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCodigosEducando.Click
    Dim frm As New frmReporte01

    frm.Gestionar()
  End Sub

  Private Sub mnuResumenNot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuResumenNot.Click
    Dim frm As New frmResumenTriAsig

    frm.DialogoGuardar = Me.sfdGuardar
    frm.Gestionar()
  End Sub

  Private Sub mnuLibretaIndicadores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLibretaIndicadores.Click
    Dim f As New frmLibretaIndicadores

    f.Gestionar()
  End Sub

  Private Sub mnuConsolidadoNotas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConsolidadoNotas.Click
    Dim f As New frmConsolidadoIndicadores

    f.Gestionar()
  End Sub

  Private Sub mnuResumenNotasArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuResumenNotasArea.Click
    Dim frm As New frmResumenNotasArea

    frm.Gestionar()
  End Sub

  Private Sub mnuConsolidadoNotasSec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConsolidadoNotasSec.Click
    Dim frm As New frmConsolidadoSec
    frm.Gestionar()
  End Sub

  Private Sub mnuCierrePeriodoAcademico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCierrePeriodoAcademico.Click
    Dim frm As New frmCerrarPeriodo

    frm.Gestionar()
  End Sub

  Private Sub mnuLibretaSecundaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLibretaSecundaria.Click
    Dim frm As New frmLibretasSecundaria

    frm.Gestionar()
  End Sub

  Private Sub mnuPromedioPonderado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPromedioPonderado.Click
    Dim frm As New frmPonderado

    frm.Gestionar()
  End Sub

  Private Sub mnuInicialYPrimaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInicialYPrimaria.Click
    Dim frm As New frmRegistroNotasIndicadores

    frm.Gestionar()
  End Sub

  Private Sub mnuSecundaria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSecundaria.Click
    Dim frm As frmNotasSecundaria = frmNotasSecundaria.Crear

    frm.MdiParent = Me
    frm.Gestionar(Me.ofdBuscarArchivo)
  End Sub

  Private Sub mnuAsistencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAsistencias.Click
    Dim frm As New frmReporteAsistenciaMensual

    frm.Gestionar()
  End Sub

  Private Sub mnuGestiónDeAutores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestiónDeAutores.Click
    Dim frm As New frmGestionAutor

    frm.Gestionar()
  End Sub

  Private Sub mnuGestiónDePresentaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestiónDePresentaciones.Click
    Dim frm As New frmGestionPresentacion

    frm.Gestionar()
  End Sub

  Private Sub mnuAsignaciónLibros_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuAsignaciónLibros.Click
    Dim frm As New frmGestionProgLectura

    frm.Gestionar()
  End Sub

  Private Sub mnuRegistrarLibros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRegistrarLibros.Click
    Dim frm As New frmGestionLibro

    frm.Gestionar()
  End Sub

  Private Sub mnuAsignarPorGrados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAsignarPorGrados.Click
    Dim frm As New frmAsignacionLibroGrado

    frm.Gestionar()
  End Sub

  Private Sub ComportamientoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComportamientoToolStripMenuItem.Click
    Dim frm As New frmComportamiento

    frm.DialogoGuardar = Me.sfdGuardar
    frm.DialogoAbrir = Me.ofdBuscarArchivo
    frm.Gestion()
  End Sub

  Private Sub mnuTrasladoAlumnosColegio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTrasladoAlumnosColegio.Click
    Dim frm As New frmTraslado

    frm.Gestionar()
  End Sub

  Private Sub mnuReuniones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReuniones.Click
    Dim frm As New frmReporteReuniones01

    frm.Gestionar()
  End Sub

  Private Sub mnuReuniones02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReuniones02.Click
    Dim frm As New frmReporteReuniones02

    frm.Gestionar()
  End Sub

  Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
    Dim f As New frmReporteIngresoCalificaciones

    f.Presentar()
  End Sub

  Private Sub mnuActaNotasFinales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuActaNotasFinales.Click
    Dim f As New frmActaNotas

    f.ShowDialog()
  End Sub

  Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
    Dim f As New frmInformacionAlumno

    f.presentar()
  End Sub

  Private Sub ReportesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportesToolStripMenuItem.Click
    frmListadoReportes.Presentar(Me, Me.sfdGuardar)
  End Sub

  Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
    frmGestionarPersonas.Presentar(Me)
  End Sub

  Private Sub PeriodoAcadémicoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeriodoAcadémicoToolStripMenuItem.Click
    Dim frm As New frmGestionarPeriodos

    frm = frmGestionarPeriodos.crear(Me)
    frm.presentar()
  End Sub

End Class
