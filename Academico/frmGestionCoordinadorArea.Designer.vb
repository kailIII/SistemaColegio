<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionCoordinadorArea

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
    Me.gbListaCoord = New System.Windows.Forms.GroupBox
    Me.dgvCoordArea = New System.Windows.Forms.DataGridView
    Me.cdArea = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdNivel = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCoordinador = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdVigencia = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnEditar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnGuardar = New System.Windows.Forms.Button
    Me.gbAreaInterna = New System.Windows.Forms.GroupBox
    Me.CheckVigente = New System.Windows.Forms.CheckBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.cboCoordiandor = New System.Windows.Forms.ComboBox
    Me.cboArea = New System.Windows.Forms.ComboBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.cboNivel = New System.Windows.Forms.ComboBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.errValida = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.gbListaCoord.SuspendLayout()
    CType(Me.dgvCoordArea, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbAreaInterna.SuspendLayout()
    CType(Me.errValida, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'gbListaCoord
    '
    Me.gbListaCoord.Controls.Add(Me.dgvCoordArea)
    Me.gbListaCoord.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbListaCoord.Location = New System.Drawing.Point(24, 12)
    Me.gbListaCoord.Name = "gbListaCoord"
    Me.gbListaCoord.Size = New System.Drawing.Size(602, 286)
    Me.gbListaCoord.TabIndex = 3
    Me.gbListaCoord.TabStop = False
    Me.gbListaCoord.Text = "Lista de Coordiandores"
    '
    'dgvCoordArea
    '
    Me.dgvCoordArea.AllowUserToAddRows = False
    Me.dgvCoordArea.AllowUserToDeleteRows = False
    Me.dgvCoordArea.AllowUserToResizeColumns = False
    Me.dgvCoordArea.AllowUserToResizeRows = False
    Me.dgvCoordArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvCoordArea.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdArea, Me.cdNivel, Me.cdCoordinador, Me.cdVigencia})
    Me.dgvCoordArea.Location = New System.Drawing.Point(6, 20)
    Me.dgvCoordArea.MultiSelect = False
    Me.dgvCoordArea.Name = "dgvCoordArea"
    Me.dgvCoordArea.ReadOnly = True
    Me.dgvCoordArea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvCoordArea.Size = New System.Drawing.Size(590, 260)
    Me.dgvCoordArea.TabIndex = 0
    '
    'cdArea
    '
    Me.cdArea.DataPropertyName = "NombreArea"
    Me.cdArea.HeaderText = "Area"
    Me.cdArea.Name = "cdArea"
    Me.cdArea.ReadOnly = True
    Me.cdArea.Width = 150
    '
    'cdNivel
    '
    Me.cdNivel.DataPropertyName = "NombreNivel"
    Me.cdNivel.HeaderText = "Nivel"
    Me.cdNivel.Name = "cdNivel"
    Me.cdNivel.ReadOnly = True
    Me.cdNivel.Width = 120
    '
    'cdCoordinador
    '
    Me.cdCoordinador.DataPropertyName = "NombreCompleto"
    Me.cdCoordinador.HeaderText = "Coordinador"
    Me.cdCoordinador.Name = "cdCoordinador"
    Me.cdCoordinador.ReadOnly = True
    Me.cdCoordinador.Width = 200
    '
    'cdVigencia
    '
    Me.cdVigencia.DataPropertyName = "NombreVigencia"
    Me.cdVigencia.HeaderText = "Vigente"
    Me.cdVigencia.Name = "cdVigencia"
    Me.cdVigencia.ReadOnly = True
    Me.cdVigencia.Width = 70
    '
    'btnEditar
    '
    Me.btnEditar.BackColor = System.Drawing.Color.White
    Me.btnEditar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnEditar.Location = New System.Drawing.Point(644, 34)
    Me.btnEditar.Name = "btnEditar"
    Me.btnEditar.Size = New System.Drawing.Size(110, 52)
    Me.btnEditar.TabIndex = 4
    Me.btnEditar.Text = "&Editar"
    Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnEditar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(644, 448)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 5
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(644, 390)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
    Me.btnCancelar.TabIndex = 2
    Me.btnCancelar.Text = "&Deshacer"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnGuardar
    '
    Me.btnGuardar.BackColor = System.Drawing.Color.White
    Me.btnGuardar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnGuardar.Location = New System.Drawing.Point(644, 304)
    Me.btnGuardar.Name = "btnGuardar"
    Me.btnGuardar.Size = New System.Drawing.Size(110, 52)
    Me.btnGuardar.TabIndex = 1
    Me.btnGuardar.Text = "&Registrar"
    Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnGuardar.UseVisualStyleBackColor = False
    '
    'gbAreaInterna
    '
    Me.gbAreaInterna.Controls.Add(Me.CheckVigente)
    Me.gbAreaInterna.Controls.Add(Me.Label1)
    Me.gbAreaInterna.Controls.Add(Me.cboCoordiandor)
    Me.gbAreaInterna.Controls.Add(Me.cboArea)
    Me.gbAreaInterna.Controls.Add(Me.Label3)
    Me.gbAreaInterna.Controls.Add(Me.cboNivel)
    Me.gbAreaInterna.Controls.Add(Me.Label2)
    Me.gbAreaInterna.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbAreaInterna.Location = New System.Drawing.Point(24, 304)
    Me.gbAreaInterna.Name = "gbAreaInterna"
    Me.gbAreaInterna.Size = New System.Drawing.Size(602, 192)
    Me.gbAreaInterna.TabIndex = 0
    Me.gbAreaInterna.TabStop = False
    Me.gbAreaInterna.Text = "Coordinador"
    '
    'CheckVigente
    '
    Me.CheckVigente.AutoSize = True
    Me.CheckVigente.Checked = True
    Me.CheckVigente.CheckState = System.Windows.Forms.CheckState.Checked
    Me.CheckVigente.Location = New System.Drawing.Point(415, 165)
    Me.CheckVigente.Name = "CheckVigente"
    Me.CheckVigente.Size = New System.Drawing.Size(73, 21)
    Me.CheckVigente.TabIndex = 6
    Me.CheckVigente.Text = "Vigente"
    Me.CheckVigente.UseVisualStyleBackColor = True
    Me.CheckVigente.Visible = False
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.Label1.Location = New System.Drawing.Point(63, 137)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(80, 17)
    Me.Label1.TabIndex = 4
    Me.Label1.Text = "Coordinador"
    '
    'cboCoordiandor
    '
    Me.cboCoordiandor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cboCoordiandor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboCoordiandor.BackColor = System.Drawing.SystemColors.Window
    Me.cboCoordiandor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboCoordiandor.FormattingEnabled = True
    Me.cboCoordiandor.Location = New System.Drawing.Point(205, 130)
    Me.cboCoordiandor.Name = "cboCoordiandor"
    Me.cboCoordiandor.Size = New System.Drawing.Size(283, 24)
    Me.cboCoordiandor.TabIndex = 5
    '
    'cboArea
    '
    Me.cboArea.DisplayMember = "nombreNivel"
    Me.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboArea.Font = New System.Drawing.Font("Arial", 9.75!)
    Me.cboArea.FormattingEnabled = True
    Me.cboArea.Location = New System.Drawing.Point(205, 86)
    Me.cboArea.Name = "cboArea"
    Me.cboArea.Size = New System.Drawing.Size(283, 24)
    Me.cboArea.TabIndex = 3
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.Label3.Location = New System.Drawing.Point(63, 93)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(38, 17)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Área"
    '
    'cboNivel
    '
    Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNivel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Location = New System.Drawing.Point(205, 44)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(283, 24)
    Me.cboNivel.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(63, 53)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(38, 15)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Nivel:"
    '
    'errValida
    '
    Me.errValida.ContainerControl = Me
    '
    'frmCoordinadorArea
    '
    Me.AcceptButton = Me.btnGuardar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
    Me.ClientSize = New System.Drawing.Size(766, 512)
    Me.Controls.Add(Me.btnEditar)
    Me.Controls.Add(Me.gbListaCoord)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnGuardar)
    Me.Controls.Add(Me.gbAreaInterna)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.Name = "frmCoordinadorArea"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión: Coordinador de Área"
    Me.gbListaCoord.ResumeLayout(False)
    CType(Me.dgvCoordArea, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbAreaInterna.ResumeLayout(False)
    Me.gbAreaInterna.PerformLayout()
    CType(Me.errValida, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents gbListaCoord As System.Windows.Forms.GroupBox
  Friend WithEvents btnEditar As System.Windows.Forms.Button
  Friend WithEvents dgvCoordArea As System.Windows.Forms.DataGridView
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnGuardar As System.Windows.Forms.Button
  Friend WithEvents gbAreaInterna As System.Windows.Forms.GroupBox
  Friend WithEvents cboArea As System.Windows.Forms.ComboBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents errValida As System.Windows.Forms.ErrorProvider
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cboCoordiandor As System.Windows.Forms.ComboBox
  Friend WithEvents CheckVigente As System.Windows.Forms.CheckBox
  Friend WithEvents cdArea As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdNivel As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCoordinador As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdVigencia As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
