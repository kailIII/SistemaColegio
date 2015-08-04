Public Class Curso

#Region "Datos"

  Private mCodigo As Integer
  Private mNombre As String
  Private mNroHoras As Integer
  Private mVigencia As Boolean
  Private mGrupo As Boolean
  Private mRotativo As Boolean
  Private mOGrado As Grado
  Private mOSeccion As Seccion
  Private mOAreaDre As AreaDRE
#End Region

#Region "Propiedades"

  Public Property Grado() As Grado
    Get
      Return mOGrado
    End Get
    Set(ByVal value As Grado)
      mOGrado = value
    End Set
  End Property

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

  Public Property Grupo() As Boolean
    Get
      Return mGrupo
    End Get
    Set(ByVal value As Boolean)
      mGrupo = value
    End Set
  End Property

  Public Property Rotativo() As Boolean
    Get
      Return mRotativo
    End Get
    Set(ByVal value As Boolean)
      mRotativo = value
    End Set
  End Property

  Public Property NumeroHoras() As Integer
    Get
      Return mNroHoras
    End Get
    Set(ByVal value As Integer)
      mNroHoras = value
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

  Public ReadOnly Property Grado_Seccion() As String
    Get
      Return CStr(mOGrado.Numero) & "º " & Me.Seccion.Letra
    End Get
  End Property

  Public ReadOnly Property VigenciaTexto() As String
    Get
      If Me.vigencia = True Then
        Return "VIGENTE"
      Else
        Return "ANULADO"
      End If
    End Get
  End Property

  Public Property Seccion() As Seccion
    Get
      Return Me.mOSeccion
    End Get
    Set(ByVal value As Seccion)
      Me.mOSeccion = value
    End Set
  End Property

  Public Property CodigoAreaDre() As AreaDRE
    Get
      Return mOAreaDre
    End Get
    Set(ByVal value As AreaDRE)
      mOAreaDre = value
    End Set
  End Property

  Public ReadOnly Property Grupos() As String
    Get
      Dim cadena As String = ""

      If Me.Grupo Then
        cadena = "NO"
      Else
        cadena = "SI"
      End If
      Return cadena
    End Get
  End Property

#End Region

#Region "Constructores"

  Public Sub New()
  End Sub

  Public Sub New(ByVal wCodigo As Integer)
    Me.Codigo = wCodigo
  End Sub

  Public Sub New(ByVal wCodigo As Integer, ByVal wNombre As String, ByVal wNroHoras As Integer, ByVal wCodigoGrado As Integer, _
                 ByVal wVigencia As Boolean, ByVal wGrupos As Boolean, ByVal wrotativo As Boolean, ByVal wcodigoAreaDre As Integer)
    Me.Codigo = wCodigo
    Me.Nombre = wNombre
    Me.NumeroHoras = wNroHoras
    Me.Grado = New Grado(wCodigoGrado)
    Me.vigencia = wVigencia
    Me.Grupo = wGrupos
    Me.Rotativo = wrotativo
    Me.CodigoAreaDre = New AreaDRE(wcodigoAreaDre)
  End Sub

  Public Sub New(ByVal wCodigo As Integer, ByVal wNombre As String, _
                 ByVal wCodigoGrado As Integer, ByVal wAreaD As AreaDRE)
    Me.Codigo = wCodigo
    Me.Nombre = wNombre
    Me.Grado = New Grado(wCodigoGrado)
    Me.CodigoAreaDre = wAreaD
  End Sub

  Public Sub New(ByVal wCodigoG As Integer, ByVal wNombreCur As String)
    Me.mOGrado = New Grado(wCodigoG)
    Me.mNombre = wNombreCur
  End Sub

  Public Sub New(ByVal wNombre As String)
    Me.Nombre = wNombre
  End Sub

  Public Sub New(ByVal wNumero As Integer, ByVal wLetra As Char, ByVal wNombre As String, ByVal wNroHoras As Integer)
    Me.Seccion = New Seccion(0, 0, 0, "", wLetra)
    Me.Grado = New Grado(0, wNumero, "", New Nivel(), "", "")
    Me.Nombre = wNombre
    Me.NumeroHoras = wNroHoras
  End Sub

  Public Sub New(ByVal wCodigoNivel As Integer, ByVal wCodigo As Integer, ByVal wNombre As String, ByVal wNroHoras As Integer, _
                 ByVal wCodigoGrado As Integer, ByVal wVigencia As Boolean, ByVal wGrupos As Boolean, ByVal wrotativo As Boolean, _
                 ByVal wcodigoAreaDre As Integer)
    Me.Codigo = wCodigo
    Me.Nombre = wNombre
    Me.NumeroHoras = wNroHoras
    Me.Grado = New Grado(wCodigoGrado, wCodigoNivel, "", 0)
    Me.vigencia = wVigencia
    Me.Grupo = wGrupos
    Me.Rotativo = wrotativo
    Me.CodigoAreaDre = New AreaDRE(wcodigoAreaDre)
  End Sub

#End Region

End Class
