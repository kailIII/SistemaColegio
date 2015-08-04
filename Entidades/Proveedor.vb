Public Class Proveedor

#Region "Datos"
	Private mcodigoProveedor AS Integer
	Private mrazonSocial AS String
	Private mruc AS String
	Private mcodigoPersona AS Integer
	Private mtipo AS String
#End Region
#Region "Propiedades"
	Public Property codigoProveedor() AS Integer
		Get
			return Me.mcodigoProveedor
		End Get
		Set(ByVal value As Integer)
			Me.mcodigoProveedor = value
		End Set
	End Property
	Public Property razonSocial() AS String
		Get
			return Me.mrazonSocial
		End Get
		Set(ByVal value As String)
			Me.mrazonSocial = value
		End Set
	End Property
	Public Property ruc() AS String
		Get
			return Me.mruc
		End Get
		Set(ByVal value As String)
			Me.mruc = value
		End Set
	End Property
	Public Property codigoPersona() AS Integer
		Get
			return Me.mcodigoPersona
		End Get
		Set(ByVal value As Integer)
			Me.mcodigoPersona = value
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
	Public Sub New(Byval wcodigoProveedor AS Integer,Byval wrazonSocial AS String,Byval wruc AS String,Byval wcodigoPersona AS Integer,Byval wtipo AS String)
		Me.codigoProveedor = wcodigoProveedor
		Me.razonSocial = wrazonSocial
		Me.ruc = wruc
		Me.codigoPersona = wcodigoPersona
		Me.tipo = wtipo
	End Sub
#End Region

End Class