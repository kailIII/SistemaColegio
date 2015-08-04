
Public Class RNLocal

  Public Function Leer() As List(Of Local)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liLocales", cn)
    Dim dr As SqlDataReader = Nothing
    Dim I As Institucion = Nothing
    cmd.CommandType = CommandType.StoredProcedure
    Dim ListL As List(Of Local) = Nothing

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ListL = New List(Of Local)
      Do While (dr.Read)
        ListL.Add(New Local(dr.Item("codigoLocal").ToString, dr.Item("direccion").ToString, _
                            dr.Item("distrito").ToString, dr.Item("nombre").ToString))
      Loop
    Catch ex As Exception
      If ListL IsNot Nothing Then
        ListL.Clear()
      End If
      I = Nothing
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

    Return ListL
  End Function
  Public Function Leer(ByVal wI As Institucion) As List(Of Local)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liLocales", cn)
    Dim dr As SqlDataReader = Nothing
    Dim I As Institucion = Nothing
    cmd.CommandType = CommandType.StoredProcedure
    Dim ListL As List(Of Local) = Nothing
    cmd.Parameters.AddWithValue("@codigoInst", wI.CodigoInst)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ListL = New List(Of Local)
      Do While (dr.Read)
        ListL.Add(New Local(dr.Item("codigoLocal").ToString, dr.Item("direccion").ToString, _
                            dr.Item("distrito").ToString, dr.Item("nombre").ToString))
      Loop
    Catch ex As Exception
      If ListL IsNot Nothing Then
        ListL.Clear()
      End If
      I = Nothing
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

    Return ListL
  End Function
  Public Function LeerLocal() As Local
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lLocal", cn)
    Dim dr As SqlDataReader = Nothing
    Dim l As Local = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      If dr.Read = True Then
        l = New Local("", "", dr.Item("distrito").ToString, dr.Item("provincia").ToString, _
dr.Item("departamento").ToString, "", "", New Institucion())
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
  Public Sub Registrar(ByVal wLocal As Local)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iLocal", cn)
    cmd.CommandType = CommandType.StoredProcedure

    With cmd.Parameters
      .AddWithValue("@CodigoLocal", wLocal.Codigo)
      .AddWithValue("@codigoInst", wLocal.Institucion.CodigoInst)
      .AddWithValue("@Nombre", wLocal.Nombre)
      .AddWithValue("@Direccion", wLocal.Direccion)
      .AddWithValue("@Telefono", wLocal.Telefono)
      .AddWithValue("@Vigencia", wLocal.Vigencia)
      .AddWithValue("@Pais", wLocal.Pais)
      .AddWithValue("@Departamento", wLocal.Departamento)
      .AddWithValue("@Provincia", wLocal.Provincia)
      .AddWithValue("@Distrito", wLocal.Distrito)
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

  Public Sub Modificar(ByVal wLocal As Local, ByVal wcodigo As String)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aLocal", cn)
    cmd.CommandType = CommandType.StoredProcedure

    With cmd.Parameters
      .AddWithValue("@CodigoLocal", wLocal.Codigo)
      .AddWithValue("@CodigoNuevo", wcodigo)

      .AddWithValue("@codigoInst", wLocal.Institucion.CodigoInst)
      .AddWithValue("@Nombre", wLocal.Nombre)
      .AddWithValue("@Direccion", wLocal.Direccion)
      .AddWithValue("@Telefono", wLocal.Telefono)
      .AddWithValue("@Vigencia", wLocal.Vigencia)
      .AddWithValue("@Pais", wLocal.Pais)
      .AddWithValue("@Departamento", wLocal.Departamento)
      .AddWithValue("@Provincia", wLocal.Provincia)
      .AddWithValue("@Distrito", wLocal.Distrito)
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

  Public Function ListarLocales_Nombre(ByVal wnombre As String) As List(Of Local)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liLocales_Nombre", cn)
    Dim dr As SqlDataReader = Nothing
    Dim I As Institucion = Nothing
    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Nombre", wnombre)
    Dim ListL As List(Of Local) = Nothing

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ListL = New List(Of Local)
      Do While (dr.Read)
        ListL.Add(New Local(dr.Item("codigoLocal").ToString, dr.Item("direccion").ToString, Nothing, _
                            dr.Item("nombre").ToString))
      Loop
    Catch ex As Exception
      If ListL IsNot Nothing Then
        ListL.Clear()
      End If
      I = Nothing
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
    Return ListL
  End Function

  Public Function LeerLocal_Codigo(ByVal wlocal As Local) As Local
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lLocal_Codigo", cn)
    Dim dr As SqlDataReader = Nothing
    Dim l As Local = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Codigo", wlocal.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      If dr.Read = True Then
        l = New Local(Nothing, New Institucion(CInt(dr.Item("CodigoInst"))), dr.Item("nombre").ToString, _
                                                       dr.Item("direccion").ToString, dr.Item("telefono").ToString, _
                                                       CBool(dr.Item("vigencia")), dr.Item("pais").ToString, _
                                                       dr.Item("departamento").ToString, _
                                                       dr.Item("provincia").ToString, dr.Item("distrito").ToString)
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

  Public Function ListarLocales_Inst(ByVal wcodigoInst As Integer) As List(Of Local)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liLocales_Institucion", cn)
    Dim dr As SqlDataReader = Nothing
    Dim I As Institucion = Nothing
    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoInst", wcodigoInst)
    Dim ListL As List(Of Local) = Nothing

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ListL = New List(Of Local)
      Do While (dr.Read)
        ListL.Add(New Local(dr.Item("codigoLocal").ToString, Nothing, Nothing, dr.Item("nombre").ToString))
      Loop
    Catch ex As Exception
      If ListL IsNot Nothing Then
        ListL.Clear()
      End If
      I = Nothing
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
    Return ListL
  End Function
End Class
