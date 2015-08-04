Public Class DRE

#Region "Datos"
    Private mCodigo As Integer
    Private mDireccion As String
    Private mTelefono As String
    Private mNombreDRE As String
    Private mNombreContacto As String
    Private mCodigoUGEL As String
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
    Public Property Direccion() As String
        Get
            Return mDireccion
        End Get
        Set(ByVal value As String)
            mDireccion = value
        End Set
    End Property
    Public Property Telefono() As String
        Get
            Return mTelefono
        End Get
        Set(ByVal value As String)
            mTelefono = value
        End Set
    End Property
    Public Property NombreDRE() As String
        Get
            Return mNombreDRE
        End Get
        Set(ByVal value As String)
            mNombreDRE = value
        End Set
    End Property
    Public Property NombreContacto() As String
        Get
            Return mNombreContacto
        End Get
        Set(ByVal value As String)
            mNombreContacto = value
        End Set
    End Property
    Public Property CodigoUGEL() As String
        Get
            Return mCodigoUGEL
        End Get
        Set(ByVal value As String)
            mCodigoUGEL = value
        End Set
    End Property
#End Region

#Region "Constructores"
    Public Sub New()

    End Sub
    Public Sub New(ByVal wCodigo As Integer, ByVal wDireccion As String, ByVal wTelefono As String, ByVal wNombreDRE As String, ByVal wNombreContacto As String, ByVal wCodigoUGEL As String)
        Me.Codigo = wCodigo
        Me.Direccion = wDireccion
        Me.Telefono = wTelefono
        Me.NombreDRE = wNombreDRE
        Me.NombreContacto = wNombreContacto
        Me.CodigoUGEL = wCodigoUGEL
    End Sub
#End Region

End Class
