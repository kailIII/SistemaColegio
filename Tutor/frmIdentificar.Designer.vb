<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmIdentificar
  Inherits Colegio.Plantillas.frmPlantilla

    'Form overrides dispose to clean up the component list.
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
  Friend WithEvents lblUsuario As System.Windows.Forms.Label
  Friend WithEvents lblContrasena As System.Windows.Forms.Label
  Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
  Friend WithEvents txtContrasena As System.Windows.Forms.TextBox
  Friend WithEvents btnIdentificar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIdentificar))
    Me.LogoPictureBox = New System.Windows.Forms.PictureBox
    Me.lblUsuario = New System.Windows.Forms.Label
    Me.lblContrasena = New System.Windows.Forms.Label
    Me.txtUsuario = New System.Windows.Forms.TextBox
    Me.txtContrasena = New System.Windows.Forms.TextBox
    Me.btnIdentificar = New System.Windows.Forms.Button
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.Label1 = New System.Windows.Forms.Label
    CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'LogoPictureBox
    '
    Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
    Me.LogoPictureBox.Location = New System.Drawing.Point(0, 44)
    Me.LogoPictureBox.Name = "LogoPictureBox"
    Me.LogoPictureBox.Size = New System.Drawing.Size(165, 193)
    Me.LogoPictureBox.TabIndex = 0
    Me.LogoPictureBox.TabStop = False
    '
    'lblUsuario
    '
    Me.lblUsuario.Location = New System.Drawing.Point(172, 46)
    Me.lblUsuario.Name = "lblUsuario"
    Me.lblUsuario.Size = New System.Drawing.Size(220, 23)
    Me.lblUsuario.TabIndex = 0
    Me.lblUsuario.Text = "&Usuario"
    Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblContrasena
    '
    Me.lblContrasena.Location = New System.Drawing.Point(172, 103)
    Me.lblContrasena.Name = "lblContrasena"
    Me.lblContrasena.Size = New System.Drawing.Size(220, 23)
    Me.lblContrasena.TabIndex = 2
    Me.lblContrasena.Text = "Contra&seña"
    Me.lblContrasena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'txtUsuario
    '
    Me.txtUsuario.Location = New System.Drawing.Point(174, 66)
    Me.txtUsuario.Name = "txtUsuario"
    Me.txtUsuario.Size = New System.Drawing.Size(220, 20)
    Me.txtUsuario.TabIndex = 1
    '
    'txtContrasena
    '
    Me.txtContrasena.Location = New System.Drawing.Point(174, 123)
    Me.txtContrasena.Name = "txtContrasena"
    Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtContrasena.Size = New System.Drawing.Size(220, 20)
    Me.txtContrasena.TabIndex = 3
    '
    'btnIdentificar
    '
    Me.btnIdentificar.Location = New System.Drawing.Point(197, 196)
    Me.btnIdentificar.Name = "btnIdentificar"
    Me.btnIdentificar.Size = New System.Drawing.Size(94, 23)
    Me.btnIdentificar.TabIndex = 4
    Me.btnIdentificar.Text = "&Identificar"
    '
    'btnCancelar
    '
    Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancelar.Location = New System.Drawing.Point(300, 196)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(94, 23)
    Me.btnCancelar.TabIndex = 5
    Me.btnCancelar.Text = "&Cancelar"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(72, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(259, 22)
    Me.Label1.TabIndex = 8
    Me.Label1.Text = "MÓDULO TUTOR DE AULA"
    '
    'frmIdentificar
    '
    Me.AcceptButton = Me.btnIdentificar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCancelar
    Me.ClientSize = New System.Drawing.Size(401, 231)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnIdentificar)
    Me.Controls.Add(Me.txtContrasena)
    Me.Controls.Add(Me.txtUsuario)
    Me.Controls.Add(Me.lblContrasena)
    Me.Controls.Add(Me.lblUsuario)
    Me.Controls.Add(Me.LogoPictureBox)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmIdentificar"
    Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Identificación"
    CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
