Public Class Deposito
#Region "Datos"
    Private mcodigoDeposito As Integer
    Private mMonto As Double
    Private mfecha As DateTime
    Private mVigencia As Boolean
    Private mLiquidacion As Liquidacion
  Private mCuentaBancaria As CuentaBancaria
  Private mAdministrativo As Administrativo
#End Region
#Region "Propiedades"
  Public Property codigoDeposito() As Integer
    Get
      Return mcodigoDeposito
    End Get
    Set(ByVal value As Integer)
      mcodigoDeposito = value
    End Set
  End Property
  Public Property fecha() As DateTime
    Get
      Return mfecha
    End Get
    Set(ByVal value As DateTime)
      mfecha = value
    End Set
  End Property
  Public Property monto() As Double
    Get
      Return mMonto
    End Get
    Set(ByVal value As Double)
      mMonto = value
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
  Public Property CuentaBancaria() As CuentaBancaria
    Get
      Return mCuentaBancaria
    End Get
    Set(ByVal value As CuentaBancaria)
      mCuentaBancaria = value
    End Set
  End Property
  Public Property Administrativo() As Administrativo
    Get
      Return mAdministrativo
    End Get
    Set(ByVal value As Administrativo)
      mAdministrativo = value
    End Set
  End Property
  Public Property Liquidacion() As Liquidacion
    Get
      Return mLiquidacion
    End Get
    Set(ByVal value As Liquidacion)
      mLiquidacion = value
    End Set
  End Property
#End Region

#Region "Metodos"
  Sub New()

  End Sub
  Sub New(ByVal wcodigoDeposito As Integer, ByVal wmonto As Double, ByVal wfecha As DateTime, ByVal wvigencia As Boolean, _
      ByVal wliquidacion As Liquidacion, ByVal wcuentaBancaria As CuentaBancaria, ByVal wadministrativo As Administrativo)
    Me.codigoDeposito = wcodigoDeposito
    Me.monto = wmonto
    Me.fecha = wfecha
    Me.vigencia = wvigencia
    Me.Liquidacion = wliquidacion
    Me.CuentaBancaria = wcuentaBancaria
    Me.Administrativo = wadministrativo
  End Sub
#End Region

End Class
