Public Class RNNotaCapacidad
  Inherits CADO

  Public Sub Registrar(ByVal obj As NotaCapacidad)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iNotaCapacidad", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Matricula", obj.Matricula.Numero)
      .AddWithValue("@Periodo", obj.Periodo.Codigo)
      .AddWithValue("@DocenteCarga", obj.Unidad.DocenteCarga.Codigo)
      .AddWithValue("@NumeroUnidad", obj.Unidad.Numero)
      .AddWithValue("@Capacidad", obj.Capacidad.Codigo)
      .AddWithValue("@Promedio", obj.Promedio)
      .AddWithValue("@Personal", obj.Personal.Codigo)
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

  Public Function ListarNotas(ByVal wUnidad As Unidad) As List(Of NotaCapacidad)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liNotaCapacidad", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ln As List(Of NotaCapacidad) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codPeriodo", wUnidad.Periodo.Codigo)
      .AddWithValue("@codDocCarga", wUnidad.DocenteCarga.Codigo)
      .AddWithValue("@nroUni", wUnidad.Numero)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ln = New List(Of NotaCapacidad)
      While dr.Read
        ln.Add(New NotaCapacidad(CInt(dr.Item("codigoNota")), CDbl(dr.Item("promedio")), Now, True, _
                                 New Matricula(CInt(dr.Item("nroMatricula")), New Alumno(CInt(dr.Item("codigoPersona")), _
                                dr.Item("nombre").ToString, dr.Item("apellidoPat").ToString, dr.Item("apellidoMat").ToString), _
                                CInt(dr.Item("nroOrden"))), Nothing, Nothing, New Capacidad(CInt(dr.Item("codigoCapac"))), _
                                wUnidad))
      End While

    Catch ex As Exception
      Throw ex
    Finally
      If dr IsNot Nothing Then
        dr.Close()
      End If
      dr = Nothing
      cmd = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn = Nothing
    End Try
    Return ln
  End Function

  Public Sub RegistrarNuevaNota(ByVal obj As NotaCapacidad, ByVal objP As Personal)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iNotaCapacidad", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Matricula", obj.Matricula.Numero)
      .AddWithValue("@Periodo", obj.Periodo.Codigo)
      .AddWithValue("@DocenteCarga", obj.Unidad.DocenteCarga.Codigo)
      .AddWithValue("@NumeroUnidad", obj.Unidad.Numero)
      .AddWithValue("@Capacidad", obj.Capacidad.Codigo)
      .AddWithValue("@Promedio", obj.Promedio)
      .AddWithValue("@Personal", objP.Codigo)
    End With
    'With cmd.Parameters
    '  .AddWithValue("@codNota", obj.Codigo)
    '  .AddWithValue("@nota", obj.Promedio)
    '  .AddWithValue("@fecha", obj.Fecha)
    '  .AddWithValue("@codPersonal", objP.Codigo)
    'End With

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

  Public Function LeerNota(ByVal Obj As NotaCapacidad) As NotaCapacidad
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lNota", cn)
    Dim dr As SqlDataReader
    Dim nota As NotaCapacidad = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@nroMatricula", Obj.Matricula.Numero)
    cmd.Parameters.AddWithValue("@codPeriodo", Obj.Unidad.Periodo.Codigo)
    cmd.Parameters.AddWithValue("@codDocCarga", Obj.Unidad.DocenteCarga.Codigo)
    cmd.Parameters.AddWithValue("@nroUni", Obj.Unidad.Numero)
    cmd.Parameters.AddWithValue("@codCapacidad", Obj.Capacidad.Codigo)

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read Then
        nota = New NotaCapacidad(CInt(dr.Item("codigoNota")), CDbl(dr.Item("promedio")))
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

  Public Function ListarNotasCurso(ByVal obj As NotaCapacidad) As List(Of NotaCapacidad)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liNotasCur", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ln As List(Of NotaCapacidad) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoG", obj.Matricula.Grado.Codigo)
      .AddWithValue("@Letra", obj.Matricula.Letra)
      .AddWithValue("@Periodo", obj.Periodo.Codigo)
      .AddWithValue("@DocCarga", obj.Unidad.DocenteCarga.Codigo)
      .AddWithValue("@CodCapac", obj.Capacidad.Codigo)
      .AddWithValue("@NroUni", obj.Unidad.Numero)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ln = New List(Of NotaCapacidad)
      While dr.Read
        ln.Add(New NotaCapacidad(CInt(dr.Item("codigoNota")), CDbl(dr.Item("promedio")), Now, True, _
                                 New Matricula(0, New Alumno(0, "", "", ""), _
                                CInt(dr.Item("nroOrden"))), New PeriodoAcademico(), _
                                New Personal(), New Capacidad(CInt(dr.Item("codigoCapac"))), _
                                New Unidad()))
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

  Public Function ListarNotasArea(ByVal obj As NotaCapacidad) As List(Of NotaCapacidad)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liNotasCurArea", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ln As List(Of NotaCapacidad) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoG", obj.Matricula.Grado.Codigo)
      .AddWithValue("@Letra", obj.Matricula.Letra)
      .AddWithValue("@Periodo", obj.Periodo.Codigo)
      .AddWithValue("@DocCarga", obj.Unidad.DocenteCarga.Codigo)
      .AddWithValue("@CodCapac", obj.Capacidad.Codigo)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ln = New List(Of NotaCapacidad)
      While dr.Read
        ln.Add(New NotaCapacidad(0, CDbl(dr.Item("promedio")), Now, True, _
                                 New Matricula(0, New Alumno(0, "", "", ""), _
                                CInt(dr.Item("nroOrden"))), New PeriodoAcademico(), _
                                New Personal(), New Capacidad(), _
                                New Unidad()))
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

  Public Function ListarConsolidadoNotasArea(ByVal obj As NotaCapacidad) As List(Of NotaCapacidad)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liNotasConsolidadoSec", cn)
    Dim dr As SqlDataReader = Nothing
    Dim ln As List(Of NotaCapacidad) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@CodigoG", obj.Matricula.Grado.Codigo)
      .AddWithValue("@Letra", obj.Matricula.Letra)
      .AddWithValue("@Periodo", obj.Periodo.Codigo)
      .AddWithValue("@CodArea", obj.Capacidad.AreaDre.Codigo)
      .AddWithValue("@CodCapac", obj.Capacidad.Codigo)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      ln = New List(Of NotaCapacidad)
      While dr.Read
        ln.Add(New NotaCapacidad(0, CDbl(dr.Item("promedio")), Now, True, _
                                 New Matricula(0, New Alumno(0, "", "", ""), _
                                CInt(dr.Item("nroOrden"))), New PeriodoAcademico(), _
                                New Personal(), New Capacidad(), _
                                New Unidad()))
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

  Public Function LeerNotaFinalCapac(ByVal Obj As NotaCapacidad, ByVal objP As PeriodoAcademico) As Double
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liNotasCapacidad", cn)
    'Dim dr As SqlDataReader
    Dim nota As Double

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@NroMatricula", Obj.Matricula.Numero)
    cmd.Parameters.AddWithValue("@CodPeriodo", objP.Codigo)
    cmd.Parameters.AddWithValue("@CodCapac", Obj.Capacidad.Codigo)

    Try
      cn.Open()
      nota = CDbl(cmd.ExecuteScalar)
      'If dr.Read Then
      '  nota = New NotaCapacidad(0, CDbl(dr.Item("promedio")))
      'End If
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

  Public Function LeerNotaFinalArea(ByVal Obj As NotaCapacidad, ByVal objP As PeriodoAcademico) As Double
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liNotaArea", cn)
    'Dim dr As SqlDataReader
    Dim nota As Double

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@NroMatricula", Obj.Matricula.Numero)
    cmd.Parameters.AddWithValue("@CodPeriodo", objP.Codigo)
    cmd.Parameters.AddWithValue("@CodArea", Obj.Capacidad.AreaDre.Codigo)

    Try
      cn.Open()
      nota = CDbl(cmd.ExecuteScalar)
      'If dr.Read Then
      '  nota = New NotaCapacidad(0, CDbl(dr.Item("promedio")))
      'End If
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

  Public Sub RegistrarNotas(ByVal wNotas As List(Of NotaCapacidad))
    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@Matricula", 0), _
                                    New CParametro("@Periodo", 0), _
                                    New CParametro("@DocenteCarga", 0), _
                                    New CParametro("@NumeroUnidad", 0), _
                                    New CParametro("@Capacidad", 0), _
                                    New CParametro("@Promedio", 0), _
                                    New CParametro("@Personal", 0)})

    Try
      Me.Conectar(True)
      Me.EjecutarSQL("ALTER TABLE Nota_Capacidad DISABLE TRIGGER tr_ActualizarPromedioUnidad;" & _
                     "ALTER TABLE Nota_Capacidad DISABLE TRIGGER tr_VerificarPeriodoAbiertoSecundaria;")
      For Each nc As NotaCapacidad In wNotas
        pars.Item(0).Valor = nc.Matricula.Numero
        pars.Item(1).Valor = nc.Unidad.Periodo.Codigo
        pars.Item(2).Valor = nc.Unidad.DocenteCarga.Codigo
        pars.Item(3).Valor = nc.Unidad.Numero
        pars.Item(4).Valor = nc.Capacidad.Codigo
        pars.Item(5).Valor = nc.Promedio
        pars.Item(6).Valor = nc.Personal.Codigo

        Me.EjecutarOrden("pr_iNotaCapacidad", pars)
      Next
      Me.EjecutarSQL("ALTER TABLE Nota_Capacidad ENABLE TRIGGER tr_ActualizarPromedioUnidad;" & _
                     "ALTER TABLE Nota_Capacidad ENABLE TRIGGER tr_VerificarPeriodoAbiertoSecundaria;")
      With wNotas.Item(0)
        Me.EjecutarSQL("UPDATE nota_capacidad SET vigencia = vigencia WHERE codigoDocenteCarga= " & .Unidad.DocenteCarga.Codigo & _
          " AND codigoPeriodo = " & .Unidad.Periodo.Codigo & " AND nroUni = " & .Unidad.Numero)
      End With
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      pars.Clear()
      pars = Nothing
    End Try

  End Sub

End Class
