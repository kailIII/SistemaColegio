<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImportarPlanLector
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
        Me.gbPeriodoAcad = New System.Windows.Forms.GroupBox
        Me.lblPeriodo = New System.Windows.Forms.Label
        Me.txtAnio = New System.Windows.Forms.TextBox
        Me.btnImportar = New System.Windows.Forms.Button
        Me.pbAvance = New System.Windows.Forms.ProgressBar
        Me.gbRuta = New System.Windows.Forms.GroupBox
        Me.btnExaminar = New System.Windows.Forms.Button
        Me.txtRuta = New System.Windows.Forms.TextBox
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.ofdArchivo = New System.Windows.Forms.OpenFileDialog
        Me.gbPeriodoAcad.SuspendLayout()
        Me.gbRuta.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbPeriodoAcad
        '
        Me.gbPeriodoAcad.Controls.Add(Me.lblPeriodo)
        Me.gbPeriodoAcad.Controls.Add(Me.txtAnio)
        Me.gbPeriodoAcad.Location = New System.Drawing.Point(12, 12)
        Me.gbPeriodoAcad.Name = "gbPeriodoAcad"
        Me.gbPeriodoAcad.Size = New System.Drawing.Size(301, 64)
        Me.gbPeriodoAcad.TabIndex = 14
        Me.gbPeriodoAcad.TabStop = False
        Me.gbPeriodoAcad.Text = "Año Académico"
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodo.Location = New System.Drawing.Point(32, 30)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(28, 15)
        Me.lblPeriodo.TabIndex = 0
        Me.lblPeriodo.Text = "Año"
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
        'btnImportar
        '
        Me.btnImportar.BackColor = System.Drawing.Color.White
        Me.btnImportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImportar.Location = New System.Drawing.Point(300, 251)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(110, 50)
        Me.btnImportar.TabIndex = 12
        Me.btnImportar.Text = "&Importar"
        Me.btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImportar.UseVisualStyleBackColor = False
        '
        'pbAvance
        '
        Me.pbAvance.Location = New System.Drawing.Point(12, 210)
        Me.pbAvance.Name = "pbAvance"
        Me.pbAvance.Size = New System.Drawing.Size(514, 23)
        Me.pbAvance.TabIndex = 11
        '
        'gbRuta
        '
        Me.gbRuta.Controls.Add(Me.btnExaminar)
        Me.gbRuta.Controls.Add(Me.txtRuta)
        Me.gbRuta.Location = New System.Drawing.Point(12, 90)
        Me.gbRuta.Name = "gbRuta"
        Me.gbRuta.Size = New System.Drawing.Size(514, 102)
        Me.gbRuta.TabIndex = 10
        Me.gbRuta.TabStop = False
        Me.gbRuta.Text = "Seleccionar Archivo"
        '
        'btnExaminar
        '
        Me.btnExaminar.Location = New System.Drawing.Point(434, 33)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(44, 23)
        Me.btnExaminar.TabIndex = 0
        Me.btnExaminar.Text = "&..."
        Me.btnExaminar.UseVisualStyleBackColor = True
        '
        'txtRuta
        '
        Me.txtRuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRuta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuta.Location = New System.Drawing.Point(37, 32)
        Me.txtRuta.Multiline = True
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.ReadOnly = True
        Me.txtRuta.Size = New System.Drawing.Size(391, 48)
        Me.txtRuta.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(416, 251)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(110, 50)
        Me.btnCerrar.TabIndex = 13
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'ofdArchivo
        '
        Me.ofdArchivo.FileName = "OpenFileDialog1"
        '
        'frmImportarPlanLector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 327)
        Me.Controls.Add(Me.gbPeriodoAcad)
        Me.Controls.Add(Me.btnImportar)
        Me.Controls.Add(Me.pbAvance)
        Me.Controls.Add(Me.gbRuta)
        Me.Controls.Add(Me.btnCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmImportarPlanLector"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mportar Registro PlanLector"
        Me.gbPeriodoAcad.ResumeLayout(False)
        Me.gbPeriodoAcad.PerformLayout()
        Me.gbRuta.ResumeLayout(False)
        Me.gbRuta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbPeriodoAcad As System.Windows.Forms.GroupBox
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents txtAnio As System.Windows.Forms.TextBox
    Friend WithEvents btnImportar As System.Windows.Forms.Button
    Friend WithEvents pbAvance As System.Windows.Forms.ProgressBar
    Friend WithEvents gbRuta As System.Windows.Forms.GroupBox
    Friend WithEvents btnExaminar As System.Windows.Forms.Button
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents ofdArchivo As System.Windows.Forms.OpenFileDialog
End Class
