
Public Class RNTurno
  Public Function Listar() As List(Of Turno)
    Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_liTurnos", cn)
    Dim dr As SqlDataReader = Nothing
    Dim g As Grado = Nothing
    Dim ListT As List(Of Turno) = Nothing

    cmd.CommandType = CommandType.StoredProcedure

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ListT = New List(Of Turno)
      Do While (dr.Read)
        ListT.Add(New Turno(CInt(dr.Item("codigoTurno")), dr.Item("nombreTurno").ToString))
      Loop
    Catch ex As Exception
      If ListT IsNot Nothing Then
        ListT.Clear()
      End If
      g = Nothing
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
    Return ListT
  End Function

  Public Function ListarDatosTurnos() As List(Of Turno)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liTurnos2", cn)
    Dim dr As SqlDataReader = Nothing
    Dim g As Grado = Nothing
    Dim ListT As List(Of Turno) = Nothing

    cmd.CommandType = CommandType.StoredProcedure

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ListT = New List(Of Turno)
      Do While (dr.Read)
        ListT.Add(New Turno(CInt(dr.Item("codigoTurno")), dr.Item("nombreTurno").ToString, _
                            dr.GetDateTime(dr.GetOrdinal("horaIni")), dr.GetDateTime(dr.GetOrdinal("horaFin"))))
      Loop
    Catch ex As Exception
      If ListT IsNot Nothing Then
        ListT.Clear()
      End If
      g = Nothing
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
    Return ListT
  End Function
  'Public Function Leer(ByVal wt As Turno) As Turno
  '  Dim cn As New SqlConnection(My.Settings.Conexion)
  '  Dim cmd As New SqlCommand("pr_MostrarTurno", cn)
  '  Dim dr As SqlDataReader = Nothing
  '  Dim t As New Turno
  '  cmd.CommandType = CommandType.StoredProcedure
  '  cmd.Parameters.AddWithValue("@CodigoTurno", wt.Codigo)
  '  Try
  '    cn.Open()
  '    dr = cmd.ExecuteReader
  '    If dr.Read = True Then
  '      t = New Turno(wt.Codigo, dr.Item("nombreTurno").ToString)
  '    End If
  '    cn.Close()
  '  Catch ex As Exception
  '    Throw ex
  '  Finally
  '    cmd.Dispose()
  '    cmd = Nothing
  '    If cn.State = ConnectionState.Open Then
  '      cn.Close()
  '    End If
  '    cn.Dispose()
  '    cn = Nothing
  '  End Try

  '  Return t
  'End Function

  Public Sub Registrar(ByVal obj As Turno)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iTurno", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      '.AddWithValue("@CodigoModular", obj.ONivel.CodigoModular)
      .AddWithValue("@Nombre", obj.Nombre)
      .AddWithValue("@HoraIngreso", obj.HoraIni)
      .AddWithValue("@HoraSalida", obj.HoraFin)
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

  Public Sub Actualizar(ByVal obj As Turno)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aTurno", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Codigo", obj.Codigo)
      .AddWithValue("@Nombre", obj.Nombre)
      .AddWithValue("@HoraIni", obj.HoraIni)
      .AddWithValue("@HoraFin", obj.HoraFin)
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
