<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionMatriculaBuscar
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.gbAlumnos = New System.Windows.Forms.GroupBox()
    Me.dgvmatriculas = New System.Windows.Forms.DataGridView()
    Me.gbAnioLectivo = New System.Windows.Forms.GroupBox()
    Me.cboSeccion = New System.Windows.Forms.ComboBox()
    Me.lblSeccion = New System.Windows.Forms.Label()
    Me.cbanio = New System.Windows.Forms.ComboBox()
    Me.lblAnio = New System.Windows.Forms.Label()
    Me.cboNivel = New System.Windows.Forms.ComboBox()
    Me.lblNivel = New System.Windows.Forms.Label()
    Me.btnBuscar = New System.Windows.Forms.Button()
    Me.btnAnular = New System.Windows.Forms.Button()
    Me.btnSeleccionar = New System.Windows.Forms.Button()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.lblLeyenda = New System.Windows.Forms.Label()
    Me.cdEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdalumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdApoderado = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdfechaMat = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.colvigencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdResponsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.gbAlumnos.SuspendLayout()
    CType(Me.dgvmatriculas, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbAnioLectivo.SuspendLayout()
    Me.SuspendLayout()
    '
    'gbAlumnos
    '
    Me.gbAlumnos.Controls.Add(Me.dgvmatriculas)
    Me.gbAlumnos.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbAlumnos.Location = New System.Drawing.Point(14, 99)
    Me.gbAlumnos.Name = "gbAlumnos"
    Me.gbAlumnos.Size = New System.Drawing.Size(755, 412)
    Me.gbAlumnos.TabIndex = 2
    Me.gbAlumnos.TabStop = False
    Me.gbAlumnos.Text = "Alumnos"
    '
    'dgvmatriculas
    '
    Me.dgvmatriculas.AllowUserToAddRows = False
    Me.dgvmatriculas.AllowUserToDeleteRows = False
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgvmatriculas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvmatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvmatriculas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdEstado, Me.cdalumno, Me.cdApoderado, Me.cdfechaMat, Me.colvigencia, Me.cdResponsable})
    Me.dgvmatriculas.Location = New System.Drawing.Point(20, 26)
    Me.dgvmatriculas.MultiSelect = False
    Me.dgvmatriculas.Name = "dgvmatriculas"
    Me.dgvmatriculas.ReadOnly = True
    Me.dgvmatriculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvmatriculas.Size = New System.Drawing.Size(714, 373)
    Me.dgvmatriculas.TabIndex = 0
    '
    'gbAnioLectivo
    '
    Me.gbAnioLectivo.Controls.Add(Me.cboSeccion)
    Me.gbAnioLectivo.Controls.Add(Me.lblSeccion)
    Me.gbAnioLectivo.Controls.Add(Me.cbanio)
    Me.gbAnioLectivo.Controls.Add(Me.lblAnio)
    Me.gbAnioLectivo.Controls.Add(Me.cboNivel)
    Me.gbAnioLectivo.Controls.Add(Me.lblNivel)
    Me.gbAnioLectivo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbAnioLectivo.Location = New System.Drawing.Point(14, 17)
    Me.gbAnioLectivo.Name = "gbAnioLectivo"
    Me.gbAnioLectivo.Size = New System.Drawing.Size(755, 61)
    Me.gbAnioLectivo.TabIndex = 0
    Me.gbAnioLectivo.TabStop = False
    Me.gbAnioLectivo.Text = "Año Lectivo"
    '
    'cboSeccion
    '
    Me.cboSeccion.BackColor = System.Drawing.SystemColors.Info
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(595, 23)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(132, 24)
    Me.cboSeccion.TabIndex = 5
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSeccion.Location = New System.Drawing.Point(498, 28)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(93, 15)
    Me.lblSeccion.TabIndex = 4
    Me.lblSeccion.Text = "&Grado y sección"
    '
    'cbanio
    '
    Me.cbanio.BackColor = System.Drawing.SystemColors.Info
    Me.cbanio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbanio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbanio.FormattingEnabled = True
    Me.cbanio.Location = New System.Drawing.Point(62, 23)
    Me.cbanio.Name = "cbanio"
    Me.cbanio.Size = New System.Drawing.Size(75, 24)
    Me.cbanio.TabIndex = 1
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAnio.Location = New System.Drawing.Point(28, 28)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(31, 15)
    Me.lblAnio.TabIndex = 0
    Me.lblAnio.Text = "Añ&o"
    '
    'cboNivel
    '
    Me.cboNivel.BackColor = System.Drawing.SystemColors.Info
    Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNivel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Location = New System.Drawing.Point(270, 23)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(132, 24)
    Me.cboNivel.TabIndex = 3
    '
    'lblNivel
    '
    Me.lblNivel.AutoSize = True
    Me.lblNivel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNivel.Location = New System.Drawing.Point(232, 28)
    Me.lblNivel.Name = "lblNivel"
    Me.lblNivel.Size = New System.Drawing.Size(35, 15)
    Me.lblNivel.TabIndex = 2
    Me.lblNivel.Text = "&Nivel"
    '
    'btnBuscar
    '
    Me.btnBuscar.BackColor = System.Drawing.Color.White
    Me.btnBuscar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscar.Location = New System.Drawing.Point(787, 26)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(110, 52)
    Me.btnBuscar.TabIndex = 1
    Me.btnBuscar.Text = "&Buscar"
    Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscar.UseVisualStyleBackColor = False
    '
    'btnAnular
    '
    Me.btnAnular.BackColor = System.Drawing.Color.White
    Me.btnAnular.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAnular.Location = New System.Drawing.Point(787, 273)
    Me.btnAnular.Name = "btnAnular"
    Me.btnAnular.Size = New System.Drawing.Size(110, 52)
    Me.btnAnular.TabIndex = 4
    Me.btnAnular.Text = "Anular &Matrícula"
    Me.btnAnular.UseVisualStyleBackColor = False
    '
    'btnSeleccionar
    '
    Me.btnSeleccionar.BackColor = System.Drawing.Color.White
    Me.btnSeleccionar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnSeleccionar.Location = New System.Drawing.Point(787, 220)
    Me.btnSeleccionar.Name = "btnSeleccionar"
    Me.btnSeleccionar.Size = New System.Drawing.Size(110, 52)
    Me.btnSeleccionar.TabIndex = 3
    Me.btnSeleccionar.Text = "&Seleccionar"
    Me.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnSeleccionar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(787, 459)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
    Me.btnCancelar.TabIndex = 5
    Me.btnCancelar.Text = "C&ancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'lblLeyenda
    '
    Me.lblLeyenda.AutoSize = True
    Me.lblLeyenda.BackColor = System.Drawing.Color.LightSkyBlue
    Me.lblLeyenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblLeyenda.Location = New System.Drawing.Point(793, 136)
    Me.lblLeyenda.Name = "lblLeyenda"
    Me.lblLeyenda.Size = New System.Drawing.Size(96, 20)
    Me.lblLeyenda.TabIndex = 13
    Me.lblLeyenda.Text = "Buscar: F5"
    '
    'cdEstado
    '
    Me.cdEstado.DataPropertyName = "DescripcionEstado"
    Me.cdEstado.HeaderText = "Estado"
    Me.cdEstado.Name = "cdEstado"
    Me.cdEstado.ReadOnly = True
    Me.cdEstado.Width = 70
    '
    'cdalumno
    '
    Me.cdalumno.DataPropertyName = "NombreAlumno"
    Me.cdalumno.HeaderText = "Alumno"
    Me.cdalumno.Name = "cdalumno"
    Me.cdalumno.ReadOnly = True
    Me.cdalumno.Width = 200
    '
    'cdApoderado
    '
    Me.cdApoderado.DataPropertyName = "codigoApoderdao"
    Me.cdApoderado.HeaderText = "Apoderado"
    Me.cdApoderado.Name = "cdApoderado"
    Me.cdApoderado.ReadOnly = True
    Me.cdApoderado.Width = 200
    '
    'cdfechaMat
    '
    Me.cdfechaMat.DataPropertyName = "fechaMat"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    DataGridViewCellStyle2.Format = "d"
    DataGridViewCellStyle2.NullValue = Nothing
    Me.cdfechaMat.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdfechaMat.HeaderText = "Fecha_Matrícula"
    Me.cdfechaMat.Name = "cdfechaMat"
    Me.cdfechaMat.ReadOnly = True
    '
    'colvigencia
    '
    Me.colvigencia.DataPropertyName = "visualizarvigencia"
    Me.colvigencia.HeaderText = "Vigente"
    Me.colvigencia.Name = "colvigencia"
    Me.colvigencia.ReadOnly = True
    Me.colvigencia.Width = 60
    '
    'cdResponsable
    '
    Me.cdResponsable.DataPropertyName = "NombreResponsable"
    Me.cdResponsable.HeaderText = "Responsable"
    Me.cdResponsable.Name = "cdResponsable"
    Me.cdResponsable.ReadOnly = True
    Me.cdResponsable.Width = 200
    '
    'frmGestionMatriculaBuscar
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(911, 528)
    Me.Controls.Add(Me.lblLeyenda)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.btnSeleccionar)
    Me.Controls.Add(Me.btnAnular)
    Me.Controls.Add(Me.btnBuscar)
    Me.Controls.Add(Me.gbAnioLectivo)
    Me.Controls.Add(Me.gbAlumnos)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.KeyPreview = True
    Me.MaximizeBox = False
    Me.Name = "frmGestionMatriculaBuscar"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Lista de Matriculados"
    Me.gbAlumnos.ResumeLayout(False)
    CType(Me.dgvmatriculas, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbAnioLectivo.ResumeLayout(False)
    Me.gbAnioLectivo.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents gbAlumnos As System.Windows.Forms.GroupBox
  Friend WithEvents dgvmatriculas As System.Windows.Forms.DataGridView
  Friend WithEvents gbAnioLectivo As System.Windows.Forms.GroupBox
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents lblNivel As System.Windows.Forms.Label
  Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents cbanio As System.Windows.Forms.ComboBox
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents btnAnular As System.Windows.Forms.Button
  Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents lblLeyenda As System.Windows.Forms.Label
  Friend WithEvents cdEstado As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdalumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdApoderado As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdfechaMat As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents colvigencia As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdResponsable As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
