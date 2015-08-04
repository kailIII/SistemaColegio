Public Class AnioLectivo

  Public Enum EstadoPeriodo
    Abierto = 1
    Cerrado
  End Enum

#Region "Datos"
  Private mAnio As String
  Private mFechaI As Date
  Private mFechaF As Date
  Private mVigencia As Boolean
  Private mDescripcion As String
  Private mOInstitucion As Institucion
  Private mEstado As EstadoPeriodo
#End Region

#Region "Propiedades"

  Public Property Institucion() As Institucion
    Get
      Return Me.mOInstitucion
    End Get
    Set(ByVal value As Institucion)
      Me.mOInstitucion = value
    End Set
  End Property

  Public Property Anio() As String
    Get
      Return mAnio
    End Get
    Set(ByVal value As String)
      mAnio = value
    End Set
  End Property

  Public Property FechaI() As Date
    Get
      Return mFechaI
    End Get
    Set(ByVal value As Date)
      mFechaI = value
    End Set
  End Property

  Public Property fechaF() As Date
    Get
      Return mFechaF
    End Get
    Set(ByVal value As Date)
      mFechaF = value
    End Set
  End Property

  Public Property vigencia() As Boolean
    Get
      Return mVigencia
    End Get
    Set(ByVal value As Boolean)
      mVigencia = value
    End Set
  End Property

  Public Property descripcion() As String
    Get
      Return mDescripcion
    End Get
    Set(ByVal value As String)
      mDescripcion = value
    End Set
  End Property

  Public ReadOnly Property CodigoInstitucion() As Integer
    Get
      Return mOInstitucion.CodigoInst
    End Get
  End Property

  Public Property Estado() As EstadoPeriodo
    Get
      Return mEstado
    End Get
    Set(ByVal value As EstadoPeriodo)
      mEstado = value
    End Set
  End Property

#End Region

#Region "Constructores"

  Public Sub New()
  End Sub

  Public Sub New(ByVal wAnio As String)
    Me.mAnio = wAnio
  End Sub

  Public Sub New(ByVal wAnio As String, ByVal wFechaI As Date, ByVal wFechaF As Date, ByVal wVigencia As Boolean, ByVal wDescripcion As String)

    Me.mAnio = wAnio
    Me.mFechaI = wFechaI
    Me.mFechaF = wFechaF
    Me.mVigencia = wVigencia
    Me.mDescripcion = wDescripcion
  End Sub

  Public Sub New(ByVal wAnio As String, ByVal wFechaI As Date, ByVal wFechaF As Date, ByVal wVigencia As Boolean, ByVal wDescripcion As String, ByVal wInstitucion As Institucion)

    Me.mAnio = wAnio
    Me.mFechaI = wFechaI
    Me.mFechaF = wFechaF
    Me.mVigencia = wVigencia
    Me.mDescripcion = wDescripcion
    Me.Institucion = wInstitucion
  End Sub

#End Region

End Class
