Public Class Permiso
#Region "Datos"
  Protected mNumero As Integer
  Private mCodigoSist As New Sistema
  Private mNumeroOpc As New Opcion
  Private mCodigoGrupoUsu As New GrupoUsuario
  Private mCodigoUsu As New Usuario
  Private mAcceso As Integer

#End Region

#Region "Propiedades"
  Public Property Numero() As Integer
    Get
      Return mNumero
    End Get
    Set(ByVal value As Integer)
      mNumero = value
    End Set
  End Property
  Public Property CodigoSist() As Integer
    Get
      Return mCodigoSist.Codigo
    End Get
    Set(ByVal value As Integer)
      mCodigoSist.Codigo = value
    End Set
  End Property
  Public Property NumeroOpc() As Integer
    Get
      Return mNumeroOpc.Numero
    End Get
    Set(ByVal value As Integer)
      mNumeroOpc.Numero = value
    End Set
  End Property
  Public Property CodigoGrupoUsu() As Integer
    Get
      Return mCodigoGrupoUsu.Codigo
    End Get
    Set(ByVal value As Integer)
      mCodigoGrupoUsu.Codigo = value
    End Set
  End Property
  Public Property CodigoUsu() As Integer
    Get
      Return mCodigoUsu.Codigo
    End Get
    Set(ByVal value As Integer)
      mCodigoUsu.Codigo = value
    End Set
  End Property
  Public Property Acceso() As Integer
    Get
      Return mAcceso
    End Get
    Set(ByVal value As Integer)
      mAcceso = value
    End Set
  End Property

#End Region
#Region "Constructores"
  Public Sub New()
  End Sub

  Public Sub New(ByVal wNumero As Integer, ByVal wCodigoSist As Sistema, ByVal wNumeroOpc As Opcion, ByVal wCodigoGrupoUsu As GrupoUsuario, ByVal wCodigoUsu As Usuario, ByVal wAcceso As Integer)
    mNumero = wNumero
    mCodigoSist = wCodigoSist
    mNumeroOpc = wNumeroOpc
    mCodigoGrupoUsu = wCodigoGrupoUsu
    mCodigoUsu = wCodigoUsu
    mAcceso = wAcceso
  End Sub

  Public Sub New(ByVal wNumero As Integer, ByVal wCodigoSist As Sistema, ByVal wNumeroOpc As Opcion, ByVal wCodigoGrupoUsu As GrupoUsuario, ByVal wAcceso As Integer)
    mNumero = wNumero
    mCodigoSist = wCodigoSist
    mNumeroOpc = wNumeroOpc
    mCodigoGrupoUsu = wCodigoGrupoUsu
    mAcceso = wAcceso
  End Sub

#End Region

End Class
