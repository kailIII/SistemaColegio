﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoAsistencia
  Inherits System.Windows.Forms.Form

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
    Me.lblDesde = New System.Windows.Forms.Label()
    Me.lblHasta = New System.Windows.Forms.Label()
    Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
    Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
    Me.dgvAsistencias = New System.Windows.Forms.DataGridView()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.cboSeccion = New System.Windows.Forms.ComboBox()
    Me.lblSeccion = New System.Windows.Forms.Label()
    Me.btnExportar = New System.Windows.Forms.Button()
    Me.btnListar = New System.Windows.Forms.Button()
    Me.pbAvance = New System.Windows.Forms.ProgressBar()
    Me.cboTipoRegistro = New System.Windows.Forms.ComboBox()
    Me.lblTipo = New System.Windows.Forms.Label()
    Me.cdFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdSeccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdMotivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdApoderado = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdResponsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdFechaJustificada = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdFechaFaltaTradanza = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cdPersonalRegistrador = New System.Windows.Forms.DataGridViewTextBoxColumn()
    CType(Me.dgvAsistencias, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblDesde
    '
    Me.lblDesde.AutoSize = True
    Me.lblDesde.Location = New System.Drawing.Point(13, 85)
    Me.lblDesde.Name = "lblDesde"
    Me.lblDesde.Size = New System.Drawing.Size(38, 13)
    Me.lblDesde.TabIndex = 4
    Me.lblDesde.Text = "Desde"
    '
    'lblHasta
    '
    Me.lblHasta.AutoSize = True
    Me.lblHasta.Location = New System.Drawing.Point(232, 85)
    Me.lblHasta.Name = "lblHasta"
    Me.lblHasta.Size = New System.Drawing.Size(35, 13)
    Me.lblHasta.TabIndex = 6
    Me.lblHasta.Text = "Hasta"
    '
    'dtpFechaIni
    '
    Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaIni.Location = New System.Drawing.Point(71, 78)
    Me.dtpFechaIni.Name = "dtpFechaIni"
    Me.dtpFechaIni.Size = New System.Drawing.Size(107, 20)
    Me.dtpFechaIni.TabIndex = 5
    '
    'dtpFechaFin
    '
    Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtpFechaFin.Location = New System.Drawing.Point(287, 78)
    Me.dtpFechaFin.Name = "dtpFechaFin"
    Me.dtpFechaFin.Size = New System.Drawing.Size(107, 20)
    Me.dtpFechaFin.TabIndex = 7
    '
    'dgvAsistencias
    '
    Me.dgvAsistencias.AllowUserToAddRows = False
    Me.dgvAsistencias.AllowUserToDeleteRows = False
    Me.dgvAsistencias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvAsistencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdFecha, Me.cdSeccion, Me.cdAlumno, Me.cdRegistro, Me.cdMotivo, Me.cdApoderado, Me.cdResponsable, Me.cdFechaJustificada, Me.cdFechaFaltaTradanza, Me.cdPersonalRegistrador})
    Me.dgvAsistencias.Location = New System.Drawing.Point(15, 111)
    Me.dgvAsistencias.MultiSelect = False
    Me.dgvAsistencias.Name = "dgvAsistencias"
    Me.dgvAsistencias.ReadOnly = True
    Me.dgvAsistencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvAsistencias.Size = New System.Drawing.Size(671, 328)
    Me.dgvAsistencias.TabIndex = 9
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.Location = New System.Drawing.Point(578, 451)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(86, 32)
    Me.btnCerrar.TabIndex = 12
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.UseVisualStyleBackColor = True
    '
    'cboSeccion
    '
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Items.AddRange(New Object() {"Faltas", "Faltas justificadas", "Tardanzas", "Tardanzas justificadas"})
    Me.cboSeccion.Location = New System.Drawing.Point(71, 28)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(196, 21)
    Me.cboSeccion.TabIndex = 1
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Location = New System.Drawing.Point(13, 36)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(46, 13)
    Me.lblSeccion.TabIndex = 0
    Me.lblSeccion.Text = "Sección"
    '
    'btnExportar
    '
    Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnExportar.Location = New System.Drawing.Point(12, 451)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(86, 32)
    Me.btnExportar.TabIndex = 10
    Me.btnExportar.Text = "E&xportar"
    Me.btnExportar.UseVisualStyleBackColor = True
    '
    'btnListar
    '
    Me.btnListar.Location = New System.Drawing.Point(440, 66)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(109, 32)
    Me.btnListar.TabIndex = 8
    Me.btnListar.Text = "&Listar"
    Me.btnListar.UseVisualStyleBackColor = True
    '
    'pbAvance
    '
    Me.pbAvance.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.pbAvance.Location = New System.Drawing.Point(113, 451)
    Me.pbAvance.Maximum = 1000
    Me.pbAvance.Name = "pbAvance"
    Me.pbAvance.Size = New System.Drawing.Size(281, 22)
    Me.pbAvance.TabIndex = 11
    Me.pbAvance.Visible = False
    '
    'cboTipoRegistro
    '
    Me.cboTipoRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoRegistro.FormattingEnabled = True
    Me.cboTipoRegistro.Location = New System.Drawing.Point(440, 28)
    Me.cboTipoRegistro.Name = "cboTipoRegistro"
    Me.cboTipoRegistro.Size = New System.Drawing.Size(109, 21)
    Me.cboTipoRegistro.TabIndex = 3
    '
    'lblTipo
    '
    Me.lblTipo.AutoSize = True
    Me.lblTipo.Location = New System.Drawing.Point(339, 31)
    Me.lblTipo.Name = "lblTipo"
    Me.lblTipo.Size = New System.Drawing.Size(85, 13)
    Me.lblTipo.TabIndex = 2
    Me.lblTipo.Text = "&Tipo de Registro"
    '
    'cdFecha
    '
    Me.cdFecha.DataPropertyName = "Fecha"
    DataGridViewCellStyle1.Format = "G"
    DataGridViewCellStyle1.NullValue = Nothing
    Me.cdFecha.DefaultCellStyle = DataGridViewCellStyle1
    Me.cdFecha.HeaderText = "Fecha"
    Me.cdFecha.Name = "cdFecha"
    Me.cdFecha.ReadOnly = True
    Me.cdFecha.Width = 80
    '
    'cdSeccion
    '
    Me.cdSeccion.DataPropertyName = "Seccion"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.cdSeccion.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdSeccion.HeaderText = "Sección"
    Me.cdSeccion.Name = "cdSeccion"
    Me.cdSeccion.ReadOnly = True
    Me.cdSeccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    Me.cdSeccion.Width = 50
    '
    'cdAlumno
    '
    Me.cdAlumno.DataPropertyName = "NombreCompleto"
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.ReadOnly = True
    Me.cdAlumno.Width = 160
    '
    'cdRegistro
    '
    Me.cdRegistro.DataPropertyName = "Registro"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.cdRegistro.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdRegistro.HeaderText = "Registro"
    Me.cdRegistro.Name = "cdRegistro"
    Me.cdRegistro.ReadOnly = True
    Me.cdRegistro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
    Me.cdRegistro.Width = 50
    '
    'cdMotivo
    '
    Me.cdMotivo.DataPropertyName = "Motivo"
    Me.cdMotivo.HeaderText = "Motivo justificación"
    Me.cdMotivo.Name = "cdMotivo"
    Me.cdMotivo.ReadOnly = True
    Me.cdMotivo.Width = 200
    '
    'cdApoderado
    '
    Me.cdApoderado.DataPropertyName = "Apoderado"
    Me.cdApoderado.HeaderText = "Apoderado"
    Me.cdApoderado.Name = "cdApoderado"
    Me.cdApoderado.ReadOnly = True
    Me.cdApoderado.Width = 150
    '
    'cdResponsable
    '
    Me.cdResponsable.DataPropertyName = "Personal"
    Me.cdResponsable.HeaderText = "Personal que registró jusitificación"
    Me.cdResponsable.Name = "cdResponsable"
    Me.cdResponsable.ReadOnly = True
    Me.cdResponsable.Width = 120
    '
    'cdFechaJustificada
    '
    Me.cdFechaJustificada.DataPropertyName = "FechaJusticadaXApoderado"
    Me.cdFechaJustificada.HeaderText = "Fecha que justificó el apoderado"
    Me.cdFechaJustificada.Name = "cdFechaJustificada"
    Me.cdFechaJustificada.ReadOnly = True
    Me.cdFechaJustificada.Width = 110
    '
    'cdFechaFaltaTradanza
    '
    Me.cdFechaFaltaTradanza.DataPropertyName = "FechaRegistro"
    Me.cdFechaFaltaTradanza.HeaderText = "Fecha que registró falta o tardanza"
    Me.cdFechaFaltaTradanza.Name = "cdFechaFaltaTradanza"
    Me.cdFechaFaltaTradanza.ReadOnly = True
    Me.cdFechaFaltaTradanza.Width = 110
    '
    'cdPersonalRegistrador
    '
    Me.cdPersonalRegistrador.DataPropertyName = "PersonalRegistrador"
    Me.cdPersonalRegistrador.HeaderText = "Personal que registró falta o tardanza"
    Me.cdPersonalRegistrador.Name = "cdPersonalRegistrador"
    Me.cdPersonalRegistrador.ReadOnly = True
    Me.cdPersonalRegistrador.Width = 150
    '
    'frmListadoAsistencia
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(698, 495)
    Me.Controls.Add(Me.cboTipoRegistro)
    Me.Controls.Add(Me.lblTipo)
    Me.Controls.Add(Me.pbAvance)
    Me.Controls.Add(Me.btnListar)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.cboSeccion)
    Me.Controls.Add(Me.lblSeccion)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.dgvAsistencias)
    Me.Controls.Add(Me.dtpFechaFin)
    Me.Controls.Add(Me.dtpFechaIni)
    Me.Controls.Add(Me.lblHasta)
    Me.Controls.Add(Me.lblDesde)
    Me.Name = "frmListadoAsistencia"
    Me.Text = "Listado de Asistencia"
    CType(Me.dgvAsistencias, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvAsistencias As System.Windows.Forms.DataGridView
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
    Friend WithEvents lblSeccion As System.Windows.Forms.Label
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents btnListar As System.Windows.Forms.Button
    Friend WithEvents pbAvance As System.Windows.Forms.ProgressBar
  Friend WithEvents cboTipoRegistro As System.Windows.Forms.ComboBox
  Friend WithEvents lblTipo As System.Windows.Forms.Label
  Friend WithEvents cdFecha As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdSeccion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdRegistro As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdMotivo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdApoderado As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdResponsable As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdFechaJustificada As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdFechaFaltaTradanza As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdPersonalRegistrador As System.Windows.Forms.DataGridViewTextBoxColumn
End Class