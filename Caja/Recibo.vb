Public Class Recibo

#Region "Datos"
  Private mNumeroRec As String
  Private mcodigoAlumno As String
  Private mAula As Integer
  Private mFecha As DateTime
  Private mGradoSec As String
  Private mTipoDoc As String
  Private mNumero As Integer
  Private mNombre As String
  Private mTotal As Double

  Private mDescripcion As String
  Private mMonto As Double
  Private mImporte As Double
  Private mDescuento As Double
  Private mDescuentoDesc As String
#End Region

#Region "Propiedades"

  Public Property NumeroRec() As String
    Get
      Return mNumeroRec
    End Get
    Set(ByVal value As String)
      mNumeroRec = value
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

  Public Property Importe() As Double
    Get
      Return mImporte
    End Get
    Set(ByVal value As Double)
      mImporte = value
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

  Public Property Nombre() As String
    Get
      Return mNombre
    End Get
    Set(ByVal value As String)
      mNombre = value
    End Set
  End Property

  Public Property Total() As Double
    Get
      Return mTotal
    End Get
    Set(ByVal value As Double)
      mTotal = value
    End Set
  End Property

  Public Property fecha() As DateTime
    Get
      Return mFecha
    End Get
    Set(ByVal value As DateTime)
      mFecha = value
    End Set
  End Property

  Public Property tipoDoc() As String
    Get
      Return mTipoDoc
    End Get
    Set(ByVal value As String)
      mTipoDoc = value
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

  Public Property DescuentoDesc() As String
    Get
      Return mDescuentoDesc
    End Get
    Set(ByVal value As String)
      mDescuentoDesc = value
    End Set
  End Property

  Public Property CodigoAlumno() As String
    Get
      Return mcodigoAlumno
    End Get
    Set(ByVal value As String)
      mcodigoAlumno = value
    End Set
  End Property

  Public Property Aula() As Integer
    Get
      Return mAula
    End Get
    Set(ByVal value As Integer)
      mAula = value
    End Set
  End Property

  Public Property GradoSec() As String
    Get
      Return mGradoSec
    End Get
    Set(ByVal value As String)
      mGradoSec = value
    End Set
  End Property

#End Region

#Region "Metodos"
  Sub New()

  End Sub

  Sub New(ByVal wNumero As Integer, ByVal wnombre As String, ByVal wtotal As Double, ByVal wImporte As Double, _
                ByVal wDescuento As Double, ByVal wfecha As DateTime, ByVal wNumeroRec As String, _
                ByVal wDescripcion As String, ByVal wMonto As Double, ByVal wtipoDoc As String, _
                ByVal wdescuentoDesc As String, ByVal wCodigoAlumno As String, ByVal waula As Integer, ByVal wGradoSec As String)
    Numero = wNumero
    Nombre = wnombre
    Total = wtotal
    Importe = wImporte
    Descuento = wDescuento
    fecha = wfecha
    NumeroRec = wNumeroRec
    Descripcion = wDescripcion
    Monto = wMonto
    tipoDoc = wtipoDoc
    DescuentoDesc = wdescuentoDesc
    CodigoAlumno = wCodigoAlumno
    Aula = waula
    GradoSec = wGradoSec
  End Sub

#End Region

End Class
