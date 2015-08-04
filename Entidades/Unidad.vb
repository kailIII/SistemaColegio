Public Class Unidad

#Region "Datos"
  Private mNumero As Integer
  Private mNombre As String
  Private mVigencia As Boolean
  Private mOPeriodo As PeriodoAcademico
  Private mODocenteCarga As DocenteCarga
#End Region

#Region "Propiedades"

  Public Property Numero() As Integer
    Get
      Return mNumero
    End Get
    Set(ByVal value As Integer)
      mNumero = value
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

  Public Property Vigencia() As Boolean
    Get
      Return mVigencia
    End Get
    Set(ByVal value As Boolean)
      mVigencia = value
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

  Public Property DocenteCarga() As DocenteCarga
    Get
      Return mODocenteCarga
    End Get
    Set(ByVal value As DocenteCarga)
      mODocenteCarga = value
    End Set
  End Property
#End Region

#Region "Constructores"
  Sub New()

  End Sub
  Sub New(ByVal wNumero As Integer, ByVal wNombre As String, ByVal wVigencia As Boolean, ByVal wPeriodo As PeriodoAcademico, ByVal wDocCarga As DocenteCarga)
    Me.Numero = wNumero
    Me.Nombre = wNombre
    Me.Vigencia = wVigencia
    Me.Periodo = wPeriodo
    Me.DocenteCarga = wDocCarga
  End Sub
#End Region

End Class
