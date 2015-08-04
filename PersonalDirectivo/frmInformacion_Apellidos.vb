Public Class frmInformacion_Apellidos

  Private Shared frm As frmInformacion_Apellidos

  Private alumnos As List(Of Matricula)
  Private mDialogoGuardar As SaveFileDialog

  Public WriteOnly Property DialogoGuardar() As SaveFileDialog
    Set(ByVal value As SaveFileDialog)
      Me.mDialogoGuardar = value
    End Set
  End Property

  Private Sub frmPadresPorTrabajo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    MostrarImagenes()
    Me.txtAnio.Text = moAnioActual.Anio.ToString
  End Sub

  Private Sub MostrarImagenes()
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
  End Sub

  Public Shared Sub Presentar(ByVal wPadre As Form, ByVal wDialogoGuardar As SaveFileDialog)
    If frmInformacion_Apellidos.frm Is Nothing Then
      frmInformacion_Apellidos.frm = New frmInformacion_Apellidos
      With frmInformacion_Apellidos.frm
        .MdiParent = wPadre
        .DialogoGuardar = wDialogoGuardar

        .Show()
        .WindowState = FormWindowState.Maximized
      End With
    Else
      frmInformacion_Apellidos.frm.Activate()
    End If
  End Sub

  Private Sub dgvApoderados_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvApoderados.DoubleClick
    Dim f As frmInformacionAlumno

    If Me.dgvApoderados.CurrentRow IsNot Nothing Then
      f = New frmInformacionAlumno
      f.Presentar(DirectCast(Me.dgvApoderados.CurrentRow.DataBoundItem, Matricula).Alumno)
      f.Dispose()
      f = Nothing
    End If
  End Sub

  Private Sub btnBuscarAlumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarAlumno.Click
    Dim rn As New RNMatricula

    dgvApoderados.AutoGenerateColumns = False
    If txtAlumno.Text.Length > 0 Then
      rn = New RNMatricula
      Me.alumnos = rn.ListarDirectorio_Nombre(moAnioActual, txtAlumno.Text.Trim)
      Me.dgvApoderados.Columns.Item("cdSeccion").Visible = True
      dgvApoderados.DataSource = alumnos
    Else
      MessageBox.Show("Debe indicar los apellidos y nombres del alumno", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      dgvApoderados.DataSource = Nothing
    End If
  End Sub

  Private Sub frmInformacion_Apellidos_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmInformacion_Apellidos.frm = Nothing
  End Sub

  Private Sub frmInformacion_Apellidos_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
    txtAlumno.Focus()
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

End Class