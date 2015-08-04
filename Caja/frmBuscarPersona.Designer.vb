<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarPersona
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
    Me.txtNombreBuscar = New System.Windows.Forms.TextBox
    Me.dgvAlumnos = New System.Windows.Forms.DataGridView
    Me.cdCodigoRecaudacion = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.lblAlumno = New System.Windows.Forms.Label
    Me.btnSeleccionar = New System.Windows.Forms.Button
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnBuscar = New System.Windows.Forms.Button
    Me.btNuevo = New System.Windows.Forms.Button
    CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtNombreBuscar
    '
    Me.txtNombreBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtNombreBuscar.Location = New System.Drawing.Point(64, 17)
    Me.txtNombreBuscar.Name = "txtNombreBuscar"
    Me.txtNombreBuscar.Size = New System.Drawing.Size(571, 20)
    Me.txtNombreBuscar.TabIndex = 1
    '
    'dgvAlumnos
    '
    Me.dgvAlumnos.AllowUserToAddRows = False
    Me.dgvAlumnos.AllowUserToDeleteRows = False
    Me.dgvAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdCodigoRecaudacion, Me.cdNombre})
    Me.dgvAlumnos.Location = New System.Drawing.Point(12, 50)
    Me.dgvAlumnos.MultiSelect = False
    Me.dgvAlumnos.Name = "dgvAlumnos"
    Me.dgvAlumnos.ReadOnly = True
    Me.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvAlumnos.Size = New System.Drawing.Size(623, 416)
    Me.dgvAlumnos.TabIndex = 3
    '
    'cdCodigoRecaudacion
    '
    Me.cdCodigoRecaudacion.DataPropertyName = "CodigoRecaudacion"
    Me.cdCodigoRecaudacion.HeaderText = "Código"
    Me.cdCodigoRecaudacion.Name = "cdCodigoRecaudacion"
    Me.cdCodigoRecaudacion.ReadOnly = True
    Me.cdCodigoRecaudacion.Width = 80
    '
    'cdNombre
    '
    Me.cdNombre.DataPropertyName = "NombreCompleto"
    Me.cdNombre.HeaderText = "Alumno"
    Me.cdNombre.Name = "cdNombre"
    Me.cdNombre.ReadOnly = True
    Me.cdNombre.Width = 350
    '
    'lblAlumno
    '
    Me.lblAlumno.AutoSize = True
    Me.lblAlumno.Location = New System.Drawing.Point(14, 24)
    Me.lblAlumno.Name = "lblAlumno"
    Me.lblAlumno.Size = New System.Drawing.Size(42, 13)
    Me.lblAlumno.TabIndex = 0
    Me.lblAlumno.Text = "A&lumno"
    '
    'btnSeleccionar
    '
    Me.btnSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnSeleccionar.BackColor = System.Drawing.Color.White
    Me.btnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnSeleccionar.Location = New System.Drawing.Point(652, 372)
    Me.btnSeleccionar.Name = "btnSeleccionar"
    Me.btnSeleccionar.Size = New System.Drawing.Size(111, 44)
    Me.btnSeleccionar.TabIndex = 5
    Me.btnSeleccionar.Text = "&Seleccionar"
    Me.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnSeleccionar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight
    Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(652, 422)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(111, 44)
    Me.btnCancelar.TabIndex = 6
    Me.btnCancelar.Text = "&Cancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnBuscar
    '
    Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnBuscar.BackColor = System.Drawing.Color.White
    Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
    Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscar.Location = New System.Drawing.Point(652, 12)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(110, 33)
    Me.btnBuscar.TabIndex = 2
    Me.btnBuscar.Text = "&Buscar"
    Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscar.UseVisualStyleBackColor = False
    '
    'btNuevo
    '
    Me.btNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btNuevo.BackColor = System.Drawing.Color.White
    Me.btNuevo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btNuevo.Location = New System.Drawing.Point(652, 51)
    Me.btNuevo.Name = "btNuevo"
    Me.btNuevo.Size = New System.Drawing.Size(113, 49)
    Me.btNuevo.TabIndex = 4
    Me.btNuevo.Text = "&Nuevo"
    Me.btNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btNuevo.UseVisualStyleBackColor = False
    '
    'frmBuscarPersona
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCancelar
    Me.ClientSize = New System.Drawing.Size(775, 478)
    Me.Controls.Add(Me.btNuevo)
    Me.Controls.Add(Me.btnSeleccionar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnBuscar)
    Me.Controls.Add(Me.txtNombreBuscar)
    Me.Controls.Add(Me.dgvAlumnos)
    Me.Controls.Add(Me.lblAlumno)
    Me.KeyPreview = True
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmBuscarPersona"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Buscar Alumno"
    CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtNombreBuscar As System.Windows.Forms.TextBox
  Friend WithEvents dgvAlumnos As System.Windows.Forms.DataGridView
  Friend WithEvents lblAlumno As System.Windows.Forms.Label
  Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
  Friend WithEvents btNuevo As System.Windows.Forms.Button
  Friend WithEvents cdCodigoRecaudacion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdNombre As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
