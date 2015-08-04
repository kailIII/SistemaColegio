Public Class TipoServicio
#Region "Datos"
  Private mCodigo As Integer
  Private mNombre As String
  Private mVigencia As Boolean
#End Region
#Region "Propiedades"
  Public Property codigo() As Integer
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
  Public Property vigencia() As Boolean
    Get
      Return mVigencia
    End Get
    Set(ByVal value As Boolean)
      mVigencia = value
    End Set
  End Property
#End Region
#Region "Constructores"
  Public Sub New()

  End Sub
  Public Sub New(ByVal wcodigo As Integer, ByVal wnombre As String, ByVal wvigencia As Boolean)
    Me.codigo = wcodigo
    Me.Nombre = wnombre
    Me.vigencia = wvigencia
  End Sub
#End Region
  End Class
