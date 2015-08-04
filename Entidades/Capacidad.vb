Public Class Capacidad

#Region "Datos"
  Private mCodigo As Integer
  Private mNombre As String
  Private mOAreaDRE As AreaDRE
  Private mVigencia As Boolean
#End Region

#Region "Propiedades"
  Public Property Codigo() As Integer
    Get
      Return mCodigo
    End Get
    Set(ByVal value As Integer)
      mCodigo = value
    End Set
  End Property
  Public Property Nombre() As String
    Get
      Return mNombre
    End Get
    Set(ByVal value As String)
      mNombre = value
    End Set
  End Property
  Public Property AreaDre() As AreaDRE
    Get
      Return mOAreaDRE
    End Get
    Set(ByVal value As AreaDRE)
      mOAreaDRE = value
    End Set
  End Property
  Public Property Vigencia() As Boolean
    Get
      Return mVigencia
    End Get
    Set(ByVal value As Boolean)
      mVigencia = value
    End Set
  End Property
#End Region

#Region "Constructores"
  Sub New()

  End Sub
  Sub New(ByVal wCodigo As Integer)
    Me.Codigo = wCodigo
  End Sub
  Sub New(ByVal wCodigo As Integer, ByVal wNombre As String, ByVal wAreaDre As AreaDRE, ByVal wVigencia As Boolean)
    Me.Codigo = wCodigo
    Me.Nombre = wNombre
    Me.AreaDre = wAreaDre
    Me.Vigencia = wVigencia
  End Sub
#End Region

End Class
