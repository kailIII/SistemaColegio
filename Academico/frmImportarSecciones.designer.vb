<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportarSecciones
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImportarSecciones))
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.btnSalir = New System.Windows.Forms.Button
    Me.btnGenerar = New System.Windows.Forms.Button
    Me.cbanio = New System.Windows.Forms.ComboBox
    Me.lblAnio = New System.Windows.Forms.Label
    Me.dgvSeccion = New System.Windows.Forms.DataGridView
    Me.colgenerar = New System.Windows.Forms.DataGridViewCheckBoxColumn
    Me.colcodigoG = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.colletra = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.colNivelAcad = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.colGradoSeccion = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.coldocente = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.colTurno = New System.Windows.Forms.DataGridViewComboBoxColumn
    Me.colAula = New System.Windows.Forms.DataGridViewComboBoxColumn
    Me.coltutor = New System.Windows.Forms.DataGridViewComboBoxColumn
    Me.colimagen = New System.Windows.Forms.DataGridViewImageColumn
    Me.colresultado = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.lblAnioAct = New System.Windows.Forms.Label
    Me.txtanioactual = New System.Windows.Forms.TextBox
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.cboSeleccion = New System.Windows.Forms.ComboBox
    Me.Label2 = New System.Windows.Forms.Label
    CType(Me.dgvSeccion, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'btnSalir
    '
    Me.btnSalir.BackColor = System.Drawing.Color.White
    Me.btnSalir.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
    Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnSalir.Location = New System.Drawing.Point(826, 448)
    Me.btnSalir.Name = "btnSalir"
    Me.btnSalir.Size = New System.Drawing.Size(110, 52)
    Me.btnSalir.TabIndex = 5
    Me.btnSalir.Tag = ""
    Me.btnSalir.Text = "&Cerrar"
    Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnSalir.UseVisualStyleBackColor = False
    '
    'btnGenerar
    '
    Me.btnGenerar.BackColor = System.Drawing.Color.White
    Me.btnGenerar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnGenerar.Location = New System.Drawing.Point(826, 186)
    Me.btnGenerar.Name = "btnGenerar"
    Me.btnGenerar.Size = New System.Drawing.Size(110, 52)
    Me.btnGenerar.TabIndex = 4
    Me.btnGenerar.Tag = ""
    Me.btnGenerar.Text = "&Importar"
    Me.btnGenerar.UseVisualStyleBackColor = False
    '
    'cbanio
    '
    Me.cbanio.BackColor = System.Drawing.SystemColors.Info
    Me.cbanio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbanio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbanio.FormattingEnabled = True
    Me.cbanio.Location = New System.Drawing.Point(158, 15)
    Me.cbanio.Name = "cbanio"
    Me.cbanio.Size = New System.Drawing.Size(75, 21)
    Me.cbanio.TabIndex = 3
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAnio.Location = New System.Drawing.Point(37, 18)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(118, 13)
    Me.lblAnio.TabIndex = 2
    Me.lblAnio.Text = "Importar del Año &lectivo"
    '
    'dgvSeccion
    '
    Me.dgvSeccion.AllowUserToAddRows = False
    Me.dgvSeccion.AllowUserToDeleteRows = False
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvSeccion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
    Me.dgvSeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvSeccion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colgenerar, Me.colcodigoG, Me.colletra, Me.colNivelAcad, Me.colGradoSeccion, Me.coldocente, Me.colTurno, Me.colAula, Me.coltutor, Me.colimagen, Me.colresultado})
    DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgvSeccion.DefaultCellStyle = DataGridViewCellStyle9
    Me.dgvSeccion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
    Me.dgvSeccion.Location = New System.Drawing.Point(16, 72)
    Me.dgvSeccion.Name = "dgvSeccion"
    DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    Me.dgvSeccion.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
    Me.dgvSeccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvSeccion.Size = New System.Drawing.Size(786, 428)
    Me.dgvSeccion.TabIndex = 3
    '
    'colgenerar
    '
    Me.colgenerar.HeaderText = "Importar"
    Me.colgenerar.Name = "colgenerar"
    Me.colgenerar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
    Me.colgenerar.Width = 50
    '
    'colcodigoG
    '
    Me.colcodigoG.DataPropertyName = "codigoG"
    Me.colcodigoG.HeaderText = ""
    Me.colcodigoG.Name = "colcodigoG"
    Me.colcodigoG.Visible = False
    '
    'colletra
    '
    Me.colletra.DataPropertyName = "letra"
    Me.colletra.HeaderText = ""
    Me.colletra.Name = "colletra"
    Me.colletra.Visible = False
    '
    'colNivelAcad
    '
    Me.colNivelAcad.DataPropertyName = "nombreNivel"
    DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.colNivelAcad.DefaultCellStyle = DataGridViewCellStyle7
    Me.colNivelAcad.HeaderText = "Nivel Academico"
    Me.colNivelAcad.Name = "colNivelAcad"
    Me.colNivelAcad.Width = 120
    '
    'colGradoSeccion
    '
    Me.colGradoSeccion.DataPropertyName = "numeroletra"
    DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.colGradoSeccion.DefaultCellStyle = DataGridViewCellStyle8
    Me.colGradoSeccion.HeaderText = "Grado y Seccion"
    Me.colGradoSeccion.Name = "colGradoSeccion"
    Me.colGradoSeccion.Width = 120
    '
    'coldocente
    '
    Me.coldocente.DataPropertyName = "codigoTutor"
    Me.coldocente.HeaderText = ""
    Me.coldocente.Name = "coldocente"
    Me.coldocente.Visible = False
    '
    'colTurno
    '
    Me.colTurno.DataPropertyName = "CodigoTurno"
    Me.colTurno.HeaderText = "Turno"
    Me.colTurno.Name = "colTurno"
    Me.colTurno.Width = 80
    '
    'colAula
    '
    Me.colAula.DataPropertyName = "nombreAulaLocal"
    Me.colAula.HeaderText = "Aula"
    Me.colAula.Name = "colAula"
    '
    'coltutor
    '
    Me.coltutor.DataPropertyName = "nombreCompleto"
    Me.coltutor.HeaderText = "Tutor"
    Me.coltutor.Name = "coltutor"
    Me.coltutor.Width = 220
    '
    'colimagen
    '
    Me.colimagen.HeaderText = ""
    Me.colimagen.Image = CType(resources.GetObject("colimagen.Image"), System.Drawing.Image)
    Me.colimagen.Name = "colimagen"
    Me.colimagen.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.colimagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.colimagen.Width = 40
    '
    'colresultado
    '
    Me.colresultado.HeaderText = "Resultado"
    Me.colresultado.Name = "colresultado"
    Me.colresultado.Visible = False
    Me.colresultado.Width = 150
    '
    'lblAnioAct
    '
    Me.lblAnioAct.AutoSize = True
    Me.lblAnioAct.Location = New System.Drawing.Point(259, 18)
    Me.lblAnioAct.Name = "lblAnioAct"
    Me.lblAnioAct.Size = New System.Drawing.Size(97, 13)
    Me.lblAnioAct.TabIndex = 0
    Me.lblAnioAct.Text = "Año Lectivo Actual"
    '
    'txtanioactual
    '
    Me.txtanioactual.BackColor = System.Drawing.SystemColors.Info
    Me.txtanioactual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtanioactual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtanioactual.Location = New System.Drawing.Point(359, 15)
    Me.txtanioactual.Name = "txtanioactual"
    Me.txtanioactual.ReadOnly = True
    Me.txtanioactual.Size = New System.Drawing.Size(71, 20)
    Me.txtanioactual.TabIndex = 1
    Me.txtanioactual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.txtanioactual)
    Me.GroupBox1.Controls.Add(Me.lblAnioAct)
    Me.GroupBox1.Controls.Add(Me.cbanio)
    Me.GroupBox1.Controls.Add(Me.lblAnio)
    Me.GroupBox1.Location = New System.Drawing.Point(16, 12)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(467, 42)
    Me.GroupBox1.TabIndex = 0
    Me.GroupBox1.TabStop = False
    '
    'cboSeleccion
    '
    Me.cboSeleccion.BackColor = System.Drawing.SystemColors.Info
    Me.cboSeleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeleccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboSeleccion.FormattingEnabled = True
    Me.cboSeleccion.Items.AddRange(New Object() {"Seleccionar Todos", "Seleccionar Ninguno", "Seleccionar mismo grado", "Seleccionar mismo nivel", "Seleccion única"})
    Me.cboSeleccion.Location = New System.Drawing.Point(655, 27)
    Me.cboSeleccion.Name = "cboSeleccion"
    Me.cboSeleccion.Size = New System.Drawing.Size(147, 21)
    Me.cboSeleccion.TabIndex = 2
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(547, 30)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(104, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Modos de Selección"
    '
    'frmImportarSecciones
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(953, 527)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.cboSeleccion)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.btnSalir)
    Me.Controls.Add(Me.btnGenerar)
    Me.Controls.Add(Me.dgvSeccion)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmImportarSecciones"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Importar Secciones"
    CType(Me.dgvSeccion, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnSalir As System.Windows.Forms.Button
  Friend WithEvents btnGenerar As System.Windows.Forms.Button
  Friend WithEvents cbanio As System.Windows.Forms.ComboBox
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents dgvSeccion As System.Windows.Forms.DataGridView
  Friend WithEvents lblAnioAct As System.Windows.Forms.Label
    Friend WithEvents txtanioactual As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboSeleccion As System.Windows.Forms.ComboBox
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents colgenerar As System.Windows.Forms.DataGridViewCheckBoxColumn
  Friend WithEvents colcodigoG As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colletra As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colNivelAcad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colGradoSeccion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents coldocente As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colTurno As System.Windows.Forms.DataGridViewComboBoxColumn
  Friend WithEvents colAula As System.Windows.Forms.DataGridViewComboBoxColumn
  Friend WithEvents coltutor As System.Windows.Forms.DataGridViewComboBoxColumn
  Friend WithEvents colimagen As System.Windows.Forms.DataGridViewImageColumn
  Friend WithEvents colresultado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
