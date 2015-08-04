Public Class DirectorNivel

#Region "Datos"
  Private moNivel As Nivel
  Private moPersonal As Personal
  Private mNumero As Integer
  Private mFechaIni As DateTime
  Private mFechaFin As DateTime
  Private mVigencia As Boolean
#End Region
#Region "Propiedades"
  Public Property Nivel() As Nivel
    Get
      Return moNivel
    End Get
    Set(ByVal value As Nivel)
      moNivel = value
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
  Public Property Numero() As Integer
    Get
      Return mNumero
    End Get
    Set(ByVal value As Integer)
      mNumero = value
    End Set
  End Property
  Public Property FechaIni() As DateTime
    Get
      Return mFechaIni
    End Get
    Set(ByVal value As DateTime)
      mFechaIni = value
    End Set
  End Property
  Public Property FechaFin() As DateTime
    Get
      Return mFechaFin
    End Get
    Set(ByVal value As DateTime)
      mFechaFin = value
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
#End Region



End Class
