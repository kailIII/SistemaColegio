
Public Class frmEquivNotasComp
  Private codigo As Integer = 0
  Private codigoEquiv As Integer
  Private objInst As Institucion = Nothing

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub frmEquivNotasComp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    MostrarImagenes()
    Institucion()
    ListarEquivalencias()
    Me.chkVigente.Visible = False
  End Sub

  Private Sub MostrarImagenes()
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnDeshacer.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnModificar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Editar.jpg")
  End Sub

  Private Sub Institucion()
    Dim obj As New RNInstitucion
    objInst = obj.Listar
    obj = Nothing
  End Sub

  Private Sub ListarEquivalencias()
    Dim obj As New RNEquivalencia
    Dim le As List(Of Equivalencia) = Nothing

    le = obj.ListarEquivalencias
    If le.Count > 0 Then
      Me.dgEquivalencia.AutoGenerateColumns = False
      Me.dgEquivalencia.DataSource = le
      Me.dgEquivalencia.Columns(0).DataPropertyName = "Puntos"
      Me.dgEquivalencia.Columns(1).DataPropertyName = "Literal"
    End If
    le = Nothing
    Me.dgEquivalencia.ClearSelection()
  End Sub

  Private Sub LimpiarEquivalencias()
    Me.dgEquivalencia.DataSource = Nothing
    Me.dgEquivalencia.Rows.Clear()
  End Sub

  Private Sub txtCualitativo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCualitativo.KeyPress, txtEspecif.KeyPress
    If Char.IsLetter(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False And _
            Char.IsSeparator(e.KeyChar) = False AndAlso e.KeyChar <> "'"c AndAlso e.KeyChar <> "." Then
      e.Handled = True
    End If
  End Sub

  Private Sub txtCualitativo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCualitativo.Validating
    If txtCualitativo.Text.Length = 0 Then
      e.Cancel = True
      errEquivalencia.SetError(Me.txtCualitativo, "Ingrese Cualitativo")
    Else
      errEquivalencia.SetError(Me.txtCualitativo, Nothing)
    End If
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim obj As RNEquivalencia = Nothing

    If Me.ValidateChildren Then
      obj = New RNEquivalencia

      Try
        If codigo = 0 Then
          obj.Registrar(New Equivalencia(0, Me.txtCualitativo.Text.Trim, _
                                      CInt(Me.nudPuntos.Value), Me.txtEspecif.Text.Trim, _
                                       True, objInst))
          MessageBox.Show("Equivalencia registrada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          obj.Actualizar(New Equivalencia(codigoEquiv, Me.txtCualitativo.Text.Trim, _
                      CInt(Me.nudPuntos.Value), Me.txtEspecif.Text.Trim, _
                      Me.chkVigente.Checked, objInst))
          MessageBox.Show("Equivalencia actualizada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        obj = Nothing
        Limpiar()
        LimpiarEquivalencias()
        ListarEquivalencias()
      End Try
    End If
  End Sub

  Private Sub btnDeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeshacer.Click
    Limpiar()
    LimpiarEquivalencias()
    ListarEquivalencias()
  End Sub

  Private Sub Limpiar()
    Me.txtCualitativo.Text = ""
    Me.txtEspecif.Text = ""
    Me.chkVigente.Visible = False
    errEquivalencia.SetError(Me.txtCualitativo, Nothing)
    Me.txtCualitativo.Focus()
    codigo = 0
    codigoEquiv = 0
    Me.btnRegistrar.Text = "&Registrar"
  End Sub

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click, dgEquivalencia.DoubleClick
    Me.txtCualitativo.Text = CType(Me.dgEquivalencia.CurrentRow.DataBoundItem, Equivalencia).Literal
    Me.txtEspecif.Text = CType(Me.dgEquivalencia.CurrentRow.DataBoundItem, Equivalencia).Especificacion
    Me.nudPuntos.Value = CDec(CType(Me.dgEquivalencia.CurrentRow.DataBoundItem, Equivalencia).Puntos)
    codigoEquiv = CType(Me.dgEquivalencia.CurrentRow.DataBoundItem, Equivalencia).Codigo
    Me.chkVigente.Visible = True
    Me.chkVigente.Checked = CType(Me.dgEquivalencia.CurrentRow.DataBoundItem, Equivalencia).Vigencia
    codigo = 1
    Me.btnRegistrar.Text = "&Actualizar"
    Me.txtCualitativo.Focus()
  End Sub

End Class