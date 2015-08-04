
Public Class RNApoderado
  Inherits CADO

  Public Function Registrar(ByVal obj As Apoderado, ByVal wParent As Parentesco) As Integer
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iApoderado", cn)
    Dim Codigo As Integer

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Codigo", 0).Direction = ParameterDirection.Output

      .AddWithValue("@CodigoAlumno", wParent.Alumno.Codigo)
      .AddWithValue("@Parentesco", wParent.Parentesco)

      .AddWithValue("@Nombre", obj.Nombre)
      .AddWithValue("@ApellidoPat", obj.ApellidoPaterno)
      .AddWithValue("@ApellidoMat", obj.ApellidoMaterno)
      .AddWithValue("@Sexo", obj.Sexo)
      .AddWithValue("@FechaNac", obj.FechaNacimiento)
      .AddWithValue("@tipoDoc", obj.TipoDoc)
      .AddWithValue("@nroDoc", obj.NroDoc)
      .AddWithValue("@EstadoCivil", obj.EstadoCivil)
      .AddWithValue("@GradoInst", obj.GradoInstruccion)
      .AddWithValue("@Direccion", obj.Direccion)
      .AddWithValue("@TelefonoCasa", IIf(obj.TelefonoCasa.Length > 0, obj.TelefonoCasa, DBNull.Value))
      .AddWithValue("@TelefonoTrab", IIf(obj.TelefonoTrabajo.Length > 0, obj.TelefonoTrabajo, DBNull.Value))
      .AddWithValue("@LugarTrab", IIf(obj.LugarTrabajo.Length > 0, obj.LugarTrabajo, DBNull.Value))
      .AddWithValue("@Email", IIf(obj.Email.Length > 0, obj.Email, DBNull.Value))
      .AddWithValue("@Celular", IIf(obj.Celular.Length > 0, obj.Celular, DBNull.Value))
      .AddWithValue("@Vive", obj.Vive)
      .AddWithValue("@Profesion", obj.Profesion.Nombre)
      .AddWithValue("@Ocupacion", obj.Ocupacion.Nombre)
      .AddWithValue("@Pais", obj.DireccionActual.Pais)
      .AddWithValue("@Departamento", obj.DireccionActual.Departamento)
      .AddWithValue("@Provincia", obj.DireccionActual.Provincia)
      .AddWithValue("@Distrito", obj.DireccionActual.Distrito)
    End With

    Try
      cn.Open()
      cmd.ExecuteNonQuery()
      Codigo = CInt(cmd.Parameters.Item("@Codigo").Value)
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

    Return Codigo
  End Function

  Public Function Listar(ByVal wNombre As String) As List(Of Apoderado)
    Dim la As New List(Of Apoderado)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liApoderado_Nombre", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Nombre", wNombre)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        la.Add(New Apoderado(CInt(dr.Item("CodigoPersona")), dr.Item("ApellidoPat").ToString, dr.Item("ApellidoMat").ToString, dr.Item("Nombre").ToString))
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

  Public Function Leer(ByVal wPar As Parentesco) As Apoderado
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_buscarApoderado", cn)
    Dim dr As SqlDataReader = Nothing
    Dim a As Apoderado = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoAlumno", wPar.Alumno.Codigo)
    cmd.Parameters.AddWithValue("@tipo", wPar.Parentesco)

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read = True Then
        a = New Apoderado(CInt(dr.Item("CodigoApoderado")), dr.Item("ApellidoPat").ToString, dr.Item("ApellidoMat").ToString, dr.Item("Nombre").ToString)
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

  Public Function Leer(ByVal obj As Apoderado) As Apoderado
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lApoderado_Codigo", cn)
    Dim dr As SqlDataReader = Nothing
    Dim A As Apoderado = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Codigo", obj.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      If dr.Read = True Then
        A = New Apoderado(obj.Codigo, dr.Item("Nombre").ToString, dr.Item("ApellidoPat").ToString, dr.Item("ApellidoMat").ToString, dr.Item("Sexo").ToString, _
                          CDate(dr.Item("FechaNac")), dr.Item("tipoDoc").ToString, dr.Item("nroDoc").ToString, dr.Item("estadoCivil").ToString, dr.Item("gradoInst").ToString, dr.Item("direccion").ToString, _
                          IIf(IsDBNull(dr.Item("telefonoCasa")) = True, "", dr.Item("telefonoCasa")).ToString, _
                          IIf(IsDBNull(dr.Item("telefonoTrab")) = True, "", dr.Item("telefonoTrab")).ToString, _
                          IIf(IsDBNull(dr.Item("lugarTrab")) = True, "", dr.Item("lugarTrab")).ToString, _
                          IIf(IsDBNull(dr.Item("email")) = True, "", dr.Item("email")).ToString, _
                          IIf(IsDBNull(dr.Item("celular")) = True, "", dr.Item("celular")).ToString, CBool(dr.Item("vive")), _
                          New Ocupacion(dr.Item("ocupacion").ToString), New Profesion(dr.Item("profesion").ToString), _
                          New UbicacionGeografica(dr.Item("distrito").ToString, dr.Item("provincia").ToString, dr.Item("departamento").ToString, _
                                                  dr.Item("pais").ToString))
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

  Public Sub Modificar(ByVal Obj As Apoderado)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aApoderado", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Codigo", Obj.Codigo)
      .AddWithValue("@Nombre", Obj.Nombre)
      .AddWithValue("@ApellidoPat", Obj.ApellidoPaterno)
      .AddWithValue("@ApellidoMat", Obj.ApellidoMaterno)
      .AddWithValue("@Sexo", Obj.Sexo)
      .AddWithValue("@FechaNac", Obj.FechaNacimiento)
      .AddWithValue("@tipoDoc", Obj.TipoDoc)
      .AddWithValue("@nroDoc", Obj.NroDoc)
      .AddWithValue("@EstadoCivil", Obj.EstadoCivil)
      .AddWithValue("@GradoInst", Obj.GradoInstruccion)
      .AddWithValue("@Direccion", Obj.Direccion)
      .AddWithValue("@TelefonoCasa", IIf(Obj.TelefonoCasa.Length > 0, Obj.TelefonoCasa, DBNull.Value))
      .AddWithValue("@TelefonoTrab", IIf(Obj.TelefonoTrabajo.Length > 0, Obj.TelefonoTrabajo, DBNull.Value))
      .AddWithValue("@LugarTrab", IIf(Obj.LugarTrabajo.Length > 0, Obj.LugarTrabajo, DBNull.Value))
      .AddWithValue("@Email", IIf(Obj.Email.Length > 0, Obj.Email, DBNull.Value))
      .AddWithValue("@Celular", IIf(Obj.Celular.Length > 0, Obj.Celular, DBNull.Value))
      .AddWithValue("@Vive", Obj.Vive)
      .AddWithValue("@Profesion", Obj.Profesion.Nombre)
      .AddWithValue("@Ocupacion", Obj.Ocupacion.Nombre)
      .AddWithValue("@Pais", Obj.DireccionActual.Pais)
      .AddWithValue("@Departamento", Obj.DireccionActual.Departamento)
      .AddWithValue("@Provincia", Obj.DireccionActual.Provincia)
      .AddWithValue("@Distrito", Obj.DireccionActual.Distrito)
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

  Public Function LeerApoderadoNombre(ByVal wap As Apoderado) As Apoderado
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lApoderadoNombre", cn)
    Dim dr As SqlDataReader = Nothing
    Dim a As Apoderado = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoApoderado", wap.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read = True Then
        a = New Apoderado(CInt(dr.Item("CodigoApoderado")), CStr(dr.Item("ApellidoPat")), CStr(dr.Item("ApellidoMat")), CStr(dr.Item("Nombre")))
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

  Public Function ListarParentesco(ByVal wcodigo As Integer) As List(Of Parentesco)
    Dim la As New List(Of Parentesco)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liParentesco", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Codigo", wcodigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        la.Add(New Parentesco(New Apoderado(CInt(dr.Item("CodigoPersona")), dr.Item("Nombre").ToString, dr.Item("ApellidoPat").ToString, dr.Item("ApellidoMat").ToString, dr.Item("Sexo").ToString, _
                          CDate(dr.Item("FechaNac")), dr.Item("tipoDoc").ToString, dr.Item("nroDoc").ToString, dr.Item("estadoCivil").ToString, dr.Item("gradoInst").ToString, dr.Item("direccion").ToString, _
                          IIf(IsDBNull(dr.Item("telefonoCasa")) = True, "", dr.Item("telefonoCasa")).ToString, _
                          IIf(IsDBNull(dr.Item("telefonoTrab")) = True, "", dr.Item("telefonoTrab")).ToString, _
                          IIf(IsDBNull(dr.Item("lugarTrab")) = True, "", dr.Item("lugarTrab")).ToString, _
                          IIf(IsDBNull(dr.Item("email")) = True, "", dr.Item("email")).ToString, _
                          IIf(IsDBNull(dr.Item("celular")) = True, "", dr.Item("celular")).ToString, CBool(dr.Item("vive")), _
                           New Ocupacion(dr.Item("ocupacion").ToString), New Profesion(dr.Item("profesion").ToString), _
                          New UbicacionGeografica(dr.Item("distrito").ToString, dr.Item("provincia").ToString, dr.Item("departamento").ToString, _
                                                  dr.Item("pais").ToString)), Nothing, dr.Item("parentesco").ToString))
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

  Public Function MostrarTutor(ByVal obj As Integer, ByVal wAnio As AnioLectivo) As Apoderado
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lTutor_Alumno", cn)
    Dim dr As SqlDataReader = Nothing
    Dim a As Apoderado = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Alumno", obj)
    cmd.Parameters.AddWithValue("@Anio", wAnio.Anio)

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read = True Then
        a = New Apoderado(CInt(dr.Item("CodigoApoderado")), Nothing, Nothing, Nothing)
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

  Public Function LeerPersonas(ByVal obj As Apoderado) As Apoderado
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lPersonas_Codigo", cn)
    Dim dr As SqlDataReader = Nothing
    Dim A As Apoderado = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Codigo", obj.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      If dr.Read = True Then
        A = New Apoderado(obj.Codigo, dr.Item("Nombre").ToString, dr.Item("ApellidoPat").ToString, dr.Item("ApellidoMat").ToString, dr.Item("Sexo").ToString, _
                          CDate(dr.Item("FechaNac")), dr.Item("tipoDoc").ToString, dr.Item("nroDoc").ToString, dr.Item("estadoCivil").ToString, dr.Item("gradoInst").ToString, dr.Item("direccion").ToString, _
                          IIf(IsDBNull(dr.Item("telefonoCasa")) = True, "", dr.Item("telefonoCasa")).ToString, _
                          IIf(IsDBNull(dr.Item("telefonoTrab")) = True, "", dr.Item("telefonoTrab")).ToString, _
                          IIf(IsDBNull(dr.Item("lugarTrab")) = True, "", dr.Item("lugarTrab")).ToString, _
                          IIf(IsDBNull(dr.Item("email")) = True, "", dr.Item("email")).ToString, _
                          IIf(IsDBNull(dr.Item("celular")) = True, "", dr.Item("celular")).ToString, _
                          CBool(IIf(IsDBNull(dr.Item("vive")) = True, True, dr.Item("vive"))), _
                           New Ocupacion(dr.Item("ocupacion").ToString), New Profesion(dr.Item("profesion").ToString), _
                          New UbicacionGeografica(dr.Item("distrito").ToString, dr.Item("provincia").ToString, dr.Item("departamento").ToString, _
                                                  dr.Item("pais").ToString))
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

  Public Function ListarPersonas(ByVal wNombre As String) As List(Of Apoderado)
    Dim la As New List(Of Apoderado)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liPersonas_Nombre", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Nombre", wNombre)

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        la.Add(New Apoderado(CInt(dr.Item("CodigoPersona")), dr.Item("ApellidoPat").ToString, _
                             dr.Item("ApellidoMat").ToString, dr.Item("Nombre").ToString))
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

  Public Function ListarApoderadosTrabajo(ByVal wAnio As AnioLectivo, ByVal wNombre As String, ByVal wOcupacion As String, ByVal wProfesion As String, _
                                          ByVal wEmpresa As String) As List(Of Matricula)

    Dim datos As List(Of Matricula) = Nothing
    Dim dr As SqlDataReader
    Dim params As New List(Of CParametro)
    Dim indNombre, indApellidoPat, indApellidoMat, indTelefono As Integer
    Dim indTelefonoTrab, indCelular, indCorreo As Integer
    Dim indLugarTrab, indProfesion, indOcupacion, iParentesco As Integer
    Dim iNombreAl, iApellidoPatAl, iApellidoMatAl, iGrado, iSiglas, iLetra As Integer

    params.Add(New CParametro("@Anio", wAnio.Anio))
    params.Add(New CParametro("@Nombre", wNombre))
    params.Add(New CParametro("@Ocupacion", IIf(wOcupacion.Length > 0, wOcupacion, DBNull.Value)))
    params.Add(New CParametro("@Profesion", IIf(wProfesion.Length > 0, wProfesion, DBNull.Value)))
    params.Add(New CParametro("@Empresa", IIf(wEmpresa.Length > 0, wEmpresa, DBNull.Value)))

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liApoderadoPorTrabajo", params)

      indNombre = dr.GetOrdinal("Nombre")
      indApellidoPat = dr.GetOrdinal("ApellidoPat")
      indApellidoMat = dr.GetOrdinal("ApellidoMat")
      indTelefono = dr.GetOrdinal("TelefonoCasa")
      indCelular = dr.GetOrdinal("Celular")
      indTelefonoTrab = dr.GetOrdinal("TelefonoTrab")
      indLugarTrab = dr.GetOrdinal("LugarTrab")
      indProfesion = dr.GetOrdinal("Profesion")
      indOcupacion = dr.GetOrdinal("Ocupacion")
      indCorreo = dr.GetOrdinal("Email")
      iNombreAl = dr.GetOrdinal("NombreAl")
      iApellidoPatAl = dr.GetOrdinal("ApellidoPatAl")
      iApellidoMatAl = dr.GetOrdinal("ApellidoMatAl")
      iGrado = dr.GetOrdinal("Numero")
      iSiglas = dr.GetOrdinal("Siglas")
      iLetra = dr.GetOrdinal("Letra")
      iParentesco = dr.GetOrdinal("Parentesco")

      datos = New List(Of Matricula)
      While dr.Read
        datos.Add(New Matricula)
        With datos.Item(datos.Count - 1)
          .Alumno = New Alumno()
          With .Alumno
            .Nombre = dr.GetString(iNombreAl)
            .ApellidoPaterno = dr.GetString(iApellidoPatAl)
            .ApellidoMaterno = dr.GetString(iApellidoMatAl)
          End With
          .Seccion = New Seccion
          With .Seccion
            .Letra = dr.GetString(iLetra)
            .Grado = New Grado
            .Grado.Numero = dr.GetByte(iGrado)
            .Grado.Nivel = New Nivel
            .Grado.Nivel.Siglas = dr.GetString(iSiglas)
          End With

          .Parentesco = New Parentesco
          .Parentesco.Parentesco = dr.GetString(iParentesco)
          With .Parentesco
            .Apoderado = New Apoderado
            With .Apoderado
              .Nombre = dr.GetString(indNombre)
              .ApellidoPaterno = dr.GetString(indApellidoPat)
              .ApellidoMaterno = dr.GetString(indApellidoMat)
              If dr.IsDBNull(indTelefono) = False Then
                .TelefonoCasa = dr.GetString(indTelefono)
              End If
              If dr.IsDBNull(indCelular) = False Then
                .Celular = dr.GetString(indCelular)
              End If
              If dr.IsDBNull(indTelefonoTrab) = False Then
                .TelefonoTrabajo = dr.GetString(indTelefonoTrab)
              End If
              If dr.IsDBNull(indLugarTrab) = False Then
                .LugarTrabajo = dr.GetString(indLugarTrab)
              End If
              .Profesion = New Profesion(dr.GetString(indProfesion))
              .Ocupacion = New Ocupacion(dr.GetString(indOcupacion))
              If dr.IsDBNull(indCorreo) = False Then
                .Email = dr.GetString(indCorreo)
              End If
            End With
          End With
          .codigoApoderado = .Parentesco.Apoderado
        End With

      End While
      Me.Cerrar(True)
    Catch ex As Exception
      datos = Nothing
      Me.Cerrar(False)
      Throw ex
    Finally
      params.Clear()
      params = Nothing
      dr = Nothing
    End Try

    Return datos
  End Function

  Public Function ListarLugaresTrabajo() As List(Of String)
    Dim datos As List(Of String) = Nothing
    Dim dr As SqlDataReader
    Dim indNombre As Integer

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liLugarTrabajo", Nothing)
      indNombre = dr.GetOrdinal("LugarTrab")
      datos = New List(Of String)
      While dr.Read
        datos.Add(dr.GetString(indNombre))
      End While
      Me.Cerrar(True)
    Catch ex As Exception
      datos = Nothing
      Me.Cerrar(False)
      Throw ex
    Finally
      dr = Nothing
    End Try

    Return datos
  End Function

  Public Function LeerParienteAlumno(ByVal wAlumno As Alumno, ByVal wParentesco As String) As Apoderado
    Dim apod As Apoderado = Nothing
    Dim dr As SqlDataReader
    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@Alumno", wAlumno.Codigo), New CParametro("Parentesco", wParentesco)})

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_lPariente_Alumno", pars)
      If dr.Read Then
        apod = New Apoderado
        apod.Nombre = dr.GetString(dr.GetOrdinal("Nombre"))
        apod.ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPat"))
        apod.ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMat"))
        apod.Direccion = dr.GetString(dr.GetOrdinal("Direccion"))
        If dr.IsDBNull(dr.GetOrdinal("TelefonoCasa")) = False Then
          apod.TelefonoCasa = dr.GetString(dr.GetOrdinal("TelefonoCasa"))
        End If
        If dr.IsDBNull(dr.GetOrdinal("TelefonoTrab")) = False Then
          apod.TelefonoTrabajo = dr.GetString(dr.GetOrdinal("TelefonoTrab"))
        End If
        If dr.IsDBNull(dr.GetOrdinal("Celular")) = False Then
          apod.Celular = dr.GetString(dr.GetOrdinal("Celular"))
        End If
        If dr.IsDBNull(dr.GetOrdinal("Email")) = False Then
          apod.Email = dr.GetString(dr.GetOrdinal("Email"))
        End If
        apod.Vive = dr.GetBoolean(dr.GetOrdinal("Vive"))
      End If
      Me.Cerrar(True)
    Catch ex As Exception
      apod = Nothing
      Me.Cerrar(False)
      Throw ex
    Finally
      dr = Nothing
    End Try

    Return apod
  End Function

  'Lista los padres de familia con hijos matriculados en el año solicitado
  'La busqueda se realiza en base a la primera parte del nombre completo
  Public Function ListarPadresNombreAnio(ByVal wAnio As AnioLectivo, ByVal wNombre As String) As List(Of Apoderado)
    Dim dr As SqlDataReader
    Dim pars As New List(Of CParametro)
    Dim padres As List(Of Apoderado) = Nothing
    Dim iCodigo, iNombres, iApPat, iApMat As Integer

    pars.AddRange(New CParametro() {New CParametro("@Anio", wAnio.Anio), _
                                    New CParametro("@Nombre", wNombre)})
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liPadresNombreAnio", pars)
      iCodigo = dr.GetOrdinal("CodigoPersona")
      iNombres = dr.GetOrdinal("Nombre")
      iApPat = dr.GetOrdinal("ApellidoPat")
      iApMat = dr.GetOrdinal("ApellidoMat")

      padres = New List(Of Apoderado)
      While dr.Read
        padres.Add(New Apoderado)
        With padres.Item(padres.Count - 1)
          .Codigo = dr.GetInt32(iCodigo)
          .Nombre = dr.GetString(iNombres)
          .ApellidoPaterno = dr.GetString(iApPat)
          .ApellidoMaterno = dr.GetString(iApMat)
        End With
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      If padres IsNot Nothing Then
        padres.Clear()
      End If
      padres = Nothing
      Me.Cerrar(False)
      Throw ex
    Finally
      dr = Nothing
    End Try

    Return padres
  End Function

  'Lista los hijos matriculados en el año solicitado del padre de familia que se indica
  Public Function ListarHijosPadreAnio(ByVal wAnio As AnioLectivo, ByVal wPadre As Apoderado) As List(Of Matricula)
    Dim dr As SqlDataReader
    Dim pars As New List(Of CParametro)
    Dim hijos As List(Of Matricula) = Nothing
    Dim iNumero, iSiglas, iGrado, iLetra, iCodigoPer, iNombres, iApPat, iApMat, iParentesco As Integer

    pars.AddRange(New CParametro() {New CParametro("@Anio", wAnio.Anio), _
                                    New CParametro("@Padre", wPadre.Codigo)})
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liHijosPadresAnio", pars)
      iNumero = dr.GetOrdinal("nroMatricula")
      iSiglas = dr.GetOrdinal("Siglas")
      iGrado = dr.GetOrdinal("Numero")
      iLetra = dr.GetOrdinal("Letra")
      iCodigoPer = dr.GetOrdinal("CodigoPersona")
      iNombres = dr.GetOrdinal("Nombre")
      iApPat = dr.GetOrdinal("ApellidoPat")
      iApMat = dr.GetOrdinal("ApellidoMat")
      iParentesco = dr.GetOrdinal("Parentesco")

      hijos = New List(Of Matricula)
      While dr.Read
        hijos.Add(New Matricula With {.Numero = dr.GetInt16(iNumero), _
                  .Seccion = New Seccion() With {.Grado = New Grado() With {.Numero = dr.GetByte(iGrado), _
                                                                            .Nivel = New Nivel With {.Siglas = dr.GetString(iSiglas)}}, _
                                                .Letra = dr.GetString(iLetra)}, _
                  .Alumno = New Alumno() With {.Codigo = dr.GetInt32(iCodigoPer), _
                                               .Nombre = dr.GetString(iNombres), _
                                               .ApellidoPaterno = dr.GetString(iApPat), _
                                               .ApellidoMaterno = dr.GetString(iApMat)}, _
                .Parentesco = New Parentesco With {.Parentesco = dr.GetString(iParentesco)}})
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      If hijos IsNot Nothing Then
        hijos.Clear()
      End If
      hijos = Nothing
      Me.Cerrar(False)
      Throw ex
    Finally
      dr = Nothing
    End Try

    Return hijos
  End Function
End Class
