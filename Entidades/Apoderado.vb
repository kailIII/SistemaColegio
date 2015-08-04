Public Class Apoderado
  Inherits Persona

#Region "Datos"
  Private mTipoDoc As String
  Private mNroDoc As String
  Private mGradoInst As String
  Private mOcupacion As String
  Private mDireccion As String
  Private mTelefonoCasa As String
  Private mTelefonoTrab As String
  Private mEmail As String
  Private mCelular As String
  Private mVive As Boolean
  Private mLugarTrabajo As String
  Private mEstadoCivil As String
  Private mOProfesion As Profesion
  Private mOOcupacion As Ocupacion
  Private mODireccionActual As UbicacionGeografica
  Private mVariable As String
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

  Public Property EstadoCivil() As String
    Get
      Return mEstadoCivil
    End Get
    Set(ByVal value As String)
      mEstadoCivil = value
    End Set
  End Property

  Public Property TipoDoc() As String
    Get
      Return mTipoDoc
    End Get
    Set(ByVal value As String)
      mTipoDoc = value
    End Set
  End Property

  Public Property LugarTrabajo() As String
    Get
      Return mLugarTrabajo
    End Get
    Set(ByVal value As String)
      mLugarTrabajo = value
    End Set
  End Property

  Public Property NroDoc() As String
    Get
      Return mNroDoc
    End Get
    Set(ByVal value As String)
      mNroDoc = value
    End Set
  End Property

  Public Property GradoInstruccion() As String
    Get
      Return mGradoInst
    End Get
    Set(ByVal value As String)
      mGradoInst = value
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

  Public Property TelefonoCasa() As String
    Get
      Return mTelefonoCasa
    End Get
    Set(ByVal value As String)
      mTelefonoCasa = value
    End Set
  End Property

  Public Property TelefonoTrabajo() As String
    Get
      Return mTelefonoTrab
    End Get
    Set(ByVal value As String)
      mTelefonoTrab = value
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

  Public Property Celular() As String
    Get
      Return mCelular
    End Get
    Set(ByVal value As String)
      mCelular = value
    End Set
  End Property

  Public Property Vive() As Boolean
    Get
      Return mVive
    End Get
    Set(ByVal value As Boolean)
      mVive = value
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

  Public Property Profesion() As Profesion
    Get
      Return mOProfesion
    End Get
    Set(ByVal value As Profesion)
      mOProfesion = value
    End Set
  End Property

  Public Property Ocupacion() As Ocupacion
    Get
      Return mOOcupacion
    End Get
    Set(ByVal value As Ocupacion)
      mOOcupacion = value
    End Set
  End Property

  Public Property Variable() As String
    Get
      Dim cad As String = ""
      If mVariable <> "" Then
        cad = mVariable
      End If
      Return cad
    End Get
    Set(ByVal value As String)
      mVariable = value
    End Set
  End Property

  Public ReadOnly Property NombreOcupacion() As String
    Get
      Return Me.Ocupacion.Nombre
    End Get
  End Property

  Public ReadOnly Property NombreProfesion() As String
    Get
      Return Me.Profesion.Nombre
    End Get
  End Property

  Public ReadOnly Property DescripcionDocumento() As String
    Get
      Dim doc As String = ""
      Select Case Me.TipoDoc
        Case "DN"
          doc = "DNI"
        Case "CE"
          doc = "Carnet de Extranjería"
        Case "CP"
          doc = "Carnet Policial"
        Case "PA"
          doc = "Pasaporte"
        Case Else
          doc = Me.TipoDoc
      End Select
      Return doc
    End Get
  End Property

#End Region

#Region "Constructores"

  Public Sub New()
  End Sub

  Public Sub New(ByVal wcodigo As Integer)
    MyBase.New(wcodigo)
  End Sub

  Public Sub New(ByVal wCodigo As Integer, ByVal wApellidoPat As String, _
                 ByVal wApellidoMat As String, ByVal wNombre As String)
    MyBase.New(wCodigo, wNombre, wApellidoPat, wApellidoMat)
  End Sub

  Public Sub New(ByVal wnombre As String, ByVal wApellidoPat As String, ByVal wApellidoMat As String, _
                 ByVal wsexo As String, ByVal wfechaNac As Date)

    MyBase.New(wnombre, wApellidoPat, wApellidoMat, wsexo, wfechaNac)
  End Sub

  Public Sub New(ByVal wNombre As String, ByVal wApellidoPat As String, ByVal wApellidoMat As String, _
         ByVal wsexo As String, ByVal wfechanac As Date, ByVal wtipoDoc As String, ByVal wnroDoc As String, ByVal westadoCivil As String, _
         ByVal wgradoinst As String, ByVal wdireccion As String, ByVal wtelefcasa As String, ByVal wteleftrab As String, _
         ByVal wlugartrabajo As String, ByVal wemail As String, ByVal wcelular As String, ByVal wvive As Boolean, ByVal wocupacion As Ocupacion, _
         ByVal wprofesion As Profesion, ByVal wdiractual As UbicacionGeografica)

    MyBase.New(wNombre, wApellidoPat, wApellidoMat, wsexo, wfechanac)
    Me.TipoDoc = wtipoDoc
    Me.NroDoc = wnroDoc
    Me.EstadoCivil = westadoCivil
    Me.GradoInstruccion = wgradoinst
    Me.mOOcupacion = wocupacion
    Me.mOProfesion = wprofesion
    Me.Direccion = wdireccion
    Me.TelefonoCasa = wtelefcasa
    Me.TelefonoTrabajo = wteleftrab
    Me.LugarTrabajo = wlugartrabajo
    Me.Email = wemail
    Me.Celular = wcelular
    Me.Vive = wvive
    Me.mODireccionActual = wdiractual

  End Sub

  Public Sub New(ByVal wcodigo As Integer, ByVal wNombre As String, ByVal wApellidoPat As String, ByVal wApellidoMat As String, _
          ByVal wsexo As String, ByVal wfechanac As Date, ByVal wtipoDoc As String, ByVal wnroDoc As String, ByVal westadoCivil As String, _
          ByVal wgradoinst As String, ByVal wdireccion As String, ByVal wtelefcasa As String, ByVal wteleftrab As String, _
          ByVal wlugartrabajo As String, ByVal wemail As String, ByVal wcelular As String, ByVal wvive As Boolean, _
          ByVal wocupacion As Ocupacion, ByVal wprofesion As Profesion, ByVal wdiractual As UbicacionGeografica)

    MyBase.New(wcodigo, wNombre, wApellidoPat, wApellidoMat, wsexo, wfechanac)

    Me.TipoDoc = wtipoDoc
    Me.NroDoc = wnroDoc
    Me.GradoInstruccion = wgradoinst
    Me.EstadoCivil = westadoCivil
    Me.mOOcupacion = wocupacion
    Me.mOProfesion = wprofesion
    Me.Direccion = wdireccion
    Me.TelefonoCasa = wtelefcasa
    Me.TelefonoTrabajo = wteleftrab
    Me.LugarTrabajo = wlugartrabajo
    Me.Email = wemail
    Me.Celular = wcelular
    Me.Vive = wvive
    Me.mODireccionActual = wdiractual

  End Sub
  
  Public Sub New(ByVal wVive As Boolean, ByVal wGradoInst As String)
    Me.Vive = wVive
    Me.GradoInstruccion = wGradoInst
  End Sub

  Public Sub New(ByVal wCodigo As Integer, ByVal wVariable As String, ByVal wGradoInst As String)
    Me.Codigo = wCodigo
    Me.Variable = wVariable
    Me.GradoInstruccion = wGradoInst
  End Sub

#End Region

End Class
