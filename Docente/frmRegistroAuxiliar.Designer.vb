<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroAuxiliar
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
        Me.cboCursoSeccion = New System.Windows.Forms.ComboBox
        Me.lblCurso = New System.Windows.Forms.Label
        Me.txtPeriodo = New System.Windows.Forms.TextBox
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.btnExportar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.gbExportar = New System.Windows.Forms.GroupBox
        Me.pbAvance = New System.Windows.Forms.ProgressBar
        Me.gbExportar.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboCursoSeccion
        '
        Me.cboCursoSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCursoSeccion.FormattingEnabled = True
        Me.cboCursoSeccion.Location = New System.Drawing.Point(63, 33)
        Me.cboCursoSeccion.Name = "cboCursoSeccion"
        Me.cboCursoSeccion.Size = New System.Drawing.Size(256, 21)
        Me.cboCursoSeccion.TabIndex = 1
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurso.Location = New System.Drawing.Point(5, 35)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(39, 15)
        Me.lblCurso.TabIndex = 0
        Me.lblCurso.Text = "&Curso"
        '
        'txtPeriodo
        '
        Me.txtPeriodo.Location = New System.Drawing.Point(72, 12)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.ReadOnly = True
        Me.txtPeriodo.Size = New System.Drawing.Size(168, 20)
        Me.txtPeriodo.TabIndex = 1
        Me.txtPeriodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodo.Location = New System.Drawing.Point(14, 16)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(48, 15)
        Me.lblPeriodo.TabIndex = 0
        Me.lblPeriodo.Text = "&Periodo"
        '
        'btnExportar
        '
        Me.btnExportar.BackColor = System.Drawing.Color.White
        Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(80, 179)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(110, 52)
        Me.btnExportar.TabIndex = 3
        Me.btnExportar.Text = "&Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(235, 179)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'gbExportar
        '
        Me.gbExportar.Controls.Add(Me.pbAvance)
        Me.gbExportar.Controls.Add(Me.cboCursoSeccion)
        Me.gbExportar.Controls.Add(Me.lblCurso)
        Me.gbExportar.Location = New System.Drawing.Point(17, 57)
        Me.gbExportar.Name = "gbExportar"
        Me.gbExportar.Size = New System.Drawing.Size(328, 116)
        Me.gbExportar.TabIndex = 2
        Me.gbExportar.TabStop = False
        Me.gbExportar.Text = "Registro Auxiliar"
        '
        'pbAvance
        '
        Me.pbAvance.BackColor = System.Drawing.Color.White
        Me.pbAvance.Location = New System.Drawing.Point(63, 79)
        Me.pbAvance.Name = "pbAvance"
        Me.pbAvance.Size = New System.Drawing.Size(256, 20)
        Me.pbAvance.TabIndex = 2
        '
        'frmRegistroAuxiliar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 248)
        Me.Controls.Add(Me.gbExportar)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtPeriodo)
        Me.Controls.Add(Me.lblPeriodo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegistroAuxiliar"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Auxiliar"
        Me.gbExportar.ResumeLayout(False)
        Me.gbExportar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
  Friend WithEvents cboCursoSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents lblCurso As System.Windows.Forms.Label
  Friend WithEvents txtPeriodo As System.Windows.Forms.TextBox
  Friend WithEvents lblPeriodo As System.Windows.Forms.Label
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents gbExportar As System.Windows.Forms.GroupBox
  Friend WithEvents pbAvance As System.Windows.Forms.ProgressBar
End Class
