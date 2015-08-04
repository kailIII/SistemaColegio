
Public Class frmVirtudComportamiento
  Private codigo As Integer = 0
  Private CodVirtud As Integer
  Private ListP As List(Of PeriodoAcademico)

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub frmVirtudComportamiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    MostrarImagenes()
    ListarNiveles()
    ListarPeriodos()
    Me.chkVigente.Visible = False
    Me.cboNivel.SelectedIndex = -1
    Me.cboPeriodo.SelectedIndex = -1
    LimpiarLista()
  End Sub

  Public Sub Gestion()
    Me.ShowDialog()
  End Sub

  Private Sub LimpiarLista()
    Me.dgVirtudes.DataSource = Nothing
    Me.dgVirtudes.Rows.Clear()
  End Sub

  Private Sub MostrarImagenes()
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnDeshacer.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnModificar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Editar.jpg")
  End Sub

  Private Sub ListarNiveles()
    Dim ListNa As List(Of Nivel)
    Dim objNa As New RNNivel

    ListNa = objNa.Listar()
    If ListNa.Count > 0 Then
      cboNivel.DisplayMember = "nombre"
      cboNivel.ValueMember = "codigoModular"
      cboNivel.DataSource = ListNa
    End If
    ListNa = Nothing
  End Sub

  Private Sub ListarPeriodos()
    Dim obj As New RNPeriodoAcademico

    ListP = obj.ListarCodPeriodos(moAnioActual)
    If ListP.Count > 0 Then
      cboPeriodo.DisplayMember = "nombre"
      cboPeriodo.ValueMember = "codigoModular"
      cboPeriodo.DataSource = ListP
    End If
  End Sub

  Private Sub txtVirtud_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVirtud.KeyPress
    If Char.IsLetter(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False And _
           Char.IsSeparator(e.KeyChar) = False AndAlso e.KeyChar <> "'"c AndAlso e.KeyChar <> "." Then
      e.Handled = True
    End If
  End Sub

  Private Sub txtVirtud_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtVirtud.Validating
    If Me.txtVirtud.Text.Length = 0 Then
      e.Cancel = True
      errVirtud.SetError(Me.txtVirtud, "Ingrese Virtud")
    Else
      errVirtud.SetError(Me.txtVirtud, Nothing)
    End If
  End Sub

  Private Sub cboPeriodo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboPeriodo.Validating
    If Me.cboPeriodo.Text.Length = 0 Then
      e.Cancel = True
      errVirtud.SetError(Me.cboPeriodo, "Seleccione Periodo")
    Else
      errVirtud.SetError(Me.cboPeriodo, Nothing)
    End If
  End Sub

  Private Sub cboNivel_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboNivel.Validating
    If Me.cboNivel.Text.Length = 0 Then
      e.Cancel = True
      errVirtud.SetError(Me.cboNivel, "Seleccione Periodo")
    Else
      errVirtud.SetError(Me.cboNivel, Nothing)
    End If
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim obj As RNVirtud = Nothing

    If Me.ValidateChildren Then
      Try
        obj = New RNVirtud
        If codigo = 0 Then
          If Me.chkRegTodos.Checked Then
            For Each p As PeriodoAcademico In ListP
              obj.Registrar(New Virtud(0, Me.txtVirtud.Text.Trim, True, moAnioActual, _
                  New PeriodoAcademico(p.Codigo) _
                  , New Nivel(CType(Me.cboNivel.SelectedItem, Nivel).Codigo), CInt(Me.nupNumero.Value)))
            Next
          Else
            obj.Registrar(New Virtud(0, Me.txtVirtud.Text.Trim, True, moAnioActual, _
                    New PeriodoAcademico(CType(Me.cboPeriodo.SelectedItem, PeriodoAcademico).Codigo) _
                    , New Nivel(CType(Me.cboNivel.SelectedItem, Nivel).Codigo), CInt(Me.nupNumero.Value)))
          End If
          MessageBox.Show("Virtud(es) registrada(s) con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          obj.Actualizar(New Virtud(CodVirtud, Me.txtVirtud.Text.Trim, Me.chkVigente.Checked, moAnioActual, _
                    New PeriodoAcademico(), New Nivel(), CInt(Me.nupNumero.Value)))
          MessageBox.Show("Virtud actualizada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      Finally
        obj = Nothing
        Limpiar()
        ListarVirtudes()
      End Try
    End If

  End Sub

  Private Sub cboPeriodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriodo.SelectedIndexChanged
    If Me.cboPeriodo.SelectedIndex > -1 And Me.cboNivel.SelectedIndex > -1 Then
      LimpiarLista()
      ListarVirtudes()
    End If
  End Sub

  Private Sub ListarVirtudes()
    Dim obj As New RNVirtud
    Dim lv As List(Of Virtud) = Nothing

    lv = obj.ListarVirtudes(New Virtud(0, "", True, moAnioActual, _
                        New PeriodoAcademico(CType(Me.cboPeriodo.SelectedItem, PeriodoAcademico).Codigo), _
                        New Nivel(CType(Me.cboNivel.SelectedItem, Nivel).Codigo), 0))
    If lv.Count > 0 Then
      Me.dgVirtudes.AutoGenerateColumns = False
      Me.dgVirtudes.DataSource = lv
      Me.dgVirtudes.Columns(0).DataPropertyName = "Id"
      Me.dgVirtudes.Columns(1).DataPropertyName = "Nombre"
    End If
    lv = Nothing
    Me.dgVirtudes.ClearSelection()
  End Sub

  Private Sub btnDeshacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeshacer.Click
    Me.cboNivel.SelectedIndex = -1
    Me.cboPeriodo.SelectedIndex = -1
    Limpiar()
  End Sub

  Private Sub Limpiar()
    Me.txtVirtud.Text = ""    
    LimpiarLista()
    Me.chkRegTodos.Visible = True
    Me.chkRegTodos.Checked = False
    Me.chkVigente.Visible = False
    errVirtud.SetError(Me.cboNivel, Nothing)
    errVirtud.SetError(Me.cboPeriodo, Nothing)
    errVirtud.SetError(Me.txtVirtud, Nothing)
    Me.cboNivel.Enabled = True
    Me.cboPeriodo.Enabled = True
    Me.txtVirtud.Focus()
    Me.btnRegistrar.Text = "&Registrar"
    codigo = 0
  End Sub

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click, dgVirtudes.DoubleClick
    Me.cboNivel.Enabled = False
    Me.cboPeriodo.Enabled = False
    Me.txtVirtud.Text = CType(Me.dgVirtudes.CurrentRow.DataBoundItem, Virtud).Nombre
    Me.nupNumero.Value = CType(Me.dgVirtudes.CurrentRow.DataBoundItem, Virtud).Id
    Me.chkVigente.Visible = True
    Me.chkVigente.Checked = CType(Me.dgVirtudes.CurrentRow.DataBoundItem, Virtud).Vigencia
    CodVirtud = CType(Me.dgVirtudes.CurrentRow.DataBoundItem, Virtud).Codigo
    Me.chkRegTodos.Visible = False
    codigo = 1
    Me.dgVirtudes.ClearSelection()
    Me.btnRegistrar.Text = "&Actualizar"
  End Sub

  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNivel.SelectedIndexChanged
    If Me.cboNivel.SelectedIndex > -1 Then
      LimpiarLista()
      Me.cboPeriodo.SelectedIndex = -1
    End If
  End Sub
End Class