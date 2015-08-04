Public Class RNEntidadFinanciera
  Inherits CADO

  Public Function Listar() As List(Of EntidadFinanciera)
    Dim le As New List(Of EntidadFinanciera)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liEntidadFin", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        le.Add(New EntidadFinanciera(CInt(dr.Item("codigoEntidad")), dr.Item("nombre").ToString))
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

  Public Function ListarCuentas(ByVal wEntidad As EntidadFinanciera) As List(Of CuentaBancaria)
    Dim lista As List(Of CuentaBancaria) = Nothing
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim iNumero, iMoneda As Integer

    pars.Add(New CParametro("@Entidad", wEntidad.Codigo))

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liCuentasBancarias", pars)
      iNumero = dr.GetOrdinal("NumeroCuenta")
      iMoneda = dr.GetOrdinal("Moneda")
      lista = New List(Of CuentaBancaria)
      Do While dr.Read
        lista.Add(New CuentaBancaria(dr.GetString(iNumero), "", dr.GetBoolean(iMoneda), 0, wEntidad))
      Loop

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try

    Return lista
  End Function

End Class
