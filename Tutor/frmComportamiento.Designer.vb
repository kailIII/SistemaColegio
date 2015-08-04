<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComportamiento
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.gbPeriodo = New System.Windows.Forms.GroupBox
    Me.lblAnio = New System.Windows.Forms.Label
    Me.txtPeriodo = New System.Windows.Forms.TextBox
    Me.dgAlumnos = New System.Windows.Forms.DataGridView
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.gbSeccion = New System.Windows.Forms.GroupBox
    Me.cboSeccion = New System.Windows.Forms.ComboBox
    Me.lblSeccion = New System.Windows.Forms.Label
    Me.btnListar = New System.Windows.Forms.Button
    Me.cdNro = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdAlumo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.gbPeriodo.SuspendLayout()
    CType(Me.dgAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbSeccion.SuspendLayout()
    Me.SuspendLayout()
    '
    'gbPeriodo
    '
    Me.gbPeriodo.Controls.Add(Me.lblAnio)
    Me.gbPeriodo.Controls.Add(Me.txtPeriodo)
    Me.gbPeriodo.Location = New System.Drawing.Point(5, 8)
    Me.gbPeriodo.Name = "gbPeriodo"
    Me.gbPeriodo.Size = New System.Drawing.Size(284, 57)
    Me.gbPeriodo.TabIndex = 6
    Me.gbPeriodo.TabStop = False
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Location = New System.Drawing.Point(18, 26)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(26, 13)
    Me.lblAnio.TabIndex = 1
    Me.lblAnio.Text = "Año"
    '
    'txtPeriodo
    '
    Me.txtPeriodo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPeriodo.Location = New System.Drawing.Point(50, 21)
    Me.txtPeriodo.Multiline = True
    Me.txtPeriodo.Name = "txtPeriodo"
    Me.txtPeriodo.ReadOnly = True
    Me.txtPeriodo.Size = New System.Drawing.Size(213, 24)
    Me.txtPeriodo.TabIndex = 0
    Me.txtPeriodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'dgAlumnos
    '
    Me.dgAlumnos.AllowUserToAddRows = False
    Me.dgAlumnos.AllowUserToDeleteRows = False
    Me.dgAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgAlumnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNro, Me.cdAlumo})
    Me.dgAlumnos.Location = New System.Drawing.Point(5, 75)
    Me.dgAlumnos.MultiSelect = False
    Me.dgAlumnos.Name = "dgAlumnos"
    Me.dgAlumnos.Size = New System.Drawing.Size(982, 546)
    Me.dgAlumnos.TabIndex = 2
    '
    'btnRegistrar
    '
    Me.btnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(5, 628)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 50)
    Me.btnRegistrar.TabIndex = 3
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(121, 628)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 50)
    Me.btnCancelar.TabIndex = 4
    Me.btnCancelar.Text = "&Deshacer"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(877, 628)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 50)
    Me.btnCerrar.TabIndex = 5
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'gbSeccion
    '
    Me.gbSeccion.Controls.Add(Me.cboSeccion)
    Me.gbSeccion.Controls.Add(Me.lblSeccion)
    Me.gbSeccion.Location = New System.Drawing.Point(295, 8)
    Me.gbSeccion.Name = "gbSeccion"
    Me.gbSeccion.Size = New System.Drawing.Size(354, 57)
    Me.gbSeccion.TabIndex = 0
    Me.gbSeccion.TabStop = False
    Me.gbSeccion.Text = "Nivel - Grado - Sección"
    '
    'cboSeccion
    '
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(69, 21)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(250, 24)
    Me.cboSeccion.TabIndex = 1
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Location = New System.Drawing.Point(17, 26)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(46, 13)
    Me.lblSeccion.TabIndex = 0
    Me.lblSeccion.Text = "Sección"
    '
    'btnListar
    '
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnListar.Location = New System.Drawing.Point(763, 30)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(125, 39)
    Me.btnListar.TabIndex = 1
    Me.btnListar.Text = "&Listar"
    Me.btnListar.UseVisualStyleBackColor = False
    Me.btnListar.Visible = False
    '
    'cdNro
    '
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.cdNro.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdNro.HeaderText = "Nro Orden"
    Me.cdNro.Name = "cdNro"
    Me.cdNro.ReadOnly = True
    Me.cdNro.Width = 50
    '
    'cdAlumo
    '
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    Me.cdAlumo.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdAlumo.HeaderText = "Alumno"
    Me.cdAlumo.Name = "cdAlumo"
    Me.cdAlumo.ReadOnly = True
    Me.cdAlumo.Width = 250
    '
    'frmComportamiento
    '
    Me.AcceptButton = Me.btnRegistrar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(995, 682)
    Me.Controls.Add(Me.btnListar)
    Me.Controls.Add(Me.gbSeccion)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.dgAlumnos)
    Me.Controls.Add(Me.gbPeriodo)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Name = "frmComportamiento"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestió Notas de Comportamiento por Virtud"
    Me.gbPeriodo.ResumeLayout(False)
    Me.gbPeriodo.PerformLayout()
    CType(Me.dgAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbSeccion.ResumeLayout(False)
    Me.gbSeccion.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents gbPeriodo As System.Windows.Forms.GroupBox
  Friend WithEvents txtPeriodo As System.Windows.Forms.TextBox
  Friend WithEvents dgAlumnos As System.Windows.Forms.DataGridView
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents gbSeccion As System.Windows.Forms.GroupBox
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents cdNro As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAlumo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
