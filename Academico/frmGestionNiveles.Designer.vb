<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionNiveles
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
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.btnActualizar = New System.Windows.Forms.Button
    Me.dgvNiveles = New System.Windows.Forms.DataGridView
    Me.cdNivel = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdSiglas = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCodigoNivel = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCodigoModular = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.gbNivel = New System.Windows.Forms.GroupBox
    Me.gbInterno = New System.Windows.Forms.GroupBox
    Me.txtCodigoModular = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.txtSiglas = New System.Windows.Forms.TextBox
    Me.lblSiglas = New System.Windows.Forms.Label
    Me.txtNombreNivel = New System.Windows.Forms.TextBox
    Me.lblNombre = New System.Windows.Forms.Label
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.gbNiveles = New System.Windows.Forms.GroupBox
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.errorNiveles = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.lblMensaje = New System.Windows.Forms.Label
    CType(Me.dgvNiveles, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbNivel.SuspendLayout()
    Me.gbInterno.SuspendLayout()
    Me.gbNiveles.SuspendLayout()
    CType(Me.errorNiveles, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnActualizar
    '
    Me.btnActualizar.BackColor = System.Drawing.Color.White
    Me.btnActualizar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnActualizar.Location = New System.Drawing.Point(543, 51)
    Me.btnActualizar.Name = "btnActualizar"
    Me.btnActualizar.Size = New System.Drawing.Size(110, 52)
    Me.btnActualizar.TabIndex = 1
    Me.btnActualizar.Text = "M&odificar"
    Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnActualizar.UseVisualStyleBackColor = False
    '
    'dgvNiveles
    '
    Me.dgvNiveles.AllowUserToAddRows = False
    Me.dgvNiveles.AllowUserToDeleteRows = False
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvNiveles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvNiveles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvNiveles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNivel, Me.cdSiglas, Me.cdCodigoNivel, Me.cdCodigoModular})
    Me.dgvNiveles.Location = New System.Drawing.Point(29, 39)
    Me.dgvNiveles.MultiSelect = False
    Me.dgvNiveles.Name = "dgvNiveles"
    Me.dgvNiveles.ReadOnly = True
    Me.dgvNiveles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvNiveles.Size = New System.Drawing.Size(396, 154)
    Me.dgvNiveles.TabIndex = 0
    '
    'cdNivel
    '
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.cdNivel.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdNivel.HeaderText = "Nivel"
    Me.cdNivel.Name = "cdNivel"
    Me.cdNivel.ReadOnly = True
    Me.cdNivel.Width = 120
    '
    'cdSiglas
    '
    Me.cdSiglas.HeaderText = "Siglas"
    Me.cdSiglas.Name = "cdSiglas"
    Me.cdSiglas.ReadOnly = True
    Me.cdSiglas.Width = 70
    '
    'cdCodigoNivel
    '
    Me.cdCodigoNivel.DataPropertyName = "Codigo"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.cdCodigoNivel.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdCodigoNivel.HeaderText = "Código_Nivel"
    Me.cdCodigoNivel.Name = "cdCodigoNivel"
    Me.cdCodigoNivel.ReadOnly = True
    Me.cdCodigoNivel.Visible = False
    Me.cdCodigoNivel.Width = 5
    '
    'cdCodigoModular
    '
    Me.cdCodigoModular.HeaderText = "Codigo Modular"
    Me.cdCodigoModular.Name = "cdCodigoModular"
    Me.cdCodigoModular.ReadOnly = True
    Me.cdCodigoModular.Width = 120
    '
    'gbNivel
    '
    Me.gbNivel.Controls.Add(Me.gbInterno)
    Me.gbNivel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbNivel.Location = New System.Drawing.Point(60, 252)
    Me.gbNivel.Name = "gbNivel"
    Me.gbNivel.Size = New System.Drawing.Size(443, 193)
    Me.gbNivel.TabIndex = 0
    Me.gbNivel.TabStop = False
    Me.gbNivel.Text = "Nivel Académico"
    '
    'gbInterno
    '
    Me.gbInterno.Controls.Add(Me.txtCodigoModular)
    Me.gbInterno.Controls.Add(Me.Label1)
    Me.gbInterno.Controls.Add(Me.txtSiglas)
    Me.gbInterno.Controls.Add(Me.lblSiglas)
    Me.gbInterno.Controls.Add(Me.txtNombreNivel)
    Me.gbInterno.Controls.Add(Me.lblNombre)
    Me.gbInterno.Location = New System.Drawing.Point(73, 21)
    Me.gbInterno.Name = "gbInterno"
    Me.gbInterno.Size = New System.Drawing.Size(298, 133)
    Me.gbInterno.TabIndex = 0
    Me.gbInterno.TabStop = False
    '
    'txtCodigoModular
    '
    Me.txtCodigoModular.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCodigoModular.Location = New System.Drawing.Point(131, 21)
    Me.txtCodigoModular.MaxLength = 7
    Me.txtCodigoModular.Multiline = True
    Me.txtCodigoModular.Name = "txtCodigoModular"
    Me.txtCodigoModular.Size = New System.Drawing.Size(139, 24)
    Me.txtCodigoModular.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.Color.Black
    Me.Label1.Location = New System.Drawing.Point(17, 25)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(95, 15)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Código Modular"
    '
    'txtSiglas
    '
    Me.txtSiglas.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSiglas.Location = New System.Drawing.Point(131, 91)
    Me.txtSiglas.MaxLength = 3
    Me.txtSiglas.Multiline = True
    Me.txtSiglas.Name = "txtSiglas"
    Me.txtSiglas.Size = New System.Drawing.Size(139, 24)
    Me.txtSiglas.TabIndex = 5
    '
    'lblSiglas
    '
    Me.lblSiglas.AutoSize = True
    Me.lblSiglas.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSiglas.ForeColor = System.Drawing.Color.Black
    Me.lblSiglas.Location = New System.Drawing.Point(17, 95)
    Me.lblSiglas.Name = "lblSiglas"
    Me.lblSiglas.Size = New System.Drawing.Size(39, 15)
    Me.lblSiglas.TabIndex = 4
    Me.lblSiglas.Text = "&Siglas"
    '
    'txtNombreNivel
    '
    Me.txtNombreNivel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNombreNivel.Location = New System.Drawing.Point(131, 57)
    Me.txtNombreNivel.Multiline = True
    Me.txtNombreNivel.Name = "txtNombreNivel"
    Me.txtNombreNivel.Size = New System.Drawing.Size(139, 24)
    Me.txtNombreNivel.TabIndex = 3
    '
    'lblNombre
    '
    Me.lblNombre.AutoSize = True
    Me.lblNombre.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNombre.ForeColor = System.Drawing.Color.Black
    Me.lblNombre.Location = New System.Drawing.Point(17, 57)
    Me.lblNombre.Name = "lblNombre"
    Me.lblNombre.Size = New System.Drawing.Size(35, 15)
    Me.lblNombre.TabIndex = 2
    Me.lblNombre.Text = "&Nivel"
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(543, 315)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
    Me.btnCancelar.TabIndex = 3
    Me.btnCancelar.Text = "&Deshacer"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(543, 262)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
    Me.btnRegistrar.TabIndex = 2
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'gbNiveles
    '
    Me.gbNiveles.Controls.Add(Me.dgvNiveles)
    Me.gbNiveles.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbNiveles.Location = New System.Drawing.Point(60, 12)
    Me.gbNiveles.Name = "gbNiveles"
    Me.gbNiveles.Size = New System.Drawing.Size(443, 225)
    Me.gbNiveles.TabIndex = 5
    Me.gbNiveles.TabStop = False
    Me.gbNiveles.Text = "Lista de Niveles Académicos"
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(543, 387)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 58)
    Me.btnCerrar.TabIndex = 4
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'errorNiveles
    '
    Me.errorNiveles.ContainerControl = Me
    '
    'lblMensaje
    '
    Me.lblMensaje.AutoSize = True
    Me.lblMensaje.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMensaje.ForeColor = System.Drawing.SystemColors.ActiveCaption
    Me.lblMensaje.Location = New System.Drawing.Point(58, 458)
    Me.lblMensaje.Name = "lblMensaje"
    Me.lblMensaje.Size = New System.Drawing.Size(415, 19)
    Me.lblMensaje.TabIndex = 6
    Me.lblMensaje.Text = "Click en Deshacer para anular la operación y volver a iniciar."
    '
    'frmGestionNiveles
    '
    Me.AcceptButton = Me.btnRegistrar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(690, 483)
    Me.Controls.Add(Me.lblMensaje)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.gbNiveles)
    Me.Controls.Add(Me.btnActualizar)
    Me.Controls.Add(Me.gbNivel)
    Me.Controls.Add(Me.btnRegistrar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.Name = "frmGestionNiveles"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de Niveles"
    CType(Me.dgvNiveles, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbNivel.ResumeLayout(False)
    Me.gbInterno.ResumeLayout(False)
    Me.gbInterno.PerformLayout()
    Me.gbNiveles.ResumeLayout(False)
    CType(Me.errorNiveles, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents dgvNiveles As System.Windows.Forms.DataGridView
    Friend WithEvents gbNivel As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombreNivel As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents gbNiveles As System.Windows.Forms.GroupBox
    Friend WithEvents errorNiveles As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents gbInterno As System.Windows.Forms.GroupBox
    Friend WithEvents txtSiglas As System.Windows.Forms.TextBox
    Friend WithEvents lblSiglas As System.Windows.Forms.Label
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents txtCodigoModular As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cdNivel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdSiglas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdCodigoNivel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdCodigoModular As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
