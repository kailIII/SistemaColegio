
Public Class frmBuscarAlumnoAnio

  Public Alumno As Alumno

  Private Sub btseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnseleccionar.Click, dgvAlumnos.DoubleClick
    Seleccionar()
  End Sub

  Private Sub Seleccionar()
    Try
      Alumno = CType(Me.dgvAlumnos.Rows(Me.dgvAlumnos.CurrentRow.Index).DataBoundItem, Matricula).Alumno
      Me.Close()
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    BuscarAlumnos()
  End Sub

  Private Sub BuscarAlumnos()
    Dim obj As New RNMatricula
    Dim la As List(Of Matricula)

    la = obj.ListarAnio(txtNombreBuscar.Text.Trim, modPrincipal.moAnioActual)
    obj = Nothing
    dgvAlumnos.AutoGenerateColumns = False
    dgvAlumnos.DataSource = la
    Me.dgvAlumnos.Focus()
  End Sub

  Public Sub MostrarImagenes()
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnBuscar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Buscar.png")
    Me.btnseleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
  End Sub

  Private Sub txtNombreBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    If Not (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) And Not (Asc(e.KeyChar) = 8) And Not (Asc(e.KeyChar) = 32) And Not (Asc(e.KeyChar) = 209) And Not (Asc(e.KeyChar) = 241) Then
      e.KeyChar = CChar("")
    End If
  End Sub

  Public Function Buscar() As Alumno
    Me.ShowDialog()
    Return Alumno
  End Function

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Close()
  End Sub

  Private Sub frmBuscarAlumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    MostrarImagenes()
    Me.txtNombreBuscar.Focus()
  End Sub

  Private Sub frmBuscarAlumno_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
    Me.txtNombreBuscar.Focus()
  End Sub

  Private Sub txtNombreBuscar_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreBuscar.Enter
    Me.AcceptButton = btnBuscar
  End Sub

  Private Sub dgvAlumnos_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvAlumnos.Enter
    Me.AcceptButton = btnseleccionar
  End Sub

  Private Sub frmBuscarAlumno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
    If Convert.ToInt16(e.KeyChar) = Keys.Enter AndAlso Me.ActiveControl.Name = "dgvAlumnos" AndAlso _
       dgvAlumnos.CurrentRow IsNot Nothing Then

      btnseleccionar.PerformClick()
      e.Handled = True
    End If
  End Sub

  Private Sub dgvAlumnos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvAlumnos.KeyDown
    If e.KeyCode = Keys.Enter Then
      e.Handled = True
    End If
  End Sub

End Class