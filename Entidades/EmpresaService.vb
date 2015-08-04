Public Class EmpresaService

#Region "Datos"
  Private mcodigoService As Integer
  Private mRUC As String
  Private mrazonSocial As String
  Private mtipoActividad As String
  Private mdenominacionEstable As String
  Private mcentroRiesgo As Boolean
  Private mtasaSCTR As Double
#End Region
#Region "Propiedades"
  Public Property codigoService() As Integer
    Get
      Return Me.mcodigoService
    End Get
    Set(ByVal value As Integer)
      Me.mcodigoService = value
    End Set
  End Property
  Public Property RUC() As String
    Get
      Return Me.mRUC
    End Get
    Set(ByVal value As String)
      Me.mRUC = value
    End Set
  End Property
  Public Property razonSocial() As String
    Get
      Return Me.mrazonSocial
    End Get
    Set(ByVal value As String)
      Me.mrazonSocial = value
    End Set
  End Property
  Public Property tipoActividad() As String
    Get
      Return Me.mtipoActividad
    End Get
    Set(ByVal value As String)
      Me.mtipoActividad = value
    End Set
  End Property
  Public Property denominacionEstable() As String
    Get
      Return Me.mdenominacionEstable
    End Get
    Set(ByVal value As String)
      Me.mdenominacionEstable = value
    End Set
  End Property
  Public Property centroRiesgo() As Boolean
    Get
      Return Me.mcentroRiesgo
    End Get
    Set(ByVal value As Boolean)
      Me.mcentroRiesgo = value
    End Set
  End Property
  Public Property tasaSCTR() As Double
    Get
      Return Me.mtasaSCTR
    End Get
    Set(ByVal value As Double)
      Me.mtasaSCTR = value
    End Set
  End Property
#End Region
#Region "Constructores"
  Public Sub New()
  End Sub
  Public Sub New(ByVal wcodigoService As Integer, ByVal wRUC As String, ByVal wrazonSocial As String, ByVal wtipoActividad As String, ByVal wdenominacionEstable As String, ByVal wcentroRiesgo As Boolean, ByVal wtasaSCTR As Double)
    Me.codigoService = wcodigoService
    Me.RUC = wRUC
    Me.razonSocial = wrazonSocial
    Me.tipoActividad = wtipoActividad
    Me.denominacionEstable = wdenominacionEstable
    Me.centroRiesgo = wcentroRiesgo
    Me.tasaSCTR = wtasaSCTR
  End Sub
#End Region

End Class