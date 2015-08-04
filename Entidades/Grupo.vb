Public Class Grupo

#Region "Datos"
  Private mOMatricula As Matricula
  Private mODocenteCarga As DocenteCarga
  Private mAsignado As Boolean
#End Region

#Region "Propiedades"

  Public Property Matricula() As Matricula
    Get
      Return mOMatricula
    End Get
    Set(ByVal value As Matricula)
      mOMatricula = value
    End Set
  End Property

  Public Property DocenteCarga() As DocenteCarga
    Get
      Return mODocenteCarga
    End Get
    Set(ByVal value As DocenteCarga)
      mODocenteCarga = value
    End Set
  End Property

  Public Property Asignado() As Boolean
    Get
      Return mAsignado
    End Get
    Set(ByVal value As Boolean)
      mAsignado = value
    End Set
  End Property

  Public ReadOnly Property NombreAlumno As String
    Get
      Return Me.Matricula.Alumno.NombreCompleto
    End Get
  End Property

  Public ReadOnly Property SexoAlumno As String
    Get
      Return Me.Matricula.Alumno.Sexo
    End Get
  End Property

#End Region

#Region "Constructores"
  Sub New()

  End Sub
  Sub New(ByVal wMatricula As Matricula, ByVal wDocenteCarga As DocenteCarga)
    Me.Matricula = wMatricula
    Me.DocenteCarga = wDocenteCarga
  End Sub
#End Region

End Class
