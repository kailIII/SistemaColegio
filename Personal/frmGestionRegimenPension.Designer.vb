<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionRegimenPension
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
    Me.ErrAmbientes = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnModificar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.gbListaService = New System.Windows.Forms.GroupBox
    Me.dgvServices = New System.Windows.Forms.DataGridView
    Me.cdRazonSocial = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.gbService = New System.Windows.Forms.GroupBox
    Me.nudAporte = New System.Windows.Forms.NumericUpDown
    Me.lblPorcentajeAporte = New System.Windows.Forms.Label
    Me.chkVigente = New System.Windows.Forms.CheckBox
    Me.txtNombre = New System.Windows.Forms.TextBox
    Me.lblNombre = New System.Windows.Forms.Label
    Me.txtCodigo = New System.Windows.Forms.TextBox
    Me.lblCodigo = New System.Windows.Forms.Label
    Me.nudComision = New System.Windows.Forms.NumericUpDown
    Me.lblPorcentajeComision = New System.Windows.Forms.Label
    Me.nudPrima = New System.Windows.Forms.NumericUpDown
    Me.lblPorcentajePrima = New System.Windows.Forms.Label
    CType(Me.ErrAmbientes, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbListaService.SuspendLayout()
    CType(Me.dgvServices, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbService.SuspendLayout()
    CType(Me.nudAporte, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nudComision, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nudPrima, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'ErrAmbientes
    '
    Me.ErrAmbientes.ContainerControl = Me
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(839, 99)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
    Me.btnCancelar.TabIndex = 3
    Me.btnCancelar.Text = "&Deshacer"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnModificar
    '
    Me.btnModificar.BackColor = System.Drawing.Color.White
    Me.btnModificar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnModificar.Location = New System.Drawing.Point(112, 330)
    Me.btnModificar.Name = "btnModificar"
    Me.btnModificar.Size = New System.Drawing.Size(110, 52)
    Me.btnModificar.TabIndex = 1
    Me.btnModificar.Text = "&Seleccionar"
    Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnModificar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(839, 363)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 4
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(839, 37)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
    Me.btnRegistrar.TabIndex = 2
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'gbListaService
    '
    Me.gbListaService.Controls.Add(Me.dgvServices)
    Me.gbListaService.Controls.Add(Me.btnModificar)
    Me.gbListaService.Location = New System.Drawing.Point(12, 27)
    Me.gbListaService.Name = "gbListaService"
    Me.gbListaService.Size = New System.Drawing.Size(449, 388)
    Me.gbListaService.TabIndex = 0
    Me.gbListaService.TabStop = False
    Me.gbListaService.Text = "Lista de service"
    '
    'dgvServices
    '
    Me.dgvServices.AllowUserToAddRows = False
    Me.dgvServices.AllowUserToDeleteRows = False
    Me.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvServices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdRazonSocial})
    Me.dgvServices.Location = New System.Drawing.Point(7, 22)
    Me.dgvServices.MultiSelect = False
    Me.dgvServices.Name = "dgvServices"
    Me.dgvServices.ReadOnly = True
    Me.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvServices.Size = New System.Drawing.Size(432, 292)
    Me.dgvServices.TabIndex = 0
    '
    'cdRazonSocial
    '
    Me.cdRazonSocial.DataPropertyName = "RazonSocial"
    Me.cdRazonSocial.HeaderText = "Service"
    Me.cdRazonSocial.Name = "cdRazonSocial"
    Me.cdRazonSocial.ReadOnly = True
    Me.cdRazonSocial.Width = 250
    '
    'gbService
    '
    Me.gbService.Controls.Add(Me.nudPrima)
    Me.gbService.Controls.Add(Me.lblPorcentajePrima)
    Me.gbService.Controls.Add(Me.nudComision)
    Me.gbService.Controls.Add(Me.lblPorcentajeComision)
    Me.gbService.Controls.Add(Me.nudAporte)
    Me.gbService.Controls.Add(Me.lblPorcentajeAporte)
    Me.gbService.Controls.Add(Me.chkVigente)
    Me.gbService.Controls.Add(Me.txtNombre)
    Me.gbService.Controls.Add(Me.lblNombre)
    Me.gbService.Controls.Add(Me.txtCodigo)
    Me.gbService.Controls.Add(Me.lblCodigo)
    Me.gbService.Location = New System.Drawing.Point(467, 27)
    Me.gbService.Name = "gbService"
    Me.gbService.Size = New System.Drawing.Size(360, 388)
    Me.gbService.TabIndex = 1
    Me.gbService.TabStop = False
    Me.gbService.Text = "Service"
    '
    'nudAporte
    '
    Me.nudAporte.Location = New System.Drawing.Point(99, 112)
    Me.nudAporte.Name = "nudAporte"
    Me.nudAporte.Size = New System.Drawing.Size(120, 22)
    Me.nudAporte.TabIndex = 10
    Me.nudAporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'lblPorcentajeAporte
    '
    Me.lblPorcentajeAporte.AutoSize = True
    Me.lblPorcentajeAporte.Location = New System.Drawing.Point(14, 119)
    Me.lblPorcentajeAporte.Name = "lblPorcentajeAporte"
    Me.lblPorcentajeAporte.Size = New System.Drawing.Size(58, 15)
    Me.lblPorcentajeAporte.TabIndex = 9
    Me.lblPorcentajeAporte.Text = "% Aporte"
    '
    'chkVigente
    '
    Me.chkVigente.AutoSize = True
    Me.chkVigente.Checked = True
    Me.chkVigente.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkVigente.Location = New System.Drawing.Point(18, 228)
    Me.chkVigente.Name = "chkVigente"
    Me.chkVigente.Size = New System.Drawing.Size(66, 19)
    Me.chkVigente.TabIndex = 8
    Me.chkVigente.Text = "Vigente"
    Me.chkVigente.UseVisualStyleBackColor = True
    '
    'txtNombre
    '
    Me.txtNombre.Location = New System.Drawing.Point(99, 72)
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Size = New System.Drawing.Size(250, 22)
    Me.txtNombre.TabIndex = 3
    '
    'lblNombre
    '
    Me.lblNombre.AutoSize = True
    Me.lblNombre.Location = New System.Drawing.Point(15, 79)
    Me.lblNombre.Name = "lblNombre"
    Me.lblNombre.Size = New System.Drawing.Size(49, 15)
    Me.lblNombre.TabIndex = 2
    Me.lblNombre.Text = "&Nombre"
    '
    'txtCodigo
    '
    Me.txtCodigo.Location = New System.Drawing.Point(99, 36)
    Me.txtCodigo.Name = "txtCodigo"
    Me.txtCodigo.Size = New System.Drawing.Size(118, 22)
    Me.txtCodigo.TabIndex = 1
    '
    'lblCodigo
    '
    Me.lblCodigo.AutoSize = True
    Me.lblCodigo.Location = New System.Drawing.Point(15, 43)
    Me.lblCodigo.Name = "lblCodigo"
    Me.lblCodigo.Size = New System.Drawing.Size(46, 15)
    Me.lblCodigo.TabIndex = 0
    Me.lblCodigo.Text = "Códi&go"
    '
    'nudComision
    '
    Me.nudComision.Location = New System.Drawing.Point(97, 185)
    Me.nudComision.Name = "nudComision"
    Me.nudComision.Size = New System.Drawing.Size(120, 22)
    Me.nudComision.TabIndex = 12
    Me.nudComision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'lblPorcentajeComision
    '
    Me.lblPorcentajeComision.AutoSize = True
    Me.lblPorcentajeComision.Location = New System.Drawing.Point(14, 192)
    Me.lblPorcentajeComision.Name = "lblPorcentajeComision"
    Me.lblPorcentajeComision.Size = New System.Drawing.Size(71, 15)
    Me.lblPorcentajeComision.TabIndex = 11
    Me.lblPorcentajeComision.Text = "% Comisión"
    '
    'nudPrima
    '
    Me.nudPrima.Location = New System.Drawing.Point(99, 148)
    Me.nudPrima.Name = "nudPrima"
    Me.nudPrima.Size = New System.Drawing.Size(120, 22)
    Me.nudPrima.TabIndex = 14
    Me.nudPrima.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'lblPorcentajePrima
    '
    Me.lblPorcentajePrima.AutoSize = True
    Me.lblPorcentajePrima.Location = New System.Drawing.Point(14, 155)
    Me.lblPorcentajePrima.Name = "lblPorcentajePrima"
    Me.lblPorcentajePrima.Size = New System.Drawing.Size(50, 15)
    Me.lblPorcentajePrima.TabIndex = 13
    Me.lblPorcentajePrima.Text = "% Prima"
    '
    'frmGestionRegimenPension
    '
    Me.AcceptButton = Me.btnRegistrar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(961, 427)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.gbListaService)
    Me.Controls.Add(Me.gbService)
    Me.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.Name = "frmGestionRegimenPension"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de regimen pensionario"
    CType(Me.ErrAmbientes, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbListaService.ResumeLayout(False)
    CType(Me.dgvServices, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbService.ResumeLayout(False)
    Me.gbService.PerformLayout()
    CType(Me.nudAporte, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nudComision, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nudPrima, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents ErrAmbientes As System.Windows.Forms.ErrorProvider
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnModificar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents gbListaService As System.Windows.Forms.GroupBox
  Friend WithEvents dgvServices As System.Windows.Forms.DataGridView
  Friend WithEvents gbService As System.Windows.Forms.GroupBox
  Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
  Friend WithEvents lblCodigo As System.Windows.Forms.Label
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents lblNombre As System.Windows.Forms.Label
  Friend WithEvents chkVigente As System.Windows.Forms.CheckBox
  Friend WithEvents nudAporte As System.Windows.Forms.NumericUpDown
  Friend WithEvents lblPorcentajeAporte As System.Windows.Forms.Label
  Friend WithEvents cdRazonSocial As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents nudPrima As System.Windows.Forms.NumericUpDown
  Friend WithEvents lblPorcentajePrima As System.Windows.Forms.Label
  Friend WithEvents nudComision As System.Windows.Forms.NumericUpDown
  Friend WithEvents lblPorcentajeComision As System.Windows.Forms.Label
End Class
