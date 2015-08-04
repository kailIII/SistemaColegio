Public Class frmIdentificar

  Private Const MAXINTENTOS As Byte = 3
  Private Intentos As Integer = 0

  Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIdentificar.Click
    Dim rnU As New RNUsuario
    Dim o As Usuario
    Dim msje As String

    Intentos += 1
    o = rnU.Identificar(New Usuario(txtUsuario.Text, txtContrasena.Text))

    rnU = Nothing
    If o IsNot Nothing Then
      If Validar(o) Then
        Me.Close()
      End If
    Else
      If Me.Intentos = MAXINTENTOS Then
        mOUsuario = Nothing
        Me.Close()
      End If
      msje = "El nombre de usuario o contraseña son incorrectas. Sólo le quedan " & (MAXINTENTOS - Intentos).ToString & " intentos"
      Me.txtContrasena.Text = ""
      MessageBox.Show(msje, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If

  End Sub

  Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    mOUsuario = Nothing
    Me.Close()
  End Sub

  Private Function Validar(ByVal wUser As Usuario) As Boolean
    Dim rnU As New RNUsuario
    Dim o As Usuario

    o = rnU.VerificarAdministrativo(wUser)

    If o IsNot Nothing Then
      mOUsuario = o
      Me.Close()
    Else
      MessageBox.Show("El Usuario debe ser un administrativo!!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Function

  Private Sub frmIdentificar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.txtUsuario.Text = ""
    Me.txtContrasena.Text = ""
  End Sub

End Class
