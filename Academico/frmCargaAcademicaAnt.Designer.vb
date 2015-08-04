<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaAcademicaAnt
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargaAcademicaAnt))
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.gbAnio = New System.Windows.Forms.GroupBox
    Me.btnListar = New System.Windows.Forms.Button
    Me.txtAnio = New System.Windows.Forms.TextBox
    Me.cboGrado = New System.Windows.Forms.ComboBox
    Me.lblAnioLectivo = New System.Windows.Forms.Label
    Me.lblGrado = New System.Windows.Forms.Label
    Me.gbAsignacion = New System.Windows.Forms.GroupBox
    Me.pnCarga2 = New System.Windows.Forms.Panel
    Me.btnAlumnos = New System.Windows.Forms.Button
    Me.btnQuitar = New System.Windows.Forms.Button
    Me.btnNuevo = New System.Windows.Forms.Button
    Me.dgGrupos = New System.Windows.Forms.DataGridView
    Me.cdPeriodo = New System.Windows.Forms.DataGridViewComboBoxColumn
    Me.cdGrupos = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdDocente = New System.Windows.Forms.DataGridViewComboBoxColumn
    Me.cdBlanco = New System.Windows.Forms.DataGridViewImageColumn
    Me.btnConfigurar = New System.Windows.Forms.Button
    Me.txtNroAlu = New System.Windows.Forms.TextBox
    Me.cdAgregar = New System.Windows.Forms.DataGridViewCheckBoxColumn
    Me.cboSeleccionar = New System.Windows.Forms.ComboBox
    Me.lblNroAlu = New System.Windows.Forms.Label
    Me.cdSexo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.gbSeleccione = New System.Windows.Forms.GroupBox
    Me.dgCursos = New System.Windows.Forms.DataGridView
    Me.cdCurso = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdRotativo = New System.Windows.Forms.DataGridViewCheckBoxColumn
    Me.cdEstado = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.dgAlumnos = New System.Windows.Forms.DataGridView
    Me.gbAlumnos = New System.Windows.Forms.GroupBox
    Me.lblSeleccionar = New System.Windows.Forms.Label
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.gbAnio.SuspendLayout()
    Me.gbAsignacion.SuspendLayout()
    Me.pnCarga2.SuspendLayout()
    CType(Me.dgGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbSeleccione.SuspendLayout()
    CType(Me.dgCursos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dgAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbAlumnos.SuspendLayout()
    Me.SuspendLayout()
    '
    'btnCancelar
    '
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.Location = New System.Drawing.Point(581, 661)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(111, 27)
    Me.btnCancelar.TabIndex = 4
    Me.btnCancelar.Text = "C&ancelar"
    Me.btnCancelar.UseVisualStyleBackColor = True
    Me.btnCancelar.Visible = False
    '
    'gbAnio
    '
    Me.gbAnio.Controls.Add(Me.btnListar)
    Me.gbAnio.Controls.Add(Me.txtAnio)
    Me.gbAnio.Controls.Add(Me.cboGrado)
    Me.gbAnio.Controls.Add(Me.lblAnioLectivo)
    Me.gbAnio.Controls.Add(Me.lblGrado)
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
    Me.txtAnio.Size = New System.Drawing.Size(100, 24)
    Me.txtAnio.TabIndex = 1
    Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'cboGrado
    '
    Me.cboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboGrado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboGrado.FormattingEnabled = True
    Me.cboGrado.Location = New System.Drawing.Point(234, 17)
    Me.cboGrado.Name = "cboGrado"
    Me.cboGrado.Size = New System.Drawing.Size(153, 24)
    Me.cboGrado.TabIndex = 3
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
    'lblGrado
    '
    Me.lblGrado.AutoSize = True
    Me.lblGrado.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblGrado.Location = New System.Drawing.Point(190, 27)
    Me.lblGrado.Name = "lblGrado"
    Me.lblGrado.Size = New System.Drawing.Size(39, 15)
    Me.lblGrado.TabIndex = 2
    Me.lblGrado.Text = "&Grado"
    '
    'gbAsignacion
    '
    Me.gbAsignacion.Controls.Add(Me.pnCarga2)
    Me.gbAsignacion.Controls.Add(Me.btnConfigurar)
    Me.gbAsignacion.Location = New System.Drawing.Point(8, 431)
    Me.gbAsignacion.Name = "gbAsignacion"
    Me.gbAsignacion.Size = New System.Drawing.Size(557, 257)
    Me.gbAsignacion.TabIndex = 2
    Me.gbAsignacion.TabStop = False
    Me.gbAsignacion.Text = "Asignación"
    '
    'pnCarga2
    '
    Me.pnCarga2.BackColor = System.Drawing.Color.LightSkyBlue
    Me.pnCarga2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.pnCarga2.Controls.Add(Me.btnAlumnos)
    Me.pnCarga2.Controls.Add(Me.btnQuitar)
    Me.pnCarga2.Controls.Add(Me.btnNuevo)
    Me.pnCarga2.Controls.Add(Me.dgGrupos)
    Me.pnCarga2.Location = New System.Drawing.Point(6, 19)
    Me.pnCarga2.Name = "pnCarga2"
    Me.pnCarga2.Size = New System.Drawing.Size(545, 189)
    Me.pnCarga2.TabIndex = 0
    '
    'btnAlumnos
    '
    Me.btnAlumnos.BackColor = System.Drawing.Color.White
    Me.btnAlumnos.Location = New System.Drawing.Point(447, 160)
    Me.btnAlumnos.Name = "btnAlumnos"
    Me.btnAlumnos.Size = New System.Drawing.Size(92, 23)
    Me.btnAlumnos.TabIndex = 3
    Me.btnAlumnos.Text = "Al&umnos Grupo"
    Me.btnAlumnos.UseVisualStyleBackColor = False
    '
    'btnQuitar
    '
    Me.btnQuitar.BackColor = System.Drawing.Color.White
    Me.btnQuitar.Location = New System.Drawing.Point(99, 160)
    Me.btnQuitar.Name = "btnQuitar"
    Me.btnQuitar.Size = New System.Drawing.Size(92, 23)
    Me.btnQuitar.TabIndex = 2
    Me.btnQuitar.Text = "Qu&itar"
    Me.btnQuitar.UseVisualStyleBackColor = False
    '
    'btnNuevo
    '
    Me.btnNuevo.BackColor = System.Drawing.Color.White
    Me.btnNuevo.Location = New System.Drawing.Point(3, 160)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(92, 23)
    Me.btnNuevo.TabIndex = 1
    Me.btnNuevo.Text = "Nu&evo"
    Me.btnNuevo.UseVisualStyleBackColor = False
    '
    'dgGrupos
    '
    Me.dgGrupos.AllowUserToAddRows = False
    Me.dgGrupos.AllowUserToDeleteRows = False
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgGrupos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgGrupos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdPeriodo, Me.cdGrupos, Me.cdDocente, Me.cdBlanco})
    Me.dgGrupos.Location = New System.Drawing.Point(4, 3)
    Me.dgGrupos.MultiSelect = False
    Me.dgGrupos.Name = "dgGrupos"
    Me.dgGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgGrupos.Size = New System.Drawing.Size(535, 151)
    Me.dgGrupos.TabIndex = 0
    '
    'cdPeriodo
    '
    Me.cdPeriodo.HeaderText = "Periodo"
    Me.cdPeriodo.Name = "cdPeriodo"
    Me.cdPeriodo.Width = 65
    '
    'cdGrupos
    '
    Me.cdGrupos.HeaderText = "Grupo"
    Me.cdGrupos.Name = "cdGrupos"
    Me.cdGrupos.Width = 135
    '
    'cdDocente
    '
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
    Me.btnConfigurar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnConfigurar.Location = New System.Drawing.Point(440, 223)
    Me.btnConfigurar.Name = "btnConfigurar"
    Me.btnConfigurar.Size = New System.Drawing.Size(111, 27)
    Me.btnConfigurar.TabIndex = 1
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
    'cdAgregar
    '
    Me.cdAgregar.HeaderText = "Agregar"
    Me.cdAgregar.Name = "cdAgregar"
    Me.cdAgregar.Width = 50
    '
    'cboSeleccionar
    '
    Me.cboSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cboSeleccionar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeleccionar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboSeleccionar.FormattingEnabled = True
    Me.cboSeleccionar.Items.AddRange(New Object() {"-------------------------------", "Mismo Sexo", "Todos", "Ninguno"})
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
    'cdSexo
    '
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.cdSexo.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdSexo.HeaderText = "Sexo"
    Me.cdSexo.Name = "cdSexo"
    Me.cdSexo.ReadOnly = True
    Me.cdSexo.Width = 33
    '
    'cdAlumno
    '
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cdAlumno.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.ReadOnly = True
    Me.cdAlumno.Width = 270
    '
    'gbSeleccione
    '
    Me.gbSeleccione.Controls.Add(Me.dgCursos)
    Me.gbSeleccione.Location = New System.Drawing.Point(8, 67)
    Me.gbSeleccione.Name = "gbSeleccione"
    Me.gbSeleccione.Size = New System.Drawing.Size(557, 358)
    Me.gbSeleccione.TabIndex = 1
    Me.gbSeleccione.TabStop = False
    '
    'dgCursos
    '
    Me.dgCursos.AllowUserToAddRows = False
    Me.dgCursos.AllowUserToDeleteRows = False
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgCursos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.dgCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgCursos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdCurso, Me.cdGrupo, Me.cdRotativo, Me.cdEstado})
    Me.dgCursos.Location = New System.Drawing.Point(6, 16)
    Me.dgCursos.MultiSelect = False
    Me.dgCursos.Name = "dgCursos"
    Me.dgCursos.ReadOnly = True
    Me.dgCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgCursos.Size = New System.Drawing.Size(544, 334)
    Me.dgCursos.TabIndex = 0
    '
    'cdCurso
    '
    Me.cdCurso.HeaderText = "Curso"
    Me.cdCurso.Name = "cdCurso"
    Me.cdCurso.ReadOnly = True
    Me.cdCurso.Width = 240
    '
    'cdGrupo
    '
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.cdGrupo.DefaultCellStyle = DataGridViewCellStyle5
    Me.cdGrupo.HeaderText = "Grupos"
    Me.cdGrupo.Name = "cdGrupo"
    Me.cdGrupo.ReadOnly = True
    Me.cdGrupo.Width = 80
    '
    'cdRotativo
    '
    Me.cdRotativo.HeaderText = "Rotativo"
    Me.cdRotativo.Name = "cdRotativo"
    Me.cdRotativo.ReadOnly = True
    Me.cdRotativo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.cdRotativo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.cdRotativo.Width = 60
    '
    'cdEstado
    '
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.cdEstado.DefaultCellStyle = DataGridViewCellStyle6
    Me.cdEstado.HeaderText = "Estado"
    Me.cdEstado.Name = "cdEstado"
    Me.cdEstado.ReadOnly = True
    Me.cdEstado.Width = 80
    '
    'dgAlumnos
    '
    Me.dgAlumnos.AllowUserToAddRows = False
    Me.dgAlumnos.AllowUserToDeleteRows = False
    Me.dgAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgAlumnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
    Me.dgAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdAlumno, Me.cdSexo, Me.cdAgregar})
    Me.dgAlumnos.Location = New System.Drawing.Point(8, 45)
    Me.dgAlumnos.Name = "dgAlumnos"
    Me.dgAlumnos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.dgAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgAlumnos.Size = New System.Drawing.Size(409, 594)
    Me.dgAlumnos.TabIndex = 4
    '
    'gbAlumnos
    '
    Me.gbAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbAlumnos.Controls.Add(Me.txtNroAlu)
    Me.gbAlumnos.Controls.Add(Me.cboSeleccionar)
    Me.gbAlumnos.Controls.Add(Me.lblNroAlu)
    Me.gbAlumnos.Controls.Add(Me.dgAlumnos)
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
    'frmCargaAcademica
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1007, 700)
    Me.Controls.Add(Me.btnCancelar)
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
    CType(Me.dgGrupos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbSeleccione.ResumeLayout(False)
    CType(Me.dgCursos, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dgAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbAlumnos.ResumeLayout(False)
    Me.gbAlumnos.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents gbAnio As System.Windows.Forms.GroupBox
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents txtAnio As System.Windows.Forms.TextBox
  Friend WithEvents cboGrado As System.Windows.Forms.ComboBox
  Friend WithEvents lblAnioLectivo As System.Windows.Forms.Label
  Friend WithEvents lblGrado As System.Windows.Forms.Label
  Friend WithEvents gbAsignacion As System.Windows.Forms.GroupBox
  Friend WithEvents pnCarga2 As System.Windows.Forms.Panel
  Friend WithEvents btnAlumnos As System.Windows.Forms.Button
  Friend WithEvents btnQuitar As System.Windows.Forms.Button
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents dgGrupos As System.Windows.Forms.DataGridView
  Friend WithEvents btnConfigurar As System.Windows.Forms.Button
  Friend WithEvents txtNroAlu As System.Windows.Forms.TextBox
  Friend WithEvents cdAgregar As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents cboSeleccionar As System.Windows.Forms.ComboBox
  Friend WithEvents lblNroAlu As System.Windows.Forms.Label
  Friend WithEvents cdSexo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents gbSeleccione As System.Windows.Forms.GroupBox
  Friend WithEvents dgCursos As System.Windows.Forms.DataGridView
  Friend WithEvents cdCurso As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdGrupo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdRotativo As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents cdEstado As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents dgAlumnos As System.Windows.Forms.DataGridView
  Friend WithEvents gbAlumnos As System.Windows.Forms.GroupBox
  Friend WithEvents lblSeleccionar As System.Windows.Forms.Label
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents cdPeriodo As System.Windows.Forms.DataGridViewComboBoxColumn
  Friend WithEvents cdGrupos As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDocente As System.Windows.Forms.DataGridViewComboBoxColumn
  Friend WithEvents cdBlanco As System.Windows.Forms.DataGridViewImageColumn
End Class
