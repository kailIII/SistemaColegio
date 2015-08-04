
Public Class frmNotasSecundaria

  Private Ldc As List(Of DocenteCarga)
  Private Lu As List(Of Unidad)
  Private lc As List(Of Capacidad)
  Private ln As List(Of NotaCapacidad)
  Private contador As Integer = 0
  Private codigoEstado As Integer = 0
  Private control(10) As Label
  Private nroCap As Integer
  Private estado As Integer = 0
  Private row As Integer = 0
  Private unidad As Integer = 0
  Private swNota As Integer = 0
  Private swError As Integer = 0
  Private codigoUsu As Integer = 0

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub frmNotasSecundaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    MostrarImagenes()
    MostrarDocentes()
    Me.cboCurso.SelectedIndex = -1
    Me.cboNro.SelectedIndex = -1
    Me.txtDescripcion.Text = ""
    Me.btnListar.Enabled = False
    Me.Text = Me.Text & ":  " & moAnioActual.Anio & "   -  " & mOPeriodoActual.Nombre
    'Me.btnAceptar.Enabled = False
  End Sub

  Private Sub MostrarDocentes()
    Dim objRN As New RNDocente
    Dim ld As List(Of Docente) = Nothing

    ld = objRN.ListarDocentesSecundaria(mOPeriodoActual)
    If ld.Count > 0 Then
      cboDocente.DisplayMember = "NombreCompleto"
      cboDocente.ValueMember = "Codigo"
      cboDocente.DataSource = ld
    Else
      cboDocente.DataSource = Nothing
    End If
  End Sub

  Private Sub MostrarCursos()
    Dim objRN As New RNDocenteCarga

    Ldc = objRN.ListarCargaSeccion2(mOPeriodoActual, New Docente(codigoUsu)) 'mOUsuario.Persona.Codigo
    If Ldc.Count > 0 Then
      cboCurso.DisplayMember = "CursoSeccion"
      cboCurso.ValueMember = "Codigo"
      cboCurso.DataSource = Ldc
    Else
      cboCurso.DataSource = Nothing
    End If
  End Sub

  Private Sub MostrarImagenes()
    Me.btnAceptar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.dgNotas.ClearSelection()
    Me.Close()
  End Sub

  Private Sub MostrarNroUnidades()
    Dim obj As New RNUnidad

    Lu = obj.ListarUnidades(New Unidad(0, "", False, New PeriodoAcademico(mOPeriodoActual.Codigo), New DocenteCarga(CType(Me.cboCurso.SelectedItem, DocenteCarga).Codigo, "", Nothing, New CargaAcademica(CType(Me.cboCurso.SelectedItem, DocenteCarga).Carga.Codigo), Nothing)))
    If Lu.Count > 0 Then
      Me.cboNro.DisplayMember = "Numero"
      Me.cboNro.ValueMember = "Numero"
      Me.cboNro.DataSource = Lu
      Me.btnListar.Enabled = True
    Else
      Me.txtDescripcion.Text = ""
      Me.btnListar.Enabled = False
    End If
  End Sub

  Private Sub LimpiarUnidades()
    Me.cboNro.DataSource = Nothing
    Me.cboNro.Items.Clear()
  End Sub

  Private Sub LimpiarAlumnos()
    Me.dgNotas.ClearSelection()
    Try
      Me.dgNotas.DataSource = Nothing
      Me.dgNotas.Rows.Clear()
      While Me.dgNotas.Columns.Count > 2
        For i As Integer = 2 To Me.dgNotas.Columns.Count - 1
          Me.dgNotas.Columns.RemoveAt(i)
          Exit For
        Next
      End While
      Me.txtTotal.Text = ""
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try
  End Sub

  Private Sub cboCurso_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCurso.SelectedValueChanged
    If Me.cboCurso.SelectedIndex > -1 Then
      Me.dgNotas.CancelEdit()
      LimpiarUnidades()
      LimpiarLeyenda()
      estado = 0
      MostrarNroUnidades()
      contador += 1
      If contador = 1 Then
        Me.cboNro.DataSource = Nothing
        Me.cboNro.Items.Clear()
      Else
        LimpiarAlumnos()
        codigoEstado = 0
        Me.btnAceptar.Text = "&Registrar"
      End If
    End If
  End Sub

  Private Sub cboNro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNro.SelectedIndexChanged
    If Me.cboNro.SelectedIndex > -1 Then
      Me.txtDescripcion.Text = CType(Me.cboNro.SelectedItem, Unidad).Nombre
      'LimpiarAlumnos()
      'estado = 0
    End If
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    'Limpiar()
    'e.Empty = False
    'e.cancel = True
    Me.dgNotas.CancelEdit()
    Me.btnListar.Enabled = False
    LimpiarLeyenda()
    LimpiarUnidades()
    Me.txtDescripcion.Text = ""
    Me.cboCurso.SelectedIndex = -1
    LimpiarAlumnos()
    estado = 0
    Me.btnAceptar.Text = "&Registrar"
  End Sub

  Private Sub Limpiar()
    'LimpiarUnidades()
    'Me.txtDescripcion.Text = ""
    'Me.cboCurso.SelectedIndex = -1
    'LimpiarAlumnos()
    'codigoEstado = 0
    Me.btnAceptar.Text = "&Actualizar"
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Me.dgNotas.CancelEdit()
    ListarAlumnos()
  End Sub

  Private Sub ListarAlumnos()
    If Me.cboCurso.SelectedIndex > -1 Then
      ' dgNotas.Visible = False
      LimpiarAlumnos()
      MostrarAlumnosGrupo()
      MostrarCapacidades()
      MostrarLeyenda()
      PintarCeldas()
      ListarNotas()

      unidad = CType(Me.cboNro.SelectedItem, Unidad).Numero
      Me.dgNotas.ClearSelection()
      ' dgNotas.Visible = True
    Else
      MessageBox.Show("Seleccione Nivel - Grado - Sección - Curso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub ListarNotas()
    Dim obj As New RNNotaCapacidad
    Dim j As Integer

    ln = obj.ListarNotas(New Unidad(CType(Me.cboNro.SelectedItem, Unidad).Numero, "", True, _
                              New PeriodoAcademico(mOPeriodoActual.Codigo), _
                          New DocenteCarga(CType(Me.cboCurso.SelectedItem, DocenteCarga).Codigo)))
    If ln.Count > 0 Then
      For i As Integer = 0 To Me.dgNotas.RowCount - 1
        j = 2
        For Each cap As Capacidad In lc
          For Each nota As NotaCapacidad In ln
            If CType(Me.dgNotas.Rows(i).DataBoundItem, Matricula).Numero = nota.Matricula.Numero _
                And cap.Codigo = nota.Capacidad.Codigo Then
              If nota.Promedio > 0 Then
                Me.dgNotas.Rows(i).Cells(j).Value() = nota.Promedio
              End If
              Exit For
            End If
          Next
          j += 1
        Next
      Next
      For i As Integer = 0 To Me.dgNotas.RowCount - 1
        MostrarPromedio()
        estado = 1
        row += 1
      Next
      estado = 0
      row = 0
      codigoEstado = 1
      Me.btnAceptar.Text = "&Actualizar"
    Else
      codigoEstado = 0
      Me.btnAceptar.Text = "&Registrar"
    End If
    ln = Nothing
  End Sub

  Private Sub MostrarAlumnosGrupo()
    Dim obj As New RNMatricula
    Dim lm As List(Of Matricula)

    lm = obj.ListarAlumnosGrupo(New DocenteCarga(CType(Me.cboCurso.SelectedItem, DocenteCarga).Codigo))
    If lm.Count > 0 Then
      Me.dgNotas.AutoGenerateColumns = False
      Me.dgNotas.DataSource = lm
      Me.dgNotas.Columns(0).DataPropertyName = "NroOrden"
      Me.dgNotas.Columns(1).DataPropertyName = "NombreAlumno"
      Me.txtTotal.Text = CStr(lm.Count)
    Else
      Me.txtTotal.Text = ""
    End If
    lm = Nothing
  End Sub

  Private Sub MostrarCapacidades()
    Dim obj As New RNCapacidad
    Dim col As DataGridViewTextBoxColumn = Nothing
    Dim k As Integer = 1

    lc = obj.ListarCapacidadesGrupo(New Curso(CType(Me.cboCurso.SelectedItem, DocenteCarga).Carga.Curso.Codigo))
    If lc.Count > 0 Then
      For Each cap As Capacidad In lc
        col = New DataGridViewTextBoxColumn
        col.Name = "cd" & cap.Nombre & CStr(cap.Codigo)
        col.HeaderText = "C" & k
        col.Width = 30
        col.MaxInputLength = 2
        col.ReadOnly = True
        col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgNotas.Columns.AddRange(col)
        k += 1
      Next
      col = New DataGridViewTextBoxColumn
      col.Name = "cdPromedio"
      col.HeaderText = "Promedio"
      col.Width = 60
      col.ReadOnly = True
      col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
      col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
      col.DefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Bold)
      Me.dgNotas.Columns.AddRange(col)
    End If
  End Sub

  Private Sub MostrarLeyenda()
    Dim obj As New RNCapacidad
    Dim k As Integer = 1
    Dim y As Integer = 0
    Dim cad As String = "C"

    LimpiarLeyenda()

    lc = obj.ListarCapacidadesGrupo(New Curso(CType(Me.cboCurso.SelectedItem, DocenteCarga).Carga.Curso.Codigo))
    nroCap = lc.Count

    If lc.Count > 0 Then
      For Each cap As Capacidad In lc
        control(k) = New Label()
        If Me.WindowState = FormWindowState.Maximized Then
          control(k).Location = New Point(827, 69 + y)
        Else
          control(k).Location = New Point(813, 69 + y)
        End If

        control(k).Name = "Cap" & k
        control(k).Size = New Size(190, 35)
        control(k).Text = cad & k & ":  " & cap.Nombre
        control(k).Font = New Font("Arial", 9, FontStyle.Bold)
        control(k).BackColor = Color.LightSteelBlue
        control(k).BorderStyle = BorderStyle.FixedSingle
        control(k).Visible = True
        control(k).Anchor = AnchorStyles.Bottom
        control(k).Anchor = AnchorStyles.Right
        Me.Controls.Add(control(k))
        k += 1
        y += 39
      Next
    End If
  End Sub

  Private Sub LimpiarLeyenda()
    If nroCap > 0 Then
      For i As Integer = 1 To nroCap
        Me.Controls.Remove(control(i))
        control(i).Dispose()
      Next
    End If
  End Sub

  Private Sub PintarCeldas()
    For i As Integer = 0 To Me.dgNotas.RowCount - 1
      Me.dgNotas.Rows(i).DefaultCellStyle.BackColor = Color.White
      i += 1
    Next
    For k As Integer = 0 To Me.dgNotas.RowCount - 1
      Me.dgNotas.Rows(k).Cells(Me.dgNotas.Columns.Count - 1).Style.BackColor = Color.White
    Next
  End Sub



  Private Sub dgNotas_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgNotas.CellValueChanged
    MostrarPromedio()
    BajarCelda()
  End Sub

  Private Sub MostrarPromedio()

    Dim nroCol As Integer = Me.dgNotas.ColumnCount - 3
    Dim pos As Integer = Me.dgNotas.Rows.IndexOf(Me.dgNotas.CurrentRow)
    Dim k As Integer
    Dim suma As Integer
    Dim prom As Double

    If estado = 1 Then
      pos = row
    End If

    For i As Integer = 2 To nroCol + 1
      If Me.dgNotas.Rows(pos).Cells(i).Value IsNot Nothing AndAlso Me.dgNotas.Rows(pos).Cells(i).Value.ToString <> "" _
      AndAlso CInt(Me.dgNotas.Rows(pos).Cells(i).Value) > 0 Then

        If CInt(Me.dgNotas.Rows(pos).Cells(i).Value) > 0 And CInt(Me.dgNotas.Rows(pos).Cells(i).Value) <= 10 Then
          Me.dgNotas.Rows(pos).Cells(i).Style.ForeColor = Color.Red
        ElseIf CInt(Me.dgNotas.Rows(pos).Cells(i).Value) >= 11 And CInt(Me.dgNotas.Rows(pos).Cells(i).Value) <= 20 Then
          Me.dgNotas.Rows(pos).Cells(i).Style.ForeColor = Color.Black
        End If
        k += 1
      End If
    Next

    If k = nroCol Then
      For i As Integer = 2 To nroCol + 1
        suma += CInt(Me.dgNotas.Rows(pos).Cells(i).Value)
      Next
      prom = suma / k
      Me.dgNotas.Rows(pos).Cells(Me.dgNotas.ColumnCount - 1).Value = Decimal.Round(CDec(prom), 2)
      Me.dgNotas.Rows(pos).Cells(Me.dgNotas.ColumnCount - 1).Style.BackColor = Color.SkyBlue

      If prom > 10.5 Then
        Me.dgNotas.Rows(pos).Cells(Me.dgNotas.ColumnCount - 1).Style.ForeColor = Color.Blue
      Else
        Me.dgNotas.Rows(pos).Cells(Me.dgNotas.ColumnCount - 1).Style.ForeColor = Color.Red
      End If
    Else
      If Me.dgNotas.RowCount > 0 Then
        Me.dgNotas.Rows(pos).Cells(Me.dgNotas.ColumnCount - 1).Value = ""
        Me.dgNotas.Rows(pos).Cells(Me.dgNotas.ColumnCount - 1).Style.BackColor = Color.White
      End If
    End If
  End Sub

  Private Sub BajarCelda()
    'If Me.dgNotas.RowCount > 0 Then
    '  Dim fil As Integer = Me.dgNotas.CurrentCell.RowIndex
    '  Dim col As Integer = Me.dgNotas.CurrentCell.ColumnIndex

    '  If fil < Me.dgNotas.RowCount - 1 Then
    '    If Me.dgNotas.CurrentCell.EditedFormattedValue.ToString <> "" Then
    '      Me.dgNotas.Item(col, fil + 1).Selected = True
    '      Me.dgNotas.Rows(fil + 1).Cells(col).Selected = True
    '    End If
    '  End If
    'End If
  End Sub

  Private Sub dgNotas_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgNotas.EditingControlShowing
    AddHandler e.Control.KeyPress, AddressOf ValidarIngreso
    RemoveHandler e.Control.KeyPress, AddressOf ValidarIngreso
  End Sub

  Private Sub ValidarIngreso(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    Dim celda As DataGridViewCell = dgNotas.CurrentCell()

    e.Handled = True
    If celda.ColumnIndex <> 0 And celda.ColumnIndex <> 1 Then
      If (Char.IsDigit(e.KeyChar) = True Or (e.KeyChar = ChrW(Keys.Back))) Then
        e.Handled = False
      Else
        MessageBox.Show("Sólo puede ingresar: Números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        e.Handled = True
      End If
    End If

  End Sub

  Private Sub dgNotas_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgNotas.CellValidating
    Dim numero As String
    Dim pos As Integer

    numero = e.FormattedValue.ToString()
    pos = Me.dgNotas.Rows.IndexOf(Me.dgNotas.CurrentRow)
    Try
      If dgNotas.CurrentCell.ColumnIndex > 1 Then

        If Not (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
          If CInt(numero) > 20 Then
            MessageBox.Show("No puede ingresar una nota mayor a 20", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = True
          ElseIf CInt(numero) <= 5 Then
            MessageBox.Show("No puede ingresar una nota igual o menor a 5", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = True
          ElseIf CInt(numero) >= 6 And CInt(numero) <= 20 Then

          End If
          'Else
          '  MessageBox.Show("Sólo puede ingresar números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          '  e.Cancel = True
          'End If

        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      e.Cancel = True
    End Try

  End Sub

  Private Sub VerificarNotas()
    For i As Integer = 0 To Me.dgNotas.RowCount - 1
      For j As Integer = 2 To Me.dgNotas.ColumnCount - 1
        If CStr(Me.dgNotas.Rows(i).Cells(j).EditedFormattedValue) <> "" Then
          If CInt(Me.dgNotas.Rows(i).Cells(j).EditedFormattedValue) < 6 Or CInt(Me.dgNotas.Rows(i).Cells(j).EditedFormattedValue) > 20 Then
            swNota = 1
            Exit For
          End If
        End If
      Next
      If swNota = 1 Then
        Exit For
      End If
    Next
  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    Dim sw As Integer
    Try
      VerificarNotas()
      If swNota = 0 Then
        For i As Integer = 0 To Me.dgNotas.RowCount - 1
          For j As Integer = 2 To Me.dgNotas.ColumnCount - 1
            If CStr(Me.dgNotas.Rows(i).Cells(j).EditedFormattedValue) <> "" Then
              sw = 1
              Exit For
            End If
          Next
          If sw = 1 Then
            Exit For
          End If
        Next

        If sw = 1 Then
          If MessageBox.Show("Desea registrar las notas", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            If codigoEstado = 0 Then

              RegistrarNotaCapacidad()
              If swError = 0 Then
                MessageBox.Show("Las notas se registraron con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
              End If

            Else

              RegistrarNuevaNota()
              If swError = 0 Then
                MessageBox.Show("Actualización de nota(s) realizada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
              End If

            End If
            Limpiar()
            codigoEstado = 1

            Me.dgNotas.Visible = False
            ListarAlumnos()
            Me.dgNotas.Visible = True
          End If
          swError = 0
        Else
          MessageBox.Show("No  realizó el ingreso de notas", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
      Else
        MessageBox.Show("Algunas notas ingresadas no estan entre 6 y 20", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        swNota = 0
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub RegistrarNotaCapacidad()
    Dim obj As New RNNotaCapacidad
    Dim prom As Double
    Dim nro, j As Integer
    'Dim u As Unidad
    Dim dc As DocenteCarga

    Try
      dc = CType(Me.cboCurso.SelectedItem, DocenteCarga)
      For i As Integer = 0 To Me.dgNotas.RowCount - 1
        j = 2
        nro = CType(Me.dgNotas.Rows(i).DataBoundItem, Matricula).Numero
        For Each cap As Capacidad In lc
          If CStr(Me.dgNotas.Rows(i).Cells(j).EditedFormattedValue) <> "" Then
            prom = CDbl(Me.dgNotas.Rows(i).Cells(j).EditedFormattedValue)
            If prom >= 6 And prom <= 20 Then
              obj.Registrar(New NotaCapacidad(0, prom, Now, True, New Matricula(nro), New PeriodoAcademico(mOPeriodoActual.Codigo), New Personal(mOUsuario.Persona.Codigo), New Capacidad(cap.Codigo), New Unidad(unidad, "", False, New PeriodoAcademico(), New DocenteCarga(dc.Codigo))))
            Else
              'MessageBox.Show () 
              Me.dgNotas.Rows(i).Cells(j).Value = ""
            End If
          End If
          j += 1
        Next
      Next
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      swError = 1
    End Try
  End Sub

  Private Sub RegistrarNuevaNota()
    Dim obj As New RNNotaCapacidad
    Dim prom As Double
    Dim nro, j As Integer
    'Dim u As Unidad
    Dim dc As DocenteCarga
    Dim nota As NotaCapacidad

    'u = CType(Me.cboNro.SelectedItem, Unidad)
    Try
      dc = CType(Me.cboCurso.SelectedItem, DocenteCarga)
      For i As Integer = 0 To Me.dgNotas.RowCount - 1
        j = 2
        nro = CType(Me.dgNotas.Rows(i).DataBoundItem, Matricula).Numero
        For Each cap As Capacidad In lc
          If Me.dgNotas.Rows(i).Cells(j).EditedFormattedValue.ToString <> "" Then
            prom = CDbl(Me.dgNotas.Rows(i).Cells(j).EditedFormattedValue)
            nota = obj.LeerNota(New NotaCapacidad(New Unidad(unidad, "", True, _
                  New PeriodoAcademico(mOPeriodoActual.Codigo), New DocenteCarga(dc.Codigo)), New Capacidad(cap.Codigo), _
                  New Matricula(nro)))
            If nota Is Nothing Then
              If prom >= 6 And prom <= 20 Then
                obj.Registrar(New NotaCapacidad(0, prom, Now, True, New Matricula(nro), _
                                        New PeriodoAcademico(mOPeriodoActual.Codigo), _
                                        New Personal(mOUsuario.Persona.Codigo), _
                                        New Capacidad(cap.Codigo), New Unidad(unidad, "", _
                                        False, New PeriodoAcademico(), _
                                        New DocenteCarga(dc.Codigo))))
              Else
                Me.dgNotas.Rows(i).Cells(j).Value = ""
              End If
            Else
              If prom <> nota.Promedio Then
                If prom >= 6 And prom <= 20 Then
                  obj.RegistrarNuevaNota(New NotaCapacidad(nota.Codigo, prom, Now, True, New Matricula(), New PeriodoAcademico(), New Personal(mOUsuario.Persona.Codigo), New Capacidad(), New Unidad()), New Personal(mOUsuario.Persona.Codigo))
                End If
              End If
            End If
          End If
          j += 1
        Next
      Next
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      swError = 1
    End Try

  End Sub

  Private Sub frmNotasSecundaria_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    If MessageBox.Show("¿Está seguro que desea cerrar la ventana?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
      e.Cancel = True
    End If
  End Sub

  Private Sub dgNotas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgNotas.KeyDown

    If dgNotas.CurrentCell.ColumnIndex > 1 AndAlso dgNotas.CurrentCell.ColumnIndex < dgNotas.ColumnCount - 1 Then
      If e.KeyCode = Keys.Delete AndAlso dgNotas.CurrentCell.IsInEditMode = False Then
        dgNotas.CurrentCell.Value = ""
      End If
    End If

  End Sub

  Private Sub cboDocente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDocente.SelectedIndexChanged
    If Me.cboDocente.SelectedIndex > -1 Then
      codigoUsu = CType(Me.cboDocente.SelectedItem, Docente).Codigo
      MostrarCursos()
    End If
  End Sub
End Class