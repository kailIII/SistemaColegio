Public Class RNMovimientoHistorico
  Inherits CADO

  Public Function verificarExistencia(ByVal wmovH As MovimientoHistorico) As Integer
    Dim o As Integer = 0
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_fverificarMov", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@fecha", wmovH.fecha)
    cmd.Parameters.AddWithValue("@numeroCuenta", wmovH.CuentaBancaria.Numero.Trim)

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        o = CInt(dr.Item("codigoMovHistorico"))
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
    Return o
  End Function

  Public Function Registrar(ByVal wMovHistorico As MovimientoHistorico) As MovimientoHistorico
    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@codigoMovHistorico", 0, CParametro.DireccionParametro.SALIDA), _
                                    New CParametro("@Fecha", wMovHistorico.fecha), _
                                    New CParametro("@numeroCuenta", wMovHistorico.CuentaBancaria.Numero)})
    Try
      Me.Conectar(False)
      Me.EjecutarOrden("pr_iMovimientoHistorico", pars)
      wMovHistorico.Codigo = CInt(pars.Item(0).Valor)
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally

    End Try

    Return wMovHistorico
  End Function

End Class
