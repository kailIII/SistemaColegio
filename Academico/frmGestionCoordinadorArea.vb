Public Class frmGestionCoordinadorArea
  Private codigo As Integer
  Private codigoCoord As Integer

  Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub cboNivel_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboNivel.Validating

    If cboNivel.SelectedIndex = -1 Then
      e.Cancel = True
      errValida.SetError(Me.cboNivel, "Debe indicar el nivel")
    Else
      errValida.SetError(Me.cboNivel, Nothing)
    End If

  End Sub

  Private Sub cboArea_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboArea.Validating
    If cboArea.SelectedIndex = -1 Then
      e.Cancel = True
      errValida.SetError(Me.cboArea, "Debe indicar el área")
    Else
      errValida.SetError(Me.cboArea, Nothing)
    End If
  End Sub
  Private Sub cboCoordiandor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboCoordiandor.Validating
    If cboCoordiandor.SelectedIndex = -1 Then
      e.Cancel = True
      errValida.SetError(Me.cboCoordiandor, "Debe indicar el Coordinador del área")
    Else
      errValida.SetError(Me.cboCoordiandor, Nothing)
    End If
  End Sub

  Private Sub frmCoordinadorArea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnGuardar.Text = "&Registrar"

    Me.btnGuardar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnEditar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Editar.jpg")

    'LimpiarDatos()
    'Dim obj As New modListar
    'obj.ListarNiveles(Me.cboNivel)

    'ListarCoordiandorArea()
    'Habilitar()

  End Sub
  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNivel.SelectedIndexChanged
    Dim obj As New RNGrado
    Dim ld As New List(Of Grado)

    If cboNivel.SelectedIndex > -1 Then
      ListarAreasNivel()

      ListarCoordiandorArea()
      Habilitar()
    End If
  End Sub
  Public Sub Habilitar()
    If dgvCoordArea.RowCount > 0 Then
      btnEditar.Enabled = True
    Else
      btnEditar.Enabled = False
    End If
  End Sub
  Public Sub ListarAreasNivel()
    Dim obj As New RNAreaDRE
    Dim lg As List(Of AreaDRE)

    lg = obj.ListarAreaDRE(New AreaDRE(0, "", New DRE(), New Nivel(CType(Me.cboNivel.SelectedItem, Nivel).Codigo, "", "")))

    If lg.Count > 0 Then
      cboArea.DataSource = lg
      cboArea.DisplayMember = "Nombre"
      cboArea.ValueMember = "codigo"
    Else
      cboArea.DataSource = Nothing
      lg = Nothing
    End If
  End Sub
  Public Sub LimpiarDatos()
    Me.btnGuardar.Text = "&Registrar"
    Me.CheckVigente.Visible = False
    Me.codigo = 0
  End Sub
  Private Sub ListarCoordiandorArea()
    Dim obj As New RNCoordinadorAreaDre
    Dim ld As List(Of CoordinadorAreaDre)

    ld = obj.ListarCoordArea(CStr(cboNivel.SelectedValue))
    obj = Nothing

    If ld.Count > 0 Then
      dgvCoordArea.AutoGenerateColumns = False
      dgvCoordArea.DataSource = ld
    Else
      dgvCoordArea.DataSource = Nothing
    End If

  End Sub
  Public Sub cargarDocentes()
    Dim ListD As New List(Of Docente)
    Dim objDoc As New RNDocente

    ListD = objDoc.Listar
    cboCoordiandor.DisplayMember = "NombreCompleto"
    cboCoordiandor.ValueMember = "codigo"
    cboCoordiandor.DataSource = ListD
    ListD = Nothing
  End Sub
  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    LimpiarDatos()
  End Sub

  Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    If Me.ValidateChildren Then
      Dim objD As New RNCoordinadorAreaDre

      Try

        If codigo = 0 Then
          objD.Registrar(New CoordinadorAreaDre(0, CheckVigente.Checked, CInt(cboArea.SelectedValue), CType(cboCoordiandor.SelectedItem, Docente)))

          MessageBox.Show("Coordinador registrado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
          objD.Modificar(New CoordinadorAreaDre(codigo, CheckVigente.Checked, CInt(cboArea.SelectedValue), CType(cboCoordiandor.SelectedItem, Docente)))

          MessageBox.Show("Los datos del Docente fueron actualizados exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

          Me.cboArea.Focus()

        End If
        LimpiarDatos()
        ListarCoordiandorArea()
        Habilitar()

      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        objD = Nothing
      End Try
    End If
  End Sub

  Public Sub Registrar(ByVal wnivel As Integer, ByVal warea As Integer)
    LimpiarDatos()
    Dim obj As New modListar
    obj.ListarNiveles(Me.cboNivel)
    Me.cboNivel.SelectedIndex = wnivel
    Me.cboArea.SelectedValue = warea
    cargarDocentes()
    ListarCoordiandorArea()
    Habilitar()

    Me.ShowDialog()
  End Sub

  Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click, dgvCoordArea.DoubleClick
    Dim obj As RNCoordinadorAreaDre = Nothing
    Dim c As CoordinadorAreaDre = Nothing

    If dgvCoordArea.SelectedRows.Count > 0 Then
      With CType(dgvCoordArea.SelectedRows.Item(0).DataBoundItem, CoordinadorAreaDre)
        obj = New RNCoordinadorAreaDre
        c = obj.Leer(New CoordinadorAreaDre(.Codigo))
        If c IsNot Nothing Then
          codigo = .Codigo
          codigoCoord = c.Personal.Codigo
          cboNivel.SelectedValue = c.AreaDre.ONivel.Codigo
          cboArea.SelectedValue = CInt(c.AreaDre.Codigo)
          CheckVigente.Visible = True
          CheckVigente.Checked = c.Vigencia
          cboCoordiandor.SelectedValue = c.Personal.Codigo
          Me.btnGuardar.Text = "&Actualizar"
          Me.cboCoordiandor.Focus()
        Else
          MessageBox.Show("No se pudo encontrar al Coordinador solicitado", "Gestión de Coordinadores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      End With

    End If
  End Sub



End Class