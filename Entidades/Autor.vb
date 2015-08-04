Public Class Autor
#Region "Datos"
    Private mcodigo As Integer
    Private mNombres As String
    Private mApellidos As String

#End Region
#Region "Propiedades"
    Public Property Codigo() As Integer
        Get
            Return mcodigo
        End Get
        Set(ByVal value As Integer)
            mcodigo = value
        End Set
    End Property

    Public Property Nombres() As String
        Get
            Return mNombres
        End Get
        Set(ByVal value As String)
            mNombres = value
        End Set
    End Property
    Public Property Apellidos() As String
        Get
            Return mApellidos
        End Get
        Set(ByVal value As String)
            mApellidos = value
        End Set
    End Property
    Public ReadOnly Property NombreCompleto() As String
        Get
            Return mNombres + " " + mApellidos
        End Get
    End Property
#End Region

#Region "Connstructores"
    Sub New()
    End Sub

    Sub New(ByVal wCodigo As Integer, ByVal wNombres As String, ByVal wApellidos As String)
        Me.Codigo = wCodigo
        Me.Nombres = wNombres
        Me.Apellidos = wApellidos
    End Sub

#End Region
End Class
