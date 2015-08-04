

Public Class frmCerrarPeriodo

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub frmCerrarPeriodo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.txtPeriodo.Text = mOPeriodoActual.Anio & " - " & mOPeriodoActual.Nombre
    MostrarImagenes()
  End Sub

  Private Sub MostrarImagenes()
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Close()
  End Sub

  Private Sub btnCerrarPer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarPer.Click
    Dim obj As RNPeriodoAcademico = Nothing

    If Me.rbCompAsist.Checked Or Me.rbPromedioNotas.Checked Then
      If MessageBox.Show("Realmente desea realizar esta operación", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
        Try
          obj = New RNPeriodoAcademico
          If Me.rbPromedioNotas.Checked Then
            obj.CerrarPeriodo(New PeriodoAcademico(mOPeriodoActual.Codigo))
            MessageBox.Show("Promedios calculados con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          ElseIf Me.rbCompAsist.Checked Then
            obj.CerrarCompAsist(New PeriodoAcademico(mOPeriodoActual.Codigo))
            MessageBox.Show("Promedios de comportamiento y asistencias calculados con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          End If

        Catch ex As Exception
          MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Question)
        Finally
          obj = Nothing
          'Me.Close()
        End Try
      End If
    Else
      MessageBox.Show("No ha seleccinado una opción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Question)
    End If

  End Sub

End Class