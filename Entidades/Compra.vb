Public Class Compra

#Region "Datos"
	Private mcodigoCompra AS Integer
	Private mfecha AS DateTime
	Private mvigencia AS Boolean
  Private mnumeroDocumento As String
	Private mcodigoTipoDocumento AS Integer
	Private mcodigoBeneficiario AS Integer
	Private mestadoDocumento AS String
	Private mcodigoProveedor AS Integer
	Private mfechaAprobacion AS DateTime
	Private mfechaPago AS DateTime
  Private mserie As String
  Private mIGV As Double
  Private mOProveedor As Proveedor
  Private mOBeneficiario As Personal
  Private mOTipoDocumento As TipoDocumento
  Private mmonto As Decimal
#End Region
#Region "Propiedades"
  Public Property monto() As Decimal
    Get
      Return Me.mmonto
    End Get
    Set(ByVal value As Decimal)
      Me.mmonto = value
    End Set
  End Property
  Public Property codigoCompra() As Integer
    Get
      Return Me.mcodigoCompra
    End Get
    Set(ByVal value As Integer)
      Me.mcodigoCompra = value
    End Set
  End Property
  Public Property fecha() As DateTime
    Get
      Return Me.mfecha
    End Get
    Set(ByVal value As DateTime)
      Me.mfecha = value
    End Set
  End Property
  Public Property vigencia() As Boolean
    Get
      Return Me.mvigencia
    End Get
    Set(ByVal value As Boolean)
      Me.mvigencia = value
    End Set
  End Property
  Public Property numeroDocumento() As String
    Get
      Return Me.mnumeroDocumento
    End Get
    Set(ByVal value As String)
      Me.mnumeroDocumento = value
    End Set
  End Property
  Public Property codigoTipoDocumento() As Integer
    Get
      Return Me.mcodigoTipoDocumento
    End Get
    Set(ByVal value As Integer)
      Me.mcodigoTipoDocumento = value
    End Set
  End Property
  Public Property codigoBeneficiario() As Integer
    Get
      Return Me.mcodigoBeneficiario
    End Get
    Set(ByVal value As Integer)
      Me.mcodigoBeneficiario = value
    End Set
  End Property
  Public Property estadoDocumento() As String
    Get
      Return Me.mestadoDocumento
    End Get
    Set(ByVal value As String)
      Me.mestadoDocumento = value
    End Set
  End Property
  Public Property codigoProveedor() As Integer
    Get
      Return Me.mcodigoProveedor
    End Get
    Set(ByVal value As Integer)
      Me.mcodigoProveedor = value
    End Set
  End Property
  Public Property fechaAprobacion() As DateTime
    Get
      Return Me.mfechaAprobacion
    End Get
    Set(ByVal value As DateTime)
      Me.mfechaAprobacion = value
    End Set
  End Property
  Public Property fechaPago() As DateTime
    Get
      Return Me.mfechaPago
    End Get
    Set(ByVal value As DateTime)
      Me.mfechaPago = value
    End Set
  End Property
  Public Property serie() As String
    Get
      Return Me.mserie
    End Get
    Set(ByVal value As String)
      Me.mserie = value
    End Set
  End Property
  Public Property IGV() As Double
    Get
      Return Me.mIGV
    End Get
    Set(ByVal value As Double)
      Me.mIGV = value
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
  Public Property Proveedor() As Proveedor
    Get
      Return Me.mOProveedor
    End Get
    Set(ByVal value As Proveedor)
      Me.mOProveedor = value
    End Set
  End Property
  Public Property Beneficiario() As Personal
    Get
      Return Me.mOBeneficiario
    End Get
    Set(ByVal value As Personal)
      Me.mOBeneficiario = value
    End Set
  End Property
  Public ReadOnly Property nombreBeneficiario() As String
    Get
      Return Me.mOBeneficiario.NombreCompleto
    End Get
  End Property
  Public ReadOnly Property nombreTipoDocumento() As String
    Get
      Return Me.mOTipoDocumento.descripcion
    End Get
  End Property
  Public ReadOnly Property Documento() As String
    Get
      Return Me.mserie & "-" & Me.mnumeroDocumento
    End Get
  End Property
#End Region
#Region "Constructores"
	Public Sub New()
	End Sub
  Public Sub New(ByVal wcodigoCompra As Integer, ByVal wfecha As DateTime, ByVal wvigencia As Boolean,
                 ByVal wnumeroDocumento As String, ByVal wcodigoTipoDocumento As Integer,
                 ByVal wcodigoBeneficiario As Integer, ByVal westadoDocumento As String, ByVal wcodigoProveedor As Integer,
                 ByVal wfechaAprobacion As DateTime, ByVal wfechaPago As DateTime, ByVal wserie As String, ByVal wIGV As Double)
    Me.codigoCompra = wcodigoCompra
    Me.fecha = wfecha
    Me.vigencia = wvigencia
    Me.numeroDocumento = wnumeroDocumento
    Me.codigoTipoDocumento = wcodigoTipoDocumento
    Me.codigoBeneficiario = wcodigoBeneficiario
    Me.estadoDocumento = westadoDocumento
    Me.codigoProveedor = wcodigoProveedor
    Me.fechaAprobacion = wfechaAprobacion
    Me.fechaPago = wfechaPago
    Me.serie = wserie
    Me.IGV = wIGV
  End Sub
  Public Sub New(ByVal wnumeroDocumento As String, ByVal wTipoDocumento As TipoDocumento,
                 ByVal wBeneficiario As Personal,
                 ByVal wserie As String, ByVal wIGV As Double)
    Me.numeroDocumento = wnumeroDocumento
    Me.TipoDocumento = wTipoDocumento
    Me.Beneficiario = wBeneficiario
    Me.serie = wserie
    Me.IGV = wIGV
  End Sub
#End Region

End Class