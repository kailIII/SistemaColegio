Public Class ProgramacionPagoSeleccionar

  Private mProgramacion As ProgramacionPago
  Private mSeleccionado As Boolean


  Public Property ProgramacionPago() As ProgramacionPago
    Get
      Return mProgramacion
    End Get
    Set(ByVal value As ProgramacionPago)
      mProgramacion = value
    End Set
  End Property

  Public Property Seleccionado() As Boolean
    Get
      Return mSeleccionado
    End Get
    Set(ByVal value As Boolean)
      mSeleccionado = value
    End Set
  End Property

  Public ReadOnly Property Descripcion() As String
    Get
      Return Me.ProgramacionPago.Descripcion
    End Get
  End Property

  Public ReadOnly Property Vencimiento() As DateTime
    Get
      Return Me.ProgramacionPago.Vencimiento
    End Get
  End Property


  Public Sub New()

  End Sub

  Public Sub New(ByVal wProgramacion As ProgramacionPago)
    Me.ProgramacionPago = wProgramacion
    Me.Seleccionado = True
  End Sub

End Class
