<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionService
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
    Me.nudSCTR = New System.Windows.Forms.NumericUpDown
    Me.lblSCTR = New System.Windows.Forms.Label
    Me.chkCentroRiesgo = New System.Windows.Forms.CheckBox
    Me.txtDenominacion = New System.Windows.Forms.TextBox
    Me.lblDenominacion = New System.Windows.Forms.Label
    Me.txtTipoActividad = New System.Windows.Forms.TextBox
    Me.lblActividad = New System.Windows.Forms.Label
    Me.txtRazonSocial = New System.Windows.Forms.TextBox
    Me.lblRazonSocial = New System.Windows.Forms.Label
    Me.txtRUC = New System.Windows.Forms.TextBox
    Me.lblRUC = New System.Windows.Forms.Label
    CType(Me.ErrAmbientes, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbListaService.SuspendLayout()
    CType(Me.dgvServices, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbService.SuspendLayout()
    CType(Me.nudSCTR, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.gbListaService.Size = New System.Drawing.Size(425, 388)
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
    Me.dgvServices.Size = New System.Drawing.Size(412, 292)
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
    Me.gbService.Controls.Add(Me.nudSCTR)
    Me.gbService.Controls.Add(Me.lblSCTR)
    Me.gbService.Controls.Add(Me.chkCentroRiesgo)
    Me.gbService.Controls.Add(Me.txtDenominacion)
    Me.gbService.Controls.Add(Me.lblDenominacion)
    Me.gbService.Controls.Add(Me.txtTipoActividad)
    Me.gbService.Controls.Add(Me.lblActividad)
    Me.gbService.Controls.Add(Me.txtRazonSocial)
    Me.gbService.Controls.Add(Me.lblRazonSocial)
    Me.gbService.Controls.Add(Me.txtRUC)
    Me.gbService.Controls.Add(Me.lblRUC)
    Me.gbService.Location = New System.Drawing.Point(443, 27)
    Me.gbService.Name = "gbService"
    Me.gbService.Size = New System.Drawing.Size(384, 388)
    Me.gbService.TabIndex = 1
    Me.gbService.TabStop = False
    Me.gbService.Text = "Service"
    '
    'nudSCTR
    '
    Me.nudSCTR.Location = New System.Drawing.Point(129, 203)
    Me.nudSCTR.Name = "nudSCTR"
    Me.nudSCTR.Size = New System.Drawing.Size(120, 22)
    Me.nudSCTR.TabIndex = 10
    Me.nudSCTR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'lblSCTR
    '
    Me.lblSCTR.AutoSize = True
    Me.lblSCTR.Location = New System.Drawing.Point(15, 210)
    Me.lblSCTR.Name = "lblSCTR"
    Me.lblSCTR.Size = New System.Drawing.Size(66, 15)
    Me.lblSCTR.TabIndex = 9
    Me.lblSCTR.Text = "Tasa &SCTR"
    '
    'chkCentroRiesgo
    '
    Me.chkCentroRiesgo.AutoSize = True
    Me.chkCentroRiesgo.Location = New System.Drawing.Point(18, 174)
    Me.chkCentroRiesgo.Name = "chkCentroRiesgo"
    Me.chkCentroRiesgo.Size = New System.Drawing.Size(139, 19)
    Me.chkCentroRiesgo.TabIndex = 8
    Me.chkCentroRiesgo.Text = "¿Es centro de riesgo?"
    Me.chkCentroRiesgo.UseVisualStyleBackColor = True
    '
    'txtDenominacion
    '
    Me.txtDenominacion.Location = New System.Drawing.Point(128, 130)
    Me.txtDenominacion.Name = "txtDenominacion"
    Me.txtDenominacion.Size = New System.Drawing.Size(250, 22)
    Me.txtDenominacion.TabIndex = 7
    '
    'lblDenominacion
    '
    Me.lblDenominacion.AutoSize = True
    Me.lblDenominacion.Location = New System.Drawing.Point(15, 137)
    Me.lblDenominacion.Name = "lblDenominacion"
    Me.lblDenominacion.Size = New System.Drawing.Size(84, 15)
    Me.lblDenominacion.TabIndex = 6
    Me.lblDenominacion.Text = "&Denominación"
    '
    'txtTipoActividad
    '
    Me.txtTipoActividad.Location = New System.Drawing.Point(128, 102)
    Me.txtTipoActividad.Name = "txtTipoActividad"
    Me.txtTipoActividad.Size = New System.Drawing.Size(250, 22)
    Me.txtTipoActividad.TabIndex = 5
    '
    'lblActividad
    '
    Me.lblActividad.AutoSize = True
    Me.lblActividad.Location = New System.Drawing.Point(15, 109)
    Me.lblActividad.Name = "lblActividad"
    Me.lblActividad.Size = New System.Drawing.Size(100, 15)
    Me.lblActividad.TabIndex = 4
    Me.lblActividad.Text = "&Tipo de actividad"
    '
    'txtRazonSocial
    '
    Me.txtRazonSocial.Location = New System.Drawing.Point(128, 72)
    Me.txtRazonSocial.Name = "txtRazonSocial"
    Me.txtRazonSocial.Size = New System.Drawing.Size(250, 22)
    Me.txtRazonSocial.TabIndex = 3
    '
    'lblRazonSocial
    '
    Me.lblRazonSocial.AutoSize = True
    Me.lblRazonSocial.Location = New System.Drawing.Point(15, 79)
    Me.lblRazonSocial.Name = "lblRazonSocial"
    Me.lblRazonSocial.Size = New System.Drawing.Size(74, 15)
    Me.lblRazonSocial.TabIndex = 2
    Me.lblRazonSocial.Text = "Ra&zon social"
    '
    'txtRUC
    '
    Me.txtRUC.Location = New System.Drawing.Point(128, 36)
    Me.txtRUC.Name = "txtRUC"
    Me.txtRUC.Size = New System.Drawing.Size(118, 22)
    Me.txtRUC.TabIndex = 1
    '
    'lblRUC
    '
    Me.lblRUC.AutoSize = True
    Me.lblRUC.Location = New System.Drawing.Point(15, 43)
    Me.lblRUC.Name = "lblRUC"
    Me.lblRUC.Size = New System.Drawing.Size(32, 15)
    Me.lblRUC.TabIndex = 0
    Me.lblRUC.Text = "&RUC"
    '
    'frmGestionService
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
    Me.Name = "frmGestionService"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de services"
    CType(Me.ErrAmbientes, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbListaService.ResumeLayout(False)
    CType(Me.dgvServices, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbService.ResumeLayout(False)
    Me.gbService.PerformLayout()
    CType(Me.nudSCTR, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents txtRUC As System.Windows.Forms.TextBox
  Friend WithEvents lblRUC As System.Windows.Forms.Label
  Friend WithEvents txtDenominacion As System.Windows.Forms.TextBox
  Friend WithEvents lblDenominacion As System.Windows.Forms.Label
  Friend WithEvents txtTipoActividad As System.Windows.Forms.TextBox
  Friend WithEvents lblActividad As System.Windows.Forms.Label
  Friend WithEvents txtRazonSocial As System.Windows.Forms.TextBox
  Friend WithEvents lblRazonSocial As System.Windows.Forms.Label
  Friend WithEvents chkCentroRiesgo As System.Windows.Forms.CheckBox
  Friend WithEvents nudSCTR As System.Windows.Forms.NumericUpDown
  Friend WithEvents lblSCTR As System.Windows.Forms.Label
  Friend WithEvents cdRazonSocial As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
