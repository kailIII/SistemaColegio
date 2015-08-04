<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionCurso
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
    Me.components = New System.ComponentModel.Container
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.errValida = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.gbListaCursos = New System.Windows.Forms.GroupBox
    Me.btnModificar = New System.Windows.Forms.Button
    Me.dgvCursos = New System.Windows.Forms.DataGridView
    Me.cdCurso = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.gbCurso = New System.Windows.Forms.GroupBox
    Me.cboArea = New System.Windows.Forms.ComboBox
    Me.gbNombreCurso = New System.Windows.Forms.GroupBox
    Me.chkVigencia = New System.Windows.Forms.CheckBox
    Me.chkRotativo = New System.Windows.Forms.CheckBox
    Me.gbTipoDocente = New System.Windows.Forms.GroupBox
    Me.rbPolidocente = New System.Windows.Forms.RadioButton
    Me.rbUnidocente = New System.Windows.Forms.RadioButton
    Me.txtNombre = New System.Windows.Forms.TextBox
    Me.lblNombre = New System.Windows.Forms.Label
    Me.lblHorasSem = New System.Windows.Forms.Label
    Me.nudHoras = New System.Windows.Forms.NumericUpDown
    Me.lblArea = New System.Windows.Forms.Label
    Me.cboNivel = New System.Windows.Forms.ComboBox
    Me.lblGrado = New System.Windows.Forms.Label
    Me.lblNivel = New System.Windows.Forms.Label
    Me.cboGrado = New System.Windows.Forms.ComboBox
    Me.btnRegistrar = New System.Windows.Forms.Button
    CType(Me.errValida, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbListaCursos.SuspendLayout()
    CType(Me.dgvCursos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbCurso.SuspendLayout()
    Me.gbNombreCurso.SuspendLayout()
    Me.gbTipoDocente.SuspendLayout()
    CType(Me.nudHoras, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'errValida
    '
    Me.errValida.ContainerControl = Me
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(752, 131)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
    Me.btnCancelar.TabIndex = 2
    Me.btnCancelar.Text = "&Deshacer"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(752, 410)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 4
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'gbListaCursos
    '
    Me.gbListaCursos.Controls.Add(Me.btnModificar)
    Me.gbListaCursos.Controls.Add(Me.dgvCursos)
    Me.gbListaCursos.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.gbListaCursos.Location = New System.Drawing.Point(11, 21)
    Me.gbListaCursos.Name = "gbListaCursos"
    Me.gbListaCursos.Size = New System.Drawing.Size(351, 441)
    Me.gbListaCursos.TabIndex = 3
    Me.gbListaCursos.TabStop = False
    Me.gbListaCursos.Text = "Lista de Cursos"
    '
    'btnModificar
    '
    Me.btnModificar.BackColor = System.Drawing.Color.White
    Me.btnModificar.Enabled = False
    Me.btnModificar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnModificar.Location = New System.Drawing.Point(235, 382)
    Me.btnModificar.Name = "btnModificar"
    Me.btnModificar.Size = New System.Drawing.Size(110, 46)
    Me.btnModificar.TabIndex = 1
    Me.btnModificar.Text = "&Modificar"
    Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnModificar.UseVisualStyleBackColor = False
    '
    'dgvCursos
    '
    Me.dgvCursos.AllowUserToAddRows = False
    Me.dgvCursos.AllowUserToDeleteRows = False
    DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle7.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvCursos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
    Me.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvCursos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdCurso})
    Me.dgvCursos.Location = New System.Drawing.Point(6, 29)
    Me.dgvCursos.MultiSelect = False
    Me.dgvCursos.Name = "dgvCursos"
    Me.dgvCursos.ReadOnly = True
    Me.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvCursos.Size = New System.Drawing.Size(339, 348)
    Me.dgvCursos.TabIndex = 0
    '
    'cdCurso
    '
    Me.cdCurso.DataPropertyName = "Nombre"
    DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    Me.cdCurso.DefaultCellStyle = DataGridViewCellStyle8
    Me.cdCurso.HeaderText = "Curso"
    Me.cdCurso.Name = "cdCurso"
    Me.cdCurso.ReadOnly = True
    Me.cdCurso.Width = 280
    '
    'gbCurso
    '
    Me.gbCurso.Controls.Add(Me.cboArea)
    Me.gbCurso.Controls.Add(Me.gbNombreCurso)
    Me.gbCurso.Controls.Add(Me.lblArea)
    Me.gbCurso.Controls.Add(Me.cboNivel)
    Me.gbCurso.Controls.Add(Me.lblGrado)
    Me.gbCurso.Controls.Add(Me.lblNivel)
    Me.gbCurso.Controls.Add(Me.cboGrado)
    Me.gbCurso.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.gbCurso.Location = New System.Drawing.Point(368, 21)
    Me.gbCurso.Name = "gbCurso"
    Me.gbCurso.Size = New System.Drawing.Size(378, 441)
    Me.gbCurso.TabIndex = 0
    Me.gbCurso.TabStop = False
    Me.gbCurso.UseCompatibleTextRendering = True
    '
    'cboArea
    '
    Me.cboArea.DisplayMember = "nombreNivel"
    Me.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboArea.FormattingEnabled = True
    Me.cboArea.Location = New System.Drawing.Point(72, 130)
    Me.cboArea.Name = "cboArea"
    Me.cboArea.Size = New System.Drawing.Size(262, 25)
    Me.cboArea.TabIndex = 5
    '
    'gbNombreCurso
    '
    Me.gbNombreCurso.Controls.Add(Me.chkVigencia)
    Me.gbNombreCurso.Controls.Add(Me.chkRotativo)
    Me.gbNombreCurso.Controls.Add(Me.gbTipoDocente)
    Me.gbNombreCurso.Controls.Add(Me.txtNombre)
    Me.gbNombreCurso.Controls.Add(Me.lblNombre)
    Me.gbNombreCurso.Controls.Add(Me.lblHorasSem)
    Me.gbNombreCurso.Controls.Add(Me.nudHoras)
    Me.gbNombreCurso.Location = New System.Drawing.Point(6, 185)
    Me.gbNombreCurso.Name = "gbNombreCurso"
    Me.gbNombreCurso.Size = New System.Drawing.Size(357, 243)
    Me.gbNombreCurso.TabIndex = 6
    Me.gbNombreCurso.TabStop = False
    Me.gbNombreCurso.Text = "Curso"
    '
    'chkVigencia
    '
    Me.chkVigencia.AutoSize = True
    Me.chkVigencia.Checked = True
    Me.chkVigencia.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkVigencia.Enabled = False
    Me.chkVigencia.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkVigencia.Location = New System.Drawing.Point(211, 190)
    Me.chkVigencia.Name = "chkVigencia"
    Me.chkVigencia.Size = New System.Drawing.Size(71, 19)
    Me.chkVigencia.TabIndex = 6
    Me.chkVigencia.Text = "&Vigencia"
    Me.chkVigencia.UseVisualStyleBackColor = True
    '
    'chkRotativo
    '
    Me.chkRotativo.AutoSize = True
    Me.chkRotativo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkRotativo.Location = New System.Drawing.Point(64, 190)
    Me.chkRotativo.Name = "chkRotativo"
    Me.chkRotativo.Size = New System.Drawing.Size(72, 19)
    Me.chkRotativo.TabIndex = 5
    Me.chkRotativo.Text = "Rotativo"
    Me.chkRotativo.UseVisualStyleBackColor = True
    '
    'gbTipoDocente
    '
    Me.gbTipoDocente.Controls.Add(Me.rbPolidocente)
    Me.gbTipoDocente.Controls.Add(Me.rbUnidocente)
    Me.gbTipoDocente.Location = New System.Drawing.Point(64, 127)
    Me.gbTipoDocente.Name = "gbTipoDocente"
    Me.gbTipoDocente.Size = New System.Drawing.Size(263, 43)
    Me.gbTipoDocente.TabIndex = 4
    Me.gbTipoDocente.TabStop = False
    '
    'rbPolidocente
    '
    Me.rbPolidocente.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rbPolidocente.Location = New System.Drawing.Point(147, 16)
    Me.rbPolidocente.Name = "rbPolidocente"
    Me.rbPolidocente.Size = New System.Drawing.Size(88, 19)
    Me.rbPolidocente.TabIndex = 1
    Me.rbPolidocente.Text = "Polidocente"
    Me.rbPolidocente.UseVisualStyleBackColor = True
    '
    'rbUnidocente
    '
    Me.rbUnidocente.AutoSize = True
    Me.rbUnidocente.Checked = True
    Me.rbUnidocente.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rbUnidocente.Location = New System.Drawing.Point(24, 16)
    Me.rbUnidocente.Name = "rbUnidocente"
    Me.rbUnidocente.Size = New System.Drawing.Size(87, 19)
    Me.rbUnidocente.TabIndex = 0
    Me.rbUnidocente.TabStop = True
    Me.rbUnidocente.Text = "Unidocente"
    Me.rbUnidocente.UseVisualStyleBackColor = True
    '
    'txtNombre
    '
    Me.txtNombre.Location = New System.Drawing.Point(66, 45)
    Me.txtNombre.Multiline = True
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Size = New System.Drawing.Size(263, 24)
    Me.txtNombre.TabIndex = 1
    '
    'lblNombre
    '
    Me.lblNombre.AutoSize = True
    Me.lblNombre.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNombre.Location = New System.Drawing.Point(8, 49)
    Me.lblNombre.Name = "lblNombre"
    Me.lblNombre.Size = New System.Drawing.Size(52, 15)
    Me.lblNombre.TabIndex = 0
    Me.lblNombre.Text = "Nombre:"
    '
    'lblHorasSem
    '
    Me.lblHorasSem.AutoSize = True
    Me.lblHorasSem.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblHorasSem.Location = New System.Drawing.Point(61, 95)
    Me.lblHorasSem.Name = "lblHorasSem"
    Me.lblHorasSem.Size = New System.Drawing.Size(101, 15)
    Me.lblHorasSem.TabIndex = 2
    Me.lblHorasSem.Text = "Horas Semanales:"
    '
    'nudHoras
    '
    Me.nudHoras.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.nudHoras.Location = New System.Drawing.Point(168, 92)
    Me.nudHoras.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
    Me.nudHoras.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.nudHoras.Name = "nudHoras"
    Me.nudHoras.Size = New System.Drawing.Size(43, 22)
    Me.nudHoras.TabIndex = 3
    Me.nudHoras.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'lblArea
    '
    Me.lblArea.AutoSize = True
    Me.lblArea.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblArea.Location = New System.Drawing.Point(23, 134)
    Me.lblArea.Name = "lblArea"
    Me.lblArea.Size = New System.Drawing.Size(36, 15)
    Me.lblArea.TabIndex = 4
    Me.lblArea.Text = "Área:"
    '
    'cboNivel
    '
    Me.cboNivel.DisplayMember = "nombreNivel"
    Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Location = New System.Drawing.Point(72, 38)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(262, 25)
    Me.cboNivel.TabIndex = 1
    '
    'lblGrado
    '
    Me.lblGrado.AutoSize = True
    Me.lblGrado.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblGrado.Location = New System.Drawing.Point(24, 88)
    Me.lblGrado.Name = "lblGrado"
    Me.lblGrado.Size = New System.Drawing.Size(42, 15)
    Me.lblGrado.TabIndex = 2
    Me.lblGrado.Text = "Grado:"
    '
    'lblNivel
    '
    Me.lblNivel.AutoSize = True
    Me.lblNivel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNivel.Location = New System.Drawing.Point(28, 42)
    Me.lblNivel.Name = "lblNivel"
    Me.lblNivel.Size = New System.Drawing.Size(38, 15)
    Me.lblNivel.TabIndex = 0
    Me.lblNivel.Text = "Nivel:"
    '
    'cboGrado
    '
    Me.cboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboGrado.FormattingEnabled = True
    Me.cboGrado.Location = New System.Drawing.Point(72, 84)
    Me.cboGrado.Name = "cboGrado"
    Me.cboGrado.Size = New System.Drawing.Size(262, 25)
    Me.cboGrado.TabIndex = 3
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(752, 63)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
    Me.btnRegistrar.TabIndex = 1
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'frmGestionCurso
    '
    Me.AcceptButton = Me.btnRegistrar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(868, 474)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.gbListaCursos)
    Me.Controls.Add(Me.gbCurso)
    Me.Controls.Add(Me.btnRegistrar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.Name = "frmGestionCurso"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de Cursos"
    CType(Me.errValida, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbListaCursos.ResumeLayout(False)
    CType(Me.dgvCursos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbCurso.ResumeLayout(False)
    Me.gbCurso.PerformLayout()
    Me.gbNombreCurso.ResumeLayout(False)
    Me.gbNombreCurso.PerformLayout()
    Me.gbTipoDocente.ResumeLayout(False)
    Me.gbTipoDocente.PerformLayout()
    CType(Me.nudHoras, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents errValida As System.Windows.Forms.ErrorProvider
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents gbListaCursos As System.Windows.Forms.GroupBox
  Friend WithEvents btnModificar As System.Windows.Forms.Button
  Friend WithEvents dgvCursos As System.Windows.Forms.DataGridView
  Friend WithEvents gbCurso As System.Windows.Forms.GroupBox
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents cboArea As System.Windows.Forms.ComboBox
  Friend WithEvents lblGrado As System.Windows.Forms.Label
  Friend WithEvents lblArea As System.Windows.Forms.Label
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents chkRotativo As System.Windows.Forms.CheckBox
  Friend WithEvents lblNivel As System.Windows.Forms.Label
  Friend WithEvents lblNombre As System.Windows.Forms.Label
  Friend WithEvents nudHoras As System.Windows.Forms.NumericUpDown
  Friend WithEvents cboGrado As System.Windows.Forms.ComboBox
  Friend WithEvents lblHorasSem As System.Windows.Forms.Label
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents gbTipoDocente As System.Windows.Forms.GroupBox
  Friend WithEvents rbPolidocente As System.Windows.Forms.RadioButton
  Friend WithEvents rbUnidocente As System.Windows.Forms.RadioButton
  Friend WithEvents gbNombreCurso As System.Windows.Forms.GroupBox
  Friend WithEvents cdCurso As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents chkVigencia As System.Windows.Forms.CheckBox

End Class
