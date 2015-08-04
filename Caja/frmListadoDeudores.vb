Public Class frmListadoDeudores

  Private dtDeudores As System.Data.DataTable

  Private Sub frmListarDeudores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    CargarImagenes()
  End Sub

  Public Sub CargarImagenes()
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnListar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Buscar.png")
    Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\excel.bmp")
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Listar()
  End Sub

  Public Sub Listar()
    Dim rn As New RNObligacion

    Me.dtDeudores = rn.ListarDeudores(Me.dtFecha.Value)
    rn = Nothing

    Me.dgvAlumnosDeudores.AutoGenerateColumns = False
    Me.dgvAlumnosDeudores.DataSource = Me.dtDeudores

  End Sub

End Class