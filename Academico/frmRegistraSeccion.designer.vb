<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistraSeccion
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
    Me.gbnuevaseccion = New System.Windows.Forms.GroupBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.txtletra = New System.Windows.Forms.TextBox
    Me.cbtutor = New System.Windows.Forms.ComboBox
    Me.GroupBox4 = New System.Windows.Forms.GroupBox
    Me.cblocal = New System.Windows.Forms.ComboBox
    Me.Label11 = New System.Windows.Forms.Label
    Me.cbturno = New System.Windows.Forms.ComboBox
    Me.cbaula = New System.Windows.Forms.ComboBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.btlimpiar = New System.Windows.Forms.Button
    Me.Label6 = New System.Windows.Forms.Label
    Me.btregistrar = New System.Windows.Forms.Button
    Me.txtdescripcion = New System.Windows.Forms.TextBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.txtvacantes = New System.Windows.Forms.TextBox
    Me.GroupBox2 = New System.Windows.Forms.GroupBox
    Me.btnuevo = New System.Windows.Forms.Button
    Me.btmodificar = New System.Windows.Forms.Button
    Me.dgvsecciones = New System.Windows.Forms.DataGridView
    Me.codigoG = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.letra = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.codigoAula = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.codigoTurno = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.codigoTutor = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.Label9 = New System.Windows.Forms.Label
    Me.txtnombregrado = New System.Windows.Forms.TextBox
    Me.txtnivelacad = New System.Windows.Forms.TextBox
    Me.Label10 = New System.Windows.Forms.Label
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.txtanio = New System.Windows.Forms.TextBox
    Me.Label8 = New System.Windows.Forms.Label
    Me.errValida = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.gbnuevaseccion.SuspendLayout()
    Me.GroupBox4.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    CType(Me.dgvsecciones, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GroupBox1.SuspendLayout()
    CType(Me.errValida, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'gbnuevaseccion
    '
    Me.gbnuevaseccion.Controls.Add(Me.Label1)
    Me.gbnuevaseccion.Controls.Add(Me.txtletra)
    Me.gbnuevaseccion.Controls.Add(Me.cbtutor)
    Me.gbnuevaseccion.Controls.Add(Me.GroupBox4)
    Me.gbnuevaseccion.Controls.Add(Me.btlimpiar)
    Me.gbnuevaseccion.Controls.Add(Me.Label6)
    Me.gbnuevaseccion.Controls.Add(Me.btregistrar)
    Me.gbnuevaseccion.Controls.Add(Me.txtdescripcion)
    Me.gbnuevaseccion.Controls.Add(Me.Label4)
    Me.gbnuevaseccion.Controls.Add(Me.Label5)
    Me.gbnuevaseccion.Controls.Add(Me.txtvacantes)
    Me.gbnuevaseccion.Location = New System.Drawing.Point(407, 69)
    Me.gbnuevaseccion.Name = "gbnuevaseccion"
    Me.gbnuevaseccion.Size = New System.Drawing.Size(312, 336)
    Me.gbnuevaseccion.TabIndex = 1
    Me.gbnuevaseccion.TabStop = False
    Me.gbnuevaseccion.Text = "Nueva Seccion"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(41, 148)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(31, 13)
    Me.Label1.TabIndex = 20
    Me.Label1.Text = "Letra"
    '
    'txtletra
    '
    Me.txtletra.BackColor = System.Drawing.SystemColors.Window
    Me.txtletra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtletra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtletra.Location = New System.Drawing.Point(78, 145)
    Me.txtletra.Name = "txtletra"
    Me.txtletra.ReadOnly = True
    Me.txtletra.Size = New System.Drawing.Size(100, 20)
    Me.txtletra.TabIndex = 1
    '
    'cbtutor
    '
    Me.cbtutor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cbtutor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cbtutor.BackColor = System.Drawing.SystemColors.Window
    Me.cbtutor.FormattingEnabled = True
    Me.cbtutor.Location = New System.Drawing.Point(78, 205)
    Me.cbtutor.Name = "cbtutor"
    Me.cbtutor.Size = New System.Drawing.Size(218, 21)
    Me.cbtutor.TabIndex = 3
    '
    'GroupBox4
    '
    Me.GroupBox4.Controls.Add(Me.cblocal)
    Me.GroupBox4.Controls.Add(Me.Label11)
    Me.GroupBox4.Controls.Add(Me.cbturno)
    Me.GroupBox4.Controls.Add(Me.cbaula)
    Me.GroupBox4.Controls.Add(Me.Label3)
    Me.GroupBox4.Controls.Add(Me.Label2)
    Me.GroupBox4.Location = New System.Drawing.Point(9, 19)
    Me.GroupBox4.Name = "GroupBox4"
    Me.GroupBox4.Size = New System.Drawing.Size(287, 115)
    Me.GroupBox4.TabIndex = 0
    Me.GroupBox4.TabStop = False
    '
    'cblocal
    '
    Me.cblocal.BackColor = System.Drawing.SystemColors.Window
    Me.cblocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cblocal.FormattingEnabled = True
    Me.cblocal.Location = New System.Drawing.Point(70, 16)
    Me.cblocal.MaxDropDownItems = 20
    Me.cblocal.Name = "cblocal"
    Me.cblocal.Size = New System.Drawing.Size(191, 21)
    Me.cblocal.TabIndex = 0
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(28, 19)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(36, 13)
    Me.Label11.TabIndex = 16
    Me.Label11.Text = "Local:"
    '
    'cbturno
    '
    Me.cbturno.BackColor = System.Drawing.SystemColors.Window
    Me.cbturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbturno.FormattingEnabled = True
    Me.cbturno.Location = New System.Drawing.Point(70, 79)
    Me.cbturno.Name = "cbturno"
    Me.cbturno.Size = New System.Drawing.Size(139, 21)
    Me.cbturno.TabIndex = 2
    '
    'cbaula
    '
    Me.cbaula.BackColor = System.Drawing.SystemColors.Window
    Me.cbaula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbaula.FormattingEnabled = True
    Me.cbaula.Location = New System.Drawing.Point(70, 46)
    Me.cbaula.Name = "cbaula"
    Me.cbaula.Size = New System.Drawing.Size(139, 21)
    Me.cbaula.TabIndex = 1
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(25, 82)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(38, 13)
    Me.Label3.TabIndex = 5
    Me.Label3.Text = "Turno:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(33, 49)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(31, 13)
    Me.Label2.TabIndex = 4
    Me.Label2.Text = "Aula:"
    '
    'btlimpiar
    '
    Me.btlimpiar.Location = New System.Drawing.Point(176, 295)
    Me.btlimpiar.Name = "btlimpiar"
    Me.btlimpiar.Size = New System.Drawing.Size(75, 23)
    Me.btlimpiar.TabIndex = 6
    Me.btlimpiar.Text = "Cancelar"
    Me.btlimpiar.UseVisualStyleBackColor = True
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(38, 208)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(35, 13)
    Me.Label6.TabIndex = 13
    Me.Label6.Text = "Tutor:"
    '
    'btregistrar
    '
    Me.btregistrar.Location = New System.Drawing.Point(46, 295)
    Me.btregistrar.Name = "btregistrar"
    Me.btregistrar.Size = New System.Drawing.Size(75, 23)
    Me.btregistrar.TabIndex = 5
    Me.btregistrar.Text = "Registrar"
    Me.btregistrar.UseVisualStyleBackColor = True
    '
    'txtdescripcion
    '
    Me.txtdescripcion.BackColor = System.Drawing.SystemColors.Window
    Me.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtdescripcion.Location = New System.Drawing.Point(78, 239)
    Me.txtdescripcion.Multiline = True
    Me.txtdescripcion.Name = "txtdescripcion"
    Me.txtdescripcion.Size = New System.Drawing.Size(172, 45)
    Me.txtdescripcion.TabIndex = 4
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(6, 242)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(66, 13)
    Me.Label4.TabIndex = 7
    Me.Label4.Text = "Descripcion:"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(17, 177)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(55, 13)
    Me.Label5.TabIndex = 8
    Me.Label5.Text = "Vacantes:"
    '
    'txtvacantes
    '
    Me.txtvacantes.BackColor = System.Drawing.SystemColors.Window
    Me.txtvacantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtvacantes.Location = New System.Drawing.Point(78, 174)
    Me.txtvacantes.Name = "txtvacantes"
    Me.txtvacantes.Size = New System.Drawing.Size(100, 20)
    Me.txtvacantes.TabIndex = 2
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.btnuevo)
    Me.GroupBox2.Controls.Add(Me.btmodificar)
    Me.GroupBox2.Controls.Add(Me.dgvsecciones)
    Me.GroupBox2.Location = New System.Drawing.Point(12, 69)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(389, 336)
    Me.GroupBox2.TabIndex = 0
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Secciones"
    '
    'btnuevo
    '
    Me.btnuevo.Location = New System.Drawing.Point(12, 307)
    Me.btnuevo.Name = "btnuevo"
    Me.btnuevo.Size = New System.Drawing.Size(75, 23)
    Me.btnuevo.TabIndex = 0
    Me.btnuevo.Text = "Nuevo"
    Me.btnuevo.UseVisualStyleBackColor = True
    '
    'btmodificar
    '
    Me.btmodificar.Location = New System.Drawing.Point(307, 307)
    Me.btmodificar.Name = "btmodificar"
    Me.btmodificar.Size = New System.Drawing.Size(75, 23)
    Me.btmodificar.TabIndex = 1
    Me.btmodificar.Text = "Modificar"
    Me.btmodificar.UseVisualStyleBackColor = True
    '
    'dgvsecciones
    '
    Me.dgvsecciones.AllowUserToAddRows = False
    Me.dgvsecciones.AllowUserToDeleteRows = False
    Me.dgvsecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvsecciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigoG, Me.letra, Me.codigoAula, Me.codigoTurno, Me.codigoTutor})
    Me.dgvsecciones.Location = New System.Drawing.Point(12, 24)
    Me.dgvsecciones.MultiSelect = False
    Me.dgvsecciones.Name = "dgvsecciones"
    Me.dgvsecciones.ReadOnly = True
    Me.dgvsecciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvsecciones.Size = New System.Drawing.Size(370, 277)
    Me.dgvsecciones.TabIndex = 0
    Me.dgvsecciones.TabStop = False
    '
    'codigoG
    '
    Me.codigoG.DataPropertyName = "nombreGrado"
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.codigoG.DefaultCellStyle = DataGridViewCellStyle1
    Me.codigoG.HeaderText = "Grado"
    Me.codigoG.Name = "codigoG"
    Me.codigoG.ReadOnly = True
    Me.codigoG.Visible = False
    Me.codigoG.Width = 80
    '
    'letra
    '
    Me.letra.DataPropertyName = "letra"
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.letra.DefaultCellStyle = DataGridViewCellStyle2
    Me.letra.HeaderText = "Letra"
    Me.letra.Name = "letra"
    Me.letra.ReadOnly = True
    Me.letra.Width = 50
    '
    'codigoAula
    '
    Me.codigoAula.DataPropertyName = "codigoAula"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
    Me.codigoAula.DefaultCellStyle = DataGridViewCellStyle3
    Me.codigoAula.HeaderText = "Aula"
    Me.codigoAula.Name = "codigoAula"
    Me.codigoAula.ReadOnly = True
    Me.codigoAula.Width = 50
    '
    'codigoTurno
    '
    Me.codigoTurno.DataPropertyName = "nombreTurno"
    Me.codigoTurno.HeaderText = "Turno"
    Me.codigoTurno.Name = "codigoTurno"
    Me.codigoTurno.ReadOnly = True
    Me.codigoTurno.Width = 80
    '
    'codigoTutor
    '
    Me.codigoTutor.DataPropertyName = "nombreTutor"
    Me.codigoTutor.HeaderText = "Tutor"
    Me.codigoTutor.Name = "codigoTutor"
    Me.codigoTutor.ReadOnly = True
    Me.codigoTutor.Width = 150
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label9.Location = New System.Drawing.Point(300, 22)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(39, 13)
    Me.Label9.TabIndex = 19
    Me.Label9.Text = "Grado:"
    '
    'txtnombregrado
    '
    Me.txtnombregrado.BackColor = System.Drawing.SystemColors.Info
    Me.txtnombregrado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtnombregrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtnombregrado.Location = New System.Drawing.Point(345, 19)
    Me.txtnombregrado.Name = "txtnombregrado"
    Me.txtnombregrado.ReadOnly = True
    Me.txtnombregrado.Size = New System.Drawing.Size(100, 20)
    Me.txtnombregrado.TabIndex = 20
    Me.txtnombregrado.TabStop = False
    '
    'txtnivelacad
    '
    Me.txtnivelacad.BackColor = System.Drawing.SystemColors.Info
    Me.txtnivelacad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtnivelacad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtnivelacad.Location = New System.Drawing.Point(106, 19)
    Me.txtnivelacad.Name = "txtnivelacad"
    Me.txtnivelacad.ReadOnly = True
    Me.txtnivelacad.Size = New System.Drawing.Size(100, 20)
    Me.txtnivelacad.TabIndex = 21
    Me.txtnivelacad.TabStop = False
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label10.Location = New System.Drawing.Point(10, 22)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(90, 13)
    Me.Label10.TabIndex = 22
    Me.Label10.Text = "Nivel Académico:"
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.txtanio)
    Me.GroupBox1.Controls.Add(Me.Label8)
    Me.GroupBox1.Controls.Add(Me.Label10)
    Me.GroupBox1.Controls.Add(Me.txtnivelacad)
    Me.GroupBox1.Controls.Add(Me.txtnombregrado)
    Me.GroupBox1.Controls.Add(Me.Label9)
    Me.GroupBox1.Location = New System.Drawing.Point(11, 9)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(708, 51)
    Me.GroupBox1.TabIndex = 25
    Me.GroupBox1.TabStop = False
    '
    'txtanio
    '
    Me.txtanio.BackColor = System.Drawing.SystemColors.Info
    Me.txtanio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtanio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtanio.Location = New System.Drawing.Point(592, 19)
    Me.txtanio.Name = "txtanio"
    Me.txtanio.ReadOnly = True
    Me.txtanio.Size = New System.Drawing.Size(100, 20)
    Me.txtanio.TabIndex = 24
    Me.txtanio.TabStop = False
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label8.Location = New System.Drawing.Point(519, 22)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(67, 13)
    Me.Label8.TabIndex = 23
    Me.Label8.Text = "Año Lectivo:"
    '
    'errValida
    '
    Me.errValida.ContainerControl = Me
    '
    'btnCerrar
    '
    Me.btnCerrar.Location = New System.Drawing.Point(642, 411)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
    Me.btnCerrar.TabIndex = 2
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.UseVisualStyleBackColor = True
    '
    'frmRegistraSeccion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(729, 446)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.gbnuevaseccion)
    Me.Controls.Add(Me.GroupBox2)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmRegistraSeccion"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Nueva Sección"
    Me.gbnuevaseccion.ResumeLayout(False)
    Me.gbnuevaseccion.PerformLayout()
    Me.GroupBox4.ResumeLayout(False)
    Me.GroupBox4.PerformLayout()
    Me.GroupBox2.ResumeLayout(False)
    CType(Me.dgvsecciones, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    CType(Me.errValida, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents gbnuevaseccion As System.Windows.Forms.GroupBox
  Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents btlimpiar As System.Windows.Forms.Button
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents btregistrar As System.Windows.Forms.Button
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents btnuevo As System.Windows.Forms.Button
  Friend WithEvents btmodificar As System.Windows.Forms.Button
  Friend WithEvents dgvsecciones As System.Windows.Forms.DataGridView
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents txtnombregrado As System.Windows.Forms.TextBox
  Friend WithEvents txtnivelacad As System.Windows.Forms.TextBox
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents txtanio As System.Windows.Forms.TextBox
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents cbturno As System.Windows.Forms.ComboBox
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtletra As System.Windows.Forms.TextBox
  Friend WithEvents cbtutor As System.Windows.Forms.ComboBox
  Friend WithEvents cblocal As System.Windows.Forms.ComboBox
  Friend WithEvents cbaula As System.Windows.Forms.ComboBox
  Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
  Friend WithEvents txtvacantes As System.Windows.Forms.TextBox
  Friend WithEvents errValida As System.Windows.Forms.ErrorProvider
  Friend WithEvents codigoG As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents letra As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents codigoAula As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents codigoTurno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents codigoTutor As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
End Class
