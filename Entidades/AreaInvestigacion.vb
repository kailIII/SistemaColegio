Public Class AreaInvestigacion

#Region "Datos"
    Private mCodigo As Integer
    Private mNombre As String
    Private mGrado As Grado
    Private mPeriodo As PeriodoAcademico
    Private mVigencia As Boolean
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

    Public Property Periodo() As PeriodoAcademico
        Get
            Return mPeriodo
        End Get
        Set(ByVal value As PeriodoAcademico)
            mPeriodo = value
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

    Public Property Vigencia() As Boolean
        Get
            Return mVigencia
        End Get
        Set(ByVal value As Boolean)
            mVigencia = value
        End Set
    End Property

    Public Property Grado() As Grado
        Get
            Return mGrado
        End Get
        Set(ByVal value As Grado)
            mGrado = value
        End Set
    End Property

#End Region

#Region "Constructores"
    Sub New()
    End Sub

    Sub New(ByVal mcodigo As Integer, ByVal mnombre As String)
        Me.Codigo = mcodigo
        Me.Nombre = mnombre
    End Sub

    Sub New(ByVal mcodigo As Integer, ByVal mnombre As String,
            ByVal mgrado As Grado, ByVal mperiodo As PeriodoAcademico)
        Me.Codigo = mcodigo
        Me.Nombre = mnombre
        Me.Grado = mgrado
        Me.Periodo = mperiodo
    End Sub
#End Region
End Class
