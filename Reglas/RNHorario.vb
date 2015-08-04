Public Class RNHorario
  Public Sub Registrar(ByVal ObjHorario As Horario)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iHorario", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigoCargaAcad", ObjHorario.CodigoCarga)
      .AddWithValue("@codigoAula", ObjHorario.Aula.Codigo)
      If ObjHorario.dia = "Miercoles" Then
        .AddWithValue("@dia", "I")
      Else
        .AddWithValue("@dia", Left(ObjHorario.dia, 1))
      End If

      .AddWithValue("@horaIni", ObjHorario.horaIni)
      .AddWithValue("@horaFin", ObjHorario.horaFin)
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
      ObjHorario = Nothing
    End Try
  End Sub
  Public Sub Modificar(ByVal ObjHorario As Horario)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aHorario", cn)
    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigo", ObjHorario.Codigo)
      .AddWithValue("@codigoCargaAcad", ObjHorario.CodigoCarga)
      .AddWithValue("@codigoAula", ObjHorario.Aula.Codigo)
      If ObjHorario.dia = "Miercoles" Then
        .AddWithValue("@dia", "I")
      Else
        .AddWithValue("@dia", Left(ObjHorario.dia, 1))
      End If
      .AddWithValue("@horaIni", ObjHorario.horaIni)
      .AddWithValue("@horaFin", ObjHorario.horaFin)


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

  Public Function Listar(ByVal wcodigo As Integer) As List(Of Horario)
    Dim lh As New List(Of Horario)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liHorarioCargaAsig", cn)
    Dim dr As SqlDataReader = Nothing
    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@codigoCargaAcad", wcodigo)

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        lh.Add(New Horario(CInt(dr.Item("codigo")), New CargaAcademica(CInt(dr.Item("codigoCargaAcad"))), _
                           New Aula(CInt(dr.Item("codigoAula"))), CStr(dr.Item("dia")), CDate(dr.Item("horaIni")), _
                           CDate(dr.Item("horaFin"))))
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
    Return lh
  End Function

  Public Function ListarHorario_Seccion(ByVal obj As Seccion) As List(Of Horario)
    Dim lh As New List(Of Horario)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liHorario_Seccion", cn)
    Dim dr As SqlDataReader = Nothing
    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoGrado", obj.Grado.Codigo)
    cmd.Parameters.AddWithValue("@letra", obj.Letra)
    cmd.Parameters.AddWithValue("@anio", obj.Anio.Anio)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        lh.Add(New Horario(CInt(dr.Item("codigo")), New CargaAcademica(Nothing, dr.Item("NombreCur").ToString), _
                           New Aula(0, dr.Item("tipo").ToString, Nothing, CInt(dr.Item("numero")), CInt(dr.Item("pabellon"))), _
                           CStr(dr.Item("dia")), CDate(dr.Item("horaIni")), CDate(dr.Item("horaFin"))))
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
    Return lh
  End Function
End Class
