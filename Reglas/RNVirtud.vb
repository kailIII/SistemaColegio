Public Class RNVirtud

  Public Sub Registrar(ByVal obj As Virtud)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iVirtud", cn)


    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Anio", obj.OAnio.Anio)
      .AddWithValue("@CodNivel", obj.ONivel.Codigo)
      .AddWithValue("@CodPer", obj.OPeriodo.Codigo)
      .AddWithValue("@IdVirtud", obj.Id)
      .AddWithValue("@Nombre", obj.Nombre)
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
      obj = Nothing
    End Try
  End Sub

  Public Function ListarVirtudes(ByVal obj As Virtud) As List(Of Virtud)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liVirtud", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lv As List(Of Virtud) = Nothing

    cmd.CommandType = CommandType.StoredProcedure

    cmd.Parameters.AddWithValue("@Anio", obj.OAnio.Anio)
    cmd.Parameters.AddWithValue("@CodNivel", obj.ONivel.Codigo)
    cmd.Parameters.AddWithValue("@CodPer", obj.OPeriodo.Codigo)
    Try

      cn.Open()
      dr = cmd.ExecuteReader
      lv = New List(Of Virtud)
      While dr.Read
        lv.Add(New Virtud(CInt(dr.Item("codigoVirtudComp")), dr.Item("Nombre").ToString, _
                          CBool(dr.Item("vigencia")), New AnioLectivo(), _
                          New PeriodoAcademico(), New Nivel(), CInt(dr.Item("idVirtud"))))
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

    Return lv
  End Function

  Public Sub Actualizar(ByVal Obj As Virtud)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aVirtud", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodVirtud", Obj.Codigo)
      .AddWithValue("@Nombre", Obj.Nombre)
      .AddWithValue("@IdVirtud", Obj.Id)
      .AddWithValue("@Vigencia", Obj.Vigencia)
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

  Public Function ListarVirtudesPeriodo(ByVal obj As Virtud) As List(Of Virtud)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lVirtudPerSec", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lv As List(Of Virtud) = Nothing

    cmd.CommandType = CommandType.StoredProcedure

    cmd.Parameters.AddWithValue("@Anio", obj.OAnio.Anio)
    cmd.Parameters.AddWithValue("@CodPer", obj.OPeriodo.Codigo)
    cmd.Parameters.AddWithValue("@CodNivel", obj.ONivel.Codigo)
    Try

      cn.Open()
      dr = cmd.ExecuteReader
      lv = New List(Of Virtud)
      While dr.Read
        lv.Add(New Virtud(CInt(dr.Item("codigoVirtudComp")), dr.Item("Nombre").ToString, _
                          True, New AnioLectivo(), New PeriodoAcademico(), New Nivel(), _
                           CInt(dr.Item("idVirtud"))))
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

    Return lv
  End Function

End Class
