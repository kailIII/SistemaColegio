
Public Class EstadoCuenta

#Region "Datos"

  Private mDescripcion As String
  Private mImporte As Double
  Private mDescuento As Double
  Private mPagar As Double
  Private mPago As Double
  Private mSaldo As Double
  Private mNombre As String
  Private mTotalImporte As Double
  Private mTotalPago As Double
  Private mTotalSaldo As Double
  Private mFecha As DateTime
  Private mEstado As String
#End Region

#Region "Propiedades"
  Public Property Descripcion() As String
    Get
      Return mDescripcion
    End Get
    Set(ByVal value As String)
      mDescripcion = value
    End Set
  End Property
  Public Property Importe() As Double
    Get
      Return mImporte
    End Get
    Set(ByVal value As Double)
      mImporte = value
    End Set
  End Property
  Public Property Descuento() As Double
    Get
      Return mDescuento
    End Get
    Set(ByVal value As Double)
      mDescuento = value
    End Set
  End Property
  Public Property Pagar() As Double
    Get
      Return mPagar
    End Get
    Set(ByVal value As Double)
      mPagar = value
    End Set
  End Property
  Public Property Pago() As Double
    Get
      Return mPago
    End Get
    Set(ByVal value As Double)
      mPago = value
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
  Public Property Nombre() As String
    Get
      Return mNombre
    End Get
    Set(ByVal value As String)
      mNombre = value
    End Set
  End Property
  Public Property TotalImporte() As Double
    Get
      Return mTotalImporte
    End Get
    Set(ByVal value As Double)
      mTotalImporte = value
    End Set
  End Property
  Public Property TotalPago() As Double
    Get
      Return mTotalPago
    End Get
    Set(ByVal value As Double)
      mTotalPago = value
    End Set
  End Property
  Public Property TotalSaldo() As Double
    Get
      Return mTotalSaldo
    End Get
    Set(ByVal value As Double)
      mTotalSaldo = value
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
  Public Property Estado() As String
    Get
      Return mEstado
    End Get
    Set(ByVal value As String)
      mEstado = value
    End Set
  End Property
#End Region

#Region "Constructores"

  Sub New()
  End Sub

  Sub New(ByVal wDescripcion As String, ByVal wImporte As Double, ByVal wDescuento As Double, ByVal wPagar As Double, ByVal wPago As Double _
          , ByVal wSaldo As Double, ByVal wNombre As String, ByVal wTotalImporte As Double _
          , ByVal wTotalPago As Double, ByVal wTotalSaldo As Double, ByVal wFecha As DateTime, ByVal wEstado As String)

    Descripcion = wDescripcion
    Importe = wImporte
    Descuento = wDescuento
    Pagar = wPagar
    Pago = wPago
    Saldo = wSaldo
    Nombre = wNombre
    TotalImporte = wTotalImporte
    TotalPago = wTotalPago
    TotalSaldo = wTotalSaldo
    Fecha = wFecha
    Estado = wEstado
  End Sub

#End Region

End Class