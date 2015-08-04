<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarAlumnoAnio
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
    Me.btnBuscar = New System.Windows.Forms.Button()
    Me.dgvAlumnos = New System.Windows.Forms.DataGridView()
    Me.btnseleccionar = New System.Windows.Forms.Button()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.GBAlumno = New System.Windows.Forms.GroupBox()
    Me.txtNombreBuscar = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.lblNombreBuscar = New System.Windows.Forms.Label()
    Me.cdNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdSeccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
    CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GBAlumno.SuspendLayout()
    Me.SuspendLayout()
    '
    'btnBuscar
    '
    Me.btnBuscar.BackColor = System.Drawing.Color.White
    Me.btnBuscar.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscar.Location = New System.Drawing.Point(475, 24)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(78, 37)
    Me.btnBuscar.TabIndex = 1
    Me.btnBuscar.Text = "&Buscar"
    Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscar.UseVisualStyleBackColor = False
    '
    'dgvAlumnos
    '
    Me.dgvAlumnos.AllowUserToAddRows = False
    Me.dgvAlumnos.AllowUserToDeleteRows = False
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvAlumnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNombre, Me.cdSeccion})
    Me.dgvAlumnos.Location = New System.Drawing.Point(19, 86)
    Me.dgvAlumnos.MultiSelect = False
    Me.dgvAlumnos.Name = "dgvAlumnos"
    Me.dgvAlumnos.ReadOnly = True
    Me.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvAlumnos.Size = New System.Drawing.Size(534, 403)
    Me.dgvAlumnos.TabIndex = 2
    '
    'btnseleccionar
    '
    Me.btnseleccionar.BackColor = System.Drawing.Color.White
    Me.btnseleccionar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnseleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnseleccionar.Location = New System.Drawing.Point(570, 193)
    Me.btnseleccionar.Name = "btnseleccionar"
    Me.btnseleccionar.Size = New System.Drawing.Size(110, 52)
    Me.btnseleccionar.TabIndex = 3
    Me.btnseleccionar.Text = "&Seleccionar"
    Me.btnseleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnseleccionar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(570, 376)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
    Me.btnCancelar.TabIndex = 4
    Me.btnCancelar.Text = "C&ancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'GBAlumno
    '
    Me.GBAlumno.Controls.Add(Me.txtNombreBuscar)
    Me.GBAlumno.Controls.Add(Me.Label1)
    Me.GBAlumno.Controls.Add(Me.lblNombreBuscar)
    Me.GBAlumno.Location = New System.Drawing.Point(19, 12)
    Me.GBAlumno.Name = "GBAlumno"
    Me.GBAlumno.Size = New System.Drawing.Size(450, 68)
    Me.GBAlumno.TabIndex = 0
    Me.GBAlumno.TabStop = False
    Me.GBAlumno.Text = "Alumno"
    '
    'txtNombreBuscar
    '
    Me.txtNombreBuscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNombreBuscar.Location = New System.Drawing.Point(68, 19)
    Me.txtNombreBuscar.Multiline = True
    Me.txtNombreBuscar.Name = "txtNombreBuscar"
    Me.txtNombreBuscar.Size = New System.Drawing.Size(375, 24)
    Me.txtNombreBuscar.TabIndex = 1
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
    'cdNombre
    '
    Me.cdNombre.DataPropertyName = "NombreAlumno"
    Me.cdNombre.HeaderText = "Alumno"
    Me.cdNombre.Name = "cdNombre"
    Me.cdNombre.ReadOnly = True
    Me.cdNombre.Width = 300
    '
    'cdSeccion
    '
    Me.cdSeccion.DataPropertyName = "NivelGradoSeccion"
    Me.cdSeccion.HeaderText = "Sección"
    Me.cdSeccion.Name = "cdSeccion"
    Me.cdSeccion.ReadOnly = True
    Me.cdSeccion.Width = 150
    '
    'frmBuscarAlumnoAnio
    '
    Me.AcceptButton = Me.btnBuscar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(698, 501)
    Me.Controls.Add(Me.GBAlumno)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnseleccionar)
    Me.Controls.Add(Me.btnBuscar)
    Me.Controls.Add(Me.dgvAlumnos)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.KeyPreview = True
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmBuscarAlumnoAnio"
    Me.ShowIcon = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Buscar Alumno"
    CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GBAlumno.ResumeLayout(False)
    Me.GBAlumno.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
  Friend WithEvents dgvAlumnos As System.Windows.Forms.DataGridView
  Friend WithEvents btnseleccionar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents GBAlumno As System.Windows.Forms.GroupBox
  Friend WithEvents txtNombreBuscar As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents lblNombreBuscar As System.Windows.Forms.Label
  Friend WithEvents cdNombre As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdSeccion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
