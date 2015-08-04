Public Class GradoLibro

#Region "Datos"
  Private mcodigo As Integer
  Private mOLibro As Libro
  Private mOGrado As Grado
  Private moAnio As AnioLectivo
  Private mVigencia As Boolean
  Private mODocente As Docente
  Private mResponsable As String
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

  Public Property Libro() As Libro
    Get
      Return mOLibro
    End Get
    Set(ByVal value As Libro)
      mOLibro = value
    End Set
  End Property

  Public Property CodigoGrado() As Integer
    Get
      Return mOGrado.Codigo
    End Get
    Set(ByVal value As Integer)
      mOGrado.Codigo = value
    End Set
  End Property

  Public Property Anio() As String
    Get
      Return moAnio.Anio
    End Get
    Set(ByVal value As String)
      moAnio.Anio = value
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

  Public ReadOnly Property NombreVigencia() As String
    Get
      If Vigencia = True Then
        Return "SI"
      Else
        Return "NO"
      End If
    End Get
  End Property

  Public ReadOnly Property NombreLibro() As String
    Get
      Return mOLibro.Titulo
    End Get
  End Property

  Public ReadOnly Property CodigoLibro() As Integer
    Get
      Return mOLibro.Codigo
    End Get
  End Property

  Public Property Docente() As Docente
    Get
      Return mODocente
    End Get
    Set(ByVal value As Docente)
      mODocente = value
    End Set
  End Property

  Public ReadOnly Property NombreDocente() As String
    Get
      Dim nomb As String = ""

      If Me.Responsable = "D" AndAlso Me.Docente IsNot Nothing Then
        nomb = Me.Docente.NombreCompleto
      ElseIf Me.Responsable = "T" Then
        nomb = "TUTOR DE AULA"
      End If

      Return nomb
    End Get
  End Property

  Public Property Responsable() As String
    Get
      Return mResponsable
    End Get
    Set(ByVal value As String)
      mResponsable = value
    End Set
  End Property

#End Region

#Region "Constructores"
  Sub New()

  End Sub
  Sub New(ByVal wCodigo As Integer)
    Me.Codigo = wCodigo
  End Sub
  Sub New(ByVal wCodigo As Integer, ByVal wcodigoG As Integer, ByVal wcodLibro As Libro, ByVal wAnio As String, ByVal wvigencia As Boolean)
    Me.Codigo = wCodigo
    mOGrado = New Grado(wcodigoG)
    mOLibro = wcodLibro
    moAnio = New AnioLectivo(wAnio)
    Me.Vigencia = wvigencia
  End Sub

#End Region

End Class
