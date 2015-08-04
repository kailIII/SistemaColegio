Public Class PromedioPeriodoArea

  Private mOMatricula As Matricula
  Private mOPeriodo As PeriodoAcademico
  Private mOArea As AreaDRE
  Private mPromedio As Decimal
  Private mOPromediosCapacidades As List(Of PromedioPeriodoCapacidad)

  Public Property Area() As AreaDRE
    Get
      Return mOArea
    End Get
    Set(ByVal value As AreaDRE)
      mOArea = value
    End Set
  End Property

  Public Property PromediosCapacidades() As List(Of PromedioPeriodoCapacidad)
    Get
      Return mOPromediosCapacidades
    End Get
    Set(ByVal value As List(Of PromedioPeriodoCapacidad))
      mOPromediosCapacidades = value
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

  Public Property Periodo() As PeriodoAcademico
    Get
      Return mOPeriodo
    End Get
    Set(ByVal value As PeriodoAcademico)
      mOPeriodo = value
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
