Public Class RNEquivalencia

  Public Sub Registrar(ByVal obj As Equivalencia)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iEquivalencia", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Literal", obj.Literal)
      .AddWithValue("@Puntos", obj.Puntos)
      .AddWithValue("@Especificacion", IIf(obj.Especificacion.Length > 0, obj.Especificacion, DBNull.Value))
      .AddWithValue("@codigoInst", obj.OInstitucion.CodigoInst)
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
      obj = Nothing
    End Try
  End Sub

  Public Sub Actualizar(ByVal Obj As Equivalencia)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aEquivalencia", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodEqui", Obj.Codigo)
      .AddWithValue("@Literal", Obj.Literal)
      .AddWithValue("@Puntos", Obj.Puntos)
      .AddWithValue("@Especific", IIf(Obj.Especificacion.Length > 0, Obj.Especificacion, DBNull.Value))
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

  Public Function ListarEquivalencias() As List(Of Equivalencia)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liEquivalencia", cn)
    Dim dr As SqlDataReader = Nothing
    Dim le As List(Of Equivalencia) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      le = New List(Of Equivalencia)
      While dr.Read
        le.Add(New Equivalencia(CInt(dr.Item("codigoNotaV")), dr.Item("literal").ToString, _
                        CInt(dr.Item("puntos")), dr.Item("especificacion").ToString, _
                         CBool(dr.Item("vigencia")), New Institucion()))
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

    Return le
  End Function

End Class
