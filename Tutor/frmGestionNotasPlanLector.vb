Public Class frmGestionNotasPlanLector
    Private codigoEstado As Integer = 0

    Private Sub frmGestionNotasPlanLector_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que desea cerrar la ventana?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Colegio.ITutor.frmPrincipal.Visible = True
        End If
    End Sub

    Private Sub frmGestionNotasPlanLector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
        Me.btncancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
        Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
        txtAnio.Text = moAnioActual.anio
        CargarSeccion()
        CargarPresentaciones()
    End Sub
    Private Function CargarSeccion() As Boolean
        Dim obj As New RNSeccion
        Dim ls As List(Of Seccion)

        ls = obj.ListarSeccionTutorPlanLector(New Seccion(moAnioActual, New Grado(), Nothing, New Docente(mOUsuario.Persona.Codigo)))
        If ls.Count > 0 Then
            cboSeccion.DisplayMember = "NivelNumeroLetra"
            cboSeccion.ValueMember = "NivelNumeroLetra"
            cboSeccion.DataSource = ls
            Return True
        Else
            MessageBox.Show("El Plan Lector sólo se aplica en el proyecto LASER!!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            'Me.Close()
        End If
    End Function
    Private Sub CargarPresentaciones()
        Dim obj As New RNPresentacion
        Dim lpres As List(Of Presentacion)

        If cboSeccion.SelectedIndex > -1 Then
            lpres = obj.ListarPresVigentes(moAnioActual.anio)

            cboPresentacion.DisplayMember = "Nro"
            cboPresentacion.ValueMember = "Codigo"

            cboPresentacion.DataSource = lpres

        Else
            btnListar.Enabled = False

        End If
    End Sub
    Public Sub Gestionar()

        If CargarSeccion() Then
            Me.ShowDialog()
        End If

    End Sub
    Private Sub cboPresentacion_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPresentacion.Leave
        btnListar.Focus()
    End Sub
    Private Sub txtAnio_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAnio.Enter
        cboSeccion.Focus()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Private Sub cboPresentacion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPresentacion.SelectedIndexChanged
        If cboPresentacion.SelectedIndex > -1 Then
            txtInicio.Text = FormatDateTime(CType(cboPresentacion.SelectedItem, Presentacion).Inicio, DateFormat.ShortDate)
            txtFin.Text = FormatDateTime(CType(cboPresentacion.SelectedItem, Presentacion).Fin.Date, DateFormat.ShortDate)
            LimpiarAlumnos()
            codigoEstado = 0
        Else
            txtInicio.Text = ""
            txtFin.Text = ""
        End If
    End Sub

    Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
        Listar()
    End Sub
    Private Sub Listar()

        If Me.cboPresentacion.SelectedIndex > -1 Then
            LimpiarAlumnos()

            MostrarAlumnosPresentacion()

            Me.dgvNotas.ClearSelection()
        End If

        Me.WindowState = FormWindowState.Maximized

    End Sub
    Private Sub MostrarAlumnosPresentacion()
        Dim obj As New RNNotaLectura
        Dim lm As List(Of NotaLectura)

        lm = obj.ListarAlumnosPresentacion(CType(cboSeccion.SelectedItem, Seccion), CType(cboPresentacion.SelectedItem, Presentacion), moAnioActual.anio)
        If lm.Count > 0 Then
            Me.dgvNotas.AutoGenerateColumns = False
            Me.dgvNotas.DataSource = lm

            For Each N In lm
                If N.Nota <> "" Then
                    codigoEstado = 1
                    Exit For
                End If
            Next

            Me.txtTotal.Text = lm.Count.ToString
            btnRegistrar.Enabled = True
        Else
            Me.txtTotal.Text = lm.Count.ToString
            btnRegistrar.Enabled = False
        End If
        lm = Nothing

    End Sub
    Private Sub LimpiarAlumnos()
        Me.dgvNotas.ClearSelection()
        Try
            Me.dgvNotas.DataSource = Nothing
            Me.dgvNotas.Rows.Clear()
            
            Me.txtTotal.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub Limpiar()
        Me.cboPresentacion.SelectedIndex = -1
        LimpiarAlumnos()
        codigoEstado = 0
        txtInicio.Text = ""
        txtFin.Text = ""
        Me.btnRegistrar.Text = "&Guardar"
        Me.btnRegistrar.Enabled = False
    End Sub

    Private Sub dgvNotas_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvNotas.CellValidating
        Dim letra As String = ""
        letra = e.FormattedValue.ToString().ToUpper

        If dgvNotas.CurrentCell.ColumnIndex = 2 Then
            If Not (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
                If Not (letra = "A" Or letra = "B" Or letra = "C" Or letra = "AD" Or letra = "NP") Then
                    MessageBox.Show("Sólo puede ingresar: A,B,C,AD y NP", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub dgvNotas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvNotas.KeyDown
        If dgvNotas.CurrentCell IsNot Nothing Then
            With dgvNotas.CurrentCell
                If .ColumnIndex = 2 Then
                    If e.KeyCode = Keys.Delete Then
                        dgvNotas.CurrentCell.Value = Nothing
                    End If
                End If
            End With
        End If
    End Sub
    Private Sub dgvAlumNotas_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvNotas.EditingControlShowing
        AddHandler e.Control.KeyPress, AddressOf Validar
        RemoveHandler e.Control.KeyPress, AddressOf Validar
    End Sub
    Private Sub Validar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Validar Fila seleccionada
        Dim drwFila As DataGridViewCell = dgvNotas.CurrentCell()

        If drwFila.ColumnIndex = 2 Then
            e.KeyChar = UCase(e.KeyChar)
            If (e.KeyChar = ChrW(Keys.A)) Or (e.KeyChar = ChrW(Keys.B)) Or (e.KeyChar = ChrW(Keys.C)) Or (e.KeyChar = ChrW(Keys.D)) _
                Or (e.KeyChar = ChrW(Keys.N)) Or (e.KeyChar = ChrW(Keys.P)) Or (e.KeyChar = ChrW(Keys.Back)) Then
                e.Handled = False
            Else
                MessageBox.Show("Sólo puede ingresar: A,B,C,AD y NP", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If

        'VerificarCeldaProm(e)

    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        If Me.dgvNotas.Rows.Count > 0 Then
            If codigoEstado = 0 Then
                RegistrarNota()
                MessageBox.Show("Las notas se registraron con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
                Listar()
            Else
                RegistrarNuevaNota()
                MessageBox.Show("Actualización realizada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
                Listar()
            End If
        Else
            Limpiar()
            MessageBox.Show("No ha ingresado notas", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub RegistrarNota()
        Dim obj As RNNotaLectura = Nothing
        Dim letra As String = ""
        Dim coment As String = ""
        Dim nroMat As Integer = 0
        Dim codPL As Integer = 0


        Try
            obj = New RNNotaLectura

            For i As Integer = 0 To Me.dgvNotas.RowCount - 1

        nroMat = CType(Me.dgvNotas.Rows(i).DataBoundItem, NotaLectura).Matricula.Numero
        codPL = CType(Me.dgvNotas.Rows(i).DataBoundItem, NotaLectura).ProgLectura.Codigo

        If CStr(Me.dgvNotas.Rows(i).Cells("cdNota").EditedFormattedValue) <> "" Then
          letra = (Me.dgvNotas.Rows(i).Cells("cdNota").EditedFormattedValue).ToString.ToUpper
          Select Case letra
            Case "C"
              coment = "Requiere Recuperación"
            Case "NP"
              coment = "No se Presento"
          End Select
          obj.Registrar(New NotaLectura(0, letra, coment, Now, True, New ProgramacionLectura(codPL), New Matricula(nroMat), mOUsuario.Persona.Codigo))
        End If

      Next
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    Finally
      obj = Nothing
    End Try

  End Sub

  Private Sub RegistrarNuevaNota()
    Dim obj As RNNotaLectura = Nothing
    Dim letra As String = ""
    Dim NotaLect As NotaLectura

    Dim coment As String = ""
    Dim nroMat As Integer = 0
    Dim codPL As Integer = 0

    Try
      obj = New RNNotaLectura

      For i As Integer = 0 To Me.dgvNotas.RowCount - 1

        nroMat = CType(Me.dgvNotas.Rows(i).DataBoundItem, NotaLectura).Matricula.Numero
        codPL = CType(Me.dgvNotas.Rows(i).DataBoundItem, NotaLectura).ProgLectura.Codigo

        If Me.dgvNotas.Rows(i).Cells("cdNota").EditedFormattedValue.ToString <> "" Then
          letra = (Me.dgvNotas.Rows(i).Cells("cdNota").EditedFormattedValue).ToString.ToUpper

          coment = ""

          Select Case letra
            Case "C"
              coment = "Requiere Recuperación"
            Case "NP"
              coment = "No se Presento"
          End Select

          NotaLect = obj.LeerNota(New NotaLectura(New Matricula(nroMat), "", "", New ProgramacionLectura(codPL)))
          If NotaLect Is Nothing Then
            obj.Registrar(New NotaLectura(0, letra, coment, Now, True, New ProgramacionLectura(codPL), _
                                          New Matricula(nroMat), mOUsuario.Persona.Codigo))
          Else
            If letra.Trim <> NotaLect.Nota.Trim Then
              obj.RegistrarNuevaNota(New NotaLectura(NotaLect.Codigo, letra, coment, Now, True, _
                                      New ProgramacionLectura(codPL), New Matricula(nroMat), mOUsuario.Persona.Codigo))
            End If
          End If
        End If

      Next
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Try

  End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Limpiar()
    End Sub

    Private Sub cboSeccion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSeccion.SelectedIndexChanged
        If cboSeccion.SelectedIndex > -1 Then
            Limpiar()
        End If
    End Sub

End Class