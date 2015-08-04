<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBalancearSecciones
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
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.gbGrado = New System.Windows.Forms.GroupBox
    Me.lblGrado = New System.Windows.Forms.Label
    Me.cboGrado = New System.Windows.Forms.ComboBox
    Me.cboNivel = New System.Windows.Forms.ComboBox
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnActualizar = New System.Windows.Forms.Button
    Me.dgAlumnos = New System.Windows.Forms.DataGridView
    Me.cdNroOrden = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdSexo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdGrado = New System.Windows.Forms.DataGridViewComboBoxColumn
    Me.cdEstado = New System.Windows.Forms.DataGridViewCheckBoxColumn
    Me.dgGrados = New System.Windows.Forms.DataGridView
    Me.cdNumero = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdSeccion = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnListar = New System.Windows.Forms.Button
    Me.lblLeyenda = New System.Windows.Forms.Label
    Me.gbLeyenda = New System.Windows.Forms.GroupBox
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.lblMatAnulada = New System.Windows.Forms.Label
    Me.gbGrado.SuspendLayout()
    CType(Me.dgAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dgGrados, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbLeyenda.SuspendLayout()
    Me.SuspendLayout()
    '
    'gbGrado
    '
    Me.gbGrado.Controls.Add(Me.lblGrado)
    Me.gbGrado.Controls.Add(Me.cboGrado)
    Me.gbGrado.Controls.Add(Me.cboNivel)
    Me.gbGrado.Location = New System.Drawing.Point(12, 4)
    Me.gbGrado.Name = "gbGrado"
    Me.gbGrado.Size = New System.Drawing.Size(459, 51)
    Me.gbGrado.TabIndex = 6
    Me.gbGrado.TabStop = False
    '
    'lblGrado
    '
    Me.lblGrado.AutoSize = True
    Me.lblGrado.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblGrado.Location = New System.Drawing.Point(17, 21)
    Me.lblGrado.Name = "lblGrado"
    Me.lblGrado.Size = New System.Drawing.Size(44, 17)
    Me.lblGrado.TabIndex = 0
    Me.lblGrado.Text = "&Grado"
    '
    'cboGrado
    '
    Me.cboGrado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboGrado.FormattingEnabled = True
    Me.cboGrado.Location = New System.Drawing.Point(266, 17)
    Me.cboGrado.Name = "cboGrado"
    Me.cboGrado.Size = New System.Drawing.Size(171, 24)
    Me.cboGrado.TabIndex = 2
    '
    'cboNivel
    '
    Me.cboNivel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Location = New System.Drawing.Point(70, 17)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(171, 24)
    Me.cboNivel.TabIndex = 1
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(806, 606)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 50)
    Me.btnCerrar.TabIndex = 11
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnActualizar
    '
    Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnActualizar.BackColor = System.Drawing.Color.White
    Me.btnActualizar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnActualizar.Location = New System.Drawing.Point(806, 378)
    Me.btnActualizar.Name = "btnActualizar"
    Me.btnActualizar.Size = New System.Drawing.Size(110, 50)
    Me.btnActualizar.TabIndex = 10
    Me.btnActualizar.Text = "&Actualizar"
    Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnActualizar.UseVisualStyleBackColor = False
    '
    'dgAlumnos
    '
    Me.dgAlumnos.AllowUserToAddRows = False
    Me.dgAlumnos.AllowUserToDeleteRows = False
    Me.dgAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgAlumnos.BackgroundColor = System.Drawing.Color.WhiteSmoke
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgAlumnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNroOrden, Me.cdAlumno, Me.cdSexo, Me.cdGrado, Me.cdEstado})
    Me.dgAlumnos.Location = New System.Drawing.Point(12, 156)
    Me.dgAlumnos.MultiSelect = False
    Me.dgAlumnos.Name = "dgAlumnos"
    Me.dgAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgAlumnos.Size = New System.Drawing.Size(782, 500)
    Me.dgAlumnos.TabIndex = 9
    '
    'cdNroOrden
    '
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.cdNroOrden.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdNroOrden.HeaderText = "Nro. Orden"
    Me.cdNroOrden.Name = "cdNroOrden"
    Me.cdNroOrden.Width = 50
    '
    'cdAlumno
    '
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    Me.cdAlumno.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.Width = 340
    '
    'cdSexo
    '
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.cdSexo.DefaultCellStyle = DataGridViewCellStyle4
    Me.cdSexo.HeaderText = "Sexo"
    Me.cdSexo.Name = "cdSexo"
    Me.cdSexo.Width = 120
    '
    'cdGrado
    '
    Me.cdGrado.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
    Me.cdGrado.HeaderText = "Grado"
    Me.cdGrado.Name = "cdGrado"
    Me.cdGrado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.cdGrado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    '
    'cdEstado
    '
    Me.cdEstado.HeaderText = "Estado"
    Me.cdEstado.Name = "cdEstado"
    Me.cdEstado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.cdEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.cdEstado.Width = 60
    '
    'dgGrados
    '
    Me.dgGrados.AllowUserToAddRows = False
    Me.dgGrados.AllowUserToDeleteRows = False
    Me.dgGrados.BackgroundColor = System.Drawing.Color.WhiteSmoke
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgGrados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
    Me.dgGrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgGrados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNumero, Me.cdSeccion, Me.cdCantidad})
    Me.dgGrados.Location = New System.Drawing.Point(12, 62)
    Me.dgGrados.MultiSelect = False
    Me.dgGrados.Name = "dgGrados"
    Me.dgGrados.ReadOnly = True
    Me.dgGrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgGrados.Size = New System.Drawing.Size(782, 88)
    Me.dgGrados.TabIndex = 8
    '
    'cdNumero
    '
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdNumero.DefaultCellStyle = DataGridViewCellStyle6
    Me.cdNumero.HeaderText = "Número"
    Me.cdNumero.Name = "cdNumero"
    Me.cdNumero.ReadOnly = True
    '
    'cdSeccion
    '
    DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cdSeccion.DefaultCellStyle = DataGridViewCellStyle7
    Me.cdSeccion.HeaderText = "Sección"
    Me.cdSeccion.Name = "cdSeccion"
    Me.cdSeccion.ReadOnly = True
    Me.cdSeccion.Width = 150
    '
    'cdCantidad
    '
    DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cdCantidad.DefaultCellStyle = DataGridViewCellStyle8
    Me.cdCantidad.HeaderText = "Cantidad"
    Me.cdCantidad.Name = "cdCantidad"
    Me.cdCantidad.ReadOnly = True
    '
    'btnListar
    '
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnListar.Location = New System.Drawing.Point(486, 17)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(100, 32)
    Me.btnListar.TabIndex = 7
    Me.btnListar.Text = "&Listar"
    Me.btnListar.UseVisualStyleBackColor = False
    '
    'lblLeyenda
    '
    Me.lblLeyenda.AutoSize = True
    Me.lblLeyenda.BackColor = System.Drawing.Color.LightSkyBlue
    Me.lblLeyenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblLeyenda.Location = New System.Drawing.Point(819, 21)
    Me.lblLeyenda.Name = "lblLeyenda"
    Me.lblLeyenda.Size = New System.Drawing.Size(85, 20)
    Me.lblLeyenda.TabIndex = 12
    Me.lblLeyenda.Text = "Listar: F6"
    '
    'gbLeyenda
    '
    Me.gbLeyenda.Controls.Add(Me.Panel1)
    Me.gbLeyenda.Controls.Add(Me.lblMatAnulada)
    Me.gbLeyenda.Location = New System.Drawing.Point(806, 59)
    Me.gbLeyenda.Name = "gbLeyenda"
    Me.gbLeyenda.Size = New System.Drawing.Size(110, 61)
    Me.gbLeyenda.TabIndex = 13
    Me.gbLeyenda.TabStop = False
    Me.gbLeyenda.Text = "Leyenda"
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
    Me.Panel1.Location = New System.Drawing.Point(6, 39)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(98, 16)
    Me.Panel1.TabIndex = 8
    '
    'lblMatAnulada
    '
    Me.lblMatAnulada.AutoSize = True
    Me.lblMatAnulada.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMatAnulada.Location = New System.Drawing.Point(9, 22)
    Me.lblMatAnulada.Name = "lblMatAnulada"
    Me.lblMatAnulada.Size = New System.Drawing.Size(92, 14)
    Me.lblMatAnulada.TabIndex = 9
    Me.lblMatAnulada.Text = "Matricula Anulada"
    '
    'frmTrasladoAlumnos
    '
    Me.AcceptButton = Me.btnActualizar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(928, 666)
    Me.Controls.Add(Me.gbLeyenda)
    Me.Controls.Add(Me.lblLeyenda)
    Me.Controls.Add(Me.gbGrado)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnActualizar)
    Me.Controls.Add(Me.dgAlumnos)
    Me.Controls.Add(Me.dgGrados)
    Me.Controls.Add(Me.btnListar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.KeyPreview = True
    Me.Name = "frmTrasladoAlumnos"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión Traslado de Alumnos"
    Me.gbGrado.ResumeLayout(False)
    Me.gbGrado.PerformLayout()
    CType(Me.dgAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dgGrados, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbLeyenda.ResumeLayout(False)
    Me.gbLeyenda.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents gbGrado As System.Windows.Forms.GroupBox
  Friend WithEvents lblGrado As System.Windows.Forms.Label
  Friend WithEvents cboGrado As System.Windows.Forms.ComboBox
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnActualizar As System.Windows.Forms.Button
  Friend WithEvents dgAlumnos As System.Windows.Forms.DataGridView
  Friend WithEvents dgGrados As System.Windows.Forms.DataGridView
  Friend WithEvents cdNumero As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdSeccion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents cdNroOrden As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdSexo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdGrado As System.Windows.Forms.DataGridViewComboBoxColumn
  Friend WithEvents cdEstado As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents lblLeyenda As System.Windows.Forms.Label
  Friend WithEvents gbLeyenda As System.Windows.Forms.GroupBox
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents lblMatAnulada As System.Windows.Forms.Label
End Class
