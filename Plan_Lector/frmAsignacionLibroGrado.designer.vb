<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignacionLibroGrado
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GBSeccion = New System.Windows.Forms.GroupBox()
        Me.lblDocente = New System.Windows.Forms.Label()
        Me.cboDocente = New System.Windows.Forms.ComboBox()
        Me.chkVigencia = New System.Windows.Forms.CheckBox()
        Me.cboLibro = New System.Windows.Forms.ComboBox()
        Me.cboResponsable = New System.Windows.Forms.ComboBox()
        Me.lblResponsable = New System.Windows.Forms.Label()
        Me.cboGrado = New System.Windows.Forms.ComboBox()
        Me.lblSeccion = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAnio = New System.Windows.Forms.Label()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.dgvLibros = New System.Windows.Forms.DataGridView()
        Me.cdNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdResponsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cdVigencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBLibros = New System.Windows.Forms.GroupBox()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.cboGradoBuscar = New System.Windows.Forms.ComboBox()
        Me.lblGradoBuscar = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.ErrLibro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cboNivel = New System.Windows.Forms.ComboBox()
        Me.lblNivel = New System.Windows.Forms.Label()
        Me.GBSeccion.SuspendLayout()
        CType(Me.dgvLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBLibros.SuspendLayout()
        CType(Me.ErrLibro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBSeccion
        '
        Me.GBSeccion.Controls.Add(Me.lblDocente)
        Me.GBSeccion.Controls.Add(Me.cboDocente)
        Me.GBSeccion.Controls.Add(Me.chkVigencia)
        Me.GBSeccion.Controls.Add(Me.cboLibro)
        Me.GBSeccion.Controls.Add(Me.cboResponsable)
        Me.GBSeccion.Controls.Add(Me.lblResponsable)
        Me.GBSeccion.Controls.Add(Me.cboGrado)
        Me.GBSeccion.Controls.Add(Me.lblSeccion)
        Me.GBSeccion.Controls.Add(Me.btnRegistrar)
        Me.GBSeccion.Controls.Add(Me.btnCancelar)
        Me.GBSeccion.Controls.Add(Me.Label1)
        Me.GBSeccion.Location = New System.Drawing.Point(26, 63)
        Me.GBSeccion.Name = "GBSeccion"
        Me.GBSeccion.Size = New System.Drawing.Size(422, 310)
        Me.GBSeccion.TabIndex = 4
        Me.GBSeccion.TabStop = False
        '
        'lblDocente
        '
        Me.lblDocente.AutoSize = True
        Me.lblDocente.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.lblDocente.Location = New System.Drawing.Point(11, 157)
        Me.lblDocente.Name = "lblDocente"
        Me.lblDocente.Size = New System.Drawing.Size(58, 17)
        Me.lblDocente.TabIndex = 6
        Me.lblDocente.Text = "&Docente"
        '
        'cboDocente
        '
        Me.cboDocente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDocente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDocente.BackColor = System.Drawing.SystemColors.Window
        Me.cboDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDocente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDocente.FormattingEnabled = True
        Me.cboDocente.Location = New System.Drawing.Point(75, 150)
        Me.cboDocente.Name = "cboDocente"
        Me.cboDocente.Size = New System.Drawing.Size(341, 24)
        Me.cboDocente.TabIndex = 7
        '
        'chkVigencia
        '
        Me.chkVigencia.AutoSize = True
        Me.chkVigencia.Location = New System.Drawing.Point(14, 208)
        Me.chkVigencia.Name = "chkVigencia"
        Me.chkVigencia.Size = New System.Drawing.Size(61, 19)
        Me.chkVigencia.TabIndex = 8
        Me.chkVigencia.Text = "&Vigente"
        Me.chkVigencia.UseVisualStyleBackColor = True
        Me.chkVigencia.Visible = False
        '
        'cboLibro
        '
        Me.cboLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLibro.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.cboLibro.FormattingEnabled = True
        Me.cboLibro.Location = New System.Drawing.Point(61, 59)
        Me.cboLibro.Name = "cboLibro"
        Me.cboLibro.Size = New System.Drawing.Size(355, 25)
        Me.cboLibro.TabIndex = 3
        '
        'cboResponsable
        '
        Me.cboResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboResponsable.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.cboResponsable.FormattingEnabled = True
        Me.cboResponsable.Items.AddRange(New Object() {"Docente", "Tutor del aula"})
        Me.cboResponsable.Location = New System.Drawing.Point(99, 102)
        Me.cboResponsable.Name = "cboResponsable"
        Me.cboResponsable.Size = New System.Drawing.Size(147, 25)
        Me.cboResponsable.TabIndex = 5
        '
        'lblResponsable
        '
        Me.lblResponsable.AutoSize = True
        Me.lblResponsable.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.lblResponsable.Location = New System.Drawing.Point(11, 110)
        Me.lblResponsable.Name = "lblResponsable"
        Me.lblResponsable.Size = New System.Drawing.Size(82, 17)
        Me.lblResponsable.TabIndex = 4
        Me.lblResponsable.Text = "Res&ponsable"
        '
        'cboGrado
        '
        Me.cboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrado.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.cboGrado.FormattingEnabled = True
        Me.cboGrado.Location = New System.Drawing.Point(61, 20)
        Me.cboGrado.Name = "cboGrado"
        Me.cboGrado.Size = New System.Drawing.Size(147, 25)
        Me.cboGrado.TabIndex = 1
        '
        'lblSeccion
        '
        Me.lblSeccion.AutoSize = True
        Me.lblSeccion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.lblSeccion.Location = New System.Drawing.Point(11, 28)
        Me.lblSeccion.Name = "lblSeccion"
        Me.lblSeccion.Size = New System.Drawing.Size(44, 17)
        Me.lblSeccion.TabIndex = 0
        Me.lblSeccion.Text = "&Grado"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.White
        Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrar.Location = New System.Drawing.Point(190, 243)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
        Me.btnRegistrar.TabIndex = 9
        Me.btnRegistrar.Text = "&Registrar"
        Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(306, 243)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(11, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "&Libro"
        '
        'lblAnio
        '
        Me.lblAnio.AutoSize = True
        Me.lblAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.lblAnio.Location = New System.Drawing.Point(23, 41)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(36, 17)
        Me.lblAnio.TabIndex = 0
        Me.lblAnio.Text = "&Anio"
        '
        'txtAnio
        '
        Me.txtAnio.BackColor = System.Drawing.Color.White
        Me.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.txtAnio.Location = New System.Drawing.Point(73, 32)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.ReadOnly = True
        Me.txtAnio.Size = New System.Drawing.Size(100, 25)
        Me.txtAnio.TabIndex = 1
        Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvLibros
        '
        Me.dgvLibros.AllowUserToAddRows = False
        Me.dgvLibros.AllowUserToDeleteRows = False
        Me.dgvLibros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLibros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLibros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNombre, Me.cdResponsable, Me.cdVigencia})
        Me.dgvLibros.Location = New System.Drawing.Point(7, 79)
        Me.dgvLibros.MultiSelect = False
        Me.dgvLibros.Name = "dgvLibros"
        Me.dgvLibros.ReadOnly = True
        Me.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLibros.Size = New System.Drawing.Size(462, 258)
        Me.dgvLibros.TabIndex = 3
        '
        'cdNombre
        '
        Me.cdNombre.DataPropertyName = "NombreLibro"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdNombre.DefaultCellStyle = DataGridViewCellStyle2
        Me.cdNombre.HeaderText = "Libro"
        Me.cdNombre.Name = "cdNombre"
        Me.cdNombre.ReadOnly = True
        Me.cdNombre.Width = 250
        '
        'cdResponsable
        '
        Me.cdResponsable.DataPropertyName = "NombreDocente"
        Me.cdResponsable.HeaderText = "Responsable"
        Me.cdResponsable.Name = "cdResponsable"
        Me.cdResponsable.ReadOnly = True
        Me.cdResponsable.Width = 170
        '
        'cdVigencia
        '
        Me.cdVigencia.DataPropertyName = "NombreVigencia"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdVigencia.DefaultCellStyle = DataGridViewCellStyle3
        Me.cdVigencia.HeaderText = "Vigente"
        Me.cdVigencia.Name = "cdVigencia"
        Me.cdVigencia.ReadOnly = True
        Me.cdVigencia.Width = 60
        '
        'GBLibros
        '
        Me.GBLibros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GBLibros.Controls.Add(Me.btnListar)
        Me.GBLibros.Controls.Add(Me.cboGradoBuscar)
        Me.GBLibros.Controls.Add(Me.lblGradoBuscar)
        Me.GBLibros.Controls.Add(Me.btnModificar)
        Me.GBLibros.Controls.Add(Me.dgvLibros)
        Me.GBLibros.Location = New System.Drawing.Point(457, 12)
        Me.GBLibros.Name = "GBLibros"
        Me.GBLibros.Size = New System.Drawing.Size(475, 401)
        Me.GBLibros.TabIndex = 5
        Me.GBLibros.TabStop = False
        Me.GBLibros.Text = "Libros asignados"
        '
        'btnListar
        '
        Me.btnListar.BackColor = System.Drawing.Color.White
        Me.btnListar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListar.Location = New System.Drawing.Point(359, 18)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(110, 52)
        Me.btnListar.TabIndex = 2
        Me.btnListar.Text = "&Listar"
        Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnListar.UseVisualStyleBackColor = False
        '
        'cboGradoBuscar
        '
        Me.cboGradoBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGradoBuscar.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.cboGradoBuscar.FormattingEnabled = True
        Me.cboGradoBuscar.Location = New System.Drawing.Point(72, 33)
        Me.cboGradoBuscar.Name = "cboGradoBuscar"
        Me.cboGradoBuscar.Size = New System.Drawing.Size(269, 25)
        Me.cboGradoBuscar.TabIndex = 1
        '
        'lblGradoBuscar
        '
        Me.lblGradoBuscar.AutoSize = True
        Me.lblGradoBuscar.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.lblGradoBuscar.Location = New System.Drawing.Point(13, 41)
        Me.lblGradoBuscar.Name = "lblGradoBuscar"
        Me.lblGradoBuscar.Size = New System.Drawing.Size(44, 17)
        Me.lblGradoBuscar.TabIndex = 0
        Me.lblGradoBuscar.Text = "Grado"
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.BackColor = System.Drawing.Color.White
        Me.btnModificar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(7, 343)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(110, 52)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(822, 419)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'ErrLibro
        '
        Me.ErrLibro.ContainerControl = Me
        '
        'cboNivel
        '
        Me.cboNivel.BackColor = System.Drawing.SystemColors.Info
        Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNivel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNivel.FormattingEnabled = True
        Me.cboNivel.Location = New System.Drawing.Point(254, 33)
        Me.cboNivel.Name = "cboNivel"
        Me.cboNivel.Size = New System.Drawing.Size(194, 24)
        Me.cboNivel.TabIndex = 3
        '
        'lblNivel
        '
        Me.lblNivel.AutoSize = True
        Me.lblNivel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNivel.Location = New System.Drawing.Point(213, 42)
        Me.lblNivel.Name = "lblNivel"
        Me.lblNivel.Size = New System.Drawing.Size(35, 15)
        Me.lblNivel.TabIndex = 2
        Me.lblNivel.Text = "&Nivel"
        '
        'frmAsignacionLibroGrado
        '
        Me.AcceptButton = Me.btnRegistrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(944, 483)
        Me.Controls.Add(Me.cboNivel)
        Me.Controls.Add(Me.lblNivel)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GBLibros)
        Me.Controls.Add(Me.GBSeccion)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.lblAnio)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmAsignacionLibroGrado"
        Me.ShowInTaskbar = False
        Me.Text = "Asignación de libro por grado"
        Me.GBSeccion.ResumeLayout(False)
        Me.GBSeccion.PerformLayout()
        CType(Me.dgvLibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBLibros.ResumeLayout(False)
        Me.GBLibros.PerformLayout()
        CType(Me.ErrLibro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
  Friend WithEvents GBSeccion As System.Windows.Forms.GroupBox
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents txtAnio As System.Windows.Forms.TextBox
  Friend WithEvents cboGrado As System.Windows.Forms.ComboBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cboLibro As System.Windows.Forms.ComboBox
  Friend WithEvents dgvLibros As System.Windows.Forms.DataGridView
  Friend WithEvents GBLibros As System.Windows.Forms.GroupBox
  Friend WithEvents chkVigencia As System.Windows.Forms.CheckBox
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnModificar As System.Windows.Forms.Button
  Friend WithEvents ErrLibro As System.Windows.Forms.ErrorProvider
  Friend WithEvents lblDocente As System.Windows.Forms.Label
  Friend WithEvents cboDocente As System.Windows.Forms.ComboBox
  Friend WithEvents cdNombre As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdResponsable As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdVigencia As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents cboGradoBuscar As System.Windows.Forms.ComboBox
  Friend WithEvents lblGradoBuscar As System.Windows.Forms.Label
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents lblNivel As System.Windows.Forms.Label
  Friend WithEvents cboResponsable As System.Windows.Forms.ComboBox
  Friend WithEvents lblResponsable As System.Windows.Forms.Label
End Class
