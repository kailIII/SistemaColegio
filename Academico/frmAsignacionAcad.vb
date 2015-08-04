Imports Microsoft.VisualBasic.Strings

Public Class frmAsignacionAcad
  Private HorasCurAsig As Integer
  Private codigo As Integer
  Private sw As Integer
  'Public Event loading()

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub frmAsignacionAcad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.cboDocente.Items.Clear()
    Loading()
  End Sub

  Public Sub Loading()
    Me.btnGuardar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnBuscar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Buscar.png")

    'Me.cboListDoc.Items.Clear()
    'Me.lblHorasTot.Text = "0"
    Me.txthours.Text = "0"


    'AgregarNiveles(Me.cboNivel2, 1)
    LimpiarDatos_Asignacion()
  End Sub

  Public Sub AgregarNiveles(ByVal cbo As ComboBox, ByVal estado As Integer)
    Dim obj As New RNNivel
    Dim ln As List(Of Nivel)

    ln = obj.Listar
    If estado = 1 Then
      ln.Insert(0, New Nivel("-1", "Todos los Niveles", ""))
    End If
    cbo.DisplayMember = "Nombre"
    cbo.ValueMember = "Nombre"
    cbo.DataSource = ln
    sw = 1
  End Sub

  Public Sub LimpiarDatos_Asignacion()
    AgregarNiveles(Me.cboNivel1, 0)
    'Me.cboNivel1.SelectedIndex = 0
    Me.txtTotHoras.TextAlign = ContentAlignment.MiddleCenter
    ListarDocentes(Me.cboDocente, 0)
    'ListarDocentes(Me.cboListDoc, 1)
    Limpiar()
    ListarCursos_Grado()
    AgregarEstado()
  End Sub

  Public Sub ListarCursos_Grado()
    Dim obj As New RNCurso
    Dim lc As List(Of Curso)

    lc = obj.ListarCur_Grados(New Seccion(New AnioLectivo(moAnioActual.anio), New Grado(0, 0, "", New Nivel(CType(cboNivel1.SelectedItem, Nivel).CodigoModular, "", ""), "", ""), CChar("")))

    Me.dgCursos.AutoGenerateColumns = False
    Me.dgCursos.DataSource = lc
    Me.dgCursos.Columns(0).DataPropertyName = "Grado_Seccion"
    Me.dgCursos.Columns(1).DataPropertyName = "Nombre"
  End Sub

  Public Sub AgregarEstado()
    Dim i As Integer
    For i = 0 To Me.dgCursos.RowCount - 1
      Dim objG As New RNGrado
      Dim objC As New RNCurso
      Dim objCA As New RNCargaAcademica
      Dim codGrado, codCurso As Integer
      Dim cadena As String
      Dim numero As Integer

      cadena = CStr(Me.dgCursos.Item(0, i).Value)
      numero = CInt(Strings.Left(cadena.Trim, 1))
      codGrado = objG.RetornaCG(New Seccion(0, numero, CType(Me.cboNivel1.SelectedItem, Nivel).CodigoModular, "", "A"c))
      codCurso = objC.RetornaCodCur(New Curso(codGrado, CStr(Me.dgCursos.Item(1, i).Value)))

      If objCA.Busca(New CargaAcademica(codCurso, codGrado, CChar(Strings.Right(cadena.Trim, 1)))) > 0 Then
        Me.dgCursos.Item(2, i).Value = "Asig."
      End If
    Next
  End Sub

  Public Sub ListarDocentes(ByVal cboDocente As ComboBox, ByVal estado As Integer)
    Dim obj As New RNDocente
    Dim cboList As List(Of Docente)

    cboList = obj.ListarDoc("")
    If estado = 1 Then
      cboList.Insert(0, New Docente(0, "", "Todos los Docentes", ""))
    End If
    cboDocente.DisplayMember = "NombreCompleto"
    cboDocente.ValueMember = "ApePaterno" & " " & "ApeMaterno" & " " & "Nombre"
    cboDocente.DataSource = cboList
  End Sub

  Private Sub cboDocente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDocente.Click
    MostrarEspecialidad()
  End Sub

  Private Sub cboDocente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDocente.LostFocus
    If Me.cboDocente.Text = "" Then
      Me.txtEspecialidad.Text = ""
      Me.txtTotHoras.Text = "0"
      Me.txthours.Text = "0"
      HorasCurAsig = 0
      AcumularHoras(Me.dgCursosAsig, 0)
      'Else
      'errAsignAcad.SetError(Me.cboDocente, Nothing)
    End If
  End Sub

  Private Sub cboDocente_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDocente.SelectedIndexChanged
    MostrarEspecialidad()
  End Sub

  Public Sub MostrarEspecialidad()
    If Me.cboDocente.SelectedIndex >= 0 Then
      Dim objE As New RNEspecialidad
      Dim objD As New RNDocente
      Dim doc2 As Docente = Nothing

      If Me.cboDocente.Text <> "" Then
        doc2 = objD.Leer(New Docente(CType(cboDocente.SelectedItem, Docente).Codigo))
        Me.txtEspecialidad.Text = doc2.Especialidad.Nombre
        MostrarHorasCursosAsig(doc2.Codigo)
      End If
    End If
  End Sub

  Public Sub MostrarHorasCursosAsig(ByVal wCodigo As Integer)
    Dim obj As New RNCargaAcademica
    HorasCurAsig = obj.RetornaHoras(New CargaAcademica(wCodigo, 0, 0, ""))
    Me.txthours.Text = HorasCurAsig.ToString
    If Me.dgCursosAsig.RowCount = 0 Then
      Me.txtTotHoras.Text = HorasCurAsig.ToString  'HorasCurAsig --> horas acumuladas del docente de sus cursos ya asignados
    End If

    If codigo <> wCodigo Then
      If Me.dgCursosAsig.RowCount > 0 Then
        AcumularHoras(Me.dgCursosAsig, 0)
      End If
    End If
    codigo = wCodigo
  End Sub

  Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click
    Dim cur As Curso = Nothing
    Dim i, sw As Integer
    Dim posSelec As Integer

    If Me.dgCursos.RowCount > 0 Then
      If Me.cboDocente.Text <> "" Then

        posSelec = Me.dgCursos.Rows.IndexOf(Me.dgCursos.CurrentRow)
        If CType(Me.dgCursos.Item(2, posSelec).Value, String) <> "Asig." Then
          cur = CType(Me.dgCursos.CurrentRow.DataBoundItem, Curso)
          For i = 0 To Me.dgCursosAsig.RowCount - 1
            If Me.dgCursosAsig.Item(0, i).Value.ToString = cur.Grado_Seccion And Me.dgCursosAsig.Item(2, i).Value.ToString = cur.Nombre And Me.dgCursosAsig.Item(3, i).Value.ToString = Me.cboNivel1.Text Then
              sw = 1
              Exit For
            End If
          Next

          If sw = 0 Then
            Me.dgCursosAsig.RowCount = Me.dgCursosAsig.RowCount + 1
            Me.dgCursosAsig.Item(0, Me.dgCursosAsig.RowCount - 1).Value = cur.Grado_Seccion
            Me.dgCursosAsig.Item(1, Me.dgCursosAsig.RowCount - 1).Value = cur.NumeroHoras
            Me.dgCursosAsig.Item(2, Me.dgCursosAsig.RowCount - 1).Value = cur.Nombre
            Me.dgCursosAsig.Item(3, Me.dgCursosAsig.RowCount - 1).Value = Me.cboNivel1.Text
            Me.dgCursosAsig.Item(4, Me.dgCursosAsig.RowCount - 1).Value = CType(Me.cboNivel1.SelectedItem, Nivel).CodigoModular
            Me.btnRetirar.Enabled = True
            Me.btnQuitar.Enabled = True
            AcumularHoras(Me.dgCursosAsig, 0)
          End If
        Else
          MsgBox("Curso seleccionado ya esta asignado", MsgBoxStyle.Exclamation, "")
        End If
      Else
        MsgBox("Seleccione docente por favor", MsgBoxStyle.Critical, "")
      End If
    End If
  End Sub

  Public Sub AcumularHoras(ByVal dg As DataGridView, ByVal estado As Integer)
    Dim i, k, horas As Integer
    horas = 0
    If estado = 0 Then
      k = 1
    Else
      k = 4
    End If
    For i = 0 To dg.RowCount - 1
      horas += CInt(dg.Item(k, i).Value)
    Next
    If estado = 0 Then
      Me.txtTotHoras.Text = CStr(horas + HorasCurAsig)
    Else
      'Me.lblHorasTot.Text = CStr(horas)
    End If
  End Sub

  Private Sub btnRetirar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetirar.Click
    If Me.dgCursosAsig.RowCount > 0 Then
      Dim i As Integer
      For i = Me.dgCursosAsig.Rows.IndexOf(Me.dgCursosAsig.CurrentRow) To Me.dgCursosAsig.RowCount - 2
        If Me.dgCursosAsig.RowCount - 1 > 0 Then
          Me.dgCursosAsig.Item(0, i).Value = Me.dgCursosAsig.Item(0, i + 1).Value
          Me.dgCursosAsig.Item(1, i).Value = Me.dgCursosAsig.Item(1, i + 1).Value
          Me.dgCursosAsig.Item(2, i).Value = Me.dgCursosAsig.Item(2, i + 1).Value
          Me.dgCursosAsig.Item(3, i).Value = Me.dgCursosAsig.Item(3, i + 1).Value
        End If
      Next
      Me.dgCursosAsig.Item(0, Me.dgCursosAsig.RowCount - 1).Value = ""
      Me.dgCursosAsig.Item(1, Me.dgCursosAsig.RowCount - 1).Value = ""
      Me.dgCursosAsig.Item(2, Me.dgCursosAsig.RowCount - 1).Value = ""
      Me.dgCursosAsig.Item(3, Me.dgCursosAsig.RowCount - 1).Value = ""
      Me.dgCursosAsig.RowCount = Me.dgCursosAsig.RowCount - 1
      AcumularHoras(Me.dgCursosAsig, 0)
      If Me.dgCursosAsig.RowCount = 0 Then
        Me.btnRetirar.Enabled = False
        Me.btnQuitar.Enabled = False
      End If

    End If
  End Sub

  Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    Dim d As Docente = Nothing
    Dim cod, i, numero As Integer
    Dim cad As String

    If Me.cboDocente.Text <> "" Then
      If Me.dgCursosAsig.RowCount > 0 Then

        d = CType(Me.cboDocente.SelectedItem, Docente)
        For i = 0 To Me.dgCursosAsig.RowCount - 1
          Dim objG As New RNGrado
          Dim objCA As New RNCargaAcademica
          Dim objC As New RNCurso
          cad = CType(Me.dgCursosAsig.Item(0, i).Value, String)
          numero = CInt(Strings.Left(cad.Trim, 1))

          cod = objG.RetornaCG(New Seccion(0, numero, Me.dgCursosAsig.Item(4, i).Value.ToString, "", "A"c))
          objCA.Registrar(New CargaAcademica(d.Codigo, cod, objC.RetornaCodCur(New Curso(cod, Me.dgCursosAsig.Item(2, i).Value.ToString)), Strings.Right(cad.Trim, 1)), New AnioLectivo(moAnioActual.anio))
          objG = Nothing
          objCA = Nothing
          objC = Nothing
        Next
        MsgBox("Asignación de cursos con éxito", MsgBoxStyle.Information, "")
        Limpiar()
        AgregarEstado()
      Else
        MsgBox("Asigne cursos por favor ....", MsgBoxStyle.Critical, "")
      End If
    Else
      MsgBox("Seleccione Docente por favor ....", MsgBoxStyle.Critical, "")
    End If
  End Sub

  Public Sub Limpiar()
    Me.cboDocente.Text = ""
    Me.txtEspecialidad.Text = ""
    Me.txtTotHoras.Text = "0"
    Me.txthours.Text = "0"
    Me.dgCursosAsig.Rows.Clear()
    Me.btnRetirar.Enabled = False
    Me.btnQuitar.Enabled = False
  End Sub

  Private Sub cboNivel1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboNivel1.SelectedValueChanged
    If sw = 1 Then
      ListarCursos_Grado()
      AgregarEstado()
    End If
  End Sub

  'Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  Dim i As Integer

  '  ListarCursosAsignados()
  '  AcumularHoras(Me.dgbuscar, 1)
  '  For i = 0 To Me.dgbuscar.RowCount - 1
  '    Me.dgbuscar.Item(0, i).Value() = i + 1
  '  Next
  '  If Me.cboListDoc.SelectedIndex <> 0 Then
  '    Me.lblTotHorasAsig.Visible = True
  '    Me.lblHorasTot.Visible = True
  '  Else
  '    Me.lblTotHorasAsig.Visible = False
  '    Me.lblHorasTot.Visible = False
  '  End If
  'End Sub

  'Public Sub ListarCursosAsignados()
  '  Dim codigoModular As String = Nothing
  '  Dim obj As New RNCargaAcademica
  '  Dim D As Docente = Nothing
  '  Dim lcd As List(Of CargaAcademica)

  '  If Me.cboNivel2.SelectedIndex = 0 Then
  '    codigoModular = ""
  '  Else
  '    codigoModular = CType(Me.cboNivel2.SelectedItem, Nivel).CodigoModular
  '  End If

  '  If Me.cboListDoc.Text <> "" Then
  '    D = CType(Me.cboListDoc.SelectedItem, Docente)
  '  Else
  '    D = New Docente(0)
  '  End If

  '  lcd = obj.ListarCurDoc(New Seccion(New AnioLectivo(), New Grado(codigoModular), CChar("a"), New Docente(D.Codigo))) 'D.Codigo, codigoModular.Trim)
  '  Me.dgbuscar.AutoGenerateColumns = False
  '  Me.dgbuscar.DataSource = lcd
  '  Me.dgbuscar.Columns(1).DataPropertyName = "Nombre_Docente"
  '  Me.dgbuscar.Columns(2).DataPropertyName = "Nombre_Curso"
  '  Me.dgbuscar.Columns(3).DataPropertyName = "Nombre_Nivel"
  '  Me.dgbuscar.Columns(4).DataPropertyName = "Horas"
  '  Me.dgbuscar.Columns(5).DataPropertyName = "Grado_Seccion"
  'End Sub

  Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
    Me.dgCursosAsig.Rows.Clear()
    Me.btnRetirar.Enabled = False
    Me.btnQuitar.Enabled = False
    AcumularHoras(Me.dgCursosAsig, 0)
  End Sub

  'Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  LimpiarDatos_Asignacion()
  '  Me.tabAsignacion.SelectedTab = Me.tabAsignacion.TabPages(0)
  'End Sub

  'Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
  '  Dim obj As New RNCargaAcademica

  '  If Me.dgbuscar.SelectedRows.Count > 0 Then
  '    With CType(Me.dgbuscar.SelectedRows.Item(0).DataBoundItem, CargaAcademica)
  '      If MsgBox("Desea quitar el curso asignado al docente", MsgBoxStyle.YesNo, "AVISO") = MsgBoxResult.Yes Then
  '        obj.Eliminar(New CargaAcademica(.CodigoDocente, .CodigoGrado, .CodigoCurso, .Letra))
  '        ListarCursosAsignados()
  '        ListarCursos_Grado()
  '        AgregarEstado()
  '        AcumularHoras(Me.dgbuscar, 1)
  '      End If
  '    End With
  '  End If
  'End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Limpiar()
    AgregarEstado()
    'errAsignAcad.SetError(Me.cboDocente, Nothing)
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Me.Close()
    Dim frm As New frmBuscarCargaAcad
    frm.ShowDialog()
  End Sub

End Class