<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPromediosCursoSeccion
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
    Me.cboSeccion = New System.Windows.Forms.ComboBox()
    Me.lblSeccion = New System.Windows.Forms.Label()
    Me.pbAvance = New System.Windows.Forms.ProgressBar()
    Me.btnExportar = New System.Windows.Forms.Button()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.dgvAreas = New System.Windows.Forms.DataGridView()
    Me.cdCurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btnListar = New System.Windows.Forms.Button()
    Me.sfdArchivos = New System.Windows.Forms.SaveFileDialog()
    CType(Me.dgvAreas, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cboSeccion
    '
    Me.cboSeccion.BackColor = System.Drawing.SystemColors.Info
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(111, 37)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(132, 24)
    Me.cboSeccion.TabIndex = 1
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSeccion.Location = New System.Drawing.Point(12, 46)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(93, 15)
    Me.lblSeccion.TabIndex = 0
    Me.lblSeccion.Text = "&Grado y sección"
    '
    'pbAvance
    '
    Me.pbAvance.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.pbAvance.Location = New System.Drawing.Point(108, 413)
    Me.pbAvance.Name = "pbAvance"
    Me.pbAvance.Size = New System.Drawing.Size(223, 23)
    Me.pbAvance.TabIndex = 5
    Me.pbAvance.Visible = False
    '
    'btnExportar
    '
    Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnExportar.Location = New System.Drawing.Point(15, 413)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(87, 23)
    Me.btnExportar.TabIndex = 4
    Me.btnExportar.Text = "&Exportar"
    Me.btnExportar.UseVisualStyleBackColor = True
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.Location = New System.Drawing.Point(508, 413)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(87, 23)
    Me.btnCerrar.TabIndex = 6
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.UseVisualStyleBackColor = True
    '
    'dgvAreas
    '
    Me.dgvAreas.AllowUserToAddRows = False
    Me.dgvAreas.AllowUserToDeleteRows = False
    Me.dgvAreas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvAreas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdCurso})
    Me.dgvAreas.Location = New System.Drawing.Point(15, 78)
    Me.dgvAreas.MultiSelect = False
    Me.dgvAreas.Name = "dgvAreas"
    Me.dgvAreas.ReadOnly = True
    Me.dgvAreas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvAreas.Size = New System.Drawing.Size(580, 329)
    Me.dgvAreas.TabIndex = 3
    '
    'cdCurso
    '
    Me.cdCurso.HeaderText = "Curso"
    Me.cdCurso.Name = "cdCurso"
    Me.cdCurso.ReadOnly = True
    Me.cdCurso.Width = 250
    '
    'btnListar
    '
    Me.btnListar.Location = New System.Drawing.Point(260, 38)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(87, 23)
    Me.btnListar.TabIndex = 2
    Me.btnListar.Text = "&Listar"
    Me.btnListar.UseVisualStyleBackColor = True
    '
    'frmPromediosCursoSeccion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(607, 448)
    Me.Controls.Add(Me.btnListar)
    Me.Controls.Add(Me.pbAvance)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.dgvAreas)
    Me.Controls.Add(Me.cboSeccion)
    Me.Controls.Add(Me.lblSeccion)
    Me.Name = "frmPromediosCursoSeccion"
    Me.Text = "Promedio de área por sección"
    CType(Me.dgvAreas, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents pbAvance As System.Windows.Forms.ProgressBar
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents dgvAreas As System.Windows.Forms.DataGridView
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents sfdArchivos As System.Windows.Forms.SaveFileDialog
  Friend WithEvents cdCurso As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
