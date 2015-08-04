Public Class RNTipoDocumento
  Inherits CADO

  Function listarTipoDocumento() As List(Of TipoDocumento)
    Dim listaTipoDocumento As New List(Of TipoDocumento)

    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim codigo As Integer, descripcion As Integer
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liTipoDocumento", pars)
      codigo = dr.GetOrdinal("codigoTipoDocumento")
      descripcion = dr.GetOrdinal("descripcion")
      While dr.Read
        listaTipoDocumento.Add(New TipoDocumento(dr.GetByte(codigo), dr.GetString(descripcion)))
      End While
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try
    Return listaTipoDocumento
  End Function

End Class