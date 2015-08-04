Public Class RNProgramacionLectura
  Inherits CADO

  Public Sub Registrar(ByVal Obj As ProgramacionLectura)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iProgramacionLectura", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Tipo", Obj.Tipo)
      .AddWithValue("@NroMatricula", Obj.Matricula.Numero)
      .AddWithValue("@CodigoPresentancion", Obj.CodigoPresentacion)
      .AddWithValue("@CodigoLibro", Obj.Libro.Codigo)
      .AddWithValue("@NroGrupo", Obj.NroGrupo)

      .AddWithValue("@Anio", Obj.Seccion.Anio.Anio)
      .AddWithValue("@CodigoG", Obj.Seccion.Grado.Codigo)
      .AddWithValue("@Letra", Obj.Seccion.Letra)
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
      Obj = Nothing
    End Try
  End Sub

  Public Sub Actualizar(ByVal Obj As ProgramacionLectura)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aProgramacionLectura", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Codigo", Obj.Codigo)
      .AddWithValue("@Tipo", Obj.Tipo)
      .AddWithValue("@NroMatricula", Obj.Matricula.Numero)
      .AddWithValue("@CodigoPresentancion", Obj.CodigoPresentacion)
      .AddWithValue("@CodigoLibro", Obj.Libro.Codigo)
      .AddWithValue("@NroGrupo", Obj.NroGrupo)

      .AddWithValue("@Anio", Obj.Seccion.Anio.Anio)
      .AddWithValue("@CodigoG", Obj.Seccion.Grado.Codigo)
      .AddWithValue("@Letra", Obj.Seccion.Letra)
      .AddWithValue("@Vigencia", Obj.Vigencia)
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
      Obj = Nothing
    End Try
  End Sub

  Public Function ListarAlumnosProgramacion(ByVal wsec As Seccion, ByVal anio As String, ByVal NroGrupo As Integer) As List(Of ProgramacionLectura)
    Dim lm As New List(Of ProgramacionLectura)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAlumnosProgramacion", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure

    cmd.Parameters.AddWithValue("@CodigoNivel", wsec.Grado.Nivel.Codigo)
    cmd.Parameters.AddWithValue("@Anio", anio)
    cmd.Parameters.AddWithValue("@Numero", wsec.Grado.Numero)
    cmd.Parameters.AddWithValue("@Letra", wsec.Letra)
    cmd.Parameters.AddWithValue("@NroGrupo", NroGrupo)

    Try

      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        lm.Add(New ProgramacionLectura(CInt(dr.Item("codigoProgLect")), dr.Item("tipo").ToString, CBool(dr.Item("vigencia")), _
                                         Nothing, CInt(dr.Item("codigoPresFecha")), _
                                       New Libro(CInt(dr.Item("codigoLibro"))), _
                New Matricula(CInt(dr.Item("nroMatricula"))), _
                New Seccion(wsec.Grado.Codigo, wsec.Numero, wsec.Grado.Nivel.Codigo, "", wsec.Letra)))
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
    Return lm
  End Function

  Public Function VerificarExistencia(ByVal wCodigoProgLect As Integer) As List(Of ProgramacionLectura)
    Dim lm As New List(Of ProgramacionLectura)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_verificarProg", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoProgLect", wCodigoProgLect)

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        lm.Add(New ProgramacionLectura(CInt(dr.Item("codigoProgLect")), Nothing, Nothing, Nothing, CInt(dr.Item("codigoPresFecha")), _
                                        New Libro(CInt(dr.Item("codigoLibro")), dr.Item("nombre").ToString, "", dr.Item("Abreviatura").ToString, 0), _
                                        New Matricula(), New Seccion()))
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

    Return lm
  End Function

  Public Sub Eliminar(ByVal Obj As ProgramacionLectura)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aAnularProgramacionLectura", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Codigo", Obj.Codigo)
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
      Obj = Nothing
    End Try
  End Sub

  Public Function ListarAlumnosAsignados(ByVal wsec As Seccion, ByVal anio As String, ByVal CodPres As Integer) As List(Of ProgramacionLectura)
    Dim lm As New List(Of ProgramacionLectura)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAlumnosProgAsig", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure

    cmd.Parameters.AddWithValue("@CodigoNivel", wsec.Grado.Nivel.Codigo)
    cmd.Parameters.AddWithValue("@Anio", anio)
    cmd.Parameters.AddWithValue("@Numero", wsec.Grado.Numero)
    cmd.Parameters.AddWithValue("@Letra", wsec.Letra)
    cmd.Parameters.AddWithValue("@CodPres", CodPres)

    Try

      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        lm.Add(New ProgramacionLectura(CInt(dr.Item("codigoProgLect")), dr.Item("tipo").ToString, CBool(dr.Item("vigencia")), _
                                        Nothing, CInt(dr.Item("codigoPresFecha")), _
                                        New Libro(CInt(dr.Item("codigoLibro"))), _
                New Matricula(CInt(dr.Item("nroMatricula"))), _
                New Seccion(wsec.Grado.Codigo, wsec.Numero, wsec.Grado.Nivel.Codigo, "", wsec.Letra)))
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

    Return lm
  End Function

  'Tania Incio
  Public Function ListarCoordinadorProgLectura() As List(Of Persona)
    Dim pars As New List(Of CParametro)
    Dim coordinadores As New List(Of Persona)
    Dim dr As SqlDataReader
    Dim nombre As Integer, apellidoPat As Integer, apellidoMat As Integer

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liCoordinadorPlanLector", pars)
      nombre = dr.GetOrdinal("nombre")
      apellidoPat = dr.GetOrdinal("apellidoPat")
      apellidoMat = dr.GetOrdinal("apellidoMat")
      While dr.Read
        coordinadores.Add(New Persona(dr.GetString(nombre), dr.GetString(apellidoPat), dr.GetString(apellidoMat)))
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      pars = Nothing
    End Try

    Return coordinadores
  End Function

End Class
