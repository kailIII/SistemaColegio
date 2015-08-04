<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignacionAcad
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
    Me.components = New System.ComponentModel.Container
    Dim DataGridViewCellStyle78 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle83 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle79 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle80 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle81 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle82 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle84 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle88 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle85 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle86 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle87 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnQuitar = New System.Windows.Forms.Button
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.txthours = New System.Windows.Forms.Label
    Me.lblHours = New System.Windows.Forms.Label
    Me.txtEspecialidad = New System.Windows.Forms.Label
    Me.lblEspecialidad = New System.Windows.Forms.Label
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnGuardar = New System.Windows.Forms.Button
    Me.dgCursosAsig = New System.Windows.Forms.DataGridView
    Me.dgGradoAsig = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdHorasAsig = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCursosAsig = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdnivelAsig = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdBlanco = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cboDocente = New System.Windows.Forms.ComboBox
    Me.txtTotHoras = New System.Windows.Forms.Label
    Me.lblTotHoras = New System.Windows.Forms.Label
    Me.btnRetirar = New System.Windows.Forms.Button
    Me.btnAsignar = New System.Windows.Forms.Button
    Me.cboNivel1 = New System.Windows.Forms.ComboBox
    Me.lblNivel1 = New System.Windows.Forms.Label
    Me.dgCursos = New System.Windows.Forms.DataGridView
    Me.cdGrado = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCurso = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdEstado = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.lblDocente1 = New System.Windows.Forms.Label
    Me.errAsignAcad = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.gbAsignar = New System.Windows.Forms.GroupBox
    Me.btnBuscar = New System.Windows.Forms.Button
    Me.GroupBox2.SuspendLayout()
    CType(Me.dgCursosAsig, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dgCursos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.errAsignAcad, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbAsignar.SuspendLayout()
    Me.SuspendLayout()
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(875, 481)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 50)
    Me.btnCerrar.TabIndex = 9
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnQuitar
    '
    Me.btnQuitar.Location = New System.Drawing.Point(849, 390)
    Me.btnQuitar.Name = "btnQuitar"
    Me.btnQuitar.Size = New System.Drawing.Size(88, 27)
    Me.btnQuitar.TabIndex = 5
    Me.btnQuitar.Text = "Q&uitar Todos"
    Me.btnQuitar.UseVisualStyleBackColor = True
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.txthours)
    Me.GroupBox2.Controls.Add(Me.lblHours)
    Me.GroupBox2.Controls.Add(Me.txtEspecialidad)
    Me.GroupBox2.Controls.Add(Me.lblEspecialidad)
    Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox2.Location = New System.Drawing.Point(507, 54)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(456, 49)
    Me.GroupBox2.TabIndex = 5
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Datos del Docente"
    '
    'txthours
    '
    Me.txthours.AutoSize = True
    Me.txthours.BackColor = System.Drawing.SystemColors.Window
    Me.txthours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txthours.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txthours.Location = New System.Drawing.Point(415, 19)
    Me.txthours.MaximumSize = New System.Drawing.Size(25, 24)
    Me.txthours.MinimumSize = New System.Drawing.Size(25, 24)
    Me.txthours.Name = "txthours"
    Me.txthours.Size = New System.Drawing.Size(25, 24)
    Me.txthours.TabIndex = 3
    Me.txthours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblHours
    '
    Me.lblHours.AutoSize = True
    Me.lblHours.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblHours.Location = New System.Drawing.Point(313, 23)
    Me.lblHours.Name = "lblHours"
    Me.lblHours.Size = New System.Drawing.Size(103, 15)
    Me.lblHours.TabIndex = 2
    Me.lblHours.Text = "Horas Asignadas:"
    '
    'txtEspecialidad
    '
    Me.txtEspecialidad.AutoSize = True
    Me.txtEspecialidad.BackColor = System.Drawing.SystemColors.Window
    Me.txtEspecialidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtEspecialidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtEspecialidad.Location = New System.Drawing.Point(89, 19)
    Me.txtEspecialidad.MaximumSize = New System.Drawing.Size(215, 24)
    Me.txtEspecialidad.MinimumSize = New System.Drawing.Size(215, 24)
    Me.txtEspecialidad.Name = "txtEspecialidad"
    Me.txtEspecialidad.Size = New System.Drawing.Size(215, 24)
    Me.txtEspecialidad.TabIndex = 1
    Me.txtEspecialidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblEspecialidad
    '
    Me.lblEspecialidad.AutoSize = True
    Me.lblEspecialidad.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblEspecialidad.Location = New System.Drawing.Point(13, 23)
    Me.lblEspecialidad.Name = "lblEspecialidad"
    Me.lblEspecialidad.Size = New System.Drawing.Size(77, 15)
    Me.lblEspecialidad.TabIndex = 0
    Me.lblEspecialidad.Text = "Especialidad:"
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(693, 481)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 50)
    Me.btnCancelar.TabIndex = 8
    Me.btnCancelar.Text = "C&ancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnGuardar
    '
    Me.btnGuardar.BackColor = System.Drawing.Color.White
    Me.btnGuardar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnGuardar.Location = New System.Drawing.Point(577, 481)
    Me.btnGuardar.Name = "btnGuardar"
    Me.btnGuardar.Size = New System.Drawing.Size(110, 50)
    Me.btnGuardar.TabIndex = 7
    Me.btnGuardar.Text = "&Registrar"
    Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnGuardar.UseVisualStyleBackColor = False
    '
    'dgCursosAsig
    '
    Me.dgCursosAsig.AllowUserToAddRows = False
    Me.dgCursosAsig.AllowUserToDeleteRows = False
    Me.dgCursosAsig.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgCursosAsig.BackgroundColor = System.Drawing.SystemColors.Window
    Me.dgCursosAsig.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    DataGridViewCellStyle78.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle78.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle78.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle78.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle78.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle78.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle78.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgCursosAsig.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle78
    Me.dgCursosAsig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgCursosAsig.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgGradoAsig, Me.cdHorasAsig, Me.cdCursosAsig, Me.cdnivelAsig, Me.cdBlanco})
    Me.dgCursosAsig.GridColor = System.Drawing.SystemColors.ScrollBar
    Me.dgCursosAsig.Location = New System.Drawing.Point(495, 92)
    Me.dgCursosAsig.MultiSelect = False
    Me.dgCursosAsig.Name = "dgCursosAsig"
    Me.dgCursosAsig.ReadOnly = True
    DataGridViewCellStyle83.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle83.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle83.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle83.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle83.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle83.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle83.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgCursosAsig.RowHeadersDefaultCellStyle = DataGridViewCellStyle83
    Me.dgCursosAsig.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.dgCursosAsig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgCursosAsig.Size = New System.Drawing.Size(453, 296)
    Me.dgCursosAsig.TabIndex = 2
    '
    'dgGradoAsig
    '
    DataGridViewCellStyle79.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.dgGradoAsig.DefaultCellStyle = DataGridViewCellStyle79
    Me.dgGradoAsig.HeaderText = "GRADO"
    Me.dgGradoAsig.Name = "dgGradoAsig"
    Me.dgGradoAsig.ReadOnly = True
    Me.dgGradoAsig.Width = 50
    '
    'cdHorasAsig
    '
    DataGridViewCellStyle80.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.cdHorasAsig.DefaultCellStyle = DataGridViewCellStyle80
    Me.cdHorasAsig.HeaderText = "HORAS"
    Me.cdHorasAsig.Name = "cdHorasAsig"
    Me.cdHorasAsig.ReadOnly = True
    Me.cdHorasAsig.Width = 48
    '
    'cdCursosAsig
    '
    DataGridViewCellStyle81.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    Me.cdCursosAsig.DefaultCellStyle = DataGridViewCellStyle81
    Me.cdCursosAsig.HeaderText = "CURSO_ASIGNADO"
    Me.cdCursosAsig.Name = "cdCursosAsig"
    Me.cdCursosAsig.ReadOnly = True
    Me.cdCursosAsig.Width = 190
    '
    'cdnivelAsig
    '
    DataGridViewCellStyle82.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.cdnivelAsig.DefaultCellStyle = DataGridViewCellStyle82
    Me.cdnivelAsig.HeaderText = "NIVEL"
    Me.cdnivelAsig.Name = "cdnivelAsig"
    Me.cdnivelAsig.ReadOnly = True
    Me.cdnivelAsig.Width = 103
    '
    'cdBlanco
    '
    Me.cdBlanco.HeaderText = ""
    Me.cdBlanco.Name = "cdBlanco"
    Me.cdBlanco.ReadOnly = True
    Me.cdBlanco.Visible = False
    Me.cdBlanco.Width = 14
    '
    'cboDocente
    '
    Me.cboDocente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cboDocente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboDocente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboDocente.FormattingEnabled = True
    Me.cboDocente.Location = New System.Drawing.Point(722, 14)
    Me.cboDocente.Name = "cboDocente"
    Me.cboDocente.Size = New System.Drawing.Size(226, 24)
    Me.cboDocente.TabIndex = 4
    '
    'txtTotHoras
    '
    Me.txtTotHoras.AutoSize = True
    Me.txtTotHoras.BackColor = System.Drawing.SystemColors.Window
    Me.txtTotHoras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.txtTotHoras.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTotHoras.Location = New System.Drawing.Point(564, 391)
    Me.txtTotHoras.MaximumSize = New System.Drawing.Size(25, 24)
    Me.txtTotHoras.MinimumSize = New System.Drawing.Size(25, 24)
    Me.txtTotHoras.Name = "txtTotHoras"
    Me.txtTotHoras.Size = New System.Drawing.Size(25, 24)
    Me.txtTotHoras.TabIndex = 4
    '
    'lblTotHoras
    '
    Me.lblTotHoras.AutoSize = True
    Me.lblTotHoras.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTotHoras.Location = New System.Drawing.Point(492, 396)
    Me.lblTotHoras.Name = "lblTotHoras"
    Me.lblTotHoras.Size = New System.Drawing.Size(73, 15)
    Me.lblTotHoras.TabIndex = 3
    Me.lblTotHoras.Text = "Total Horas:"
    '
    'btnRetirar
    '
    Me.btnRetirar.Location = New System.Drawing.Point(407, 238)
    Me.btnRetirar.Name = "btnRetirar"
    Me.btnRetirar.Size = New System.Drawing.Size(77, 25)
    Me.btnRetirar.TabIndex = 1
    Me.btnRetirar.Text = "&Quitar"
    Me.btnRetirar.UseVisualStyleBackColor = True
    '
    'btnAsignar
    '
    Me.btnAsignar.Location = New System.Drawing.Point(407, 187)
    Me.btnAsignar.Name = "btnAsignar"
    Me.btnAsignar.Size = New System.Drawing.Size(77, 25)
    Me.btnAsignar.TabIndex = 0
    Me.btnAsignar.Text = "&Asignar ->>"
    Me.btnAsignar.UseVisualStyleBackColor = True
    '
    'cboNivel1
    '
    Me.cboNivel1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNivel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboNivel1.FormattingEnabled = True
    Me.cboNivel1.Location = New System.Drawing.Point(65, 64)
    Me.cboNivel1.Name = "cboNivel1"
    Me.cboNivel1.Size = New System.Drawing.Size(136, 24)
    Me.cboNivel1.TabIndex = 2
    '
    'lblNivel1
    '
    Me.lblNivel1.AutoSize = True
    Me.lblNivel1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNivel1.Location = New System.Drawing.Point(29, 67)
    Me.lblNivel1.Name = "lblNivel1"
    Me.lblNivel1.Size = New System.Drawing.Size(38, 15)
    Me.lblNivel1.TabIndex = 1
    Me.lblNivel1.Text = "&Nivel:"
    '
    'dgCursos
    '
    Me.dgCursos.AllowUserToAddRows = False
    Me.dgCursos.AllowUserToDeleteRows = False
    Me.dgCursos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgCursos.BackgroundColor = System.Drawing.SystemColors.Window
    Me.dgCursos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    DataGridViewCellStyle84.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle84.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle84.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle84.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle84.NullValue = "false"
    DataGridViewCellStyle84.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle84.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle84.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgCursos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle84
    Me.dgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgCursos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdGrado, Me.cdCurso, Me.cdEstado})
    Me.dgCursos.GridColor = System.Drawing.SystemColors.ScrollBar
    Me.dgCursos.Location = New System.Drawing.Point(32, 109)
    Me.dgCursos.MultiSelect = False
    Me.dgCursos.Name = "dgCursos"
    Me.dgCursos.ReadOnly = True
    Me.dgCursos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
    DataGridViewCellStyle88.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle88.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle88.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle88.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle88.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle88.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle88.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgCursos.RowHeadersDefaultCellStyle = DataGridViewCellStyle88
    Me.dgCursos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.dgCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgCursos.Size = New System.Drawing.Size(379, 326)
    Me.dgCursos.TabIndex = 6
    '
    'cdGrado
    '
    DataGridViewCellStyle85.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.cdGrado.DefaultCellStyle = DataGridViewCellStyle85
    Me.cdGrado.HeaderText = "GRADO"
    Me.cdGrado.Name = "cdGrado"
    Me.cdGrado.ReadOnly = True
    Me.cdGrado.Width = 50
    '
    'cdCurso
    '
    DataGridViewCellStyle86.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    Me.cdCurso.DefaultCellStyle = DataGridViewCellStyle86
    Me.cdCurso.HeaderText = "CURSO"
    Me.cdCurso.Name = "cdCurso"
    Me.cdCurso.ReadOnly = True
    Me.cdCurso.Width = 217
    '
    'cdEstado
    '
    DataGridViewCellStyle87.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.cdEstado.DefaultCellStyle = DataGridViewCellStyle87
    Me.cdEstado.HeaderText = "ESTADO"
    Me.cdEstado.Name = "cdEstado"
    Me.cdEstado.ReadOnly = True
    Me.cdEstado.Width = 56
    '
    'lblDocente1
    '
    Me.lblDocente1.AutoSize = True
    Me.lblDocente1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDocente1.Location = New System.Drawing.Point(663, 18)
    Me.lblDocente1.Name = "lblDocente1"
    Me.lblDocente1.Size = New System.Drawing.Size(58, 15)
    Me.lblDocente1.TabIndex = 3
    Me.lblDocente1.Text = "&Docente: "
    '
    'errAsignAcad
    '
    Me.errAsignAcad.ContainerControl = Me
    '
    'gbAsignar
    '
    Me.gbAsignar.Controls.Add(Me.btnQuitar)
    Me.gbAsignar.Controls.Add(Me.lblDocente1)
    Me.gbAsignar.Controls.Add(Me.txtTotHoras)
    Me.gbAsignar.Controls.Add(Me.lblTotHoras)
    Me.gbAsignar.Controls.Add(Me.cboDocente)
    Me.gbAsignar.Controls.Add(Me.dgCursosAsig)
    Me.gbAsignar.Controls.Add(Me.btnRetirar)
    Me.gbAsignar.Controls.Add(Me.btnAsignar)
    Me.gbAsignar.Location = New System.Drawing.Point(15, 17)
    Me.gbAsignar.Name = "gbAsignar"
    Me.gbAsignar.Size = New System.Drawing.Size(970, 436)
    Me.gbAsignar.TabIndex = 0
    Me.gbAsignar.TabStop = False
    '
    'btnBuscar
    '
    Me.btnBuscar.BackColor = System.Drawing.Color.White
    Me.btnBuscar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscar.Location = New System.Drawing.Point(461, 481)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(110, 50)
    Me.btnBuscar.TabIndex = 10
    Me.btnBuscar.Text = "&Buscar"
    Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscar.UseVisualStyleBackColor = False
    '
    'frmAsignacionAcad
    '
    Me.AcceptButton = Me.btnGuardar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(1000, 558)
    Me.Controls.Add(Me.btnBuscar)
    Me.Controls.Add(Me.cboNivel1)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.lblNivel1)
    Me.Controls.Add(Me.dgCursos)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnGuardar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.gbAsignar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmAsignacionAcad"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = " Gestión de carga académica"
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    CType(Me.dgCursosAsig, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dgCursos, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.errAsignAcad, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbAsignar.ResumeLayout(False)
    Me.gbAsignar.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnGuardar As System.Windows.Forms.Button
  Friend WithEvents btnAsignar As System.Windows.Forms.Button
  Friend WithEvents btnRetirar As System.Windows.Forms.Button
  Friend WithEvents dgCursos As System.Windows.Forms.DataGridView
  Friend WithEvents btnQuitar As System.Windows.Forms.Button
  Friend WithEvents cboDocente As System.Windows.Forms.ComboBox
  Friend WithEvents cboNivel1 As System.Windows.Forms.ComboBox
  Friend WithEvents lblNivel1 As System.Windows.Forms.Label
  Friend WithEvents lblEspecialidad As System.Windows.Forms.Label
  Friend WithEvents lblDocente1 As System.Windows.Forms.Label
  Friend WithEvents errAsignAcad As System.Windows.Forms.ErrorProvider
  Friend WithEvents dgCursosAsig As System.Windows.Forms.DataGridView
  Friend WithEvents txtTotHoras As System.Windows.Forms.Label
  Friend WithEvents lblTotHoras As System.Windows.Forms.Label
  Friend WithEvents txtEspecialidad As System.Windows.Forms.Label
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents txthours As System.Windows.Forms.Label
  Friend WithEvents lblHours As System.Windows.Forms.Label
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents cdGrado As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCurso As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdEstado As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents dgGradoAsig As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdHorasAsig As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCursosAsig As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdnivelAsig As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdBlanco As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents gbAsignar As System.Windows.Forms.GroupBox
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class
