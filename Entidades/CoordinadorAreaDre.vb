Public Class CoordinadorAreaDre
#Region "Datos"
  Private mcodigo As Integer
  Private mvigencia As Boolean
  Private mOAreaDre As AreaDRE
  Private mOCoordiandor As Docente
#End Region

#Region "Propiedades"
  Public Property Codigo() As Integer
    Get
      Return mcodigo
    End Get
    Set(ByVal value As Integer)
      mcodigo = value
    End Set
  End Property
  Public Property Vigencia() As Boolean
    Get
      Return mvigencia
    End Get
    Set(ByVal value As Boolean)
      mvigencia = value
    End Set
  End Property
  Public ReadOnly Property NombreVigencia() As String
    Get
      Dim nombre As String = ""
      Select Case Vigencia
        Case True
          nombre = "SI"
        Case False
          nombre = "NO"
      End Select
      Return nombre
    End Get
  End Property

  Public Property AreaDre() As AreaDRE
    Get
      Return mOAreaDre
    End Get
    Set(ByVal value As AreaDRE)
      mOAreaDre = value
    End Set
  End Property
  Public Property Personal() As Docente
    Get
      Return mOCoordiandor
    End Get
    Set(ByVal value As Docente)
      mOCoordiandor = value
    End Set
  End Property
  Public ReadOnly Property NombreCompleto() As String
    Get
      Return mOCoordiandor.NombreCompleto
    End Get
  End Property
  Public ReadOnly Property NombreArea() As String
    Get
      Return mOAreaDre.Nombre
    End Get

  End Property
  Public ReadOnly Property NombreNivel() As String
    Get
      Return mOAreaDre.NombreNivel
    End Get
  End Property
#End Region

#Region "Constructores"
  Public Sub New()
  End Sub
  Public Sub New(ByVal wcodigo As Integer)
    Me.Codigo = wcodigo
  End Sub

  Public Sub New(ByVal wcodigo As Integer, ByVal wvigencia As Boolean, ByVal wareaDre As Integer, ByVal wdocente As Docente)
    Me.Codigo = wcodigo
    Me.Vigencia = wvigencia
    Me.AreaDre = New AreaDRE(wareaDre)
    Me.Personal = wdocente
  End Sub


  Public Sub New(ByVal wcodigo As Integer, ByVal wvigencia As Boolean, ByVal wareaDre As AreaDRE, ByVal wdocente As Docente)
    Me.Codigo = wcodigo
    Me.Vigencia = wvigencia
    Me.AreaDre = wareaDre
    Me.Personal = wdocente
  End Sub

#End Region
End Class
