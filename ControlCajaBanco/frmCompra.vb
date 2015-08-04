Public Class frmCompra
  Dim codigoNuevo As Integer
  Shared frm As Form

  Public Shared Sub Crear(ByVal pPadre As Form)
    If frmCompra.frm Is Nothing Then
      frmCompra.frm = New frmCompra
      frmCompra.frm.MdiParent = pPadre
      frmCompra.frm.Show()
      frmCompra.frm.WindowState = FormWindowState.Maximized
    Else
      frm.Activate()
    End If
  End Sub

  Private Sub frmCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
  End Sub

  Private Sub frmCompra_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmCompra.frm = Nothing
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
    Me.Close()
  End Sub
End Class