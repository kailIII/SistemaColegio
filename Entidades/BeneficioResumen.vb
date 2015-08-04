Public Class BeneficioResumen

#Region "Datos"
  Private mMotivo As String
  Private mDescuento As Double
  Private mONivel As Nivel
  Private mCantidad As Integer
#End Region

  Public Property Nivel() As Nivel
    Get
      Return mONivel
    End Get
    Set(ByVal value As Nivel)
      mONivel = value
    End Set
  End Property

  Public ReadOnly Property NombreNivel() As String
    Get
      Return Me.Nivel.Nombre
    End Get
  End Property

  Public Property Descuento() As Double
    Get
      Return mDescuento
    End Get
    Set(ByVal value As Double)
      mDescuento = value
    End Set
  End Property

  Public Property Cantidad() As Integer
    Get
      Return mCantidad
    End Get
    Set(ByVal value As Integer)
      mCantidad = value
    End Set
  End Property

  Public Property Motivo() As String
    Get
      Return mMotivo
    End Get
    Set(ByVal value As String)
      mMotivo = value
    End Set
  End Property


End Class
