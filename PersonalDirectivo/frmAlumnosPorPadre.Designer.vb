<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlumnosPorPadre
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
    Me.btnBuscarAlumno = New System.Windows.Forms.Button
    Me.txtPadre = New System.Windows.Forms.TextBox
    Me.lblAlumno = New System.Windows.Forms.Label
    Me.lblAnio = New System.Windows.Forms.Label
    Me.txtAnio = New System.Windows.Forms.TextBox
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.dgvApoderados = New System.Windows.Forms.DataGridView
    Me.cdSeccion = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.Parentesco = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.dgvApoderados, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnBuscarAlumno
    '
    Me.btnBuscarAlumno.BackColor = System.Drawing.Color.White
    Me.btnBuscarAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscarAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscarAlumno.Location = New System.Drawing.Point(480, 61)
    Me.btnBuscarAlumno.Name = "btnBuscarAlumno"
    Me.btnBuscarAlumno.Size = New System.Drawing.Size(104, 39)
    Me.btnBuscarAlumno.TabIndex = 4
    Me.btnBuscarAlumno.Text = "&Buscar"
    Me.btnBuscarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscarAlumno.UseVisualStyleBackColor = False
    '
    'txtPadre
    '
    Me.txtPadre.BackColor = System.Drawing.SystemColors.Info
    Me.txtPadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtPadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPadre.Location = New System.Drawing.Point(138, 76)
    Me.txtPadre.Multiline = True
    Me.txtPadre.Name = "txtPadre"
    Me.txtPadre.ReadOnly = True
    Me.txtPadre.Size = New System.Drawing.Size(336, 24)
    Me.txtPadre.TabIndex = 3
    '
    'lblAlumno
    '
    Me.lblAlumno.AutoSize = True
    Me.lblAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAlumno.Location = New System.Drawing.Point(26, 84)
    Me.lblAlumno.Name = "lblAlumno"
    Me.lblAlumno.Size = New System.Drawing.Size(106, 16)
    Me.lblAlumno.TabIndex = 2
    Me.lblAlumno.Text = "Padre de familia"
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAnio.Location = New System.Drawing.Point(26, 33)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(32, 16)
    Me.lblAnio.TabIndex = 0
    Me.lblAnio.Text = "Añ&o"
    '
    'txtAnio
    '
    Me.txtAnio.BackColor = System.Drawing.SystemColors.Info
    Me.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAnio.Location = New System.Drawing.Point(107, 25)
    Me.txtAnio.Multiline = True
    Me.txtAnio.Name = "txtAnio"
    Me.txtAnio.ReadOnly = True
    Me.txtAnio.Size = New System.Drawing.Size(94, 24)
    Me.txtAnio.TabIndex = 1
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(485, 397)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(104, 44)
    Me.btnCerrar.TabIndex = 6
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
    Me.dgvApoderados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdSeccion, Me.cdAlumno, Me.Parentesco})
    Me.dgvApoderados.Location = New System.Drawing.Point(29, 122)
    Me.dgvApoderados.MultiSelect = False
    Me.dgvApoderados.Name = "dgvApoderados"
    Me.dgvApoderados.ReadOnly = True
    Me.dgvApoderados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvApoderados.Size = New System.Drawing.Size(555, 269)
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
    Me.cdAlumno.DataPropertyName = "NombreAlumno"
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.ReadOnly = True
    Me.cdAlumno.Width = 210
    '
    'Parentesco
    '
    Me.Parentesco.DataPropertyName = "NombreParentesco"
    Me.Parentesco.HeaderText = "Parentesco"
    Me.Parentesco.Name = "Parentesco"
    Me.Parentesco.ReadOnly = True
    '
    'frmAlumnosPorPadre
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(603, 453)
    Me.Controls.Add(Me.dgvApoderados)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.txtAnio)
    Me.Controls.Add(Me.lblAnio)
    Me.Controls.Add(Me.btnBuscarAlumno)
    Me.Controls.Add(Me.txtPadre)
    Me.Controls.Add(Me.lblAlumno)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmAlumnosPorPadre"
    Me.Text = "Alumnos por padre de familia"
    CType(Me.dgvApoderados, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnBuscarAlumno As System.Windows.Forms.Button
  Friend WithEvents txtPadre As System.Windows.Forms.TextBox
    Friend WithEvents lblAlumno As System.Windows.Forms.Label
    Friend WithEvents lblAnio As System.Windows.Forms.Label
    Friend WithEvents txtAnio As System.Windows.Forms.TextBox
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents dgvApoderados As System.Windows.Forms.DataGridView
  Friend WithEvents cdSeccion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Parentesco As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
