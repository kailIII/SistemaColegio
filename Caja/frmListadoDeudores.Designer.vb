<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoDeudores
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
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.btnExportar = New System.Windows.Forms.Button
    Me.colSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.colMora = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.colPagado = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.colVencido = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.colDeuda = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.lblFecha = New System.Windows.Forms.Label
    Me.btnListar = New System.Windows.Forms.Button
    Me.ColAsignado = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ColNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.dgvAlumnosDeudores = New System.Windows.Forms.DataGridView
    Me.colSeccion = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.dtFecha = New System.Windows.Forms.DateTimePicker
    Me.GroupBox1.SuspendLayout()
    CType(Me.dgvAlumnosDeudores, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnExportar
    '
    Me.btnExportar.BackColor = System.Drawing.Color.White
    Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnExportar.Location = New System.Drawing.Point(722, 439)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(110, 52)
    Me.btnExportar.TabIndex = 40
    Me.btnExportar.Text = "&Exportar"
    Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnExportar.UseVisualStyleBackColor = False
    '
    'colSaldo
    '
    DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.colSaldo.DefaultCellStyle = DataGridViewCellStyle7
    Me.colSaldo.HeaderText = "Saldo"
    Me.colSaldo.Name = "colSaldo"
    Me.colSaldo.ReadOnly = True
    Me.colSaldo.Width = 70
    '
    'colMora
    '
    Me.colMora.DataPropertyName = "MontoMora"
    DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.colMora.DefaultCellStyle = DataGridViewCellStyle8
    Me.colMora.HeaderText = "Mora"
    Me.colMora.Name = "colMora"
    Me.colMora.ReadOnly = True
    Me.colMora.Width = 70
    '
    'colPagado
    '
    Me.colPagado.DataPropertyName = "MontoPagado"
    DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
    Me.colPagado.DefaultCellStyle = DataGridViewCellStyle9
    Me.colPagado.HeaderText = "Pagado"
    Me.colPagado.Name = "colPagado"
    Me.colPagado.ReadOnly = True
    Me.colPagado.Width = 70
    '
    'colVencido
    '
    Me.colVencido.DataPropertyName = "MontoVencido"
    DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
    Me.colVencido.DefaultCellStyle = DataGridViewCellStyle10
    Me.colVencido.HeaderText = "Vencido"
    Me.colVencido.Name = "colVencido"
    Me.colVencido.ReadOnly = True
    Me.colVencido.Width = 70
    '
    'colDeuda
    '
    DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.colDeuda.DefaultCellStyle = DataGridViewCellStyle11
    Me.colDeuda.HeaderText = "Deuda"
    Me.colDeuda.Name = "colDeuda"
    Me.colDeuda.ReadOnly = True
    Me.colDeuda.Width = 70
    '
    'lblFecha
    '
    Me.lblFecha.AutoSize = True
    Me.lblFecha.Location = New System.Drawing.Point(18, 71)
    Me.lblFecha.Name = "lblFecha"
    Me.lblFecha.Size = New System.Drawing.Size(37, 13)
    Me.lblFecha.TabIndex = 43
    Me.lblFecha.Text = "Fecha"
    '
    'btnListar
    '
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnListar.Location = New System.Drawing.Point(249, 32)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(110, 52)
    Me.btnListar.TabIndex = 41
    Me.btnListar.Text = "&Listar"
    Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnListar.UseVisualStyleBackColor = False
    '
    'ColAsignado
    '
    Me.ColAsignado.DataPropertyName = "Monto"
    DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
    Me.ColAsignado.DefaultCellStyle = DataGridViewCellStyle12
    Me.ColAsignado.HeaderText = "Asignado"
    Me.ColAsignado.Name = "ColAsignado"
    Me.ColAsignado.ReadOnly = True
    Me.ColAsignado.Width = 70
    '
    'ColNombre
    '
    Me.ColNombre.DataPropertyName = "NombreCompleto"
    Me.ColNombre.HeaderText = "Apellidos y Nombres"
    Me.ColNombre.Name = "ColNombre"
    Me.ColNombre.ReadOnly = True
    Me.ColNombre.Width = 300
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(838, 439)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 39
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.dgvAlumnosDeudores)
    Me.GroupBox1.Location = New System.Drawing.Point(12, 90)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(936, 335)
    Me.GroupBox1.TabIndex = 38
    Me.GroupBox1.TabStop = False
    '
    'dgvAlumnosDeudores
    '
    Me.dgvAlumnosDeudores.AllowUserToAddRows = False
    Me.dgvAlumnosDeudores.AllowUserToDeleteRows = False
    Me.dgvAlumnosDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvAlumnosDeudores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSeccion, Me.ColNombre, Me.ColAsignado, Me.colVencido, Me.colPagado, Me.colSaldo, Me.colMora, Me.colDeuda})
    Me.dgvAlumnosDeudores.Location = New System.Drawing.Point(9, 19)
    Me.dgvAlumnosDeudores.Name = "dgvAlumnosDeudores"
    Me.dgvAlumnosDeudores.ReadOnly = True
    Me.dgvAlumnosDeudores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvAlumnosDeudores.Size = New System.Drawing.Size(913, 307)
    Me.dgvAlumnosDeudores.TabIndex = 9
    '
    'colSeccion
    '
    Me.colSeccion.DataPropertyName = "NivelGSeccion"
    Me.colSeccion.HeaderText = "Nivel Grado Seccion"
    Me.colSeccion.Name = "colSeccion"
    Me.colSeccion.ReadOnly = True
    Me.colSeccion.Width = 150
    '
    'dtFecha
    '
    Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtFecha.Location = New System.Drawing.Point(81, 67)
    Me.dtFecha.Name = "dtFecha"
    Me.dtFecha.Size = New System.Drawing.Size(143, 20)
    Me.dtFecha.TabIndex = 42
    '
    'frmListadoDeudores
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(960, 503)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.lblFecha)
    Me.Controls.Add(Me.btnListar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.dtFecha)
    Me.Name = "frmListadoDeudores"
    Me.Text = "Listado Deudores"
    Me.GroupBox1.ResumeLayout(False)
    CType(Me.dgvAlumnosDeudores, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents colSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colMora As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colPagado As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colVencido As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colDeuda As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents lblFecha As System.Windows.Forms.Label
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents ColAsignado As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ColNombre As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents dgvAlumnosDeudores As System.Windows.Forms.DataGridView
  Friend WithEvents colSeccion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
End Class
