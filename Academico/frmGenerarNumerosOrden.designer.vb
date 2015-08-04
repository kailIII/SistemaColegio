<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerarNumerosOrden
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenerarNumerosOrden))
        Me.dgvSeccion = New System.Windows.Forms.DataGridView
        Me.cbanio = New System.Windows.Forms.ComboBox
        Me.lblAnio = New System.Windows.Forms.Label
        Me.btnVer = New System.Windows.Forms.Button
        Me.btnGenerar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboSeleccion = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.colgenerar = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.colcodigoG = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colletra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colGradoSeccion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colNivelAcad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colimagen = New System.Windows.Forms.DataGridViewImageColumn
        Me.colresultado = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvSeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSeccion
        '
        Me.dgvSeccion.AllowUserToAddRows = False
        Me.dgvSeccion.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSeccion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeccion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colgenerar, Me.colcodigoG, Me.colletra, Me.colGradoSeccion, Me.colNivelAcad, Me.colimagen, Me.colresultado})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSeccion.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvSeccion.Location = New System.Drawing.Point(35, 68)
        Me.dgvSeccion.Name = "dgvSeccion"
        Me.dgvSeccion.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSeccion.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvSeccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSeccion.Size = New System.Drawing.Size(534, 345)
        Me.dgvSeccion.TabIndex = 0
        '
        'cbanio
        '
        Me.cbanio.BackColor = System.Drawing.SystemColors.Info
        Me.cbanio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbanio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbanio.FormattingEnabled = True
        Me.cbanio.Location = New System.Drawing.Point(90, 19)
        Me.cbanio.Name = "cbanio"
        Me.cbanio.Size = New System.Drawing.Size(75, 21)
        Me.cbanio.TabIndex = 9
        '
        'lblAnio
        '
        Me.lblAnio.AutoSize = True
        Me.lblAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnio.Location = New System.Drawing.Point(24, 22)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(60, 13)
        Me.lblAnio.TabIndex = 10
        Me.lblAnio.Text = "Año &lectivo"
        '
        'btnVer
        '
        Me.btnVer.BackColor = System.Drawing.Color.White
        Me.btnVer.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVer.Location = New System.Drawing.Point(593, 205)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(110, 52)
        Me.btnVer.TabIndex = 13
        Me.btnVer.Tag = ""
        Me.btnVer.Text = "Ver"
        Me.btnVer.UseVisualStyleBackColor = False
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.White
        Me.btnGenerar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerar.Location = New System.Drawing.Point(593, 150)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(110, 52)
        Me.btnGenerar.TabIndex = 14
        Me.btnGenerar.Tag = ""
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(593, 361)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(110, 52)
        Me.btnSalir.TabIndex = 15
        Me.btnSalir.Tag = ""
        Me.btnSalir.Text = "Cerrar"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Modos de Selección"
        '
        'cboSeleccion
        '
        Me.cboSeleccion.BackColor = System.Drawing.SystemColors.Info
        Me.cboSeleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeleccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSeleccion.FormattingEnabled = True
        Me.cboSeleccion.Items.AddRange(New Object() {"Seleccionar Todos", "Seleccionar Ninguno", "Seleccionar mismo grado", "Seleccionar mismo nivel", "Seleccion única"})
        Me.cboSeleccion.Location = New System.Drawing.Point(343, 19)
        Me.cboSeleccion.Name = "cboSeleccion"
        Me.cboSeleccion.Size = New System.Drawing.Size(168, 21)
        Me.cboSeleccion.TabIndex = 29
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbanio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblAnio)
        Me.GroupBox1.Controls.Add(Me.cboSeleccion)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(534, 47)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'colgenerar
        '
        Me.colgenerar.HeaderText = "Generar"
        Me.colgenerar.Name = "colgenerar"
        Me.colgenerar.ReadOnly = True
        Me.colgenerar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colgenerar.Width = 50
        '
        'colcodigoG
        '
        Me.colcodigoG.DataPropertyName = "grado"
        Me.colcodigoG.HeaderText = ""
        Me.colcodigoG.Name = "colcodigoG"
        Me.colcodigoG.ReadOnly = True
        Me.colcodigoG.Visible = False
        '
        'colletra
        '
        Me.colletra.DataPropertyName = "letra"
        Me.colletra.HeaderText = ""
        Me.colletra.Name = "colletra"
        Me.colletra.ReadOnly = True
        Me.colletra.Visible = False
        '
        'colGradoSeccion
        '
        Me.colGradoSeccion.DataPropertyName = "numeroletra"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.colGradoSeccion.DefaultCellStyle = DataGridViewCellStyle2
        Me.colGradoSeccion.HeaderText = "Grado y Seccion"
        Me.colGradoSeccion.Name = "colGradoSeccion"
        Me.colGradoSeccion.ReadOnly = True
        Me.colGradoSeccion.Width = 130
        '
        'colNivelAcad
        '
        Me.colNivelAcad.DataPropertyName = "NombreNivel"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.colNivelAcad.DefaultCellStyle = DataGridViewCellStyle3
        Me.colNivelAcad.HeaderText = "Nivel Academico"
        Me.colNivelAcad.Name = "colNivelAcad"
        Me.colNivelAcad.ReadOnly = True
        Me.colNivelAcad.Width = 120
        '
        'colimagen
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.NullValue = "System.Drawing.Bitmap"
        Me.colimagen.DefaultCellStyle = DataGridViewCellStyle4
        Me.colimagen.HeaderText = ""
        Me.colimagen.Image = CType(resources.GetObject("colimagen.Image"), System.Drawing.Image)
        Me.colimagen.Name = "colimagen"
        Me.colimagen.ReadOnly = True
        Me.colimagen.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colimagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colimagen.Width = 40
        '
        'colresultado
        '
        Me.colresultado.HeaderText = "Resultado"
        Me.colresultado.Name = "colresultado"
        Me.colresultado.ReadOnly = True
        Me.colresultado.Width = 150
        '
        'frmGenerarNumerosOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 426)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.dgvSeccion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmGenerarNumerosOrden"
        Me.Text = "Generar Números de Orden"
        CType(Me.dgvSeccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
  Friend WithEvents dgvSeccion As System.Windows.Forms.DataGridView
  Friend WithEvents cbanio As System.Windows.Forms.ComboBox
  Friend WithEvents lblAnio As System.Windows.Forms.Label
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboSeleccion As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents colgenerar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colcodigoG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colletra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGradoSeccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNivelAcad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colimagen As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colresultado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
