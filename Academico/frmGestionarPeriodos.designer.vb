<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionarPeriodos
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
    Me.components = New System.ComponentModel.Container()
    Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.lblAnio = New System.Windows.Forms.Label()
    Me.TextBox7 = New System.Windows.Forms.TextBox()
    Me.DtpFechaInicio1 = New System.Windows.Forms.DateTimePicker()
    Me.gpbPeriodoAcad = New System.Windows.Forms.GroupBox()
    Me.gbFecha = New System.Windows.Forms.GroupBox()
    Me.dtpFechaFinPeriodo = New System.Windows.Forms.DateTimePicker()
    Me.dtpFechaIniPeriodo = New System.Windows.Forms.DateTimePicker()
    Me.lblInicio2 = New System.Windows.Forms.Label()
    Me.lblFin2 = New System.Windows.Forms.Label()
    Me.optTrimestre = New System.Windows.Forms.RadioButton()
    Me.optBimestre = New System.Windows.Forms.RadioButton()
    Me.cboNombre = New System.Windows.Forms.ComboBox()
    Me.btnAgregar = New System.Windows.Forms.Button()
    Me.dgvPeriodos = New System.Windows.Forms.DataGridView()
    Me.btnEliminar = New System.Windows.Forms.Button()
    Me.lblNombre = New System.Windows.Forms.Label()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.btnGuardar = New System.Windows.Forms.Button()
    Me.errValida = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.cboAnio = New System.Windows.Forms.ComboBox()
    Me.cdNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdFechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdFechaFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.lblSiglas = New System.Windows.Forms.Label()
    Me.txtSiglas = New System.Windows.Forms.TextBox()
    Me.gpbPeriodoAcad.SuspendLayout()
    Me.gbFecha.SuspendLayout()
    CType(Me.dgvPeriodos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.errValida, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Location = New System.Drawing.Point(31, 33)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(26, 13)
    Me.lblAnio.TabIndex = 0
    Me.lblAnio.Text = "A&ño"
    '
    'TextBox7
    '
    Me.TextBox7.Location = New System.Drawing.Point(113, 29)
    Me.TextBox7.Name = "TextBox7"
    Me.TextBox7.Size = New System.Drawing.Size(100, 20)
    Me.TextBox7.TabIndex = 34
    '
    'DtpFechaInicio1
    '
    Me.DtpFechaInicio1.Location = New System.Drawing.Point(113, 181)
    Me.DtpFechaInicio1.Name = "DtpFechaInicio1"
    Me.DtpFechaInicio1.Size = New System.Drawing.Size(200, 20)
    Me.DtpFechaInicio1.TabIndex = 21
    '
    'gpbPeriodoAcad
    '
    Me.gpbPeriodoAcad.Controls.Add(Me.txtSiglas)
    Me.gpbPeriodoAcad.Controls.Add(Me.lblSiglas)
    Me.gpbPeriodoAcad.Controls.Add(Me.gbFecha)
    Me.gpbPeriodoAcad.Controls.Add(Me.optTrimestre)
    Me.gpbPeriodoAcad.Controls.Add(Me.optBimestre)
    Me.gpbPeriodoAcad.Controls.Add(Me.cboNombre)
    Me.gpbPeriodoAcad.Controls.Add(Me.btnAgregar)
    Me.gpbPeriodoAcad.Controls.Add(Me.dgvPeriodos)
    Me.gpbPeriodoAcad.Controls.Add(Me.btnEliminar)
    Me.gpbPeriodoAcad.Controls.Add(Me.lblNombre)
    Me.gpbPeriodoAcad.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gpbPeriodoAcad.Location = New System.Drawing.Point(34, 63)
    Me.gpbPeriodoAcad.Name = "gpbPeriodoAcad"
    Me.gpbPeriodoAcad.Size = New System.Drawing.Size(495, 408)
    Me.gpbPeriodoAcad.TabIndex = 3
    Me.gpbPeriodoAcad.TabStop = False
    Me.gpbPeriodoAcad.Text = "Periodo académico"
    '
    'gbFecha
    '
    Me.gbFecha.Controls.Add(Me.dtpFechaFinPeriodo)
    Me.gbFecha.Controls.Add(Me.dtpFechaIniPeriodo)
    Me.gbFecha.Controls.Add(Me.lblInicio2)
    Me.gbFecha.Controls.Add(Me.lblFin2)
    Me.gbFecha.Location = New System.Drawing.Point(29, 118)
    Me.gbFecha.Name = "gbFecha"
    Me.gbFecha.Size = New System.Drawing.Size(436, 53)
    Me.gbFecha.TabIndex = 6
    Me.gbFecha.TabStop = False
    Me.gbFecha.Text = "Fecha"
    '
    'dtpFechaFinPeriodo
    '
    Me.dtpFechaFinPeriodo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaFinPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaFinPeriodo.Location = New System.Drawing.Point(299, 20)
    Me.dtpFechaFinPeriodo.Name = "dtpFechaFinPeriodo"
    Me.dtpFechaFinPeriodo.Size = New System.Drawing.Size(121, 22)
    Me.dtpFechaFinPeriodo.TabIndex = 3
    '
    'dtpFechaIniPeriodo
    '
    Me.dtpFechaIniPeriodo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaIniPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaIniPeriodo.Location = New System.Drawing.Point(65, 20)
    Me.dtpFechaIniPeriodo.Name = "dtpFechaIniPeriodo"
    Me.dtpFechaIniPeriodo.Size = New System.Drawing.Size(121, 22)
    Me.dtpFechaIniPeriodo.TabIndex = 1
    '
    'lblInicio2
    '
    Me.lblInicio2.AutoSize = True
    Me.lblInicio2.Location = New System.Drawing.Point(22, 26)
    Me.lblInicio2.Name = "lblInicio2"
    Me.lblInicio2.Size = New System.Drawing.Size(37, 15)
    Me.lblInicio2.TabIndex = 0
    Me.lblInicio2.Text = "Inici&o"
    '
    'lblFin2
    '
    Me.lblFin2.AutoSize = True
    Me.lblFin2.Location = New System.Drawing.Point(269, 26)
    Me.lblFin2.Name = "lblFin2"
    Me.lblFin2.Size = New System.Drawing.Size(24, 15)
    Me.lblFin2.TabIndex = 2
    Me.lblFin2.Text = "&Fin"
    '
    'optTrimestre
    '
    Me.optTrimestre.AutoSize = True
    Me.optTrimestre.Checked = True
    Me.optTrimestre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.optTrimestre.Location = New System.Drawing.Point(301, 36)
    Me.optTrimestre.Name = "optTrimestre"
    Me.optTrimestre.Size = New System.Drawing.Size(80, 20)
    Me.optTrimestre.TabIndex = 2
    Me.optTrimestre.TabStop = True
    Me.optTrimestre.Text = "Trimestre"
    Me.optTrimestre.UseVisualStyleBackColor = True
    '
    'optBimestre
    '
    Me.optBimestre.AutoSize = True
    Me.optBimestre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.optBimestre.Location = New System.Drawing.Point(387, 34)
    Me.optBimestre.Name = "optBimestre"
    Me.optBimestre.Size = New System.Drawing.Size(78, 20)
    Me.optBimestre.TabIndex = 3
    Me.optBimestre.Text = "Bimestre"
    Me.optBimestre.UseVisualStyleBackColor = True
    '
    'cboNombre
    '
    Me.cboNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboNombre.FormattingEnabled = True
    Me.cboNombre.Location = New System.Drawing.Point(94, 30)
    Me.cboNombre.Name = "cboNombre"
    Me.cboNombre.Size = New System.Drawing.Size(134, 24)
    Me.cboNombre.TabIndex = 1
    '
    'btnAgregar
    '
    Me.btnAgregar.Location = New System.Drawing.Point(29, 190)
    Me.btnAgregar.Name = "btnAgregar"
    Me.btnAgregar.Size = New System.Drawing.Size(79, 30)
    Me.btnAgregar.TabIndex = 7
    Me.btnAgregar.Text = "&Agregar"
    Me.btnAgregar.UseVisualStyleBackColor = True
    '
    'dgvPeriodos
    '
    Me.dgvPeriodos.AllowUserToAddRows = False
    Me.dgvPeriodos.AllowUserToDeleteRows = False
    DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvPeriodos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
    Me.dgvPeriodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvPeriodos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNombre, Me.cdFechaInicio, Me.cdFechaFinal})
    Me.dgvPeriodos.Location = New System.Drawing.Point(29, 226)
    Me.dgvPeriodos.MultiSelect = False
    Me.dgvPeriodos.Name = "dgvPeriodos"
    Me.dgvPeriodos.ReadOnly = True
    Me.dgvPeriodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvPeriodos.Size = New System.Drawing.Size(436, 176)
    Me.dgvPeriodos.TabIndex = 9
    '
    'btnEliminar
    '
    Me.btnEliminar.Location = New System.Drawing.Point(114, 190)
    Me.btnEliminar.Name = "btnEliminar"
    Me.btnEliminar.Size = New System.Drawing.Size(79, 30)
    Me.btnEliminar.TabIndex = 8
    Me.btnEliminar.Text = "&Eliminar"
    Me.btnEliminar.UseVisualStyleBackColor = True
    '
    'lblNombre
    '
    Me.lblNombre.AutoSize = True
    Me.lblNombre.Location = New System.Drawing.Point(26, 39)
    Me.lblNombre.Name = "lblNombre"
    Me.lblNombre.Size = New System.Drawing.Size(49, 15)
    Me.lblNombre.TabIndex = 0
    Me.lblNombre.Text = "No&mbre"
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(544, 421)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 50)
    Me.btnCancelar.TabIndex = 4
    Me.btnCancelar.Text = "&Cerrar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnGuardar
    '
    Me.btnGuardar.BackColor = System.Drawing.Color.White
    Me.btnGuardar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnGuardar.Location = New System.Drawing.Point(544, 271)
    Me.btnGuardar.Name = "btnGuardar"
    Me.btnGuardar.Size = New System.Drawing.Size(110, 50)
    Me.btnGuardar.TabIndex = 3
    Me.btnGuardar.Text = "&Registrar"
    Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnGuardar.UseVisualStyleBackColor = False
    '
    'errValida
    '
    Me.errValida.ContainerControl = Me
    '
    'cboAnio
    '
    Me.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAnio.FormattingEnabled = True
    Me.cboAnio.Location = New System.Drawing.Point(69, 25)
    Me.cboAnio.Name = "cboAnio"
    Me.cboAnio.Size = New System.Drawing.Size(107, 21)
    Me.cboAnio.TabIndex = 1
    '
    'cdNombre
    '
    Me.cdNombre.DataPropertyName = "Nombre"
    DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
    Me.cdNombre.DefaultCellStyle = DataGridViewCellStyle10
    Me.cdNombre.HeaderText = "Nombre"
    Me.cdNombre.Name = "cdNombre"
    Me.cdNombre.ReadOnly = True
    Me.cdNombre.Width = 180
    '
    'cdFechaInicio
    '
    Me.cdFechaInicio.DataPropertyName = "FechaIni"
    DataGridViewCellStyle11.Format = "d"
    DataGridViewCellStyle11.NullValue = Nothing
    Me.cdFechaInicio.DefaultCellStyle = DataGridViewCellStyle11
    Me.cdFechaInicio.HeaderText = "Inicio"
    Me.cdFechaInicio.Name = "cdFechaInicio"
    Me.cdFechaInicio.ReadOnly = True
    Me.cdFechaInicio.Width = 80
    '
    'cdFechaFinal
    '
    Me.cdFechaFinal.DataPropertyName = "fechaFin"
    DataGridViewCellStyle12.Format = "d"
    DataGridViewCellStyle12.NullValue = Nothing
    Me.cdFechaFinal.DefaultCellStyle = DataGridViewCellStyle12
    Me.cdFechaFinal.HeaderText = "Fin"
    Me.cdFechaFinal.Name = "cdFechaFinal"
    Me.cdFechaFinal.ReadOnly = True
    Me.cdFechaFinal.Width = 80
    '
    'lblSiglas
    '
    Me.lblSiglas.AutoSize = True
    Me.lblSiglas.Location = New System.Drawing.Point(26, 84)
    Me.lblSiglas.Name = "lblSiglas"
    Me.lblSiglas.Size = New System.Drawing.Size(39, 15)
    Me.lblSiglas.TabIndex = 4
    Me.lblSiglas.Text = "Siglas"
    '
    'txtSiglas
    '
    Me.txtSiglas.Location = New System.Drawing.Point(94, 77)
    Me.txtSiglas.Name = "txtSiglas"
    Me.txtSiglas.Size = New System.Drawing.Size(69, 22)
    Me.txtSiglas.TabIndex = 5
    '
    'frmGestionarPeriodos
    '
    Me.AcceptButton = Me.btnGuardar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(666, 483)
    Me.Controls.Add(Me.cboAnio)
    Me.Controls.Add(Me.btnGuardar)
    Me.Controls.Add(Me.lblAnio)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.gpbPeriodoAcad)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmGestionarPeriodos"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "APERTURA DE AÑO ESCOLAR"
    Me.gpbPeriodoAcad.ResumeLayout(False)
    Me.gpbPeriodoAcad.PerformLayout()
    Me.gbFecha.ResumeLayout(False)
    Me.gbFecha.PerformLayout()
    CType(Me.dgvPeriodos, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.errValida, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
  'Friend WithEvents Label21 As System.Windows.Forms.Label
  'Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents DtpFechaFinal1 As System.Windows.Forms.DateTimePicker
  Friend WithEvents cboSiglas As System.Windows.Forms.ComboBox
  Friend WithEvents cbo As System.Windows.Forms.ComboBox
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents DtpFechaInicio1 As System.Windows.Forms.DateTimePicker
  'Friend WithEvents Label20 As System.Windows.Forms.Label
  Friend WithEvents Label19 As System.Windows.Forms.Label
  'Friend WithEvents Label9 As System.Windows.Forms.Label
  'Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents gpbPeriodoAcad As System.Windows.Forms.GroupBox
  Friend WithEvents dtpFechaFinPeriodo As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtpFechaIniPeriodo As System.Windows.Forms.DateTimePicker
  Friend WithEvents lblInicio2 As System.Windows.Forms.Label
  Friend WithEvents lblFin2 As System.Windows.Forms.Label
  Friend WithEvents lblNombre As System.Windows.Forms.Label
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnGuardar As System.Windows.Forms.Button
  Friend WithEvents dgvPeriodos As System.Windows.Forms.DataGridView
  Friend WithEvents btnEliminar As System.Windows.Forms.Button
  Friend WithEvents btnAgregar As System.Windows.Forms.Button
  Friend WithEvents errValida As System.Windows.Forms.ErrorProvider
  Friend WithEvents cboNombre As System.Windows.Forms.ComboBox
  Friend WithEvents optTrimestre As System.Windows.Forms.RadioButton
  Friend WithEvents optBimestre As System.Windows.Forms.RadioButton
  Friend WithEvents gbFecha As System.Windows.Forms.GroupBox
  Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
  Friend WithEvents cdNombre As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdFechaInicio As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdFechaFinal As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents txtSiglas As System.Windows.Forms.TextBox
  Friend WithEvents lblSiglas As System.Windows.Forms.Label

End Class
