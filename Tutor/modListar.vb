Public Class modListar

  Public Sub ListarNiveles(ByVal cbo As ComboBox)
    Dim obj As New RNNivel
    Dim ld As New List(Of Nivel)

    ld = obj.Listar
    obj = Nothing
    cbo.DisplayMember = "nombre"
    cbo.ValueMember = "codigo"
    cbo.DataSource = ld
    'cbo.SelectedIndex = 0
  End Sub

End Class
