<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoPagosBanco
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
    Me.dgvDocumentos = New System.Windows.Forms.DataGridView()
    Me.cdCodigoAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Persona = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdVoucher = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.btnExportar = New System.Windows.Forms.Button()
    Me.lblTotalRecaudado = New System.Windows.Forms.Label()
    Me.txtTotalRecaudado = New System.Windows.Forms.TextBox()
    Me.btnBuscar = New System.Windows.Forms.Button()
    Me.btnImprimir = New System.Windows.Forms.Button()
    Me.lblCuenta = New System.Windows.Forms.Label()
    Me.cboCuenta = New System.Windows.Forms.ComboBox()
    Me.cboEntidadFinanciera = New System.Windows.Forms.ComboBox()
    Me.lblEntidadFinanciera = New System.Windows.Forms.Label()
    Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
    Me.lblFechaVoucher = New System.Windows.Forms.Label()
    Me.lblInstitucion = New System.Windows.Forms.Label()
    Me.txtInstitucion = New System.Windows.Forms.TextBox()
    Me.lblCOPAFA = New System.Windows.Forms.Label()
    Me.txtCOPAFA = New System.Windows.Forms.TextBox()
    CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'dgvDocumentos
    '
    Me.dgvDocumentos.AllowUserToAddRows = False
    Me.dgvDocumentos.AllowUserToDeleteRows = False
    Me.dgvDocumentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvDocumentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdCodigoAlumno, Me.Persona, Me.cdVoucher, Me.cdDocumento, Me.cdDescripcion, Me.cdMonto})
    Me.dgvDocumentos.Location = New System.Drawing.Point(17, 121)
    Me.dgvDocumentos.Name = "dgvDocumentos"
    Me.dgvDocumentos.ReadOnly = True
    Me.dgvDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvDocumentos.Size = New System.Drawing.Size(811, 395)
    Me.dgvDocumentos.TabIndex = 7
    '
    'cdCodigoAlumno
    '
    Me.cdCodigoAlumno.DataPropertyName = "CodigoRecaudacion"
    Me.cdCodigoAlumno.HeaderText = "Código"
    Me.cdCodigoAlumno.Name = "cdCodigoAlumno"
    Me.cdCodigoAlumno.ReadOnly = True
    '
    'Persona
    '
    Me.Persona.DataPropertyName = "Alumno"
    Me.Persona.HeaderText = "Persona"
    Me.Persona.Name = "Persona"
    Me.Persona.ReadOnly = True
    Me.Persona.Width = 200
    '
    'cdVoucher
    '
    Me.cdVoucher.DataPropertyName = "NumOperacion"
    Me.cdVoucher.HeaderText = "Voucher"
    Me.cdVoucher.Name = "cdVoucher"
    Me.cdVoucher.ReadOnly = True
    Me.cdVoucher.Width = 150
    '
    'cdDocumento
    '
    Me.cdDocumento.DataPropertyName = "Documento"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.cdDocumento.DefaultCellStyle = DataGridViewCellStyle1
    Me.cdDocumento.HeaderText = "Documento"
    Me.cdDocumento.Name = "cdDocumento"
    Me.cdDocumento.ReadOnly = True
    Me.cdDocumento.Width = 110
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
    'btnCancelar
    '
    Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(722, 533)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(106, 52)
    Me.btnCancelar.TabIndex = 12
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
    Me.btnExportar.TabIndex = 11
    Me.btnExportar.Text = "&Exportar"
    Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnExportar.UseVisualStyleBackColor = False
    '
    'lblTotalRecaudado
    '
    Me.lblTotalRecaudado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblTotalRecaudado.AutoSize = True
    Me.lblTotalRecaudado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTotalRecaudado.Location = New System.Drawing.Point(14, 570)
    Me.lblTotalRecaudado.Name = "lblTotalRecaudado"
    Me.lblTotalRecaudado.Size = New System.Drawing.Size(39, 15)
    Me.lblTotalRecaudado.TabIndex = 8
    Me.lblTotalRecaudado.Text = "Total"
    '
    'txtTotalRecaudado
    '
    Me.txtTotalRecaudado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtTotalRecaudado.BackColor = System.Drawing.SystemColors.Window
    Me.txtTotalRecaudado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTotalRecaudado.Location = New System.Drawing.Point(93, 563)
    Me.txtTotalRecaudado.Name = "txtTotalRecaudado"
    Me.txtTotalRecaudado.ReadOnly = True
    Me.txtTotalRecaudado.Size = New System.Drawing.Size(100, 22)
    Me.txtTotalRecaudado.TabIndex = 9
    Me.txtTotalRecaudado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'btnBuscar
    '
    Me.btnBuscar.BackColor = System.Drawing.Color.White
    Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscar.Location = New System.Drawing.Point(586, 47)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(110, 52)
    Me.btnBuscar.TabIndex = 6
    Me.btnBuscar.Text = "&Buscar"
    Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscar.UseVisualStyleBackColor = False
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
    Me.btnImprimir.TabIndex = 10
    Me.btnImprimir.Text = "&Imprimir"
    Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnImprimir.UseVisualStyleBackColor = False
    '
    'lblCuenta
    '
    Me.lblCuenta.AutoSize = True
    Me.lblCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCuenta.Location = New System.Drawing.Point(40, 82)
    Me.lblCuenta.Name = "lblCuenta"
    Me.lblCuenta.Size = New System.Drawing.Size(50, 16)
    Me.lblCuenta.TabIndex = 2
    Me.lblCuenta.Text = "C&uenta"
    '
    'cboCuenta
    '
    Me.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCuenta.FormattingEnabled = True
    Me.cboCuenta.Location = New System.Drawing.Point(103, 77)
    Me.cboCuenta.Name = "cboCuenta"
    Me.cboCuenta.Size = New System.Drawing.Size(224, 21)
    Me.cboCuenta.TabIndex = 3
    '
    'cboEntidadFinanciera
    '
    Me.cboEntidadFinanciera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEntidadFinanciera.FormattingEnabled = True
    Me.cboEntidadFinanciera.Location = New System.Drawing.Point(103, 33)
    Me.cboEntidadFinanciera.Name = "cboEntidadFinanciera"
    Me.cboEntidadFinanciera.Size = New System.Drawing.Size(314, 21)
    Me.cboEntidadFinanciera.TabIndex = 1
    '
    'lblEntidadFinanciera
    '
    Me.lblEntidadFinanciera.AutoSize = True
    Me.lblEntidadFinanciera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblEntidadFinanciera.Location = New System.Drawing.Point(10, 38)
    Me.lblEntidadFinanciera.Name = "lblEntidadFinanciera"
    Me.lblEntidadFinanciera.Size = New System.Drawing.Size(87, 16)
    Me.lblEntidadFinanciera.TabIndex = 0
    Me.lblEntidadFinanciera.Text = "E&nt. Bancaria"
    '
    'dtpFecha
    '
    Me.dtpFecha.CustomFormat = "dd/MM/yyyy hh:mm tt"
    Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFecha.Location = New System.Drawing.Point(436, 77)
    Me.dtpFecha.Name = "dtpFecha"
    Me.dtpFecha.Size = New System.Drawing.Size(100, 22)
    Me.dtpFecha.TabIndex = 5
    '
    'lblFechaVoucher
    '
    Me.lblFechaVoucher.AutoSize = True
    Me.lblFechaVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFechaVoucher.Location = New System.Drawing.Point(387, 82)
    Me.lblFechaVoucher.Name = "lblFechaVoucher"
    Me.lblFechaVoucher.Size = New System.Drawing.Size(46, 16)
    Me.lblFechaVoucher.TabIndex = 4
    Me.lblFechaVoucher.Text = "&Fecha"
    '
    'lblInstitucion
    '
    Me.lblInstitucion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblInstitucion.AutoSize = True
    Me.lblInstitucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblInstitucion.Location = New System.Drawing.Point(14, 542)
    Me.lblInstitucion.Name = "lblInstitucion"
    Me.lblInstitucion.Size = New System.Drawing.Size(73, 15)
    Me.lblInstitucion.TabIndex = 8
    Me.lblInstitucion.Text = "Institución"
    '
    'txtInstitucion
    '
    Me.txtInstitucion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtInstitucion.BackColor = System.Drawing.SystemColors.Window
    Me.txtInstitucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtInstitucion.Location = New System.Drawing.Point(93, 535)
    Me.txtInstitucion.Name = "txtInstitucion"
    Me.txtInstitucion.ReadOnly = True
    Me.txtInstitucion.Size = New System.Drawing.Size(100, 22)
    Me.txtInstitucion.TabIndex = 9
    Me.txtInstitucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'lblCOPAFA
    '
    Me.lblCOPAFA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblCOPAFA.AutoSize = True
    Me.lblCOPAFA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCOPAFA.Location = New System.Drawing.Point(208, 542)
    Me.lblCOPAFA.Name = "lblCOPAFA"
    Me.lblCOPAFA.Size = New System.Drawing.Size(59, 15)
    Me.lblCOPAFA.TabIndex = 8
    Me.lblCOPAFA.Text = "COPAFA"
    '
    'txtCOPAFA
    '
    Me.txtCOPAFA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtCOPAFA.BackColor = System.Drawing.SystemColors.Window
    Me.txtCOPAFA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCOPAFA.Location = New System.Drawing.Point(273, 535)
    Me.txtCOPAFA.Name = "txtCOPAFA"
    Me.txtCOPAFA.ReadOnly = True
    Me.txtCOPAFA.Size = New System.Drawing.Size(100, 22)
    Me.txtCOPAFA.TabIndex = 9
    Me.txtCOPAFA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'frmListadoPagosBanco
    '
    Me.AcceptButton = Me.btnBuscar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(850, 597)
    Me.Controls.Add(Me.lblCuenta)
    Me.Controls.Add(Me.cboCuenta)
    Me.Controls.Add(Me.cboEntidadFinanciera)
    Me.Controls.Add(Me.lblEntidadFinanciera)
    Me.Controls.Add(Me.dtpFecha)
    Me.Controls.Add(Me.lblFechaVoucher)
    Me.Controls.Add(Me.txtCOPAFA)
    Me.Controls.Add(Me.lblCOPAFA)
    Me.Controls.Add(Me.txtInstitucion)
    Me.Controls.Add(Me.lblInstitucion)
    Me.Controls.Add(Me.txtTotalRecaudado)
    Me.Controls.Add(Me.lblTotalRecaudado)
    Me.Controls.Add(Me.btnBuscar)
    Me.Controls.Add(Me.btnImprimir)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.dgvDocumentos)
    Me.Name = "frmListadoPagosBanco"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Listado de pagos realizados en cuenta recaudador"
    CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents dgvDocumentos As System.Windows.Forms.DataGridView
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents lblTotalRecaudado As System.Windows.Forms.Label
  Friend WithEvents txtTotalRecaudado As System.Windows.Forms.TextBox
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
  Friend WithEvents btnImprimir As System.Windows.Forms.Button
  Friend WithEvents lblCuenta As System.Windows.Forms.Label
  Friend WithEvents cboCuenta As System.Windows.Forms.ComboBox
  Friend WithEvents cboEntidadFinanciera As System.Windows.Forms.ComboBox
  Friend WithEvents lblEntidadFinanciera As System.Windows.Forms.Label
  Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
  Friend WithEvents lblFechaVoucher As System.Windows.Forms.Label
  Friend WithEvents cdCodigoAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Persona As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdVoucher As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdMonto As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents lblInstitucion As System.Windows.Forms.Label
  Friend WithEvents txtInstitucion As System.Windows.Forms.TextBox
  Friend WithEvents lblCOPAFA As System.Windows.Forms.Label
  Friend WithEvents txtCOPAFA As System.Windows.Forms.TextBox
End Class
