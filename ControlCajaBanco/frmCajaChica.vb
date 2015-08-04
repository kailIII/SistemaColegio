Public Class frmCajaChica

  Dim codigoNuevo As Integer
  Shared frm As Form

  Public Shared Sub Crear(ByVal pPadre As Form)
    If frmCajaChica.frm Is Nothing Then
      frmCajaChica.frm = New frmCajaChica
      frmCajaChica.frm.MdiParent = pPadre
      frmCajaChica.frm.Show()
      frmCajaChica.frm.WindowState = FormWindowState.Maximized
    Else
      frm.Activate()
    End If
  End Sub
  
  Private Sub frmCajaChica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.Limpiar()
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnEditar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Editar.jpg")
    Me.CargarPersonal()
    
    Me.CargarTipoDocumento()
  End Sub

  Public Sub CargarPersonal()
    Dim rnPersonal As New RNPersonal
    Dim listaPersonal = rnPersonal.listarPersonal
    Me.cboBeneficiario.ValueMember = "Codigo"
    Me.cboBeneficiario.DisplayMember = "NombreCompleto"
    Me.cboBeneficiario.DataSource = listaPersonal
    Me.cboBeneficiario.SelectedIndex = -1
    listaPersonal = Nothing

  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    Me.Limpiar()
    Me.Habilitar(True)
    Me.codigoNuevo = 0
    Me.btnRegistrar.Text = "&Registrar"
  End Sub

  Private Sub Limpiar()
    Me.cboBeneficiario.SelectedIndex = -1
    Me.cboDescripcion.SelectedIndex = -1
    Me.cboTipoDocumento.SelectedIndex = -1
    Me.txtNumero.Text = ""
    Me.nudMonto.Value = 0
  End Sub

  Private Sub Habilitar(ByVal wBoolean As Boolean)
    Me.gbMantenimiento.Enabled = wBoolean
    Me.lblBeneficiario.Enabled = wBoolean
    Me.cboBeneficiario.Enabled = wBoolean
    Me.lblDescripcion.Enabled = wBoolean
    Me.cboDescripcion.Enabled = wBoolean
    Me.lblTipo.Enabled = wBoolean
    Me.cboTipoDocumento.Enabled = wBoolean
    'Me.lblNumero.Enabled = wBoolean
    'Me.txtNumero.Enabled = wBoolean
    If Me.cboTipoDocumento.SelectedIndex <> -1 Then
      Dim tipo = DirectCast(Me.cboTipoDocumento.SelectedItem, TipoDocumento).descripcion
      If tipo <> "SIN DOCUMENTO" Then
        Me.txtNumero.Enabled = True
        Me.lblNumero.Enabled = True
      End If
    End If

    Me.lblMonto.Enabled = wBoolean
    Me.nudMonto.Enabled = wBoolean
    ' Me.dtpFecha.Enabled = wBoolean
    Me.btnRegistrar.Enabled = wBoolean
    Me.btncancelar.Enabled = wBoolean

    wBoolean = Not wBoolean
    Me.btnListar.Enabled = wBoolean
    Me.dgvCajaChica.Enabled = wBoolean
    Me.btnEditar.Enabled = wBoolean
    Me.btnAnular.Enabled = wBoolean
    Me.btnNuevo.Enabled = wBoolean
    Me.gbListado.Enabled = wBoolean
  End Sub

  Private Function Validar() As Boolean
    Dim a = Me.cboDescripcion.Text
    Dim b = Me.cboDescripcion.SelectedText
    Dim c = Me.cboDescripcion.SelectedValue
    Dim valido = True
    If Me.cboBeneficiario.SelectedIndex = -1 Then
      MessageBox.Show("Debe elegir beneficiario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    Else
      If CInt(Me.cboDescripcion.SelectedValue) = -1 AndAlso Me.cboDescripcion.Text = "" Then
        MessageBox.Show("Debe elegir o ingresar descripción", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Else

        If Me.nudMonto.Value = 0 Then
          valido = False
          MessageBox.Show("Debe ingresar monto", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      End If

    End If


    Return valido
  End Function

  Private Sub frmReposicion_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmCajaChica.frm = Nothing
  End Sub

  Private Sub rbEgreso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEgreso.CheckedChanged
    Me.CargarDescripcion("E")
  End Sub

  Private Sub CargarDescripcion(ByVal wTipo As String)
    Dim rnConcepto As New RNConceptoOperacion
    Me.cboDescripcion.DataSource = rnConcepto.listarDescripcion(wTipo)
    Me.cboDescripcion.ValueMember = "codigoConceptoOperacion"
    Me.cboDescripcion.DisplayMember = "descripcion"
    Me.cboDescripcion.SelectedIndex = -1
  End Sub

  Private Sub CargarTipoDocumento()
    Dim rnTipoDocumento As New RNTipoDocumento
    Dim lista = rnTipoDocumento.listarTipoDocumento()
    Me.cboTipoDocumento.DataSource = lista
    Me.cboTipoDocumento.DisplayMember = "descripcion"
    Me.cboTipoDocumento.ValueMember = "codigoTipoDocumento"
    Me.cboTipoDocumento.SelectedIndex = -1
    lista = Nothing
  End Sub

  Private Sub cboTipoDocumento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDocumento.SelectedIndexChanged
    If Me.cboTipoDocumento.SelectedItem IsNot Nothing Then
      Dim tipo = DirectCast(Me.cboTipoDocumento.SelectedItem, TipoDocumento).descripcion
      If tipo <> "SIN DOCUMENTO" Then
        Me.txtNumero.Enabled = True
        Me.lblNumero.Enabled = True
      Else
        Me.txtNumero.Enabled = False
        Me.lblNumero.Enabled = False
      End If
    End If

  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim rnOpCajaChica As New RNOperacionCajaChica
    Dim tipo = "E"
    If Me.rbIngreso.Checked = True Then
      tipo = "I"
    End If
    Try
      If Validar() Then
        If Me.codigoNuevo = 0 Then
          rnOpCajaChica.RegistrarOperacionCajaChica(New OperacionCajaChica(0, Nothing, True, Me.txtNumero.Text,
                                                      New TipoDocumento(CInt(Me.cboTipoDocumento.SelectedValue),
                                                          Me.cboTipoDocumento.Text),
                                                      New Personal(CInt(Me.cboBeneficiario.SelectedValue)), mOCajaChica,
                                                      New ConceptoOperacion(CInt(Me.cboDescripcion.SelectedValue),
                                                                             Me.cboDescripcion.Text, tipo), CDec(Me.nudMonto.Value)))
          MessageBox.Show("Se registró correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

          rnOpCajaChica.ModificarOperacionCajaChica(New OperacionCajaChica(Me.codigoNuevo, Now, True, Me.txtNumero.Text,
                                                      New TipoDocumento(CInt(Me.cboTipoDocumento.SelectedValue),
                                                          Me.cboTipoDocumento.Text),
                                                      New Personal(CInt(Me.cboBeneficiario.SelectedValue)), mOCajaChica,
                                                      New ConceptoOperacion(CInt(Me.cboDescripcion.SelectedValue),
                                                                             Me.cboDescripcion.Text, tipo), CDec(Me.nudMonto.Value)))
          MessageBox.Show("Se modificó correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Limpiar()
        Me.Habilitar(False)
        Me.btnListar.PerformClick()
      End If
    Catch ex As Exception
      If Me.codigoNuevo = 0 Then
        MessageBox.Show("No se registró", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Else
        MessageBox.Show("No se actualizó", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
    End Try
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim rnOpCajaChica As New RNOperacionCajaChica
    Dim fechaInicio = Me.dtpFechaInicio.Value
    Dim fechaFin = Me.dtpFechaFin.Value
    Dim lista As New List(Of OperacionCajaChica)
    lista = rnOpCajaChica.listarOperacionCajaChica(fechaInicio, fechaFin, mOCajaChica)
    Me.dgvCajaChica.AutoGenerateColumns = False
    Me.dgvCajaChica.DataSource = lista
    Me.Habilitar(False)
  End Sub

  Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
    If Me.dgvCajaChica.SelectedRows.Count > 0 Then
      With DirectCast(Me.dgvCajaChica.SelectedRows.Item(0).DataBoundItem, OperacionCajaChica)
        Me.codigoNuevo = .codigoOperacion
        Me.nudMonto.Value = CDec(.monto)
        Me.cboBeneficiario.SelectedValue = .Beneficiario.Codigo
        Me.cboDescripcion.SelectedValue = .ConceptoOperacion.codigoConceptoOperacion
        Me.cboTipoDocumento.SelectedValue = .TipoDocumento.codigoTipoDocumento
        Me.txtNumero.Text = .numeroDocumento
        If .ConceptoOperacion.tipo = "E" Then
          Me.rbEgreso.Checked = True
        Else
          Me.rbIngreso.Checked = True
        End If
        Me.codigoNuevo = .codigoOperacion
      End With
      Me.btnRegistrar.Text = "&Actualizar"
      Me.Habilitar(True)
    End If
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.nudMonto.Value = 0
    Me.cboBeneficiario.SelectedValue = -1
    Me.cboDescripcion.SelectedValue = -1
    Me.cboTipoDocumento.SelectedValue = -1
    Me.txtNumero.Text = ""
    Me.rbEgreso.Checked = True
    Me.Habilitar(False)
  End Sub

  Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
    
  End Sub
End Class