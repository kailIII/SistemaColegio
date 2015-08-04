<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscaPersona
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
    Me.dgvgrupo = New System.Windows.Forms.DataGridView
    Me.cdPersona = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnBuscar = New System.Windows.Forms.Button
    Me.txtnombre = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    CType(Me.dgvgrupo, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'dgvgrupo
    '
    Me.dgvgrupo.AllowUserToAddRows = False
    Me.dgvgrupo.AllowUserToDeleteRows = False
    Me.dgvgrupo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvgrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvgrupo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdPersona})
    Me.dgvgrupo.Location = New System.Drawing.Point(13, 40)
    Me.dgvgrupo.Name = "dgvgrupo"
    Me.dgvgrupo.ReadOnly = True
    Me.dgvgrupo.Size = New System.Drawing.Size(307, 187)
    Me.dgvgrupo.TabIndex = 7
    '
    'cdPersona
    '
    Me.cdPersona.DataPropertyName = "NombreCompleto"
    Me.cdPersona.HeaderText = "Persona"
    Me.cdPersona.Name = "cdPersona"
    Me.cdPersona.ReadOnly = True
    Me.cdPersona.Width = 263
    '
    'btnBuscar
    '
    Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnBuscar.Location = New System.Drawing.Point(245, 11)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
    Me.btnBuscar.TabIndex = 6
    Me.btnBuscar.Text = "Buscar"
    Me.btnBuscar.UseVisualStyleBackColor = True
    '
    'txtnombre
    '
    Me.txtnombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtnombre.Location = New System.Drawing.Point(53, 13)
    Me.txtnombre.Name = "txtnombre"
    Me.txtnombre.Size = New System.Drawing.Size(186, 20)
    Me.txtnombre.TabIndex = 5
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(10, 20)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(44, 13)
    Me.Label1.TabIndex = 4
    Me.Label1.Text = "Nombre"
    '
    'BuscaPersona
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.dgvgrupo)
    Me.Controls.Add(Me.btnBuscar)
    Me.Controls.Add(Me.txtnombre)
    Me.Controls.Add(Me.Label1)
    Me.Name = "BuscaPersona"
    Me.Size = New System.Drawing.Size(332, 238)
    CType(Me.dgvgrupo, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents dgvgrupo As System.Windows.Forms.DataGridView
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cdPersona As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
