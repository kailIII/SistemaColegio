<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerarCarnet
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
    Me.btnExportar = New System.Windows.Forms.Button()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.gbExportar = New System.Windows.Forms.GroupBox()
    Me.cboFormato = New System.Windows.Forms.ComboBox()
    Me.lblFormato = New System.Windows.Forms.Label()
    Me.gbDatos = New System.Windows.Forms.GroupBox()
    Me.txtAnio = New System.Windows.Forms.TextBox()
    Me.cboGrado = New System.Windows.Forms.ComboBox()
    Me.cboNivel = New System.Windows.Forms.ComboBox()
    Me.lblAnio = New System.Windows.Forms.Label()
    Me.lblNivel = New System.Windows.Forms.Label()
    Me.lblGrado = New System.Windows.Forms.Label()
    Me.pbAvance = New System.Windows.Forms.ProgressBar()
    Me.gbExportar.SuspendLayout()
    Me.gbDatos.SuspendLayout()
    Me.SuspendLayout()
    '
    'btnExportar
    '
    Me.btnExportar.BackColor = System.Drawing.Color.White
    Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnExportar.Location = New System.Drawing.Point(240, 321)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(110, 50)
    Me.btnExportar.TabIndex = 1
    Me.btnExportar.Text = "&Exportar"
    Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnExportar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(357, 321)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 50)
    Me.btnCerrar.TabIndex = 2
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'gbExportar
    '
    Me.gbExportar.Controls.Add(Me.cboFormato)
    Me.gbExportar.Controls.Add(Me.lblFormato)
    Me.gbExportar.Controls.Add(Me.gbDatos)
    Me.gbExportar.Controls.Add(Me.pbAvance)
    Me.gbExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbExportar.Location = New System.Drawing.Point(14, 32)
    Me.gbExportar.Name = "gbExportar"
    Me.gbExportar.Size = New System.Drawing.Size(453, 283)
    Me.gbExportar.TabIndex = 0
    Me.gbExportar.TabStop = False
    Me.gbExportar.Text = "Generar carnet de alumno"
    '
    'cboFormato
    '
    Me.cboFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboFormato.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboFormato.FormattingEnabled = True
    Me.cboFormato.Items.AddRange(New Object() {"Inicial - Primaria", "Secundaria"})
    Me.cboFormato.Location = New System.Drawing.Point(120, 187)
    Me.cboFormato.Name = "cboFormato"
    Me.cboFormato.Size = New System.Drawing.Size(259, 24)
    Me.cboFormato.TabIndex = 2
    Me.cboFormato.Visible = False
    '
    'lblFormato
    '
    Me.lblFormato.AutoSize = True
    Me.lblFormato.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFormato.Location = New System.Drawing.Point(48, 196)
    Me.lblFormato.Name = "lblFormato"
    Me.lblFormato.Size = New System.Drawing.Size(51, 15)
    Me.lblFormato.TabIndex = 1
    Me.lblFormato.Text = "&Formato"
    Me.lblFormato.Visible = False
    '
    'gbDatos
    '
    Me.gbDatos.Controls.Add(Me.txtAnio)
    Me.gbDatos.Controls.Add(Me.cboGrado)
    Me.gbDatos.Controls.Add(Me.cboNivel)
    Me.gbDatos.Controls.Add(Me.lblAnio)
    Me.gbDatos.Controls.Add(Me.lblNivel)
    Me.gbDatos.Controls.Add(Me.lblGrado)
    Me.gbDatos.Location = New System.Drawing.Point(51, 24)
    Me.gbDatos.Name = "gbDatos"
    Me.gbDatos.Size = New System.Drawing.Size(350, 153)
    Me.gbDatos.TabIndex = 0
    Me.gbDatos.TabStop = False
    '
    'txtAnio
    '
    Me.txtAnio.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAnio.Location = New System.Drawing.Point(130, 21)
    Me.txtAnio.Name = "txtAnio"
    Me.txtAnio.ReadOnly = True
    Me.txtAnio.Size = New System.Drawing.Size(198, 22)
    Me.txtAnio.TabIndex = 1
    Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'cboGrado
    '
    Me.cboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboGrado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboGrado.FormattingEnabled = True
    Me.cboGrado.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.cboGrado.Items.AddRange(New Object() {"Todos"})
    Me.cboGrado.Location = New System.Drawing.Point(130, 107)
    Me.cboGrado.Name = "cboGrado"
    Me.cboGrado.Size = New System.Drawing.Size(198, 24)
    Me.cboGrado.TabIndex = 5
    '
    'cboNivel
    '
    Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNivel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Location = New System.Drawing.Point(130, 65)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(198, 24)
    Me.cboNivel.TabIndex = 3
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAnio.Location = New System.Drawing.Point(86, 28)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(31, 15)
    Me.lblAnio.TabIndex = 0
    Me.lblAnio.Text = "A&ño"
    '
    'lblNivel
    '
    Me.lblNivel.AutoSize = True
    Me.lblNivel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNivel.Location = New System.Drawing.Point(81, 74)
    Me.lblNivel.Name = "lblNivel"
    Me.lblNivel.Size = New System.Drawing.Size(35, 15)
    Me.lblNivel.TabIndex = 2
    Me.lblNivel.Text = "&Nivel"
    '
    'lblGrado
    '
    Me.lblGrado.AutoSize = True
    Me.lblGrado.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblGrado.Location = New System.Drawing.Point(76, 116)
    Me.lblGrado.Name = "lblGrado"
    Me.lblGrado.Size = New System.Drawing.Size(39, 15)
    Me.lblGrado.TabIndex = 4
    Me.lblGrado.Text = "&Grado"
    '
    'pbAvance
    '
    Me.pbAvance.BackColor = System.Drawing.Color.White
    Me.pbAvance.Location = New System.Drawing.Point(51, 240)
    Me.pbAvance.Name = "pbAvance"
    Me.pbAvance.Size = New System.Drawing.Size(350, 20)
    Me.pbAvance.TabIndex = 3
    Me.pbAvance.Visible = False
    '
    'frmGenerarCarnet
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(479, 383)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.gbExportar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmGenerarCarnet"
    Me.Text = "Generación de carnets"
    Me.gbExportar.ResumeLayout(False)
    Me.gbExportar.PerformLayout()
    Me.gbDatos.ResumeLayout(False)
    Me.gbDatos.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents gbExportar As System.Windows.Forms.GroupBox
  Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
  Friend WithEvents cboGrado As System.Windows.Forms.ComboBox
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents lblNivel As System.Windows.Forms.Label
  Friend WithEvents lblGrado As System.Windows.Forms.Label
  Friend WithEvents pbAvance As System.Windows.Forms.ProgressBar
  Friend WithEvents txtAnio As System.Windows.Forms.TextBox
  Friend WithEvents cboFormato As System.Windows.Forms.ComboBox
  Friend WithEvents lblFormato As System.Windows.Forms.Label
End Class
