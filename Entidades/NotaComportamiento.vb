
Public Class NotaComportamiento

#Region "Datos"
  Private mCodigo As Integer
  Private mPuntos As Integer
  Private mLetra As String
  Private mFecha As DateTime
  Private mVigencia As Boolean
  Private mOMatricula As Matricula
  Private mOPeriodo As PeriodoAcademico
  Private mOVirtud As Virtud
  Private mOPersonal As Personal
  Private mONotaAnt As NotaComportamiento
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
  Public Property Puntos() As Integer
    Get
      Return mPuntos
    End Get
    Set(ByVal value As Integer)
      mPuntos = value
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
      Return mOMatricula
    End Get
    Set(ByVal value As Matricula)
      mOMatricula = value
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
  Public Property Virtud() As Virtud
    Get
      Return mOVirtud
    End Get
    Set(ByVal value As Virtud)
      mOVirtud = value
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
  Public Property CodigoAnt() As NotaComportamiento
    Get
      Return mONotaAnt
    End Get
    Set(ByVal value As NotaComportamiento)
      mONotaAnt = value
    End Set
  End Property
#End Region

#Region "Constructores"
  Sub New()

  End Sub
  Sub New(ByVal wCodigo As Integer)
    Me.Codigo = wCodigo
  End Sub
  Sub New(ByVal wCodigoAnt As NotaComportamiento, ByVal wVigencia As Boolean)
    Me.CodigoAnt = wCodigoAnt
    Me.Vigencia = wVigencia
  End Sub
  Sub New(ByVal wCodigo As Integer, ByVal wPuntos As Integer, ByVal wLetra As String, _
            ByVal wfecha As DateTime, ByVal wVigencia As Boolean, ByVal wMatricula As Matricula, _
            ByVal wPeriodo As PeriodoAcademico, ByVal wVirtud As Virtud, _
            ByVal wPersonal As Personal)
    Me.Codigo = wCodigo
    Me.Puntos = wPuntos
    Me.Letra = wLetra
    Me.Fecha = wfecha
    Me.Vigencia = wVigencia
    Me.Matricula = wMatricula
    Me.Periodo = wPeriodo
    Me.Virtud = wVirtud
    Me.Personal = wPersonal
  End Sub
  Sub New(ByVal wCodigo As Integer, ByVal null As DBNull, ByVal wLetra As String, _
              ByVal wfecha As DateTime, ByVal wVigencia As Boolean, ByVal wMatricula As Matricula, _
              ByVal wPeriodo As PeriodoAcademico, ByVal wVirtud As Virtud, _
              ByVal wPersonal As Personal)
    Me.Codigo = wCodigo
    'Me.Puntos = wPuntos
    Me.Letra = wLetra
    Me.Fecha = wfecha
    Me.Vigencia = wVigencia
    Me.Matricula = wMatricula
    Me.Periodo = wPeriodo
    Me.Virtud = wVirtud
    Me.Personal = wPersonal
  End Sub
  Sub New(ByVal wCodigo As Integer, ByVal wPuntos As Integer, ByVal wNull As DBNull, _
            ByVal wfecha As DateTime, ByVal wVigencia As Boolean, ByVal wMatricula As Matricula, _
            ByVal wPeriodo As PeriodoAcademico, ByVal wVirtud As Virtud, _
            ByVal wPersonal As Personal)
    Me.Codigo = wCodigo
    Me.Puntos = wPuntos
    'Me.Letra = wLetra
    Me.Fecha = wfecha
    Me.Vigencia = wVigencia
    Me.Matricula = wMatricula
    Me.Periodo = wPeriodo
    Me.Virtud = wVirtud
    Me.Personal = wPersonal
  End Sub
  Sub New(ByVal wPeriodo As PeriodoAcademico, ByVal wMatricula As Matricula, ByVal wVirtud As Virtud)
    Me.Periodo = wPeriodo
    Me.Matricula = wMatricula
    Me.Virtud = wVirtud
  End Sub

  Sub New(ByVal wPeriodo As PeriodoAcademico, ByVal wMatricula As Matricula, ByVal wVirtud As Virtud, _
          ByVal wpuntos As Integer, ByVal wletra As String)
    Me.Periodo = wPeriodo
    Me.Matricula = wMatricula
    Me.Virtud = wVirtud
    Me.Puntos = wpuntos
    Me.Letra = wletra
  End Sub

#End Region

End Class
