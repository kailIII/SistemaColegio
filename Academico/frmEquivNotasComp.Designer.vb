<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEquivNotasComp
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
    Me.gbListado = New System.Windows.Forms.GroupBox
    Me.btnModificar = New System.Windows.Forms.Button
    Me.dgEquivalencia = New System.Windows.Forms.DataGridView
    Me.cdPuntaje = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCualitativo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.gbEquivalencia = New System.Windows.Forms.GroupBox
    Me.chkVigente = New System.Windows.Forms.CheckBox
    Me.nudPuntos = New System.Windows.Forms.NumericUpDown
    Me.txtEspecif = New System.Windows.Forms.TextBox
    Me.txtCualitativo = New System.Windows.Forms.TextBox
    Me.lblEspecificacion = New System.Windows.Forms.Label
    Me.lblPuntos = New System.Windows.Forms.Label
    Me.lblCualitativo = New System.Windows.Forms.Label
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.btnDeshacer = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.errEquivalencia = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.gbListado.SuspendLayout()
    CType(Me.dgEquivalencia, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbEquivalencia.SuspendLayout()
    CType(Me.nudPuntos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.errEquivalencia, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'gbListado
    '
    Me.gbListado.Controls.Add(Me.btnModificar)
    Me.gbListado.Controls.Add(Me.dgEquivalencia)
    Me.gbListado.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbListado.Location = New System.Drawing.Point(12, 12)
    Me.gbListado.Name = "gbListado"
    Me.gbListado.Size = New System.Drawing.Size(326, 347)
    Me.gbListado.TabIndex = 3
    Me.gbListado.TabStop = False
    Me.gbListado.Text = "Listado de Equivalencias"
    '
    'btnModificar
    '
    Me.btnModificar.BackColor = System.Drawing.Color.White
    Me.btnModificar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnModificar.Location = New System.Drawing.Point(192, 288)
    Me.btnModificar.Name = "btnModificar"
    Me.btnModificar.Size = New System.Drawing.Size(110, 50)
    Me.btnModificar.TabIndex = 1
    Me.btnModificar.Text = "&Modificar"
    Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnModificar.UseVisualStyleBackColor = False
    '
    'dgEquivalencia
    '
    Me.dgEquivalencia.AllowUserToAddRows = False
    Me.dgEquivalencia.AllowUserToDeleteRows = False
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgEquivalencia.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgEquivalencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgEquivalencia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdPuntaje, Me.cdCualitativo})
    Me.dgEquivalencia.Location = New System.Drawing.Point(24, 28)
    Me.dgEquivalencia.MultiSelect = False
    Me.dgEquivalencia.Name = "dgEquivalencia"
    Me.dgEquivalencia.ReadOnly = True
    Me.dgEquivalencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgEquivalencia.Size = New System.Drawing.Size(278, 254)
    Me.dgEquivalencia.TabIndex = 0
    '
    'cdPuntaje
    '
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.cdPuntaje.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdPuntaje.HeaderText = "Puntos"
    Me.cdPuntaje.Name = "cdPuntaje"
    Me.cdPuntaje.ReadOnly = True
    Me.cdPuntaje.Width = 50
    '
    'cdCualitativo
    '
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.cdCualitativo.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdCualitativo.HeaderText = "Cualitativo"
    Me.cdCualitativo.Name = "cdCualitativo"
    Me.cdCualitativo.ReadOnly = True
    Me.cdCualitativo.Width = 175
    '
    'gbEquivalencia
    '
    Me.gbEquivalencia.Controls.Add(Me.chkVigente)
    Me.gbEquivalencia.Controls.Add(Me.nudPuntos)
    Me.gbEquivalencia.Controls.Add(Me.txtEspecif)
    Me.gbEquivalencia.Controls.Add(Me.txtCualitativo)
    Me.gbEquivalencia.Controls.Add(Me.lblEspecificacion)
    Me.gbEquivalencia.Controls.Add(Me.lblPuntos)
    Me.gbEquivalencia.Controls.Add(Me.lblCualitativo)
    Me.gbEquivalencia.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbEquivalencia.Location = New System.Drawing.Point(344, 12)
    Me.gbEquivalencia.Name = "gbEquivalencia"
    Me.gbEquivalencia.Size = New System.Drawing.Size(320, 347)
    Me.gbEquivalencia.TabIndex = 0
    Me.gbEquivalencia.TabStop = False
    Me.gbEquivalencia.Text = "Equivalencia"
    '
    'chkVigente
    '
    Me.chkVigente.AutoSize = True
    Me.chkVigente.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkVigente.Location = New System.Drawing.Point(100, 222)
    Me.chkVigente.Name = "chkVigente"
    Me.chkVigente.Size = New System.Drawing.Size(67, 19)
    Me.chkVigente.TabIndex = 6
    Me.chkVigente.Text = "Vigente"
    Me.chkVigente.UseVisualStyleBackColor = True
    '
    'nudPuntos
    '
    Me.nudPuntos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.nudPuntos.Location = New System.Drawing.Point(100, 82)
    Me.nudPuntos.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
    Me.nudPuntos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.nudPuntos.Name = "nudPuntos"
    Me.nudPuntos.Size = New System.Drawing.Size(45, 22)
    Me.nudPuntos.TabIndex = 3
    Me.nudPuntos.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'txtEspecif
    '
    Me.txtEspecif.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtEspecif.Location = New System.Drawing.Point(100, 123)
    Me.txtEspecif.Multiline = True
    Me.txtEspecif.Name = "txtEspecif"
    Me.txtEspecif.Size = New System.Drawing.Size(202, 72)
    Me.txtEspecif.TabIndex = 5
    '
    'txtCualitativo
    '
    Me.txtCualitativo.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCualitativo.Location = New System.Drawing.Point(100, 39)
    Me.txtCualitativo.Multiline = True
    Me.txtCualitativo.Name = "txtCualitativo"
    Me.txtCualitativo.Size = New System.Drawing.Size(202, 24)
    Me.txtCualitativo.TabIndex = 1
    '
    'lblEspecificacion
    '
    Me.lblEspecificacion.AutoSize = True
    Me.lblEspecificacion.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblEspecificacion.Location = New System.Drawing.Point(10, 123)
    Me.lblEspecificacion.Name = "lblEspecificacion"
    Me.lblEspecificacion.Size = New System.Drawing.Size(84, 15)
    Me.lblEspecificacion.TabIndex = 4
    Me.lblEspecificacion.Text = "Es&pecificación"
    '
    'lblPuntos
    '
    Me.lblPuntos.AutoSize = True
    Me.lblPuntos.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPuntos.Location = New System.Drawing.Point(49, 84)
    Me.lblPuntos.Name = "lblPuntos"
    Me.lblPuntos.Size = New System.Drawing.Size(45, 15)
    Me.lblPuntos.TabIndex = 2
    Me.lblPuntos.Text = "Pu&ntos"
    '
    'lblCualitativo
    '
    Me.lblCualitativo.AutoSize = True
    Me.lblCualitativo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCualitativo.Location = New System.Drawing.Point(29, 42)
    Me.lblCualitativo.Name = "lblCualitativo"
    Me.lblCualitativo.Size = New System.Drawing.Size(65, 15)
    Me.lblCualitativo.TabIndex = 0
    Me.lblCualitativo.Text = "Cu&alitativo"
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(670, 84)
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
    Me.btnDeshacer.Location = New System.Drawing.Point(670, 147)
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
    Me.btnCerrar.Location = New System.Drawing.Point(670, 309)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 50)
    Me.btnCerrar.TabIndex = 4
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'errEquivalencia
    '
    Me.errEquivalencia.ContainerControl = Me
    '
    'frmEquivNotasComp
    '
    Me.AcceptButton = Me.btnRegistrar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(790, 372)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnDeshacer)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.gbEquivalencia)
    Me.Controls.Add(Me.gbListado)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.Name = "frmEquivNotasComp"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión: Equivalencia de Notas de Comportamiento"
    Me.gbListado.ResumeLayout(False)
    CType(Me.dgEquivalencia, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbEquivalencia.ResumeLayout(False)
    Me.gbEquivalencia.PerformLayout()
    CType(Me.nudPuntos, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.errEquivalencia, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents gbListado As System.Windows.Forms.GroupBox
  Friend WithEvents dgEquivalencia As System.Windows.Forms.DataGridView
  Friend WithEvents gbEquivalencia As System.Windows.Forms.GroupBox
  Friend WithEvents txtEspecif As System.Windows.Forms.TextBox
  Friend WithEvents txtCualitativo As System.Windows.Forms.TextBox
  Friend WithEvents lblEspecificacion As System.Windows.Forms.Label
  Friend WithEvents lblPuntos As System.Windows.Forms.Label
  Friend WithEvents lblCualitativo As System.Windows.Forms.Label
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnDeshacer As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents nudPuntos As System.Windows.Forms.NumericUpDown
  Friend WithEvents btnModificar As System.Windows.Forms.Button
  Friend WithEvents chkVigente As System.Windows.Forms.CheckBox
  Friend WithEvents errEquivalencia As System.Windows.Forms.ErrorProvider
  Friend WithEvents cdPuntaje As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCualitativo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
