Public Class frmReporteAlumnosNoProgramados

  Private Sub frmReporteNotasPlanLector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.txtAnio.Text = moAnioActual.Anio
    Me.CargarNiveles()
  End Sub

  Public Sub CargarNiveles()
    Dim ListNa As List(Of Nivel)
    Dim objNa As New RNNivel

    ListNa = objNa.Listar()
    objNa = Nothing
    cboNivel.DisplayMember = "nombre"
    cboNivel.ValueMember = "codigo"
    cboNivel.DataSource = ListNa
    ListNa = Nothing
    Me.cboSeccion.SelectedIndex = -1
  End Sub

  Public Sub Gestionar()
    Me.Show()
    Me.WindowState = FormWindowState.Maximized
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim rn As RNSeccion
    Dim sec As Seccion
    Dim dt As DataTable

    If cboSeccion.SelectedIndex > -1 Then
      sec = DirectCast(Me.cboSeccion.SelectedItem, Seccion)
      sec.Anio = moAnioActual
      rn = New RNSeccion
      dt = rn.ListarAlumnosPLNoProgramados(sec)
      dt.Columns.Add("Alumno", GetType(String), "apellidoPat + ' ' + apellidoMat + ' ' + Nombre")
      dgvAlumnos.AutoGenerateColumns = False
      dgvAlumnos.DataSource = dt
    Else
      MessageBox.Show("Debe seleccionar una sección", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub cboNivel_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNivel.Leave
    Me.ListarSecciones()
  End Sub

  Public Sub ListarSecciones()
    Dim ListSec As List(Of Seccion)
    Dim objS As New RNSeccion

    If CType(Me.cboNivel.SelectedItem, Nivel) IsNot Nothing Then
      ListSec = objS.Leer_NivelAcad(moAnioActual, DirectCast(cboNivel.SelectedItem, Nivel), 1)
      cboSeccion.DisplayMember = "numeroletra"
      cboSeccion.ValueMember = "codigoG"
      cboSeccion.DataSource = ListSec
      ListSec = Nothing
    Else
      Me.cboSeccion.DataSource = Nothing
      Me.cboSeccion.SelectedIndex = -1
    End If
  End Sub

End Class