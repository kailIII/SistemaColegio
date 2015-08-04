<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionCuentaContable
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
    Me.tveCuenta = New System.Windows.Forms.TreeView
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.txtCuentaPadre = New System.Windows.Forms.TextBox
    Me.nudNivel = New System.Windows.Forms.NumericUpDown
    Me.cboTipo = New System.Windows.Forms.ComboBox
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.lblCuentaPadre = New System.Windows.Forms.Label
    Me.lblTipo = New System.Windows.Forms.Label
    Me.lblNivel = New System.Windows.Forms.Label
    Me.txtNumero = New System.Windows.Forms.TextBox
    Me.lblCodigo = New System.Windows.Forms.Label
    Me.txtNombre = New System.Windows.Forms.TextBox
    Me.lblNombre = New System.Windows.Forms.Label
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.ErrorCuenta = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.btnNuevo = New System.Windows.Forms.Button
    Me.btnModificar = New System.Windows.Forms.Button
    Me.btnEliminar = New System.Windows.Forms.Button
    Me.GroupBox1.SuspendLayout()
    CType(Me.nudNivel, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ErrorCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'tveCuenta
    '
    Me.tveCuenta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.tveCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.tveCuenta.Location = New System.Drawing.Point(22, 31)
    Me.tveCuenta.Name = "tveCuenta"
    Me.tveCuenta.Size = New System.Drawing.Size(283, 344)
    Me.tveCuenta.TabIndex = 0
    '
    'GroupBox1
    '
    Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBox1.Controls.Add(Me.txtCuentaPadre)
    Me.GroupBox1.Controls.Add(Me.nudNivel)
    Me.GroupBox1.Controls.Add(Me.cboTipo)
    Me.GroupBox1.Controls.Add(Me.btnCancelar)
    Me.GroupBox1.Controls.Add(Me.btnRegistrar)
    Me.GroupBox1.Controls.Add(Me.lblCuentaPadre)
    Me.GroupBox1.Controls.Add(Me.lblTipo)
    Me.GroupBox1.Controls.Add(Me.lblNivel)
    Me.GroupBox1.Controls.Add(Me.txtNumero)
    Me.GroupBox1.Controls.Add(Me.lblCodigo)
    Me.GroupBox1.Controls.Add(Me.txtNombre)
    Me.GroupBox1.Controls.Add(Me.lblNombre)
    Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.GroupBox1.Location = New System.Drawing.Point(311, 31)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(469, 343)
    Me.GroupBox1.TabIndex = 4
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Cuenta"
    '
    'txtCuentaPadre
    '
    Me.txtCuentaPadre.BackColor = System.Drawing.SystemColors.Window
    Me.txtCuentaPadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtCuentaPadre.Enabled = False
    Me.txtCuentaPadre.Location = New System.Drawing.Point(130, 73)
    Me.txtCuentaPadre.Name = "txtCuentaPadre"
    Me.txtCuentaPadre.Size = New System.Drawing.Size(328, 24)
    Me.txtCuentaPadre.TabIndex = 3
    '
    'nudNivel
    '
    Me.nudNivel.Location = New System.Drawing.Point(130, 38)
    Me.nudNivel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.nudNivel.Name = "nudNivel"
    Me.nudNivel.ReadOnly = True
    Me.nudNivel.Size = New System.Drawing.Size(70, 24)
    Me.nudNivel.TabIndex = 1
    Me.nudNivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    Me.nudNivel.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'cboTipo
    '
    Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipo.FormattingEnabled = True
    Me.cboTipo.Items.AddRange(New Object() {"Formal", "Interno"})
    Me.cboTipo.Location = New System.Drawing.Point(130, 193)
    Me.cboTipo.Name = "cboTipo"
    Me.cboTipo.Size = New System.Drawing.Size(220, 26)
    Me.cboTipo.TabIndex = 9
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(330, 285)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(133, 52)
    Me.btnCancelar.TabIndex = 11
    Me.btnCancelar.Text = "&Cancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(191, 285)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(133, 52)
    Me.btnRegistrar.TabIndex = 10
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'lblCuentaPadre
    '
    Me.lblCuentaPadre.AutoSize = True
    Me.lblCuentaPadre.Location = New System.Drawing.Point(20, 79)
    Me.lblCuentaPadre.Name = "lblCuentaPadre"
    Me.lblCuentaPadre.Size = New System.Drawing.Size(115, 18)
    Me.lblCuentaPadre.TabIndex = 2
    Me.lblCuentaPadre.Text = "Cuenta Padre "
    '
    'lblTipo
    '
    Me.lblTipo.AutoSize = True
    Me.lblTipo.Location = New System.Drawing.Point(20, 201)
    Me.lblTipo.Name = "lblTipo"
    Me.lblTipo.Size = New System.Drawing.Size(46, 18)
    Me.lblTipo.TabIndex = 8
    Me.lblTipo.Text = "Tipo "
    '
    'lblNivel
    '
    Me.lblNivel.AutoSize = True
    Me.lblNivel.Location = New System.Drawing.Point(20, 44)
    Me.lblNivel.Name = "lblNivel"
    Me.lblNivel.Size = New System.Drawing.Size(50, 18)
    Me.lblNivel.TabIndex = 0
    Me.lblNivel.Text = "Nivel "
    '
    'txtNumero
    '
    Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtNumero.Location = New System.Drawing.Point(130, 113)
    Me.txtNumero.Name = "txtNumero"
    Me.txtNumero.Size = New System.Drawing.Size(89, 24)
    Me.txtNumero.TabIndex = 5
    '
    'lblCodigo
    '
    Me.lblCodigo.AutoSize = True
    Me.lblCodigo.Location = New System.Drawing.Point(20, 119)
    Me.lblCodigo.Name = "lblCodigo"
    Me.lblCodigo.Size = New System.Drawing.Size(68, 18)
    Me.lblCodigo.TabIndex = 4
    Me.lblCodigo.Text = "Numero"
    '
    'txtNombre
    '
    Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtNombre.Location = New System.Drawing.Point(130, 156)
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Size = New System.Drawing.Size(328, 24)
    Me.txtNombre.TabIndex = 7
    '
    'lblNombre
    '
    Me.lblNombre.AutoSize = True
    Me.lblNombre.Location = New System.Drawing.Point(20, 162)
    Me.lblNombre.Name = "lblNombre"
    Me.lblNombre.Size = New System.Drawing.Size(68, 18)
    Me.lblNombre.TabIndex = 6
    Me.lblNombre.Text = "Nombre"
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(670, 391)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 58)
    Me.btnCerrar.TabIndex = 7
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'ErrorCuenta
    '
    Me.ErrorCuenta.ContainerControl = Me
    '
    'btnNuevo
    '
    Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnNuevo.BackColor = System.Drawing.Color.White
    Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
    Me.btnNuevo.Location = New System.Drawing.Point(22, 382)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(71, 68)
    Me.btnNuevo.TabIndex = 1
    Me.btnNuevo.Text = "&Nuevo"
    Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
    Me.btnNuevo.UseVisualStyleBackColor = False
    '
    'btnModificar
    '
    Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnModificar.BackColor = System.Drawing.Color.White
    Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
    Me.btnModificar.Location = New System.Drawing.Point(128, 382)
    Me.btnModificar.Name = "btnModificar"
    Me.btnModificar.Size = New System.Drawing.Size(71, 68)
    Me.btnModificar.TabIndex = 2
    Me.btnModificar.Text = "&Modificar"
    Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
    Me.btnModificar.UseVisualStyleBackColor = False
    '
    'btnEliminar
    '
    Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnEliminar.BackColor = System.Drawing.Color.White
    Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
    Me.btnEliminar.Location = New System.Drawing.Point(234, 381)
    Me.btnEliminar.Name = "btnEliminar"
    Me.btnEliminar.Size = New System.Drawing.Size(71, 68)
    Me.btnEliminar.TabIndex = 3
    Me.btnEliminar.Text = "&Eliminar"
    Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
    Me.btnEliminar.UseVisualStyleBackColor = False
    '
    'frmGestionCuentaContable
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.CancelButton = Me.btnCerrar
    Me.ClientSize = New System.Drawing.Size(792, 462)
    Me.Controls.Add(Me.btnEliminar)
    Me.Controls.Add(Me.btnModificar)
    Me.Controls.Add(Me.btnNuevo)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.tveCuenta)
    Me.MaximizeBox = False
    Me.Name = "frmGestionCuentaContable"
    Me.Text = "REGISTRAR CUENTA"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    CType(Me.nudNivel, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ErrorCuenta, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents tveCuenta As System.Windows.Forms.TreeView
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents lblNombre As System.Windows.Forms.Label
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents lblNivel As System.Windows.Forms.Label
  Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
  Friend WithEvents lblTipo As System.Windows.Forms.Label
  Friend WithEvents txtNumero As System.Windows.Forms.TextBox
  Friend WithEvents lblCodigo As System.Windows.Forms.Label
  Friend WithEvents txtCuentaPadre As System.Windows.Forms.TextBox
  Friend WithEvents lblCuentaPadre As System.Windows.Forms.Label
  Friend WithEvents ErrorCuenta As System.Windows.Forms.ErrorProvider
  Friend WithEvents nudNivel As System.Windows.Forms.NumericUpDown
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents btnEliminar As System.Windows.Forms.Button
  Friend WithEvents btnModificar As System.Windows.Forms.Button
End Class
