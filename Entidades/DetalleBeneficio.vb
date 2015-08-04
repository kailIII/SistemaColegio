Public Class DetalleBeneficio
#Region "Datos"
    Private OMatricula As Matricula
    Private OBeneficio As Beneficio
  Private mNumero As Integer    'modificado 22082010
    Private mDescuento As Double
    Private mfechaini As Date     'modificado 22082010
  Private mfechafin As Date     'modificado 22082010
  Private mMotivo As String

#End Region
#Region "Propiedades"
    Public Property Matricula() As Matricula
        Get
            Return OMatricula
        End Get
        Set(ByVal value As Matricula)
            OMatricula = value
        End Set
    End Property


    Public Property Beneficio() As Beneficio
        Get
            Return OBeneficio
        End Get
        Set(ByVal value As Beneficio)
            OBeneficio = value
        End Set
    End Property

    Public Property Numero() As Integer
        Get
            Return mnumero
        End Get
        Set(ByVal value As Integer)
            mnumero = value
        End Set
    End Property

    Public Property Descuento() As Double
        Get
            Return mDescuento
        End Get
        Set(ByVal value As Double)
            mDescuento = value
        End Set
    End Property

    Public Property Fechaini() As Date
        Get
            Return mfechaini
        End Get
        Set(ByVal value As Date)
            mfechaini = value
        End Set
    End Property
    Public Property Fechafin() As Date
        Get
            Return mfechafin
        End Get
        Set(ByVal value As Date)
            mfechafin = value
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
  Public ReadOnly Property MotivoCadena() As Integer
    Get
      Select Case Motivo
        Case "H"
          Return 0
        Case "S"
          Return 1
        Case "O"
          Return 2
        Case "U"
          Return 3
      End Select
    End Get
  End Property
#End Region
#Region "Constructores"
    Public Sub New()
    End Sub
  Public Sub New(ByVal wNumMatricula As Integer, ByVal wCodigoBeneficio As Integer, ByVal wNumero As Integer, ByVal wDescuento As Double, ByVal wFechaini As Date, ByVal wFechafin As Date, ByVal wMotivo As String)
    Matricula = New Matricula(wNumMatricula)
    Beneficio = New Beneficio(wCodigoBeneficio)
    Numero = wNumero
    Descuento = wDescuento
    Fechaini = wFechaini
    Fechafin = wFechafin
    Motivo = wMotivo
  End Sub

  Public Sub New(ByVal wcodalumno As Integer, ByVal wapellidopat As String, ByVal wapellidomat As String, ByVal wnombre As String, _
     ByVal wfecha As Date, ByVal wCodigoAutorizador As Integer, ByVal wVigencia As Boolean, ByVal wCodigoBeneficio As Integer, _
     ByVal wNumMatricula As Integer, ByVal wNumero As Integer, ByVal wDescuento As Double, ByVal wfechaini As Date, ByVal wfechafin As Date, ByVal wMotivo As String)

    Matricula = New Matricula(wNumMatricula)
    Beneficio = New Beneficio(wCodigoBeneficio, wCodigoAutorizador, 0, wfecha, wVigencia)
    Descuento = wDescuento
    Numero = wNumero
    Fechaini = wfechaini
    Fechafin = wfechafin
    Motivo = wMotivo
    Matricula.Alumno = New Alumno(wcodalumno, wnombre, wapellidopat, wapellidomat)
  End Sub

#End Region
End Class
