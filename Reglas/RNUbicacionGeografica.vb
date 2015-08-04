
Public Class RNUbicacionGeografica

  Public Function ListarPaises() As List(Of UbicacionGeografica)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liPaises", cn)
    Dim dr As SqlDataReader = Nothing
    Dim Paises As List(Of UbicacionGeografica) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    'cmd.Parameters.AddWithValue("@Vigencia", )
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      Paises = New List(Of UbicacionGeografica)
      Do While (dr.Read)
        Dim tp As New UbicacionGeografica("", "", "", dr.Item("pais").ToString)
        Paises.Add(tp)
      Loop
      cn.Close()
    Catch ex As Exception
      If Paises IsNot Nothing Then
        Paises.Clear()
      End If
      Paises = Nothing
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

    Return Paises
  End Function

  Public Function ListarDptos(ByVal wpais As String) As List(Of UbicacionGeografica)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liDptos", cn)
    Dim dr As SqlDataReader = Nothing
    Dim Dptos As List(Of UbicacionGeografica) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@pais", wpais)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      Dptos = New List(Of UbicacionGeografica)
      Do While (dr.Read)
        Dim tp As New UbicacionGeografica("", "", dr.Item("departamento").ToString, wpais)
        Dptos.Add(tp)
      Loop
      cn.Close()
    Catch ex As Exception
      If Dptos IsNot Nothing Then
        Dptos.Clear()
      End If
      Dptos = Nothing
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

    Return Dptos
  End Function
  Public Function ListarProvincias(ByVal wpais As String, ByVal wdpto As String) As List(Of UbicacionGeografica)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liProvincias", cn)
    Dim dr As SqlDataReader = Nothing
    Dim Provincias As List(Of UbicacionGeografica) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@pais", wpais)
    cmd.Parameters.AddWithValue("@dpto", wdpto)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      Provincias = New List(Of UbicacionGeografica)
      Do While (dr.Read)
        Dim tp As New UbicacionGeografica("", dr.Item("provincia").ToString, wdpto, wpais)
        Provincias.Add(tp)
      Loop
      cn.Close()
    Catch ex As Exception
      If Provincias IsNot Nothing Then
        Provincias.Clear()
      End If
      Provincias = Nothing
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

    Return Provincias
  End Function
  Public Function ListarDistritos(ByVal wpais As String, ByVal wdpto As String, ByVal wprovincia As String) As List(Of UbicacionGeografica)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liDistritos", cn)
    Dim dr As SqlDataReader = Nothing
    Dim Distritos As List(Of UbicacionGeografica) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@pais", wpais)
    cmd.Parameters.AddWithValue("@dpto", wdpto)
    cmd.Parameters.AddWithValue("@provincia", wprovincia)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      Distritos = New List(Of UbicacionGeografica)
      Do While (dr.Read)
        Dim tp As New UbicacionGeografica(dr.Item("distrito").ToString, wprovincia, wdpto, wpais)
        Distritos.Add(tp)
      Loop
      cn.Close()
    Catch ex As Exception
      If Distritos IsNot Nothing Then
        Distritos.Clear()
      End If
      Distritos = Nothing
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

    Return Distritos
  End Function

  Public Sub Registrar(ByVal obj As UbicacionGeografica)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iUbicacionGeografica", cn)
    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      cmd.Parameters.AddWithValue("@Pais", obj.Pais)
      cmd.Parameters.AddWithValue("@Departamento", obj.Departamento)
      cmd.Parameters.AddWithValue("@Provincia", obj.Provincia)
      cmd.Parameters.AddWithValue("@Distrito", obj.Distrito)
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

  Public Sub Modificar(ByVal obj As UbicacionGeografica)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aUbicacionGeografica", cn)
    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      cmd.Parameters.AddWithValue("@Codigo", obj.CodigoUbGeog)
      cmd.Parameters.AddWithValue("@Pais", obj.Pais)
      cmd.Parameters.AddWithValue("@Departamento", obj.Departamento)
      cmd.Parameters.AddWithValue("@Provincia", obj.Provincia)
      cmd.Parameters.AddWithValue("@Distrito", obj.Distrito)
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
  Public Function ListarUbicacion() As List(Of UbicacionGeografica)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liUbicacionGeografica", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lUbicacion As List(Of UbicacionGeografica) = Nothing

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lUbicacion = New List(Of UbicacionGeografica)
      Do While (dr.Read)
        Dim tp As New UbicacionGeografica(CInt(dr.Item("codigoUbicGeog")), dr.Item("distrito").ToString, dr.Item("provincia").ToString, _
                                          dr.Item("departamento").ToString, dr.Item("pais").ToString)
        lUbicacion.Add(tp)
      Loop
      cn.Close()
    Catch ex As Exception
      If lUbicacion IsNot Nothing Then
        lUbicacion.Clear()
      End If
      lUbicacion = Nothing
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
    Return lUbicacion
  End Function

  Public Function ListarUbicacion_Nombre(ByVal wnombre As String) As List(Of UbicacionGeografica)
    Dim le As New List(Of UbicacionGeografica)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liUbicacion_nombre", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Nombre", wnombre)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        le.Add(New UbicacionGeografica(CInt(dr.Item("codigoUbicGeog")), dr.Item("distrito").ToString, dr.Item("provincia").ToString, _
                                          dr.Item("departamento").ToString, dr.Item("pais").ToString))
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
    Return le
  End Function
  Public Function LeerUbicacion_Codigo(ByVal obj As UbicacionGeografica) As UbicacionGeografica
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lUbicacion_Codigo", cn)
    Dim dr As SqlDataReader = Nothing
    Dim l As UbicacionGeografica = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Codigo", obj.CodigoUbGeog)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      If dr.Read = True Then
        l = New UbicacionGeografica(obj.CodigoUbGeog, dr.Item("distrito").ToString, dr.Item("provincia").ToString, _
                                          dr.Item("departamento").ToString, dr.Item("pais").ToString)
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

    Return l
  End Function
End Class
