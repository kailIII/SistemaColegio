
Public Class RNAreaDRE
  Inherits CADO

  Public Sub Registrar(ByVal obj As AreaDRE)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iAreaDRE", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Nombre", obj.Nombre)
      .AddWithValue("@CodigoNivel", obj.ONivel.Codigo)
      .AddWithValue("@CodigoDRE", obj.ODRE.Codigo)
      .AddWithValue("@OrdenActa", obj.OrdenActa)
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

  Public Function ListarAreaDRE(ByVal obj As AreaDRE) As List(Of AreaDRE)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAreaDRE", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ad As New List(Of AreaDRE)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoNivel", obj.ONivel.Codigo)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader

      Do While (dr.Read)
        ad.Add(New AreaDRE(dr.GetInt16(dr.GetOrdinal("codigoAreaD")), dr.GetString(dr.GetOrdinal("nombreAreaD")), _
                           New DRE(dr.GetInt16(dr.GetOrdinal("codigoDRE")), "", "", "", "", ""), _
                           New Nivel((CInt(dr.GetOrdinal("CodigoNivel"))), dr.GetString(dr.GetOrdinal("nombreNivel")), "")))
        ad.Item(ad.Count - 1).OrdenActa = CInt(dr.Item("OrdenActa"))
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

    Return ad
  End Function

  Public Function Listar_Nivel(ByVal wNivel As Nivel) As List(Of AreaDRE)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAreasD", cn)
    Dim la As List(Of AreaDRE) = Nothing
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoNivel", wNivel.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      la = New List(Of AreaDRE)
      Do While dr.Read
        la.Add(New AreaDRE(dr.GetInt16(dr.GetOrdinal("codigoAreaD")), dr.GetString(dr.GetOrdinal("nombreAreaD")), Nothing, wNivel))
        'la.Item(la.Count - 1).OrdenActa = CInt(dr.Item("OrdenActa"))
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
    Return la
  End Function

  Public Sub Actualizar(ByVal obj As AreaDRE)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aAreaDRE", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoNivel ", obj.ONivel.Codigo)
      .AddWithValue("@CodigoDRE", obj.ODRE.Codigo)
      .AddWithValue("@CodigoAreaDRE", obj.Codigo)
      .AddWithValue("@Nombre", obj.Nombre)
      .AddWithValue("@OrdenActa", obj.OrdenActa)
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

  Public Function RetornaCodArea(ByVal obj As AreaDRE) As Integer
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lCodArea", cn)
    Dim dr As Integer


    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Nombre", obj.Nombre)
    cmd.Parameters.AddWithValue("@CodigoNivel", obj.ONivel.Codigo)
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

  Public Function ListarAreasSeccion(ByVal obj As AnioLectivo) As List(Of AreaDRE)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAreasSec", cn)
    Dim la As List(Of AreaDRE) = Nothing
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Anio", obj.Anio)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      la = New List(Of AreaDRE)
      Do While dr.Read
        la.Add(New AreaDRE(dr.GetInt16(dr.GetOrdinal("codigoAreaD")), dr.GetString(dr.GetOrdinal("nombreAreaD")), Nothing, Nothing))
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
    Return la
  End Function

  Public Function ListarAreasSecundaria() As List(Of AreaDRE)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAreasSecundaria", cn)
    Dim la As List(Of AreaDRE) = Nothing
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      la = New List(Of AreaDRE)
      Do While dr.Read
        la.Add(New AreaDRE(dr.GetInt16(dr.GetOrdinal("codigoAreaD")), dr.GetString(dr.GetOrdinal("nombreAreaD")), Nothing, Nothing))
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
    Return la
  End Function

End Class
