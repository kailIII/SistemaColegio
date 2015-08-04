Public Class frmgestionOcupacion
  Private Codigo As Integer

  Private Sub frmgestionOcupaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnActualizar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
    Me.btnBuscar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "/Imagenes/Buscar.png")
    Me.txtBuscar.CharacterCasing = CharacterCasing.Upper
    Me.txtNombre.CharacterCasing = CharacterCasing.Upper

    AgregarOcupacion()
    Habilitar()
  End Sub
  Public Sub gestionar()
    Me.ShowDialog()
  End Sub
  Public Sub AgregarOcupacion()
    Dim obj As New RNOcupacion
    Dim la As List(Of Ocupacion)
    la = obj.ListarOcupaciones
    dgvOcupacion.AutoGenerateColumns = False
    dgvOcupacion.DataSource = la
  End Sub
  Public Sub Habilitar()
    If dgvOcupacion.RowCount = 0 Then
      Me.btnActualizar.Enabled = False
    Else
      Me.btnActualizar.Enabled = True
    End If
  End Sub
  Public Sub InicializarControles()
    Me.Codigo = 0
    txtNombre.Text = ""
    Me.btnRegistrar.Text = "&Registrar"
    txtNombre.Focus()
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    InicializarControles()
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    If Me.ValidateChildren() Then
      Dim obj As New RNOcupacion
      Try
        If Codigo = 0 Then
          obj.Registrar(New Ocupacion(Nothing, txtNombre.Text))

          MessageBox.Show("La ocupación se registró exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          obj.Modificar(New Ocupacion(Codigo, txtNombre.Text))

          MessageBox.Show("Los datos se actualizaron exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        InicializarControles()
        AgregarOcupacion()
        Habilitar()

      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        obj = Nothing
      End Try
    End If

  End Sub

  Private Sub txtNombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
    If txtnombre.Text.Length = 0 Then
      e.Cancel = True
      ErrOcupacion.SetError(txtNombre, "Debe indicar Nombre de la profesión")
    Else
      ErrOcupacion.SetError(txtNombre, "")
    End If
  End Sub


  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Dim obj As New RNOcupacion
    Dim la As List(Of Ocupacion)
    la = obj.ListarOcupaciones_Nombre(txtBuscar.Text.Trim)
    dgvOcupacion.AutoGenerateColumns = False
    dgvOcupacion.DataSource = la
  End Sub

  Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click, dgvOcupacion.DoubleClick
    InicializarControles()

    Dim obj As RNOcupacion = Nothing
    Dim P As Ocupacion = Nothing

    If dgvOcupacion.SelectedRows.Count > 0 Then
      With CType(dgvOcupacion.SelectedRows.Item(0).DataBoundItem, Ocupacion)
        obj = New RNOcupacion
        P = obj.LeerOcupacion_Codigo(New Ocupacion(.Codigo, Nothing))
        If P IsNot Nothing Then
          Codigo = .Codigo
          txtNombre.Text = P.Nombre
          btnRegistrar.Text = "&Actualizar"
          txtNombre.Focus()
        Else
          MessageBox.Show("No se pudo encontrar la profesión solicitada", "Gestión de Profesiones", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

      End With
    End If
  End Sub
End Class