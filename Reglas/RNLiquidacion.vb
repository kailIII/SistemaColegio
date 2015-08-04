Public Class RNLiquidacion
  Inherits CADO

  Public Sub Registrar(ByVal wliquid As Liquidacion)
    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@Numero", wliquid.Numero), _
                                    New CParametro("@Entidad", wliquid.Entidad), _
                                    New CParametro("@Fecha", wliquid.Fecha)})
    Try
      Me.Conectar(False)
      Me.EjecutarOrden("pr_iLiquidacion", pars)

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      pars.Clear()
      pars = Nothing
    End Try
  End Sub

  Public Function LeerNumero(ByVal wLiquidacion As Liquidacion) As Liquidacion
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim liq As Liquidacion = Nothing

    pars.AddRange(New CParametro() {New CParametro("@Entidad", wLiquidacion.Entidad), _
                                    New CParametro("@Fecha", wLiquidacion.Fecha)})
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_lLiquidacion_EntidadFecha", pars)
      If dr.Read Then
        liq = New Liquidacion With {.Entidad = wLiquidacion.Entidad, .Fecha = wLiquidacion.Fecha}

        liq.Codigo = dr.GetInt16(dr.GetOrdinal("nroLiquidacion"))
        liq.Numero = dr.GetInt16(dr.GetOrdinal("numero"))
      End If
    Catch ex As Exception
      Throw
    Finally
      pars.Clear()
      pars = Nothing
    End Try

    Return liq
  End Function

  Public Function ObtenerNumero(ByVal wEntidad As String, ByVal wAnio As Integer) As Liquidacion
    Dim liq As New Liquidacion
    Dim dr As SqlDataReader
    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@Entidad", wEntidad), _
                                    New CParametro("@Anio", wAnio)})
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_lLiquidacion_NumeroNuevo", pars)
      If dr.Read Then
        liq.Numero = dr.GetInt16(dr.GetOrdinal("Numero")) + 1
      Else
        liq.Numero = 1
      End If

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      pars.Clear()
      pars = Nothing
    End Try

    Return liq
  End Function

End Class
