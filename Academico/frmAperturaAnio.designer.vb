<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAperturaAnio
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
    Me.gpbAnioLectivo = New System.Windows.Forms.GroupBox
    Me.txtAnio = New System.Windows.Forms.TextBox
    Me.lblAnio = New System.Windows.Forms.Label
    Me.lblFin1 = New System.Windows.Forms.Label
    Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
    Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
    Me.lblInicio1 = New System.Windows.Forms.Label
    Me.TextBox7 = New System.Windows.Forms.TextBox
    Me.DtpFechaInicio1 = New System.Windows.Forms.DateTimePicker
    Me.gpbPeriodoAcad = New System.Windows.Forms.GroupBox
    Me.gbFecha = New System.Windows.Forms.GroupBox
    Me.dtpFechaFinal2 = New System.Windows.Forms.DateTimePicker
    Me.dtpFechaInicio2 = New System.Windows.Forms.DateTimePicker
    Me.lblInicio2 = New System.Windows.Forms.Label
    Me.lblFin2 = New System.Windows.Forms.Label
    Me.optTrimestre = New System.Windows.Forms.RadioButton
    Me.optBimestre = New System.Windows.Forms.RadioButton
    Me.cboNombre = New System.Windows.Forms.ComboBox
    Me.btnAgregar = New System.Windows.Forms.Button
    Me.dgvPeriodos = New System.Windows.Forms.DataGridView
    Me.cdNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdFechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdFechaFinal = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnEliminar = New System.Windows.Forms.Button
    Me.lblNombre = New System.Windows.Forms.Label
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnGuardar = New System.Windows.Forms.Button
    Me.errValida = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.gpbAnioLectivo.SuspendLayout()
    Me.gpbPeriodoAcad.SuspendLayout()
    Me.gbFecha.SuspendLayout()
    CType(Me.dgvPeriodos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.errValida, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'gpbAnioLectivo
    '
    Me.gpbAnioLectivo.Controls.Add(Me.txtAnio)
    Me.gpbAnioLectivo.Controls.Add(Me.lblAnio)
    Me.gpbAnioLectivo.Controls.Add(Me.lblFin1)
    Me.gpbAnioLectivo.Controls.Add(Me.dtpFechaFinal)
    Me.gpbAnioLectivo.Controls.Add(Me.dtpFechaInicio)
    Me.gpbAnioLectivo.Controls.Add(Me.lblInicio1)
    Me.gpbAnioLectivo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gpbAnioLectivo.Location = New System.Drawing.Point(34, 17)
    Me.gpbAnioLectivo.Name = "gpbAnioLectivo"
    Me.gpbAnioLectivo.Size = New System.Drawing.Size(495, 80)
    Me.gpbAnioLectivo.TabIndex = 0
    Me.gpbAnioLectivo.TabStop = False
    Me.gpbAnioLectivo.Text = "Año lectivo"
    '
    'txtAnio
    '
    Me.txtAnio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAnio.Location = New System.Drawing.Point(62, 33)
    Me.txtAnio.MaxLength = 4
    Me.txtAnio.Name = "txtAnio"
    Me.txtAnio.Size = New System.Drawing.Size(100, 22)
    Me.txtAnio.TabIndex = 1
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Location = New System.Drawing.Point(27, 37)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(31, 15)
    Me.lblAnio.TabIndex = 0
    Me.lblAnio.Text = "A&ño"
    '
    'lblFin1
    '
    Me.lblFin1.AutoSize = True
    Me.lblFin1.Location = New System.Drawing.Point(340, 37)
    Me.lblFin1.Name = "lblFin1"
    Me.lblFin1.Size = New System.Drawing.Size(24, 15)
    Me.lblFin1.TabIndex = 4
    Me.lblFin1.Text = "F&in"
    '
    'dtpFechaFinal
    '
    Me.dtpFechaFinal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaFinal.Location = New System.Drawing.Point(368, 33)
    Me.dtpFechaFinal.Name = "dtpFechaFinal"
    Me.dtpFechaFinal.Size = New System.Drawing.Size(100, 22)
    Me.dtpFechaFinal.TabIndex = 5
    '
    'dtpFechaInicio
    '
    Me.dtpFechaInicio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaInicio.Location = New System.Drawing.Point(220, 33)
    Me.dtpFechaInicio.Name = "dtpFechaInicio"
    Me.dtpFechaInicio.Size = New System.Drawing.Size(100, 22)
    Me.dtpFechaInicio.TabIndex = 3
    '
    'lblInicio1
    '
    Me.lblInicio1.AutoSize = True
    Me.lblInicio1.Location = New System.Drawing.Point(179, 37)
    Me.lblInicio1.Name = "lblInicio1"
    Me.lblInicio1.Size = New System.Drawing.Size(37, 15)
    Me.lblInicio1.TabIndex = 2
    Me.lblInicio1.Text = "I&nicio"
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
    Me.gpbPeriodoAcad.Controls.Add(Me.gbFecha)
    Me.gpbPeriodoAcad.Controls.Add(Me.optTrimestre)
    Me.gpbPeriodoAcad.Controls.Add(Me.optBimestre)
    Me.gpbPeriodoAcad.Controls.Add(Me.cboNombre)
    Me.gpbPeriodoAcad.Controls.Add(Me.btnAgregar)
    Me.gpbPeriodoAcad.Controls.Add(Me.dgvPeriodos)
    Me.gpbPeriodoAcad.Controls.Add(Me.btnEliminar)
    Me.gpbPeriodoAcad.Controls.Add(Me.lblNombre)
    Me.gpbPeriodoAcad.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gpbPeriodoAcad.Location = New System.Drawing.Point(34, 123)
    Me.gpbPeriodoAcad.Name = "gpbPeriodoAcad"
    Me.gpbPeriodoAcad.Size = New System.Drawing.Size(495, 337)
    Me.gpbPeriodoAcad.TabIndex = 1
    Me.gpbPeriodoAcad.TabStop = False
    Me.gpbPeriodoAcad.Text = "Periodo académico"
    '
    'gbFecha
    '
    Me.gbFecha.Controls.Add(Me.dtpFechaFinal2)
    Me.gbFecha.Controls.Add(Me.dtpFechaInicio2)
    Me.gbFecha.Controls.Add(Me.lblInicio2)
    Me.gbFecha.Controls.Add(Me.lblFin2)
    Me.gbFecha.Location = New System.Drawing.Point(53, 67)
    Me.gbFecha.Name = "gbFecha"
    Me.gbFecha.Size = New System.Drawing.Size(389, 53)
    Me.gbFecha.TabIndex = 4
    Me.gbFecha.TabStop = False
    Me.gbFecha.Text = "Fecha"
    '
    'dtpFechaFinal2
    '
    Me.dtpFechaFinal2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaFinal2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaFinal2.Location = New System.Drawing.Point(245, 20)
    Me.dtpFechaFinal2.Name = "dtpFechaFinal2"
    Me.dtpFechaFinal2.Size = New System.Drawing.Size(121, 22)
    Me.dtpFechaFinal2.TabIndex = 3
    '
    'dtpFechaInicio2
    '
    Me.dtpFechaInicio2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaInicio2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaInicio2.Location = New System.Drawing.Point(65, 20)
    Me.dtpFechaInicio2.Name = "dtpFechaInicio2"
    Me.dtpFechaInicio2.Size = New System.Drawing.Size(121, 22)
    Me.dtpFechaInicio2.TabIndex = 1
    '
    'lblInicio2
    '
    Me.lblInicio2.AutoSize = True
    Me.lblInicio2.Location = New System.Drawing.Point(22, 24)
    Me.lblInicio2.Name = "lblInicio2"
    Me.lblInicio2.Size = New System.Drawing.Size(37, 15)
    Me.lblInicio2.TabIndex = 0
    Me.lblInicio2.Text = "Inici&o"
    '
    'lblFin2
    '
    Me.lblFin2.AutoSize = True
    Me.lblFin2.Location = New System.Drawing.Point(215, 24)
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
    Me.optTrimestre.Location = New System.Drawing.Point(268, 32)
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
    Me.optBimestre.Location = New System.Drawing.Point(365, 32)
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
    Me.cboNombre.Location = New System.Drawing.Point(103, 30)
    Me.cboNombre.Name = "cboNombre"
    Me.cboNombre.Size = New System.Drawing.Size(134, 24)
    Me.cboNombre.TabIndex = 1
    '
    'btnAgregar
    '
    Me.btnAgregar.Location = New System.Drawing.Point(29, 137)
    Me.btnAgregar.Name = "btnAgregar"
    Me.btnAgregar.Size = New System.Drawing.Size(79, 30)
    Me.btnAgregar.TabIndex = 5
    Me.btnAgregar.Text = "&Agregar"
    Me.btnAgregar.UseVisualStyleBackColor = True
    '
    'dgvPeriodos
    '
    Me.dgvPeriodos.AllowUserToAddRows = False
    Me.dgvPeriodos.AllowUserToDeleteRows = False
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvPeriodos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvPeriodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvPeriodos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNombre, Me.cdFechaInicio, Me.cdFechaFinal})
    Me.dgvPeriodos.Location = New System.Drawing.Point(29, 175)
    Me.dgvPeriodos.MultiSelect = False
    Me.dgvPeriodos.Name = "dgvPeriodos"
    Me.dgvPeriodos.ReadOnly = True
    Me.dgvPeriodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvPeriodos.Size = New System.Drawing.Size(436, 143)
    Me.dgvPeriodos.TabIndex = 7
    '
    'cdNombre
    '
    Me.cdNombre.DataPropertyName = "nombre"
    Me.cdNombre.HeaderText = "Nombre"
    Me.cdNombre.Name = "cdNombre"
    Me.cdNombre.ReadOnly = True
    Me.cdNombre.Width = 180
    '
    'cdFechaInicio
    '
    Me.cdFechaInicio.DataPropertyName = "fechaIni"
    DataGridViewCellStyle2.Format = "d"
    DataGridViewCellStyle2.NullValue = Nothing
    Me.cdFechaInicio.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdFechaInicio.HeaderText = "Inicio"
    Me.cdFechaInicio.Name = "cdFechaInicio"
    Me.cdFechaInicio.ReadOnly = True
    Me.cdFechaInicio.Width = 80
    '
    'cdFechaFinal
    '
    Me.cdFechaFinal.DataPropertyName = "fechaFin"
    DataGridViewCellStyle3.Format = "d"
    DataGridViewCellStyle3.NullValue = Nothing
    Me.cdFechaFinal.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdFechaFinal.HeaderText = "Fin"
    Me.cdFechaFinal.Name = "cdFechaFinal"
    Me.cdFechaFinal.ReadOnly = True
    Me.cdFechaFinal.Width = 80
    '
    'btnEliminar
    '
    Me.btnEliminar.Location = New System.Drawing.Point(114, 137)
    Me.btnEliminar.Name = "btnEliminar"
    Me.btnEliminar.Size = New System.Drawing.Size(79, 30)
    Me.btnEliminar.TabIndex = 6
    Me.btnEliminar.Text = "&Eliminar"
    Me.btnEliminar.UseVisualStyleBackColor = True
    '
    'lblNombre
    '
    Me.lblNombre.AutoSize = True
    Me.lblNombre.Location = New System.Drawing.Point(51, 33)
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
    Me.btnCancelar.Location = New System.Drawing.Point(544, 410)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 50)
    Me.btnCancelar.TabIndex = 3
    Me.btnCancelar.Text = "&Cerrar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnGuardar
    '
    Me.btnGuardar.BackColor = System.Drawing.Color.White
    Me.btnGuardar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnGuardar.Location = New System.Drawing.Point(544, 196)
    Me.btnGuardar.Name = "btnGuardar"
    Me.btnGuardar.Size = New System.Drawing.Size(110, 50)
    Me.btnGuardar.TabIndex = 2
    Me.btnGuardar.Text = "&Registrar"
    Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnGuardar.UseVisualStyleBackColor = False
    '
    'errValida
    '
    Me.errValida.ContainerControl = Me
    '
    'frmAperturaAnio
    '
    Me.AcceptButton = Me.btnGuardar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(666, 472)
    Me.Controls.Add(Me.btnGuardar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.gpbPeriodoAcad)
    Me.Controls.Add(Me.gpbAnioLectivo)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmAperturaAnio"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "APERTURA DE AÑO ESCOLAR"
    Me.gpbAnioLectivo.ResumeLayout(False)
    Me.gpbAnioLectivo.PerformLayout()
    Me.gpbPeriodoAcad.ResumeLayout(False)
    Me.gpbPeriodoAcad.PerformLayout()
    Me.gbFecha.ResumeLayout(False)
    Me.gbFecha.PerformLayout()
    CType(Me.dgvPeriodos, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.errValida, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
    Friend WithEvents gpbAnioLectivo As System.Windows.Forms.GroupBox
    Friend WithEvents lblAnio As System.Windows.Forms.Label
    Friend WithEvents lblFin1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblInicio1 As System.Windows.Forms.Label
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
    Friend WithEvents dtpFechaFinal2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblInicio2 As System.Windows.Forms.Label
    Friend WithEvents lblFin2 As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents dgvPeriodos As System.Windows.Forms.DataGridView
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtAnio As System.Windows.Forms.TextBox
    Friend WithEvents errValida As System.Windows.Forms.ErrorProvider
    Friend WithEvents cboNombre As System.Windows.Forms.ComboBox
    Friend WithEvents optTrimestre As System.Windows.Forms.RadioButton
  Friend WithEvents optBimestre As System.Windows.Forms.RadioButton
  Friend WithEvents cdNombre As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdFechaInicio As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdFechaFinal As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents gbFecha As System.Windows.Forms.GroupBox

End Class
