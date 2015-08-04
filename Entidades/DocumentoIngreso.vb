Public Class DocumentoIngreso

#Region "Datos"

  Private mCodigo As Integer
  Private mEntidad As String
  Private mFecha As DateTime
  Private mTipoDoc As String
  Private mSerie As Integer
  Private mNumero As Integer
  Private mOLiquidacion As Liquidacion
  Private mOPersona As Persona
  Private mOVoucher As VoucherPago
  Private mOAdministrativo As Administrativo
  Private mVigencia As Boolean
  Private mFormaPago As String
  Private mTotal As Double

  Private mODetalles As List(Of DetalleDocumentoIngreso)
#End Region

#Region "Propiedades"

  Public Property Codigo() As Integer
    Get
      Return mCodigo
    End Get
    Set(ByVal value As Integer)
      mCodigo = value
    End Set
  End Property

  Public Property Entidad() As String
    Get
      Return mEntidad
    End Get
    Set(ByVal value As String)
      mEntidad = value
    End Set
  End Property

  Public Property Fecha() As DateTime
    Get
      Return mFecha
    End Get
    Set(ByVal value As DateTime)
      mFecha = value
    End Set
  End Property

  Public Property Serie() As Integer
    Get
      Return mSerie
    End Get
    Set(ByVal value As Integer)
      mSerie = value
    End Set
  End Property

  Public Property Numero() As Integer
    Get
      Return mNumero
    End Get
    Set(ByVal value As Integer)
      mNumero = value
    End Set
  End Property

  Public Property Voucher() As VoucherPago
    Get
      Return mOVoucher
    End Get
    Set(ByVal value As VoucherPago)
      mOVoucher = value
    End Set
  End Property

  Public Property Liquidacion() As Liquidacion
    Get
      Return mOLiquidacion
    End Get
    Set(ByVal value As Liquidacion)
      mOLiquidacion = value
    End Set
  End Property

  Public Property Persona() As Persona
    Get
      Return mOPersona
    End Get
    Set(ByVal value As Persona)
      mOPersona = value
    End Set
  End Property

  Public Property TipoDocumento() As String
    Get
      Return mTipoDoc
    End Get
    Set(ByVal value As String)
      mTipoDoc = value
    End Set
  End Property

  Public Property Administrativo() As Administrativo
    Get
      Return mOAdministrativo
    End Get
    Set(ByVal value As Administrativo)
      mOAdministrativo = value
    End Set
  End Property

  Public Property FormaPago() As String
    Get
      Return Me.mFormaPago
    End Get
    Set(ByVal value As String)
      Me.mFormaPago = value
    End Set
  End Property

  Public Property Vigencia() As Boolean
    Get
      Return mVigencia
    End Get
    Set(ByVal value As Boolean)
      mVigencia = value
    End Set
  End Property

  Public Property Total() As Double
    Get
      If Me.mODetalles IsNot Nothing Then
        Me.mTotal = 0

        If Me.Vigencia = True Then
          For Each det As DetalleDocumentoIngreso In Me.Detalles
            Me.mTotal += det.Monto
          Next
        End If
        Return Me.mTotal
      Else
        Return Me.mTotal
      End If
    End Get
    Set(ByVal value As Double)
      Me.mTotal = value
    End Set
  End Property

  Public ReadOnly Property MostrarCodigoVoucher() As Integer
    Get
      Return Voucher.Codigo
    End Get
  End Property

  Public ReadOnly Property FechaVoucher() As Date
    Get
      Return Me.Voucher.Fecha
    End Get
  End Property

  Public ReadOnly Property CodigoPersona() As Integer
    Get
      If Me.Vigencia = True Then
        Return Me.Persona.Codigo
      Else
        Return 0
      End If
    End Get
  End Property

  Public ReadOnly Property DocumentoNumero() As String
    Get
      Dim td As String = ""
      Select Case Me.TipoDocumento
        Case "B" : td = "BOL"
        Case "R" : td = "REC"
        Case "F" : td = "FAC"
      End Select
      Return td & " " & Me.Serie.ToString("000") & "-" & Me.Numero.ToString("000000")
    End Get
  End Property

  Public ReadOnly Property NombrePersona() As String
    Get
      If Me.Vigencia = True Then
        Return Me.Persona.NombreCompleto
      Else
        Return "***** ANULADO *****"
      End If
    End Get
  End Property

  Public ReadOnly Property DescripcionTipoDocumento() As String
    Get
      If Me.TipoDocumento = "B" Then
        Return "BOLETA DE VENTA"
      ElseIf Me.TipoDocumento = "R" Then
        Return "RECIBO DE PAGO"
      Else
        Return "FACTURA"
      End If
    End Get
  End Property

  Public ReadOnly Property DescripcionFormaPago() As String
    Get
      Dim fp As String = ""

      Select Case Me.FormaPago
        Case "E"
          fp = "Efectivo"
        Case "V"
          fp = "Voucher"
        Case "C"
          fp = "Cheque"
      End Select

      Return fp
    End Get
  End Property

  Public ReadOnly Property DescripcionVigencia() As String
    Get
      Dim vig As String = ""

      If Me.Vigencia = True Then
        vig = "VIGENTE"
      Else
        vig = "ANULADO"
      End If

      Return vig
    End Get
  End Property

  Public ReadOnly Property Operacion() As String
    Get
      If Me.Voucher IsNot Nothing Then
        Return Me.Voucher.NumOperacion
      Else
        Return ""
      End If
    End Get
  End Property

  Public Property Detalles() As List(Of DetalleDocumentoIngreso)
    Get
      Return Me.mODetalles
    End Get
    Set(ByVal value As List(Of DetalleDocumentoIngreso))
      mODetalles = value
    End Set
  End Property

#End Region

#Region "Metodos"

  Sub New()

  End Sub

  Sub New(ByVal wCodigoDctoIngreso As Integer, ByVal wentidad As String, ByVal wnumero As Integer, _
          ByVal wserie As Integer, ByVal wtipoDoc As String, ByVal wVigencia As Boolean, ByVal wFecha As DateTime, _
          ByVal wLiquidacion As Liquidacion, ByVal wAlumno As Persona, ByVal wAdministrativo As Administrativo, _
          ByVal wVoucher As VoucherPago)
    Entidad = wentidad
    Codigo = wCodigoDctoIngreso
    Serie = wserie
    Numero = wnumero
    Vigencia = wVigencia
    Fecha = wFecha
    Persona = wAlumno
    Administrativo = wAdministrativo
    Voucher = wVoucher
    Liquidacion = wLiquidacion
    TipoDocumento = wtipoDoc
  End Sub

  Sub New(ByVal wCodigoDctoIngreso As Integer, ByVal wentidad As String, ByVal wnumero As Integer, _
          ByVal wserie As Integer, ByVal wTipoDoc As String, ByVal wVigencia As Boolean, ByVal wFecha As DateTime, _
          ByVal wLiquidacion As Liquidacion, ByVal wAlumno As Persona, ByVal wAdministrativo As Administrativo, _
          ByVal wVoucher As VoucherPago, ByVal wMontoTotal As Double)
    Entidad = wentidad
    Codigo = wCodigoDctoIngreso
    Serie = wserie
    Numero = wnumero
    Vigencia = wVigencia
    Fecha = wFecha
    Persona = wAlumno
    Administrativo = wAdministrativo
    Voucher = wVoucher
    Liquidacion = wLiquidacion
    TipoDocumento = wTipoDoc
  End Sub

  'Sub New(ByVal wCodigoDctoIngreso As Integer, ByVal wentidad As String, ByVal wnumero As Integer, _
  '     ByVal wserie As Integer, ByVal wTipoDoc As String, ByVal wVigencia As Boolean, ByVal wFecha As DateTime, _
  '     ByVal wLiquidacion As Liquidacion, ByVal wAlumno As Persona, ByVal wAdministrativo As Administrativo, _
  '     ByVal wVoucher As Voucher_Pago, ByVal wMontoTotal As Double) ', ByVal wcuentacontable As String
  '  Entidad = wentidad
  '  codigoDctoIngreso = wCodigoDctoIngreso
  '  serie = wserie
  '  Numero = wnumero
  '  vigencia = wVigencia
  '  Fecha = wFecha
  '  Alumno = wAlumno
  '  Administrativo = wAdministrativo
  '  Voucher = wVoucher
  '  Liquidacion = wLiquidacion
  '  MontoTotal = wMontoTotal
  '  TipoDoc = wTipoDoc
  '  'cuentaContable = wcuentacontable
  'End Sub

#End Region

End Class
