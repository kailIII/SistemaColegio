<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoMadresHijoMayor
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
    Me.btnExportar = New System.Windows.Forms.Button
    Me.lblAnio = New System.Windows.Forms.Label
    Me.txtAnio = New System.Windows.Forms.TextBox
    Me.btnListar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.dgvApoderados = New System.Windows.Forms.DataGridView
    Me.cdSeccion = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdMadre = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdVive = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.dgvApoderados, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnExportar
    '
    Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnExportar.BackColor = System.Drawing.Color.White
    Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnExportar.Location = New System.Drawing.Point(544, 463)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(110, 50)
    Me.btnExportar.TabIndex = 6
    Me.btnExportar.Text = "&Exportar"
    Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnExportar.UseVisualStyleBackColor = False
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblAnio.Location = New System.Drawing.Point(28, 41)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(36, 17)
    Me.lblAnio.TabIndex = 0
    Me.lblAnio.Text = "&Anio"
    '
    'txtAnio
    '
    Me.txtAnio.BackColor = System.Drawing.Color.White
    Me.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.txtAnio.Location = New System.Drawing.Point(91, 33)
    Me.txtAnio.Name = "txtAnio"
    Me.txtAnio.ReadOnly = True
    Me.txtAnio.Size = New System.Drawing.Size(100, 25)
    Me.txtAnio.TabIndex = 1
    Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'btnListar
    '
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnListar.Location = New System.Drawing.Point(221, 33)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(122, 56)
    Me.btnListar.TabIndex = 4
    Me.btnListar.Text = "&Listar"
    Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnListar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(660, 463)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 50)
    Me.btnCerrar.TabIndex = 7
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'dgvApoderados
    '
    Me.dgvApoderados.AllowUserToAddRows = False
    Me.dgvApoderados.AllowUserToDeleteRows = False
    Me.dgvApoderados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvApoderados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvApoderados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdSeccion, Me.cdAlumno, Me.cdMadre, Me.cdVive})
    Me.dgvApoderados.Location = New System.Drawing.Point(31, 95)
    Me.dgvApoderados.MultiSelect = False
    Me.dgvApoderados.Name = "dgvApoderados"
    Me.dgvApoderados.ReadOnly = True
    Me.dgvApoderados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvApoderados.Size = New System.Drawing.Size(739, 362)
    Me.dgvApoderados.TabIndex = 5
    '
    'cdSeccion
    '
    Me.cdSeccion.DataPropertyName = "NivelGradoSeccion"
    Me.cdSeccion.HeaderText = "Sección"
    Me.cdSeccion.Name = "cdSeccion"
    Me.cdSeccion.ReadOnly = True
    '
    'cdAlumno
    '
    Me.cdAlumno.DataPropertyName = "NombreHijo"
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.ReadOnly = True
    Me.cdAlumno.Width = 210
    '
    'cdMadre
    '
    Me.cdMadre.DataPropertyName = "NombreCompleto"
    Me.cdMadre.HeaderText = "Madre"
    Me.cdMadre.Name = "cdMadre"
    Me.cdMadre.ReadOnly = True
    Me.cdMadre.Width = 210
    '
    'cdVive
    '
    Me.cdVive.DataPropertyName = "DescripcionVive"
    Me.cdVive.HeaderText = "Vive"
    Me.cdVive.Name = "cdVive"
    Me.cdVive.ReadOnly = True
    Me.cdVive.Width = 50
    '
    'frmListadoMadres
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(782, 525)
    Me.Controls.Add(Me.lblAnio)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.txtAnio)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.dgvApoderados)
    Me.Controls.Add(Me.btnListar)
    Me.Name = "frmListadoMadres"
    Me.Text = "Listado de madres e hijos mayores"
    CType(Me.dgvApoderados, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents txtAnio As System.Windows.Forms.TextBox
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents dgvApoderados As System.Windows.Forms.DataGridView
  Friend WithEvents cdSeccion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdMadre As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdVive As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
