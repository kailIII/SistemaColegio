Public Class RNPresentacion
  Inherits CADO

  Public Sub Registrar(ByVal Obj As Presentacion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iPresentacion", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Nro", Obj.Numero)
      .AddWithValue("@FechaIni", Obj.Inicio)
      .AddWithValue("@FechaFin", Obj.Fin)
      .AddWithValue("@Anio", Obj.Anio)

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

  Public Sub Actualizar(ByVal Obj As Presentacion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aPresentacion", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Codigo", Obj.Codigo)
      .AddWithValue("@Nro", Obj.Numero)
      .AddWithValue("@FechaIni", Obj.Inicio)
      .AddWithValue("@FechaFin", Obj.Fin)
      .AddWithValue("@Anio", Obj.Anio)
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

  Public Function ListarPresentaciones(ByVal wanio As String) As List(Of Presentacion)
    Dim la As New List(Of Presentacion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liPresentaciones", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Anio", wanio)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        la.Add(New Presentacion(CInt(dr.Item("CodigoPresFecha")), CInt(dr.Item("nro")), CDate(dr.Item("fechaIni")), _
                                CDate(dr.Item("fechaFin")), wanio, CBool(dr.Item("vigencia"))))
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

  Public Function LeerPresentacion_Codigo(ByVal obj As Presentacion) As Presentacion
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lPresentacion_Codigo", cn)
    Dim dr As SqlDataReader = Nothing
    Dim pres As Presentacion = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Codigo", obj.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      If dr.Read = True Then
        pres = New Presentacion(obj.Codigo, CInt(dr.Item("nro")), CDate(dr.Item("fechaIni")), _
                                CDate(dr.Item("fechaFin")), "", CBool(dr.Item("vigencia")))
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

    Return pres
  End Function

  Public Function ListarPresVigentes(ByVal wanio As String) As List(Of Presentacion)
    Dim la As New List(Of Presentacion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liPresVigentes", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Anio", wanio)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        la.Add(New Presentacion(CInt(dr.Item("CodigoPresFecha")), CInt(dr.Item("nro")), CDate(dr.Item("fechaIni")), _
                                CDate(dr.Item("fechaFin")), wanio, CBool(dr.Item("vigencia"))))
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

  Public Function ListarResponsables(ByVal wPresentacion As Presentacion) As List(Of Docente)
    Dim pars As New List(Of CParametro)
    Dim docentes As List(Of Docente) = Nothing
    Dim dr As SqlDataReader
    Dim iCod, iNombres, iApPat, iApMat As Integer

    pars.Add(New CParametro("@Presentacion", wPresentacion.Codigo))
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liDocentesAsignadosProgramacion", pars)
      iCod = dr.GetOrdinal("CodigoPersona")
      iNombres = dr.GetOrdinal("nombre")
      iApPat = dr.GetOrdinal("ApellidoPat")
      iApMat = dr.GetOrdinal("ApellidoMat")

      docentes = New List(Of Docente)
      While dr.Read
        docentes.Add(New Docente With {.Codigo = dr.GetInt32(iCod), _
                                        .Nombre = dr.GetString(iNombres), _
                                        .ApellidoPaterno = dr.GetString(iApPat), _
                                        .ApellidoMaterno = dr.GetString(iApMat) _
                                        })
      End While

      Me.Conectar(True)
    Catch ex As Exception
      Me.Conectar(False)
      Throw
    Finally
      pars.Clear()
      pars = Nothing
    End Try

    Return docentes
  End Function

End Class
