
Public Class RNMatricula
  Inherits CADO

  Public Function ListarAlumno(ByVal wSeccion As Seccion) As List(Of Matricula)
    Dim lm As New List(Of Matricula)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lMatriculaAlumno", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@anio", wSeccion.Anio.Anio)
    cmd.Parameters.AddWithValue("@codigoG", wSeccion.Grado.Codigo)
    cmd.Parameters.AddWithValue("@letra", wSeccion.Letra)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        lm.Add(New Matricula(CInt(dr.Item("nroMatricula")), New Alumno(0, CStr(dr.Item("nombre")), _
                CStr(dr.Item("apellidoPat")), CStr(dr.Item("apellidoMat")), ""), _
                CInt(dr.Item("nroOrden")), True))
        With lm.Item(lm.Count - 1)
          .Alumno.Sexo = dr.Item("Sexo").ToString
          .Alumno.FechaNacimiento = CDate(dr.Item("FechaNac"))
          .Alumno.CodigoRecaudacion = dr.Item("CodigoRecaudacion").ToString
        End With
      End While
      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
    Return lm
  End Function

  Public Function Listar(ByVal wSec As Seccion) As List(Of Matricula)
    Dim lm As New List(Of Matricula)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liMatriculaSeccion", cn)
    Dim dr As SqlDataReader = Nothing
    Dim fecha As DateTime

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@anio", wSec.Anio.Anio)
    cmd.Parameters.AddWithValue("@codigoG", wSec.Grado.Codigo)
    cmd.Parameters.AddWithValue("@letra", wSec.Letra)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      fecha = Now
      While dr.Read
        lm.Add(New Matricula(CInt(dr.Item("nroMatricula")), CDate(dr.Item("fechaMat")), _
                     New Alumno(CInt(dr.Item("codigoAlumno")), CStr(dr.Item("nombre")), _
                                CStr(dr.Item("apellidoPat")), CStr(dr.Item("apellidoMat")), _
                                dr.Item("sexo").ToString, fecha, CStr(dr.Item("codigoEducando")), Nothing), _
                      New Apoderado(CInt(dr.Item("codigoApoderado"))), _
                      CBool(dr.Item("vigencia")), New Personal(CInt(dr.Item("codigoPersonal"))) _
                , wSec.Anio, wSec.Grado, "", CInt(dr.Item("nroOrden"))))
        With lm.Item(lm.Count - 1)
          .Estado = dr.Item("estado").ToString
          With .Personal
            .ApellidoPaterno = dr.Item("ResApellidoPat").ToString
            .ApellidoMaterno = dr.Item("ResApellidoMat").ToString
            .Nombre = dr.Item("ResNombre").ToString
          End With
        End With
      End While
      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
    Return lm
  End Function

  Public Function Listar(ByVal wAlumno As Alumno) As List(Of Matricula)
    Dim lm As List(Of Matricula)
    Dim m As Matricula
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader = Nothing
    Dim iNro As Integer, iAnio As Integer, iNivel As Integer, iGrado As Integer, iSeccion As Integer

    pars.Add(New CParametro("@Alumno", wAlumno.Codigo))

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_ListarMatricula_Alumno", pars)

      iNro = dr.GetOrdinal("nroMatricula")
      iAnio = dr.GetOrdinal("Anio")
      iNivel = dr.GetOrdinal("NombreNivel")
      iGrado = dr.GetOrdinal("Numero")
      iSeccion = dr.GetOrdinal("Letra")

      lm = New List(Of Matricula)
      While dr.Read
        m = New Matricula
        m.Numero = dr.GetInt16(iNro)
        m.Seccion = New Seccion
        With m.Seccion
          .Grado = New Grado
          .Grado.Numero = dr.GetByte(iGrado)
          .Grado.Nivel = New Nivel(0, dr.GetString(iNivel), "")
          .Letra = dr.GetString(iSeccion)
          .Anio = New AnioLectivo(dr.GetInt16(iAnio).ToString)

          m.Grado = .Grado
          m.Letra = m.Seccion.Letra
          m.Anio = m.Seccion.Anio
        End With

        lm.Add(m)
      End While
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(True)
      Throw ex
    Finally
      dr = Nothing
      pars = Nothing
    End Try

    Return lm
  End Function

  Public Sub Registrar(ByVal objMat As Matricula, ByVal objApd As Parentesco)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmdMat As New SqlCommand("pr_iMatricula", cn)

    '-----------------------------REGISTRO DE APODERADO---------------------------------
    cmdMat.CommandType = CommandType.StoredProcedure

    With cmdMat.Parameters
      .AddWithValue("@fechaMat", objMat.Fecha)
      .AddWithValue("@codigoG", objMat.Grado.Codigo)
      .AddWithValue("@codigoAlumno", objMat.Alumno.Codigo)
      .AddWithValue("@codigoPersonal", objMat.Personal.Codigo)
      .AddWithValue("@anio", objMat.Anio.Anio)
      .AddWithValue("@letra", CChar(objMat.Letra))
      .AddWithValue("@vigencia", objMat.vigencia)
      .AddWithValue("@promFinal", objMat.PromedioFinal)
      .AddWithValue("@OrdenMeritoFinal", objMat.OrdenMeritoFinal)
      .AddWithValue("@nroOrden", objMat.NroOrden)
      .AddWithValue("@acumuladoFinal", 0)
      .AddWithValue("@codigoAlumnoApoderado", objMat.Alumno.Codigo)
      .AddWithValue("@codigoApoderado", objApd.Apoderado.Codigo)
      .AddWithValue("@Situacion", objMat.SituacioFinal)
      .AddWithValue("@tipoMatricula", objMat.TipoMatricula)
    End With

    Try
      cn.Open()

      cmdMat.ExecuteNonQuery()
      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally
      cmdMat.Dispose()
      cmdMat = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
  End Sub

  Public Sub Modificar(ByVal wm As Matricula)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aMatricula", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@nroMatricula", wm.Numero)
      .AddWithValue("@fechaMat", wm.Fecha)
      .AddWithValue("@codigoG", wm.Grado.Codigo)
      .AddWithValue("@codigoPersonal", wm.Personal.Codigo)
      .AddWithValue("@codigoAlumno", wm.Alumno.Codigo)
      .AddWithValue("@anio", wm.Anio.Anio)
      .AddWithValue("@letra", wm.Letra)
      .AddWithValue("@vigencia", wm.vigencia)
      .AddWithValue("@promFinal", wm.PromedioFinal)
      .AddWithValue("@OrdenMeritoFinal", wm.OrdenMeritoFinal)
      .AddWithValue("@nroOrden", wm.NroOrden)
      .AddWithValue("@acumuladoFinal", wm.AcumuladoFinal)
      .AddWithValue("@codigoAlumnoApoderado", wm.Alumno.Codigo)
      .AddWithValue("@codigoApoderado", wm.Parentesco.Apoderado.Codigo)
    End With
    Try
      cn.Open()
      cmd.ExecuteNonQuery()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
  End Sub

  Public Sub ModificarVigencia(ByVal wnroMat As Integer, ByVal wvig As Integer)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aMatriculaVigencia", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@nroMatricula", wnroMat)
      .AddWithValue("@vigencia", wvig)
    End With
    Try
      cn.Open()
      cmd.ExecuteNonQuery()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
  End Sub

  Public Sub GenerarNumerodeOrden(ByVal wsec As Seccion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aMatriculaGenerarNroOrden", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@anio", wsec.Anio.Anio)
      .AddWithValue("@codigoG", wsec.Grado.Codigo)
      .AddWithValue("@letra", wsec.Letra)
    End With
    Try
      cn.Open()
      cmd.ExecuteNonQuery()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
  End Sub

  Public Function ListarMatriculas(ByVal obj As AnioLectivo) As Integer
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liMatriculas", cn)
    Dim dr As Integer

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Anio", obj.Anio)
    Try
      cn.Open()
      dr = CInt(cmd.ExecuteScalar)
      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
    Return dr
  End Function

  Public Function LeerAnioGradoSeccion(ByVal obj As Matricula) As Matricula
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lAnioGradoSec", cn)
    Dim dr As SqlDataReader = Nothing
    Dim m As New Matricula
    Dim fecha As Date

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@nroMat", obj.Numero)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read Then
        m = New Matricula(0, fecha, New Grado(0, CInt(dr.Item("numero")), dr.GetString(dr.GetOrdinal("nombreNivel")), _
                                              Nothing, "", "", "", ""), Nothing,
                                            New AnioLectivo(dr.GetInt16(dr.GetOrdinal("anio")).ToString), _
                                            dr.GetString(dr.GetOrdinal("letra")), 0, False)
      End If
      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
    Return m
  End Function

  Public Function LeerSgteGrado(ByVal obj As Matricula) As Matricula
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lSgteGradoAlu", cn)
    Dim dr As SqlDataReader = Nothing
    Dim M As Matricula = Nothing
    Dim fecha As Date

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoAlu", obj.Alumno.Codigo)
      .AddWithValue("@Anio", obj.Anio.Anio)
    End With
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      If dr.Read Then
        M = New Matricula(fecha, New Grado(0, dr.GetInt16(dr.GetOrdinal("numero")), "", _
                          New Nivel(Nothing, dr.GetString(dr.GetOrdinal("nombreNivel")), ""), "", "", "", ""), _
                          New Alumno(), New Personal(), New AnioLectivo(), dr.GetString(dr.GetOrdinal("letra")), _
                          CBool(0), 0, 0, 0, 0, New Alumno(), New Parentesco(), _
                          dr.GetString(dr.GetOrdinal("situacionFinal")))
      End If

      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try

    Return M
  End Function

  Public Function LeerNroMatriculasAlu(ByVal obj As Alumno) As Integer
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lNroMatriculas", cn)
    Dim dr As Integer

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Codigo", obj.Codigo)
    Try
      cn.Open()
      dr = CInt(cmd.ExecuteScalar)
      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
    Return dr
  End Function

  Public Function Leer(ByVal wAlumno As Alumno, ByVal wAnio As AnioLectivo) As Matricula
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lMatAnioActual", cn)
    Dim dr As SqlDataReader
    Dim mat As Matricula = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Codigo", wAlumno.Codigo)
    cmd.Parameters.AddWithValue("@Anio", wAnio.Anio)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read Then
        mat = New Matricula
        mat.Numero = CInt(dr.Item("NroMatricula"))
        mat.Grado = New Grado(CInt(dr.Item("CodigoG")))
        mat.Grado.Numero = CInt(dr.Item("Numero"))
        mat.Grado.Nivel = New Nivel() With {.Codigo = CInt(dr.Item("codigoNivel")), .Siglas = dr.Item("Siglas").ToString}
        mat.Letra = dr.Item("Letra").ToString
        mat.Anio = wAnio
        mat.Seccion = New Seccion With {.Anio = wAnio, .Grado = mat.Grado, .Letra = mat.Letra}
        mat.TipoMatricula = dr.Item("TipoMatricula").ToString
        mat.codigoApoderado = New Apoderado
        mat.codigoApoderado.Codigo = CInt(dr.Item("CodigoApoderado"))
      End If
      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try

    Return mat
  End Function

  Public Function ListarAlumnos(ByVal obj As AnioLectivo) As List(Of Matricula)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liMatriculasAlum", cn)
    Dim la As New List(Of Matricula)
    Dim dr As SqlDataReader = Nothing
    Dim fecha As Date

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Anio", obj.Anio)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        la.Add(New Matricula(CDate(fecha), _
                              New Grado(0, CInt(dr.Item("numero")), "",
                                        New Nivel(CInt(dr.Item("codigoNivel")), dr.GetString(dr.GetOrdinal("nombreNivel")), ""),
                                        "", "", "", ""), _
                              New Alumno(CInt(dr.Item("codigoPersona")), dr.GetString(dr.GetOrdinal("nombre")),
                                        dr.GetString(dr.GetOrdinal("apellidoPat")), dr.GetString(dr.GetOrdinal("apellidoMat"))),
                              Nothing, Nothing, dr.GetString(dr.GetOrdinal("letra")), False, 0.0, 0, 0, 0, Nothing, _
                              Nothing, dr.GetString(dr.GetOrdinal("situacionFinal"))))
        With la.Item(la.Count - 1)
          .Seccion = New Seccion With {.Grado = la.Item(la.Count - 1).Grado, .Letra = la.Item(la.Count - 1).Letra}
          .Seccion.Grado.Nivel.Siglas = dr.Item("Siglas").ToString
          .Alumno.FechaNacimiento = CDate(dr.Item("FechaNac"))
          .Alumno.CodigoEducando = dr.Item("CodigoEducando").ToString
          If dr.IsDBNull(dr.GetOrdinal("DNI")) = False Then
            .Alumno.DNI = dr.GetString(dr.GetOrdinal("DNI"))
          End If
        End With
      End While

      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
    Return la
  End Function

  Public Sub ActualizarSecMat(ByVal obj As Matricula)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aMatriculaSec", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Anio", obj.Anio.Anio)
      .AddWithValue("@CodigoAlu", obj.Alumno.Codigo)
      .AddWithValue("@CodigoG", obj.Grado.Codigo)
      .AddWithValue("@Letra", obj.Letra)
      .AddWithValue("@Vigencia", obj.vigencia)
    End With

    Try
      cn.Open()
      cmd.ExecuteNonQuery()
      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try

  End Sub

  Public Function ListarAlumnosGrado(ByVal obj As Seccion) As List(Of Matricula)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAlumnosGrado", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lm As List(Of Matricula) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Anio", obj.Anio.Anio)
      .AddWithValue("@CodigoG", obj.Grado.Codigo)
    End With

    Try
      cn.Open()
      lm = New List(Of Matricula)
      dr = cmd.ExecuteReader
      Do While dr.Read
        lm.Add(New Matricula(CInt(dr.Item("nroMatricula")), CDate(dr.Item("fechaMat")), New Grado(), New Personal(CInt(dr.Item("codigoPersonal"))), _
                          New Alumno(CInt(dr.Item("codigoAlumno")), CStr(dr.Item("nombre")), _
                                                CStr(dr.Item("apellidoPat")), CStr(dr.Item("apellidoMat")), _
                                                CStr(dr.Item("codigoEducando"))), _
                             New AnioLectivo(), CChar(dr.Item("letra")), 0, 0, 0, 0, CBool(dr.Item("vigencia")), dr.Item("sexo").ToString, ""))
      Loop
      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
    Return lm
  End Function

  Public Function ListarAlumnosSeccion(ByVal obj As Seccion) As List(Of Matricula)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAlumnosSeccion", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lm As List(Of Matricula) = Nothing

    With cmd.Parameters
      .AddWithValue("@Anio", obj.Anio.Anio)
      .AddWithValue("@CodigoG", obj.Grado.Codigo)
      .AddWithValue("@Letra", obj.Letra)
    End With
    cmd.CommandType = CommandType.StoredProcedure

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lm = New List(Of Matricula)
      Do While dr.Read
        lm.Add(New Matricula(0, New Alumno(CInt(dr.Item("codigoPersona")), CStr(dr.Item("nombre")), CStr(dr.Item("apellidoPat")), CStr(dr.Item("apellidoMat"))), 0))
        lm.Item(lm.Count - 1).NroOrden = CInt(dr.Item("nroOrden"))
        lm.Item(lm.Count - 1).Numero = CInt(dr.Item("nroMatricula"))
      Loop
      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
    Return lm
  End Function

  Public Function ListarAlumnosGrupo(ByVal obj As DocenteCarga) As List(Of Matricula)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAlumnosGrupo", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lm As List(Of Matricula) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoDocenteCarga", obj.Codigo)
    End With
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lm = New List(Of Matricula)
      Do While dr.Read
        lm.Add(New Matricula(CInt(dr.Item("nroMatricula")), New Alumno(CInt(dr.Item("codigoPersona")), CStr(dr.Item("nombre")), _
                            CStr(dr.Item("apellidoPat")), CStr(dr.Item("apellidoMat"))), CInt(dr.Item("nroOrden"))))
      Loop
      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
    Return lm
  End Function

  Public Function ListarConsolidado(ByVal wsec As Seccion, ByVal anio As String) As List(Of Matricula)
    Dim lm As New List(Of Matricula)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAlumnosConsolidado", cn)
    Dim dr As SqlDataReader = Nothing
    Dim fecha As DateTime

    cmd.CommandType = CommandType.StoredProcedure

    cmd.Parameters.AddWithValue("@CodigoNivel", wsec.Grado.Nivel.Codigo)
    cmd.Parameters.AddWithValue("@Anio", anio)
    'cmd.Parameters.AddWithValue("@codigoG", wsec.Grado.Codigo)
    cmd.Parameters.AddWithValue("@Numero", wsec.Grado.Numero)
    cmd.Parameters.AddWithValue("@Letra", wsec.Letra)

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      fecha = Now
      While dr.Read
        lm.Add(New Matricula(CInt(dr.Item("nroMatricula")), Nothing, _
                     New Alumno(CInt(dr.Item("codigoAlumno")), CStr(dr.Item("nombre")), _
                                CStr(dr.Item("apellidoPat")), CStr(dr.Item("apellidoMat")), _
                                 dr.Item("sexo").ToString, Nothing, "", New UbicacionGeografica()), _
                      New Apoderado(), True, New Personal() _
                , New AnioLectivo(), New Grado(), "", CInt(dr.Item("nroOrden"))))
      End While
      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
    Return lm
  End Function

  Public Function ListarAlumnosCurso(ByVal obj As DocenteCarga) As List(Of Matricula)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAlumnosCurso", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lm As List(Of Matricula) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoG", obj.Carga.Seccion.Grado.Codigo)
      .AddWithValue("@CodigoDC", obj.Codigo)
      .AddWithValue("@CodigoCur", obj.Carga.Curso.Codigo)
      .AddWithValue("@Anio", obj.Carga.Seccion.Anio.Anio)
      .AddWithValue("@Letra", obj.Carga.Letra)
      .AddWithValue("CodigoPer", obj.Periodo.Codigo)
    End With
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lm = New List(Of Matricula)
      Do While dr.Read
        lm.Add(New Matricula(CInt(dr.Item("nroMatricula")), New Alumno(CInt(dr.Item("codigoPersona")), _
                    CStr(dr.Item("nombre")), CStr(dr.Item("apellidoPat")), CStr(dr.Item("apellidoMat"))), _
                    CInt(dr.Item("nroOrden"))))
      Loop
      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
    Return lm
  End Function

  Public Function ListarAlumnosGradoSeccion(ByVal obj As Seccion) As List(Of Matricula)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAlumnosGradoSec", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lm As List(Of Matricula) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Anio", obj.Anio.Anio)
      .AddWithValue("@Letra", obj.Letra)
      .AddWithValue("@CodigoG", obj.Grado.Codigo)
    End With

    Try
      cn.Open()
      lm = New List(Of Matricula)
      dr = cmd.ExecuteReader
      Do While dr.Read
        lm.Add(New Matricula(CInt(dr.Item("nroMatricula")), Now, _
                          New Alumno(CInt(dr.Item("codigoAlumno")), CStr(dr.Item("nombre")), _
                             CStr(dr.Item("apellidoPat")), CStr(dr.Item("apellidoMat")), ""), _
                             New Apoderado(), True, New Personal(), New AnioLectivo(), New Grado(), _
                              "", CInt(dr.Item("nroOrden"))))
      Loop
      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
    Return lm
  End Function

  Public Function ListarAlumnosGradoSeccionExport(ByVal obj As Seccion, ByVal dc As DocenteCarga) As List(Of Matricula)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAlumnosGradoSecExport", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lm As List(Of Matricula) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Anio", obj.Anio.Anio)
      .AddWithValue("@Letra", obj.Letra)
      .AddWithValue("@CodDocCar", dc.Codigo)
      .AddWithValue("@CodigoG", obj.Grado.Codigo)
    End With

    Try
      cn.Open()
      lm = New List(Of Matricula)
      dr = cmd.ExecuteReader
      Do While dr.Read
        lm.Add(New Matricula(CInt(dr.Item("nroMatricula")), Now, _
                          New Alumno(CInt(dr.Item("codigoAlumno")), CStr(dr.Item("nombre")), _
                             CStr(dr.Item("apellidoPat")), CStr(dr.Item("apellidoMat")), ""), _
                             New Apoderado(), True, New Personal(), New AnioLectivo(), New Grado(), _
                              "", CInt(dr.Item("nroOrden"))))
      Loop
      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
    Return lm
  End Function

  Public Sub RegistrarPromedioAreaAnio(ByVal wPromedio As PromedioAnioArea, ByVal wCarga As CargaAcademica)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmdMat As New SqlCommand("pr_iPromedioAreaAnio", cn)

    cmdMat.CommandType = CommandType.StoredProcedure
    With cmdMat.Parameters
      .AddWithValue("@CargaAcad", wCarga.Codigo)
      .AddWithValue("@Matricula", wPromedio.Matricula.Numero)
      .AddWithValue("@Letra", wPromedio.Letra)
      .AddWithValue("@Personal", wPromedio.Personal.Codigo)
    End With

    Try
      cn.Open()

      cmdMat.ExecuteNonQuery()
      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally
      cmdMat.Dispose()
      cmdMat = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
  End Sub

  Public Function ListarPosiblesMatriculas(ByVal wAnio As AnioLectivo) As DataTable
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liPosiblesMatriculas", cn)
    Dim da As New SqlDataAdapter(cmd)
    Dim dt As New DataTable

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Anio", wAnio.Anio)
    End With

    Try
      da.Fill(dt)
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      cn.Dispose()
      cn = Nothing
    End Try

    Return dt
  End Function

  Public Function LeerMatriculaxGradoSeccion(ByVal m As Alumno) As Matricula
    Dim mat As Matricula = Nothing
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lmatriculaNivelGradoSec", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@codigoAlumno", m.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read Then
        mat = New Matricula()
        With mat
          .Numero = CInt(dr.Item("nroMatricula"))
          .Letra = dr.Item("letra").ToString
          .Aula = CInt(dr.Item("numero"))
          .Grado = New Grado
          With .Grado
            .Numero = CInt(dr.Item("numero"))
            .Nivel = New Nivel(CInt(dr.Item("codigoNivel")), dr.Item("nombreNivel").ToString, "")
            .Nivel.Siglas = dr.Item("Siglas").ToString
          End With
          .Seccion = New Seccion
          .Seccion.Grado = .Grado
          .Seccion.Letra = .Letra
        End With
      End If
      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
    Return mat
  End Function

  Public Function MatriculadosPorSeccion(ByVal wAnio As AnioLectivo) As DataTable
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liResumenMatriculasAnio", cn)
    Dim da As New SqlDataAdapter(cmd)
    Dim dt As New DataTable

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Anio", wAnio.Anio)
    Try
      da.Fill(dt)
    Catch ex As Exception
      Throw ex
    Finally
      da.Dispose()
      da = Nothing
      cmd.Dispose()
      cmd = Nothing
      cn.Dispose()
      cn = Nothing
    End Try

    Return dt
  End Function

  Public Function ListarAlumnosDatos_Seccion(ByVal wSeccion As Seccion) As List(Of Matricula)
    Dim datos As List(Of Matricula) = Nothing
    Dim mat As Matricula
    Dim dr As SqlDataReader
    Dim params As New List(Of CParametro)(3)
    Dim iCodigo, iOrden, iNombre, iApPat, iApMat, iTel, iCorreo, iDir As Integer
    Dim iNombreAp, iApPatAp, iApMatAp, iTelCasaAp, iTelTrabAp As Integer
    Dim iCelularAp, iCorreoAp, iDirAp, iPar As Integer

    params.Add(New CParametro("@Anio", wSeccion.Anio.Anio))
    params.Add(New CParametro("@Grado", wSeccion.Grado.Codigo))
    params.Add(New CParametro("@Letra", wSeccion.Letra))
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liDatosContactoAlumnosSeccion", params)
      params.Clear()
      iOrden = dr.GetOrdinal("nroOrden")
      iCodigo = dr.GetOrdinal("codigoAlumno")
      iNombre = dr.GetOrdinal("Nombre")
      iApPat = dr.GetOrdinal("apellidoPat")
      iApMat = dr.GetOrdinal("apellidoMat")
      iTel = dr.GetOrdinal("Telefono")
      iCorreo = dr.GetOrdinal("Email")
      iDir = dr.GetOrdinal("Direccion")

      iNombreAp = dr.GetOrdinal("NombreAp")
      iApPatAp = dr.GetOrdinal("apellidoPatAp")
      iApMatAp = dr.GetOrdinal("apellidoMatAp")
      iTelCasaAp = dr.GetOrdinal("TelefonoCasaAp")
      iCelularAp = dr.GetOrdinal("CelularAp")
      iTelTrabAp = dr.GetOrdinal("TelefonoTrabAp")
      iCorreoAp = dr.GetOrdinal("EmailAp")
      iDirAp = dr.GetOrdinal("DireccionAp")
      iPar = dr.GetOrdinal("Parentesco")
      datos = New List(Of Matricula)
      While dr.Read
        mat = New Matricula
        mat.NroOrden = dr.GetByte(iOrden)
        mat.Alumno = New Alumno()
        With mat.Alumno
          .Codigo = dr.GetInt32(iCodigo)
          .Nombre = dr.GetString(iNombre)
          .ApellidoPaterno = dr.GetString(iApPat)
          .ApellidoMaterno = dr.GetString(iApMat)
          .Direccion = dr.GetString(iDir)
          If dr.IsDBNull(iTel) = False Then .Telefono = dr.GetString(iTel)
          If dr.IsDBNull(iCorreo) = False Then .Email = dr.GetString(iCorreo)
        End With

        mat.Parentesco = New Parentesco()
        With mat.Parentesco
          .Parentesco = dr.GetString(iPar)
          .Apoderado = New Apoderado
          With .Apoderado
            .Nombre = dr.GetString(iNombreAp)
            .ApellidoPaterno = dr.GetString(iApPatAp)
            .ApellidoMaterno = dr.GetString(iApMatAp)
            .Direccion = dr.GetString(iDirAp)
            If dr.IsDBNull(iCelularAp) = False Then .Celular = dr.GetString(iCelularAp)
            If dr.IsDBNull(iTelCasaAp) = False Then .TelefonoCasa = dr.GetString(iTelCasaAp)
            If dr.IsDBNull(iTelTrabAp) = False Then .TelefonoTrabajo = dr.GetString(iTelTrabAp)
            If dr.IsDBNull(iCorreoAp) = False Then .Email = dr.GetString(iCorreoAp)
          End With
          mat.codigoApoderado = mat.Parentesco.Apoderado
        End With

        datos.Add(mat)
      End While

    Catch ex As Exception
      datos = Nothing
      Throw ex
    Finally
      params = Nothing
      dr = Nothing
      mat = Nothing
      Me.Cerrar(True)
    End Try

    Return datos
  End Function

  Public Function ListarAlumnosDatos_Anio(ByVal wAnio As AnioLectivo) As List(Of Matricula)
    Dim datos As List(Of Matricula) = Nothing
    Dim mat As Matricula
    Dim dr As SqlDataReader
    Dim params As New List(Of CParametro)(3)
    Dim iSiglas, iNumero, iLetra, iOrden As Integer
    Dim iCodigo, iNombre, iApPat, iApMat, iTel, iCorreo, iDir As Integer
    Dim iNombreAp, iApPatAp, iApMatAp, iTelCasaAp, iTelTrabAp As Integer
    Dim iCelularAp, iCorreoAp, iDirAp, iPar As Integer

    params.Add(New CParametro("@Anio", wAnio.Anio))
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liDatosContactoAlumnosColegio", params)
      params.Clear()
      iSiglas = dr.GetOrdinal("Siglas")
      iNumero = dr.GetOrdinal("Numero")
      iLetra = dr.GetOrdinal("Letra")
      iOrden = dr.GetOrdinal("nroOrden")

      iCodigo = dr.GetOrdinal("CodigoAlumno")
      iNombre = dr.GetOrdinal("Nombre")
      iApPat = dr.GetOrdinal("apellidoPat")
      iApMat = dr.GetOrdinal("apellidoMat")
      iTel = dr.GetOrdinal("Telefono")
      iCorreo = dr.GetOrdinal("Email")
      iDir = dr.GetOrdinal("Direccion")

      iNombreAp = dr.GetOrdinal("NombreAp")
      iApPatAp = dr.GetOrdinal("apellidoPatAp")
      iApMatAp = dr.GetOrdinal("apellidoMatAp")
      iTelCasaAp = dr.GetOrdinal("TelefonoCasaAp")
      iCelularAp = dr.GetOrdinal("CelularAp")
      iTelTrabAp = dr.GetOrdinal("TelefonoTrabAp")
      iCorreoAp = dr.GetOrdinal("EmailAp")
      iDirAp = dr.GetOrdinal("DireccionAp")
      iPar = dr.GetOrdinal("Parentesco")
      datos = New List(Of Matricula)
      While dr.Read
        mat = New Matricula
        mat.Seccion = New Seccion
        With mat.Seccion
          .Grado = New Grado() With {.Numero = dr.GetByte(iNumero)}
          .Grado.Nivel = New Nivel() With {.Siglas = dr.GetString(iSiglas)}
          .Letra = dr.GetString(iLetra)
        End With
        mat.NroOrden = dr.GetByte(iOrden)
        mat.Alumno = New Alumno()
        With mat.Alumno
          .Codigo = dr.GetInt32(iCodigo)
          .Nombre = dr.GetString(iNombre)
          .ApellidoPaterno = dr.GetString(iApPat)
          .ApellidoMaterno = dr.GetString(iApMat)
          .Direccion = dr.GetString(iDir)
          If dr.IsDBNull(iTel) = False Then .Telefono = dr.GetString(iTel)
          If dr.IsDBNull(iCorreo) = False Then .Email = dr.GetString(iCorreo)
        End With

        mat.Parentesco = New Parentesco()
        With mat.Parentesco
          .Parentesco = dr.GetString(iPar)
          .Apoderado = New Apoderado
          With .Apoderado
            .Nombre = dr.GetString(iNombreAp)
            .ApellidoPaterno = dr.GetString(iApPatAp)
            .ApellidoMaterno = dr.GetString(iApMatAp)
            .Direccion = dr.GetString(iDirAp)
            If dr.IsDBNull(iCelularAp) = False Then .Celular = dr.GetString(iCelularAp)
            If dr.IsDBNull(iTelCasaAp) = False Then .TelefonoCasa = dr.GetString(iTelCasaAp)
            If dr.IsDBNull(iTelTrabAp) = False Then .TelefonoTrabajo = dr.GetString(iTelTrabAp)
            If dr.IsDBNull(iCorreoAp) = False Then .Email = dr.GetString(iCorreoAp)
          End With
          mat.codigoApoderado = mat.Parentesco.Apoderado
        End With

        datos.Add(mat)
      End While

    Catch ex As Exception
      datos = Nothing
      Throw ex
    Finally
      params = Nothing
      dr = Nothing
      mat = Nothing
      Me.Cerrar(True)
    End Try

    Return datos
  End Function

  Public Function ListarAlumnosEstructuraIntegrantes() As List(Of Matricula)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pa_listarAlumnosBIF", cn)
    Dim la As New List(Of Matricula)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure

    Try
      cn.Open()
      cmd.CommandTimeout = 600
      dr = cmd.ExecuteReader

      While dr.Read
        la.Add(New Matricula(Nothing, New Grado(0, 0, "", CInt(dr.Item("Numero"))), _
                              New Alumno(CInt(dr.Item("codigoAlumno")), dr.GetString(dr.GetOrdinal("nombre")), _
                                         dr.GetString(dr.GetOrdinal("apellidoPat")), dr.GetString(dr.GetOrdinal("apellidoMat")), _
                                         "", dr.GetString(dr.GetOrdinal("codigoRecaudacion"))), _
                              Nothing, Nothing, dr.GetString(dr.GetOrdinal("letra")), False, 0.0, 0, 0, 0, Nothing, Nothing, ""))
        With la.Item(la.Count - 1)
          .Seccion = New Seccion
          .Seccion.Grado = .Grado
          .Seccion.Grado.Nivel = New Nivel() With {.Orden = CInt(dr.Item("Nivel"))}
        End With
      End While

      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
    Return la
  End Function

  Public Function LeerInformacionMatricula(ByVal wMatricula As Matricula) As Matricula
    Dim mat As Matricula = Nothing
    Dim dr As SqlDataReader
    Dim params As New List(Of CParametro)(2)

    params.AddRange(New CParametro() {New CParametro("@Alumno", wMatricula.Alumno.Codigo), _
                                       New CParametro("@Anio", wMatricula.Anio.Anio)})

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_lInformacionAlumno", params)
      params.Clear()
      If dr.Read Then
        mat = New Matricula
        mat.Grado = New Grado() With {.Numero = CInt(dr.Item("Numero"))}
        mat.Grado.Nivel = New Nivel With {.Nombre = dr.Item("NombreNivel").ToString}
        mat.Letra = dr.Item("Letra").ToString

        mat.Parentesco = New Parentesco()
        With mat.Parentesco
          .Parentesco = dr.Item("Parentesco").ToString
          .Apoderado = New Apoderado
          With .Apoderado
            .Nombre = dr.Item("Nombre").ToString
            .ApellidoPaterno = dr.Item("ApellidoPat").ToString
            .ApellidoMaterno = dr.Item("ApellidoMat").ToString
          End With
          mat.codigoApoderado = mat.Parentesco.Apoderado
        End With
        mat.Seccion = New Seccion
        With mat.Seccion
          .Grado = mat.Grado
          .Letra = mat.Letra
          .Aula = New Aula() With {.Pabellon = CInt(dr.Item("Pabellon")), .Numero = CInt(dr.Item("Aula"))}
          .Aula.Local = New Local() With {.Nombre = dr.Item("Local").ToString}
          .Tutor = New Docente()
          With .Tutor
            .Nombre = dr.Item("NombreTut").ToString
            .ApellidoPaterno = dr.Item("ApellidoPatTut").ToString
            .ApellidoMaterno = dr.Item("ApellidoMatTut").ToString
          End With
        End With
      End If
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      mat = Nothing
      Throw ex
    Finally
      params = Nothing
      dr = Nothing
    End Try

    Return mat
  End Function

  Public Function ListarDirectorio(ByVal wSeccion As Seccion) As List(Of Matricula)
    Dim datos As List(Of Matricula) = Nothing
    Dim mat As Matricula
    Dim dr As SqlDataReader
    Dim params As New List(Of CParametro)(3)
    Dim iCodigo, iNombre, iApPat, iApMat, iTel, iCorreo, iDir As Integer
    Dim iNombrePad, iApPatPad, iApMatPad, iTelCasaPad, iTelTrabPad, iCelularPad, iCorreoPad, iVivePad, iDocPad, inroDocPad As Integer
    Dim iNombreMad, iApPatMad, iApMatMad, iTelCasaMad, iTelTrabMad, iCelularMad, iCorreoMad, iViveMad, iDocMad, inroDocMad As Integer
    Dim iNombreAp, iApPatAp, iApMatAp, iTelCasaAp, iTelTrabAp, iCelularAp, iCorreoAp, iPar, iDocAp, iNroDocAp As Integer

    params.Add(New CParametro("@Anio", wSeccion.Anio.Anio))
    params.Add(New CParametro("@Grado", wSeccion.Grado.Codigo))
    params.Add(New CParametro("@Letra", wSeccion.Letra))

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liAlumnosPadresApoderados_Contacto", params)
      params.Clear()
      iCodigo = dr.GetOrdinal("CodigoAlumno")
      iNombre = dr.GetOrdinal("Nombre")
      iApPat = dr.GetOrdinal("apellidoPat")
      iApMat = dr.GetOrdinal("apellidoMat")
      iTel = dr.GetOrdinal("Telefono")
      iCorreo = dr.GetOrdinal("Email")
      iDir = dr.GetOrdinal("Direccion")

      iNombrePad = dr.GetOrdinal("NombrePadre")
      iApPatPad = dr.GetOrdinal("apellidoPatPadre")
      iApMatPad = dr.GetOrdinal("apellidoMatPadre")
      iTelCasaPad = dr.GetOrdinal("TelefonoCasaPadre")
      iCelularPad = dr.GetOrdinal("CelularPadre")
      iTelTrabPad = dr.GetOrdinal("TelefonoTrabPadre")
      iCorreoPad = dr.GetOrdinal("EmailPadre")
      iVivePad = dr.GetOrdinal("VivePadre")
      iDocPad = dr.GetOrdinal("DocumentoPadre")
      inroDocPad = dr.GetOrdinal("NumeroDocPadre")

      iNombreMad = dr.GetOrdinal("NombreMadre")
      iApPatMad = dr.GetOrdinal("apellidoPatMadre")
      iApMatMad = dr.GetOrdinal("apellidoMatMadre")
      iTelCasaMad = dr.GetOrdinal("TelefonoCasaMadre")
      iCelularMad = dr.GetOrdinal("CelularMadre")
      iTelTrabMad = dr.GetOrdinal("TelefonoTrabMadre")
      iCorreoMad = dr.GetOrdinal("EmailMadre")
      iViveMad = dr.GetOrdinal("ViveMadre")
      iDocMad = dr.GetOrdinal("DocumentoMadre")
      inroDocMad = dr.GetOrdinal("NumeroDocMadre")

      iNombreAp = dr.GetOrdinal("NombreAp")
      iApPatAp = dr.GetOrdinal("apellidoPatAp")
      iApMatAp = dr.GetOrdinal("apellidoMatAp")
      iTelCasaAp = dr.GetOrdinal("TelefonoCasaAp")
      iCelularAp = dr.GetOrdinal("CelularAp")
      iTelTrabAp = dr.GetOrdinal("TelefonoTrabAp")
      iCorreoAp = dr.GetOrdinal("EmailAp")
      iPar = dr.GetOrdinal("Parentesco")
      iDocAp = dr.GetOrdinal("DocumentoAp")
      iNroDocAp = dr.GetOrdinal("NumeroDocAp")
      datos = New List(Of Matricula)
      While dr.Read
        mat = New Matricula

        mat.Seccion = wSeccion
        mat.Grado = mat.Seccion.Grado
        mat.Letra = mat.Seccion.Letra
        mat.Alumno = New Alumno()
        With mat.Alumno
          .Codigo = dr.GetInt32(iCodigo)
          .Nombre = dr.GetString(iNombre)
          .ApellidoPaterno = dr.GetString(iApPat)
          .ApellidoMaterno = dr.GetString(iApMat)
          .Direccion = dr.GetString(iDir)
          If dr.IsDBNull(iTel) = False Then .Telefono = dr.GetString(iTel)
          If dr.IsDBNull(iCorreo) = False Then .Email = dr.GetString(iCorreo)

          If dr.IsDBNull(iNombrePad) = False Then
            .Padre = New Apoderado
            With .Padre
              .Nombre = dr.GetString(iNombrePad)
              .ApellidoPaterno = dr.GetString(iApPatPad)
              .ApellidoMaterno = dr.GetString(iApMatPad)
              If dr.IsDBNull(iTelCasaPad) = False Then .TelefonoCasa = dr.GetString(iTelCasaPad)
              If dr.IsDBNull(iTelTrabPad) = False Then .TelefonoTrabajo = dr.GetString(iTelTrabPad)
              If dr.IsDBNull(iCelularPad) = False Then .Celular = dr.GetString(iCelularPad)
              If dr.IsDBNull(iCorreoPad) = False Then .Email = dr.GetString(iCorreoPad)
              If dr.IsDBNull(iDocPad) = False Then .TipoDoc = dr.GetString(iDocPad)
              If dr.IsDBNull(inroDocPad) = False Then .NroDoc = dr.GetString(inroDocPad)
              .Vive = dr.GetBoolean(iVivePad)
            End With
          End If

          If dr.IsDBNull(iNombreMad) = False Then
            .Madre = New Apoderado
            With .Madre
              .Nombre = dr.GetString(iNombreMad)
              .ApellidoPaterno = dr.GetString(iApPatMad)
              .ApellidoMaterno = dr.GetString(iApMatMad)
              If dr.IsDBNull(iTelCasaMad) = False Then .TelefonoCasa = dr.GetString(iTelCasaMad)
              If dr.IsDBNull(iTelTrabMad) = False Then .TelefonoTrabajo = dr.GetString(iTelTrabMad)
              If dr.IsDBNull(iCelularMad) = False Then .Celular = dr.GetString(iCelularMad)
              If dr.IsDBNull(iCorreoMad) = False Then .Email = dr.GetString(iCorreoMad)
              If dr.IsDBNull(iDocMad) = False Then .TipoDoc = dr.GetString(iDocMad)
              If dr.IsDBNull(inroDocMad) = False Then .NroDoc = dr.GetString(inroDocMad)
              .Vive = dr.GetBoolean(iViveMad)
            End With
          End If
        End With

        If dr.IsDBNull(iNombreAp) = False Then
          mat.Parentesco = New Parentesco()
          With mat.Parentesco
            .Parentesco = dr.GetString(iPar)
            .Apoderado = New Apoderado
            With .Apoderado
              .Nombre = dr.GetString(iNombreAp)
              .ApellidoPaterno = dr.GetString(iApPatAp)
              .ApellidoMaterno = dr.GetString(iApMatAp)
              If dr.IsDBNull(iCelularAp) = False Then .Celular = dr.GetString(iCelularAp)
              If dr.IsDBNull(iTelCasaAp) = False Then .TelefonoCasa = dr.GetString(iTelCasaAp)
              If dr.IsDBNull(iTelTrabAp) = False Then .TelefonoTrabajo = dr.GetString(iTelTrabAp)
              If dr.IsDBNull(iCorreoAp) = False Then .Email = dr.GetString(iCorreoAp)
              If dr.IsDBNull(iDocAp) = False Then .TipoDoc = dr.GetString(iDocAp)
              If dr.IsDBNull(iNroDocAp) = False Then .NroDoc = dr.GetString(iNroDocAp)
            End With
            mat.codigoApoderado = mat.Parentesco.Apoderado
          End With
        End If

        datos.Add(mat)
      End While

    Catch ex As Exception
      datos = Nothing
      Throw ex
    Finally
      params = Nothing
      dr = Nothing
      mat = Nothing
      Me.Cerrar(True)
    End Try

    Return datos
  End Function

  Public Function ListarDirectorio(ByVal wAnio As AnioLectivo) As List(Of Matricula)
    Dim datos As List(Of Matricula) = Nothing
    Dim mat As Matricula
    Dim dr As SqlDataReader
    Dim params As New List(Of CParametro)(1)
    Dim iNivel, iGrado, iLetra As Integer
    Dim iNombre, iApPat, iApMat, iTel, iCorreo, iDir As Integer
    Dim iNombrePad, iApPatPad, iApMatPad, iTelCasaPad, iTelTrabPad, iCelularPad, iCorreoPad, iVivePad, iDocPad, inroDocPad As Integer
    Dim iNombreMad, iApPatMad, iApMatMad, iTelCasaMad, iTelTrabMad, iCelularMad, iCorreoMad, iViveMad, iDocMad, inroDocMad As Integer
    Dim iNombreAp, iApPatAp, iApMatAp, iTelCasaAp, iTelTrabAp, iCelularAp, iCorreoAp, iPar, iDocAp, inroDocAp As Integer

    params.Add(New CParametro("@Anio", wAnio.Anio))

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liAlumnosPadresApoderadosAnio_Contacto", params)
      params.Clear()
      iNivel = dr.GetOrdinal("Siglas")
      iGrado = dr.GetOrdinal("Numero")
      iLetra = dr.GetOrdinal("Letra")

      iNombre = dr.GetOrdinal("Nombre")
      iApPat = dr.GetOrdinal("apellidoPat")
      iApMat = dr.GetOrdinal("apellidoMat")
      iTel = dr.GetOrdinal("Telefono")
      iCorreo = dr.GetOrdinal("Email")
      iDir = dr.GetOrdinal("Direccion")

      iNombrePad = dr.GetOrdinal("NombrePadre")
      iApPatPad = dr.GetOrdinal("apellidoPatPadre")
      iApMatPad = dr.GetOrdinal("apellidoMatPadre")
      iTelCasaPad = dr.GetOrdinal("TelefonoCasaPadre")
      iCelularPad = dr.GetOrdinal("CelularPadre")
      iTelTrabPad = dr.GetOrdinal("TelefonoTrabPadre")
      iCorreoPad = dr.GetOrdinal("EmailPadre")
      iVivePad = dr.GetOrdinal("VivePadre")
      iDocPad = dr.GetOrdinal("DocumentoPadre")
      inroDocPad = dr.GetOrdinal("NumeroDocPadre")

      iNombreMad = dr.GetOrdinal("NombreMadre")
      iApPatMad = dr.GetOrdinal("apellidoPatMadre")
      iApMatMad = dr.GetOrdinal("apellidoMatMadre")
      iTelCasaMad = dr.GetOrdinal("TelefonoCasaMadre")
      iCelularMad = dr.GetOrdinal("CelularMadre")
      iTelTrabMad = dr.GetOrdinal("TelefonoTrabMadre")
      iCorreoMad = dr.GetOrdinal("EmailMadre")
      iViveMad = dr.GetOrdinal("ViveMadre")
      iDocMad = dr.GetOrdinal("DocumentoMadre")
      inroDocMad = dr.GetOrdinal("NumeroDocMadre")

      iNombreAp = dr.GetOrdinal("NombreAp")
      iApPatAp = dr.GetOrdinal("apellidoPatAp")
      iApMatAp = dr.GetOrdinal("apellidoMatAp")
      iTelCasaAp = dr.GetOrdinal("TelefonoCasaAp")
      iCelularAp = dr.GetOrdinal("CelularAp")
      iTelTrabAp = dr.GetOrdinal("TelefonoTrabAp")
      iCorreoAp = dr.GetOrdinal("EmailAp")
      iPar = dr.GetOrdinal("Parentesco")
      iDocAp = dr.GetOrdinal("DocumentoAp")
      inroDocAp = dr.GetOrdinal("NumeroDocAp")
      datos = New List(Of Matricula)
      While dr.Read
        mat = New Matricula

        mat.Seccion = New Seccion
        With mat.Seccion
          .Grado = New Grado With {.Numero = dr.GetByte(iGrado)}
          .Grado.Nivel = New Nivel With {.Siglas = dr.GetString(iNivel)}
          .Letra = dr.GetString(iLetra)
        End With

        mat.Grado = mat.Seccion.Grado
        mat.Letra = mat.Seccion.Letra
        mat.Alumno = New Alumno()
        With mat.Alumno
          .Nombre = dr.GetString(iNombre)
          .ApellidoPaterno = dr.GetString(iApPat)
          .ApellidoMaterno = dr.GetString(iApMat)
          .Direccion = dr.GetString(iDir)
          If dr.IsDBNull(iTel) = False Then .Telefono = dr.GetString(iTel)
          If dr.IsDBNull(iCorreo) = False Then .Email = dr.GetString(iCorreo)


          If dr.IsDBNull(iNombrePad) = False Then
            .Padre = New Apoderado
            With .Padre
              .Nombre = dr.GetString(iNombrePad)
              .ApellidoPaterno = dr.GetString(iApPatPad)
              .ApellidoMaterno = dr.GetString(iApMatPad)
              If dr.IsDBNull(iTelCasaPad) = False Then .TelefonoCasa = dr.GetString(iTelCasaPad)
              If dr.IsDBNull(iTelTrabPad) = False Then .TelefonoTrabajo = dr.GetString(iTelTrabPad)
              If dr.IsDBNull(iCelularPad) = False Then .Celular = dr.GetString(iCelularPad)
              If dr.IsDBNull(iCorreoPad) = False Then .Email = dr.GetString(iCorreoPad)
              If dr.IsDBNull(iDocPad) = False Then .TipoDoc = dr.GetString(iDocPad)
              If dr.IsDBNull(inroDocPad) = False Then .NroDoc = dr.GetString(inroDocPad)
              .Vive = dr.GetBoolean(iVivePad)
            End With
          End If

          If dr.IsDBNull(iNombreMad) = False Then
            .Madre = New Apoderado
            With .Madre
              .Nombre = dr.GetString(iNombreMad)
              .ApellidoPaterno = dr.GetString(iApPatMad)
              .ApellidoMaterno = dr.GetString(iApMatMad)
              If dr.IsDBNull(iTelCasaMad) = False Then .TelefonoCasa = dr.GetString(iTelCasaMad)
              If dr.IsDBNull(iTelTrabMad) = False Then .TelefonoTrabajo = dr.GetString(iTelTrabMad)
              If dr.IsDBNull(iCelularMad) = False Then .Celular = dr.GetString(iCelularMad)
              If dr.IsDBNull(iCorreoMad) = False Then .Email = dr.GetString(iCorreoMad)
              If dr.IsDBNull(iDocMad) = False Then .TipoDoc = dr.GetString(iDocMad)
              If dr.IsDBNull(inroDocMad) = False Then .NroDoc = dr.GetString(inroDocMad)
              .Vive = dr.GetBoolean(iViveMad)
            End With
          End If
        End With

        If dr.IsDBNull(iNombreAp) = False Then
          mat.Parentesco = New Parentesco()
          With mat.Parentesco
            .Parentesco = dr.GetString(iPar)
            .Apoderado = New Apoderado
            With .Apoderado
              .Nombre = dr.GetString(iNombreAp)
              .ApellidoPaterno = dr.GetString(iApPatAp)
              .ApellidoMaterno = dr.GetString(iApMatAp)
              If dr.IsDBNull(iCelularAp) = False Then .Celular = dr.GetString(iCelularAp)
              If dr.IsDBNull(iTelCasaAp) = False Then .TelefonoCasa = dr.GetString(iTelCasaAp)
              If dr.IsDBNull(iTelTrabAp) = False Then .TelefonoTrabajo = dr.GetString(iTelTrabAp)
              If dr.IsDBNull(iCorreoAp) = False Then .Email = dr.GetString(iCorreoAp)
              If dr.IsDBNull(iDocAp) = False Then .TipoDoc = dr.GetString(iDocAp)
              If dr.IsDBNull(inroDocAp) = False Then .NroDoc = dr.GetString(inroDocAp)
            End With
            mat.codigoApoderado = mat.Parentesco.Apoderado
          End With
        End If

        datos.Add(mat)
      End While

    Catch ex As Exception
      datos = Nothing
      Throw ex
    Finally
      params = Nothing
      dr = Nothing
      mat = Nothing
      Me.Cerrar(True)
    End Try

    Return datos
  End Function

  Public Function ListarDirectorio_Nombre(ByVal wAnio As AnioLectivo, ByVal wNombre As String) As List(Of Matricula)
    Dim datos As List(Of Matricula) = Nothing
    Dim mat As Matricula
    Dim dr As SqlDataReader
    Dim params As New List(Of CParametro)(1)
    Dim iNivel, iGrado, iLetra As Integer
    Dim iCodigo, iNombre, iApPat, iApMat, iTel, iCorreo, iDir As Integer
    Dim iNombrePad, iApPatPad, iApMatPad, iTelCasaPad, iTelTrabPad, iCelularPad, iCorreoPad, iVivePad As Integer
    Dim iNombreMad, iApPatMad, iApMatMad, iTelCasaMad, iTelTrabMad, iCelularMad, iCorreoMad, iViveMad As Integer
    Dim iNombreAp, iApPatAp, iApMatAp, iTelCasaAp, iTelTrabAp, iCelularAp, iCorreoAp, iPar As Integer

    params.AddRange(New CParametro() {New CParametro("@Anio", wAnio.Anio), _
                                         New CParametro("@Alumno", wNombre)})


    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liAlumnosDatos_NombreCompleto", params)
      params.Clear()
      iNivel = dr.GetOrdinal("Siglas")
      iGrado = dr.GetOrdinal("Numero")
      iLetra = dr.GetOrdinal("Letra")

      iCodigo = dr.GetOrdinal("CodigoAlumno")
      iNombre = dr.GetOrdinal("Nombre")
      iApPat = dr.GetOrdinal("apellidoPat")
      iApMat = dr.GetOrdinal("apellidoMat")
      iTel = dr.GetOrdinal("Telefono")
      iCorreo = dr.GetOrdinal("Email")
      iDir = dr.GetOrdinal("Direccion")

      iNombrePad = dr.GetOrdinal("NombrePadre")
      iApPatPad = dr.GetOrdinal("apellidoPatPadre")
      iApMatPad = dr.GetOrdinal("apellidoMatPadre")
      iTelCasaPad = dr.GetOrdinal("TelefonoCasaPadre")
      iCelularPad = dr.GetOrdinal("CelularPadre")
      iTelTrabPad = dr.GetOrdinal("TelefonoTrabPadre")
      iCorreoPad = dr.GetOrdinal("EmailPadre")
      iVivePad = dr.GetOrdinal("VivePadre")

      iNombreMad = dr.GetOrdinal("NombreMadre")
      iApPatMad = dr.GetOrdinal("apellidoPatMadre")
      iApMatMad = dr.GetOrdinal("apellidoMatMadre")
      iTelCasaMad = dr.GetOrdinal("TelefonoCasaMadre")
      iCelularMad = dr.GetOrdinal("CelularMadre")
      iTelTrabMad = dr.GetOrdinal("TelefonoTrabMadre")
      iCorreoMad = dr.GetOrdinal("EmailMadre")
      iViveMad = dr.GetOrdinal("ViveMadre")

      iNombreAp = dr.GetOrdinal("NombreAp")
      iApPatAp = dr.GetOrdinal("apellidoPatAp")
      iApMatAp = dr.GetOrdinal("apellidoMatAp")
      iTelCasaAp = dr.GetOrdinal("TelefonoCasaAp")
      iCelularAp = dr.GetOrdinal("CelularAp")
      iTelTrabAp = dr.GetOrdinal("TelefonoTrabAp")
      iCorreoAp = dr.GetOrdinal("EmailAp")
      iPar = dr.GetOrdinal("Parentesco")
      datos = New List(Of Matricula)
      While dr.Read
        mat = New Matricula

        mat.Seccion = New Seccion
        With mat.Seccion
          .Grado = New Grado With {.Numero = dr.GetByte(iGrado)}
          .Grado.Nivel = New Nivel With {.Siglas = dr.GetString(iNivel)}
          .Letra = dr.GetString(iLetra)
        End With

        mat.Grado = mat.Seccion.Grado
        mat.Letra = mat.Seccion.Letra
        mat.Alumno = New Alumno()
        With mat.Alumno
          .Codigo = dr.GetInt32(iCodigo)
          .Nombre = dr.GetString(iNombre)
          .ApellidoPaterno = dr.GetString(iApPat)
          .ApellidoMaterno = dr.GetString(iApMat)
          .Direccion = dr.GetString(iDir)
          If dr.IsDBNull(iTel) = False Then .Telefono = dr.GetString(iTel)
          If dr.IsDBNull(iCorreo) = False Then .Email = dr.GetString(iCorreo)

          If dr.IsDBNull(iNombrePad) = False Then
            .Padre = New Apoderado
            With .Padre
              .Nombre = dr.GetString(iNombrePad)
              .ApellidoPaterno = dr.GetString(iApPatPad)
              .ApellidoMaterno = dr.GetString(iApMatPad)
              If dr.IsDBNull(iTelCasaPad) = False Then .TelefonoCasa = dr.GetString(iTelCasaPad)
              If dr.IsDBNull(iTelTrabPad) = False Then .TelefonoTrabajo = dr.GetString(iTelTrabPad)
              If dr.IsDBNull(iCelularPad) = False Then .Celular = dr.GetString(iCelularPad)
              If dr.IsDBNull(iCorreoPad) = False Then .Email = dr.GetString(iCorreoPad)
              .Vive = dr.GetBoolean(iVivePad)
            End With
          End If

          If dr.IsDBNull(iNombreMad) = False Then
            .Madre = New Apoderado
            With .Madre
              .Nombre = dr.GetString(iNombreMad)
              .ApellidoPaterno = dr.GetString(iApPatMad)
              .ApellidoMaterno = dr.GetString(iApMatMad)
              If dr.IsDBNull(iTelCasaMad) = False Then .TelefonoCasa = dr.GetString(iTelCasaMad)
              If dr.IsDBNull(iTelTrabMad) = False Then .TelefonoTrabajo = dr.GetString(iTelTrabMad)
              If dr.IsDBNull(iCelularMad) = False Then .Celular = dr.GetString(iCelularMad)
              If dr.IsDBNull(iCorreoMad) = False Then .Email = dr.GetString(iCorreoMad)
              .Vive = dr.GetBoolean(iViveMad)
            End With
          End If
        End With

        If dr.IsDBNull(iNombreAp) = False Then
          mat.Parentesco = New Parentesco()
          With mat.Parentesco
            .Parentesco = dr.GetString(iPar)
            .Apoderado = New Apoderado
            With .Apoderado
              .Nombre = dr.GetString(iNombreAp)
              .ApellidoPaterno = dr.GetString(iApPatAp)
              .ApellidoMaterno = dr.GetString(iApMatAp)
              If dr.IsDBNull(iCelularAp) = False Then .Celular = dr.GetString(iCelularAp)
              If dr.IsDBNull(iTelCasaAp) = False Then .TelefonoCasa = dr.GetString(iTelCasaAp)
              If dr.IsDBNull(iTelTrabAp) = False Then .TelefonoTrabajo = dr.GetString(iTelTrabAp)
              If dr.IsDBNull(iCorreoAp) = False Then .Email = dr.GetString(iCorreoAp)
            End With
            mat.codigoApoderado = mat.Parentesco.Apoderado
          End With
        End If

        datos.Add(mat)
      End While

    Catch ex As Exception
      datos = Nothing
      Throw ex
    Finally
      params = Nothing
      dr = Nothing
      mat = Nothing
      Me.Cerrar(True)
    End Try

    Return datos
  End Function

  'Listado de alumnos que se han matriculado en un año
  'Se incluyen aquellos alumnos que han sido promovidos el año pasado
  Public Function ListarAlumnosMatricula(ByVal wAnio As AnioLectivo) As DataTable
    Dim pars As New List(Of CParametro)
    Dim dt As DataTable = Nothing

    pars.Add(New CParametro("@Anio", wAnio.Anio))
    Try
      Me.Conectar(False)
      dt = Me.PedirDatatable("pr_lAlumnosMatriculados_ConEsperados", pars)

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      pars.Clear()
      pars = Nothing
    End Try

    Return dt
  End Function

  'Lista todos los alumnos cuyo nombre completo empieza con el texto indicado en el parametros
  'El listado esta restringido a los alumnos matriculados en el año indicado
  Public Function ListarAnio(ByVal wNombre As String, ByVal wAnio As AnioLectivo) As List(Of Matricula)
    Dim la As New List(Of Matricula)
    Dim dr As SqlDataReader = Nothing
    Dim pars As New List(Of CParametro)
    Dim mat As Matricula
    Dim iCod, iNombre, iApPat, iApMat As Integer
    Dim iNivel, iGrado, iLetra As Integer

    pars.AddRange(New CParametro() {New CParametro("@Nombre", wNombre), _
                                      New CParametro("@Anio", wAnio.Anio)})
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liAlumnos_NombreAnio", pars)
      iCod = dr.GetOrdinal("CodigoPersona")
      iNombre = dr.GetOrdinal("Nombre")
      iApPat = dr.GetOrdinal("ApellidoPat")
      iApMat = dr.GetOrdinal("ApellidoMat")
      iNivel = dr.GetOrdinal("Siglas")
      iGrado = dr.GetOrdinal("Numero")
      iLetra = dr.GetOrdinal("Letra")
      While dr.Read
        mat = New Matricula
        mat.Alumno = New Alumno(dr.GetInt32(iCod), dr.GetString(iNombre), dr.GetString(iApPat), dr.GetString(iApMat))
        mat.Seccion = New Seccion With {.Letra = dr.GetString(iLetra)}
        mat.Seccion.Grado = New Grado With {.Numero = dr.GetByte(iGrado),
                                            .Nivel = New Nivel() With {.Siglas = dr.GetString(iNivel)}}

        la.Add(mat)
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars.Clear()
      pars = Nothing
    End Try

    Return la
  End Function


End Class
