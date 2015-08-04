<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionarMatricula
    Inherits Colegio.Plantillas.frmPlantilla

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Me.cbanio = New System.Windows.Forms.ComboBox
    Me.lblAnio = New System.Windows.Forms.Label
    Me.gbMatricula = New System.Windows.Forms.GroupBox
    Me.gbApoderado = New System.Windows.Forms.GroupBox
    Me.txtParentesco = New System.Windows.Forms.TextBox
    Me.lblParentesco = New System.Windows.Forms.Label
    Me.cboApoderado = New System.Windows.Forms.ComboBox
    Me.btnNuevoApo = New System.Windows.Forms.Button
    Me.lblApoderado = New System.Windows.Forms.Label
    Me.gbAlumno = New System.Windows.Forms.GroupBox
    Me.btnActualizarDatos = New System.Windows.Forms.Button
    Me.cboTipo = New System.Windows.Forms.ComboBox
    Me.lblTipo = New System.Windows.Forms.Label
    Me.cboNivel = New System.Windows.Forms.ComboBox
    Me.cboSeccion = New System.Windows.Forms.ComboBox
    Me.lblNivel = New System.Windows.Forms.Label
    Me.lblSeccion = New System.Windows.Forms.Label
    Me.btnBuscarAlumno = New System.Windows.Forms.Button
    Me.txtAlumno = New System.Windows.Forms.TextBox
    Me.btnNuevoAlu = New System.Windows.Forms.Button
    Me.lblAlumno = New System.Windows.Forms.Label
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.gbAnioLectivo = New System.Windows.Forms.GroupBox
    Me.btnMatriculados = New System.Windows.Forms.Button
    Me.errMatricula = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.lblLeyenda = New System.Windows.Forms.Label
    Me.lblLeyenda2 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.gbMatricula.SuspendLayout()
    Me.gbApoderado.SuspendLayout()
    Me.gbAlumno.SuspendLayout()
    Me.gbAnioLectivo.SuspendLayout()
    CType(Me.errMatricula, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cbanio
    '
    Me.cbanio.BackColor = System.Drawing.SystemColors.Info
    Me.cbanio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbanio.Enabled = False
    Me.cbanio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbanio.FormattingEnabled = True
    Me.cbanio.Location = New System.Drawing.Point(83, 27)
    Me.cbanio.Name = "cbanio"
    Me.cbanio.Size = New System.Drawing.Size(87, 24)
    Me.cbanio.TabIndex = 1
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAnio.Location = New System.Drawing.Point(47, 31)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(31, 15)
    Me.lblAnio.TabIndex = 0
    Me.lblAnio.Text = "Añ&o"
    '
    'gbMatricula
    '
    Me.gbMatricula.Controls.Add(Me.gbApoderado)
    Me.gbMatricula.Controls.Add(Me.gbAlumno)
    Me.gbMatricula.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbMatricula.Location = New System.Drawing.Point(37, 90)
    Me.gbMatricula.Name = "gbMatricula"
    Me.gbMatricula.Size = New System.Drawing.Size(647, 393)
    Me.gbMatricula.TabIndex = 1
    Me.gbMatricula.TabStop = False
    Me.gbMatricula.Text = "Matrícula"
    '
    'gbApoderado
    '
    Me.gbApoderado.Controls.Add(Me.txtParentesco)
    Me.gbApoderado.Controls.Add(Me.lblParentesco)
    Me.gbApoderado.Controls.Add(Me.cboApoderado)
    Me.gbApoderado.Controls.Add(Me.btnNuevoApo)
    Me.gbApoderado.Controls.Add(Me.lblApoderado)
    Me.gbApoderado.Location = New System.Drawing.Point(32, 259)
    Me.gbApoderado.Name = "gbApoderado"
    Me.gbApoderado.Size = New System.Drawing.Size(587, 112)
    Me.gbApoderado.TabIndex = 4
    Me.gbApoderado.TabStop = False
    Me.gbApoderado.Text = "Apoderado"
    '
    'txtParentesco
    '
    Me.txtParentesco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtParentesco.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtParentesco.Location = New System.Drawing.Point(91, 66)
    Me.txtParentesco.Multiline = True
    Me.txtParentesco.Name = "txtParentesco"
    Me.txtParentesco.ReadOnly = True
    Me.txtParentesco.Size = New System.Drawing.Size(158, 24)
    Me.txtParentesco.TabIndex = 4
    '
    'lblParentesco
    '
    Me.lblParentesco.AutoSize = True
    Me.lblParentesco.Location = New System.Drawing.Point(16, 75)
    Me.lblParentesco.Name = "lblParentesco"
    Me.lblParentesco.Size = New System.Drawing.Size(66, 15)
    Me.lblParentesco.TabIndex = 3
    Me.lblParentesco.Text = "&Parentesco"
    '
    'cboApoderado
    '
    Me.cboApoderado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboApoderado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboApoderado.FormattingEnabled = True
    Me.cboApoderado.Location = New System.Drawing.Point(91, 26)
    Me.cboApoderado.Name = "cboApoderado"
    Me.cboApoderado.Size = New System.Drawing.Size(325, 24)
    Me.cboApoderado.TabIndex = 1
    '
    'btnNuevoApo
    '
    Me.btnNuevoApo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnNuevoApo.Location = New System.Drawing.Point(432, 25)
    Me.btnNuevoApo.Name = "btnNuevoApo"
    Me.btnNuevoApo.Size = New System.Drawing.Size(138, 34)
    Me.btnNuevoApo.TabIndex = 2
    Me.btnNuevoApo.Text = "N&uevo"
    Me.btnNuevoApo.UseVisualStyleBackColor = True
    '
    'lblApoderado
    '
    Me.lblApoderado.AutoSize = True
    Me.lblApoderado.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblApoderado.Location = New System.Drawing.Point(33, 35)
    Me.lblApoderado.Name = "lblApoderado"
    Me.lblApoderado.Size = New System.Drawing.Size(49, 15)
    Me.lblApoderado.TabIndex = 0
    Me.lblApoderado.Text = "Nombre"
    '
    'gbAlumno
    '
    Me.gbAlumno.Controls.Add(Me.btnActualizarDatos)
    Me.gbAlumno.Controls.Add(Me.cboTipo)
    Me.gbAlumno.Controls.Add(Me.lblTipo)
    Me.gbAlumno.Controls.Add(Me.cboNivel)
    Me.gbAlumno.Controls.Add(Me.cboSeccion)
    Me.gbAlumno.Controls.Add(Me.lblNivel)
    Me.gbAlumno.Controls.Add(Me.lblSeccion)
    Me.gbAlumno.Controls.Add(Me.btnBuscarAlumno)
    Me.gbAlumno.Controls.Add(Me.txtAlumno)
    Me.gbAlumno.Controls.Add(Me.btnNuevoAlu)
    Me.gbAlumno.Controls.Add(Me.lblAlumno)
    Me.gbAlumno.Location = New System.Drawing.Point(32, 34)
    Me.gbAlumno.Name = "gbAlumno"
    Me.gbAlumno.Size = New System.Drawing.Size(587, 198)
    Me.gbAlumno.TabIndex = 2
    Me.gbAlumno.TabStop = False
    Me.gbAlumno.Text = "Alumno"
    '
    'btnActualizarDatos
    '
    Me.btnActualizarDatos.BackColor = System.Drawing.Color.White
    Me.btnActualizarDatos.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnActualizarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnActualizarDatos.Location = New System.Drawing.Point(411, 73)
    Me.btnActualizarDatos.Name = "btnActualizarDatos"
    Me.btnActualizarDatos.Size = New System.Drawing.Size(159, 70)
    Me.btnActualizarDatos.TabIndex = 20
    Me.btnActualizarDatos.Text = "&Actualizar datos"
    Me.btnActualizarDatos.UseVisualStyleBackColor = False
    '
    'cboTipo
    '
    Me.cboTipo.BackColor = System.Drawing.SystemColors.Info
    Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboTipo.FormattingEnabled = True
    Me.cboTipo.Items.AddRange(New Object() {"Ingresante", "Promovido", "Repitente", "Reentrante", "Reingresante"})
    Me.cboTipo.Location = New System.Drawing.Point(69, 83)
    Me.cboTipo.Name = "cboTipo"
    Me.cboTipo.Size = New System.Drawing.Size(180, 24)
    Me.cboTipo.TabIndex = 19
    '
    'lblTipo
    '
    Me.lblTipo.AutoSize = True
    Me.lblTipo.Location = New System.Drawing.Point(33, 92)
    Me.lblTipo.Name = "lblTipo"
    Me.lblTipo.Size = New System.Drawing.Size(32, 15)
    Me.lblTipo.TabIndex = 18
    Me.lblTipo.Text = "&Tipo"
    '
    'cboNivel
    '
    Me.cboNivel.BackColor = System.Drawing.SystemColors.Info
    Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNivel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Location = New System.Drawing.Point(69, 149)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(132, 24)
    Me.cboNivel.TabIndex = 15
    '
    'cboSeccion
    '
    Me.cboSeccion.BackColor = System.Drawing.SystemColors.Info
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(354, 149)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(132, 24)
    Me.cboSeccion.TabIndex = 17
    '
    'lblNivel
    '
    Me.lblNivel.AutoSize = True
    Me.lblNivel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNivel.Location = New System.Drawing.Point(28, 152)
    Me.lblNivel.Name = "lblNivel"
    Me.lblNivel.Size = New System.Drawing.Size(35, 15)
    Me.lblNivel.TabIndex = 14
    Me.lblNivel.Text = "&Nivel"
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSeccion.Location = New System.Drawing.Point(255, 152)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(93, 15)
    Me.lblSeccion.TabIndex = 16
    Me.lblSeccion.Text = "&Grado y sección"
    '
    'btnBuscarAlumno
    '
    Me.btnBuscarAlumno.BackColor = System.Drawing.Color.White
    Me.btnBuscarAlumno.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscarAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscarAlumno.Location = New System.Drawing.Point(411, 26)
    Me.btnBuscarAlumno.Name = "btnBuscarAlumno"
    Me.btnBuscarAlumno.Size = New System.Drawing.Size(75, 34)
    Me.btnBuscarAlumno.TabIndex = 2
    Me.btnBuscarAlumno.Text = "&Buscar"
    Me.btnBuscarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscarAlumno.UseVisualStyleBackColor = False
    '
    'txtAlumno
    '
    Me.txtAlumno.BackColor = System.Drawing.SystemColors.Info
    Me.txtAlumno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAlumno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAlumno.Location = New System.Drawing.Point(69, 30)
    Me.txtAlumno.Multiline = True
    Me.txtAlumno.Name = "txtAlumno"
    Me.txtAlumno.ReadOnly = True
    Me.txtAlumno.Size = New System.Drawing.Size(325, 24)
    Me.txtAlumno.TabIndex = 1
    '
    'btnNuevoAlu
    '
    Me.btnNuevoAlu.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnNuevoAlu.Location = New System.Drawing.Point(495, 26)
    Me.btnNuevoAlu.Name = "btnNuevoAlu"
    Me.btnNuevoAlu.Size = New System.Drawing.Size(75, 34)
    Me.btnNuevoAlu.TabIndex = 12
    Me.btnNuevoAlu.Text = "&Nuevo"
    Me.btnNuevoAlu.UseVisualStyleBackColor = True
    '
    'lblAlumno
    '
    Me.lblAlumno.AutoSize = True
    Me.lblAlumno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAlumno.Location = New System.Drawing.Point(16, 33)
    Me.lblAlumno.Name = "lblAlumno"
    Me.lblAlumno.Size = New System.Drawing.Size(49, 15)
    Me.lblAlumno.TabIndex = 0
    Me.lblAlumno.Text = "Nombre"
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(736, 229)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
    Me.btnRegistrar.TabIndex = 2
    Me.btnRegistrar.Text = "&Matricular"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(736, 287)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
    Me.btnCancelar.TabIndex = 4
    Me.btnCancelar.Text = "&Deshacer"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(736, 430)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 5
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'gbAnioLectivo
    '
    Me.gbAnioLectivo.Controls.Add(Me.cbanio)
    Me.gbAnioLectivo.Controls.Add(Me.lblAnio)
    Me.gbAnioLectivo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbAnioLectivo.Location = New System.Drawing.Point(37, 12)
    Me.gbAnioLectivo.Name = "gbAnioLectivo"
    Me.gbAnioLectivo.Size = New System.Drawing.Size(216, 65)
    Me.gbAnioLectivo.TabIndex = 0
    Me.gbAnioLectivo.TabStop = False
    Me.gbAnioLectivo.Text = "Año Lectivo"
    '
    'btnMatriculados
    '
    Me.btnMatriculados.BackColor = System.Drawing.Color.White
    Me.btnMatriculados.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnMatriculados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnMatriculados.Location = New System.Drawing.Point(736, 113)
    Me.btnMatriculados.Name = "btnMatriculados"
    Me.btnMatriculados.Size = New System.Drawing.Size(110, 52)
    Me.btnMatriculados.TabIndex = 3
    Me.btnMatriculados.Text = "&Matriculados"
    Me.btnMatriculados.UseVisualStyleBackColor = False
    '
    'errMatricula
    '
    Me.errMatricula.ContainerControl = Me
    '
    'lblLeyenda
    '
    Me.lblLeyenda.AutoSize = True
    Me.lblLeyenda.BackColor = System.Drawing.Color.LightSkyBlue
    Me.lblLeyenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblLeyenda.Location = New System.Drawing.Point(430, 6)
    Me.lblLeyenda.Name = "lblLeyenda"
    Me.lblLeyenda.Size = New System.Drawing.Size(96, 20)
    Me.lblLeyenda.TabIndex = 6
    Me.lblLeyenda.Text = "Buscar: F5"
    '
    'lblLeyenda2
    '
    Me.lblLeyenda2.AutoSize = True
    Me.lblLeyenda2.BackColor = System.Drawing.Color.LightSkyBlue
    Me.lblLeyenda2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblLeyenda2.Location = New System.Drawing.Point(430, 31)
    Me.lblLeyenda2.Name = "lblLeyenda2"
    Me.lblLeyenda2.Size = New System.Drawing.Size(142, 20)
    Me.lblLeyenda2.TabIndex = 7
    Me.lblLeyenda2.Text = "Matriculados: F6"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.BackColor = System.Drawing.Color.LightSkyBlue
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(430, 56)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(254, 20)
    Me.Label1.TabIndex = 8
    Me.Label1.Text = "Nuevo: ALT + Letra Subrayada"
    '
    'frmGestionarMatricula
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(881, 525)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.lblLeyenda2)
    Me.Controls.Add(Me.lblLeyenda)
    Me.Controls.Add(Me.btnMatriculados)
    Me.Controls.Add(Me.gbAnioLectivo)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.gbMatricula)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.KeyPreview = True
    Me.MaximizeBox = False
    Me.Name = "frmGestionarMatricula"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestionar Matrícula"
    Me.gbMatricula.ResumeLayout(False)
    Me.gbApoderado.ResumeLayout(False)
    Me.gbApoderado.PerformLayout()
    Me.gbAlumno.ResumeLayout(False)
    Me.gbAlumno.PerformLayout()
    Me.gbAnioLectivo.ResumeLayout(False)
    Me.gbAnioLectivo.PerformLayout()
    CType(Me.errMatricula, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cbanio As System.Windows.Forms.ComboBox
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents gbMatricula As System.Windows.Forms.GroupBox
  Friend WithEvents btnBuscarAlumno As System.Windows.Forms.Button
  Friend WithEvents txtAlumno As System.Windows.Forms.TextBox
  Friend WithEvents lblAlumno As System.Windows.Forms.Label
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents lblApoderado As System.Windows.Forms.Label
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents gbAnioLectivo As System.Windows.Forms.GroupBox
  Friend WithEvents btnMatriculados As System.Windows.Forms.Button
  Friend WithEvents txtParentesco As System.Windows.Forms.TextBox
  Friend WithEvents lblParentesco As System.Windows.Forms.Label
  Friend WithEvents cboApoderado As System.Windows.Forms.ComboBox
  Friend WithEvents gbAlumno As System.Windows.Forms.GroupBox
  Friend WithEvents btnNuevoApo As System.Windows.Forms.Button
  Friend WithEvents btnNuevoAlu As System.Windows.Forms.Button
  Friend WithEvents gbApoderado As System.Windows.Forms.GroupBox
  Friend WithEvents errMatricula As System.Windows.Forms.ErrorProvider
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents lblLeyenda2 As System.Windows.Forms.Label
  Friend WithEvents lblLeyenda As System.Windows.Forms.Label
  Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
  Friend WithEvents lblTipo As System.Windows.Forms.Label
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents lblNivel As System.Windows.Forms.Label
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents btnActualizarDatos As System.Windows.Forms.Button
End Class
