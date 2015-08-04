Public Class PromedioPeriodoCurso

#Region "Datos"
  Private mCodigo As Integer
  Private mOPeriodo As PeriodoAcademico
  Private mOCargaAcademica As CargaAcademica
  Private mODocenteCarga As DocenteCarga
  Private mOMatricula As Matricula
  Private mPromedio As Double
  Private mOPersonal As Personal
  Private mLetra As String
  Private mNivelEsfuerzo As String
  'Private mOTraslado As Traslado
#End Region

#Region "Propiedades"

  Public Property Matricula() As Matricula
    Get
      Return Me.mOMatricula
    End Get
    Set(ByVal value As Matricula)
      Me.mOMatricula = value
    End Set
  End Property

  Public Property Periodo() As PeriodoAcademico
    Get
      Return Me.mOPeriodo
    End Get
    Set(ByVal value As PeriodoAcademico)
      Me.mOPeriodo = value
    End Set
  End Property

  Public Property Codigo() As Integer
    Get
      Return mCodigo
    End Get
    Set(ByVal value As Integer)
      mCodigo = value
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
  Public Property CodigoPeriodo() As Integer
    Get
      Return mOPeriodo.Codigo
    End Get
    Set(ByVal value As Integer)
      mOPeriodo.Codigo = value
    End Set
  End Property

  Public Property CodDocenteCarga() As Integer
    Get
      Return mODocenteCarga.Codigo
    End Get
    Set(ByVal value As Integer)
      mODocenteCarga.Codigo = value
    End Set
  End Property
  Public Property NroMatricula() As Integer
    Get
      Return mOMatricula.Numero
    End Get
    Set(ByVal value As Integer)
      mOMatricula.Numero = value
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
  Public Property NroOrden() As Integer
    Get
      Return mOMatricula.NroOrden
    End Get
    Set(ByVal value As Integer)
      mOMatricula.NroOrden = value
    End Set
  End Property
  Public Property CodigoPersonal() As Integer
    Get
      Return mOPersonal.Codigo
    End Get
    Set(ByVal value As Integer)
      mOPersonal.Codigo = value
    End Set
  End Property
  Public Property NivelEsfuerzo() As String
    Get
      Return mNivelEsfuerzo
    End Get
    Set(ByVal value As String)
      mNivelEsfuerzo = value
    End Set
  End Property
  Public ReadOnly Property NombreNivelEsfuerzo() As String
    Get
      Dim nombre As String = ""
      Select Case NivelEsfuerzo
        Case "A"
          nombre = "ALTO"
        Case "M"
          nombre = "MEDIO"
        Case "B"
          nombre = "BAJO"
      End Select
      Return nombre
    End Get
  End Property

  Public Property CargaAcademica() As CargaAcademica
    Get
      Return mOCargaAcademica
    End Get
    Set(ByVal value As CargaAcademica)
      mOCargaAcademica = value
    End Set
  End Property

#End Region

#Region "Constructores"
  Public Sub New()
  End Sub
  Public Sub New(ByVal wCodigo As Integer)
    Me.Codigo = wCodigo
  End Sub
  Public Sub New(ByVal wCodigoProm As Integer, ByVal wNroMatricula As Integer, ByVal wcodigoPeriodo As Integer, _
                 ByVal wletra As String, ByVal wNivelEsf As String)
    Me.Codigo = wCodigoProm
    Me.mOMatricula = New Matricula(wNroMatricula)
    Me.mOPeriodo = New PeriodoAcademico(wcodigoPeriodo)
    Me.Letra = wletra
    Me.NivelEsfuerzo = wNivelEsf
  End Sub
  Public Sub New(ByVal wCodigoProm As Integer, ByVal wCodDocenteCarga As Integer, _
                ByVal wNroMatricula As Integer, ByVal wcodperiodo As Integer, ByVal wcodpersonal As Integer, _
                ByVal wletra As String, ByVal wNivelEsf As String)
    Me.Codigo = wCodigoProm
    Me.mODocenteCarga = New DocenteCarga(wCodDocenteCarga)
    Me.mOMatricula = New Matricula(wNroMatricula)
    Me.mOPeriodo = New PeriodoAcademico(wcodperiodo)
    Me.mOPersonal = New Personal(wcodpersonal)
    Me.Letra = wletra
    Me.NivelEsfuerzo = wNivelEsf
  End Sub
  Public Sub New(ByVal wCodigoProm As Integer, ByVal wCodDocenteCarga As Integer, _
               ByVal wNroMatricula As Integer, ByVal wcodperiodo As Integer, ByVal wcodpersonal As Integer, _
               ByVal wletra As String, ByVal wNivelEsf As String, ByVal wnroOrden As Integer)
    Me.Codigo = wCodigoProm
    Me.mODocenteCarga = New DocenteCarga(wCodDocenteCarga)
    Me.mOMatricula = New Matricula(wNroMatricula, Nothing, wnroOrden)
    Me.mOPeriodo = New PeriodoAcademico(wcodperiodo)
    Me.mOPersonal = New Personal(wcodpersonal)
    Me.Letra = wletra
    Me.NivelEsfuerzo = wNivelEsf
  End Sub
#End Region
End Class
