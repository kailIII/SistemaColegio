Public Class TipoDocumento

#Region "Datos"
	Private mcodigoTipoDocumento AS Integer
	Private mdescripcion AS String
#End Region
#Region "Propiedades"
	Public Property codigoTipoDocumento() AS Integer
		Get
			return Me.mcodigoTipoDocumento
		End Get
		Set(ByVal value As Integer)
			Me.mcodigoTipoDocumento = value
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
#End Region
#Region "Constructores"
	Public Sub New()
	End Sub
	Public Sub New(Byval wcodigoTipoDocumento AS Integer,Byval wdescripcion AS String)
		Me.codigoTipoDocumento = wcodigoTipoDocumento
		Me.descripcion = wdescripcion
	End Sub
#End Region

End Class