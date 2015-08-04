Public Class CuentaBancaria

#Region "Datos"

  Private mNumero As String
  Private mTipo As String
  Private mMoneda As Boolean
  Private mSaldo As Double
  Private mEntidadFinanciera As EntidadFinanciera

#End Region

#Region "Propiedades"

  Public Property Numero() As String
    Get
      Return mNumero
    End Get
    Set(ByVal value As String)
      mNumero = value
    End Set
  End Property

  Public Property Tipo() As String
    Get
      Return mTipo
    End Get
    Set(ByVal value As String)
      mTipo = mTipo
    End Set
  End Property

  Public Property Moneda() As Boolean
    Get
      Return mMoneda
    End Get
    Set(ByVal value As Boolean)
      mMoneda = value
    End Set
  End Property

  Public Property Saldo() As Double
    Get
      Return mSaldo
    End Get
    Set(ByVal value As Double)
      mSaldo = value
    End Set
  End Property

  Public Property EntidadFinanciera() As EntidadFinanciera
    Get
      Return mEntidadFinanciera
    End Get
    Set(ByVal value As EntidadFinanciera)
      mEntidadFinanciera = value
    End Set
  End Property

  Public ReadOnly Property NumeroMoneda() As Integer
    Get
      If Moneda = False Then
        Return 0
      Else
        Return 1
      End If
    End Get
  End Property

  Public ReadOnly Property DescripcionMoneda() As String
    Get
      If Moneda = False Then
        Return "SOL"
      Else
        Return "USD"
      End If
    End Get
  End Property

#End Region

#Region "Metodos"

  Public Sub New()

  End Sub

  Public Sub New(ByVal wNumero As String, ByVal wTipo As String, ByVal wMoneda As Boolean, ByVal wSaldo As Double, ByVal wEntidadFinanciera As EntidadFinanciera)
    Me.Numero = wNumero
    Me.Tipo = wTipo
    Me.Moneda = wMoneda
    Me.Saldo = wSaldo
    Me.EntidadFinanciera = wEntidadFinanciera
  End Sub

  Public Sub New(ByVal wNumeroCuenta As String, ByVal wEntidadFinanciera As EntidadFinanciera)
    Me.Numero = wNumeroCuenta
    Me.EntidadFinanciera = wEntidadFinanciera
  End Sub

#End Region

End Class
