Public Class ProgramacionLectura

#Region "Datos"
  Private mcodigo As Integer
  Private mtipo As String
  Private mVigencia As Boolean
  Private mNroGrupo As Integer
  Private mOMatricula As Matricula
  Private mOSeccion As Seccion
  Private mOLibro As Libro
  Private mOPresentacion As Presentacion
#End Region

#Region "Propiedades"

  Public Property Presentacion() As Presentacion
    Get
      Return Me.mOPresentacion
    End Get
    Set(ByVal value As Presentacion)
      Me.mOPresentacion = value
    End Set
  End Property
  Public Property Codigo() As Integer
    Get
      Return mcodigo
    End Get
    Set(ByVal value As Integer)
      mcodigo = value
    End Set
  End Property
  Public Property Tipo() As String
    Get
      Return mtipo
    End Get
    Set(ByVal value As String)
      mtipo = value
    End Set
  End Property
  Public Property NroGrupo() As Integer
    Get
      Return mNroGrupo
    End Get
    Set(ByVal value As Integer)
      mNroGrupo = value
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
  Public Property CodigoPresentacion() As Integer
    Get
      Return mOPresentacion.Codigo
    End Get
    Set(ByVal value As Integer)
      mOPresentacion.Codigo = value
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
  Public Property Matricula() As Matricula
    Get
      Return mOMatricula
    End Get
    Set(ByVal value As Matricula)
      mOMatricula = value
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
      Return Me.mOMatricula.Alumno.NombreCompleto
    End Get
  End Property
  Public ReadOnly Property NroOrden() As Integer
    Get
      Return mOMatricula.NroOrden
    End Get
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
  Public ReadOnly Property Sexo() As String
    Get
      'Dim s As String
      'If mOAlumno.Sexo = "M" Then
      '    s = "M"
      'Else
      '    s = "F"
      'End If
      Return mOMatricula.LeerSexo2
    End Get
  End Property
#End Region

#Region "Constructores"
  Sub New()
  End Sub

  Sub New(ByVal wcodigo As Integer)
    Me.Codigo = wcodigo
  End Sub
  Sub New(ByVal wcodigo As Integer, ByVal wLibro As Libro)
    Me.Codigo = wcodigo
    Me.Libro = wLibro
  End Sub
  Sub New(ByVal wcodigo As Integer, ByVal wLibro As Libro, ByVal wPresentacion As Presentacion)
    Me.Codigo = wcodigo
    Me.Libro = wLibro
    Me.mOPresentacion = wPresentacion
  End Sub

  Sub New(ByVal wcodigo As Integer, ByVal wtipo As String, ByVal wvigencia As Boolean, ByVal wnroGrupo As Integer, ByVal wcodPresentacion As Integer, _
          ByVal wLibro As Libro, ByVal wNroMatricula As Matricula, ByVal wseccion As Seccion)
    Me.Codigo = wcodigo
    Me.Tipo = wtipo
    Me.Vigencia = wvigencia
    Me.NroGrupo = wnroGrupo
    Me.Matricula = wNroMatricula
    Me.Seccion = wseccion
    mOPresentacion = New Presentacion(wcodPresentacion)
    Me.Libro = wLibro
  End Sub

  Sub New(ByVal wLibro As Libro, ByVal wTipo As String)
    Me.Libro = wLibro
    Me.Tipo = wTipo

  End Sub

#End Region

End Class
