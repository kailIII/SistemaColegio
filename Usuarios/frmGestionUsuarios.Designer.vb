<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
 Partial Class frmGestionUsuarios
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
    Me.dgvUsuarios = New System.Windows.Forms.DataGridView
    Me.cdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdPersona = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdTipo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdVigencia = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnseleccionar = New System.Windows.Forms.Button
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btncancelar = New System.Windows.Forms.Button
    Me.btnregistrar = New System.Windows.Forms.Button
    Me.btnnuevo = New System.Windows.Forms.Button
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.btnVerificar = New System.Windows.Forms.Button
    Me.cbogrupo = New System.Windows.Forms.ComboBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.cboTipo = New System.Windows.Forms.ComboBox
    Me.Label5 = New System.Windows.Forms.Label
    Me.frmvigencia = New System.Windows.Forms.GroupBox
    Me.rbtnovigente = New System.Windows.Forms.RadioButton
    Me.rbtvigente = New System.Windows.Forms.RadioButton
    Me.txtConfirmar = New System.Windows.Forms.TextBox
    Me.lblConfirmar = New System.Windows.Forms.Label
    Me.txtContraseña = New System.Windows.Forms.TextBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.btnbuscapersona = New System.Windows.Forms.Button
    Me.txtpersona = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.txtUsuario = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.frmvigencia.SuspendLayout()
    Me.SuspendLayout()
    '
    'dgvUsuarios
    '
    Me.dgvUsuarios.AllowUserToAddRows = False
    Me.dgvUsuarios.AllowUserToDeleteRows = False
    Me.dgvUsuarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdUsuario, Me.cdPersona, Me.cdTipo, Me.cdVigencia})
    Me.dgvUsuarios.Location = New System.Drawing.Point(6, 19)
    Me.dgvUsuarios.Name = "dgvUsuarios"
    Me.dgvUsuarios.ReadOnly = True
    Me.dgvUsuarios.Size = New System.Drawing.Size(544, 221)
    Me.dgvUsuarios.TabIndex = 0
    '
    'cdUsuario
    '
    Me.cdUsuario.DataPropertyName = "Nombre"
    Me.cdUsuario.HeaderText = "Usuario"
    Me.cdUsuario.Name = "cdUsuario"
    Me.cdUsuario.ReadOnly = True
    '
    'cdPersona
    '
    Me.cdPersona.DataPropertyName = "nombrepersona"
    Me.cdPersona.HeaderText = "Persona"
    Me.cdPersona.Name = "cdPersona"
    Me.cdPersona.ReadOnly = True
    Me.cdPersona.Width = 200
    '
    'cdTipo
    '
    Me.cdTipo.DataPropertyName = "nombretipo"
    Me.cdTipo.HeaderText = "Tipo"
    Me.cdTipo.Name = "cdTipo"
    Me.cdTipo.ReadOnly = True
    '
    'cdVigencia
    '
    Me.cdVigencia.DataPropertyName = "nombrevigencia"
    Me.cdVigencia.HeaderText = "Vigencia"
    Me.cdVigencia.Name = "cdVigencia"
    Me.cdVigencia.ReadOnly = True
    '
    'btnseleccionar
    '
    Me.btnseleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnseleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnseleccionar.Location = New System.Drawing.Point(204, 264)
    Me.btnseleccionar.Name = "btnseleccionar"
    Me.btnseleccionar.Size = New System.Drawing.Size(115, 43)
    Me.btnseleccionar.TabIndex = 1
    Me.btnseleccionar.Text = "&Seleccionar"
    Me.btnseleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnseleccionar.UseVisualStyleBackColor = True
    '
    'GroupBox1
    '
    Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.GroupBox1.Controls.Add(Me.dgvUsuarios)
    Me.GroupBox1.Location = New System.Drawing.Point(6, 12)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(556, 246)
    Me.GroupBox1.TabIndex = 0
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Lista de Usuarios"
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(857, 161)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(115, 43)
    Me.btnCerrar.TabIndex = 6
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = True
    '
    'btncancelar
    '
    Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btncancelar.Location = New System.Drawing.Point(857, 112)
    Me.btncancelar.Name = "btncancelar"
    Me.btncancelar.Size = New System.Drawing.Size(115, 43)
    Me.btncancelar.TabIndex = 5
    Me.btncancelar.Text = "C&ancelar"
    Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btncancelar.UseVisualStyleBackColor = True
    '
    'btnregistrar
    '
    Me.btnregistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnregistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnregistrar.Location = New System.Drawing.Point(857, 63)
    Me.btnregistrar.Name = "btnregistrar"
    Me.btnregistrar.Size = New System.Drawing.Size(115, 43)
    Me.btnregistrar.TabIndex = 4
    Me.btnregistrar.Text = "&Registrar"
    Me.btnregistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnregistrar.UseVisualStyleBackColor = True
    '
    'btnnuevo
    '
    Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnnuevo.Location = New System.Drawing.Point(857, 12)
    Me.btnnuevo.Name = "btnnuevo"
    Me.btnnuevo.Size = New System.Drawing.Size(115, 45)
    Me.btnnuevo.TabIndex = 3
    Me.btnnuevo.Text = "&Nuevo"
    Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnnuevo.UseVisualStyleBackColor = True
    '
    'GroupBox2
    '
    Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBox2.Controls.Add(Me.btnVerificar)
    Me.GroupBox2.Controls.Add(Me.cbogrupo)
    Me.GroupBox2.Controls.Add(Me.Label4)
    Me.GroupBox2.Controls.Add(Me.cboTipo)
    Me.GroupBox2.Controls.Add(Me.Label5)
    Me.GroupBox2.Controls.Add(Me.frmvigencia)
    Me.GroupBox2.Controls.Add(Me.txtConfirmar)
    Me.GroupBox2.Controls.Add(Me.lblConfirmar)
    Me.GroupBox2.Controls.Add(Me.txtContraseña)
    Me.GroupBox2.Controls.Add(Me.Label3)
    Me.GroupBox2.Controls.Add(Me.btnbuscapersona)
    Me.GroupBox2.Controls.Add(Me.txtpersona)
    Me.GroupBox2.Controls.Add(Me.Label2)
    Me.GroupBox2.Controls.Add(Me.txtUsuario)
    Me.GroupBox2.Controls.Add(Me.Label1)
    Me.GroupBox2.Location = New System.Drawing.Point(568, 12)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(283, 295)
    Me.GroupBox2.TabIndex = 2
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Usuario"
    '
    'btnVerificar
    '
    Me.btnVerificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnVerificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnVerificar.Location = New System.Drawing.Point(62, 119)
    Me.btnVerificar.Name = "btnVerificar"
    Me.btnVerificar.Size = New System.Drawing.Size(209, 24)
    Me.btnVerificar.TabIndex = 7
    Me.btnVerificar.Text = "&Verificar"
    Me.btnVerificar.UseVisualStyleBackColor = True
    '
    'cbogrupo
    '
    Me.cbogrupo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbogrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbogrupo.FormattingEnabled = True
    Me.cbogrupo.Location = New System.Drawing.Point(63, 24)
    Me.cbogrupo.Name = "cbogrupo"
    Me.cbogrupo.Size = New System.Drawing.Size(208, 21)
    Me.cbogrupo.TabIndex = 1
    '
    'Label4
    '
    Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(13, 32)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(36, 13)
    Me.Label4.TabIndex = 0
    Me.Label4.Text = "Grupo"
    '
    'cboTipo
    '
    Me.cboTipo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipo.FormattingEnabled = True
    Me.cboTipo.Location = New System.Drawing.Point(80, 213)
    Me.cboTipo.Name = "cboTipo"
    Me.cboTipo.Size = New System.Drawing.Size(191, 21)
    Me.cboTipo.TabIndex = 13
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(13, 221)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(28, 13)
    Me.Label5.TabIndex = 12
    Me.Label5.Text = "Tipo"
    '
    'frmvigencia
    '
    Me.frmvigencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.frmvigencia.Controls.Add(Me.rbtnovigente)
    Me.frmvigencia.Controls.Add(Me.rbtvigente)
    Me.frmvigencia.Location = New System.Drawing.Point(14, 247)
    Me.frmvigencia.Name = "frmvigencia"
    Me.frmvigencia.Size = New System.Drawing.Size(257, 37)
    Me.frmvigencia.TabIndex = 14
    Me.frmvigencia.TabStop = False
    Me.frmvigencia.Text = "Vigencia"
    '
    'rbtnovigente
    '
    Me.rbtnovigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.rbtnovigente.AutoSize = True
    Me.rbtnovigente.Location = New System.Drawing.Point(135, 14)
    Me.rbtnovigente.Name = "rbtnovigente"
    Me.rbtnovigente.Size = New System.Drawing.Size(78, 17)
    Me.rbtnovigente.TabIndex = 1
    Me.rbtnovigente.TabStop = True
    Me.rbtnovigente.Text = "No Vigente"
    Me.rbtnovigente.UseVisualStyleBackColor = True
    '
    'rbtvigente
    '
    Me.rbtvigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.rbtvigente.AutoSize = True
    Me.rbtvigente.Location = New System.Drawing.Point(25, 14)
    Me.rbtvigente.Name = "rbtvigente"
    Me.rbtvigente.Size = New System.Drawing.Size(61, 17)
    Me.rbtvigente.TabIndex = 0
    Me.rbtvigente.TabStop = True
    Me.rbtvigente.Text = "Vigente"
    Me.rbtvigente.UseVisualStyleBackColor = True
    '
    'txtConfirmar
    '
    Me.txtConfirmar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtConfirmar.Location = New System.Drawing.Point(80, 177)
    Me.txtConfirmar.Name = "txtConfirmar"
    Me.txtConfirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtConfirmar.Size = New System.Drawing.Size(191, 20)
    Me.txtConfirmar.TabIndex = 11
    '
    'lblConfirmar
    '
    Me.lblConfirmar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblConfirmar.AutoSize = True
    Me.lblConfirmar.Location = New System.Drawing.Point(13, 184)
    Me.lblConfirmar.Name = "lblConfirmar"
    Me.lblConfirmar.Size = New System.Drawing.Size(51, 13)
    Me.lblConfirmar.TabIndex = 10
    Me.lblConfirmar.Text = "Confirmar"
    '
    'txtContraseña
    '
    Me.txtContraseña.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtContraseña.Location = New System.Drawing.Point(80, 149)
    Me.txtContraseña.Name = "txtContraseña"
    Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtContraseña.Size = New System.Drawing.Size(191, 20)
    Me.txtContraseña.TabIndex = 9
    '
    'Label3
    '
    Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(13, 156)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(61, 13)
    Me.Label3.TabIndex = 8
    Me.Label3.Text = "Contraseña"
    '
    'btnbuscapersona
    '
    Me.btnbuscapersona.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnbuscapersona.Image = Global.Colegio.IUsuario.My.Resources.Resources._18
    Me.btnbuscapersona.Location = New System.Drawing.Point(253, 59)
    Me.btnbuscapersona.Name = "btnbuscapersona"
    Me.btnbuscapersona.Size = New System.Drawing.Size(24, 20)
    Me.btnbuscapersona.TabIndex = 4
    Me.btnbuscapersona.UseVisualStyleBackColor = True
    '
    'txtpersona
    '
    Me.txtpersona.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtpersona.Location = New System.Drawing.Point(62, 59)
    Me.txtpersona.Name = "txtpersona"
    Me.txtpersona.ReadOnly = True
    Me.txtpersona.Size = New System.Drawing.Size(191, 20)
    Me.txtpersona.TabIndex = 3
    '
    'Label2
    '
    Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(13, 66)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(46, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Persona"
    '
    'txtUsuario
    '
    Me.txtUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtUsuario.Location = New System.Drawing.Point(62, 93)
    Me.txtUsuario.Name = "txtUsuario"
    Me.txtUsuario.Size = New System.Drawing.Size(209, 20)
    Me.txtUsuario.TabIndex = 6
    '
    'Label1
    '
    Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(13, 100)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(43, 13)
    Me.Label1.TabIndex = 5
    Me.Label1.Text = "Usuario"
    '
    'frmGestionUsuarios
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(975, 319)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btncancelar)
    Me.Controls.Add(Me.btnregistrar)
    Me.Controls.Add(Me.btnnuevo)
    Me.Controls.Add(Me.btnseleccionar)
    Me.Controls.Add(Me.GroupBox1)
    Me.Name = "frmGestionUsuarios"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de usuarios"
    CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.frmvigencia.ResumeLayout(False)
    Me.frmvigencia.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents dgvUsuarios As System.Windows.Forms.DataGridView
  Friend WithEvents btnseleccionar As System.Windows.Forms.Button
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btncancelar As System.Windows.Forms.Button
  Friend WithEvents btnregistrar As System.Windows.Forms.Button
  Friend WithEvents btnnuevo As System.Windows.Forms.Button
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents frmvigencia As System.Windows.Forms.GroupBox
  Friend WithEvents rbtnovigente As System.Windows.Forms.RadioButton
  Friend WithEvents rbtvigente As System.Windows.Forms.RadioButton
  Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents btnbuscapersona As System.Windows.Forms.Button
  Friend WithEvents txtpersona As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
  Friend WithEvents cdUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdPersona As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdTipo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdVigencia As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cbogrupo As System.Windows.Forms.ComboBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtConfirmar As System.Windows.Forms.TextBox
  Friend WithEvents lblConfirmar As System.Windows.Forms.Label
  Friend WithEvents btnVerificar As System.Windows.Forms.Button
End Class
