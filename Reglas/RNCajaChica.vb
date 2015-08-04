Public Class RNCajaChica
  Inherits CADO

  Public Function RegistrarCajaChicaReposicion(ByVal wCajaChica As CajaChica) As Integer
    Dim pars As New List(Of CParametro)
    Dim i As Integer
    pars.AddRange({New CParametro("@monto", wCajaChica.montoReposicion), _
                   New CParametro("@codigoPersonalReposicion", wCajaChica.PersonalReposicion.Codigo), _
                   New CParametro("@codigoRespCajaChica", wCajaChica.ResponsableCajaChica.codigoRespCajaChica)})

    Try
      Me.Conectar(True)
      i = Me.EjecutarOrden("pr_iCajaChicaReposicion", pars)    
      Me.Cerrar(True)
      Return i
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try
  End Function
  Public Function ModificarCajaChicaReposicion(ByVal wCajaChica As CajaChica) As Integer
    Dim pars As New List(Of CParametro)
    pars.AddRange({New CParametro("@monto", wCajaChica.montoReposicion), _
                   New CParametro("@codigoPersonalReposicion", wCajaChica.PersonalReposicion.Codigo)})
    Dim i As Integer
    Try
      Me.Conectar(True)
      i = Me.EjecutarOrden("pr_moCajaChicaReposicion", pars)
      Me.Cerrar(True)
      Return i
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try
  End Function

  Public Function ModificarVigenciaCajaChica(ByVal wCajaChica As CajaChica) As Integer
    Dim pars As New List(Of CParametro)
    pars.AddRange({New CParametro("@codigoCajaChica", wCajaChica.codigoCajaChica)})
    Dim i As Integer
    Try
      Me.Conectar(True)
      i = Me.EjecutarOrden("pr_moCajaChicaVigencia", pars)
      Me.Cerrar(True)
      Return i
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try
  End Function
  Public Function ListarReposicion() As List(Of CajaChica)
    Dim pars As New List(Of CParametro)
    Dim listaReposicion As New List(Of CajaChica)
    Dim dr As SqlDataReader
    Dim monto As Integer, fecha As Integer, responsableReposicion As Integer, saldo As Integer,
      nombre As Integer, apellidoPat As Integer, apellidoMat As Integer, codigoCajaChica As Integer,
      vigencia As Integer
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liCajaChicaReposicion", pars)
      monto = dr.GetOrdinal("montoReposicion")    
      fecha = dr.GetOrdinal("fechaApertura")
      responsableReposicion = dr.GetOrdinal("codigoPersonalReposicion")
      saldo = dr.GetOrdinal("saldo")
      nombre = dr.GetOrdinal("nombre")
      apellidoPat = dr.GetOrdinal("apellidoPat")
      apellidoMat = dr.GetOrdinal("apellidoMat")
      codigoCajaChica = dr.GetOrdinal("codigoCajaChica")
      vigencia = dr.GetOrdinal("vigencia")
      While dr.Read
        listaReposicion.Add(New CajaChica(dr.GetInt32(codigoCajaChica), dr.GetDecimal(monto), dr.GetDateTime(fecha),
                                          dr.GetBoolean(vigencia), New Personal(dr.GetInt32(responsableReposicion), dr.GetString(nombre),
                                                             dr.GetString(apellidoPat), dr.GetString(apellidoMat)), Nothing,
                                          dr.GetDecimal(saldo), Nothing))
      End While
      Me.Cerrar(True)
      Return listaReposicion
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try
  End Function

  Public Function IdentificarResponsableCajaChica(ByVal oUsuario As Usuario) As ResponsableCajaChica
    Dim pars As New List(Of CParametro)
    pars.Add(New CParametro("@codigoPersonal", oUsuario.Persona.Codigo))
    Dim dr As SqlDataReader
    Dim codigoResponsable As Integer
    Dim responsable As ResponsableCajaChica = Nothing
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liResponsableCajaChica", pars)
      codigoResponsable = dr.GetOrdinal("codigoRespCajaChica")
      While dr.Read
        responsable = New ResponsableCajaChica(dr.GetInt16(codigoResponsable), True, Nothing)
      End While
      Me.Cerrar(True)
      Return responsable
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try
  End Function

End Class