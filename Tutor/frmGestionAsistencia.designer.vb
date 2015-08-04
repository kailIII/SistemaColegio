<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionAsistencia
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
    Me.lblAnio = New System.Windows.Forms.Label
    Me.lblSeccion = New System.Windows.Forms.Label
    Me.lblFecha = New System.Windows.Forms.Label
    Me.txtAnio = New System.Windows.Forms.TextBox
    Me.cboSeccion = New System.Windows.Forms.ComboBox
    Me.dtpFecha = New System.Windows.Forms.DateTimePicker
    Me.btnListar = New System.Windows.Forms.Button
    Me.dgvAsistencia = New System.Windows.Forms.DataGridView
    Me.gbAsistencia = New System.Windows.Forms.GroupBox
    Me.btnJustificar = New System.Windows.Forms.Button
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.cboPadre = New System.Windows.Forms.ComboBox
    Me.lblPadre = New System.Windows.Forms.Label
    Me.lbldetalle = New System.Windows.Forms.Label
    Me.txtDesc = New System.Windows.Forms.TextBox
    Me.dtpFechaJust = New System.Windows.Forms.DateTimePicker
    Me.Label1 = New System.Windows.Forms.Label
    Me.gbJustificacion = New System.Windows.Forms.GroupBox
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnRegJust = New System.Windows.Forms.Button
    Me.gbLeyenda = New System.Windows.Forms.GroupBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.Panel1 = New System.Windows.Forms.Panel
    Me.lblFalta = New System.Windows.Forms.Label
    Me.txtTotal = New System.Windows.Forms.TextBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.cdNro = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdSituacion = New System.Windows.Forms.DataGridViewComboBoxColumn
    Me.cdJustificado = New System.Windows.Forms.DataGridViewCheckBoxColumn
    CType(Me.dgvAsistencia, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbAsistencia.SuspendLayout()
    Me.gbJustificacion.SuspendLayout()
    Me.gbLeyenda.SuspendLayout()
    Me.SuspendLayout()
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblAnio.Location = New System.Drawing.Point(28, 9)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(36, 17)
    Me.lblAnio.TabIndex = 0
    Me.lblAnio.Text = "&Anio"
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblSeccion.Location = New System.Drawing.Point(28, 47)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(54, 17)
    Me.lblSeccion.TabIndex = 2
    Me.lblSeccion.Text = "&Sección"
    '
    'lblFecha
    '
    Me.lblFecha.AutoSize = True
    Me.lblFecha.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblFecha.Location = New System.Drawing.Point(358, 47)
    Me.lblFecha.Name = "lblFecha"
    Me.lblFecha.Size = New System.Drawing.Size(44, 17)
    Me.lblFecha.TabIndex = 4
    Me.lblFecha.Text = "&Fecha"
    '
    'txtAnio
    '
    Me.txtAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.txtAnio.Location = New System.Drawing.Point(91, 9)
    Me.txtAnio.Name = "txtAnio"
    Me.txtAnio.ReadOnly = True
    Me.txtAnio.Size = New System.Drawing.Size(100, 25)
    Me.txtAnio.TabIndex = 1
    '
    'cboSeccion
    '
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(90, 44)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(250, 25)
    Me.cboSeccion.TabIndex = 3
    '
    'dtpFecha
    '
    Me.dtpFecha.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFecha.Location = New System.Drawing.Point(408, 42)
    Me.dtpFecha.Name = "dtpFecha"
    Me.dtpFecha.Size = New System.Drawing.Size(163, 25)
    Me.dtpFecha.TabIndex = 5
    Me.dtpFecha.Value = New Date(2010, 4, 27, 0, 0, 0, 0)
    '
    'btnListar
    '
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.btnListar.Location = New System.Drawing.Point(675, 37)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(96, 35)
    Me.btnListar.TabIndex = 6
    Me.btnListar.Text = "&Listar"
    Me.btnListar.UseVisualStyleBackColor = False
    '
    'dgvAsistencia
    '
    Me.dgvAsistencia.AllowUserToAddRows = False
    Me.dgvAsistencia.AllowUserToDeleteRows = False
    Me.dgvAsistencia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvAsistencia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNro, Me.cdAlumno, Me.cdSituacion, Me.cdJustificado})
    Me.dgvAsistencia.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
    Me.dgvAsistencia.Location = New System.Drawing.Point(6, 19)
    Me.dgvAsistencia.MultiSelect = False
    Me.dgvAsistencia.Name = "dgvAsistencia"
    Me.dgvAsistencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvAsistencia.Size = New System.Drawing.Size(553, 528)
    Me.dgvAsistencia.TabIndex = 0
    '
    'gbAsistencia
    '
    Me.gbAsistencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.gbAsistencia.Controls.Add(Me.btnJustificar)
    Me.gbAsistencia.Controls.Add(Me.btnRegistrar)
    Me.gbAsistencia.Controls.Add(Me.dgvAsistencia)
    Me.gbAsistencia.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbAsistencia.Location = New System.Drawing.Point(12, 72)
    Me.gbAsistencia.Name = "gbAsistencia"
    Me.gbAsistencia.Size = New System.Drawing.Size(565, 608)
    Me.gbAsistencia.TabIndex = 7
    Me.gbAsistencia.TabStop = False
    Me.gbAsistencia.Text = "Registro de Asistencia"
    '
    'btnJustificar
    '
    Me.btnJustificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnJustificar.BackColor = System.Drawing.Color.White
    Me.btnJustificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnJustificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnJustificar.Location = New System.Drawing.Point(449, 552)
    Me.btnJustificar.Name = "btnJustificar"
    Me.btnJustificar.Size = New System.Drawing.Size(110, 50)
    Me.btnJustificar.TabIndex = 2
    Me.btnJustificar.Text = "&Justificar"
    Me.btnJustificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnJustificar.UseVisualStyleBackColor = False
    Me.btnJustificar.Visible = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(6, 552)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 50)
    Me.btnRegistrar.TabIndex = 1
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    Me.btnRegistrar.Visible = False
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(834, 628)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 9
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'cboPadre
    '
    Me.cboPadre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboPadre.FormattingEnabled = True
    Me.cboPadre.Location = New System.Drawing.Point(68, 74)
    Me.cboPadre.Name = "cboPadre"
    Me.cboPadre.Size = New System.Drawing.Size(274, 25)
    Me.cboPadre.TabIndex = 3
    '
    'lblPadre
    '
    Me.lblPadre.AutoSize = True
    Me.lblPadre.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPadre.Location = New System.Drawing.Point(6, 75)
    Me.lblPadre.Name = "lblPadre"
    Me.lblPadre.Size = New System.Drawing.Size(43, 17)
    Me.lblPadre.TabIndex = 2
    Me.lblPadre.Text = "&Padre"
    '
    'lbldetalle
    '
    Me.lbldetalle.AutoSize = True
    Me.lbldetalle.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lbldetalle.Location = New System.Drawing.Point(6, 121)
    Me.lbldetalle.Name = "lbldetalle"
    Me.lbldetalle.Size = New System.Drawing.Size(50, 17)
    Me.lbldetalle.TabIndex = 4
    Me.lbldetalle.Text = "&Detalle"
    '
    'txtDesc
    '
    Me.txtDesc.Location = New System.Drawing.Point(68, 116)
    Me.txtDesc.Multiline = True
    Me.txtDesc.Name = "txtDesc"
    Me.txtDesc.Size = New System.Drawing.Size(274, 91)
    Me.txtDesc.TabIndex = 5
    '
    'dtpFechaJust
    '
    Me.dtpFechaJust.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaJust.Location = New System.Drawing.Point(68, 32)
    Me.dtpFechaJust.Name = "dtpFechaJust"
    Me.dtpFechaJust.Size = New System.Drawing.Size(137, 25)
    Me.dtpFechaJust.TabIndex = 1
    Me.dtpFechaJust.Value = New Date(2010, 4, 27, 0, 0, 0, 0)
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(6, 35)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(44, 17)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "&Fecha"
    '
    'gbJustificacion
    '
    Me.gbJustificacion.Controls.Add(Me.btnCancelar)
    Me.gbJustificacion.Controls.Add(Me.btnRegJust)
    Me.gbJustificacion.Controls.Add(Me.dtpFechaJust)
    Me.gbJustificacion.Controls.Add(Me.lblPadre)
    Me.gbJustificacion.Controls.Add(Me.Label1)
    Me.gbJustificacion.Controls.Add(Me.cboPadre)
    Me.gbJustificacion.Controls.Add(Me.txtDesc)
    Me.gbJustificacion.Controls.Add(Me.lbldetalle)
    Me.gbJustificacion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.gbJustificacion.Location = New System.Drawing.Point(584, 213)
    Me.gbJustificacion.Name = "gbJustificacion"
    Me.gbJustificacion.Size = New System.Drawing.Size(366, 295)
    Me.gbJustificacion.TabIndex = 8
    Me.gbJustificacion.TabStop = False
    Me.gbJustificacion.Text = "Justificación"
    Me.gbJustificacion.Visible = False
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(232, 227)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
    Me.btnCancelar.TabIndex = 7
    Me.btnCancelar.Text = "Canc&elar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnRegJust
    '
    Me.btnRegJust.BackColor = System.Drawing.Color.White
    Me.btnRegJust.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegJust.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegJust.Location = New System.Drawing.Point(115, 227)
    Me.btnRegJust.Name = "btnRegJust"
    Me.btnRegJust.Size = New System.Drawing.Size(110, 52)
    Me.btnRegJust.TabIndex = 6
    Me.btnRegJust.Text = "&Guardar"
    Me.btnRegJust.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegJust.UseVisualStyleBackColor = False
    '
    'gbLeyenda
    '
    Me.gbLeyenda.Controls.Add(Me.Label3)
    Me.gbLeyenda.Controls.Add(Me.Label2)
    Me.gbLeyenda.Controls.Add(Me.Panel2)
    Me.gbLeyenda.Controls.Add(Me.Panel1)
    Me.gbLeyenda.Controls.Add(Me.lblFalta)
    Me.gbLeyenda.Location = New System.Drawing.Point(584, 73)
    Me.gbLeyenda.Name = "gbLeyenda"
    Me.gbLeyenda.Size = New System.Drawing.Size(366, 123)
    Me.gbLeyenda.TabIndex = 9
    Me.gbLeyenda.TabStop = False
    Me.gbLeyenda.Text = "Leyenda"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(11, 91)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(70, 15)
    Me.Label3.TabIndex = 12
    Me.Label3.Text = "Justificada"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(11, 75)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(102, 15)
    Me.Label2.TabIndex = 11
    Me.Label2.Text = "Falta o Tardanza "
    '
    'Panel2
    '
    Me.Panel2.BackColor = System.Drawing.Color.GreenYellow
    Me.Panel2.Location = New System.Drawing.Point(115, 80)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(245, 26)
    Me.Panel2.TabIndex = 10
    '
    'Panel1
    '
    Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
    Me.Panel1.Location = New System.Drawing.Point(115, 25)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(245, 26)
    Me.Panel1.TabIndex = 8
    '
    'lblFalta
    '
    Me.lblFalta.AutoSize = True
    Me.lblFalta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFalta.Location = New System.Drawing.Point(11, 31)
    Me.lblFalta.Name = "lblFalta"
    Me.lblFalta.Size = New System.Drawing.Size(99, 15)
    Me.lblFalta.TabIndex = 9
    Me.lblFalta.Text = "Falta o Tardanza"
    '
    'txtTotal
    '
    Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.txtTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTotal.Location = New System.Drawing.Point(631, 595)
    Me.txtTotal.Multiline = True
    Me.txtTotal.Name = "txtTotal"
    Me.txtTotal.ReadOnly = True
    Me.txtTotal.Size = New System.Drawing.Size(34, 24)
    Me.txtTotal.TabIndex = 13
    '
    'Label4
    '
    Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(581, 599)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(44, 15)
    Me.Label4.TabIndex = 12
    Me.Label4.Text = "Total : "
    '
    'cdNro
    '
    Me.cdNro.DataPropertyName = "NroOrden"
    Me.cdNro.HeaderText = "N°"
    Me.cdNro.Name = "cdNro"
    Me.cdNro.Width = 35
    '
    'cdAlumno
    '
    Me.cdAlumno.DataPropertyName = "NombreAlumno"
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.Width = 250
    '
    'cdSituacion
    '
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    Me.cdSituacion.DefaultCellStyle = DataGridViewCellStyle1
    Me.cdSituacion.HeaderText = "Situación"
    Me.cdSituacion.Name = "cdSituacion"
    Me.cdSituacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.cdSituacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.cdSituacion.Width = 130
    '
    'cdJustificado
    '
    Me.cdJustificado.HeaderText = "Justif."
    Me.cdJustificado.Name = "cdJustificado"
    Me.cdJustificado.ReadOnly = True
    Me.cdJustificado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.cdJustificado.Width = 50
    '
    'frmGestionAsistencia
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(962, 687)
    Me.Controls.Add(Me.txtTotal)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.gbLeyenda)
    Me.Controls.Add(Me.gbJustificacion)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.gbAsistencia)
    Me.Controls.Add(Me.btnListar)
    Me.Controls.Add(Me.dtpFecha)
    Me.Controls.Add(Me.cboSeccion)
    Me.Controls.Add(Me.txtAnio)
    Me.Controls.Add(Me.lblFecha)
    Me.Controls.Add(Me.lblSeccion)
    Me.Controls.Add(Me.lblAnio)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Name = "frmGestionAsistencia"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de Asistencia"
    CType(Me.dgvAsistencia, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbAsistencia.ResumeLayout(False)
    Me.gbJustificacion.ResumeLayout(False)
    Me.gbJustificacion.PerformLayout()
    Me.gbLeyenda.ResumeLayout(False)
    Me.gbLeyenda.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents lblFecha As System.Windows.Forms.Label
  Friend WithEvents txtAnio As System.Windows.Forms.TextBox
  Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents dgvAsistencia As System.Windows.Forms.DataGridView
  Friend WithEvents gbAsistencia As System.Windows.Forms.GroupBox
  Friend WithEvents btnJustificar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents cboPadre As System.Windows.Forms.ComboBox
  Friend WithEvents lblPadre As System.Windows.Forms.Label
  Friend WithEvents lbldetalle As System.Windows.Forms.Label
  Friend WithEvents dtpFechaJust As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtDesc As System.Windows.Forms.TextBox
  Friend WithEvents gbJustificacion As System.Windows.Forms.GroupBox
  Friend WithEvents btnRegJust As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents gbLeyenda As System.Windows.Forms.GroupBox
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents lblFalta As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtTotal As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents cdNro As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdSituacion As System.Windows.Forms.DataGridViewComboBoxColumn
  Friend WithEvents cdJustificado As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
