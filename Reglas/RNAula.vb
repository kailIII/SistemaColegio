Public Class RNAula

  Public Function ListarAula(ByVal wA As Aula, ByVal wL As Local) As List(Of Aula)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("liAulas", cn)
    Dim dr As SqlDataReader = Nothing
    Dim A As Grado = Nothing
    Dim ListA As List(Of Aula) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@vigencia", wA.Vigencia)
    cmd.Parameters.AddWithValue("@codigoLocal", wL.Codigo)

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ListA = New List(Of Aula)
      Do While (dr.Read)
        ListA.Add(New Aula(CInt(dr.Item("codigoAula")), dr.Item("codigoLocal").ToString, CInt(dr.Item("numero")), _
                           CInt(dr.Item("capacidadCarpetas")), wA.Vigencia, CInt(dr.Item("piso")), dr.Item("tipo").ToString, _
                            CInt(dr.Item("pabellon"))))
      Loop
    Catch ex As Exception
      If ListA IsNot Nothing Then
        ListA.Clear()
      End If
      A = Nothing
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
    Return ListA
  End Function
  Public Function Leer(ByVal wa As Aula) As Aula
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lAulaLocal", cn)
    Dim dr As SqlDataReader = Nothing
    Dim a As New Aula
    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoAula", wa.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read = True Then
        a = New Aula(wa.Codigo, dr.Item("codigoLocal").ToString, CInt(dr.Item("numero")), CInt(dr.Item("capacidadCarpetas")), _
                     CBool(dr.Item("estado")), CInt(dr.Item("piso")), dr.Item("tipo").ToString, dr.Item("Nombre").ToString, _
                     CInt(dr.Item("pabellon")))
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
    Return a
  End Function
  Public Function ListarTodasAulas() As List(Of Aula)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAulasTodas", cn)
    Dim dr As SqlDataReader = Nothing
    Dim A As Grado = Nothing
    Dim ListA As List(Of Aula) = Nothing
    cmd.CommandType = CommandType.StoredProcedure
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ListA = New List(Of Aula)
      Do While (dr.Read)
        ListA.Add(New Aula(CInt(dr.Item("codigoAula")), dr.Item("Tipo").ToString, New Local(dr.Item("codigoLocal").ToString, _
                                dr.Item("nombre").ToString), CInt(dr.Item("numero")), CInt((dr.Item("pabellon"))), CBool(dr.Item("vigencia"))))
      Loop
    Catch ex As Exception
      If ListA IsNot Nothing Then
        ListA.Clear()
      End If
      A = Nothing
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
    Return ListA
  End Function
  Public Sub Registrar(ByVal wAula As Aula)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iAula", cn)
    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoLocal", wAula.Local.Codigo)
      .AddWithValue("@Tipo", wAula.Tipo)
      .AddWithValue("@Numero", wAula.Numero)
      .AddWithValue("@Piso", wAula.Piso)
      .AddWithValue("@Capacidad", wAula.Capacidad)
      .AddWithValue("@Pabellon", wAula.Pabellon)
      .AddWithValue("@Vigencia", wAula.Vigencia)
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
  Public Sub Modificar(ByVal wAula As Aula)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aAula", cn)
    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoAula", wAula.Codigo)
      .AddWithValue("@CodigoLocal", wAula.Local.Codigo)
      .AddWithValue("@Tipo", wAula.Tipo)
      .AddWithValue("@Numero", wAula.Numero)
      .AddWithValue("@Piso", wAula.Piso)
      .AddWithValue("@Capacidad", wAula.Capacidad)
      .AddWithValue("@Pabellon", wAula.Pabellon)
      .AddWithValue("@Vigencia", wAula.Vigencia)
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

End Class
