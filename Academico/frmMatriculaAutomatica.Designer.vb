<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMatriculaAutomatica
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
    Me.gbAniActual = New System.Windows.Forms.GroupBox
    Me.cboAnioAct = New System.Windows.Forms.ComboBox
    Me.gbAnioProximo = New System.Windows.Forms.GroupBox
    Me.txtAnioProx = New System.Windows.Forms.TextBox
    Me.dgProxMat = New System.Windows.Forms.DataGridView
    Me.cdImagen = New System.Windows.Forms.DataGridViewImageColumn
    Me.cdAlumno = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdGradoActual = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdGradoSiguiente = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnMatricular = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.errMatAuto = New System.Windows.Forms.ErrorProvider(Me.components)
    Me.gbLeyenda = New System.Windows.Forms.GroupBox
    Me.lblEgresado = New System.Windows.Forms.Label
    Me.lblRepite = New System.Windows.Forms.Label
    Me.pnVerde = New System.Windows.Forms.Panel
    Me.pnRojo = New System.Windows.Forms.Panel
    Me.btnListarAlumnos = New System.Windows.Forms.Button
    Me.lblMsje = New System.Windows.Forms.Label
    Me.gbAniActual.SuspendLayout()
    Me.gbAnioProximo.SuspendLayout()
    CType(Me.dgProxMat, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.errMatAuto, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.gbLeyenda.SuspendLayout()
    Me.SuspendLayout()
    '
    'gbAniActual
    '
    Me.gbAniActual.Controls.Add(Me.cboAnioAct)
    Me.gbAniActual.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbAniActual.Location = New System.Drawing.Point(12, 8)
    Me.gbAniActual.Name = "gbAniActual"
    Me.gbAniActual.Size = New System.Drawing.Size(200, 67)
    Me.gbAniActual.TabIndex = 0
    Me.gbAniActual.TabStop = False
    Me.gbAniActual.Text = "Año Lectivo Actual"
    '
    'cboAnioAct
    '
    Me.cboAnioAct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAnioAct.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboAnioAct.FormattingEnabled = True
    Me.cboAnioAct.Location = New System.Drawing.Point(29, 28)
    Me.cboAnioAct.Name = "cboAnioAct"
    Me.cboAnioAct.Size = New System.Drawing.Size(142, 24)
    Me.cboAnioAct.TabIndex = 0
    '
    'gbAnioProximo
    '
    Me.gbAnioProximo.Controls.Add(Me.txtAnioProx)
    Me.gbAnioProximo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbAnioProximo.Location = New System.Drawing.Point(228, 7)
    Me.gbAnioProximo.Name = "gbAnioProximo"
    Me.gbAnioProximo.Size = New System.Drawing.Size(200, 67)
    Me.gbAnioProximo.TabIndex = 1
    Me.gbAnioProximo.TabStop = False
    Me.gbAnioProximo.Text = "Siguiente Año Lectivo"
    '
    'txtAnioProx
    '
    Me.txtAnioProx.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAnioProx.Location = New System.Drawing.Point(29, 28)
    Me.txtAnioProx.Name = "txtAnioProx"
    Me.txtAnioProx.Size = New System.Drawing.Size(142, 22)
    Me.txtAnioProx.TabIndex = 0
    '
    'dgProxMat
    '
    Me.dgProxMat.AllowUserToAddRows = False
    Me.dgProxMat.AllowUserToDeleteRows = False
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgProxMat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgProxMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgProxMat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdImagen, Me.cdAlumno, Me.cdGradoActual, Me.cdGradoSiguiente})
    Me.dgProxMat.Location = New System.Drawing.Point(12, 85)
    Me.dgProxMat.MultiSelect = False
    Me.dgProxMat.Name = "dgProxMat"
    Me.dgProxMat.ReadOnly = True
    Me.dgProxMat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgProxMat.Size = New System.Drawing.Size(833, 402)
    Me.dgProxMat.TabIndex = 5
    '
    'cdImagen
    '
    Me.cdImagen.HeaderText = ""
    Me.cdImagen.Name = "cdImagen"
    Me.cdImagen.ReadOnly = True
    Me.cdImagen.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
    Me.cdImagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
    Me.cdImagen.Width = 60
    '
    'cdAlumno
    '
    Me.cdAlumno.DataPropertyName = "NombreCompleto"
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cdAlumno.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdAlumno.HeaderText = "Alumno"
    Me.cdAlumno.Name = "cdAlumno"
    Me.cdAlumno.ReadOnly = True
    Me.cdAlumno.Width = 250
    '
    'cdGradoActual
    '
    Me.cdGradoActual.DataPropertyName = "GradoActual"
    Me.cdGradoActual.HeaderText = "Grado actual"
    Me.cdGradoActual.Name = "cdGradoActual"
    Me.cdGradoActual.ReadOnly = True
    Me.cdGradoActual.Width = 150
    '
    'cdGradoSiguiente
    '
    Me.cdGradoSiguiente.DataPropertyName = "GradoSgte"
    Me.cdGradoSiguiente.HeaderText = "Grado siguiente"
    Me.cdGradoSiguiente.Name = "cdGradoSiguiente"
    Me.cdGradoSiguiente.ReadOnly = True
    Me.cdGradoSiguiente.Width = 150
    '
    'btnMatricular
    '
    Me.btnMatricular.BackColor = System.Drawing.Color.White
    Me.btnMatricular.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnMatricular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnMatricular.Location = New System.Drawing.Point(863, 409)
    Me.btnMatricular.Name = "btnMatricular"
    Me.btnMatricular.Size = New System.Drawing.Size(110, 52)
    Me.btnMatricular.TabIndex = 3
    Me.btnMatricular.Text = "&Matricular"
    Me.btnMatricular.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(863, 465)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 4
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'errMatAuto
    '
    Me.errMatAuto.ContainerControl = Me
    '
    'gbLeyenda
    '
    Me.gbLeyenda.Controls.Add(Me.lblEgresado)
    Me.gbLeyenda.Controls.Add(Me.lblRepite)
    Me.gbLeyenda.Controls.Add(Me.pnVerde)
    Me.gbLeyenda.Controls.Add(Me.pnRojo)
    Me.gbLeyenda.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbLeyenda.Location = New System.Drawing.Point(742, 9)
    Me.gbLeyenda.Name = "gbLeyenda"
    Me.gbLeyenda.Size = New System.Drawing.Size(231, 66)
    Me.gbLeyenda.TabIndex = 2
    Me.gbLeyenda.TabStop = False
    Me.gbLeyenda.Text = "Leyenda"
    '
    'lblEgresado
    '
    Me.lblEgresado.AutoSize = True
    Me.lblEgresado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblEgresado.Location = New System.Drawing.Point(93, 43)
    Me.lblEgresado.Name = "lblEgresado"
    Me.lblEgresado.Size = New System.Drawing.Size(111, 16)
    Me.lblEgresado.TabIndex = 3
    Me.lblEgresado.Text = "Alumno Egresado"
    '
    'lblRepite
    '
    Me.lblRepite.AutoSize = True
    Me.lblRepite.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblRepite.Location = New System.Drawing.Point(93, 19)
    Me.lblRepite.Name = "lblRepite"
    Me.lblRepite.Size = New System.Drawing.Size(84, 16)
    Me.lblRepite.TabIndex = 1
    Me.lblRepite.Text = "Repite Grado"
    '
    'pnVerde
    '
    Me.pnVerde.BackColor = System.Drawing.Color.LimeGreen
    Me.pnVerde.Location = New System.Drawing.Point(27, 46)
    Me.pnVerde.Name = "pnVerde"
    Me.pnVerde.Size = New System.Drawing.Size(56, 12)
    Me.pnVerde.TabIndex = 2
    '
    'pnRojo
    '
    Me.pnRojo.BackColor = System.Drawing.Color.Red
    Me.pnRojo.Location = New System.Drawing.Point(27, 22)
    Me.pnRojo.Name = "pnRojo"
    Me.pnRojo.Size = New System.Drawing.Size(56, 12)
    Me.pnRojo.TabIndex = 0
    '
    'btnListarAlumnos
    '
    Me.btnListarAlumnos.BackColor = System.Drawing.Color.White
    Me.btnListarAlumnos.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnListarAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnListarAlumnos.Location = New System.Drawing.Point(437, 23)
    Me.btnListarAlumnos.Name = "btnListarAlumnos"
    Me.btnListarAlumnos.Size = New System.Drawing.Size(110, 52)
    Me.btnListarAlumnos.TabIndex = 6
    Me.btnListarAlumnos.Text = "&Listar alumnos"
    Me.btnListarAlumnos.UseVisualStyleBackColor = False
    '
    'lblMsje
    '
    Me.lblMsje.AutoSize = True
    Me.lblMsje.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblMsje.Location = New System.Drawing.Point(12, 501)
    Me.lblMsje.Name = "lblMsje"
    Me.lblMsje.Size = New System.Drawing.Size(0, 16)
    Me.lblMsje.TabIndex = 7
    '
    'frmMatriculaAutomatica
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(985, 529)
    Me.Controls.Add(Me.lblMsje)
    Me.Controls.Add(Me.btnListarAlumnos)
    Me.Controls.Add(Me.gbLeyenda)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.btnMatricular)
    Me.Controls.Add(Me.dgProxMat)
    Me.Controls.Add(Me.gbAnioProximo)
    Me.Controls.Add(Me.gbAniActual)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.Name = "frmMatriculaAutomatica"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Matrícula automática"
    Me.gbAniActual.ResumeLayout(False)
    Me.gbAnioProximo.ResumeLayout(False)
    Me.gbAnioProximo.PerformLayout()
    CType(Me.dgProxMat, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.errMatAuto, System.ComponentModel.ISupportInitialize).EndInit()
    Me.gbLeyenda.ResumeLayout(False)
    Me.gbLeyenda.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents gbAniActual As System.Windows.Forms.GroupBox
  Friend WithEvents gbAnioProximo As System.Windows.Forms.GroupBox
  Friend WithEvents cboAnioAct As System.Windows.Forms.ComboBox
  'Friend WithEvents txtAnioProx As System.Windows.Forms.ComboBox
  Friend WithEvents txtAnioProx As System.Windows.Forms.TextBox
  Friend WithEvents dgProxMat As System.Windows.Forms.DataGridView
  Friend WithEvents btnMatricular As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents errMatAuto As System.Windows.Forms.ErrorProvider
  Friend WithEvents gbLeyenda As System.Windows.Forms.GroupBox
  Friend WithEvents pnVerde As System.Windows.Forms.Panel
  Friend WithEvents pnRojo As System.Windows.Forms.Panel
  Friend WithEvents lblEgresado As System.Windows.Forms.Label
  Friend WithEvents lblRepite As System.Windows.Forms.Label
  Friend WithEvents btnListarAlumnos As System.Windows.Forms.Button
  Friend WithEvents cdImagen As System.Windows.Forms.DataGridViewImageColumn
  Friend WithEvents cdAlumno As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdGradoActual As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdGradoSiguiente As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents lblMsje As System.Windows.Forms.Label
End Class
