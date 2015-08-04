Public Class Administrativo
  Inherits Personal

#Region "Datos"
  Private mCargo As String
#End Region

#Region "Propìedades"

  Public Property Cargo() As String
    Get
      Return mCargo
    End Get
    Set(ByVal value As String)
      mCargo = value
    End Set
  End Property

#End Region

#Region "Constructores"

  Public Sub New()
  End Sub

  Public Sub New(ByVal _cod As Integer)
    MyBase.New(_cod)
  End Sub

  Public Sub New(ByVal _cargo As String)
    Me.Cargo = _cargo
  End Sub

  Public Sub New(ByVal _cod As Integer, ByVal wNombre As String, ByVal wApellidoPat As String, _
               ByVal wApellidoMat As String)
    MyBase.New(_cod, wNombre, wApellidoPat, wApellidoMat)
  End Sub

  Public Sub New(ByVal _cod As Integer, ByVal wNombre As String, ByVal wApellidoPat As String, _
                 ByVal wApellidoMat As String, ByVal wSexo As String, ByVal wFechaNac As Date, _
                 ByVal wEmail As String, ByVal wCelular As String, ByVal wcargo As String)
    MyBase.New(_cod, wNombre, wApellidoPat, wApellidoMat, wSexo, wFechaNac, wEmail, wCelular)
    Me.Cargo = wcargo
  End Sub
#End Region

End Class
