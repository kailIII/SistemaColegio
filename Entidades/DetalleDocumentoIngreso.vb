Public Class DetalleDocumentoIngreso

#Region "Datos"
  Private mODocumento As DocumentoIngreso
  Private mNumero As Integer
  Private mMonto As Double
  Private mDescripcion As String
  Private mOServicio As Servicio
  Private mOObligacion As Obligacion
  'Private mDescuento As Double
  'Private mMontoDebe As Double
  Private mItem As Integer
#End Region

#Region "Propiedades"

  Public Property Documento() As DocumentoIngreso
    Get
      Return Me.mODocumento
    End Get
    Set(ByVal value As DocumentoIngreso)
      Me.mODocumento = value
    End Set
  End Property

  Public ReadOnly Property CodigoDocumentoIngreso() As Integer
    Get
      If Me.Documento IsNot Nothing Then
        Return Me.Documento.Codigo
      Else
        Return 0
      End If
    End Get
  End Property

  Public Property Numero() As Integer
    Get
      Return mNumero
    End Get
    Set(ByVal value As Integer)
      mNumero = value
    End Set
  End Property

  Public Property Item() As Integer
    Get
      Return mItem
    End Get
    Set(ByVal value As Integer)
      mItem = value
    End Set
  End Property

  Public Property Descripcion() As String
    Get
      Return mDescripcion
    End Get
    Set(ByVal value As String)
      mDescripcion = value.ToUpper
    End Set
  End Property

  Public Property Monto() As Double
    Get
      If Me.Documento Is Nothing OrElse Me.Documento.Vigencia = True Then
        Return mMonto
      Else
        Return 0
      End If
    End Get
    Set(ByVal value As Double)
      mMonto = value
    End Set
  End Property

  Public Property Servicio() As Servicio
    Get
      Return mOServicio
    End Get
    Set(ByVal value As Servicio)
      mOServicio = value
    End Set
  End Property

  Public Property Obligacion() As Obligacion
    Get
      Return mOObligacion
    End Get
    Set(ByVal value As Obligacion)
      mOObligacion = value
    End Set
  End Property

  Public Property MostrarDescripcion() As String
    Get
      Return Descripcion.ToUpper
    End Get
    Set(ByVal value As String)
      Descripcion = value.ToUpper
    End Set
  End Property

  Public ReadOnly Property codigoObligacion() As Integer
    Get
      If Me.Obligacion IsNot Nothing Then
        Return Me.Obligacion.Codigo
      Else
        Return 0
      End If
    End Get
  End Property

  Public ReadOnly Property codigoServicio() As Integer
    Get
      If Me.Servicio IsNot Nothing Then
        Return Me.Servicio.Codigo
      Else
        Return 0
      End If
    End Get
  End Property

  Public Property MostrarFechaVencimiento() As DateTime
    Get
      If Me.Obligacion IsNot Nothing Then
        Return Me.Obligacion.FechaVencimiento
      Else
        Return DateAndTime.Now
      End If
    End Get
    Set(ByVal value As DateTime)
      Obligacion.FechaVencimiento = value
    End Set
  End Property

  Public ReadOnly Property MontoObligacion() As Double
    Get
      If Me.Servicio IsNot Nothing AndAlso Me.Obligacion IsNot Nothing Then
        If Me.Servicio.Codigo = 0 Then
          Return Me.Obligacion.Monto
        ElseIf Me.Obligacion.Codigo = 0 Then
          Return Me.Servicio.Monto
        End If
      Else
        Return 0
      End If
    End Get
  End Property

  Public ReadOnly Property CodigoRecaudacionAlumno() As String
    Get
      Dim cod As String

      If TypeOf Me.Documento.Persona Is Alumno Then
        cod = DirectCast(Me.Documento.Persona, Alumno).CodigoRecaudacion
      Else
        cod = ""
      End If

      Return cod
    End Get
  End Property

  Public ReadOnly Property NumeroCuentaContable() As String
    Get
      If Me.Servicio IsNot Nothing AndAlso Me.Servicio.CuentaContable IsNot Nothing Then
        Return Me.Servicio.CuentaContable.Codigo
      Else
        Return ""
      End If
    End Get
  End Property

  Public ReadOnly Property DescripcionFormaPago() As String
    Get
      Dim fp As String = ""

      Select Case Me.Documento.FormaPago
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

  Public ReadOnly Property FormaPago() As String
    Get
      Dim fp As String = ""

      If Me.Documento IsNot Nothing Then
        fp = Me.Documento.FormaPago
      End If

      Return fp
    End Get
  End Property

  Public ReadOnly Property NombrePersona() As String
    Get
      If Me.Documento.Vigencia = True Then
        Return Me.Documento.Persona.NombreCompleto
      Else
        Return "***** ANULADO *****"
      End If
    End Get
  End Property

  Public ReadOnly Property DocumentoNumero() As String
    Get
      Dim td As String = ""
      Select Case Me.Documento.TipoDocumento
        Case "B" : td = "BOL"
        Case "R" : td = "REC"
        Case "F" : td = "FAC"
      End Select
      Return td & " " & Me.Documento.Serie.ToString("000") & "-" & Me.Documento.Numero.ToString("000000")
    End Get
  End Property

  Public ReadOnly Property DescripcionVigencia() As String
    Get
      If Me.Documento.Vigencia = True Then
        Return "VIGENTE"
      Else
        Return "ANULADO"
      End If
    End Get
  End Property

  Public ReadOnly Property NumeroCuentaBancaria() As String
    Get
      Dim cta As String = ""

      If Me.Documento.Voucher IsNot Nothing Then
        cta = Me.Documento.Voucher.CuentaBancaria.Numero
      End If

      Return cta
    End Get
  End Property

#End Region

#Region "Constructores"
  Sub New()

  End Sub
  Sub New(ByVal wCodigoDctoIngreso As Integer, ByVal wNumero As Integer, ByVal wDescripcion As String, ByVal wMonto As Double, ByVal wServicio As Servicio, ByVal wObligacion As Obligacion)
    Numero = wNumero
    Me.Documento = New DocumentoIngreso() With {.Codigo = wCodigoDctoIngreso}
    Descripcion = wDescripcion
    Monto = wMonto
    Servicio = wServicio
    Obligacion = wObligacion
  End Sub

  'Sub New(ByVal wItem As Integer, ByVal wNumero As Integer, ByVal wDescripcion As String, ByVal wMonto As Double, ByVal wDescuento As Double, ByVal wPagar As Double, ByVal wServicio As Servicio, ByVal wObligacion As Obligacion)
  '  Numero = wNumero
  '  Item = wItem
  '  Descripcion = wDescripcion
  '  Monto = wMonto
  '  Descuento = wDescuento
  '  MontoDebe = wPagar
  '  Servicio = wServicio
  '  Obligacion = wObligacion
  'End Sub

  Sub New(ByVal wObligacion As Obligacion, ByRef wNroMeses As Integer, ByVal wVencido As Double)
    Obligacion = wObligacion
    Item = wNroMeses
    Monto = wVencido
  End Sub

#End Region

End Class
