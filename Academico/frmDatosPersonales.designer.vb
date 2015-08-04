<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatosPersonales
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
    Me.ErrDP = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.txtAlumno = New System.Windows.Forms.TextBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.GroupBoxPadresF = New System.Windows.Forms.GroupBox
    Me.txtMadre = New System.Windows.Forms.TextBox
    Me.txtPadre = New System.Windows.Forms.TextBox
    Me.btnregPadre = New System.Windows.Forms.Button
    Me.Label1 = New System.Windows.Forms.Label
    Me.btnRegMadre = New System.Windows.Forms.Button
    Me.Label2 = New System.Windows.Forms.Label
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
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
    Me.txtdireccion = New System.Windows.Forms.TextBox
    Me.Label24 = New System.Windows.Forms.Label
    Me.gbDireccion = New System.Windows.Forms.GroupBox
    Me.CLugarNac = New Colegio.IAcademico.ControlUbicacionGeografica
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.btnCancelar = New System.Windows.Forms.Button
    CType(Me.ErrDP, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBoxPadresF.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.gbDireccion.SuspendLayout()
    Me.SuspendLayout()
    '
    'ErrDP
    '
    Me.ErrDP.ContainerControl = Me
    '
    'txtAlumno
    '
    Me.txtAlumno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtAlumno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAlumno.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAlumno.ForeColor = System.Drawing.Color.Navy
    Me.txtAlumno.Location = New System.Drawing.Point(116, 13)
    Me.txtAlumno.Name = "txtAlumno"
    Me.txtAlumno.ReadOnly = True
    Me.txtAlumno.Size = New System.Drawing.Size(339, 22)
    Me.txtAlumno.TabIndex = 1
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(56, 17)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(45, 13)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Alumno "
    '
    'GroupBoxPadresF
    '
    Me.GroupBoxPadresF.Controls.Add(Me.txtMadre)
    Me.GroupBoxPadresF.Controls.Add(Me.txtPadre)
    Me.GroupBoxPadresF.Controls.Add(Me.btnregPadre)
    Me.GroupBoxPadresF.Controls.Add(Me.Label1)
    Me.GroupBoxPadresF.Controls.Add(Me.btnRegMadre)
    Me.GroupBoxPadresF.Controls.Add(Me.Label2)
    Me.GroupBoxPadresF.Location = New System.Drawing.Point(12, 34)
    Me.GroupBoxPadresF.Name = "GroupBoxPadresF"
    Me.GroupBoxPadresF.Size = New System.Drawing.Size(561, 91)
    Me.GroupBoxPadresF.TabIndex = 2
    Me.GroupBoxPadresF.TabStop = False
    Me.GroupBoxPadresF.Text = "Padres de Familia"
    '
    'txtMadre
    '
    Me.txtMadre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtMadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtMadre.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMadre.ForeColor = System.Drawing.Color.Navy
    Me.txtMadre.Location = New System.Drawing.Point(104, 53)
    Me.txtMadre.Name = "txtMadre"
    Me.txtMadre.ReadOnly = True
    Me.txtMadre.Size = New System.Drawing.Size(339, 22)
    Me.txtMadre.TabIndex = 4
    '
    'txtPadre
    '
    Me.txtPadre.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.txtPadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtPadre.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPadre.ForeColor = System.Drawing.Color.Navy
    Me.txtPadre.Location = New System.Drawing.Point(104, 14)
    Me.txtPadre.Name = "txtPadre"
    Me.txtPadre.ReadOnly = True
    Me.txtPadre.Size = New System.Drawing.Size(339, 22)
    Me.txtPadre.TabIndex = 1
    '
    'btnregPadre
    '
    Me.btnregPadre.BackColor = System.Drawing.Color.White
    Me.btnregPadre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnregPadre.Location = New System.Drawing.Point(475, 12)
    Me.btnregPadre.Name = "btnregPadre"
    Me.btnregPadre.Size = New System.Drawing.Size(71, 28)
    Me.btnregPadre.TabIndex = 2
    Me.btnregPadre.Text = "&Padre"
    Me.btnregPadre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnregPadre.UseVisualStyleBackColor = False
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(44, 21)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(36, 15)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Padre"
    '
    'btnRegMadre
    '
    Me.btnRegMadre.BackColor = System.Drawing.Color.White
    Me.btnRegMadre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegMadre.Location = New System.Drawing.Point(475, 46)
    Me.btnRegMadre.Name = "btnRegMadre"
    Me.btnRegMadre.Size = New System.Drawing.Size(71, 28)
    Me.btnRegMadre.TabIndex = 5
    Me.btnRegMadre.Text = "&Madre"
    Me.btnRegMadre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegMadre.UseVisualStyleBackColor = False
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(44, 60)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(38, 15)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Madre"
    '
    'GroupBox2
    '
    Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(137, Byte), Integer))
    Me.GroupBox2.Controls.Add(Me.txtmedcontra)
    Me.GroupBox2.Controls.Add(Me.txtcolegproced)
    Me.GroupBox2.Controls.Add(Me.Label18)
    Me.GroupBox2.Controls.Add(Me.Label19)
    Me.GroupBox2.Controls.Add(Me.cbolengmat)
    Me.GroupBox2.Controls.Add(Me.Label20)
    Me.GroupBox2.Controls.Add(Me.cbogrupoSang)
    Me.GroupBox2.Controls.Add(Me.txtemail)
    Me.GroupBox2.Controls.Add(Me.Label21)
    Me.GroupBox2.Controls.Add(Me.Label25)
    Me.GroupBox2.Controls.Add(Me.cbonacionalidad)
    Me.GroupBox2.Controls.Add(Me.txttelefono)
    Me.GroupBox2.Controls.Add(Me.Label22)
    Me.GroupBox2.Controls.Add(Me.Label23)
    Me.GroupBox2.Location = New System.Drawing.Point(12, 129)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(561, 207)
    Me.GroupBox2.TabIndex = 3
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Datos Personales"
    '
    'txtmedcontra
    '
    Me.txtmedcontra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtmedcontra.Location = New System.Drawing.Point(155, 84)
    Me.txtmedcontra.Multiline = True
    Me.txtmedcontra.Name = "txtmedcontra"
    Me.txtmedcontra.Size = New System.Drawing.Size(391, 57)
    Me.txtmedcontra.TabIndex = 9
    '
    'txtcolegproced
    '
    Me.txtcolegproced.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtcolegproced.Location = New System.Drawing.Point(155, 147)
    Me.txtcolegproced.Name = "txtcolegproced"
    Me.txtcolegproced.Size = New System.Drawing.Size(288, 20)
    Me.txtcolegproced.TabIndex = 11
    '
    'Label18
    '
    Me.Label18.AutoSize = True
    Me.Label18.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label18.Location = New System.Drawing.Point(11, 149)
    Me.Label18.Name = "Label18"
    Me.Label18.Size = New System.Drawing.Size(107, 15)
    Me.Label18.TabIndex = 10
    Me.Label18.Text = "Colegio Procedencia"
    '
    'Label19
    '
    Me.Label19.AutoSize = True
    Me.Label19.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label19.Location = New System.Drawing.Point(11, 95)
    Me.Label19.Name = "Label19"
    Me.Label19.Size = New System.Drawing.Size(138, 15)
    Me.Label19.TabIndex = 8
    Me.Label19.Text = "Medicinas Contraindicadas"
    '
    'cbolengmat
    '
    Me.cbolengmat.FormattingEnabled = True
    Me.cbolengmat.Items.AddRange(New Object() {"Español", "Ingles", "Frances", "Italiano", "Aleman", "Japones", "Chino"})
    Me.cbolengmat.Location = New System.Drawing.Point(425, 56)
    Me.cbolengmat.Name = "cbolengmat"
    Me.cbolengmat.Size = New System.Drawing.Size(121, 21)
    Me.cbolengmat.TabIndex = 7
    '
    'Label20
    '
    Me.Label20.AutoSize = True
    Me.Label20.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label20.Location = New System.Drawing.Point(327, 56)
    Me.Label20.Name = "Label20"
    Me.Label20.Size = New System.Drawing.Size(86, 15)
    Me.Label20.TabIndex = 6
    Me.Label20.Text = "Lengua Materna"
    '
    'cbogrupoSang
    '
    Me.cbogrupoSang.FormattingEnabled = True
    Me.cbogrupoSang.Items.AddRange(New Object() {"A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-"})
    Me.cbogrupoSang.Location = New System.Drawing.Point(425, 29)
    Me.cbogrupoSang.Name = "cbogrupoSang"
    Me.cbogrupoSang.Size = New System.Drawing.Size(121, 21)
    Me.cbogrupoSang.TabIndex = 3
    '
    'txtemail
    '
    Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtemail.Location = New System.Drawing.Point(155, 173)
    Me.txtemail.Name = "txtemail"
    Me.txtemail.Size = New System.Drawing.Size(288, 20)
    Me.txtemail.TabIndex = 13
    '
    'Label21
    '
    Me.Label21.AutoSize = True
    Me.Label21.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label21.Location = New System.Drawing.Point(327, 29)
    Me.Label21.Name = "Label21"
    Me.Label21.Size = New System.Drawing.Size(92, 15)
    Me.Label21.TabIndex = 2
    Me.Label21.Text = "Grupo Sanguineo"
    '
    'Label25
    '
    Me.Label25.AutoSize = True
    Me.Label25.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label25.Location = New System.Drawing.Point(86, 178)
    Me.Label25.Name = "Label25"
    Me.Label25.Size = New System.Drawing.Size(32, 15)
    Me.Label25.TabIndex = 12
    Me.Label25.Text = "Email"
    '
    'cbonacionalidad
    '
    Me.cbonacionalidad.FormattingEnabled = True
    Me.cbonacionalidad.Items.AddRange(New Object() {"Peruana", "Argentina", "Colombiana", "Chilena", "Española", "Mexicana", "Brasil"})
    Me.cbonacionalidad.Location = New System.Drawing.Point(104, 50)
    Me.cbonacionalidad.Name = "cbonacionalidad"
    Me.cbonacionalidad.Size = New System.Drawing.Size(121, 21)
    Me.cbonacionalidad.TabIndex = 5
    '
    'txttelefono
    '
    Me.txttelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txttelefono.Location = New System.Drawing.Point(104, 24)
    Me.txttelefono.MaxLength = 6
    Me.txttelefono.Name = "txttelefono"
    Me.txttelefono.Size = New System.Drawing.Size(121, 20)
    Me.txttelefono.TabIndex = 1
    '
    'Label22
    '
    Me.Label22.AutoSize = True
    Me.Label22.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label22.Location = New System.Drawing.Point(11, 50)
    Me.Label22.Name = "Label22"
    Me.Label22.Size = New System.Drawing.Size(69, 15)
    Me.Label22.TabIndex = 4
    Me.Label22.Text = "Nacionalidad"
    '
    'Label23
    '
    Me.Label23.AutoSize = True
    Me.Label23.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label23.Location = New System.Drawing.Point(31, 26)
    Me.Label23.Name = "Label23"
    Me.Label23.Size = New System.Drawing.Size(49, 15)
    Me.Label23.TabIndex = 0
    Me.Label23.Text = "Teléfono"
    '
    'txtdireccion
    '
    Me.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtdireccion.Location = New System.Drawing.Point(104, 19)
    Me.txtdireccion.Name = "txtdireccion"
    Me.txtdireccion.Size = New System.Drawing.Size(339, 20)
    Me.txtdireccion.TabIndex = 1
    '
    'Label24
    '
    Me.Label24.AutoSize = True
    Me.Label24.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label24.Location = New System.Drawing.Point(36, 27)
    Me.Label24.Name = "Label24"
    Me.Label24.Size = New System.Drawing.Size(53, 15)
    Me.Label24.TabIndex = 0
    Me.Label24.Text = "Dirección"
    '
    'gbDireccion
    '
    Me.gbDireccion.Controls.Add(Me.txtdireccion)
    Me.gbDireccion.Controls.Add(Me.Label24)
    Me.gbDireccion.Controls.Add(Me.CLugarNac)
    Me.gbDireccion.Location = New System.Drawing.Point(12, 342)
    Me.gbDireccion.Name = "gbDireccion"
    Me.gbDireccion.Size = New System.Drawing.Size(561, 156)
    Me.gbDireccion.TabIndex = 4
    Me.gbDireccion.TabStop = False
    Me.gbDireccion.Text = "Dirección"
    '
    'CLugarNac
    '
    Me.CLugarNac.Location = New System.Drawing.Point(34, 45)
    Me.CLugarNac.Name = "CLugarNac"
    Me.CLugarNac.Size = New System.Drawing.Size(512, 101)
    Me.CLugarNac.TabIndex = 2
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(601, 252)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(111, 44)
    Me.btnCerrar.TabIndex = 7
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(601, 92)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(111, 44)
    Me.btnRegistrar.TabIndex = 5
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(601, 172)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(111, 44)
    Me.btnCancelar.TabIndex = 6
    Me.btnCancelar.Text = "&Deshacer"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    Me.btnCancelar.Visible = False
    '
    'frmDatosPersonales
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(724, 515)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.gbDireccion)
    Me.Controls.Add(Me.GroupBox2)
    Me.Controls.Add(Me.txtAlumno)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.GroupBoxPadresF)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmDatosPersonales"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Datos Personales del Alumno"
    CType(Me.ErrDP, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBoxPadresF.ResumeLayout(False)
    Me.GroupBoxPadresF.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    Me.gbDireccion.ResumeLayout(False)
    Me.gbDireccion.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents ErrDP As System.Windows.Forms.ErrorProvider
  Friend WithEvents CLugarNac As ControlUbicacionGeografica
  Friend WithEvents GroupBoxPadresF As System.Windows.Forms.GroupBox
  Friend WithEvents btnregPadre As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents btnRegMadre As System.Windows.Forms.Button
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtAlumno As System.Windows.Forms.TextBox
  Friend WithEvents txtPadre As System.Windows.Forms.TextBox
  Friend WithEvents txtMadre As System.Windows.Forms.TextBox
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents txtmedcontra As System.Windows.Forms.TextBox
  Friend WithEvents txtcolegproced As System.Windows.Forms.TextBox
  Friend WithEvents Label18 As System.Windows.Forms.Label
  Friend WithEvents Label19 As System.Windows.Forms.Label
  Friend WithEvents cbolengmat As System.Windows.Forms.ComboBox
  Friend WithEvents Label20 As System.Windows.Forms.Label
  Friend WithEvents cbogrupoSang As System.Windows.Forms.ComboBox
  Friend WithEvents Label21 As System.Windows.Forms.Label
  Friend WithEvents cbonacionalidad As System.Windows.Forms.ComboBox
  Friend WithEvents txttelefono As System.Windows.Forms.TextBox
  Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
  Friend WithEvents Label22 As System.Windows.Forms.Label
  Friend WithEvents Label23 As System.Windows.Forms.Label
  Friend WithEvents Label24 As System.Windows.Forms.Label
  Friend WithEvents txtemail As System.Windows.Forms.TextBox
  Friend WithEvents Label25 As System.Windows.Forms.Label
  Friend WithEvents gbDireccion As System.Windows.Forms.GroupBox
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
