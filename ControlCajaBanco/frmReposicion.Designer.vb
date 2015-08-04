<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReposicion
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
    Me.gbMantenimiento = New System.Windows.Forms.GroupBox()
    Me.cboPersonal = New System.Windows.Forms.ComboBox()
    Me.lblPersonal = New System.Windows.Forms.Label()
    Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
    Me.lblFecha = New System.Windows.Forms.Label()
    Me.nudMonto = New System.Windows.Forms.NumericUpDown()
    Me.lblMonto = New System.Windows.Forms.Label()
    Me.btncancelar = New System.Windows.Forms.Button()
    Me.btnRegistrar = New System.Windows.Forms.Button()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.gbListado = New System.Windows.Forms.GroupBox()
    Me.btnNuevo = New System.Windows.Forms.Button()
    Me.btnListar = New System.Windows.Forms.Button()
    Me.dgvReposicion = New System.Windows.Forms.DataGridView()
    Me.btnAnular = New System.Windows.Forms.Button()
    Me.btnEditar = New System.Windows.Forms.Button()
    Me.cdFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdPersonal = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.gbMantenimiento.SuspendLayout()
    CType(Me.nudMonto, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbListado.SuspendLayout()
    CType(Me.dgvReposicion, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'gbMantenimiento
    '
    Me.gbMantenimiento.Controls.Add(Me.cboPersonal)
    Me.gbMantenimiento.Controls.Add(Me.lblPersonal)
    Me.gbMantenimiento.Controls.Add(Me.dtpFecha)
    Me.gbMantenimiento.Controls.Add(Me.lblFecha)
    Me.gbMantenimiento.Controls.Add(Me.nudMonto)
    Me.gbMantenimiento.Controls.Add(Me.lblMonto)
    Me.gbMantenimiento.Controls.Add(Me.btncancelar)
    Me.gbMantenimiento.Controls.Add(Me.btnRegistrar)
    Me.gbMantenimiento.Enabled = False
    Me.gbMantenimiento.Location = New System.Drawing.Point(21, 27)
    Me.gbMantenimiento.Name = "gbMantenimiento"
    Me.gbMantenimiento.Size = New System.Drawing.Size(276, 277)
    Me.gbMantenimiento.TabIndex = 0
    Me.gbMantenimiento.TabStop = False
    '
    'cboPersonal
    '
    Me.cboPersonal.Enabled = False
    Me.cboPersonal.FormattingEnabled = True
    Me.cboPersonal.Location = New System.Drawing.Point(127, 146)
    Me.cboPersonal.Name = "cboPersonal"
    Me.cboPersonal.Size = New System.Drawing.Size(136, 21)
    Me.cboPersonal.TabIndex = 5
    '
    'lblPersonal
    '
    Me.lblPersonal.AutoSize = True
    Me.lblPersonal.Enabled = False
    Me.lblPersonal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPersonal.Location = New System.Drawing.Point(22, 146)
    Me.lblPersonal.Name = "lblPersonal"
    Me.lblPersonal.Size = New System.Drawing.Size(85, 15)
    Me.lblPersonal.TabIndex = 4
    Me.lblPersonal.Text = "Entregado por"
    '
    'dtpFecha
    '
    Me.dtpFecha.Enabled = False
    Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFecha.Location = New System.Drawing.Point(90, 48)
    Me.dtpFecha.Name = "dtpFecha"
    Me.dtpFecha.Size = New System.Drawing.Size(109, 20)
    Me.dtpFecha.TabIndex = 1
    '
    'lblFecha
    '
    Me.lblFecha.AutoSize = True
    Me.lblFecha.Enabled = False
    Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFecha.Location = New System.Drawing.Point(22, 48)
    Me.lblFecha.Name = "lblFecha"
    Me.lblFecha.Size = New System.Drawing.Size(41, 15)
    Me.lblFecha.TabIndex = 0
    Me.lblFecha.Text = "Fecha"
    '
    'nudMonto
    '
    Me.nudMonto.Enabled = False
    Me.nudMonto.Location = New System.Drawing.Point(90, 92)
    Me.nudMonto.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
    Me.nudMonto.Name = "nudMonto"
    Me.nudMonto.Size = New System.Drawing.Size(92, 20)
    Me.nudMonto.TabIndex = 3
    '
    'lblMonto
    '
    Me.lblMonto.AutoSize = True
    Me.lblMonto.Enabled = False
    Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMonto.Location = New System.Drawing.Point(22, 92)
    Me.lblMonto.Name = "lblMonto"
    Me.lblMonto.Size = New System.Drawing.Size(42, 15)
    Me.lblMonto.TabIndex = 2
    Me.lblMonto.Text = "Monto"
    '
    'btncancelar
    '
    Me.btncancelar.BackColor = System.Drawing.Color.White
    Me.btncancelar.Enabled = False
    Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btncancelar.Location = New System.Drawing.Point(153, 203)
    Me.btncancelar.Name = "btncancelar"
    Me.btncancelar.Size = New System.Drawing.Size(110, 52)
    Me.btncancelar.TabIndex = 7
    Me.btncancelar.Text = "&Cancelar"
    Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btncancelar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Enabled = False
    Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(21, 203)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
    Me.btnRegistrar.TabIndex = 6
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(626, 383)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 2
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'gbListado
    '
    Me.gbListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbListado.Controls.Add(Me.btnNuevo)
    Me.gbListado.Controls.Add(Me.btnListar)
    Me.gbListado.Controls.Add(Me.dgvReposicion)
    Me.gbListado.Controls.Add(Me.btnAnular)
    Me.gbListado.Controls.Add(Me.btnEditar)
    Me.gbListado.Location = New System.Drawing.Point(327, 27)
    Me.gbListado.Name = "gbListado"
    Me.gbListado.Size = New System.Drawing.Size(409, 324)
    Me.gbListado.TabIndex = 1
    Me.gbListado.TabStop = False
    '
    'btnNuevo
    '
    Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnNuevo.BackColor = System.Drawing.Color.White
    Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnNuevo.Location = New System.Drawing.Point(28, 250)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(108, 52)
    Me.btnNuevo.TabIndex = 2
    Me.btnNuevo.Text = "&Nuevo"
    Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnNuevo.UseVisualStyleBackColor = False
    '
    'btnListar
    '
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnListar.Location = New System.Drawing.Point(15, 16)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(110, 52)
    Me.btnListar.TabIndex = 0
    Me.btnListar.Text = "&Listar"
    Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnListar.UseVisualStyleBackColor = False
    '
    'dgvReposicion
    '
    Me.dgvReposicion.AllowUserToAddRows = False
    Me.dgvReposicion.AllowUserToDeleteRows = False
    Me.dgvReposicion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvReposicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvReposicion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdFecha, Me.cdPersonal, Me.cdMonto})
    Me.dgvReposicion.Location = New System.Drawing.Point(15, 80)
    Me.dgvReposicion.MultiSelect = False
    Me.dgvReposicion.Name = "dgvReposicion"
    Me.dgvReposicion.ReadOnly = True
    Me.dgvReposicion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvReposicion.Size = New System.Drawing.Size(367, 148)
    Me.dgvReposicion.TabIndex = 1
    '
    'btnAnular
    '
    Me.btnAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnAnular.BackColor = System.Drawing.Color.White
    Me.btnAnular.Enabled = False
    Me.btnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAnular.Location = New System.Drawing.Point(284, 250)
    Me.btnAnular.Name = "btnAnular"
    Me.btnAnular.Size = New System.Drawing.Size(110, 52)
    Me.btnAnular.TabIndex = 4
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
    Me.btnEditar.Location = New System.Drawing.Point(159, 250)
    Me.btnEditar.Name = "btnEditar"
    Me.btnEditar.Size = New System.Drawing.Size(108, 52)
    Me.btnEditar.TabIndex = 3
    Me.btnEditar.Text = "&Editar"
    Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnEditar.UseVisualStyleBackColor = False
    '
    'cdFecha
    '
    Me.cdFecha.DataPropertyName = "fecha"
    Me.cdFecha.HeaderText = "Fecha"
    Me.cdFecha.Name = "cdFecha"
    Me.cdFecha.ReadOnly = True
    Me.cdFecha.Width = 120
    '
    'cdPersonal
    '
    Me.cdPersonal.DataPropertyName = "nombrePersonal"
    Me.cdPersonal.HeaderText = "Entregado por"
    Me.cdPersonal.Name = "cdPersonal"
    Me.cdPersonal.ReadOnly = True
    Me.cdPersonal.Width = 200
    '
    'cdMonto
    '
    Me.cdMonto.DataPropertyName = "monto"
    Me.cdMonto.HeaderText = "Monto"
    Me.cdMonto.Name = "cdMonto"
    Me.cdMonto.ReadOnly = True
    Me.cdMonto.Width = 80
    '
    'frmReposicion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(776, 447)
    Me.Controls.Add(Me.gbListado)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.gbMantenimiento)
    Me.Name = "frmReposicion"
    Me.Text = "Reposición de Caja"
    Me.gbMantenimiento.ResumeLayout(False)
    Me.gbMantenimiento.PerformLayout()
    CType(Me.nudMonto, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbListado.ResumeLayout(False)
    CType(Me.dgvReposicion, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents gbMantenimiento As System.Windows.Forms.GroupBox
  Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
  Friend WithEvents lblFecha As System.Windows.Forms.Label
  Friend WithEvents nudMonto As System.Windows.Forms.NumericUpDown
  Friend WithEvents lblMonto As System.Windows.Forms.Label
  Friend WithEvents btncancelar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents cboPersonal As System.Windows.Forms.ComboBox
  Friend WithEvents lblPersonal As System.Windows.Forms.Label
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents gbListado As System.Windows.Forms.GroupBox
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents dgvReposicion As System.Windows.Forms.DataGridView
  Friend WithEvents btnAnular As System.Windows.Forms.Button
  Friend WithEvents btnEditar As System.Windows.Forms.Button
  Friend WithEvents cdFecha As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdPersonal As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdMonto As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
