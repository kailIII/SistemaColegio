Public Class AreaDRE
  Implements IComparable(Of AreaDRE)

#Region "Datos"
  Private mCodigo As Integer
  Private mNombre As String
  Private mODRE As DRE
  Private mONivel As Nivel
  Private mOrdenActa As Integer

  Private mOCapacidades As List(Of Capacidad)
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

  Public Property Nombre() As String
    Get
      Return mNombre
    End Get
    Set(ByVal value As String)
      mNombre = value
    End Set
  End Property

  Public Property ODRE() As DRE
    Get
      Return mODRE
    End Get
    Set(ByVal value As DRE)
      mODRE = value
    End Set
  End Property

  Public Property ONivel() As Nivel
    Get
      Return mONivel
    End Get
    Set(ByVal value As Nivel)
      mONivel = value
    End Set
  End Property

  Public Property Capacidades() As List(Of Capacidad)
    Get
      Return Me.mOCapacidades
    End Get
    Set(ByVal value As List(Of Capacidad))
      Me.mOCapacidades = value
    End Set
  End Property

  Public ReadOnly Property NombreNivel() As String
    Get
      Return Me.ONivel.Nombre
    End Get
  End Property

  Public Property OrdenActa() As Integer
    Get
      Return mOrdenActa
    End Get
    Set(ByVal value As Integer)
      mOrdenActa = value
    End Set
  End Property

#End Region

#Region "Constructores"
  Sub New()

  End Sub
  Sub New(ByVal wCodigo As Integer)
    Me.Codigo = wCodigo
  End Sub
  Sub New(ByVal wCodigo As Integer, ByVal wNombre As String, ByVal wDRE As DRE, ByVal wNivel As Nivel)
    Me.Codigo = wCodigo
    Me.mNombre = wNombre
    Me.ODRE = wDRE
    Me.ONivel = wNivel
  End Sub
#End Region

  Public Function CompareTo(ByVal wArea As AreaDRE) As Integer Implements System.IComparable(Of AreaDRE).CompareTo
    If Me.Codigo > 0 AndAlso Me.Codigo = wArea.Codigo Then
      Return 0
    Else
      Return -1
    End If
  End Function

End Class
