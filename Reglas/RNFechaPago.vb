Public Class RNFechaPago
  Inherits CADO

  Public Sub Modificar(ByVal wAnterior As FechaPago, ByVal wNuevo As FechaPago)
    Dim pars As New List(Of CParametro)

    pars.Add(New CParametro("@Anio", wAnterior.Anio.Anio))
    pars.Add(New CParametro("@DescripcionAnterior", wAnterior.Descripcion))
    pars.Add(New CParametro("@DescripcionNuevo", wNuevo.Descripcion))
    pars.Add(New CParametro("@Fecha", wNuevo.Fecha))
    Try
      Me.Conectar(True)
      Me.EjecutarOrden("pr_aCronograma", pars)

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex

    Finally
      pars.Clear()
      pars = Nothing
    End Try
  End Sub

  Public Function Listar(ByVal wAnio As AnioLectivo) As List(Of FechaPago)
    Dim fechas As List(Of FechaPago)
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader

    pars.Add(New CParametro("@Anio", wAnio.Anio))

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liCronogramaAnio", pars)
      fechas = New List(Of FechaPago)

      While dr.Read
        fechas.Add(New FechaPago With {.Anio = wAnio,
                                        .Descripcion = dr.Item("Descripcion").ToString,
                                        .Fecha = CDate(dr.Item("FechaVcto"))})
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars.Clear()
      pars = Nothing
    End Try

    Return fechas
  End Function

End Class
