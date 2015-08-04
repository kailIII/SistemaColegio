<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionProgramacionPago
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
    Me.dgvServicio = New System.Windows.Forms.DataGridView
    Me.colanio = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdAplica = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.colNivel = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.colDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.colMonto = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.colEntidad = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.colServicio = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.lbDescripcion = New System.Windows.Forms.Label
    Me.lbTipo = New System.Windows.Forms.Label
    Me.lbMonto = New System.Windows.Forms.Label
    Me.txtDescripcion = New System.Windows.Forms.TextBox
    Me.txtMonto = New System.Windows.Forms.TextBox
    Me.dtFecha = New System.Windows.Forms.DateTimePicker
    Me.cbAnio = New System.Windows.Forms.ComboBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.gbServicio = New System.Windows.Forms.GroupBox
    Me.cboAplica = New System.Windows.Forms.ComboBox
    Me.lblAplica = New System.Windows.Forms.Label
    Me.cbEntidad = New System.Windows.Forms.ComboBox
    Me.lblEntidad = New System.Windows.Forms.Label
    Me.btnEliminar = New System.Windows.Forms.Button
    Me.cboNivel = New System.Windows.Forms.ComboBox
    Me.cbServicio = New System.Windows.Forms.ComboBox
    Me.lblNivel = New System.Windows.Forms.Label
    Me.btnAgregar = New System.Windows.Forms.Button
    Me.Label3 = New System.Windows.Forms.Label
    Me.btnAceptar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.errValida = New System.Windows.Forms.ErrorProvider(Me.components)
    CType(Me.dgvServicio, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbServicio.SuspendLayout()
    CType(Me.errValida, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'dgvServicio
    '
    Me.dgvServicio.AllowUserToAddRows = False
    Me.dgvServicio.AllowUserToDeleteRows = False
    Me.dgvServicio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colanio, Me.cdAplica, Me.colNivel, Me.colDescripcion, Me.colMonto, Me.colEntidad, Me.colFecha, Me.colServicio})
    Me.dgvServicio.Location = New System.Drawing.Point(16, 263)
    Me.dgvServicio.Name = "dgvServicio"
    Me.dgvServicio.ReadOnly = True
    Me.dgvServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvServicio.Size = New System.Drawing.Size(656, 205)
    Me.dgvServicio.TabIndex = 18
    Me.dgvServicio.TabStop = False
    '
    'colanio
    '
    Me.colanio.DataPropertyName = "leerAnio"
    Me.colanio.HeaderText = "Año Lectivo"
    Me.colanio.Name = "colanio"
    Me.colanio.ReadOnly = True
    Me.colanio.Width = 90
    '
    'cdAplica
    '
    Me.cdAplica.DataPropertyName = "DescripcionAplica"
    Me.cdAplica.HeaderText = "Aplicable a"
    Me.cdAplica.Name = "cdAplica"
    Me.cdAplica.ReadOnly = True
    '
    'colNivel
    '
    Me.colNivel.DataPropertyName = "leerNivel"
    Me.colNivel.HeaderText = "Nivel"
    Me.colNivel.Name = "colNivel"
    Me.colNivel.ReadOnly = True
    Me.colNivel.Width = 80
    '
    'colDescripcion
    '
    Me.colDescripcion.DataPropertyName = "Descripcion"
    Me.colDescripcion.HeaderText = "Descripcion"
    Me.colDescripcion.Name = "colDescripcion"
    Me.colDescripcion.ReadOnly = True
    Me.colDescripcion.Width = 150
    '
    'colMonto
    '
    Me.colMonto.DataPropertyName = "Monto"
    Me.colMonto.HeaderText = "Monto"
    Me.colMonto.Name = "colMonto"
    Me.colMonto.ReadOnly = True
    Me.colMonto.Width = 80
    '
    'colEntidad
    '
    Me.colEntidad.DataPropertyName = "mostrarEntidad"
    Me.colEntidad.HeaderText = "Entidad"
    Me.colEntidad.Name = "colEntidad"
    Me.colEntidad.ReadOnly = True
    '
    'colFecha
    '
    Me.colFecha.DataPropertyName = "Vencimiento"
    Me.colFecha.HeaderText = "Fecha Vcto"
    Me.colFecha.Name = "colFecha"
    Me.colFecha.ReadOnly = True
    '
    'colServicio
    '
    Me.colServicio.DataPropertyName = "leerServicio"
    Me.colServicio.HeaderText = "Servicio"
    Me.colServicio.Name = "colServicio"
    Me.colServicio.ReadOnly = True
    Me.colServicio.Width = 90
    '
    'lbDescripcion
    '
    Me.lbDescripcion.AutoSize = True
    Me.lbDescripcion.Location = New System.Drawing.Point(42, 135)
    Me.lbDescripcion.Name = "lbDescripcion"
    Me.lbDescripcion.Size = New System.Drawing.Size(63, 13)
    Me.lbDescripcion.TabIndex = 10
    Me.lbDescripcion.Text = "Descripción"
    '
    'lbTipo
    '
    Me.lbTipo.AutoSize = True
    Me.lbTipo.Location = New System.Drawing.Point(42, 27)
    Me.lbTipo.Name = "lbTipo"
    Me.lbTipo.Size = New System.Drawing.Size(64, 13)
    Me.lbTipo.TabIndex = 0
    Me.lbTipo.Text = "Año Lectivo"
    '
    'lbMonto
    '
    Me.lbMonto.AutoSize = True
    Me.lbMonto.Location = New System.Drawing.Point(260, 172)
    Me.lbMonto.Name = "lbMonto"
    Me.lbMonto.Size = New System.Drawing.Size(37, 13)
    Me.lbMonto.TabIndex = 14
    Me.lbMonto.Text = "Monto"
    '
    'txtDescripcion
    '
    Me.txtDescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.txtDescripcion.Location = New System.Drawing.Point(117, 128)
    Me.txtDescripcion.Name = "txtDescripcion"
    Me.txtDescripcion.Size = New System.Drawing.Size(548, 20)
    Me.txtDescripcion.TabIndex = 11
    '
    'txtMonto
    '
    Me.txtMonto.Location = New System.Drawing.Point(308, 165)
    Me.txtMonto.Name = "txtMonto"
    Me.txtMonto.ReadOnly = True
    Me.txtMonto.Size = New System.Drawing.Size(94, 20)
    Me.txtMonto.TabIndex = 15
    Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'dtFecha
    '
    Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtFecha.Location = New System.Drawing.Point(117, 166)
    Me.dtFecha.Name = "dtFecha"
    Me.dtFecha.Size = New System.Drawing.Size(100, 20)
    Me.dtFecha.TabIndex = 13
    '
    'cbAnio
    '
    Me.cbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbAnio.FormattingEnabled = True
    Me.cbAnio.Location = New System.Drawing.Point(117, 19)
    Me.cbAnio.Name = "cbAnio"
    Me.cbAnio.Size = New System.Drawing.Size(148, 21)
    Me.cbAnio.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(13, 172)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(98, 13)
    Me.Label1.TabIndex = 12
    Me.Label1.Text = "Fecha Vencimiento"
    '
    'gbServicio
    '
    Me.gbServicio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbServicio.Controls.Add(Me.cboAplica)
    Me.gbServicio.Controls.Add(Me.lblAplica)
    Me.gbServicio.Controls.Add(Me.cbEntidad)
    Me.gbServicio.Controls.Add(Me.lblEntidad)
    Me.gbServicio.Controls.Add(Me.btnEliminar)
    Me.gbServicio.Controls.Add(Me.cboNivel)
    Me.gbServicio.Controls.Add(Me.cbServicio)
    Me.gbServicio.Controls.Add(Me.lblNivel)
    Me.gbServicio.Controls.Add(Me.btnAgregar)
    Me.gbServicio.Controls.Add(Me.Label3)
    Me.gbServicio.Controls.Add(Me.Label1)
    Me.gbServicio.Controls.Add(Me.dgvServicio)
    Me.gbServicio.Controls.Add(Me.cbAnio)
    Me.gbServicio.Controls.Add(Me.dtFecha)
    Me.gbServicio.Controls.Add(Me.txtMonto)
    Me.gbServicio.Controls.Add(Me.txtDescripcion)
    Me.gbServicio.Controls.Add(Me.lbMonto)
    Me.gbServicio.Controls.Add(Me.lbTipo)
    Me.gbServicio.Controls.Add(Me.lbDescripcion)
    Me.gbServicio.Location = New System.Drawing.Point(12, 12)
    Me.gbServicio.Name = "gbServicio"
    Me.gbServicio.Size = New System.Drawing.Size(678, 483)
    Me.gbServicio.TabIndex = 0
    Me.gbServicio.TabStop = False
    Me.gbServicio.Text = "Programacion Pago"
    '
    'cboAplica
    '
    Me.cboAplica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAplica.FormattingEnabled = True
    Me.cboAplica.Items.AddRange(New Object() {"TODOS", "NUEVOS", "ANTIGUOS", "HIJO DE FAMILIA"})
    Me.cboAplica.Location = New System.Drawing.Point(117, 56)
    Me.cboAplica.Name = "cboAplica"
    Me.cboAplica.Size = New System.Drawing.Size(148, 21)
    Me.cboAplica.TabIndex = 5
    '
    'lblAplica
    '
    Me.lblAplica.AutoSize = True
    Me.lblAplica.Location = New System.Drawing.Point(63, 64)
    Me.lblAplica.Name = "lblAplica"
    Me.lblAplica.Size = New System.Drawing.Size(45, 13)
    Me.lblAplica.TabIndex = 4
    Me.lblAplica.Text = "A&plica a"
    '
    'cbEntidad
    '
    Me.cbEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbEntidad.FormattingEnabled = True
    Me.cbEntidad.Items.AddRange(New Object() {"INSTITUCION", "COPAFA"})
    Me.cbEntidad.Location = New System.Drawing.Point(359, 19)
    Me.cbEntidad.Name = "cbEntidad"
    Me.cbEntidad.Size = New System.Drawing.Size(148, 21)
    Me.cbEntidad.TabIndex = 3
    '
    'lblEntidad
    '
    Me.lblEntidad.AutoSize = True
    Me.lblEntidad.Location = New System.Drawing.Point(305, 27)
    Me.lblEntidad.Name = "lblEntidad"
    Me.lblEntidad.Size = New System.Drawing.Size(43, 13)
    Me.lblEntidad.TabIndex = 2
    Me.lblEntidad.Text = "Entidad"
    '
    'btnEliminar
    '
    Me.btnEliminar.BackColor = System.Drawing.Color.White
    Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnEliminar.Location = New System.Drawing.Point(554, 202)
    Me.btnEliminar.Name = "btnEliminar"
    Me.btnEliminar.Size = New System.Drawing.Size(115, 55)
    Me.btnEliminar.TabIndex = 17
    Me.btnEliminar.Text = "&Eliminar"
    Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnEliminar.UseVisualStyleBackColor = False
    '
    'cboNivel
    '
    Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Location = New System.Drawing.Point(117, 90)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(306, 21)
    Me.cboNivel.TabIndex = 9
    '
    'cbServicio
    '
    Me.cbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbServicio.FormattingEnabled = True
    Me.cbServicio.Location = New System.Drawing.Point(359, 56)
    Me.cbServicio.Name = "cbServicio"
    Me.cbServicio.Size = New System.Drawing.Size(306, 21)
    Me.cbServicio.TabIndex = 7
    '
    'lblNivel
    '
    Me.lblNivel.AutoSize = True
    Me.lblNivel.Location = New System.Drawing.Point(61, 98)
    Me.lblNivel.Name = "lblNivel"
    Me.lblNivel.Size = New System.Drawing.Size(31, 13)
    Me.lblNivel.TabIndex = 8
    Me.lblNivel.Text = "Nivel"
    '
    'btnAgregar
    '
    Me.btnAgregar.BackColor = System.Drawing.Color.White
    Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAgregar.Location = New System.Drawing.Point(428, 202)
    Me.btnAgregar.Name = "btnAgregar"
    Me.btnAgregar.Size = New System.Drawing.Size(115, 55)
    Me.btnAgregar.TabIndex = 16
    Me.btnAgregar.Text = "&Agregar"
    Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnAgregar.UseVisualStyleBackColor = False
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(303, 64)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(45, 13)
    Me.Label3.TabIndex = 6
    Me.Label3.Text = "Servicio"
    '
    'btnAceptar
    '
    Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnAceptar.BackColor = System.Drawing.Color.White
    Me.btnAceptar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAceptar.Location = New System.Drawing.Point(696, 14)
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(110, 52)
    Me.btnAceptar.TabIndex = 1
    Me.btnAceptar.Text = "&Aceptar"
    Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnAceptar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(696, 437)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 58)
    Me.btnCerrar.TabIndex = 3
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(696, 68)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
    Me.btnCancelar.TabIndex = 2
    Me.btnCancelar.Text = "C&ancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'errValida
    '
    Me.errValida.ContainerControl = Me
    '
    'frmGestionProgramacionPago
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCerrar
    Me.ClientSize = New System.Drawing.Size(818, 507)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnAceptar)
    Me.Controls.Add(Me.gbServicio)
    Me.Name = "frmGestionProgramacionPago"
    Me.Text = "Gestion Programacion Pago"
    CType(Me.dgvServicio, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbServicio.ResumeLayout(False)
    Me.gbServicio.PerformLayout()
    CType(Me.errValida, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents dgvServicio As System.Windows.Forms.DataGridView
  Friend WithEvents lbDescripcion As System.Windows.Forms.Label
  Friend WithEvents lbTipo As System.Windows.Forms.Label
  Friend WithEvents lbMonto As System.Windows.Forms.Label
  Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
  Friend WithEvents txtMonto As System.Windows.Forms.TextBox
  Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
  Friend WithEvents cbAnio As System.Windows.Forms.ComboBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents gbServicio As System.Windows.Forms.GroupBox
  Friend WithEvents btnAceptar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnAgregar As System.Windows.Forms.Button
  Friend WithEvents btnEliminar As System.Windows.Forms.Button
  Friend WithEvents cbServicio As System.Windows.Forms.ComboBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents errValida As System.Windows.Forms.ErrorProvider
  Friend WithEvents cbEntidad As System.Windows.Forms.ComboBox
  Friend WithEvents lblEntidad As System.Windows.Forms.Label
  Friend WithEvents cboAplica As System.Windows.Forms.ComboBox
  Friend WithEvents lblAplica As System.Windows.Forms.Label
  Friend WithEvents colanio As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAplica As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colNivel As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colMonto As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colEntidad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colFecha As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colServicio As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents lblNivel As System.Windows.Forms.Label
End Class
