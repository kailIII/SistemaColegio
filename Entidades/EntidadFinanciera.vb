Public Class EntidadFinanciera

#Region "Datos"

  Private mCodigo As Integer
  Private mNombre As String

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

  Public Property Nombre() As String
    Get
      Return mNombre
    End Get
    Set(ByVal value As String)
      mNombre = value
    End Set
  End Property

#End Region

#Region "Constructores"

  Sub New()

  End Sub
  Sub New(ByVal wcodigoEntidad As Integer, ByVal wNombre As String)
    Me.Codigo = wcodigoEntidad
    Me.Nombre = wNombre
  End Sub
#End Region

End Class
