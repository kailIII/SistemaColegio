<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarCargaAcad
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
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarCargaAcad))
    Me.lblHorasTot = New System.Windows.Forms.Label
    Me.lblTotHorasAsig = New System.Windows.Forms.Label
    Me.gbSeleccione = New System.Windows.Forms.GroupBox
    Me.cboNivel2 = New System.Windows.Forms.ComboBox
    Me.cboListDoc = New System.Windows.Forms.ComboBox
    Me.lblNivel2 = New System.Windows.Forms.Label
    Me.lblDocente2 = New System.Windows.Forms.Label
    Me.btnEliminar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.dgbuscar = New System.Windows.Forms.DataGridView
    Me.cdNumero = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdDocente = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdCursos = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdNivel = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdHoras = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdGrados = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.cdBlanco4 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnBuscar = New System.Windows.Forms.Button
    Me.gbSeleccione.SuspendLayout()
    CType(Me.dgbuscar, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblHorasTot
    '
    Me.lblHorasTot.AutoSize = True
    Me.lblHorasTot.BackColor = System.Drawing.SystemColors.Window
    Me.lblHorasTot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
    Me.lblHorasTot.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblHorasTot.Location = New System.Drawing.Point(177, 404)
    Me.lblHorasTot.MaximumSize = New System.Drawing.Size(25, 24)
    Me.lblHorasTot.MinimumSize = New System.Drawing.Size(25, 24)
    Me.lblHorasTot.Name = "lblHorasTot"
    Me.lblHorasTot.Size = New System.Drawing.Size(25, 24)
    Me.lblHorasTot.TabIndex = 11
    Me.lblHorasTot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    Me.lblHorasTot.Visible = False
    '
    'lblTotHorasAsig
    '
    Me.lblTotHorasAsig.AutoSize = True
    Me.lblTotHorasAsig.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblTotHorasAsig.Location = New System.Drawing.Point(42, 408)
    Me.lblTotHorasAsig.Name = "lblTotHorasAsig"
    Me.lblTotHorasAsig.Size = New System.Drawing.Size(134, 15)
    Me.lblTotHorasAsig.TabIndex = 10
    Me.lblTotHorasAsig.Text = "Total Horas Asignadas:"
    Me.lblTotHorasAsig.Visible = False
    '
    'gbSeleccione
    '
    Me.gbSeleccione.Controls.Add(Me.cboNivel2)
    Me.gbSeleccione.Controls.Add(Me.cboListDoc)
    Me.gbSeleccione.Controls.Add(Me.lblNivel2)
    Me.gbSeleccione.Controls.Add(Me.lblDocente2)
    Me.gbSeleccione.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbSeleccione.Location = New System.Drawing.Point(231, 25)
    Me.gbSeleccione.Name = "gbSeleccione"
    Me.gbSeleccione.Size = New System.Drawing.Size(590, 53)
    Me.gbSeleccione.TabIndex = 5
    Me.gbSeleccione.TabStop = False
    Me.gbSeleccione.Text = "&Seleccione"
    '
    'cboNivel2
    '
    Me.cboNivel2.FormattingEnabled = True
    Me.cboNivel2.Location = New System.Drawing.Point(362, 20)
    Me.cboNivel2.Name = "cboNivel2"
    Me.cboNivel2.Size = New System.Drawing.Size(211, 23)
    Me.cboNivel2.TabIndex = 3
    '
    'cboListDoc
    '
    Me.cboListDoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cboListDoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cboListDoc.FormattingEnabled = True
    Me.cboListDoc.Location = New System.Drawing.Point(75, 20)
    Me.cboListDoc.Name = "cboListDoc"
    Me.cboListDoc.Size = New System.Drawing.Size(231, 23)
    Me.cboListDoc.TabIndex = 1
    '
    'lblNivel2
    '
    Me.lblNivel2.AutoSize = True
    Me.lblNivel2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNivel2.Location = New System.Drawing.Point(321, 24)
    Me.lblNivel2.Name = "lblNivel2"
    Me.lblNivel2.Size = New System.Drawing.Size(38, 15)
    Me.lblNivel2.TabIndex = 2
    Me.lblNivel2.Text = "Ni&vel:"
    '
    'lblDocente2
    '
    Me.lblDocente2.AutoSize = True
    Me.lblDocente2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDocente2.Location = New System.Drawing.Point(18, 23)
    Me.lblDocente2.Name = "lblDocente2"
    Me.lblDocente2.Size = New System.Drawing.Size(55, 15)
    Me.lblDocente2.TabIndex = 0
    Me.lblDocente2.Text = "&Docente:"
    '
    'btnEliminar
    '
    Me.btnEliminar.BackColor = System.Drawing.Color.White
    Me.btnEliminar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnEliminar.Location = New System.Drawing.Point(572, 394)
    Me.btnEliminar.Name = "btnEliminar"
    Me.btnEliminar.Size = New System.Drawing.Size(150, 52)
    Me.btnEliminar.TabIndex = 9
    Me.btnEliminar.Text = "&Quitar Curso Asignado"
    Me.btnEliminar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(740, 394)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(150, 52)
    Me.btnCerrar.TabIndex = 6
    Me.btnCerrar.Text = "C&ancelar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'dgbuscar
    '
    Me.dgbuscar.AllowUserToAddRows = False
    Me.dgbuscar.AllowUserToDeleteRows = False
    Me.dgbuscar.BackgroundColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgbuscar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgbuscar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNumero, Me.cdDocente, Me.cdCursos, Me.cdNivel, Me.cdHoras, Me.cdGrados, Me.cdBlanco4})
    Me.dgbuscar.GridColor = System.Drawing.SystemColors.ScrollBar
    Me.dgbuscar.Location = New System.Drawing.Point(45, 94)
    Me.dgbuscar.Name = "dgbuscar"
    Me.dgbuscar.ReadOnly = True
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveBorder
    DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgbuscar.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
    Me.dgbuscar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.dgbuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgbuscar.Size = New System.Drawing.Size(845, 288)
    Me.dgbuscar.TabIndex = 8
    '
    'cdNumero
    '
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
    Me.cdNumero.DefaultCellStyle = DataGridViewCellStyle2
    Me.cdNumero.HeaderText = ""
    Me.cdNumero.Name = "cdNumero"
    Me.cdNumero.ReadOnly = True
    Me.cdNumero.Width = 35
    '
    'cdDocente
    '
    Me.cdDocente.FillWeight = 85.95601!
    Me.cdDocente.HeaderText = "DOCENTE"
    Me.cdDocente.Name = "cdDocente"
    Me.cdDocente.ReadOnly = True
    Me.cdDocente.Width = 235
    '
    'cdCursos
    '
    Me.cdCursos.FillWeight = 85.95601!
    Me.cdCursos.HeaderText = "CURSO"
    Me.cdCursos.Name = "cdCursos"
    Me.cdCursos.ReadOnly = True
    Me.cdCursos.Width = 250
    '
    'cdNivel
    '
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.cdNivel.DefaultCellStyle = DataGridViewCellStyle3
    Me.cdNivel.HeaderText = "NIVEL"
    Me.cdNivel.Name = "cdNivel"
    Me.cdNivel.ReadOnly = True
    Me.cdNivel.Width = 145
    '
    'cdHoras
    '
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    Me.cdHoras.DefaultCellStyle = DataGridViewCellStyle4
    Me.cdHoras.FillWeight = 85.95601!
    Me.cdHoras.HeaderText = "HORAS"
    Me.cdHoras.Name = "cdHoras"
    Me.cdHoras.ReadOnly = True
    Me.cdHoras.Width = 50
    '
    'cdGrados
    '
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cdGrados.DefaultCellStyle = DataGridViewCellStyle5
    Me.cdGrados.FillWeight = 142.132!
    Me.cdGrados.HeaderText = "GRADO"
    Me.cdGrados.Name = "cdGrados"
    Me.cdGrados.ReadOnly = True
    Me.cdGrados.Width = 72
    '
    'cdBlanco4
    '
    Me.cdBlanco4.HeaderText = ""
    Me.cdBlanco4.Name = "cdBlanco4"
    Me.cdBlanco4.ReadOnly = True
    Me.cdBlanco4.Width = 17
    '
    'btnBuscar
    '
    Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
    Me.btnBuscar.Location = New System.Drawing.Point(841, 34)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(49, 43)
    Me.btnBuscar.TabIndex = 7
    Me.btnBuscar.UseVisualStyleBackColor = True
    '
    'frmBuscarCargaAcad
    '
    Me.AcceptButton = Me.btnBuscar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(933, 468)
    Me.Controls.Add(Me.lblHorasTot)
    Me.Controls.Add(Me.lblTotHorasAsig)
    Me.Controls.Add(Me.gbSeleccione)
    Me.Controls.Add(Me.btnEliminar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.dgbuscar)
    Me.Controls.Add(Me.btnBuscar)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmBuscarCargaAcad"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Asignación académica"
    Me.gbSeleccione.ResumeLayout(False)
    Me.gbSeleccione.PerformLayout()
    CType(Me.dgbuscar, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblHorasTot As System.Windows.Forms.Label
  Friend WithEvents lblTotHorasAsig As System.Windows.Forms.Label
  Friend WithEvents gbSeleccione As System.Windows.Forms.GroupBox
  Friend WithEvents cboNivel2 As System.Windows.Forms.ComboBox
  Friend WithEvents cboListDoc As System.Windows.Forms.ComboBox
  Friend WithEvents lblNivel2 As System.Windows.Forms.Label
  Friend WithEvents lblDocente2 As System.Windows.Forms.Label
  Friend WithEvents btnEliminar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents dgbuscar As System.Windows.Forms.DataGridView
  Friend WithEvents cdNumero As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdDocente As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdCursos As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdNivel As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdHoras As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdGrados As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cdBlanco4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class
