Public Class frmPrincipal
  Public Shared txtSaldoPrincipal As ToolStripTextBox

  Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
    Me.Close()
  End Sub

  Private Sub tsbReposicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbReposicion.Click
    frmReposicion.Crear(Me)
  End Sub

  Private Sub tHoraFecha_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tHoraFecha.Tick
    Me.tsslHora.Text = Date.Now.Second.ToString
  End Sub

  Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
    frmCompra.Crear(Me)
  End Sub

  Private Sub mnuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSalir.Click
    Me.Close()
  End Sub

  Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.tsslUsuario.Text = mOUsuario.Persona.NombreCompleto.ToUpper
    Me.tsslFecha.Text = Date.Now.ToString("dd/MM/yyyy")
    Dim rnCompra As New RNCompra
    Dim saldo = rnCompra.ListarSaldo()
    If saldo <> 0 Then
      Me.txtSaldo.Text = saldo.ToString.Substring(0, saldo.ToString.Length - 2)      
    Else
      Me.txtSaldo.Text = "0"
    End If
    txtSaldoPrincipal = Me.txtSaldo
  End Sub

  Private Sub mnuCambiarContrasenia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCambiarContrasenia.Click
    Dim frm As New frmCuentasUsuario
    frm.Gestionar()
  End Sub
End Class