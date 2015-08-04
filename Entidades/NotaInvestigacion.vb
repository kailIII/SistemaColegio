Public Class NotaInvestigacion

#Region "Datos"
  Private mCodigo As Integer
  Private mAreaInv As AreaInvestigacion
  Private mVigencia As Boolean  
  Private mNombreNivel As String
  Private moRespInvestigacion As ResponsableInvestigacion
  Private malumno As Alumno
  Private mnota As String
  Private moMatricula As Matricula
  Private mPersonal As Personal

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

  Public Property Nota() As String
    Get
      Return mnota
    End Get
    Set(ByVal value As String)
      mnota = value
    End Set
  End Property

  Public Property Alumno() As Alumno
    Get
      Return malumno
    End Get
    Set(ByVal value As Alumno)
      malumno = value
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

  Public Property Vigencia() As Boolean
    Get
      Return mVigencia
    End Get
    Set(ByVal value As Boolean)
      mVigencia = value
    End Set
  End Property

  Public Property AreaInvestigacion() As AreaInvestigacion
    Get
      Return mAreaInv
    End Get
    Set(ByVal value As AreaInvestigacion)
      mAreaInv = value
    End Set
  End Property

  Public Property RespInvestigacion() As ResponsableInvestigacion
    Get
      Return moRespInvestigacion
    End Get
    Set(ByVal value As ResponsableInvestigacion)
      moRespInvestigacion = value
    End Set
  End Property

  Public ReadOnly Property DocenteNivel() As String
    Get
      Return moRespInvestigacion.nombreCompleto
    End Get
  End Property

  Public ReadOnly Property AlumnoNivel() As String
    Get
      Return Me.malumno.NombreCompleto
    End Get
  End Property

  Public ReadOnly Property AreaNivel() As String
    Get
      Return Me.AreaInvestigacion.Nombre
    End Get
  End Property

  Public Property NombreNivel() As String
    Get
      Return mNombreNivel
    End Get
    Set(ByVal value As String)
      mNombreNivel = value
    End Set
  End Property

  Public Property Personal() As Personal
    Get
      Return mPersonal
    End Get
    Set(ByVal value As Personal)
      mPersonal = value
    End Set
  End Property
#End Region

#Region "Constructores"

  Sub New()
  End Sub

  Sub New(ByVal mcodigo As Integer, ByVal mnota As String,
          ByVal malumno As Alumno, ByVal mrespInv As ResponsableInvestigacion, ByVal marea As AreaInvestigacion, ByVal moMatricula As Matricula,
          ByVal Nivel As String)
    Me.Codigo = mcodigo
    Me.Nota = mnota
    Me.Alumno = malumno
    Me.moRespInvestigacion = mrespInv
    Me.mAreaInv = marea
    Me.moMatricula = moMatricula
    Me.NombreNivel = Nivel
  End Sub

#End Region

End Class
