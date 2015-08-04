Public Class ConceptoOperacion

#Region "Datos"
  Private mcodigoConceptoOperacion As Integer
	Private mdescripcion AS String
	Private mtipo AS String
#End Region
#Region "Propiedades"
	Public Property codigoConceptoOperacion() AS Integer
		Get
			return Me.mcodigoConceptoOperacion
		End Get
		Set(ByVal value As Integer)
			Me.mcodigoConceptoOperacion = value
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
	Public Sub New(Byval wcodigoConceptoOperacion AS Integer,Byval wdescripcion AS String,Byval wtipo AS String)
		Me.codigoConceptoOperacion = wcodigoConceptoOperacion
		Me.descripcion = wdescripcion
		Me.tipo = wtipo
	End Sub
#End Region

End Class