
Public Class RNInvestigacion
  Inherits CADO

  Public Sub RegistrarAreaResponsableInvestigacion(ByVal pArea As AreaInvestigacion, ByVal pRespuesta As ResponsableInvestigacion)

    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@nombreA", pArea.Nombre), _
                                    New CParametro("@codigoG", pArea.Grado.Codigo), _
                                    New CParametro("@codigoPeriodo", pArea.Periodo.Codigo), _
                                    New CParametro("@codigoDocente", pRespuesta.Docente.Codigo), _
                                    New CParametro("@letra", pRespuesta.Seccion.Letra), _
                                    New CParametro("@anio", pRespuesta.Seccion.Anio.Anio)})

    Try
      Me.Conectar(False)
      Me.EjecutarOrden("pr_iAreaResponsablexSeccion", pars)
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try
  End Sub

  Public Sub ModificarAreaResponsableInvestigacion(ByVal pArea As AreaInvestigacion, ByVal codigoD As Integer, ByVal codigoR As Integer, ByVal codigoA As Integer,
                       ByVal codigoG As Integer)
    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@nombreA", pArea.Nombre), _
                                    New CParametro("@codigoActual", codigoA), _                                    
                                    New CParametro("@codigoDocente", codigoD), _
                                    New CParametro("@codigoR", codigoR), _
                                    New CParametro("@codigoG", codigoG), _
                                    New CParametro("@codigoPeriodo", pArea.Periodo.Codigo)})
    Try
      Me.Conectar(False)
      Me.EjecutarOrden("pr_aAreaResponsablexSeccion", pars)
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try
  End Sub

  Public Sub ModificarResponsableInvestigacion(ByVal pCodigoResponsable As Integer)

    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@codResponsableInv", pCodigoResponsable)})

    Try
      Me.Conectar(False)
      Me.EjecutarOrden("pr_aRespInvestigacionVigencia", pars)
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try
  End Sub

  Public Function ListarAreaInvestigacionXSeccion(ByVal codigoPeriodo As Integer) As List(Of ResponsableInvestigacion)
    Dim lc As List(Of ResponsableInvestigacion) = Nothing
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liAreaInvestigacionxSeccion", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigoPeriodo", codigoPeriodo)
    End With

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      lc = New List(Of ResponsableInvestigacion)
      While dr.Read
        lc.Add(New ResponsableInvestigacion(CInt(dr.Item("codigoRespInv")), dr.Item("Seccion").ToString, CInt(dr.Item("codigoG")), _
                                            New Docente(CInt(dr.Item("codigoDocente")), dr.Item("nombre").ToString, _
                                                        dr.Item("apellidoPat").ToString, dr.Item("apellidoMat").ToString), _
                                            New AreaInvestigacion(CInt(dr.Item("codigoAreaInv")), dr.Item("nombreA").ToString), _
                                            New Seccion(New AnioLectivo(dr.Item("anio").ToString), _
                                                        New Grado(CInt(dr.Item("codigoG")), CInt(dr.Item("codigoNivel")), "", CInt(dr.Item("numero"))), dr.Item("letra").ToString), dr.Item("nombreNivel").ToString))
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
    Return lc
  End Function

  Public Function ListarAreasInvestigacion(ByVal codigoPeriodo As Integer, ByVal codigoNivel As Integer) As List(Of AreaInvestigacion)

    Dim listParamet As New List(Of CParametro)
    Dim listAreas As New List(Of AreaInvestigacion)
    Dim drAreas As SqlDataReader
    Dim codigoArea As Integer, nombreArea As String

    listParamet.AddRange({New CParametro("@codigoPeriodo", codigoPeriodo), _
                          New CParametro("@codigoNivel", codigoNivel)})
    Try
      Me.Conectar(False)
      drAreas = Me.PedirDataReader("pr_liAreasInvestigacion", listParamet)
      While drAreas.Read
        'codigoArea = CInt(drAreas.Item("codigoAreaInv"))
        nombreArea = drAreas.Item("nombre").ToString
        listAreas.Add(New AreaInvestigacion(codigoArea, nombreArea))
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      listAreas = Nothing
      Throw ex
    Finally

      listParamet = Nothing
      drAreas = Nothing
    End Try
    Return listAreas
  End Function

  Public Function ListarResponsableInvestigacion(ByVal seccion As Seccion, ByVal anio As String) As String
    Dim responsable As String = Nothing
    Dim notas As New List(Of NotaInvestigacion)
    Dim dr As SqlDataReader
    Dim pars As New List(Of CParametro)
    pars.AddRange(New CParametro() {New CParametro("@CodigoG", seccion.Grado.Codigo), _
                                    New CParametro("@Letra", seccion.Letra), _
                                    New CParametro("@Anio", anio)})

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liResponsableInvestigacion", pars)
      If dr.Read = True Then
        responsable = dr.GetString(dr.GetOrdinal("nombre"))
      End If

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      pars = Nothing
    End Try

    Return responsable
  End Function
End Class
