<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVirtudComportamiento
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
    Me.btnDeshacer = New System.Windows.Forms.Button
    Me.chkRegTodos = New System.Windows.Forms.CheckBox
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.gbBlanco = New System.Windows.Forms.GroupBox
    Me.cboPeriodo = New System.Windows.Forms.ComboBox
    Me.cboNivel = New System.Windows.Forms.ComboBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.txtVirtud = New System.Windows.Forms.TextBox
    Me.chkVigente = New System.Windows.Forms.CheckBox
    Me.gbVirtud = New System.Windows.Forms.GroupBox
    Me.nupNumero = New System.Windows.Forms.NumericUpDown
    Me.lblId = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.gbListaVirtudes = New System.Windows.Forms.GroupBox
    Me.dgVirtudes = New System.Windows.Forms.DataGridView
    Me.cdNumero = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdVirtud = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnModificar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.errVirtud = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.gbBlanco.SuspendLayout()
    Me.gbVirtud.SuspendLayout()
    CType(Me.nupNumero, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbListaVirtudes.SuspendLayout()
    CType(Me.dgVirtudes, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.errVirtud, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnDeshacer
    '
    Me.btnDeshacer.BackColor = System.Drawing.Color.White
    Me.btnDeshacer.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnDeshacer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnDeshacer.Location = New System.Drawing.Point(688, 210)
    Me.btnDeshacer.Name = "btnDeshacer"
    Me.btnDeshacer.Size = New System.Drawing.Size(110, 50)
    Me.btnDeshacer.TabIndex = 3
    Me.btnDeshacer.Text = "&Deshacer"
    Me.btnDeshacer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnDeshacer.UseVisualStyleBackColor = False
    '
    'chkRegTodos
    '
    Me.chkRegTodos.AutoSize = True
    Me.chkRegTodos.Location = New System.Drawing.Point(57, 136)
    Me.chkRegTodos.Name = "chkRegTodos"
    Me.chkRegTodos.Size = New System.Drawing.Size(203, 19)
    Me.chkRegTodos.TabIndex = 3
    Me.chkRegTodos.Text = "Registrar para todos los periodos"
    Me.chkRegTodos.UseVisualStyleBackColor = True
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(688, 154)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 50)
    Me.btnRegistrar.TabIndex = 2
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'gbBlanco
    '
    Me.gbBlanco.Controls.Add(Me.cboPeriodo)
    Me.gbBlanco.Controls.Add(Me.cboNivel)
    Me.gbBlanco.Controls.Add(Me.Label2)
    Me.gbBlanco.Controls.Add(Me.Label1)
    Me.gbBlanco.Location = New System.Drawing.Point(350, 10)
    Me.gbBlanco.Name = "gbBlanco"
    Me.gbBlanco.Size = New System.Drawing.Size(332, 127)
    Me.gbBlanco.TabIndex = 0
    Me.gbBlanco.TabStop = False
    '
    'cboPeriodo
    '
    Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboPeriodo.FormattingEnabled = True
    Me.cboPeriodo.Location = New System.Drawing.Point(108, 75)
    Me.cboPeriodo.Name = "cboPeriodo"
    Me.cboPeriodo.Size = New System.Drawing.Size(166, 21)
    Me.cboPeriodo.TabIndex = 3
    '
    'cboNivel
    '
    Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Location = New System.Drawing.Point(108, 32)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(166, 21)
    Me.cboNivel.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(59, 78)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(48, 15)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "&Periodo"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(68, 35)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(38, 15)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "&Nivel "
    '
    'txtVirtud
    '
    Me.txtVirtud.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtVirtud.Location = New System.Drawing.Point(57, 36)
    Me.txtVirtud.Multiline = True
    Me.txtVirtud.Name = "txtVirtud"
    Me.txtVirtud.Size = New System.Drawing.Size(263, 48)
    Me.txtVirtud.TabIndex = 1
    '
    'chkVigente
    '
    Me.chkVigente.AutoSize = True
    Me.chkVigente.Location = New System.Drawing.Point(253, 99)
    Me.chkVigente.Name = "chkVigente"
    Me.chkVigente.Size = New System.Drawing.Size(67, 19)
    Me.chkVigente.TabIndex = 2
    Me.chkVigente.Text = "&Vigente"
    Me.chkVigente.UseVisualStyleBackColor = True
    '
    'gbVirtud
    '
    Me.gbVirtud.Controls.Add(Me.nupNumero)
    Me.gbVirtud.Controls.Add(Me.lblId)
    Me.gbVirtud.Controls.Add(Me.chkRegTodos)
    Me.gbVirtud.Controls.Add(Me.txtVirtud)
    Me.gbVirtud.Controls.Add(Me.chkVigente)
    Me.gbVirtud.Controls.Add(Me.Label3)
    Me.gbVirtud.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbVirtud.Location = New System.Drawing.Point(349, 147)
    Me.gbVirtud.Name = "gbVirtud"
    Me.gbVirtud.Size = New System.Drawing.Size(333, 228)
    Me.gbVirtud.TabIndex = 1
    Me.gbVirtud.TabStop = False
    Me.gbVirtud.Text = "Virtud"
    '
    'nupNumero
    '
    Me.nupNumero.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.nupNumero.Location = New System.Drawing.Point(57, 97)
    Me.nupNumero.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
    Me.nupNumero.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.nupNumero.Name = "nupNumero"
    Me.nupNumero.Size = New System.Drawing.Size(50, 22)
    Me.nupNumero.TabIndex = 5
    Me.nupNumero.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'lblId
    '
    Me.lblId.AutoSize = True
    Me.lblId.Location = New System.Drawing.Point(10, 101)
    Me.lblId.Name = "lblId"
    Me.lblId.Size = New System.Drawing.Size(49, 15)
    Me.lblId.TabIndex = 4
    Me.lblId.Text = "Número"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(10, 39)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(49, 15)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "N&ombre"
    '
    'gbListaVirtudes
    '
    Me.gbListaVirtudes.Controls.Add(Me.dgVirtudes)
    Me.gbListaVirtudes.Controls.Add(Me.btnModificar)
    Me.gbListaVirtudes.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbListaVirtudes.Location = New System.Drawing.Point(11, 9)
    Me.gbListaVirtudes.Name = "gbListaVirtudes"
    Me.gbListaVirtudes.Size = New System.Drawing.Size(333, 366)
    Me.gbListaVirtudes.TabIndex = 5
    Me.gbListaVirtudes.TabStop = False
    Me.gbListaVirtudes.Text = "&Lista de Virtudes"
    '
    'dgVirtudes
    '
    Me.dgVirtudes.AllowUserToAddRows = False
    Me.dgVirtudes.AllowUserToDeleteRows = False
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgVirtudes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgVirtudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgVirtudes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNumero, Me.cdVirtud})
    Me.dgVirtudes.Location = New System.Drawing.Point(14, 39)
    Me.dgVirtudes.MultiSelect = False
    Me.dgVirtudes.Name = "dgVirtudes"
    Me.dgVirtudes.ReadOnly = True
    Me.dgVirtudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgVirtudes.Size = New System.Drawing.Size(304, 253)
    Me.dgVirtudes.TabIndex = 2
    '
    'cdNumero
    '
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.cdNumero.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdNumero.HeaderText = "Id"
    Me.cdNumero.Name = "cdNumero"
    Me.cdNumero.ReadOnly = True
    Me.cdNumero.Width = 30
    '
    'cdVirtud
    '
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.cdVirtud.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdVirtud.HeaderText = "Virtud"
    Me.cdVirtud.Name = "cdVirtud"
    Me.cdVirtud.ReadOnly = True
    Me.cdVirtud.Width = 210
    '
    'btnModificar
    '
    Me.btnModificar.BackColor = System.Drawing.Color.White
    Me.btnModificar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnModificar.Location = New System.Drawing.Point(208, 303)
    Me.btnModificar.Name = "btnModificar"
    Me.btnModificar.Size = New System.Drawing.Size(110, 50)
    Me.btnModificar.TabIndex = 1
    Me.btnModificar.Text = "&Modificar"
    Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnModificar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(688, 325)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 50)
    Me.btnCerrar.TabIndex = 4
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'errVirtud
    '
    Me.errVirtud.ContainerControl = Me
    '
    'frmVirtudComportamiento
    '
    Me.AcceptButton = Me.btnRegistrar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(808, 385)
    Me.Controls.Add(Me.btnDeshacer)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.gbBlanco)
    Me.Controls.Add(Me.gbVirtud)
    Me.Controls.Add(Me.gbListaVirtudes)
    Me.Controls.Add(Me.btnCerrar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.Name = "frmVirtudComportamiento"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Virtudes de Comportamiento"
    Me.gbBlanco.ResumeLayout(False)
    Me.gbBlanco.PerformLayout()
    Me.gbVirtud.ResumeLayout(False)
    Me.gbVirtud.PerformLayout()
    CType(Me.nupNumero, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbListaVirtudes.ResumeLayout(False)
    CType(Me.dgVirtudes, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.errVirtud, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnDeshacer As System.Windows.Forms.Button
  Friend WithEvents chkRegTodos As System.Windows.Forms.CheckBox
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents gbBlanco As System.Windows.Forms.GroupBox
  Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtVirtud As System.Windows.Forms.TextBox
  Friend WithEvents chkVigente As System.Windows.Forms.CheckBox
  Friend WithEvents gbVirtud As System.Windows.Forms.GroupBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents gbListaVirtudes As System.Windows.Forms.GroupBox
  Friend WithEvents btnModificar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents errVirtud As System.Windows.Forms.ErrorProvider
  Friend WithEvents lblId As System.Windows.Forms.Label
  Friend WithEvents nupNumero As System.Windows.Forms.NumericUpDown
  Friend WithEvents dgVirtudes As System.Windows.Forms.DataGridView
  Friend WithEvents cdNumero As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdVirtud As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
