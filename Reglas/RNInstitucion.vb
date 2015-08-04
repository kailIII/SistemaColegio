
Public Class RNInstitucion

  Public Function Listar() As Institucion
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liInstitucion", cn)
    Dim dr As SqlDataReader = Nothing
    Dim Inst As Institucion = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If (dr.Read) Then
        Inst = New Institucion(CInt(dr.Item("codigoInst")), dr.Item("nombreInst").ToString, CChar(dr.Item("gestion")), dr.Item("resolucion").ToString)
      End If
      cn.Close()
    Catch ex As Exception
      Inst = Nothing
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

    Return Inst
  End Function

  Public Function ListarI() As List(Of Institucion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liInstitucion", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lInst As List(Of Institucion) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lInst = New List(Of Institucion)
      Do While (dr.Read)
        lInst.Add(New Institucion(CInt(dr.Item("codigoInst")), dr.Item("nombreInst").ToString, CChar(dr.Item("gestion")), _
                          dr.Item("resolucion").ToString))
      Loop
      cn.Close()
    Catch ex As Exception
      lInst = Nothing
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

    Return lInst
  End Function

End Class
