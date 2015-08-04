Public Class Indicador
#Region "Datos"

  Private mCodigo As Integer
  Private mOPeriodo As PeriodoAcademico
  Private mnombre As String
  Private mVigencia As Boolean
  Private mODocenteCarga As DocenteCarga
  Private mNro As Integer
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
  Public Property Nro() As Integer
    Get
      Return mNro
    End Get
    Set(ByVal value As Integer)
      mNro = value
    End Set
  End Property
  Public Property Nombre() As String
    Get
      Return mnombre
    End Get
    Set(ByVal value As String)
      mnombre = value
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
  Public Property Periodo() As Integer
    Get
      Return mOPeriodo.Codigo
    End Get
    Set(ByVal value As Integer)
      mOPeriodo.Codigo = value
    End Set
  End Property
  Public Property DocenteCarga() As Integer
    Get
      Return mODocenteCarga.Codigo
    End Get
    Set(ByVal value As Integer)
      mODocenteCarga.Codigo = value
    End Set
  End Property
  
#End Region

#Region "Constructores"

  Public Sub New()
  End Sub
  Public Sub New(ByVal wCodigo As Integer)
    Me.Codigo = wCodigo
  End Sub
  Public Sub New(ByVal wCodigo As Integer, ByVal wnombre As String)
    Me.Codigo = wCodigo
    Me.Nombre = wnombre
  End Sub

  Public Sub New(ByVal wCodigo As Integer, ByVal wnombre As String, ByVal wnro As Integer, ByVal wperiodo As Integer)
    Me.Codigo = wCodigo
    Me.Nombre = wnombre
    Me.Nro = wnro
    Me.mOPeriodo = New PeriodoAcademico(wperiodo)
  End Sub

  Sub New(ByVal wCodigo As Integer, ByVal wnombre As String, ByVal wvigencia As Boolean, _
          ByVal wCodigoPeriodo As Integer, ByVal wCodigoDocCarga As Integer, ByVal wnro As Integer)
    Me.Codigo = wCodigo
    Me.Nombre = wnombre
    Me.Vigencia = wvigencia
    Me.mOPeriodo = New PeriodoAcademico(wCodigoPeriodo)
    Me.mODocenteCarga = New DocenteCarga(wCodigoDocCarga)
    Me.Nro = wnro
  End Sub

#End Region

End Class
