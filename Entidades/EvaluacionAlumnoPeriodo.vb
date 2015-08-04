Public Class EvaluacionAlumnoPeriodo

  Private mOAlumno As Matricula
  Private mOPeriodo As PeriodoAcademico
  Private mOPromediosAreas As List(Of PromedioPeriodoArea)

  Public Property PromediosCapacidades() As List(Of PromedioPeriodoArea)
    Get
      Return mOPromediosAreas
    End Get
    Set(ByVal value As List(Of PromedioPeriodoArea))
      mOPromediosAreas = value
    End Set
  End Property

  Public Property Periodo() As PeriodoAcademico
    Get
      Return mOPeriodo
    End Get
    Set(ByVal value As PeriodoAcademico)
      mOPeriodo = value
    End Set
  End Property


  Public Property Alumno() As Matricula
    Get
      Return mOAlumno
    End Get
    Set(ByVal value As Matricula)
      mOAlumno = value
    End Set
  End Property


End Class
