<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarObligacion
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
    Me.components = New System.ComponentModel.Container
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.lblDescripcion = New System.Windows.Forms.Label
    Me.txtDescripcion = New System.Windows.Forms.TextBox
    Me.lblMonto = New System.Windows.Forms.Label
    Me.nudMonto = New System.Windows.Forms.NumericUpDown
    Me.btnAceptar = New System.Windows.Forms.Button
    Me.errObligacion = New System.Windows.Forms.ErrorProvider(Me.components)
    CType(Me.nudMonto, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.errObligacion, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(329, 133)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 58)
    Me.btnCerrar.TabIndex = 10
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'lblDescripcion
    '
    Me.lblDescripcion.AutoSize = True
    Me.lblDescripcion.Location = New System.Drawing.Point(28, 39)
    Me.lblDescripcion.Name = "lblDescripcion"
    Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
    Me.lblDescripcion.TabIndex = 11
    Me.lblDescripcion.Text = "&Descripción"
    '
    'txtDescripcion
    '
    Me.txtDescripcion.Location = New System.Drawing.Point(101, 32)
    Me.txtDescripcion.Name = "txtDescripcion"
    Me.txtDescripcion.Size = New System.Drawing.Size(338, 20)
    Me.txtDescripcion.TabIndex = 12
    '
    'lblMonto
    '
    Me.lblMonto.AutoSize = True
    Me.lblMonto.Location = New System.Drawing.Point(28, 92)
    Me.lblMonto.Name = "lblMonto"
    Me.lblMonto.Size = New System.Drawing.Size(37, 13)
    Me.lblMonto.TabIndex = 11
    Me.lblMonto.Text = "&Monto"
    '
    'nudMonto
    '
    Me.nudMonto.DecimalPlaces = 2
    Me.nudMonto.Location = New System.Drawing.Point(101, 85)
    Me.nudMonto.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
    Me.nudMonto.Name = "nudMonto"
    Me.nudMonto.Size = New System.Drawing.Size(75, 20)
    Me.nudMonto.TabIndex = 13
    Me.nudMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'btnAceptar
    '
    Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnAceptar.BackColor = System.Drawing.Color.White
    Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnAceptar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAceptar.Location = New System.Drawing.Point(202, 133)
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(110, 58)
    Me.btnAceptar.TabIndex = 10
    Me.btnAceptar.Text = "&Aceptar"
    Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnAceptar.UseVisualStyleBackColor = False
    '
    'errObligacion
    '
    Me.errObligacion.ContainerControl = Me
    '
    'frmModificarObligacion
    '
    Me.AcceptButton = Me.btnAceptar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCerrar
    Me.ClientSize = New System.Drawing.Size(451, 203)
    Me.Controls.Add(Me.nudMonto)
    Me.Controls.Add(Me.txtDescripcion)
    Me.Controls.Add(Me.lblMonto)
    Me.Controls.Add(Me.lblDescripcion)
    Me.Controls.Add(Me.btnAceptar)
    Me.Controls.Add(Me.btnCerrar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmModificarObligacion"
    Me.Text = "Actualizar datos de obligación"
    CType(Me.nudMonto, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.errObligacion, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents lblDescripcion As System.Windows.Forms.Label
  Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
  Friend WithEvents lblMonto As System.Windows.Forms.Label
  Friend WithEvents nudMonto As System.Windows.Forms.NumericUpDown
  Friend WithEvents btnAceptar As System.Windows.Forms.Button
  Friend WithEvents errObligacion As System.Windows.Forms.ErrorProvider
End Class
