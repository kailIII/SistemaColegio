Public Class RNConceptoCompra
  Inherits CADO

  Public Function RegistrarConceptoCompra(ByVal wConceptoCompra As ConceptoCompra) As Integer
    Dim pars As New List(Of CParametro)
    Dim c As Integer
    pars.AddRange({New CParametro("@nombre", wConceptoCompra.nombre, CParametro.DireccionParametro.ENTRADA), _
                   New CParametro("@codigo", c, CParametro.DireccionParametro.SALIDA)})
    Dim codigo As Integer
    Try
      Me.Conectar(True)
      codigo = Me.EjecutarOrden("pr_iConceptoCompra", pars)
      c = c
      Me.Cerrar(True)
      Return CInt(pars.Item(1).Valor)
    Catch ex As Exception
      Throw ex
      Me.Cerrar(False)
    Finally
      codigo = 0
      pars = Nothing
    End Try
  End Function


  Function ListarConceptoCompra(ByVal wTipo As String) As Object
    Dim listaConceptoCompra As New List(Of ConceptoCompra)

    Dim pars As New List(Of CParametro)
    pars.Add(New CParametro("@tipo", wTipo))
    Dim dr As SqlDataReader
    Dim codigo As Integer, descripcion As Integer, tipo As Integer
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liConceptoCompra", pars)
      codigo = dr.GetOrdinal("codigoConceptoCompra")
      descripcion = dr.GetOrdinal("nombre")
      tipo = dr.GetOrdinal("tipo")
      While dr.Read
        listaConceptoCompra.Add(New ConceptoCompra(dr.GetInt32(codigo), dr.GetString(descripcion), True, dr.GetString(tipo)))
      End While
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try
    Return listaConceptoCompra
  End Function

End Class