<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionDocenteArea
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
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.btnEditar = New System.Windows.Forms.Button()
    Me.btncancelar = New System.Windows.Forms.Button()
    Me.btnRegistrar = New System.Windows.Forms.Button()
    Me.dgvRespInvestigacion = New System.Windows.Forms.DataGridView()
    Me.btnBuscarDocente = New System.Windows.Forms.Button()
    Me.txtDocente = New System.Windows.Forms.TextBox()
    Me.lblDocente = New System.Windows.Forms.Label()
    Me.lblArea = New System.Windows.Forms.Label()
    Me.lblSeccion = New System.Windows.Forms.Label()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.txtSeccion = New System.Windows.Forms.TextBox()
    Me.cboSeccion = New System.Windows.Forms.ComboBox()
    Me.cboArea = New System.Windows.Forms.ComboBox()
    Me.cboNivel = New System.Windows.Forms.ComboBox()
    Me.lblNivel = New System.Windows.Forms.Label()
    Me.btnAnular = New System.Windows.Forms.Button()
    Me.gbRespInvestigacion = New System.Windows.Forms.GroupBox()
    Me.gbListaInv = New System.Windows.Forms.GroupBox()
    Me.btnListar = New System.Windows.Forms.Button()
    Me.btnNuevo = New System.Windows.Forms.Button()
    Me.cdDocente = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdArea = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdSeccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdNombreNivel = New System.Windows.Forms.DataGridViewTextBoxColumn()
    CType(Me.dgvRespInvestigacion, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbRespInvestigacion.SuspendLayout()
    Me.gbListaInv.SuspendLayout()
    Me.SuspendLayout()
    '
    'btnEditar
    '
    Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnEditar.BackColor = System.Drawing.Color.White
    Me.btnEditar.Enabled = False
    Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnEditar.Location = New System.Drawing.Point(158, 330)
    Me.btnEditar.Name = "btnEditar"
    Me.btnEditar.Size = New System.Drawing.Size(108, 52)
    Me.btnEditar.TabIndex = 3
    Me.btnEditar.Text = "&Editar"
    Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnEditar.UseVisualStyleBackColor = False
    '
    'btncancelar
    '
    Me.btncancelar.BackColor = System.Drawing.Color.White
    Me.btncancelar.Enabled = False
    Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btncancelar.Location = New System.Drawing.Point(221, 236)
    Me.btncancelar.Name = "btncancelar"
    Me.btncancelar.Size = New System.Drawing.Size(110, 52)
    Me.btncancelar.TabIndex = 11
    Me.btncancelar.Text = "&Cancelar"
    Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btncancelar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Enabled = False
    Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(86, 236)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
    Me.btnRegistrar.TabIndex = 10
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'dgvRespInvestigacion
    '
    Me.dgvRespInvestigacion.AllowUserToAddRows = False
    Me.dgvRespInvestigacion.AllowUserToDeleteRows = False
    Me.dgvRespInvestigacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvRespInvestigacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvRespInvestigacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNombreNivel, Me.cdSeccion, Me.cdArea, Me.cdDocente})
    Me.dgvRespInvestigacion.Location = New System.Drawing.Point(15, 80)
    Me.dgvRespInvestigacion.MultiSelect = False
    Me.dgvRespInvestigacion.Name = "dgvRespInvestigacion"
    Me.dgvRespInvestigacion.ReadOnly = True
    Me.dgvRespInvestigacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvRespInvestigacion.Size = New System.Drawing.Size(488, 235)
    Me.dgvRespInvestigacion.TabIndex = 1
    '
    'btnBuscarDocente
    '
    Me.btnBuscarDocente.BackColor = System.Drawing.Color.White
    Me.btnBuscarDocente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
    Me.btnBuscarDocente.Enabled = False
    Me.btnBuscarDocente.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnBuscarDocente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscarDocente.Location = New System.Drawing.Point(314, 142)
    Me.btnBuscarDocente.Name = "btnBuscarDocente"
    Me.btnBuscarDocente.Size = New System.Drawing.Size(110, 32)
    Me.btnBuscarDocente.TabIndex = 9
    Me.btnBuscarDocente.Text = "Buscar &Docente"
    Me.btnBuscarDocente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscarDocente.UseVisualStyleBackColor = False
    '
    'txtDocente
    '
    Me.txtDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtDocente.Enabled = False
    Me.txtDocente.Font = New System.Drawing.Font("Times New Roman", 9.75!)
    Me.txtDocente.Location = New System.Drawing.Point(69, 149)
    Me.txtDocente.Name = "txtDocente"
    Me.txtDocente.ReadOnly = True
    Me.txtDocente.Size = New System.Drawing.Size(232, 22)
    Me.txtDocente.TabIndex = 8
    '
    'lblDocente
    '
    Me.lblDocente.AutoSize = True
    Me.lblDocente.Enabled = False
    Me.lblDocente.Location = New System.Drawing.Point(11, 156)
    Me.lblDocente.Name = "lblDocente"
    Me.lblDocente.Size = New System.Drawing.Size(48, 13)
    Me.lblDocente.TabIndex = 7
    Me.lblDocente.Text = "Docente"
    '
    'lblArea
    '
    Me.lblArea.AutoSize = True
    Me.lblArea.Enabled = False
    Me.lblArea.Location = New System.Drawing.Point(11, 114)
    Me.lblArea.Name = "lblArea"
    Me.lblArea.Size = New System.Drawing.Size(29, 13)
    Me.lblArea.TabIndex = 5
    Me.lblArea.Text = "Área"
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Enabled = False
    Me.lblSeccion.Location = New System.Drawing.Point(11, 73)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(46, 13)
    Me.lblSeccion.TabIndex = 2
    Me.lblSeccion.Text = "Sección"
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(897, 434)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 2
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'txtSeccion
    '
    Me.txtSeccion.Enabled = False
    Me.txtSeccion.Location = New System.Drawing.Point(69, 66)
    Me.txtSeccion.Name = "txtSeccion"
    Me.txtSeccion.Size = New System.Drawing.Size(147, 20)
    Me.txtSeccion.TabIndex = 4
    '
    'cboSeccion
    '
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Enabled = False
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Items.AddRange(New Object() {"Faltas", "Faltas justificadas", "Tardanzas", "Tardanzas justificadas"})
    Me.cboSeccion.Location = New System.Drawing.Point(69, 65)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(147, 21)
    Me.cboSeccion.TabIndex = 3
    '
    'cboArea
    '
    Me.cboArea.Enabled = False
    Me.cboArea.FormattingEnabled = True
    Me.cboArea.Location = New System.Drawing.Point(69, 106)
    Me.cboArea.Name = "cboArea"
    Me.cboArea.Size = New System.Drawing.Size(196, 21)
    Me.cboArea.TabIndex = 6
    '
    'cboNivel
    '
    Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNivel.Enabled = False
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Items.AddRange(New Object() {"Faltas", "Faltas justificadas", "Tardanzas", "Tardanzas justificadas"})
    Me.cboNivel.Location = New System.Drawing.Point(69, 24)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(147, 21)
    Me.cboNivel.TabIndex = 1
    '
    'lblNivel
    '
    Me.lblNivel.AutoSize = True
    Me.lblNivel.Enabled = False
    Me.lblNivel.Location = New System.Drawing.Point(11, 32)
    Me.lblNivel.Name = "lblNivel"
    Me.lblNivel.Size = New System.Drawing.Size(31, 13)
    Me.lblNivel.TabIndex = 0
    Me.lblNivel.Text = "Nivel"
    '
    'btnAnular
    '
    Me.btnAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnAnular.BackColor = System.Drawing.Color.White
    Me.btnAnular.Enabled = False
    Me.btnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAnular.Location = New System.Drawing.Point(283, 330)
    Me.btnAnular.Name = "btnAnular"
    Me.btnAnular.Size = New System.Drawing.Size(110, 52)
    Me.btnAnular.TabIndex = 3
    Me.btnAnular.Text = "&Anular"
    Me.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnAnular.UseVisualStyleBackColor = False
    '
    'gbRespInvestigacion
    '
    Me.gbRespInvestigacion.Controls.Add(Me.txtDocente)
    Me.gbRespInvestigacion.Controls.Add(Me.lblSeccion)
    Me.gbRespInvestigacion.Controls.Add(Me.cboNivel)
    Me.gbRespInvestigacion.Controls.Add(Me.lblArea)
    Me.gbRespInvestigacion.Controls.Add(Me.btncancelar)
    Me.gbRespInvestigacion.Controls.Add(Me.lblNivel)
    Me.gbRespInvestigacion.Controls.Add(Me.btnRegistrar)
    Me.gbRespInvestigacion.Controls.Add(Me.cboArea)
    Me.gbRespInvestigacion.Controls.Add(Me.cboSeccion)
    Me.gbRespInvestigacion.Controls.Add(Me.btnBuscarDocente)
    Me.gbRespInvestigacion.Controls.Add(Me.lblDocente)
    Me.gbRespInvestigacion.Controls.Add(Me.txtSeccion)
    Me.gbRespInvestigacion.Enabled = False
    Me.gbRespInvestigacion.Location = New System.Drawing.Point(27, 29)
    Me.gbRespInvestigacion.Name = "gbRespInvestigacion"
    Me.gbRespInvestigacion.Size = New System.Drawing.Size(437, 330)
    Me.gbRespInvestigacion.TabIndex = 0
    Me.gbRespInvestigacion.TabStop = False
    '
    'gbListaInv
    '
    Me.gbListaInv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbListaInv.Controls.Add(Me.btnNuevo)
    Me.gbListaInv.Controls.Add(Me.btnListar)
    Me.gbListaInv.Controls.Add(Me.dgvRespInvestigacion)
    Me.gbListaInv.Controls.Add(Me.btnAnular)
    Me.gbListaInv.Controls.Add(Me.btnEditar)
    Me.gbListaInv.Location = New System.Drawing.Point(488, 30)
    Me.gbListaInv.Name = "gbListaInv"
    Me.gbListaInv.Size = New System.Drawing.Size(518, 397)
    Me.gbListaInv.TabIndex = 1
    Me.gbListaInv.TabStop = False
    '
    'btnListar
    '
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
    Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnListar.Location = New System.Drawing.Point(15, 19)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(110, 52)
    Me.btnListar.TabIndex = 0
    Me.btnListar.Text = "&Listar"
    Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnListar.UseVisualStyleBackColor = False
    '
    'btnNuevo
    '
    Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnNuevo.BackColor = System.Drawing.Color.White
    Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnNuevo.Location = New System.Drawing.Point(27, 330)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(108, 52)
    Me.btnNuevo.TabIndex = 2
    Me.btnNuevo.Text = "&Nuevo"
    Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnNuevo.UseVisualStyleBackColor = False
    '
    'cdDocente
    '
    Me.cdDocente.DataPropertyName = "DocenteNivel"
    DataGridViewCellStyle2.Format = "G"
    DataGridViewCellStyle2.NullValue = Nothing
    Me.cdDocente.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdDocente.HeaderText = "Docente"
    Me.cdDocente.Name = "cdDocente"
    Me.cdDocente.ReadOnly = True
    Me.cdDocente.Width = 330
    '
    'cdArea
    '
    Me.cdArea.DataPropertyName = "AreaNivel"
    Me.cdArea.HeaderText = "Área"
    Me.cdArea.Name = "cdArea"
    Me.cdArea.ReadOnly = True
    Me.cdArea.Width = 220
    '
    'cdSeccion
    '
    Me.cdSeccion.DataPropertyName = "SeccionNivel"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.cdSeccion.DefaultCellStyle = DataGridViewCellStyle1
    Me.cdSeccion.HeaderText = "Sección"
    Me.cdSeccion.Name = "cdSeccion"
    Me.cdSeccion.ReadOnly = True
    Me.cdSeccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    Me.cdSeccion.Width = 60
    '
    'cdNombreNivel
    '
    Me.cdNombreNivel.DataPropertyName = "nombreNivel"
    Me.cdNombreNivel.HeaderText = "Nivel"
    Me.cdNombreNivel.Name = "cdNombreNivel"
    Me.cdNombreNivel.ReadOnly = True
    Me.cdNombreNivel.Width = 85
    '
    'frmGestionDocenteArea
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1027, 496)
    Me.Controls.Add(Me.gbListaInv)
    Me.Controls.Add(Me.gbRespInvestigacion)
    Me.Controls.Add(Me.btnCerrar)
    Me.MinimizeBox = False
    Me.Name = "frmGestionDocenteArea"
    Me.Text = "Asignar Docente a Área de Investigación"
    CType(Me.dgvRespInvestigacion, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbRespInvestigacion.ResumeLayout(False)
    Me.gbRespInvestigacion.PerformLayout()
    Me.gbListaInv.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents dgvRespInvestigacion As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscarDocente As System.Windows.Forms.Button
    Friend WithEvents txtDocente As System.Windows.Forms.TextBox
    Friend WithEvents lblDocente As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents txtSeccion As System.Windows.Forms.TextBox
    Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents cboArea As System.Windows.Forms.ComboBox
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents lblNivel As System.Windows.Forms.Label
  Friend WithEvents btnAnular As System.Windows.Forms.Button
  Friend WithEvents gbRespInvestigacion As System.Windows.Forms.GroupBox
  Friend WithEvents gbListaInv As System.Windows.Forms.GroupBox
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents cdNombreNivel As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdSeccion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdArea As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDocente As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
