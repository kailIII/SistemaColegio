<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumenPagosColegio
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.btnExportar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.dgvConsolidadoPagos = New System.Windows.Forms.DataGridView
    Me.cdMotivo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnListar = New System.Windows.Forms.Button
    Me.lblInicio = New System.Windows.Forms.Label
    Me.dtpInicio = New System.Windows.Forms.DateTimePicker
    Me.lblFin = New System.Windows.Forms.Label
    Me.dtpFin = New System.Windows.Forms.DateTimePicker
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
    Me.btnExportar.TabIndex = 6
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
    Me.btnCerrar.TabIndex = 7
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
    Me.dgvConsolidadoPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdMotivo, Me.cdTotal})
    Me.dgvConsolidadoPagos.Location = New System.Drawing.Point(23, 83)
    Me.dgvConsolidadoPagos.MultiSelect = False
    Me.dgvConsolidadoPagos.Name = "dgvConsolidadoPagos"
    Me.dgvConsolidadoPagos.ReadOnly = True
    Me.dgvConsolidadoPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvConsolidadoPagos.Size = New System.Drawing.Size(646, 339)
    Me.dgvConsolidadoPagos.TabIndex = 5
    '
    'cdMotivo
    '
    Me.cdMotivo.DataPropertyName = "Descripcion"
    Me.cdMotivo.HeaderText = "Descripción"
    Me.cdMotivo.Name = "cdMotivo"
    Me.cdMotivo.ReadOnly = True
    Me.cdMotivo.Width = 250
    '
    'cdTotal
    '
    Me.cdTotal.DataPropertyName = "Total"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle1.Format = "N2"
    DataGridViewCellStyle1.NullValue = Nothing
    Me.cdTotal.DefaultCellStyle = DataGridViewCellStyle1
    Me.cdTotal.HeaderText = "Total"
    Me.cdTotal.Name = "cdTotal"
    Me.cdTotal.ReadOnly = True
    '
    'btnListar
    '
    Me.btnListar.Location = New System.Drawing.Point(320, 16)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(113, 52)
    Me.btnListar.TabIndex = 4
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
    'frmResumenPagosColegio
    '
    Me.AcceptButton = Me.btnListar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(681, 492)
    Me.Controls.Add(Me.dtpFin)
    Me.Controls.Add(Me.lblFin)
    Me.Controls.Add(Me.dtpInicio)
    Me.Controls.Add(Me.lblInicio)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.dgvConsolidadoPagos)
    Me.Controls.Add(Me.btnListar)
    Me.Name = "frmResumenPagosColegio"
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
  Friend WithEvents cdMotivo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdTotal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
