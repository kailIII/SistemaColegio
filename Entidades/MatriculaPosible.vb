Public Class MatriculaPosible

#Region "Datos"
  Private mOAlumno As Alumno
  Private mOSeccion As Seccion
  Private mOApoderado As Parentesco
#End Region

#Region "Propiedades"
  Public Property Apoderado() As Parentesco
    Get
      Return mOApoderado
    End Get
    Set(ByVal value As Parentesco)
      mOApoderado = value
    End Set
  End Property

  Public Property Seccion() As Seccion
    Get
      Return mOSeccion
    End Get
    Set(ByVal value As Seccion)
      mOSeccion = value
    End Set
  End Property

  Public Property Alumno() As Alumno
    Get
      Return mOAlumno
    End Get
    Set(ByVal value As Alumno)
      mOAlumno = value
    End Set
  End Property
#End Region

#Region "Constructores"

#End Region


End Class
