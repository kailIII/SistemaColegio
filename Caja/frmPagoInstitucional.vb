Public Class frmPagoInstitucional

  Private Const LIMITE As Integer = 4

  Private alumnos As List(Of AlumnoBeneficiado)

  Private mControlError As ErrorProvider

  Public WriteOnly Property ControlError() As ErrorProvider
    Set(ByVal value As ErrorProvider)
      Me.mControlError = value
    End Set
  End Property

  Public Sub Registrar()
    Me.Show()
    Me.WindowState = FormWindowState.Maximized
  End Sub

  Private Sub frmPagoInstitucional_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.cboEntidad.SelectedIndex = 0
    Me.cboTipoDoc.SelectedIndex = 0
    Me.txtSerie.Text = "1"
    Me.ObtenerNumeracion()
    Me.CargarAnios(modPrincipal.mOInstitucion)
    Me.cboAnio.SelectedValue = mOAnioActual.Anio
    Me.ListarMotivos()
    Me.CargarIconos()
    Me.CargarEntidades()
  End Sub

  Private Sub CargarAnios(ByVal wInst As Institucion)
    Dim rnA As New RNAnioLectivo
    Dim lA As List(Of AnioLectivo)

    lA = rnA.Listar(wInst)
    cboAnio.DisplayMember = "Anio"
    cboAnio.ValueMember = "Anio"
    cboAnio.DataSource = lA
  End Sub

  Private Sub ListarMotivos()
    Dim rn As New RNBeneficio
    Dim Motivos As List(Of String)

    Motivos = rn.ListarMotivos
    rn = Nothing

    Me.cboMotivo.DataSource = Motivos
    Me.cboMotivo.Text = ""
    Me.cboMotivo.SelectedIndex = -1
  End Sub

  Private Sub ListarPagos()
    Dim rn As New RNProgramacionPago
    Dim Pagos As List(Of ProgramacionPago)

    If Me.cboAnio.SelectedIndex > -1 AndAlso Me.cboEntidad.SelectedIndex > -1 Then
      Pagos = rn.ListarPagosRealizar(DirectCast(Me.cboAnio.SelectedItem, AnioLectivo), Me.cboEntidad.Text.Substring(0, 1))
      rn = Nothing
      Me.cboProgramacion.DataSource = Pagos
      Me.cboProgramacion.DisplayMember = "Descripcion"
      Me.cboProgramacion.Text = ""
      Me.cboProgramacion.SelectedIndex = -1
    Else
      MessageBox.Show("Debe seleccionar el año lectivo y la entidad", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Public Sub CargarIconos()
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
  End Sub

  Private Sub ObtenerNumeracion()
    Dim rn As RNDocumentoIngreso
    Dim doc As DocumentoIngreso

    If Me.cboEntidad.SelectedIndex > -1 AndAlso Me.cboTipoDoc.SelectedIndex > -1 AndAlso String.IsNullOrEmpty(Me.txtSerie.Text) = False Then
      rn = New RNDocumentoIngreso
      doc = rn.ObtenerNumeracion(cboEntidad.Text.Substring(0, 1), cboTipoDoc.Text.Substring(0, 1), CInt(Me.txtSerie.Text))
      rn = Nothing
      txtSerie.Text = doc.Serie.ToString("000")
      txtNumero.Text = doc.Numero.ToString("0000000")
      doc = Nothing
    End If
  End Sub

  Public Sub CargarEntidades()
    Dim ListA As New List(Of EntidadFinanciera)
    Dim objE As New RNEntidadFinanciera

    ListA = objE.Listar
    objE = Nothing
    If ListA.Count > 0 Then
      cboEntidadFinanciera.DisplayMember = "nombre"
      cboEntidadFinanciera.ValueMember = "codigoEntidad"
      cboEntidadFinanciera.DataSource = ListA
      If ListA.Count = 1 Then
        cboEntidadFinanciera.SelectedIndex = 0
        cboCuenta.Focus()
      Else
        cboEntidadFinanciera.SelectedIndex = -1
      End If
      ListA = Nothing
    End If
  End Sub

  Private Sub cboEntidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEntidad.SelectedIndexChanged
    Me.ObtenerNumeracion()
    Me.ListarPagos()
    Me.dgvAlumnos.DataSource = Nothing
  End Sub

  Private Sub cboEntidadFinanciera_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEntidadFinanciera.Leave
    Dim rn As RNEntidadFinanciera
    Dim cuentas As List(Of CuentaBancaria)

    If cboEntidadFinanciera.SelectedItem IsNot Nothing Then
      rn = New RNEntidadFinanciera
      cboCuenta.DisplayMember = "Numero"
      cboCuenta.ValueMember = "Numero"
      cuentas = rn.ListarCuentas(DirectCast(cboEntidadFinanciera.SelectedItem, EntidadFinanciera))
      cboCuenta.DataSource = cuentas
      If cuentas.Count = 1 Then
        cboCuenta.SelectedIndex = 0
        txtVoucher.Focus()
      Else
        cboCuenta.SelectedIndex = -1
      End If
    Else
      cboCuenta.DataSource = Nothing
      MessageBox.Show("Debe seleccionar una entidad financiera", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim rb As New RNBeneficio

    Me.alumnos = rb.ListarBeneficiados(DirectCast(Me.cboAnio.SelectedItem, AnioLectivo), cboMotivo.Text, cboProgramacion.Text)
    Me.dgvAlumnos.AutoGenerateColumns = False
    Me.dgvAlumnos.DataSource = Me.alumnos
    Me.dgvAlumnos.Focus()
    Me.chkTodos.Checked = True
  End Sub

  Private Sub cboTipoDoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDoc.SelectedIndexChanged
    Me.ObtenerNumeracion()
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Close()
  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim crp As crpDocumentoIngreso
    Dim pago As VoucherPago
    Dim cont As Integer = 0

    If Me.ValidateChildren AndAlso Me.VerificarMonto() = True Then
      Try
        pago = New VoucherPago
        pago.CuentaBancaria = DirectCast(Me.cboCuenta.SelectedItem, CuentaBancaria)
        pago.NumOperacion = Me.txtVoucher.Text
        pago.Fecha = Me.dtpFechaVoucher.Value
        pago.Monto = Me.nudMontoVoucher.Value
        crp = New crpDocumentoIngreso
        For Each al In Me.alumnos
          If al.Seleccionado = True Then
            CrearDocumento(al, pago)
            cont += 1
            If cont = LIMITE Then
              If MessageBox.Show("¿Desea continuar imprimiendo?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                cont = 0
              Else
                Exit For
              End If
            End If
          End If
        Next
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    End If
  End Sub

  Private Function VerificarMonto() As Boolean
    Dim total As Double = 0

    For Each al In Me.alumnos
      If al.Seleccionado = True Then
        total += al.MontoPagar
      End If
    Next

    If total = Me.nudMontoVoucher.Value Then
      Return True
    ElseIf total < Me.nudMontoVoucher.Value Then
      If MessageBox.Show("El monto depositado es mayor al monto total a pagar" & vbNewLine & _
                         "Monto depositado : " & Me.nudMontoVoucher.Value & vbNewLine & _
                         "Total recibos : " & total & vbNewLine & _
                         "Diferencia : " & (Me.nudMontoVoucher.Value - total) & vbNewLine & _
                         "¿Desea continuar?", _
                         Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Error) = Windows.Forms.DialogResult.Yes Then
        Return True
      Else
        Return False
      End If
    Else
      MessageBox.Show("El monto depositado es menor al monto total a pagar" & vbNewLine & _
                         "Monto depositado : " & Me.nudMontoVoucher.Value & vbNewLine & _
                         "Total recibos : " & total & vbNewLine & _
                         "Diferencia : " & (Me.nudMontoVoucher.Value - total), _
                         Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Return False
    End If
  End Function

  Private Sub CrearDocumento(ByVal wAlumno As AlumnoBeneficiado, ByVal wPago As VoucherPago)
    Dim rn As RNDocumentoIngreso
    Dim doc As New DocumentoIngreso
    Dim detalles As New List(Of VistaDetalleDocumentoIngreso)

    doc.Entidad = Me.cboEntidad.Text.Substring(0, 1)
    doc.TipoDocumento = cboTipoDoc.Text.Substring(0, 1)
    doc.Serie = CInt(Me.txtSerie.Text)
    doc.Numero = CInt(Me.txtNumero.Text)
    doc.Fecha = Me.dtpFecha.Value
    doc.Persona = wAlumno.Matricula.Alumno
    doc.Administrativo = New Administrativo(mOUsuario.Persona.Codigo)
    doc.FormaPago = cboFormaPago.Text.Substring(0, 1)
    doc.Voucher = wPago
    doc.Vigencia = True

    doc.Detalles = New List(Of DetalleDocumentoIngreso)
    doc.Detalles.Add(New DetalleDocumentoIngreso)
    wAlumno.Beneficio.Obligacion.Descripcion = cboProgramacion.Text
    With doc.Detalles.Item(doc.Detalles.Count - 1)
      .Numero = 1
      .Descripcion = Me.cboProgramacion.Text
      .Monto = wAlumno.MontoPagar
      .Obligacion = wAlumno.Beneficio.Obligacion
      .Servicio = wAlumno.Beneficio.Obligacion.Servicio
    End With
    detalles.Add(New VistaDetalleDocumentoIngreso)
    With detalles.Item(0)
      .Seleccionado = True
      .Descripcion = Me.cboProgramacion.Text
      .Monto = wAlumno.MontoPagar
      .Beneficio = wAlumno.Beneficio
    End With

    modImprimirDocumento.ConfigurarReporte(doc, wAlumno.Matricula, detalles)
    rn = New RNDocumentoIngreso
    Try
      rn.Registrar(doc)
      Me.txtNumero.Text = (CInt(Me.txtNumero.Text) + 1).ToString
      modPrincipal.crpDocumento.PrintToPrinter(1, True, 1, 1)
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      rn = Nothing
      detalles = Nothing
      doc = Nothing
    End Try
  End Sub

  Private Sub cboFormaPago_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboFormaPago.Validating
    If Me.cboFormaPago.SelectedIndex > -1 Then
      Me.mControlError.SetError(cboFormaPago, "")
    Else
      Me.mControlError.SetError(cboFormaPago, "Debe indicar la forma de pago")
      e.Cancel = True
    End If
  End Sub

  Private Sub cboEntidadFinanciera_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboEntidadFinanciera.Validating
    If Me.cboEntidadFinanciera.SelectedIndex > -1 Then
      Me.mControlError.SetError(Me.cboEntidadFinanciera, "")
    Else
      Me.mControlError.SetError(Me.cboEntidadFinanciera, "Debe indicar la entidad financiera")
      e.Cancel = True
    End If
  End Sub

  Private Sub cboCuenta_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboCuenta.Validating
    If Me.cboCuenta.SelectedIndex > -1 Then
      Me.mControlError.SetError(Me.cboCuenta, "")
    Else
      Me.mControlError.SetError(Me.cboCuenta, "Debe indicar la cuenta corriente")
      e.Cancel = True
    End If
  End Sub

  Private Sub cboTipoDoc_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboTipoDoc.Validating
    If Me.cboTipoDoc.SelectedIndex > -1 Then
      Me.mControlError.SetError(Me.cboTipoDoc, "")
    Else
      Me.mControlError.SetError(Me.cboTipoDoc, "Debe indicar el tipo de documento")
      e.Cancel = True
    End If
  End Sub

  Private Sub txtSerie_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSerie.Validating
    If Me.txtSerie.Text.Length > 0 Then
      Me.mControlError.SetError(Me.txtSerie, "")
    Else
      Me.mControlError.SetError(Me.txtSerie, "Debe indicar la serie del documento")
      e.Cancel = True
    End If
  End Sub

  Private Sub txtNumero_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNumero.Validating
    If Me.txtNumero.Text.Length > 0 Then
      Me.mControlError.SetError(Me.txtNumero, "")
    Else
      Me.mControlError.SetError(Me.txtNumero, "Debe indicar el número del documento")
      e.Cancel = True
    End If
  End Sub

  Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
    Dim sel As Boolean
    sel = Me.chkTodos.Checked

    Me.dgvAlumnos.DataSource = Nothing
    For Each al In Me.alumnos
      al.Seleccionado = sel
    Next

    Me.dgvAlumnos.AutoGenerateColumns = False
    Me.dgvAlumnos.DataSource = Me.alumnos
  End Sub

  'Private Sub dgvAlumnos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAlumnos.CellContentClick
  '  Dim frm As frmModificarCanje
  '  Dim doc As DocumentoIngreso

  '  If e.ColumnIndex = 5 Then
  '    If Me.dgvAlumnos.CurrentRow IsNot Nothing Then
  '      doc = DirectCast(Me.dgvAlumnos.CurrentRow.DataBoundItem, AlumnoBeneficiado))
  '      frm = New frmModificarCanje
  '      frm.Registrar(doc)
  '      frm = Nothing

  '      Me.dgvAlumnos.DataSource = Nothing
  '      Me.dgvAlumnos.AutoGenerateColumns = False
  '      Me.dgvAlumnos.DataSource = Me.alumnos
  '    Else
  '      MessageBox.Show("Debe seleccionar un pago", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
  '    End If
  '  End If
  'End Sub

  Private Sub txtSerie_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.Leave
    Me.ObtenerNumeracion()
  End Sub

  Private Sub dgvAlumnos_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAlumnos.CellValueChanged
    Dim cant As Integer = 0
    Dim tot As Double = 0

    If Me.alumnos IsNot Nothing Then
      For Each det In Me.alumnos
        If det.Seleccionado = True Then
          cant += 1
          tot += det.MontoPagar
        End If
      Next
    End If

    Me.txtPagantes.Text = cant.ToString
    Me.txtTotal.Text = tot.ToString("0.00")
  End Sub

  Private Sub btnNumerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNumerar.Click
    Dim num As Integer = CInt(Me.txtNumero.Text)
    Dim serie As Integer = CInt(Me.txtSerie.Text)
    Dim doc As String = Me.cboTipoDoc.Text.Substring(0, 1)

    Me.dgvAlumnos.DataSource = Nothing
    For Each al As AlumnoBeneficiado In Me.alumnos
      If al.Seleccionado = True Then
        al.Documento = doc & " " & serie.ToString("000") & "-" & num.ToString("0000000")
        num += 1
      Else
        al.Documento = ""
      End If
    Next
    Me.dgvAlumnos.AutoGenerateColumns = False
    Me.dgvAlumnos.DataSource = Me.alumnos
  End Sub

  Private Sub cboAnio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnio.SelectedIndexChanged
    Me.cboProgramacion.SelectedIndex = -1
    Me.cboProgramacion.DataSource = Nothing
  End Sub

  Private Sub cboProgramacion_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProgramacion.Enter
    Me.ListarPagos()
  End Sub

  Private Sub cboProgramacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProgramacion.SelectedIndexChanged
    Me.dgvAlumnos.DataSource = Nothing
  End Sub

End Class
