<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarApoderado
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
    Me.btnBuscar = New System.Windows.Forms.Button
    Me.dgvApoderado = New System.Windows.Forms.DataGridView
    Me.cdNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.GBApoderado = New System.Windows.Forms.GroupBox
    Me.txtNombreBuscar = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.lblNombreBuscar = New System.Windows.Forms.Label
    CType(Me.dgvApoderado, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GBApoderado.SuspendLayout()
    Me.SuspendLayout()
    '
    'btnBuscar
    '
    Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnBuscar.BackColor = System.Drawing.Color.White
    Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscar.Location = New System.Drawing.Point(459, 15)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(78, 37)
    Me.btnBuscar.TabIndex = 6
    Me.btnBuscar.Text = "Buscar"
    Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscar.UseVisualStyleBackColor = False
    '
    'dgvApoderado
    '
    Me.dgvApoderado.AllowUserToAddRows = False
    Me.dgvApoderado.AllowUserToDeleteRows = False
    Me.dgvApoderado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvApoderado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvApoderado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNombre})
    Me.dgvApoderado.Location = New System.Drawing.Point(3, 77)
    Me.dgvApoderado.MultiSelect = False
    Me.dgvApoderado.Name = "dgvApoderado"
    Me.dgvApoderado.ReadOnly = True
    Me.dgvApoderado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvApoderado.Size = New System.Drawing.Size(544, 395)
    Me.dgvApoderado.TabIndex = 7
    '
    'cdNombre
    '
    Me.cdNombre.DataPropertyName = "NombreCompleto"
    Me.cdNombre.HeaderText = "Apoderado"
    Me.cdNombre.Name = "cdNombre"
    Me.cdNombre.ReadOnly = True
    Me.cdNombre.Width = 400
    '
    'GBApoderado
    '
    Me.GBApoderado.Controls.Add(Me.txtNombreBuscar)
    Me.GBApoderado.Controls.Add(Me.Label1)
    Me.GBApoderado.Controls.Add(Me.lblNombreBuscar)
    Me.GBApoderado.Location = New System.Drawing.Point(3, 3)
    Me.GBApoderado.Name = "GBApoderado"
    Me.GBApoderado.Size = New System.Drawing.Size(450, 68)
    Me.GBApoderado.TabIndex = 13
    Me.GBApoderado.TabStop = False
    Me.GBApoderado.Text = "Padres/Apoderado"
    '
    'txtNombreBuscar
    '
    Me.txtNombreBuscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNombreBuscar.Location = New System.Drawing.Point(68, 19)
    Me.txtNombreBuscar.Multiline = True
    Me.txtNombreBuscar.Name = "txtNombreBuscar"
    Me.txtNombreBuscar.Size = New System.Drawing.Size(375, 24)
    Me.txtNombreBuscar.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
    Me.Label1.Location = New System.Drawing.Point(65, 46)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(248, 14)
    Me.Label1.TabIndex = 11
    Me.Label1.Text = "Orden:  ApePaterno    ApeMaterno   Nombre"
    '
    'lblNombreBuscar
    '
    Me.lblNombreBuscar.AutoSize = True
    Me.lblNombreBuscar.BackColor = System.Drawing.Color.Transparent
    Me.lblNombreBuscar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNombreBuscar.Location = New System.Drawing.Point(17, 23)
    Me.lblNombreBuscar.Name = "lblNombreBuscar"
    Me.lblNombreBuscar.Size = New System.Drawing.Size(52, 15)
    Me.lblNombreBuscar.TabIndex = 0
    Me.lblNombreBuscar.Text = "N&ombre:"
    '
    'BuscarApoderado
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.GBApoderado)
    Me.Controls.Add(Me.btnBuscar)
    Me.Controls.Add(Me.dgvApoderado)
    Me.Name = "BuscarApoderado"
    Me.Size = New System.Drawing.Size(549, 472)
    CType(Me.dgvApoderado, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GBApoderado.ResumeLayout(False)
    Me.GBApoderado.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents dgvApoderado As System.Windows.Forms.DataGridView
  Friend WithEvents GBApoderado As System.Windows.Forms.GroupBox
  Friend WithEvents txtNombreBuscar As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents lblNombreBuscar As System.Windows.Forms.Label
  Friend WithEvents cdNombre As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
