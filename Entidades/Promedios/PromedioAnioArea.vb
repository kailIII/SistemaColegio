Public Class PromedioAnioArea

#Region "Datos"
  Private mCodigo As Integer
  Private mOPersonal As Personal
  Private mOAnio As AnioLectivo
  Private mOMatricula As Matricula
  Private mOArea As AreaDRE
  Private mLetra As String
  Private mPromedio As Decimal
  Private mVigencia As Boolean

  Private mOPromediosPeriodo As List(Of PromedioPeriodoArea)
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
  Public Property Anio() As AnioLectivo
    Get
      Return mOAnio
    End Get
    Set(ByVal value As AnioLectivo)
      mOAnio = value
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
  Public Property Area() As AreaDRE
    Get
      Return mOArea
    End Get
    Set(ByVal value As AreaDRE)
      mOArea = value
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
  Public Property Vigencia() As Boolean
    Get
      Return mVigencia
    End Get
    Set(ByVal value As Boolean)
      mVigencia = value
    End Set
  End Property
  Public Property PromediosPeriodo() As List(Of PromedioPeriodoArea)
    Get
      Return mOPromediosPeriodo
    End Get
    Set(ByVal value As List(Of PromedioPeriodoArea))
      mOPromediosPeriodo = value
    End Set
  End Property
#End Region

#Region "Constructores"

  Public Sub New()
  End Sub
  Public Sub New(ByVal wCodigo As Integer, ByVal wPersonal As Personal, ByVal wAnio As AnioLectivo, _
         ByVal wMatricula As Matricula, ByVal wArea As AreaDRE, ByVal wLetra As String, ByVal wVigencia As Boolean)

    Me.Codigo = wCodigo
    Me.Personal = wPersonal
    Me.Anio = wAnio
    Me.Matricula = wMatricula
    Me.Area = wArea
    Me.Letra = wLetra
    Me.Vigencia = wVigencia
  End Sub


#End Region

End Class
