
Public Class frmGestionCurso

  Private Codigo As Integer
  Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
    If Char.IsLetter(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False And _
       Char.IsSeparator(e.KeyChar) = False AndAlso e.KeyChar <> "'"c Then
      e.Handled = True
    End If
  End Sub

  Private Sub txtNombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
    ValidarText(e, Me.txtNombre, "Debe ingresar nombre del curso")
  End Sub

  Private Sub txtHoras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nudHoras.KeyPress

    If Char.IsDigit(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False Then
      e.Handled = True
    End If
  End Sub

  Private Sub ValidarText(ByVal e As System.ComponentModel.CancelEventArgs, ByVal cadena As TextBox, ByVal msj As String)
    If cadena.Text.Length = 0 Then
      e.Cancel = True
      errValida.SetError(cadena, msj)
    Else
      errValida.SetError(cadena, "")
    End If
  End Sub


  Private Sub frmCurso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnModificar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Editar.jpg")

    Dim obj As New modListar
    Me.nudHoras.Value = 4

    obj.ListarNiveles(Me.cboNivel)
  End Sub

  Public Sub LimpiarDatos()
    Me.Codigo = 0

    Me.txtNombre.Text = ""
    Me.nudHoras.Text = "4"
    Me.cboNivel.Enabled = True
    Me.rbUnidocente.Checked = True
    Me.chkRotativo.Checked = False
    Me.chkVigencia.Checked = True
    Me.chkVigencia.Enabled = False

    Me.btnRegistrar.Text = "&Registar"
  End Sub

  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNivel.SelectedIndexChanged
    Dim obj As New RNGrado
    Dim ld As New List(Of Grado)

    If cboNivel.SelectedIndex > -1 Then
      ld = obj.Listar(New Grado(CInt(cboNivel.SelectedValue), ""))
      obj = Nothing

      If ld.Count > 0 Then
        Me.cboGrado.DisplayMember = "nombre"
        Me.cboGrado.ValueMember = "codigo"
        Me.cboGrado.DataSource = ld
        Me.cboGrado.SelectedIndex = 0
        ListarAreasNivel()
        Habilitar()
      Else
        cboGrado.DataSource = Nothing
      End If
    End If

    'If cboNivel.SelectedIndex = 0 Then
    '  cboGrado.Enabled = False
    'Else
    '  cboGrado.Enabled = True
    'End If

  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim obj As RNCurso = Nothing
    Dim cur As Curso

    If Me.ValidateChildren Then
      obj = New RNCurso
      Try
        cur = New Curso(0, CStr(Me.txtNombre.Text.Trim), CInt(Me.nudHoras.Value), CInt(Me.cboGrado.SelectedValue), _
                                   Me.chkVigencia.Checked, Not Me.rbUnidocente.Checked, Me.chkRotativo.Checked, CInt(Me.cboArea.SelectedValue))
        If Me.Codigo = 0 Then
          obj.Registrar(cur)
          MessageBox.Show("El curso fue registrado exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          cur.Codigo = Me.Codigo
          obj.Modificar(cur)
          MessageBox.Show("Los datos del Curso fueron actualizados exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.LimpiarDatos()
        Me.ListarCursos()
        Me.Habilitar()
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        obj = Nothing
      End Try
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCursos.DoubleClick, btnModificar.Click
    Dim obj As RNCurso = Nothing
    Dim c As Curso = Nothing

    If dgvCursos.SelectedRows.Count > 0 Then
      With CType(dgvCursos.SelectedRows.Item(0).DataBoundItem, Curso)
        obj = New RNCurso
        c = obj.Leer(New Curso(.Codigo))
        If c IsNot Nothing Then
          Me.Codigo = .Codigo
          cboNivel.SelectedValue = c.Grado.codigoNivel
          cboGrado.SelectedValue = CInt(c.Grado.Codigo)
          cboArea.SelectedValue = CInt(c.CodigoAreaDre.Codigo)
          txtNombre.Text = c.Nombre
          nudHoras.Text = c.NumeroHoras.ToString
          If c.Grupo = False Then
            Me.rbUnidocente.Checked = True
          Else
            Me.rbPolidocente.Checked = True
          End If
          Me.chkRotativo.Checked = c.Rotativo
          Me.chkVigencia.Checked = c.vigencia
          Me.cboNivel.Enabled = False
          Me.chkVigencia.Enabled = True
          Me.btnRegistrar.Text = "&Actualizar"

          Me.txtNombre.Focus()
        Else
          MessageBox.Show("No se pudo encontrar al Curso solicitado", "Gestión de Cursos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      End With
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
  Private Sub ListarCursos()
    Dim obj As New RNCurso
    Dim ld As List(Of Curso)

    ld = obj.Listar(New Grado(CInt(cboGrado.SelectedValue)))
    obj = Nothing

    If ld.Count > 0 Then
      dgvCursos.AutoGenerateColumns = False
      dgvCursos.DataSource = ld
    Else
      dgvCursos.DataSource = Nothing
    End If
  End Sub
  Private Sub Habilitar()
    If dgvCursos.RowCount > 0 Then
      btnModificar.Enabled = True
    Else
      btnModificar.Enabled = False
    End If
  End Sub
  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.LimpiarDatos()
  End Sub

  Private Sub cboGrado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboGrado.SelectedIndexChanged
    If cboGrado.SelectedIndex > -1 Then
      ListarCursos()
      Habilitar()
    End If
  End Sub


  Private Sub cboArea_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboArea.SelectedIndexChanged
    If cboArea.SelectedIndex > -1 Then
      Me.txtNombre.Text = cboArea.Text
    Else
      Me.txtNombre.Text = ""
    End If
  End Sub
End Class
