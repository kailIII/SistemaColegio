<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlUbicacionGeografica
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
    Me.Label14 = New System.Windows.Forms.Label
    Me.cbodpto = New System.Windows.Forms.ComboBox
    Me.Label16 = New System.Windows.Forms.Label
    Me.Label15 = New System.Windows.Forms.Label
    Me.cbopPvcia = New System.Windows.Forms.ComboBox
    Me.cbopais = New System.Windows.Forms.ComboBox
    Me.Label17 = New System.Windows.Forms.Label
    Me.cbodistrito = New System.Windows.Forms.ComboBox
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label14
    '
    Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.Label14.AutoSize = True
    Me.Label14.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label14.Location = New System.Drawing.Point(3, 93)
    Me.Label14.Name = "Label14"
    Me.Label14.Size = New System.Drawing.Size(52, 15)
    Me.Label14.TabIndex = 4
    Me.Label14.Text = "Provincia"
    '
    'cbodpto
    '
    Me.cbodpto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbodpto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cbodpto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cbodpto.FormattingEnabled = True
    Me.cbodpto.Items.AddRange(New Object() {""})
    Me.cbodpto.Location = New System.Drawing.Point(301, 38)
    Me.cbodpto.Name = "cbodpto"
    Me.cbodpto.Size = New System.Drawing.Size(129, 21)
    Me.cbodpto.TabIndex = 3
    '
    'Label16
    '
    Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.Label16.AutoSize = True
    Me.Label16.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label16.Location = New System.Drawing.Point(3, 47)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(28, 15)
    Me.Label16.TabIndex = 0
    Me.Label16.Text = "Pais"
    '
    'Label15
    '
    Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.Label15.AutoSize = True
    Me.Label15.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label15.Location = New System.Drawing.Point(218, 47)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(75, 15)
    Me.Label15.TabIndex = 2
    Me.Label15.Text = "Departamento"
    '
    'cbopPvcia
    '
    Me.cbopPvcia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbopPvcia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cbopPvcia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cbopPvcia.FormattingEnabled = True
    Me.cbopPvcia.Location = New System.Drawing.Point(72, 84)
    Me.cbopPvcia.Name = "cbopPvcia"
    Me.cbopPvcia.Size = New System.Drawing.Size(140, 21)
    Me.cbopPvcia.TabIndex = 5
    '
    'cbopais
    '
    Me.cbopais.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbopais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cbopais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cbopais.FormattingEnabled = True
    Me.cbopais.Items.AddRange(New Object() {""})
    Me.cbopais.Location = New System.Drawing.Point(72, 38)
    Me.cbopais.Name = "cbopais"
    Me.cbopais.Size = New System.Drawing.Size(140, 21)
    Me.cbopais.TabIndex = 1
    '
    'Label17
    '
    Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.Label17.AutoSize = True
    Me.Label17.Font = New System.Drawing.Font("Arial Unicode MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label17.Location = New System.Drawing.Point(218, 93)
    Me.Label17.Name = "Label17"
    Me.Label17.Size = New System.Drawing.Size(41, 15)
    Me.Label17.TabIndex = 6
    Me.Label17.Text = "Distrito"
    '
    'cbodistrito
    '
    Me.cbodistrito.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cbodistrito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    Me.cbodistrito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
    Me.cbodistrito.FormattingEnabled = True
    Me.cbodistrito.Location = New System.Drawing.Point(301, 84)
    Me.cbodistrito.Name = "cbodistrito"
    Me.cbodistrito.Size = New System.Drawing.Size(129, 21)
    Me.cbodistrito.TabIndex = 7
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 4
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.24299!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.75701!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.cbodistrito, 3, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.cbopPvcia, 1, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.Label17, 2, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.cbodpto, 3, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Label15, 2, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Label16, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Me.Label14, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.cbopais, 1, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.40741!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.59259!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(433, 108)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'ControlUbicacionGeografica
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Name = "ControlUbicacionGeografica"
    Me.Size = New System.Drawing.Size(433, 108)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Public WithEvents Label14 As System.Windows.Forms.Label
  Public WithEvents cbodpto As System.Windows.Forms.ComboBox
  Public WithEvents Label16 As System.Windows.Forms.Label
  Public WithEvents Label15 As System.Windows.Forms.Label
  Public WithEvents cbopPvcia As System.Windows.Forms.ComboBox
  Public WithEvents cbopais As System.Windows.Forms.ComboBox
  Public WithEvents Label17 As System.Windows.Forms.Label
  Public WithEvents cbodistrito As System.Windows.Forms.ComboBox
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

End Class
