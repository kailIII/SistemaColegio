Public Class RNDetalleDctoIngreso

  'Public Function leerObligacionesNocanceladas(ByVal wMatricula As Matricula, ByVal wentidad As String) As List(Of DetalleDocumentoIngreso)
  '  Dim cn As New SqlConnection(My.Settings.Conexion)
  '  Dim cmd As New SqlCommand("pr_liObligacionMatriculaDetalle", cn)

  '  Dim dr As SqlDataReader = Nothing
  '  Dim detDI As DetalleDocumentoIngreso = Nothing
  '  cmd.CommandType = CommandType.StoredProcedure
  '  cmd.Parameters.AddWithValue("@matricula", wMatricula.Numero)
  '  cmd.Parameters.AddWithValue("@entidad", wentidad)
  '  Dim ListdetDI As List(Of DetalleDocumentoIngreso) = Nothing
  '  Try
  '    cn.Open()
  '    dr = cmd.ExecuteReader
  '    ListdetDI = New List(Of DetalleDocumentoIngreso)
  '    Do While (dr.Read)
  '      ListdetDI.Add(New DetalleDocumentoIngreso(0, 0, dr.Item("descripcion").ToString, CDbl(dr.Item("monto")) _
  '                                    , CDbl(dr.Item("descuento")), CDbl(dr.Item("subtotal")), New Servicio(), _
  '                      New Obligacion(CInt(dr.Item("codigoObligacion")), dr.Item("descripcion").ToString, _
  '                      CDbl(dr.Item("monto")), True, CDate(dr.Item("fecha")), New Servicio(CInt(dr.Item("codigoServicio"))), _
  '                      New Matricula(CInt(dr.Item("matricula"))), New Obligacion(CInt(dr.Item("obligacionPadre"))))))
  '    Loop
  '  Catch ex As Exception
  '    If ListdetDI IsNot Nothing Then
  '      ListdetDI.Clear()
  '    End If
  '    detDI = Nothing
  '    Throw ex
  '  Finally
  '    cmd.Dispose()
  '    cmd = Nothing
  '    dr.Dispose()
  '    dr = Nothing
  '    If cn.State = ConnectionState.Open Then
  '      cn.Close()
  '    End If
  '    cn.Dispose()
  '    cn = Nothing
  '  End Try

  '  Return ListdetDI
  'End Function

  'Public Function leerDetalleDocIngreso(ByVal codigo As Integer) As List(Of DetalleDocumentoIngreso)
  '  Dim cn As New SqlConnection(My.Settings.Conexion)
  '  Dim cmd As New SqlCommand("pr_liDetalleDocIngreso", cn)
  '  Dim dr As SqlDataReader = Nothing
  '  Dim detDI As DetalleDocumentoIngreso = Nothing
  '  cmd.CommandType = CommandType.StoredProcedure
  '  cmd.Parameters.AddWithValue("@codigoDocumentoIngreso", codigo)
  '  Dim ListdetDI As List(Of DetalleDocumentoIngreso) = Nothing
  '  Try
  '    cn.Open()
  '    dr = cmd.ExecuteReader
  '    ListdetDI = New List(Of DetalleDocumentoIngreso)
  '    Do While (dr.Read)
  '      ListdetDI.Add(New DetalleDocumentoIngreso(codigo, 0, dr.Item("descripcion").ToString, CDbl(dr.Item("monto")), _
  '                                           CDbl(dr.Item("descuento")), 0, New Servicio(CInt(dr.Item("codigoServicio")), "", CDbl(dr.Item("montoServ")), "", _
  '                                              "", True, New TipoServicio(), New CuentaContable, New Nivel()), _
  '                                           New Obligacion(CInt(dr.Item("codigoObligacion")), dr.Item("descripcion").ToString, CDbl(dr.Item("montoOblig")), True, _
  '                                             CDate(dr.Item("fechaVcto")), New Servicio(CInt(dr.Item("codigoServicioOblig"))), _
  '                                           New Matricula(CInt(dr.Item("nroMatricula"))), New Obligacion(CInt(dr.Item("obligacionPadre"))))))
  '    Loop
  '  Catch ex As Exception
  '    If ListdetDI IsNot Nothing Then
  '      ListdetDI.Clear()
  '    End If
  '    detDI = Nothing
  '    Throw ex
  '  Finally
  '    cmd.Dispose()
  '    cmd = Nothing
  '    dr.Dispose()
  '    dr = Nothing
  '    If cn.State = ConnectionState.Open Then
  '      cn.Close()
  '    End If
  '    cn.Dispose()
  '    cn = Nothing
  '  End Try

  '  Return ListdetDI
  'End Function

  'Public Function leerObligaciones(ByVal wMatricula As Matricula, ByVal wentidad As String) As List(Of DetalleDocumentoIngreso)
  '  Dim cn As New SqlConnection(My.Settings.Conexion)
  '  Dim cmd As New SqlCommand("pr_lEstadoCuenta", cn)
  '  Dim dr As SqlDataReader = Nothing
  '  Dim detDI As DetalleDocumentoIngreso = Nothing
  '  cmd.CommandType = CommandType.StoredProcedure
  '  cmd.Parameters.AddWithValue("@matricula", wMatricula.Numero)
  '  cmd.Parameters.AddWithValue("@entidad", wentidad)
  '  Dim ListdetDI As List(Of DetalleDocumentoIngreso) = Nothing
  '  Try
  '    cn.Open()
  '    dr = cmd.ExecuteReader
  '    ListdetDI = New List(Of DetalleDocumentoIngreso)
  '    Do While (dr.Read)
  '      ListdetDI.Add(New DetalleDocumentoIngreso(CInt(dr.Item("item")), 0, dr.Item("descripcion").ToString, CDbl(dr.Item("monto")), CDbl(dr.Item("descuento")), CDbl(dr.Item("montoDebe")), New Servicio(), _
  '                              New Obligacion(CInt(dr.Item("codigoObligacion")), dr.Item("descripcion").ToString, _
  '                              CDbl(dr.Item("monto")), True, CDate(dr.Item("fecha")), New Servicio(CInt(dr.Item("codigoServicio"))), _
  '                              New Matricula(CInt(dr.Item("matricula"))), New Obligacion(CInt(dr.Item("obligacionPadre"))))))
  '    Loop
  '  Catch ex As Exception
  '    If ListdetDI IsNot Nothing Then
  '      ListdetDI.Clear()
  '    End If
  '    detDI = Nothing
  '    Throw ex
  '  Finally
  '    cmd.Dispose()
  '    cmd = Nothing
  '    dr.Dispose()
  '    dr = Nothing
  '    If cn.State = ConnectionState.Open Then
  '      cn.Close()
  '    End If
  '    cn.Dispose()
  '    cn = Nothing
  '  End Try

  '  Return ListdetDI
  'End Function

  Public Function ListarObligacionesVencidasCartas(ByVal wanio As String, ByVal wnivel As Integer, ByVal wGrado As String) As List(Of DetalleDocumentoIngreso)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liObligacionVencidaCarta", cn)
    Dim dr As SqlDataReader = Nothing
    Dim detDI As DetalleDocumentoIngreso = Nothing
    Dim Listdet As List(Of DetalleDocumentoIngreso) = Nothing

    Dim A, A1() As String

    cmd.CommandType = CommandType.StoredProcedure

    A = wGrado
    A1 = A.Split(CChar(" "))

    cmd.Parameters.AddWithValue("@anio", wanio)
    cmd.Parameters.AddWithValue("@nivel", wnivel)
    cmd.Parameters.AddWithValue("@grado", A1(0))
    cmd.Parameters.AddWithValue("@letra", A1(1))

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      Listdet = New List(Of DetalleDocumentoIngreso)
      Do While (dr.Read)
        Listdet.Add(New DetalleDocumentoIngreso(New Obligacion(New Matricula()), CInt(dr.Item("Meses")), CDbl(dr.Item("Vencido"))))

        With Listdet.Item(Listdet.Count - 1)
          With .Obligacion
            .Matricula.Parentesco = New Parentesco
            .Matricula.Parentesco.Apoderado = New Apoderado(CInt(0), CStr(dr.Item("ApellidoPat")), CStr(dr.Item("ApellidoMat")), CStr(dr.Item("Nombre")))
          End With
        End With
      Loop

    Catch ex As Exception
      If Listdet IsNot Nothing Then
        Listdet.Clear()
      End If
      detDI = Nothing
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

    Return Listdet
  End Function

End Class
