<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroNotasPeriodo
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.txtanio = New System.Windows.Forms.TextBox
    Me.txtDocente = New System.Windows.Forms.TextBox
    Me.dgvAlumNotas = New System.Windows.Forms.DataGridView
    Me.cdNumero = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCodigoProm = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdNota = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdNroMatricula = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnRegistrar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.btnExcel = New System.Windows.Forms.Button
    Me.btnListar = New System.Windows.Forms.Button
    Me.cboCurso = New System.Windows.Forms.ComboBox
    Me.lblcurso = New System.Windows.Forms.Label
    Me.cboSeccion = New System.Windows.Forms.ComboBox
    Me.lblSeccion = New System.Windows.Forms.Label
    Me.cboGrado = New System.Windows.Forms.ComboBox
    Me.lblgrado = New System.Windows.Forms.Label
    Me.cboNivel = New System.Windows.Forms.ComboBox
    Me.lblanioL = New System.Windows.Forms.Label
    Me.lblNivel = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.txtperiodo = New System.Windows.Forms.TextBox
    Me.ErrListarNotas = New System.Windows.Forms.ErrorProvider(Me.components)
    CType(Me.dgvAlumNotas, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ErrListarNotas, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'txtanio
    '
    Me.txtanio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.txtanio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtanio.Location = New System.Drawing.Point(309, 23)
    Me.txtanio.Name = "txtanio"
    Me.txtanio.ReadOnly = True
    Me.txtanio.Size = New System.Drawing.Size(73, 20)
    Me.txtanio.TabIndex = 19
    '
    'txtDocente
    '
    Me.txtDocente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.txtDocente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtDocente.Location = New System.Drawing.Point(279, 103)
    Me.txtDocente.Name = "txtDocente"
    Me.txtDocente.ReadOnly = True
    Me.txtDocente.Size = New System.Drawing.Size(253, 20)
    Me.txtDocente.TabIndex = 20
    '
    'dgvAlumNotas
    '
    Me.dgvAlumNotas.AllowUserToAddRows = False
    Me.dgvAlumNotas.AllowUserToDeleteRows = False
    DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
    Me.dgvAlumNotas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
    Me.dgvAlumNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvAlumNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvAlumNotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNumero, Me.cdCodigoProm, Me.cdAlumno, Me.cdNota, Me.cdNroMatricula})
    Me.dgvAlumNotas.Location = New System.Drawing.Point(25, 178)
    Me.dgvAlumNotas.Name = "dgvAlumNotas"
    Me.dgvAlumNotas.Size = New System.Drawing.Size(507, 246)
    Me.dgvAlumNotas.TabIndex = 10
    '
    'cdNumero
    '
    Me.cdNumero.DataPropertyName = "NroOrden"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle2.NullValue = Nothing
    Me.cdNumero.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdNumero.HeaderText = "Nº"
    Me.cdNumero.Name = "cdNumero"
    Me.cdNumero.ReadOnly = True
    Me.cdNumero.Width = 60
    '
    'cdCodigoProm
    '
    Me.cdCodigoProm.DataPropertyName = "Codigo"
    Me.cdCodigoProm.HeaderText = ""
    Me.cdCodigoProm.Name = "cdCodigoProm"
    Me.cdCodigoProm.Visible = False
    Me.cdCodigoProm.Width = 10
    '
    'cdAlumno
    '
    Me.cdAlumno.DataPropertyName = "NombreCompleto"
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.ReadOnly = True
    Me.cdAlumno.Width = 250
    '
    'cdNota
    '
    Me.cdNota.DataPropertyName = "PromedioFinal"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    DataGridViewCellStyle3.Format = "00"
    Me.cdNota.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdNota.HeaderText = "Nota"
    Me.cdNota.Name = "cdNota"
    '
    'cdNroMatricula
    '
    Me.cdNroMatricula.DataPropertyName = "NroMatricula"
    Me.cdNroMatricula.HeaderText = ""
    Me.cdNroMatricula.Name = "cdNroMatricula"
    Me.cdNroMatricula.Visible = False
    Me.cdNroMatricula.Width = 10
    '
    'btnRegistrar
    '
    Me.btnRegistrar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnRegistrar.Enabled = False
    Me.btnRegistrar.Location = New System.Drawing.Point(25, 430)
    Me.btnRegistrar.Name = "btnRegistrar"
    Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
    Me.btnRegistrar.TabIndex = 11
    Me.btnRegistrar.Text = "&Registrar"
    Me.btnRegistrar.UseVisualStyleBackColor = True
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.Location = New System.Drawing.Point(457, 430)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
    Me.btnCerrar.TabIndex = 12
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.UseVisualStyleBackColor = True
    '
    'btnExcel
    '
    Me.btnExcel.Location = New System.Drawing.Point(158, 149)
    Me.btnExcel.Name = "btnExcel"
    Me.btnExcel.Size = New System.Drawing.Size(75, 23)
    Me.btnExcel.TabIndex = 9
    Me.btnExcel.Text = "&Excel"
    Me.btnExcel.UseVisualStyleBackColor = True
    Me.btnExcel.Visible = False
    '
    'btnListar
    '
    Me.btnListar.Enabled = False
    Me.btnListar.Location = New System.Drawing.Point(77, 149)
    Me.btnListar.Name = "btnListar"
    Me.btnListar.Size = New System.Drawing.Size(75, 23)
    Me.btnListar.TabIndex = 8
    Me.btnListar.Text = "&Listar"
    Me.btnListar.UseVisualStyleBackColor = True
    '
    'cboCurso
    '
    Me.cboCurso.FormattingEnabled = True
    Me.cboCurso.Location = New System.Drawing.Point(77, 103)
    Me.cboCurso.Name = "cboCurso"
    Me.cboCurso.Size = New System.Drawing.Size(196, 21)
    Me.cboCurso.TabIndex = 7
    '
    'lblcurso
    '
    Me.lblcurso.AutoSize = True
    Me.lblcurso.Location = New System.Drawing.Point(22, 111)
    Me.lblcurso.Name = "lblcurso"
    Me.lblcurso.Size = New System.Drawing.Size(34, 13)
    Me.lblcurso.TabIndex = 6
    Me.lblcurso.Text = "C&urso"
    '
    'cboSeccion
    '
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(77, 76)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(196, 21)
    Me.cboSeccion.TabIndex = 5
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Location = New System.Drawing.Point(22, 84)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(46, 13)
    Me.lblSeccion.TabIndex = 4
    Me.lblSeccion.Text = "&Sección"
    '
    'cboGrado
    '
    Me.cboGrado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cboGrado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboGrado.FormattingEnabled = True
    Me.cboGrado.Location = New System.Drawing.Point(77, 49)
    Me.cboGrado.Name = "cboGrado"
    Me.cboGrado.Size = New System.Drawing.Size(196, 21)
    Me.cboGrado.TabIndex = 3
    '
    'lblgrado
    '
    Me.lblgrado.AutoSize = True
    Me.lblgrado.Location = New System.Drawing.Point(22, 57)
    Me.lblgrado.Name = "lblgrado"
    Me.lblgrado.Size = New System.Drawing.Size(36, 13)
    Me.lblgrado.TabIndex = 2
    Me.lblgrado.Text = "&Grado"
    '
    'cboNivel
    '
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Location = New System.Drawing.Point(77, 22)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(196, 21)
    Me.cboNivel.TabIndex = 1
    '
    'lblanioL
    '
    Me.lblanioL.AutoSize = True
    Me.lblanioL.Location = New System.Drawing.Point(279, 30)
    Me.lblanioL.Name = "lblanioL"
    Me.lblanioL.Size = New System.Drawing.Size(28, 13)
    Me.lblanioL.TabIndex = 9
    Me.lblanioL.Text = "&Anio"
    '
    'lblNivel
    '
    Me.lblNivel.AutoSize = True
    Me.lblNivel.Location = New System.Drawing.Point(22, 30)
    Me.lblNivel.Name = "lblNivel"
    Me.lblNivel.Size = New System.Drawing.Size(31, 13)
    Me.lblNivel.TabIndex = 0
    Me.lblNivel.Text = "&Nivel"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(279, 87)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(48, 13)
    Me.Label1.TabIndex = 9
    Me.Label1.Text = "Docente"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(402, 30)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(43, 13)
    Me.Label2.TabIndex = 9
    Me.Label2.Text = "&Periodo"
    '
    'txtperiodo
    '
    Me.txtperiodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
    Me.txtperiodo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtperiodo.Location = New System.Drawing.Point(448, 23)
    Me.txtperiodo.Name = "txtperiodo"
    Me.txtperiodo.ReadOnly = True
    Me.txtperiodo.Size = New System.Drawing.Size(94, 20)
    Me.txtperiodo.TabIndex = 19
    '
    'ErrListarNotas
    '
    Me.ErrListarNotas.ContainerControl = Me
    '
    'frmRegistroNotasPeriodo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(554, 475)
    Me.Controls.Add(Me.txtperiodo)
    Me.Controls.Add(Me.txtanio)
    Me.Controls.Add(Me.txtDocente)
    Me.Controls.Add(Me.dgvAlumNotas)
    Me.Controls.Add(Me.btnRegistrar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnExcel)
    Me.Controls.Add(Me.btnListar)
    Me.Controls.Add(Me.cboCurso)
    Me.Controls.Add(Me.lblcurso)
    Me.Controls.Add(Me.cboSeccion)
    Me.Controls.Add(Me.lblSeccion)
    Me.Controls.Add(Me.cboGrado)
    Me.Controls.Add(Me.lblgrado)
    Me.Controls.Add(Me.cboNivel)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.lblanioL)
    Me.Controls.Add(Me.lblNivel)
    Me.Name = "frmRegistroNotasPeriodo"
    Me.Text = "RegistroNotasPeriodo"
    CType(Me.dgvAlumNotas, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ErrListarNotas, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
    Friend WithEvents txtanio As System.Windows.Forms.TextBox
    Friend WithEvents txtDocente As System.Windows.Forms.TextBox
    Friend WithEvents dgvAlumNotas As System.Windows.Forms.DataGridView
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnListar As System.Windows.Forms.Button
    Friend WithEvents cboCurso As System.Windows.Forms.ComboBox
    Friend WithEvents lblcurso As System.Windows.Forms.Label
    Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
    Friend WithEvents lblSeccion As System.Windows.Forms.Label
    Friend WithEvents cboGrado As System.Windows.Forms.ComboBox
    Friend WithEvents lblgrado As System.Windows.Forms.Label
    Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
    Friend WithEvents lblanioL As System.Windows.Forms.Label
    Friend WithEvents lblNivel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtperiodo As System.Windows.Forms.TextBox
    Friend WithEvents ErrListarNotas As System.Windows.Forms.ErrorProvider
    Friend WithEvents cdNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdCodigoProm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdNota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cdNroMatricula As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
