<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionProgLectura
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
    Me.cboSeccion = New System.Windows.Forms.ComboBox()
    Me.txtAnio = New System.Windows.Forms.TextBox()
    Me.lblSeccion = New System.Windows.Forms.Label()
    Me.lblAnio = New System.Windows.Forms.Label()
    Me.dgvAlumnos = New System.Windows.Forms.DataGridView()
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.btnRegistrar = New System.Windows.Forms.Button()
    Me.GBSeccion = New System.Windows.Forms.GroupBox()
    Me.cboNivel = New System.Windows.Forms.ComboBox()
    Me.lblNivel = New System.Windows.Forms.Label()
    Me.lblPresentacion = New System.Windows.Forms.Label()
    Me.btnListar = New System.Windows.Forms.Button()
    Me.cboPresentacion = New System.Windows.Forms.ComboBox()
    Me.btnExportar = New System.Windows.Forms.Button()
    Me.btnImportar = New System.Windows.Forms.Button()
    CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GBSeccion.SuspendLayout()
    Me.SuspendLayout()
    '
    'cboSeccion
    '
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(330, 36)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(223, 25)
    Me.cboSeccion.TabIndex = 4
    '
    'txtAnio
    '
    Me.txtAnio.BackColor = System.Drawing.Color.White
    Me.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.txtAnio.Location = New System.Drawing.Point(48, 48)
    Me.txtAnio.Name = "txtAnio"
    Me.txtAnio.ReadOnly = True
    Me.txtAnio.Size = New System.Drawing.Size(80, 25)
    Me.txtAnio.TabIndex = 1
    Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSeccion.Location = New System.Drawing.Point(327, 16)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(49, 15)
    Me.lblSeccion.TabIndex = 3
    Me.lblSeccion.Text = "&Sección"
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblAnio.Location = New System.Drawing.Point(9, 56)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(33, 17)
    Me.lblAnio.TabIndex = 0
    Me.lblAnio.Text = "&Año"
    '
    'dgvAlumnos
    '
    Me.dgvAlumnos.AllowUserToAddRows = False
    Me.dgvAlumnos.AllowUserToDeleteRows = False
    Me.dgvAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdAlumno})
    Me.dgvAlumnos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
    Me.dgvAlumnos.Location = New System.Drawing.Point(12, 127)
    Me.dgvAlumnos.MultiSelect = False
    Me.dgvAlumnos.Name = "dgvAlumnos"
    Me.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvAlumnos.Size = New System.Drawing.Size(716, 273)
    Me.dgvAlumnos.TabIndex = 1
    '
    'cdAlumno
    '
    Me.cdAlumno.DataPropertyName = "Alumno"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    Me.cdAlumno.DefaultCellStyle = DataGridViewCellStyle1
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.ReadOnly = True
    Me.cdAlumno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    Me.cdAlumno.Width = 285
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(618, 411)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 5
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(502, 411)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
    Me.btnRegistrar.TabIndex = 4
    Me.btnRegistrar.Text = "&Asignar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'GBSeccion
    '
    Me.GBSeccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GBSeccion.Controls.Add(Me.cboNivel)
    Me.GBSeccion.Controls.Add(Me.lblNivel)
    Me.GBSeccion.Controls.Add(Me.lblAnio)
    Me.GBSeccion.Controls.Add(Me.lblPresentacion)
    Me.GBSeccion.Controls.Add(Me.lblSeccion)
    Me.GBSeccion.Controls.Add(Me.btnListar)
    Me.GBSeccion.Controls.Add(Me.txtAnio)
    Me.GBSeccion.Controls.Add(Me.cboPresentacion)
    Me.GBSeccion.Controls.Add(Me.cboSeccion)
    Me.GBSeccion.Location = New System.Drawing.Point(12, 12)
    Me.GBSeccion.Name = "GBSeccion"
    Me.GBSeccion.Size = New System.Drawing.Size(716, 103)
    Me.GBSeccion.TabIndex = 0
    Me.GBSeccion.TabStop = False
    '
    'cboNivel
    '
    Me.cboNivel.BackColor = System.Drawing.SystemColors.Info
    Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNivel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Location = New System.Drawing.Point(165, 37)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(145, 24)
    Me.cboNivel.TabIndex = 2
    '
    'lblNivel
    '
    Me.lblNivel.AutoSize = True
    Me.lblNivel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNivel.Location = New System.Drawing.Point(162, 16)
    Me.lblNivel.Name = "lblNivel"
    Me.lblNivel.Size = New System.Drawing.Size(35, 15)
    Me.lblNivel.TabIndex = 1
    Me.lblNivel.Text = "&Nivel"
    '
    'lblPresentacion
    '
    Me.lblPresentacion.AutoSize = True
    Me.lblPresentacion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblPresentacion.Location = New System.Drawing.Point(226, 79)
    Me.lblPresentacion.Name = "lblPresentacion"
    Me.lblPresentacion.Size = New System.Drawing.Size(84, 17)
    Me.lblPresentacion.TabIndex = 5
    Me.lblPresentacion.Text = "&Presentación"
    '
    'btnListar
    '
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnListar.Location = New System.Drawing.Point(566, 44)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(110, 52)
    Me.btnListar.TabIndex = 7
    Me.btnListar.Text = "&Listar"
    Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnListar.UseVisualStyleBackColor = False
    '
    'cboPresentacion
    '
    Me.cboPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboPresentacion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.cboPresentacion.FormattingEnabled = True
    Me.cboPresentacion.Location = New System.Drawing.Point(330, 69)
    Me.cboPresentacion.Name = "cboPresentacion"
    Me.cboPresentacion.Size = New System.Drawing.Size(132, 25)
    Me.cboPresentacion.TabIndex = 6
    '
    'btnExportar
    '
    Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnExportar.BackColor = System.Drawing.Color.White
    Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnExportar.Location = New System.Drawing.Point(386, 411)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(110, 52)
    Me.btnExportar.TabIndex = 3
    Me.btnExportar.Text = "E&xportar"
    Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnExportar.UseVisualStyleBackColor = False
    '
    'btnImportar
    '
    Me.btnImportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnImportar.BackColor = System.Drawing.Color.White
    Me.btnImportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnImportar.Location = New System.Drawing.Point(270, 411)
    Me.btnImportar.Name = "btnImportar"
    Me.btnImportar.Size = New System.Drawing.Size(110, 52)
    Me.btnImportar.TabIndex = 2
    Me.btnImportar.Text = "&Importar"
    Me.btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnImportar.UseVisualStyleBackColor = False
    '
    'frmGestionProgLectura
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(740, 465)
    Me.Controls.Add(Me.dgvAlumnos)
    Me.Controls.Add(Me.GBSeccion)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnImportar)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.MinimizeBox = False
    Me.Name = "frmGestionProgLectura"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Programación de lecturas"
    CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GBSeccion.ResumeLayout(False)
    Me.GBSeccion.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents txtAnio As System.Windows.Forms.TextBox
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents dgvAlumnos As System.Windows.Forms.DataGridView
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents GBSeccion As System.Windows.Forms.GroupBox
  Friend WithEvents lblPresentacion As System.Windows.Forms.Label
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents cboPresentacion As System.Windows.Forms.ComboBox
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents lblNivel As System.Windows.Forms.Label
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents btnImportar As System.Windows.Forms.Button
End Class
