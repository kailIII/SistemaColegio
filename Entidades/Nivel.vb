Public Class Nivel

#Region "Datos"
  Private mcodigo As Integer
  Private mNombre As String
  Private mSiglas As String
  Private mCodigoModular As String
  Private mOInstitucion As Institucion
  Private mOrden As Integer

  Private mOAreas As List(Of AreaDRE)
#End Region

#Region "Propiedades"

  Public Property CodigoModular() As String
    Get
      Return mCodigoModular
    End Get
    Set(ByVal value As String)
      mCodigoModular = value
    End Set
  End Property

  Public Property Codigo() As Integer
    Get
      Return mcodigo
    End Get
    Set(ByVal value As Integer)
      mcodigo = value
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

  Public Property Siglas() As String
    Get
      Return mSiglas.Trim
    End Get
    Set(ByVal value As String)
      mSiglas = value
    End Set
  End Property

  Public Property Institucion() As Institucion
    Get
      Return Me.mOInstitucion
    End Get
    Set(ByVal value As Institucion)
      Me.mOInstitucion = value
    End Set
  End Property

  Public Property Areas() As List(Of AreaDRE)
    Get
      Return Me.mOAreas
    End Get
    Set(ByVal value As List(Of AreaDRE))
      Me.mOAreas = value
    End Set
  End Property

  Public Property Orden() As Integer
    Get
      Return mOrden
    End Get
    Set(ByVal value As Integer)
      mOrden = value
    End Set
  End Property

  Public ReadOnly Property CodigoInstitucion() As Integer
    Get
      Return mOInstitucion.CodigoInst
    End Get
  End Property

#End Region

#Region "Constructores"

  Public Sub New()
  End Sub

  Public Sub New(ByVal wCodigo As Integer)
    Me.Codigo = wCodigo
  End Sub

  Public Sub New(ByVal wCodigo As Integer, ByVal wNombre As String, ByVal wSiglas As String)
    Me.Codigo = wCodigo
    Me.Nombre = wNombre
    Me.Siglas = wSiglas
  End Sub

  Public Sub New(ByVal wCodigo As Integer, ByVal wNombre As String, ByVal wSiglas As String, ByVal wcodigoModular As String)
    Me.Codigo = wCodigo
    Me.Nombre = wNombre
    Me.Siglas = wSiglas
    Me.CodigoModular = wcodigoModular
  End Sub

  Public Sub New(ByVal wCodigo As Integer, ByVal wNombre As String, ByVal wInstitucion As Institucion, ByVal wcodigoModular As String)
    Me.Codigo = wCodigo
    Me.Nombre = wNombre
    Me.CodigoModular = wcodigoModular

    Me.Institucion = wInstitucion
  End Sub

  Public Sub New(ByVal wNombreInstitucion As String, ByVal wGestion As String, ByVal wCodigo As Integer, ByVal wNombreNivel As String, _
                 ByVal wcodigoModular As String)
    Me.Codigo = wCodigo
    Me.Nombre = wNombreNivel
    Me.mOInstitucion = New Institucion(Nothing, wNombreInstitucion, CChar(wGestion), "")
    Me.CodigoModular = wcodigoModular
  End Sub

#End Region

End Class
