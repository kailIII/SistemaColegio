<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
 Partial Class frmMostrarEstadoCuenta
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
    'Me.crptEstadoDeCuenta1 = New rptEstadoDeCuenta
    'Me.cryRepViewEstadoDeCuenta = New CrystalDecisions.Windows.Forms.CrystalReportViewer
    Me.SuspendLayout()
    '
    'cryRepViewEstadoDeCuenta
    '
    'Me.cryRepViewEstadoDeCuenta.ActiveViewIndex = -1
    'Me.cryRepViewEstadoDeCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    'Me.cryRepViewEstadoDeCuenta.Dock = System.Windows.Forms.DockStyle.Fill
    'Me.cryRepViewEstadoDeCuenta.Location = New System.Drawing.Point(0, 0)
    'Me.cryRepViewEstadoDeCuenta.Name = "cryRepViewEstadoDeCuenta"
    'Me.cryRepViewEstadoDeCuenta.SelectionFormula = ""
    'Me.cryRepViewEstadoDeCuenta.Size = New System.Drawing.Size(763, 366)
    'Me.cryRepViewEstadoDeCuenta.TabIndex = 0
    'Me.cryRepViewEstadoDeCuenta.ViewTimeSelectionFormula = ""
    '
    'frmMostrarEstadoCuenta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(763, 366)
    'Me.Controls.Add(Me.cryRepViewEstadoDeCuenta)
    Me.Name = "frmMostrarEstadoCuenta"
    Me.Text = "frmMostrarEstadoCuenta"
    Me.ResumeLayout(False)
  End Sub

  'Friend WithEvents crptEstadoDeCuenta1 As Colegio.Caja.rptEstadoDeCuenta
  'Friend WithEvents cryRepViewEstadoDeCuenta As CrystalDecisions.Windows.Forms.CrystalReportViewer

End Class
