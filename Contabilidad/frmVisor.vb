Public Class frmVisor

  Private boAceptado As Boolean

  Public ReadOnly Property Aceptado() As Boolean
    Get
      Return Me.boAceptado
    End Get
  End Property

  Private Sub frmVisor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
    If Convert.ToInt16(e.KeyChar) = Keys.Enter Then
      Me.boAceptado = True
      Me.Close()
    ElseIf Convert.ToInt16(e.KeyChar) = Keys.Escape Then
      Me.boAceptado = False
      Me.Close()
    End If
    e.Handled = True
  End Sub

  Private Sub frmVisor_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
    Me.boAceptado = False
  End Sub

  Private Sub frmVisor_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
    If e.Control = True AndAlso e.KeyCode = Keys.P Then
      Me.crvVisor.PrintReport()
      Me.Close()
    End If
  End Sub

End Class