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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.ManteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.GestionDeServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.GestionDeProgramacionDePagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.GestionDeCuentasContablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
    Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
    Me.ProcesoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.RegistrarPagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.MantenimientoDeDocumentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
    Me.ExportarDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ImportarDataToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
    Me.PagoInstitucionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
    Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
    Me.AsignarObligacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.EstadoDeCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.LiquidacionDelDiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
    Me.GenerarCartasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
    Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
    Me.ResumenDebeneficiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
    Me.ConsolidadoDePagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
    Me.ResumenPagosProgramadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ReporteDePagosPorServicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuConfiguracion = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuAcercaDe = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
    Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
    Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
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
    Me.ToolStrip1.SuspendLayout()
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
    Me.ManteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDeServiciosToolStripMenuItem, Me.SalirToolStripMenuItem, Me.GestionDeProgramacionDePagosToolStripMenuItem, Me.GestionDeCuentasContablesToolStripMenuItem, Me.ToolStripSeparator2, Me.ToolStripMenuItem7, Me.ToolStripMenuItem1, Me.ToolStripSeparator1, Me.ToolStripMenuItem4, Me.ToolStripMenuItem3, Me.mnuSalir})
    Me.ManteToolStripMenuItem.Name = "ManteToolStripMenuItem"
    Me.ManteToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
    Me.ManteToolStripMenuItem.Text = "&Mantenimiento"
    '
    'GestionDeServiciosToolStripMenuItem
    '
    Me.GestionDeServiciosToolStripMenuItem.Name = "GestionDeServiciosToolStripMenuItem"
    Me.GestionDeServiciosToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
    Me.GestionDeServiciosToolStripMenuItem.Text = "Gestión de Servicios"
    '
    'SalirToolStripMenuItem
    '
    Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
    Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
    Me.SalirToolStripMenuItem.Text = "Gestion de Beneficios"
    '
    'GestionDeProgramacionDePagosToolStripMenuItem
    '
    Me.GestionDeProgramacionDePagosToolStripMenuItem.Name = "GestionDeProgramacionDePagosToolStripMenuItem"
    Me.GestionDeProgramacionDePagosToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
    Me.GestionDeProgramacionDePagosToolStripMenuItem.Text = "Gestion de Programacion de Pagos"
    '
    'GestionDeCuentasContablesToolStripMenuItem
    '
    Me.GestionDeCuentasContablesToolStripMenuItem.Name = "GestionDeCuentasContablesToolStripMenuItem"
    Me.GestionDeCuentasContablesToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
    Me.GestionDeCuentasContablesToolStripMenuItem.Text = "Gestion de Cuentas Contables"
    '
    'ToolStripSeparator2
    '
    Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
    Me.ToolStripSeparator2.Size = New System.Drawing.Size(256, 6)
    '
    'ToolStripMenuItem7
    '
    Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
    Me.ToolStripMenuItem7.Size = New System.Drawing.Size(259, 22)
    Me.ToolStripMenuItem7.Text = "Gestión de personas"
    '
    'ToolStripMenuItem1
    '
    Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
    Me.ToolStripMenuItem1.Size = New System.Drawing.Size(259, 22)
    Me.ToolStripMenuItem1.Text = "A&signar códigos"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(256, 6)
    '
    'ToolStripMenuItem4
    '
    Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
    Me.ToolStripMenuItem4.Size = New System.Drawing.Size(259, 22)
    Me.ToolStripMenuItem4.Text = "Cambiar clave"
    '
    'ToolStripMenuItem3
    '
    Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
    Me.ToolStripMenuItem3.Size = New System.Drawing.Size(256, 6)
    '
    'mnuSalir
    '
    Me.mnuSalir.Name = "mnuSalir"
    Me.mnuSalir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
    Me.mnuSalir.Size = New System.Drawing.Size(259, 22)
    Me.mnuSalir.Text = "Salir"
    '
    'ProcesoToolStripMenuItem
    '
    Me.ProcesoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarPagoToolStripMenuItem, Me.MantenimientoDeDocumentosToolStripMenuItem, Me.ToolStripMenuItem11, Me.ToolStripMenuItem5, Me.ExportarDataToolStripMenuItem, Me.ImportarDataToolStripMenuItem2, Me.PagoInstitucionalToolStripMenuItem, Me.ToolStripMenuItem6, Me.ToolStripMenuItem13, Me.AsignarObligacionesToolStripMenuItem, Me.EstadoDeCuentaToolStripMenuItem})
    Me.ProcesoToolStripMenuItem.Name = "ProcesoToolStripMenuItem"
    Me.ProcesoToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
    Me.ProcesoToolStripMenuItem.Text = "&Procesos"
    '
    'RegistrarPagoToolStripMenuItem
    '
    Me.RegistrarPagoToolStripMenuItem.Name = "RegistrarPagoToolStripMenuItem"
    Me.RegistrarPagoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
    Me.RegistrarPagoToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
    Me.RegistrarPagoToolStripMenuItem.Text = "&Registrar Pagos"
    '
    'MantenimientoDeDocumentosToolStripMenuItem
    '
    Me.MantenimientoDeDocumentosToolStripMenuItem.Name = "MantenimientoDeDocumentosToolStripMenuItem"
    Me.MantenimientoDeDocumentosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
    Me.MantenimientoDeDocumentosToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
    Me.MantenimientoDeDocumentosToolStripMenuItem.Text = "&Mantenimiento de documentos"
    '
    'ToolStripMenuItem11
    '
    Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
    Me.ToolStripMenuItem11.Size = New System.Drawing.Size(261, 22)
    Me.ToolStripMenuItem11.Text = "Gestionar liquidaciones"
    Me.ToolStripMenuItem11.Visible = False
    '
    'ToolStripMenuItem5
    '
    Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
    Me.ToolStripMenuItem5.Size = New System.Drawing.Size(258, 6)
    '
    'ExportarDataToolStripMenuItem
    '
    Me.ExportarDataToolStripMenuItem.Name = "ExportarDataToolStripMenuItem"
    Me.ExportarDataToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9
    Me.ExportarDataToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
    Me.ExportarDataToolStripMenuItem.Text = "E&xportar data"
    '
    'ImportarDataToolStripMenuItem2
    '
    Me.ImportarDataToolStripMenuItem2.Name = "ImportarDataToolStripMenuItem2"
    Me.ImportarDataToolStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.F8
    Me.ImportarDataToolStripMenuItem2.Size = New System.Drawing.Size(261, 22)
    Me.ImportarDataToolStripMenuItem2.Text = "I&mportar data"
    '
    'PagoInstitucionalToolStripMenuItem
    '
    Me.PagoInstitucionalToolStripMenuItem.Name = "PagoInstitucionalToolStripMenuItem"
    Me.PagoInstitucionalToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12
    Me.PagoInstitucionalToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
    Me.PagoInstitucionalToolStripMenuItem.Text = "&Pago institucional"
    '
    'ToolStripMenuItem6
    '
    Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
    Me.ToolStripMenuItem6.Size = New System.Drawing.Size(258, 6)
    '
    'ToolStripMenuItem13
    '
    Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
    Me.ToolStripMenuItem13.Size = New System.Drawing.Size(261, 22)
    Me.ToolStripMenuItem13.Text = "Modificar cronograma de pago"
    '
    'AsignarObligacionesToolStripMenuItem
    '
    Me.AsignarObligacionesToolStripMenuItem.Name = "AsignarObligacionesToolStripMenuItem"
    Me.AsignarObligacionesToolStripMenuItem.Size = New System.Drawing.Size(261, 22)
    Me.AsignarObligacionesToolStripMenuItem.Text = "Asignar o&bligaciones"
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
    Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LiquidacionDelDiaToolStripMenuItem, Me.ToolStripMenuItem10, Me.GenerarCartasToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem9, Me.ResumenDebeneficiosToolStripMenuItem, Me.ToolStripMenuItem8, Me.ToolStripSeparator3, Me.ConsolidadoDePagosToolStripMenuItem, Me.ToolStripMenuItem12, Me.ResumenPagosProgramadosToolStripMenuItem, Me.ReporteDePagosPorServicioToolStripMenuItem})
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
    'GenerarCartasToolStripMenuItem
    '
    Me.GenerarCartasToolStripMenuItem.Name = "GenerarCartasToolStripMenuItem"
    Me.GenerarCartasToolStripMenuItem.Size = New System.Drawing.Size(284, 22)
    Me.GenerarCartasToolStripMenuItem.Text = "Generar cartas"
    Me.GenerarCartasToolStripMenuItem.Visible = False
    '
    'ToolStripMenuItem2
    '
    Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
    Me.ToolStripMenuItem2.Size = New System.Drawing.Size(281, 6)
    '
    'ToolStripMenuItem9
    '
    Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
    Me.ToolStripMenuItem9.Size = New System.Drawing.Size(284, 22)
    Me.ToolStripMenuItem9.Text = "Listado de alumnos a matricular"
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
    'ResumenPagosProgramadosToolStripMenuItem
    '
    Me.ResumenPagosProgramadosToolStripMenuItem.Name = "ResumenPagosProgramadosToolStripMenuItem"
    Me.ResumenPagosProgramadosToolStripMenuItem.Size = New System.Drawing.Size(284, 22)
    Me.ResumenPagosProgramadosToolStripMenuItem.Text = "Resumen pagos programados"
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
    'ToolStrip1
    '
    Me.ToolStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton6, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripButton7})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
    Me.ToolStrip1.MinimumSize = New System.Drawing.Size(72, 72)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(718, 72)
    Me.ToolStrip1.TabIndex = 2
    Me.ToolStrip1.Text = "ToolStrip1"
    '
    'ToolStripButton6
    '
    Me.ToolStripButton6.AccessibleRole = System.Windows.Forms.AccessibleRole.None
    Me.ToolStripButton6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
    Me.ToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripButton6.Name = "ToolStripButton6"
    Me.ToolStripButton6.Size = New System.Drawing.Size(70, 69)
    Me.ToolStripButton6.Text = "Beneficio"
    Me.ToolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'ToolStripButton1
    '
    Me.ToolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
    Me.ToolStripButton1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
    Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripButton1.Name = "ToolStripButton1"
    Me.ToolStripButton1.Size = New System.Drawing.Size(61, 69)
    Me.ToolStripButton1.Text = "Servicio"
    Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'ToolStripButton2
    '
    Me.ToolStripButton2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
    Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripButton2.Name = "ToolStripButton2"
    Me.ToolStripButton2.Size = New System.Drawing.Size(100, 69)
    Me.ToolStripButton2.Text = "Registrar Pago"
    Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'ToolStripButton3
    '
    Me.ToolStripButton3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
    Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripButton3.Name = "ToolStripButton3"
    Me.ToolStripButton3.Size = New System.Drawing.Size(66, 69)
    Me.ToolStripButton3.Text = "Importar"
    Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'ToolStripButton4
    '
    Me.ToolStripButton4.AccessibleRole = System.Windows.Forms.AccessibleRole.None
    Me.ToolStripButton4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
    Me.ToolStripButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripButton4.Name = "ToolStripButton4"
    Me.ToolStripButton4.Size = New System.Drawing.Size(64, 69)
    Me.ToolStripButton4.Text = "Exportar"
    Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'ToolStripButton5
    '
    Me.ToolStripButton5.AccessibleRole = System.Windows.Forms.AccessibleRole.None
    Me.ToolStripButton5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
    Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripButton5.Name = "ToolStripButton5"
    Me.ToolStripButton5.Size = New System.Drawing.Size(119, 69)
    Me.ToolStripButton5.Text = "Estado de Cuenta"
    Me.ToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'ToolStripButton7
    '
    Me.ToolStripButton7.AccessibleRole = System.Windows.Forms.AccessibleRole.None
    Me.ToolStripButton7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ToolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripButton7.Name = "ToolStripButton7"
    Me.ToolStripButton7.Size = New System.Drawing.Size(50, 69)
    Me.ToolStripButton7.Text = "Cartas"
    Me.ToolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    Me.ToolStripButton7.Visible = False
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
    Me.Controls.Add(Me.ToolStrip1)
    Me.Controls.Add(Me.MenuStrip1)
    Me.IsMdiContainer = True
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "frmPrincipal"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "MODULO DE CAJA"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    Me.StatusStrip1.ResumeLayout(False)
    Me.StatusStrip1.PerformLayout()
    CType(Me.errGeneral, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents ManteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents GestionDeServiciosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents LiquidacionDelDiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuConfiguracion As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuAcercaDe As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents GestionDeCuentasContablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents GestionDeProgramacionDePagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
  Friend WithEvents GenerarCartasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
  Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
  Friend WithEvents tsslUsuario As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents tsslVacio As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents tsslHora As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents timerHora As System.Windows.Forms.Timer
  Friend WithEvents tsslFecha As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ofdAbrir As System.Windows.Forms.OpenFileDialog
  Friend WithEvents errGeneral As System.Windows.Forms.ErrorProvider
  Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ResumenDebeneficiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents sfdGuardar As System.Windows.Forms.SaveFileDialog
  Friend WithEvents ConsolidadoDePagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ResumenPagosProgramadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ProcesoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents RegistrarPagoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MantenimientoDeDocumentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ExportarDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ImportarDataToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents PagoInstitucionalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents AsignarObligacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents EstadoDeCuentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ReporteDePagosPorServicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem

End Class
