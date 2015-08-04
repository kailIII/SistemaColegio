Public Class frmRegistrarPago

  Private Persona As Persona
  Private Matricula As Matricula
  Private mODetalles As List(Of VistaDetalleDocumentoIngreso)
  Private mODocumento As DocumentoIngreso

  Private mVisor As frmVisor
  Private mReporte As crpDocumentoIngreso

  Private mControlError As ErrorProvider

  Public WriteOnly Property Visor() As frmVisor
    Set(ByVal value As frmVisor)
      Me.mVisor = value
    End Set
  End Property

  Public WriteOnly Property Reporte() As crpDocumentoIngreso
    Set(ByVal value As crpDocumentoIngreso)
      Me.mReporte = value
    End Set
  End Property

  Public WriteOnly Property ControlError() As ErrorProvider
    Set(ByVal value As ErrorProvider)
      Me.mControlError = value
    End Set
  End Property

  Public Sub QuitarObligacionesRepetidas()
    Dim det As New DetalleDocumentoIngreso

    For i = 0 To dgvServicio.RowCount
      det = CType(Me.dgvServicio.Rows.Item(i).DataBoundItem, DetalleDocumentoIngreso)
    Next
  End Sub

  Private Sub frmRegistrarPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.CargarIconos()
    Me.cboFormaPago.SelectedIndex = 1
    Me.cboEntidad.SelectedIndex = 0
    Me.txtSerie.Text = "1"
    Me.ObtenerNumeracion()
    Me.tmrTiempo.Enabled = True
  End Sub

  Public Sub CargarControlesPersona()
    dgvServicio.Enabled = True
    dgvServicio.AutoGenerateColumns = False
    btnRegistrar.Enabled = True
    btNuevo.Enabled = True
    btnImprimir.Enabled = True
    btnCancelar.Enabled = True
    btnAgregar.Select()
  End Sub

  Public Sub CargarIconos()
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnAgregar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\agregar.png")
    Me.btnBuscar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Buscar.png")
    Me.btnImprimir.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\ver1.gif")
    Me.btNuevo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\nuevo.png")
    Me.btnEstadoCta.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\korganizer.png")
  End Sub

  Public Sub Registrar()
    Me.cboEntidad.SelectedIndex = 0
    Me.cboTipoDoc.SelectedIndex = 0

    Me.Text = "REGISTRAR PAGO - INSTITUCION EDUCATIVA"
    Me.txtTotal.Text = " 0"
    Me.btnBuscar.Focus()
    Me.mODetalles = New List(Of VistaDetalleDocumentoIngreso)

    Me.Show()
  End Sub

  Private Sub ObtenerNumeracion()
    Dim rn As RNDocumentoIngreso
    Dim doc As DocumentoIngreso

    If cboEntidad.SelectedIndex > -1 AndAlso cboTipoDoc.SelectedIndex > -1 AndAlso String.IsNullOrEmpty(Me.txtSerie.Text) = False Then
      rn = New RNDocumentoIngreso
      doc = rn.ObtenerNumeracion(cboEntidad.Text.Substring(0, 1), cboTipoDoc.Text.Substring(0, 1), CInt(Me.txtSerie.Text))
      rn = Nothing
      txtSerie.Text = doc.Serie.ToString("000")
      txtNumero.Text = doc.Numero.ToString("0000000")
      doc = Nothing
    End If
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Me.CargarDatosPersona()
  End Sub

  Public Sub CargarDatosPersona()
    Dim frm As New frmBuscarPersona

    frm.ControlError = Me.mControlError
    Me.Persona = frm.Buscar()
    If Me.Persona IsNot Nothing Then
      Me.txtNombre.Text = Persona.NombreCompleto
      If TypeOf Me.Persona Is Alumno Then
        Me.txtCodigo.Text = DirectCast(Me.Persona, Alumno).CodigoRecaudacion.Trim
        Me.CargarDatosMatricula(Me.Persona)
        Me.CargarPagosPendientes()
        Me.dgvServicio.Focus()
      Else
        Me.CargarControlesPersona()
        Me.txtSeccion.Text = ""
        Me.txtCodigo.Text = "VARIOS"
        Me.txtSeccion.Text = ""
        Me.Matricula = Nothing
        Me.mODetalles = Nothing
        Me.dgvServicio.DataSource = Nothing
        Me.btnAgregar.PerformClick()
      End If
    Else
      Me.txtNombre.Text = ""
      Me.txtCodigo.Text = ""
      Me.txtSeccion.Text = ""
      Me.dgvServicio.DataSource = Nothing
    End If
  End Sub

  Private Sub CargarDatosMatricula(ByVal wPersona As Persona)
    Dim objmat As RNMatricula

    objmat = New RNMatricula
    Me.Matricula = objmat.LeerMatriculaxGradoSeccion(DirectCast(Persona, Alumno))
    objmat = Nothing
    If matricula IsNot Nothing Then
      Me.txtSeccion.Text = Me.Matricula.GradoSeccion
    End If
  End Sub

  Private Sub CargarPagosPendientes()
    Dim rnPer As New RNPersona
    Dim tot As Double = 0

    Me.mODetalles = rnPer.ListarObligacionesPendientes(Me.Persona, cboEntidad.Text.Substring(0, 1))
    rnPer = Nothing
    Me.dgvServicio.DataSource = Nothing
    If Me.mODetalles.Count > 0 Then
      dgvServicio.AutoGenerateColumns = False
      dgvServicio.DataSource = Me.mODetalles
      dgvServicio.Focus()
      For Each det In Me.mODetalles
        tot += det.Obligacion.Monto
      Next
      txtDeudaTotal.Text = tot.ToString("0.00")
    Else
      btnAgregar.Focus()
    End If
  End Sub

  Private Sub AgregarObligaciones(ByVal wPagos As List(Of Obligacion))
    For Each ob In wPagos
      Me.mODetalles.Add(New VistaDetalleDocumentoIngreso)
      With Me.mODetalles.Item(Me.mODetalles.Count - 1)
        .Descripcion = ob.Descripcion
        .Monto = ob.Monto
        .MontoOriginal = ob.Monto
        .Beneficio = New Beneficio
        .Obligacion = ob
        .Seleccionado = False
      End With
    Next
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Dispose()
    Me.Close()
  End Sub

  Public Function ExisteServicio(ByVal serv As Servicio) As Boolean

    For Each elm As DetalleDocumentoIngreso In Me.mODetalles
      If elm.Servicio.Codigo = serv.Codigo Then
        Return True
      End If
    Next

    Return False
  End Function

  Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
    AgregarVarios()
  End Sub

  Private Sub AgregarVarios()
    Dim frm As New frmBuscarServicio
    Dim servicios As List(Of Servicio)

    servicios = frm.BuscarVarios(cboEntidad.Text.Substring(0, 1))
    frm.Dispose()
    If servicios IsNot Nothing AndAlso servicios.Count > 0 Then
      For Each s In servicios
        Me.AgregarServicio(s)
      Next

      Me.ActualizarPagoRealizar()
      Me.dgvServicio.DataSource = Nothing
      Me.dgvServicio.AutoGenerateColumns = False
      Me.dgvServicio.DataSource = Me.mODetalles

      Me.dgvServicio.Focus()
    End If
  End Sub

  Private Sub AgregarUnico()
    Dim frm As New frmBuscarServicio
    Dim serv As Servicio

    serv = frm.Buscar(cboEntidad.Text.Substring(0, 1))
    frm.Dispose()
    If serv IsNot Nothing Then
      Me.AgregarServicio(serv)

      Me.ActualizarPagoRealizar()
      Me.dgvServicio.DataSource = Nothing
      Me.dgvServicio.AutoGenerateColumns = False
      Me.dgvServicio.DataSource = Me.mODetalles

      Me.dgvServicio.Focus()
    End If
  End Sub

  Private Sub AgregarServicio(ByVal wServicio As Servicio)
    Dim det As VistaDetalleDocumentoIngreso

    If Me.mODetalles Is Nothing Then
      Me.mODetalles = New List(Of VistaDetalleDocumentoIngreso)
    End If
    'If ExisteServicio(wServicio) = False Then
    det = New VistaDetalleDocumentoIngreso
    det.Servicio = wServicio
    det.Descripcion = wServicio.Nombre

    det.Monto = wServicio.Monto
    det.MontoOriginal = wServicio.Monto

    det.Seleccionado = True
    Me.mODetalles.Insert(0, det)
    'Else
    '  MessageBox.Show("El servicio ya ha sido agregado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    'End If

  End Sub

  Private Sub dgvServicio_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvServicio.CellValueChanged
    If e.ColumnIndex = 0 AndAlso Me.dgvServicio.DataSource IsNot Nothing Then
      ActualizarPagoRealizar()
      If Me.mODetalles.Item(e.RowIndex).Obligacion IsNot Nothing Then
        If CBool(Me.dgvServicio.Rows.Item(e.RowIndex).Cells(e.ColumnIndex).Value) = True Then
          BuscarMora(Me.mODetalles.Item(e.RowIndex).Obligacion.Codigo, True)
        Else
          BuscarMora(Me.mODetalles.Item(e.RowIndex).Obligacion.Codigo, False)
        End If
      End If
      Me.dgvServicio.DataSource = Me.mODetalles
    End If
  End Sub

  Private Sub BuscarMora(ByVal wCodigoObligacion As Integer, ByVal wEstado As Boolean)
    Dim i As Integer = 0
    For Each det In Me.mODetalles
      If det.Obligacion IsNot Nothing AndAlso det.Obligacion.ObligacionPadre IsNot Nothing AndAlso _
            det.Obligacion.ObligacionPadre.Codigo = wCodigoObligacion Then
        Me.dgvServicio.Item(0, i).Value = wEstado

        Return
      End If
      i += 1
    Next
  End Sub

  Private Sub dgvServicio_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvServicio.CellContentClick
    If e.ColumnIndex = 0 Then
      dgvServicio.CurrentCell = Nothing
      dgvServicio.CurrentCell = Me.dgvServicio.Rows.Item(e.RowIndex).Cells(e.ColumnIndex)
    End If
  End Sub

  Private Sub ActualizarPagoRealizar()
    Dim tot As Double = 0
    Dim ob As Double = 0
    Dim mora As Double = 0

    If Me.mODetalles IsNot Nothing Then
      For Each det In Me.mODetalles
        If det.Seleccionado = True Then
          tot += det.Monto

          If det.Obligacion IsNot Nothing Then
            ob += det.Monto
          End If

          If det.Descripcion.ToUpper.IndexOf("MORA") >= 0 Then
            mora += det.Monto
          End If
        End If
      Next
      txtTotal.Text = tot.ToString("0.00")
      txtObligacionTotal.Text = ob.ToString("0.00")
      txtMoraTotal.Text = mora.ToString("0.00")
    End If
  End Sub

  Private Sub chkSeleccionarTodos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSeleccionarTodos.CheckedChanged

    For Each det In Me.mODetalles
      det.Seleccionado = chkSeleccionarTodos.Checked
    Next

    Me.dgvServicio.DataSource = Nothing
    Me.dgvServicio.AutoGenerateColumns = False
    Me.dgvServicio.DataSource = Me.mODetalles
  End Sub

  Public Function verficarServiciosconCheck() As Boolean
    For i = 0 To dgvServicio.RowCount - 1
      If CBool(dgvServicio.Item("colItem", i).Value) = True Then
        Return True
      End If
    Next
    Return False
  End Function

  Public Sub anularCodigosObligacionesPadre(ByVal wlis As List(Of DetalleDocumentoIngreso))
    Dim oblig As New Obligacion
    For Each elem In wlis
      If Not elem.Obligacion Is Nothing Then
        If Not elem.Obligacion.ObligacionPadre Is Nothing Then
          If elem.Obligacion.ObligacionPadre.Codigo <> 0 Then
            oblig = New Obligacion(0, elem.Obligacion.Descripcion, elem.Obligacion.Monto, True, elem.Obligacion.FechaVencimiento, _
                                                elem.Obligacion.Servicio, elem.Obligacion.Matricula, elem.Obligacion.ObligacionPadre)
            elem.Obligacion = oblig
          End If
        End If
      End If
    Next
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim rn As RNDocumentoIngreso
    Dim doc As DocumentoIngreso

    If Me.ValidateChildren Then
      doc = New DocumentoIngreso
      doc.Persona = Me.Persona
      doc.TipoDocumento = cboTipoDoc.Text.Substring(0, 1)
      doc.Serie = CInt(txtSerie.Text)
      doc.Numero = CInt(txtNumero.Text)
      doc.Fecha = dtpFecha.Value
      doc.Total = CDbl(txtTotal.Text)
      doc.FormaPago = cboFormaPago.Text.Substring(0, 1)
      If doc.FormaPago = "V" OrElse doc.FormaPago = "C" Then
        doc.Voucher = New VoucherPago
        With doc.Voucher
          .CuentaBancaria = DirectCast(cboCuenta.SelectedItem, CuentaBancaria)
          .NumOperacion = Me.txtNumOperacion.Text
          .Fecha = Me.dtpFechaVoucher.Value
          .Monto = CDbl(nudMontoVoucher.Value)
        End With
      End If
      If VerVistaPrevia(doc, Me.Matricula, Me.mODetalles) = True Then
        Me.GenerarDocumento()
        rn = New RNDocumentoIngreso
        Try
          rn.Registrar(Me.mODocumento)
          Me.mReporte.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
          Me.mReporte.PrintToPrinter(1, False, 1, 1)
          MessageBox.Show("El documento fue registrado exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          Me.LimpiarControles()
          Me.txtCodigo.Focus()
          Me.cboEntidad.SelectedIndex = 0
        Catch ex As Exception
          MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
          rn = Nothing
        End Try
      End If
    End If
  End Sub

  Private Sub GenerarDocumento()
    Me.mODocumento = New DocumentoIngreso
    With Me.mODocumento
      .Entidad = cboEntidad.Text.Substring(0, 1)
      .TipoDocumento = cboTipoDoc.Text.Substring(0, 1)
      .Serie = CInt(txtSerie.Text)
      .Numero = CInt(txtNumero.Text)
      .Persona = Me.Persona
      .Fecha = dtpFecha.Value
      .FormaPago = cboFormaPago.Text.Substring(0, 1)
      .Administrativo = New Administrativo(mOUsuario.Persona.Codigo)
      If .FormaPago = "C" OrElse .FormaPago = "V" Then
        .Voucher = New VoucherPago
        With .Voucher
          .CuentaBancaria = DirectCast(cboCuenta.SelectedItem, CuentaBancaria)
          .NumOperacion = Me.txtNumOperacion.Text
          .Fecha = Me.dtpFechaVoucher.Value
          .Monto = CDbl(Me.nudMontoVoucher.Value)
        End With
      End If
    End With
    mODocumento.Detalles = New List(Of DetalleDocumentoIngreso)
    For Each det In Me.mODetalles
      If det.Seleccionado = True Then
        With Me.mODocumento.Detalles
          .Add(New DetalleDocumentoIngreso)
          With .Item(.Count - 1)
            .Servicio = det.Servicio
            .Obligacion = det.Obligacion
            .Descripcion = det.Descripcion
            .Monto = det.Monto
          End With
        End With
      End If
    Next
  End Sub

  Private Sub Validar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    Dim drwFila As DataGridViewCell = dgvServicio.CurrentCell()

    Try
      If dgvServicio.Columns(drwFila.ColumnIndex).Name = "colSubtotal" Then
        If Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 8) Or e.KeyChar = "." Then
          e.Handled = False
        Else
          e.Handled = True
        End If
      End If
    Catch ex As Exception
      MessageBox.Show("Debe ingresar un valor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub txtNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerie.KeyPress, txtNumero.KeyPress
    If Char.IsDigit(e.KeyChar) = False AndAlso Char.IsNumber(e.KeyChar) = False _
            AndAlso Char.IsControl(e.KeyChar) = False Then
      e.Handled = True
    End If
  End Sub

  Public Sub MostrarRecibo()
    CargarIconos()
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Me.Dispose()
    Me.Close()
  End Sub

  Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
    If Convert.ToInt32(e.KeyChar) = Keys.Enter AndAlso txtCodigo.Text.Length > 0 Then
      BuscarAlumno(txtCodigo.Text)
    End If
  End Sub

  Private Sub BuscarAlumno(ByVal wCodigo As String)
    Dim rn As New RNAlumno

    Me.Persona = rn.LeerDatosAlumno_CodigoRecaudacion(wCodigo)
    rn = Nothing
    If Me.Persona IsNot Nothing Then
      Me.txtNombre.Text = Persona.NombreCompleto
      Me.CargarDatosMatricula(Me.Persona)
      Me.CargarPagosPendientes()

    Else
      MessageBox.Show("No se encontró el alumno con el código ingresado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Me.txtNombre.Text = ""
      Me.txtSeccion.Text = ""
      Me.dgvServicio.DataSource = Nothing
    End If

  End Sub

  Private Sub frmRegistrarPago_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
    Me.txtCodigo.Focus()
  End Sub

  Private Sub btNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNuevo.Click
    LimpiarControles()
  End Sub

  Private Sub LimpiarControles()
    Me.Persona = Nothing
    Me.dgvServicio.DataSource = Nothing
    Me.txtNombre.Text = ""
    Me.txtSeccion.Text = ""
    Me.txtCodigo.Text = ""
    Me.txtTotal.Text = "0"
    Me.dtpFecha.Value = DateAndTime.Now
    Me.txtNumero.Text = (CInt(txtNumero.Text) + 1).ToString
    Me.cboFormaPago.SelectedIndex = 1
    Me.txtDeudaTotal.Text = "0"
    Me.txtObligacionTotal.Text = "0"
    Me.txtMoraTotal.Text = "0"
    Me.mODetalles = Nothing
  End Sub

  Private Sub txtSerie_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSerie.Validating
    If txtSerie.Text.Trim.Length = 0 Then
      Me.mControlError.SetError(txtSerie, "No se ha indicado la serie del documento")
      e.Cancel = True
    Else
      Me.mControlError.SetError(txtSerie, "")
    End If
  End Sub

  Private Sub txtNumero_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNumero.Validating
    If txtNumero.Text.Trim.Length = 0 Then
      Me.mControlError.SetError(txtNumero, "No se ha indicado el número del documento")
      e.Cancel = True
    Else
      Me.mControlError.SetError(txtNumero, "")
    End If
  End Sub

  Private Sub txtNombre_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
    If txtNombre.Text.Trim.Length = 0 Then
      Me.mControlError.SetError(txtNombre, "No se ha identificado al alumno o persona")
      e.Cancel = True
    Else
      Me.mControlError.SetError(txtNombre, "")
    End If
  End Sub

  Private Sub dgvServicio_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dgvServicio.Validating
    If CDbl(txtTotal.Text) = 0 Then
      Me.mControlError.SetError(dgvServicio, "No se ha indicado los servicios a pagar")
      e.Cancel = True
    Else
      Me.mControlError.SetError(dgvServicio, "")
    End If
  End Sub

  Private Sub cboEntidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEntidad.SelectedIndexChanged, cboTipoDoc.SelectedIndexChanged
    Me.ObtenerNumeracion()
  End Sub

  Private Sub dgvServicio_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvServicio.CellEndEdit
    If Me.dgvServicio.Columns.Item(e.ColumnIndex).Name.ToString = "colSubtotal" Then
      Me.ActualizarPagoRealizar()
      With DirectCast(Me.dgvServicio.CurrentRow.DataBoundItem, VistaDetalleDocumentoIngreso)
        If .Descripcion.ToUpper.Contains("MORA") = True AndAlso .Obligacion IsNot Nothing AndAlso .codigoObligacion = -1 Then
          Me.dgvServicio.DataSource = Nothing
          .MontoOriginal = .Monto
          .Obligacion.Monto = .Monto
          Me.dgvServicio.DataSource = Me.mODetalles
        End If
      End With
    End If
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
    If cboEntidadFinanciera.DataSource Is Nothing Then
      txtNumOperacion.Text = ""
      dtpFechaVoucher.Value = DateAndTime.Now
      Me.CargarEntidades()
    End If
    cboCuenta.SelectedIndex = -1
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

  Private Sub cboCuenta_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuenta.Enter
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
        txtNumOperacion.Focus()
      Else
        cboCuenta.SelectedIndex = -1
      End If
    Else
      cboCuenta.DataSource = Nothing
      MessageBox.Show("Debe seleccionar una entidad financiera", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
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

  Private Sub nudMontoVoucher_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles nudMontoVoucher.Validating
    If Me.cboFormaPago.SelectedIndex <> 1 AndAlso String.IsNullOrEmpty(Me.txtNumOperacion.Text) Then
      Me.mControlError.SetError(Me.nudMontoVoucher, "Los montos de la operación y del documento de pago no coinciden")
      e.Cancel = True
    Else
      Me.mControlError.SetError(Me.nudMontoVoucher, "")
    End If
  End Sub

  Private Sub txtSerie_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerie.Leave
    Me.ObtenerNumeracion()
  End Sub

  Private Sub tmrTiempo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTiempo.Tick
    Me.dtpFecha.Value = DateAndTime.Now
  End Sub

  Private Sub frmRegistrarPago_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    Me.tmrTiempo.Enabled = False
  End Sub

  Private Sub dgvServicio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgvServicio.KeyPress
    If (Me.dgvServicio.CurrentCell.ColumnIndex = 0 Or Me.dgvServicio.IsCurrentCellInEditMode = False) _
        AndAlso e.KeyChar = Convert.ToChar(Keys.Enter) Then

      Me.btnAgregar.PerformClick()
      e.Handled = True
    End If
  End Sub
End Class
