Public Class frmIdentificar

  Private Const MAXINTENTOS As Byte = 3
  Private Intentos As Integer = 0

  Private Sub btnIdentificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIdentificar.Click
    Dim rnU As New RNUsuario
    Dim rnCajaChica As New RNCajaChica
    Dim oUsuario As Usuario
    Dim msje As String
    Dim oRespCajaChica As ResponsableCajaChica

    Intentos += 1
    oUsuario = rnU.Identificar(New Usuario(txtUsuario.Text, txtContrasena.Text))

    rnU = Nothing

    If oUsuario IsNot Nothing Then
      oRespCajaChica = rnCajaChica.IdentificarResponsableCajaChica(oUsuario)
      If oRespCajaChica IsNot Nothing Then
        mOUsuario = oUsuario
        Me.Close()
      Else
        If Me.Intentos = MAXINTENTOS Then
          mOUsuario = Nothing
          Me.Close()
        End If
        msje = "El nombre de usuario no es responsable de la caja chica. Sólo le quedan " & (MAXINTENTOS - Intentos).ToString & " intentos"
        Me.txtContrasena.Text = ""
        MessageBox.Show(msje, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
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

End Class