<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroNotasIndicadores
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
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.cboCurso = New System.Windows.Forms.ComboBox
    Me.lblCurso = New System.Windows.Forms.Label
    Me.txtPeriodo = New System.Windows.Forms.TextBox
    Me.lblPeriodo = New System.Windows.Forms.Label
    Me.dgvNotas = New System.Windows.Forms.DataGridView
    Me.cdNumero = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnListar = New System.Windows.Forms.Button
    Me.btncancelar = New System.Windows.Forms.Button
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.GBindicador = New System.Windows.Forms.GroupBox
    Me.txtNombre = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.txtTotal = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GBindicador.SuspendLayout()
    Me.SuspendLayout()
    '
    'cboCurso
    '
    Me.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCurso.FormattingEnabled = True
    Me.cboCurso.Location = New System.Drawing.Point(79, 49)
    Me.cboCurso.Name = "cboCurso"
    Me.cboCurso.Size = New System.Drawing.Size(256, 21)
    Me.cboCurso.TabIndex = 3
    '
    'lblCurso
    '
    Me.lblCurso.AutoSize = True
    Me.lblCurso.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCurso.Location = New System.Drawing.Point(21, 51)
    Me.lblCurso.Name = "lblCurso"
    Me.lblCurso.Size = New System.Drawing.Size(39, 15)
    Me.lblCurso.TabIndex = 2
    Me.lblCurso.Text = "&Curso"
    '
    'txtPeriodo
    '
    Me.txtPeriodo.Location = New System.Drawing.Point(79, 12)
    Me.txtPeriodo.Name = "txtPeriodo"
    Me.txtPeriodo.ReadOnly = True
    Me.txtPeriodo.Size = New System.Drawing.Size(168, 20)
    Me.txtPeriodo.TabIndex = 1
    Me.txtPeriodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'lblPeriodo
    '
    Me.lblPeriodo.AutoSize = True
    Me.lblPeriodo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPeriodo.Location = New System.Drawing.Point(21, 16)
    Me.lblPeriodo.Name = "lblPeriodo"
    Me.lblPeriodo.Size = New System.Drawing.Size(48, 15)
    Me.lblPeriodo.TabIndex = 0
    Me.lblPeriodo.Text = "&Periodo"
    '
    'dgvNotas
    '
    Me.dgvNotas.AllowUserToAddRows = False
    Me.dgvNotas.AllowUserToDeleteRows = False
    DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.dgvNotas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
    Me.dgvNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvNotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNumero, Me.cdAlumno})
    Me.dgvNotas.Location = New System.Drawing.Point(24, 178)
    Me.dgvNotas.MultiSelect = False
    Me.dgvNotas.Name = "dgvNotas"
    DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvNotas.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
    Me.dgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.dgvNotas.Size = New System.Drawing.Size(816, 321)
    Me.dgvNotas.TabIndex = 5
    '
    'cdNumero
    '
    DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle8.NullValue = Nothing
    Me.cdNumero.DefaultCellStyle = DataGridViewCellStyle8
    Me.cdNumero.HeaderText = "Nº"
    Me.cdNumero.Name = "cdNumero"
    Me.cdNumero.ReadOnly = True
    Me.cdNumero.Width = 30
    '
    'cdAlumno
    '
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.ReadOnly = True
    Me.cdAlumno.Width = 280
    '
    'btnListar
    '
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.btnListar.Location = New System.Drawing.Point(352, 39)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(81, 37)
    Me.btnListar.TabIndex = 4
    Me.btnListar.Text = "&Listar"
    Me.btnListar.UseVisualStyleBackColor = False
    '
    'btncancelar
    '
    Me.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
    Me.btncancelar.BackColor = System.Drawing.Color.White
    Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btncancelar.Location = New System.Drawing.Point(595, 503)
    Me.btncancelar.Name = "btncancelar"
    Me.btncancelar.Size = New System.Drawing.Size(110, 52)
    Me.btncancelar.TabIndex = 7
    Me.btncancelar.Text = "Ca&ncelar"
    Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btncancelar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(128, 503)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
    Me.btnRegistrar.TabIndex = 6
    Me.btnRegistrar.Text = "&Guardar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(740, 505)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(100, 50)
    Me.btnCerrar.TabIndex = 8
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'GBindicador
    '
    Me.GBindicador.Controls.Add(Me.txtNombre)
    Me.GBindicador.Controls.Add(Me.Label2)
    Me.GBindicador.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.GBindicador.Location = New System.Drawing.Point(24, 78)
    Me.GBindicador.Name = "GBindicador"
    Me.GBindicador.Size = New System.Drawing.Size(816, 94)
    Me.GBindicador.TabIndex = 9
    Me.GBindicador.TabStop = False
    Me.GBindicador.Text = "Indicador"
    '
    'txtNombre
    '
    Me.txtNombre.BackColor = System.Drawing.Color.White
    Me.txtNombre.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNombre.ForeColor = System.Drawing.Color.Navy
    Me.txtNombre.Location = New System.Drawing.Point(65, 23)
    Me.txtNombre.Multiline = True
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.ReadOnly = True
    Me.txtNombre.Size = New System.Drawing.Size(745, 65)
    Me.txtNombre.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(10, 42)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(49, 15)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Nombre"
    '
    'txtTotal
    '
    Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.txtTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTotal.Location = New System.Drawing.Point(74, 510)
    Me.txtTotal.Multiline = True
    Me.txtTotal.Name = "txtTotal"
    Me.txtTotal.ReadOnly = True
    Me.txtTotal.Size = New System.Drawing.Size(34, 24)
    Me.txtTotal.TabIndex = 11
    '
    'Label1
    '
    Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(24, 514)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(45, 15)
    Me.Label1.TabIndex = 10
    Me.Label1.Text = "Total : "
    '
    'frmRegistroNotasIndicadores
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(852, 557)
    Me.Controls.Add(Me.txtTotal)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.GBindicador)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btncancelar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.btnListar)
    Me.Controls.Add(Me.dgvNotas)
    Me.Controls.Add(Me.cboCurso)
    Me.Controls.Add(Me.lblCurso)
    Me.Controls.Add(Me.txtPeriodo)
    Me.Controls.Add(Me.lblPeriodo)
    Me.Name = "frmRegistroNotasIndicadores"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de Notas (Indicadores)"
    CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GBindicador.ResumeLayout(False)
    Me.GBindicador.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cboCurso As System.Windows.Forms.ComboBox
  Friend WithEvents lblCurso As System.Windows.Forms.Label
  Friend WithEvents txtPeriodo As System.Windows.Forms.TextBox
  Friend WithEvents lblPeriodo As System.Windows.Forms.Label
  Friend WithEvents dgvNotas As System.Windows.Forms.DataGridView
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents btncancelar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents GBindicador As System.Windows.Forms.GroupBox
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents cdNumero As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents txtTotal As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
