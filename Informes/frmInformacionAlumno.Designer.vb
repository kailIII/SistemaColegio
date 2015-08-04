<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformacionAlumno
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
    Me.lblApoderado = New System.Windows.Forms.Label
    Me.lblAnio = New System.Windows.Forms.Label
    Me.lblSeccion = New System.Windows.Forms.Label
    Me.txtSeccion = New System.Windows.Forms.TextBox
    Me.txtAnio = New System.Windows.Forms.TextBox
    Me.txtApoderado = New System.Windows.Forms.TextBox
    Me.txtParentesco = New System.Windows.Forms.TextBox
    Me.txtTutor = New System.Windows.Forms.TextBox
    Me.lblTutor = New System.Windows.Forms.Label
    Me.txtAula = New System.Windows.Forms.TextBox
    Me.lblAula = New System.Windows.Forms.Label
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'btnBuscarAlumno
    '
    Me.btnBuscarAlumno.BackColor = System.Drawing.Color.White
    Me.btnBuscarAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscarAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscarAlumno.Location = New System.Drawing.Point(595, 74)
    Me.btnBuscarAlumno.Name = "btnBuscarAlumno"
    Me.btnBuscarAlumno.Size = New System.Drawing.Size(133, 50)
    Me.btnBuscarAlumno.TabIndex = 0
    Me.btnBuscarAlumno.Text = "&Buscar"
    Me.btnBuscarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscarAlumno.UseVisualStyleBackColor = False
    '
    'txtAlumno
    '
    Me.txtAlumno.BackColor = System.Drawing.SystemColors.Info
    Me.txtAlumno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAlumno.Location = New System.Drawing.Point(131, 89)
    Me.txtAlumno.Multiline = True
    Me.txtAlumno.Name = "txtAlumno"
    Me.txtAlumno.ReadOnly = True
    Me.txtAlumno.Size = New System.Drawing.Size(458, 35)
    Me.txtAlumno.TabIndex = 14
    '
    'lblAlumno
    '
    Me.lblAlumno.AutoSize = True
    Me.lblAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAlumno.Location = New System.Drawing.Point(31, 101)
    Me.lblAlumno.Name = "lblAlumno"
    Me.lblAlumno.Size = New System.Drawing.Size(94, 29)
    Me.lblAlumno.TabIndex = 13
    Me.lblAlumno.Text = "Alumno"
    '
    'lblApoderado
    '
    Me.lblApoderado.AutoSize = True
    Me.lblApoderado.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblApoderado.Location = New System.Drawing.Point(26, 341)
    Me.lblApoderado.Name = "lblApoderado"
    Me.lblApoderado.Size = New System.Drawing.Size(133, 29)
    Me.lblApoderado.TabIndex = 8
    Me.lblApoderado.Text = "Apoderado"
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAnio.Location = New System.Drawing.Point(31, 41)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(55, 29)
    Me.lblAnio.TabIndex = 11
    Me.lblAnio.Text = "Añ&o"
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSeccion.Location = New System.Drawing.Point(31, 161)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(186, 29)
    Me.lblSeccion.TabIndex = 1
    Me.lblSeccion.Text = "&Grado y sección"
    '
    'txtSeccion
    '
    Me.txtSeccion.BackColor = System.Drawing.SystemColors.Info
    Me.txtSeccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtSeccion.Location = New System.Drawing.Point(223, 155)
    Me.txtSeccion.Multiline = True
    Me.txtSeccion.Name = "txtSeccion"
    Me.txtSeccion.ReadOnly = True
    Me.txtSeccion.Size = New System.Drawing.Size(505, 35)
    Me.txtSeccion.TabIndex = 2
    '
    'txtAnio
    '
    Me.txtAnio.BackColor = System.Drawing.SystemColors.Info
    Me.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAnio.Location = New System.Drawing.Point(130, 35)
    Me.txtAnio.Multiline = True
    Me.txtAnio.Name = "txtAnio"
    Me.txtAnio.ReadOnly = True
    Me.txtAnio.Size = New System.Drawing.Size(94, 35)
    Me.txtAnio.TabIndex = 12
    '
    'txtApoderado
    '
    Me.txtApoderado.BackColor = System.Drawing.SystemColors.Info
    Me.txtApoderado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtApoderado.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtApoderado.Location = New System.Drawing.Point(165, 335)
    Me.txtApoderado.Multiline = True
    Me.txtApoderado.Name = "txtApoderado"
    Me.txtApoderado.ReadOnly = True
    Me.txtApoderado.Size = New System.Drawing.Size(424, 35)
    Me.txtApoderado.TabIndex = 9
    '
    'txtParentesco
    '
    Me.txtParentesco.BackColor = System.Drawing.SystemColors.Info
    Me.txtParentesco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtParentesco.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtParentesco.Location = New System.Drawing.Point(595, 335)
    Me.txtParentesco.Multiline = True
    Me.txtParentesco.Name = "txtParentesco"
    Me.txtParentesco.ReadOnly = True
    Me.txtParentesco.Size = New System.Drawing.Size(133, 35)
    Me.txtParentesco.TabIndex = 7
    '
    'txtTutor
    '
    Me.txtTutor.BackColor = System.Drawing.SystemColors.Info
    Me.txtTutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtTutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTutor.Location = New System.Drawing.Point(130, 215)
    Me.txtTutor.Multiline = True
    Me.txtTutor.Name = "txtTutor"
    Me.txtTutor.ReadOnly = True
    Me.txtTutor.Size = New System.Drawing.Size(598, 35)
    Me.txtTutor.TabIndex = 4
    '
    'lblTutor
    '
    Me.lblTutor.AutoSize = True
    Me.lblTutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTutor.Location = New System.Drawing.Point(26, 221)
    Me.lblTutor.Name = "lblTutor"
    Me.lblTutor.Size = New System.Drawing.Size(70, 29)
    Me.lblTutor.TabIndex = 3
    Me.lblTutor.Text = "Tutor"
    '
    'txtAula
    '
    Me.txtAula.BackColor = System.Drawing.SystemColors.Info
    Me.txtAula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAula.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAula.Location = New System.Drawing.Point(130, 275)
    Me.txtAula.Multiline = True
    Me.txtAula.Name = "txtAula"
    Me.txtAula.ReadOnly = True
    Me.txtAula.Size = New System.Drawing.Size(459, 35)
    Me.txtAula.TabIndex = 6
    '
    'lblAula
    '
    Me.lblAula.AutoSize = True
    Me.lblAula.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAula.Location = New System.Drawing.Point(26, 281)
    Me.lblAula.Name = "lblAula"
    Me.lblAula.Size = New System.Drawing.Size(60, 29)
    Me.lblAula.TabIndex = 5
    Me.lblAula.Text = "Aula"
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(595, 454)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(133, 52)
    Me.btnCerrar.TabIndex = 10
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'frmInformacionAlumno
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(740, 518)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.txtAula)
    Me.Controls.Add(Me.lblAula)
    Me.Controls.Add(Me.txtTutor)
    Me.Controls.Add(Me.lblTutor)
    Me.Controls.Add(Me.txtParentesco)
    Me.Controls.Add(Me.txtApoderado)
    Me.Controls.Add(Me.txtAnio)
    Me.Controls.Add(Me.txtSeccion)
    Me.Controls.Add(Me.lblSeccion)
    Me.Controls.Add(Me.lblAnio)
    Me.Controls.Add(Me.lblApoderado)
    Me.Controls.Add(Me.btnBuscarAlumno)
    Me.Controls.Add(Me.txtAlumno)
    Me.Controls.Add(Me.lblAlumno)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmInformacionAlumno"
    Me.Text = "Información de alumno"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnBuscarAlumno As System.Windows.Forms.Button
  Friend WithEvents txtAlumno As System.Windows.Forms.TextBox
  Friend WithEvents lblAlumno As System.Windows.Forms.Label
  Friend WithEvents lblApoderado As System.Windows.Forms.Label
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents txtSeccion As System.Windows.Forms.TextBox
  Friend WithEvents txtAnio As System.Windows.Forms.TextBox
  Friend WithEvents txtApoderado As System.Windows.Forms.TextBox
  Friend WithEvents txtParentesco As System.Windows.Forms.TextBox
  Friend WithEvents txtTutor As System.Windows.Forms.TextBox
  Friend WithEvents lblTutor As System.Windows.Forms.Label
  Friend WithEvents txtAula As System.Windows.Forms.TextBox
  Friend WithEvents lblAula As System.Windows.Forms.Label
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
End Class
