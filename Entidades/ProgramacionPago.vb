Public Class ProgramacionPago

#Region "Datos"

  Private mCodigo As Integer
  Private mDescripcion As String
  Private mMonto As Double
  Private mEntidad As String
  Private mVigencia As Boolean
  Private mVencimiento As DateTime
  Private mOServicio As Servicio
  Private mONivel As Nivel
  Private mOAnio As AnioLectivo
  Private mAplica As String
#End Region

#Region "Propiedades"

  Public Property codigo() As Integer
    Get
      Return mCodigo
    End Get
    Set(ByVal value As Integer)
      mCodigo = value
    End Set
  End Property

  Public Property Descripcion() As String
    Get
      Return mDescripcion
    End Get
    Set(ByVal value As String)
      mDescripcion = value
    End Set
  End Property

  Public Property Monto() As Double
    Get
      Return mMonto
    End Get
    Set(ByVal value As Double)
      mMonto = value
    End Set
  End Property

  Public Property Entidad() As String
    Get
      Return mEntidad
    End Get
    Set(ByVal value As String)
      mEntidad = value
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

  Public Property Vencimiento() As DateTime
    Get
      Return mVencimiento
    End Get
    Set(ByVal value As DateTime)
      mVencimiento = value
    End Set
  End Property

  Public Property Servicio() As Servicio
    Get
      Return mOServicio
    End Get
    Set(ByVal value As Servicio)
      mOServicio = value
    End Set
  End Property

  Public Property Nivel() As Nivel
    Get
      Return mONivel
    End Get
    Set(ByVal value As Nivel)
      mONivel = value
    End Set
  End Property

  Public Property Anio() As AnioLectivo
    Get
      Return mOAnio
    End Get
    Set(ByVal value As AnioLectivo)
      mOAnio = value
    End Set
  End Property

  Public ReadOnly Property LeerVigencia() As String
    Get
      If vigencia = True Then
        Return "Activo"
      Else
        Return "No Activo"
      End If
    End Get
  End Property

  Public ReadOnly Property MostrarEntidad() As String
    Get
      If Entidad = "I" Then
        Return "INSTITUCION"
      Else
        Return "COPAFA"
      End If
    End Get
  End Property

  Public ReadOnly Property leerAnio() As String
    Get
      Return Anio.Anio
    End Get
  End Property

  Public ReadOnly Property leerNivel() As String
    Get
      If Me.Nivel IsNot Nothing Then
        Return Nivel.Nombre
      Else
        Return ""
      End If
    End Get
  End Property

  Public ReadOnly Property LeerServicio() As String
    Get
      Return Me.Servicio.Nombre
    End Get
  End Property

  Public Property Aplica() As String
    Get
      Return mAplica
    End Get
    Set(ByVal value As String)
      mAplica = value
    End Set
  End Property

  Public ReadOnly Property DescripcionAplica() As String
    Get
      Dim desc As String = ""
      Select Case Me.Aplica
        Case "T"
          desc = "Todos"
        Case "A"
          desc = "Antiguos"
        Case "N"
          desc = "Nuevos"
        Case "H"
          desc = "Hijo menor"
      End Select

      Return desc
    End Get
  End Property

#End Region

#Region "Constructores"

  Public Sub New()

  End Sub

  Public Sub New(ByVal wcodigo As Integer, ByVal wmonto As Double, ByVal wdescripcion As String, ByVal wentidad As String, _
                 ByVal wvigencia As Boolean, ByVal wfechaVcto As DateTime, ByVal wServicio As Servicio, _
                  ByVal wAnio As AnioLectivo, ByVal wNivel As Nivel)
    Me.codigo = wcodigo
    Me.Monto = wmonto
    Me.Entidad = wentidad
    Me.Descripcion = wdescripcion
    Me.vigencia = wvigencia
    Me.Vencimiento = wfechaVcto
    Me.Servicio = wServicio
    Me.Anio = wAnio
    Me.Nivel = wNivel
  End Sub

  Public Sub New(ByVal wvigencia As Boolean)

    Me.vigencia = wvigencia

  End Sub
#End Region

End Class
