Public Class Local

#Region "Datos"

  Private mOInstitucion As Institucion
  Private mCodigo As String
  Private mNombre As String
  Private mDireccion As String
  Private mTelefono As String
  Private mvigencia As Boolean
  Private mDistrito As String
  Private mProvincia As String
  Private mDepartamento As String
  Private mPais As String
#End Region

#Region "Propiedades"

  Public Property Codigo() As String
    Get
      Return mCodigo
    End Get
    Set(ByVal value As String)
      mCodigo = value
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
  Public Property Provincia() As String
    Get
      Return mProvincia
    End Get
    Set(ByVal value As String)
      mProvincia = value
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
  Public Property Telefono() As String
    Get
      Return mTelefono
    End Get
    Set(ByVal value As String)
      mTelefono = value
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
            Return mvigencia
        End Get
        Set(ByVal value As Boolean)
            mvigencia = value
        End Set
    End Property
  Public Property Institucion() As Institucion
    Get
      Return mOInstitucion
    End Get
    Set(ByVal value As Institucion)
      mOInstitucion = value
    End Set
    End Property

    Public ReadOnly Property ubicacionLocal() As String
        Get
            Return direccion & " " & distrito
        End Get
    End Property
#End Region

#Region "Constructores"
  Public Sub New()

  End Sub
  Sub New(ByVal wCodigo As String)
    Me.Codigo = wCodigo
  End Sub
  Sub New(ByVal wcodigoLocal As String, ByVal wdireccion As String, ByVal wdistrito As String, ByVal wprovincia As String, _
          ByVal wdepartamneto As String, ByVal wnombre As String, ByVal wtelefono As String, ByVal wcodigoInst As Institucion)
    Me.Codigo = wcodigoLocal
    Me.Direccion = wdireccion
    Me.Distrito = wdistrito
    Me.Provincia = wprovincia
    Me.Departamento = wdepartamneto
    Me.Nombre = wnombre
    Me.Telefono = wtelefono
    Me.Institucion = wcodigoInst
  End Sub
  Sub New(ByVal wcodigoLocal As String, ByVal wdireccion As String, ByVal wdistrito As String, ByVal wnombre As String)
    Me.Codigo = wcodigoLocal
    Me.direccion = wdireccion
    Me.distrito = wdistrito
    Me.nombre = wnombre
  End Sub
  Sub New(ByVal wcodigoLocal As String, ByVal wnombre As String)
    Me.Codigo = wcodigoLocal
    Me.Nombre = wnombre
    End Sub

  Sub New(ByVal wcodigo As String, ByVal wcodigoInstitucion As Institucion, ByVal wnombre As String, ByVal wdireccion As String, _
          ByVal wtelefono As String, ByVal wVigencia As Boolean, ByVal wpais As String, ByVal wdepartamneto As String, ByVal wprovincia As String, _
          ByVal wdistrito As String)
    Me.Codigo = wcodigo
    Me.Institucion = wcodigoInstitucion
    Me.Direccion = wdireccion
    Me.Distrito = wdistrito
    Me.Provincia = wprovincia
    Me.Departamento = wdepartamneto
    Me.Nombre = wnombre
    Me.Telefono = wtelefono
    Me.Vigencia = wVigencia
    Me.Pais = wPais
  End Sub
#End Region

End Class
