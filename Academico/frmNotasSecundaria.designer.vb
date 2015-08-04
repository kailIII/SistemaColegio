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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.cboCurso = New System.Windows.Forms.ComboBox()
    Me.lblNro = New System.Windows.Forms.Label()
    Me.cboUnidades = New System.Windows.Forms.ComboBox()
    Me.gbUnidad = New System.Windows.Forms.GroupBox()
    Me.txtDescripcion = New System.Windows.Forms.TextBox()
    Me.lblDescripcion = New System.Windows.Forms.Label()
    Me.dgvNotas = New System.Windows.Forms.DataGridView()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.btnAceptar = New System.Windows.Forms.Button()
    Me.btnListar = New System.Windows.Forms.Button()
    Me.txtTotal = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cboDocente = New System.Windows.Forms.ComboBox()
    Me.btnImportar = New System.Windows.Forms.Button()
    Me.btnExportar = New System.Windows.Forms.Button()
    Me.dgvCapacidades = New System.Windows.Forms.DataGridView()
    Me.cdNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cboPeriodo = New System.Windows.Forms.ComboBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.lblDocente = New System.Windows.Forms.Label()
    Me.lblCurso = New System.Windows.Forms.Label()
    Me.gbUnidad.SuspendLayout()
    CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dgvCapacidades, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cboCurso
    '
    Me.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCurso.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboCurso.FormattingEnabled = True
    Me.cboCurso.Location = New System.Drawing.Point(358, 68)
    Me.cboCurso.Name = "cboCurso"
    Me.cboCurso.Size = New System.Drawing.Size(248, 24)
    Me.cboCurso.TabIndex = 5
    '
    'lblNro
    '
    Me.lblNro.AutoSize = True
    Me.lblNro.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNro.Location = New System.Drawing.Point(4, 30)
    Me.lblNro.Name = "lblNro"
    Me.lblNro.Size = New System.Drawing.Size(49, 15)
    Me.lblNro.TabIndex = 0
    Me.lblNro.Text = "Nú&mero"
    '
    'cboUnidades
    '
    Me.cboUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboUnidades.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboUnidades.FormattingEnabled = True
    Me.cboUnidades.Location = New System.Drawing.Point(51, 21)
    Me.cboUnidades.Name = "cboUnidades"
    Me.cboUnidades.Size = New System.Drawing.Size(54, 24)
    Me.cboUnidades.TabIndex = 1
    '
    'gbUnidad
    '
    Me.gbUnidad.Controls.Add(Me.txtDescripcion)
    Me.gbUnidad.Controls.Add(Me.lblDescripcion)
    Me.gbUnidad.Controls.Add(Me.cboUnidades)
    Me.gbUnidad.Controls.Add(Me.lblNro)
    Me.gbUnidad.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbUnidad.Location = New System.Drawing.Point(12, 103)
    Me.gbUnidad.Name = "gbUnidad"
    Me.gbUnidad.Size = New System.Drawing.Size(471, 53)
    Me.gbUnidad.TabIndex = 6
    Me.gbUnidad.TabStop = False
    Me.gbUnidad.Text = "Unidad"
    '
    'txtDescripcion
    '
    Me.txtDescripcion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDescripcion.Location = New System.Drawing.Point(185, 21)
    Me.txtDescripcion.Multiline = True
    Me.txtDescripcion.Name = "txtDescripcion"
    Me.txtDescripcion.ReadOnly = True
    Me.txtDescripcion.Size = New System.Drawing.Size(280, 24)
    Me.txtDescripcion.TabIndex = 3
    '
    'lblDescripcion
    '
    Me.lblDescripcion.AutoSize = True
    Me.lblDescripcion.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDescripcion.Location = New System.Drawing.Point(111, 30)
    Me.lblDescripcion.Name = "lblDescripcion"
    Me.lblDescripcion.Size = New System.Drawing.Size(71, 15)
    Me.lblDescripcion.TabIndex = 2
    Me.lblDescripcion.Text = "Descripción"
    '
    'dgvNotas
    '
    Me.dgvNotas.AllowUserToAddRows = False
    Me.dgvNotas.AllowUserToDeleteRows = False
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.dgvNotas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvNotas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
    Me.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgvNotas.DefaultCellStyle = DataGridViewCellStyle3
    Me.dgvNotas.Location = New System.Drawing.Point(7, 162)
    Me.dgvNotas.MultiSelect = False
    Me.dgvNotas.Name = "dgvNotas"
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvNotas.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.dgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.dgvNotas.Size = New System.Drawing.Size(697, 347)
    Me.dgvNotas.TabIndex = 8
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(863, 459)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(134, 50)
    Me.btnCerrar.TabIndex = 13
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnAceptar
    '
    Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnAceptar.BackColor = System.Drawing.Color.White
    Me.btnAceptar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAceptar.Location = New System.Drawing.Point(863, 403)
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(134, 50)
    Me.btnAceptar.TabIndex = 12
    Me.btnAceptar.Text = "&Registrar"
    Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnAceptar.UseVisualStyleBackColor = False
    '
    'btnListar
    '
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnListar.Location = New System.Drawing.Point(489, 103)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(117, 53)
    Me.btnListar.TabIndex = 7
    Me.btnListar.Text = "&Listar"
    Me.btnListar.UseVisualStyleBackColor = False
    '
    'txtTotal
    '
    Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.txtTotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTotal.Location = New System.Drawing.Point(753, 485)
    Me.txtTotal.Multiline = True
    Me.txtTotal.Name = "txtTotal"
    Me.txtTotal.ReadOnly = True
    Me.txtTotal.Size = New System.Drawing.Size(49, 24)
    Me.txtTotal.TabIndex = 15
    Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'Label1
    '
    Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(711, 494)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(34, 15)
    Me.Label1.TabIndex = 14
    Me.Label1.Text = "Total"
    '
    'cboDocente
    '
    Me.cboDocente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboDocente.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboDocente.FormattingEnabled = True
    Me.cboDocente.Location = New System.Drawing.Point(63, 26)
    Me.cboDocente.Name = "cboDocente"
    Me.cboDocente.Size = New System.Drawing.Size(296, 24)
    Me.cboDocente.TabIndex = 1
    '
    'btnImportar
    '
    Me.btnImportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnImportar.BackColor = System.Drawing.Color.White
    Me.btnImportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnImportar.Location = New System.Drawing.Point(863, 347)
    Me.btnImportar.Name = "btnImportar"
    Me.btnImportar.Size = New System.Drawing.Size(134, 50)
    Me.btnImportar.TabIndex = 11
    Me.btnImportar.Text = "&Importar"
    Me.btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnImportar.UseVisualStyleBackColor = False
    '
    'btnExportar
    '
    Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnExportar.BackColor = System.Drawing.Color.White
    Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnExportar.Location = New System.Drawing.Point(863, 291)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(134, 50)
    Me.btnExportar.TabIndex = 10
    Me.btnExportar.Text = "&Exportar"
    Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnExportar.UseVisualStyleBackColor = False
    Me.btnExportar.Visible = False
    '
    'dgvCapacidades
    '
    Me.dgvCapacidades.AllowUserToAddRows = False
    Me.dgvCapacidades.AllowUserToDeleteRows = False
    Me.dgvCapacidades.AllowUserToResizeColumns = False
    Me.dgvCapacidades.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvCapacidades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
    Me.dgvCapacidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvCapacidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNombre})
    Me.dgvCapacidades.Location = New System.Drawing.Point(710, 75)
    Me.dgvCapacidades.MultiSelect = False
    Me.dgvCapacidades.Name = "dgvCapacidades"
    Me.dgvCapacidades.ReadOnly = True
    Me.dgvCapacidades.RowHeadersVisible = False
    Me.dgvCapacidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvCapacidades.Size = New System.Drawing.Size(287, 210)
    Me.dgvCapacidades.TabIndex = 9
    '
    'cdNombre
    '
    Me.cdNombre.DataPropertyName = "Nombre"
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.cdNombre.DefaultCellStyle = DataGridViewCellStyle5
    Me.cdNombre.HeaderText = "Capacidad"
    Me.cdNombre.Name = "cdNombre"
    Me.cdNombre.ReadOnly = True
    Me.cdNombre.Width = 182
    '
    'cboPeriodo
    '
    Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboPeriodo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboPeriodo.FormattingEnabled = True
    Me.cboPeriodo.Location = New System.Drawing.Point(63, 68)
    Me.cboPeriodo.Name = "cboPeriodo"
    Me.cboPeriodo.Size = New System.Drawing.Size(174, 24)
    Me.cboPeriodo.TabIndex = 3
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(9, 77)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(48, 15)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Periodo"
    '
    'lblDocente
    '
    Me.lblDocente.AutoSize = True
    Me.lblDocente.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDocente.Location = New System.Drawing.Point(9, 35)
    Me.lblDocente.Name = "lblDocente"
    Me.lblDocente.Size = New System.Drawing.Size(52, 15)
    Me.lblDocente.TabIndex = 0
    Me.lblDocente.Text = "Docente"
    '
    'lblCurso
    '
    Me.lblCurso.AutoSize = True
    Me.lblCurso.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCurso.Location = New System.Drawing.Point(304, 77)
    Me.lblCurso.Name = "lblCurso"
    Me.lblCurso.Size = New System.Drawing.Size(39, 15)
    Me.lblCurso.TabIndex = 4
    Me.lblCurso.Text = "Curso"
    '
    'frmNotasSecundaria
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(1009, 521)
    Me.Controls.Add(Me.lblCurso)
    Me.Controls.Add(Me.lblDocente)
    Me.Controls.Add(Me.cboCurso)
    Me.Controls.Add(Me.cboDocente)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.cboPeriodo)
    Me.Controls.Add(Me.dgvCapacidades)
    Me.Controls.Add(Me.txtTotal)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.btnListar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.btnImportar)
    Me.Controls.Add(Me.btnAceptar)
    Me.Controls.Add(Me.gbUnidad)
    Me.Controls.Add(Me.dgvNotas)
    Me.Name = "frmNotasSecundaria"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Notas de Secundaria"
    Me.gbUnidad.ResumeLayout(False)
    Me.gbUnidad.PerformLayout()
    CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dgvCapacidades, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cboCurso As System.Windows.Forms.ComboBox
  Friend WithEvents lblNro As System.Windows.Forms.Label
  Friend WithEvents cboUnidades As System.Windows.Forms.ComboBox
  Friend WithEvents gbUnidad As System.Windows.Forms.GroupBox
  Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
  Friend WithEvents lblDescripcion As System.Windows.Forms.Label
  Friend WithEvents dgvNotas As System.Windows.Forms.DataGridView
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnAceptar As System.Windows.Forms.Button
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents txtTotal As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cboDocente As System.Windows.Forms.ComboBox
  Friend WithEvents btnImportar As System.Windows.Forms.Button
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents dgvCapacidades As System.Windows.Forms.DataGridView
  Friend WithEvents cdNombre As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lblDocente As System.Windows.Forms.Label
  Friend WithEvents lblCurso As System.Windows.Forms.Label
End Class
