Public Class frmGestionNiveles

  Private codigoEstado As Integer = 0
  Private codNivel As Integer = 0

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub txtNombreNivel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreNivel.KeyPress
    If Char.IsLetter(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False And _
            Char.IsSeparator(e.KeyChar) = False AndAlso e.KeyChar <> "'"c Then
      e.Handled = True
    End If
  End Sub

  Private Sub txtNombreNivel_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombreNivel.Validating
    If Me.txtNombreNivel.Text.Length = 0 Then
      e.Cancel = True
      errorNiveles.SetError(Me.txtNombreNivel, "Ingrese el nombre del nivel")
    Else
      errorNiveles.SetError(Me.txtNombreNivel, Nothing)
    End If
  End Sub

  Private Sub frmNiveles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnRegistrar.Text = "&Registrar"
    Me.txtNombreNivel.CharacterCasing = CharacterCasing.Upper
    Me.txtSiglas.CharacterCasing = CharacterCasing.Upper
    MostrarImagenes()
    AgregarNivel()
    Habilitar()
  End Sub

  Public Sub MostrarImagenes()
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnActualizar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Editar.jpg")
  End Sub

  Public Sub Habilitar()
    If dgvNiveles.RowCount = 0 Then
      Me.btnActualizar.Enabled = False
      'Me.btnEliminar.Enabled = False
    Else
      Me.btnActualizar.Enabled = True
      'Me.btnEliminar.Enabled = True
    End If
  End Sub

  Public Sub AgregarNivel()
    Dim obj As New RNNivel
    Dim ln As List(Of Nivel)

    ln = obj.Listar()
    dgvNiveles.AutoGenerateColumns = False
    dgvNiveles.DataSource = ln
    Me.dgvNiveles.Columns(0).DataPropertyName = "Nombre"
    Me.dgvNiveles.Columns(1).DataPropertyName = "Siglas"
    Me.dgvNiveles.Columns(2).DataPropertyName = "Codigo"
    Me.dgvNiveles.Columns("cdCodigoModular").DataPropertyName = "CodigoModular"

  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim obj As RNNivel
    If Me.ValidateChildren Then
      obj = New RNNivel
      Try
        If codigoEstado = 0 Then
          obj.Registrar(New Nivel(0, Me.txtNombreNivel.Text.Trim, Me.txtSiglas.Text.Trim, txtCodigoModular.Text.Trim))
          MessageBox.Show("Nivel académico registrado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          Limpiar()
        Else
          obj.Actualizar(New Nivel(codNivel, Me.txtNombreNivel.Text.Trim, Me.txtSiglas.Text.Trim, txtCodigoModular.Text.Trim))
          MessageBox.Show("Datos actualizados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          Limpiar()
        End If
        AgregarNivel()
        Habilitar()
        Me.txtNombreNivel.Focus()
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        obj = Nothing
      End Try
    End If
  End Sub

  Public Sub Limpiar()
    codigoEstado = 0
    Me.txtNombreNivel.Text = ""
    Me.txtSiglas.Text = ""
    Me.txtCodigoModular.Text = ""
    Me.btnRegistrar.Text = "&Registrar"
  End Sub

  Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click, dgvNiveles.DoubleClick
    If dgvNiveles.SelectedRows.Count > 0 Then
      With CType(dgvNiveles.SelectedRows.Item(0).DataBoundItem, Nivel)
        Me.txtNombreNivel.Text = .Nombre.Trim
        Me.txtSiglas.Text = .Siglas
        Me.txtCodigoModular.Text = .CodigoModular
        codNivel = .Codigo
      End With
      Me.btnRegistrar.Text = "&Actualizar"
      codigoEstado = 1
    End If
  End Sub

  Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'Dim obj As RNNivel

    'If dgvNiveles.RowCount > 0 Then
    '  obj = New RNNivel
    '  Try

    '    obj.Eliminar(New Nivel(CType(dgvNiveles.SelectedRows.Item(0).DataBoundItem, Nivel).CodigoModular, ""))
    '    MessageBox.Show("Nivel académico eliminado", "Gestión de niveles", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    AgregarNivel()
    '  Catch ex As Exception
    '    MessageBox.Show(ex.Message, "Gestión de niveles", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '  Finally
    '    obj = Nothing
    '  End Try
    'Else
    '  MessageBox.Show("No existen niveles", "Gestión de niveles", MessageBoxButtons.OK, MessageBoxIcon.Information)
    'End If
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Limpiar()
    errorNiveles.SetError(Me.txtNombreNivel, Nothing)
    errorNiveles.SetError(Me.txtSiglas, Nothing)
    errorNiveles.SetError(Me.txtCodigoModular, Nothing)

    Me.txtNombreNivel.Focus()
  End Sub

  Private Sub txtSiglas_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSiglas.Validating
    If Me.txtSiglas.Text.Length = 0 Then
      e.Cancel = True
      errorNiveles.SetError(Me.txtSiglas, "Ingrese 3 caracteres para las siglas")
    Else
      errorNiveles.SetError(Me.txtSiglas, Nothing)
    End If
  End Sub

  Private Sub txtCodigoModular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoModular.KeyPress
    If Char.IsDigit(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False Then
      e.Handled = True
    End If

  End Sub

  Private Sub txtCodigoModular_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodigoModular.Validating
    If Me.txtCodigoModular.Text.Length = 0 Then
      e.Cancel = True
      errorNiveles.SetError(Me.txtNombreNivel, "Ingrese el código modular del nivel")
    Else
      errorNiveles.SetError(Me.txtNombreNivel, Nothing)
    End If

  End Sub
End Class