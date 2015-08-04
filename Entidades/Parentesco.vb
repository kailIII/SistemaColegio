Public Class Parentesco

#Region "Datos"
  Private mOApoderado As Apoderado
  Private mOAlumno As Alumno
  Private mParentesco As String
#End Region

#Region "Propiedades"
  Public Property Apoderado() As Apoderado
    Get
      Return mOApoderado
    End Get
    Set(ByVal value As Apoderado)
      mOApoderado = value
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
  Public Property Parentesco() As String
    Get
      Return mParentesco
    End Get
    Set(ByVal value As String)
      mParentesco = value
    End Set
  End Property
  Public ReadOnly Property NombreCompleto() As String
    Get
      Return mOApoderado.ApellidoPaterno & " " & mOApoderado.ApellidoMaterno & " " & mOApoderado.Nombre
    End Get
  End Property
  Public ReadOnly Property CodigoApoderado() As Integer
    Get
      Return mOApoderado.Codigo
    End Get
  End Property
#End Region

#Region "Constructores"
  Sub New()
  End Sub
  Sub New(ByVal mOApoderado As Apoderado, ByVal mOAlumno As Alumno, ByVal mParentesco As String)
    Apoderado = mOApoderado
    Alumno = mOAlumno
    Parentesco = mParentesco
  End Sub
  Sub New(ByVal mOApoderado As Apoderado, ByVal mParentesco As String)
    Apoderado = mOApoderado
    Parentesco = mParentesco
  End Sub
  Sub New(ByVal wcodigoAlumno As Integer, ByVal wcodigoApoderado As Integer, ByVal wparentesco As String)
    Me.Alumno = New Alumno(wcodigoAlumno)
    Me.Apoderado = New Apoderado(wcodigoApoderado)
    Me.parentesco = wparentesco
  End Sub

#End Region

End Class
