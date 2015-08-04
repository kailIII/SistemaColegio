<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPeriodoActual
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
    Me.components = New System.ComponentModel.Container()
    Me.btnAceptar = New System.Windows.Forms.Button()
    Me.btnCancelar = New System.Windows.Forms.Button()
    Me.cboPeriodo = New System.Windows.Forms.ComboBox()
    Me.cboAnio = New System.Windows.Forms.ComboBox()
    Me.lblPeriodo = New System.Windows.Forms.Label()
    Me.cboInstitucion = New System.Windows.Forms.ComboBox()
    Me.lblInstitucion = New System.Windows.Forms.Label()
    Me.errPeriodoActual = New System.Windows.Forms.ErrorProvider(Me.components)
    CType(Me.errPeriodoActual, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnAceptar
    '
    Me.btnAceptar.Location = New System.Drawing.Point(260, 164)
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
    Me.btnAceptar.TabIndex = 12
    Me.btnAceptar.Text = "&Aceptar"
    Me.btnAceptar.UseVisualStyleBackColor = True
    '
    'btnCancelar
    '
    Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancelar.Location = New System.Drawing.Point(352, 163)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
    Me.btnCancelar.TabIndex = 13
    Me.btnCancelar.Text = "&Cancelar"
    Me.btnCancelar.UseVisualStyleBackColor = True
    '
    'cboPeriodo
    '
    Me.cboPeriodo.FormattingEnabled = True
    Me.cboPeriodo.Location = New System.Drawing.Point(202, 59)
    Me.cboPeriodo.Name = "cboPeriodo"
    Me.cboPeriodo.Size = New System.Drawing.Size(133, 21)
    Me.cboPeriodo.TabIndex = 11
    '
    'cboAnio
    '
    Me.cboAnio.FormattingEnabled = True
    Me.cboAnio.Location = New System.Drawing.Point(83, 59)
    Me.cboAnio.Name = "cboAnio"
    Me.cboAnio.Size = New System.Drawing.Size(107, 21)
    Me.cboAnio.TabIndex = 10
    '
    'lblPeriodo
    '
    Me.lblPeriodo.AutoSize = True
    Me.lblPeriodo.Location = New System.Drawing.Point(22, 67)
    Me.lblPeriodo.Name = "lblPeriodo"
    Me.lblPeriodo.Size = New System.Drawing.Size(43, 13)
    Me.lblPeriodo.TabIndex = 9
    Me.lblPeriodo.Text = "&Periodo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
    '
    'cboInstitucion
    '
    Me.cboInstitucion.FormattingEnabled = True
    Me.cboInstitucion.Location = New System.Drawing.Point(83, 22)
    Me.cboInstitucion.Name = "cboInstitucion"
    Me.cboInstitucion.Size = New System.Drawing.Size(344, 21)
    Me.cboInstitucion.TabIndex = 8
    '
    'lblInstitucion
    '
    Me.lblInstitucion.AutoSize = True
    Me.lblInstitucion.Location = New System.Drawing.Point(22, 30)
    Me.lblInstitucion.Name = "lblInstitucion"
    Me.lblInstitucion.Size = New System.Drawing.Size(55, 13)
    Me.lblInstitucion.TabIndex = 7
    Me.lblInstitucion.Text = "&Institución"
    '
    'errPeriodoActual
    '
    Me.errPeriodoActual.ContainerControl = Me
    '
    'frmPeriodoActual
    '
    Me.AcceptButton = Me.btnAceptar
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(464, 192)
    Me.Controls.Add(Me.btnAceptar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.cboPeriodo)
    Me.Controls.Add(Me.cboAnio)
    Me.Controls.Add(Me.lblPeriodo)
    Me.Controls.Add(Me.cboInstitucion)
    Me.Controls.Add(Me.lblInstitucion)
    Me.Name = "frmPeriodoActual"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Periodo Actual"
    CType(Me.errPeriodoActual, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnAceptar As System.Windows.Forms.Button
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
  Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
  Friend WithEvents lblPeriodo As System.Windows.Forms.Label
  Friend WithEvents cboInstitucion As System.Windows.Forms.ComboBox
  Friend WithEvents lblInstitucion As System.Windows.Forms.Label
  Friend WithEvents errPeriodoActual As System.Windows.Forms.ErrorProvider
End Class
