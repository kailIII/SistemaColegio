Public Class MatriculaIndicador

#Region "Datos"

  Private mONroMatricula As Matricula
  Private mNumero As Integer
  Private mOIndicador As Indicador
  Private mLetra As String
  Private mFecha As Date
  Private mOPersonal As Personal
  Private mVigencia As Boolean
  Private mONroMatricAnt As Matricula
  Private mNumeroAnt As Integer

#End Region

#Region "Propiedades"
  Public Property Matricula() As Matricula
    Get
      Return mONroMatricula
    End Get
    Set(ByVal value As Matricula)
      mONroMatricula = value
    End Set
  End Property
  Public Property Numero() As Integer
    Get
      Return mNumero
    End Get
    Set(ByVal value As Integer)
      mNumero = value
    End Set
  End Property
  Public Property NumeroAnt() As Integer
    Get
      Return mNumeroAnt
    End Get
    Set(ByVal value As Integer)
      mNumeroAnt = value
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
  Public Property CodIndicador() As Integer
    Get
      Return mOIndicador.Codigo
    End Get
    Set(ByVal value As Integer)
      mOIndicador.Codigo = value
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

  Public Property Fecha() As Date
    Get
      Return mFecha
    End Get
    Set(ByVal value As Date)
      mFecha = value
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
  Public Property NroMatricAnt() As Integer
    Get
      Return mONroMatricAnt.Numero
    End Get
    Set(ByVal value As Integer)
      mONroMatricAnt.Numero = value
    End Set
  End Property
#End Region

#Region "Constructores"

  Public Sub New()
  End Sub
  'Public Sub New(ByVal wNroMatricula As Integer, ByVal wnumero As Integer)
  '  Me.Matricula = New Matricula(wNroMatricula)
  '  Me.Numero = wnumero
  'End Sub
  Public Sub New(ByVal wNroMatricula As Integer, ByVal wcodigoindicador As Integer)
    Me.Matricula = New Matricula(wNroMatricula)
    Me.mOIndicador = New Indicador(wcodigoindicador)
  End Sub
  Public Sub New(ByVal wCodigo As Integer, ByVal wnro As Integer, ByVal wletra As String)
    Me.Matricula = New Matricula(wCodigo)
    Me.Numero = wnro
    Me.Letra = wletra
  End Sub

  Public Sub New(ByVal wNroMatricula As Matricula, ByVal wnumero As Integer, ByVal wLetra As String, ByVal wfecha As Date, _
                  ByVal wvigencia As Boolean, ByVal wcodigoIndicador As Integer, ByVal wCodigoPersonal As Integer, _
                  ByVal wNroMatAnt As Integer, ByVal wnumeroAnt As Integer)

    Me.Matricula = wNroMatricula
    Me.Numero = wnumero
    Me.Letra = wLetra
    Me.Fecha = wfecha
    Me.Vigencia = wvigencia
    Me.mOIndicador = New Indicador(wcodigoIndicador)
    Me.mOPersonal = New Personal(wCodigoPersonal)
    Me.mONroMatricAnt = New Matricula(wNroMatAnt)
    Me.NumeroAnt = wnumeroAnt
  End Sub

#End Region

End Class
