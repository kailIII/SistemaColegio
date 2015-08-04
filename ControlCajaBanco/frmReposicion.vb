Public Class frmReposicion

  Dim codigoNuevo As Integer
  Shared frm As Form

  Public Shared Sub Crear(ByVal pPadre As Form)
    If frmReposicion.frm Is Nothing Then
      frmReposicion.frm = New frmReposicion
      frmReposicion.frm.MdiParent = pPadre
      frmReposicion.frm.Show()
      frmReposicion.frm.WindowState = FormWindowState.Maximized
    Else
      frm.Activate()
    End If
  End Sub

  Private Sub frmReposicion_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmReposicion.frm = Nothing
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Me.Habilitar(False)
    Dim rnReposicion As New RNReposicion
    Dim listaReposicion = rnReposicion.ListarReposicion
    Me.dgvReposicion.AutoGenerateColumns = False
    Me.dgvReposicion.DataSource = listaReposicion
  End Sub

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    Me.Limpiar()
    Me.Habilitar(True)
    Me.codigoNuevo = 0
    Me.btnRegistrar.Text = "&Registrar"
  End Sub

  Private Sub Habilitar(ByVal wBoolean As Boolean)
    Me.lblFecha.Enabled = wBoolean
    Me.lblMonto.Enabled = wBoolean
    Me.lblPersonal.Enabled = wBoolean
    Me.nudMonto.Enabled = wBoolean
    Me.cboPersonal.Enabled = wBoolean
    ' Me.dtpFecha.Enabled = wBoolean
    Me.btnRegistrar.Enabled = wBoolean
    Me.btncancelar.Enabled = wBoolean
    Me.gbMantenimiento.Enabled = wBoolean

    wBoolean = Not wBoolean
    Me.btnListar.Enabled = wBoolean
    Me.dgvReposicion.Enabled = wBoolean
    Me.btnEditar.Enabled = wBoolean
    Me.btnAnular.Enabled = wBoolean
    Me.btnNuevo.Enabled = wBoolean
    Me.gbListado.Enabled = wBoolean
  End Sub

  Private Function Validar() As Boolean
    Dim valido = True
    
      If Me.nudMonto.Value = 0 Then
        valido = False
        MessageBox.Show("Debe ingresar monto", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Else
        If Me.cboPersonal.SelectedIndex = -1 Then
          valido = False
          MessageBox.Show("Debe elegir Personal", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End If

    Return valido
  End Function

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim monto = Me.nudMonto.Value
    Dim personal = DirectCast(Me.cboPersonal.SelectedItem, Personal)
    Dim oReposicion As New Reposicion(0, monto, Nothing, True, personal, mOCajaChica)
    Dim rnReposicion As New RNReposicion
    Try
      If Validar() Then
        If Me.codigoNuevo = 0 Then
          rnReposicion.RegistrarReposicion(oReposicion)
          MessageBox.Show("Se registró correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          oReposicion.codigoReposicion = Me.codigoNuevo
          rnReposicion.ModificarReposicion(oReposicion)
          MessageBox.Show("Se actualizó correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Habilitar(False)
        Me.btnListar.PerformClick()
      End If
    Catch ex As Exception
      If Me.codigoNuevo = 0 Then
        MessageBox.Show("No se registró", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Else
        MessageBox.Show("No se actualizó", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
    Finally
      rnReposicion = Nothing
      oReposicion = Nothing
    End Try
  End Sub

  Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
    Me.nudMonto.Value = 0
    Me.dtpFecha.Value = DateTime.Now
    Me.cboPersonal.SelectedIndex = -1
    Me.Habilitar(False)
  End Sub

  Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
    If Me.dgvReposicion.SelectedRows.Count > 0 Then
      With DirectCast(Me.dgvReposicion.SelectedRows.Item(0).DataBoundItem, Reposicion)
        Me.codigoNuevo = .codigoReposicion
        Me.nudMonto.Value = CDec(.monto)
        Me.cboPersonal.SelectedValue = .Personal.Codigo
        Me.dtpFecha.Value = .fecha
      End With
      Me.btnRegistrar.Text = "&Actualizar"
      Me.Habilitar(True)
    End If
  End Sub

  Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
    If Me.dgvReposicion.SelectedRows.Count > 0 Then
      Dim rnReposicion As New RNReposicion
      Dim codigo As Integer, monto As Double
      Try
        With DirectCast(Me.dgvReposicion.CurrentRow.DataBoundItem, Reposicion)
          codigo = .codigoReposicion
          monto = .monto
        End With
        rnReposicion.ModificarVigenciaReposicion(New Reposicion(codigo,
                                                 monto,mOCajaChica))
        MessageBox.Show("Se eliminó correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.btnListar.PerformClick()
      Catch ex As Exception
        MessageBox.Show("No se pudo eliminar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Finally
        rnReposicion = Nothing
      End Try
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub frmReposicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.Limpiar()
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btncancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnEditar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Editar.jpg")
    Me.CargarPersonal()
  End Sub

  Public Sub CargarPersonal()
    Dim rnPersonal As New RNPersonal
    Dim listaPersonal = rnPersonal.listarPersonal
    Me.cboPersonal.ValueMember = "Codigo"
    Me.cboPersonal.DisplayMember = "NombreCompleto"
    Me.cboPersonal.DataSource = listaPersonal
    Me.cboPersonal.SelectedIndex = -1
    listaPersonal = Nothing

  End Sub

  Private Sub Limpiar()
    Me.cboPersonal.SelectedIndex = -1
    Me.nudMonto.Value = 0
  End Sub

End Class