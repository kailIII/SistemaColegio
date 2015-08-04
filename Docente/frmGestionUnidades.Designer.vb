<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionUnidades
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.txtAnio = New System.Windows.Forms.TextBox
    Me.lblAnio = New System.Windows.Forms.Label
    Me.gbListaUnid = New System.Windows.Forms.GroupBox
    Me.dgUnidades = New System.Windows.Forms.DataGridView
    Me.cdNumero = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdVigente = New System.Windows.Forms.DataGridViewCheckBoxColumn
    Me.gbUnidades = New System.Windows.Forms.GroupBox
    Me.btnAgregar = New System.Windows.Forms.Button
    Me.gbInterno = New System.Windows.Forms.GroupBox
    Me.nuUnidades = New System.Windows.Forms.NumericUpDown
    Me.cboCurso = New System.Windows.Forms.ComboBox
    Me.lblUnidades = New System.Windows.Forms.Label
    Me.lblCurso = New System.Windows.Forms.Label
    Me.btnGenerar = New System.Windows.Forms.Button
    Me.chkRegistrar = New System.Windows.Forms.CheckBox
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnAceptar = New System.Windows.Forms.Button
    Me.gbAnioNivel = New System.Windows.Forms.GroupBox
    Me.lblMensaje = New System.Windows.Forms.Label
    Me.gbListaUnid.SuspendLayout()
    CType(Me.dgUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbUnidades.SuspendLayout()
    Me.gbInterno.SuspendLayout()
    CType(Me.nuUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbAnioNivel.SuspendLayout()
    Me.SuspendLayout()
    '
    'txtAnio
    '
    Me.txtAnio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAnio.Location = New System.Drawing.Point(79, 19)
    Me.txtAnio.Multiline = True
    Me.txtAnio.Name = "txtAnio"
    Me.txtAnio.ReadOnly = True
    Me.txtAnio.Size = New System.Drawing.Size(191, 24)
    Me.txtAnio.TabIndex = 1
    Me.txtAnio.TabStop = False
    Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAnio.Location = New System.Drawing.Point(42, 23)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(31, 15)
    Me.lblAnio.TabIndex = 0
    Me.lblAnio.Text = "Año"
    '
    'gbListaUnid
    '
    Me.gbListaUnid.Controls.Add(Me.dgUnidades)
    Me.gbListaUnid.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbListaUnid.Location = New System.Drawing.Point(31, 245)
    Me.gbListaUnid.Name = "gbListaUnid"
    Me.gbListaUnid.Size = New System.Drawing.Size(566, 247)
    Me.gbListaUnid.TabIndex = 2
    Me.gbListaUnid.TabStop = False
    Me.gbListaUnid.Text = "&Lista de unidades"
    '
    'dgUnidades
    '
    Me.dgUnidades.AllowUserToAddRows = False
    Me.dgUnidades.AllowUserToDeleteRows = False
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgUnidades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgUnidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNumero, Me.cdUnidad, Me.cdVigente})
    Me.dgUnidades.Location = New System.Drawing.Point(14, 21)
    Me.dgUnidades.MultiSelect = False
    Me.dgUnidades.Name = "dgUnidades"
    Me.dgUnidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgUnidades.Size = New System.Drawing.Size(539, 215)
    Me.dgUnidades.TabIndex = 0
    '
    'cdNumero
    '
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle2.NullValue = Nothing
    Me.cdNumero.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdNumero.HeaderText = ""
    Me.cdNumero.Name = "cdNumero"
    Me.cdNumero.ReadOnly = True
    Me.cdNumero.Width = 30
    '
    'cdUnidad
    '
    Me.cdUnidad.HeaderText = "Unidad"
    Me.cdUnidad.Name = "cdUnidad"
    Me.cdUnidad.Width = 250
    '
    'cdVigente
    '
    Me.cdVigente.HeaderText = "Vigente"
    Me.cdVigente.Name = "cdVigente"
    Me.cdVigente.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.cdVigente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.cdVigente.Width = 60
    '
    'gbUnidades
    '
    Me.gbUnidades.Controls.Add(Me.btnAgregar)
    Me.gbUnidades.Controls.Add(Me.gbInterno)
    Me.gbUnidades.Controls.Add(Me.btnGenerar)
    Me.gbUnidades.Controls.Add(Me.chkRegistrar)
    Me.gbUnidades.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbUnidades.Location = New System.Drawing.Point(31, 86)
    Me.gbUnidades.Name = "gbUnidades"
    Me.gbUnidades.Size = New System.Drawing.Size(566, 139)
    Me.gbUnidades.TabIndex = 1
    Me.gbUnidades.TabStop = False
    Me.gbUnidades.Text = "Curso"
    '
    'btnAgregar
    '
    Me.btnAgregar.Location = New System.Drawing.Point(445, 103)
    Me.btnAgregar.Name = "btnAgregar"
    Me.btnAgregar.Size = New System.Drawing.Size(99, 23)
    Me.btnAgregar.TabIndex = 9
    Me.btnAgregar.Text = "A&gregar Uni."
    Me.btnAgregar.UseVisualStyleBackColor = True
    '
    'gbInterno
    '
    Me.gbInterno.Controls.Add(Me.nuUnidades)
    Me.gbInterno.Controls.Add(Me.cboCurso)
    Me.gbInterno.Controls.Add(Me.lblUnidades)
    Me.gbInterno.Controls.Add(Me.lblCurso)
    Me.gbInterno.Location = New System.Drawing.Point(22, 21)
    Me.gbInterno.Name = "gbInterno"
    Me.gbInterno.Size = New System.Drawing.Size(522, 76)
    Me.gbInterno.TabIndex = 0
    Me.gbInterno.TabStop = False
    Me.gbInterno.Text = "Nivel - Grado - Sección - Curso"
    '
    'nuUnidades
    '
    Me.nuUnidades.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.nuUnidades.Location = New System.Drawing.Point(99, 48)
    Me.nuUnidades.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
    Me.nuUnidades.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.nuUnidades.Name = "nuUnidades"
    Me.nuUnidades.Size = New System.Drawing.Size(47, 22)
    Me.nuUnidades.TabIndex = 3
    Me.nuUnidades.Value = New Decimal(New Integer() {2, 0, 0, 0})
    '
    'cboCurso
    '
    Me.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCurso.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboCurso.FormattingEnabled = True
    Me.cboCurso.Location = New System.Drawing.Point(99, 19)
    Me.cboCurso.Name = "cboCurso"
    Me.cboCurso.Size = New System.Drawing.Size(396, 24)
    Me.cboCurso.TabIndex = 1
    '
    'lblUnidades
    '
    Me.lblUnidades.AutoSize = True
    Me.lblUnidades.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblUnidades.Location = New System.Drawing.Point(41, 51)
    Me.lblUnidades.Name = "lblUnidades"
    Me.lblUnidades.Size = New System.Drawing.Size(58, 15)
    Me.lblUnidades.TabIndex = 2
    Me.lblUnidades.Text = "&Unidades"
    '
    'lblCurso
    '
    Me.lblCurso.AutoSize = True
    Me.lblCurso.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCurso.Location = New System.Drawing.Point(28, 23)
    Me.lblCurso.Name = "lblCurso"
    Me.lblCurso.Size = New System.Drawing.Size(71, 15)
    Me.lblCurso.TabIndex = 0
    Me.lblCurso.Text = "&Descripción"
    '
    'btnGenerar
    '
    Me.btnGenerar.Location = New System.Drawing.Point(445, 104)
    Me.btnGenerar.Name = "btnGenerar"
    Me.btnGenerar.Size = New System.Drawing.Size(99, 23)
    Me.btnGenerar.TabIndex = 2
    Me.btnGenerar.Text = "&Generar"
    Me.btnGenerar.UseVisualStyleBackColor = True
    '
    'chkRegistrar
    '
    Me.chkRegistrar.AutoSize = True
    Me.chkRegistrar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.chkRegistrar.Location = New System.Drawing.Point(22, 107)
    Me.chkRegistrar.Name = "chkRegistrar"
    Me.chkRegistrar.Size = New System.Drawing.Size(332, 20)
    Me.chkRegistrar.TabIndex = 1
    Me.chkRegistrar.Text = "Registrar para todas las secciones del mismo grado "
    Me.chkRegistrar.UseVisualStyleBackColor = True
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(628, 442)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 50)
    Me.btnCerrar.TabIndex = 5
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(628, 311)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 50)
    Me.btnCancelar.TabIndex = 4
    Me.btnCancelar.Text = "C&ancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnAceptar
    '
    Me.btnAceptar.BackColor = System.Drawing.Color.White
    Me.btnAceptar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAceptar.Location = New System.Drawing.Point(628, 254)
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(110, 50)
    Me.btnAceptar.TabIndex = 3
    Me.btnAceptar.Text = "&Registrar"
    Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnAceptar.UseVisualStyleBackColor = False
    '
    'gbAnioNivel
    '
    Me.gbAnioNivel.Controls.Add(Me.txtAnio)
    Me.gbAnioNivel.Controls.Add(Me.lblAnio)
    Me.gbAnioNivel.Location = New System.Drawing.Point(31, 13)
    Me.gbAnioNivel.Name = "gbAnioNivel"
    Me.gbAnioNivel.Size = New System.Drawing.Size(312, 56)
    Me.gbAnioNivel.TabIndex = 0
    Me.gbAnioNivel.TabStop = False
    '
    'lblMensaje
    '
    Me.lblMensaje.AutoSize = True
    Me.lblMensaje.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMensaje.ForeColor = System.Drawing.SystemColors.ActiveCaption
    Me.lblMensaje.Location = New System.Drawing.Point(27, 502)
    Me.lblMensaje.Name = "lblMensaje"
    Me.lblMensaje.Size = New System.Drawing.Size(412, 19)
    Me.lblMensaje.TabIndex = 7
    Me.lblMensaje.Text = "Click en Cancelar para anular la operación y volver a iniciar."
    '
    'frmGestionUnidades
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(750, 531)
    Me.Controls.Add(Me.lblMensaje)
    Me.Controls.Add(Me.gbAnioNivel)
    Me.Controls.Add(Me.gbListaUnid)
    Me.Controls.Add(Me.gbUnidades)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnAceptar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmGestionUnidades"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestionar de unidades"
    Me.gbListaUnid.ResumeLayout(False)
    CType(Me.dgUnidades, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbUnidades.ResumeLayout(False)
    Me.gbUnidades.PerformLayout()
    Me.gbInterno.ResumeLayout(False)
    Me.gbInterno.PerformLayout()
    CType(Me.nuUnidades, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbAnioNivel.ResumeLayout(False)
    Me.gbAnioNivel.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents txtAnio As System.Windows.Forms.TextBox
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents gbListaUnid As System.Windows.Forms.GroupBox
  Friend WithEvents dgUnidades As System.Windows.Forms.DataGridView
  Friend WithEvents gbUnidades As System.Windows.Forms.GroupBox
  Friend WithEvents gbInterno As System.Windows.Forms.GroupBox
  Friend WithEvents nuUnidades As System.Windows.Forms.NumericUpDown
  Friend WithEvents cboCurso As System.Windows.Forms.ComboBox
  Friend WithEvents lblUnidades As System.Windows.Forms.Label
  Friend WithEvents lblCurso As System.Windows.Forms.Label
  Friend WithEvents btnGenerar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnAceptar As System.Windows.Forms.Button
  Friend WithEvents chkRegistrar As System.Windows.Forms.CheckBox
  Friend WithEvents gbAnioNivel As System.Windows.Forms.GroupBox
  Friend WithEvents lblMensaje As System.Windows.Forms.Label
  Friend WithEvents cdNumero As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdVigente As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents btnAgregar As System.Windows.Forms.Button
End Class
