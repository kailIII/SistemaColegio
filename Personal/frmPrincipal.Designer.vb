<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
    Me.mnuPrincipal = New System.Windows.Forms.MenuStrip
    Me.mnuAcademico = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuGestionService = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuAcademico2 = New System.Windows.Forms.ToolStripSeparator
    Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem
    Me.ssBarra = New System.Windows.Forms.StatusStrip
    Me.tslblUsuario = New System.Windows.Forms.ToolStripStatusLabel
    Me.tslblSeparador = New System.Windows.Forms.ToolStripStatusLabel
    Me.tslblPeriodo = New System.Windows.Forms.ToolStripStatusLabel
    Me.mnuPrincipal.SuspendLayout()
    Me.ssBarra.SuspendLayout()
    Me.SuspendLayout()
    '
    'mnuPrincipal
    '
    Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAcademico})
    Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
    Me.mnuPrincipal.Name = "mnuPrincipal"
    Me.mnuPrincipal.Size = New System.Drawing.Size(652, 24)
    Me.mnuPrincipal.TabIndex = 0
    Me.mnuPrincipal.Text = "MenuStrip1"
    '
    'mnuAcademico
    '
    Me.mnuAcademico.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGestionService, Me.ToolStripMenuItem1, Me.mnuAcademico2, Me.mnuSalir})
    Me.mnuAcademico.Name = "mnuAcademico"
    Me.mnuAcademico.Size = New System.Drawing.Size(67, 20)
    Me.mnuAcademico.Text = "&Registros"
    '
    'mnuGestionService
    '
    Me.mnuGestionService.Name = "mnuGestionService"
    Me.mnuGestionService.Size = New System.Drawing.Size(242, 22)
    Me.mnuGestionService.Tag = "24"
    Me.mnuGestionService.Text = "Gestión de &service"
    '
    'ToolStripMenuItem1
    '
    Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    Me.ToolStripMenuItem1.Size = New System.Drawing.Size(242, 22)
    Me.ToolStripMenuItem1.Text = "Gestión de regimen pensionario"
    '
    'mnuAcademico2
    '
    Me.mnuAcademico2.Name = "mnuAcademico2"
    Me.mnuAcademico2.Size = New System.Drawing.Size(239, 6)
    '
    'mnuSalir
    '
    Me.mnuSalir.Name = "mnuSalir"
    Me.mnuSalir.Size = New System.Drawing.Size(242, 22)
    Me.mnuSalir.Text = "Salir"
    '
    'ssBarra
    '
    Me.ssBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslblUsuario, Me.tslblSeparador, Me.tslblPeriodo})
    Me.ssBarra.Location = New System.Drawing.Point(0, 437)
    Me.ssBarra.Name = "ssBarra"
    Me.ssBarra.Size = New System.Drawing.Size(652, 22)
    Me.ssBarra.TabIndex = 2
    Me.ssBarra.Text = "StatusBar"
    '
    'tslblUsuario
    '
    Me.tslblUsuario.Name = "tslblUsuario"
    Me.tslblUsuario.Size = New System.Drawing.Size(112, 17)
    Me.tslblUsuario.Text = "Nombre del usuario"
    '
    'tslblSeparador
    '
    Me.tslblSeparador.AutoSize = False
    Me.tslblSeparador.Name = "tslblSeparador"
    Me.tslblSeparador.Size = New System.Drawing.Size(300, 17)
    '
    'tslblPeriodo
    '
    Me.tslblPeriodo.Name = "tslblPeriodo"
    Me.tslblPeriodo.Size = New System.Drawing.Size(83, 17)
    Me.tslblPeriodo.Text = "Periodo actual"
    '
    'frmPrincipal
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(652, 459)
    Me.Controls.Add(Me.ssBarra)
    Me.Controls.Add(Me.mnuPrincipal)
    Me.IsMdiContainer = True
    Me.MainMenuStrip = Me.mnuPrincipal
    Me.Name = "frmPrincipal"
    Me.Text = "Sistema de Gestión de Personal"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.mnuPrincipal.ResumeLayout(False)
    Me.mnuPrincipal.PerformLayout()
    Me.ssBarra.ResumeLayout(False)
    Me.ssBarra.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents mnuPrincipal As System.Windows.Forms.MenuStrip
  Friend WithEvents mnuAcademico As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuGestionService As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuAcademico2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ssBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents tslblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslblPeriodo As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents tslblSeparador As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
