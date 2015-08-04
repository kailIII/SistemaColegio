Public Class RNCuenta

  Public Sub Registrar(ByVal wCuenta As CuentaContable)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iCuenta", cn)


    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigoCtaContable", wCuenta.Codigo)
      .AddWithValue("codigoCtaPadre", wCuenta.CodigoPadre)
      .AddWithValue("@nombre", wCuenta.Nombre)
      .AddWithValue("@descripcion", wCuenta.Descripcion)
      .AddWithValue("@vigencia", wCuenta.Vigencia)
      .AddWithValue("@nivel", wCuenta.Nivel)
      .AddWithValue("@tipo", wCuenta.Tipo)
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
      wCuenta = Nothing
    End Try

  End Sub

  Public Sub Modificar(ByVal codigo As String, ByVal wCuenta As CuentaContable)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aCuenta", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigo", codigo)
      .AddWithValue("@codigoCtaContable", wCuenta.Codigo)
      .AddWithValue("codigoCtaPadre", wCuenta.CodigoPadre)
      .AddWithValue("@nombre", wCuenta.Nombre)
      .AddWithValue("@descripcion", wCuenta.Descripcion)
      .AddWithValue("@vigencia", wCuenta.Vigencia)
      .AddWithValue("@nivel", wCuenta.Nivel)
      .AddWithValue("@tipo", wCuenta.Tipo)
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
      wCuenta = Nothing
    End Try

  End Sub
  Public Function Leer(ByVal wCur As CuentaContable) As CuentaContable
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lCuentaCodigo", cn)
    Dim dr As SqlDataReader = Nothing
    Dim c As CuentaContable = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@codigoCtaContable", wCur.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      If dr.Read = True Then
        c = New CuentaContable(dr.Item("codigoCtaContable").ToString.Trim, dr.Item("codigoCtaPadre").ToString, dr.Item("nombre").ToString, "".ToString, True, CInt(dr.Item("nivel")), _
                                           CStr(dr.Item("tipo")))

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

    Return c
  End Function

  Public Function Listar(ByVal wvigencia As Boolean) As List(Of CuentaContable)
    Dim lc As New List(Of CuentaContable)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liCuenta", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@vigencia", wvigencia)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        lc.Add(New CuentaContable(dr.Item("codigoCtaContable").ToString, dr.Item("codigoCtaPadre").ToString, dr.Item("nombre").ToString, "".ToString, True, CInt(dr.Item("nivel")), dr.Item("tipo").ToString))
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
End Class
