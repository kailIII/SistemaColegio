Public Class RNNotaLectura
  Inherits CADO

  Public Sub Registrar(ByVal obj As NotaLectura)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iNotaLectura", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@NroMatricula", obj.Matricula.Numero)
      .AddWithValue("@Letra", obj.Nota)
      .AddWithValue("@Comentario", obj.Comentario)
      .AddWithValue("@CodProgLect", obj.ProgLectura.Codigo)
      .AddWithValue("@CodPersonal", obj.Personal)
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

  Public Function LeerNota(ByVal Obj As NotaLectura) As NotaLectura
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lNotaLectura", cn)
    Dim dr As SqlDataReader
    Dim nota As NotaLectura = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@NroMatricula", Obj.Matricula.Numero)
    cmd.Parameters.AddWithValue("@CodProgLect", Obj.ProgLectura.Codigo)

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read Then
        nota = New NotaLectura(CInt(dr.Item("codigoNotaLect")), dr.Item("letra").ToString)
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

    Return nota
  End Function

  Public Sub RegistrarNuevaNota(ByVal obj As NotaLectura)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iNuevaNotaLectura", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoNota", obj.Codigo)
      .AddWithValue("@Letra", obj.Nota)
      .AddWithValue("@Comentario", obj.Comentario)
      .AddWithValue("@codPersonal", obj.Personal)
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

  'Tania Incio
  Public Sub RegistrarNotaRecuperacion(ByVal codigo As Integer, ByVal codP As Integer, ByVal codProgLect As Integer, ByVal codLibro As Integer, ByVal letra As String, ByVal comentario As String)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iNotaLecturaRecuperacion", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigoNota", codigo)
      .AddWithValue("@letra", letra)
      .AddWithValue("@comentario", comentario)
      .AddWithValue("@codPersonal", codP)
      .AddWithValue("@codigoLibro", codLibro)
      .AddWithValue("@codProgLect", codProgLect)
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

  Public Function ListarAlumnosPresentacion(ByVal obj As Seccion, ByVal pres As Presentacion, ByVal anio As String) As List(Of NotaLectura)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAlumnosLecturaNota", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lm As List(Of NotaLectura) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Anio", anio)
      .AddWithValue("@Letra", obj.Letra)
      .AddWithValue("@CodigoG", obj.Grado.Codigo)
      .AddWithValue("@CodigoPres", pres.Codigo)
    End With
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lm = New List(Of NotaLectura)
      Do While dr.Read
        lm.Add(New NotaLectura(New Matricula(CInt(dr.Item("nroMatricula")), New Alumno(CInt(dr.Item("codigoPersona")), CStr(dr.Item("nombre")), _
                            CStr(dr.Item("apellidoPat")), CStr(dr.Item("apellidoMat"))), CInt(dr.Item("nroOrden"))), _
                            CStr(IIf(IsDBNull(dr.Item("letra")) = True, "", dr.Item("letra"))), dr.Item("comentario").ToString, _
                            New ProgramacionLectura(CInt(dr.Item("codigoProgLect")), New Libro(dr.Item("Libro").ToString, Nothing))))

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

  Public Function ListarAlumnosPresentacionDocente(ByVal wPresentacion As Presentacion, ByVal wAnio As AnioLectivo, ByVal wDocente As Docente) As List(Of NotaLectura)
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader = Nothing
    Dim lm As List(Of NotaLectura) = Nothing

    pars.AddRange(New CParametro() {New CParametro("@Anio", wAnio.Anio), _
                                    New CParametro("@CodigoPres", wPresentacion.Codigo), _
                                    New CParametro("@Docente", wDocente.Codigo)})

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liAlumnosLecturaNotaDocente", pars)
      lm = New List(Of NotaLectura)
      Do While dr.Read
        lm.Add(New NotaLectura(New Matricula(CInt(dr.Item("nroMatricula")), _
                                             New Alumno(CInt(dr.Item("codigoPersona")), dr.Item("nombre").ToString, _
                                                    dr.Item("apellidoPat").ToString, CStr(dr.Item("apellidoMat"))), _
                                              0), _
                            "", dr.Item("comentario").ToString, _
                            New ProgramacionLectura(CInt(dr.Item("codigoProgLect")), _
                                                    New Libro(dr.Item("Libro").ToString, Nothing))))

        With lm.Item(lm.Count - 1)
          If dr.IsDBNull(dr.GetOrdinal("CodigoNotaLect")) = False Then
            .Codigo = CInt(dr.Item("CodigoNotaLect"))
          End If
          .Nota = dr.Item("Calificacion").ToString
          'Tania
          .NotaRecuperacion = dr.Item("CalificacionR").ToString
          .LibroRecuperacion = dr.Item("LibroR").ToString

          .Matricula.Seccion = New Seccion
          With .Matricula.Seccion
            .Grado = New Grado With {.Numero = CInt(dr.Item("Numero")), _
                                     .Nivel = New Nivel With {.Siglas = dr.Item("Siglas").ToString}}
            .Letra = dr.Item("Letra").ToString
          End With
        End With
      Loop
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars.Clear()
      pars = Nothing
    End Try
    Return lm
  End Function

  Public Function ListarAlumnosLibretaPlanLector(ByVal obj As Seccion, ByVal pres As Presentacion, ByVal anio As String) As List(Of NotaLectura)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAlumnosLibretaPL", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lm As List(Of NotaLectura) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Anio", anio)
      .AddWithValue("@Letra", obj.Letra)
      .AddWithValue("@CodigoG", obj.Grado.Codigo)
      .AddWithValue("@CodigoPres", pres.Codigo)

    End With
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lm = New List(Of NotaLectura)
      Do While dr.Read
        lm.Add(New NotaLectura(New Matricula(CInt(dr.Item("nroMatricula")), New Alumno(CInt(dr.Item("codigoPersona")), CStr(dr.Item("nombre")), _
                            CStr(dr.Item("apellidoPat")), CStr(dr.Item("apellidoMat"))), CInt(dr.Item("nroOrden"))), _
                            CStr(IIf(IsDBNull(dr.Item("letra")) = True, "", dr.Item("letra"))), dr.Item("comentario").ToString, _
                            New ProgramacionLectura(CInt(dr.Item("codigoProgLect")), New Libro(dr.Item("Libro").ToString, Nothing))))

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

  Public Function ListarNotasLibros_NroMat(ByVal NroMatricula As Integer) As List(Of NotaLectura)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liNotaPL_NroMatricula", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lm As List(Of NotaLectura) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@NroMatricula", NroMatricula)
    End With
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lm = New List(Of NotaLectura)
      Do While dr.Read
        lm.Add(New NotaLectura( _
              New Matricula(CInt(dr.Item("nroMatricula"))), _
              dr.Item("letra").ToString, dr.Item("comentario").ToString, _
              New ProgramacionLectura(CInt(dr.Item("codigoProgLect")), New Libro(dr.Item("Libro").ToString, Nothing), _
                                       New Presentacion() With {.Numero = CInt(dr.Item("Nro"))}) _
            ) _
          )
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

  Public Sub RegistrarNotas(ByVal wNotas As List(Of NotaLectura))
    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@NroMatricula", 0), _
                                    New CParametro("@Letra", ""), _
                                    New CParametro("@Comentario", ""), _
                                    New CParametro("@CodProgLect", 0), _
                                    New CParametro("@CodPersonal", 0)})
    Try
      Me.Conectar(True)
      pars.Item(2).Valor = ""
      For Each nl As NotaLectura In wNotas
        pars.Item(0).Valor = nl.Matricula.Numero
        pars.Item(1).Valor = nl.Nota
        pars.Item(3).Valor = nl.ProgLectura.Codigo
        pars.Item(4).Valor = nl.Personal

        Me.EjecutarOrden("pr_iNotaLectura", pars)
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

  'Tania Incio
  'Listado de notas de plan lector incluida la recuperacion
  Public Function ListarNotasLecturaNroMatricula(ByVal nroMatricula As Integer) As List(Of NotaLectura)
    Dim pars As New List(Of CParametro)
    Dim notas As New List(Of NotaLectura)
    Dim dr As SqlDataReader
    Dim nombreLibro As Integer, nota As Integer, notaRecuperacion As Integer
    pars.AddRange(New CParametro() {New CParametro("@nroMatricula", nroMatricula)})

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liNotaPlanLectorXNroMatricula", pars)
      nombreLibro = dr.GetOrdinal("nombreLibro")
      nota = dr.GetOrdinal("Nota")
      notaRecuperacion = dr.GetOrdinal("NotaRecuperacion")
      While dr.Read
        notas.Add(New NotaLectura(dr.GetString(nota), dr.GetString(notaRecuperacion),
                                  New ProgramacionLectura(0, New Libro(dr.GetString(nombreLibro), ""))))
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      pars = Nothing
    End Try

    Return notas
  End Function

End Class
