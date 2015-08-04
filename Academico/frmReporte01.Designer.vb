<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporte01
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
        Me.gbExportar = New System.Windows.Forms.GroupBox
        Me.gbNomina = New System.Windows.Forms.GroupBox
        Me.cboSeccion = New System.Windows.Forms.ComboBox
        Me.cboGrado = New System.Windows.Forms.ComboBox
        Me.cboNivel = New System.Windows.Forms.ComboBox
        Me.cboAnio = New System.Windows.Forms.ComboBox
        Me.lblAnio = New System.Windows.Forms.Label
        Me.lblSeccion = New System.Windows.Forms.Label
        Me.lblNivel = New System.Windows.Forms.Label
        Me.lblGrado = New System.Windows.Forms.Label
        Me.pbAvance = New System.Windows.Forms.ProgressBar
        Me.btnExportar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.gbExportar.SuspendLayout()
        Me.gbNomina.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbExportar
        '
        Me.gbExportar.Controls.Add(Me.gbNomina)
        Me.gbExportar.Controls.Add(Me.pbAvance)
        Me.gbExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbExportar.Location = New System.Drawing.Point(44, 17)
        Me.gbExportar.Name = "gbExportar"
        Me.gbExportar.Size = New System.Drawing.Size(452, 242)
        Me.gbExportar.TabIndex = 0
        Me.gbExportar.TabStop = False
        Me.gbExportar.Text = "Generar"
        '
        'gbNomina
        '
        Me.gbNomina.Controls.Add(Me.cboSeccion)
        Me.gbNomina.Controls.Add(Me.cboGrado)
        Me.gbNomina.Controls.Add(Me.cboNivel)
        Me.gbNomina.Controls.Add(Me.cboAnio)
        Me.gbNomina.Controls.Add(Me.lblAnio)
        Me.gbNomina.Controls.Add(Me.lblSeccion)
        Me.gbNomina.Controls.Add(Me.lblNivel)
        Me.gbNomina.Controls.Add(Me.lblGrado)
        Me.gbNomina.Location = New System.Drawing.Point(59, 24)
        Me.gbNomina.Name = "gbNomina"
        Me.gbNomina.Size = New System.Drawing.Size(334, 153)
        Me.gbNomina.TabIndex = 0
        Me.gbNomina.TabStop = False
        '
        'cboSeccion
        '
        Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSeccion.FormattingEnabled = True
        Me.cboSeccion.Location = New System.Drawing.Point(130, 111)
        Me.cboSeccion.Name = "cboSeccion"
        Me.cboSeccion.Size = New System.Drawing.Size(139, 24)
        Me.cboSeccion.TabIndex = 7
        '
        'cboGrado
        '
        Me.cboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGrado.FormattingEnabled = True
        Me.cboGrado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboGrado.Items.AddRange(New Object() {"Todos"})
        Me.cboGrado.Location = New System.Drawing.Point(130, 82)
        Me.cboGrado.Name = "cboGrado"
        Me.cboGrado.Size = New System.Drawing.Size(139, 24)
        Me.cboGrado.TabIndex = 5
        '
        'cboNivel
        '
        Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNivel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNivel.FormattingEnabled = True
        Me.cboNivel.Location = New System.Drawing.Point(130, 53)
        Me.cboNivel.Name = "cboNivel"
        Me.cboNivel.Size = New System.Drawing.Size(139, 24)
        Me.cboNivel.TabIndex = 3
        '
        'cboAnio
        '
        Me.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAnio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnio.FormattingEnabled = True
        Me.cboAnio.Location = New System.Drawing.Point(130, 24)
        Me.cboAnio.Name = "cboAnio"
        Me.cboAnio.Size = New System.Drawing.Size(139, 24)
        Me.cboAnio.TabIndex = 1
        '
        'lblAnio
        '
        Me.lblAnio.AutoSize = True
        Me.lblAnio.Location = New System.Drawing.Point(86, 28)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(31, 15)
        Me.lblAnio.TabIndex = 0
        Me.lblAnio.Text = "A&ño"
        '
        'lblSeccion
        '
        Me.lblSeccion.AutoSize = True
        Me.lblSeccion.Location = New System.Drawing.Point(66, 115)
        Me.lblSeccion.Name = "lblSeccion"
        Me.lblSeccion.Size = New System.Drawing.Size(49, 15)
        Me.lblSeccion.TabIndex = 6
        Me.lblSeccion.Text = "&Sección"
        '
        'lblNivel
        '
        Me.lblNivel.AutoSize = True
        Me.lblNivel.Location = New System.Drawing.Point(81, 57)
        Me.lblNivel.Name = "lblNivel"
        Me.lblNivel.Size = New System.Drawing.Size(35, 15)
        Me.lblNivel.TabIndex = 2
        Me.lblNivel.Text = "&Nivel"
        '
        'lblGrado
        '
        Me.lblGrado.AutoSize = True
        Me.lblGrado.Location = New System.Drawing.Point(76, 86)
        Me.lblGrado.Name = "lblGrado"
        Me.lblGrado.Size = New System.Drawing.Size(39, 15)
        Me.lblGrado.TabIndex = 4
        Me.lblGrado.Text = "&Grado"
        '
        'pbAvance
        '
        Me.pbAvance.BackColor = System.Drawing.Color.White
        Me.pbAvance.Location = New System.Drawing.Point(59, 198)
        Me.pbAvance.Name = "pbAvance"
        Me.pbAvance.Size = New System.Drawing.Size(334, 20)
        Me.pbAvance.TabIndex = 1
        '
        'btnExportar
        '
        Me.btnExportar.BackColor = System.Drawing.Color.White
        Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(270, 276)
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
        Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(386, 276)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(110, 50)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'frmReporte01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 343)
        Me.Controls.Add(Me.gbExportar)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmReporte01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Codigos del Estudiante"
        Me.gbExportar.ResumeLayout(False)
        Me.gbNomina.ResumeLayout(False)
        Me.gbNomina.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
  Friend WithEvents gbExportar As System.Windows.Forms.GroupBox
  Friend WithEvents gbNomina As System.Windows.Forms.GroupBox
  Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents cboGrado As System.Windows.Forms.ComboBox
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents lblNivel As System.Windows.Forms.Label
  Friend WithEvents lblGrado As System.Windows.Forms.Label
  Friend WithEvents pbAvance As System.Windows.Forms.ProgressBar
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
End Class
