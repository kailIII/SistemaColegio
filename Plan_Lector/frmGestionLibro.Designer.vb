<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionLibro
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
        Me.components = New System.ComponentModel.Container
        Me.gbLibro = New System.Windows.Forms.GroupBox
        Me.txtAbreviatura = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnBuscarLibro = New System.Windows.Forms.Button
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLibro = New System.Windows.Forms.TextBox
        Me.lblnombre = New System.Windows.Forms.Label
        Me.gbAutor = New System.Windows.Forms.GroupBox
        Me.btnGenerar = New System.Windows.Forms.Button
        Me.nupNro = New System.Windows.Forms.NumericUpDown
        Me.gbListaAutores = New System.Windows.Forms.GroupBox
        Me.dgvAutor = New System.Windows.Forms.DataGridView
        Me.cdCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cdNombres = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cdApellidos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnBuscarAutor = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnRegistrar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.ErrLibro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gbLibro.SuspendLayout()
        Me.gbAutor.SuspendLayout()
        CType(Me.nupNro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbListaAutores.SuspendLayout()
        CType(Me.dgvAutor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrLibro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbLibro
        '
        Me.gbLibro.Controls.Add(Me.txtAbreviatura)
        Me.gbLibro.Controls.Add(Me.Label3)
        Me.gbLibro.Controls.Add(Me.Label1)
        Me.gbLibro.Controls.Add(Me.btnBuscarLibro)
        Me.gbLibro.Controls.Add(Me.txtDescripcion)
        Me.gbLibro.Controls.Add(Me.Label2)
        Me.gbLibro.Controls.Add(Me.txtLibro)
        Me.gbLibro.Controls.Add(Me.lblnombre)
        Me.gbLibro.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.gbLibro.Location = New System.Drawing.Point(12, 12)
        Me.gbLibro.Name = "gbLibro"
        Me.gbLibro.Size = New System.Drawing.Size(669, 165)
        Me.gbLibro.TabIndex = 0
        Me.gbLibro.TabStop = False
        Me.gbLibro.Text = "Libro"
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAbreviatura.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.txtAbreviatura.Location = New System.Drawing.Point(79, 137)
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(448, 22)
        Me.txtAbreviatura.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Abreviatura"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(539, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "F5 : Buscar Libro"
        '
        'btnBuscarLibro
        '
        Me.btnBuscarLibro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarLibro.BackColor = System.Drawing.Color.White
        Me.btnBuscarLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscarLibro.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnBuscarLibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarLibro.Location = New System.Drawing.Point(553, 29)
        Me.btnBuscarLibro.Name = "btnBuscarLibro"
        Me.btnBuscarLibro.Size = New System.Drawing.Size(110, 32)
        Me.btnBuscarLibro.TabIndex = 2
        Me.btnBuscarLibro.Text = "Buscar &Libro"
        Me.btnBuscarLibro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarLibro.UseVisualStyleBackColor = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(79, 59)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(448, 62)
        Me.txtDescripcion.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripción"
        '
        'txtLibro
        '
        Me.txtLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLibro.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.txtLibro.Location = New System.Drawing.Point(79, 29)
        Me.txtLibro.Name = "txtLibro"
        Me.txtLibro.Size = New System.Drawing.Size(448, 22)
        Me.txtLibro.TabIndex = 1
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(6, 29)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(39, 15)
        Me.lblnombre.TabIndex = 0
        Me.lblnombre.Text = "Titulo"
        '
        'gbAutor
        '
        Me.gbAutor.Controls.Add(Me.btnGenerar)
        Me.gbAutor.Controls.Add(Me.nupNro)
        Me.gbAutor.Controls.Add(Me.gbListaAutores)
        Me.gbAutor.Controls.Add(Me.btnBuscarAutor)
        Me.gbAutor.Controls.Add(Me.Label4)
        Me.gbAutor.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.gbAutor.Location = New System.Drawing.Point(12, 183)
        Me.gbAutor.Name = "gbAutor"
        Me.gbAutor.Size = New System.Drawing.Size(548, 240)
        Me.gbAutor.TabIndex = 1
        Me.gbAutor.TabStop = False
        Me.gbAutor.Text = "Autor"
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.White
        Me.btnGenerar.Font = New System.Drawing.Font("Times New Roman", 8.9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Location = New System.Drawing.Point(138, 18)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(79, 30)
        Me.btnGenerar.TabIndex = 2
        Me.btnGenerar.Text = "&Generar"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'nupNro
        '
        Me.nupNro.Location = New System.Drawing.Point(79, 21)
        Me.nupNro.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nupNro.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nupNro.Name = "nupNro"
        Me.nupNro.Size = New System.Drawing.Size(35, 22)
        Me.nupNro.TabIndex = 1
        Me.nupNro.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'gbListaAutores
        '
        Me.gbListaAutores.Controls.Add(Me.dgvAutor)
        Me.gbListaAutores.Controls.Add(Me.btnEliminar)
        Me.gbListaAutores.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.gbListaAutores.Location = New System.Drawing.Point(6, 55)
        Me.gbListaAutores.Name = "gbListaAutores"
        Me.gbListaAutores.Size = New System.Drawing.Size(536, 174)
        Me.gbListaAutores.TabIndex = 3
        Me.gbListaAutores.TabStop = False
        Me.gbListaAutores.Text = "Lista de Autores"
        '
        'dgvAutor
        '
        Me.dgvAutor.AllowUserToAddRows = False
        Me.dgvAutor.AllowUserToDeleteRows = False
        Me.dgvAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAutor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdCodigo, Me.cdNombres, Me.cdApellidos})
        Me.dgvAutor.Location = New System.Drawing.Point(9, 21)
        Me.dgvAutor.MultiSelect = False
        Me.dgvAutor.Name = "dgvAutor"
        Me.dgvAutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvAutor.Size = New System.Drawing.Size(518, 111)
        Me.dgvAutor.TabIndex = 0
        '
        'cdCodigo
        '
        Me.cdCodigo.HeaderText = ""
        Me.cdCodigo.Name = "cdCodigo"
        Me.cdCodigo.Visible = False
        '
        'cdNombres
        '
        Me.cdNombres.HeaderText = "Nombres"
        Me.cdNombres.Name = "cdNombres"
        Me.cdNombres.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cdNombres.Width = 200
        '
        'cdApellidos
        '
        Me.cdApellidos.HeaderText = "Apellidos"
        Me.cdApellidos.Name = "cdApellidos"
        Me.cdApellidos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cdApellidos.Width = 270
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.White
        Me.btnEliminar.Font = New System.Drawing.Font("Times New Roman", 8.9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(442, 138)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(79, 30)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "&Quitar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnBuscarAutor
        '
        Me.btnBuscarAutor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarAutor.BackColor = System.Drawing.Color.White
        Me.btnBuscarAutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscarAutor.Enabled = False
        Me.btnBuscarAutor.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnBuscarAutor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarAutor.Location = New System.Drawing.Point(416, 17)
        Me.btnBuscarAutor.Name = "btnBuscarAutor"
        Me.btnBuscarAutor.Size = New System.Drawing.Size(111, 32)
        Me.btnBuscarAutor.TabIndex = 4
        Me.btnBuscarAutor.Text = "&B&uscar Autor"
        Me.btnBuscarAutor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarAutor.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Autores"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(571, 371)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.White
        Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrar.Location = New System.Drawing.Point(571, 183)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
        Me.btnRegistrar.TabIndex = 2
        Me.btnRegistrar.Text = "&Registrar"
        Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(571, 254)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "&Deshacer"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'ErrLibro
        '
        Me.ErrLibro.ContainerControl = Me
        '
        'frmLibro
        '
        Me.AcceptButton = Me.btnRegistrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(693, 429)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.gbAutor)
        Me.Controls.Add(Me.gbLibro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLibro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Libros"
        Me.gbLibro.ResumeLayout(False)
        Me.gbLibro.PerformLayout()
        Me.gbAutor.ResumeLayout(False)
        Me.gbAutor.PerformLayout()
        CType(Me.nupNro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbListaAutores.ResumeLayout(False)
        CType(Me.dgvAutor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrLibro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbLibro As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLibro As System.Windows.Forms.TextBox
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents gbAutor As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarAutor As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents ErrLibro As System.Windows.Forms.ErrorProvider
    Friend WithEvents dgvAutor As System.Windows.Forms.DataGridView
    Friend WithEvents gbListaAutores As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnBuscarLibro As System.Windows.Forms.Button
    Friend WithEvents nupNro As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents cdCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdNombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdApellidos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAbreviatura As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
