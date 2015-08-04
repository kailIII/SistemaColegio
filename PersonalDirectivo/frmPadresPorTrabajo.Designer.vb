<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPadresPorTrabajo
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
    Me.dgvApoderados = New System.Windows.Forms.DataGridView
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.gbCriterios = New System.Windows.Forms.GroupBox
    Me.txtNombre = New System.Windows.Forms.TextBox
    Me.lblNombre = New System.Windows.Forms.Label
    Me.btnListar = New System.Windows.Forms.Button
    Me.cboOcupacion = New System.Windows.Forms.ComboBox
    Me.lblOcupacion = New System.Windows.Forms.Label
    Me.cboProfesion = New System.Windows.Forms.ComboBox
    Me.lblProfesion = New System.Windows.Forms.Label
    Me.cboLugarTrab = New System.Windows.Forms.ComboBox
    Me.lblLugarTrab = New System.Windows.Forms.Label
    Me.cdEmpresa = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdApoderado = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdOcupacion = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCelular = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdTelefonoTrab = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCorreo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdProfesion = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdSeccion = New System.Windows.Forms.DataGridViewTextBoxColumn
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
    Me.dgvApoderados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdEmpresa, Me.cdApoderado, Me.cdOcupacion, Me.cdCelular, Me.cdTelefonoTrab, Me.cdTelefono, Me.cdCorreo, Me.cdProfesion, Me.cdAlumno, Me.cdSeccion})
    Me.dgvApoderados.Location = New System.Drawing.Point(27, 216)
    Me.dgvApoderados.MultiSelect = False
    Me.dgvApoderados.Name = "dgvApoderados"
    Me.dgvApoderados.ReadOnly = True
    Me.dgvApoderados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvApoderados.Size = New System.Drawing.Size(510, 198)
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
    Me.btnCerrar.TabIndex = 2
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'gbCriterios
    '
    Me.gbCriterios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbCriterios.Controls.Add(Me.txtNombre)
    Me.gbCriterios.Controls.Add(Me.lblNombre)
    Me.gbCriterios.Controls.Add(Me.btnListar)
    Me.gbCriterios.Controls.Add(Me.cboOcupacion)
    Me.gbCriterios.Controls.Add(Me.lblOcupacion)
    Me.gbCriterios.Controls.Add(Me.cboProfesion)
    Me.gbCriterios.Controls.Add(Me.lblProfesion)
    Me.gbCriterios.Controls.Add(Me.cboLugarTrab)
    Me.gbCriterios.Controls.Add(Me.lblLugarTrab)
    Me.gbCriterios.Location = New System.Drawing.Point(27, 14)
    Me.gbCriterios.Name = "gbCriterios"
    Me.gbCriterios.Size = New System.Drawing.Size(510, 189)
    Me.gbCriterios.TabIndex = 0
    Me.gbCriterios.TabStop = False
    '
    'txtNombre
    '
    Me.txtNombre.Location = New System.Drawing.Point(80, 28)
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Size = New System.Drawing.Size(422, 20)
    Me.txtNombre.TabIndex = 1
    '
    'lblNombre
    '
    Me.lblNombre.AutoSize = True
    Me.lblNombre.Location = New System.Drawing.Point(12, 35)
    Me.lblNombre.Name = "lblNombre"
    Me.lblNombre.Size = New System.Drawing.Size(44, 13)
    Me.lblNombre.TabIndex = 0
    Me.lblNombre.Text = "&Nombre"
    '
    'btnListar
    '
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnListar.Location = New System.Drawing.Point(380, 113)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(122, 56)
    Me.btnListar.TabIndex = 8
    Me.btnListar.Text = "&Listar"
    Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnListar.UseVisualStyleBackColor = False
    '
    'cboOcupacion
    '
    Me.cboOcupacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cboOcupacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboOcupacion.FormattingEnabled = True
    Me.cboOcupacion.Location = New System.Drawing.Point(80, 148)
    Me.cboOcupacion.Name = "cboOcupacion"
    Me.cboOcupacion.Size = New System.Drawing.Size(194, 21)
    Me.cboOcupacion.TabIndex = 7
    '
    'lblOcupacion
    '
    Me.lblOcupacion.AutoSize = True
    Me.lblOcupacion.Location = New System.Drawing.Point(15, 156)
    Me.lblOcupacion.Name = "lblOcupacion"
    Me.lblOcupacion.Size = New System.Drawing.Size(59, 13)
    Me.lblOcupacion.TabIndex = 6
    Me.lblOcupacion.Text = "&Ocupación"
    '
    'cboProfesion
    '
    Me.cboProfesion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cboProfesion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboProfesion.FormattingEnabled = True
    Me.cboProfesion.Location = New System.Drawing.Point(80, 107)
    Me.cboProfesion.Name = "cboProfesion"
    Me.cboProfesion.Size = New System.Drawing.Size(194, 21)
    Me.cboProfesion.TabIndex = 5
    '
    'lblProfesion
    '
    Me.lblProfesion.AutoSize = True
    Me.lblProfesion.Location = New System.Drawing.Point(15, 115)
    Me.lblProfesion.Name = "lblProfesion"
    Me.lblProfesion.Size = New System.Drawing.Size(51, 13)
    Me.lblProfesion.TabIndex = 4
    Me.lblProfesion.Text = "&Profesión"
    '
    'cboLugarTrab
    '
    Me.cboLugarTrab.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cboLugarTrab.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboLugarTrab.FormattingEnabled = True
    Me.cboLugarTrab.Location = New System.Drawing.Point(105, 65)
    Me.cboLugarTrab.Name = "cboLugarTrab"
    Me.cboLugarTrab.Size = New System.Drawing.Size(397, 21)
    Me.cboLugarTrab.TabIndex = 3
    '
    'lblLugarTrab
    '
    Me.lblLugarTrab.AutoSize = True
    Me.lblLugarTrab.Location = New System.Drawing.Point(15, 73)
    Me.lblLugarTrab.Name = "lblLugarTrab"
    Me.lblLugarTrab.Size = New System.Drawing.Size(84, 13)
    Me.lblLugarTrab.TabIndex = 2
    Me.lblLugarTrab.Text = "&Lugar de trabajo"
    '
    'cdEmpresa
    '
    Me.cdEmpresa.DataPropertyName = "LugarTrabajo"
    Me.cdEmpresa.HeaderText = "Empresa"
    Me.cdEmpresa.Name = "cdEmpresa"
    Me.cdEmpresa.ReadOnly = True
    Me.cdEmpresa.Width = 180
    '
    'cdApoderado
    '
    Me.cdApoderado.DataPropertyName = "NombreApoderado"
    Me.cdApoderado.HeaderText = "Apoderado"
    Me.cdApoderado.Name = "cdApoderado"
    Me.cdApoderado.ReadOnly = True
    Me.cdApoderado.Width = 200
    '
    'cdOcupacion
    '
    Me.cdOcupacion.DataPropertyName = "NombreOcupacion"
    Me.cdOcupacion.HeaderText = "Ocupación"
    Me.cdOcupacion.Name = "cdOcupacion"
    Me.cdOcupacion.ReadOnly = True
    Me.cdOcupacion.Width = 120
    '
    'cdCelular
    '
    Me.cdCelular.DataPropertyName = "CelularApoderado"
    Me.cdCelular.HeaderText = "Celular"
    Me.cdCelular.Name = "cdCelular"
    Me.cdCelular.ReadOnly = True
    Me.cdCelular.Width = 80
    '
    'cdTelefonoTrab
    '
    Me.cdTelefonoTrab.DataPropertyName = "TelefonoTrabajoApoderado"
    Me.cdTelefonoTrab.HeaderText = "Telefono de trabajo"
    Me.cdTelefonoTrab.Name = "cdTelefonoTrab"
    Me.cdTelefonoTrab.ReadOnly = True
    Me.cdTelefonoTrab.Width = 80
    '
    'cdTelefono
    '
    Me.cdTelefono.DataPropertyName = "TelefonoCasaApoderado"
    Me.cdTelefono.HeaderText = "Telefono"
    Me.cdTelefono.Name = "cdTelefono"
    Me.cdTelefono.ReadOnly = True
    Me.cdTelefono.Width = 80
    '
    'cdCorreo
    '
    Me.cdCorreo.DataPropertyName = "Email"
    Me.cdCorreo.HeaderText = "Correo"
    Me.cdCorreo.Name = "cdCorreo"
    Me.cdCorreo.ReadOnly = True
    Me.cdCorreo.Width = 150
    '
    'cdProfesion
    '
    Me.cdProfesion.DataPropertyName = "NombreProfesion"
    Me.cdProfesion.HeaderText = "Profesión"
    Me.cdProfesion.Name = "cdProfesion"
    Me.cdProfesion.ReadOnly = True
    Me.cdProfesion.Width = 120
    '
    'cdAlumno
    '
    Me.cdAlumno.DataPropertyName = "NombreAlumno"
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.ReadOnly = True
    Me.cdAlumno.Width = 150
    '
    'cdSeccion
    '
    Me.cdSeccion.DataPropertyName = "NivelGradoSeccion"
    Me.cdSeccion.HeaderText = "Sección"
    Me.cdSeccion.Name = "cdSeccion"
    Me.cdSeccion.ReadOnly = True
    '
    'frmPadresPorTrabajo
    '
    Me.AcceptButton = Me.btnListar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.CancelButton = Me.btnCerrar
    Me.ClientSize = New System.Drawing.Size(549, 489)
    Me.Controls.Add(Me.gbCriterios)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.dgvApoderados)
    Me.Name = "frmPadresPorTrabajo"
    Me.Text = "Reporte de padres de familia por condición laboral"
    CType(Me.dgvApoderados, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbCriterios.ResumeLayout(False)
    Me.gbCriterios.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents dgvApoderados As System.Windows.Forms.DataGridView
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents gbCriterios As System.Windows.Forms.GroupBox
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents cboOcupacion As System.Windows.Forms.ComboBox
  Friend WithEvents lblOcupacion As System.Windows.Forms.Label
  Friend WithEvents cboProfesion As System.Windows.Forms.ComboBox
  Friend WithEvents lblProfesion As System.Windows.Forms.Label
  Friend WithEvents cboLugarTrab As System.Windows.Forms.ComboBox
  Friend WithEvents lblLugarTrab As System.Windows.Forms.Label
  Friend WithEvents lblNombre As System.Windows.Forms.Label
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents cdEmpresa As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdApoderado As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdOcupacion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCelular As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdTelefonoTrab As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdTelefono As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCorreo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdProfesion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdSeccion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
