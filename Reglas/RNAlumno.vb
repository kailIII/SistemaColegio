
Public Class RNAlumno
  Inherits CADO

  Public Function Registrar(ByVal wAlumno As Alumno) As Integer
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iAlumno", cn)
    Dim codigo As Integer = 0
    cmd.CommandType = CommandType.StoredProcedure

    With cmd.Parameters
      .AddWithValue("@CodigoAlu", 0).Direction = ParameterDirection.Output
      .AddWithValue("@Nombre", wAlumno.Nombre)
      .AddWithValue("@ApellidoPat", wAlumno.ApellidoPaterno)
      .AddWithValue("@ApellidoMat", wAlumno.ApellidoMaterno)
      .AddWithValue("@DNI", wAlumno.DNI)
      .AddWithValue("@Sexo", wAlumno.Sexo)
      .AddWithValue("@FechaNac", wAlumno.FechaNacimiento)
      .AddWithValue("@CodigoEducando", wAlumno.CodigoEducando)
      .AddWithValue("@lPais", wAlumno.LugarNacimiento.Pais)
      .AddWithValue("@lDepartamento", wAlumno.LugarNacimiento.Departamento)
      .AddWithValue("@lProvincia", wAlumno.LugarNacimiento.Provincia)
      .AddWithValue("@lDistrito", wAlumno.LugarNacimiento.Distrito)
      .AddWithValue("@email", IIf(wAlumno.Email.Length > 0, wAlumno.Email, DBNull.Value))
      .AddWithValue("@direccion", wAlumno.Direccion)
      .AddWithValue("@telefono", IIf(wAlumno.Telefono.Length > 0, wAlumno.Telefono, DBNull.Value))
      .AddWithValue("@nacionalidad", wAlumno.Nacionalidad)
      .AddWithValue("@grupoSang", wAlumno.GrupoSanguineo)
      .AddWithValue("@lenguaMat", wAlumno.LenguaMaterna)
      .AddWithValue("@medContra", IIf(wAlumno.MedicinasContraindicadas.Length > 0, wAlumno.MedicinasContraindicadas, DBNull.Value))
      .AddWithValue("@colegProc", IIf(wAlumno.ColegioProcedencia.Length > 0, wAlumno.ColegioProcedencia, DBNull.Value))
      .AddWithValue("@dPais", wAlumno.DireccionActual.Pais)
      .AddWithValue("@dDepartamento", wAlumno.DireccionActual.Departamento)
      .AddWithValue("@dProvincia", wAlumno.DireccionActual.Provincia)
      .AddWithValue("@dDistrito", wAlumno.DireccionActual.Distrito)
    End With
    Try
      cn.Open()
      cmd.ExecuteNonQuery()
      codigo = CInt(cmd.Parameters.Item("@CodigoAlu").Value)
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
    Return codigo
  End Function

  Public Function Listar(ByVal wNombre As String) As List(Of Alumno)
    Dim la As New List(Of Alumno)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAlumnos_Nombre", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Nombre", wNombre)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        la.Add(New Alumno(CInt(dr.Item("CodigoPersona")), dr.Item("Nombre").ToString, dr.Item("ApellidoPat").ToString, dr.Item("ApellidoMat").ToString))
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

    Return la
  End Function

  Public Function Leer(ByVal wAlum As Alumno) As Alumno
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lAlumno_Codigo", cn)
    Dim dr As SqlDataReader = Nothing
    Dim A As Alumno = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Codigo", wAlum.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read = True Then
        A = New Alumno(wAlum.Codigo, dr.Item("Nombre").ToString, dr.Item("ApellidoPat").ToString, dr.Item("ApellidoMat").ToString, _
                       dr.Item("Sexo").ToString, CDate(dr.Item("FechaNac")), dr.Item("codigoEducando").ToString, _
                       New UbicacionGeografica(dr.Item("distrito").ToString, dr.Item("provincia").ToString, dr.Item("departamento").ToString, _
                                               dr.Item("pais").ToString), IIf(IsDBNull(dr.Item("email")) = True, "", dr.Item("email")).ToString, dr.Item("direccion").ToString, _
                       IIf(IsDBNull(dr.Item("telefono")) = True, "", dr.Item("telefono")).ToString, dr.Item("nacionalidad").ToString, _
                             dr.Item("grupoSanguineo").ToString, dr.Item("lenguaMaterna").ToString, _
                             IIf(IsDBNull(dr.Item("medicinasContraindicadas")) = True, "", dr.Item("medicinasContraindicadas")).ToString, _
                             IIf(IsDBNull(dr.Item("colegioProcedencia")) = True, "", dr.Item("colegioProcedencia")).ToString, _
                              New UbicacionGeografica(dr.Item("ddistrito").ToString, dr.Item("dprovincia").ToString, _
                                                      dr.Item("ddepartamento").ToString, dr.Item("dpais").ToString))
        A.CodigoRecaudacion = dr.Item("CodigoRecaudacion").ToString.Trim
        A.DNI = dr.Item("DNI").ToString.Trim
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

    Return A
  End Function

  Public Sub Modificar(ByVal walumno As Alumno)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aAlumno", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Codigo", walumno.Codigo)
      .AddWithValue("@Nombre", walumno.Nombre)
      .AddWithValue("@ApellidoPat", walumno.ApellidoPaterno)
      .AddWithValue("@ApellidoMat", walumno.ApellidoMaterno)
      .AddWithValue("@DNI", walumno.DNI)
      .AddWithValue("@Sexo", walumno.Sexo)
      .AddWithValue("@FechaNac", walumno.FechaNacimiento)
      .AddWithValue("@CodigoEducando", walumno.CodigoEducando)
      .AddWithValue("@lPais", walumno.LugarNacimiento.Pais)
      .AddWithValue("@lDepartamento", walumno.LugarNacimiento.Departamento)
      .AddWithValue("@lProvincia", walumno.LugarNacimiento.Provincia)
      .AddWithValue("@lDistrito", walumno.LugarNacimiento.Distrito)
      .AddWithValue("@email", IIf(walumno.Email.Length > 0, walumno.Email, DBNull.Value))
      .AddWithValue("@direccion", walumno.Direccion)
      .AddWithValue("@telefono", IIf(walumno.Telefono.Length > 0, walumno.Telefono, DBNull.Value))
      .AddWithValue("@nacionalidad", walumno.Nacionalidad)
      .AddWithValue("@grupoSang", walumno.GrupoSanguineo)
      .AddWithValue("@lenguaMat", walumno.LenguaMaterna)
      .AddWithValue("@medContra", IIf(walumno.MedicinasContraindicadas.Length > 0, walumno.MedicinasContraindicadas, DBNull.Value))
      .AddWithValue("@colegProc", IIf(walumno.ColegioProcedencia.Length > 0, walumno.ColegioProcedencia, DBNull.Value))
      .AddWithValue("@dPais", walumno.DireccionActual.Pais)
      .AddWithValue("@dDepartamento", walumno.DireccionActual.Departamento)
      .AddWithValue("@dProvincia", walumno.DireccionActual.Provincia)
      .AddWithValue("@dDistrito", walumno.DireccionActual.Distrito)
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

  Public Sub RegistrarDatosPers(ByVal obj As Alumno, ByVal wpadre As Parentesco, ByVal wmadre As Parentesco)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iDatos_Pers_Alumno", cn)
    cmd.CommandType = CommandType.StoredProcedure

    With cmd.Parameters
      .AddWithValue("@codigo", obj.Codigo)
      .AddWithValue("@codigoPadre", wpadre.Apoderado.Codigo)
      .AddWithValue("@parentescoPadre", wpadre.Parentesco)
      .AddWithValue("@codigoMadre", wmadre.Apoderado.Codigo)
      .AddWithValue("@parentescoMadre", wmadre.Parentesco)
      .AddWithValue("@email", IIf(obj.Email.Length > 0, obj.Email, DBNull.Value))
      .AddWithValue("@direccion", obj.Direccion)
      .AddWithValue("@telefono", IIf(obj.Telefono.Length > 0, obj.Telefono, DBNull.Value))
      .AddWithValue("@nacionalidad", obj.Nacionalidad)
      .AddWithValue("@grupoSang", obj.GrupoSanguineo)
      .AddWithValue("@lenguaMat", obj.LenguaMaterna)
      .AddWithValue("@medContra", IIf(obj.MedicinasContraindicadas.Length > 0, obj.MedicinasContraindicadas, DBNull.Value))
      .AddWithValue("@colegProc", IIf(obj.ColegioProcedencia.Length > 0, obj.ColegioProcedencia, DBNull.Value))
      .AddWithValue("@Pais", obj.LugarNacimiento.Pais)
      .AddWithValue("@Departamento", obj.LugarNacimiento.Departamento)
      .AddWithValue("@Provincia", obj.LugarNacimiento.Provincia)
      .AddWithValue("@Distrito", obj.LugarNacimiento.Distrito)
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

  Public Function NumeroAlumnos() As Integer
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAlumnos", cn)
    Dim dr As Integer


    cmd.CommandType = CommandType.StoredProcedure
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

  Public Function ListarAlumnosSeccion(ByVal obj As Seccion) As List(Of Alumno)
    Dim la As New List(Of Alumno)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lAlumnosSeccion", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Letra", obj.Letra)
    cmd.Parameters.AddWithValue("@CodigoG", obj.Grado.Codigo)
    cmd.Parameters.AddWithValue("@Anio", obj.Anio.Anio)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        la.Add(New Alumno(CInt(dr.Item("CodigoAlumno"))))
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

    Return la
  End Function

  Public Function ListarMatriculado(ByVal wNombre As String) As List(Of Alumno)
    Dim la As New List(Of Alumno)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAlumnos_NombreCompleto", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Nombre", wNombre)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        la.Add(New Alumno(CInt(dr.Item("CodigoAlumno")), dr.Item("Nombre").ToString, dr.Item("ApellidoPat").ToString, dr.Item("ApellidoMat").ToString))
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

    Return la
  End Function

  Public Function LeerDatosAlumno_CodigoRecaudacion(ByVal wCodigoRecaudacion As String) As Alumno
    Dim al As Alumno = Nothing
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lAlumno_CodigoRecaudacion", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure

    cmd.Parameters.Add(New SqlParameter("@CodigoRecaudacion", CInt(wCodigoRecaudacion)))
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      If dr.Read Then
        al = New Alumno(CInt(dr.Item("CodigoPersona")), dr.Item("Nombre").ToString, dr.Item("ApellidoPat").ToString, dr.Item("ApellidoMat").ToString)
        al.CodigoRecaudacion = CInt(wCodigoRecaudacion).ToString
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

    Return al
  End Function

  Public Function ListarParientes(ByVal wAlumno As Alumno) As List(Of Parentesco)
    Dim datos As List(Of Parentesco) = Nothing
    Dim params As New List(Of CParametro)
    Dim dr As SqlDataReader = Nothing
    Dim p As Parentesco
    Dim indCod As Integer, indPar As Integer, indNombre As Integer, indApPat As Integer, indApMat As Integer

    params.Add(New CParametro("@Alumno", wAlumno.Codigo))

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liParientes", params)
      indCod = dr.GetOrdinal("CodigoApoderado")
      indPar = dr.GetOrdinal("Parentesco")
      indNombre = dr.GetOrdinal("Nombre")
      indApPat = dr.GetOrdinal("ApellidoPat")
      indApMat = dr.GetOrdinal("ApellidoMat")
      datos = New List(Of Parentesco)
      While dr.Read
        p = New Parentesco
        p.Parentesco = dr.GetString(indPar)
        p.Apoderado = New Apoderado(dr.GetInt32(indCod), dr.GetString(indApPat), dr.GetString(indApMat), dr.GetString(indNombre))
        datos.Add(p)
      End While
      Me.Cerrar(True)
    Catch ex As Exception
      datos = Nothing
      Me.Cerrar(False)
      Throw ex
    Finally
      If dr IsNot Nothing Then
        dr.Close()
      End If
      dr = Nothing
    End Try

    Return datos
  End Function

  Public Function ListarAlumnosSeccion_NombreCompleto(ByVal obj As Seccion) As List(Of Alumno)
    Dim la As New List(Of Alumno)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liCodigosRecaudacion", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Letra", obj.Letra)
    cmd.Parameters.AddWithValue("@Grado", obj.Grado.Codigo)
    cmd.Parameters.AddWithValue("@Anio", obj.Anio.Anio)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        la.Add(New Alumno(CInt(dr.Item("codigoAlumno")), dr.Item("Nombre").ToString.ToUpperInvariant, _
                          dr.Item("ApellidoPat").ToString.ToUpper, dr.Item("ApellidoMat").ToString.ToUpper, "", dr.Item("codigoRecaudacion").ToString.Trim))
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

    Return la
  End Function

  Public Sub AsignarCodigoRecaudacion(ByVal wList As List(Of Alumno))
    Dim cn As New SqlConnection(My.Settings.Conexion)

    Try
      For Each fila In wList
        Dim cmd As New SqlCommand("pr_aCodigosRecaudacion", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
          .AddWithValue("@Alumno", fila.Codigo)
          .AddWithValue("@Codigo", IIf(fila.CodigoRecaudacion = "", "   ", fila.CodigoRecaudacion))
        End With
        cn.Open()
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        cmd = Nothing
        cn.Close()
      Next
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

  Public Function ListarAlumnosSinCodigo(ByVal wAnio As AnioLectivo) As List(Of Matricula)
    Dim datos As List(Of Matricula) = Nothing
    Dim params As New List(Of CParametro)
    Dim dr As SqlDataReader = Nothing
    Dim iSiglas, iGrado, iLetra, iApellidoPat, iApellidoMat, iNombres, iCodigo, iCodigoRec As Integer

    params.Add(New CParametro("@Anio", wAnio.Anio))

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liAlumnosSinCodigoRecaudacion", params)
      iSiglas = dr.GetOrdinal("Siglas")
      iGrado = dr.GetOrdinal("Numero")
      iLetra = dr.GetOrdinal("Letra")
      iCodigo = dr.GetOrdinal("CodigoAlumno")
      iCodigoRec = dr.GetOrdinal("CodigoRecaudacion")
      iApellidoPat = dr.GetOrdinal("ApellidoPat")
      iApellidoMat = dr.GetOrdinal("ApellidoMat")
      iNombres = dr.GetOrdinal("Nombre")
      datos = New List(Of Matricula)
      While dr.Read
        datos.Add(New Matricula)
        With datos.Item(datos.Count - 1)
          .Alumno = New Alumno With {.Codigo = dr.GetInt32(iCodigo), _
                                    .CodigoRecaudacion = dr.GetString(iCodigoRec).Trim, _
                                    .Nombre = dr.GetString(iNombres), _
                                    .ApellidoPaterno = dr.GetString(iApellidoPat), _
                                    .ApellidoMaterno = dr.GetString(iApellidoMat)}
          .Seccion = New Seccion With {.Letra = dr.GetString(iLetra), _
                                       .Grado = New Grado With {.Numero = dr.GetByte(iGrado), _
                                                               .Nivel = New Nivel With {.Siglas = dr.GetString(iSiglas)} _
                                                               } _
                                       }
        End With
      End While
      Me.Cerrar(True)
    Catch ex As Exception
      datos = Nothing
      Me.Cerrar(False)
      Throw ex
    Finally
      If dr IsNot Nothing Then
        dr.Close()
      End If
      dr = Nothing
    End Try

    Return datos
  End Function

  Public Function ListarHermanosMatriculados(ByVal wAnio As AnioLectivo, ByVal wPersona As Persona) As List(Of Matricula)
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim hermanosMat As List(Of Matricula) = Nothing
    Dim nroMat, nombre, apPat, apMat As Integer

    pars.AddRange(New CParametro() {New CParametro("@Anio", wAnio.Anio), _
                                    New CParametro("@Alumno", wPersona.Codigo)})
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liHermanosMatriculados", pars)
      nroMat = dr.GetOrdinal("nroMatricula")
      nombre = dr.GetOrdinal("Nombre")
      apPat = dr.GetOrdinal("ApellidoPat")
      apMat = dr.GetOrdinal("ApellidoMat")
      hermanosMat = New List(Of Matricula)
      While dr.Read
        hermanosMat.Add(New Matricula)
        With hermanosMat.Item(hermanosMat.Count - 1)
          .Numero = dr.GetInt16(nroMat)
          .Alumno = New Alumno With {.Nombre = dr.GetString(nombre), _
                                     .ApellidoPaterno = dr.GetString(apPat), _
                                     .ApellidoMaterno = dr.GetString(apMat)}
        End With
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars.Clear()
      pars = Nothing
    End Try

    Return hermanosMat
  End Function

  'Permite obtener el último código de recaudación de un alumno
  Public Function ObtenerNuevoCodigo() As Integer
    Dim dr As SqlDataReader = Nothing
    Dim codigo As Integer = 1

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_lCodigoAlumnoMaximo", Nothing)
      If dr.Read Then
        If dr.IsDBNull(dr.GetOrdinal("codigo")) = False Then
          codigo = CInt(dr.Item("codigo")) + 1
        End If
      End If

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      If dr IsNot Nothing Then
        dr.Close()
        dr = Nothing
      End If
    End Try

    Return codigo
  End Function


End Class
