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
    Me.mnuMantenimiento = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuCambiar = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuCalificar = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuGestionDeComp = New System.Windows.Forms.ToolStripMenuItem
    Me.PlanLectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuAsignarLibros = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuNotasPlanLector = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuExportarRegistro = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuImportarRegistro = New System.Windows.Forms.ToolStripMenuItem
    Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.ListadoDeAlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.ssBarra = New System.Windows.Forms.StatusStrip
    Me.tslblUsuario = New System.Windows.Forms.ToolStripStatusLabel
    Me.tslblSeparador = New System.Windows.Forms.ToolStripStatusLabel
    Me.tslblPeriodo = New System.Windows.Forms.ToolStripStatusLabel
    Me.errGeneral = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.sfdGuardar = New System.Windows.Forms.SaveFileDialog
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuPrincipal.SuspendLayout()
    Me.ssBarra.SuspendLayout()
    CType(Me.errGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'mnuPrincipal
    '
    Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMantenimiento, Me.mnuCalificar, Me.ReportesToolStripMenuItem})
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
    Me.mnuSalir.Tag = "3"
    Me.mnuSalir.Text = "&Salir"
    '
    'mnuCalificar
    '
    Me.mnuCalificar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.mnuGestionDeComp, Me.PlanLectorToolStripMenuItem})
    Me.mnuCalificar.Name = "mnuCalificar"
    Me.mnuCalificar.Size = New System.Drawing.Size(62, 20)
    Me.mnuCalificar.Text = "&Calificar"
    '
    'mnuGestionDeComp
    '
    Me.mnuGestionDeComp.Name = "mnuGestionDeComp"
    Me.mnuGestionDeComp.Size = New System.Drawing.Size(225, 22)
    Me.mnuGestionDeComp.Tag = "2"
    Me.mnuGestionDeComp.Text = "Gestión de C&omportamiento"
    '
    'PlanLectorToolStripMenuItem
    '
    Me.PlanLectorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAsignarLibros, Me.mnuNotasPlanLector, Me.mnuExportarRegistro, Me.mnuImportarRegistro})
    Me.PlanLectorToolStripMenuItem.Name = "PlanLectorToolStripMenuItem"
    Me.PlanLectorToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
    Me.PlanLectorToolStripMenuItem.Text = "Plan Lector"
    '
    'mnuAsignarLibros
    '
    Me.mnuAsignarLibros.Name = "mnuAsignarLibros"
    Me.mnuAsignarLibros.Size = New System.Drawing.Size(166, 22)
    Me.mnuAsignarLibros.Tag = "4"
    Me.mnuAsignarLibros.Text = "&Asignar Libros"
    '
    'mnuNotasPlanLector
    '
    Me.mnuNotasPlanLector.Name = "mnuNotasPlanLector"
    Me.mnuNotasPlanLector.Size = New System.Drawing.Size(166, 22)
    Me.mnuNotasPlanLector.Tag = "5"
    Me.mnuNotasPlanLector.Text = "&Notas"
    '
    'mnuExportarRegistro
    '
    Me.mnuExportarRegistro.Name = "mnuExportarRegistro"
    Me.mnuExportarRegistro.Size = New System.Drawing.Size(166, 22)
    Me.mnuExportarRegistro.Tag = "6"
    Me.mnuExportarRegistro.Text = "&Exportar Registro"
    '
    'mnuImportarRegistro
    '
    Me.mnuImportarRegistro.Name = "mnuImportarRegistro"
    Me.mnuImportarRegistro.Size = New System.Drawing.Size(166, 22)
    Me.mnuImportarRegistro.Tag = "7"
    Me.mnuImportarRegistro.Text = "&Importar Registro"
    '
    'ReportesToolStripMenuItem
    '
    Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoDeAlumnosToolStripMenuItem})
    Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
    Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
    Me.ReportesToolStripMenuItem.Text = "&Reportes"
    '
    'ListadoDeAlumnosToolStripMenuItem
    '
    Me.ListadoDeAlumnosToolStripMenuItem.Name = "ListadoDeAlumnosToolStripMenuItem"
    Me.ListadoDeAlumnosToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
    Me.ListadoDeAlumnosToolStripMenuItem.Text = "Listado de alumnos"
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
    'errGeneral
    '
    Me.errGeneral.ContainerControl = Me
    '
    'ToolStripMenuItem1
    '
    Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    Me.ToolStripMenuItem1.Size = New System.Drawing.Size(225, 22)
    Me.ToolStripMenuItem1.Text = "Gestión de asistencia"
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
    Me.Text = "Sistema de Gestión Académica - Tutor"
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
    Friend WithEvents mnuMantenimiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ssBarra As System.Windows.Forms.StatusStrip
    Friend WithEvents tslblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslblPeriodo As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslblSeparador As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuCambiar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCalificar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGestionDeComp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlanLectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNotasPlanLector As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAsignarLibros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExportarRegistro As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuImportarRegistro As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ListadoDeAlumnosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents errGeneral As System.Windows.Forms.ErrorProvider
  Friend WithEvents sfdGuardar As System.Windows.Forms.SaveFileDialog
  Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
