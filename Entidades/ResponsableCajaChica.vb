Public Class ResponsableCajaChica

#Region "Datos"
	Private mcodigoRespCajaChica AS Integer
	Private mvigencia AS Boolean
	Private mcodigoPersonal AS Integer
#End Region
#Region "Propiedades"
	Public Property codigoRespCajaChica() AS Integer
		Get
			return Me.mcodigoRespCajaChica
		End Get
		Set(ByVal value As Integer)
			Me.mcodigoRespCajaChica = value
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
	Public Property codigoPersonal() AS Integer
		Get
			return Me.mcodigoPersonal
		End Get
		Set(ByVal value As Integer)
			Me.mcodigoPersonal = value
		End Set
	End Property
#End Region
#Region "Constructores"
	Public Sub New()
	End Sub
	Public Sub New(Byval wcodigoRespCajaChica AS Integer,Byval wvigencia AS Boolean,Byval wcodigoPersonal AS Integer)
		Me.codigoRespCajaChica = wcodigoRespCajaChica
		Me.vigencia = wvigencia
		Me.codigoPersonal = wcodigoPersonal
	End Sub
#End Region

End Class