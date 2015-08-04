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
    Me.mnuPrincipal = New System.Windows.Forms.MenuStrip()
    Me.mnuMantenimiento = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCambiarContrasenia = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
    Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.AsignarDocenteAAreasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.AlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.RegistrarNotaDeInvestigaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.tsLibreta = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuNotasInvestigacion = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuNotasPlanLectorInvestigacion = New System.Windows.Forms.ToolStripMenuItem()
    Me.ssBarra = New System.Windows.Forms.StatusStrip()
    Me.tslblPeriodo = New System.Windows.Forms.ToolStripStatusLabel()
    Me.sfdGuardarArchivo = New System.Windows.Forms.SaveFileDialog()
    Me.ofdAbrirArchivo = New System.Windows.Forms.OpenFileDialog()
    Me.tslblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
    Me.tslblSeparador = New System.Windows.Forms.ToolStripStatusLabel()
    Me.mnuPrincipal.SuspendLayout()
    Me.ssBarra.SuspendLayout()
    Me.SuspendLayout()
    '
    'mnuPrincipal
    '
    Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMantenimiento, Me.ReportesToolStripMenuItem, Me.AlumnoToolStripMenuItem, Me.tsLibreta})
    Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
    Me.mnuPrincipal.Name = "mnuPrincipal"
    Me.mnuPrincipal.Size = New System.Drawing.Size(616, 24)
    Me.mnuPrincipal.TabIndex = 0
    Me.mnuPrincipal.Text = "MenuStrip1"
    '
    'mnuMantenimiento
    '
    Me.mnuMantenimiento.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCambiarContrasenia, Me.ToolStripSeparator1, Me.mnuSalir})
    Me.mnuMantenimiento.Name = "mnuMantenimiento"
    Me.mnuMantenimiento.Size = New System.Drawing.Size(101, 20)
    Me.mnuMantenimiento.Text = "&Mantenimiento"
    '
    'mnuCambiarContrasenia
    '
    Me.mnuCambiarContrasenia.Name = "mnuCambiarContrasenia"
    Me.mnuCambiarContrasenia.Size = New System.Drawing.Size(182, 22)
    Me.mnuCambiarContrasenia.Tag = "1"
    Me.mnuCambiarContrasenia.Text = "&Cambiar Contraseña"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(179, 6)
    '
    'mnuSalir
    '
    Me.mnuSalir.Name = "mnuSalir"
    Me.mnuSalir.Size = New System.Drawing.Size(182, 22)
    Me.mnuSalir.Tag = "5"
    Me.mnuSalir.Text = "&Salir"
    '
    'ReportesToolStripMenuItem
    '
    Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsignarDocenteAAreasToolStripMenuItem})
    Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
    Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
    Me.ReportesToolStripMenuItem.Text = "Investigación"
    '
    'AsignarDocenteAAreasToolStripMenuItem
    '
    Me.AsignarDocenteAAreasToolStripMenuItem.Name = "AsignarDocenteAAreasToolStripMenuItem"
    Me.AsignarDocenteAAreasToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
    Me.AsignarDocenteAAreasToolStripMenuItem.Text = "Asignar Docente a Areas"
    '
    'AlumnoToolStripMenuItem
    '
    Me.AlumnoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarNotaDeInvestigaciónToolStripMenuItem})
    Me.AlumnoToolStripMenuItem.Name = "AlumnoToolStripMenuItem"
    Me.AlumnoToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
    Me.AlumnoToolStripMenuItem.Text = "Alumno"
    '
    'RegistrarNotaDeInvestigaciónToolStripMenuItem
    '
    Me.RegistrarNotaDeInvestigaciónToolStripMenuItem.Name = "RegistrarNotaDeInvestigaciónToolStripMenuItem"
    Me.RegistrarNotaDeInvestigaciónToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
    Me.RegistrarNotaDeInvestigaciónToolStripMenuItem.Text = "Registrar Nota de Investigación"
    '
    'tsLibreta
    '
    Me.tsLibreta.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNotasInvestigacion, Me.mnuNotasPlanLectorInvestigacion})
    Me.tsLibreta.Name = "tsLibreta"
    Me.tsLibreta.Size = New System.Drawing.Size(55, 20)
    Me.tsLibreta.Text = "&Libreta"
    '
    'mnuNotasInvestigacion
    '
    Me.mnuNotasInvestigacion.Name = "mnuNotasInvestigacion"
    Me.mnuNotasInvestigacion.Size = New System.Drawing.Size(265, 22)
    Me.mnuNotasInvestigacion.Text = "&Notas de Investigación"
    '
    'mnuNotasPlanLectorInvestigacion
    '
    Me.mnuNotasPlanLectorInvestigacion.Name = "mnuNotasPlanLectorInvestigacion"
    Me.mnuNotasPlanLectorInvestigacion.Size = New System.Drawing.Size(265, 22)
    Me.mnuNotasPlanLectorInvestigacion.Text = "Notas de &Investigación y Plan Lector"
    '
    'ssBarra
    '
    Me.ssBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslblUsuario, Me.tslblSeparador, Me.tslblPeriodo})
    Me.ssBarra.Location = New System.Drawing.Point(0, 418)
    Me.ssBarra.Name = "ssBarra"
    Me.ssBarra.Size = New System.Drawing.Size(616, 22)
    Me.ssBarra.TabIndex = 2
    Me.ssBarra.Text = "StatusBar"
    '
    'tslblPeriodo
    '
    Me.tslblPeriodo.Name = "tslblPeriodo"
    Me.tslblPeriodo.Size = New System.Drawing.Size(83, 17)
    Me.tslblPeriodo.Text = "Periodo actual"
    '
    'ofdAbrirArchivo
    '
    Me.ofdAbrirArchivo.FileName = "OpenFileDialog1"
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
    'frmPrincipal
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.ClientSize = New System.Drawing.Size(616, 440)
    Me.Controls.Add(Me.ssBarra)
    Me.Controls.Add(Me.mnuPrincipal)
    Me.IsMdiContainer = True
    Me.MainMenuStrip = Me.mnuPrincipal
    Me.Name = "frmPrincipal"
    Me.Text = "Sistema de Gestión Académica -Investigación"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.mnuPrincipal.ResumeLayout(False)
    Me.mnuPrincipal.PerformLayout()
    Me.ssBarra.ResumeLayout(False)
    Me.ssBarra.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents mnuPrincipal As System.Windows.Forms.MenuStrip
  Friend WithEvents mnuMantenimiento As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ssBarra As System.Windows.Forms.StatusStrip
  Friend WithEvents tslblPeriodo As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents mnuCambiarContrasenia As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents AsignarDocenteAAreasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents AlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents RegistrarNotaDeInvestigaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents sfdGuardarArchivo As System.Windows.Forms.SaveFileDialog
  Friend WithEvents ofdAbrirArchivo As System.Windows.Forms.OpenFileDialog
  Friend WithEvents tsLibreta As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuNotasInvestigacion As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuNotasPlanLectorInvestigacion As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents tslblUsuario As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents tslblSeparador As System.Windows.Forms.ToolStripStatusLabel

End Class
