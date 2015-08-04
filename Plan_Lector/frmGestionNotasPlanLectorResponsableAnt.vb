Imports Microsoft.Office.Interop.Excel

Public Class frmGestionNotasPlanLectorResponsableAnt

  'Private Const CLAVE As String = "CETI"
  'Private Const CELDA_INICIO As String = "A12"

  'Private sfdDialogo As SaveFileDialog

  'Private Shared frm As frmGestionNotasPlanLectorResponsableAnt

  'Private codigoEstado As Integer = 0
  'Private AlumnosNotas As List(Of NotaLectura)

  'Private Sub New()
  '  ' Llamada necesaria para el Diseñador de Windows Forms.
  '  InitializeComponent()

  '  ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
  'End Sub

  'Private Sub frmGestionNotasPlanLector_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
  '  If MessageBox.Show("¿Está seguro que desea cerrar la ventana?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
  '    e.Cancel = True
  '  End If
  'End Sub

  'Private Sub frmGestionNotasPlanLector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
  '  Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
  '  Me.btncancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
  '  Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
  '  Me.txtAnio.Text = moAnioActual.Anio
  '  Me.CargarPresentaciones()
  '  Me.CargarDocentes()
  'End Sub

  'Public Sub CargarDocentes()
  '  Dim ListD As New List(Of Docente)
  '  Dim objDoc As New RNDocente

  '  ListD = objDoc.Listar
  '  objDoc = Nothing
  '  Me.cboDocente.DisplayMember = "NombreCompleto"
  '  Me.cboDocente.ValueMember = "codigo"
  '  Me.cboDocente.DataSource = ListD
  '  ListD = Nothing
  'End Sub

  'Private Sub CargarPresentaciones()
  '  Dim obj As New RNPresentacion
  '  Dim lpres As List(Of Presentacion)

  '  lpres = obj.ListarPresVigentes(moAnioActual.Anio)
  '  obj = Nothing
  '  cboPresentacion.DisplayMember = "Numero"
  '  cboPresentacion.ValueMember = "Codigo"
  '  cboPresentacion.DataSource = lpres
  'End Sub

  'Public Shared Sub Gestionar(ByVal wPadre As Form, ByVal wDialogo As SaveFileDialog)
  '  If frmGestionNotasPlanLectorResponsableAnt.frm Is Nothing Then
  '    frmGestionNotasPlanLectorResponsableAnt.frm = New frmGestionNotasPlanLectorResponsableAnt
  '    frmGestionNotasPlanLectorResponsableAnt.frm.MdiParent = wPadre
  '    frmGestionNotasPlanLectorResponsableAnt.frm.sfdDialogo = wDialogo
  '    frmGestionNotasPlanLectorResponsableAnt.frm.Show()
  '    frmGestionNotasPlanLectorResponsableAnt.frm.WindowState = FormWindowState.Maximized
  '  Else
  '    frmGestionNotasPlanLectorResponsableAnt.frm.Activate()
  '  End If
  'End Sub

  'Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
  '  Me.Close()
  'End Sub

  'Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
  '  Me.Listar()
  'End Sub

  'Private Sub Listar()
  '  If Me.cboPresentacion.SelectedIndex > -1 AndAlso Me.cboSeccion.SelectedIndex > -1 Then
  '    Me.LimpiarAlumnos()
  '    Me.MostrarAlumnosPresentacion()

  '    Me.dgvNotas.ClearSelection()
  '  ElseIf Me.cboPresentacion.SelectedIndex = -1 Then
  '    MessageBox.Show("Debe seleccionar la presentación", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
  '    Me.cboPresentacion.Focus()
  '  Else
  '    MessageBox.Show("Debe seleccionar la sección", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
  '    Me.cboSeccion.Focus()
  '  End If

  '  Me.WindowState = FormWindowState.Maximized
  'End Sub

  'Private Sub MostrarAlumnosPresentacion()
  '  Dim obj As New RNNotaLectura

  '  AlumnosNotas = obj.ListarAlumnosPresentacionDocente(DirectCast(cboSeccion.SelectedItem, Seccion), DirectCast(cboPresentacion.SelectedItem, Presentacion), moAnioActual.Anio, DirectCast(Me.cboDocente.SelectedItem, Docente))
  '  obj = Nothing
  '  If AlumnosNotas.Count > 0 Then
  '    Me.dgvNotas.AutoGenerateColumns = False
  '    Me.dgvNotas.DataSource = AlumnosNotas

  '    For Each N In AlumnosNotas
  '      If N.Nota <> "" Then
  '        codigoEstado = 1
  '        Exit For
  '      End If
  '    Next

  '    Me.txtTotal.Text = AlumnosNotas.Count.ToString
  '    btnRegistrar.Enabled = True
  '  Else
  '    Me.txtTotal.Text = AlumnosNotas.Count.ToString
  '    btnRegistrar.Enabled = False
  '  End If
  'End Sub

  'Private Sub LimpiarAlumnos()
  '  Me.dgvNotas.ClearSelection()
  '  Try
  '    Me.dgvNotas.DataSource = Nothing
  '    Me.dgvNotas.Rows.Clear()

  '    Me.txtTotal.Text = ""

  '  Catch ex As Exception
  '    MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
  '  End Try
  'End Sub

  'Private Sub Limpiar()
  '  Me.cboPresentacion.SelectedIndex = -1
  '  LimpiarAlumnos()
  '  codigoEstado = 0

  '  Me.btnRegistrar.Text = "&Guardar"
  '  Me.btnRegistrar.Enabled = False
  'End Sub

  'Private Sub dgvNotas_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvNotas.CellValidating
  '  Dim letra As String = ""
  '  letra = e.FormattedValue.ToString().ToUpper

  '  If dgvNotas.CurrentCell.ColumnIndex = 2 Then
  '    If Not (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
  '      If Not (letra = "A" Or letra = "B" Or letra = "C" Or letra = "AD" Or letra = "NP") Then
  '        MessageBox.Show("Sólo puede ingresar: A,B,C,AD y NP", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
  '        e.Cancel = True
  '      End If
  '    End If
  '  End If
  'End Sub

  'Private Sub dgvNotas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvNotas.KeyDown
  '  If dgvNotas.CurrentCell IsNot Nothing Then
  '    With dgvNotas.CurrentCell
  '      If .ColumnIndex = 2 Then
  '        If e.KeyCode = Keys.Delete Then
  '          dgvNotas.CurrentCell.Value = Nothing
  '        End If
  '      End If
  '    End With
  '  End If
  'End Sub

  'Private Sub dgvNotas_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvNotas.EditingControlShowing
  '  AddHandler e.Control.KeyPress, AddressOf Validar
  '  RemoveHandler e.Control.KeyPress, AddressOf Validar
  'End Sub

  'Private Sub Validar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
  '  'Validar Fila seleccionada
  '  Dim drwFila As DataGridViewCell = dgvNotas.CurrentCell()

  '  If drwFila.ColumnIndex = 2 Then
  '    e.KeyChar = UCase(e.KeyChar)
  '    If (e.KeyChar = ChrW(Keys.A)) Or (e.KeyChar = ChrW(Keys.B)) Or (e.KeyChar = ChrW(Keys.C)) Or (e.KeyChar = ChrW(Keys.D)) _
  '        Or (e.KeyChar = ChrW(Keys.N)) Or (e.KeyChar = ChrW(Keys.P)) Or (e.KeyChar = ChrW(Keys.Back)) Then
  '      e.Handled = False
  '    Else
  '      MessageBox.Show("Sólo puede ingresar: A,B,C,AD y NP", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
  '      e.Handled = True
  '    End If
  '  End If
  'End Sub

  'Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
  '  If Me.dgvNotas.Rows.Count > 0 Then
  '    If codigoEstado = 0 Then
  '      Me.RegistrarNota()
  '      MessageBox.Show("Las notas se registraron con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
  '      Me.Limpiar()
  '      Me.Listar()
  '    Else
  '      Me.RegistrarNuevaNota()
  '      MessageBox.Show("Actualización realizada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
  '      Me.Limpiar()
  '      Me.Listar()
  '    End If
  '  Else
  '    Limpiar()
  '    MessageBox.Show("No ha ingresado notas", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
  '  End If
  'End Sub

  'Private Sub RegistrarNota()
  '  Dim obj As RNNotaLectura = Nothing
  '  Dim letra As String = ""
  '  Dim coment As String = ""
  '  Dim nroMat As Integer = 0
  '  Dim codPL As Integer = 0

  '  Try
  '    obj = New RNNotaLectura
  '    For i As Integer = 0 To Me.dgvNotas.RowCount - 1

  '      nroMat = CType(Me.dgvNotas.Rows(i).DataBoundItem, NotaLectura).Matricula.Numero
  '      codPL = CType(Me.dgvNotas.Rows(i).DataBoundItem, NotaLectura).ProgLectura.Codigo

  '      If CStr(Me.dgvNotas.Rows(i).Cells("cdNota").EditedFormattedValue) <> "" Then
  '        letra = (Me.dgvNotas.Rows(i).Cells("cdNota").EditedFormattedValue).ToString.ToUpper
  '        Select Case letra
  '          Case "C"
  '            coment = "Requiere Recuperación"
  '          Case "NP"
  '            coment = "No se Presentó"
  '        End Select
  '        obj.Registrar(New NotaLectura(0, letra, coment, Now, True, New ProgramacionLectura(codPL), New Matricula(nroMat), mOUsuario.Persona.Codigo))
  '      End If

  '    Next
  '  Catch ex As Exception
  '    MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
  '  Finally
  '    obj = Nothing
  '  End Try

  'End Sub

  'Private Sub RegistrarNuevaNota()
  '  Dim obj As RNNotaLectura = Nothing
  '  Dim letra As String = ""
  '  Dim NotaLect As NotaLectura
  '  Dim coment As String = ""
  '  Dim nroMat As Integer = 0
  '  Dim codPL As Integer = 0

  '  Try
  '    obj = New RNNotaLectura

  '    For i As Integer = 0 To Me.dgvNotas.RowCount - 1

  '      nroMat = CType(Me.dgvNotas.Rows(i).DataBoundItem, NotaLectura).Matricula.Numero
  '      codPL = CType(Me.dgvNotas.Rows(i).DataBoundItem, NotaLectura).ProgLectura.Codigo

  '      If Me.dgvNotas.Rows(i).Cells("cdNota").EditedFormattedValue.ToString <> "" Then
  '        letra = (Me.dgvNotas.Rows(i).Cells("cdNota").EditedFormattedValue).ToString.ToUpper
  '        Select Case letra
  '          Case "C"
  '            coment = "Requiere Recuperación"
  '          Case "D"
  '            coment = "Requiere Recuperación"
  '          Case "NP"
  '            coment = "No se Presento"
  '        End Select

  '        NotaLect = obj.LeerNota(New NotaLectura(New Matricula(nroMat), "", "", New ProgramacionLectura(codPL)))
  '        If NotaLect Is Nothing Then
  '          obj.Registrar(New NotaLectura(0, letra, coment, Now, True, New ProgramacionLectura(codPL), _
  '                                        New Matricula(nroMat), mOUsuario.Persona.Codigo))
  '        Else
  '          If letra.Trim <> NotaLect.Nota.Trim Then
  '            obj.RegistrarNuevaNota(New NotaLectura(NotaLect.Codigo, letra, coment, Now, True, _
  '                                    New ProgramacionLectura(codPL), New Matricula(nroMat), mOUsuario.Persona.Codigo))
  '          End If
  '        End If
  '      End If

  '    Next
  '  Catch ex As Exception
  '    MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

  '  End Try

  'End Sub

  'Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
  '  Me.Limpiar()
  'End Sub

  'Private Sub frmGestionNotasPlanLectorResponsable_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
  '  frmGestionNotasPlanLectorResponsableAnt.frm = Nothing
  'End Sub

  'Private Sub cboSeccion_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSeccion.Enter
  '  Dim rn As RNProgramacionLectura
  '  Dim secciones As List(Of Seccion)

  '  If Me.cboDocente.SelectedIndex > -1 AndAlso Me.cboPresentacion.SelectedIndex > -1 Then
  '    rn = New RNProgramacionLectura
  '    secciones = rn.listarSeccionesACargo(DirectCast(Me.cboDocente.SelectedItem, Docente), DirectCast(Me.cboPresentacion.SelectedItem, Presentacion))
  '    rn = Nothing

  '    Me.cboSeccion.ValueMember = "NivelNumeroLetra"
  '    Me.cboSeccion.DisplayMember = "NivelNumeroLetra"
  '    Me.cboSeccion.DataSource = secciones
  '    Me.cboSeccion.SelectedIndex = -1
  '  ElseIf Me.cboDocente.SelectedIndex = -1 Then
  '    MessageBox.Show("Debe seleccionar un docente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
  '    Me.cboDocente.Focus()
  '  Else
  '    MessageBox.Show("Debe seleccionar una presentación", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
  '    Me.cboPresentacion.Focus()
  '  End If
  'End Sub

  'Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
  '  Dim excel As Application = Nothing
  '  Dim libro As Workbook = Nothing

  '  Try
  '    Me.sfdDialogo.FileName = "REGISTRO DE NOTAS " & Me.cboDocente.Text & " - Rotación " & Me.cboPresentacion.Text & "-" & Me.cboSeccion.Text
  '    Me.sfdDialogo.Filter = "Hoja de cálculo 2007(*.xlsx)|*.xlsx"
  '    excel = New Application
  '    excel.ScreenUpdating = False
  '    excel.DisplayAlerts = False
  '    libro = modExcel.AbrirPlantilla(excel, Me.sfdDialogo, AppDomain.CurrentDomain.BaseDirectory & "Plantillas\RegistroNotas.xlsx")
  '    With DirectCast(libro.Worksheets.Item("Datos"), Worksheet)
  '      .Range("C6").Value = Me.cboDocente.Text
  '      .Range("C7").Value = Me.cboDocente.SelectedValue
  '      .Range("E6").Value = Me.cboPresentacion.Text
  '      .Range("E7").Value = Me.cboPresentacion.SelectedValue
  '      .Range("E9").Value = Me.cboSeccion.Text
  '      .Range("E10").Value = moAnioActual.Anio & "-" & DirectCast(Me.cboSeccion.SelectedItem, Seccion).Grado.Codigo & "-" & DirectCast(Me.cboSeccion.SelectedItem, Seccion).Letra

  '      Me.ExportarDatos(.Range(CELDA_INICIO).Offset(1, 0))
  '      modExcel.BordesTodo(.Range(.Range(CELDA_INICIO), .Range(CELDA_INICIO).Offset(Me.AlumnosNotas.Count, 4)))

  '      .Protect(CLAVE)
  '    End With

  '    libro.SaveAs(Me.sfdDialogo.FileName)
  '    MessageBox.Show("La exportación se realizó exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
  '  Catch ex As Exception
  '    MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
  '  Finally
  '    If libro IsNot Nothing Then
  '      libro.Close()
  '    End If
  '    If excel IsNot Nothing Then
  '      excel.ScreenUpdating = True
  '      excel.Quit()
  '    End If
  '    libro = Nothing
  '    excel = Nothing
  '  End Try
  'End Sub

  'Private Sub ExportarDatos(ByVal wCelda As Range)
  '  Dim i As Integer = 1

  '  For Each Alu As NotaLectura In Me.AlumnosNotas
  '    wCelda.Value = i
  '    wCelda.Offset(0, 1).Value = Alu.Matricula.Numero
  '    wCelda.Offset(0, 2).Value = Alu.Matricula.Alumno.NombreCompleto
  '    If Alu.Nota.Length > 0 Then
  '      wCelda.Offset(0, 3).Value = Alu.Nota
  '    End If
  '    With wCelda.Offset(0, 3).Validation
  '      .Add(XlDVType.xlValidateList, XlDVAlertStyle.xlValidAlertStop, 1, "AD, A, B, C, NP")
  '    End With
  '    wCelda.Offset(0, 4).Value = Alu.ProgLectura.Libro.Titulo
  '    wCelda.Offset(0, 5).Value = Alu.ProgLectura.Codigo

  '    i += 1
  '    wCelda = wCelda.Offset(1, 0)
  '  Next
  'End Sub



End Class