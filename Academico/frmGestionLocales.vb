Public Class frmGestionLocales
    Private Codigo As Integer
    Private CodigoAnterior As String


#Region "Control de Teclas"


    Private Sub txttelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodigo.KeyPress, txttelefono.KeyPress
        If Char.IsDigit(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
#End Region

#Region "Validacion"
    Private Sub txtnombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtnombre.Validating
        If txtnombre.Text.Length = 0 Then
            e.Cancel = True
            ErrLocal.SetError(txtnombre, "Debe indicar Nombre del Local")
        Else
            ErrLocal.SetError(txtnombre, "")
        End If
    End Sub


    Private Sub txtDireccion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDireccion.Validating
        If txtDireccion.Text.Length = 0 Then
            e.Cancel = True
            ErrLocal.SetError(txtDireccion, "Debe indicar la dirección del Local")
        Else
            ErrLocal.SetError(txtDireccion, "")
        End If

    End Sub

    Private Sub txttelefono_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txttelefono.Validating
        If txttelefono.Text.Length = 0 Then
            e.Cancel = True
            ErrLocal.SetError(txttelefono, "Debe indicar el teléfono del Local")
        Else
            ErrLocal.SetError(txttelefono, "")
        End If
    End Sub
    Private Sub txtcodigo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtcodigo.Validating
        If txtcodigo.Text.Length = 0 And txtcodigo.Text.Length < 6 Then
            e.Cancel = True
            ErrLocal.SetError(txtcodigo, "Debe indicar el código del Local(6 dígitos)")
        Else
            ErrLocal.SetError(txtcodigo, "")
        End If
    End Sub
    Private Sub Ubicacion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Ubicacion.Validating
        If Ubicacion.cbopais.Text.Length = 0 Then
            e.Cancel = True
            ErrLocal.SetError(Ubicacion.cbopais, "Debe indicar el Pais ")
        Else
            ErrLocal.SetError(Ubicacion.cbopais, "")
        End If

        If Ubicacion.cbodpto.Text.Length = 0 Then
            e.Cancel = True
            ErrLocal.SetError(Ubicacion.cbodpto, "Debe indicar el Departamento ")
        Else
            ErrLocal.SetError(Ubicacion.cbodpto, "")
        End If

        If Ubicacion.cbopPvcia.Text.Length = 0 Then
            e.Cancel = True
            ErrLocal.SetError(Ubicacion.cbopPvcia, "Debe indicar la Provincia ")
        Else
            ErrLocal.SetError(Ubicacion.cbopPvcia, "")
        End If

        If Ubicacion.cbodistrito.Text.Length = 0 Then
            e.Cancel = True
            ErrLocal.SetError(Ubicacion.cbodistrito, "Debe indicar el Distrito ")
        Else
            ErrLocal.SetError(Ubicacion.cbodistrito, "")
        End If

    End Sub
#End Region
    Private Sub InicializarControles()
        Me.Codigo = 0
        Me.txtcodigo.Text = ""
        Me.txtnombre.Text = ""
        Me.txtDireccion.Text = ""
        Me.txttelefono.Text = ""
        btnRegistrar.Text = "&Registrar"
        Me.cBoxVigenciaLocal.Visible = False
        txtcodigo.Focus()
    End Sub


    Private Sub frmGestionLocales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtInstitucion.Text = mOInstitucion.Nombre
        Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
        Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
        Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
        Me.btnActualizar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
        Me.btnAgregarAmbientes.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\aula.gif")
        Me.txtnombre.CharacterCasing = CharacterCasing.Upper
        Me.txtDireccion.CharacterCasing = CharacterCasing.Upper

        Me.Ubicacion.CargarPaises()
        AgregarLocal()
        Habilitar()
        Me.txtcodigo.Focus()
    End Sub

    Private Sub btnregistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Dim objLocal As RNLocal = Nothing
        If Me.ValidateChildren() Then
            objLocal = New RNLocal
            Try
                If Codigo = 0 Then
                    objLocal.Registrar(New Local(txtcodigo.Text, New Institucion(mOInstitucion.CodigoInst), txtnombre.Text, txtDireccion.Text, _
                                                txttelefono.Text, cBoxVigenciaLocal.Checked, Ubicacion.cbopais.Text, Ubicacion.cbodpto.Text, Ubicacion.cbopPvcia.Text, _
                                                Ubicacion.cbodistrito.Text))

                    MessageBox.Show("El Local se registró exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    objLocal.Modificar(New Local(CodigoAnterior, New Institucion(mOInstitucion.CodigoInst), txtnombre.Text, txtDireccion.Text, _
                                                txttelefono.Text, cBoxVigenciaLocal.Checked, Ubicacion.cbopais.Text, Ubicacion.cbodpto.Text, Ubicacion.cbopPvcia.Text, _
                                                Ubicacion.cbodistrito.Text), txtcodigo.Text)

                    MessageBox.Show("Los datos se actualizaron exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                AgregarLocal()
                Habilitar()
                InicializarControles()

            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                objLocal = Nothing
            End Try
        End If
    End Sub

    Public Sub AgregarLocal()
        Dim obj As New RNLocal
        Dim la As List(Of Local)

        la = obj.Leer

        dgvLocales.AutoGenerateColumns = False
        dgvLocales.DataSource = la
    End Sub

    Public Sub Habilitar()
        If dgvLocales.RowCount = 0 Then
            Me.btnActualizar.Enabled = False
        Else
            Me.btnActualizar.Enabled = True
        End If
    End Sub


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click, dgvLocales.DoubleClick
        InicializarControles()
        Dim obj As RNLocal = Nothing
        Dim L As Local = Nothing

        If dgvLocales.SelectedRows.Count > 0 Then
            With CType(dgvLocales.SelectedRows.Item(0).DataBoundItem, Local)
                obj = New RNLocal
                L = obj.LeerLocal_Codigo(New Local(.Codigo))
                If L IsNot Nothing Then
                    Codigo = -1
                    CodigoAnterior = .Codigo
                    txtcodigo.Text = .Codigo
                    txtnombre.Text = L.Nombre
                    txtDireccion.Text = L.Direccion
                    txttelefono.Text = L.Telefono
                    cBoxVigenciaLocal.Visible = True
                    If L.Vigencia = True Then
                        cBoxVigenciaLocal.Checked = True
                    Else
                        cBoxVigenciaLocal.Checked = False
                    End If
                    Ubicacion.cbopais.Text = L.Pais
                    Ubicacion.cbodpto.Text = L.Departamento
                    Ubicacion.cbopPvcia.Text = L.Provincia
                    Ubicacion.cbodistrito.Text = L.Distrito
                    btnRegistrar.Text = "&Actualizar"
                    'txtcodigo.Enabled = False
                    txtnombre.Focus()
                Else
                    MessageBox.Show("No se pudo encontrar al Local solicitado", "Gestión de Locales", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    InicializarControles()

                End If
            End With
        End If
    End Sub
    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnAgregarAmbientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarAmbientes.Click
        Dim frmAmbientes As frmGestionAmbientes = Nothing

        If dgvLocales.SelectedRows.Count > 0 Then
            frmAmbientes = New frmGestionAmbientes
            With CType(dgvLocales.SelectedRows.Item(0).DataBoundItem, Local)
                frmAmbientes.Local = .Nombre
                frmAmbientes.cboLocal.Enabled = False
                frmAmbientes.txtPiso.Focus()
            End With
            frmAmbientes.ShowDialog()

        Else
            MessageBox.Show("No se pudo encontrar al Local solicitado", "Gestión de Locales", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
    Private Sub btnCancelar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        InicializarControles()
        Me.txtcodigo.Enabled = True
        txtcodigo.Focus()
    End Sub

    Private Sub txtInstitucion_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInstitucion.Enter
        txtcodigo.Focus()
    End Sub


End Class