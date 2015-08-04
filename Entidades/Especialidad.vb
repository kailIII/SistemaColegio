Public Class Especialidad

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

  'Public ReadOnly Property Especialidades() As Integer
  '  Get
  '    Return mNombre
  '  End Get
  'End Property

#End Region

#Region "Constructores"
  Public Sub New()

  End Sub
  Public Sub New(ByVal wCodigo As Integer, ByVal wNombre As String)
    mCodigo = wCodigo
    mNombre = wNombre
  End Sub
  Public Sub New(ByVal wNombre As String)
    mNombre = wNombre
  End Sub
#End Region

End Class
