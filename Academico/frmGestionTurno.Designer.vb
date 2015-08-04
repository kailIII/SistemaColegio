<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionTurno
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
    Me.lblHoraIng = New System.Windows.Forms.Label
    Me.lblHoraSal = New System.Windows.Forms.Label
    Me.dtpHIngreso = New System.Windows.Forms.DateTimePicker
    Me.dtpHSalida = New System.Windows.Forms.DateTimePicker
    Me.gbTurno = New System.Windows.Forms.GroupBox
    Me.gbInterno = New System.Windows.Forms.GroupBox
    Me.txtNombre = New System.Windows.Forms.TextBox
    Me.lblNombre = New System.Windows.Forms.Label
    Me.dgvturnos = New System.Windows.Forms.DataGridView
    Me.cdTurno = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdHoraI = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdHoraS = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.gbListaTurnos = New System.Windows.Forms.GroupBox
    Me.btnModificar = New System.Windows.Forms.Button
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.errTurno = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.lblMensaje = New System.Windows.Forms.Label
    Me.gbTurno.SuspendLayout()
    Me.gbInterno.SuspendLayout()
    CType(Me.dgvturnos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbListaTurnos.SuspendLayout()
    CType(Me.errTurno, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblHoraIng
    '
    Me.lblHoraIng.AutoSize = True
    Me.lblHoraIng.Location = New System.Drawing.Point(27, 66)
    Me.lblHoraIng.Name = "lblHoraIng"
    Me.lblHoraIng.Size = New System.Drawing.Size(77, 15)
    Me.lblHoraIng.TabIndex = 2
    Me.lblHoraIng.Text = "Hora Ingreso"
    '
    'lblHoraSal
    '
    Me.lblHoraSal.AutoSize = True
    Me.lblHoraSal.Location = New System.Drawing.Point(36, 99)
    Me.lblHoraSal.Name = "lblHoraSal"
    Me.lblHoraSal.Size = New System.Drawing.Size(68, 15)
    Me.lblHoraSal.TabIndex = 4
    Me.lblHoraSal.Text = "Hora Salida"
    '
    'dtpHIngreso
    '
    Me.dtpHIngreso.CustomFormat = "hh:mm tt"
    Me.dtpHIngreso.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpHIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtpHIngreso.Location = New System.Drawing.Point(115, 62)
    Me.dtpHIngreso.Name = "dtpHIngreso"
    Me.dtpHIngreso.ShowUpDown = True
    Me.dtpHIngreso.Size = New System.Drawing.Size(153, 22)
    Me.dtpHIngreso.TabIndex = 3
    Me.dtpHIngreso.Value = New Date(2010, 2, 12, 7, 30, 0, 0)
    '
    'dtpHSalida
    '
    Me.dtpHSalida.CustomFormat = "hh:mm tt"
    Me.dtpHSalida.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpHSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtpHSalida.Location = New System.Drawing.Point(115, 95)
    Me.dtpHSalida.Name = "dtpHSalida"
    Me.dtpHSalida.ShowUpDown = True
    Me.dtpHSalida.Size = New System.Drawing.Size(153, 22)
    Me.dtpHSalida.TabIndex = 5
    Me.dtpHSalida.Value = New Date(2010, 2, 12, 13, 30, 0, 0)
    '
    'gbTurno
    '
    Me.gbTurno.Controls.Add(Me.gbInterno)
    Me.gbTurno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbTurno.Location = New System.Drawing.Point(49, 261)
    Me.gbTurno.Name = "gbTurno"
    Me.gbTurno.Size = New System.Drawing.Size(379, 200)
    Me.gbTurno.TabIndex = 0
    Me.gbTurno.TabStop = False
    Me.gbTurno.Text = "Turno"
    '
    'gbInterno
    '
    Me.gbInterno.Controls.Add(Me.txtNombre)
    Me.gbInterno.Controls.Add(Me.lblNombre)
    Me.gbInterno.Controls.Add(Me.dtpHSalida)
    Me.gbInterno.Controls.Add(Me.dtpHIngreso)
    Me.gbInterno.Controls.Add(Me.lblHoraSal)
    Me.gbInterno.Controls.Add(Me.lblHoraIng)
    Me.gbInterno.Location = New System.Drawing.Point(42, 29)
    Me.gbInterno.Name = "gbInterno"
    Me.gbInterno.Size = New System.Drawing.Size(294, 145)
    Me.gbInterno.TabIndex = 0
    Me.gbInterno.TabStop = False
    '
    'txtNombre
    '
    Me.txtNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNombre.Location = New System.Drawing.Point(115, 27)
    Me.txtNombre.Multiline = True
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Size = New System.Drawing.Size(153, 24)
    Me.txtNombre.TabIndex = 1
    '
    'lblNombre
    '
    Me.lblNombre.AutoSize = True
    Me.lblNombre.Location = New System.Drawing.Point(55, 34)
    Me.lblNombre.Name = "lblNombre"
    Me.lblNombre.Size = New System.Drawing.Size(49, 15)
    Me.lblNombre.TabIndex = 0
    Me.lblNombre.Text = "Nombre"
    '
    'dgvturnos
    '
    Me.dgvturnos.AllowUserToAddRows = False
    Me.dgvturnos.AllowUserToDeleteRows = False
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvturnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvturnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvturnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdTurno, Me.cdHoraI, Me.cdHoraS})
    Me.dgvturnos.Location = New System.Drawing.Point(32, 27)
    Me.dgvturnos.Name = "dgvturnos"
    Me.dgvturnos.ReadOnly = True
    Me.dgvturnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvturnos.Size = New System.Drawing.Size(314, 150)
    Me.dgvturnos.TabIndex = 0
    '
    'cdTurno
    '
    Me.cdTurno.HeaderText = "Turno"
    Me.cdTurno.Name = "cdTurno"
    Me.cdTurno.ReadOnly = True
    Me.cdTurno.Width = 90
    '
    'cdHoraI
    '
    DataGridViewCellStyle2.Format = "t"
    DataGridViewCellStyle2.NullValue = Nothing
    Me.cdHoraI.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdHoraI.HeaderText = "Hora_Ingreso"
    Me.cdHoraI.Name = "cdHoraI"
    Me.cdHoraI.ReadOnly = True
    Me.cdHoraI.Width = 90
    '
    'cdHoraS
    '
    DataGridViewCellStyle3.Format = "t"
    DataGridViewCellStyle3.NullValue = Nothing
    Me.cdHoraS.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdHoraS.HeaderText = "Hora_Salida"
    Me.cdHoraS.Name = "cdHoraS"
    Me.cdHoraS.ReadOnly = True
    Me.cdHoraS.Width = 90
    '
    'gbListaTurnos
    '
    Me.gbListaTurnos.Controls.Add(Me.dgvturnos)
    Me.gbListaTurnos.Location = New System.Drawing.Point(49, 25)
    Me.gbListaTurnos.Name = "gbListaTurnos"
    Me.gbListaTurnos.Size = New System.Drawing.Size(379, 195)
    Me.gbListaTurnos.TabIndex = 4
    Me.gbListaTurnos.TabStop = False
    Me.gbListaTurnos.Text = "Lista de turnos"
    '
    'btnModificar
    '
    Me.btnModificar.BackColor = System.Drawing.Color.White
    Me.btnModificar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnModificar.Location = New System.Drawing.Point(485, 52)
    Me.btnModificar.Name = "btnModificar"
    Me.btnModificar.Size = New System.Drawing.Size(110, 50)
    Me.btnModificar.TabIndex = 3
    Me.btnModificar.Text = "&Modificar"
    Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnModificar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(485, 270)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 50)
    Me.btnRegistrar.TabIndex = 1
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(485, 326)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 50)
    Me.btnCancelar.TabIndex = 2
    Me.btnCancelar.Text = "&Deshacer"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(485, 411)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 50)
    Me.btnCerrar.TabIndex = 5
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'errTurno
    '
    Me.errTurno.ContainerControl = Me
    '
    'lblMensaje
    '
    Me.lblMensaje.AutoSize = True
    Me.lblMensaje.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMensaje.ForeColor = System.Drawing.SystemColors.ActiveCaption
    Me.lblMensaje.Location = New System.Drawing.Point(45, 476)
    Me.lblMensaje.Name = "lblMensaje"
    Me.lblMensaje.Size = New System.Drawing.Size(416, 19)
    Me.lblMensaje.TabIndex = 7
    Me.lblMensaje.Text = "Click en Deshacer para anular la operación y volver a iniciar."
    '
    'frmTurno
    '
    Me.AcceptButton = Me.btnRegistrar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(640, 508)
    Me.Controls.Add(Me.lblMensaje)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.btnModificar)
    Me.Controls.Add(Me.gbListaTurnos)
    Me.Controls.Add(Me.gbTurno)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.Name = "frmTurno"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de Turnos"
    Me.gbTurno.ResumeLayout(False)
    Me.gbInterno.ResumeLayout(False)
    Me.gbInterno.PerformLayout()
    CType(Me.dgvturnos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbListaTurnos.ResumeLayout(False)
    CType(Me.errTurno, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblHoraIng As System.Windows.Forms.Label
  Friend WithEvents lblHoraSal As System.Windows.Forms.Label
  Friend WithEvents dtpHIngreso As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtpHSalida As System.Windows.Forms.DateTimePicker
  Friend WithEvents gbTurno As System.Windows.Forms.GroupBox
  Friend WithEvents dgvturnos As System.Windows.Forms.DataGridView
  Friend WithEvents gbListaTurnos As System.Windows.Forms.GroupBox
  Friend WithEvents btnModificar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents lblNombre As System.Windows.Forms.Label
  Friend WithEvents errTurno As System.Windows.Forms.ErrorProvider
  Friend WithEvents gbInterno As System.Windows.Forms.GroupBox
  Friend WithEvents cdTurno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdHoraI As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdHoraS As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents lblMensaje As System.Windows.Forms.Label
End Class
