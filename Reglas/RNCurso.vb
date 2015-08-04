
Public Class RNCurso
  Inherits CADO

  Public Sub Registrar(ByVal Obj As Curso)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iCurso", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@nombreCur", Obj.Nombre)
      .AddWithValue("@nroHoras", Obj.NumeroHoras)
      .AddWithValue("@codigoG", Obj.Grado.Codigo)
      .AddWithValue("@vigencia", Obj.vigencia)
      .AddWithValue("@grupo", Obj.Grupo)
      .AddWithValue("@rotativo", Obj.Rotativo)
      .AddWithValue("@codigoAreaDre", Obj.CodigoAreaDre.Codigo)
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

  Public Sub Modificar(ByVal Obj As Curso)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aCurso", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigoCur", Obj.Codigo)
      .AddWithValue("@nombreCur", Obj.Nombre)
      .AddWithValue("@nroHoras", Obj.NumeroHoras)
      .AddWithValue("@codigoG", Obj.Grado.Codigo)
      .AddWithValue("@vigencia", Obj.vigencia)
      .AddWithValue("@grupo", Obj.Grupo)
      .AddWithValue("@rotativo", Obj.Rotativo)
      .AddWithValue("@codigoAreaDre", Obj.CodigoAreaDre.Codigo)
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

  Public Function Listar(ByVal obj As Grado) As List(Of Curso)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liCurso_Grado", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ld As New List(Of Curso)

    cmd.Parameters.AddWithValue("@CodigoG", obj.Codigo)
    cmd.CommandType = CommandType.StoredProcedure
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        ld.Add(New Curso(CInt(dr.Item("codigoCur")), dr.Item("nombreCur").ToString, obj.Codigo, Nothing))
      End While
      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally
      cmd.Dispose()
      cmd = Nothing
      dr.Dispose()
      dr = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try

    Return ld
  End Function

  Public Function Leer(ByVal obj As Curso) As Curso
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lCursoCodigo", cn)
    Dim dr As SqlDataReader = Nothing
    Dim c As Curso = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Codigo", obj.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      If dr.Read = True Then
        c = New Curso(CInt(dr.Item("codigoNivel")), obj.Codigo, dr.Item("nombreCur").ToString, CInt(dr.Item("nroHoras")), _
                      CInt(dr.Item("codigoG")), CBool(dr.Item("vigencia")), CBool(dr.Item("Grupo")), CBool(dr.Item("rotativo")), _
                      CInt(dr.Item("CodigoAreaD")))
        c.Codigo = obj.Codigo
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

    Return c
  End Function

  Public Function ListarCur_Grados(ByVal obj As Seccion) As List(Of Curso)
    Dim lcg As New List(Of Curso)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As SqlCommand

    cmd = New SqlCommand("pr_liGradosNivel", cn)
    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoNivel", obj.Grado.Nivel.Codigo)
    cmd.Parameters.AddWithValue("@Anio", obj.Anio.Anio)

    Dim dr As SqlDataReader = Nothing


    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        lcg.Add(New Curso(CInt(dr.Item("Numero")), CChar(dr.Item("Letra").ToString.Trim), _
                          dr.Item("NombreCur").ToString, CInt(dr.Item("NroHoras"))))
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

    Return lcg
  End Function

  Public Function RetornaCodCur(ByVal obj As Curso) As Integer
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lCodigo_Curso", cn)

    Dim dr As Integer


    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@codigoG", obj.Grado.Codigo)
    cmd.Parameters.AddWithValue("@nombreCur", obj.Nombre)
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

End Class
