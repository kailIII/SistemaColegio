Public Class PromedioPeriodo

  Private mOMatricula As Matricula
  Private mPromedio As Double
  Private mOrdenMerito As Byte
  Private mOAreas As PromedioPeriodoArea

  Public Property Areas() As PromedioPeriodoArea
    Get
      Return mOAreas
    End Get
    Set(ByVal value As PromedioPeriodoArea)
      mOAreas = value
    End Set
  End Property

  Public Property Promedio() As Double
    Get
      Return mPromedio
    End Get
    Set(ByVal value As Double)
      mPromedio = value
    End Set
  End Property

  Public Property OrdenMerito() As Byte
    Get
      Return mOrdenMerito
    End Get
    Set(ByVal value As Byte)
      mOrdenMerito = value
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
