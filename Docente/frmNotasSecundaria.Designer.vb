<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotasSecundaria
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
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.lblNombre = New System.Windows.Forms.Label
    Me.cboCurso = New System.Windows.Forms.ComboBox
    Me.lblNro = New System.Windows.Forms.Label
    Me.cboNro = New System.Windows.Forms.ComboBox
    Me.gbUnidad = New System.Windows.Forms.GroupBox
    Me.txtDescripcion = New System.Windows.Forms.TextBox
    Me.lblDescripcion = New System.Windows.Forms.Label
    Me.gbCurso = New System.Windows.Forms.GroupBox
    Me.dgNotas = New System.Windows.Forms.DataGridView
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnAceptar = New System.Windows.Forms.Button
    Me.btnListar = New System.Windows.Forms.Button
    Me.txtTotal = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.cdNroOrden = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.gbUnidad.SuspendLayout()
    Me.gbCurso.SuspendLayout()
    CType(Me.dgNotas, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblNombre
    '
    Me.lblNombre.AutoSize = True
    Me.lblNombre.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNombre.Location = New System.Drawing.Point(8, 26)
    Me.lblNombre.Name = "lblNombre"
    Me.lblNombre.Size = New System.Drawing.Size(49, 15)
    Me.lblNombre.TabIndex = 0
    Me.lblNombre.Text = "N&ombre"
    '
    'cboCurso
    '
    Me.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCurso.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboCurso.FormattingEnabled = True
    Me.cboCurso.Location = New System.Drawing.Point(56, 22)
    Me.cboCurso.Name = "cboCurso"
    Me.cboCurso.Size = New System.Drawing.Size(245, 24)
    Me.cboCurso.TabIndex = 1
    '
    'lblNro
    '
    Me.lblNro.AutoSize = True
    Me.lblNro.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNro.Location = New System.Drawing.Point(6, 26)
    Me.lblNro.Name = "lblNro"
    Me.lblNro.Size = New System.Drawing.Size(49, 15)
    Me.lblNro.TabIndex = 0
    Me.lblNro.Text = "Nú&mero"
    '
    'cboNro
    '
    Me.cboNro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboNro.FormattingEnabled = True
    Me.cboNro.Location = New System.Drawing.Point(51, 21)
    Me.cboNro.Name = "cboNro"
    Me.cboNro.Size = New System.Drawing.Size(42, 24)
    Me.cboNro.TabIndex = 1
    '
    'gbUnidad
    '
    Me.gbUnidad.Controls.Add(Me.txtDescripcion)
    Me.gbUnidad.Controls.Add(Me.lblDescripcion)
    Me.gbUnidad.Controls.Add(Me.cboNro)
    Me.gbUnidad.Controls.Add(Me.lblNro)
    Me.gbUnidad.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbUnidad.Location = New System.Drawing.Point(320, 8)
    Me.gbUnidad.Name = "gbUnidad"
    Me.gbUnidad.Size = New System.Drawing.Size(377, 53)
    Me.gbUnidad.TabIndex = 1
    Me.gbUnidad.TabStop = False
    Me.gbUnidad.Text = "Unidad"
    '
    'txtDescripcion
    '
    Me.txtDescripcion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDescripcion.Location = New System.Drawing.Point(172, 21)
    Me.txtDescripcion.Multiline = True
    Me.txtDescripcion.Name = "txtDescripcion"
    Me.txtDescripcion.ReadOnly = True
    Me.txtDescripcion.Size = New System.Drawing.Size(198, 24)
    Me.txtDescripcion.TabIndex = 3
    '
    'lblDescripcion
    '
    Me.lblDescripcion.AutoSize = True
    Me.lblDescripcion.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDescripcion.Location = New System.Drawing.Point(101, 25)
    Me.lblDescripcion.Name = "lblDescripcion"
    Me.lblDescripcion.Size = New System.Drawing.Size(71, 15)
    Me.lblDescripcion.TabIndex = 2
    Me.lblDescripcion.Text = "Descripción"
    '
    'gbCurso
    '
    Me.gbCurso.Controls.Add(Me.cboCurso)
    Me.gbCurso.Controls.Add(Me.lblNombre)
    Me.gbCurso.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbCurso.Location = New System.Drawing.Point(6, 8)
    Me.gbCurso.Name = "gbCurso"
    Me.gbCurso.Size = New System.Drawing.Size(308, 53)
    Me.gbCurso.TabIndex = 0
    Me.gbCurso.TabStop = False
    Me.gbCurso.Text = "Nivel - Grado - Sección - Curso"
    '
    'dgNotas
    '
    Me.dgNotas.AllowUserToAddRows = False
    Me.dgNotas.AllowUserToDeleteRows = False
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.dgNotas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
    Me.dgNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgNotas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
    Me.dgNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgNotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNroOrden, Me.cdAlumno})
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgNotas.DefaultCellStyle = DataGridViewCellStyle5
    Me.dgNotas.Location = New System.Drawing.Point(7, 67)
    Me.dgNotas.MultiSelect = False
    Me.dgNotas.Name = "dgNotas"
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgNotas.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
    Me.dgNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.dgNotas.Size = New System.Drawing.Size(798, 606)
    Me.dgNotas.TabIndex = 3
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(842, 623)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(134, 50)
    Me.btnCerrar.TabIndex = 6
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(842, 528)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(134, 50)
    Me.btnCancelar.TabIndex = 5
    Me.btnCancelar.Text = "C&ancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnAceptar
    '
    Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnAceptar.BackColor = System.Drawing.Color.White
    Me.btnAceptar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAceptar.Location = New System.Drawing.Point(842, 474)
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(134, 50)
    Me.btnAceptar.TabIndex = 4
    Me.btnAceptar.Text = "&Registrar"
    Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnAceptar.UseVisualStyleBackColor = False
    '
    'btnListar
    '
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnListar.Location = New System.Drawing.Point(703, 20)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(102, 39)
    Me.btnListar.TabIndex = 2
    Me.btnListar.Text = "&Listar"
    Me.btnListar.UseVisualStyleBackColor = False
    '
    'txtTotal
    '
    Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.txtTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTotal.Location = New System.Drawing.Point(889, 405)
    Me.txtTotal.Multiline = True
    Me.txtTotal.Name = "txtTotal"
    Me.txtTotal.ReadOnly = True
    Me.txtTotal.Size = New System.Drawing.Size(34, 24)
    Me.txtTotal.TabIndex = 8
    '
    'Label1
    '
    Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(839, 409)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(45, 15)
    Me.Label1.TabIndex = 7
    Me.Label1.Text = "Total : "
    '
    'cdNroOrden
    '
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.cdNroOrden.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdNroOrden.FillWeight = 90.0!
    Me.cdNroOrden.HeaderText = "Nro Orden"
    Me.cdNroOrden.Name = "cdNroOrden"
    Me.cdNroOrden.ReadOnly = True
    Me.cdNroOrden.Width = 50
    '
    'cdAlumno
    '
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
    Me.cdAlumno.DefaultCellStyle = DataGridViewCellStyle4
    Me.cdAlumno.FillWeight = 90.0!
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.ReadOnly = True
    Me.cdAlumno.Width = 280
    '
    'frmNotasSecundaria
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(1009, 680)
    Me.Controls.Add(Me.txtTotal)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.btnListar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnAceptar)
    Me.Controls.Add(Me.gbUnidad)
    Me.Controls.Add(Me.dgNotas)
    Me.Controls.Add(Me.gbCurso)
    Me.Name = "frmNotasSecundaria"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de Notas (Secundaria)"
    Me.gbUnidad.ResumeLayout(False)
    Me.gbUnidad.PerformLayout()
    Me.gbCurso.ResumeLayout(False)
    Me.gbCurso.PerformLayout()
    CType(Me.dgNotas, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblNombre As System.Windows.Forms.Label
  Friend WithEvents cboCurso As System.Windows.Forms.ComboBox
  Friend WithEvents lblNro As System.Windows.Forms.Label
  Friend WithEvents cboNro As System.Windows.Forms.ComboBox
  Friend WithEvents gbUnidad As System.Windows.Forms.GroupBox
  Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
  Friend WithEvents lblDescripcion As System.Windows.Forms.Label
  Friend WithEvents gbCurso As System.Windows.Forms.GroupBox
  Friend WithEvents dgNotas As System.Windows.Forms.DataGridView
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnAceptar As System.Windows.Forms.Button
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents txtTotal As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cdNroOrden As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
