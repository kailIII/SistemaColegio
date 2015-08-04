Public Class frmInformacionAlumno


  Public Sub Presentar()
    txtAnio.Text = moAnioActual.anio
    Me.ShowDialog()
  End Sub

  Private Sub btnBuscarAlumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarAlumno.Click
    Buscar()
  End Sub

  Private Sub Buscar()
    Dim frm As New frmBuscarAlumno
    Dim al As New Alumno

    al = frm.Buscar()
    frm.Dispose()
    frm = Nothing
    If al IsNot Nothing AndAlso al.Codigo <> 0 Then
      Me.txtAlumno.Text = al.NombreCompleto
      PresentarInformacion(al)
    Else
      Me.txtAlumno.Text = ""
      Me.txtSeccion.Text = ""
      Me.txtTutor.Text = ""
      Me.txtAula.Text = ""
      Me.txtApoderado.Text = ""
      Me.txtParentesco.Text = ""
    End If
  End Sub

  Private Sub PresentarInformacion(ByVal wAlumno As Alumno)
    Dim rn As New RNMatricula
    Dim mat As New Matricula With {.Alumno = wAlumno, .Anio = moAnioActual}

    mat = rn.LeerInformacionMatricula(mat)
    rn = Nothing
    If mat IsNot Nothing Then
      txtSeccion.Text = mat.Seccion.NivelNumeroLetra2
      txtTutor.Text = mat.Seccion.Tutor.NombreCompleto
      With mat.Seccion.Aula
        txtAula.Text = .Local.Nombre & " - Pabellon " & .Pabellon & " - Aula " & .Numero
      End With
      txtApoderado.Text = mat.codigoApoderado.NombreCompleto
      txtParentesco.Text = mat.Parentesco.Parentesco
      mat = Nothing
    Else
      MessageBox.Show("No se encontró información del alumno", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Me.txtSeccion.Text = ""
      Me.txtTutor.Text = ""
      Me.txtAula.Text = ""
      Me.txtApoderado.Text = ""
      Me.txtParentesco.Text = ""
    End If

  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub frmInformacionAlumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    MostrarImagenes()
  End Sub

  Private Sub MostrarImagenes()
    Me.btnBuscarAlumno.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\buscar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
  End Sub

End Class