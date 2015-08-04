<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformacionAlumno
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
    Me.btnBuscarAlumno = New System.Windows.Forms.Button()
    Me.txtAlumno = New System.Windows.Forms.TextBox()
    Me.lblAlumno = New System.Windows.Forms.Label()
    Me.lblApoderado = New System.Windows.Forms.Label()
    Me.lblAnio = New System.Windows.Forms.Label()
    Me.lblSeccion = New System.Windows.Forms.Label()
    Me.txtSeccion = New System.Windows.Forms.TextBox()
    Me.txtApoderado = New System.Windows.Forms.TextBox()
    Me.txtParentesco = New System.Windows.Forms.TextBox()
    Me.txtTutor = New System.Windows.Forms.TextBox()
    Me.lblTutor = New System.Windows.Forms.Label()
    Me.txtAula = New System.Windows.Forms.TextBox()
    Me.lblAula = New System.Windows.Forms.Label()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.tabDatos = New System.Windows.Forms.TabControl()
    Me.tabMatricula = New System.Windows.Forms.TabPage()
    Me.tabPadre = New System.Windows.Forms.TabPage()
    Me.lblCorreoPadre = New System.Windows.Forms.Label()
    Me.txtCorreoPadre = New System.Windows.Forms.TextBox()
    Me.txtCelularPadre = New System.Windows.Forms.TextBox()
    Me.lblCelularPadre = New System.Windows.Forms.Label()
    Me.txtTelTrabajoPadre = New System.Windows.Forms.TextBox()
    Me.lblTelTrabajo = New System.Windows.Forms.Label()
    Me.txtTelCasaPadre = New System.Windows.Forms.TextBox()
    Me.lblTelCasaPadre = New System.Windows.Forms.Label()
    Me.lblNombrePadre = New System.Windows.Forms.Label()
    Me.txtNombrePadre = New System.Windows.Forms.TextBox()
    Me.tabMadre = New System.Windows.Forms.TabPage()
    Me.lblCorreoMadre = New System.Windows.Forms.Label()
    Me.txtCorreoMadre = New System.Windows.Forms.TextBox()
    Me.txtCelularMadre = New System.Windows.Forms.TextBox()
    Me.lblCelularMadre = New System.Windows.Forms.Label()
    Me.txtTelTrabajoMadre = New System.Windows.Forms.TextBox()
    Me.lblTelTrabajoMadre = New System.Windows.Forms.Label()
    Me.txtTelCasaMadre = New System.Windows.Forms.TextBox()
    Me.lblTelCasaMadre = New System.Windows.Forms.Label()
    Me.lblNombreMadre = New System.Windows.Forms.Label()
    Me.txtNombreMadre = New System.Windows.Forms.TextBox()
    Me.cboAnio = New System.Windows.Forms.ComboBox()
    Me.btnPresentar = New System.Windows.Forms.Button()
    Me.tabDatos.SuspendLayout()
    Me.tabMatricula.SuspendLayout()
    Me.tabPadre.SuspendLayout()
    Me.tabMadre.SuspendLayout()
    Me.SuspendLayout()
    '
    'btnBuscarAlumno
    '
    Me.btnBuscarAlumno.BackColor = System.Drawing.Color.White
    Me.btnBuscarAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscarAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscarAlumno.Location = New System.Drawing.Point(457, 15)
    Me.btnBuscarAlumno.Name = "btnBuscarAlumno"
    Me.btnBuscarAlumno.Size = New System.Drawing.Size(104, 39)
    Me.btnBuscarAlumno.TabIndex = 4
    Me.btnBuscarAlumno.Text = "&Buscar"
    Me.btnBuscarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscarAlumno.UseVisualStyleBackColor = False
    '
    'txtAlumno
    '
    Me.txtAlumno.BackColor = System.Drawing.SystemColors.Info
    Me.txtAlumno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAlumno.Location = New System.Drawing.Point(72, 30)
    Me.txtAlumno.Multiline = True
    Me.txtAlumno.Name = "txtAlumno"
    Me.txtAlumno.ReadOnly = True
    Me.txtAlumno.Size = New System.Drawing.Size(367, 24)
    Me.txtAlumno.TabIndex = 3
    '
    'lblAlumno
    '
    Me.lblAlumno.AutoSize = True
    Me.lblAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAlumno.Location = New System.Drawing.Point(13, 38)
    Me.lblAlumno.Name = "lblAlumno"
    Me.lblAlumno.Size = New System.Drawing.Size(53, 16)
    Me.lblAlumno.TabIndex = 2
    Me.lblAlumno.Text = "Alumno"
    '
    'lblApoderado
    '
    Me.lblApoderado.AutoSize = True
    Me.lblApoderado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblApoderado.Location = New System.Drawing.Point(8, 158)
    Me.lblApoderado.Name = "lblApoderado"
    Me.lblApoderado.Size = New System.Drawing.Size(77, 16)
    Me.lblApoderado.TabIndex = 6
    Me.lblApoderado.Text = "Apoderado"
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAnio.Location = New System.Drawing.Point(13, 86)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(32, 16)
    Me.lblAnio.TabIndex = 0
    Me.lblAnio.Text = "Añ&o"
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSeccion.Location = New System.Drawing.Point(10, 24)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(57, 16)
    Me.lblSeccion.TabIndex = 0
    Me.lblSeccion.Text = "&Sección"
    '
    'txtSeccion
    '
    Me.txtSeccion.BackColor = System.Drawing.SystemColors.Info
    Me.txtSeccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSeccion.Location = New System.Drawing.Point(91, 16)
    Me.txtSeccion.Multiline = True
    Me.txtSeccion.Name = "txtSeccion"
    Me.txtSeccion.ReadOnly = True
    Me.txtSeccion.Size = New System.Drawing.Size(331, 24)
    Me.txtSeccion.TabIndex = 1
    '
    'txtApoderado
    '
    Me.txtApoderado.BackColor = System.Drawing.SystemColors.Info
    Me.txtApoderado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtApoderado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtApoderado.Location = New System.Drawing.Point(91, 150)
    Me.txtApoderado.Multiline = True
    Me.txtApoderado.Name = "txtApoderado"
    Me.txtApoderado.ReadOnly = True
    Me.txtApoderado.Size = New System.Drawing.Size(344, 24)
    Me.txtApoderado.TabIndex = 7
    '
    'txtParentesco
    '
    Me.txtParentesco.BackColor = System.Drawing.SystemColors.Info
    Me.txtParentesco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtParentesco.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtParentesco.Location = New System.Drawing.Point(441, 150)
    Me.txtParentesco.Multiline = True
    Me.txtParentesco.Name = "txtParentesco"
    Me.txtParentesco.ReadOnly = True
    Me.txtParentesco.Size = New System.Drawing.Size(126, 24)
    Me.txtParentesco.TabIndex = 8
    '
    'txtTutor
    '
    Me.txtTutor.BackColor = System.Drawing.SystemColors.Info
    Me.txtTutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtTutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTutor.Location = New System.Drawing.Point(91, 62)
    Me.txtTutor.Multiline = True
    Me.txtTutor.Name = "txtTutor"
    Me.txtTutor.ReadOnly = True
    Me.txtTutor.Size = New System.Drawing.Size(344, 24)
    Me.txtTutor.TabIndex = 3
    '
    'lblTutor
    '
    Me.lblTutor.AutoSize = True
    Me.lblTutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTutor.Location = New System.Drawing.Point(10, 70)
    Me.lblTutor.Name = "lblTutor"
    Me.lblTutor.Size = New System.Drawing.Size(39, 16)
    Me.lblTutor.TabIndex = 2
    Me.lblTutor.Text = "Tutor"
    '
    'txtAula
    '
    Me.txtAula.BackColor = System.Drawing.SystemColors.Info
    Me.txtAula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAula.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAula.Location = New System.Drawing.Point(91, 104)
    Me.txtAula.Multiline = True
    Me.txtAula.Name = "txtAula"
    Me.txtAula.ReadOnly = True
    Me.txtAula.Size = New System.Drawing.Size(344, 24)
    Me.txtAula.TabIndex = 5
    '
    'lblAula
    '
    Me.lblAula.AutoSize = True
    Me.lblAula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAula.Location = New System.Drawing.Point(10, 112)
    Me.lblAula.Name = "lblAula"
    Me.lblAula.Size = New System.Drawing.Size(35, 16)
    Me.lblAula.TabIndex = 4
    Me.lblAula.Text = "Aula"
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(485, 364)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(104, 44)
    Me.btnCerrar.TabIndex = 6
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'tabDatos
    '
    Me.tabDatos.Controls.Add(Me.tabMatricula)
    Me.tabDatos.Controls.Add(Me.tabPadre)
    Me.tabDatos.Controls.Add(Me.tabMadre)
    Me.tabDatos.Location = New System.Drawing.Point(12, 124)
    Me.tabDatos.Name = "tabDatos"
    Me.tabDatos.SelectedIndex = 0
    Me.tabDatos.Size = New System.Drawing.Size(581, 234)
    Me.tabDatos.TabIndex = 5
    '
    'tabMatricula
    '
    Me.tabMatricula.Controls.Add(Me.lblSeccion)
    Me.tabMatricula.Controls.Add(Me.lblApoderado)
    Me.tabMatricula.Controls.Add(Me.txtAula)
    Me.tabMatricula.Controls.Add(Me.txtSeccion)
    Me.tabMatricula.Controls.Add(Me.lblAula)
    Me.tabMatricula.Controls.Add(Me.txtApoderado)
    Me.tabMatricula.Controls.Add(Me.txtTutor)
    Me.tabMatricula.Controls.Add(Me.txtParentesco)
    Me.tabMatricula.Controls.Add(Me.lblTutor)
    Me.tabMatricula.Location = New System.Drawing.Point(4, 22)
    Me.tabMatricula.Name = "tabMatricula"
    Me.tabMatricula.Padding = New System.Windows.Forms.Padding(3)
    Me.tabMatricula.Size = New System.Drawing.Size(573, 208)
    Me.tabMatricula.TabIndex = 0
    Me.tabMatricula.Text = "Matrícula"
    Me.tabMatricula.UseVisualStyleBackColor = True
    '
    'tabPadre
    '
    Me.tabPadre.Controls.Add(Me.lblCorreoPadre)
    Me.tabPadre.Controls.Add(Me.txtCorreoPadre)
    Me.tabPadre.Controls.Add(Me.txtCelularPadre)
    Me.tabPadre.Controls.Add(Me.lblCelularPadre)
    Me.tabPadre.Controls.Add(Me.txtTelTrabajoPadre)
    Me.tabPadre.Controls.Add(Me.lblTelTrabajo)
    Me.tabPadre.Controls.Add(Me.txtTelCasaPadre)
    Me.tabPadre.Controls.Add(Me.lblTelCasaPadre)
    Me.tabPadre.Controls.Add(Me.lblNombrePadre)
    Me.tabPadre.Controls.Add(Me.txtNombrePadre)
    Me.tabPadre.Location = New System.Drawing.Point(4, 22)
    Me.tabPadre.Name = "tabPadre"
    Me.tabPadre.Padding = New System.Windows.Forms.Padding(3)
    Me.tabPadre.Size = New System.Drawing.Size(573, 208)
    Me.tabPadre.TabIndex = 1
    Me.tabPadre.Text = "Padre"
    Me.tabPadre.UseVisualStyleBackColor = True
    '
    'lblCorreoPadre
    '
    Me.lblCorreoPadre.AutoSize = True
    Me.lblCorreoPadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCorreoPadre.Location = New System.Drawing.Point(8, 149)
    Me.lblCorreoPadre.Name = "lblCorreoPadre"
    Me.lblCorreoPadre.Size = New System.Drawing.Size(49, 16)
    Me.lblCorreoPadre.TabIndex = 10
    Me.lblCorreoPadre.Text = "Correo"
    '
    'txtCorreoPadre
    '
    Me.txtCorreoPadre.BackColor = System.Drawing.SystemColors.Info
    Me.txtCorreoPadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtCorreoPadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCorreoPadre.Location = New System.Drawing.Point(89, 141)
    Me.txtCorreoPadre.Multiline = True
    Me.txtCorreoPadre.Name = "txtCorreoPadre"
    Me.txtCorreoPadre.ReadOnly = True
    Me.txtCorreoPadre.Size = New System.Drawing.Size(476, 24)
    Me.txtCorreoPadre.TabIndex = 11
    '
    'txtCelularPadre
    '
    Me.txtCelularPadre.BackColor = System.Drawing.SystemColors.Info
    Me.txtCelularPadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtCelularPadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCelularPadre.Location = New System.Drawing.Point(91, 102)
    Me.txtCelularPadre.Multiline = True
    Me.txtCelularPadre.Name = "txtCelularPadre"
    Me.txtCelularPadre.ReadOnly = True
    Me.txtCelularPadre.Size = New System.Drawing.Size(94, 24)
    Me.txtCelularPadre.TabIndex = 9
    '
    'lblCelularPadre
    '
    Me.lblCelularPadre.AutoSize = True
    Me.lblCelularPadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCelularPadre.Location = New System.Drawing.Point(10, 110)
    Me.lblCelularPadre.Name = "lblCelularPadre"
    Me.lblCelularPadre.Size = New System.Drawing.Size(50, 16)
    Me.lblCelularPadre.TabIndex = 8
    Me.lblCelularPadre.Text = "Celular"
    '
    'txtTelTrabajoPadre
    '
    Me.txtTelTrabajoPadre.BackColor = System.Drawing.SystemColors.Info
    Me.txtTelTrabajoPadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtTelTrabajoPadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTelTrabajoPadre.Location = New System.Drawing.Point(376, 64)
    Me.txtTelTrabajoPadre.Multiline = True
    Me.txtTelTrabajoPadre.Name = "txtTelTrabajoPadre"
    Me.txtTelTrabajoPadre.ReadOnly = True
    Me.txtTelTrabajoPadre.Size = New System.Drawing.Size(94, 24)
    Me.txtTelTrabajoPadre.TabIndex = 7
    '
    'lblTelTrabajo
    '
    Me.lblTelTrabajo.AutoSize = True
    Me.lblTelTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTelTrabajo.Location = New System.Drawing.Point(295, 72)
    Me.lblTelTrabajo.Name = "lblTelTrabajo"
    Me.lblTelTrabajo.Size = New System.Drawing.Size(77, 16)
    Me.lblTelTrabajo.TabIndex = 6
    Me.lblTelTrabajo.Text = "Tlf. Trabajo"
    '
    'txtTelCasaPadre
    '
    Me.txtTelCasaPadre.BackColor = System.Drawing.SystemColors.Info
    Me.txtTelCasaPadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtTelCasaPadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTelCasaPadre.Location = New System.Drawing.Point(91, 64)
    Me.txtTelCasaPadre.Multiline = True
    Me.txtTelCasaPadre.Name = "txtTelCasaPadre"
    Me.txtTelCasaPadre.ReadOnly = True
    Me.txtTelCasaPadre.Size = New System.Drawing.Size(94, 24)
    Me.txtTelCasaPadre.TabIndex = 5
    '
    'lblTelCasaPadre
    '
    Me.lblTelCasaPadre.AutoSize = True
    Me.lblTelCasaPadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTelCasaPadre.Location = New System.Drawing.Point(10, 72)
    Me.lblTelCasaPadre.Name = "lblTelCasaPadre"
    Me.lblTelCasaPadre.Size = New System.Drawing.Size(59, 16)
    Me.lblTelCasaPadre.TabIndex = 4
    Me.lblTelCasaPadre.Text = "Tlf. casa"
    '
    'lblNombrePadre
    '
    Me.lblNombrePadre.AutoSize = True
    Me.lblNombrePadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNombrePadre.Location = New System.Drawing.Point(10, 28)
    Me.lblNombrePadre.Name = "lblNombrePadre"
    Me.lblNombrePadre.Size = New System.Drawing.Size(57, 16)
    Me.lblNombrePadre.TabIndex = 0
    Me.lblNombrePadre.Text = "Nombre"
    '
    'txtNombrePadre
    '
    Me.txtNombrePadre.BackColor = System.Drawing.SystemColors.Info
    Me.txtNombrePadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtNombrePadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNombrePadre.Location = New System.Drawing.Point(91, 20)
    Me.txtNombrePadre.Multiline = True
    Me.txtNombrePadre.Name = "txtNombrePadre"
    Me.txtNombrePadre.ReadOnly = True
    Me.txtNombrePadre.Size = New System.Drawing.Size(476, 24)
    Me.txtNombrePadre.TabIndex = 1
    '
    'tabMadre
    '
    Me.tabMadre.Controls.Add(Me.lblCorreoMadre)
    Me.tabMadre.Controls.Add(Me.txtCorreoMadre)
    Me.tabMadre.Controls.Add(Me.txtCelularMadre)
    Me.tabMadre.Controls.Add(Me.lblCelularMadre)
    Me.tabMadre.Controls.Add(Me.txtTelTrabajoMadre)
    Me.tabMadre.Controls.Add(Me.lblTelTrabajoMadre)
    Me.tabMadre.Controls.Add(Me.txtTelCasaMadre)
    Me.tabMadre.Controls.Add(Me.lblTelCasaMadre)
    Me.tabMadre.Controls.Add(Me.lblNombreMadre)
    Me.tabMadre.Controls.Add(Me.txtNombreMadre)
    Me.tabMadre.Location = New System.Drawing.Point(4, 22)
    Me.tabMadre.Name = "tabMadre"
    Me.tabMadre.Padding = New System.Windows.Forms.Padding(3)
    Me.tabMadre.Size = New System.Drawing.Size(573, 208)
    Me.tabMadre.TabIndex = 2
    Me.tabMadre.Text = "Madre"
    Me.tabMadre.UseVisualStyleBackColor = True
    '
    'lblCorreoMadre
    '
    Me.lblCorreoMadre.AutoSize = True
    Me.lblCorreoMadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCorreoMadre.Location = New System.Drawing.Point(7, 145)
    Me.lblCorreoMadre.Name = "lblCorreoMadre"
    Me.lblCorreoMadre.Size = New System.Drawing.Size(49, 16)
    Me.lblCorreoMadre.TabIndex = 10
    Me.lblCorreoMadre.Text = "Correo"
    '
    'txtCorreoMadre
    '
    Me.txtCorreoMadre.BackColor = System.Drawing.SystemColors.Info
    Me.txtCorreoMadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtCorreoMadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCorreoMadre.Location = New System.Drawing.Point(90, 137)
    Me.txtCorreoMadre.Multiline = True
    Me.txtCorreoMadre.Name = "txtCorreoMadre"
    Me.txtCorreoMadre.ReadOnly = True
    Me.txtCorreoMadre.Size = New System.Drawing.Size(476, 24)
    Me.txtCorreoMadre.TabIndex = 11
    '
    'txtCelularMadre
    '
    Me.txtCelularMadre.BackColor = System.Drawing.SystemColors.Info
    Me.txtCelularMadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtCelularMadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCelularMadre.Location = New System.Drawing.Point(90, 101)
    Me.txtCelularMadre.Multiline = True
    Me.txtCelularMadre.Name = "txtCelularMadre"
    Me.txtCelularMadre.ReadOnly = True
    Me.txtCelularMadre.Size = New System.Drawing.Size(94, 24)
    Me.txtCelularMadre.TabIndex = 9
    '
    'lblCelularMadre
    '
    Me.lblCelularMadre.AutoSize = True
    Me.lblCelularMadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCelularMadre.Location = New System.Drawing.Point(9, 109)
    Me.lblCelularMadre.Name = "lblCelularMadre"
    Me.lblCelularMadre.Size = New System.Drawing.Size(50, 16)
    Me.lblCelularMadre.TabIndex = 8
    Me.lblCelularMadre.Text = "Celular"
    '
    'txtTelTrabajoMadre
    '
    Me.txtTelTrabajoMadre.BackColor = System.Drawing.SystemColors.Info
    Me.txtTelTrabajoMadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtTelTrabajoMadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTelTrabajoMadre.Location = New System.Drawing.Point(375, 63)
    Me.txtTelTrabajoMadre.Multiline = True
    Me.txtTelTrabajoMadre.Name = "txtTelTrabajoMadre"
    Me.txtTelTrabajoMadre.ReadOnly = True
    Me.txtTelTrabajoMadre.Size = New System.Drawing.Size(94, 24)
    Me.txtTelTrabajoMadre.TabIndex = 7
    '
    'lblTelTrabajoMadre
    '
    Me.lblTelTrabajoMadre.AutoSize = True
    Me.lblTelTrabajoMadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTelTrabajoMadre.Location = New System.Drawing.Point(294, 71)
    Me.lblTelTrabajoMadre.Name = "lblTelTrabajoMadre"
    Me.lblTelTrabajoMadre.Size = New System.Drawing.Size(77, 16)
    Me.lblTelTrabajoMadre.TabIndex = 6
    Me.lblTelTrabajoMadre.Text = "Tlf. Trabajo"
    '
    'txtTelCasaMadre
    '
    Me.txtTelCasaMadre.BackColor = System.Drawing.SystemColors.Info
    Me.txtTelCasaMadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtTelCasaMadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTelCasaMadre.Location = New System.Drawing.Point(90, 63)
    Me.txtTelCasaMadre.Multiline = True
    Me.txtTelCasaMadre.Name = "txtTelCasaMadre"
    Me.txtTelCasaMadre.ReadOnly = True
    Me.txtTelCasaMadre.Size = New System.Drawing.Size(94, 24)
    Me.txtTelCasaMadre.TabIndex = 5
    '
    'lblTelCasaMadre
    '
    Me.lblTelCasaMadre.AutoSize = True
    Me.lblTelCasaMadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTelCasaMadre.Location = New System.Drawing.Point(9, 71)
    Me.lblTelCasaMadre.Name = "lblTelCasaMadre"
    Me.lblTelCasaMadre.Size = New System.Drawing.Size(59, 16)
    Me.lblTelCasaMadre.TabIndex = 4
    Me.lblTelCasaMadre.Text = "Tlf. casa"
    '
    'lblNombreMadre
    '
    Me.lblNombreMadre.AutoSize = True
    Me.lblNombreMadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNombreMadre.Location = New System.Drawing.Point(9, 27)
    Me.lblNombreMadre.Name = "lblNombreMadre"
    Me.lblNombreMadre.Size = New System.Drawing.Size(57, 16)
    Me.lblNombreMadre.TabIndex = 0
    Me.lblNombreMadre.Text = "Nombre"
    '
    'txtNombreMadre
    '
    Me.txtNombreMadre.BackColor = System.Drawing.SystemColors.Info
    Me.txtNombreMadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtNombreMadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNombreMadre.Location = New System.Drawing.Point(90, 19)
    Me.txtNombreMadre.Multiline = True
    Me.txtNombreMadre.Name = "txtNombreMadre"
    Me.txtNombreMadre.ReadOnly = True
    Me.txtNombreMadre.Size = New System.Drawing.Size(476, 24)
    Me.txtNombreMadre.TabIndex = 1
    '
    'cboAnio
    '
    Me.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAnio.FormattingEnabled = True
    Me.cboAnio.Location = New System.Drawing.Point(75, 81)
    Me.cboAnio.Name = "cboAnio"
    Me.cboAnio.Size = New System.Drawing.Size(107, 21)
    Me.cboAnio.TabIndex = 1
    '
    'btnPresentar
    '
    Me.btnPresentar.BackColor = System.Drawing.Color.White
    Me.btnPresentar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnPresentar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnPresentar.Location = New System.Drawing.Point(208, 70)
    Me.btnPresentar.Name = "btnPresentar"
    Me.btnPresentar.Size = New System.Drawing.Size(104, 39)
    Me.btnPresentar.TabIndex = 7
    Me.btnPresentar.Text = "&Presentar"
    Me.btnPresentar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnPresentar.UseVisualStyleBackColor = False
    '
    'frmInformacionAlumno
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(605, 420)
    Me.Controls.Add(Me.btnPresentar)
    Me.Controls.Add(Me.cboAnio)
    Me.Controls.Add(Me.tabDatos)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.lblAnio)
    Me.Controls.Add(Me.btnBuscarAlumno)
    Me.Controls.Add(Me.txtAlumno)
    Me.Controls.Add(Me.lblAlumno)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmInformacionAlumno"
    Me.Text = "Información de alumno"
    Me.tabDatos.ResumeLayout(False)
    Me.tabMatricula.ResumeLayout(False)
    Me.tabMatricula.PerformLayout()
    Me.tabPadre.ResumeLayout(False)
    Me.tabPadre.PerformLayout()
    Me.tabMadre.ResumeLayout(False)
    Me.tabMadre.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnBuscarAlumno As System.Windows.Forms.Button
  Friend WithEvents txtAlumno As System.Windows.Forms.TextBox
  Friend WithEvents lblAlumno As System.Windows.Forms.Label
  Friend WithEvents lblApoderado As System.Windows.Forms.Label
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents txtSeccion As System.Windows.Forms.TextBox
  Friend WithEvents txtApoderado As System.Windows.Forms.TextBox
  Friend WithEvents txtParentesco As System.Windows.Forms.TextBox
  Friend WithEvents txtTutor As System.Windows.Forms.TextBox
  Friend WithEvents lblTutor As System.Windows.Forms.Label
  Friend WithEvents txtAula As System.Windows.Forms.TextBox
  Friend WithEvents lblAula As System.Windows.Forms.Label
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents tabDatos As System.Windows.Forms.TabControl
  Friend WithEvents tabMatricula As System.Windows.Forms.TabPage
  Friend WithEvents tabPadre As System.Windows.Forms.TabPage
  Friend WithEvents tabMadre As System.Windows.Forms.TabPage
  Friend WithEvents lblNombrePadre As System.Windows.Forms.Label
  Friend WithEvents txtNombrePadre As System.Windows.Forms.TextBox
  Friend WithEvents txtTelCasaPadre As System.Windows.Forms.TextBox
  Friend WithEvents lblTelCasaPadre As System.Windows.Forms.Label
  Friend WithEvents txtTelTrabajoPadre As System.Windows.Forms.TextBox
  Friend WithEvents lblTelTrabajo As System.Windows.Forms.Label
  Friend WithEvents txtCelularPadre As System.Windows.Forms.TextBox
  Friend WithEvents lblCelularPadre As System.Windows.Forms.Label
  Friend WithEvents lblCorreoPadre As System.Windows.Forms.Label
  Friend WithEvents txtCorreoPadre As System.Windows.Forms.TextBox
  Friend WithEvents lblCorreoMadre As System.Windows.Forms.Label
  Friend WithEvents txtCorreoMadre As System.Windows.Forms.TextBox
  Friend WithEvents txtCelularMadre As System.Windows.Forms.TextBox
  Friend WithEvents lblCelularMadre As System.Windows.Forms.Label
  Friend WithEvents txtTelTrabajoMadre As System.Windows.Forms.TextBox
  Friend WithEvents lblTelTrabajoMadre As System.Windows.Forms.Label
  Friend WithEvents txtTelCasaMadre As System.Windows.Forms.TextBox
  Friend WithEvents lblTelCasaMadre As System.Windows.Forms.Label
  Friend WithEvents lblNombreMadre As System.Windows.Forms.Label
  Friend WithEvents txtNombreMadre As System.Windows.Forms.TextBox
  Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
  Friend WithEvents btnPresentar As System.Windows.Forms.Button
End Class
