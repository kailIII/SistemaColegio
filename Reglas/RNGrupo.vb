
Public Class RNGrupo

  Public Sub Registrar(ByVal obj As Grupo)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iGrupo", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@NroMatricula", obj.Matricula.Numero)
      .AddWithValue("@CodigoDocCarga", obj.DocenteCarga.Codigo)
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

  Public Sub Eliminar(ByVal obj As Grupo)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_eGrupo", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@NroMatricula", obj.Matricula.Numero)
      .AddWithValue("@CodigoDocenteCarga", obj.DocenteCarga.Codigo)
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

  Public Function ListarAlumnosGrupo(ByVal obj As DocenteCarga, ByVal procedimiento As Integer) As List(Of Matricula)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim dr As SqlDataReader = Nothing
    Dim cmd As SqlCommand = Nothing
    Dim lm As List(Of Matricula) = Nothing
    Dim fecha As DateTime = Now

    If procedimiento = 0 Then
      cmd = New SqlCommand("pr_liAlumnosCarga", cn)
    Else
      cmd = New SqlCommand("pr_liAlumnosCarga2", cn)
    End If

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoCur", obj.Carga.Curso.Codigo)
      If procedimiento = 1 Then
        .AddWithValue("@Nombre", obj.Nombre)
      End If
      .AddWithValue("@Anio", obj.Carga.Seccion.Anio.Anio)
      .AddWithValue("@CodigoG", obj.Carga.Seccion.Grado.Codigo)
      .AddWithValue("@Letra", obj.Carga.Seccion.Letra)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lm = New List(Of Matricula)
      Do While dr.Read
        lm.Add(New Matricula(CInt(dr.Item("nroMatricula")), _
                             New Alumno(CInt(dr.Item("codigoPersona")), dr.Item("nombre").ToString, dr.Item("apellidoPat").ToString, dr.Item("apellidoMat").ToString, dr.Item("sexo").ToString, CStr(fecha), ""), _
                             0))
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
    Return lm
  End Function

  Public Function ListarAlumnosGrupo2(ByVal obj As DocenteCarga, ByVal procedimiento As Integer) As List(Of Matricula)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As SqlCommand = Nothing
    Dim dr As SqlDataReader = Nothing
    Dim lm As List(Of Matricula) = Nothing
    Dim fecha As DateTime = Now

    'If procedimiento = 0 Then
    cmd = New SqlCommand("pr_liAlumnosCarga02", cn)
    ' Else
    'cmd = New SqlCommand("pr_liAlumnosCarga0202", cn)
    'End If

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoCur", obj.Carga.Curso.Codigo)
      .AddWithValue("@CodigoPeriodo", obj.Periodo.Codigo)
      .AddWithValue("@CodigoDocCarga", obj.Codigo)
      .AddWithValue("@Nombre", obj.Nombre)
      .AddWithValue("@Anio", obj.Carga.Seccion.Anio.Anio)
      .AddWithValue("@CodigoG", obj.Carga.Seccion.Grado.Codigo)
      .AddWithValue("@Letra", obj.Carga.Seccion.Letra)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lm = New List(Of Matricula)
      Do While dr.Read
        lm.Add(New Matricula(CInt(dr.Item("nroMatricula")), _
                             New Alumno(CInt(dr.Item("codigoPersona")), dr.Item("nombre").ToString, dr.Item("apellidoPat").ToString, dr.Item("apellidoMat").ToString, dr.Item("sexo").ToString, CStr(fecha), ""), _
                             0))
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
    Return lm
  End Function

  Public Function Cantidad(ByVal obj As DocenteCarga) As Integer
    'Dim cn As New SqlConnection(My.Settings.Conexion)
    'Dim cmd As New SqlCommand("pr_lGrupo", cn)
    'Dim dr As Integer

    'cmd.CommandType = CommandType.StoredProcedure
    'With cmd.Parameters
    '  .AddWithValue("@Nombre", obj.Nombre)
    '  .AddWithValue("@CodigoCur", obj.Carga.Curso.codigoCur)
    '  .AddWithValue("@CodigoG", obj.Carga.Seccion.Grado.Codigo)
    '  .AddWithValue("@Anio", obj.Carga.Seccion.Anio.anio)
    '  .AddWithValue("@Letra", obj.Carga.Seccion.Letra)
    'End With

    'Try
    '  cn.Open()
    '  dr = CInt(cmd.ExecuteScalar)
    '  cn.Close()
    'Catch ex As Exception
    '  Throw ex
    'Finally
    '  cmd.Dispose()
    '  cmd = Nothing
    '  If cn.State = ConnectionState.Open Then
    '    cn.Close()
    '  End If
    '  cn.Dispose()
    '  cn = Nothing
    'End Try

    'Return dr

  End Function

  Public Function CodigoCarga(ByVal obj As DocenteCarga) As Integer
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lGrupo2", cn)
    Dim dr As Integer

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      '.AddWithValue("@Nombre", obj.Nombre)
      .AddWithValue("@CodigoCur", obj.Carga.Curso.Codigo)
      .AddWithValue("@CodigoG", obj.Carga.Seccion.Grado.Codigo)
      .AddWithValue("@Anio", obj.Carga.Seccion.Anio.Anio)
      .AddWithValue("@Letra", obj.Carga.Seccion.Letra)
    End With

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

  Public Function Cantidad2(ByVal obj As DocenteCarga) As Integer
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lGrupo3", cn)
    Dim dr As Integer

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Nombre", obj.Nombre)
      .AddWithValue("@CodigoCur", obj.Carga.Curso.Codigo)
      .AddWithValue("@CodPer", obj.Periodo.Codigo)
      .AddWithValue("@CodigoG", obj.Carga.Seccion.Grado.Codigo)
      .AddWithValue("@Anio", obj.Carga.Seccion.Anio.Anio)
      .AddWithValue("@Letra", obj.Carga.Seccion.Letra)
    End With

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

  Public Function ListarAlumnosSeccion(ByVal obj As CargaAcademica) As List(Of Matricula)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAlumnosSeccion2", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lm As List(Of Matricula) = Nothing
    Dim fecha As DateTime = Now

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoCur", obj.Curso.Codigo)
      .AddWithValue("@Anio", obj.Seccion.Anio.Anio)
      .AddWithValue("@CodigoG", obj.Seccion.Grado.Codigo)
      .AddWithValue("@Letra", obj.Seccion.Letra)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lm = New List(Of Matricula)
      Do While dr.Read
        lm.Add(New Matricula(CInt(dr.Item("nroMatricula")), _
                             New Alumno(CInt(dr.Item("codigoPersona")), dr.Item("nombre").ToString, dr.Item("apellidoPat").ToString, dr.Item("apellidoMat").ToString, dr.Item("sexo").ToString, CStr(fecha), ""), _
                             0))
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
    Return lm
  End Function

  Public Sub EliminarGrupo(ByVal obj As Grupo)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_eTodoGrupo", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codDocenteCarga", obj.DocenteCarga.Codigo)
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

  Public Function AlumnosSinGrupo(ByVal obj As CargaAcademica) As List(Of Matricula)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAluCargaGrupo", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lm As List(Of Matricula) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodCur", obj.Curso.Codigo)
      .AddWithValue("@CodGra", obj.Seccion.Grado.Codigo)
      .AddWithValue("@Anio", obj.Seccion.Anio.Anio)
      .AddWithValue("@Letra", obj.Seccion.Letra)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lm = New List(Of Matricula)
      Do While dr.Read
        lm.Add(New Matricula(CInt(dr.Item("nroMatricula")), New Alumno(CInt(dr.Item("codigoPersona")), _
                      "", "", "", "", CStr(Now), ""), _
                             0))
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
    Return lm
  End Function

  Public Function ListarAlumnosGrupoEdFis(ByVal obj As DocenteCarga) As List(Of Matricula)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As SqlCommand = Nothing
    Dim dr As SqlDataReader = Nothing
    Dim lm As List(Of Matricula) = Nothing
    Dim fecha As DateTime = Now

    cmd = New SqlCommand("pr_liMatriculadosGrupoEdFis", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodDocCar", obj.Codigo)
      .AddWithValue("@CodPer", obj.Periodo.Codigo)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lm = New List(Of Matricula)
      Do While dr.Read
        lm.Add(New Matricula(CInt(dr.Item("nroMatricula")), _
                             New Alumno(CInt(dr.Item("codigoPersona")), dr.Item("nombre").ToString, dr.Item("apellidoPat").ToString, dr.Item("apellidoMat").ToString, dr.Item("sexo").ToString, CStr(fecha), ""), _
                             0))
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
    Return lm
  End Function

End Class
