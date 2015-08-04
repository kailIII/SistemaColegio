Public Class frmRegistroNotasIndicadores

  Private Ldc As New List(Of DocenteCarga)
  Private LInd As New List(Of Indicador)
  Private LMI As New List(Of MatriculaIndicador)
  Private LPPC As New List(Of PromedioPeriodoCurso)

  Private contador As Integer = 0
  Private codigoEstado As Integer = 0
  Private EstadoProm As Integer = 0
  Private vector(100) As Integer
  Private swErr As Integer = 0


  Private Sub frmRegistroNotasIndicadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btncancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")

    MostrarDocentes()
    Me.txtPeriodo.Text = moAnioActual.Anio & "    -    " & mOPeriodoActual.Nombre

    txtNombre.Text = ""
  End Sub

  Private Sub LimpiarVector()
    For i As Integer = 0 To 99
      vector(i) = 0
    Next
  End Sub

  Private Sub MostrarDocentes()
    Dim objRN As New RNDocente
    Dim ld As List(Of Docente) = Nothing

    ld = objRN.ListarDocentesInicialPrimaria(mOPeriodoActual)
    If ld.Count > 0 Then
      cboDocente.DisplayMember = "NombreCompleto"
      cboDocente.ValueMember = "Codigo"
      cboDocente.DataSource = ld
    Else
      cboDocente.DataSource = Nothing
    End If
  End Sub

  Private Sub Validar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    'Validar Fila seleccionada
    Dim drwFila As DataGridViewCell = dgvNotas.CurrentCell()

    If drwFila.ColumnIndex > 1 And drwFila.ColumnIndex <> dgvNotas.ColumnCount - 1 Then
      e.KeyChar = UCase(e.KeyChar)
      If (e.KeyChar = ChrW(Keys.A)) Or (e.KeyChar = ChrW(Keys.B)) Or (e.KeyChar = ChrW(Keys.C)) Or (e.KeyChar = ChrW(Keys.D)) Or _
           (e.KeyChar = ChrW(Keys.Back)) Then
        e.Handled = False
      Else
        MessageBox.Show("Sólo puede ingresar: A,B,C,D,AD", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        e.Handled = True
      End If
    End If

    'VerificarCeldaProm(e)

  End Sub
  Private Sub VerificarCeldaProm(ByVal e As System.Windows.Forms.KeyPressEventArgs)
    Dim nroCol As Integer = Me.dgvNotas.ColumnCount - 4
    Dim pos As Integer = Me.dgvNotas.Rows.IndexOf(Me.dgvNotas.CurrentRow)
    Dim k As Integer
    If dgvNotas.CurrentCell.ColumnIndex = dgvNotas.ColumnCount - 2 Then
      For i As Integer = 2 To nroCol + 1
        If dgvNotas.Rows(pos).Cells(i).Value() IsNot Nothing Then
          k += 1
        End If
      Next
      If Not (k = nroCol) Then
        Me.dgvNotas.Rows(pos).Cells(Me.dgvNotas.ColumnCount - 2).Style.BackColor = Color.Red
        e.Handled = True
      Else
        Me.dgvNotas.Rows(pos).Cells(Me.dgvNotas.ColumnCount - 2).Style.BackColor = Color.Green
      End If
    End If
  End Sub

  Private Sub dgvAlumNotas_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvNotas.CellValidating
    Dim letra As String = ""
    letra = e.FormattedValue.ToString().ToUpper

    If dgvNotas.CurrentCell.ColumnIndex > 1 And dgvNotas.CurrentCell.ColumnIndex <> dgvNotas.ColumnCount - 1 Then
      If Not (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
        If Not (letra = "A" Or letra = "B" Or letra = "C" Or letra = "D" Or letra = "AD") Then
          MessageBox.Show("Sólo puede ingresar: A,B,C,D,AD", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
          e.Cancel = True
        End If
      End If
    End If
  End Sub
  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub
  Private Sub dgvAlumNotas_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvNotas.EditingControlShowing
    Dim combo As ComboBox = Nothing

    AddHandler e.Control.KeyPress, AddressOf Validar
    RemoveHandler e.Control.KeyPress, AddressOf Validar

    If TypeOf (e.Control) Is ComboBox Then
      combo = CType(e.Control, ComboBox)

      RemoveHandler combo.SelectedIndexChanged, New EventHandler(AddressOf dgvNotas_SelectedIndexChanged)
      AddHandler combo.SelectedIndexChanged, New EventHandler(AddressOf dgvNotas_SelectedIndexChanged)
      'creo el evento selectedindexchanged
    End If
  End Sub
  Private Sub MostrarAlumnosGrupo()
    Dim obj As New RNMatricula
    Dim lm As List(Of Matricula)
    lm = obj.ListarAlumnosGrupo(New DocenteCarga(CType(Me.cboCurso.SelectedItem, DocenteCarga).Codigo))
    If lm.Count > 0 Then
      Me.dgvNotas.AutoGenerateColumns = False
      Me.dgvNotas.DataSource = lm
      Me.dgvNotas.Columns(0).DataPropertyName = "NroOrden"
      Me.dgvNotas.Columns(1).DataPropertyName = "NombreAlumno"
      Me.txtTotal.Text = lm.Count.ToString
    Else
      Me.txtTotal.Text = lm.Count.ToString
    End If
    lm = Nothing

  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Listar()
  End Sub

  Private Sub Listar()
    If Me.cboCurso.SelectedIndex > -1 Then
      LimpiarAlumnos()
      If MostrarIndicadores() Then
        MostrarAlumnosGrupo()
        LlenarcolEstado()
        LimpiarVector()
        ListarNotas()

        Me.dgvNotas.ClearSelection()
      Else
        Limpiar()
      End If
    Else
      MessageBox.Show("Seleccione Nivel - Grado - Sección - Curso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If

    Me.WindowState = FormWindowState.Maximized
  End Sub

  Private Function MostrarIndicadores() As Boolean
    Dim obj As New RNIndicador
    Dim col As DataGridViewTextBoxColumn = Nothing
    Dim colProm As DataGridViewTextBoxColumn = Nothing
    Dim colNivelEsf As DataGridViewComboBoxColumn = Nothing

    Dim i As Integer = 0
    Dim rpta As Boolean = False
    LInd = obj.ListarIndicadoresGrupo(New DocenteCarga(CType(Me.cboCurso.SelectedItem, DocenteCarga).Codigo, Nothing, mOPeriodoActual))

    If LInd.Count > 0 Then


      For Each ind As Indicador In LInd
        i += 1
        col = New DataGridViewTextBoxColumn
        'col.Name = "cd" & CStr(ind.Codigo)
        'col.HeaderText = "IND " & i.ToString

        col.Name = "cd" & CStr(ind.Codigo)
        col.HeaderText = "IND " & ind.Nro

        If mOPeriodoActual.Cerrado Then
          col.ReadOnly = True
        End If

        col.ToolTipText = ind.Nombre
        col.Width = 28
        col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        col.MaxInputLength = 2
        Me.dgvNotas.Columns.AddRange(col)


      Next

      colProm = New DataGridViewTextBoxColumn
      colProm.Name = "cdPromedio"
      colProm.HeaderText = "PROM"
      If mOPeriodoActual.Cerrado Then
        colProm.ReadOnly = True
      End If

      colProm.Width = 40
      colProm.MaxInputLength = 2
      colProm.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
      colProm.DefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Bold)

      Me.dgvNotas.Columns.AddRange(colProm)

      colNivelEsf = New DataGridViewComboBoxColumn
      colNivelEsf.Name = "cdNivelEsfuerzo"
      If mOPeriodoActual.Cerrado Then
        colNivelEsf.ReadOnly = True
      End If

      colNivelEsf.HeaderText = "Nivel Esfuerzo"
      colNivelEsf.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton

      colNivelEsf.Width = 80
      colNivelEsf.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
      colNivelEsf.DefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Bold)
      Me.dgvNotas.Columns.AddRange(colNivelEsf)

      contador = dgvNotas.Columns.Count - 1

      rpta = True
    End If
    Return rpta
  End Function
  Public Sub LlenarcolEstado()
    Dim column As DataGridViewComboBoxColumn = DirectCast(Me.dgvNotas.Columns("cdNivelEsfuerzo"), DataGridViewComboBoxColumn)
    Dim ListEstado As New List(Of PromedioPeriodoCurso)
    ListEstado = LlenarEstado()
    With column
      .DataPropertyName = "NivelEsfuerzo"
      .DisplayMember = "NombreNivelEsfuerzo"
      .DataSource = ListEstado

    End With

    column = Nothing
    ListEstado = Nothing
  End Sub
  Public Function LlenarEstado() As List(Of PromedioPeriodoCurso)
    Dim obj As New RNPromedioPeriodoCurso
    Dim list As New List(Of PromedioPeriodoCurso)
    list = obj.ListarEstado
    obj = Nothing
    Return list
  End Function

  Private Sub dgvAlumNotas_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvNotas.CellClick, dgvNotas.CellEnter
    MostrarPromedio()
    If dgvNotas.CurrentCell.ColumnIndex > 1 And dgvNotas.CurrentCell.ColumnIndex <> dgvNotas.ColumnCount - 1 And e.ColumnIndex > -1 Then
      txtNombre.Text = dgvNotas.Columns.Item(e.ColumnIndex).ToolTipText
    Else
      txtNombre.Text = ""
    End If

  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub
  Private Sub txtPeriodo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPeriodo.Enter
    cboCurso.Focus()
  End Sub
  Private Sub ListarNotas()
    Dim obj As New RNMatriculaIndicador
    Dim objProm As New RNPromedioPeriodoCurso
    Dim j As Integer

    LMI = obj.ListarNotas(New Indicador(Nothing, Nothing, Nothing, mOPeriodoActual.Codigo, _
                            CType(Me.cboCurso.SelectedItem, DocenteCarga).Codigo, 0))

    LPPC = objProm.ListarPromIndicadores(New PromedioPeriodoCurso(Nothing, CType(Me.cboCurso.SelectedItem, DocenteCarga).Codigo, _
                                          Nothing, mOPeriodoActual.Codigo, Nothing, Nothing, Nothing))



    If LMI.Count > 0 Then
      For i As Integer = 0 To Me.dgvNotas.RowCount - 1
        j = 2
        For Each Ind As Indicador In LInd
          For Each nota As MatriculaIndicador In LMI
            If CType(Me.dgvNotas.Rows(i).DataBoundItem, Matricula).Numero = nota.Matricula.Numero _
                And Ind.Codigo = nota.CodIndicador Then
              dgvNotas.Rows(i).Cells("cd" & Ind.Codigo).Value() = nota.Letra.Trim
              j += 1
              Exit For
            End If
          Next
        Next
      Next
      Me.btnRegistrar.Text = "&Actualizar"
      codigoEstado = 1
    End If

    If LPPC.Count > 0 Then
      For i As Integer = 0 To Me.dgvNotas.RowCount - 1
        j = contador
        For Each Prom As PromedioPeriodoCurso In LPPC
          If CType(Me.dgvNotas.Rows(i).DataBoundItem, Matricula).Numero = Prom.NroMatricula Then
            Me.dgvNotas.Rows(i).Cells(j - 1).Value() = Prom.Letra.Trim
            vector(i) = Prom.Codigo
            Me.dgvNotas.Rows(i).Cells(j - 1).Style.BackColor = Color.Yellow
            Me.dgvNotas.Rows(i).Cells("cdNivelEsfuerzo").Value() = Prom.NombreNivelEsfuerzo
            Me.dgvNotas.Rows(i).Cells(j - 1).Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            j += 1
            Exit For

          End If
        Next
      Next
      EstadoProm = 1
    Else
      dgvNotas.Rows(0).Cells("cdPromedio").Style.BackColor = Color.White
    End If

    LMI = Nothing
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click

    If Me.dgvNotas.Rows.Count > 0 Then
      If MessageBox.Show("Desea registrar las notas", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

        If codigoEstado = 0 Then

          RegistrarNotaIndicador()
          RegistrarPromIndicador()
          If swErr = 0 Then
            MessageBox.Show("Las notas se registraron con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          End If
          'Limpiar()
          Listar()
        Else
          RegistrarNuevaNota()
          RegistrarNuevaPromInd()
          If swErr = 0 Then
            MessageBox.Show("Actualización realizada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          End If
          'Limpiar()
          Listar()
        End If
      End If
    Else
      Limpiar()
      MessageBox.Show("No ha ingresado notas", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End If
  End Sub
  Private Sub Limpiar()
    Me.cboCurso.SelectedIndex = -1
    LimpiarAlumnos()
    codigoEstado = 0
    txtNombre.Text = ""
    Me.btnRegistrar.Text = "&Guardar"
  End Sub

  Private Sub LimpiarAlumnos()
    Me.dgvNotas.ClearSelection()
    Try
      Me.dgvNotas.DataSource = Nothing
      Me.dgvNotas.Rows.Clear()
      While Me.dgvNotas.Columns.Count > 2
        For i As Integer = 2 To Me.dgvNotas.Columns.Count - 1
          Me.dgvNotas.Columns.RemoveAt(i)
          Exit For
        Next
      End While
      Me.txtTotal.Text = ""
      Me.txtNombre.Text = ""

    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try
  End Sub
  Private Sub RegistrarNotaIndicador()
    Dim obj As New RNMatriculaIndicador
    Dim letra As String
    Dim nroMat, j As Integer
    Dim dc As DocenteCarga

    Try
      dc = CType(Me.cboCurso.SelectedItem, DocenteCarga)
      For i As Integer = 0 To Me.dgvNotas.RowCount - 1
        j = 2
        nroMat = CType(Me.dgvNotas.Rows(i).DataBoundItem, Matricula).Numero
        For Each Ind As Indicador In LInd
          If CStr(Me.dgvNotas.Rows(i).Cells(j).EditedFormattedValue) <> "" Then
            letra = Me.dgvNotas.Rows(i).Cells(j).Value.ToString
            obj.Registrar(New MatriculaIndicador(New Matricula(nroMat), 0, letra, Now, True, Ind.Codigo, mOUsuario.Persona.Codigo, 0, 0))
          End If
          j += 1
        Next
      Next
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      swErr = 1
    End Try
  End Sub

  Private Sub RegistrarPromIndicador()
    Dim obj As New RNPromedioPeriodoCurso
    Dim letra, NivelEsf As String
    Dim nroMat, j As Integer
    Dim dc As DocenteCarga

    Try
      'If dgvNotas.CurrentCell.ColumnIndex = dgvNotas.ColumnCount - 1 Then
      dc = CType(Me.cboCurso.SelectedItem, DocenteCarga)
      For i As Integer = 0 To Me.dgvNotas.RowCount - 1
        j = contador
        nroMat = CType(Me.dgvNotas.Rows(i).DataBoundItem, Matricula).Numero
        If CStr(Me.dgvNotas.Rows(i).Cells(j - 1).EditedFormattedValue) <> "" Then
          letra = Me.dgvNotas.Rows(i).Cells(j - 1).Value.ToString
          NivelEsf = Me.dgvNotas.Rows(i).Cells("cdNivelEsfuerzo").Value.ToString.Chars(0)

          obj.Registrar(New PromedioPeriodoCurso(Nothing, dc.Codigo, nroMat, mOPeriodoActual.Codigo, _
                                                 mOUsuario.Persona.Codigo, letra, NivelEsf))
        End If
        j += 1
      Next
      'End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      swErr = 1
    End Try
  End Sub

  Private Sub RegistrarNuevaNota()
    Dim obj As New RNMatriculaIndicador
    Dim Letra As String
    Dim NroMat, j As Integer
    Dim dc As DocenteCarga
    Dim nota As MatriculaIndicador

    Try

      dc = CType(Me.cboCurso.SelectedItem, DocenteCarga)
      For i As Integer = 0 To Me.dgvNotas.RowCount - 1
        j = 2
        NroMat = CType(Me.dgvNotas.Rows(i).DataBoundItem, Matricula).Numero

        For Each ind As Indicador In LInd
          If Me.dgvNotas.Rows(i).Cells(j).EditedFormattedValue.ToString <> "" Then
            Letra = (Me.dgvNotas.Rows(i).Cells(j).EditedFormattedValue).ToString
            nota = obj.LeerNota(New MatriculaIndicador(NroMat, ind.Codigo))
            If nota Is Nothing Then
              obj.Registrar(New MatriculaIndicador(New Matricula(NroMat), 0, Letra, Now, True, ind.Codigo, mOUsuario.Persona.Codigo, 0, 0))
            Else
              If Letra.Trim <> nota.Letra.Trim Then
                obj.RegistrarNuevaNotaIndicador(New MatriculaIndicador(New Matricula(NroMat), nota.Numero, Letra, Now, True, ind.Codigo, mOUsuario.Persona.Codigo, 0, 0))
              End If
            End If
          End If

          j += 1
        Next
      Next
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      swErr = 1
    End Try

  End Sub

  Private Sub RegistrarNuevaPromInd()
    Dim obj As New RNPromedioPeriodoCurso
    Dim promTri As String = ""
    Dim NivelEsf As String = ""
    Dim NroMat, j As Integer
    Dim dc As DocenteCarga = Nothing
    Dim nota As PromedioPeriodoCurso = Nothing
    Try

      dc = CType(Me.cboCurso.SelectedItem, DocenteCarga)
      For i As Integer = 0 To Me.dgvNotas.RowCount - 1
        j = contador

        NroMat = CType(Me.dgvNotas.Rows(i).DataBoundItem, Matricula).Numero
        If Me.dgvNotas.Rows(i).Cells("cdNivelEsfuerzo").EditedFormattedValue.ToString <> "" Then
          NivelEsf = Me.dgvNotas.Rows(i).Cells("cdNivelEsfuerzo").EditedFormattedValue.ToString.Chars(0)
        Else
          NivelEsf = ""
        End If
        If CStr(dgvNotas.Rows(i).Cells(j - 1).EditedFormattedValue) <> "" Or NivelEsf <> "" Then
          promTri = Me.dgvNotas.Rows(i).Cells(j - 1).EditedFormattedValue.ToString
          nota = obj.LeerPromInd(New PromedioPeriodoCurso(vector(i), NroMat, mOPeriodoActual.Codigo, promTri, NivelEsf))

          If nota Is Nothing Then
            obj.Registrar(New PromedioPeriodoCurso(Nothing, dc.Codigo, NroMat, mOPeriodoActual.Codigo, _
                                                   mOUsuario.Persona.Codigo, promTri, NivelEsf))
          Else
            If promTri.Trim <> nota.Letra.Trim Or NivelEsf <> nota.NivelEsfuerzo Then
              obj.RegistrarNuevaPromInd(New PromedioPeriodoCurso(nota.Codigo, dc.Codigo, Nothing, Nothing, mOUsuario.Persona.Codigo, _
                                                                 promTri, NivelEsf))
            End If
          End If
        End If
        j += 1
      Next

    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      swErr = 1
    End Try

  End Sub


  Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
    Limpiar()
  End Sub

  Private Sub cboCurso_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCurso.SelectedIndexChanged
    If Me.cboCurso.SelectedIndex > -1 Then
      LimpiarAlumnos()
      codigoEstado = 0
      Me.btnRegistrar.Text = "&Guardar"
    End If
  End Sub

  'Private Sub dgvNotas_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvNotas.CellValueChanged
  '  VerificarCeldaProm(e)
  'End Sub

  Private Sub frmRegistroNotasIndicadores_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    If MessageBox.Show("¿Está seguro que desea cerrar la ventana?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
      e.Cancel = True
    Else
      Colegio.IDirectorNivel.frmPrincipal.Visible = True
    End If
  End Sub

  Private Sub dgvNotas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvNotas.KeyDown

    If dgvNotas.CurrentCell IsNot Nothing Then
      With dgvNotas.CurrentCell
        If .ColumnIndex > 1 Then
          If e.KeyCode = Keys.Delete Then
            dgvNotas.CurrentCell.Value = Nothing
          End If
        End If
      End With
    End If
  End Sub

  Private Sub dgvNotas_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvNotas.CellValueChanged
    MostrarPromedio()
  End Sub
  Private Sub MostrarPromedio()
    Dim nroCol As Integer = 0
    Dim pos As Integer = -1
    Dim k As Integer = 0

    Try
      nroCol = Me.dgvNotas.ColumnCount - 4
      pos = Me.dgvNotas.Rows.IndexOf(Me.dgvNotas.CurrentRow)
      For i As Integer = 2 To nroCol + 1
        If dgvNotas.Rows(pos).Cells(i).Value IsNot Nothing Then
          k += 1
        End If
      Next

      If Not (k = nroCol) Then
        If Me.dgvNotas.RowCount > 0 Then

          Me.dgvNotas.Rows(pos).Cells(Me.dgvNotas.ColumnCount - 2).Style.BackColor = Color.White
          Me.dgvNotas.Rows(pos).Cells(Me.dgvNotas.ColumnCount - 2).Value = ""
          If Me.dgvNotas.Rows(pos).Cells(Me.dgvNotas.ColumnCount - 2).EditedFormattedValue.ToString = "" Then
            Me.dgvNotas.Rows(pos).Cells(Me.dgvNotas.ColumnCount - 1).Value = ""
          End If
        End If
      Else
        If Me.dgvNotas.Rows(pos).Cells(Me.dgvNotas.ColumnCount - 2).EditedFormattedValue.ToString = "" Then
          Me.dgvNotas.Rows(pos).Cells(Me.dgvNotas.ColumnCount - 1).Value = ""
        End If
        Me.dgvNotas.Rows(pos).Cells(Me.dgvNotas.ColumnCount - 2).Style.BackColor = Color.Yellow
        'Me.dgvNotas.Rows(pos).Cells(Me.dgvNotas.ColumnCount - 2).ReadOnly = False
        'Me.dgvNotas.Rows(pos).Cells(Me.dgvNotas.ColumnCount - 1).ReadOnly = False
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Question)
    End Try

  End Sub

  Private Sub dgvNotas_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
    Dim cmb As ComboBox = CType(sender, ComboBox)
    Dim selectedIndex As Integer = cmb.SelectedIndex
    Dim str As String = ""

    Try
      If selectedIndex >= 0 Then
        str = cmb.Text.Trim

        If str = "ALTO" Or str = "MEDIO" Or str = "BAJO" Then
          Me.dgvNotas.CurrentRow.Cells(Me.dgvNotas.CurrentCell.ColumnIndex).Value = cmb.Text
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub cboDocente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDocente.SelectedIndexChanged
    If Me.cboDocente.SelectedIndex > -1 Then
      Dim codigoUsu = CType(Me.cboDocente.SelectedItem, Docente).Codigo

      MostrarCursos(codigoUsu)
    End If
  End Sub
  Private Sub MostrarCursos(ByVal codDocente As Integer)
    Dim objRN As New RNDocenteCarga

    Ldc = objRN.ListarCargaSeccion(mOPeriodoActual, New Docente(codDocente)) 'mOUsuario.Persona.Codigo
    If Ldc.Count > 0 Then
      cboCurso.DisplayMember = "CursoSeccion"
      cboCurso.ValueMember = "Codigo"
      cboCurso.DataSource = Ldc
    Else
      cboCurso.DataSource = Nothing
    End If
  End Sub

End Class