﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDirectorio
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.dgvApoderados = New System.Windows.Forms.DataGridView
    Me.cdSeccion = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdTelefonoAl = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCorreoAl = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdDireccionAl = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdPadre = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdTelefonoCasaPad = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdTelefonoTrabPad = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCelularPad = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCorreoPad = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdVivePad = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdMadre = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdTelefonoCasaMad = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdTelefonoTrabMad = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCelularMad = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCorreoMad = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdViveMad = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdApoderado = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdTelefonoCadaApo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdTelefonoTrabajoApo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCelularApo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCorreoApo = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdParentesco = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.gbCriterios = New System.Windows.Forms.GroupBox
    Me.lblAnio = New System.Windows.Forms.Label
    Me.lblSeccion = New System.Windows.Forms.Label
    Me.txtAnio = New System.Windows.Forms.TextBox
    Me.cboSeccion = New System.Windows.Forms.ComboBox
    Me.btnListar = New System.Windows.Forms.Button
    Me.btnExportar = New System.Windows.Forms.Button
    CType(Me.dgvApoderados, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbCriterios.SuspendLayout()
    Me.SuspendLayout()
    '
    'dgvApoderados
    '
    Me.dgvApoderados.AllowUserToAddRows = False
    Me.dgvApoderados.AllowUserToDeleteRows = False
    Me.dgvApoderados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvApoderados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvApoderados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdSeccion, Me.cdAlumno, Me.cdTelefonoAl, Me.cdCorreoAl, Me.cdDireccionAl, Me.cdPadre, Me.cdTelefonoCasaPad, Me.cdTelefonoTrabPad, Me.cdCelularPad, Me.cdCorreoPad, Me.cdVivePad, Me.cdMadre, Me.cdTelefonoCasaMad, Me.cdTelefonoTrabMad, Me.cdCelularMad, Me.cdCorreoMad, Me.cdViveMad, Me.cdApoderado, Me.cdTelefonoCadaApo, Me.cdTelefonoTrabajoApo, Me.cdCelularApo, Me.cdCorreoApo, Me.cdParentesco})
    Me.dgvApoderados.Location = New System.Drawing.Point(27, 148)
    Me.dgvApoderados.MultiSelect = False
    Me.dgvApoderados.Name = "dgvApoderados"
    Me.dgvApoderados.ReadOnly = True
    Me.dgvApoderados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvApoderados.Size = New System.Drawing.Size(510, 269)
    Me.dgvApoderados.TabIndex = 1
    '
    'cdSeccion
    '
    Me.cdSeccion.DataPropertyName = "NivelGradoSeccion"
    Me.cdSeccion.HeaderText = "Sección"
    Me.cdSeccion.Name = "cdSeccion"
    Me.cdSeccion.ReadOnly = True
    Me.cdSeccion.Visible = False
    '
    'cdAlumno
    '
    Me.cdAlumno.DataPropertyName = "NombreAlumno"
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.ReadOnly = True
    Me.cdAlumno.Width = 210
    '
    'cdTelefonoAl
    '
    Me.cdTelefonoAl.DataPropertyName = "TelefonoAlumno"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdTelefonoAl.DefaultCellStyle = DataGridViewCellStyle1
    Me.cdTelefonoAl.HeaderText = "Teléfono"
    Me.cdTelefonoAl.Name = "cdTelefonoAl"
    Me.cdTelefonoAl.ReadOnly = True
    Me.cdTelefonoAl.Width = 80
    '
    'cdCorreoAl
    '
    Me.cdCorreoAl.DataPropertyName = "EmailAlumno"
    Me.cdCorreoAl.HeaderText = "Correo"
    Me.cdCorreoAl.Name = "cdCorreoAl"
    Me.cdCorreoAl.ReadOnly = True
    '
    'cdDireccionAl
    '
    Me.cdDireccionAl.DataPropertyName = "DireccionAlumno"
    Me.cdDireccionAl.HeaderText = "Dirección"
    Me.cdDireccionAl.Name = "cdDireccionAl"
    Me.cdDireccionAl.ReadOnly = True
    '
    'cdPadre
    '
    Me.cdPadre.DataPropertyName = "NombrePadre"
    Me.cdPadre.HeaderText = "Padre"
    Me.cdPadre.Name = "cdPadre"
    Me.cdPadre.ReadOnly = True
    '
    'cdTelefonoCasaPad
    '
    Me.cdTelefonoCasaPad.DataPropertyName = "TelefonoCasaPadre"
    Me.cdTelefonoCasaPad.HeaderText = "Tef. Casa"
    Me.cdTelefonoCasaPad.Name = "cdTelefonoCasaPad"
    Me.cdTelefonoCasaPad.ReadOnly = True
    '
    'cdTelefonoTrabPad
    '
    Me.cdTelefonoTrabPad.DataPropertyName = "TelefonoTrabajoPadre"
    Me.cdTelefonoTrabPad.HeaderText = "Telf. Trabajo"
    Me.cdTelefonoTrabPad.Name = "cdTelefonoTrabPad"
    Me.cdTelefonoTrabPad.ReadOnly = True
    '
    'cdCelularPad
    '
    Me.cdCelularPad.DataPropertyName = "CelularPadre"
    Me.cdCelularPad.HeaderText = "Celular"
    Me.cdCelularPad.Name = "cdCelularPad"
    Me.cdCelularPad.ReadOnly = True
    '
    'cdCorreoPad
    '
    Me.cdCorreoPad.DataPropertyName = "CorreoPadre"
    Me.cdCorreoPad.HeaderText = "Correo"
    Me.cdCorreoPad.Name = "cdCorreoPad"
    Me.cdCorreoPad.ReadOnly = True
    '
    'cdVivePad
    '
    Me.cdVivePad.DataPropertyName = "DescripcionVivePadre"
    Me.cdVivePad.HeaderText = "Vive"
    Me.cdVivePad.Name = "cdVivePad"
    Me.cdVivePad.ReadOnly = True
    '
    'cdMadre
    '
    Me.cdMadre.DataPropertyName = "NombreMadre"
    Me.cdMadre.HeaderText = "Madre"
    Me.cdMadre.Name = "cdMadre"
    Me.cdMadre.ReadOnly = True
    '
    'cdTelefonoCasaMad
    '
    Me.cdTelefonoCasaMad.DataPropertyName = "TelefonoCasaMadre"
    Me.cdTelefonoCasaMad.HeaderText = "Telf. Casa"
    Me.cdTelefonoCasaMad.Name = "cdTelefonoCasaMad"
    Me.cdTelefonoCasaMad.ReadOnly = True
    '
    'cdTelefonoTrabMad
    '
    Me.cdTelefonoTrabMad.DataPropertyName = "TelefonoTrabajoMadre"
    Me.cdTelefonoTrabMad.HeaderText = "Telf. Trabajo"
    Me.cdTelefonoTrabMad.Name = "cdTelefonoTrabMad"
    Me.cdTelefonoTrabMad.ReadOnly = True
    '
    'cdCelularMad
    '
    Me.cdCelularMad.DataPropertyName = "CelularMadre"
    Me.cdCelularMad.HeaderText = "Celular"
    Me.cdCelularMad.Name = "cdCelularMad"
    Me.cdCelularMad.ReadOnly = True
    '
    'cdCorreoMad
    '
    Me.cdCorreoMad.DataPropertyName = "CorreoMadre"
    Me.cdCorreoMad.HeaderText = "Correo"
    Me.cdCorreoMad.Name = "cdCorreoMad"
    Me.cdCorreoMad.ReadOnly = True
    '
    'cdViveMad
    '
    Me.cdViveMad.DataPropertyName = "DescripcionViveMadre"
    Me.cdViveMad.HeaderText = "Vive"
    Me.cdViveMad.Name = "cdViveMad"
    Me.cdViveMad.ReadOnly = True
    '
    'cdApoderado
    '
    Me.cdApoderado.DataPropertyName = "NombreApoderado"
    Me.cdApoderado.HeaderText = "Apoderado"
    Me.cdApoderado.Name = "cdApoderado"
    Me.cdApoderado.ReadOnly = True
    '
    'cdTelefonoCadaApo
    '
    Me.cdTelefonoCadaApo.DataPropertyName = "TelefonoCasaApoderado"
    Me.cdTelefonoCadaApo.HeaderText = "Telf. Casa"
    Me.cdTelefonoCadaApo.Name = "cdTelefonoCadaApo"
    Me.cdTelefonoCadaApo.ReadOnly = True
    '
    'cdTelefonoTrabajoApo
    '
    Me.cdTelefonoTrabajoApo.DataPropertyName = "TelefonoTrabajoApoderado"
    Me.cdTelefonoTrabajoApo.HeaderText = "Telf. Trabajo"
    Me.cdTelefonoTrabajoApo.Name = "cdTelefonoTrabajoApo"
    Me.cdTelefonoTrabajoApo.ReadOnly = True
    '
    'cdCelularApo
    '
    Me.cdCelularApo.DataPropertyName = "CelularApoderado"
    Me.cdCelularApo.HeaderText = "Celular"
    Me.cdCelularApo.Name = "cdCelularApo"
    Me.cdCelularApo.ReadOnly = True
    '
    'cdCorreoApo
    '
    Me.cdCorreoApo.DataPropertyName = "CorreoApoderado"
    Me.cdCorreoApo.HeaderText = "Correo"
    Me.cdCorreoApo.Name = "cdCorreoApo"
    Me.cdCorreoApo.ReadOnly = True
    '
    'cdParentesco
    '
    Me.cdParentesco.DataPropertyName = "NombreParentesco"
    Me.cdParentesco.HeaderText = "Parentesco"
    Me.cdParentesco.Name = "cdParentesco"
    Me.cdParentesco.ReadOnly = True
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(427, 427)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 50)
    Me.btnCerrar.TabIndex = 3
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'gbCriterios
    '
    Me.gbCriterios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.gbCriterios.Controls.Add(Me.lblAnio)
    Me.gbCriterios.Controls.Add(Me.lblSeccion)
    Me.gbCriterios.Controls.Add(Me.txtAnio)
    Me.gbCriterios.Controls.Add(Me.cboSeccion)
    Me.gbCriterios.Controls.Add(Me.btnListar)
    Me.gbCriterios.Location = New System.Drawing.Point(27, 14)
    Me.gbCriterios.Name = "gbCriterios"
    Me.gbCriterios.Size = New System.Drawing.Size(510, 124)
    Me.gbCriterios.TabIndex = 0
    Me.gbCriterios.TabStop = False
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblAnio.Location = New System.Drawing.Point(17, 42)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(36, 17)
    Me.lblAnio.TabIndex = 0
    Me.lblAnio.Text = "&Anio"
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblSeccion.Location = New System.Drawing.Point(17, 81)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(54, 17)
    Me.lblSeccion.TabIndex = 2
    Me.lblSeccion.Text = "&Sección"
    '
    'txtAnio
    '
    Me.txtAnio.BackColor = System.Drawing.Color.White
    Me.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.txtAnio.Location = New System.Drawing.Point(80, 34)
    Me.txtAnio.Name = "txtAnio"
    Me.txtAnio.ReadOnly = True
    Me.txtAnio.Size = New System.Drawing.Size(100, 25)
    Me.txtAnio.TabIndex = 1
    Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'cboSeccion
    '
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(79, 73)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(223, 25)
    Me.cboSeccion.TabIndex = 3
    '
    'btnListar
    '
    Me.btnListar.BackColor = System.Drawing.Color.White
    Me.btnListar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnListar.Location = New System.Drawing.Point(380, 42)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(122, 56)
    Me.btnListar.TabIndex = 4
    Me.btnListar.Text = "&Listar"
    Me.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnListar.UseVisualStyleBackColor = False
    '
    'btnExportar
    '
    Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnExportar.BackColor = System.Drawing.Color.White
    Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnExportar.Location = New System.Drawing.Point(311, 427)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(110, 50)
    Me.btnExportar.TabIndex = 2
    Me.btnExportar.Text = "&Exportar"
    Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnExportar.UseVisualStyleBackColor = False
    '
    'frmDirectorio
    '
    Me.AcceptButton = Me.btnListar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.CancelButton = Me.btnCerrar
    Me.ClientSize = New System.Drawing.Size(549, 489)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.gbCriterios)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.dgvApoderados)
    Me.Name = "frmDirectorio"
    Me.Text = "Lista de alumnos por sección"
    CType(Me.dgvApoderados, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbCriterios.ResumeLayout(False)
    Me.gbCriterios.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents dgvApoderados As System.Windows.Forms.DataGridView
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents gbCriterios As System.Windows.Forms.GroupBox
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents txtAnio As System.Windows.Forms.TextBox
  Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents cdSeccion As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdTelefonoAl As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCorreoAl As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDireccionAl As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdPadre As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdTelefonoCasaPad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdTelefonoTrabPad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCelularPad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCorreoPad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdVivePad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdMadre As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdTelefonoCasaMad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdTelefonoTrabMad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCelularMad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCorreoMad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdViveMad As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdApoderado As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdTelefonoCadaApo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdTelefonoTrabajoApo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCelularApo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCorreoApo As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdParentesco As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
