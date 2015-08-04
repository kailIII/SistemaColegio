<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCajaChica
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
    Me.gbListado = New System.Windows.Forms.GroupBox()
    Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
    Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
    Me.lblFechaFin = New System.Windows.Forms.Label()
    Me.lblFechaInicio = New System.Windows.Forms.Label()
    Me.btnNuevo = New System.Windows.Forms.Button()
    Me.btnListar = New System.Windows.Forms.Button()
    Me.dgvCajaChica = New System.Windows.Forms.DataGridView()
    Me.cdFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdNombreNivel = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdEgreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdTipoDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btnAnular = New System.Windows.Forms.Button()
    Me.btnEditar = New System.Windows.Forms.Button()
    Me.gbMantenimiento = New System.Windows.Forms.GroupBox()
    Me.txtNumero = New System.Windows.Forms.TextBox()
    Me.lblNumero = New System.Windows.Forms.Label()
    Me.cboDescripcion = New System.Windows.Forms.ComboBox()
    Me.nudMonto = New System.Windows.Forms.NumericUpDown()
    Me.lblMonto = New System.Windows.Forms.Label()
    Me.cboTipoDocumento = New System.Windows.Forms.ComboBox()
    Me.lblTipo = New System.Windows.Forms.Label()
    Me.cboBeneficiario = New System.Windows.Forms.ComboBox()
    Me.lblBeneficiario = New System.Windows.Forms.Label()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.btnRegistrar = New System.Windows.Forms.Button()
    Me.lblDescripcion = New System.Windows.Forms.Label()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.rbIngreso = New System.Windows.Forms.RadioButton()
    Me.rbEgreso = New System.Windows.Forms.RadioButton()
    Me.gbListado.SuspendLayout()
    CType(Me.dgvCajaChica, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbMantenimiento.SuspendLayout()
    CType(Me.nudMonto, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'gbListado
    '
    Me.gbListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbListado.Controls.Add(Me.dtpFechaFin)
    Me.gbListado.Controls.Add(Me.dtpFechaInicio)
    Me.gbListado.Controls.Add(Me.lblFechaFin)
    Me.gbListado.Controls.Add(Me.lblFechaInicio)
    Me.gbListado.Controls.Add(Me.btnNuevo)
    Me.gbListado.Controls.Add(Me.btnListar)
    Me.gbListado.Controls.Add(Me.dgvCajaChica)
    Me.gbListado.Controls.Add(Me.btnAnular)
    Me.gbListado.Controls.Add(Me.btnEditar)
    Me.gbListado.Location = New System.Drawing.Point(322, 12)
    Me.gbListado.Name = "gbListado"
    Me.gbListado.Size = New System.Drawing.Size(691, 392)
    Me.gbListado.TabIndex = 1
    Me.gbListado.TabStop = False
    '
    'dtpFechaFin
    '
    Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaFin.Location = New System.Drawing.Point(272, 26)
    Me.dtpFechaFin.Name = "dtpFechaFin"
    Me.dtpFechaFin.Size = New System.Drawing.Size(92, 20)
    Me.dtpFechaFin.TabIndex = 3
    '
    'dtpFechaInicio
    '
    Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaInicio.Location = New System.Drawing.Point(83, 28)
    Me.dtpFechaInicio.Name = "dtpFechaInicio"
    Me.dtpFechaInicio.Size = New System.Drawing.Size(92, 20)
    Me.dtpFechaInicio.TabIndex = 1
    '
    'lblFechaFin
    '
    Me.lblFechaFin.AutoSize = True
    Me.lblFechaFin.Location = New System.Drawing.Point(212, 32)
    Me.lblFechaFin.Name = "lblFechaFin"
    Me.lblFechaFin.Size = New System.Drawing.Size(54, 13)
    Me.lblFechaFin.TabIndex = 2
    Me.lblFechaFin.Text = "Fecha Fin"
    '
    'lblFechaInicio
    '
    Me.lblFechaInicio.AutoSize = True
    Me.lblFechaInicio.Location = New System.Drawing.Point(12, 30)
    Me.lblFechaInicio.Name = "lblFechaInicio"
    Me.lblFechaInicio.Size = New System.Drawing.Size(65, 13)
    Me.lblFechaInicio.TabIndex = 0
    Me.lblFechaInicio.Text = "Fecha Inicio"
    '
    'btnNuevo
    '
    Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnNuevo.BackColor = System.Drawing.Color.White
    Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnNuevo.Location = New System.Drawing.Point(27, 325)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(108, 52)
    Me.btnNuevo.TabIndex = 6
    Me.btnNuevo.Text = "&Nuevo"
    Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnNuevo.UseVisualStyleBackColor = False
    '
    'btnListar
    '
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnListar.Location = New System.Drawing.Point(433, 19)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(110, 52)
    Me.btnListar.TabIndex = 4
    Me.btnListar.Text = "&Listar"
    Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnListar.UseVisualStyleBackColor = False
    '
    'dgvCajaChica
    '
    Me.dgvCajaChica.AllowUserToAddRows = False
    Me.dgvCajaChica.AllowUserToDeleteRows = False
    Me.dgvCajaChica.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvCajaChica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvCajaChica.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdFecha, Me.cdNombreNivel, Me.cdDescripcion, Me.cdIngreso, Me.cdEgreso, Me.cdTipoDocumento})
    Me.dgvCajaChica.Location = New System.Drawing.Point(15, 80)
    Me.dgvCajaChica.MultiSelect = False
    Me.dgvCajaChica.Name = "dgvCajaChica"
    Me.dgvCajaChica.ReadOnly = True
    Me.dgvCajaChica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvCajaChica.Size = New System.Drawing.Size(649, 230)
    Me.dgvCajaChica.TabIndex = 5
    '
    'cdFecha
    '
    Me.cdFecha.DataPropertyName = "fecha"
    Me.cdFecha.HeaderText = "Fecha"
    Me.cdFecha.Name = "cdFecha"
    Me.cdFecha.ReadOnly = True
    Me.cdFecha.Width = 90
    '
    'cdNombreNivel
    '
    Me.cdNombreNivel.DataPropertyName = "NombreCompleto"
    Me.cdNombreNivel.HeaderText = "Beneficiario"
    Me.cdNombreNivel.Name = "cdNombreNivel"
    Me.cdNombreNivel.ReadOnly = True
    Me.cdNombreNivel.Width = 150
    '
    'cdDescripcion
    '
    Me.cdDescripcion.DataPropertyName = "descripcion"
    Me.cdDescripcion.HeaderText = "Descripción"
    Me.cdDescripcion.Name = "cdDescripcion"
    Me.cdDescripcion.ReadOnly = True
    Me.cdDescripcion.Width = 200
    '
    'cdIngreso
    '
    Me.cdIngreso.DataPropertyName = "ingreso"
    Me.cdIngreso.HeaderText = "Ingreso"
    Me.cdIngreso.Name = "cdIngreso"
    Me.cdIngreso.ReadOnly = True
    Me.cdIngreso.Width = 50
    '
    'cdEgreso
    '
    Me.cdEgreso.DataPropertyName = "egreso"
    Me.cdEgreso.HeaderText = "Egreso"
    Me.cdEgreso.Name = "cdEgreso"
    Me.cdEgreso.ReadOnly = True
    '
    'cdTipoDocumento
    '
    Me.cdTipoDocumento.DataPropertyName = "documento"
    Me.cdTipoDocumento.HeaderText = "Documento"
    Me.cdTipoDocumento.Name = "cdTipoDocumento"
    Me.cdTipoDocumento.ReadOnly = True
    Me.cdTipoDocumento.Width = 90
    '
    'btnAnular
    '
    Me.btnAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnAnular.BackColor = System.Drawing.Color.White
    Me.btnAnular.Enabled = False
    Me.btnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAnular.Location = New System.Drawing.Point(283, 325)
    Me.btnAnular.Name = "btnAnular"
    Me.btnAnular.Size = New System.Drawing.Size(110, 52)
    Me.btnAnular.TabIndex = 8
    Me.btnAnular.Text = "&Anular"
    Me.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnAnular.UseVisualStyleBackColor = False
    '
    'btnEditar
    '
    Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnEditar.BackColor = System.Drawing.Color.White
    Me.btnEditar.Enabled = False
    Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnEditar.Location = New System.Drawing.Point(158, 325)
    Me.btnEditar.Name = "btnEditar"
    Me.btnEditar.Size = New System.Drawing.Size(108, 52)
    Me.btnEditar.TabIndex = 7
    Me.btnEditar.Text = "&Editar"
    Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnEditar.UseVisualStyleBackColor = False
    '
    'gbMantenimiento
    '
    Me.gbMantenimiento.Controls.Add(Me.txtNumero)
    Me.gbMantenimiento.Controls.Add(Me.lblNumero)
    Me.gbMantenimiento.Controls.Add(Me.cboDescripcion)
    Me.gbMantenimiento.Controls.Add(Me.nudMonto)
    Me.gbMantenimiento.Controls.Add(Me.lblMonto)
    Me.gbMantenimiento.Controls.Add(Me.cboTipoDocumento)
    Me.gbMantenimiento.Controls.Add(Me.lblTipo)
    Me.gbMantenimiento.Controls.Add(Me.rbEgreso)
    Me.gbMantenimiento.Controls.Add(Me.rbIngreso)
    Me.gbMantenimiento.Controls.Add(Me.cboBeneficiario)
    Me.gbMantenimiento.Controls.Add(Me.lblBeneficiario)
    Me.gbMantenimiento.Controls.Add(Me.btnCancelar)
    Me.gbMantenimiento.Controls.Add(Me.btnRegistrar)
    Me.gbMantenimiento.Controls.Add(Me.lblDescripcion)
    Me.gbMantenimiento.Enabled = False
    Me.gbMantenimiento.Location = New System.Drawing.Point(5, 12)
    Me.gbMantenimiento.Name = "gbMantenimiento"
    Me.gbMantenimiento.Size = New System.Drawing.Size(291, 377)
    Me.gbMantenimiento.TabIndex = 0
    Me.gbMantenimiento.TabStop = False
    '
    'txtNumero
    '
    Me.txtNumero.Enabled = False
    Me.txtNumero.Location = New System.Drawing.Point(92, 200)
    Me.txtNumero.Name = "txtNumero"
    Me.txtNumero.Size = New System.Drawing.Size(100, 20)
    Me.txtNumero.TabIndex = 9
    '
    'lblNumero
    '
    Me.lblNumero.AutoSize = True
    Me.lblNumero.Enabled = False
    Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNumero.Location = New System.Drawing.Point(23, 201)
    Me.lblNumero.Name = "lblNumero"
    Me.lblNumero.Size = New System.Drawing.Size(52, 15)
    Me.lblNumero.TabIndex = 8
    Me.lblNumero.Text = "Número"
    '
    'cboDescripcion
    '
    Me.cboDescripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboDescripcion.Enabled = False
    Me.cboDescripcion.FormattingEnabled = True
    Me.cboDescripcion.Location = New System.Drawing.Point(125, 111)
    Me.cboDescripcion.Name = "cboDescripcion"
    Me.cboDescripcion.Size = New System.Drawing.Size(144, 21)
    Me.cboDescripcion.TabIndex = 5
    '
    'nudMonto
    '
    Me.nudMonto.Enabled = False
    Me.nudMonto.Location = New System.Drawing.Point(92, 235)
    Me.nudMonto.Name = "nudMonto"
    Me.nudMonto.Size = New System.Drawing.Size(92, 20)
    Me.nudMonto.TabIndex = 11
    '
    'lblMonto
    '
    Me.lblMonto.AutoSize = True
    Me.lblMonto.Enabled = False
    Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMonto.Location = New System.Drawing.Point(23, 240)
    Me.lblMonto.Name = "lblMonto"
    Me.lblMonto.Size = New System.Drawing.Size(42, 15)
    Me.lblMonto.TabIndex = 10
    Me.lblMonto.Text = "Monto"
    '
    'cboTipoDocumento
    '
    Me.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoDocumento.Enabled = False
    Me.cboTipoDocumento.FormattingEnabled = True
    Me.cboTipoDocumento.Location = New System.Drawing.Point(125, 152)
    Me.cboTipoDocumento.Name = "cboTipoDocumento"
    Me.cboTipoDocumento.Size = New System.Drawing.Size(144, 21)
    Me.cboTipoDocumento.TabIndex = 7
    '
    'lblTipo
    '
    Me.lblTipo.AutoSize = True
    Me.lblTipo.Enabled = False
    Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTipo.Location = New System.Drawing.Point(21, 158)
    Me.lblTipo.Name = "lblTipo"
    Me.lblTipo.Size = New System.Drawing.Size(98, 15)
    Me.lblTipo.TabIndex = 6
    Me.lblTipo.Text = "Tipo Documento"
    '
    'cboBeneficiario
    '
    Me.cboBeneficiario.Enabled = False
    Me.cboBeneficiario.FormattingEnabled = True
    Me.cboBeneficiario.Location = New System.Drawing.Point(125, 71)
    Me.cboBeneficiario.Name = "cboBeneficiario"
    Me.cboBeneficiario.Size = New System.Drawing.Size(144, 21)
    Me.cboBeneficiario.TabIndex = 3
    '
    'lblBeneficiario
    '
    Me.lblBeneficiario.AutoSize = True
    Me.lblBeneficiario.Enabled = False
    Me.lblBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblBeneficiario.Location = New System.Drawing.Point(21, 71)
    Me.lblBeneficiario.Name = "lblBeneficiario"
    Me.lblBeneficiario.Size = New System.Drawing.Size(72, 15)
    Me.lblBeneficiario.TabIndex = 2
    Me.lblBeneficiario.Text = "Beneficiario"
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Enabled = False
    Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(159, 303)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
    Me.btnCancelar.TabIndex = 13
    Me.btnCancelar.Text = "&Cancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Enabled = False
    Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(25, 303)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
    Me.btnRegistrar.TabIndex = 12
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'lblDescripcion
    '
    Me.lblDescripcion.AutoSize = True
    Me.lblDescripcion.Enabled = False
    Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDescripcion.Location = New System.Drawing.Point(21, 112)
    Me.lblDescripcion.Name = "lblDescripcion"
    Me.lblDescripcion.Size = New System.Drawing.Size(72, 15)
    Me.lblDescripcion.TabIndex = 4
    Me.lblDescripcion.Text = "Descripción"
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(895, 432)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 2
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'rbIngreso
    '
    Me.rbIngreso.AutoSize = True
    Me.rbIngreso.Enabled = False
    Me.rbIngreso.Location = New System.Drawing.Point(44, 28)
    Me.rbIngreso.Name = "rbIngreso"
    Me.rbIngreso.Size = New System.Drawing.Size(60, 17)
    Me.rbIngreso.TabIndex = 0
    Me.rbIngreso.Text = "Ingreso"
    Me.rbIngreso.UseVisualStyleBackColor = True
    '
    'rbEgreso
    '
    Me.rbEgreso.AutoSize = True
    Me.rbEgreso.Checked = True
    Me.rbEgreso.Enabled = False
    Me.rbEgreso.Location = New System.Drawing.Point(134, 28)
    Me.rbEgreso.Name = "rbEgreso"
    Me.rbEgreso.Size = New System.Drawing.Size(58, 17)
    Me.rbEgreso.TabIndex = 1
    Me.rbEgreso.TabStop = True
    Me.rbEgreso.Text = "Egreso"
    Me.rbEgreso.UseVisualStyleBackColor = True
    '
    'frmCajaChica
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1017, 496)
    Me.Controls.Add(Me.gbListado)
    Me.Controls.Add(Me.gbMantenimiento)
    Me.Controls.Add(Me.btnCerrar)
    Me.Name = "frmCajaChica"
    Me.Text = "Gestión Caja Chica"
    Me.gbListado.ResumeLayout(False)
    Me.gbListado.PerformLayout()
    CType(Me.dgvCajaChica, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbMantenimiento.ResumeLayout(False)
    Me.gbMantenimiento.PerformLayout()
    CType(Me.nudMonto, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents gbListado As System.Windows.Forms.GroupBox
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents dgvCajaChica As System.Windows.Forms.DataGridView
  Friend WithEvents btnAnular As System.Windows.Forms.Button
  Friend WithEvents btnEditar As System.Windows.Forms.Button
  Friend WithEvents gbMantenimiento As System.Windows.Forms.GroupBox
  Friend WithEvents lblBeneficiario As System.Windows.Forms.Label
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents lblDescripcion As System.Windows.Forms.Label
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents lblFechaFin As System.Windows.Forms.Label
  Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
  Friend WithEvents nudMonto As System.Windows.Forms.NumericUpDown
  Friend WithEvents lblMonto As System.Windows.Forms.Label
  Friend WithEvents cboTipoDocumento As System.Windows.Forms.ComboBox
  Friend WithEvents lblTipo As System.Windows.Forms.Label
  Friend WithEvents cboBeneficiario As System.Windows.Forms.ComboBox
  Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
  Friend WithEvents cboDescripcion As System.Windows.Forms.ComboBox
  Friend WithEvents txtNumero As System.Windows.Forms.TextBox
  Friend WithEvents lblNumero As System.Windows.Forms.Label
  Friend WithEvents cdFecha As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdNombreNivel As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdIngreso As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdEgreso As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdTipoDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents rbEgreso As System.Windows.Forms.RadioButton
  Friend WithEvents rbIngreso As System.Windows.Forms.RadioButton
End Class
