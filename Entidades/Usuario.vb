Public Class Usuario

  '#Region "Datos"
  '  Private mCodigo As Integer
  '  Private mOPersona As Persona
  '  Private mNombre As String
  '  Private mContrasena As String
  '  Private mTipo As Char
  '  Private mVigencia As Boolean
  '#End Region
  '#Region "Propiedades"
  '  Public Property Persona() As Persona
  '    Get
  '      Return mOPersona
  '    End Get
  '    Set(ByVal value As Persona)
  '      mOPersona = value
  '    End Set
  '  End Property
  '  Public Property Vigencia() As Boolean
  '    Get
  '      Return mVigencia
  '    End Get
  '    Set(ByVal value As Boolean)
  '      mVigencia = value
  '    End Set
  '  End Property
  '  Public Property Tipo() As Char
  '    Get
  '      Return mTipo
  '    End Get
  '    Set(ByVal value As Char)
  '      mTipo = value
  '    End Set
  '  End Property
  '  Public Property Nombre() As String
  '    Get
  '      Return mNombre
  '    End Get
  '    Set(ByVal value As String)
  '      mNombre = value
  '    End Set
  '  End Property
  '  Public Property Contrasena() As String
  '    Get
  '      Return mContrasena
  '    End Get
  '    Set(ByVal value As String)
  '      mContrasena = value
  '    End Set
  '  End Property
  '  Public Property Codigo() As Integer
  '    Get
  '      Return mCodigo
  '    End Get
  '    Set(ByVal value As Integer)
  '      mCodigo = value
  '    End Set
  '  End Property

  '#End Region
  '#Region "Constructores"
  '  Public Sub New()

  '  End Sub
  '  Public Sub New(ByVal wNombre As String, ByVal wContrasenia As String)
  '    Me.Nombre = wNombre
  '    Me.Contrasena = wContrasenia
  '  End Sub
  '  Public Sub New(ByVal wCodigo As Integer, ByVal wPersona As Persona, ByVal wNombre As String, ByVal wContrasenia As String, ByVal wTipo As Char, ByVal wVigencia As Boolean)
  '    Me.Codigo = wCodigo
  '    Me.Persona = wPersona
  '    Me.Nombre = wNombre
  '    Me.Contrasena = wContrasenia
  '    Me.Tipo = wTipo
  '  End Sub

  '#End Region

#Region "Datos"
  Protected mCodigo As Integer
  Private mOPersona As Persona
  Private mNombre As String
  Private mContrasenia As String
  Private mTipo As Char
  Private mVigencia As Boolean
  Private mGrupo As GrupoUsuario
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
  Public Property Persona() As Persona
    Get
      Return mOPersona
    End Get
    Set(ByVal value As Persona)
      mOPersona = value

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
  Public Property Contrasenia() As String
    Get
      Return mContrasenia
    End Get
    Set(ByVal value As String)
      mContrasenia = value
    End Set
  End Property

  Public Property Tipo() As Char
    Get
      Return mTipo
    End Get
    Set(ByVal value As Char)
      mTipo = value
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

  Public ReadOnly Property NombreCompleto() As String
    Get
      If mVigencia = False Then
        Return mNombre & " - " & " - No vigente"
      Else
        Return mNombre & " - " & " - Vigente"

      End If
    End Get
  End Property

  Public ReadOnly Property NombreVigencia() As String
    Get
      If mVigencia = False Then
        Return "No vigente"
      Else
        Return "Vigente"

      End If
    End Get
  End Property

  Public ReadOnly Property NombreTipo() As String
    Get
      If mTipo = "A" Then
        Return "Administrador"
      Else
        Return "Limitado"
      End If
    End Get
  End Property

  Public ReadOnly Property NombrePersona() As String
    Get
      Return mOPersona.NombreCompleto
    End Get
  End Property

#End Region

#Region "Contructores"
  Public Sub New()
  End Sub
  Public Sub New(ByVal wCodigo As Integer, ByVal wPersona As Persona, ByVal wNombre As String, ByVal wContrasenia As String, ByVal wTipo As Char, ByVal wVigenca As Boolean)
    Me.mCodigo = wCodigo
    Me.mOPersona = wPersona
    Me.mNombre = wNombre
    Me.mContrasenia = wContrasenia
    Me.mTipo = wTipo
    Me.mVigencia = wVigenca
  End Sub
  Public Sub New(ByVal wCodigo As Integer, ByVal wPersona As Persona, ByVal wNombre As String, ByVal wTipo As Char, ByVal wVigenca As Boolean)
    Me.mCodigo = wCodigo
    Me.mOPersona = wPersona
    Me.mNombre = wNombre
    Me.mTipo = wTipo
    Me.mVigencia = wVigenca
  End Sub
  Public Sub New(ByVal wPersona As Persona, ByVal wNombre As String, ByVal wContrasenia As String, ByVal wTipo As Char, ByVal wVigenca As Boolean)
    Me.mOPersona = wPersona
    Me.mNombre = wNombre
    Me.mContrasenia = wContrasenia
    Me.mTipo = wTipo
    Me.mVigencia = wVigenca
  End Sub
  Public Sub New(ByVal wPersona As Persona, ByVal wCodigo As Integer)
    Me.mCodigo = wCodigo
    Me.mOPersona = wPersona
  End Sub
  Public Sub New(ByVal wCodigo As Integer)
    Me.mCodigo = wCodigo
  End Sub
  Public Sub New(ByVal wCodigo As Integer, ByVal wNombre As String)
    Me.mCodigo = wCodigo
    Me.mNombre = wNombre
  End Sub
  Public Sub New(ByVal wNombre As String, ByVal wContrasenia As String)
    Me.Nombre = wNombre
    Me.Contrasenia = wContrasenia
  End Sub
#End Region


End Class
