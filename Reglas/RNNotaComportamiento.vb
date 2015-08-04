
Public Class RNNotaComportamiento
  Inherits CADO

  Public Sub Registrar(ByVal obj As NotaComportamiento)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iNotaComp", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@NroMat", obj.Matricula.Numero)
      .AddWithValue("@CodPeriodo", obj.Periodo.Codigo)
      .AddWithValue("@CodVirtud", obj.Virtud.Codigo)
      .AddWithValue("@Puntos", IIf(obj.Puntos > 0, obj.Puntos, DBNull.Value))
      .AddWithValue("@Letra", IIf(obj.Letra.Length > 0, obj.Letra, DBNull.Value))
      .AddWithValue("@CodPersonal", obj.Personal.Codigo)
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
      obj = Nothing
    End Try
  End Sub

  Public Function NotaComport(ByVal obj As NotaComportamiento) As NotaComportamiento
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liNotasComport", cn)
    Dim dr As SqlDataReader = Nothing
    Dim nota As NotaComportamiento = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("codigoVirtud", obj.Virtud.Codigo)
      .AddWithValue("@CodPeriodo", obj.Periodo.Codigo)
      .AddWithValue("@NroMat", obj.Matricula.Numero)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read Then
        nota = New NotaComportamiento(CInt(dr.Item("codigoNotaComp")), CInt(dr.Item("puntos")), _
                  dr.Item("letra").ToString, Now, True, New Matricula(), New PeriodoAcademico(), _
                  New Virtud(CInt(dr.Item("codigoVirtudComp"))), New Personal())
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

  Public Sub RegistrarNuevaNotaComp(ByVal obj As NotaComportamiento)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iNuevaNotaComp", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codNotaComp", obj.Codigo)
      .AddWithValue("@puntos", obj.Puntos)
      .AddWithValue("@letra", obj.Letra)
      .AddWithValue("@codPersonal", obj.Personal.Codigo)
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

  Public Function ListarComportamientoTrimestral(ByVal obj As NotaComportamiento) As List(Of NotaComportamiento)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liComportamientoTrim", cn)
    Dim dr As SqlDataReader = Nothing
    Dim nota As List(Of NotaComportamiento) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigoPeriodo", obj.Periodo.Codigo)
      .AddWithValue("@NroMatricula", obj.Matricula.Numero)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      nota = New List(Of NotaComportamiento)

      Do While dr.Read
        nota.Add(New NotaComportamiento(0, CInt(dr.Item("puntos")), _
                  dr.Item("literal").ToString, Now, True, New Matricula(), New PeriodoAcademico(), _
                  New Virtud(CInt(dr.Item("codigoVirtudComp")), dr.Item("nombre").ToString), New Personal()))
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
    Return nota
  End Function

  Public Function ListarVirtudesTrimestral(ByVal obj As Seccion, ByVal per As Integer) As List(Of Virtud)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liVirtudTrim", cn)
    Dim dr As SqlDataReader = Nothing
    Dim lv As List(Of Virtud) = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigoPeriodo", per)
      .AddWithValue("@CodigoNivel", obj.Grado.CodigoNivel)
    End With
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lv = New List(Of Virtud)
      Do While dr.Read
        lv.Add(New Virtud(CInt(dr.Item("codigoVirtudComp")), dr.Item("Nombre").ToString, _
                          CBool(dr.Item("vigencia")), New AnioLectivo(), _
                          New PeriodoAcademico(), New Nivel(), CInt(dr.Item("idVirtud"))))
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
    Return lv
  End Function

  Public Function LeerPuntosComportamiento(ByVal Obj As NotaComportamiento, ByVal objP As PeriodoAcademico) As Integer
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lPuntosComp", cn)
    Dim nota As Integer

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@NroMatricula", Obj.Matricula.Numero)
    cmd.Parameters.AddWithValue("@CodPeriodo", objP.Codigo)
    cmd.Parameters.AddWithValue("@CodVirtud", Obj.Virtud.Codigo)

    Try
      cn.Open()
      nota = CInt(cmd.ExecuteScalar)
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

  Public Function LeerNotaFinalComportamiento(ByVal Obj As NotaComportamiento, ByVal objP As PeriodoAcademico) As Double
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lPromComp", cn)
    Dim nota As Double

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@NroMatricula", Obj.Matricula.Numero)
    cmd.Parameters.AddWithValue("@CodPeriodo", objP.Codigo)

    Try
      cn.Open()
      nota = CDbl(cmd.ExecuteScalar)
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

  Public Sub Registrar(ByVal notas As List(Of NotaComportamiento))
    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@NroMat", 0),
                                    New CParametro("@codPeriodo", 0),
                                    New CParametro("@codVirtud", 0),
                                    New CParametro("@Puntos", 0),
                                    New CParametro("@Letra", 0),
                                    New CParametro("@codPersonal", 0)})
    Try
      Me.Conectar(True)
      For Each nc As NotaComportamiento In notas
        pars.Item(0).Valor = nc.Matricula.Numero
        pars.Item(1).Valor = nc.Periodo.Codigo
        pars.Item(2).Valor = nc.Virtud.Codigo
        pars.Item(3).Valor = nc.Puntos
        Select Case nc.Puntos
          Case 1
            pars.Item(4).Valor = "E"
          Case 2
            pars.Item(4).Valor = "P"
          Case 3
            pars.Item(4).Valor = "R"
          Case 4
            pars.Item(4).Valor = "O"
          Case 5
            pars.Item(4).Valor = "M"
        End Select
        pars.Item(5).Valor = nc.Personal.Codigo

        Me.EjecutarOrden("pr_iNotaComp", pars)
      Next
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars.Clear()
      pars = Nothing
    End Try
  End Sub

End Class
