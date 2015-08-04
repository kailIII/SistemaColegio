<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
 Partial Class frmGestionUsuario
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
    Me.dvgusuario = New System.Windows.Forms.DataGridView
    Me.cdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdPersona = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdTipo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdVigencia = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnseleccionar = New System.Windows.Forms.Button
    Me.gbListaUsuarios = New System.Windows.Forms.GroupBox
    Me.btnListar = New System.Windows.Forms.Button
    Me.txtUsuarioBuscar = New System.Windows.Forms.TextBox
    Me.lblUsuarioBuscar = New System.Windows.Forms.Label
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btncancelar = New System.Windows.Forms.Button
    Me.btnregistrar = New System.Windows.Forms.Button
    Me.btnnuevo = New System.Windows.Forms.Button
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.txtVerificar = New System.Windows.Forms.TextBox
    Me.Label6 = New System.Windows.Forms.Label
    Me.cbogrupo = New System.Windows.Forms.ComboBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.cboTipo = New System.Windows.Forms.ComboBox
    Me.Label5 = New System.Windows.Forms.Label
    Me.frmvigencia = New System.Windows.Forms.GroupBox
    Me.rbtnovigente = New System.Windows.Forms.RadioButton
    Me.rbtvigente = New System.Windows.Forms.RadioButton
    Me.txtContraseña = New System.Windows.Forms.TextBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.btnbuscapersona = New System.Windows.Forms.Button
    Me.txtpersona = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.txtnombre = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    CType(Me.dvgusuario, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbListaUsuarios.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.frmvigencia.SuspendLayout()
    Me.SuspendLayout()
    '
    'dvgusuario
    '
    Me.dvgusuario.AllowUserToAddRows = False
    Me.dvgusuario.AllowUserToDeleteRows = False
    Me.dvgusuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.dvgusuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dvgusuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdUsuario, Me.cdPersona, Me.cdTipo, Me.cdVigencia})
    Me.dvgusuario.Location = New System.Drawing.Point(6, 51)
    Me.dvgusuario.Name = "dvgusuario"
    Me.dvgusuario.ReadOnly = True
    Me.dvgusuario.Size = New System.Drawing.Size(531, 298)
    Me.dvgusuario.TabIndex = 0
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
    Me.btnseleccionar.Location = New System.Drawing.Point(204, 378)
    Me.btnseleccionar.Name = "btnseleccionar"
    Me.btnseleccionar.Size = New System.Drawing.Size(115, 43)
    Me.btnseleccionar.TabIndex = 6
    Me.btnseleccionar.Text = "&Seleccionar"
    Me.btnseleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnseleccionar.UseVisualStyleBackColor = True
    '
    'gbListaUsuarios
    '
    Me.gbListaUsuarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.gbListaUsuarios.Controls.Add(Me.btnListar)
    Me.gbListaUsuarios.Controls.Add(Me.txtUsuarioBuscar)
    Me.gbListaUsuarios.Controls.Add(Me.lblUsuarioBuscar)
    Me.gbListaUsuarios.Controls.Add(Me.dvgusuario)
    Me.gbListaUsuarios.Location = New System.Drawing.Point(6, 12)
    Me.gbListaUsuarios.Name = "gbListaUsuarios"
    Me.gbListaUsuarios.Size = New System.Drawing.Size(547, 360)
    Me.gbListaUsuarios.TabIndex = 0
    Me.gbListaUsuarios.TabStop = False
    '
    'btnListar
    '
    Me.btnListar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnListar.Location = New System.Drawing.Point(448, 15)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(87, 28)
    Me.btnListar.TabIndex = 9
    Me.btnListar.Text = "&Listar"
    Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnListar.UseVisualStyleBackColor = True
    '
    'txtUsuarioBuscar
    '
    Me.txtUsuarioBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtUsuarioBuscar.Location = New System.Drawing.Point(55, 23)
    Me.txtUsuarioBuscar.Name = "txtUsuarioBuscar"
    Me.txtUsuarioBuscar.Size = New System.Drawing.Size(387, 20)
    Me.txtUsuarioBuscar.TabIndex = 8
    '
    'lblUsuarioBuscar
    '
    Me.lblUsuarioBuscar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblUsuarioBuscar.AutoSize = True
    Me.lblUsuarioBuscar.Location = New System.Drawing.Point(6, 30)
    Me.lblUsuarioBuscar.Name = "lblUsuarioBuscar"
    Me.lblUsuarioBuscar.Size = New System.Drawing.Size(43, 13)
    Me.lblUsuarioBuscar.TabIndex = 7
    Me.lblUsuarioBuscar.Text = "Usuario"
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(882, 161)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(115, 43)
    Me.btnCerrar.TabIndex = 5
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = True
    '
    'btncancelar
    '
    Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btncancelar.Location = New System.Drawing.Point(882, 112)
    Me.btncancelar.Name = "btncancelar"
    Me.btncancelar.Size = New System.Drawing.Size(115, 43)
    Me.btncancelar.TabIndex = 4
    Me.btncancelar.Text = "C&ancelar"
    Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btncancelar.UseVisualStyleBackColor = True
    '
    'btnregistrar
    '
    Me.btnregistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnregistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnregistrar.Location = New System.Drawing.Point(882, 63)
    Me.btnregistrar.Name = "btnregistrar"
    Me.btnregistrar.Size = New System.Drawing.Size(115, 43)
    Me.btnregistrar.TabIndex = 3
    Me.btnregistrar.Text = "&Registrar"
    Me.btnregistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnregistrar.UseVisualStyleBackColor = True
    '
    'btnnuevo
    '
    Me.btnnuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnnuevo.Location = New System.Drawing.Point(882, 12)
    Me.btnnuevo.Name = "btnnuevo"
    Me.btnnuevo.Size = New System.Drawing.Size(115, 45)
    Me.btnnuevo.TabIndex = 2
    Me.btnnuevo.Text = "&Nuevo"
    Me.btnnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnnuevo.UseVisualStyleBackColor = True
    '
    'GroupBox2
    '
    Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBox2.Controls.Add(Me.txtVerificar)
    Me.GroupBox2.Controls.Add(Me.Label6)
    Me.GroupBox2.Controls.Add(Me.cbogrupo)
    Me.GroupBox2.Controls.Add(Me.Label4)
    Me.GroupBox2.Controls.Add(Me.cboTipo)
    Me.GroupBox2.Controls.Add(Me.Label5)
    Me.GroupBox2.Controls.Add(Me.frmvigencia)
    Me.GroupBox2.Controls.Add(Me.txtContraseña)
    Me.GroupBox2.Controls.Add(Me.Label3)
    Me.GroupBox2.Controls.Add(Me.btnbuscapersona)
    Me.GroupBox2.Controls.Add(Me.txtpersona)
    Me.GroupBox2.Controls.Add(Me.Label2)
    Me.GroupBox2.Controls.Add(Me.txtnombre)
    Me.GroupBox2.Controls.Add(Me.Label1)
    Me.GroupBox2.Location = New System.Drawing.Point(559, 12)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(317, 289)
    Me.GroupBox2.TabIndex = 1
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Usuario"
    '
    'txtVerificar
    '
    Me.txtVerificar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtVerificar.Location = New System.Drawing.Point(75, 157)
    Me.txtVerificar.Name = "txtVerificar"
    Me.txtVerificar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtVerificar.Size = New System.Drawing.Size(219, 20)
    Me.txtVerificar.TabIndex = 10
    '
    'Label6
    '
    Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(7, 164)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(45, 13)
    Me.Label6.TabIndex = 9
    Me.Label6.Text = "Verificar"
    '
    'cbogrupo
    '
    Me.cbogrupo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbogrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbogrupo.FormattingEnabled = True
    Me.cbogrupo.Location = New System.Drawing.Point(58, 29)
    Me.cbogrupo.Name = "cbogrupo"
    Me.cbogrupo.Size = New System.Drawing.Size(236, 21)
    Me.cbogrupo.TabIndex = 1
    '
    'Label4
    '
    Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(8, 37)
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
    Me.cboTipo.Location = New System.Drawing.Point(75, 190)
    Me.cboTipo.Name = "cboTipo"
    Me.cboTipo.Size = New System.Drawing.Size(219, 21)
    Me.cboTipo.TabIndex = 12
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(8, 198)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(28, 13)
    Me.Label5.TabIndex = 11
    Me.Label5.Text = "Tipo"
    '
    'frmvigencia
    '
    Me.frmvigencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.frmvigencia.Controls.Add(Me.rbtnovigente)
    Me.frmvigencia.Controls.Add(Me.rbtvigente)
    Me.frmvigencia.Location = New System.Drawing.Point(11, 232)
    Me.frmvigencia.Name = "frmvigencia"
    Me.frmvigencia.Size = New System.Drawing.Size(283, 46)
    Me.frmvigencia.TabIndex = 13
    Me.frmvigencia.TabStop = False
    Me.frmvigencia.Text = "Vigencia"
    '
    'rbtnovigente
    '
    Me.rbtnovigente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.rbtnovigente.AutoSize = True
    Me.rbtnovigente.Location = New System.Drawing.Point(135, 18)
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
    Me.rbtvigente.Location = New System.Drawing.Point(25, 18)
    Me.rbtvigente.Name = "rbtvigente"
    Me.rbtvigente.Size = New System.Drawing.Size(61, 17)
    Me.rbtvigente.TabIndex = 0
    Me.rbtvigente.TabStop = True
    Me.rbtvigente.Text = "Vigente"
    Me.rbtvigente.UseVisualStyleBackColor = True
    '
    'txtContraseña
    '
    Me.txtContraseña.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtContraseña.Location = New System.Drawing.Point(75, 127)
    Me.txtContraseña.Name = "txtContraseña"
    Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtContraseña.Size = New System.Drawing.Size(219, 20)
    Me.txtContraseña.TabIndex = 8
    '
    'Label3
    '
    Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(8, 134)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(61, 13)
    Me.Label3.TabIndex = 7
    Me.Label3.Text = "Contraseña"
    '
    'btnbuscapersona
    '
    Me.btnbuscapersona.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnbuscapersona.Image = Global.Colegio.IUsuario.My.Resources.Resources._18
    Me.btnbuscapersona.Location = New System.Drawing.Point(270, 63)
    Me.btnbuscapersona.Name = "btnbuscapersona"
    Me.btnbuscapersona.Size = New System.Drawing.Size(24, 20)
    Me.btnbuscapersona.TabIndex = 4
    Me.btnbuscapersona.UseVisualStyleBackColor = True
    '
    'txtpersona
    '
    Me.txtpersona.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtpersona.Location = New System.Drawing.Point(57, 63)
    Me.txtpersona.Name = "txtpersona"
    Me.txtpersona.ReadOnly = True
    Me.txtpersona.Size = New System.Drawing.Size(207, 20)
    Me.txtpersona.TabIndex = 3
    '
    'Label2
    '
    Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(8, 70)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(46, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Persona"
    '
    'txtnombre
    '
    Me.txtnombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtnombre.Location = New System.Drawing.Point(57, 93)
    Me.txtnombre.Name = "txtnombre"
    Me.txtnombre.Size = New System.Drawing.Size(237, 20)
    Me.txtnombre.TabIndex = 6
    '
    'Label1
    '
    Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(8, 100)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(43, 13)
    Me.Label1.TabIndex = 5
    Me.Label1.Text = "Usuario"
    '
    'frmGestionUsuario
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(1000, 433)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btncancelar)
    Me.Controls.Add(Me.btnregistrar)
    Me.Controls.Add(Me.btnnuevo)
    Me.Controls.Add(Me.btnseleccionar)
    Me.Controls.Add(Me.gbListaUsuarios)
    Me.Name = "frmGestionUsuario"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de usuarios"
    CType(Me.dvgusuario, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbListaUsuarios.ResumeLayout(False)
    Me.gbListaUsuarios.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.frmvigencia.ResumeLayout(False)
    Me.frmvigencia.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents dvgusuario As System.Windows.Forms.DataGridView
  Friend WithEvents btnseleccionar As System.Windows.Forms.Button
  Friend WithEvents gbListaUsuarios As System.Windows.Forms.GroupBox
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
  Friend WithEvents txtnombre As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
  Friend WithEvents cdUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdPersona As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdTipo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdVigencia As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cbogrupo As System.Windows.Forms.ComboBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtVerificar As System.Windows.Forms.TextBox
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents txtUsuarioBuscar As System.Windows.Forms.TextBox
  Friend WithEvents lblUsuarioBuscar As System.Windows.Forms.Label
  Friend WithEvents btnListar As System.Windows.Forms.Button
End Class
