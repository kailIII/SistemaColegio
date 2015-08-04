Public Class Pariente
  Inherits Persona

#Region "Datos"

  Private mAlumnoMatriculado As Matricula
  Private mVive As Boolean

#End Region

#Region "Propiedades"

  Public Property Vive() As Boolean
    Get
      Return Me.mVive
    End Get
    Set(ByVal value As Boolean)
      Me.mVive = value
    End Set
  End Property

  Public ReadOnly Property DescripcionVive() As String
    Get
      Return IIf(Me.mVive = True, "Si", "No").ToString
    End Get
  End Property


  Public Property AlumnoMatriculado() As Matricula
    Get
      Return mAlumnoMatriculado
    End Get
    Set(ByVal value As Matricula)
      mAlumnoMatriculado = value
    End Set
  End Property

#Region "Matricula"

  Public ReadOnly Property NivelGradoSeccion() As String
    Get
      Return Me.AlumnoMatriculado.Seccion.NivelNumeroLetra
    End Get
  End Property

  Public ReadOnly Property NombreHijo() As String
    Get
      Return Me.AlumnoMatriculado.Alumno.NombreCompleto
    End Get
  End Property

#End Region

#End Region

End Class
