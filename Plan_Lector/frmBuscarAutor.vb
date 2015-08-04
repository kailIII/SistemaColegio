Public Class frmBuscarAutor
    Private Autor As New Autor

    Private Sub frmBuscarAutor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
        Me.btnBuscar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Buscar.png")
        Me.btnseleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
        txtNombreBuscar.Focus()

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        BuscarLibros()
    End Sub
    Private Sub BuscarLibros()
        Dim obj As New RNLibro
        Dim la As List(Of Autor)
        la = obj.ListarAutores(txtNombreBuscar.Text.Trim)
        dgvAutores.AutoGenerateColumns = False
        dgvAutores.DataSource = la
        If la.Count > 0 Then
            dgvAutores.Focus()
        Else
            txtNombreBuscar.Focus()
        End If
    End Sub

    Private Sub Seleccionar()
        Try
            Autor = CType(Me.dgvAutores.Rows(Me.dgvAutores.CurrentRow.Index).DataBoundItem, Autor)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function Buscar() As Autor
        Me.ShowDialog()
        If Autor.Nombres Is Nothing Then
            Return Nothing
        Else
            Return Autor
        End If
    End Function
    Private Sub txtNombreBuscar_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombreBuscar.Enter
        Me.AcceptButton = btnBuscar
    End Sub
    Private Sub dgvAutores_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvAutores.KeyDown
        If e.KeyCode = Keys.Enter Then
            Seleccionar()
        End If
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnseleccionar.Click, dgvAutores.DoubleClick
        Seleccionar()
    End Sub
End Class