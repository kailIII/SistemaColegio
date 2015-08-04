<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistrarPersona
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
    Me.txtApellidoPat = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.txtApellidoMat = New System.Windows.Forms.TextBox
    Me.cbSexo = New System.Windows.Forms.ComboBox
    Me.dtpFechaNac = New System.Windows.Forms.DateTimePicker
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.txtNombre = New System.Windows.Forms.TextBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.SuspendLayout()
    '
    'txtApellidoPat
    '
    Me.txtApellidoPat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtApellidoPat.Location = New System.Drawing.Point(117, 64)
    Me.txtApellidoPat.Name = "txtApellidoPat"
    Me.txtApellidoPat.Size = New System.Drawing.Size(196, 20)
    Me.txtApellidoPat.TabIndex = 3
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(18, 71)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(84, 13)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Apellido Paterno"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(18, 106)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(86, 13)
    Me.Label2.TabIndex = 4
    Me.Label2.Text = "Apellido Materno"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(18, 141)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(31, 13)
    Me.Label4.TabIndex = 6
    Me.Label4.Text = "Sexo"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(18, 176)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(93, 13)
    Me.Label5.TabIndex = 8
    Me.Label5.Text = "Fecha Nacimiento"
    '
    'txtApellidoMat
    '
    Me.txtApellidoMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtApellidoMat.Location = New System.Drawing.Point(117, 99)
    Me.txtApellidoMat.Name = "txtApellidoMat"
    Me.txtApellidoMat.Size = New System.Drawing.Size(196, 20)
    Me.txtApellidoMat.TabIndex = 5
    '
    'cbSexo
    '
    Me.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbSexo.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.cbSexo.FormattingEnabled = True
    Me.cbSexo.Items.AddRange(New Object() {"FEMENINO", "MASCULINO"})
    Me.cbSexo.Location = New System.Drawing.Point(117, 133)
    Me.cbSexo.Name = "cbSexo"
    Me.cbSexo.Size = New System.Drawing.Size(121, 21)
    Me.cbSexo.TabIndex = 7
    '
    'dtpFechaNac
    '
    Me.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaNac.Location = New System.Drawing.Point(117, 169)
    Me.dtpFechaNac.Name = "dtpFechaNac"
    Me.dtpFechaNac.Size = New System.Drawing.Size(121, 20)
    Me.dtpFechaNac.TabIndex = 9
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(266, 247)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(113, 52)
    Me.btnCerrar.TabIndex = 11
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(117, 247)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(113, 52)
    Me.btnRegistrar.TabIndex = 10
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'txtNombre
    '
    Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtNombre.Location = New System.Drawing.Point(117, 28)
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Size = New System.Drawing.Size(196, 20)
    Me.txtNombre.TabIndex = 1
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(18, 35)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(49, 13)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Nombres"
    '
    'frmRegistrarPersona
    '
    Me.AcceptButton = Me.btnRegistrar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.CancelButton = Me.btnCerrar
    Me.ClientSize = New System.Drawing.Size(391, 311)
    Me.Controls.Add(Me.txtNombre)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.dtpFechaNac)
    Me.Controls.Add(Me.cbSexo)
    Me.Controls.Add(Me.txtApellidoMat)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.txtApellidoPat)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmRegistrarPersona"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Registrar Persona"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtApellidoPat As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txtApellidoMat As System.Windows.Forms.TextBox
  Friend WithEvents cbSexo As System.Windows.Forms.ComboBox
  Friend WithEvents dtpFechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
