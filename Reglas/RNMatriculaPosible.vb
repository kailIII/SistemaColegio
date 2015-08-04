
Public Class RNMatriculaPosible

  Public Sub Registrar(ByVal objMat As MatriculaPosible)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmdMat As New SqlCommand("pr_iMatriculaPosible", cn)

    cmdMat.CommandType = CommandType.StoredProcedure
    With cmdMat.Parameters
      .AddWithValue("@Alumno", objMat.Alumno.Codigo)
      .AddWithValue("@Apoderado", objMat.Apoderado.CodigoApoderado)
      .AddWithValue("@anio", objMat.Seccion.Anio.Anio)
      .AddWithValue("@Grado", objMat.Seccion.Grado.Codigo)
      .AddWithValue("@letra", CChar(objMat.Seccion.Letra))
    End With

    Try
      cn.Open()

      cmdMat.ExecuteNonQuery()
      cn.Close()
    Catch ex As Exception
      Throw ex
    Finally
      cmdMat.Dispose()
      cmdMat = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
  End Sub

  Public Function Leer(ByVal wAlumno As Alumno, ByVal wAnio As AnioLectivo) As MatriculaPosible
    Dim mp As MatriculaPosible = Nothing
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lMatriculaPosible", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Alumno", wAlumno.Codigo)
    cmd.Parameters.AddWithValue("@Anio", wAnio.Anio)

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read Then
        mp = New MatriculaPosible
        mp.Alumno = wAlumno
        mp.Apoderado = New Parentesco
        mp.Apoderado.Apoderado = New Apoderado(CInt(dr.Item("CodigoApoderado")), dr.Item("ApellidoPat").ToString, _
                                               dr.Item("ApellidoMat").ToString, dr.Item("Nombre").ToString)
        mp.Apoderado.Alumno = wAlumno
        mp.Seccion = New Seccion(wAnio, New Grado(CInt(dr.Item("CodigoG"))), CChar(dr.Item("Letra")))
        mp.Seccion.Grado.Numero = CInt(dr.Item("Numero"))
        mp.Seccion.Letra = CChar(dr.Item("Letra"))
        mp.Seccion.Grado.Nivel = New Nivel(CInt(dr.Item("codigoNivel")))
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

    Return mp
  End Function
End Class
