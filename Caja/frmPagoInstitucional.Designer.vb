<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagoInstitucional
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.cboMotivo = New System.Windows.Forms.ComboBox()
    Me.dgvAlumnos = New System.Windows.Forms.DataGridView()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.btnRegistrar = New System.Windows.Forms.Button()
    Me.btnListar = New System.Windows.Forms.Button()
    Me.gbDeposito = New System.Windows.Forms.GroupBox()
    Me.cboFormaPago = New System.Windows.Forms.ComboBox()
    Me.lblFormaPago = New System.Windows.Forms.Label()
    Me.nudMontoVoucher = New System.Windows.Forms.NumericUpDown()
    Me.lblCuenta = New System.Windows.Forms.Label()
    Me.cboCuenta = New System.Windows.Forms.ComboBox()
    Me.lblMontoVoucher = New System.Windows.Forms.Label()
    Me.lblVoucher = New System.Windows.Forms.Label()
    Me.txtVoucher = New System.Windows.Forms.TextBox()
    Me.cboEntidadFinanciera = New System.Windows.Forms.ComboBox()
    Me.lblEntidadFinanciera = New System.Windows.Forms.Label()
    Me.dtpFechaVoucher = New System.Windows.Forms.DateTimePicker()
    Me.lblFechaVoucher = New System.Windows.Forms.Label()
    Me.lblAnio = New System.Windows.Forms.Label()
    Me.cboTipoDoc = New System.Windows.Forms.ComboBox()
    Me.lblDocumento = New System.Windows.Forms.Label()
    Me.txtSerie = New System.Windows.Forms.TextBox()
    Me.lblSerie = New System.Windows.Forms.Label()
    Me.lblFecha = New System.Windows.Forms.Label()
    Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
    Me.txtNumero = New System.Windows.Forms.TextBox()
    Me.gbDocumento = New System.Windows.Forms.GroupBox()
    Me.lblPagoProgramado = New System.Windows.Forms.Label()
    Me.cboProgramacion = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.lblEntidad = New System.Windows.Forms.Label()
    Me.cboEntidad = New System.Windows.Forms.ComboBox()
    Me.chkTodos = New System.Windows.Forms.CheckBox()
    Me.txtTotal = New System.Windows.Forms.TextBox()
    Me.txtPagantes = New System.Windows.Forms.TextBox()
    Me.lblTotal = New System.Windows.Forms.Label()
    Me.lblVouchers = New System.Windows.Forms.Label()
    Me.btnNumerar = New System.Windows.Forms.Button()
    Me.cboAnio = New System.Windows.Forms.ComboBox()
    Me.cdSeleccionado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.cdDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdSeccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdMontoPagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdModificar = New System.Windows.Forms.DataGridViewButtonColumn()
    CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbDeposito.SuspendLayout()
    CType(Me.nudMontoVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbDocumento.SuspendLayout()
    Me.SuspendLayout()
    '
    'cboMotivo
    '
    Me.cboMotivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cboMotivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboMotivo.FormattingEnabled = True
    Me.cboMotivo.Items.AddRange(New Object() {"NRO DE HERMANOS", "STM", "ORFANDAD", "USAT"})
    Me.cboMotivo.Location = New System.Drawing.Point(381, 166)
    Me.cboMotivo.MaxLength = 60
    Me.cboMotivo.Name = "cboMotivo"
    Me.cboMotivo.Size = New System.Drawing.Size(318, 24)
    Me.cboMotivo.TabIndex = 4
    '
    'dgvAlumnos
    '
    Me.dgvAlumnos.AllowUserToAddRows = False
    Me.dgvAlumnos.AllowUserToDeleteRows = False
    Me.dgvAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdSeleccionado, Me.cdDocumento, Me.cdCodigo, Me.cdAlumno, Me.cdSeccion, Me.cdMonto, Me.cdDescuento, Me.cdMontoPagar, Me.cdModificar})
    Me.dgvAlumnos.Location = New System.Drawing.Point(26, 240)
    Me.dgvAlumnos.Name = "dgvAlumnos"
    Me.dgvAlumnos.Size = New System.Drawing.Size(897, 385)
    Me.dgvAlumnos.TabIndex = 11
    '
    'btnCancelar
    '
    Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(814, 631)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(109, 41)
    Me.btnCancelar.TabIndex = 18
    Me.btnCancelar.Text = "&Cancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = True
    '
    'btnRegistrar
    '
    Me.btnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(684, 631)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(109, 41)
    Me.btnRegistrar.TabIndex = 17
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = True
    '
    'btnListar
    '
    Me.btnListar.Location = New System.Drawing.Point(716, 187)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(99, 43)
    Me.btnListar.TabIndex = 9
    Me.btnListar.Text = "&Listar"
    Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnListar.UseVisualStyleBackColor = True
    '
    'gbDeposito
    '
    Me.gbDeposito.Controls.Add(Me.cboFormaPago)
    Me.gbDeposito.Controls.Add(Me.lblFormaPago)
    Me.gbDeposito.Controls.Add(Me.nudMontoVoucher)
    Me.gbDeposito.Controls.Add(Me.lblCuenta)
    Me.gbDeposito.Controls.Add(Me.cboCuenta)
    Me.gbDeposito.Controls.Add(Me.lblMontoVoucher)
    Me.gbDeposito.Controls.Add(Me.lblVoucher)
    Me.gbDeposito.Controls.Add(Me.txtVoucher)
    Me.gbDeposito.Controls.Add(Me.cboEntidadFinanciera)
    Me.gbDeposito.Controls.Add(Me.lblEntidadFinanciera)
    Me.gbDeposito.Controls.Add(Me.dtpFechaVoucher)
    Me.gbDeposito.Controls.Add(Me.lblFechaVoucher)
    Me.gbDeposito.Location = New System.Drawing.Point(0, 47)
    Me.gbDeposito.Name = "gbDeposito"
    Me.gbDeposito.Size = New System.Drawing.Size(897, 99)
    Me.gbDeposito.TabIndex = 7
    Me.gbDeposito.TabStop = False
    '
    'cboFormaPago
    '
    Me.cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboFormaPago.FormattingEnabled = True
    Me.cboFormaPago.Items.AddRange(New Object() {"CHEQUE", "VOUCHER"})
    Me.cboFormaPago.Location = New System.Drawing.Point(75, 20)
    Me.cboFormaPago.Name = "cboFormaPago"
    Me.cboFormaPago.Size = New System.Drawing.Size(161, 24)
    Me.cboFormaPago.TabIndex = 1
    '
    'lblFormaPago
    '
    Me.lblFormaPago.AutoSize = True
    Me.lblFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFormaPago.Location = New System.Drawing.Point(13, 28)
    Me.lblFormaPago.Name = "lblFormaPago"
    Me.lblFormaPago.Size = New System.Drawing.Size(46, 16)
    Me.lblFormaPago.TabIndex = 0
    Me.lblFormaPago.Text = "Me&dio"
    '
    'nudMontoVoucher
    '
    Me.nudMontoVoucher.DecimalPlaces = 2
    Me.nudMontoVoucher.Location = New System.Drawing.Point(607, 64)
    Me.nudMontoVoucher.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
    Me.nudMontoVoucher.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.nudMontoVoucher.Name = "nudMontoVoucher"
    Me.nudMontoVoucher.Size = New System.Drawing.Size(104, 20)
    Me.nudMontoVoucher.TabIndex = 11
    Me.nudMontoVoucher.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.nudMontoVoucher.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'lblCuenta
    '
    Me.lblCuenta.AutoSize = True
    Me.lblCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCuenta.Location = New System.Drawing.Point(555, 28)
    Me.lblCuenta.Name = "lblCuenta"
    Me.lblCuenta.Size = New System.Drawing.Size(50, 16)
    Me.lblCuenta.TabIndex = 4
    Me.lblCuenta.Text = "C&uenta"
    '
    'cboCuenta
    '
    Me.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCuenta.FormattingEnabled = True
    Me.cboCuenta.Location = New System.Drawing.Point(607, 23)
    Me.cboCuenta.Name = "cboCuenta"
    Me.cboCuenta.Size = New System.Drawing.Size(284, 21)
    Me.cboCuenta.TabIndex = 5
    '
    'lblMontoVoucher
    '
    Me.lblMontoVoucher.AutoSize = True
    Me.lblMontoVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMontoVoucher.Location = New System.Drawing.Point(560, 69)
    Me.lblMontoVoucher.Name = "lblMontoVoucher"
    Me.lblMontoVoucher.Size = New System.Drawing.Size(45, 16)
    Me.lblMontoVoucher.TabIndex = 10
    Me.lblMontoVoucher.Text = "Monto"
    '
    'lblVoucher
    '
    Me.lblVoucher.AutoSize = True
    Me.lblVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblVoucher.Location = New System.Drawing.Point(13, 68)
    Me.lblVoucher.Name = "lblVoucher"
    Me.lblVoucher.Size = New System.Drawing.Size(58, 16)
    Me.lblVoucher.TabIndex = 6
    Me.lblVoucher.Text = "&Voucher"
    '
    'txtVoucher
    '
    Me.txtVoucher.BackColor = System.Drawing.SystemColors.Window
    Me.txtVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtVoucher.Location = New System.Drawing.Point(75, 62)
    Me.txtVoucher.Name = "txtVoucher"
    Me.txtVoucher.Size = New System.Drawing.Size(161, 22)
    Me.txtVoucher.TabIndex = 7
    '
    'cboEntidadFinanciera
    '
    Me.cboEntidadFinanciera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEntidadFinanciera.FormattingEnabled = True
    Me.cboEntidadFinanciera.Location = New System.Drawing.Point(339, 23)
    Me.cboEntidadFinanciera.Name = "cboEntidadFinanciera"
    Me.cboEntidadFinanciera.Size = New System.Drawing.Size(210, 21)
    Me.cboEntidadFinanciera.TabIndex = 3
    '
    'lblEntidadFinanciera
    '
    Me.lblEntidadFinanciera.AutoSize = True
    Me.lblEntidadFinanciera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblEntidadFinanciera.Location = New System.Drawing.Point(259, 28)
    Me.lblEntidadFinanciera.Name = "lblEntidadFinanciera"
    Me.lblEntidadFinanciera.Size = New System.Drawing.Size(76, 16)
    Me.lblEntidadFinanciera.TabIndex = 2
    Me.lblEntidadFinanciera.Text = "Ent. &Financ."
    '
    'dtpFechaVoucher
    '
    Me.dtpFechaVoucher.CustomFormat = "dd/MM/yyyy hh:mm tt"
    Me.dtpFechaVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaVoucher.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtpFechaVoucher.Location = New System.Drawing.Point(339, 63)
    Me.dtpFechaVoucher.Name = "dtpFechaVoucher"
    Me.dtpFechaVoucher.Size = New System.Drawing.Size(165, 22)
    Me.dtpFechaVoucher.TabIndex = 9
    '
    'lblFechaVoucher
    '
    Me.lblFechaVoucher.AutoSize = True
    Me.lblFechaVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFechaVoucher.Location = New System.Drawing.Point(290, 68)
    Me.lblFechaVoucher.Name = "lblFechaVoucher"
    Me.lblFechaVoucher.Size = New System.Drawing.Size(46, 16)
    Me.lblFechaVoucher.TabIndex = 8
    Me.lblFechaVoucher.Text = "Fec&ha"
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAnio.Location = New System.Drawing.Point(23, 174)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(32, 16)
    Me.lblAnio.TabIndex = 1
    Me.lblAnio.Text = "Año"
    '
    'cboTipoDoc
    '
    Me.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboTipoDoc.FormattingEnabled = True
    Me.cboTipoDoc.Items.AddRange(New Object() {"RECIBO DE PAGO", "BOLETA DE VENTA", "FACTURA"})
    Me.cboTipoDoc.Location = New System.Drawing.Point(339, 19)
    Me.cboTipoDoc.Name = "cboTipoDoc"
    Me.cboTipoDoc.Size = New System.Drawing.Size(210, 24)
    Me.cboTipoDoc.TabIndex = 3
    '
    'lblDocumento
    '
    Me.lblDocumento.AutoSize = True
    Me.lblDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDocumento.Location = New System.Drawing.Point(259, 27)
    Me.lblDocumento.Name = "lblDocumento"
    Me.lblDocumento.Size = New System.Drawing.Size(77, 16)
    Me.lblDocumento.TabIndex = 2
    Me.lblDocumento.Text = "D&ocumento"
    '
    'txtSerie
    '
    Me.txtSerie.BackColor = System.Drawing.SystemColors.Window
    Me.txtSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSerie.Location = New System.Drawing.Point(607, 19)
    Me.txtSerie.Name = "txtSerie"
    Me.txtSerie.Size = New System.Drawing.Size(57, 22)
    Me.txtSerie.TabIndex = 5
    Me.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'lblSerie
    '
    Me.lblSerie.AutoSize = True
    Me.lblSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSerie.Location = New System.Drawing.Point(555, 25)
    Me.lblSerie.Name = "lblSerie"
    Me.lblSerie.Size = New System.Drawing.Size(40, 16)
    Me.lblSerie.TabIndex = 4
    Me.lblSerie.Text = "Ser&ie"
    '
    'lblFecha
    '
    Me.lblFecha.AutoSize = True
    Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFecha.Location = New System.Drawing.Point(13, 25)
    Me.lblFecha.Name = "lblFecha"
    Me.lblFecha.Size = New System.Drawing.Size(46, 16)
    Me.lblFecha.TabIndex = 0
    Me.lblFecha.Text = "&Fecha"
    '
    'dtpFecha
    '
    Me.dtpFecha.CustomFormat = "dd/MM/yyyy hh:mm tt"
    Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtpFecha.Location = New System.Drawing.Point(75, 20)
    Me.dtpFecha.Name = "dtpFecha"
    Me.dtpFecha.Size = New System.Drawing.Size(161, 22)
    Me.dtpFecha.TabIndex = 1
    '
    'txtNumero
    '
    Me.txtNumero.BackColor = System.Drawing.SystemColors.Window
    Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNumero.Location = New System.Drawing.Point(670, 19)
    Me.txtNumero.Name = "txtNumero"
    Me.txtNumero.Size = New System.Drawing.Size(98, 22)
    Me.txtNumero.TabIndex = 6
    Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'gbDocumento
    '
    Me.gbDocumento.Controls.Add(Me.cboTipoDoc)
    Me.gbDocumento.Controls.Add(Me.lblDocumento)
    Me.gbDocumento.Controls.Add(Me.txtNumero)
    Me.gbDocumento.Controls.Add(Me.txtSerie)
    Me.gbDocumento.Controls.Add(Me.dtpFecha)
    Me.gbDocumento.Controls.Add(Me.lblSerie)
    Me.gbDocumento.Controls.Add(Me.gbDeposito)
    Me.gbDocumento.Controls.Add(Me.lblFecha)
    Me.gbDocumento.Location = New System.Drawing.Point(26, 12)
    Me.gbDocumento.Name = "gbDocumento"
    Me.gbDocumento.Size = New System.Drawing.Size(897, 147)
    Me.gbDocumento.TabIndex = 0
    Me.gbDocumento.TabStop = False
    Me.gbDocumento.Text = "Documento"
    '
    'lblPagoProgramado
    '
    Me.lblPagoProgramado.AutoSize = True
    Me.lblPagoProgramado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPagoProgramado.Location = New System.Drawing.Point(282, 214)
    Me.lblPagoProgramado.Name = "lblPagoProgramado"
    Me.lblPagoProgramado.Size = New System.Drawing.Size(93, 16)
    Me.lblPagoProgramado.TabIndex = 7
    Me.lblPagoProgramado.Text = "&Programación"
    '
    'cboProgramacion
    '
    Me.cboProgramacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cboProgramacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboProgramacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboProgramacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboProgramacion.FormattingEnabled = True
    Me.cboProgramacion.Location = New System.Drawing.Point(381, 206)
    Me.cboProgramacion.MaxLength = 60
    Me.cboProgramacion.Name = "cboProgramacion"
    Me.cboProgramacion.Size = New System.Drawing.Size(318, 24)
    Me.cboProgramacion.TabIndex = 8
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(327, 174)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(48, 16)
    Me.Label1.TabIndex = 3
    Me.Label1.Text = "&Motivo"
    '
    'lblEntidad
    '
    Me.lblEntidad.AutoSize = True
    Me.lblEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblEntidad.Location = New System.Drawing.Point(23, 214)
    Me.lblEntidad.Name = "lblEntidad"
    Me.lblEntidad.Size = New System.Drawing.Size(54, 16)
    Me.lblEntidad.TabIndex = 5
    Me.lblEntidad.Text = "En&tidad"
    '
    'cboEntidad
    '
    Me.cboEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboEntidad.FormattingEnabled = True
    Me.cboEntidad.Items.AddRange(New Object() {"INST EDUCATIVA", "COPAFA"})
    Me.cboEntidad.Location = New System.Drawing.Point(77, 206)
    Me.cboEntidad.Name = "cboEntidad"
    Me.cboEntidad.Size = New System.Drawing.Size(186, 24)
    Me.cboEntidad.TabIndex = 6
    '
    'chkTodos
    '
    Me.chkTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.chkTodos.AutoSize = True
    Me.chkTodos.Location = New System.Drawing.Point(26, 646)
    Me.chkTodos.Name = "chkTodos"
    Me.chkTodos.Size = New System.Drawing.Size(111, 17)
    Me.chkTodos.TabIndex = 12
    Me.chkTodos.Text = "&Seleccionar todos"
    Me.chkTodos.UseVisualStyleBackColor = True
    '
    'txtTotal
    '
    Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtTotal.BackColor = System.Drawing.SystemColors.Window
    Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTotal.Location = New System.Drawing.Point(469, 640)
    Me.txtTotal.Name = "txtTotal"
    Me.txtTotal.ReadOnly = True
    Me.txtTotal.Size = New System.Drawing.Size(91, 22)
    Me.txtTotal.TabIndex = 16
    Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'txtPagantes
    '
    Me.txtPagantes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtPagantes.BackColor = System.Drawing.SystemColors.Window
    Me.txtPagantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPagantes.Location = New System.Drawing.Point(317, 640)
    Me.txtPagantes.Name = "txtPagantes"
    Me.txtPagantes.ReadOnly = True
    Me.txtPagantes.Size = New System.Drawing.Size(70, 22)
    Me.txtPagantes.TabIndex = 14
    Me.txtPagantes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'lblTotal
    '
    Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblTotal.AutoSize = True
    Me.lblTotal.Location = New System.Drawing.Point(424, 649)
    Me.lblTotal.Name = "lblTotal"
    Me.lblTotal.Size = New System.Drawing.Size(31, 13)
    Me.lblTotal.TabIndex = 15
    Me.lblTotal.Text = "Total"
    '
    'lblVouchers
    '
    Me.lblVouchers.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblVouchers.AutoSize = True
    Me.lblVouchers.Location = New System.Drawing.Point(251, 649)
    Me.lblVouchers.Name = "lblVouchers"
    Me.lblVouchers.Size = New System.Drawing.Size(52, 13)
    Me.lblVouchers.TabIndex = 13
    Me.lblVouchers.Text = "Vouchers"
    '
    'btnNumerar
    '
    Me.btnNumerar.Location = New System.Drawing.Point(824, 187)
    Me.btnNumerar.Name = "btnNumerar"
    Me.btnNumerar.Size = New System.Drawing.Size(99, 43)
    Me.btnNumerar.TabIndex = 10
    Me.btnNumerar.Text = "&Numerar"
    Me.btnNumerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnNumerar.UseVisualStyleBackColor = True
    '
    'cboAnio
    '
    Me.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAnio.FormattingEnabled = True
    Me.cboAnio.Location = New System.Drawing.Point(77, 169)
    Me.cboAnio.Name = "cboAnio"
    Me.cboAnio.Size = New System.Drawing.Size(107, 21)
    Me.cboAnio.TabIndex = 2
    '
    'cdSeleccionado
    '
    Me.cdSeleccionado.DataPropertyName = "Seleccionado"
    Me.cdSeleccionado.HeaderText = "Seleccionado"
    Me.cdSeleccionado.Name = "cdSeleccionado"
    Me.cdSeleccionado.Width = 80
    '
    'cdDocumento
    '
    Me.cdDocumento.DataPropertyName = "Documento"
    Me.cdDocumento.HeaderText = "Documento"
    Me.cdDocumento.Name = "cdDocumento"
    Me.cdDocumento.ReadOnly = True
    '
    'cdCodigo
    '
    Me.cdCodigo.DataPropertyName = "CodigoAlumno"
    Me.cdCodigo.HeaderText = "Código"
    Me.cdCodigo.Name = "cdCodigo"
    Me.cdCodigo.ReadOnly = True
    Me.cdCodigo.Width = 80
    '
    'cdAlumno
    '
    Me.cdAlumno.DataPropertyName = "NombreAlumno"
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.ReadOnly = True
    Me.cdAlumno.Width = 200
    '
    'cdSeccion
    '
    Me.cdSeccion.DataPropertyName = "NivelGradoSeccion"
    Me.cdSeccion.HeaderText = "Sección"
    Me.cdSeccion.Name = "cdSeccion"
    Me.cdSeccion.ReadOnly = True
    '
    'cdMonto
    '
    Me.cdMonto.DataPropertyName = "Monto"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle1.Format = "N2"
    Me.cdMonto.DefaultCellStyle = DataGridViewCellStyle1
    Me.cdMonto.HeaderText = "Monto"
    Me.cdMonto.Name = "cdMonto"
    Me.cdMonto.ReadOnly = True
    Me.cdMonto.Width = 80
    '
    'cdDescuento
    '
    Me.cdDescuento.DataPropertyName = "Descuento"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle2.NullValue = "N2"
    Me.cdDescuento.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdDescuento.HeaderText = "Descuento"
    Me.cdDescuento.Name = "cdDescuento"
    Me.cdDescuento.ReadOnly = True
    Me.cdDescuento.Width = 80
    '
    'cdMontoPagar
    '
    Me.cdMontoPagar.DataPropertyName = "MontoPagar"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle3.Format = "N2"
    Me.cdMontoPagar.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdMontoPagar.HeaderText = "MontoPagar"
    Me.cdMontoPagar.Name = "cdMontoPagar"
    Me.cdMontoPagar.Width = 80
    '
    'cdModificar
    '
    Me.cdModificar.HeaderText = "Modificar"
    Me.cdModificar.Name = "cdModificar"
    Me.cdModificar.ReadOnly = True
    Me.cdModificar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.cdModificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.cdModificar.Text = "..."
    Me.cdModificar.Visible = False
    Me.cdModificar.Width = 70
    '
    'frmPagoInstitucional
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(945, 684)
    Me.Controls.Add(Me.cboAnio)
    Me.Controls.Add(Me.txtTotal)
    Me.Controls.Add(Me.txtPagantes)
    Me.Controls.Add(Me.lblTotal)
    Me.Controls.Add(Me.lblVouchers)
    Me.Controls.Add(Me.chkTodos)
    Me.Controls.Add(Me.cboEntidad)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.lblPagoProgramado)
    Me.Controls.Add(Me.lblEntidad)
    Me.Controls.Add(Me.cboProgramacion)
    Me.Controls.Add(Me.gbDocumento)
    Me.Controls.Add(Me.lblAnio)
    Me.Controls.Add(Me.btnNumerar)
    Me.Controls.Add(Me.btnListar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.dgvAlumnos)
    Me.Controls.Add(Me.cboMotivo)
    Me.Name = "frmPagoInstitucional"
    Me.Text = "Registrar pago institucional"
    CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbDeposito.ResumeLayout(False)
    Me.gbDeposito.PerformLayout()
    CType(Me.nudMontoVoucher, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbDocumento.ResumeLayout(False)
    Me.gbDocumento.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cboMotivo As System.Windows.Forms.ComboBox
  Friend WithEvents dgvAlumnos As System.Windows.Forms.DataGridView
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents gbDeposito As System.Windows.Forms.GroupBox
  Friend WithEvents nudMontoVoucher As System.Windows.Forms.NumericUpDown
  Friend WithEvents lblCuenta As System.Windows.Forms.Label
  Friend WithEvents cboCuenta As System.Windows.Forms.ComboBox
  Friend WithEvents lblMontoVoucher As System.Windows.Forms.Label
  Friend WithEvents lblVoucher As System.Windows.Forms.Label
  Friend WithEvents txtVoucher As System.Windows.Forms.TextBox
  Friend WithEvents cboEntidadFinanciera As System.Windows.Forms.ComboBox
  Friend WithEvents lblEntidadFinanciera As System.Windows.Forms.Label
  Friend WithEvents dtpFechaVoucher As System.Windows.Forms.DateTimePicker
  Friend WithEvents lblFechaVoucher As System.Windows.Forms.Label
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents cboTipoDoc As System.Windows.Forms.ComboBox
  Friend WithEvents lblDocumento As System.Windows.Forms.Label
  Friend WithEvents txtSerie As System.Windows.Forms.TextBox
  Friend WithEvents lblSerie As System.Windows.Forms.Label
  Friend WithEvents lblFecha As System.Windows.Forms.Label
  Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
  Friend WithEvents txtNumero As System.Windows.Forms.TextBox
  Friend WithEvents gbDocumento As System.Windows.Forms.GroupBox
  Friend WithEvents cboFormaPago As System.Windows.Forms.ComboBox
  Friend WithEvents lblFormaPago As System.Windows.Forms.Label
  Friend WithEvents lblPagoProgramado As System.Windows.Forms.Label
  Friend WithEvents cboProgramacion As System.Windows.Forms.ComboBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents lblEntidad As System.Windows.Forms.Label
  Friend WithEvents cboEntidad As System.Windows.Forms.ComboBox
  Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
  Friend WithEvents txtTotal As System.Windows.Forms.TextBox
  Friend WithEvents txtPagantes As System.Windows.Forms.TextBox
  Friend WithEvents lblTotal As System.Windows.Forms.Label
  Friend WithEvents lblVouchers As System.Windows.Forms.Label
  Friend WithEvents btnNumerar As System.Windows.Forms.Button
  Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
  Friend WithEvents cdSeleccionado As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents cdDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdSeccion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdMonto As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDescuento As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdMontoPagar As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdModificar As System.Windows.Forms.DataGridViewButtonColumn
End Class
