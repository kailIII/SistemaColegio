Public Class frmGestionProfesion
  Private Codigo As Integer

  Private Sub frmGestionProfesion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnActualizar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
    Me.btnBuscar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "/Imagenes/Buscar.png")
    Me.txtNombre.CharacterCasing = CharacterCasing.Upper
    Me.txtBuscar.CharacterCasing = CharacterCasing.Upper

    AgregarProfesion()
    Habilitar()
  End Sub
  Public Sub gestionar()
    Me.ShowDialog()
  End Sub

  Public Sub AgregarProfesion()
    Dim obj As New RNProfesion
    Dim la As List(Of Profesion)
    la = obj.ListarProfesiones
    dgvProfesion.AutoGenerateColumns = False
    dgvProfesion.DataSource = la
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Dim obj As New RNProfesion
    Dim la As List(Of Profesion)
    la = obj.ListarProfesiones_Nombre(txtBuscar.Text.Trim)
    dgvProfesion.AutoGenerateColumns = False
    dgvProfesion.DataSource = la
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    InicializarControles()
  End Sub
  Public Sub InicializarControles()
    Me.Codigo = 0
    txtNombre.Text = ""
    Me.btnRegistrar.Text = "&Registrar"
    txtNombre.Focus()
  End Sub
  Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click, dgvProfesion.DoubleClick

    Dim obj As RNProfesion = Nothing
    Dim P As Profesion = Nothing

    If dgvProfesion.SelectedRows.Count > 0 Then
      With CType(dgvProfesion.SelectedRows.Item(0).DataBoundItem, Profesion)
        obj = New RNProfesion
        P = obj.LeerProfesion_Codigo(New Profesion(.Codigo, Nothing))
        If P IsNot Nothing Then
          Codigo = .Codigo
          txtNombre.Text = P.Nombre
          btnRegistrar.Text = "&Actualizar"
          txtNombre.Focus()
        Else
          MessageBox.Show("No se pudo encontrar la profesión solicitada", "Gestión de Profesiones", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

      End With
    End If
  End Sub
  Public Sub Habilitar()
    If dgvProfesion.RowCount = 0 Then
      Me.btnActualizar.Enabled = False
    Else
      Me.btnActualizar.Enabled = True
    End If
  End Sub
  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    If Me.ValidateChildren() Then
      Dim obj As New RNProfesion
      Try
        If Codigo = 0 Then
          obj.Registrar(New Profesion(Nothing, txtNombre.Text))

          MessageBox.Show("La profesión se registró exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          obj.Modificar(New Profesion(Codigo, txtNombre.Text))

          MessageBox.Show("Los datos se actualizaron exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        InicializarControles()
        AgregarProfesion()
        Habilitar()

      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        obj = Nothing
      End Try
    End If
  End Sub

  Private Sub txtNombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
    If txtnombre.Text.Length = 0 Then
      e.Cancel = True
      ErrProfesion.SetError(txtNombre, "Debe indicar Nombre de la profesión")
    Else
      ErrProfesion.SetError(txtNombre, "")
    End If
  End Sub
End Class