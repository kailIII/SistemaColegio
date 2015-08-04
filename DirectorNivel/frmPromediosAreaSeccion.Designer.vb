<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPromediosAreaSeccion
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
    Me.cdArea = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btnListar = New System.Windows.Forms.Button()
    Me.sfdArchivos = New System.Windows.Forms.SaveFileDialog()
    Me.cboPeriodo = New System.Windows.Forms.ComboBox()
    Me.lblPeriodo = New System.Windows.Forms.Label()
    CType(Me.dgvAreas, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'cboSeccion
    '
    Me.cboSeccion.BackColor = System.Drawing.SystemColors.Info
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(111, 61)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(174, 24)
    Me.cboSeccion.TabIndex = 3
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSeccion.Location = New System.Drawing.Point(15, 70)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(93, 15)
    Me.lblSeccion.TabIndex = 2
    Me.lblSeccion.Text = "&Grado y sección"
    '
    'pbAvance
    '
    Me.pbAvance.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.pbAvance.Location = New System.Drawing.Point(108, 413)
    Me.pbAvance.Name = "pbAvance"
    Me.pbAvance.Size = New System.Drawing.Size(223, 23)
    Me.pbAvance.TabIndex = 7
    Me.pbAvance.Visible = False
    '
    'btnExportar
    '
    Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnExportar.Location = New System.Drawing.Point(15, 413)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(87, 23)
    Me.btnExportar.TabIndex = 6
    Me.btnExportar.Text = "&Exportar"
    Me.btnExportar.UseVisualStyleBackColor = True
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.Location = New System.Drawing.Point(508, 413)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(87, 23)
    Me.btnCerrar.TabIndex = 8
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
    Me.dgvAreas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdArea})
    Me.dgvAreas.Location = New System.Drawing.Point(15, 103)
    Me.dgvAreas.MultiSelect = False
    Me.dgvAreas.Name = "dgvAreas"
    Me.dgvAreas.ReadOnly = True
    Me.dgvAreas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvAreas.Size = New System.Drawing.Size(580, 304)
    Me.dgvAreas.TabIndex = 5
    '
    'cdArea
    '
    Me.cdArea.HeaderText = "Área"
    Me.cdArea.Name = "cdArea"
    Me.cdArea.ReadOnly = True
    Me.cdArea.Width = 250
    '
    'btnListar
    '
    Me.btnListar.Location = New System.Drawing.Point(299, 62)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(87, 23)
    Me.btnListar.TabIndex = 4
    Me.btnListar.Text = "&Listar"
    Me.btnListar.UseVisualStyleBackColor = True
    '
    'cboPeriodo
    '
    Me.cboPeriodo.BackColor = System.Drawing.SystemColors.Info
    Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboPeriodo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboPeriodo.FormattingEnabled = True
    Me.cboPeriodo.Location = New System.Drawing.Point(111, 21)
    Me.cboPeriodo.Name = "cboPeriodo"
    Me.cboPeriodo.Size = New System.Drawing.Size(174, 24)
    Me.cboPeriodo.TabIndex = 1
    '
    'lblPeriodo
    '
    Me.lblPeriodo.AutoSize = True
    Me.lblPeriodo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPeriodo.Location = New System.Drawing.Point(15, 30)
    Me.lblPeriodo.Name = "lblPeriodo"
    Me.lblPeriodo.Size = New System.Drawing.Size(48, 15)
    Me.lblPeriodo.TabIndex = 0
    Me.lblPeriodo.Text = "&Periodo"
    '
    'frmPromediosAreaSeccion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(607, 448)
    Me.Controls.Add(Me.cboPeriodo)
    Me.Controls.Add(Me.lblPeriodo)
    Me.Controls.Add(Me.btnListar)
    Me.Controls.Add(Me.pbAvance)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.dgvAreas)
    Me.Controls.Add(Me.cboSeccion)
    Me.Controls.Add(Me.lblSeccion)
    Me.Name = "frmPromediosAreaSeccion"
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
  Friend WithEvents cdArea As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
  Friend WithEvents lblPeriodo As System.Windows.Forms.Label
End Class
