<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsociarPago
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
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.lblCodigo = New System.Windows.Forms.Label
    Me.txtCodigo = New System.Windows.Forms.TextBox
    Me.lblSeccion = New System.Windows.Forms.Label
    Me.lblAlumno = New System.Windows.Forms.Label
    Me.txtSeccion = New System.Windows.Forms.TextBox
    Me.txtNombre = New System.Windows.Forms.TextBox
    Me.dgvPendientes = New System.Windows.Forms.DataGridView
    Me.cdDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdMonto = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnAceptar = New System.Windows.Forms.Button
    Me.btnCancelar = New System.Windows.Forms.Button
    CType(Me.dgvPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblCodigo
    '
    Me.lblCodigo.AutoSize = True
    Me.lblCodigo.Location = New System.Drawing.Point(348, 66)
    Me.lblCodigo.Name = "lblCodigo"
    Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
    Me.lblCodigo.TabIndex = 4
    Me.lblCodigo.Text = "Có&digo"
    '
    'txtCodigo
    '
    Me.txtCodigo.BackColor = System.Drawing.SystemColors.Window
    Me.txtCodigo.Location = New System.Drawing.Point(399, 59)
    Me.txtCodigo.Name = "txtCodigo"
    Me.txtCodigo.Size = New System.Drawing.Size(125, 20)
    Me.txtCodigo.TabIndex = 5
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Location = New System.Drawing.Point(13, 66)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(46, 13)
    Me.lblSeccion.TabIndex = 2
    Me.lblSeccion.Text = "Sección"
    '
    'lblAlumno
    '
    Me.lblAlumno.AutoSize = True
    Me.lblAlumno.Location = New System.Drawing.Point(13, 34)
    Me.lblAlumno.Name = "lblAlumno"
    Me.lblAlumno.Size = New System.Drawing.Size(42, 13)
    Me.lblAlumno.TabIndex = 0
    Me.lblAlumno.Text = "Alumno"
    '
    'txtSeccion
    '
    Me.txtSeccion.BackColor = System.Drawing.SystemColors.Window
    Me.txtSeccion.Location = New System.Drawing.Point(64, 59)
    Me.txtSeccion.Name = "txtSeccion"
    Me.txtSeccion.ReadOnly = True
    Me.txtSeccion.Size = New System.Drawing.Size(205, 20)
    Me.txtSeccion.TabIndex = 3
    '
    'txtNombre
    '
    Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
    Me.txtNombre.Location = New System.Drawing.Point(64, 27)
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.ReadOnly = True
    Me.txtNombre.Size = New System.Drawing.Size(460, 20)
    Me.txtNombre.TabIndex = 1
    '
    'dgvPendientes
    '
    Me.dgvPendientes.AllowUserToAddRows = False
    Me.dgvPendientes.AllowUserToDeleteRows = False
    Me.dgvPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvPendientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdDescripcion, Me.cdMonto})
    Me.dgvPendientes.Location = New System.Drawing.Point(16, 96)
    Me.dgvPendientes.MultiSelect = False
    Me.dgvPendientes.Name = "dgvPendientes"
    Me.dgvPendientes.ReadOnly = True
    Me.dgvPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvPendientes.Size = New System.Drawing.Size(537, 334)
    Me.dgvPendientes.TabIndex = 6
    '
    'cdDescripcion
    '
    Me.cdDescripcion.DataPropertyName = "Descripcion"
    Me.cdDescripcion.HeaderText = "Descripción"
    Me.cdDescripcion.Name = "cdDescripcion"
    Me.cdDescripcion.ReadOnly = True
    Me.cdDescripcion.Width = 250
    '
    'cdMonto
    '
    Me.cdMonto.DataPropertyName = "Monto"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle2.Format = "N2"
    DataGridViewCellStyle2.NullValue = Nothing
    Me.cdMonto.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdMonto.HeaderText = "Monto"
    Me.cdMonto.Name = "cdMonto"
    Me.cdMonto.ReadOnly = True
    '
    'btnAceptar
    '
    Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnAceptar.BackColor = System.Drawing.Color.White
    Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnAceptar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAceptar.Location = New System.Drawing.Point(287, 442)
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(130, 52)
    Me.btnAceptar.TabIndex = 7
    Me.btnAceptar.Text = "&Aceptar"
    Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnAceptar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(423, 442)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(130, 52)
    Me.btnCancelar.TabIndex = 8
    Me.btnCancelar.Text = "&Cancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'frmAsociarPago
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCancelar
    Me.ClientSize = New System.Drawing.Size(565, 499)
    Me.Controls.Add(Me.btnAceptar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.dgvPendientes)
    Me.Controls.Add(Me.lblCodigo)
    Me.Controls.Add(Me.txtCodigo)
    Me.Controls.Add(Me.lblSeccion)
    Me.Controls.Add(Me.lblAlumno)
    Me.Controls.Add(Me.txtSeccion)
    Me.Controls.Add(Me.txtNombre)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmAsociarPago"
    Me.Text = "Asociar pago realizado"
    CType(Me.dgvPendientes, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblCodigo As System.Windows.Forms.Label
  Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents lblAlumno As System.Windows.Forms.Label
  Friend WithEvents txtSeccion As System.Windows.Forms.TextBox
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents dgvPendientes As System.Windows.Forms.DataGridView
  Friend WithEvents btnAceptar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents cdDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdMonto As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
