Public Class Traslado

#Region "Datos"
  Private mCodigo As Integer
  Private mMotivo As String
  Private mCodigoModularInst As String
  Private mNombreInst As String
  Private mDescripcionPeriodo As String
  Private mFechaTras As DateTime
  Private mTipo As String
  Private mNroResolucion As String
  Private mOMatricula As Matricula
#End Region

#Region "Propiedades"
  Public Property OMatricula() As Matricula
    Get
      Return mOMatricula
    End Get
    Set(ByVal value As Matricula)
      mOMatricula = value
    End Set
  End Property
  Public Property Codigo() As Integer
    Get
      Return mCodigo
    End Get
    Set(ByVal value As Integer)
      mCodigo = value
    End Set
  End Property
  Public Property Motivo() As String
    Get
      Return mMotivo
    End Get
    Set(ByVal value As String)
      mMotivo = value
    End Set
  End Property
  Public Property CodigoModularInst() As String
    Get
      Return mCodigoModularInst
    End Get
    Set(ByVal value As String)
      mCodigoModularInst = value
    End Set
  End Property
  Public Property NombreInst() As String
    Get
      Return mNombreInst
    End Get
    Set(ByVal value As String)
      mNombreInst = value
    End Set
  End Property
  Public Property DescripcionPeriodo() As String
    Get
      Return mDescripcionPeriodo
    End Get
    Set(ByVal value As String)
      mDescripcionPeriodo = value
    End Set
  End Property
  Public Property FechaTras() As DateTime
    Get
      Return mFechaTras
    End Get
    Set(ByVal value As DateTime)
      mFechaTras = value
    End Set
  End Property
  Public Property Tipo() As String
    Get
      Return mTipo
    End Get
    Set(ByVal value As String)
      mTipo = value
    End Set
  End Property
  Public Property NroResolucion() As String
    Get
      Return mNroResolucion
    End Get
    Set(ByVal value As String)
      mNroResolucion = value
    End Set
  End Property
  Public ReadOnly Property Sexo() As String
    Get
      Return mOMatricula.Alumno.Sexo
    End Get
  End Property
  Public ReadOnly Property NombreCompleto() As String
    Get
      Return mOMatricula.Alumno.NombreCompleto
    End Get
  End Property
  Public ReadOnly Property Grado() As String
    Get
      Return mOMatricula.Grado.Nivel.Siglas.Trim & " - " & mOMatricula.Grado.Numero & " " & mOMatricula.Letra
    End Get
  End Property
  Public ReadOnly Property TipoTraslado() As String
    Get
      If mTipo = "I" Then
        Return "Ingreso"
      Else
        Return "Salida"
      End If
    End Get
  End Property
#End Region

#Region "Constructores"
  Sub New()

  End Sub
  Sub New(ByVal wCodigo As Integer)
    Me.Codigo = wCodigo
  End Sub
  Sub New(ByVal wCodigoModularInst As String, ByVal wNombreInst As String, _
          ByVal wMatricula As Matricula)
    Me.CodigoModularInst = wCodigoModularInst
    Me.NombreInst = wNombreInst
    Me.OMatricula = wMatricula
  End Sub
  Sub New(ByVal wCodigo As Integer, ByVal wCodigoModular As String, ByVal wNombreInst As String, _
          ByVal wMotivo As String, ByVal wDescripcion As String, ByVal wFechaTras As DateTime, _
          ByVal wTipo As String, ByVal wResolucion As String, ByVal wMatricula As Matricula)
    Me.Codigo = wCodigo
    Me.CodigoModularInst = wCodigoModular
    Me.NombreInst = wNombreInst
    Me.Motivo = wMotivo
    Me.DescripcionPeriodo = wDescripcion
    Me.FechaTras = wFechaTras
    Me.Tipo = wTipo
    Me.NroResolucion = wResolucion
    Me.OMatricula = wMatricula
  End Sub
#End Region

End Class