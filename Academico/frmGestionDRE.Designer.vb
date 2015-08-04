<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionDRE
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
    Me.lblNombre = New System.Windows.Forms.Label
    Me.lblDireccion = New System.Windows.Forms.Label
    Me.lblContacto = New System.Windows.Forms.Label
    Me.lblTelefono = New System.Windows.Forms.Label
    Me.lblCodigo = New System.Windows.Forms.Label
    Me.txtNombre = New System.Windows.Forms.TextBox
    Me.txtDireccion = New System.Windows.Forms.TextBox
    Me.txtContacto = New System.Windows.Forms.TextBox
    Me.txtTelefono = New System.Windows.Forms.TextBox
    Me.txtCodigo = New System.Windows.Forms.TextBox
    Me.gbDatosDRE = New System.Windows.Forms.GroupBox
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnModificar = New System.Windows.Forms.Button
    Me.errDre = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.gbDRE = New System.Windows.Forms.GroupBox
    Me.dgvDRE = New System.Windows.Forms.DataGridView
    Me.cdNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cgCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.lblMensaje = New System.Windows.Forms.Label
    Me.gbDatosDRE.SuspendLayout()
    CType(Me.errDre, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbDRE.SuspendLayout()
    CType(Me.dgvDRE, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblNombre
    '
    Me.lblNombre.AutoSize = True
    Me.lblNombre.Location = New System.Drawing.Point(50, 41)
    Me.lblNombre.Name = "lblNombre"
    Me.lblNombre.Size = New System.Drawing.Size(49, 15)
    Me.lblNombre.TabIndex = 0
    Me.lblNombre.Text = "Nombre"
    '
    'lblDireccion
    '
    Me.lblDireccion.AutoSize = True
    Me.lblDireccion.Location = New System.Drawing.Point(41, 78)
    Me.lblDireccion.Name = "lblDireccion"
    Me.lblDireccion.Size = New System.Drawing.Size(58, 15)
    Me.lblDireccion.TabIndex = 2
    Me.lblDireccion.Text = "Dirección"
    '
    'lblContacto
    '
    Me.lblContacto.AutoSize = True
    Me.lblContacto.Location = New System.Drawing.Point(43, 115)
    Me.lblContacto.Name = "lblContacto"
    Me.lblContacto.Size = New System.Drawing.Size(56, 15)
    Me.lblContacto.TabIndex = 4
    Me.lblContacto.Text = "Contacto"
    '
    'lblTelefono
    '
    Me.lblTelefono.AutoSize = True
    Me.lblTelefono.Location = New System.Drawing.Point(44, 153)
    Me.lblTelefono.Name = "lblTelefono"
    Me.lblTelefono.Size = New System.Drawing.Size(55, 15)
    Me.lblTelefono.TabIndex = 6
    Me.lblTelefono.Text = "Teléfono"
    '
    'lblCodigo
    '
    Me.lblCodigo.AutoSize = True
    Me.lblCodigo.Location = New System.Drawing.Point(25, 191)
    Me.lblCodigo.Name = "lblCodigo"
    Me.lblCodigo.Size = New System.Drawing.Size(74, 15)
    Me.lblCodigo.TabIndex = 8
    Me.lblCodigo.Text = "Código Ugel"
    '
    'txtNombre
    '
    Me.txtNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNombre.Location = New System.Drawing.Point(108, 37)
    Me.txtNombre.Multiline = True
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Size = New System.Drawing.Size(268, 24)
    Me.txtNombre.TabIndex = 1
    '
    'txtDireccion
    '
    Me.txtDireccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDireccion.Location = New System.Drawing.Point(108, 74)
    Me.txtDireccion.Multiline = True
    Me.txtDireccion.Name = "txtDireccion"
    Me.txtDireccion.Size = New System.Drawing.Size(268, 24)
    Me.txtDireccion.TabIndex = 3
    '
    'txtContacto
    '
    Me.txtContacto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtContacto.Location = New System.Drawing.Point(108, 111)
    Me.txtContacto.Multiline = True
    Me.txtContacto.Name = "txtContacto"
    Me.txtContacto.Size = New System.Drawing.Size(268, 24)
    Me.txtContacto.TabIndex = 5
    '
    'txtTelefono
    '
    Me.txtTelefono.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTelefono.Location = New System.Drawing.Point(108, 149)
    Me.txtTelefono.MaxLength = 10
    Me.txtTelefono.Multiline = True
    Me.txtTelefono.Name = "txtTelefono"
    Me.txtTelefono.Size = New System.Drawing.Size(135, 24)
    Me.txtTelefono.TabIndex = 7
    '
    'txtCodigo
    '
    Me.txtCodigo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCodigo.Location = New System.Drawing.Point(108, 187)
    Me.txtCodigo.MaxLength = 6
    Me.txtCodigo.Multiline = True
    Me.txtCodigo.Name = "txtCodigo"
    Me.txtCodigo.Size = New System.Drawing.Size(135, 24)
    Me.txtCodigo.TabIndex = 9
    '
    'gbDatosDRE
    '
    Me.gbDatosDRE.Controls.Add(Me.txtCodigo)
    Me.gbDatosDRE.Controls.Add(Me.txtTelefono)
    Me.gbDatosDRE.Controls.Add(Me.txtContacto)
    Me.gbDatosDRE.Controls.Add(Me.txtDireccion)
    Me.gbDatosDRE.Controls.Add(Me.txtNombre)
    Me.gbDatosDRE.Controls.Add(Me.lblCodigo)
    Me.gbDatosDRE.Controls.Add(Me.lblTelefono)
    Me.gbDatosDRE.Controls.Add(Me.lblContacto)
    Me.gbDatosDRE.Controls.Add(Me.lblDireccion)
    Me.gbDatosDRE.Controls.Add(Me.lblNombre)
    Me.gbDatosDRE.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbDatosDRE.Location = New System.Drawing.Point(47, 203)
    Me.gbDatosDRE.Name = "gbDatosDRE"
    Me.gbDatosDRE.Size = New System.Drawing.Size(401, 233)
    Me.gbDatosDRE.TabIndex = 0
    Me.gbDatosDRE.TabStop = False
    Me.gbDatosDRE.Text = "Datos de la DRE"
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(485, 384)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 5
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(485, 214)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
    Me.btnRegistrar.TabIndex = 1
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(485, 273)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
    Me.btnCancelar.TabIndex = 4
    Me.btnCancelar.Text = "&Deshacer"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnModificar
    '
    Me.btnModificar.BackColor = System.Drawing.Color.White
    Me.btnModificar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnModificar.Location = New System.Drawing.Point(485, 52)
    Me.btnModificar.Name = "btnModificar"
    Me.btnModificar.Size = New System.Drawing.Size(110, 52)
    Me.btnModificar.TabIndex = 2
    Me.btnModificar.Text = "&Modificar"
    Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnModificar.UseVisualStyleBackColor = False
    '
    'errDre
    '
    Me.errDre.ContainerControl = Me
    '
    'gbDRE
    '
    Me.gbDRE.Controls.Add(Me.dgvDRE)
    Me.gbDRE.Location = New System.Drawing.Point(47, 22)
    Me.gbDRE.Name = "gbDRE"
    Me.gbDRE.Size = New System.Drawing.Size(401, 156)
    Me.gbDRE.TabIndex = 3
    Me.gbDRE.TabStop = False
    Me.gbDRE.Text = "DRE"
    '
    'dgvDRE
    '
    Me.dgvDRE.AllowUserToAddRows = False
    Me.dgvDRE.AllowUserToDeleteRows = False
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvDRE.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvDRE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvDRE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNombre, Me.cgCodigo})
    Me.dgvDRE.Location = New System.Drawing.Point(23, 30)
    Me.dgvDRE.Name = "dgvDRE"
    Me.dgvDRE.ReadOnly = True
    Me.dgvDRE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvDRE.Size = New System.Drawing.Size(354, 102)
    Me.dgvDRE.TabIndex = 0
    '
    'cdNombre
    '
    Me.cdNombre.HeaderText = "Nombre"
    Me.cdNombre.Name = "cdNombre"
    Me.cdNombre.ReadOnly = True
    Me.cdNombre.Width = 210
    '
    'cgCodigo
    '
    Me.cgCodigo.HeaderText = "Codigo Ugel"
    Me.cgCodigo.Name = "cgCodigo"
    Me.cgCodigo.ReadOnly = True
    '
    'lblMensaje
    '
    Me.lblMensaje.AutoSize = True
    Me.lblMensaje.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMensaje.ForeColor = System.Drawing.SystemColors.ActiveCaption
    Me.lblMensaje.Location = New System.Drawing.Point(43, 452)
    Me.lblMensaje.Name = "lblMensaje"
    Me.lblMensaje.Size = New System.Drawing.Size(416, 19)
    Me.lblMensaje.TabIndex = 7
    Me.lblMensaje.Text = "Click en Deshacer para anular la operación y volver a iniciar."
    '
    'frmDRE
    '
    Me.AcceptButton = Me.btnRegistrar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(643, 485)
    Me.Controls.Add(Me.lblMensaje)
    Me.Controls.Add(Me.gbDRE)
    Me.Controls.Add(Me.btnModificar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.gbDatosDRE)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.Name = "frmDRE"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión DRE"
    Me.gbDatosDRE.ResumeLayout(False)
    Me.gbDatosDRE.PerformLayout()
    CType(Me.errDre, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbDRE.ResumeLayout(False)
    CType(Me.dgvDRE, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblNombre As System.Windows.Forms.Label
  Friend WithEvents lblDireccion As System.Windows.Forms.Label
  Friend WithEvents lblContacto As System.Windows.Forms.Label
  Friend WithEvents lblTelefono As System.Windows.Forms.Label
  Friend WithEvents lblCodigo As System.Windows.Forms.Label
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
  Friend WithEvents txtContacto As System.Windows.Forms.TextBox
  Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
  Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
  Friend WithEvents gbDatosDRE As System.Windows.Forms.GroupBox
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnModificar As System.Windows.Forms.Button
  Friend WithEvents errDre As System.Windows.Forms.ErrorProvider
  Friend WithEvents gbDRE As System.Windows.Forms.GroupBox
  Friend WithEvents dgvDRE As System.Windows.Forms.DataGridView
  Friend WithEvents cdNombre As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cgCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents lblMensaje As System.Windows.Forms.Label
End Class
