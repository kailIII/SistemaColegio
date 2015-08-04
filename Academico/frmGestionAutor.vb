Public Class frmGestionAutor
  Private Codigo As Integer = 0
#Region "Validacion"
  Private Sub txtNombreBuscar_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombreBuscar.Enter
    Me.AcceptButton = btnBuscar
  End Sub

  Private Sub txtNombreBuscar_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombreBuscar.Leave
    Me.AcceptButton = btnRegistrar
  End Sub

  Private Sub dgvAutores_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvAutores.KeyDown
    If e.KeyCode = Keys.Enter Then
      Seleccionar()
    End If
  End Sub

  Private Sub txtNombres_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombres.Validating
    If txtNombres.Text.Length = 0 Then
      e.Cancel = True
      ErrAutor.SetError(txtNombres, "Debe indicar nombre del autor")
    Else
      ErrAutor.SetError(txtNombres, "")
    End If
  End Sub

  Private Sub txtApellidos_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtApellidos.Validating
    If txtApellidos.Text.Length = 0 Then
      e.Cancel = True
      ErrAutor.SetError(txtApellidos, "Debe indicar el apellido del autor")
    Else
      ErrAutor.SetError(txtApellidos, "")
    End If

  End Sub
#End Region

  Private Sub frmAutor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnActualizar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
    Me.btnBuscar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "/Imagenes/Buscar.png")
    AgregarAutor()
    Habilitar()
    txtNombreBuscar.Focus()
  End Sub
  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub
  Private Sub Limpiar()
    Me.Codigo = 0
    Me.txtNombres.Text = ""
    Me.txtApellidos.Text = ""
    Me.btnRegistrar.Text = "&Registrar"
    Me.txtNombres.Focus()
    ErrAutor.SetError(txtNombres, "")
    ErrAutor.SetError(txtApellidos, "")
  End Sub
  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Limpiar()
  End Sub
  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Dim obj As New RNLibro
    Dim la As List(Of Autor)
    la = obj.ListarAutores(txtNombreBuscar.Text)
    dgvAutores.AutoGenerateColumns = False
    dgvAutores.DataSource = la
    If la.Count > 0 Then
      dgvAutores.Focus()
    Else
      txtNombreBuscar.Focus()
    End If
  End Sub
  Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click, dgvAutores.DoubleClick
    Seleccionar()
  End Sub
  Private Sub Seleccionar()
    Dim obj As RNLibro = Nothing
    Dim A As Autor = Nothing

    If dgvAutores.SelectedRows.Count > 0 Then
      With CType(dgvAutores.SelectedRows.Item(0).DataBoundItem, Autor)
        obj = New RNLibro
        A = obj.LeerAutor_Codigo(New Autor(.Codigo, "", ""))
        If A IsNot Nothing Then
          Codigo = .Codigo
          txtNombres.Text = A.Nombres
          txtApellidos.Text = A.Apellidos
          btnRegistrar.Text = "&Actualizar"
          txtNombres.Focus()
        Else
          MessageBox.Show("No se pudo encontrar el autor solicitado", "Gestión de Autores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

      End With
    End If
  End Sub
  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    If Me.ValidateChildren() Then
      Dim obj As New RNLibro
      Try
        If Codigo = 0 Then
          obj.RegistrarAutor(New Autor(Nothing, txtNombres.Text, txtApellidos.Text))

          MessageBox.Show("El autor se registró exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          obj.ActualizarAutor(New Autor(Codigo, txtNombres.Text, txtApellidos.Text))

          MessageBox.Show("Los datos se actualizaron exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Limpiar()
        AgregarAutor()
        Habilitar()
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        obj = Nothing
      End Try
    End If
  End Sub
  Public Sub AgregarAutor()
    Dim obj As New RNLibro
    Dim la As List(Of Autor)
    la = obj.ListarAutores("")
    dgvAutores.AutoGenerateColumns = False
    dgvAutores.DataSource = la
  End Sub
  Public Sub Habilitar()
    If dgvAutores.RowCount = 0 Then
      Me.btnActualizar.Enabled = False
    Else
      Me.btnActualizar.Enabled = True
    End If
  End Sub
  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub
End Class