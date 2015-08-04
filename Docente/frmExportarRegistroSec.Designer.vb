<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportarRegistroSec
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
        Me.gbPeriodoAcad = New System.Windows.Forms.GroupBox
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.txtAnio = New System.Windows.Forms.TextBox
        Me.gbInterno = New System.Windows.Forms.GroupBox
        Me.cboCurso = New System.Windows.Forms.ComboBox
        Me.lblCurso = New System.Windows.Forms.Label
        Me.gbContenedor = New System.Windows.Forms.GroupBox
        Me.pbAvance = New System.Windows.Forms.ProgressBar
        Me.btnExportar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.sfdArchivos = New System.Windows.Forms.SaveFileDialog
        Me.gbPeriodoAcad.SuspendLayout()
        Me.gbInterno.SuspendLayout()
        Me.gbContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbPeriodoAcad
        '
        Me.gbPeriodoAcad.Controls.Add(Me.lblPeriodo)
        Me.gbPeriodoAcad.Controls.Add(Me.txtAnio)
        Me.gbPeriodoAcad.Location = New System.Drawing.Point(22, 12)
        Me.gbPeriodoAcad.Name = "gbPeriodoAcad"
        Me.gbPeriodoAcad.Size = New System.Drawing.Size(301, 64)
        Me.gbPeriodoAcad.TabIndex = 4
        Me.gbPeriodoAcad.TabStop = False
        Me.gbPeriodoAcad.Text = "Año Académico"
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodo.Location = New System.Drawing.Point(32, 30)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(44, 15)
        Me.lblPeriodo.TabIndex = 0
        Me.lblPeriodo.Text = "Periodo"
        '
        'txtAnio
        '
        Me.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAnio.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnio.Location = New System.Drawing.Point(81, 27)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.ReadOnly = True
        Me.txtAnio.Size = New System.Drawing.Size(187, 22)
        Me.txtAnio.TabIndex = 1
        Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gbInterno
        '
        Me.gbInterno.Controls.Add(Me.cboCurso)
        Me.gbInterno.Controls.Add(Me.lblCurso)
        Me.gbInterno.Location = New System.Drawing.Point(24, 19)
        Me.gbInterno.Name = "gbInterno"
        Me.gbInterno.Size = New System.Drawing.Size(466, 64)
        Me.gbInterno.TabIndex = 0
        Me.gbInterno.TabStop = False
        Me.gbInterno.Text = "Nivel - Grado - Sección - Curso"
        '
        'cboCurso
        '
        Me.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCurso.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCurso.FormattingEnabled = True
        Me.cboCurso.Location = New System.Drawing.Point(104, 23)
        Me.cboCurso.Name = "cboCurso"
        Me.cboCurso.Size = New System.Drawing.Size(330, 24)
        Me.cboCurso.TabIndex = 1
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurso.Location = New System.Drawing.Point(33, 27)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(71, 15)
        Me.lblCurso.TabIndex = 0
        Me.lblCurso.Text = "&Descripción"
        '
        'gbContenedor
        '
        Me.gbContenedor.Controls.Add(Me.gbInterno)
        Me.gbContenedor.Location = New System.Drawing.Point(22, 85)
        Me.gbContenedor.Name = "gbContenedor"
        Me.gbContenedor.Size = New System.Drawing.Size(514, 102)
        Me.gbContenedor.TabIndex = 0
        Me.gbContenedor.TabStop = False
        '
        'pbAvance
        '
        Me.pbAvance.Location = New System.Drawing.Point(22, 206)
        Me.pbAvance.Name = "pbAvance"
        Me.pbAvance.Size = New System.Drawing.Size(514, 23)
        Me.pbAvance.TabIndex = 1
        '
        'btnExportar
        '
        Me.btnExportar.BackColor = System.Drawing.Color.White
        Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportar.Location = New System.Drawing.Point(310, 249)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(110, 50)
        Me.btnExportar.TabIndex = 2
        Me.btnExportar.Text = "&Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(426, 249)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(110, 50)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'frmExportarRegistroSec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 315)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.gbPeriodoAcad)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.pbAvance)
        Me.Controls.Add(Me.gbContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmExportarRegistroSec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exportar Registro - Secundaria"
        Me.gbPeriodoAcad.ResumeLayout(False)
        Me.gbPeriodoAcad.PerformLayout()
        Me.gbInterno.ResumeLayout(False)
        Me.gbInterno.PerformLayout()
        Me.gbContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
  Friend WithEvents gbPeriodoAcad As System.Windows.Forms.GroupBox
  Friend WithEvents lblPeriodo As System.Windows.Forms.Label
  Friend WithEvents txtAnio As System.Windows.Forms.TextBox
  Friend WithEvents gbInterno As System.Windows.Forms.GroupBox
  Friend WithEvents cboCurso As System.Windows.Forms.ComboBox
  Friend WithEvents lblCurso As System.Windows.Forms.Label
  Friend WithEvents gbContenedor As System.Windows.Forms.GroupBox
  Friend WithEvents pbAvance As System.Windows.Forms.ProgressBar
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents sfdArchivos As System.Windows.Forms.SaveFileDialog
End Class
