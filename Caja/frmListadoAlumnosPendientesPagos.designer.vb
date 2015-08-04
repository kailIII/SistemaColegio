<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoAlumnosPendientesPago
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
    Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.dgvDocumentos = New System.Windows.Forms.DataGridView()
    Me.cdCodigoAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdSeccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Persona = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdMontoAsignado = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdMontoPagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.btnExportar = New System.Windows.Forms.Button()
    Me.btnBuscar = New System.Windows.Forms.Button()
    Me.btnImprimir = New System.Windows.Forms.Button()
    Me.cboServicio = New System.Windows.Forms.ComboBox()
    Me.lblServicio = New System.Windows.Forms.Label()
    Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
    Me.lblFechaVoucher = New System.Windows.Forms.Label()
    Me.cboAnio = New System.Windows.Forms.ComboBox()
    Me.lblAnio = New System.Windows.Forms.Label()
    CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'dgvDocumentos
    '
    Me.dgvDocumentos.AllowUserToAddRows = False
    Me.dgvDocumentos.AllowUserToDeleteRows = False
    Me.dgvDocumentos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvDocumentos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdCodigoAlumno, Me.cdSeccion, Me.Persona, Me.cdMontoAsignado, Me.cdMontoPagado, Me.cdSaldo})
    Me.dgvDocumentos.Location = New System.Drawing.Point(17, 121)
    Me.dgvDocumentos.Name = "dgvDocumentos"
    Me.dgvDocumentos.ReadOnly = True
    Me.dgvDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvDocumentos.Size = New System.Drawing.Size(811, 395)
    Me.dgvDocumentos.TabIndex = 5
    '
    'cdCodigoAlumno
    '
    Me.cdCodigoAlumno.DataPropertyName = "CodigoRecaudacion"
    Me.cdCodigoAlumno.HeaderText = "Código"
    Me.cdCodigoAlumno.Name = "cdCodigoAlumno"
    Me.cdCodigoAlumno.ReadOnly = True
    Me.cdCodigoAlumno.Width = 80
    '
    'cdSeccion
    '
    Me.cdSeccion.DataPropertyName = "Seccion"
    Me.cdSeccion.HeaderText = "Sección"
    Me.cdSeccion.Name = "cdSeccion"
    Me.cdSeccion.ReadOnly = True
    '
    'Persona
    '
    Me.Persona.DataPropertyName = "Alumno"
    Me.Persona.HeaderText = "Alumno"
    Me.Persona.Name = "Persona"
    Me.Persona.ReadOnly = True
    Me.Persona.Width = 200
    '
    'cdMontoAsignado
    '
    Me.cdMontoAsignado.DataPropertyName = "MontoAsignado"
    DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle10.Format = "N2"
    DataGridViewCellStyle10.NullValue = Nothing
    Me.cdMontoAsignado.DefaultCellStyle = DataGridViewCellStyle10
    Me.cdMontoAsignado.HeaderText = "Monto asignado"
    Me.cdMontoAsignado.Name = "cdMontoAsignado"
    Me.cdMontoAsignado.ReadOnly = True
    Me.cdMontoAsignado.Width = 80
    '
    'cdMontoPagado
    '
    Me.cdMontoPagado.DataPropertyName = "MontoPagado"
    DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle11.Format = "N2"
    Me.cdMontoPagado.DefaultCellStyle = DataGridViewCellStyle11
    Me.cdMontoPagado.HeaderText = "Monto pagado"
    Me.cdMontoPagado.Name = "cdMontoPagado"
    Me.cdMontoPagado.ReadOnly = True
    Me.cdMontoPagado.Width = 80
    '
    'cdSaldo
    '
    Me.cdSaldo.DataPropertyName = "Saldo"
    DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle12.Format = "N2"
    Me.cdSaldo.DefaultCellStyle = DataGridViewCellStyle12
    Me.cdSaldo.HeaderText = "Saldo"
    Me.cdSaldo.Name = "cdSaldo"
    Me.cdSaldo.ReadOnly = True
    Me.cdSaldo.Width = 80
    '
    'btnCancelar
    '
    Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(722, 533)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(106, 52)
    Me.btnCancelar.TabIndex = 8
    Me.btnCancelar.Text = "&Cerrar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnExportar
    '
    Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnExportar.BackColor = System.Drawing.Color.White
    Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnExportar.Location = New System.Drawing.Point(609, 533)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(106, 52)
    Me.btnExportar.TabIndex = 7
    Me.btnExportar.Text = "&Exportar"
    Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnExportar.UseVisualStyleBackColor = False
    '
    'btnBuscar
    '
    Me.btnBuscar.BackColor = System.Drawing.Color.White
    Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscar.Location = New System.Drawing.Point(575, 46)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(110, 52)
    Me.btnBuscar.TabIndex = 4
    Me.btnBuscar.Text = "&Buscar"
    Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscar.UseVisualStyleBackColor = False
    '
    'btnImprimir
    '
    Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnImprimir.BackColor = System.Drawing.Color.White
    Me.btnImprimir.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnImprimir.Location = New System.Drawing.Point(497, 533)
    Me.btnImprimir.Name = "btnImprimir"
    Me.btnImprimir.Size = New System.Drawing.Size(106, 52)
    Me.btnImprimir.TabIndex = 6
    Me.btnImprimir.Text = "&Imprimir"
    Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnImprimir.UseVisualStyleBackColor = False
    '
    'cboServicio
    '
    Me.cboServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboServicio.FormattingEnabled = True
    Me.cboServicio.Location = New System.Drawing.Point(77, 77)
    Me.cboServicio.Name = "cboServicio"
    Me.cboServicio.Size = New System.Drawing.Size(417, 21)
    Me.cboServicio.TabIndex = 1
    '
    'lblServicio
    '
    Me.lblServicio.AutoSize = True
    Me.lblServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblServicio.Location = New System.Drawing.Point(14, 82)
    Me.lblServicio.Name = "lblServicio"
    Me.lblServicio.Size = New System.Drawing.Size(57, 16)
    Me.lblServicio.TabIndex = 0
    Me.lblServicio.Text = "&Servicio"
    '
    'dtpFecha
    '
    Me.dtpFecha.CustomFormat = "dd/MM/yyyy hh:mm tt"
    Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFecha.Location = New System.Drawing.Point(394, 36)
    Me.dtpFecha.Name = "dtpFecha"
    Me.dtpFecha.Size = New System.Drawing.Size(100, 22)
    Me.dtpFecha.TabIndex = 3
    Me.dtpFecha.Visible = False
    '
    'lblFechaVoucher
    '
    Me.lblFechaVoucher.AutoSize = True
    Me.lblFechaVoucher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFechaVoucher.Location = New System.Drawing.Point(331, 41)
    Me.lblFechaVoucher.Name = "lblFechaVoucher"
    Me.lblFechaVoucher.Size = New System.Drawing.Size(46, 16)
    Me.lblFechaVoucher.TabIndex = 2
    Me.lblFechaVoucher.Text = "&Fecha"
    Me.lblFechaVoucher.Visible = False
    '
    'cboAnio
    '
    Me.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAnio.FormattingEnabled = True
    Me.cboAnio.Location = New System.Drawing.Point(77, 37)
    Me.cboAnio.Name = "cboAnio"
    Me.cboAnio.Size = New System.Drawing.Size(107, 21)
    Me.cboAnio.TabIndex = 10
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblAnio.Location = New System.Drawing.Point(14, 41)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(33, 17)
    Me.lblAnio.TabIndex = 9
    Me.lblAnio.Text = "&Año"
    '
    'frmListadoAlumnosPendientesPago
    '
    Me.AcceptButton = Me.btnBuscar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(850, 597)
    Me.Controls.Add(Me.cboAnio)
    Me.Controls.Add(Me.lblAnio)
    Me.Controls.Add(Me.cboServicio)
    Me.Controls.Add(Me.lblServicio)
    Me.Controls.Add(Me.dtpFecha)
    Me.Controls.Add(Me.lblFechaVoucher)
    Me.Controls.Add(Me.btnBuscar)
    Me.Controls.Add(Me.btnImprimir)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.dgvDocumentos)
    Me.Name = "frmListadoAlumnosPendientesPago"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Listado de alumnos pendientes de pago"
    CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents dgvDocumentos As System.Windows.Forms.DataGridView
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
  Friend WithEvents btnImprimir As System.Windows.Forms.Button
  Friend WithEvents cboServicio As System.Windows.Forms.ComboBox
  Friend WithEvents lblServicio As System.Windows.Forms.Label
  Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
  Friend WithEvents lblFechaVoucher As System.Windows.Forms.Label
  Friend WithEvents cdCodigoAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdSeccion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Persona As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdMontoAsignado As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdMontoPagado As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
  Friend WithEvents lblAnio As System.Windows.Forms.Label
End Class
