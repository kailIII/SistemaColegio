Public Class ResumenFormaPago

  Private mEntidadFinanciera As EntidadFinanciera
  Private mFormaPago As String
  Private mTotal As Double

  Public Property Total() As Double
    Get
      Return mTotal
    End Get
    Set(ByVal value As Double)
      mTotal = value
    End Set
  End Property

  Public Property FormaPago() As String
    Get
      Return mFormaPago
    End Get
    Set(ByVal value As String)
      mFormaPago = value
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

End Class
