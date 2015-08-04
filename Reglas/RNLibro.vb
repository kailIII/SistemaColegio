Public Class RNLibro
  Inherits CADO

  Public Sub Registrar(ByVal wLibro As Libro, ByVal wListaAutor As List(Of Autor))
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmdLib As New SqlCommand("pr_iLibro", cn)
    Dim cmdAut As New SqlCommand("pr_iAutor", cn)

    Dim trx As SqlTransaction = Nothing
    Dim codigoLibro As Integer = 0

    cmdLib.CommandType = CommandType.StoredProcedure

    Try
      cn.Open()
      trx = cn.BeginTransaction

      cmdLib.Transaction = trx
      cmdLib.CommandType = CommandType.StoredProcedure
      With (cmdLib.Parameters)
        .AddWithValue("@CodigoLibro", 0).Direction = ParameterDirection.Output
        .AddWithValue("@Titulo", wLibro.Titulo)
        .AddWithValue("@Descripcion", wLibro.Descripcion)
        .AddWithValue("@Abreviatura", wLibro.Abreviatura)

      End With
      cmdLib.ExecuteNonQuery()
      codigoLibro = CInt(cmdLib.Parameters.Item("@CodigoLibro").Value)
      '-----------------------------REGISTRO DE AUTORES---------------------------------
      cmdAut.Transaction = trx
      cmdAut.CommandType = CommandType.StoredProcedure
      With cmdAut.Parameters
        .AddWithValue("@CodigoLibro", 0)
        .AddWithValue("@Nombres", "")
        .AddWithValue("@Apellidos", "")
      End With

      For Each objAutor As Autor In wListaAutor
        With cmdAut.Parameters
          .Item("@CodigoLibro").Value = codigoLibro
          .Item("@Nombres").Value = objAutor.Nombres
          .Item("@Apellidos").Value = objAutor.Apellidos
        End With
        cmdAut.ExecuteNonQuery()
      Next
      trx.Commit()
    Catch ex As Exception
      If trx IsNot Nothing Then
        trx.Rollback()
      End If
      Throw ex
    Finally
      cmdLib.Dispose()
      cmdAut = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try

  End Sub

  Public Function ListarLibros(ByVal wNombre As String) As List(Of Libro)
    Dim la As New List(Of Libro)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liLibros_Nombre", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Nombre", wNombre)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        la.Add(New Libro(CInt(dr.Item("CodigoLibro")), dr.Item("nombre").ToString, dr.Item("comentario").ToString, dr.Item("Abreviatura").ToString, 0))
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

  Public Function LeerAutor(ByVal wLibro As Libro) As List(Of Autor)
    Dim la As New List(Of Autor)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAutor_Libro", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoLibro ", wLibro.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        la.Add(New Autor(CInt(dr.Item("CodigoAutor")), dr.Item("Nombres").ToString, dr.Item("Apellidos").ToString))
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

  Public Sub Actualizar(ByVal wLibro As Libro, ByVal wListaAutor As List(Of Autor))
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmdLib As New SqlCommand("pr_aLibro", cn)
    Dim cmdAut As New SqlCommand("pr_aAutor", cn)

    Dim trx As SqlTransaction = Nothing

    cmdLib.CommandType = CommandType.StoredProcedure

    Try
      cn.Open()
      trx = cn.BeginTransaction

      cmdLib.Transaction = trx
      cmdLib.CommandType = CommandType.StoredProcedure
      With (cmdLib.Parameters)
        .AddWithValue("@CodigoLibro", wLibro.Codigo)
        .AddWithValue("@Titulo", wLibro.Titulo)
        .AddWithValue("@Descripcion", wLibro.Descripcion)
        .AddWithValue("@Abreviatura", wLibro.Abreviatura)

      End With
      cmdLib.ExecuteNonQuery()
      '-----------------------------REGISTRO DE AUTORES---------------------------------
      cmdAut.Transaction = trx
      cmdAut.CommandType = CommandType.StoredProcedure
      With cmdAut.Parameters
        .AddWithValue("@CodigoLibro", 0)
        .AddWithValue("@CodigoAutor", 0)
        .AddWithValue("@Nombres", "")
        .AddWithValue("@Apellidos", "")
      End With

      For Each objAutor As Autor In wListaAutor
        With cmdAut.Parameters
          .Item("@CodigoLibro").Value = wLibro.Codigo
          .Item("@CodigoAutor").Value = objAutor.Codigo
          .Item("@Nombres").Value = objAutor.Nombres
          .Item("@Apellidos").Value = objAutor.Apellidos
        End With
        cmdAut.ExecuteNonQuery()
      Next
      trx.Commit()
    Catch ex As Exception
      If trx IsNot Nothing Then
        trx.Rollback()
      End If
      Throw ex
    Finally
      cmdLib.Dispose()
      cmdAut = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try

  End Sub

  Public Function ListarAutores(ByVal wNombre As String) As List(Of Autor)
    Dim la As New List(Of Autor)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAutores_Nombre", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Nombre", wNombre)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        la.Add(New Autor(CInt(dr.Item("CodigoAutor")), dr.Item("nombres").ToString, dr.Item("apellidos").ToString))
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

  Public Sub RegistrarAutor(ByVal obj As Autor)
    Dim cn As New SqlConnection(My.Settings.Conexion)

    Dim cmd As New SqlCommand("pr_iAutorSolo", cn)
    cmd.CommandType = CommandType.StoredProcedure

    With cmd.Parameters
      .AddWithValue("@Nombres", obj.Nombres)
      .AddWithValue("@Apellidos", obj.Apellidos)
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

  Public Sub ActualizarAutor(ByVal obj As Autor)
    Dim cn As New SqlConnection(My.Settings.Conexion)

    Dim cmd As New SqlCommand("pr_aAutorSolo", cn)
    cmd.CommandType = CommandType.StoredProcedure

    With cmd.Parameters
      .AddWithValue("@CodigoAutor", obj.Codigo)
      .AddWithValue("@Nombres", obj.Nombres)
      .AddWithValue("@Apellidos", obj.Apellidos)
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

  Public Function LeerAutor_Codigo(ByVal obj As Autor) As Autor
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lAutor_Codigo", cn)
    Dim dr As SqlDataReader = Nothing
    Dim l As Autor = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoAutor", obj.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      If dr.Read = True Then
        l = New Autor(obj.Codigo, dr.Item("nombres").ToString, dr.Item("apellidos").ToString)
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

    Return l
  End Function

  Public Function ListarLibros_Grupo(ByVal wsec As Seccion, ByVal anio As String, ByVal wcodigoPres As Integer) As List(Of Libro)
    Dim la As New List(Of Libro)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lGrupos_Libros", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoPresFecha", wcodigoPres)
    cmd.Parameters.AddWithValue("@Anio", anio)
    cmd.Parameters.AddWithValue("@CodigoG", wsec.Grado.Codigo)
    cmd.Parameters.AddWithValue("@Letra", wsec.Letra)

    Try
      cn.Open()
      dr = cmd.ExecuteReader

      While dr.Read
        la.Add(New Libro(CInt(dr.Item("CodigoLibro")), dr.Item("nombre").ToString, dr.Item("comentario").ToString, dr.Item("Abreviatura").ToString, 0))
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

  Public Function ListarLibros_Grado(ByVal wGrado As Grado, ByVal wAnio As AnioLectivo) As List(Of GradoLibro)
    Dim lista As New List(Of GradoLibro)
    Dim dr As SqlDataReader = Nothing
    Dim pars As New List(Of CParametro)
    Dim gl As GradoLibro
    Dim iCodigoDoc, iNombreDoc, iApPat, iApMat As Integer

    pars.AddRange(New CParametro() {New CParametro("@CodigoG", wGrado.Codigo), _
                                    New CParametro("@Anio", wAnio.Anio)})

    Try
      Me.Conectar(False)

      dr = Me.PedirDataReader("pr_liLibros_Grado", pars)
      iCodigoDoc = dr.GetOrdinal("codigoDocente")
      iNombreDoc = dr.GetOrdinal("NombreDocente")
      iApPat = dr.GetOrdinal("ApellidoPat")
      iApMat = dr.GetOrdinal("ApellidoMat")
      While dr.Read
        gl = New GradoLibro(CInt(dr.Item("CodigoGL")), CInt(dr.Item("CodigoG")), _
                              New Libro(CInt(dr.Item("CodigoLibro")), dr.Item("nombre").ToString, "", "", 0), _
                              wAnio.Anio, CBool(dr.Item("vigencia")))
        gl.Responsable = dr.Item("Responsable").ToString
        If dr.IsDBNull(iCodigoDoc) = False Then
          gl.Docente = New Docente With {.Codigo = dr.GetInt32(iCodigoDoc), _
                                         .Nombre = dr.GetString(iNombreDoc), _
                                        .ApellidoPaterno = dr.GetString(iApPat), _
                                        .ApellidoMaterno = dr.GetString(iApMat)}
        End If
        lista.Add(gl)
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars.Clear()
      pars = Nothing
    End Try

    Return lista
  End Function

  Public Function ListarLibroGradoVigentes(ByVal wGrado As Grado, ByVal wAnio As AnioLectivo) As List(Of GradoLibro)
    Dim lista As New List(Of GradoLibro)
    Dim dr As SqlDataReader = Nothing
    Dim pars As New List(Of CParametro)
    Dim gl As GradoLibro

    pars.AddRange(New CParametro() {New CParametro("@CodigoG", wGrado.Codigo), _
                                    New CParametro("@Anio", wAnio.Anio)})

    Try
      Me.Conectar(False)

      dr = Me.PedirDataReader("pr_liLibroGrado_Vigentes", pars)
      While dr.Read
        gl = New GradoLibro(CInt(dr.Item("CodigoGL")), wGrado.Codigo, _
                              New Libro(CInt(dr.Item("CodigoLibro")), dr.Item("nombre").ToString, "", "", 0), _
                              wAnio.Anio, True)
        lista.Add(gl)
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars.Clear()
      pars = Nothing
    End Try

    Return lista
  End Function

  Public Sub RegistrarGrado_Libro(ByVal obj As GradoLibro)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iLibro_Grado", cn)
    Dim CodigoDocente As Object = DBNull.Value

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoG", obj.CodigoGrado)
      .AddWithValue("@CodigoLibro", obj.Libro.Codigo)
      .AddWithValue("@Anio", obj.Anio)
      .AddWithValue("@Responsable", obj.Responsable)
      If obj.Responsable = "D" Then
        CodigoDocente = obj.Docente.Codigo
      End If
      .AddWithValue("@Docente", CodigoDocente)
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

  Public Sub ActualizarGrado_Libro(ByVal obj As GradoLibro)
    Dim pars As New List(Of CParametro)
    Dim CodigoDocente As Object = DBNull.Value

    If obj.Responsable = "D" Then
      CodigoDocente = obj.Docente.Codigo
    End If
    pars.AddRange(New CParametro() {New CParametro("@CodigoGL", obj.Codigo), _
                                        New CParametro("@CodigoG", obj.CodigoGrado), _
                                        New CParametro("@CodigoLibro", obj.Libro.Codigo), _
                                        New CParametro("@Anio", obj.Anio), _
                                        New CParametro("@Vigencia", obj.Vigencia), _
                                        New CParametro("@Responsable", obj.Responsable), _
                                        New CParametro("@Docente", codigodocente)})

    Try
      Me.Conectar(False)
      Me.EjecutarOrden("pr_aLibro_Grado", pars)
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars.Clear()
      pars = Nothing
    End Try

  End Sub

  'Lista todos los alumnos de una sección, detallando el libro que se la ha asignado
  Public Function ListarLibrosAsignados(ByVal wSeccion As Seccion, ByVal wPresentacion As Presentacion, ByVal wLibros As List(Of GradoLibro)) As DataTable
    Dim dt As DataTable = Nothing
    Dim sql As String = ""

    sql = "SELECT M.nroMatricula, P.apellidoPat + ' ' + P.apellidoMat + ' ' + P.nombre AS Alumno "
    For Each gl As GradoLibro In wLibros
      sql &= ", CAST ( ISNULL( ( SELECT TOP 1 1 " & _
          "FROM PROGRAMACION_LECTURA PL " & _
          "WHERE(PL.nroMatricula = M.nroMatricula And PL.codigoPresFecha = " & wPresentacion.Codigo & " AND PL.codigoLibro = " & gl.Libro.Codigo & " AND PL.vigencia = 1) " & _
          "), 0) AS BIT ) AS '" & gl.Libro.Titulo & "' "
    Next
    sql &= "FROM Persona P JOIN Matricula M ON P.codigoPersona = M.codigoAlumno " & _
      "WHERE M.anio = " & wSeccion.Anio.Anio & " AND M.codigoG = " & wSeccion.Grado.Codigo & " AND M.letra = '" & wSeccion.Letra & "' AND M.vigencia = 1 " & _
      "ORDER BY Alumno ASC"

    Try
      Me.Conectar(False)
      dt = Me.EjecutarSQLDatos(sql)
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    End Try

    Return dt
  End Function

  'Registra la asignación de un libro a un alumno
  Public Sub ProgramarLectura(ByVal wProgramacion As ProgramacionLectura)
    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@Matricula", wProgramacion.Matricula.Numero), _
                                    New CParametro("@Libro", wProgramacion.Libro.Codigo), _
                                    New CParametro("@Tipo", wProgramacion.Tipo), _
                                    New CParametro("@Presentacion", wProgramacion.Presentacion.Codigo), _
                                    New CParametro("@Grupo", wProgramacion.NroGrupo), _
                                    New CParametro("@Vigencia", wProgramacion.Vigencia)})

    Try
      Me.Conectar(False)
      Me.EjecutarOrden("pr_aAsignarLibroAlumno", pars)

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      pars.Clear()
      pars = Nothing
    End Try
  End Sub

  'Registra la asignación de los libros a los alumnos
  Public Function ProgramarLectura(ByVal wProgramaciones As List(Of ProgramacionLectura)) As List(Of Integer)
    Dim pars As New List(Of CParametro)
    Dim posiciones As New List(Of Integer)
    Dim pos As Integer = -1

    pars.AddRange(New CParametro() {New CParametro("@Matricula", Nothing), _
                                    New CParametro("@Libro", Nothing), _
                                    New CParametro("@Tipo", Nothing), _
                                    New CParametro("@Presentacion", Nothing), _
                                    New CParametro("@Grupo", Nothing), _
                                    New CParametro("@Vigencia", Nothing)})
    Try
      Me.Conectar(False)
      For Each pl As ProgramacionLectura In wProgramaciones
        pars.Item(0).Valor = pl.Matricula.Numero
        pars.Item(1).Valor = pl.Libro.Codigo
        pars.Item(2).Valor = pl.Tipo
        pars.Item(3).Valor = pl.Presentacion.Codigo
        pars.Item(4).Valor = pl.NroGrupo
        pars.Item(5).Valor = pl.Vigencia
        Try
          pos += 1
          Me.EjecutarOrden("pr_aAsignarLibroAlumno", pars)
        Catch ex As Exception
          posiciones.Add(pos)
        End Try
      Next

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      pars.Clear()
      pars = Nothing
    End Try

    Return posiciones
  End Function

    'Tania Incio
    'Devuelve libro por codigo ProgLectura
    Public Function LibroXcodProgLectura(ByVal codProgrLectura As Integer) As Libro
        Dim pars As New List(Of CParametro)
        Dim libro As Libro = Nothing
        pars.AddRange({New CParametro("@codigoP", codProgrLectura)})

        Try
            Me.Conectar(False)
            Dim dr = Me.PedirDataReader("pr_LibroxCodProgLectura", pars)
            If dr.Read Then
                Dim i = CInt(dr.Item("codigoLibro"))
                libro = New Libro(
                    CInt(dr.Item("codigoLibro")), dr.GetString(dr.GetOrdinal("nombre")), dr.GetString(dr.GetOrdinal("abreviatura")),
                    dr.GetString(dr.GetOrdinal("comentario")), 0)
            End If
            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw New Exception(ex.Message)
        Finally
            pars.Clear()
            pars = Nothing
        End Try
        Return libro
    End Function

    'Devuelve grado por codigoProgLectura
    Public Function GradoXcodProgLectura(ByVal codProgLectura As Integer) As Grado
        Dim pars As New List(Of CParametro)
        Dim grado As Grado = Nothing
        pars.AddRange({New CParametro("@codigoP", codProgLectura)})

        Try
            Me.Conectar(False)
            Dim dr = Me.PedirDataReader("pr_GradoxCodProgLectura", pars)
            If dr.Read Then
                grado = New Grado(CInt(dr.Item("codigoG")))
            End If
            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw New Exception(ex.Message)
        Finally
            pars.Clear()
            pars = Nothing
        End Try
        Return grado
    End Function

    'Lista libros segun Grado y AnioLectivo
    Public Function ListarLibroGradoAnio(ByVal grado As Grado, ByVal anio As AnioLectivo) As List(Of Libro)
        Dim lista As New List(Of Libro)
        Dim dr As SqlDataReader = Nothing
        Dim pars As New List(Of CParametro)
        Dim libro As Libro

        pars.AddRange({New CParametro("@codigoG", grado.Codigo), _
                       New CParametro("@anio", anio.Anio)})

        Try
            Me.Conectar(False)
            dr = Me.PedirDataReader("pr_liLibrosGradoAnio", pars)
            While dr.Read
                libro = New Libro(
                        CInt(dr.Item("codigoLibro")), dr.GetString(dr.GetOrdinal("nombre")), dr.GetString(dr.GetOrdinal("abreviatura")),
                        dr.GetString(dr.GetOrdinal("comentario")), 0)
                lista.Add(libro)
            End While

            Me.Cerrar(True)
        Catch ex As Exception
            Me.Cerrar(False)
            Throw ex
        Finally
            pars.Clear()
            pars = Nothing
        End Try

        Return lista
    End Function

    'Devuelve el codProgLectura segun nombre del libro
    Public Function getCodProgLectura(ByVal libro As String, ByVal nroM As Integer) As Integer
        Dim dr As SqlDataReader = Nothing
        Dim pars As New List(Of CParametro)
        Dim res As Integer
        pars.AddRange({New CParametro("nombre", libro), _
                      New CParametro("nroM", nroM)})

        Try
            Me.Conectar(False)
            dr = Me.PedirDataReader("pr_CodProgLecturaXLibro", pars)
            If dr.Read Then
                res = CInt(dr.Item("codigoProgLect"))
            Else
                res = 0
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return res
    End Function

End Class
