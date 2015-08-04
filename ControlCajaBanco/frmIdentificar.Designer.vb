<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIdentificar
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIdentificar))
    Me.lblModulo = New System.Windows.Forms.Label()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.btnIdentificar = New System.Windows.Forms.Button()
    Me.txtContrasena = New System.Windows.Forms.TextBox()
    Me.txtUsuario = New System.Windows.Forms.TextBox()
    Me.lblContrasena = New System.Windows.Forms.Label()
    Me.lblUsuario = New System.Windows.Forms.Label()
    Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
    CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblModulo
    '
    Me.lblModulo.AutoSize = True
    Me.lblModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblModulo.Location = New System.Drawing.Point(55, 9)
    Me.lblModulo.Name = "lblModulo"
    Me.lblModulo.Size = New System.Drawing.Size(269, 22)
    Me.lblModulo.TabIndex = 16
    Me.lblModulo.Text = "CONTROL CAJA Y BANCOS"
    '
    'btnCancelar
    '
    Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancelar.Location = New System.Drawing.Point(301, 202)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(94, 23)
    Me.btnCancelar.TabIndex = 15
    Me.btnCancelar.Text = "&Cancelar"
    '
    'btnIdentificar
    '
    Me.btnIdentificar.Location = New System.Drawing.Point(198, 202)
    Me.btnIdentificar.Name = "btnIdentificar"
    Me.btnIdentificar.Size = New System.Drawing.Size(94, 23)
    Me.btnIdentificar.TabIndex = 14
    Me.btnIdentificar.Text = "&Identificar"
    '
    'txtContrasena
    '
    Me.txtContrasena.Location = New System.Drawing.Point(174, 138)
    Me.txtContrasena.Name = "txtContrasena"
    Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtContrasena.Size = New System.Drawing.Size(220, 20)
    Me.txtContrasena.TabIndex = 13
    '
    'txtUsuario
    '
    Me.txtUsuario.Location = New System.Drawing.Point(174, 81)
    Me.txtUsuario.Name = "txtUsuario"
    Me.txtUsuario.Size = New System.Drawing.Size(220, 20)
    Me.txtUsuario.TabIndex = 11
    '
    'lblContrasena
    '
    Me.lblContrasena.Location = New System.Drawing.Point(172, 118)
    Me.lblContrasena.Name = "lblContrasena"
    Me.lblContrasena.Size = New System.Drawing.Size(220, 23)
    Me.lblContrasena.TabIndex = 12
    Me.lblContrasena.Text = "Contra&seña"
    Me.lblContrasena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblUsuario
    '
    Me.lblUsuario.Location = New System.Drawing.Point(172, 61)
    Me.lblUsuario.Name = "lblUsuario"
    Me.lblUsuario.Size = New System.Drawing.Size(220, 23)
    Me.lblUsuario.TabIndex = 9
    Me.lblUsuario.Text = "&Usuario"
    Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'LogoPictureBox
    '
    Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
    Me.LogoPictureBox.Location = New System.Drawing.Point(1, 49)
    Me.LogoPictureBox.Name = "LogoPictureBox"
    Me.LogoPictureBox.Size = New System.Drawing.Size(165, 193)
    Me.LogoPictureBox.TabIndex = 10
    Me.LogoPictureBox.TabStop = False
    '
    'frmIdentificar
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(407, 255)
    Me.Controls.Add(Me.lblModulo)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnIdentificar)
    Me.Controls.Add(Me.txtContrasena)
    Me.Controls.Add(Me.txtUsuario)
    Me.Controls.Add(Me.lblContrasena)
    Me.Controls.Add(Me.lblUsuario)
    Me.Controls.Add(Me.LogoPictureBox)
    Me.Name = "frmIdentificar"
    Me.Text = "Identificación"
    CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblModulo As System.Windows.Forms.Label
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnIdentificar As System.Windows.Forms.Button
  Friend WithEvents txtContrasena As System.Windows.Forms.TextBox
  Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
  Friend WithEvents lblContrasena As System.Windows.Forms.Label
  Friend WithEvents lblUsuario As System.Windows.Forms.Label
  Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
End Class
