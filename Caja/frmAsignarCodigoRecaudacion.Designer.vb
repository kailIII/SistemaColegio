<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarCodigoRecaudacion
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.txtAnio = New System.Windows.Forms.TextBox()
    Me.lblAnioLectivo = New System.Windows.Forms.Label()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.btnAsignar = New System.Windows.Forms.Button()
    Me.tabAlumnos = New System.Windows.Forms.TabControl()
    Me.tbpAlumnosNuevos = New System.Windows.Forms.TabPage()
    Me.btnListarAlumnosNuevos = New System.Windows.Forms.Button()
    Me.dgvAlumnosNuevos = New System.Windows.Forms.DataGridView()
    Me.cdSeccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.tbpSecciones = New System.Windows.Forms.TabPage()
    Me.btnListarSeccion = New System.Windows.Forms.Button()
    Me.dgvAlumnosSeccion = New System.Windows.Forms.DataGridView()
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cboGrado = New System.Windows.Forms.ComboBox()
    Me.lblGrado = New System.Windows.Forms.Label()
    Me.btnGenerar = New System.Windows.Forms.Button()
    Me.tabAlumnos.SuspendLayout()
    Me.tbpAlumnosNuevos.SuspendLayout()
    CType(Me.dgvAlumnosNuevos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.tbpSecciones.SuspendLayout()
    CType(Me.dgvAlumnosSeccion, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtAnio
    '
    Me.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAnio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAnio.Location = New System.Drawing.Point(49, 25)
    Me.txtAnio.Multiline = True
    Me.txtAnio.Name = "txtAnio"
    Me.txtAnio.ReadOnly = True
    Me.txtAnio.Size = New System.Drawing.Size(100, 24)
    Me.txtAnio.TabIndex = 1
    Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'lblAnioLectivo
    '
    Me.lblAnioLectivo.AutoSize = True
    Me.lblAnioLectivo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAnioLectivo.Location = New System.Drawing.Point(12, 34)
    Me.lblAnioLectivo.Name = "lblAnioLectivo"
    Me.lblAnioLectivo.Size = New System.Drawing.Size(31, 15)
    Me.lblAnioLectivo.TabIndex = 0
    Me.lblAnioLectivo.Text = "&Año"
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.Location = New System.Drawing.Point(556, 454)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(111, 27)
    Me.btnCerrar.TabIndex = 4
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.UseVisualStyleBackColor = True
    '
    'btnAsignar
    '
    Me.btnAsignar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnAsignar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAsignar.Location = New System.Drawing.Point(439, 454)
    Me.btnAsignar.Name = "btnAsignar"
    Me.btnAsignar.Size = New System.Drawing.Size(111, 27)
    Me.btnAsignar.TabIndex = 3
    Me.btnAsignar.Text = "A&signar"
    Me.btnAsignar.UseVisualStyleBackColor = True
    '
    'tabAlumnos
    '
    Me.tabAlumnos.Controls.Add(Me.tbpAlumnosNuevos)
    Me.tabAlumnos.Controls.Add(Me.tbpSecciones)
    Me.tabAlumnos.Location = New System.Drawing.Point(12, 67)
    Me.tabAlumnos.Name = "tabAlumnos"
    Me.tabAlumnos.SelectedIndex = 0
    Me.tabAlumnos.Size = New System.Drawing.Size(655, 373)
    Me.tabAlumnos.TabIndex = 2
    '
    'tbpAlumnosNuevos
    '
    Me.tbpAlumnosNuevos.Controls.Add(Me.btnGenerar)
    Me.tbpAlumnosNuevos.Controls.Add(Me.btnListarAlumnosNuevos)
    Me.tbpAlumnosNuevos.Controls.Add(Me.dgvAlumnosNuevos)
    Me.tbpAlumnosNuevos.Location = New System.Drawing.Point(4, 22)
    Me.tbpAlumnosNuevos.Name = "tbpAlumnosNuevos"
    Me.tbpAlumnosNuevos.Padding = New System.Windows.Forms.Padding(3)
    Me.tbpAlumnosNuevos.Size = New System.Drawing.Size(647, 347)
    Me.tbpAlumnosNuevos.TabIndex = 0
    Me.tbpAlumnosNuevos.Text = "Alumnos nuevos"
    Me.tbpAlumnosNuevos.UseVisualStyleBackColor = True
    '
    'btnListarAlumnosNuevos
    '
    Me.btnListarAlumnosNuevos.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnListarAlumnosNuevos.Location = New System.Drawing.Point(6, 13)
    Me.btnListarAlumnosNuevos.Name = "btnListarAlumnosNuevos"
    Me.btnListarAlumnosNuevos.Size = New System.Drawing.Size(111, 27)
    Me.btnListarAlumnosNuevos.TabIndex = 0
    Me.btnListarAlumnosNuevos.Text = "&Listar"
    Me.btnListarAlumnosNuevos.UseVisualStyleBackColor = True
    '
    'dgvAlumnosNuevos
    '
    Me.dgvAlumnosNuevos.AllowUserToAddRows = False
    Me.dgvAlumnosNuevos.AllowUserToDeleteRows = False
    Me.dgvAlumnosNuevos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvAlumnosNuevos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvAlumnosNuevos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdSeccion, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
    Me.dgvAlumnosNuevos.Location = New System.Drawing.Point(6, 52)
    Me.dgvAlumnosNuevos.Name = "dgvAlumnosNuevos"
    Me.dgvAlumnosNuevos.Size = New System.Drawing.Size(635, 282)
    Me.dgvAlumnosNuevos.TabIndex = 1
    '
    'cdSeccion
    '
    Me.cdSeccion.DataPropertyName = "NivelGradoSeccion"
    Me.cdSeccion.HeaderText = "Sección"
    Me.cdSeccion.Name = "cdSeccion"
    Me.cdSeccion.ReadOnly = True
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.DataPropertyName = "NombreAlumno"
    Me.DataGridViewTextBoxColumn1.HeaderText = "Alumno"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.Width = 350
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.DataPropertyName = "CodigoRecaudacion"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle1
    Me.DataGridViewTextBoxColumn2.HeaderText = "Código"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    '
    'tbpSecciones
    '
    Me.tbpSecciones.Controls.Add(Me.btnListarSeccion)
    Me.tbpSecciones.Controls.Add(Me.dgvAlumnosSeccion)
    Me.tbpSecciones.Controls.Add(Me.cboGrado)
    Me.tbpSecciones.Controls.Add(Me.lblGrado)
    Me.tbpSecciones.Location = New System.Drawing.Point(4, 22)
    Me.tbpSecciones.Name = "tbpSecciones"
    Me.tbpSecciones.Padding = New System.Windows.Forms.Padding(3)
    Me.tbpSecciones.Size = New System.Drawing.Size(647, 347)
    Me.tbpSecciones.TabIndex = 1
    Me.tbpSecciones.Text = "Secciones"
    Me.tbpSecciones.UseVisualStyleBackColor = True
    '
    'btnListarSeccion
    '
    Me.btnListarSeccion.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnListarSeccion.Location = New System.Drawing.Point(242, 13)
    Me.btnListarSeccion.Name = "btnListarSeccion"
    Me.btnListarSeccion.Size = New System.Drawing.Size(111, 27)
    Me.btnListarSeccion.TabIndex = 2
    Me.btnListarSeccion.Text = "&Listar"
    Me.btnListarSeccion.UseVisualStyleBackColor = True
    '
    'dgvAlumnosSeccion
    '
    Me.dgvAlumnosSeccion.AllowUserToAddRows = False
    Me.dgvAlumnosSeccion.AllowUserToDeleteRows = False
    Me.dgvAlumnosSeccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvAlumnosSeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvAlumnosSeccion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdAlumno, Me.cdCodigo})
    Me.dgvAlumnosSeccion.Location = New System.Drawing.Point(6, 52)
    Me.dgvAlumnosSeccion.Name = "dgvAlumnosSeccion"
    Me.dgvAlumnosSeccion.Size = New System.Drawing.Size(635, 282)
    Me.dgvAlumnosSeccion.TabIndex = 3
    '
    'cdAlumno
    '
    Me.cdAlumno.DataPropertyName = "NombreCompleto"
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.Width = 350
    '
    'cdCodigo
    '
    Me.cdCodigo.DataPropertyName = "CodigoRecaudacion"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdCodigo.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdCodigo.HeaderText = "Código"
    Me.cdCodigo.Name = "cdCodigo"
    '
    'cboGrado
    '
    Me.cboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboGrado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboGrado.FormattingEnabled = True
    Me.cboGrado.Location = New System.Drawing.Point(67, 15)
    Me.cboGrado.Name = "cboGrado"
    Me.cboGrado.Size = New System.Drawing.Size(153, 24)
    Me.cboGrado.TabIndex = 1
    '
    'lblGrado
    '
    Me.lblGrado.AutoSize = True
    Me.lblGrado.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblGrado.Location = New System.Drawing.Point(6, 24)
    Me.lblGrado.Name = "lblGrado"
    Me.lblGrado.Size = New System.Drawing.Size(39, 15)
    Me.lblGrado.TabIndex = 0
    Me.lblGrado.Text = "&Grado"
    '
    'btnGenerar
    '
    Me.btnGenerar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnGenerar.Location = New System.Drawing.Point(132, 13)
    Me.btnGenerar.Name = "btnGenerar"
    Me.btnGenerar.Size = New System.Drawing.Size(209, 27)
    Me.btnGenerar.TabIndex = 2
    Me.btnGenerar.Text = "&Generar automáticamente"
    Me.btnGenerar.UseVisualStyleBackColor = True
    '
    'frmAsignarCodigoRecaudacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(683, 493)
    Me.Controls.Add(Me.txtAnio)
    Me.Controls.Add(Me.lblAnioLectivo)
    Me.Controls.Add(Me.tabAlumnos)
    Me.Controls.Add(Me.btnAsignar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Name = "frmAsignarCodigoRecaudacion"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Asignar códigos de recaudación"
    Me.tabAlumnos.ResumeLayout(False)
    Me.tbpAlumnosNuevos.ResumeLayout(False)
    CType(Me.dgvAlumnosNuevos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.tbpSecciones.ResumeLayout(False)
    Me.tbpSecciones.PerformLayout()
    CType(Me.dgvAlumnosSeccion, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtAnio As System.Windows.Forms.TextBox
  Friend WithEvents lblAnioLectivo As System.Windows.Forms.Label
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnAsignar As System.Windows.Forms.Button
  Friend WithEvents tabAlumnos As System.Windows.Forms.TabControl
  Friend WithEvents tbpAlumnosNuevos As System.Windows.Forms.TabPage
  Friend WithEvents tbpSecciones As System.Windows.Forms.TabPage
  Friend WithEvents btnListarSeccion As System.Windows.Forms.Button
  Friend WithEvents dgvAlumnosSeccion As System.Windows.Forms.DataGridView
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cboGrado As System.Windows.Forms.ComboBox
  Friend WithEvents lblGrado As System.Windows.Forms.Label
  Friend WithEvents btnListarAlumnosNuevos As System.Windows.Forms.Button
  Friend WithEvents dgvAlumnosNuevos As System.Windows.Forms.DataGridView
  Friend WithEvents cdSeccion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnGenerar As System.Windows.Forms.Button
End Class
