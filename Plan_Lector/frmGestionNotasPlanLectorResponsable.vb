Imports Microsoft.Office.Interop.Excel

Public Class frmGestionNotasPlanLectorResponsable

  Private Const CLAVE As String = "CETI"
  Private Const CELDA_INICIO As String = "A9"

  Private sfdDialogo As SaveFileDialog
  Private ofdDialogo As OpenFileDialog

  Private Shared frm As frmGestionNotasPlanLectorResponsable
  Private Shared dgvA As DataGridView

  Private codigoEstado As Integer = 0
  Private AlumnosNotas As List(Of NotaLectura)
  Private Docentes As List(Of Docente)

  Private Shared nota As String
  Private Shared libro As Libro

  Public L As Libro = Nothing

  Private Sub New()
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
  End Sub

  Private Sub frmGestionNotasPlanLector_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    If MessageBox.Show("¿Está seguro que desea cerrar la ventana?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
      e.Cancel = True
    End If
  End Sub

  Private Sub frmGestionNotasPlanLector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btncancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.txtAnio.Text = moAnioActual.Anio
    Me.CargarPresentaciones()
    'Me.CargarDocentes()
  End Sub

  Public Sub CargarDocentes()
    Dim ListD As New List(Of Docente)
    Dim objDoc As New RNDocente

    ListD = objDoc.Listar
    objDoc = Nothing
    Me.cboDocente.DisplayMember = "NombreCompleto"
    Me.cboDocente.ValueMember = "codigo"
    Me.cboDocente.DataSource = ListD
    ListD = Nothing
  End Sub

  Private Sub CargarPresentaciones()
    Dim obj As New RNPresentacion
    Dim lpres As List(Of Presentacion)

    lpres = obj.ListarPresVigentes(moAnioActual.Anio)
    obj = Nothing
    cboPresentacion.DisplayMember = "Numero"
    cboPresentacion.ValueMember = "Codigo"
    cboPresentacion.DataSource = lpres
  End Sub

  Public Shared Sub Gestionar(ByVal wPadre As Form, ByVal wDialogo As SaveFileDialog, ByVal wAbrir As OpenFileDialog)
    If frmGestionNotasPlanLectorResponsable.frm Is Nothing Then
      frmGestionNotasPlanLectorResponsable.frm = New frmGestionNotasPlanLectorResponsable
      frmGestionNotasPlanLectorResponsable.frm.MdiParent = wPadre
      frmGestionNotasPlanLectorResponsable.frm.sfdDialogo = wDialogo
      frmGestionNotasPlanLectorResponsable.frm.ofdDialogo = wAbrir
      frmGestionNotasPlanLectorResponsable.frm.Show()
      frmGestionNotasPlanLectorResponsable.frm.WindowState = FormWindowState.Maximized
    Else
      frmGestionNotasPlanLectorResponsable.frm.Activate()
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Me.Listar()
  End Sub

  Private Sub Listar()
    If Me.cboPresentacion.SelectedIndex > -1 AndAlso Me.cboDocente.SelectedIndex > -1 Then
      Me.LimpiarAlumnos()
      Me.MostrarAlumnosPresentacion()

      Me.dgvNotas.ClearSelection()
    ElseIf Me.cboPresentacion.SelectedIndex = -1 Then
      MessageBox.Show("Debe seleccionar la presentación", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Me.cboPresentacion.Focus()
    Else
      MessageBox.Show("Debe seleccionar el docente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Me.cboDocente.Focus()
    End If

    Me.WindowState = FormWindowState.Maximized
  End Sub

  Private Sub MostrarAlumnosPresentacion()
    Dim obj As New RNNotaLectura

    AlumnosNotas = obj.ListarAlumnosPresentacionDocente(DirectCast(cboPresentacion.SelectedItem, Presentacion), moAnioActual, DirectCast(Me.cboDocente.SelectedItem, Docente))
    obj = Nothing
    If AlumnosNotas.Count > 0 Then
      Me.dgvNotas.AutoGenerateColumns = False
      Me.dgvNotas.DataSource = AlumnosNotas
      'Tania Incio
      For i As Integer = 0 To AlumnosNotas.Count - 1
        If AlumnosNotas(i).NotaRecuperacion <> "" Then
          Me.dgvNotas.Rows(i).Cells.Item(2).ReadOnly = True
        Else
          Me.dgvNotas.Rows(i).Cells.Item(4).ReadOnly = True
        End If
      Next
      For Each N In AlumnosNotas
        If N.Nota <> "" Then
          codigoEstado = 1
          Exit For
        End If
      Next

      Me.txtTotal.Text = AlumnosNotas.Count.ToString
      btnRegistrar.Enabled = True
      Me.btnRecuperacion.Enabled = True
    Else
      Me.txtTotal.Text = AlumnosNotas.Count.ToString
      btnRegistrar.Enabled = False
      Me.btnRecuperacion.Enabled = False
    End If
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

    Me.btnRegistrar.Text = "&Guardar"
    Me.btnRegistrar.Enabled = False
    Me.btnRecuperacion.Enabled = False
  End Sub

  Private Sub dgvNotas_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvNotas.CellValidating
    Dim letra As String = ""
    letra = e.FormattedValue.ToString().ToUpper.Trim

    If dgvNotas.CurrentCell.ColumnIndex = 2 Or dgvNotas.CurrentCell.ColumnIndex = 4 Then
      If Not (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
        validarLetra(letra)
      End If
    End If
  End Sub

  'Tania Incio
  Private Function validarLetra(ByVal letra As String) As Boolean
    If Not (letra = "A" Or letra = "B" Or letra = "C" Or letra = "AD" Or letra = "NP") Then
      MessageBox.Show("Sólo puede ingresar: A,B,C,AD y NP", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Return False
    Else
      Return True
    End If
  End Function


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

  Private Sub dgvNotas_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvNotas.EditingControlShowing
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
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    If Me.dgvNotas.Rows.Count > 0 Then
      If codigoEstado = 0 Then
        Me.RegistrarNota()
        MessageBox.Show("Las notas se registraron con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Limpiar()
        Me.Listar()
      Else
        Me.RegistrarNuevaNota()
        MessageBox.Show("Actualización realizada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Limpiar()
        Me.Listar()
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
          letra = (Me.dgvNotas.Rows(i).Cells("cdNota").EditedFormattedValue).ToString.ToUpper.Trim
          Select Case letra
            Case "C"
              coment = "Requiere Recuperación"
            Case "NP"
              coment = "No se Presentó"
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
        If Me.dgvNotas.Rows(i).Cells("cdNotaRecuperacion").Value.ToString.Equals("") Then
          letra = Me.dgvNotas.Rows(i).Cells("cdNota").Value.ToString.ToUpper
        Else
          letra = Me.dgvNotas.Rows(i).Cells("cdNotaRecuperacion").Value.ToString.ToUpper
        End If



        If Not letra.Equals("") Then
          If Not Me.dgvNotas.Rows(i).Cells("cdNotaRecuperacion").Value.ToString.ToUpper.Equals("") Then
            'Rgistrar nota de recuperación
            RegistrarNotaRecuperacion(nroMat, letra, i)
          Else
            coment = ""
            nroMat = CType(Me.dgvNotas.Rows(i).DataBoundItem, NotaLectura).Matricula.Numero
            codPL = CType(Me.dgvNotas.Rows(i).DataBoundItem, NotaLectura).ProgLectura.Codigo

            If Me.dgvNotas.Rows(i).Cells("cdNota").EditedFormattedValue.ToString <> "" Then
              letra = (Me.dgvNotas.Rows(i).Cells("cdNota").EditedFormattedValue).ToString.ToUpper
              Select Case letra
                Case "C"
                  coment = "Requiere Recuperación"
                Case "D"
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
          End If
        End If

      Next
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Try

  End Sub

  Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
    Me.Limpiar()
  End Sub

  Private Sub frmGestionNotasPlanLectorResponsable_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmGestionNotasPlanLectorResponsable.frm = Nothing
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Dim excel As Application = Nothing
    Dim libro As Workbook = Nothing

    Try
      Me.sfdDialogo.FileName = "PL " & moAnioActual.Anio & "-" & Me.cboDocente.Text & " - Rotación " & Me.cboPresentacion.Text
      Me.sfdDialogo.Filter = "Hoja de cálculo 2007(*.xlsx)|*.xlsx"
      excel = New Application
      excel.ScreenUpdating = False
      excel.DisplayAlerts = False
      libro = modExcel.AbrirPlantilla(excel, Me.sfdDialogo, AppDomain.CurrentDomain.BaseDirectory & "Plantillas\RegistroNotasExportar.xlsx")
      Me.ExportarExcelDocente(DirectCast(Me.cboDocente.SelectedItem, Docente), Me.AlumnosNotas, libro, Me.sfdDialogo.FileName)
      libro.SaveAs(Me.sfdDialogo.FileName)
      MessageBox.Show("La exportación se realizó exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.pbAvance.Value = 0
      If libro IsNot Nothing Then
        libro.Close()
      End If
      If excel IsNot Nothing Then
        excel.DisplayAlerts = True
        excel.ScreenUpdating = True
        excel.Quit()
      End If
      libro = Nothing
      excel = Nothing
    End Try

  End Sub

  Private Sub ExportarDatos(ByVal wAlumnosNotas As List(Of NotaLectura), ByVal wCelda As Range)
    Dim i As Integer = 1
    Me.pbAvance.Value = 0
    For Each Alu As NotaLectura In wAlumnosNotas
      wCelda.Value = i
      wCelda.Offset(0, 1).Value = Alu.Matricula.Numero
      wCelda.Offset(0, 2).Value = Alu.Seccion
      wCelda.Offset(0, 3).Value = Alu.Matricula.Alumno.NombreCompleto
      If Alu.Nota.Length > 0 Then
        wCelda.Offset(0, 4).Value = Alu.Nota
        wCelda.Offset(0, 7).Value = Alu.NotaRecuperacion
      End If
      With wCelda.Offset(0, 4).Validation
        .Add(XlDVType.xlValidateList, XlDVAlertStyle.xlValidAlertStop, 1, "AD, A, B, C, NP")
        .ErrorMessage = "La calificación no es válida. (AD, A, B, C, NP)"
      End With
      wCelda.Offset(0, 5).Value = Alu.ProgLectura.Libro.Titulo
      wCelda.Offset(0, 6).Value = Alu.ProgLectura.Codigo
      wCelda.Offset(0, 8).Value = Alu.LibroRecuperacion
      Me.pbAvance.Value += CInt(100 / wAlumnosNotas.Count)
      i += 1
      wCelda = wCelda.Offset(1, 0)
    Next
  End Sub

  Private Sub cboPresentacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPresentacion.SelectedIndexChanged
    Dim rn As RNPresentacion

    If Me.cboPresentacion.SelectedIndex > -1 Then
      rn = New RNPresentacion
      Me.Docentes = rn.ListarResponsables(DirectCast(Me.cboPresentacion.SelectedItem, Presentacion))
      rn = Nothing
      Me.cboDocente.DisplayMember = "NombreCompleto"
      Me.cboDocente.ValueMember = "Codigo"
      Me.cboDocente.DataSource = Me.Docentes
      Me.cboDocente.SelectedIndex = -1
    Else
      Me.cboDocente.DataSource = Nothing
    End If
  End Sub

  Private Sub ExportarExcelDocente(ByVal wDocente As Docente, ByVal wAlumnosNotas As List(Of NotaLectura), ByVal wLibro As Workbook, ByVal wArchivo As String)
    With CType(wLibro.Worksheets(wLibro.Worksheets.Count), Worksheet)

      .Range("C6").Value = wDocente.NombreCompleto
      .Range("C7").Value = wDocente.Codigo
      .Range("F6").Value = Me.cboPresentacion.Text
      .Range("F7").Value = Me.cboPresentacion.SelectedValue

      Me.ExportarDatos(wAlumnosNotas, .Range(CELDA_INICIO).Offset(1, 0))
      modExcel.BordesTodo(.Range(.Range(CELDA_INICIO), .Range(CELDA_INICIO).Offset(wAlumnosNotas.Count, 8)))
      Me.pbAvance.Value = Me.pbAvance.Maximum
    End With


  End Sub

  Private Sub btnExportarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarTodo.Click
    Dim rnMat As New RNMatricula    
    Dim sec As Seccion = Nothing
    Dim Libro As Workbook = Nothing
    Dim Hoja As Worksheet = Nothing
    Dim excel As Application = Nothing
    Dim proc As Process()

    Dim ruta As String = "", pos As Integer, sw As Integer = 0

    Try

      Me.sfdDialogo.Filter = "Hoja de cálculo 2007(*.xlsx)|*.xlsx"
      Me.sfdDialogo.FileName = "Notas_PlanLector_TodosDocentes " & moAnioActual.Anio & "- Presentación " & DirectCast(Me.cboPresentacion.SelectedItem, Presentacion).NombrePresentacion & ".xls"
      excel = New Application
      excel.ScreenUpdating = False
      excel.DisplayAlerts = False

      Libro = modExcel.AbrirPlantilla(excel, Me.sfdDialogo, AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\RegistroNotasExportar.xlsx")
      If Libro IsNot Nothing Then

        ruta = Me.sfdDialogo.FileName
        For g As Integer = 0 To ruta.Length - 1
          If ruta.Chars(g) = "\" Then
            pos = g
          End If
        Next
        ruta = Microsoft.VisualBasic.Left(ruta, pos + 1)
        sw = 1

        If sw = 1 And Me.cboPresentacion.SelectedIndex > -1 Then

          If Me.Docentes.Count > 0 Then
            Me.LlenarHojasExcel(Me.Docentes, Hoja, Libro)
            Me.EliminarHoja(Libro, excel, Hoja)
            Me.pbAvance.Value = Me.pbAvance.Maximum

            MessageBox.Show("Archivo exportado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            excel.ScreenUpdating = True
          End If

        End If

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Me.pbAvance.Value = 0
    Finally
      If Hoja IsNot Nothing Then
        System.Runtime.InteropServices.Marshal.ReleaseComObject(Hoja)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(Libro)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(excel)
      End If

      Hoja = Nothing
      Libro = Nothing
      excel = Nothing

      proc = Process.GetProcessesByName("EXCEL")
      For Each p As Process In proc
        p.Kill()
      Next
      proc = Nothing
    End Try

    Me.pbAvance.Value = 0
  End Sub

  Private Sub LlenarHojasExcel(ByVal lm As List(Of Docente), ByVal Hoja As Worksheet,
                              ByVal Libro As Workbook)

    Dim nombreHoja As String = "", i As Integer, av As Integer
    Dim celda As Range
    Dim rn As New RNNotaLectura
    Dim rnSeccion As New RNSeccion, rnNivel As New RNNivel
    i = 1
    For Each wDocente As Docente In lm

      Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
      Hoja.Select()
      Hoja.Copy(, Hoja)

      celda = Hoja.Range("C6")
      Hoja.Range("C6").Value = wDocente.NombreCompleto
      Hoja.Range("C7").Value = wDocente.Codigo
      Hoja.Range("F6").Value = Me.cboPresentacion.Text
      Hoja.Range("F7").Value = Me.cboPresentacion.SelectedValue
      nombreHoja = wDocente.ApellidoPaterno & " " & wDocente.ApellidoMaterno
      ExportarAlumnoPlanLector(wDocente, celda)

      Hoja.Select()
      Hoja.Name = i & "-" & nombreHoja
      Hoja.Protect(CLAVE)

      av = CInt(Math.Floor(100 / lm.Count))
      Me.pbAvance.Value += av
      i += 1
    Next
   

  End Sub


  Private Sub ExportarAlumnoPlanLector(ByVal mat As Docente, ByVal wCelda As Range)
    Dim rnNL As New RNNotaLectura
    Dim lNot As List(Of NotaLectura) = Nothing
    Dim ptjeTotal As Integer = 0, i As Integer

    lNot = rnNL.ListarAlumnosPresentacionDocente(DirectCast(cboPresentacion.SelectedItem, Presentacion), moAnioActual, mat)

    wCelda = wCelda.Offset(4, -2)
    i = 1
    For Each Alu As NotaLectura In lNot
      wCelda.Value = i
      wCelda.Offset(0, 1).Value = Alu.Matricula.Numero
      wCelda.Offset(0, 2).Value = Alu.Seccion
      wCelda.Offset(0, 3).Value = Alu.Matricula.Alumno.NombreCompleto
      If Alu.Nota.Length > 0 Then
        wCelda.Offset(0, 4).Value = Alu.Nota
        wCelda.Offset(0, 7).Value = Alu.NotaRecuperacion
      End If
      For j As Integer = 4 To 6
        With wCelda.Offset(0, j).Validation
          .Add(XlDVType.xlValidateList, XlDVAlertStyle.xlValidAlertStop, 1, "AD, A, B, C, NP")
          .ErrorMessage = "La calificación no es válida. (AD, A, B, C, NP)"
        End With
        j += 1
      Next

      
      wCelda.Offset(0, 5).Value = Alu.ProgLectura.Libro.Titulo
      wCelda.Offset(0, 6).Value = Alu.ProgLectura.Codigo
      wCelda.Offset(0, 8).Value = Alu.LibroRecuperacion

      i += 1
      wCelda = wCelda.Offset(1, 0)
    Next
  End Sub

  Private Sub EliminarHoja(ByVal Libro As Workbook, ByVal excel As Application, ByVal Hoja As Worksheet)

    Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
    Hoja.Select()
    Hoja.Delete()

    Hoja = CType(Libro.Worksheets(1), Worksheet)
    Hoja.Select()

    If Me.cboPresentacion.SelectedIndex > -1 Then
      excel.ActiveWorkbook.SaveAs(Me.sfdDialogo.FileName, _
            Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
    End If
  End Sub


  Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
    Dim rn As New RNNotaLectura
    Dim excel As Application = Nothing
    Dim libro As Workbook = Nothing
    Dim hojaNotas As Worksheet
    Dim Notas As List(Of NotaLectura) = Nothing
    Dim celda As Range

    Me.ofdDialogo.FileName = ""
    Me.ofdDialogo.Filter = "Documentos de excel(*.xlsx)|*.xlsx"
    Me.ofdDialogo.ShowDialog()
    If Me.ofdDialogo.FileName.Length > 0 Then
      Try
        excel = New Application
        excel.ScreenUpdating = False
        excel.DisplayAlerts = False
        libro = excel.Workbooks.Open(Me.ofdDialogo.FileName)
        hojaNotas = DirectCast(libro.Worksheets.Item("Datos"), Worksheet)
        celda = hojaNotas.Range(CELDA_INICIO).Offset(1, 1)
        Notas = New List(Of NotaLectura)
        While celda.Value IsNot Nothing
          If celda.Offset(0, 3).Value IsNot Nothing Then
            Notas.Add(New NotaLectura)
            With Notas.Item(Notas.Count - 1)
              .Matricula = New Matricula With {.Numero = CInt(celda.Value)}
              .ProgLectura = New ProgramacionLectura With {.Codigo = CInt(celda.Offset(0, 5).Value)}
              .Nota = celda.Offset(0, 3).Value.ToString
              .Personal = mOUsuario.Persona.Codigo
            End With
          Else
            Notas.Clear()
            Throw New Exception("Una o mas calificaciones no se han registrado")
          End If
          celda = celda.Offset(1, 0)
        End While
        rn = New RNNotaLectura
        rn.RegistrarNotas(Notas)

        MessageBox.Show("Se han importado todos las calificaciones exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        rn = Nothing
        If Notas IsNot Nothing Then
          Notas.Clear()
        End If
        Notas = Nothing
        If libro IsNot Nothing Then
          libro.Close()
        End If
        If excel IsNot Nothing Then
          excel.DisplayAlerts = True
          excel.ScreenUpdating = True
          excel.Quit()
        End If
        libro = Nothing
        excel = Nothing
      End Try
    End If
  End Sub

  'Tania Incio    
  Private Sub btnRecuperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecuperacion.Click
    Me.Recuperacion()
  End Sub

  Private Sub Recuperacion()
    Dim frm As New frmRecuperacionNota
    Dim obj As RNLibro = Nothing
    Dim notaL = DirectCast(Me.dgvNotas.CurrentRow.DataBoundItem, NotaLectura)
    Dim nota = Me.dgvNotas.CurrentRow.Cells.Item(2).Value.ToString.Trim
    Dim notaRec = Me.dgvNotas.CurrentRow.Cells.Item(4).Value.ToString.Trim

    If nota = "C" Or nota = "D" Or nota = "NP" Then
      frm.Gestionar(DirectCast(Me.dgvNotas.CurrentRow.DataBoundItem, NotaLectura), notaRec)
      frm.Dispose()
      frm = Nothing
      Me.dgvNotas.Refresh()
      If Not Me.dgvNotas.CurrentRow.Cells.Item(4).Value.ToString.Equals("") Then
        Me.dgvNotas.CurrentRow.Cells.Item(2).ReadOnly = True
      End If
    Else
      MessageBox.Show("El alumno no necesita recuperación", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  'Tania Incio
  Private Sub RegistrarNotaRecuperacion(ByVal nroMat As Integer, ByVal letra As String, ByVal i As Integer)
    Dim obj As New RNNotaLectura
    Dim NotaLect As NotaLectura
    Dim coment As String = "Nota de Recuperación"
    Dim codPL As Integer = 0
    Dim codLibro As Integer = 0
    Dim daoL As New RNLibro

    'letra = letra.Substring(2, letra.Length - 2)
    Try
      codLibro = daoL.ListarLibros(Me.dgvNotas.Rows(i).Cells("cdLibroRecuperacion").Value.ToString).Item(0).Codigo
      codPL = CType(Me.dgvNotas.Rows(i).DataBoundItem, NotaLectura).ProgLectura.Codigo
      NotaLect = obj.LeerNota(New NotaLectura(New Matricula(nroMat), "", "", New ProgramacionLectura(codPL)))
      If NotaLect.Nota <> letra Then
        obj.RegistrarNotaRecuperacion(NotaLect.Codigo, mOUsuario.Persona.Codigo, codPL, codLibro, letra, coment)
      End If

    Catch ex As Exception
      Throw ex
    Finally
      obj = Nothing
    End Try

  End Sub

End Class