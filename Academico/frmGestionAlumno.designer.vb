<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionAlumno
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
    Me.ErrAlumno = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.btnNuevo = New System.Windows.Forms.Button
    Me.btnpadres = New System.Windows.Forms.Button
    Me.GroupBoxDP = New System.Windows.Forms.GroupBox
    Me.txtmedcontra = New System.Windows.Forms.TextBox
    Me.txtcolegproced = New System.Windows.Forms.TextBox
    Me.Label18 = New System.Windows.Forms.Label
    Me.Label19 = New System.Windows.Forms.Label
    Me.cbolengmat = New System.Windows.Forms.ComboBox
    Me.Label20 = New System.Windows.Forms.Label
    Me.cbogrupoSang = New System.Windows.Forms.ComboBox
    Me.txtemail = New System.Windows.Forms.TextBox
    Me.Label21 = New System.Windows.Forms.Label
    Me.Label25 = New System.Windows.Forms.Label
    Me.cbonacionalidad = New System.Windows.Forms.ComboBox
    Me.txttelefono = New System.Windows.Forms.TextBox
    Me.Label22 = New System.Windows.Forms.Label
    Me.Label23 = New System.Windows.Forms.Label
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.btnGenerar = New System.Windows.Forms.Button
    Me.Label26 = New System.Windows.Forms.Label
    Me.dtpfechaN = New System.Windows.Forms.DateTimePicker
    Me.CLugarNac = New Colegio.IAcademico.ControlUbicacionGeografica
    Me.btnBuscar = New System.Windows.Forms.Button
    Me.cbosexo = New System.Windows.Forms.ComboBox
    Me.txtCodEducando = New System.Windows.Forms.TextBox
    Me.txtmat = New System.Windows.Forms.TextBox
    Me.txtpat = New System.Windows.Forms.TextBox
    Me.txtnombre = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label27 = New System.Windows.Forms.Label
    Me.Label29 = New System.Windows.Forms.Label
    Me.Label30 = New System.Windows.Forms.Label
    Me.gbDireccion = New System.Windows.Forms.GroupBox
    Me.txtdireccion = New System.Windows.Forms.TextBox
    Me.Label24 = New System.Windows.Forms.Label
    Me.CDireccionActual = New Colegio.IAcademico.ControlUbicacionGeografica
    Me.Label4 = New System.Windows.Forms.Label
    Me.txtDNI = New System.Windows.Forms.TextBox
    Me.lblDNI = New System.Windows.Forms.Label
    CType(Me.ErrAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBoxDP.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.gbDireccion.SuspendLayout()
    Me.SuspendLayout()
    '
    'ErrAlumno
    '
    Me.ErrAlumno.ContainerControl = Me
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.ErrAlumno.SetIconAlignment(Me.btnRegistrar, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(748, 284)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
    Me.btnRegistrar.TabIndex = 4
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'btnNuevo
    '
    Me.btnNuevo.BackColor = System.Drawing.Color.White
    Me.btnNuevo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.ErrAlumno.SetIconAlignment(Me.btnNuevo, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
    Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnNuevo.Location = New System.Drawing.Point(748, 211)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(110, 52)
    Me.btnNuevo.TabIndex = 3
    Me.btnNuevo.Text = "&Nuevo"
    Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnNuevo.UseVisualStyleBackColor = False
    '
    'btnpadres
    '
    Me.btnpadres.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnpadres.BackColor = System.Drawing.Color.White
    Me.btnpadres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
    Me.btnpadres.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnpadres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnpadres.Location = New System.Drawing.Point(748, 364)
    Me.btnpadres.Name = "btnpadres"
    Me.btnpadres.Size = New System.Drawing.Size(110, 52)
    Me.btnpadres.TabIndex = 5
    Me.btnpadres.Text = "&Padres"
    Me.btnpadres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnpadres.UseVisualStyleBackColor = False
    Me.btnpadres.Visible = False
    '
    'GroupBoxDP
    '
    Me.GroupBoxDP.Controls.Add(Me.txtmedcontra)
    Me.GroupBoxDP.Controls.Add(Me.txtcolegproced)
    Me.GroupBoxDP.Controls.Add(Me.Label18)
    Me.GroupBoxDP.Controls.Add(Me.Label19)
    Me.GroupBoxDP.Controls.Add(Me.cbolengmat)
    Me.GroupBoxDP.Controls.Add(Me.Label20)
    Me.GroupBoxDP.Controls.Add(Me.cbogrupoSang)
    Me.GroupBoxDP.Controls.Add(Me.txtemail)
    Me.GroupBoxDP.Controls.Add(Me.Label21)
    Me.GroupBoxDP.Controls.Add(Me.Label25)
    Me.GroupBoxDP.Controls.Add(Me.cbonacionalidad)
    Me.GroupBoxDP.Controls.Add(Me.txttelefono)
    Me.GroupBoxDP.Controls.Add(Me.Label22)
    Me.GroupBoxDP.Controls.Add(Me.Label23)
    Me.GroupBoxDP.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.GroupBoxDP.Location = New System.Drawing.Point(17, 438)
    Me.GroupBoxDP.Name = "GroupBoxDP"
    Me.GroupBoxDP.Size = New System.Drawing.Size(694, 232)
    Me.GroupBoxDP.TabIndex = 2
    Me.GroupBoxDP.TabStop = False
    Me.GroupBoxDP.Text = "Datos Personales"
    '
    'txtmedcontra
    '
    Me.txtmedcontra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtmedcontra.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.txtmedcontra.Location = New System.Drawing.Point(217, 91)
    Me.txtmedcontra.Multiline = True
    Me.txtmedcontra.Name = "txtmedcontra"
    Me.txtmedcontra.Size = New System.Drawing.Size(456, 65)
    Me.txtmedcontra.TabIndex = 9
    '
    'txtcolegproced
    '
    Me.txtcolegproced.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtcolegproced.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.txtcolegproced.Location = New System.Drawing.Point(217, 164)
    Me.txtcolegproced.Name = "txtcolegproced"
    Me.txtcolegproced.Size = New System.Drawing.Size(336, 22)
    Me.txtcolegproced.TabIndex = 11
    '
    'Label18
    '
    Me.Label18.AutoSize = True
    Me.Label18.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label18.Location = New System.Drawing.Point(91, 171)
    Me.Label18.Name = "Label18"
    Me.Label18.Size = New System.Drawing.Size(116, 15)
    Me.Label18.TabIndex = 10
    Me.Label18.Text = "Colegio Procedencia"
    '
    'Label19
    '
    Me.Label19.AutoSize = True
    Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label19.Location = New System.Drawing.Point(49, 91)
    Me.Label19.Name = "Label19"
    Me.Label19.Size = New System.Drawing.Size(153, 15)
    Me.Label19.TabIndex = 8
    Me.Label19.Text = "Medicinas Contraindicadas"
    '
    'cbolengmat
    '
    Me.cbolengmat.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.cbolengmat.FormattingEnabled = True
    Me.cbolengmat.Items.AddRange(New Object() {"Castellano", "Ingles", "Frances", "Italiano", "Aleman", "Japones", "Chino"})
    Me.cbolengmat.Location = New System.Drawing.Point(532, 52)
    Me.cbolengmat.Name = "cbolengmat"
    Me.cbolengmat.Size = New System.Drawing.Size(140, 23)
    Me.cbolengmat.TabIndex = 7
    '
    'Label20
    '
    Me.Label20.AutoSize = True
    Me.Label20.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label20.Location = New System.Drawing.Point(418, 60)
    Me.Label20.Name = "Label20"
    Me.Label20.Size = New System.Drawing.Size(95, 15)
    Me.Label20.TabIndex = 6
    Me.Label20.Text = "Lengua Materna"
    '
    'cbogrupoSang
    '
    Me.cbogrupoSang.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.cbogrupoSang.FormattingEnabled = True
    Me.cbogrupoSang.Items.AddRange(New Object() {"No Precisa", "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-"})
    Me.cbogrupoSang.Location = New System.Drawing.Point(532, 22)
    Me.cbogrupoSang.Name = "cbogrupoSang"
    Me.cbogrupoSang.Size = New System.Drawing.Size(140, 23)
    Me.cbogrupoSang.TabIndex = 3
    '
    'txtemail
    '
    Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtemail.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.txtemail.Location = New System.Drawing.Point(217, 194)
    Me.txtemail.MaxLength = 60
    Me.txtemail.Name = "txtemail"
    Me.txtemail.Size = New System.Drawing.Size(336, 22)
    Me.txtemail.TabIndex = 13
    '
    'Label21
    '
    Me.Label21.AutoSize = True
    Me.Label21.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label21.Location = New System.Drawing.Point(418, 30)
    Me.Label21.Name = "Label21"
    Me.Label21.Size = New System.Drawing.Size(100, 15)
    Me.Label21.TabIndex = 2
    Me.Label21.Text = "Grupo Sanguineo"
    '
    'Label25
    '
    Me.Label25.AutoSize = True
    Me.Label25.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label25.Location = New System.Drawing.Point(167, 201)
    Me.Label25.Name = "Label25"
    Me.Label25.Size = New System.Drawing.Size(35, 15)
    Me.Label25.TabIndex = 12
    Me.Label25.Text = "Email"
    '
    'cbonacionalidad
    '
    Me.cbonacionalidad.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.cbonacionalidad.FormattingEnabled = True
    Me.cbonacionalidad.Location = New System.Drawing.Point(157, 52)
    Me.cbonacionalidad.Name = "cbonacionalidad"
    Me.cbonacionalidad.Size = New System.Drawing.Size(140, 23)
    Me.cbonacionalidad.TabIndex = 5
    '
    'txttelefono
    '
    Me.txttelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txttelefono.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.txttelefono.Location = New System.Drawing.Point(157, 22)
    Me.txttelefono.MaxLength = 12
    Me.txttelefono.Name = "txttelefono"
    Me.txttelefono.Size = New System.Drawing.Size(141, 22)
    Me.txttelefono.TabIndex = 1
    '
    'Label22
    '
    Me.Label22.AutoSize = True
    Me.Label22.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label22.Location = New System.Drawing.Point(49, 60)
    Me.Label22.Name = "Label22"
    Me.Label22.Size = New System.Drawing.Size(77, 15)
    Me.Label22.TabIndex = 4
    Me.Label22.Text = "Nacionalidad"
    '
    'Label23
    '
    Me.Label23.AutoSize = True
    Me.Label23.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label23.Location = New System.Drawing.Point(72, 30)
    Me.Label23.Name = "Label23"
    Me.Label23.Size = New System.Drawing.Size(54, 15)
    Me.Label23.TabIndex = 0
    Me.Label23.Text = "Teléfono"
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(748, 619)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 6
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(748, 441)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
    Me.btnCancelar.TabIndex = 6
    Me.btnCancelar.Text = "&Deshacer"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.txtDNI)
    Me.GroupBox2.Controls.Add(Me.lblDNI)
    Me.GroupBox2.Controls.Add(Me.btnGenerar)
    Me.GroupBox2.Controls.Add(Me.Label26)
    Me.GroupBox2.Controls.Add(Me.dtpfechaN)
    Me.GroupBox2.Controls.Add(Me.CLugarNac)
    Me.GroupBox2.Controls.Add(Me.btnBuscar)
    Me.GroupBox2.Controls.Add(Me.cbosexo)
    Me.GroupBox2.Controls.Add(Me.txtCodEducando)
    Me.GroupBox2.Controls.Add(Me.txtmat)
    Me.GroupBox2.Controls.Add(Me.txtpat)
    Me.GroupBox2.Controls.Add(Me.txtnombre)
    Me.GroupBox2.Controls.Add(Me.Label2)
    Me.GroupBox2.Controls.Add(Me.Label27)
    Me.GroupBox2.Controls.Add(Me.Label29)
    Me.GroupBox2.Controls.Add(Me.Label30)
    Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.GroupBox2.Location = New System.Drawing.Point(17, 11)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(694, 269)
    Me.GroupBox2.TabIndex = 0
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Datos Alumno"
    '
    'btnGenerar
    '
    Me.btnGenerar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnGenerar.BackColor = System.Drawing.Color.White
    Me.btnGenerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
    Me.btnGenerar.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnGenerar.Location = New System.Drawing.Point(306, 117)
    Me.btnGenerar.Name = "btnGenerar"
    Me.btnGenerar.Size = New System.Drawing.Size(83, 22)
    Me.btnGenerar.TabIndex = 11
    Me.btnGenerar.Text = "&Generar"
    Me.btnGenerar.UseVisualStyleBackColor = False
    Me.btnGenerar.Visible = False
    '
    'Label26
    '
    Me.Label26.AutoSize = True
    Me.Label26.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label26.Location = New System.Drawing.Point(19, 159)
    Me.Label26.Name = "Label26"
    Me.Label26.Size = New System.Drawing.Size(102, 15)
    Me.Label26.TabIndex = 12
    Me.Label26.Text = "Fecha Nacimiento"
    '
    'dtpfechaN
    '
    Me.dtpfechaN.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.dtpfechaN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpfechaN.Location = New System.Drawing.Point(159, 152)
    Me.dtpfechaN.Name = "dtpfechaN"
    Me.dtpfechaN.Size = New System.Drawing.Size(140, 22)
    Me.dtpfechaN.TabIndex = 13
    Me.dtpfechaN.Value = New Date(1995, 1, 1, 0, 0, 0, 0)
    '
    'CLugarNac
    '
    Me.CLugarNac.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.CLugarNac.Location = New System.Drawing.Point(77, 162)
    Me.CLugarNac.Name = "CLugarNac"
    Me.CLugarNac.Size = New System.Drawing.Size(593, 103)
    Me.CLugarNac.TabIndex = 14
    '
    'btnBuscar
    '
    Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnBuscar.BackColor = System.Drawing.Color.White
    Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
    Me.btnBuscar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscar.Location = New System.Drawing.Point(588, 23)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(83, 32)
    Me.btnBuscar.TabIndex = 0
    Me.btnBuscar.TabStop = False
    Me.btnBuscar.Text = "&Buscar"
    Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscar.UseVisualStyleBackColor = False
    '
    'cbosexo
    '
    Me.cbosexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cbosexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cbosexo.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.cbosexo.FormattingEnabled = True
    Me.cbosexo.Items.AddRange(New Object() {"Femenino", "Masculino"})
    Me.cbosexo.Location = New System.Drawing.Point(160, 88)
    Me.cbosexo.Name = "cbosexo"
    Me.cbosexo.Size = New System.Drawing.Size(140, 23)
    Me.cbosexo.TabIndex = 6
    '
    'txtCodEducando
    '
    Me.txtCodEducando.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtCodEducando.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.txtCodEducando.Location = New System.Drawing.Point(159, 117)
    Me.txtCodEducando.MaxLength = 14
    Me.txtCodEducando.Name = "txtCodEducando"
    Me.txtCodEducando.Size = New System.Drawing.Size(141, 22)
    Me.txtCodEducando.TabIndex = 10
    '
    'txtmat
    '
    Me.txtmat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtmat.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.txtmat.Location = New System.Drawing.Point(415, 59)
    Me.txtmat.Name = "txtmat"
    Me.txtmat.Size = New System.Drawing.Size(256, 22)
    Me.txtmat.TabIndex = 4
    '
    'txtpat
    '
    Me.txtpat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtpat.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.txtpat.Location = New System.Drawing.Point(159, 59)
    Me.txtpat.Name = "txtpat"
    Me.txtpat.Size = New System.Drawing.Size(250, 22)
    Me.txtpat.TabIndex = 3
    '
    'txtnombre
    '
    Me.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtnombre.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.txtnombre.Location = New System.Drawing.Point(159, 30)
    Me.txtnombre.Name = "txtnombre"
    Me.txtnombre.Size = New System.Drawing.Size(423, 22)
    Me.txtnombre.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label2.Location = New System.Drawing.Point(23, 124)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(106, 15)
    Me.Label2.TabIndex = 9
    Me.Label2.Text = "Código Educando "
    '
    'Label27
    '
    Me.Label27.AutoSize = True
    Me.Label27.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label27.Location = New System.Drawing.Point(91, 96)
    Me.Label27.Name = "Label27"
    Me.Label27.Size = New System.Drawing.Size(32, 15)
    Me.Label27.TabIndex = 5
    Me.Label27.Text = "Sexo"
    '
    'Label29
    '
    Me.Label29.AutoSize = True
    Me.Label29.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label29.Location = New System.Drawing.Point(77, 66)
    Me.Label29.Name = "Label29"
    Me.Label29.Size = New System.Drawing.Size(59, 15)
    Me.Label29.TabIndex = 2
    Me.Label29.Text = "Apellidos"
    '
    'Label30
    '
    Me.Label30.AutoSize = True
    Me.Label30.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label30.Location = New System.Drawing.Point(76, 37)
    Me.Label30.Name = "Label30"
    Me.Label30.Size = New System.Drawing.Size(55, 15)
    Me.Label30.TabIndex = 0
    Me.Label30.Text = "Nombres"
    '
    'gbDireccion
    '
    Me.gbDireccion.Controls.Add(Me.txtdireccion)
    Me.gbDireccion.Controls.Add(Me.Label24)
    Me.gbDireccion.Controls.Add(Me.CDireccionActual)
    Me.gbDireccion.Location = New System.Drawing.Point(17, 286)
    Me.gbDireccion.Name = "gbDireccion"
    Me.gbDireccion.Size = New System.Drawing.Size(694, 149)
    Me.gbDireccion.TabIndex = 1
    Me.gbDireccion.TabStop = False
    Me.gbDireccion.Text = "Dirección"
    '
    'txtdireccion
    '
    Me.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtdireccion.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.txtdireccion.Location = New System.Drawing.Point(159, 21)
    Me.txtdireccion.Name = "txtdireccion"
    Me.txtdireccion.Size = New System.Drawing.Size(512, 22)
    Me.txtdireccion.TabIndex = 1
    '
    'Label24
    '
    Me.Label24.AutoSize = True
    Me.Label24.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label24.Location = New System.Drawing.Point(48, 28)
    Me.Label24.Name = "Label24"
    Me.Label24.Size = New System.Drawing.Size(58, 15)
    Me.Label24.TabIndex = 0
    Me.Label24.Text = "Dirección"
    '
    'CDireccionActual
    '
    Me.CDireccionActual.AccessibleDescription = ""
    Me.CDireccionActual.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.CDireccionActual.Location = New System.Drawing.Point(79, 31)
    Me.CDireccionActual.Name = "CDireccionActual"
    Me.CDireccionActual.Size = New System.Drawing.Size(594, 99)
    Me.CDireccionActual.TabIndex = 2
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.Label4.Location = New System.Drawing.Point(730, 70)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(140, 19)
    Me.Label4.TabIndex = 8
    Me.Label4.Text = "F3 : Buscar Alumno"
    '
    'txtDNI
    '
    Me.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtDNI.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.txtDNI.Location = New System.Drawing.Point(415, 88)
    Me.txtDNI.MaxLength = 14
    Me.txtDNI.Name = "txtDNI"
    Me.txtDNI.Size = New System.Drawing.Size(141, 22)
    Me.txtDNI.TabIndex = 8
    '
    'lblDNI
    '
    Me.lblDNI.AutoSize = True
    Me.lblDNI.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.lblDNI.Location = New System.Drawing.Point(380, 95)
    Me.lblDNI.Name = "lblDNI"
    Me.lblDNI.Size = New System.Drawing.Size(29, 15)
    Me.lblDNI.TabIndex = 7
    Me.lblDNI.Text = "DNI"
    '
    'frmGestionAlumno
    '
    Me.AcceptButton = Me.btnRegistrar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(884, 684)
    Me.Controls.Add(Me.btnNuevo)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.gbDireccion)
    Me.Controls.Add(Me.btnpadres)
    Me.Controls.Add(Me.GroupBoxDP)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.GroupBox2)
    Me.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.KeyPreview = True
    Me.MaximizeBox = False
    Me.Name = "frmGestionAlumno"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de Alumnos"
    CType(Me.ErrAlumno, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBoxDP.ResumeLayout(False)
    Me.GroupBoxDP.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.gbDireccion.ResumeLayout(False)
    Me.gbDireccion.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents ErrAlumno As System.Windows.Forms.ErrorProvider
  Friend WithEvents btnpadres As System.Windows.Forms.Button
  Friend WithEvents GroupBoxDP As System.Windows.Forms.GroupBox
  Friend WithEvents txtmedcontra As System.Windows.Forms.TextBox
  Friend WithEvents txtcolegproced As System.Windows.Forms.TextBox
  Friend WithEvents Label18 As System.Windows.Forms.Label
  Friend WithEvents Label19 As System.Windows.Forms.Label
  Friend WithEvents cbolengmat As System.Windows.Forms.ComboBox
  Friend WithEvents Label20 As System.Windows.Forms.Label
  Friend WithEvents cbogrupoSang As System.Windows.Forms.ComboBox
  Friend WithEvents txtemail As System.Windows.Forms.TextBox
  Friend WithEvents Label21 As System.Windows.Forms.Label
  Friend WithEvents Label25 As System.Windows.Forms.Label
  Friend WithEvents cbonacionalidad As System.Windows.Forms.ComboBox
  Friend WithEvents txttelefono As System.Windows.Forms.TextBox
  Friend WithEvents Label22 As System.Windows.Forms.Label
  Friend WithEvents Label23 As System.Windows.Forms.Label
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents Label26 As System.Windows.Forms.Label
  Friend WithEvents dtpfechaN As System.Windows.Forms.DateTimePicker
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
  Friend WithEvents cbosexo As System.Windows.Forms.ComboBox
  Friend WithEvents txtCodEducando As System.Windows.Forms.TextBox
  Friend WithEvents txtmat As System.Windows.Forms.TextBox
  Friend WithEvents txtpat As System.Windows.Forms.TextBox
  Friend WithEvents txtnombre As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label27 As System.Windows.Forms.Label
  Friend WithEvents Label29 As System.Windows.Forms.Label
  Friend WithEvents Label30 As System.Windows.Forms.Label
  Friend WithEvents gbDireccion As System.Windows.Forms.GroupBox
  Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
  Friend WithEvents Label24 As System.Windows.Forms.Label
  Friend WithEvents CDireccionActual As Colegio.IAcademico.ControlUbicacionGeografica
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents btnGenerar As System.Windows.Forms.Button
  Public WithEvents CLugarNac As Colegio.IAcademico.ControlUbicacionGeografica
  Friend WithEvents txtDNI As System.Windows.Forms.TextBox
  Friend WithEvents lblDNI As System.Windows.Forms.Label
End Class
