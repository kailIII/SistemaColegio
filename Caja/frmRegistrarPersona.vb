Public Class frmRegistrarPersona

  Private Persona As Persona

  Private mControlError As ErrorProvider

  Public WriteOnly Property ControlError() As ErrorProvider
    Set(ByVal value As ErrorProvider)
      Me.mControlError = value
    End Set
  End Property

  Private Sub frmRegistrarPersona_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes/cancelar.png")
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes/Buscar.png")
  End Sub

  Public Function Registrar() As Persona
    Me.cbSexo.SelectedIndex = 0
    Me.dtpFechaNac.Value = Date.Today

    Me.ShowDialog()
    Return Me.Persona
  End Function

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click

    If Me.ValidateChildren() Then

      Persona = New Persona(-1, txtNombre.Text.Trim, txtApellidoPat.Text.Trim, txtApellidoMat.Text.Trim)
      Persona.Sexo = cbSexo.Text.Substring(0, 1)
      Persona.FechaNacimiento = Me.dtpFechaNac.Value

      Me.Close()
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub txtNombre_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating, txtApellidoPat.Validating, txtApellidoMat.Validating
    If DirectCast(sender, Control).Text.Length > 0 Then
      Me.mControlError.SetError(DirectCast(sender, Control), "")
    Else
      Me.mControlError.SetError(DirectCast(sender, Control), "Debe indicar el nombre")
      e.Cancel = True
    End If
  End Sub

  Private Sub cbSexo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbSexo.Validating
    If cbSexo.SelectedIndex > -1 Then
      Me.mControlError.SetError(cbSexo, "")
    Else
      Me.mControlError.SetError(cbSexo, "Debe seleccionar el sexo")
      e.Cancel = True
    End If
  End Sub

End Class
