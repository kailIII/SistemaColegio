<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionAreasDRE
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
    Me.lblDRE = New System.Windows.Forms.Label
    Me.lblNivel = New System.Windows.Forms.Label
    Me.lblArea = New System.Windows.Forms.Label
    Me.cboDRE = New System.Windows.Forms.ComboBox
    Me.cboNivel = New System.Windows.Forms.ComboBox
    Me.txtArea = New System.Windows.Forms.TextBox
    Me.gbArea = New System.Windows.Forms.GroupBox
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.errAreaDre = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.lblMensaje = New System.Windows.Forms.Label
    Me.gbDRE = New System.Windows.Forms.GroupBox
    Me.gbListaAreas = New System.Windows.Forms.GroupBox
    Me.btnCoordinador = New System.Windows.Forms.Button
    Me.btnModificar = New System.Windows.Forms.Button
    Me.lbListArea = New System.Windows.Forms.ListBox
    Me.lblOrden = New System.Windows.Forms.Label
    Me.nudOrden = New System.Windows.Forms.NumericUpDown
    Me.gbArea.SuspendLayout()
    CType(Me.errAreaDre, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbDRE.SuspendLayout()
    Me.gbListaAreas.SuspendLayout()
    CType(Me.nudOrden, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblDRE
    '
    Me.lblDRE.AutoSize = True
    Me.lblDRE.Location = New System.Drawing.Point(35, 41)
    Me.lblDRE.Name = "lblDRE"
    Me.lblDRE.Size = New System.Drawing.Size(30, 13)
    Me.lblDRE.TabIndex = 0
    Me.lblDRE.Text = "D&RE"
    '
    'lblNivel
    '
    Me.lblNivel.AutoSize = True
    Me.lblNivel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNivel.Location = New System.Drawing.Point(41, 44)
    Me.lblNivel.Name = "lblNivel"
    Me.lblNivel.Size = New System.Drawing.Size(35, 15)
    Me.lblNivel.TabIndex = 0
    Me.lblNivel.Text = "N&ivel"
    '
    'lblArea
    '
    Me.lblArea.AutoSize = True
    Me.lblArea.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblArea.Location = New System.Drawing.Point(32, 73)
    Me.lblArea.Name = "lblArea"
    Me.lblArea.Size = New System.Drawing.Size(49, 15)
    Me.lblArea.TabIndex = 2
    Me.lblArea.Text = "No&mbre"
    '
    'cboDRE
    '
    Me.cboDRE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboDRE.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboDRE.FormattingEnabled = True
    Me.cboDRE.Location = New System.Drawing.Point(85, 30)
    Me.cboDRE.Name = "cboDRE"
    Me.cboDRE.Size = New System.Drawing.Size(235, 24)
    Me.cboDRE.TabIndex = 1
    '
    'cboNivel
    '
    Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNivel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Location = New System.Drawing.Point(85, 35)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(203, 24)
    Me.cboNivel.TabIndex = 1
    '
    'txtArea
    '
    Me.txtArea.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtArea.Location = New System.Drawing.Point(85, 73)
    Me.txtArea.Multiline = True
    Me.txtArea.Name = "txtArea"
    Me.txtArea.Size = New System.Drawing.Size(203, 43)
    Me.txtArea.TabIndex = 3
    '
    'gbArea
    '
    Me.gbArea.Controls.Add(Me.nudOrden)
    Me.gbArea.Controls.Add(Me.txtArea)
    Me.gbArea.Controls.Add(Me.cboNivel)
    Me.gbArea.Controls.Add(Me.lblOrden)
    Me.gbArea.Controls.Add(Me.lblArea)
    Me.gbArea.Controls.Add(Me.lblNivel)
    Me.gbArea.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbArea.Location = New System.Drawing.Point(400, 120)
    Me.gbArea.Name = "gbArea"
    Me.gbArea.Size = New System.Drawing.Size(355, 262)
    Me.gbArea.TabIndex = 1
    Me.gbArea.TabStop = False
    Me.gbArea.Text = "Área"
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(773, 130)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 50)
    Me.btnRegistrar.TabIndex = 2
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(773, 186)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 50)
    Me.btnCancelar.TabIndex = 3
    Me.btnCancelar.Text = "&Deshacer"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(773, 332)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 50)
    Me.btnCerrar.TabIndex = 5
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'errAreaDre
    '
    Me.errAreaDre.ContainerControl = Me
    '
    'lblMensaje
    '
    Me.lblMensaje.AutoSize = True
    Me.lblMensaje.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMensaje.ForeColor = System.Drawing.SystemColors.ActiveCaption
    Me.lblMensaje.Location = New System.Drawing.Point(32, 394)
    Me.lblMensaje.Name = "lblMensaje"
    Me.lblMensaje.Size = New System.Drawing.Size(415, 19)
    Me.lblMensaje.TabIndex = 6
    Me.lblMensaje.Text = "Click en Deshacer para anular la operación y volver a iniciar."
    '
    'gbDRE
    '
    Me.gbDRE.Controls.Add(Me.cboDRE)
    Me.gbDRE.Controls.Add(Me.lblDRE)
    Me.gbDRE.Location = New System.Drawing.Point(400, 26)
    Me.gbDRE.Name = "gbDRE"
    Me.gbDRE.Size = New System.Drawing.Size(355, 79)
    Me.gbDRE.TabIndex = 0
    Me.gbDRE.TabStop = False
    '
    'gbListaAreas
    '
    Me.gbListaAreas.Controls.Add(Me.btnCoordinador)
    Me.gbListaAreas.Controls.Add(Me.btnModificar)
    Me.gbListaAreas.Controls.Add(Me.lbListArea)
    Me.gbListaAreas.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbListaAreas.Location = New System.Drawing.Point(35, 26)
    Me.gbListaAreas.Name = "gbListaAreas"
    Me.gbListaAreas.Size = New System.Drawing.Size(348, 356)
    Me.gbListaAreas.TabIndex = 4
    Me.gbListaAreas.TabStop = False
    Me.gbListaAreas.Text = "Listado de Áreas"
    '
    'btnCoordinador
    '
    Me.btnCoordinador.BackColor = System.Drawing.Color.White
    Me.btnCoordinador.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCoordinador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCoordinador.Location = New System.Drawing.Point(217, 295)
    Me.btnCoordinador.Name = "btnCoordinador"
    Me.btnCoordinador.Size = New System.Drawing.Size(110, 52)
    Me.btnCoordinador.TabIndex = 4
    Me.btnCoordinador.Text = "C&oordinador"
    Me.btnCoordinador.UseVisualStyleBackColor = False
    '
    'btnModificar
    '
    Me.btnModificar.BackColor = System.Drawing.Color.White
    Me.btnModificar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnModificar.Location = New System.Drawing.Point(22, 295)
    Me.btnModificar.Name = "btnModificar"
    Me.btnModificar.Size = New System.Drawing.Size(110, 50)
    Me.btnModificar.TabIndex = 2
    Me.btnModificar.Text = "&Modificar"
    Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnModificar.UseVisualStyleBackColor = False
    '
    'lbListArea
    '
    Me.lbListArea.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lbListArea.FormattingEnabled = True
    Me.lbListArea.HorizontalScrollbar = True
    Me.lbListArea.ItemHeight = 17
    Me.lbListArea.Location = New System.Drawing.Point(22, 30)
    Me.lbListArea.Name = "lbListArea"
    Me.lbListArea.ScrollAlwaysVisible = True
    Me.lbListArea.Size = New System.Drawing.Size(305, 259)
    Me.lbListArea.TabIndex = 1
    '
    'lblOrden
    '
    Me.lblOrden.AutoSize = True
    Me.lblOrden.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblOrden.Location = New System.Drawing.Point(32, 152)
    Me.lblOrden.Name = "lblOrden"
    Me.lblOrden.Size = New System.Drawing.Size(40, 15)
    Me.lblOrden.TabIndex = 2
    Me.lblOrden.Text = "&Orden"
    '
    'nudOrden
    '
    Me.nudOrden.Location = New System.Drawing.Point(85, 142)
    Me.nudOrden.Name = "nudOrden"
    Me.nudOrden.Size = New System.Drawing.Size(71, 25)
    Me.nudOrden.TabIndex = 4
    Me.nudOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'frmGestionAreasDRE
    '
    Me.AcceptButton = Me.btnRegistrar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(914, 425)
    Me.Controls.Add(Me.gbListaAreas)
    Me.Controls.Add(Me.gbDRE)
    Me.Controls.Add(Me.lblMensaje)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.gbArea)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.Name = "frmGestionAreasDRE"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de áreas de la DRE"
    Me.gbArea.ResumeLayout(False)
    Me.gbArea.PerformLayout()
    CType(Me.errAreaDre, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbDRE.ResumeLayout(False)
    Me.gbDRE.PerformLayout()
    Me.gbListaAreas.ResumeLayout(False)
    CType(Me.nudOrden, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblDRE As System.Windows.Forms.Label
  Friend WithEvents lblNivel As System.Windows.Forms.Label
  Friend WithEvents lblArea As System.Windows.Forms.Label
  Friend WithEvents cboDRE As System.Windows.Forms.ComboBox
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents txtArea As System.Windows.Forms.TextBox
  Friend WithEvents gbArea As System.Windows.Forms.GroupBox
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents errAreaDre As System.Windows.Forms.ErrorProvider
  Friend WithEvents lblMensaje As System.Windows.Forms.Label
  Friend WithEvents gbDRE As System.Windows.Forms.GroupBox
  Friend WithEvents gbListaAreas As System.Windows.Forms.GroupBox
  Friend WithEvents lbListArea As System.Windows.Forms.ListBox
  Friend WithEvents btnModificar As System.Windows.Forms.Button
  Friend WithEvents btnCoordinador As System.Windows.Forms.Button
  Friend WithEvents nudOrden As System.Windows.Forms.NumericUpDown
  Friend WithEvents lblOrden As System.Windows.Forms.Label
End Class
