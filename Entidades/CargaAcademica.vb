
Public Class CargaAcademica

#Region "Datos"
  Private mCodigo As Integer
  Private mOCurso As Curso
  Private mOSeccion As Seccion
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

  Public Property Curso() As Curso
    Get
      Return Me.mOCurso
    End Get
    Set(ByVal value As Curso)
      Me.mOCurso = value
    End Set
  End Property

  Public Property Seccion() As Seccion
    Get
      Return mOSeccion
    End Get
    Set(ByVal value As Seccion)
      mOSeccion = value
    End Set
  End Property

  Public ReadOnly Property CodigoGrado() As Integer
    Get
      Return mOSeccion.Grado.Codigo
    End Get
  End Property

  Public ReadOnly Property Letra() As String
    Get
      Return mOSeccion.Letra
    End Get
  End Property

  Public ReadOnly Property GradoSeccion() As String
    Get
      Return CStr(mOSeccion.Grado.Numero) & "º " & mOSeccion.Letra
    End Get
  End Property

  Public ReadOnly Property CursoNombre() As String
    Get
      Return mOCurso.Nombre
    End Get
  End Property

  Public ReadOnly Property CursoHoras() As Integer
    Get
      Return mOCurso.NumeroHoras
    End Get
  End Property

  Public ReadOnly Property CursoGrupo() As Boolean
    Get
      Return mOCurso.Grupo
    End Get
  End Property

  Public ReadOnly Property CursoRotativo() As Boolean
    Get
      Return mOCurso.Rotativo
    End Get
  End Property

  Public ReadOnly Property NivelNombre() As String
    Get
      Return mOSeccion.Grado.Nivel.Nombre
    End Get
  End Property

  Public ReadOnly Property Asignado() As Boolean
    Get
      Dim asig As Boolean = False

      If Me.Codigo > 0 Then
        asig = True
      End If

      Return asig
    End Get
  End Property

#End Region

#Region "Constructores"

  Public Sub New()
  End Sub
  Public Sub New(ByVal wCodigoCargaAcad As Integer)
    mCodigo = wCodigoCargaAcad
  End Sub
  Public Sub New(ByVal wCodigoGrado As Integer, ByVal wCodigoCurso As Integer, ByVal wLetra As String)
    Me.Seccion = New Seccion(wCodigoGrado, 0, 0, "", CChar(wLetra))
    Me.Curso = New Curso(wCodigoCurso)
  End Sub
  Public Sub New(ByVal wCodigoCurso As Integer, ByVal wCodigoGrado As Integer, ByVal wLetra As Char)
    Me.Curso = New Curso(wCodigoCurso)
    Me.Seccion = New Seccion(wCodigoGrado, 0, "", wLetra)
  End Sub
  Public Sub New(ByVal wcodigo As Integer, ByVal wanio As String, ByVal wcodigoG As Integer, ByVal wletra As Char)
    Me.Codigo = wcodigo
    Me.mOSeccion = New Seccion(wcodigoG, wanio, wletra)
  End Sub
  'Public Sub New(ByVal wCodigoCarga As Integer, ByVal wCurso As Curso, ByVal wDocente As Docente, ByVal wSeccion As Seccion)
  '  Me.Codigo = wCodigoCarga
  '  'Me.Docente = wDocente
  '  Me.Curso = wCurso
  '  Me.Seccion = wSeccion
  'End Sub
  Public Sub New(ByVal wCodigoCurso As Integer, ByVal wNombreCurso As String)
    Me.Curso = New Curso(wCodigoCurso, wNombreCurso)
  End Sub

  Public Sub New(ByVal wCodigo As Integer, ByVal wCurso As Curso, ByVal wSeccion As Seccion)
    Me.Codigo = wCodigo
    Me.Curso = wCurso
    Me.Seccion = wSeccion
  End Sub

#End Region


End Class
