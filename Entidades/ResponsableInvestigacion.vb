Public Class ResponsableInvestigacion

#Region "Datos"
    Private mCodigo As Integer
    Private mDocente As Docente
    Private mAreaInv As AreaInvestigacion
    Private mSeccion As Seccion
  Private mVigencia As Boolean
  Private mSeccionNivel As String
  Private mNombreNivel As String
  Private mNombreCompleto As String
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

  Public Property nombreCompleto() As String
    Get
      Return mNombreCompleto
    End Get
    Set(ByVal value As String)
      mNombreCompleto = value
    End Set
  End Property
    Public Property Docente() As Docente
        Get
            Return mDocente
        End Get
        Set(ByVal value As Docente)
            mDocente = value
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

    Public Property AreaInvestigacion() As AreaInvestigacion
        Get
            Return mAreaInv
        End Get
        Set(ByVal value As AreaInvestigacion)
            mAreaInv = value
        End Set
    End Property

    Public Property Seccion() As Seccion
        Get
            Return mSeccion
        End Get
        Set(ByVal value As Seccion)
            mSeccion = value
        End Set
    End Property

    Public Property SeccionNivel() As String
        Get
            Return mSeccionNivel
        End Get
        Set(ByVal value As String)
            mSeccionNivel = value
        End Set
    End Property

    Public ReadOnly Property DocenteNivel() As String
        Get
            Return Me.Docente.NombreCompleto
        End Get
    End Property

    Public ReadOnly Property AreaNivel() As String
        Get
            Return Me.AreaInvestigacion.Nombre
        End Get
  End Property

  Public Property NombreNivel() As String
    Get
      Return mNombreNivel
    End Get
    Set(ByVal value As String)
      mNombreNivel = value
    End Set
  End Property
#End Region

#Region "Constructores"
    Sub New()
    End Sub

    Sub New(ByVal mSeccion As Seccion, ByVal mAreaInv As AreaInvestigacion, ByVal mDocente As Docente)
        Me.Seccion = mSeccion
        Me.AreaInvestigacion = mAreaInv
        Me.Docente = mDocente
    End Sub

  Sub New(ByVal mcodigo As Integer, ByVal mNombre As String)
    Me.Codigo = mcodigo
    Me.nombreCompleto = mNombre
  End Sub

  Sub New(ByVal mdocente As Docente, ByVal mseccion As Seccion)
    Me.Docente = mdocente
    Me.Seccion = mseccion
  End Sub

  Sub New(ByVal mcodigo As Integer, ByVal mseccionNivel As String, ByVal codigoG As Integer, ByVal mdocente As Docente, ByVal marea As AreaInvestigacion,
          ByVal mseccion As Seccion, ByVal mnombreNivel As String)
    Me.Docente = mdocente
    Me.Codigo = mcodigo
    Me.AreaInvestigacion = marea
    Me.SeccionNivel = mseccionNivel
    Me.Seccion = mseccion
    Me.NombreNivel = mnombreNivel
  End Sub
#End Region
End Class
