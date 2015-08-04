Public Class frmGestionDRE
  Private codigoEstado As Integer = 0
  Private codigo As Integer = 0

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub frmDRE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    MostrarImagenes()
    ConvertirMayusculas()
    LlenarTablaDRE()
    Limpiar()
  End Sub

  Public Sub MostrarImagenes()
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnModificar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Editar.jpg")
  End Sub

  Public Sub LlenarTablaDRE()
    Dim obj As New RNDRE
    Dim ld As List(Of DRE)

    ld = obj.DatosDRE
    dgvDRE.AutoGenerateColumns = False
    dgvDRE.DataSource = ld
    Me.dgvDRE.Columns(0).DataPropertyName = "NombreDRE"
    Me.dgvDRE.Columns(1).DataPropertyName = "CodigoUGEL"
  End Sub

  Public Sub ConvertirMayusculas()
    Me.txtNombre.CharacterCasing = CharacterCasing.Upper
    Me.txtDireccion.CharacterCasing = CharacterCasing.Upper
    Me.txtContacto.CharacterCasing = CharacterCasing.Upper
  End Sub

  Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress, txtContacto.KeyPress
    If Char.IsLetter(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False And _
            Char.IsSeparator(e.KeyChar) = False AndAlso e.KeyChar <> "'"c Then
      e.Handled = True
    End If
  End Sub

  Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress, txtCodigo.KeyPress
    If Not (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) And Not (Asc(e.KeyChar) = 8) Then
      e.Handled = True
    End If
  End Sub

  Private Sub ValidarText(ByVal e As System.ComponentModel.CancelEventArgs, ByVal cadena As System.Windows.Forms.TextBox, ByVal msj As String)
    If cadena.Text.Length = 0 Then
      e.Cancel = True
      errDre.SetError(cadena, msj)
    Else
      errDre.SetError(cadena, Nothing)
    End If
  End Sub

  Private Sub txtNombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
    ValidarText(e, Me.txtNombre, "Debe indicar el nombre de la DRE")
  End Sub

  Private Sub txtDireccion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDireccion.Validating
    ValidarText(e, Me.txtDireccion, "Debe indicar la dirección de la DRE")
  End Sub

  Private Sub txtCodigo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodigo.Validating
    ValidarText(e, Me.txtCodigo, "Debe indicar el codigo de la DRE")
  End Sub

  Private Sub txtTelefono_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTelefono.Validating
    ValidarText(e, Me.txtTelefono, "Debe indicar el teléfono de la DRE")
  End Sub

  Private Sub txtContacto_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtContacto.Validating
    ValidarText(e, Me.txtContacto, "Debe indicar el contacto")
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Limpiar()
    Me.btnRegistrar.Text = "&Registrar"
    codigoEstado = 0
    errDre.SetError(txtCodigo, Nothing)
    errDre.SetError(txtContacto, Nothing)
    errDre.SetError(txtDireccion, Nothing)
    errDre.SetError(txtNombre, Nothing)
    errDre.SetError(txtTelefono, Nothing)
  End Sub

  Public Sub Limpiar()
    Me.txtContacto.Text = "NINGUNO(A)"
    Me.txtCodigo.Text = ""
    Me.txtNombre.Text = ""
    Me.txtDireccion.Text = ""
    Me.txtTelefono.Text = ""
    Me.txtNombre.Focus()
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim obj As RNDRE
    If Me.ValidateChildren Then
      obj = New RNDRE
      If codigoEstado = 0 Then
        obj.Registrar(New DRE(0, Me.txtDireccion.Text, Me.txtTelefono.Text, Me.txtNombre.Text, Me.txtContacto.Text, Me.txtCodigo.Text))
        MessageBox.Show("Datos de la DRE registrados con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Else
        obj.Actualizar(New DRE(codigo, Me.txtDireccion.Text, Me.txtTelefono.Text, Me.txtNombre.Text, Me.txtContacto.Text, Me.txtCodigo.Text))
        MessageBox.Show("Datos Actualizados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.btnRegistrar.Text = "&Registrar"
        codigoEstado = 0
        codigo = 0
      End If
      Limpiar()
      LlenarTablaDRE()
    End If
  End Sub

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click, dgvDRE.DoubleClick
    If Me.dgvDRE.RowCount > 0 Then
      With CType(dgvDRE.SelectedRows.Item(0).DataBoundItem, DRE)
        Me.txtNombre.Text = .NombreDRE.Trim
        Me.txtDireccion.Text = .Direccion.Trim
        Me.txtCodigo.Text = .CodigoUGEL.Trim
        Me.txtContacto.Text = .NombreContacto.Trim
        Me.txtTelefono.Text = .Telefono.Trim
        codigo = .Codigo
      End With
      Me.btnRegistrar.Text = "&Actualizar"
      codigoEstado = 1
    Else
      MessageBox.Show("No existe DRE para modificar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub
End Class