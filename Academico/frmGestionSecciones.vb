Public Class frmGestionSecciones
  Private listG As New List(Of Grado)
  Public Shared objGra As Grado
  Private Al As New AnioLectivo
  Private capMax As Integer
  Private est As Boolean
  Private objRNS As New RNSeccion
  Private ListS As New List(Of Seccion)

  Private Sub frmGestionSecciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.cargarcbanio()
    Me.llenarGrados()
    Me.Cargar()
    Me.MostrarImagenes()
  End Sub

  Public Sub MostrarImagenes()
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnModificar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Editar.jpg")
  End Sub

  Public Sub Cargar()
    cargarCboLocal()
    cargarcboTurno()
    cargarcboTutor()
    Actualizar()
  End Sub

  Public Sub cargarCboLocal()
    Dim ListL As New List(Of Local)
    Dim objLoc As New RNLocal
    ListL = objLoc.Leer()
    cblocal.ValueMember = "codigo"
    cblocal.DisplayMember = "ubicacionLocal"
    cblocal.DataSource = ListL
    'cblocal.SelectedIndex = 0
    ListL = Nothing
  End Sub

  Public Sub cargarcboTurno()
    Dim ListT As New List(Of Turno)
    Dim objTurn As New RNTurno

    ListT = objTurn.Listar()
    cbturno.DisplayMember = "nombre"
    cbturno.ValueMember = "codigo"
    cbturno.DataSource = ListT
    ListT = Nothing
  End Sub

  Public Sub cargarcboTutor()
    Dim ListD As New List(Of Docente)
    Dim objDoc As New RNDocente

    ListD = objDoc.Listar
    cbtutor.DisplayMember = "NombreCompleto"
    cbtutor.ValueMember = "codigo"
    cbtutor.DataSource = ListD
    ListD = Nothing
  End Sub

  Public Sub Nuevo()
    If ListS.Count = 0 Then
      Me.txtLetra.Text = "A"
    Else
      Dim c As Char = CChar(Trim(ListS.ElementAt(ListS.Count - 1).Letra))
      c = Chr(Asc(c) + 1)
      Me.txtLetra.Text = c
    End If
    'cblocal.Focus()
    If cblocal.Items.Count > 0 Then
      cblocal.SelectedIndex = 0
    End If
    If cbturno.Items.Count > 0 Then
      cbturno.SelectedIndex = 0
    End If
    ActualizarMaxVacantesAula()
    est = True
  End Sub

  Public Sub ActualizarMaxVacantesAula()
    Dim aula As Aula

    If cbaula.SelectedIndex > -1 Then
      aula = CType(cbaula.SelectedItem, Aula)
      Me.txtVacantes.Text = CStr(aula.Capacidad)
      capMax = aula.Capacidad
    End If
  End Sub

  Public Sub cargarcbanio()
    Me.txtAnio.Text = moAnioActual.anio
  End Sub
  Public Sub llenarGrados()
    Dim objG As New RNGrado

    dgvGrados.AutoGenerateColumns = False
    listG = objG.Leer()
    Me.dgvGrados.DataSource = listG
  End Sub

  Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
    Dim frm As frmImportarSecciones
    Dim obj As RNAnioLectivo
    If dgvGrados.RowCount > 0 Then
      frm = New frmImportarSecciones
      obj = New RNAnioLectivo
      If obj.VerificarAnios > 1 Then
        frm.txtanioactual.Text = Me.txtAnio.Text
        frm.ShowDialog()
      Else
        MsgBox("No existen años anteriores para importar", MsgBoxStyle.Information, "GESTIÓN DE SECCIONES")
      End If
    Else
      MessageBox.Show("No hay grados......", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub txtLetra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLetra.KeyPress, txtDescripcion.KeyPress
    If Not (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) And Not (Asc(e.KeyChar) = 8) And Not (Asc(e.KeyChar) = 32) Then
      e.Handled = True
    End If
  End Sub

  Private Sub txtVacantes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVacantes.KeyPress
    If Not (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) And Not (Asc(e.KeyChar) = 8) Then
      e.Handled = True
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Public Sub Actualizar()
    Dim wal As New AnioLectivo(moAnioActual.anio)
    ListS = Nothing
    If Me.dgvGrados.RowCount > 0 Then
      objGra = listG.ElementAt(dgvGrados.CurrentRow.Index)
      ListS = objRNS.Leer_Grado(wal, objGra, 1)
      Me.dgvSecciones.AutoGenerateColumns = False
      Me.dgvSecciones.DataSource = ListS
      Nuevo()
      PintarSeccionAnulada()
    Else
      MessageBox.Show("Ingrese grados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Me.Close()
    End If
  End Sub

  Private Sub PintarSeccionAnulada()
    For i As Integer = 0 To Me.dgvSecciones.RowCount - 1
      If CType(Me.dgvSecciones.Rows(i).DataBoundItem, Seccion).Vigencia = False Then
        Me.dgvSecciones.Rows(i).DefaultCellStyle.BackColor = Color.Gray
        Me.dgvSecciones.Rows(i).DefaultCellStyle.ForeColor = Color.White
      Else
        Me.dgvSecciones.Rows(i).DefaultCellStyle.BackColor = Color.White
        Me.dgvSecciones.Rows(i).DefaultCellStyle.ForeColor = Color.Black
      End If
    Next
    Me.dgvSecciones.ClearSelection()
  End Sub

  Private Sub cblocal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cblocal.SelectedIndexChanged
    Dim ListA As List(Of Aula)
    Dim n As Integer = cblocal.SelectedIndex
    Dim A As Aula
    Dim objRNA As RNAula

    If cblocal.SelectedIndex > -1 Then
      A = New Aula(True, "A")
      ListA = New List(Of Aula)
      objRNA = New RNAula
      cbaula.DataSource = Nothing
      ListA = objRNA.ListarAula(A, CType(cblocal.SelectedItem, Local))
      cbaula.DisplayMember = "NombreCompletoAula"
      cbaula.ValueMember = "codigo"
      cbaula.DataSource = ListA
      ListA = Nothing
    Else
      cbaula.Text = ""
      cbaula.DataSource = Nothing
    End If
  End Sub

  Private Sub cbaula_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbaula.SelectedIndexChanged
    If cbaula.SelectedIndex > -1 Then
      ActualizarMaxVacantesAula()
    End If
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim wal As AnioLectivo = Nothing
    Dim objRNSec As RNSeccion

    If Me.ValidateChildren Then
      Try
        objRNSec = New RNSeccion

        wal = New AnioLectivo(Me.txtAnio.Text)
        objGra = listG.ElementAt(dgvGrados.CurrentRow.Index)
        If est = True Then
          objRNSec.Registrar(New Seccion(objGra, wal, CChar(Me.txtLetra.Text), CInt(Me.txtVacantes.Text), True, Me.txtDescripcion.Text, _
                                         CType(Me.cbturno.SelectedItem, Turno), CType(Me.cbaula.SelectedItem, Aula), _
                                         CType(Me.cbtutor.SelectedItem, Docente)))
          MessageBox.Show("Sección registrada exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          If Me.cbaula.Items.Count - 1 > Me.cbaula.SelectedIndex Then
            Me.cbaula.SelectedIndex += 1
          End If
        Else
          objRNSec.Modificar(New Seccion(objGra, wal, CChar(Me.txtLetra.Text), CInt(Me.txtVacantes.Text), Me.chkVigente.Checked, Me.txtDescripcion.Text, CType(Me.cbturno.SelectedItem, Turno), CType(Me.cbaula.SelectedItem, Aula), CType(Me.cbtutor.SelectedItem, Docente)))
          MessageBox.Show("Sección actualizada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Actualizar()
        Nuevo()
        limpiar()

      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        objRNSec = Nothing
      End Try
    End If
  End Sub

  Public Sub limpiar()
    Me.cblocal.SelectedIndex = 0
    Me.cbturno.SelectedIndex = 0
    Me.cbtutor.SelectedIndex = -1
    'Me.txtLetra.Text = ""
    Me.txtVacantes.Text = "35"
    ' Me.txtLetra.Text = ""
    Me.chkVigente.Visible = False
    Me.txtDescripcion.Text = ""
    Me.btnRegistrar.Text = "&Registrar"
    est = True
  End Sub

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click, dgvSecciones.DoubleClick
    mostrarSeccionMod()
    cblocal.SelectedIndex = 0
    Me.chkVigente.Visible = True
    Me.btnRegistrar.Text = "Actualizar"
    est = False
  End Sub

  Public Sub mostrarSeccionMod()
    Dim local As New Local
    Dim aula As New Aula
    Dim codigoG As Integer
    Dim letra As Char
    Dim objsec As New RNSeccion

   
    Me.cbaula.SelectedValue = ListS.ElementAt(dgvSecciones.CurrentRow.Index).CodigoAula
    Me.cblocal.SelectedValue = ListS.ElementAt(dgvSecciones.CurrentRow.Index).Aula.Local.Codigo

    Me.cbturno.SelectedValue = CInt(ListS.ElementAt(dgvSecciones.CurrentRow.Index).Turno.Codigo)
    Me.cbtutor.SelectedValue = ListS.ElementAt(dgvSecciones.CurrentRow.Index).Tutor.Codigo
    codigoG = ListS.ElementAt(dgvSecciones.CurrentRow.Index).Grado.Codigo
    letra = CChar(ListS.ElementAt(dgvSecciones.CurrentRow.Index).Letra)
    Me.txtVacantes.Text = CStr(objsec.LeerVacantesSeccion(New Seccion(New AnioLectivo(moAnioActual.anio), New Grado(codigoG), letra)))
    Me.txtLetra.Text = ListS.ElementAt(dgvSecciones.CurrentRow.Index).Letra
    Me.txtDescripcion.Text = ListS.ElementAt(dgvSecciones.CurrentRow.Index).Descripcion
    If ListS.ElementAt(dgvSecciones.CurrentRow.Index).Vigencia Then
      Me.chkVigente.Checked = True
    Else
      Me.chkVigente.Checked = False
    End If
  End Sub

  Private Sub dgvGrados_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvGrados.Click
    If Me.dgvGrados.RowCount > 0 Then
      Actualizar()
      Nuevo()
      If Me.dgvSecciones.RowCount > 0 Then
        Me.btnModificar.Enabled = True
      Else
        Me.btnModificar.Enabled = False
      End If
    End If
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    limpiar()
    Nuevo()
    errValida.SetError(Me.cbtutor, Nothing)
    errValida.SetError(Me.txtVacantes, Nothing)
  End Sub

  Private Sub ValidarText(ByVal e As System.ComponentModel.CancelEventArgs, ByVal cadena As TextBox, ByVal msj As String)
    If cadena.Text.Length = 0 Then
      e.Cancel = True
      errValida.SetError(cadena, msj)
    Else
      errValida.SetError(cadena, "")
    End If
  End Sub

  Private Sub txtVacantes_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtVacantes.Validating
    ValidarText(e, Me.txtVacantes, "Debe indicar el número de vacantes en la sección")
    If Val(Me.txtVacantes.Text) > capMax Then
      'MessageBox.Show("El número de vacantes debe ser menor que la capacidad del aula", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      'ValidarText(e, Me.txtVacantes, "El número de vacantes debe ser menor que la capacidad del aula")
      e.Cancel = True
      errValida.SetError(Me.txtVacantes, "El número de vacantes debe ser menor que la capacidad del aula")
      Me.txtVacantes.Text = CStr(capMax)
    End If
  End Sub

  Private Sub cbtutor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbtutor.Validating
    If Me.cbtutor.Text = "" Then
      e.Cancel = True
      errValida.SetError(Me.cbtutor, "Debe indicar el tutor de la sección")
    Else
      errValida.SetError(Me.cbtutor, Nothing)
    End If
  End Sub

  Private Sub cbturno_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbturno.Validating
    If Me.cbturno.Text = "" Then
      e.Cancel = True
      errValida.SetError(Me.cbturno, "Debe indicar el turno de la sección")
    Else
      errValida.SetError(Me.cbturno, Nothing)
    End If
  End Sub

End Class