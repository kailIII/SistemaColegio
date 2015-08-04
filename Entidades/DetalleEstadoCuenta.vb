Public Class DetalleEstadoCuenta

#Region "Datos"
  Private mObligacion As Obligacion
  Private mDetallePago As DetalleDocumentoIngreso
  Private mSaldo As Double
#End Region

#Region "Propiedades"

  Public Property Obligacion() As Obligacion
    Get
      Return mObligacion
    End Get
    Set(ByVal value As Obligacion)
      mObligacion = value
    End Set
  End Property

  Public Property DetallePago() As DetalleDocumentoIngreso
    Get
      Return mDetallePago
    End Get
    Set(ByVal value As DetalleDocumentoIngreso)
      mDetallePago = value
    End Set
  End Property

  Public ReadOnly Property Descripcion() As String
    Get
      If Me.Obligacion IsNot Nothing Then
        Return Me.Obligacion.Descripcion
      ElseIf Me.DetallePago IsNot Nothing Then
        Return Me.DetallePago.Descripcion
      Else
        Return ""
      End If
    End Get
  End Property

  Public ReadOnly Property Vencimiento() As String
    Get
      If Me.Obligacion IsNot Nothing Then
        Return Me.Obligacion.FechaVencimiento.ToShortDateString
      Else
        Return ""
      End If
    End Get
  End Property

  Public ReadOnly Property MontoPagar() As String
    Get
      If Me.Obligacion IsNot Nothing Then
        Return Me.Obligacion.Monto.ToString("0.00")
      Else
        Return ""
      End If
    End Get
  End Property

  Public ReadOnly Property Entidad() As String
    Get
      Dim ent As String = ""

      If Me.DetallePago IsNot Nothing OrElse Me.Obligacion IsNot Nothing Then
        If Me.DetallePago IsNot Nothing Then
          ent = Me.DetallePago.Documento.Entidad
        Else
          ent = Me.Obligacion.Servicio.entidad
        End If
      End If

      Return ent
    End Get
  End Property

  Public ReadOnly Property NombreEntidad() As String
    Get
      Dim ent As String

      If Me.DetallePago IsNot Nothing OrElse Me.Obligacion IsNot Nothing Then
        If Me.DetallePago IsNot Nothing Then
          ent = Me.DetallePago.Documento.Entidad
        Else
          ent = Me.Obligacion.Servicio.entidad
        End If
        Select Case ent
          Case "I"
            Return "COLEGIO"
          Case Else
            Return "COPAFA"
        End Select
      Else
        Return ""
      End If
    End Get
  End Property

  Public ReadOnly Property DocumentoPago() As String
    Get
      If Me.DetallePago IsNot Nothing Then
        With Me.DetallePago.Documento
          Return .TipoDocumento & " " & .Serie.ToString("000") & " - " & .Numero.ToString("000000")
        End With
      Else
        Return ""
      End If
    End Get
  End Property

  Public ReadOnly Property FechaPago() As String
    Get
      If Me.DetallePago IsNot Nothing Then
        Return Me.DetallePago.Documento.Fecha.ToShortDateString
      Else
        Return ""
      End If
    End Get
  End Property

  Public ReadOnly Property MontoPagado() As String
    Get
      If Me.DetallePago IsNot Nothing Then
        Return Me.DetallePago.Monto.ToString("0.00")
      Else
        Return ""
      End If
    End Get
  End Property

  Public Property Saldo() As Double
    Get
      Return mSaldo
    End Get
    Set(ByVal value As Double)
      mSaldo = value
    End Set
  End Property

  Public ReadOnly Property SaldoFormato() As String
    Get
      Return mSaldo.ToString("0.00")
    End Get
  End Property

#End Region

#Region "Constructores"

  Public Sub New()
    Me.Obligacion = Nothing
    Me.DetallePago = Nothing
    Me.Saldo = 0
  End Sub

  Public Sub New(ByVal wObligacion As Obligacion, ByVal wDetallePago As DetalleDocumentoIngreso, ByVal wSaldo As Double)
    Me.Obligacion = wObligacion
    Me.DetallePago = wDetallePago
    Me.Saldo = wSaldo
  End Sub

#End Region

End Class
