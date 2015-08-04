Public Class frmBuscarDocente

  Public Docente As New Docente

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    BuscarDocente()
  End Sub

  Private Sub BuscarDocente()
    Dim obj As New RNDocente
    Dim ld As List(Of Docente)

    ld = obj.ListarDoc(txtNombreBuscar.Text.Trim)
    dgvDocentes.AutoGenerateColumns = False
    dgvDocentes.DataSource = ld
    If Me.dgvDocentes.RowCount > 0 Then
      Me.btnSeleccionar.Enabled = True
      Dim i As Integer
      For i = 0 To Me.dgvDocentes.RowCount - 1
        Me.dgvDocentes.Item(0, i).Value() = i + 1
      Next
    Else
      Me.btnSeleccionar.Enabled = False
    End If
    Me.dgvDocentes.Focus()
  End Sub

  Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click, dgvDocentes.DoubleClick
    Seleccionar()
  End Sub

  Private Sub Seleccionar()
    Dim obj As RNDocente = Nothing

    If dgvDocentes.SelectedRows.Count > 0 Then
      obj = New RNDocente
      Try
        Docente = CType(Me.dgvDocentes.Rows(Me.dgvDocentes.CurrentRow.Index).DataBoundItem, Docente)
        Me.Close()
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    End If
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Docente = Nothing
    Me.Close()
  End Sub

  Public Function Buscar() As Docente
    Me.ShowDialog()
    If Docente Is Nothing Then
      Return Nothing
    Else
      If Docente.Codigo = Nothing Then
        Return Nothing
      Else
        Return Docente
      End If
    End If
  End Function

  Private Sub frmBuscarDocente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnSeleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnBuscar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Buscar.png")

    If Me.dgvDocentes.RowCount = 0 Then
      Me.btnSeleccionar.Enabled = False
    End If
    Me.txtNombreBuscar.Focus()
  End Sub

  Private Sub txtNombreBuscar_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreBuscar.Enter
    Me.AcceptButton = Me.btnBuscar
  End Sub

  Private Sub dgvDocentes_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvDocentes.Enter
    Me.AcceptButton = Me.btnSeleccionar
  End Sub

  Private Sub dgvDocentes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvDocentes.KeyDown
    If e.KeyCode = Keys.Enter Then
      btnSeleccionar.PerformClick()
      e.Handled = True
    End If
  End Sub

End Class