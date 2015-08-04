Public Class RegimenPension

#Region "Datos"
  Private mnroRegimenPension As String
  Private mnombre As String
  Private mvigencia As Boolean
  Private mporcentajeAporte As Double
  Private mporcentajePrima As Double
  Private mporcentajeComision As Double
#End Region
#Region "Propiedades"
  Public Property nroRegimenPension() As String
    Get
      Return Me.mnroRegimenPension
    End Get
    Set(ByVal value As String)
      Me.mnroRegimenPension = value
    End Set
  End Property
  Public Property nombre() As String
    Get
      Return Me.mnombre
    End Get
    Set(ByVal value As String)
      Me.mnombre = value
    End Set
  End Property
  Public Property vigencia() As Boolean
    Get
      Return Me.mvigencia
    End Get
    Set(ByVal value As Boolean)
      Me.mvigencia = value
    End Set
  End Property
  Public Property porcentajeAporte() As Double
    Get
      Return Me.mporcentajeAporte
    End Get
    Set(ByVal value As Double)
      Me.mporcentajeAporte = value
    End Set
  End Property
  Public Property porcentajePrima() As Double
    Get
      Return Me.mporcentajePrima
    End Get
    Set(ByVal value As Double)
      Me.mporcentajePrima = value
    End Set
  End Property
  Public Property porcentajeComision() As Double
    Get
      Return Me.mporcentajeComision
    End Get
    Set(ByVal value As Double)
      Me.mporcentajeComision = value
    End Set
  End Property
#End Region
#Region "Constructores"
  Public Sub New()
  End Sub
  Public Sub New(ByVal wnroRegimenPension As String, ByVal wnombre As String, ByVal wvigencia As Boolean, ByVal wporcentajeAporte As Double, ByVal wporcentajePrima As Double, ByVal wporcentajeComision As Double)
    Me.nroRegimenPension = wnroRegimenPension
    Me.nombre = wnombre
    Me.vigencia = wvigencia
    Me.porcentajeAporte = wporcentajeAporte
    Me.porcentajePrima = wporcentajePrima
    Me.porcentajeComision = wporcentajeComision
  End Sub
#End Region

End Class