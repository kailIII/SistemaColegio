Public Class RNVoucher
  Inherits CADO

  Public Function Leer(ByVal wVoucher As VoucherPago) As VoucherPago
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim v As VoucherPago = Nothing

    pars.AddRange(New CParametro() {New CParametro("@Fecha", wVoucher.Fecha), _
                                    New CParametro("@Operacion", wVoucher.NumOperacion)})

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_lPagoOperacion", pars)
      If dr.Read Then
        v = New VoucherPago
        v.CuentaBancaria = New CuentaBancaria
        v.CuentaBancaria.Numero = dr.GetString(dr.GetOrdinal("numeroCuenta"))
        v.CuentaBancaria.EntidadFinanciera = New EntidadFinanciera With {.Codigo = dr.GetByte(dr.GetOrdinal("codigoEntidad"))}
        v.Monto = dr.GetDecimal(dr.GetOrdinal("Monto"))
      End If

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      pars.Clear()
    End Try

    Return v
  End Function

End Class
