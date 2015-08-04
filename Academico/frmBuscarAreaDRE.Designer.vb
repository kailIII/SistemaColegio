<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarAreaDRE
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
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.dgvAreaDRE = New System.Windows.Forms.DataGridView
    Me.cdNivel = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdArea = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnSeleccionar = New System.Windows.Forms.Button
    Me.btnCancelar = New System.Windows.Forms.Button
    CType(Me.dgvAreaDRE, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'dgvAreaDRE
    '
    Me.dgvAreaDRE.AllowUserToAddRows = False
    Me.dgvAreaDRE.AllowUserToDeleteRows = False
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvAreaDRE.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.dgvAreaDRE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvAreaDRE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNivel, Me.cdArea})
    Me.dgvAreaDRE.Location = New System.Drawing.Point(44, 34)
    Me.dgvAreaDRE.Name = "dgvAreaDRE"
    Me.dgvAreaDRE.ReadOnly = True
    Me.dgvAreaDRE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvAreaDRE.Size = New System.Drawing.Size(363, 418)
    Me.dgvAreaDRE.TabIndex = 0
    '
    'cdNivel
    '
    Me.cdNivel.HeaderText = "Nivel"
    Me.cdNivel.Name = "cdNivel"
    Me.cdNivel.ReadOnly = True
    Me.cdNivel.Width = 120
    '
    'cdArea
    '
    Me.cdArea.HeaderText = "Área"
    Me.cdArea.Name = "cdArea"
    Me.cdArea.ReadOnly = True
    Me.cdArea.Width = 200
    '
    'btnSeleccionar
    '
    Me.btnSeleccionar.BackColor = System.Drawing.Color.White
    Me.btnSeleccionar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnSeleccionar.Location = New System.Drawing.Point(446, 177)
    Me.btnSeleccionar.Name = "btnSeleccionar"
    Me.btnSeleccionar.Size = New System.Drawing.Size(110, 52)
    Me.btnSeleccionar.TabIndex = 1
    Me.btnSeleccionar.Text = "&Seleccionar"
    Me.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnSeleccionar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(446, 400)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
    Me.btnCancelar.TabIndex = 2
    Me.btnCancelar.Text = "C&ancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'frmBuscarAreaDRE
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(600, 487)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnSeleccionar)
    Me.Controls.Add(Me.dgvAreaDRE)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmBuscarAreaDRE"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de áreas de la DRE"
    CType(Me.dgvAreaDRE, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents dgvAreaDRE As System.Windows.Forms.DataGridView
  Friend WithEvents cdNivel As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdArea As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
