﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
    Me.mnuCambiar = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCalificar = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuGestionDeAsistencia = New System.Windows.Forms.ToolStripMenuItem()
    Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.AsistenciaMensualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ssBarra = New System.Windows.Forms.StatusStrip()
    Me.tslblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
    Me.tslblSeparador = New System.Windows.Forms.ToolStripStatusLabel()
    Me.tslblPeriodo = New System.Windows.Forms.ToolStripStatusLabel()
    Me.ListadoDeAsistenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.sfdGuardar = New System.Windows.Forms.SaveFileDialog()
    Me.mnuPrincipal.SuspendLayout()
    Me.ssBarra.SuspendLayout()
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
    Me.mnuCalificar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGestionDeAsistencia})
    Me.mnuCalificar.Name = "mnuCalificar"
    Me.mnuCalificar.Size = New System.Drawing.Size(59, 20)
    Me.mnuCalificar.Text = "&Gestión"
    '
    'mnuGestionDeAsistencia
    '
    Me.mnuGestionDeAsistencia.Name = "mnuGestionDeAsistencia"
    Me.mnuGestionDeAsistencia.Size = New System.Drawing.Size(127, 22)
    Me.mnuGestionDeAsistencia.Tag = "2"
    Me.mnuGestionDeAsistencia.Text = "&Asistencia"
    '
    'ReportesToolStripMenuItem
    '
    Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsistenciaMensualToolStripMenuItem, Me.ListadoDeAsistenciaToolStripMenuItem})
    Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
    Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
    Me.ReportesToolStripMenuItem.Text = "&Reportes"
    '
    'AsistenciaMensualToolStripMenuItem
    '
    Me.AsistenciaMensualToolStripMenuItem.Name = "AsistenciaMensualToolStripMenuItem"
    Me.AsistenciaMensualToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
    Me.AsistenciaMensualToolStripMenuItem.Text = "&Asistencia Mensual"
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
    'ListadoDeAsistenciaToolStripMenuItem
    '
    Me.ListadoDeAsistenciaToolStripMenuItem.Name = "ListadoDeAsistenciaToolStripMenuItem"
    Me.ListadoDeAsistenciaToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
    Me.ListadoDeAsistenciaToolStripMenuItem.Text = "Listado de asistencia"
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
    Me.Text = "Sistema de Gestión Académica - Asistencia"
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
  Friend WithEvents mnuCalificar As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuGestionDeAsistencia As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents AsistenciaMensualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ListadoDeAsistenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents sfdGuardar As System.Windows.Forms.SaveFileDialog

End Class
