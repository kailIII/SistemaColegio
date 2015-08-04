
Public Class RNCargaAcademica
  Inherits CADO

  Public Function Registrar(ByVal Obj As CargaAcademica, ByVal objA As AnioLectivo) As Integer
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iCargaAcademica", cn)
    Dim dr As Integer

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigoCur", Obj.Curso.Codigo)
      .AddWithValue("@CodigoCarga", 0).Direction = ParameterDirection.Output
      .AddWithValue("@codigoG", Obj.CodigoGrado)
      .AddWithValue("@Anio", objA.Anio)
      .AddWithValue("@letra", CChar(Obj.Letra))
    End With

    Try
      cn.Open()
      cmd.ExecuteNonQuery()
      dr = CInt(cmd.Parameters("@CodigoCarga").Value)
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

  Public Function Listar(ByVal wsec As Seccion) As List(Of CargaAcademica)
    Dim lc As New List(Of CargaAcademica)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liCargaAcademica", cn)
    Dim dr As SqlDataReader = Nothing
    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@anio", wsec.Anio.Anio)
    cmd.Parameters.AddWithValue("@codigoG", wsec.Grado.Codigo)
    cmd.Parameters.AddWithValue("@letra", wsec.Letra)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        lc.Add(New CargaAcademica(CInt(dr.Item("codigoCargaAcad")), New Curso(CInt(dr.Item("codigoCur")), CStr(dr.Item("nombreCur")), _
                                        CInt(dr.Item("nroHoras")), CInt(dr.Item("codigoG")), CBool(dr.Item("vigencia")), Nothing, Nothing, Nothing), _
                                        New Seccion(CInt(dr.Item("CodigoG")), CStr(dr.Item("anio")), CChar(dr.Item("letra")))))
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
    Return lc
  End Function

  Public Function ListarCargasAcad(ByVal obj As CargaAcademica) As List(Of CargaAcademica)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liCargasAcad", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lc As List(Of CargaAcademica) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Anio", obj.Seccion.Anio.Anio)
      .AddWithValue("@CodigoG", obj.Seccion.Grado.Codigo)
      .AddWithValue("@Letra", obj.Seccion.Letra)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lc = New List(Of CargaAcademica)
      Do While dr.Read
        lc.Add(New CargaAcademica(CInt(dr.Item("codigoCargaAcad")), New Curso(CInt(dr.Item("codigoCur"))), New Seccion()))
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
    Return lc
  End Function

  Public Function MostrarCargasAcad(ByVal obj As CargaAcademica) As List(Of DocenteCarga)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liCargasAcademicas", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ldc As List(Of DocenteCarga) = Nothing
    Dim fecha As DateTime = Now

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoCur", obj.Curso.Codigo)
      .AddWithValue("@CodigoG", obj.Seccion.Grado.Codigo)
      .AddWithValue("@Letra", obj.Seccion.Letra)
      .AddWithValue("@Anio", obj.Seccion.Anio.Anio)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ldc = New List(Of DocenteCarga)
      Do While dr.Read
        ldc.Add(New DocenteCarga(CInt(dr.Item("codigoDocenteCarga")), dr.Item("NombreCarga").ToString, New Docente(CInt(dr.Item("codigoDocente")), dr.Item("NombreDocente").ToString, dr.Item("apellidoPat").ToString, dr.Item("apellidoMat").ToString), New CargaAcademica(CInt(dr.Item("codigoCargaAcad"))), _
                                 New PeriodoAcademico(CInt(dr.Item("codigoPeriodo")), fecha, fecha, False, "", dr.Item("NombrePeriodo").ToString, "")))
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
    Return ldc
  End Function

  Public Function MostrarCargasAcad3(ByVal obj As CargaAcademica) As List(Of DocenteCarga)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liCargasAcademicas3", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ldc As List(Of DocenteCarga) = Nothing
    Dim fecha As DateTime = Now

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoCur", obj.Curso.Codigo)
      .AddWithValue("@CodigoG", obj.Seccion.Grado.Codigo)
      .AddWithValue("@Letra", obj.Seccion.Letra)
      .AddWithValue("@Anio", obj.Seccion.Anio.Anio)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ldc = New List(Of DocenteCarga)
      Do While dr.Read
        ldc.Add(New DocenteCarga(CInt(dr.Item("codigoDocenteCarga")), dr.Item("NombreCarga").ToString, _
                                 New Docente(CInt(dr.Item("codigoDocente")), dr.Item("NombreDocente").ToString, _
                                             dr.Item("apellidoPat").ToString, dr.Item("apellidoMat").ToString), _
                                             New CargaAcademica(CInt(dr.Item("codigoCargaAcad"))), _
                                             New PeriodoAcademico(CInt(dr.Item("codigoPeriodo")), fecha, fecha, _
                                                                  False, "", dr.Item("NombrePeriodo").ToString, "")))
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
    Return ldc
  End Function

  Public Function MostrarCargasAcad4(ByVal obj As CargaAcademica) As List(Of DocenteCarga)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liCargasAcademicas4", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ldc As List(Of DocenteCarga) = Nothing
    Dim fecha As DateTime = Now

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoCur", obj.Curso.Codigo)
      .AddWithValue("@CodigoG", obj.Seccion.Grado.Codigo)
      .AddWithValue("@Letra", obj.Seccion.Letra)
      .AddWithValue("@Anio", obj.Seccion.Anio.Anio)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ldc = New List(Of DocenteCarga)
      Do While dr.Read
        ldc.Add(New DocenteCarga(CInt(dr.Item("codigoDocenteCarga")), dr.Item("NombreCarga").ToString, New Docente(CInt(dr.Item("codigoDocente")), dr.Item("NombreDocente").ToString, dr.Item("apellidoPat").ToString, dr.Item("apellidoMat").ToString), New CargaAcademica(CInt(dr.Item("codigoCargaAcad"))), _
                                 New PeriodoAcademico(CInt(dr.Item("codigoPeriodo")), fecha, fecha, False, "", dr.Item("NombrePeriodo").ToString, dr.Item("siglas").ToString, CBool(dr.Item("cerrado")))))
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
    Return ldc
  End Function

  Public Function CodigoCarga(ByVal Obj As CargaAcademica) As Integer
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lCodigoCarga", cn)
    Dim dr As Integer

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigoCur", Obj.Curso.Codigo)
      .AddWithValue("@codigoG", Obj.CodigoGrado)
      .AddWithValue("@Anio", Obj.Seccion.Anio.Anio)
      .AddWithValue("@letra", CChar(Obj.Letra))
    End With

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

  'Lista los cursos que corresponden a una sección, indicando el código de la carga academica
  'asignada si la tiene
  Public Function ListarCargaAsignadadSeccion(ByVal wSeccion As Seccion) As List(Of CargaAcademica)
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim cargas As List(Of CargaAcademica) = Nothing
    Dim iCodigo, iNombre, iGrupo, iRotatito, iCodigoCarga As Integer

    pars.AddRange(New CParametro() {New CParametro("@Anio", wSeccion.Anio.Anio), _
                                    New CParametro("@Grado", wSeccion.Grado.Codigo), _
                                    New CParametro("@Letra", wSeccion.Letra)})
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liCursosAsignadosSeccion", pars)
      iCodigo = dr.GetOrdinal("CodigoCur")
      iNombre = dr.GetOrdinal("nombreCur")
      iGrupo = dr.GetOrdinal("Grupo")
      iRotatito = dr.GetOrdinal("Rotativo")
      iCodigoCarga = dr.GetOrdinal("CodigoCarga")
      cargas = New List(Of CargaAcademica)
      While dr.Read
        cargas.Add(New CargaAcademica With { _
              .Curso = New Curso With {.Codigo = dr.GetInt16(iCodigo), _
                                       .Nombre = dr.GetString(iNombre), _
                                       .Grupo = dr.GetBoolean(iGrupo), _
                                       .Rotativo = dr.GetBoolean(iRotatito)}, _
              .Seccion = wSeccion, _
              .Codigo = 0})
        If dr.IsDBNull(iCodigoCarga) = False Then
          cargas.Item(cargas.Count - 1).Codigo = dr.GetInt16(iCodigoCarga)
        End If
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      pars.Clear()
      pars = Nothing
    End Try

    Return cargas
  End Function

  'Presenta un resumen de las notas de una sección en base al curso y docente indicado
  'Devuelve las unidades registradas por el docente y las capacidades del area
  Public Function ListarResumenPeriodo(ByVal unidades As List(Of Unidad), ByVal capacidades As List(Of Capacidad), ByVal docenteCarga As DocenteCarga) As DataTable
    Dim sql As String
    Dim dt As DataTable = Nothing
    Dim dr As SqlDataReader

    Try
      Me.Conectar(False)
      Me.LlenarUnidades(unidades, docenteCarga)
      Me.LlenarCapacidades(capacidades, docenteCarga)
      sql = Me.generarSentenciaResumenPeriodo(unidades, capacidades, docenteCarga)
      dt = Me.EjecutarSQLDatos(sql)

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      dr = Nothing
    End Try

    Return dt
  End Function

  Private Sub LlenarUnidades(ByVal unidades As List(Of Unidad), ByVal docenteCarga As DocenteCarga)
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader = Nothing

    pars.Add(New CParametro("@CodPeriodo", docenteCarga.Periodo.Codigo))
    pars.Add(New CParametro("@CodDocCarga", docenteCarga.Codigo))
    Try
      dr = Me.PedirDataReader("pr_liTodasUnidades", pars)
      While dr.Read
        unidades.Add(New Unidad With {.Numero = CInt(dr.Item("nroUni"))})
      End While
    Catch ex As Exception
      Throw
    Finally
      dr.Close()
      dr = Nothing
    End Try
  End Sub

  Private Sub LlenarCapacidades(ByVal capacidades As List(Of Capacidad), ByVal docenteCarga As DocenteCarga)
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader = Nothing

    pars.Add(New CParametro("@CodigoCur", docenteCarga.Carga.Curso.Codigo))
    Try
      dr = Me.PedirDataReader("pr_liCapacidadesCur", pars)
      While dr.Read
        capacidades.Add(New Capacidad With {.Codigo = CInt(dr.Item("codigoCapac"))})
      End While
    Catch ex As Exception
      Throw
    Finally
      dr.Close()
      dr = Nothing
    End Try
  End Sub

  Private Function generarSentenciaResumenPeriodo(ByVal unidades As List(Of Unidad), ByVal capacidades As List(Of Capacidad), ByVal docenteCarga As DocenteCarga) As String
    Dim sql As String = "SELECT M.nroOrden, p.apellidoPat + ' ' + p.apellidoMat + ' ' + p.nombre AS Alumno"
    Dim prom As String = ""
    Dim promUni As String = ""
    Dim notas As String = ""
    Dim agrupado As String = ""
    Dim icap As Integer, iuni As Integer = 1

    For Each uni As Unidad In unidades
      icap = 1
      promUni &= ", CAST ("
      For Each cap As Capacidad In capacidades
        sql &= ",NC.U" & iuni & "C" & icap
        promUni += " + NC.U" & iuni & "C" & icap
        notas &= ", SUM ( CASE WHEN nc.nroUni = " & uni.Numero & " AND nc.codigoCapac =  " & cap.Codigo & " THEN nc.promedio ELSE 0 END ) " & "U" & iuni & "C" & icap
        agrupado &= ",NC.U" & iuni & "C" & icap
        icap += 1
      Next
      promUni += " AS SMALLMONEY) / " & capacidades.Count & " AS PU" & iuni
      iuni += 1
    Next
    icap = 1
    For Each cap As Capacidad In capacidades
      prom &= ",SUM( CASE PCCP.codigoCapac WHEN " & cap.Codigo & " THEN PCCP.promedio ELSE 0 END ) C" & icap
      icap += 1
    Next
    sql &= promUni & prom & ", pro.promedio, ROUND( pro.promedio, 0) AS PromFinal " &
      "	FROM PROMEDIO_PERIODO_CUR Pro join " &
          "	MATRICULA M ON M.nroMatricula = Pro.nroMatricula " &
        "	JOIN PERSONA p on p.codigoPersona = m.codigoAlumno " &
        "	JOIN PROMEDIO_CAPACIDAD_CARGAACADEMICA_PERIODO PCCP " &
          "	ON PCCP.nroMatricula = M.nroMatricula	AND " &
            "	PCCP.codigoCargaAcad = Pro.CodigoCargaAcad And " &
            "	PCCP.codigoPeriodo = Pro.codigoPeriodo " &
          "	JOIN (  " &
            "	SELECT NC.nroMatricula"
    sql &= notas &
                " FROM NOTA_CAPACIDAD nc " &
                "WHERE EXISTS( " &
                              "SELECT TOP 1 1 FROM DOCENTE_CARGA DC " &
                                "WHERE DC.codigoCargaAcad = " & docenteCarga.Carga.Codigo &
                                  " AND DC.codigoPeriodo = " & docenteCarga.Periodo.Codigo &
                                  "	AND NC.codigoDocenteCarga = DC.codigoDocenteCarga) " &
                    "AND nc.vigencia = 1 " &
                "GROUP BY NC.nroMatricula " &
              ") AS NC ON NC.nroMatricula = Pro.nroMatricula " &
            "WHERE(pro.CodigoCargaAcad = " & docenteCarga.Carga.Codigo &
              " AND Pro.codigoPeriodo = " & docenteCarga.Periodo.Codigo & ") " &
              "	AND pro.vigencia = 1 " &
          "GROUP BY M.nroOrden, p.apellidoPat, p.apellidoMat, p.nombre,  " &
            " pro.promedio" & agrupado &
          " ORDER BY p.apellidoPat, p.apellidoMat, p.nombre"

    Return sql
  End Function

End Class
