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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.gbPeriodo = New System.Windows.Forms.GroupBox()
    Me.txtPeriodo = New System.Windows.Forms.TextBox()
    Me.dgvAlumnos = New System.Windows.Forms.DataGridView()
    Me.cdNro = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdAlumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btnRegistrar = New System.Windows.Forms.Button()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.gbTutor = New System.Windows.Forms.GroupBox()
    Me.cboTutor = New System.Windows.Forms.ComboBox()
    Me.lblNombre = New System.Windows.Forms.Label()
    Me.btnListar = New System.Windows.Forms.Button()
    Me.btnExportar = New System.Windows.Forms.Button()
    Me.btnImportar = New System.Windows.Forms.Button()
    Me.gbPeriodo.SuspendLayout()
    CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbTutor.SuspendLayout()
    Me.SuspendLayout()
    '
    'gbPeriodo
    '
    Me.gbPeriodo.Controls.Add(Me.txtPeriodo)
    Me.gbPeriodo.Location = New System.Drawing.Point(5, 4)
    Me.gbPeriodo.Name = "gbPeriodo"
    Me.gbPeriodo.Size = New System.Drawing.Size(204, 57)
    Me.gbPeriodo.TabIndex = 0
    Me.gbPeriodo.TabStop = False
    Me.gbPeriodo.Text = "Periodo"
    '
    'txtPeriodo
    '
    Me.txtPeriodo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPeriodo.Location = New System.Drawing.Point(19, 21)
    Me.txtPeriodo.Multiline = True
    Me.txtPeriodo.Name = "txtPeriodo"
    Me.txtPeriodo.ReadOnly = True
    Me.txtPeriodo.Size = New System.Drawing.Size(167, 24)
    Me.txtPeriodo.TabIndex = 0
    Me.txtPeriodo.TabStop = False
    Me.txtPeriodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'dgvAlumnos
    '
    Me.dgvAlumnos.AllowUserToAddRows = False
    Me.dgvAlumnos.AllowUserToDeleteRows = False
    Me.dgvAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvAlumnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNro, Me.cdAlumo})
    Me.dgvAlumnos.Location = New System.Drawing.Point(5, 67)
    Me.dgvAlumnos.MultiSelect = False
    Me.dgvAlumnos.Name = "dgvAlumnos"
    Me.dgvAlumnos.Size = New System.Drawing.Size(872, 420)
    Me.dgvAlumnos.TabIndex = 3
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
    'btnRegistrar
    '
    Me.btnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(5, 490)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 46)
    Me.btnRegistrar.TabIndex = 4
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
    Me.btnCancelar.Location = New System.Drawing.Point(121, 490)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 46)
    Me.btnCancelar.TabIndex = 5
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
    Me.btnCerrar.Location = New System.Drawing.Point(771, 490)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 46)
    Me.btnCerrar.TabIndex = 7
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'gbTutor
    '
    Me.gbTutor.Controls.Add(Me.cboTutor)
    Me.gbTutor.Controls.Add(Me.lblNombre)
    Me.gbTutor.Location = New System.Drawing.Point(215, 4)
    Me.gbTutor.Name = "gbTutor"
    Me.gbTutor.Size = New System.Drawing.Size(418, 57)
    Me.gbTutor.TabIndex = 1
    Me.gbTutor.TabStop = False
    Me.gbTutor.Text = "Tutor"
    '
    'cboTutor
    '
    Me.cboTutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTutor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboTutor.FormattingEnabled = True
    Me.cboTutor.Location = New System.Drawing.Point(55, 21)
    Me.cboTutor.Name = "cboTutor"
    Me.cboTutor.Size = New System.Drawing.Size(347, 24)
    Me.cboTutor.TabIndex = 2
    '
    'lblNombre
    '
    Me.lblNombre.AutoSize = True
    Me.lblNombre.Location = New System.Drawing.Point(9, 32)
    Me.lblNombre.Name = "lblNombre"
    Me.lblNombre.Size = New System.Drawing.Size(44, 13)
    Me.lblNombre.TabIndex = 1
    Me.lblNombre.Text = "&Nombre"
    '
    'btnListar
    '
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnListar.Location = New System.Drawing.Point(649, 13)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(110, 46)
    Me.btnListar.TabIndex = 2
    Me.btnListar.Text = "&Listar"
    Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnListar.UseVisualStyleBackColor = False
    '
    'btnExportar
    '
    Me.btnExportar.BackColor = System.Drawing.Color.White
    Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnExportar.Location = New System.Drawing.Point(237, 490)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(110, 46)
    Me.btnExportar.TabIndex = 6
    Me.btnExportar.Text = "E&xportar"
    Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnExportar.UseVisualStyleBackColor = False
    '
    'btnImportar
    '
    Me.btnImportar.BackColor = System.Drawing.Color.White
    Me.btnImportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnImportar.Location = New System.Drawing.Point(353, 490)
    Me.btnImportar.Name = "btnImportar"
    Me.btnImportar.Size = New System.Drawing.Size(110, 46)
    Me.btnImportar.TabIndex = 8
    Me.btnImportar.Text = "I&mportar"
    Me.btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnImportar.UseVisualStyleBackColor = False
    '
    'frmComportamiento
    '
    Me.AcceptButton = Me.btnRegistrar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(889, 539)
    Me.Controls.Add(Me.btnImportar)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.btnListar)
    Me.Controls.Add(Me.gbTutor)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.dgvAlumnos)
    Me.Controls.Add(Me.gbPeriodo)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Name = "frmComportamiento"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión Notas de Comportamiento"
    Me.gbPeriodo.ResumeLayout(False)
    Me.gbPeriodo.PerformLayout()
    CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbTutor.ResumeLayout(False)
    Me.gbTutor.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents gbPeriodo As System.Windows.Forms.GroupBox
  Friend WithEvents txtPeriodo As System.Windows.Forms.TextBox
  Friend WithEvents dgvAlumnos As System.Windows.Forms.DataGridView
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents cdNro As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAlumo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents gbTutor As System.Windows.Forms.GroupBox
  Friend WithEvents cboTutor As System.Windows.Forms.ComboBox
  Friend WithEvents lblNombre As System.Windows.Forms.Label
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents btnImportar As System.Windows.Forms.Button
End Class
