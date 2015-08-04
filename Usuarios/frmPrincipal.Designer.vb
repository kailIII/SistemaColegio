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
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
    Me.RegistrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.RegistrarGrupoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.RegistrarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.AsignarGrupoAUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.RegistrarSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.RegistrarOpcionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.PermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.PermisosGrupalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.PermisosIndividualesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
    Me.MenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarToolStripMenuItem, Me.PermisosToolStripMenuItem})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(292, 24)
    Me.MenuStrip1.TabIndex = 0
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'RegistrarToolStripMenuItem
    '
    Me.RegistrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarGrupoToolStripMenuItem, Me.RegistrarUsuarioToolStripMenuItem, Me.AsignarGrupoAUsuarioToolStripMenuItem, Me.RegistrarSistemaToolStripMenuItem, Me.RegistrarOpcionToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
    Me.RegistrarToolStripMenuItem.Name = "RegistrarToolStripMenuItem"
    Me.RegistrarToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
    Me.RegistrarToolStripMenuItem.Text = "&Registrar"
    '
    'RegistrarGrupoToolStripMenuItem
    '
    Me.RegistrarGrupoToolStripMenuItem.Name = "RegistrarGrupoToolStripMenuItem"
    Me.RegistrarGrupoToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
    Me.RegistrarGrupoToolStripMenuItem.Text = "Registrar &Grupo"
    '
    'RegistrarUsuarioToolStripMenuItem
    '
    Me.RegistrarUsuarioToolStripMenuItem.Name = "RegistrarUsuarioToolStripMenuItem"
    Me.RegistrarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
    Me.RegistrarUsuarioToolStripMenuItem.Text = "Registrar &Usuario"
    '
    'AsignarGrupoAUsuarioToolStripMenuItem
    '
    Me.AsignarGrupoAUsuarioToolStripMenuItem.Name = "AsignarGrupoAUsuarioToolStripMenuItem"
    Me.AsignarGrupoAUsuarioToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
    Me.AsignarGrupoAUsuarioToolStripMenuItem.Text = "Asignar Grupo a Usuario"
    Me.AsignarGrupoAUsuarioToolStripMenuItem.Visible = False
    '
    'RegistrarSistemaToolStripMenuItem
    '
    Me.RegistrarSistemaToolStripMenuItem.Name = "RegistrarSistemaToolStripMenuItem"
    Me.RegistrarSistemaToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
    Me.RegistrarSistemaToolStripMenuItem.Text = "Registrar &Sistema"
    Me.RegistrarSistemaToolStripMenuItem.Visible = False
    '
    'RegistrarOpcionToolStripMenuItem
    '
    Me.RegistrarOpcionToolStripMenuItem.Name = "RegistrarOpcionToolStripMenuItem"
    Me.RegistrarOpcionToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
    Me.RegistrarOpcionToolStripMenuItem.Text = "Registrar &Opcion"
    Me.RegistrarOpcionToolStripMenuItem.Visible = False
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(199, 6)
    '
    'SalirToolStripMenuItem
    '
    Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
    Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
    Me.SalirToolStripMenuItem.Text = "&Salir"
    '
    'PermisosToolStripMenuItem
    '
    Me.PermisosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PermisosGrupalesToolStripMenuItem, Me.PermisosIndividualesToolStripMenuItem})
    Me.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem"
    Me.PermisosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
    Me.PermisosToolStripMenuItem.Text = "&Permisos"
    Me.PermisosToolStripMenuItem.Visible = False
    '
    'PermisosGrupalesToolStripMenuItem
    '
    Me.PermisosGrupalesToolStripMenuItem.Name = "PermisosGrupalesToolStripMenuItem"
    Me.PermisosGrupalesToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
    Me.PermisosGrupalesToolStripMenuItem.Text = "Permisos Grupales"
    '
    'PermisosIndividualesToolStripMenuItem
    '
    Me.PermisosIndividualesToolStripMenuItem.Name = "PermisosIndividualesToolStripMenuItem"
    Me.PermisosIndividualesToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
    Me.PermisosIndividualesToolStripMenuItem.Text = "Permisos Individuales"
    '
    'frmPrincipal
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(292, 266)
    Me.Controls.Add(Me.MenuStrip1)
    Me.IsMdiContainer = True
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "frmPrincipal"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Sistema de Control de Usuario"
    Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents RegistrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents PermisosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents RegistrarGrupoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents RegistrarUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents RegistrarSistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents RegistrarOpcionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents PermisosGrupalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents PermisosIndividualesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents AsignarGrupoAUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
