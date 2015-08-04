Public Class frmBuscarPersonal
  Private personal As New Personal
  Private Sub frmBuscarLibro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnBuscar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Buscar.png")
    Me.btnseleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
    txtNombreBuscar.Focus()
  End Sub
  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    BuscarPersonal()
  End Sub
  Private Sub BuscarPersonal()
    Dim rnPersonal As New RNPersonal
    Dim listaPersonal = rnPersonal.listarPersonal(txtNombreBuscar.Text.Trim)

    dgvLibros.AutoGenerateColumns = False
    dgvLibros.DataSource = listaPersonal
    If listaPersonal.Count > 0 Then
      dgvLibros.Focus()
    Else
      txtNombreBuscar.Focus()
    End If
  End Sub
  Private Sub Seleccionar()
    Try
      personal = CType(Me.dgvLibros.Rows(Me.dgvLibros.CurrentRow.Index).DataBoundItem, Personal)
      Me.Close()
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
  Public Function Buscar() As Personal
    Me.ShowDialog()
    If personal.NombreCompleto Is Nothing Then
      Return Nothing
    Else
      Return personal
    End If
  End Function

  Private Sub btnseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnseleccionar.Click, dgvLibros.DoubleClick
    Seleccionar()
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Close()
  End Sub
  Private Sub txtNombreBuscar_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombreBuscar.Enter
    Me.AcceptButton = btnBuscar
  End Sub
  Private Sub dgvLibros_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvLibros.KeyDown
    If e.KeyCode = Keys.Enter Then
      Seleccionar()
    End If
  End Sub
End Class