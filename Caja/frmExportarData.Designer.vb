<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportarData
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.cboEntidadFinanciera = New System.Windows.Forms.ComboBox()
    Me.lbfecha = New System.Windows.Forms.Label()
    Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.btnExportar = New System.Windows.Forms.Button()
    Me.pbProgreso = New System.Windows.Forms.ProgressBar()
    Me.bcwProgreso = New System.ComponentModel.BackgroundWorker()
    Me.btnVer = New System.Windows.Forms.Button()
    Me.btnExportarIntegrantesBIF = New System.Windows.Forms.Button()
    Me.cboCuenta = New System.Windows.Forms.ComboBox()
    Me.lblCuenta = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.nudMeses = New System.Windows.Forms.NumericUpDown()
    CType(Me.nudMeses, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(22, 46)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(95, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Entidad &Financiera"
    '
    'cboEntidadFinanciera
    '
    Me.cboEntidadFinanciera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboEntidadFinanciera.FormattingEnabled = True
    Me.cboEntidadFinanciera.Location = New System.Drawing.Point(123, 38)
    Me.cboEntidadFinanciera.Name = "cboEntidadFinanciera"
    Me.cboEntidadFinanciera.Size = New System.Drawing.Size(243, 21)
    Me.cboEntidadFinanciera.TabIndex = 1
    '
    'lbfecha
    '
    Me.lbfecha.AutoSize = True
    Me.lbfecha.Location = New System.Drawing.Point(80, 130)
    Me.lbfecha.Name = "lbfecha"
    Me.lbfecha.Size = New System.Drawing.Size(37, 13)
    Me.lbfecha.TabIndex = 4
    Me.lbfecha.Text = "Fec&ha"
    '
    'dtpFecha
    '
    Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFecha.Location = New System.Drawing.Point(123, 124)
    Me.dtpFecha.Name = "dtpFecha"
    Me.dtpFecha.Size = New System.Drawing.Size(91, 20)
    Me.dtpFecha.TabIndex = 5
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(402, 315)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 58)
    Me.btnCerrar.TabIndex = 11
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'btnExportar
    '
    Me.btnExportar.BackColor = System.Drawing.Color.White
    Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnExportar.Location = New System.Drawing.Point(51, 315)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(110, 58)
    Me.btnExportar.TabIndex = 9
    Me.btnExportar.Text = "&Exportar"
    Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnExportar.UseVisualStyleBackColor = False
    '
    'pbProgreso
    '
    Me.pbProgreso.Location = New System.Drawing.Point(51, 244)
    Me.pbProgreso.Name = "pbProgreso"
    Me.pbProgreso.Size = New System.Drawing.Size(461, 33)
    Me.pbProgreso.TabIndex = 8
    '
    'bcwProgreso
    '
    Me.bcwProgreso.WorkerReportsProgress = True
    Me.bcwProgreso.WorkerSupportsCancellation = True
    '
    'btnVer
    '
    Me.btnVer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnVer.BackColor = System.Drawing.Color.White
    Me.btnVer.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnVer.Location = New System.Drawing.Point(286, 315)
    Me.btnVer.Name = "btnVer"
    Me.btnVer.Size = New System.Drawing.Size(110, 58)
    Me.btnVer.TabIndex = 10
    Me.btnVer.Text = "&Ver"
    Me.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnVer.UseVisualStyleBackColor = False
    '
    'btnExportarIntegrantesBIF
    '
    Me.btnExportarIntegrantesBIF.BackColor = System.Drawing.Color.White
    Me.btnExportarIntegrantesBIF.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportarIntegrantesBIF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnExportarIntegrantesBIF.Location = New System.Drawing.Point(402, 124)
    Me.btnExportarIntegrantesBIF.Name = "btnExportarIntegrantesBIF"
    Me.btnExportarIntegrantesBIF.Size = New System.Drawing.Size(110, 58)
    Me.btnExportarIntegrantesBIF.TabIndex = 7
    Me.btnExportarIntegrantesBIF.Text = "E&xportar Integrantes"
    Me.btnExportarIntegrantesBIF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnExportarIntegrantesBIF.UseVisualStyleBackColor = False
    '
    'cboCuenta
    '
    Me.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCuenta.FormattingEnabled = True
    Me.cboCuenta.Location = New System.Drawing.Point(123, 79)
    Me.cboCuenta.Name = "cboCuenta"
    Me.cboCuenta.Size = New System.Drawing.Size(243, 21)
    Me.cboCuenta.TabIndex = 3
    '
    'lblCuenta
    '
    Me.lblCuenta.AutoSize = True
    Me.lblCuenta.Location = New System.Drawing.Point(76, 87)
    Me.lblCuenta.Name = "lblCuenta"
    Me.lblCuenta.Size = New System.Drawing.Size(41, 13)
    Me.lblCuenta.TabIndex = 2
    Me.lblCuenta.Text = "C&uenta"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(48, 206)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(248, 13)
    Me.Label2.TabIndex = 12
    Me.Label2.Text = "&Agregar meses a los pagos sin fecha de caducidad"
    '
    'nudMeses
    '
    Me.nudMeses.Location = New System.Drawing.Point(315, 199)
    Me.nudMeses.Name = "nudMeses"
    Me.nudMeses.Size = New System.Drawing.Size(51, 20)
    Me.nudMeses.TabIndex = 13
    Me.nudMeses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
    '
    'frmExportarData
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCerrar
    Me.ClientSize = New System.Drawing.Size(524, 387)
    Me.Controls.Add(Me.nudMeses)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.cboCuenta)
    Me.Controls.Add(Me.lblCuenta)
    Me.Controls.Add(Me.btnExportarIntegrantesBIF)
    Me.Controls.Add(Me.btnVer)
    Me.Controls.Add(Me.pbProgreso)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.dtpFecha)
    Me.Controls.Add(Me.lbfecha)
    Me.Controls.Add(Me.cboEntidadFinanciera)
    Me.Controls.Add(Me.Label1)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.Name = "frmExportarData"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Exportar Data"
    CType(Me.nudMeses, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents cboEntidadFinanciera As System.Windows.Forms.ComboBox
  Friend WithEvents lbfecha As System.Windows.Forms.Label
  Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents pbProgreso As System.Windows.Forms.ProgressBar
  Friend WithEvents bcwProgreso As System.ComponentModel.BackgroundWorker
  Friend WithEvents btnVer As System.Windows.Forms.Button
  Friend WithEvents btnExportarIntegrantesBIF As System.Windows.Forms.Button
  Friend WithEvents cboCuenta As System.Windows.Forms.ComboBox
  Friend WithEvents lblCuenta As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents nudMeses As System.Windows.Forms.NumericUpDown
End Class
