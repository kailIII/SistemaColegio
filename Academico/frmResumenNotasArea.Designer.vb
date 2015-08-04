<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumenNotasArea
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
    Me.cboSeccion = New System.Windows.Forms.ComboBox
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.cboPeriodo = New System.Windows.Forms.ComboBox
    Me.cboGrado = New System.Windows.Forms.ComboBox
    Me.gbGrupo = New System.Windows.Forms.GroupBox
    Me.cboCurso = New System.Windows.Forms.ComboBox
    Me.lblCurso = New System.Windows.Forms.Label
    Me.lblSeccion = New System.Windows.Forms.Label
    Me.lblGrado = New System.Windows.Forms.Label
    Me.btnExportar = New System.Windows.Forms.Button
    Me.lblAnio = New System.Windows.Forms.Label
    Me.cboAnio = New System.Windows.Forms.ComboBox
    Me.lblPeriodo = New System.Windows.Forms.Label
    Me.pbAvance = New System.Windows.Forms.ProgressBar
    Me.gbPeriodo = New System.Windows.Forms.GroupBox
    Me.gbGrupo.SuspendLayout()
    Me.gbPeriodo.SuspendLayout()
    Me.SuspendLayout()
    '
    'cboSeccion
    '
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(73, 58)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(158, 24)
    Me.cboSeccion.TabIndex = 3
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(396, 278)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 50)
    Me.btnCerrar.TabIndex = 4
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'cboPeriodo
    '
    Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboPeriodo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboPeriodo.FormattingEnabled = True
    Me.cboPeriodo.Location = New System.Drawing.Point(343, 26)
    Me.cboPeriodo.Name = "cboPeriodo"
    Me.cboPeriodo.Size = New System.Drawing.Size(72, 24)
    Me.cboPeriodo.TabIndex = 3
    '
    'cboGrado
    '
    Me.cboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboGrado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboGrado.FormattingEnabled = True
    Me.cboGrado.Location = New System.Drawing.Point(73, 21)
    Me.cboGrado.Name = "cboGrado"
    Me.cboGrado.Size = New System.Drawing.Size(158, 24)
    Me.cboGrado.TabIndex = 1
    '
    'gbGrupo
    '
    Me.gbGrupo.Controls.Add(Me.cboCurso)
    Me.gbGrupo.Controls.Add(Me.cboSeccion)
    Me.gbGrupo.Controls.Add(Me.cboGrado)
    Me.gbGrupo.Controls.Add(Me.lblCurso)
    Me.gbGrupo.Controls.Add(Me.lblSeccion)
    Me.gbGrupo.Controls.Add(Me.lblGrado)
    Me.gbGrupo.Location = New System.Drawing.Point(35, 88)
    Me.gbGrupo.Name = "gbGrupo"
    Me.gbGrupo.Size = New System.Drawing.Size(471, 137)
    Me.gbGrupo.TabIndex = 1
    Me.gbGrupo.TabStop = False
    '
    'cboCurso
    '
    Me.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCurso.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboCurso.FormattingEnabled = True
    Me.cboCurso.Location = New System.Drawing.Point(73, 96)
    Me.cboCurso.Name = "cboCurso"
    Me.cboCurso.Size = New System.Drawing.Size(374, 24)
    Me.cboCurso.TabIndex = 5
    '
    'lblCurso
    '
    Me.lblCurso.AutoSize = True
    Me.lblCurso.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCurso.Location = New System.Drawing.Point(35, 99)
    Me.lblCurso.Name = "lblCurso"
    Me.lblCurso.Size = New System.Drawing.Size(33, 15)
    Me.lblCurso.TabIndex = 4
    Me.lblCurso.Text = "Á&rea"
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSeccion.Location = New System.Drawing.Point(23, 61)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(49, 15)
    Me.lblSeccion.TabIndex = 2
    Me.lblSeccion.Text = "&Sección"
    '
    'lblGrado
    '
    Me.lblGrado.AutoSize = True
    Me.lblGrado.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblGrado.Location = New System.Drawing.Point(33, 24)
    Me.lblGrado.Name = "lblGrado"
    Me.lblGrado.Size = New System.Drawing.Size(39, 15)
    Me.lblGrado.TabIndex = 0
    Me.lblGrado.Text = "&Grado"
    '
    'btnExportar
    '
    Me.btnExportar.BackColor = System.Drawing.Color.White
    Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.Location = New System.Drawing.Point(280, 278)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(110, 50)
    Me.btnExportar.TabIndex = 3
    Me.btnExportar.Text = "&Exportar"
    Me.btnExportar.UseVisualStyleBackColor = False
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAnio.Location = New System.Drawing.Point(56, 30)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(31, 15)
    Me.lblAnio.TabIndex = 0
    Me.lblAnio.Text = "&Año"
    '
    'cboAnio
    '
    Me.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAnio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboAnio.FormattingEnabled = True
    Me.cboAnio.Location = New System.Drawing.Point(92, 27)
    Me.cboAnio.Name = "cboAnio"
    Me.cboAnio.Size = New System.Drawing.Size(158, 24)
    Me.cboAnio.TabIndex = 1
    '
    'lblPeriodo
    '
    Me.lblPeriodo.AutoSize = True
    Me.lblPeriodo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPeriodo.Location = New System.Drawing.Point(280, 31)
    Me.lblPeriodo.Name = "lblPeriodo"
    Me.lblPeriodo.Size = New System.Drawing.Size(57, 15)
    Me.lblPeriodo.TabIndex = 2
    Me.lblPeriodo.Text = "&Trimestre"
    '
    'pbAvance
    '
    Me.pbAvance.Location = New System.Drawing.Point(35, 236)
    Me.pbAvance.Name = "pbAvance"
    Me.pbAvance.Size = New System.Drawing.Size(471, 23)
    Me.pbAvance.TabIndex = 2
    '
    'gbPeriodo
    '
    Me.gbPeriodo.Controls.Add(Me.cboPeriodo)
    Me.gbPeriodo.Controls.Add(Me.lblAnio)
    Me.gbPeriodo.Controls.Add(Me.cboAnio)
    Me.gbPeriodo.Controls.Add(Me.lblPeriodo)
    Me.gbPeriodo.Location = New System.Drawing.Point(35, 14)
    Me.gbPeriodo.Name = "gbPeriodo"
    Me.gbPeriodo.Size = New System.Drawing.Size(471, 66)
    Me.gbPeriodo.TabIndex = 0
    Me.gbPeriodo.TabStop = False
    Me.gbPeriodo.Text = "Periodo Académico"
    '
    'frmResumenNotasArea
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(541, 343)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.gbGrupo)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.pbAvance)
    Me.Controls.Add(Me.gbPeriodo)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.Name = "frmResumenNotasArea"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Resumen de notas por área - Secundaria"
    Me.gbGrupo.ResumeLayout(False)
    Me.gbGrupo.PerformLayout()
    Me.gbPeriodo.ResumeLayout(False)
    Me.gbPeriodo.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
  Friend WithEvents cboGrado As System.Windows.Forms.ComboBox
  Friend WithEvents gbGrupo As System.Windows.Forms.GroupBox
  Friend WithEvents cboCurso As System.Windows.Forms.ComboBox
  Friend WithEvents lblCurso As System.Windows.Forms.Label
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents lblGrado As System.Windows.Forms.Label
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
  Friend WithEvents lblPeriodo As System.Windows.Forms.Label
  Friend WithEvents pbAvance As System.Windows.Forms.ProgressBar
  Friend WithEvents gbPeriodo As System.Windows.Forms.GroupBox
End Class
