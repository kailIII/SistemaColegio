<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionarPersonas
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
    Me.components = New System.ComponentModel.Container
    Me.gbPersona = New System.Windows.Forms.GroupBox
    Me.txtApellidoMaterno = New System.Windows.Forms.TextBox
    Me.lblApellidoMaterno = New System.Windows.Forms.Label
    Me.txtApellidoPaterno = New System.Windows.Forms.TextBox
    Me.lblApellidoPat = New System.Windows.Forms.Label
    Me.txtNombre = New System.Windows.Forms.TextBox
    Me.lblNombres = New System.Windows.Forms.Label
    Me.btnAceptar = New System.Windows.Forms.Button
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.gbBuscar = New System.Windows.Forms.GroupBox
    Me.txtPersona = New System.Windows.Forms.TextBox
    Me.lblPersona = New System.Windows.Forms.Label
    Me.dgvPersonas = New System.Windows.Forms.DataGridView
    Me.cdNombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnListar = New System.Windows.Forms.Button
    Me.btnEliminarDuplicado = New System.Windows.Forms.Button
    Me.btnModificar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.lblPersonaOriginal = New System.Windows.Forms.Label
    Me.txtNombreCorrecto = New System.Windows.Forms.TextBox
    Me.lblDuplicado = New System.Windows.Forms.Label
    Me.txtNombreDuplicado = New System.Windows.Forms.TextBox
    Me.btnCancelarFusion = New System.Windows.Forms.Button
    Me.btnAceptarFusion = New System.Windows.Forms.Button
    Me.gbEliminarDuplicado = New System.Windows.Forms.GroupBox
    Me.btnBuscarDuplicado = New System.Windows.Forms.Button
    Me.btnBuscarCorrecto = New System.Windows.Forms.Button
    Me.errPersona = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.gbPersona.SuspendLayout()
    Me.gbBuscar.SuspendLayout()
    CType(Me.dgvPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbEliminarDuplicado.SuspendLayout()
    CType(Me.errPersona, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'gbPersona
    '
    Me.gbPersona.Controls.Add(Me.txtApellidoMaterno)
    Me.gbPersona.Controls.Add(Me.lblApellidoMaterno)
    Me.gbPersona.Controls.Add(Me.txtApellidoPaterno)
    Me.gbPersona.Controls.Add(Me.lblApellidoPat)
    Me.gbPersona.Controls.Add(Me.txtNombre)
    Me.gbPersona.Controls.Add(Me.lblNombres)
    Me.gbPersona.Controls.Add(Me.btnAceptar)
    Me.gbPersona.Controls.Add(Me.btnCancelar)
    Me.gbPersona.Enabled = False
    Me.gbPersona.Location = New System.Drawing.Point(12, 26)
    Me.gbPersona.Name = "gbPersona"
    Me.gbPersona.Size = New System.Drawing.Size(293, 205)
    Me.gbPersona.TabIndex = 0
    Me.gbPersona.TabStop = False
    Me.gbPersona.Text = "Persona"
    '
    'txtApellidoMaterno
    '
    Me.txtApellidoMaterno.Location = New System.Drawing.Point(71, 89)
    Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
    Me.txtApellidoMaterno.Size = New System.Drawing.Size(216, 20)
    Me.txtApellidoMaterno.TabIndex = 5
    '
    'lblApellidoMaterno
    '
    Me.lblApellidoMaterno.AutoSize = True
    Me.lblApellidoMaterno.Location = New System.Drawing.Point(6, 96)
    Me.lblApellidoMaterno.Name = "lblApellidoMaterno"
    Me.lblApellidoMaterno.Size = New System.Drawing.Size(65, 13)
    Me.lblApellidoMaterno.TabIndex = 4
    Me.lblApellidoMaterno.Text = "Ap. Ma&terno"
    '
    'txtApellidoPaterno
    '
    Me.txtApellidoPaterno.Location = New System.Drawing.Point(71, 61)
    Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
    Me.txtApellidoPaterno.Size = New System.Drawing.Size(216, 20)
    Me.txtApellidoPaterno.TabIndex = 3
    '
    'lblApellidoPat
    '
    Me.lblApellidoPat.AutoSize = True
    Me.lblApellidoPat.Location = New System.Drawing.Point(5, 68)
    Me.lblApellidoPat.Name = "lblApellidoPat"
    Me.lblApellidoPat.Size = New System.Drawing.Size(63, 13)
    Me.lblApellidoPat.TabIndex = 2
    Me.lblApellidoPat.Text = "Ap. &Paterno"
    '
    'txtNombre
    '
    Me.txtNombre.Location = New System.Drawing.Point(71, 35)
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Size = New System.Drawing.Size(216, 20)
    Me.txtNombre.TabIndex = 1
    '
    'lblNombres
    '
    Me.lblNombres.AutoSize = True
    Me.lblNombres.Location = New System.Drawing.Point(5, 42)
    Me.lblNombres.Name = "lblNombres"
    Me.lblNombres.Size = New System.Drawing.Size(49, 13)
    Me.lblNombres.TabIndex = 0
    Me.lblNombres.Text = "&Nombres"
    '
    'btnAceptar
    '
    Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnAceptar.BackColor = System.Drawing.Color.White
    Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAceptar.Location = New System.Drawing.Point(59, 155)
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(111, 44)
    Me.btnAceptar.TabIndex = 6
    Me.btnAceptar.Text = "&Aceptar"
    Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnAceptar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(176, 155)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(111, 44)
    Me.btnCancelar.TabIndex = 7
    Me.btnCancelar.Text = "&Cancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'gbBuscar
    '
    Me.gbBuscar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbBuscar.Controls.Add(Me.txtPersona)
    Me.gbBuscar.Controls.Add(Me.lblPersona)
    Me.gbBuscar.Controls.Add(Me.dgvPersonas)
    Me.gbBuscar.Controls.Add(Me.btnListar)
    Me.gbBuscar.Controls.Add(Me.btnEliminarDuplicado)
    Me.gbBuscar.Controls.Add(Me.btnModificar)
    Me.gbBuscar.Location = New System.Drawing.Point(325, 26)
    Me.gbBuscar.Name = "gbBuscar"
    Me.gbBuscar.Size = New System.Drawing.Size(461, 374)
    Me.gbBuscar.TabIndex = 2
    Me.gbBuscar.TabStop = False
    '
    'txtPersona
    '
    Me.txtPersona.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtPersona.Location = New System.Drawing.Point(54, 31)
    Me.txtPersona.Name = "txtPersona"
    Me.txtPersona.Size = New System.Drawing.Size(284, 20)
    Me.txtPersona.TabIndex = 1
    '
    'lblPersona
    '
    Me.lblPersona.AutoSize = True
    Me.lblPersona.Location = New System.Drawing.Point(6, 38)
    Me.lblPersona.Name = "lblPersona"
    Me.lblPersona.Size = New System.Drawing.Size(46, 13)
    Me.lblPersona.TabIndex = 0
    Me.lblPersona.Text = "&Persona"
    '
    'dgvPersonas
    '
    Me.dgvPersonas.AllowUserToAddRows = False
    Me.dgvPersonas.AllowUserToDeleteRows = False
    Me.dgvPersonas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvPersonas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNombreCompleto})
    Me.dgvPersonas.Location = New System.Drawing.Point(6, 57)
    Me.dgvPersonas.MultiSelect = False
    Me.dgvPersonas.Name = "dgvPersonas"
    Me.dgvPersonas.ReadOnly = True
    Me.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvPersonas.Size = New System.Drawing.Size(449, 261)
    Me.dgvPersonas.TabIndex = 3
    '
    'cdNombreCompleto
    '
    Me.cdNombreCompleto.DataPropertyName = "NombreCompleto"
    Me.cdNombreCompleto.HeaderText = "Persona"
    Me.cdNombreCompleto.Name = "cdNombreCompleto"
    Me.cdNombreCompleto.ReadOnly = True
    Me.cdNombreCompleto.Width = 350
    '
    'btnListar
    '
    Me.btnListar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnListar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnListar.Location = New System.Drawing.Point(344, 19)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(111, 32)
    Me.btnListar.TabIndex = 2
    Me.btnListar.Text = "&Listar"
    Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnListar.UseVisualStyleBackColor = False
    '
    'btnEliminarDuplicado
    '
    Me.btnEliminarDuplicado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnEliminarDuplicado.BackColor = System.Drawing.Color.White
    Me.btnEliminarDuplicado.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnEliminarDuplicado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEliminarDuplicado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnEliminarDuplicado.Location = New System.Drawing.Point(123, 324)
    Me.btnEliminarDuplicado.Name = "btnEliminarDuplicado"
    Me.btnEliminarDuplicado.Size = New System.Drawing.Size(111, 44)
    Me.btnEliminarDuplicado.TabIndex = 4
    Me.btnEliminarDuplicado.Text = "Eliminar duplicado"
    Me.btnEliminarDuplicado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnEliminarDuplicado.UseVisualStyleBackColor = False
    '
    'btnModificar
    '
    Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnModificar.BackColor = System.Drawing.Color.White
    Me.btnModificar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnModificar.Location = New System.Drawing.Point(6, 324)
    Me.btnModificar.Name = "btnModificar"
    Me.btnModificar.Size = New System.Drawing.Size(111, 44)
    Me.btnModificar.TabIndex = 4
    Me.btnModificar.Text = "&Modificar"
    Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnModificar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(675, 406)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(111, 44)
    Me.btnCerrar.TabIndex = 3
    Me.btnCerrar.Text = "Ce&rrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'lblPersonaOriginal
    '
    Me.lblPersonaOriginal.AutoSize = True
    Me.lblPersonaOriginal.Location = New System.Drawing.Point(9, 35)
    Me.lblPersonaOriginal.Name = "lblPersonaOriginal"
    Me.lblPersonaOriginal.Size = New System.Drawing.Size(47, 26)
    Me.lblPersonaOriginal.TabIndex = 0
    Me.lblPersonaOriginal.Text = "&Nombre " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "correcto"
    '
    'txtNombreCorrecto
    '
    Me.txtNombreCorrecto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtNombreCorrecto.Location = New System.Drawing.Point(65, 19)
    Me.txtNombreCorrecto.Multiline = True
    Me.txtNombreCorrecto.Name = "txtNombreCorrecto"
    Me.txtNombreCorrecto.ReadOnly = True
    Me.txtNombreCorrecto.Size = New System.Drawing.Size(186, 42)
    Me.txtNombreCorrecto.TabIndex = 1
    '
    'lblDuplicado
    '
    Me.lblDuplicado.AutoSize = True
    Me.lblDuplicado.Location = New System.Drawing.Point(4, 83)
    Me.lblDuplicado.Name = "lblDuplicado"
    Me.lblDuplicado.Size = New System.Drawing.Size(55, 26)
    Me.lblDuplicado.TabIndex = 3
    Me.lblDuplicado.Text = "Nombre" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "&Duplicado"
    '
    'txtNombreDuplicado
    '
    Me.txtNombreDuplicado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtNombreDuplicado.Location = New System.Drawing.Point(65, 67)
    Me.txtNombreDuplicado.Multiline = True
    Me.txtNombreDuplicado.Name = "txtNombreDuplicado"
    Me.txtNombreDuplicado.ReadOnly = True
    Me.txtNombreDuplicado.Size = New System.Drawing.Size(186, 42)
    Me.txtNombreDuplicado.TabIndex = 4
    '
    'btnCancelarFusion
    '
    Me.btnCancelarFusion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnCancelarFusion.BackColor = System.Drawing.Color.White
    Me.btnCancelarFusion.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancelarFusion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelarFusion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelarFusion.Location = New System.Drawing.Point(164, 137)
    Me.btnCancelarFusion.Name = "btnCancelarFusion"
    Me.btnCancelarFusion.Size = New System.Drawing.Size(111, 44)
    Me.btnCancelarFusion.TabIndex = 7
    Me.btnCancelarFusion.Text = "&Cancelar"
    Me.btnCancelarFusion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelarFusion.UseVisualStyleBackColor = False
    '
    'btnAceptarFusion
    '
    Me.btnAceptarFusion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnAceptarFusion.BackColor = System.Drawing.Color.White
    Me.btnAceptarFusion.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnAceptarFusion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAceptarFusion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAceptarFusion.Location = New System.Drawing.Point(38, 137)
    Me.btnAceptarFusion.Name = "btnAceptarFusion"
    Me.btnAceptarFusion.Size = New System.Drawing.Size(111, 44)
    Me.btnAceptarFusion.TabIndex = 6
    Me.btnAceptarFusion.Text = "F&usionar"
    Me.btnAceptarFusion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnAceptarFusion.UseVisualStyleBackColor = False
    '
    'gbEliminarDuplicado
    '
    Me.gbEliminarDuplicado.Controls.Add(Me.btnBuscarDuplicado)
    Me.gbEliminarDuplicado.Controls.Add(Me.btnBuscarCorrecto)
    Me.gbEliminarDuplicado.Controls.Add(Me.btnCancelarFusion)
    Me.gbEliminarDuplicado.Controls.Add(Me.txtNombreDuplicado)
    Me.gbEliminarDuplicado.Controls.Add(Me.btnAceptarFusion)
    Me.gbEliminarDuplicado.Controls.Add(Me.lblDuplicado)
    Me.gbEliminarDuplicado.Controls.Add(Me.lblPersonaOriginal)
    Me.gbEliminarDuplicado.Controls.Add(Me.txtNombreCorrecto)
    Me.gbEliminarDuplicado.Location = New System.Drawing.Point(12, 254)
    Me.gbEliminarDuplicado.Name = "gbEliminarDuplicado"
    Me.gbEliminarDuplicado.Size = New System.Drawing.Size(293, 187)
    Me.gbEliminarDuplicado.TabIndex = 1
    Me.gbEliminarDuplicado.TabStop = False
    Me.gbEliminarDuplicado.Text = "Duplicados"
    Me.gbEliminarDuplicado.Visible = False
    '
    'btnBuscarDuplicado
    '
    Me.btnBuscarDuplicado.Location = New System.Drawing.Point(257, 83)
    Me.btnBuscarDuplicado.Name = "btnBuscarDuplicado"
    Me.btnBuscarDuplicado.Size = New System.Drawing.Size(30, 26)
    Me.btnBuscarDuplicado.TabIndex = 5
    Me.btnBuscarDuplicado.Text = "..."
    Me.btnBuscarDuplicado.UseVisualStyleBackColor = True
    '
    'btnBuscarCorrecto
    '
    Me.btnBuscarCorrecto.Location = New System.Drawing.Point(257, 35)
    Me.btnBuscarCorrecto.Name = "btnBuscarCorrecto"
    Me.btnBuscarCorrecto.Size = New System.Drawing.Size(30, 26)
    Me.btnBuscarCorrecto.TabIndex = 2
    Me.btnBuscarCorrecto.Text = "..."
    Me.btnBuscarCorrecto.UseVisualStyleBackColor = True
    '
    'errPersona
    '
    Me.errPersona.ContainerControl = Me
    '
    'frmGestionarPersonas
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCerrar
    Me.ClientSize = New System.Drawing.Size(800, 462)
    Me.Controls.Add(Me.gbEliminarDuplicado)
    Me.Controls.Add(Me.gbBuscar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.gbPersona)
    Me.Name = "frmGestionarPersonas"
    Me.Text = "Gestión de personas"
    Me.gbPersona.ResumeLayout(False)
    Me.gbPersona.PerformLayout()
    Me.gbBuscar.ResumeLayout(False)
    Me.gbBuscar.PerformLayout()
    CType(Me.dgvPersonas, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbEliminarDuplicado.ResumeLayout(False)
    Me.gbEliminarDuplicado.PerformLayout()
    CType(Me.errPersona, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents gbPersona As System.Windows.Forms.GroupBox
  Friend WithEvents gbBuscar As System.Windows.Forms.GroupBox
  Friend WithEvents btnAceptar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnModificar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents txtApellidoMaterno As System.Windows.Forms.TextBox
  Friend WithEvents lblApellidoMaterno As System.Windows.Forms.Label
  Friend WithEvents txtApellidoPaterno As System.Windows.Forms.TextBox
  Friend WithEvents lblApellidoPat As System.Windows.Forms.Label
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents lblNombres As System.Windows.Forms.Label
  Friend WithEvents txtPersona As System.Windows.Forms.TextBox
  Friend WithEvents lblPersona As System.Windows.Forms.Label
  Friend WithEvents dgvPersonas As System.Windows.Forms.DataGridView
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents cdNombreCompleto As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnEliminarDuplicado As System.Windows.Forms.Button
  Friend WithEvents lblPersonaOriginal As System.Windows.Forms.Label
  Friend WithEvents txtNombreCorrecto As System.Windows.Forms.TextBox
  Friend WithEvents lblDuplicado As System.Windows.Forms.Label
  Friend WithEvents txtNombreDuplicado As System.Windows.Forms.TextBox
  Friend WithEvents btnCancelarFusion As System.Windows.Forms.Button
  Friend WithEvents btnAceptarFusion As System.Windows.Forms.Button
  Friend WithEvents gbEliminarDuplicado As System.Windows.Forms.GroupBox
  Friend WithEvents btnBuscarDuplicado As System.Windows.Forms.Button
  Friend WithEvents btnBuscarCorrecto As System.Windows.Forms.Button
  Friend WithEvents errPersona As System.Windows.Forms.ErrorProvider
End Class
