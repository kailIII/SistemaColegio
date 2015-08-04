<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoDocumentos
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
    Me.cboEntidad = New System.Windows.Forms.ComboBox
    Me.dtfechaMay = New System.Windows.Forms.DateTimePicker
    Me.lblfechafinal = New System.Windows.Forms.Label
    Me.lblFechainicial = New System.Windows.Forms.Label
    Me.dtfechaMen = New System.Windows.Forms.DateTimePicker
    Me.gbAlumno = New System.Windows.Forms.GroupBox
    Me.btnBuscarAlumno = New System.Windows.Forms.Button
    Me.lblGradoSec = New System.Windows.Forms.Label
    Me.lblNombre = New System.Windows.Forms.Label
    Me.txtGradoSec = New System.Windows.Forms.TextBox
    Me.txtNombre = New System.Windows.Forms.TextBox
    Me.chkAlumno = New System.Windows.Forms.CheckBox
    Me.btnListar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnAnular = New System.Windows.Forms.Button
    Me.dgvRecibos = New System.Windows.Forms.DataGridView
    Me.cdSeleccionado = New System.Windows.Forms.DataGridViewCheckBoxColumn
    Me.cdDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdPersona = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdVigencia = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.gbDetalleDoc = New System.Windows.Forms.GroupBox
    Me.chkSeleccionarTodos = New System.Windows.Forms.CheckBox
    Me.btnActivar = New System.Windows.Forms.Button
    Me.btnImprimir = New System.Windows.Forms.Button
    Me.btnModificar = New System.Windows.Forms.Button
    Me.gbPeriodo = New System.Windows.Forms.GroupBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.gbAlumno.SuspendLayout()
    CType(Me.dgvRecibos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbDetalleDoc.SuspendLayout()
    Me.gbPeriodo.SuspendLayout()
    Me.SuspendLayout()
    '
    'cboEntidad
    '
    Me.cboEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEntidad.FormattingEnabled = True
    Me.cboEntidad.Items.AddRange(New Object() {"TODOS", "INSTITUCION", "COPAFA"})
    Me.cboEntidad.Location = New System.Drawing.Point(77, 21)
    Me.cboEntidad.Name = "cboEntidad"
    Me.cboEntidad.Size = New System.Drawing.Size(167, 21)
    Me.cboEntidad.TabIndex = 1
    '
    'dtfechaMay
    '
    Me.dtfechaMay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dtfechaMay.CustomFormat = "dd/MM/yyyy"
    Me.dtfechaMay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtfechaMay.Location = New System.Drawing.Point(443, 18)
    Me.dtfechaMay.Name = "dtfechaMay"
    Me.dtfechaMay.Size = New System.Drawing.Size(105, 20)
    Me.dtfechaMay.TabIndex = 3
    '
    'lblfechafinal
    '
    Me.lblfechafinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lblfechafinal.AutoSize = True
    Me.lblfechafinal.Location = New System.Drawing.Point(375, 25)
    Me.lblfechafinal.Name = "lblfechafinal"
    Me.lblfechafinal.Size = New System.Drawing.Size(62, 13)
    Me.lblfechafinal.TabIndex = 2
    Me.lblfechafinal.Text = "&Fecha Final"
    '
    'lblFechainicial
    '
    Me.lblFechainicial.AutoSize = True
    Me.lblFechainicial.Location = New System.Drawing.Point(16, 26)
    Me.lblFechainicial.Name = "lblFechainicial"
    Me.lblFechainicial.Size = New System.Drawing.Size(34, 13)
    Me.lblFechainicial.TabIndex = 0
    Me.lblFechainicial.Text = "&Inicial"
    '
    'dtfechaMen
    '
    Me.dtfechaMen.CustomFormat = "dd/MM/yyyy"
    Me.dtfechaMen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtfechaMen.Location = New System.Drawing.Point(71, 19)
    Me.dtfechaMen.Name = "dtfechaMen"
    Me.dtfechaMen.Size = New System.Drawing.Size(104, 20)
    Me.dtfechaMen.TabIndex = 1
    '
    'gbAlumno
    '
    Me.gbAlumno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbAlumno.Controls.Add(Me.btnBuscarAlumno)
    Me.gbAlumno.Controls.Add(Me.lblGradoSec)
    Me.gbAlumno.Controls.Add(Me.lblNombre)
    Me.gbAlumno.Controls.Add(Me.txtGradoSec)
    Me.gbAlumno.Controls.Add(Me.txtNombre)
    Me.gbAlumno.Enabled = False
    Me.gbAlumno.Location = New System.Drawing.Point(6, 127)
    Me.gbAlumno.Name = "gbAlumno"
    Me.gbAlumno.Size = New System.Drawing.Size(667, 80)
    Me.gbAlumno.TabIndex = 3
    Me.gbAlumno.TabStop = False
    '
    'btnBuscarAlumno
    '
    Me.btnBuscarAlumno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnBuscarAlumno.Location = New System.Drawing.Point(575, 19)
    Me.btnBuscarAlumno.Name = "btnBuscarAlumno"
    Me.btnBuscarAlumno.Size = New System.Drawing.Size(55, 23)
    Me.btnBuscarAlumno.TabIndex = 2
    Me.btnBuscarAlumno.Text = "..."
    Me.btnBuscarAlumno.UseVisualStyleBackColor = True
    '
    'lblGradoSec
    '
    Me.lblGradoSec.AutoSize = True
    Me.lblGradoSec.Location = New System.Drawing.Point(9, 52)
    Me.lblGradoSec.Name = "lblGradoSec"
    Me.lblGradoSec.Size = New System.Drawing.Size(46, 13)
    Me.lblGradoSec.TabIndex = 3
    Me.lblGradoSec.Text = "Sección"
    '
    'lblNombre
    '
    Me.lblNombre.AutoSize = True
    Me.lblNombre.Location = New System.Drawing.Point(9, 26)
    Me.lblNombre.Name = "lblNombre"
    Me.lblNombre.Size = New System.Drawing.Size(44, 13)
    Me.lblNombre.TabIndex = 0
    Me.lblNombre.Text = "Nombre"
    '
    'txtGradoSec
    '
    Me.txtGradoSec.Location = New System.Drawing.Point(65, 45)
    Me.txtGradoSec.Name = "txtGradoSec"
    Me.txtGradoSec.Size = New System.Drawing.Size(120, 20)
    Me.txtGradoSec.TabIndex = 4
    '
    'txtNombre
    '
    Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtNombre.Location = New System.Drawing.Point(65, 19)
    Me.txtNombre.Name = "txtNombre"
    Me.txtNombre.Size = New System.Drawing.Size(483, 20)
    Me.txtNombre.TabIndex = 1
    '
    'chkAlumno
    '
    Me.chkAlumno.AutoSize = True
    Me.chkAlumno.Location = New System.Drawing.Point(17, 126)
    Me.chkAlumno.Name = "chkAlumno"
    Me.chkAlumno.Size = New System.Drawing.Size(61, 17)
    Me.chkAlumno.TabIndex = 5
    Me.chkAlumno.Text = "A&lumno"
    Me.chkAlumno.UseVisualStyleBackColor = True
    '
    'btnListar
    '
    Me.btnListar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnListar.Location = New System.Drawing.Point(684, 155)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(110, 52)
    Me.btnListar.TabIndex = 4
    Me.btnListar.Text = "&Listar"
    Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnListar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(684, 443)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 58)
    Me.btnCerrar.TabIndex = 6
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnAnular
    '
    Me.btnAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnAnular.BackColor = System.Drawing.Color.White
    Me.btnAnular.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAnular.Location = New System.Drawing.Point(12, 216)
    Me.btnAnular.Name = "btnAnular"
    Me.btnAnular.Size = New System.Drawing.Size(110, 52)
    Me.btnAnular.TabIndex = 1
    Me.btnAnular.Text = "&Anular"
    Me.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnAnular.UseVisualStyleBackColor = False
    '
    'dgvRecibos
    '
    Me.dgvRecibos.AllowUserToAddRows = False
    Me.dgvRecibos.AllowUserToDeleteRows = False
    Me.dgvRecibos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvRecibos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdSeleccionado, Me.cdDocumento, Me.cdPersona, Me.cdFecha, Me.cdTotal, Me.cdVigencia})
    Me.dgvRecibos.Location = New System.Drawing.Point(12, 51)
    Me.dgvRecibos.MultiSelect = False
    Me.dgvRecibos.Name = "dgvRecibos"
    Me.dgvRecibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvRecibos.Size = New System.Drawing.Size(646, 159)
    Me.dgvRecibos.TabIndex = 0
    '
    'cdSeleccionado
    '
    Me.cdSeleccionado.DataPropertyName = "Seleccionado"
    Me.cdSeleccionado.HeaderText = "Seleccionar"
    Me.cdSeleccionado.Name = "cdSeleccionado"
    Me.cdSeleccionado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.cdSeleccionado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.cdSeleccionado.Width = 70
    '
    'cdDocumento
    '
    Me.cdDocumento.DataPropertyName = "DocumentoNumero"
    Me.cdDocumento.HeaderText = "Documento"
    Me.cdDocumento.Name = "cdDocumento"
    Me.cdDocumento.ReadOnly = True
    '
    'cdPersona
    '
    Me.cdPersona.DataPropertyName = "NombrePersona"
    Me.cdPersona.HeaderText = "Persona"
    Me.cdPersona.Name = "cdPersona"
    Me.cdPersona.ReadOnly = True
    Me.cdPersona.Width = 170
    '
    'cdFecha
    '
    Me.cdFecha.DataPropertyName = "Fecha"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle1.Format = "d"
    DataGridViewCellStyle1.NullValue = Nothing
    Me.cdFecha.DefaultCellStyle = DataGridViewCellStyle1
    Me.cdFecha.HeaderText = "Fecha"
    Me.cdFecha.Name = "cdFecha"
    Me.cdFecha.ReadOnly = True
    Me.cdFecha.Width = 120
    '
    'cdTotal
    '
    Me.cdTotal.DataPropertyName = "Total"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle2.Format = "N2"
    DataGridViewCellStyle2.NullValue = Nothing
    Me.cdTotal.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdTotal.HeaderText = "Total"
    Me.cdTotal.Name = "cdTotal"
    Me.cdTotal.ReadOnly = True
    Me.cdTotal.Width = 70
    '
    'cdVigencia
    '
    Me.cdVigencia.DataPropertyName = "DescripcionVigencia"
    Me.cdVigencia.HeaderText = "Vigencia"
    Me.cdVigencia.Name = "cdVigencia"
    Me.cdVigencia.ReadOnly = True
    Me.cdVigencia.Width = 90
    '
    'gbDetalleDoc
    '
    Me.gbDetalleDoc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbDetalleDoc.Controls.Add(Me.chkSeleccionarTodos)
    Me.gbDetalleDoc.Controls.Add(Me.btnActivar)
    Me.gbDetalleDoc.Controls.Add(Me.btnImprimir)
    Me.gbDetalleDoc.Controls.Add(Me.btnModificar)
    Me.gbDetalleDoc.Controls.Add(Me.dgvRecibos)
    Me.gbDetalleDoc.Controls.Add(Me.btnAnular)
    Me.gbDetalleDoc.Location = New System.Drawing.Point(6, 227)
    Me.gbDetalleDoc.Name = "gbDetalleDoc"
    Me.gbDetalleDoc.Size = New System.Drawing.Size(667, 274)
    Me.gbDetalleDoc.TabIndex = 5
    Me.gbDetalleDoc.TabStop = False
    Me.gbDetalleDoc.Text = "Detalles de Recibo de Pago"
    '
    'chkSeleccionarTodos
    '
    Me.chkSeleccionarTodos.AutoSize = True
    Me.chkSeleccionarTodos.Location = New System.Drawing.Point(12, 28)
    Me.chkSeleccionarTodos.Name = "chkSeleccionarTodos"
    Me.chkSeleccionarTodos.Size = New System.Drawing.Size(106, 17)
    Me.chkSeleccionarTodos.TabIndex = 18
    Me.chkSeleccionarTodos.Text = "&Seleccionar todo"
    Me.chkSeleccionarTodos.UseVisualStyleBackColor = True
    '
    'btnActivar
    '
    Me.btnActivar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnActivar.BackColor = System.Drawing.Color.White
    Me.btnActivar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnActivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnActivar.Location = New System.Drawing.Point(128, 216)
    Me.btnActivar.Name = "btnActivar"
    Me.btnActivar.Size = New System.Drawing.Size(110, 52)
    Me.btnActivar.TabIndex = 3
    Me.btnActivar.Text = "Acti&var"
    Me.btnActivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnActivar.UseVisualStyleBackColor = False
    '
    'btnImprimir
    '
    Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnImprimir.BackColor = System.Drawing.Color.White
    Me.btnImprimir.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnImprimir.Location = New System.Drawing.Point(360, 216)
    Me.btnImprimir.Name = "btnImprimir"
    Me.btnImprimir.Size = New System.Drawing.Size(110, 52)
    Me.btnImprimir.TabIndex = 2
    Me.btnImprimir.Text = "&Imprimir"
    Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnImprimir.UseVisualStyleBackColor = False
    '
    'btnModificar
    '
    Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnModificar.BackColor = System.Drawing.Color.White
    Me.btnModificar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnModificar.Location = New System.Drawing.Point(244, 216)
    Me.btnModificar.Name = "btnModificar"
    Me.btnModificar.Size = New System.Drawing.Size(110, 52)
    Me.btnModificar.TabIndex = 2
    Me.btnModificar.Text = "&Modificar"
    Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnModificar.UseVisualStyleBackColor = False
    '
    'gbPeriodo
    '
    Me.gbPeriodo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbPeriodo.Controls.Add(Me.dtfechaMay)
    Me.gbPeriodo.Controls.Add(Me.lblfechafinal)
    Me.gbPeriodo.Controls.Add(Me.lblFechainicial)
    Me.gbPeriodo.Controls.Add(Me.dtfechaMen)
    Me.gbPeriodo.Location = New System.Drawing.Point(6, 66)
    Me.gbPeriodo.Name = "gbPeriodo"
    Me.gbPeriodo.Size = New System.Drawing.Size(667, 55)
    Me.gbPeriodo.TabIndex = 2
    Me.gbPeriodo.TabStop = False
    Me.gbPeriodo.Text = "Periodo"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(13, 29)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(43, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "&Entidad"
    '
    'frmMantenimientoDocumentos
    '
    Me.AcceptButton = Me.btnListar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCerrar
    Me.ClientSize = New System.Drawing.Size(806, 515)
    Me.Controls.Add(Me.chkAlumno)
    Me.Controls.Add(Me.gbDetalleDoc)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.btnListar)
    Me.Controls.Add(Me.gbAlumno)
    Me.Controls.Add(Me.gbPeriodo)
    Me.Controls.Add(Me.cboEntidad)
    Me.Name = "frmMantenimientoDocumentos"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Mantenimiento de documentos"
    Me.gbAlumno.ResumeLayout(False)
    Me.gbAlumno.PerformLayout()
    CType(Me.dgvRecibos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbDetalleDoc.ResumeLayout(False)
    Me.gbDetalleDoc.PerformLayout()
    Me.gbPeriodo.ResumeLayout(False)
    Me.gbPeriodo.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents cboEntidad As System.Windows.Forms.ComboBox
  Friend WithEvents gbAlumno As System.Windows.Forms.GroupBox
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents lblGradoSec As System.Windows.Forms.Label
  Friend WithEvents lblNombre As System.Windows.Forms.Label
  Friend WithEvents txtGradoSec As System.Windows.Forms.TextBox
  Friend WithEvents txtNombre As System.Windows.Forms.TextBox
  Friend WithEvents dtfechaMay As System.Windows.Forms.DateTimePicker
  Friend WithEvents lblfechafinal As System.Windows.Forms.Label
  Friend WithEvents lblFechainicial As System.Windows.Forms.Label
  Friend WithEvents dtfechaMen As System.Windows.Forms.DateTimePicker
  Friend WithEvents btnBuscarAlumno As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnAnular As System.Windows.Forms.Button
  Friend WithEvents dgvRecibos As System.Windows.Forms.DataGridView
  Friend WithEvents gbDetalleDoc As System.Windows.Forms.GroupBox
  Friend WithEvents gbPeriodo As System.Windows.Forms.GroupBox
  Friend WithEvents btnModificar As System.Windows.Forms.Button
  Friend WithEvents chkAlumno As System.Windows.Forms.CheckBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents btnImprimir As System.Windows.Forms.Button
  Friend WithEvents btnActivar As System.Windows.Forms.Button
  Friend WithEvents cdSeleccionado As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents cdDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdPersona As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdFecha As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdTotal As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdVigencia As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents chkSeleccionarTodos As System.Windows.Forms.CheckBox
End Class
