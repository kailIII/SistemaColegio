Public Class RNParentesco
  Inherits CADO

  Public Function VerificarPadresAlumno(ByVal obj As Alumno) As List(Of Parentesco)
    Dim lp As New List(Of Parentesco)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lPadresSeccion", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@CodigoAlu", obj.Codigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        lp.Add(New Parentesco(New Apoderado(CInt(dr.Item("codigoApoderado"))), New Alumno(), dr.Item("parentesco").ToString))
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

    Return lp
  End Function

  Public Function ListarPadresAlumno(ByVal wcodigo As Integer) As List(Of Parentesco)
    Dim la As New List(Of Parentesco)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liPadres_Alumno", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Codigo", wcodigo)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        la.Add(New Parentesco(New Apoderado(CInt(dr.Item("CodigoPersona")), dr.Item("Nombre").ToString, dr.Item("ApellidoPat").ToString, _
               dr.Item("ApellidoMat").ToString), dr.Item("parentesco").ToString))

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

  Public Sub ModificarParentesco(ByVal wAlumno As Alumno, ByVal wParientes As List(Of Parentesco))
    Dim params As New List(Of CParametro)

    params.Add(New CParametro("@Alumno", wAlumno.Codigo))
    params.Add(New CParametro("@Pariente", 0))
    params.Add(New CParametro("@Vinculo", ""))

    Try
      Me.Conectar(True)
      Me.EjecutarSQL("ALTER TABLE Parentesco DISABLE TRIGGER des_VerificarPadreMadre")
      For Each par As Parentesco In wParientes
        params.Item(1).Valor = par.CodigoApoderado
        params.Item(2).Valor = par.Parentesco

        Me.EjecutarOrden("pr_aVinculoPariente", params)
      Next
      Me.EjecutarSQL("ALTER TABLE Parentesco ENABLE TRIGGER des_VerificarPadreMadre")
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      params.Clear()
      params = Nothing
    End Try
  End Sub

End Class
