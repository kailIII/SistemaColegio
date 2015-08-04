<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarDocumento
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
    Me.lblPersona = New System.Windows.Forms.Label()
    Me.txtPersona = New System.Windows.Forms.TextBox()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.btnRegistrar = New System.Windows.Forms.Button()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.cboTipoDoc = New System.Windows.Forms.ComboBox()
    Me.lblDocumento = New System.Windows.Forms.Label()
    Me.txtSerie = New System.Windows.Forms.TextBox()
    Me.lblSerie = New System.Windows.Forms.Label()
    Me.lblFecha = New System.Windows.Forms.Label()
    Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
    Me.txtNumero = New System.Windows.Forms.TextBox()
    Me.cboFormaPago = New System.Windows.Forms.ComboBox()
    Me.gbDeposito = New System.Windows.Forms.GroupBox()
    Me.nudMontoVoucher = New System.Windows.Forms.NumericUpDown()
    Me.lblCuenta = New System.Windows.Forms.Label()
    Me.cboCuenta = New System.Windows.Forms.ComboBox()
    Me.lblMontoVoucher = New System.Windows.Forms.Label()
    Me.lblVoucher = New System.Windows.Forms.Label()
    Me.txtNumOperacion = New System.Windows.Forms.TextBox()
    Me.cboEntidadFinanciera = New System.Windows.Forms.ComboBox()
    Me.lblEntidadFinanciera = New System.Windows.Forms.Label()
    Me.dtpFechaVoucher = New System.Windows.Forms.DateTimePicker()
    Me.lblFechaVoucher = New System.Windows.Forms.Label()
    Me.lblFormaPago = New System.Windows.Forms.Label()
    Me.mControlError = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.btnBuscar = New System.Windows.Forms.Button()
    Me.GroupBox2.SuspendLayout()
    Me.gbDeposito.SuspendLayout()
    CType(Me.nudMontoVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.mControlError, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblPersona
    '
    Me.lblPersona.AutoSize = True
    Me.lblPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPersona.Location = New System.Drawing.Point(30, 125)
    Me.lblPersona.Name = "lblPersona"
    Me.lblPersona.Size = New System.Drawing.Size(59, 16)
    Me.lblPersona.TabIndex = 7
    Me.lblPersona.Text = "Persona"
    '
    'txtPersona
    '
    Me.txtPersona.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtPersona.BackColor = System.Drawing.SystemColors.Window
    Me.txtPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPersona.Location = New System.Drawing.Point(93, 119)
    Me.txtPersona.Name = "txtPersona"
    Me.txtPersona.ReadOnly = True
    Me.txtPersona.Size = New System.Drawing.Size(433, 22)
    Me.txtPersona.TabIndex = 8
    '
    'btnCancelar
    '
    Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(544, 376)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(102, 57)
    Me.btnCancelar.TabIndex = 5
    Me.btnCancelar.Text = "&Cancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(436, 379)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(102, 52)
    Me.btnRegistrar.TabIndex = 4
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'GroupBox2
    '
    Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBox2.Controls.Add(Me.btnBuscar)
    Me.GroupBox2.Controls.Add(Me.cboTipoDoc)
    Me.GroupBox2.Controls.Add(Me.lblDocumento)
    Me.GroupBox2.Controls.Add(Me.txtSerie)
    Me.GroupBox2.Controls.Add(Me.lblSerie)
    Me.GroupBox2.Controls.Add(Me.lblFecha)
    Me.GroupBox2.Controls.Add(Me.dtpFecha)
    Me.GroupBox2.Controls.Add(Me.txtNumero)
    Me.GroupBox2.Controls.Add(Me.lblPersona)
    Me.GroupBox2.Controls.Add(Me.txtPersona)
    Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(634, 162)
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
    Me.cboTipoDoc.Location = New System.Drawing.Point(93, 35)
    Me.cboTipoDoc.Name = "cboTipoDoc"
    Me.cboTipoDoc.Size = New System.Drawing.Size(166, 24)
    Me.cboTipoDoc.TabIndex = 1
    '
    'lblDocumento
    '
    Me.lblDocumento.AutoSize = True
    Me.lblDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDocumento.Location = New System.Drawing.Point(10, 43)
    Me.lblDocumento.Name = "lblDocumento"
    Me.lblDocumento.Size = New System.Drawing.Size(77, 16)
    Me.lblDocumento.TabIndex = 0
    Me.lblDocumento.Text = "D&ocumento"
    '
    'txtSerie
    '
    Me.txtSerie.BackColor = System.Drawing.SystemColors.Window
    Me.txtSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSerie.Location = New System.Drawing.Point(365, 74)
    Me.txtSerie.Name = "txtSerie"
    Me.txtSerie.Size = New System.Drawing.Size(57, 22)
    Me.txtSerie.TabIndex = 5
    Me.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'lblSerie
    '
    Me.lblSerie.AutoSize = True
    Me.lblSerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSerie.Location = New System.Drawing.Point(319, 80)
    Me.lblSerie.Name = "lblSerie"
    Me.lblSerie.Size = New System.Drawing.Size(40, 16)
    Me.lblSerie.TabIndex = 4
    Me.lblSerie.Text = "Ser&ie"
    '
    'lblFecha
    '
    Me.lblFecha.AutoSize = True
    Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFecha.Location = New System.Drawing.Point(41, 80)
    Me.lblFecha.Name = "lblFecha"
    Me.lblFecha.Size = New System.Drawing.Size(46, 16)
    Me.lblFecha.TabIndex = 2
    Me.lblFecha.Text = "&Fecha"
    '
    'dtpFecha
    '
    Me.dtpFecha.CustomFormat = "dd/MM/yyyy hh:mm tt"
    Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtpFecha.Location = New System.Drawing.Point(93, 74)
    Me.dtpFecha.Name = "dtpFecha"
    Me.dtpFecha.Size = New System.Drawing.Size(161, 22)
    Me.dtpFecha.TabIndex = 3
    '
    'txtNumero
    '
    Me.txtNumero.BackColor = System.Drawing.SystemColors.Window
    Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNumero.Location = New System.Drawing.Point(428, 74)
    Me.txtNumero.Name = "txtNumero"
    Me.txtNumero.Size = New System.Drawing.Size(98, 22)
    Me.txtNumero.TabIndex = 6
    Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'cboFormaPago
    '
    Me.cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboFormaPago.FormattingEnabled = True
    Me.cboFormaPago.Items.AddRange(New Object() {"CHEQUE", "EFECTIVO", "VOUCHER"})
    Me.cboFormaPago.Location = New System.Drawing.Point(122, 182)
    Me.cboFormaPago.Name = "cboFormaPago"
    Me.cboFormaPago.Size = New System.Drawing.Size(166, 24)
    Me.cboFormaPago.TabIndex = 2
    '
    'gbDeposito
    '
    Me.gbDeposito.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
    Me.gbDeposito.Location = New System.Drawing.Point(12, 190)
    Me.gbDeposito.Name = "gbDeposito"
    Me.gbDeposito.Size = New System.Drawing.Size(634, 160)
    Me.gbDeposito.TabIndex = 3
    Me.gbDeposito.TabStop = False
    '
    'nudMontoVoucher
    '
    Me.nudMontoVoucher.DecimalPlaces = 2
    Me.nudMontoVoucher.Location = New System.Drawing.Point(444, 119)
    Me.nudMontoVoucher.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
    Me.nudMontoVoucher.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.nudMontoVoucher.Name = "nudMontoVoucher"
    Me.nudMontoVoucher.Size = New System.Drawing.Size(92, 20)
    Me.nudMontoVoucher.TabIndex = 9
    Me.nudMontoVoucher.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.nudMontoVoucher.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'lblCuenta
    '
    Me.lblCuenta.AutoSize = True
    Me.lblCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCuenta.Location = New System.Drawing.Point(47, 124)
    Me.lblCuenta.Name = "lblCuenta"
    Me.lblCuenta.Size = New System.Drawing.Size(50, 16)
    Me.lblCuenta.TabIndex = 6
    Me.lblCuenta.Text = "C&uenta"
    '
    'cboCuenta
    '
    Me.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCuenta.FormattingEnabled = True
    Me.cboCuenta.Location = New System.Drawing.Point(110, 119)
    Me.cboCuenta.Name = "cboCuenta"
    Me.cboCuenta.Size = New System.Drawing.Size(234, 21)
    Me.cboCuenta.TabIndex = 7
    '
    'lblMontoVoucher
    '
    Me.lblMontoVoucher.AutoSize = True
    Me.lblMontoVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMontoVoucher.Location = New System.Drawing.Point(393, 124)
    Me.lblMontoVoucher.Name = "lblMontoVoucher"
    Me.lblMontoVoucher.Size = New System.Drawing.Size(45, 16)
    Me.lblMontoVoucher.TabIndex = 8
    Me.lblMontoVoucher.Text = "&Monto"
    '
    'lblVoucher
    '
    Me.lblVoucher.AutoSize = True
    Me.lblVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblVoucher.Location = New System.Drawing.Point(351, 45)
    Me.lblVoucher.Name = "lblVoucher"
    Me.lblVoucher.Size = New System.Drawing.Size(90, 16)
    Me.lblVoucher.TabIndex = 2
    Me.lblVoucher.Text = "Núm. Operac."
    '
    'txtNumOperacion
    '
    Me.txtNumOperacion.BackColor = System.Drawing.SystemColors.Window
    Me.txtNumOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNumOperacion.Location = New System.Drawing.Point(444, 39)
    Me.txtNumOperacion.Name = "txtNumOperacion"
    Me.txtNumOperacion.Size = New System.Drawing.Size(181, 22)
    Me.txtNumOperacion.TabIndex = 3
    '
    'cboEntidadFinanciera
    '
    Me.cboEntidadFinanciera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEntidadFinanciera.FormattingEnabled = True
    Me.cboEntidadFinanciera.Location = New System.Drawing.Point(110, 81)
    Me.cboEntidadFinanciera.Name = "cboEntidadFinanciera"
    Me.cboEntidadFinanciera.Size = New System.Drawing.Size(234, 21)
    Me.cboEntidadFinanciera.TabIndex = 5
    '
    'lblEntidadFinanciera
    '
    Me.lblEntidadFinanciera.AutoSize = True
    Me.lblEntidadFinanciera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblEntidadFinanciera.Location = New System.Drawing.Point(10, 86)
    Me.lblEntidadFinanciera.Name = "lblEntidadFinanciera"
    Me.lblEntidadFinanciera.Size = New System.Drawing.Size(87, 16)
    Me.lblEntidadFinanciera.TabIndex = 4
    Me.lblEntidadFinanciera.Text = "Ent. Bancaria"
    '
    'dtpFechaVoucher
    '
    Me.dtpFechaVoucher.CustomFormat = "dd/MM/yyyy hh:mm tt"
    Me.dtpFechaVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaVoucher.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaVoucher.Location = New System.Drawing.Point(110, 37)
    Me.dtpFechaVoucher.Name = "dtpFechaVoucher"
    Me.dtpFechaVoucher.Size = New System.Drawing.Size(100, 22)
    Me.dtpFechaVoucher.TabIndex = 1
    '
    'lblFechaVoucher
    '
    Me.lblFechaVoucher.AutoSize = True
    Me.lblFechaVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFechaVoucher.Location = New System.Drawing.Point(51, 43)
    Me.lblFechaVoucher.Name = "lblFechaVoucher"
    Me.lblFechaVoucher.Size = New System.Drawing.Size(46, 16)
    Me.lblFechaVoucher.TabIndex = 0
    Me.lblFechaVoucher.Text = "&Fecha"
    '
    'lblFormaPago
    '
    Me.lblFormaPago.AutoSize = True
    Me.lblFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFormaPago.Location = New System.Drawing.Point(21, 190)
    Me.lblFormaPago.Name = "lblFormaPago"
    Me.lblFormaPago.Size = New System.Drawing.Size(101, 16)
    Me.lblFormaPago.TabIndex = 1
    Me.lblFormaPago.Text = "For&ma de pago"
    '
    'mControlError
    '
    Me.mControlError.ContainerControl = Me
    '
    'btnBuscar
    '
    Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnBuscar.BackColor = System.Drawing.Color.White
    Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscar.Location = New System.Drawing.Point(529, 89)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(96, 52)
    Me.btnBuscar.TabIndex = 9
    Me.btnBuscar.Text = "&Buscar"
    Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscar.UseVisualStyleBackColor = False
    '
    'frmModificarDocumento
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
    Me.ClientSize = New System.Drawing.Size(658, 445)
    Me.Controls.Add(Me.lblFormaPago)
    Me.Controls.Add(Me.cboFormaPago)
    Me.Controls.Add(Me.gbDeposito)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.GroupBox2)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmModificarDocumento"
    Me.Text = "Modificar Documento"
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.gbDeposito.ResumeLayout(False)
    Me.gbDeposito.PerformLayout()
    CType(Me.nudMontoVoucher, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.mControlError, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblPersona As System.Windows.Forms.Label
  Friend WithEvents txtPersona As System.Windows.Forms.TextBox
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents cboTipoDoc As System.Windows.Forms.ComboBox
  Friend WithEvents lblDocumento As System.Windows.Forms.Label
  Friend WithEvents txtSerie As System.Windows.Forms.TextBox
  Friend WithEvents lblSerie As System.Windows.Forms.Label
  Friend WithEvents lblFecha As System.Windows.Forms.Label
  Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
  Friend WithEvents txtNumero As System.Windows.Forms.TextBox
  Friend WithEvents cboFormaPago As System.Windows.Forms.ComboBox
  Friend WithEvents gbDeposito As System.Windows.Forms.GroupBox
  Friend WithEvents nudMontoVoucher As System.Windows.Forms.NumericUpDown
  Friend WithEvents lblCuenta As System.Windows.Forms.Label
  Friend WithEvents cboCuenta As System.Windows.Forms.ComboBox
  Friend WithEvents lblMontoVoucher As System.Windows.Forms.Label
  Friend WithEvents lblVoucher As System.Windows.Forms.Label
  Friend WithEvents txtNumOperacion As System.Windows.Forms.TextBox
  Friend WithEvents cboEntidadFinanciera As System.Windows.Forms.ComboBox
  Friend WithEvents lblEntidadFinanciera As System.Windows.Forms.Label
  Friend WithEvents dtpFechaVoucher As System.Windows.Forms.DateTimePicker
  Friend WithEvents lblFechaVoucher As System.Windows.Forms.Label
  Friend WithEvents lblFormaPago As System.Windows.Forms.Label
  Friend WithEvents mControlError As System.Windows.Forms.ErrorProvider
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class
