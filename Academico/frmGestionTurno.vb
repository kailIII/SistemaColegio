Public Class frmGestionTurno
  Dim codigoEstado As Integer = 0
  Dim codigo As Integer

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Public Sub Gestionar()
    'Dim obj As New RNNivel
    'If obj.Listar.Count > 0 Then
    Me.ShowDialog()
    'Else
    'MessageBox.Show("Ingrese niveles", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    'End If
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim obj As RNTurno

    If Me.ValidateChildren Then
      Try
        obj = New RNTurno
        If codigoEstado = 0 Then
          obj.Registrar(New Turno(0, Me.txtNombre.Text.Trim, Me.dtpHIngreso.Value, dtpHSalida.Value))
          MessageBox.Show("Turno registrado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          'If Me.cboNivel.Items.Count - 1 > Me.cboNivel.SelectedIndex Then
          '  Me.cboNivel.SelectedIndex += 1
          'End If
        Else
          obj.Actualizar(New Turno(codigo, Me.txtNombre.Text.Trim, Me.dtpHIngreso.Value, dtpHSalida.Value))
          MessageBox.Show("Turno actualizado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          codigoEstado = 0
          Me.btnRegistrar.Text = "&Registrar"
          'Me.cboNivel.Enabled = True
        End If
        ListarTurnosRegistrados()
        Me.txtNombre.Text = ""
        Me.txtNombre.Focus()
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        obj = Nothing
      End Try
    End If
  End Sub

  Private Sub frmTurno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'ListarNiveles()
    ListarTurnosRegistrados()
    Me.txtNombre.CharacterCasing = CharacterCasing.Upper
    MostrarImagenes()
    'Me.txtNombre.Text = "MAÑANA"
  End Sub

  Public Sub MostrarImagenes()
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnModificar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Editar.jpg")
  End Sub

  Public Sub ListarTurnosRegistrados()
    Dim obj As New RNTurno
    Dim lt As List(Of Turno)

    lt = obj.ListarDatosTurnos
    Me.dgvturnos.AutoGenerateColumns = False
    Me.dgvturnos.DataSource = lt
    'Me.dgvturnos.Columns(0).DataPropertyName = "NombreNivel"
    Me.dgvturnos.Columns(0).DataPropertyName = "Nombre"
    Me.dgvturnos.Columns(1).DataPropertyName = "HoraIni"
    Me.dgvturnos.Columns(2).DataPropertyName = "HoraFin"
  End Sub

  Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
    If Char.IsLetter(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False And _
            Char.IsSeparator(e.KeyChar) = False AndAlso e.KeyChar <> "'"c Then
      e.Handled = True
    End If
  End Sub

  'Public Sub ListarNiveles()
  '  Dim obj As New RNNivel
  '  Dim ln As List(Of Nivel)

  '  ln = obj.Listar
  '  Me.cboNivel.DisplayMember = "Nombre"
  '  Me.cboNivel.ValueMember = "nombre"
  '  Me.cboNivel.DataSource = ln
  'End Sub

  Private Sub txtNombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
    If Me.txtNombre.Text.Length = 0 Then
      e.Cancel = True
      errTurno.SetError(Me.txtNombre, "Ingrese el nombre del turno")
    Else
      errTurno.SetError(Me.txtNombre, Nothing)
    End If
  End Sub

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click, dgvturnos.DoubleClick
    If Me.dgvturnos.RowCount > 0 Then
      With CType(dgvturnos.SelectedRows.Item(0).DataBoundItem, Turno)
        Me.txtNombre.Text = .Nombre.Trim
        'Me.cboNivel.Text = .ONivel.Nombre
        Me.dtpHIngreso.Value = .HoraIni
        Me.dtpHSalida.Value = .HoraFin
        codigo = .Codigo
        'Me.cboNivel.Enabled = False
      End With
      Me.btnRegistrar.Text = "&Actualizar"
      codigoEstado = 1
    End If
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    codigoEstado = 0
    Me.btnRegistrar.Text = "&Registrar"
    errTurno.SetError(Me.txtNombre, Nothing)
    'Me.cboNivel.Enabled = True
    Me.txtNombre.Text = ""
    Me.txtNombre.Focus()
  End Sub

End Class