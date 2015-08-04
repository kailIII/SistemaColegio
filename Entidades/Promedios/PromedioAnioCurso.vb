Public Class PromedioAnioCurso

#Region "Datos"
  Private mCodigo As Integer
  Private mOPersonal As Personal
  Private mOMatricula As Matricula
  Private mOCargaAcademica As CargaAcademica
  Private mPromedio As Decimal
  Private mLetra As String
  Private mFecha As DateTime
  Private mVigencia As Boolean

  Private mOPromediosPeriodo As List(Of PromedioPeriodoCurso)
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
  Public Property Personal() As Personal
    Get
      Return mOPersonal
    End Get
    Set(ByVal value As Personal)
      mOPersonal = value
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
  Public Property CargaAcademica() As CargaAcademica
    Get
      Return mOCargaAcademica
    End Get
    Set(ByVal value As CargaAcademica)
      mOCargaAcademica = value
    End Set
  End Property
  Public Property Letra() As String
    Get
      Return mLetra
    End Get
    Set(ByVal value As String)
      mLetra = value
    End Set
  End Property
  Public Property Promedio() As Decimal
    Get
      Return mPromedio
    End Get
    Set(ByVal value As Decimal)
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
  Public Property PromediosPeriodo() As List(Of PromedioPeriodoCurso)
    Get
      Return mOPromediosPeriodo
    End Get
    Set(ByVal value As List(Of PromedioPeriodoCurso))
      mOPromediosPeriodo = value
    End Set
  End Property
#End Region

#Region "Constructores"

  Public Sub New()
  End Sub

#End Region

End Class
