Public Class frmModificarApoderados

  Private alumno As Alumno
  Private parientes As List(Of Parentesco)

  Private Sub frmModificarApoderados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    CargarImagenes()
  End Sub

  Private Sub CargarImagenes()
    Me.btnBuscarAlumno.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Buscar.png")
  End Sub

  Private Sub btnBuscarAlumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarAlumno.Click
    Buscar()
  End Sub

  Private Sub Buscar()
    Dim frm As New frmBuscarAlumno
    Dim al As New Alumno
    Dim rnAl As RNAlumno

    al = frm.Buscar()
    frm.Dispose()
    frm = Nothing
    If al.Codigo <> 0 Then
      txtAlumno.Text = al.NombreCompleto
      Me.alumno = al
      rnAl = New RNAlumno
      parientes = rnAl.ListarParientes(al)
      rnAl = Nothing
      dgvApoderados.AutoGenerateColumns = False
      dgvApoderados.DataSource = parientes
    Else
      Me.alumno = Nothing
      Me.txtAlumno.Text = ""
      Me.dgvApoderados.DataSource = Nothing
    End If
  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    Dim rnP As RNParentesco

    If parientes.Count > 0 Then
      Try
        rnP = New RNParentesco
        rnP.ModificarParentesco(alumno, parientes)
        rnP = Nothing
        MessageBox.Show("Actualización de datos terminó exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        rnP = Nothing
      End Try
    Else
      MessageBox.Show("No hay datos disponibles para actualizar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Close()
  End Sub

End Class