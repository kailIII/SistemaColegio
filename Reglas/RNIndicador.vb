Public Class RNIndicador
  Public Sub Registrar(ByVal Obj As Indicador)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iIndicador", cn)


    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoPeriodo", Obj.Periodo)
      .AddWithValue("@CodigoDocenteCarga", Obj.DocenteCarga)
      .AddWithValue("@Nombre", Obj.Nombre)
            .AddWithValue("@vigencia", Obj.Vigencia)
            .AddWithValue("@Numero", Obj.Nro)

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
  Public Sub Actualizar(ByVal Obj As Indicador)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aIndicador", cn)


    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoIndicador", Obj.Codigo)
      .AddWithValue("@CodigoDocenteCarga", Obj.DocenteCarga)
      .AddWithValue("@Nombre", Obj.Nombre)
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
 
  Public Function ListarIndicadores_Seccion(ByVal obj As DocenteCarga) As List(Of Indicador)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liIndicadores_Seccion", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ld As New List(Of Indicador)

    cmd.Parameters.AddWithValue("@Codigo", obj.Codigo)
    cmd.Parameters.AddWithValue("@CodigoPeriodo", obj.Periodo.Codigo)

    cmd.CommandType = CommandType.StoredProcedure
    Try

      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        ld.Add(New Indicador(CInt(dr.Item("codigoIndicador")), dr.Item("nombre").ToString, CBool(dr.Item("vigencia")), _
                             Nothing, Nothing, CInt(dr.Item("Numero"))))
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

  Public Function ListarIndicadoresMod(ByVal obj As DocenteCarga, ByVal wnombre As String) As List(Of Indicador)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liIndicadores_Mod", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ld As New List(Of Indicador)

    cmd.Parameters.AddWithValue("@Codigo", obj.Codigo)
    cmd.Parameters.AddWithValue("@CodigoPeriodo", obj.Periodo.Codigo)
    cmd.Parameters.AddWithValue("@Nombre", wnombre)

    cmd.CommandType = CommandType.StoredProcedure
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        ld.Add(New Indicador(CInt(dr.Item("codigoIndicador")), dr.Item("nombre").ToString, CBool(dr.Item("vigencia")), _
                             Nothing, Nothing, Nothing))
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

  Public Function Leer(ByVal obj As Indicador) As Indicador
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lIndicadorCodigo", cn)
    Dim dr As SqlDataReader = Nothing
    Dim I As Indicador = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Codigo", obj.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      If dr.Read = True Then
        I = New Indicador(obj.Codigo, dr.Item("nombre").ToString, CBool(dr.Item("vigencia")), _
                             Nothing, Nothing, CInt(dr.Item("Numero")))

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

    Return I
  End Function
  Public Function ListarIndicadoresGrupo(ByVal obj As DocenteCarga) As List(Of Indicador)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liIndicadoresGrupo", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lc As List(Of Indicador) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoDocenteCarga", obj.Codigo)
    cmd.Parameters.AddWithValue("@Codigoperiodo", obj.Periodo.Codigo)

    Try
      lc = New List(Of Indicador)
      cn.Open()
      dr = cmd.ExecuteReader
      Do While dr.Read
        lc.Add(New Indicador(CInt(dr.Item("codigoIndicador")), dr.GetString(dr.GetOrdinal("nombre")), _
                             Nothing, obj.Periodo.Codigo, obj.Codigo, CInt(dr.Item("numero"))))
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
  Public Sub OrdenarUno(ByVal Obj As Indicador)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aOrdenIndicador", cn)


    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoIndicador", Obj.Codigo)
      .AddWithValue("@Numero", Obj.Nro)
      .AddWithValue("@Codigoperiodo", Obj.Periodo)

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
  Public Sub OrdenarTodos(ByVal Obj As Indicador)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aOrdenTodosInd", cn)


    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoIndicador", Obj.Codigo)
      .AddWithValue("@Numero", Obj.Nro)
      .AddWithValue("@Nombre", Obj.Nombre)
      .AddWithValue("@Codigoperiodo", Obj.Periodo)

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
End Class
