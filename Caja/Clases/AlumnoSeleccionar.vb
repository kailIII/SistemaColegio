Public Class AlumnoSeleccionar

  Private mOAlumno As Matricula
  Private mSeleccionado As Boolean

  Public Property Seleccionado() As Boolean
    Get
      Return mSeleccionado
    End Get
    Set(ByVal value As Boolean)
      Me.mSeleccionado = value
    End Set
  End Property

  Public Property Matriculado() As Matricula
    Get
      Return mOAlumno
    End Get
    Set(ByVal value As Matricula)
      mOAlumno = value
    End Set
  End Property

  Public ReadOnly Property NombreAlumno() As String
    Get
      Return Me.Matriculado.NombreAlumno
    End Get
  End Property

  Public Sub New()
    Me.Matriculado = Nothing
    Me.Seleccionado = True
  End Sub

  Public Sub New(ByVal wAlumno As Matricula)
    Me.Matriculado = wAlumno
    Me.Seleccionado = True
  End Sub

  Public ReadOnly Property CodigoRecaudacion As String
    Get
      Return Me.mOAlumno.CodigoRecaudacion
    End Get
  End Property


End Class
