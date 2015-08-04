<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompra
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
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.tbControl = New System.Windows.Forms.TabControl()
    Me.tpRegistroCompra = New System.Windows.Forms.TabPage()
    Me.nudIGV = New System.Windows.Forms.NumericUpDown()
    Me.lblIgv = New System.Windows.Forms.Label()
    Me.txtMontoTotal = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.btnRegistrar = New System.Windows.Forms.Button()
    Me.gbLista = New System.Windows.Forms.GroupBox()
    Me.txtDescripcion = New System.Windows.Forms.TextBox()
    Me.lblDescripcion = New System.Windows.Forms.Label()
    Me.btnEliminar = New System.Windows.Forms.Button()
    Me.btnModificar = New System.Windows.Forms.Button()
    Me.dgvDetalleCompra = New System.Windows.Forms.DataGridView()
    Me.cdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btnAgregar = New System.Windows.Forms.Button()
    Me.nudMonto = New System.Windows.Forms.NumericUpDown()
    Me.lblMonto = New System.Windows.Forms.Label()
    Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.cboConceptoCompra = New System.Windows.Forms.ComboBox()
    Me.lblProductoServicio = New System.Windows.Forms.Label()
    Me.gbRegistro = New System.Windows.Forms.GroupBox()
    Me.txtSerie = New System.Windows.Forms.TextBox()
    Me.lblSerie = New System.Windows.Forms.Label()
    Me.btnBuscar = New System.Windows.Forms.Button()
    Me.txtPersonal = New System.Windows.Forms.TextBox()
    Me.lblPersonal = New System.Windows.Forms.Label()
    Me.txtNumero = New System.Windows.Forms.TextBox()
    Me.lblNumero = New System.Windows.Forms.Label()
    Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
    Me.lblTipo = New System.Windows.Forms.Label()
    Me.tpCompras = New System.Windows.Forms.TabPage()
    Me.gbListado = New System.Windows.Forms.GroupBox()
    Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
    Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
    Me.lblFechaFin = New System.Windows.Forms.Label()
    Me.lblFechaInicio = New System.Windows.Forms.Label()
    Me.btnNuevoCompra = New System.Windows.Forms.Button()
    Me.btnListarCompra = New System.Windows.Forms.Button()
    Me.dgvCompra = New System.Windows.Forms.DataGridView()
    Me.cdFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdNombreNivel = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdMontoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdNumeroDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btnAnularCompra = New System.Windows.Forms.Button()
    Me.btnEditar = New System.Windows.Forms.Button()
    Me.btnCerrarCompra = New System.Windows.Forms.Button()
    Me.tbControl.SuspendLayout()
    Me.tpRegistroCompra.SuspendLayout()
    CType(Me.nudIGV, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbLista.SuspendLayout()
    CType(Me.dgvDetalleCompra, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nudMonto, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbRegistro.SuspendLayout()
    Me.tpCompras.SuspendLayout()
    Me.gbListado.SuspendLayout()
    CType(Me.dgvCompra, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'tbControl
    '
    Me.tbControl.Controls.Add(Me.tpRegistroCompra)
    Me.tbControl.Controls.Add(Me.tpCompras)
    Me.tbControl.Location = New System.Drawing.Point(0, -1)
    Me.tbControl.Name = "tbControl"
    Me.tbControl.SelectedIndex = 0
    Me.tbControl.Size = New System.Drawing.Size(832, 608)
    Me.tbControl.TabIndex = 0
    '
    'tpRegistroCompra
    '
    Me.tpRegistroCompra.Controls.Add(Me.nudIGV)
    Me.tpRegistroCompra.Controls.Add(Me.lblIgv)
    Me.tpRegistroCompra.Controls.Add(Me.txtMontoTotal)
    Me.tpRegistroCompra.Controls.Add(Me.Label1)
    Me.tpRegistroCompra.Controls.Add(Me.btnCerrar)
    Me.tpRegistroCompra.Controls.Add(Me.btnCancelar)
    Me.tpRegistroCompra.Controls.Add(Me.btnRegistrar)
    Me.tpRegistroCompra.Controls.Add(Me.gbLista)
    Me.tpRegistroCompra.Controls.Add(Me.gbRegistro)
    Me.tpRegistroCompra.Location = New System.Drawing.Point(4, 22)
    Me.tpRegistroCompra.Name = "tpRegistroCompra"
    Me.tpRegistroCompra.Padding = New System.Windows.Forms.Padding(3)
    Me.tpRegistroCompra.Size = New System.Drawing.Size(824, 582)
    Me.tpRegistroCompra.TabIndex = 0
    Me.tpRegistroCompra.Text = "Registro de Compras"
    Me.tpRegistroCompra.UseVisualStyleBackColor = True
    '
    'nudIGV
    '
    Me.nudIGV.DecimalPlaces = 2
    Me.nudIGV.Location = New System.Drawing.Point(261, 456)
    Me.nudIGV.Name = "nudIGV"
    Me.nudIGV.Size = New System.Drawing.Size(71, 20)
    Me.nudIGV.TabIndex = 7
    '
    'lblIgv
    '
    Me.lblIgv.AutoSize = True
    Me.lblIgv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblIgv.Location = New System.Drawing.Point(229, 456)
    Me.lblIgv.Name = "lblIgv"
    Me.lblIgv.Size = New System.Drawing.Size(26, 15)
    Me.lblIgv.TabIndex = 6
    Me.lblIgv.Text = "IGV"
    '
    'txtMontoTotal
    '
    Me.txtMontoTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
    Me.txtMontoTotal.Location = New System.Drawing.Point(117, 456)
    Me.txtMontoTotal.Name = "txtMontoTotal"
    Me.txtMontoTotal.ReadOnly = True
    Me.txtMontoTotal.Size = New System.Drawing.Size(73, 20)
    Me.txtMontoTotal.TabIndex = 9
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(32, 456)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(72, 15)
    Me.Label1.TabIndex = 14
    Me.Label1.Text = "Monto Total"
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(693, 514)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 4
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(169, 514)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
    Me.btnCancelar.TabIndex = 3
    Me.btnCancelar.Text = "&Cancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(35, 514)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
    Me.btnRegistrar.TabIndex = 2
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'gbLista
    '
    Me.gbLista.Controls.Add(Me.txtDescripcion)
    Me.gbLista.Controls.Add(Me.lblDescripcion)
    Me.gbLista.Controls.Add(Me.btnEliminar)
    Me.gbLista.Controls.Add(Me.btnModificar)
    Me.gbLista.Controls.Add(Me.dgvDetalleCompra)
    Me.gbLista.Controls.Add(Me.btnAgregar)
    Me.gbLista.Controls.Add(Me.nudMonto)
    Me.gbLista.Controls.Add(Me.lblMonto)
    Me.gbLista.Controls.Add(Me.nudCantidad)
    Me.gbLista.Controls.Add(Me.Label2)
    Me.gbLista.Controls.Add(Me.cboConceptoCompra)
    Me.gbLista.Controls.Add(Me.lblProductoServicio)
    Me.gbLista.Location = New System.Drawing.Point(35, 133)
    Me.gbLista.Name = "gbLista"
    Me.gbLista.Size = New System.Drawing.Size(677, 306)
    Me.gbLista.TabIndex = 1
    Me.gbLista.TabStop = False
    '
    'txtDescripcion
    '
    Me.txtDescripcion.Location = New System.Drawing.Point(89, 116)
    Me.txtDescripcion.Multiline = True
    Me.txtDescripcion.Name = "txtDescripcion"
    Me.txtDescripcion.Size = New System.Drawing.Size(315, 36)
    Me.txtDescripcion.TabIndex = 10
    Me.txtDescripcion.Visible = False
    '
    'lblDescripcion
    '
    Me.lblDescripcion.AutoSize = True
    Me.lblDescripcion.Enabled = False
    Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDescripcion.Location = New System.Drawing.Point(11, 116)
    Me.lblDescripcion.Name = "lblDescripcion"
    Me.lblDescripcion.Size = New System.Drawing.Size(72, 15)
    Me.lblDescripcion.TabIndex = 9
    Me.lblDescripcion.Text = "Descripción"
    Me.lblDescripcion.Visible = False
    '
    'btnEliminar
    '
    Me.btnEliminar.BackColor = System.Drawing.Color.White
    Me.btnEliminar.Enabled = False
    Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnEliminar.Location = New System.Drawing.Point(559, 206)
    Me.btnEliminar.Name = "btnEliminar"
    Me.btnEliminar.Size = New System.Drawing.Size(91, 23)
    Me.btnEliminar.TabIndex = 13
    Me.btnEliminar.Text = "Eliminar"
    Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnEliminar.UseVisualStyleBackColor = False
    '
    'btnModificar
    '
    Me.btnModificar.BackColor = System.Drawing.Color.White
    Me.btnModificar.Enabled = False
    Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnModificar.Location = New System.Drawing.Point(559, 167)
    Me.btnModificar.Name = "btnModificar"
    Me.btnModificar.Size = New System.Drawing.Size(91, 23)
    Me.btnModificar.TabIndex = 12
    Me.btnModificar.Text = "Modificar"
    Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnModificar.UseVisualStyleBackColor = False
    '
    'dgvDetalleCompra
    '
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvDetalleCompra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvDetalleCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdProducto, Me.cdCantidad, Me.cdMonto})
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgvDetalleCompra.DefaultCellStyle = DataGridViewCellStyle2
    Me.dgvDetalleCompra.Location = New System.Drawing.Point(14, 166)
    Me.dgvDetalleCompra.Name = "dgvDetalleCompra"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvDetalleCompra.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.dgvDetalleCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvDetalleCompra.Size = New System.Drawing.Size(522, 116)
    Me.dgvDetalleCompra.TabIndex = 11
    '
    'cdProducto
    '
    Me.cdProducto.DataPropertyName = "nombreProducto"
    Me.cdProducto.HeaderText = "Producto/Servicio"
    Me.cdProducto.Name = "cdProducto"
    '
    'cdCantidad
    '
    Me.cdCantidad.DataPropertyName = "cantidad"
    Me.cdCantidad.HeaderText = "Cantidad"
    Me.cdCantidad.Name = "cdCantidad"
    '
    'cdMonto
    '
    Me.cdMonto.DataPropertyName = "precioTotal"
    Me.cdMonto.HeaderText = "Monto Total"
    Me.cdMonto.Name = "cdMonto"
    '
    'btnAgregar
    '
    Me.btnAgregar.BackColor = System.Drawing.Color.White
    Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAgregar.Location = New System.Drawing.Point(488, 72)
    Me.btnAgregar.Name = "btnAgregar"
    Me.btnAgregar.Size = New System.Drawing.Size(85, 23)
    Me.btnAgregar.TabIndex = 8
    Me.btnAgregar.Text = "Agregar"
    Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnAgregar.UseVisualStyleBackColor = False
    '
    'nudMonto
    '
    Me.nudMonto.DecimalPlaces = 2
    Me.nudMonto.Location = New System.Drawing.Point(225, 72)
    Me.nudMonto.Name = "nudMonto"
    Me.nudMonto.Size = New System.Drawing.Size(72, 20)
    Me.nudMonto.TabIndex = 5
    '
    'lblMonto
    '
    Me.lblMonto.AutoSize = True
    Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMonto.Location = New System.Drawing.Point(162, 72)
    Me.lblMonto.Name = "lblMonto"
    Me.lblMonto.Size = New System.Drawing.Size(42, 15)
    Me.lblMonto.TabIndex = 4
    Me.lblMonto.Text = "Monto"
    '
    'nudCantidad
    '
    Me.nudCantidad.Location = New System.Drawing.Point(73, 72)
    Me.nudCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.nudCantidad.Name = "nudCantidad"
    Me.nudCantidad.Size = New System.Drawing.Size(48, 20)
    Me.nudCantidad.TabIndex = 3
    Me.nudCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(11, 72)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(56, 15)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Cantidad"
    '
    'cboConceptoCompra
    '
    Me.cboConceptoCompra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboConceptoCompra.FormattingEnabled = True
    Me.cboConceptoCompra.Location = New System.Drawing.Point(134, 26)
    Me.cboConceptoCompra.Name = "cboConceptoCompra"
    Me.cboConceptoCompra.Size = New System.Drawing.Size(301, 21)
    Me.cboConceptoCompra.TabIndex = 1
    '
    'lblProductoServicio
    '
    Me.lblProductoServicio.AutoSize = True
    Me.lblProductoServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblProductoServicio.Location = New System.Drawing.Point(11, 27)
    Me.lblProductoServicio.Name = "lblProductoServicio"
    Me.lblProductoServicio.Size = New System.Drawing.Size(102, 15)
    Me.lblProductoServicio.TabIndex = 0
    Me.lblProductoServicio.Text = "Producto/Servicio"
    '
    'gbRegistro
    '
    Me.gbRegistro.Controls.Add(Me.txtSerie)
    Me.gbRegistro.Controls.Add(Me.lblSerie)
    Me.gbRegistro.Controls.Add(Me.btnBuscar)
    Me.gbRegistro.Controls.Add(Me.txtPersonal)
    Me.gbRegistro.Controls.Add(Me.lblPersonal)
    Me.gbRegistro.Controls.Add(Me.txtNumero)
    Me.gbRegistro.Controls.Add(Me.lblNumero)
    Me.gbRegistro.Controls.Add(Me.cboTipoDocumento)
    Me.gbRegistro.Controls.Add(Me.lblTipo)
    Me.gbRegistro.Location = New System.Drawing.Point(35, 15)
    Me.gbRegistro.Name = "gbRegistro"
    Me.gbRegistro.Size = New System.Drawing.Size(625, 96)
    Me.gbRegistro.TabIndex = 0
    Me.gbRegistro.TabStop = False
    '
    'txtSerie
    '
    Me.txtSerie.Location = New System.Drawing.Point(372, 25)
    Me.txtSerie.MaxLength = 999
    Me.txtSerie.Name = "txtSerie"
    Me.txtSerie.Size = New System.Drawing.Size(49, 20)
    Me.txtSerie.TabIndex = 3
    '
    'lblSerie
    '
    Me.lblSerie.AutoSize = True
    Me.lblSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSerie.Location = New System.Drawing.Point(320, 26)
    Me.lblSerie.Name = "lblSerie"
    Me.lblSerie.Size = New System.Drawing.Size(36, 15)
    Me.lblSerie.TabIndex = 2
    Me.lblSerie.Text = "Serie"
    '
    'btnBuscar
    '
    Me.btnBuscar.BackColor = System.Drawing.Color.White
    Me.btnBuscar.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscar.Location = New System.Drawing.Point(412, 59)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(78, 31)
    Me.btnBuscar.TabIndex = 8
    Me.btnBuscar.Text = "&Buscar"
    Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscar.UseVisualStyleBackColor = False
    '
    'txtPersonal
    '
    Me.txtPersonal.Location = New System.Drawing.Point(120, 67)
    Me.txtPersonal.Name = "txtPersonal"
    Me.txtPersonal.ReadOnly = True
    Me.txtPersonal.Size = New System.Drawing.Size(274, 20)
    Me.txtPersonal.TabIndex = 7
    '
    'lblPersonal
    '
    Me.lblPersonal.AutoSize = True
    Me.lblPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPersonal.Location = New System.Drawing.Point(16, 67)
    Me.lblPersonal.Name = "lblPersonal"
    Me.lblPersonal.Size = New System.Drawing.Size(77, 15)
    Me.lblPersonal.TabIndex = 6
    Me.lblPersonal.Text = "Se entregó a"
    '
    'txtNumero
    '
    Me.txtNumero.Location = New System.Drawing.Point(508, 24)
    Me.txtNumero.Name = "txtNumero"
    Me.txtNumero.Size = New System.Drawing.Size(100, 20)
    Me.txtNumero.TabIndex = 5
    '
    'lblNumero
    '
    Me.lblNumero.AutoSize = True
    Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNumero.Location = New System.Drawing.Point(438, 25)
    Me.lblNumero.Name = "lblNumero"
    Me.lblNumero.Size = New System.Drawing.Size(52, 15)
    Me.lblNumero.TabIndex = 4
    Me.lblNumero.Text = "Número"
    '
    'cboTipoDocumento
    '
    Me.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoDocumento.FormattingEnabled = True
    Me.cboTipoDocumento.Location = New System.Drawing.Point(120, 25)
    Me.cboTipoDocumento.Name = "cboTipoDocumento"
    Me.cboTipoDocumento.Size = New System.Drawing.Size(177, 21)
    Me.cboTipoDocumento.TabIndex = 1
    '
    'lblTipo
    '
    Me.lblTipo.AutoSize = True
    Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTipo.Location = New System.Drawing.Point(16, 25)
    Me.lblTipo.Name = "lblTipo"
    Me.lblTipo.Size = New System.Drawing.Size(98, 15)
    Me.lblTipo.TabIndex = 0
    Me.lblTipo.Text = "Tipo Documento"
    '
    'tpCompras
    '
    Me.tpCompras.Controls.Add(Me.gbListado)
    Me.tpCompras.Controls.Add(Me.btnCerrarCompra)
    Me.tpCompras.Location = New System.Drawing.Point(4, 22)
    Me.tpCompras.Name = "tpCompras"
    Me.tpCompras.Padding = New System.Windows.Forms.Padding(3)
    Me.tpCompras.Size = New System.Drawing.Size(824, 582)
    Me.tpCompras.TabIndex = 1
    Me.tpCompras.Text = "Ver Compras"
    Me.tpCompras.UseVisualStyleBackColor = True
    '
    'gbListado
    '
    Me.gbListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbListado.Controls.Add(Me.dtpFechaFin)
    Me.gbListado.Controls.Add(Me.dtpFechaInicio)
    Me.gbListado.Controls.Add(Me.lblFechaFin)
    Me.gbListado.Controls.Add(Me.lblFechaInicio)
    Me.gbListado.Controls.Add(Me.btnNuevoCompra)
    Me.gbListado.Controls.Add(Me.btnListarCompra)
    Me.gbListado.Controls.Add(Me.dgvCompra)
    Me.gbListado.Controls.Add(Me.btnAnularCompra)
    Me.gbListado.Controls.Add(Me.btnEditar)
    Me.gbListado.Location = New System.Drawing.Point(24, 28)
    Me.gbListado.Name = "gbListado"
    Me.gbListado.Size = New System.Drawing.Size(759, 418)
    Me.gbListado.TabIndex = 0
    Me.gbListado.TabStop = False
    '
    'dtpFechaFin
    '
    Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaFin.Location = New System.Drawing.Point(272, 26)
    Me.dtpFechaFin.Name = "dtpFechaFin"
    Me.dtpFechaFin.Size = New System.Drawing.Size(92, 20)
    Me.dtpFechaFin.TabIndex = 3
    '
    'dtpFechaInicio
    '
    Me.dtpFechaInicio.CustomFormat = ""
    Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaInicio.Location = New System.Drawing.Point(83, 28)
    Me.dtpFechaInicio.Name = "dtpFechaInicio"
    Me.dtpFechaInicio.Size = New System.Drawing.Size(103, 20)
    Me.dtpFechaInicio.TabIndex = 1
    '
    'lblFechaFin
    '
    Me.lblFechaFin.AutoSize = True
    Me.lblFechaFin.Location = New System.Drawing.Point(212, 32)
    Me.lblFechaFin.Name = "lblFechaFin"
    Me.lblFechaFin.Size = New System.Drawing.Size(54, 13)
    Me.lblFechaFin.TabIndex = 2
    Me.lblFechaFin.Text = "Fecha Fin"
    '
    'lblFechaInicio
    '
    Me.lblFechaInicio.AutoSize = True
    Me.lblFechaInicio.Location = New System.Drawing.Point(12, 30)
    Me.lblFechaInicio.Name = "lblFechaInicio"
    Me.lblFechaInicio.Size = New System.Drawing.Size(65, 13)
    Me.lblFechaInicio.TabIndex = 0
    Me.lblFechaInicio.Text = "Fecha Inicio"
    '
    'btnNuevoCompra
    '
    Me.btnNuevoCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnNuevoCompra.BackColor = System.Drawing.Color.White
    Me.btnNuevoCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnNuevoCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnNuevoCompra.Location = New System.Drawing.Point(27, 351)
    Me.btnNuevoCompra.Name = "btnNuevoCompra"
    Me.btnNuevoCompra.Size = New System.Drawing.Size(108, 52)
    Me.btnNuevoCompra.TabIndex = 6
    Me.btnNuevoCompra.Text = "&Nuevo"
    Me.btnNuevoCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnNuevoCompra.UseVisualStyleBackColor = False
    '
    'btnListarCompra
    '
    Me.btnListarCompra.BackColor = System.Drawing.Color.White
    Me.btnListarCompra.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnListarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnListarCompra.Location = New System.Drawing.Point(433, 19)
    Me.btnListarCompra.Name = "btnListarCompra"
    Me.btnListarCompra.Size = New System.Drawing.Size(110, 52)
    Me.btnListarCompra.TabIndex = 4
    Me.btnListarCompra.Text = "&Listar"
    Me.btnListarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnListarCompra.UseVisualStyleBackColor = False
    '
    'dgvCompra
    '
    Me.dgvCompra.AllowUserToAddRows = False
    Me.dgvCompra.AllowUserToDeleteRows = False
    Me.dgvCompra.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvCompra.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdFecha, Me.cdNombreNivel, Me.cdMontoTotal, Me.cdDescripcion, Me.cdNumeroDocumento})
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgvCompra.DefaultCellStyle = DataGridViewCellStyle5
    Me.dgvCompra.Location = New System.Drawing.Point(15, 80)
    Me.dgvCompra.MultiSelect = False
    Me.dgvCompra.Name = "dgvCompra"
    Me.dgvCompra.ReadOnly = True
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvCompra.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
    Me.dgvCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvCompra.Size = New System.Drawing.Size(717, 256)
    Me.dgvCompra.TabIndex = 5
    '
    'cdFecha
    '
    Me.cdFecha.DataPropertyName = "fecha"
    Me.cdFecha.HeaderText = "Fecha"
    Me.cdFecha.Name = "cdFecha"
    Me.cdFecha.ReadOnly = True
    Me.cdFecha.Width = 120
    '
    'cdNombreNivel
    '
    Me.cdNombreNivel.DataPropertyName = "NombreBeneficiario"
    Me.cdNombreNivel.HeaderText = "Se entregó a"
    Me.cdNombreNivel.Name = "cdNombreNivel"
    Me.cdNombreNivel.ReadOnly = True
    Me.cdNombreNivel.Width = 170
    '
    'cdMontoTotal
    '
    Me.cdMontoTotal.DataPropertyName = "monto"
    Me.cdMontoTotal.HeaderText = "Monto Total"
    Me.cdMontoTotal.Name = "cdMontoTotal"
    Me.cdMontoTotal.ReadOnly = True
    '
    'cdDescripcion
    '
    Me.cdDescripcion.DataPropertyName = "nombreTipoDocumento"
    Me.cdDescripcion.HeaderText = "Tipo Documento"
    Me.cdDescripcion.Name = "cdDescripcion"
    Me.cdDescripcion.ReadOnly = True
    Me.cdDescripcion.Width = 120
    '
    'cdNumeroDocumento
    '
    Me.cdNumeroDocumento.DataPropertyName = "Documento"
    Me.cdNumeroDocumento.HeaderText = "Numero de Documento"
    Me.cdNumeroDocumento.Name = "cdNumeroDocumento"
    Me.cdNumeroDocumento.ReadOnly = True
    Me.cdNumeroDocumento.Width = 150
    '
    'btnAnularCompra
    '
    Me.btnAnularCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnAnularCompra.BackColor = System.Drawing.Color.White
    Me.btnAnularCompra.Enabled = False
    Me.btnAnularCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAnularCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAnularCompra.Location = New System.Drawing.Point(283, 351)
    Me.btnAnularCompra.Name = "btnAnularCompra"
    Me.btnAnularCompra.Size = New System.Drawing.Size(110, 52)
    Me.btnAnularCompra.TabIndex = 8
    Me.btnAnularCompra.Text = "&Anular"
    Me.btnAnularCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnAnularCompra.UseVisualStyleBackColor = False
    '
    'btnEditar
    '
    Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnEditar.BackColor = System.Drawing.Color.White
    Me.btnEditar.Enabled = False
    Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnEditar.Location = New System.Drawing.Point(158, 351)
    Me.btnEditar.Name = "btnEditar"
    Me.btnEditar.Size = New System.Drawing.Size(108, 52)
    Me.btnEditar.TabIndex = 7
    Me.btnEditar.Text = "&Editar"
    Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnEditar.UseVisualStyleBackColor = False
    '
    'btnCerrarCompra
    '
    Me.btnCerrarCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrarCompra.BackColor = System.Drawing.Color.White
    Me.btnCerrarCompra.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnCerrarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrarCompra.Location = New System.Drawing.Point(673, 481)
    Me.btnCerrarCompra.Name = "btnCerrarCompra"
    Me.btnCerrarCompra.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrarCompra.TabIndex = 1
    Me.btnCerrarCompra.Text = "&Cerrar"
    Me.btnCerrarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrarCompra.UseVisualStyleBackColor = False
    '
    'frmCompra
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(831, 612)
    Me.Controls.Add(Me.tbControl)
    Me.Name = "frmCompra"
    Me.Text = "Compras"
    Me.tbControl.ResumeLayout(False)
    Me.tpRegistroCompra.ResumeLayout(False)
    Me.tpRegistroCompra.PerformLayout()
    CType(Me.nudIGV, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbLista.ResumeLayout(False)
    Me.gbLista.PerformLayout()
    CType(Me.dgvDetalleCompra, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nudMonto, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbRegistro.ResumeLayout(False)
    Me.gbRegistro.PerformLayout()
    Me.tpCompras.ResumeLayout(False)
    Me.gbListado.ResumeLayout(False)
    Me.gbListado.PerformLayout()
    CType(Me.dgvCompra, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents tbControl As System.Windows.Forms.TabControl
  Friend WithEvents tpRegistroCompra As System.Windows.Forms.TabPage
  Friend WithEvents tpCompras As System.Windows.Forms.TabPage
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents gbLista As System.Windows.Forms.GroupBox
  Friend WithEvents btnEliminar As System.Windows.Forms.Button
  Friend WithEvents btnModificar As System.Windows.Forms.Button
  Friend WithEvents dgvDetalleCompra As System.Windows.Forms.DataGridView
  Friend WithEvents btnAgregar As System.Windows.Forms.Button
  Friend WithEvents nudMonto As System.Windows.Forms.NumericUpDown
  Friend WithEvents lblMonto As System.Windows.Forms.Label
  Friend WithEvents nudCantidad As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents cboConceptoCompra As System.Windows.Forms.ComboBox
  Friend WithEvents lblProductoServicio As System.Windows.Forms.Label
  Friend WithEvents gbRegistro As System.Windows.Forms.GroupBox
  Friend WithEvents lblPersonal As System.Windows.Forms.Label
  Friend WithEvents txtNumero As System.Windows.Forms.TextBox
  Friend WithEvents lblNumero As System.Windows.Forms.Label
  Friend WithEvents cboTipoDocumento As System.Windows.Forms.ComboBox
  Friend WithEvents lblTipo As System.Windows.Forms.Label
  Friend WithEvents gbListado As System.Windows.Forms.GroupBox
  Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
  Friend WithEvents lblFechaFin As System.Windows.Forms.Label
  Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
  Friend WithEvents btnNuevoCompra As System.Windows.Forms.Button
  Friend WithEvents btnListarCompra As System.Windows.Forms.Button
  Friend WithEvents dgvCompra As System.Windows.Forms.DataGridView
  Friend WithEvents btnAnularCompra As System.Windows.Forms.Button
  Friend WithEvents btnEditar As System.Windows.Forms.Button
  Friend WithEvents btnCerrarCompra As System.Windows.Forms.Button
  Friend WithEvents txtPersonal As System.Windows.Forms.TextBox
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
  Friend WithEvents txtSerie As System.Windows.Forms.TextBox
  Friend WithEvents lblSerie As System.Windows.Forms.Label
  Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
  Friend WithEvents lblDescripcion As System.Windows.Forms.Label
  Friend WithEvents cdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdMonto As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents nudIGV As System.Windows.Forms.NumericUpDown
  Friend WithEvents lblIgv As System.Windows.Forms.Label
  Friend WithEvents txtMontoTotal As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cdFecha As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdNombreNivel As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdMontoTotal As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdNumeroDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
