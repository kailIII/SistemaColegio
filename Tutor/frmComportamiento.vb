
Public Class frmComportamiento

  Private ls As List(Of Seccion)
  Private lv As List(Of Virtud) = Nothing
  Private codVirtudes(50) As Integer
  Private estadoEva As String
  Private estado As Integer = 0
  Private rows As Integer = 0
  Private codNotas(100, 20) As Integer
  Private codNotasText(100, 20) As String

  Private Sub frmComportamiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    MostrarAnioPeriodo()
    MostrarSeccion()
    MostrarImagenes()
    InicializarCodNotas()
    Me.cboSeccion.SelectedIndex = 0
    Listar()
  End Sub

  Public Sub Gestion()
    If moAnioActual IsNot Nothing AndAlso mOPeriodoActual IsNot Nothing Then
      Me.ShowDialog()
    ElseIf moAnioActual Is Nothing Then
      MessageBox.Show("No se ha seleccionado el año académico", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Else
      MessageBox.Show("No se ha seleccionado el periodo académico", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If

  End Sub

  Private Sub InicializarCodNotas()
    For i As Integer = 0 To 100
      For j As Integer = 0 To 20
        codNotas(i, j) = 0
        codNotasText(i, j) = ""
      Next
    Next
  End Sub

  Private Sub MostrarAnioPeriodo()
    Me.txtPeriodo.Text = moAnioActual.Anio & "    -    " & mOPeriodoActual.Nombre
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub MostrarSeccion()
    Dim obj As New RNSeccion

    ls = obj.ListarSeccionTutor(New Seccion(moAnioActual, New Grado(), Nothing, New Docente(mOUsuario.Persona.Codigo)))
    obj = Nothing
    If ls.Count > 0 Then
      cboSeccion.DisplayMember = "NivelNumeroLetra2"
      cboSeccion.ValueMember = "NivelNumeroLetra2"
      cboSeccion.DataSource = ls
    End If
  End Sub

  Private Sub MostrarImagenes()
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Listar()
  End Sub

  Private Sub Listar()
    If Me.cboSeccion.SelectedIndex > -1 Then
      Me.dgAlumnos.Visible = False
      LimpiarColumnas()
      Me.dgAlumnos.Visible = True
      MostrarAlumnosSeccion()
      MostrarVirtudes()
      estadoEva = CType(Me.cboSeccion.SelectedItem, Seccion).Grado.TipoEval
      ListarNotasComportamiento()
    Else
      MessageBox.Show("Seleccione sección", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
  End Sub

  Private Sub MostrarAlumnosSeccion()
    Dim obj As New RNMatricula
    Dim lm As List(Of Matricula)

    lm = obj.ListarAlumno(New Seccion(moAnioActual, New Grado(CType(Me.cboSeccion.SelectedItem, Seccion).Grado.Codigo) _
                                  , CType(Me.cboSeccion.SelectedItem, Seccion).Letra))
    If lm.Count > 0 Then
      Me.dgAlumnos.AutoGenerateColumns = False
      Me.dgAlumnos.DataSource = lm
      Me.dgAlumnos.Columns(0).DataPropertyName = "NroOrden"
      Me.dgAlumnos.Columns(1).DataPropertyName = "NombreAlumno"
    End If
    lm = Nothing
  End Sub

  Private Sub MostrarVirtudes()
    Dim obj As New RNVirtud
    Dim col As DataGridViewComboBoxColumn = Nothing
    Dim col2 As DataGridViewTextBoxColumn = Nothing
    Dim k As Integer = 2
    Dim sw As Integer = 0

    lv = obj.ListarVirtudesPeriodo(New Virtud(0, "", True, moAnioActual _
                  , mOPeriodoActual, New Nivel(CType(Me.cboSeccion.SelectedItem, Seccion).Grado.CodigoNivel), 0))
    If lv.Count > 0 Then
      LimpiarCodVirtudes() ''inicializar el vector de codigos de virtud
      For Each virtud As Virtud In lv
        col = New DataGridViewComboBoxColumn
        col.Name = "cd" & virtud.Nombre & CStr(virtud.Codigo)
        col.HeaderText = virtud.Nombre
        col.Width = 120
        col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgAlumnos.Columns.AddRange(col)
        If CType(Me.cboSeccion.SelectedItem, Seccion).Grado.TipoEval.Trim = "N" Then
          sw = 1
        End If
        codVirtudes(k) = virtud.Codigo  ''desde la posicion 2 donde van las virtudes
        k += 1
        LlenarColumnas(col.Name)
      Next

      If sw = 1 Then
        col2 = New DataGridViewTextBoxColumn
        col2.Name = "cdAcumulado"
        col2.HeaderText = "Suma"
        col2.Width = 50
        col2.ReadOnly = True
        col2.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        col2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        col2.DefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Bold)
        Me.dgAlumnos.Columns.AddRange(col2)
      End If
    End If

  End Sub

  Private Sub ListarNotasComportamiento()
    Dim obj As RNNotaComportamiento
    Dim obj2 As RNEquivalencia

    Dim nota As NotaComportamiento = Nothing
    Dim le As List(Of Equivalencia) = Nothing
    Dim cadena As String = ""
    Dim k As Integer = 0
    Dim nro As Integer

    If Me.dgAlumnos.RowCount > 0 Then
      obj = New RNNotaComportamiento
      obj2 = New RNEquivalencia

      le = obj2.ListarEquivalencias()
      For i As Integer = 0 To Me.dgAlumnos.RowCount - 1
        k = 2
        nro = CType(Me.dgAlumnos.Rows(i).DataBoundItem, Matricula).Numero
        For Each v As Virtud In lv
          nota = obj.NotaComport(New NotaComportamiento(mOPeriodoActual _
                  , New Matricula(nro), v))
          If nota IsNot Nothing Then
            Me.dgAlumnos.Rows(i).Cells(k).Value = RetornaCadena(nota.Puntos, nota.Letra, le)
            codNotas(i, k) = nota.Codigo '''''para guardar todos los codigos de las notas de cada alumno
            codNotasText(i, k) = Me.dgAlumnos.Rows(i).Cells(k).EditedFormattedValue.ToString

            If estadoEva = "N" Then
              estado = 1
              MostrarAcumulado()
              rows = i
            End If
          End If
          k += 1
        Next
        estado = 0
        rows = 0
      Next
    End If

  End Sub

  Public Function RetornaCadena(ByVal puntos As Integer, ByVal letra As String, ByVal le As List(Of Equivalencia)) As String
    Dim cadena As String = ""

    For Each e As Equivalencia In le
      If estadoEva = "N" Then
        If e.Puntos = puntos Then
          cadena = e.Puntos & " - " & e.Literal
          Exit For
        End If
      Else
        If e.Literal.Chars(0) = letra Then
          cadena = e.Puntos & " - " & e.Literal
          Exit For
        End If
      End If
    Next

    Return cadena
  End Function


  Private Sub LimpiarCodVirtudes()
    For i As Integer = 0 To 50
      codVirtudes(i) = 0
    Next
  End Sub

  Private Sub LimpiarColumnas()
    Me.dgAlumnos.ClearSelection()
    Try
      Me.dgAlumnos.DataSource = Nothing
      Me.dgAlumnos.Rows.Clear()
      While Me.dgAlumnos.Columns.Count > 2
        For i As Integer = 2 To Me.dgAlumnos.Columns.Count - 1
          Me.dgAlumnos.Columns.RemoveAt(i)
          Exit For
        Next
      End While
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try
  End Sub

  Private Sub LlenarColumnas(ByVal name As String)
    Dim column As DataGridViewComboBoxColumn = DirectCast(Me.dgAlumnos.Columns(name), DataGridViewComboBoxColumn)
    Dim Le As New List(Of Equivalencia)
    Dim obj As New RNEquivalencia

    Le = obj.ListarEquivalencias()
    With column
      .DataPropertyName = "LeerEquivalencia"
      .DisplayMember = "LeerEquivalencia"
      .DataSource = Le
    End With
    column = Nothing
    Le = Nothing
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    'If MessageBox.Show("Ya guardo las notas si es que realizó algún cambio, sino luego tendra que volver a ingresarlas", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    LimpiarColumnas()
    Me.cboSeccion.SelectedIndex = -1
    'End If
  End Sub

  Private Sub dgAlumnos_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgAlumnos.CellValueChanged
    If Me.cboSeccion.SelectedIndex > -1 Then
      If CType(Me.cboSeccion.SelectedItem, Seccion).Grado.TipoEval.Trim = "N" Then
        MostrarAcumulado()
      End If
    End If
  End Sub

  Private Sub MostrarAcumulado()
    Dim nroCol As Integer = Me.dgAlumnos.ColumnCount - 3
    Dim pos As Integer = Me.dgAlumnos.Rows.IndexOf(Me.dgAlumnos.CurrentRow)
    Dim k As Integer
    Dim suma As Integer
    Dim puntos As String

    If estado = 1 Then
      pos = rows
    End If

    For i As Integer = 2 To nroCol + 1
      If Me.dgAlumnos.Rows(pos).Cells(i).EditedFormattedValue.ToString <> "" Then
        k += 1
      End If
    Next

    If k = nroCol Then
      For i As Integer = 2 To nroCol + 1
        puntos = Me.dgAlumnos.Rows(pos).Cells(i).EditedFormattedValue.ToString.Chars(0)
        suma += CInt(puntos)
      Next
      Me.dgAlumnos.Rows(pos).Cells(Me.dgAlumnos.ColumnCount - 1).Value = suma
      Me.dgAlumnos.Rows(pos).Cells(Me.dgAlumnos.ColumnCount - 1).Style.BackColor = Color.SkyBlue
      Me.dgAlumnos.Rows(pos).Cells(Me.dgAlumnos.ColumnCount - 1).Style.ForeColor = Color.Black
    Else
      If Me.dgAlumnos.RowCount > 0 Then
        Me.dgAlumnos.Rows(pos).Cells(Me.dgAlumnos.ColumnCount - 1).Value = ""
        Me.dgAlumnos.Rows(pos).Cells(Me.dgAlumnos.ColumnCount - 1).Style.BackColor = Color.White
      End If
    End If
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim sw As Integer = 0
    Dim k, nro As Integer

    For i As Integer = 0 To Me.dgAlumnos.RowCount - 1
      For j As Integer = 2 To Me.dgAlumnos.ColumnCount - 1
        If CStr(Me.dgAlumnos.Rows(i).Cells(j).EditedFormattedValue) <> "" Then
          sw = 1
          Exit For
        End If
      Next
      If sw = 1 Then
        Exit For
      End If
    Next

    If sw = 1 Then
      If MessageBox.Show("Desea registrar las notas ingresadas", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
        Try
          For i As Integer = 0 To Me.dgAlumnos.RowCount - 1
            k = 2
            nro = CType(Me.dgAlumnos.Rows(i).DataBoundItem, Matricula).Numero
            For Each virtud As Virtud In lv
              If codNotasText(i, k) = "" Then
                If CStr(Me.dgAlumnos.Rows(i).Cells(k).EditedFormattedValue) <> "" Then
                  RegistrarNotaComportamiento(i, k, nro, virtud)
                End If
              Else
                If CStr(Me.dgAlumnos.Rows(i).Cells(k).EditedFormattedValue) <> codNotasText(i, k) Then
                  ActualizarNotaComportamiento(i, k)
                End If
              End If
              k += 1
            Next
          Next
          InicializarCodNotas()
          'Listar()
          MessageBox.Show("Notas registradas y/o actualizadas con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
          MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
          Me.dgAlumnos.Visible = False
          Listar()
          Me.dgAlumnos.Visible = True
        End Try
      End If
    Else
      MessageBox.Show("No a ingresado notas", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If

  End Sub

  Public Sub RegistrarNotaComportamiento(ByVal i As Integer, ByVal j As Integer, ByVal nro As Integer, ByVal v As Virtud)
    Dim obj As New RNNotaComportamiento
    Dim letra As String = ""
    Dim puntos As Integer = 0
    Dim cadena As String = ""

    If CType(Me.cboSeccion.SelectedItem, Seccion).Grado.TipoEval = "N" Then
      cadena = CStr(Me.dgAlumnos.Rows(i).Cells(j).EditedFormattedValue).Chars(0)
      puntos = CInt(cadena)
    Else
      letra = CStr(Me.dgAlumnos.Rows(i).Cells(j).EditedFormattedValue).Chars(4)
    End If
    obj.Registrar(New NotaComportamiento(0, puntos, letra, Now, True, New Matricula(nro), _
            New PeriodoAcademico(mOPeriodoActual.Codigo), New Virtud(v.Codigo), _
            New Personal(mOUsuario.Persona.Codigo)))
  End Sub

  Public Sub ActualizarNotaComportamiento(ByVal i As Integer, ByVal j As Integer)
    Dim obj As New RNNotaComportamiento
    Dim letra As String = ""
    Dim puntos As Integer = 0
    Dim cadena As String = ""

    If CType(Me.cboSeccion.SelectedItem, Seccion).Grado.TipoEval = "N" Then
      cadena = CStr(Me.dgAlumnos.Rows(i).Cells(j).EditedFormattedValue).Chars(0)
      puntos = CInt(cadena)
    Else
      letra = CStr(Me.dgAlumnos.Rows(i).Cells(j).EditedFormattedValue).Chars(4)
    End If

    obj.RegistrarNuevaNotaComp(New NotaComportamiento(codNotas(i, j), puntos, letra, Now, True, _
                    New Matricula(), New PeriodoAcademico(), New Virtud() _
                    , New Personal(mOUsuario.Persona.Codigo)))

  End Sub

  Private Sub frmComportamiento_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    If MessageBox.Show("¿Está seguro que desea cerrar la ventana?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
      e.Cancel = True
    End If
  End Sub

  Private Sub dgAlumnos_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgAlumnos.EditingControlShowing
    Dim combo As ComboBox = Nothing


    If TypeOf (e.Control) Is ComboBox Then
      combo = CType(e.Control, ComboBox)

      RemoveHandler combo.SelectedIndexChanged, New EventHandler(AddressOf dgAlumnos_SelectedIndexChanged)
      AddHandler combo.SelectedIndexChanged, New EventHandler(AddressOf dgAlumnos_SelectedIndexChanged) 'creo el evento selectedindexchanged
    End If

  End Sub

  Private Sub dgAlumnos_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
    Dim cmb As ComboBox = CType(sender, ComboBox)
    Dim selectedIndex As Integer = cmb.SelectedIndex
    Dim num As Integer = 0
    Dim str As String = ""

    Try
      If selectedIndex >= 0 Then
        str = cmb.Text.Trim.Chars(0)
        If str = "1" Or str = "2" Or str = "3" Or str = "4" Or str = "5" _
            Or str = "6" Or str = "7" Or str = "8" Or str = "9" Or str = "10" Then
          num = CInt(str)
          Me.dgAlumnos.CurrentRow.Cells(Me.dgAlumnos.CurrentCell.ColumnIndex).Value = cmb.Text
        End If

      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub
End Class