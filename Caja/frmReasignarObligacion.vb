Public Class frmReasignarObligacion

  Private Anio As AnioLectivo
  Private Persona As Persona
  Private Obligacion As Obligacion

  Public Sub Reasignar(ByVal wAnio As AnioLectivo, ByVal wPersona As Persona, ByVal wObligacion As Obligacion)
    Me.Anio = wAnio
    Me.Persona = wPersona
    Me.Obligacion = wObligacion
    Me.txtAlumno.Text = Me.Persona.NombreCompleto
    Me.txtObligacion.Text = Me.Obligacion.Descripcion
    ListarHermanos()
    Me.ShowDialog()
  End Sub

  Private Sub ListarHermanos()
    Dim rn As New RNAlumno
    Dim hermanos As List(Of Matricula)

    hermanos = rn.ListarHermanosMatriculados(Me.Anio, Me.Persona)
    rn = Nothing

    Me.cboHermanos.DisplayMember = "NombreAlumno"
    Me.cboHermanos.DataSource = hermanos
    Me.cboHermanos.SelectedIndex = -1
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnReasignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReasignar.Click
    Dim rn As RNObligacion

    rn = New RNObligacion
    Try
      rn.CambiarMatricula(Me.Obligacion, DirectCast(Me.cboHermanos.SelectedItem, Matricula))
      Me.Close()
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      rn = Nothing
    End Try
  End Sub

End Class