Public Class RNOcupacion
  Public Sub Registrar(ByVal obj As Ocupacion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iOcupacion", cn)
    cmd.CommandType = CommandType.StoredProcedure

    With cmd.Parameters
      .AddWithValue("@Nombre", obj.Nombre)
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

  Public Sub Modificar(ByVal obj As Ocupacion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aOcupacion", cn)
    cmd.CommandType = CommandType.StoredProcedure

    With cmd.Parameters
      .AddWithValue("@Codigo", obj.Codigo)
      .AddWithValue("@Nombre", obj.Nombre)
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


  Public Function ListarOcupaciones() As List(Of Ocupacion)
    Dim le As New List(Of Ocupacion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liOcupaciones", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure

    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        le.Add(New Ocupacion(CInt(dr.Item("codigoOcupacion")), dr.Item("nombre").ToString))
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
    Return le
  End Function

  Public Function ListarOcupaciones_Nombre(ByVal wnombre As String) As List(Of Ocupacion)
    Dim le As New List(Of Ocupacion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liOcupaciones_nombre", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Nombre", wnombre)

    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        le.Add(New Ocupacion(CInt(dr.Item("codigoOcupacion")), dr.Item("nombre").ToString))
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
    Return le
  End Function

  Public Function LeerOcupacion_Codigo(ByVal obj As Ocupacion) As Ocupacion
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lOcupacion_Codigo", cn)
    Dim dr As SqlDataReader = Nothing
    Dim l As Ocupacion = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Codigo", obj.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      If dr.Read = True Then
        l = New Ocupacion(obj.Codigo, dr.Item("nombre").ToString)
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

    Return l
  End Function
End Class
