Public Class DetalleBeneficioDctoIngreso

#Region "Datos"
  Private mNroMatricula As Integer
  Private mBeneficio As Integer
  Private mNumeroDetBeneficio As Integer
  Private codigoDocumentoIngreso As Integer
  Private mNumero As Integer
#End Region

#Region "Propiedades"
  Public Property NroMatricula() As Integer
    Get
      Return mNroMatricula
    End Get
    Set(ByVal value As Integer)
      mNroMatricula = value
    End Set
  End Property
  Public Property Beneficio() As Integer
    Get
      Return mBeneficio
    End Get
    Set(ByVal value As Integer)
      mBeneficio = value
    End Set
  End Property
  Public Property NumeroDetBeneficio() As Integer
    Get
      Return mNumeroDetBeneficio
    End Get
    Set(ByVal value As Integer)
      mNumeroDetBeneficio = value
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
#End Region

#Region "Metodos"
  Sub New()

  End Sub
  Sub New(ByVal wnromatricula As Integer, ByVal wnumeroDetBeneficio As Integer, ByVal wBeneficio As Integer, _
          ByVal wCodigoDocumentoIngreso As Integer, ByVal wnumero As Integer)
    NroMatricula = wnromatricula
    NumeroDetBeneficio = wnumeroDetBeneficio
    Beneficio = wBeneficio
    codigoDocumentoIngreso = wCodigoDocumentoIngreso
    Numero = wnumero
  End Sub
#End Region

End Class
