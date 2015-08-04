Public Class RNAdministrativo
  Inherits CADO

  Public Function Listar() As List(Of Administrativo)
    Dim la As New List(Of Administrativo)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAdministrativo", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        la.Add(New Administrativo(CInt(dr.Item("CodigoPersona")), dr.Item("Nombre").ToString, dr.Item("ApellidoPat").ToString, dr.Item("ApellidoMat").ToString))
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

End Class
