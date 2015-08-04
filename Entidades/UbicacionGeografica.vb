Public Class UbicacionGeografica
#Region "Datos"

    Private mCodigoUbG As Integer
    Private mDistrito As String
    Private mProvincia As String
    Private mDepartamento As String
    Private mPais As String
#End Region
#Region "Propiedades"
    Public Property CodigoUbGeog() As Integer
        Get
            Return mCodigoUbG
        End Get
        Set(ByVal value As Integer)
            mCodigoUbG = value
        End Set
    End Property
    Public Property Distrito() As String
        Get
            Return mDistrito
        End Get
        Set(ByVal value As String)
            mDistrito = value
        End Set
    End Property
    Public Property Provincia() As String
        Get
            Return mProvincia
        End Get
        Set(ByVal value As String)
            mProvincia = value
        End Set
    End Property
    Public Property Departamento() As String
        Get
            Return mDepartamento
        End Get
        Set(ByVal value As String)
            mDepartamento = value
        End Set
    End Property
    Public Property Pais() As String
        Get
            Return mPais
        End Get
        Set(ByVal value As String)
            mPais = value
        End Set
    End Property
#End Region
#Region "Constructores"
    Sub New()
    End Sub
    Sub New(ByVal _cod As Integer)
        mCodigoUbG = _cod
    End Sub

    Sub New(ByVal wcodUbG As Integer, ByVal wdistrito As String, ByVal wpvcia As String, ByVal wdpto As String, ByVal wpais As String)
        Me.CodigoUbGeog = wcodUbG
        Me.Distrito = wdistrito
        Me.Provincia = wpvcia
        Me.Departamento = wdpto
        Me.Pais = wpais
    End Sub
    Sub New(ByVal wdistrito As String, ByVal wpvcia As String, ByVal wdpto As String, ByVal wpais As String)
        Me.Distrito = wdistrito
        Me.Provincia = wpvcia
        Me.Departamento = wdpto
        Me.Pais = wpais
    End Sub
#End Region
End Class
