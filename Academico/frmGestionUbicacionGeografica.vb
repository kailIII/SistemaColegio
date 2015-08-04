Public Class frmGestionUbicacionGeografica
  Private codigo As Integer

#Region "Validacion"



  Private Sub txtpais_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtpais.Validating
    If txtpais.Text.Length = 0 Then
      e.Cancel = True
      ErrUbicacion.SetError(txtpais, "Debe indicar el pais")
    Else
      ErrUbicacion.SetError(txtpais, "")
    End If
  End Sub

  Private Sub txtdpto_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtdpto.Validating
    If txtdpto.Text.Length = 0 Then
      e.Cancel = True
      ErrUbicacion.SetError(txtdpto, "Debe indicar el departamento")
    Else
      ErrUbicacion.SetError(txtdpto, "")
    End If
  End Sub

  Private Sub txtProvincia_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtProvincia.Validating
    If txtProvincia.Text.Length = 0 Then
      e.Cancel = True
      ErrUbicacion.SetError(txtProvincia, "Debe indicar la provincia")
    Else
      ErrUbicacion.SetError(txtProvincia, "")
    End If
  End Sub

  Private Sub txtDistrito_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDistrito.Validating
    If txtDistrito.Text.Length = 0 Then
      e.Cancel = True
      ErrUbicacion.SetError(txtDistrito, "Debe indicar el distrito")
    Else
      ErrUbicacion.SetError(txtDistrito, "")
    End If
  End Sub
#End Region

#Region "Control de Teclas"
  Private Sub txtpais_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpais.KeyPress, txtdpto.KeyPress, txtProvincia.KeyPress, txtDistrito.KeyPress
    If Char.IsLetter(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False And _
       Char.IsSeparator(e.KeyChar) = False AndAlso e.KeyChar <> "'"c Then
      e.Handled = True
    End If
  End Sub
#End Region


  Private Sub frmGestionUbicacionGeografica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnActualizar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
    Me.btnBuscar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "/Imagenes/Buscar.png")

    Me.txtpais.CharacterCasing = CharacterCasing.Upper
    Me.txtdpto.CharacterCasing = CharacterCasing.Upper
    Me.txtProvincia.CharacterCasing = CharacterCasing.Upper
    Me.txtDistrito.CharacterCasing = CharacterCasing.Upper

    AgregarUbicacion()
    Habilitar()
    txtBuscar.Text = "PERU"
  End Sub
  Public Sub Habilitar()
    If dgvUbicacion.RowCount = 0 Then
      Me.btnActualizar.Enabled = False
    Else
      Me.btnActualizar.Enabled = True
    End If
  End Sub
  Public Sub AgregarUbicacion()
    Dim obj As New RNUbicacionGeografica
    Dim la As List(Of UbicacionGeografica)
    la = obj.ListarUbicacion
    dgvUbicacion.AutoGenerateColumns = False
    dgvUbicacion.DataSource = la
  End Sub
  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Dim obj As New RNUbicacionGeografica
    Dim la As List(Of UbicacionGeografica)
    la = obj.ListarUbicacion_Nombre(txtBuscar.Text.Trim)
    dgvUbicacion.AutoGenerateColumns = False
    dgvUbicacion.DataSource = la
  End Sub
  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub
  Public Sub InicializarControles()
    Me.codigo = 0
    Me.txtpais.Text = ""
    Me.txtdpto.Text = ""
    Me.txtProvincia.Text = ""
    Me.txtDistrito.Text = ""
    Me.btnRegistrar.Text = "&Registrar"
    txtpais.Focus()
  End Sub
  Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click, dgvUbicacion.DoubleClick
    InicializarControles()
    Dim obj As RNUbicacionGeografica = Nothing
    Dim P As UbicacionGeografica = Nothing
    If dgvUbicacion.SelectedRows.Count > 0 Then
      With CType(dgvUbicacion.SelectedRows.Item(0).DataBoundItem, UbicacionGeografica)
        obj = New RNUbicacionGeografica
        P = obj.LeerUbicacion_Codigo(New UbicacionGeografica(.CodigoUbGeog))
        If P IsNot Nothing Then
          codigo = .CodigoUbGeog
          txtpais.Text = P.Pais
          txtdpto.Text = P.Departamento
          txtProvincia.Text = P.Provincia
          txtDistrito.Text = P.Distrito
          btnRegistrar.Text = "&Actualizar"
          txtpais.Focus()
        Else
          MessageBox.Show("No se pudo encontrar la Ubicación solicitada", "Gestión de Ubicaciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      End With
    End If
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    If Me.ValidateChildren() Then
      Dim obj As New RNUbicacionGeografica
      Try
        If codigo = 0 Then
          obj.Registrar(New UbicacionGeografica(txtDistrito.Text, txtProvincia.Text, txtdpto.Text, txtpais.Text))

          MessageBox.Show("La Ubicación se registró exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          obj.Modificar(New UbicacionGeografica(codigo, txtDistrito.Text, txtProvincia.Text, txtdpto.Text, txtpais.Text))

          MessageBox.Show("Los datos se actualizaron exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        InicializarControles()
        AgregarUbicacion()
        Habilitar()

      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        obj = Nothing
      End Try
    End If
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    InicializarControles()
  End Sub

  Private Sub txtBuscar_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.Enter
    AcceptButton = btnBuscar
  End Sub

  Private Sub txtBuscar_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar.Leave
    AcceptButton = btnRegistrar
  End Sub
End Class