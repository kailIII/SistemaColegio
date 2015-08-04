
Public Class RNAnioLectivo
  Inherits CADO

  Public Sub Registrar(ByVal objAnio As AnioLectivo, ByVal wListaPer As List(Of PeriodoAcademico))
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmdAnio As New SqlCommand("pr_iAnioLectivo", cn)
    Dim cmdPer As New SqlCommand("pr_iPeriodo_Acad", cn)
    Dim trx As SqlTransaction = Nothing
    Dim objInst As New RNAnioLectivo

    '-----------------------------REGISTRO DE ANIO---------------------------------
    Try
      cn.Open()
      trx = cn.BeginTransaction

      cmdAnio.Transaction = trx
      cmdAnio.CommandType = CommandType.StoredProcedure
      With (cmdAnio.Parameters)
        .AddWithValue("@codigoInst", objAnio.CodigoInstitucion)
        .AddWithValue("@fechaI", objAnio.FechaI)
        .AddWithValue("@fechaF", objAnio.fechaF)
        .AddWithValue("@anio", objAnio.Anio)
        .AddWithValue("@descripcion", objAnio.descripcion)
        .AddWithValue("@vigencia", objAnio.vigencia)
      End With
      cmdAnio.ExecuteNonQuery()

      '-----------------------------REGISTRO DE PERIODO---------------------------------
      cmdPer.Transaction = trx
      cmdPer.CommandType = CommandType.StoredProcedure
      With cmdPer.Parameters
        .AddWithValue("@fechaIni", DateAndTime.Now)
        .AddWithValue("@fechaFin", DateAndTime.Now)
        .AddWithValue("@vigencia", True)
        .AddWithValue("@anio", "")
        .AddWithValue("@nombre", "")
        .AddWithValue("@siglas", "")
      End With

      For Each objPeriodo As PeriodoAcademico In wListaPer
        With cmdPer.Parameters
          .Item("@fechaIni").Value = objPeriodo.fechaIni
          .Item("@fechaFin").Value = objPeriodo.fechaFin
          .Item("@vigencia").Value = objPeriodo.vigencia
          .Item("@anio").Value = objPeriodo.Anio
          .Item("@nombre").Value = objPeriodo.Nombre
          .Item("@siglas").Value = objPeriodo.Siglas
        End With
        cmdPer.ExecuteNonQuery()
      Next
      trx.Commit()
    Catch ex As Exception
      If trx IsNot Nothing Then
        trx.Rollback()
      End If
      Throw ex
    Finally
      cmdPer.Dispose()
      cmdPer = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
  End Sub

  Public Sub RegistrarAnio(ByVal objAnio As AnioLectivo)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmdAnio As New SqlCommand("pr_iAnioLectivo", cn)
    Dim trx As SqlTransaction = Nothing
    Dim objInst As New RNAnioLectivo

    '-----------------------------REGISTRO DE ANIO---------------------------------
    Try
      cn.Open()
      trx = cn.BeginTransaction

      cmdAnio.Transaction = trx
      cmdAnio.CommandType = CommandType.StoredProcedure
      With (cmdAnio.Parameters)
        .AddWithValue("@codigoInst", objAnio.CodigoInstitucion)
        .AddWithValue("@fechaI", objAnio.FechaI)
        .AddWithValue("@fechaF", objAnio.fechaF)
        .AddWithValue("@anio", objAnio.Anio)
        .AddWithValue("@descripcion", objAnio.descripcion)
        .AddWithValue("@vigencia", objAnio.vigencia)
      End With
      cmdAnio.ExecuteNonQuery()

      trx.Commit()
    Catch ex As Exception
      If trx IsNot Nothing Then
        trx.Rollback()
      End If
      Throw ex
    Finally
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
  End Sub

  Public Function RetornaCodigoInst() As Integer
    Dim cnR As New SqlConnection(My.Settings.Conexion)
    Dim cmdR As New SqlCommand("pr_lCodigo_Inst", cnR)

    cmdR.CommandType = CommandType.StoredProcedure
    Try
      cnR.Open()
      Return CInt(cmdR.ExecuteScalar())
    Catch ex As Exception
      Throw ex
    Finally
      cmdR.Dispose()
      cmdR = Nothing
      If cnR.State = ConnectionState.Open Then
        cnR.Close()
      End If
      cnR.Dispose()
      cnR = Nothing
    End Try
  End Function

  Public Function Leer(ByVal wA As AnioLectivo) As List(Of AnioLectivo)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lAnioLectivo", cn)
    Dim dr As SqlDataReader = Nothing
    Dim Al As AnioLectivo = Nothing
    Dim List As List(Of AnioLectivo) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@vigencia", wA.vigencia)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      List = New List(Of AnioLectivo)
      Do While (dr.Read)
        List.Add(New AnioLectivo(CStr(dr.Item("anio"))))
      Loop
    Catch ex As Exception
      If List IsNot Nothing Then
        List.Clear()
      End If
      Al = Nothing
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

    Return List
  End Function

  Public Function Listar() As List(Of AnioLectivo)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAnios", cn)
    Dim dr As SqlDataReader = Nothing
    Dim List As List(Of AnioLectivo) = Nothing

    cmd.CommandType = CommandType.StoredProcedure

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      List = New List(Of AnioLectivo)
      Do While (dr.Read)
        List.Add(New AnioLectivo(dr.Item("anio").ToString, CDate(dr.Item("fechaI")), CDate(dr.Item("fechaF")), False, ""))
      Loop
    Catch ex As Exception
      If List IsNot Nothing Then
        List.Clear()
      End If
      'Al = Nothing
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

    Return List
  End Function

  Public Function LeerAnioLectivo(ByVal obj As AnioLectivo) As AnioLectivo
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lPeriodoLectivo", cn)
    Dim dr As SqlDataReader = Nothing
    Dim a As AnioLectivo = Nothing


    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Anio", obj.Anio)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      If dr.Read = True Then
        a = New AnioLectivo("", CDate(dr.Item("FechaI")), CDate(dr.Item("FechaF")), CBool(dr.Item("vigencia")), "")
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

    Return a
  End Function

  Public Function MostrarPeriodo(ByVal obj As Integer) As PeriodoAcademico

    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lPeriodo", cn)
    Dim dr As SqlDataReader = Nothing
    Dim P As PeriodoAcademico = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@codigoPeriodo", obj)

    Try
      cn.Open()
      dr = cmd.ExecuteReader

      If dr.Read = True Then
        P = New PeriodoAcademico(Nothing, Nothing, Nothing, Nothing, dr.Item("anio").ToString, dr.Item("nombre").ToString, dr.Item("siglas").ToString)
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
    Return P
  End Function

  'Lista todos los AnioLectivo correspondientes a una institución
  Public Function Listar(ByVal wIns As Institucion) As List(Of AnioLectivo)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAnios_Institucion", cn)
    Dim dr As SqlDataReader = Nothing
    Dim List As List(Of AnioLectivo) = Nothing

    cmd.Parameters.AddWithValue("@codigoInst", wIns.CodigoInst)
    cmd.CommandType = CommandType.StoredProcedure
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      List = New List(Of AnioLectivo)
      Do While (dr.Read)
        List.Add(New AnioLectivo(dr.Item("anio").ToString, CDate(dr.Item("fechaI")), CDate(dr.Item("fechaF")), False, ""))
      Loop
    Catch ex As Exception
      If List IsNot Nothing Then
        List.Clear()
      End If
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

    Return List
  End Function

  'Lista todos los PeriodoAcademico correspondientes a un AnioLectivo
  Public Function ListarPeriodos(ByVal wAnio As AnioLectivo) As List(Of PeriodoAcademico)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liPeriodos_Anio", cn)
    Dim dr As SqlDataReader = Nothing
    Dim List As List(Of PeriodoAcademico) = Nothing

    cmd.Parameters.AddWithValue("@Anio", wAnio.Anio)
    cmd.CommandType = CommandType.StoredProcedure
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      List = New List(Of PeriodoAcademico)
      Do While (dr.Read)
        List.Add(New PeriodoAcademico(dr.GetInt16(dr.GetOrdinal("codigoPeriodo")), New Date, New Date, True, _
                            wAnio.Anio, dr.GetString(dr.GetOrdinal("Nombre")), _
                            dr.GetString(dr.GetOrdinal("Siglas")), _
                            dr.GetBoolean(dr.GetOrdinal("cerrado"))))
      Loop
    Catch ex As Exception
      If List IsNot Nothing Then
        List.Clear()
      End If
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

    Return List
  End Function

  Public Function VerificarAnios() As Integer
    Dim cnR As New SqlConnection(My.Settings.Conexion)
    Dim cmdR As New SqlCommand("pr_lNro_Anios", cnR)

    cmdR.CommandType = CommandType.StoredProcedure
    Try
      cnR.Open()
      Return CInt(cmdR.ExecuteScalar())
    Catch ex As Exception
      Throw ex
    Finally
      cmdR.Dispose()
      cmdR = Nothing
      If cnR.State = ConnectionState.Open Then
        cnR.Close()
      End If
      cnR.Dispose()
      cnR = Nothing
    End Try
  End Function

  Public Sub EliminarAnio(ByVal obj As AnioLectivo)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_eAnio", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Anio", obj.Anio)
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

  Public Function ListarSecciones(ByVal wAnio As AnioLectivo) As List(Of Seccion)
    Dim ls As List(Of Seccion) = Nothing
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liTodasSeccionesAnio", cn)
    Dim dr As SqlDataReader = Nothing
    Dim List As List(Of PeriodoAcademico) = Nothing
    Dim iCod As Integer, iLetra As Integer, iNiv As Integer

    cmd.Parameters.AddWithValue("@Anio", wAnio.Anio)
    cmd.CommandType = CommandType.StoredProcedure
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      iCod = dr.GetOrdinal("codigoG")
      iLetra = dr.GetOrdinal("Letra")
      iNiv = dr.GetOrdinal("codigoNivel")
      ls = New List(Of Seccion)
      Do While (dr.Read)
        ls.Add(New Seccion(wAnio, New Grado(dr.GetInt16(iCod), dr.GetInt16(iNiv), "", 0), dr.GetString(iLetra)) _
               )
      Loop
    Catch ex As Exception
      If ls IsNot Nothing Then
        ls.Clear()
      End If
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

    Return ls
  End Function

  Public Sub ImportarAnio(ByVal wAnio As AnioLectivo, ByVal wAnioNuevo As AnioLectivo)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmdAnio As New SqlCommand("pr_iImportarAnio", cn)

    Try
      cn.Open()

      cmdAnio.CommandType = CommandType.StoredProcedure
      With (cmdAnio.Parameters)
        .AddWithValue("@Anio", wAnio.Anio)
        .AddWithValue("@AnioNuevo", wAnioNuevo.Anio)
      End With
      cmdAnio.ExecuteNonQuery()
    Catch ex As Exception
      Throw ex
    Finally
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
  End Sub

  'Lista todos los periodos activos, abiertos o cerrados
  Public Function ListarActivos(ByVal wIns As Institucion) As List(Of AnioLectivo)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAniosActivos_Institucion", cn)
    Dim dr As SqlDataReader = Nothing
    Dim List As List(Of AnioLectivo) = Nothing

    cmd.Parameters.AddWithValue("@codigoInst", wIns.CodigoInst)
    cmd.CommandType = CommandType.StoredProcedure
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      List = New List(Of AnioLectivo)
      Do While (dr.Read)
        List.Add(New AnioLectivo(dr.Item("anio").ToString, CDate(dr.Item("fechaI")), CDate(dr.Item("fechaF")), False, ""))
        If dr.Item("Estado").ToString = "A" Then
          List.Item(List.Count - 1).Estado = AnioLectivo.EstadoPeriodo.Abierto
        Else
          List.Item(List.Count - 1).Estado = AnioLectivo.EstadoPeriodo.Cerrado
        End If
      Loop
    Catch ex As Exception
      If List IsNot Nothing Then
        List.Clear()
      End If
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

    Return List
  End Function

  'Lista todos los periodos abiertos, abiertos o cerrados
  Public Function ListarAbiertos(ByVal wIns As Institucion) As List(Of AnioLectivo)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAniosAbiertos_Institucion", cn)
    Dim dr As SqlDataReader = Nothing
    Dim List As List(Of AnioLectivo) = Nothing

    cmd.Parameters.AddWithValue("@codigoInst", wIns.CodigoInst)
    cmd.CommandType = CommandType.StoredProcedure
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      List = New List(Of AnioLectivo)
      Do While (dr.Read)
        List.Add(New AnioLectivo(dr.Item("anio").ToString, CDate(dr.Item("fechaI")), CDate(dr.Item("fechaF")), False, ""))
        List.Item(List.Count - 1).Estado = AnioLectivo.EstadoPeriodo.Abierto
      Loop
    Catch ex As Exception
      If List IsNot Nothing Then
        List.Clear()
      End If
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

    Return List
  End Function

  'Lista todos los periodos abiertos, abiertos o cerrados
  Public Function ListarGrados(ByVal wAnio As AnioLectivo) As List(Of Grado)
    Dim pars As New List(Of CParametro)
    Dim lista As List(Of Grado) = Nothing
    Dim dr As SqlDataReader
    Dim iCodigo, iNumero As Integer, iSiglas As Integer

    pars.Add(New CParametro("@Anio", wAnio.Anio))

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liGradosAnio", pars)
      iCodigo = dr.GetOrdinal("CodigoG")
      iNumero = dr.GetOrdinal("Numero")
      iSiglas = dr.GetOrdinal("Siglas")
      lista = New List(Of Grado)
      While dr.Read
        lista.Add(New Grado)
        With lista.Item(lista.Count - 1)
          .Codigo = dr.GetInt16(iCodigo)
          .Numero = dr.GetByte(iNumero)
          .Nivel = New Nivel
          .Nivel.Siglas = dr.GetString(iSiglas)
        End With
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      lista = Nothing
      Throw ex
    End Try

    Return lista
  End Function

  'Lista las madres indicando los datos del hijo mayor
  Public Function ListarMadresHijoMayor(ByVal wAnio As AnioLectivo) As List(Of Pariente)
    Dim pars As New List(Of CParametro)
    Dim lista As List(Of Pariente) = Nothing
    Dim dr As SqlDataReader
    Dim iSiglas, iGrado, iSeccion As Integer
    Dim iNombreMad, iApellidoPatMad, iApellidoMatMad, iVive As Integer
    Dim iNombreAl, iApellidoPatAl, iApellidoMatAl As Integer

    pars.Add(New CParametro("@Anio", wAnio.Anio))

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liMadres_AlumnoMayor", pars)
      iSiglas = dr.GetOrdinal("Siglas")
      iGrado = dr.GetOrdinal("Grado")
      iSeccion = dr.GetOrdinal("Seccion")
      iNombreMad = dr.GetOrdinal("Nombre")
      iApellidoPatMad = dr.GetOrdinal("ApellidoPat")
      iApellidoMatMad = dr.GetOrdinal("ApellidoMat")
      iVive = dr.GetOrdinal("Vive")
      iNombreAl = dr.GetOrdinal("NombreAl")
      iApellidoPatAl = dr.GetOrdinal("ApellidoPatAl")
      iApellidoMatAl = dr.GetOrdinal("ApellidoMatAl")

      lista = New List(Of Pariente)
      While dr.Read
        lista.Add(New Pariente)
        With lista.Item(lista.Count - 1)
          .Nombre = dr.GetString(iNombreMad)
          .ApellidoPaterno = dr.GetString(iApellidoPatMad)
          .ApellidoMaterno = dr.GetString(iApellidoMatMad)
          .Vive = dr.GetBoolean(iVive)
          .AlumnoMatriculado = New Matricula
          With .AlumnoMatriculado
            .Seccion = New Seccion
            .Seccion.Grado = New Grado With {.Numero = dr.GetByte(iGrado)}
            .Seccion.Grado.Nivel = New Nivel With {.Siglas = dr.GetString(iSiglas)}
            .Seccion.Letra = dr.GetString(iSeccion)

            .Alumno = New Alumno
            With .Alumno
              .Nombre = dr.GetString(iNombreAl)
              .ApellidoPaterno = dr.GetString(iApellidoPatAl)
              .ApellidoMaterno = dr.GetString(iApellidoMatAl)
            End With
          End With
        End With
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      lista = Nothing
      Throw ex
    End Try

    Return lista
  End Function

  'Lista las madres indicando los datos del hijo mayor
  Public Function ListarMadresHijoMenor(ByVal wAnio As AnioLectivo) As List(Of Pariente)
    Dim pars As New List(Of CParametro)
    Dim lista As List(Of Pariente) = Nothing
    Dim dr As SqlDataReader
    Dim iSiglas, iGrado, iSeccion As Integer
    Dim iNombreMad, iApellidoPatMad, iApellidoMatMad, iVive As Integer
    Dim iNombreAl, iApellidoPatAl, iApellidoMatAl As Integer

    pars.Add(New CParametro("@Anio", wAnio.Anio))

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liMadres_AlumnoMenor", pars)
      iSiglas = dr.GetOrdinal("Siglas")
      iGrado = dr.GetOrdinal("Grado")
      iSeccion = dr.GetOrdinal("Seccion")
      iNombreMad = dr.GetOrdinal("Nombre")
      iApellidoPatMad = dr.GetOrdinal("ApellidoPat")
      iApellidoMatMad = dr.GetOrdinal("ApellidoMat")
      iVive = dr.GetOrdinal("Vive")
      iNombreAl = dr.GetOrdinal("NombreAl")
      iApellidoPatAl = dr.GetOrdinal("ApellidoPatAl")
      iApellidoMatAl = dr.GetOrdinal("ApellidoMatAl")

      lista = New List(Of Pariente)
      While dr.Read
        lista.Add(New Pariente)
        With lista.Item(lista.Count - 1)
          .Nombre = dr.GetString(iNombreMad)
          .ApellidoPaterno = dr.GetString(iApellidoPatMad)
          .ApellidoMaterno = dr.GetString(iApellidoMatMad)
          .Vive = dr.GetBoolean(iVive)
          .AlumnoMatriculado = New Matricula
          With .AlumnoMatriculado
            .Seccion = New Seccion
            .Seccion.Grado = New Grado With {.Numero = dr.GetByte(iGrado)}
            .Seccion.Grado.Nivel = New Nivel With {.Siglas = dr.GetString(iSiglas)}
            .Seccion.Letra = dr.GetString(iSeccion)

            .Alumno = New Alumno
            With .Alumno
              .Nombre = dr.GetString(iNombreAl)
              .ApellidoPaterno = dr.GetString(iApellidoPatAl)
              .ApellidoMaterno = dr.GetString(iApellidoMatAl)
            End With
          End With
        End With
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      lista = Nothing
      Throw ex
    End Try

    Return lista
  End Function

  'Lista los padres indicando los datos del hijo mayor
  Public Function ListarPadresHijoMayor(ByVal wAnio As AnioLectivo) As List(Of Pariente)
    Dim pars As New List(Of CParametro)
    Dim lista As List(Of Pariente) = Nothing
    Dim dr As SqlDataReader
    Dim iSiglas, iGrado, iSeccion As Integer
    Dim iNombreMad, iApellidoPatMad, iApellidoMatMad, iVive As Integer
    Dim iNombreAl, iApellidoPatAl, iApellidoMatAl As Integer

    pars.Add(New CParametro("@Anio", wAnio.Anio))

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liPadres_AlumnoMayor", pars)
      iSiglas = dr.GetOrdinal("Siglas")
      iGrado = dr.GetOrdinal("Grado")
      iSeccion = dr.GetOrdinal("Seccion")
      iNombreMad = dr.GetOrdinal("Nombre")
      iApellidoPatMad = dr.GetOrdinal("ApellidoPat")
      iApellidoMatMad = dr.GetOrdinal("ApellidoMat")
      iVive = dr.GetOrdinal("Vive")
      iNombreAl = dr.GetOrdinal("NombreAl")
      iApellidoPatAl = dr.GetOrdinal("ApellidoPatAl")
      iApellidoMatAl = dr.GetOrdinal("ApellidoMatAl")

      lista = New List(Of Pariente)
      While dr.Read
        lista.Add(New Pariente)
        With lista.Item(lista.Count - 1)
          .Nombre = dr.GetString(iNombreMad)
          .ApellidoPaterno = dr.GetString(iApellidoPatMad)
          .ApellidoMaterno = dr.GetString(iApellidoMatMad)
          .Vive = dr.GetBoolean(iVive)
          .AlumnoMatriculado = New Matricula
          With .AlumnoMatriculado
            .Seccion = New Seccion
            .Seccion.Grado = New Grado With {.Numero = dr.GetByte(iGrado)}
            .Seccion.Grado.Nivel = New Nivel With {.Siglas = dr.GetString(iSiglas)}
            .Seccion.Letra = dr.GetString(iSeccion)

            .Alumno = New Alumno
            With .Alumno
              .Nombre = dr.GetString(iNombreAl)
              .ApellidoPaterno = dr.GetString(iApellidoPatAl)
              .ApellidoMaterno = dr.GetString(iApellidoMatAl)
            End With
          End With
        End With
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      lista = Nothing
      Throw ex
    End Try

    Return lista
  End Function

  'Lista los padres indicando los datos del hijo mayor
  Public Function ListarPadresHijoMenor(ByVal wAnio As AnioLectivo) As List(Of Pariente)
    Dim pars As New List(Of CParametro)
    Dim lista As List(Of Pariente) = Nothing
    Dim dr As SqlDataReader
    Dim iSiglas, iGrado, iSeccion As Integer
    Dim iNombreMad, iApellidoPatMad, iApellidoMatMad, iVive As Integer
    Dim iNombreAl, iApellidoPatAl, iApellidoMatAl As Integer

    pars.Add(New CParametro("@Anio", wAnio.Anio))

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liPadres_AlumnoMenor", pars)
      iSiglas = dr.GetOrdinal("Siglas")
      iGrado = dr.GetOrdinal("Grado")
      iSeccion = dr.GetOrdinal("Seccion")
      iNombreMad = dr.GetOrdinal("Nombre")
      iApellidoPatMad = dr.GetOrdinal("ApellidoPat")
      iApellidoMatMad = dr.GetOrdinal("ApellidoMat")
      iVive = dr.GetOrdinal("Vive")
      iNombreAl = dr.GetOrdinal("NombreAl")
      iApellidoPatAl = dr.GetOrdinal("ApellidoPatAl")
      iApellidoMatAl = dr.GetOrdinal("ApellidoMatAl")

      lista = New List(Of Pariente)
      While dr.Read
        lista.Add(New Pariente)
        With lista.Item(lista.Count - 1)
          .Nombre = dr.GetString(iNombreMad)
          .ApellidoPaterno = dr.GetString(iApellidoPatMad)
          .ApellidoMaterno = dr.GetString(iApellidoMatMad)
          .Vive = dr.GetBoolean(iVive)
          .AlumnoMatriculado = New Matricula
          With .AlumnoMatriculado
            .Seccion = New Seccion
            .Seccion.Grado = New Grado With {.Numero = dr.GetByte(iGrado)}
            .Seccion.Grado.Nivel = New Nivel With {.Siglas = dr.GetString(iSiglas)}
            .Seccion.Letra = dr.GetString(iSeccion)

            .Alumno = New Alumno
            With .Alumno
              .Nombre = dr.GetString(iNombreAl)
              .ApellidoPaterno = dr.GetString(iApellidoPatAl)
              .ApellidoMaterno = dr.GetString(iApellidoMatAl)
            End With
          End With
        End With
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      lista = Nothing
      Throw ex
    End Try

    Return lista
  End Function

  'Lista los alumnos matriculados en el año solicitado que cumplen años en el mes indicado
  Public Function ListarCumpleanieros(ByVal wAnio As AnioLectivo, ByVal wMes As Integer) As List(Of Matricula)
    Dim mats As List(Of Matricula) = Nothing
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim iNom, iApPat, iApMat, iFechaNac As Integer
    Dim iNivel, iGrado, iLetra As Integer


    pars.AddRange(New CParametro() {New CParametro("@Anio", wAnio.Anio), _
                                    New CParametro("@Mes", wMes)})

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liCumpleaniosMes", pars)
      iNom = dr.GetOrdinal("Nombre")
      iApPat = dr.GetOrdinal("ApellidoPat")
      iApMat = dr.GetOrdinal("ApellidoMat")
      iFechaNac = dr.GetOrdinal("FechaNac")
      iNivel = dr.GetOrdinal("Siglas")
      iGrado = dr.GetOrdinal("Numero")
      iLetra = dr.GetOrdinal("Letra")
      mats = New List(Of Matricula)
      While dr.Read
        mats.Add(New Matricula())
        With mats.Item(mats.Count - 1)
          .Seccion = New Seccion
          With .Seccion
            .Letra = dr.GetString(iLetra)
            .Grado = New Grado With {.Numero = dr.GetByte(iGrado)}
            .Grado.Nivel = New Nivel With {.Siglas = dr.GetString(iNivel)}
          End With
          .Alumno = New Alumno With {.Nombre = dr.GetString(iNom), _
                                     .ApellidoPaterno = dr.GetString(iApPat), _
                                     .ApellidoMaterno = dr.GetString(iApMat), _
                                     .FechaNacimiento = dr.GetDateTime(iFechaNac) _
                                     }
        End With

      End While
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      pars = Nothing
    End Try

    Return mats
  End Function

  'Registrar los periodos que se indican
  Public Sub RegistrarPeriodos(ByVal wListaPer As List(Of PeriodoAcademico))
    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@FechaIni", Nothing),
                                    New CParametro("@FechaFin", Nothing),
                                    New CParametro("@Vigencia", Nothing),
                                    New CParametro("@Anio", Nothing),
                                    New CParametro("@nombre", Nothing),
                                    New CParametro("@siglas", Nothing)
                  })
    Try
      Me.Conectar(True)

      For Each objPeriodo As PeriodoAcademico In wListaPer
        pars.Item(0).Valor = objPeriodo.fechaIni
        pars.Item(1).Valor = objPeriodo.fechaFin
        pars.Item(2).Valor = True
        pars.Item(3).Valor = objPeriodo.Anio
        pars.Item(4).Valor = objPeriodo.Nombre
        pars.Item(5).Valor = objPeriodo.Siglas

        Me.EjecutarOrden("pr_iPeriodo_Acad", pars)
      Next

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)

      Throw ex
    Finally
      pars.clear()
    End Try
  End Sub


End Class
