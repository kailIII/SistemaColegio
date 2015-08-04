Public Class frmGestionCapacidad
  Private codigoEstado As Integer = 0
  Private codigo As Integer

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub frmCapacidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'Me.txtCapacidad.CharacterCasing = CharacterCasing.Upper
    Me.chkVigente.Visible = False
    MostrarImagenes()
    ListarNiveles()
    If Me.cboNivel.Items.Count > 0 Then
      ListarAreas()
    End If
    If Me.cboArea.Items.Count > 0 Then
      Me.cboArea.SelectedIndex = -1
    End If
    If Me.cboNivel.Items.Count = 3 Then
      Me.cboNivel.SelectedIndex = 2
    End If
    Me.cboArea.Focus()
  End Sub

  Public Sub ListarNiveles()
    Dim ListNa As List(Of Nivel)
    Dim objNa As New RNNivel

    ListNa = objNa.LeerNivelSec()
    If ListNa.Count > 0 Then
      cboNivel.DisplayMember = "nombre"
      cboNivel.ValueMember = "codigoModular"
      cboNivel.DataSource = ListNa
      ListNa = Nothing
    End If
  End Sub

  Public Sub ListarAreas()
    Dim ListA As List(Of AreaDRE)
    Dim obj As New RNAreaDRE

    ListA = obj.Listar_Nivel(CType(Me.cboNivel.SelectedItem, Nivel))
    If ListA.Count > 0 Then
      Me.cboArea.DisplayMember = "Nombre"
      Me.cboArea.ValueMember = "Nombre"
      Me.cboArea.DataSource = ListA
      ListA = Nothing
    End If
  End Sub

  Public Sub MostrarImagenes()
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnDeshacer.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnModificar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Editar.jpg")
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub txtCapacidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCapacidad.KeyPress
    If Char.IsLetter(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False And _
            Char.IsSeparator(e.KeyChar) = False AndAlso e.KeyChar <> "'"c AndAlso e.KeyChar <> "." Then
      e.Handled = True
    End If
  End Sub

  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNivel.SelectedIndexChanged
    If Me.cboNivel.SelectedIndex > -1 Then
      ListarAreas()
      If Me.cboArea.Items.Count > 0 Then
        Me.cboArea.SelectedIndex = -1
        Me.cboArea.Focus()
      End If
    End If
  End Sub

  Private Sub txtCapacidad_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCapacidad.Validating
    If Me.txtCapacidad.Text = "" Then
      e.Cancel = True
      errCapacidad.SetError(Me.txtCapacidad, "Ingrese capacidad")
    Else
      errCapacidad.SetError(Me.txtCapacidad, Nothing)
    End If
  End Sub

  Private Sub cboArea_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboArea.Validating
    If Me.cboArea.Text = "" Then
      e.Cancel = True
      errCapacidad.SetError(Me.cboArea, "Seleccione área")
    Else
      errCapacidad.SetError(Me.cboArea, Nothing)
    End If
  End Sub

  Private Sub cboNivel_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboNivel.Validating
    If Me.cboNivel.Text = "" Then
      e.Cancel = True
      errCapacidad.SetError(Me.cboNivel, "Registre niveles académicos")
    Else
      errCapacidad.SetError(Me.cboNivel, Nothing)
    End If
  End Sub

  Public Sub Limpiar()
    errCapacidad.SetError(Me.cboNivel, Nothing)
    errCapacidad.SetError(Me.cboArea, Nothing)
    errCapacidad.SetError(Me.txtCapacidad, Nothing)
    Me.txtCapacidad.Text = ""
    Me.txtCapacidad.Focus()
    codigoEstado = 0
    Me.cboArea.Enabled = True
    Me.cboNivel.Enabled = True
    Me.btnRegistrar.Text = "&Registrar"
    Me.chkVigente.Visible = False
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim obj As RNCapacidad = Nothing

    If Me.ValidateChildren Then
      Try
        obj = New RNCapacidad
        If codigoEstado = 0 Then
          obj.Registrar(New Capacidad(0, Me.txtCapacidad.Text.Trim, CType(Me.cboArea.SelectedItem, AreaDRE), True))
          MessageBox.Show("Capacidad registrada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          obj.Actualizar(New Capacidad(Me.codigo, Me.txtCapacidad.Text.Trim, New AreaDRE(), Me.chkVigente.Checked))
          MessageBox.Show("Capacidad actualizada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Limpiar()
        ListarCapacidades()
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Me.txtCapacidad.Text = ""
        Me.txtCapacidad.Focus()
      Finally
        obj = Nothing
      End Try
    End If
  End Sub

  Public Sub ListarCapacidades()
    Dim obj As New RNCapacidad
    Dim lc As List(Of Capacidad)
    Dim k As Integer = 0

    Me.lbCapacidades.DataSource = Nothing
    Me.lbCapacidades.Items.Clear()
    lc = obj.ListarCapacidadesArea(CType(Me.cboArea.SelectedItem, AreaDRE))
    If lc.Count > 0 Then
      Me.lbCapacidades.DisplayMember = "Nombre"
      Me.lbCapacidades.ValueMember = "Nombre"
      Me.lbCapacidades.DataSource = lc
      lc = Nothing
    End If

  End Sub

  Private Sub btnDeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeshacer.Click
    Limpiar()
  End Sub

  Private Sub cboArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboArea.SelectedIndexChanged
    If Me.cboArea.SelectedIndex > -1 Then
      ListarCapacidades()
    Else
      Me.lbCapacidades.DataSource = Nothing
      Me.lbCapacidades.Items.Clear()
    End If
  End Sub

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click, lbCapacidades.DoubleClick
    Me.btnRegistrar.Text = "&Actualizar"
    codigoEstado = 1
    Me.chkVigente.Visible = True
    Me.txtCapacidad.Text = CType(Me.lbCapacidades.SelectedItem, Capacidad).Nombre
    Me.codigo = CType(Me.lbCapacidades.SelectedItem, Capacidad).Codigo
    Me.chkVigente.Checked = CType(Me.lbCapacidades.SelectedItem, Capacidad).Vigencia
    Me.cboArea.Enabled = False
    Me.cboNivel.Enabled = False
    Me.txtCapacidad.Focus()
  End Sub
End Class