Public Class PromedioPeriodoCapacidad

  Private mOMatricula As Matricula
  Private mOCapacidad As Capacidad
  Private mOPeriodo As PeriodoAcademico
  Private mPromedio As Decimal

  Public Property Periodo() As PeriodoAcademico
    Get
      Return mOPeriodo
    End Get
    Set(ByVal value As PeriodoAcademico)
      mOPeriodo = value
    End Set
  End Property

  Public Property Promedio() As Decimal
    Get
      Return mPromedio
    End Get
    Set(ByVal value As Decimal)
      mPromedio = value
    End Set
  End Property

  Public Property Capacidad() As Capacidad
    Get
      Return mOCapacidad
    End Get
    Set(ByVal value As Capacidad)
      mOCapacidad = value
    End Set
  End Property

  Public Property Matricula() As Matricula
    Get
      Return mOMatricula
    End Get
    Set(ByVal value As Matricula)
      mOMatricula = value
    End Set
  End Property


End Class
