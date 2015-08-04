<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionProfesion
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
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.btnActualizar = New System.Windows.Forms.Button
    Me.GroupBoxNuevo = New System.Windows.Forms.GroupBox
    Me.txtNombre = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.GroupBoxProfesiones = New System.Windows.Forms.GroupBox
    Me.btnBuscar = New System.Windows.Forms.Button
    Me.txtBuscar = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.dgvProfesion = New System.Windows.Forms.DataGridView
    Me.cdCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ErrProfesion = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.GroupBoxNuevo.SuspendLayout()
    Me.GroupBoxProfesiones.SuspendLayout()
    CType(Me.dgvProfesion, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ErrProfesion, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(651, 329)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
    Me.btnCancelar.TabIndex = 10
    Me.btnCancelar.Text = "&Deshacer"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(651, 520)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 11
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(651, 246)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
    Me.btnRegistrar.TabIndex = 9
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'btnActualizar
    '
    Me.btnActualizar.BackColor = System.Drawing.Color.White
    Me.btnActualizar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnActualizar.Location = New System.Drawing.Point(651, 147)
    Me.btnActualizar.Name = "btnActualizar"
    Me.btnActualizar.Size = New System.Drawing.Size(110, 52)
    Me.btnActualizar.TabIndex = 7
    Me.btnActualizar.Text = "&Seleccionar"
    Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnActualizar.UseVisualStyleBackColor = False
    '
    'GroupBoxNuevo
    '
    Me.GroupBoxNuevo.Controls.Add(Me.txtNombre)
    Me.GroupBoxNuevo.Controls.Add(Me.Label1)
    Me.GroupBoxNuevo.Location = New System.Drawing.Point(21, 497)
    Me.GroupBoxNuevo.Name = "GroupBoxNuevo"
    Me.GroupBoxNuevo.Size = New System.Drawing.Size(624, 82)
    Me.GroupBoxNuevo.TabIndex = 8
    Me.GroupBoxNuevo.TabStop = False
    Me.GroupBoxNuevo.Text = "Profesión"
    '
    'txtNombre
    '
    Me.txtNombre.Location = New System.Drawing.Point(76, 39)
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Size = New System.Drawing.Size(541, 22)
    Me.txtNombre.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(9, 43)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(49, 15)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Nombre"
    '
    'GroupBoxProfesiones
    '
    Me.GroupBoxProfesiones.Controls.Add(Me.btnBuscar)
    Me.GroupBoxProfesiones.Controls.Add(Me.txtBuscar)
    Me.GroupBoxProfesiones.Controls.Add(Me.Label2)
    Me.GroupBoxProfesiones.Controls.Add(Me.dgvProfesion)
    Me.GroupBoxProfesiones.Location = New System.Drawing.Point(21, 13)
    Me.GroupBoxProfesiones.Name = "GroupBoxProfesiones"
    Me.GroupBoxProfesiones.Size = New System.Drawing.Size(624, 478)
    Me.GroupBoxProfesiones.TabIndex = 6
    Me.GroupBoxProfesiones.TabStop = False
    Me.GroupBoxProfesiones.Text = "Lista de profesiones"
    '
    'btnBuscar
    '
    Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnBuscar.BackColor = System.Drawing.Color.White
    Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
    Me.btnBuscar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscar.Location = New System.Drawing.Point(534, 22)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(83, 32)
    Me.btnBuscar.TabIndex = 2
    Me.btnBuscar.Text = "&Buscar"
    Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscar.UseVisualStyleBackColor = False
    '
    'txtBuscar
    '
    Me.txtBuscar.Location = New System.Drawing.Point(76, 28)
    Me.txtBuscar.Name = "txtBuscar"
    Me.txtBuscar.Size = New System.Drawing.Size(451, 22)
    Me.txtBuscar.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(9, 31)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(49, 15)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Nombre"
    '
    'dgvProfesion
    '
    Me.dgvProfesion.AllowUserToAddRows = False
    Me.dgvProfesion.AllowUserToDeleteRows = False
    Me.dgvProfesion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvProfesion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdCodigo, Me.cdNombre})
    Me.dgvProfesion.Location = New System.Drawing.Point(9, 70)
    Me.dgvProfesion.MultiSelect = False
    Me.dgvProfesion.Name = "dgvProfesion"
    Me.dgvProfesion.ReadOnly = True
    Me.dgvProfesion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvProfesion.Size = New System.Drawing.Size(608, 393)
    Me.dgvProfesion.TabIndex = 3
    '
    'cdCodigo
    '
    Me.cdCodigo.DataPropertyName = "Codigo"
    Me.cdCodigo.HeaderText = ""
    Me.cdCodigo.Name = "cdCodigo"
    Me.cdCodigo.ReadOnly = True
    Me.cdCodigo.Visible = False
    '
    'cdNombre
    '
    Me.cdNombre.DataPropertyName = "Nombre"
    Me.cdNombre.HeaderText = "Nombre"
    Me.cdNombre.Name = "cdNombre"
    Me.cdNombre.ReadOnly = True
    Me.cdNombre.Width = 400
    '
    'ErrProfesion
    '
    Me.ErrProfesion.ContainerControl = Me
    '
    'frmGestionProfesion
    '
    Me.AcceptButton = Me.btnRegistrar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(770, 585)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.btnActualizar)
    Me.Controls.Add(Me.GroupBoxNuevo)
    Me.Controls.Add(Me.GroupBoxProfesiones)
    Me.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.Name = "frmGestionProfesion"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de profesiones"
    Me.GroupBoxNuevo.ResumeLayout(False)
    Me.GroupBoxNuevo.PerformLayout()
    Me.GroupBoxProfesiones.ResumeLayout(False)
    Me.GroupBoxProfesiones.PerformLayout()
    CType(Me.dgvProfesion, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ErrProfesion, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnActualizar As System.Windows.Forms.Button
  Friend WithEvents GroupBoxNuevo As System.Windows.Forms.GroupBox
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents GroupBoxProfesiones As System.Windows.Forms.GroupBox
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
  Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents dgvProfesion As System.Windows.Forms.DataGridView
  Friend WithEvents cdCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdNombre As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ErrProfesion As System.Windows.Forms.ErrorProvider
End Class
