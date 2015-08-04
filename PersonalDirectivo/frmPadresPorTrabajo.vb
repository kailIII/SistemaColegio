Public Class frmPadresPorTrabajo

  Private errReporte As ErrorProvider

  Public WriteOnly Property ErrorReporte() As ErrorProvider
    Set(ByVal value As ErrorProvider)
      Me.errReporte = value
    End Set
  End Property

  Private Sub frmPadresPorTrabajo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ListarOcupaciones()
    ListarProfesiones()
    ListarEmpresas()
    MostrarImagenes()
  End Sub

  Private Sub MostrarImagenes()
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
  End Sub

  Public Sub ListarEmpresas()
    Dim obj As New RNApoderado
    Dim lp As List(Of String)

    lp = obj.ListarLugaresTrabajo
    obj = Nothing
    lp.Insert(0, "CUALQUIER EMPRESA")
    Me.cboLugarTrab.DataSource = lp
    Me.cboLugarTrab.SelectedIndex = 0
  End Sub

  Public Sub ListarProfesiones()
    Dim obj As New RNProfesion
    Dim lp As List(Of Profesion)

    lp = obj.ListarProfesiones
    obj = Nothing
    lp.Insert(0, New Profesion(0, "CUALQUIER PROFESIÓN"))
    Me.cboProfesion.DisplayMember = "Nombre"
    Me.cboProfesion.DataSource = lp
    Me.cboProfesion.SelectedIndex = 0
  End Sub

  Public Sub ListarOcupaciones()
    Dim obj As New RNOcupacion
    Dim lo As List(Of Ocupacion)

    lo = obj.ListarOcupaciones
    obj = Nothing
    lo.Insert(0, New Ocupacion(0, "CUALQUIER OCUPACIÓN"))
    Me.cboOcupacion.DisplayMember = "Nombre"
    Me.cboOcupacion.DataSource = lo
    Me.cboOcupacion.SelectedIndex = 0
  End Sub

  Public Sub Presentar()

    Me.Show()
    Me.WindowState = FormWindowState.Maximized
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim rn As RNApoderado
    Dim lista As List(Of Matricula)
    Dim empresa As String, prof As String, ocup As String

    If validarControles() = True Then
      If cboLugarTrab.SelectedIndex <> 0 AndAlso cboLugarTrab.Text.ToUpper.IndexOf("CUALQUIER") = -1 Then
        empresa = cboLugarTrab.Text
      Else
        empresa = ""
      End If
      If cboProfesion.SelectedIndex <> 0 AndAlso cboProfesion.Text.ToUpper.IndexOf("CUALQUIER") = -1 Then
        prof = cboProfesion.Text
      Else
        prof = ""
      End If
      If cboOcupacion.SelectedIndex <> 0 AndAlso cboOcupacion.Text.ToUpper.IndexOf("CUALQUIER") = -1 Then
        ocup = cboOcupacion.Text
      Else
        ocup = ""
      End If
      rn = New RNApoderado
      lista = rn.ListarApoderadosTrabajo(moAnioActual, txtNombre.Text, ocup, prof, empresa)
      rn = Nothing

      dgvApoderados.AutoGenerateColumns = False
      dgvApoderados.DataSource = lista
    End If
  End Sub

  Private Function validarControles() As Boolean
    Dim info As New System.ComponentModel.CancelEventArgs

    cboLugarTrab_Validating(Nothing, info)
    cboProfesion_Validating(Nothing, info)
    cboOcupacion_Validating(Nothing, info)

    Return Not info.Cancel
  End Function

  Private Sub cboLugarTrab_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboLugarTrab.Validating
    If cboLugarTrab.Text.Length = 0 Then
      Me.errReporte.SetError(cboLugarTrab, "Debe indicar un criterio")
      e.Cancel = True
    Else
      Me.errReporte.SetError(cboLugarTrab, "")
    End If
  End Sub

  Private Sub cboProfesion_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboProfesion.Validating
    If cboProfesion.Text.Length = 0 Then
      Me.errReporte.SetError(cboProfesion, "Debe indicar una profesión")
      e.Cancel = True
    Else
      Me.errReporte.SetError(cboProfesion, "")
    End If
  End Sub

  Private Sub cboOcupacion_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboOcupacion.Validating
    If cboOcupacion.Text.Length = 0 Then
      Me.errReporte.SetError(cboOcupacion, "Debe indicar una ocupación")
      e.Cancel = True
    Else
      Me.errReporte.SetError(cboOcupacion, "")
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub
End Class