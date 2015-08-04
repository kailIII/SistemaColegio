
Public Class frmComportamiento

  Private Const CELDAINICIO As String = "C8"
  Private Const CLAVE As String = "CETI"

  Private equivalencias As List(Of Equivalencia) = Nothing
  Private secciones As List(Of Seccion)
  Private virtudes As List(Of Virtud) = Nothing
  Private codVirtudes(50) As Integer
  Private estadoEva As String
  Private estado As Integer = 0
  Private rows As Integer = 0
  Private codNotas(100, 20) As Integer
  Private codNotasText(100, 20) As String

  Private mDialogoGuardar As SaveFileDialog
  Private mDialogoAbrir As OpenFileDialog

  Public WriteOnly Property DialogoGuardar As SaveFileDialog
    Set(ByVal value As SaveFileDialog)
      Me.mDialogoGuardar = value
    End Set
  End Property

  Public WriteOnly Property DialogoAbrir As OpenFileDialog
    Set(ByVal value As OpenFileDialog)
      Me.mDialogoAbrir = value
    End Set
  End Property

  Private Sub frmComportamiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Dim obj2 As New RNEquivalencia
    Me.MostrarAnioPeriodo()
    Me.ListarTutores()
    Me.MostrarImagenes()
    equivalencias = obj2.ListarEquivalencias()
    obj2 = Nothing
  End Sub

  Public Sub Gestion()
    Me.ShowDialog()
  End Sub

  Private Sub ListarTutores()
    Dim obj As New RNSeccion

    secciones = obj.ListarTutores(modPrincipal.moAnioActual)
    If secciones.Count > 0 Then
      cboTutor.DisplayMember = "TutorSeccion"
      cboTutor.ValueMember = "CodigoTutor"
      cboTutor.DataSource = secciones
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

  Private Sub MostrarImagenes()
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
  End Sub

  Private Sub Listar()
    If Me.cboTutor.SelectedIndex > -1 Then
      Me.dgvAlumnos.Visible = False
      LimpiarColumnas()
      Me.dgvAlumnos.Visible = True
      Me.MostrarAlumnosSeccion()
      Me.MostrarVirtudes()
      Me.estadoEva = CType(Me.cboTutor.SelectedItem, Seccion).Grado.TipoEval
      Me.ListarNotasComportamiento()
    Else
      MessageBox.Show("Seleccione sección", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
  End Sub

  Private Sub MostrarAlumnosSeccion()
    Dim obj As New RNMatricula
    Dim lm As List(Of Matricula)

    lm = obj.ListarAlumno(New Seccion(moAnioActual, New Grado(CType(Me.cboTutor.SelectedItem, Seccion).Grado.Codigo) _
                                  , CType(Me.cboTutor.SelectedItem, Seccion).Letra))
    If lm.Count > 0 Then
      Me.dgvAlumnos.AutoGenerateColumns = False
      Me.dgvAlumnos.DataSource = lm
      Me.dgvAlumnos.Columns(0).DataPropertyName = "NroOrden"
      Me.dgvAlumnos.Columns(1).DataPropertyName = "NombreAlumno"
    End If
    lm = Nothing
  End Sub

  Private Sub MostrarVirtudes()
    Dim obj As New RNVirtud
    Dim col As DataGridViewComboBoxColumn = Nothing
    Dim col2 As DataGridViewTextBoxColumn = Nothing
    Dim k As Integer = 2
    Dim sw As Integer = 0

    virtudes = obj.ListarVirtudesPeriodo(New Virtud(0, "", True, moAnioActual, mOPeriodoActual, _
                                              CType(Me.cboTutor.SelectedItem, Seccion).Grado.Nivel, 0))
    If virtudes.Count > 0 Then
      LimpiarCodVirtudes() ''inicializar el vector de codigos de virtud
      For Each virtud As Virtud In virtudes
        col = New DataGridViewComboBoxColumn
        col.Name = "cd" & virtud.Nombre & CStr(virtud.Codigo)
        col.HeaderText = virtud.Nombre
        col.Width = 120
        col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.dgvAlumnos.Columns.AddRange(col)
        If CType(Me.cboTutor.SelectedItem, Seccion).Grado.TipoEval.Trim = "N" Then
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
        Me.dgvAlumnos.Columns.AddRange(col2)
      End If
    End If

  End Sub

  Private Sub ListarNotasComportamiento()
    Dim obj As RNNotaComportamiento

    Dim nota As NotaComportamiento = Nothing
    Dim cadena As String = ""
    Dim k As Integer = 0
    Dim nro As Integer

    If Me.dgvAlumnos.RowCount > 0 Then
      obj = New RNNotaComportamiento

      For i As Integer = 0 To Me.dgvAlumnos.RowCount - 1
        k = 2
        nro = CType(Me.dgvAlumnos.Rows(i).DataBoundItem, Matricula).Numero
        For Each v As Virtud In virtudes
          nota = obj.NotaComport(New NotaComportamiento(mOPeriodoActual _
                  , New Matricula(nro), v))
          If nota IsNot Nothing Then
            Me.dgvAlumnos.Rows(i).Cells(k).Value = RetornaCadena(nota.Puntos, nota.Letra, equivalencias)
            codNotas(i, k) = nota.Codigo '''''para guardar todos los codigos de las notas de cada alumno
            codNotasText(i, k) = Me.dgvAlumnos.Rows(i).Cells(k).EditedFormattedValue.ToString

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
    Me.dgvAlumnos.ClearSelection()
    Try
      Me.dgvAlumnos.DataSource = Nothing
      Me.dgvAlumnos.Rows.Clear()
      While Me.dgvAlumnos.Columns.Count > 2
        For i As Integer = 2 To Me.dgvAlumnos.Columns.Count - 1
          Me.dgvAlumnos.Columns.RemoveAt(i)
          Exit For
        Next
      End While
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try
  End Sub

  Private Sub LlenarColumnas(ByVal name As String)
    Dim column As DataGridViewComboBoxColumn = DirectCast(Me.dgvAlumnos.Columns(name), DataGridViewComboBoxColumn)
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
    Me.cboTutor.SelectedIndex = -1
    'End If
  End Sub

  Private Sub dgAlumnos_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAlumnos.CellValueChanged
    If Me.cboTutor.SelectedIndex > -1 Then
      If CType(Me.cboTutor.SelectedItem, Seccion).Grado.TipoEval.Trim = "N" Then
        MostrarAcumulado()
      End If
    End If
  End Sub

  Private Sub MostrarAcumulado()
    Dim nroCol As Integer = Me.dgvAlumnos.ColumnCount - 3
    Dim pos As Integer = Me.dgvAlumnos.Rows.IndexOf(Me.dgvAlumnos.CurrentRow)
    Dim k As Integer
    Dim suma As Integer
    Dim puntos As String

    If estado = 1 Then
      pos = rows
    End If

    For i As Integer = 2 To nroCol + 1
      If Me.dgvAlumnos.Rows(pos).Cells(i).EditedFormattedValue.ToString <> "" Then
        k += 1
      End If
    Next

    If k = nroCol Then
      For i As Integer = 2 To nroCol + 1
        puntos = Me.dgvAlumnos.Rows(pos).Cells(i).EditedFormattedValue.ToString.Chars(0)
        suma += CInt(puntos)
      Next
      Me.dgvAlumnos.Rows(pos).Cells(Me.dgvAlumnos.ColumnCount - 1).Value = suma
      Me.dgvAlumnos.Rows(pos).Cells(Me.dgvAlumnos.ColumnCount - 1).Style.BackColor = Color.SkyBlue
      Me.dgvAlumnos.Rows(pos).Cells(Me.dgvAlumnos.ColumnCount - 1).Style.ForeColor = Color.Black
    Else
      If Me.dgvAlumnos.RowCount > 0 Then
        Me.dgvAlumnos.Rows(pos).Cells(Me.dgvAlumnos.ColumnCount - 1).Value = ""
        Me.dgvAlumnos.Rows(pos).Cells(Me.dgvAlumnos.ColumnCount - 1).Style.BackColor = Color.White
      End If
    End If
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim sw As Integer = 0
    Dim k, nro As Integer

    For i As Integer = 0 To Me.dgvAlumnos.RowCount - 1
      For j As Integer = 2 To Me.dgvAlumnos.ColumnCount - 1
        If CStr(Me.dgvAlumnos.Rows(i).Cells(j).EditedFormattedValue) <> "" Then
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

          For i As Integer = 0 To Me.dgvAlumnos.RowCount - 1
            k = 2
            nro = CType(Me.dgvAlumnos.Rows(i).DataBoundItem, Matricula).Numero
            For Each virtud As Virtud In virtudes
              If codNotasText(i, k) = "" Then
                If CStr(Me.dgvAlumnos.Rows(i).Cells(k).EditedFormattedValue) <> "" Then

                  RegistrarNotaComportamiento(i, k, nro, virtud)

                End If
              Else
                If CStr(Me.dgvAlumnos.Rows(i).Cells(k).EditedFormattedValue) <> codNotasText(i, k) Then

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
          Me.dgvAlumnos.Visible = False
          Listar()
          Me.dgvAlumnos.Visible = True
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

    If CType(Me.cboTutor.SelectedItem, Seccion).Grado.TipoEval = "N" Then
      cadena = CStr(Me.dgvAlumnos.Rows(i).Cells(j).EditedFormattedValue).Chars(0)
      puntos = CInt(cadena)
    Else
      letra = CStr(Me.dgvAlumnos.Rows(i).Cells(j).EditedFormattedValue).Chars(4)
    End If
    obj.Registrar(New NotaComportamiento(0, puntos, letra, Now, True, New Matricula(nro), _
            mOPeriodoActual, New Virtud(v.Codigo), _
            New Personal(mOUsuario.Persona.Codigo)))
  End Sub

  Public Sub ActualizarNotaComportamiento(ByVal i As Integer, ByVal j As Integer)
    Dim obj As New RNNotaComportamiento
    Dim letra As String = ""
    Dim puntos As Integer = 0
    Dim cadena As String = ""

    If CType(Me.cboTutor.SelectedItem, Seccion).Grado.TipoEval = "N" Then
      cadena = CStr(Me.dgvAlumnos.Rows(i).Cells(j).EditedFormattedValue).Chars(0)
      puntos = CInt(cadena)
    Else
      letra = CStr(Me.dgvAlumnos.Rows(i).Cells(j).EditedFormattedValue).Chars(4)
    End If

    obj.RegistrarNuevaNotaComp(New NotaComportamiento(codNotas(i, j), puntos, letra, Now, True, _
                    Nothing, Nothing, Nothing, New Personal(mOUsuario.Persona.Codigo)))

  End Sub

  Private Sub frmComportamiento_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    If MessageBox.Show("¿Está seguro que desea cerrar la ventana?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
      e.Cancel = True
    End If
  End Sub

  Private Sub dgAlumnos_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvAlumnos.EditingControlShowing
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
          Me.dgvAlumnos.CurrentRow.Cells(Me.dgvAlumnos.CurrentCell.ColumnIndex).Value = cmb.Text
        End If

      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try

  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    If Me.cboTutor.SelectedIndex > -1 Then
      'Me.MostrarSeccion()
      Me.InicializarCodNotas()
      Me.Listar()
    End If
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Dim rn As RNSeccion
    Dim dt As DataTable

    virtudes = New List(Of Virtud)
    rn = New RNSeccion
    Try
      dt = rn.GenerarRegistroComportamiento(DirectCast(Me.cboTutor.SelectedItem, Seccion), mOPeriodoActual, Me.virtudes)
      Me.ExportarDatos(dt)
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      rn = Nothing
    End Try
  End Sub

  Private Sub ExportarDatos(ByVal datos As DataTable)
    Dim excel As Microsoft.Office.Interop.Excel.Application = Nothing
    Dim libro As Microsoft.Office.Interop.Excel.Workbook
    Dim hoja As Microsoft.Office.Interop.Excel.Worksheet
    Dim sec As Seccion

    sec = DirectCast(Me.cboTutor.SelectedItem, Seccion)
    Me.mDialogoGuardar.FileName = sec.NivelNumeroLetra & " " & sec.Tutor.NombreCompleto
    Me.mDialogoGuardar.Filter = "Documentos de excel (*.xlsx)|*.xlsx"
    Try
      excel = modExcel.CrearExcel
      libro = modExcel.AbrirPlantilla(excel, Me.mDialogoGuardar, AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\RegistroComportamiento.xls")
      If libro IsNot Nothing Then
        hoja = DirectCast(libro.Worksheets.Item("DATOS"), Microsoft.Office.Interop.Excel.Worksheet)

        With DirectCast(Me.cboTutor.SelectedItem, Seccion)
          hoja.Range("B5").Value = .Anio.Anio & "-" & .Grado.Codigo & "-" & .Letra & "-" & mOPeriodoActual.Codigo
          hoja.Range("D5").Value = .Tutor.NombreCompleto
          hoja.Range("G5").Value = .NivelNumeroLetra
        End With

        Me.CrearCabecera(hoja.Range(CELDAINICIO))
        Me.ExportarDatos(hoja.Range(CELDAINICIO).Offset(1, 0), datos)
        modExcel.CeldaFondo(hoja.Range(hoja.Range(CELDAINICIO), hoja.Range(CELDAINICIO).Offset(0, 1 + Me.virtudes.Count)), 15720111)
        With hoja.Range(hoja.Range(CELDAINICIO), hoja.Range(CELDAINICIO).Offset(0, 1 + Me.virtudes.Count))
          .Font.Bold = True
          .HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
        End With
        modExcel.BordesTodo(hoja.Range(hoja.Range(CELDAINICIO), hoja.Range(CELDAINICIO).Offset(datos.Rows.Count, 1 + Me.virtudes.Count)))
        hoja.Protect(CLAVE)

        excel.ActiveWorkbook.SaveAs(Me.mDialogoGuardar.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault)

        MessageBox.Show("Registro generado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      If excel IsNot Nothing Then
        excel.ScreenUpdating = True
        excel.Quit()
      End If
      hoja = Nothing
      libro = Nothing
      excel = Nothing
    End Try
  End Sub

  Private Sub ExportarDatos(ByVal celda As Microsoft.Office.Interop.Excel.Range, ByVal datos As DataTable)
    Dim i As Integer
    Dim valores As String = ""

    For Each eq As Equivalencia In Me.equivalencias
      valores &= "," & eq.Puntos & " : " & eq.Literal
    Next
    For Each dr As DataRow In datos.Rows
      celda.Offset(0, -1).Value = dr.Item("nroMatricula")
      celda.Value = dr.Item("nroOrden")
      celda.Offset(0, 1).Value = dr.Item("Alumno")
      i = 2
      For Each vir As Virtud In Me.virtudes
        If dr.IsNull(vir.Nombre) = False AndAlso CInt(dr.Item(vir.Nombre)) > 0 Then
          With Me.equivalencias.Item(CInt(dr.Item(vir.Nombre)) - 1)
            celda.Offset(0, i).Value = .Puntos & " : " & .Literal
          End With
        End If
        celda.Offset(0, i).Locked = False
        With celda.Offset(0, i).Validation
          .Add(Microsoft.Office.Interop.Excel.XlDVType.xlValidateList, Microsoft.Office.Interop.Excel.XlDVAlertStyle.xlValidAlertStop, 1, valores)
          .ErrorMessage = "La calificación no es válida. (" & valores & ")"
        End With

        i += 1
      Next
      celda = celda.Offset(1, 0)
    Next
  End Sub

  Private Sub CrearCabecera(ByVal celda As Microsoft.Office.Interop.Excel.Range)
    Dim tit As Microsoft.Office.Interop.Excel.Range = celda
    tit.Value = "NUM."
    tit.Offset(0, 1).Value = "ALUMNO"
    tit = celda.Offset(0, 2)
    For Each vir As Virtud In Me.virtudes
      tit.Offset(-1, 0).Value = vir.Codigo
      tit.Value = vir.Nombre.ToUpper
      tit.EntireColumn.ColumnWidth = 17
      tit = tit.Offset(0, 1)
    Next
  End Sub

  Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
    Dim m_excel As Microsoft.Office.Interop.Excel.Application = Nothing
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing

    Try
      m_excel = New Microsoft.Office.Interop.Excel.Application
      m_excel.ScreenUpdating = False
      m_excel.DisplayAlerts = False

      Me.mDialogoAbrir.Filter = "Todos las hojas de cálculo|*.xls;*.xlsx|Hojas de cálculo MS Excel 2007(*.xlsx)|*.xlsx|Hojas de cálculo MS Excel 2003(*.xls)|*.xls"
      Libro = modExcel.AbrirLibro(m_excel, Me.mDialogoAbrir)
      If Libro IsNot Nothing Then
        For i As Integer = 1 To Libro.Worksheets.Count
          Hoja = DirectCast(Libro.Worksheets.Item(i), Microsoft.Office.Interop.Excel.Worksheet)
          Me.CargarNotasComportamiento(Hoja)
        Next
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Hoja = Nothing
      Libro = Nothing
      If m_excel IsNot Nothing Then
        m_excel.ScreenUpdating = True
        m_excel.Quit()
      End If
      m_excel = Nothing
    End Try
  End Sub

  Private Sub CargarNotasComportamiento(ByVal wHojaUnidad As Microsoft.Office.Interop.Excel.Worksheet)
    Dim promedios As New List(Of NotaCapacidad)
    Dim mat As Matricula
    Dim per As New Personal With {.Codigo = mOUsuario.Persona.Codigo}
    Dim celdaMat As Microsoft.Office.Interop.Excel.Range = wHojaUnidad.Range("B9")
    Dim celdaVir As Microsoft.Office.Interop.Excel.Range = wHojaUnidad.Range("E7")
    Dim notasComp As New List(Of NotaComportamiento)
    Dim notaC As NotaComportamiento
    Dim i As Integer

    Me.virtudes = New List(Of Virtud)
    While (celdaVir.Value IsNot Nothing)
      Me.virtudes.Add(New Virtud With {.Codigo = CInt(celdaVir.Value)})
      celdaVir = celdaVir.Offset(0, 1)
    End While
    While (celdaMat.Value IsNot Nothing)
      mat = New Matricula With {.Numero = CInt(celdaMat.Value)}
      i = 3
      For Each vir As Virtud In Me.virtudes
        If celdaMat.Offset(0, i).Value IsNot Nothing Then
          notaC = New NotaComportamiento With {.Periodo = modPrincipal.mOPeriodoActual, .Personal = per}
          notaC.Matricula = mat
          notaC.Virtud = vir
          notaC.Puntos = CInt(celdaMat.Offset(0, i).Value.ToString.Substring(0, 1))

          notasComp.Add(notaC)
        End If
        i += 1
      Next

      celdaMat = celdaMat.Offset(1, 0)
    End While
    If notasComp.Count > 0 Then
      Me.RegistrarNotas(notasComp)
    End If
  End Sub

  Private Sub RegistrarNotas(ByVal notas As List(Of NotaComportamiento))
    Dim rn As New RNNotaComportamiento

    Try
      rn.Registrar(notas)
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      rn = Nothing
    End Try
  End Sub

End Class