Public Class Liquidacion

#Region "Datos"
  Private mCodigo As Integer
  Private mNumero As Integer
  Private mEntidad As String
  Private mFecha As DateTime
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

  Public Property Numero() As Integer
    Get
      Return mNumero
    End Get
    Set(ByVal value As Integer)
      mNumero = value
    End Set
  End Property

  Public Property Entidad() As String
    Get
      Return mEntidad
    End Get
    Set(ByVal value As String)
      mEntidad = value
    End Set
  End Property

  Public Property Fecha() As DateTime
    Get
      Return mFecha
    End Get
    Set(ByVal value As DateTime)
      mFecha = value
    End Set
  End Property

#End Region

#Region "Metodos"
  Sub New()

  End Sub

  Sub New(ByVal wNumero As Integer, ByVal wentidad As String, ByVal wFecha As DateTime)
    Me.Numero = wNumero
    Me.Entidad = wentidad
    Me.Fecha = wFecha
  End Sub

  Sub New(ByVal wNumero As Integer)
    Me.Numero = wNumero
  End Sub
#End Region

End Class
