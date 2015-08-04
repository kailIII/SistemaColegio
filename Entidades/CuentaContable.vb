Public Class CuentaContable

#Region "Datos"
  Private mCodigo As String
  Private mCodigoPadre As String
  Private mNombre As String
  Private mDescripcion As String
  Private mVigencia As Boolean
  Private mNivel As Integer
  Private mTipo As String
#End Region

#Region "Propiedades"

  Public Property Codigo() As String
    Get
      Return mCodigo
    End Get
    Set(ByVal value As String)
      mCodigo = value
    End Set
  End Property

  Public Property CodigoPadre() As String
    Get
      Return mCodigoPadre
    End Get
    Set(ByVal value As String)
      mCodigoPadre = value
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

  Public Property NumeroNombreNivel() As String
    Get
      Return New String(" "c, (Me.Nivel - 1) * 2) & Me.Codigo.Trim & "  " & mNombre
    End Get
    Set(ByVal value As String)
      mNombre = value
    End Set
  End Property

  Public Property Descripcion() As String
    Get
      Return mDescripcion
    End Get
    Set(ByVal value As String)
      mDescripcion = value
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

  Public Property Nivel() As Integer
    Get
      Return mNivel
    End Get
    Set(ByVal value As Integer)
      mNivel = value
    End Set
  End Property

  Public Property Tipo() As String
    Get
      Return mTipo
    End Get
    Set(ByVal value As String)
      mTipo = value
    End Set
  End Property

#End Region

#Region "Constructores"

  Public Sub New()
  End Sub

  Public Sub New(ByVal wCodigo As String)
    Me.Codigo = wCodigo
  End Sub

  Public Sub New(ByVal wCodigo As String, ByVal wCodigoPadre As String, ByVal wNombre As String, ByVal wDescripcion As String, ByVal wVigencia As Boolean, ByVal wNivel As Integer, ByVal wTipo As String)
    Me.Codigo = wCodigo
    Me.CodigoPadre = wCodigoPadre
    Me.Nombre = wNombre
    Me.Descripcion = wDescripcion
    Me.Vigencia = wVigencia
    Me.Nivel = wNivel
    Me.Tipo = wTipo
  End Sub

#End Region
End Class
