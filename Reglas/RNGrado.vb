
Public Class RNGrado
  Inherits CADO

  Public Function Leer(ByVal obj As Grado) As List(Of Grado)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liGrado", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ListG As List(Of Grado) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoNivel", obj.Nivel.Codigo)

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ListG = New List(Of Grado)
      Do While (dr.Read)
        ListG.Add(New Grado(CInt(dr.Item("codigoG")), CInt(dr.Item("numero")), CStr(dr.Item("nombre")), _
                            New Nivel(CInt(dr.Item("codigoNivel")), dr.Item("nombreNivel").ToString, ""), _
                            dr.GetString(dr.GetOrdinal("tipoCalif")), dr.GetString(dr.GetOrdinal("caracteristica")).Trim, _
                            CStr(dr.Item("evalComp")), dr.Item("tipoComp").ToString))
      Loop
    Catch ex As Exception
      If ListG IsNot Nothing Then
        ListG.Clear()
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
    Return ListG
  End Function

  Public Function Leer() As List(Of Grado)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liGrado2", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ListG As List(Of Grado) = Nothing

    cmd.CommandType = CommandType.StoredProcedure

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ListG = New List(Of Grado)
      Do While (dr.Read)
        ListG.Add(New Grado(CInt(dr.Item("codigoG")), CInt(dr.Item("numero")), CStr(dr.Item("nombre")), _
                            New Nivel(CInt(dr.Item("codigoNivel")), dr.Item("nombreNivel").ToString, ""), dr.GetString(dr.GetOrdinal("tipoCalif")), dr.GetString(dr.GetOrdinal("caracteristica")), dr.Item("evalComp").ToString, dr.Item("tipoComp").ToString))
      Loop
    Catch ex As Exception
      If ListG IsNot Nothing Then
        ListG.Clear()
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
    Return ListG
  End Function

  Public Function Listar(ByVal obj As Grado) As List(Of Grado)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lNivel_Grado", cn)
    Dim dr As SqlDataReader = Nothing
    Dim obj1 As Grado = Nothing
    Dim Grados As List(Of Grado) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Codigo", obj.CodigoNivel)

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      Grados = New List(Of Grado)
      Do While (dr.Read)
        obj1 = New Grado(CInt(dr.Item("codigoG")), CInt(dr.Item("codigoNivel")), dr.Item("nombre").ToString, 0) '''''zsdgsd
        obj1.TipoCalif = dr.Item("tipoCalif").ToString
        obj1.TipoEval = dr.Item("tipoComp").ToString
        obj1.EvaluacionComp = dr.Item("evalComp").ToString

        Grados.Add(obj1)
      Loop
      cn.Close()
    Catch ex As Exception
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

    Return Grados
  End Function

  Public Function Listar(ByVal objNivel As Nivel) As List(Of Grado)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liGrados_CodMod", cn)
    Dim dr As SqlDataReader = Nothing
    Dim Grado As New List(Of Grado)

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@codigoNivel", objNivel.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      Do While (dr.Read)
        Grado.Add(New Grado(CInt(dr.Item("codigoG")), CInt(dr.Item("numero")), dr.Item("nombre").ToString, New Nivel(), "", "", "", ""))
        With Grado.Item(Grado.Count - 1)
          .Nivel = objNivel
        End With
      Loop
      cn.Close()
    Catch ex As Exception
      If Grado IsNot Nothing Then
        Grado.Clear()
      End If
      Grado = Nothing
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

    Return Grado
  End Function

  Public Function RetornaCG(ByVal obj As Seccion) As Integer
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lCodGrado", cn)
    Dim dr As Integer


    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Numero", obj.Grado.Numero)
    cmd.Parameters.AddWithValue("@codigoNivel", obj.Grado.Nivel.Codigo)
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

  Public Sub Registrar(ByVal obj As Grado)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iGrado", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigoNivel", obj.CodigoNivel)
      .AddWithValue("@Numero", obj.Numero)
      .AddWithValue("@Nombre", obj.Nombre)
      .AddWithValue("@TipoCalif", obj.TipoCalif)
      .AddWithValue("@Caracteristica", obj.Caracteristica)
      .AddWithValue("@EvalComp", obj.EvaluacionComp)
      .AddWithValue("@TipoComp", obj.TipoEval)
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

  Public Sub Actualizar(ByVal obj As Grado)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aGrado", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoNivel", obj.CodigoNivel)
      .AddWithValue("@Numero", obj.Numero)
      .AddWithValue("@Nombre", obj.Nombre)
      .AddWithValue("@TipoCalif", obj.TipoCalif)
      .AddWithValue("@Caracteristica", obj.Caracteristica)
      .AddWithValue("@EvalComp", obj.EvaluacionComp)
      .AddWithValue("@TipoComp", obj.TipoEval)
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

  Public Sub Eliminar(ByVal obj As Grado)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_eGrado", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Codigo", obj.Codigo)
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

  Public Function LeerSgteGrado(ByVal obj As Matricula) As Grado
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lSgteGradoAlu", cn)
    Dim dr As SqlDataReader = Nothing
    Dim G As Grado = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoAlu", obj.Alumno.Codigo)
      .AddWithValue("@Anio", obj.Anio.Anio)
    End With
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      If dr.Read Then
        G = New Grado(0, dr.GetInt16(dr.GetOrdinal("numero")), "", New Nivel(Nothing, dr.GetString(dr.GetOrdinal("nombreNivel")), ""), "", "", "", "")
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

    Return G
  End Function

  Public Function LeerCodigoGrado(ByVal obj As Grado) As Integer
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lCodigoGrado", cn)
    Dim dr As Integer

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Numero", obj.Numero)
      .AddWithValue("@Siglas", obj.Nivel.Siglas)
    End With

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

  Public Function LeerNroAlumnosSeccion(ByVal objG As Grado, ByVal objA As AnioLectivo) As List(Of Seccion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lNroAluSec", cn)
    Dim ls As List(Of Seccion) = Nothing
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoNivel", objG.CodigoNivel)
      .AddWithValue("@Numero", objG.Numero)
      .AddWithValue("@Anio", objA.Anio)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ls = New List(Of Seccion)
      Do While dr.Read
        ls.Add(New Seccion(New Grado(CInt(dr.Item("codigoG")), CInt(dr.Item("numero"))), New AnioLectivo(), CChar(dr.GetString(dr.GetOrdinal("letra"))), CInt(dr.Item("Cantidad")), False, "", New Turno(), New Aula(), New Docente()))
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

  Public Function LeerCursosGrado(ByVal obj As Grado) As List(Of Curso)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lCursosGrado", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ls As List(Of Curso) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoG", obj.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ls = New List(Of Curso)
      Do While dr.Read
        ls.Add(New Curso(CInt(dr.Item("codigoCur")), CStr(dr.Item("nombreCur")), 0, CInt(dr.Item("codigoG")), False, CBool(dr.Item("grupo")), CBool(dr.Item("rotativo")), 0))
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

  Public Function ListarGradosSec(ByVal obj As AnioLectivo) As List(Of Grado)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liGradosSec", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lg As List(Of Grado) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Anio", obj.Anio)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lg = New List(Of Grado)
      Do While dr.Read
        lg.Add(New Grado(CInt(dr.Item("codigoG")), CInt(dr.Item("codigoNivel")), _
                         dr.Item("nombre").ToString, CInt(dr.Item("numero"))))
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
    Return lg
  End Function

  Public Function ListarAlumnosCarnet(ByVal wSeccion As Seccion) As List(Of Matricula)
    Dim datos As List(Of Matricula) = Nothing
    Dim lp As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim iNombre As Integer, iApellidoPat As Integer, iApellidoMat As Integer
    Dim iNombreAp As Integer, iApellidoPatAp As Integer, iApellidoMatAp As Integer
    Dim iDireccion As Integer, iDepartamento As Integer, iProvincia As Integer
    Dim iDistrito As Integer, iTelefono As Integer, iLetra As Integer

    lp.AddRange(New CParametro() {New CParametro("@Anio", wSeccion.Anio.Anio), _
                                  New CParametro("@Grado", wSeccion.Grado.Codigo)})
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liDatosCarnetAlumno_Grado", lp)
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
      iLetra = dr.GetOrdinal("Letra")
      datos = New List(Of Matricula)
      Do While dr.Read
        datos.Add(New Matricula())
        With datos.Item(datos.Count - 1)
          .Seccion = wSeccion
          .Grado = wSeccion.Grado
          .Letra = dr.GetString(iLetra)
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

End Class
