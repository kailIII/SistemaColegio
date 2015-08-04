Imports Microsoft.Office.Interop.Excel

Public Class frmGestionProgLectura

  Private Const CLAVE As String = "CETI"
  Private Const CELDA_INICIO As String = "A11"

  Private Shared frm As frmGestionProgLectura
  Private sfdDialogo As SaveFileDialog
  Private ofdDialogo As OpenFileDialog

  Private Libros As List(Of GradoLibro)
  Private Asignaciones As Data.DataTable
  Private presentado As Boolean = False

  Private Sub New()
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
  End Sub

  Private Sub frmProgramacionLectura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.CargarImagenes()
    Me.txtAnio.Text = moAnioActual.Anio
    Me.CargarNiveles()
    Me.CargarPresentaciones()
  End Sub

  Public Sub CargarNiveles()
    Dim ListNa As List(Of Nivel)
    Dim objNa As New RNNivel

    ListNa = objNa.Listar()
    cboNivel.DisplayMember = "Nombre"
    cboNivel.ValueMember = "Codigo"
    cboNivel.DataSource = ListNa
    ListNa = Nothing
    Me.cboNivel.SelectedIndex = -1
  End Sub

  Private Sub CargarImagenes()
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
  End Sub

  Private Sub CargarSeccion()
    Dim obj As New RNSeccion
    Dim ls As List(Of Seccion)

    If Me.cboNivel.SelectedIndex > -1 Then
      ls = obj.Leer_NivelAcad(moAnioActual, CType(cboNivel.SelectedItem, Nivel), 1)
      If ls.Count > 0 Then
        Me.cboSeccion.DisplayMember = "NumeroLetra"
        Me.cboSeccion.ValueMember = "NumeroLetra"
        Me.cboSeccion.DataSource = ls
      End If
    Else
      Me.cboSeccion.DataSource = Nothing
      Me.cboSeccion.SelectedIndex = -1
    End If
  End Sub

  Private Sub CargarPresentaciones()
    Dim obj As New RNPresentacion
    Dim Presentaciones As List(Of Presentacion)

    Presentaciones = obj.ListarPresVigentes(moAnioActual.Anio)
    Me.cboPresentacion.DisplayMember = "Numero"
    Me.cboPresentacion.ValueMember = "Codigo"
    Me.cboPresentacion.DataSource = Presentaciones
    Me.cboPresentacion.SelectedIndex = -1
  End Sub

  Public Shared Sub Gestionar(ByVal wPadre As Form, ByVal wDialogoGuardar As SaveFileDialog, ByVal wDialogoAbrir As OpenFileDialog)
    If frmGestionProgLectura.frm Is Nothing Then
      frmGestionProgLectura.frm = New frmGestionProgLectura
      frmGestionProgLectura.frm.sfdDialogo = wDialogoGuardar
      frmGestionProgLectura.frm.ofdDialogo = wDialogoAbrir
      frmGestionProgLectura.frm.MdiParent = wPadre
      frmGestionProgLectura.frm.Show()
      frmGestionProgLectura.frm.WindowState = FormWindowState.Maximized
    Else
      frmGestionProgLectura.frm.Activate()
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub txtAnio_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAnio.Enter
    Me.cboNivel.Focus()
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim rn As New RNLibro

    If Me.cboSeccion.SelectedIndex > -1 AndAlso Me.cboPresentacion.SelectedIndex > -1 Then
      With DirectCast(Me.cboSeccion.SelectedItem, Seccion)
        Me.Libros = rn.ListarLibroGradoVigentes(.Grado, .Anio)
        Me.Asignaciones = rn.ListarLibrosAsignados(DirectCast(Me.cboSeccion.SelectedItem, Seccion), DirectCast(Me.cboPresentacion.SelectedItem, Presentacion), Libros)
      End With

      Me.presentado = False
      Me.dgvAlumnos.DataSource = Me.Asignaciones
      Me.dgvAlumnos.Columns.Remove("nroMatricula")
      Me.presentado = True
    ElseIf Me.cboPresentacion.SelectedIndex = -1 Then
      MessageBox.Show("Debe seleccionar la presentación", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    ElseIf Me.cboSeccion.SelectedIndex = -1 Then
      MessageBox.Show("Debe seleccionar la sección", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    Else
      MessageBox.Show("Debe seleccionar el nivel académico", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim pl As ProgramacionLectura
    Dim dr As DataRow = Nothing
    Dim rn As RNLibro
    Dim i As Integer

    If Me.VerificarAsignacion = True Then
      Try
        rn = New RNLibro
        pl = New ProgramacionLectura With {.Matricula = New Matricula}
        For Each dr In Me.Asignaciones.Rows
          pl.Matricula.Numero = CInt(dr.Item("nroMatricula"))
          pl.Presentacion = DirectCast(Me.cboPresentacion.SelectedItem, Presentacion)
          i = 0
          For Each gl As GradoLibro In Me.Libros
            i = i + 1
            If CBool(dr.Item(gl.Libro.Titulo)) = True Then
              pl.NroGrupo = i
              pl.Libro = gl.Libro
              pl.Vigencia = CBool(dr.Item(gl.Libro.Titulo))
              pl.Tipo = "P"

              rn.ProgramarLectura(pl)
            End If
          Next
        Next
        MessageBox.Show("Se registró la programación", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Catch ex As Exception
        MessageBox.Show("No se pudo registrar la programación de " & dr.Item("Alumno").ToString & vbNewLine & _
                        ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'MessageBox.Show("No se pudo registrar la programación", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        rn = Nothing
      End Try
    Else
      MessageBox.Show("Uno o mas alumnos no tienen libro asignado o se ha asignado más de un libro a un alumno", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Function VerificarAsignacion() As Boolean
    Dim asignado As Boolean

    For Each fila As DataRow In Me.Asignaciones.Rows
      asignado = False
      For Each gl As GradoLibro In Me.Libros
        If CBool(fila.Item(gl.Libro.Titulo)) = True Then
          If asignado = False Then
            asignado = True
          Else
            Return False
          End If
        End If
      Next
      If asignado = False Then
        Return False
      End If
    Next

    Return True
  End Function

  Private Sub dgvAlumnos_CellValidated(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAlumnos.CellValidated
    If e.ColumnIndex > 0 AndAlso Me.presentado = True AndAlso CBool(Me.dgvAlumnos.Rows.Item(e.RowIndex).Cells(e.ColumnIndex).Value) = True Then
      For Each gl As GradoLibro In Me.Libros
        If gl.Libro.Titulo <> Me.dgvAlumnos.Columns.Item(e.ColumnIndex).Name Then
          Me.dgvAlumnos.Rows.Item(e.RowIndex).Cells(gl.Libro.Titulo).Value = False
        End If
      Next
    End If
  End Sub

  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNivel.SelectedIndexChanged
    Me.CargarSeccion()
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Dim excel As Application = Nothing
    Dim libro As Workbook = Nothing

    Try
      Me.sfdDialogo.FileName = "REGISTRO ASIGNACIONES " & Me.cboNivel.Text & " " & Me.cboSeccion.Text & "-" & Me.cboPresentacion.Text
      Me.sfdDialogo.Filter = "Hoja de cálculo 2007(*.xlsx)|*.xlsx"
      excel = New Application
      excel.ScreenUpdating = False
      excel.DisplayAlerts = False
      libro = modExcel.AbrirPlantilla(excel, Me.sfdDialogo, AppDomain.CurrentDomain.BaseDirectory & "Plantillas\RegistroAsignaciones.xlsx")
      With DirectCast(libro.Worksheets.Item("Datos"), Worksheet)
        .Range("B6").Value = Me.cboNivel.Text & " " & Me.cboSeccion.Text
        .Range("C7").Value = moAnioActual.Anio & "-" & DirectCast(Me.cboSeccion.SelectedItem, Seccion).Grado.Codigo & "-" & DirectCast(Me.cboSeccion.SelectedItem, Seccion).Letra
        .Range("G6").Value = Me.cboPresentacion.Text
        .Range("G7").Value = Me.cboPresentacion.SelectedValue

        Me.CrearCabecera(.Range(CELDA_INICIO))
        Me.ExportarDatos(.Range(CELDA_INICIO).Offset(1, 0))

        modExcel.FondoGris(.Range(.Range(CELDA_INICIO), .Range(CELDA_INICIO).Offset(0, 2 + Me.Libros.Count)))
        modExcel.BordesTodo(.Range(.Range(CELDA_INICIO), .Range(CELDA_INICIO).Offset(Me.Asignaciones.Rows.Count, 2 + Me.Libros.Count)))

        .Protect(CLAVE)
      End With

      libro.SaveAs(Me.sfdDialogo.FileName)
      MessageBox.Show("La exportación se realizó exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      If libro IsNot Nothing Then
        libro.Close()
      End If
      If excel IsNot Nothing Then
        excel.ScreenUpdating = True
        excel.Quit()
      End If
      libro = Nothing
      excel = Nothing
    End Try
  End Sub

  Private Sub CrearCabecera(ByVal wCelda As Range)
    Dim celdaLibro As Range
    Dim i As Integer = 1

    wCelda.Value = "N°"
    'wCelda.Offset(0, 1).Value = "nroMatricula"
    wCelda.Offset(0, 2).Value = "ALUMNO"
    wCelda.Offset(-2, 2).Value = Me.Libros.Count
    celdaLibro = wCelda.Offset(0, 3)
    For Each gl As GradoLibro In Me.Libros
      celdaLibro.Offset(-2, 0).Value = i
      celdaLibro.Offset(-1, 0).Value = gl.Libro.Codigo
      celdaLibro.Value = gl.Libro.Titulo

      celdaLibro = celdaLibro.Offset(0, 1)
      i += 1
    Next
  End Sub

  Private Sub ExportarDatos(ByVal wCelda As Range)
    Dim colLibro As Integer
    Dim i As Integer = 1

    wCelda.Offset(-1, 1).Value = Me.Asignaciones.Rows.Count
    For Each drAlu As DataRow In Me.Asignaciones.Rows
      wCelda.Value = i
      wCelda.Offset(0, 1).Value = drAlu.Item("nroMatricula")
      wCelda.Offset(0, 2).Value = drAlu.Item("Alumno")
      colLibro = 0
      For Each gl As GradoLibro In Me.Libros
        If CBool(drAlu.Item(gl.NombreLibro)) = True Then
          wCelda.Offset(0, 3 + colLibro).Value = "SI"
        End If
        With wCelda.Offset(0, 3 + colLibro).Validation
          .Add(XlDVType.xlValidateList, XlDVAlertStyle.xlValidAlertStop, 1, "SI, NO")
        End With
        colLibro += 1
      Next
      i += 1
      wCelda = wCelda.Offset(1, 0)
    Next
  End Sub

  Private Sub frmGestionProgLectura_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmGestionProgLectura.frm = Nothing
  End Sub

  Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
    Dim m_excel As Microsoft.Office.Interop.Excel.Application = Nothing
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing

    Try
      m_excel = New Microsoft.Office.Interop.Excel.Application
      m_excel.ScreenUpdating = False
      m_excel.DisplayAlerts = False

      Me.ofdDialogo.Filter = "Todos las hojas de cálculo|*.xls;*.xlsx|Hojas de cálculo MS Excel 2007(*.xlsx)|*.xlsx|Hojas de cálculo MS Excel 2003(*.xls)|*.xls"
      Libro = modExcel.AbrirLibro(m_excel, Me.ofdDialogo)
      If Libro IsNot Nothing Then
        Hoja = DirectCast(Libro.Worksheets.Item(1), Microsoft.Office.Interop.Excel.Worksheet)
        Hoja.Unprotect(CLAVE)
        If Me.CargarAsignaciones(Hoja) = False Then
          Hoja.Protect(CLAVE)
          Libro.Save()
          MessageBox.Show("Los registros en conflicto han sido marcados en color rojo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Hoja = Nothing
      If Libro IsNot Nothing Then
        Libro.Close()
      End If
      Libro = Nothing
      If m_excel IsNot Nothing Then
        m_excel.ScreenUpdating = True
        m_excel.Quit()
      End If
      m_excel = Nothing
    End Try
  End Sub

  Private Function CargarAsignaciones(ByVal wHoja As Worksheet) As Boolean
    Dim rn As RNLibro
    Dim celda As Range
    Dim libros As List(Of Libro)
    Dim matriculas As List(Of Matricula)
    Dim asignados(,) As Object
    Dim programaciones As New List(Of ProgramacionLectura)
    Dim seccion() As String = wHoja.Range("C7").Value.ToString.Split("-"c)
    Dim asignado As Boolean
    Dim tieneErrores As Boolean = False
    Dim pr As New Presentacion With {.Codigo = CInt(wHoja.Range("G7").Value)}
    Dim sec As New Seccion With {.Grado = New Grado With {.Codigo = CInt(seccion(1))},
                                 .Anio = New AnioLectivo With {.Anio = seccion(0)},
                                 .Letra = seccion(2)}
    Dim posiciones As List(Of Integer)

    celda = wHoja.Range(CELDA_INICIO)
    libros = CargarLibros(celda)
    matriculas = CargarMatriculas(celda)
    celda = celda.Offset(1, 3)
    asignados = DirectCast(wHoja.Range(celda.Address & ":" & celda.Offset(matriculas.Count - 1, libros.Count - 1).Address).Value, Object(,))
    For i As Integer = 1 To matriculas.Count
      asignado = False
      For j As Integer = 1 To libros.Count
        If asignados(i, j) IsNot Nothing AndAlso asignados(i, j).ToString = "SI" Then
          If asignado = False Then
            programaciones.Add(New ProgramacionLectura With {.Matricula = matriculas.Item(i - 1),
                                                             .Libro = libros.Item(j - 1),
                                                             .Tipo = "P",
                                                             .Presentacion = pr,
                                                             .NroGrupo = j,
                                                             .Seccion = sec,
                                                             .Vigencia = True})
            asignado = True
          Else
            'MessageBox.Show("No se puede asignar más de un libro a un alumno" & vbNewLine &
            '                "No se ha registrado ninguna programación", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            modExcel.CeldaFondo(celda.Offset(i - 1, -1), RGB(255, 0, 0))
            tieneErrores = True
          End If
        End If
      Next
    Next
    If tieneErrores = True Then
      MessageBox.Show("Se ha asignado mas de un libro a un mismo alumno" & vbNewLine &
                      "No se ha registrado ninguna programación", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Return False
    End If
    rn = New RNLibro
    Try
      posiciones = rn.ProgramarLectura(programaciones)
      If posiciones.Count = 0 Then
        MessageBox.Show("La importación de las programaciones de lecturas se realizó exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return True
      Else
        MessageBox.Show("No se ha podido registrar una o mas programaciones", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.marcarErrores(celda.Offset(0, -1), posiciones)
        Return False
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Return False
    Finally
      rn = Nothing
    End Try

  End Function

  Private Sub MarcarErrores(ByVal wCelda As Range, ByVal wPosiciones As List(Of Integer))
    For Each pos As Integer In wPosiciones
      modExcel.CeldaFondo(wCelda.Offset(pos, 0), RGB(255, 0, 0))
    Next
  End Sub


  Private Function CargarLibros(ByVal wCelda As Range) As List(Of Libro)
    Dim codigos(,) As Object
    Dim codigosLibros As New List(Of Libro)
    Dim cant As Integer = CInt(wCelda.Offset(-2, 2).Value)

    codigos = DirectCast(wCelda.Worksheet.Range(wCelda.Offset(-1, 3).Address & ":" & wCelda.Offset(-1, 2 + cant).Address).Value, Object(,))
    For i As Integer = 1 To cant
      codigosLibros.Add(New Libro With {.Codigo = CInt(codigos(1, i))})
    Next

    Return codigosLibros
  End Function

  Private Function CargarMatriculas(ByVal wCelda As Range) As List(Of Matricula)
    Dim numeros(,) As Object
    Dim matriculas As New List(Of Matricula)
    Dim cant As Integer = CInt(wCelda.Offset(0, 1).Value)

    numeros = DirectCast(wCelda.Worksheet.Range(wCelda.Offset(1, 1).Address & ":" & wCelda.Offset(cant, 1).Address).Value, Object(,))
    For i As Integer = 1 To cant
      matriculas.Add(New Matricula With {.Numero = CInt(numeros(i, 1))})
    Next

    Return matriculas
  End Function

End Class