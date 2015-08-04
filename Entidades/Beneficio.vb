Public Class Beneficio

#Region "Datos"
  Private mCodigo As Integer
  Private mOAutorizador As Administrativo
  Private mOAdministrativo As Administrativo
  Private mOObligacion As Obligacion
  Private mFecha As Date
  Private mMotivo As String
  Private mDescuento As Double
  Private mVigencia As Boolean
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

  Public Property Autorizador() As Administrativo
    Get
      Return mOAutorizador
    End Get
    Set(ByVal value As Administrativo)
      mOAutorizador = value
    End Set
  End Property

  Public Property Administrativo() As Administrativo
    Get
      Return mOAdministrativo
    End Get
    Set(ByVal value As Administrativo)
      mOAdministrativo = value
    End Set
  End Property

  Public Property Obligacion() As Obligacion
    Get
      Return Me.mOObligacion
    End Get
    Set(ByVal value As Obligacion)
      Me.mOObligacion = value
    End Set
  End Property

  Public Property Descuento() As Double
    Get
      Return Me.mDescuento
    End Get
    Set(ByVal value As Double)
      Me.mDescuento = value
    End Set
  End Property

  Public Property Motivo() As String
    Get
      Return Me.mMotivo
    End Get
    Set(ByVal value As String)
      Me.mMotivo = value
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

  Public Property Vigencia() As Boolean
    Get
      Return mVigencia
    End Get
    Set(ByVal value As Boolean)
      mVigencia = value
    End Set
  End Property

#Region "Obligacion"

  Public ReadOnly Property DescripcionPension() As String
    Get
      Return Me.Obligacion.Descripcion
    End Get
  End Property

  Public ReadOnly Property FechaVencimiento() As Date
    Get
      Return Me.Obligacion.FechaVencimiento
    End Get
  End Property

#End Region

#End Region

#Region "Constructores"

  Public Sub New()
  End Sub

  Public Sub New(ByVal wCodigo As Integer)
    Codigo = wCodigo
  End Sub

  Public Sub New(ByVal wCodigo As Integer, ByVal wCodigoAutoriza As Integer, ByVal wCodigoAdmin As Integer, ByVal wFecha As Date, ByVal wVigencia As Boolean)
    Codigo = wCodigo
    Administrativo = New Administrativo(wCodigoAdmin)
    Autorizador = New Administrativo(wCodigoAutoriza)
    Vigencia = wVigencia
    Fecha = wFecha
  End Sub

#End Region

End Class
