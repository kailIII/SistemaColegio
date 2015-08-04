Public Class AlumnoBeneficiado

#Region "Datos"
  Private mSeleccionado As Boolean
  Private mAlumno As Matricula
  Private mBeneficio As Beneficio
  Private mMontoPagar As Double
#End Region

#Region "Propiedades"

  Public Property Beneficio() As Beneficio
    Get
      Return mBeneficio
    End Get
    Set(ByVal value As Beneficio)
      mBeneficio = value
    End Set
  End Property

  Public Property MontoPagar() As Double
    Get
      Return mMontoPagar
    End Get
    Set(ByVal value As Double)
      mMontoPagar = value
    End Set
  End Property

  Public Property Matricula() As Matricula
    Get
      Return mAlumno
    End Get
    Set(ByVal value As Matricula)
      mAlumno = value
    End Set
  End Property

  Public Property Seleccionado() As Boolean
    Get
      Return Me.mSeleccionado
    End Get
    Set(ByVal value As Boolean)
      Me.mSeleccionado = value
    End Set
  End Property

  Public ReadOnly Property NombreAlumno() As String
    Get
      Return Me.Matricula.NombreAlumno
    End Get
  End Property

  Public ReadOnly Property CodigoAlumno() As String
    Get
      Return Me.Matricula.Alumno.CodigoRecaudacion
    End Get
  End Property

  Public ReadOnly Property NivelGradoSeccion() As String
    Get
      Return Me.Matricula.NivelGradoSeccion
    End Get
  End Property

  Public ReadOnly Property Descuento() As Double
    Get
      Return Me.Beneficio.Descuento
    End Get
  End Property

  Public ReadOnly Property Monto() As Double
    Get
      Return Me.Beneficio.Obligacion.Monto
    End Get
  End Property

#End Region

  Public Property Documento As String

  Public Sub New()
    Me.Seleccionado = True
  End Sub

End Class
