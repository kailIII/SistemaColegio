<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionProgLecturaAnt
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
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionProgLecturaAnt))
    Me.cboSeccion = New System.Windows.Forms.ComboBox
    Me.txtAnio = New System.Windows.Forms.TextBox
    Me.lblSeccion = New System.Windows.Forms.Label
    Me.lblAnio = New System.Windows.Forms.Label
    Me.GBAlumnos = New System.Windows.Forms.GroupBox
    Me.cboSeleccionar = New System.Windows.Forms.ComboBox
    Me.txtTotal = New System.Windows.Forms.TextBox
    Me.lblSeleccionar = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.dgvAlumnos = New System.Windows.Forms.DataGridView
    Me.GBLista = New System.Windows.Forms.GroupBox
    Me.dgvPresentacion = New System.Windows.Forms.DataGridView
    Me.cdNroPres = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdInicio = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdFin = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdAnio = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCodigoPres = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.GBSeccion = New System.Windows.Forms.GroupBox
    Me.GBGrupo = New System.Windows.Forms.GroupBox
    Me.btnQuitar = New System.Windows.Forms.Button
    Me.btnAlumnos = New System.Windows.Forms.Button
    Me.btnNuevo = New System.Windows.Forms.Button
    Me.dgvGrupoLibro = New System.Windows.Forms.DataGridView
    Me.cdGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdLibro = New System.Windows.Forms.DataGridViewComboBoxColumn
    Me.cdImg = New System.Windows.Forms.DataGridViewImageColumn
    Me.cdCodigoLibro = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCodPre = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdNroGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdNro = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdSexo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdAgregar = New System.Windows.Forms.DataGridViewCheckBoxColumn
    Me.cdAsig = New System.Windows.Forms.DataGridViewImageColumn
    Me.cdCodigoPL = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.GBAlumnos.SuspendLayout()
    CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GBLista.SuspendLayout()
    CType(Me.dgvPresentacion, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GBSeccion.SuspendLayout()
    Me.GBGrupo.SuspendLayout()
    CType(Me.dgvGrupoLibro, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cboSeccion
    '
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(73, 51)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(223, 25)
    Me.cboSeccion.TabIndex = 3
    '
    'txtAnio
    '
    Me.txtAnio.BackColor = System.Drawing.Color.White
    Me.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.txtAnio.Location = New System.Drawing.Point(74, 16)
    Me.txtAnio.Name = "txtAnio"
    Me.txtAnio.ReadOnly = True
    Me.txtAnio.Size = New System.Drawing.Size(100, 25)
    Me.txtAnio.TabIndex = 1
    Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblSeccion.Location = New System.Drawing.Point(11, 54)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(54, 17)
    Me.lblSeccion.TabIndex = 2
    Me.lblSeccion.Text = "&Sección"
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
    'GBAlumnos
    '
    Me.GBAlumnos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.GBAlumnos.Controls.Add(Me.cboSeleccionar)
    Me.GBAlumnos.Controls.Add(Me.txtTotal)
    Me.GBAlumnos.Controls.Add(Me.lblSeleccionar)
    Me.GBAlumnos.Controls.Add(Me.Label1)
    Me.GBAlumnos.Controls.Add(Me.dgvAlumnos)
    Me.GBAlumnos.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GBAlumnos.Location = New System.Drawing.Point(459, 2)
    Me.GBAlumnos.Name = "GBAlumnos"
    Me.GBAlumnos.Size = New System.Drawing.Size(498, 634)
    Me.GBAlumnos.TabIndex = 3
    Me.GBAlumnos.TabStop = False
    Me.GBAlumnos.Text = "Lista de Alumnos"
    '
    'cboSeleccionar
    '
    Me.cboSeleccionar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeleccionar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboSeleccionar.FormattingEnabled = True
    Me.cboSeleccionar.Items.AddRange(New Object() {"-------------------------------", "Mismo Sexo", "Todos", "Ninguno"})
    Me.cboSeleccionar.Location = New System.Drawing.Point(333, 19)
    Me.cboSeleccionar.Name = "cboSeleccionar"
    Me.cboSeleccionar.Size = New System.Drawing.Size(155, 24)
    Me.cboSeleccionar.TabIndex = 1
    '
    'txtTotal
    '
    Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.txtTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTotal.Location = New System.Drawing.Point(57, 21)
    Me.txtTotal.Multiline = True
    Me.txtTotal.Name = "txtTotal"
    Me.txtTotal.ReadOnly = True
    Me.txtTotal.Size = New System.Drawing.Size(34, 24)
    Me.txtTotal.TabIndex = 4
    '
    'lblSeleccionar
    '
    Me.lblSeleccionar.AutoSize = True
    Me.lblSeleccionar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSeleccionar.Location = New System.Drawing.Point(259, 23)
    Me.lblSeleccionar.Name = "lblSeleccionar"
    Me.lblSeleccionar.Size = New System.Drawing.Size(68, 15)
    Me.lblSeleccionar.TabIndex = 0
    Me.lblSeleccionar.Text = "&Seleccionar"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(7, 25)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(44, 15)
    Me.Label1.TabIndex = 3
    Me.Label1.Text = "Total : "
    '
    'dgvAlumnos
    '
    Me.dgvAlumnos.AllowUserToAddRows = False
    Me.dgvAlumnos.AllowUserToDeleteRows = False
    Me.dgvAlumnos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNro, Me.cdAlumno, Me.cdSexo, Me.cdAgregar, Me.cdAsig, Me.cdCodigoPL})
    Me.dgvAlumnos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
    Me.dgvAlumnos.Location = New System.Drawing.Point(6, 49)
    Me.dgvAlumnos.MultiSelect = False
    Me.dgvAlumnos.Name = "dgvAlumnos"
    Me.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvAlumnos.Size = New System.Drawing.Size(482, 579)
    Me.dgvAlumnos.TabIndex = 2
    '
    'GBLista
    '
    Me.GBLista.Controls.Add(Me.dgvPresentacion)
    Me.GBLista.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.GBLista.Location = New System.Drawing.Point(3, 89)
    Me.GBLista.Name = "GBLista"
    Me.GBLista.Size = New System.Drawing.Size(448, 324)
    Me.GBLista.TabIndex = 1
    Me.GBLista.TabStop = False
    Me.GBLista.Text = "Lista de Presentaciones"
    '
    'dgvPresentacion
    '
    Me.dgvPresentacion.AllowUserToAddRows = False
    Me.dgvPresentacion.AllowUserToDeleteRows = False
    Me.dgvPresentacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvPresentacion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
    Me.dgvPresentacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvPresentacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNroPres, Me.cdInicio, Me.cdFin, Me.cdAnio, Me.cdCodigoPres})
    Me.dgvPresentacion.Location = New System.Drawing.Point(6, 20)
    Me.dgvPresentacion.MultiSelect = False
    Me.dgvPresentacion.Name = "dgvPresentacion"
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.GreenYellow
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
    Me.dgvPresentacion.RowsDefaultCellStyle = DataGridViewCellStyle6
    Me.dgvPresentacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvPresentacion.Size = New System.Drawing.Size(436, 298)
    Me.dgvPresentacion.TabIndex = 0
    '
    'cdNroPres
    '
    Me.cdNroPres.DataPropertyName = "Nro"
    Me.cdNroPres.HeaderText = "Nro"
    Me.cdNroPres.Name = "cdNroPres"
    Me.cdNroPres.ReadOnly = True
    Me.cdNroPres.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    Me.cdNroPres.Width = 30
    '
    'cdInicio
    '
    Me.cdInicio.DataPropertyName = "Inicio"
    DataGridViewCellStyle3.Format = "d"
    DataGridViewCellStyle3.NullValue = Nothing
    Me.cdInicio.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdInicio.HeaderText = "Fecha Inicio"
    Me.cdInicio.Name = "cdInicio"
    Me.cdInicio.ReadOnly = True
    Me.cdInicio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    Me.cdInicio.Width = 130
    '
    'cdFin
    '
    Me.cdFin.DataPropertyName = "Fin"
    DataGridViewCellStyle4.Format = "d"
    Me.cdFin.DefaultCellStyle = DataGridViewCellStyle4
    Me.cdFin.HeaderText = "Fecha Fin"
    Me.cdFin.Name = "cdFin"
    Me.cdFin.ReadOnly = True
    Me.cdFin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    Me.cdFin.Width = 130
    '
    'cdAnio
    '
    Me.cdAnio.DataPropertyName = "Anio"
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.cdAnio.DefaultCellStyle = DataGridViewCellStyle5
    Me.cdAnio.HeaderText = "Año"
    Me.cdAnio.Name = "cdAnio"
    Me.cdAnio.ReadOnly = True
    '
    'cdCodigoPres
    '
    Me.cdCodigoPres.DataPropertyName = "Codigo"
    Me.cdCodigoPres.HeaderText = ""
    Me.cdCodigoPres.Name = "cdCodigoPres"
    Me.cdCodigoPres.Visible = False
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(842, 642)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 6
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Enabled = False
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(341, 642)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
    Me.btnRegistrar.TabIndex = 4
    Me.btnRegistrar.Text = "&Asignar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'GBSeccion
    '
    Me.GBSeccion.Controls.Add(Me.lblAnio)
    Me.GBSeccion.Controls.Add(Me.lblSeccion)
    Me.GBSeccion.Controls.Add(Me.txtAnio)
    Me.GBSeccion.Controls.Add(Me.cboSeccion)
    Me.GBSeccion.Location = New System.Drawing.Point(3, 2)
    Me.GBSeccion.Name = "GBSeccion"
    Me.GBSeccion.Size = New System.Drawing.Size(448, 86)
    Me.GBSeccion.TabIndex = 0
    Me.GBSeccion.TabStop = False
    '
    'GBGrupo
    '
    Me.GBGrupo.Controls.Add(Me.btnQuitar)
    Me.GBGrupo.Controls.Add(Me.btnAlumnos)
    Me.GBGrupo.Controls.Add(Me.btnNuevo)
    Me.GBGrupo.Controls.Add(Me.dgvGrupoLibro)
    Me.GBGrupo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GBGrupo.Location = New System.Drawing.Point(3, 419)
    Me.GBGrupo.Name = "GBGrupo"
    Me.GBGrupo.Size = New System.Drawing.Size(448, 217)
    Me.GBGrupo.TabIndex = 2
    Me.GBGrupo.TabStop = False
    Me.GBGrupo.Text = "Grupos"
    '
    'btnQuitar
    '
    Me.btnQuitar.BackColor = System.Drawing.Color.White
    Me.btnQuitar.Location = New System.Drawing.Point(123, 189)
    Me.btnQuitar.Name = "btnQuitar"
    Me.btnQuitar.Size = New System.Drawing.Size(92, 23)
    Me.btnQuitar.TabIndex = 5
    Me.btnQuitar.Text = "&Quitar"
    Me.btnQuitar.UseVisualStyleBackColor = False
    '
    'btnAlumnos
    '
    Me.btnAlumnos.BackColor = System.Drawing.Color.White
    Me.btnAlumnos.Location = New System.Drawing.Point(308, 189)
    Me.btnAlumnos.Name = "btnAlumnos"
    Me.btnAlumnos.Size = New System.Drawing.Size(134, 23)
    Me.btnAlumnos.TabIndex = 4
    Me.btnAlumnos.Text = "Al&umnos Grupo"
    Me.btnAlumnos.UseVisualStyleBackColor = False
    '
    'btnNuevo
    '
    Me.btnNuevo.BackColor = System.Drawing.Color.White
    Me.btnNuevo.Location = New System.Drawing.Point(14, 189)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(92, 23)
    Me.btnNuevo.TabIndex = 2
    Me.btnNuevo.Text = "Nu&evo"
    Me.btnNuevo.UseVisualStyleBackColor = False
    '
    'dgvGrupoLibro
    '
    Me.dgvGrupoLibro.AllowUserToAddRows = False
    Me.dgvGrupoLibro.AllowUserToDeleteRows = False
    Me.dgvGrupoLibro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
    DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvGrupoLibro.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
    Me.dgvGrupoLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvGrupoLibro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdGrupo, Me.cdLibro, Me.cdImg, Me.cdCodigoLibro, Me.cdCodPre, Me.cdNroGrupo})
    Me.dgvGrupoLibro.Location = New System.Drawing.Point(3, 20)
    Me.dgvGrupoLibro.MultiSelect = False
    Me.dgvGrupoLibro.Name = "dgvGrupoLibro"
    DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Yellow
    DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
    Me.dgvGrupoLibro.RowsDefaultCellStyle = DataGridViewCellStyle9
    Me.dgvGrupoLibro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvGrupoLibro.Size = New System.Drawing.Size(439, 163)
    Me.dgvGrupoLibro.TabIndex = 0
    '
    'cdGrupo
    '
    Me.cdGrupo.HeaderText = "Grupo"
    Me.cdGrupo.Name = "cdGrupo"
    Me.cdGrupo.ReadOnly = True
    Me.cdGrupo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    Me.cdGrupo.Width = 110
    '
    'cdLibro
    '
    Me.cdLibro.HeaderText = "Libro"
    Me.cdLibro.Name = "cdLibro"
    Me.cdLibro.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.cdLibro.Width = 240
    '
    'cdImg
    '
    DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle8.NullValue = "System.Drawing.Bitmap"
    Me.cdImg.DefaultCellStyle = DataGridViewCellStyle8
    Me.cdImg.HeaderText = ""
    Me.cdImg.Image = CType(resources.GetObject("cdImg.Image"), System.Drawing.Image)
    Me.cdImg.Name = "cdImg"
    Me.cdImg.ReadOnly = True
    Me.cdImg.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
    Me.cdImg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.cdImg.Width = 40
    '
    'cdCodigoLibro
    '
    Me.cdCodigoLibro.HeaderText = "codLibro"
    Me.cdCodigoLibro.Name = "cdCodigoLibro"
    Me.cdCodigoLibro.Visible = False
    '
    'cdCodPre
    '
    Me.cdCodPre.HeaderText = "CodPres"
    Me.cdCodPre.Name = "cdCodPre"
    Me.cdCodPre.Visible = False
    '
    'cdNroGrupo
    '
    Me.cdNroGrupo.HeaderText = "NroGrupo"
    Me.cdNroGrupo.Name = "cdNroGrupo"
    Me.cdNroGrupo.Visible = False
    '
    'cdNro
    '
    Me.cdNro.DataPropertyName = "NroOrden"
    Me.cdNro.HeaderText = "N°"
    Me.cdNro.Name = "cdNro"
    Me.cdNro.ReadOnly = True
    Me.cdNro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    Me.cdNro.Width = 35
    '
    'cdAlumno
    '
    Me.cdAlumno.DataPropertyName = "NombreAlumno"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    Me.cdAlumno.DefaultCellStyle = DataGridViewCellStyle1
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.ReadOnly = True
    Me.cdAlumno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    Me.cdAlumno.Width = 285
    '
    'cdSexo
    '
    Me.cdSexo.DataPropertyName = "LeerSexo2"
    Me.cdSexo.HeaderText = "Sexo"
    Me.cdSexo.Name = "cdSexo"
    Me.cdSexo.ReadOnly = True
    Me.cdSexo.Visible = False
    '
    'cdAgregar
    '
    Me.cdAgregar.HeaderText = "Agregar"
    Me.cdAgregar.Name = "cdAgregar"
    Me.cdAgregar.Width = 60
    '
    'cdAsig
    '
    Me.cdAsig.HeaderText = "Asig."
    Me.cdAsig.Image = CType(resources.GetObject("cdAsig.Image"), System.Drawing.Image)
    Me.cdAsig.Name = "cdAsig"
    Me.cdAsig.Width = 40
    '
    'cdCodigoPL
    '
    Me.cdCodigoPL.HeaderText = ""
    Me.cdCodigoPL.Name = "cdCodigoPL"
    Me.cdCodigoPL.Visible = False
    '
    'frmGestionProgLectura
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(964, 696)
    Me.Controls.Add(Me.GBGrupo)
    Me.Controls.Add(Me.GBSeccion)
    Me.Controls.Add(Me.GBAlumnos)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.GBLista)
    Me.Controls.Add(Me.btnRegistrar)
    Me.MinimizeBox = False
    Me.Name = "frmGestionProgLectura"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Programación de lecturas"
    Me.GBAlumnos.ResumeLayout(False)
    Me.GBAlumnos.PerformLayout()
    CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GBLista.ResumeLayout(False)
    CType(Me.dgvPresentacion, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GBSeccion.ResumeLayout(False)
    Me.GBSeccion.PerformLayout()
    Me.GBGrupo.ResumeLayout(False)
    CType(Me.dgvGrupoLibro, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents txtAnio As System.Windows.Forms.TextBox
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents GBAlumnos As System.Windows.Forms.GroupBox
  Friend WithEvents dgvAlumnos As System.Windows.Forms.DataGridView
  Friend WithEvents GBLista As System.Windows.Forms.GroupBox
  Friend WithEvents dgvPresentacion As System.Windows.Forms.DataGridView
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents txtTotal As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cboSeleccionar As System.Windows.Forms.ComboBox
  Friend WithEvents lblSeleccionar As System.Windows.Forms.Label
  Friend WithEvents GBSeccion As System.Windows.Forms.GroupBox
  Friend WithEvents GBGrupo As System.Windows.Forms.GroupBox
  Friend WithEvents dgvGrupoLibro As System.Windows.Forms.DataGridView
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents btnAlumnos As System.Windows.Forms.Button
  Friend WithEvents btnQuitar As System.Windows.Forms.Button
  Friend WithEvents cdGrupo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdLibro As System.Windows.Forms.DataGridViewComboBoxColumn
  Friend WithEvents cdImg As System.Windows.Forms.DataGridViewImageColumn
  Friend WithEvents cdCodigoLibro As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCodPre As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdNroGrupo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdNroPres As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdInicio As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdFin As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAnio As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCodigoPres As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdNro As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdSexo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAgregar As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents cdAsig As System.Windows.Forms.DataGridViewImageColumn
  Friend WithEvents cdCodigoPL As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
