<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarCronogramaPago
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.dgvCronograma = New System.Windows.Forms.DataGridView()
    Me.lblAnio = New System.Windows.Forms.Label()
    Me.btnListar = New System.Windows.Forms.Button()
    Me.gbCronograma = New System.Windows.Forms.GroupBox()
    Me.cboAnio = New System.Windows.Forms.ComboBox()
    Me.cdDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btnModificar = New System.Windows.Forms.Button()
    Me.lblDescripcion = New System.Windows.Forms.Label()
    Me.gbFecha = New System.Windows.Forms.GroupBox()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.txtDescripcion = New System.Windows.Forms.TextBox()
    Me.lblFecha = New System.Windows.Forms.Label()
    Me.btnActualizar = New System.Windows.Forms.Button()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
    CType(Me.dgvCronograma, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbCronograma.SuspendLayout()
    Me.gbFecha.SuspendLayout()
    Me.SuspendLayout()
    '
    'dgvCronograma
    '
    Me.dgvCronograma.AllowUserToAddRows = False
    Me.dgvCronograma.AllowUserToDeleteRows = False
    Me.dgvCronograma.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.dgvCronograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvCronograma.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdDescripcion, Me.cdFecha})
    Me.dgvCronograma.Location = New System.Drawing.Point(15, 56)
    Me.dgvCronograma.MultiSelect = False
    Me.dgvCronograma.Name = "dgvCronograma"
    Me.dgvCronograma.ReadOnly = True
    Me.dgvCronograma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvCronograma.Size = New System.Drawing.Size(362, 357)
    Me.dgvCronograma.TabIndex = 3
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Location = New System.Drawing.Point(15, 30)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(26, 13)
    Me.lblAnio.TabIndex = 0
    Me.lblAnio.Text = "Año"
    '
    'btnListar
    '
    Me.btnListar.Location = New System.Drawing.Point(222, 20)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(75, 23)
    Me.btnListar.TabIndex = 2
    Me.btnListar.Text = "Listar"
    Me.btnListar.UseVisualStyleBackColor = True
    '
    'gbCronograma
    '
    Me.gbCronograma.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.gbCronograma.Controls.Add(Me.cboAnio)
    Me.gbCronograma.Controls.Add(Me.lblAnio)
    Me.gbCronograma.Controls.Add(Me.btnModificar)
    Me.gbCronograma.Controls.Add(Me.btnListar)
    Me.gbCronograma.Controls.Add(Me.dgvCronograma)
    Me.gbCronograma.Location = New System.Drawing.Point(12, 12)
    Me.gbCronograma.Name = "gbCronograma"
    Me.gbCronograma.Size = New System.Drawing.Size(403, 458)
    Me.gbCronograma.TabIndex = 0
    Me.gbCronograma.TabStop = False
    Me.gbCronograma.Text = "Cronograma de pagos"
    '
    'cboAnio
    '
    Me.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAnio.FormattingEnabled = True
    Me.cboAnio.Location = New System.Drawing.Point(47, 22)
    Me.cboAnio.Name = "cboAnio"
    Me.cboAnio.Size = New System.Drawing.Size(138, 21)
    Me.cboAnio.TabIndex = 1
    '
    'cdDescripcion
    '
    Me.cdDescripcion.DataPropertyName = "Descripcion"
    Me.cdDescripcion.HeaderText = "Descripción"
    Me.cdDescripcion.Name = "cdDescripcion"
    Me.cdDescripcion.ReadOnly = True
    Me.cdDescripcion.Width = 200
    '
    'cdFecha
    '
    Me.cdFecha.DataPropertyName = "Fecha"
    Me.cdFecha.HeaderText = "Fecha"
    Me.cdFecha.Name = "cdFecha"
    Me.cdFecha.ReadOnly = True
    '
    'btnModificar
    '
    Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnModificar.Location = New System.Drawing.Point(15, 422)
    Me.btnModificar.Name = "btnModificar"
    Me.btnModificar.Size = New System.Drawing.Size(89, 30)
    Me.btnModificar.TabIndex = 4
    Me.btnModificar.Text = "Modificar"
    Me.btnModificar.UseVisualStyleBackColor = True
    '
    'lblDescripcion
    '
    Me.lblDescripcion.AutoSize = True
    Me.lblDescripcion.Location = New System.Drawing.Point(29, 56)
    Me.lblDescripcion.Name = "lblDescripcion"
    Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
    Me.lblDescripcion.TabIndex = 0
    Me.lblDescripcion.Text = "Descripción"
    '
    'gbFecha
    '
    Me.gbFecha.Controls.Add(Me.dtpFecha)
    Me.gbFecha.Controls.Add(Me.btnCancelar)
    Me.gbFecha.Controls.Add(Me.btnActualizar)
    Me.gbFecha.Controls.Add(Me.txtDescripcion)
    Me.gbFecha.Controls.Add(Me.lblFecha)
    Me.gbFecha.Controls.Add(Me.lblDescripcion)
    Me.gbFecha.Enabled = False
    Me.gbFecha.Location = New System.Drawing.Point(421, 12)
    Me.gbFecha.Name = "gbFecha"
    Me.gbFecha.Size = New System.Drawing.Size(328, 240)
    Me.gbFecha.TabIndex = 1
    Me.gbFecha.TabStop = False
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.Location = New System.Drawing.Point(632, 417)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(117, 53)
    Me.btnCerrar.TabIndex = 2
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.UseVisualStyleBackColor = True
    '
    'txtDescripcion
    '
    Me.txtDescripcion.Location = New System.Drawing.Point(107, 49)
    Me.txtDescripcion.Name = "txtDescripcion"
    Me.txtDescripcion.Size = New System.Drawing.Size(204, 20)
    Me.txtDescripcion.TabIndex = 1
    '
    'lblFecha
    '
    Me.lblFecha.AutoSize = True
    Me.lblFecha.Location = New System.Drawing.Point(29, 123)
    Me.lblFecha.Name = "lblFecha"
    Me.lblFecha.Size = New System.Drawing.Size(37, 13)
    Me.lblFecha.TabIndex = 2
    Me.lblFecha.Text = "Fecha"
    '
    'btnActualizar
    '
    Me.btnActualizar.Location = New System.Drawing.Point(129, 192)
    Me.btnActualizar.Name = "btnActualizar"
    Me.btnActualizar.Size = New System.Drawing.Size(88, 32)
    Me.btnActualizar.TabIndex = 4
    Me.btnActualizar.Text = "Actualizar"
    Me.btnActualizar.UseVisualStyleBackColor = True
    '
    'btnCancelar
    '
    Me.btnCancelar.Location = New System.Drawing.Point(223, 192)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(88, 32)
    Me.btnCancelar.TabIndex = 5
    Me.btnCancelar.Text = "Cancelar"
    Me.btnCancelar.UseVisualStyleBackColor = True
    '
    'dtpFecha
    '
    Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFecha.Location = New System.Drawing.Point(107, 116)
    Me.dtpFecha.Name = "dtpFecha"
    Me.dtpFecha.Size = New System.Drawing.Size(111, 20)
    Me.dtpFecha.TabIndex = 3
    '
    'frmModificarCronogramaPago
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(792, 482)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.gbFecha)
    Me.Controls.Add(Me.gbCronograma)
    Me.Name = "frmModificarCronogramaPago"
    Me.Text = "Cronograma de pagos"
    CType(Me.dgvCronograma, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbCronograma.ResumeLayout(False)
    Me.gbCronograma.PerformLayout()
    Me.gbFecha.ResumeLayout(False)
    Me.gbFecha.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents dgvCronograma As System.Windows.Forms.DataGridView
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents gbCronograma As System.Windows.Forms.GroupBox
  Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
  Friend WithEvents cdDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdFecha As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnModificar As System.Windows.Forms.Button
  Friend WithEvents lblDescripcion As System.Windows.Forms.Label
  Friend WithEvents gbFecha As System.Windows.Forms.GroupBox
  Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnActualizar As System.Windows.Forms.Button
  Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
  Friend WithEvents lblFecha As System.Windows.Forms.Label
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
End Class
