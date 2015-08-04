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
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.btnRegistrar = New System.Windows.Forms.Button()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.Button3 = New System.Windows.Forms.Button()
    Me.Button2 = New System.Windows.Forms.Button()
    Me.DataGridView1 = New System.Windows.Forms.DataGridView()
    Me.cdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.nudMonto = New System.Windows.Forms.NumericUpDown()
    Me.lblMonto = New System.Windows.Forms.Label()
    Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.cboDescripcion = New System.Windows.Forms.ComboBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.cboBeneficiario = New System.Windows.Forms.ComboBox()
    Me.lblBeneficiario = New System.Windows.Forms.Label()
    Me.txtNumero = New System.Windows.Forms.TextBox()
    Me.lblNumero = New System.Windows.Forms.Label()
    Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
    Me.lblTipo = New System.Windows.Forms.Label()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.gbListado = New System.Windows.Forms.GroupBox()
    Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
    Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
    Me.lblFechaFin = New System.Windows.Forms.Label()
    Me.lblFechaInicio = New System.Windows.Forms.Label()
    Me.btnNuevo = New System.Windows.Forms.Button()
    Me.btnListar = New System.Windows.Forms.Button()
    Me.dgvCajaChica = New System.Windows.Forms.DataGridView()
    Me.cdFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdNombreNivel = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdMontoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdNumeroDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btnAnular = New System.Windows.Forms.Button()
    Me.btnEditar = New System.Windows.Forms.Button()
    Me.Button4 = New System.Windows.Forms.Button()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nudMonto, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox1.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.gbListado.SuspendLayout()
    CType(Me.dgvCajaChica, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Location = New System.Drawing.Point(0, -1)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(832, 582)
    Me.TabControl1.TabIndex = 0
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.btnCerrar)
    Me.TabPage1.Controls.Add(Me.btnCancelar)
    Me.TabPage1.Controls.Add(Me.btnRegistrar)
    Me.TabPage1.Controls.Add(Me.GroupBox2)
    Me.TabPage1.Controls.Add(Me.GroupBox1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(824, 556)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Registro de Compras"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(693, 488)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 21
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Enabled = False
    Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(173, 456)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
    Me.btnCancelar.TabIndex = 20
    Me.btnCancelar.Text = "&Cancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Enabled = False
    Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(39, 456)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
    Me.btnRegistrar.TabIndex = 19
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.Button3)
    Me.GroupBox2.Controls.Add(Me.Button2)
    Me.GroupBox2.Controls.Add(Me.DataGridView1)
    Me.GroupBox2.Controls.Add(Me.Button1)
    Me.GroupBox2.Controls.Add(Me.nudMonto)
    Me.GroupBox2.Controls.Add(Me.lblMonto)
    Me.GroupBox2.Controls.Add(Me.NumericUpDown1)
    Me.GroupBox2.Controls.Add(Me.Label2)
    Me.GroupBox2.Controls.Add(Me.cboDescripcion)
    Me.GroupBox2.Controls.Add(Me.Label1)
    Me.GroupBox2.Location = New System.Drawing.Point(35, 133)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(677, 306)
    Me.GroupBox2.TabIndex = 18
    Me.GroupBox2.TabStop = False
    '
    'Button3
    '
    Me.Button3.Location = New System.Drawing.Point(557, 175)
    Me.Button3.Name = "Button3"
    Me.Button3.Size = New System.Drawing.Size(91, 23)
    Me.Button3.TabIndex = 21
    Me.Button3.Text = "Eliminar"
    Me.Button3.UseVisualStyleBackColor = True
    '
    'Button2
    '
    Me.Button2.Location = New System.Drawing.Point(557, 136)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(91, 23)
    Me.Button2.TabIndex = 20
    Me.Button2.Text = "Modificar"
    Me.Button2.UseVisualStyleBackColor = True
    '
    'DataGridView1
    '
    Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdProducto, Me.cdCantidad, Me.cdMonto})
    Me.DataGridView1.Location = New System.Drawing.Point(14, 124)
    Me.DataGridView1.Name = "DataGridView1"
    Me.DataGridView1.Size = New System.Drawing.Size(522, 150)
    Me.DataGridView1.TabIndex = 19
    '
    'cdProducto
    '
    Me.cdProducto.HeaderText = "Producto/Servicio"
    Me.cdProducto.Name = "cdProducto"
    '
    'cdCantidad
    '
    Me.cdCantidad.HeaderText = "Cantidad"
    Me.cdCantidad.Name = "cdCantidad"
    '
    'cdMonto
    '
    Me.cdMonto.HeaderText = "Monto Total"
    Me.cdMonto.Name = "cdMonto"
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(454, 69)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(91, 23)
    Me.Button1.TabIndex = 18
    Me.Button1.Text = "Agregar"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'nudMonto
    '
    Me.nudMonto.Enabled = False
    Me.nudMonto.Location = New System.Drawing.Point(312, 72)
    Me.nudMonto.Name = "nudMonto"
    Me.nudMonto.Size = New System.Drawing.Size(92, 20)
    Me.nudMonto.TabIndex = 17
    '
    'lblMonto
    '
    Me.lblMonto.AutoSize = True
    Me.lblMonto.Enabled = False
    Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMonto.Location = New System.Drawing.Point(225, 72)
    Me.lblMonto.Name = "lblMonto"
    Me.lblMonto.Size = New System.Drawing.Size(72, 15)
    Me.lblMonto.TabIndex = 16
    Me.lblMonto.Text = "Monto Total"
    '
    'NumericUpDown1
    '
    Me.NumericUpDown1.Location = New System.Drawing.Point(93, 67)
    Me.NumericUpDown1.Name = "NumericUpDown1"
    Me.NumericUpDown1.Size = New System.Drawing.Size(48, 20)
    Me.NumericUpDown1.TabIndex = 15
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Enabled = False
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(11, 67)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(56, 15)
    Me.Label2.TabIndex = 14
    Me.Label2.Text = "Cantidad"
    '
    'cboDescripcion
    '
    Me.cboDescripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboDescripcion.Enabled = False
    Me.cboDescripcion.FormattingEnabled = True
    Me.cboDescripcion.Location = New System.Drawing.Point(134, 26)
    Me.cboDescripcion.Name = "cboDescripcion"
    Me.cboDescripcion.Size = New System.Drawing.Size(301, 21)
    Me.cboDescripcion.TabIndex = 12
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Enabled = False
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(11, 27)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(102, 15)
    Me.Label1.TabIndex = 11
    Me.Label1.Text = "Producto/Servicio"
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.cboBeneficiario)
    Me.GroupBox1.Controls.Add(Me.lblBeneficiario)
    Me.GroupBox1.Controls.Add(Me.txtNumero)
    Me.GroupBox1.Controls.Add(Me.lblNumero)
    Me.GroupBox1.Controls.Add(Me.cboTipoDocumento)
    Me.GroupBox1.Controls.Add(Me.lblTipo)
    Me.GroupBox1.Location = New System.Drawing.Point(35, 15)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(583, 96)
    Me.GroupBox1.TabIndex = 17
    Me.GroupBox1.TabStop = False
    '
    'cboBeneficiario
    '
    Me.cboBeneficiario.Enabled = False
    Me.cboBeneficiario.FormattingEnabled = True
    Me.cboBeneficiario.Location = New System.Drawing.Point(177, 61)
    Me.cboBeneficiario.Name = "cboBeneficiario"
    Me.cboBeneficiario.Size = New System.Drawing.Size(144, 21)
    Me.cboBeneficiario.TabIndex = 15
    '
    'lblBeneficiario
    '
    Me.lblBeneficiario.AutoSize = True
    Me.lblBeneficiario.Enabled = False
    Me.lblBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblBeneficiario.Location = New System.Drawing.Point(16, 61)
    Me.lblBeneficiario.Name = "lblBeneficiario"
    Me.lblBeneficiario.Size = New System.Drawing.Size(155, 15)
    Me.lblBeneficiario.TabIndex = 14
    Me.lblBeneficiario.Text = "Responsable de la compra"
    '
    'txtNumero
    '
    Me.txtNumero.Enabled = False
    Me.txtNumero.Location = New System.Drawing.Point(378, 28)
    Me.txtNumero.Name = "txtNumero"
    Me.txtNumero.Size = New System.Drawing.Size(100, 20)
    Me.txtNumero.TabIndex = 13
    '
    'lblNumero
    '
    Me.lblNumero.AutoSize = True
    Me.lblNumero.Enabled = False
    Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNumero.Location = New System.Drawing.Point(308, 29)
    Me.lblNumero.Name = "lblNumero"
    Me.lblNumero.Size = New System.Drawing.Size(52, 15)
    Me.lblNumero.TabIndex = 12
    Me.lblNumero.Text = "Número"
    '
    'cboTipoDocumento
    '
    Me.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoDocumento.Enabled = False
    Me.cboTipoDocumento.FormattingEnabled = True
    Me.cboTipoDocumento.Location = New System.Drawing.Point(120, 25)
    Me.cboTipoDocumento.Name = "cboTipoDocumento"
    Me.cboTipoDocumento.Size = New System.Drawing.Size(144, 21)
    Me.cboTipoDocumento.TabIndex = 11
    '
    'lblTipo
    '
    Me.lblTipo.AutoSize = True
    Me.lblTipo.Enabled = False
    Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTipo.Location = New System.Drawing.Point(16, 25)
    Me.lblTipo.Name = "lblTipo"
    Me.lblTipo.Size = New System.Drawing.Size(98, 15)
    Me.lblTipo.TabIndex = 10
    Me.lblTipo.Text = "Tipo Documento"
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.gbListado)
    Me.TabPage2.Controls.Add(Me.Button4)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(824, 556)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Ver Compras"
    Me.TabPage2.UseVisualStyleBackColor = True
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
    Me.gbListado.Controls.Add(Me.btnNuevo)
    Me.gbListado.Controls.Add(Me.btnListar)
    Me.gbListado.Controls.Add(Me.dgvCajaChica)
    Me.gbListado.Controls.Add(Me.btnAnular)
    Me.gbListado.Controls.Add(Me.btnEditar)
    Me.gbListado.Location = New System.Drawing.Point(24, 28)
    Me.gbListado.Name = "gbListado"
    Me.gbListado.Size = New System.Drawing.Size(759, 392)
    Me.gbListado.TabIndex = 3
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
    Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaInicio.Location = New System.Drawing.Point(83, 28)
    Me.dtpFechaInicio.Name = "dtpFechaInicio"
    Me.dtpFechaInicio.Size = New System.Drawing.Size(92, 20)
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
    'btnNuevo
    '
    Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnNuevo.BackColor = System.Drawing.Color.White
    Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnNuevo.Location = New System.Drawing.Point(27, 325)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(108, 52)
    Me.btnNuevo.TabIndex = 6
    Me.btnNuevo.Text = "&Nuevo"
    Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnNuevo.UseVisualStyleBackColor = False
    '
    'btnListar
    '
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnListar.Location = New System.Drawing.Point(433, 19)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(110, 52)
    Me.btnListar.TabIndex = 4
    Me.btnListar.Text = "&Listar"
    Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnListar.UseVisualStyleBackColor = False
    '
    'dgvCajaChica
    '
    Me.dgvCajaChica.AllowUserToAddRows = False
    Me.dgvCajaChica.AllowUserToDeleteRows = False
    Me.dgvCajaChica.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvCajaChica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvCajaChica.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdFecha, Me.cdNombreNivel, Me.cdDescripcion, Me.cdMontoTotal, Me.cdNumeroDocumento})
    Me.dgvCajaChica.Location = New System.Drawing.Point(15, 80)
    Me.dgvCajaChica.MultiSelect = False
    Me.dgvCajaChica.Name = "dgvCajaChica"
    Me.dgvCajaChica.ReadOnly = True
    Me.dgvCajaChica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvCajaChica.Size = New System.Drawing.Size(717, 230)
    Me.dgvCajaChica.TabIndex = 5
    '
    'cdFecha
    '
    Me.cdFecha.DataPropertyName = "fecha"
    Me.cdFecha.HeaderText = "Fecha"
    Me.cdFecha.Name = "cdFecha"
    Me.cdFecha.ReadOnly = True
    Me.cdFecha.Width = 90
    '
    'cdNombreNivel
    '
    Me.cdNombreNivel.DataPropertyName = "NombreCompleto"
    Me.cdNombreNivel.HeaderText = "Responsable de Compra"
    Me.cdNombreNivel.Name = "cdNombreNivel"
    Me.cdNombreNivel.ReadOnly = True
    Me.cdNombreNivel.Width = 170
    '
    'cdDescripcion
    '
    Me.cdDescripcion.DataPropertyName = "tipoDocumento"
    Me.cdDescripcion.HeaderText = "Tipo Documento"
    Me.cdDescripcion.Name = "cdDescripcion"
    Me.cdDescripcion.ReadOnly = True
    Me.cdDescripcion.Width = 120
    '
    'cdMontoTotal
    '
    Me.cdMontoTotal.DataPropertyName = "monto"
    Me.cdMontoTotal.HeaderText = "Monto Total"
    Me.cdMontoTotal.Name = "cdMontoTotal"
    Me.cdMontoTotal.ReadOnly = True
    Me.cdMontoTotal.Width = 110
    '
    'cdNumeroDocumento
    '
    Me.cdNumeroDocumento.DataPropertyName = "numeroDocumento"
    Me.cdNumeroDocumento.HeaderText = "Numero de Documento"
    Me.cdNumeroDocumento.Name = "cdNumeroDocumento"
    Me.cdNumeroDocumento.ReadOnly = True
    Me.cdNumeroDocumento.Width = 170
    '
    'btnAnular
    '
    Me.btnAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnAnular.BackColor = System.Drawing.Color.White
    Me.btnAnular.Enabled = False
    Me.btnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAnular.Location = New System.Drawing.Point(283, 325)
    Me.btnAnular.Name = "btnAnular"
    Me.btnAnular.Size = New System.Drawing.Size(110, 52)
    Me.btnAnular.TabIndex = 8
    Me.btnAnular.Text = "&Anular"
    Me.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnAnular.UseVisualStyleBackColor = False
    '
    'btnEditar
    '
    Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnEditar.BackColor = System.Drawing.Color.White
    Me.btnEditar.Enabled = False
    Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnEditar.Location = New System.Drawing.Point(158, 325)
    Me.btnEditar.Name = "btnEditar"
    Me.btnEditar.Size = New System.Drawing.Size(108, 52)
    Me.btnEditar.TabIndex = 7
    Me.btnEditar.Text = "&Editar"
    Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnEditar.UseVisualStyleBackColor = False
    '
    'Button4
    '
    Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Button4.BackColor = System.Drawing.Color.White
    Me.Button4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.Button4.Location = New System.Drawing.Point(673, 455)
    Me.Button4.Name = "Button4"
    Me.Button4.Size = New System.Drawing.Size(110, 52)
    Me.Button4.TabIndex = 4
    Me.Button4.Text = "&Cerrar"
    Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.Button4.UseVisualStyleBackColor = False
    '
    'frmCompra
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(831, 583)
    Me.Controls.Add(Me.TabControl1)
    Me.Name = "frmCompra"
    Me.Text = "Compras"
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nudMonto, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.TabPage2.ResumeLayout(False)
    Me.gbListado.ResumeLayout(False)
    Me.gbListado.PerformLayout()
    CType(Me.dgvCajaChica, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents Button3 As System.Windows.Forms.Button
  Friend WithEvents Button2 As System.Windows.Forms.Button
  Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
  Friend WithEvents cdProducto As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdMonto As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents nudMonto As System.Windows.Forms.NumericUpDown
  Friend WithEvents lblMonto As System.Windows.Forms.Label
  Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents cboDescripcion As System.Windows.Forms.ComboBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents cboBeneficiario As System.Windows.Forms.ComboBox
  Friend WithEvents lblBeneficiario As System.Windows.Forms.Label
  Friend WithEvents txtNumero As System.Windows.Forms.TextBox
  Friend WithEvents lblNumero As System.Windows.Forms.Label
  Friend WithEvents cboTipoDocumento As System.Windows.Forms.ComboBox
  Friend WithEvents lblTipo As System.Windows.Forms.Label
  Friend WithEvents gbListado As System.Windows.Forms.GroupBox
  Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
  Friend WithEvents lblFechaFin As System.Windows.Forms.Label
  Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents dgvCajaChica As System.Windows.Forms.DataGridView
  Friend WithEvents cdFecha As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdNombreNivel As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdMontoTotal As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdNumeroDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnAnular As System.Windows.Forms.Button
  Friend WithEvents btnEditar As System.Windows.Forms.Button
  Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
