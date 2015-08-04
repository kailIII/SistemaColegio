<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionIndicadoresGrupal
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
    Me.components = New System.ComponentModel.Container()
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.txtPeriodo = New System.Windows.Forms.TextBox()
    Me.lblPeriodo = New System.Windows.Forms.Label()
    Me.lblCurso = New System.Windows.Forms.Label()
    Me.cboCurso = New System.Windows.Forms.ComboBox()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.dgvCriterios = New System.Windows.Forms.DataGridView()
    Me.cdCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdNro = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdCriterio = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdVigencia = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.btnRegistrar = New System.Windows.Forms.Button()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.GBindicador = New System.Windows.Forms.GroupBox()
    Me.chkVigencia = New System.Windows.Forms.CheckBox()
    Me.txtNombre = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.btncancelar = New System.Windows.Forms.Button()
    Me.btnEditar = New System.Windows.Forms.Button()
    Me.ErrIndicador = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.lblSeccion = New System.Windows.Forms.Label()
    Me.cboSeccion = New System.Windows.Forms.ComboBox()
    Me.txtDocente = New System.Windows.Forms.TextBox()
    Me.lblDocente = New System.Windows.Forms.Label()
    Me.btnOrdenar = New System.Windows.Forms.Button()
    Me.btnbajar = New System.Windows.Forms.Button()
    Me.btnSubir = New System.Windows.Forms.Button()
    Me.GroupBox1.SuspendLayout()
    CType(Me.dgvCriterios, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GBindicador.SuspendLayout()
    CType(Me.ErrIndicador, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtPeriodo
    '
    Me.txtPeriodo.Location = New System.Drawing.Point(77, 17)
    Me.txtPeriodo.Name = "txtPeriodo"
    Me.txtPeriodo.ReadOnly = True
    Me.txtPeriodo.Size = New System.Drawing.Size(168, 20)
    Me.txtPeriodo.TabIndex = 1
    Me.txtPeriodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'lblPeriodo
    '
    Me.lblPeriodo.AutoSize = True
    Me.lblPeriodo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPeriodo.Location = New System.Drawing.Point(19, 21)
    Me.lblPeriodo.Name = "lblPeriodo"
    Me.lblPeriodo.Size = New System.Drawing.Size(48, 15)
    Me.lblPeriodo.TabIndex = 0
    Me.lblPeriodo.Text = "&Periodo"
    '
    'lblCurso
    '
    Me.lblCurso.AutoSize = True
    Me.lblCurso.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCurso.Location = New System.Drawing.Point(19, 94)
    Me.lblCurso.Name = "lblCurso"
    Me.lblCurso.Size = New System.Drawing.Size(39, 15)
    Me.lblCurso.TabIndex = 4
    Me.lblCurso.Text = "&Curso"
    '
    'cboCurso
    '
    Me.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCurso.FormattingEnabled = True
    Me.cboCurso.Location = New System.Drawing.Point(77, 88)
    Me.cboCurso.Name = "cboCurso"
    Me.cboCurso.Size = New System.Drawing.Size(344, 21)
    Me.cboCurso.TabIndex = 5
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.dgvCriterios)
    Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.GroupBox1.Location = New System.Drawing.Point(19, 249)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(851, 303)
    Me.GroupBox1.TabIndex = 12
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Lista de Indicadores"
    '
    'dgvCriterios
    '
    Me.dgvCriterios.AllowUserToAddRows = False
    Me.dgvCriterios.AllowUserToDeleteRows = False
    Me.dgvCriterios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvCriterios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdCodigo, Me.cdNro, Me.cdCriterio, Me.cdVigencia})
    Me.dgvCriterios.Location = New System.Drawing.Point(3, 21)
    Me.dgvCriterios.MultiSelect = False
    Me.dgvCriterios.Name = "dgvCriterios"
    Me.dgvCriterios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvCriterios.Size = New System.Drawing.Size(842, 276)
    Me.dgvCriterios.TabIndex = 0
    '
    'cdCodigo
    '
    Me.cdCodigo.DataPropertyName = "Codigo"
    Me.cdCodigo.HeaderText = "Codigo"
    Me.cdCodigo.Name = "cdCodigo"
    Me.cdCodigo.Visible = False
    '
    'cdNro
    '
    Me.cdNro.DataPropertyName = "Nro"
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
    Me.cdNro.DefaultCellStyle = DataGridViewCellStyle1
    Me.cdNro.HeaderText = "Nro"
    Me.cdNro.Name = "cdNro"
    Me.cdNro.Width = 33
    '
    'cdCriterio
    '
    Me.cdCriterio.DataPropertyName = "Nombre"
    Me.cdCriterio.HeaderText = "Indicador"
    Me.cdCriterio.Name = "cdCriterio"
    Me.cdCriterio.ReadOnly = True
    Me.cdCriterio.Width = 690
    '
    'cdVigencia
    '
    Me.cdVigencia.DataPropertyName = "Vigencia"
    Me.cdVigencia.HeaderText = "Vigente"
    Me.cdVigencia.Name = "cdVigencia"
    Me.cdVigencia.ReadOnly = True
    Me.cdVigencia.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.cdVigencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.cdVigencia.Width = 70
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(760, 68)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
    Me.btnRegistrar.TabIndex = 9
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(760, 558)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 13
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'GBindicador
    '
    Me.GBindicador.Controls.Add(Me.chkVigencia)
    Me.GBindicador.Controls.Add(Me.txtNombre)
    Me.GBindicador.Controls.Add(Me.Label2)
    Me.GBindicador.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.GBindicador.Location = New System.Drawing.Point(22, 120)
    Me.GBindicador.Name = "GBindicador"
    Me.GBindicador.Size = New System.Drawing.Size(732, 123)
    Me.GBindicador.TabIndex = 8
    Me.GBindicador.TabStop = False
    Me.GBindicador.Text = "Indicador"
    '
    'chkVigencia
    '
    Me.chkVigencia.AutoSize = True
    Me.chkVigencia.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.chkVigencia.Location = New System.Drawing.Point(65, 100)
    Me.chkVigencia.Name = "chkVigencia"
    Me.chkVigencia.Size = New System.Drawing.Size(71, 19)
    Me.chkVigencia.TabIndex = 2
    Me.chkVigencia.Text = "&Vigencia"
    Me.chkVigencia.UseVisualStyleBackColor = True
    Me.chkVigencia.Visible = False
    '
    'txtNombre
    '
    Me.txtNombre.Location = New System.Drawing.Point(65, 22)
    Me.txtNombre.Multiline = True
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Size = New System.Drawing.Size(661, 72)
    Me.txtNombre.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(10, 42)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(49, 15)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Nombre"
    '
    'btncancelar
    '
    Me.btncancelar.BackColor = System.Drawing.Color.White
    Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btncancelar.Location = New System.Drawing.Point(760, 191)
    Me.btncancelar.Name = "btncancelar"
    Me.btncancelar.Size = New System.Drawing.Size(110, 52)
    Me.btncancelar.TabIndex = 11
    Me.btncancelar.Text = "Ca&ncelar"
    Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btncancelar.UseVisualStyleBackColor = False
    '
    'btnEditar
    '
    Me.btnEditar.BackColor = System.Drawing.Color.White
    Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnEditar.Location = New System.Drawing.Point(760, 126)
    Me.btnEditar.Name = "btnEditar"
    Me.btnEditar.Size = New System.Drawing.Size(110, 52)
    Me.btnEditar.TabIndex = 10
    Me.btnEditar.Text = "&Editar"
    Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnEditar.UseVisualStyleBackColor = False
    '
    'ErrIndicador
    '
    Me.ErrIndicador.ContainerControl = Me
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Location = New System.Drawing.Point(19, 61)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(46, 13)
    Me.lblSeccion.TabIndex = 2
    Me.lblSeccion.Text = "&Sección"
    '
    'cboSeccion
    '
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(77, 50)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(153, 24)
    Me.cboSeccion.TabIndex = 3
    '
    'txtDocente
    '
    Me.txtDocente.Location = New System.Drawing.Point(481, 92)
    Me.txtDocente.Name = "txtDocente"
    Me.txtDocente.ReadOnly = True
    Me.txtDocente.Size = New System.Drawing.Size(273, 20)
    Me.txtDocente.TabIndex = 7
    '
    'lblDocente
    '
    Me.lblDocente.AutoSize = True
    Me.lblDocente.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDocente.Location = New System.Drawing.Point(427, 96)
    Me.lblDocente.Name = "lblDocente"
    Me.lblDocente.Size = New System.Drawing.Size(52, 15)
    Me.lblDocente.TabIndex = 6
    Me.lblDocente.Text = "Docente"
    '
    'btnOrdenar
    '
    Me.btnOrdenar.BackColor = System.Drawing.Color.White
    Me.btnOrdenar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnOrdenar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnOrdenar.Location = New System.Drawing.Point(22, 558)
    Me.btnOrdenar.Name = "btnOrdenar"
    Me.btnOrdenar.Size = New System.Drawing.Size(110, 52)
    Me.btnOrdenar.TabIndex = 16
    Me.btnOrdenar.Text = "&Ordenar"
    Me.btnOrdenar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnOrdenar.UseVisualStyleBackColor = False
    '
    'btnbajar
    '
    Me.btnbajar.BackColor = System.Drawing.Color.White
    Me.btnbajar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnbajar.Location = New System.Drawing.Point(327, 563)
    Me.btnbajar.Name = "btnbajar"
    Me.btnbajar.Size = New System.Drawing.Size(75, 47)
    Me.btnbajar.TabIndex = 15
    Me.btnbajar.Text = "Bajar"
    Me.btnbajar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnbajar.UseVisualStyleBackColor = False
    '
    'btnSubir
    '
    Me.btnSubir.BackColor = System.Drawing.Color.White
    Me.btnSubir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnSubir.Location = New System.Drawing.Point(232, 563)
    Me.btnSubir.Name = "btnSubir"
    Me.btnSubir.Size = New System.Drawing.Size(75, 47)
    Me.btnSubir.TabIndex = 14
    Me.btnSubir.Text = "Subir"
    Me.btnSubir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnSubir.UseVisualStyleBackColor = False
    '
    'frmGestionIndicadoresGrupal
    '
    Me.AcceptButton = Me.btnRegistrar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(876, 617)
    Me.Controls.Add(Me.btnOrdenar)
    Me.Controls.Add(Me.btnbajar)
    Me.Controls.Add(Me.btnSubir)
    Me.Controls.Add(Me.txtDocente)
    Me.Controls.Add(Me.lblDocente)
    Me.Controls.Add(Me.cboSeccion)
    Me.Controls.Add(Me.lblSeccion)
    Me.Controls.Add(Me.btnEditar)
    Me.Controls.Add(Me.btncancelar)
    Me.Controls.Add(Me.GBindicador)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.cboCurso)
    Me.Controls.Add(Me.lblCurso)
    Me.Controls.Add(Me.txtPeriodo)
    Me.Controls.Add(Me.lblPeriodo)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.Name = "frmGestionIndicadoresGrupal"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de indicadores - Grupal"
    Me.GroupBox1.ResumeLayout(False)
    CType(Me.dgvCriterios, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GBindicador.ResumeLayout(False)
    Me.GBindicador.PerformLayout()
    CType(Me.ErrIndicador, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtPeriodo As System.Windows.Forms.TextBox
  Friend WithEvents lblPeriodo As System.Windows.Forms.Label
  Friend WithEvents lblCurso As System.Windows.Forms.Label
  Friend WithEvents cboCurso As System.Windows.Forms.ComboBox
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents dgvCriterios As System.Windows.Forms.DataGridView
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents GBindicador As System.Windows.Forms.GroupBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents chkVigencia As System.Windows.Forms.CheckBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents ErrIndicador As System.Windows.Forms.ErrorProvider
    Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
    Friend WithEvents lblSeccion As System.Windows.Forms.Label
    Friend WithEvents txtDocente As System.Windows.Forms.TextBox
    Friend WithEvents lblDocente As System.Windows.Forms.Label
    Friend WithEvents btnOrdenar As System.Windows.Forms.Button
    Friend WithEvents btnbajar As System.Windows.Forms.Button
    Friend WithEvents btnSubir As System.Windows.Forms.Button
    Friend WithEvents cdCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdNro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdCriterio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdVigencia As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
