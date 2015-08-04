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
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
    Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
    Me.DatosLaboralesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.AlumnosPorSecciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.DatosDeAlumnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.DirectorioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.DirectorioEspecialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.PadresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.MadresEHijoMayorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.MadresEHijoMenorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.PadresEHijoMayorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.PadresEHijoMenorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuAlumnosCumpleanios = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuConfiguracion = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuAcercaDe = New System.Windows.Forms.ToolStripMenuItem
    Me.ssBarra = New System.Windows.Forms.StatusStrip
    Me.tslblUsuario = New System.Windows.Forms.ToolStripStatusLabel
    Me.tslblSeparador = New System.Windows.Forms.ToolStripStatusLabel
    Me.tslblPeriodo = New System.Windows.Forms.ToolStripStatusLabel
    Me.sdfGuardar = New System.Windows.Forms.SaveFileDialog
    Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuPrincipal.SuspendLayout()
    Me.ssBarra.SuspendLayout()
    CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'mnuPrincipal
    '
    Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAcademico, Me.ToolStripMenuItem2, Me.mnuConfiguracion})
    Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
    Me.mnuPrincipal.Name = "mnuPrincipal"
    Me.mnuPrincipal.Size = New System.Drawing.Size(652, 24)
    Me.mnuPrincipal.TabIndex = 0
    Me.mnuPrincipal.Text = "MenuStrip1"
    '
    'mnuAcademico
    '
    Me.mnuAcademico.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripSeparator2, Me.ToolStripMenuItem3, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
    Me.mnuAcademico.Name = "mnuAcademico"
    Me.mnuAcademico.Size = New System.Drawing.Size(79, 20)
    Me.mnuAcademico.Text = "Académico"
    '
    'ToolStripMenuItem1
    '
    Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    Me.ToolStripMenuItem1.Size = New System.Drawing.Size(217, 22)
    Me.ToolStripMenuItem1.Text = "Estadística de matriculados"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(214, 6)
    '
    'ToolStripMenuItem3
    '
    Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
    Me.ToolStripMenuItem3.Size = New System.Drawing.Size(217, 22)
    Me.ToolStripMenuItem3.Text = "Cambiar cla&ve"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(214, 6)
    '
    'SalirToolStripMenuItem
    '
    Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
    Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
    Me.SalirToolStripMenuItem.Text = "Salir"
    '
    'ToolStripMenuItem2
    '
    Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosLaboralesToolStripMenuItem, Me.AlumnosPorSecciónToolStripMenuItem, Me.ToolStripMenuItem4, Me.DatosDeAlumnoToolStripMenuItem, Me.DirectorioToolStripMenuItem, Me.DirectorioEspecialToolStripMenuItem, Me.PadresToolStripMenuItem, Me.mnuAlumnosCumpleanios})
    Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
    Me.ToolStripMenuItem2.Size = New System.Drawing.Size(84, 20)
    Me.ToolStripMenuItem2.Text = "&Información"
    '
    'DatosLaboralesToolStripMenuItem
    '
    Me.DatosLaboralesToolStripMenuItem.Name = "DatosLaboralesToolStripMenuItem"
    Me.DatosLaboralesToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
    Me.DatosLaboralesToolStripMenuItem.Text = "&Datos laborales"
    '
    'AlumnosPorSecciónToolStripMenuItem
    '
    Me.AlumnosPorSecciónToolStripMenuItem.Name = "AlumnosPorSecciónToolStripMenuItem"
    Me.AlumnosPorSecciónToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
    Me.AlumnosPorSecciónToolStripMenuItem.Text = "&Alumnos por sección"
    '
    'DatosDeAlumnoToolStripMenuItem
    '
    Me.DatosDeAlumnoToolStripMenuItem.Name = "DatosDeAlumnoToolStripMenuItem"
    Me.DatosDeAlumnoToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
    Me.DatosDeAlumnoToolStripMenuItem.Text = "Da&tos de alumno"
    '
    'DirectorioToolStripMenuItem
    '
    Me.DirectorioToolStripMenuItem.Name = "DirectorioToolStripMenuItem"
    Me.DirectorioToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
    Me.DirectorioToolStripMenuItem.Text = "D&irectorio"
    '
    'DirectorioEspecialToolStripMenuItem
    '
    Me.DirectorioEspecialToolStripMenuItem.Name = "DirectorioEspecialToolStripMenuItem"
    Me.DirectorioEspecialToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
    Me.DirectorioEspecialToolStripMenuItem.Text = "Directorio e&special"
    '
    'PadresToolStripMenuItem
    '
    Me.PadresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MadresEHijoMayorToolStripMenuItem, Me.MadresEHijoMenorToolStripMenuItem, Me.PadresEHijoMayorToolStripMenuItem, Me.PadresEHijoMenorToolStripMenuItem})
    Me.PadresToolStripMenuItem.Name = "PadresToolStripMenuItem"
    Me.PadresToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
    Me.PadresToolStripMenuItem.Text = "&Padres"
    '
    'MadresEHijoMayorToolStripMenuItem
    '
    Me.MadresEHijoMayorToolStripMenuItem.Name = "MadresEHijoMayorToolStripMenuItem"
    Me.MadresEHijoMayorToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
    Me.MadresEHijoMayorToolStripMenuItem.Text = "Madres e hijo mayor"
    '
    'MadresEHijoMenorToolStripMenuItem
    '
    Me.MadresEHijoMenorToolStripMenuItem.Name = "MadresEHijoMenorToolStripMenuItem"
    Me.MadresEHijoMenorToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
    Me.MadresEHijoMenorToolStripMenuItem.Text = "Madres e hijo menor"
    '
    'PadresEHijoMayorToolStripMenuItem
    '
    Me.PadresEHijoMayorToolStripMenuItem.Name = "PadresEHijoMayorToolStripMenuItem"
    Me.PadresEHijoMayorToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
    Me.PadresEHijoMayorToolStripMenuItem.Text = "Padres e hijo mayor"
    '
    'PadresEHijoMenorToolStripMenuItem
    '
    Me.PadresEHijoMenorToolStripMenuItem.Name = "PadresEHijoMenorToolStripMenuItem"
    Me.PadresEHijoMenorToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
    Me.PadresEHijoMenorToolStripMenuItem.Text = "Padres e hijo menor"
    '
    'mnuAlumnosCumpleanios
    '
    Me.mnuAlumnosCumpleanios.Name = "mnuAlumnosCumpleanios"
    Me.mnuAlumnosCumpleanios.Size = New System.Drawing.Size(199, 22)
    Me.mnuAlumnosCumpleanios.Text = "Alumnos y cu&mpleaños"
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
    'err
    '
    Me.err.ContainerControl = Me
    '
    'ToolStripMenuItem4
    '
    Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
    Me.ToolStripMenuItem4.Size = New System.Drawing.Size(199, 22)
    Me.ToolStripMenuItem4.Text = "Alumnos por padre"
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
    Me.Text = "Sistema directivo"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.mnuPrincipal.ResumeLayout(False)
    Me.mnuPrincipal.PerformLayout()
    Me.ssBarra.ResumeLayout(False)
    Me.ssBarra.PerformLayout()
    CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents sdfGuardar As System.Windows.Forms.SaveFileDialog
  Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents DatosLaboralesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents err As System.Windows.Forms.ErrorProvider
  Friend WithEvents AlumnosPorSecciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents DatosDeAlumnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents DirectorioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents DirectorioEspecialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents PadresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MadresEHijoMayorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MadresEHijoMenorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents PadresEHijoMayorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents PadresEHijoMenorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuAlumnosCumpleanios As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem

End Class
