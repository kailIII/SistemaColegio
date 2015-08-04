<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTraslado
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
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.gbTraslado = New System.Windows.Forms.GroupBox
    Me.btnCarga = New System.Windows.Forms.Button
    Me.lblfechaTras = New System.Windows.Forms.Label
    Me.dtpFechaTras = New System.Windows.Forms.DateTimePicker
    Me.cboGrado = New System.Windows.Forms.ComboBox
    Me.txtMotivo = New System.Windows.Forms.TextBox
    Me.lblGrado = New System.Windows.Forms.Label
    Me.lblAlumno = New System.Windows.Forms.Label
    Me.lblMotivo = New System.Windows.Forms.Label
    Me.cboAlumno = New System.Windows.Forms.ComboBox
    Me.txtCodigoMod = New System.Windows.Forms.TextBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.txtResolucion = New System.Windows.Forms.TextBox
    Me.txtInstitucion = New System.Windows.Forms.TextBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.txtDescripcion = New System.Windows.Forms.TextBox
    Me.cboTipoTras = New System.Windows.Forms.ComboBox
    Me.lblCodigoMod = New System.Windows.Forms.Label
    Me.lblPeriodo = New System.Windows.Forms.Label
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.txtPeriodo = New System.Windows.Forms.TextBox
    Me.errorTraslado = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.gbTrasladados = New System.Windows.Forms.GroupBox
    Me.dgTraslados = New System.Windows.Forms.DataGridView
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdGrado = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdTipo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnModificar = New System.Windows.Forms.Button
    Me.gbTraslado.SuspendLayout()
    CType(Me.errorTraslado, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbTrasladados.SuspendLayout()
    CType(Me.dgTraslados, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'gbTraslado
    '
    Me.gbTraslado.Controls.Add(Me.btnCarga)
    Me.gbTraslado.Controls.Add(Me.lblfechaTras)
    Me.gbTraslado.Controls.Add(Me.dtpFechaTras)
    Me.gbTraslado.Controls.Add(Me.cboGrado)
    Me.gbTraslado.Controls.Add(Me.txtMotivo)
    Me.gbTraslado.Controls.Add(Me.lblGrado)
    Me.gbTraslado.Controls.Add(Me.lblAlumno)
    Me.gbTraslado.Controls.Add(Me.lblMotivo)
    Me.gbTraslado.Controls.Add(Me.cboAlumno)
    Me.gbTraslado.Controls.Add(Me.txtCodigoMod)
    Me.gbTraslado.Controls.Add(Me.Label3)
    Me.gbTraslado.Controls.Add(Me.Label2)
    Me.gbTraslado.Controls.Add(Me.txtResolucion)
    Me.gbTraslado.Controls.Add(Me.txtInstitucion)
    Me.gbTraslado.Controls.Add(Me.Label4)
    Me.gbTraslado.Controls.Add(Me.Label1)
    Me.gbTraslado.Controls.Add(Me.txtDescripcion)
    Me.gbTraslado.Controls.Add(Me.cboTipoTras)
    Me.gbTraslado.Controls.Add(Me.lblCodigoMod)
    Me.gbTraslado.Location = New System.Drawing.Point(15, 250)
    Me.gbTraslado.Name = "gbTraslado"
    Me.gbTraslado.Size = New System.Drawing.Size(569, 312)
    Me.gbTraslado.TabIndex = 0
    Me.gbTraslado.TabStop = False
    Me.gbTraslado.Text = "Datos Traslado"
    '
    'btnCarga
    '
    Me.btnCarga.Location = New System.Drawing.Point(326, 107)
    Me.btnCarga.Name = "btnCarga"
    Me.btnCarga.Size = New System.Drawing.Size(72, 23)
    Me.btnCarga.TabIndex = 8
    Me.btnCarga.Text = "Carga"
    Me.btnCarga.UseVisualStyleBackColor = True
    Me.btnCarga.Visible = False
    '
    'lblfechaTras
    '
    Me.lblfechaTras.AutoSize = True
    Me.lblfechaTras.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblfechaTras.Location = New System.Drawing.Point(84, 24)
    Me.lblfechaTras.Name = "lblfechaTras"
    Me.lblfechaTras.Size = New System.Drawing.Size(89, 15)
    Me.lblfechaTras.TabIndex = 0
    Me.lblfechaTras.Text = "Fecha Traslado"
    '
    'dtpFechaTras
    '
    Me.dtpFechaTras.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.dtpFechaTras.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaTras.Location = New System.Drawing.Point(173, 20)
    Me.dtpFechaTras.Name = "dtpFechaTras"
    Me.dtpFechaTras.Size = New System.Drawing.Size(147, 22)
    Me.dtpFechaTras.TabIndex = 1
    '
    'cboGrado
    '
    Me.cboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboGrado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboGrado.FormattingEnabled = True
    Me.cboGrado.Location = New System.Drawing.Point(173, 47)
    Me.cboGrado.Name = "cboGrado"
    Me.cboGrado.Size = New System.Drawing.Size(147, 24)
    Me.cboGrado.TabIndex = 3
    '
    'txtMotivo
    '
    Me.txtMotivo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtMotivo.Location = New System.Drawing.Point(173, 134)
    Me.txtMotivo.Multiline = True
    Me.txtMotivo.Name = "txtMotivo"
    Me.txtMotivo.Size = New System.Drawing.Size(337, 58)
    Me.txtMotivo.TabIndex = 10
    '
    'lblGrado
    '
    Me.lblGrado.AutoSize = True
    Me.lblGrado.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblGrado.Location = New System.Drawing.Point(134, 51)
    Me.lblGrado.Name = "lblGrado"
    Me.lblGrado.Size = New System.Drawing.Size(39, 15)
    Me.lblGrado.TabIndex = 2
    Me.lblGrado.Text = "Grado"
    '
    'lblAlumno
    '
    Me.lblAlumno.AutoSize = True
    Me.lblAlumno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAlumno.Location = New System.Drawing.Point(123, 78)
    Me.lblAlumno.Name = "lblAlumno"
    Me.lblAlumno.Size = New System.Drawing.Size(50, 15)
    Me.lblAlumno.TabIndex = 4
    Me.lblAlumno.Text = "Alumno"
    '
    'lblMotivo
    '
    Me.lblMotivo.AutoSize = True
    Me.lblMotivo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMotivo.Location = New System.Drawing.Point(126, 137)
    Me.lblMotivo.Name = "lblMotivo"
    Me.lblMotivo.Size = New System.Drawing.Size(47, 15)
    Me.lblMotivo.TabIndex = 9
    Me.lblMotivo.Text = "Motivo"
    '
    'cboAlumno
    '
    Me.cboAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAlumno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboAlumno.FormattingEnabled = True
    Me.cboAlumno.Location = New System.Drawing.Point(173, 76)
    Me.cboAlumno.Name = "cboAlumno"
    Me.cboAlumno.Size = New System.Drawing.Size(337, 24)
    Me.cboAlumno.TabIndex = 5
    '
    'txtCodigoMod
    '
    Me.txtCodigoMod.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtCodigoMod.Location = New System.Drawing.Point(173, 224)
    Me.txtCodigoMod.MaxLength = 7
    Me.txtCodigoMod.Name = "txtCodigoMod"
    Me.txtCodigoMod.Size = New System.Drawing.Size(147, 22)
    Me.txtCodigoMod.TabIndex = 14
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(106, 254)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(67, 15)
    Me.Label3.TabIndex = 15
    Me.Label3.Text = "Resolución"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(108, 200)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(65, 15)
    Me.Label2.TabIndex = 11
    Me.Label2.Text = "Institución"
    '
    'txtResolucion
    '
    Me.txtResolucion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtResolucion.Location = New System.Drawing.Point(173, 251)
    Me.txtResolucion.Name = "txtResolucion"
    Me.txtResolucion.Size = New System.Drawing.Size(147, 22)
    Me.txtResolucion.TabIndex = 16
    '
    'txtInstitucion
    '
    Me.txtInstitucion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtInstitucion.Location = New System.Drawing.Point(173, 197)
    Me.txtInstitucion.Name = "txtInstitucion"
    Me.txtInstitucion.Size = New System.Drawing.Size(337, 22)
    Me.txtInstitucion.TabIndex = 12
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(58, 281)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(115, 15)
    Me.Label4.TabIndex = 17
    Me.Label4.Text = "Descripción Periodo"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(91, 107)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(82, 15)
    Me.Label1.TabIndex = 6
    Me.Label1.Text = "Tipo Traslado"
    '
    'txtDescripcion
    '
    Me.txtDescripcion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDescripcion.Location = New System.Drawing.Point(173, 278)
    Me.txtDescripcion.Name = "txtDescripcion"
    Me.txtDescripcion.Size = New System.Drawing.Size(337, 22)
    Me.txtDescripcion.TabIndex = 18
    '
    'cboTipoTras
    '
    Me.cboTipoTras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoTras.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboTipoTras.FormattingEnabled = True
    Me.cboTipoTras.Items.AddRange(New Object() {"Ingreso", "Salida"})
    Me.cboTipoTras.Location = New System.Drawing.Point(173, 105)
    Me.cboTipoTras.Name = "cboTipoTras"
    Me.cboTipoTras.Size = New System.Drawing.Size(147, 24)
    Me.cboTipoTras.TabIndex = 7
    '
    'lblCodigoMod
    '
    Me.lblCodigoMod.AutoSize = True
    Me.lblCodigoMod.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblCodigoMod.Location = New System.Drawing.Point(78, 227)
    Me.lblCodigoMod.Name = "lblCodigoMod"
    Me.lblCodigoMod.Size = New System.Drawing.Size(95, 15)
    Me.lblCodigoMod.TabIndex = 13
    Me.lblCodigoMod.Text = "Código Modular"
    '
    'lblPeriodo
    '
    Me.lblPeriodo.AutoSize = True
    Me.lblPeriodo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPeriodo.Location = New System.Drawing.Point(12, 17)
    Me.lblPeriodo.Name = "lblPeriodo"
    Me.lblPeriodo.Size = New System.Drawing.Size(48, 15)
    Me.lblPeriodo.TabIndex = 6
    Me.lblPeriodo.Text = "Periodo"
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(597, 322)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 50)
    Me.btnRegistrar.TabIndex = 1
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(597, 384)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 50)
    Me.btnCancelar.TabIndex = 2
    Me.btnCancelar.Text = "C&ancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(597, 512)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 50)
    Me.btnCerrar.TabIndex = 5
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'txtPeriodo
    '
    Me.txtPeriodo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtPeriodo.Location = New System.Drawing.Point(60, 13)
    Me.txtPeriodo.Name = "txtPeriodo"
    Me.txtPeriodo.ReadOnly = True
    Me.txtPeriodo.Size = New System.Drawing.Size(159, 22)
    Me.txtPeriodo.TabIndex = 7
    Me.txtPeriodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'errorTraslado
    '
    Me.errorTraslado.ContainerControl = Me
    '
    'gbTrasladados
    '
    Me.gbTrasladados.Controls.Add(Me.dgTraslados)
    Me.gbTrasladados.Location = New System.Drawing.Point(15, 44)
    Me.gbTrasladados.Name = "gbTrasladados"
    Me.gbTrasladados.Size = New System.Drawing.Size(569, 200)
    Me.gbTrasladados.TabIndex = 3
    Me.gbTrasladados.TabStop = False
    Me.gbTrasladados.Text = "Trasladados"
    '
    'dgTraslados
    '
    Me.dgTraslados.AllowUserToAddRows = False
    Me.dgTraslados.AllowUserToDeleteRows = False
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgTraslados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.dgTraslados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgTraslados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdAlumno, Me.cdGrado, Me.cdTipo})
    Me.dgTraslados.Location = New System.Drawing.Point(11, 21)
    Me.dgTraslados.MultiSelect = False
    Me.dgTraslados.Name = "dgTraslados"
    Me.dgTraslados.ReadOnly = True
    Me.dgTraslados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgTraslados.Size = New System.Drawing.Size(546, 167)
    Me.dgTraslados.TabIndex = 0
    '
    'cdAlumno
    '
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.ReadOnly = True
    Me.cdAlumno.Width = 300
    '
    'cdGrado
    '
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.cdGrado.DefaultCellStyle = DataGridViewCellStyle5
    Me.cdGrado.HeaderText = "Grado"
    Me.cdGrado.Name = "cdGrado"
    Me.cdGrado.ReadOnly = True
    '
    'cdTipo
    '
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.cdTipo.DefaultCellStyle = DataGridViewCellStyle6
    Me.cdTipo.HeaderText = "Tipo"
    Me.cdTipo.Name = "cdTipo"
    Me.cdTipo.ReadOnly = True
    '
    'btnModificar
    '
    Me.btnModificar.BackColor = System.Drawing.Color.White
    Me.btnModificar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnModificar.Location = New System.Drawing.Point(597, 120)
    Me.btnModificar.Name = "btnModificar"
    Me.btnModificar.Size = New System.Drawing.Size(110, 50)
    Me.btnModificar.TabIndex = 4
    Me.btnModificar.Text = "&Modificar"
    Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnModificar.UseVisualStyleBackColor = False
    '
    'frmTraslado
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(719, 574)
    Me.Controls.Add(Me.btnModificar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.gbTrasladados)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.txtPeriodo)
    Me.Controls.Add(Me.lblPeriodo)
    Me.Controls.Add(Me.gbTraslado)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.Name = "frmTraslado"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de Traslado de Alumnos"
    Me.gbTraslado.ResumeLayout(False)
    Me.gbTraslado.PerformLayout()
    CType(Me.errorTraslado, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbTrasladados.ResumeLayout(False)
    CType(Me.dgTraslados, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents gbTraslado As System.Windows.Forms.GroupBox
  Friend WithEvents lblPeriodo As System.Windows.Forms.Label
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents txtPeriodo As System.Windows.Forms.TextBox
  Friend WithEvents errorTraslado As System.Windows.Forms.ErrorProvider
  Friend WithEvents gbTrasladados As System.Windows.Forms.GroupBox
  Friend WithEvents dgTraslados As System.Windows.Forms.DataGridView
  Friend WithEvents btnModificar As System.Windows.Forms.Button
  Friend WithEvents btnCarga As System.Windows.Forms.Button
  Friend WithEvents lblfechaTras As System.Windows.Forms.Label
  Friend WithEvents dtpFechaTras As System.Windows.Forms.DateTimePicker
  Friend WithEvents cboGrado As System.Windows.Forms.ComboBox
  Friend WithEvents txtMotivo As System.Windows.Forms.TextBox
  Friend WithEvents lblGrado As System.Windows.Forms.Label
  Friend WithEvents lblAlumno As System.Windows.Forms.Label
  Friend WithEvents lblMotivo As System.Windows.Forms.Label
  Friend WithEvents cboAlumno As System.Windows.Forms.ComboBox
  Friend WithEvents txtCodigoMod As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtResolucion As System.Windows.Forms.TextBox
  Friend WithEvents txtInstitucion As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
  Friend WithEvents cboTipoTras As System.Windows.Forms.ComboBox
  Friend WithEvents lblCodigoMod As System.Windows.Forms.Label
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdGrado As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdTipo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
