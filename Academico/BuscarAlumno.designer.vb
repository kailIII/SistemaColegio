﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarAlumno
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
    Me.dgvAlumnos = New System.Windows.Forms.DataGridView
    Me.cdNombre = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.btnBuscar = New System.Windows.Forms.Button
    Me.GBAlumno = New System.Windows.Forms.GroupBox
    Me.txtNombreBuscar = New System.Windows.Forms.TextBox
    Me.Label1 = New System.Windows.Forms.Label
    Me.lblNombreBuscar = New System.Windows.Forms.Label
    CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.GBAlumno.SuspendLayout()
    Me.SuspendLayout()
    '
    'dgvAlumnos
    '
    Me.dgvAlumnos.AllowUserToAddRows = False
    Me.dgvAlumnos.AllowUserToDeleteRows = False
    Me.dgvAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cdNombre})
    Me.dgvAlumnos.Location = New System.Drawing.Point(3, 77)
    Me.dgvAlumnos.MultiSelect = False
    Me.dgvAlumnos.Name = "dgvAlumnos"
    Me.dgvAlumnos.ReadOnly = True
    Me.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgvAlumnos.Size = New System.Drawing.Size(534, 322)
    Me.dgvAlumnos.TabIndex = 2
    '
    'cdNombre
    '
    Me.cdNombre.DataPropertyName = "NombreCompleto"
    Me.cdNombre.HeaderText = "Alumno"
    Me.cdNombre.Name = "cdNombre"
    Me.cdNombre.ReadOnly = True
    Me.cdNombre.Width = 350
    '
    'btnBuscar
    '
    Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnBuscar.BackColor = System.Drawing.Color.White
    Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
    Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.7!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnBuscar.Location = New System.Drawing.Point(457, 19)
    Me.btnBuscar.Name = "btnBuscar"
    Me.btnBuscar.Size = New System.Drawing.Size(78, 37)
    Me.btnBuscar.TabIndex = 1
    Me.btnBuscar.Text = "&Buscar"
    Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnBuscar.UseVisualStyleBackColor = False
    '
    'GBAlumno
    '
    Me.GBAlumno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GBAlumno.Controls.Add(Me.txtNombreBuscar)
    Me.GBAlumno.Controls.Add(Me.Label1)
    Me.GBAlumno.Controls.Add(Me.lblNombreBuscar)
    Me.GBAlumno.Location = New System.Drawing.Point(3, 3)
    Me.GBAlumno.Name = "GBAlumno"
    Me.GBAlumno.Size = New System.Drawing.Size(450, 68)
    Me.GBAlumno.TabIndex = 0
    Me.GBAlumno.TabStop = False
    Me.GBAlumno.Text = "Alumno"
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
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
    Me.Label1.Location = New System.Drawing.Point(65, 46)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(248, 14)
    Me.Label1.TabIndex = 11
    Me.Label1.Text = "Orden:  ApePaterno    ApeMaterno   Nombre"
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
    'BuscarAlumno
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.GBAlumno)
    Me.Controls.Add(Me.btnBuscar)
    Me.Controls.Add(Me.dgvAlumnos)
    Me.Name = "BuscarAlumno"
    Me.Size = New System.Drawing.Size(539, 400)
    CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
    Me.GBAlumno.ResumeLayout(False)
    Me.GBAlumno.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents cdNombre As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents lblNombreBuscar As System.Windows.Forms.Label
  Public WithEvents dgvAlumnos As System.Windows.Forms.DataGridView
  Public WithEvents btnBuscar As System.Windows.Forms.Button
  Public WithEvents GBAlumno As System.Windows.Forms.GroupBox
  Public WithEvents txtNombreBuscar As System.Windows.Forms.TextBox

End Class
