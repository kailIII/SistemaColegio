Public Class RNConceptoOperacion
  Inherits CADO

  Function listarDescripcion(ByVal wTipo As String) As List(Of ConceptoOperacion)
    Dim listaConcepto As New List(Of ConceptoOperacion)

    Dim pars As New List(Of CParametro)
    pars.Add(New CParametro("@tipo", wTipo))
    Dim dr As SqlDataReader
    Dim codigo As Integer, descripcion As Integer, tipo As Integer
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liConceptoOperacion", pars)
      codigo = dr.GetOrdinal("codigoConceptoOperacion")
      descripcion = dr.GetOrdinal("descripcion")
      tipo = dr.GetOrdinal("tipo")
      While dr.Read
        listaConcepto.Add(New ConceptoOperacion(dr.GetInt16(codigo), dr.GetString(descripcion), dr.GetString(tipo)))
      End While
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try
    Return listaConcepto
  End Function

End Class