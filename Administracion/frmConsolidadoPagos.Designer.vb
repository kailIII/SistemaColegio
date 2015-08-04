<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsolidadoPagos
    Inherits System.Windows.Forms.Form

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
    Me.btnExportar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.dgvConsolidadoPagos = New System.Windows.Forms.DataGridView
    Me.btnListar = New System.Windows.Forms.Button
    Me.cboAnio = New System.Windows.Forms.ComboBox
    Me.lblAnioLectivo = New System.Windows.Forms.Label
    Me.pbAvance = New System.Windows.Forms.ProgressBar
    Me.chkSoloDeudores = New System.Windows.Forms.CheckBox
    Me.cboNivel = New System.Windows.Forms.ComboBox
    Me.cboSeccion = New System.Windows.Forms.ComboBox
    Me.lblNivel = New System.Windows.Forms.Label
    Me.chkSeccion = New System.Windows.Forms.CheckBox
    Me.panSeccion = New System.Windows.Forms.Panel
    Me.chkSoloSeccion = New System.Windows.Forms.CheckBox
    Me.lblFechaRef = New System.Windows.Forms.Label
    Me.dtpFechaRef = New System.Windows.Forms.DateTimePicker
    Me.cboEntidad = New System.Windows.Forms.ComboBox
    Me.lblEntidad = New System.Windows.Forms.Label
    CType(Me.dgvConsolidadoPagos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.panSeccion.SuspendLayout()
    Me.SuspendLayout()
    '
    'btnExportar
    '
    Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnExportar.BackColor = System.Drawing.Color.White
    Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnExportar.Location = New System.Drawing.Point(454, 506)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(110, 52)
    Me.btnExportar.TabIndex = 12
    Me.btnExportar.Text = "&Exportar"
    Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnExportar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(588, 506)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 13
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'dgvConsolidadoPagos
    '
    Me.dgvConsolidadoPagos.AllowUserToAddRows = False
    Me.dgvConsolidadoPagos.AllowUserToDeleteRows = False
    Me.dgvConsolidadoPagos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvConsolidadoPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvConsolidadoPagos.Location = New System.Drawing.Point(19, 208)
    Me.dgvConsolidadoPagos.MultiSelect = False
    Me.dgvConsolidadoPagos.Name = "dgvConsolidadoPagos"
    Me.dgvConsolidadoPagos.ReadOnly = True
    Me.dgvConsolidadoPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvConsolidadoPagos.Size = New System.Drawing.Size(679, 292)
    Me.dgvConsolidadoPagos.TabIndex = 10
    '
    'btnListar
    '
    Me.btnListar.Location = New System.Drawing.Point(517, 150)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(110, 52)
    Me.btnListar.TabIndex = 9
    Me.btnListar.Text = "&Listar"
    Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnListar.UseVisualStyleBackColor = True
    '
    'cboAnio
    '
    Me.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAnio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboAnio.FormattingEnabled = True
    Me.cboAnio.Location = New System.Drawing.Point(52, 35)
    Me.cboAnio.Name = "cboAnio"
    Me.cboAnio.Size = New System.Drawing.Size(120, 24)
    Me.cboAnio.TabIndex = 1
    '
    'lblAnioLectivo
    '
    Me.lblAnioLectivo.AutoSize = True
    Me.lblAnioLectivo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAnioLectivo.Location = New System.Drawing.Point(15, 44)
    Me.lblAnioLectivo.Name = "lblAnioLectivo"
    Me.lblAnioLectivo.Size = New System.Drawing.Size(31, 15)
    Me.lblAnioLectivo.TabIndex = 0
    Me.lblAnioLectivo.Text = "&Año"
    '
    'pbAvance
    '
    Me.pbAvance.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.pbAvance.Location = New System.Drawing.Point(19, 506)
    Me.pbAvance.Name = "pbAvance"
    Me.pbAvance.Size = New System.Drawing.Size(429, 52)
    Me.pbAvance.TabIndex = 11
    Me.pbAvance.Visible = False
    '
    'chkSoloDeudores
    '
    Me.chkSoloDeudores.AutoSize = True
    Me.chkSoloDeudores.Location = New System.Drawing.Point(19, 77)
    Me.chkSoloDeudores.Name = "chkSoloDeudores"
    Me.chkSoloDeudores.Size = New System.Drawing.Size(165, 17)
    Me.chkSoloDeudores.TabIndex = 4
    Me.chkSoloDeudores.Text = "Ver sólo alumnos con &deudas"
    Me.chkSoloDeudores.UseVisualStyleBackColor = True
    '
    'cboNivel
    '
    Me.cboNivel.BackColor = System.Drawing.SystemColors.Info
    Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNivel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Location = New System.Drawing.Point(50, 10)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(132, 24)
    Me.cboNivel.TabIndex = 1
    '
    'cboSeccion
    '
    Me.cboSeccion.BackColor = System.Drawing.SystemColors.Info
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Enabled = False
    Me.cboSeccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(335, 10)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(132, 24)
    Me.cboSeccion.TabIndex = 3
    '
    'lblNivel
    '
    Me.lblNivel.AutoSize = True
    Me.lblNivel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNivel.Location = New System.Drawing.Point(13, 19)
    Me.lblNivel.Name = "lblNivel"
    Me.lblNivel.Size = New System.Drawing.Size(35, 15)
    Me.lblNivel.TabIndex = 0
    Me.lblNivel.Text = "&Nivel"
    '
    'chkSeccion
    '
    Me.chkSeccion.AutoSize = True
    Me.chkSeccion.Location = New System.Drawing.Point(19, 111)
    Me.chkSeccion.Name = "chkSeccion"
    Me.chkSeccion.Size = New System.Drawing.Size(82, 17)
    Me.chkSeccion.TabIndex = 5
    Me.chkSeccion.Text = "&Por &sección"
    Me.chkSeccion.UseVisualStyleBackColor = True
    '
    'panSeccion
    '
    Me.panSeccion.Controls.Add(Me.chkSoloSeccion)
    Me.panSeccion.Controls.Add(Me.cboNivel)
    Me.panSeccion.Controls.Add(Me.lblNivel)
    Me.panSeccion.Controls.Add(Me.cboSeccion)
    Me.panSeccion.Enabled = False
    Me.panSeccion.Location = New System.Drawing.Point(19, 120)
    Me.panSeccion.Name = "panSeccion"
    Me.panSeccion.Size = New System.Drawing.Size(478, 47)
    Me.panSeccion.TabIndex = 6
    '
    'chkSoloSeccion
    '
    Me.chkSoloSeccion.AutoSize = True
    Me.chkSoloSeccion.Location = New System.Drawing.Point(264, 17)
    Me.chkSoloSeccion.Name = "chkSoloSeccion"
    Me.chkSoloSeccion.Size = New System.Drawing.Size(65, 17)
    Me.chkSoloSeccion.TabIndex = 2
    Me.chkSoloSeccion.Text = "Secció&n"
    Me.chkSoloSeccion.UseVisualStyleBackColor = True
    '
    'lblFechaRef
    '
    Me.lblFechaRef.AutoSize = True
    Me.lblFechaRef.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFechaRef.Location = New System.Drawing.Point(17, 187)
    Me.lblFechaRef.Name = "lblFechaRef"
    Me.lblFechaRef.Size = New System.Drawing.Size(110, 15)
    Me.lblFechaRef.TabIndex = 7
    Me.lblFechaRef.Text = "Fecha de &referencia"
    '
    'dtpFechaRef
    '
    Me.dtpFechaRef.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaRef.Location = New System.Drawing.Point(133, 182)
    Me.dtpFechaRef.Name = "dtpFechaRef"
    Me.dtpFechaRef.Size = New System.Drawing.Size(112, 20)
    Me.dtpFechaRef.TabIndex = 8
    '
    'cboEntidad
    '
    Me.cboEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboEntidad.FormattingEnabled = True
    Me.cboEntidad.Items.AddRange(New Object() {"INST EDUCATIVA", "COPAFA"})
    Me.cboEntidad.Location = New System.Drawing.Point(282, 35)
    Me.cboEntidad.Name = "cboEntidad"
    Me.cboEntidad.Size = New System.Drawing.Size(166, 24)
    Me.cboEntidad.TabIndex = 3
    '
    'lblEntidad
    '
    Me.lblEntidad.AutoSize = True
    Me.lblEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblEntidad.Location = New System.Drawing.Point(222, 42)
    Me.lblEntidad.Name = "lblEntidad"
    Me.lblEntidad.Size = New System.Drawing.Size(54, 16)
    Me.lblEntidad.TabIndex = 2
    Me.lblEntidad.Text = "E&ntidad"
    '
    'frmConsolidadoPagos
    '
    Me.AcceptButton = Me.btnListar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(710, 567)
    Me.Controls.Add(Me.cboEntidad)
    Me.Controls.Add(Me.lblEntidad)
    Me.Controls.Add(Me.dtpFechaRef)
    Me.Controls.Add(Me.lblFechaRef)
    Me.Controls.Add(Me.chkSeccion)
    Me.Controls.Add(Me.panSeccion)
    Me.Controls.Add(Me.chkSoloDeudores)
    Me.Controls.Add(Me.pbAvance)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.dgvConsolidadoPagos)
    Me.Controls.Add(Me.btnListar)
    Me.Controls.Add(Me.cboAnio)
    Me.Controls.Add(Me.lblAnioLectivo)
    Me.Name = "frmConsolidadoPagos"
    Me.Text = "Consolidado de pagos"
    CType(Me.dgvConsolidadoPagos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.panSeccion.ResumeLayout(False)
    Me.panSeccion.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents dgvConsolidadoPagos As System.Windows.Forms.DataGridView
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
  Friend WithEvents lblAnioLectivo As System.Windows.Forms.Label
  Friend WithEvents pbAvance As System.Windows.Forms.ProgressBar
  Friend WithEvents chkSoloDeudores As System.Windows.Forms.CheckBox
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents lblNivel As System.Windows.Forms.Label
  Friend WithEvents chkSeccion As System.Windows.Forms.CheckBox
  Friend WithEvents panSeccion As System.Windows.Forms.Panel
  Friend WithEvents chkSoloSeccion As System.Windows.Forms.CheckBox
  Friend WithEvents lblFechaRef As System.Windows.Forms.Label
  Friend WithEvents dtpFechaRef As System.Windows.Forms.DateTimePicker
  Friend WithEvents cboEntidad As System.Windows.Forms.ComboBox
  Friend WithEvents lblEntidad As System.Windows.Forms.Label
End Class
