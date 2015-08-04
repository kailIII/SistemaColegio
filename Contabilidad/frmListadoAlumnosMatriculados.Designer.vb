<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoAlumnosMatriculados
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
    Me.cbSeccion = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCondicion = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnListar = New System.Windows.Forms.Button
    Me.cboAnio = New System.Windows.Forms.ComboBox
    Me.lblAnioLectivo = New System.Windows.Forms.Label
    CType(Me.dgvConsolidadoPagos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnExportar
    '
    Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnExportar.BackColor = System.Drawing.Color.White
    Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnExportar.Location = New System.Drawing.Point(434, 428)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(110, 52)
    Me.btnExportar.TabIndex = 4
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
    Me.btnCerrar.Location = New System.Drawing.Point(559, 428)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 5
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
    Me.dgvConsolidadoPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cbSeccion, Me.cdAlumno, Me.cdCodigo, Me.cdCondicion})
    Me.dgvConsolidadoPagos.Location = New System.Drawing.Point(23, 86)
    Me.dgvConsolidadoPagos.MultiSelect = False
    Me.dgvConsolidadoPagos.Name = "dgvConsolidadoPagos"
    Me.dgvConsolidadoPagos.ReadOnly = True
    Me.dgvConsolidadoPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvConsolidadoPagos.Size = New System.Drawing.Size(646, 336)
    Me.dgvConsolidadoPagos.TabIndex = 3
    '
    'cbSeccion
    '
    Me.cbSeccion.DataPropertyName = "Seccion"
    Me.cbSeccion.HeaderText = "Sección"
    Me.cbSeccion.Name = "cbSeccion"
    Me.cbSeccion.ReadOnly = True
    '
    'cdAlumno
    '
    Me.cdAlumno.DataPropertyName = "Alumno"
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.ReadOnly = True
    Me.cdAlumno.Width = 200
    '
    'cdCodigo
    '
    Me.cdCodigo.DataPropertyName = "CodigoRecaudacion"
    Me.cdCodigo.HeaderText = "Código"
    Me.cdCodigo.Name = "cdCodigo"
    Me.cdCodigo.ReadOnly = True
    '
    'cdCondicion
    '
    Me.cdCondicion.DataPropertyName = "Condicion"
    Me.cdCondicion.HeaderText = "Condición"
    Me.cdCondicion.Name = "cdCondicion"
    Me.cdCondicion.ReadOnly = True
    '
    'btnListar
    '
    Me.btnListar.Location = New System.Drawing.Point(235, 28)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(113, 52)
    Me.btnListar.TabIndex = 2
    Me.btnListar.Text = "&Listar"
    Me.btnListar.UseVisualStyleBackColor = True
    '
    'cboAnio
    '
    Me.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAnio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboAnio.FormattingEnabled = True
    Me.cboAnio.Location = New System.Drawing.Point(62, 56)
    Me.cboAnio.Name = "cboAnio"
    Me.cboAnio.Size = New System.Drawing.Size(120, 24)
    Me.cboAnio.TabIndex = 1
    '
    'lblAnioLectivo
    '
    Me.lblAnioLectivo.AutoSize = True
    Me.lblAnioLectivo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAnioLectivo.Location = New System.Drawing.Point(25, 65)
    Me.lblAnioLectivo.Name = "lblAnioLectivo"
    Me.lblAnioLectivo.Size = New System.Drawing.Size(31, 15)
    Me.lblAnioLectivo.TabIndex = 0
    Me.lblAnioLectivo.Text = "&Año"
    '
    'frmListadoAlumnosMatriculados
    '
    Me.AcceptButton = Me.btnListar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(681, 492)
    Me.Controls.Add(Me.cboAnio)
    Me.Controls.Add(Me.lblAnioLectivo)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.dgvConsolidadoPagos)
    Me.Controls.Add(Me.btnListar)
    Me.Name = "frmListadoAlumnosMatriculados"
    Me.Text = "Listado de alumnos matriculados"
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
  Friend WithEvents cbSeccion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCondicion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
