<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaAcademica
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargaAcademica))
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.gbAnio = New System.Windows.Forms.GroupBox()
    Me.btnListar = New System.Windows.Forms.Button()
    Me.txtAnio = New System.Windows.Forms.TextBox()
    Me.cboSeccion = New System.Windows.Forms.ComboBox()
    Me.lblAnioLectivo = New System.Windows.Forms.Label()
    Me.lblSeccion = New System.Windows.Forms.Label()
    Me.gbAsignacion = New System.Windows.Forms.GroupBox()
    Me.pnCarga2 = New System.Windows.Forms.Panel()
    Me.btnAlumnos = New System.Windows.Forms.Button()
    Me.btnQuitar = New System.Windows.Forms.Button()
    Me.btnNuevo = New System.Windows.Forms.Button()
    Me.dgvGrupos = New System.Windows.Forms.DataGridView()
    Me.cdPeriodo = New System.Windows.Forms.DataGridViewComboBoxColumn()
    Me.cdGrupos = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdDocente = New System.Windows.Forms.DataGridViewComboBoxColumn()
    Me.cdBlanco = New System.Windows.Forms.DataGridViewImageColumn()
    Me.btnConfigurar = New System.Windows.Forms.Button()
    Me.txtNroAlu = New System.Windows.Forms.TextBox()
    Me.cboSeleccionar = New System.Windows.Forms.ComboBox()
    Me.lblNroAlu = New System.Windows.Forms.Label()
    Me.gbSeleccione = New System.Windows.Forms.GroupBox()
    Me.dgvCargas = New System.Windows.Forms.DataGridView()
    Me.cdCurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdGrupo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.cdRotativo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.cdEstado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.cdVerAsignacion = New System.Windows.Forms.DataGridViewButtonColumn()
    Me.dgvAlumnos = New System.Windows.Forms.DataGridView()
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdSexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdAgregar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.gbAlumnos = New System.Windows.Forms.GroupBox()
    Me.lblSeleccionar = New System.Windows.Forms.Label()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.btnActualizar = New System.Windows.Forms.Button()
    Me.gbAnio.SuspendLayout()
    Me.gbAsignacion.SuspendLayout()
    Me.pnCarga2.SuspendLayout()
    CType(Me.dgvGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbSeleccione.SuspendLayout()
    CType(Me.dgvCargas, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbAlumnos.SuspendLayout()
    Me.SuspendLayout()
    '
    'gbAnio
    '
    Me.gbAnio.Controls.Add(Me.btnListar)
    Me.gbAnio.Controls.Add(Me.txtAnio)
    Me.gbAnio.Controls.Add(Me.cboSeccion)
    Me.gbAnio.Controls.Add(Me.lblAnioLectivo)
    Me.gbAnio.Controls.Add(Me.lblSeccion)
    Me.gbAnio.Location = New System.Drawing.Point(8, 7)
    Me.gbAnio.Name = "gbAnio"
    Me.gbAnio.Size = New System.Drawing.Size(557, 54)
    Me.gbAnio.TabIndex = 0
    Me.gbAnio.TabStop = False
    '
    'btnListar
    '
    Me.btnListar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnListar.Location = New System.Drawing.Point(423, 17)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(111, 27)
    Me.btnListar.TabIndex = 4
    Me.btnListar.Text = "&Listar"
    Me.btnListar.UseVisualStyleBackColor = True
    '
    'txtAnio
    '
    Me.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAnio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAnio.Location = New System.Drawing.Point(59, 17)
    Me.txtAnio.Multiline = True
    Me.txtAnio.Name = "txtAnio"
    Me.txtAnio.ReadOnly = True
    Me.txtAnio.Size = New System.Drawing.Size(80, 24)
    Me.txtAnio.TabIndex = 1
    Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'cboSeccion
    '
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(234, 16)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(153, 24)
    Me.cboSeccion.TabIndex = 3
    '
    'lblAnioLectivo
    '
    Me.lblAnioLectivo.AutoSize = True
    Me.lblAnioLectivo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAnioLectivo.Location = New System.Drawing.Point(23, 26)
    Me.lblAnioLectivo.Name = "lblAnioLectivo"
    Me.lblAnioLectivo.Size = New System.Drawing.Size(31, 15)
    Me.lblAnioLectivo.TabIndex = 0
    Me.lblAnioLectivo.Text = "&Año"
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSeccion.Location = New System.Drawing.Point(179, 26)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(49, 15)
    Me.lblSeccion.TabIndex = 2
    Me.lblSeccion.Text = "&Sección"
    '
    'gbAsignacion
    '
    Me.gbAsignacion.Controls.Add(Me.pnCarga2)
    Me.gbAsignacion.Location = New System.Drawing.Point(8, 457)
    Me.gbAsignacion.Name = "gbAsignacion"
    Me.gbAsignacion.Size = New System.Drawing.Size(557, 231)
    Me.gbAsignacion.TabIndex = 2
    Me.gbAsignacion.TabStop = False
    Me.gbAsignacion.Text = "Asignación"
    '
    'pnCarga2
    '
    Me.pnCarga2.BackColor = System.Drawing.Color.LightSkyBlue
    Me.pnCarga2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.pnCarga2.Controls.Add(Me.btnActualizar)
    Me.pnCarga2.Controls.Add(Me.btnAlumnos)
    Me.pnCarga2.Controls.Add(Me.btnQuitar)
    Me.pnCarga2.Controls.Add(Me.btnNuevo)
    Me.pnCarga2.Controls.Add(Me.dgvGrupos)
    Me.pnCarga2.Location = New System.Drawing.Point(6, 19)
    Me.pnCarga2.Name = "pnCarga2"
    Me.pnCarga2.Size = New System.Drawing.Size(545, 204)
    Me.pnCarga2.TabIndex = 0
    '
    'btnAlumnos
    '
    Me.btnAlumnos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnAlumnos.BackColor = System.Drawing.Color.White
    Me.btnAlumnos.Location = New System.Drawing.Point(447, 175)
    Me.btnAlumnos.Name = "btnAlumnos"
    Me.btnAlumnos.Size = New System.Drawing.Size(92, 23)
    Me.btnAlumnos.TabIndex = 3
    Me.btnAlumnos.Text = "&Ver alumnos"
    Me.btnAlumnos.UseVisualStyleBackColor = False
    '
    'btnQuitar
    '
    Me.btnQuitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnQuitar.BackColor = System.Drawing.Color.White
    Me.btnQuitar.Location = New System.Drawing.Point(99, 175)
    Me.btnQuitar.Name = "btnQuitar"
    Me.btnQuitar.Size = New System.Drawing.Size(92, 23)
    Me.btnQuitar.TabIndex = 2
    Me.btnQuitar.Text = "Qu&itar"
    Me.btnQuitar.UseVisualStyleBackColor = False
    '
    'btnNuevo
    '
    Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnNuevo.BackColor = System.Drawing.Color.White
    Me.btnNuevo.Location = New System.Drawing.Point(3, 175)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(92, 23)
    Me.btnNuevo.TabIndex = 1
    Me.btnNuevo.Text = "Nu&evo"
    Me.btnNuevo.UseVisualStyleBackColor = False
    '
    'dgvGrupos
    '
    Me.dgvGrupos.AllowUserToAddRows = False
    Me.dgvGrupos.AllowUserToDeleteRows = False
    Me.dgvGrupos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvGrupos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvGrupos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdPeriodo, Me.cdGrupos, Me.cdDocente, Me.cdBlanco})
    Me.dgvGrupos.Location = New System.Drawing.Point(3, 4)
    Me.dgvGrupos.MultiSelect = False
    Me.dgvGrupos.Name = "dgvGrupos"
    Me.dgvGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvGrupos.Size = New System.Drawing.Size(535, 166)
    Me.dgvGrupos.TabIndex = 0
    '
    'cdPeriodo
    '
    Me.cdPeriodo.DataPropertyName = "CodigoPeriodo"
    Me.cdPeriodo.HeaderText = "Periodo"
    Me.cdPeriodo.Name = "cdPeriodo"
    Me.cdPeriodo.Width = 65
    '
    'cdGrupos
    '
    Me.cdGrupos.DataPropertyName = "Nombre"
    Me.cdGrupos.HeaderText = "Grupo"
    Me.cdGrupos.Name = "cdGrupos"
    Me.cdGrupos.Width = 135
    '
    'cdDocente
    '
    Me.cdDocente.DataPropertyName = "CodigoDocente"
    Me.cdDocente.HeaderText = "Docente"
    Me.cdDocente.Name = "cdDocente"
    Me.cdDocente.Width = 240
    '
    'cdBlanco
    '
    Me.cdBlanco.HeaderText = ""
    Me.cdBlanco.Image = CType(resources.GetObject("cdBlanco.Image"), System.Drawing.Image)
    Me.cdBlanco.Name = "cdBlanco"
    Me.cdBlanco.Width = 40
    '
    'btnConfigurar
    '
    Me.btnConfigurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnConfigurar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnConfigurar.Location = New System.Drawing.Point(6, 614)
    Me.btnConfigurar.Name = "btnConfigurar"
    Me.btnConfigurar.Size = New System.Drawing.Size(111, 27)
    Me.btnConfigurar.TabIndex = 5
    Me.btnConfigurar.Text = "C&onfigurar"
    Me.btnConfigurar.UseVisualStyleBackColor = True
    '
    'txtNroAlu
    '
    Me.txtNroAlu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtNroAlu.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNroAlu.Location = New System.Drawing.Point(135, 19)
    Me.txtNroAlu.Multiline = True
    Me.txtNroAlu.Name = "txtNroAlu"
    Me.txtNroAlu.ReadOnly = True
    Me.txtNroAlu.Size = New System.Drawing.Size(36, 22)
    Me.txtNroAlu.TabIndex = 1
    '
    'cboSeleccionar
    '
    Me.cboSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cboSeleccionar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeleccionar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboSeleccionar.FormattingEnabled = True
    Me.cboSeleccionar.Items.AddRange(New Object() {"-------------------------------", "Ninguno", "Mismo sexo", "Todos"})
    Me.cboSeleccionar.Location = New System.Drawing.Point(262, 17)
    Me.cboSeleccionar.Name = "cboSeleccionar"
    Me.cboSeleccionar.Size = New System.Drawing.Size(155, 24)
    Me.cboSeleccionar.TabIndex = 3
    '
    'lblNroAlu
    '
    Me.lblNroAlu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblNroAlu.AutoSize = True
    Me.lblNroAlu.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNroAlu.Location = New System.Drawing.Point(98, 23)
    Me.lblNroAlu.Name = "lblNroAlu"
    Me.lblNroAlu.Size = New System.Drawing.Size(34, 15)
    Me.lblNroAlu.TabIndex = 0
    Me.lblNroAlu.Text = "Total"
    '
    'gbSeleccione
    '
    Me.gbSeleccione.Controls.Add(Me.dgvCargas)
    Me.gbSeleccione.Location = New System.Drawing.Point(8, 67)
    Me.gbSeleccione.Name = "gbSeleccione"
    Me.gbSeleccione.Size = New System.Drawing.Size(557, 384)
    Me.gbSeleccione.TabIndex = 1
    Me.gbSeleccione.TabStop = False
    '
    'dgvCargas
    '
    Me.dgvCargas.AllowUserToAddRows = False
    Me.dgvCargas.AllowUserToDeleteRows = False
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvCargas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
    Me.dgvCargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvCargas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdCurso, Me.cdGrupo, Me.cdRotativo, Me.cdEstado, Me.cdVerAsignacion})
    Me.dgvCargas.Location = New System.Drawing.Point(6, 18)
    Me.dgvCargas.MultiSelect = False
    Me.dgvCargas.Name = "dgvCargas"
    Me.dgvCargas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvCargas.Size = New System.Drawing.Size(544, 360)
    Me.dgvCargas.TabIndex = 0
    '
    'cdCurso
    '
    Me.cdCurso.DataPropertyName = "CursoNombre"
    Me.cdCurso.HeaderText = "Curso"
    Me.cdCurso.Name = "cdCurso"
    Me.cdCurso.ReadOnly = True
    Me.cdCurso.Width = 220
    '
    'cdGrupo
    '
    Me.cdGrupo.DataPropertyName = "CursoGrupo"
    Me.cdGrupo.HeaderText = "Grupos"
    Me.cdGrupo.Name = "cdGrupo"
    Me.cdGrupo.ReadOnly = True
    Me.cdGrupo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.cdGrupo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.cdGrupo.Width = 60
    '
    'cdRotativo
    '
    Me.cdRotativo.DataPropertyName = "CursoRotativo"
    Me.cdRotativo.HeaderText = "Rotativo"
    Me.cdRotativo.Name = "cdRotativo"
    Me.cdRotativo.ReadOnly = True
    Me.cdRotativo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.cdRotativo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.cdRotativo.Width = 60
    '
    'cdEstado
    '
    Me.cdEstado.DataPropertyName = "Asignado"
    Me.cdEstado.HeaderText = "Asignado"
    Me.cdEstado.Name = "cdEstado"
    Me.cdEstado.ReadOnly = True
    Me.cdEstado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.cdEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.cdEstado.Width = 60
    '
    'cdVerAsignacion
    '
    Me.cdVerAsignacion.HeaderText = "Ver"
    Me.cdVerAsignacion.Name = "cdVerAsignacion"
    Me.cdVerAsignacion.Text = "..."
    Me.cdVerAsignacion.UseColumnTextForButtonValue = True
    Me.cdVerAsignacion.Width = 50
    '
    'dgvAlumnos
    '
    Me.dgvAlumnos.AllowUserToAddRows = False
    Me.dgvAlumnos.AllowUserToDeleteRows = False
    Me.dgvAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvAlumnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdAlumno, Me.cdSexo, Me.cdAgregar})
    Me.dgvAlumnos.Location = New System.Drawing.Point(8, 45)
    Me.dgvAlumnos.Name = "dgvAlumnos"
    Me.dgvAlumnos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvAlumnos.Size = New System.Drawing.Size(409, 563)
    Me.dgvAlumnos.TabIndex = 4
    '
    'cdAlumno
    '
    Me.cdAlumno.DataPropertyName = "NombreAlumno"
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cdAlumno.DefaultCellStyle = DataGridViewCellStyle4
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.ReadOnly = True
    Me.cdAlumno.Width = 270
    '
    'cdSexo
    '
    Me.cdSexo.DataPropertyName = "SexoAlumno"
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.cdSexo.DefaultCellStyle = DataGridViewCellStyle5
    Me.cdSexo.HeaderText = "Sexo"
    Me.cdSexo.Name = "cdSexo"
    Me.cdSexo.ReadOnly = True
    Me.cdSexo.Width = 33
    '
    'cdAgregar
    '
    Me.cdAgregar.DataPropertyName = "Asignado"
    Me.cdAgregar.HeaderText = "Agregar"
    Me.cdAgregar.Name = "cdAgregar"
    Me.cdAgregar.Width = 50
    '
    'gbAlumnos
    '
    Me.gbAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbAlumnos.Controls.Add(Me.txtNroAlu)
    Me.gbAlumnos.Controls.Add(Me.btnConfigurar)
    Me.gbAlumnos.Controls.Add(Me.cboSeleccionar)
    Me.gbAlumnos.Controls.Add(Me.lblNroAlu)
    Me.gbAlumnos.Controls.Add(Me.dgvAlumnos)
    Me.gbAlumnos.Controls.Add(Me.lblSeleccionar)
    Me.gbAlumnos.Location = New System.Drawing.Point(573, 7)
    Me.gbAlumnos.Name = "gbAlumnos"
    Me.gbAlumnos.Size = New System.Drawing.Size(425, 647)
    Me.gbAlumnos.TabIndex = 3
    Me.gbAlumnos.TabStop = False
    Me.gbAlumnos.Text = "Alumnos"
    '
    'lblSeleccionar
    '
    Me.lblSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblSeleccionar.AutoSize = True
    Me.lblSeleccionar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSeleccionar.Location = New System.Drawing.Point(192, 22)
    Me.lblSeleccionar.Name = "lblSeleccionar"
    Me.lblSeleccionar.Size = New System.Drawing.Size(68, 15)
    Me.lblSeleccionar.TabIndex = 2
    Me.lblSeleccionar.Text = "&Seleccionar"
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.Location = New System.Drawing.Point(887, 666)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(111, 27)
    Me.btnCerrar.TabIndex = 5
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.UseVisualStyleBackColor = True
    '
    'btnActualizar
    '
    Me.btnActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnActualizar.BackColor = System.Drawing.Color.White
    Me.btnActualizar.Location = New System.Drawing.Point(349, 175)
    Me.btnActualizar.Name = "btnActualizar"
    Me.btnActualizar.Size = New System.Drawing.Size(92, 23)
    Me.btnActualizar.TabIndex = 4
    Me.btnActualizar.Text = "Actualizar"
    Me.btnActualizar.UseVisualStyleBackColor = False
    '
    'frmCargaAcademica
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1007, 700)
    Me.Controls.Add(Me.gbAnio)
    Me.Controls.Add(Me.gbAsignacion)
    Me.Controls.Add(Me.gbSeleccione)
    Me.Controls.Add(Me.gbAlumnos)
    Me.Controls.Add(Me.btnCerrar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Name = "frmCargaAcademica"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de la Carga Académica"
    Me.gbAnio.ResumeLayout(False)
    Me.gbAnio.PerformLayout()
    Me.gbAsignacion.ResumeLayout(False)
    Me.pnCarga2.ResumeLayout(False)
    CType(Me.dgvGrupos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbSeleccione.ResumeLayout(False)
    CType(Me.dgvCargas, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbAlumnos.ResumeLayout(False)
    Me.gbAlumnos.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents gbAnio As System.Windows.Forms.GroupBox
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents txtAnio As System.Windows.Forms.TextBox
  Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents lblAnioLectivo As System.Windows.Forms.Label
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents gbAsignacion As System.Windows.Forms.GroupBox
  Friend WithEvents pnCarga2 As System.Windows.Forms.Panel
  Friend WithEvents btnAlumnos As System.Windows.Forms.Button
  Friend WithEvents btnQuitar As System.Windows.Forms.Button
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents dgvGrupos As System.Windows.Forms.DataGridView
  Friend WithEvents btnConfigurar As System.Windows.Forms.Button
  Friend WithEvents txtNroAlu As System.Windows.Forms.TextBox
  Friend WithEvents cboSeleccionar As System.Windows.Forms.ComboBox
  Friend WithEvents lblNroAlu As System.Windows.Forms.Label
  Friend WithEvents gbSeleccione As System.Windows.Forms.GroupBox
  Friend WithEvents dgvCargas As System.Windows.Forms.DataGridView
  Friend WithEvents dgvAlumnos As System.Windows.Forms.DataGridView
  Friend WithEvents gbAlumnos As System.Windows.Forms.GroupBox
  Friend WithEvents lblSeleccionar As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents cdPeriodo As System.Windows.Forms.DataGridViewComboBoxColumn
  Friend WithEvents cdGrupos As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDocente As System.Windows.Forms.DataGridViewComboBoxColumn
  Friend WithEvents cdBlanco As System.Windows.Forms.DataGridViewImageColumn
  Friend WithEvents cdCurso As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdGrupo As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents cdRotativo As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents cdEstado As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents cdVerAsignacion As System.Windows.Forms.DataGridViewButtonColumn
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdSexo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAgregar As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents btnActualizar As System.Windows.Forms.Button
End Class
