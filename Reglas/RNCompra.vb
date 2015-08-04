Public Class RNCompra
  Inherits CADO
  Public Function RegistrarCompraCajaChicaConcepto(ByVal wCompra As Compra, ByVal wmontoTotal As Double,
                                      ByVal listaDetalles As List(Of DetalleCompra)) As Integer
    Dim pars As New List(Of CParametro)
    Dim xmlDetalle As String

    Try
      Me.Conectar(True)

      xmlDetalle = CrearXMLDetalleCompra(listaDetalles)
      pars.AddRange({New CParametro("@codigoTipoDocumento", wCompra.TipoDocumento.codigoTipoDocumento), _
                  New CParametro("@numeroDocumento", CInt(wCompra.numeroDocumento)), _
                  New CParametro("@codigoBeneficiario", wCompra.Beneficiario.Codigo),
                  New CParametro("@serie", CInt(wCompra.serie)), _
                  New CParametro("@IGV", wCompra.IGV), _
                  New CParametro("@montoTotal", wmontoTotal), _
                  New CParametro("@detallesCompra", xmlDetalle)})
      Dim row = Me.EjecutarOrden("pr_iCompraCajaChica", pars)
      Me.Cerrar(True)
      Return row
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try
  End Function
  Private Function CrearXMLDetalleCompra(ByVal wDetalle As List(Of DetalleCompra)) As String
    Dim cad As String = "<ROOT>"

    For Each pp As DetalleCompra In wDetalle
      cad &= "<DetalleCompra "
      cad &= "descripcion=""" & pp.descripcion & """ "
      cad &= "precioTotal=""" & pp.precioTotal & """ "
      cad &= "cantidad=""" & pp.cantidad & """ "
      cad &= "codigoConceptoCompra=""" & pp.ConceptoCompra.codigoConceptoCompra & """ "
      cad &= "nombre=""" & pp.ConceptoCompra.nombre & """ "
      cad &= "/>"
    Next
    cad &= "</ROOT>"

    Return cad
  End Function

  Public Function listarCompraCajaChica(ByVal fechaInicio As DateTime, ByVal fechaFin As DateTime) As List(Of Compra)
    Dim pars As New List(Of CParametro)
    Dim A = fechaFin.AddDays(1)
    pars.AddRange({New CParametro("@fechaInicio", fechaInicio), _
                   New CParametro("@fechaFin", fechaFin.AddDays(1))})
    Dim listaCompra As New List(Of Compra)
    Dim dr As SqlDataReader
    Dim codigoCompra As Integer, fecha As Integer, codigoBeneficiario As Integer, serie As Integer,
      IGV As Integer, numero As Integer, nombre As Integer, tipoD As Integer, apellidoPat As Integer,
       apellidoMat As Integer, descripcionTipo As Integer, montoTotal As Integer

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liCompraCajaChica", pars)
      codigoCompra = dr.GetOrdinal("codigoCompra")
      fecha = dr.GetOrdinal("fecha")
      codigoBeneficiario = dr.GetOrdinal("codigoBeneficiario")
      numero = dr.GetOrdinal("numeroDocumento")
      montoTotal = dr.GetOrdinal("monto")
      tipoD = dr.GetOrdinal("codigoTipoDocumento")
      descripcionTipo = dr.GetOrdinal("descripcionTipoDocumento")
      serie = dr.GetOrdinal("serie")
      nombre = dr.GetOrdinal("nombre")
      apellidoPat = dr.GetOrdinal("apellidoPat")
      apellidoMat = dr.GetOrdinal("apellidoMat")
      IGV = dr.GetOrdinal("IGV")
      While dr.Read
        listaCompra.Add(New Compra() With {.codigoCompra = dr.GetInt32(codigoCompra), _
                                           .fecha = dr.GetDateTime(fecha), _
                                           .Beneficiario = New Personal() With {.Codigo = dr.GetInt32(codigoBeneficiario), _
                                                                                .Nombre = dr.GetString(nombre), _
                                                                                .ApellidoPaterno = dr.GetString(apellidoPat), _
                                                                                .ApellidoMaterno = dr.GetString(apellidoMat)}, _
                                           .numeroDocumento = dr.GetString(numero), _
                                           .TipoDocumento = New TipoDocumento() With {.codigoTipoDocumento = dr.GetByte(tipoD), _
                                                                                   .descripcion = dr.GetString(descripcionTipo)}, _
                                           .serie = dr.GetString(serie), _
                                           .IGV = dr.GetDecimal(IGV), _
                                           .monto = dr.GetDecimal(montoTotal)})
      End While
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try
    Return listaCompra
  End Function

  Public Function ModificarCompraCajaChicaConcepto(ByVal wcompra As Compra, ByVal wmontoTotal As Double,
                                       ByVal listaDetalles As List(Of DetalleCompra)) As Integer
    Dim pars As New List(Of CParametro)
    Dim xmlDetalle As String

    Try
      Me.Conectar(True)

      xmlDetalle = CrearXMLDetalleCompra(listaDetalles)
      pars.AddRange({New CParametro("@codigoTipoDocumento", wcompra.TipoDocumento.codigoTipoDocumento), _
                  New CParametro("@numeroDocumento", wcompra.numeroDocumento), _
                  New CParametro("@codigoBeneficiario", wcompra.Beneficiario.Codigo),
                  New CParametro("@serie", wcompra.serie), _
                  New CParametro("@IGV", wcompra.IGV), _
                  New CParametro("@montoTotal", wmontoTotal), _
                  New CParametro("@detallesCompra", xmlDetalle), _
                  New CParametro("@codigoCompra", wcompra.codigoCompra)})
      Dim row = Me.EjecutarOrden("pr_moCompraCajaChica", pars)
      Me.Cerrar(True)
      Return row
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try
  End Function
  Public Function ModificarCompraCajaChicaVigencia(ByVal wCompra As Compra) As Integer
    Dim pars As New List(Of CParametro)

    Try
      Me.Conectar(True)
      pars.AddRange({New CParametro("@codigoCompra", wCompra.codigoCompra)})
      Dim row = Me.EjecutarOrden("pr_moCompraCajaChicaVigencia", pars)
      Me.Cerrar(True)
      Return row
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try
  End Function

  Public Function ListarSaldo() As Decimal
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim saldo As Decimal
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liSaldoCajaChica", pars)
      If dr.Read Then
        saldo = dr.GetDecimal(dr.GetOrdinal("saldo"))
      End If
      Me.Cerrar(True)
      Return saldo
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      dr = Nothing
      pars = Nothing
    End Try
  End Function

End Class