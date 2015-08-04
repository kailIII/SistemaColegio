Public Class frmAsignacionLibroGrado
    Private codigo As Integer = 0



    Private Sub frmAsignacionLibroGrado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
        Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
        Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
        Me.btnActualizar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
        txtAnio.Text = moAnioActual.anio

        ListarGrados()
        ListarLibros()
        Limpiar()

    End Sub

    Private Sub ListarGrados()
        Dim obj As New RNGrado
        Dim lg As List(Of Grado)
        lg = obj.ListarGradosSec(moAnioActual)
        If lg.Count > 0 Then
            Me.cboGrado.DisplayMember = "Nombre"
            Me.cboGrado.ValueMember = "Codigo"
            Me.cboGrado.DataSource = lg
        End If
    End Sub
    Private Sub ListarLibros()
        Dim obj As New RNLibro
        Dim la As List(Of Libro)
        la = obj.ListarLibros("")

        If la.Count > 0 Then
            Me.cboLibro.DisplayMember = "Titulo"
            Me.cboLibro.ValueMember = "Codigo"
            Me.cboLibro.DataSource = la
        Else
            Me.cboLibro.DataSource = Nothing
        End If
    End Sub
    Public Sub AgregarLibro()
        Dim obj As New RNLibro
        Dim la As List(Of GradoLibro)

        If cboGrado.SelectedIndex > -1 Then
            la = obj.ListarLibros_Grado(CType(cboGrado.SelectedItem, Grado), moAnioActual)
            dgvLibros.AutoGenerateColumns = False
            dgvLibros.DataSource = la
        Else
            dgvLibros.DataSource = Nothing
        End If

      End Sub
    Public Sub Habilitar()
        If dgvLibros.RowCount = 0 Then
            Me.btnActualizar.Enabled = False
        Else
            Pintar()
            Me.btnActualizar.Enabled = True
        End If
    End Sub
    Public Sub Pintar()
        For i As Integer = 0 To dgvLibros.Rows.Count - 1
            If CType(dgvLibros.Rows(i).DataBoundItem, GradoLibro).NombreVigencia = "NO" Then
                Me.dgvLibros.Rows(i).DefaultCellStyle.BackColor = Color.OrangeRed
            Else
                Me.dgvLibros.Rows(i).DefaultCellStyle.BackColor = Color.GreenYellow
            End If
        Next
    End Sub
    Private Sub dgvPresentacion_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvLibros.CellClick, dgvLibros.SelectionChanged
        Me.dgvLibros.CurrentRow.DefaultCellStyle.SelectionBackColor = Me.dgvLibros.CurrentRow.DefaultCellStyle.BackColor

        If Me.dgvLibros.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.White Then
            Me.dgvLibros.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Blue
        Else
            Me.dgvLibros.CurrentRow.DefaultCellStyle.SelectionForeColor = Me.dgvLibros.CurrentRow.DefaultCellStyle.ForeColor
            'Me.dgvPresentacion.CurrentRow.DefaultCellStyle.ForeColor = Color.Red
        End If
    End Sub
    Private Sub Limpiar()
        codigo = 0
        Me.cboLibro.SelectedIndex = -1
        btnRegistrar.Text = "&Registrar"

        Me.chkVigencia.Visible = False
        ErrLibro.SetError(cboLibro, "")
        ErrLibro.SetError(cboGrado, "")
    End Sub

    Private Sub txtAnio_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAnio.Enter
        cboGrado.Focus()
    End Sub
    Public Sub Gestionar()
        Me.ShowDialog()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Dim obj As RNLibro = Nothing

        Try
            obj = New RNLibro

            If codigo = 0 Then
                obj.RegistrarGrado_Libro(New GradoLibro(0, CInt(cboGrado.SelectedValue), CType(Me.cboLibro.SelectedItem, Libro), moAnioActual.anio, True))
                MessageBox.Show("Asignación registrada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                obj.ActualizarGrado_Libro(New GradoLibro(codigo, CInt(cboGrado.SelectedValue), CType(Me.cboLibro.SelectedItem, Libro), moAnioActual.anio, chkVigencia.Checked))
                MessageBox.Show("Asignación actualizada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            
            Limpiar()
            AgregarLibro()
            Habilitar()
            
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            obj = Nothing
            codigo = 0
        End Try
    End Sub

    Private Sub cboGrado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboGrado.SelectedIndexChanged
        If cboGrado.SelectedIndex > -1 Then
            Limpiar()
            AgregarLibro()
            Habilitar()
        End If
    End Sub

    Private Sub cboGrado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboGrado.Validating
        If cboGrado.SelectedIndex = -1 Then
            e.Cancel = True
            ErrLibro.SetError(cboGrado, "Debe indicar el grado")
        Else
            ErrLibro.SetError(cboGrado, "")
        End If
    End Sub

    Private Sub cboLibro_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboLibro.Validating
        If cboLibro.SelectedIndex = -1 Then
            e.Cancel = True
            ErrLibro.SetError(cboLibro, "Debe indicar el libro")
        Else
            ErrLibro.SetError(cboLibro, "")
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Limpiar()
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click, dgvLibros.DoubleClick
        Dim L As GradoLibro = Nothing

        If dgvLibros.SelectedRows.Count > 0 Then
            L = CType(Me.dgvLibros.Rows(Me.dgvLibros.CurrentRow.Index).DataBoundItem, GradoLibro)

            If L IsNot Nothing Then
                codigo = L.Codigo
                Me.cboGrado.SelectedValue = L.CodigoGrado
                Me.cboLibro.SelectedValue = L.Libro.Codigo
                chkVigencia.Checked = L.Vigencia
                chkVigencia.Visible = True
                btnRegistrar.Text = "&Actualizar"

            Else
                MessageBox.Show("No se pudo encontrar el libro solicitado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If
    End Sub
End Class