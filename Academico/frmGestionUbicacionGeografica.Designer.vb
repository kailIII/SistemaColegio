<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionUbicacionGeografica
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
    Me.GroupBoxNuevo = New System.Windows.Forms.GroupBox
    Me.txtDistrito = New System.Windows.Forms.TextBox
    Me.Label5 = New System.Windows.Forms.Label
    Me.txtProvincia = New System.Windows.Forms.TextBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.txtdpto = New System.Windows.Forms.TextBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.txtpais = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.btnActualizar = New System.Windows.Forms.Button
    Me.ErrUbicacion = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.gbListaUbicGeog = New System.Windows.Forms.GroupBox
    Me.lblbuscar = New System.Windows.Forms.Label
    Me.btnBuscar = New System.Windows.Forms.Button
    Me.txtBuscar = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.dgvUbicacion = New System.Windows.Forms.DataGridView
    Me.cdCodigoAula = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdPais = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdDepartamento = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdProvincia = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdDistrito = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.GroupBoxNuevo.SuspendLayout()
    CType(Me.ErrUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbListaUbicGeog.SuspendLayout()
    CType(Me.dgvUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'GroupBoxNuevo
    '
    Me.GroupBoxNuevo.Controls.Add(Me.txtDistrito)
    Me.GroupBoxNuevo.Controls.Add(Me.Label5)
    Me.GroupBoxNuevo.Controls.Add(Me.txtProvincia)
    Me.GroupBoxNuevo.Controls.Add(Me.Label4)
    Me.GroupBoxNuevo.Controls.Add(Me.txtdpto)
    Me.GroupBoxNuevo.Controls.Add(Me.Label3)
    Me.GroupBoxNuevo.Controls.Add(Me.txtpais)
    Me.GroupBoxNuevo.Controls.Add(Me.Label1)
    Me.GroupBoxNuevo.Location = New System.Drawing.Point(12, 384)
    Me.GroupBoxNuevo.Name = "GroupBoxNuevo"
    Me.GroupBoxNuevo.Size = New System.Drawing.Size(584, 150)
    Me.GroupBoxNuevo.TabIndex = 27
    Me.GroupBoxNuevo.TabStop = False
    Me.GroupBoxNuevo.Text = "Ubicación Geográfica"
    '
    'txtDistrito
    '
    Me.txtDistrito.Location = New System.Drawing.Point(98, 112)
    Me.txtDistrito.Name = "txtDistrito"
    Me.txtDistrito.Size = New System.Drawing.Size(467, 20)
    Me.txtDistrito.TabIndex = 7
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(47, 112)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(39, 13)
    Me.Label5.TabIndex = 6
    Me.Label5.Text = "Distrito"
    '
    'txtProvincia
    '
    Me.txtProvincia.Location = New System.Drawing.Point(98, 86)
    Me.txtProvincia.Name = "txtProvincia"
    Me.txtProvincia.Size = New System.Drawing.Size(467, 20)
    Me.txtProvincia.TabIndex = 5
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(35, 86)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(51, 13)
    Me.Label4.TabIndex = 4
    Me.Label4.Text = "Provincia"
    '
    'txtdpto
    '
    Me.txtdpto.Location = New System.Drawing.Point(98, 60)
    Me.txtdpto.Name = "txtdpto"
    Me.txtdpto.Size = New System.Drawing.Size(467, 20)
    Me.txtdpto.TabIndex = 3
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 60)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(74, 13)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Departamento"
    '
    'txtpais
    '
    Me.txtpais.Location = New System.Drawing.Point(98, 34)
    Me.txtpais.Name = "txtpais"
    Me.txtpais.Size = New System.Drawing.Size(467, 20)
    Me.txtpais.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(59, 34)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(27, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Pais"
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(610, 276)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
    Me.btnCancelar.TabIndex = 25
    Me.btnCancelar.Text = "&Deshacer"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(610, 482)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 26
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(610, 204)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
    Me.btnRegistrar.TabIndex = 24
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'btnActualizar
    '
    Me.btnActualizar.BackColor = System.Drawing.Color.White
    Me.btnActualizar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnActualizar.Location = New System.Drawing.Point(610, 118)
    Me.btnActualizar.Name = "btnActualizar"
    Me.btnActualizar.Size = New System.Drawing.Size(110, 52)
    Me.btnActualizar.TabIndex = 23
    Me.btnActualizar.Text = "&Seleccionar"
    Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnActualizar.UseVisualStyleBackColor = False
    '
    'ErrUbicacion
    '
    Me.ErrUbicacion.ContainerControl = Me
    '
    'gbListaUbicGeog
    '
    Me.gbListaUbicGeog.Controls.Add(Me.lblbuscar)
    Me.gbListaUbicGeog.Controls.Add(Me.btnBuscar)
    Me.gbListaUbicGeog.Controls.Add(Me.txtBuscar)
    Me.gbListaUbicGeog.Controls.Add(Me.Label2)
    Me.gbListaUbicGeog.Controls.Add(Me.dgvUbicacion)
    Me.gbListaUbicGeog.Location = New System.Drawing.Point(12, 12)
    Me.gbListaUbicGeog.Name = "gbListaUbicGeog"
    Me.gbListaUbicGeog.Size = New System.Drawing.Size(584, 366)
    Me.gbListaUbicGeog.TabIndex = 22
    Me.gbListaUbicGeog.TabStop = False
    Me.gbListaUbicGeog.Text = "Lista Ubicación Geográfica"
    '
    'lblbuscar
    '
    Me.lblbuscar.AutoSize = True
    Me.lblbuscar.BackColor = System.Drawing.Color.Transparent
    Me.lblbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblbuscar.ForeColor = System.Drawing.SystemColors.ActiveCaption
    Me.lblbuscar.Location = New System.Drawing.Point(78, 41)
    Me.lblbuscar.Name = "lblbuscar"
    Me.lblbuscar.Size = New System.Drawing.Size(329, 13)
    Me.lblbuscar.TabIndex = 6
    Me.lblbuscar.Text = "Orden:     Pais      Departamento    Provincia      Distrito "
    '
    'btnBuscar
    '
    Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnBuscar.BackColor = System.Drawing.Color.White
    Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
    Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.7!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscar.Location = New System.Drawing.Point(507, 14)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(71, 28)
    Me.btnBuscar.TabIndex = 5
    Me.btnBuscar.Text = "&Buscar"
    Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscar.UseVisualStyleBackColor = False
    '
    'txtBuscar
    '
    Me.txtBuscar.Location = New System.Drawing.Point(62, 19)
    Me.txtBuscar.Name = "txtBuscar"
    Me.txtBuscar.Size = New System.Drawing.Size(432, 20)
    Me.txtBuscar.TabIndex = 4
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(5, 22)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(44, 13)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Nombre"
    '
    'dgvUbicacion
    '
    Me.dgvUbicacion.AllowUserToAddRows = False
    Me.dgvUbicacion.AllowUserToDeleteRows = False
    Me.dgvUbicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvUbicacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdCodigoAula, Me.cdPais, Me.cdDepartamento, Me.cdProvincia, Me.cdDistrito})
    Me.dgvUbicacion.Location = New System.Drawing.Point(8, 67)
    Me.dgvUbicacion.MultiSelect = False
    Me.dgvUbicacion.Name = "dgvUbicacion"
    Me.dgvUbicacion.ReadOnly = True
    Me.dgvUbicacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvUbicacion.Size = New System.Drawing.Size(570, 287)
    Me.dgvUbicacion.TabIndex = 0
    '
    'cdCodigoAula
    '
    Me.cdCodigoAula.DataPropertyName = "Codigo"
    Me.cdCodigoAula.HeaderText = ""
    Me.cdCodigoAula.Name = "cdCodigoAula"
    Me.cdCodigoAula.ReadOnly = True
    Me.cdCodigoAula.Visible = False
    Me.cdCodigoAula.Width = 10
    '
    'cdPais
    '
    Me.cdPais.DataPropertyName = "Pais"
    Me.cdPais.HeaderText = "Pais"
    Me.cdPais.Name = "cdPais"
    Me.cdPais.ReadOnly = True
    '
    'cdDepartamento
    '
    Me.cdDepartamento.DataPropertyName = "Departamento"
    Me.cdDepartamento.HeaderText = "Departamento"
    Me.cdDepartamento.Name = "cdDepartamento"
    Me.cdDepartamento.ReadOnly = True
    Me.cdDepartamento.Width = 130
    '
    'cdProvincia
    '
    Me.cdProvincia.DataPropertyName = "Provincia"
    Me.cdProvincia.HeaderText = "Provincia"
    Me.cdProvincia.Name = "cdProvincia"
    Me.cdProvincia.ReadOnly = True
    Me.cdProvincia.Width = 130
    '
    'cdDistrito
    '
    Me.cdDistrito.DataPropertyName = "Distrito"
    Me.cdDistrito.HeaderText = "Distrito"
    Me.cdDistrito.Name = "cdDistrito"
    Me.cdDistrito.ReadOnly = True
    Me.cdDistrito.Width = 150
    '
    'frmGestionUbicacionGeografica
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(732, 545)
    Me.Controls.Add(Me.GroupBoxNuevo)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.btnActualizar)
    Me.Controls.Add(Me.gbListaUbicGeog)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmGestionUbicacionGeografica"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de Ubicación Geográfica"
    Me.GroupBoxNuevo.ResumeLayout(False)
    Me.GroupBoxNuevo.PerformLayout()
    CType(Me.ErrUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbListaUbicGeog.ResumeLayout(False)
    Me.gbListaUbicGeog.PerformLayout()
    CType(Me.dgvUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents GroupBoxNuevo As System.Windows.Forms.GroupBox
  Friend WithEvents txtDistrito As System.Windows.Forms.TextBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txtProvincia As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents txtdpto As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtpais As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnActualizar As System.Windows.Forms.Button
  Friend WithEvents ErrUbicacion As System.Windows.Forms.ErrorProvider
  Friend WithEvents gbListaUbicGeog As System.Windows.Forms.GroupBox
  Friend WithEvents lblbuscar As System.Windows.Forms.Label
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
  Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents dgvUbicacion As System.Windows.Forms.DataGridView
  Friend WithEvents cdCodigoAula As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdPais As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDepartamento As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdProvincia As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDistrito As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
