Public Class frmBuscarApoderadoNew
  Private A As New Apoderado
  Private destino As String = ""

  Private Sub frmBuscarApoderadoNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    btnSeleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes/seleccionar.png")
    btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes/cancelar.png")
    Me.BuaP.btnBuscar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes/Buscar.png")

    Me.BuAP.txtNombreBuscar.Focus()
  End Sub

  Public Function BuscarApoderado() As Apoderado
    If BuaP.dgvApoderado.SelectedRows.Count > 0 Then
      A = CType(BuaP.dgvApoderado.SelectedRows.Item(0).DataBoundItem, Apoderado)
      Me.Close()
    End If
    Return A
  End Function

  Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
    BuscarApoderado()
  End Sub

  Private Sub buAl_DobleClicGrid() Handles BuAP.DobleClicGrid
    btnSeleccionar_Click(Nothing, Nothing)
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Close()
  End Sub

  Public Function Buscar() As Apoderado
    Me.ShowDialog()
    If A.Nombre Is Nothing Then
      Return Nothing
    Else
      Return A
    End If
  End Function

End Class