Public Class RNServicio
  Inherits CADO

  Public Sub Registrar(ByVal ws As Servicio)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iServicio", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@nombre", ws.Nombre)
      .AddWithValue("@codigoCtaContable", ws.CuentaContable.Codigo)
      .AddWithValue("@descripcion", ws.Descripcion)
      .AddWithValue("@entidad", ws.entidad)
      .AddWithValue("@vigencia", ws.vigencia)
      .AddWithValue("@Caduca", ws.Caduca)
      .AddWithValue("@PagoBanco", ws.PagoBanco)
      .AddWithValue("@monto", ws.Monto)
      .AddWithValue("@nombreTipoServ", ws.TipoServicio.Nombre)
      .AddWithValue("@codigoNivel", DBNull.Value)
      If ws.NivelAcademico IsNot Nothing Then
        .Item("@codigoNivel").Value = ws.NivelAcademico.Codigo
      End If
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

  Public Sub Actualizar(ByVal ws As Servicio)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aServicio", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigoServicio", ws.Codigo)
      .AddWithValue("@nombre", ws.Nombre)
      .AddWithValue("@codigoCtaContable", ws.CuentaContable.Codigo)
      .AddWithValue("@descripcion", ws.Descripcion)
      .AddWithValue("@entidad", ws.entidad)
      .AddWithValue("@vigencia", ws.vigencia)
      .AddWithValue("@Caduca", ws.Caduca)
      .AddWithValue("@PagoBanco", ws.PagoBanco)
      .AddWithValue("@monto", ws.Monto)
      .AddWithValue("@nombreTipoServ", ws.TipoServicio.Nombre)
      .AddWithValue("@codigoNivel", DBNull.Value)
      If ws.NivelAcademico IsNot Nothing Then
        .Item("@codigoNivel").Value = ws.NivelAcademico.Codigo
      End If
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

  Public Function ListarTipoServicio(ByVal tps As TipoServicio) As List(Of TipoServicio)
    Dim ld As New List(Of TipoServicio)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liTipoServicio", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@vigencia", tps.vigencia)
    End With
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        ld.Add(New TipoServicio(CInt(dr.Item("codigoTipoServ")), dr.Item("nombre").ToString, True))
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

    Return ld
  End Function

  Public Function ListarServicio(ByVal s As Servicio) As List(Of Servicio)
    Dim ld As New List(Of Servicio)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liServicio", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@nombre", s.Nombre)
      .AddWithValue("@entidad", s.entidad)
      .AddWithValue("@vigencia", s.vigencia)
    End With
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        ld.Add(New Servicio(CInt(dr.Item("codigoServicio")), dr.Item("nombre").ToString, CDbl(dr.Item("monto")), _
                            dr.Item("entidad").ToString, dr.Item("descripcion").ToString, CBool(dr.Item("vigencia")), _
                            New TipoServicio(CInt(dr.Item("codigoTipoServ")), dr.Item("nombreTipo").ToString, True), _
                            New CuentaContable(dr.Item("codigoCtaContable").ToString), Nothing) _
                            )
        If dr.IsDBNull(dr.GetOrdinal("codigoNivel")) = False Then
          ld.Item(ld.Count - 1).NivelAcademico = New Nivel(CInt(dr.Item("codigoNivel")), dr.Item("nombreNivel").ToString, "")
        End If
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

    Return ld
  End Function

  Public Function ListarServicioTodo() As List(Of Servicio)
    Dim ld As New List(Of Servicio)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liServicioTodoGeneral", cn)
    Dim dr As SqlDataReader = Nothing
    cmd.CommandType = CommandType.StoredProcedure

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        ld.Add(New Servicio(CInt(dr.Item("codigoServicio")), dr.Item("nombre").ToString.Trim, CDbl(dr.Item("monto")), _
                            dr.Item("entidad").ToString, dr.Item("descripcion").ToString, CBool(dr.Item("vigencia")), _
                            New TipoServicio(CInt(dr.Item("codigoTipoServ")), _
                                             dr.Item("nombreTipo").ToString, True), _
                            New CuentaContable(dr.Item("codigoCtaContable").ToString), _
                            Nothing) _
              )
        With ld.Item(ld.Count - 1)
          If dr.IsDBNull(dr.GetOrdinal("codigoNivel")) = False Then
            .NivelAcademico = New Nivel
            With .NivelAcademico
              .Codigo = CInt(dr.Item("codigoNivel"))
              .Nombre = dr.Item("nombreNivel").ToString
            End With
          End If
          .Caduca = CBool(dr.Item("Caduca"))
          .PagoBanco = CBool(dr.Item("PagoBanco"))
        End With
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
    Return ld
  End Function

  Public Sub AnularServicio(ByVal obj As Servicio)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_eServicio", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigoServicio", obj.Codigo)
      .AddWithValue("@vigencia", obj.vigencia)
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

  'Franklin Teran Santa Cruz
  '2011-01-03
  'Lista todos los servicios vigentes para la entidad solicitada
  Public Function ListarVigentes(ByVal wEntidad As String) As List(Of Servicio)
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim servicios As List(Of Servicio) = Nothing
    Dim iCodigo, iNombre As Integer

    pars.Add(New CParametro("@Entidad", wEntidad))
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liServiciosVigentes", pars)
      iCodigo = dr.GetOrdinal("CodigoServicio")
      iNombre = dr.GetOrdinal("Nombre")

      servicios = New List(Of Servicio)

      While dr.Read
        servicios.Add(New Servicio)
        With servicios.Item(servicios.Count - 1)
          .Codigo = dr.GetInt16(iCodigo)
          .Nombre = dr.GetString(iNombre)
        End With
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      dr = Nothing
    End Try

    Return servicios
  End Function


End Class

