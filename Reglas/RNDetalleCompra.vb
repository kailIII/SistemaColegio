Public Class RNDetalleCompra
  Inherits CADO

  Function listarDetalleCompraCajaChica(ByVal codigoCompra As Integer) As List(Of DetalleCompra)
    Dim pars As New List(Of CParametro)
    pars.AddRange({New CParametro("@codigoCompra", codigoCompra)})
    Dim listaDetalleCompra As New List(Of DetalleCompra)
    Dim dr As SqlDataReader
    Dim cantidad As Integer, precioTotal As Integer, descripcion As Integer,
      nombre As Integer, tipo As Integer, codigoConcepto As Integer

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liDetalleCompraCajaChica", pars)
      cantidad = dr.GetOrdinal("cantidad")
      precioTotal = dr.GetOrdinal("precioTotal")
      descripcion = dr.GetOrdinal("descripcion")
      nombre = dr.GetOrdinal("nombre")
      tipo = dr.GetOrdinal("tipo")
      codigoConcepto = dr.GetOrdinal("codigoConceptoCompra")
      While dr.Read
        listaDetalleCompra.Add(New DetalleCompra() With {.cantidad = dr.GetInt16(cantidad), _
                                                         .precioTotal = dr.GetDecimal(precioTotal), _
                                                         .descripcion = dr.GetString(descripcion), _
                                                         .ConceptoCompra = New ConceptoCompra() With
                                                                           {.codigoConceptoCompra = dr.GetInt32(codigoConcepto), _
                                                                            .nombre = dr.GetString(nombre)}})
      End While
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try
    Return listaDetalleCompra
  End Function
	

End Class