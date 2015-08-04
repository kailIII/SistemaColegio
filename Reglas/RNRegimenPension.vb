Public Class RNRegimenPension

  Public Sub Registrar(ByVal wRegimenPension As RegimenPension)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iREGIMEN_PENSION", cn)
    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@nroRegimenPension", wRegimenPension.nroRegimenPension)
      .AddWithValue("@nombre", wRegimenPension.nombre)
      .AddWithValue("@vigencia", wRegimenPension.vigencia)
      .AddWithValue("@porcentajeAporte", wRegimenPension.porcentajeAporte)
      .AddWithValue("@porcentajePrima", wRegimenPension.porcentajePrima)
      .AddWithValue("@porcentajeComision", wRegimenPension.porcentajeComision)
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
  Public Sub Modificar(ByVal wRegimenPension As RegimenPension)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aREGIMEN_PENSION", cn)
    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@nroRegimenPension", wRegimenPension.nroRegimenPension)
      .AddWithValue("@nombre", wRegimenPension.nombre)
      .AddWithValue("@vigencia", wRegimenPension.vigencia)
      .AddWithValue("@porcentajeAporte", wRegimenPension.porcentajeAporte)
      .AddWithValue("@porcentajePrima", wRegimenPension.porcentajePrima)
      .AddWithValue("@porcentajeComision", wRegimenPension.porcentajeComision)
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
  Public Function Leer(ByVal wRegimenPension As RegimenPension) As RegimenPension
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lREGIMEN_PENSION", cn)
    Dim dr As SqlDataReader = Nothing
    Dim dato As RegimenPension = Nothing
    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@nroRegimenPension", wRegimenPension.nroRegimenPension)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader()
      If dr.Read = True Then
        dato = New RegimenPension(wRegimenPension.nroRegimenPension, CStr(dr.Item("nombre")), CBool(dr.Item("vigencia")), CDbl(dr.Item("porcentajeAporte")), CDbl(dr.Item("porcentajePrima")), CDbl(dr.Item("porcentajeComision")))
      End If
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
    Return dato
  End Function
  Public Function Listar() As List(Of RegimenPension)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liREGIMEN_PENSION", cn)
    Dim dr As SqlDataReader = Nothing
    Dim datos As List(Of RegimenPension) = Nothing
    Dim iNro As Integer
    Dim iNomb As Integer
    Dim iVig As Integer
    cmd.CommandType = CommandType.StoredProcedure

    Try
      cn.Open()
      dr = cmd.ExecuteReader()
      iNro = dr.GetOrdinal("nroRegimenPension")
      iNomb = dr.GetOrdinal("Nombre")
      iVig = dr.GetOrdinal("Vigencia")
      Do While dr.Read = True
        datos.Add(New RegimenPension() With {.nroRegimenPension = dr.GetString(iNro), .nombre = dr.GetString(iNomb), _
                                             .vigencia = dr.GetBoolean(iVig)})
      Loop
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
    Return datos
  End Function

End Class