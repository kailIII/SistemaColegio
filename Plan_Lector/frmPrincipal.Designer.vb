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
    Me.mnuMantenimiento = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuCambiar = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem
    Me.PlanLectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuGestiónDePresentaciones = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuRegistrarLibro = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuAsignarLibroGrado = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuGestionAutores = New System.Windows.Forms.ToolStripMenuItem
    Me.AsignarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuLibrosPorGrado = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
    Me.RegistroPorSecciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.RegistroPorResponsableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuExportarRegistro = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuImportarRegistro = New System.Windows.Forms.ToolStripMenuItem
    Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuNotas = New System.Windows.Forms.ToolStripMenuItem
    Me.AlumnosYPromedioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.AlumnosNoProgramadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuConsolidadoNotasSeccion = New System.Windows.Forms.ToolStripMenuItem
    Me.ssBarra = New System.Windows.Forms.StatusStrip
    Me.tslblUsuario = New System.Windows.Forms.ToolStripStatusLabel
    Me.tslblSeparador = New System.Windows.Forms.ToolStripStatusLabel
    Me.tslblPeriodo = New System.Windows.Forms.ToolStripStatusLabel
    Me.sfdGuardarArchivo = New System.Windows.Forms.SaveFileDialog
    Me.ofdAbrirArchivo = New System.Windows.Forms.OpenFileDialog
    Me.mnuPrincipal.SuspendLayout()
    Me.ssBarra.SuspendLayout()
    Me.SuspendLayout()
    '
    'mnuPrincipal
    '
    Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMantenimiento, Me.PlanLectorToolStripMenuItem, Me.AsignarToolStripMenuItem, Me.ReportesToolStripMenuItem})
    Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
    Me.mnuPrincipal.Name = "mnuPrincipal"
    Me.mnuPrincipal.Size = New System.Drawing.Size(616, 24)
    Me.mnuPrincipal.TabIndex = 0
    Me.mnuPrincipal.Text = "MenuStrip1"
    '
    'mnuMantenimiento
    '
    Me.mnuMantenimiento.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCambiar, Me.ToolStripSeparator1, Me.mnuSalir})
    Me.mnuMantenimiento.Name = "mnuMantenimiento"
    Me.mnuMantenimiento.Size = New System.Drawing.Size(101, 20)
    Me.mnuMantenimiento.Text = "&Mantenimiento"
    '
    'mnuCambiar
    '
    Me.mnuCambiar.Name = "mnuCambiar"
    Me.mnuCambiar.Size = New System.Drawing.Size(182, 22)
    Me.mnuCambiar.Tag = "1"
    Me.mnuCambiar.Text = "Cambiar C&ontraseña"
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
    Me.mnuSalir.Tag = "2"
    Me.mnuSalir.Text = "&Salir"
    '
    'PlanLectorToolStripMenuItem
    '
    Me.PlanLectorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGestiónDePresentaciones, Me.ToolStripMenuItem4, Me.mnuGestionAutores})
    Me.PlanLectorToolStripMenuItem.Name = "PlanLectorToolStripMenuItem"
    Me.PlanLectorToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
    Me.PlanLectorToolStripMenuItem.Text = "Plan Lector"
    '
    'mnuGestiónDePresentaciones
    '
    Me.mnuGestiónDePresentaciones.Name = "mnuGestiónDePresentaciones"
    Me.mnuGestiónDePresentaciones.Size = New System.Drawing.Size(212, 22)
    Me.mnuGestiónDePresentaciones.Tag = "3"
    Me.mnuGestiónDePresentaciones.Text = "Gestión de &Presentaciones"
    '
    'ToolStripMenuItem4
    '
    Me.ToolStripMenuItem4.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRegistrarLibro, Me.mnuAsignarLibroGrado})
    Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
    Me.ToolStripMenuItem4.Size = New System.Drawing.Size(212, 22)
    Me.ToolStripMenuItem4.Text = "Gestión de &Libros"
    '
    'mnuRegistrarLibro
    '
    Me.mnuRegistrarLibro.Name = "mnuRegistrarLibro"
    Me.mnuRegistrarLibro.Size = New System.Drawing.Size(163, 22)
    Me.mnuRegistrarLibro.Tag = "4"
    Me.mnuRegistrarLibro.Text = "&Registrar"
    '
    'mnuAsignarLibroGrado
    '
    Me.mnuAsignarLibroGrado.Name = "mnuAsignarLibroGrado"
    Me.mnuAsignarLibroGrado.Size = New System.Drawing.Size(163, 22)
    Me.mnuAsignarLibroGrado.Tag = "5"
    Me.mnuAsignarLibroGrado.Text = "&Asignar a Grados"
    '
    'mnuGestionAutores
    '
    Me.mnuGestionAutores.Name = "mnuGestionAutores"
    Me.mnuGestionAutores.Size = New System.Drawing.Size(212, 22)
    Me.mnuGestionAutores.Tag = "6"
    Me.mnuGestionAutores.Text = "&Gestión de Autores"
    '
    'AsignarToolStripMenuItem
    '
    Me.AsignarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLibrosPorGrado, Me.ToolStripMenuItem1, Me.mnuExportarRegistro, Me.mnuImportarRegistro})
    Me.AsignarToolStripMenuItem.Name = "AsignarToolStripMenuItem"
    Me.AsignarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
    Me.AsignarToolStripMenuItem.Text = "&Alumno"
    '
    'mnuLibrosPorGrado
    '
    Me.mnuLibrosPorGrado.Name = "mnuLibrosPorGrado"
    Me.mnuLibrosPorGrado.Size = New System.Drawing.Size(166, 22)
    Me.mnuLibrosPorGrado.Tag = "7"
    Me.mnuLibrosPorGrado.Text = "Asignar &Libros"
    '
    'ToolStripMenuItem1
    '
    Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroPorSecciónToolStripMenuItem, Me.RegistroPorResponsableToolStripMenuItem})
    Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    Me.ToolStripMenuItem1.Size = New System.Drawing.Size(166, 22)
    Me.ToolStripMenuItem1.Text = "Evaluación"
    '
    'RegistroPorSecciónToolStripMenuItem
    '
    Me.RegistroPorSecciónToolStripMenuItem.Name = "RegistroPorSecciónToolStripMenuItem"
    Me.RegistroPorSecciónToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
    Me.RegistroPorSecciónToolStripMenuItem.Text = "Registro por sección"
    '
    'RegistroPorResponsableToolStripMenuItem
    '
    Me.RegistroPorResponsableToolStripMenuItem.Name = "RegistroPorResponsableToolStripMenuItem"
    Me.RegistroPorResponsableToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
    Me.RegistroPorResponsableToolStripMenuItem.Text = "Registro por responsable"
    '
    'mnuExportarRegistro
    '
    Me.mnuExportarRegistro.Name = "mnuExportarRegistro"
    Me.mnuExportarRegistro.Size = New System.Drawing.Size(166, 22)
    Me.mnuExportarRegistro.Text = "&Exportar Registro"
    '
    'mnuImportarRegistro
    '
    Me.mnuImportarRegistro.Name = "mnuImportarRegistro"
    Me.mnuImportarRegistro.Size = New System.Drawing.Size(166, 22)
    Me.mnuImportarRegistro.Text = "&Importar Registro"
    '
    'ReportesToolStripMenuItem
    '
    Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNotas, Me.AlumnosYPromedioToolStripMenuItem, Me.AlumnosNoProgramadosToolStripMenuItem, Me.mnuConsolidadoNotasSeccion})
    Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
    Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
    Me.ReportesToolStripMenuItem.Text = "&Reportes"
    '
    'mnuNotas
    '
    Me.mnuNotas.Name = "mnuNotas"
    Me.mnuNotas.Size = New System.Drawing.Size(213, 22)
    Me.mnuNotas.Text = "&Notas"
    '
    'AlumnosYPromedioToolStripMenuItem
    '
    Me.AlumnosYPromedioToolStripMenuItem.Name = "AlumnosYPromedioToolStripMenuItem"
    Me.AlumnosYPromedioToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
    Me.AlumnosYPromedioToolStripMenuItem.Text = "&Alumnos y promedio"
    '
    'AlumnosNoProgramadosToolStripMenuItem
    '
    Me.AlumnosNoProgramadosToolStripMenuItem.Name = "AlumnosNoProgramadosToolStripMenuItem"
    Me.AlumnosNoProgramadosToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
    Me.AlumnosNoProgramadosToolStripMenuItem.Text = "Alumnos no &programados"
    '
    'mnuConsolidadoNotasSeccion
    '
    Me.mnuConsolidadoNotasSeccion.Name = "mnuConsolidadoNotasSeccion"
    Me.mnuConsolidadoNotasSeccion.Size = New System.Drawing.Size(213, 22)
    Me.mnuConsolidadoNotasSeccion.Text = "Consolidado por sección"
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
    'ofdAbrirArchivo
    '
    Me.ofdAbrirArchivo.FileName = "OpenFileDialog1"
    '
    'frmPrincipal
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(616, 440)
    Me.Controls.Add(Me.ssBarra)
    Me.Controls.Add(Me.mnuPrincipal)
    Me.IsMdiContainer = True
    Me.MainMenuStrip = Me.mnuPrincipal
    Me.Name = "frmPrincipal"
    Me.Text = "Sistema de Gestión Académica - Plan Lector"
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
  Friend WithEvents ssBarra As System.Windows.Forms.StatusStrip
  Friend WithEvents tslblUsuario As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents tslblPeriodo As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents tslblSeparador As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuCambiar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents AsignarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuLibrosPorGrado As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents PlanLectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuGestiónDePresentaciones As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuRegistrarLibro As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuAsignarLibroGrado As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuGestionAutores As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuExportarRegistro As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuImportarRegistro As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuNotas As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents AlumnosYPromedioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents AlumnosNoProgramadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuConsolidadoNotasSeccion As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents sfdGuardarArchivo As System.Windows.Forms.SaveFileDialog
  Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents RegistroPorSecciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents RegistroPorResponsableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ofdAbrirArchivo As System.Windows.Forms.OpenFileDialog

End Class
