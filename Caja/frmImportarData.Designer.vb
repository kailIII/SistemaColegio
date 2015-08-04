<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportarData
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
    Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.btnImportar = New System.Windows.Forms.Button()
    Me.cboEntidadFinanciera = New System.Windows.Forms.ComboBox()
    Me.lblEntidad = New System.Windows.Forms.Label()
    Me.dgvVouchersInstitucion = New System.Windows.Forms.DataGridView()
    Me.cdImprimir = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.colalumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdRecibo = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.colVoucher = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdFechaVoucher = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdCanjear = New System.Windows.Forms.DataGridViewButtonColumn()
    Me.gbDocumentosInstitucion = New System.Windows.Forms.GroupBox()
    Me.btnVolverGenerarInstitucion = New System.Windows.Forms.Button()
    Me.chkSeleccionarTodosInstitucion = New System.Windows.Forms.CheckBox()
    Me.btnRegistrarInstitucion = New System.Windows.Forms.Button()
    Me.txtTotal = New System.Windows.Forms.TextBox()
    Me.txtVouchers = New System.Windows.Forms.TextBox()
    Me.lblTotal = New System.Windows.Forms.Label()
    Me.lblVouchersInstitucion = New System.Windows.Forms.Label()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.txtSerieInstitucion = New System.Windows.Forms.TextBox()
    Me.gbDocumentoInstitucion = New System.Windows.Forms.GroupBox()
    Me.dtpFechaInstitucion = New System.Windows.Forms.DateTimePicker()
    Me.lblFechaInstitucion = New System.Windows.Forms.Label()
    Me.cboTipoDocInstitucion = New System.Windows.Forms.ComboBox()
    Me.lblTipoDocInstitucion = New System.Windows.Forms.Label()
    Me.lblNumeroInstitucion = New System.Windows.Forms.Label()
    Me.txtNumeroInstitucion = New System.Windows.Forms.TextBox()
    Me.cboCuenta = New System.Windows.Forms.ComboBox()
    Me.lblCuenta = New System.Windows.Forms.Label()
    Me.tbcImportacion = New System.Windows.Forms.TabControl()
    Me.tbpInstitucion = New System.Windows.Forms.TabPage()
    Me.tbpCopafa = New System.Windows.Forms.TabPage()
    Me.gbTipoDocCOPAFA = New System.Windows.Forms.GroupBox()
    Me.dtpFechaCOPAFA = New System.Windows.Forms.DateTimePicker()
    Me.lblFechaCOPAFA = New System.Windows.Forms.Label()
    Me.cboTipoDocCOPAFA = New System.Windows.Forms.ComboBox()
    Me.lblTipoDocCOPAFA = New System.Windows.Forms.Label()
    Me.txtSerieCOPAFA = New System.Windows.Forms.TextBox()
    Me.lblNumeroCOPAFA = New System.Windows.Forms.Label()
    Me.txtNumeroCOPAFA = New System.Windows.Forms.TextBox()
    Me.gbVouchersCOPAFA = New System.Windows.Forms.GroupBox()
    Me.btnRegistrarCOPAFA = New System.Windows.Forms.Button()
    Me.btnVolverGenerarCOPAFA = New System.Windows.Forms.Button()
    Me.chkSeleccionarTodosCOPAFA = New System.Windows.Forms.CheckBox()
    Me.dgvVouchersCOPAFA = New System.Windows.Forms.DataGridView()
    Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
    CType(Me.dgvVouchersInstitucion, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbDocumentosInstitucion.SuspendLayout()
    Me.gbDocumentoInstitucion.SuspendLayout()
    Me.tbcImportacion.SuspendLayout()
    Me.tbpInstitucion.SuspendLayout()
    Me.tbpCopafa.SuspendLayout()
    Me.gbTipoDocCOPAFA.SuspendLayout()
    Me.gbVouchersCOPAFA.SuspendLayout()
    CType(Me.dgvVouchersCOPAFA, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnImportar
    '
    Me.btnImportar.BackColor = System.Drawing.Color.White
    Me.btnImportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnImportar.Location = New System.Drawing.Point(660, 17)
    Me.btnImportar.Name = "btnImportar"
    Me.btnImportar.Size = New System.Drawing.Size(102, 42)
    Me.btnImportar.TabIndex = 4
    Me.btnImportar.Text = "I&mportar"
    Me.btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnImportar.UseVisualStyleBackColor = False
    '
    'cboEntidadFinanciera
    '
    Me.cboEntidadFinanciera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEntidadFinanciera.FormattingEnabled = True
    Me.cboEntidadFinanciera.Location = New System.Drawing.Point(68, 29)
    Me.cboEntidadFinanciera.Name = "cboEntidadFinanciera"
    Me.cboEntidadFinanciera.Size = New System.Drawing.Size(256, 21)
    Me.cboEntidadFinanciera.TabIndex = 1
    '
    'lblEntidad
    '
    Me.lblEntidad.AutoSize = True
    Me.lblEntidad.Location = New System.Drawing.Point(19, 35)
    Me.lblEntidad.Name = "lblEntidad"
    Me.lblEntidad.Size = New System.Drawing.Size(43, 13)
    Me.lblEntidad.TabIndex = 0
    Me.lblEntidad.Text = "E&ntidad"
    '
    'dgvVouchersInstitucion
    '
    Me.dgvVouchersInstitucion.AllowUserToAddRows = False
    Me.dgvVouchersInstitucion.AllowUserToDeleteRows = False
    Me.dgvVouchersInstitucion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvVouchersInstitucion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle21
    Me.dgvVouchersInstitucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvVouchersInstitucion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdImprimir, Me.colalumno, Me.cdRecibo, Me.colVoucher, Me.cdFechaVoucher, Me.colTotal, Me.cdCanjear})
    DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgvVouchersInstitucion.DefaultCellStyle = DataGridViewCellStyle24
    Me.dgvVouchersInstitucion.Location = New System.Drawing.Point(12, 19)
    Me.dgvVouchersInstitucion.MultiSelect = False
    Me.dgvVouchersInstitucion.Name = "dgvVouchersInstitucion"
    DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvVouchersInstitucion.RowHeadersDefaultCellStyle = DataGridViewCellStyle25
    Me.dgvVouchersInstitucion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvVouchersInstitucion.Size = New System.Drawing.Size(794, 296)
    Me.dgvVouchersInstitucion.TabIndex = 0
    '
    'cdImprimir
    '
    Me.cdImprimir.DataPropertyName = "Imprimir"
    Me.cdImprimir.HeaderText = "Imprimir"
    Me.cdImprimir.Name = "cdImprimir"
    Me.cdImprimir.Width = 50
    '
    'colalumno
    '
    Me.colalumno.DataPropertyName = "NombrePersona"
    Me.colalumno.HeaderText = "Nombre"
    Me.colalumno.Name = "colalumno"
    Me.colalumno.Width = 200
    '
    'cdRecibo
    '
    Me.cdRecibo.DataPropertyName = "NumeroRecibo"
    Me.cdRecibo.HeaderText = "Recibo"
    Me.cdRecibo.Name = "cdRecibo"
    Me.cdRecibo.ReadOnly = True
    Me.cdRecibo.Width = 120
    '
    'colVoucher
    '
    Me.colVoucher.DataPropertyName = "NumeroVoucher"
    Me.colVoucher.HeaderText = "Voucher"
    Me.colVoucher.Name = "colVoucher"
    '
    'cdFechaVoucher
    '
    Me.cdFechaVoucher.DataPropertyName = "FechaVoucher"
    DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle22.Format = "g"
    DataGridViewCellStyle22.NullValue = Nothing
    Me.cdFechaVoucher.DefaultCellStyle = DataGridViewCellStyle22
    Me.cdFechaVoucher.HeaderText = "Fecha de pago"
    Me.cdFechaVoucher.Name = "cdFechaVoucher"
    Me.cdFechaVoucher.Width = 120
    '
    'colTotal
    '
    Me.colTotal.DataPropertyName = "Total"
    DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle23.Format = "N2"
    DataGridViewCellStyle23.NullValue = Nothing
    Me.colTotal.DefaultCellStyle = DataGridViewCellStyle23
    Me.colTotal.HeaderText = "Total"
    Me.colTotal.Name = "colTotal"
    '
    'cdCanjear
    '
    Me.cdCanjear.HeaderText = "Canjear"
    Me.cdCanjear.Name = "cdCanjear"
    Me.cdCanjear.ReadOnly = True
    Me.cdCanjear.Text = "..."
    Me.cdCanjear.UseColumnTextForButtonValue = True
    Me.cdCanjear.Width = 70
    '
    'gbDocumentosInstitucion
    '
    Me.gbDocumentosInstitucion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbDocumentosInstitucion.Controls.Add(Me.btnVolverGenerarInstitucion)
    Me.gbDocumentosInstitucion.Controls.Add(Me.chkSeleccionarTodosInstitucion)
    Me.gbDocumentosInstitucion.Controls.Add(Me.dgvVouchersInstitucion)
    Me.gbDocumentosInstitucion.Controls.Add(Me.btnRegistrarInstitucion)
    Me.gbDocumentosInstitucion.Location = New System.Drawing.Point(6, 136)
    Me.gbDocumentosInstitucion.Name = "gbDocumentosInstitucion"
    Me.gbDocumentosInstitucion.Size = New System.Drawing.Size(824, 383)
    Me.gbDocumentosInstitucion.TabIndex = 5
    Me.gbDocumentosInstitucion.TabStop = False
    Me.gbDocumentosInstitucion.Text = "Voucher de Pagos"
    '
    'btnVolverGenerarInstitucion
    '
    Me.btnVolverGenerarInstitucion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnVolverGenerarInstitucion.Location = New System.Drawing.Point(163, 347)
    Me.btnVolverGenerarInstitucion.Name = "btnVolverGenerarInstitucion"
    Me.btnVolverGenerarInstitucion.Size = New System.Drawing.Size(139, 30)
    Me.btnVolverGenerarInstitucion.TabIndex = 6
    Me.btnVolverGenerarInstitucion.Text = "Reinici&ar numeración"
    Me.btnVolverGenerarInstitucion.UseVisualStyleBackColor = True
    '
    'chkSeleccionarTodosInstitucion
    '
    Me.chkSeleccionarTodosInstitucion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.chkSeleccionarTodosInstitucion.AutoSize = True
    Me.chkSeleccionarTodosInstitucion.Checked = True
    Me.chkSeleccionarTodosInstitucion.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkSeleccionarTodosInstitucion.Location = New System.Drawing.Point(14, 360)
    Me.chkSeleccionarTodosInstitucion.Name = "chkSeleccionarTodosInstitucion"
    Me.chkSeleccionarTodosInstitucion.Size = New System.Drawing.Size(111, 17)
    Me.chkSeleccionarTodosInstitucion.TabIndex = 1
    Me.chkSeleccionarTodosInstitucion.Text = "Seleccionar &todos"
    Me.chkSeleccionarTodosInstitucion.UseVisualStyleBackColor = True
    '
    'btnRegistrarInstitucion
    '
    Me.btnRegistrarInstitucion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnRegistrarInstitucion.BackColor = System.Drawing.Color.White
    Me.btnRegistrarInstitucion.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrarInstitucion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrarInstitucion.Location = New System.Drawing.Point(696, 321)
    Me.btnRegistrarInstitucion.Name = "btnRegistrarInstitucion"
    Me.btnRegistrarInstitucion.Size = New System.Drawing.Size(110, 52)
    Me.btnRegistrarInstitucion.TabIndex = 6
    Me.btnRegistrarInstitucion.Text = "&Registrar"
    Me.btnRegistrarInstitucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrarInstitucion.UseVisualStyleBackColor = False
    '
    'txtTotal
    '
    Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtTotal.BackColor = System.Drawing.SystemColors.Window
    Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTotal.Location = New System.Drawing.Point(231, 629)
    Me.txtTotal.Name = "txtTotal"
    Me.txtTotal.ReadOnly = True
    Me.txtTotal.Size = New System.Drawing.Size(91, 22)
    Me.txtTotal.TabIndex = 9
    Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'txtVouchers
    '
    Me.txtVouchers.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtVouchers.BackColor = System.Drawing.SystemColors.Window
    Me.txtVouchers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtVouchers.Location = New System.Drawing.Point(100, 629)
    Me.txtVouchers.Name = "txtVouchers"
    Me.txtVouchers.ReadOnly = True
    Me.txtVouchers.Size = New System.Drawing.Size(70, 22)
    Me.txtVouchers.TabIndex = 7
    Me.txtVouchers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'lblTotal
    '
    Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblTotal.AutoSize = True
    Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTotal.Location = New System.Drawing.Point(178, 638)
    Me.lblTotal.Name = "lblTotal"
    Me.lblTotal.Size = New System.Drawing.Size(47, 13)
    Me.lblTotal.TabIndex = 8
    Me.lblTotal.Text = "TOTAL"
    '
    'lblVouchersInstitucion
    '
    Me.lblVouchersInstitucion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblVouchersInstitucion.AutoSize = True
    Me.lblVouchersInstitucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblVouchersInstitucion.Location = New System.Drawing.Point(19, 638)
    Me.lblVouchersInstitucion.Name = "lblVouchersInstitucion"
    Me.lblVouchersInstitucion.Size = New System.Drawing.Size(75, 13)
    Me.lblVouchersInstitucion.TabIndex = 6
    Me.lblVouchersInstitucion.Text = "VOUCHERS"
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(872, 622)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 10
    Me.btnCerrar.Text = "C&errar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'txtSerieInstitucion
    '
    Me.txtSerieInstitucion.BackColor = System.Drawing.SystemColors.Window
    Me.txtSerieInstitucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSerieInstitucion.Location = New System.Drawing.Point(366, 39)
    Me.txtSerieInstitucion.Name = "txtSerieInstitucion"
    Me.txtSerieInstitucion.Size = New System.Drawing.Size(70, 22)
    Me.txtSerieInstitucion.TabIndex = 3
    Me.txtSerieInstitucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'gbDocumentoInstitucion
    '
    Me.gbDocumentoInstitucion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbDocumentoInstitucion.Controls.Add(Me.dtpFechaInstitucion)
    Me.gbDocumentoInstitucion.Controls.Add(Me.lblFechaInstitucion)
    Me.gbDocumentoInstitucion.Controls.Add(Me.cboTipoDocInstitucion)
    Me.gbDocumentoInstitucion.Controls.Add(Me.lblTipoDocInstitucion)
    Me.gbDocumentoInstitucion.Controls.Add(Me.txtSerieInstitucion)
    Me.gbDocumentoInstitucion.Controls.Add(Me.lblNumeroInstitucion)
    Me.gbDocumentoInstitucion.Controls.Add(Me.txtNumeroInstitucion)
    Me.gbDocumentoInstitucion.Location = New System.Drawing.Point(6, 6)
    Me.gbDocumentoInstitucion.Name = "gbDocumentoInstitucion"
    Me.gbDocumentoInstitucion.Size = New System.Drawing.Size(824, 124)
    Me.gbDocumentoInstitucion.TabIndex = 4
    Me.gbDocumentoInstitucion.TabStop = False
    Me.gbDocumentoInstitucion.Text = "Documento"
    '
    'dtpFechaInstitucion
    '
    Me.dtpFechaInstitucion.CustomFormat = "dd/MM/yyyy hh:mm tt"
    Me.dtpFechaInstitucion.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtpFechaInstitucion.Location = New System.Drawing.Point(98, 85)
    Me.dtpFechaInstitucion.Name = "dtpFechaInstitucion"
    Me.dtpFechaInstitucion.Size = New System.Drawing.Size(166, 20)
    Me.dtpFechaInstitucion.TabIndex = 7
    '
    'lblFechaInstitucion
    '
    Me.lblFechaInstitucion.AutoSize = True
    Me.lblFechaInstitucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFechaInstitucion.Location = New System.Drawing.Point(9, 89)
    Me.lblFechaInstitucion.Name = "lblFechaInstitucion"
    Me.lblFechaInstitucion.Size = New System.Drawing.Size(46, 16)
    Me.lblFechaInstitucion.TabIndex = 6
    Me.lblFechaInstitucion.Text = "&Fecha"
    '
    'cboTipoDocInstitucion
    '
    Me.cboTipoDocInstitucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoDocInstitucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboTipoDocInstitucion.FormattingEnabled = True
    Me.cboTipoDocInstitucion.Items.AddRange(New Object() {"RECIBO DE PAGO", "BOLETA DE VENTA", "FACTURA"})
    Me.cboTipoDocInstitucion.Location = New System.Drawing.Point(98, 37)
    Me.cboTipoDocInstitucion.Name = "cboTipoDocInstitucion"
    Me.cboTipoDocInstitucion.Size = New System.Drawing.Size(166, 24)
    Me.cboTipoDocInstitucion.TabIndex = 1
    '
    'lblTipoDocInstitucion
    '
    Me.lblTipoDocInstitucion.AutoSize = True
    Me.lblTipoDocInstitucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTipoDocInstitucion.Location = New System.Drawing.Point(9, 45)
    Me.lblTipoDocInstitucion.Name = "lblTipoDocInstitucion"
    Me.lblTipoDocInstitucion.Size = New System.Drawing.Size(86, 16)
    Me.lblTipoDocInstitucion.TabIndex = 0
    Me.lblTipoDocInstitucion.Text = "Tip&o de Doc."
    '
    'lblNumeroInstitucion
    '
    Me.lblNumeroInstitucion.AutoSize = True
    Me.lblNumeroInstitucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNumeroInstitucion.Location = New System.Drawing.Point(320, 45)
    Me.lblNumeroInstitucion.Name = "lblNumeroInstitucion"
    Me.lblNumeroInstitucion.Size = New System.Drawing.Size(40, 16)
    Me.lblNumeroInstitucion.TabIndex = 2
    Me.lblNumeroInstitucion.Text = "Ser&ie"
    '
    'txtNumeroInstitucion
    '
    Me.txtNumeroInstitucion.BackColor = System.Drawing.SystemColors.Window
    Me.txtNumeroInstitucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNumeroInstitucion.Location = New System.Drawing.Point(442, 39)
    Me.txtNumeroInstitucion.Name = "txtNumeroInstitucion"
    Me.txtNumeroInstitucion.Size = New System.Drawing.Size(91, 22)
    Me.txtNumeroInstitucion.TabIndex = 5
    Me.txtNumeroInstitucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'cboCuenta
    '
    Me.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCuenta.FormattingEnabled = True
    Me.cboCuenta.Location = New System.Drawing.Point(388, 29)
    Me.cboCuenta.Name = "cboCuenta"
    Me.cboCuenta.Size = New System.Drawing.Size(224, 21)
    Me.cboCuenta.TabIndex = 3
    '
    'lblCuenta
    '
    Me.lblCuenta.AutoSize = True
    Me.lblCuenta.Location = New System.Drawing.Point(342, 35)
    Me.lblCuenta.Name = "lblCuenta"
    Me.lblCuenta.Size = New System.Drawing.Size(41, 13)
    Me.lblCuenta.TabIndex = 2
    Me.lblCuenta.Text = "C&uenta"
    '
    'tbcImportacion
    '
    Me.tbcImportacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.tbcImportacion.Controls.Add(Me.tbpInstitucion)
    Me.tbcImportacion.Controls.Add(Me.tbpCopafa)
    Me.tbcImportacion.Location = New System.Drawing.Point(22, 65)
    Me.tbcImportacion.Name = "tbcImportacion"
    Me.tbcImportacion.SelectedIndex = 0
    Me.tbcImportacion.Size = New System.Drawing.Size(844, 551)
    Me.tbcImportacion.TabIndex = 5
    '
    'tbpInstitucion
    '
    Me.tbpInstitucion.Controls.Add(Me.gbDocumentoInstitucion)
    Me.tbpInstitucion.Controls.Add(Me.gbDocumentosInstitucion)
    Me.tbpInstitucion.Location = New System.Drawing.Point(4, 22)
    Me.tbpInstitucion.Name = "tbpInstitucion"
    Me.tbpInstitucion.Padding = New System.Windows.Forms.Padding(3)
    Me.tbpInstitucion.Size = New System.Drawing.Size(836, 525)
    Me.tbpInstitucion.TabIndex = 0
    Me.tbpInstitucion.Text = "Institución"
    Me.tbpInstitucion.UseVisualStyleBackColor = True
    '
    'tbpCopafa
    '
    Me.tbpCopafa.Controls.Add(Me.gbTipoDocCOPAFA)
    Me.tbpCopafa.Controls.Add(Me.gbVouchersCOPAFA)
    Me.tbpCopafa.Location = New System.Drawing.Point(4, 22)
    Me.tbpCopafa.Name = "tbpCopafa"
    Me.tbpCopafa.Padding = New System.Windows.Forms.Padding(3)
    Me.tbpCopafa.Size = New System.Drawing.Size(836, 525)
    Me.tbpCopafa.TabIndex = 1
    Me.tbpCopafa.Text = "COPAFA"
    Me.tbpCopafa.UseVisualStyleBackColor = True
    '
    'gbTipoDocCOPAFA
    '
    Me.gbTipoDocCOPAFA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbTipoDocCOPAFA.Controls.Add(Me.dtpFechaCOPAFA)
    Me.gbTipoDocCOPAFA.Controls.Add(Me.lblFechaCOPAFA)
    Me.gbTipoDocCOPAFA.Controls.Add(Me.cboTipoDocCOPAFA)
    Me.gbTipoDocCOPAFA.Controls.Add(Me.lblTipoDocCOPAFA)
    Me.gbTipoDocCOPAFA.Controls.Add(Me.txtSerieCOPAFA)
    Me.gbTipoDocCOPAFA.Controls.Add(Me.lblNumeroCOPAFA)
    Me.gbTipoDocCOPAFA.Controls.Add(Me.txtNumeroCOPAFA)
    Me.gbTipoDocCOPAFA.Location = New System.Drawing.Point(6, 6)
    Me.gbTipoDocCOPAFA.Name = "gbTipoDocCOPAFA"
    Me.gbTipoDocCOPAFA.Size = New System.Drawing.Size(824, 124)
    Me.gbTipoDocCOPAFA.TabIndex = 6
    Me.gbTipoDocCOPAFA.TabStop = False
    Me.gbTipoDocCOPAFA.Text = "Documento"
    '
    'dtpFechaCOPAFA
    '
    Me.dtpFechaCOPAFA.CustomFormat = "dd/MM/yyyy hh:mm tt"
    Me.dtpFechaCOPAFA.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtpFechaCOPAFA.Location = New System.Drawing.Point(98, 85)
    Me.dtpFechaCOPAFA.Name = "dtpFechaCOPAFA"
    Me.dtpFechaCOPAFA.Size = New System.Drawing.Size(166, 20)
    Me.dtpFechaCOPAFA.TabIndex = 7
    '
    'lblFechaCOPAFA
    '
    Me.lblFechaCOPAFA.AutoSize = True
    Me.lblFechaCOPAFA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFechaCOPAFA.Location = New System.Drawing.Point(9, 89)
    Me.lblFechaCOPAFA.Name = "lblFechaCOPAFA"
    Me.lblFechaCOPAFA.Size = New System.Drawing.Size(46, 16)
    Me.lblFechaCOPAFA.TabIndex = 6
    Me.lblFechaCOPAFA.Text = "&Fecha"
    '
    'cboTipoDocCOPAFA
    '
    Me.cboTipoDocCOPAFA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoDocCOPAFA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboTipoDocCOPAFA.FormattingEnabled = True
    Me.cboTipoDocCOPAFA.Items.AddRange(New Object() {"RECIBO DE PAGO", "BOLETA DE VENTA", "FACTURA"})
    Me.cboTipoDocCOPAFA.Location = New System.Drawing.Point(98, 37)
    Me.cboTipoDocCOPAFA.Name = "cboTipoDocCOPAFA"
    Me.cboTipoDocCOPAFA.Size = New System.Drawing.Size(166, 24)
    Me.cboTipoDocCOPAFA.TabIndex = 1
    '
    'lblTipoDocCOPAFA
    '
    Me.lblTipoDocCOPAFA.AutoSize = True
    Me.lblTipoDocCOPAFA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTipoDocCOPAFA.Location = New System.Drawing.Point(9, 45)
    Me.lblTipoDocCOPAFA.Name = "lblTipoDocCOPAFA"
    Me.lblTipoDocCOPAFA.Size = New System.Drawing.Size(86, 16)
    Me.lblTipoDocCOPAFA.TabIndex = 0
    Me.lblTipoDocCOPAFA.Text = "Tip&o de Doc."
    '
    'txtSerieCOPAFA
    '
    Me.txtSerieCOPAFA.BackColor = System.Drawing.SystemColors.Window
    Me.txtSerieCOPAFA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSerieCOPAFA.Location = New System.Drawing.Point(366, 39)
    Me.txtSerieCOPAFA.Name = "txtSerieCOPAFA"
    Me.txtSerieCOPAFA.Size = New System.Drawing.Size(70, 22)
    Me.txtSerieCOPAFA.TabIndex = 3
    Me.txtSerieCOPAFA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'lblNumeroCOPAFA
    '
    Me.lblNumeroCOPAFA.AutoSize = True
    Me.lblNumeroCOPAFA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNumeroCOPAFA.Location = New System.Drawing.Point(320, 45)
    Me.lblNumeroCOPAFA.Name = "lblNumeroCOPAFA"
    Me.lblNumeroCOPAFA.Size = New System.Drawing.Size(40, 16)
    Me.lblNumeroCOPAFA.TabIndex = 2
    Me.lblNumeroCOPAFA.Text = "Ser&ie"
    '
    'txtNumeroCOPAFA
    '
    Me.txtNumeroCOPAFA.BackColor = System.Drawing.SystemColors.Window
    Me.txtNumeroCOPAFA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNumeroCOPAFA.Location = New System.Drawing.Point(442, 39)
    Me.txtNumeroCOPAFA.Name = "txtNumeroCOPAFA"
    Me.txtNumeroCOPAFA.Size = New System.Drawing.Size(91, 22)
    Me.txtNumeroCOPAFA.TabIndex = 5
    Me.txtNumeroCOPAFA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'gbVouchersCOPAFA
    '
    Me.gbVouchersCOPAFA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbVouchersCOPAFA.Controls.Add(Me.btnRegistrarCOPAFA)
    Me.gbVouchersCOPAFA.Controls.Add(Me.btnVolverGenerarCOPAFA)
    Me.gbVouchersCOPAFA.Controls.Add(Me.chkSeleccionarTodosCOPAFA)
    Me.gbVouchersCOPAFA.Controls.Add(Me.dgvVouchersCOPAFA)
    Me.gbVouchersCOPAFA.Location = New System.Drawing.Point(6, 136)
    Me.gbVouchersCOPAFA.Name = "gbVouchersCOPAFA"
    Me.gbVouchersCOPAFA.Size = New System.Drawing.Size(824, 383)
    Me.gbVouchersCOPAFA.TabIndex = 7
    Me.gbVouchersCOPAFA.TabStop = False
    Me.gbVouchersCOPAFA.Text = "Voucher de Pagos"
    '
    'btnRegistrarCOPAFA
    '
    Me.btnRegistrarCOPAFA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnRegistrarCOPAFA.BackColor = System.Drawing.Color.White
    Me.btnRegistrarCOPAFA.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrarCOPAFA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrarCOPAFA.Location = New System.Drawing.Point(696, 325)
    Me.btnRegistrarCOPAFA.Name = "btnRegistrarCOPAFA"
    Me.btnRegistrarCOPAFA.Size = New System.Drawing.Size(110, 52)
    Me.btnRegistrarCOPAFA.TabIndex = 7
    Me.btnRegistrarCOPAFA.Text = "&Registrar"
    Me.btnRegistrarCOPAFA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrarCOPAFA.UseVisualStyleBackColor = False
    '
    'btnVolverGenerarCOPAFA
    '
    Me.btnVolverGenerarCOPAFA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnVolverGenerarCOPAFA.Location = New System.Drawing.Point(163, 347)
    Me.btnVolverGenerarCOPAFA.Name = "btnVolverGenerarCOPAFA"
    Me.btnVolverGenerarCOPAFA.Size = New System.Drawing.Size(139, 30)
    Me.btnVolverGenerarCOPAFA.TabIndex = 6
    Me.btnVolverGenerarCOPAFA.Text = "Reinici&ar numeración"
    Me.btnVolverGenerarCOPAFA.UseVisualStyleBackColor = True
    '
    'chkSeleccionarTodosCOPAFA
    '
    Me.chkSeleccionarTodosCOPAFA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.chkSeleccionarTodosCOPAFA.AutoSize = True
    Me.chkSeleccionarTodosCOPAFA.Checked = True
    Me.chkSeleccionarTodosCOPAFA.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkSeleccionarTodosCOPAFA.Location = New System.Drawing.Point(14, 360)
    Me.chkSeleccionarTodosCOPAFA.Name = "chkSeleccionarTodosCOPAFA"
    Me.chkSeleccionarTodosCOPAFA.Size = New System.Drawing.Size(111, 17)
    Me.chkSeleccionarTodosCOPAFA.TabIndex = 1
    Me.chkSeleccionarTodosCOPAFA.Text = "Seleccionar &todos"
    Me.chkSeleccionarTodosCOPAFA.UseVisualStyleBackColor = True
    '
    'dgvVouchersCOPAFA
    '
    Me.dgvVouchersCOPAFA.AllowUserToAddRows = False
    Me.dgvVouchersCOPAFA.AllowUserToDeleteRows = False
    Me.dgvVouchersCOPAFA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvVouchersCOPAFA.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
    Me.dgvVouchersCOPAFA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvVouchersCOPAFA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewButtonColumn1})
    DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgvVouchersCOPAFA.DefaultCellStyle = DataGridViewCellStyle29
    Me.dgvVouchersCOPAFA.Location = New System.Drawing.Point(12, 19)
    Me.dgvVouchersCOPAFA.MultiSelect = False
    Me.dgvVouchersCOPAFA.Name = "dgvVouchersCOPAFA"
    DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvVouchersCOPAFA.RowHeadersDefaultCellStyle = DataGridViewCellStyle30
    Me.dgvVouchersCOPAFA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvVouchersCOPAFA.Size = New System.Drawing.Size(794, 299)
    Me.dgvVouchersCOPAFA.TabIndex = 0
    '
    'DataGridViewCheckBoxColumn1
    '
    Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Imprimir"
    Me.DataGridViewCheckBoxColumn1.HeaderText = "Imprimir"
    Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
    Me.DataGridViewCheckBoxColumn1.Width = 50
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.DataPropertyName = "NombrePersona"
    Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.Width = 200
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.DataPropertyName = "NumeroRecibo"
    Me.DataGridViewTextBoxColumn2.HeaderText = "Recibo"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    Me.DataGridViewTextBoxColumn2.Width = 120
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.DataPropertyName = "NumeroVoucher"
    Me.DataGridViewTextBoxColumn3.HeaderText = "Voucher"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.DataPropertyName = "FechaVoucher"
    DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle27.Format = "g"
    DataGridViewCellStyle27.NullValue = Nothing
    Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle27
    Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha de pago"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    Me.DataGridViewTextBoxColumn4.Width = 120
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.DataPropertyName = "Total"
    DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle28.Format = "N2"
    DataGridViewCellStyle28.NullValue = Nothing
    Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle28
    Me.DataGridViewTextBoxColumn5.HeaderText = "Total"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    '
    'DataGridViewButtonColumn1
    '
    Me.DataGridViewButtonColumn1.HeaderText = "Canjear"
    Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
    Me.DataGridViewButtonColumn1.ReadOnly = True
    Me.DataGridViewButtonColumn1.Text = "..."
    Me.DataGridViewButtonColumn1.UseColumnTextForButtonValue = True
    Me.DataGridViewButtonColumn1.Visible = False
    Me.DataGridViewButtonColumn1.Width = 70
    '
    'frmImportarData
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCerrar
    Me.ClientSize = New System.Drawing.Size(994, 684)
    Me.Controls.Add(Me.tbcImportacion)
    Me.Controls.Add(Me.cboCuenta)
    Me.Controls.Add(Me.txtTotal)
    Me.Controls.Add(Me.txtVouchers)
    Me.Controls.Add(Me.lblCuenta)
    Me.Controls.Add(Me.lblTotal)
    Me.Controls.Add(Me.lblVouchersInstitucion)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.cboEntidadFinanciera)
    Me.Controls.Add(Me.lblEntidad)
    Me.Controls.Add(Me.btnImportar)
    Me.Name = "frmImportarData"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Importar pagos de cuenta recaudadora"
    CType(Me.dgvVouchersInstitucion, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbDocumentosInstitucion.ResumeLayout(False)
    Me.gbDocumentosInstitucion.PerformLayout()
    Me.gbDocumentoInstitucion.ResumeLayout(False)
    Me.gbDocumentoInstitucion.PerformLayout()
    Me.tbcImportacion.ResumeLayout(False)
    Me.tbpInstitucion.ResumeLayout(False)
    Me.tbpCopafa.ResumeLayout(False)
    Me.gbTipoDocCOPAFA.ResumeLayout(False)
    Me.gbTipoDocCOPAFA.PerformLayout()
    Me.gbVouchersCOPAFA.ResumeLayout(False)
    Me.gbVouchersCOPAFA.PerformLayout()
    CType(Me.dgvVouchersCOPAFA, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnImportar As System.Windows.Forms.Button
  Friend WithEvents cboEntidadFinanciera As System.Windows.Forms.ComboBox
  Friend WithEvents lblEntidad As System.Windows.Forms.Label
  Friend WithEvents dgvVouchersInstitucion As System.Windows.Forms.DataGridView
  Friend WithEvents gbDocumentosInstitucion As System.Windows.Forms.GroupBox
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrarInstitucion As System.Windows.Forms.Button
  Friend WithEvents txtSerieInstitucion As System.Windows.Forms.TextBox
  Friend WithEvents gbDocumentoInstitucion As System.Windows.Forms.GroupBox
  Friend WithEvents cboTipoDocInstitucion As System.Windows.Forms.ComboBox
  Friend WithEvents lblTipoDocInstitucion As System.Windows.Forms.Label
  Friend WithEvents lblNumeroInstitucion As System.Windows.Forms.Label
  Friend WithEvents txtNumeroInstitucion As System.Windows.Forms.TextBox
  Friend WithEvents cboCuenta As System.Windows.Forms.ComboBox
  Friend WithEvents lblCuenta As System.Windows.Forms.Label
  Friend WithEvents dtpFechaInstitucion As System.Windows.Forms.DateTimePicker
  Friend WithEvents lblFechaInstitucion As System.Windows.Forms.Label
  Friend WithEvents txtTotal As System.Windows.Forms.TextBox
  Friend WithEvents txtVouchers As System.Windows.Forms.TextBox
  Friend WithEvents lblTotal As System.Windows.Forms.Label
  Friend WithEvents lblVouchersInstitucion As System.Windows.Forms.Label
  Friend WithEvents cdImprimir As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents colalumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdRecibo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colVoucher As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdFechaVoucher As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colTotal As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCanjear As System.Windows.Forms.DataGridViewButtonColumn
  Friend WithEvents chkSeleccionarTodosInstitucion As System.Windows.Forms.CheckBox
  Friend WithEvents btnVolverGenerarInstitucion As System.Windows.Forms.Button
  Friend WithEvents tbcImportacion As System.Windows.Forms.TabControl
  Friend WithEvents tbpInstitucion As System.Windows.Forms.TabPage
  Friend WithEvents tbpCopafa As System.Windows.Forms.TabPage
  Friend WithEvents gbTipoDocCOPAFA As System.Windows.Forms.GroupBox
  Friend WithEvents dtpFechaCOPAFA As System.Windows.Forms.DateTimePicker
  Friend WithEvents lblFechaCOPAFA As System.Windows.Forms.Label
  Friend WithEvents cboTipoDocCOPAFA As System.Windows.Forms.ComboBox
  Friend WithEvents lblTipoDocCOPAFA As System.Windows.Forms.Label
  Friend WithEvents txtSerieCOPAFA As System.Windows.Forms.TextBox
  Friend WithEvents lblNumeroCOPAFA As System.Windows.Forms.Label
  Friend WithEvents txtNumeroCOPAFA As System.Windows.Forms.TextBox
  Friend WithEvents gbVouchersCOPAFA As System.Windows.Forms.GroupBox
  Friend WithEvents btnVolverGenerarCOPAFA As System.Windows.Forms.Button
  Friend WithEvents chkSeleccionarTodosCOPAFA As System.Windows.Forms.CheckBox
  Friend WithEvents dgvVouchersCOPAFA As System.Windows.Forms.DataGridView
  Friend WithEvents btnRegistrarCOPAFA As System.Windows.Forms.Button
  Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewButtonColumn1 As System.Windows.Forms.DataGridViewButtonColumn
End Class
