<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionLocales
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
    Me.ErrLocal = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.gbLocales = New System.Windows.Forms.GroupBox
    Me.btnActualizar = New System.Windows.Forms.Button
    Me.btnAgregarAmbientes = New System.Windows.Forms.Button
    Me.dgvLocales = New System.Windows.Forms.DataGridView
    Me.cdCodigoLocal = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.gbLocal = New System.Windows.Forms.GroupBox
    Me.cBoxVigenciaLocal = New System.Windows.Forms.CheckBox
    Me.txttelefono = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.txtcodigo = New System.Windows.Forms.TextBox
    Me.lblcodlocal = New System.Windows.Forms.Label
    Me.Ubicacion = New Colegio.IAcademico.ControlUbicacionGeografica
    Me.txtnombre = New System.Windows.Forms.TextBox
    Me.Label2 = New System.Windows.Forms.Label
    Me.txtDireccion = New System.Windows.Forms.TextBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.txtInstitucion = New System.Windows.Forms.TextBox
    Me.lblMensaje = New System.Windows.Forms.Label
    CType(Me.ErrLocal, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbLocales.SuspendLayout()
    CType(Me.dgvLocales, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbLocal.SuspendLayout()
    Me.SuspendLayout()
    '
    'ErrLocal
    '
    Me.ErrLocal.ContainerControl = Me
    '
    'gbLocales
    '
    Me.gbLocales.Controls.Add(Me.btnActualizar)
    Me.gbLocales.Controls.Add(Me.btnAgregarAmbientes)
    Me.gbLocales.Controls.Add(Me.dgvLocales)
    Me.gbLocales.Location = New System.Drawing.Point(7, 24)
    Me.gbLocales.Name = "gbLocales"
    Me.gbLocales.Size = New System.Drawing.Size(365, 406)
    Me.gbLocales.TabIndex = 1
    Me.gbLocales.TabStop = False
    Me.gbLocales.Text = "Lista de Locales"
    '
    'btnActualizar
    '
    Me.btnActualizar.BackColor = System.Drawing.Color.White
    Me.btnActualizar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnActualizar.Location = New System.Drawing.Point(27, 346)
    Me.btnActualizar.Name = "btnActualizar"
    Me.btnActualizar.Size = New System.Drawing.Size(110, 52)
    Me.btnActualizar.TabIndex = 1
    Me.btnActualizar.Text = "&Seleccionar"
    Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnActualizar.UseVisualStyleBackColor = False
    '
    'btnAgregarAmbientes
    '
    Me.btnAgregarAmbientes.BackColor = System.Drawing.Color.White
    Me.btnAgregarAmbientes.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnAgregarAmbientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAgregarAmbientes.Location = New System.Drawing.Point(207, 346)
    Me.btnAgregarAmbientes.Name = "btnAgregarAmbientes"
    Me.btnAgregarAmbientes.Size = New System.Drawing.Size(110, 52)
    Me.btnAgregarAmbientes.TabIndex = 2
    Me.btnAgregarAmbientes.Text = "A&mbientes"
    Me.btnAgregarAmbientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnAgregarAmbientes.UseVisualStyleBackColor = False
    '
    'dgvLocales
    '
    Me.dgvLocales.AllowUserToAddRows = False
    Me.dgvLocales.AllowUserToDeleteRows = False
    Me.dgvLocales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvLocales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdCodigoLocal, Me.cdNombre, Me.cdDireccion})
    Me.dgvLocales.Location = New System.Drawing.Point(9, 25)
    Me.dgvLocales.MultiSelect = False
    Me.dgvLocales.Name = "dgvLocales"
    Me.dgvLocales.ReadOnly = True
    Me.dgvLocales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvLocales.Size = New System.Drawing.Size(348, 315)
    Me.dgvLocales.TabIndex = 0
    '
    'cdCodigoLocal
    '
    Me.cdCodigoLocal.DataPropertyName = "Codigo"
    Me.cdCodigoLocal.HeaderText = ""
    Me.cdCodigoLocal.Name = "cdCodigoLocal"
    Me.cdCodigoLocal.ReadOnly = True
    Me.cdCodigoLocal.Visible = False
    '
    'cdNombre
    '
    Me.cdNombre.DataPropertyName = "Nombre"
    Me.cdNombre.HeaderText = "Nombre"
    Me.cdNombre.Name = "cdNombre"
    Me.cdNombre.ReadOnly = True
    Me.cdNombre.Width = 150
    '
    'cdDireccion
    '
    Me.cdDireccion.DataPropertyName = "Direccion"
    Me.cdDireccion.HeaderText = "Direccion"
    Me.cdDireccion.Name = "cdDireccion"
    Me.cdDireccion.ReadOnly = True
    Me.cdDireccion.Width = 150
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(867, 128)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
    Me.btnCancelar.TabIndex = 3
    Me.btnCancelar.Text = "&Deshacer"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(867, 370)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 4
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(867, 66)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
    Me.btnRegistrar.TabIndex = 2
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'gbLocal
    '
    Me.gbLocal.Controls.Add(Me.cBoxVigenciaLocal)
    Me.gbLocal.Controls.Add(Me.txttelefono)
    Me.gbLocal.Controls.Add(Me.Label1)
    Me.gbLocal.Controls.Add(Me.txtcodigo)
    Me.gbLocal.Controls.Add(Me.lblcodlocal)
    Me.gbLocal.Controls.Add(Me.Ubicacion)
    Me.gbLocal.Controls.Add(Me.txtnombre)
    Me.gbLocal.Controls.Add(Me.Label2)
    Me.gbLocal.Controls.Add(Me.txtDireccion)
    Me.gbLocal.Controls.Add(Me.Label3)
    Me.gbLocal.Controls.Add(Me.txtInstitucion)
    Me.gbLocal.Location = New System.Drawing.Point(375, 24)
    Me.gbLocal.Name = "gbLocal"
    Me.gbLocal.Size = New System.Drawing.Size(486, 406)
    Me.gbLocal.TabIndex = 0
    Me.gbLocal.TabStop = False
    Me.gbLocal.Text = "Local"
    '
    'cBoxVigenciaLocal
    '
    Me.cBoxVigenciaLocal.AutoSize = True
    Me.cBoxVigenciaLocal.Checked = True
    Me.cBoxVigenciaLocal.CheckState = System.Windows.Forms.CheckState.Checked
    Me.cBoxVigenciaLocal.Location = New System.Drawing.Point(357, 148)
    Me.cBoxVigenciaLocal.Name = "cBoxVigenciaLocal"
    Me.cBoxVigenciaLocal.Size = New System.Drawing.Size(67, 19)
    Me.cBoxVigenciaLocal.TabIndex = 7
    Me.cBoxVigenciaLocal.Text = "&Vigente"
    Me.cBoxVigenciaLocal.UseVisualStyleBackColor = True
    Me.cBoxVigenciaLocal.Visible = False
    '
    'txttelefono
    '
    Me.txttelefono.Location = New System.Drawing.Point(83, 140)
    Me.txttelefono.MaxLength = 10
    Me.txttelefono.Multiline = True
    Me.txttelefono.Name = "txttelefono"
    Me.txttelefono.Size = New System.Drawing.Size(114, 27)
    Me.txttelefono.TabIndex = 6
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(11, 148)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(55, 15)
    Me.Label1.TabIndex = 5
    Me.Label1.Text = "&Teléfono"
    '
    'txtcodigo
    '
    Me.txtcodigo.Location = New System.Drawing.Point(83, 62)
    Me.txtcodigo.MaxLength = 6
    Me.txtcodigo.Multiline = True
    Me.txtcodigo.Name = "txtcodigo"
    Me.txtcodigo.Size = New System.Drawing.Size(114, 27)
    Me.txtcodigo.TabIndex = 2
    '
    'lblcodlocal
    '
    Me.lblcodlocal.AutoSize = True
    Me.lblcodlocal.Location = New System.Drawing.Point(17, 65)
    Me.lblcodlocal.Name = "lblcodlocal"
    Me.lblcodlocal.Size = New System.Drawing.Size(49, 15)
    Me.lblcodlocal.TabIndex = 1
    Me.lblcodlocal.Text = "Codigo "
    '
    'Ubicacion
    '
    Me.Ubicacion.Location = New System.Drawing.Point(2, 231)
    Me.Ubicacion.Name = "Ubicacion"
    Me.Ubicacion.Size = New System.Drawing.Size(477, 111)
    Me.Ubicacion.TabIndex = 10
    '
    'txtnombre
    '
    Me.txtnombre.Location = New System.Drawing.Point(83, 104)
    Me.txtnombre.Multiline = True
    Me.txtnombre.Name = "txtnombre"
    Me.txtnombre.Size = New System.Drawing.Size(393, 27)
    Me.txtnombre.TabIndex = 4
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(17, 107)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(49, 15)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "&Nombre"
    '
    'txtDireccion
    '
    Me.txtDireccion.Location = New System.Drawing.Point(83, 198)
    Me.txtDireccion.Multiline = True
    Me.txtDireccion.Name = "txtDireccion"
    Me.txtDireccion.Size = New System.Drawing.Size(393, 27)
    Me.txtDireccion.TabIndex = 9
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(8, 198)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(58, 15)
    Me.Label3.TabIndex = 8
    Me.Label3.Text = "&Dirección"
    '
    'txtInstitucion
    '
    Me.txtInstitucion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.txtInstitucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtInstitucion.Location = New System.Drawing.Point(15, 25)
    Me.txtInstitucion.Name = "txtInstitucion"
    Me.txtInstitucion.ReadOnly = True
    Me.txtInstitucion.Size = New System.Drawing.Size(464, 22)
    Me.txtInstitucion.TabIndex = 0
    Me.txtInstitucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'lblMensaje
    '
    Me.lblMensaje.AutoSize = True
    Me.lblMensaje.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMensaje.ForeColor = System.Drawing.SystemColors.ActiveCaption
    Me.lblMensaje.Location = New System.Drawing.Point(373, 442)
    Me.lblMensaje.Name = "lblMensaje"
    Me.lblMensaje.Size = New System.Drawing.Size(416, 19)
    Me.lblMensaje.TabIndex = 7
    Me.lblMensaje.Text = "Click en Deshacer para anular la operación y volver a iniciar."
    '
    'frmGestionLocales
    '
    Me.AcceptButton = Me.btnRegistrar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(984, 470)
    Me.Controls.Add(Me.lblMensaje)
    Me.Controls.Add(Me.gbLocales)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.gbLocal)
    Me.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.Name = "frmGestionLocales"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de Locales"
    CType(Me.ErrLocal, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbLocales.ResumeLayout(False)
    CType(Me.dgvLocales, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbLocal.ResumeLayout(False)
    Me.gbLocal.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
    Friend WithEvents ErrLocal As System.Windows.Forms.ErrorProvider
    Friend WithEvents gbLocales As System.Windows.Forms.GroupBox
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnAgregarAmbientes As System.Windows.Forms.Button
    Friend WithEvents dgvLocales As System.Windows.Forms.DataGridView
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents gbLocal As System.Windows.Forms.GroupBox
    Friend WithEvents cBoxVigenciaLocal As System.Windows.Forms.CheckBox
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblcodlocal As System.Windows.Forms.Label
    Friend WithEvents Ubicacion As Colegio.IAcademico.ControlUbicacionGeografica
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtInstitucion As System.Windows.Forms.TextBox
  Friend WithEvents lblMensaje As System.Windows.Forms.Label
  Friend WithEvents cdCodigoLocal As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdNombre As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDireccion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
