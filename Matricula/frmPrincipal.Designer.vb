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
    Me.components = New System.ComponentModel.Container
    Me.mnuPrincipal = New System.Windows.Forms.MenuStrip
    Me.mnuAcademico = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuGestionAlumnos = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuGestionDePadresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuGestionMatriculas = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
    Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuConfiguracion = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuAcercaDe = New System.Windows.Forms.ToolStripMenuItem
    Me.ssBarra = New System.Windows.Forms.StatusStrip
    Me.tslblUsuario = New System.Windows.Forms.ToolStripStatusLabel
    Me.tslblSeparador = New System.Windows.Forms.ToolStripStatusLabel
    Me.tslblPeriodo = New System.Windows.Forms.ToolStripStatusLabel
    Me.errGeneral = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.sfdGuardar = New System.Windows.Forms.SaveFileDialog
    Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuPrincipal.SuspendLayout()
    Me.ssBarra.SuspendLayout()
    CType(Me.errGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'mnuPrincipal
    '
    Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAcademico, Me.mnuConfiguracion})
    Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
    Me.mnuPrincipal.Name = "mnuPrincipal"
    Me.mnuPrincipal.Size = New System.Drawing.Size(652, 24)
    Me.mnuPrincipal.TabIndex = 0
    Me.mnuPrincipal.Text = "MenuStrip1"
    '
    'mnuAcademico
    '
    Me.mnuAcademico.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGestionAlumnos, Me.ToolStripMenuItem2, Me.mnuGestionDePadresToolStripMenuItem, Me.mnuGestionMatriculas, Me.ToolStripMenuItem4, Me.ToolStripMenuItem3, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
    Me.mnuAcademico.Name = "mnuAcademico"
    Me.mnuAcademico.Size = New System.Drawing.Size(79, 20)
    Me.mnuAcademico.Text = "Académico"
    '
    'mnuGestionAlumnos
    '
    Me.mnuGestionAlumnos.Name = "mnuGestionAlumnos"
    Me.mnuGestionAlumnos.Size = New System.Drawing.Size(226, 22)
    Me.mnuGestionAlumnos.Tag = "24"
    Me.mnuGestionAlumnos.Text = "Gestión de &alumnos"
    '
    'ToolStripMenuItem2
    '
    Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
    Me.ToolStripMenuItem2.Size = New System.Drawing.Size(226, 22)
    Me.ToolStripMenuItem2.Text = "&Actualización de apoderados"
    '
    'mnuGestionDePadresToolStripMenuItem
    '
    Me.mnuGestionDePadresToolStripMenuItem.Name = "mnuGestionDePadresToolStripMenuItem"
    Me.mnuGestionDePadresToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
    Me.mnuGestionDePadresToolStripMenuItem.Tag = "25"
    Me.mnuGestionDePadresToolStripMenuItem.Text = "Gestion de &padres"
    '
    'mnuGestionMatriculas
    '
    Me.mnuGestionMatriculas.Name = "mnuGestionMatriculas"
    Me.mnuGestionMatriculas.Size = New System.Drawing.Size(226, 22)
    Me.mnuGestionMatriculas.Tag = "26"
    Me.mnuGestionMatriculas.Text = "Gestión de &matrículas"
    '
    'ToolStripMenuItem3
    '
    Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
    Me.ToolStripMenuItem3.Size = New System.Drawing.Size(226, 22)
    Me.ToolStripMenuItem3.Text = "Generación de &carnet"
    '
    'ToolStripMenuItem1
    '
    Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    Me.ToolStripMenuItem1.Size = New System.Drawing.Size(223, 6)
    '
    'SalirToolStripMenuItem
    '
    Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
    Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(226, 22)
    Me.SalirToolStripMenuItem.Text = "&Salir"
    '
    'mnuConfiguracion
    '
    Me.mnuConfiguracion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAcercaDe})
    Me.mnuConfiguracion.Name = "mnuConfiguracion"
    Me.mnuConfiguracion.Size = New System.Drawing.Size(95, 20)
    Me.mnuConfiguracion.Text = "&Configuración"
    '
    'mnuAcercaDe
    '
    Me.mnuAcercaDe.Name = "mnuAcercaDe"
    Me.mnuAcercaDe.Size = New System.Drawing.Size(126, 22)
    Me.mnuAcercaDe.Text = "Acerca de"
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
    'errGeneral
    '
    Me.errGeneral.ContainerControl = Me
    '
    'ToolStripMenuItem4
    '
    Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
    Me.ToolStripMenuItem4.Size = New System.Drawing.Size(226, 22)
    Me.ToolStripMenuItem4.Text = "Trasladar alumnos"
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
    Me.Text = "Sistema de Gestión Académica"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.mnuPrincipal.ResumeLayout(False)
    Me.mnuPrincipal.PerformLayout()
    Me.ssBarra.ResumeLayout(False)
    Me.ssBarra.PerformLayout()
    CType(Me.errGeneral, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
    Friend WithEvents mnuPrincipal As System.Windows.Forms.MenuStrip
  Friend WithEvents ssBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents tslblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslblPeriodo As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslblSeparador As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents mnuConfiguracion As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuAcercaDe As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuAcademico As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuGestionAlumnos As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuGestionDePadresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuGestionMatriculas As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents errGeneral As System.Windows.Forms.ErrorProvider
  Friend WithEvents sfdGuardar As System.Windows.Forms.SaveFileDialog
  Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem

End Class
