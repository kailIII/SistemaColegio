
Public Class frmGestionAsistencia

  Private codigo As Integer
  Private lm As List(Of Asistencia) = Nothing
  Private Asist As New Asistencia

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim obj As RNAsistencia = Nothing
    Dim i As Integer = 0
    Dim estado As String = ""
    Dim A As Asistencia = Nothing
    Try

      If MessageBox.Show("Sr(a) Tutor va a  registrar  las faltas y tardanzas del aula, una vez registrada sólo tendra opción a justificar más no a registrar.", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
        If codigo = 0 Then
          A = New Asistencia
          obj = New RNAsistencia
          For i = 0 To dgvAsistencia.Rows.Count - 1
            A = CType(dgvAsistencia.Rows(i).DataBoundItem, Asistencia)

            obj.Registrar(New Asistencia(0, A.Estado, dtpFecha.Value, New Matricula(A.Matricula.Numero), _
                          mOPeriodoActual.Codigo, mOUsuario.Persona.Codigo))
          Next
          MessageBox.Show("Asistencia del dia  " & dtpFecha.Value.ToShortDateString & "  registrada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          Listar()
          btnRegistrar.Visible = False
          btnJustificar.Visible = True
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
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
    Listar()
    Me.dgvAsistencia.ClearSelection()
  End Sub
  Private Sub cargarSecciones()
    Dim obj As New RNSeccion
    Dim ls As List(Of Seccion)

    ls = obj.ListarSeccionTutor(New Seccion(moAnioActual, New Grado(), Nothing, New Docente(mOUsuario.Persona.Codigo)))

    If ls.Count > 0 Then
      cboSeccion.DisplayMember = "NivelNumeroLetra"
      cboSeccion.ValueMember = "NivelNumeroLetra"
      cboSeccion.DataSource = ls
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
          btnRegistrar.Visible = True
          LlenarcolEstado()
          For i As Integer = 0 To dgvAsistencia.Rows.Count - 1
            A = CType(dgvAsistencia.Rows(i).DataBoundItem, Asistencia)
            If A.Codigo > 0 Then
              aux = True

              If A.Estado.Trim = "T" Or A.Estado.Trim = "F" Then
                dgvAsistencia.Rows(i).Cells("cdSituacion").Value = A.NombreEstado
                dgvAsistencia.Rows(i).DefaultCellStyle.BackColor = Color.OrangeRed
                dgvAsistencia.Rows(i).Cells("cdSituacion").ReadOnly = True

              ElseIf A.Estado.Trim = "TJ" Or A.Estado.Trim = "FJ" Then
                dgvAsistencia.Rows(i).Cells("cdSituacion").Value = A.NombreEstado
                dgvAsistencia.Rows(i).Cells("cdJustificado").Value = True
                dgvAsistencia.Rows(i).DefaultCellStyle.BackColor = Color.GreenYellow
                dgvAsistencia.Rows(i).Cells("cdSituacion").ReadOnly = True
              Else
                dgvAsistencia.Rows(i).Cells("cdSituacion").Value = "Asistencia"

              End If
            Else
              Me.btnRegistrar.Visible = True
              Me.btnJustificar.Visible = False
              dgvAsistencia.Rows(i).Cells("cdSituacion").Value = "Asistencia"

            End If
          Next
        End If
        If aux Then
          For i = 0 To dgvAsistencia.Rows.Count - 1
            Me.btnRegistrar.Visible = False
            Me.btnJustificar.Visible = True
            dgvAsistencia.Rows(i).Cells("cdSituacion").ReadOnly = True
          Next
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
    Listar()

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
    Limpiar()
    Me.btnListar.Enabled = True
  End Sub


  Private Sub btnJustificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJustificar.Click, dgvAsistencia.DoubleClick
    Asist = CType(dgvAsistencia.SelectedRows.Item(0).DataBoundItem, Asistencia)
    If btnRegistrar.Visible = False Then
      If CType(dgvAsistencia.SelectedRows.Item(0).Cells("cdJustificado").Value, Boolean) = True Then
        MessageBox.Show(Asist.Estado & "  ya esta justificada", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      ElseIf Asist.Estado = "Falta" Or Asist.Estado = "Tardanza" Then
        MostarJustificar()
        Me.btnListar.Enabled = False
      Else
        MessageBox.Show("Ud. ya registró las faltas y tardanzas, sólo tiene opción a justificar!!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
    End If
  End Sub

  Private Sub MostarJustificar()
    btnRegistrar.Visible = False
    'btnCerrar.Visible = False
    btnJustificar.Visible = False
    gbJustificacion.Visible = True

    If dgvAsistencia.SelectedRows.Count > 0 Then
      MostrarTutor(Asist.Matricula.Alumno.Codigo)
      txtDesc.Focus()
    Else
      MessageBox.Show("Seleccione un alumno!!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If

  End Sub

  Private Sub MostrarTutor(ByVal wCod As Integer)
    Dim obj As RNApoderado = Nothing
    Dim A As New List(Of Parentesco)
    obj = New RNApoderado

    A = obj.ListarParentesco(wCod)
    cboPadre.DataSource = A
    cboPadre.DisplayMember = "NombreCompleto"
    cboPadre.ValueMember = "CodigoApoderado"
    dgvAsistencia.Enabled = False
  End Sub


  Private Sub btnRegJust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegJust.Click

    Dim obj As RNAsistencia = Nothing
    If cboPadre.SelectedIndex > -1 And txtDesc.Text.Length > 0 Then
      obj = New RNAsistencia
      obj.Justificar(New Asistencia(Asist.Codigo, Asist.Estado, dtpFechaJust.Value, txtDesc.Text, True, CInt(cboPadre.SelectedValue), _
                        mOUsuario.Persona.Codigo))
      MessageBox.Show("Justificación registrada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Limpiar()
      Listar()
      Me.btnListar.Enabled = True
    Else
      MessageBox.Show("Debe llenar todos los campos!!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub Limpiar()
    Me.gbJustificacion.Visible = False

    Me.btnJustificar.Visible = True
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


End Class