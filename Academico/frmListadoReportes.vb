Public Class frmListadoReportes

  Private Class Reporte

    Private mReporte As String
    Private mFormulario As iReporte

    Public Property Reporte() As String
      Get
        Return mReporte
      End Get
      Set(ByVal value As String)
        mReporte = value
      End Set
    End Property

    Public Property Formulario() As iReporte
      Get
        Return mFormulario
      End Get
      Set(ByVal value As iReporte)
        mFormulario = value
      End Set
    End Property

  End Class

  Private Shared frm As frmListadoReportes = Nothing

  Private mDialogoGuardar As SaveFileDialog

  Public WriteOnly Property DialogoGuardar() As SaveFileDialog
    Set(ByVal value As SaveFileDialog)
      Me.mDialogoGuardar = value
    End Set
  End Property

  Private Sub New()
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
  End Sub

  Public Shared Sub Presentar(ByVal wPadre As Form, ByVal wDialogoGuardar As SaveFileDialog)
    If frm Is Nothing Then
      frm = New frmListadoReportes
      frm.MdiParent = wPadre
      frm.DialogoGuardar = wDialogoGuardar
      frm.Show()
      frm.WindowState = FormWindowState.Maximized
    Else
      frm.Activate()
    End If
  End Sub

  Private Sub frmListadoReportes_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmListadoReportes.frm = Nothing
  End Sub

  Private Sub frmListadoReportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    LlenarReportes()
  End Sub

  Private Sub LlenarReportes()
    Dim Reps As Reporte() = {New Reporte With {.Reporte = "Alumnos y apoderados", .Formulario = New frmAlumnosSeccion}, _
                             New Reporte With {.Reporte = "Madres e hijo mayor", .Formulario = New frmListadoMadresHijoMayor}, _
                             New Reporte With {.Reporte = "Madres e hijo menor", .Formulario = New frmListadoMadresHijoMenor}, _
                             New Reporte With {.Reporte = "Consolidado anual por áreas y periodo", .Formulario = frmConsolidadoAnioAreaPeriodo.Crear}, _
                             New Reporte With {.Reporte = "Consolidado anualpor cursos y periodo", .Formulario = frmConsolidadoAnioCursoPeriodo.Crear}, _
                             New Reporte With {.Reporte = "Consolidado periódico por áreas y capacidades - Secundaria", .Formulario = frmConsolidadoPeriodoAreaCapacidad.Crear}, _
                             New Reporte With {.Reporte = "Avance de ingreso de notas - Primaria", .Formulario = New frmReporteIngresoCalificacionesPrimaria}, _
                             New Reporte With {.Reporte = "Avance de ingreso de notas - Secundaria", .Formulario = New frmReporteIngresoCalificacionesSecundaria}, _
                             New Reporte With {.Reporte = "Registro de asistencia", .Formulario = frmListadoAsistencia.Crear}, _
                             New Reporte With {.Reporte = "Listado de alumnos", .Formulario = frmListadoAlumnos.Crear}, _
                             New Reporte With {.Reporte = "Listado completo de alumnos", .Formulario = frmListadoAlumnosDNI.Crear}, _
                             New Reporte With {.Reporte = "Consolidado de promedios literales por periodo ", .Formulario = frmConsolidadoPromedioLiteralPeriodo.crear}
                             }

    DirectCast(Reps(1).Formulario, frmListadoMadresHijoMayor).DialogoGuardar = Me.mDialogoGuardar
    DirectCast(Reps(2).Formulario, frmListadoMadresHijoMenor).DialogoGuardar = Me.mDialogoGuardar
    DirectCast(Reps(3).Formulario, frmConsolidadoAnioAreaPeriodo).DialogoGuardar = Me.mDialogoGuardar
    DirectCast(Reps(4).Formulario, frmConsolidadoAnioCursoPeriodo).DialogoGuardar = Me.mDialogoGuardar
    DirectCast(Reps(5).Formulario, frmConsolidadoPeriodoAreaCapacidad).DialogoGuardar = Me.mDialogoGuardar
    DirectCast(Reps(8).Formulario, frmListadoAsistencia).DialogoGuardar = Me.mDialogoGuardar
    DirectCast(Reps(9).Formulario, frmListadoAlumnos).DialogoGuardar = Me.mDialogoGuardar
    DirectCast(Reps(10).Formulario, frmListadoAlumnosDNI).DialogoGuardar = Me.mDialogoGuardar
    DirectCast(Reps(11).Formulario, frmConsolidadoPromedioLiteralPeriodo).DialogoGuardar = Me.mDialogoGuardar

    Me.lstReportes.DisplayMember = "Reporte"
    Me.lstReportes.DataSource = Reps
  End Sub

  Private Sub btnPresentar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPresentar.Click
    Dim f As iReporte = Nothing

    If Me.lstReportes.SelectedIndex > -1 Then
      f = DirectCast(Me.lstReportes.SelectedItem, Reporte).Formulario
      f.Presentar()
    Else
      MessageBox.Show("Debe seleccionar el reporte", Me.Text, MessageBoxButtons.OK)
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

End Class