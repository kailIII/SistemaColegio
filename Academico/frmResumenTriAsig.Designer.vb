<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumenTriAsig
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
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.cboCursoSeccion = New System.Windows.Forms.ComboBox()
    Me.cboSeccion = New System.Windows.Forms.ComboBox()
    Me.cboGrado = New System.Windows.Forms.ComboBox()
    Me.lblCursoSeccion = New System.Windows.Forms.Label()
    Me.lblSeccion = New System.Windows.Forms.Label()
    Me.lblGrado = New System.Windows.Forms.Label()
    Me.btnExportar = New System.Windows.Forms.Button()
    Me.cboPeriodo = New System.Windows.Forms.ComboBox()
    Me.gbPeriodo = New System.Windows.Forms.GroupBox()
    Me.lblAnio = New System.Windows.Forms.Label()
    Me.cboAnio = New System.Windows.Forms.ComboBox()
    Me.lblPeriodo = New System.Windows.Forms.Label()
    Me.pbAvance = New System.Windows.Forms.ProgressBar()
    Me.tabListado = New System.Windows.Forms.TabControl()
    Me.tbpDocente = New System.Windows.Forms.TabPage()
    Me.cboCursoDocente = New System.Windows.Forms.ComboBox()
    Me.lblCursoDocente = New System.Windows.Forms.Label()
    Me.cboDocente = New System.Windows.Forms.ComboBox()
    Me.lblDocente = New System.Windows.Forms.Label()
    Me.tbpSeccion = New System.Windows.Forms.TabPage()
    Me.gbPeriodo.SuspendLayout()
    Me.tabListado.SuspendLayout()
    Me.tbpDocente.SuspendLayout()
    Me.tbpSeccion.SuspendLayout()
    Me.SuspendLayout()
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(396, 324)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 50)
    Me.btnCerrar.TabIndex = 4
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'cboCursoSeccion
    '
    Me.cboCursoSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCursoSeccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboCursoSeccion.FormattingEnabled = True
    Me.cboCursoSeccion.Location = New System.Drawing.Point(60, 93)
    Me.cboCursoSeccion.Name = "cboCursoSeccion"
    Me.cboCursoSeccion.Size = New System.Drawing.Size(374, 24)
    Me.cboCursoSeccion.TabIndex = 5
    '
    'cboSeccion
    '
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(60, 55)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(158, 24)
    Me.cboSeccion.TabIndex = 3
    '
    'cboGrado
    '
    Me.cboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboGrado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboGrado.FormattingEnabled = True
    Me.cboGrado.Location = New System.Drawing.Point(60, 18)
    Me.cboGrado.Name = "cboGrado"
    Me.cboGrado.Size = New System.Drawing.Size(158, 24)
    Me.cboGrado.TabIndex = 1
    '
    'lblCursoSeccion
    '
    Me.lblCursoSeccion.AutoSize = True
    Me.lblCursoSeccion.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCursoSeccion.Location = New System.Drawing.Point(10, 102)
    Me.lblCursoSeccion.Name = "lblCursoSeccion"
    Me.lblCursoSeccion.Size = New System.Drawing.Size(39, 15)
    Me.lblCursoSeccion.TabIndex = 4
    Me.lblCursoSeccion.Text = "C&urso"
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSeccion.Location = New System.Drawing.Point(10, 64)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(49, 15)
    Me.lblSeccion.TabIndex = 2
    Me.lblSeccion.Text = "&Sección"
    '
    'lblGrado
    '
    Me.lblGrado.AutoSize = True
    Me.lblGrado.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblGrado.Location = New System.Drawing.Point(10, 27)
    Me.lblGrado.Name = "lblGrado"
    Me.lblGrado.Size = New System.Drawing.Size(39, 15)
    Me.lblGrado.TabIndex = 0
    Me.lblGrado.Text = "&Grado"
    '
    'btnExportar
    '
    Me.btnExportar.BackColor = System.Drawing.Color.White
    Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.Location = New System.Drawing.Point(280, 324)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(110, 50)
    Me.btnExportar.TabIndex = 3
    Me.btnExportar.Text = "&Exportar"
    Me.btnExportar.UseVisualStyleBackColor = False
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
    'gbPeriodo
    '
    Me.gbPeriodo.Controls.Add(Me.cboPeriodo)
    Me.gbPeriodo.Controls.Add(Me.lblAnio)
    Me.gbPeriodo.Controls.Add(Me.cboAnio)
    Me.gbPeriodo.Controls.Add(Me.lblPeriodo)
    Me.gbPeriodo.Location = New System.Drawing.Point(34, 15)
    Me.gbPeriodo.Name = "gbPeriodo"
    Me.gbPeriodo.Size = New System.Drawing.Size(471, 66)
    Me.gbPeriodo.TabIndex = 0
    Me.gbPeriodo.TabStop = False
    Me.gbPeriodo.Text = "Periodo Académico"
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAnio.Location = New System.Drawing.Point(32, 36)
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
    Me.cboAnio.Location = New System.Drawing.Point(69, 27)
    Me.cboAnio.Name = "cboAnio"
    Me.cboAnio.Size = New System.Drawing.Size(158, 24)
    Me.cboAnio.TabIndex = 1
    '
    'lblPeriodo
    '
    Me.lblPeriodo.AutoSize = True
    Me.lblPeriodo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPeriodo.Location = New System.Drawing.Point(280, 35)
    Me.lblPeriodo.Name = "lblPeriodo"
    Me.lblPeriodo.Size = New System.Drawing.Size(57, 15)
    Me.lblPeriodo.TabIndex = 2
    Me.lblPeriodo.Text = "&Trimestre"
    '
    'pbAvance
    '
    Me.pbAvance.Location = New System.Drawing.Point(34, 277)
    Me.pbAvance.Name = "pbAvance"
    Me.pbAvance.Size = New System.Drawing.Size(471, 23)
    Me.pbAvance.TabIndex = 2
    '
    'tabListado
    '
    Me.tabListado.Controls.Add(Me.tbpDocente)
    Me.tabListado.Controls.Add(Me.tbpSeccion)
    Me.tabListado.Location = New System.Drawing.Point(35, 98)
    Me.tabListado.Name = "tabListado"
    Me.tabListado.SelectedIndex = 0
    Me.tabListado.Size = New System.Drawing.Size(471, 173)
    Me.tabListado.TabIndex = 1
    '
    'tbpDocente
    '
    Me.tbpDocente.Controls.Add(Me.cboCursoDocente)
    Me.tbpDocente.Controls.Add(Me.lblCursoDocente)
    Me.tbpDocente.Controls.Add(Me.cboDocente)
    Me.tbpDocente.Controls.Add(Me.lblDocente)
    Me.tbpDocente.Location = New System.Drawing.Point(4, 22)
    Me.tbpDocente.Name = "tbpDocente"
    Me.tbpDocente.Padding = New System.Windows.Forms.Padding(3)
    Me.tbpDocente.Size = New System.Drawing.Size(463, 147)
    Me.tbpDocente.TabIndex = 0
    Me.tbpDocente.Text = "Docente"
    Me.tbpDocente.UseVisualStyleBackColor = True
    '
    'cboCursoDocente
    '
    Me.cboCursoDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCursoDocente.FormattingEnabled = True
    Me.cboCursoDocente.Location = New System.Drawing.Point(74, 75)
    Me.cboCursoDocente.Name = "cboCursoDocente"
    Me.cboCursoDocente.Size = New System.Drawing.Size(337, 21)
    Me.cboCursoDocente.TabIndex = 3
    '
    'lblCursoDocente
    '
    Me.lblCursoDocente.AutoSize = True
    Me.lblCursoDocente.Location = New System.Drawing.Point(16, 83)
    Me.lblCursoDocente.Name = "lblCursoDocente"
    Me.lblCursoDocente.Size = New System.Drawing.Size(34, 13)
    Me.lblCursoDocente.TabIndex = 2
    Me.lblCursoDocente.Text = "C&urso"
    '
    'cboDocente
    '
    Me.cboDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboDocente.FormattingEnabled = True
    Me.cboDocente.Location = New System.Drawing.Point(74, 31)
    Me.cboDocente.Name = "cboDocente"
    Me.cboDocente.Size = New System.Drawing.Size(337, 21)
    Me.cboDocente.TabIndex = 1
    '
    'lblDocente
    '
    Me.lblDocente.AutoSize = True
    Me.lblDocente.Location = New System.Drawing.Point(16, 39)
    Me.lblDocente.Name = "lblDocente"
    Me.lblDocente.Size = New System.Drawing.Size(48, 13)
    Me.lblDocente.TabIndex = 0
    Me.lblDocente.Text = "&Docente"
    '
    'tbpSeccion
    '
    Me.tbpSeccion.Controls.Add(Me.cboCursoSeccion)
    Me.tbpSeccion.Controls.Add(Me.cboGrado)
    Me.tbpSeccion.Controls.Add(Me.cboSeccion)
    Me.tbpSeccion.Controls.Add(Me.lblGrado)
    Me.tbpSeccion.Controls.Add(Me.lblSeccion)
    Me.tbpSeccion.Controls.Add(Me.lblCursoSeccion)
    Me.tbpSeccion.Location = New System.Drawing.Point(4, 22)
    Me.tbpSeccion.Name = "tbpSeccion"
    Me.tbpSeccion.Padding = New System.Windows.Forms.Padding(3)
    Me.tbpSeccion.Size = New System.Drawing.Size(463, 147)
    Me.tbpSeccion.TabIndex = 1
    Me.tbpSeccion.Text = "Sección"
    Me.tbpSeccion.UseVisualStyleBackColor = True
    '
    'frmResumenTriAsig
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(541, 390)
    Me.Controls.Add(Me.tabListado)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.gbPeriodo)
    Me.Controls.Add(Me.pbAvance)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.Name = "frmResumenTriAsig"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Resumen de notas de capacidades por unidades - Secundaria"
    Me.gbPeriodo.ResumeLayout(False)
    Me.gbPeriodo.PerformLayout()
    Me.tabListado.ResumeLayout(False)
    Me.tbpDocente.ResumeLayout(False)
    Me.tbpDocente.PerformLayout()
    Me.tbpSeccion.ResumeLayout(False)
    Me.tbpSeccion.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents cboCursoSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents cboGrado As System.Windows.Forms.ComboBox
  Friend WithEvents lblCursoSeccion As System.Windows.Forms.Label
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents lblGrado As System.Windows.Forms.Label
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
  Friend WithEvents gbPeriodo As System.Windows.Forms.GroupBox
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
  Friend WithEvents lblPeriodo As System.Windows.Forms.Label
  Friend WithEvents pbAvance As System.Windows.Forms.ProgressBar
  Friend WithEvents tabListado As System.Windows.Forms.TabControl
  Friend WithEvents tbpDocente As System.Windows.Forms.TabPage
  Friend WithEvents cboDocente As System.Windows.Forms.ComboBox
  Friend WithEvents lblDocente As System.Windows.Forms.Label
  Friend WithEvents tbpSeccion As System.Windows.Forms.TabPage
  Friend WithEvents cboCursoDocente As System.Windows.Forms.ComboBox
  Friend WithEvents lblCursoDocente As System.Windows.Forms.Label
End Class
