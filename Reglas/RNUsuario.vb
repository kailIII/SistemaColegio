Public Class RNUsuario

  Public Function Identificar(ByVal wUsuario As Usuario) As Usuario
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_IdentificarUsuario", cn)
    Dim dr As SqlDataReader = Nothing
    Dim usu As Usuario = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Usuario", wUsuario.Nombre)
    cmd.Parameters.AddWithValue("@Contrasenia", wUsuario.Contrasenia)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read = True Then
        usu = New Usuario(dr.GetInt16(dr.GetOrdinal("CodigoUsu")), _
                        New Persona(dr.GetInt32(dr.GetOrdinal("CodigoPersona")), dr.GetString(dr.GetOrdinal("Nombre")), _
                                    dr.GetString(dr.GetOrdinal("ApellidoPat")), dr.GetString(dr.GetOrdinal("ApellidoMat"))), _
                        "", "", CChar(dr.Item("Tipo")), True)
        usu.Nombre = wUsuario.Nombre
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

    Return usu
  End Function

  Public Function VerificarDocente(ByVal wUsuario As Usuario) As Usuario
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_VerificarUsuario", cn)
    Dim dr As SqlDataReader = Nothing
    Dim o As Usuario = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoPersona", wUsuario.Persona.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read = True Then

        o = New Usuario(dr.GetInt16(dr.GetOrdinal("CodigoUsu")), New Persona(dr.GetInt32(dr.GetOrdinal("CodigoPersona")), _
            dr.GetString(dr.GetOrdinal("Nombre")), dr.GetString(dr.GetOrdinal("ApellidoPat")), _
            dr.GetString(dr.GetOrdinal("ApellidoMat"))), dr.Item("nombreUser").ToString, _
            dr.Item("contrasenia").ToString, CChar(dr.Item("Tipo")), True)
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

    Return o
  End Function

  Public Function VerificarTutor(ByVal wUsuario As Usuario) As Usuario
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_VerificarUserTutor", cn)
    Dim dr As SqlDataReader = Nothing
    Dim o As Usuario = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoPersona", wUsuario.Persona.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read = True Then

        o = New Usuario(dr.GetInt16(dr.GetOrdinal("CodigoUsu")), New Persona(dr.GetInt32(dr.GetOrdinal("CodigoPersona")), _
            dr.GetString(dr.GetOrdinal("Nombre")), dr.GetString(dr.GetOrdinal("ApellidoPat")), _
            dr.GetString(dr.GetOrdinal("ApellidoMat"))), dr.Item("nombreUser").ToString, _
            dr.Item("contrasenia").ToString, CChar(dr.Item("Tipo")), True)
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

    Return o
  End Function

  Public Function VerificarAdministrativo(ByVal wUsuario As Usuario) As Usuario
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_VerificarPersonal", cn)
    Dim dr As SqlDataReader = Nothing
    Dim o As Usuario = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoPersona", wUsuario.Persona.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read = True Then

        o = New Usuario(dr.GetInt16(dr.GetOrdinal("CodigoUsu")), New Persona(dr.GetInt32(dr.GetOrdinal("CodigoPersona")), _
            dr.GetString(dr.GetOrdinal("Nombre")), dr.GetString(dr.GetOrdinal("ApellidoPat")), _
            dr.GetString(dr.GetOrdinal("ApellidoMat"))), dr.Item("nombreUser").ToString, _
            "", CChar(dr.Item("Tipo")), True)
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

    Return o
  End Function

  Public Sub CambiarClave(ByVal Obj As Usuario, ByVal wclaveNueva As String)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aUsuarioClave", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Codigo", Obj.Codigo)
      '.AddWithValue("@Nombre", Obj.Nombre)
      .AddWithValue("@ContraseniaNueva", wclaveNueva)
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

  Public Sub Registrar(ByVal usuario As Usuario)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iUsuario", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigoPersona", usuario.Persona.Codigo)
      .AddWithValue("@nombreUsuario", usuario.Nombre)
      .AddWithValue("@contrasenia", usuario.Contrasenia)
      .AddWithValue("@tipo", usuario.Tipo)
      .AddWithValue("@vigencia", usuario.Vigencia)
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

  Public Function Verificar(ByVal nombre As String) As Usuario
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lUsuario", cn)
    Dim dr As SqlDataReader = Nothing
    Dim p As Usuario = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@nombreUsuario", nombre)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      If dr.Read = True Then
        p = New Usuario(New Persona(CInt(dr.Item("codigoPersona"))), CInt(dr.Item("codigoUsu")))
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
    Return p
  End Function

  Public Function Leer(ByVal wpro As String) As List(Of Usuario)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liUsuario", cn)
    Dim dr As SqlDataReader = Nothing
    Dim la As New List(Of Usuario)

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@nombreUsuario", wpro)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        la.Add(New Usuario(CInt(dr.Item("codigoUsu")), _
                           New Persona(CInt(dr.Item("codigoPersona")), dr.Item("nombre").ToString, dr.Item("apellidoPat").ToString, dr.Item("apellidoMat").ToString), _
                          dr.Item("nombreUsuario").ToString, "", CChar(dr.Item("tipo")), CBool(dr.Item("vigencia"))))
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
    Return la

  End Function

  Public Sub Modificar(ByVal usuario As Usuario)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aUsuario", cn)
    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigoUsu", usuario.Codigo)
      .AddWithValue("@codigoPersona", usuario.Persona.Codigo)
      .AddWithValue("@nombreUsuario", usuario.Nombre)
      .AddWithValue("@contrasenia", usuario.Contrasenia)
      .AddWithValue("@tipo", usuario.Tipo)
      .AddWithValue("@vigencia", usuario.Vigencia)
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

  Public Sub registrar2(ByVal usuario As Usuario, ByVal grupo As GrupoUsuario)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iUsuario_Grupo", cn)
    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigoUsu", usuario.Codigo)
      .AddWithValue("@codigoGrupoUsu", grupo.Codigo)
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

  Public Sub Eliminar(ByVal usuario As Usuario, ByVal grupo As GrupoUsuario)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_eUsuario_Grupo", cn)
    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigoUsu", usuario.Codigo)
      .AddWithValue("@codigoGrupoUsu", grupo.Codigo)
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

  Public Function PersonaUsuario(ByVal wpro As Integer) As List(Of Usuario)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liPersonaUsuario", cn)
    Dim dr As SqlDataReader = Nothing
    Dim la As New List(Of Usuario)

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@codigoPersona", wpro)

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        la.Add(New Usuario(CInt(dr.Item("codigoUsu")), dr.Item("nombreUsuario").ToString))

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
    Return la

  End Function

  Public Function Listar(ByVal wNombre As String) As List(Of Usuario)
    Dim la As New List(Of Usuario)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liUsuarios", cn)
    Dim dr As SqlDataReader = Nothing
    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Nombre", wNombre)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        la.Add(New Usuario(CInt(dr.Item("codigoUsu")), New Persona(CInt(dr.Item("codigoPersona")), dr.Item("nombre").ToString, dr.Item("apellidopat").ToString, dr.Item("apellidomat").ToString), dr.Item("nombreUsuario").ToString, "", "L"c, False))
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

    Return la
  End Function

  Public Function VerificarCoorPlanLectorTutor(ByVal wUsuario As Usuario) As Usuario
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_VerificarCoordPL", cn)
    Dim dr As SqlDataReader = Nothing
    Dim o As Usuario = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoPersona", wUsuario.Persona.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read = True Then

        o = New Usuario(dr.GetInt16(dr.GetOrdinal("CodigoUsu")), New Persona(dr.GetInt32(dr.GetOrdinal("CodigoPersona")), _
            dr.GetString(dr.GetOrdinal("Nombre")), dr.GetString(dr.GetOrdinal("ApellidoPat")), _
            dr.GetString(dr.GetOrdinal("ApellidoMat"))), dr.Item("nombreUser").ToString, _
            dr.Item("contrasenia").ToString, CChar(dr.Item("Tipo")), True)
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

    Return o
  End Function

  Public Function VerificarDirectorNivel(ByVal wUsuario As Usuario) As Usuario
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_VerificarDirectorNivel", cn)
    Dim dr As SqlDataReader = Nothing
    Dim o As Usuario = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoPersona", wUsuario.Persona.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read = True Then

        o = New Usuario(dr.GetInt16(dr.GetOrdinal("CodigoUsu")), New Persona(dr.GetInt32(dr.GetOrdinal("CodigoPersona")), _
            dr.GetString(dr.GetOrdinal("Nombre")), dr.GetString(dr.GetOrdinal("ApellidoPat")), _
            dr.GetString(dr.GetOrdinal("ApellidoMat"))), dr.Item("nombreUser").ToString, _
            dr.Item("contrasenia").ToString, CChar(dr.Item("Tipo")), True)
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

    Return o
  End Function

  Public Function ObtenerNivel(ByVal wUsuario As Usuario) As Nivel
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lNivelxUsuario", cn)
    Dim dr As SqlDataReader = Nothing
    Dim o As Nivel = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Usuario", wUsuario.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read = True Then
        o = New Nivel() With {.Codigo = CInt(dr.Item("codigoNivel")), .Nombre = dr.Item("NombreNivel").ToString}
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

    Return o
  End Function

End Class
