Public Class NotaLectura

#Region "Datos"
  Private mCodigo As Integer
  Private mNota As String
  Private mFecha As DateTime
  Private mVigencia As Boolean
  Private mComentario As String
  Private moMatricula As Matricula
  Private moPersonal As Personal
    Private mOProgLectura As ProgramacionLectura
    Private mNotaRecuperacion As String
    Private mLibroRecuperacion As String

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

  Public Property Nota() As String
    Get
      Return mNota
    End Get
    Set(ByVal value As String)
      mNota = value
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

  Public Property Comentario() As String
    Get
      Return mComentario
    End Get
    Set(ByVal value As String)
      mComentario = value
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

  Public Property Matricula() As Matricula
    Get
      Return moMatricula
    End Get
    Set(ByVal value As Matricula)
      moMatricula = value
    End Set
  End Property

  Public Property Personal() As Integer
    Get
      Return moPersonal.Codigo
    End Get
    Set(ByVal value As Integer)
      moPersonal.Codigo = value
    End Set
  End Property

  Public Property ProgLectura() As ProgramacionLectura
    Get
      Return mOProgLectura
    End Get
    Set(ByVal value As ProgramacionLectura)
      mOProgLectura = value
    End Set
  End Property

  Public ReadOnly Property NombreCompleto() As String
    Get
      Return Me.moMatricula.Alumno.NombreCompleto
    End Get
  End Property

  Public ReadOnly Property NroOrden() As Integer
    Get
      Return moMatricula.NroOrden
    End Get
  End Property

  Public ReadOnly Property Libro() As String
    Get
      Return mOProgLectura.Libro.Titulo
    End Get
  End Property

  Public ReadOnly Property Seccion() As String
    Get
      Return Me.Matricula.Seccion.NivelNumeroLetra
    End Get
  End Property

#End Region
    'Tania
    Public Property NotaRecuperacion() As String
        Get
            Return mNotaRecuperacion
        End Get
        Set(ByVal value As String)
            mNotaRecuperacion = value
        End Set
    End Property

    Public Property LibroRecuperacion() As String
        Get
            Return mLibroRecuperacion
        End Get
        Set(ByVal value As String)
            mLibroRecuperacion = value
        End Set
    End Property
#Region "Constructores"
  Sub New()
    Me.moPersonal = New Personal
  End Sub

  Sub New(ByVal wCodigo As Integer, ByVal wnota As String)
    Me.Codigo = wCodigo
    Me.Nota = wnota.Trim
  End Sub

  Sub New(ByVal wMatricula As Matricula, ByVal wnota As String, ByVal wcomentario As String, ByVal wProgLect As ProgramacionLectura)
    Me.Matricula = wMatricula
    Me.Nota = wnota.Trim
    Me.Comentario = wcomentario
    Me.ProgLectura = wProgLect
  End Sub

  Sub New(ByVal wCodigo As Integer, ByVal wNota As String, ByVal wComentario As String, ByVal wFecha As DateTime, _
          ByVal wVigencia As Boolean, ByVal wProgLect As ProgramacionLectura, ByVal wMatricula As Matricula, ByVal wPersonal As Integer)
    Me.Codigo = wCodigo
    Me.Nota = wNota.Trim
    Me.Fecha = wFecha
    Me.Vigencia = wVigencia
    Me.Matricula = wMatricula
    Me.ProgLectura = wProgLect
    moPersonal = New Personal(wPersonal)
    Me.Comentario = wComentario
  End Sub

  'Tania Incio
  Sub New(ByVal wnota As String, ByVal wNotaRecuperacion As String, ByVal wProgLect As ProgramacionLectura)
    Me.Nota = wnota.Trim
    Me.NotaRecuperacion = wNotaRecuperacion.Trim
    Me.ProgLectura = wProgLect
  End Sub
#End Region

End Class
