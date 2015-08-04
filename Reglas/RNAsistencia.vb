Public Class RNAsistencia
  Inherits CADO

  Public Sub Registrar(ByVal Obj As Asistencia)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iAsistencia", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Estado", Left(Obj.Estado, 1))
      .AddWithValue("@Fecha", Obj.Fecha)
      .AddWithValue("@NroMatricula", Obj.Matricula.Numero)
      .AddWithValue("@CodigoPersonal", Obj.Personal)
      .AddWithValue("@CodigoPeriodo", Obj.Periodo)
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

  Public Sub Justificar(ByVal Obj As Asistencia)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iJustAsistencia", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Codigo", Obj.Codigo)
      .AddWithValue("@Descripcion", Obj.Descripcion)
      .AddWithValue("@Estado", Left(Obj.Estado, 1) & "J")
      .AddWithValue("@FechaJust", Obj.FechaJustificacion)
      .AddWithValue("@Vigencia", Obj.Vigencia)
      .AddWithValue("@CodigoPersonal", Obj.Personal)
      .AddWithValue("@CodigoApoderado", Obj.CodigoApoderado)
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

  Public Function MostrarJustificacion(ByVal obj As Date) As Asistencia
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lTutor_Alumno", cn)
    Dim dr As SqlDataReader = Nothing
    Dim A As Asistencia = Nothing
    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Fecha", obj)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read = True Then
        A = New Asistencia(CInt(dr.Item("codigoAsist")), dr.Item("estado").ToString, Nothing, _
                           New Matricula(CInt(dr.Item("nroMatricula"))), 0, 0)
      End If
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

    Return A
  End Function

  Public Function Listar(ByVal wsec As Seccion, ByVal wfecha As Date) As List(Of Asistencia)
    Dim lm As New List(Of Asistencia)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liMatricula_Asistencia", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@anio", wsec.Anio.Anio)
    cmd.Parameters.AddWithValue("@codigoG", wsec.Grado.Codigo)
    cmd.Parameters.AddWithValue("@letra", wsec.Letra)
    cmd.Parameters.AddWithValue("@Fecha", wfecha)

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        lm.Add(New Asistencia(CInt(IIf(IsDBNull(dr.Item("codigoAsist")) = True, 0, dr.Item("codigoAsist"))), _
                     CStr(IIf(IsDBNull(dr.Item("estado")) = True, "", dr.Item("estado"))), _
                      CDate(IIf(IsDBNull(dr.Item("fecha")) = True, Now, dr.Item("fecha"))), _
                      New Matricula(CInt(dr.Item("nroMatricula")), Nothing, _
                      New Alumno(CInt(dr.Item("codigoAlumno")), CStr(dr.Item("nombre")), _
                        CStr(dr.Item("apellidoPat")), CStr(dr.Item("apellidoMat")), _
                        Nothing, Nothing, Nothing, Nothing), _
                        New Apoderado(CInt(dr.Item("codigoApoderado"))), _
                         Nothing, Nothing, CInt(dr.Item("NroOrden")))))
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

  Public Function ListarEstado() As List(Of Asistencia)
    Dim lm As New List(Of Asistencia)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liEstado", cn)
    Dim dr As SqlDataReader = Nothing


    cmd.CommandType = CommandType.StoredProcedure
    Try

      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        lm.Add(New Asistencia(0, dr.Item("estado").ToString, Nothing, Nothing, Nothing, Nothing))

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

  Public Function FaltasJusticadas(ByVal obj As Asistencia) As Integer
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_AsistTrim", cn)
    Dim dr As Integer

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@NroMatricula", obj.Matricula.Numero)
    cmd.Parameters.AddWithValue("@codigoPeriodo", obj.Periodo)
    cmd.Parameters.AddWithValue("@Estado", obj.Estado)

    Try
      cn.Open()
      dr = CInt(cmd.ExecuteScalar)
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
    Return dr
  End Function

  Public Sub Elimina_Actualiza(ByVal Obj As Asistencia)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_eAsistencia", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodAsist", Obj.Codigo)
      .AddWithValue("@EstadoAsist", Left(Obj.Estado, 1))
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

  'Presenta los datos de la justificación de la asistencia
  Public Function LeerJustificacion(ByVal pAsistencia As Asistencia) As Asistencia
    Dim asis As Asistencia = Nothing
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader

    pars.Add(New CParametro("@Asistencia", pAsistencia.Codigo))

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_lJustificacion", pars)
      If dr.Read = True Then
        asis = New Asistencia
        asis.Codigo = pAsistencia.Codigo
        asis.Apoderado = New Apoderado With {.Codigo = CInt(dr.Item("CodigoApoderado"))}
        asis.FechaJustificacion = CDate(dr.Item("Fecha"))
        asis.Descripcion = dr.Item("Descripcion").ToString
      End If

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars.Clear()
    End Try

    Return asis
  End Function

    'Tania Incio
    Public Function ListarTipoRegistro(ByVal wPeriodo As PeriodoAcademico) As List(Of Asistencia)
        Dim datos As List(Of Asistencia) = Nothing
        Dim lp As New List(Of CParametro)
        Dim dr As SqlDataReader
        Dim iEstado As Integer

        lp.AddRange(New CParametro() {New CParametro("@codigoPeriodo", wPeriodo.Codigo)})
        Try
            Me.Conectar(False)
            dr = Me.PedirDataReader("pr_liTipoRegistro", lp)
            iEstado = dr.GetOrdinal("estado")
            datos = New List(Of Asistencia)
            datos.Add(New Asistencia())
            With datos.Item(0)
                .Estado = "TODOS"
            End With
            Do While dr.Read
                datos.Add(New Asistencia())
                With datos.Item(datos.Count - 1)
                    .Estado = dr.GetString(iEstado)
                End With
            Loop

            Me.Cerrar(True)
        Catch ex As Exception
            datos = Nothing
            Me.Cerrar(False)
            Throw ex
        Finally
            lp = Nothing
            dr = Nothing
        End Try
        Return datos
    End Function
End Class
