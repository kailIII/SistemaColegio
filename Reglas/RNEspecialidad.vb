
Public Class RNEspecialidad

  Public Function ListarEsp() As List(Of Especialidad)
    Dim le As New List(Of Especialidad)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liEspecialidades", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure

    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        le.Add(New Especialidad(dr.Item("nombre").ToString))
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

  Public Sub Registrar(ByVal obj As Especialidad)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iEspecialidad", cn)

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

  Public Function Buscar(ByVal objE As Especialidad) As Integer
    Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_lEspecialidad", cn)
    Dim dr As Integer


    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@nombre", objE.Nombre)
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

  Public Function RetornaNom(ByVal objE As Especialidad) As String
    Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_lNombre", cn)
    Dim dr As String

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@codigo", objE.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteScalar.ToString
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

End Class
