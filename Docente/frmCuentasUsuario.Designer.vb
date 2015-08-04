<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuentasUsuario
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
    Me.lblUsuario = New System.Windows.Forms.Label
    Me.GBContrasenia = New System.Windows.Forms.GroupBox
    Me.lblContrasena = New System.Windows.Forms.Label
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.txtUsuario = New System.Windows.Forms.TextBox
    Me.txtClaveNueva = New System.Windows.Forms.TextBox
    Me.txtClaveActual = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.txtReClaveNueva = New System.Windows.Forms.TextBox
    Me.ErrUser = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.GBContrasenia.SuspendLayout()
    CType(Me.ErrUser, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
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
    Me.GBContrasenia.Location = New System.Drawing.Point(10, 11)
    Me.GBContrasenia.Name = "GBContrasenia"
    Me.GBContrasenia.Size = New System.Drawing.Size(271, 221)
    Me.GBContrasenia.TabIndex = 0
    Me.GBContrasenia.TabStop = False
    Me.GBContrasenia.Text = "Cambiar Contraseña"
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
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Location = New System.Drawing.Point(33, 248)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(113, 50)
    Me.btnRegistrar.TabIndex = 1
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.UseVisualStyleBackColor = False
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
    'ErrUser
    '
    Me.ErrUser.ContainerControl = Me
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(181, 248)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(100, 50)
    Me.btnCerrar.TabIndex = 2
    Me.btnCerrar.Text = "&Cancelar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'frmCuentasUsuario
    '
    Me.AcceptButton = Me.btnRegistrar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.CancelButton = Me.btnCerrar
    Me.ClientSize = New System.Drawing.Size(291, 311)
    Me.Controls.Add(Me.GBContrasenia)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmCuentasUsuario"
    Me.ShowIcon = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Cambio de Contraseña"
    Me.GBContrasenia.ResumeLayout(False)
    Me.GBContrasenia.PerformLayout()
    CType(Me.ErrUser, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents lblUsuario As System.Windows.Forms.Label
  Friend WithEvents GBContrasenia As System.Windows.Forms.GroupBox
  Friend WithEvents lblContrasena As System.Windows.Forms.Label
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
  Friend WithEvents txtClaveNueva As System.Windows.Forms.TextBox
  Friend WithEvents txtClaveActual As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtReClaveNueva As System.Windows.Forms.TextBox
  Friend WithEvents ErrUser As System.Windows.Forms.ErrorProvider
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
End Class
