<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstadoCuenta
    Inherits Colegio.Plantillas.frmPlantilla

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.txtTotal = New System.Windows.Forms.TextBox()
    Me.lblTotal = New System.Windows.Forms.Label()
    Me.lblEntidad = New System.Windows.Forms.Label()
    Me.cboEntidad = New System.Windows.Forms.ComboBox()
    Me.lblVer = New System.Windows.Forms.Label()
    Me.cboVer = New System.Windows.Forms.ComboBox()
    Me.chkAnio = New System.Windows.Forms.CheckBox()
    Me.cboMatriculas = New System.Windows.Forms.ComboBox()
    Me.txtDeuda = New System.Windows.Forms.TextBox()
    Me.lblDeuda = New System.Windows.Forms.Label()
    Me.dgvObligaciones = New System.Windows.Forms.DataGridView()
    Me.cdSeleccionado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
    Me.cdDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdMontoPagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdEntidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdFechaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdMontoPagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btnImprimir = New System.Windows.Forms.Button()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.btnBuscar = New System.Windows.Forms.Button()
    Me.lblSeccion = New System.Windows.Forms.Label()
    Me.lblAlumno = New System.Windows.Forms.Label()
    Me.txtSeccion = New System.Windows.Forms.TextBox()
    Me.txtNombre = New System.Windows.Forms.TextBox()
    Me.lblCodigo = New System.Windows.Forms.Label()
    Me.txtCodigo = New System.Windows.Forms.TextBox()
    Me.btnContactar = New System.Windows.Forms.Button()
    Me.btnBeneficios = New System.Windows.Forms.Button()
    Me.GroupBox1.SuspendLayout()
    CType(Me.dgvObligaciones, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'GroupBox1
    '
    Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBox1.Controls.Add(Me.txtTotal)
    Me.GroupBox1.Controls.Add(Me.lblTotal)
    Me.GroupBox1.Controls.Add(Me.lblEntidad)
    Me.GroupBox1.Controls.Add(Me.cboEntidad)
    Me.GroupBox1.Controls.Add(Me.lblVer)
    Me.GroupBox1.Controls.Add(Me.cboVer)
    Me.GroupBox1.Controls.Add(Me.chkAnio)
    Me.GroupBox1.Controls.Add(Me.cboMatriculas)
    Me.GroupBox1.Controls.Add(Me.txtDeuda)
    Me.GroupBox1.Controls.Add(Me.lblDeuda)
    Me.GroupBox1.Controls.Add(Me.dgvObligaciones)
    Me.GroupBox1.Location = New System.Drawing.Point(12, 92)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(899, 365)
    Me.GroupBox1.TabIndex = 7
    Me.GroupBox1.TabStop = False
    '
    'txtTotal
    '
    Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtTotal.BackColor = System.Drawing.Color.White
    Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtTotal.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtTotal.Location = New System.Drawing.Point(686, 331)
    Me.txtTotal.Name = "txtTotal"
    Me.txtTotal.ReadOnly = True
    Me.txtTotal.Size = New System.Drawing.Size(67, 23)
    Me.txtTotal.TabIndex = 14
    Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'lblTotal
    '
    Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblTotal.AutoSize = True
    Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTotal.Location = New System.Drawing.Point(607, 329)
    Me.lblTotal.Name = "lblTotal"
    Me.lblTotal.Size = New System.Drawing.Size(73, 26)
    Me.lblTotal.TabIndex = 13
    Me.lblTotal.Text = "Total " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "programado"
    '
    'lblEntidad
    '
    Me.lblEntidad.AutoSize = True
    Me.lblEntidad.Location = New System.Drawing.Point(573, 31)
    Me.lblEntidad.Name = "lblEntidad"
    Me.lblEntidad.Size = New System.Drawing.Size(43, 13)
    Me.lblEntidad.TabIndex = 4
    Me.lblEntidad.Text = "E&ntidad"
    '
    'cboEntidad
    '
    Me.cboEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEntidad.FormattingEnabled = True
    Me.cboEntidad.Items.AddRange(New Object() {"AMBOS", "COLEGIO", "COPAFA"})
    Me.cboEntidad.Location = New System.Drawing.Point(622, 23)
    Me.cboEntidad.Name = "cboEntidad"
    Me.cboEntidad.Size = New System.Drawing.Size(142, 21)
    Me.cboEntidad.TabIndex = 5
    '
    'lblVer
    '
    Me.lblVer.AutoSize = True
    Me.lblVer.Location = New System.Drawing.Point(302, 29)
    Me.lblVer.Name = "lblVer"
    Me.lblVer.Size = New System.Drawing.Size(23, 13)
    Me.lblVer.TabIndex = 2
    Me.lblVer.Text = "Ve&r"
    '
    'cboVer
    '
    Me.cboVer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboVer.FormattingEnabled = True
    Me.cboVer.Items.AddRange(New Object() {"VER TODO", "VER PENDIENTES DE PAGO"})
    Me.cboVer.Location = New System.Drawing.Point(331, 22)
    Me.cboVer.Name = "cboVer"
    Me.cboVer.Size = New System.Drawing.Size(186, 21)
    Me.cboVer.TabIndex = 3
    '
    'chkAnio
    '
    Me.chkAnio.AutoSize = True
    Me.chkAnio.Location = New System.Drawing.Point(9, 28)
    Me.chkAnio.Name = "chkAnio"
    Me.chkAnio.Size = New System.Drawing.Size(45, 17)
    Me.chkAnio.TabIndex = 0
    Me.chkAnio.Text = "Añ&o"
    Me.chkAnio.UseVisualStyleBackColor = True
    '
    'cboMatriculas
    '
    Me.cboMatriculas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboMatriculas.Enabled = False
    Me.cboMatriculas.FormattingEnabled = True
    Me.cboMatriculas.Location = New System.Drawing.Point(57, 22)
    Me.cboMatriculas.Name = "cboMatriculas"
    Me.cboMatriculas.Size = New System.Drawing.Size(136, 21)
    Me.cboMatriculas.TabIndex = 1
    '
    'txtDeuda
    '
    Me.txtDeuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.txtDeuda.BackColor = System.Drawing.Color.White
    Me.txtDeuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDeuda.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtDeuda.Location = New System.Drawing.Point(818, 331)
    Me.txtDeuda.Name = "txtDeuda"
    Me.txtDeuda.ReadOnly = True
    Me.txtDeuda.Size = New System.Drawing.Size(70, 23)
    Me.txtDeuda.TabIndex = 16
    Me.txtDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'lblDeuda
    '
    Me.lblDeuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.lblDeuda.AutoSize = True
    Me.lblDeuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDeuda.Location = New System.Drawing.Point(760, 329)
    Me.lblDeuda.Name = "lblDeuda"
    Me.lblDeuda.Size = New System.Drawing.Size(52, 26)
    Me.lblDeuda.TabIndex = 15
    Me.lblDeuda.Text = "Total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "vencido"
    '
    'dgvObligaciones
    '
    Me.dgvObligaciones.AllowUserToAddRows = False
    Me.dgvObligaciones.AllowUserToDeleteRows = False
    Me.dgvObligaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvObligaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvObligaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvObligaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdSeleccionado, Me.cdDescripcion, Me.cdVencimiento, Me.cdMontoPagar, Me.cdEntidad, Me.cdDocumento, Me.cdFechaPago, Me.cdMontoPagado, Me.cdSaldo})
    Me.dgvObligaciones.Location = New System.Drawing.Point(9, 51)
    Me.dgvObligaciones.Name = "dgvObligaciones"
    Me.dgvObligaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvObligaciones.Size = New System.Drawing.Size(879, 268)
    Me.dgvObligaciones.TabIndex = 6
    '
    'cdSeleccionado
    '
    Me.cdSeleccionado.DataPropertyName = "Seleccionado"
    Me.cdSeleccionado.HeaderText = "Seleccionado"
    Me.cdSeleccionado.Name = "cdSeleccionado"
    Me.cdSeleccionado.Width = 70
    '
    'cdDescripcion
    '
    Me.cdDescripcion.DataPropertyName = "Descripcion"
    Me.cdDescripcion.HeaderText = "Descripción"
    Me.cdDescripcion.Name = "cdDescripcion"
    Me.cdDescripcion.Width = 180
    '
    'cdVencimiento
    '
    Me.cdVencimiento.DataPropertyName = "Vencimiento"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdVencimiento.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdVencimiento.HeaderText = "Fecha de Venc."
    Me.cdVencimiento.Name = "cdVencimiento"
    Me.cdVencimiento.Width = 80
    '
    'cdMontoPagar
    '
    Me.cdMontoPagar.DataPropertyName = "MontoPagar"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdMontoPagar.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdMontoPagar.HeaderText = "Importe a pagar"
    Me.cdMontoPagar.Name = "cdMontoPagar"
    Me.cdMontoPagar.Width = 80
    '
    'cdEntidad
    '
    Me.cdEntidad.DataPropertyName = "NombreEntidad"
    Me.cdEntidad.HeaderText = "Entidad"
    Me.cdEntidad.Name = "cdEntidad"
    Me.cdEntidad.Width = 80
    '
    'cdDocumento
    '
    Me.cdDocumento.DataPropertyName = "DocumentoPago"
    Me.cdDocumento.HeaderText = "Documento"
    Me.cdDocumento.Name = "cdDocumento"
    '
    'cdFechaPago
    '
    Me.cdFechaPago.DataPropertyName = "FechaPago"
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdFechaPago.DefaultCellStyle = DataGridViewCellStyle4
    Me.cdFechaPago.HeaderText = "Fecha documento"
    Me.cdFechaPago.Name = "cdFechaPago"
    Me.cdFechaPago.Width = 80
    '
    'cdMontoPagado
    '
    Me.cdMontoPagado.DataPropertyName = "MontoPagado"
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdMontoPagado.DefaultCellStyle = DataGridViewCellStyle5
    Me.cdMontoPagado.HeaderText = "Importe pagado"
    Me.cdMontoPagado.Name = "cdMontoPagado"
    Me.cdMontoPagado.Width = 80
    '
    'cdSaldo
    '
    Me.cdSaldo.DataPropertyName = "SaldoFormato"
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdSaldo.DefaultCellStyle = DataGridViewCellStyle6
    Me.cdSaldo.HeaderText = "Saldo"
    Me.cdSaldo.Name = "cdSaldo"
    Me.cdSaldo.Width = 80
    '
    'btnImprimir
    '
    Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnImprimir.BackColor = System.Drawing.Color.White
    Me.btnImprimir.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnImprimir.Location = New System.Drawing.Point(917, 341)
    Me.btnImprimir.Name = "btnImprimir"
    Me.btnImprimir.Size = New System.Drawing.Size(130, 52)
    Me.btnImprimir.TabIndex = 10
    Me.btnImprimir.Text = "&Imprimir"
    Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnImprimir.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(917, 399)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(130, 58)
    Me.btnCerrar.TabIndex = 11
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnBuscar
    '
    Me.btnBuscar.BackColor = System.Drawing.Color.White
    Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscar.Location = New System.Drawing.Point(698, 27)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(117, 52)
    Me.btnBuscar.TabIndex = 2
    Me.btnBuscar.Text = "&Buscar"
    Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscar.UseVisualStyleBackColor = False
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Location = New System.Drawing.Point(18, 66)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(46, 13)
    Me.lblSeccion.TabIndex = 3
    Me.lblSeccion.Text = "Sección"
    '
    'lblAlumno
    '
    Me.lblAlumno.AutoSize = True
    Me.lblAlumno.Location = New System.Drawing.Point(18, 34)
    Me.lblAlumno.Name = "lblAlumno"
    Me.lblAlumno.Size = New System.Drawing.Size(42, 13)
    Me.lblAlumno.TabIndex = 0
    Me.lblAlumno.Text = "Alumno"
    '
    'txtSeccion
    '
    Me.txtSeccion.BackColor = System.Drawing.SystemColors.Window
    Me.txtSeccion.Location = New System.Drawing.Point(69, 59)
    Me.txtSeccion.Name = "txtSeccion"
    Me.txtSeccion.ReadOnly = True
    Me.txtSeccion.Size = New System.Drawing.Size(205, 20)
    Me.txtSeccion.TabIndex = 4
    '
    'txtNombre
    '
    Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
    Me.txtNombre.Location = New System.Drawing.Point(69, 27)
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.ReadOnly = True
    Me.txtNombre.Size = New System.Drawing.Size(623, 20)
    Me.txtNombre.TabIndex = 1
    '
    'lblCodigo
    '
    Me.lblCodigo.AutoSize = True
    Me.lblCodigo.Location = New System.Drawing.Point(353, 66)
    Me.lblCodigo.Name = "lblCodigo"
    Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
    Me.lblCodigo.TabIndex = 5
    Me.lblCodigo.Text = "Có&digo"
    '
    'txtCodigo
    '
    Me.txtCodigo.BackColor = System.Drawing.SystemColors.Window
    Me.txtCodigo.Location = New System.Drawing.Point(404, 59)
    Me.txtCodigo.Name = "txtCodigo"
    Me.txtCodigo.Size = New System.Drawing.Size(125, 20)
    Me.txtCodigo.TabIndex = 6
    '
    'btnContactar
    '
    Me.btnContactar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnContactar.BackColor = System.Drawing.Color.White
    Me.btnContactar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnContactar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnContactar.Location = New System.Drawing.Point(917, 27)
    Me.btnContactar.Name = "btnContactar"
    Me.btnContactar.Size = New System.Drawing.Size(130, 52)
    Me.btnContactar.TabIndex = 8
    Me.btnContactar.Text = "Ver da&tos"
    Me.btnContactar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnContactar.UseVisualStyleBackColor = False
    '
    'btnBeneficios
    '
    Me.btnBeneficios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnBeneficios.BackColor = System.Drawing.Color.White
    Me.btnBeneficios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBeneficios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBeneficios.Location = New System.Drawing.Point(917, 92)
    Me.btnBeneficios.Name = "btnBeneficios"
    Me.btnBeneficios.Size = New System.Drawing.Size(130, 52)
    Me.btnBeneficios.TabIndex = 9
    Me.btnBeneficios.Text = "Bene&ficios"
    Me.btnBeneficios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBeneficios.UseVisualStyleBackColor = False
    '
    'frmEstadoCuenta
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCerrar
    Me.ClientSize = New System.Drawing.Size(1059, 476)
    Me.Controls.Add(Me.btnBeneficios)
    Me.Controls.Add(Me.btnContactar)
    Me.Controls.Add(Me.lblCodigo)
    Me.Controls.Add(Me.txtCodigo)
    Me.Controls.Add(Me.btnBuscar)
    Me.Controls.Add(Me.lblSeccion)
    Me.Controls.Add(Me.lblAlumno)
    Me.Controls.Add(Me.txtSeccion)
    Me.Controls.Add(Me.txtNombre)
    Me.Controls.Add(Me.btnImprimir)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.GroupBox1)
    Me.Name = "frmEstadoCuenta"
    Me.Text = "Estado de Cuenta"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    CType(Me.dgvObligaciones, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents lblDeuda As System.Windows.Forms.Label
  Friend WithEvents btnImprimir As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents dgvObligaciones As System.Windows.Forms.DataGridView
  Private WithEvents txtDeuda As System.Windows.Forms.TextBox
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents lblAlumno As System.Windows.Forms.Label
  Friend WithEvents txtSeccion As System.Windows.Forms.TextBox
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents cboMatriculas As System.Windows.Forms.ComboBox
  Friend WithEvents chkAnio As System.Windows.Forms.CheckBox
  Friend WithEvents lblVer As System.Windows.Forms.Label
  Friend WithEvents cboVer As System.Windows.Forms.ComboBox
  Friend WithEvents lblEntidad As System.Windows.Forms.Label
  Friend WithEvents cboEntidad As System.Windows.Forms.ComboBox
  Friend WithEvents lblCodigo As System.Windows.Forms.Label
  Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
  Friend WithEvents btnContactar As System.Windows.Forms.Button
  Friend WithEvents btnBeneficios As System.Windows.Forms.Button
  Friend WithEvents cdSeleccionado As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents cdDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdVencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdMontoPagar As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdEntidad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdFechaPago As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdMontoPagado As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
  Private WithEvents txtTotal As System.Windows.Forms.TextBox
  Friend WithEvents lblTotal As System.Windows.Forms.Label
End Class
