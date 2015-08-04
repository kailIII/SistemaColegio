<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlumnosSeccion
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
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.dgvApoderados = New System.Windows.Forms.DataGridView
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.gbCriterios = New System.Windows.Forms.GroupBox
    Me.lblAnio = New System.Windows.Forms.Label
    Me.lblSeccion = New System.Windows.Forms.Label
    Me.txtAnio = New System.Windows.Forms.TextBox
    Me.cboSeccion = New System.Windows.Forms.ComboBox
    Me.btnListar = New System.Windows.Forms.Button
    Me.btnExportar = New System.Windows.Forms.Button
    Me.cdSeccion = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdTelefonoAl = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdApoderado = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdParentesco = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdTelefonoAp = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdTelefonoTrabAp = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCelularAp = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdDireccionAp = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.dgvApoderados, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbCriterios.SuspendLayout()
    Me.SuspendLayout()
    '
    'dgvApoderados
    '
    Me.dgvApoderados.AllowUserToAddRows = False
    Me.dgvApoderados.AllowUserToDeleteRows = False
    Me.dgvApoderados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvApoderados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvApoderados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdSeccion, Me.cdAlumno, Me.cdTelefonoAl, Me.cdApoderado, Me.cdParentesco, Me.cdTelefonoAp, Me.cdTelefonoTrabAp, Me.cdCelularAp, Me.cdDireccionAp})
    Me.dgvApoderados.Location = New System.Drawing.Point(27, 148)
    Me.dgvApoderados.MultiSelect = False
    Me.dgvApoderados.Name = "dgvApoderados"
    Me.dgvApoderados.ReadOnly = True
    Me.dgvApoderados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvApoderados.Size = New System.Drawing.Size(510, 269)
    Me.dgvApoderados.TabIndex = 1
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(427, 427)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 50)
    Me.btnCerrar.TabIndex = 3
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'gbCriterios
    '
    Me.gbCriterios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbCriterios.Controls.Add(Me.lblAnio)
    Me.gbCriterios.Controls.Add(Me.lblSeccion)
    Me.gbCriterios.Controls.Add(Me.txtAnio)
    Me.gbCriterios.Controls.Add(Me.cboSeccion)
    Me.gbCriterios.Controls.Add(Me.btnListar)
    Me.gbCriterios.Location = New System.Drawing.Point(27, 14)
    Me.gbCriterios.Name = "gbCriterios"
    Me.gbCriterios.Size = New System.Drawing.Size(510, 124)
    Me.gbCriterios.TabIndex = 0
    Me.gbCriterios.TabStop = False
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblAnio.Location = New System.Drawing.Point(17, 42)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(36, 17)
    Me.lblAnio.TabIndex = 0
    Me.lblAnio.Text = "&Anio"
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblSeccion.Location = New System.Drawing.Point(17, 81)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(54, 17)
    Me.lblSeccion.TabIndex = 2
    Me.lblSeccion.Text = "&Sección"
    '
    'txtAnio
    '
    Me.txtAnio.BackColor = System.Drawing.Color.White
    Me.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.txtAnio.Location = New System.Drawing.Point(80, 34)
    Me.txtAnio.Name = "txtAnio"
    Me.txtAnio.ReadOnly = True
    Me.txtAnio.Size = New System.Drawing.Size(100, 25)
    Me.txtAnio.TabIndex = 1
    Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'cboSeccion
    '
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(79, 73)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(223, 25)
    Me.cboSeccion.TabIndex = 3
    '
    'btnListar
    '
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnListar.Location = New System.Drawing.Point(380, 42)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(122, 56)
    Me.btnListar.TabIndex = 4
    Me.btnListar.Text = "&Listar"
    Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnListar.UseVisualStyleBackColor = False
    '
    'btnExportar
    '
    Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnExportar.BackColor = System.Drawing.Color.White
    Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnExportar.Location = New System.Drawing.Point(311, 427)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(110, 50)
    Me.btnExportar.TabIndex = 2
    Me.btnExportar.Text = "&Exportar"
    Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnExportar.UseVisualStyleBackColor = False
    '
    'cdSeccion
    '
    Me.cdSeccion.DataPropertyName = "NivelGradoSeccion"
    Me.cdSeccion.HeaderText = "Sección"
    Me.cdSeccion.Name = "cdSeccion"
    Me.cdSeccion.ReadOnly = True
    Me.cdSeccion.Visible = False
    '
    'cdAlumno
    '
    Me.cdAlumno.DataPropertyName = "NombreAlumno"
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.ReadOnly = True
    Me.cdAlumno.Width = 210
    '
    'cdTelefonoAl
    '
    Me.cdTelefonoAl.DataPropertyName = "TelefonoAlumno"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdTelefonoAl.DefaultCellStyle = DataGridViewCellStyle1
    Me.cdTelefonoAl.HeaderText = "Teléfono"
    Me.cdTelefonoAl.Name = "cdTelefonoAl"
    Me.cdTelefonoAl.ReadOnly = True
    Me.cdTelefonoAl.Width = 80
    '
    'cdApoderado
    '
    Me.cdApoderado.DataPropertyName = "NombreApoderado"
    Me.cdApoderado.HeaderText = "Apoderado"
    Me.cdApoderado.Name = "cdApoderado"
    Me.cdApoderado.ReadOnly = True
    Me.cdApoderado.Width = 210
    '
    'cdParentesco
    '
    Me.cdParentesco.DataPropertyName = "NombreParentesco"
    Me.cdParentesco.HeaderText = "Parentesco"
    Me.cdParentesco.Name = "cdParentesco"
    Me.cdParentesco.ReadOnly = True
    '
    'cdTelefonoAp
    '
    Me.cdTelefonoAp.DataPropertyName = "TelefonoCasaApoderado"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdTelefonoAp.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdTelefonoAp.HeaderText = "Teléfono"
    Me.cdTelefonoAp.Name = "cdTelefonoAp"
    Me.cdTelefonoAp.ReadOnly = True
    Me.cdTelefonoAp.Width = 80
    '
    'cdTelefonoTrabAp
    '
    Me.cdTelefonoTrabAp.DataPropertyName = "TelefonoTrabajoApoderado"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdTelefonoTrabAp.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdTelefonoTrabAp.HeaderText = "Teléfono Trabajo"
    Me.cdTelefonoTrabAp.Name = "cdTelefonoTrabAp"
    Me.cdTelefonoTrabAp.ReadOnly = True
    Me.cdTelefonoTrabAp.Width = 80
    '
    'cdCelularAp
    '
    Me.cdCelularAp.DataPropertyName = "CelularApoderado"
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdCelularAp.DefaultCellStyle = DataGridViewCellStyle4
    Me.cdCelularAp.HeaderText = "Celular"
    Me.cdCelularAp.Name = "cdCelularAp"
    Me.cdCelularAp.ReadOnly = True
    Me.cdCelularAp.Width = 80
    '
    'cdDireccionAp
    '
    Me.cdDireccionAp.DataPropertyName = "DireccionApoderado"
    Me.cdDireccionAp.HeaderText = "Dirección"
    Me.cdDireccionAp.Name = "cdDireccionAp"
    Me.cdDireccionAp.ReadOnly = True
    Me.cdDireccionAp.Width = 150
    '
    'frmAlumnosSeccion
    '
    Me.AcceptButton = Me.btnListar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.CancelButton = Me.btnCerrar
    Me.ClientSize = New System.Drawing.Size(549, 489)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.gbCriterios)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.dgvApoderados)
    Me.Name = "frmAlumnosSeccion"
    Me.Text = "Lista de alumnos por sección"
    CType(Me.dgvApoderados, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbCriterios.ResumeLayout(False)
    Me.gbCriterios.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents dgvApoderados As System.Windows.Forms.DataGridView
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents gbCriterios As System.Windows.Forms.GroupBox
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents txtAnio As System.Windows.Forms.TextBox
  Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents cdSeccion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdTelefonoAl As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdApoderado As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdParentesco As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdTelefonoAp As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdTelefonoTrabAp As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCelularAp As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDireccionAp As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
