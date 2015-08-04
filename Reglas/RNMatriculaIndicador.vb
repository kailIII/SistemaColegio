Public Class RNMatriculaIndicador
  Public Function ListarNotas(ByVal obj As Indicador) As List(Of MatriculaIndicador)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liNotaIndicador", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ln As List(Of MatriculaIndicador) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codPeriodo", obj.Periodo)
      .AddWithValue("@codDocCarga", obj.DocenteCarga)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ln = New List(Of MatriculaIndicador)
      While dr.Read
        ln.Add(New MatriculaIndicador(New Matricula(CInt(dr.Item("NroMatricula"))), CInt(dr.Item("numero")), _
                dr.Item("letra").ToString, CDate(dr.Item("fecha")), CBool(dr.Item("vigencia")), CInt(dr.Item("codigoIndicador")), _
                 CInt(dr.Item("codigoPersonal")), _
                 Nothing, _
                 CInt(IIf(IsDBNull(dr.Item("numeroAnt")) = True, 0, dr.Item("numeroAnt")))))
      End While
      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally

    End Try
    Return ln
  End Function

  Public Sub Registrar(ByVal obj As MatriculaIndicador)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iNotaIndicador", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@NroMatricula", obj.Matricula.Numero)
      .AddWithValue("@CodIndicador", obj.CodIndicador)
      .AddWithValue("@Letra", obj.Letra)
      .AddWithValue("@CodPersonal", obj.Personal)
    End With

    Try
      cn.Open()
      cmd.ExecuteNonQuery()
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

  End Sub

  Public Function LeerNota(ByVal Obj As MatriculaIndicador) As MatriculaIndicador
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lNotaIndicador", cn)
    Dim dr As SqlDataReader
    Dim nota As MatriculaIndicador = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@NroMatricula", Obj.Matricula.Numero)
    cmd.Parameters.AddWithValue("@CodigoIndicador", Obj.CodIndicador)

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read Then
        nota = New MatriculaIndicador(0, CInt(dr.Item("numero")), dr.Item("letra").ToString)
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

    Return nota
  End Function

  Public Sub RegistrarNuevaNotaIndicador(ByVal obj As MatriculaIndicador)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iNuevaNotaIndicador", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@NroMatricula", obj.Matricula.Numero)
      .AddWithValue("@Numero", obj.Numero)
      .AddWithValue("@Letra", obj.Letra)
      .AddWithValue("@CodPersonal", obj.Personal)
    End With

    Try
      cn.Open()
      cmd.ExecuteNonQuery()
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

  End Sub

  Public Function ListarNotasIndicador(ByVal obj As Indicador) As List(Of MatriculaIndicador)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liNotaIndicadorGrupo", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ln As List(Of MatriculaIndicador) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codPeriodo", obj.Periodo)
      .AddWithValue("@codDocCarga", obj.DocenteCarga)
      .AddWithValue("@CodigoInd", obj.Codigo)

    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ln = New List(Of MatriculaIndicador)
      While dr.Read
        ln.Add(New MatriculaIndicador(New Matricula(CInt(dr.Item("NroMatricula")), Nothing, CInt(dr.Item("nroOrden"))), CInt(dr.Item("numero")), _
                dr.Item("letra").ToString, Nothing, CBool(dr.Item("vigencia")), CInt(dr.Item("codigoIndicador")), _
                 CInt(dr.Item("codigoPersonal")), _
                 Nothing, _
                 CInt(IIf(IsDBNull(dr.Item("numeroAnt")) = True, 0, dr.Item("numeroAnt")))))
      End While
      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally

    End Try
    Return ln
  End Function
  Public Function ListarNotasInd_Alumno(ByVal obj As Indicador, ByVal NroMat As Integer) As MatriculaIndicador
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liNotaIndicadorAlumno", cn)
    Dim dr As SqlDataReader = Nothing
    Dim nota As MatriculaIndicador = Nothing
    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codPeriodo", obj.Periodo)
      .AddWithValue("@codDocCarga", obj.DocenteCarga)
      .AddWithValue("@CodigoInd", obj.Codigo)
      .AddWithValue("@NroMatricula", NroMat)

    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read Then
        nota = New MatriculaIndicador(New Matricula(CInt(dr.Item("NroMatricula")), Nothing, CInt(dr.Item("nroOrden"))), CInt(dr.Item("numero")), _
                dr.Item("letra").ToString, Nothing, CBool(dr.Item("vigencia")), CInt(dr.Item("codigoIndicador")), _
                 CInt(dr.Item("codigoPersonal")), _
                 Nothing, _
                 CInt(IIf(IsDBNull(dr.Item("numeroAnt")) = True, 0, dr.Item("numeroAnt"))))
      End If
      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally

    End Try
    Return nota
  End Function

End Class
