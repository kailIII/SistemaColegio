Public Class Turno

#Region "Datos"
  Private mCodigo As Integer
  Private mNombre As String
  'Private mONivel As Nivel
  Private mHoraIni As Date
  Private mHoraFin As Date
#End Region

#Region "Propiedades"
  Public Property Codigo() As Integer
    Get
      Return mCodigo
    End Get
    Set(ByVal value As Integer)
      mCodigo = value
    End Set
  End Property
  'Public Property ONivel() As Nivel
  '  Get
  '    Return mONivel
  '  End Get
  '  Set(ByVal value As Nivel)
  '    mONivel = value
  '  End Set
  'End Property
  Public Property Nombre() As String
    Get
      Return mNombre
    End Get
    Set(ByVal value As String)
      mNombre = value
    End Set
  End Property
  Public Property HoraFin() As Date
    Get
      Return mHoraFin
    End Get
    Set(ByVal value As Date)
      mHoraFin = value
    End Set
  End Property
  Public Property HoraIni() As Date
    Get
      Return mHoraIni
    End Get
    Set(ByVal value As Date)
      mHoraIni = value
    End Set
  End Property
  'Public ReadOnly Property NombreNivel() As String
  '  Get
  '    Return mONivel.Nombre
  '  End Get
  'End Property

#End Region

#Region "Constructores"
  Public Sub New()

  End Sub

  Public Sub New(ByVal wCodigo As Integer, ByVal wNombre As String, ByVal wHoraIni As Date, ByVal wHoraFin As Date)
    Me.Codigo = wCodigo
    Me.Nombre = wNombre
    Me.HoraIni = wHoraIni
    Me.HoraFin = wHoraFin
  End Sub
  Public Sub New(ByVal wCodigo As Integer, ByVal wNombre As String)
    Me.Codigo = wCodigo
    Me.Nombre = wNombre
  End Sub
  Public Sub New(ByVal wCodigo As Integer)
    Me.Codigo = wCodigo
  End Sub
  'Public Sub New(ByVal wCodigo As Integer, ByVal wNombre As String, ByVal wHoraIni As Date, ByVal wHoraFin As Date) ', ByVal wNivel As Nivel)
  '  Me.Codigo = wCodigo
  '  'Me.ONivel = wNivel
  '  Me.Nombre = wNombre
  '  Me.HoraIni = wHoraIni
  '  Me.HoraFin = wHoraFin
  'End Sub

#End Region

End Class
