
Public Class frmImportarSecciones

  Public estadocombo As Boolean = False

  Public Sub cargarcbanio()
    Dim ListAn As New List(Of AnioLectivo)
    Dim objAn As New RNAnioLectivo
    Dim al As New AnioLectivo

    al.vigencia = True
    ListAn = objAn.Leer(al)
    cbanio.DisplayMember = "anio"
    cbanio.ValueMember = "anio"
    cbanio.DataSource = ListAn
    ListAn = Nothing
  End Sub
  Public Function llenardocente() As List(Of Docente)
    Dim objDoc As New RNDocente
    Dim list As New List(Of Docente)
    list = objDoc.Listar()
    objDoc = Nothing
    Return list
  End Function
  Public Sub llenarcolDocente()
    Dim column As DataGridViewComboBoxColumn = DirectCast(Me.dgvSeccion.Columns("coltutor"), DataGridViewComboBoxColumn)
    Dim ListDoc As New List(Of Docente)
    ListDoc = llenardocente()
    With column
      .DataPropertyName = "codigoTutor"
      .DisplayMember = "nombreCompleto"
      .ValueMember = "codigo"
      .DataSource = ListDoc
    End With
    column = Nothing
    ListDoc = Nothing
  End Sub
  Public Function llenarTurno() As List(Of Turno)
    Dim objDoc As New RNTurno
    Dim list As New List(Of Turno)
    list = objDoc.Listar()
    objDoc = Nothing
    Return list
  End Function

  Public Sub llenarcolTurno()
    Dim column As DataGridViewComboBoxColumn = DirectCast(Me.dgvSeccion.Columns("colturno"), DataGridViewComboBoxColumn)
    Dim ListTur As New List(Of Turno)
    ListTur = llenarTurno()
    With column
      .DataPropertyName = "CodigoTurno"
      .DisplayMember = "Nombre"
      .ValueMember = "Codigo"
      .DataSource = ListTur
    End With
    column = Nothing
    ListTur = Nothing
  End Sub

  Public Function llenarAula() As List(Of Aula)
    Dim objAula As New RNAula
    Dim list As New List(Of Aula)

    list = objAula.ListarTodasAulas()
    objAula = Nothing
    Return list
  End Function

  Public Sub llenarcolAula()
    Dim column As DataGridViewComboBoxColumn = DirectCast(Me.dgvSeccion.Columns("colAula"), DataGridViewComboBoxColumn)
    Dim ListA As New List(Of Aula)
    ListA = llenarAula()
    With column
      .DataPropertyName = "CodigoAula"
      .DisplayMember = "NombreCompletoAula"
      .ValueMember = "Codigo"
      .DataSource = ListA
    End With
    column = Nothing
    ListA = Nothing
  End Sub

  Public Sub LlenarSecciones()
    Dim ListSec As List(Of Seccion)
    Dim objS As New RNSeccion

    Try
      estadocombo = True
      Me.dgvSeccion.DataSource = Nothing
      ListSec = objS.LeerSeccion_Anio(CType(Me.cbanio.SelectedItem, AnioLectivo))
      dgvSeccion.AutoGenerateColumns = False
      dgvSeccion.DataSource = ListSec
      llenarcolDocente()
      llenarcolTurno()
      llenarcolAula()
      objS = Nothing
      ListSec = Nothing
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
  Public Sub IniciarFormulario()
    cargarcbanio()
    LlenarSecciones()
    cambiarcheck(True)
    cboSeleccion.SelectedIndex = 0
    ' Me.ShowDialog()
  End Sub
  Private Sub frmImportarSecciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    IniciarFormulario()
  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.Close()
  End Sub

  Private Sub cbanio_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbanio.SelectedIndexChanged
    If estadocombo = True Then
      cambiarcheck(True)
      LlenarSecciones()
    End If
  End Sub
  Public Sub cambiarcheck(ByVal estado As Boolean)
    For i = 0 To dgvSeccion.Rows.Count - 1
      dgvSeccion.Rows(i).Cells("colgenerar").Value = estado
    Next
  End Sub

  Public Sub ImportarSecciones()
    Dim objSec As New RNSeccion
    Dim sec As New Seccion
    Dim img As New PictureBox

    Try
      For i = 0 To dgvSeccion.Rows.Count - 1
        Try
          If CBool(dgvSeccion.Rows(i).Cells("colgenerar").Value) = True Then
            sec = CType(Me.dgvSeccion.Rows(i).DataBoundItem, Seccion)
            sec.Anio.anio = txtanioactual.Text
            sec.Vigencia = True
            objSec.Registrar(sec)
            dgvSeccion.Rows(i).Cells("colimagen").Value = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\exito.png")
            dgvSeccion.Rows(i).Cells("colresultado").Value = "Generacion Correcta..."
          End If
        Catch ex As Exception
          MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      Next
      MessageBox.Show("Las secciones se importaron exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
    Me.ImportarSecciones()
  End Sub

  Public Sub cambiarcheckGrado()
    Dim sec As New Seccion
    Dim secactual As New Seccion
    secactual = CType(Me.dgvSeccion.Rows(Me.dgvSeccion.CurrentRow.Index).DataBoundItem, Seccion)
    If Me.dgvSeccion.CurrentRow.Index > -1 Then
      For i = 0 To Me.dgvSeccion.Rows.Count - 1
        sec = CType(Me.dgvSeccion.Rows(i).DataBoundItem, Seccion)
        If sec.Grado.Numero = secactual.Grado.Numero Then
          Me.dgvSeccion.Rows(i).Cells("colgenerar").Value = True
        Else
          Me.dgvSeccion.Rows(i).Cells("colgenerar").Value = False
        End If
        sec = Nothing
      Next
    End If
  End Sub
  Public Sub cambiarcheckNivel()
    Dim sec As New Seccion
    Dim secactual As New Seccion
    secactual = CType(Me.dgvSeccion.Rows(Me.dgvSeccion.CurrentRow.Index).DataBoundItem, Seccion)
    If Me.dgvSeccion.CurrentRow.Index > -1 Then
      For i = 0 To Me.dgvSeccion.Rows.Count - 1
        sec = CType(Me.dgvSeccion.Rows(i).DataBoundItem, Seccion)
        If sec.NombreNivel = secactual.NombreNivel Then
          Me.dgvSeccion.Rows(i).Cells("colgenerar").Value = True
        Else
          Me.dgvSeccion.Rows(i).Cells("colgenerar").Value = False
        End If
        sec = Nothing
      Next
    End If
  End Sub

  Private Sub cboSeleccion_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSeleccion.SelectedValueChanged
    Select Case Me.cboSeleccion.Text
      Case "Seleccionar Todos"
        cambiarcheck(True)
      Case "Seleccionar Ninguno"
        cambiarcheck(False)
      Case "Seleccionar mismo grado"
        cambiarcheckGrado()
      Case "Seleccionar mismo nivel"
        cambiarcheckNivel()
    End Select
  End Sub

End Class