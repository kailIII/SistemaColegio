Public Class RNCoordinadorAreaDre
  Public Sub Registrar(ByVal Obj As CoordinadorAreaDre)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iCoordinadorArea", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigoAreaD", Obj.AreaDre.Codigo)
      .AddWithValue("@vigencia", Obj.Vigencia)
      .AddWithValue("@codigoDocente", Obj.Personal.Codigo)
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
  Public Sub Modificar(ByVal Obj As CoordinadorAreaDre)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aCoordinadorArea", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters

      .AddWithValue("@CodigoCoord", Obj.Codigo)
      .AddWithValue("@codigoDocente", Obj.Personal.Codigo)
      .AddWithValue("@codigoAreaD", Obj.AreaDre.Codigo)
      .AddWithValue("@vigencia", Obj.Vigencia)
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

  Public Function ListarCoordArea(ByVal wCodigoNivel As String) As List(Of CoordinadorAreaDre)
    Dim ld As New List(Of CoordinadorAreaDre)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As SqlCommand

    cmd = New SqlCommand("pr_liCoord_Nivel", cn)
    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoNivel", wCodigoNivel)
    Dim dr As SqlDataReader = Nothing
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        ld.Add(New CoordinadorAreaDre(CInt(dr.Item("CodigoCoord")), CBool(dr.Item("vigencia")), New AreaDRE(Nothing, _
                                                                             (dr.Item("nombreAreaD").ToString), Nothing, _
                                      New Nivel(Nothing, (dr.Item("nombreNivel").ToString), "")), _
                                      New Docente(Nothing, dr.Item("Nombre").ToString, dr.Item("ApellidoPat").ToString, _
                                                    dr.Item("ApellidoMat").ToString)))
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

  Public Function Leer(ByVal obj As CoordinadorAreaDre) As CoordinadorAreaDre
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lCoordCodigo", cn)
    Dim dr As SqlDataReader = Nothing
    Dim c As CoordinadorAreaDre = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Codigo", obj.Codigo)

    Try
      cn.Open()
      dr = cmd.ExecuteReader

      If dr.Read = True Then
        c = New CoordinadorAreaDre(obj.Codigo, CBool(dr.Item("vigencia")), New AreaDRE(CInt(dr.Item("codigoAreaD")), _
                                                                             Nothing, Nothing, _
                                      New Nivel(CInt(dr.Item("codigoNivel")), Nothing, "")), _
                                      New Docente(CInt(dr.Item("codigopersona")), dr.Item("Nombre").ToString, dr.Item("ApellidoPat").ToString, _
                                                    dr.Item("ApellidoMat").ToString))

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

  Public Function LeerAsesorArea(ByVal obj As Curso) As CoordinadorAreaDre
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lCoordinadorAsesor", cn)
    Dim dr As SqlDataReader = Nothing
    Dim c As CoordinadorAreaDre = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoCur", obj.Codigo)

    Try
      cn.Open()
      dr = cmd.ExecuteReader

      If dr.Read = True Then
        c = New CoordinadorAreaDre(0, Nothing, New AreaDRE(), _
                                      New Docente(CInt(dr.Item("codigopersona")), dr.Item("Nombre").ToString, dr.Item("ApellidoPat").ToString, _
                                                    dr.Item("ApellidoMat").ToString))

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
End Class
