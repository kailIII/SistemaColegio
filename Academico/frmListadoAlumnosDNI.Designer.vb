<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoAlumnosDNI
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
    Me.btnExportar = New System.Windows.Forms.Button()
    Me.pbAvance = New System.Windows.Forms.ProgressBar()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'btnExportar
    '
    Me.btnExportar.Location = New System.Drawing.Point(240, 215)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(87, 23)
    Me.btnExportar.TabIndex = 3
    Me.btnExportar.Text = "E&xportar"
    Me.btnExportar.UseVisualStyleBackColor = True
    '
    'pbAvance
    '
    Me.pbAvance.Location = New System.Drawing.Point(30, 147)
    Me.pbAvance.Name = "pbAvance"
    Me.pbAvance.Size = New System.Drawing.Size(390, 29)
    Me.pbAvance.TabIndex = 2
    Me.pbAvance.Visible = False
    '
    'btnCerrar
    '
    Me.btnCerrar.Location = New System.Drawing.Point(333, 215)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(87, 23)
    Me.btnCerrar.TabIndex = 4
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.UseVisualStyleBackColor = True
    '
    'frmListadoAlumnosDNI
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(443, 263)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.pbAvance)
    Me.Controls.Add(Me.btnCerrar)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmListadoAlumnosDNI"
    Me.Text = "Listado completo de alumnos"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents pbAvance As System.Windows.Forms.ProgressBar
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
End Class
