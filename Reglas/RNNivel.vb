
Public Class RNNivel
  Inherits CADO

  'Public Function Leer() As List(Of Nivel)
  '  Dim cn As New SqlConnection(My.Settings.Conexion)
  '  Dim cmd As New SqlCommand("liNivelAcad5", cn)
  '  Dim dr As SqlDataReader = Nothing
  '  Dim Na As Nivel = Nothing
  '  cmd.CommandType = CommandType.StoredProcedure
  '  Dim ListNa As List(Of Nivel) = Nothing
  '  Try
  '    cn.Open()
  '    dr = cmd.ExecuteReader
  '    ListNa = New List(Of Nivel)
  '    Do While (dr.Read)
  '      ListNa.Add(New Nivel(CInt(dr.Item("codigoNivel")), CStr(dr.Item("nombreNivel")), _
  '                           "", dr.Item("codigoModular").ToString))
  '    Loop
  '  Catch ex As Exception
  '    If ListNa IsNot Nothing Then
  '      ListNa.Clear()
  '    End If
  '    Na = Nothing
  '    Throw ex
  '  Finally
  '    cmd.Dispose()
  '    cmd = Nothing
  '    dr.Dispose()
  '    dr = Nothing
  '    If cn.State = ConnectionState.Open Then
  '      cn.Close()
  '    End If
  '    cn.Dispose()

  '    cn = Nothing
  '  End Try

  '  Return ListNa
  'End Function

  Public Function LeerNivelSec() As List(Of Nivel)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("liNivelAcad2", cn)
    Dim dr As SqlDataReader = Nothing
    Dim Na As Nivel = Nothing
    Dim ListNa As List(Of Nivel) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ListNa = New List(Of Nivel)
      Do While (dr.Read)
        ListNa.Add(New Nivel(CInt(dr.Item("codigoNivel")), CStr(dr.Item("nombreNivel")), _
                                            "", dr.Item("codigoModular").ToString))
      Loop
    Catch ex As Exception
      If ListNa IsNot Nothing Then
        ListNa.Clear()
      End If
      Na = Nothing
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

    Return ListNa
  End Function

  Public Function Listar() As List(Of Nivel)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liNiveles", cn)
    Dim dr As SqlDataReader = Nothing
    Dim Niveles As List(Of Nivel) = Nothing
    Dim N As Nivel

    cmd.CommandType = CommandType.StoredProcedure
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      Niveles = New List(Of Nivel)
      Do While (dr.Read)
        N = New Nivel(CInt(dr.Item("codigoNivel")), dr.Item("nombreNivel").ToString, dr.Item("siglas").ToString, _
                      dr.Item("codigoModular").ToString)
        N.Orden = CInt(dr.Item("Orden"))
        Niveles.Add(N)
      Loop
      cn.Close()
    Catch ex As Exception
      If Niveles IsNot Nothing Then
        Niveles.Clear()
      End If
      Niveles = Nothing
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

    Return Niveles
  End Function

  Public Function LeerNivelesInstitucion(ByVal obj As Nivel) As List(Of Nivel)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lDatosInstitucion", cn)
    Dim dr As SqlDataReader = Nothing
    Dim n As New List(Of Nivel)

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoNivel", obj.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader

      Do While (dr.Read)
        n.Add(New Nivel(dr.Item("nombreInst").ToString, dr.Item("gestion").ToString, CInt(dr.Item("codigoNivel")), _
                        dr.Item("nombreNivel").ToString, dr.Item("codigoModular").ToString))
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

    Return n
  End Function

  Public Sub Registrar(ByVal obj As Nivel)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iNivelAcad", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@NombreNivel", obj.Nombre)
      .AddWithValue("@Siglas", obj.Siglas)
      .AddWithValue("@CodigoModular", obj.CodigoModular)
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

  Public Sub Actualizar(ByVal obj As Nivel)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aNivelAcad", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@NombreNivel", obj.Nombre)
      .AddWithValue("@Siglas", obj.Siglas)
      .AddWithValue("@CodigoModular", obj.CodigoModular)
      .AddWithValue("@CodigoNivel", obj.Codigo)
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

  Public Sub Eliminar(ByVal obj As Nivel)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_eNivelAcad", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoNivel", obj.Codigo)
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

  Public Function Buscar(ByVal wObj As Nivel) As String
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lNivelAcad", cn)
    Dim dr As String

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@NombreNivel", wObj.Nombre)
    cmd.Parameters.AddWithValue("@CodigoNivel", wObj.Codigo)
    Try
      cn.Open()
      dr = CStr(cmd.ExecuteScalar)

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
    If dr <> Nothing Then
      Return dr.Trim
    Else
      Return ""
    End If

  End Function

  Public Function LeerNivelIndicadores() As List(Of Nivel)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("liNivelAcadInd", cn)
    Dim dr As SqlDataReader = Nothing
    Dim Na As Nivel = Nothing
    Dim ListNa As List(Of Nivel) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ListNa = New List(Of Nivel)
      Do While (dr.Read)
        ListNa.Add(New Nivel(CInt(dr.Item("codigoNivel")), CStr(dr.Item("nombreNivel")), _
                             "", dr.Item("codigoModular").ToString))
      Loop
    Catch ex As Exception
      If ListNa IsNot Nothing Then
        ListNa.Clear()
      End If
      Na = Nothing
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

    Return ListNa
  End Function

  Public Function ListarSecciones(ByVal wAnio As AnioLectivo, ByVal wNivel As Nivel) As List(Of Seccion)
    Dim ls As List(Of Seccion) = Nothing
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liTodasSeccionesNivel", cn)
    Dim dr As SqlDataReader = Nothing
    Dim List As List(Of PeriodoAcademico) = Nothing
    Dim iCod As Integer, iLetra As Integer

    cmd.Parameters.AddWithValue("@Anio", wAnio.Anio)
    cmd.Parameters.AddWithValue("@Nivel", wNivel.Codigo)
    cmd.CommandType = CommandType.StoredProcedure
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      iCod = dr.GetOrdinal("codigoG")
      iLetra = dr.GetOrdinal("Letra")
      ls = New List(Of Seccion)
      Do While (dr.Read)
        ls.Add(New Seccion(wAnio, New Grado(dr.GetInt16(iCod)), dr.GetString(iLetra)) _
               )
        ls.Item(ls.Count - 1).Grado.Nivel = wNivel
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

  'Tania Incio
  Public Function ListarDirectorNivel(ByVal nivel As Integer) As Persona
    Dim pars As New List(Of CParametro)
    Dim Director As New Persona
    Dim dr As SqlDataReader
    Dim nombre As Integer, apellidoPat As Integer, apellidoMat As Integer

    pars.Add(New CParametro("@nivel", nivel))
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liDirectorNivel", pars)
      nombre = dr.GetOrdinal("nombre")
      apellidoPat = dr.GetOrdinal("apellidoPat")
      apellidoMat = dr.GetOrdinal("apellidoMat")
      If dr.Read Then
        Director = New Persona(dr.GetString(nombre), dr.GetString(apellidoPat), dr.GetString(apellidoMat))
      End If

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      pars = Nothing
    End Try

    Return Director
  End Function
End Class
