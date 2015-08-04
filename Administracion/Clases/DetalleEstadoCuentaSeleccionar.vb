Public Class DetalleEstadoCuentaSeleccionar
  Inherits DetalleEstadoCuenta

  Private mSeleccionado As Boolean

  Public Property Seleccionado() As Boolean
    Get
      Return mSeleccionado
    End Get
    Set(ByVal value As Boolean)
      mSeleccionado = value
    End Set
  End Property

  Public Sub New()

  End Sub

End Class
