Public Class frmBuscarDocente
    Private Docente As New Docente
    Private Sub frmBuscarLibro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
        Me.btnBuscar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Buscar.png")
        Me.btnseleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
        txtNombreBuscar.Focus()
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        BuscarDocente()
    End Sub
    Private Sub BuscarDocente()
        Dim obj As New RNDocente
        Dim la As List(Of Docente)
        la = obj.ListarDoc(txtNombreBuscar.Text.Trim)
        dgvDocentes.AutoGenerateColumns = False
        dgvDocentes.DataSource = la
        If la.Count > 0 Then
            dgvDocentes.Focus()
        Else
            txtNombreBuscar.Focus()
        End If
    End Sub
    'Tania Incio
    Private Sub Seleccionar()
        Try
            Docente = CType(Me.dgvDocentes.Rows(Me.dgvDocentes.CurrentRow.Index).DataBoundItem, Docente)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function Buscar() As Docente
        Me.ShowDialog()
        If Docente Is Nothing Then
            Return Nothing
        Else
            Return Docente
        End If
    End Function

    Private Sub btnseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnseleccionar.Click, dgvDocentes.DoubleClick
        Seleccionar()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub txtNombreBuscar_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombreBuscar.Enter
        Me.AcceptButton = btnBuscar
    End Sub
    Private Sub dgvLibros_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvDocentes.KeyDown
        If e.KeyCode = Keys.Enter Then
            Seleccionar()
        End If
    End Sub

    'Tania Incio
    Public Sub Gestionar()
        ' If obj IsNot Nothing Then
        'Me.notaL = obj
        'libro = dao.LibroXcodProgLectura(notaL.ProgLectura.Codigo)
        'Me.ListarLibros(notaL.ProgLectura.Codigo)
        'Me.cboLibro.SelectedValue = libro.Codigo
        'Me.txtNotaRecuperacion.Text = notaRec
        Me.ShowDialog()
        'End If
    End Sub

End Class