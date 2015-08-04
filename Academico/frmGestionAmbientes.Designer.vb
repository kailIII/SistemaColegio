<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionAmbientes
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
    Me.ErrAmbientes = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnModificar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.gbListAmbientes = New System.Windows.Forms.GroupBox
    Me.dgvAmbientes = New System.Windows.Forms.DataGridView
    Me.cdCodigoAula = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdTipo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdLocal = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdPabellon = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdVigencia = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.GbAmbientes = New System.Windows.Forms.GroupBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.cboPabellon = New System.Windows.Forms.ComboBox
    Me.nudNumero = New System.Windows.Forms.NumericUpDown
    Me.lblnumero = New System.Windows.Forms.Label
    Me.cboxVigenciaAmb = New System.Windows.Forms.CheckBox
    Me.lblTipo = New System.Windows.Forms.Label
    Me.cboTipo = New System.Windows.Forms.ComboBox
    Me.txtCapacidad = New System.Windows.Forms.TextBox
    Me.txtPiso = New System.Windows.Forms.TextBox
    Me.lblCapacidad = New System.Windows.Forms.Label
    Me.lblpiso = New System.Windows.Forms.Label
    Me.lblLocal = New System.Windows.Forms.Label
    Me.cboLocal = New System.Windows.Forms.ComboBox
    CType(Me.ErrAmbientes, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbListAmbientes.SuspendLayout()
    CType(Me.dgvAmbientes, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GbAmbientes.SuspendLayout()
    CType(Me.nudNumero, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.btnModificar.TabIndex = 5
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
    'gbListAmbientes
    '
    Me.gbListAmbientes.Controls.Add(Me.dgvAmbientes)
    Me.gbListAmbientes.Controls.Add(Me.btnModificar)
    Me.gbListAmbientes.Location = New System.Drawing.Point(12, 27)
    Me.gbListAmbientes.Name = "gbListAmbientes"
    Me.gbListAmbientes.Size = New System.Drawing.Size(425, 388)
    Me.gbListAmbientes.TabIndex = 1
    Me.gbListAmbientes.TabStop = False
    Me.gbListAmbientes.Text = "Lista de Ambientes"
    '
    'dgvAmbientes
    '
    Me.dgvAmbientes.AllowUserToAddRows = False
    Me.dgvAmbientes.AllowUserToDeleteRows = False
    Me.dgvAmbientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvAmbientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdCodigoAula, Me.cdTipo, Me.cdLocal, Me.cdPabellon, Me.cdVigencia})
    Me.dgvAmbientes.Location = New System.Drawing.Point(7, 22)
    Me.dgvAmbientes.MultiSelect = False
    Me.dgvAmbientes.Name = "dgvAmbientes"
    Me.dgvAmbientes.ReadOnly = True
    Me.dgvAmbientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvAmbientes.Size = New System.Drawing.Size(412, 292)
    Me.dgvAmbientes.TabIndex = 0
    '
    'cdCodigoAula
    '
    Me.cdCodigoAula.DataPropertyName = "Codigo"
    Me.cdCodigoAula.HeaderText = ""
    Me.cdCodigoAula.Name = "cdCodigoAula"
    Me.cdCodigoAula.ReadOnly = True
    Me.cdCodigoAula.Visible = False
    '
    'cdTipo
    '
    Me.cdTipo.DataPropertyName = "NombreCompletoAula"
    Me.cdTipo.HeaderText = "Tipo"
    Me.cdTipo.Name = "cdTipo"
    Me.cdTipo.ReadOnly = True
    '
    'cdLocal
    '
    Me.cdLocal.DataPropertyName = "NombreLocal"
    Me.cdLocal.HeaderText = "Local"
    Me.cdLocal.Name = "cdLocal"
    Me.cdLocal.ReadOnly = True
    '
    'cdPabellon
    '
    Me.cdPabellon.DataPropertyName = "NombrePabellon"
    Me.cdPabellon.HeaderText = "Pabellón"
    Me.cdPabellon.Name = "cdPabellon"
    Me.cdPabellon.ReadOnly = True
    Me.cdPabellon.Width = 90
    '
    'cdVigencia
    '
    Me.cdVigencia.DataPropertyName = "NombreVigencia"
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cdVigencia.DefaultCellStyle = DataGridViewCellStyle1
    Me.cdVigencia.HeaderText = "Vigente"
    Me.cdVigencia.Name = "cdVigencia"
    Me.cdVigencia.ReadOnly = True
    Me.cdVigencia.Width = 60
    '
    'GbAmbientes
    '
    Me.GbAmbientes.Controls.Add(Me.Label1)
    Me.GbAmbientes.Controls.Add(Me.cboPabellon)
    Me.GbAmbientes.Controls.Add(Me.nudNumero)
    Me.GbAmbientes.Controls.Add(Me.lblnumero)
    Me.GbAmbientes.Controls.Add(Me.cboxVigenciaAmb)
    Me.GbAmbientes.Controls.Add(Me.lblTipo)
    Me.GbAmbientes.Controls.Add(Me.cboTipo)
    Me.GbAmbientes.Controls.Add(Me.txtCapacidad)
    Me.GbAmbientes.Controls.Add(Me.txtPiso)
    Me.GbAmbientes.Controls.Add(Me.lblCapacidad)
    Me.GbAmbientes.Controls.Add(Me.lblpiso)
    Me.GbAmbientes.Controls.Add(Me.lblLocal)
    Me.GbAmbientes.Controls.Add(Me.cboLocal)
    Me.GbAmbientes.Location = New System.Drawing.Point(443, 27)
    Me.GbAmbientes.Name = "GbAmbientes"
    Me.GbAmbientes.Size = New System.Drawing.Size(384, 388)
    Me.GbAmbientes.TabIndex = 0
    Me.GbAmbientes.TabStop = False
    Me.GbAmbientes.Text = "Ambientes"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(21, 303)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(53, 15)
    Me.Label1.TabIndex = 11
    Me.Label1.Text = "Pabellón"
    '
    'cboPabellon
    '
    Me.cboPabellon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboPabellon.FormattingEnabled = True
    Me.cboPabellon.Items.AddRange(New Object() {"Inicial", "Primaria", "Secundaria"})
    Me.cboPabellon.Location = New System.Drawing.Point(84, 300)
    Me.cboPabellon.Name = "cboPabellon"
    Me.cboPabellon.Size = New System.Drawing.Size(184, 23)
    Me.cboPabellon.TabIndex = 12
    '
    'nudNumero
    '
    Me.nudNumero.Location = New System.Drawing.Point(84, 141)
    Me.nudNumero.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.nudNumero.Name = "nudNumero"
    Me.nudNumero.Size = New System.Drawing.Size(79, 22)
    Me.nudNumero.TabIndex = 5
    Me.nudNumero.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'lblnumero
    '
    Me.lblnumero.AutoSize = True
    Me.lblnumero.Location = New System.Drawing.Point(25, 143)
    Me.lblnumero.Name = "lblnumero"
    Me.lblnumero.Size = New System.Drawing.Size(49, 15)
    Me.lblnumero.TabIndex = 4
    Me.lblnumero.Text = "&Número"
    '
    'cboxVigenciaAmb
    '
    Me.cboxVigenciaAmb.AutoSize = True
    Me.cboxVigenciaAmb.Checked = True
    Me.cboxVigenciaAmb.CheckState = System.Windows.Forms.CheckState.Checked
    Me.cboxVigenciaAmb.Location = New System.Drawing.Point(280, 144)
    Me.cboxVigenciaAmb.Name = "cboxVigenciaAmb"
    Me.cboxVigenciaAmb.Size = New System.Drawing.Size(81, 19)
    Me.cboxVigenciaAmb.TabIndex = 6
    Me.cboxVigenciaAmb.Text = "&Habilitado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
    Me.cboxVigenciaAmb.UseVisualStyleBackColor = True
    Me.cboxVigenciaAmb.Visible = False
    '
    'lblTipo
    '
    Me.lblTipo.AutoSize = True
    Me.lblTipo.Location = New System.Drawing.Point(42, 91)
    Me.lblTipo.Name = "lblTipo"
    Me.lblTipo.Size = New System.Drawing.Size(32, 15)
    Me.lblTipo.TabIndex = 2
    Me.lblTipo.Text = "T&ipo"
    '
    'cboTipo
    '
    Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipo.FormattingEnabled = True
    Me.cboTipo.Items.AddRange(New Object() {"Aula", "Patio", "Laboratorio"})
    Me.cboTipo.Location = New System.Drawing.Point(84, 86)
    Me.cboTipo.Name = "cboTipo"
    Me.cboTipo.Size = New System.Drawing.Size(277, 23)
    Me.cboTipo.TabIndex = 3
    '
    'txtCapacidad
    '
    Me.txtCapacidad.Location = New System.Drawing.Point(189, 242)
    Me.txtCapacidad.Name = "txtCapacidad"
    Me.txtCapacidad.Size = New System.Drawing.Size(79, 22)
    Me.txtCapacidad.TabIndex = 10
    '
    'txtPiso
    '
    Me.txtPiso.Location = New System.Drawing.Point(84, 194)
    Me.txtPiso.Name = "txtPiso"
    Me.txtPiso.Size = New System.Drawing.Size(79, 22)
    Me.txtPiso.TabIndex = 8
    '
    'lblCapacidad
    '
    Me.lblCapacidad.AutoSize = True
    Me.lblCapacidad.Location = New System.Drawing.Point(25, 250)
    Me.lblCapacidad.Name = "lblCapacidad"
    Me.lblCapacidad.Size = New System.Drawing.Size(129, 15)
    Me.lblCapacidad.TabIndex = 9
    Me.lblCapacidad.Text = "C&apacidad de Carpetas"
    Me.lblCapacidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'lblpiso
    '
    Me.lblpiso.AutoSize = True
    Me.lblpiso.Location = New System.Drawing.Point(44, 197)
    Me.lblpiso.Name = "lblpiso"
    Me.lblpiso.Size = New System.Drawing.Size(30, 15)
    Me.lblpiso.TabIndex = 7
    Me.lblpiso.Text = "&Piso"
    '
    'lblLocal
    '
    Me.lblLocal.AutoSize = True
    Me.lblLocal.Location = New System.Drawing.Point(38, 43)
    Me.lblLocal.Name = "lblLocal"
    Me.lblLocal.Size = New System.Drawing.Size(36, 15)
    Me.lblLocal.TabIndex = 0
    Me.lblLocal.Text = "&Local"
    '
    'cboLocal
    '
    Me.cboLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboLocal.FormattingEnabled = True
    Me.cboLocal.Location = New System.Drawing.Point(84, 37)
    Me.cboLocal.Name = "cboLocal"
    Me.cboLocal.Size = New System.Drawing.Size(277, 23)
    Me.cboLocal.TabIndex = 1
    '
    'frmGestionAmbientes
    '
    Me.AcceptButton = Me.btnRegistrar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(961, 427)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.gbListAmbientes)
    Me.Controls.Add(Me.GbAmbientes)
    Me.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.Name = "frmGestionAmbientes"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de ambientes"
    CType(Me.ErrAmbientes, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbListAmbientes.ResumeLayout(False)
    CType(Me.dgvAmbientes, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GbAmbientes.ResumeLayout(False)
    Me.GbAmbientes.PerformLayout()
    CType(Me.nudNumero, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents ErrAmbientes As System.Windows.Forms.ErrorProvider
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnModificar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents gbListAmbientes As System.Windows.Forms.GroupBox
  Friend WithEvents dgvAmbientes As System.Windows.Forms.DataGridView
  Friend WithEvents GbAmbientes As System.Windows.Forms.GroupBox
  Friend WithEvents nudNumero As System.Windows.Forms.NumericUpDown
  Friend WithEvents lblnumero As System.Windows.Forms.Label
  Friend WithEvents cboxVigenciaAmb As System.Windows.Forms.CheckBox
  Friend WithEvents lblTipo As System.Windows.Forms.Label
  Private WithEvents cboTipo As System.Windows.Forms.ComboBox
  Friend WithEvents txtCapacidad As System.Windows.Forms.TextBox
  Friend WithEvents txtPiso As System.Windows.Forms.TextBox
  Friend WithEvents lblCapacidad As System.Windows.Forms.Label
  Friend WithEvents lblpiso As System.Windows.Forms.Label
  Friend WithEvents lblLocal As System.Windows.Forms.Label
  Friend WithEvents cboLocal As System.Windows.Forms.ComboBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Private WithEvents cboPabellon As System.Windows.Forms.ComboBox
  Friend WithEvents cdCodigoAula As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdTipo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdLocal As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdPabellon As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdVigencia As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
