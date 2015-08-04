<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarDocente
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
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.dgvDocentes = New System.Windows.Forms.DataGridView
    Me.cdNumero = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.txtNombreBuscar = New System.Windows.Forms.TextBox
    Me.lblNombreBuscar = New System.Windows.Forms.Label
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnBuscar = New System.Windows.Forms.Button
    Me.btnSeleccionar = New System.Windows.Forms.Button
    Me.Label1 = New System.Windows.Forms.Label
    Me.GBDocente = New System.Windows.Forms.GroupBox
    Me.lblLeyenda = New System.Windows.Forms.Label
    CType(Me.dgvDocentes, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GBDocente.SuspendLayout()
    Me.SuspendLayout()
    '
    'dgvDocentes
    '
    Me.dgvDocentes.AllowUserToAddRows = False
    Me.dgvDocentes.AllowUserToDeleteRows = False
    Me.dgvDocentes.BackgroundColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvDocentes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvDocentes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNumero, Me.cdNombre})
    Me.dgvDocentes.GridColor = System.Drawing.SystemColors.ScrollBar
    Me.dgvDocentes.Location = New System.Drawing.Point(29, 86)
    Me.dgvDocentes.MultiSelect = False
    Me.dgvDocentes.Name = "dgvDocentes"
    Me.dgvDocentes.ReadOnly = True
    Me.dgvDocentes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.dgvDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvDocentes.Size = New System.Drawing.Size(534, 402)
    Me.dgvDocentes.TabIndex = 2
    '
    'cdNumero
    '
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cdNumero.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdNumero.HeaderText = ""
    Me.cdNumero.Name = "cdNumero"
    Me.cdNumero.ReadOnly = True
    Me.cdNumero.Width = 35
    '
    'cdNombre
    '
    Me.cdNombre.DataPropertyName = "NombreCompleto"
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cdNombre.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdNombre.HeaderText = "Docente"
    Me.cdNombre.Name = "cdNombre"
    Me.cdNombre.ReadOnly = True
    Me.cdNombre.Width = 400
    '
    'txtNombreBuscar
    '
    Me.txtNombreBuscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNombreBuscar.Location = New System.Drawing.Point(68, 19)
    Me.txtNombreBuscar.Name = "txtNombreBuscar"
    Me.txtNombreBuscar.Size = New System.Drawing.Size(375, 22)
    Me.txtNombreBuscar.TabIndex = 1
    '
    'lblNombreBuscar
    '
    Me.lblNombreBuscar.AutoSize = True
    Me.lblNombreBuscar.BackColor = System.Drawing.Color.Transparent
    Me.lblNombreBuscar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNombreBuscar.Location = New System.Drawing.Point(17, 23)
    Me.lblNombreBuscar.Name = "lblNombreBuscar"
    Me.lblNombreBuscar.Size = New System.Drawing.Size(52, 15)
    Me.lblNombreBuscar.TabIndex = 0
    Me.lblNombreBuscar.Text = "N&ombre:"
    '
    'btnCancelar
    '
    Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(578, 367)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
    Me.btnCancelar.TabIndex = 4
    Me.btnCancelar.Text = "C&ancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = True
    '
    'btnBuscar
    '
    Me.btnBuscar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscar.Location = New System.Drawing.Point(485, 24)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(78, 37)
    Me.btnBuscar.TabIndex = 1
    Me.btnBuscar.Text = "&Buscar"
    Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscar.UseVisualStyleBackColor = True
    '
    'btnSeleccionar
    '
    Me.btnSeleccionar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnSeleccionar.Location = New System.Drawing.Point(578, 223)
    Me.btnSeleccionar.Name = "btnSeleccionar"
    Me.btnSeleccionar.Size = New System.Drawing.Size(110, 52)
    Me.btnSeleccionar.TabIndex = 3
    Me.btnSeleccionar.Text = "&Seleccionar"
    Me.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnSeleccionar.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
    Me.Label1.Location = New System.Drawing.Point(65, 46)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(248, 14)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Orden:  ApePaterno    ApeMaterno   Nombre"
    '
    'GBDocente
    '
    Me.GBDocente.Controls.Add(Me.txtNombreBuscar)
    Me.GBDocente.Controls.Add(Me.Label1)
    Me.GBDocente.Controls.Add(Me.lblNombreBuscar)
    Me.GBDocente.Location = New System.Drawing.Point(29, 12)
    Me.GBDocente.Name = "GBDocente"
    Me.GBDocente.Size = New System.Drawing.Size(450, 68)
    Me.GBDocente.TabIndex = 0
    Me.GBDocente.TabStop = False
    Me.GBDocente.Text = "Docente"
    '
    'lblLeyenda
    '
    Me.lblLeyenda.AutoSize = True
    Me.lblLeyenda.BackColor = System.Drawing.Color.LightSkyBlue
    Me.lblLeyenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblLeyenda.Location = New System.Drawing.Point(584, 129)
    Me.lblLeyenda.Name = "lblLeyenda"
    Me.lblLeyenda.Size = New System.Drawing.Size(96, 20)
    Me.lblLeyenda.TabIndex = 5
    Me.lblLeyenda.Text = "Buscar: F5"
    '
    'frmBuscarDocente
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCancelar
    Me.ClientSize = New System.Drawing.Size(700, 503)
    Me.Controls.Add(Me.lblLeyenda)
    Me.Controls.Add(Me.GBDocente)
    Me.Controls.Add(Me.btnSeleccionar)
    Me.Controls.Add(Me.btnBuscar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.dgvDocentes)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmBuscarDocente"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de Docentes"
    CType(Me.dgvDocentes, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GBDocente.ResumeLayout(False)
    Me.GBDocente.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents dgvDocentes As System.Windows.Forms.DataGridView
  Friend WithEvents txtNombreBuscar As System.Windows.Forms.TextBox
  Friend WithEvents lblNombreBuscar As System.Windows.Forms.Label
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
  Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents GBDocente As System.Windows.Forms.GroupBox
  Friend WithEvents cdNumero As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdNombre As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents lblLeyenda As System.Windows.Forms.Label
End Class
