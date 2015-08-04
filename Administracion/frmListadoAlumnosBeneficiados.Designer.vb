<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoAlumnosBeneficiados
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.btnExportar = New System.Windows.Forms.Button()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.dgvConsolidadoPagos = New System.Windows.Forms.DataGridView()
    Me.cbSeccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdMotivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdPension = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdPadre = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdMadre = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdDirecccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btnListar = New System.Windows.Forms.Button()
    Me.cboAnio = New System.Windows.Forms.ComboBox()
    Me.lblAnioLectivo = New System.Windows.Forms.Label()
    Me.btnImprimir = New System.Windows.Forms.Button()
    Me.cboFiltro = New System.Windows.Forms.ComboBox()
    Me.lblFiltro = New System.Windows.Forms.Label()
    Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
    Me.dtpFin = New System.Windows.Forms.DateTimePicker()
    Me.lblY = New System.Windows.Forms.Label()
    CType(Me.dgvConsolidadoPagos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnExportar
    '
    Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnExportar.BackColor = System.Drawing.Color.White
    Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnExportar.Location = New System.Drawing.Point(566, 428)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(110, 52)
    Me.btnExportar.TabIndex = 10
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
    Me.btnCerrar.Location = New System.Drawing.Point(682, 428)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 11
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
    Me.dgvConsolidadoPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cbSeccion, Me.cdCodigo, Me.cdAlumno, Me.cdFecha, Me.cdMotivo, Me.cdPension, Me.cdDescuento, Me.cdPadre, Me.cdMadre, Me.cdDirecccion, Me.cdTelefono})
    Me.dgvConsolidadoPagos.Location = New System.Drawing.Point(23, 148)
    Me.dgvConsolidadoPagos.MultiSelect = False
    Me.dgvConsolidadoPagos.Name = "dgvConsolidadoPagos"
    Me.dgvConsolidadoPagos.ReadOnly = True
    Me.dgvConsolidadoPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvConsolidadoPagos.Size = New System.Drawing.Size(769, 274)
    Me.dgvConsolidadoPagos.TabIndex = 8
    '
    'cbSeccion
    '
    Me.cbSeccion.DataPropertyName = "Seccion"
    Me.cbSeccion.HeaderText = "Sección"
    Me.cbSeccion.Name = "cbSeccion"
    Me.cbSeccion.ReadOnly = True
    '
    'cdCodigo
    '
    Me.cdCodigo.DataPropertyName = "CodigoRecaudacion"
    Me.cdCodigo.HeaderText = "Código"
    Me.cdCodigo.Name = "cdCodigo"
    Me.cdCodigo.ReadOnly = True
    Me.cdCodigo.Width = 85
    '
    'cdAlumno
    '
    Me.cdAlumno.DataPropertyName = "Alumno"
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.ReadOnly = True
    Me.cdAlumno.Width = 200
    '
    'cdFecha
    '
    Me.cdFecha.DataPropertyName = "Fecha"
    Me.cdFecha.HeaderText = "Fecha"
    Me.cdFecha.Name = "cdFecha"
    Me.cdFecha.ReadOnly = True
    '
    'cdMotivo
    '
    Me.cdMotivo.DataPropertyName = "Motivo"
    Me.cdMotivo.HeaderText = "Motivo"
    Me.cdMotivo.Name = "cdMotivo"
    Me.cdMotivo.ReadOnly = True
    '
    'cdPension
    '
    Me.cdPension.DataPropertyName = "Monto"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdPension.DefaultCellStyle = DataGridViewCellStyle1
    Me.cdPension.HeaderText = "Pensión"
    Me.cdPension.Name = "cdPension"
    Me.cdPension.ReadOnly = True
    '
    'cdDescuento
    '
    Me.cdDescuento.DataPropertyName = "Descuento"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle2.Format = "N2"
    Me.cdDescuento.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdDescuento.HeaderText = "Descuento"
    Me.cdDescuento.Name = "cdDescuento"
    Me.cdDescuento.ReadOnly = True
    '
    'cdPadre
    '
    Me.cdPadre.DataPropertyName = "Padre"
    Me.cdPadre.HeaderText = "Padre"
    Me.cdPadre.Name = "cdPadre"
    Me.cdPadre.ReadOnly = True
    Me.cdPadre.Width = 200
    '
    'cdMadre
    '
    Me.cdMadre.DataPropertyName = "Madre"
    Me.cdMadre.HeaderText = "Madre"
    Me.cdMadre.Name = "cdMadre"
    Me.cdMadre.ReadOnly = True
    Me.cdMadre.Width = 200
    '
    'cdDirecccion
    '
    Me.cdDirecccion.DataPropertyName = "Direccion"
    Me.cdDirecccion.HeaderText = "Dirección"
    Me.cdDirecccion.Name = "cdDirecccion"
    Me.cdDirecccion.ReadOnly = True
    Me.cdDirecccion.Width = 200
    '
    'cdTelefono
    '
    Me.cdTelefono.DataPropertyName = "Telefono"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdTelefono.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdTelefono.HeaderText = "Teléfono"
    Me.cdTelefono.Name = "cdTelefono"
    Me.cdTelefono.ReadOnly = True
    Me.cdTelefono.Width = 70
    '
    'btnListar
    '
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnListar.Location = New System.Drawing.Point(629, 73)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(113, 52)
    Me.btnListar.TabIndex = 7
    Me.btnListar.Text = "&Listar"
    Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnListar.UseVisualStyleBackColor = False
    '
    'cboAnio
    '
    Me.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAnio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboAnio.FormattingEnabled = True
    Me.cboAnio.Location = New System.Drawing.Point(62, 43)
    Me.cboAnio.Name = "cboAnio"
    Me.cboAnio.Size = New System.Drawing.Size(120, 24)
    Me.cboAnio.TabIndex = 1
    '
    'lblAnioLectivo
    '
    Me.lblAnioLectivo.AutoSize = True
    Me.lblAnioLectivo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAnioLectivo.Location = New System.Drawing.Point(25, 52)
    Me.lblAnioLectivo.Name = "lblAnioLectivo"
    Me.lblAnioLectivo.Size = New System.Drawing.Size(31, 15)
    Me.lblAnioLectivo.TabIndex = 0
    Me.lblAnioLectivo.Text = "&Año"
    '
    'btnImprimir
    '
    Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnImprimir.BackColor = System.Drawing.Color.White
    Me.btnImprimir.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnImprimir.Location = New System.Drawing.Point(454, 428)
    Me.btnImprimir.Name = "btnImprimir"
    Me.btnImprimir.Size = New System.Drawing.Size(106, 52)
    Me.btnImprimir.TabIndex = 9
    Me.btnImprimir.Text = "&Imprimir"
    Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnImprimir.UseVisualStyleBackColor = False
    '
    'cboFiltro
    '
    Me.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboFiltro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboFiltro.FormattingEnabled = True
    Me.cboFiltro.Items.AddRange(New Object() {"Todos los beneficios registrados", "Los beneficios registrado entre"})
    Me.cboFiltro.Location = New System.Drawing.Point(70, 100)
    Me.cboFiltro.Name = "cboFiltro"
    Me.cboFiltro.Size = New System.Drawing.Size(269, 24)
    Me.cboFiltro.TabIndex = 3
    '
    'lblFiltro
    '
    Me.lblFiltro.AutoSize = True
    Me.lblFiltro.Location = New System.Drawing.Point(25, 111)
    Me.lblFiltro.Name = "lblFiltro"
    Me.lblFiltro.Size = New System.Drawing.Size(42, 13)
    Me.lblFiltro.TabIndex = 2
    Me.lblFiltro.Text = "&Mostrar"
    '
    'dtpInicio
    '
    Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpInicio.Location = New System.Drawing.Point(354, 105)
    Me.dtpInicio.Name = "dtpInicio"
    Me.dtpInicio.Size = New System.Drawing.Size(97, 20)
    Me.dtpInicio.TabIndex = 4
    Me.dtpInicio.Visible = False
    '
    'dtpFin
    '
    Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFin.Location = New System.Drawing.Point(476, 105)
    Me.dtpFin.Name = "dtpFin"
    Me.dtpFin.Size = New System.Drawing.Size(97, 20)
    Me.dtpFin.TabIndex = 6
    Me.dtpFin.Visible = False
    '
    'lblY
    '
    Me.lblY.AutoSize = True
    Me.lblY.Location = New System.Drawing.Point(458, 112)
    Me.lblY.Name = "lblY"
    Me.lblY.Size = New System.Drawing.Size(12, 13)
    Me.lblY.TabIndex = 5
    Me.lblY.Text = "y"
    Me.lblY.Visible = False
    '
    'frmListadoAlumnosBeneficiados
    '
    Me.AcceptButton = Me.btnListar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(804, 492)
    Me.Controls.Add(Me.lblY)
    Me.Controls.Add(Me.dtpFin)
    Me.Controls.Add(Me.dtpInicio)
    Me.Controls.Add(Me.lblFiltro)
    Me.Controls.Add(Me.btnImprimir)
    Me.Controls.Add(Me.cboFiltro)
    Me.Controls.Add(Me.cboAnio)
    Me.Controls.Add(Me.lblAnioLectivo)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.dgvConsolidadoPagos)
    Me.Controls.Add(Me.btnListar)
    Me.Name = "frmListadoAlumnosBeneficiados"
    Me.Text = "Listado de alumnos beneficiados"
    CType(Me.dgvConsolidadoPagos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents dgvConsolidadoPagos As System.Windows.Forms.DataGridView
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
  Friend WithEvents lblAnioLectivo As System.Windows.Forms.Label
  Friend WithEvents btnImprimir As System.Windows.Forms.Button
  Friend WithEvents cbSeccion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdFecha As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdMotivo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdPension As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDescuento As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdPadre As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdMadre As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDirecccion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdTelefono As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cboFiltro As System.Windows.Forms.ComboBox
  Friend WithEvents lblFiltro As System.Windows.Forms.Label
  Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
  Friend WithEvents lblY As System.Windows.Forms.Label
End Class
