Public Class PeriodoAcademico

#Region "Datos"

  Private mCodigo As Integer
  Private mFechaIni As Date
  Private mFechaFin As Date
  Private mVigencia As Boolean
  Private mAnio As String
  Private mNombre As String
  Private mSiglas As String
  Private mCerrado As Boolean

  Private moAnioLectivo As AnioLectivo

#End Region

#Region "Propiedades"

  Public Property AnioLectivo() As AnioLectivo
    Get
      Return moAnioLectivo
    End Get
    Set(ByVal value As AnioLectivo)
      moAnioLectivo = value
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

  Public Property fechaIni() As Date
    Get
      Return mFechaIni
    End Get
    Set(ByVal value As Date)
      mFechaIni = value
    End Set
  End Property

  Public Property fechaFin() As Date
    Get
      Return mFechaFin
    End Get
    Set(ByVal value As Date)
      mFechaFin = value
    End Set
  End Property

  Public Property vigencia() As Boolean
    Get
      Return mVigencia
    End Get
    Set(ByVal value As Boolean)
      mVigencia = value
    End Set
  End Property

  Public Property Anio() As String
    Get
      Return mAnio
    End Get
    Set(ByVal value As String)
      mAnio = value
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

  Public Property Siglas() As String
    Get
      Return mSiglas
    End Get
    Set(ByVal value As String)
      mSiglas = value
    End Set
  End Property

  Public Property Cerrado() As Boolean
    Get
      Return mCerrado
    End Get
    Set(ByVal value As Boolean)
      mCerrado = value
    End Set
  End Property

#End Region

#Region "Constructores"
  Public Sub New()
  End Sub
  Public Sub New(ByVal wCod As Integer)
    Me.mCodigo = wCod
  End Sub
  Public Sub New(ByVal wCodigoPeriodo As Integer, ByVal wFechaIni As Date, ByVal wFechaFin As Date, ByVal wVigencia As Boolean, ByVal wAnio As String, ByVal wNombre As String, ByVal wSiglas As String)
    Me.Codigo = wCodigoPeriodo
    Me.mFechaIni = wFechaIni
    Me.mFechaFin = wFechaFin
    Me.mVigencia = wVigencia
    Me.mAnio = wAnio
    Me.mNombre = wNombre
    Me.mSiglas = wSiglas
  End Sub
  Public Sub New(ByVal wCodigoPeriodo As Integer, ByVal wFechaIni As Date, _
                 ByVal wFechaFin As Date, ByVal wVigencia As Boolean, _
                 ByVal wAnio As String, ByVal wNombre As String, _
                 ByVal wSiglas As String, ByVal wCerrado As Boolean)
    Me.Codigo = wCodigoPeriodo
    Me.mFechaIni = wFechaIni
    Me.mFechaFin = wFechaFin
    Me.mVigencia = wVigencia
    Me.mAnio = wAnio
    Me.mNombre = wNombre
    Me.mSiglas = wSiglas
    Me.Cerrado = wCerrado
  End Sub
  Public Sub New(ByVal wFechaIni As Date, ByVal wFechaFin As Date, ByVal wVigencia As Boolean, ByVal wAnio As String, ByVal wNombre As String, ByVal wSiglas As String)
    Me.mFechaIni = wFechaIni
    Me.mFechaFin = wFechaFin
    Me.mVigencia = wVigencia
    Me.mAnio = wAnio
    Me.mNombre = wNombre
    Me.mSiglas = wSiglas
  End Sub
  Public Sub New(ByVal wCodigo As Integer, ByVal wCerrado As Boolean)
    Me.Codigo = wCodigo
    Me.Cerrado = wCerrado
  End Sub

#End Region

End Class
