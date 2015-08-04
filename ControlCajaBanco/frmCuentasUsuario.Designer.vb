<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuentasUsuario
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
    Me.components = New System.ComponentModel.Container()
    Me.GBContrasenia = New System.Windows.Forms.GroupBox()
    Me.lblUsuario = New System.Windows.Forms.Label()
    Me.lblContrasena = New System.Windows.Forms.Label()
    Me.txtUsuario = New System.Windows.Forms.TextBox()
    Me.txtClaveNueva = New System.Windows.Forms.TextBox()
    Me.txtClaveActual = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtReClaveNueva = New System.Windows.Forms.TextBox()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.btnRegistrar = New System.Windows.Forms.Button()
    Me.ErrUser = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.GBContrasenia.SuspendLayout()
    CType(Me.ErrUser, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'GBContrasenia
    '
    Me.GBContrasenia.Controls.Add(Me.lblUsuario)
    Me.GBContrasenia.Controls.Add(Me.lblContrasena)
    Me.GBContrasenia.Controls.Add(Me.txtUsuario)
    Me.GBContrasenia.Controls.Add(Me.txtClaveNueva)
    Me.GBContrasenia.Controls.Add(Me.txtClaveActual)
    Me.GBContrasenia.Controls.Add(Me.Label2)
    Me.GBContrasenia.Controls.Add(Me.Label1)
    Me.GBContrasenia.Controls.Add(Me.txtReClaveNueva)
    Me.GBContrasenia.Location = New System.Drawing.Point(12, 22)
    Me.GBContrasenia.Name = "GBContrasenia"
    Me.GBContrasenia.Size = New System.Drawing.Size(271, 212)
    Me.GBContrasenia.TabIndex = 3
    Me.GBContrasenia.TabStop = False
    Me.GBContrasenia.Text = "Cambiar Contraseña"
    '
    'lblUsuario
    '
    Me.lblUsuario.Location = New System.Drawing.Point(20, 16)
    Me.lblUsuario.Name = "lblUsuario"
    Me.lblUsuario.Size = New System.Drawing.Size(58, 23)
    Me.lblUsuario.TabIndex = 0
    Me.lblUsuario.Text = "&Usuario"
    Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblContrasena
    '
    Me.lblContrasena.Location = New System.Drawing.Point(20, 42)
    Me.lblContrasena.Name = "lblContrasena"
    Me.lblContrasena.Size = New System.Drawing.Size(220, 23)
    Me.lblContrasena.TabIndex = 2
    Me.lblContrasena.Text = "Contra&seña Anterior"
    Me.lblContrasena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'txtUsuario
    '
    Me.txtUsuario.Location = New System.Drawing.Point(84, 19)
    Me.txtUsuario.Name = "txtUsuario"
    Me.txtUsuario.ReadOnly = True
    Me.txtUsuario.Size = New System.Drawing.Size(157, 20)
    Me.txtUsuario.TabIndex = 1
    '
    'txtClaveNueva
    '
    Me.txtClaveNueva.Location = New System.Drawing.Point(87, 117)
    Me.txtClaveNueva.Name = "txtClaveNueva"
    Me.txtClaveNueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtClaveNueva.Size = New System.Drawing.Size(157, 20)
    Me.txtClaveNueva.TabIndex = 5
    '
    'txtClaveActual
    '
    Me.txtClaveActual.Location = New System.Drawing.Point(84, 68)
    Me.txtClaveActual.Name = "txtClaveActual"
    Me.txtClaveActual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtClaveActual.Size = New System.Drawing.Size(157, 20)
    Me.txtClaveActual.TabIndex = 3
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(23, 91)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(220, 23)
    Me.Label2.TabIndex = 4
    Me.Label2.Text = "Contraseña Nueva"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'Label1
    '
    Me.Label1.Location = New System.Drawing.Point(21, 140)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(220, 23)
    Me.Label1.TabIndex = 6
    Me.Label1.Text = "Confirmar Contraseña Nueva"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'txtReClaveNueva
    '
    Me.txtReClaveNueva.Location = New System.Drawing.Point(85, 166)
    Me.txtReClaveNueva.Name = "txtReClaveNueva"
    Me.txtReClaveNueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtReClaveNueva.Size = New System.Drawing.Size(157, 20)
    Me.txtReClaveNueva.TabIndex = 7
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(183, 254)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(100, 50)
    Me.btnCerrar.TabIndex = 5
    Me.btnCerrar.Text = "&Cancelar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Location = New System.Drawing.Point(38, 254)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(120, 49)
    Me.btnRegistrar.TabIndex = 4
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'ErrUser
    '
    Me.ErrUser.ContainerControl = Me
    '
    'frmCuentasUsuario
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(301, 318)
    Me.Controls.Add(Me.GBContrasenia)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Name = "frmCuentasUsuario"
    Me.Text = "Cambio de Contraseña"
    Me.GBContrasenia.ResumeLayout(False)
    Me.GBContrasenia.PerformLayout()
    CType(Me.ErrUser, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents GBContrasenia As System.Windows.Forms.GroupBox
  Friend WithEvents lblUsuario As System.Windows.Forms.Label
  Friend WithEvents lblContrasena As System.Windows.Forms.Label
  Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
  Friend WithEvents txtClaveNueva As System.Windows.Forms.TextBox
  Friend WithEvents txtClaveActual As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtReClaveNueva As System.Windows.Forms.TextBox
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents ErrUser As System.Windows.Forms.ErrorProvider
End Class
