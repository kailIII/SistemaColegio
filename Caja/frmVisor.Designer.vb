<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisor
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
    Me.crvVisor = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
    Me.SuspendLayout()
    '
    'crvVisor
    '
    Me.crvVisor.ActiveViewIndex = -1
    Me.crvVisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.crvVisor.Cursor = System.Windows.Forms.Cursors.Default
    Me.crvVisor.Dock = System.Windows.Forms.DockStyle.Fill
    Me.crvVisor.Location = New System.Drawing.Point(0, 0)
    Me.crvVisor.Name = "crvVisor"
    Me.crvVisor.SelectionFormula = ""
    Me.crvVisor.ShowCloseButton = False
    Me.crvVisor.ShowExportButton = False
    Me.crvVisor.ShowGotoPageButton = False
    Me.crvVisor.ShowGroupTreeButton = False
    Me.crvVisor.ShowPageNavigateButtons = False
    Me.crvVisor.ShowPrintButton = False
    Me.crvVisor.ShowRefreshButton = False
    Me.crvVisor.ShowTextSearchButton = False
    Me.crvVisor.ShowZoomButton = False
    Me.crvVisor.Size = New System.Drawing.Size(720, 509)
    Me.crvVisor.TabIndex = 0
    Me.crvVisor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
    Me.crvVisor.ViewTimeSelectionFormula = ""
    '
    'frmVisor
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(720, 509)
    Me.Controls.Add(Me.crvVisor)
    Me.KeyPreview = True
    Me.Name = "frmVisor"
    Me.Text = "Vista previa"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents crvVisor As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
