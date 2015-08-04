<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionNotasPlanLectorResponsable
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
    Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.lblAnio = New System.Windows.Forms.Label()
    Me.txtAnio = New System.Windows.Forms.TextBox()
    Me.lblPresentacion = New System.Windows.Forms.Label()
    Me.cboPresentacion = New System.Windows.Forms.ComboBox()
    Me.btnListar = New System.Windows.Forms.Button()
    Me.dgvNotas = New System.Windows.Forms.DataGridView()
    Me.cdSeccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdNota = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdLibro = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdNotaRecuperacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdLibroRecuperacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.txtTotal = New System.Windows.Forms.TextBox()
    Me.lblTotal = New System.Windows.Forms.Label()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.btncancelar = New System.Windows.Forms.Button()
    Me.btnRegistrar = New System.Windows.Forms.Button()
    Me.gbLeyenda = New System.Windows.Forms.GroupBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.lblVigente = New System.Windows.Forms.Label()
    Me.cboDocente = New System.Windows.Forms.ComboBox()
    Me.lblDocente = New System.Windows.Forms.Label()
    Me.btnExportar = New System.Windows.Forms.Button()
    Me.btnImportar = New System.Windows.Forms.Button()
    Me.btnExportarTodo = New System.Windows.Forms.Button()
    Me.btnRecuperacion = New System.Windows.Forms.Button()
    Me.pbAvance = New System.Windows.Forms.ProgressBar()
    CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbLeyenda.SuspendLayout()
    Me.SuspendLayout()
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblAnio.Location = New System.Drawing.Point(17, 40)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(34, 17)
    Me.lblAnio.TabIndex = 0
    Me.lblAnio.Text = "Año"
    '
    'txtAnio
    '
    Me.txtAnio.BackColor = System.Drawing.Color.White
    Me.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.txtAnio.Location = New System.Drawing.Point(87, 32)
    Me.txtAnio.Name = "txtAnio"
    Me.txtAnio.ReadOnly = True
    Me.txtAnio.Size = New System.Drawing.Size(79, 25)
    Me.txtAnio.TabIndex = 1
    Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'lblPresentacion
    '
    Me.lblPresentacion.AutoSize = True
    Me.lblPresentacion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblPresentacion.Location = New System.Drawing.Point(186, 40)
    Me.lblPresentacion.Name = "lblPresentacion"
    Me.lblPresentacion.Size = New System.Drawing.Size(85, 17)
    Me.lblPresentacion.TabIndex = 2
    Me.lblPresentacion.Text = "&Presentación"
    '
    'cboPresentacion
    '
    Me.cboPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboPresentacion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.cboPresentacion.FormattingEnabled = True
    Me.cboPresentacion.Location = New System.Drawing.Point(276, 31)
    Me.cboPresentacion.Name = "cboPresentacion"
    Me.cboPresentacion.Size = New System.Drawing.Size(88, 25)
    Me.cboPresentacion.TabIndex = 3
    '
    'btnListar
    '
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.btnListar.Location = New System.Drawing.Point(518, 57)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(113, 46)
    Me.btnListar.TabIndex = 8
    Me.btnListar.Text = "&Listar"
    Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnListar.UseVisualStyleBackColor = False
    '
    'dgvNotas
    '
    Me.dgvNotas.AllowUserToAddRows = False
    Me.dgvNotas.AllowUserToDeleteRows = False
    DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.dgvNotas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
    Me.dgvNotas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvNotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdSeccion, Me.cdAlumno, Me.cdNota, Me.cdLibro, Me.cdNotaRecuperacion, Me.cdLibroRecuperacion})
    Me.dgvNotas.Location = New System.Drawing.Point(12, 109)
    Me.dgvNotas.MultiSelect = False
    Me.dgvNotas.Name = "dgvNotas"
    DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvNotas.RowHeadersDefaultCellStyle = DataGridViewCellStyle20
    Me.dgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.dgvNotas.Size = New System.Drawing.Size(872, 400)
    Me.dgvNotas.TabIndex = 10
    '
    'cdSeccion
    '
    Me.cdSeccion.DataPropertyName = "Seccion"
    Me.cdSeccion.HeaderText = "Sección"
    Me.cdSeccion.Name = "cdSeccion"
    Me.cdSeccion.ReadOnly = True
    '
    'cdAlumno
    '
    Me.cdAlumno.DataPropertyName = "NombreCompleto"
    DataGridViewCellStyle17.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cdAlumno.DefaultCellStyle = DataGridViewCellStyle17
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.ReadOnly = True
    Me.cdAlumno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    Me.cdAlumno.Width = 270
    '
    'cdNota
    '
    Me.cdNota.DataPropertyName = "Nota"
    DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle18.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
    DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Yellow
    DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black
    Me.cdNota.DefaultCellStyle = DataGridViewCellStyle18
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
    'cdNotaRecuperacion
    '
    Me.cdNotaRecuperacion.DataPropertyName = "NotaRecuperacion"
    DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle19.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
    DataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
    DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Yellow
    DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black
    Me.cdNotaRecuperacion.DefaultCellStyle = DataGridViewCellStyle19
    Me.cdNotaRecuperacion.HeaderText = "Nota Rec."
    Me.cdNotaRecuperacion.Name = "cdNotaRecuperacion"
    Me.cdNotaRecuperacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    Me.cdNotaRecuperacion.Width = 40
    '
    'cdLibroRecuperacion
    '
    Me.cdLibroRecuperacion.DataPropertyName = "LibroRecuperacion"
    Me.cdLibroRecuperacion.HeaderText = "Libro de Recuperación"
    Me.cdLibroRecuperacion.Name = "cdLibroRecuperacion"
    Me.cdLibroRecuperacion.ReadOnly = True
    Me.cdLibroRecuperacion.Width = 195
    '
    'txtTotal
    '
    Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.txtTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTotal.Location = New System.Drawing.Point(49, 581)
    Me.txtTotal.Multiline = True
    Me.txtTotal.Name = "txtTotal"
    Me.txtTotal.ReadOnly = True
    Me.txtTotal.Size = New System.Drawing.Size(47, 24)
    Me.txtTotal.TabIndex = 13
    '
    'lblTotal
    '
    Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblTotal.AutoSize = True
    Me.lblTotal.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTotal.Location = New System.Drawing.Point(9, 585)
    Me.lblTotal.Name = "lblTotal"
    Me.lblTotal.Size = New System.Drawing.Size(34, 15)
    Me.lblTotal.TabIndex = 12
    Me.lblTotal.Text = "Total"
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(789, 561)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(95, 50)
    Me.btnCerrar.TabIndex = 1
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
    Me.btncancelar.Location = New System.Drawing.Point(332, 562)
    Me.btncancelar.Name = "btncancelar"
    Me.btncancelar.Size = New System.Drawing.Size(103, 50)
    Me.btncancelar.TabIndex = 16
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
    Me.btnRegistrar.Location = New System.Drawing.Point(132, 562)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(93, 50)
    Me.btnRegistrar.TabIndex = 14
    Me.btnRegistrar.Text = "&Guardar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'gbLeyenda
    '
    Me.gbLeyenda.Controls.Add(Me.Label5)
    Me.gbLeyenda.Controls.Add(Me.lblVigente)
    Me.gbLeyenda.Location = New System.Drawing.Point(654, 40)
    Me.gbLeyenda.Name = "gbLeyenda"
    Me.gbLeyenda.Size = New System.Drawing.Size(230, 63)
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
    Me.Label5.Size = New System.Drawing.Size(145, 15)
    Me.Label5.TabIndex = 0
    Me.Label5.Text = "A, B, C y AD : calificación"
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
    'cboDocente
    '
    Me.cboDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboDocente.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.cboDocente.FormattingEnabled = True
    Me.cboDocente.Location = New System.Drawing.Point(87, 77)
    Me.cboDocente.Name = "cboDocente"
    Me.cboDocente.Size = New System.Drawing.Size(392, 25)
    Me.cboDocente.TabIndex = 5
    '
    'lblDocente
    '
    Me.lblDocente.AutoSize = True
    Me.lblDocente.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblDocente.Location = New System.Drawing.Point(14, 86)
    Me.lblDocente.Name = "lblDocente"
    Me.lblDocente.Size = New System.Drawing.Size(58, 17)
    Me.lblDocente.TabIndex = 4
    Me.lblDocente.Text = "&Docente"
    '
    'btnExportar
    '
    Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnExportar.BackColor = System.Drawing.Color.White
    Me.btnExportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnExportar.Location = New System.Drawing.Point(463, 562)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(95, 50)
    Me.btnExportar.TabIndex = 17
    Me.btnExportar.Text = "E&xportar"
    Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnExportar.UseVisualStyleBackColor = False
    '
    'btnImportar
    '
    Me.btnImportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnImportar.BackColor = System.Drawing.Color.White
    Me.btnImportar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnImportar.Location = New System.Drawing.Point(665, 561)
    Me.btnImportar.Name = "btnImportar"
    Me.btnImportar.Size = New System.Drawing.Size(95, 50)
    Me.btnImportar.TabIndex = 0
    Me.btnImportar.Text = "I&mportar"
    Me.btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnImportar.UseVisualStyleBackColor = False
    '
    'btnExportarTodo
    '
    Me.btnExportarTodo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnExportarTodo.BackColor = System.Drawing.Color.White
    Me.btnExportarTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportarTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnExportarTodo.Location = New System.Drawing.Point(564, 561)
    Me.btnExportarTodo.Name = "btnExportarTodo"
    Me.btnExportarTodo.Size = New System.Drawing.Size(95, 50)
    Me.btnExportarTodo.TabIndex = 18
    Me.btnExportarTodo.Text = "Exportar &todo"
    Me.btnExportarTodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnExportarTodo.UseVisualStyleBackColor = False
    '
    'btnRecuperacion
    '
    Me.btnRecuperacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnRecuperacion.BackColor = System.Drawing.Color.White
    Me.btnRecuperacion.Enabled = False
    Me.btnRecuperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRecuperacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRecuperacion.Location = New System.Drawing.Point(231, 561)
    Me.btnRecuperacion.Name = "btnRecuperacion"
    Me.btnRecuperacion.Size = New System.Drawing.Size(95, 50)
    Me.btnRecuperacion.TabIndex = 15
    Me.btnRecuperacion.Text = "&Recuperación"
    Me.btnRecuperacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRecuperacion.UseVisualStyleBackColor = False
    '
    'pbAvance
    '
    Me.pbAvance.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.pbAvance.Location = New System.Drawing.Point(132, 527)
    Me.pbAvance.Name = "pbAvance"
    Me.pbAvance.Size = New System.Drawing.Size(322, 19)
    Me.pbAvance.TabIndex = 11
    '
    'frmGestionNotasPlanLectorResponsable
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(896, 617)
    Me.Controls.Add(Me.pbAvance)
    Me.Controls.Add(Me.btnRecuperacion)
    Me.Controls.Add(Me.btnExportarTodo)
    Me.Controls.Add(Me.lblDocente)
    Me.Controls.Add(Me.lblAnio)
    Me.Controls.Add(Me.cboDocente)
    Me.Controls.Add(Me.gbLeyenda)
    Me.Controls.Add(Me.txtAnio)
    Me.Controls.Add(Me.btnListar)
    Me.Controls.Add(Me.cboPresentacion)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.lblPresentacion)
    Me.Controls.Add(Me.btnImportar)
    Me.Controls.Add(Me.btncancelar)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.txtTotal)
    Me.Controls.Add(Me.lblTotal)
    Me.Controls.Add(Me.dgvNotas)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MinimizeBox = False
    Me.Name = "frmGestionNotasPlanLectorResponsable"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de Notas - Plan Lector"
    CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbLeyenda.ResumeLayout(False)
    Me.gbLeyenda.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents txtAnio As System.Windows.Forms.TextBox
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents lblPresentacion As System.Windows.Forms.Label
  Friend WithEvents cboPresentacion As System.Windows.Forms.ComboBox
  Friend WithEvents dgvNotas As System.Windows.Forms.DataGridView
  Friend WithEvents txtTotal As System.Windows.Forms.TextBox
  Friend WithEvents lblTotal As System.Windows.Forms.Label
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btncancelar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents gbLeyenda As System.Windows.Forms.GroupBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents lblVigente As System.Windows.Forms.Label
  Friend WithEvents lblDocente As System.Windows.Forms.Label
  Friend WithEvents cboDocente As System.Windows.Forms.ComboBox
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents btnImportar As System.Windows.Forms.Button
  Friend WithEvents btnExportarTodo As System.Windows.Forms.Button
  Friend WithEvents btnRecuperacion As System.Windows.Forms.Button
  Friend WithEvents cdSeccion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdNota As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdLibro As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdNotaRecuperacion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdLibroRecuperacion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents pbAvance As System.Windows.Forms.ProgressBar
End Class
