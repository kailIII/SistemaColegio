Public Class frmBuscarAreaDRE
  Private A As AreaDRE

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Close()
  End Sub

  Private Sub frmBuscarAreaDRE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ListarAreaDRE()
    MostrarImagenes()
    If Me.dgvAreaDRE.RowCount = 0 Then
      Me.btnSeleccionar.Enabled = False
    End If
  End Sub

  Public Sub MostrarImagenes()
    Me.btnSeleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
  End Sub

  Public Sub ListarAreaDRE()
    'Dim obj As New RNAreaDRe
    'Dim lg As List(Of AreaDRE)

    ''lg = obj.ListarAreaDRE
    'dgvAreaDRE.AutoGenerateColumns = False
    'dgvAreaDRE.DataSource = lg
    'Me.dgvAreaDRE.Columns(0).DataPropertyName = "NombreNivel"
    'Me.dgvAreaDRE.Columns(1).DataPropertyName = "Nombre"
  End Sub

  Public Function Buscar() As AreaDRE
    Me.ShowDialog()
    If A Is Nothing Then
      Return Nothing
    Else
      Return A
    End If
  End Function

  Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click, dgvAreaDRE.DoubleClick
    Dim obj As RNAreaDRe = Nothing

    If dgvAreaDRE.SelectedRows.Count > 0 Then
      obj = New RNAreaDRe
      Try
        A = CType(Me.dgvAreaDRE.Rows(Me.dgvAreaDRE.CurrentRow.Index).DataBoundItem, AreaDRE)
        Me.Close()
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    End If
  End Sub
End Class