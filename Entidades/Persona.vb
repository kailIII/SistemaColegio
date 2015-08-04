Public Class Persona

#Region "Datos"
  Protected mCodigo As Integer
  Private mNombre As String
  Private mApePat As String
  Private mApeMat As String
  Private mSexo As String
  Private mFechaNacimiento As Date
#End Region

#Region "Propiedades"
  Public Overridable Property Codigo() As Integer
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

  Public Property ApellidoPaterno() As String
    Get
      Return mApePat
    End Get
    Set(ByVal value As String)
      mApePat = value
    End Set
  End Property

  Public Property ApellidoMaterno() As String
    Get
      Return mApeMat
    End Get
    Set(ByVal value As String)
      mApeMat = value
    End Set
  End Property

  Public Property FechaNacimiento() As Date
    Get
      Return mFechaNacimiento
    End Get
    Set(ByVal value As Date)
      mFechaNacimiento = value
    End Set
  End Property

  Public ReadOnly Property NombreCompleto() As String
    Get
      Return ApellidoPaterno & " " & ApellidoMaterno & " " & Nombre
    End Get
  End Property

  Public Property Sexo() As String
    Get
      Return mSexo
    End Get
    Set(ByVal value As String)
      mSexo = value
    End Set
  End Property

#End Region

#Region "Constructores"
  Public Sub New()
  End Sub
  Public Sub New(ByVal wCodigo As Integer)
    Me.mCodigo = wCodigo
  End Sub
  Public Sub New(ByVal wCodigo As Integer, ByVal wNombres As String, ByVal wApellidoPat As String, ByVal wApellidoMat As String)
    Me.Codigo = wCodigo
    Me.ApellidoPaterno = wApellidoPat
    Me.ApellidoMaterno = wApellidoMat
    Me.Nombre = wNombres
  End Sub
  Public Sub New(ByVal wApelidoPat As String, ByVal wApelidoMat As String, ByVal wNombres As String)
    Me.ApellidoPaterno = wApelidoPat
    Me.ApellidoMaterno = wApelidoMat
    Me.Nombre = wNombres
  End Sub
  Public Sub New(ByVal wNombres As String, ByVal wApellidoPat As String, ByVal wApellidoMat As String, ByVal wSexo As String, ByVal wFechaNac As Date)
    Me.Nombre = wNombres
    Me.ApellidoPaterno = wApellidoPat
    Me.ApellidoMaterno = wApellidoMat
    Me.Sexo = wSexo
    Me.FechaNacimiento = wFechaNac
  End Sub
  Public Sub New(ByVal wCodigo As Integer, ByVal wNombres As String, ByVal wApellidoPat As String, ByVal wApellidoMat As String, ByVal wSexo As String, ByVal wFechaNac As Date)
    Me.Codigo = wCodigo
    Me.Nombre = wNombres
    Me.ApellidoPaterno = wApellidoPat
    Me.ApellidoMaterno = wApellidoMat
    Me.Sexo = wSexo
    Me.FechaNacimiento = wFechaNac
  End Sub

#End Region

End Class
