﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarLibro
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GBAlumno = New System.Windows.Forms.GroupBox
        Me.txtNombreBuscar = New System.Windows.Forms.TextBox
        Me.lblNombreBuscar = New System.Windows.Forms.Label
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnseleccionar = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.dgvLibros = New System.Windows.Forms.DataGridView
        Me.cdNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GBAlumno.SuspendLayout()
        CType(Me.dgvLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBAlumno
        '
        Me.GBAlumno.Controls.Add(Me.txtNombreBuscar)
        Me.GBAlumno.Controls.Add(Me.lblNombreBuscar)
        Me.GBAlumno.Location = New System.Drawing.Point(19, 12)
        Me.GBAlumno.Name = "GBAlumno"
        Me.GBAlumno.Size = New System.Drawing.Size(450, 68)
        Me.GBAlumno.TabIndex = 5
        Me.GBAlumno.TabStop = False
        Me.GBAlumno.Text = "Libro"
        '
        'txtNombreBuscar
        '
        Me.txtNombreBuscar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreBuscar.Location = New System.Drawing.Point(68, 19)
        Me.txtNombreBuscar.Multiline = True
        Me.txtNombreBuscar.Name = "txtNombreBuscar"
        Me.txtNombreBuscar.Size = New System.Drawing.Size(375, 24)
        Me.txtNombreBuscar.TabIndex = 1
        '
        'lblNombreBuscar
        '
        Me.lblNombreBuscar.AutoSize = True
        Me.lblNombreBuscar.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreBuscar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreBuscar.Location = New System.Drawing.Point(17, 23)
        Me.lblNombreBuscar.Name = "lblNombreBuscar"
        Me.lblNombreBuscar.Size = New System.Drawing.Size(52, 15)
        Me.lblNombreBuscar.TabIndex = 0
        Me.lblNombreBuscar.Text = "N&ombre:"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(570, 376)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(110, 52)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "C&ancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnseleccionar
        '
        Me.btnseleccionar.BackColor = System.Drawing.Color.White
        Me.btnseleccionar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnseleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnseleccionar.Location = New System.Drawing.Point(570, 193)
        Me.btnseleccionar.Name = "btnseleccionar"
        Me.btnseleccionar.Size = New System.Drawing.Size(110, 52)
        Me.btnseleccionar.TabIndex = 8
        Me.btnseleccionar.Text = "&Seleccionar"
        Me.btnseleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnseleccionar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.White
        Me.btnBuscar.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(475, 24)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(78, 37)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'dgvLibros
        '
        Me.dgvLibros.AllowUserToAddRows = False
        Me.dgvLibros.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLibros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLibros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNombre})
        Me.dgvLibros.Location = New System.Drawing.Point(19, 86)
        Me.dgvLibros.MultiSelect = False
        Me.dgvLibros.Name = "dgvLibros"
        Me.dgvLibros.ReadOnly = True
        Me.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLibros.Size = New System.Drawing.Size(534, 403)
        Me.dgvLibros.TabIndex = 7
        '
        'cdNombre
        '
        Me.cdNombre.DataPropertyName = "Titulo"
        Me.cdNombre.HeaderText = "Libro"
        Me.cdNombre.Name = "cdNombre"
        Me.cdNombre.ReadOnly = True
        Me.cdNombre.Width = 470
        '
        'frmBuscarLibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 501)
        Me.Controls.Add(Me.GBAlumno)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnseleccionar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dgvLibros)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscarLibro"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Libro"
        Me.GBAlumno.ResumeLayout(False)
        Me.GBAlumno.PerformLayout()
        CType(Me.dgvLibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBAlumno As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombreBuscar As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreBuscar As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnseleccionar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents dgvLibros As System.Windows.Forms.DataGridView
    Friend WithEvents cdNombre As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
