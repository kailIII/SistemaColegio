Public Class Institucion

#Region "Datos"
    Private mCodigo As Integer
    Private mNombre As String
    Private mGestion As Char
    Private mResolucion As String
#End Region

#Region "Propiedades"
    Public Property Gestion() As Char
        Get
            Return mGestion
        End Get
        Set(ByVal value As Char)
            mGestion = value
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
    Public Property CodigoInst() As Integer
        Get
            Return mCodigo
        End Get
        Set(ByVal value As Integer)
            mCodigo = value
        End Set
    End Property
    Public Property Resolucion() As String
        Get
            Return mResolucion
        End Get
        Set(ByVal value As String)
            mResolucion = value
        End Set
    End Property

#End Region

#Region "Constructores"
    Public Sub New()

    End Sub
    Sub New(ByVal wcodigoInst As Integer)
        Me.CodigoInst = wcodigoInst
    End Sub
    Sub New(ByVal wCodigoInst As Integer, ByVal wNombreInst As String, ByVal wGestion As Char, ByVal wResolucion As String)
        Me.CodigoInst = wCodigoInst
        Me.Nombre = wNombreInst
        Me.Gestion = wGestion
        Me.Resolucion = wResolucion
    End Sub
#End Region

End Class
