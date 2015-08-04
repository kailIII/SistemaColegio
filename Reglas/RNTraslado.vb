
Public Class RNTraslado

  Public Function DatosAlumno(ByVal objSec As Seccion) As List(Of Traslado)
    Dim lt As New List(Of Traslado)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lDatosAlumno2", cn)
    Dim dr As SqlDataReader = Nothing
    Dim fecha As DateTime
    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoNivel", objSec.Grado.Nivel.Codigo)
    cmd.Parameters.AddWithValue("@Numero", objSec.Grado.Numero)
    cmd.Parameters.AddWithValue("@Letra", objSec.Letra)
    cmd.Parameters.AddWithValue("@Anio", objSec.Anio.Anio)

    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        lt.Add(New Traslado(dr.Item("codModularIE").ToString, dr.Item("nombreIE").ToString, New Matricula(0, fecha, New Grado(), New Personal(), _
                             New Alumno(New UbicacionGeografica("", "", "", dr.Item("pais").ToString), _
                                    CInt(dr.Item("codigoAlumno")), _
                                    dr.Item("codigoEducando").ToString, dr.Item("nombre").ToString, dr.Item("apellidoPat").ToString, _
                                    dr.Item("apellidoMat").ToString, CDate(dr.Item("fechaNac")), dr.Item("sexo").ToString, _
                                    dr.Item("lenguaMaterna").ToString, New Apoderado(0, dr.Item("Padre_Vive").ToString, ""), _
                                    New Apoderado(0, dr.Item("Madre_Vive").ToString, dr.Item("GradoInst").ToString)), _
                                    New AnioLectivo(), "", 0, 0, CInt(dr.Item("nroOrden")), 0, False, dr.Item("sexo").ToString, dr.Item("situacionFinal").ToString)))
        With lt.Item(lt.Count - 1).OMatricula
          .TipoMatricula = dr.Item("tipoMatricula").ToString
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

    Return lt
  End Function

  Public Sub Registrar(ByVal obj As Traslado)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iTraslado", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@NroMat", obj.OMatricula.Numero)
      .AddWithValue("@Motivo", obj.Motivo)
      .AddWithValue("@CodMod", obj.CodigoModularInst)
      .AddWithValue("@NombreIE", obj.NombreInst)
      .AddWithValue("@Descripcion", obj.DescripcionPeriodo)
      .AddWithValue("@Fecha", obj.FechaTras)
      .AddWithValue("@Tipo", obj.Tipo)
      .AddWithValue("@Resolucion", obj.NroResolucion)
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

  Public Sub Actualizar(ByVal obj As Traslado)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aTraslado", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Codigo", obj.Codigo)
      .AddWithValue("@NroMat", obj.OMatricula.Numero)
      .AddWithValue("@Motivo", obj.Motivo)
      .AddWithValue("@CodMod", obj.CodigoModularInst)
      .AddWithValue("@NombreIE", obj.NombreInst)
      .AddWithValue("@Descripcion", obj.DescripcionPeriodo)
      .AddWithValue("@Fecha", obj.FechaTras)
      .AddWithValue("@Tipo", obj.Tipo)
      .AddWithValue("@Resolucion", obj.NroResolucion)
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

  Public Function ListarTraslados(ByVal obj As AnioLectivo) As List(Of Traslado)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liTraslado", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lt As New List(Of Traslado)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Anio", obj.Anio)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        lt.Add(New Traslado(CInt(dr.Item("codigoTras")), dr.Item("codModularIE").ToString, _
                   dr.Item("nombreIE").ToString, dr.Item("motivo").ToString, dr.Item("descripPeriodo").ToString, _
                    CDate(dr.Item("fechaTras")), CStr(dr.Item("tipo")), dr.Item("nroResolucion").ToString, _
                     New Matricula(CInt(dr.Item("nroMatricula")), Nothing, New Grado(0, CInt(dr.Item("numero")), _
                     Nothing, New Nivel(Nothing, Nothing, dr.Item("siglas").ToString), Nothing, Nothing), New Alumno(0, _
                     dr.Item("nombre").ToString, dr.Item("apellidoPat").ToString, _
                     dr.Item("apellidoMat").ToString), Nothing, dr.Item("letra").ToString, Nothing, _
                     Nothing)))
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
    Return lt
  End Function

End Class