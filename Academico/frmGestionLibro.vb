Public Class frmGestionLibro
    Private codigo As Integer = 0
    Private ListAutor As New List(Of Autor)

#Region "Validacion"

    Private Sub txtLibro_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLibro.Enter
        AcceptButton = btnBuscarLibro
    End Sub

    Private Sub txtLibro_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLibro.Leave
        AcceptButton = btnRegistrar
    End Sub

    Private Sub txtLibro_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtLibro.Validating
        If txtLibro.Text.Length = 0 Then
            e.Cancel = True
            ErrLibro.SetError(txtLibro, "Debe indicar nombre del libro")
        Else
            ErrLibro.SetError(txtLibro, "")
        End If
    End Sub

    Private Sub txtDescripcion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDescripcion.Validating
        If txtDescripcion.Text.Length = 0 Then
            e.Cancel = True
            ErrLibro.SetError(txtDescripcion, "Debe indicar la descripción del libro")
        Else
            ErrLibro.SetError(txtDescripcion, "")
        End If
    End Sub
    Private Sub txtAbreviatura_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAbreviatura.Validating
        If txtAbreviatura.Text.Length = 0 Then
            e.Cancel = True
            ErrLibro.SetError(txtAbreviatura, "Debe indicar la abreviatura del libro")
        Else
            ErrLibro.SetError(txtAbreviatura, "")
        End If
    End Sub
    'Private Sub txtNombres_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    If txtNombres.Text.Length = 0 Then
    '        e.Cancel = True
    '        ErrLibro.SetError(txtNombres, "Debe indicar el nombre del autor")
    '    Else
    '        ErrLibro.SetError(txtNombres, "")
    '    End If
    'End Sub

    'Private Sub txtApellidos_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    If txtApellidos.Text.Length = 0 Then
    '        e.Cancel = True
    '        ErrLibro.SetError(txtApellidos, "Debe indicar los apellidos del autor")
    '    Else
    '        ErrLibro.SetError(txtApellidos, "")
    '    End If
    'End Sub

#End Region

    Private Sub frmLibro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            BuscarLibrosTeclasRapidas()
            e.Handled = True
        End If

    End Sub

    Private Sub frmLibro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
        Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
        Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
        Me.btnBuscarAutor.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes/Buscar.png")
        Me.btnEliminar.Visible = True
    End Sub
    Public Sub Gestionar()
        Me.ShowDialog()
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click

        Dim k As Integer = 0
        If Me.ValidateChildren Then
            Try
                If Me.dgvAutor.RowCount > 0 Then
                    For i As Integer = 0 To Me.dgvAutor.RowCount - 1
                        If Me.dgvAutor.Rows(i).Cells("cdNombres").EditedFormattedValue.ToString = "" Or _
                        Me.dgvAutor.Rows(i).Cells("cdApellidos").EditedFormattedValue.ToString = "" Then
                            k = 1
                            Exit For
                        End If
                    Next
                    If k = 0 Then

                        RegistrarLibro()
                        Limpiar()
                        txtLibro.Focus()
                    Else
                        MessageBox.Show("Ingrese el nombre del autor(es)", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("No ha ingresado Autor(es)", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub RegistrarLibro()
        Dim obj As RNLibro = Nothing
        Dim listAutor As List(Of Autor) = Nothing

        'If Me.ValidateChildren Then
        '    Try
        listAutor = New List(Of Autor)
        obj = New RNLibro

        For i As Integer = 0 To dgvAutor.Rows.Count - 1
            listAutor.Add(New Autor(CInt(dgvAutor.Rows(i).Cells("cdCodigo").Value), dgvAutor.Rows(i).Cells("cdNombres").Value.ToString, _
                                    dgvAutor.Rows(i).Cells("cdApellidos").Value.ToString))
        Next

        If codigo = 0 Then 'registrar
            obj.Registrar(New Libro(0, txtLibro.Text, txtDescripcion.Text, txtAbreviatura.Text, 0), listAutor)
            MessageBox.Show("El Libro se registró exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'actualizar
            obj.Actualizar(New Libro(codigo, txtLibro.Text, txtDescripcion.Text, txtAbreviatura.Text, 0), listAutor)
            MessageBox.Show("El Libro se actualizó exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        '    Catch ex As Exception
        '    MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

        'Finally
        '    obj = Nothing
        '    listAutor = Nothing
        'End Try
        'End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If dgvAutor.Rows.Count >= 1 Then
            Me.dgvAutor.Rows.RemoveAt(dgvAutor.CurrentRow.Index)
        Else
            MessageBox.Show("No hay autor(es) para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            nupNro.Enabled = True
            btnGenerar.Text = "&Generar"
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        ErrLibro.SetError(txtLibro, "")
        ErrLibro.SetError(txtDescripcion, "")
        ErrLibro.SetError(txtAbreviatura, "")
        Limpiar()
        txtLibro.Focus()
    End Sub
    Private Sub Limpiar()
        codigo = 0
        txtLibro.Text = ""
        txtDescripcion.Text = ""
        txtAbreviatura.Text = ""
        dgvAutor.Rows.Clear()
        btnEliminar.Visible = True
        nupNro.Enabled = True
        btnGenerar.Text = "&Generar"
        btnRegistrar.Text = "&Registrar"
    End Sub
    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        For i As Integer = 0 To CInt(Me.nupNro.Value) - 1
            Me.dgvAutor.Rows.Add()
        Next
        nupNro.Value = 1
        nupNro.Enabled = False
        btnGenerar.Text = "Agregar Autor"
        dgvAutor.Focus()
        dgvAutor.Rows(0).Cells("cdNombres").Selected = True
        btnBuscarAutor.Enabled = True

    End Sub

    Private Sub btnBuscarLibro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarLibro.Click, dgvAutor.DoubleClick
        BuscarLibrosTeclasRapidas()
    End Sub
    Private Sub BuscarLibrosTeclasRapidas()
        Dim L As Libro = Nothing
        Dim frmbuscar As New frmBuscarLibro
        Dim obj As RNLibro = Nothing
        L = frmbuscar.Buscar
        frmbuscar.Dispose()
        frmbuscar = Nothing


        If L IsNot Nothing Then
            Limpiar()
            obj = New RNLibro
            codigo = L.Codigo
            ListAutor = obj.LeerAutor(New Libro(L.Codigo))

            If ListAutor.Count > 0 Then
                For i As Integer = 0 To CInt(ListAutor.Count) - 1
                    Me.dgvAutor.Rows.Add()
                    dgvAutor.Rows(i).Cells("cdCodigo").Value = ListAutor(i).Codigo
                    dgvAutor.Rows(i).Cells("cdNombres").Value = ListAutor(i).Nombres
                    dgvAutor.Rows(i).Cells("cdApellidos").Value = ListAutor(i).Apellidos
                Next
            End If
            Me.txtLibro.Text = L.Titulo
            Me.txtDescripcion.Text = L.Descripcion
            Me.txtAbreviatura.Text = L.Abreviatura
            Me.btnRegistrar.Text = "&Actualizar"
            Me.btnEliminar.Visible = False
        End If
    End Sub

    Private Sub btnBuscarAutor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarAutor.Click
        BuscarAutoresTeclasRapidas()
    End Sub
    Private Sub BuscarAutoresTeclasRapidas()
        Dim A As Autor = Nothing
        Dim k = 0
        Dim frmbuscar As New frmBuscarAutor
        Dim obj As RNLibro = Nothing

        For i As Integer = 0 To Me.dgvAutor.RowCount - 1
            If Me.dgvAutor.Rows(i).Cells("cdNombres").EditedFormattedValue.ToString = "" And _
             Me.dgvAutor.Rows(i).Cells("cdApellidos").EditedFormattedValue.ToString = "" Then
                A = frmbuscar.Buscar
                frmbuscar.Dispose()
                frmbuscar = Nothing
                k = 1
                Exit For
            End If
        Next

        If k = 0 Then
            MessageBox.Show("La lista de autor(es) esta llena", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If A IsNot Nothing Then
            'Limpiar()
            obj = New RNLibro
            If A IsNot Nothing Then
                For i As Integer = 0 To Me.dgvAutor.RowCount - 1
                    If Me.dgvAutor.Rows(i).Cells("cdNombres").EditedFormattedValue.ToString = "" And _
                    Me.dgvAutor.Rows(i).Cells("cdApellidos").EditedFormattedValue.ToString = "" Then
                        dgvAutor.Rows(i).Cells("cdCodigo").Value = A.Codigo
                        dgvAutor.Rows(i).Cells("cdNombres").Value = A.Nombres
                        dgvAutor.Rows(i).Cells("cdApellidos").Value = A.Apellidos

                        Exit For
                    End If
                Next

            End If
        End If


    End Sub

End Class