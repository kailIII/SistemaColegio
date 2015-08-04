<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReasignarObligacion
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
    Me.lblAlumno = New System.Windows.Forms.Label
    Me.txtAlumno = New System.Windows.Forms.TextBox
    Me.lblObligacion = New System.Windows.Forms.Label
    Me.txtObligacion = New System.Windows.Forms.TextBox
    Me.lblHermano = New System.Windows.Forms.Label
    Me.cboHermanos = New System.Windows.Forms.ComboBox
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnReasignar = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'lblAlumno
    '
    Me.lblAlumno.AutoSize = True
    Me.lblAlumno.Location = New System.Drawing.Point(12, 30)
    Me.lblAlumno.Name = "lblAlumno"
    Me.lblAlumno.Size = New System.Drawing.Size(42, 13)
    Me.lblAlumno.TabIndex = 0
    Me.lblAlumno.Text = "Alumno"
    '
    'txtAlumno
    '
    Me.txtAlumno.Location = New System.Drawing.Point(68, 23)
    Me.txtAlumno.Name = "txtAlumno"
    Me.txtAlumno.Size = New System.Drawing.Size(400, 20)
    Me.txtAlumno.TabIndex = 1
    '
    'lblObligacion
    '
    Me.lblObligacion.AutoSize = True
    Me.lblObligacion.Location = New System.Drawing.Point(12, 74)
    Me.lblObligacion.Name = "lblObligacion"
    Me.lblObligacion.Size = New System.Drawing.Size(57, 13)
    Me.lblObligacion.TabIndex = 0
    Me.lblObligacion.Text = "Obligación"
    '
    'txtObligacion
    '
    Me.txtObligacion.Location = New System.Drawing.Point(68, 67)
    Me.txtObligacion.Name = "txtObligacion"
    Me.txtObligacion.Size = New System.Drawing.Size(400, 20)
    Me.txtObligacion.TabIndex = 1
    '
    'lblHermano
    '
    Me.lblHermano.AutoSize = True
    Me.lblHermano.Location = New System.Drawing.Point(12, 142)
    Me.lblHermano.Name = "lblHermano"
    Me.lblHermano.Size = New System.Drawing.Size(50, 13)
    Me.lblHermano.TabIndex = 0
    Me.lblHermano.Text = "&Hermano"
    '
    'cboHermano
    '
    Me.cboHermanos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboHermanos.FormattingEnabled = True
    Me.cboHermanos.Location = New System.Drawing.Point(68, 134)
    Me.cboHermanos.Name = "cboHermano"
    Me.cboHermanos.Size = New System.Drawing.Size(400, 21)
    Me.cboHermanos.TabIndex = 2
    '
    'btnCerrar
    '
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Location = New System.Drawing.Point(393, 227)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
    Me.btnCerrar.TabIndex = 3
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.UseVisualStyleBackColor = True
    '
    'btnReasignar
    '
    Me.btnReasignar.Location = New System.Drawing.Point(312, 227)
    Me.btnReasignar.Name = "btnReasignar"
    Me.btnReasignar.Size = New System.Drawing.Size(75, 23)
    Me.btnReasignar.TabIndex = 3
    Me.btnReasignar.Text = "&Reasignar"
    Me.btnReasignar.UseVisualStyleBackColor = True
    '
    'frmReasignarObligacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCerrar
    Me.ClientSize = New System.Drawing.Size(480, 262)
    Me.Controls.Add(Me.btnReasignar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.cboHermanos)
    Me.Controls.Add(Me.txtObligacion)
    Me.Controls.Add(Me.txtAlumno)
    Me.Controls.Add(Me.lblHermano)
    Me.Controls.Add(Me.lblObligacion)
    Me.Controls.Add(Me.lblAlumno)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmReasignarObligacion"
    Me.Text = "Reasignar obligación de pago"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblAlumno As System.Windows.Forms.Label
  Friend WithEvents txtAlumno As System.Windows.Forms.TextBox
  Friend WithEvents lblObligacion As System.Windows.Forms.Label
  Friend WithEvents txtObligacion As System.Windows.Forms.TextBox
  Friend WithEvents lblHermano As System.Windows.Forms.Label
  Friend WithEvents cboHermanos As System.Windows.Forms.ComboBox
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnReasignar As System.Windows.Forms.Button
End Class
