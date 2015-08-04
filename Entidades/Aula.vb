Public Class Aula

#Region "Datos"

  Private mCodigo As Integer
  Private mOLocal As Local
  Private mNumero As Integer
  Private mPiso As Integer
  Private mCapacidad As Integer
  Private mPabellon As Integer
  Private mVigencia As Boolean
  Private mTipo As String
#End Region

#Region "Propiedades"

  Public Property Tipo() As String
    Get
      Return mTipo
    End Get
    Set(ByVal value As String)
      mTipo = value
    End Set
  End Property

  Public Property Vigencia() As Boolean
    Get
      Return mVigencia
    End Get
    Set(ByVal value As Boolean)
      mVigencia = value
    End Set
  End Property

  Public Property Piso() As Integer
    Get
      Return mPiso
    End Get
    Set(ByVal value As Integer)
      mPiso = value
    End Set
  End Property

  Public Property Capacidad() As Integer
    Get
      Return mCapacidad
    End Get
    Set(ByVal value As Integer)
      mCapacidad = value
    End Set
  End Property

  Public Property Pabellon() As Integer
    Get
      Return mPabellon
    End Get
    Set(ByVal value As Integer)
      mPabellon = value
    End Set
  End Property

  Public Property Local() As Local
    Get
      Return mOLocal
    End Get
    Set(ByVal value As Local)
      mOLocal = value
    End Set
  End Property

  Public Property Numero() As Integer
    Get
      Return mNumero
    End Get
    Set(ByVal value As Integer)
      mNumero = value
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

  Public ReadOnly Property NombreAula() As String
    Get
      Return "Aula " & Numero & "-" & NombrePabellon
    End Get
  End Property

  Public ReadOnly Property NombreCompletoAula() As String
    Get
      Dim nombre As String = ""
      Select Case Tipo
        Case "A"
          nombre = "Aula" & " - " & Numero & " - " & Me.NombrePabellon
        Case "P"
          nombre = "Patio" & " - " & Numero & " - " & Me.NombrePabellon
        Case "L"
          nombre = "Laboratorio" & " - " & Numero & " - " & Me.NombrePabellon
      End Select

      Return nombre
    End Get
  End Property

  Public ReadOnly Property NombrePabellon() As String
    Get
      Dim nombre As String = ""
      Select Case Pabellon
        Case 0
          nombre = "Inicial"
        Case 1
          nombre = "Primaria"
        Case 2
          nombre = "Secundaria"
      End Select
      Return nombre
    End Get
  End Property

  Public ReadOnly Property NombreLocal() As String
    Get
      Return mOLocal.Nombre
    End Get
  End Property

  Public ReadOnly Property NombreAulaLocal() As String
    Get
      Return Me.Local.Nombre & " - " & Me.Numero
    End Get
  End Property

  Public ReadOnly Property NombreVigencia() As String
    Get
      Dim nombre As String = ""
      If Vigencia = True Then
        nombre = "SI"
      Else
        nombre = "NO"
      End If
      Return nombre
    End Get
  End Property

#End Region

#Region "Constructores"

  Public Sub New()

  End Sub

  Public Sub New(ByVal wCodigo As Integer, ByVal wCodigoLocal As String, ByVal wnumero As Integer)
    Me.Codigo = wCodigo
    Me.Local = New Local(wCodigoLocal)
    Me.Numero = wnumero
  End Sub

  Public Sub New(ByVal wCodigo As Integer)
    Me.Codigo = wCodigo
  End Sub

  Public Sub New(ByVal wcodigoAula As Integer, ByVal wcodigolocal As String, ByVal wnumero As Integer, ByVal wcapacidadCarpetas As Integer, _
          ByVal wVigencia As Boolean, ByVal wpiso As Integer, ByVal wtipo As String, ByVal wpabellon As Integer)
    Me.Codigo = wcodigoAula
    Me.Local = New Local(wcodigolocal)
    Me.Numero = wnumero
    Me.Capacidad = wcapacidadCarpetas
    Me.Piso = wpiso
    Me.Pabellon = wpabellon
    Me.Vigencia = wVigencia
    Me.Tipo = wtipo
  End Sub

  Public Sub New(ByVal wcodigoAula As Integer, ByVal wcodigolocal As String, ByVal wnumero As Integer, ByVal wcapacidadCarpetas As Integer, _
          ByVal wVigencia As Boolean, ByVal wpiso As Integer, ByVal wtipo As String, ByVal wnombreLocal As String, ByVal wpabellon As Integer)

    Me.Codigo = wcodigoAula
    Me.Local = New Local(wcodigolocal)
    Me.Numero = wnumero
    Me.Capacidad = wcapacidadCarpetas
    Me.Piso = wpiso
    Me.Vigencia = wVigencia
    Me.Tipo = wtipo
    Me.Pabellon = wpabellon
    Me.Local.Nombre = wnombreLocal
  End Sub

  Public Sub New(ByVal wcodigoAula As Integer, ByVal wtipo As String, ByVal wlocal As Local, ByVal wnumero As Integer, ByVal wpabellon As Integer)
    Me.Codigo = wcodigoAula
    Me.Tipo = wtipo
    Me.Local = wlocal
    Me.Numero = wnumero
    Me.Pabellon = wpabellon
  End Sub

  Public Sub New(ByVal wcodigoAula As Integer, ByVal wtipo As String, ByVal wlocal As Local, ByVal wnumero As Integer, ByVal wpabellon As Integer, ByVal wvigencia As Boolean)
    Me.Codigo = wcodigoAula
    Me.Tipo = wtipo
    Me.Local = wlocal
    Me.Numero = wnumero
    Me.Pabellon = wpabellon
    Me.Vigencia = wvigencia
  End Sub

  Public Sub New(ByVal wVigencia As Boolean, ByVal wtipo As String)
    Me.Vigencia = wVigencia
    Me.Tipo = wtipo
  End Sub

#End Region

End Class
