<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionPresentacion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txtAnio = New System.Windows.Forms.TextBox
        Me.lblAnio = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GBPresentación = New System.Windows.Forms.GroupBox
        Me.chkVigencia = New System.Windows.Forms.CheckBox
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.nudPresentacion = New System.Windows.Forms.NumericUpDown
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnRegistrar = New System.Windows.Forms.Button
        Me.dgvPresentacion = New System.Windows.Forms.DataGridView
        Me.GBLista = New System.Windows.Forms.GroupBox
        Me.ErrValida = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnActualizar = New System.Windows.Forms.Button
        Me.gbLeyenda = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblVigente = New System.Windows.Forms.Label
        Me.cdNro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cdInicio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cdFin = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cdVigencia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GBPresentación.SuspendLayout()
        CType(Me.nudPresentacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPresentacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBLista.SuspendLayout()
        CType(Me.ErrValida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLeyenda.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAnio
        '
        Me.txtAnio.BackColor = System.Drawing.Color.White
        Me.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.txtAnio.Location = New System.Drawing.Point(103, 12)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.ReadOnly = True
        Me.txtAnio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAnio.Size = New System.Drawing.Size(73, 25)
        Me.txtAnio.TabIndex = 1
        Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAnio
        '
        Me.lblAnio.AutoSize = True
        Me.lblAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.lblAnio.Location = New System.Drawing.Point(17, 15)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(53, 17)
        Me.lblAnio.TabIndex = 0
        Me.lblAnio.Text = "&Periodo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(18, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Nro"
        '
        'GBPresentación
        '
        Me.GBPresentación.Controls.Add(Me.chkVigencia)
        Me.GBPresentación.Controls.Add(Me.dtpFechaFin)
        Me.GBPresentación.Controls.Add(Me.dtpFechaIni)
        Me.GBPresentación.Controls.Add(Me.Label3)
        Me.GBPresentación.Controls.Add(Me.Label2)
        Me.GBPresentación.Controls.Add(Me.nudPresentacion)
        Me.GBPresentación.Controls.Add(Me.Label1)
        Me.GBPresentación.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.GBPresentación.Location = New System.Drawing.Point(12, 43)
        Me.GBPresentación.Name = "GBPresentación"
        Me.GBPresentación.Size = New System.Drawing.Size(326, 175)
        Me.GBPresentación.TabIndex = 2
        Me.GBPresentación.TabStop = False
        Me.GBPresentación.Text = "Presentación"
        '
        'chkVigencia
        '
        Me.chkVigencia.AutoSize = True
        Me.chkVigencia.Location = New System.Drawing.Point(91, 141)
        Me.chkVigencia.Name = "chkVigencia"
        Me.chkVigencia.Size = New System.Drawing.Size(72, 21)
        Me.chkVigencia.TabIndex = 6
        Me.chkVigencia.Text = "&Vigente"
        Me.chkVigencia.UseVisualStyleBackColor = True
        Me.chkVigencia.Visible = False
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(91, 100)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(163, 25)
        Me.dtpFechaFin.TabIndex = 5
        Me.dtpFechaFin.Value = New Date(2010, 4, 27, 0, 0, 0, 0)
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(91, 62)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(163, 25)
        Me.dtpFechaIni.TabIndex = 3
        Me.dtpFechaIni.Value = New Date(2010, 4, 27, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(18, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Fin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(18, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Inicio"
        '
        'nudPresentacion
        '
        Me.nudPresentacion.Location = New System.Drawing.Point(91, 25)
        Me.nudPresentacion.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nudPresentacion.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPresentacion.Name = "nudPresentacion"
        Me.nudPresentacion.Size = New System.Drawing.Size(42, 25)
        Me.nudPresentacion.TabIndex = 1
        Me.nudPresentacion.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(485, 167)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "&Deshacer"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(485, 520)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.White
        Me.btnRegistrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistrar.Location = New System.Drawing.Point(358, 166)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(110, 52)
        Me.btnRegistrar.TabIndex = 3
        Me.btnRegistrar.Text = "&Registrar"
        Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'dgvPresentacion
        '
        Me.dgvPresentacion.AllowUserToAddRows = False
        Me.dgvPresentacion.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPresentacion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPresentacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPresentacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNro, Me.cdInicio, Me.cdFin, Me.cdVigencia})
        Me.dgvPresentacion.Location = New System.Drawing.Point(6, 22)
        Me.dgvPresentacion.MultiSelect = False
        Me.dgvPresentacion.Name = "dgvPresentacion"
        Me.dgvPresentacion.ReadOnly = True
        Me.dgvPresentacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPresentacion.Size = New System.Drawing.Size(444, 320)
        Me.dgvPresentacion.TabIndex = 0
        '
        'GBLista
        '
        Me.GBLista.Controls.Add(Me.dgvPresentacion)
        Me.GBLista.Font = New System.Drawing.Font("Times New Roman", 11.25!)
        Me.GBLista.Location = New System.Drawing.Point(12, 224)
        Me.GBLista.Name = "GBLista"
        Me.GBLista.Size = New System.Drawing.Size(456, 348)
        Me.GBLista.TabIndex = 5
        Me.GBLista.TabStop = False
        Me.GBLista.Text = "Lista de Presentaciones"
        '
        'ErrValida
        '
        Me.ErrValida.ContainerControl = Me
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.White
        Me.btnActualizar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizar.Location = New System.Drawing.Point(485, 334)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(110, 52)
        Me.btnActualizar.TabIndex = 6
        Me.btnActualizar.Text = "&Seleccionar"
        Me.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'gbLeyenda
        '
        Me.gbLeyenda.Controls.Add(Me.Label5)
        Me.gbLeyenda.Controls.Add(Me.Panel1)
        Me.gbLeyenda.Controls.Add(Me.lblVigente)
        Me.gbLeyenda.Controls.Add(Me.Panel2)
        Me.gbLeyenda.Location = New System.Drawing.Point(358, 43)
        Me.gbLeyenda.Name = "gbLeyenda"
        Me.gbLeyenda.Size = New System.Drawing.Size(237, 79)
        Me.gbLeyenda.TabIndex = 10
        Me.gbLeyenda.TabStop = False
        Me.gbLeyenda.Text = "Leyenda"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Vigente"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.GreenYellow
        Me.Panel2.Location = New System.Drawing.Point(127, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(104, 26)
        Me.Panel2.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Location = New System.Drawing.Point(127, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(104, 26)
        Me.Panel1.TabIndex = 8
        '
        'lblVigente
        '
        Me.lblVigente.AutoSize = True
        Me.lblVigente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVigente.Location = New System.Drawing.Point(23, 53)
        Me.lblVigente.Name = "lblVigente"
        Me.lblVigente.Size = New System.Drawing.Size(68, 15)
        Me.lblVigente.TabIndex = 9
        Me.lblVigente.Text = "No Vigente"
        '
        'cdNro
        '
        Me.cdNro.DataPropertyName = "Nro"
        Me.cdNro.HeaderText = "Nro"
        Me.cdNro.Name = "cdNro"
        Me.cdNro.ReadOnly = True
        Me.cdNro.Width = 30
        '
        'cdInicio
        '
        Me.cdInicio.DataPropertyName = "Inicio"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.cdInicio.DefaultCellStyle = DataGridViewCellStyle2
        Me.cdInicio.HeaderText = "Fecha Inicio"
        Me.cdInicio.Name = "cdInicio"
        Me.cdInicio.ReadOnly = True
        Me.cdInicio.Width = 130
        '
        'cdFin
        '
        Me.cdFin.DataPropertyName = "Fin"
        DataGridViewCellStyle3.Format = "d"
        Me.cdFin.DefaultCellStyle = DataGridViewCellStyle3
        Me.cdFin.HeaderText = "Fecha Fin"
        Me.cdFin.Name = "cdFin"
        Me.cdFin.ReadOnly = True
        Me.cdFin.Width = 130
        '
        'cdVigencia
        '
        Me.cdVigencia.DataPropertyName = "NombreVigencia"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.cdVigencia.DefaultCellStyle = DataGridViewCellStyle4
        Me.cdVigencia.HeaderText = "Vigente"
        Me.cdVigencia.Name = "cdVigencia"
        Me.cdVigencia.ReadOnly = True
        '
        'frmGestionPresentacion
        '
        Me.AcceptButton = Me.btnRegistrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.ClientSize = New System.Drawing.Size(604, 584)
        Me.Controls.Add(Me.gbLeyenda)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.GBLista)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.GBPresentación)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.lblAnio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGestionPresentacion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Presentaciones"
        Me.GBPresentación.ResumeLayout(False)
        Me.GBPresentación.PerformLayout()
        CType(Me.nudPresentacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPresentacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBLista.ResumeLayout(False)
        CType(Me.ErrValida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLeyenda.ResumeLayout(False)
        Me.gbLeyenda.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAnio As System.Windows.Forms.TextBox
    Friend WithEvents lblAnio As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GBPresentación As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nudPresentacion As System.Windows.Forms.NumericUpDown
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkVigencia As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents dgvPresentacion As System.Windows.Forms.DataGridView
    Friend WithEvents GBLista As System.Windows.Forms.GroupBox
    Friend WithEvents ErrValida As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents gbLeyenda As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblVigente As System.Windows.Forms.Label
    Friend WithEvents cdNro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdVigencia As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
