<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotaInvestigacion
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.btnListar = New System.Windows.Forms.Button()
    Me.cboSeccion = New System.Windows.Forms.ComboBox()
    Me.lblPresentacion = New System.Windows.Forms.Label()
    Me.dgvNotas = New System.Windows.Forms.DataGridView()
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdNota = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdLibro = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdDocente = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.btnImportar = New System.Windows.Forms.Button()
    Me.btncancelar = New System.Windows.Forms.Button()
    Me.btnExportar = New System.Windows.Forms.Button()
    Me.btnRegistrar = New System.Windows.Forms.Button()
    Me.cboNivel = New System.Windows.Forms.ComboBox()
    Me.lblNivel = New System.Windows.Forms.Label()
    Me.txtTotal = New System.Windows.Forms.TextBox()
    Me.lblTotal = New System.Windows.Forms.Label()
    Me.gbLeyenda = New System.Windows.Forms.GroupBox()
    Me.lblLeyenda1 = New System.Windows.Forms.Label()
    Me.lblLeyenda2 = New System.Windows.Forms.Label()
    CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbLeyenda.SuspendLayout()
    Me.SuspendLayout()
    '
    'btnListar
    '
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.btnListar.Location = New System.Drawing.Point(486, 24)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(113, 46)
    Me.btnListar.TabIndex = 4
    Me.btnListar.Text = "&Listar"
    Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnListar.UseVisualStyleBackColor = False
    '
    'cboSeccion
    '
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(308, 36)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(152, 25)
    Me.cboSeccion.TabIndex = 3
    '
    'lblPresentacion
    '
    Me.lblPresentacion.AutoSize = True
    Me.lblPresentacion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblPresentacion.Location = New System.Drawing.Point(241, 39)
    Me.lblPresentacion.Name = "lblPresentacion"
    Me.lblPresentacion.Size = New System.Drawing.Size(55, 17)
    Me.lblPresentacion.TabIndex = 2
    Me.lblPresentacion.Text = "&Sección"
    '
    'dgvNotas
    '
    Me.dgvNotas.AllowUserToAddRows = False
    Me.dgvNotas.AllowUserToDeleteRows = False
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.dgvNotas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvNotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdAlumno, Me.cdNota, Me.cdLibro, Me.cdDocente})
    Me.dgvNotas.Location = New System.Drawing.Point(12, 115)
    Me.dgvNotas.MultiSelect = False
    Me.dgvNotas.Name = "dgvNotas"
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvNotas.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.dgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.dgvNotas.Size = New System.Drawing.Size(868, 224)
    Me.dgvNotas.TabIndex = 6
    '
    'cdAlumno
    '
    Me.cdAlumno.DataPropertyName = "AlumnoNivel"
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cdAlumno.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.ReadOnly = True
    Me.cdAlumno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    Me.cdAlumno.Width = 300
    '
    'cdNota
    '
    Me.cdNota.DataPropertyName = "Nota"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
    Me.cdNota.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdNota.HeaderText = "Nota"
    Me.cdNota.Name = "cdNota"
    Me.cdNota.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    Me.cdNota.Width = 80
    '
    'cdLibro
    '
    Me.cdLibro.DataPropertyName = "AreaNivel"
    Me.cdLibro.HeaderText = "Área"
    Me.cdLibro.Name = "cdLibro"
    Me.cdLibro.ReadOnly = True
    Me.cdLibro.Width = 195
    '
    'cdDocente
    '
    Me.cdDocente.DataPropertyName = "DocenteNivel"
    Me.cdDocente.HeaderText = "Docente"
    Me.cdDocente.Name = "cdDocente"
    Me.cdDocente.Width = 150
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(720, 365)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(95, 50)
    Me.btnCerrar.TabIndex = 13
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnImportar
    '
    Me.btnImportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnImportar.BackColor = System.Drawing.Color.White
    Me.btnImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnImportar.Location = New System.Drawing.Point(579, 365)
    Me.btnImportar.Name = "btnImportar"
    Me.btnImportar.Size = New System.Drawing.Size(95, 50)
    Me.btnImportar.TabIndex = 12
    Me.btnImportar.Text = "I&mportar"
    Me.btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnImportar.UseVisualStyleBackColor = False
    '
    'btncancelar
    '
    Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btncancelar.BackColor = System.Drawing.Color.White
    Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btncancelar.Location = New System.Drawing.Point(234, 366)
    Me.btncancelar.Name = "btncancelar"
    Me.btncancelar.Size = New System.Drawing.Size(103, 50)
    Me.btncancelar.TabIndex = 10
    Me.btncancelar.Text = "Ca&ncelar"
    Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btncancelar.UseVisualStyleBackColor = False
    '
    'btnExportar
    '
    Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnExportar.BackColor = System.Drawing.Color.White
    Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnExportar.Location = New System.Drawing.Point(468, 366)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(95, 50)
    Me.btnExportar.TabIndex = 11
    Me.btnExportar.Text = "E&xportar"
    Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnExportar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Enabled = False
    Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(125, 365)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(93, 50)
    Me.btnRegistrar.TabIndex = 9
    Me.btnRegistrar.Text = "&Guardar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'cboNivel
    '
    Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Items.AddRange(New Object() {"Faltas", "Faltas justificadas", "Tardanzas", "Tardanzas justificadas"})
    Me.cboNivel.Location = New System.Drawing.Point(72, 39)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(147, 21)
    Me.cboNivel.TabIndex = 1
    '
    'lblNivel
    '
    Me.lblNivel.AutoSize = True
    Me.lblNivel.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblNivel.Location = New System.Drawing.Point(27, 42)
    Me.lblNivel.Name = "lblNivel"
    Me.lblNivel.Size = New System.Drawing.Size(39, 17)
    Me.lblNivel.TabIndex = 0
    Me.lblNivel.Text = "&Nivel"
    '
    'txtTotal
    '
    Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.txtTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTotal.Location = New System.Drawing.Point(56, 380)
    Me.txtTotal.Multiline = True
    Me.txtTotal.Name = "txtTotal"
    Me.txtTotal.ReadOnly = True
    Me.txtTotal.Size = New System.Drawing.Size(47, 24)
    Me.txtTotal.TabIndex = 8
    '
    'lblTotal
    '
    Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblTotal.AutoSize = True
    Me.lblTotal.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTotal.Location = New System.Drawing.Point(16, 384)
    Me.lblTotal.Name = "lblTotal"
    Me.lblTotal.Size = New System.Drawing.Size(34, 15)
    Me.lblTotal.TabIndex = 7
    Me.lblTotal.Text = "Total"
    '
    'gbLeyenda
    '
    Me.gbLeyenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbLeyenda.Controls.Add(Me.lblLeyenda1)
    Me.gbLeyenda.Controls.Add(Me.lblLeyenda2)
    Me.gbLeyenda.Location = New System.Drawing.Point(641, 24)
    Me.gbLeyenda.Name = "gbLeyenda"
    Me.gbLeyenda.Size = New System.Drawing.Size(230, 63)
    Me.gbLeyenda.TabIndex = 5
    Me.gbLeyenda.TabStop = False
    Me.gbLeyenda.Text = "Leyenda"
    Me.gbLeyenda.Visible = False
    '
    'lblLeyenda1
    '
    Me.lblLeyenda1.AutoSize = True
    Me.lblLeyenda1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblLeyenda1.ForeColor = System.Drawing.Color.DarkBlue
    Me.lblLeyenda1.Location = New System.Drawing.Point(6, 16)
    Me.lblLeyenda1.Name = "lblLeyenda1"
    Me.lblLeyenda1.Size = New System.Drawing.Size(145, 15)
    Me.lblLeyenda1.TabIndex = 0
    Me.lblLeyenda1.Text = "A, B, C y AD : calificación"
    Me.lblLeyenda1.Visible = False
    '
    'lblLeyenda2
    '
    Me.lblLeyenda2.AutoSize = True
    Me.lblLeyenda2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblLeyenda2.ForeColor = System.Drawing.Color.DarkBlue
    Me.lblLeyenda2.Location = New System.Drawing.Point(6, 41)
    Me.lblLeyenda2.Name = "lblLeyenda2"
    Me.lblLeyenda2.Size = New System.Drawing.Size(139, 15)
    Me.lblLeyenda2.TabIndex = 1
    Me.lblLeyenda2.Text = "NP        : No se presentó"
    Me.lblLeyenda2.Visible = False
    '
    'frmNotaInvestigacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(892, 438)
    Me.Controls.Add(Me.gbLeyenda)
    Me.Controls.Add(Me.txtTotal)
    Me.Controls.Add(Me.lblTotal)
    Me.Controls.Add(Me.lblNivel)
    Me.Controls.Add(Me.cboNivel)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnImportar)
    Me.Controls.Add(Me.btncancelar)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.btnListar)
    Me.Controls.Add(Me.cboSeccion)
    Me.Controls.Add(Me.lblPresentacion)
    Me.Controls.Add(Me.dgvNotas)
    Me.MinimizeBox = False
    Me.Name = "frmNotaInvestigacion"
    Me.Text = "Notas de Investigación"
    CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbLeyenda.ResumeLayout(False)
    Me.gbLeyenda.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents lblPresentacion As System.Windows.Forms.Label
  Friend WithEvents dgvNotas As System.Windows.Forms.DataGridView
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnImportar As System.Windows.Forms.Button
  Friend WithEvents btncancelar As System.Windows.Forms.Button
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents lblNivel As System.Windows.Forms.Label
  Friend WithEvents txtTotal As System.Windows.Forms.TextBox
  Friend WithEvents lblTotal As System.Windows.Forms.Label
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdNota As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdLibro As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDocente As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents gbLeyenda As System.Windows.Forms.GroupBox
  Friend WithEvents lblLeyenda1 As System.Windows.Forms.Label
  Friend WithEvents lblLeyenda2 As System.Windows.Forms.Label
End Class
