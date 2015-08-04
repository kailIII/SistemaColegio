Public Class Grado

#Region "Datos"
  Private oNivel As Nivel
  Private mCodigo As Integer
  Private mNumero As Integer
  Private mNombre As String
  Private mTipoCalif As String
  Private mCaracteristica As String
  Private mEvalComp As String
  Private mTipoEval As String
#End Region

#Region "Propiedades"

  Public Property EvaluacionComp() As String
    Get
      Return mEvalComp
    End Get
    Set(ByVal value As String)
      mEvalComp = value
    End Set
  End Property

  Public Property TipoEval() As String
    Get
      Return mTipoEval
    End Get
    Set(ByVal value As String)
      mTipoEval = value
    End Set
  End Property

  Public Property Nivel() As Nivel
    Get
      Return Me.oNivel
    End Get
    Set(ByVal value As Nivel)
      oNivel = value
    End Set
  End Property

  Public Property Caracteristica() As String
    Get
      Return mCaracteristica
    End Get
    Set(ByVal value As String)
      mCaracteristica = value
    End Set
  End Property

  Public ReadOnly Property LeerCaracteristica() As String
    Get
      Dim cadena As String = ""
      Select Case mCaracteristica.Trim
        Case "U" : cadena = "Unidocente"
        Case "PM" : cadena = "Polidocente Multigrado"
        Case "PC" : cadena = "Polidocente Completo"
      End Select
      Return cadena
    End Get
  End Property

  Public Property TipoCalif() As String
    Get
      Return mTipoCalif
    End Get
    Set(ByVal value As String)
      mTipoCalif = value
    End Set
  End Property

  Public ReadOnly Property TipoCalif2() As String
    Get
      Dim cad As String = ""
      If Me.TipoCalif = "L" Then
        cad = "Literal"
      Else
        cad = "Numérica"
      End If
      Return cad
    End Get
  End Property

  Public Property Codigo() As Integer
    Get
      Return mCodigo
    End Get
    Set(ByVal value As Integer)
      mCodigo = value
    End Set
  End Property

  Public ReadOnly Property CodigoNivel() As Integer
    Get
      Return Me.Nivel.Codigo
    End Get
  End Property

  Public Property Numero() As Integer
    Get
      Return mNumero
    End Get
    Set(ByVal value As Integer)
      mNumero = value
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

  Public ReadOnly Property NombreNivel() As String
    Get
      Return Me.Nivel.Nombre
    End Get
  End Property

  Public ReadOnly Property NivelGrado() As String
    Get
      Return Me.Nivel.Siglas & " " & Me.Numero
    End Get
  End Property
#End Region

#Region "Constructores"

  Public Sub New()
  End Sub

  Public Sub New(ByVal wCodigo As Integer)
    Me.Codigo = wCodigo
  End Sub

  Public Sub New(ByVal wCodigo As Integer, ByVal wCodigoNivel As Integer, ByVal wNombre As String, ByVal wNumero As Integer)
    Me.Codigo = wCodigo
    Me.Nombre = wNombre
    Me.Nivel = New Nivel(wCodigoNivel, "", "")
    Me.Numero = wNumero
  End Sub

  Sub New(ByVal wcodigoGrado As Integer, ByVal wnumero As Integer, ByVal wnombre As String, ByVal wcodigoModular As Nivel, ByVal wTipoCalif As String, ByVal wCaracteristica As String)
    Me.Codigo = wcodigoGrado
    Me.Numero = wnumero
    Me.Nombre = wnombre
    Me.Nivel = wcodigoModular
    Me.TipoCalif = wTipoCalif
    Me.Caracteristica = wCaracteristica
  End Sub

  Public Sub New(ByVal wCodigoNivel As Integer, ByVal wnombre As String)
    Me.Nivel = New Nivel(wCodigoNivel, "", "")
  End Sub

  Sub New(ByVal wcodigoG As Integer, ByVal wnumero As Integer)
    Me.Codigo = wcodigoG
    Me.numero = wnumero
  End Sub

  Sub New(ByVal wcodigoGrado As Integer, ByVal wnumero As Integer, ByVal wnombre As String, ByVal wcodigoModular As Nivel, ByVal wTipoCalif As String, ByVal wCaracteristica As String, ByVal wEval As String, ByVal wTipo As String)
    Me.Codigo = wcodigoGrado
    Me.Numero = wnumero
    Me.Nombre = wnombre
    Me.Nivel = wcodigoModular
    Me.TipoCalif = wTipoCalif
    Me.Caracteristica = wCaracteristica
    Me.EvaluacionComp = wEval
    Me.TipoEval = wTipo
  End Sub

#End Region

End Class
