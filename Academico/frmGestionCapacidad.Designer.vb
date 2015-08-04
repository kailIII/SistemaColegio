<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionCapacidad
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
    Me.lbCapacidades = New System.Windows.Forms.ListBox
    Me.gbListCap = New System.Windows.Forms.GroupBox
    Me.btnModificar = New System.Windows.Forms.Button
    Me.cboNivel = New System.Windows.Forms.ComboBox
    Me.cboArea = New System.Windows.Forms.ComboBox
    Me.lblNivel = New System.Windows.Forms.Label
    Me.lblArea = New System.Windows.Forms.Label
    Me.gbCapacidad = New System.Windows.Forms.GroupBox
    Me.chkVigente = New System.Windows.Forms.CheckBox
    Me.txtCapacidad = New System.Windows.Forms.TextBox
    Me.lblCapacidad = New System.Windows.Forms.Label
    Me.gbNivel = New System.Windows.Forms.GroupBox
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.btnDeshacer = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.errCapacidad = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.lblMensaje = New System.Windows.Forms.Label
    Me.gbListCap.SuspendLayout()
    Me.gbCapacidad.SuspendLayout()
    Me.gbNivel.SuspendLayout()
    CType(Me.errCapacidad, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lbCapacidades
    '
    Me.lbCapacidades.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lbCapacidades.FormattingEnabled = True
    Me.lbCapacidades.ItemHeight = 15
    Me.lbCapacidades.Location = New System.Drawing.Point(12, 33)
    Me.lbCapacidades.Name = "lbCapacidades"
    Me.lbCapacidades.Size = New System.Drawing.Size(391, 214)
    Me.lbCapacidades.TabIndex = 0
    '
    'gbListCap
    '
    Me.gbListCap.Controls.Add(Me.btnModificar)
    Me.gbListCap.Controls.Add(Me.lbCapacidades)
    Me.gbListCap.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbListCap.Location = New System.Drawing.Point(14, 14)
    Me.gbListCap.Name = "gbListCap"
    Me.gbListCap.Size = New System.Drawing.Size(415, 336)
    Me.gbListCap.TabIndex = 3
    Me.gbListCap.TabStop = False
    Me.gbListCap.Text = "Lista &de capacidades"
    '
    'btnModificar
    '
    Me.btnModificar.BackColor = System.Drawing.Color.White
    Me.btnModificar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnModificar.Location = New System.Drawing.Point(152, 265)
    Me.btnModificar.Name = "btnModificar"
    Me.btnModificar.Size = New System.Drawing.Size(110, 50)
    Me.btnModificar.TabIndex = 1
    Me.btnModificar.Text = "&Modificar"
    Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnModificar.UseVisualStyleBackColor = False
    '
    'cboNivel
    '
    Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNivel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Location = New System.Drawing.Point(137, 33)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(186, 24)
    Me.cboNivel.TabIndex = 1
    '
    'cboArea
    '
    Me.cboArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cboArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboArea.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboArea.FormattingEnabled = True
    Me.cboArea.Location = New System.Drawing.Point(67, 36)
    Me.cboArea.Name = "cboArea"
    Me.cboArea.Size = New System.Drawing.Size(279, 24)
    Me.cboArea.TabIndex = 1
    '
    'lblNivel
    '
    Me.lblNivel.AutoSize = True
    Me.lblNivel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNivel.Location = New System.Drawing.Point(36, 37)
    Me.lblNivel.Name = "lblNivel"
    Me.lblNivel.Size = New System.Drawing.Size(98, 15)
    Me.lblNivel.TabIndex = 0
    Me.lblNivel.Text = "N&ivel Académico"
    '
    'lblArea
    '
    Me.lblArea.AutoSize = True
    Me.lblArea.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblArea.Location = New System.Drawing.Point(30, 40)
    Me.lblArea.Name = "lblArea"
    Me.lblArea.Size = New System.Drawing.Size(33, 15)
    Me.lblArea.TabIndex = 0
    Me.lblArea.Text = "Á&rea"
    '
    'gbCapacidad
    '
    Me.gbCapacidad.Controls.Add(Me.chkVigente)
    Me.gbCapacidad.Controls.Add(Me.lblArea)
    Me.gbCapacidad.Controls.Add(Me.txtCapacidad)
    Me.gbCapacidad.Controls.Add(Me.cboArea)
    Me.gbCapacidad.Controls.Add(Me.lblCapacidad)
    Me.gbCapacidad.Location = New System.Drawing.Point(438, 132)
    Me.gbCapacidad.Name = "gbCapacidad"
    Me.gbCapacidad.Size = New System.Drawing.Size(359, 218)
    Me.gbCapacidad.TabIndex = 0
    Me.gbCapacidad.TabStop = False
    Me.gbCapacidad.Text = "Capacidad"
    '
    'chkVigente
    '
    Me.chkVigente.AutoSize = True
    Me.chkVigente.Location = New System.Drawing.Point(66, 180)
    Me.chkVigente.Name = "chkVigente"
    Me.chkVigente.Size = New System.Drawing.Size(62, 17)
    Me.chkVigente.TabIndex = 4
    Me.chkVigente.Text = "&Vigente"
    Me.chkVigente.UseVisualStyleBackColor = True
    '
    'txtCapacidad
    '
    Me.txtCapacidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCapacidad.Location = New System.Drawing.Point(66, 81)
    Me.txtCapacidad.MaxLength = 80
    Me.txtCapacidad.Multiline = True
    Me.txtCapacidad.Name = "txtCapacidad"
    Me.txtCapacidad.Size = New System.Drawing.Size(279, 83)
    Me.txtCapacidad.TabIndex = 3
    '
    'lblCapacidad
    '
    Me.lblCapacidad.AutoSize = True
    Me.lblCapacidad.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCapacidad.Location = New System.Drawing.Point(14, 85)
    Me.lblCapacidad.Name = "lblCapacidad"
    Me.lblCapacidad.Size = New System.Drawing.Size(49, 15)
    Me.lblCapacidad.TabIndex = 2
    Me.lblCapacidad.Text = "N&ombre"
    '
    'gbNivel
    '
    Me.gbNivel.Controls.Add(Me.lblNivel)
    Me.gbNivel.Controls.Add(Me.cboNivel)
    Me.gbNivel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbNivel.Location = New System.Drawing.Point(438, 15)
    Me.gbNivel.Name = "gbNivel"
    Me.gbNivel.Size = New System.Drawing.Size(359, 86)
    Me.gbNivel.TabIndex = 4
    Me.gbNivel.TabStop = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(813, 141)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 50)
    Me.btnRegistrar.TabIndex = 1
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'btnDeshacer
    '
    Me.btnDeshacer.BackColor = System.Drawing.Color.White
    Me.btnDeshacer.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnDeshacer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnDeshacer.Location = New System.Drawing.Point(813, 197)
    Me.btnDeshacer.Name = "btnDeshacer"
    Me.btnDeshacer.Size = New System.Drawing.Size(110, 50)
    Me.btnDeshacer.TabIndex = 2
    Me.btnDeshacer.Text = "&Deshacer"
    Me.btnDeshacer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnDeshacer.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(813, 300)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 50)
    Me.btnCerrar.TabIndex = 5
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'errCapacidad
    '
    Me.errCapacidad.ContainerControl = Me
    '
    'lblMensaje
    '
    Me.lblMensaje.AutoSize = True
    Me.lblMensaje.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMensaje.ForeColor = System.Drawing.SystemColors.ActiveCaption
    Me.lblMensaje.Location = New System.Drawing.Point(13, 362)
    Me.lblMensaje.Name = "lblMensaje"
    Me.lblMensaje.Size = New System.Drawing.Size(416, 19)
    Me.lblMensaje.TabIndex = 7
    Me.lblMensaje.Text = "Click en Deshacer para anular la operación y volver a iniciar."
    '
    'frmCapacidad
    '
    Me.AcceptButton = Me.btnRegistrar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(932, 390)
    Me.Controls.Add(Me.lblMensaje)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnDeshacer)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.gbNivel)
    Me.Controls.Add(Me.gbCapacidad)
    Me.Controls.Add(Me.gbListCap)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.Name = "frmCapacidad"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de capacidades"
    Me.gbListCap.ResumeLayout(False)
    Me.gbCapacidad.ResumeLayout(False)
    Me.gbCapacidad.PerformLayout()
    Me.gbNivel.ResumeLayout(False)
    Me.gbNivel.PerformLayout()
    CType(Me.errCapacidad, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lbCapacidades As System.Windows.Forms.ListBox
  Friend WithEvents gbListCap As System.Windows.Forms.GroupBox
  Friend WithEvents btnModificar As System.Windows.Forms.Button
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents cboArea As System.Windows.Forms.ComboBox
  Friend WithEvents lblNivel As System.Windows.Forms.Label
  Friend WithEvents lblArea As System.Windows.Forms.Label
  Friend WithEvents gbCapacidad As System.Windows.Forms.GroupBox
  Friend WithEvents gbNivel As System.Windows.Forms.GroupBox
  Friend WithEvents txtCapacidad As System.Windows.Forms.TextBox
  Friend WithEvents lblCapacidad As System.Windows.Forms.Label
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnDeshacer As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents errCapacidad As System.Windows.Forms.ErrorProvider
  Friend WithEvents lblMensaje As System.Windows.Forms.Label
  Friend WithEvents chkVigente As System.Windows.Forms.CheckBox
End Class
