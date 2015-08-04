<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarServicio
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
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.dgvServicio = New System.Windows.Forms.DataGridView
    Me.lblServicio = New System.Windows.Forms.Label
    Me.txtnombre = New System.Windows.Forms.TextBox
    Me.btnSeleccionar = New System.Windows.Forms.Button
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnBuscar = New System.Windows.Forms.Button
    Me.lblEntidad = New System.Windows.Forms.Label
    Me.cdSeleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn
    Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.colImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdNivel = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.dgvServicio, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'dgvServicio
    '
    Me.dgvServicio.AllowUserToAddRows = False
    Me.dgvServicio.AllowUserToDeleteRows = False
    Me.dgvServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdSeleccionar, Me.colNombre, Me.colImporte, Me.cdNivel})
    Me.dgvServicio.Location = New System.Drawing.Point(12, 87)
    Me.dgvServicio.MultiSelect = False
    Me.dgvServicio.Name = "dgvServicio"
    Me.dgvServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.dgvServicio.Size = New System.Drawing.Size(607, 370)
    Me.dgvServicio.TabIndex = 1
    '
    'lblServicio
    '
    Me.lblServicio.AutoSize = True
    Me.lblServicio.Location = New System.Drawing.Point(9, 56)
    Me.lblServicio.Name = "lblServicio"
    Me.lblServicio.Size = New System.Drawing.Size(45, 13)
    Me.lblServicio.TabIndex = 9
    Me.lblServicio.Text = "Ser&vicio"
    '
    'txtnombre
    '
    Me.txtnombre.Location = New System.Drawing.Point(68, 49)
    Me.txtnombre.Name = "txtnombre"
    Me.txtnombre.Size = New System.Drawing.Size(470, 20)
    Me.txtnombre.TabIndex = 0
    '
    'btnSeleccionar
    '
    Me.btnSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.btnSeleccionar.BackColor = System.Drawing.Color.White
    Me.btnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnSeleccionar.Location = New System.Drawing.Point(391, 463)
    Me.btnSeleccionar.Name = "btnSeleccionar"
    Me.btnSeleccionar.Size = New System.Drawing.Size(111, 44)
    Me.btnSeleccionar.TabIndex = 11
    Me.btnSeleccionar.Text = "&Seleccionar"
    Me.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnSeleccionar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(508, 463)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(111, 44)
    Me.btnCancelar.TabIndex = 12
    Me.btnCancelar.Text = "&Cancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnBuscar
    '
    Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnBuscar.BackColor = System.Drawing.Color.White
    Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
    Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscar.Location = New System.Drawing.Point(544, 41)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(75, 28)
    Me.btnBuscar.TabIndex = 10
    Me.btnBuscar.Text = "&Buscar"
    Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscar.UseVisualStyleBackColor = False
    '
    'lblEntidad
    '
    Me.lblEntidad.AutoSize = True
    Me.lblEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblEntidad.Location = New System.Drawing.Point(12, 17)
    Me.lblEntidad.Name = "lblEntidad"
    Me.lblEntidad.Size = New System.Drawing.Size(64, 18)
    Me.lblEntidad.TabIndex = 13
    Me.lblEntidad.Text = "Entidad"
    '
    'cdSeleccionar
    '
    Me.cdSeleccionar.DataPropertyName = "Seleccionado"
    Me.cdSeleccionar.HeaderText = "Selec."
    Me.cdSeleccionar.Name = "cdSeleccionar"
    Me.cdSeleccionar.Width = 70
    '
    'colNombre
    '
    Me.colNombre.DataPropertyName = "Nombre"
    Me.colNombre.HeaderText = "Nombre"
    Me.colNombre.Name = "colNombre"
    Me.colNombre.ReadOnly = True
    Me.colNombre.Width = 160
    '
    'colImporte
    '
    Me.colImporte.DataPropertyName = "monto"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle2.Format = "N2"
    DataGridViewCellStyle2.NullValue = Nothing
    Me.colImporte.DefaultCellStyle = DataGridViewCellStyle2
    Me.colImporte.HeaderText = "Importe"
    Me.colImporte.Name = "colImporte"
    Me.colImporte.ReadOnly = True
    '
    'cdNivel
    '
    Me.cdNivel.DataPropertyName = "NombreNivel"
    Me.cdNivel.HeaderText = "Nivel"
    Me.cdNivel.Name = "cdNivel"
    Me.cdNivel.ReadOnly = True
    '
    'frmBuscarServicio
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCancelar
    Me.ClientSize = New System.Drawing.Size(631, 519)
    Me.Controls.Add(Me.lblEntidad)
    Me.Controls.Add(Me.btnSeleccionar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnBuscar)
    Me.Controls.Add(Me.txtnombre)
    Me.Controls.Add(Me.lblServicio)
    Me.Controls.Add(Me.dgvServicio)
    Me.KeyPreview = True
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmBuscarServicio"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Buscar Servicio"
    CType(Me.dgvServicio, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents dgvServicio As System.Windows.Forms.DataGridView
  Friend WithEvents lblServicio As System.Windows.Forms.Label
  Friend WithEvents txtnombre As System.Windows.Forms.TextBox
  Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
  Friend WithEvents lblEntidad As System.Windows.Forms.Label
  Friend WithEvents cdSeleccionar As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colImporte As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdNivel As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
