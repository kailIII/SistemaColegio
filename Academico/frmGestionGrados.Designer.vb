<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionGrados
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.errorGrado = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.cboCaracteristica = New System.Windows.Forms.ComboBox
    Me.lblCaracteristica = New System.Windows.Forms.Label
    Me.cboTipoCalif = New System.Windows.Forms.ComboBox
    Me.lblTipoCalif = New System.Windows.Forms.Label
    Me.cboNivel = New System.Windows.Forms.ComboBox
    Me.txtNombreNum = New System.Windows.Forms.TextBox
    Me.lblNivel = New System.Windows.Forms.Label
    Me.nudNumero = New System.Windows.Forms.NumericUpDown
    Me.lblNombreNum = New System.Windows.Forms.Label
    Me.lblNumero = New System.Windows.Forms.Label
    Me.gbNivel = New System.Windows.Forms.GroupBox
    Me.gbComp = New System.Windows.Forms.GroupBox
    Me.gbCalificacion = New System.Windows.Forms.GroupBox
    Me.rbLiteral = New System.Windows.Forms.RadioButton
    Me.rbNumerica = New System.Windows.Forms.RadioButton
    Me.lblCalifComp = New System.Windows.Forms.Label
    Me.gbEvaluacion = New System.Windows.Forms.GroupBox
    Me.rbPeriodo = New System.Windows.Forms.RadioButton
    Me.rbAnual = New System.Windows.Forms.RadioButton
    Me.lblEvaluacion = New System.Windows.Forms.Label
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.gbListaGrados = New System.Windows.Forms.GroupBox
    Me.dgvGrados = New System.Windows.Forms.DataGridView
    Me.cdNumero = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdGrado = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCalificacion = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdBlanco = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnModificar = New System.Windows.Forms.Button
    Me.lblMensaje = New System.Windows.Forms.Label
    CType(Me.errorGrado, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.nudNumero, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbNivel.SuspendLayout()
    Me.gbComp.SuspendLayout()
    Me.gbCalificacion.SuspendLayout()
    Me.gbEvaluacion.SuspendLayout()
    Me.gbListaGrados.SuspendLayout()
    CType(Me.dgvGrados, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(567, 514)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 5
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'errorGrado
    '
    Me.errorGrado.ContainerControl = Me
    '
    'cboCaracteristica
    '
    Me.cboCaracteristica.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboCaracteristica.FormattingEnabled = True
    Me.cboCaracteristica.Items.AddRange(New Object() {"Unidocente", "Polidocente Multigrado", "Polidocente Completo"})
    Me.cboCaracteristica.Location = New System.Drawing.Point(174, 109)
    Me.cboCaracteristica.Name = "cboCaracteristica"
    Me.cboCaracteristica.Size = New System.Drawing.Size(237, 24)
    Me.cboCaracteristica.TabIndex = 7
    '
    'lblCaracteristica
    '
    Me.lblCaracteristica.AutoSize = True
    Me.lblCaracteristica.Location = New System.Drawing.Point(78, 113)
    Me.lblCaracteristica.Name = "lblCaracteristica"
    Me.lblCaracteristica.Size = New System.Drawing.Size(79, 15)
    Me.lblCaracteristica.TabIndex = 6
    Me.lblCaracteristica.Text = "Característica"
    '
    'cboTipoCalif
    '
    Me.cboTipoCalif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoCalif.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboTipoCalif.FormattingEnabled = True
    Me.cboTipoCalif.Items.AddRange(New Object() {"Literal", "Numérica"})
    Me.cboTipoCalif.Location = New System.Drawing.Point(174, 138)
    Me.cboTipoCalif.Name = "cboTipoCalif"
    Me.cboTipoCalif.Size = New System.Drawing.Size(237, 25)
    Me.cboTipoCalif.TabIndex = 9
    '
    'lblTipoCalif
    '
    Me.lblTipoCalif.AutoSize = True
    Me.lblTipoCalif.Location = New System.Drawing.Point(59, 143)
    Me.lblTipoCalif.Name = "lblTipoCalif"
    Me.lblTipoCalif.Size = New System.Drawing.Size(97, 15)
    Me.lblTipoCalif.TabIndex = 8
    Me.lblTipoCalif.Text = "Tipo Calificación"
    '
    'cboNivel
    '
    Me.cboNivel.Anchor = System.Windows.Forms.AnchorStyles.Right
    Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNivel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Location = New System.Drawing.Point(174, 23)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(173, 25)
    Me.cboNivel.TabIndex = 1
    '
    'txtNombreNum
    '
    Me.txtNombreNum.Anchor = System.Windows.Forms.AnchorStyles.Right
    Me.txtNombreNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtNombreNum.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtNombreNum.Location = New System.Drawing.Point(174, 80)
    Me.txtNombreNum.Multiline = True
    Me.txtNombreNum.Name = "txtNombreNum"
    Me.txtNombreNum.Size = New System.Drawing.Size(173, 24)
    Me.txtNombreNum.TabIndex = 5
    '
    'lblNivel
    '
    Me.lblNivel.AutoSize = True
    Me.lblNivel.Location = New System.Drawing.Point(59, 28)
    Me.lblNivel.Name = "lblNivel"
    Me.lblNivel.Size = New System.Drawing.Size(98, 15)
    Me.lblNivel.TabIndex = 0
    Me.lblNivel.Text = "N&ivel Académico"
    '
    'nudNumero
    '
    Me.nudNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.nudNumero.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.nudNumero.Location = New System.Drawing.Point(174, 53)
    Me.nudNumero.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
    Me.nudNumero.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.nudNumero.Name = "nudNumero"
    Me.nudNumero.Size = New System.Drawing.Size(36, 22)
    Me.nudNumero.TabIndex = 3
    Me.nudNumero.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'lblNombreNum
    '
    Me.lblNombreNum.AutoSize = True
    Me.lblNombreNum.Location = New System.Drawing.Point(108, 84)
    Me.lblNombreNum.Name = "lblNombreNum"
    Me.lblNombreNum.Size = New System.Drawing.Size(49, 15)
    Me.lblNombreNum.TabIndex = 4
    Me.lblNombreNum.Text = "N&ombre"
    '
    'lblNumero
    '
    Me.lblNumero.AutoSize = True
    Me.lblNumero.Location = New System.Drawing.Point(108, 56)
    Me.lblNumero.Name = "lblNumero"
    Me.lblNumero.Size = New System.Drawing.Size(49, 15)
    Me.lblNumero.TabIndex = 2
    Me.lblNumero.Text = "Nú&mero"
    '
    'gbNivel
    '
    Me.gbNivel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbNivel.Controls.Add(Me.gbComp)
    Me.gbNivel.Controls.Add(Me.cboCaracteristica)
    Me.gbNivel.Controls.Add(Me.cboNivel)
    Me.gbNivel.Controls.Add(Me.lblNumero)
    Me.gbNivel.Controls.Add(Me.lblCaracteristica)
    Me.gbNivel.Controls.Add(Me.lblNombreNum)
    Me.gbNivel.Controls.Add(Me.nudNumero)
    Me.gbNivel.Controls.Add(Me.cboTipoCalif)
    Me.gbNivel.Controls.Add(Me.lblNivel)
    Me.gbNivel.Controls.Add(Me.txtNombreNum)
    Me.gbNivel.Controls.Add(Me.lblTipoCalif)
    Me.gbNivel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbNivel.Location = New System.Drawing.Point(63, 269)
    Me.gbNivel.Name = "gbNivel"
    Me.gbNivel.Size = New System.Drawing.Size(478, 297)
    Me.gbNivel.TabIndex = 0
    Me.gbNivel.TabStop = False
    Me.gbNivel.Text = "Grado"
    '
    'gbComp
    '
    Me.gbComp.Controls.Add(Me.gbCalificacion)
    Me.gbComp.Controls.Add(Me.gbEvaluacion)
    Me.gbComp.Location = New System.Drawing.Point(56, 169)
    Me.gbComp.Name = "gbComp"
    Me.gbComp.Size = New System.Drawing.Size(366, 111)
    Me.gbComp.TabIndex = 10
    Me.gbComp.TabStop = False
    Me.gbComp.Text = "Comportamiento"
    '
    'gbCalificacion
    '
    Me.gbCalificacion.Controls.Add(Me.rbLiteral)
    Me.gbCalificacion.Controls.Add(Me.rbNumerica)
    Me.gbCalificacion.Controls.Add(Me.lblCalifComp)
    Me.gbCalificacion.Location = New System.Drawing.Point(38, 59)
    Me.gbCalificacion.Name = "gbCalificacion"
    Me.gbCalificacion.Size = New System.Drawing.Size(291, 39)
    Me.gbCalificacion.TabIndex = 1
    Me.gbCalificacion.TabStop = False
    '
    'rbLiteral
    '
    Me.rbLiteral.AutoSize = True
    Me.rbLiteral.Checked = True
    Me.rbLiteral.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rbLiteral.Location = New System.Drawing.Point(105, 14)
    Me.rbLiteral.Name = "rbLiteral"
    Me.rbLiteral.Size = New System.Drawing.Size(61, 20)
    Me.rbLiteral.TabIndex = 1
    Me.rbLiteral.TabStop = True
    Me.rbLiteral.Text = "Literal"
    Me.rbLiteral.UseVisualStyleBackColor = True
    '
    'rbNumerica
    '
    Me.rbNumerica.AutoSize = True
    Me.rbNumerica.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rbNumerica.Location = New System.Drawing.Point(202, 14)
    Me.rbNumerica.Name = "rbNumerica"
    Me.rbNumerica.Size = New System.Drawing.Size(81, 20)
    Me.rbNumerica.TabIndex = 2
    Me.rbNumerica.Text = "Numérica"
    Me.rbNumerica.UseVisualStyleBackColor = True
    '
    'lblCalifComp
    '
    Me.lblCalifComp.AutoSize = True
    Me.lblCalifComp.Location = New System.Drawing.Point(10, 16)
    Me.lblCalifComp.Name = "lblCalifComp"
    Me.lblCalifComp.Size = New System.Drawing.Size(69, 15)
    Me.lblCalifComp.TabIndex = 0
    Me.lblCalifComp.Text = "Calificación"
    '
    'gbEvaluacion
    '
    Me.gbEvaluacion.Controls.Add(Me.rbPeriodo)
    Me.gbEvaluacion.Controls.Add(Me.rbAnual)
    Me.gbEvaluacion.Controls.Add(Me.lblEvaluacion)
    Me.gbEvaluacion.Location = New System.Drawing.Point(38, 17)
    Me.gbEvaluacion.Name = "gbEvaluacion"
    Me.gbEvaluacion.Size = New System.Drawing.Size(291, 39)
    Me.gbEvaluacion.TabIndex = 0
    Me.gbEvaluacion.TabStop = False
    '
    'rbPeriodo
    '
    Me.rbPeriodo.AutoSize = True
    Me.rbPeriodo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rbPeriodo.Location = New System.Drawing.Point(202, 15)
    Me.rbPeriodo.Name = "rbPeriodo"
    Me.rbPeriodo.Size = New System.Drawing.Size(80, 20)
    Me.rbPeriodo.TabIndex = 2
    Me.rbPeriodo.Text = "Periódica"
    Me.rbPeriodo.UseVisualStyleBackColor = True
    '
    'rbAnual
    '
    Me.rbAnual.AutoSize = True
    Me.rbAnual.Checked = True
    Me.rbAnual.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.rbAnual.Location = New System.Drawing.Point(105, 13)
    Me.rbAnual.Name = "rbAnual"
    Me.rbAnual.Size = New System.Drawing.Size(59, 20)
    Me.rbAnual.TabIndex = 1
    Me.rbAnual.TabStop = True
    Me.rbAnual.Text = "Anual"
    Me.rbAnual.UseVisualStyleBackColor = True
    '
    'lblEvaluacion
    '
    Me.lblEvaluacion.AutoSize = True
    Me.lblEvaluacion.Location = New System.Drawing.Point(6, 15)
    Me.lblEvaluacion.Name = "lblEvaluacion"
    Me.lblEvaluacion.Size = New System.Drawing.Size(66, 15)
    Me.lblEvaluacion.TabIndex = 0
    Me.lblEvaluacion.Text = "&Evaluación"
    '
    'btnCancelar
    '
    Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(567, 348)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
    Me.btnCancelar.TabIndex = 2
    Me.btnCancelar.Text = "&Deshacer"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnRegistrar
    '
    Me.btnRegistrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(567, 295)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
    Me.btnRegistrar.TabIndex = 1
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'gbListaGrados
    '
    Me.gbListaGrados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbListaGrados.Controls.Add(Me.dgvGrados)
    Me.gbListaGrados.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbListaGrados.Location = New System.Drawing.Point(63, 14)
    Me.gbListaGrados.Name = "gbListaGrados"
    Me.gbListaGrados.Size = New System.Drawing.Size(478, 241)
    Me.gbListaGrados.TabIndex = 4
    Me.gbListaGrados.TabStop = False
    Me.gbListaGrados.Text = "Lista de Grados"
    '
    'dgvGrados
    '
    Me.dgvGrados.AllowUserToAddRows = False
    Me.dgvGrados.AllowUserToDeleteRows = False
    Me.dgvGrados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvGrados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvGrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvGrados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNumero, Me.cdGrado, Me.cdCalificacion, Me.cdBlanco})
    Me.dgvGrados.Location = New System.Drawing.Point(12, 35)
    Me.dgvGrados.Name = "dgvGrados"
    Me.dgvGrados.ReadOnly = True
    Me.dgvGrados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.dgvGrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvGrados.Size = New System.Drawing.Size(454, 182)
    Me.dgvGrados.TabIndex = 0
    '
    'cdNumero
    '
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cdNumero.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdNumero.HeaderText = "Número"
    Me.cdNumero.Name = "cdNumero"
    Me.cdNumero.ReadOnly = True
    Me.cdNumero.Width = 50
    '
    'cdGrado
    '
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cdGrado.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdGrado.HeaderText = "Grado"
    Me.cdGrado.Name = "cdGrado"
    Me.cdGrado.ReadOnly = True
    Me.cdGrado.Width = 140
    '
    'cdCalificacion
    '
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cdCalificacion.DefaultCellStyle = DataGridViewCellStyle4
    Me.cdCalificacion.HeaderText = "Calificación"
    Me.cdCalificacion.Name = "cdCalificacion"
    Me.cdCalificacion.ReadOnly = True
    Me.cdCalificacion.Width = 80
    '
    'cdBlanco
    '
    Me.cdBlanco.HeaderText = "Característica"
    Me.cdBlanco.Name = "cdBlanco"
    Me.cdBlanco.ReadOnly = True
    Me.cdBlanco.Width = 140
    '
    'btnModificar
    '
    Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnModificar.BackColor = System.Drawing.Color.White
    Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnModificar.Location = New System.Drawing.Point(567, 49)
    Me.btnModificar.Name = "btnModificar"
    Me.btnModificar.Size = New System.Drawing.Size(110, 52)
    Me.btnModificar.TabIndex = 3
    Me.btnModificar.Text = "&Modificar"
    Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnModificar.UseVisualStyleBackColor = False
    '
    'lblMensaje
    '
    Me.lblMensaje.AutoSize = True
    Me.lblMensaje.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMensaje.ForeColor = System.Drawing.SystemColors.ActiveCaption
    Me.lblMensaje.Location = New System.Drawing.Point(59, 578)
    Me.lblMensaje.Name = "lblMensaje"
    Me.lblMensaje.Size = New System.Drawing.Size(416, 19)
    Me.lblMensaje.TabIndex = 7
    Me.lblMensaje.Text = "Click en Deshacer para anular la operación y volver a iniciar."
    '
    'frmGestionGrados
    '
    Me.AcceptButton = Me.btnRegistrar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(737, 606)
    Me.Controls.Add(Me.lblMensaje)
    Me.Controls.Add(Me.gbListaGrados)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.gbNivel)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.btnModificar)
    Me.Controls.Add(Me.btnCerrar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.Name = "frmGestionGrados"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de Grados"
    CType(Me.errorGrado, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.nudNumero, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbNivel.ResumeLayout(False)
    Me.gbNivel.PerformLayout()
    Me.gbComp.ResumeLayout(False)
    Me.gbCalificacion.ResumeLayout(False)
    Me.gbCalificacion.PerformLayout()
    Me.gbEvaluacion.ResumeLayout(False)
    Me.gbEvaluacion.PerformLayout()
    Me.gbListaGrados.ResumeLayout(False)
    CType(Me.dgvGrados, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents errorGrado As System.Windows.Forms.ErrorProvider
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents gbListaGrados As System.Windows.Forms.GroupBox
  Friend WithEvents dgvGrados As System.Windows.Forms.DataGridView
  Friend WithEvents btnModificar As System.Windows.Forms.Button
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents txtNombreNum As System.Windows.Forms.TextBox
  Friend WithEvents lblNivel As System.Windows.Forms.Label
  Friend WithEvents nudNumero As System.Windows.Forms.NumericUpDown
  Friend WithEvents lblNombreNum As System.Windows.Forms.Label
  Friend WithEvents lblNumero As System.Windows.Forms.Label
  Friend WithEvents gbNivel As System.Windows.Forms.GroupBox
  Friend WithEvents cboTipoCalif As System.Windows.Forms.ComboBox
  Friend WithEvents lblTipoCalif As System.Windows.Forms.Label
  Friend WithEvents lblCaracteristica As System.Windows.Forms.Label
  Friend WithEvents cboCaracteristica As System.Windows.Forms.ComboBox
  Friend WithEvents cdNumero As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdGrado As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCalificacion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdBlanco As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents lblMensaje As System.Windows.Forms.Label
  Friend WithEvents gbComp As System.Windows.Forms.GroupBox
  Friend WithEvents lblCalifComp As System.Windows.Forms.Label
  Friend WithEvents lblEvaluacion As System.Windows.Forms.Label
  Friend WithEvents rbPeriodo As System.Windows.Forms.RadioButton
  Friend WithEvents rbAnual As System.Windows.Forms.RadioButton
  Friend WithEvents rbLiteral As System.Windows.Forms.RadioButton
  Friend WithEvents rbNumerica As System.Windows.Forms.RadioButton
  Friend WithEvents gbCalificacion As System.Windows.Forms.GroupBox
  Friend WithEvents gbEvaluacion As System.Windows.Forms.GroupBox
End Class
