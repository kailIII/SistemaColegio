Public Class RNDRE

  Public Function DatosDRE() As List(Of DRE)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lDatosDRE", cn)
    Dim dr As SqlDataReader = Nothing
    Dim d As New List(Of DRE)

    cmd.CommandType = CommandType.StoredProcedure
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      Do While (dr.Read)
        d.Add(New DRE(dr.GetInt16(dr.GetOrdinal("codigoDRE")), dr.GetString(dr.GetOrdinal("direccion")), dr.GetString(dr.GetOrdinal("telefono")), dr.Item("nombreDRE").ToString, dr.GetString(dr.GetOrdinal("nombreContacto")), dr.Item("codigoUGEL").ToString))
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

    Return d
  End Function

  Public Function DatosDRE1() As DRE
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lDatosDRE1", cn)
    Dim dr As SqlDataReader = Nothing
    Dim d As DRE = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      If dr.Read Then
        d = New DRE(0, "", "", dr.Item("nombreDRE").ToString, "", dr.Item("codigoUGEL").ToString)
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

    Return d
  End Function

  Public Sub Registrar(ByVal obj As DRE)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iDRE", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Nombre", obj.NombreDRE)
      .AddWithValue("@Direccion", obj.Direccion)
      .AddWithValue("@Contacto", obj.NombreContacto)
      .AddWithValue("@Telefono", obj.Telefono)
      .AddWithValue("@CodigoUgel", obj.CodigoUGEL)
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

  Public Sub Actualizar(ByVal obj As DRE)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aDRE", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Codigo", obj.Codigo)
      .AddWithValue("@Nombre", obj.NombreDRE)
      .AddWithValue("@Direccion", obj.Direccion)
      .AddWithValue("@Contacto", obj.NombreContacto)
      .AddWithValue("@Telefono", obj.Telefono)
      .AddWithValue("@CodigoUgel", obj.CodigoUGEL)
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

  Public Function LeerNombreDRE(ByVal obj As DRE) As String
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lDRE", cn)
    Dim d As String

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Codigo", obj.Codigo)
    End With

    Try
      cn.Open()
      d = CStr(cmd.ExecuteScalar)
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

    Return d
  End Function
End Class
