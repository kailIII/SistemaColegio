Public Class frmRegistraSeccion
  'Public Shared objIns As Institucion
  Public Shared objGra As Grado

  Private objRNS As New RNSeccion
  Private capMax As Integer
  Private ListS As New List(Of Seccion)
  Private est As Boolean

  Public Sub cargar()
    cargarCboLocal()
    cargarcboTurno()
    cargarcboTutor()
    deshabilitar()
    Me.txtnombregrado.Text = objGra.Nombre
    actualizar()
    Me.Show()
  End Sub

  Public Sub cargarCboLocal()
    Dim ListL As New List(Of Local)
    Dim objLoc As New RNLocal
    ListL = objLoc.Leer()
    cblocal.ValueMember = "codigo"
    cblocal.DisplayMember = "ubicacionLocal"
    cblocal.DataSource = ListL
    cblocal.SelectedIndex = 0
    ListL = Nothing
  End Sub

  Private Sub cblocal_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cblocal.SelectedIndexChanged
    Dim ListA As New List(Of Aula)
    Dim n As Integer = cblocal.SelectedIndex
    Dim A As New Aula(True, "A")
    Dim objRNA As New RNAula

    If cblocal.SelectedIndex > -1 Then
      cbaula.DataSource = Nothing
      ListA = objRNA.ListarAula(A, CType(cblocal.SelectedItem, Local))
      cbaula.DisplayMember = "NombreAula"
      cbaula.ValueMember = "codigo"
      cbaula.DataSource = ListA
      ListA = Nothing
    Else
      cbaula.Text = ""
      cbaula.DataSource = Nothing
    End If
  End Sub

  Private Sub cbaula_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbaula.SelectedIndexChanged
    If cbaula.SelectedIndex <> -1 Then
      actualizarMaxvacantesAula()
    End If
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

  Private Sub btregistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btregistrar.Click
    Dim wal As AnioLectivo = Nothing
    Dim objRNSec As New RNSeccion
    Try
      wal = New AnioLectivo(Me.txtanio.Text)
      If est = True Then
        objRNSec.Registrar(New Seccion(objGra, wal, CChar(Me.txtletra.Text), CInt(Me.txtvacantes.Text), True, Me.txtdescripcion.Text, CType(Me.cbturno.SelectedItem, Turno), CType(Me.cbaula.SelectedItem, Aula), CType(Me.cbtutor.SelectedItem, Docente)))
        MessageBox.Show("Sección registrada exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Else
        objRNSec.Modificar(New Seccion(objGra, wal, CChar(Me.txtletra.Text), CInt(Me.txtvacantes.Text), True, Me.txtdescripcion.Text, CType(Me.cbturno.SelectedItem, Turno), CType(Me.cbaula.SelectedItem, Aula), CType(Me.cbtutor.SelectedItem, Docente)))
        MessageBox.Show("Sección actualizada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
      actualizar()
      limpiar()
      deshabilitar()
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Public Sub actualizar()
    Dim wal As New AnioLectivo(Me.txtanio.Text)
    ListS = Nothing
    ListS = objRNS.Leer_Grado(wal, objGra, 1)
    Me.dgvsecciones.DataSource = Nothing
    Me.dgvsecciones.AutoGenerateColumns = False
    Me.dgvsecciones.DataSource = ListS
  End Sub

  Public Sub limpiar()
    Me.cblocal.SelectedIndex = -1
    Me.cbturno.SelectedIndex = -1
    Me.cbtutor.SelectedIndex = -1
    Me.txtletra.Text = ""
    Me.txtvacantes.Text = ""
    Me.txtletra.Text = ""
    Me.txtdescripcion.Text = ""
  End Sub

  Public Sub deshabilitar()
    Me.gbnuevaseccion.Enabled = False
  End Sub

  Public Sub habilitar()
    Me.gbnuevaseccion.Enabled = True
  End Sub

  Public Sub actualizarMaxvacantesAula()
    Dim aula As Aula

    If cbaula.SelectedIndex > -1 Then
      aula = CType(cbaula.SelectedItem, Aula)
      Me.txtvacantes.Text = CStr(aula.Capacidad)
      capMax = aula.Capacidad
    End If
  End Sub

  Private Sub btnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnuevo.Click
    habilitar()
    If ListS.Count = 0 Then
      Me.txtletra.Text = "A"
    Else
      Dim c As Char = CChar(Trim(ListS.ElementAt(ListS.Count - 1).Letra))
      c = Chr(Asc(c) + 1)
      Me.txtletra.Text = c
    End If
    cblocal.Focus()
    cblocal.SelectedIndex = 0
    cbturno.SelectedIndex = 0
    actualizarMaxvacantesAula()
    est = True
    Me.btregistrar.Text = "Registrar"
  End Sub

  Private Sub txtletra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtletra.KeyPress, txtdescripcion.KeyPress
    If Not (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) And Not (Asc(e.KeyChar) = 8) And Not (Asc(e.KeyChar) = 32) Then
      e.Handled = True
    End If
  End Sub

  Private Sub txtvacantes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvacantes.KeyPress
    If Not (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) And Not (Asc(e.KeyChar) = 8) Then
      e.Handled = True
    End If
  End Sub

  Private Sub txtEmail_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtletra.Validating
    ValidarText(e, Me.txtletra, "Debe indicar la letra de la Seccion")
  End Sub

  Private Sub ValidarText(ByVal e As System.ComponentModel.CancelEventArgs, ByVal cadena As TextBox, ByVal msj As String)
    If cadena.Text.Length = 0 Then
      e.Cancel = True
      errValida.SetError(cadena, msj)
    Else
      errValida.SetError(cadena, "")
    End If
  End Sub

  Private Sub txtvacantes_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtvacantes.Validating
    ValidarText(e, Me.txtvacantes, "Debe indicar el numero de vacantes en la Seccion")
    If Val(Me.txtvacantes.Text) > capMax Then
      MessageBox.Show("El numero de vacantes debe ser menor que la capacidad del Aula", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Me.txtvacantes.Text = CStr(capMax)
    End If
  End Sub

  Private Sub btlimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btlimpiar.Click
    limpiar()
    deshabilitar()
  End Sub

  Private Sub btmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btmodificar.Click, dgvsecciones.DoubleClick
    mostrarSeccionMod()
    cblocal.SelectedIndex = 0
    Me.btregistrar.Text = "Actualizar"
    est = False
  End Sub

  Public Sub mostrarSeccionMod()
    Dim local As New Local
    Dim aula As New Aula

    habilitar()
    For i = 0 To cblocal.Items.Count - 1
      local = CType(cblocal.Items(i), Local)
      If local.Codigo = ListS.ElementAt(dgvsecciones.CurrentRow.Index).Aula.Local.Codigo Then
        cblocal.SelectedIndex = i
        local = Nothing
      End If
    Next
    For i = 0 To cbaula.Items.Count - 1
      aula = CType(cbaula.Items(i), Aula)
      If aula.Codigo = ListS.ElementAt(dgvsecciones.CurrentRow.Index).Aula.Codigo Then
        cbaula.SelectedIndex = i
      End If
    Next
    Me.cbturno.SelectedValue = ListS.ElementAt(dgvsecciones.CurrentRow.Index).Turno.Codigo
    Me.cbtutor.SelectedValue = ListS.ElementAt(dgvsecciones.CurrentRow.Index).Tutor.Codigo
    Me.txtvacantes.Text = CStr(ListS.ElementAt(dgvsecciones.CurrentRow.Index).Vacantes)
    Me.txtletra.Text = ListS.ElementAt(dgvsecciones.CurrentRow.Index).Letra
    Me.txtdescripcion.Text = ListS.ElementAt(dgvsecciones.CurrentRow.Index).Descripcion
  End Sub

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

End Class