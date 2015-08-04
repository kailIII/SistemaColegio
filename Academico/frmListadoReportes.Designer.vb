<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoReportes
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
    Me.lstReportes = New System.Windows.Forms.ListBox
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnPresentar = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'lstReportes
    '
    Me.lstReportes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lstReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lstReportes.FormattingEnabled = True
    Me.lstReportes.ItemHeight = 20
    Me.lstReportes.Location = New System.Drawing.Point(12, 49)
    Me.lstReportes.Name = "lstReportes"
    Me.lstReportes.Size = New System.Drawing.Size(651, 424)
    Me.lstReportes.TabIndex = 0
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Location = New System.Drawing.Point(588, 508)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
    Me.btnCerrar.TabIndex = 2
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.UseVisualStyleBackColor = True
    '
    'btnPresentar
    '
    Me.btnPresentar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnPresentar.Location = New System.Drawing.Point(12, 508)
    Me.btnPresentar.Name = "btnPresentar"
    Me.btnPresentar.Size = New System.Drawing.Size(75, 23)
    Me.btnPresentar.TabIndex = 1
    Me.btnPresentar.Text = "&Presentar"
    Me.btnPresentar.UseVisualStyleBackColor = True
    '
    'frmListadoReportes
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCerrar
    Me.ClientSize = New System.Drawing.Size(675, 543)
    Me.Controls.Add(Me.btnPresentar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.lstReportes)
    Me.Name = "frmListadoReportes"
    Me.Text = "Listado de reportes"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents lstReportes As System.Windows.Forms.ListBox
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnPresentar As System.Windows.Forms.Button
End Class
