<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificarApoderados
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
    Me.txtAlumno = New System.Windows.Forms.TextBox
    Me.lblAlumno = New System.Windows.Forms.Label
    Me.dgvApoderados = New System.Windows.Forms.DataGridView
    Me.cdParentesco = New System.Windows.Forms.DataGridViewComboBoxColumn
    Me.cdApoderado = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnAceptar = New System.Windows.Forms.Button
    CType(Me.dgvApoderados, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnBuscarAlumno
    '
    Me.btnBuscarAlumno.BackColor = System.Drawing.Color.White
    Me.btnBuscarAlumno.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscarAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscarAlumno.Location = New System.Drawing.Point(422, 26)
    Me.btnBuscarAlumno.Name = "btnBuscarAlumno"
    Me.btnBuscarAlumno.Size = New System.Drawing.Size(75, 34)
    Me.btnBuscarAlumno.TabIndex = 0
    Me.btnBuscarAlumno.Text = "&Buscar"
    Me.btnBuscarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscarAlumno.UseVisualStyleBackColor = False
    '
    'txtAlumno
    '
    Me.txtAlumno.BackColor = System.Drawing.SystemColors.Info
    Me.txtAlumno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAlumno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAlumno.Location = New System.Drawing.Point(80, 33)
    Me.txtAlumno.Multiline = True
    Me.txtAlumno.Name = "txtAlumno"
    Me.txtAlumno.ReadOnly = True
    Me.txtAlumno.Size = New System.Drawing.Size(325, 24)
    Me.txtAlumno.TabIndex = 5
    '
    'lblAlumno
    '
    Me.lblAlumno.AutoSize = True
    Me.lblAlumno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAlumno.Location = New System.Drawing.Point(24, 42)
    Me.lblAlumno.Name = "lblAlumno"
    Me.lblAlumno.Size = New System.Drawing.Size(50, 15)
    Me.lblAlumno.TabIndex = 4
    Me.lblAlumno.Text = "A&lumno"
    '
    'dgvApoderados
    '
    Me.dgvApoderados.AllowUserToAddRows = False
    Me.dgvApoderados.AllowUserToDeleteRows = False
    Me.dgvApoderados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvApoderados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdParentesco, Me.cdApoderado})
    Me.dgvApoderados.Location = New System.Drawing.Point(27, 89)
    Me.dgvApoderados.Name = "dgvApoderados"
    Me.dgvApoderados.Size = New System.Drawing.Size(489, 303)
    Me.dgvApoderados.TabIndex = 1
    '
    'cdParentesco
    '
    Me.cdParentesco.DataPropertyName = "Parentesco"
    Me.cdParentesco.HeaderText = "Parentesco"
    Me.cdParentesco.Items.AddRange(New Object() {"MADRE", "PADRE", "TIO(A)"})
    Me.cdParentesco.MaxDropDownItems = 5
    Me.cdParentesco.Name = "cdParentesco"
    Me.cdParentesco.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.cdParentesco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.cdParentesco.Width = 120
    '
    'cdApoderado
    '
    Me.cdApoderado.DataPropertyName = "NombreCompleto"
    Me.cdApoderado.HeaderText = "Pariente"
    Me.cdApoderado.Name = "cdApoderado"
    Me.cdApoderado.ReadOnly = True
    Me.cdApoderado.Width = 300
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(435, 402)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(81, 37)
    Me.btnCancelar.TabIndex = 3
    Me.btnCancelar.Text = "&Cancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnAceptar
    '
    Me.btnAceptar.BackColor = System.Drawing.Color.White
    Me.btnAceptar.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAceptar.Location = New System.Drawing.Point(346, 402)
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(83, 37)
    Me.btnAceptar.TabIndex = 2
    Me.btnAceptar.Text = "&Aceptar"
    Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnAceptar.UseVisualStyleBackColor = False
    '
    'frmModificarApoderados
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(531, 448)
    Me.Controls.Add(Me.btnAceptar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.dgvApoderados)
    Me.Controls.Add(Me.btnBuscarAlumno)
    Me.Controls.Add(Me.txtAlumno)
    Me.Controls.Add(Me.lblAlumno)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmModificarApoderados"
    Me.Text = "Actualización de apoderados"
    CType(Me.dgvApoderados, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnBuscarAlumno As System.Windows.Forms.Button
  Friend WithEvents txtAlumno As System.Windows.Forms.TextBox
  Friend WithEvents lblAlumno As System.Windows.Forms.Label
  Friend WithEvents dgvApoderados As System.Windows.Forms.DataGridView
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnAceptar As System.Windows.Forms.Button
  Friend WithEvents cdParentesco As System.Windows.Forms.DataGridViewComboBoxColumn
  Friend WithEvents cdApoderado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
