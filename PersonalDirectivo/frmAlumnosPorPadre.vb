Public Class frmAlumnosPorPadre

  Private Padre As Apoderado

  Public Sub Presentar()
    Me.txtAnio.Text = moAnioActual.Anio
    Me.ShowDialog()
  End Sub

  Public Sub Presentar(ByVal wAlumno As Alumno)
    Me.txtAnio.Text = moAnioActual.Anio
    Me.ShowDialog()
  End Sub

  Private Sub btnBuscarAlumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarAlumno.Click
    Dim rn As RNApoderado
    Dim frm As New frmBuscarPadreAnio
    Dim hijos As List(Of Matricula)

    Me.Padre = frm.Buscar
    Me.dgvApoderados.DataSource = Nothing
    If Me.Padre IsNot Nothing Then
      Me.txtPadre.Text = Me.Padre.NombreCompleto
      rn = New RNApoderado
      hijos = rn.ListarHijosPadreAnio(moAnioActual, Me.Padre)
      rn = Nothing
      If hijos.Count > 0 Then
        Me.dgvApoderados.AutoGenerateColumns = False
        Me.dgvApoderados.DataSource = hijos
      End If
    Else
      Me.txtPadre.Text = ""
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub frmInformacionAlumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.MostrarImagenes()
  End Sub

  Public Sub MostrarImagenes()
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnBuscarAlumno.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Buscar.png")
  End Sub

End Class