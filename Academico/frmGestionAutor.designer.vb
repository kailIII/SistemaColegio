<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionAutor
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
    Me.components = New System.ComponentModel.Container
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.GBAlumno = New System.Windows.Forms.GroupBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.txtNombreBuscar = New System.Windows.Forms.TextBox
    Me.lblNombreBuscar = New System.Windows.Forms.Label
    Me.btnBuscar = New System.Windows.Forms.Button
    Me.dgvAutores = New System.Windows.Forms.DataGridView
    Me.cdNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.btnActualizar = New System.Windows.Forms.Button
    Me.gbAutor = New System.Windows.Forms.GroupBox
    Me.txtApellidos = New System.Windows.Forms.TextBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.txtNombres = New System.Windows.Forms.TextBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.ErrAutor = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.GBAlumno.SuspendLayout()
    CType(Me.dgvAutores, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbAutor.SuspendLayout()
    CType(Me.ErrAutor, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'GBAlumno
    '
    Me.GBAlumno.Controls.Add(Me.Label2)
    Me.GBAlumno.Controls.Add(Me.Label1)
    Me.GBAlumno.Controls.Add(Me.txtNombreBuscar)
    Me.GBAlumno.Controls.Add(Me.lblNombreBuscar)
    Me.GBAlumno.Location = New System.Drawing.Point(14, 7)
    Me.GBAlumno.Name = "GBAlumno"
    Me.GBAlumno.Size = New System.Drawing.Size(450, 68)
    Me.GBAlumno.TabIndex = 15
    Me.GBAlumno.TabStop = False
    Me.GBAlumno.Text = "Autor"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.BackColor = System.Drawing.Color.Transparent
    Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.Label2.Location = New System.Drawing.Point(65, 50)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(149, 15)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Apellidos              Nombres"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.BackColor = System.Drawing.Color.Transparent
    Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.Label1.Location = New System.Drawing.Point(17, 50)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(42, 15)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Orden"
    '
    'txtNombreBuscar
    '
    Me.txtNombreBuscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNombreBuscar.Location = New System.Drawing.Point(68, 19)
    Me.txtNombreBuscar.Multiline = True
    Me.txtNombreBuscar.Name = "txtNombreBuscar"
    Me.txtNombreBuscar.Size = New System.Drawing.Size(375, 24)
    Me.txtNombreBuscar.TabIndex = 1
    '
    'lblNombreBuscar
    '
    Me.lblNombreBuscar.AutoSize = True
    Me.lblNombreBuscar.BackColor = System.Drawing.Color.Transparent
    Me.lblNombreBuscar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNombreBuscar.Location = New System.Drawing.Point(17, 23)
    Me.lblNombreBuscar.Name = "lblNombreBuscar"
    Me.lblNombreBuscar.Size = New System.Drawing.Size(52, 15)
    Me.lblNombreBuscar.TabIndex = 0
    Me.lblNombreBuscar.Text = "N&ombre:"
    '
    'btnBuscar
    '
    Me.btnBuscar.BackColor = System.Drawing.Color.White
    Me.btnBuscar.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscar.Location = New System.Drawing.Point(470, 19)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(78, 37)
    Me.btnBuscar.TabIndex = 16
    Me.btnBuscar.Text = "&Buscar"
    Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscar.UseVisualStyleBackColor = False
    '
    'dgvAutores
    '
    Me.dgvAutores.AllowUserToAddRows = False
    Me.dgvAutores.AllowUserToDeleteRows = False
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvAutores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvAutores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNombre})
    Me.dgvAutores.Location = New System.Drawing.Point(14, 81)
    Me.dgvAutores.MultiSelect = False
    Me.dgvAutores.Name = "dgvAutores"
    Me.dgvAutores.ReadOnly = True
    Me.dgvAutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvAutores.Size = New System.Drawing.Size(534, 403)
    Me.dgvAutores.TabIndex = 17
    '
    'cdNombre
    '
    Me.cdNombre.DataPropertyName = "NombreCompleto"
    Me.cdNombre.HeaderText = "Autor"
    Me.cdNombre.Name = "cdNombre"
    Me.cdNombre.ReadOnly = True
    Me.cdNombre.Width = 470
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(566, 280)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
    Me.btnCancelar.TabIndex = 20
    Me.btnCancelar.Text = "&Deshacer"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(566, 430)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 21
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(566, 197)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
    Me.btnRegistrar.TabIndex = 19
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'btnActualizar
    '
    Me.btnActualizar.BackColor = System.Drawing.Color.White
    Me.btnActualizar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnActualizar.Location = New System.Drawing.Point(566, 98)
    Me.btnActualizar.Name = "btnActualizar"
    Me.btnActualizar.Size = New System.Drawing.Size(110, 52)
    Me.btnActualizar.TabIndex = 18
    Me.btnActualizar.Text = "&Seleccionar"
    Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnActualizar.UseVisualStyleBackColor = False
    '
    'gbAutor
    '
    Me.gbAutor.Controls.Add(Me.txtApellidos)
    Me.gbAutor.Controls.Add(Me.Label4)
    Me.gbAutor.Controls.Add(Me.txtNombres)
    Me.gbAutor.Controls.Add(Me.Label3)
    Me.gbAutor.Location = New System.Drawing.Point(12, 490)
    Me.gbAutor.Name = "gbAutor"
    Me.gbAutor.Size = New System.Drawing.Size(536, 74)
    Me.gbAutor.TabIndex = 22
    Me.gbAutor.TabStop = False
    Me.gbAutor.Text = "Autor"
    '
    'txtApellidos
    '
    Me.txtApellidos.Location = New System.Drawing.Point(76, 46)
    Me.txtApellidos.Name = "txtApellidos"
    Me.txtApellidos.Size = New System.Drawing.Size(428, 20)
    Me.txtApellidos.TabIndex = 3
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(9, 50)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(49, 13)
    Me.Label4.TabIndex = 2
    Me.Label4.Text = "Apellidos"
    '
    'txtNombres
    '
    Me.txtNombres.Location = New System.Drawing.Point(76, 20)
    Me.txtNombres.Name = "txtNombres"
    Me.txtNombres.Size = New System.Drawing.Size(428, 20)
    Me.txtNombres.TabIndex = 1
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(9, 24)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(49, 13)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Nombres"
    '
    'ErrAutor
    '
    Me.ErrAutor.ContainerControl = Me
    '
    'frmAutor
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(688, 589)
    Me.Controls.Add(Me.gbAutor)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.btnActualizar)
    Me.Controls.Add(Me.GBAlumno)
    Me.Controls.Add(Me.btnBuscar)
    Me.Controls.Add(Me.dgvAutores)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Name = "frmAutor"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de Autores"
    Me.GBAlumno.ResumeLayout(False)
    Me.GBAlumno.PerformLayout()
    CType(Me.dgvAutores, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbAutor.ResumeLayout(False)
    Me.gbAutor.PerformLayout()
    CType(Me.ErrAutor, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents GBAlumno As System.Windows.Forms.GroupBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtNombreBuscar As System.Windows.Forms.TextBox
  Friend WithEvents lblNombreBuscar As System.Windows.Forms.Label
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
  Friend WithEvents dgvAutores As System.Windows.Forms.DataGridView
  Friend WithEvents cdNombre As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnActualizar As System.Windows.Forms.Button
  Friend WithEvents gbAutor As System.Windows.Forms.GroupBox
  Friend WithEvents txtNombres As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents ErrAutor As System.Windows.Forms.ErrorProvider
End Class
