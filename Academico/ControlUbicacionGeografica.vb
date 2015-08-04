Public Class ControlUbicacionGeografica

  Public Sub New()
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
  End Sub

  Public Sub CargarPaises()
    Dim ug As New RNUbicacionGeografica
    Dim lug As New List(Of UbicacionGeografica)

    lug = ug.ListarPaises()
    ug = Nothing
    Me.cbopais.DataSource = lug
    Me.cbopais.DisplayMember = "pais"
    Me.cbodpto.SelectedText = UCase("Lambayeque")
    Me.cbopPvcia.SelectedText = UCase("Chiclayo")
    Me.cbodistrito.SelectedText = UCase("Chiclayo")
  End Sub

  Private Sub cbodpto_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbodpto.Enter
    If cbopais.Text <> cbopais.Tag.ToString Then
      ListarDepartamentos()
    End If

  End Sub

  Public Sub ListarDepartamentos()
    Dim ug As RNUbicacionGeografica
    Dim lug As List(Of UbicacionGeografica)

    If cbopais.Text.Length > 0 Then
      ug = New RNUbicacionGeografica
      lug = ug.ListarDptos(cbopais.Text)
      ug = Nothing
      Me.cbodpto.DataSource = lug
      Me.cbodpto.DisplayMember = "departamento"
      If lug.Count = 0 Then
        cbodpto.Text = ""
      End If
    Else
      Me.cbodpto.DataSource = Nothing
      Me.cbodpto.Text = ""
    End If
    cbopais.Tag = cbopais.Text
  End Sub

  Private Sub cbopPvcia_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbopPvcia.Enter
    If cbodpto.Text <> cbodpto.Tag.ToString Then
      ListarProvincias()
    End If

  End Sub

  Public Sub ListarProvincias()
    Dim ug As RNUbicacionGeografica
    Dim lug As List(Of UbicacionGeografica)

    If cbodpto.Text.Length > 0 Then
      ug = New RNUbicacionGeografica
      lug = ug.ListarProvincias(cbopais.Text, cbodpto.Text)
      ug = Nothing
      Me.cbopPvcia.DataSource = lug
      Me.cbopPvcia.DisplayMember = "provincia"
      If lug.Count = 0 Then
        cbopPvcia.Text = ""
      End If
    Else
      Me.cbopPvcia.DataSource = Nothing
      Me.cbopPvcia.Text = ""
    End If
    cbodpto.Tag = cbodpto.Text
  End Sub

  Private Sub cbodistrito_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbodistrito.Enter
    If cbopPvcia.Text <> cbopPvcia.Tag.ToString Then
      ListarDistritos()
    End If
  End Sub

  Public Sub ListarDistritos()
    Dim ug As RNUbicacionGeografica
    Dim lug As List(Of UbicacionGeografica)

    If cbopPvcia.Text.Length > 0 Then
      ug = New RNUbicacionGeografica
      lug = ug.ListarDistritos(cbopais.Text, cbodpto.Text, cbopPvcia.Text)
      ug = Nothing
      Me.cbodistrito.DataSource = lug
      Me.cbodistrito.DisplayMember = "distrito"
      If lug.Count = 0 Then
        cbodistrito.Text = ""
      End If
    Else
      Me.cbodistrito.DataSource = Nothing
      Me.cbodistrito.Text = ""
    End If
    cbopPvcia.Tag = cbopPvcia.Text
  End Sub

  Private Sub ControlUbicacionGeografica_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    cbopais.Tag = ""
    cbodpto.Tag = ""
    cbopPvcia.Tag = ""
    cbodistrito.Tag = ""
  End Sub

End Class
