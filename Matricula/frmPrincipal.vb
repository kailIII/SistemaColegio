Public Class frmPrincipal

  Private Sub mnuGestionAlumnos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestionAlumnos.Click
    Dim f As New frmGestionAlumno
    f.Show(Me)
  End Sub

  Private Sub mnuGestionMatriculas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestionMatriculas.Click
    Dim objNivel As New RNNivel
    Dim objGrado As New RNGrado
    Dim objSec As New RNSeccion
    Dim f As frmGestionarMatricula

    If moAnioActual IsNot Nothing AndAlso (objNivel.Listar.Count > 0 And objGrado.Leer.Count > 0 And objSec.LeerSeccion_Anio(New AnioLectivo(moAnioActual.anio)).Count > 0) Then
      f = New frmGestionarMatricula
      f.Show(Me)
    Else
      MessageBox.Show("Ingrese año lectivo, niveles académicos, grados y secciones", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
    objGrado = Nothing
    objNivel = Nothing
    objSec = Nothing
  End Sub

  Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    With mOUsuario.Persona
      tslblUsuario.Text = .NombreCompleto
    End With
    If moAnioActual IsNot Nothing Then
      tslblPeriodo.Text = moAnioActual.anio
    Else
      tslblPeriodo.Text = "Año actual no seleccionado"
    End If

    If mOInstitucion IsNot Nothing Then
      Me.Text &= " - " & mOInstitucion.Nombre
    End If

    mnuGestionMatriculas.PerformClick()
  End Sub

  Private Sub GestionDePadresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGestionDePadresToolStripMenuItem.Click
    Dim f As New frmGestionApoderado

    f.Gestionar()
  End Sub

  Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
    Me.Close()
  End Sub

  Private Sub ToolStripMenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
    Dim f As New frmModificarApoderados

    f.ShowDialog()
    f = Nothing
  End Sub

  Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
    Dim f As New frmGenerarCarnet

    f.ComponenteError = Me.errGeneral
    f.DialogoGuardar = Me.sfdGuardar
    f.ShowDialog()
    f = Nothing
  End Sub

  Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
    Dim f As New frmBalancearSecciones

    f.Gestionar()
  End Sub
End Class
