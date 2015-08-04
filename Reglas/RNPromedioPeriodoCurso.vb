
Public Class RNPromedioPeriodoCurso

  Public Sub Registrar(ByVal Obj As PromedioPeriodoCurso)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iPromPerIndicador", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@NroMatricula", Obj.NroMatricula)
      .AddWithValue("@CodigoPeriodo", Obj.CodigoPeriodo)
      .AddWithValue("@CodigoDocenteCarga", Obj.CodDocenteCarga)
      .AddWithValue("@CodigoPersonal", Obj.CodigoPersonal)
      .AddWithValue("@Letra", Obj.Letra)
      .AddWithValue("@NivelEsfuerzo", Obj.NivelEsfuerzo)

      '.AddWithValue("@CodigoTras", Obj.codTraslado)
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
  Public Function ListarPromIndicadores(ByVal wobj As PromedioPeriodoCurso) As List(Of PromedioPeriodoCurso)
    Dim lAlumCur As New List(Of PromedioPeriodoCurso)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As SqlCommand
    cmd = New SqlCommand("pr_liPromPeriodoCursoInd", cn)

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoDocenteCarga", wobj.CodDocenteCarga)
    cmd.Parameters.AddWithValue("@CodigoPeriodo", wobj.CodigoPeriodo)

    Dim dr As SqlDataReader = Nothing
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        lAlumCur.Add(New PromedioPeriodoCurso(CInt(dr.Item("codigoProm")), Nothing, _
                                           CInt(dr.Item("nroMatricula")), Nothing, Nothing, dr.Item("letra").ToString, _
                                           dr.Item("nivelEsfuerzo").ToString))
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

    Return lAlumCur
  End Function

  Public Function LeerPromInd(ByVal Obj As PromedioPeriodoCurso) As PromedioPeriodoCurso
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lPromIndicador", cn)
    Dim dr As SqlDataReader
    Dim nota As PromedioPeriodoCurso = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@NroMatricula", Obj.NroMatricula)
    cmd.Parameters.AddWithValue("@Codigo", Obj.Codigo)
    cmd.Parameters.AddWithValue("@CodigoPeriodo", Obj.CodigoPeriodo)

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read Then
        nota = New PromedioPeriodoCurso(CInt(dr.Item("codigoProm")), Nothing, _
                                           Nothing, Nothing, Nothing, dr.Item("letra").ToString, _
                                          dr.Item("nivelEsfuerzo").ToString)
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

    Return nota
  End Function

  Public Sub RegistrarNuevaPromInd(ByVal obj As PromedioPeriodoCurso)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iNuevoPromIndicador", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoProm", obj.Codigo)
      .AddWithValue("@CodigoPersonal", obj.CodigoPersonal)
      .AddWithValue("@Letra", obj.Letra)
      .AddWithValue("@NivelEsfuerzo", obj.NivelEsfuerzo)

    End With

    Try
      cn.Open()
      cmd.ExecuteNonQuery()
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

  End Sub
  Public Function ListarEstado() As List(Of PromedioPeriodoCurso)
    Dim lm As New List(Of PromedioPeriodoCurso)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liEstadoNivelEsfuerzo", cn)
    Dim dr As SqlDataReader = Nothing


    cmd.CommandType = CommandType.StoredProcedure
    Try

      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        lm.Add(New PromedioPeriodoCurso(0, Nothing, _
                                           Nothing, Nothing, Nothing, Nothing, _
                                          dr.Item("nivelEsfuerzo").ToString))
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

  Public Function ListarPromIndConsolidado(ByVal wobj As PromedioPeriodoCurso) As List(Of PromedioPeriodoCurso)
    Dim lAlumCur As New List(Of PromedioPeriodoCurso)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As SqlCommand
    cmd = New SqlCommand("liPromConsolidado", cn)

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoDocenteCarga", wobj.CodDocenteCarga)
    cmd.Parameters.AddWithValue("@CodigoPeriodo", wobj.CodigoPeriodo)

    Dim dr As SqlDataReader = Nothing
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        lAlumCur.Add(New PromedioPeriodoCurso(CInt(dr.Item("codigoProm")), Nothing, _
                                           CInt(dr.Item("nroMatricula")), Nothing, Nothing, dr.Item("letra").ToString, _
                                           dr.Item("nivelEsfuerzo").ToString, CInt(dr.Item("nroOrden"))))
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

    Return lAlumCur
  End Function

  Public Function ListarPromTrimAlumno(ByVal wobj As PromedioPeriodoCurso) As PromedioPeriodoCurso
    Dim nota As PromedioPeriodoCurso = Nothing
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As SqlCommand
    cmd = New SqlCommand("lPromTrimAlumno", cn)

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoDocenteCarga", wobj.CodDocenteCarga)
    cmd.Parameters.AddWithValue("@CodigoPeriodo", wobj.CodigoPeriodo)
    cmd.Parameters.AddWithValue("@NroMatricula", wobj.NroMatricula)


    Dim dr As SqlDataReader = Nothing
    Try

      cn.Close()
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read Then
        nota = New PromedioPeriodoCurso(CInt(dr.Item("codigoProm")), Nothing, _
                                           CInt(dr.Item("nroMatricula")), Nothing, Nothing, dr.Item("letra").ToString, _
                                           dr.Item("nivelEsfuerzo").ToString, CInt(dr.Item("nroOrden")))
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

    Return nota
  End Function

End Class
