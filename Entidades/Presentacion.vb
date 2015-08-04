Public Class Presentacion

#Region "Datos"
    Private mcodigo As Integer
  Private mNumero As Integer
  Private mInicio As Date
  Private mFin As Date
  Private mOAnio As AnioLectivo
  Private mVigencia As Boolean
#End Region

#Region "Propiedades"

  Public Property Codigo() As Integer
    Get
      Return mcodigo
    End Get
    Set(ByVal value As Integer)
      mcodigo = value
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

  Public Property Inicio() As Date
    Get
      Return mInicio
    End Get
    Set(ByVal value As Date)
      mInicio = value
    End Set
  End Property

  Public Property Fin() As Date
    Get
      Return mFin
    End Get
    Set(ByVal value As Date)
      mFin = value
    End Set
  End Property

  Public Property Anio() As String
    Get
      Return mOAnio.Anio
    End Get
    Set(ByVal value As String)
      mOAnio.Anio = value
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

  Public ReadOnly Property NombreVigencia() As String
    Get
      If Vigencia = True Then
        Return "SI"
      Else
        Return "NO"
      End If

    End Get

  End Property

  Public ReadOnly Property NombrePresentacion() As String
    Get
      Dim cad As String = ""
      If Codigo > 0 Then
        cad = Numero.ToString
      Else
        cad = "Todas"
      End If
      Return cad
    End Get

  End Property

#End Region

#Region "Constructores"
  Sub New()
  End Sub

  Sub New(ByVal mcodigo As Integer)
    Me.Codigo = mcodigo
  End Sub
  Sub New(ByVal wcodigo As Integer, ByVal wNro As Integer, ByVal wInicio As Date, ByVal wFin As Date, ByVal wanio As String, ByVal wVigencia As Boolean)
    Me.Codigo = wcodigo
    Me.Numero = wNro
    Me.Inicio = wInicio
    Me.Fin = wFin
    Me.Vigencia = wVigencia
    mOAnio = New AnioLectivo(wanio)
  End Sub

#End Region

End Class
