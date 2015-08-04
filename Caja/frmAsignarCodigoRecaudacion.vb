Public Class frmAsignarCodigoRecaudacion

  Private List As List(Of Alumno)

  Private Sub ListarComboGrados()
    Dim objS As RNSeccion = New RNSeccion
    Dim ls As List(Of Seccion)

    ls = objS.LeerNivelNumSec(New Seccion(0, moAnioActual.Anio, CChar("A")))
    If ls.Count > 0 Then
      Me.cboGrado.DisplayMember = "NivelNumeroLetra"
      Me.cboGrado.ValueMember = "NivelNumeroLetra"
      Me.cboGrado.DataSource = ls
    Else
      Me.Close()
      MessageBox.Show("Registre secciones", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub frmAsignarCodigoRecaudacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.ListarComboGrados()
    Me.txtAnio.Text = mOAnioActual.Anio
  End Sub

  Private Sub dgvAlumnosSeccion_EditingControlShowing(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs) Handles dgvAlumnosSeccion.EditingControlShowing
    ' referencia a la celda
    Dim validar As TextBox = CType(e.Control, TextBox)
    ' agregar el controlador de eventos para el KeyPress  
    AddHandler validar.KeyPress, AddressOf validar_Keypress
  End Sub

  Private Sub validar_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    ' Obtener caracter
    Dim caracter As Char = e.KeyChar
    ' comprobar si el caracter es un número o el retroceso
    If Not Char.IsNumber(caracter) And (caracter = ChrW(Keys.Back)) = False Then
      'Me.Text = e.KeyChar
      e.KeyChar = Chr(0)
    End If
  End Sub

  Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click
    Dim obj As New RNAlumno
    Dim nuevos As List(Of Alumno)

    Try
      'If Me.dgvAlumnosSeccion.RowCount > 0 Then
      If Me.tabAlumnos.SelectedIndex = 0 Then
        nuevos = New List(Of Alumno)
        For Each dr As DataGridViewRow In Me.dgvAlumnosNuevos.Rows
          nuevos.Add(DirectCast(dr.DataBoundItem, Matricula).Alumno)
        Next
        obj.AsignarCodigoRecaudacion(nuevos)
      Else
        obj.AsignarCodigoRecaudacion(List)
      End If
      MessageBox.Show("Se registró correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

      'End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      obj = Nothing
    End Try
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarSeccion.Click
    Dim obj As New RNAlumno
    Dim sec As Seccion = Nothing

    Try
      List = New List(Of Alumno)
      sec = New Seccion(mOAnioActual, CType(Me.cboGrado.SelectedItem, Seccion).Grado, CType(Me.cboGrado.SelectedItem, Seccion).Letra)
      List = obj.ListarAlumnosSeccion_NombreCompleto(sec)
      Me.dgvAlumnosSeccion.AutoGenerateColumns = False
      Me.dgvAlumnosSeccion.DataSource = List
      Me.dgvAlumnosSeccion.Focus()
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnListarAlumnosNuevos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarAlumnosNuevos.Click
    Dim obj As New RNAlumno
    Dim nuevos As List(Of Matricula)

    Try
      'nuevos = New List(Of Matricula)
      nuevos = obj.ListarAlumnosSinCodigo(mOAnioActual)
      Me.dgvAlumnosNuevos.AutoGenerateColumns = False
      Me.dgvAlumnosNuevos.DataSource = nuevos
      Me.dgvAlumnosNuevos.Focus()
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      obj = Nothing
    End Try
  End Sub

  Private Sub dgvAlumnosNuevos_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvAlumnosNuevos.EditingControlShowing
    ' referencia a la celda
    Dim validar As TextBox = CType(e.Control, TextBox)
    ' agregar el controlador de eventos para el KeyPress
    AddHandler validar.KeyPress, AddressOf validar_Keypress
  End Sub

  Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
    Dim rn As RNAlumno
    Dim cod As Integer
    Dim nuevos As List(Of Matricula)

    nuevos = DirectCast(Me.dgvAlumnosNuevos.DataSource, List(Of Matricula))
    If nuevos IsNot Nothing AndAlso nuevos.Count > 0 Then
      Me.dgvAlumnosNuevos.DataSource = Nothing
      rn = New RNAlumno
      cod = rn.ObtenerNuevoCodigo

      For Each mat As Matricula In nuevos
        mat.Alumno.CodigoRecaudacion = cod.ToString
        cod += 1
      Next
      Me.dgvAlumnosNuevos.AutoGenerateColumns = False
      Me.dgvAlumnosNuevos.DataSource = nuevos
    End If
  End Sub
End Class