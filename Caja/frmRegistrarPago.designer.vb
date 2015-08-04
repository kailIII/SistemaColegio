<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarPago
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
    Me.components = New System.ComponentModel.Container()
    Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.lblCodigo = New System.Windows.Forms.Label()
    Me.txtCodigo = New System.Windows.Forms.TextBox()
    Me.btnBuscar = New System.Windows.Forms.Button()
    Me.lblGradoSec = New System.Windows.Forms.Label()
    Me.lblNombre = New System.Windows.Forms.Label()
    Me.txtSeccion = New System.Windows.Forms.TextBox()
    Me.txtNombre = New System.Windows.Forms.TextBox()
    Me.dgvServicio = New System.Windows.Forms.DataGridView()
    Me.cdItem = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.cdDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdImporte = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.colDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.colSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
    Me.lblFecha = New System.Windows.Forms.Label()
    Me.txtNumero = New System.Windows.Forms.TextBox()
    Me.lblEntidad = New System.Windows.Forms.Label()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.cboTipoDoc = New System.Windows.Forms.ComboBox()
    Me.lblDocumento = New System.Windows.Forms.Label()
    Me.txtSerie = New System.Windows.Forms.TextBox()
    Me.lblSerie = New System.Windows.Forms.Label()
    Me.cboEntidad = New System.Windows.Forms.ComboBox()
    Me.gbServicio = New System.Windows.Forms.GroupBox()
    Me.txtObligacionTotal = New System.Windows.Forms.TextBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.txtDeudaTotal = New System.Windows.Forms.TextBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.txtMoraTotal = New System.Windows.Forms.TextBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.chkSeleccionarTodos = New System.Windows.Forms.CheckBox()
    Me.btnAgregar = New System.Windows.Forms.Button()
    Me.txtTotal = New System.Windows.Forms.TextBox()
    Me.lblTotal = New System.Windows.Forms.Label()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.btnRegistrar = New System.Windows.Forms.Button()
    Me.btnImprimir = New System.Windows.Forms.Button()
    Me.btNuevo = New System.Windows.Forms.Button()
    Me.btnEstadoCta = New System.Windows.Forms.Button()
    Me.cboFormaPago = New System.Windows.Forms.ComboBox()
    Me.lblFormaPago = New System.Windows.Forms.Label()
    Me.cboEntidadFinanciera = New System.Windows.Forms.ComboBox()
    Me.lblEntidadFinanciera = New System.Windows.Forms.Label()
    Me.gbDeposito = New System.Windows.Forms.GroupBox()
    Me.nudMontoVoucher = New System.Windows.Forms.NumericUpDown()
    Me.lblCuenta = New System.Windows.Forms.Label()
    Me.cboCuenta = New System.Windows.Forms.ComboBox()
    Me.lblMontoVoucher = New System.Windows.Forms.Label()
    Me.lblVoucher = New System.Windows.Forms.Label()
    Me.txtNumOperacion = New System.Windows.Forms.TextBox()
    Me.dtpFechaVoucher = New System.Windows.Forms.DateTimePicker()
    Me.lblFechaVoucher = New System.Windows.Forms.Label()
    Me.tmrTiempo = New System.Windows.Forms.Timer(Me.components)
    Me.GroupBox1.SuspendLayout()
    CType(Me.dgvServicio, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox2.SuspendLayout()
    Me.gbServicio.SuspendLayout()
    Me.gbDeposito.SuspendLayout()
    CType(Me.nudMontoVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'GroupBox1
    '
    Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBox1.Controls.Add(Me.lblCodigo)
    Me.GroupBox1.Controls.Add(Me.txtCodigo)
    Me.GroupBox1.Controls.Add(Me.btnBuscar)
    Me.GroupBox1.Controls.Add(Me.lblGradoSec)
    Me.GroupBox1.Controls.Add(Me.lblNombre)
    Me.GroupBox1.Controls.Add(Me.txtSeccion)
    Me.GroupBox1.Controls.Add(Me.txtNombre)
    Me.GroupBox1.Location = New System.Drawing.Point(6, 98)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(795, 80)
    Me.GroupBox1.TabIndex = 1
    Me.GroupBox1.TabStop = False
    '
    'lblCodigo
    '
    Me.lblCodigo.AutoSize = True
    Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCodigo.Location = New System.Drawing.Point(413, 56)
    Me.lblCodigo.Name = "lblCodigo"
    Me.lblCodigo.Size = New System.Drawing.Size(52, 16)
    Me.lblCodigo.TabIndex = 5
    Me.lblCodigo.Text = "Có&digo"
    '
    'txtCodigo
    '
    Me.txtCodigo.BackColor = System.Drawing.SystemColors.Window
    Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCodigo.Location = New System.Drawing.Point(465, 50)
    Me.txtCodigo.Name = "txtCodigo"
    Me.txtCodigo.Size = New System.Drawing.Size(124, 22)
    Me.txtCodigo.TabIndex = 6
    '
    'btnBuscar
    '
    Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnBuscar.BackColor = System.Drawing.Color.White
    Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscar.Location = New System.Drawing.Point(693, 20)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(96, 52)
    Me.btnBuscar.TabIndex = 2
    Me.btnBuscar.Text = "&Buscar"
    Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscar.UseVisualStyleBackColor = False
    '
    'lblGradoSec
    '
    Me.lblGradoSec.AutoSize = True
    Me.lblGradoSec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblGradoSec.Location = New System.Drawing.Point(9, 56)
    Me.lblGradoSec.Name = "lblGradoSec"
    Me.lblGradoSec.Size = New System.Drawing.Size(57, 16)
    Me.lblGradoSec.TabIndex = 3
    Me.lblGradoSec.Text = "Sección"
    '
    'lblNombre
    '
    Me.lblNombre.AutoSize = True
    Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNombre.Location = New System.Drawing.Point(9, 27)
    Me.lblNombre.Name = "lblNombre"
    Me.lblNombre.Size = New System.Drawing.Size(53, 16)
    Me.lblNombre.TabIndex = 0
    Me.lblNombre.Text = "Alumno"
    '
    'txtSeccion
    '
    Me.txtSeccion.BackColor = System.Drawing.SystemColors.Window
    Me.txtSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSeccion.Location = New System.Drawing.Point(78, 50)
    Me.txtSeccion.Name = "txtSeccion"
    Me.txtSeccion.ReadOnly = True
    Me.txtSeccion.Size = New System.Drawing.Size(195, 22)
    Me.txtSeccion.TabIndex = 4
    '
    'txtNombre
    '
    Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
    Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNombre.Location = New System.Drawing.Point(78, 21)
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.ReadOnly = True
    Me.txtNombre.Size = New System.Drawing.Size(609, 22)
    Me.txtNombre.TabIndex = 1
    '
    'dgvServicio
    '
    Me.dgvServicio.AllowUserToAddRows = False
    Me.dgvServicio.AllowUserToDeleteRows = False
    Me.dgvServicio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvServicio.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
    Me.dgvServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdItem, Me.cdDetalle, Me.cdImporte, Me.colDescuento, Me.colSubtotal})
    DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgvServicio.DefaultCellStyle = DataGridViewCellStyle13
    Me.dgvServicio.Location = New System.Drawing.Point(12, 42)
    Me.dgvServicio.MultiSelect = False
    Me.dgvServicio.Name = "dgvServicio"
    DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvServicio.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
    Me.dgvServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.dgvServicio.Size = New System.Drawing.Size(675, 216)
    Me.dgvServicio.TabIndex = 1
    '
    'cdItem
    '
    Me.cdItem.DataPropertyName = "Seleccionado"
    Me.cdItem.HeaderText = "Item"
    Me.cdItem.Name = "cdItem"
    Me.cdItem.Width = 50
    '
    'cdDetalle
    '
    Me.cdDetalle.DataPropertyName = "Descripcion"
    DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cdDetalle.DefaultCellStyle = DataGridViewCellStyle9
    Me.cdDetalle.HeaderText = "Detalle"
    Me.cdDetalle.Name = "cdDetalle"
    Me.cdDetalle.Width = 280
    '
    'cdImporte
    '
    Me.cdImporte.DataPropertyName = "MontoInicial"
    DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle10.Format = "N2"
    DataGridViewCellStyle10.NullValue = Nothing
    Me.cdImporte.DefaultCellStyle = DataGridViewCellStyle10
    Me.cdImporte.HeaderText = "Importe"
    Me.cdImporte.Name = "cdImporte"
    Me.cdImporte.ReadOnly = True
    Me.cdImporte.Width = 80
    '
    'colDescuento
    '
    Me.colDescuento.DataPropertyName = "Descuento"
    DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle11.Format = "N2"
    DataGridViewCellStyle11.NullValue = Nothing
    Me.colDescuento.DefaultCellStyle = DataGridViewCellStyle11
    Me.colDescuento.HeaderText = "Descuento"
    Me.colDescuento.Name = "colDescuento"
    Me.colDescuento.ReadOnly = True
    Me.colDescuento.Width = 80
    '
    'colSubtotal
    '
    Me.colSubtotal.DataPropertyName = "Monto"
    DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle12.Format = "N2"
    DataGridViewCellStyle12.NullValue = Nothing
    Me.colSubtotal.DefaultCellStyle = DataGridViewCellStyle12
    Me.colSubtotal.HeaderText = "Importe a pagar"
    Me.colSubtotal.Name = "colSubtotal"
    '
    'dtpFecha
    '
    Me.dtpFecha.CustomFormat = "dd/MM/yyyy hh:mm tt"
    Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtpFecha.Location = New System.Drawing.Point(465, 18)
    Me.dtpFecha.Name = "dtpFecha"
    Me.dtpFecha.Size = New System.Drawing.Size(161, 22)
    Me.dtpFecha.TabIndex = 3
    '
    'lblFecha
    '
    Me.lblFecha.AutoSize = True
    Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFecha.Location = New System.Drawing.Point(413, 21)
    Me.lblFecha.Name = "lblFecha"
    Me.lblFecha.Size = New System.Drawing.Size(46, 16)
    Me.lblFecha.TabIndex = 2
    Me.lblFecha.Text = "&Fecha"
    '
    'txtNumero
    '
    Me.txtNumero.BackColor = System.Drawing.SystemColors.Window
    Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNumero.Location = New System.Drawing.Point(528, 45)
    Me.txtNumero.Name = "txtNumero"
    Me.txtNumero.Size = New System.Drawing.Size(98, 22)
    Me.txtNumero.TabIndex = 9
    Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'lblEntidad
    '
    Me.lblEntidad.AutoSize = True
    Me.lblEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblEntidad.Location = New System.Drawing.Point(24, 24)
    Me.lblEntidad.Name = "lblEntidad"
    Me.lblEntidad.Size = New System.Drawing.Size(54, 16)
    Me.lblEntidad.TabIndex = 0
    Me.lblEntidad.Text = "E&ntidad"
    '
    'GroupBox2
    '
    Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBox2.Controls.Add(Me.cboTipoDoc)
    Me.GroupBox2.Controls.Add(Me.lblDocumento)
    Me.GroupBox2.Controls.Add(Me.txtSerie)
    Me.GroupBox2.Controls.Add(Me.lblSerie)
    Me.GroupBox2.Controls.Add(Me.cboEntidad)
    Me.GroupBox2.Controls.Add(Me.lblFecha)
    Me.GroupBox2.Controls.Add(Me.lblEntidad)
    Me.GroupBox2.Controls.Add(Me.dtpFecha)
    Me.GroupBox2.Controls.Add(Me.txtNumero)
    Me.GroupBox2.Location = New System.Drawing.Point(6, 8)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(795, 84)
    Me.GroupBox2.TabIndex = 0
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Documento"
    '
    'cboTipoDoc
    '
    Me.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboTipoDoc.FormattingEnabled = True
    Me.cboTipoDoc.Items.AddRange(New Object() {"RECIBO DE PAGO", "BOLETA DE VENTA", "FACTURA"})
    Me.cboTipoDoc.Location = New System.Drawing.Point(107, 49)
    Me.cboTipoDoc.Name = "cboTipoDoc"
    Me.cboTipoDoc.Size = New System.Drawing.Size(166, 24)
    Me.cboTipoDoc.TabIndex = 5
    '
    'lblDocumento
    '
    Me.lblDocumento.AutoSize = True
    Me.lblDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDocumento.Location = New System.Drawing.Point(24, 57)
    Me.lblDocumento.Name = "lblDocumento"
    Me.lblDocumento.Size = New System.Drawing.Size(77, 16)
    Me.lblDocumento.TabIndex = 4
    Me.lblDocumento.Text = "D&ocumento"
    '
    'txtSerie
    '
    Me.txtSerie.BackColor = System.Drawing.SystemColors.Window
    Me.txtSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSerie.Location = New System.Drawing.Point(465, 45)
    Me.txtSerie.Name = "txtSerie"
    Me.txtSerie.Size = New System.Drawing.Size(57, 22)
    Me.txtSerie.TabIndex = 7
    Me.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'lblSerie
    '
    Me.lblSerie.AutoSize = True
    Me.lblSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSerie.Location = New System.Drawing.Point(413, 51)
    Me.lblSerie.Name = "lblSerie"
    Me.lblSerie.Size = New System.Drawing.Size(40, 16)
    Me.lblSerie.TabIndex = 6
    Me.lblSerie.Text = "Ser&ie"
    '
    'cboEntidad
    '
    Me.cboEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboEntidad.FormattingEnabled = True
    Me.cboEntidad.Items.AddRange(New Object() {"INST EDUCATIVA", "COPAFA"})
    Me.cboEntidad.Location = New System.Drawing.Point(107, 17)
    Me.cboEntidad.Name = "cboEntidad"
    Me.cboEntidad.Size = New System.Drawing.Size(166, 24)
    Me.cboEntidad.TabIndex = 1
    '
    'gbServicio
    '
    Me.gbServicio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbServicio.Controls.Add(Me.txtObligacionTotal)
    Me.gbServicio.Controls.Add(Me.Label6)
    Me.gbServicio.Controls.Add(Me.txtDeudaTotal)
    Me.gbServicio.Controls.Add(Me.Label5)
    Me.gbServicio.Controls.Add(Me.txtMoraTotal)
    Me.gbServicio.Controls.Add(Me.Label4)
    Me.gbServicio.Controls.Add(Me.chkSeleccionarTodos)
    Me.gbServicio.Controls.Add(Me.btnAgregar)
    Me.gbServicio.Controls.Add(Me.txtTotal)
    Me.gbServicio.Controls.Add(Me.lblTotal)
    Me.gbServicio.Controls.Add(Me.dgvServicio)
    Me.gbServicio.Location = New System.Drawing.Point(6, 184)
    Me.gbServicio.Name = "gbServicio"
    Me.gbServicio.Size = New System.Drawing.Size(795, 298)
    Me.gbServicio.TabIndex = 2
    Me.gbServicio.TabStop = False
    Me.gbServicio.Text = "Servicios"
    Me.gbServicio.UseCompatibleTextRendering = True
    '
    'txtObligacionTotal
    '
    Me.txtObligacionTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtObligacionTotal.BackColor = System.Drawing.SystemColors.Window
    Me.txtObligacionTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtObligacionTotal.Location = New System.Drawing.Point(324, 267)
    Me.txtObligacionTotal.Name = "txtObligacionTotal"
    Me.txtObligacionTotal.ReadOnly = True
    Me.txtObligacionTotal.Size = New System.Drawing.Size(72, 22)
    Me.txtObligacionTotal.TabIndex = 9
    Me.txtObligacionTotal.Text = "0.00"
    Me.txtObligacionTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label6
    '
    Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.Label6.AutoSize = True
    Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(211, 273)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(107, 16)
    Me.Label6.TabIndex = 8
    Me.Label6.Text = "Obligacion Total"
    '
    'txtDeudaTotal
    '
    Me.txtDeudaTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtDeudaTotal.BackColor = System.Drawing.SystemColors.Window
    Me.txtDeudaTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDeudaTotal.Location = New System.Drawing.Point(102, 267)
    Me.txtDeudaTotal.Name = "txtDeudaTotal"
    Me.txtDeudaTotal.ReadOnly = True
    Me.txtDeudaTotal.Size = New System.Drawing.Size(81, 22)
    Me.txtDeudaTotal.TabIndex = 7
    Me.txtDeudaTotal.Text = "0.00"
    Me.txtDeudaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label5
    '
    Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.Label5.AutoSize = True
    Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(9, 273)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(83, 16)
    Me.Label5.TabIndex = 6
    Me.Label5.Text = "Deuda Total"
    '
    'txtMoraTotal
    '
    Me.txtMoraTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtMoraTotal.BackColor = System.Drawing.SystemColors.Window
    Me.txtMoraTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMoraTotal.Location = New System.Drawing.Point(501, 267)
    Me.txtMoraTotal.Name = "txtMoraTotal"
    Me.txtMoraTotal.ReadOnly = True
    Me.txtMoraTotal.Size = New System.Drawing.Size(80, 22)
    Me.txtMoraTotal.TabIndex = 11
    Me.txtMoraTotal.Text = "0.00"
    Me.txtMoraTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label4
    '
    Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(422, 273)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(73, 16)
    Me.Label4.TabIndex = 10
    Me.Label4.Text = "Mora Total"
    '
    'chkSeleccionarTodos
    '
    Me.chkSeleccionarTodos.AutoSize = True
    Me.chkSeleccionarTodos.Location = New System.Drawing.Point(12, 19)
    Me.chkSeleccionarTodos.Name = "chkSeleccionarTodos"
    Me.chkSeleccionarTodos.Size = New System.Drawing.Size(106, 17)
    Me.chkSeleccionarTodos.TabIndex = 0
    Me.chkSeleccionarTodos.Text = "Seleccionar &todo"
    Me.chkSeleccionarTodos.UseVisualStyleBackColor = True
    '
    'btnAgregar
    '
    Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnAgregar.BackColor = System.Drawing.Color.White
    Me.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAgregar.Location = New System.Drawing.Point(693, 42)
    Me.btnAgregar.Name = "btnAgregar"
    Me.btnAgregar.Size = New System.Drawing.Size(96, 52)
    Me.btnAgregar.TabIndex = 2
    Me.btnAgregar.Text = "A&gregar"
    Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnAgregar.UseVisualStyleBackColor = False
    '
    'txtTotal
    '
    Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtTotal.BackColor = System.Drawing.SystemColors.Window
    Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTotal.Location = New System.Drawing.Point(682, 263)
    Me.txtTotal.Name = "txtTotal"
    Me.txtTotal.Size = New System.Drawing.Size(107, 26)
    Me.txtTotal.TabIndex = 5
    Me.txtTotal.Text = "0.00"
    Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'lblTotal
    '
    Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblTotal.AutoSize = True
    Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTotal.Location = New System.Drawing.Point(690, 242)
    Me.lblTotal.Name = "lblTotal"
    Me.lblTotal.Size = New System.Drawing.Size(103, 16)
    Me.lblTotal.TabIndex = 4
    Me.lblTotal.Text = "Total a Pagar"
    '
    'btnCancelar
    '
    Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(815, 540)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(113, 58)
    Me.btnCancelar.TabIndex = 10
    Me.btnCancelar.Text = "&Cancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(815, 72)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(113, 52)
    Me.btnRegistrar.TabIndex = 7
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'btnImprimir
    '
    Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnImprimir.BackColor = System.Drawing.Color.White
    Me.btnImprimir.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnImprimir.Location = New System.Drawing.Point(815, 130)
    Me.btnImprimir.Name = "btnImprimir"
    Me.btnImprimir.Size = New System.Drawing.Size(113, 52)
    Me.btnImprimir.TabIndex = 8
    Me.btnImprimir.Text = "&Vista Previa"
    Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnImprimir.UseVisualStyleBackColor = False
    Me.btnImprimir.Visible = False
    '
    'btNuevo
    '
    Me.btNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btNuevo.BackColor = System.Drawing.Color.White
    Me.btNuevo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btNuevo.Location = New System.Drawing.Point(815, 14)
    Me.btNuevo.Name = "btNuevo"
    Me.btNuevo.Size = New System.Drawing.Size(113, 52)
    Me.btNuevo.TabIndex = 6
    Me.btNuevo.Text = "N&uevo"
    Me.btNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btNuevo.UseVisualStyleBackColor = False
    '
    'btnEstadoCta
    '
    Me.btnEstadoCta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnEstadoCta.BackColor = System.Drawing.Color.White
    Me.btnEstadoCta.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEstadoCta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnEstadoCta.Location = New System.Drawing.Point(815, 188)
    Me.btnEstadoCta.Name = "btnEstadoCta"
    Me.btnEstadoCta.Size = New System.Drawing.Size(113, 52)
    Me.btnEstadoCta.TabIndex = 9
    Me.btnEstadoCta.Text = "&Estado de Cuenta"
    Me.btnEstadoCta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnEstadoCta.UseVisualStyleBackColor = False
    Me.btnEstadoCta.Visible = False
    '
    'cboFormaPago
    '
    Me.cboFormaPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboFormaPago.FormattingEnabled = True
    Me.cboFormaPago.Items.AddRange(New Object() {"CHEQUE", "EFECTIVO", "VOUCHER"})
    Me.cboFormaPago.Location = New System.Drawing.Point(122, 490)
    Me.cboFormaPago.Name = "cboFormaPago"
    Me.cboFormaPago.Size = New System.Drawing.Size(166, 24)
    Me.cboFormaPago.TabIndex = 4
    '
    'lblFormaPago
    '
    Me.lblFormaPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblFormaPago.AutoSize = True
    Me.lblFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFormaPago.Location = New System.Drawing.Point(15, 496)
    Me.lblFormaPago.Name = "lblFormaPago"
    Me.lblFormaPago.Size = New System.Drawing.Size(101, 16)
    Me.lblFormaPago.TabIndex = 3
    Me.lblFormaPago.Text = "For&ma de pago"
    '
    'cboEntidadFinanciera
    '
    Me.cboEntidadFinanciera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEntidadFinanciera.FormattingEnabled = True
    Me.cboEntidadFinanciera.Location = New System.Drawing.Point(102, 28)
    Me.cboEntidadFinanciera.Name = "cboEntidadFinanciera"
    Me.cboEntidadFinanciera.Size = New System.Drawing.Size(314, 21)
    Me.cboEntidadFinanciera.TabIndex = 1
    '
    'lblEntidadFinanciera
    '
    Me.lblEntidadFinanciera.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblEntidadFinanciera.AutoSize = True
    Me.lblEntidadFinanciera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblEntidadFinanciera.Location = New System.Drawing.Point(9, 33)
    Me.lblEntidadFinanciera.Name = "lblEntidadFinanciera"
    Me.lblEntidadFinanciera.Size = New System.Drawing.Size(87, 16)
    Me.lblEntidadFinanciera.TabIndex = 0
    Me.lblEntidadFinanciera.Text = "Ent. Bancaria"
    '
    'gbDeposito
    '
    Me.gbDeposito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.gbDeposito.Controls.Add(Me.nudMontoVoucher)
    Me.gbDeposito.Controls.Add(Me.lblCuenta)
    Me.gbDeposito.Controls.Add(Me.cboCuenta)
    Me.gbDeposito.Controls.Add(Me.lblMontoVoucher)
    Me.gbDeposito.Controls.Add(Me.lblVoucher)
    Me.gbDeposito.Controls.Add(Me.txtNumOperacion)
    Me.gbDeposito.Controls.Add(Me.cboEntidadFinanciera)
    Me.gbDeposito.Controls.Add(Me.lblEntidadFinanciera)
    Me.gbDeposito.Controls.Add(Me.dtpFechaVoucher)
    Me.gbDeposito.Controls.Add(Me.lblFechaVoucher)
    Me.gbDeposito.Enabled = False
    Me.gbDeposito.Location = New System.Drawing.Point(6, 496)
    Me.gbDeposito.Name = "gbDeposito"
    Me.gbDeposito.Size = New System.Drawing.Size(795, 103)
    Me.gbDeposito.TabIndex = 5
    Me.gbDeposito.TabStop = False
    '
    'nudMontoVoucher
    '
    Me.nudMontoVoucher.DecimalPlaces = 2
    Me.nudMontoVoucher.Location = New System.Drawing.Point(693, 70)
    Me.nudMontoVoucher.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
    Me.nudMontoVoucher.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.nudMontoVoucher.Name = "nudMontoVoucher"
    Me.nudMontoVoucher.Size = New System.Drawing.Size(92, 20)
    Me.nudMontoVoucher.TabIndex = 8
    Me.nudMontoVoucher.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.nudMontoVoucher.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'lblCuenta
    '
    Me.lblCuenta.AutoSize = True
    Me.lblCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCuenta.Location = New System.Drawing.Point(498, 33)
    Me.lblCuenta.Name = "lblCuenta"
    Me.lblCuenta.Size = New System.Drawing.Size(50, 16)
    Me.lblCuenta.TabIndex = 2
    Me.lblCuenta.Text = "C&uenta"
    '
    'cboCuenta
    '
    Me.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCuenta.FormattingEnabled = True
    Me.cboCuenta.Location = New System.Drawing.Point(561, 28)
    Me.cboCuenta.Name = "cboCuenta"
    Me.cboCuenta.Size = New System.Drawing.Size(224, 21)
    Me.cboCuenta.TabIndex = 3
    '
    'lblMontoVoucher
    '
    Me.lblMontoVoucher.AutoSize = True
    Me.lblMontoVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMontoVoucher.Location = New System.Drawing.Point(642, 75)
    Me.lblMontoVoucher.Name = "lblMontoVoucher"
    Me.lblMontoVoucher.Size = New System.Drawing.Size(45, 16)
    Me.lblMontoVoucher.TabIndex = 4
    Me.lblMontoVoucher.Text = "&Monto"
    '
    'lblVoucher
    '
    Me.lblVoucher.AutoSize = True
    Me.lblVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblVoucher.Location = New System.Drawing.Point(9, 74)
    Me.lblVoucher.Name = "lblVoucher"
    Me.lblVoucher.Size = New System.Drawing.Size(90, 16)
    Me.lblVoucher.TabIndex = 4
    Me.lblVoucher.Text = "Num. Operac."
    '
    'txtNumOperacion
    '
    Me.txtNumOperacion.BackColor = System.Drawing.SystemColors.Window
    Me.txtNumOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNumOperacion.Location = New System.Drawing.Point(102, 68)
    Me.txtNumOperacion.Name = "txtNumOperacion"
    Me.txtNumOperacion.Size = New System.Drawing.Size(243, 22)
    Me.txtNumOperacion.TabIndex = 5
    '
    'dtpFechaVoucher
    '
    Me.dtpFechaVoucher.CustomFormat = "dd/MM/yyyy hh:mm tt"
    Me.dtpFechaVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaVoucher.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaVoucher.Location = New System.Drawing.Point(416, 69)
    Me.dtpFechaVoucher.Name = "dtpFechaVoucher"
    Me.dtpFechaVoucher.Size = New System.Drawing.Size(100, 22)
    Me.dtpFechaVoucher.TabIndex = 7
    '
    'lblFechaVoucher
    '
    Me.lblFechaVoucher.AutoSize = True
    Me.lblFechaVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFechaVoucher.Location = New System.Drawing.Point(367, 74)
    Me.lblFechaVoucher.Name = "lblFechaVoucher"
    Me.lblFechaVoucher.Size = New System.Drawing.Size(46, 16)
    Me.lblFechaVoucher.TabIndex = 6
    Me.lblFechaVoucher.Text = "&Fecha"
    '
    'tmrTiempo
    '
    Me.tmrTiempo.Interval = 100000
    '
    'frmRegistrarPago
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.CancelButton = Me.btnCancelar
    Me.ClientSize = New System.Drawing.Size(942, 608)
    Me.Controls.Add(Me.lblFormaPago)
    Me.Controls.Add(Me.cboFormaPago)
    Me.Controls.Add(Me.gbDeposito)
    Me.Controls.Add(Me.btnEstadoCta)
    Me.Controls.Add(Me.btNuevo)
    Me.Controls.Add(Me.btnImprimir)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.gbServicio)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.GroupBox1)
    Me.Name = "frmRegistrarPago"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "REGISTRAR PAGO"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    CType(Me.dgvServicio, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.gbServicio.ResumeLayout(False)
    Me.gbServicio.PerformLayout()
    Me.gbDeposito.ResumeLayout(False)
    Me.gbDeposito.PerformLayout()
    CType(Me.nudMontoVoucher, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents lblGradoSec As System.Windows.Forms.Label
  Friend WithEvents lblNombre As System.Windows.Forms.Label
  Friend WithEvents txtSeccion As System.Windows.Forms.TextBox
  Friend WithEvents dgvServicio As System.Windows.Forms.DataGridView
  Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
  Friend WithEvents lblFecha As System.Windows.Forms.Label
  Friend WithEvents txtNumero As System.Windows.Forms.TextBox
  Friend WithEvents lblEntidad As System.Windows.Forms.Label
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents cboEntidad As System.Windows.Forms.ComboBox
  Friend WithEvents gbServicio As System.Windows.Forms.GroupBox
  Friend WithEvents txtTotal As System.Windows.Forms.TextBox
  Friend WithEvents lblTotal As System.Windows.Forms.Label
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnAgregar As System.Windows.Forms.Button
  Friend WithEvents btnImprimir As System.Windows.Forms.Button
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents txtSerie As System.Windows.Forms.TextBox
  Friend WithEvents lblSerie As System.Windows.Forms.Label
  Friend WithEvents cboTipoDoc As System.Windows.Forms.ComboBox
  Friend WithEvents lblDocumento As System.Windows.Forms.Label
  Friend WithEvents btNuevo As System.Windows.Forms.Button
  Friend WithEvents chkSeleccionarTodos As System.Windows.Forms.CheckBox
  Friend WithEvents txtDeudaTotal As System.Windows.Forms.TextBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txtMoraTotal As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtObligacionTotal As System.Windows.Forms.TextBox
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents btnEstadoCta As System.Windows.Forms.Button
  Friend WithEvents lblCodigo As System.Windows.Forms.Label
  Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
  Friend WithEvents cdItem As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents cdDetalle As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdImporte As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colDescuento As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cboFormaPago As System.Windows.Forms.ComboBox
  Friend WithEvents lblFormaPago As System.Windows.Forms.Label
  Friend WithEvents cboEntidadFinanciera As System.Windows.Forms.ComboBox
  Friend WithEvents lblEntidadFinanciera As System.Windows.Forms.Label
  Friend WithEvents gbDeposito As System.Windows.Forms.GroupBox
  Friend WithEvents lblVoucher As System.Windows.Forms.Label
  Friend WithEvents txtNumOperacion As System.Windows.Forms.TextBox
  Friend WithEvents dtpFechaVoucher As System.Windows.Forms.DateTimePicker
  Friend WithEvents lblFechaVoucher As System.Windows.Forms.Label
  Friend WithEvents cboCuenta As System.Windows.Forms.ComboBox
  Friend WithEvents lblCuenta As System.Windows.Forms.Label
  Friend WithEvents nudMontoVoucher As System.Windows.Forms.NumericUpDown
  Friend WithEvents lblMontoVoucher As System.Windows.Forms.Label
  Friend WithEvents tmrTiempo As System.Windows.Forms.Timer
End Class
