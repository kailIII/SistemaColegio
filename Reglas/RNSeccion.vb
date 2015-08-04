Public Class RNSeccion
  Inherits CADO

  Public Sub Registrar(ByVal ws As Seccion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iSeccion", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigoG", ws.Grado.Codigo)
      .AddWithValue("@anio", ws.Anio.Anio)
      .AddWithValue("@letra", ws.Letra)
      .AddWithValue("@codigoTutor", ws.Tutor.Codigo)
      .AddWithValue("@vacantes", ws.Vacantes)
      .AddWithValue("@vigencia", ws.Vigencia)
      .AddWithValue("@descripcion", ws.Descripcion)
      .AddWithValue("@codigoTurno", ws.Turno.Codigo)
      .AddWithValue("@codigoAula", ws.Aula.Codigo)
      .AddWithValue("@tipoCalif", ws.Grado.TipoCalif)
      .AddWithValue("@evalComp", ws.Grado.EvaluacionComp)
      .AddWithValue("@tipoComp", ws.Grado.TipoEval)
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

  Public Sub Modificar(ByVal ws As Seccion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aSeccion", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigoG", ws.Grado.Codigo)
      .AddWithValue("@anio", ws.Anio.Anio)
      .AddWithValue("@letra", ws.Letra)
      .AddWithValue("@codigoTutor", ws.Tutor.Codigo)
      .AddWithValue("@vacantes", ws.Vacantes)
      .AddWithValue("@vigencia", ws.Vigencia)
      .AddWithValue("@descripcion", ws.Descripcion)
      .AddWithValue("@codigoTurno", ws.Turno.Codigo)
      .AddWithValue("@codigoAula", ws.Aula.Codigo)
      .AddWithValue("@tipoCalif", ws.Grado.TipoCalif)
      .AddWithValue("@evalComp", ws.Grado.EvaluacionComp)
      .AddWithValue("@tipoComp", ws.Grado.TipoEval)
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

  Public Function Listar(ByVal obj As Seccion) As List(Of Seccion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liSecciones", cn)
    Dim dr As SqlDataReader = Nothing
    Dim s As Seccion = Nothing
    Dim ListSec As List(Of Seccion) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Anio", obj.Anio.Anio)
    cmd.Parameters.AddWithValue("@CodigoG", obj.Grado.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ListSec = New List(Of Seccion)
      Do While (dr.Read)
        ListSec.Add(New Seccion(obj.Grado, CChar(dr.Item("letra")), _
                              New Aula(CInt(dr.Item("codigoAula")), "", 0), _
                              New Turno(CInt(dr.Item("codigoTurno"))), _
                              New Docente(CInt(dr.Item("codigoTutor"))), 0, dr.Item("descripcion").ToString))
      Loop
    Catch ex As Exception
      If ListSec IsNot Nothing Then
        ListSec.Clear()
      End If
      s = Nothing
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
    Return ListSec
  End Function

  Public Function Listar2(ByVal obj As Seccion) As List(Of Seccion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liSecciones2", cn)
    Dim dr As SqlDataReader = Nothing
    Dim s As Seccion = Nothing
    Dim ListSec As List(Of Seccion) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Anio", obj.Anio.Anio)
    cmd.Parameters.AddWithValue("@CodigoG", obj.Grado.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ListSec = New List(Of Seccion)
      Do While (dr.Read)
        ListSec.Add(New Seccion(obj.Grado, CChar(dr.Item("letra")), _
                              New Aula(CInt(dr.Item("codigoAula")), "", 0), _
                              New Turno(CInt(dr.Item("codigoTurno"))), _
                              New Docente(CInt(dr.Item("codigoTutor"))), 0, dr.Item("descripcion").ToString))
        With ListSec.Item(ListSec.Count - 1)
          .Anio = obj.Anio
        End With
      Loop
    Catch ex As Exception
      If ListSec IsNot Nothing Then
        ListSec.Clear()
      End If
      s = Nothing
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
    Return ListSec
  End Function

  Public Function LeerNroSecciones(ByVal objSeccion As Seccion) As Integer
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lNroSecciones", cn)
    Dim dr As Integer

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Anio", objSeccion.Anio.Anio)
    cmd.Parameters.AddWithValue("@CodigoNivel", objSeccion.Grado.Nivel.Codigo)
    cmd.Parameters.AddWithValue("@NombreGrado", objSeccion.Grado.Nombre)

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

  Public Function LeerNroSeccionesGrado(ByVal objSeccion As Seccion, ByVal objA As AnioLectivo) As Integer
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lNro_Sec_Grado", cn)
    Dim dr As Integer

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Numero", objSeccion.Grado.Numero)
    cmd.Parameters.AddWithValue("@CodigoNivel", objSeccion.Grado.CodigoNivel)
    cmd.Parameters.AddWithValue("@Anio", objA.Anio)

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

  Public Function LeerDatosSeccion(ByVal objSec As Seccion) As List(Of Seccion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lDatosSeccion", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ListSec As List(Of Seccion) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoNivel", objSec.Grado.Nivel.Codigo)
    cmd.Parameters.AddWithValue("@NombreGrado", objSec.Grado.Nombre)
    cmd.Parameters.AddWithValue("@Letra", objSec.Letra.ToString)
    cmd.Parameters.AddWithValue("@Anio", objSec.Anio.Anio)

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ListSec = New List(Of Seccion)
      Do While (dr.Read)
        ListSec.Add(New Seccion(New Grado(CInt(dr.Item("codigoG")), CInt(dr.Item("numero")), _
                                          dr.Item("nombre").ToString, New Nivel(CInt(dr.Item("CodigoNivel")), "", ""), _
                                          "", dr.Item("caracteristica").ToString, "", ""), _
                                CChar(dr.Item("letra")), _
                              New Aula(0, "", 0), _
                              New Turno(0, dr.Item("nombreTurno").ToString), _
                              New Docente(0), 0, ""))
      Loop
    Catch ex As Exception
      If ListSec IsNot Nothing Then
        ListSec.Clear()
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
    Return ListSec
  End Function

  Public Function Leer_NivelAcad(ByVal wAnio As AnioLectivo, ByVal wNivel As Nivel, ByVal wVigencia As Byte, Optional ByVal wAsistencia As Boolean = False) As List(Of Seccion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liSeccionesNivel", cn)
    Dim dr As SqlDataReader = Nothing
    Dim sec As Seccion = Nothing
    Dim ListS As List(Of Seccion) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@anio", wAnio.Anio)
    cmd.Parameters.AddWithValue("@CodigoNivel", wNivel.Codigo)
    cmd.Parameters.AddWithValue("@vigencia", wVigencia)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ListS = New List(Of Seccion)
      If wAsistencia Then
        ListS.Add(New Seccion)
      End If
      Do While (dr.Read)
        ListS.Add(New Seccion(wAnio, New Grado(CInt(dr.Item("codigoG")), CInt(dr.Item("numero"))), CChar(dr.Item("letra"))))
        ListS.Item(ListS.Count - 1).Grado.Nivel = wNivel
      Loop
    Catch ex As Exception
      If ListS IsNot Nothing Then
        ListS.Clear()
      End If
      sec = Nothing
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
    Return ListS
    'Return Nothing
  End Function

  Public Function Leer_Anio(ByVal wa As AnioLectivo) As List(Of Seccion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lSeccionGradoNAcad", cn)
    Dim dr As SqlDataReader = Nothing
    Dim s As Seccion = Nothing
    Dim ListS As List(Of Seccion) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@anio", wa.Anio)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ListS = New List(Of Seccion)
      Do While (dr.Read)
        ListS.Add(New Seccion(False, wa, New Grado(CInt(dr.Item("codigoG")), CInt(dr.Item("numero")), "", _
                                            New Nivel(Nothing, CStr(dr.Item("NombreNivel")), ""), "", "", "", ""), CChar(dr.Item("letra")), New Aula(), New Turno(), New Docente(CInt(dr.Item("codigoDocente")), dr.Item("nombre").ToString, dr.Item("ApellidoPat").ToString, dr.Item("ApellidoMat").ToString, 0), CInt(0), "".ToString))
      Loop
    Catch ex As Exception
      If ListS IsNot Nothing Then
        ListS.Clear()
      End If
      s = Nothing
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
    Return ListS
  End Function

  Public Function LeerSeccion_Anio(ByVal wAnio As AnioLectivo) As List(Of Seccion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lSeccion", cn)
    Dim dr As SqlDataReader = Nothing
    Dim s As Seccion = Nothing
    Dim ListS As List(Of Seccion) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@anio", wAnio.Anio)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ListS = New List(Of Seccion)
      Do While (dr.Read)
        ListS.Add(New Seccion(False, wAnio, _
                              New Grado(CInt(dr.Item("codigoG")), CInt(dr.Item("numero")), "", _
                                        New Nivel(Nothing, dr.Item("nombreNivel").ToString, dr.Item("Siglas").ToString), _
                                        dr.Item("tipoCalif").ToString, "", dr.Item("evalComp").ToString, dr.Item("tipoComp").ToString), _
                              CChar(dr.Item("letra")), _
                              New Aula(CInt(dr.Item("codigoAula")), "", CInt(dr.Item("numero"))), _
                              New Turno(CInt(dr.Item("codigoTurno")), dr.Item("nombreTurno").ToString), _
                              New Docente(CInt(dr.Item("codigoDocente")), dr.Item("nombre").ToString, _
                                          dr.Item("ApellidoPat").ToString, dr.Item("ApellidoMat").ToString, 0), _
                              CInt(dr.Item("vacantes")), dr.Item("descripcion").ToString) _
                              )
      Loop
    Catch ex As Exception
      If ListS IsNot Nothing Then
        ListS.Clear()
      End If
      s = Nothing
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
    Return ListS
  End Function

  Public Function Leer_Grado(ByVal wa As AnioLectivo, ByVal wGrado As Grado, ByVal vig As Byte) As List(Of Seccion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liSeccionesGrado", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ListS As List(Of Seccion) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@anio", wa.Anio)
    cmd.Parameters.AddWithValue("@codigoG", wGrado.Codigo)

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ListS = New List(Of Seccion)
      Do While (dr.Read)
        'New Grado(CInt(dr.Item("codigoG")), CInt(dr.Item("numero")), dr.Item("nombre").ToString, New Nivel(), "", "", "", ""), _
        wGrado.Numero = CInt(dr.Item("Numero"))
        'wGrado.Nombre = dr.Item("Nombre").ToString
        ListS.Add(New Seccion(CBool(dr.Item("vigencia")), wa, wGrado, CChar(dr.Item("letra")), _
                               New Aula(CInt(dr.Item("codigoAula")), dr.Item("tipo").ToString, _
                                        New Local(dr.Item("codigoLocal").ToString), _
                                        CInt(dr.Item("NumeroAula")), 0), _
                               New Turno(CInt(dr.Item("codigoTurno")), dr.Item("nombreTurno").ToString), _
                               New Docente(CInt(dr.Item("codigoTutor")), dr.Item("Nombre").ToString, dr.Item("ApellidoPat").ToString, dr.Item("ApellidoMat").ToString, 0), _
                               CInt(dr.Item("vacantes")), dr.Item("descripcion").ToString) _
                  )
      Loop
    Catch ex As Exception
      If ListS IsNot Nothing Then
        ListS.Clear()
      End If
      's = Nothing
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
    Return ListS
  End Function

  Public Function LeerVacantesSeccion(ByVal objSeccion As Seccion) As Integer
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lVacantesSec", cn)
    Dim dr As Integer

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@codigoG", objSeccion.Grado.Codigo)
    cmd.Parameters.AddWithValue("@anio", objSeccion.Anio.Anio)
    cmd.Parameters.AddWithValue("@letra", objSeccion.Letra)

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

  Public Function LeerNivelNumSec(ByVal obj As Seccion) As List(Of Seccion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liNivelGradoSec", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ls As List(Of Seccion) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Anio", obj.Anio.Anio)
    Try
      cn.Open()
      ls = New List(Of Seccion)
      dr = cmd.ExecuteReader
      Do While dr.Read
        ls.Add(New Seccion(obj.Anio, _
                           New Grado(CInt(dr.Item("codigoG")), CInt(dr.Item("numero")), "", _
                                      New Nivel(CInt(dr.Item("codigoNivel")), "", dr.GetString(dr.GetOrdinal("siglas"))), "", "", "", ""), _
                           CChar(dr.Item("letra"))) _
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
    Return ls
  End Function

  Public Function ListarSeccionTutor(ByVal obj As Seccion) As List(Of Seccion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liSeccionTutor", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ls As List(Of Seccion) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Anio", obj.Anio.Anio)
    cmd.Parameters.AddWithValue("@CodigoTutor", obj.CodigoTutor)

    Try
      cn.Open()
      ls = New List(Of Seccion)
      dr = cmd.ExecuteReader
      Do While dr.Read
        ls.Add(New Seccion(obj.Anio, _
                            New Grado(CInt(dr.Item("codigoG")), CInt(dr.Item("numero")), "", _
                                      New Nivel(CInt(dr.Item("codigoNivel")), dr.Item("nombreNivel").ToString, dr.GetString(dr.GetOrdinal("siglas"))), _
                                      Nothing, Nothing, Nothing, dr.Item("tipoComp").ToString), _
                            CChar(dr.Item("letra"))))
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
    Return ls
  End Function

  Public Function ListarCargaSeccion(ByVal wSeccion As Seccion, ByVal wPeriodo As PeriodoAcademico) As List(Of DocenteCarga)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liGruposSeccion", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ls As List(Of DocenteCarga) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Periodo", wPeriodo.Codigo)
    cmd.Parameters.AddWithValue("@CodigoG", wSeccion.Grado.Codigo)
    cmd.Parameters.AddWithValue("@Letra", wSeccion.Letra)

    Try
      cn.Open()
      ls = New List(Of DocenteCarga)
      dr = cmd.ExecuteReader
      Do While dr.Read
        Dim ca As New CargaAcademica(0, New Curso(CInt(dr.Item("codigoCur")), dr.Item("nombreCur").ToString, 0, Nothing, Nothing, _
                   CBool(dr.Item("grupo")), CBool(dr.Item("rotativo")), Nothing), Nothing)
        Dim dc As New DocenteCarga(CInt(dr.Item("CodigoDocenteCarga")), dr.Item("Nombre").ToString, _
            New Docente(CInt(dr.Item("codigopersona")), dr.Item("NombreDocente").ToString, _
                        dr.Item("ApellidoPat").ToString, dr.Item("ApellidoMat").ToString), ca, wPeriodo)
        ls.Add(dc)
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
    Return ls
  End Function

  Public Function NombreTutor(ByVal obj As Seccion, ByVal anio As String) As String
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lNombreTutor", cn)
    Dim dr As String

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoG", obj.Grado.Codigo)
    cmd.Parameters.AddWithValue("@Letra", obj.Letra)
    cmd.Parameters.AddWithValue("@Anio", anio)

    Try
      cn.Open()
      dr = cmd.ExecuteScalar.ToString
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

  Public Function NombreDirector(ByVal obj As Seccion) As String
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lNombreDirector", cn)
    Dim dr As String

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoNivel", obj.Grado.CodigoNivel)

    Try
      cn.Open()
      dr = cmd.ExecuteScalar.ToString
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

  Public Function ListarSeccionTutorPlanLector(ByVal obj As Seccion) As List(Of Seccion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liSeccionPlanLectorTutor", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ls As List(Of Seccion) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Anio", obj.Anio.Anio)
    cmd.Parameters.AddWithValue("@CodigoTutor", obj.CodigoTutor)

    Try
      cn.Open()
      ls = New List(Of Seccion)
      dr = cmd.ExecuteReader
      Do While dr.Read
        ls.Add(New Seccion(New AnioLectivo(), New Grado(CInt(dr.Item("codigoG")), _
                                  CInt(dr.Item("numero")), "", New Nivel(CInt(dr.Item("codigoNivel")), _
                                dr.Item("nombreNivel").ToString, dr.GetString(dr.GetOrdinal("siglas"))), "", "", "", _
                                dr.Item("tipoComp").ToString), CChar(dr.Item("letra"))))
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
    Return ls
  End Function

  Public Function ListarSeccionesSec(ByVal obj As Seccion) As List(Of Seccion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liSeccionesSec", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ls As List(Of Seccion) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Anio", obj.Anio.Anio)
    Try
      cn.Open()
      ls = New List(Of Seccion)
      dr = cmd.ExecuteReader
      Do While dr.Read
        ls.Add(New Seccion(New AnioLectivo(obj.Anio.Anio), New Grado(CInt(dr.Item("codigoG")), CInt(dr.Item("numero")), "", _
                                              New Nivel(CInt(dr.Item("codigoNivel")), "", dr.GetString(dr.GetOrdinal("siglas"))), "", "", "", ""), _
                                              CChar(dr.Item("letra"))))
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
    Return ls
  End Function

  Public Function ListarSeccionTutorPlanLectorExportar(ByVal obj As Seccion) As List(Of Seccion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liSeccionPlanLectorExportar", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ls As List(Of Seccion) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Anio", obj.Anio.Anio)

    Try
      cn.Open()
      ls = New List(Of Seccion)
      dr = cmd.ExecuteReader
      Do While dr.Read
        ls.Add(New Seccion(New AnioLectivo(), New Grado(CInt(dr.Item("codigoG")), _
                                  CInt(dr.Item("numero")), "", New Nivel(CInt(dr.Item("codigoNivel")), _
                                dr.Item("nombreNivel").ToString, dr.GetString(dr.GetOrdinal("siglas"))), "", "", "", _
                                dr.Item("tipoComp").ToString), CChar(dr.Item("letra"))))
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
    Return ls
  End Function

  Public Function NombreCoordPlanLector() As String
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lNombreCoorPlanLector", cn)
    Dim dr As String

    cmd.CommandType = CommandType.StoredProcedure
    Try
      cn.Open()
      dr = cmd.ExecuteScalar.ToString

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

  Public Function ListarTutores(ByVal wAnio As AnioLectivo) As List(Of Seccion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liTutores", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ls As List(Of Seccion) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Anio", wAnio.Anio)
    Try
      cn.Open()
      ls = New List(Of Seccion)
      dr = cmd.ExecuteReader
      While dr.Read
        ls.Add(New Seccion(Nothing, Nothing, Nothing, _
                           New Docente(CInt(dr.Item("codigoTutor")), dr.Item("nombre").ToString, _
                                       dr.Item("apellidoPat").ToString, dr.Item("apellidoMat").ToString)))
        With ls.Item(ls.Count - 1)
          .Anio = wAnio
          .Grado = New Grado With {.Codigo = CInt(dr.Item("CodigoG")), .Numero = CInt(dr.Item("Numero")), _
                                   .TipoEval = dr.Item("tipoComp").ToString}
          .Grado.Nivel = New Nivel With {.Codigo = CInt(dr.Item("codigoNivel")), .Siglas = dr.Item("Siglas").ToString}
          .Letra = dr.Item("Letra").ToString
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

    Return ls
  End Function

  Public Function ListarAlumnosPlanLectorPromedio(ByVal wSeccion As Seccion, ByVal wPres As Presentacion, ByVal wNota As String) As List(Of NotaLectura)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAlumnosPlanLectorPromedio", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ln As List(Of NotaLectura)

    Dim iOrden As Integer, iNombre As Integer, iApPat As Integer, iApMat As Integer, iLib As Integer, iLet As Integer,
      iComent As Integer, iNotaRecuperacion As Integer

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Grado", IIf(wSeccion.Grado.Codigo > 0, wSeccion.Grado.Codigo, DBNull.Value))
      .AddWithValue("@Seccion", wSeccion.Letra)
      .AddWithValue("@Presentacion", wPres.Codigo)
      .AddWithValue("@Nota", wNota)
    End With

    Try
      cn.Open()
      ln = New List(Of NotaLectura)
      dr = cmd.ExecuteReader
      iOrden = dr.GetOrdinal("nroOrden")
      iApPat = dr.GetOrdinal("apellidoPat")
      iApMat = dr.GetOrdinal("apellidoMat")
      iNombre = dr.GetOrdinal("Nombre")
      iLib = dr.GetOrdinal("Libro")
      iLet = dr.GetOrdinal("Letra")
      iComent = dr.GetOrdinal("Comentario")
      iNotaRecuperacion = dr.GetOrdinal("notaRecuperacion")

      While dr.Read
        ln.Add(New NotaLectura() With {.Matricula = New Matricula() _
                  With {.NroOrden = dr.GetByte(iOrden), .Alumno = New Alumno() _
                      With {.Nombre = dr.GetString(iNombre), .ApellidoPaterno = dr.GetString(iApPat), .ApellidoMaterno = dr.GetString(iApMat)} _
                  }, _
                .ProgLectura = New ProgramacionLectura() With {.Libro = New Libro(dr.GetString(iLib), "")}, _
                .Comentario = dr.GetString(iComent), .Nota = dr.GetString(iLet), _
                .NotaRecuperacion = dr.GetString(iNotaRecuperacion)} _
            )
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


    Return ln
  End Function

  Public Function ListarAlumnosPlanLectorPromedio(ByVal wNivel As Nivel, ByVal wPresentacion As Presentacion, ByVal wNota As String) As List(Of NotaLectura)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liTodosAlumnosPlanLectorPromedio", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ln As List(Of NotaLectura)
    Dim iSiglasNiv As Integer, iGrado As Integer, iSec As Integer, iOrden As Integer, iNombre As Integer, iApPat As Integer,
      iApMat As Integer, iLib As Integer, iLet As Integer, iComent As Integer, iNotaRecuperacion As Integer

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Nivel", wNivel.Codigo)
      .AddWithValue("@Presentacion", wPresentacion.Codigo)
      .AddWithValue("@Nota", wNota)
    End With

    Try
      cn.Open()
      ln = New List(Of NotaLectura)
      dr = cmd.ExecuteReader
      iSiglasNiv = dr.GetOrdinal("Siglas")
      iGrado = dr.GetOrdinal("Numero")
      iSec = dr.GetOrdinal("Sec")
      iOrden = dr.GetOrdinal("nroOrden")
      iApPat = dr.GetOrdinal("apellidoPat")
      iApMat = dr.GetOrdinal("apellidoMat")
      iNombre = dr.GetOrdinal("Nombre")
      iLib = dr.GetOrdinal("Libro")
      iLet = dr.GetOrdinal("Letra")
      iComent = dr.GetOrdinal("Comentario")
      iNotaRecuperacion = dr.GetOrdinal("notaRecuperacion")
      While dr.Read
        ln.Add(New NotaLectura() With {.Matricula = New Matricula() _
                  With {.NroOrden = dr.GetByte(iOrden), .Alumno = New Alumno() _
                      With {.Nombre = dr.GetString(iNombre), .ApellidoPaterno = dr.GetString(iApPat), .ApellidoMaterno = dr.GetString(iApMat)}, _
                      .Letra = dr.GetString(iSec), .Grado = New Grado() _
                          With {.Nivel = New Nivel() With {.Siglas = dr.GetString(iSiglasNiv)}, .Numero = dr.GetByte(iGrado) _
                          } _
                      }, _
                .ProgLectura = New ProgramacionLectura() With {.Libro = New Libro(dr.GetString(iLib), "")}, _
                .Comentario = dr.GetString(iComent), .Nota = dr.GetString(iLet), _
                .NotaRecuperacion = dr.GetString(iNotaRecuperacion)} _
            )
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

    Return ln
  End Function

  Public Function ListarPromedioArea(ByVal wSeccion As Seccion) As DataTable
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liPromediosAreaSeccion", cn)
    Dim da As New SqlDataAdapter(cmd)
    Dim dt As New DataTable

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Anio", wSeccion.Anio.Anio)
      .AddWithValue("@Grado", wSeccion.Grado.Codigo)
      .AddWithValue("@Seccion", wSeccion.Letra)
    End With

    Try
      da.Fill(dt)
    Catch ex As Exception
      Throw ex
    Finally
      da.Dispose()
      da = Nothing
      cmd.Dispose()
      cmd = Nothing
      cn.Dispose()
      cn = Nothing
    End Try

    Return dt
  End Function

  Public Function ListarPromedioCurso(ByVal wSeccion As Seccion) As DataTable
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liPromediosCursoSeccion", cn)
    Dim da As New SqlDataAdapter(cmd)
    Dim dt As New DataTable

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Anio", wSeccion.Anio.Anio)
      .AddWithValue("@Grado", wSeccion.Grado.Codigo)
      .AddWithValue("@Seccion", wSeccion.Letra)
    End With

    Try
      da.Fill(dt)
    Catch ex As Exception
      Throw ex
    Finally
      da.Dispose()
      da = Nothing
      cmd.Dispose()
      cmd = Nothing
      cn.Dispose()
      cn = Nothing
    End Try

    Return dt
  End Function

  Public Function ListarResumenAsistencia(ByVal wSeccion As Seccion, ByVal wPeriodo As PeriodoAcademico) As DataTable
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liResumenAsistenciaSeccion", cn)
    Dim da As New SqlDataAdapter(cmd)
    Dim dt As New DataTable

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Anio", wSeccion.Anio.Anio)
      .AddWithValue("@Grado", wSeccion.Grado.Codigo)
      .AddWithValue("@Seccion", wSeccion.Letra)
      .AddWithValue("@Periodo", wPeriodo.Codigo)
    End With

    Try
      da.Fill(dt)
    Catch ex As Exception
      Throw ex
    Finally
      da.Dispose()
      da = Nothing
      cmd.Dispose()
      cmd = Nothing
      cn.Dispose()
      cn = Nothing
    End Try

    Return dt
  End Function

  Public Function ListarAlumnosPLNoProgramados(ByVal wSeccion As Seccion) As DataTable
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAlumnosPLNoProgramados", cn)
    Dim da As New SqlDataAdapter(cmd)
    Dim dt As New DataTable

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Anio", wSeccion.Anio.Anio)
      .AddWithValue("@Grado", wSeccion.Grado.Codigo)
      .AddWithValue("@Letra", wSeccion.Letra)
    End With

    Try
      da.Fill(dt)
    Catch ex As Exception
      Throw ex
    Finally
      da.Dispose()
      da = Nothing
      cmd.Dispose()
      cmd = Nothing
      cn.Dispose()
      cn = Nothing
    End Try

    Return dt
  End Function

  Public Function ListarAlumnosActa(ByVal wSeccion As Seccion) As DataTable
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAlumnosSeccionActa", cn)
    Dim da As New SqlDataAdapter(cmd)
    Dim dt As New DataTable

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Anio", wSeccion.Anio.Anio)
      .AddWithValue("@Grado", wSeccion.Grado.Codigo)
      .AddWithValue("@Letra", wSeccion.Letra)
    End With

    Try
      da.Fill(dt)
    Catch ex As Exception
      Throw ex
    Finally
      da.Dispose()
      da = Nothing
      cmd.Dispose()
      cmd = Nothing
      cn.Dispose()
      cn = Nothing
    End Try

    Return dt
  End Function

  Public Function ListarAlumnosCarnet(ByVal wSeccion As Seccion) As List(Of Matricula)
    Dim datos As List(Of Matricula) = Nothing
    Dim lp As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim iNombre As Integer, iApellidoPat As Integer, iApellidoMat As Integer
    Dim iNombreAp As Integer, iApellidoPatAp As Integer, iApellidoMatAp As Integer
    Dim iDireccion As Integer, iDepartamento As Integer, iProvincia As Integer
    Dim iDistrito As Integer, iTelefono As Integer

    lp.AddRange(New CParametro() {New CParametro("@Anio", wSeccion.Anio.Anio), _
                                  New CParametro("@Grado", wSeccion.Grado.Codigo), _
                                  New CParametro("@Letra", wSeccion.Letra)})
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liDatosCarnetAlumno_Seccion", lp)
      iNombre = dr.GetOrdinal("Nombre")
      iApellidoPat = dr.GetOrdinal("ApellidoPat")
      iApellidoMat = dr.GetOrdinal("ApellidoMat")
      iNombreAp = dr.GetOrdinal("NombreAp")
      iApellidoPatAp = dr.GetOrdinal("ApellidoPatAp")
      iApellidoMatAp = dr.GetOrdinal("ApellidoMatAp")
      iDireccion = dr.GetOrdinal("Direccion")
      iDepartamento = dr.GetOrdinal("Departamento")
      iProvincia = dr.GetOrdinal("Provincia")
      iDistrito = dr.GetOrdinal("Distrito")
      iTelefono = dr.GetOrdinal("Telefono")
      datos = New List(Of Matricula)
      Do While dr.Read
        datos.Add(New Matricula())
        With datos.Item(datos.Count - 1)
          .Grado = wSeccion.Grado
          .Letra = wSeccion.Letra
          .Alumno = New Alumno
          With .Alumno
            .Nombre = dr.GetString(iNombre)
            .ApellidoPaterno = dr.GetString(iApellidoPat)
            .ApellidoMaterno = dr.GetString(iApellidoMat)
            If dr.IsDBNull(iTelefono) = False Then
              .Telefono = dr.GetString(iTelefono)
            End If
            .Direccion = dr.GetString(iDireccion)
            .DireccionActual = New UbicacionGeografica
            With .DireccionActual
              .Departamento = dr.GetString(iDepartamento)
              .Provincia = dr.GetString(iProvincia)
              .Distrito = dr.GetString(iDistrito)
            End With
          End With

          .codigoApoderado = New Apoderado
          With .codigoApoderado
            .Nombre = dr.GetString(iNombreAp)
            .ApellidoPaterno = dr.GetString(iApellidoPatAp)
            .ApellidoMaterno = dr.GetString(iApellidoMatAp)
          End With
        End With
      Loop

      Me.Cerrar(True)
    Catch ex As Exception
      datos = Nothing
      Me.Cerrar(False)
      Throw ex
    Finally
      lp = Nothing
      dr = Nothing
    End Try

    Return datos
  End Function

#Region "Listar promedios capacidad periodo"
  Public Sub ListarPromediosCapacidadPeriodo(ByVal wSeccion As Seccion, ByVal wPeriodo As PeriodoAcademico, _
                                             ByVal wAlumnos As List(Of PromedioPeriodoArea), ByVal wAreas As List(Of AreaDRE), _
                                             ByVal wPromediosPeriodo As List(Of PromedioPeriodo))
    Dim capacidades As Hashtable

    Try
      Me.Conectar(False)
      capacidades = New Hashtable
      Me.CargarAreas(wAreas, capacidades, wSeccion.Grado.Nivel)
      Me.CargarPromedios(wSeccion, wPeriodo, wAlumnos, capacidades)
      Me.CargarPromediosPeriodo(wPromediosPeriodo, wSeccion, wPeriodo)
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    End Try

  End Sub

  Private Sub CargarAreas(ByVal wAreas As List(Of AreaDRE), ByVal wCapacidades As Hashtable, ByVal wNivel As Nivel)
    Dim parsAreas As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim iArea, iCodCapac, iCapac As Integer
    Dim areaActual As New AreaDRE
    Dim cap As Capacidad

    parsAreas.AddRange(New CParametro() {New CParametro("@Nivel", wNivel.Codigo)})
    dr = Me.PedirDataReader("pr_liTodasCapacidadesNivel", parsAreas)
    iArea = dr.GetOrdinal("NombreAreaD")
    iCodCapac = dr.GetOrdinal("CodigoCapac")
    iCapac = dr.GetOrdinal("Nombre")
    While (dr.Read)
      If (areaActual.Nombre <> dr.GetString(iArea)) Then
        areaActual = New AreaDRE With {.Nombre = dr.GetString(iArea)}
        areaActual.Capacidades = New List(Of Capacidad)
        wAreas.Add(areaActual)
      End If
      cap = New Capacidad() With {.Codigo = dr.GetByte(iCodCapac), .Nombre = dr.GetString(iCapac), .AreaDre = areaActual}
      wCapacidades.Add("C" & cap.Codigo, cap)
      wAreas.Item(wAreas.Count - 1).Capacidades.Add(cap)
    End While
    dr.Close()
    dr = Nothing
  End Sub

  Private Sub CargarPromedios(ByVal wSeccion As Seccion, ByVal wPeriodo As PeriodoAcademico, ByVal wAlumnos As List(Of PromedioPeriodoArea), ByVal wCapacidades As Hashtable)
    Dim dr As SqlDataReader
    Dim parsPromedios As New List(Of CParametro)
    Dim iOrden, iNombre, iApellidoPat, iApellidoMat As Integer
    Dim iCapacidad, iPromCapac As Integer
    Dim iArea, iPromArea As Integer
    Dim promAreaActual As PromedioPeriodoArea = Nothing
    Dim promCapacActual As PromedioPeriodoCapacidad = Nothing
    Dim matActual As New Matricula
    Dim areas As Hashtable

    parsPromedios.AddRange(New CParametro() {New CParametro("@Anio", wSeccion.Anio.Anio), _
                                  New CParametro("@Grado", wSeccion.Grado.Codigo), _
                                  New CParametro("@Letra", wSeccion.Letra), _
                                  New CParametro("@Periodo", wPeriodo.Codigo)})

    matActual.NroOrden = -1
    dr = Me.PedirDataReader("pr_liAlumnosPromedioCapacidadPeriodo", parsPromedios)
    iOrden = dr.GetOrdinal("nroOrden")
    iNombre = dr.GetOrdinal("Nombre")
    iApellidoPat = dr.GetOrdinal("ApellidoPat")
    iApellidoMat = dr.GetOrdinal("ApellidoMat")
    iArea = dr.GetOrdinal("CodigoAreaD")
    iPromArea = dr.GetOrdinal("PromArea")
    iCapacidad = dr.GetOrdinal("CodigoCapac")
    iPromCapac = dr.GetOrdinal("PromCapac")
    areas = New Hashtable
    Do While dr.Read
      promCapacActual = New PromedioPeriodoCapacidad With {.Matricula = matActual, .Periodo = wPeriodo, _
                                                              .Capacidad = DirectCast(wCapacidades.Item("C" & dr.GetByte(iCapacidad)), Capacidad), _
                                                              .Promedio = dr.GetDecimal(iPromCapac)}
      If matActual.NroOrden <> dr.GetByte(iOrden) Then
        matActual = New Matricula
        With matActual
          .Seccion = wSeccion
          .NroOrden = dr.GetByte(iOrden)
          .Alumno = New Alumno With {.Nombre = dr.GetString(iNombre), .ApellidoPaterno = dr.GetString(iApellidoPat), .ApellidoMaterno = dr.GetString(iApellidoMat)}
        End With
        promAreaActual = New PromedioPeriodoArea With {.Matricula = matActual, .Area = promCapacActual.Capacidad.AreaDre, _
                                                       .Promedio = dr.GetDecimal(iPromArea), .PromediosCapacidades = New List(Of PromedioPeriodoCapacidad)}
        promAreaActual.PromediosCapacidades.Add(promCapacActual)
        wAlumnos.Add(promAreaActual)
        areas.Add(promAreaActual.Matricula.NroOrden & "-" & promAreaActual.Area.Nombre, promAreaActual)
      Else
        promAreaActual = Nothing
        If areas.Contains(promCapacActual.Matricula.NroOrden & "-" & promCapacActual.Capacidad.AreaDre.Nombre) Then
          promAreaActual = DirectCast(areas.Item(promCapacActual.Matricula.NroOrden & "-" & promCapacActual.Capacidad.AreaDre.Nombre), PromedioPeriodoArea)
        End If
        If promAreaActual Is Nothing Then
          promAreaActual = New PromedioPeriodoArea With {.Matricula = matActual, .Area = promCapacActual.Capacidad.AreaDre, _
                                                         .Promedio = dr.GetDecimal(iPromArea), .PromediosCapacidades = New List(Of PromedioPeriodoCapacidad)}
          wAlumnos.Add(promAreaActual)
          areas.Add(promAreaActual.Matricula.NroOrden & "-" & promAreaActual.Area.Nombre, promAreaActual)
        End If
        promAreaActual.PromediosCapacidades.Add(promCapacActual)
      End If
    Loop
    dr.Close()
    dr = Nothing
  End Sub

  Private Sub CargarPromediosPeriodo(ByVal wPromediosPeriodo As List(Of PromedioPeriodo), ByVal wSeccion As Seccion, _
                                     ByVal wPeriodo As PeriodoAcademico)
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim iOrden, iPromedio, iMerito As Integer
    Dim prom As PromedioPeriodo

    pars.AddRange(New CParametro() {New CParametro("@Anio", wSeccion.Anio.Anio), _
                                    New CParametro("@Grado", wSeccion.Grado.Codigo), _
                                    New CParametro("@Letra", wSeccion.Letra), _
                                    New CParametro("@Periodo", wPeriodo.Codigo)})
    dr = Me.PedirDataReader("pr_liPromediosFinalesPeriodo", pars)
    iOrden = dr.GetOrdinal("nroOrden")
    iPromedio = dr.GetOrdinal("Promedio")
    iMerito = dr.GetOrdinal("Merito")
    While (dr.Read)
      prom = New PromedioPeriodo
      prom.Matricula = New Matricula With {.NroOrden = dr.GetByte(iOrden)}
      prom.Promedio = dr.GetDecimal(iPromedio)
      prom.OrdenMerito = CByte(dr.GetInt64(iMerito))

      wPromediosPeriodo.Add(prom)
    End While
    dr.Close()
    dr = Nothing

  End Sub

#End Region

#Region "Listar promedios de area al anio"
  Public Sub ListarPromediosAreaPeriodo(ByVal wSeccion As Seccion, ByVal wAlumnos As List(Of PromedioAnioArea), _
                                             ByVal wPeriodos As List(Of PeriodoAcademico), ByVal wAreas As List(Of AreaDRE))
    Dim RefAreas As Hashtable
    Dim RefPeriodos As Hashtable

    Try
      Me.Conectar(False)
      RefAreas = New Hashtable
      CargarAreas(wAreas, wSeccion.Grado.Nivel, RefAreas)
      RefPeriodos = New Hashtable
      CargarPeriodos(wPeriodos, wSeccion.Anio, RefPeriodos)
      CargarPromedios(wSeccion, wAlumnos, RefPeriodos, RefAreas)
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    End Try

  End Sub

  Private Sub CargarAreas(ByVal wAreas As List(Of AreaDRE), ByVal wNivel As Nivel, ByVal wRefAreas As Hashtable)
    Dim parsAreas As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim iArea, iCodArea As Integer
    Dim areaActual As New AreaDRE

    parsAreas.AddRange(New CParametro() {New CParametro("@CodigoNivel", wNivel.Codigo)})
    dr = Me.PedirDataReader("pr_liAreasD", parsAreas)
    iArea = dr.GetOrdinal("NombreAreaD")
    iCodArea = dr.GetOrdinal("codigoAreaD")
    While (dr.Read)
      areaActual = New AreaDRE With {.Codigo = dr.GetInt16(iCodArea), .Nombre = dr.GetString(iArea)}
      wRefAreas.Add("A" & areaActual.Codigo, areaActual)
      wAreas.Add(areaActual)
    End While
    dr.Close()
    dr = Nothing
  End Sub

  Private Sub CargarPeriodos(ByVal wPeriodos As List(Of PeriodoAcademico), ByVal wAnio As AnioLectivo, ByVal wRefPeriodos As Hashtable)
    Dim parsPeriodos As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim iCodigo, iNombre, iSiglas As Integer
    Dim perActual As New PeriodoAcademico

    parsPeriodos.AddRange(New CParametro() {New CParametro("@Anio", wAnio.Anio)})
    dr = Me.PedirDataReader("pr_liCodPeriodos", parsPeriodos)
    iCodigo = dr.GetOrdinal("CodigoPeriodo")
    iNombre = dr.GetOrdinal("nombre")
    iSiglas = dr.GetOrdinal("Siglas")
    While (dr.Read)
      perActual = New PeriodoAcademico With {.Codigo = dr.GetInt16(iCodigo), .Nombre = dr.GetString(iNombre), .Siglas = dr.GetString(iSiglas)}
      wRefPeriodos.Add("P" & perActual.Codigo, perActual)
      wPeriodos.Add(perActual)
    End While
    dr.Close()
    dr = Nothing
  End Sub

  Private Sub CargarPromedios(ByVal wSeccion As Seccion, ByVal wAlumnos As List(Of PromedioAnioArea), _
                              ByVal wRefPeriodos As Hashtable, ByVal wRefAreas As Hashtable)
    Dim dr As SqlDataReader
    Dim parsPromedios As New List(Of CParametro)
    Dim htAreasAlum As Hashtable
    Dim iOrden, iNombre, iApellidoPat, iApellidoMat As Integer
    Dim iPromAnio, iPeriodo, iArea, iPromPer As Integer
    Dim promAreaActual As PromedioAnioArea = Nothing
    Dim matActual As New Matricula

    parsPromedios.AddRange(New CParametro() {New CParametro("@Anio", wSeccion.Anio.Anio), _
                                  New CParametro("@Grado", wSeccion.Grado.Codigo), _
                                  New CParametro("@Letra", wSeccion.Letra)})

    matActual.NroOrden = -1
    dr = Me.PedirDataReader("pr_liAlumnosPromedioAreaAnio", parsPromedios)
    iOrden = dr.GetOrdinal("nroOrden")
    iNombre = dr.GetOrdinal("Nombre")
    iApellidoPat = dr.GetOrdinal("ApellidoPat")
    iApellidoMat = dr.GetOrdinal("ApellidoMat")
    iPromAnio = dr.GetOrdinal("Promedio")
    iPeriodo = dr.GetOrdinal("CodigoPeriodo")
    iArea = dr.GetOrdinal("CodigoAreaD")
    iPromPer = dr.GetOrdinal("PromArea")
    htAreasAlum = New Hashtable
    Do While dr.Read
      If matActual.NroOrden <> dr.GetByte(iOrden) Then
        matActual = New Matricula With {.Alumno = New Alumno() With {.Nombre = dr.GetString(iNombre), _
                                                                     .ApellidoPaterno = dr.GetString(iApellidoPat), _
                                                                     .ApellidoMaterno = dr.GetString(iApellidoMat)}, _
                                        .NroOrden = dr.GetByte(iOrden)}

        promAreaActual = New PromedioAnioArea With {.Matricula = matActual, _
                                                    .Area = DirectCast(wRefAreas.Item("A" & dr.GetInt16(iArea)), AreaDRE), _
                                                    .Promedio = dr.GetDecimal(iPromAnio), _
                                                    .PromediosPeriodo = New List(Of PromedioPeriodoArea)}
        htAreasAlum.Add(promAreaActual.Area.Codigo & "-" & matActual.NroOrden, promAreaActual)
        wAlumnos.Add(promAreaActual)
      Else
        promAreaActual = DirectCast(htAreasAlum.Item(dr.GetInt16(iArea) & "-" & matActual.NroOrden), PromedioAnioArea)
        If promAreaActual Is Nothing Then
          promAreaActual = New PromedioAnioArea With {.Matricula = matActual, _
                                                    .Area = DirectCast(wRefAreas.Item("A" & dr.GetInt16(iArea)), AreaDRE), _
                                                    .Promedio = dr.GetDecimal(iPromAnio), _
                                                    .PromediosPeriodo = New List(Of PromedioPeriodoArea)}
          htAreasAlum.Add(promAreaActual.Area.Codigo & "-" & matActual.NroOrden, promAreaActual)
          wAlumnos.Add(promAreaActual)
        End If
      End If
      promAreaActual.PromediosPeriodo.Add(New PromedioPeriodoArea)
      With promAreaActual.PromediosPeriodo.Item(promAreaActual.PromediosPeriodo.Count - 1)
        .Matricula = matActual
        .Area = promAreaActual.Area
        .Periodo = DirectCast(wRefPeriodos.Item("P" & dr.GetInt16(iPeriodo)), PeriodoAcademico)
        .Promedio = dr.GetDecimal(iPromPer)
      End With
    Loop
    dr.Close()
    dr = Nothing
  End Sub

#End Region

#Region "Listar promedios de curso al anio"
  Public Sub ListarPromediosCursoPeriodo(ByVal wSeccion As Seccion, ByVal wAlumnos As List(Of PromedioAnioCurso), _
                                             ByVal wPeriodos As List(Of PeriodoAcademico), ByVal wCursos As List(Of Curso))
    Dim RefCursos As Hashtable
    Dim RefPeriodos As Hashtable

    Try
      Me.Conectar(False)
      RefCursos = New Hashtable
      CargarCursos(wCursos, wSeccion.Grado, RefCursos)
      RefPeriodos = New Hashtable
      CargarPeriodos(wPeriodos, wSeccion.Anio, RefPeriodos)
      CargarPromedios(wSeccion, wAlumnos, RefPeriodos, RefCursos)
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    End Try

  End Sub

  Private Sub CargarCursos(ByVal wCursos As List(Of Curso), ByVal wGrado As Grado, ByVal wRefCursos As Hashtable)
    Dim parsAreas As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim iCurso, iCodCurso As Integer
    Dim CursoActual As New Curso

    parsAreas.AddRange(New CParametro() {New CParametro("@CodigoG", wGrado.Codigo)})
    dr = Me.PedirDataReader("pr_liCurso_Grado", parsAreas)
    iCurso = dr.GetOrdinal("NombreCur")
    iCodCurso = dr.GetOrdinal("codigoCur")
    While (dr.Read)
      CursoActual = New Curso With {.Codigo = dr.GetInt16(iCodCurso), .Nombre = dr.GetString(iCurso)}
      wRefCursos.Add("C" & CursoActual.Codigo, CursoActual)
      wCursos.Add(CursoActual)
    End While
    dr.Close()
    dr = Nothing
  End Sub

  Private Sub CargarPromedios(ByVal wSeccion As Seccion, ByVal wAlumnos As List(Of PromedioAnioCurso), _
                              ByVal wRefPeriodos As Hashtable, ByVal wRefCursos As Hashtable)
    Dim dr As SqlDataReader
    Dim parsPromedios As New List(Of CParametro)
    Dim htAreasAlum As Hashtable
    Dim iOrden, iNombre, iApellidoPat, iApellidoMat As Integer
    Dim iPromAnio, iPeriodo, iCurso, iPromPer As Integer
    Dim promCursoActual As PromedioAnioCurso = Nothing
    Dim matActual As New Matricula

    parsPromedios.AddRange(New CParametro() {New CParametro("@Anio", wSeccion.Anio.Anio), _
                                  New CParametro("@Grado", wSeccion.Grado.Codigo), _
                                  New CParametro("@Letra", wSeccion.Letra)})

    matActual.NroOrden = -1
    dr = Me.PedirDataReader("pr_liAlumnosPromedioCursoAnio", parsPromedios)
    iOrden = dr.GetOrdinal("nroOrden")
    iNombre = dr.GetOrdinal("Nombre")
    iApellidoPat = dr.GetOrdinal("ApellidoPat")
    iApellidoMat = dr.GetOrdinal("ApellidoMat")
    iPromAnio = dr.GetOrdinal("Promedio")
    iPeriodo = dr.GetOrdinal("CodigoPeriodo")
    iCurso = dr.GetOrdinal("CodigoCur")
    iPromPer = dr.GetOrdinal("PromCurso")
    htAreasAlum = New Hashtable
    Do While dr.Read
      If matActual.NroOrden <> dr.GetByte(iOrden) Then
        matActual = New Matricula With {.Alumno = New Alumno() With {.Nombre = dr.GetString(iNombre), _
                                                                     .ApellidoPaterno = dr.GetString(iApellidoPat), _
                                                                     .ApellidoMaterno = dr.GetString(iApellidoMat)}, _
                                        .NroOrden = dr.GetByte(iOrden)}

        promCursoActual = New PromedioAnioCurso With {.Matricula = matActual, _
                                                    .CargaAcademica = New CargaAcademica, _
                                                    .Promedio = dr.GetDecimal(iPromAnio), _
                                                    .PromediosPeriodo = New List(Of PromedioPeriodoCurso)}
        promCursoActual.CargaAcademica.Curso = DirectCast(wRefCursos.Item("C" & dr.GetInt16(iCurso)), Curso)
        htAreasAlum.Add(promCursoActual.CargaAcademica.Curso.Codigo & "-" & matActual.NroOrden, promCursoActual)
        wAlumnos.Add(promCursoActual)
      Else
        promCursoActual = DirectCast(htAreasAlum.Item(dr.GetInt16(iCurso) & "-" & matActual.NroOrden), PromedioAnioCurso)
        If promCursoActual Is Nothing Then
          promCursoActual = New PromedioAnioCurso With {.Matricula = matActual, _
                                                    .CargaAcademica = New CargaAcademica(), _
                                                    .Promedio = dr.GetDecimal(iPromAnio), _
                                                    .PromediosPeriodo = New List(Of PromedioPeriodoCurso)}
          promCursoActual.CargaAcademica.Curso = DirectCast(wRefCursos.Item("C" & dr.GetInt16(iCurso)), Curso)
          htAreasAlum.Add(promCursoActual.CargaAcademica.Curso.Codigo & "-" & matActual.NroOrden, promCursoActual)
          wAlumnos.Add(promCursoActual)
        End If
      End If
      promCursoActual.PromediosPeriodo.Add(New PromedioPeriodoCurso)
      With promCursoActual.PromediosPeriodo.Item(promCursoActual.PromediosPeriodo.Count - 1)
        .Matricula = matActual
        .CargaAcademica = promCursoActual.CargaAcademica
        .Periodo = DirectCast(wRefPeriodos.Item("P" & dr.GetInt16(iPeriodo)), PeriodoAcademico)
        .Promedio = dr.GetDecimal(iPromPer)
      End With
    Loop
    dr.Close()
    dr = Nothing
  End Sub

#End Region

#Region "Consolidado de todas las notas de plan lector para una seccion"

  Public Sub ListarConsolidadoNotasPL(ByVal wSeccion As Seccion, ByVal wNotas As List(Of NotaLectura), ByVal wLibros As List(Of Libro))
    Dim htLibros As New Hashtable

    Try
      Me.Conectar(False)
      Me.CargarLibros(wSeccion, wLibros, htLibros)
      Me.CargarNotas(wSeccion, wNotas, htLibros)
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      htLibros = Nothing
    End Try

  End Sub

  Private Sub CargarLibros(ByVal wSeccion As Seccion, ByVal wLibros As List(Of Libro), ByVal whtLibros As Hashtable)
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim l As Libro
    Dim iCod, iNombre As Integer

    pars.AddRange(New CParametro() {New CParametro("@Anio", wSeccion.Anio.Anio), _
                                     New CParametro("@Grado", wSeccion.Grado.Codigo), _
                                     New CParametro("@Letra", wSeccion.Letra)})
    dr = Me.PedirDataReader("pr_liLibrosSeccionAnio", pars)
    iCod = dr.GetOrdinal("CodigoLibro")
    iNombre = dr.GetOrdinal("Nombre")
    While dr.Read()
      l = New Libro() With {.Codigo = dr.GetInt16(iCod), .Titulo = dr.GetString(iNombre)}
      wLibros.Add(l)
      'whtLibros.Add("L" & l.Codigo, New ProgramacionLectura() With {.Libro = l})
      whtLibros.Add("L" & l.Codigo, l)
    End While
    dr.Close()
  End Sub

  Private Sub CargarNotas(ByVal wSeccion As Seccion, ByVal wNotas As List(Of NotaLectura), ByVal whtLibro As Hashtable)
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim nl As NotaLectura
    Dim iOrden, iNombre, iApPat, iApMat, iCodLibro, iNota, iNumPres As Integer

    pars.AddRange(New CParametro() {New CParametro("@Anio", wSeccion.Anio.Anio), _
                                     New CParametro("@Grado", wSeccion.Grado.Codigo), _
                                     New CParametro("@Letra", wSeccion.Letra)})
    dr = Me.PedirDataReader("pr_liNotasPLConsolidadoSeccion", pars)
    iOrden = dr.GetOrdinal("nroOrden")
    iNombre = dr.GetOrdinal("nombre")
    iApPat = dr.GetOrdinal("ApellidoPat")
    iApMat = dr.GetOrdinal("ApellidoMat")
    iCodLibro = dr.GetOrdinal("codigoLibro")
    iNota = dr.GetOrdinal("letra")
    iNumPres = dr.GetOrdinal("nro")
    While dr.Read()
      nl = New NotaLectura
      nl.ProgLectura = New ProgramacionLectura With {.Libro = DirectCast(whtLibro.Item("L" & dr.GetInt16(iCodLibro)), Libro)}
      nl.ProgLectura.Presentacion = New Presentacion With {.Numero = dr.GetByte(iNumPres)}
      nl.Matricula = New Matricula With {.NroOrden = dr.GetByte(iOrden), _
                                          .Alumno = New Alumno() With {.Nombre = dr.GetString(iNombre), _
                                                                        .ApellidoPaterno = dr.GetString(iApPat), _
                                                                        .ApellidoMaterno = dr.GetString(iApMat)} _
                                          }
      nl.Nota = dr.GetString(iNota)
      wNotas.Add(nl)
    End While
    dr.Close()
  End Sub

#End Region

  Public Function ListarEvolucionComportamiento(ByVal seccion As Seccion) As DataTable
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim dt As DataTable
    Dim sql As String = ""

    pars.Add(New CParametro("@Anio", seccion.Anio.Anio))
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liCodPeriodos", pars)
      sql = "SELECT P.apellidoPat + ' ' + P.apellidoMat + ' ' P.nombre AS Alumno "
      While dr.Read
        sql &= ", SUM( CASE ELSE 0 END) AS '" & dr.Item("siglas").ToString & "'"
      End While
      sql &= ""
      dr.Close()
      dt = Me.EjecutarSQLDatos(sql)
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      pars.Clear()
      pars = Nothing
    End Try

    Return dt
  End Function

  Public Function GenerarRegistroComportamiento(ByVal seccion As Seccion, ByVal periodo As PeriodoAcademico, ByVal virtudes As List(Of Virtud)) As DataTable
    Dim dt As DataTable = Nothing
    Dim sql As String = ""

    Try
      Me.Conectar(False)
      Me.ListarVirtudes(seccion, periodo, virtudes)
      sql = "SELECT M.nroMatricula, M.nroOrden, P.apellidoPat + ' ' + P.apellidoMat + ' ' + P.nombre AS Alumno"
      For Each vir As Virtud In virtudes
        sql &= ", SUM (CASE NC.codigoVirtudComp WHEN " & vir.Codigo & " THEN NC.puntos ELSE 0 END) AS '" & vir.Nombre & "' "
      Next
      If seccion.Grado.TipoEval = "N" Then
        sql &= ", 2 AS Total "
      End If
      sql &= "FROM Persona P JOIN Matricula M ON P.codigoPersona = M.codigoAlumno " &
        "LEFT OUTER JOIN ( SELECT NC.nroMatricula, NC.codigoVirtudComp, NC.letra, NC.puntos " &
                           "FROM NOTA_COMPORTAMIENTO NC " &
                           "WHERE NC.vigencia = 1 AND NC.codigoPeriodo = " & periodo.Codigo &
                          ") AS NC ON NC.nroMatricula = M.nroMatricula " &
        "WHERE M.vigencia = 1 AND M.codigoG = " & seccion.Grado.Codigo & " AND M.letra = '" & seccion.Letra &
        "' AND M.anio = " & seccion.Anio.Anio &
        " GROUP BY M.nroMatricula, M.nroOrden, P.apellidoPat, P.apellidoMat, P.nombre " &
        "ORDER BY Alumno"

      dt = Me.EjecutarSQLDatos(sql)

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally

    End Try

    Return dt
  End Function

  Private Sub ListarVirtudes(ByVal seccion As Seccion, ByVal periodo As PeriodoAcademico, ByVal virtudes As List(Of Virtud))
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim codigo, nombre, id As Integer

    pars.Add(New CParametro("@anio", seccion.Anio.Anio))
    pars.Add(New CParametro("@codPer", periodo.Codigo))
    pars.Add(New CParametro("@codNivel", seccion.Grado.Nivel.Codigo))
    dr = Me.PedirDataReader("pr_lVirtudPerSec", pars)
    codigo = dr.GetOrdinal("codigoVirtudComp")
    nombre = dr.GetOrdinal("nombre")
    id = dr.GetOrdinal("idVirtud")
    While dr.Read
      virtudes.Add(
          New Virtud With {.Codigo = dr.GetInt16(codigo),
                            .Nombre = dr.GetString(nombre),
                           .Id = dr.GetInt16(id)}
                  )
    End While
    dr.Close()
    dr = Nothing
  End Sub

#Region "Consolidado de promedio literal por curso para todo el año lectivo"

  Public Function PresentarConsolidadoCursosAnio(ByVal periodos As List(Of PeriodoAcademico), ByVal cursos As List(Of Curso), ByVal seccion As Seccion) As DataTable
    Dim refPeriodos As New Hashtable
    Dim refCursos As New Hashtable
    Dim dt As DataTable
    Dim sql As String = ""

    Try
      Me.Conectar(False)
      Me.CargarPeriodos(periodos, seccion.Anio, refPeriodos)
      Me.CargarCursos(cursos, seccion.Grado, refCursos)
      sql = Me.GenerarSentencia(seccion, periodos, cursos)
      dt = Me.EjecutarSQLDatos(sql)

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    End Try

    Return dt
  End Function

  Private Function GenerarSentencia(ByVal seccion As Seccion, ByVal periodos As List(Of PeriodoAcademico), ByVal cursos As List(Of Curso)) As String
    Dim sql As String = ""
    Dim pers() As PeriodoAcademico = periodos.ToArray
    Dim curs() As Curso = cursos.ToArray
    Dim cantPers As Integer = pers.Length
    Dim cantCur As Integer = curs.Length

    sql = "SELECT P.nroOrden, P.Alumno "
    For i = 0 To cantCur - 1
      For j = 0 To cantPers - 1
        sql &= ", MAX( CASE WHEN P.codigoCur = " & curs(i).Codigo & " AND P.codigoPeriodo = " & pers(j).Codigo & " THEN P.Promedio ELSE '' END ) AS C" & curs(i).Codigo & "P" & pers(j).Codigo
      Next
    Next

    sql &= " FROM (" &
              "SELECT M.nroOrden, A.apellidoPat + ' ' + A.apellidoMat + ' ' + A.nombre AS Alumno," &
                  "C.codigoCur, PA.codigoPeriodo," &
                  "( SELECT TOP 1 PPC.letra  " &
                      "FROM PROMEDIO_PERIODO_CUR PPC JOIN DOCENTE_CARGA DC ON DC.codigoDocenteCarga = PPC.CodigoDocenteCarga " &
                          "JOIN CARGA_ACADEMICA CA ON CA.codigoCargaAcad = DC.codigoCargaAcad " &
                      "WHERE(PPC.codigoPeriodo = PA.codigoPeriodo " &
                      "AND PPC.nroMatricula = M.nroMatricula " &
                      "AND CA.codigoCur = C.codigoCur " &
                      "AND PPC.vigencia = 1) " &
                      "ORDER BY PPC.codigoProm DESC" &
                  ") AS Promedio " &
                "FROM PERSONA A JOIN MATRICULA M ON A.codigoPersona = M.codigoAlumno " &
                  "JOIN CURSO C ON C.codigoG = M.codigoG " &
                  "JOIN PERIODO_ACAD PA ON PA.anio = M.anio " &
                  "WHERE M.anio = " & seccion.Anio.Anio & " AND M.codigoG = " & seccion.Grado.Codigo &
                      " AND M.letra = '" & seccion.Letra & "' AND M.vigencia = 1 " &
              ") AS P " &
            "GROUP BY P.nroOrden, P.Alumno " &
            "ORDER BY P.nroOrden, P.Alumno"
    Return sql
  End Function

#End Region

  'Tania Incio
  Public Function ListarAsistenciaxSeccion(ByVal wNivel As Nivel, ByVal wSeccion As Seccion, ByVal wPeriodo As PeriodoAcademico,
                                             ByVal FechaIni As DateTime, ByVal FechaFin As DateTime, ByVal wTipoRegistro As String) As DataTable
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAsistenciaxSeccion", cn)
    Dim da As New SqlDataAdapter(cmd)
    Dim dt As New DataTable

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      If wSeccion.Anio IsNot Nothing Then
        .AddWithValue("@Anio", wSeccion.Anio.Anio)
        .AddWithValue("@Grado", wSeccion.Grado.Codigo)
        .AddWithValue("@Seccion", wSeccion.Letra)
      ElseIf wNivel IsNot Nothing Then
        .AddWithValue("@Nivel", wNivel.Codigo)
      End If
      .AddWithValue("@Periodo", wPeriodo.Codigo)
      .AddWithValue("@FechaIni", FechaIni)
      .AddWithValue("@FechaFin", FechaFin)
      .AddWithValue("@TipoRegistro", wTipoRegistro)
    End With

    Try
      da.Fill(dt)
    Catch ex As Exception
      Throw ex
    Finally
      da.Dispose()
      da = Nothing
      cmd.Dispose()
      cmd = Nothing
      cn.Dispose()
      cn = Nothing
    End Try

    Return dt
  End Function

    Public Function ListarSeccionInvestigacion(ByVal wAnio As AnioLectivo, ByVal wNivel As Nivel, ByVal codigoPeriodo As Integer) As List(Of Seccion)
        Dim cn As New SqlConnection(My.Settings.Conexion)
        Dim cmd As New SqlCommand("pr_liSeccionesInvest", cn)
        Dim dr As SqlDataReader = Nothing
        Dim sec As Seccion = Nothing
        Dim ListS As List(Of Seccion) = Nothing

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@anio", wAnio.Anio)
        cmd.Parameters.AddWithValue("@codigoNivel", wNivel.Codigo)
        cmd.Parameters.AddWithValue("@codigoPeriodo", codigoPeriodo)
        Try
            cn.Open()
            dr = cmd.ExecuteReader
            ListS = New List(Of Seccion)
            Do While (dr.Read)
                ListS.Add(New Seccion(wAnio, New Grado(CInt(dr.Item("codigoG")), CInt(dr.Item("numero"))), CChar(dr.Item("letra"))))
            Loop
        Catch ex As Exception
            If ListS IsNot Nothing Then
                ListS.Clear()
            End If
            sec = Nothing
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

        Return ListS
    End Function


End Class
