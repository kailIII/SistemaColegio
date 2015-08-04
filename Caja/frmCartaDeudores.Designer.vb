<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCartaDeudores
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
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnExportar = New System.Windows.Forms.Button
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.cboNivel = New System.Windows.Forms.ComboBox
    Me.lblNivel = New System.Windows.Forms.Label
    Me.cboSeccion = New System.Windows.Forms.ComboBox
    Me.lblSeccion = New System.Windows.Forms.Label
    Me.cbanio = New System.Windows.Forms.ComboBox
    Me.lblAnio = New System.Windows.Forms.Label
    Me.pbAvance = New System.Windows.Forms.ProgressBar
    Me.Label1 = New System.Windows.Forms.Label
    Me.GroupBox1.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(416, 159)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 58)
    Me.btnCerrar.TabIndex = 7
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnExportar
    '
    Me.btnExportar.BackColor = System.Drawing.Color.White
    Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnExportar.Location = New System.Drawing.Point(416, 70)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(110, 52)
    Me.btnExportar.TabIndex = 6
    Me.btnExportar.Text = "&Exportar"
    Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnExportar.UseVisualStyleBackColor = False
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.pbAvance)
    Me.GroupBox1.Controls.Add(Me.Panel1)
    Me.GroupBox1.Location = New System.Drawing.Point(12, 62)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(386, 211)
    Me.GroupBox1.TabIndex = 15
    Me.GroupBox1.TabStop = False
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
    Me.Panel1.Controls.Add(Me.cboNivel)
    Me.Panel1.Controls.Add(Me.lblNivel)
    Me.Panel1.Controls.Add(Me.cboSeccion)
    Me.Panel1.Controls.Add(Me.lblSeccion)
    Me.Panel1.Controls.Add(Me.cbanio)
    Me.Panel1.Controls.Add(Me.lblAnio)
    Me.Panel1.Location = New System.Drawing.Point(16, 17)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(352, 125)
    Me.Panel1.TabIndex = 15
    '
    'cboNivel
    '
    Me.cboNivel.BackColor = System.Drawing.SystemColors.Window
    Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Location = New System.Drawing.Point(141, 50)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(194, 24)
    Me.cboNivel.TabIndex = 17
    '
    'lblNivel
    '
    Me.lblNivel.AutoSize = True
    Me.lblNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNivel.Location = New System.Drawing.Point(4, 50)
    Me.lblNivel.Name = "lblNivel"
    Me.lblNivel.Size = New System.Drawing.Size(45, 18)
    Me.lblNivel.TabIndex = 16
    Me.lblNivel.Text = "&Nivel"
    '
    'cboSeccion
    '
    Me.cboSeccion.BackColor = System.Drawing.SystemColors.Window
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(141, 77)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(198, 24)
    Me.cboSeccion.TabIndex = 19
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSeccion.Location = New System.Drawing.Point(3, 80)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(132, 18)
    Me.lblSeccion.TabIndex = 18
    Me.lblSeccion.Text = "&Grado y sección"
    '
    'cbanio
    '
    Me.cbanio.BackColor = System.Drawing.SystemColors.Window
    Me.cbanio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbanio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbanio.FormattingEnabled = True
    Me.cbanio.Location = New System.Drawing.Point(141, 23)
    Me.cbanio.Name = "cbanio"
    Me.cbanio.Size = New System.Drawing.Size(90, 24)
    Me.cbanio.TabIndex = 15
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAnio.Location = New System.Drawing.Point(4, 23)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(91, 18)
    Me.lblAnio.TabIndex = 14
    Me.lblAnio.Text = "Año &lectivo"
    '
    'pbAvance
    '
    Me.pbAvance.BackColor = System.Drawing.Color.White
    Me.pbAvance.Location = New System.Drawing.Point(16, 158)
    Me.pbAvance.Maximum = 50
    Me.pbAvance.Name = "pbAvance"
    Me.pbAvance.Size = New System.Drawing.Size(352, 20)
    Me.pbAvance.TabIndex = 16
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(166, 27)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(159, 18)
    Me.Label1.TabIndex = 14
    Me.Label1.Text = "GENERAR CARTAS"
    '
    'frmCartaDeudores
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(538, 353)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.Label1)
    Me.MaximizeBox = False
    Me.Name = "frmCartaDeudores"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "CARTA DEUDORES"
    Me.GroupBox1.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents lblNivel As System.Windows.Forms.Label
  Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents cbanio As System.Windows.Forms.ComboBox
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents pbAvance As System.Windows.Forms.ProgressBar
  Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
