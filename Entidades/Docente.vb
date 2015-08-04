Public Class Docente
  Inherits Personal

#Region "Datos"
  Private mOEspecialidad As Especialidad
  Private mGrado As String
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

  Public Property Especialidad() As Especialidad
    Get
      Return Me.mOEspecialidad
    End Get
    Set(ByVal value As Especialidad)
      Me.mOEspecialidad = value
    End Set
  End Property

  Public ReadOnly Property NombreEspecialidad() As String
    Get
      Return Me.Especialidad.nombre
    End Get
  End Property

  Public Property Grado() As String
    Get
      Return mGrado
    End Get
    Set(ByVal value As String)
      mGrado = value
    End Set
  End Property

#End Region

#Region "Constructores"

  Public Sub New()
  End Sub
  Public Sub New(ByVal wCodigo As Integer, ByVal wNombre As String, ByVal wApellidoPat As String, ByVal wApellidoMat As String)
    MyBase.New(wCodigo, wNombre, wApellidoPat, wApellidoMat)
  End Sub
  Public Sub New(ByVal wCodigo As Integer, ByVal wNombre As String, ByVal wApellidoPat As String, _
                 ByVal wApellidoMat As String, ByVal wSexo As String, ByVal wFechaNac As Date, _
                 ByVal wEmail As String, ByVal wTipoDoc As String, ByVal wNroDoc As String, ByVal wCelular As String, ByVal wGrado As String, _
                 ByVal wEspecialidad As Integer, ByVal wNombreEspecialidad As String, ByVal wDireccion As String)

    MyBase.New(wCodigo, wNombre, wApellidoPat, wApellidoMat, wSexo, wFechaNac, wEmail, wTipoDoc, wNroDoc, wCelular, wDireccion)
    Me.Grado = wGrado
    Me.Especialidad = New Especialidad(wEspecialidad, wNombreEspecialidad)
  End Sub
  Public Sub New(ByVal wNombre As String, ByVal wApellidoPat As String, _
                     ByVal wApellidoMat As String, ByVal wSexo As String, ByVal wFechaNac As Date, _
                     ByVal wTipoDoc As String, ByVal wNroDoc As String, ByVal wEmail As String, ByVal wCelular As String, ByVal wEspecialidad As Integer, _
                     ByVal wGrado As String, ByVal wDireccion As String)

    MyBase.New(wNombre, wApellidoPat, wApellidoMat, wSexo, wFechaNac, wTipoDoc, wNroDoc, wEmail, wCelular, wDireccion)
    Me.Grado = wGrado
    Me.Especialidad = New Especialidad(wEspecialidad, "")
  End Sub

  Public Sub New(ByVal wCod As Integer)
    MyBase.New(wCod)
  End Sub

  Public Sub New(ByVal wEspecialidad As Integer, ByVal wGrado As String)
    Me.Especialidad = New Especialidad(wEspecialidad, "")
    Me.Grado = wGrado
  End Sub

  Public Sub New(ByVal wCodigo As Integer, ByVal wNombre As String, ByVal wApellidoPat As String, ByVal wApellidoMat As String, _
                 ByVal wespecialidad As Integer)
    MyBase.New(wCodigo, wNombre, wApellidoPat, wApellidoMat)
    Me.Especialidad = New Especialidad(wespecialidad, "")
  End Sub

#End Region

End Class
