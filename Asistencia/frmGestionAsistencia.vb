
Public Class frmGestionAsistencia

  Private codigo As Integer
  Private lm As List(Of Asistencia) = Nothing
  Private Asistencia As New Asistencia
  Private vector(70) As String
  Private swError As Integer = 0

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim obj As RNAsistencia = Nothing
    Dim i As Integer = 0
    Dim estado As String = ""
    Dim A As Asistencia = Nothing

    Try
      If codigo = 0 Then
        A = New Asistencia
        obj = New RNAsistencia

        For i = 0 To dgvAsistencia.Rows.Count - 1
          A = CType(dgvAsistencia.Rows(i).DataBoundItem, Asistencia)
          If vector(i) = "Asistencia" And Me.dgvAsistencia.Rows(i).Cells(2).EditedFormattedValue <> "Asistencia" Then
            obj.Registrar(New Asistencia(0, A.Estado, dtpFecha.Value, New Matricula(A.Matricula.Numero), _
                        mOPeriodoActual.Codigo, mOUsuario.Persona.Codigo))
            swError = 1
          ElseIf vector(i) <> "Asistencia" And Me.dgvAsistencia.Rows(i).Cells(2).EditedFormattedValue <> vector(i) Then
            obj.Elimina_Actualiza(New Asistencia(A.Codigo, A.Estado, Nothing, Nothing, Nothing, Nothing))
            swError = 1
          End If
        Next
        If swError = 1 Then
          MessageBox.Show("Asistencia del dia  " & dtpFecha.Value.ToShortDateString & "  guardada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        IniciaVector()
        Listar()
        GuardarSituacion()
        'btnRegistrar.Visible = False
        btnJustificar.Visible = True
      End If
      'End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Listar()
      GuardarSituacion()
      'btnRegistrar.Visible = False
      btnJustificar.Visible = True
    End Try
    swError = 0
  End Sub

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub frmGestionAsistencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnRegJust.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnJustificar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Editar.jpg")
    Me.btnRegJust.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")

    txtAnio.Text = moAnioActual.Anio
    dtpFecha.Value = DateAndTime.Now
    dtpFechaJust.Value = DateAndTime.Now
    cargarSecciones()
    codigo = 0
    Me.cboSeccion.SelectedIndex = 0
    IniciaVector()
    Listar()
    GuardarSituacion()
    Me.dgvAsistencia.ClearSelection()
  End Sub

  Private Sub cargarSecciones()
    Dim ls As List(Of Seccion)
    Dim objS As RNSeccion = New RNSeccion

    ls = objS.LeerNivelNumSec(New Seccion(0, moAnioActual.Anio, CChar("A")))
    If ls.Count > 0 Then
      Me.cboSeccion.DisplayMember = "NivelNumeroLetra"
      Me.cboSeccion.ValueMember = "NivelNumeroLetra"
      Me.cboSeccion.DataSource = ls
    Else
      Me.Close()
      MessageBox.Show("Registre secciones", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub Listar()
    Dim obj As RNAsistencia = Nothing
    Dim s As Seccion = Nothing
    Dim A As Asistencia = Nothing
    Dim aux As Boolean = False

    Try
      If Me.cboSeccion.Items.Count > 0 Then
        obj = New RNAsistencia
        s = CType(Me.cboSeccion.SelectedItem, Seccion)
        lm = obj.Listar(New Seccion(moAnioActual, New Grado(s.Grado.Codigo, s.Grado.Numero), s.Letra), dtpFecha.Value)
        Me.dgvAsistencia.AutoGenerateColumns = False
        Me.dgvAsistencia.DataSource = lm
        A = New Asistencia
        If lm.Count > 0 Then
          Me.btnRegistrar.Visible = True
          Me.LlenarcolEstado()
          For i As Integer = 0 To dgvAsistencia.Rows.Count - 1
            A = CType(dgvAsistencia.Rows(i).DataBoundItem, Asistencia)
            If A.Codigo > 0 Then
              aux = True
              If A.Estado.Trim = "T" Or A.Estado.Trim = "F" Then
                dgvAsistencia.Rows(i).Cells("cdSituacion").Value = A.NombreEstado
                dgvAsistencia.Rows(i).DefaultCellStyle.BackColor = Color.OrangeRed
              ElseIf A.Estado.Trim = "TJ" Or A.Estado.Trim = "FJ" Then
                dgvAsistencia.Rows(i).Cells("cdSituacion").Value = A.NombreEstado
                dgvAsistencia.Rows(i).Cells("cdJustificado").Value = True
                dgvAsistencia.Rows(i).DefaultCellStyle.BackColor = Color.GreenYellow
              Else
                dgvAsistencia.Rows(i).Cells("cdSituacion").Value = "Asistencia"
              End If
            Else
              Me.btnJustificar.Visible = False
              dgvAsistencia.Rows(i).Cells("cdSituacion").Value = "Asistencia"
            End If
          Next
        End If
        If aux Then
          Me.btnJustificar.Visible = True
        End If
        txtTotal.Text = lm.Count.ToString
        dgvAsistencia.Focus()

        dgvAsistencia.CurrentCell.Selected = True
        dgvAsistencia.Rows(0).Cells("cdSituacion").Selected = True
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Me.IniciaVector()
    Me.Listar()
    Me.GuardarSituacion()
  End Sub

  Private Sub GuardarSituacion()
    For i As Integer = 0 To Me.dgvAsistencia.RowCount - 1
      vector(i) = Me.dgvAsistencia.Rows(i).Cells(2).EditedFormattedValue.ToString.Trim
    Next
  End Sub

  Public Sub LlenarcolEstado()
    Dim column As DataGridViewComboBoxColumn = DirectCast(Me.dgvAsistencia.Columns("cdSituacion"), DataGridViewComboBoxColumn)
    Dim ListEstado As New List(Of Asistencia)
    ListEstado = LlenarEstado()
    With column
      .DataPropertyName = "Estado"
      .DisplayMember = "NombreEstado"
      .DataSource = ListEstado
    End With
    column = Nothing
    ListEstado = Nothing
  End Sub

  Public Function LlenarEstado() As List(Of Asistencia)
    Dim obj As New RNAsistencia
    Dim list As New List(Of Asistencia)
    list = obj.ListarEstado
    obj = Nothing
    Return list
  End Function

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Limpiar()
    Me.btnListar.Enabled = True
  End Sub


  Private Sub btnJustificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJustificar.Click, dgvAsistencia.DoubleClick
    'Asist = CType(dgvAsistencia.SelectedRows.Item(0).DataBoundItem, Asistencia)
    Asistencia = CType(dgvAsistencia.CurrentRow.DataBoundItem, Asistencia)
    If CType(dgvAsistencia.SelectedRows.Item(0).Cells("cdJustificado").Value, Boolean) = True Then
      Me.PresentarJustificacion()
    ElseIf Asistencia.Estado = "Falta" Or Asistencia.Estado = "Tardanza" Then
      Me.MostrarJustificar()
      Me.btnListar.Enabled = False
    Else
      MessageBox.Show("Ud. no puede justificar una asistencia!!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub PresentarJustificacion()
    Dim rn As New RNAsistencia
    Dim asis As Asistencia

    Try
      asis = rn.LeerJustificacion(Me.Asistencia)
      If asis IsNot Nothing Then
        Me.CargarTutores(Me.Asistencia.Matricula.Alumno.Codigo)
        Me.gbJustificacion.Enabled = True

        Me.dtpFechaJust.Value = asis.FechaJustificacion
        Me.txtDesc.Text = asis.Descripcion
        Me.cboPadre.SelectedValue = asis.Apoderado.Codigo
        Me.chkVigencia.Checked = True
        Me.chkVigencia.Enabled = True
        Me.chkVigencia.Visible = True
        Me.gbJustificacion.Visible = True
      Else
        MessageBox.Show("No se ha registrado justificación", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.gbJustificacion.Visible = False
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      rn = Nothing
    End Try
  End Sub

  Private Sub MostrarJustificar()
    Me.chkVigencia.Checked = True

    Me.btnRegistrar.Visible = False
    Me.btnJustificar.Visible = False
    Me.gbJustificacion.Visible = True

    If dgvAsistencia.SelectedRows.Count > 0 Then
      Me.CargarTutores(Asistencia.Matricula.Alumno.Codigo)
      Me.txtDesc.Focus()
    Else
      MessageBox.Show("Seleccione un alumno!!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub CargarTutores(ByVal wCod As Integer)
    Dim obj As RNApoderado = Nothing
    Dim apoderados As New List(Of Parentesco)
    obj = New RNApoderado

    apoderados = obj.ListarParentesco(wCod)
    cboPadre.DataSource = apoderados
    cboPadre.DisplayMember = "NombreCompleto"
    cboPadre.ValueMember = "CodigoApoderado"
    dgvAsistencia.Enabled = False
  End Sub

  Private Sub btnRegJust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegJust.Click
    Dim obj As RNAsistencia = Nothing

    If cboPadre.SelectedIndex > -1 And txtDesc.Text.Length > 0 Then
      Try
        obj = New RNAsistencia
        obj.Justificar(New Asistencia(Asistencia.Codigo, Asistencia.Estado, dtpFechaJust.Value, txtDesc.Text,
                                      Me.chkVigencia.Checked, CInt(cboPadre.SelectedValue), mOUsuario.Persona.Codigo))
        MessageBox.Show("Justificación registrada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Limpiar()
        'Listar()
        'Me.btnListar.Enabled = True
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        obj = Nothing
        Limpiar()
        Listar()
        Me.btnListar.Enabled = True
      End Try
    Else
      MessageBox.Show("Debe llenar todos los campos!!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub Limpiar()
    Me.gbJustificacion.Visible = False

    Me.btnJustificar.Visible = True
    Me.btnRegistrar.Visible = True
    Me.dgvAsistencia.Enabled = True
    Me.cboPadre.DataSource = Nothing
    Me.txtDesc.Text = ""

    Me.cboPadre.DataSource = Nothing
    Me.txtDesc.Text = ""
    codigo = 0
    txtTotal.Text = ""
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub txtAnio_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAnio.Enter
    dtpFecha.Focus()
  End Sub

  Private Sub dtpFecha_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.Enter
    Me.AcceptButton = btnListar
  End Sub

  Private Sub txtDesc_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDesc.Enter
    Me.AcceptButton = btnRegJust
  End Sub

  Private Sub frmGestionAsistencia_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    If MessageBox.Show("¿Está seguro que desea cerrar la ventana?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
      e.Cancel = True
    End If
  End Sub

  Private Sub IniciaVector()
    For i As Integer = 0 To 70
      vector(i) = ""
    Next
  End Sub

End Class