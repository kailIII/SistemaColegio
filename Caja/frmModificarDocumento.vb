Public Class frmModificarDocumento

  Private mDocumento As DocumentoIngreso

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Close()
  End Sub

  Public Sub Modificar(ByVal wDocumento As DocumentoIngreso)
    Me.mDocumento = wDocumento

    Me.PresentarDatos()
    Me.ShowDialog()
  End Sub

  Private Sub PresentarDatos()
    Dim rn As RNDocumentoIngreso
    Dim doc As DocumentoIngreso

    rn = New RNDocumentoIngreso
    Try
      doc = rn.LeerFormaPago(Me.mDocumento)
      doc.FormaPago = doc.FormaPago

      Me.mDocumento.FormaPago = doc.FormaPago
      Me.mDocumento.Voucher = doc.Voucher
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Exit Sub
    Finally
      rn = Nothing
    End Try

    With Me.mDocumento
      Select Case .TipoDocumento
        Case "R"
          Me.cboTipoDoc.SelectedIndex = 0
        Case "B"
          Me.cboTipoDoc.SelectedIndex = 1
        Case "F"
          Me.cboTipoDoc.SelectedIndex = 2
      End Select
      Me.txtSerie.Text = .Serie.ToString
      Me.txtNumero.Text = .Numero.ToString
      Me.dtpFecha.Value = .Fecha
      Me.txtPersona.Text = .Persona.NombreCompleto
      Select Case Me.mDocumento.FormaPago
        Case "C"
          Me.cboFormaPago.SelectedIndex = 0
        Case "E"
          Me.cboFormaPago.SelectedIndex = 1
        Case "V"
          Me.cboFormaPago.SelectedIndex = 2
      End Select
      If Me.cboFormaPago.SelectedIndex <> 1 Then
        With .Voucher
          Me.cboEntidadFinanciera.SelectedValue = Me.mDocumento.Voucher.CuentaBancaria.EntidadFinanciera.Codigo
          Me.cboCuenta.SelectedValue = .CuentaBancaria.Numero
          Me.txtNumOperacion.Text = .NumOperacion
          Me.dtpFechaVoucher.Value = .Fecha
          Me.nudMontoVoucher.Value = CDec(.Monto)
        End With
      End If
    End With
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim rn As RNDocumentoIngreso
    Dim doc As DocumentoIngreso

    rn = New RNDocumentoIngreso
    doc = New DocumentoIngreso
    doc.Codigo = Me.mDocumento.Codigo
    doc.Persona = Me.mDocumento.Persona
    doc.TipoDocumento = Me.cboTipoDoc.Text.Substring(0, 1)
    doc.Serie = CInt(Me.txtSerie.Text)
    doc.Numero = CInt(Me.txtNumero.Text)
    doc.Fecha = Me.dtpFecha.Value
    doc.FormaPago = Me.cboFormaPago.Text.Substring(0, 1)
    doc.Administrativo = New Administrativo(mOUsuario.Persona.Codigo)
    If Me.cboFormaPago.SelectedIndex <> 1 Then
      doc.Voucher = New VoucherPago
      With doc.Voucher
        .CuentaBancaria = DirectCast(Me.cboCuenta.SelectedItem, CuentaBancaria)
        .NumOperacion = Me.txtNumOperacion.Text.Trim
        .Fecha = Me.dtpFechaVoucher.Value
        .Monto = Me.nudMontoVoucher.Value
        doc.Voucher.Administrativo = doc.Administrativo
      End With
    End If
    Try
      rn.Modificar(doc)
      Me.Close()
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      doc = Nothing
      rn = Nothing
    End Try
  End Sub

  Private Sub frmModificarDocumento_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
    Me.txtNumero.Focus()
  End Sub

  Private Sub cboFormaPago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFormaPago.SelectedIndexChanged
    If cboFormaPago.SelectedIndex <> 1 Then
      Me.gbDeposito.Enabled = True
      Me.ConfigurarVoucher()
    Else
      Me.gbDeposito.Enabled = False
    End If
  End Sub

  Private Sub ConfigurarVoucher()
    If Me.cboEntidadFinanciera.DataSource Is Nothing Then
      Me.txtNumOperacion.Text = ""
      Me.dtpFechaVoucher.Value = DateAndTime.Now
      Me.CargarEntidades()
    End If
    Me.cboCuenta.SelectedIndex = -1
  End Sub

  Public Sub CargarEntidades()
    Dim ListA As New List(Of EntidadFinanciera)
    Dim objE As New RNEntidadFinanciera

    ListA = objE.Listar
    objE = Nothing
    If ListA.Count > 0 Then
      Me.cboEntidadFinanciera.DisplayMember = "nombre"
      Me.cboEntidadFinanciera.ValueMember = "codigo"
      Me.cboEntidadFinanciera.DataSource = ListA
      If ListA.Count = 1 Then
        Me.cboEntidadFinanciera.SelectedIndex = 0
        Me.cboCuenta.Focus()
      Else
        Me.cboEntidadFinanciera.SelectedIndex = -1
      End If
      ListA = Nothing
    End If
  End Sub

  Private Sub cboEntidadFinanciera_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboEntidadFinanciera.Validating
    If Me.cboFormaPago.SelectedIndex <> 1 AndAlso Me.cboEntidadFinanciera.SelectedIndex = -1 Then
      Me.mControlError.SetError(Me.cboEntidadFinanciera, "Debe seleccionar la entidad bancaria")
      e.Cancel = True
    Else
      Me.mControlError.SetError(Me.cboEntidadFinanciera, "")
    End If
  End Sub

  Private Sub cboCuenta_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboCuenta.Validating
    If Me.cboFormaPago.SelectedIndex <> 1 AndAlso Me.cboCuenta.SelectedIndex = -1 Then
      Me.mControlError.SetError(Me.cboCuenta, "Debe seleccionar la cuenta bancaria")
      e.Cancel = True
    Else
      Me.mControlError.SetError(Me.cboCuenta, "")
    End If
  End Sub

  Private Sub txtVoucher_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNumOperacion.Validating
    If Me.cboFormaPago.SelectedIndex <> 1 AndAlso String.IsNullOrEmpty(Me.txtNumOperacion.Text) Then
      Me.mControlError.SetError(Me.txtNumOperacion, "No ha indicado el número del cheque u operación")
      e.Cancel = True
    Else
      Me.mControlError.SetError(Me.txtNumOperacion, "")
    End If
  End Sub

  Private Sub cboEntidadFinanciera_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEntidadFinanciera.SelectedIndexChanged
    Dim rn As RNEntidadFinanciera
    Dim cuentas As List(Of CuentaBancaria)

    If Me.cboEntidadFinanciera.SelectedItem IsNot Nothing Then
      rn = New RNEntidadFinanciera
      Me.cboCuenta.DisplayMember = "Numero"
      Me.cboCuenta.ValueMember = "Numero"
      cuentas = rn.ListarCuentas(DirectCast(cboEntidadFinanciera.SelectedItem, EntidadFinanciera))
      rn = Nothing
      Me.cboCuenta.DataSource = cuentas
      If cuentas.Count = 1 Then
        Me.cboCuenta.SelectedIndex = 0
        Me.txtNumOperacion.Focus()
      Else
        Me.cboCuenta.SelectedIndex = -1
      End If
    End If
  End Sub

  Private Sub txtNumOperacion_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumOperacion.Validated
    Dim rn As New rnVoucher
    Dim vou As VoucherPago

    Try
      vou = rn.Leer(New VoucherPago With {.NumOperacion = Me.txtNumOperacion.Text, .Fecha = Me.dtpFechaVoucher.Value})
      If vou IsNot Nothing Then
        Me.nudMontoVoucher.Value = CDec(vou.Monto)
        Me.cboEntidadFinanciera.SelectedValue = vou.CuentaBancaria.EntidadFinanciera.Codigo
        Me.cboCuenta.SelectedValue = vou.CuentaBancaria.Numero
        Me.btnRegistrar.Focus()
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      vou = Nothing
      rn = Nothing
    End Try

  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Dim frm As New frmBuscarPersona
    Dim persona As Persona

    frm.ControlError = Me.mControlError
    persona = frm.Buscar()
    If persona IsNot Nothing Then
      Me.txtPersona.Text = persona.NombreCompleto
      Me.mDocumento.Persona = persona
    End If
  End Sub

End Class