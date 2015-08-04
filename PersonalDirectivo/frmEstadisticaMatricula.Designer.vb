<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstadisticaMatricula
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.gbPeriodo = New System.Windows.Forms.GroupBox
    Me.cboAnio = New System.Windows.Forms.ComboBox
    Me.lblAnio = New System.Windows.Forms.Label
    Me.btnListar = New System.Windows.Forms.Button
    Me.dgvResumenMatricula = New System.Windows.Forms.DataGridView
    Me.cdSeccion = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdEsperados = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdMatriculados = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdNuevos = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnExportar = New System.Windows.Forms.Button
    Me.gbPeriodo.SuspendLayout()
    CType(Me.dgvResumenMatricula, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'gbPeriodo
    '
    Me.gbPeriodo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbPeriodo.Controls.Add(Me.cboAnio)
    Me.gbPeriodo.Controls.Add(Me.lblAnio)
    Me.gbPeriodo.Controls.Add(Me.btnListar)
    Me.gbPeriodo.Location = New System.Drawing.Point(22, 23)
    Me.gbPeriodo.Name = "gbPeriodo"
    Me.gbPeriodo.Size = New System.Drawing.Size(497, 93)
    Me.gbPeriodo.TabIndex = 0
    Me.gbPeriodo.TabStop = False
    '
    'cboAnio
    '
    Me.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAnio.FormattingEnabled = True
    Me.cboAnio.Location = New System.Drawing.Point(55, 43)
    Me.cboAnio.Name = "cboAnio"
    Me.cboAnio.Size = New System.Drawing.Size(107, 21)
    Me.cboAnio.TabIndex = 1
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Location = New System.Drawing.Point(10, 51)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(26, 13)
    Me.lblAnio.TabIndex = 0
    Me.lblAnio.Text = "Añ&o"
    '
    'btnListar
    '
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnListar.Location = New System.Drawing.Point(369, 21)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(122, 56)
    Me.btnListar.TabIndex = 6
    Me.btnListar.Text = "&Listar"
    Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnListar.UseVisualStyleBackColor = False
    '
    'dgvResumenMatricula
    '
    Me.dgvResumenMatricula.AllowUserToAddRows = False
    Me.dgvResumenMatricula.AllowUserToDeleteRows = False
    Me.dgvResumenMatricula.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvResumenMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvResumenMatricula.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdSeccion, Me.cdEsperados, Me.cdMatriculados, Me.cdNuevos})
    Me.dgvResumenMatricula.Location = New System.Drawing.Point(22, 130)
    Me.dgvResumenMatricula.Name = "dgvResumenMatricula"
    Me.dgvResumenMatricula.ReadOnly = True
    Me.dgvResumenMatricula.Size = New System.Drawing.Size(497, 261)
    Me.dgvResumenMatricula.TabIndex = 1
    '
    'cdSeccion
    '
    Me.cdSeccion.DataPropertyName = "Seccion"
    Me.cdSeccion.HeaderText = "Seccion"
    Me.cdSeccion.Name = "cdSeccion"
    Me.cdSeccion.ReadOnly = True
    Me.cdSeccion.Width = 350
    '
    'cdEsperados
    '
    Me.cdEsperados.DataPropertyName = "Esperado"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdEsperados.DefaultCellStyle = DataGridViewCellStyle1
    Me.cdEsperados.HeaderText = "Matrículas esperadas"
    Me.cdEsperados.Name = "cdEsperados"
    Me.cdEsperados.ReadOnly = True
    '
    'cdMatriculados
    '
    Me.cdMatriculados.DataPropertyName = "Matriculados"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdMatriculados.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdMatriculados.HeaderText = "Matrículas realizadas"
    Me.cdMatriculados.Name = "cdMatriculados"
    Me.cdMatriculados.ReadOnly = True
    '
    'cdNuevos
    '
    Me.cdNuevos.DataPropertyName = "Nuevos"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdNuevos.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdNuevos.HeaderText = "Alumnos nuevos"
    Me.cdNuevos.Name = "cdNuevos"
    Me.cdNuevos.ReadOnly = True
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(410, 401)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 50)
    Me.btnCerrar.TabIndex = 3
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnExportar
    '
    Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnExportar.BackColor = System.Drawing.Color.White
    Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnExportar.Location = New System.Drawing.Point(294, 401)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(110, 50)
    Me.btnExportar.TabIndex = 2
    Me.btnExportar.Text = "&Exportar"
    Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnExportar.UseVisualStyleBackColor = False
    '
    'frmEstadisticaMatricula
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(532, 453)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.dgvResumenMatricula)
    Me.Controls.Add(Me.gbPeriodo)
    Me.Name = "frmEstadisticaMatricula"
    Me.Text = "Reporte estadístico de matriculados"
    Me.gbPeriodo.ResumeLayout(False)
    Me.gbPeriodo.PerformLayout()
    CType(Me.dgvResumenMatricula, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents gbPeriodo As System.Windows.Forms.GroupBox
  Friend WithEvents dgvResumenMatricula As System.Windows.Forms.DataGridView
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
  Friend WithEvents cdSeccion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdEsperados As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdMatriculados As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdNuevos As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
