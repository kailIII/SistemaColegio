<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
    Me.components = New System.ComponentModel.Container()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.ManteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
    Me.ProcesoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.MantenimientoDeDocumentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.EstadoDeCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.LiquidacionDelDiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
    Me.ResumenDebeneficiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
    Me.ConsolidadoDePagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
    Me.ReporteDePagosPorServicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuConfiguracion = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
    Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
    Me.tsslUsuario = New System.Windows.Forms.ToolStripStatusLabel()
    Me.tsslVacio = New System.Windows.Forms.ToolStripStatusLabel()
    Me.tsslFecha = New System.Windows.Forms.ToolStripStatusLabel()
    Me.tsslHora = New System.Windows.Forms.ToolStripStatusLabel()
    Me.timerHora = New System.Windows.Forms.Timer(Me.components)
    Me.ofdAbrir = New System.Windows.Forms.OpenFileDialog()
    Me.errGeneral = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.sfdGuardar = New System.Windows.Forms.SaveFileDialog()
    Me.MenuStrip1.SuspendLayout()
    Me.StatusStrip1.SuspendLayout()
    CType(Me.errGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManteToolStripMenuItem, Me.ProcesoToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.mnuConfiguracion})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(718, 24)
    Me.MenuStrip1.TabIndex = 0
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'ManteToolStripMenuItem
    '
    Me.ManteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem3, Me.mnuSalir})
    Me.ManteToolStripMenuItem.Name = "ManteToolStripMenuItem"
    Me.ManteToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
    Me.ManteToolStripMenuItem.Text = "&Mantenimiento"
    '
    'ToolStripMenuItem4
    '
    Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
    Me.ToolStripMenuItem4.Size = New System.Drawing.Size(149, 22)
    Me.ToolStripMenuItem4.Text = "Cambiar clave"
    '
    'ToolStripMenuItem3
    '
    Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
    Me.ToolStripMenuItem3.Size = New System.Drawing.Size(146, 6)
    '
    'mnuSalir
    '
    Me.mnuSalir.Name = "mnuSalir"
    Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
    Me.mnuSalir.Size = New System.Drawing.Size(149, 22)
    Me.mnuSalir.Text = "Salir"
    '
    'ProcesoToolStripMenuItem
    '
    Me.ProcesoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoDeDocumentosToolStripMenuItem, Me.EstadoDeCuentaToolStripMenuItem})
    Me.ProcesoToolStripMenuItem.Name = "ProcesoToolStripMenuItem"
    Me.ProcesoToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
    Me.ProcesoToolStripMenuItem.Text = "&Procesos"
    '
    'MantenimientoDeDocumentosToolStripMenuItem
    '
    Me.MantenimientoDeDocumentosToolStripMenuItem.Name = "MantenimientoDeDocumentosToolStripMenuItem"
    Me.MantenimientoDeDocumentosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
    Me.MantenimientoDeDocumentosToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
    Me.MantenimientoDeDocumentosToolStripMenuItem.Text = "&Mantenimiento de documentos"
    '
    'EstadoDeCuentaToolStripMenuItem
    '
    Me.EstadoDeCuentaToolStripMenuItem.Name = "EstadoDeCuentaToolStripMenuItem"
    Me.EstadoDeCuentaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
    Me.EstadoDeCuentaToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
    Me.EstadoDeCuentaToolStripMenuItem.Text = "&Estado de cuenta"
    '
    'ReportesToolStripMenuItem
    '
    Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LiquidacionDelDiaToolStripMenuItem, Me.ToolStripMenuItem10, Me.ToolStripMenuItem2, Me.ResumenDebeneficiosToolStripMenuItem, Me.ToolStripMenuItem8, Me.ToolStripSeparator3, Me.ConsolidadoDePagosToolStripMenuItem, Me.ToolStripMenuItem12, Me.ReporteDePagosPorServicioToolStripMenuItem})
    Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
    Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
    Me.ReportesToolStripMenuItem.Text = "&Reportes"
    '
    'LiquidacionDelDiaToolStripMenuItem
    '
    Me.LiquidacionDelDiaToolStripMenuItem.Name = "LiquidacionDelDiaToolStripMenuItem"
    Me.LiquidacionDelDiaToolStripMenuItem.Size = New System.Drawing.Size(284, 22)
    Me.LiquidacionDelDiaToolStripMenuItem.Text = "Liquidación del día"
    '
    'ToolStripMenuItem10
    '
    Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
    Me.ToolStripMenuItem10.Size = New System.Drawing.Size(284, 22)
    Me.ToolStripMenuItem10.Text = "Listado de pagos realizados en banco"
    '
    'ToolStripMenuItem2
    '
    Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
    Me.ToolStripMenuItem2.Size = New System.Drawing.Size(281, 6)
    '
    'ResumenDebeneficiosToolStripMenuItem
    '
    Me.ResumenDebeneficiosToolStripMenuItem.Name = "ResumenDebeneficiosToolStripMenuItem"
    Me.ResumenDebeneficiosToolStripMenuItem.Size = New System.Drawing.Size(284, 22)
    Me.ResumenDebeneficiosToolStripMenuItem.Text = "Resumen de &beneficios"
    '
    'ToolStripMenuItem8
    '
    Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
    Me.ToolStripMenuItem8.Size = New System.Drawing.Size(284, 22)
    Me.ToolStripMenuItem8.Text = "Listado de alumnos beneficiados"
    '
    'ToolStripSeparator3
    '
    Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
    Me.ToolStripSeparator3.Size = New System.Drawing.Size(281, 6)
    '
    'ConsolidadoDePagosToolStripMenuItem
    '
    Me.ConsolidadoDePagosToolStripMenuItem.Name = "ConsolidadoDePagosToolStripMenuItem"
    Me.ConsolidadoDePagosToolStripMenuItem.Size = New System.Drawing.Size(284, 22)
    Me.ConsolidadoDePagosToolStripMenuItem.Text = "&Consolidado de pagos"
    '
    'ToolStripMenuItem12
    '
    Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
    Me.ToolStripMenuItem12.Size = New System.Drawing.Size(284, 22)
    Me.ToolStripMenuItem12.Text = "Listado de alumnos pendientes de pago"
    '
    'ReporteDePagosPorServicioToolStripMenuItem
    '
    Me.ReporteDePagosPorServicioToolStripMenuItem.Name = "ReporteDePagosPorServicioToolStripMenuItem"
    Me.ReporteDePagosPorServicioToolStripMenuItem.Size = New System.Drawing.Size(284, 22)
    Me.ReporteDePagosPorServicioToolStripMenuItem.Text = "Reporte de pagos por servicio"
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
    Me.mnuAcercaDe.Size = New System.Drawing.Size(129, 22)
    Me.mnuAcercaDe.Text = "Acerca de "
    '
    'StatusStrip1
    '
    Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslUsuario, Me.tsslVacio, Me.tsslFecha, Me.tsslHora})
    Me.StatusStrip1.Location = New System.Drawing.Point(0, 425)
    Me.StatusStrip1.Name = "StatusStrip1"
    Me.StatusStrip1.Size = New System.Drawing.Size(718, 22)
    Me.StatusStrip1.TabIndex = 4
    Me.StatusStrip1.Text = "StatusStrip1"
    '
    'tsslUsuario
    '
    Me.tsslUsuario.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.tsslUsuario.Name = "tsslUsuario"
    Me.tsslUsuario.Size = New System.Drawing.Size(49, 17)
    Me.tsslUsuario.Text = "usuario"
    '
    'tsslVacio
    '
    Me.tsslVacio.AutoSize = False
    Me.tsslVacio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.tsslVacio.Name = "tsslVacio"
    Me.tsslVacio.Size = New System.Drawing.Size(440, 17)
    '
    'tsslFecha
    '
    Me.tsslFecha.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.tsslFecha.Name = "tsslFecha"
    Me.tsslFecha.Size = New System.Drawing.Size(40, 17)
    Me.tsslFecha.Text = "Fecha"
    '
    'tsslHora
    '
    Me.tsslHora.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.tsslHora.Name = "tsslHora"
    Me.tsslHora.Size = New System.Drawing.Size(34, 17)
    Me.tsslHora.Text = "Hora"
    '
    'timerHora
    '
    Me.timerHora.Enabled = True
    '
    'ofdAbrir
    '
    Me.ofdAbrir.FileName = "OpenFileDialog1"
    '
    'errGeneral
    '
    Me.errGeneral.ContainerControl = Me
    '
    'frmPrincipal
    '
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
    Me.ClientSize = New System.Drawing.Size(718, 447)
    Me.Controls.Add(Me.StatusStrip1)
    Me.Controls.Add(Me.MenuStrip1)
    Me.IsMdiContainer = True
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "frmPrincipal"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "MODULO DE REPORTES DE ADMINISTRACIÓN"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.StatusStrip1.ResumeLayout(False)
    Me.StatusStrip1.PerformLayout()
    CType(Me.errGeneral, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents ManteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents LiquidacionDelDiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuConfiguracion As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuAcercaDe As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
  Friend WithEvents tsslUsuario As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents tsslVacio As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents tsslHora As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents timerHora As System.Windows.Forms.Timer
  Friend WithEvents tsslFecha As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents ofdAbrir As System.Windows.Forms.OpenFileDialog
  Friend WithEvents errGeneral As System.Windows.Forms.ErrorProvider
  Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ResumenDebeneficiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents sfdGuardar As System.Windows.Forms.SaveFileDialog
  Friend WithEvents ConsolidadoDePagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ProcesoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MantenimientoDeDocumentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents EstadoDeCuentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ReporteDePagosPorServicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem

End Class
