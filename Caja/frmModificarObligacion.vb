Public Class frmModificarObligacion

  Private mOObligacion As Obligacion

  Public Sub Presentar(ByVal wObligacion As Obligacion)

    Me.mOObligacion = wObligacion
    LeerDatos()
    Me.ShowDialog()
  End Sub

  Private Sub LeerDatos()
    Dim rn As New RNObligacion

    Me.mOObligacion = rn.Leer(Me.mOObligacion)
    rn = Nothing

    txtDescripcion.Text = Me.mOObligacion.Descripcion
    nudMonto.Value = CDec(Me.mOObligacion.Monto)
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    Dim rn As RNObligacion

    If Me.ValidateChildren Then
      rn = New RNObligacion
      Me.mOObligacion.Descripcion = Me.txtDescripcion.Text
      Me.mOObligacion.Monto = Me.nudMonto.Value

      Try
        rn.Actualizar(Me.mOObligacion)
        Me.Close()
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        rn = Nothing
      End Try
    End If
  End Sub

  Private Sub frmModificarObligacion_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    Me.Dispose()
  End Sub

End Class