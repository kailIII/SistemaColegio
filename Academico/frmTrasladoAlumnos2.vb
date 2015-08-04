
Public Class frmTrasladoAlumnos2
  Private sw As Integer = 0
  Private sw2 As Integer = 0
  Private sw3 As Integer = 0
  Private posicion As Integer = -1
  Private vector(300) As String

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub frmTrasladoAlumnos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ListarNiveles()
    ListarGrados()
    MostrarImagenes()
  End Sub

  Public Sub ListarNiveles()
    Dim obj As New RNNivel
    Dim ln As List(Of Nivel)

    ln = obj.Listar
    If ln.Count > 0 Then
      Me.cboNivel.DisplayMember = "Nombre"
      Me.cboNivel.ValueMember = "nombre"
      Me.cboNivel.DataSource = ln
    Else
      MessageBox.Show("Ingrese niveles", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Question)
      Me.Close()
    End If

  End Sub

  Public Sub ListarGrados()
    Dim obj As New RNGrado
    Dim lg As List(Of Grado)

    lg = obj.Leer(New Grado(0, CType(Me.cboNivel.SelectedItem, Nivel).Codigo, "", 0)) '''''zsdgsd
    If lg.Count > 0 Then
      Me.cboGrado.DisplayMember = "Nombre"
      Me.cboGrado.ValueMember = "Nombre"
      Me.cboGrado.DataSource = lg
    Else
      MessageBox.Show("Ingrese grados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Question)
      Me.Close()
    End If

  End Sub

  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNivel.SelectedIndexChanged
    If Me.cboNivel.SelectedIndex > -1 Then
      ListarGrados()
    End If
  End Sub

  Public Sub MostrarImagenes()
    Me.btnActualizar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    ListarSecciones()
    ListarAlumnos()
    sw2 = 0
  End Sub

  Public Sub ListarSecciones()
    Dim obj As New RNGrado
    Dim ls As List(Of Seccion)

    sw = 1
    ls = obj.LeerNroAlumnosSeccion(New Grado(0, CType(Me.cboGrado.SelectedItem, Grado).Numero, "", New Nivel(CType(Me.cboNivel.SelectedItem, Nivel).Codigo, "", ""), "", "", "", ""), moAnioActual)
    If ls.Count > 0 Then
      Me.dgGrados.AutoGenerateColumns = False
      Me.dgGrados.DataSource = ls
      Me.dgGrados.Columns(0).DataPropertyName = "Numero"
      Me.dgGrados.Columns(1).DataPropertyName = "Letra"
      Me.dgGrados.Columns(2).DataPropertyName = "Vacantes"
    Else
      Me.dgGrados.DataSource = Nothing
      Me.dgGrados.Rows.Clear()
      Me.dgAlumnos.DataSource = Nothing
      Me.dgAlumnos.Rows.Clear()
    End If
    ls = Nothing
  End Sub

  Public Sub ListarAlumnos()
    Dim obj As RNMatricula = Nothing
    Dim lm As List(Of Matricula) = Nothing
    Dim s As Seccion = Nothing
    Dim m As Matricula = Nothing
    Dim j As Integer = 0

    If Me.dgGrados.RowCount > 0 Then

      obj = New RNMatricula
      s = CType(Me.dgGrados.CurrentRow.DataBoundItem, Seccion)
      lm = obj.ListarAlumnosGrado(New Seccion(moAnioActual, New Grado(s.Grado.Codigo, s.Grado.Numero), CChar("A")))
      Me.dgAlumnos.AutoGenerateColumns = False
      Me.dgAlumnos.DataSource = lm
      Me.dgAlumnos.Columns(0).DataPropertyName = "NombreCompleto"
      Me.dgAlumnos.Columns(1).DataPropertyName = "LeerSexo"

      LlenarColGrados()

      For Each m In lm
        SeleccionarSeccion(j, m.Letra)
        MarcarCheck(j, lm)
        j += 1
      Next

    End If
    lm = Nothing
    obj = Nothing
  End Sub

  Public Sub LlenarColGrados()
    Dim col As DataGridViewComboBoxColumn = DirectCast(Me.dgAlumnos.Columns("cdGrado"), DataGridViewComboBoxColumn)
    Dim obj As New RNSeccion
    Dim ls As List(Of Seccion)
    ls = obj.LeerNivelNumSec(New Seccion(0, moAnioActual.anio, CChar("A")))
    If ls.Count > 0 Then
      With col
        .DisplayMember = "NivelNumeroLetra"
        .ValueMember = "NivelNumeroLetra"
        .DataSource = ls
      End With
    End If
    col = Nothing
    ls = Nothing
  End Sub

  Public Sub SeleccionarSeccion(ByVal i As Integer, ByVal letra As String)
    Dim sec As Seccion

    sec = CType(Me.dgGrados.CurrentRow.DataBoundItem, Seccion)
    Me.dgAlumnos.Item("cdGrado", i).Value = CType(Me.cboNivel.SelectedItem, Nivel).Siglas & " - " & sec.Grado.Numero & " " & letra
  End Sub

  Public Sub MarcarCheck(ByVal i As Integer, ByVal lm As List(Of Matricula))
    If lm(i).vigencia Then
      Me.dgAlumnos.Rows(i).Cells(3).Value = True
    Else
      Me.dgAlumnos.Rows(i).Cells(3).Value = False
    End If
  End Sub

  Private Sub dgAlumnos_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgAlumnos.EditingControlShowing
    Dim combo As ComboBox = CType(e.Control, ComboBox)

    If Not TypeOf e.Control Is DataGridViewComboBoxEditingControl Then Return

    If combo IsNot Nothing Then
      RemoveHandler combo.SelectedValueChanged, New EventHandler(AddressOf dgAlumnos_SelectedValueChanged)
      AddHandler combo.SelectedValueChanged, New EventHandler(AddressOf dgAlumnos_SelectedValueChanged)
    End If

    sw3 = 0

  End Sub

  Private Sub dgAlumnos_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
    Dim pos As Integer
    Dim combo As ComboBox = DirectCast(sender, ComboBox)

    If sw3 = 0 Then
      posicion = Me.dgAlumnos.Rows.IndexOf(Me.dgAlumnos.CurrentRow)
      sw3 = 1
    End If

    If combo.SelectedIndex > -1 Then
      pos = Me.dgAlumnos.Rows.IndexOf(Me.dgAlumnos.CurrentRow)
      If pos = posicion Then
        posicion = pos
        ModificarCantidad(sender)
      End If
    End If

  End Sub

  Public Sub ModificarCantidad(ByVal sender As Object)
    Dim pos2 As Integer = 0
    Dim combo As ComboBox = DirectCast(sender, ComboBox)
    Dim cadena As String = ""
    Dim k As Integer = 0
    Dim posic As Integer

    posic = Me.dgAlumnos.Rows.IndexOf(Me.dgAlumnos.CurrentRow)

    If sw2 = 0 Then
      For k = 0 To Me.dgAlumnos.RowCount - 1
        vector(k) = CStr(Me.dgAlumnos.Rows(k).Cells.Item("cdGrado").Value)
      Next
      sw2 = 1
    End If

    cadena = CType(combo.SelectedItem, Seccion).NivelNumeroLetra

    If cadena <> vector(posic) Then
      For i = 0 To Me.dgGrados.RowCount - 1
        If CType(Me.cboNivel.SelectedItem, Nivel).Siglas & " - " & CStr(Me.dgGrados.Rows(i).Cells("cdNumero").Value) & " " & CStr(Me.dgGrados.Rows(i).Cells("cdSeccion").Value) = cadena Then
          Me.dgGrados.Rows(i).Cells("cdCantidad").Value = CInt(Me.dgGrados.Rows(i).Cells("cdCantidad").Value) + 1
          Exit For
        End If
      Next

      For i = 0 To Me.dgGrados.RowCount - 1
        If CType(Me.cboNivel.SelectedItem, Nivel).Siglas & " - " & CStr(Me.dgGrados.Rows(i).Cells("cdNumero").Value) & " " & CStr(Me.dgGrados.Rows(i).Cells("cdSeccion").Value) = vector(posic) Then
          Me.dgGrados.Rows(i).Cells("cdCantidad").Value = CInt(Me.dgGrados.Rows(i).Cells("cdCantidad").Value) - 1
          Exit For
        End If
      Next

    End If

    vector(posic) = cadena

  End Sub

  Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
    If Me.dgAlumnos.Rows.Count > 0 Then
      ActualizarLista()
      MessageBox.Show("Información actualizada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      ListarAlumnos()
    Else
      MessageBox.Show("No existen alumnos en la lista", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
  End Sub

  Public Sub ActualizarLista()
    Dim obj As New RNMatricula
    Dim obj2 As New RNGrado
    Dim m As Matricula
    Dim cod As Integer
    Dim letra As String
    Dim numero As Integer
    Dim siglas As String
    Dim cadena As String
    Dim cadTemp As String
    Dim posTemp As Integer
    Dim fecha As DateTime

    Try
      fecha = Now

      For i As Integer = 0 To Me.dgAlumnos.Rows.Count - 1
        m = Nothing
        m = CType(Me.dgAlumnos.Rows(i).DataBoundItem, Matricula)
        cadena = CStr(Me.dgAlumnos.Rows(i).Cells.Item("cdGrado").EditedFormattedValue)
        cadTemp = Microsoft.VisualBasic.Right(cadena.Trim, 3)
        numero = CInt(Microsoft.VisualBasic.Left(cadTemp, 1))
        letra = Microsoft.VisualBasic.Right(cadena.Trim, 1)
        cadTemp = ""
        cadTemp = Microsoft.VisualBasic.Right(cadena.Trim, 6)
        posTemp = Microsoft.VisualBasic.InStr(cadena.Trim, cadTemp)
        siglas = Microsoft.VisualBasic.Left(cadena, posTemp - 1)
        cod = obj2.LeerCodigoGrado(New Grado(0, numero, "", New Nivel(0, "", siglas.Trim), "", "", "", ""))
        If CBool(Me.dgAlumnos.Rows(i).Cells.Item("cdEstado").EditedFormattedValue) Then
          m.vigencia = True
        Else
          m.vigencia = False
        End If
        obj.ActualizarSecMat(New Matricula(0, fecha, New Grado(cod), New Alumno(m.Alumno.Codigo), moAnioActual, letra, CDbl(0), m.vigencia))
      Next
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      obj = Nothing
      obj2 = Nothing
    End Try

  End Sub

End Class