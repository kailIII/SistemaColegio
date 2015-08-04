Public Class Personal
  Inherits Persona

#Region "Datos"
  Private mCelular As String
  Private mTipoDoc As String
  Private mNroDoc As String
  Private mEmail As String
  Private mDireccion As String
#End Region

#Region "Propiedades"

  Public Overrides Property Codigo() As Integer
    Get
      Return MyBase.Codigo
    End Get
    Set(ByVal value As Integer)
      mCodigo = value
    End Set
  End Property

  Public Property Celular() As String
    Get
      Return mCelular
    End Get
    Set(ByVal value As String)
      mCelular = value
    End Set
  End Property

  Public Property TipoDocumento() As String
    Get
      Return mTipoDoc
    End Get
    Set(ByVal value As String)
      mTipoDoc = value
    End Set
  End Property

  Public Property NumeroDocumento() As String
    Get
      Return mNroDoc
    End Get
    Set(ByVal value As String)
      mNroDoc = value
    End Set
  End Property

  Public Property Email() As String
    Get
      Return mEmail
    End Get
    Set(ByVal value As String)
      mEmail = value
    End Set
  End Property

  Public Property Direccion() As String
    Get
      Return mDireccion
    End Get
    Set(ByVal value As String)
      mDireccion = value
    End Set
  End Property
#End Region

#Region "Constructores"

  Public Sub New()
  End Sub

  Public Sub New(ByVal wCod As Integer)
    MyBase.New(wCod)
  End Sub

  Public Sub New(ByVal wCod As Integer, ByVal wNombres As String, ByVal wApellidoPat As String, ByVal wApellidoMat As String)
    MyBase.New(wCod, wNombres, wApellidoPat, wApellidoMat)
  End Sub

  Public Sub New(ByVal wNombres As String, ByVal wApellidoPat As String, _
               ByVal wApellidoMat As String, ByVal wSexo As String, ByVal wFechaNac As Date, _
               ByVal wTipoDoc As String, ByVal wNroDoc As String, ByVal wEmail As String, ByVal wCelular As String, _
               ByVal wDireccion As String)
    MyBase.New(wNombres, wApellidoPat, wApellidoMat, wSexo, wFechaNac)
    Me.Email = wEmail
    Me.TipoDocumento = wTipoDoc
    Me.NumeroDocumento = wNroDoc
    Me.Celular = wCelular
    Me.Direccion = wDireccion
  End Sub

  Public Sub New(ByVal wCodigo As Integer, ByVal wNombres As String, ByVal wApellidoPat As String, _
               ByVal wApellidoMat As String, ByVal wSexo As String, ByVal wFechaNac As Date, _
               ByVal wEmail As String, ByVal wTipoDoc As String, ByVal wNroDoc As String, ByVal wCelular As String, _
               ByVal wDireccion As String)
    MyBase.New(wCodigo, wNombres, wApellidoPat, wApellidoMat, wSexo, wFechaNac)
    Me.Email = wEmail
    Me.TipoDocumento = wTipoDoc
    Me.NumeroDocumento = wNroDoc
    Me.Celular = wCelular
    Me.Direccion = wDireccion
  End Sub

  Public Sub New(ByVal _cod As Integer, ByVal wNombre As String, ByVal wApellidoPat As String, _
                   ByVal wApellidoMat As String, ByVal wSexo As String, ByVal wFechaNac As Date, _
                   ByVal wEmail As String, ByVal wCelular As String)
    MyBase.New(_cod, wNombre, wApellidoPat, wApellidoMat, wSexo, wFechaNac)
    Me.Email = wEmail
    Me.Celular = wCelular

  End Sub

#End Region

End Class
