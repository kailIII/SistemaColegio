Public Class DocumentoIngresoSeleccionar

  Private mSeleccionado As Boolean
  Private mDocumentoIngreso As DocumentoIngreso

  Public Property DocumentoIngreso() As DocumentoIngreso
    Get
      Return mDocumentoIngreso
    End Get
    Set(ByVal value As DocumentoIngreso)
      mDocumentoIngreso = value
    End Set
  End Property

  Public Property Seleccionado() As Boolean
    Get
      Return mSeleccionado
    End Get
    Set(ByVal value As Boolean)
      mSeleccionado = value
    End Set
  End Property

  Public ReadOnly Property DocumentoNumero() As String
    Get
      Return Me.mDocumentoIngreso.DocumentoNumero
    End Get
  End Property

  Public ReadOnly Property NombrePersona() As String
    Get
      Return Me.mDocumentoIngreso.NombrePersona
    End Get
  End Property

  Public ReadOnly Property Fecha() As Date
    Get
      Return Me.mDocumentoIngreso.Fecha
    End Get
  End Property

  Public ReadOnly Property Total() As Double
    Get
      Return Me.mDocumentoIngreso.Total
    End Get
  End Property

  Public ReadOnly Property DescripcionVigencia() As String
    Get
      Return Me.mDocumentoIngreso.DescripcionVigencia
    End Get
  End Property

End Class
