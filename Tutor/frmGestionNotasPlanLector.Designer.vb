<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionNotasPlanLector
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GBSeccion = New System.Windows.Forms.GroupBox
        Me.lblAnio = New System.Windows.Forms.Label
        Me.lblSeccion = New System.Windows.Forms.Label
        Me.txtAnio = New System.Windows.Forms.TextBox
        Me.cboSeccion = New System.Windows.Forms.ComboBox
        Me.txtInicio = New System.Windows.Forms.TextBox
        Me.txtFin = New System.Windows.Forms.TextBox
        Me.lblHasta = New System.Windows.Forms.Label
        Me.lblDe = New System.Windows.Forms.Label
        Me.lblPres = New System.Windows.Forms.Label
        Me.cboPresentacion = New System.Windows.Forms.ComboBox
        Me.btnListar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgvNotas = New System.Windows.Forms.DataGridView
        Me.cdNumero = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cdNota = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cdLibro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btncancelar = New System.Windows.Forms.Button
        Me.btnRegistrar = New System.Windows.Forms.Button
        Me.gbLeyenda = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblVigente = New System.Windows.Forms.Label
        Me.GBSeccion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLeyenda.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBSeccion
        '
        Me.GBSeccion.Controls.Add(Me.lblAnio)
        Me.GBSeccion.Controls.Add(Me.lblSeccion)
        Me.GBSeccion.Controls.Add(Me.txtAnio)
        Me.GBSeccion.Controls.Add(Me.cboSeccion)
        Me.GBSeccion.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBSeccion.Location = New System.Drawing.Point(12, 11)
        Me.GBSeccion.Name = "GBSeccion"
        Me.GBSeccion.Size = New System.Drawing.Size(181, 81)
        Me.GBSeccion.TabIndex = 0
        Me.GBSeccion.TabStop = False
        Me.GBSeccion.Text = "Sección"
        '
        'lblAnio
        '
        Me.lblAnio.AutoSize = True
        Me.lblAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.lblAnio.Location = New System.Drawing.Point(11, 16)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(36, 17)
        Me.lblAnio.TabIndex = 0
        Me.lblAnio.Text = "&Anio"
        '
        'lblSeccion
        '
        Me.lblSeccion.AutoSize = True
        Me.lblSeccion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.lblSeccion.Location = New System.Drawing.Point(11, 48)
        Me.lblSeccion.Name = "lblSeccion"
        Me.lblSeccion.Size = New System.Drawing.Size(54, 17)
        Me.lblSeccion.TabIndex = 2
        Me.lblSeccion.Text = "&Sección"
        '
        'txtAnio
        '
        Me.txtAnio.BackColor = System.Drawing.Color.White
        Me.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.txtAnio.Location = New System.Drawing.Point(74, 14)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.ReadOnly = True
        Me.txtAnio.Size = New System.Drawing.Size(100, 25)
        Me.txtAnio.TabIndex = 1
        Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboSeccion
        '
        Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeccion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.cboSeccion.FormattingEnabled = True
        Me.cboSeccion.Location = New System.Drawing.Point(73, 45)
        Me.cboSeccion.Name = "cboSeccion"
        Me.cboSeccion.Size = New System.Drawing.Size(101, 25)
        Me.cboSeccion.TabIndex = 3
        '
        'txtInicio
        '
        Me.txtInicio.BackColor = System.Drawing.Color.White
        Me.txtInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInicio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.txtInicio.Location = New System.Drawing.Point(130, 35)
        Me.txtInicio.Name = "txtInicio"
        Me.txtInicio.ReadOnly = True
        Me.txtInicio.Size = New System.Drawing.Size(73, 25)
        Me.txtInicio.TabIndex = 3
        Me.txtInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFin
        '
        Me.txtFin.BackColor = System.Drawing.Color.White
        Me.txtFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFin.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.txtFin.Location = New System.Drawing.Point(230, 35)
        Me.txtFin.Name = "txtFin"
        Me.txtFin.ReadOnly = True
        Me.txtFin.Size = New System.Drawing.Size(73, 25)
        Me.txtFin.TabIndex = 5
        Me.txtFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.lblHasta.Location = New System.Drawing.Point(209, 37)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(15, 17)
        Me.lblHasta.TabIndex = 4
        Me.lblHasta.Text = "a"
        '
        'lblDe
        '
        Me.lblDe.AutoSize = True
        Me.lblDe.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.lblDe.Location = New System.Drawing.Point(98, 37)
        Me.lblDe.Name = "lblDe"
        Me.lblDe.Size = New System.Drawing.Size(26, 17)
        Me.lblDe.TabIndex = 2
        Me.lblDe.Text = "&De"
        '
        'lblPres
        '
        Me.lblPres.AutoSize = True
        Me.lblPres.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.lblPres.Location = New System.Drawing.Point(6, 38)
        Me.lblPres.Name = "lblPres"
        Me.lblPres.Size = New System.Drawing.Size(31, 17)
        Me.lblPres.TabIndex = 0
        Me.lblPres.Text = "&Nro"
        '
        'cboPresentacion
        '
        Me.cboPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPresentacion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.cboPresentacion.FormattingEnabled = True
        Me.cboPresentacion.Location = New System.Drawing.Point(43, 35)
        Me.cboPresentacion.Name = "cboPresentacion"
        Me.cboPresentacion.Size = New System.Drawing.Size(49, 25)
        Me.cboPresentacion.TabIndex = 1
        '
        'btnListar
        '
        Me.btnListar.BackColor = System.Drawing.Color.White
        Me.btnListar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnListar.Location = New System.Drawing.Point(515, 39)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(76, 37)
        Me.btnListar.TabIndex = 2
        Me.btnListar.Text = "&Listar"
        Me.btnListar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtInicio)
        Me.GroupBox1.Controls.Add(Me.lblDe)
        Me.GroupBox1.Controls.Add(Me.txtFin)
        Me.GroupBox1.Controls.Add(Me.cboPresentacion)
        Me.GroupBox1.Controls.Add(Me.lblHasta)
        Me.GroupBox1.Controls.Add(Me.lblPres)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(199, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 81)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Presentación"
        '
        'dgvNotas
        '
        Me.dgvNotas.AllowUserToAddRows = False
        Me.dgvNotas.AllowUserToDeleteRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvNotas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvNotas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNumero, Me.cdAlumno, Me.cdNota, Me.cdLibro})
        Me.dgvNotas.Location = New System.Drawing.Point(12, 104)
        Me.dgvNotas.MultiSelect = False
        Me.dgvNotas.Name = "dgvNotas"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNotas.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvNotas.Size = New System.Drawing.Size(602, 483)
        Me.dgvNotas.TabIndex = 3
        '
        'cdNumero
        '
        Me.cdNumero.DataPropertyName = "NroOrden"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.NullValue = Nothing
        Me.cdNumero.DefaultCellStyle = DataGridViewCellStyle12
        Me.cdNumero.HeaderText = "Nº"
        Me.cdNumero.Name = "cdNumero"
        Me.cdNumero.ReadOnly = True
        Me.cdNumero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cdNumero.Width = 30
        '
        'cdAlumno
        '
        Me.cdAlumno.DataPropertyName = "NombreCompleto"
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdAlumno.DefaultCellStyle = DataGridViewCellStyle13
        Me.cdAlumno.HeaderText = "Alumno"
        Me.cdAlumno.Name = "cdAlumno"
        Me.cdAlumno.ReadOnly = True
        Me.cdAlumno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cdAlumno.Width = 270
        '
        'cdNota
        '
        Me.cdNota.DataPropertyName = "Nota"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black
        Me.cdNota.DefaultCellStyle = DataGridViewCellStyle14
        Me.cdNota.HeaderText = "Nota"
        Me.cdNota.Name = "cdNota"
        Me.cdNota.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cdNota.Width = 40
        '
        'cdLibro
        '
        Me.cdLibro.DataPropertyName = "Libro"
        Me.cdLibro.HeaderText = "Libro"
        Me.cdLibro.Name = "cdLibro"
        Me.cdLibro.ReadOnly = True
        Me.cdLibro.Width = 195
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(59, 597)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(34, 24)
        Me.txtTotal.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 601)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Total : "
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(632, 571)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(100, 50)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btncancelar.BackColor = System.Drawing.Color.White
        Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncancelar.Location = New System.Drawing.Point(653, 363)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(100, 50)
        Me.btncancelar.TabIndex = 5
        Me.btncancelar.Text = "Ca&ncelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRegistrar.BackColor = System.Drawing.Color.White
        Me.btnRegistrar.Enabled = False
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrar.Location = New System.Drawing.Point(653, 236)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(100, 50)
        Me.btnRegistrar.TabIndex = 4
        Me.btnRegistrar.Text = "&Guardar"
        Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'gbLeyenda
        '
        Me.gbLeyenda.Controls.Add(Me.Label5)
        Me.gbLeyenda.Controls.Add(Me.lblVigente)
        Me.gbLeyenda.Location = New System.Drawing.Point(616, 29)
        Me.gbLeyenda.Name = "gbLeyenda"
        Me.gbLeyenda.Size = New System.Drawing.Size(178, 63)
        Me.gbLeyenda.TabIndex = 9
        Me.gbLeyenda.TabStop = False
        Me.gbLeyenda.Text = "Leyenda"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "A, B, C y AD : NotasRegulares"
        '
        'lblVigente
        '
        Me.lblVigente.AutoSize = True
        Me.lblVigente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVigente.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblVigente.Location = New System.Drawing.Point(6, 41)
        Me.lblVigente.Name = "lblVigente"
        Me.lblVigente.Size = New System.Drawing.Size(139, 15)
        Me.lblVigente.TabIndex = 1
        Me.lblVigente.Text = "NP        : No se presentó"
        '
        'frmGestionNotasPlanLector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 625)
        Me.Controls.Add(Me.gbLeyenda)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvNotas)
        Me.Controls.Add(Me.GBSeccion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimizeBox = False
        Me.Name = "frmGestionNotasPlanLector"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Notas - Plan Lector"
        Me.GBSeccion.ResumeLayout(False)
        Me.GBSeccion.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLeyenda.ResumeLayout(False)
        Me.gbLeyenda.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBSeccion As System.Windows.Forms.GroupBox
    Friend WithEvents lblAnio As System.Windows.Forms.Label
    Friend WithEvents lblSeccion As System.Windows.Forms.Label
    Friend WithEvents txtAnio As System.Windows.Forms.TextBox
    Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
    Friend WithEvents btnListar As System.Windows.Forms.Button
    Friend WithEvents lblPres As System.Windows.Forms.Label
    Friend WithEvents cboPresentacion As System.Windows.Forms.ComboBox
    Friend WithEvents txtInicio As System.Windows.Forms.TextBox
    Friend WithEvents txtFin As System.Windows.Forms.TextBox
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents lblDe As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvNotas As System.Windows.Forms.DataGridView
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents cdNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdNota As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdLibro As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents gbLeyenda As System.Windows.Forms.GroupBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents lblVigente As System.Windows.Forms.Label
End Class
