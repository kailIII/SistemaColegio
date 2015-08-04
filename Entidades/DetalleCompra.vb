Public Class DetalleCompra

#Region "Datos"
	Private mcantidad AS Integer
	Private mprecioTotal AS Double
	Private mcodigoCompra AS Integer
	Private mcodigoConceptoCompra AS Integer
  Private mdescripcion As String
  Private mOCompra As Compra
  Private mOConceptoCompra As ConceptoCompra
#End Region
#Region "Propiedades"
	Public Property cantidad() AS Integer
		Get
			return Me.mcantidad
		End Get
		Set(ByVal value As Integer)
			Me.mcantidad = value
		End Set
	End Property
	Public Property precioTotal() AS Double
		Get
			return Me.mprecioTotal
		End Get
		Set(ByVal value As Double)
			Me.mprecioTotal = value
		End Set
	End Property
	Public Property codigoCompra() AS Integer
		Get
			return Me.mcodigoCompra
		End Get
		Set(ByVal value As Integer)
			Me.mcodigoCompra = value
		End Set
	End Property
	Public Property codigoConceptoCompra() AS Integer
		Get
			return Me.mcodigoConceptoCompra
		End Get
		Set(ByVal value As Integer)
			Me.mcodigoConceptoCompra = value
		End Set
	End Property
	Public Property descripcion() AS String
		Get
			return Me.mdescripcion
		End Get
		Set(ByVal value As String)
			Me.mdescripcion = value
		End Set
  End Property
  Public Property Compra() As Compra
    Get
      Return Me.mOCompra
    End Get
    Set(ByVal value As Compra)
      Me.mOCompra = value
    End Set
  End Property
  Public Property ConceptoCompra() As ConceptoCompra
    Get
      Return Me.mOConceptoCompra
    End Get
    Set(ByVal value As ConceptoCompra)
      Me.mOConceptoCompra = value
    End Set
  End Property
  Public ReadOnly Property nombreProducto() As String
    Get
      Return Me.ConceptoCompra.nombre
    End Get
  End Property
#End Region
#Region "Constructores"
	Public Sub New()
	End Sub
  Public Sub New(ByVal wcantidad As Integer, ByVal wprecioTotal As Double, ByVal wCompra As Compra,
                 ByVal wConceptoCompra As ConceptoCompra, ByVal wdescripcion As String)
    Me.cantidad = wcantidad
    Me.precioTotal = wprecioTotal
    Me.Compra = wCompra
    Me.ConceptoCompra = wConceptoCompra
    Me.descripcion = wdescripcion
  End Sub
  
#End Region

End Class