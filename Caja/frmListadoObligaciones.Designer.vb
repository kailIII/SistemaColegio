<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoObligaciones
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
    Me.DataGridView1 = New System.Windows.Forms.DataGridView
    Me.colItem = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.colObligacion = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.colfecha = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.colImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.TextBox3 = New System.Windows.Forms.TextBox
    Me.TextBox2 = New System.Windows.Forms.TextBox
    Me.TextBox1 = New System.Windows.Forms.TextBox
    Me.Button1 = New System.Windows.Forms.Button
    Me.Button2 = New System.Windows.Forms.Button
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'DataGridView1
    '
    Me.DataGridView1.AllowUserToAddRows = False
    Me.DataGridView1.AllowUserToDeleteRows = False
    Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colItem, Me.colObligacion, Me.colfecha, Me.colImporte})
    Me.DataGridView1.Location = New System.Drawing.Point(12, 123)
    Me.DataGridView1.Name = "DataGridView1"
    Me.DataGridView1.ReadOnly = True
    Me.DataGridView1.Size = New System.Drawing.Size(518, 290)
    Me.DataGridView1.TabIndex = 0
    '
    'colItem
    '
    Me.colItem.HeaderText = "Item"
    Me.colItem.Name = "colItem"
    Me.colItem.ReadOnly = True
    Me.colItem.Width = 80
    '
    'colObligacion
    '
    Me.colObligacion.HeaderText = "Obligacion"
    Me.colObligacion.Name = "colObligacion"
    Me.colObligacion.ReadOnly = True
    Me.colObligacion.Width = 170
    '
    'colfecha
    '
    Me.colfecha.HeaderText = "Fecha Vcto"
    Me.colfecha.Name = "colfecha"
    Me.colfecha.ReadOnly = True
    Me.colfecha.Width = 120
    '
    'colImporte
    '
    Me.colImporte.HeaderText = "Importe"
    Me.colImporte.Name = "colImporte"
    Me.colImporte.ReadOnly = True
    Me.colImporte.Width = 120
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.Label3)
    Me.GroupBox1.Controls.Add(Me.Label2)
    Me.GroupBox1.Controls.Add(Me.Label1)
    Me.GroupBox1.Controls.Add(Me.TextBox3)
    Me.GroupBox1.Controls.Add(Me.TextBox2)
    Me.GroupBox1.Controls.Add(Me.TextBox1)
    Me.GroupBox1.Controls.Add(Me.Button1)
    Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(518, 87)
    Me.GroupBox1.TabIndex = 8
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Alumno"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(210, 58)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(115, 13)
    Me.Label3.TabIndex = 13
    Me.Label3.Text = "Nivel/Grado/Seccion :"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(9, 58)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(46, 13)
    Me.Label2.TabIndex = 12
    Me.Label2.Text = "Codigo :"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(9, 24)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(50, 13)
    Me.Label1.TabIndex = 11
    Me.Label1.Text = "Nombre :"
    '
    'TextBox3
    '
    Me.TextBox3.Location = New System.Drawing.Point(331, 55)
    Me.TextBox3.Name = "TextBox3"
    Me.TextBox3.Size = New System.Drawing.Size(75, 20)
    Me.TextBox3.TabIndex = 10
    '
    'TextBox2
    '
    Me.TextBox2.Location = New System.Drawing.Point(65, 55)
    Me.TextBox2.Name = "TextBox2"
    Me.TextBox2.Size = New System.Drawing.Size(121, 20)
    Me.TextBox2.TabIndex = 9
    '
    'TextBox1
    '
    Me.TextBox1.Location = New System.Drawing.Point(65, 19)
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.Size = New System.Drawing.Size(341, 20)
    Me.TextBox1.TabIndex = 8
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(437, 19)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(75, 23)
    Me.Button1.TabIndex = 7
    Me.Button1.Text = "Buscar"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'Button2
    '
    Me.Button2.Location = New System.Drawing.Point(240, 432)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(75, 23)
    Me.Button2.TabIndex = 9
    Me.Button2.Text = "Cerrar"
    Me.Button2.UseVisualStyleBackColor = True
    '
    'frmListadoObligaciones
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(552, 474)
    Me.Controls.Add(Me.Button2)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.DataGridView1)
    Me.Name = "frmListadoObligaciones"
    Me.Text = "Obligaciones en el Año"
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
  Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
  Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents colItem As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colObligacion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colfecha As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colImporte As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
