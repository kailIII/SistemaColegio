Public Class frmGestionRegimenPension

  Private moService As EmpresaService

#Region "Control de teclas"
  Private Sub txtRUC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
    If Char.IsDigit(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False Then
      e.Handled = True
    End If
  End Sub
#End Region

#Region "Validacion"

  Private Sub txtRUC_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodigo.Validating
    If txtCodigo.Text.Length = 0 Then
      e.Cancel = True
      ErrAmbientes.SetError(txtCodigo, "Debe indicar el RUC")
    Else
      ErrAmbientes.SetError(txtCodigo, "")
    End If
  End Sub
#End Region

  Private Sub frmGestionAmbientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnModificar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")

    ListarServices()
    Me.txtCodigo.Focus()
    Me.moService = Nothing
  End Sub

  Private Sub ListarServices()
    Dim rn As New RNEmpresaService
    Dim services As List(Of EmpresaService)

    services = rn.Listar
    dgvServices.AutoGenerateColumns = False
    dgvServices.DataSource = services
  End Sub

  Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim rn As RNEmpresaService = Nothing

    If Me.ValidateChildren() Then
      rn = New RNEmpresaService
      Try
        If moService Is Nothing Then
          rn.Registrar(New EmpresaService())
        Else
          rn.Modificar(New EmpresaService())
        End If
        ListarServices()
        Habilitar(True)
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        rn = Nothing
      End Try
    End If
  End Sub
  Private Sub LimpiarControles()
    Me.txtCodigo.Text = ""
    Me.txtNombre.Text = ""
    Me.chkVigente.Checked = False
    Me.nudAporte.Value = 0
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
    Me.Dispose()
  End Sub

  Public Sub Habilitar(ByVal habilitado As Boolean)
    If habilitado = True Then
      Me.btnRegistrar.Text = "&Registrar"
    Else
      Me.btnRegistrar.Text = "&Modificar"
    End If
    Me.LimpiarControles()
    Me.txtCodigo.Focus()
  End Sub

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click, dgvServices.DoubleClick
    If dgvServices.CurrentRow IsNot Nothing Then
      Me.moService = DirectCast(dgvServices.CurrentRow.DataBoundItem, EmpresaService)
      Habilitar(False)
      PresentarDatos()
    Else
      MessageBox.Show("Debe seleccionar una service", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub
  Private Sub PresentarDatos()
    Dim rn As New RNEmpresaService
    Dim es As EmpresaService

    es = rn.Leer(moService)
    rn = Nothing
    If es IsNot Nothing Then
      txtCodigo.Text = es.RUC
      txtNombre.Text = es.razonSocial
      chkVigente.Checked = es.centroRiesgo
      nudAporte.Value = CDec(es.tasaSCTR)
      es = Nothing
    Else
      moService = Nothing
      MessageBox.Show("No se encontro la service", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Habilitar(True)
    Me.moService = Nothing
  End Sub

End Class