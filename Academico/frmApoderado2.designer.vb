<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApoderado2
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
        Me.TabApoderado = New System.Windows.Forms.TabControl
        Me.TabPageRegistrar = New System.Windows.Forms.TabPage
        Me.gbparentesco = New System.Windows.Forms.GroupBox
        Me.cboParentesco = New System.Windows.Forms.ComboBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.gbUbicacion = New System.Windows.Forms.GroupBox
        Me.cbodistrito = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.cbopPvcia = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cbopais = New System.Windows.Forms.ComboBox
        Me.cbodpto = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.gbdatos = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtNroDoc = New System.Windows.Forms.TextBox
        Me.cbotipoDoc = New System.Windows.Forms.ComboBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.cboVive = New System.Windows.Forms.ComboBox
        Me.txtcelular = New System.Windows.Forms.TextBox
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.txtTelefTrabajo = New System.Windows.Forms.TextBox
        Me.txtTelefcasa = New System.Windows.Forms.TextBox
        Me.txtdireccion = New System.Windows.Forms.TextBox
        Me.cboOcupacion = New System.Windows.Forms.ComboBox
        Me.cbogradoInst = New System.Windows.Forms.ComboBox
        Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker
        Me.cboSexo = New System.Windows.Forms.ComboBox
        Me.txtMat = New System.Windows.Forms.TextBox
        Me.txtPat = New System.Windows.Forms.TextBox
        Me.txtnombre = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.TabPageBuscar = New System.Windows.Forms.TabPage
        Me.gbbuscarparentesco = New System.Windows.Forms.GroupBox
        Me.cbparentescobuscar = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.dgvApoderado = New System.Windows.Forms.DataGridView
        Me.txtNombreBuscar = New System.Windows.Forms.TextBox
        Me.lblNombreBuscar = New System.Windows.Forms.Label
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.btnSeleccionar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnRegistrar = New System.Windows.Forms.Button
        Me.ErrorApoderado = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cdNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCodigoAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabApoderado.SuspendLayout()
        Me.TabPageRegistrar.SuspendLayout()
        Me.gbparentesco.SuspendLayout()
        Me.gbUbicacion.SuspendLayout()
        Me.gbdatos.SuspendLayout()
        Me.TabPageBuscar.SuspendLayout()
        Me.gbbuscarparentesco.SuspendLayout()
        CType(Me.dgvApoderado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorApoderado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabApoderado
        '
        Me.TabApoderado.Controls.Add(Me.TabPageRegistrar)
        Me.TabApoderado.Controls.Add(Me.TabPageBuscar)
        Me.TabApoderado.Location = New System.Drawing.Point(1, 2)
        Me.TabApoderado.Name = "TabApoderado"
        Me.TabApoderado.SelectedIndex = 0
        Me.TabApoderado.Size = New System.Drawing.Size(473, 577)
        Me.TabApoderado.TabIndex = 0
        '
        'TabPageRegistrar
        '
        Me.TabPageRegistrar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabPageRegistrar.Controls.Add(Me.gbparentesco)
        Me.TabPageRegistrar.Controls.Add(Me.gbUbicacion)
        Me.TabPageRegistrar.Controls.Add(Me.gbdatos)
        Me.TabPageRegistrar.Location = New System.Drawing.Point(4, 22)
        Me.TabPageRegistrar.Name = "TabPageRegistrar"
        Me.TabPageRegistrar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageRegistrar.Size = New System.Drawing.Size(465, 551)
        Me.TabPageRegistrar.TabIndex = 0
        Me.TabPageRegistrar.Text = "Registrar"
        '
        'gbparentesco
        '
        Me.gbparentesco.Controls.Add(Me.cboParentesco)
        Me.gbparentesco.Controls.Add(Me.Label28)
        Me.gbparentesco.Location = New System.Drawing.Point(7, 483)
        Me.gbparentesco.Name = "gbparentesco"
        Me.gbparentesco.Size = New System.Drawing.Size(446, 45)
        Me.gbparentesco.TabIndex = 2
        Me.gbparentesco.TabStop = False
        Me.gbparentesco.Text = "Parentesco"
        '
        'cboParentesco
        '
        Me.cboParentesco.FormattingEnabled = True
        Me.cboParentesco.Location = New System.Drawing.Point(157, 13)
        Me.cboParentesco.Name = "cboParentesco"
        Me.cboParentesco.Size = New System.Drawing.Size(121, 21)
        Me.cboParentesco.TabIndex = 0
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(83, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(64, 13)
        Me.Label28.TabIndex = 72
        Me.Label28.Text = "Parentesco "
        '
        'gbUbicacion
        '
        Me.gbUbicacion.Controls.Add(Me.cbodistrito)
        Me.gbUbicacion.Controls.Add(Me.Label17)
        Me.gbUbicacion.Controls.Add(Me.cbopPvcia)
        Me.gbUbicacion.Controls.Add(Me.Label16)
        Me.gbUbicacion.Controls.Add(Me.Label14)
        Me.gbUbicacion.Controls.Add(Me.cbopais)
        Me.gbUbicacion.Controls.Add(Me.cbodpto)
        Me.gbUbicacion.Controls.Add(Me.Label15)
        Me.gbUbicacion.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbUbicacion.Location = New System.Drawing.Point(6, 395)
        Me.gbUbicacion.Name = "gbUbicacion"
        Me.gbUbicacion.Size = New System.Drawing.Size(448, 82)
        Me.gbUbicacion.TabIndex = 1
        Me.gbUbicacion.TabStop = False
        Me.gbUbicacion.Text = "Ubicación Geográfica"
        '
        'cbodistrito
        '
        Me.cbodistrito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbodistrito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbodistrito.FormattingEnabled = True
        Me.cbodistrito.Location = New System.Drawing.Point(298, 50)
        Me.cbodistrito.Name = "cbodistrito"
        Me.cbodistrito.Size = New System.Drawing.Size(121, 23)
        Me.cbodistrito.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(251, 53)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 15)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Distrito"
        '
        'cbopPvcia
        '
        Me.cbopPvcia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbopPvcia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbopPvcia.FormattingEnabled = True
        Me.cbopPvcia.Location = New System.Drawing.Point(72, 50)
        Me.cbopPvcia.Name = "cbopPvcia"
        Me.cbopPvcia.Size = New System.Drawing.Size(121, 23)
        Me.cbopPvcia.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(37, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 15)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Pais"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(14, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 15)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "Provincia"
        '
        'cbopais
        '
        Me.cbopais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbopais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbopais.FormattingEnabled = True
        Me.cbopais.Items.AddRange(New Object() {""})
        Me.cbopais.Location = New System.Drawing.Point(72, 21)
        Me.cbopais.Name = "cbopais"
        Me.cbopais.Size = New System.Drawing.Size(121, 23)
        Me.cbopais.TabIndex = 0
        '
        'cbodpto
        '
        Me.cbodpto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbodpto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbodpto.FormattingEnabled = True
        Me.cbodpto.Items.AddRange(New Object() {""})
        Me.cbodpto.Location = New System.Drawing.Point(298, 21)
        Me.cbodpto.Name = "cbodpto"
        Me.cbodpto.Size = New System.Drawing.Size(121, 23)
        Me.cbodpto.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(217, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 15)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Departamento"
        '
        'gbdatos
        '
        Me.gbdatos.Controls.Add(Me.Label12)
        Me.gbdatos.Controls.Add(Me.txtNroDoc)
        Me.gbdatos.Controls.Add(Me.cbotipoDoc)
        Me.gbdatos.Controls.Add(Me.Label30)
        Me.gbdatos.Controls.Add(Me.cboVive)
        Me.gbdatos.Controls.Add(Me.txtcelular)
        Me.gbdatos.Controls.Add(Me.txtemail)
        Me.gbdatos.Controls.Add(Me.txtTelefTrabajo)
        Me.gbdatos.Controls.Add(Me.txtTelefcasa)
        Me.gbdatos.Controls.Add(Me.txtdireccion)
        Me.gbdatos.Controls.Add(Me.cboOcupacion)
        Me.gbdatos.Controls.Add(Me.cbogradoInst)
        Me.gbdatos.Controls.Add(Me.dtpFechaNac)
        Me.gbdatos.Controls.Add(Me.cboSexo)
        Me.gbdatos.Controls.Add(Me.txtMat)
        Me.gbdatos.Controls.Add(Me.txtPat)
        Me.gbdatos.Controls.Add(Me.txtnombre)
        Me.gbdatos.Controls.Add(Me.Label1)
        Me.gbdatos.Controls.Add(Me.Label2)
        Me.gbdatos.Controls.Add(Me.Label3)
        Me.gbdatos.Controls.Add(Me.Label4)
        Me.gbdatos.Controls.Add(Me.Label5)
        Me.gbdatos.Controls.Add(Me.Label6)
        Me.gbdatos.Controls.Add(Me.Label7)
        Me.gbdatos.Controls.Add(Me.Label8)
        Me.gbdatos.Controls.Add(Me.Label9)
        Me.gbdatos.Controls.Add(Me.Label10)
        Me.gbdatos.Controls.Add(Me.Label26)
        Me.gbdatos.Controls.Add(Me.Label27)
        Me.gbdatos.Controls.Add(Me.Label29)
        Me.gbdatos.Location = New System.Drawing.Point(3, 6)
        Me.gbdatos.Name = "gbdatos"
        Me.gbdatos.Size = New System.Drawing.Size(450, 383)
        Me.gbdatos.TabIndex = 0
        Me.gbdatos.TabStop = False
        Me.gbdatos.Text = "Datos Personales"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(298, 150)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "Nro. Doc."
        '
        'txtNroDoc
        '
        Me.txtNroDoc.Location = New System.Drawing.Point(357, 143)
        Me.txtNroDoc.MaxLength = 8
        Me.txtNroDoc.Name = "txtNroDoc"
        Me.txtNroDoc.Size = New System.Drawing.Size(87, 20)
        Me.txtNroDoc.TabIndex = 93
        '
        'cbotipoDoc
        '
        Me.cbotipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipoDoc.FormattingEnabled = True
        Me.cbotipoDoc.Items.AddRange(New Object() {"DNI", "Carnet Extranjería", "Libreta Electoral", "Libreta Militar", "Pasaporte", "Carnet Policial"})
        Me.cbotipoDoc.Location = New System.Drawing.Point(161, 142)
        Me.cbotipoDoc.Name = "cbotipoDoc"
        Me.cbotipoDoc.Size = New System.Drawing.Size(121, 21)
        Me.cbotipoDoc.TabIndex = 92
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(59, 150)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(86, 13)
        Me.Label30.TabIndex = 94
        Me.Label30.Text = "Tipo Documento"
        '
        'cboVive
        '
        Me.cboVive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVive.FormattingEnabled = True
        Me.cboVive.Items.AddRange(New Object() {"No", "Si"})
        Me.cboVive.Location = New System.Drawing.Point(161, 352)
        Me.cboVive.Name = "cboVive"
        Me.cboVive.Size = New System.Drawing.Size(121, 21)
        Me.cboVive.TabIndex = 14
        '
        'txtcelular
        '
        Me.txtcelular.Location = New System.Drawing.Point(161, 326)
        Me.txtcelular.MaxLength = 10
        Me.txtcelular.Name = "txtcelular"
        Me.txtcelular.Size = New System.Drawing.Size(121, 20)
        Me.txtcelular.TabIndex = 13
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(161, 300)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(216, 20)
        Me.txtemail.TabIndex = 12
        '
        'txtTelefTrabajo
        '
        Me.txtTelefTrabajo.Location = New System.Drawing.Point(161, 274)
        Me.txtTelefTrabajo.MaxLength = 10
        Me.txtTelefTrabajo.Name = "txtTelefTrabajo"
        Me.txtTelefTrabajo.Size = New System.Drawing.Size(121, 20)
        Me.txtTelefTrabajo.TabIndex = 11
        '
        'txtTelefcasa
        '
        Me.txtTelefcasa.Location = New System.Drawing.Point(161, 248)
        Me.txtTelefcasa.MaxLength = 10
        Me.txtTelefcasa.Name = "txtTelefcasa"
        Me.txtTelefcasa.Size = New System.Drawing.Size(121, 20)
        Me.txtTelefcasa.TabIndex = 10
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(161, 222)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(216, 20)
        Me.txtdireccion.TabIndex = 9
        '
        'cboOcupacion
        '
        Me.cboOcupacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboOcupacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboOcupacion.FormattingEnabled = True
        Me.cboOcupacion.Items.AddRange(New Object() {"Arquitecto", "Contador", "Economista", "Profesor", "Ingeniero", "Medico", "Abogado", "Obrero", "Comerciante", "Chofer", "Ama de Casa"})
        Me.cboOcupacion.Location = New System.Drawing.Point(161, 195)
        Me.cboOcupacion.Name = "cboOcupacion"
        Me.cboOcupacion.Size = New System.Drawing.Size(121, 21)
        Me.cboOcupacion.TabIndex = 8
        '
        'cbogradoInst
        '
        Me.cbogradoInst.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbogradoInst.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbogradoInst.FormattingEnabled = True
        Me.cbogradoInst.Items.AddRange(New Object() {"Primaria ", "Secundaria", "Tecnica", "Superior"})
        Me.cbogradoInst.Location = New System.Drawing.Point(161, 168)
        Me.cbogradoInst.Name = "cbogradoInst"
        Me.cbogradoInst.Size = New System.Drawing.Size(121, 21)
        Me.cbogradoInst.TabIndex = 7
        '
        'dtpFechaNac
        '
        Me.dtpFechaNac.Location = New System.Drawing.Point(161, 116)
        Me.dtpFechaNac.Name = "dtpFechaNac"
        Me.dtpFechaNac.Size = New System.Drawing.Size(216, 20)
        Me.dtpFechaNac.TabIndex = 4
        Me.dtpFechaNac.Value = New Date(1970, 1, 1, 0, 0, 0, 0)
        '
        'cboSexo
        '
        Me.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.cboSexo.Location = New System.Drawing.Point(161, 89)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(121, 21)
        Me.cboSexo.TabIndex = 3
        '
        'txtMat
        '
        Me.txtMat.Location = New System.Drawing.Point(161, 63)
        Me.txtMat.Name = "txtMat"
        Me.txtMat.Size = New System.Drawing.Size(216, 20)
        Me.txtMat.TabIndex = 2
        '
        'txtPat
        '
        Me.txtPat.Location = New System.Drawing.Point(161, 37)
        Me.txtPat.Name = "txtPat"
        Me.txtPat.Size = New System.Drawing.Size(216, 20)
        Me.txtPat.TabIndex = 1
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(161, 11)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(216, 20)
        Me.txtnombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 15)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Fecha Nacimiento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(119, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 15)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Sexo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 15)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Apellido Materno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(66, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 15)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Apellido Paterno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(100, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 15)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Nombres"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(120, 354)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Vive "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(109, 328)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Celular "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(116, 302)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Email "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(72, 250)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "Teléfono Casa "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(63, 276)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Teléfono Trabajo"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(96, 224)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(55, 13)
        Me.Label26.TabIndex = 74
        Me.Label26.Text = "Dirección "
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(92, 197)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(59, 13)
        Me.Label27.TabIndex = 73
        Me.Label27.Text = "Ocupación"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(57, 170)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(94, 13)
        Me.Label29.TabIndex = 71
        Me.Label29.Text = "Grado Instrucción "
        '
        'TabPageBuscar
        '
        Me.TabPageBuscar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabPageBuscar.Controls.Add(Me.gbbuscarparentesco)
        Me.TabPageBuscar.Controls.Add(Me.btnBuscar)
        Me.TabPageBuscar.Controls.Add(Me.dgvApoderado)
        Me.TabPageBuscar.Controls.Add(Me.txtNombreBuscar)
        Me.TabPageBuscar.Controls.Add(Me.lblNombreBuscar)
        Me.TabPageBuscar.Controls.Add(Me.btnNuevo)
        Me.TabPageBuscar.Controls.Add(Me.btnSeleccionar)
        Me.TabPageBuscar.Location = New System.Drawing.Point(4, 22)
        Me.TabPageBuscar.Name = "TabPageBuscar"
        Me.TabPageBuscar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageBuscar.Size = New System.Drawing.Size(465, 551)
        Me.TabPageBuscar.TabIndex = 1
        Me.TabPageBuscar.Text = "Buscar"
        '
        'gbbuscarparentesco
        '
        Me.gbbuscarparentesco.Controls.Add(Me.cbparentescobuscar)
        Me.gbbuscarparentesco.Controls.Add(Me.Label11)
        Me.gbbuscarparentesco.Location = New System.Drawing.Point(19, 462)
        Me.gbbuscarparentesco.Name = "gbbuscarparentesco"
        Me.gbbuscarparentesco.Size = New System.Drawing.Size(431, 45)
        Me.gbbuscarparentesco.TabIndex = 12
        Me.gbbuscarparentesco.TabStop = False
        Me.gbbuscarparentesco.Text = "Parentesco"
        '
        'cbparentescobuscar
        '
        Me.cbparentescobuscar.BackColor = System.Drawing.SystemColors.Info
        Me.cbparentescobuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbparentescobuscar.FormattingEnabled = True
        Me.cbparentescobuscar.Location = New System.Drawing.Point(157, 13)
        Me.cbparentescobuscar.Name = "cbparentescobuscar"
        Me.cbparentescobuscar.Size = New System.Drawing.Size(121, 21)
        Me.cbparentescobuscar.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(83, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Parentesco "
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(352, 14)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(58, 23)
        Me.btnBuscar.TabIndex = 10
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dgvApoderado
        '
        Me.dgvApoderado.AllowUserToAddRows = False
        Me.dgvApoderado.AllowUserToDeleteRows = False
        Me.dgvApoderado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvApoderado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNombre, Me.colCodigoAlumno})
        Me.dgvApoderado.Location = New System.Drawing.Point(19, 38)
        Me.dgvApoderado.MultiSelect = False
        Me.dgvApoderado.Name = "dgvApoderado"
        Me.dgvApoderado.ReadOnly = True
        Me.dgvApoderado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvApoderado.Size = New System.Drawing.Size(431, 361)
        Me.dgvApoderado.TabIndex = 11
        '
        'txtNombreBuscar
        '
        Me.txtNombreBuscar.Location = New System.Drawing.Point(66, 12)
        Me.txtNombreBuscar.Name = "txtNombreBuscar"
        Me.txtNombreBuscar.Size = New System.Drawing.Size(256, 20)
        Me.txtNombreBuscar.TabIndex = 9
        '
        'lblNombreBuscar
        '
        Me.lblNombreBuscar.AutoSize = True
        Me.lblNombreBuscar.Location = New System.Drawing.Point(16, 15)
        Me.lblNombreBuscar.Name = "lblNombreBuscar"
        Me.lblNombreBuscar.Size = New System.Drawing.Size(44, 13)
        Me.lblNombreBuscar.TabIndex = 8
        Me.lblNombreBuscar.Text = "&Nombre"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(19, 417)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(89, 23)
        Me.btnNuevo.TabIndex = 4
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(359, 417)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(91, 23)
        Me.btnSeleccionar.TabIndex = 3
        Me.btnSeleccionar.Text = "&Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(265, 595)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(111, 595)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 3
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'ErrorApoderado
        '
        Me.ErrorApoderado.ContainerControl = Me
        '
        'cdNombre
        '
        Me.cdNombre.DataPropertyName = "NombreCompleto"
        Me.cdNombre.HeaderText = "Apoderado"
        Me.cdNombre.Name = "cdNombre"
        Me.cdNombre.ReadOnly = True
        Me.cdNombre.Width = 350
        '
        'colCodigoAlumno
        '
        Me.colCodigoAlumno.DataPropertyName = "codigo"
        Me.colCodigoAlumno.HeaderText = "Codigo"
        Me.colCodigoAlumno.Name = "colCodigoAlumno"
        Me.colCodigoAlumno.ReadOnly = True
        Me.colCodigoAlumno.Visible = False
        '
        'frmApoderado2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 641)
        Me.Controls.Add(Me.TabApoderado)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmApoderado2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Apoderado"
        Me.TabApoderado.ResumeLayout(False)
        Me.TabPageRegistrar.ResumeLayout(False)
        Me.gbparentesco.ResumeLayout(False)
        Me.gbparentesco.PerformLayout()
        Me.gbUbicacion.ResumeLayout(False)
        Me.gbUbicacion.PerformLayout()
        Me.gbdatos.ResumeLayout(False)
        Me.gbdatos.PerformLayout()
        Me.TabPageBuscar.ResumeLayout(False)
        Me.TabPageBuscar.PerformLayout()
        Me.gbbuscarparentesco.ResumeLayout(False)
        Me.gbbuscarparentesco.PerformLayout()
        CType(Me.dgvApoderado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorApoderado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
  Friend WithEvents TabApoderado As System.Windows.Forms.TabControl
  Friend WithEvents TabPageRegistrar As System.Windows.Forms.TabPage
  Friend WithEvents gbdatos As System.Windows.Forms.GroupBox
  Protected WithEvents cboVive As System.Windows.Forms.ComboBox
  Friend WithEvents txtcelular As System.Windows.Forms.TextBox
  Friend WithEvents txtemail As System.Windows.Forms.TextBox
  Friend WithEvents txtTelefTrabajo As System.Windows.Forms.TextBox
  Friend WithEvents txtTelefcasa As System.Windows.Forms.TextBox
  Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
  Friend WithEvents cboOcupacion As System.Windows.Forms.ComboBox
  Friend WithEvents cbogradoInst As System.Windows.Forms.ComboBox
  Friend WithEvents cboParentesco As System.Windows.Forms.ComboBox
  Friend WithEvents dtpFechaNac As System.Windows.Forms.DateTimePicker
  Friend WithEvents cboSexo As System.Windows.Forms.ComboBox
  Friend WithEvents txtMat As System.Windows.Forms.TextBox
  Friend WithEvents txtPat As System.Windows.Forms.TextBox
  Friend WithEvents txtnombre As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents Label26 As System.Windows.Forms.Label
  Friend WithEvents Label27 As System.Windows.Forms.Label
  Friend WithEvents Label28 As System.Windows.Forms.Label
  Friend WithEvents Label29 As System.Windows.Forms.Label
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents TabPageBuscar As System.Windows.Forms.TabPage
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
  Friend WithEvents dgvApoderado As System.Windows.Forms.DataGridView
    Friend WithEvents txtNombreBuscar As System.Windows.Forms.TextBox
  Friend WithEvents lblNombreBuscar As System.Windows.Forms.Label
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
  Friend WithEvents ErrorApoderado As System.Windows.Forms.ErrorProvider
  Friend WithEvents gbUbicacion As System.Windows.Forms.GroupBox
  Friend WithEvents cbodistrito As System.Windows.Forms.ComboBox
  Friend WithEvents Label17 As System.Windows.Forms.Label
  Friend WithEvents cbopPvcia As System.Windows.Forms.ComboBox
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents cbopais As System.Windows.Forms.ComboBox
  Friend WithEvents cbodpto As System.Windows.Forms.ComboBox
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents gbparentesco As System.Windows.Forms.GroupBox
  Friend WithEvents gbbuscarparentesco As System.Windows.Forms.GroupBox
  Friend WithEvents cbparentescobuscar As System.Windows.Forms.ComboBox
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents txtNroDoc As System.Windows.Forms.TextBox
  Friend WithEvents cbotipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cdNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCodigoAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
