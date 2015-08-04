Public Class Obligacion

#Region "Datos"
  Private mCodigo As Integer
  Private mDescripcion As String
  Private mMonto As Double
  Private mVigencia As Boolean
  Private mFechaVencimiento As DateTime
  Private mOServicio As Servicio
  Private mOMatricula As Matricula
  Private mOObligacionPadre As Obligacion

  Private mTipo_Pension As String
  Private mCodigoProgramacion As Integer
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

  Public Property Descripcion() As String
    Get
      Return mDescripcion
    End Get
    Set(ByVal value As String)
      mDescripcion = value
    End Set
  End Property

  Public Property Monto() As Double
    Get
      Return mMonto
    End Get
    Set(ByVal value As Double)
      mMonto = value
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

  Public Property FechaVencimiento() As DateTime
    Get
      Return mFechaVencimiento
    End Get
    Set(ByVal value As DateTime)
      mFechaVencimiento = value
    End Set
  End Property

  Public Property Servicio() As Servicio
    Get
      Return mOServicio
    End Get
    Set(ByVal value As Servicio)
      mOServicio = value
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

  Public Property ObligacionPadre() As Obligacion
    Get
      Return mOObligacionPadre
    End Get
    Set(ByVal value As Obligacion)
      mOObligacionPadre = value
    End Set
  End Property

  Public Property Tipo_Pension() As String
    Get
      Return mTipo_Pension
    End Get
    Set(ByVal value As String)
      mTipo_Pension = value
    End Set
  End Property

  Public Property CodigoProgramacion() As Integer
    Get
      Return mCodigoProgramacion
    End Get
    Set(ByVal value As Integer)
      mCodigoProgramacion = value
    End Set
  End Property

#End Region

#Region "Constructores"

  Public Sub New()

  End Sub

  Public Sub New(ByVal wCodigoObligacion As Integer, ByVal wDescripcion As String, ByVal wMonto As Double, ByVal wVigencia As Boolean, ByVal wfechaVcto As DateTime, ByVal wServicio As Servicio, ByVal wMatricula As Matricula, ByVal wObligacionPadre As Obligacion)
    Codigo = wCodigoObligacion
    Descripcion = wDescripcion
    Monto = wMonto
    Vigencia = wVigencia
    FechaVencimiento = wfechaVcto
    Servicio = wServicio
    Matricula = wMatricula
    ObligacionPadre = wObligacionPadre
  End Sub

  Public Sub New(ByVal wObligacionPadre As Obligacion)
    ObligacionPadre = wObligacionPadre
  End Sub

  Public Sub New(ByVal wCodigoObligacion As Integer)
    Codigo = wCodigoObligacion
  End Sub

  Public Sub New(ByVal wCodigoObligacion As Integer, ByVal wobligacionPadre As Obligacion)
    Codigo = wCodigoObligacion
    ObligacionPadre = wobligacionPadre
  End Sub

  Public Sub New(ByVal wMatricula As Matricula)
    Matricula = wMatricula
  End Sub

  Public Sub New(ByVal wCodigoObligacion As Integer, ByVal wDescripcion As String, ByVal wMonto As Double, _
          ByVal wVigencia As Boolean, ByVal wfechaVcto As DateTime, ByVal wServicio As Servicio, _
          ByVal wMatricula As Matricula, ByVal wObligacionPadre As Obligacion, ByVal wTipoPension As String, ByVal wcodigoProgramacion As Integer)
    Codigo = wCodigoObligacion
    Descripcion = wDescripcion
    Monto = wMonto
    Vigencia = wVigencia
    FechaVencimiento = wfechaVcto
    Servicio = wServicio
    Matricula = wMatricula
    ObligacionPadre = wObligacionPadre
    Tipo_Pension = wTipoPension
    CodigoProgramacion = wcodigoProgramacion
  End Sub

#End Region

End Class
