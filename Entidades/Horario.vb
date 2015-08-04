Public Class Horario

#Region "Datos"
    Private mcodigo As Integer
    Private mOCarga As CargaAcademica
    Private mOAula As Aula
    Private mdia As String
    Private mhoraIni As Date
    Private mhoraFin As Date

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
    Public Property Carga() As CargaAcademica
        Get
            Return Me.mOCarga
        End Get
        Set(ByVal value As CargaAcademica)
            Me.mOCarga = value
        End Set
    End Property
    Public ReadOnly Property CodigoCarga() As Integer
        Get
            Return mOCarga.Codigo
        End Get
    End Property
    Public Property Aula() As Aula
        Get
            Return mOAula
        End Get
        Set(ByVal value As Aula)
            mOAula = value
        End Set
    End Property

    Public Property dia() As String
        Get
            Return mdia
        End Get
        Set(ByVal value As String)
            mdia = value
        End Set
    End Property

    Public Property horaIni() As Date
        Get
            Return mhoraIni
        End Get
        Set(ByVal value As Date)
            mhoraIni = value
        End Set
    End Property

    Public Property horaFin() As Date
        Get
            Return mhoraFin
        End Get
        Set(ByVal value As Date)
            mhoraFin = value
        End Set
  End Property
  Public ReadOnly Property NumeroAula() As Integer
    Get
      Return mOAula.Numero
    End Get
  End Property
  Public ReadOnly Property Tipo() As String
    Get
      Return mOAula.Tipo
    End Get
  End Property


  Public ReadOnly Property NombreCompletoAula() As String
    Get
      Dim nombre As String = ""
      Select Case Tipo
        Case "A"
          nombre = "Aula" & " - " & NumeroAula
        Case "P"
          nombre = "Patio" & " - " & NumeroAula
        Case "L"
          nombre = "Laboratorio" & " - " & NumeroAula
      End Select

      Return nombre
    End Get
  End Property
#End Region

#Region "Connstructores"
    Sub New()

    End Sub

  Sub New(ByVal wCodigo As Integer, ByVal wCarga As CargaAcademica, ByVal wAula As Aula, ByVal wDia As String, ByVal wHoraIni As Date, _
          ByVal wHoraFin As Date)
    Codigo = wCodigo
    Carga = wCarga
    Aula = wAula
    dia = wDia
    horaIni = wHoraIni
    horaFin = wHoraFin
  End Sub

#End Region

End Class
