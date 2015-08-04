Public Class MovimientoHistorico
#Region "Datos"
  Private mCodigo As Integer
  Private mImporte As Double
  Private mFecha As DateTime
  Private mVigencia As Boolean
  Private mCuentaBancaria As CuentaBancaria
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
  Public Property importe() As Double
    Get
      Return mImporte
    End Get
    Set(ByVal value As Double)
      mImporte = value
    End Set
  End Property
  Public Property fecha() As DateTime
    Get
      Return mFecha
    End Get
    Set(ByVal value As DateTime)
      mFecha = value
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
#End Region
#Region "Metodos"
  Sub New()

  End Sub
  Sub New(ByVal wcodigoMovHistorico As Integer, ByVal wimporte As Double, ByVal wfecha As DateTime, _
          ByVal wvigencia As Boolean, ByVal wCuentaCtte As CuentaBancaria)
    Me.Codigo = wcodigoMovHistorico
    Me.importe = wimporte
    Me.fecha = wfecha
    Me.vigencia = wvigencia
    Me.mCuentaBancaria = wCuentaCtte
  End Sub
#End Region
End Class
