Public Class frmCuentasUsuario
  Private Sub txtClaveActual_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtClaveActual.Validating
    If txtClaveActual.Text.Length = 0 Then
      e.Cancel = True
      ErrUser.SetError(txtClaveActual, "Debe indicar la contraseña actual")
    Else
      ErrUser.SetError(txtClaveActual, "")
    End If
  End Sub

  Private Sub txtClaveNueva_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtClaveNueva.Validating
    If txtClaveNueva.Text.Length = 0 Then
      e.Cancel = True
      ErrUser.SetError(txtClaveNueva, "Debe indicar la contraseña Nueva")
    Else
      ErrUser.SetError(txtClaveNueva, "")
    End If
  End Sub

  Private Sub txtReClaveNueva_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtReClaveNueva.Validating
    If txtReClaveNueva.Text.Length = 0 Then
      e.Cancel = True
      ErrUser.SetError(txtReClaveNueva, "Debe indicar la contraseña Nueva")
    Else
      ErrUser.SetError(txtReClaveNueva, "")
    End If
  End Sub

  Private Sub Limpiar()
    Me.txtClaveActual.Text = ""
    Me.txtClaveNueva.Text = ""
    Me.txtReClaveNueva.Text = ""
    Me.txtClaveActual.Focus()
  End Sub
  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub frmCuentasUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.txtUsuario.Text = mOUsuario.Nombre
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.txtClaveActual.Focus()
  End Sub
  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim obj As RNUsuario = Nothing
    Dim U As Usuario = Nothing
    If Me.ValidateChildren Then
      obj = New RNUsuario
      U = New Usuario
      Try
        U = obj.Identificar(New Usuario(txtUsuario.Text, txtClaveActual.Text))
        If U IsNot Nothing Then
          If txtClaveNueva.Text.Trim = txtReClaveNueva.Text.Trim Then
            obj.CambiarClave(mOUsuario, txtClaveNueva.Text)
            MessageBox.Show("La contraseña se actualizo exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
          Else

            MessageBox.Show("Error en ingreso de nueva contraseña, no coincide confirmacion... intente nuevamente...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtClaveNueva.Focus()
          End If
        Else
          MessageBox.Show("La contraseña actual no es correcta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          txtClaveActual.Focus()
        End If

      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

      Finally
        obj = Nothing
        U = Nothing
      End Try
    End If

  End Sub

  Private Sub txtUsuario_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.Enter
    Me.txtClaveActual.Focus()
  End Sub

End Class