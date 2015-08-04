Public Class frmInformacionAlumno

  Private Alumno As Alumno
  Private Padre As Apoderado
  Private Madre As Apoderado

  Public Sub Presentar()
    Me.txtAnio.Text = moAnioActual.anio
    Me.ShowDialog()
  End Sub

  Public Sub Presentar(ByVal wAlumno As Alumno)
    Me.txtAnio.Text = moAnioActual.anio
    Me.Alumno = wAlumno
    Me.PresentarInformacion(Me.Alumno)
    Me.ShowDialog()
  End Sub

  Private Sub btnBuscarAlumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarAlumno.Click
    Me.Buscar()
  End Sub

  Private Sub Buscar()
    Dim frm As New frmBuscarAlumnoAnio

    Me.Alumno = frm.Buscar()
    frm.Dispose()
    frm = Nothing
    If Me.Alumno IsNot Nothing AndAlso Me.Alumno.Codigo <> 0 Then
      Me.PresentarInformacion(Me.Alumno)
    Else
      Me.txtAlumno.Text = ""
      Me.txtSeccion.Text = ""
      Me.txtTutor.Text = ""
      Me.txtAula.Text = ""
      Me.txtApoderado.Text = ""
      Me.txtParentesco.Text = ""
    End If
    Me.Padre = Nothing
    Me.Madre = Nothing
    Me.tabDatos.SelectedIndex = 0
  End Sub

  Private Sub PresentarInformacion(ByVal wAlumno As Alumno)
    Dim rn As New RNMatricula
    Dim rnAl As New RNAlumno
    Dim mat As New Matricula With {.Alumno = wAlumno, .Anio = moAnioActual}

    Me.txtAlumno.Text = Me.Alumno.NombreCompleto
    mat.Alumno = rnAl.Leer(mat.Alumno)
    rnAl = Nothing
    Me.txtTelefono.Text = mat.Alumno.Telefono
    Me.txtDNI.Text = mat.Alumno.DNI
    Me.txtCodigo.Text = mat.Alumno.CodigoEducando
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
      MessageBox.Show("No se encontró información de matrícula", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Me.MostrarImagenes()
  End Sub

  Public Sub MostrarImagenes()
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnBuscarAlumno.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Buscar.png")
  End Sub

  Private Sub tabDatos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabDatos.SelectedIndexChanged
    If Me.Alumno IsNot Nothing Then
      If tabDatos.SelectedIndex = 1 AndAlso Me.Padre Is Nothing Then
        MostrarDatosPadre()
      ElseIf tabDatos.SelectedIndex = 2 AndAlso Me.Madre Is Nothing Then
        MostrarDatosMadre()
      End If
    End If
  End Sub

  Private Sub MostrarDatosPadre()
    Dim rn As New RNApoderado
    Dim par As Apoderado

    par = rn.LeerParienteAlumno(Me.Alumno, "Padre")
    rn = Nothing
    If par IsNot Nothing Then
      Me.txtNombrePadre.Text = par.NombreCompleto
      Me.txtDireccionPadre.Text = par.Direccion
      Me.txtTelCasaPadre.Text = par.TelefonoCasa
      Me.txtTelTrabajoPadre.Text = par.TelefonoTrabajo
      Me.txtCelularPadre.Text = par.Celular
      Me.txtCorreoPadre.Text = par.Email
      par = Nothing
    Else
      MessageBox.Show("No se encontraron datos del padre", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub MostrarDatosMadre()
    Dim rn As New RNApoderado
    Dim par As Apoderado

    par = rn.LeerParienteAlumno(Me.Alumno, "Madre")
    rn = Nothing
    If par IsNot Nothing Then
      Me.txtNombreMadre.Text = par.NombreCompleto
      Me.txtDireccionMadre.Text = par.Direccion
      Me.txtTelCasaMadre.Text = par.TelefonoCasa
      Me.txtTelTrabajoMadre.Text = par.TelefonoTrabajo
      Me.txtCelularMadre.Text = par.Celular
      Me.txtCorreoMadre.Text = par.Email
      par = Nothing
    Else
      MessageBox.Show("No se encontraron datos de la madre", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

End Class