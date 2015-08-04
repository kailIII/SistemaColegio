Public Class VoucherPago
#Region "Datos"
  Private mCodigo As Integer
  Private mMonto As Double
  Private mFecha As DateTime
  Private mVigencia As Boolean
  Private mnumOperacion As String
  Private mMovimientoHistorico As MovimientoHistorico
  Private mCuentaBancaria As CuentaBancaria
  Private mAdministrativo As Administrativo

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
  Public Property Monto() As Double
    Get
      Return mMonto
    End Get
    Set(ByVal value As Double)
      mMonto = value
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
  Public Property vigencia() As Boolean
    Get
      Return mVigencia
    End Get
    Set(ByVal value As Boolean)
      mVigencia = value
    End Set
  End Property
  Public Property NumOperacion() As String
    Get
      Return mnumOperacion
    End Get
    Set(ByVal value As String)
      mnumOperacion = value
    End Set
  End Property
  Public Property MovimientoHistorico() As MovimientoHistorico
    Get
      Return mMovimientoHistorico
    End Get
    Set(ByVal value As MovimientoHistorico)
      mMovimientoHistorico = value
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
#End Region
#Region "Metodos"
  Sub New()

  End Sub
  Sub New(ByVal wcodigoVoucher As Integer, ByVal wnumOperacion As String)
    Me.Codigo = wcodigoVoucher
    Me.NumOperacion = wnumOperacion
  End Sub
  Sub New(ByVal wcodigoVoucher As Integer, ByVal wctta As CuentaBancaria)
    Me.Codigo = wcodigoVoucher
    Me.CuentaBancaria = wctta
  End Sub
  Sub New(ByVal wcodigoVoucher As Integer, ByVal wmonto As Double, ByVal wfecha As DateTime, ByVal wnumOperacion As String, _
          ByVal wvigencia As Boolean, ByVal wMovHistorico As MovimientoHistorico, ByVal wCuentaCtte As CuentaBancaria, _
          ByVal wAdminitrativo As Administrativo)
    Me.Codigo = wcodigoVoucher
    Me.Monto = wmonto
    Me.Fecha = wfecha
    Me.vigencia = wvigencia
    Me.NumOperacion = wnumOperacion
    Me.MovimientoHistorico = wMovHistorico
    Me.mCuentaBancaria = wCuentaCtte
    Me.Administrativo = wAdminitrativo
  End Sub
  Sub New(ByVal wcodigoVoucher As Integer)
    Me.Codigo = wcodigoVoucher
  End Sub
#End Region
End Class
