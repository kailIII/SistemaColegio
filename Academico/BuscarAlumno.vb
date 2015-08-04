Public Class BuscarAlumno

  Public Event DobleClicGrid()

  Public Sub New()
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
  End Sub
  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Dim obj As New RNAlumno
    Dim la As List(Of Alumno)
    la = obj.Listar(txtNombreBuscar.Text.Trim)
    dgvAlumnos.AutoGenerateColumns = False
    dgvAlumnos.DataSource = la
    If la.Count > 0 Then
      dgvAlumnos.Focus()
    Else
      txtNombreBuscar.Focus()
    End If

  End Sub
    Private Sub BuscarAlumno_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    txtNombreBuscar.Text = ""
    txtNombreBuscar.Focus()
  End Sub

  Private Sub dgvAlumnos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvAlumnos.DoubleClick
    RaiseEvent DobleClicGrid()
  End Sub


  Private Sub txtNombreBuscar_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombreBuscar.Enter
    Me.ParentForm.AcceptButton = btnBuscar
  End Sub

  Private Sub dgvAlumnos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvAlumnos.KeyDown
    If e.KeyCode = Keys.Enter Then
      RaiseEvent DobleClicGrid()
    End If
  End Sub

End Class
