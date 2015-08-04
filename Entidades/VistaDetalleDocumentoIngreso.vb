Public Class VistaDetalleDocumentoIngreso
  Inherits DetalleDocumentoIngreso

#Region "Datos"

  Private mSeleccionado As Boolean
  Private mMontoOriginal As Double
  Private mBeneficio As Beneficio
  'Private mDescuento As Double
#End Region

#Region "Propiedades"

  Public ReadOnly Property MontoInicial() As Double
    Get
      Return Me.Monto + Me.Descuento
    End Get
  End Property

  Public Property MontoOriginal() As Double
    Get
      Return mMontoOriginal
    End Get
    Set(ByVal value As Double)
      mMontoOriginal = value
    End Set
  End Property

  Public Property Beneficio() As Beneficio
    Get
      Return mBeneficio
    End Get
    Set(ByVal value As Beneficio)
      mBeneficio = value
    End Set
  End Property

  Public ReadOnly Property Descuento() As Double
    Get
      If Me.mBeneficio IsNot Nothing Then
        Return Me.mBeneficio.Descuento
      Else
        Return 0
      End If
    End Get
  End Property

  Public Property Seleccionado() As Boolean
    Get
      Return mSeleccionado
    End Get
    Set(ByVal value As Boolean)
      mSeleccionado = value
    End Set
  End Property

#End Region


End Class
