Public Class ObligacionesVencidas

#Region "Datos"

  Private mGradoSeccion As String
  Private mApellidosNombres As String
  Private mAsignado As Double
  Private mVencido As Double
  Private mPagado As Double
  Private mSaldo As Double
  Private mMora As Double
  Private mDeuda As Double
  Private mTotalAsignado As Double
  Private mTotalVencido As Double
  Private mTotalPagado As Double
  Private mTotalSaldo As Double
  Private mTotalMora As Double
  Private mTotalDeuda As Double
  Private mFecha As DateTime
#End Region

#Region "Propiedades"
    Public Property GradoSeccion() As String
        Get
            Return mGradoSeccion
        End Get
        Set(ByVal value As String)
            mGradoSeccion = value
        End Set
    End Property
    Public Property ApellidosNombres() As String
        Get
            Return mApellidosNombres
        End Get
        Set(ByVal value As String)
            mApellidosNombres = value
        End Set
    End Property
    Public Property Asignado() As Double
        Get
            Return mAsignado
        End Get
        Set(ByVal value As Double)
            mAsignado = value
        End Set
    End Property
    Public Property Vencido() As Double
        Get
            Return mVencido
        End Get
        Set(ByVal value As Double)
            mVencido = value
        End Set
    End Property
    Public Property Pagado() As Double
        Get
            Return mPagado
        End Get
        Set(ByVal value As Double)
            mPagado = value
        End Set
    End Property
    Public Property Saldo() As Double
        Get
            Return mSaldo
        End Get
        Set(ByVal value As Double)
            mSaldo = value
        End Set
    End Property
    Public Property Mora() As Double
        Get
            Return mMora
        End Get
        Set(ByVal value As Double)
            mMora = value
        End Set
    End Property
    Public Property Deuda() As Double
        Get
            Return mDeuda
        End Get
        Set(ByVal value As Double)
            mDeuda = value
        End Set
    End Property
    Public Property TotalAsignado() As Double
        Get
            Return mTotalAsignado
        End Get
        Set(ByVal value As Double)
            mTotalAsignado = value
        End Set
    End Property
    Public Property TotalVencido() As Double
        Get
            Return mTotalVencido
        End Get
        Set(ByVal value As Double)
            mTotalVencido = value
        End Set
    End Property
    Public Property TotalPagado() As Double
        Get
            Return mTotalPagado
        End Get
        Set(ByVal value As Double)
            mTotalPagado = value
        End Set
    End Property
    Public Property TotalSaldo() As Double
        Get
            Return mTotalSaldo
        End Get
        Set(ByVal value As Double)
            mTotalSaldo = value
        End Set
    End Property
    Public Property TotalMora() As Double
        Get
            Return mTotalMora
        End Get
        Set(ByVal value As Double)
            mTotalMora = value
        End Set
    End Property
    Public Property TotalDeuda() As Double
        Get
            Return mTotalDeuda
        End Get
        Set(ByVal value As Double)
            mTotalDeuda = value
        End Set
    End Property
    Public Property Fecha() As DateTime
        Get
            Return mFecha
        End Get
        Set(ByVal value As DateTime)
            mFecha = value
        End Set
    End Property
#End Region

#Region "Constructores"
  Sub New()
  End Sub
  Sub New(ByVal wGradoSeccion As String, ByVal wApellidosNombres As String, ByVal wAsignado As Double, ByVal wVencido As Double, _
          ByVal wPagado As Double, ByVal wSaldo As Double, ByVal wMora As Double, ByVal wDeuda As Double, ByVal wTotalAsignado As Double, _
          ByVal wTotalVencido As Double, ByVal wTotalPagado As Double, ByVal wTotalSaldo As Double, ByVal wTotalMora As Double, ByVal wTotalDeuda As Double, ByVal wFecha As DateTime)

    GradoSeccion = wGradoSeccion
    ApellidosNombres = wApellidosNombres
    Asignado = wAsignado
    Vencido = wVencido
    Pagado = wPagado
    Saldo = wSaldo
    Mora = wMora
    Deuda = wDeuda
    TotalAsignado = wTotalAsignado
    TotalVencido = wTotalVencido
    TotalPagado = wTotalPagado
    TotalSaldo = wTotalSaldo
    TotalMora = wTotalMora
    TotalDeuda = wTotalDeuda
    Fecha = wFecha

  End Sub
#End Region

End Class
