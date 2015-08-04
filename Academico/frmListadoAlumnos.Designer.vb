<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoAlumnos
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
    Me.btnExportar = New System.Windows.Forms.Button
    Me.pbAvance = New System.Windows.Forms.ProgressBar
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.cboSeccion = New System.Windows.Forms.ComboBox
    Me.lblSeccion = New System.Windows.Forms.Label
    Me.cboNivel = New System.Windows.Forms.ComboBox
    Me.lblNivel = New System.Windows.Forms.Label
    Me.SuspendLayout()
    '
    'btnExportar
    '
    Me.btnExportar.Location = New System.Drawing.Point(240, 215)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(87, 23)
    Me.btnExportar.TabIndex = 6
    Me.btnExportar.Text = "E&xportar"
    Me.btnExportar.UseVisualStyleBackColor = True
    '
    'pbAvance
    '
    Me.pbAvance.Location = New System.Drawing.Point(30, 147)
    Me.pbAvance.Name = "pbAvance"
    Me.pbAvance.Size = New System.Drawing.Size(390, 29)
    Me.pbAvance.TabIndex = 7
    Me.pbAvance.Visible = False
    '
    'btnCerrar
    '
    Me.btnCerrar.Location = New System.Drawing.Point(333, 215)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(87, 23)
    Me.btnCerrar.TabIndex = 8
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.UseVisualStyleBackColor = True
    '
    'cboSeccion
    '
    Me.cboSeccion.BackColor = System.Drawing.SystemColors.Info
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(83, 93)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(222, 24)
    Me.cboSeccion.TabIndex = 3
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSeccion.Location = New System.Drawing.Point(27, 102)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(49, 15)
    Me.lblSeccion.TabIndex = 2
    Me.lblSeccion.Text = "&Sección"
    '
    'cboNivel
    '
    Me.cboNivel.BackColor = System.Drawing.SystemColors.Info
    Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNivel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Location = New System.Drawing.Point(83, 41)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(222, 24)
    Me.cboNivel.TabIndex = 1
    '
    'lblNivel
    '
    Me.lblNivel.AutoSize = True
    Me.lblNivel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNivel.Location = New System.Drawing.Point(27, 50)
    Me.lblNivel.Name = "lblNivel"
    Me.lblNivel.Size = New System.Drawing.Size(35, 15)
    Me.lblNivel.TabIndex = 0
    Me.lblNivel.Text = "&Nivel"
    '
    'frmListadoAlumnos
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(443, 263)
    Me.Controls.Add(Me.cboNivel)
    Me.Controls.Add(Me.lblNivel)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.pbAvance)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.cboSeccion)
    Me.Controls.Add(Me.lblSeccion)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmListadoAlumnos"
    Me.Text = "Listado de alumnos"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents pbAvance As System.Windows.Forms.ProgressBar
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents lblNivel As System.Windows.Forms.Label
End Class
