Public Class frmBuscarCargaAcad
  Private sw As Integer


  Private Sub frmBuscarCargaAcad_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    'frmAsignacionAcad.LimpiarDatos_Asignacion()
    Dim frm As New frmAsignacionAcad
    frm.Show()
    'frmAsignacionAcad.Loading()
    'AgregarNiveles(frmAsignacionAcad.cboNivel1, 0)
    'frmAsignacionAcad.cboNivel1.SelectedIndex = 0
    'RaiseEvent  frmAsignacionAcad.loading()
  End Sub

  Private Sub frmBuscarCargaAcad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.cboListDoc.Items.Clear()
    Me.lblHorasTot.Text = "0"
    AgregarNiveles(Me.cboNivel2, 1)
    frmAsignacionAcad.ListarDocentes(Me.cboListDoc, 1)
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
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

  Public Sub ListarCursosAsignados()
    Dim codigoModular As String = Nothing
    Dim obj As New RNCargaAcademica
    Dim D As Docente = Nothing
    Dim lcd As List(Of CargaAcademica)

    If Me.cboNivel2.SelectedIndex = 0 Then
      codigoModular = ""
    Else
      codigoModular = CType(Me.cboNivel2.SelectedItem, Nivel).CodigoModular
    End If

    If Me.cboListDoc.SelectedIndex > 0 Then
      D = CType(Me.cboListDoc.SelectedItem, Docente)
    Else
      D = New Docente(0)
    End If

    lcd = obj.ListarCurDoc(New Seccion(New AnioLectivo(), New Grado(codigoModular), CChar("a"), New Docente(D.Codigo))) 'D.Codigo, codigoModular.Trim)
    Me.dgbuscar.AutoGenerateColumns = False
    Me.dgbuscar.DataSource = lcd
    Me.dgbuscar.Columns(1).DataPropertyName = "Nombre_Docente"
    Me.dgbuscar.Columns(2).DataPropertyName = "Nombre_Curso"
    Me.dgbuscar.Columns(3).DataPropertyName = "Nombre_Nivel"
    Me.dgbuscar.Columns(4).DataPropertyName = "Horas"
    Me.dgbuscar.Columns(5).DataPropertyName = "Grado_Seccion"
  End Sub

  Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
    Dim obj As New RNCargaAcademica
    'Dim frm As New frmAsignacionAcad

    If Me.dgbuscar.SelectedRows.Count > 0 Then
      With CType(Me.dgbuscar.SelectedRows.Item(0).DataBoundItem, CargaAcademica)
        If MsgBox("Desea quitar el curso asignado al docente", MsgBoxStyle.YesNo, "AVISO") = MsgBoxResult.Yes Then
          obj.Eliminar(New CargaAcademica(.CodigoDocente, .CodigoGrado, .CodigoCurso, .Letra))
          ListarCursosAsignados()
          'ListarCursos_Grado()
          'AgregarEstado()
          AcumularHoras(Me.dgbuscar, 1)
        End If
      End With
    End If
  End Sub

  Public Sub ListarCursos_Grado()
    Dim obj As New RNCurso
    Dim lc As List(Of Curso)

    lc = obj.ListarCur_Grados(New Seccion(New AnioLectivo(moAnioActual.anio), New Grado(0, 0, "", New Nivel(CType(frmAsignacionAcad.cboNivel1.SelectedItem, Nivel).CodigoModular, "", ""), "", ""), CChar(""))) ')New Nivel())

    frmAsignacionAcad.dgCursos.AutoGenerateColumns = False
    frmAsignacionAcad.dgCursos.DataSource = lc
    frmAsignacionAcad.dgCursos.Columns(0).DataPropertyName = "Grado_Seccion"
    frmAsignacionAcad.dgCursos.Columns(1).DataPropertyName = "Nombre"
  End Sub
  Public Sub AgregarEstado()
    Dim i As Integer
    For i = 0 To frmAsignacionAcad.dgCursos.RowCount - 1
      Dim objG As New RNGrado
      Dim objC As New RNCurso
      Dim objCA As New RNCargaAcademica
      Dim codGrado, codCurso As Integer
      Dim cadena As String
      Dim numero As Integer

      cadena = CStr(frmAsignacionAcad.dgCursos.Item(0, i).Value)
      numero = CInt(Strings.Left(cadena.Trim, 1))
      codGrado = objG.RetornaCG(New Seccion(0, numero, CType(frmAsignacionAcad.cboNivel1.SelectedItem, Nivel).CodigoModular, "", "A"c))
      codCurso = objC.RetornaCodCur(New Curso(codGrado, CStr(frmAsignacionAcad.dgCursos.Item(1, i).Value)))

      If objCA.Busca(New CargaAcademica(codCurso, codGrado, CChar(Strings.Right(cadena.Trim, 1)))) > 0 Then
        frmAsignacionAcad.dgCursos.Item(2, i).Value = "Asig."
      End If
    Next
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
      'txtTotHoras.Text = CStr(horas + HorasCurAsig)
    Else
      Me.lblHorasTot.Text = CStr(horas)
    End If
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Dim i As Integer

    ListarCursosAsignados()
    AcumularHoras(Me.dgbuscar, 1)
    For i = 0 To Me.dgbuscar.RowCount - 1
      Me.dgbuscar.Item(0, i).Value() = i + 1
    Next
    If Me.cboListDoc.SelectedIndex <> 0 Then
      Me.lblTotHorasAsig.Visible = True
      Me.lblHorasTot.Visible = True
    Else
      Me.lblTotHorasAsig.Visible = False
      Me.lblHorasTot.Visible = False
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub
End Class