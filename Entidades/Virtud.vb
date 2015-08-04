Public Class Virtud
#Region "Datos"
  Private mCodigo As Integer
  Private mNombre As String
  Private mId As Integer
  Private mVigencia As Boolean
  Private mOAnio As AnioLectivo
  Private mOPeriodo As PeriodoAcademico
  Private mONivel As Nivel
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
  Public Property Nombre() As String
    Get
      Return mNombre
    End Get
    Set(ByVal value As String)
      mNombre = value
    End Set
  End Property
  Public Property Id() As Integer
    Get
      Return mId
    End Get
    Set(ByVal value As Integer)
      mId = value
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
  Public Property OAnio() As AnioLectivo
    Get
      Return mOAnio
    End Get
    Set(ByVal value As AnioLectivo)
      mOAnio = value
    End Set
  End Property
  Public Property OPeriodo() As PeriodoAcademico
    Get
      Return mOPeriodo
    End Get
    Set(ByVal value As PeriodoAcademico)
      mOPeriodo = value
    End Set
  End Property
  Public Property ONivel() As Nivel
    Get
      Return mONivel
    End Get
    Set(ByVal value As Nivel)
      mONivel = value
    End Set
  End Property
#End Region

#Region "Constructores"
  Sub New()

  End Sub
  Sub New(ByVal wCodigo As Integer)
    Me.Codigo = wCodigo
  End Sub
  Sub New(ByVal wCodigo As Integer, ByVal wnombre As String)
    Me.Codigo = wCodigo
    Me.Nombre = wnombre
  End Sub
  Sub New(ByVal wCodigo As Integer, ByVal wNombre As String, ByVal wVigencia As Boolean, _
          ByVal wAnio As AnioLectivo, ByVal wPer As PeriodoAcademico, _
          ByVal wNivel As Nivel, ByVal wId As Integer)
    Me.Codigo = wCodigo
    Me.Nombre = wNombre
    Me.Vigencia = wVigencia
    Me.OAnio = wAnio
    Me.OPeriodo = wPer
    Me.mONivel = wNivel
    Me.Id = wId
  End Sub
#End Region

End Class
