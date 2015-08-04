<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionNotasPlanLectorSeccion
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
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.lblAnio = New System.Windows.Forms.Label
    Me.lblSeccion = New System.Windows.Forms.Label
    Me.txtAnio = New System.Windows.Forms.TextBox
    Me.cboSeccion = New System.Windows.Forms.ComboBox
    Me.txtInicio = New System.Windows.Forms.TextBox
    Me.txtFin = New System.Windows.Forms.TextBox
    Me.lblHasta = New System.Windows.Forms.Label
    Me.lblDe = New System.Windows.Forms.Label
    Me.lblPresentacion = New System.Windows.Forms.Label
    Me.cboPresentacion = New System.Windows.Forms.ComboBox
    Me.btnListar = New System.Windows.Forms.Button
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.dgvNotas = New System.Windows.Forms.DataGridView
    Me.cdNumero = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdNota = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdLibro = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.txtTotal = New System.Windows.Forms.TextBox
    Me.lblCantidad = New System.Windows.Forms.Label
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btncancelar = New System.Windows.Forms.Button
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.gbLeyenda = New System.Windows.Forms.GroupBox
    Me.Label5 = New System.Windows.Forms.Label
    Me.lblVigente = New System.Windows.Forms.Label
    Me.cboNivel = New System.Windows.Forms.ComboBox
    Me.lblNivel = New System.Windows.Forms.Label
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.btnRecuperar = New System.Windows.Forms.Button
    Me.GroupBox1.SuspendLayout()
    CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbLeyenda.SuspendLayout()
    Me.SuspendLayout()
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblAnio.Location = New System.Drawing.Point(18, 23)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(33, 17)
    Me.lblAnio.TabIndex = 0
    Me.lblAnio.Text = "&Año"
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblSeccion.Location = New System.Drawing.Point(350, 24)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(54, 17)
    Me.lblSeccion.TabIndex = 4
    Me.lblSeccion.Text = "&Sección"
    '
    'txtAnio
    '
    Me.txtAnio.BackColor = System.Drawing.Color.White
    Me.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.txtAnio.Location = New System.Drawing.Point(21, 45)
    Me.txtAnio.Name = "txtAnio"
    Me.txtAnio.ReadOnly = True
    Me.txtAnio.Size = New System.Drawing.Size(67, 25)
    Me.txtAnio.TabIndex = 1
    Me.txtAnio.TabStop = False
    Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'cboSeccion
    '
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(353, 46)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(223, 25)
    Me.cboSeccion.TabIndex = 5
    '
    'txtInicio
    '
    Me.txtInicio.BackColor = System.Drawing.Color.White
    Me.txtInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtInicio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.txtInicio.Location = New System.Drawing.Point(238, 35)
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
    Me.txtFin.Location = New System.Drawing.Point(329, 35)
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
    Me.lblHasta.Location = New System.Drawing.Point(313, 43)
    Me.lblHasta.Name = "lblHasta"
    Me.lblHasta.Size = New System.Drawing.Size(15, 17)
    Me.lblHasta.TabIndex = 4
    Me.lblHasta.Text = "a"
    '
    'lblDe
    '
    Me.lblDe.AutoSize = True
    Me.lblDe.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblDe.Location = New System.Drawing.Point(206, 43)
    Me.lblDe.Name = "lblDe"
    Me.lblDe.Size = New System.Drawing.Size(26, 17)
    Me.lblDe.TabIndex = 2
    Me.lblDe.Text = "&De"
    '
    'lblPresentacion
    '
    Me.lblPresentacion.AutoSize = True
    Me.lblPresentacion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblPresentacion.Location = New System.Drawing.Point(6, 43)
    Me.lblPresentacion.Name = "lblPresentacion"
    Me.lblPresentacion.Size = New System.Drawing.Size(56, 17)
    Me.lblPresentacion.TabIndex = 0
    Me.lblPresentacion.Text = "&Número"
    '
    'cboPresentacion
    '
    Me.cboPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboPresentacion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.cboPresentacion.FormattingEnabled = True
    Me.cboPresentacion.Location = New System.Drawing.Point(68, 35)
    Me.cboPresentacion.Name = "cboPresentacion"
    Me.cboPresentacion.Size = New System.Drawing.Size(97, 25)
    Me.cboPresentacion.TabIndex = 1
    '
    'btnListar
    '
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
    Me.btnListar.Location = New System.Drawing.Point(482, 133)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(94, 37)
    Me.btnListar.TabIndex = 7
    Me.btnListar.Text = "&Listar"
    Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnListar.UseVisualStyleBackColor = False
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.txtInicio)
    Me.GroupBox1.Controls.Add(Me.lblDe)
    Me.GroupBox1.Controls.Add(Me.txtFin)
    Me.GroupBox1.Controls.Add(Me.cboPresentacion)
    Me.GroupBox1.Controls.Add(Me.lblHasta)
    Me.GroupBox1.Controls.Add(Me.lblPresentacion)
    Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox1.Location = New System.Drawing.Point(12, 89)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(428, 81)
    Me.GroupBox1.TabIndex = 6
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Presentación"
    '
    'dgvNotas
    '
    Me.dgvNotas.AllowUserToAddRows = False
    Me.dgvNotas.AllowUserToDeleteRows = False
    DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.dgvNotas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
    Me.dgvNotas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvNotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNumero, Me.cdAlumno, Me.cdNota, Me.cdLibro})
    Me.dgvNotas.Location = New System.Drawing.Point(12, 176)
    Me.dgvNotas.MultiSelect = False
    Me.dgvNotas.Name = "dgvNotas"
    DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvNotas.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
    Me.dgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.dgvNotas.Size = New System.Drawing.Size(585, 315)
    Me.dgvNotas.TabIndex = 9
    '
    'cdNumero
    '
    Me.cdNumero.DataPropertyName = "NroOrden"
    DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle7.NullValue = Nothing
    Me.cdNumero.DefaultCellStyle = DataGridViewCellStyle7
    Me.cdNumero.HeaderText = "Nº"
    Me.cdNumero.Name = "cdNumero"
    Me.cdNumero.ReadOnly = True
    Me.cdNumero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    Me.cdNumero.Width = 30
    '
    'cdAlumno
    '
    Me.cdAlumno.DataPropertyName = "NombreCompleto"
    DataGridViewCellStyle8.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cdAlumno.DefaultCellStyle = DataGridViewCellStyle8
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.ReadOnly = True
    Me.cdAlumno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    Me.cdAlumno.Width = 270
    '
    'cdNota
    '
    Me.cdNota.DataPropertyName = "Nota"
    DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle9.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
    DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Yellow
    DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
    Me.cdNota.DefaultCellStyle = DataGridViewCellStyle9
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
    Me.txtTotal.Location = New System.Drawing.Point(70, 497)
    Me.txtTotal.Multiline = True
    Me.txtTotal.Name = "txtTotal"
    Me.txtTotal.ReadOnly = True
    Me.txtTotal.Size = New System.Drawing.Size(46, 24)
    Me.txtTotal.TabIndex = 11
    '
    'lblCantidad
    '
    Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblCantidad.AutoSize = True
    Me.lblCantidad.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCantidad.Location = New System.Drawing.Point(9, 506)
    Me.lblCantidad.Name = "lblCantidad"
    Me.lblCantidad.Size = New System.Drawing.Size(55, 15)
    Me.lblCantidad.TabIndex = 10
    Me.lblCantidad.Text = "Cantidad"
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(667, 471)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(116, 50)
    Me.btnCerrar.TabIndex = 14
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
    Me.btncancelar.Location = New System.Drawing.Point(667, 232)
    Me.btncancelar.Name = "btncancelar"
    Me.btncancelar.Size = New System.Drawing.Size(116, 50)
    Me.btncancelar.TabIndex = 13
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
    Me.btnRegistrar.Location = New System.Drawing.Point(667, 176)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(116, 50)
    Me.btnRegistrar.TabIndex = 12
    Me.btnRegistrar.Text = "&Guardar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'gbLeyenda
    '
    Me.gbLeyenda.Controls.Add(Me.Label5)
    Me.gbLeyenda.Controls.Add(Me.lblVigente)
    Me.gbLeyenda.Location = New System.Drawing.Point(582, 107)
    Me.gbLeyenda.Name = "gbLeyenda"
    Me.gbLeyenda.Size = New System.Drawing.Size(201, 63)
    Me.gbLeyenda.TabIndex = 8
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
    'cboNivel
    '
    Me.cboNivel.BackColor = System.Drawing.SystemColors.Info
    Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNivel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Location = New System.Drawing.Point(113, 46)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(222, 24)
    Me.cboNivel.TabIndex = 3
    '
    'lblNivel
    '
    Me.lblNivel.AutoSize = True
    Me.lblNivel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNivel.Location = New System.Drawing.Point(110, 24)
    Me.lblNivel.Name = "lblNivel"
    Me.lblNivel.Size = New System.Drawing.Size(35, 15)
    Me.lblNivel.TabIndex = 2
    Me.lblNivel.Text = "&Nivel"
    '
    'GroupBox2
    '
    Me.GroupBox2.Location = New System.Drawing.Point(89, 241)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(472, 148)
    Me.GroupBox2.TabIndex = 15
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "GroupBox2"
    Me.GroupBox2.Visible = False
    '
    'btnRecuperar
    '
    Me.btnRecuperar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnRecuperar.BackColor = System.Drawing.Color.White
    Me.btnRecuperar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRecuperar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRecuperar.Location = New System.Drawing.Point(667, 288)
    Me.btnRecuperar.Name = "btnRecuperar"
    Me.btnRecuperar.Size = New System.Drawing.Size(114, 50)
    Me.btnRecuperar.TabIndex = 17
    Me.btnRecuperar.Text = "&Registrar recuperación"
    Me.btnRecuperar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRecuperar.UseVisualStyleBackColor = False
    Me.btnRecuperar.Visible = False
    '
    'frmGestionNotasPlanLectorSeccion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(795, 525)
    Me.Controls.Add(Me.btnRecuperar)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.cboNivel)
    Me.Controls.Add(Me.lblNivel)
    Me.Controls.Add(Me.lblAnio)
    Me.Controls.Add(Me.lblSeccion)
    Me.Controls.Add(Me.gbLeyenda)
    Me.Controls.Add(Me.txtAnio)
    Me.Controls.Add(Me.btnListar)
    Me.Controls.Add(Me.cboSeccion)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btncancelar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.txtTotal)
    Me.Controls.Add(Me.lblCantidad)
    Me.Controls.Add(Me.dgvNotas)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MinimizeBox = False
    Me.Name = "frmGestionNotasPlanLectorSeccion"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de Notas - Plan Lector"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbLeyenda.ResumeLayout(False)
    Me.gbLeyenda.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents txtAnio As System.Windows.Forms.TextBox
  Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents lblPresentacion As System.Windows.Forms.Label
  Friend WithEvents cboPresentacion As System.Windows.Forms.ComboBox
  Friend WithEvents txtInicio As System.Windows.Forms.TextBox
  Friend WithEvents txtFin As System.Windows.Forms.TextBox
  Friend WithEvents lblHasta As System.Windows.Forms.Label
  Friend WithEvents lblDe As System.Windows.Forms.Label
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents dgvNotas As System.Windows.Forms.DataGridView
  Friend WithEvents txtTotal As System.Windows.Forms.TextBox
  Friend WithEvents lblCantidad As System.Windows.Forms.Label
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
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents lblNivel As System.Windows.Forms.Label
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents btnRecuperar As System.Windows.Forms.Button
End Class
