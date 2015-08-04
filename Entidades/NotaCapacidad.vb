Public Class NotaCapacidad

#Region "Datos"
  Private mCodigo As Integer
  Private moCodNotaAnt As NotaCapacidad
  Private mPromedio As Double
  Private mFecha As DateTime
  Private mVigencia As Boolean
  Private moMatricula As Matricula
  Private moPeriodo As PeriodoAcademico
  Private moPersonal As Personal
  Private moCapacidad As Capacidad
  Private moUnidad As Unidad
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
  Public Property CodigoNotaAnt() As NotaCapacidad
    Get
      Return moCodNotaAnt
    End Get
    Set(ByVal value As NotaCapacidad)
      moCodNotaAnt = value
    End Set
  End Property
  Public Property Promedio() As Double
    Get
      Return mPromedio
    End Get
    Set(ByVal value As Double)
      mPromedio = value
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
  Public Property Periodo() As PeriodoAcademico
    Get
      Return moPeriodo
    End Get
    Set(ByVal value As PeriodoAcademico)
      moPeriodo = value
    End Set
  End Property
  Public Property Personal() As Personal
    Get
      Return moPersonal
    End Get
    Set(ByVal value As Personal)
      moPersonal = value
    End Set
  End Property
  Public Property Capacidad() As Capacidad
    Get
      Return moCapacidad
    End Get
    Set(ByVal value As Capacidad)
      moCapacidad = value
    End Set
  End Property
  Public Property Unidad() As Unidad
    Get
      Return moUnidad
    End Get
    Set(ByVal value As Unidad)
      moUnidad = value
    End Set
  End Property
#End Region

#Region "Constructores"
  Sub New()

  End Sub
  Sub New(ByVal wCodigo As Integer)
    Me.Codigo = wCodigo
  End Sub
  Sub New(ByVal wCodigoAnt As NotaCapacidad)
    Me.CodigoNotaAnt = wCodigoAnt
  End Sub
  Sub New(ByVal wCodigo As Integer, ByVal wPromedio As Double, _
          ByVal wFecha As DateTime, ByVal wVigencia As Boolean, ByVal wMatricula As Matricula, ByVal wPeriodo As PeriodoAcademico, _
          ByVal wPersonal As Personal, ByVal wCapacidad As Capacidad, ByVal wUnidad As Unidad)
    Me.Codigo = wCodigo
    Me.Promedio = wPromedio
    Me.Fecha = wFecha
    Me.Vigencia = wVigencia
    Me.Matricula = wMatricula
    Me.Periodo = wPeriodo
    Me.Personal = wPersonal
    Me.Capacidad = wCapacidad
    Me.Unidad = wUnidad
  End Sub
  Sub New(ByVal wCodigo As Integer, ByVal wPromedio As Double)
    Me.Codigo = wCodigo
    Me.Promedio = wPromedio
  End Sub
  Sub New(ByVal wUnidad As Unidad, ByVal wCapacidad As Capacidad, ByVal wMatricula As Matricula)
    Me.Unidad = wUnidad
    Me.Capacidad = wCapacidad
    Me.Matricula = wMatricula
  End Sub
#End Region

End Class
