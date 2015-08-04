<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteIngresoCalificacionesPrimaria
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
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.lblPeriodo = New System.Windows.Forms.Label
    Me.txtNivel = New System.Windows.Forms.TextBox
    Me.lblNivel = New System.Windows.Forms.Label
    Me.btnListar = New System.Windows.Forms.Button
    Me.dgvDocentes = New System.Windows.Forms.DataGridView
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnExportar = New System.Windows.Forms.Button
    Me.cboPeriodo = New System.Windows.Forms.ComboBox
    Me.pbAvance = New System.Windows.Forms.ProgressBar
    Me.sfdArchivos = New System.Windows.Forms.SaveFileDialog
    Me.cdDocente = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdSeccion = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCurso = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdAlumnos = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdIndicadores = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdTotalNotas = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdIngresadas = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCalificaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.dgvDocentes, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblPeriodo
    '
    Me.lblPeriodo.AutoSize = True
    Me.lblPeriodo.Location = New System.Drawing.Point(15, 76)
    Me.lblPeriodo.Name = "lblPeriodo"
    Me.lblPeriodo.Size = New System.Drawing.Size(43, 13)
    Me.lblPeriodo.TabIndex = 2
    Me.lblPeriodo.Text = "&Periodo"
    '
    'txtNivel
    '
    Me.txtNivel.Location = New System.Drawing.Point(76, 31)
    Me.txtNivel.Name = "txtNivel"
    Me.txtNivel.ReadOnly = True
    Me.txtNivel.Size = New System.Drawing.Size(149, 20)
    Me.txtNivel.TabIndex = 1
    '
    'lblNivel
    '
    Me.lblNivel.AutoSize = True
    Me.lblNivel.Location = New System.Drawing.Point(15, 38)
    Me.lblNivel.Name = "lblNivel"
    Me.lblNivel.Size = New System.Drawing.Size(31, 13)
    Me.lblNivel.TabIndex = 0
    Me.lblNivel.Text = "&Nivel"
    '
    'btnListar
    '
    Me.btnListar.Location = New System.Drawing.Point(340, 66)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(87, 23)
    Me.btnListar.TabIndex = 4
    Me.btnListar.Text = "&Listar"
    Me.btnListar.UseVisualStyleBackColor = True
    '
    'dgvDocentes
    '
    Me.dgvDocentes.AllowUserToAddRows = False
    Me.dgvDocentes.AllowUserToDeleteRows = False
    Me.dgvDocentes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvDocentes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdDocente, Me.cdSeccion, Me.cdCurso, Me.cdAlumnos, Me.cdIndicadores, Me.cdTotalNotas, Me.cdIngresadas, Me.cdCalificaciones})
    Me.dgvDocentes.Location = New System.Drawing.Point(18, 107)
    Me.dgvDocentes.MultiSelect = False
    Me.dgvDocentes.Name = "dgvDocentes"
    Me.dgvDocentes.ReadOnly = True
    Me.dgvDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvDocentes.Size = New System.Drawing.Size(574, 245)
    Me.dgvDocentes.TabIndex = 5
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.Location = New System.Drawing.Point(505, 359)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(87, 23)
    Me.btnCerrar.TabIndex = 7
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.UseVisualStyleBackColor = True
    '
    'btnExportar
    '
    Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnExportar.Location = New System.Drawing.Point(18, 359)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(87, 23)
    Me.btnExportar.TabIndex = 6
    Me.btnExportar.Text = "&Exportar"
    Me.btnExportar.UseVisualStyleBackColor = True
    '
    'cboPeriodo
    '
    Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboPeriodo.FormattingEnabled = True
    Me.cboPeriodo.Location = New System.Drawing.Point(76, 68)
    Me.cboPeriodo.Name = "cboPeriodo"
    Me.cboPeriodo.Size = New System.Drawing.Size(258, 21)
    Me.cboPeriodo.TabIndex = 3
    '
    'pbAvance
    '
    Me.pbAvance.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.pbAvance.Location = New System.Drawing.Point(111, 359)
    Me.pbAvance.Name = "pbAvance"
    Me.pbAvance.Size = New System.Drawing.Size(223, 23)
    Me.pbAvance.TabIndex = 8
    Me.pbAvance.Visible = False
    '
    'cdDocente
    '
    Me.cdDocente.DataPropertyName = "Docente"
    Me.cdDocente.HeaderText = "Docente"
    Me.cdDocente.Name = "cdDocente"
    Me.cdDocente.ReadOnly = True
    Me.cdDocente.Width = 250
    '
    'cdSeccion
    '
    Me.cdSeccion.DataPropertyName = "Seccion"
    Me.cdSeccion.HeaderText = "Sección"
    Me.cdSeccion.Name = "cdSeccion"
    Me.cdSeccion.ReadOnly = True
    Me.cdSeccion.Width = 80
    '
    'cdCurso
    '
    Me.cdCurso.DataPropertyName = "NombreCur"
    Me.cdCurso.HeaderText = "Curso"
    Me.cdCurso.Name = "cdCurso"
    Me.cdCurso.ReadOnly = True
    Me.cdCurso.Width = 90
    '
    'cdAlumnos
    '
    Me.cdAlumnos.DataPropertyName = "Alumnos"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdAlumnos.DefaultCellStyle = DataGridViewCellStyle1
    Me.cdAlumnos.HeaderText = "Alumnos"
    Me.cdAlumnos.Name = "cdAlumnos"
    Me.cdAlumnos.ReadOnly = True
    '
    'cdIndicadores
    '
    Me.cdIndicadores.DataPropertyName = "IndicadoresRegistrados"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdIndicadores.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdIndicadores.HeaderText = "Indicadores registrados"
    Me.cdIndicadores.Name = "cdIndicadores"
    Me.cdIndicadores.ReadOnly = True
    '
    'cdTotalNotas
    '
    Me.cdTotalNotas.DataPropertyName = "CalificacionesEsperadas"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle3.Format = "N0"
    DataGridViewCellStyle3.NullValue = Nothing
    Me.cdTotalNotas.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdTotalNotas.HeaderText = "Calificaciones esperadas"
    Me.cdTotalNotas.Name = "cdTotalNotas"
    Me.cdTotalNotas.ReadOnly = True
    '
    'cdIngresadas
    '
    Me.cdIngresadas.DataPropertyName = "CalificacionesRegistradas"
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle4.Format = "N0"
    Me.cdIngresadas.DefaultCellStyle = DataGridViewCellStyle4
    Me.cdIngresadas.HeaderText = "Calificaciones ingresadas"
    Me.cdIngresadas.Name = "cdIngresadas"
    Me.cdIngresadas.ReadOnly = True
    '
    'cdCalificaciones
    '
    Me.cdCalificaciones.DataPropertyName = "CalificacionesFaltantes"
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdCalificaciones.DefaultCellStyle = DataGridViewCellStyle5
    Me.cdCalificaciones.HeaderText = "Calificaciones faltantes"
    Me.cdCalificaciones.Name = "cdCalificaciones"
    Me.cdCalificaciones.ReadOnly = True
    '
    'frmReporteIngresoCalificacionesPrimaria
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(604, 394)
    Me.Controls.Add(Me.pbAvance)
    Me.Controls.Add(Me.cboPeriodo)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.dgvDocentes)
    Me.Controls.Add(Me.btnListar)
    Me.Controls.Add(Me.txtNivel)
    Me.Controls.Add(Me.lblNivel)
    Me.Controls.Add(Me.lblPeriodo)
    Me.Name = "frmReporteIngresoCalificacionesPrimaria"
    Me.Text = "Reporte de ingreso de calificaciones de secundaria"
    CType(Me.dgvDocentes, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblPeriodo As System.Windows.Forms.Label
  Friend WithEvents txtNivel As System.Windows.Forms.TextBox
  Friend WithEvents lblNivel As System.Windows.Forms.Label
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents dgvDocentes As System.Windows.Forms.DataGridView
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
  Friend WithEvents pbAvance As System.Windows.Forms.ProgressBar
  Friend WithEvents sfdArchivos As System.Windows.Forms.SaveFileDialog
  Friend WithEvents cdDocente As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdSeccion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCurso As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAlumnos As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdIndicadores As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdTotalNotas As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdIngresadas As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCalificaciones As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
