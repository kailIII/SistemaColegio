<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportePagosServicio
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
    Me.btnExportar = New System.Windows.Forms.Button()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.dgvConsolidadoPagos = New System.Windows.Forms.DataGridView()
    Me.cdCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdSeccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdPersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btnListar = New System.Windows.Forms.Button()
    Me.lblInicio = New System.Windows.Forms.Label()
    Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
    Me.lblFin = New System.Windows.Forms.Label()
    Me.dtpFin = New System.Windows.Forms.DateTimePicker()
    Me.lblServicio = New System.Windows.Forms.Label()
    Me.cboServicio = New System.Windows.Forms.ComboBox()
    Me.lblTotal = New System.Windows.Forms.Label()
    Me.txtTotal = New System.Windows.Forms.TextBox()
    CType(Me.dgvConsolidadoPagos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnExportar
    '
    Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnExportar.BackColor = System.Drawing.Color.White
    Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnExportar.Location = New System.Drawing.Point(434, 428)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(110, 52)
    Me.btnExportar.TabIndex = 8
    Me.btnExportar.Text = "&Exportar"
    Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnExportar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(559, 428)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 9
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'dgvConsolidadoPagos
    '
    Me.dgvConsolidadoPagos.AllowUserToAddRows = False
    Me.dgvConsolidadoPagos.AllowUserToDeleteRows = False
    Me.dgvConsolidadoPagos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvConsolidadoPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvConsolidadoPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdCodigo, Me.cdSeccion, Me.cdPersona, Me.cdDocumento, Me.cdFecha, Me.cdDescripcion, Me.cdMonto})
    Me.dgvConsolidadoPagos.Location = New System.Drawing.Point(23, 127)
    Me.dgvConsolidadoPagos.MultiSelect = False
    Me.dgvConsolidadoPagos.Name = "dgvConsolidadoPagos"
    Me.dgvConsolidadoPagos.ReadOnly = True
    Me.dgvConsolidadoPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvConsolidadoPagos.Size = New System.Drawing.Size(646, 295)
    Me.dgvConsolidadoPagos.TabIndex = 7
    '
    'cdCodigo
    '
    Me.cdCodigo.DataPropertyName = "CodigoAlumno"
    Me.cdCodigo.HeaderText = "Código"
    Me.cdCodigo.Name = "cdCodigo"
    Me.cdCodigo.ReadOnly = True
    '
    'cdSeccion
    '
    Me.cdSeccion.DataPropertyName = "Seccion"
    Me.cdSeccion.HeaderText = "Sección"
    Me.cdSeccion.Name = "cdSeccion"
    Me.cdSeccion.ReadOnly = True
    Me.cdSeccion.Width = 80
    '
    'cdPersona
    '
    Me.cdPersona.DataPropertyName = "Persona"
    Me.cdPersona.HeaderText = "Persona"
    Me.cdPersona.Name = "cdPersona"
    Me.cdPersona.ReadOnly = True
    Me.cdPersona.Width = 250
    '
    'cdDocumento
    '
    Me.cdDocumento.DataPropertyName = "Documento"
    Me.cdDocumento.HeaderText = "Documento"
    Me.cdDocumento.Name = "cdDocumento"
    Me.cdDocumento.ReadOnly = True
    Me.cdDocumento.Width = 110
    '
    'cdFecha
    '
    Me.cdFecha.DataPropertyName = "Fecha"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle1.Format = "d"
    DataGridViewCellStyle1.NullValue = Nothing
    Me.cdFecha.DefaultCellStyle = DataGridViewCellStyle1
    Me.cdFecha.HeaderText = "Fecha"
    Me.cdFecha.Name = "cdFecha"
    Me.cdFecha.ReadOnly = True
    Me.cdFecha.Width = 110
    '
    'cdDescripcion
    '
    Me.cdDescripcion.DataPropertyName = "Descripcion"
    Me.cdDescripcion.HeaderText = "Descripción"
    Me.cdDescripcion.Name = "cdDescripcion"
    Me.cdDescripcion.ReadOnly = True
    Me.cdDescripcion.Width = 200
    '
    'cdMonto
    '
    Me.cdMonto.DataPropertyName = "Monto"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdMonto.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdMonto.HeaderText = "Monto"
    Me.cdMonto.Name = "cdMonto"
    Me.cdMonto.ReadOnly = True
    Me.cdMonto.Width = 80
    '
    'btnListar
    '
    Me.btnListar.Location = New System.Drawing.Point(400, 56)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(113, 52)
    Me.btnListar.TabIndex = 6
    Me.btnListar.Text = "&Listar"
    Me.btnListar.UseVisualStyleBackColor = True
    '
    'lblInicio
    '
    Me.lblInicio.AutoSize = True
    Me.lblInicio.Location = New System.Drawing.Point(20, 24)
    Me.lblInicio.Name = "lblInicio"
    Me.lblInicio.Size = New System.Drawing.Size(38, 13)
    Me.lblInicio.TabIndex = 0
    Me.lblInicio.Text = "&Desde"
    '
    'dtpInicio
    '
    Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpInicio.Location = New System.Drawing.Point(23, 48)
    Me.dtpInicio.Name = "dtpInicio"
    Me.dtpInicio.Size = New System.Drawing.Size(104, 20)
    Me.dtpInicio.TabIndex = 1
    '
    'lblFin
    '
    Me.lblFin.AutoSize = True
    Me.lblFin.Location = New System.Drawing.Point(187, 24)
    Me.lblFin.Name = "lblFin"
    Me.lblFin.Size = New System.Drawing.Size(35, 13)
    Me.lblFin.TabIndex = 2
    Me.lblFin.Text = "&Hasta"
    '
    'dtpFin
    '
    Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFin.Location = New System.Drawing.Point(190, 48)
    Me.dtpFin.Name = "dtpFin"
    Me.dtpFin.Size = New System.Drawing.Size(104, 20)
    Me.dtpFin.TabIndex = 3
    '
    'lblServicio
    '
    Me.lblServicio.AutoSize = True
    Me.lblServicio.Location = New System.Drawing.Point(20, 95)
    Me.lblServicio.Name = "lblServicio"
    Me.lblServicio.Size = New System.Drawing.Size(45, 13)
    Me.lblServicio.TabIndex = 4
    Me.lblServicio.Text = "Ser&vicio"
    '
    'cboServicio
    '
    Me.cboServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboServicio.FormattingEnabled = True
    Me.cboServicio.Location = New System.Drawing.Point(74, 87)
    Me.cboServicio.Name = "cboServicio"
    Me.cboServicio.Size = New System.Drawing.Size(302, 21)
    Me.cboServicio.TabIndex = 5
    '
    'lblTotal
    '
    Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblTotal.AutoSize = True
    Me.lblTotal.Location = New System.Drawing.Point(20, 448)
    Me.lblTotal.Name = "lblTotal"
    Me.lblTotal.Size = New System.Drawing.Size(31, 13)
    Me.lblTotal.TabIndex = 10
    Me.lblTotal.Text = "&Total"
    '
    'txtTotal
    '
    Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtTotal.Location = New System.Drawing.Point(74, 441)
    Me.txtTotal.Name = "txtTotal"
    Me.txtTotal.ReadOnly = True
    Me.txtTotal.Size = New System.Drawing.Size(100, 20)
    Me.txtTotal.TabIndex = 11
    '
    'frmReportePagosServicio
    '
    Me.AcceptButton = Me.btnListar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(681, 492)
    Me.Controls.Add(Me.txtTotal)
    Me.Controls.Add(Me.lblTotal)
    Me.Controls.Add(Me.cboServicio)
    Me.Controls.Add(Me.lblServicio)
    Me.Controls.Add(Me.dtpFin)
    Me.Controls.Add(Me.lblFin)
    Me.Controls.Add(Me.dtpInicio)
    Me.Controls.Add(Me.lblInicio)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.dgvConsolidadoPagos)
    Me.Controls.Add(Me.btnListar)
    Me.Name = "frmReportePagosServicio"
    Me.Text = "Resumen de pagos"
    CType(Me.dgvConsolidadoPagos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents dgvConsolidadoPagos As System.Windows.Forms.DataGridView
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents lblInicio As System.Windows.Forms.Label
  Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
  Friend WithEvents lblFin As System.Windows.Forms.Label
  Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
  Friend WithEvents lblServicio As System.Windows.Forms.Label
  Friend WithEvents cboServicio As System.Windows.Forms.ComboBox
  Friend WithEvents cdCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdSeccion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdPersona As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdFecha As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdMonto As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents lblTotal As System.Windows.Forms.Label
  Friend WithEvents txtTotal As System.Windows.Forms.TextBox
End Class
