<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionSecciones
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.gbGrado = New System.Windows.Forms.GroupBox
    Me.dgvGrados = New System.Windows.Forms.DataGridView
    Me.colnombre = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.colnivelacad = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnImportar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.gbAnioLectivo = New System.Windows.Forms.GroupBox
    Me.txtAnio = New System.Windows.Forms.TextBox
    Me.lblAnioLectivo = New System.Windows.Forms.Label
    Me.gbSecciones = New System.Windows.Forms.GroupBox
    Me.dgvSecciones = New System.Windows.Forms.DataGridView
    Me.codigoG = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.letra = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdAula = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.codigoTurno = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.codigoTutor = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnModificar = New System.Windows.Forms.Button
    Me.gbNuevaSeccion = New System.Windows.Forms.GroupBox
    Me.chkVigente = New System.Windows.Forms.CheckBox
    Me.lblLetra = New System.Windows.Forms.Label
    Me.txtLetra = New System.Windows.Forms.TextBox
    Me.cbtutor = New System.Windows.Forms.ComboBox
    Me.gbIntNuevaSec = New System.Windows.Forms.GroupBox
    Me.cblocal = New System.Windows.Forms.ComboBox
    Me.lblLocal = New System.Windows.Forms.Label
    Me.cbturno = New System.Windows.Forms.ComboBox
    Me.cbaula = New System.Windows.Forms.ComboBox
    Me.lblTurno = New System.Windows.Forms.Label
    Me.lblAula = New System.Windows.Forms.Label
    Me.lblTutor = New System.Windows.Forms.Label
    Me.txtDescripcion = New System.Windows.Forms.TextBox
    Me.lblDescripcion = New System.Windows.Forms.Label
    Me.lblVacantes = New System.Windows.Forms.Label
    Me.txtVacantes = New System.Windows.Forms.TextBox
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.errValida = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.lblMensaje = New System.Windows.Forms.Label
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.lblSecAnulada = New System.Windows.Forms.Label
    Me.gbLeyenda = New System.Windows.Forms.GroupBox
    Me.gbGrado.SuspendLayout()
    CType(Me.dgvGrados, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbAnioLectivo.SuspendLayout()
    Me.gbSecciones.SuspendLayout()
    CType(Me.dgvSecciones, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbNuevaSeccion.SuspendLayout()
    Me.gbIntNuevaSec.SuspendLayout()
    CType(Me.errValida, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbLeyenda.SuspendLayout()
    Me.SuspendLayout()
    '
    'gbGrado
    '
    Me.gbGrado.Controls.Add(Me.dgvGrados)
    Me.gbGrado.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbGrado.Location = New System.Drawing.Point(12, 72)
    Me.gbGrado.Name = "gbGrado"
    Me.gbGrado.Size = New System.Drawing.Size(350, 414)
    Me.gbGrado.TabIndex = 0
    Me.gbGrado.TabStop = False
    Me.gbGrado.Text = "Grado"
    '
    'dgvGrados
    '
    Me.dgvGrados.AllowUserToAddRows = False
    Me.dgvGrados.AllowUserToDeleteRows = False
    Me.dgvGrados.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvGrados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvGrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvGrados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colnombre, Me.colnivelacad})
    Me.dgvGrados.Location = New System.Drawing.Point(18, 27)
    Me.dgvGrados.MultiSelect = False
    Me.dgvGrados.Name = "dgvGrados"
    Me.dgvGrados.ReadOnly = True
    Me.dgvGrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvGrados.Size = New System.Drawing.Size(315, 372)
    Me.dgvGrados.StandardTab = True
    Me.dgvGrados.TabIndex = 0
    '
    'colnombre
    '
    Me.colnombre.DataPropertyName = "nombre"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.colnombre.DefaultCellStyle = DataGridViewCellStyle2
    Me.colnombre.HeaderText = "Grado"
    Me.colnombre.Name = "colnombre"
    Me.colnombre.ReadOnly = True
    '
    'colnivelacad
    '
    Me.colnivelacad.DataPropertyName = "nombreNivel"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.colnivelacad.DefaultCellStyle = DataGridViewCellStyle3
    Me.colnivelacad.HeaderText = "Nivel Academico"
    Me.colnivelacad.Name = "colnivelacad"
    Me.colnivelacad.ReadOnly = True
    Me.colnivelacad.Width = 170
    '
    'btnImportar
    '
    Me.btnImportar.BackColor = System.Drawing.Color.White
    Me.btnImportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnImportar.Location = New System.Drawing.Point(856, 156)
    Me.btnImportar.Name = "btnImportar"
    Me.btnImportar.Size = New System.Drawing.Size(110, 50)
    Me.btnImportar.TabIndex = 2
    Me.btnImportar.Text = "&Importar"
    Me.btnImportar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(856, 436)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 50)
    Me.btnCerrar.TabIndex = 3
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'gbAnioLectivo
    '
    Me.gbAnioLectivo.Controls.Add(Me.txtAnio)
    Me.gbAnioLectivo.Controls.Add(Me.lblAnioLectivo)
    Me.gbAnioLectivo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbAnioLectivo.Location = New System.Drawing.Point(12, 12)
    Me.gbAnioLectivo.Name = "gbAnioLectivo"
    Me.gbAnioLectivo.Size = New System.Drawing.Size(350, 54)
    Me.gbAnioLectivo.TabIndex = 4
    Me.gbAnioLectivo.TabStop = False
    Me.gbAnioLectivo.Text = "Año Lectivo"
    '
    'txtAnio
    '
    Me.txtAnio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAnio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAnio.Location = New System.Drawing.Point(141, 21)
    Me.txtAnio.Multiline = True
    Me.txtAnio.Name = "txtAnio"
    Me.txtAnio.ReadOnly = True
    Me.txtAnio.Size = New System.Drawing.Size(108, 24)
    Me.txtAnio.TabIndex = 1
    Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'lblAnioLectivo
    '
    Me.lblAnioLectivo.AutoSize = True
    Me.lblAnioLectivo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAnioLectivo.Location = New System.Drawing.Point(101, 24)
    Me.lblAnioLectivo.Name = "lblAnioLectivo"
    Me.lblAnioLectivo.Size = New System.Drawing.Size(31, 15)
    Me.lblAnioLectivo.TabIndex = 0
    Me.lblAnioLectivo.Text = "Año"
    '
    'gbSecciones
    '
    Me.gbSecciones.Controls.Add(Me.dgvSecciones)
    Me.gbSecciones.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbSecciones.Location = New System.Drawing.Point(368, 12)
    Me.gbSecciones.Name = "gbSecciones"
    Me.gbSecciones.Size = New System.Drawing.Size(482, 213)
    Me.gbSecciones.TabIndex = 5
    Me.gbSecciones.TabStop = False
    Me.gbSecciones.Text = "Secciones"
    '
    'dgvSecciones
    '
    Me.dgvSecciones.AllowUserToAddRows = False
    Me.dgvSecciones.AllowUserToDeleteRows = False
    Me.dgvSecciones.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvSecciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.dgvSecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvSecciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigoG, Me.letra, Me.cdAula, Me.codigoTurno, Me.codigoTutor})
    Me.dgvSecciones.Location = New System.Drawing.Point(9, 26)
    Me.dgvSecciones.MultiSelect = False
    Me.dgvSecciones.Name = "dgvSecciones"
    Me.dgvSecciones.ReadOnly = True
    Me.dgvSecciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvSecciones.Size = New System.Drawing.Size(464, 177)
    Me.dgvSecciones.TabIndex = 0
    Me.dgvSecciones.TabStop = False
    '
    'codigoG
    '
    Me.codigoG.DataPropertyName = "nombreGrado"
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.codigoG.DefaultCellStyle = DataGridViewCellStyle5
    Me.codigoG.HeaderText = "Grado"
    Me.codigoG.Name = "codigoG"
    Me.codigoG.ReadOnly = True
    Me.codigoG.Visible = False
    Me.codigoG.Width = 80
    '
    'letra
    '
    Me.letra.DataPropertyName = "letra"
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.letra.DefaultCellStyle = DataGridViewCellStyle6
    Me.letra.HeaderText = "Letra"
    Me.letra.Name = "letra"
    Me.letra.ReadOnly = True
    Me.letra.Width = 50
    '
    'cdAula
    '
    Me.cdAula.DataPropertyName = "NombreCompletoAula"
    DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.cdAula.DefaultCellStyle = DataGridViewCellStyle7
    Me.cdAula.HeaderText = "Aula"
    Me.cdAula.Name = "cdAula"
    Me.cdAula.ReadOnly = True
    Me.cdAula.Width = 50
    '
    'codigoTurno
    '
    Me.codigoTurno.DataPropertyName = "nombreTurno"
    Me.codigoTurno.HeaderText = "Turno"
    Me.codigoTurno.Name = "codigoTurno"
    Me.codigoTurno.ReadOnly = True
    Me.codigoTurno.Width = 90
    '
    'codigoTutor
    '
    Me.codigoTutor.DataPropertyName = "nombreTutor"
    Me.codigoTutor.HeaderText = "Tutor"
    Me.codigoTutor.Name = "codigoTutor"
    Me.codigoTutor.ReadOnly = True
    Me.codigoTutor.Width = 225
    '
    'btnModificar
    '
    Me.btnModificar.BackColor = System.Drawing.Color.White
    Me.btnModificar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnModificar.Location = New System.Drawing.Point(856, 100)
    Me.btnModificar.Name = "btnModificar"
    Me.btnModificar.Size = New System.Drawing.Size(110, 50)
    Me.btnModificar.TabIndex = 1
    Me.btnModificar.Text = "&Modificar"
    Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnModificar.UseVisualStyleBackColor = False
    '
    'gbNuevaSeccion
    '
    Me.gbNuevaSeccion.Controls.Add(Me.chkVigente)
    Me.gbNuevaSeccion.Controls.Add(Me.lblLetra)
    Me.gbNuevaSeccion.Controls.Add(Me.txtLetra)
    Me.gbNuevaSeccion.Controls.Add(Me.cbtutor)
    Me.gbNuevaSeccion.Controls.Add(Me.gbIntNuevaSec)
    Me.gbNuevaSeccion.Controls.Add(Me.lblTutor)
    Me.gbNuevaSeccion.Controls.Add(Me.txtDescripcion)
    Me.gbNuevaSeccion.Controls.Add(Me.lblDescripcion)
    Me.gbNuevaSeccion.Controls.Add(Me.lblVacantes)
    Me.gbNuevaSeccion.Controls.Add(Me.txtVacantes)
    Me.gbNuevaSeccion.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbNuevaSeccion.Location = New System.Drawing.Point(368, 253)
    Me.gbNuevaSeccion.Name = "gbNuevaSeccion"
    Me.gbNuevaSeccion.Size = New System.Drawing.Size(482, 233)
    Me.gbNuevaSeccion.TabIndex = 6
    Me.gbNuevaSeccion.TabStop = False
    Me.gbNuevaSeccion.Text = "Nueva Seccion"
    '
    'chkVigente
    '
    Me.chkVigente.AutoSize = True
    Me.chkVigente.Location = New System.Drawing.Point(389, 115)
    Me.chkVigente.Name = "chkVigente"
    Me.chkVigente.Size = New System.Drawing.Size(66, 19)
    Me.chkVigente.TabIndex = 21
    Me.chkVigente.Text = "Vigente"
    Me.chkVigente.UseVisualStyleBackColor = True
    Me.chkVigente.Visible = False
    '
    'lblLetra
    '
    Me.lblLetra.AutoSize = True
    Me.lblLetra.Location = New System.Drawing.Point(67, 116)
    Me.lblLetra.Name = "lblLetra"
    Me.lblLetra.Size = New System.Drawing.Size(34, 15)
    Me.lblLetra.TabIndex = 20
    Me.lblLetra.Text = "Letra"
    '
    'txtLetra
    '
    Me.txtLetra.BackColor = System.Drawing.SystemColors.Window
    Me.txtLetra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtLetra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtLetra.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtLetra.Location = New System.Drawing.Point(104, 113)
    Me.txtLetra.Multiline = True
    Me.txtLetra.Name = "txtLetra"
    Me.txtLetra.ReadOnly = True
    Me.txtLetra.Size = New System.Drawing.Size(66, 24)
    Me.txtLetra.TabIndex = 1
    '
    'cbtutor
    '
    Me.cbtutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cbtutor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cbtutor.BackColor = System.Drawing.SystemColors.Window
    Me.cbtutor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbtutor.FormattingEnabled = True
    Me.cbtutor.Location = New System.Drawing.Point(104, 144)
    Me.cbtutor.Name = "cbtutor"
    Me.cbtutor.Size = New System.Drawing.Size(349, 24)
    Me.cbtutor.TabIndex = 3
    '
    'gbIntNuevaSec
    '
    Me.gbIntNuevaSec.Controls.Add(Me.cblocal)
    Me.gbIntNuevaSec.Controls.Add(Me.lblLocal)
    Me.gbIntNuevaSec.Controls.Add(Me.cbturno)
    Me.gbIntNuevaSec.Controls.Add(Me.cbaula)
    Me.gbIntNuevaSec.Controls.Add(Me.lblTurno)
    Me.gbIntNuevaSec.Controls.Add(Me.lblAula)
    Me.gbIntNuevaSec.Location = New System.Drawing.Point(26, 19)
    Me.gbIntNuevaSec.Name = "gbIntNuevaSec"
    Me.gbIntNuevaSec.Size = New System.Drawing.Size(430, 78)
    Me.gbIntNuevaSec.TabIndex = 0
    Me.gbIntNuevaSec.TabStop = False
    '
    'cblocal
    '
    Me.cblocal.BackColor = System.Drawing.SystemColors.Window
    Me.cblocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cblocal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cblocal.FormattingEnabled = True
    Me.cblocal.Location = New System.Drawing.Point(54, 16)
    Me.cblocal.MaxDropDownItems = 20
    Me.cblocal.Name = "cblocal"
    Me.cblocal.Size = New System.Drawing.Size(362, 24)
    Me.cblocal.TabIndex = 0
    '
    'lblLocal
    '
    Me.lblLocal.AutoSize = True
    Me.lblLocal.Location = New System.Drawing.Point(14, 20)
    Me.lblLocal.Name = "lblLocal"
    Me.lblLocal.Size = New System.Drawing.Size(36, 15)
    Me.lblLocal.TabIndex = 16
    Me.lblLocal.Text = "Local"
    '
    'cbturno
    '
    Me.cbturno.BackColor = System.Drawing.SystemColors.Window
    Me.cbturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbturno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbturno.FormattingEnabled = True
    Me.cbturno.Location = New System.Drawing.Point(278, 46)
    Me.cbturno.Name = "cbturno"
    Me.cbturno.Size = New System.Drawing.Size(138, 24)
    Me.cbturno.TabIndex = 2
    '
    'cbaula
    '
    Me.cbaula.BackColor = System.Drawing.SystemColors.Window
    Me.cbaula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbaula.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbaula.FormattingEnabled = True
    Me.cbaula.Location = New System.Drawing.Point(54, 46)
    Me.cbaula.Name = "cbaula"
    Me.cbaula.Size = New System.Drawing.Size(170, 24)
    Me.cbaula.TabIndex = 1
    '
    'lblTurno
    '
    Me.lblTurno.AutoSize = True
    Me.lblTurno.Location = New System.Drawing.Point(236, 50)
    Me.lblTurno.Name = "lblTurno"
    Me.lblTurno.Size = New System.Drawing.Size(40, 15)
    Me.lblTurno.TabIndex = 5
    Me.lblTurno.Text = "Turno"
    '
    'lblAula
    '
    Me.lblAula.AutoSize = True
    Me.lblAula.Location = New System.Drawing.Point(17, 50)
    Me.lblAula.Name = "lblAula"
    Me.lblAula.Size = New System.Drawing.Size(33, 15)
    Me.lblAula.TabIndex = 4
    Me.lblAula.Text = "Aula"
    '
    'lblTutor
    '
    Me.lblTutor.AutoSize = True
    Me.lblTutor.Location = New System.Drawing.Point(61, 153)
    Me.lblTutor.Name = "lblTutor"
    Me.lblTutor.Size = New System.Drawing.Size(37, 15)
    Me.lblTutor.TabIndex = 13
    Me.lblTutor.Text = "Tutor"
    '
    'txtDescripcion
    '
    Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
    Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtDescripcion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDescripcion.Location = New System.Drawing.Point(104, 175)
    Me.txtDescripcion.Multiline = True
    Me.txtDescripcion.Name = "txtDescripcion"
    Me.txtDescripcion.Size = New System.Drawing.Size(349, 45)
    Me.txtDescripcion.TabIndex = 4
    '
    'lblDescripcion
    '
    Me.lblDescripcion.AutoSize = True
    Me.lblDescripcion.Location = New System.Drawing.Point(27, 178)
    Me.lblDescripcion.Name = "lblDescripcion"
    Me.lblDescripcion.Size = New System.Drawing.Size(71, 15)
    Me.lblDescripcion.TabIndex = 7
    Me.lblDescripcion.Text = "Descripcion"
    '
    'lblVacantes
    '
    Me.lblVacantes.AutoSize = True
    Me.lblVacantes.Location = New System.Drawing.Point(215, 116)
    Me.lblVacantes.Name = "lblVacantes"
    Me.lblVacantes.Size = New System.Drawing.Size(55, 15)
    Me.lblVacantes.TabIndex = 8
    Me.lblVacantes.Text = "Vacantes"
    '
    'txtVacantes
    '
    Me.txtVacantes.BackColor = System.Drawing.SystemColors.Window
    Me.txtVacantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtVacantes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtVacantes.Location = New System.Drawing.Point(276, 113)
    Me.txtVacantes.MaxLength = 40
    Me.txtVacantes.Multiline = True
    Me.txtVacantes.Name = "txtVacantes"
    Me.txtVacantes.Size = New System.Drawing.Size(66, 24)
    Me.txtVacantes.TabIndex = 2
    Me.txtVacantes.Text = "35"
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(856, 315)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 50)
    Me.btnCancelar.TabIndex = 6
    Me.btnCancelar.Text = "&Deshacer"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(856, 259)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 50)
    Me.btnRegistrar.TabIndex = 5
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'errValida
    '
    Me.errValida.ContainerControl = Me
    '
    'lblMensaje
    '
    Me.lblMensaje.AutoSize = True
    Me.lblMensaje.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMensaje.ForeColor = System.Drawing.SystemColors.ActiveCaption
    Me.lblMensaje.Location = New System.Drawing.Point(12, 501)
    Me.lblMensaje.Name = "lblMensaje"
    Me.lblMensaje.Size = New System.Drawing.Size(415, 19)
    Me.lblMensaje.TabIndex = 7
    Me.lblMensaje.Text = "Click en Deshacer para anular la operación y volver a iniciar."
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.Gray
    Me.Panel1.Location = New System.Drawing.Point(6, 43)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(98, 16)
    Me.Panel1.TabIndex = 8
    '
    'lblSecAnulada
    '
    Me.lblSecAnulada.AutoSize = True
    Me.lblSecAnulada.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSecAnulada.Location = New System.Drawing.Point(11, 26)
    Me.lblSecAnulada.Name = "lblSecAnulada"
    Me.lblSecAnulada.Size = New System.Drawing.Size(88, 14)
    Me.lblSecAnulada.TabIndex = 9
    Me.lblSecAnulada.Text = "Sección Anulada"
    '
    'gbLeyenda
    '
    Me.gbLeyenda.Controls.Add(Me.Panel1)
    Me.gbLeyenda.Controls.Add(Me.lblSecAnulada)
    Me.gbLeyenda.Location = New System.Drawing.Point(856, 12)
    Me.gbLeyenda.Name = "gbLeyenda"
    Me.gbLeyenda.Size = New System.Drawing.Size(110, 70)
    Me.gbLeyenda.TabIndex = 10
    Me.gbLeyenda.TabStop = False
    Me.gbLeyenda.Text = "Leyenda"
    '
    'frmGestionSecciones
    '
    Me.AcceptButton = Me.btnRegistrar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(978, 531)
    Me.Controls.Add(Me.gbLeyenda)
    Me.Controls.Add(Me.lblMensaje)
    Me.Controls.Add(Me.btnModificar)
    Me.Controls.Add(Me.gbNuevaSeccion)
    Me.Controls.Add(Me.gbSecciones)
    Me.Controls.Add(Me.btnImportar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.gbGrado)
    Me.Controls.Add(Me.gbAnioLectivo)
    Me.Controls.Add(Me.btnRegistrar)
    Me.MaximizeBox = False
    Me.Name = "frmGestionSecciones"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Mantenimiento Secciones"
    Me.gbGrado.ResumeLayout(False)
    CType(Me.dgvGrados, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbAnioLectivo.ResumeLayout(False)
    Me.gbAnioLectivo.PerformLayout()
    Me.gbSecciones.ResumeLayout(False)
    CType(Me.dgvSecciones, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbNuevaSeccion.ResumeLayout(False)
    Me.gbNuevaSeccion.PerformLayout()
    Me.gbIntNuevaSec.ResumeLayout(False)
    Me.gbIntNuevaSec.PerformLayout()
    CType(Me.errValida, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbLeyenda.ResumeLayout(False)
    Me.gbLeyenda.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents gbGrado As System.Windows.Forms.GroupBox
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents dgvGrados As System.Windows.Forms.DataGridView
  Friend WithEvents gbAnioLectivo As System.Windows.Forms.GroupBox
  Friend WithEvents lblAnioLectivo As System.Windows.Forms.Label
  Friend WithEvents btnImportar As System.Windows.Forms.Button
  Friend WithEvents txtAnio As System.Windows.Forms.TextBox
  Friend WithEvents gbSecciones As System.Windows.Forms.GroupBox
  Friend WithEvents btnModificar As System.Windows.Forms.Button
  Friend WithEvents dgvSecciones As System.Windows.Forms.DataGridView
  Friend WithEvents gbNuevaSeccion As System.Windows.Forms.GroupBox
  Friend WithEvents lblLetra As System.Windows.Forms.Label
  Friend WithEvents txtLetra As System.Windows.Forms.TextBox
  Friend WithEvents cbtutor As System.Windows.Forms.ComboBox
  Friend WithEvents gbIntNuevaSec As System.Windows.Forms.GroupBox
  Friend WithEvents cblocal As System.Windows.Forms.ComboBox
  Friend WithEvents lblLocal As System.Windows.Forms.Label
  Friend WithEvents cbturno As System.Windows.Forms.ComboBox
  Friend WithEvents cbaula As System.Windows.Forms.ComboBox
  Friend WithEvents lblTurno As System.Windows.Forms.Label
  Friend WithEvents lblAula As System.Windows.Forms.Label
  Friend WithEvents lblTutor As System.Windows.Forms.Label
  Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
  Friend WithEvents lblDescripcion As System.Windows.Forms.Label
  Friend WithEvents lblVacantes As System.Windows.Forms.Label
  Friend WithEvents txtVacantes As System.Windows.Forms.TextBox
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents colnombre As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colnivelacad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents errValida As System.Windows.Forms.ErrorProvider
  Friend WithEvents lblMensaje As System.Windows.Forms.Label
  Friend WithEvents codigoG As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents letra As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAula As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents codigoTurno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents codigoTutor As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents chkVigente As System.Windows.Forms.CheckBox
  Friend WithEvents lblSecAnulada As System.Windows.Forms.Label
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents gbLeyenda As System.Windows.Forms.GroupBox
End Class
