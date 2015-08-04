Public Class OperacionCajaChica

#Region "Datos"
	Private mcodigoOperacion AS Integer
	Private mfecha AS DateTime
	Private mvigencia AS Boolean
	Private mnumeroDocumento AS String
  Private mOTipoDocumento As TipoDocumento
  Private mOCajaChica As CajaChica
  Private mOConceptoOperacion As ConceptoOperacion
  Private mmonto As Double
  Private mOBeneficiario As Personal
  Private mIngreso As Double
  Private mEgreso As Double
#End Region
#Region "Propiedades"
	Public Property codigoOperacion() AS Integer
		Get
			return Me.mcodigoOperacion
		End Get
		Set(ByVal value As Integer)
			Me.mcodigoOperacion = value
		End Set
	End Property
	Public Property fecha() AS DateTime
		Get
			return Me.mfecha
		End Get
		Set(ByVal value As DateTime)
			Me.mfecha = value
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
	Public Property numeroDocumento() AS String
		Get
			return Me.mnumeroDocumento
		End Get
		Set(ByVal value As String)
			Me.mnumeroDocumento = value
		End Set
	End Property
  Public Property TipoDocumento() As TipoDocumento
    Get
      Return Me.mOTipoDocumento
    End Get
    Set(ByVal value As TipoDocumento)
      Me.mOTipoDocumento = value
    End Set
  End Property
  Public ReadOnly Property documento() As String
    Get
      Dim doc = ""
      If Me.mOTipoDocumento.descripcion <> "SIN DOCUMENTO" Then
        doc = Me.mOTipoDocumento.descripcion.Substring(0, 3) & "-" & Me.numeroDocumento
      End If
      Return doc
    End Get
  End Property
  Public ReadOnly Property descripcion() As String
    Get
      Return Me.mOConceptoOperacion.descripcion
    End Get
  End Property
  Public ReadOnly Property NombreCompleto() As String
    Get
      Return Me.mOBeneficiario.NombreCompleto
    End Get
  End Property
  Public Property CajaChica() As CajaChica
    Get
      Return Me.mOCajaChica
    End Get
    Set(ByVal value As CajaChica)
      Me.mOCajaChica = value
    End Set
  End Property
  Public Property ConceptoOperacion() As ConceptoOperacion
    Get
      Return Me.mOConceptoOperacion
    End Get
    Set(ByVal value As ConceptoOperacion)
      Me.mOConceptoOperacion = value
    End Set
  End Property
	Public Property monto() AS Double
		Get
			return Me.mmonto
		End Get
		Set(ByVal value As Double)
			Me.mmonto = value
		End Set
  End Property
  Public ReadOnly Property ingreso() As String
    Get
      If Me.mOConceptoOperacion.tipo = "I" Then
        Return Me.mmonto.ToString
      Else
        Return ""
      End If
    End Get
  End Property
  Public ReadOnly Property egreso() As String
    Get
      If Me.mOConceptoOperacion.tipo = "E" Then
        Return Me.mmonto.ToString
      Else
        Return ""
      End If
    End Get
  End Property
  Public Property Beneficiario() As Personal
    Get
      Return Me.mOBeneficiario
    End Get
    Set(ByVal value As Personal)
      Me.mOBeneficiario = value
    End Set
  End Property
#End Region
#Region "Constructores"
	Public Sub New()
	End Sub
  Public Sub New(ByVal wcodigoOperacion As Integer, ByVal wfecha As DateTime, ByVal wvigencia As Boolean,
                 ByVal wnumeroDocumento As String, ByVal wTipoDocumento As TipoDocumento, ByVal wBeneficiario As Personal,
                 ByVal wCajaChica As CajaChica, ByVal wConceptoOperacion As ConceptoOperacion, ByVal wmonto As Double)
    Me.codigoOperacion = wcodigoOperacion
    Me.fecha = wfecha
    Me.vigencia = wvigencia
    Me.numeroDocumento = wnumeroDocumento
    Me.TipoDocumento = wTipoDocumento
    Me.CajaChica = wCajaChica
    Me.ConceptoOperacion = wConceptoOperacion
    Me.monto = wmonto
    Me.Beneficiario = wBeneficiario
  End Sub
  Public Sub New(ByVal wcodigoOperacion As Integer, ByVal wfecha As DateTime,
                 ByVal wnumeroDocumento As String, ByVal wTipoDocumento As TipoDocumento, ByVal wBeneficiario As Personal,
                 ByVal wConceptoOperacion As ConceptoOperacion, ByVal wmonto As Double)
    Me.codigoOperacion = wcodigoOperacion
    Me.fecha = wfecha
    Me.numeroDocumento = wnumeroDocumento
    Me.TipoDocumento = wTipoDocumento
    Me.ConceptoOperacion = wConceptoOperacion
    Me.Beneficiario = wBeneficiario
    Me.monto = wmonto
  End Sub
#End Region

End Class