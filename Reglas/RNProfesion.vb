Public Class RNProfesion
  Public Sub Registrar(ByVal obj As Profesion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iProfesion", cn)
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

  Public Sub Modificar(ByVal obj As Profesion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aProfesion", cn)
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

  Public Function ListarProfesiones() As List(Of Profesion)
    Dim le As New List(Of Profesion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liProfesiones", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure

    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        le.Add(New Profesion(CInt(dr.Item("codigoProfesion")), dr.Item("nombre").ToString))
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

  Public Function ListarProfesiones_Nombre(ByVal wnombre As String) As List(Of Profesion)
    Dim le As New List(Of Profesion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liProfesiones_nombre", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Nombre", wnombre)

    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        le.Add(New Profesion(CInt(dr.Item("codigoProfesion")), dr.Item("nombre").ToString))
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

  Public Function LeerProfesion_Codigo(ByVal obj As Profesion) As Profesion
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lProfesion_Codigo", cn)
    Dim dr As SqlDataReader = Nothing
    Dim l As Profesion = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Codigo", obj.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      If dr.Read = True Then
        l = New Profesion(obj.Codigo, dr.Item("nombre").ToString)
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
