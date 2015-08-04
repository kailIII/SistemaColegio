
Public Class RNProgramacionPago
  Inherits CADO

  Public Sub Registrar(ByVal obj As ProgramacionPago)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iProgramacion_Pago", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@descripcion", obj.Descripcion)
      .AddWithValue("@monto", obj.Monto)
      .AddWithValue("@entidad", obj.Entidad)
      .AddWithValue("@vigencia ", obj.vigencia)
      .AddWithValue("@fechaVcto", obj.Vencimiento)
      .AddWithValue("@anio", obj.Anio.Anio)
      .AddWithValue("@codigoNivel", obj.Nivel.Codigo)
      .AddWithValue("@codigoServicio", obj.Servicio.Codigo)
      .AddWithValue("@Aplica", obj.Aplica)
    End With
    Try
      cn.Open()
      cmd.ExecuteNonQuery()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
  End Sub

  Public Function ListarProgramacionPago(ByVal p As ProgramacionPago, ByVal a As AnioLectivo) As List(Of ProgramacionPago)
    Dim lp As New List(Of ProgramacionPago)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liProgramacion_Pago", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@vigencia", p.vigencia)
      .AddWithValue("@anio", a.Anio)
    End With
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        lp.Add(New ProgramacionPago(CInt(dr.Item("codigoProgramacion")), CDbl(dr.Item("monto")), dr.Item("descripcion").ToString, dr.Item("entidad").ToString, _
                True, CDate(dr.Item("fechaVcto")), New Servicio(CInt(dr.Item("codigoServicio")), dr.Item("nombre").ToString, 0, "", "", True, _
                New TipoServicio(), New CuentaContable(), New Nivel), New AnioLectivo(dr.Item("anio").ToString), New Nivel(CInt(dr.Item("codigoNivel")), dr.Item("nombreNivel").ToString, "")))
        With lp.Item(lp.Count - 1)
          .Aplica = dr.Item("Aplica").ToString
        End With
      End While
      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try

    Return lp
  End Function

  Public Sub Eliminar(ByVal obj As ProgramacionPago)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_eProgramacion_Pago", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigoProgramacion", obj.codigo)
    End With
    Try
      cn.Open()
      cmd.ExecuteNonQuery()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try

  End Sub

  Public Function Leer(ByVal wProgramacion As ProgramacionPago) As ProgramacionPago
    Dim dr As SqlDataReader
    Dim pp As ProgramacionPago = Nothing
    Dim pars As New List(Of CParametro)

    pars.Add(New CParametro("@Programacion", wProgramacion.codigo))
    Try
      Me.Conectar(False)

      dr = Me.PedirDataReader("pr_lProgramacionPago", pars)
      If dr.Read = True Then
        pp = New ProgramacionPago
        pp.codigo = wProgramacion.codigo
        pp.Nivel = New Nivel(CInt(dr.Item("CodigoNivel")))
        pp.Anio = New AnioLectivo(dr.Item("anio").ToString)
        pp.Servicio = New Servicio(CInt(dr.Item("CodigoServicio")))
        pp.Servicio.entidad = dr.Item("Entidad").ToString
        pp.Descripcion = dr.Item("Descripcion").ToString
        pp.Monto = CDbl(dr.Item("Monto"))
        pp.Vencimiento = CDate(dr.Item("fechaVcto"))
        pp.vigencia = CBool(dr.Item("Vigencia"))
      End If
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      dr = Nothing
    End Try

    Return pp
  End Function

  Public Sub Asignar(ByVal wAnio As AnioLectivo, ByVal wPagos As List(Of ProgramacionPago), ByVal wAlumnos As List(Of Matricula))
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iProgramarPagos", cn)
    Dim xAl As String, xPr As String

    xAl = CrearXMLAlumnos(wAlumnos)
    xPr = CrearXMLProgramaciones(wPagos)
    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Alumnos", xAl)
      .AddWithValue("@Programaciones", xPr)
      .AddWithValue("@Anio", wAnio.Anio)
    End With
    Try
      cn.Open()
      cmd.ExecuteNonQuery()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
  End Sub

  Private Function CrearXMLAlumnos(ByVal wAl As List(Of Matricula)) As String
    Dim cad As String = "<ROOT>"

    For Each m As Matricula In wAl
      cad &= "<Matricula numero=""" & m.Numero & """ />"
    Next
    cad &= "</ROOT>"

    Return cad
  End Function

  Private Function CrearXMLProgramaciones(ByVal wProgs As List(Of ProgramacionPago)) As String
    Dim cad As String = "<ROOT>"

    For Each pp As ProgramacionPago In wProgs
      cad &= "<Programacion "
      cad &= "descripcion=""" & pp.Descripcion & """ "
      cad &= "monto=""" & pp.Monto & """ "
      cad &= "vencimiento=""" & pp.Vencimiento.ToString("yyyyMMdd") & """ "
      With pp.Servicio
        cad &= "servicio=""" & .Codigo & """ "
        cad &= "nivel=""" & .NivelAcademico.Codigo & """ "
      End With
      cad &= "/>"
    Next
    cad &= "</ROOT>"

    Return cad
  End Function

  Public Function ListarMeses(ByVal wAnio As AnioLectivo) As List(Of ProgramacionPago)
    Dim dr As SqlDataReader
    Dim meses As List(Of ProgramacionPago) = Nothing
    Dim pp As ProgramacionPago = Nothing
    Dim pars As New List(Of CParametro)
    Dim iDesc As Integer, iVencimiento As Integer

    pars.Add(New CParametro("@Anio", wAnio.Anio))
    Try
      Me.Conectar(False)

      dr = Me.PedirDataReader("pr_liMesesPago", pars)
      iDesc = dr.GetOrdinal("descripcion")
      iVencimiento = dr.GetOrdinal("fechaVcto")
      meses = New List(Of ProgramacionPago)
      While dr.Read
        pp = New ProgramacionPago
        pp.Anio = wAnio
        pp.Descripcion = dr.GetString(iDesc)
        pp.Vencimiento = dr.GetDateTime(iVencimiento)
        pp.vigencia = True

        meses.Add(pp)
      End While
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      dr = Nothing
    End Try

    Return meses
  End Function

  Public Function ListarPagosRealizar(ByVal wAnio As AnioLectivo, ByVal wEntidad As String) As List(Of ProgramacionPago)
    Dim dr As SqlDataReader
    Dim meses As List(Of ProgramacionPago) = Nothing
    Dim pp As ProgramacionPago = Nothing
    Dim pars As New List(Of CParametro)
    Dim iDesc As Integer, iVencimiento As Integer

    pars.AddRange(New CParametro() {New CParametro("@Anio", wAnio.Anio), _
                                    New CParametro("@Entidad", wEntidad)})
    Try
      Me.Conectar(False)

      dr = Me.PedirDataReader("pr_liPagosARealizar", pars)
      iDesc = dr.GetOrdinal("descripcion")
      iVencimiento = dr.GetOrdinal("fechaVcto")
      meses = New List(Of ProgramacionPago)
      While dr.Read
        pp = New ProgramacionPago
        pp.Anio = wAnio
        pp.Descripcion = dr.GetString(iDesc)
        pp.Vencimiento = dr.GetDateTime(iVencimiento)
        pp.vigencia = True

        meses.Add(pp)
      End While
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      dr = Nothing
    End Try

    Return meses
  End Function


End Class
