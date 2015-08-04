Public Class Equivalencia

#Region "Datos"
  Private mCodigo As Integer
  Private mLiteral As String
  Private mPuntos As Integer
  Private mEspecificacion As String
  Private mVigencia As Boolean
  Private mOInstitucion As Institucion
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
  Public Property Literal() As String
    Get
      Return mLiteral
    End Get
    Set(ByVal value As String)
      mLiteral = value
    End Set
  End Property
  Public Property Puntos() As Integer
    Get
      Return mPuntos
    End Get
    Set(ByVal value As Integer)
      mPuntos = value
    End Set
  End Property
  Public Property Especificacion() As String
    Get
      Return mEspecificacion
    End Get
    Set(ByVal value As String)
      mEspecificacion = value
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
  Public Property OInstitucion() As Institucion
    Get
      Return mOInstitucion
    End Get
    Set(ByVal value As Institucion)
      mOInstitucion = value
    End Set
  End Property
  Public ReadOnly Property LeerEquivalencia() As String
    Get
      Return Me.Puntos & " - " & Me.Literal
    End Get
  End Property
#End Region

#Region "Constructores"
  Sub New()

  End Sub
  Sub New(ByVal wCodigo As Integer)
    Me.Codigo = wCodigo
  End Sub
  Sub New(ByVal wCodigo As Integer, ByVal wLiteral As String, ByVal wPuntos As Integer _
           , ByVal wEspecific As String, ByVal wVigencia As Boolean, ByVal wInst As Institucion)
    Me.Codigo = wCodigo
    Me.Literal = wLiteral
    Me.Puntos = wPuntos
    Me.Especificacion = wEspecific
    Me.Vigencia = wVigencia
    Me.OInstitucion = wInst
  End Sub
#End Region

End Class
