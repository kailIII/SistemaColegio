<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCerrarPeriodo
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
    Me.gbCerrarPeriodo = New System.Windows.Forms.GroupBox
    Me.txtPeriodo = New System.Windows.Forms.TextBox
    Me.btnCerrarPer = New System.Windows.Forms.Button
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.rbPromedioNotas = New System.Windows.Forms.RadioButton
    Me.rbCompAsist = New System.Windows.Forms.RadioButton
    Me.gbCalcular = New System.Windows.Forms.GroupBox
    Me.gbCerrarPeriodo.SuspendLayout()
    Me.gbCalcular.SuspendLayout()
    Me.SuspendLayout()
    '
    'gbCerrarPeriodo
    '
    Me.gbCerrarPeriodo.Controls.Add(Me.txtPeriodo)
    Me.gbCerrarPeriodo.Location = New System.Drawing.Point(23, 12)
    Me.gbCerrarPeriodo.Name = "gbCerrarPeriodo"
    Me.gbCerrarPeriodo.Size = New System.Drawing.Size(300, 73)
    Me.gbCerrarPeriodo.TabIndex = 2
    Me.gbCerrarPeriodo.TabStop = False
    Me.gbCerrarPeriodo.Text = "Periodo Académico Actual"
    '
    'txtPeriodo
    '
    Me.txtPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtPeriodo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPeriodo.Location = New System.Drawing.Point(44, 30)
    Me.txtPeriodo.Multiline = True
    Me.txtPeriodo.Name = "txtPeriodo"
    Me.txtPeriodo.ReadOnly = True
    Me.txtPeriodo.Size = New System.Drawing.Size(212, 24)
    Me.txtPeriodo.TabIndex = 0
    Me.txtPeriodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'btnCerrarPer
    '
    Me.btnCerrarPer.BackColor = System.Drawing.Color.White
    Me.btnCerrarPer.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrarPer.Location = New System.Drawing.Point(23, 200)
    Me.btnCerrarPer.Name = "btnCerrarPer"
    Me.btnCerrarPer.Size = New System.Drawing.Size(115, 45)
    Me.btnCerrarPer.TabIndex = 0
    Me.btnCerrarPer.Text = "Calcular Promedio"
    Me.btnCerrarPer.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(208, 200)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(115, 45)
    Me.btnCancelar.TabIndex = 1
    Me.btnCancelar.Text = "C&ancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'rbPromedioNotas
    '
    Me.rbPromedioNotas.AutoSize = True
    Me.rbPromedioNotas.Location = New System.Drawing.Point(22, 22)
    Me.rbPromedioNotas.Name = "rbPromedioNotas"
    Me.rbPromedioNotas.Size = New System.Drawing.Size(257, 17)
    Me.rbPromedioNotas.TabIndex = 3
    Me.rbPromedioNotas.Text = "Promediar notas finales de áreas de cada alumno"
    Me.rbPromedioNotas.UseVisualStyleBackColor = True
    '
    'rbCompAsist
    '
    Me.rbCompAsist.AutoSize = True
    Me.rbCompAsist.Location = New System.Drawing.Point(22, 49)
    Me.rbCompAsist.Name = "rbCompAsist"
    Me.rbCompAsist.Size = New System.Drawing.Size(248, 17)
    Me.rbCompAsist.TabIndex = 4
    Me.rbCompAsist.TabStop = True
    Me.rbCompAsist.Text = "Calcular notas de comportamiento y asistencias"
    Me.rbCompAsist.UseVisualStyleBackColor = True
    '
    'gbCalcular
    '
    Me.gbCalcular.Controls.Add(Me.rbCompAsist)
    Me.gbCalcular.Controls.Add(Me.rbPromedioNotas)
    Me.gbCalcular.Location = New System.Drawing.Point(23, 99)
    Me.gbCalcular.Name = "gbCalcular"
    Me.gbCalcular.Size = New System.Drawing.Size(300, 80)
    Me.gbCalcular.TabIndex = 5
    Me.gbCalcular.TabStop = False
    '
    'frmCerrarPeriodo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCancelar
    Me.ClientSize = New System.Drawing.Size(346, 258)
    Me.Controls.Add(Me.gbCalcular)
    Me.Controls.Add(Me.btnCerrarPer)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.gbCerrarPeriodo)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.Name = "frmCerrarPeriodo"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Cerrar Periodo"
    Me.gbCerrarPeriodo.ResumeLayout(False)
    Me.gbCerrarPeriodo.PerformLayout()
    Me.gbCalcular.ResumeLayout(False)
    Me.gbCalcular.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents gbCerrarPeriodo As System.Windows.Forms.GroupBox
  Friend WithEvents txtPeriodo As System.Windows.Forms.TextBox
  Friend WithEvents btnCerrarPer As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents rbPromedioNotas As System.Windows.Forms.RadioButton
  Friend WithEvents rbCompAsist As System.Windows.Forms.RadioButton
  Friend WithEvents gbCalcular As System.Windows.Forms.GroupBox
End Class
