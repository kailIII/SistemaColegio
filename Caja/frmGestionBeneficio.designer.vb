<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionBeneficio
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
    Me.components = New System.ComponentModel.Container()
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.cboAutorizado = New System.Windows.Forms.ComboBox()
    Me.btnRegistrar = New System.Windows.Forms.Button()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.ErrorBeneficio = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.lblAutorizado = New System.Windows.Forms.Label()
    Me.lblDescuento = New System.Windows.Forms.Label()
    Me.gpbBeneficio = New System.Windows.Forms.GroupBox()
    Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
    Me.lblFecha = New System.Windows.Forms.Label()
    Me.nudDescuento = New System.Windows.Forms.NumericUpDown()
    Me.cboMotivo = New System.Windows.Forms.ComboBox()
    Me.LblMotivo = New System.Windows.Forms.Label()
    Me.gbAlumnos = New System.Windows.Forms.GroupBox()
    Me.btnListar = New System.Windows.Forms.Button()
    Me.cboGrado = New System.Windows.Forms.ComboBox()
    Me.chkSeleccionarTodos = New System.Windows.Forms.CheckBox()
    Me.dgvAlumnos = New System.Windows.Forms.DataGridView()
    Me.cdSeleccionado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.lblGrado = New System.Windows.Forms.Label()
    Me.cboAnio = New System.Windows.Forms.ComboBox()
    Me.lblAnioLectivo = New System.Windows.Forms.Label()
    Me.gbPogramacion = New System.Windows.Forms.GroupBox()
    Me.chkSeleccionarTodosProgramacion = New System.Windows.Forms.CheckBox()
    Me.dgvMeses = New System.Windows.Forms.DataGridView()
    Me.cdSeleccionarMes = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.cdMes = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btnVerProgramacion = New System.Windows.Forms.Button()
    CType(Me.ErrorBeneficio, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gpbBeneficio.SuspendLayout()
    CType(Me.nudDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbAlumnos.SuspendLayout()
    CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbPogramacion.SuspendLayout()
    CType(Me.dgvMeses, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cboAutorizado
    '
    Me.cboAutorizado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cboAutorizado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cboAutorizado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboAutorizado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAutorizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboAutorizado.FormattingEnabled = True
    Me.cboAutorizado.Location = New System.Drawing.Point(72, 23)
    Me.cboAutorizado.Name = "cboAutorizado"
    Me.cboAutorizado.Size = New System.Drawing.Size(371, 24)
    Me.cboAutorizado.TabIndex = 1
    '
    'btnRegistrar
    '
    Me.btnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(742, 420)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(111, 44)
    Me.btnRegistrar.TabIndex = 6
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(742, 470)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(111, 44)
    Me.btnCancelar.TabIndex = 7
    Me.btnCancelar.Text = "&Cancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'ErrorBeneficio
    '
    Me.ErrorBeneficio.ContainerControl = Me
    '
    'lblAutorizado
    '
    Me.lblAutorizado.AutoSize = True
    Me.lblAutorizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAutorizado.Location = New System.Drawing.Point(9, 34)
    Me.lblAutorizado.Name = "lblAutorizado"
    Me.lblAutorizado.Size = New System.Drawing.Size(57, 13)
    Me.lblAutorizado.TabIndex = 0
    Me.lblAutorizado.Text = "A&utorizado"
    '
    'lblDescuento
    '
    Me.lblDescuento.AutoSize = True
    Me.lblDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDescuento.Location = New System.Drawing.Point(300, 113)
    Me.lblDescuento.Name = "lblDescuento"
    Me.lblDescuento.Size = New System.Drawing.Size(59, 13)
    Me.lblDescuento.TabIndex = 4
    Me.lblDescuento.Text = "D&escuento"
    '
    'gpbBeneficio
    '
    Me.gpbBeneficio.Controls.Add(Me.dtpFecha)
    Me.gpbBeneficio.Controls.Add(Me.lblFecha)
    Me.gpbBeneficio.Controls.Add(Me.nudDescuento)
    Me.gpbBeneficio.Controls.Add(Me.cboMotivo)
    Me.gpbBeneficio.Controls.Add(Me.cboAutorizado)
    Me.gpbBeneficio.Controls.Add(Me.LblMotivo)
    Me.gpbBeneficio.Controls.Add(Me.lblAutorizado)
    Me.gpbBeneficio.Controls.Add(Me.lblDescuento)
    Me.gpbBeneficio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gpbBeneficio.Location = New System.Drawing.Point(15, 68)
    Me.gpbBeneficio.Name = "gpbBeneficio"
    Me.gpbBeneficio.Size = New System.Drawing.Size(449, 141)
    Me.gpbBeneficio.TabIndex = 4
    Me.gpbBeneficio.TabStop = False
    Me.gpbBeneficio.Text = "Beneficio"
    '
    'dtpFecha
    '
    Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFecha.Location = New System.Drawing.Point(72, 106)
    Me.dtpFecha.Name = "dtpFecha"
    Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
    Me.dtpFecha.TabIndex = 7
    '
    'lblFecha
    '
    Me.lblFecha.AutoSize = True
    Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFecha.Location = New System.Drawing.Point(9, 113)
    Me.lblFecha.Name = "lblFecha"
    Me.lblFecha.Size = New System.Drawing.Size(37, 13)
    Me.lblFecha.TabIndex = 6
    Me.lblFecha.Text = "&Fecha"
    '
    'nudDescuento
    '
    Me.nudDescuento.Increment = New Decimal(New Integer() {5, 0, 0, 0})
    Me.nudDescuento.Location = New System.Drawing.Point(365, 106)
    Me.nudDescuento.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
    Me.nudDescuento.Name = "nudDescuento"
    Me.nudDescuento.Size = New System.Drawing.Size(78, 20)
    Me.nudDescuento.TabIndex = 5
    Me.nudDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'cboMotivo
    '
    Me.cboMotivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cboMotivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cboMotivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboMotivo.FormattingEnabled = True
    Me.cboMotivo.Items.AddRange(New Object() {"NRO DE HERMANOS", "STM", "ORFANDAD", "USAT"})
    Me.cboMotivo.Location = New System.Drawing.Point(72, 62)
    Me.cboMotivo.MaxLength = 60
    Me.cboMotivo.Name = "cboMotivo"
    Me.cboMotivo.Size = New System.Drawing.Size(371, 24)
    Me.cboMotivo.TabIndex = 3
    '
    'LblMotivo
    '
    Me.LblMotivo.AutoSize = True
    Me.LblMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LblMotivo.Location = New System.Drawing.Point(9, 73)
    Me.LblMotivo.Name = "LblMotivo"
    Me.LblMotivo.Size = New System.Drawing.Size(39, 13)
    Me.LblMotivo.TabIndex = 2
    Me.LblMotivo.Text = "&Motivo"
    '
    'gbAlumnos
    '
    Me.gbAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbAlumnos.Controls.Add(Me.btnListar)
    Me.gbAlumnos.Controls.Add(Me.cboGrado)
    Me.gbAlumnos.Controls.Add(Me.chkSeleccionarTodos)
    Me.gbAlumnos.Controls.Add(Me.dgvAlumnos)
    Me.gbAlumnos.Controls.Add(Me.lblGrado)
    Me.gbAlumnos.Location = New System.Drawing.Point(15, 215)
    Me.gbAlumnos.Name = "gbAlumnos"
    Me.gbAlumnos.Size = New System.Drawing.Size(721, 299)
    Me.gbAlumnos.TabIndex = 5
    Me.gbAlumnos.TabStop = False
    Me.gbAlumnos.Text = "Alumnos"
    '
    'btnListar
    '
    Me.btnListar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnListar.Location = New System.Drawing.Point(283, 19)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(102, 27)
    Me.btnListar.TabIndex = 4
    Me.btnListar.Text = "&Listar"
    Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnListar.UseVisualStyleBackColor = True
    '
    'cboGrado
    '
    Me.cboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboGrado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboGrado.FormattingEnabled = True
    Me.cboGrado.Location = New System.Drawing.Point(72, 21)
    Me.cboGrado.Name = "cboGrado"
    Me.cboGrado.Size = New System.Drawing.Size(153, 24)
    Me.cboGrado.TabIndex = 3
    '
    'chkSeleccionarTodos
    '
    Me.chkSeleccionarTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.chkSeleccionarTodos.AutoSize = True
    Me.chkSeleccionarTodos.Location = New System.Drawing.Point(10, 277)
    Me.chkSeleccionarTodos.Name = "chkSeleccionarTodos"
    Me.chkSeleccionarTodos.Size = New System.Drawing.Size(111, 17)
    Me.chkSeleccionarTodos.TabIndex = 6
    Me.chkSeleccionarTodos.Text = "Seleccionar &todos"
    Me.chkSeleccionarTodos.UseVisualStyleBackColor = True
    '
    'dgvAlumnos
    '
    Me.dgvAlumnos.AllowUserToAddRows = False
    Me.dgvAlumnos.AllowUserToDeleteRows = False
    Me.dgvAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdSeleccionado, Me.cdAlumno})
    Me.dgvAlumnos.Location = New System.Drawing.Point(9, 52)
    Me.dgvAlumnos.Name = "dgvAlumnos"
    Me.dgvAlumnos.Size = New System.Drawing.Size(706, 219)
    Me.dgvAlumnos.TabIndex = 5
    '
    'cdSeleccionado
    '
    Me.cdSeleccionado.DataPropertyName = "Seleccionado"
    Me.cdSeleccionado.HeaderText = "Seleccionado"
    Me.cdSeleccionado.Name = "cdSeleccionado"
    '
    'cdAlumno
    '
    Me.cdAlumno.DataPropertyName = "NombreAlumno"
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.ReadOnly = True
    Me.cdAlumno.Width = 350
    '
    'lblGrado
    '
    Me.lblGrado.AutoSize = True
    Me.lblGrado.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblGrado.Location = New System.Drawing.Point(6, 30)
    Me.lblGrado.Name = "lblGrado"
    Me.lblGrado.Size = New System.Drawing.Size(39, 15)
    Me.lblGrado.TabIndex = 2
    Me.lblGrado.Text = "&Grado"
    '
    'cboAnio
    '
    Me.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAnio.FormattingEnabled = True
    Me.cboAnio.Location = New System.Drawing.Point(76, 31)
    Me.cboAnio.Name = "cboAnio"
    Me.cboAnio.Size = New System.Drawing.Size(107, 21)
    Me.cboAnio.TabIndex = 1
    '
    'lblAnioLectivo
    '
    Me.lblAnioLectivo.AutoSize = True
    Me.lblAnioLectivo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAnioLectivo.Location = New System.Drawing.Point(39, 38)
    Me.lblAnioLectivo.Name = "lblAnioLectivo"
    Me.lblAnioLectivo.Size = New System.Drawing.Size(31, 15)
    Me.lblAnioLectivo.TabIndex = 0
    Me.lblAnioLectivo.Text = "Año"
    '
    'gbPogramacion
    '
    Me.gbPogramacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbPogramacion.Controls.Add(Me.chkSeleccionarTodosProgramacion)
    Me.gbPogramacion.Controls.Add(Me.dgvMeses)
    Me.gbPogramacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbPogramacion.Location = New System.Drawing.Point(470, 18)
    Me.gbPogramacion.Name = "gbPogramacion"
    Me.gbPogramacion.Size = New System.Drawing.Size(383, 191)
    Me.gbPogramacion.TabIndex = 3
    Me.gbPogramacion.TabStop = False
    Me.gbPogramacion.Text = "Programación"
    '
    'chkSeleccionarTodosProgramacion
    '
    Me.chkSeleccionarTodosProgramacion.AutoSize = True
    Me.chkSeleccionarTodosProgramacion.Location = New System.Drawing.Point(6, 168)
    Me.chkSeleccionarTodosProgramacion.Name = "chkSeleccionarTodosProgramacion"
    Me.chkSeleccionarTodosProgramacion.Size = New System.Drawing.Size(111, 17)
    Me.chkSeleccionarTodosProgramacion.TabIndex = 1
    Me.chkSeleccionarTodosProgramacion.Text = "&Seleccionar todos"
    Me.chkSeleccionarTodosProgramacion.UseVisualStyleBackColor = True
    '
    'dgvMeses
    '
    Me.dgvMeses.AllowUserToAddRows = False
    Me.dgvMeses.AllowUserToDeleteRows = False
    Me.dgvMeses.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvMeses.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvMeses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvMeses.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdSeleccionarMes, Me.cdMes, Me.cdVencimiento})
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgvMeses.DefaultCellStyle = DataGridViewCellStyle3
    Me.dgvMeses.Location = New System.Drawing.Point(6, 23)
    Me.dgvMeses.MultiSelect = False
    Me.dgvMeses.Name = "dgvMeses"
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvMeses.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.dgvMeses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvMeses.Size = New System.Drawing.Size(368, 130)
    Me.dgvMeses.TabIndex = 0
    '
    'cdSeleccionarMes
    '
    Me.cdSeleccionarMes.DataPropertyName = "Seleccionado"
    Me.cdSeleccionarMes.HeaderText = "Seleccionado"
    Me.cdSeleccionarMes.Name = "cdSeleccionarMes"
    Me.cdSeleccionarMes.Width = 80
    '
    'cdMes
    '
    Me.cdMes.DataPropertyName = "Descripcion"
    Me.cdMes.HeaderText = "Mes"
    Me.cdMes.Name = "cdMes"
    Me.cdMes.ReadOnly = True
    Me.cdMes.Width = 160
    '
    'cdVencimiento
    '
    Me.cdVencimiento.DataPropertyName = "Vencimiento"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle2.Format = "d"
    DataGridViewCellStyle2.NullValue = Nothing
    Me.cdVencimiento.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdVencimiento.HeaderText = "Vencimiento"
    Me.cdVencimiento.Name = "cdVencimiento"
    Me.cdVencimiento.ReadOnly = True
    '
    'btnVerProgramacion
    '
    Me.btnVerProgramacion.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnVerProgramacion.Location = New System.Drawing.Point(208, 18)
    Me.btnVerProgramacion.Name = "btnVerProgramacion"
    Me.btnVerProgramacion.Size = New System.Drawing.Size(166, 44)
    Me.btnVerProgramacion.TabIndex = 2
    Me.btnVerProgramacion.Text = "&Ver programación"
    Me.btnVerProgramacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnVerProgramacion.UseVisualStyleBackColor = True
    '
    'frmGestionBeneficio
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCancelar
    Me.ClientSize = New System.Drawing.Size(865, 526)
    Me.Controls.Add(Me.btnVerProgramacion)
    Me.Controls.Add(Me.cboAnio)
    Me.Controls.Add(Me.gbPogramacion)
    Me.Controls.Add(Me.gbAlumnos)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.lblAnioLectivo)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.gpbBeneficio)
    Me.Name = "frmGestionBeneficio"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Registrar Beneficio"
    CType(Me.ErrorBeneficio, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gpbBeneficio.ResumeLayout(False)
    Me.gpbBeneficio.PerformLayout()
    CType(Me.nudDescuento, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbAlumnos.ResumeLayout(False)
    Me.gbAlumnos.PerformLayout()
    CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbPogramacion.ResumeLayout(False)
    Me.gbPogramacion.PerformLayout()
    CType(Me.dgvMeses, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cboAutorizado As System.Windows.Forms.ComboBox
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents ErrorBeneficio As System.Windows.Forms.ErrorProvider
  Friend WithEvents gpbBeneficio As System.Windows.Forms.GroupBox
  Friend WithEvents lblAutorizado As System.Windows.Forms.Label
  Friend WithEvents lblDescuento As System.Windows.Forms.Label
  Friend WithEvents cboMotivo As System.Windows.Forms.ComboBox
  Friend WithEvents LblMotivo As System.Windows.Forms.Label
  Friend WithEvents gbAlumnos As System.Windows.Forms.GroupBox
  Friend WithEvents chkSeleccionarTodos As System.Windows.Forms.CheckBox
  Friend WithEvents dgvAlumnos As System.Windows.Forms.DataGridView
  Friend WithEvents cdSeleccionado As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents cboGrado As System.Windows.Forms.ComboBox
  Friend WithEvents lblAnioLectivo As System.Windows.Forms.Label
  Friend WithEvents lblGrado As System.Windows.Forms.Label
  Friend WithEvents gbPogramacion As System.Windows.Forms.GroupBox
  Friend WithEvents dgvMeses As System.Windows.Forms.DataGridView
  Friend WithEvents cdSeleccionarMes As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents cdMes As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdVencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents nudDescuento As System.Windows.Forms.NumericUpDown
  Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
  Friend WithEvents lblFecha As System.Windows.Forms.Label
  Friend WithEvents chkSeleccionarTodosProgramacion As System.Windows.Forms.CheckBox
  Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
  Friend WithEvents btnVerProgramacion As System.Windows.Forms.Button
End Class
