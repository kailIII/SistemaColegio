Public Class frmGestionAreasDRE

  Private codigoEstado As Integer = 0
  Private codigoAreaDRE As Integer

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Public Sub Gestionar()
    Dim objDRE As New RNDRE
    Dim objNivel As New RNNivel
    If objDRE.DatosDRE.Count > 0 And objNivel.Listar.Count > 0 Then
      Me.ShowDialog()
    Else
      MessageBox.Show("Ingrese datos de la DRE y niveles", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub txtArea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtArea.KeyPress
    If Char.IsLetter(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False And _
            Char.IsSeparator(e.KeyChar) = False AndAlso e.KeyChar <> "'"c AndAlso e.KeyChar <> "," Then
      e.Handled = True
    End If
  End Sub

  Private Sub ValidarCombo(ByVal e As System.ComponentModel.CancelEventArgs, ByVal opcion As ComboBox, ByVal msj As String)
    If opcion.SelectedIndex = -1 Then
      e.Cancel = True
      errAreaDre.SetError(opcion, msj)
    Else
      errAreaDre.SetError(opcion, Nothing)
    End If
  End Sub

  Private Sub cboDRE_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboDRE.Validating
    ValidarCombo(e, Me.cboDRE, "Debe indicar la DRE")
  End Sub

  Private Sub cboNivel_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboNivel.Validating
    ValidarCombo(e, Me.cboNivel, "Debe indicar el nivel del área")
  End Sub

  Private Sub txtArea_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtArea.Validating
    If Me.txtArea.Text.Length = 0 Then
      e.Cancel = True
      errAreaDre.SetError(Me.txtArea, "Ingrese el área")
    Else
      errAreaDre.SetError(Me.txtArea, Nothing)
    End If
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    errAreaDre.SetError(Me.txtArea, Nothing)
    errAreaDre.SetError(Me.cboNivel, Nothing)
    errAreaDre.SetError(Me.cboDRE, Nothing)
    Me.txtArea.Text = ""
    Me.txtArea.Focus()
    Me.btnRegistrar.Text = "&Registrar"
    codigoEstado = 0
    Me.cboDRE.Enabled = True
    Me.cboNivel.Enabled = True
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim obj As RNAreaDRE
    Dim ar As AreaDRE

    If Me.ValidateChildren Then
      obj = New RNAreaDRE

      ar = New AreaDRE() With {.Nombre = Me.txtArea.Text.Trim, _
                               .ODRE = DirectCast(Me.cboDRE.SelectedItem, DRE), _
                               .ONivel = DirectCast(Me.cboNivel.SelectedItem, Nivel), _
                               .OrdenActa = CInt(Me.nudOrden.Value)}
      If codigoEstado = 0 Then
        obj.Registrar(ar)
        MessageBox.Show("Datos del área registrados con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Else
        ar.Codigo = Me.codigoAreaDRE
        obj.Actualizar(ar)
        MessageBox.Show("Los datos del área fueron actualizados exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.btnRegistrar.Text = "&Registrar"
        Me.cboDRE.Enabled = True
        Me.cboNivel.Enabled = True
      End If
      Me.txtArea.Text = ""
      Me.codigoEstado = 0
      Me.ListarAreasNivel()
      Me.nudOrden.Value = 1
      Me.txtArea.Focus()
    End If
  End Sub

  Private Sub frmAreasDRE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.ListarDRE()
    Me.ListarNiveles()
    ' Me.txtArea.CharacterCasing = CharacterCasing.Upper
    Me.cboNivel.Focus()
    Me.MostrarImagenes()
  End Sub

  Public Sub MostrarImagenes()
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnModificar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Editar.jpg")
  End Sub

  Public Sub ListarDRE()
    Dim obj As New RNDRE
    Dim ld As List(Of DRE)

    ld = obj.DatosDRE
    Me.cboDRE.DisplayMember = "NombreDRE"
    Me.cboDRE.ValueMember = "NombreDRE"
    Me.cboDRE.DataSource = ld
  End Sub

  Public Sub ListarNiveles()
    Dim objNivel As New RNNivel
    Dim lni As List(Of Nivel)

    lni = objNivel.Listar
    Me.cboNivel.DisplayMember = "Nombre"
    Me.cboNivel.ValueMember = "nombre"
    Me.cboNivel.DataSource = lni
  End Sub

  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNivel.SelectedIndexChanged
    If Me.cboNivel.SelectedIndex > -1 Then
      ListarAreasNivel()
    End If
  End Sub

  Public Sub ListarAreasNivel()
    Dim obj As New RNAreaDRE
    Dim lg As List(Of AreaDRE)

    lg = obj.ListarAreaDRE(New AreaDRE(0, "", New DRE(), New Nivel(CType(Me.cboNivel.SelectedItem, Nivel).Codigo, "", "")))
    lbListArea.DataSource = lg
    lbListArea.DisplayMember = "Nombre"
  End Sub

  Private Sub lbListArea_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbListArea.DoubleClick, btnModificar.Click
    Dim objDRE As New RNDRE

    If Me.lbListArea.Items.Count > 0 Then
      Me.txtArea.Text = CType(Me.lbListArea.SelectedItem, AreaDRE).Nombre
      Me.cboNivel.Text = CType(Me.lbListArea.SelectedItem, AreaDRE).ONivel.Nombre
      Me.nudOrden.Value = CType(Me.lbListArea.SelectedItem, AreaDRE).OrdenActa
      Me.cboDRE.Text = objDRE.LeerNombreDRE(New DRE(CType(Me.lbListArea.SelectedItem, AreaDRE).ODRE.Codigo, "", "", "", "", ""))

      codigoAreaDRE = CType(Me.lbListArea.SelectedItem, AreaDRE).Codigo
      Me.btnRegistrar.Text = "&Actualizar"
      codigoEstado = 1
      Me.cboDRE.Enabled = False
      Me.cboNivel.Enabled = False
      Me.txtArea.Focus()
    End If

  End Sub

  Private Sub btnCoordinador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCoordinador.Click
    If Me.lbListArea.Items.Count > 0 Then
      Dim f As New frmGestionCoordinadorArea
      f.Registrar(cboNivel.SelectedIndex, CType(Me.lbListArea.SelectedItem, AreaDRE).Codigo)
    End If
  End Sub
End Class