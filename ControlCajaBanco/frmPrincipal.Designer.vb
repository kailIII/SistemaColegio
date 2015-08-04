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
    Me.mnuPrincipal = New System.Windows.Forms.MenuStrip()
    Me.mnuMantenimiento = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuCambiarContrasenia = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
    Me.ssBarra = New System.Windows.Forms.StatusStrip()
    Me.tsslUsuarioLabel = New System.Windows.Forms.ToolStripStatusLabel()
    Me.tsslUsuario = New System.Windows.Forms.ToolStripStatusLabel()
    Me.tsslVacio = New System.Windows.Forms.ToolStripStatusLabel()
    Me.tsslFecha = New System.Windows.Forms.ToolStripStatusLabel()
    Me.tsslHora = New System.Windows.Forms.ToolStripStatusLabel()
    Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
    Me.tHoraFecha = New System.Windows.Forms.Timer(Me.components)
    Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
    Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
    Me.tsbReposicion = New System.Windows.Forms.ToolStripButton()
    Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
    Me.mnuPrincipal.SuspendLayout()
    Me.ssBarra.SuspendLayout()
    CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'mnuPrincipal
    '
    Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMantenimiento})
    Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
    Me.mnuPrincipal.Name = "mnuPrincipal"
    Me.mnuPrincipal.Size = New System.Drawing.Size(754, 24)
    Me.mnuPrincipal.TabIndex = 1
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
    'ssBarra
    '
    Me.ssBarra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslUsuarioLabel, Me.tsslUsuario, Me.tsslVacio, Me.tsslFecha, Me.tsslHora, Me.ToolStripStatusLabel1})
    Me.ssBarra.Location = New System.Drawing.Point(0, 448)
    Me.ssBarra.Name = "ssBarra"
    Me.ssBarra.Size = New System.Drawing.Size(754, 22)
    Me.ssBarra.TabIndex = 3
    Me.ssBarra.Text = "StatusBar"
    '
    'tsslUsuarioLabel
    '
    Me.tsslUsuarioLabel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.tsslUsuarioLabel.Name = "tsslUsuarioLabel"
    Me.tsslUsuarioLabel.Size = New System.Drawing.Size(55, 17)
    Me.tsslUsuarioLabel.Text = "Usuario: "
    '
    'tsslUsuario
    '
    Me.tsslUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.tsslUsuario.Name = "tsslUsuario"
    Me.tsslUsuario.Size = New System.Drawing.Size(52, 17)
    Me.tsslUsuario.Text = "Usuario "
    '
    'tsslVacio
    '
    Me.tsslVacio.AutoSize = False
    Me.tsslVacio.Name = "tsslVacio"
    Me.tsslVacio.Size = New System.Drawing.Size(520, 17)
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
    'ToolStripStatusLabel1
    '
    Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
    Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 15)
    Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
    '
    'tHoraFecha
    '
    '
    'ErrorProvider1
    '
    Me.ErrorProvider1.ContainerControl = Me
    '
    'ToolStrip1
    '
    Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton5, Me.tsbReposicion, Me.tsbSalir})
    Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
    Me.ToolStrip1.Name = "ToolStrip1"
    Me.ToolStrip1.Size = New System.Drawing.Size(754, 73)
    Me.ToolStrip1.TabIndex = 5
    Me.ToolStrip1.Text = "ToolStrip1"
    '
    'ToolStripButton5
    '
    Me.ToolStripButton5.AccessibleRole = System.Windows.Forms.AccessibleRole.None
    Me.ToolStripButton5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
    Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.ToolStripButton5.Name = "ToolStripButton5"
    Me.ToolStripButton5.Size = New System.Drawing.Size(66, 70)
    Me.ToolStripButton5.Text = "Compras"
    Me.ToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'tsbReposicion
    '
    Me.tsbReposicion.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.tsbReposicion.Image = CType(resources.GetObject("tsbReposicion.Image"), System.Drawing.Image)
    Me.tsbReposicion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.tsbReposicion.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.tsbReposicion.Name = "tsbReposicion"
    Me.tsbReposicion.Size = New System.Drawing.Size(80, 70)
    Me.tsbReposicion.Text = "Reposición"
    Me.tsbReposicion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'tsbSalir
    '
    Me.tsbSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.None
    Me.tsbSalir.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
    Me.tsbSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
    Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.tsbSalir.Name = "tsbSalir"
    Me.tsbSalir.Size = New System.Drawing.Size(52, 70)
    Me.tsbSalir.Text = "Salir"
    Me.tsbSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
    '
    'frmPrincipal
    '
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
    Me.BackColor = System.Drawing.Color.White
    Me.ClientSize = New System.Drawing.Size(754, 470)
    Me.Controls.Add(Me.ToolStrip1)
    Me.Controls.Add(Me.ssBarra)
    Me.Controls.Add(Me.mnuPrincipal)
    Me.IsMdiContainer = True
    Me.MainMenuStrip = Me.mnuPrincipal
    Me.Name = "frmPrincipal"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Sistema de Gestión de Caja Chica y Bancos"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.mnuPrincipal.ResumeLayout(False)
    Me.mnuPrincipal.PerformLayout()
    Me.ssBarra.ResumeLayout(False)
    Me.ssBarra.PerformLayout()
    CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ToolStrip1.ResumeLayout(False)
    Me.ToolStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents mnuPrincipal As System.Windows.Forms.MenuStrip
  Friend WithEvents mnuMantenimiento As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnuCambiarContrasenia As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ssBarra As System.Windows.Forms.StatusStrip
  Friend WithEvents tHoraFecha As System.Windows.Forms.Timer
  Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
  Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
  Friend WithEvents tsbReposicion As System.Windows.Forms.ToolStripButton
  Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
  Friend WithEvents tsslUsuarioLabel As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents tsslUsuario As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents tsslVacio As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents tsslFecha As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents tsslHora As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
End Class
