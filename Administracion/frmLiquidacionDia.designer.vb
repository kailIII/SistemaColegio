<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLiquidacionDia
    Inherits Colegio.Plantillas.frmPlantilla

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
    Me.lblDel = New System.Windows.Forms.Label()
    Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
    Me.dgvDocumentos = New System.Windows.Forms.DataGridView()
    Me.cdDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdCodigoAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Persona = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdFormaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdCuentaBancaria = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.btnExportar = New System.Windows.Forms.Button()
    Me.lblEfectivo = New System.Windows.Forms.Label()
    Me.lblCheque = New System.Windows.Forms.Label()
    Me.lblTotalRecaudado = New System.Windows.Forms.Label()
    Me.lblTotalCuentas = New System.Windows.Forms.Label()
    Me.txtTotalEfectivo = New System.Windows.Forms.TextBox()
    Me.txtTotalCheques = New System.Windows.Forms.TextBox()
    Me.txtTotalRecaudado = New System.Windows.Forms.TextBox()
    Me.txtTotalCuentas = New System.Windows.Forms.TextBox()
    Me.txtTotalCaja = New System.Windows.Forms.TextBox()
    Me.lblTotalCaja = New System.Windows.Forms.Label()
    Me.txtTotalBIF = New System.Windows.Forms.TextBox()
    Me.lblBIF = New System.Windows.Forms.Label()
    Me.txtTotalBCP = New System.Windows.Forms.TextBox()
    Me.lblBCP = New System.Windows.Forms.Label()
    Me.txtTotalVouchers = New System.Windows.Forms.TextBox()
    Me.lblVoucher = New System.Windows.Forms.Label()
    Me.btnBuscar = New System.Windows.Forms.Button()
    Me.cboEntidad = New System.Windows.Forms.ComboBox()
    Me.lblEntidad = New System.Windows.Forms.Label()
    Me.gbCaja = New System.Windows.Forms.GroupBox()
    Me.gbCuentaRecaudadora = New System.Windows.Forms.GroupBox()
    Me.btnImprimir = New System.Windows.Forms.Button()
    Me.lblNumero = New System.Windows.Forms.Label()
    Me.nudNumero = New System.Windows.Forms.NumericUpDown()
    Me.btnSiguiente = New System.Windows.Forms.Button()
    Me.btnAnterior = New System.Windows.Forms.Button()
    CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbCaja.SuspendLayout()
    Me.gbCuentaRecaudadora.SuspendLayout()
    CType(Me.nudNumero, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblDel
    '
    Me.lblDel.Anchor = System.Windows.Forms.AnchorStyles.Top
    Me.lblDel.AutoSize = True
    Me.lblDel.Location = New System.Drawing.Point(253, 30)
    Me.lblDel.Name = "lblDel"
    Me.lblDel.Size = New System.Drawing.Size(23, 13)
    Me.lblDel.TabIndex = 2
    Me.lblDel.Text = "&Del"
    '
    'dtpFecha
    '
    Me.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.Top
    Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtpFecha.Location = New System.Drawing.Point(256, 50)
    Me.dtpFecha.Name = "dtpFecha"
    Me.dtpFecha.Size = New System.Drawing.Size(114, 20)
    Me.dtpFecha.TabIndex = 3
    '
    'dgvDocumentos
    '
    Me.dgvDocumentos.AllowUserToAddRows = False
    Me.dgvDocumentos.AllowUserToDeleteRows = False
    Me.dgvDocumentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvDocumentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdDocumento, Me.cdCodigoAlumno, Me.Persona, Me.cdDescripcion, Me.cdMonto, Me.cdCuenta, Me.cdFormaPago, Me.cdCuentaBancaria})
    Me.dgvDocumentos.Location = New System.Drawing.Point(17, 121)
    Me.dgvDocumentos.Name = "dgvDocumentos"
    Me.dgvDocumentos.ReadOnly = True
    Me.dgvDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvDocumentos.Size = New System.Drawing.Size(811, 294)
    Me.dgvDocumentos.TabIndex = 8
    '
    'cdDocumento
    '
    Me.cdDocumento.DataPropertyName = "DocumentoNumero"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.cdDocumento.DefaultCellStyle = DataGridViewCellStyle1
    Me.cdDocumento.HeaderText = "Documento"
    Me.cdDocumento.Name = "cdDocumento"
    Me.cdDocumento.ReadOnly = True
    Me.cdDocumento.Width = 110
    '
    'cdCodigoAlumno
    '
    Me.cdCodigoAlumno.DataPropertyName = "CodigoRecaudacionAlumno"
    Me.cdCodigoAlumno.HeaderText = "Código"
    Me.cdCodigoAlumno.Name = "cdCodigoAlumno"
    Me.cdCodigoAlumno.ReadOnly = True
    '
    'Persona
    '
    Me.Persona.DataPropertyName = "NombrePersona"
    Me.Persona.HeaderText = "Persona"
    Me.Persona.Name = "Persona"
    Me.Persona.ReadOnly = True
    Me.Persona.Width = 200
    '
    'cdDescripcion
    '
    Me.cdDescripcion.DataPropertyName = "Descripcion"
    Me.cdDescripcion.HeaderText = "Detalle"
    Me.cdDescripcion.Name = "cdDescripcion"
    Me.cdDescripcion.ReadOnly = True
    Me.cdDescripcion.Width = 190
    '
    'cdMonto
    '
    Me.cdMonto.DataPropertyName = "Monto"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle2.Format = "N2"
    Me.cdMonto.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdMonto.HeaderText = "Monto"
    Me.cdMonto.Name = "cdMonto"
    Me.cdMonto.ReadOnly = True
    Me.cdMonto.Width = 80
    '
    'cdCuenta
    '
    Me.cdCuenta.DataPropertyName = "NumeroCuentaContable"
    Me.cdCuenta.HeaderText = "Cuenta"
    Me.cdCuenta.Name = "cdCuenta"
    Me.cdCuenta.ReadOnly = True
    '
    'cdFormaPago
    '
    Me.cdFormaPago.DataPropertyName = "DescripcionFormaPago"
    Me.cdFormaPago.HeaderText = "Forma de pago"
    Me.cdFormaPago.Name = "cdFormaPago"
    Me.cdFormaPago.ReadOnly = True
    '
    'cdCuentaBancaria
    '
    Me.cdCuentaBancaria.DataPropertyName = "NumeroCuentaBancaria"
    Me.cdCuentaBancaria.HeaderText = "Cuenta bancaria"
    Me.cdCuentaBancaria.Name = "cdCuentaBancaria"
    Me.cdCuentaBancaria.ReadOnly = True
    '
    'btnCancelar
    '
    Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(722, 533)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(106, 52)
    Me.btnCancelar.TabIndex = 17
    Me.btnCancelar.Text = "&Cerrar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnExportar
    '
    Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnExportar.BackColor = System.Drawing.Color.White
    Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnExportar.Location = New System.Drawing.Point(609, 533)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(106, 52)
    Me.btnExportar.TabIndex = 16
    Me.btnExportar.Text = "&Exportar"
    Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnExportar.UseVisualStyleBackColor = False
    '
    'lblEfectivo
    '
    Me.lblEfectivo.AutoSize = True
    Me.lblEfectivo.Location = New System.Drawing.Point(70, 15)
    Me.lblEfectivo.Name = "lblEfectivo"
    Me.lblEfectivo.Size = New System.Drawing.Size(46, 13)
    Me.lblEfectivo.TabIndex = 1
    Me.lblEfectivo.Text = "Efectivo"
    '
    'lblCheque
    '
    Me.lblCheque.AutoSize = True
    Me.lblCheque.Location = New System.Drawing.Point(184, 15)
    Me.lblCheque.Name = "lblCheque"
    Me.lblCheque.Size = New System.Drawing.Size(44, 13)
    Me.lblCheque.TabIndex = 3
    Me.lblCheque.Text = "Cheque"
    '
    'lblTotalRecaudado
    '
    Me.lblTotalRecaudado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblTotalRecaudado.AutoSize = True
    Me.lblTotalRecaudado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTotalRecaudado.Location = New System.Drawing.Point(14, 529)
    Me.lblTotalRecaudado.Name = "lblTotalRecaudado"
    Me.lblTotalRecaudado.Size = New System.Drawing.Size(111, 15)
    Me.lblTotalRecaudado.TabIndex = 11
    Me.lblTotalRecaudado.Text = "Total recaudado"
    '
    'lblTotalCuentas
    '
    Me.lblTotalCuentas.AutoSize = True
    Me.lblTotalCuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTotalCuentas.Location = New System.Drawing.Point(170, 72)
    Me.lblTotalCuentas.Name = "lblTotalCuentas"
    Me.lblTotalCuentas.Size = New System.Drawing.Size(39, 15)
    Me.lblTotalCuentas.TabIndex = 14
    Me.lblTotalCuentas.Text = "Total"
    '
    'txtTotalEfectivo
    '
    Me.txtTotalEfectivo.BackColor = System.Drawing.SystemColors.Window
    Me.txtTotalEfectivo.Location = New System.Drawing.Point(72, 32)
    Me.txtTotalEfectivo.Name = "txtTotalEfectivo"
    Me.txtTotalEfectivo.ReadOnly = True
    Me.txtTotalEfectivo.Size = New System.Drawing.Size(100, 20)
    Me.txtTotalEfectivo.TabIndex = 2
    Me.txtTotalEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'txtTotalCheques
    '
    Me.txtTotalCheques.BackColor = System.Drawing.SystemColors.Window
    Me.txtTotalCheques.Location = New System.Drawing.Point(187, 32)
    Me.txtTotalCheques.Name = "txtTotalCheques"
    Me.txtTotalCheques.ReadOnly = True
    Me.txtTotalCheques.Size = New System.Drawing.Size(100, 20)
    Me.txtTotalCheques.TabIndex = 4
    Me.txtTotalCheques.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'txtTotalRecaudado
    '
    Me.txtTotalRecaudado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtTotalRecaudado.BackColor = System.Drawing.SystemColors.Window
    Me.txtTotalRecaudado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTotalRecaudado.Location = New System.Drawing.Point(131, 522)
    Me.txtTotalRecaudado.Name = "txtTotalRecaudado"
    Me.txtTotalRecaudado.ReadOnly = True
    Me.txtTotalRecaudado.Size = New System.Drawing.Size(100, 22)
    Me.txtTotalRecaudado.TabIndex = 12
    Me.txtTotalRecaudado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'txtTotalCuentas
    '
    Me.txtTotalCuentas.BackColor = System.Drawing.SystemColors.Window
    Me.txtTotalCuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTotalCuentas.Location = New System.Drawing.Point(215, 67)
    Me.txtTotalCuentas.Name = "txtTotalCuentas"
    Me.txtTotalCuentas.ReadOnly = True
    Me.txtTotalCuentas.Size = New System.Drawing.Size(100, 22)
    Me.txtTotalCuentas.TabIndex = 15
    Me.txtTotalCuentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'txtTotalCaja
    '
    Me.txtTotalCaja.BackColor = System.Drawing.SystemColors.Window
    Me.txtTotalCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTotalCaja.Location = New System.Drawing.Point(300, 67)
    Me.txtTotalCaja.Name = "txtTotalCaja"
    Me.txtTotalCaja.ReadOnly = True
    Me.txtTotalCaja.Size = New System.Drawing.Size(100, 22)
    Me.txtTotalCaja.TabIndex = 8
    Me.txtTotalCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'lblTotalCaja
    '
    Me.lblTotalCaja.AutoSize = True
    Me.lblTotalCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTotalCaja.Location = New System.Drawing.Point(251, 74)
    Me.lblTotalCaja.Name = "lblTotalCaja"
    Me.lblTotalCaja.Size = New System.Drawing.Size(39, 15)
    Me.lblTotalCaja.TabIndex = 7
    Me.lblTotalCaja.Text = "Total"
    '
    'txtTotalBIF
    '
    Me.txtTotalBIF.BackColor = System.Drawing.SystemColors.Window
    Me.txtTotalBIF.Location = New System.Drawing.Point(216, 32)
    Me.txtTotalBIF.Name = "txtTotalBIF"
    Me.txtTotalBIF.ReadOnly = True
    Me.txtTotalBIF.Size = New System.Drawing.Size(100, 20)
    Me.txtTotalBIF.TabIndex = 13
    Me.txtTotalBIF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'lblBIF
    '
    Me.lblBIF.AutoSize = True
    Me.lblBIF.Location = New System.Drawing.Point(213, 16)
    Me.lblBIF.Name = "lblBIF"
    Me.lblBIF.Size = New System.Drawing.Size(23, 13)
    Me.lblBIF.TabIndex = 12
    Me.lblBIF.Text = "BIF"
    '
    'txtTotalBCP
    '
    Me.txtTotalBCP.BackColor = System.Drawing.SystemColors.Window
    Me.txtTotalBCP.Location = New System.Drawing.Point(88, 32)
    Me.txtTotalBCP.Name = "txtTotalBCP"
    Me.txtTotalBCP.ReadOnly = True
    Me.txtTotalBCP.Size = New System.Drawing.Size(100, 20)
    Me.txtTotalBCP.TabIndex = 11
    Me.txtTotalBCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'lblBCP
    '
    Me.lblBCP.AutoSize = True
    Me.lblBCP.Location = New System.Drawing.Point(85, 16)
    Me.lblBCP.Name = "lblBCP"
    Me.lblBCP.Size = New System.Drawing.Size(28, 13)
    Me.lblBCP.TabIndex = 10
    Me.lblBCP.Text = "BCP"
    '
    'txtTotalVouchers
    '
    Me.txtTotalVouchers.BackColor = System.Drawing.SystemColors.Window
    Me.txtTotalVouchers.Location = New System.Drawing.Point(300, 32)
    Me.txtTotalVouchers.Name = "txtTotalVouchers"
    Me.txtTotalVouchers.ReadOnly = True
    Me.txtTotalVouchers.Size = New System.Drawing.Size(100, 20)
    Me.txtTotalVouchers.TabIndex = 6
    Me.txtTotalVouchers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'lblVoucher
    '
    Me.lblVoucher.AutoSize = True
    Me.lblVoucher.Location = New System.Drawing.Point(297, 15)
    Me.lblVoucher.Name = "lblVoucher"
    Me.lblVoucher.Size = New System.Drawing.Size(47, 13)
    Me.lblVoucher.TabIndex = 5
    Me.lblVoucher.Text = "Voucher"
    '
    'btnBuscar
    '
    Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnBuscar.BackColor = System.Drawing.Color.White
    Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscar.Location = New System.Drawing.Point(416, 18)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(110, 52)
    Me.btnBuscar.TabIndex = 4
    Me.btnBuscar.Text = "&Buscar"
    Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscar.UseVisualStyleBackColor = False
    '
    'cboEntidad
    '
    Me.cboEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboEntidad.FormattingEnabled = True
    Me.cboEntidad.Items.AddRange(New Object() {"INST EDUCATIVA", "COPAFA"})
    Me.cboEntidad.Location = New System.Drawing.Point(17, 46)
    Me.cboEntidad.Name = "cboEntidad"
    Me.cboEntidad.Size = New System.Drawing.Size(166, 24)
    Me.cboEntidad.TabIndex = 1
    '
    'lblEntidad
    '
    Me.lblEntidad.AutoSize = True
    Me.lblEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblEntidad.Location = New System.Drawing.Point(14, 27)
    Me.lblEntidad.Name = "lblEntidad"
    Me.lblEntidad.Size = New System.Drawing.Size(54, 16)
    Me.lblEntidad.TabIndex = 0
    Me.lblEntidad.Text = "E&ntidad"
    '
    'gbCaja
    '
    Me.gbCaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.gbCaja.Controls.Add(Me.lblEfectivo)
    Me.gbCaja.Controls.Add(Me.txtTotalCaja)
    Me.gbCaja.Controls.Add(Me.lblTotalCaja)
    Me.gbCaja.Controls.Add(Me.lblCheque)
    Me.gbCaja.Controls.Add(Me.lblVoucher)
    Me.gbCaja.Controls.Add(Me.txtTotalEfectivo)
    Me.gbCaja.Controls.Add(Me.txtTotalCheques)
    Me.gbCaja.Controls.Add(Me.txtTotalVouchers)
    Me.gbCaja.Location = New System.Drawing.Point(17, 421)
    Me.gbCaja.Name = "gbCaja"
    Me.gbCaja.Size = New System.Drawing.Size(413, 95)
    Me.gbCaja.TabIndex = 9
    Me.gbCaja.TabStop = False
    Me.gbCaja.Text = "Caja"
    '
    'gbCuentaRecaudadora
    '
    Me.gbCuentaRecaudadora.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.gbCuentaRecaudadora.Controls.Add(Me.txtTotalBCP)
    Me.gbCuentaRecaudadora.Controls.Add(Me.lblBCP)
    Me.gbCuentaRecaudadora.Controls.Add(Me.txtTotalCuentas)
    Me.gbCuentaRecaudadora.Controls.Add(Me.txtTotalBIF)
    Me.gbCuentaRecaudadora.Controls.Add(Me.lblTotalCuentas)
    Me.gbCuentaRecaudadora.Controls.Add(Me.lblBIF)
    Me.gbCuentaRecaudadora.Location = New System.Drawing.Point(436, 421)
    Me.gbCuentaRecaudadora.Name = "gbCuentaRecaudadora"
    Me.gbCuentaRecaudadora.Size = New System.Drawing.Size(331, 95)
    Me.gbCuentaRecaudadora.TabIndex = 10
    Me.gbCuentaRecaudadora.TabStop = False
    Me.gbCuentaRecaudadora.Text = "Cuenta recaudadora"
    '
    'btnImprimir
    '
    Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnImprimir.BackColor = System.Drawing.Color.White
    Me.btnImprimir.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnImprimir.Location = New System.Drawing.Point(497, 533)
    Me.btnImprimir.Name = "btnImprimir"
    Me.btnImprimir.Size = New System.Drawing.Size(106, 52)
    Me.btnImprimir.TabIndex = 15
    Me.btnImprimir.Text = "&Imprimir"
    Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnImprimir.UseVisualStyleBackColor = False
    '
    'lblNumero
    '
    Me.lblNumero.AutoSize = True
    Me.lblNumero.Enabled = False
    Me.lblNumero.Location = New System.Drawing.Point(18, 102)
    Me.lblNumero.Name = "lblNumero"
    Me.lblNumero.Size = New System.Drawing.Size(76, 13)
    Me.lblNumero.TabIndex = 5
    Me.lblNumero.Text = "Liquidación N°"
    Me.lblNumero.Visible = False
    '
    'nudNumero
    '
    Me.nudNumero.Enabled = False
    Me.nudNumero.Location = New System.Drawing.Point(106, 95)
    Me.nudNumero.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
    Me.nudNumero.Name = "nudNumero"
    Me.nudNumero.Size = New System.Drawing.Size(77, 20)
    Me.nudNumero.TabIndex = 6
    Me.nudNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.nudNumero.Visible = False
    '
    'btnSiguiente
    '
    Me.btnSiguiente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnSiguiente.BackColor = System.Drawing.Color.White
    Me.btnSiguiente.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnSiguiente.Location = New System.Drawing.Point(385, 533)
    Me.btnSiguiente.Name = "btnSiguiente"
    Me.btnSiguiente.Size = New System.Drawing.Size(106, 52)
    Me.btnSiguiente.TabIndex = 14
    Me.btnSiguiente.Text = "&Siguiente"
    Me.btnSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnSiguiente.UseVisualStyleBackColor = False
    '
    'btnAnterior
    '
    Me.btnAnterior.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnAnterior.BackColor = System.Drawing.Color.White
    Me.btnAnterior.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAnterior.Location = New System.Drawing.Point(273, 533)
    Me.btnAnterior.Name = "btnAnterior"
    Me.btnAnterior.Size = New System.Drawing.Size(106, 52)
    Me.btnAnterior.TabIndex = 13
    Me.btnAnterior.Text = "An&terior"
    Me.btnAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnAnterior.UseVisualStyleBackColor = False
    '
    'frmLiquidacionDia
    '
    Me.AcceptButton = Me.btnBuscar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(850, 597)
    Me.Controls.Add(Me.btnAnterior)
    Me.Controls.Add(Me.btnSiguiente)
    Me.Controls.Add(Me.nudNumero)
    Me.Controls.Add(Me.lblNumero)
    Me.Controls.Add(Me.gbCuentaRecaudadora)
    Me.Controls.Add(Me.cboEntidad)
    Me.Controls.Add(Me.gbCaja)
    Me.Controls.Add(Me.txtTotalRecaudado)
    Me.Controls.Add(Me.lblEntidad)
    Me.Controls.Add(Me.lblTotalRecaudado)
    Me.Controls.Add(Me.btnBuscar)
    Me.Controls.Add(Me.btnImprimir)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.dgvDocumentos)
    Me.Controls.Add(Me.dtpFecha)
    Me.Controls.Add(Me.lblDel)
    Me.Name = "frmLiquidacionDia"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "LIQUIDACIÓN DEL DÍA"
    CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbCaja.ResumeLayout(False)
    Me.gbCaja.PerformLayout()
    Me.gbCuentaRecaudadora.ResumeLayout(False)
    Me.gbCuentaRecaudadora.PerformLayout()
    CType(Me.nudNumero, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblDel As System.Windows.Forms.Label
  Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
  Friend WithEvents dgvDocumentos As System.Windows.Forms.DataGridView
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents lblEfectivo As System.Windows.Forms.Label
  Friend WithEvents lblCheque As System.Windows.Forms.Label
  Friend WithEvents lblTotalRecaudado As System.Windows.Forms.Label
  Friend WithEvents lblTotalCuentas As System.Windows.Forms.Label
  Friend WithEvents txtTotalEfectivo As System.Windows.Forms.TextBox
  Friend WithEvents txtTotalCheques As System.Windows.Forms.TextBox
  Friend WithEvents txtTotalRecaudado As System.Windows.Forms.TextBox
  Friend WithEvents txtTotalCuentas As System.Windows.Forms.TextBox
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
  Friend WithEvents txtTotalBIF As System.Windows.Forms.TextBox
  Friend WithEvents lblBIF As System.Windows.Forms.Label
  Friend WithEvents txtTotalBCP As System.Windows.Forms.TextBox
  Friend WithEvents lblBCP As System.Windows.Forms.Label
  Friend WithEvents txtTotalCaja As System.Windows.Forms.TextBox
  Friend WithEvents lblTotalCaja As System.Windows.Forms.Label
  Friend WithEvents txtTotalVouchers As System.Windows.Forms.TextBox
  Friend WithEvents lblVoucher As System.Windows.Forms.Label
  Friend WithEvents cboEntidad As System.Windows.Forms.ComboBox
  Friend WithEvents lblEntidad As System.Windows.Forms.Label
  Friend WithEvents gbCaja As System.Windows.Forms.GroupBox
  Friend WithEvents gbCuentaRecaudadora As System.Windows.Forms.GroupBox
  Friend WithEvents cdDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCodigoAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Persona As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdMonto As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdFormaPago As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCuentaBancaria As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnImprimir As System.Windows.Forms.Button
  Friend WithEvents lblNumero As System.Windows.Forms.Label
  Friend WithEvents nudNumero As System.Windows.Forms.NumericUpDown
  Friend WithEvents btnSiguiente As System.Windows.Forms.Button
  Friend WithEvents btnAnterior As System.Windows.Forms.Button
End Class
