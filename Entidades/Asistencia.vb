Public Class Asistencia

#Region "Datos"
  Private mcodigo As Integer
  Private mestado As String
  Private mfecha As Date
  Private mOMatricula As Matricula
  Private mOPeriodo As PeriodoAcademico
  Private mOPersonal As Personal

  Private mdescripcion As String
  Private mOApoderado As Apoderado
  Private mFechaJust As Date
  Private mVigencia As Boolean

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

  Public Property Estado() As String
    Get
      Return mestado
    End Get
    Set(ByVal value As String)
      mestado = value
    End Set
  End Property

  Public Property Fecha() As Date
    Get
      Return mfecha
    End Get
    Set(ByVal value As Date)
      mfecha = value
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

  Public Property Periodo() As Integer
    Get
      Return mOPeriodo.Codigo
    End Get
    Set(ByVal value As Integer)
      mOPeriodo.Codigo = value
    End Set
  End Property

  Public Property Personal() As Integer
    Get
      Return mOPersonal.Codigo
    End Get
    Set(ByVal value As Integer)
      mOPersonal.Codigo = value
    End Set
  End Property

  Public Property Descripcion() As String
    Get
      Return mdescripcion
    End Get
    Set(ByVal value As String)
      mdescripcion = value
    End Set
  End Property

  Public Property FechaJustificacion() As Date
    Get
      Return mFechaJust
    End Get
    Set(ByVal value As Date)
      mFechaJust = value
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

  Public Property Apoderado As Apoderado
    Get
      Return Me.mOApoderado
    End Get
    Set(ByVal value As Apoderado)
      Me.mOApoderado = value
    End Set
  End Property

  Public Property CodigoApoderado() As Integer
    Get
      Return mOApoderado.Codigo
    End Get
    Set(ByVal value As Integer)
      mOApoderado.Codigo = value
    End Set
  End Property

  Public ReadOnly Property NombreEstado() As String
    Get
      Dim texto As String = ""
      Select Case Estado.Trim
        Case "F"
          texto = "Falta"
        Case "FJ"
          texto = "Falta"
        Case "T"
          texto = "Tardanza"
        Case "TJ"
          texto = "Tardanza"
        Case "A"
          texto = "Asistencia"
      End Select
      Return texto
    End Get
  End Property

  Public ReadOnly Property NombreAlumno() As String
    Get
      Return Me.mOMatricula.Alumno.NombreCompleto
    End Get
  End Property

  Public ReadOnly Property NroOrden() As Integer
    Get
      Return mOMatricula.NroOrden
    End Get
  End Property

  Public ReadOnly Property CodigoTutor() As Integer
    Get
      Return mOApoderado.Codigo
    End Get
  End Property

#End Region

#Region "Constructores"
  Sub New()
  End Sub

  Sub New(ByVal mcodigo As Integer)
    Me.Codigo = mcodigo
  End Sub
  Sub New(ByVal wcodigo As Integer, ByVal westado As String, ByVal wfecha As Date, ByVal wNroMatricula As Matricula, ByVal wCodPeriodo As Integer, _
           ByVal wcodPersonal As Integer)
    Me.Codigo = wcodigo
    Me.Estado = westado
    Me.Fecha = wfecha
    Me.Matricula = wNroMatricula
    mOPeriodo = New PeriodoAcademico(wCodPeriodo)
    mOPersonal = New Personal(wcodPersonal)
  End Sub
  Sub New(ByVal wcodigo As Integer, ByVal westado As String, ByVal wfecha As Date, ByVal wNroMatricula As Matricula)
    Me.Codigo = wcodigo
    Me.Estado = westado
    Me.Fecha = wfecha
    Me.Matricula = wNroMatricula
  End Sub
  Sub New(ByVal wcodigo As Integer, ByVal westado As String, ByVal wfechaJust As Date, ByVal wdescripcion As String, ByVal wVigencia As Boolean, _
           ByVal wApoderado As Integer, ByVal wcodPersonal As Integer)
    Me.Codigo = wcodigo
    Me.Estado = westado
    Me.FechaJustificacion = wfechaJust
    Me.Descripcion = wdescripcion
    Me.Vigencia = wVigencia
    mOApoderado = New Apoderado(wApoderado)
    mOPersonal = New Personal(wcodPersonal)
  End Sub

#End Region

End Class
