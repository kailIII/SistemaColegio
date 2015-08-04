<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionDocente
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionDocente))
    Me.gbDatosPer = New System.Windows.Forms.GroupBox
    Me.btnImagen = New System.Windows.Forms.Button
    Me.PictureBox1 = New System.Windows.Forms.PictureBox
    Me.gbDocumentoIdent = New System.Windows.Forms.GroupBox
    Me.cboTipoDoc = New System.Windows.Forms.ComboBox
    Me.lblTipoDoc = New System.Windows.Forms.Label
    Me.txtNroDoc = New System.Windows.Forms.TextBox
    Me.lblNroDoc = New System.Windows.Forms.Label
    Me.lblOpcion2 = New System.Windows.Forms.Label
    Me.lblOpcion1 = New System.Windows.Forms.Label
    Me.txtDireccion = New System.Windows.Forms.TextBox
    Me.lblNombre = New System.Windows.Forms.Label
    Me.lblDireccion = New System.Windows.Forms.Label
    Me.lblApellidoPat = New System.Windows.Forms.Label
    Me.lblSexo = New System.Windows.Forms.Label
    Me.lblEjemplo = New System.Windows.Forms.Label
    Me.lblFechaNac = New System.Windows.Forms.Label
    Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker
    Me.º = New System.Windows.Forms.Label
    Me.lblEmail = New System.Windows.Forms.Label
    Me.txtEmail = New System.Windows.Forms.TextBox
    Me.txtNombre = New System.Windows.Forms.TextBox
    Me.txtCelular = New System.Windows.Forms.TextBox
    Me.txtApePat = New System.Windows.Forms.TextBox
    Me.cboSexo = New System.Windows.Forms.ComboBox
    Me.txtApeMat = New System.Windows.Forms.TextBox
    Me.gbGradoAcad = New System.Windows.Forms.GroupBox
    Me.lblGrado = New System.Windows.Forms.Label
    Me.cboEspecialidad = New System.Windows.Forms.ComboBox
    Me.cboGrado = New System.Windows.Forms.ComboBox
    Me.lblEspecialidad = New System.Windows.Forms.Label
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnGuardar = New System.Windows.Forms.Button
    Me.btnBuscar = New System.Windows.Forms.Button
    Me.errValida = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.lblMensaje = New System.Windows.Forms.Label
    Me.lblLeyenda = New System.Windows.Forms.Label
    Me.gbDatosPer.SuspendLayout()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbDocumentoIdent.SuspendLayout()
    Me.gbGradoAcad.SuspendLayout()
    CType(Me.errValida, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'gbDatosPer
    '
    Me.gbDatosPer.Controls.Add(Me.btnImagen)
    Me.gbDatosPer.Controls.Add(Me.PictureBox1)
    Me.gbDatosPer.Controls.Add(Me.gbDocumentoIdent)
    Me.gbDatosPer.Controls.Add(Me.lblOpcion2)
    Me.gbDatosPer.Controls.Add(Me.lblOpcion1)
    Me.gbDatosPer.Controls.Add(Me.txtDireccion)
    Me.gbDatosPer.Controls.Add(Me.lblNombre)
    Me.gbDatosPer.Controls.Add(Me.lblDireccion)
    Me.gbDatosPer.Controls.Add(Me.lblApellidoPat)
    Me.gbDatosPer.Controls.Add(Me.lblSexo)
    Me.gbDatosPer.Controls.Add(Me.lblEjemplo)
    Me.gbDatosPer.Controls.Add(Me.lblFechaNac)
    Me.gbDatosPer.Controls.Add(Me.dtpFechaNac)
    Me.gbDatosPer.Controls.Add(Me.º)
    Me.gbDatosPer.Controls.Add(Me.lblEmail)
    Me.gbDatosPer.Controls.Add(Me.txtEmail)
    Me.gbDatosPer.Controls.Add(Me.txtNombre)
    Me.gbDatosPer.Controls.Add(Me.txtCelular)
    Me.gbDatosPer.Controls.Add(Me.txtApePat)
    Me.gbDatosPer.Controls.Add(Me.cboSexo)
    Me.gbDatosPer.Controls.Add(Me.txtApeMat)
    Me.gbDatosPer.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbDatosPer.Location = New System.Drawing.Point(38, 94)
    Me.gbDatosPer.Name = "gbDatosPer"
    Me.gbDatosPer.Size = New System.Drawing.Size(636, 307)
    Me.gbDatosPer.TabIndex = 1
    Me.gbDatosPer.TabStop = False
    Me.gbDatosPer.Text = "Datos Personales"
    '
    'btnImagen
    '
    Me.btnImagen.Location = New System.Drawing.Point(490, 171)
    Me.btnImagen.Name = "btnImagen"
    Me.btnImagen.Size = New System.Drawing.Size(122, 24)
    Me.btnImagen.TabIndex = 21
    Me.btnImagen.Text = "Foto"
    Me.btnImagen.UseVisualStyleBackColor = True
    '
    'PictureBox1
    '
    Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
    Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.PictureBox1.Location = New System.Drawing.Point(490, 42)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(122, 126)
    Me.PictureBox1.TabIndex = 20
    Me.PictureBox1.TabStop = False
    '
    'gbDocumentoIdent
    '
    Me.gbDocumentoIdent.Controls.Add(Me.cboTipoDoc)
    Me.gbDocumentoIdent.Controls.Add(Me.lblTipoDoc)
    Me.gbDocumentoIdent.Controls.Add(Me.txtNroDoc)
    Me.gbDocumentoIdent.Controls.Add(Me.lblNroDoc)
    Me.gbDocumentoIdent.Location = New System.Drawing.Point(69, 33)
    Me.gbDocumentoIdent.Name = "gbDocumentoIdent"
    Me.gbDocumentoIdent.Size = New System.Drawing.Size(403, 48)
    Me.gbDocumentoIdent.TabIndex = 0
    Me.gbDocumentoIdent.TabStop = False
    Me.gbDocumentoIdent.Text = "Documento de Identidad"
    '
    'cboTipoDoc
    '
    Me.cboTipoDoc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboTipoDoc.FormattingEnabled = True
    Me.cboTipoDoc.Items.AddRange(New Object() {"DNI", "Carnet Extranjería", "Libreta Electoral", "Libreta Militar", "Pasaporte", "Carnet Policial"})
    Me.cboTipoDoc.Location = New System.Drawing.Point(55, 18)
    Me.cboTipoDoc.Name = "cboTipoDoc"
    Me.cboTipoDoc.Size = New System.Drawing.Size(151, 24)
    Me.cboTipoDoc.TabIndex = 1
    '
    'lblTipoDoc
    '
    Me.lblTipoDoc.AutoSize = True
    Me.lblTipoDoc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTipoDoc.Location = New System.Drawing.Point(14, 21)
    Me.lblTipoDoc.Name = "lblTipoDoc"
    Me.lblTipoDoc.Size = New System.Drawing.Size(35, 15)
    Me.lblTipoDoc.TabIndex = 0
    Me.lblTipoDoc.Text = "&Tipo "
    '
    'txtNroDoc
    '
    Me.txtNroDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtNroDoc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNroDoc.Location = New System.Drawing.Point(267, 18)
    Me.txtNroDoc.MaxLength = 11
    Me.txtNroDoc.Name = "txtNroDoc"
    Me.txtNroDoc.Size = New System.Drawing.Size(121, 22)
    Me.txtNroDoc.TabIndex = 3
    '
    'lblNroDoc
    '
    Me.lblNroDoc.AutoSize = True
    Me.lblNroDoc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNroDoc.Location = New System.Drawing.Point(213, 21)
    Me.lblNroDoc.Name = "lblNroDoc"
    Me.lblNroDoc.Size = New System.Drawing.Size(49, 15)
    Me.lblNroDoc.TabIndex = 2
    Me.lblNroDoc.Text = "Núme&ro"
    '
    'lblOpcion2
    '
    Me.lblOpcion2.AutoSize = True
    Me.lblOpcion2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblOpcion2.ForeColor = System.Drawing.Color.Gray
    Me.lblOpcion2.Location = New System.Drawing.Point(574, 268)
    Me.lblOpcion2.Name = "lblOpcion2"
    Me.lblOpcion2.Size = New System.Drawing.Size(41, 12)
    Me.lblOpcion2.TabIndex = 18
    Me.lblOpcion2.Text = "Opcional"
    '
    'lblOpcion1
    '
    Me.lblOpcion1.AutoSize = True
    Me.lblOpcion1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblOpcion1.ForeColor = System.Drawing.Color.Gray
    Me.lblOpcion1.Location = New System.Drawing.Point(183, 266)
    Me.lblOpcion1.Name = "lblOpcion1"
    Me.lblOpcion1.Size = New System.Drawing.Size(41, 12)
    Me.lblOpcion1.TabIndex = 15
    Me.lblOpcion1.Text = "Opcional"
    '
    'txtDireccion
    '
    Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtDireccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDireccion.Location = New System.Drawing.Point(83, 203)
    Me.txtDireccion.Name = "txtDireccion"
    Me.txtDireccion.Size = New System.Drawing.Size(529, 22)
    Me.txtDireccion.TabIndex = 12
    '
    'lblNombre
    '
    Me.lblNombre.AutoSize = True
    Me.lblNombre.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNombre.Location = New System.Drawing.Point(28, 104)
    Me.lblNombre.Name = "lblNombre"
    Me.lblNombre.Size = New System.Drawing.Size(49, 15)
    Me.lblNombre.TabIndex = 1
    Me.lblNombre.Text = "&Nombre"
    '
    'lblDireccion
    '
    Me.lblDireccion.AutoSize = True
    Me.lblDireccion.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDireccion.Location = New System.Drawing.Point(19, 205)
    Me.lblDireccion.Name = "lblDireccion"
    Me.lblDireccion.Size = New System.Drawing.Size(58, 15)
    Me.lblDireccion.TabIndex = 11
    Me.lblDireccion.Text = "&Dirección"
    '
    'lblApellidoPat
    '
    Me.lblApellidoPat.AutoSize = True
    Me.lblApellidoPat.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblApellidoPat.Location = New System.Drawing.Point(18, 138)
    Me.lblApellidoPat.Name = "lblApellidoPat"
    Me.lblApellidoPat.Size = New System.Drawing.Size(59, 15)
    Me.lblApellidoPat.TabIndex = 3
    Me.lblApellidoPat.Text = "Apellidos"
    '
    'lblSexo
    '
    Me.lblSexo.AutoSize = True
    Me.lblSexo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSexo.Location = New System.Drawing.Point(45, 172)
    Me.lblSexo.Name = "lblSexo"
    Me.lblSexo.Size = New System.Drawing.Size(32, 15)
    Me.lblSexo.TabIndex = 7
    Me.lblSexo.Text = "&Sexo"
    '
    'lblEjemplo
    '
    Me.lblEjemplo.AllowDrop = True
    Me.lblEjemplo.AutoSize = True
    Me.lblEjemplo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblEjemplo.Location = New System.Drawing.Point(377, 266)
    Me.lblEjemplo.Name = "lblEjemplo"
    Me.lblEjemplo.Size = New System.Drawing.Size(155, 14)
    Me.lblEjemplo.TabIndex = 19
    Me.lblEjemplo.Text = "Ejemplo: usuario@ejemplo.com"
    '
    'lblFechaNac
    '
    Me.lblFechaNac.AutoSize = True
    Me.lblFechaNac.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFechaNac.Location = New System.Drawing.Point(225, 173)
    Me.lblFechaNac.Name = "lblFechaNac"
    Me.lblFechaNac.Size = New System.Drawing.Size(102, 15)
    Me.lblFechaNac.TabIndex = 9
    Me.lblFechaNac.Text = "&Fecha Nacimiento"
    '
    'dtpFechaNac
    '
    Me.dtpFechaNac.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaNac.Location = New System.Drawing.Point(336, 170)
    Me.dtpFechaNac.Name = "dtpFechaNac"
    Me.dtpFechaNac.Size = New System.Drawing.Size(136, 22)
    Me.dtpFechaNac.TabIndex = 10
    '
    'º
    '
    Me.º.AutoSize = True
    Me.º.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.º.Location = New System.Drawing.Point(33, 243)
    Me.º.Name = "º"
    Me.º.Size = New System.Drawing.Size(44, 15)
    Me.º.TabIndex = 13
    Me.º.Text = "Cel&ular"
    '
    'lblEmail
    '
    Me.lblEmail.AutoSize = True
    Me.lblEmail.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblEmail.Location = New System.Drawing.Point(329, 243)
    Me.lblEmail.Name = "lblEmail"
    Me.lblEmail.Size = New System.Drawing.Size(39, 15)
    Me.lblEmail.TabIndex = 16
    Me.lblEmail.Text = "E-&mail"
    '
    'txtEmail
    '
    Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtEmail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtEmail.Location = New System.Drawing.Point(374, 239)
    Me.txtEmail.Name = "txtEmail"
    Me.txtEmail.Size = New System.Drawing.Size(238, 22)
    Me.txtEmail.TabIndex = 17
    '
    'txtNombre
    '
    Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNombre.Location = New System.Drawing.Point(83, 98)
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Size = New System.Drawing.Size(389, 22)
    Me.txtNombre.TabIndex = 2
    '
    'txtCelular
    '
    Me.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtCelular.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCelular.Location = New System.Drawing.Point(83, 239)
    Me.txtCelular.MaxLength = 11
    Me.txtCelular.Name = "txtCelular"
    Me.txtCelular.Size = New System.Drawing.Size(138, 22)
    Me.txtCelular.TabIndex = 14
    '
    'txtApePat
    '
    Me.txtApePat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtApePat.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtApePat.Location = New System.Drawing.Point(83, 134)
    Me.txtApePat.Name = "txtApePat"
    Me.txtApePat.Size = New System.Drawing.Size(192, 22)
    Me.txtApePat.TabIndex = 4
    '
    'cboSexo
    '
    Me.cboSexo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboSexo.FormattingEnabled = True
    Me.cboSexo.Items.AddRange(New Object() {"FEMENINO", "MASCULINO"})
    Me.cboSexo.Location = New System.Drawing.Point(82, 168)
    Me.cboSexo.Name = "cboSexo"
    Me.cboSexo.Size = New System.Drawing.Size(121, 24)
    Me.cboSexo.TabIndex = 8
    '
    'txtApeMat
    '
    Me.txtApeMat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtApeMat.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtApeMat.Location = New System.Drawing.Point(280, 134)
    Me.txtApeMat.Name = "txtApeMat"
    Me.txtApeMat.Size = New System.Drawing.Size(192, 22)
    Me.txtApeMat.TabIndex = 6
    '
    'gbGradoAcad
    '
    Me.gbGradoAcad.Controls.Add(Me.lblGrado)
    Me.gbGradoAcad.Controls.Add(Me.cboEspecialidad)
    Me.gbGradoAcad.Controls.Add(Me.cboGrado)
    Me.gbGradoAcad.Controls.Add(Me.lblEspecialidad)
    Me.gbGradoAcad.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbGradoAcad.Location = New System.Drawing.Point(38, 19)
    Me.gbGradoAcad.Name = "gbGradoAcad"
    Me.gbGradoAcad.Size = New System.Drawing.Size(636, 66)
    Me.gbGradoAcad.TabIndex = 0
    Me.gbGradoAcad.TabStop = False
    Me.gbGradoAcad.Text = "Grado Académico"
    '
    'lblGrado
    '
    Me.lblGrado.AutoSize = True
    Me.lblGrado.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblGrado.Location = New System.Drawing.Point(29, 29)
    Me.lblGrado.Name = "lblGrado"
    Me.lblGrado.Size = New System.Drawing.Size(39, 15)
    Me.lblGrado.TabIndex = 0
    Me.lblGrado.Text = "G&rado"
    '
    'cboEspecialidad
    '
    Me.cboEspecialidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cboEspecialidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboEspecialidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboEspecialidad.FormattingEnabled = True
    Me.cboEspecialidad.Location = New System.Drawing.Point(314, 26)
    Me.cboEspecialidad.Name = "cboEspecialidad"
    Me.cboEspecialidad.Size = New System.Drawing.Size(297, 24)
    Me.cboEspecialidad.TabIndex = 3
    '
    'cboGrado
    '
    Me.cboGrado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboGrado.FormattingEnabled = True
    Me.cboGrado.Items.AddRange(New Object() {"BACHILLER", "LICENCIADO", "DOCTOR", "MAGISTER", "PHD", "TECNICO"})
    Me.cboGrado.Location = New System.Drawing.Point(74, 26)
    Me.cboGrado.Name = "cboGrado"
    Me.cboGrado.Size = New System.Drawing.Size(143, 24)
    Me.cboGrado.TabIndex = 1
    '
    'lblEspecialidad
    '
    Me.lblEspecialidad.AutoSize = True
    Me.lblEspecialidad.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblEspecialidad.Location = New System.Drawing.Point(235, 29)
    Me.lblEspecialidad.Name = "lblEspecialidad"
    Me.lblEspecialidad.Size = New System.Drawing.Size(74, 15)
    Me.lblEspecialidad.TabIndex = 2
    Me.lblEspecialidad.Text = "&Especialidad"
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(714, 210)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
    Me.btnCancelar.TabIndex = 5
    Me.btnCancelar.Text = "&Deshacer"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnGuardar
    '
    Me.btnGuardar.BackColor = System.Drawing.Color.White
    Me.btnGuardar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnGuardar.Location = New System.Drawing.Point(714, 156)
    Me.btnGuardar.Name = "btnGuardar"
    Me.btnGuardar.Size = New System.Drawing.Size(110, 52)
    Me.btnGuardar.TabIndex = 2
    Me.btnGuardar.Text = "&Registrar"
    Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnGuardar.UseVisualStyleBackColor = False
    '
    'btnBuscar
    '
    Me.btnBuscar.BackColor = System.Drawing.Color.White
    Me.btnBuscar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscar.Location = New System.Drawing.Point(714, 102)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(110, 52)
    Me.btnBuscar.TabIndex = 3
    Me.btnBuscar.Text = "&Buscar"
    Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscar.UseVisualStyleBackColor = False
    '
    'errValida
    '
    Me.errValida.ContainerControl = Me
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(714, 349)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 6
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'lblMensaje
    '
    Me.lblMensaje.AutoSize = True
    Me.lblMensaje.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMensaje.ForeColor = System.Drawing.SystemColors.ActiveCaption
    Me.lblMensaje.Location = New System.Drawing.Point(34, 413)
    Me.lblMensaje.Name = "lblMensaje"
    Me.lblMensaje.Size = New System.Drawing.Size(415, 19)
    Me.lblMensaje.TabIndex = 7
    Me.lblMensaje.Text = "Click en Deshacer para anular la operación y volver a iniciar."
    '
    'lblLeyenda
    '
    Me.lblLeyenda.AutoSize = True
    Me.lblLeyenda.BackColor = System.Drawing.Color.LightSkyBlue
    Me.lblLeyenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblLeyenda.Location = New System.Drawing.Point(722, 30)
    Me.lblLeyenda.Name = "lblLeyenda"
    Me.lblLeyenda.Size = New System.Drawing.Size(96, 20)
    Me.lblLeyenda.TabIndex = 8
    Me.lblLeyenda.Text = "Buscar: F5"
    '
    'frmGestionDocente
    '
    Me.AcceptButton = Me.btnGuardar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(862, 441)
    Me.Controls.Add(Me.lblLeyenda)
    Me.Controls.Add(Me.lblMensaje)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnBuscar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.gbDatosPer)
    Me.Controls.Add(Me.btnGuardar)
    Me.Controls.Add(Me.gbGradoAcad)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.KeyPreview = True
    Me.MaximizeBox = False
    Me.Name = "frmGestionDocente"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de Docentes"
    Me.gbDatosPer.ResumeLayout(False)
    Me.gbDatosPer.PerformLayout()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbDocumentoIdent.ResumeLayout(False)
    Me.gbDocumentoIdent.PerformLayout()
    Me.gbGradoAcad.ResumeLayout(False)
    Me.gbGradoAcad.PerformLayout()
    CType(Me.errValida, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents º As System.Windows.Forms.Label
  Friend WithEvents lblFechaNac As System.Windows.Forms.Label
  Friend WithEvents lblSexo As System.Windows.Forms.Label
  Friend WithEvents lblApellidoPat As System.Windows.Forms.Label
  Friend WithEvents lblNombre As System.Windows.Forms.Label
  Friend WithEvents lblEspecialidad As System.Windows.Forms.Label
  Friend WithEvents lblGrado As System.Windows.Forms.Label
  Friend WithEvents lblEmail As System.Windows.Forms.Label
  Friend WithEvents txtCelular As System.Windows.Forms.TextBox
  Friend WithEvents cboSexo As System.Windows.Forms.ComboBox
  Friend WithEvents txtApeMat As System.Windows.Forms.TextBox
  Friend WithEvents txtApePat As System.Windows.Forms.TextBox
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents dtpFechaNac As System.Windows.Forms.DateTimePicker
  Friend WithEvents cboEspecialidad As System.Windows.Forms.ComboBox
  Friend WithEvents cboGrado As System.Windows.Forms.ComboBox
  Friend WithEvents txtEmail As System.Windows.Forms.TextBox
  Friend WithEvents btnGuardar As System.Windows.Forms.Button
  Friend WithEvents errValida As System.Windows.Forms.ErrorProvider
  Friend WithEvents lblEjemplo As System.Windows.Forms.Label
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
  Friend WithEvents txtNroDoc As System.Windows.Forms.TextBox
  Friend WithEvents lblNroDoc As System.Windows.Forms.Label
  Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
  Friend WithEvents lblDireccion As System.Windows.Forms.Label
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents lblTipoDoc As System.Windows.Forms.Label
  Friend WithEvents cboTipoDoc As System.Windows.Forms.ComboBox
  Friend WithEvents lblOpcion2 As System.Windows.Forms.Label
  Friend WithEvents lblOpcion1 As System.Windows.Forms.Label
  Friend WithEvents gbGradoAcad As System.Windows.Forms.GroupBox
  Friend WithEvents gbDatosPer As System.Windows.Forms.GroupBox
  Friend WithEvents gbDocumentoIdent As System.Windows.Forms.GroupBox
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents btnImagen As System.Windows.Forms.Button
  Friend WithEvents lblMensaje As System.Windows.Forms.Label
  Friend WithEvents lblLeyenda As System.Windows.Forms.Label
End Class
