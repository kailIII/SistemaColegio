Public Class RNCapacidad
  Inherits CADO

  Public Sub Registrar(ByVal obj As Capacidad)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iCapacidad", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Nombre", obj.Nombre)
      .AddWithValue("@CodigoArea", obj.AreaDre.Codigo)
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

  Public Sub Actualizar(ByVal obj As Capacidad)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aCapacidad", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoCap", obj.Codigo)
      .AddWithValue("@Nombre", obj.Nombre)
      .AddWithValue("@Vigente", obj.Vigencia)
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

  Public Function ListarCapacidadesArea(ByVal obj As AreaDRE) As List(Of Capacidad)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liCapacidad", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lc As List(Of Capacidad) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoArea", obj.Codigo)
    Try
      lc = New List(Of Capacidad)
      cn.Open()
      dr = cmd.ExecuteReader
      Do While dr.Read
        lc.Add(New Capacidad(CInt(dr.Item("codigoCapac")), dr.GetString(dr.GetOrdinal("nombre")), New AreaDRE(), CBool(dr.Item("vigencia"))))
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

  Public Function ListarCapacidadesGrupo(ByVal obj As Curso) As List(Of Capacidad)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liCapacidadesGrupo", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lc As List(Of Capacidad) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodCurso", obj.Codigo)
    Try
      lc = New List(Of Capacidad)
      cn.Open()
      dr = cmd.ExecuteReader
      Do While dr.Read
        lc.Add(New Capacidad(CInt(dr.Item("codigoCapac")), dr.GetString(dr.GetOrdinal("nombre")), New AreaDRE(CInt(dr.Item("codigoAreaD"))), True))
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

  Public Function ListarCapacidadesCurso(ByVal obj As Curso) As List(Of Capacidad)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liCapacidadesCur", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lc As List(Of Capacidad) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoCur", obj.Codigo)
    Try
      lc = New List(Of Capacidad)
      cn.Open()
      dr = cmd.ExecuteReader
      Do While dr.Read
        lc.Add(New Capacidad(CInt(dr.Item("codigoCapac")), dr.GetString(dr.GetOrdinal("nombre")), New AreaDRE(CInt(dr.Item("codigoAreaD"))), True))
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

End Class
