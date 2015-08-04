Public Class Seccion

#Region "Datos"
  Private mOGrado As Grado
  Private mOAnio As AnioLectivo
  Private mLetra As String
  Private mOTutor As Docente
  Private mDescripcion As String
  Private mOTurno As Turno
  Private mOAula As Aula
  Private mVacantes As Integer
  Private mVigencia As Boolean
#End Region

#Region "Propiedades"

  Public ReadOnly Property NumeroLetra() As String
    Get
      If Me.Grado IsNot Nothing Then
        Return Grado.Numero & " '" & Letra & "'"
      Else
        Return "TODAS LAS SECCIONES"
      End If
    End Get
  End Property

  Public ReadOnly Property NivelNumeroLetra() As String
    Get
      If Me.Grado IsNot Nothing Then
        Return Grado.Nivel.Siglas.Trim & " - " & IIf(Grado.Numero > 0, Grado.Numero, "").ToString & " " & Letra
      Else
        Return "TODAS LAS SECCIONES"
      End If
    End Get
  End Property

  Public ReadOnly Property NivelNumeroLetra2() As String
    Get
      If Me.Grado IsNot Nothing Then
        Return Grado.Nivel.Nombre.Trim & " - " & IIf(Grado.Numero > 0, Grado.Numero, "").ToString & " " & Letra
      Else
        Return "TODAS LAS SECCIONES"
      End If
    End Get
  End Property

  Public Property Vacantes() As Integer
    Get
      Return mVacantes
    End Get
    Set(ByVal value As Integer)
      mVacantes = value
    End Set
  End Property

  Public Property Grado() As Grado
    Get
      Return mOGrado
    End Get
    Set(ByVal value As Grado)
      mOGrado = value
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

  Public Property Letra() As String
    Get
      Return mLetra
    End Get
    Set(ByVal value As String)
      mLetra = value
    End Set
  End Property

  Public ReadOnly Property LetraCompleta() As String
    Get
      If Letra = "S" Then
        Return "Seleccionar Todas"
      Else
        Return Me.Letra
      End If
    End Get
  End Property

  Public Property Tutor() As Docente
    Get
      Return mOTutor
    End Get
    Set(ByVal value As Docente)
      mOTutor = value
    End Set
  End Property

  Public Property CodigoTutor() As Integer
    Get
      Return Me.Tutor.Codigo
    End Get
    Set(ByVal value As Integer)
      Me.Tutor = New Docente(value)
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

  Public Property Turno() As Turno
    Get
      Return Me.mOTurno
    End Get
    Set(ByVal value As Turno)
      Me.mOTurno = value
    End Set
  End Property

  Public Property CodigoTurno() As Integer
    Get
      Return Me.Turno.Codigo
    End Get
    Set(ByVal value As Integer)
      Me.Turno = New Turno(value)
    End Set
  End Property

  Public Property Aula() As Aula
    Get
      Return Me.mOAula
    End Get
    Set(ByVal value As Aula)
      Me.mOAula = value
    End Set
  End Property

  Public Property CodigoAula() As Integer
    Get
      Return Me.Aula.Codigo
    End Get
    Set(ByVal value As Integer)
      Me.Aula = New Aula(value)
    End Set
  End Property

  Public ReadOnly Property NombreTutor() As String
    Get
      Return Me.Tutor.NombreCompleto
    End Get
  End Property

  Public ReadOnly Property nombreTurno() As String
    Get
      Return Me.Turno.Nombre
    End Get
  End Property

  Public ReadOnly Property nombreGrado() As String
    Get
      Return Me.Grado.Nombre
    End Get
  End Property

  Public ReadOnly Property NombreNivel() As String
    Get
      Return Me.Grado.Nivel.Nombre
    End Get
  End Property

  Public Property Vigencia() As Boolean
    Get
      Return mVigencia
    End Get
    Set(ByVal value As Boolean)
      mVigencia = value
    End Set
  End Property

  Public ReadOnly Property Numero() As Integer
    Get
      Return mOGrado.Numero
    End Get
  End Property

  Public ReadOnly Property Tipo() As String
    Get
      Return mOAula.Tipo
    End Get
  End Property

  Public ReadOnly Property NumeroAula() As Integer
    Get
      Return mOAula.Numero
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

  Public ReadOnly Property TutorSeccion As String
    Get
      Return Me.Grado.Nivel.Siglas & " " & Me.Grado.Numero & "-" & Me.Letra & " - " & Me.Tutor.NombreCompleto
    End Get
  End Property

#End Region

#Region "Constructores"

  Public Sub New()
  End Sub

  Public Sub New(ByVal wCodigoG As Grado)
    mOGrado = wCodigoG
  End Sub

  Public Sub New(ByVal wcodigoG As Grado, ByVal wanio As AnioLectivo, ByVal wletra As Char, _
                 ByVal wvacantes As Integer, ByVal wvigencia As Boolean, ByVal wdescripcion As String, _
                 ByVal wcodigoTurno As Turno, ByVal wcodigoAula As Aula, ByVal wcodigoTutor As Docente)

    Me.Grado = wcodigoG
    Me.Anio = wanio
    Me.Letra = wletra
    Me.mVacantes = wvacantes
    Me.Vigencia = wvigencia
    Me.Descripcion = wdescripcion
    Me.Turno = wcodigoTurno
    Me.Aula = wcodigoAula
    Me.Tutor = wcodigoTutor
  End Sub

  Public Sub New(ByVal wGrado As Grado, ByVal wLetra As Char, ByVal wAula As Aula, ByVal wTurno As Turno, ByVal wTutor As Docente, _
          ByVal wVacantes As Integer, ByVal wDescripcion As String)

    Me.Grado = wGrado
    Me.Letra = wLetra
    Me.Turno = wTurno
    Me.Aula = wAula
    Me.Tutor = wTutor
    Me.Vacantes = wVacantes
    Me.Descripcion = wDescripcion
  End Sub

  Public Sub New(ByVal wAnio As AnioLectivo, ByVal wGrado As Grado, ByVal wLetra As String)
    Me.Anio = wAnio
    Me.Grado = wGrado
    Me.Letra = wLetra
  End Sub

  Public Sub New(ByVal wGrado As Grado, ByVal wAnio As String, ByVal wLetra As String, ByVal wTutor As Docente, _
                  ByVal wDescripcion As String, ByVal wCodigoTurno As Integer, ByVal wCodigoAula As Integer)
    mOGrado = wGrado
    mOAnio = New AnioLectivo(wAnio)
    mLetra = wLetra
    mOTutor = wTutor
    mDescripcion = wDescripcion
    mOTurno = New Turno(wCodigoTurno)
    mOAula = New Aula(wCodigoAula)
  End Sub

  Public Sub New(ByVal wCodigoGrado As Integer, ByVal wNumero As Integer, ByVal wCodigoNivel As Integer, ByVal wNombreNivel As String, _
               ByVal wLetra As String)
    Me.Grado = New Grado(wCodigoGrado, wNumero, "", New Nivel(wCodigoNivel, wNombreNivel, ""), "", "", "", "")
    Me.Letra = wLetra
  End Sub

  Public Sub New(ByVal wCodigoGrado As Integer, ByVal wNumero As Integer, ByVal wNivel As String, ByVal wLetra As String)
    Me.Grado = New Grado(wCodigoGrado, wNumero, "", New Nivel(0, wNivel, ""), "", "", "", "")
    Me.Letra = wLetra
  End Sub

  Public Sub New(ByVal wCodigoGrado As Integer, ByVal wanio As String, ByVal wletra As String)
    Me.mOGrado = New Grado(wCodigoGrado)
    Me.mOAnio = New AnioLectivo(wanio)
    Me.Letra = wletra
  End Sub

  Public Sub New(ByVal wVigencia As Boolean, ByVal wanio As AnioLectivo, ByVal wcodigoG As Grado, ByVal wletra As String, _
          ByVal wcodigoAula As Aula, ByVal wcodigoTurno As Turno, ByVal wcodigoTutor As Docente, _
          ByVal wvacantes As Integer, ByVal wdescripcion As String)

    Me.Anio = wanio
    Me.Grado = wcodigoG
    Me.Letra = wletra
    Me.Turno = wcodigoTurno
    Me.Aula = wcodigoAula
    Me.Tutor = wcodigoTutor
    Me.mVacantes = wvacantes
    Me.Descripcion = wdescripcion
    Me.Vigencia = wVigencia
  End Sub

  Public Sub New(ByVal wanio As AnioLectivo, ByVal wcodigoG As Grado, ByVal wletra As String, ByVal wcodigoTutor As Docente)

    Me.Anio = wanio
    Me.Grado = wcodigoG
    Me.Letra = wletra
    Me.Tutor = wcodigoTutor
  End Sub

  Public Sub New(ByVal wanio As AnioLectivo)
    Me.Anio = wanio
  End Sub

#End Region

End Class
