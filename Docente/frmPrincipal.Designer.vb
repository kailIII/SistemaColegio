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
    Me.mnuCambiarContrasenia = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuIndicador = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuRegistrar = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuNotasIndicador = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuRegistroAuxiliar = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuImportarRegistroInd = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuCapacidad = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuRegistrarCapacidad = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuNotasCapacidad = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuExportarRegistro = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuImportarRegistro = New System.Windows.Forms.ToolStripMenuItem
    Me.ssBarra = New System.Windows.Forms.StatusStrip
    Me.tslblUsuario = New System.Windows.Forms.ToolStripStatusLabel
    Me.tslblSeparador = New System.Windows.Forms.ToolStripStatusLabel
    Me.tslblPeriodo = New System.Windows.Forms.ToolStripStatusLabel
    Me.PictureBox1 = New System.Windows.Forms.PictureBox
    Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.RegistroAuxiliarSecundariaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.mnuPrincipal.SuspendLayout()
    Me.ssBarra.SuspendLayout()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.mnuMantenimiento.Size = New System.Drawing.Size(89, 20)
    Me.mnuMantenimiento.Text = "&Mantenimiento"
    '
    'mnuCambiarContrasenia
    '
    Me.mnuCambiarContrasenia.Name = "mnuCambiarContrasenia"
    Me.mnuCambiarContrasenia.Size = New System.Drawing.Size(183, 22)
    Me.mnuCambiarContrasenia.Tag = "1"
    Me.mnuCambiarContrasenia.Text = "&Cambiar Contraseña"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(180, 6)
    '
    'mnuSalir
    '
    Me.mnuSalir.Name = "mnuSalir"
    Me.mnuSalir.Size = New System.Drawing.Size(183, 22)
    Me.mnuSalir.Tag = "10"
    Me.mnuSalir.Text = "&Salir"
    '
    'mnuIndicador
    '
    Me.mnuIndicador.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRegistrar, Me.mnuNotasIndicador, Me.mnuRegistroAuxiliar, Me.mnuImportarRegistroInd})
    Me.mnuIndicador.Name = "mnuIndicador"
    Me.mnuIndicador.Size = New System.Drawing.Size(88, 20)
    Me.mnuIndicador.Text = "&Inicial-Primaria"
    '
    'mnuRegistrar
    '
    Me.mnuRegistrar.Name = "mnuRegistrar"
    Me.mnuRegistrar.Size = New System.Drawing.Size(237, 22)
    Me.mnuRegistrar.Tag = "2"
    Me.mnuRegistrar.Text = "&Registrar Indicador"
    '
    'mnuNotasIndicador
    '
    Me.mnuNotasIndicador.Name = "mnuNotasIndicador"
    Me.mnuNotasIndicador.Size = New System.Drawing.Size(237, 22)
    Me.mnuNotasIndicador.Tag = "3"
    Me.mnuNotasIndicador.Text = "&Notas de Indicadores por Curso"
    '
    'mnuRegistroAuxiliar
    '
    Me.mnuRegistroAuxiliar.Name = "mnuRegistroAuxiliar"
    Me.mnuRegistroAuxiliar.Size = New System.Drawing.Size(237, 22)
    Me.mnuRegistroAuxiliar.Tag = "4"
    Me.mnuRegistroAuxiliar.Text = "&Exportar Registro"
    '
    'mnuImportarRegistroInd
    '
    Me.mnuImportarRegistroInd.Name = "mnuImportarRegistroInd"
    Me.mnuImportarRegistroInd.Size = New System.Drawing.Size(237, 22)
    Me.mnuImportarRegistroInd.Tag = "5"
    Me.mnuImportarRegistroInd.Text = "&Importar Registro"
    '
    'mnuCapacidad
    '
    Me.mnuCapacidad.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRegistrarCapacidad, Me.mnuNotasCapacidad, Me.mnuExportarRegistro, Me.mnuImportarRegistro})
    Me.mnuCapacidad.Name = "mnuCapacidad"
    Me.mnuCapacidad.Size = New System.Drawing.Size(72, 20)
    Me.mnuCapacidad.Text = "&Secundaria"
    '
    'mnuRegistrarCapacidad
    '
    Me.mnuRegistrarCapacidad.Name = "mnuRegistrarCapacidad"
    Me.mnuRegistrarCapacidad.Size = New System.Drawing.Size(258, 22)
    Me.mnuRegistrarCapacidad.Tag = "6"
    Me.mnuRegistrarCapacidad.Text = "Registrar Unidades para cada Curso"
    '
    'mnuNotasCapacidad
    '
    Me.mnuNotasCapacidad.Name = "mnuNotasCapacidad"
    Me.mnuNotasCapacidad.Size = New System.Drawing.Size(258, 22)
    Me.mnuNotasCapacidad.Tag = "7"
    Me.mnuNotasCapacidad.Text = "Notas de Capacidades por Curso"
    '
    'mnuExportarRegistro
    '
    Me.mnuExportarRegistro.Name = "mnuExportarRegistro"
    Me.mnuExportarRegistro.Size = New System.Drawing.Size(258, 22)
    Me.mnuExportarRegistro.Tag = "8"
    Me.mnuExportarRegistro.Text = "Exportar Registro"
    '
    'mnuImportarRegistro
    '
    Me.mnuImportarRegistro.Name = "mnuImportarRegistro"
    Me.mnuImportarRegistro.Size = New System.Drawing.Size(258, 22)
    Me.mnuImportarRegistro.Tag = "9"
    Me.mnuImportarRegistro.Text = "Importar Registro"
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
    Me.tslblUsuario.Size = New System.Drawing.Size(99, 17)
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
    Me.tslblPeriodo.Size = New System.Drawing.Size(75, 17)
    Me.tslblPeriodo.Text = "Periodo actual"
    '
    'PictureBox1
    '
    Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(616, 394)
    Me.PictureBox1.TabIndex = 4
    Me.PictureBox1.TabStop = False
    '
    'ReportesToolStripMenuItem
    '
    Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroAuxiliarSecundariaToolStripMenuItem})
    Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
    Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
    Me.ReportesToolStripMenuItem.Text = "&Reportes"
    '
    'RegistroAuxiliarSecundariaToolStripMenuItem
    '
    Me.RegistroAuxiliarSecundariaToolStripMenuItem.Name = "RegistroAuxiliarSecundariaToolStripMenuItem"
    Me.RegistroAuxiliarSecundariaToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
    Me.RegistroAuxiliarSecundariaToolStripMenuItem.Text = "Registro Auxiliar Secundaria"
    '
    'frmPrincipal
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.BackColor = System.Drawing.Color.White
    Me.ClientSize = New System.Drawing.Size(616, 440)
    Me.Controls.Add(Me.PictureBox1)
    Me.Controls.Add(Me.ssBarra)
    Me.Controls.Add(Me.mnuPrincipal)
    Me.IsMdiContainer = True
    Me.MainMenuStrip = Me.mnuPrincipal
    Me.Name = "frmPrincipal"
    Me.Text = "Sistema de Gestión Académica - Docente"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.mnuPrincipal.ResumeLayout(False)
    Me.mnuPrincipal.PerformLayout()
    Me.ssBarra.ResumeLayout(False)
    Me.ssBarra.PerformLayout()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents mnuRegistrarCapacidad As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuNotasCapacidad As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuCambiarContrasenia As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents mnuRegistroAuxiliar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuExportarRegistro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuImportarRegistro As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuImportarRegistroInd As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents RegistroAuxiliarSecundariaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
