<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecuperacionNota
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
    Me.lblLibro = New System.Windows.Forms.Label()
    Me.txtNotaRecuperacion = New System.Windows.Forms.TextBox()
    Me.cboLibro = New System.Windows.Forms.ComboBox()
    Me.btnAceptar = New System.Windows.Forms.Button()
    Me.lblNotaRecuperacion = New System.Windows.Forms.Label()
    Me.gbLeyenda = New System.Windows.Forms.GroupBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.lblVigente = New System.Windows.Forms.Label()
    Me.btnCerrar = New System.Windows.Forms.Button()
    Me.gbLeyenda.SuspendLayout()
    Me.SuspendLayout()
    '
    'lblLibro
    '
    Me.lblLibro.AutoSize = True
    Me.lblLibro.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblLibro.Location = New System.Drawing.Point(48, 83)
    Me.lblLibro.Name = "lblLibro"
    Me.lblLibro.Size = New System.Drawing.Size(37, 15)
    Me.lblLibro.TabIndex = 2
    Me.lblLibro.Text = "Libro"
    '
    'txtNotaRecuperacion
    '
    Me.txtNotaRecuperacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtNotaRecuperacion.Location = New System.Drawing.Point(118, 41)
    Me.txtNotaRecuperacion.Name = "txtNotaRecuperacion"
    Me.txtNotaRecuperacion.Size = New System.Drawing.Size(49, 20)
    Me.txtNotaRecuperacion.TabIndex = 1
    '
    'cboLibro
    '
    Me.cboLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboLibro.FormattingEnabled = True
    Me.cboLibro.Location = New System.Drawing.Point(119, 77)
    Me.cboLibro.Name = "cboLibro"
    Me.cboLibro.Size = New System.Drawing.Size(238, 21)
    Me.cboLibro.TabIndex = 3
    '
    'btnAceptar
    '
    Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnAceptar.BackColor = System.Drawing.Color.White
    Me.btnAceptar.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAceptar.Location = New System.Drawing.Point(60, 134)
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(91, 46)
    Me.btnAceptar.TabIndex = 4
    Me.btnAceptar.Text = "&Aceptar"
    Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnAceptar.UseVisualStyleBackColor = False
    '
    'lblNotaRecuperacion
    '
    Me.lblNotaRecuperacion.AutoSize = True
    Me.lblNotaRecuperacion.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNotaRecuperacion.Location = New System.Drawing.Point(44, 46)
    Me.lblNotaRecuperacion.Name = "lblNotaRecuperacion"
    Me.lblNotaRecuperacion.Size = New System.Drawing.Size(68, 15)
    Me.lblNotaRecuperacion.TabIndex = 0
    Me.lblNotaRecuperacion.Text = "Nueva Nota"
    '
    'gbLeyenda
    '
    Me.gbLeyenda.Controls.Add(Me.Label5)
    Me.gbLeyenda.Controls.Add(Me.lblVigente)
    Me.gbLeyenda.Location = New System.Drawing.Point(51, 200)
    Me.gbLeyenda.Name = "gbLeyenda"
    Me.gbLeyenda.Size = New System.Drawing.Size(230, 63)
    Me.gbLeyenda.TabIndex = 6
    Me.gbLeyenda.TabStop = False
    Me.gbLeyenda.Text = "Leyenda"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
    Me.Label5.Location = New System.Drawing.Point(6, 16)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(145, 15)
    Me.Label5.TabIndex = 0
    Me.Label5.Text = "A, B, C y AD : calificación"
    '
    'lblVigente
    '
    Me.lblVigente.AutoSize = True
    Me.lblVigente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblVigente.ForeColor = System.Drawing.Color.DarkBlue
    Me.lblVigente.Location = New System.Drawing.Point(6, 41)
    Me.lblVigente.Name = "lblVigente"
    Me.lblVigente.Size = New System.Drawing.Size(139, 15)
    Me.lblVigente.TabIndex = 1
    Me.lblVigente.Text = "NP        : No se presentó"
    '
    'btnCerrar
    '
    Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(186, 132)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(95, 50)
    Me.btnCerrar.TabIndex = 5
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'frmRecuperacionNota
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(381, 297)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.gbLeyenda)
    Me.Controls.Add(Me.lblNotaRecuperacion)
    Me.Controls.Add(Me.btnAceptar)
    Me.Controls.Add(Me.cboLibro)
    Me.Controls.Add(Me.txtNotaRecuperacion)
    Me.Controls.Add(Me.lblLibro)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmRecuperacionNota"
    Me.ShowIcon = False
    Me.Text = "Recuperación de Nota"
    Me.gbLeyenda.ResumeLayout(False)
    Me.gbLeyenda.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
    Friend WithEvents lblLibro As System.Windows.Forms.Label
    Friend WithEvents txtNotaRecuperacion As System.Windows.Forms.TextBox
    Friend WithEvents cboLibro As System.Windows.Forms.ComboBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblNotaRecuperacion As System.Windows.Forms.Label
    Friend WithEvents gbLeyenda As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblVigente As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
End Class
