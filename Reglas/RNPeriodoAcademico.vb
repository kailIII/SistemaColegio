
Public Class RNPeriodoAcademico

  Public Function MostrarPeriodo(ByVal obj As Integer) As PeriodoAcademico
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lPeriodo", cn)
    Dim dr As SqlDataReader = Nothing
    Dim P As PeriodoAcademico = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@codigoPeriodo", obj)

    Try
      cn.Open()
      dr = cmd.ExecuteReader

      If dr.Read = True Then
        P = New PeriodoAcademico(Nothing, Nothing, Nothing, dr.Item("anio").ToString, dr.Item("nombre").ToString, dr.Item("siglas").ToString)
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
    Return P
  End Function

  Public Function ListarCodPeriodos(ByVal obj As AnioLectivo) As List(Of PeriodoAcademico)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liCodPeriodos", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lp As List(Of PeriodoAcademico) = Nothing
    
    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Anio", obj.Anio)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lp = New List(Of PeriodoAcademico)
      Do While dr.Read
        lp.Add(New PeriodoAcademico(CInt(dr.Item("codigoPeriodo")), Nothing, Nothing, _
                                    False, "", CStr(dr.Item("nombre")), dr.Item("siglas").ToString))
        lp.Item(lp.Count - 1).Anio = obj.Anio
      Loop
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

  Public Sub CerrarPeriodo(ByVal obj As PeriodoAcademico)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aCerrarPeriodoAcademico", cn)

    cmd.CommandType = CommandType.StoredProcedure
    cmd.CommandTimeout = 0
    cmd.Parameters.AddWithValue("@Periodo", obj.Codigo)

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
      cmd = Nothing
    End Try
  End Sub

  Public Sub CerrarCompAsist(ByVal obj As PeriodoAcademico)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aCerrarAsistComp", cn)

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Periodo", obj.Codigo)

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
      cmd = Nothing
    End Try
  End Sub

  Public Function ListarAvanceRegistroNotas(ByVal Nivel As Nivel, ByVal Per As PeriodoAcademico) As DataTable
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liDocentesFaltaNotas", cn)
    Dim da As New SqlDataAdapter(cmd)
    Dim dt As New DataTable

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Nivel", Nivel.Codigo)
    cmd.Parameters.AddWithValue("@Periodo", Per.Codigo)

    Try
      da.Fill(dt)
    Catch ex As Exception
      Throw ex
    Finally
      cn = Nothing
      cmd = Nothing
    End Try

    Return dt
  End Function

  Public Function ListarAvanceRegistroNotasPrimaria(ByVal Nivel As Nivel, ByVal Per As PeriodoAcademico) As DataTable
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liDocentesFaltaNotasPrimaria", cn)
    Dim da As New SqlDataAdapter(cmd)
    Dim dt As New DataTable

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Nivel", Nivel.Codigo)
    cmd.Parameters.AddWithValue("@Periodo", Per.Codigo)

    Try
      da.Fill(dt)
    Catch ex As Exception
      Throw ex
    Finally
      cn = Nothing
      cmd = Nothing
    End Try

    Return dt
  End Function

End Class