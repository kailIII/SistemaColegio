<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarObligaciones
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
    Me.components = New System.ComponentModel.Container()
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.btnAceptar = New System.Windows.Forms.Button()
    Me.gbObligaciones = New System.Windows.Forms.GroupBox()
    Me.btnAgregar = New System.Windows.Forms.Button()
    Me.btnEliminar = New System.Windows.Forms.Button()
    Me.cboEntidad = New System.Windows.Forms.ComboBox()
    Me.lblEntidad = New System.Windows.Forms.Label()
    Me.cboServicio = New System.Windows.Forms.ComboBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.lblVencimiento = New System.Windows.Forms.Label()
    Me.dtFecha = New System.Windows.Forms.DateTimePicker()
    Me.txtMonto = New System.Windows.Forms.TextBox()
    Me.txtDescripcion = New System.Windows.Forms.TextBox()
    Me.lblMonto = New System.Windows.Forms.Label()
    Me.lbDescripcion = New System.Windows.Forms.Label()
    Me.dgvObligaciones = New System.Windows.Forms.DataGridView()
    Me.cdEntidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdObligacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.gbAlumnos = New System.Windows.Forms.GroupBox()
    Me.btnListar = New System.Windows.Forms.Button()
    Me.cboAnio = New System.Windows.Forms.ComboBox()
    Me.dgvAlumnos = New System.Windows.Forms.DataGridView()
    Me.cboSeccion = New System.Windows.Forms.ComboBox()
    Me.chkSeleccionarTodos = New System.Windows.Forms.CheckBox()
    Me.lblAnioLectivo = New System.Windows.Forms.Label()
    Me.lblSeccion = New System.Windows.Forms.Label()
    Me.errAsignar = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.cdSeleccionado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.cdCodigoRecaudacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.gbObligaciones.SuspendLayout()
    CType(Me.dgvObligaciones, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbAlumnos.SuspendLayout()
    CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.errAsignar, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnCancelar
    '
    Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.Location = New System.Drawing.Point(611, 470)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(111, 27)
    Me.btnCancelar.TabIndex = 3
    Me.btnCancelar.Text = "&Cancelar"
    Me.btnCancelar.UseVisualStyleBackColor = True
    '
    'btnAceptar
    '
    Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnAceptar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAceptar.Location = New System.Drawing.Point(449, 470)
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(111, 27)
    Me.btnAceptar.TabIndex = 2
    Me.btnAceptar.Text = "&Aceptar"
    Me.btnAceptar.UseVisualStyleBackColor = True
    '
    'gbObligaciones
    '
    Me.gbObligaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbObligaciones.Controls.Add(Me.btnAgregar)
    Me.gbObligaciones.Controls.Add(Me.btnEliminar)
    Me.gbObligaciones.Controls.Add(Me.cboEntidad)
    Me.gbObligaciones.Controls.Add(Me.lblEntidad)
    Me.gbObligaciones.Controls.Add(Me.cboServicio)
    Me.gbObligaciones.Controls.Add(Me.Label3)
    Me.gbObligaciones.Controls.Add(Me.lblVencimiento)
    Me.gbObligaciones.Controls.Add(Me.dtFecha)
    Me.gbObligaciones.Controls.Add(Me.txtMonto)
    Me.gbObligaciones.Controls.Add(Me.txtDescripcion)
    Me.gbObligaciones.Controls.Add(Me.lblMonto)
    Me.gbObligaciones.Controls.Add(Me.lbDescripcion)
    Me.gbObligaciones.Controls.Add(Me.dgvObligaciones)
    Me.gbObligaciones.Location = New System.Drawing.Point(12, 12)
    Me.gbObligaciones.Name = "gbObligaciones"
    Me.gbObligaciones.Size = New System.Drawing.Size(710, 232)
    Me.gbObligaciones.TabIndex = 0
    Me.gbObligaciones.TabStop = False
    Me.gbObligaciones.Text = "Obligaciones a asignar"
    '
    'btnAgregar
    '
    Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnAgregar.Location = New System.Drawing.Point(624, 119)
    Me.btnAgregar.Name = "btnAgregar"
    Me.btnAgregar.Size = New System.Drawing.Size(80, 31)
    Me.btnAgregar.TabIndex = 11
    Me.btnAgregar.Text = "A&gregar"
    Me.btnAgregar.UseVisualStyleBackColor = True
    '
    'btnEliminar
    '
    Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnEliminar.Location = New System.Drawing.Point(624, 191)
    Me.btnEliminar.Name = "btnEliminar"
    Me.btnEliminar.Size = New System.Drawing.Size(80, 31)
    Me.btnEliminar.TabIndex = 12
    Me.btnEliminar.Text = "&Eliminar"
    Me.btnEliminar.UseVisualStyleBackColor = True
    '
    'cboEntidad
    '
    Me.cboEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEntidad.FormattingEnabled = True
    Me.cboEntidad.Items.AddRange(New Object() {"INSTITUCION", "COPAFA"})
    Me.cboEntidad.Location = New System.Drawing.Point(81, 21)
    Me.cboEntidad.Name = "cboEntidad"
    Me.cboEntidad.Size = New System.Drawing.Size(148, 21)
    Me.cboEntidad.TabIndex = 1
    '
    'lblEntidad
    '
    Me.lblEntidad.AutoSize = True
    Me.lblEntidad.Location = New System.Drawing.Point(6, 29)
    Me.lblEntidad.Name = "lblEntidad"
    Me.lblEntidad.Size = New System.Drawing.Size(43, 13)
    Me.lblEntidad.TabIndex = 0
    Me.lblEntidad.Text = "En&tidad"
    '
    'cboServicio
    '
    Me.cboServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboServicio.FormattingEnabled = True
    Me.cboServicio.Location = New System.Drawing.Point(329, 19)
    Me.cboServicio.Name = "cboServicio"
    Me.cboServicio.Size = New System.Drawing.Size(233, 21)
    Me.cboServicio.TabIndex = 3
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(278, 29)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(45, 13)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Ser&vicio"
    '
    'lblVencimiento
    '
    Me.lblVencimiento.AutoSize = True
    Me.lblVencimiento.Location = New System.Drawing.Point(6, 91)
    Me.lblVencimiento.Name = "lblVencimiento"
    Me.lblVencimiento.Size = New System.Drawing.Size(65, 13)
    Me.lblVencimiento.TabIndex = 6
    Me.lblVencimiento.Text = "&Vencimiento"
    '
    'dtFecha
    '
    Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtFecha.Location = New System.Drawing.Point(82, 84)
    Me.dtFecha.Name = "dtFecha"
    Me.dtFecha.Size = New System.Drawing.Size(90, 20)
    Me.dtFecha.TabIndex = 7
    '
    'txtMonto
    '
    Me.txtMonto.Location = New System.Drawing.Point(329, 83)
    Me.txtMonto.Name = "txtMonto"
    Me.txtMonto.Size = New System.Drawing.Size(78, 20)
    Me.txtMonto.TabIndex = 9
    Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'txtDescripcion
    '
    Me.txtDescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.txtDescripcion.Location = New System.Drawing.Point(81, 52)
    Me.txtDescripcion.Name = "txtDescripcion"
    Me.txtDescripcion.Size = New System.Drawing.Size(481, 20)
    Me.txtDescripcion.TabIndex = 5
    '
    'lblMonto
    '
    Me.lblMonto.AutoSize = True
    Me.lblMonto.Location = New System.Drawing.Point(278, 90)
    Me.lblMonto.Name = "lblMonto"
    Me.lblMonto.Size = New System.Drawing.Size(37, 13)
    Me.lblMonto.TabIndex = 8
    Me.lblMonto.Text = "&Monto"
    '
    'lbDescripcion
    '
    Me.lbDescripcion.AutoSize = True
    Me.lbDescripcion.Location = New System.Drawing.Point(6, 59)
    Me.lbDescripcion.Name = "lbDescripcion"
    Me.lbDescripcion.Size = New System.Drawing.Size(63, 13)
    Me.lbDescripcion.TabIndex = 4
    Me.lbDescripcion.Text = "&Descripcion"
    '
    'dgvObligaciones
    '
    Me.dgvObligaciones.AllowUserToAddRows = False
    Me.dgvObligaciones.AllowUserToDeleteRows = False
    Me.dgvObligaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvObligaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvObligaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdEntidad, Me.cdObligacion, Me.cdVencimiento, Me.cdMonto})
    Me.dgvObligaciones.Location = New System.Drawing.Point(9, 119)
    Me.dgvObligaciones.MultiSelect = False
    Me.dgvObligaciones.Name = "dgvObligaciones"
    Me.dgvObligaciones.ReadOnly = True
    Me.dgvObligaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvObligaciones.Size = New System.Drawing.Size(612, 103)
    Me.dgvObligaciones.TabIndex = 10
    '
    'cdEntidad
    '
    Me.cdEntidad.DataPropertyName = "mostrarEntidad"
    Me.cdEntidad.HeaderText = "Entidad"
    Me.cdEntidad.Name = "cdEntidad"
    Me.cdEntidad.ReadOnly = True
    '
    'cdObligacion
    '
    Me.cdObligacion.DataPropertyName = "Descripcion"
    Me.cdObligacion.HeaderText = "Obligación"
    Me.cdObligacion.Name = "cdObligacion"
    Me.cdObligacion.ReadOnly = True
    Me.cdObligacion.Width = 250
    '
    'cdVencimiento
    '
    Me.cdVencimiento.DataPropertyName = "Vencimiento"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle1.Format = "d"
    DataGridViewCellStyle1.NullValue = Nothing
    Me.cdVencimiento.DefaultCellStyle = DataGridViewCellStyle1
    Me.cdVencimiento.HeaderText = "Vencimiento"
    Me.cdVencimiento.Name = "cdVencimiento"
    Me.cdVencimiento.ReadOnly = True
    '
    'cdMonto
    '
    Me.cdMonto.DataPropertyName = "Monto"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdMonto.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdMonto.HeaderText = "Monto"
    Me.cdMonto.Name = "cdMonto"
    Me.cdMonto.ReadOnly = True
    '
    'gbAlumnos
    '
    Me.gbAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbAlumnos.Controls.Add(Me.btnListar)
    Me.gbAlumnos.Controls.Add(Me.cboAnio)
    Me.gbAlumnos.Controls.Add(Me.dgvAlumnos)
    Me.gbAlumnos.Controls.Add(Me.cboSeccion)
    Me.gbAlumnos.Controls.Add(Me.chkSeleccionarTodos)
    Me.gbAlumnos.Controls.Add(Me.lblAnioLectivo)
    Me.gbAlumnos.Controls.Add(Me.lblSeccion)
    Me.gbAlumnos.Location = New System.Drawing.Point(12, 250)
    Me.gbAlumnos.Name = "gbAlumnos"
    Me.gbAlumnos.Size = New System.Drawing.Size(710, 197)
    Me.gbAlumnos.TabIndex = 1
    Me.gbAlumnos.TabStop = False
    Me.gbAlumnos.Text = "A&lumnos"
    '
    'btnListar
    '
    Me.btnListar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnListar.Location = New System.Drawing.Point(483, 28)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(102, 27)
    Me.btnListar.TabIndex = 4
    Me.btnListar.Text = "&Listar"
    Me.btnListar.UseVisualStyleBackColor = True
    '
    'cboAnio
    '
    Me.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAnio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboAnio.FormattingEnabled = True
    Me.cboAnio.Location = New System.Drawing.Point(53, 28)
    Me.cboAnio.Name = "cboAnio"
    Me.cboAnio.Size = New System.Drawing.Size(120, 24)
    Me.cboAnio.TabIndex = 1
    '
    'dgvAlumnos
    '
    Me.dgvAlumnos.AllowUserToAddRows = False
    Me.dgvAlumnos.AllowUserToDeleteRows = False
    Me.dgvAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdSeleccionado, Me.cdCodigoRecaudacion, Me.cdAlumno})
    Me.dgvAlumnos.Location = New System.Drawing.Point(10, 61)
    Me.dgvAlumnos.MultiSelect = False
    Me.dgvAlumnos.Name = "dgvAlumnos"
    Me.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvAlumnos.Size = New System.Drawing.Size(694, 108)
    Me.dgvAlumnos.TabIndex = 5
    '
    'cboSeccion
    '
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(238, 28)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(153, 24)
    Me.cboSeccion.TabIndex = 3
    '
    'chkSeleccionarTodos
    '
    Me.chkSeleccionarTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.chkSeleccionarTodos.AutoSize = True
    Me.chkSeleccionarTodos.Location = New System.Drawing.Point(10, 175)
    Me.chkSeleccionarTodos.Name = "chkSeleccionarTodos"
    Me.chkSeleccionarTodos.Size = New System.Drawing.Size(111, 17)
    Me.chkSeleccionarTodos.TabIndex = 6
    Me.chkSeleccionarTodos.Text = "Seleccionar &todos"
    Me.chkSeleccionarTodos.UseVisualStyleBackColor = True
    '
    'lblAnioLectivo
    '
    Me.lblAnioLectivo.AutoSize = True
    Me.lblAnioLectivo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAnioLectivo.Location = New System.Drawing.Point(16, 37)
    Me.lblAnioLectivo.Name = "lblAnioLectivo"
    Me.lblAnioLectivo.Size = New System.Drawing.Size(31, 15)
    Me.lblAnioLectivo.TabIndex = 0
    Me.lblAnioLectivo.Text = "&Año"
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSeccion.Location = New System.Drawing.Point(183, 37)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(49, 15)
    Me.lblSeccion.TabIndex = 2
    Me.lblSeccion.Text = "&Sección"
    '
    'errAsignar
    '
    Me.errAsignar.ContainerControl = Me
    '
    'cdSeleccionado
    '
    Me.cdSeleccionado.DataPropertyName = "Seleccionado"
    Me.cdSeleccionado.HeaderText = "Seleccionado"
    Me.cdSeleccionado.Name = "cdSeleccionado"
    Me.cdSeleccionado.Width = 75
    '
    'cdCodigoRecaudacion
    '
    Me.cdCodigoRecaudacion.DataPropertyName = "CodigoRecaudacion"
    Me.cdCodigoRecaudacion.HeaderText = "Código"
    Me.cdCodigoRecaudacion.Name = "cdCodigoRecaudacion"
    Me.cdCodigoRecaudacion.ReadOnly = True
    '
    'cdAlumno
    '
    Me.cdAlumno.DataPropertyName = "NombreAlumno"
    Me.cdAlumno.HeaderText = "Aumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.ReadOnly = True
    Me.cdAlumno.Width = 300
    '
    'frmAsignarObligaciones
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCancelar
    Me.ClientSize = New System.Drawing.Size(740, 509)
    Me.Controls.Add(Me.gbObligaciones)
    Me.Controls.Add(Me.gbAlumnos)
    Me.Controls.Add(Me.btnAceptar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Name = "frmAsignarObligaciones"
    Me.Text = "Asignar de obligaciones"
    Me.gbObligaciones.ResumeLayout(False)
    Me.gbObligaciones.PerformLayout()
    CType(Me.dgvObligaciones, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbAlumnos.ResumeLayout(False)
    Me.gbAlumnos.PerformLayout()
    CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.errAsignar, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnAceptar As System.Windows.Forms.Button
  Friend WithEvents gbObligaciones As System.Windows.Forms.GroupBox
  Friend WithEvents btnAgregar As System.Windows.Forms.Button
  Friend WithEvents btnEliminar As System.Windows.Forms.Button
  Friend WithEvents cboEntidad As System.Windows.Forms.ComboBox
  Friend WithEvents lblEntidad As System.Windows.Forms.Label
  Friend WithEvents cboServicio As System.Windows.Forms.ComboBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents lblVencimiento As System.Windows.Forms.Label
  Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
  Friend WithEvents txtMonto As System.Windows.Forms.TextBox
  Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
  Friend WithEvents lblMonto As System.Windows.Forms.Label
  Friend WithEvents lbDescripcion As System.Windows.Forms.Label
  Friend WithEvents dgvObligaciones As System.Windows.Forms.DataGridView
  Friend WithEvents gbAlumnos As System.Windows.Forms.GroupBox
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents lblAnioLectivo As System.Windows.Forms.Label
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents chkSeleccionarTodos As System.Windows.Forms.CheckBox
  Friend WithEvents errAsignar As System.Windows.Forms.ErrorProvider
  Friend WithEvents cdEntidad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdObligacion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdVencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdMonto As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
  Friend WithEvents dgvAlumnos As System.Windows.Forms.DataGridView
  Friend WithEvents cdSeleccionado As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents cdCodigoRecaudacion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
