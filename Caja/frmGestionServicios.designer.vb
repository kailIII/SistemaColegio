<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionServicios
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.gbServicio = New System.Windows.Forms.GroupBox()
    Me.cboCuenta = New System.Windows.Forms.ComboBox()
    Me.txtDescripcion = New System.Windows.Forms.TextBox()
    Me.chkCaduca = New System.Windows.Forms.CheckBox()
    Me.chkPagoBanco = New System.Windows.Forms.CheckBox()
    Me.chkVigencia = New System.Windows.Forms.CheckBox()
    Me.cboNivel = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.btnModificar = New System.Windows.Forms.Button()
    Me.cbentidad = New System.Windows.Forms.ComboBox()
    Me.btnRegistrar = New System.Windows.Forms.Button()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.cbTipo = New System.Windows.Forms.ComboBox()
    Me.txtMonto = New System.Windows.Forms.TextBox()
    Me.txtNombre = New System.Windows.Forms.TextBox()
    Me.lbMonto = New System.Windows.Forms.Label()
    Me.lbTipo = New System.Windows.Forms.Label()
    Me.lbDescripcion = New System.Windows.Forms.Label()
    Me.lbNombre = New System.Windows.Forms.Label()
    Me.dgvServicio = New System.Windows.Forms.DataGridView()
    Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.colMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdCodigoCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.colEntidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.colVigencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.codigoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.errValida = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.btnNuevo = New System.Windows.Forms.Button()
    Me.btnSeleccionar = New System.Windows.Forms.Button()
    Me.gbBuscar = New System.Windows.Forms.GroupBox()
    Me.gbServicio.SuspendLayout()
    CType(Me.dgvServicio, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.errValida, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbBuscar.SuspendLayout()
    Me.SuspendLayout()
    '
    'gbServicio
    '
    Me.gbServicio.Controls.Add(Me.cboCuenta)
    Me.gbServicio.Controls.Add(Me.txtDescripcion)
    Me.gbServicio.Controls.Add(Me.chkCaduca)
    Me.gbServicio.Controls.Add(Me.chkPagoBanco)
    Me.gbServicio.Controls.Add(Me.chkVigencia)
    Me.gbServicio.Controls.Add(Me.cboNivel)
    Me.gbServicio.Controls.Add(Me.Label2)
    Me.gbServicio.Controls.Add(Me.Label1)
    Me.gbServicio.Controls.Add(Me.btnModificar)
    Me.gbServicio.Controls.Add(Me.cbentidad)
    Me.gbServicio.Controls.Add(Me.btnRegistrar)
    Me.gbServicio.Controls.Add(Me.Label5)
    Me.gbServicio.Controls.Add(Me.cbTipo)
    Me.gbServicio.Controls.Add(Me.txtMonto)
    Me.gbServicio.Controls.Add(Me.txtNombre)
    Me.gbServicio.Controls.Add(Me.lbMonto)
    Me.gbServicio.Controls.Add(Me.lbTipo)
    Me.gbServicio.Controls.Add(Me.lbDescripcion)
    Me.gbServicio.Controls.Add(Me.lbNombre)
    Me.gbServicio.Location = New System.Drawing.Point(12, 12)
    Me.gbServicio.Name = "gbServicio"
    Me.gbServicio.Size = New System.Drawing.Size(483, 431)
    Me.gbServicio.TabIndex = 0
    Me.gbServicio.TabStop = False
    Me.gbServicio.Text = "Servicio"
    '
    'cboCuenta
    '
    Me.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCuenta.FormattingEnabled = True
    Me.cboCuenta.Items.AddRange(New Object() {"INSTITUCION", "COPAFA"})
    Me.cboCuenta.Location = New System.Drawing.Point(93, 163)
    Me.cboCuenta.Name = "cboCuenta"
    Me.cboCuenta.Size = New System.Drawing.Size(374, 21)
    Me.cboCuenta.TabIndex = 11
    '
    'txtDescripcion
    '
    Me.txtDescripcion.Location = New System.Drawing.Point(93, 196)
    Me.txtDescripcion.Multiline = True
    Me.txtDescripcion.Name = "txtDescripcion"
    Me.txtDescripcion.Size = New System.Drawing.Size(374, 36)
    Me.txtDescripcion.TabIndex = 13
    '
    'chkCaduca
    '
    Me.chkCaduca.AutoSize = True
    Me.chkCaduca.Location = New System.Drawing.Point(93, 288)
    Me.chkCaduca.Name = "chkCaduca"
    Me.chkCaduca.Size = New System.Drawing.Size(151, 17)
    Me.chkCaduca.TabIndex = 15
    Me.chkCaduca.Text = "Tiene &fecha de caducidad"
    Me.chkCaduca.UseVisualStyleBackColor = True
    '
    'chkPagoBanco
    '
    Me.chkPagoBanco.AutoSize = True
    Me.chkPagoBanco.Location = New System.Drawing.Point(93, 256)
    Me.chkPagoBanco.Name = "chkPagoBanco"
    Me.chkPagoBanco.Size = New System.Drawing.Size(161, 17)
    Me.chkPagoBanco.TabIndex = 14
    Me.chkPagoBanco.Text = "Se puede pagar en el &banco"
    Me.chkPagoBanco.UseVisualStyleBackColor = True
    '
    'chkVigencia
    '
    Me.chkVigencia.AutoSize = True
    Me.chkVigencia.Location = New System.Drawing.Point(93, 321)
    Me.chkVigencia.Name = "chkVigencia"
    Me.chkVigencia.Size = New System.Drawing.Size(67, 17)
    Me.chkVigencia.TabIndex = 16
    Me.chkVigencia.Text = "Vigencia"
    Me.chkVigencia.UseVisualStyleBackColor = True
    '
    'cboNivel
    '
    Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Location = New System.Drawing.Point(93, 78)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(171, 21)
    Me.cboNivel.TabIndex = 5
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(51, 86)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(31, 13)
    Me.Label2.TabIndex = 4
    Me.Label2.Text = "Nivel"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(44, 59)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(43, 13)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Entidad"
    '
    'btnModificar
    '
    Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnModificar.BackColor = System.Drawing.Color.White
    Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnModificar.Location = New System.Drawing.Point(357, 373)
    Me.btnModificar.Name = "btnModificar"
    Me.btnModificar.Size = New System.Drawing.Size(110, 52)
    Me.btnModificar.TabIndex = 18
    Me.btnModificar.Text = "&Cancelar"
    Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnModificar.UseVisualStyleBackColor = False
    '
    'cbentidad
    '
    Me.cbentidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbentidad.FormattingEnabled = True
    Me.cbentidad.Items.AddRange(New Object() {"INSTITUCION", "COPAFA"})
    Me.cbentidad.Location = New System.Drawing.Point(93, 51)
    Me.cbentidad.Name = "cbentidad"
    Me.cbentidad.Size = New System.Drawing.Size(171, 21)
    Me.cbentidad.TabIndex = 3
    '
    'btnRegistrar
    '
    Me.btnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(231, 373)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
    Me.btnRegistrar.TabIndex = 17
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(13, 171)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(68, 13)
    Me.Label5.TabIndex = 10
    Me.Label5.Text = "Cta Contable"
    '
    'cbTipo
    '
    Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbTipo.FormattingEnabled = True
    Me.cbTipo.Location = New System.Drawing.Point(93, 105)
    Me.cbTipo.Name = "cbTipo"
    Me.cbTipo.Size = New System.Drawing.Size(171, 21)
    Me.cbTipo.TabIndex = 7
    '
    'txtMonto
    '
    Me.txtMonto.Location = New System.Drawing.Point(93, 132)
    Me.txtMonto.Name = "txtMonto"
    Me.txtMonto.Size = New System.Drawing.Size(110, 20)
    Me.txtMonto.TabIndex = 9
    '
    'txtNombre
    '
    Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtNombre.ForeColor = System.Drawing.SystemColors.ControlText
    Me.txtNombre.Location = New System.Drawing.Point(93, 25)
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Size = New System.Drawing.Size(248, 20)
    Me.txtNombre.TabIndex = 1
    '
    'lbMonto
    '
    Me.lbMonto.AutoSize = True
    Me.lbMonto.Location = New System.Drawing.Point(50, 139)
    Me.lbMonto.Name = "lbMonto"
    Me.lbMonto.Size = New System.Drawing.Size(37, 13)
    Me.lbMonto.TabIndex = 8
    Me.lbMonto.Text = "Monto"
    '
    'lbTipo
    '
    Me.lbTipo.AutoSize = True
    Me.lbTipo.Location = New System.Drawing.Point(53, 113)
    Me.lbTipo.Name = "lbTipo"
    Me.lbTipo.Size = New System.Drawing.Size(28, 13)
    Me.lbTipo.TabIndex = 6
    Me.lbTipo.Text = "Tipo"
    '
    'lbDescripcion
    '
    Me.lbDescripcion.AutoSize = True
    Me.lbDescripcion.Location = New System.Drawing.Point(18, 196)
    Me.lbDescripcion.Name = "lbDescripcion"
    Me.lbDescripcion.Size = New System.Drawing.Size(63, 13)
    Me.lbDescripcion.TabIndex = 12
    Me.lbDescripcion.Text = "Descripcion"
    '
    'lbNombre
    '
    Me.lbNombre.AutoSize = True
    Me.lbNombre.Location = New System.Drawing.Point(37, 32)
    Me.lbNombre.Name = "lbNombre"
    Me.lbNombre.Size = New System.Drawing.Size(44, 13)
    Me.lbNombre.TabIndex = 0
    Me.lbNombre.Text = "Nombre"
    '
    'dgvServicio
    '
    Me.dgvServicio.AllowUserToAddRows = False
    Me.dgvServicio.AllowUserToDeleteRows = False
    Me.dgvServicio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNombre, Me.colMonto, Me.cdCodigoCuenta, Me.colEntidad, Me.colVigencia, Me.codigoServicio})
    Me.dgvServicio.Location = New System.Drawing.Point(6, 14)
    Me.dgvServicio.Name = "dgvServicio"
    Me.dgvServicio.RowHeadersVisible = False
    Me.dgvServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvServicio.Size = New System.Drawing.Size(399, 310)
    Me.dgvServicio.TabIndex = 0
    Me.dgvServicio.TabStop = False
    '
    'colNombre
    '
    Me.colNombre.DataPropertyName = "nombre"
    Me.colNombre.HeaderText = "Nombre"
    Me.colNombre.Name = "colNombre"
    Me.colNombre.Width = 200
    '
    'colMonto
    '
    Me.colMonto.DataPropertyName = "monto"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.colMonto.DefaultCellStyle = DataGridViewCellStyle1
    Me.colMonto.HeaderText = "Monto"
    Me.colMonto.Name = "colMonto"
    Me.colMonto.Width = 80
    '
    'cdCodigoCuenta
    '
    Me.cdCodigoCuenta.DataPropertyName = "CodigoCuenta"
    Me.cdCodigoCuenta.HeaderText = "Cuenta"
    Me.cdCodigoCuenta.Name = "cdCodigoCuenta"
    Me.cdCodigoCuenta.ReadOnly = True
    '
    'colEntidad
    '
    Me.colEntidad.DataPropertyName = "NombreNivel"
    Me.colEntidad.HeaderText = "Nivel Academico"
    Me.colEntidad.Name = "colEntidad"
    Me.colEntidad.Width = 110
    '
    'colVigencia
    '
    Me.colVigencia.DataPropertyName = "leerVigencia"
    Me.colVigencia.HeaderText = "Vigencia"
    Me.colVigencia.Name = "colVigencia"
    Me.colVigencia.Width = 80
    '
    'codigoServicio
    '
    Me.codigoServicio.DataPropertyName = "codigoServicio"
    Me.codigoServicio.HeaderText = "colServicio"
    Me.codigoServicio.Name = "codigoServicio"
    Me.codigoServicio.Visible = False
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(802, 417)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 2
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'errValida
    '
    Me.errValida.ContainerControl = Me
    '
    'btnNuevo
    '
    Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnNuevo.BackColor = System.Drawing.Color.White
    Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnNuevo.Location = New System.Drawing.Point(6, 341)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(110, 52)
    Me.btnNuevo.TabIndex = 1
    Me.btnNuevo.Text = "&Nuevo"
    Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnNuevo.UseVisualStyleBackColor = False
    '
    'btnSeleccionar
    '
    Me.btnSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnSeleccionar.BackColor = System.Drawing.Color.White
    Me.btnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnSeleccionar.Location = New System.Drawing.Point(122, 341)
    Me.btnSeleccionar.Name = "btnSeleccionar"
    Me.btnSeleccionar.Size = New System.Drawing.Size(110, 52)
    Me.btnSeleccionar.TabIndex = 2
    Me.btnSeleccionar.Text = "&Seleccionar"
    Me.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnSeleccionar.UseVisualStyleBackColor = False
    '
    'gbBuscar
    '
    Me.gbBuscar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbBuscar.Controls.Add(Me.btnNuevo)
    Me.gbBuscar.Controls.Add(Me.btnSeleccionar)
    Me.gbBuscar.Controls.Add(Me.dgvServicio)
    Me.gbBuscar.Location = New System.Drawing.Point(501, 12)
    Me.gbBuscar.Name = "gbBuscar"
    Me.gbBuscar.Size = New System.Drawing.Size(411, 399)
    Me.gbBuscar.TabIndex = 1
    Me.gbBuscar.TabStop = False
    '
    'frmGestionServicios
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCerrar
    Me.ClientSize = New System.Drawing.Size(924, 481)
    Me.Controls.Add(Me.gbServicio)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.gbBuscar)
    Me.Name = "frmGestionServicios"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestion Servicios"
    Me.gbServicio.ResumeLayout(False)
    Me.gbServicio.PerformLayout()
    CType(Me.dgvServicio, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.errValida, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbBuscar.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents gbServicio As System.Windows.Forms.GroupBox
  Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
  Friend WithEvents txtMonto As System.Windows.Forms.TextBox
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents lbMonto As System.Windows.Forms.Label
  Friend WithEvents lbTipo As System.Windows.Forms.Label
  Friend WithEvents lbDescripcion As System.Windows.Forms.Label
  Friend WithEvents lbNombre As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents dgvServicio As System.Windows.Forms.DataGridView
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnModificar As System.Windows.Forms.Button
  Friend WithEvents errValida As System.Windows.Forms.ErrorProvider
  Friend WithEvents cbentidad As System.Windows.Forms.ComboBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
  Friend WithEvents chkVigencia As System.Windows.Forms.CheckBox
  Friend WithEvents gbBuscar As System.Windows.Forms.GroupBox
  Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
  Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colMonto As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCodigoCuenta As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colEntidad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colVigencia As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents codigoServicio As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cboCuenta As System.Windows.Forms.ComboBox
  Friend WithEvents chkCaduca As System.Windows.Forms.CheckBox
  Friend WithEvents chkPagoBanco As System.Windows.Forms.CheckBox
End Class
