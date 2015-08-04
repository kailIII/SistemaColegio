<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionBeneficioAlumno
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
    Me.lblAlumno = New System.Windows.Forms.Label()
    Me.txtNombre = New System.Windows.Forms.TextBox()
    Me.lblAnio = New System.Windows.Forms.Label()
    Me.dgvBeneficios = New System.Windows.Forms.DataGridView()
    Me.cdMotivo = New System.Windows.Forms.DataGridViewComboBoxColumn()
    Me.cdDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdVigencia = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.cdFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.btnListar = New System.Windows.Forms.Button()
    Me.btnAsignar = New System.Windows.Forms.Button()
    Me.cboAnio = New System.Windows.Forms.ComboBox()
    CType(Me.dgvBeneficios, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblAlumno
    '
    Me.lblAlumno.AutoSize = True
    Me.lblAlumno.Location = New System.Drawing.Point(12, 81)
    Me.lblAlumno.Name = "lblAlumno"
    Me.lblAlumno.Size = New System.Drawing.Size(42, 13)
    Me.lblAlumno.TabIndex = 2
    Me.lblAlumno.Text = "Alumno"
    '
    'txtNombre
    '
    Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
    Me.txtNombre.Location = New System.Drawing.Point(63, 74)
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.ReadOnly = True
    Me.txtNombre.Size = New System.Drawing.Size(438, 20)
    Me.txtNombre.TabIndex = 3
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblAnio.Location = New System.Drawing.Point(12, 43)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(33, 17)
    Me.lblAnio.TabIndex = 0
    Me.lblAnio.Text = "&Año"
    '
    'dgvBeneficios
    '
    Me.dgvBeneficios.AllowUserToAddRows = False
    Me.dgvBeneficios.AllowUserToDeleteRows = False
    Me.dgvBeneficios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvBeneficios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdMotivo, Me.cdDescripcion, Me.cdVencimiento, Me.cdDescuento, Me.cdVigencia, Me.cdFecha})
    Me.dgvBeneficios.Location = New System.Drawing.Point(15, 135)
    Me.dgvBeneficios.Name = "dgvBeneficios"
    Me.dgvBeneficios.Size = New System.Drawing.Size(678, 261)
    Me.dgvBeneficios.TabIndex = 5
    '
    'cdMotivo
    '
    Me.cdMotivo.DataPropertyName = "Motivo"
    Me.cdMotivo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
    Me.cdMotivo.DisplayStyleForCurrentCellOnly = True
    Me.cdMotivo.HeaderText = "Motivo"
    Me.cdMotivo.Name = "cdMotivo"
    Me.cdMotivo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.cdMotivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.cdMotivo.Width = 150
    '
    'cdDescripcion
    '
    Me.cdDescripcion.DataPropertyName = "DescripcionPension"
    Me.cdDescripcion.HeaderText = "Descripción"
    Me.cdDescripcion.Name = "cdDescripcion"
    Me.cdDescripcion.ReadOnly = True
    Me.cdDescripcion.Width = 150
    '
    'cdVencimiento
    '
    Me.cdVencimiento.DataPropertyName = "FechaVencimiento"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle1.Format = "d"
    DataGridViewCellStyle1.NullValue = Nothing
    Me.cdVencimiento.DefaultCellStyle = DataGridViewCellStyle1
    Me.cdVencimiento.HeaderText = "Vencimiento"
    Me.cdVencimiento.Name = "cdVencimiento"
    Me.cdVencimiento.ReadOnly = True
    Me.cdVencimiento.Width = 80
    '
    'cdDescuento
    '
    Me.cdDescuento.DataPropertyName = "Descuento"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle2.Format = "N2"
    Me.cdDescuento.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdDescuento.HeaderText = "Descuento"
    Me.cdDescuento.Name = "cdDescuento"
    Me.cdDescuento.Width = 80
    '
    'cdVigencia
    '
    Me.cdVigencia.DataPropertyName = "Vigencia"
    Me.cdVigencia.HeaderText = "Vigencia"
    Me.cdVigencia.Name = "cdVigencia"
    Me.cdVigencia.Width = 60
    '
    'cdFecha
    '
    Me.cdFecha.DataPropertyName = "Fecha"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle3.Format = "d"
    DataGridViewCellStyle3.NullValue = Nothing
    Me.cdFecha.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdFecha.HeaderText = "Fecha"
    Me.cdFecha.Name = "cdFecha"
    Me.cdFecha.Width = 80
    '
    'btnCerrar
    '
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Location = New System.Drawing.Point(598, 402)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(95, 36)
    Me.btnCerrar.TabIndex = 7
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.UseVisualStyleBackColor = True
    '
    'btnListar
    '
    Me.btnListar.Location = New System.Drawing.Point(512, 74)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(115, 44)
    Me.btnListar.TabIndex = 4
    Me.btnListar.Text = "&Listar"
    Me.btnListar.UseVisualStyleBackColor = True
    '
    'btnAsignar
    '
    Me.btnAsignar.Location = New System.Drawing.Point(15, 402)
    Me.btnAsignar.Name = "btnAsignar"
    Me.btnAsignar.Size = New System.Drawing.Size(95, 36)
    Me.btnAsignar.TabIndex = 6
    Me.btnAsignar.Text = "A&signar"
    Me.btnAsignar.UseVisualStyleBackColor = True
    '
    'cboAnio
    '
    Me.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAnio.FormattingEnabled = True
    Me.cboAnio.Location = New System.Drawing.Point(63, 39)
    Me.cboAnio.Name = "cboAnio"
    Me.cboAnio.Size = New System.Drawing.Size(107, 21)
    Me.cboAnio.TabIndex = 1
    '
    'frmGestionBeneficioAlumno
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCerrar
    Me.ClientSize = New System.Drawing.Size(705, 450)
    Me.Controls.Add(Me.cboAnio)
    Me.Controls.Add(Me.btnAsignar)
    Me.Controls.Add(Me.btnListar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.dgvBeneficios)
    Me.Controls.Add(Me.lblAnio)
    Me.Controls.Add(Me.lblAlumno)
    Me.Controls.Add(Me.txtNombre)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmGestionBeneficioAlumno"
    Me.Text = "Gestión de beneficios"
    CType(Me.dgvBeneficios, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblAlumno As System.Windows.Forms.Label
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents dgvBeneficios As System.Windows.Forms.DataGridView
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents btnAsignar As System.Windows.Forms.Button
  Friend WithEvents cdMotivo As System.Windows.Forms.DataGridViewComboBoxColumn
  Friend WithEvents cdDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdVencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDescuento As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdVigencia As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents cdFecha As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
End Class
