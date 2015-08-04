Public Class frmBuscarPersona

  Private Persona As Persona

  Private mControlError As ErrorProvider

  Public WriteOnly Property ControlError() As ErrorProvider
    Set(ByVal value As ErrorProvider)
      Me.mControlError = value
    End Set
  End Property

  Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click, dgvAlumnos.DoubleClick
    If dgvAlumnos.CurrentRow IsNot Nothing Then
      Persona = DirectCast(dgvAlumnos.CurrentRow.DataBoundItem, Persona)
      Me.Close()
    Else
      MessageBox.Show("No ha seleccionado ninguna persona", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Persona = Nothing
    Me.Close()
  End Sub

  Private Sub dgvAlumnos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvAlumnos.KeyDown
    If e.KeyCode = Keys.Enter Then
      e.Handled = True
    End If
  End Sub

  Private Sub frmBuscarAlumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    btnSeleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes/seleccionar.png")
    btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes/cancelar.png")
    Me.btnBuscar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes/Buscar.png")
  End Sub

  Public Function Buscar() As Persona
    Me.txtNombreBuscar.Focus()

    Me.ShowDialog()
    Return Me.Persona
  End Function

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click ', txtNombreBuscar.Enter
    Dim obj As RNPersona
    Dim la As List(Of Persona)

    Try
      obj = New RNPersona
      la = obj.Listar(txtNombreBuscar.Text.Trim)
      dgvAlumnos.AutoGenerateColumns = False
      dgvAlumnos.DataSource = la
      If la.Count > 0 Then
        dgvAlumnos.Focus()
      End If
    Catch ex As Exception
      dgvAlumnos.DataSource = Nothing
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      obj = Nothing
      la = Nothing
    End Try

  End Sub

  Private Sub txtNombreBuscar_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreBuscar.Enter
    Me.AcceptButton = Me.btnBuscar
  End Sub

  Private Sub dgvAlumnos_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvAlumnos.Enter
    Me.AcceptButton = btnSeleccionar
  End Sub

  Private Sub frmBuscarAlumno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
    If Convert.ToInt16(e.KeyChar) = Keys.Enter AndAlso Me.ActiveControl.Name = "dgvAlumnos" Then

      btnSeleccionar.PerformClick()
      e.Handled = True
    End If
  End Sub

  Private Sub dgvAlumnos_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvAlumnos.RowPostPaint
    If Me.dgvAlumnos.CurrentRow IsNot Nothing AndAlso e.RowIndex > -1 Then
      If TypeOf Me.dgvAlumnos.Rows(e.RowIndex).DataBoundItem Is Alumno Then
        Me.dgvAlumnos.Rows.Item(e.RowIndex).Cells(0).Value = DirectCast(Me.dgvAlumnos.Rows(e.RowIndex).DataBoundItem, Alumno).CodigoRecaudacion
      End If
    End If
  End Sub

End Class