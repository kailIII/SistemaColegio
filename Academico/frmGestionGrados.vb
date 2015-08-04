
Public Class frmGestionGrados
  Private codigoEstado As Integer = 0

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub frmGestionGrados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.txtNombreNum.CharacterCasing = CharacterCasing.Upper
    MostrarImagenes()
    ListarNiveles()
    AgregarGrados()
    Me.cboTipoCalif.SelectedIndex = 0
    Me.cboCaracteristica.SelectedIndex = 2
  End Sub

  Public Sub MostrarImagenes()
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnModificar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Editar.jpg")
  End Sub

  Public Sub ListarNiveles()
    Dim obj As New RNNivel
    Dim ln As List(Of Nivel)

    ln = obj.Listar
    Me.cboNivel.DisplayMember = "Nombre"
    Me.cboNivel.ValueMember = "nombre"
    Me.cboNivel.DataSource = ln
  End Sub

  Private Sub txtNombreNum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreNum.KeyPress
        If Char.IsLetter(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False And _
                    Char.IsDigit(e.KeyChar) = False And Char.IsSeparator(e.KeyChar) = False AndAlso e.KeyChar <> "'"c Then
            e.Handled = True
        End If
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim obj As RNGrado = Nothing
    Dim caracteristica As String = ""
    Dim eval As String = ""
    Dim tipoEval As String = ""
    'Dim tipoCalif As String = ""

    If Me.ValidateChildren Then
      Try
        obj = New RNGrado
        Select Case Me.cboCaracteristica.SelectedIndex
          Case 0 : caracteristica = "U"
          Case 1 : caracteristica = "PM"
          Case 2 : caracteristica = "PC"
        End Select

        If Me.rbAnual.Checked Then
          eval = Me.rbAnual.Text(0)
        Else
          eval = Me.rbPeriodo.Text(0)
        End If

        If Me.rbLiteral.Checked Then
          tipoEval = Me.rbLiteral.Text(0)
        Else
          tipoEval = Me.rbNumerica.Text(0)
        End If

        'If Me.cboTipoCalif.SelectedIndex = 0 Then
        '  tipoCalif = Me.cboTipoCalif.Text(0)
        'Else

        'End If

        If codigoEstado = 0 Then
          If obj.RetornaCG(New Seccion(0, CInt(Me.nudNumero.Value), CType(Me.cboNivel.SelectedItem, Nivel).Codigo, "", CChar("A"))) = 0 Then
            obj.Registrar(New Grado(0, CInt(Me.nudNumero.Value), Me.txtNombreNum.Text.Trim, New Nivel(CType(Me.cboNivel.SelectedItem, Nivel).Codigo, "", ""), Me.cboTipoCalif.Text(0), caracteristica.Trim, eval.Trim, tipoEval.Trim))
            MessageBox.Show("Grado registrado con éxito", "Gestión de grados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If Me.nudNumero.Maximum > Me.nudNumero.Value Then
              Me.nudNumero.Value += 1
            End If
          Else
            MessageBox.Show("Grado ya existe", "Gestión de grados", MessageBoxButtons.OK, MessageBoxIcon.Error)
          End If
        Else
          obj.Actualizar(New Grado(0, CInt(Me.nudNumero.Value), Me.txtNombreNum.Text.Trim, New Nivel(CType(Me.cboNivel.SelectedItem, Nivel).Codigo, "", ""), Me.cboTipoCalif.Text(0), caracteristica.Trim, eval.Trim, tipoEval.Trim))
          MessageBox.Show("Datos actualizados con éxito", "Gestión de grados", MessageBoxButtons.OK, MessageBoxIcon.Information)
          Me.btnRegistrar.Text = "&Registrar"
          Me.cboNivel.Enabled = True
          Me.nudNumero.Enabled = True
          codigoEstado = 0
        End If
        Me.txtNombreNum.Text = ""
        Me.cboCaracteristica.SelectedIndex = 2
        Me.txtNombreNum.Focus()
        AgregarGrados()
      Catch ex As Exception
        MessageBox.Show(ex.Message, "Gestión de niveles", MessageBoxButtons.OK, MessageBoxIcon.Error)
        obj = Nothing
      Finally
        obj = Nothing
      End Try
    End If
  End Sub

  Public Sub AgregarGrados()
    Dim obj As New RNGrado
    Dim lg As List(Of Grado)

    lg = obj.Leer(New Grado(0, CType(Me.cboNivel.SelectedItem, Nivel).Codigo, "", 0)) '''''zsdgsd
    dgvGrados.AutoGenerateColumns = False
    dgvGrados.DataSource = lg
    Me.dgvGrados.Columns(0).DataPropertyName = "Numero"
    Me.dgvGrados.Columns(1).DataPropertyName = "Nombre"
    Me.dgvGrados.Columns(2).DataPropertyName = "TipoCalif2"
    Me.dgvGrados.Columns(3).DataPropertyName = "LeerCaracteristica"
    'Me.dgvGrados.Focus()
  End Sub

  Private Sub txtNombreNum_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombreNum.Validating
    If Me.txtNombreNum.Text.Length = 0 Then
      e.Cancel = True
      errorGrado.SetError(Me.txtNombreNum, "Ingrese la descripción del grado")
    Else
      errorGrado.SetError(Me.txtNombreNum, Nothing)
    End If
  End Sub

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click, dgvGrados.DoubleClick
    If dgvGrados.SelectedRows.Count > 0 Then
      With CType(dgvGrados.SelectedRows.Item(0).DataBoundItem, Grado)
        Me.txtNombreNum.Text = .Nombre.Trim
        Me.cboNivel.Text = .nombreNivel
        If .TipoCalif = "L" Then
          Me.cboTipoCalif.SelectedIndex = 0
        Else
          Me.cboTipoCalif.SelectedIndex = 1
        End If
        Me.nudNumero.Value = .Numero
        Select Case .Caracteristica.Trim
          Case "U" : Me.cboCaracteristica.Text = "Unidocente"
          Case "PM" : Me.cboCaracteristica.Text = "Polidocente Multigrado"
          Case "PC" : Me.cboCaracteristica.Text = "Polidocente Completo"
        End Select
        If .EvaluacionComp = "A" Then
          Me.rbAnual.Checked = True
        Else
          Me.rbPeriodo.Checked = True
        End If
        If .TipoEval = "L" Then
          Me.rbLiteral.Checked = True
        Else
          Me.rbNumerica.Checked = True
        End If
      End With
      Me.btnRegistrar.Text = "&Actualizar"
      Me.cboNivel.Enabled = False
      Me.nudNumero.Enabled = False
      codigoEstado = 1
    Else
      MessageBox.Show("No existen grados", "Gestión de grados", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'Dim obj As RNGrado

    'If dgvGrados.RowCount > 0 Then
    '  obj = New RNGrado
    '  Try
    '    obj.Eliminar(New Grado(CType(dgvGrados.SelectedRows.Item(0).DataBoundItem, Grado).Codigo))
    '    MessageBox.Show("Grado eliminado", "Gestión de niveles", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    AgregarGrados()
    '  Catch ex As Exception
    '    MessageBox.Show(ex.Message, "Gestión de grados", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '  Finally
    '    obj = Nothing
    '  End Try
    'Else
    '  MessageBox.Show("No existen grados", "Gestión de grados", MessageBoxButtons.OK, MessageBoxIcon.Information)
    'End If
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.btnRegistrar.Text = "&Registrar"
    Me.txtNombreNum.Text = ""
    Me.cboCaracteristica.SelectedIndex = 2
    errorGrado.SetError(Me.txtNombreNum, Nothing)
    errorGrado.SetError(Me.cboNivel, Nothing)
    Me.txtNombreNum.Focus()
    Me.cboNivel.Enabled = True
    Me.nudNumero.Enabled = True
    Me.nudNumero.Value = 1
    codigoEstado = 0
  End Sub

  Private Sub cboNivel_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboNivel.Validating
    If Me.cboNivel.Text = "" Then
      e.Cancel = True
      errorGrado.SetError(Me.cboNivel, "Debe indicar la especialidad del Docente")
    Else
      errorGrado.SetError(Me.cboNivel, Nothing)
    End If
  End Sub

  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNivel.SelectedIndexChanged
    If Me.cboNivel.SelectedIndex > -1 Then
      AgregarGrados()
      Me.nudNumero.Value = 1
    End If
  End Sub

  Private Sub cboCaracteristica_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboCaracteristica.Validating
    If Me.cboCaracteristica.Text = "" Then
      e.Cancel = True
      errorGrado.SetError(Me.cboCaracteristica, "Debe indicar la caracteristica")
    Else
      errorGrado.SetError(Me.cboCaracteristica, Nothing)
    End If
  End Sub

End Class