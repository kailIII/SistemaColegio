Public Class RNUnidad
  Inherits CADO

  Public Sub Registrar(ByVal Obj As Unidad)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iUnidad", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoPeriodo", Obj.Periodo.Codigo)
      .AddWithValue("@CodigoDocenteCarga", Obj.DocenteCarga.Codigo)
      .AddWithValue("@Nombre", Obj.Nombre)
      .AddWithValue("@NroUni", Obj.Numero)
      .AddWithValue("@vigencia", Obj.Vigencia)
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
      Obj = Nothing
    End Try
  End Sub

  Public Sub Actualizar(ByVal Obj As Unidad)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aUnidad", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoPer", Obj.Periodo.Codigo)
      .AddWithValue("@CodigoDocCarga", Obj.DocenteCarga.Codigo)
      .AddWithValue("@NroUni", Obj.Numero)
      .AddWithValue("@Nombre", Obj.Nombre)
      .AddWithValue("@Vigencia", Obj.Vigencia)
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
      Obj = Nothing
    End Try

  End Sub

  Public Function ListarUnidades(ByVal obj As DocenteCarga) As List(Of Unidad)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liUnidades", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ld As List(Of Unidad) = Nothing

    cmd.Parameters.AddWithValue("@CodigoDocCarga", obj.Codigo)
    cmd.Parameters.AddWithValue("@CodigoPeriodo", obj.Periodo.Codigo)
    cmd.CommandType = CommandType.StoredProcedure
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ld = New List(Of Unidad)
      While dr.Read
        ld.Add(New Unidad(CInt(dr.Item("nroUni")), dr.Item("nombre").ToString, CBool(dr.Item("vigencia")), obj.Periodo, obj))
      End While
      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      dr.Dispose()
      dr = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try

    Return ld
  End Function

  Public Function ListarUnidades(ByVal obj As Unidad) As List(Of Unidad)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liTodasUnidades", cn)
    Dim dr As SqlDataReader
    Dim liU As List(Of Unidad) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodPeriodo", obj.Periodo.Codigo)
      .AddWithValue("@CodDocCarga", obj.DocenteCarga.Codigo)
    End With
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      liU = New List(Of Unidad)
      While dr.Read
        liU.Add(New Unidad(CInt(dr.Item("nroUni")), dr.GetString(dr.GetOrdinal("nombre")), dr.GetBoolean(dr.GetOrdinal("vigencia")), _
                           obj.Periodo, obj.DocenteCarga))
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

    Return liU
  End Function

  Public Function ListarUnidadesCurso(ByVal obj As Unidad) As List(Of Unidad)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liUnidadesCurso", cn)
    Dim dr As SqlDataReader
    Dim liU As List(Of Unidad) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoDoc", obj.DocenteCarga.Docente.Codigo)
      .AddWithValue("@CodigoG", obj.DocenteCarga.Carga.Seccion.Grado.Codigo)
      .AddWithValue("@CodigoCur", obj.DocenteCarga.Carga.Curso.Codigo)
      .AddWithValue("@Anio", obj.DocenteCarga.Carga.Seccion.Anio.Anio)
      .AddWithValue("@Letra", obj.DocenteCarga.Carga.Letra)
      .AddWithValue("@CodigoPer", obj.DocenteCarga.Periodo.Codigo)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      liU = New List(Of Unidad)
      While dr.Read
        liU.Add(New Unidad(CInt(dr.Item("NROUNI")), dr.Item("NOMBRE").ToString, True, New PeriodoAcademico() _
                           , New DocenteCarga()))
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

    Return liU
  End Function

  Public Function RetornaUnidadesCurso(ByVal obj As Unidad) As Integer
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liNroUni", cn)
    Dim dr As Integer

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Periodo", obj.Periodo.Codigo)
      .AddWithValue("@DocCarga", obj.DocenteCarga.Codigo)
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

#Region "Listado de notas por unidad"

  Public Function ListarNotas(ByVal wUnidad As Unidad, ByVal wCapacidades As List(Of Capacidad)) As DataTable
    Dim dt As DataTable

    Try
      Me.Conectar(True)
      Me.LlenarCapacidades(wUnidad.DocenteCarga.Carga.Curso, wCapacidades)
      dt = Me.CrearListadoNotas(wUnidad, wCapacidades)
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    End Try

    Return dt
  End Function

  Private Function CrearListadoNotas(ByVal wUnidad As Unidad, ByVal wCapacidades As List(Of Capacidad)) As DataTable
    Dim dt As New DataTable
    Dim sql As String
    Dim exp As String = ""
    Dim i As Integer = 1

    sql = "SELECT M.nroMatricula, M.nroOrden, P.apellidoPat + ' ' + P.apellidoMat + ' ' + P.nombre AS NombreCompleto"
    For Each cap As Capacidad In wCapacidades
      sql &= ", SUM( CASE WHEN N.codigoCapac = " & cap.Codigo & " THEN N.promedio ELSE NULL END ) AS Cap" & i.ToString("00")
      exp &= "Cap" & i.ToString("00") & " + "
      i += 1
    Next
    sql &= " FROM Grupo G JOIN Matricula M ON M.nroMatricula = G.nroMatricula " & _
      "JOIN Persona P ON P.codigoPersona = M.codigoAlumno " & _
      "LEFT OUTER JOIN (  SELECT NC.nroMatricula, NC.codigoCapac, NC.promedio " & _
        "FROM NOTA_CAPACIDAD NC  " & _
        "WHERE(NC.codigoPeriodo = " & wUnidad.Periodo.Codigo & " And NC.nroUni = " & wUnidad.Numero & " And NC.codigoDocenteCarga = " & wUnidad.DocenteCarga.Codigo & ") " & _
          "AND NC.vigencia = 1 " & _
      ") AS N ON N.nroMatricula = m.nroMatricula " & _
      "WHERE M.vigencia = 1 And G.codigoDocenteCarga = " & wUnidad.DocenteCarga.Codigo & _
      " GROUP BY M.nroMatricula, M.nroOrden,  P.nombre, P.apellidoPat, P.apellidoMat " & _
      "ORDER BY M.nroOrden"

    dt = Me.EjecutarSQLDatos(sql)
    dt.Columns.Add("Promedio", GetType(Double), "(" & exp.Substring(0, exp.Length - 2) & ") / " & wCapacidades.Count)

    Return dt
  End Function

  Private Sub LlenarCapacidades(ByVal wCurso As Curso, ByVal wCapacidades As List(Of Capacidad))
    Dim dr As SqlDataReader = Nothing
    Dim parsCap As New List(Of CParametro)
    Dim cap As Capacidad
    Dim iCodigo, iNombre, iCodigoArea As Integer

    parsCap.Add(New CParametro("@CodigoCur", wCurso.Codigo))
    Try
      dr = Me.PedirDataReader("pr_liCapacidadesCur", parsCap)
      iCodigo = dr.GetOrdinal("codigoCapac")
      iNombre = dr.GetOrdinal("nombre")
      iCodigoArea = dr.GetOrdinal("codigoAreaD")
      While dr.Read
        cap = New Capacidad()
        With cap
          .Codigo = dr.GetByte(iCodigo)
          .Nombre = dr.GetString(iNombre)
          .AreaDre = New AreaDRE() With {.Codigo = dr.GetInt16(iCodigoArea)}
        End With

        wCapacidades.Add(cap)
      End While
    Catch ex As Exception
      Throw ex
    Finally
      If dr IsNot Nothing Then
        dr.Close()
      End If
    End Try

  End Sub

#End Region

End Class
