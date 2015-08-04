<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarAlumno_new
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
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnSeleccionar = New System.Windows.Forms.Button
    Me.BuscarAlumno1 = New Colegio.IAcademico.BuscarAlumno
    Me.SuspendLayout()
    '
    'btnCancelar
    '
    Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(577, 291)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
    Me.btnCancelar.TabIndex = 2
    Me.btnCancelar.Text = "&Cancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnSeleccionar
    '
    Me.btnSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnSeleccionar.BackColor = System.Drawing.Color.White
    Me.btnSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
    Me.btnSeleccionar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnSeleccionar.Location = New System.Drawing.Point(577, 134)
    Me.btnSeleccionar.Name = "btnSeleccionar"
    Me.btnSeleccionar.Size = New System.Drawing.Size(110, 52)
    Me.btnSeleccionar.TabIndex = 1
    Me.btnSeleccionar.Text = "&Seleccionar"
    Me.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnSeleccionar.UseVisualStyleBackColor = False
    '
    'BuscarAlumno1
    '
    Me.BuscarAlumno1.Location = New System.Drawing.Point(19, 8)
    Me.BuscarAlumno1.Name = "BuscarAlumno1"
    Me.BuscarAlumno1.Size = New System.Drawing.Size(548, 483)
    Me.BuscarAlumno1.TabIndex = 0
    '
    'frmBuscarAlumno_new
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(700, 503)
    Me.Controls.Add(Me.BuscarAlumno1)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnSeleccionar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmBuscarAlumno_new"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Buscar Alumnos"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
  Friend WithEvents BuscarAlumno1 As Colegio.IAcademico.BuscarAlumno
End Class
