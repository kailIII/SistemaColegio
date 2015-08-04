<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarCanje
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.lblCodigo = New System.Windows.Forms.Label
    Me.txtCodigo = New System.Windows.Forms.TextBox
    Me.lblGradoSec = New System.Windows.Forms.Label
    Me.lblNombre = New System.Windows.Forms.Label
    Me.txtSeccion = New System.Windows.Forms.TextBox
    Me.txtNombre = New System.Windows.Forms.TextBox
    Me.dgvServicio = New System.Windows.Forms.DataGridView
    Me.cdItem = New System.Windows.Forms.DataGridViewCheckBoxColumn
    Me.cdDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.colDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.colSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.dtpFecha = New System.Windows.Forms.DateTimePicker
    Me.lblFecha = New System.Windows.Forms.Label
    Me.txtNumero = New System.Windows.Forms.TextBox
    Me.lblEntidad = New System.Windows.Forms.Label
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.cboTipoDoc = New System.Windows.Forms.ComboBox
    Me.lblDocumento = New System.Windows.Forms.Label
    Me.txtSerie = New System.Windows.Forms.TextBox
    Me.lblSerie = New System.Windows.Forms.Label
    Me.cboEntidad = New System.Windows.Forms.ComboBox
    Me.gbServicio = New System.Windows.Forms.GroupBox
    Me.txtObligacionTotal = New System.Windows.Forms.TextBox
    Me.Label6 = New System.Windows.Forms.Label
    Me.txtDeudaTotal = New System.Windows.Forms.TextBox
    Me.Label5 = New System.Windows.Forms.Label
    Me.txtMoraTotal = New System.Windows.Forms.TextBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.chkSeleccionarTodos = New System.Windows.Forms.CheckBox
    Me.NumText = New System.Windows.Forms.Label
    Me.btnAgregar = New System.Windows.Forms.Button
    Me.txtMontoPagado = New System.Windows.Forms.TextBox
    Me.lblMontoPagado = New System.Windows.Forms.Label
    Me.txtTotal = New System.Windows.Forms.TextBox
    Me.lblTotal = New System.Windows.Forms.Label
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnAceptar = New System.Windows.Forms.Button
    Me.GroupBox1.SuspendLayout()
    CType(Me.dgvServicio, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox2.SuspendLayout()
    Me.gbServicio.SuspendLayout()
    Me.SuspendLayout()
    '
    'GroupBox1
    '
    Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBox1.Controls.Add(Me.lblCodigo)
    Me.GroupBox1.Controls.Add(Me.txtCodigo)
    Me.GroupBox1.Controls.Add(Me.lblGradoSec)
    Me.GroupBox1.Controls.Add(Me.lblNombre)
    Me.GroupBox1.Controls.Add(Me.txtSeccion)
    Me.GroupBox1.Controls.Add(Me.txtNombre)
    Me.GroupBox1.Enabled = False
    Me.GroupBox1.Location = New System.Drawing.Point(6, 98)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(773, 80)
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
    Me.txtNombre.Size = New System.Drawing.Size(587, 22)
    Me.txtNombre.TabIndex = 1
    '
    'dgvServicio
    '
    Me.dgvServicio.AllowUserToAddRows = False
    Me.dgvServicio.AllowUserToDeleteRows = False
    Me.dgvServicio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvServicio.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdItem, Me.cdDetalle, Me.cdImporte, Me.colDescuento, Me.colSubtotal})
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgvServicio.DefaultCellStyle = DataGridViewCellStyle6
    Me.dgvServicio.Location = New System.Drawing.Point(12, 42)
    Me.dgvServicio.MultiSelect = False
    Me.dgvServicio.Name = "dgvServicio"
    DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvServicio.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
    Me.dgvServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.dgvServicio.Size = New System.Drawing.Size(653, 170)
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
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cdDetalle.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdDetalle.HeaderText = "Detalle"
    Me.cdDetalle.Name = "cdDetalle"
    Me.cdDetalle.Width = 280
    '
    'cdImporte
    '
    Me.cdImporte.DataPropertyName = "MontoInicial"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.Format = "N2"
    DataGridViewCellStyle3.NullValue = Nothing
    Me.cdImporte.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdImporte.HeaderText = "Importe"
    Me.cdImporte.Name = "cdImporte"
    Me.cdImporte.ReadOnly = True
    Me.cdImporte.Width = 80
    '
    'colDescuento
    '
    Me.colDescuento.DataPropertyName = "Descuento"
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle4.Format = "N2"
    DataGridViewCellStyle4.NullValue = Nothing
    Me.colDescuento.DefaultCellStyle = DataGridViewCellStyle4
    Me.colDescuento.HeaderText = "Descuento"
    Me.colDescuento.Name = "colDescuento"
    Me.colDescuento.ReadOnly = True
    Me.colDescuento.Width = 80
    '
    'colSubtotal
    '
    Me.colSubtotal.DataPropertyName = "Monto"
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle5.Format = "N2"
    DataGridViewCellStyle5.NullValue = Nothing
    Me.colSubtotal.DefaultCellStyle = DataGridViewCellStyle5
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
    Me.GroupBox2.Size = New System.Drawing.Size(773, 84)
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
    Me.cboEntidad.Enabled = False
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
    Me.gbServicio.Controls.Add(Me.NumText)
    Me.gbServicio.Controls.Add(Me.btnAgregar)
    Me.gbServicio.Controls.Add(Me.txtMontoPagado)
    Me.gbServicio.Controls.Add(Me.lblMontoPagado)
    Me.gbServicio.Controls.Add(Me.txtTotal)
    Me.gbServicio.Controls.Add(Me.lblTotal)
    Me.gbServicio.Controls.Add(Me.dgvServicio)
    Me.gbServicio.Location = New System.Drawing.Point(6, 184)
    Me.gbServicio.Name = "gbServicio"
    Me.gbServicio.Size = New System.Drawing.Size(773, 363)
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
    Me.txtObligacionTotal.Location = New System.Drawing.Point(346, 335)
    Me.txtObligacionTotal.Name = "txtObligacionTotal"
    Me.txtObligacionTotal.ReadOnly = True
    Me.txtObligacionTotal.Size = New System.Drawing.Size(92, 22)
    Me.txtObligacionTotal.TabIndex = 9
    Me.txtObligacionTotal.Text = "0.00"
    Me.txtObligacionTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label6
    '
    Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.Label6.AutoSize = True
    Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(233, 338)
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
    Me.txtDeudaTotal.Location = New System.Drawing.Point(102, 335)
    Me.txtDeudaTotal.Name = "txtDeudaTotal"
    Me.txtDeudaTotal.ReadOnly = True
    Me.txtDeudaTotal.Size = New System.Drawing.Size(92, 22)
    Me.txtDeudaTotal.TabIndex = 7
    Me.txtDeudaTotal.Text = "0.00"
    Me.txtDeudaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label5
    '
    Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.Label5.AutoSize = True
    Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(9, 338)
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
    Me.txtMoraTotal.Location = New System.Drawing.Point(573, 335)
    Me.txtMoraTotal.Name = "txtMoraTotal"
    Me.txtMoraTotal.ReadOnly = True
    Me.txtMoraTotal.Size = New System.Drawing.Size(92, 22)
    Me.txtMoraTotal.TabIndex = 11
    Me.txtMoraTotal.Text = "0.00"
    Me.txtMoraTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label4
    '
    Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(494, 338)
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
    'NumText
    '
    Me.NumText.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.NumText.AutoSize = True
    Me.NumText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.NumText.Location = New System.Drawing.Point(9, 237)
    Me.NumText.Name = "NumText"
    Me.NumText.Size = New System.Drawing.Size(96, 16)
    Me.NumText.TabIndex = 3
    Me.NumText.Text = "Cantidad Total"
    '
    'btnAgregar
    '
    Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnAgregar.BackColor = System.Drawing.Color.White
    Me.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAgregar.Location = New System.Drawing.Point(671, 42)
    Me.btnAgregar.Name = "btnAgregar"
    Me.btnAgregar.Size = New System.Drawing.Size(96, 52)
    Me.btnAgregar.TabIndex = 2
    Me.btnAgregar.Text = "A&gregar"
    Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnAgregar.UseVisualStyleBackColor = False
    '
    'txtMontoPagado
    '
    Me.txtMontoPagado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtMontoPagado.BackColor = System.Drawing.SystemColors.Window
    Me.txtMontoPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMontoPagado.Location = New System.Drawing.Point(573, 307)
    Me.txtMontoPagado.Name = "txtMontoPagado"
    Me.txtMontoPagado.Size = New System.Drawing.Size(92, 22)
    Me.txtMontoPagado.TabIndex = 5
    Me.txtMontoPagado.Text = "0.00"
    Me.txtMontoPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'lblMontoPagado
    '
    Me.lblMontoPagado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblMontoPagado.AutoSize = True
    Me.lblMontoPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMontoPagado.Location = New System.Drawing.Point(464, 310)
    Me.lblMontoPagado.Name = "lblMontoPagado"
    Me.lblMontoPagado.Size = New System.Drawing.Size(108, 16)
    Me.lblMontoPagado.TabIndex = 4
    Me.lblMontoPagado.Text = "Monto pagado"
    '
    'txtTotal
    '
    Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtTotal.BackColor = System.Drawing.SystemColors.Window
    Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTotal.Location = New System.Drawing.Point(573, 234)
    Me.txtTotal.Name = "txtTotal"
    Me.txtTotal.Size = New System.Drawing.Size(92, 22)
    Me.txtTotal.TabIndex = 5
    Me.txtTotal.Text = "0.00"
    Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'lblTotal
    '
    Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblTotal.AutoSize = True
    Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTotal.Location = New System.Drawing.Point(523, 240)
    Me.lblTotal.Name = "lblTotal"
    Me.lblTotal.Size = New System.Drawing.Size(44, 16)
    Me.lblTotal.TabIndex = 4
    Me.lblTotal.Text = "Total"
    '
    'btnCancelar
    '
    Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(785, 489)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(113, 58)
    Me.btnCancelar.TabIndex = 4
    Me.btnCancelar.Text = "&Cancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnAceptar
    '
    Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnAceptar.BackColor = System.Drawing.Color.White
    Me.btnAceptar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAceptar.Location = New System.Drawing.Point(785, 8)
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(113, 52)
    Me.btnAceptar.TabIndex = 3
    Me.btnAceptar.Text = "&Aceptar"
    Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnAceptar.UseVisualStyleBackColor = False
    '
    'frmModificarCanje
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.CancelButton = Me.btnCancelar
    Me.ClientSize = New System.Drawing.Size(910, 559)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnAceptar)
    Me.Controls.Add(Me.gbServicio)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.GroupBox1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmModificarCanje"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "MODIFICAR CANJE"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    CType(Me.dgvServicio, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.gbServicio.ResumeLayout(False)
    Me.gbServicio.PerformLayout()
    Me.ResumeLayout(False)

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
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnAceptar As System.Windows.Forms.Button
  Friend WithEvents btnAgregar As System.Windows.Forms.Button
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents txtSerie As System.Windows.Forms.TextBox
  Friend WithEvents lblSerie As System.Windows.Forms.Label
  Friend WithEvents NumText As System.Windows.Forms.Label
  Friend WithEvents cboTipoDoc As System.Windows.Forms.ComboBox
  Friend WithEvents lblDocumento As System.Windows.Forms.Label
  Friend WithEvents chkSeleccionarTodos As System.Windows.Forms.CheckBox
  Friend WithEvents txtDeudaTotal As System.Windows.Forms.TextBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txtMoraTotal As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtObligacionTotal As System.Windows.Forms.TextBox
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents lblCodigo As System.Windows.Forms.Label
  Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
  Friend WithEvents cdItem As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents cdDetalle As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdImporte As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colDescuento As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents txtMontoPagado As System.Windows.Forms.TextBox
  Friend WithEvents lblMontoPagado As System.Windows.Forms.Label
End Class
