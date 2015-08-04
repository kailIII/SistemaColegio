
Public Class RNDocente
  Inherits CADO

  Public Sub Registrar(ByVal Obj As Docente, ByVal objESp As Especialidad)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iDocente", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Nombre", Obj.Nombre)
      .AddWithValue("@ApellidoPat", Obj.ApellidoPaterno)
      .AddWithValue("@ApellidoMat", Obj.ApellidoMaterno)
      .AddWithValue("@Sexo", Obj.Sexo.Trim)
      .AddWithValue("@FechaNac", Obj.FechaNacimiento)
      .AddWithValue("@TipoDoc", Obj.TipoDocumento)
      .AddWithValue("@NroDoc", Obj.NumeroDocumento)
      .AddWithValue("@Email", IIf(Obj.Email.Length > 0, Obj.Email, DBNull.Value))
      .AddWithValue("@Celular", IIf(Obj.Celular.Length > 0, Obj.Celular, DBNull.Value))
      .AddWithValue("@Direccion", Obj.Direccion)
      .AddWithValue("@Grado", Obj.Grado)
      .AddWithValue("@Especialidad", objESp.Nombre)
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

  Public Sub Modificar(ByVal Obj As Docente)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aDocente", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Codigo", Obj.Codigo)
      .AddWithValue("@Nombre", Obj.Nombre)
      .AddWithValue("@ApellidoPat", Obj.ApellidoPaterno)
      .AddWithValue("@ApellidoMat", Obj.ApellidoMaterno)
      .AddWithValue("@Sexo", Obj.Sexo)
      .AddWithValue("@FechaNac", Obj.FechaNacimiento)
      .AddWithValue("@Celular", IIf(Obj.Celular.Length > 0, Obj.Celular, DBNull.Value))
      .AddWithValue("@TipoDoc", Obj.TipoDocumento)
      .AddWithValue("@NroDoc", Obj.NumeroDocumento)
      .AddWithValue("@Email", IIf(Obj.Email.Length > 0, Obj.Email, DBNull.Value))
      .AddWithValue("@Direccion", Obj.Direccion)
      .AddWithValue("@Grado", Obj.Grado)
      .AddWithValue("@Especialidad", Obj.Especialidad.Nombre)
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

  Public Function Listar() As List(Of Docente)
    Dim ld As New List(Of Docente)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lDocente", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        ld.Add(New Docente(CInt(dr.Item("CodigoPersona")), dr.Item("Nombre").ToString, dr.Item("ApellidoPat").ToString, dr.Item("ApellidoMat").ToString, 0))
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

    Return ld
  End Function

  Public Function ListarDoc(ByVal wNombre As String) As List(Of Docente)
    Dim ld As New List(Of Docente)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader = Nothing

    cmd = New SqlCommand("pr_liDocNombre", cn)
    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Nombre", wNombre)

    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        ld.Add(New Docente(CInt(dr.Item("CodigoPersona")), dr.Item("Nombre").ToString, dr.Item("ApellidoPat").ToString, dr.Item("ApellidoMat").ToString))
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

    Return ld
  End Function

  Public Function Leer(ByVal wDoc As Docente) As Docente
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lDocCodigo", cn)
    Dim dr As SqlDataReader = Nothing
    Dim d As Docente = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Codigo", wDoc.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      If dr.Read = True Then
        d = New Docente(wDoc.Codigo, dr.Item("Nombre").ToString, dr.Item("ApellidoPat").ToString, dr.Item("ApellidoMat").ToString, _
                                   dr.Item("Sexo").ToString, CDate(dr.Item("FechaNac")), dr.Item("Email").ToString, dr.Item("tipoDoc").ToString, dr.Item("nroDoc").ToString, dr.Item("Celular").ToString, _
                                   dr.Item("Grado").ToString, CInt(dr.Item("codigoEsp")), dr.Item("Especialidad").ToString, dr.Item("Direccion").ToString)
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

    Return d
  End Function

  Public Function ListarDocentesSecundaria(ByVal obj As PeriodoAcademico) As List(Of Docente)
    Dim ld As New List(Of Docente)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader = Nothing

    cmd = New SqlCommand("pr_liDocentesSec", cn)
    cmd.CommandType = CommandType.StoredProcedure

    cmd.Parameters.AddWithValue("@Anio", obj.Anio)
    cmd.Parameters.AddWithValue("@CodPer", obj.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        ld.Add(New Docente(CInt(dr.Item("CodigoPersona")), dr.Item("Nombre").ToString, _
                           dr.Item("ApellidoPat").ToString, dr.Item("ApellidoMat").ToString))
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

    Return ld
  End Function

  Public Function ListarDocentesInicialPrimaria(ByVal obj As PeriodoAcademico) As List(Of Docente)
    Dim ld As New List(Of Docente)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader = Nothing

    cmd = New SqlCommand("pr_liDocentesIniPri", cn)
    cmd.CommandType = CommandType.StoredProcedure

    cmd.Parameters.AddWithValue("@Anio", obj.Anio)
    cmd.Parameters.AddWithValue("@CodPer", obj.Codigo)

    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        ld.Add(New Docente(CInt(dr.Item("CodigoPersona")), dr.Item("Nombre").ToString, dr.Item("ApellidoPat").ToString, dr.Item("ApellidoMat").ToString))
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

    Return ld
  End Function

End Class
