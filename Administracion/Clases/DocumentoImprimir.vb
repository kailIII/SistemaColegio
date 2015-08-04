Public Class DocumentoImprimir

  Private mDocumento As DocumentoIngreso
  Private mRegistrado As Boolean
  Private mImprimir As Boolean

  Public Property Imprimir() As Boolean
    Get
      Return mImprimir
    End Get
    Set(ByVal value As Boolean)
      mImprimir = value
    End Set
  End Property

  Public Property Registrado() As Boolean
    Get
      Return mRegistrado
    End Get
    Set(ByVal value As Boolean)
      mRegistrado = value
    End Set
  End Property

  Public Property Documento() As DocumentoIngreso
    Get
      Return mDocumento
    End Get
    Set(ByVal value As DocumentoIngreso)
      mDocumento = value
    End Set
  End Property

  Public Sub New()
    Me.mDocumento = Nothing
    Me.Registrado = False
    Me.Imprimir = True
  End Sub

  Public ReadOnly Property NombrePersona() As String
    Get
      Return Me.Documento.Persona.NombreCompleto
    End Get
  End Property

  Public ReadOnly Property NumeroRecibo() As String
    Get
      Return Me.Documento.Serie.ToString("000") & "-" & Me.Documento.Numero.ToString("000000")
    End Get
  End Property

  Public ReadOnly Property NumeroVoucher() As String
    Get
      Return Me.Documento.Voucher.NumOperacion
    End Get
  End Property

  Public ReadOnly Property FechaVoucher() As Date
    Get
      Return Me.Documento.Voucher.Fecha
    End Get
  End Property

  Public ReadOnly Property Total() As Double
    Get
      Return Me.Documento.Total
    End Get
  End Property

End Class
