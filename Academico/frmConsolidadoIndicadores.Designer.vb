<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsolidadoIndicadores
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
        Me.txtAnio = New System.Windows.Forms.TextBox
        Me.lblAnioLectivo = New System.Windows.Forms.Label
        Me.gbExportar = New System.Windows.Forms.GroupBox
        Me.gbNomina = New System.Windows.Forms.GroupBox
        Me.cboSeccion = New System.Windows.Forms.ComboBox
        Me.cboGrado = New System.Windows.Forms.ComboBox
        Me.cboNivel = New System.Windows.Forms.ComboBox
        Me.lblSeccion = New System.Windows.Forms.Label
        Me.lblNivel = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.pbAvance = New System.Windows.Forms.ProgressBar
        Me.btnExportar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.ErrLibretra = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gbExportar.SuspendLayout()
        Me.gbNomina.SuspendLayout()
        CType(Me.ErrLibretra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAnio
        '
        Me.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnio.Location = New System.Drawing.Point(85, 16)
        Me.txtAnio.Multiline = True
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.ReadOnly = True
        Me.txtAnio.Size = New System.Drawing.Size(234, 24)
        Me.txtAnio.TabIndex = 1
        Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAnioLectivo
        '
        Me.lblAnioLectivo.AutoSize = True
        Me.lblAnioLectivo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnioLectivo.Location = New System.Drawing.Point(21, 19)
        Me.lblAnioLectivo.Name = "lblAnioLectivo"
        Me.lblAnioLectivo.Size = New System.Drawing.Size(48, 15)
        Me.lblAnioLectivo.TabIndex = 0
        Me.lblAnioLectivo.Text = "&Periodo"
        '
        'gbExportar
        '
        Me.gbExportar.Controls.Add(Me.gbNomina)
        Me.gbExportar.Controls.Add(Me.pbAvance)
        Me.gbExportar.Location = New System.Drawing.Point(24, 57)
        Me.gbExportar.Name = "gbExportar"
        Me.gbExportar.Size = New System.Drawing.Size(319, 188)
        Me.gbExportar.TabIndex = 2
        Me.gbExportar.TabStop = False
        Me.gbExportar.Text = "Generar Consolidado"
        '
        'gbNomina
        '
        Me.gbNomina.Controls.Add(Me.cboSeccion)
        Me.gbNomina.Controls.Add(Me.cboGrado)
        Me.gbNomina.Controls.Add(Me.cboNivel)
        Me.gbNomina.Controls.Add(Me.lblSeccion)
        Me.gbNomina.Controls.Add(Me.lblNivel)
        Me.gbNomina.Controls.Add(Me.Label1)
        Me.gbNomina.Location = New System.Drawing.Point(16, 27)
        Me.gbNomina.Name = "gbNomina"
        Me.gbNomina.Size = New System.Drawing.Size(279, 112)
        Me.gbNomina.TabIndex = 0
        Me.gbNomina.TabStop = False
        '
        'cboSeccion
        '
        Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeccion.FormattingEnabled = True
        Me.cboSeccion.Location = New System.Drawing.Point(108, 77)
        Me.cboSeccion.Name = "cboSeccion"
        Me.cboSeccion.Size = New System.Drawing.Size(139, 21)
        Me.cboSeccion.TabIndex = 5
        '
        'cboGrado
        '
        Me.cboGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGrado.FormattingEnabled = True
        Me.cboGrado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboGrado.Items.AddRange(New Object() {"Todos"})
        Me.cboGrado.Location = New System.Drawing.Point(108, 48)
        Me.cboGrado.Name = "cboGrado"
        Me.cboGrado.Size = New System.Drawing.Size(139, 21)
        Me.cboGrado.TabIndex = 3
        '
        'cboNivel
        '
        Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNivel.FormattingEnabled = True
        Me.cboNivel.Location = New System.Drawing.Point(108, 19)
        Me.cboNivel.Name = "cboNivel"
        Me.cboNivel.Size = New System.Drawing.Size(139, 21)
        Me.cboNivel.TabIndex = 1
        '
        'lblSeccion
        '
        Me.lblSeccion.AutoSize = True
        Me.lblSeccion.Location = New System.Drawing.Point(44, 81)
        Me.lblSeccion.Name = "lblSeccion"
        Me.lblSeccion.Size = New System.Drawing.Size(46, 13)
        Me.lblSeccion.TabIndex = 4
        Me.lblSeccion.Text = "&Sección"
        '
        'lblNivel
        '
        Me.lblNivel.AutoSize = True
        Me.lblNivel.Location = New System.Drawing.Point(59, 23)
        Me.lblNivel.Name = "lblNivel"
        Me.lblNivel.Size = New System.Drawing.Size(31, 13)
        Me.lblNivel.TabIndex = 0
        Me.lblNivel.Text = "&Nivel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "&Grado"
        '
        'pbAvance
        '
        Me.pbAvance.BackColor = System.Drawing.Color.White
        Me.pbAvance.Location = New System.Drawing.Point(16, 155)
        Me.pbAvance.Name = "pbAvance"
        Me.pbAvance.Size = New System.Drawing.Size(279, 20)
        Me.pbAvance.TabIndex = 1
        '
        'btnExportar
        '
        Me.btnExportar.BackColor = System.Drawing.Color.White
        Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(371, 57)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(110, 52)
        Me.btnExportar.TabIndex = 3
        Me.btnExportar.Text = "&Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(371, 198)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(110, 58)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'ErrLibretra
        '
        Me.ErrLibretra.ContainerControl = Me
        '
        'frmConsolidadoIndicadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 284)
        Me.Controls.Add(Me.gbExportar)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.lblAnioLectivo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsolidadoIndicadores"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consolidado Aula - Inicial y Primaria"
        Me.gbExportar.ResumeLayout(False)
        Me.gbNomina.ResumeLayout(False)
        Me.gbNomina.PerformLayout()
        CType(Me.ErrLibretra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
  Friend WithEvents txtAnio As System.Windows.Forms.TextBox
  Friend WithEvents lblAnioLectivo As System.Windows.Forms.Label
  Friend WithEvents gbExportar As System.Windows.Forms.GroupBox
  Friend WithEvents gbNomina As System.Windows.Forms.GroupBox
  Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents cboGrado As System.Windows.Forms.ComboBox
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents lblNivel As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents pbAvance As System.Windows.Forms.ProgressBar
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents ErrLibretra As System.Windows.Forms.ErrorProvider
End Class
