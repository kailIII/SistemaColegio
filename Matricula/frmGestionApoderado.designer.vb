<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionApoderado
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
    Me.ErrorApoderado = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.btnEditar = New System.Windows.Forms.Button()
    Me.GroupBoxAlumno = New System.Windows.Forms.GroupBox()
    Me.btnBuscarAlumno = New System.Windows.Forms.Button()
    Me.txtAlumno = New System.Windows.Forms.TextBox()
    Me.lblAlumno = New System.Windows.Forms.Label()
    Me.btnNuevo = New System.Windows.Forms.Button()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.btnRegistrar = New System.Windows.Forms.Button()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.gbLuganNac = New System.Windows.Forms.GroupBox()
    Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker()
    Me.Label14 = New System.Windows.Forms.Label()
    Me.CDireccionActual = New Colegio.IAcademico.ControlUbicacionGeografica()
    Me.gbDP = New System.Windows.Forms.GroupBox()
    Me.cboTipoParentesco = New System.Windows.Forms.ComboBox()
    Me.cboxTutor = New System.Windows.Forms.CheckBox()
    Me.cboEstadoCivil = New System.Windows.Forms.ComboBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.cboProfesion = New System.Windows.Forms.ComboBox()
    Me.lblProfesion = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cboOcupacion = New System.Windows.Forms.ComboBox()
    Me.cbogradoInst = New System.Windows.Forms.ComboBox()
    Me.Label19 = New System.Windows.Forms.Label()
    Me.cboVive = New System.Windows.Forms.ComboBox()
    Me.Label25 = New System.Windows.Forms.Label()
    Me.txtlugarTrabajo = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.btnBuscarPersonas = New System.Windows.Forms.Button()
    Me.txtTelefTrabajo = New System.Windows.Forms.TextBox()
    Me.cboSexo = New System.Windows.Forms.ComboBox()
    Me.Label15 = New System.Windows.Forms.Label()
    Me.cboParentesco = New System.Windows.Forms.ComboBox()
    Me.txtemail = New System.Windows.Forms.TextBox()
    Me.Label31 = New System.Windows.Forms.Label()
    Me.txtcelular = New System.Windows.Forms.TextBox()
    Me.txtTelefcasa = New System.Windows.Forms.TextBox()
    Me.txtdireccion = New System.Windows.Forms.TextBox()
    Me.txtNroDoc = New System.Windows.Forms.TextBox()
    Me.cbotipoDoc = New System.Windows.Forms.ComboBox()
    Me.Label16 = New System.Windows.Forms.Label()
    Me.Label34 = New System.Windows.Forms.Label()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.txtmat = New System.Windows.Forms.TextBox()
    Me.txtpat = New System.Windows.Forms.TextBox()
    Me.txtnombre = New System.Windows.Forms.TextBox()
    Me.Label17 = New System.Windows.Forms.Label()
    Me.Label18 = New System.Windows.Forms.Label()
    Me.Label22 = New System.Windows.Forms.Label()
    Me.Label23 = New System.Windows.Forms.Label()
    Me.Label24 = New System.Windows.Forms.Label()
    Me.Label33 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    CType(Me.ErrorApoderado, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBoxAlumno.SuspendLayout()
    Me.gbLuganNac.SuspendLayout()
    Me.gbDP.SuspendLayout()
    Me.SuspendLayout()
    '
    'ErrorApoderado
    '
    Me.ErrorApoderado.ContainerControl = Me
    '
    'btnEditar
    '
    Me.btnEditar.BackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.btnEditar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnEditar.Location = New System.Drawing.Point(827, 221)
    Me.btnEditar.Name = "btnEditar"
    Me.btnEditar.Size = New System.Drawing.Size(110, 52)
    Me.btnEditar.TabIndex = 2
    Me.btnEditar.Text = "&Editar"
    Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnEditar.UseVisualStyleBackColor = False
    '
    'GroupBoxAlumno
    '
    Me.GroupBoxAlumno.Controls.Add(Me.btnBuscarAlumno)
    Me.GroupBoxAlumno.Controls.Add(Me.txtAlumno)
    Me.GroupBoxAlumno.Controls.Add(Me.lblAlumno)
    Me.GroupBoxAlumno.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.GroupBoxAlumno.Location = New System.Drawing.Point(16, 8)
    Me.GroupBoxAlumno.Name = "GroupBoxAlumno"
    Me.GroupBoxAlumno.Size = New System.Drawing.Size(779, 55)
    Me.GroupBoxAlumno.TabIndex = 0
    Me.GroupBoxAlumno.TabStop = False
    Me.GroupBoxAlumno.Text = "Alumno"
    '
    'btnBuscarAlumno
    '
    Me.btnBuscarAlumno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnBuscarAlumno.BackColor = System.Drawing.Color.White
    Me.btnBuscarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
    Me.btnBuscarAlumno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnBuscarAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscarAlumno.Location = New System.Drawing.Point(689, 15)
    Me.btnBuscarAlumno.Name = "btnBuscarAlumno"
    Me.btnBuscarAlumno.Size = New System.Drawing.Size(83, 32)
    Me.btnBuscarAlumno.TabIndex = 2
    Me.btnBuscarAlumno.Text = "&Buscar"
    Me.btnBuscarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscarAlumno.UseVisualStyleBackColor = False
    Me.btnBuscarAlumno.Visible = False
    '
    'txtAlumno
    '
    Me.txtAlumno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtAlumno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAlumno.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAlumno.ForeColor = System.Drawing.Color.Navy
    Me.txtAlumno.Location = New System.Drawing.Point(155, 20)
    Me.txtAlumno.Name = "txtAlumno"
    Me.txtAlumno.ReadOnly = True
    Me.txtAlumno.Size = New System.Drawing.Size(527, 22)
    Me.txtAlumno.TabIndex = 1
    '
    'lblAlumno
    '
    Me.lblAlumno.AutoSize = True
    Me.lblAlumno.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.lblAlumno.Location = New System.Drawing.Point(63, 24)
    Me.lblAlumno.Name = "lblAlumno"
    Me.lblAlumno.Size = New System.Drawing.Size(63, 15)
    Me.lblAlumno.TabIndex = 0
    Me.lblAlumno.Text = "ALUMNO"
    '
    'btnNuevo
    '
    Me.btnNuevo.BackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.btnNuevo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnNuevo.Location = New System.Drawing.Point(827, 288)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(110, 52)
    Me.btnNuevo.TabIndex = 3
    Me.btnNuevo.Text = "&Nuevo"
    Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnNuevo.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(827, 546)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 6
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(827, 354)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
    Me.btnRegistrar.TabIndex = 4
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(827, 422)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
    Me.btnCancelar.TabIndex = 5
    Me.btnCancelar.Text = "&Deshacer"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'gbLuganNac
    '
    Me.gbLuganNac.Controls.Add(Me.dtpFechaNac)
    Me.gbLuganNac.Controls.Add(Me.Label14)
    Me.gbLuganNac.Controls.Add(Me.CDireccionActual)
    Me.gbLuganNac.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.gbLuganNac.Location = New System.Drawing.Point(6, 154)
    Me.gbLuganNac.Name = "gbLuganNac"
    Me.gbLuganNac.Size = New System.Drawing.Size(676, 172)
    Me.gbLuganNac.TabIndex = 14
    Me.gbLuganNac.TabStop = False
    Me.gbLuganNac.Text = "Lugar de Nacimiento"
    '
    'dtpFechaNac
    '
    Me.dtpFechaNac.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaNac.Location = New System.Drawing.Point(155, 29)
    Me.dtpFechaNac.Name = "dtpFechaNac"
    Me.dtpFechaNac.Size = New System.Drawing.Size(181, 22)
    Me.dtpFechaNac.TabIndex = 1
    Me.dtpFechaNac.Value = New Date(1970, 1, 1, 0, 0, 0, 0)
    '
    'Label14
    '
    Me.Label14.AutoSize = True
    Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label14.Location = New System.Drawing.Point(22, 29)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(102, 15)
    Me.Label14.TabIndex = 0
    Me.Label14.Text = "Fecha Nacimiento"
    '
    'CDireccionActual
    '
    Me.CDireccionActual.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.CDireccionActual.Location = New System.Drawing.Point(71, 49)
    Me.CDireccionActual.Name = "CDireccionActual"
    Me.CDireccionActual.Size = New System.Drawing.Size(585, 117)
    Me.CDireccionActual.TabIndex = 2
    '
    'gbDP
    '
    Me.gbDP.Controls.Add(Me.cboTipoParentesco)
    Me.gbDP.Controls.Add(Me.cboxTutor)
    Me.gbDP.Controls.Add(Me.cboEstadoCivil)
    Me.gbDP.Controls.Add(Me.Label3)
    Me.gbDP.Controls.Add(Me.cboProfesion)
    Me.gbDP.Controls.Add(Me.lblProfesion)
    Me.gbDP.Controls.Add(Me.Label1)
    Me.gbDP.Controls.Add(Me.gbLuganNac)
    Me.gbDP.Controls.Add(Me.cboOcupacion)
    Me.gbDP.Controls.Add(Me.cbogradoInst)
    Me.gbDP.Controls.Add(Me.Label19)
    Me.gbDP.Controls.Add(Me.cboVive)
    Me.gbDP.Controls.Add(Me.Label25)
    Me.gbDP.Controls.Add(Me.txtlugarTrabajo)
    Me.gbDP.Controls.Add(Me.Label2)
    Me.gbDP.Controls.Add(Me.btnBuscarPersonas)
    Me.gbDP.Controls.Add(Me.txtTelefTrabajo)
    Me.gbDP.Controls.Add(Me.cboSexo)
    Me.gbDP.Controls.Add(Me.Label15)
    Me.gbDP.Controls.Add(Me.cboParentesco)
    Me.gbDP.Controls.Add(Me.txtemail)
    Me.gbDP.Controls.Add(Me.Label31)
    Me.gbDP.Controls.Add(Me.txtcelular)
    Me.gbDP.Controls.Add(Me.txtTelefcasa)
    Me.gbDP.Controls.Add(Me.txtdireccion)
    Me.gbDP.Controls.Add(Me.txtNroDoc)
    Me.gbDP.Controls.Add(Me.cbotipoDoc)
    Me.gbDP.Controls.Add(Me.Label16)
    Me.gbDP.Controls.Add(Me.Label34)
    Me.gbDP.Controls.Add(Me.Label12)
    Me.gbDP.Controls.Add(Me.txtmat)
    Me.gbDP.Controls.Add(Me.txtpat)
    Me.gbDP.Controls.Add(Me.txtnombre)
    Me.gbDP.Controls.Add(Me.Label17)
    Me.gbDP.Controls.Add(Me.Label18)
    Me.gbDP.Controls.Add(Me.Label22)
    Me.gbDP.Controls.Add(Me.Label23)
    Me.gbDP.Controls.Add(Me.Label24)
    Me.gbDP.Controls.Add(Me.Label33)
    Me.gbDP.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbDP.Location = New System.Drawing.Point(16, 67)
    Me.gbDP.Name = "gbDP"
    Me.gbDP.Size = New System.Drawing.Size(779, 597)
    Me.gbDP.TabIndex = 1
    Me.gbDP.TabStop = False
    Me.gbDP.Text = "Datos Personales"
    '
    'cboTipoParentesco
    '
    Me.cboTipoParentesco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cboTipoParentesco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboTipoParentesco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoParentesco.FormattingEnabled = True
    Me.cboTipoParentesco.Items.AddRange(New Object() {"MADRE", "PADRE", "TIA(O)", "ABUELA(O)", "PRIMA(O)"})
    Me.cboTipoParentesco.Location = New System.Drawing.Point(155, 19)
    Me.cboTipoParentesco.Name = "cboTipoParentesco"
    Me.cboTipoParentesco.Size = New System.Drawing.Size(174, 23)
    Me.cboTipoParentesco.TabIndex = 1
    Me.cboTipoParentesco.Visible = False
    '
    'cboxTutor
    '
    Me.cboxTutor.AutoSize = True
    Me.cboxTutor.Enabled = False
    Me.cboxTutor.Location = New System.Drawing.Point(337, 26)
    Me.cboxTutor.Name = "cboxTutor"
    Me.cboxTutor.Size = New System.Drawing.Size(56, 19)
    Me.cboxTutor.TabIndex = 2
    Me.cboxTutor.Text = "Tutor"
    Me.cboxTutor.UseVisualStyleBackColor = True
    Me.cboxTutor.Visible = False
    '
    'cboEstadoCivil
    '
    Me.cboEstadoCivil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cboEstadoCivil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboEstadoCivil.FormattingEnabled = True
    Me.cboEstadoCivil.Items.AddRange(New Object() {"SOLTERO(a)", "CASADO(a)", "VIUDO(a)", "DIVORCIADO(a)", "CONVIVIENTE", "SEPARADO(a)"})
    Me.cboEstadoCivil.Location = New System.Drawing.Point(507, 22)
    Me.cboEstadoCivil.Name = "cboEstadoCivil"
    Me.cboEstadoCivil.Size = New System.Drawing.Size(174, 23)
    Me.cboEstadoCivil.TabIndex = 4
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(427, 27)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(71, 15)
    Me.Label3.TabIndex = 3
    Me.Label3.Text = "Estado Civil"
    '
    'cboProfesion
    '
    Me.cboProfesion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cboProfesion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboProfesion.FormattingEnabled = True
    Me.cboProfesion.Location = New System.Drawing.Point(497, 451)
    Me.cboProfesion.Name = "cboProfesion"
    Me.cboProfesion.Size = New System.Drawing.Size(185, 23)
    Me.cboProfesion.TabIndex = 30
    '
    'lblProfesion
    '
    Me.lblProfesion.AutoSize = True
    Me.lblProfesion.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.lblProfesion.Location = New System.Drawing.Point(417, 459)
    Me.lblProfesion.Name = "lblProfesion"
    Me.lblProfesion.Size = New System.Drawing.Size(58, 15)
    Me.lblProfesion.TabIndex = 29
    Me.lblProfesion.Text = "Profesión"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label1.Location = New System.Drawing.Point(23, 456)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(103, 15)
    Me.Label1.TabIndex = 27
    Me.Label1.Text = "Grado Instrucción"
    '
    'cboOcupacion
    '
    Me.cboOcupacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cboOcupacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboOcupacion.FormattingEnabled = True
    Me.cboOcupacion.Location = New System.Drawing.Point(155, 488)
    Me.cboOcupacion.Name = "cboOcupacion"
    Me.cboOcupacion.Size = New System.Drawing.Size(181, 23)
    Me.cboOcupacion.TabIndex = 32
    '
    'cbogradoInst
    '
    Me.cbogradoInst.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cbogradoInst.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cbogradoInst.FormattingEnabled = True
    Me.cbogradoInst.Items.AddRange(New Object() {"NINGUNA", "PRIMARIA", "SECUNDARIA", "UNIVERSITARIA", "TECNICA"})
    Me.cbogradoInst.Location = New System.Drawing.Point(155, 450)
    Me.cbogradoInst.Name = "cbogradoInst"
    Me.cbogradoInst.Size = New System.Drawing.Size(181, 23)
    Me.cbogradoInst.TabIndex = 28
    '
    'Label19
    '
    Me.Label19.AutoSize = True
    Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label19.Location = New System.Drawing.Point(438, 336)
    Me.Label19.Name = "Label19"
    Me.Label19.Size = New System.Drawing.Size(34, 15)
    Me.Label19.TabIndex = 17
    Me.Label19.Text = "Vive "
    '
    'cboVive
    '
    Me.cboVive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboVive.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboVive.FormattingEnabled = True
    Me.cboVive.Items.AddRange(New Object() {"No", "Si"})
    Me.cboVive.Location = New System.Drawing.Point(497, 332)
    Me.cboVive.Name = "cboVive"
    Me.cboVive.Size = New System.Drawing.Size(184, 23)
    Me.cboVive.TabIndex = 18
    '
    'Label25
    '
    Me.Label25.AutoSize = True
    Me.Label25.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label25.Location = New System.Drawing.Point(61, 495)
    Me.Label25.Name = "Label25"
    Me.Label25.Size = New System.Drawing.Size(65, 15)
    Me.Label25.TabIndex = 31
    Me.Label25.Text = "Ocupación"
    '
    'txtlugarTrabajo
    '
    Me.txtlugarTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtlugarTrabajo.Location = New System.Drawing.Point(155, 525)
    Me.txtlugarTrabajo.MaxLength = 120
    Me.txtlugarTrabajo.Name = "txtlugarTrabajo"
    Me.txtlugarTrabajo.Size = New System.Drawing.Size(527, 22)
    Me.txtlugarTrabajo.TabIndex = 34
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label2.Location = New System.Drawing.Point(28, 533)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(98, 15)
    Me.Label2.TabIndex = 33
    Me.Label2.Text = "Lugar de Trabajo"
    '
    'btnBuscarPersonas
    '
    Me.btnBuscarPersonas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnBuscarPersonas.BackColor = System.Drawing.Color.White
    Me.btnBuscarPersonas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
    Me.btnBuscarPersonas.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnBuscarPersonas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscarPersonas.Location = New System.Drawing.Point(689, 51)
    Me.btnBuscarPersonas.Name = "btnBuscarPersonas"
    Me.btnBuscarPersonas.Size = New System.Drawing.Size(83, 32)
    Me.btnBuscarPersonas.TabIndex = 37
    Me.btnBuscarPersonas.Text = "&Buscar"
    Me.btnBuscarPersonas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscarPersonas.UseVisualStyleBackColor = False
    '
    'txtTelefTrabajo
    '
    Me.txtTelefTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtTelefTrabajo.Location = New System.Drawing.Point(155, 555)
    Me.txtTelefTrabajo.MaxLength = 12
    Me.txtTelefTrabajo.Name = "txtTelefTrabajo"
    Me.txtTelefTrabajo.Size = New System.Drawing.Size(181, 22)
    Me.txtTelefTrabajo.TabIndex = 36
    '
    'cboSexo
    '
    Me.cboSexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cboSexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSexo.FormattingEnabled = True
    Me.cboSexo.Items.AddRange(New Object() {"FEMENINO", "MASCULINO"})
    Me.cboSexo.Location = New System.Drawing.Point(155, 332)
    Me.cboSexo.Name = "cboSexo"
    Me.cboSexo.Size = New System.Drawing.Size(181, 23)
    Me.cboSexo.TabIndex = 16
    '
    'Label15
    '
    Me.Label15.AutoSize = True
    Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label15.Location = New System.Drawing.Point(94, 336)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(32, 15)
    Me.Label15.TabIndex = 15
    Me.Label15.Text = "Sexo"
    '
    'cboParentesco
    '
    Me.cboParentesco.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cboParentesco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboParentesco.FormattingEnabled = True
    Me.cboParentesco.Location = New System.Drawing.Point(155, 22)
    Me.cboParentesco.Name = "cboParentesco"
    Me.cboParentesco.Size = New System.Drawing.Size(174, 23)
    Me.cboParentesco.TabIndex = 1
    '
    'txtemail
    '
    Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtemail.Location = New System.Drawing.Point(155, 420)
    Me.txtemail.Name = "txtemail"
    Me.txtemail.Size = New System.Drawing.Size(527, 22)
    Me.txtemail.TabIndex = 26
    '
    'Label31
    '
    Me.Label31.AutoSize = True
    Me.Label31.Location = New System.Drawing.Point(63, 29)
    Me.Label31.Name = "Label31"
    Me.Label31.Size = New System.Drawing.Size(66, 15)
    Me.Label31.TabIndex = 0
    Me.Label31.Text = "Parentesco"
    '
    'txtcelular
    '
    Me.txtcelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtcelular.Location = New System.Drawing.Point(497, 390)
    Me.txtcelular.MaxLength = 12
    Me.txtcelular.Name = "txtcelular"
    Me.txtcelular.Size = New System.Drawing.Size(185, 22)
    Me.txtcelular.TabIndex = 24
    '
    'txtTelefcasa
    '
    Me.txtTelefcasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtTelefcasa.Location = New System.Drawing.Point(155, 390)
    Me.txtTelefcasa.MaxLength = 12
    Me.txtTelefcasa.Name = "txtTelefcasa"
    Me.txtTelefcasa.Size = New System.Drawing.Size(181, 22)
    Me.txtTelefcasa.TabIndex = 22
    '
    'txtdireccion
    '
    Me.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtdireccion.Location = New System.Drawing.Point(155, 360)
    Me.txtdireccion.MaxLength = 120
    Me.txtdireccion.Name = "txtdireccion"
    Me.txtdireccion.Size = New System.Drawing.Size(527, 22)
    Me.txtdireccion.TabIndex = 20
    '
    'txtNroDoc
    '
    Me.txtNroDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtNroDoc.Location = New System.Drawing.Point(500, 123)
    Me.txtNroDoc.MaxLength = 11
    Me.txtNroDoc.Name = "txtNroDoc"
    Me.txtNroDoc.Size = New System.Drawing.Size(182, 22)
    Me.txtNroDoc.TabIndex = 13
    '
    'cbotipoDoc
    '
    Me.cbotipoDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cbotipoDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cbotipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbotipoDoc.FormattingEnabled = True
    Me.cbotipoDoc.Items.AddRange(New Object() {"DNI", "Carnet Extranjería", "Libreta Electoral", "Libreta Militar", "Pasaporte", "Carnet Policial"})
    Me.cbotipoDoc.Location = New System.Drawing.Point(155, 123)
    Me.cbotipoDoc.Name = "cbotipoDoc"
    Me.cbotipoDoc.Size = New System.Drawing.Size(181, 23)
    Me.cbotipoDoc.TabIndex = 11
    '
    'Label16
    '
    Me.Label16.AutoSize = True
    Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label16.Location = New System.Drawing.Point(437, 393)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(47, 15)
    Me.Label16.TabIndex = 23
    Me.Label16.Text = "Celular "
    '
    'Label34
    '
    Me.Label34.AutoSize = True
    Me.Label34.Location = New System.Drawing.Point(88, 420)
    Me.Label34.Name = "Label34"
    Me.Label34.Size = New System.Drawing.Size(38, 15)
    Me.Label34.TabIndex = 25
    Me.Label34.Text = "Email "
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label12.Location = New System.Drawing.Point(427, 128)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(58, 15)
    Me.Label12.TabIndex = 12
    Me.Label12.Text = "Nro. Doc."
    '
    'txtmat
    '
    Me.txtmat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtmat.Location = New System.Drawing.Point(413, 89)
    Me.txtmat.Name = "txtmat"
    Me.txtmat.Size = New System.Drawing.Size(269, 22)
    Me.txtmat.TabIndex = 9
    '
    'txtpat
    '
    Me.txtpat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtpat.Location = New System.Drawing.Point(155, 89)
    Me.txtpat.Name = "txtpat"
    Me.txtpat.Size = New System.Drawing.Size(252, 22)
    Me.txtpat.TabIndex = 8
    '
    'txtnombre
    '
    Me.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtnombre.Location = New System.Drawing.Point(155, 53)
    Me.txtnombre.Name = "txtnombre"
    Me.txtnombre.Size = New System.Drawing.Size(527, 22)
    Me.txtnombre.TabIndex = 6
    '
    'Label17
    '
    Me.Label17.AutoSize = True
    Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label17.Location = New System.Drawing.Point(70, 91)
    Me.Label17.Name = "Label17"
    Me.Label17.Size = New System.Drawing.Size(59, 15)
    Me.Label17.TabIndex = 7
    Me.Label17.Text = "Apellidos"
    '
    'Label18
    '
    Me.Label18.AutoSize = True
    Me.Label18.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label18.Location = New System.Drawing.Point(74, 57)
    Me.Label18.Name = "Label18"
    Me.Label18.Size = New System.Drawing.Size(55, 15)
    Me.Label18.TabIndex = 5
    Me.Label18.Text = "Nombres"
    '
    'Label22
    '
    Me.Label22.AutoSize = True
    Me.Label22.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label22.Location = New System.Drawing.Point(39, 390)
    Me.Label22.Name = "Label22"
    Me.Label22.Size = New System.Drawing.Size(86, 15)
    Me.Label22.TabIndex = 21
    Me.Label22.Text = "Teléfono Casa "
    '
    'Label23
    '
    Me.Label23.AutoSize = True
    Me.Label23.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label23.Location = New System.Drawing.Point(27, 559)
    Me.Label23.Name = "Label23"
    Me.Label23.Size = New System.Drawing.Size(98, 15)
    Me.Label23.TabIndex = 35
    Me.Label23.Text = "Teléfono Trabajo"
    '
    'Label24
    '
    Me.Label24.AutoSize = True
    Me.Label24.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label24.Location = New System.Drawing.Point(65, 363)
    Me.Label24.Name = "Label24"
    Me.Label24.Size = New System.Drawing.Size(61, 15)
    Me.Label24.TabIndex = 19
    Me.Label24.Text = "Dirección "
    '
    'Label33
    '
    Me.Label33.AutoSize = True
    Me.Label33.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.Label33.Location = New System.Drawing.Point(32, 128)
    Me.Label33.Name = "Label33"
    Me.Label33.Size = New System.Drawing.Size(97, 15)
    Me.Label33.TabIndex = 10
    Me.Label33.Text = "Tipo Documento"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.Label4.Location = New System.Drawing.Point(801, 89)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(140, 19)
    Me.Label4.TabIndex = 7
    Me.Label4.Text = "F3 : Buscar Alumno"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.Label5.Location = New System.Drawing.Point(801, 118)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(136, 19)
    Me.Label5.TabIndex = 8
    Me.Label5.Text = "F5 : Buscar Padres"
    '
    'frmGestionApoderado
    '
    Me.AcceptButton = Me.btnRegistrar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(954, 668)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.btnEditar)
    Me.Controls.Add(Me.GroupBoxAlumno)
    Me.Controls.Add(Me.btnNuevo)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.gbDP)
    Me.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.KeyPreview = True
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmGestionApoderado"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de Padres y Apoderado"
    CType(Me.ErrorApoderado, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBoxAlumno.ResumeLayout(False)
    Me.GroupBoxAlumno.PerformLayout()
    Me.gbLuganNac.ResumeLayout(False)
    Me.gbLuganNac.PerformLayout()
    Me.gbDP.ResumeLayout(False)
    Me.gbDP.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents ErrorApoderado As System.Windows.Forms.ErrorProvider
  Friend WithEvents btnEditar As System.Windows.Forms.Button
  Friend WithEvents GroupBoxAlumno As System.Windows.Forms.GroupBox
  Friend WithEvents btnBuscarAlumno As System.Windows.Forms.Button
  Friend WithEvents txtAlumno As System.Windows.Forms.TextBox
  Friend WithEvents lblAlumno As System.Windows.Forms.Label
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents gbLuganNac As System.Windows.Forms.GroupBox
  Friend WithEvents dtpFechaNac As System.Windows.Forms.DateTimePicker
  Friend WithEvents CDireccionActual As Colegio.IAcademico.ControlUbicacionGeografica
  Friend WithEvents Label14 As System.Windows.Forms.Label
  Friend WithEvents gbDP As System.Windows.Forms.GroupBox
  Friend WithEvents cboxTutor As System.Windows.Forms.CheckBox
  Friend WithEvents cboEstadoCivil As System.Windows.Forms.ComboBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents cboProfesion As System.Windows.Forms.ComboBox
  Friend WithEvents lblProfesion As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cboOcupacion As System.Windows.Forms.ComboBox
  Friend WithEvents cbogradoInst As System.Windows.Forms.ComboBox
  Friend WithEvents Label25 As System.Windows.Forms.Label
  Friend WithEvents txtlugarTrabajo As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents btnBuscarPersonas As System.Windows.Forms.Button
  Protected WithEvents cboVive As System.Windows.Forms.ComboBox
  Friend WithEvents txtTelefTrabajo As System.Windows.Forms.TextBox
  Friend WithEvents cboSexo As System.Windows.Forms.ComboBox
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents cboParentesco As System.Windows.Forms.ComboBox
  Friend WithEvents txtemail As System.Windows.Forms.TextBox
  Friend WithEvents Label31 As System.Windows.Forms.Label
  Friend WithEvents txtcelular As System.Windows.Forms.TextBox
  Friend WithEvents txtTelefcasa As System.Windows.Forms.TextBox
  Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
  Friend WithEvents txtNroDoc As System.Windows.Forms.TextBox
  Friend WithEvents cbotipoDoc As System.Windows.Forms.ComboBox
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents Label34 As System.Windows.Forms.Label
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents txtmat As System.Windows.Forms.TextBox
  Friend WithEvents txtpat As System.Windows.Forms.TextBox
  Friend WithEvents txtnombre As System.Windows.Forms.TextBox
  Friend WithEvents Label17 As System.Windows.Forms.Label
  Friend WithEvents Label18 As System.Windows.Forms.Label
  Friend WithEvents Label19 As System.Windows.Forms.Label
  Friend WithEvents Label22 As System.Windows.Forms.Label
  Friend WithEvents Label23 As System.Windows.Forms.Label
  Friend WithEvents Label24 As System.Windows.Forms.Label
  Friend WithEvents Label33 As System.Windows.Forms.Label
  Friend WithEvents cboTipoParentesco As System.Windows.Forms.ComboBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
