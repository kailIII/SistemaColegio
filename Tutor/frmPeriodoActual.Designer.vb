﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPeriodoActual
  Inherits Colegio.Plantillas.frmPlantilla

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
    Me.components = New System.ComponentModel.Container
    Me.lblInstitucion = New System.Windows.Forms.Label
    Me.cboInstitucion = New System.Windows.Forms.ComboBox
    Me.lblPeriodo = New System.Windows.Forms.Label
    Me.cboAnio = New System.Windows.Forms.ComboBox
    Me.cboPeriodo = New System.Windows.Forms.ComboBox
    Me.btnCancelar = New System.Windows.Forms.Button
    Me.btnAceptar = New System.Windows.Forms.Button
    Me.errPeriodoActual = New System.Windows.Forms.ErrorProvider(Me.components)
    CType(Me.errPeriodoActual, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'lblInstitucion
    '
    Me.lblInstitucion.AutoSize = True
    Me.lblInstitucion.Location = New System.Drawing.Point(20, 36)
    Me.lblInstitucion.Name = "lblInstitucion"
    Me.lblInstitucion.Size = New System.Drawing.Size(55, 13)
    Me.lblInstitucion.TabIndex = 0
    Me.lblInstitucion.Text = "&Institución"
    '
    'cboInstitucion
    '
    Me.cboInstitucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboInstitucion.FormattingEnabled = True
    Me.cboInstitucion.Location = New System.Drawing.Point(81, 28)
    Me.cboInstitucion.Name = "cboInstitucion"
    Me.cboInstitucion.Size = New System.Drawing.Size(344, 21)
    Me.cboInstitucion.TabIndex = 1
    '
    'lblPeriodo
    '
    Me.lblPeriodo.AutoSize = True
    Me.lblPeriodo.Location = New System.Drawing.Point(32, 73)
    Me.lblPeriodo.Name = "lblPeriodo"
    Me.lblPeriodo.Size = New System.Drawing.Size(43, 13)
    Me.lblPeriodo.TabIndex = 2
    Me.lblPeriodo.Text = "&Periodo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
    '
    'cboAnio
    '
    Me.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAnio.FormattingEnabled = True
    Me.cboAnio.Location = New System.Drawing.Point(81, 65)
    Me.cboAnio.Name = "cboAnio"
    Me.cboAnio.Size = New System.Drawing.Size(107, 21)
    Me.cboAnio.TabIndex = 3
    '
    'cboPeriodo
    '
    Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboPeriodo.FormattingEnabled = True
    Me.cboPeriodo.Location = New System.Drawing.Point(200, 65)
    Me.cboPeriodo.Name = "cboPeriodo"
    Me.cboPeriodo.Size = New System.Drawing.Size(133, 21)
    Me.cboPeriodo.TabIndex = 4
    '
    'btnCancelar
    '
    Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancelar.Location = New System.Drawing.Point(350, 169)
    Me.btnCancelar.Name = "btnCancelar"
    Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
    Me.btnCancelar.TabIndex = 6
    Me.btnCancelar.Text = "&Cancelar"
    Me.btnCancelar.UseVisualStyleBackColor = True
    '
    'btnAceptar
    '
    Me.btnAceptar.Location = New System.Drawing.Point(258, 170)
    Me.btnAceptar.Name = "btnAceptar"
    Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
    Me.btnAceptar.TabIndex = 5
    Me.btnAceptar.Text = "&Aceptar"
    Me.btnAceptar.UseVisualStyleBackColor = True
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
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.CancelButton = Me.btnCancelar
    Me.ClientSize = New System.Drawing.Size(437, 205)
    Me.Controls.Add(Me.btnAceptar)
    Me.Controls.Add(Me.btnCancelar)
    Me.Controls.Add(Me.cboPeriodo)
    Me.Controls.Add(Me.cboAnio)
    Me.Controls.Add(Me.lblPeriodo)
    Me.Controls.Add(Me.cboInstitucion)
    Me.Controls.Add(Me.lblInstitucion)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmPeriodoActual"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Institución"
    CType(Me.errPeriodoActual, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents lblInstitucion As System.Windows.Forms.Label
  Friend WithEvents cboInstitucion As System.Windows.Forms.ComboBox
  Friend WithEvents lblPeriodo As System.Windows.Forms.Label
  Friend WithEvents cboAnio As System.Windows.Forms.ComboBox
  Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
  Friend WithEvents btnCancelar As System.Windows.Forms.Button
  Friend WithEvents btnAceptar As System.Windows.Forms.Button
  Friend WithEvents errPeriodoActual As System.Windows.Forms.ErrorProvider
End Class
