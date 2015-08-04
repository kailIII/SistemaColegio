Public Class ConceptoCompra

#Region "Datos"
	Private mcodigoConceptoCompra AS Integer
	Private mnombre AS String
	Private mvigencia AS Boolean
	Private mtipo AS String
#End Region
#Region "Propiedades"
	Public Property codigoConceptoCompra() AS Integer
		Get
			return Me.mcodigoConceptoCompra
		End Get
		Set(ByVal value As Integer)
			Me.mcodigoConceptoCompra = value
		End Set
	End Property
	Public Property nombre() AS String
		Get
			return Me.mnombre
		End Get
		Set(ByVal value As String)
			Me.mnombre = value
		End Set
	End Property
	Public Property vigencia() AS Boolean
		Get
			return Me.mvigencia
		End Get
		Set(ByVal value As Boolean)
			Me.mvigencia = value
		End Set
	End Property
	Public Property tipo() AS String
		Get
			return Me.mtipo
		End Get
		Set(ByVal value As String)
			Me.mtipo = value
		End Set
	End Property
#End Region
#Region "Constructores"
	Public Sub New()
	End Sub
	Public Sub New(Byval wcodigoConceptoCompra AS Integer,Byval wnombre AS String,Byval wvigencia AS Boolean,Byval wtipo AS String)
		Me.codigoConceptoCompra = wcodigoConceptoCompra
		Me.nombre = wnombre
		Me.vigencia = wvigencia
		Me.tipo = wtipo
	End Sub
#End Region

End Class