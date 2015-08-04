Public Class BuscarPersonas

  Public Event DobleClicGrid()

  Public Sub New()
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
    ' Agregue cualquier inicialización después de la llamada a InitializeComponent()
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Dim obj As New RNApoderado
    Dim la As List(Of Apoderado)

    la = obj.ListarPersonas(txtNombreBuscar.Text.Trim)
    dgvApoderado.AutoGenerateColumns = False
    dgvApoderado.DataSource = la

    If la.Count > 0 Then
      dgvApoderado.Focus()
    Else
      txtNombreBuscar.Focus()
    End If
  End Sub

  Private Sub BuscarApoderado_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    txtNombreBuscar.Text = ""
    txtNombreBuscar.Focus()
  End Sub

  Private Sub txtNombreBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreBuscar.KeyPress
    If Char.IsLetter(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False And _
    Char.IsSeparator(e.KeyChar) = False AndAlso e.KeyChar <> "'"c Then
      e.Handled = True
    End If
  End Sub

  Private Sub txtNombreBuscar_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreBuscar.Enter
    Me.ParentForm.AcceptButton = btnBuscar
  End Sub

  Private Sub dgvApoderado_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvApoderado.DoubleClick
    RaiseEvent DobleClicGrid()
  End Sub

  Private Sub dgvApoderado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvApoderado.KeyDown
    If e.KeyCode = Keys.Enter Then
      RaiseEvent DobleClicGrid()
    End If
  End Sub

End Class
