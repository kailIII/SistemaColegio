Public Class RNEmpresaService

  Public Sub Registrar(ByVal wEmpresaService As EmpresaService)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iEMPRESA_SERVICE", cn)
    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@RUC", wEmpresaService.RUC)
      .AddWithValue("@razonSocial", wEmpresaService.razonSocial)
      .AddWithValue("@tipoActividad", wEmpresaService.tipoActividad)
      .AddWithValue("@denominacionEstable", wEmpresaService.denominacionEstable)
      .AddWithValue("@centroRiesgo", wEmpresaService.centroRiesgo)
      .AddWithValue("@tasaSCTR", wEmpresaService.tasaSCTR)
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
  Public Sub Modificar(ByVal wEmpresaService As EmpresaService)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aEMPRESA_SERVICE", cn)
    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigoService", wEmpresaService.codigoService)
      .AddWithValue("@RUC", wEmpresaService.RUC)
      .AddWithValue("@razonSocial", wEmpresaService.razonSocial)
      .AddWithValue("@tipoActividad", wEmpresaService.tipoActividad)
      .AddWithValue("@denominacionEstable", wEmpresaService.denominacionEstable)
      .AddWithValue("@centroRiesgo", wEmpresaService.centroRiesgo)
      .AddWithValue("@tasaSCTR", wEmpresaService.tasaSCTR)
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
  Public Function Leer(ByVal wEmpresaService As EmpresaService) As EmpresaService
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lEMPRESA_SERVICE", cn)
    Dim dr As SqlDataReader = Nothing
    Dim dato As EmpresaService = Nothing
    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigoService", wEmpresaService.codigoService)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader()
      If dr.Read = True Then
        dato = New EmpresaService(wEmpresaService.codigoService, CStr(dr.Item("RUC")), CStr(dr.Item("razonSocial")), CStr(dr.Item("tipoActividad")), CStr(dr.Item("denominacionEstable")), CBool(dr.Item("centroRiesgo")), CDbl(dr.Item("tasaSCTR")))
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
  Public Function Listar() As List(Of EmpresaService)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liEmpresa_Service", cn)
    Dim dr As SqlDataReader = Nothing
    Dim datos As List(Of EmpresaService) = Nothing
    Dim icod As Integer
    Dim iraz As Integer
    cmd.CommandType = CommandType.StoredProcedure

    Try
      cn.Open()
      dr = cmd.ExecuteReader()
      icod = dr.GetOrdinal("codigoService")
      iraz = dr.GetOrdinal("razonSocial")
      datos = New List(Of EmpresaService)
      Do While dr.Read = True
        datos.Add(New EmpresaService() With {.codigoService = dr.GetByte(icod), .razonSocial = dr.GetString(iraz)})
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