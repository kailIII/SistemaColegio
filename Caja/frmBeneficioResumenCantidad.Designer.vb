<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBeneficioResumenCantidad
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.cboAnio = New System.Windows.Forms.ComboBox
    Me.lblAnioLectivo = New System.Windows.Forms.Label
    Me.btnListar = New System.Windows.Forms.Button
    Me.dgvResumenBeneficios = New System.Windows.Forms.DataGridView
    Me.cdBeneficio = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdNivel = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnExportar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    CType(Me.dgvResumenBeneficios, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cboAnio
    '
    Me.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAnio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboAnio.FormattingEnabled = True
    Me.cboAnio.Location = New System.Drawing.Point(60, 53)
    Me.cboAnio.Name = "cboAnio"
    Me.cboAnio.Size = New System.Drawing.Size(120, 24)
    Me.cboAnio.TabIndex = 1
    '
    'lblAnioLectivo
    '
    Me.lblAnioLectivo.AutoSize = True
    Me.lblAnioLectivo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAnioLectivo.Location = New System.Drawing.Point(23, 62)
    Me.lblAnioLectivo.Name = "lblAnioLectivo"
    Me.lblAnioLectivo.Size = New System.Drawing.Size(31, 15)
    Me.lblAnioLectivo.TabIndex = 0
    Me.lblAnioLectivo.Text = "&Año"
    '
    'btnListar
    '
    Me.btnListar.Location = New System.Drawing.Point(201, 25)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(110, 52)
    Me.btnListar.TabIndex = 2
    Me.btnListar.Text = "&Listar"
    Me.btnListar.UseVisualStyleBackColor = True
    '
    'dgvResumenBeneficios
    '
    Me.dgvResumenBeneficios.AllowUserToAddRows = False
    Me.dgvResumenBeneficios.AllowUserToDeleteRows = False
    Me.dgvResumenBeneficios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvResumenBeneficios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvResumenBeneficios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdBeneficio, Me.cdDescuento, Me.cdNivel, Me.cdCantidad})
    Me.dgvResumenBeneficios.Location = New System.Drawing.Point(27, 92)
    Me.dgvResumenBeneficios.MultiSelect = False
    Me.dgvResumenBeneficios.Name = "dgvResumenBeneficios"
    Me.dgvResumenBeneficios.ReadOnly = True
    Me.dgvResumenBeneficios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvResumenBeneficios.Size = New System.Drawing.Size(739, 299)
    Me.dgvResumenBeneficios.TabIndex = 3
    '
    'cdBeneficio
    '
    Me.cdBeneficio.DataPropertyName = "Motivo"
    Me.cdBeneficio.HeaderText = "Beneficio"
    Me.cdBeneficio.Name = "cdBeneficio"
    Me.cdBeneficio.ReadOnly = True
    Me.cdBeneficio.Width = 150
    '
    'cdDescuento
    '
    Me.cdDescuento.DataPropertyName = "Descuento"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle1.Format = "N2"
    Me.cdDescuento.DefaultCellStyle = DataGridViewCellStyle1
    Me.cdDescuento.HeaderText = "Descuento"
    Me.cdDescuento.Name = "cdDescuento"
    Me.cdDescuento.ReadOnly = True
    '
    'cdNivel
    '
    Me.cdNivel.DataPropertyName = "NombreNivel"
    Me.cdNivel.HeaderText = "Nivel"
    Me.cdNivel.Name = "cdNivel"
    Me.cdNivel.ReadOnly = True
    Me.cdNivel.Width = 110
    '
    'cdCantidad
    '
    Me.cdCantidad.DataPropertyName = "Cantidad"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdCantidad.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdCantidad.HeaderText = "Cantidad"
    Me.cdCantidad.Name = "cdCantidad"
    Me.cdCantidad.ReadOnly = True
    Me.cdCantidad.Width = 80
    '
    'btnExportar
    '
    Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnExportar.BackColor = System.Drawing.Color.White
    Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnExportar.Location = New System.Drawing.Point(522, 397)
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
    Me.btnCerrar.Location = New System.Drawing.Point(656, 397)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 5
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'frmBeneficioResumenCantidad
    '
    Me.AcceptButton = Me.btnListar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(794, 461)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.dgvResumenBeneficios)
    Me.Controls.Add(Me.btnListar)
    Me.Controls.Add(Me.cboAnio)
    Me.Controls.Add(Me.lblAnioLectivo)
    Me.Name = "frmBeneficioResumenCantidad"
    Me.Text = "Resumen de beneficios"
    CType(Me.dgvResumenBeneficios, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
  Friend WithEvents lblAnioLectivo As System.Windows.Forms.Label
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents dgvResumenBeneficios As System.Windows.Forms.DataGridView
  Friend WithEvents cdBeneficio As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDescuento As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdNivel As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
End Class
