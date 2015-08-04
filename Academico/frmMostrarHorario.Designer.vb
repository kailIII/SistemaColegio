<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMostrarHorario
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
    Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.btnSalir = New System.Windows.Forms.Button
    Me.cboNivel = New System.Windows.Forms.ComboBox
    Me.lblNivel = New System.Windows.Forms.Label
    Me.cboSeccion = New System.Windows.Forms.ComboBox
    Me.lblSeccion = New System.Windows.Forms.Label
    Me.btnListar = New System.Windows.Forms.Button
    Me.dgvHorario = New System.Windows.Forms.DataGridView
    Me.cdHora = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdLunes = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdMartes = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdMiercoles = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdJueves = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdViernes = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.dgvHorario, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnSalir
    '
    Me.btnSalir.BackColor = System.Drawing.Color.White
    Me.btnSalir.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnSalir.Location = New System.Drawing.Point(793, 439)
    Me.btnSalir.Name = "btnSalir"
    Me.btnSalir.Size = New System.Drawing.Size(110, 54)
    Me.btnSalir.TabIndex = 17
    Me.btnSalir.Text = "&Cerrar"
    Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnSalir.UseVisualStyleBackColor = False
    '
    'cboNivel
    '
    Me.cboNivel.BackColor = System.Drawing.Color.White
    Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNivel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Location = New System.Drawing.Point(101, 12)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(253, 23)
    Me.cboNivel.TabIndex = 14
    '
    'lblNivel
    '
    Me.lblNivel.AutoSize = True
    Me.lblNivel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNivel.Location = New System.Drawing.Point(59, 20)
    Me.lblNivel.Name = "lblNivel"
    Me.lblNivel.Size = New System.Drawing.Size(35, 15)
    Me.lblNivel.TabIndex = 13
    Me.lblNivel.Text = "&Nivel"
    '
    'cboSeccion
    '
    Me.cboSeccion.BackColor = System.Drawing.Color.White
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(101, 41)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(253, 23)
    Me.cboSeccion.TabIndex = 16
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSeccion.Location = New System.Drawing.Point(6, 50)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(93, 15)
    Me.lblSeccion.TabIndex = 15
    Me.lblSeccion.Text = "&Grado y sección"
    '
    'btnListar
    '
    Me.btnListar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnListar.Location = New System.Drawing.Point(394, 41)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(75, 25)
    Me.btnListar.TabIndex = 12
    Me.btnListar.Text = "Listar"
    Me.btnListar.UseVisualStyleBackColor = True
    '
    'dgvHorario
    '
    Me.dgvHorario.AllowUserToAddRows = False
    Me.dgvHorario.AllowUserToDeleteRows = False
    DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle17.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvHorario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
    Me.dgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvHorario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdHora, Me.cdLunes, Me.cdMartes, Me.cdMiercoles, Me.cdJueves, Me.cdViernes})
    Me.dgvHorario.Cursor = System.Windows.Forms.Cursors.Default
    DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle24.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgvHorario.DefaultCellStyle = DataGridViewCellStyle24
    Me.dgvHorario.GridColor = System.Drawing.Color.Navy
    Me.dgvHorario.Location = New System.Drawing.Point(6, 90)
    Me.dgvHorario.MultiSelect = False
    Me.dgvHorario.Name = "dgvHorario"
    Me.dgvHorario.ReadOnly = True
    Me.dgvHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvHorario.Size = New System.Drawing.Size(902, 328)
    Me.dgvHorario.TabIndex = 11
    '
    'cdHora
    '
    DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle18.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle18.Format = "t"
    DataGridViewCellStyle18.NullValue = Nothing
    Me.cdHora.DefaultCellStyle = DataGridViewCellStyle18
    Me.cdHora.HeaderText = "Hora"
    Me.cdHora.Name = "cdHora"
    Me.cdHora.ReadOnly = True
    '
    'cdLunes
    '
    DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cdLunes.DefaultCellStyle = DataGridViewCellStyle19
    Me.cdLunes.HeaderText = "Lunes"
    Me.cdLunes.Name = "cdLunes"
    Me.cdLunes.ReadOnly = True
    Me.cdLunes.Width = 150
    '
    'cdMartes
    '
    DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black
    DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.DodgerBlue
    DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.cdMartes.DefaultCellStyle = DataGridViewCellStyle20
    Me.cdMartes.HeaderText = "Martes"
    Me.cdMartes.Name = "cdMartes"
    Me.cdMartes.ReadOnly = True
    Me.cdMartes.Width = 150
    '
    'cdMiercoles
    '
    DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cdMiercoles.DefaultCellStyle = DataGridViewCellStyle21
    Me.cdMiercoles.HeaderText = "Miercoles"
    Me.cdMiercoles.Name = "cdMiercoles"
    Me.cdMiercoles.ReadOnly = True
    Me.cdMiercoles.Width = 150
    '
    'cdJueves
    '
    DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cdJueves.DefaultCellStyle = DataGridViewCellStyle22
    Me.cdJueves.HeaderText = "Jueves"
    Me.cdJueves.Name = "cdJueves"
    Me.cdJueves.ReadOnly = True
    Me.cdJueves.Width = 150
    '
    'cdViernes
    '
    DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cdViernes.DefaultCellStyle = DataGridViewCellStyle23
    Me.cdViernes.HeaderText = "Viernes"
    Me.cdViernes.Name = "cdViernes"
    Me.cdViernes.ReadOnly = True
    Me.cdViernes.Width = 150
    '
    'frmMostrarHorario
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(915, 506)
    Me.Controls.Add(Me.btnSalir)
    Me.Controls.Add(Me.cboNivel)
    Me.Controls.Add(Me.lblNivel)
    Me.Controls.Add(Me.cboSeccion)
    Me.Controls.Add(Me.lblSeccion)
    Me.Controls.Add(Me.btnListar)
    Me.Controls.Add(Me.dgvHorario)
    Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Name = "frmMostrarHorario"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Mostrar Horario"
    CType(Me.dgvHorario, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnSalir As System.Windows.Forms.Button
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents lblNivel As System.Windows.Forms.Label
  Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents dgvHorario As System.Windows.Forms.DataGridView
  Friend WithEvents cdHora As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdLunes As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdMartes As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdMiercoles As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdJueves As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdViernes As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
