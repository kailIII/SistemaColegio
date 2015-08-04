Public Class Matricula

#Region "Datos"

  Private mNumero As Integer
  Private mFecha As DateTime
  Private mOPersonal As Personal
  Private mOAlumno As Alumno
  Private mAnio As AnioLectivo
  Private mOGrado As Grado
  Private mLetra As String
  Private mOAlumnoApoderado As Alumno
  Private mOApoderado As Apoderado
  Private mPromedioFinal As Double
  Private mOrdenMeritoFinal As Integer
  Private mNroOrden As Integer
  Private mTipoMatricula As String
  Private mSituacionFinal As String
  Private mAcumuladoFinal As Integer
  Private mVigencia As Boolean
  Private mOParentesco As Parentesco

  Private mOSeccion As Seccion

  Private mAula As Integer
  Private mEstado As String
#End Region

#Region "Propiedades"

  Public Property Seccion() As Seccion
    Get
      Return Me.mOSeccion
    End Get
    Set(ByVal value As Seccion)
      Me.mOSeccion = value
    End Set
  End Property

  Public Property TipoMatricula() As String
    Get
      Return mTipoMatricula
    End Get
    Set(ByVal value As String)
      mTipoMatricula = value
    End Set
  End Property

  Public Property Parentesco() As Parentesco
    Get
      Return Me.mOParentesco
    End Get
    Set(ByVal value As Parentesco)
      Me.mOParentesco = value
    End Set
  End Property

  Public ReadOnly Property NombreParentesco() As String
    Get
      If Me.Parentesco IsNot Nothing Then
        Return Me.Parentesco.Parentesco
      Else
        Return ""
      End If
    End Get
  End Property

  Public Property Numero() As Integer
    Get
      Return mNumero
    End Get
    Set(ByVal value As Integer)
      mNumero = value
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

  Public Property Grado() As Grado
    Get
      Return mOGrado
    End Get
    Set(ByVal value As Grado)
      mOGrado = value
    End Set
  End Property

  Public Property Personal() As Personal
    Get
      Return mOPersonal
    End Get
    Set(ByVal value As Personal)
      mOPersonal = value
    End Set
  End Property

  Public Property Alumno() As Alumno
    Get
      Return mOAlumno
    End Get
    Set(ByVal value As Alumno)
      mOAlumno = value
    End Set
  End Property

  Public Property Anio() As AnioLectivo
    Get
      Return mAnio
    End Get
    Set(ByVal value As AnioLectivo)
      mAnio = value
    End Set
  End Property

  Public ReadOnly Property VerAnio() As String
    Get
      Return Me.Seccion.Anio.Anio
    End Get
  End Property

  Public Property Letra() As String
    Get
      Return mLetra
    End Get
    Set(ByVal value As String)
      mLetra = value
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

  Public Property PromedioFinal() As Double
    Get
      Return mPromedioFinal
    End Get
    Set(ByVal value As Double)
      mPromedioFinal = value
    End Set
  End Property

  Public Property OrdenMeritoFinal() As Integer
    Get
      Return mOrdenMeritoFinal
    End Get
    Set(ByVal value As Integer)
      mOrdenMeritoFinal = value
    End Set
  End Property

  Public Property NroOrden() As Integer
    Get
      Return mNroOrden
    End Get
    Set(ByVal value As Integer)
      mNroOrden = value
    End Set
  End Property

  Public Property NroOrden2() As Integer
    Get
      If Me.vigencia Then
        Return mNroOrden
      Else
        Return 0
      End If
    End Get
    Set(ByVal value As Integer)
      mNroOrden = value
    End Set
  End Property

  Public Property SituacioFinal() As String
    Get
      Return mSituacionFinal
    End Get
    Set(ByVal value As String)
      mSituacionFinal = value
    End Set
  End Property

  Public ReadOnly Property LeerSituacion() As String
    Get
      Dim cadena As String = ""
      Select Case mSituacionFinal.Trim
        Case "C" : cadena = "Concluyo"
        Case "R" : cadena = "Retirado"
        Case "T" : cadena = "Trasladado"
        Case "F" : cadena = "Fallecido"
        Case "P" : cadena = "Promovido"
        Case "RG" : cadena = "Repite Grado"
        Case "RR" : cadena = "Requiere Recuperación"
        Case "A" : cadena = "Aprobado"
        Case "D" : cadena = "Desaprobado"
        Case "PP" : cadena = "Postergación de Evaluación"
        Case "XX" : cadena = ""
      End Select
      Return cadena
    End Get
  End Property

  Public Property AcumuladoFinal() As Integer
    Get
      Return mAcumuladoFinal
    End Get
    Set(ByVal value As Integer)
      mAcumuladoFinal = value
    End Set
  End Property

  Public Property codigoAlumnoApoderado() As Alumno
    Get
      Return mOAlumnoApoderado
    End Get
    Set(ByVal value As Alumno)
      mOAlumnoApoderado = value
    End Set
  End Property

  Public Property codigoApoderado() As Apoderado
    Get
      Return mOApoderado
    End Get
    Set(ByVal value As Apoderado)
      mOApoderado = value
    End Set
  End Property

  Public ReadOnly Property VisualizarVigencia() As String
    Get
      If Me.vigencia = True Then
        Return "Si"
      Else
        Return "No"
      End If
    End Get
  End Property

  Public Property Estado() As String
    Get
      Return Me.mEstado
    End Get
    Set(ByVal value As String)
      Me.mEstado = value
    End Set
  End Property

  Public ReadOnly Property DescripcionEstado() As String
    Get
      Dim desc As String = ""
      If Me.Estado = "C" Then
        desc = "Confirmada"
      ElseIf Me.Estado = "P" Then
        desc = "Por confirmar"
      End If
      Return desc
    End Get
  End Property

#Region "Datos Alumno"

  Public ReadOnly Property NombreAlumno() As String
    Get
      Return Me.Alumno.NombreCompleto
    End Get
  End Property

  Public Property CodigoRecaudacion() As String
    Get
      Return Me.Alumno.CodigoRecaudacion
    End Get
    Set(ByVal value As String)
      Me.Alumno.CodigoRecaudacion = value
    End Set
  End Property

  Public ReadOnly Property TelefonoAlumno() As String
    Get
      Return Me.Alumno.Telefono
    End Get
  End Property

  Public ReadOnly Property DireccionAlumno() As String
    Get
      Return Me.Alumno.Direccion
    End Get
  End Property

  Public ReadOnly Property EmailAlumno() As String
    Get
      Return Me.Alumno.Email
    End Get
  End Property

  Public ReadOnly Property FechaNacimientoAlumno() As DateTime
    Get
      Return Me.Alumno.FechaNacimiento
    End Get
  End Property

#End Region

#Region "Padre"

  Public ReadOnly Property NombrePadre() As String
    Get
      If Me.Alumno.Padre IsNot Nothing Then
        Return Me.Alumno.Padre.NombreCompleto
      Else
        Return ""
      End If
    End Get
  End Property

  Public ReadOnly Property TelefonoCasaPadre() As String
    Get
      If Me.Alumno.Padre IsNot Nothing Then
        Return Me.Alumno.Padre.TelefonoCasa
      Else
        Return ""
      End If
    End Get
  End Property

  Public ReadOnly Property TelefonoTrabajoPadre() As String
    Get
      If Me.Alumno.Padre IsNot Nothing Then
        Return Me.Alumno.Padre.TelefonoTrabajo
      Else
        Return ""
      End If
    End Get
  End Property

  Public ReadOnly Property CelularPadre() As String
    Get
      If Me.Alumno.Padre IsNot Nothing Then
        Return Me.Alumno.Padre.Celular
      Else
        Return ""
      End If
    End Get
  End Property

  Public ReadOnly Property CorreoPadre() As String
    Get
      If Me.Alumno.Padre IsNot Nothing Then
        Return Me.Alumno.Padre.Email
      Else
        Return ""
      End If
    End Get
  End Property

  Public ReadOnly Property DescripcionVivePadre() As String
    Get
      If Me.Alumno.Padre IsNot Nothing Then
        If Me.Alumno.Padre.Vive = True Then
          Return "Si"
        Else
          Return "No"
        End If
      Else
        Return ""
      End If
    End Get
  End Property

#End Region

#Region "Madre"

  Public ReadOnly Property NombreMadre() As String
    Get
      If Me.Alumno.Madre IsNot Nothing Then
        Return Me.Alumno.Madre.NombreCompleto
      Else
        Return ""
      End If
    End Get
  End Property

  Public ReadOnly Property TelefonoCasaMadre() As String
    Get
      If Me.Alumno.Madre IsNot Nothing Then
        Return Me.Alumno.Madre.TelefonoCasa
      Else
        Return ""
      End If
    End Get
  End Property

  Public ReadOnly Property TelefonoTrabajoMadre() As String
    Get
      If Me.Alumno.Madre IsNot Nothing Then
        Return Me.Alumno.Madre.TelefonoTrabajo
      Else
        Return ""
      End If
    End Get
  End Property

  Public ReadOnly Property CelularMadre() As String
    Get
      If Me.Alumno.Madre IsNot Nothing Then
        Return Me.Alumno.Madre.Celular
      Else
        Return ""
      End If
    End Get
  End Property

  Public ReadOnly Property CorreoMadre() As String
    Get
      If Me.Alumno.Madre IsNot Nothing Then
        Return Me.Alumno.Madre.Email
      Else
        Return ""
      End If
    End Get
  End Property

  Public ReadOnly Property DescripcionViveMadre() As String
    Get
      If Me.Alumno.Madre IsNot Nothing Then
        If Me.Alumno.Madre.Vive = True Then
          Return "Si"
        Else
          Return "No"
        End If
      Else
        Return ""
      End If
    End Get
  End Property

#End Region

#Region "Datos Apoderado"

  Public ReadOnly Property NombreApoderado() As String
    Get
      If Me.mOApoderado IsNot Nothing Then
        Return Me.mOApoderado.NombreCompleto
      Else
        Return ""
      End If
    End Get
  End Property

  Public ReadOnly Property LugarTrabajo() As String
    Get
      If Me.mOApoderado IsNot Nothing Then
        Return Me.mOApoderado.LugarTrabajo
      Else
        Return ""
      End If
    End Get
  End Property

  Public ReadOnly Property NombreOcupacion() As String
    Get
      If Me.mOApoderado IsNot Nothing Then
        Return Me.mOApoderado.Ocupacion.Nombre
      Else
        Return ""
      End If
    End Get
  End Property

  Public ReadOnly Property NombreProfesion() As String
    Get
      If Me.mOApoderado IsNot Nothing Then
        Return Me.mOApoderado.Profesion.Nombre
      Else
        Return ""
      End If

    End Get
  End Property

  Public ReadOnly Property TelefonoCasaApoderado() As String
    Get
      If Me.mOApoderado IsNot Nothing Then
        Return Me.codigoApoderado.TelefonoCasa
      Else
        Return ""
      End If

    End Get
  End Property

  Public ReadOnly Property TelefonoTrabajoApoderado() As String
    Get
      If Me.mOApoderado IsNot Nothing Then
        Return Me.codigoApoderado.TelefonoTrabajo
      Else
        Return ""
      End If

    End Get
  End Property

  Public ReadOnly Property CelularApoderado() As String
    Get
      If Me.mOApoderado IsNot Nothing Then
        Return Me.codigoApoderado.Celular
      Else
        Return ""
      End If

    End Get
  End Property

  Public ReadOnly Property CorreoApoderado() As String
    Get
      If Me.mOApoderado IsNot Nothing Then
        Return Me.codigoApoderado.Email
      Else
        Return ""
      End If

    End Get
  End Property

  Public ReadOnly Property DireccionApoderado() As String
    Get
      If Me.mOApoderado IsNot Nothing Then
        Return Me.codigoApoderado.Direccion
      Else
        Return ""
      End If

    End Get
  End Property

#End Region

  Public WriteOnly Property Sexo() As String
    Set(ByVal value As String)
      mOAlumno.Sexo = value
    End Set
  End Property

  Public ReadOnly Property LeerSexo() As String
    Get
      Dim s As String
      If mOAlumno.Sexo = "M" Then
        s = "Masculino"
      Else
        s = "Femenino"
      End If
      Return s
    End Get
  End Property

  Public ReadOnly Property LeerSexo2() As String
    Get
      Return mOAlumno.Sexo
    End Get
  End Property

  Public ReadOnly Property CodigoTutor() As Integer
    Get
      Return mOApoderado.Codigo
    End Get
  End Property

  Public Property Aula() As Integer
    Get
      Return mAula
    End Get
    Set(ByVal value As Integer)
      mAula = value
    End Set
  End Property

  Public ReadOnly Property GradoSeccion() As String
    Get
      If Me.Grado.Nivel.Nombre.Length > 0 AndAlso Me.Grado.Numero > 0 And Me.Letra.Length > 0 Then
        Return Me.Grado.Nivel.Nombre & " - " & Me.Grado.Numero.ToString & " - " & Me.Letra
      Else
        Return "TODOS"
      End If
    End Get
  End Property

  Public ReadOnly Property NivelGradoSeccion() As String
    Get
      Return Me.Seccion.Grado.Nivel.Siglas & " - " & Me.Seccion.Grado.Numero.ToString & " - " & Me.Seccion.Letra
    End Get
  End Property

  Public ReadOnly Property MostrarGradoSec() As String
    Get
      If Me.Grado.Nivel.Codigo = 1 Then
        Return "I" + Me.Grado.Numero.ToString + Me.Letra
      Else
        If Me.Grado.Nivel.Codigo = 2 Then
          Return "P" + Me.Grado.Numero.ToString + Me.Letra
        Else
          Return "S" + Me.Grado.Numero.ToString + Me.Letra
        End If
      End If
    End Get
  End Property

  Public ReadOnly Property NombreResponsable() As String
    Get
      Dim responsable As String = ""

      If Me.Personal IsNot Nothing Then
        responsable = Me.Personal.NombreCompleto
      End If

      Return responsable
    End Get
  End Property

#End Region

#Region "Constructores"

  Public Sub New()
  End Sub

  Public Sub New(ByVal wNumero As Integer)
    Me.Numero = wNumero
  End Sub

  Public Sub New(ByVal wNumero As Integer, ByVal wFecha As DateTime, ByVal wcodigoAlumno As Alumno, ByVal wcodigoApoderado As Apoderado, _
          ByVal wvigencia As Boolean, ByVal wcodigoPersonal As Personal, ByVal wAnio As AnioLectivo, ByVal wGrado As Grado, _
          ByVal wSituacion As String, ByVal wNroOrden As Integer)
    Me.Fecha = wFecha
    Me.Numero = wNumero
    Me.Alumno = wcodigoAlumno
    Me.Personal = wcodigoPersonal
    Me.codigoApoderado = wcodigoApoderado
    Me.vigencia = wvigencia
    Me.Anio = wAnio
    Me.Grado = wGrado
    Me.SituacioFinal = wSituacion
    Me.NroOrden = wNroOrden
  End Sub

  Public Sub New(ByVal wNumero As Integer, ByVal wFecha As DateTime, ByVal wcodigoAlumno As Alumno, ByVal wcodigoApoderado As Apoderado, _
          ByVal wvigencia As Boolean, ByVal wcodigoPersonal As Personal, ByVal wnroOrden As Integer)
    Me.Fecha = wFecha
    Me.Numero = wNumero
    Me.Alumno = wcodigoAlumno
    Me.Personal = wcodigoPersonal
    Me.codigoApoderado = wcodigoApoderado
    Me.vigencia = wvigencia
    Me.NroOrden = wnroOrden
  End Sub

  Public Sub New(ByVal wNumero As Integer, ByVal wFecha As DateTime, ByVal wcodigoG As Grado, _
                 ByVal wcodigoAlumno As Alumno, ByVal wcodigoPersonal As Personal, ByVal wanio As AnioLectivo, _
                 ByVal wletra As String, ByVal wvigencia As Boolean, ByVal wpromFinal As Double, _
                 ByVal wOrdenMeritoFinal As Integer, ByVal wnroOrden As Integer, ByVal wacumuladoFinal As Integer, _
                 ByVal wcodigoAlumnoApoderado As Alumno, ByVal wcodigoApoderado As Parentesco)

    Me.Numero = wNumero
    Me.Fecha = wFecha
    Me.Grado = wcodigoG
    Me.Personal = wcodigoPersonal
    Me.Alumno = wcodigoAlumno
    Me.mOParentesco = wcodigoApoderado
    Me.Anio = wanio
    Me.Letra = wletra
    Me.vigencia = wvigencia
    Me.PromedioFinal = wpromFinal
    Me.OrdenMeritoFinal = wOrdenMeritoFinal
    Me.NroOrden = wnroOrden
    Me.AcumuladoFinal = wacumuladoFinal
  End Sub

  Public Sub New(ByVal wfechaMat As DateTime, ByVal wcodigoG As Grado, ByVal wcodigoAlumno As Alumno, _
                 ByVal wcodigoPersonal As Personal, ByVal wanio As AnioLectivo, ByVal wletra As String, _
                 ByVal wvigencia As Boolean, ByVal wpromFinal As Double, _
                 ByVal wOrdenMeritoFinal As Integer, ByVal wnroOrden As Integer, _
                 ByVal wacumuladoFinal As Integer, ByVal wcodigoAlumnoApoderado As Alumno, _
                 ByVal wcodigoApoderado As Apoderado)

    Me.Fecha = wfechaMat
    Me.Grado = wcodigoG
    Me.Alumno = wcodigoAlumno
    Me.Personal = wcodigoPersonal
    Me.Anio = wanio
    Me.Letra = wletra
    Me.vigencia = wvigencia
    Me.PromedioFinal = wpromFinal
    Me.OrdenMeritoFinal = wOrdenMeritoFinal
    Me.NroOrden = wnroOrden
    Me.AcumuladoFinal = wacumuladoFinal
    Me.codigoAlumnoApoderado = wcodigoAlumnoApoderado
    Me.codigoApoderado = wcodigoApoderado
  End Sub

  Public Sub New(ByVal wnroMatricula As Integer, ByVal wcodigoAlumno As Alumno, ByVal wnroOrden As Integer)
    Me.Numero = wnroMatricula
    Me.Alumno = wcodigoAlumno
    Me.NroOrden = wnroOrden
  End Sub

  Public Sub New(ByVal wnroMatricula As Integer, ByVal wcodigoAlumno As Alumno, ByVal wnroOrden As Integer, _
                 ByVal wVigencia As Boolean)
    Me.Numero = wnroMatricula
    Me.Alumno = wcodigoAlumno
    Me.NroOrden = wnroOrden
    Me.vigencia = wVigencia
  End Sub

  Public Sub New(ByVal wNroMatricula As Integer, ByVal wFecha As DateTime, ByVal wGrado As Grado, ByVal wAlumno As Alumno, _
                 ByVal wAnio As AnioLectivo, ByVal wLetra As String, ByVal wPromedioFinal As Double, ByVal wVigencia As Boolean)

    Me.Numero = wNroMatricula
    Me.Fecha = wFecha
    Me.Grado = wGrado
    Me.Alumno = wAlumno
    Me.Anio = wAnio
    Me.Letra = wLetra
    Me.PromedioFinal = wPromedioFinal
    Me.vigencia = wVigencia
  End Sub

  Public Sub New(ByVal wNroMatricula As Integer, ByVal wFecha As DateTime, ByVal wGrado As Grado, ByVal wPersonal As Personal, _
                 ByVal wAlumno As Alumno, ByVal wAnio As AnioLectivo, ByVal wLetra As String, ByVal wPromedioFinal As Double, _
                 ByVal wOrdenMeritoFinal As Integer, ByVal wNroOrden As Integer, ByVal wAcumuladoFinal As Integer, ByVal wVigencia As Boolean, ByVal wSexo As String, ByVal wSituacion As String)
    Me.Numero = wNroMatricula
    Me.Fecha = wFecha
    Me.Grado = wGrado
    Me.Personal = wPersonal
    Me.Alumno = wAlumno
    Me.Anio = wAnio
    Me.Letra = wLetra
    Me.PromedioFinal = wPromedioFinal
    Me.OrdenMeritoFinal = wOrdenMeritoFinal
    Me.NroOrden = wNroOrden
    Me.AcumuladoFinal = wAcumuladoFinal
    Me.vigencia = wVigencia
    Me.Sexo = wSexo
    Me.SituacioFinal = wSituacion
  End Sub

  Public Sub New(ByVal wfechaMat As DateTime, ByVal wcodigoG As Grado, ByVal wcodigoAlumno As Alumno, _
                  ByVal wcodigoPersonal As Personal, ByVal wanio As AnioLectivo, ByVal wletra As String, _
                  ByVal wvigencia As Boolean, ByVal wpromFinal As Double, _
                  ByVal wOrdenMeritoFinal As Integer, ByVal wnroOrden As Integer, _
                  ByVal wacumuladoFinal As Integer, ByVal wcodigoAlumnoApoderado As Alumno, _
                  ByVal wcodigoApoderado As Parentesco, ByVal wSituacion As String)

    Me.Fecha = wfechaMat
    Me.Grado = wcodigoG
    Me.Alumno = wcodigoAlumno
    Me.Personal = wcodigoPersonal
    Me.Anio = wanio
    Me.Letra = wletra
    Me.vigencia = wvigencia
    Me.PromedioFinal = wpromFinal
    Me.OrdenMeritoFinal = wOrdenMeritoFinal
    Me.NroOrden = wnroOrden
    Me.AcumuladoFinal = wacumuladoFinal
    Me.codigoAlumnoApoderado = wcodigoAlumnoApoderado
    Me.mOParentesco = wcodigoApoderado
    Me.SituacioFinal = wSituacion
  End Sub

#End Region

End Class
