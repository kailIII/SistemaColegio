<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarAlumno
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListarAlumno))
    Me.dgvalumno = New System.Windows.Forms.DataGridView
    Me.colnroOrden = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.colnombre = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.Button1 = New System.Windows.Forms.Button
    Me.Label1 = New System.Windows.Forms.Label
    Me.txtseccion = New System.Windows.Forms.TextBox
    Me.txtnivel = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.gbListar = New System.Windows.Forms.GroupBox
    CType(Me.dgvalumno, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbListar.SuspendLayout()
    Me.SuspendLayout()
    '
    'dgvalumno
    '
    Me.dgvalumno.AllowUserToAddRows = False
    Me.dgvalumno.AllowUserToDeleteRows = False
    Me.dgvalumno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvalumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvalumno.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colnroOrden, Me.colnombre})
    Me.dgvalumno.Location = New System.Drawing.Point(20, 77)
    Me.dgvalumno.Name = "dgvalumno"
    Me.dgvalumno.ReadOnly = True
    Me.dgvalumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvalumno.Size = New System.Drawing.Size(369, 285)
    Me.dgvalumno.TabIndex = 16
    '
    'colnroOrden
    '
    Me.colnroOrden.DataPropertyName = "nroOrden"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.colnroOrden.DefaultCellStyle = DataGridViewCellStyle2
    Me.colnroOrden.HeaderText = "Nro Orden"
    Me.colnroOrden.Name = "colnroOrden"
    Me.colnroOrden.ReadOnly = True
    '
    'colnombre
    '
    Me.colnombre.DataPropertyName = "NombreCompleto"
    Me.colnombre.HeaderText = "Apellidos y Nombre"
    Me.colnombre.Name = "colnombre"
    Me.colnombre.ReadOnly = True
    Me.colnombre.Width = 225
    '
    'Button1
    '
    Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
    Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.Button1.Location = New System.Drawing.Point(279, 377)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(110, 52)
    Me.Button1.TabIndex = 17
    Me.Button1.Text = "&Cerrar"
    Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.Button1.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(10, 17)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(86, 13)
    Me.Label1.TabIndex = 18
    Me.Label1.Text = "Grado y Sección"
    '
    'txtseccion
    '
    Me.txtseccion.BackColor = System.Drawing.SystemColors.Info
    Me.txtseccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtseccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtseccion.Location = New System.Drawing.Point(98, 14)
    Me.txtseccion.Name = "txtseccion"
    Me.txtseccion.ReadOnly = True
    Me.txtseccion.Size = New System.Drawing.Size(111, 20)
    Me.txtseccion.TabIndex = 19
    '
    'txtnivel
    '
    Me.txtnivel.BackColor = System.Drawing.SystemColors.Info
    Me.txtnivel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtnivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtnivel.Location = New System.Drawing.Point(248, 14)
    Me.txtnivel.Name = "txtnivel"
    Me.txtnivel.ReadOnly = True
    Me.txtnivel.Size = New System.Drawing.Size(111, 20)
    Me.txtnivel.TabIndex = 21
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(215, 17)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(31, 13)
    Me.Label2.TabIndex = 20
    Me.Label2.Text = "Nivel"
    '
    'gbListar
    '
    Me.gbListar.Controls.Add(Me.txtnivel)
    Me.gbListar.Controls.Add(Me.Label2)
    Me.gbListar.Controls.Add(Me.txtseccion)
    Me.gbListar.Controls.Add(Me.Label1)
    Me.gbListar.Location = New System.Drawing.Point(20, 12)
    Me.gbListar.Name = "gbListar"
    Me.gbListar.Size = New System.Drawing.Size(369, 42)
    Me.gbListar.TabIndex = 22
    Me.gbListar.TabStop = False
    '
    'frmListarAlumno
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(409, 441)
    Me.Controls.Add(Me.gbListar)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.dgvalumno)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmListarAlumno"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Listar Alumno"
    CType(Me.dgvalumno, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbListar.ResumeLayout(False)
    Me.gbListar.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
    Friend WithEvents dgvalumno As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtseccion As System.Windows.Forms.TextBox
    Friend WithEvents txtnivel As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents colnroOrden As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colnombre As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents gbListar As System.Windows.Forms.GroupBox
End Class
