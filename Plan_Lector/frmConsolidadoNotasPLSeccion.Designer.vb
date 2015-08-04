<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsolidadoNotasPLSeccion
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
    Me.lblAnio = New System.Windows.Forms.Label
    Me.lblSeccion = New System.Windows.Forms.Label
    Me.txtAnio = New System.Windows.Forms.TextBox
    Me.cboSeccion = New System.Windows.Forms.ComboBox
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnExportar = New System.Windows.Forms.Button
    Me.cboNivel = New System.Windows.Forms.ComboBox
    Me.lblNivel = New System.Windows.Forms.Label
    Me.SuspendLayout()
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblAnio.Location = New System.Drawing.Point(41, 41)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(36, 17)
    Me.lblAnio.TabIndex = 0
    Me.lblAnio.Text = "&Anio"
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblSeccion.Location = New System.Drawing.Point(23, 144)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(54, 17)
    Me.lblSeccion.TabIndex = 4
    Me.lblSeccion.Text = "&Sección"
    '
    'txtAnio
    '
    Me.txtAnio.BackColor = System.Drawing.Color.White
    Me.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.txtAnio.Location = New System.Drawing.Point(85, 33)
    Me.txtAnio.Name = "txtAnio"
    Me.txtAnio.ReadOnly = True
    Me.txtAnio.Size = New System.Drawing.Size(100, 25)
    Me.txtAnio.TabIndex = 1
    Me.txtAnio.TabStop = False
    Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'cboSeccion
    '
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(85, 136)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(223, 25)
    Me.cboSeccion.TabIndex = 5
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(275, 184)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 7
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnExportar
    '
    Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnExportar.BackColor = System.Drawing.Color.White
    Me.btnExportar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnExportar.Location = New System.Drawing.Point(140, 184)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(110, 52)
    Me.btnExportar.TabIndex = 6
    Me.btnExportar.Text = "E&xportar"
    Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnExportar.UseVisualStyleBackColor = False
    '
    'cboNivel
    '
    Me.cboNivel.BackColor = System.Drawing.SystemColors.Info
    Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNivel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Location = New System.Drawing.Point(85, 83)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(223, 24)
    Me.cboNivel.TabIndex = 3
    '
    'lblNivel
    '
    Me.lblNivel.AutoSize = True
    Me.lblNivel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNivel.Location = New System.Drawing.Point(42, 92)
    Me.lblNivel.Name = "lblNivel"
    Me.lblNivel.Size = New System.Drawing.Size(35, 15)
    Me.lblNivel.TabIndex = 2
    Me.lblNivel.Text = "&Nivel"
    '
    'frmConsolidadoNotasPLSeccion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(397, 248)
    Me.Controls.Add(Me.cboNivel)
    Me.Controls.Add(Me.lblNivel)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.lblAnio)
    Me.Controls.Add(Me.lblSeccion)
    Me.Controls.Add(Me.txtAnio)
    Me.Controls.Add(Me.cboSeccion)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmConsolidadoNotasPLSeccion"
    Me.Text = "Consolidado de notas de plan lector por sección"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents txtAnio As System.Windows.Forms.TextBox
  Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents lblNivel As System.Windows.Forms.Label
End Class
