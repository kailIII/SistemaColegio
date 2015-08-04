<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrasladoAlumnos2
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
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.gbGrado = New System.Windows.Forms.GroupBox
    Me.lblGrado = New System.Windows.Forms.Label
    Me.cboGrado = New System.Windows.Forms.ComboBox
    Me.cboNivel = New System.Windows.Forms.ComboBox
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnActualizar = New System.Windows.Forms.Button
    Me.dgAlumnos = New System.Windows.Forms.DataGridView
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdSexo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdGrado = New System.Windows.Forms.DataGridViewComboBoxColumn
    Me.cdEstado = New System.Windows.Forms.DataGridViewCheckBoxColumn
    Me.dgGrados = New System.Windows.Forms.DataGridView
    Me.cdNumero = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdSeccion = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnListar = New System.Windows.Forms.Button
    Me.gbGrado.SuspendLayout()
    CType(Me.dgAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dgGrados, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'gbGrado
    '
    Me.gbGrado.Controls.Add(Me.lblGrado)
    Me.gbGrado.Controls.Add(Me.cboGrado)
    Me.gbGrado.Controls.Add(Me.cboNivel)
    Me.gbGrado.Location = New System.Drawing.Point(40, 9)
    Me.gbGrado.Name = "gbGrado"
    Me.gbGrado.Size = New System.Drawing.Size(459, 62)
    Me.gbGrado.TabIndex = 18
    Me.gbGrado.TabStop = False
    '
    'lblGrado
    '
    Me.lblGrado.AutoSize = True
    Me.lblGrado.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblGrado.Location = New System.Drawing.Point(17, 27)
    Me.lblGrado.Name = "lblGrado"
    Me.lblGrado.Size = New System.Drawing.Size(44, 17)
    Me.lblGrado.TabIndex = 0
    Me.lblGrado.Text = "&Grado"
    '
    'cboGrado
    '
    Me.cboGrado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboGrado.FormattingEnabled = True
    Me.cboGrado.Location = New System.Drawing.Point(266, 23)
    Me.cboGrado.Name = "cboGrado"
    Me.cboGrado.Size = New System.Drawing.Size(171, 24)
    Me.cboGrado.TabIndex = 2
    '
    'cboNivel
    '
    Me.cboNivel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Location = New System.Drawing.Point(70, 23)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(171, 24)
    Me.cboNivel.TabIndex = 1
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(766, 534)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 50)
    Me.btnCerrar.TabIndex = 23
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnActualizar
    '
    Me.btnActualizar.BackColor = System.Drawing.Color.White
    Me.btnActualizar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnActualizar.Location = New System.Drawing.Point(766, 306)
    Me.btnActualizar.Name = "btnActualizar"
    Me.btnActualizar.Size = New System.Drawing.Size(110, 50)
    Me.btnActualizar.TabIndex = 22
    Me.btnActualizar.Text = "&Actualizar"
    Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnActualizar.UseVisualStyleBackColor = False
    '
    'dgAlumnos
    '
    Me.dgAlumnos.AllowUserToAddRows = False
    Me.dgAlumnos.AllowUserToDeleteRows = False
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgAlumnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdAlumno, Me.cdSexo, Me.cdGrado, Me.cdEstado})
    Me.dgAlumnos.Location = New System.Drawing.Point(40, 207)
    Me.dgAlumnos.Name = "dgAlumnos"
    Me.dgAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgAlumnos.Size = New System.Drawing.Size(694, 377)
    Me.dgAlumnos.TabIndex = 21
    '
    'cdAlumno
    '
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    Me.cdAlumno.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.Width = 340
    '
    'cdSexo
    '
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.cdSexo.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdSexo.HeaderText = "Sexo"
    Me.cdSexo.Name = "cdSexo"
    Me.cdSexo.Width = 110
    '
    'cdGrado
    '
    Me.cdGrado.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
    Me.cdGrado.HeaderText = "Grado"
    Me.cdGrado.Name = "cdGrado"
    Me.cdGrado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.cdGrado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    '
    'cdEstado
    '
    Me.cdEstado.HeaderText = "Estado"
    Me.cdEstado.Name = "cdEstado"
    Me.cdEstado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.cdEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.cdEstado.Width = 60
    '
    'dgGrados
    '
    Me.dgGrados.AllowUserToAddRows = False
    Me.dgGrados.AllowUserToDeleteRows = False
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgGrados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.dgGrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgGrados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNumero, Me.cdSeccion, Me.cdCantidad})
    Me.dgGrados.Location = New System.Drawing.Point(40, 86)
    Me.dgGrados.Name = "dgGrados"
    Me.dgGrados.ReadOnly = True
    Me.dgGrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgGrados.Size = New System.Drawing.Size(694, 115)
    Me.dgGrados.TabIndex = 20
    '
    'cdNumero
    '
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdNumero.DefaultCellStyle = DataGridViewCellStyle5
    Me.cdNumero.HeaderText = "Número"
    Me.cdNumero.Name = "cdNumero"
    Me.cdNumero.ReadOnly = True
    '
    'cdSeccion
    '
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cdSeccion.DefaultCellStyle = DataGridViewCellStyle6
    Me.cdSeccion.HeaderText = "Sección"
    Me.cdSeccion.Name = "cdSeccion"
    Me.cdSeccion.ReadOnly = True
    Me.cdSeccion.Width = 150
    '
    'cdCantidad
    '
    DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cdCantidad.DefaultCellStyle = DataGridViewCellStyle7
    Me.cdCantidad.HeaderText = "Cantidad"
    Me.cdCantidad.Name = "cdCantidad"
    Me.cdCantidad.ReadOnly = True
    '
    'btnListar
    '
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnListar.Location = New System.Drawing.Point(514, 28)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(100, 32)
    Me.btnListar.TabIndex = 19
    Me.btnListar.Text = "&Listar"
    Me.btnListar.UseVisualStyleBackColor = False
    '
    'frmTrasladoAlumnos2
    '
    Me.AcceptButton = Me.btnListar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(917, 593)
    Me.Controls.Add(Me.gbGrado)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnActualizar)
    Me.Controls.Add(Me.dgAlumnos)
    Me.Controls.Add(Me.dgGrados)
    Me.Controls.Add(Me.btnListar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MinimizeBox = False
    Me.Name = "frmTrasladoAlumnos2"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión traslado de alumnos"
    Me.gbGrado.ResumeLayout(False)
    Me.gbGrado.PerformLayout()
    CType(Me.dgAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dgGrados, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents gbGrado As System.Windows.Forms.GroupBox
  Friend WithEvents lblGrado As System.Windows.Forms.Label
  Friend WithEvents cboGrado As System.Windows.Forms.ComboBox
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnActualizar As System.Windows.Forms.Button
  Friend WithEvents dgAlumnos As System.Windows.Forms.DataGridView
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdSexo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdGrado As System.Windows.Forms.DataGridViewComboBoxColumn
  Friend WithEvents cdEstado As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents dgGrados As System.Windows.Forms.DataGridView
  Friend WithEvents cdNumero As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdSeccion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnListar As System.Windows.Forms.Button
End Class
