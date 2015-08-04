Public Class RNPersonal
  Inherits CADO

  Public Function listarPersonal(ByVal busqueda As String) As List(Of Personal)
    Dim listaPersonal As New List(Of Personal)
    Dim pars As New List(Of CParametro)
    pars.Add(New CParametro("@busqueda", busqueda))
    Dim dr As SqlDataReader = Nothing
    Dim oPersona As Personal
    Dim codigo As Integer, nombre As Integer, apellidoPat As Integer, apellidoMat As Integer

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liPersonal", pars)
      codigo = dr.GetOrdinal("codigoPersona")
      nombre = dr.GetOrdinal("nombre")
      apellidoPat = dr.GetOrdinal("apellidoPat")
      apellidoMat = dr.GetOrdinal("apellidoMat")
      While dr.Read
        oPersona = New Personal(dr.GetInt32(codigo), dr.GetString(nombre),
                               dr.GetString(apellidoPat), dr.GetString(apellidoMat))
        listaPersonal.Add(oPersona)
      End While
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      dr = Nothing
      pars = Nothing
    End Try
    Return listaPersonal
  End Function
End Class
