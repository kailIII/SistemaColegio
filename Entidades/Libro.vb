Public Class Libro

#Region "Datos"
  Private mcodigo As Integer
  Private mtitulo As String
  Private mdescripcion As String
  Private mabreviatura As String
  Private moAutor As Autor
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

  Public Property Titulo() As String
    Get
      Return mtitulo
    End Get
    Set(ByVal value As String)
      mtitulo = value
    End Set
  End Property
  Public Property Descripcion() As String
    Get
      Return mdescripcion
    End Get
    Set(ByVal value As String)
      mdescripcion = value
    End Set
  End Property
  Public Property Abreviatura() As String
    Get
      Return mabreviatura
    End Get
    Set(ByVal value As String)
      mabreviatura = value
    End Set
  End Property
  Public Property CodigoAutor() As Integer
    Get
      Return moAutor.Codigo
    End Get
    Set(ByVal value As Integer)
      moAutor.Codigo = value
    End Set
  End Property

#End Region

#Region "Connstructores"
  Sub New()

  End Sub
  Sub New(ByVal wCodigo As Integer)
    Me.Codigo = wCodigo
  End Sub
  Sub New(ByVal wTitulo As String, ByVal wAbrev As String)
    Me.Titulo = wTitulo
    Me.Abreviatura = wAbrev
  End Sub
  Sub New(ByVal wCodigo As Integer, ByVal wTitulo As String, ByVal wDescripcion As String, ByVal wAbreviatura As String, ByVal wCodAutor As Integer)
    Me.Codigo = wCodigo
    Me.Titulo = wTitulo
    Me.Descripcion = wDescripcion
    Me.Abreviatura = wAbreviatura
    Me.moAutor = New Autor(wCodAutor, "", "")
  End Sub

#End Region

End Class
