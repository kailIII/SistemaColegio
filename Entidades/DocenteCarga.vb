Public Class DocenteCarga

#Region "Datos"
  Private mCodigo As Integer
  Private mNombre As String
  Private mODocente As Docente
  Private mOCarga As CargaAcademica
  Private mOPeriodo As PeriodoAcademico

  Private mAlumnos As List(Of Grupo)
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

  Public Property Nombre() As String
    Get
      Return mNombre
    End Get
    Set(ByVal value As String)
      mNombre = value
    End Set
  End Property

  Public Property Docente() As Docente
    Get
      Return mODocente
    End Get
    Set(ByVal value As Docente)
      mODocente = value
    End Set
  End Property

  Public Property Carga() As CargaAcademica
    Get
      Return mOCarga
    End Get
    Set(ByVal value As CargaAcademica)
      mOCarga = value
    End Set
  End Property

  Public Property Periodo() As PeriodoAcademico
    Get
      Return mOPeriodo
    End Get
    Set(ByVal value As PeriodoAcademico)
      mOPeriodo = value
    End Set
  End Property

  Public Property Alumnos() As List(Of Grupo)
    Get
      Return mAlumnos
    End Get
    Set(ByVal value As List(Of Grupo))
      mAlumnos = value
    End Set
  End Property

  Public ReadOnly Property CursoNivel() As String
    Get
      Return mOCarga.Seccion.NombreNivel & " - " & mOCarga.Seccion.Numero & " - " & mOCarga.CursoNombre
    End Get
  End Property

  Public ReadOnly Property CursoSeccion() As String
    Get
      Dim cad As String = ""
      If mOCarga IsNot Nothing Then
        cad = mOCarga.Seccion.NombreNivel.Trim & " - " & mOCarga.Seccion.Numero & " - " & mOCarga.Seccion.LetraCompleta & " - " & mOCarga.CursoNombre.Trim
      Else
        cad = "Todos los cursos"
      End If

      Return cad
    End Get
  End Property

  Public ReadOnly Property CursoGrupo() As String
    Get
      Return mOCarga.CursoNombre.Trim & "-" & Me.Nombre
    End Get
  End Property

  Public ReadOnly Property NombreCurso() As String
    Get
      Return mOCarga.CursoNombre.Trim
    End Get
  End Property

  Public ReadOnly Property CursoDocente() As String
    Get
      Return mOCarga.Curso.Nombre & " - " & mODocente.NombreCompleto
    End Get
  End Property

  Public Property CodigoDocente() As Integer
    Get
      If Me.Docente IsNot Nothing Then
        Return Me.Docente.Codigo
      Else
        Return 0
      End If
    End Get
    Set(ByVal value As Integer)
      'If Me.Docente Is Nothing Then
      Me.Docente = New Docente With {.Codigo = value}
      'Else
      'Me.Docente.Codigo = value
      'End If
    End Set
  End Property

  Public Property CodigoPeriodo() As Integer
    Get
      If Me.Periodo IsNot Nothing Then
        Return Me.Periodo.Codigo
      Else
        Return 0
      End If
    End Get
    Set(ByVal value As Integer)
      'If Me.Periodo Is Nothing Then
      Me.Periodo = New PeriodoAcademico With {.Codigo = value}
      'Else
      'Me.Periodo.Codigo = value
      'End If
    End Set
  End Property

#End Region

#Region "Constructores"

  Sub New()

  End Sub
  Sub New(ByVal wCodigo As Integer)
    Me.Codigo = wCodigo
  End Sub
  Sub New(ByVal wCodigo As Integer, ByVal wNombre As String, ByVal wDocente As Docente, ByVal wCarga As CargaAcademica, ByVal wPeriodo As PeriodoAcademico)
    Me.Codigo = wCodigo
    Me.Nombre = wNombre
    Me.Docente = wDocente
    Me.Carga = wCarga
    Me.Periodo = wPeriodo
  End Sub

  Sub New(ByVal wCodigo As Integer, ByVal wCarga As CargaAcademica, ByVal wPeriodo As PeriodoAcademico)
    Me.Codigo = wCodigo
    Me.Carga = wCarga
    Me.Periodo = wPeriodo
  End Sub
  Sub New(ByVal wCodigo As Integer, ByVal wCarga As CargaAcademica, ByVal wPeriodo As PeriodoAcademico, ByVal wnombre As String)
    Me.Codigo = wCodigo
    Me.Carga = wCarga
    Me.Periodo = wPeriodo
    Me.Nombre = wnombre
  End Sub

#End Region

End Class
