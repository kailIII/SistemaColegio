Public Class frmBalancearSecciones

  Private sw As Integer = 0
  Private sw2 As Integer = 0
  Private letra As String
  Private nro As Integer
  Private cant As Integer
  Private sw3 As Integer = 0
  Private posicion As Integer = -1
  Private vector(300) As String
  Private array(100) As Boolean

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub frmTrasladoAlumnos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    If e.KeyCode = Keys.F6 Then
      Listar()
      e.Handled = True
    ElseIf e.KeyCode = Keys.Enter Then
      Actualizar()
    End If
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
      LimpiarGrados()
      LimpiarAlumnos()
      ListarGrados()
    End If
  End Sub

  Private Sub LimpiarGrados()
    Me.dgGrados.DataSource = Nothing
    Me.dgGrados.Rows.Clear()
  End Sub

  Private Sub LimpiarAlumnos()
    Me.dgAlumnos.DataSource = Nothing
    Me.dgAlumnos.Rows.Clear()
  End Sub

  Public Sub MostrarImagenes()
    Me.btnActualizar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Listar()
  End Sub

  Private Sub Listar()
    Dim obj As New RNGrado
    Dim ls As List(Of Seccion)

    sw = 1
    ls = obj.LeerNroAlumnosSeccion(New Grado(0, CType(Me.cboGrado.SelectedItem, Grado).Numero, "", _
                                             New Nivel(CType(Me.cboNivel.SelectedItem, Nivel).Codigo, "", ""), _
                                             "", "", "", ""), moAnioActual)
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
    'Me.dgGrados.ClearSelection()
    Me.dgGrados.Focus()
  End Sub

  Private Sub dgGrados_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgGrados.SelectionChanged
    If Me.dgGrados.RowCount > 0 Then
      Me.dgAlumnos.Visible = False
      ListarGradosPorSeccion()
      PintarEstado()
      Me.dgAlumnos.ClearSelection()
      Me.dgAlumnos.Visible = True
      Me.dgAlumnos.ClearSelection()
    End If
  End Sub

  Public Sub ListarGradosPorSeccion()
    Dim obj As RNMatricula = Nothing
    Dim lm As List(Of Matricula) = Nothing
    Dim s As Seccion = Nothing

    If Me.dgGrados.RowCount > 0 Then
      obj = New RNMatricula
      s = CType(Me.dgGrados.CurrentRow.DataBoundItem, Seccion)
      lm = obj.Listar(New Seccion(moAnioActual, New Grado(s.Grado.Codigo, s.Grado.Numero), s.Letra))
      obj = Nothing
      If lm.Count > 0 Then
        Me.dgAlumnos.AutoGenerateColumns = False
        Me.dgAlumnos.DataSource = lm
        Me.dgAlumnos.Columns(0).DataPropertyName = "NroOrden2"
        Me.dgAlumnos.Columns(1).DataPropertyName = "NombreAlumno"
        Me.dgAlumnos.Columns(2).DataPropertyName = "LeerSexo"

        LlenarColGrados()
        For i = 0 To lm.Count - 1
          SeleccionarSeccion(i)
          MarcarCheck(i, lm)
        Next
      Else
        Me.dgAlumnos.DataSource = Nothing
      End If
    End If
    lm = Nothing
    sw2 = 0
  End Sub

  Private Sub PintarEstado()
    For i As Integer = 0 To Me.dgAlumnos.RowCount - 1
      If CBool(Me.dgAlumnos.Rows(i).Cells("cdEstado").Value) = False Then
        Me.dgAlumnos.Rows(i).DefaultCellStyle.BackColor = Color.DarkOrange
      Else
        Me.dgAlumnos.Rows(i).DefaultCellStyle.BackColor = Color.White
      End If
    Next
  End Sub

  Public Sub LlenarColGrados()
    Dim col As DataGridViewComboBoxColumn = DirectCast(Me.dgAlumnos.Columns("cdGrado"), DataGridViewComboBoxColumn)
    Dim obj As New RNSeccion
    Dim ls As List(Of Seccion)
    ls = obj.LeerNivelNumSec(New Seccion(0, moAnioActual.anio, CChar("A")))
    If ls.Count > 0 Then
      With col
        .DataSource = ls
        .DisplayMember = "NivelNumeroLetra"
        .ValueMember = "NivelNumeroLetra"
      End With
    End If
    col = Nothing
    ls = Nothing
  End Sub

  Public Sub SeleccionarSeccion(ByVal i As Integer)
    Dim sec As Seccion

    sec = CType(Me.dgGrados.CurrentRow.DataBoundItem, Seccion)
    Me.dgAlumnos.Item("cdGrado", i).Value = CType(Me.cboNivel.SelectedItem, Nivel).Siglas & " - " & sec.Grado.Numero & " " & sec.Letra
  End Sub

  Public Sub MarcarCheck(ByVal i As Integer, ByVal lm As List(Of Matricula))
    If lm(i).vigencia Then
      Me.dgAlumnos.Rows(i).Cells("cdEstado").Value = True
      array(i) = True
    Else
      Me.dgAlumnos.Rows(i).Cells("cdEstado").Value = False
      array(i) = False
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
    Dim sec As Seccion
    Dim pos2 As Integer = 0
    Dim combo As ComboBox = DirectCast(sender, ComboBox)
    Dim cadena As String = ""
    Dim k As Integer = 0
    Dim posic As Integer

    pos2 = Me.dgGrados.Rows.IndexOf(Me.dgGrados.CurrentRow)
    posic = Me.dgAlumnos.Rows.IndexOf(Me.dgAlumnos.CurrentRow)
    sec = CType(Me.dgGrados.CurrentRow.DataBoundItem, Seccion)

    If array(posic) = True Then

      If sw2 = 0 Then
        letra = sec.Letra
        nro = sec.Grado.Numero
        cant = sec.Vacantes
        sw2 = 1
      End If

      cadena = CType(combo.SelectedItem, Seccion).NivelNumeroLetra

      If cadena <> vector(posic) Then

        If cadena <> CType(Me.cboNivel.SelectedItem, Nivel).Siglas & " - " & nro & " " & letra Then

          If CInt(Me.dgGrados.Rows(pos2).Cells("cdCantidad").Value) > 0 Then
            Me.dgGrados.Rows(pos2).Cells("cdCantidad").Value = sec.Vacantes - 1
            For i = 0 To Me.dgGrados.RowCount - 1
              If CType(Me.cboNivel.SelectedItem, Nivel).Siglas & " - " & CStr(Me.dgGrados.Rows(i).Cells("cdNumero").Value) & " " & CStr(Me.dgGrados.Rows(i).Cells("cdSeccion").Value) = cadena Then
                Me.dgGrados.Rows(i).Cells("cdCantidad").Value = CInt(Me.dgGrados.Rows(i).Cells("cdCantidad").Value) + 1
                Exit For
              End If
            Next
            k = 1
          End If

          If k = 0 Then
            If CInt(Me.dgGrados.Rows(pos2).Cells("cdCantidad").Value) = 0 Then
              If Microsoft.VisualBasic.Right(cadena.Trim, 1) = letra Then
                Me.dgGrados.Rows(pos2).Cells("cdCantidad").Value = sec.Vacantes + 1
                For i = 0 To Me.dgGrados.RowCount - 1
                  If CType(Me.cboNivel.SelectedItem, Nivel).Siglas & " - " & CStr(Me.dgGrados.Rows(i).Cells("cdNumero").Value) & " " & CStr(Me.dgGrados.Rows(i).Cells("cdSeccion").Value) = vector(posic) Then
                    Me.dgGrados.Rows(i).Cells("cdCantidad").Value = CInt(Me.dgGrados.Rows(i).Cells("cdCantidad").Value) - 1
                    Exit For
                  End If
                Next
              Else
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

            End If
          End If

        Else

          If CInt(Me.dgGrados.Rows(pos2).Cells("cdCantidad").Value) < cant Then
            Me.dgGrados.Rows(pos2).Cells("cdCantidad").Value = sec.Vacantes + 1
            For i = 0 To Me.dgGrados.RowCount - 1
              If CType(Me.cboNivel.SelectedItem, Nivel).Siglas & " - " & CStr(Me.dgGrados.Rows(i).Cells("cdNumero").Value) & " " & CStr(Me.dgGrados.Rows(i).Cells("cdSeccion").Value) = vector(posic) Then
                Me.dgGrados.Rows(i).Cells("cdCantidad").Value = CInt(Me.dgGrados.Rows(i).Cells("cdCantidad").Value) - 1
                Exit For
              End If
            Next
          End If
        End If

      End If

      vector(posic) = cadena
    End If

  End Sub

  Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
    Actualizar()
  End Sub

  Private Sub Actualizar()
    Dim pos As Integer = Me.dgGrados.Rows.IndexOf(Me.dgGrados.CurrentRow)

    If Me.dgAlumnos.Rows.Count > 0 Then
      ActualizarLista(pos)
      MessageBox.Show("Información actualizada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      ListarGradosPorSeccion()
      PintarEstado()
      Me.dgAlumnos.ClearSelection()
    Else
      MessageBox.Show("No existen alumnos en la lista", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
  End Sub

  Public Sub ActualizarLista(ByVal pos As Integer)
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
          With Me.dgGrados
            .Rows(pos).Cells("cdCantidad").Value = CInt(.Rows(pos).Cells("cdCantidad").Value) - 1
          End With
        End If
        If array(i) = True Then
          obj.ActualizarSecMat(New Matricula(0, fecha, New Grado(cod), New Alumno(m.Alumno.Codigo), moAnioActual, letra, CDbl(0), m.vigencia))
        Else
          obj.ActualizarSecMat(New Matricula(0, fecha, New Grado(CType(Me.dgGrados.CurrentRow.DataBoundItem, Seccion).Grado.Codigo), New Alumno(m.Alumno.Codigo), moAnioActual, CType(Me.dgGrados.CurrentRow.DataBoundItem, Seccion).Letra, CDbl(0), m.vigencia))
          Me.dgGrados.Rows(pos).Cells("cdCantidad").Value = CInt(Me.dgGrados.Rows(pos).Cells("cdCantidad").Value) + 1
        End If
      Next
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      obj = Nothing
      obj2 = Nothing
    End Try

  End Sub

  Private Sub cboGrado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrado.SelectedIndexChanged
    If Me.cboGrado.SelectedIndex > -1 Then
      LimpiarGrados()
      LimpiarAlumnos()
    End If
  End Sub

End Class