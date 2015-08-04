Public Class CajaChica

#Region "Datos"
	Private mcodigoCajaChica AS Integer
	Private mmontoReposicion AS Double
	Private mfechaApertura AS DateTime
	Private mvigencia AS Boolean
	Private mcodigoPersonalReposicion AS Integer
	Private mfechaCierre AS DateTime
	Private msaldo AS Double
  Private mcodigoRespCajaChica As Integer
  Private mOPersonalReposicion As Personal
  Private mOResponsableCajaChica As ResponsableCajaChica
#End Region
#Region "Propiedades"
	Public Property codigoCajaChica() AS Integer
		Get
			return Me.mcodigoCajaChica
		End Get
		Set(ByVal value As Integer)
			Me.mcodigoCajaChica = value
		End Set
	End Property
	Public Property montoReposicion() AS Double
		Get
			return Me.mmontoReposicion
		End Get
		Set(ByVal value As Double)
			Me.mmontoReposicion = value
		End Set
  End Property

  Public ReadOnly Property nombreResponsableReposicion() As String
    Get
      Return PersonalReposicion.NombreCompleto
    End Get
  End Property


	Public Property fechaApertura() AS DateTime
		Get
			return Me.mfechaApertura
		End Get
		Set(ByVal value As DateTime)
			Me.mfechaApertura = value
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
	Public Property codigoPersonalReposicion() AS Integer
		Get
			return Me.mcodigoPersonalReposicion
		End Get
		Set(ByVal value As Integer)
			Me.mcodigoPersonalReposicion = value
		End Set
	End Property
	Public Property fechaCierre() AS DateTime
		Get
			return Me.mfechaCierre
		End Get
		Set(ByVal value As DateTime)
			Me.mfechaCierre = value
		End Set
	End Property
	Public Property saldo() AS Double
		Get
			return Me.msaldo
		End Get
		Set(ByVal value As Double)
			Me.msaldo = value
		End Set
	End Property
	Public Property codigoRespCajaChica() AS Integer
		Get
			return Me.mcodigoRespCajaChica
		End Get
		Set(ByVal value As Integer)
			Me.mcodigoRespCajaChica = value
		End Set
  End Property
  Public Property PersonalReposicion() As Personal
    Get
      Return Me.mOPersonalReposicion
    End Get
    Set(ByVal value As Personal)
      Me.mOPersonalReposicion = value
    End Set
  End Property
  Public Property ResponsableCajaChica() As ResponsableCajaChica
    Get
      Return Me.mOResponsableCajaChica
    End Get
    Set(ByVal value As ResponsableCajaChica)
      Me.mOResponsableCajaChica = value
    End Set
  End Property
#End Region
#Region "Constructores"
	Public Sub New()
  End Sub
  Public Sub New(ByVal wcodigoCajahica As Integer)
    Me.codigoCajaChica = wcodigoCajahica
  End Sub
  Public Sub New(ByVal wcodigoCajaChica As Integer, ByVal wmontoReposicion As Double, ByVal wfechaApertura As DateTime,
                 ByVal wvigencia As Boolean, ByVal wPersonalReposicion As Personal, ByVal wfechaCierre As DateTime,
                 ByVal wsaldo As Double, ByVal wRespCajaChica As ResponsableCajaChica)
    Me.codigoCajaChica = wcodigoCajaChica
    Me.montoReposicion = wmontoReposicion
    Me.fechaApertura = wfechaApertura
    Me.vigencia = wvigencia
    Me.PersonalReposicion = wPersonalReposicion
    Me.fechaCierre = wfechaCierre
    Me.saldo = wsaldo
    Me.ResponsableCajaChica = wRespCajaChica
  End Sub
  Public Sub New(ByVal wmontoReposicion As Double, ByVal wPersonalReposicion As Personal,
                 ByVal wsaldo As Double, ByVal wRespCajaChica As ResponsableCajaChica)
    Me.montoReposicion = wmontoReposicion
    Me.PersonalReposicion = wPersonalReposicion    
    Me.saldo = wsaldo
    Me.ResponsableCajaChica = wRespCajaChica
  End Sub
#End Region

End Class