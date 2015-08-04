<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionHorarios
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
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.errValida = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.btnVer = New System.Windows.Forms.Button
    Me.btnListar = New System.Windows.Forms.Button
    Me.btnModificar = New System.Windows.Forms.Button
    Me.btnNuevo = New System.Windows.Forms.Button
    Me.gbHorario = New System.Windows.Forms.GroupBox
    Me.cboHoraIni = New System.Windows.Forms.ComboBox
    Me.nudhoras = New System.Windows.Forms.NumericUpDown
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.lblhoras = New System.Windows.Forms.Label
    Me.cboLocal = New System.Windows.Forms.ComboBox
    Me.cboAula = New System.Windows.Forms.ComboBox
    Me.lblLocal = New System.Windows.Forms.Label
    Me.cboDia = New System.Windows.Forms.ComboBox
    Me.lblAula = New System.Windows.Forms.Label
    Me.lblInicio = New System.Windows.Forms.Label
    Me.lblDia = New System.Windows.Forms.Label
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.dgvHorario = New System.Windows.Forms.DataGridView
    Me.cdDia = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdInicio = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdFin = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.dgvCargaAcademica = New System.Windows.Forms.DataGridView
    Me.cdCurso = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdNroHoras = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cboNivel = New System.Windows.Forms.ComboBox
    Me.lblNivel = New System.Windows.Forms.Label
    Me.cboSeccion = New System.Windows.Forms.ComboBox
    Me.lblSeccion = New System.Windows.Forms.Label
    Me.cbanio = New System.Windows.Forms.ComboBox
    Me.lblAnio = New System.Windows.Forms.Label
    Me.GBListaH = New System.Windows.Forms.GroupBox
    Me.gbcurso = New System.Windows.Forms.GroupBox
    CType(Me.errValida, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbHorario.SuspendLayout()
    CType(Me.nudhoras, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dgvHorario, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.dgvCargaAcademica, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GBListaH.SuspendLayout()
    Me.gbcurso.SuspendLayout()
    Me.SuspendLayout()
    '
    'errValida
    '
    Me.errValida.ContainerControl = Me
    '
    'btnVer
    '
    Me.btnVer.Location = New System.Drawing.Point(487, 72)
    Me.btnVer.Name = "btnVer"
    Me.btnVer.Size = New System.Drawing.Size(75, 23)
    Me.btnVer.TabIndex = 12
    Me.btnVer.Text = "&Ver Horario"
    Me.btnVer.UseVisualStyleBackColor = True
    '
    'btnListar
    '
    Me.btnListar.Location = New System.Drawing.Point(329, 72)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(67, 23)
    Me.btnListar.TabIndex = 6
    Me.btnListar.Text = "&Listar"
    Me.btnListar.UseVisualStyleBackColor = True
    '
    'btnModificar
    '
    Me.btnModificar.BackColor = System.Drawing.Color.White
    Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnModificar.Location = New System.Drawing.Point(178, 166)
    Me.btnModificar.Name = "btnModificar"
    Me.btnModificar.Size = New System.Drawing.Size(110, 50)
    Me.btnModificar.TabIndex = 10
    Me.btnModificar.Text = "&Modificar"
    Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnModificar.UseVisualStyleBackColor = False
    '
    'btnNuevo
    '
    Me.btnNuevo.BackColor = System.Drawing.Color.White
    Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnNuevo.Location = New System.Drawing.Point(49, 166)
    Me.btnNuevo.Name = "btnNuevo"
    Me.btnNuevo.Size = New System.Drawing.Size(110, 50)
    Me.btnNuevo.TabIndex = 9
    Me.btnNuevo.Text = "&Nuevo"
    Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnNuevo.UseVisualStyleBackColor = False
    '
    'gbHorario
    '
    Me.gbHorario.Controls.Add(Me.cboHoraIni)
    Me.gbHorario.Controls.Add(Me.nudhoras)
    Me.gbHorario.Controls.Add(Me.btnRegistrar)
    Me.gbHorario.Controls.Add(Me.btnCancelar)
    Me.gbHorario.Controls.Add(Me.lblhoras)
    Me.gbHorario.Controls.Add(Me.cboLocal)
    Me.gbHorario.Controls.Add(Me.cboAula)
    Me.gbHorario.Controls.Add(Me.lblLocal)
    Me.gbHorario.Controls.Add(Me.cboDia)
    Me.gbHorario.Controls.Add(Me.lblAula)
    Me.gbHorario.Controls.Add(Me.lblInicio)
    Me.gbHorario.Controls.Add(Me.lblDia)
    Me.gbHorario.Enabled = False
    Me.gbHorario.Location = New System.Drawing.Point(338, 343)
    Me.gbHorario.Name = "gbHorario"
    Me.gbHorario.Size = New System.Drawing.Size(317, 234)
    Me.gbHorario.TabIndex = 11
    Me.gbHorario.TabStop = False
    Me.gbHorario.Text = "&Horario"
    '
    'cboHoraIni
    '
    Me.cboHoraIni.BackColor = System.Drawing.SystemColors.Window
    Me.cboHoraIni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboHoraIni.FormattingEnabled = True
    Me.cboHoraIni.Location = New System.Drawing.Point(70, 101)
    Me.cboHoraIni.Name = "cboHoraIni"
    Me.cboHoraIni.Size = New System.Drawing.Size(121, 21)
    Me.cboHoraIni.TabIndex = 12
    '
    'nudhoras
    '
    Me.nudhoras.Location = New System.Drawing.Point(70, 134)
    Me.nudhoras.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
    Me.nudhoras.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
    Me.nudhoras.Name = "nudhoras"
    Me.nudhoras.Size = New System.Drawing.Size(39, 20)
    Me.nudhoras.TabIndex = 9
    Me.nudhoras.Value = New Decimal(New Integer() {1, 0, 0, 0})
    '
    'btnRegistrar
    '
    Me.btnRegistrar.BackColor = System.Drawing.Color.White
    Me.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnRegistrar.Location = New System.Drawing.Point(25, 173)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(110, 50)
    Me.btnRegistrar.TabIndex = 10
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnRegistrar.UseVisualStyleBackColor = False
    '
    'btnCancelar
    '
    Me.btnCancelar.BackColor = System.Drawing.Color.White
    Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCancelar.Location = New System.Drawing.Point(178, 173)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(110, 50)
    Me.btnCancelar.TabIndex = 11
    Me.btnCancelar.Text = "&Cancelar"
    Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCancelar.UseVisualStyleBackColor = False
    '
    'lblhoras
    '
    Me.lblhoras.AutoSize = True
    Me.lblhoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblhoras.Location = New System.Drawing.Point(10, 136)
    Me.lblhoras.Name = "lblhoras"
    Me.lblhoras.Size = New System.Drawing.Size(50, 13)
    Me.lblhoras.TabIndex = 8
    Me.lblhoras.Text = "N° Horas"
    '
    'cboLocal
    '
    Me.cboLocal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
    Me.cboLocal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboLocal.BackColor = System.Drawing.SystemColors.Window
    Me.cboLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboLocal.FormattingEnabled = True
    Me.cboLocal.Items.AddRange(New Object() {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"})
    Me.cboLocal.Location = New System.Drawing.Point(70, 22)
    Me.cboLocal.Name = "cboLocal"
    Me.cboLocal.Size = New System.Drawing.Size(218, 21)
    Me.cboLocal.TabIndex = 1
    '
    'cboAula
    '
    Me.cboAula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
    Me.cboAula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboAula.BackColor = System.Drawing.SystemColors.Window
    Me.cboAula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboAula.FormattingEnabled = True
    Me.cboAula.Items.AddRange(New Object() {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"})
    Me.cboAula.Location = New System.Drawing.Point(70, 49)
    Me.cboAula.Name = "cboAula"
    Me.cboAula.Size = New System.Drawing.Size(218, 21)
    Me.cboAula.TabIndex = 3
    '
    'lblLocal
    '
    Me.lblLocal.AutoSize = True
    Me.lblLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblLocal.Location = New System.Drawing.Point(10, 30)
    Me.lblLocal.Name = "lblLocal"
    Me.lblLocal.Size = New System.Drawing.Size(33, 13)
    Me.lblLocal.TabIndex = 0
    Me.lblLocal.Text = "&Local"
    '
    'cboDia
    '
    Me.cboDia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
    Me.cboDia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboDia.BackColor = System.Drawing.SystemColors.Window
    Me.cboDia.DisplayMember = "L"
    Me.cboDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboDia.FormattingEnabled = True
    Me.cboDia.Items.AddRange(New Object() {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"})
    Me.cboDia.Location = New System.Drawing.Point(70, 76)
    Me.cboDia.Name = "cboDia"
    Me.cboDia.Size = New System.Drawing.Size(218, 21)
    Me.cboDia.TabIndex = 5
    '
    'lblAula
    '
    Me.lblAula.AutoSize = True
    Me.lblAula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAula.Location = New System.Drawing.Point(10, 57)
    Me.lblAula.Name = "lblAula"
    Me.lblAula.Size = New System.Drawing.Size(28, 13)
    Me.lblAula.TabIndex = 2
    Me.lblAula.Text = "&Aula"
    '
    'lblInicio
    '
    Me.lblInicio.AutoSize = True
    Me.lblInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblInicio.Location = New System.Drawing.Point(10, 110)
    Me.lblInicio.Name = "lblInicio"
    Me.lblInicio.Size = New System.Drawing.Size(32, 13)
    Me.lblInicio.TabIndex = 6
    Me.lblInicio.Text = "&Inicio"
    '
    'lblDia
    '
    Me.lblDia.AutoSize = True
    Me.lblDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDia.Location = New System.Drawing.Point(10, 84)
    Me.lblDia.Name = "lblDia"
    Me.lblDia.Size = New System.Drawing.Size(25, 13)
    Me.lblDia.TabIndex = 4
    Me.lblDia.Text = "&Día"
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(545, 585)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 50)
    Me.btnCerrar.TabIndex = 13
    Me.btnCerrar.Text = "C&errar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'dgvHorario
    '
    Me.dgvHorario.AllowUserToAddRows = False
    Me.dgvHorario.AllowUserToDeleteRows = False
    Me.dgvHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvHorario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdDia, Me.cdInicio, Me.cdFin})
    Me.dgvHorario.Location = New System.Drawing.Point(6, 19)
    Me.dgvHorario.MultiSelect = False
    Me.dgvHorario.Name = "dgvHorario"
    Me.dgvHorario.ReadOnly = True
    Me.dgvHorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvHorario.Size = New System.Drawing.Size(304, 131)
    Me.dgvHorario.TabIndex = 8
    '
    'cdDia
    '
    Me.cdDia.HeaderText = "Dia"
    Me.cdDia.Name = "cdDia"
    Me.cdDia.ReadOnly = True
    '
    'cdInicio
    '
    DataGridViewCellStyle2.Format = "t"
    DataGridViewCellStyle2.NullValue = Nothing
    Me.cdInicio.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdInicio.HeaderText = "Inicio"
    Me.cdInicio.Name = "cdInicio"
    Me.cdInicio.ReadOnly = True
    Me.cdInicio.Width = 80
    '
    'cdFin
    '
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle3.Format = "t"
    Me.cdFin.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdFin.HeaderText = "Fin"
    Me.cdFin.Name = "cdFin"
    Me.cdFin.ReadOnly = True
    Me.cdFin.Width = 80
    '
    'dgvCargaAcademica
    '
    Me.dgvCargaAcademica.AllowUserToAddRows = False
    Me.dgvCargaAcademica.AllowUserToDeleteRows = False
    Me.dgvCargaAcademica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvCargaAcademica.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdCurso, Me.cdNroHoras})
    Me.dgvCargaAcademica.Location = New System.Drawing.Point(6, 17)
    Me.dgvCargaAcademica.MultiSelect = False
    Me.dgvCargaAcademica.Name = "dgvCargaAcademica"
    Me.dgvCargaAcademica.ReadOnly = True
    Me.dgvCargaAcademica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvCargaAcademica.Size = New System.Drawing.Size(305, 434)
    Me.dgvCargaAcademica.TabIndex = 7
    '
    'cdCurso
    '
    Me.cdCurso.DataPropertyName = "Nombre_Curso"
    Me.cdCurso.HeaderText = "Curso"
    Me.cdCurso.Name = "cdCurso"
    Me.cdCurso.ReadOnly = True
    Me.cdCurso.Width = 200
    '
    'cdNroHoras
    '
    Me.cdNroHoras.DataPropertyName = "Horas"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdNroHoras.DefaultCellStyle = DataGridViewCellStyle1
    Me.cdNroHoras.HeaderText = "Horas"
    Me.cdNroHoras.Name = "cdNroHoras"
    Me.cdNroHoras.ReadOnly = True
    Me.cdNroHoras.Width = 60
    '
    'cboNivel
    '
    Me.cboNivel.BackColor = System.Drawing.SystemColors.Window
    Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Location = New System.Drawing.Point(104, 47)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(219, 21)
    Me.cboNivel.TabIndex = 3
    '
    'lblNivel
    '
    Me.lblNivel.AutoSize = True
    Me.lblNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNivel.Location = New System.Drawing.Point(15, 55)
    Me.lblNivel.Name = "lblNivel"
    Me.lblNivel.Size = New System.Drawing.Size(31, 13)
    Me.lblNivel.TabIndex = 2
    Me.lblNivel.Text = "&Nivel"
    '
    'cboSeccion
    '
    Me.cboSeccion.BackColor = System.Drawing.SystemColors.Window
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(104, 74)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(219, 21)
    Me.cboSeccion.TabIndex = 5
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSeccion.Location = New System.Drawing.Point(14, 82)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(84, 13)
    Me.lblSeccion.TabIndex = 4
    Me.lblSeccion.Text = "&Grado y sección"
    '
    'cbanio
    '
    Me.cbanio.BackColor = System.Drawing.SystemColors.Window
    Me.cbanio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbanio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cbanio.FormattingEnabled = True
    Me.cbanio.Location = New System.Drawing.Point(104, 20)
    Me.cbanio.Name = "cbanio"
    Me.cbanio.Size = New System.Drawing.Size(90, 21)
    Me.cbanio.TabIndex = 1
    '
    'lblAnio
    '
    Me.lblAnio.AutoSize = True
    Me.lblAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAnio.Location = New System.Drawing.Point(15, 28)
    Me.lblAnio.Name = "lblAnio"
    Me.lblAnio.Size = New System.Drawing.Size(60, 13)
    Me.lblAnio.TabIndex = 0
    Me.lblAnio.Text = "Año &lectivo"
    '
    'GBListaH
    '
    Me.GBListaH.Controls.Add(Me.dgvHorario)
    Me.GBListaH.Controls.Add(Me.btnModificar)
    Me.GBListaH.Controls.Add(Me.btnNuevo)
    Me.GBListaH.Location = New System.Drawing.Point(338, 115)
    Me.GBListaH.Name = "GBListaH"
    Me.GBListaH.Size = New System.Drawing.Size(317, 222)
    Me.GBListaH.TabIndex = 14
    Me.GBListaH.TabStop = False
    Me.GBListaH.Text = "Lista de Horarios"
    '
    'gbcurso
    '
    Me.gbcurso.Controls.Add(Me.dgvCargaAcademica)
    Me.gbcurso.Location = New System.Drawing.Point(17, 115)
    Me.gbcurso.Name = "gbcurso"
    Me.gbcurso.Size = New System.Drawing.Size(318, 462)
    Me.gbcurso.TabIndex = 15
    Me.gbcurso.TabStop = False
    Me.gbcurso.Text = "Lista de Cursos"
    '
    'frmGestionHorarios
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(665, 647)
    Me.Controls.Add(Me.gbcurso)
    Me.Controls.Add(Me.GBListaH)
    Me.Controls.Add(Me.btnVer)
    Me.Controls.Add(Me.btnListar)
    Me.Controls.Add(Me.gbHorario)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.cboNivel)
    Me.Controls.Add(Me.lblNivel)
    Me.Controls.Add(Me.cboSeccion)
    Me.Controls.Add(Me.lblSeccion)
    Me.Controls.Add(Me.cbanio)
    Me.Controls.Add(Me.lblAnio)
    Me.Name = "frmGestionHorarios"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Gestión de Horarios"
    CType(Me.errValida, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbHorario.ResumeLayout(False)
    Me.gbHorario.PerformLayout()
    CType(Me.nudhoras, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dgvHorario, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.dgvCargaAcademica, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GBListaH.ResumeLayout(False)
    Me.gbcurso.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents errValida As System.Windows.Forms.ErrorProvider
  Friend WithEvents btnVer As System.Windows.Forms.Button
  Friend WithEvents btnListar As System.Windows.Forms.Button
  Friend WithEvents btnModificar As System.Windows.Forms.Button
  Friend WithEvents btnNuevo As System.Windows.Forms.Button
  Friend WithEvents gbHorario As System.Windows.Forms.GroupBox
  Friend WithEvents nudhoras As System.Windows.Forms.NumericUpDown
  Friend WithEvents btnRegistrar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents lblhoras As System.Windows.Forms.Label
  Friend WithEvents cboLocal As System.Windows.Forms.ComboBox
  Friend WithEvents cboAula As System.Windows.Forms.ComboBox
  Friend WithEvents lblLocal As System.Windows.Forms.Label
  Friend WithEvents cboDia As System.Windows.Forms.ComboBox
  Friend WithEvents lblAula As System.Windows.Forms.Label
  Friend WithEvents lblInicio As System.Windows.Forms.Label
  Friend WithEvents lblDia As System.Windows.Forms.Label
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents dgvHorario As System.Windows.Forms.DataGridView
  Friend WithEvents dgvCargaAcademica As System.Windows.Forms.DataGridView
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents lblNivel As System.Windows.Forms.Label
  Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents cbanio As System.Windows.Forms.ComboBox
  Friend WithEvents lblAnio As System.Windows.Forms.Label
  Friend WithEvents cdCurso As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdNroHoras As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDia As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdInicio As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdFin As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents GBListaH As System.Windows.Forms.GroupBox
  Friend WithEvents gbcurso As System.Windows.Forms.GroupBox
  Friend WithEvents cboHoraIni As System.Windows.Forms.ComboBox
End Class
