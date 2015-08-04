Public Class Servicio

#Region "Datos"
  Private mCodigo As Integer
  Private mNombre As String
  Private mDescripcion As String
  Private mMonto As Double
  Private mentidad As String
  Private mVigencia As Boolean
  Private mOTipoServicio As TipoServicio
  Private mOCuentaContable As CuentaContable
  Private mONivelAcademico As Nivel
  Private mCaduca As Boolean
  Private mPagoBanco As Boolean
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

  Public Property Descripcion() As String
    Get
      Return mDescripcion
    End Get
    Set(ByVal value As String)
      mDescripcion = value
    End Set
  End Property

  Public Property Monto() As Double
    Get
      Return mMonto
    End Get
    Set(ByVal value As Double)
      mMonto = value
    End Set
  End Property

  Public Property entidad() As String
    Get
      Return mentidad
    End Get
    Set(ByVal value As String)
      mentidad = value
    End Set
  End Property

  Public Property vigencia() As Boolean
    Get
      Return mVigencia
    End Get
    Set(ByVal value As Boolean)
      mVigencia = value
    End Set
  End Property

  Public Property TipoServicio() As TipoServicio
    Get
      Return mOTipoServicio
    End Get
    Set(ByVal value As TipoServicio)
      mOTipoServicio = value
    End Set
  End Property

  Public Property CuentaContable() As CuentaContable
    Get
      Return mOCuentaContable
    End Get
    Set(ByVal value As CuentaContable)
      mOCuentaContable = value
    End Set
  End Property

  Public Property NivelAcademico() As Nivel
    Get
      Return mONivelAcademico
    End Get
    Set(ByVal value As Nivel)
      mONivelAcademico = value
    End Set
  End Property

  Public ReadOnly Property LeerVigencia() As String
    Get
      If vigencia = True Then
        Return "Activo"
      Else
        Return "No Activo"
      End If
    End Get
  End Property

  Public ReadOnly Property MostrarEntidad() As String
    Get
      If entidad = "I" Then
        Return "INSTITUCION"
      Else
        Return "COPAFA"
      End If
    End Get
  End Property

  Public ReadOnly Property NombreNivel() As String
    Get
      If Me.NivelAcademico IsNot Nothing Then
        Return Me.NivelAcademico.Nombre
      Else
        Return ""
      End If
    End Get
  End Property

  Public ReadOnly Property NombreConNivel() As String
    Get
      If Me.NivelAcademico IsNot Nothing Then
        Return Me.Nombre & " - " & Me.NivelAcademico.Nombre
      Else
        Return Me.Nombre
      End If
    End Get
  End Property

  Public ReadOnly Property CodigoCuenta() As String
    Get
      Return Me.CuentaContable.Codigo
    End Get
  End Property

  Public Property PagoBanco() As Boolean
    Get
      Return mPagoBanco
    End Get
    Set(ByVal value As Boolean)
      mPagoBanco = value
    End Set
  End Property

  Public Property Caduca() As Boolean
    Get
      Return mCaduca
    End Get
    Set(ByVal value As Boolean)
      mCaduca = value
    End Set
  End Property

#End Region

#Region "Constructores"

  Public Sub New()

  End Sub

  Public Sub New(ByVal wcodigo As Integer, ByVal wnombre As String, ByVal wmonto As Double, ByVal wentidad As String, ByVal wdescripcion As String, ByVal wvigencia As Boolean, ByVal wtipoServicio As TipoServicio, ByVal wctaContable As CuentaContable, ByVal wNivelAcad As Nivel)
    Me.Codigo = wcodigo
    Me.Nombre = wnombre
    Me.Monto = wmonto
    Me.entidad = wentidad
    Me.Descripcion = wdescripcion
    Me.vigencia = wvigencia
    Me.TipoServicio = wtipoServicio
    Me.CuentaContable = wctaContable
    Me.NivelAcademico = wNivelAcad
  End Sub

  Public Sub New(ByVal wnombre As String, ByVal wentidad As String, ByVal wvigencia As Boolean)
    Me.Nombre = wnombre
    Me.entidad = wentidad
    Me.vigencia = wvigencia
  End Sub

  Public Sub New(ByVal wcodigo As Integer)
    Me.Codigo = wcodigo
  End Sub

#End Region

End Class
