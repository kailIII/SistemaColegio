Public Class RNObligacion
  Inherits CADO

  Public Function ListarObligaciones(ByVal wMesesAdicionales As Integer) As List(Of Obligacion)
    Dim lo As New List(Of Obligacion)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liPensionesT", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@MesesAdicionales", wMesesAdicionales)
    Try
      cn.Open()
      'Aumentar el tiempo de espera para solicitar los datos
      cmd.CommandTimeout = 0
      dr = cmd.ExecuteReader
      While dr.Read
        lo.Add(New Obligacion(CInt(dr.Item("codigoObligacion")), dr.Item("descripcionComp").ToString, _
                    CDbl(dr.Item("MontoTot")), True, CDate(dr.Item("fechaVcto")), Nothing, _
                    New Matricula(CInt(dr.Item("nroMatricula")), _
                        New Alumno(CInt(dr.Item("codigoAlumno")), dr.Item("nombre").ToString, _
                                      dr.Item("ApellidoPat").ToString, dr.Item("ApellidoMat").ToString, "", _
                                      dr.Item("codigoRecaudacion").ToString), 0), _
                    Nothing, dr.Item("tipo").ToString, 0) _
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

    Return lo
  End Function

  Public Function LeerDetalles(ByVal wObligacion As Integer, ByRef wMora As Servicio) As Obligacion
    Dim o As Obligacion = Nothing
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lDetallesObligacion", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Obligacion", wObligacion)

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read Then
        o = New Obligacion(wObligacion, dr.Item("descripcion").ToString, CDbl(dr.Item("Monto")), CBool(dr.Item("Vigencia")), Nothing, _
                           New Servicio() With {.Codigo = CInt(dr.Item("codigoServicio")), .entidad = dr.Item("Entidad").ToString}, _
                           New Matricula(CInt(dr.Item("nroMatricula"))), Nothing)
        If dr.IsDBNull(dr.GetOrdinal("Mora")) = False Then
          wMora = New Servicio(CInt(dr.Item("Mora")))
        End If
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

    Return o
  End Function

  Public Function LeerDeProgramacion(ByVal wCodigoAlumno As String, ByVal wProgramacion As Integer, ByRef wMora As Servicio) As Obligacion
    Dim o As Obligacion = Nothing
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader = Nothing

    pars.AddRange(New CParametro() {New CParametro("@CodigoAlumno", CInt(wCodigoAlumno)), _
                                    New CParametro("@Programacion", wProgramacion)})

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_lObligacion_Programacion", pars)
      If dr.Read Then
        o = New Obligacion
        o.Codigo = CInt(dr.Item("CodigoObligacion"))
        o.Descripcion = dr.Item("descripcion").ToString
        o.Monto = CDbl(dr.Item("Monto"))
        o.Vigencia = True
        o.Servicio = New Servicio() With {.Codigo = CInt(dr.Item("codigoServicio")), .entidad = dr.Item("Entidad").ToString}
        o.Matricula = New Matricula() With {.Numero = CInt(dr.Item("nroMatricula"))}
        If dr.IsDBNull(dr.GetOrdinal("Mora")) = False Then
          wMora = New Servicio(CInt(dr.Item("Mora")))
        End If
      End If
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars.Clear()
      pars = Nothing
    End Try

    Return o
  End Function

  Public Sub CambiarVigencia(ByVal wObligacion As Obligacion)
    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@Obligacion", wObligacion.Codigo), _
                                    New CParametro("@Vigencia", wObligacion.Vigencia)})

    Try
      Me.Conectar(False)
      Me.EjecutarOrden("pr_aObligacion_CambiarVigencia", pars)

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try
  End Sub

  Public Function Leer(ByVal wObligacion As Obligacion) As Obligacion
    Dim o As Obligacion = Nothing
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_lObligacion", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@Obligacion", wObligacion.Codigo)

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      If dr.Read Then
        o = New Obligacion(wObligacion.Codigo, dr.Item("descripcion").ToString, CDbl(dr.Item("Monto")), CBool(dr.Item("Vigencia")), CDate(dr.Item("fechaVcto")), _
                           New Servicio() With {.Codigo = CInt(dr.Item("codigoServicio"))}, _
                           New Matricula(CInt(dr.Item("nroMatricula"))), Nothing)
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

    Return o
  End Function

  Public Sub Actualizar(ByVal wObligacion As Obligacion)
    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@Obligacion", wObligacion.Codigo), _
                                    New CParametro("@Descripcion", wObligacion.Descripcion), _
                                    New CParametro("@Monto", wObligacion.Monto)})

    Try
      Me.Conectar(False)
      Me.EjecutarOrden("pr_aObligacion", pars)

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try
  End Sub

  Public Function CalcularBeneficio(ByVal wObligacion As Obligacion) As Beneficio
    Dim ben As Beneficio = Nothing
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader

    pars.Add(New CParametro("@CodigoObligacion", wObligacion.Codigo))

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_lCalcularBeneficio", pars)
      If dr.Read Then
        ben = New Beneficio
        ben.Motivo = "DESCUENTO POR BENEFICIO"
        ben.Descuento = dr.GetDecimal(dr.GetOrdinal("descuento"))
        ben.Vigencia = True
      End If
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      dr = Nothing
      pars = Nothing
    End Try

    Return ben
  End Function

  Public Function ListarConsolidadoPagos(ByVal wAnio As Integer, ByVal wEntidad As String, ByVal wFechaRef As Date) As DataTable
    Dim dt As DataTable
    Dim sql As String = ""

    Try
      Me.Conectar(False)
      sql = Me.CrearSentencia(wAnio, wEntidad, wFechaRef, "WHERE M.vigencia = 1 AND M.Anio =" & wAnio & " and O.vigencia = 1", "", True)
      dt = Me.EjecutarSQLDatos(sql)
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    End Try

    Return dt
  End Function

  Private Function CrearSentencia(ByVal wAnio As Integer, ByVal wEntidad As String, ByVal wFechaRef As Date, ByVal wCondicion As String, ByVal wHaving As String, ByVal wMostrarTodos As Boolean) As String
    Dim pars As New List(Of CParametro)
    Dim sql As String = "SELECT A.CodigoRecaudacion, P.apellidoPat + ' ' + P.apellidoMat + ' ' + P.nombre AS Alumno, " & _
                        "	RTRIM( na.siglAS ) + ' ' + CAST( G.numero AS VARCHAR(4) ) + '-' + M.letra AS Seccion "
    Dim dr As SqlDataReader

    pars.Add(New CParametro("@Anio", wAnio))
    pars.Add(New CParametro("@Entidad", wEntidad))
    pars.Add(New CParametro("@MostrarTodos", wMostrarTodos))
    dr = Me.PedirDataReader("pr_liProgramacionAnio", pars)
    While dr.Read
      sql &= ", SUM( CASE WHEN O.descripcion = '" & dr.GetString(0) & "' THEN O.monto - ISNULL( B.descuento, 0) - ISNULL( Pag.Total, 0) ELSE 0 END) AS [" & dr.GetString(0) & "]"
    End While
    sql &= ", ( SELECT TOP 1 Motivo FROM Beneficio B JOIN Obligacion Ob ON B.codigoObligacion = Ob.codigoObligacion WHERE Ob.nroMatricula = M.nroMatricula AND B.vigencia = 1 ) AS Beneficio"
    dr.Close()

    sql &= " FROM Persona P JOIN Alumno A ON A.codigoAlumno = P.codigoPersona " & _
          "JOIN Matricula M ON M.codigoAlumno = A.codigoAlumno " & _
          "JOIN Grado G ON G.codigoG = M.codigoG " & _
          "JOIN Nivel_Academico NA ON NA.codigonivel = G.codigoNivel " & _
          "LEFT OUTER JOIN (" & _
              "SELECT O.* FROM Obligacion O JOIN Servicio S ON S.codigoServicio = O.codigoServicio WHERE S.entidad = '" & wEntidad & "'" & _
              IIf(wMostrarTodos = True, "", " AND S.caduca = 1 ").ToString & _
            ") O ON O.nroMatricula = m.nroMatricula " & _
          "LEFT OUTER JOIN ( " & _
            "SELECT B.codigoObligacion, SUM ( B.descuento) AS descuento " & _
            "	FROM Beneficio B " & _
            "	WHERE B.vigencia = 1 " & _
            "	GROUP BY B.codigoObligacion " & _
          "	) AS B ON B.codigoObligacion = O.codigoObligacion " & _
          "LEFT OUTER JOIN ( " & _
            "SELECT DDI.CodigoObligacion, SUM( DDI.monto) AS Total " & _
            "	FROM DOCUMENTO_INGRESO DI JOIN DETALLE_DCTO_INGRESO DDI ON DI.codigoDocumentoIngreso = DDI.codigoDocumentoIngreso " & _
            "	WHERE DI.entidad = '" & wEntidad & "' AND DI.vigencia = 1 AND DATEDIFF( DAY, DI.fecha, '" & wFechaRef.ToString("yyyyMMdd") & "') >=0 " & _
            "	GROUP BY DDI.codigoObligacion " & _
          "	) AS Pag ON Pag.CodigoObligacion = O.codigoObligacion "

    sql &= wCondicion & _
        " GROUP BY A.codigoRecaudacion, P.apellidoPat, P.apellidoMat, P.nombre, na.orden, na.siglas, G.numero, M.letra, m.nroMatricula " & _
        wHaving & _
        " ORDER BY na.orden, g.numero, m.letra, alumno"

    Return sql
  End Function

  'FRANKLIN TERAN SANTA CRUZ
  'LISTA EL CONSOLIDADO DE PAGOS DE LOS ALUMNOS QUE AÚN MANTIENEN, EN BASE A LA SECCIÓN SOLICITADA
  '2012-01-02
  Public Function ListarConsolidadoPagosSeccion(ByVal wAnio As Integer, ByVal wEntidad As String, ByVal wSeccion As Seccion, ByVal wFechaRef As Date) As DataTable
    Dim dt As DataTable
    Dim sql As String = ""

    Try
      Me.Conectar(False)
      sql = Me.CrearSentencia(wAnio, wEntidad, wFechaRef, "WHERE M.vigencia = 1 AND M.Anio = " & wAnio & " AND M.codigoG = " & _
                              wSeccion.Grado.Codigo & " AND M.letra = '" & wSeccion.Letra & "' AND O.vigencia = 1", "", True)
      dt = Me.EjecutarSQLDatos(sql)
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    End Try

    Return dt
  End Function

  'FRANKLIN TERAN SANTA CRUZ
  'LISTA EL CONSOLIDADO DE PAGOS DE LOS ALUMNOS QUE AÚN MANTIENEN, EN BASE AL NIVEL SOLICITADO
  '2012-01-02
  Public Function ListarConsolidadoPagosNivel(ByVal wAnio As Integer, ByVal wEntidad As String, ByVal wNivel As Nivel, ByVal wFechaRef As Date) As DataTable
    Dim dt As DataTable
    Dim sql As String = ""

    Try
      Me.Conectar(False)
      sql = Me.CrearSentencia(wAnio, wEntidad, wFechaRef, "WHERE M.vigencia = 1 AND M.Anio = " & wAnio & _
                " AND G.codigoNivel = " & wNivel.Codigo & " AND O.vigencia = 1", "", True)

      dt = Me.EjecutarSQLDatos(sql)
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    End Try

    Return dt
  End Function

  'FRANKLIN TERAN SANTA CRUZ
  'LISTA EL CONSOLIDADO DE PAGOS DE LOS ALUMNOS QUE AÚN MANTIENEN, EN BASE AL AÑO, TIPO DE INSTITUCIÓN Y FECHA DE VENCIMIENTO DEL PAGO PROGRAMADO
  '2012-01-02
  Public Function ListarConsolidadoPagosDeudores(ByVal wAnio As Integer, ByVal wEntidad As String, ByVal wFechaRef As Date) As DataTable
    Dim dt As DataTable
    Dim sql As String = ""

    Try
      Me.Conectar(False)
      sql = Me.CrearSentencia(wAnio, wEntidad, wFechaRef, "WHERE M.vigencia = 1 AND M.Anio = " & wAnio & " AND O.vigencia = 1", _
                              "HAVING SUM( CASE WHEN DATEDIFF( DAY, O.fechaVcto, GETDATE() ) > 0 THEN ISNULL( O.monto, 0) - ISNULL( B.descuento, 0) - ISNULL( Pag.Total, 0) ELSE 0 END   ) > 0 ", False)
      dt = Me.EjecutarSQLDatos(sql)
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    End Try

    Return dt
  End Function

  Public Function ListarResumenPagosAnioEntidad(ByVal wEntidad As String, _
        ByVal wFechaInicio As Date, ByVal wFechaFin As Date) As DataTable

    Dim pars As New List(Of CParametro)
    Dim dt As DataTable = Nothing

    pars.AddRange(New CParametro() {New CParametro("@Entidad", "I"), _
                    New CParametro("@FechaIni", wFechaInicio), _
                    New CParametro("@FechaFin", wFechaFin)})

    Try
      Me.Conectar(False)
      dt = Me.PedirDatatable("pr_liResumenIngresosMotivoEntidad", pars)
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      pars = Nothing
    End Try

    Return dt
  End Function

  Public Function ListarDeudores(ByVal wFechaRef As Date) As DataTable
    Dim dt As DataTable = Nothing


    Return dt
  End Function

  Public Sub CambiarMatricula(ByVal wObligacion As Obligacion, ByVal wMatricula As Matricula)
    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@Obligacion", wObligacion.Codigo), _
                                    New CParametro("@Matricula", wMatricula.Numero)})

    Try
      Me.Conectar(False)
      Me.EjecutarOrden("pr_aCambiarMatriculaObligacion", pars)

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try
  End Sub

  Public Sub DesasociarPago(ByVal wDetalle As DetalleDocumentoIngreso)
    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@DocumentoIngreso", wDetalle.Documento.Codigo), _
                                    New CParametro("@Numero", wDetalle.Numero)})

    Try
      Me.Conectar(False)
      Me.EjecutarOrden("pr_aDesasociarDetalleDocumento", pars)

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try
  End Sub

  'Lista los servicios programados en el presente año
  Public Function ListarServiciosProgramados(ByVal wAnio As AnioLectivo) As List(Of Servicio)
    Dim servicios As List(Of Servicio) = Nothing
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim iNombre As Integer

    pars.Add(New CParametro("@Anio", wAnio.Anio))
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liServiciosProgramados", pars)
      iNombre = dr.GetOrdinal("descripcion")
      servicios = New List(Of Servicio)
      While dr.Read
        servicios.Add(New Servicio With {.Nombre = dr.GetString(iNombre)})
      End While
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      pars.Clear()
      pars = Nothing
    End Try

    Return servicios
  End Function

  'Lista los alumnos pendientes de pago
  Public Function ListarAlumnosPendientesPago(ByVal wNombre As String) As DataTable
    Dim pars As New List(Of CParametro)
    Dim dt As DataTable

    pars.Add(New CParametro("@Servicio", wNombre))

    Try
      Me.Conectar(False)
      dt = Me.PedirDatatable("pr_liAlumnosPendientesPago", pars)

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

End Class
