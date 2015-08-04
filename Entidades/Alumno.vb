Public Class Alumno
  Inherits Persona

#Region "Datos"
  Private mOPadre As Apoderado
  Private mOMadre As Apoderado
  Private mCodEducando As String
  Private mODireccionActual As UbicacionGeografica
  Private mDNI As String
  Private mEmail As String
  Private mDireccion As String
  Private mTelefono As String
  Private mNacionalidad As String
  Private mGrupoSanguineo As String
  Private mLenguaMaterna As String
  Private mMedicinasContraindicadas As String
  Private mColegioProcedencia As String
  Private mOLugarNacimiento As UbicacionGeografica
  Private mCodigoRecaudacion As String
#End Region

#Region "Propiedades"

  Public Overrides Property Codigo() As Integer
    Get
      Return MyBase.Codigo
    End Get
    Set(ByVal value As Integer)
      mCodigo = value
    End Set
  End Property

  Public Property Padre() As Apoderado
    Get
      Return mOPadre
    End Get
    Set(ByVal value As Apoderado)
      mOPadre = value
    End Set
  End Property

  Public Property Madre() As Apoderado
    Get
      Return mOMadre
    End Get
    Set(ByVal value As Apoderado)
      mOMadre = value
    End Set
  End Property

  Public Property CodigoEducando() As String
    Get
      Return mCodEducando
    End Get
    Set(ByVal value As String)
      mCodEducando = value
    End Set
  End Property

  Public Property DireccionActual() As UbicacionGeografica
    Get
      Return mODireccionActual
    End Get
    Set(ByVal value As UbicacionGeografica)
      mODireccionActual = value
    End Set
  End Property

  Public Property LugarNacimiento() As UbicacionGeografica
    Get
      Return mOLugarNacimiento
    End Get
    Set(ByVal value As UbicacionGeografica)
      mOLugarNacimiento = value
    End Set
  End Property

  Public Property Email() As String
    Get
      Return mEmail
    End Get
    Set(ByVal value As String)
      mEmail = value
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

  Public Property Nacionalidad() As String
    Get
      Return mNacionalidad
    End Get
    Set(ByVal value As String)
      mNacionalidad = value
    End Set
  End Property

  Public Property GrupoSanguineo() As String
    Get
      Return mGrupoSanguineo
    End Get
    Set(ByVal value As String)
      mGrupoSanguineo = value
    End Set
  End Property

  Public Property LenguaMaterna() As String
    Get
      Return mLenguaMaterna
    End Get
    Set(ByVal value As String)
      mLenguaMaterna = value
    End Set
  End Property

  Public Property MedicinasContraindicadas() As String
    Get
      Return mMedicinasContraindicadas
    End Get
    Set(ByVal value As String)
      mMedicinasContraindicadas = value
    End Set
  End Property

  Public Property ColegioProcedencia() As String
    Get
      Return mColegioProcedencia
    End Get
    Set(ByVal value As String)
      mColegioProcedencia = value
    End Set
  End Property

  Public Property CodigoRecaudacion() As String
    Get
      Return mCodigoRecaudacion
    End Get
    Set(ByVal value As String)
      mCodigoRecaudacion = value
    End Set
  End Property

  Public Property DNI() As String
    Get
      Return mDNI
    End Get
    Set(ByVal value As String)
      mDNI = value
    End Set
  End Property

#End Region

#Region "Constructores"

  Public Sub New()
  End Sub

  Public Sub New(ByVal _cod As Integer)
    MyBase.New(_cod)
  End Sub

  Public Sub New(ByVal wCodigo As Integer, ByVal wNombre As String, ByVal wApellidoPat As String, _
                 ByVal wApellidoMat As String)
    MyBase.New(wCodigo, wNombre, wApellidoPat, wApellidoMat)
  End Sub

  Public Sub New(ByVal wnombre As String, ByVal wapeP As String, ByVal wapeM As String, ByVal wsexo As String, _
            ByVal wfechanac As Date, ByVal wcodEducando As String, ByVal wlugarNac As UbicacionGeografica, _
            ByVal wemail As String, ByVal wdireccion As String, ByVal wtelefono As String, _
            ByVal wnacionalidad As String, ByVal wgruposang As String, ByVal wlenguamat As String, _
            ByVal wmedcontra As String, ByVal wcolegproc As String, ByVal wdiractual As UbicacionGeografica)
    MyBase.New(wnombre, wapeP, wapeM, wsexo, wfechanac)
    Me.CodigoEducando = wcodEducando
    Me.DireccionActual = wdiractual
    Me.Email = wemail
    Me.Direccion = wdireccion
    Me.Telefono = wtelefono
    Me.Nacionalidad = wnacionalidad
    Me.GrupoSanguineo = wgruposang
    Me.LenguaMaterna = wlenguamat
    Me.MedicinasContraindicadas = wmedcontra
    Me.ColegioProcedencia = wcolegproc
    Me.LugarNacimiento = wlugarNac
  End Sub

  Public Sub New(ByVal wcodigo As Integer, ByVal wnombre As String, ByVal wapeP As String, ByVal wapeM As String, ByVal wsexo As String, _
          ByVal wfechanac As Date, ByVal wcodEducando As String, ByVal wlugarNac As UbicacionGeografica, _
          ByVal wemail As String, ByVal wdireccion As String, ByVal wtelefono As String, _
          ByVal wnacionalidad As String, ByVal wgruposang As String, ByVal wlenguamat As String, _
          ByVal wmedcontra As String, ByVal wcolegproc As String, ByVal wdiractual As UbicacionGeografica)
    MyBase.New(wcodigo, wnombre, wapeP, wapeM, wsexo, wfechanac)
    Me.CodigoEducando = wcodEducando
    Me.DireccionActual = wdiractual
    Me.Email = wemail
    Me.Direccion = wdireccion
    Me.Telefono = wtelefono
    Me.Nacionalidad = wnacionalidad
    Me.GrupoSanguineo = wgruposang
    Me.LenguaMaterna = wlenguamat
    Me.MedicinasContraindicadas = wmedcontra
    Me.ColegioProcedencia = wcolegproc
    Me.LugarNacimiento = wlugarNac
  End Sub

  Public Sub New(ByVal wcodigo As Integer, ByVal wnombre As String, ByVal wapeP As String, ByVal wapeM As String, _
            ByVal wsexo As String, ByVal wfechanac As Date, ByVal wcodEducando As String, ByVal wdiractual As UbicacionGeografica)
    MyBase.New(wcodigo, wnombre, wapeP, wapeM, wsexo, wfechanac)

    Me.CodigoEducando = wcodEducando
    Me.DireccionActual = wdiractual
  End Sub

  Public Sub New(ByVal wUbicacion As UbicacionGeografica, ByVal wCodigo As Integer, ByVal wCodigoEducando As String, _
        ByVal wNombre As String, ByVal wApellidoPat As String, ByVal wApellidoMat As String, ByVal wFechaNac As Date, _
        ByVal wSexo As String, ByVal wLenguaMaterna As String, ByVal wPadre As Apoderado, ByVal wMadre As Apoderado)
    Me.LugarNacimiento = wUbicacion
    Me.CodigoEducando = wCodigoEducando
    Me.Nombre = wNombre
    Me.ApellidoPaterno = wApellidoPat
    Me.ApellidoMaterno = wApellidoMat
    Me.FechaNacimiento = wFechaNac
    Me.Sexo = wSexo
    Me.Codigo = wCodigo
    Me.LenguaMaterna = wLenguaMaterna
    Me.Padre = wPadre
    Me.Madre = wMadre
  End Sub

  Public Sub New(ByVal wnombre As String, ByVal wapeP As String, ByVal wapeM As String, _
          ByVal wsexo As String, ByVal wfechanac As Date)
    MyBase.New(wnombre, wapeP, wapeM, wsexo, wfechanac)
  End Sub

  Public Sub New(ByVal _cod As Integer, ByVal wNombre As String, ByVal wApellidoPat As String, _
               ByVal wApellidoMat As String, ByVal wSexo As String, ByVal wFechaNac As String, _
               ByVal wcodigoEducando As String)
    MyBase.New(_cod, wNombre, wApellidoPat, wApellidoMat, wSexo, CType(wFechaNac, Date))
    Me.CodigoEducando = wcodigoEducando
  End Sub

  Public Sub New(ByVal _cod As Integer, ByVal wNombre As String, ByVal wApellidoPat As String, _
                 ByVal wApellidoMat As String, ByVal wcodigoEducando As String)
    MyBase.New(_cod, wNombre, wApellidoPat, wApellidoMat)
    Me.CodigoEducando = wcodigoEducando
  End Sub

  Public Sub New(ByVal _cod As Integer, ByVal wNombre As String, ByVal wApellidoPat As String, _
                 ByVal wApellidoMat As String, ByVal wcodigoEducando As String, ByVal wcodigoRecaudacion As String)
    MyBase.New(_cod, wNombre, wApellidoPat, wApellidoMat)
    Me.CodigoEducando = wcodigoEducando
    Me.CodigoRecaudacion = wcodigoRecaudacion
  End Sub

#End Region

End Class
