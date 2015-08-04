<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteAlumnosPlanLectorPromedio
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
    Me.btnExportar = New System.Windows.Forms.Button
    Me.btnCerrar = New System.Windows.Forms.Button
    Me.pbAvance = New System.Windows.Forms.ProgressBar
    Me.gbInterno = New System.Windows.Forms.GroupBox
    Me.cboCriterio = New System.Windows.Forms.ComboBox
    Me.lblCriterio = New System.Windows.Forms.Label
    Me.cboPresentacion = New System.Windows.Forms.ComboBox
    Me.lblPres = New System.Windows.Forms.Label
    Me.cboSeccion = New System.Windows.Forms.ComboBox
    Me.lblSeccion = New System.Windows.Forms.Label
    Me.gbPeriodoAcad = New System.Windows.Forms.GroupBox
    Me.cboNivel = New System.Windows.Forms.ComboBox
    Me.lblNivel = New System.Windows.Forms.Label
    Me.lblPeriodo = New System.Windows.Forms.Label
    Me.txtAnio = New System.Windows.Forms.TextBox
    Me.sfdArchivos = New System.Windows.Forms.SaveFileDialog
    Me.gbInterno.SuspendLayout()
    Me.gbPeriodoAcad.SuspendLayout()
    Me.SuspendLayout()
    '
    'btnExportar
    '
    Me.btnExportar.BackColor = System.Drawing.Color.White
    Me.btnExportar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnExportar.Location = New System.Drawing.Point(146, 332)
    Me.btnExportar.Name = "btnExportar"
    Me.btnExportar.Size = New System.Drawing.Size(110, 52)
    Me.btnExportar.TabIndex = 3
    Me.btnExportar.Text = "&Exportar"
    Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnExportar.UseVisualStyleBackColor = False
    '
    'btnCerrar
    '
    Me.btnCerrar.BackColor = System.Drawing.Color.White
    Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCerrar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnCerrar.Location = New System.Drawing.Point(302, 332)
    Me.btnCerrar.Name = "btnCerrar"
    Me.btnCerrar.Size = New System.Drawing.Size(110, 52)
    Me.btnCerrar.TabIndex = 4
    Me.btnCerrar.Text = "&Cerrar"
    Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    Me.btnCerrar.UseVisualStyleBackColor = False
    '
    'pbAvance
    '
    Me.pbAvance.BackColor = System.Drawing.Color.White
    Me.pbAvance.Location = New System.Drawing.Point(27, 290)
    Me.pbAvance.Name = "pbAvance"
    Me.pbAvance.Size = New System.Drawing.Size(382, 20)
    Me.pbAvance.TabIndex = 2
    '
    'gbInterno
    '
    Me.gbInterno.Controls.Add(Me.cboCriterio)
    Me.gbInterno.Controls.Add(Me.lblCriterio)
    Me.gbInterno.Controls.Add(Me.cboPresentacion)
    Me.gbInterno.Controls.Add(Me.lblPres)
    Me.gbInterno.Controls.Add(Me.cboSeccion)
    Me.gbInterno.Controls.Add(Me.lblSeccion)
    Me.gbInterno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbInterno.Location = New System.Drawing.Point(15, 134)
    Me.gbInterno.Name = "gbInterno"
    Me.gbInterno.Size = New System.Drawing.Size(400, 150)
    Me.gbInterno.TabIndex = 1
    Me.gbInterno.TabStop = False
    Me.gbInterno.Text = "Sección - Presentación"
    '
    'cboCriterio
    '
    Me.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboCriterio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.cboCriterio.FormattingEnabled = True
    Me.cboCriterio.Items.AddRange(New Object() {"Todos", "Alumnos aprobados con AD", "Alumnos aprobados con A", "Alumnos aprobados con B", "Alumnos aprobados", "Alumnos desaprobados", "Alumnos que no se presentaron"})
    Me.cboCriterio.Location = New System.Drawing.Point(131, 100)
    Me.cboCriterio.Name = "cboCriterio"
    Me.cboCriterio.Size = New System.Drawing.Size(263, 25)
    Me.cboCriterio.TabIndex = 5
    '
    'lblCriterio
    '
    Me.lblCriterio.AutoSize = True
    Me.lblCriterio.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblCriterio.Location = New System.Drawing.Point(32, 108)
    Me.lblCriterio.Name = "lblCriterio"
    Me.lblCriterio.Size = New System.Drawing.Size(52, 17)
    Me.lblCriterio.TabIndex = 4
    Me.lblCriterio.Text = "C&riterio"
    '
    'cboPresentacion
    '
    Me.cboPresentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboPresentacion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.cboPresentacion.FormattingEnabled = True
    Me.cboPresentacion.Location = New System.Drawing.Point(131, 64)
    Me.cboPresentacion.Name = "cboPresentacion"
    Me.cboPresentacion.Size = New System.Drawing.Size(263, 25)
    Me.cboPresentacion.TabIndex = 2
    '
    'lblPres
    '
    Me.lblPres.AutoSize = True
    Me.lblPres.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblPres.Location = New System.Drawing.Point(32, 72)
    Me.lblPres.Name = "lblPres"
    Me.lblPres.Size = New System.Drawing.Size(84, 17)
    Me.lblPres.TabIndex = 3
    Me.lblPres.Text = "Presentación"
    '
    'cboSeccion
    '
    Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSeccion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.cboSeccion.FormattingEnabled = True
    Me.cboSeccion.Location = New System.Drawing.Point(131, 28)
    Me.cboSeccion.Name = "cboSeccion"
    Me.cboSeccion.Size = New System.Drawing.Size(263, 25)
    Me.cboSeccion.TabIndex = 1
    '
    'lblSeccion
    '
    Me.lblSeccion.AutoSize = True
    Me.lblSeccion.Font = New System.Drawing.Font("Times New Roman", 11.25!)
    Me.lblSeccion.Location = New System.Drawing.Point(32, 36)
    Me.lblSeccion.Name = "lblSeccion"
    Me.lblSeccion.Size = New System.Drawing.Size(54, 17)
    Me.lblSeccion.TabIndex = 0
    Me.lblSeccion.Text = "&Sección"
    '
    'gbPeriodoAcad
    '
    Me.gbPeriodoAcad.Controls.Add(Me.cboNivel)
    Me.gbPeriodoAcad.Controls.Add(Me.lblNivel)
    Me.gbPeriodoAcad.Controls.Add(Me.lblPeriodo)
    Me.gbPeriodoAcad.Controls.Add(Me.txtAnio)
    Me.gbPeriodoAcad.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.gbPeriodoAcad.Location = New System.Drawing.Point(15, 9)
    Me.gbPeriodoAcad.Name = "gbPeriodoAcad"
    Me.gbPeriodoAcad.Size = New System.Drawing.Size(400, 99)
    Me.gbPeriodoAcad.TabIndex = 0
    Me.gbPeriodoAcad.TabStop = False
    Me.gbPeriodoAcad.Text = "Año Académico"
    '
    'cboNivel
    '
    Me.cboNivel.BackColor = System.Drawing.SystemColors.Info
    Me.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNivel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cboNivel.FormattingEnabled = True
    Me.cboNivel.Location = New System.Drawing.Point(114, 60)
    Me.cboNivel.Name = "cboNivel"
    Me.cboNivel.Size = New System.Drawing.Size(280, 24)
    Me.cboNivel.TabIndex = 3
    '
    'lblNivel
    '
    Me.lblNivel.AutoSize = True
    Me.lblNivel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblNivel.Location = New System.Drawing.Point(32, 69)
    Me.lblNivel.Name = "lblNivel"
    Me.lblNivel.Size = New System.Drawing.Size(35, 15)
    Me.lblNivel.TabIndex = 2
    Me.lblNivel.Text = "&Nivel"
    '
    'lblPeriodo
    '
    Me.lblPeriodo.AutoSize = True
    Me.lblPeriodo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblPeriodo.Location = New System.Drawing.Point(32, 27)
    Me.lblPeriodo.Name = "lblPeriodo"
    Me.lblPeriodo.Size = New System.Drawing.Size(33, 17)
    Me.lblPeriodo.TabIndex = 0
    Me.lblPeriodo.Text = "Año"
    '
    'txtAnio
    '
    Me.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.txtAnio.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAnio.Location = New System.Drawing.Point(114, 24)
    Me.txtAnio.Name = "txtAnio"
    Me.txtAnio.ReadOnly = True
    Me.txtAnio.Size = New System.Drawing.Size(173, 25)
    Me.txtAnio.TabIndex = 1
    Me.txtAnio.TabStop = False
    Me.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'frmReporteAlumnosPlanLectorPromedio
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(427, 396)
    Me.Controls.Add(Me.btnExportar)
    Me.Controls.Add(Me.btnCerrar)
    Me.Controls.Add(Me.pbAvance)
    Me.Controls.Add(Me.gbInterno)
    Me.Controls.Add(Me.gbPeriodoAcad)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmReporteAlumnosPlanLectorPromedio"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Listado de alumnos con promedio"
    Me.gbInterno.ResumeLayout(False)
    Me.gbInterno.PerformLayout()
    Me.gbPeriodoAcad.ResumeLayout(False)
    Me.gbPeriodoAcad.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnExportar As System.Windows.Forms.Button
  Friend WithEvents btnCerrar As System.Windows.Forms.Button
  Friend WithEvents pbAvance As System.Windows.Forms.ProgressBar
  Friend WithEvents gbInterno As System.Windows.Forms.GroupBox
  Friend WithEvents cboPresentacion As System.Windows.Forms.ComboBox
  Friend WithEvents lblPres As System.Windows.Forms.Label
  Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
  Friend WithEvents lblSeccion As System.Windows.Forms.Label
  Friend WithEvents gbPeriodoAcad As System.Windows.Forms.GroupBox
  Friend WithEvents lblPeriodo As System.Windows.Forms.Label
  Friend WithEvents txtAnio As System.Windows.Forms.TextBox
  Friend WithEvents sfdArchivos As System.Windows.Forms.SaveFileDialog
  Friend WithEvents cboCriterio As System.Windows.Forms.ComboBox
  Friend WithEvents lblCriterio As System.Windows.Forms.Label
  Friend WithEvents cboNivel As System.Windows.Forms.ComboBox
  Friend WithEvents lblNivel As System.Windows.Forms.Label
End Class
