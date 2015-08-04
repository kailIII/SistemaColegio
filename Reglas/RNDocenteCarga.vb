Public Class RNDocenteCarga
  Inherits CADO

  Public Function Registrar(ByVal obj As DocenteCarga) As Integer
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim tr As SqlTransaction = Nothing
    Dim cmdCarga As SqlCommand = Nothing
    Dim cmd As New SqlCommand("pr_iCargaPeriodo", cn)
    Dim cod As Integer

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoDocCarga", 0).Direction = ParameterDirection.Output
      .AddWithValue("@CodigoDoc", obj.Docente.Codigo)
      .AddWithValue("@CodigoCarga", obj.Carga.Codigo)
      .AddWithValue("@CodigoPer", obj.Periodo.Codigo)
      .AddWithValue("@Nombre", obj.Nombre)
    End With
    If obj.Carga.Codigo = 0 Then
      cmdCarga = New SqlCommand("pr_iCargaAcademica", cn)
      cmdCarga.CommandType = CommandType.StoredProcedure
      With cmdCarga.Parameters
        .AddWithValue("@CodigoCarga", 0).Direction = ParameterDirection.Output
        .AddWithValue("@CodigoCur", obj.Carga.Curso.Codigo)
        .AddWithValue("@CodigoG", obj.Carga.Seccion.Grado.Codigo)
        .AddWithValue("@Anio", obj.Carga.Seccion.Anio.Anio)
        .AddWithValue("@Letra", obj.Carga.Seccion.Letra)
      End With
    End If
    Try
      cn.Open()
      tr = cn.BeginTransaction()
      If obj.Carga.Codigo = 0 Then
        cmdCarga.Transaction = tr
        cmdCarga.ExecuteNonQuery()
        cmd.Parameters.Item("@CodigoCarga").Value = cmdCarga.Parameters.Item("@CodigoCarga").Value
        obj.Carga.Codigo = CInt(cmd.Parameters.Item("@CodigoCarga").Value)
      End If
      cmd.Transaction = tr
      cmd.ExecuteNonQuery()
      cod = CInt(cmd.Parameters("@CodigoDocCarga").Value)
      obj.Codigo = cod

      tr.Commit()
      cn.Close()
    Catch ex As Exception
      tr.Rollback()
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
    Return cod
  End Function

  Public Sub Actualizar(ByVal obj As DocenteCarga)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aDocenteCarga", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoDocente", obj.Docente.Codigo)
      .AddWithValue("@CodigoDocCarga", obj.Codigo)
      .AddWithValue("@Nombre", obj.Nombre)
      .AddWithValue("@CodigoPer", obj.Periodo.Codigo)
      .AddWithValue("@CodigoCarga", obj.Carga.Codigo)
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

  Public Sub Actualizar01(ByVal obj As DocenteCarga)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aDocenteCarga01", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoDocente", obj.Docente.Codigo)
      .AddWithValue("@Nombre", obj.Nombre)
      .AddWithValue("@CodigoPer", obj.Periodo.Codigo)
      .AddWithValue("@CodigoCarga", obj.Carga.Codigo)
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

  Public Sub Actualizar2(ByVal obj As DocenteCarga, ByVal nombre As String, ByVal objPer As PeriodoAcademico)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aDocenteCarga2", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoDocente", obj.Docente.Codigo)
      .AddWithValue("@CodigoDocenteCarga", obj.Codigo)
      .AddWithValue("@NuevoNombre", obj.Nombre)
      .AddWithValue("@Nombre", nombre)
      .AddWithValue("@CodigoPer", obj.Periodo.Codigo)
      .AddWithValue("@CodPerNuevo", objPer.Codigo)
      .AddWithValue("@CodigoCarga", obj.Carga.Codigo)
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

  Public Function CodigosDocenteCarga(ByVal obj As Grupo) As List(Of DocenteCarga)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lCodigoGrupo", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lm As List(Of DocenteCarga) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@NroMatricula", obj.Matricula.Numero)
      .AddWithValue("@CodigoCur", obj.DocenteCarga.Carga.Curso.Codigo)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lm = New List(Of DocenteCarga)
      Do While dr.Read
        lm.Add(New DocenteCarga(CInt(dr.Item("codigoDocenteCarga")), _
              dr.Item("nombre").ToString, Nothing, Nothing, _
              New PeriodoAcademico(Nothing, CBool(dr.Item("cerrado")))))
      Loop
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
    Return lm

  End Function

  Public Function CodigosDocenteCargaAlumno(ByVal obj As Grupo) As List(Of DocenteCarga)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liDocCargas", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lm As List(Of DocenteCarga) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoCarga", obj.DocenteCarga.Carga.Codigo)
      .AddWithValue("@NroMat", obj.Matricula.Numero)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lm = New List(Of DocenteCarga)
      Do While dr.Read
        lm.Add(New DocenteCarga(CInt(dr.Item("codigoDocenteCarga")), "", New Docente(), New CargaAcademica(), New PeriodoAcademico()))
      Loop
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
    Return lm

  End Function

  Public Function CodDocCarNombreGrupo(ByVal obj As DocenteCarga) As List(Of DocenteCarga)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lCodigoDocenteCarga", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lm As List(Of DocenteCarga) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Nombre", obj.Nombre)
      .AddWithValue("@CodigoCarga", obj.Carga.Codigo)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lm = New List(Of DocenteCarga)
      Do While dr.Read
        lm.Add(New DocenteCarga(CInt(dr.Item("codigoDocenteCarga")), "", Nothing _
                    , Nothing, New PeriodoAcademico(0, CBool(dr.Item("cerrado")))))
      Loop
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
    Return lm

  End Function

  Public Function ListarCargaSeccion(ByVal wobj As PeriodoAcademico, ByVal wdoc As Docente) As List(Of DocenteCarga)
    Dim lc As New List(Of DocenteCarga)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liDocCargaSeccion", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoPeriodo", wobj.Codigo)
    cmd.Parameters.AddWithValue("@codigoDocente", wdoc.Codigo)
    cmd.Parameters.AddWithValue("@anio", wobj.Anio)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        Dim c As New Curso(CInt(dr.Item("codigoCur")), dr.Item("nombreCur").ToString, 0, Nothing, Nothing, _
                           CBool(dr.Item("grupo")), CBool(dr.Item("rotativo")), Nothing)
        Dim s As New Seccion(CInt(dr.Item("codigoG")), CInt(dr.Item("numero")), Nothing, dr.Item("Siglas").ToString, _
                          CChar(dr.Item("letra")))
        Dim ca As New CargaAcademica(CInt(dr.Item("codigoCargaAcad")), c, s)

        lc.Add(New DocenteCarga(CInt(dr.Item("codigoDocenteCarga")), dr.Item("nombre").ToString, Nothing, _
               ca, New PeriodoAcademico(CInt(dr.Item("codigoPeriodo")))))

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

    Return lc
  End Function

  Public Function ListarCargaSeccion2(ByVal wPeriodo As PeriodoAcademico, ByVal wDocente As Docente) As List(Of DocenteCarga)
    Dim lc As New List(Of DocenteCarga)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liDocCargaSeccion2", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoPeriodo", wPeriodo.Codigo)
    cmd.Parameters.AddWithValue("@codigoDocente", wDocente.Codigo)
    cmd.Parameters.AddWithValue("@anio", wPeriodo.Anio)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        Dim curso As New Curso(CInt(dr.Item("codigoCur")), dr.Item("nombreCur").ToString, 0, Nothing)
        Dim seccion As New Seccion(CInt(dr.Item("codigoG")), CInt(dr.Item("numero")), Nothing, dr.Item("Siglas").ToString, CChar(dr.Item("letra")))
        Dim CargaAcad As New CargaAcademica(CInt(dr.Item("codigoCargaAcad")), curso, seccion)

        seccion.Anio = wPeriodo.AnioLectivo

        lc.Add(New DocenteCarga(CInt(dr.Item("codigoDocenteCarga")), dr.Item("nombre").ToString, wDocente, CargaAcad, wPeriodo))
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

    Return lc
  End Function

  Public Function ListarCodDocenteCarga(ByVal obj As DocenteCarga) As List(Of DocenteCarga)
    Dim lc As List(Of DocenteCarga) = Nothing
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liTodasSecciones", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoDoc", obj.Docente.Codigo)
      .AddWithValue("@CodigoPer", obj.Periodo.Codigo)
      .AddWithValue("@CodigoCur", obj.Carga.Curso.Codigo)
      .AddWithValue("@CodigoGra", obj.Carga.Seccion.Grado.Codigo)
      .AddWithValue("@Nombre", obj.Nombre)
      .AddWithValue("@Anio", obj.Carga.Seccion.Anio.Anio)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lc = New List(Of DocenteCarga)
      While dr.Read
        lc.Add(New DocenteCarga(CInt(dr.Item("codigoDocenteCarga"))))
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
    Return lc
  End Function

  Public Function CodigosDocenteCarga(ByVal obj As DocenteCarga) As List(Of DocenteCarga)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liDocenteCarga", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lc As List(Of DocenteCarga) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoCarga", obj.Carga.Codigo)
      .AddWithValue("@Nombre", obj.Nombre)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lc = New List(Of DocenteCarga)
      While dr.Read
        lc.Add(New DocenteCarga(CInt(dr.Item("codigoDocenteCarga"))))
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
    Return lc
  End Function

  Public Function ListarDocenteCargaIndicadores(ByVal obj As DocenteCarga) As List(Of DocenteCarga)
    Dim lc As List(Of DocenteCarga) = Nothing
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liTodasSeccionesInd", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoDoc", obj.Docente.Codigo)
      .AddWithValue("@CodigoPer", obj.Periodo.Codigo)
      .AddWithValue("@CodigoCur", obj.Carga.Curso.Codigo)
      .AddWithValue("@CodigoGra", obj.Carga.Seccion.Grado.Codigo)
      .AddWithValue("@Anio", obj.Carga.Seccion.Anio.Anio)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lc = New List(Of DocenteCarga)
      While dr.Read
        lc.Add(New DocenteCarga(CInt(dr.Item("codigoDocenteCarga"))))
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
    Return lc
  End Function

  Public Function ListarCargaConsolidado(ByVal obj As Seccion, ByVal wperiodo As PeriodoAcademico) As List(Of DocenteCarga)
    Dim lc As List(Of DocenteCarga) = Nothing
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("liCursoConsolidado", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigoG", obj.Grado.Codigo)
      .AddWithValue("@letra", obj.Letra)
      .AddWithValue("@anio", wperiodo.Anio)
      .AddWithValue("@codigoPeriodo", wperiodo.Codigo)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lc = New List(Of DocenteCarga)
      While dr.Read
        lc.Add(New DocenteCarga(CInt(dr.Item("codigoDocenteCarga")), New CargaAcademica(CInt(dr.Item("codigoCur")), _
                                dr.Item("nombrecur").ToString), wperiodo, dr.Item("nombre").ToString))
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
    Return lc
  End Function

  'rebb

  Public Function ListarCargaSeccionUnica(ByVal wobj As DocenteCarga) As List(Of DocenteCarga)
    Dim lc As New List(Of DocenteCarga)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liDocCargaSeccionUnico", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@codigoDocenteCarga", wobj.Codigo)

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        Dim c As New Curso(CInt(dr.Item("codigoCur")), dr.Item("nombreCur").ToString, 0, Nothing, Nothing, _
                           CBool(dr.Item("grupo")), CBool(dr.Item("rotativo")), Nothing)
        Dim s As New Seccion(CInt(dr.Item("codigoG")), CInt(dr.Item("numero")), Nothing, dr.Item("Siglas").ToString, _
                          CChar(dr.Item("letra")))
        Dim ca As New CargaAcademica(CInt(dr.Item("codigoCargaAcad")), c, s)

        lc.Add(New DocenteCarga(CInt(dr.Item("codigoDocenteCarga")), dr.Item("nombre").ToString, Nothing, _
               ca, New PeriodoAcademico(CInt(dr.Item("codigoPeriodo")))))

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
    Return lc
  End Function

  Public Function ListarCursoDocente(ByVal obj As DocenteCarga) As List(Of DocenteCarga)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liCurSec", cn)
    Dim ldc As List(Of DocenteCarga) = Nothing
    Dim dr As SqlDataReader = Nothing

    If obj.Carga.Seccion.Grado.Codigo > 0 Then
      cmd.CommandType = CommandType.StoredProcedure

      With cmd.Parameters
        .AddWithValue("@Anio", obj.Carga.Seccion.Anio.Anio)
        .AddWithValue("@CodigoPer", obj.Periodo.Codigo)
        .AddWithValue("@codigoG", obj.Carga.Seccion.Grado.Codigo)
        .AddWithValue("@letra", CChar(obj.Carga.Letra))
      End With
      Try
        cn.Open()
        dr = cmd.ExecuteReader
        ldc = New List(Of DocenteCarga)

        Do While dr.Read
          ldc.Add(New DocenteCarga(CInt(dr.Item("codigoDocenteCarga")), "", New Docente(CInt(dr.Item("codigoDocente")), dr.Item("nombre").ToString _
                                          , dr.Item("apellidoPat").ToString, dr.Item("apellidoMat").ToString), _
                  New CargaAcademica(0, New Curso(CInt(dr.Item("codigoCur")), dr.Item("nombreCur").ToString, 0, New AreaDRE()), _
                  New Seccion(0, "", CChar(dr.Item("letra")))), New PeriodoAcademico()))
        Loop
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
    End If

    Return ldc
  End Function

  Public Function ListarCursoDocente2(ByVal obj As DocenteCarga) As List(Of DocenteCarga)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liCurSec2", cn)
    Dim ldc As List(Of DocenteCarga) = Nothing
    Dim dr As SqlDataReader = Nothing

    If obj.Carga.Seccion.Grado.Codigo > 0 Then
      cmd.CommandType = CommandType.StoredProcedure

      With cmd.Parameters
        .AddWithValue("@Anio", obj.Carga.Seccion.Anio.Anio)
        .AddWithValue("@CodigoPer", obj.Periodo.Codigo)
        .AddWithValue("@codigoG", obj.Carga.Seccion.Grado.Codigo)
      End With

      Try
        cn.Open()
        dr = cmd.ExecuteReader
        ldc = New List(Of DocenteCarga)

        Do While dr.Read
          ldc.Add(New DocenteCarga(CInt(dr.Item("codigoDocenteCarga")), "", New Docente(CInt(dr.Item("codigoDocente")), dr.Item("nombre").ToString _
                                          , dr.Item("apellidoPat").ToString, dr.Item("apellidoMat").ToString), _
                  New CargaAcademica(0, New Curso(CInt(dr.Item("codigoCur")), dr.Item("nombreCur").ToString, 0, New AreaDRE()), _
                  New Seccion(0, "", CChar(dr.Item("letra")))), New PeriodoAcademico()))
        Loop
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
    End If
    Return ldc
  End Function

  Public Function VerificarAlumnoGrupo(ByVal obj As DocenteCarga, ByVal Nromat As Integer) As Integer
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_VerificarAlumGrupo", cn)
    Dim dr As Integer

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@NroMatricula", Nromat)
    cmd.Parameters.AddWithValue("@codigoPeriodo", obj.Periodo.Codigo)
    cmd.Parameters.AddWithValue("@CodigoDocentecarga ", obj.Codigo)
    Try
      cn.Open()
      dr = CInt(cmd.ExecuteScalar)
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
    Return dr
  End Function

  Public Function ListarCursosArea1(ByVal obj As DocenteCarga) As List(Of DocenteCarga)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liCursoXAreas", cn)
    Dim ldc As List(Of DocenteCarga) = Nothing
    Dim dr As SqlDataReader = Nothing

    If obj.Carga.Seccion.Grado.Codigo > 0 Then
      cmd.CommandType = CommandType.StoredProcedure

      With cmd.Parameters
        .AddWithValue("@CodArea", obj.Carga.Curso.CodigoAreaDre.Codigo)
        .AddWithValue("@CodigoG", obj.Carga.Seccion.Grado.Codigo)
        .AddWithValue("@CodPer", obj.Periodo.Codigo)
        .AddWithValue("@Letra", obj.Carga.Letra)
        .AddWithValue("@Anio", obj.Carga.Seccion.Anio.Anio)
      End With

      Try
        cn.Open()
        dr = cmd.ExecuteReader
        ldc = New List(Of DocenteCarga)

        Do While dr.Read
          ldc.Add(New DocenteCarga(CInt(dr.Item("codigoDocenteCarga")), dr.Item("nombre").ToString, _
                  New Docente(), _
                  New CargaAcademica(0, New Curso(CInt(dr.Item("codigoCur")), dr.Item("nombreCur").ToString, _
                      0, New AreaDRE(CInt(dr.Item("codigoAreaD")), dr.Item("nombreAreaD").ToString, New DRE(), New Nivel())), _
                  New Seccion(0, "", CChar(dr.Item("letra")))), New PeriodoAcademico()))
        Loop
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
    End If
    Return ldc
  End Function

  Public Function ListarCursosArea2(ByVal obj As DocenteCarga) As List(Of DocenteCarga)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liCursoXAreas2", cn)
    Dim ldc As List(Of DocenteCarga) = Nothing
    Dim dr As SqlDataReader = Nothing

    If obj.Carga.Seccion.Grado.Codigo > 0 Then
      cmd.CommandType = CommandType.StoredProcedure

      With cmd.Parameters
        .AddWithValue("@CodigoG", obj.Carga.Seccion.Grado.Codigo)
        .AddWithValue("@CodPer", obj.Periodo.Codigo)
        .AddWithValue("@Letra", obj.Carga.Letra)
        .AddWithValue("@Anio", obj.Carga.Seccion.Anio.Anio)
      End With

      Try
        cn.Open()
        dr = cmd.ExecuteReader
        ldc = New List(Of DocenteCarga)

        Do While dr.Read
          ldc.Add(New DocenteCarga(CInt(dr.Item("codigoDocenteCarga")), dr.Item("nombre").ToString, _
                  New Docente(), _
                  New CargaAcademica(0, New Curso(CInt(dr.Item("codigoCur")), dr.Item("nombreCur").ToString, _
                      0, New AreaDRE(CInt(dr.Item("codigoAreaD")), dr.Item("nombreAreaD").ToString, New DRE(), New Nivel())), _
                  New Seccion(0, "", CChar(dr.Item("letra")))), New PeriodoAcademico()))
        Loop
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
    End If
    Return ldc
  End Function

  Public Function ListarCursosArea3(ByVal obj As DocenteCarga) As List(Of DocenteCarga)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liCursoXAreas3", cn)
    Dim ldc As List(Of DocenteCarga) = Nothing
    Dim dr As SqlDataReader = Nothing

    If obj.Carga.Seccion.Grado.Codigo > 0 Then
      cmd.CommandType = CommandType.StoredProcedure

      With cmd.Parameters
        .AddWithValue("@CodigoG", obj.Carga.Seccion.Grado.Codigo)
        .AddWithValue("@CodPer", obj.Periodo.Codigo)
        .AddWithValue("@Anio", obj.Carga.Seccion.Anio.Anio)
      End With

      Try
        cn.Open()
        dr = cmd.ExecuteReader
        ldc = New List(Of DocenteCarga)

        Do While dr.Read
          ldc.Add(New DocenteCarga(CInt(dr.Item("codigoDocenteCarga")), dr.Item("nombre").ToString, _
                  New Docente(), _
                  New CargaAcademica(0, New Curso(CInt(dr.Item("codigoCur")), dr.Item("nombreCur").ToString, _
                      0, New AreaDRE(CInt(dr.Item("codigoAreaD")), dr.Item("nombreAreaD").ToString, New DRE(), New Nivel())), _
                  New Seccion(0, "", CChar(dr.Item("letra")))), New PeriodoAcademico()))
        Loop
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
    End If
    Return ldc
  End Function

  Public Function ListarCargasArea(ByVal obj As DocenteCarga, ByVal objA As AreaDRE) As List(Of DocenteCarga)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liCargasAreas", cn)
    Dim ldc As List(Of DocenteCarga) = Nothing
    Dim dr As SqlDataReader = Nothing

    If obj.Carga.Seccion.Grado.Codigo > 0 Then
      cmd.CommandType = CommandType.StoredProcedure

      With cmd.Parameters
        .AddWithValue("@CodArea", objA.Codigo)
        .AddWithValue("@CodigoG", obj.Carga.Seccion.Grado.Codigo)
        .AddWithValue("@CodPer", obj.Periodo.Codigo)
        .AddWithValue("@Letra", obj.Carga.Seccion.Letra)
      End With

      Try
        cn.Open()
        dr = cmd.ExecuteReader
        ldc = New List(Of DocenteCarga)

        Do While dr.Read
          ldc.Add(New DocenteCarga(CInt(dr.Item("codigoDocenteCarga")), "", _
                  New Docente(), _
                  New CargaAcademica(0, New Curso(0, dr.Item("nombreCur").ToString, _
                      0, Nothing), _
                  New Seccion(0, "", CChar(dr.Item("letra")))), New PeriodoAcademico()))
        Loop
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
    End If
    Return ldc
  End Function

  Public Function ListarCargaSeccionIndicadores(ByVal wobj As PeriodoAcademico, ByVal wdoc As Docente) As List(Of DocenteCarga)
    Dim lc As New List(Of DocenteCarga)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liDocCargaSeccionIndicadores", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoPeriodo", wobj.Codigo)

    cmd.Parameters.AddWithValue("@anio", wobj.Anio)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        Dim c As New Curso(CInt(dr.Item("codigoCur")), dr.Item("nombreCur").ToString, 0, Nothing, Nothing, _
                           CBool(dr.Item("grupo")), CBool(dr.Item("rotativo")), Nothing)
        Dim s As New Seccion(CInt(dr.Item("codigoG")), CInt(dr.Item("numero")), Nothing, dr.Item("Siglas").ToString, _
                          CChar(dr.Item("letra")))
        Dim ca As New CargaAcademica(CInt(dr.Item("codigoCargaAcad")), c, s)

        lc.Add(New DocenteCarga(CInt(dr.Item("codigoDocenteCarga")), dr.Item("nombre").ToString, Nothing, _
               ca, New PeriodoAcademico(CInt(dr.Item("codigoPeriodo")))))

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
    Return lc
  End Function

  Public Function ListarDocentes(ByVal wPeriodo As PeriodoAcademico, ByVal wSeccion As Seccion, ByVal wCurso As Curso) As DataTable
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liDocentesCursoPeriodo", cn)
    Dim da As New SqlDataAdapter(cmd)
    Dim dt As New DataTable

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Anio", wSeccion.Anio.Anio)
      .AddWithValue("@Grado", wSeccion.Grado.Codigo)
      .AddWithValue("@Letra", wSeccion.Letra)
      .AddWithValue("@Curso", wCurso.Codigo)
      .AddWithValue("@Periodo", wPeriodo.Codigo)
    End With

    Try
      da.Fill(dt)
    Catch ex As Exception
      Throw ex
    Finally
      cn = Nothing
      cmd = Nothing
      da = Nothing
    End Try

    Return dt
  End Function

  Public Function ListarNotasDocente(ByVal wDocenteCarga As DocenteCarga) As DataTable
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liNotasDocenteCarga", cn)
    Dim da As New SqlDataAdapter(cmd)
    Dim dt As New DataTable

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@DocenteCarga", wDocenteCarga.Codigo)
    End With

    Try
      da.Fill(dt)
    Catch ex As Exception
      Throw ex
    Finally
      cn = Nothing
      cmd = Nothing
      da = Nothing
    End Try

    Return dt
  End Function


  'Lista los docentes asignados a una carga academica
  Public Function ListarDocentesCarga(ByVal wCarga As CargaAcademica) As List(Of DocenteCarga)
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim cargasDocente As List(Of DocenteCarga) = Nothing
    Dim iCodigoDocenteCarga, iNombreDocenteCarga, iCodigoPeriodo, iCodigoDocente As Integer

    pars.AddRange(New CParametro() {New CParametro("@CodigoCarga", wCarga.Codigo)})
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liDocentesAsignados", pars)
      iCodigoDocenteCarga = dr.GetOrdinal("codigoDocenteCarga")
      iNombreDocenteCarga = dr.GetOrdinal("NombreDocenteCarga")
      iCodigoPeriodo = dr.GetOrdinal("CodigoPeriodo")
      iCodigoDocente = dr.GetOrdinal("CodigoDocente")
      cargasDocente = New List(Of DocenteCarga)
      While dr.Read
        cargasDocente.Add(New DocenteCarga With { _
              .Periodo = New PeriodoAcademico With {.Codigo = dr.GetInt16(iCodigoPeriodo)}, _
              .Carga = wCarga, _
              .Codigo = dr.GetInt16(iCodigoDocenteCarga), _
              .Nombre = dr.GetString(iNombreDocenteCarga), _
              .Docente = New Docente With {.Codigo = dr.GetInt32(iCodigoDocente)} _
              })
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      pars.Clear()
      pars = Nothing
    End Try

    Return cargasDocente
  End Function

  'Lista los alumnos de la sección indicando el numero de matricula de los que pertenecen al grupo
  Public Function ListarAlumnos(ByVal wDocenteCarga As DocenteCarga) As List(Of Grupo)
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim grupoAlumnos As List(Of Grupo) = Nothing
    Dim iMatricula, iApePat, iApeMat, iNombres, iSexo, iAsignado As Integer

    pars.AddRange(New CParametro() {New CParametro("@Anio", wDocenteCarga.Carga.Seccion.Anio.Anio), _
                                    New CParametro("@Grado", wDocenteCarga.Carga.Seccion.Grado.Codigo),
                                    New CParametro("@Letra", wDocenteCarga.Carga.Seccion.Letra),
                                    New CParametro("@CodigoDocenteCarga", wDocenteCarga.Codigo)})
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liAlumnosSeccionGrupo", pars)
      iMatricula = dr.GetOrdinal("nroMatricula")
      iApePat = dr.GetOrdinal("apellidoPat")
      iApeMat = dr.GetOrdinal("apellidoMat")
      iNombres = dr.GetOrdinal("nombre")
      iSexo = dr.GetOrdinal("sexo")
      iAsignado = dr.GetOrdinal("Asignado")
      grupoAlumnos = New List(Of Grupo)
      While dr.Read
        grupoAlumnos.Add(New Grupo With {.Matricula = New Matricula With {
                                                                          .Numero = dr.GetInt16(iMatricula),
                                                                          .Alumno = New Alumno With {
                                                                                                    .Nombre = dr.GetString(iNombres),
                                                                                                     .ApellidoPaterno = dr.GetString(iApePat),
                                                                                                     .ApellidoMaterno = dr.GetString(iApeMat),
                                                                                                     .Sexo = dr.GetString(iSexo)}},
                                        .DocenteCarga = wDocenteCarga,
                                        .Asignado = dr.GetBoolean(iAsignado)})
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      pars.Clear()
      pars = Nothing
    End Try

    Return grupoAlumnos
  End Function

  'Registra los alumnos indicados en el grupo para el docente que se solicita
  Public Sub RegistrarAlumnos(ByVal wAlumnos As List(Of Grupo))
    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@Matricula", 0),
                                    New CParametro("@DocenteCarga", 0),
                                    New CParametro("@Asignado", False)})
    Try
      Me.Conectar(True)
      For Each gr As Grupo In wAlumnos
        pars.Item(0).Valor = gr.Matricula.Numero
        pars.Item(1).Valor = gr.DocenteCarga.Codigo
        pars.Item(2).Valor = gr.Asignado
        Me.EjecutarOrden("pr_iGrupo", pars)
      Next
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      pars.Clear()
      pars = Nothing
    End Try
  End Sub

  Public Function RegistrarDocenteCarga(ByVal doc As DocenteCarga) As Integer
    Dim parsCarga As New List(Of CParametro)
    Dim parsAlumno As New List(Of CParametro)

    parsCarga.AddRange(New CParametro() {New CParametro("@CodigoDocCarga", 0),
                                    New CParametro("@CodigoDoc", doc.Docente.Codigo),
                                    New CParametro("@CodigoCarga", doc.Carga.Codigo),
                                    New CParametro("@CodigoPer", doc.Periodo.Codigo),
                                    New CParametro("@Nombre", doc.Nombre)})
    parsCarga.Item(0).Direccion = CParametro.DireccionParametro.SALIDA
    parsAlumno.AddRange(New CParametro() {New CParametro("@Matricula", 0),
                                    New CParametro("@DocenteCarga", 0),
                                    New CParametro("@Asignado", False)})

    Try
      Me.Conectar(True)
      Me.EjecutarOrden("pr_iCargaPeriodo", parsCarga)
      parsAlumno.Item(1).Valor = parsCarga.Item(0).Valor
      For Each gr As Grupo In doc.Alumnos
        parsAlumno.Item(0).Valor = gr.Matricula.Numero
        parsAlumno.Item(2).Valor = gr.Asignado
        Me.EjecutarOrden("pr_iGrupo", parsAlumno)
      Next

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      parsCarga.Clear()
      parsCarga = Nothing
    End Try

    Return CInt(parsCarga.Item(0).Valor)
  End Function

End Class
