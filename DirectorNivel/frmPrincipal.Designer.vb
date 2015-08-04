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
    Me.mnuIndicador = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuRegistrar = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuIndividual = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuGrupal = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuNotasIndicador = New System.Windows.Forms.ToolStripMenuItem()
    Me.RegistrarPromediosDeAreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCapacidad = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuNotasCapacidad = New System.Windows.Forms.ToolStripMenuItem()
    Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuConsolidadoAnualAreaPeriodo = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuConsolidadoAnualCursoPeriodo = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuConsolidadoTrimestralAreasCapacidades = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
    Me.IngresoDeCalificacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
    Me.ResumenDeAsistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.EvoluciónDeConductaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ssBarra = New System.Windows.Forms.StatusStrip()
    Me.tslblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
    Me.tslblSeparador = New System.Windows.Forms.ToolStripStatusLabel()
    Me.tslblPeriodo = New System.Windows.Forms.ToolStripStatusLabel()
    Me.sfdDialogoGuardar = New System.Windows.Forms.SaveFileDialog()
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
    Me.ResumenDeRegistroDeAsistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuPrincipal.SuspendLayout()
    Me.ssBarra.SuspendLayout()
    Me.SuspendLayout()
    '
    'mnuPrincipal
    '
    Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMantenimiento, Me.mnuIndicador, Me.mnuCapacidad, Me.ReportesToolStripMenuItem})
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
    'mnuIndicador
    '
    Me.mnuIndicador.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRegistrar, Me.mnuNotasIndicador, Me.RegistrarPromediosDeAreaToolStripMenuItem})
    Me.mnuIndicador.Name = "mnuIndicador"
    Me.mnuIndicador.Size = New System.Drawing.Size(99, 20)
    Me.mnuIndicador.Text = "Inicial-Primaria"
    '
    'mnuRegistrar
    '
    Me.mnuRegistrar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuIndividual, Me.mnuGrupal})
    Me.mnuRegistrar.Name = "mnuRegistrar"
    Me.mnuRegistrar.Size = New System.Drawing.Size(240, 22)
    Me.mnuRegistrar.Tag = ""
    Me.mnuRegistrar.Text = "Registrar Indicador"
    '
    'mnuIndividual
    '
    Me.mnuIndividual.Name = "mnuIndividual"
    Me.mnuIndividual.Size = New System.Drawing.Size(126, 22)
    Me.mnuIndividual.Tag = "2"
    Me.mnuIndividual.Text = "Individual"
    '
    'mnuGrupal
    '
    Me.mnuGrupal.Name = "mnuGrupal"
    Me.mnuGrupal.Size = New System.Drawing.Size(126, 22)
    Me.mnuGrupal.Tag = "3"
    Me.mnuGrupal.Text = "Grupal"
    '
    'mnuNotasIndicador
    '
    Me.mnuNotasIndicador.Name = "mnuNotasIndicador"
    Me.mnuNotasIndicador.Size = New System.Drawing.Size(240, 22)
    Me.mnuNotasIndicador.Text = "Notas de Indicadores por Curso"
    '
    'RegistrarPromediosDeAreaToolStripMenuItem
    '
    Me.RegistrarPromediosDeAreaToolStripMenuItem.Name = "RegistrarPromediosDeAreaToolStripMenuItem"
    Me.RegistrarPromediosDeAreaToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
    Me.RegistrarPromediosDeAreaToolStripMenuItem.Text = "Registrar promedios de area"
    '
    'mnuCapacidad
    '
    Me.mnuCapacidad.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNotasCapacidad})
    Me.mnuCapacidad.Name = "mnuCapacidad"
    Me.mnuCapacidad.Size = New System.Drawing.Size(77, 20)
    Me.mnuCapacidad.Text = "Secundaria"
    '
    'mnuNotasCapacidad
    '
    Me.mnuNotasCapacidad.Name = "mnuNotasCapacidad"
    Me.mnuNotasCapacidad.Size = New System.Drawing.Size(246, 22)
    Me.mnuNotasCapacidad.Text = "Notas de Capacidades por Curso"
    '
    'ReportesToolStripMenuItem
    '
    Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuConsolidadoAnualAreaPeriodo, Me.mnuConsolidadoAnualCursoPeriodo, Me.mnuConsolidadoTrimestralAreasCapacidades, Me.ToolStripSeparator3, Me.IngresoDeCalificacionesToolStripMenuItem, Me.ToolStripMenuItem2, Me.EvoluciónDeConductaToolStripMenuItem, Me.ToolStripMenuItem1, Me.ResumenDeAsistenciaToolStripMenuItem, Me.ResumenDeRegistroDeAsistenciaToolStripMenuItem})
    Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
    Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
    Me.ReportesToolStripMenuItem.Text = "Reportes"
    '
    'mnuConsolidadoAnualAreaPeriodo
    '
    Me.mnuConsolidadoAnualAreaPeriodo.Name = "mnuConsolidadoAnualAreaPeriodo"
    Me.mnuConsolidadoAnualAreaPeriodo.Size = New System.Drawing.Size(322, 22)
    Me.mnuConsolidadoAnualAreaPeriodo.Text = "Consolidado anual por áreas y periodo"
    '
    'mnuConsolidadoAnualCursoPeriodo
    '
    Me.mnuConsolidadoAnualCursoPeriodo.Name = "mnuConsolidadoAnualCursoPeriodo"
    Me.mnuConsolidadoAnualCursoPeriodo.Size = New System.Drawing.Size(322, 22)
    Me.mnuConsolidadoAnualCursoPeriodo.Text = "Consolidado anual por curso y periodo"
    '
    'mnuConsolidadoTrimestralAreasCapacidades
    '
    Me.mnuConsolidadoTrimestralAreasCapacidades.Name = "mnuConsolidadoTrimestralAreasCapacidades"
    Me.mnuConsolidadoTrimestralAreasCapacidades.Size = New System.Drawing.Size(322, 22)
    Me.mnuConsolidadoTrimestralAreasCapacidades.Text = "Consolidado periódico por áreas y capacidades"
    '
    'ToolStripSeparator3
    '
    Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    Me.ToolStripSeparator3.Size = New System.Drawing.Size(319, 6)
    '
    'IngresoDeCalificacionesToolStripMenuItem
    '
    Me.IngresoDeCalificacionesToolStripMenuItem.Name = "IngresoDeCalificacionesToolStripMenuItem"
    Me.IngresoDeCalificacionesToolStripMenuItem.Size = New System.Drawing.Size(322, 22)
    Me.IngresoDeCalificacionesToolStripMenuItem.Text = "Ingreso de calificaciones de secundaria"
    '
    'ToolStripMenuItem2
    '
    Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
    Me.ToolStripMenuItem2.Size = New System.Drawing.Size(322, 22)
    Me.ToolStripMenuItem2.Text = "Ingreso de calificaciones de primaria"
    '
    'ResumenDeAsistenciaToolStripMenuItem
    '
    Me.ResumenDeAsistenciaToolStripMenuItem.Name = "ResumenDeAsistenciaToolStripMenuItem"
    Me.ResumenDeAsistenciaToolStripMenuItem.Size = New System.Drawing.Size(322, 22)
    Me.ResumenDeAsistenciaToolStripMenuItem.Text = "Reporte de asistencia"
    '
    'EvoluciónDeConductaToolStripMenuItem
    '
    Me.EvoluciónDeConductaToolStripMenuItem.Name = "EvoluciónDeConductaToolStripMenuItem"
    Me.EvoluciónDeConductaToolStripMenuItem.Size = New System.Drawing.Size(322, 22)
    Me.EvoluciónDeConductaToolStripMenuItem.Text = "Evolución de conducta"
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
    'ToolStripMenuItem1
    '
    Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    Me.ToolStripMenuItem1.Size = New System.Drawing.Size(319, 6)
    '
    'ResumenDeRegistroDeAsistenciaToolStripMenuItem
    '
    Me.ResumenDeRegistroDeAsistenciaToolStripMenuItem.Name = "ResumenDeRegistroDeAsistenciaToolStripMenuItem"
    Me.ResumenDeRegistroDeAsistenciaToolStripMenuItem.Size = New System.Drawing.Size(322, 22)
    Me.ResumenDeRegistroDeAsistenciaToolStripMenuItem.Text = "Listado de asistencia"
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
    Me.Text = "Sistema de Gestión Académica - Director Nivel"
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
  Friend WithEvents tslblUsuario As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents tslblPeriodo As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents tslblSeparador As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents mnuIndicador As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuRegistrar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuNotasIndicador As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuCapacidad As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuNotasCapacidad As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuCambiarContrasenia As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuIndividual As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuGrupal As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents IngresoDeCalificacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ResumenDeAsistenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents RegistrarPromediosDeAreaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuConsolidadoTrimestralAreasCapacidades As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents sfdDialogoGuardar As System.Windows.Forms.SaveFileDialog
  Friend WithEvents mnuConsolidadoAnualAreaPeriodo As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuConsolidadoAnualCursoPeriodo As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents EvoluciónDeConductaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ResumenDeRegistroDeAsistenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
