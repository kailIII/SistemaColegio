Public Class DetalleRecibo

#Region "Datos"

  Private mOObligacion As Obligacion
  Private mOServicio As Servicio
  Private mDescripcion As String
  Private mMonto As Double
#End Region

#Region "Propiedades"

  Public Property Obligacion() As Obligacion
    Get
      Return Me.mOObligacion
    End Get
    Set(ByVal value As Obligacion)
      Me.mOObligacion = value
    End Set
  End Property

  Public Property Servicio() As Servicio
    Get
      Return Me.mOServicio
    End Get
    Set(ByVal value As Servicio)
      Me.mOServicio = value
    End Set
  End Property

  Public Property Descripcion() As String
    Get
      Return Me.mDescripcion
    End Get
    Set(ByVal value As String)
      Me.mDescripcion = value
    End Set
  End Property

  Public Property Monto() As Double
    Get
      Return Me.mMonto
    End Get
    Set(ByVal value As Double)
      Me.mMonto = value
    End Set
  End Property

#End Region

End Class
