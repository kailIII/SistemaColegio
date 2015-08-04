Public Class RNBeneficio
  Inherits CADO

  Public Sub Registrar(ByVal wBeneficio As Beneficio, ByVal wDetalle As DetalleBeneficio)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmdBeneficio As New SqlCommand("pr_iBeneficio", cn)
    Dim cmdDetalle As New SqlCommand("pr_iDetalleBeneficio", cn)
    Dim trx As SqlTransaction = Nothing


    '-----------------------------REGISTRO DE BENEFICIO---------------------------------
    Try
      cn.Open()
      trx = cn.BeginTransaction

      cmdBeneficio.Transaction = trx
      cmdBeneficio.CommandType = CommandType.StoredProcedure


      With (cmdBeneficio.Parameters)
        .AddWithValue("@Codigo", wBeneficio.Codigo).Direction = ParameterDirection.Output
        .AddWithValue("@Fecha", wBeneficio.Fecha)
        .AddWithValue("@Vigencia", wBeneficio.Vigencia)
        .AddWithValue("@codigoAdministrativo", wBeneficio.Administrativo.Codigo)
        .AddWithValue("@codigoAutorizador", wBeneficio.Autorizador.Codigo)

      End With
      cmdBeneficio.ExecuteNonQuery()

      '-----------------------------REGISTRO DE DETALLE BENEFICIO---------------------------------
      cmdDetalle.Transaction = trx
      cmdDetalle.CommandType = CommandType.StoredProcedure

      With cmdDetalle.Parameters
        .AddWithValue("@codigoBeneficio", 0)
        .AddWithValue("@NroMatricula", 0)
        .AddWithValue("@fechaini", 0)
        .AddWithValue("@fechafin", 0)
        .AddWithValue("@Descuento", 0)
        .AddWithValue("@Motivo", 0)

      End With

      cmdDetalle.Parameters.Item("@codigoBeneficio").Value = cmdBeneficio.Parameters.Item("@Codigo").Value

      With cmdDetalle.Parameters
        .Item("@NroMatricula").Value = wDetalle.Matricula.Numero
        .Item("@fechaini").Value = wDetalle.Fechaini
        .Item("@fechafin").Value = wDetalle.Fechafin
        .Item("@Descuento").Value = wDetalle.Descuento
        .Item("@Motivo").Value = wDetalle.Motivo

      End With
      cmdDetalle.ExecuteNonQuery()

      trx.Commit()
    Catch ex As Exception
      If trx IsNot Nothing Then
        trx.Rollback()
      End If
      Throw ex
    Finally
      cmdDetalle.Dispose()
      cmdDetalle = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
  End Sub

  Public Sub Actualizar(ByVal wBeneficios As List(Of Beneficio))
    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@Codigo", 0), _
                                    New CParametro("@Motivo", ""), _
                                    New CParametro("@Descuento", 0), _
                                    New CParametro("@Fecha", #1/1/2010#), _
                                    New CParametro("@Vigencia", False)})

    Try
      Me.Conectar(True)
      For Each ben In wBeneficios
        pars.Item(0).Valor = ben.Codigo
        pars.Item(1).Valor = ben.Motivo
        pars.Item(2).Valor = ben.Descuento
        pars.Item(3).Valor = ben.Fecha
        pars.Item(4).Valor = ben.Vigencia

        Me.EjecutarOrden("pr_aBeneficio", pars)
      Next

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try
  End Sub

  Public Sub Modificar(ByVal wBeneficio As Beneficio, ByVal wDetalle As DetalleBeneficio)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmdBeneficio As New SqlCommand("pr_aBeneficio", cn)
    Dim cmdDetalle As New SqlCommand("pr_aDetalleBeneficio", cn)
    Dim trx As SqlTransaction = Nothing


    '-----------------------------REGISTRO DE BENEFICIO---------------------------------
    Try
      cn.Open()
      trx = cn.BeginTransaction

      cmdBeneficio.Transaction = trx
      cmdBeneficio.CommandType = CommandType.StoredProcedure


      With (cmdBeneficio.Parameters)
        .AddWithValue("@Codigo", wBeneficio.Codigo)
        .AddWithValue("@Fecha", wBeneficio.Fecha)
        .AddWithValue("@Vigencia", wBeneficio.Vigencia)
        .AddWithValue("@codigoAdministrativo", wBeneficio.Administrativo.Codigo)
        .AddWithValue("@codigoAutorizador", wBeneficio.Autorizador.Codigo)

      End With
      cmdBeneficio.ExecuteNonQuery()

      '-----------------------------REGISTRO DE DETALLE BENEFICIO---------------------------------
      cmdDetalle.Transaction = trx
      cmdDetalle.CommandType = CommandType.StoredProcedure

      With cmdDetalle.Parameters
        .AddWithValue("@codigoBeneficio", 0)
        .AddWithValue("@NroMatricula", 0)
        .AddWithValue("@numero", 0)
        .AddWithValue("@fechaini", 0)
        .AddWithValue("@fechafin", 0)
        .AddWithValue("@Descuento", 0)
        .AddWithValue("@Motivo", 0)
      End With

      With cmdDetalle.Parameters
        .Item("@codigoBeneficio").Value = wDetalle.Beneficio.Codigo
        .Item("@NroMatricula").Value = wDetalle.Matricula.Numero
        .Item("@numero").Value = wDetalle.Numero
        .Item("@fechaini").Value = wDetalle.Fechaini
        .Item("@fechafin").Value = wDetalle.Fechafin
        .Item("@Descuento").Value = wDetalle.Descuento
        .Item("@Motivo").Value = wDetalle.Motivo
      End With
      cmdDetalle.ExecuteNonQuery()

      trx.Commit()
    Catch ex As Exception
      If trx IsNot Nothing Then
        trx.Rollback()
      End If
      Throw ex
    Finally
      cmdDetalle.Dispose()
      cmdDetalle = Nothing
      If cn.State = ConnectionState.Open Then
        cn.Close()
      End If
      cn.Dispose()
      cn = Nothing
    End Try
  End Sub

  Public Function Listar() As List(Of DetalleBeneficio)
    Dim ldb As New List(Of DetalleBeneficio)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_liBeneficio", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure

    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        ldb.Add(New DetalleBeneficio(CInt(dr.Item("codigoAlumno")), CStr(dr.Item("ApellidoPat")), _
                                     CStr(dr.Item("ApellidoMat")), CStr(dr.Item("Nombre")), _
                                     CDate(dr.Item("fecha")), CInt(dr.Item("codigoAutorizador")), _
                                     CBool(dr.Item("Vigencia")), CInt(dr.Item("CodigoBeneficio")), _
                                     CInt(dr.Item("nroMatricula")), CInt(dr.Item("numero")), CDbl(dr.Item("Descuento")), CDate(dr.Item("fechaini")), CDate(dr.Item("fechafin")), CStr(dr.Item("Motivo"))))
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
    Return ldb

  End Function

  Public Function DevolverDetalleBeneficio(ByVal wnroMatricula As Integer, ByVal wfecha As DateTime) As DetalleBeneficioDctoIngreso
    Dim db As New DetalleBeneficioDctoIngreso
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_devolverCodigoDetBeneficio", cn)
    Dim dr As SqlDataReader = Nothing

    cmd.CommandType = CommandType.StoredProcedure
    cmd.Parameters.AddWithValue("@fecha", wfecha)
    cmd.Parameters.AddWithValue("@nroMatricula", wnroMatricula)
    Try
      cn.Open()
      dr = cmd.ExecuteReader
      While dr.Read
        db = New DetalleBeneficioDctoIngreso(CInt(dr.Item("nroMatricula")), CInt(dr.Item("numero")), _
                                             CInt(dr.Item("codigoBeneficio")), 0, 0)
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
    Return db
  End Function

  Public Sub Registrar(ByVal wBeneficio As Beneficio, ByVal wObligaciones As List(Of ProgramacionPago), ByVal wAlumnos As List(Of Matricula))
    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@Autorizador", wBeneficio.Autorizador.Codigo), _
                                    New CParametro("@Administrativo", wBeneficio.Administrativo.Codigo), _
                                    New CParametro("@Motivo", wBeneficio.Motivo), _
                                    New CParametro("@Fecha", wBeneficio.Fecha), _
                                    New CParametro("@Descuento", wBeneficio.Descuento), _
                                    New CParametro("@Obligacion", 0), _
                                    New CParametro("@Matricula", 0)})
    Try
      Me.Conectar(True)

      For Each al In wAlumnos
        pars.Item(6).Valor = al.Numero

        For Each pp In wObligaciones
          pars.Item(5).Valor = pp.Descripcion
          Me.EjecutarOrden("pr_iBeneficio_Matricula", pars)
        Next
      Next

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally

    End Try
  End Sub

  Public Function ListarMotivos() As List(Of String)
    Dim dr As SqlDataReader
    Dim iMotivo As Integer
    Dim motivos As List(Of String) = Nothing

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liMotivos", Nothing)
      iMotivo = dr.GetOrdinal("Motivo")
      motivos = New List(Of String)
      While dr.Read
        motivos.Add(dr.GetString(iMotivo))
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
    Finally
      dr = Nothing
    End Try

    Return motivos
  End Function

  Public Function Resumen(ByVal wAnio As AnioLectivo) As List(Of BeneficioResumen)
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim beneficios As List(Of BeneficioResumen) = Nothing
    Dim iMotivo, iDescuento, iNivel, iCantidad As Integer

    pars.Add(New CParametro("@Anio", wAnio.Anio))

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liResumenBeneficios_Cantidad", pars)
      iMotivo = dr.GetOrdinal("Motivo")
      iDescuento = dr.GetOrdinal("Descuento")
      iNivel = dr.GetOrdinal("NombreNivel")
      iCantidad = dr.GetOrdinal("Cantidad")
      beneficios = New List(Of BeneficioResumen)
      While dr.Read
        beneficios.Add(New BeneficioResumen)
        With beneficios.Item(beneficios.Count - 1)
          .Motivo = dr.GetString(iMotivo)
          .Descuento = dr.GetDecimal(iDescuento)
          .Nivel = New Nivel(0, dr.GetString(iNivel), "")
          .Cantidad = dr.GetInt32(iCantidad)
        End With
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
    Finally
      pars = Nothing
      dr = Nothing
    End Try

    Return beneficios
  End Function

  Public Function ListarAlumno(ByVal wAnio As AnioLectivo, ByVal wAlumno As Alumno) As List(Of Beneficio)
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim beneficios As List(Of Beneficio) = Nothing
    Dim iCodigo, iMotivo, iDescripcion, iDescuento, iFechaVenc, iVigencia, iFecha As Integer

    pars.Add(New CParametro("@Anio", wAnio.Anio))
    pars.Add(New CParametro("@Alumno", wAlumno.Codigo))

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liBeneficios_AlumnoAnio", pars)
      iCodigo = dr.GetOrdinal("codigoBeneficio")
      iMotivo = dr.GetOrdinal("Motivo")
      iDescripcion = dr.GetOrdinal("Descripcion")
      iFechaVenc = dr.GetOrdinal("fechaVcto")
      iDescuento = dr.GetOrdinal("Descuento")
      iVigencia = dr.GetOrdinal("Vigencia")
      iFecha = dr.GetOrdinal("Fecha")
      beneficios = New List(Of Beneficio)
      While dr.Read
        beneficios.Add(New Beneficio)
        With beneficios.Item(beneficios.Count - 1)
          .Codigo = dr.GetInt16(iCodigo)
          .Motivo = dr.GetString(iMotivo)
          .Fecha = dr.GetDateTime(iFecha)
          .Descuento = dr.GetDecimal(iDescuento)
          .Vigencia = dr.GetBoolean(iVigencia)
          .Obligacion = New Obligacion
          With .Obligacion
            .Descripcion = dr.GetString(iDescripcion)
            .FechaVencimiento = dr.GetDateTime(iFechaVenc)
          End With
        End With
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
    Finally
      pars = Nothing
      dr = Nothing
    End Try

    Return beneficios
  End Function

  Public Function ListarBeneficiados(ByVal wAnio As AnioLectivo, ByVal wMotivo As String, ByVal wPagoProgramado As String) As List(Of AlumnoBeneficiado)
    Dim lista As List(Of AlumnoBeneficiado) = Nothing
    Dim dr As SqlDataReader
    Dim pars As New List(Of CParametro)
    Dim iCodigo, iNombreAl, iApellidoPat, iApellidoMat, iCodRecaudacion As Integer
    Dim iSiglas, iNumero, iLetra As Integer
    Dim iObligacion, iServicio, iMonto, iDescuento As Integer

    pars.AddRange(New CParametro() {New CParametro("@Anio", wAnio.Anio), _
                                      New CParametro("@Motivo", wMotivo), _
                                      New CParametro("@PagoProgramado", wPagoProgramado)})
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liAlumnosBeneficiados", pars)
      iCodigo = dr.GetOrdinal("CodigoAlumno")
      iNombreAl = dr.GetOrdinal("Nombre")
      iApellidoPat = dr.GetOrdinal("ApellidoPat")
      iApellidoMat = dr.GetOrdinal("ApellidoMat")
      iCodRecaudacion = dr.GetOrdinal("CodigoRecaudacion")
      iSiglas = dr.GetOrdinal("Siglas")
      iNumero = dr.GetOrdinal("Numero")
      iLetra = dr.GetOrdinal("Letra")
      iObligacion = dr.GetOrdinal("CodigoObligacion")
      iServicio = dr.GetOrdinal("CodigoServicio")
      iMonto = dr.GetOrdinal("Monto")
      iDescuento = dr.GetOrdinal("Descuento")
      lista = New List(Of AlumnoBeneficiado)
      While dr.Read
        lista.Add(New AlumnoBeneficiado)
        With lista.Item(lista.Count - 1)
          .Matricula = New Matricula
          With .Matricula
            .Seccion = New Seccion
            With .Seccion
              .Grado = New Grado With {.Numero = dr.GetByte(iNumero)}
              .Grado.Nivel = New Nivel With {.Siglas = dr.GetString(iSiglas)}
              .Letra = dr.GetString(iLetra)
            End With
            .Alumno = New Alumno With {.Codigo = dr.GetInt32(icodigo), .Nombre = dr.GetString(iNombreAl), .ApellidoPaterno = dr.GetString(iApellidoPat), _
                                       .ApellidoMaterno = dr.GetString(iApellidoMat), .CodigoRecaudacion = dr.GetString(iCodRecaudacion)}
          End With
          .Beneficio = New Beneficio
          With .Beneficio
            .Obligacion = New Obligacion With {.Codigo = dr.GetInt32(iObligacion), .Monto = dr.GetDecimal(iMonto)}
            .Obligacion.Servicio = New Servicio With {.Codigo = dr.GetInt16(iServicio)}
            .Descuento = dr.GetDecimal(iDescuento)
          End With
          .MontoPagar = .Monto - .Descuento
          .Seleccionado = False
        End With
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
      dr = Nothing
    End Try

    Return lista
  End Function

  Public Function ListarAlumnosBeneficiadosAnio(ByVal wAnio As AnioLectivo) As DataTable
    Dim pars As New List(Of CParametro)
    Dim dt As DataTable = Nothing

    pars.Add(New CParametro("@Anio", wAnio.Anio))
    Try
      Me.Conectar(False)
      dt = Me.PedirDatatable("pr_liAlumnosBeneficiadosAnio", pars)
    Catch ex As Exception
      Throw ex
    Finally
      Me.Cerrar(True)
      pars = Nothing
    End Try

    Return dt
  End Function

  Public Function ListarAlumnosBeneficiadosAnioFecha(ByVal wAnio As AnioLectivo, ByVal wFechaIni As DateTime, ByVal wFechaFin As DateTime) As DataTable
    Dim pars As New List(Of CParametro)
    Dim dt As DataTable = Nothing

    pars.Add(New CParametro("@Anio", wAnio.Anio))
    pars.Add(New CParametro("@FechaIni", wFechaIni))
    pars.Add(New CParametro("@FechaFin", wFechaFin))
    Try
      Me.Conectar(False)
      dt = Me.PedirDatatable("pr_liAlumnosBeneficiadosAnioFecha", pars)
    Catch ex As Exception
      Throw ex
    Finally
      Me.Cerrar(True)
      pars = Nothing
    End Try

    Return dt
  End Function

End Class
