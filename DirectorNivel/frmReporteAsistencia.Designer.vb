<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteAsistencia
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
    Me.cboSeccion = New System.Windows.Forms.ComboBox
    Me.lblSeccion = New System.Windows.Forms.Label
    Me.pbAvance = New System.Windows.Forms.ProgressBar
    Me.btnExportar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.dgvAreas = New System.Windows.Forms.DataGridView
    Me.btnListar = New System.Windows.Forms.Button
    Me.sfdArchivos = New System.Windows.Forms.SaveFileDialog
    Me.cboPeriodo = New System.Windows.Forms.ComboBox
    Me.lblPeriodo = New System.Windows.Forms.Label
    Me.cdNro = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdFaltasT = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdFaltasJ = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdFaltasInj = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdTardanzas = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdTardanzasInj = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdTardanzasJ = New System.Windows.Forms.DataGridViewTextBoxColumn
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
    Me.lblSeccion.Location = New System.Drawing.Point(12, 40)
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
    Me.dgvAreas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNro, Me.cdAlumno, Me.cdFaltasT, Me.cdFaltasJ, Me.cdFaltasInj, Me.cdTardanzas, Me.cdTardanzasInj, Me.cdTardanzasJ})
    Me.dgvAreas.Location = New System.Drawing.Point(15, 107)
    Me.dgvAreas.MultiSelect = False
    Me.dgvAreas.Name = "dgvAreas"
    Me.dgvAreas.ReadOnly = True
    Me.dgvAreas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvAreas.Size = New System.Drawing.Size(580, 300)
    Me.dgvAreas.TabIndex = 5
    '
    'btnListar
    '
    Me.btnListar.Location = New System.Drawing.Point(375, 76)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(87, 23)
    Me.btnListar.TabIndex = 4
    Me.btnListar.Text = "&Listar"
    Me.btnListar.UseVisualStyleBackColor = True
    '
    'cboPeriodo
    '
    Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboPeriodo.FormattingEnabled = True
    Me.cboPeriodo.Location = New System.Drawing.Point(111, 78)
    Me.cboPeriodo.Name = "cboPeriodo"
    Me.cboPeriodo.Size = New System.Drawing.Size(258, 21)
    Me.cboPeriodo.TabIndex = 3
    '
    'lblPeriodo
    '
    Me.lblPeriodo.AutoSize = True
    Me.lblPeriodo.Location = New System.Drawing.Point(12, 86)
    Me.lblPeriodo.Name = "lblPeriodo"
    Me.lblPeriodo.Size = New System.Drawing.Size(43, 13)
    Me.lblPeriodo.TabIndex = 2
    Me.lblPeriodo.Text = "&Periodo"
    '
    'cdNro
    '
    Me.cdNro.DataPropertyName = "nroOrden"
    Me.cdNro.HeaderText = "N°"
    Me.cdNro.Name = "cdNro"
    Me.cdNro.ReadOnly = True
    Me.cdNro.Width = 50
    '
    'cdAlumno
    '
    Me.cdAlumno.DataPropertyName = "NombreCompleto"
    Me.cdAlumno.HeaderText = "NombreCompleto"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.ReadOnly = True
    Me.cdAlumno.Width = 200
    '
    'cdFaltasT
    '
    Me.cdFaltasT.DataPropertyName = "FT"
    Me.cdFaltasT.HeaderText = "Faltas"
    Me.cdFaltasT.Name = "cdFaltasT"
    Me.cdFaltasT.ReadOnly = True
    '
    'cdFaltasJ
    '
    Me.cdFaltasJ.DataPropertyName = "FJ"
    Me.cdFaltasJ.HeaderText = "Faltas justificadas"
    Me.cdFaltasJ.Name = "cdFaltasJ"
    Me.cdFaltasJ.ReadOnly = True
    '
    'cdFaltasInj
    '
    Me.cdFaltasInj.DataPropertyName = "F"
    Me.cdFaltasInj.HeaderText = "Faltas injustificadas"
    Me.cdFaltasInj.Name = "cdFaltasInj"
    Me.cdFaltasInj.ReadOnly = True
    '
    'cdTardanzas
    '
    Me.cdTardanzas.DataPropertyName = "TT"
    Me.cdTardanzas.HeaderText = "Tardanzas"
    Me.cdTardanzas.Name = "cdTardanzas"
    Me.cdTardanzas.ReadOnly = True
    '
    'cdTardanzasInj
    '
    Me.cdTardanzasInj.DataPropertyName = "T"
    Me.cdTardanzasInj.HeaderText = "Tardanzas injustificadas"
    Me.cdTardanzasInj.Name = "cdTardanzasInj"
    Me.cdTardanzasInj.ReadOnly = True
    '
    'cdTardanzasJ
    '
    Me.cdTardanzasJ.DataPropertyName = "TJ"
    Me.cdTardanzasJ.HeaderText = "Tardanzas justificadas"
    Me.cdTardanzasJ.Name = "cdTardanzasJ"
    Me.cdTardanzasJ.ReadOnly = True
    '
    'frmReporteAsistencia
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
    Me.Name = "frmReporteAsistencia"
    Me.Text = "Reporte de asistencia"
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
  Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
  Friend WithEvents lblPeriodo As System.Windows.Forms.Label
  Friend WithEvents cdNro As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdFaltasT As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdFaltasJ As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdFaltasInj As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdTardanzas As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdTardanzasInj As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdTardanzasJ As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
