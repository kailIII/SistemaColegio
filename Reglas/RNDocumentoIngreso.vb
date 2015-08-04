Public Class RNDocumentoIngreso
  Inherits CADO

  Public Sub Registrar(ByVal wDoc As DocumentoIngreso)
    Dim parsPer As List(Of CParametro) = Nothing
    Dim parsDoc As New List(Of CParametro)
    Dim parsVou As New List(Of CParametro)
    Dim parsDet As New List(Of CParametro)
    Dim codDoc As Integer
    Dim i As Integer = 0
    Dim Matriculado As Boolean = False
    Dim MovHis As Object
    Dim NumOper As Object

    If wDoc.Persona.Codigo = -1 Then
      parsPer = New List(Of CParametro)
      With wDoc.Persona
        parsPer.AddRange(New CParametro() {New CParametro("@Codigo", 0, CParametro.DireccionParametro.SALIDA), _
                      New CParametro("@Nombre", .Nombre), New CParametro("@ApellidoPat", .ApellidoPaterno), _
                      New CParametro("@ApellidoMat", .ApellidoMaterno), New CParametro("@FechaNac", .FechaNacimiento), _
                      New CParametro("@Sexo", .Sexo)})
      End With
    End If
    parsDoc.AddRange(New CParametro() {New CParametro("@Codigo", 0, CParametro.DireccionParametro.SALIDA), _
                  New CParametro("@entidad", wDoc.Entidad), New CParametro("@Fecha", wDoc.Fecha), _
                  New CParametro("@serie", wDoc.Serie), New CParametro("@Numero", wDoc.Numero), New CParametro("@TipoDoc", wDoc.TipoDocumento), _
                  New CParametro("@Liquidacion", DBNull.Value), New CParametro("@Persona", wDoc.Persona.Codigo), _
                  New CParametro("@Administrativo", wDoc.Administrativo.Codigo), New CParametro("@Voucher", DBNull.Value), _
                  New CParametro("@FormaPago", wDoc.FormaPago)})
    If wDoc.Voucher IsNot Nothing Then
      With wDoc.Voucher
        If .MovimientoHistorico IsNot Nothing Then
          MovHis = .MovimientoHistorico.Codigo
        Else
          MovHis = DBNull.Value
        End If
        If .NumOperacion IsNot Nothing Then
          NumOper = .NumOperacion
        Else
          NumOper = DBNull.Value
        End If
        parsVou.AddRange(New CParametro() {New CParametro("@Voucher", 0, CParametro.DireccionParametro.SALIDA), _
                    New CParametro("@Monto", .Monto), New CParametro("@Fecha", .Fecha), _
                    New CParametro("@MovHistorico", MovHis), New CParametro("@Operacion", NumOper), _
                    New CParametro("@numeroCuenta", .CuentaBancaria.Numero), New CParametro("@Administrativo", wDoc.Administrativo.Codigo)})
      End With
    End If
    parsDet.AddRange(New CParametro() {New CParametro("@Numero", 0), New CParametro("@Monto", 0), New CParametro("@Descripcion", 0), _
                  New CParametro("@Servicio", 0), New CParametro("@Obligacion", DBNull.Value), New CParametro("@DocumentoIngreso", 0)})

    Try
      Me.Conectar(True)
      If wDoc.Persona.Codigo = -1 Then
        Me.EjecutarOrden("pr_iPersona", parsPer)
        parsDoc.Item(7).Valor = parsPer.Item(0).Valor
      End If

      If wDoc.Voucher IsNot Nothing Then
        Me.EjecutarOrden("pr_iVoucherPago", parsVou)
        parsDoc.Item(9).Valor = parsVou.Item(0).Valor
      End If
      Me.EjecutarOrden("pr_iDocumentoIngreso", parsDoc)
      codDoc = CInt(parsDoc.Item(0).Valor)
      For Each det As DetalleDocumentoIngreso In wDoc.Detalles
        i += 1
        parsDet.Item(0).Valor = i
        parsDet.Item(1).Valor = det.Monto
        parsDet.Item(2).Valor = det.Descripcion
        If det.Servicio IsNot Nothing Then
          parsDet.Item(3).Valor = det.Servicio.Codigo
        Else
          i = i
        End If
        If det.Obligacion IsNot Nothing Then
          If det.Obligacion.Codigo > -1 Then
            parsDet.Item(4).Valor = det.Obligacion.Codigo
          ElseIf det.Obligacion.Codigo = -1 Then
            If det.Servicio IsNot Nothing Then
              parsDet.Item(4).Valor = RegistrarObligacion(det.Obligacion).Codigo
            Else
              parsDet.Item(4).Valor = RegistrarMoraProgramacion(det.Obligacion).Codigo
            End If
          ElseIf det.Obligacion.Codigo = -2 Then
            If Matriculado = False Then
              Me.RegistrarMatricula(New MatriculaPosible() With { _
                                                              .Alumno = det.Obligacion.Matricula.Alumno, _
                                                              .Seccion = New Seccion() With {.Anio = det.Obligacion.Matricula.Anio} _
                                                              }, wDoc.Administrativo)
              Matriculado = True
            End If
            det.Obligacion.Codigo = ObtenerObligacion(New Alumno(wDoc.Persona.Codigo), det.Obligacion.Matricula.Anio, det.Descripcion).Codigo
            parsDet.Item(4).Valor = det.Obligacion.Codigo
          End If
        Else
          parsDet.Item(4).Valor = DBNull.Value
        End If
          parsDet.Item(5).Valor = codDoc

          Me.EjecutarOrden("pr_iDetalleDocumentoIngreso", parsDet)
      Next

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      parsDoc = Nothing
      parsVou = Nothing
      parsDet = Nothing
    End Try
  End Sub

  Public Sub Modificar(ByVal wDocumento As DocumentoIngreso)
    Dim pars As New List(Of CParametro)
    Dim iCuenta As String = ""
    Dim Operacion As String = ""
    Dim fechaV As Date = DateTime.Now
    Dim monto As Double = 0

    If wDocumento.FormaPago <> "E" Then
      iCuenta = wDocumento.Voucher.CuentaBancaria.Numero
      Operacion = wDocumento.Voucher.NumOperacion
      fechaV = wDocumento.Voucher.Fecha
      monto = wDocumento.Voucher.Monto
    End If
    pars.AddRange(New CParametro() {New CParametro("@Codigo", wDocumento.Codigo), _
                                    New CParametro("@Persona", wDocumento.Persona.Codigo), _
                                    New CParametro("@TipoDoc", wDocumento.TipoDocumento), _
                                    New CParametro("@Serie", wDocumento.Serie), _
                                    New CParametro("@Numero", wDocumento.Numero), _
                                    New CParametro("@Fecha", wDocumento.Fecha), _
                                    New CParametro("@FormaPago", wDocumento.FormaPago), _
                                    New CParametro("@CuentaBancaria", iCuenta), _
                                    New CParametro("@NumOperacion", Operacion), _
                                    New CParametro("@FechaVoucher", fechaV), _
                                    New CParametro("@Monto", monto), _
                                    New CParametro("@Administrativo", wDocumento.Administrativo.Codigo)})
    If wDocumento.FormaPago <> "E" Then

    End If
    Try
      Me.Conectar(False)
      Me.EjecutarOrden("pr_aDocumentoIngreso", pars)

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      pars = Nothing
    End Try
  End Sub

  Private Function ObtenerObligacion(ByVal wAlumno As Alumno, ByVal wAnio As AnioLectivo, ByVal wDescripcion As String) As Obligacion
    Dim dr As SqlDataReader
    Dim o As Obligacion = Nothing
    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@Alumno", wAlumno.Codigo), _
                                    New CParametro("@Anio", wAnio.Anio), _
                                    New CParametro("@Descripcion", wDescripcion)})
    Try
      dr = Me.PedirDataReader("pr_lObligacion_Alumno", pars)
      If dr.Read = True Then
        o = New Obligacion
        o.Codigo = CInt(dr.Item("CodigoObligacion"))
        o.Descripcion = dr.Item("Descripcion").ToString
        o.Servicio = New Servicio(CInt(dr.Item("codigoServicio")))
        o.FechaVencimiento = CDate(dr.Item("fechaVcto"))
        o.Monto = CDbl(dr.Item("Monto"))
        o.Matricula = New Matricula(CInt(dr.Item("nroMatricula")))
        o.Matricula.Alumno = wAlumno
        o.Matricula.Anio = wAnio
        o.Vigencia = CBool(dr.Item("Vigencia"))
        dr.Close()
      Else
        dr.Close()
        Throw New Exception("No se encontró información de la obligación")
      End If

    Catch ex As Exception
      o = Nothing
      Throw ex
    Finally
      pars = Nothing
    End Try

    Return o
  End Function

  Private Sub RegistrarMatricula(ByVal wPosible As MatriculaPosible, ByVal wAdministrativo As Administrativo)
    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@Alumno", wPosible.Alumno.Codigo), _
                                    New CParametro("@Anio", wPosible.Seccion.Anio.Anio), _
                                    New CParametro("@Administrativo", wAdministrativo.Codigo)})

    Try
      Me.EjecutarOrden("pr_iMatricula_Posible", pars)
    Catch ex As Exception
      Throw ex
    Finally
      pars = Nothing
    End Try

  End Sub

  Private Function RegistrarMoraProgramacion(ByRef wOblig As Obligacion) As Obligacion
    Dim parsOb As New List(Of CParametro)

    parsOb.AddRange(New CParametro() {New CParametro("@Obligacion", 0, CParametro.DireccionParametro.SALIDA), _
                      New CParametro("@Descripcion", wOblig.Descripcion), New CParametro("@Monto", wOblig.Monto), _
                      New CParametro("@fechaVcto", wOblig.FechaVencimiento), New CParametro("@Alumno", wOblig.Matricula.Alumno.Codigo), _
                      New CParametro("@Anio", wOblig.Matricula.Anio.Anio), New CParametro("@obligacionPadre", wOblig.ObligacionPadre.Codigo)})

    Try
      Me.EjecutarOrden("pr_iMoraProgramacion", parsOb)
      wOblig.Codigo = CInt(parsOb.Item(0).Valor)
    Catch ex As Exception
      Throw ex
    Finally
      parsOb = Nothing
    End Try

    Return wOblig
  End Function

  Private Function RegistrarObligacion(ByRef wOblig As Obligacion) As Obligacion
    Dim parsOb As New List(Of CParametro)

    parsOb.AddRange(New CParametro() {New CParametro("@Obligacion", 0, CParametro.DireccionParametro.SALIDA), _
                      New CParametro("@Descripcion", wOblig.Descripcion), New CParametro("@Monto", wOblig.Monto), _
                      New CParametro("@fechaVcto", wOblig.FechaVencimiento), New CParametro("@nroMatricula", wOblig.Matricula.Numero), _
                      New CParametro("@codigoServicio", wOblig.Servicio.Codigo), _
                      New CParametro("@obligacionPadre", wOblig.ObligacionPadre.Codigo)})

    Try
      Me.EjecutarOrden("pr_iObligacion", parsOb)
      wOblig.Codigo = CInt(parsOb.Item(0).Valor)
    Catch ex As Exception
      Throw ex
    Finally
      parsOb = Nothing
    End Try

    Return wOblig
  End Function

  Public Function ObtenerNumeracion(ByVal wEntidad As String, ByVal wTipoDoc As String, ByVal wSerie As Integer) As DocumentoIngreso
    Dim doc As DocumentoIngreso = Nothing
    Dim dr As SqlDataReader = Nothing
    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@entidad", wEntidad), _
                                    New CParametro("@tipoDoc", wTipoDoc), _
                                    New CParametro("@Serie", wSerie)})
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_lIdentificadorDocumento", pars)
      If dr.Read Then
        doc = New DocumentoIngreso(0, wEntidad, dr.GetInt32(dr.GetOrdinal("numero")) + 1, wSerie, wTipoDoc, True, Nothing, Nothing, Nothing, Nothing, Nothing)
      Else
        doc = New DocumentoIngreso(0, wEntidad, 1, 1, wTipoDoc, True, Nothing, Nothing, Nothing, Nothing, Nothing)
      End If
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try

    Return doc
  End Function

  Public Function Listar_PeriodoPersona(ByVal wFechaIni As DateTime, ByVal wFechaFin As DateTime, ByVal wEntidad As String, ByVal wPersona As Persona) As List(Of DocumentoIngreso)
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader = Nothing
    Dim Documentos As List(Of DocumentoIngreso) = Nothing
    Dim cod As Object = DBNull.Value
    Dim iCodigo, iEntidad, iTipoDoc, iSerie, iNumero, iFecha, iVigencia As Integer
    Dim iCodPers, iNombres, iApPat, iApMat, iCodRecaudacion, iTotal As Integer

    If wPersona IsNot Nothing Then
      cod = wPersona.Codigo
    End If

    pars.AddRange(New CParametro() {New CParametro("@FechaIni", wFechaIni), _
                                    New CParametro("@FechaFin", wFechaFin), _
                                    New CParametro("@Entidad", IIf(wEntidad.Length > 0, wEntidad, DBNull.Value)), _
                                    New CParametro("@Persona", cod)})

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liDocumentos_PeriodoPersona", pars)
      iCodigo = dr.GetOrdinal("codigoDocumentoIngreso")
      iEntidad = dr.GetOrdinal("Entidad")
      iTipoDoc = dr.GetOrdinal("TipoDoc")
      iSerie = dr.GetOrdinal("serie")
      iNumero = dr.GetOrdinal("numero")
      iFecha = dr.GetOrdinal("fecha")
      iTotal = dr.GetOrdinal("Total")
      iCodPers = dr.GetOrdinal("codigoPersona")
      iApPat = dr.GetOrdinal("apellidoPat")
      iApMat = dr.GetOrdinal("apellidoMat")
      iNombres = dr.GetOrdinal("nombre")
      iCodRecaudacion = dr.GetOrdinal("CodigoRecaudacion")
      iVigencia = dr.GetOrdinal("vigencia")
      Documentos = New List(Of DocumentoIngreso)
      Do While (dr.Read)
        Documentos.Add(New DocumentoIngreso)
        With Documentos.Item(Documentos.Count - 1)
          .Codigo = dr.GetInt32(iCodigo)
          .Entidad = dr.GetString(iEntidad)
          .TipoDocumento = dr.GetString(iTipoDoc)
          .Serie = dr.GetByte(iSerie)
          .Numero = dr.GetInt32(iNumero)
          .Fecha = dr.GetDateTime(iFecha)
          .Total = dr.GetDecimal(iTotal)
          .Vigencia = dr.GetBoolean(iVigencia)

          If dr.IsDBNull(iCodRecaudacion) = False Then
            .Persona = New Alumno With {.CodigoRecaudacion = dr.GetString(iCodRecaudacion)}
          Else
            .Persona = New Persona
          End If

          With .Persona
            .Codigo = dr.GetInt32(iCodPers)
            .Nombre = dr.GetString(iNombres)
            .ApellidoPaterno = dr.GetString(iApPat)
            .ApellidoMaterno = dr.GetString(iApMat)
          End With
        End With
      Loop
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try

    Return Documentos
  End Function

  Public Sub AnularRecibo(ByVal obj As DocumentoIngreso)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_aDocumento_Ingreso", cn)
    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@codigoDocumentoIngreso", obj.Codigo)
      .AddWithValue("@vigencia", obj.Vigencia)
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

  'Lista todos los documentos emitidos en el periodo especificado para el tipo de entidad que se solicita
  Public Function ListarPeriodo(ByVal wEntidad As String, ByVal wInicio As DateTime, ByVal wFin As DateTime) As List(Of DetalleDocumentoIngreso)
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim docs As List(Of DetalleDocumentoIngreso) = Nothing
    Dim iCodigo, iNombres, iApellidoPat, iApellidoMat As Integer
    Dim iTipoDoc, iSerie, iNumero, iFormaPago, iNumeroCuenta, iVigencia As Integer
    Dim iCuenta, iDescripcion, iMonto As Integer

    pars.AddRange(New CParametro() {New CParametro("@Entidad", wEntidad), _
                                    New CParametro("@Inicio", wInicio), _
                                    New CParametro("@Fin", wFin)})
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liDocumentosEntidadPeriodo", pars)
      iCodigo = dr.GetOrdinal("CodigoRecaudacion")
      iNombres = dr.GetOrdinal("Nombre")
      iApellidoPat = dr.GetOrdinal("ApellidoPat")
      iApellidoMat = dr.GetOrdinal("ApellidoMat")
      iTipoDoc = dr.GetOrdinal("TipoDoc")
      iSerie = dr.GetOrdinal("Serie")
      iNumero = dr.GetOrdinal("Numero")
      iFormaPago = dr.GetOrdinal("FormaPago")
      iNumeroCuenta = dr.GetOrdinal("numeroCuenta")
      iCuenta = dr.GetOrdinal("codigoCtaContable")
      iDescripcion = dr.GetOrdinal("Descripcion")
      iMonto = dr.GetOrdinal("Monto")
      iVigencia = dr.GetOrdinal("Vigencia")
      docs = New List(Of DetalleDocumentoIngreso)
      While dr.Read
        docs.Add(New DetalleDocumentoIngreso)
        With docs.Item(docs.Count - 1)
          .Documento = New DocumentoIngreso
          With .Documento
            If dr.IsDBNull(iCodigo) = True Then
              .Persona = New Persona
            Else
              .Persona = New Alumno With {.CodigoRecaudacion = dr.GetString(iCodigo)}
            End If
            With .Persona
              .Nombre = dr.GetString(iNombres)
              .ApellidoPaterno = dr.GetString(iApellidoPat)
              .ApellidoMaterno = dr.GetString(iApellidoMat)
            End With
            .TipoDocumento = dr.GetString(iTipoDoc)
            .Serie = dr.GetByte(iSerie)
            .Numero = dr.GetInt32(iNumero)
            .Total = dr.GetDecimal(iMonto)
            .FormaPago = dr.GetString(iFormaPago)
            If dr.IsDBNull(iNumeroCuenta) = False Then
              .Voucher = New VoucherPago
              .Voucher.CuentaBancaria = New CuentaBancaria With {.Numero = dr.GetString(iNumeroCuenta)}
            End If
            .Vigencia = dr.GetBoolean(iVigencia)
          End With
          .Servicio = New Servicio
          .Servicio.CuentaContable = New CuentaContable With {.Codigo = dr.GetString(iCuenta)}
          .Descripcion = dr.GetString(iDescripcion)
          .Monto = dr.GetDecimal(iMonto)
        End With

      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      dr = Nothing
    End Try

    Return docs
  End Function

  'Lista todos los documentos emitidos en el periodo especificado para el tipo de entidad que se solicita
  Public Function ResumenIngresosFormaPago(ByVal wEntidad As String, ByVal wInicio As DateTime, ByVal wFin As DateTime) As List(Of ResumenFormaPago)
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim docs As List(Of ResumenFormaPago) = Nothing
    Dim iFormaPago, iBanco, iTotal As Integer

    pars.AddRange(New CParametro() {New CParametro("@Entidad", wEntidad), _
                                    New CParametro("@Inicio", wInicio), _
                                    New CParametro("@Fin", wFin)})
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liResumenIngresosFormaPago", pars)
      iFormaPago = dr.GetOrdinal("FormaPago")
      iBanco = dr.GetOrdinal("Banco")
      iTotal = dr.GetOrdinal("Total")
      docs = New List(Of ResumenFormaPago)
      While dr.Read
        docs.Add(New ResumenFormaPago)
        With docs.Item(docs.Count - 1)
          .FormaPago = dr.GetString(iFormaPago)
          If dr.IsDBNull(iBanco) = False Then
            .EntidadFinanciera = New EntidadFinanciera With {.Nombre = dr.GetString(iBanco)}
          End If
          .Total = dr.GetDecimal(iTotal)
        End With

      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      dr = Nothing
    End Try

    Return docs
  End Function

  'Lista los detalles registrados para un documento de ingreso
  Public Function ListarDetalles(ByVal wDocumento As DocumentoIngreso) As List(Of DetalleDocumentoIngreso)
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim detalles As List(Of DetalleDocumentoIngreso) = Nothing
    Dim iNumero, iDescripcion, iMonto, iDescuento As Integer

    pars.Add(New CParametro("@Codigo", wDocumento.Codigo))
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liDetallesDocumento", pars)
      iNumero = dr.GetOrdinal("Numero")
      iDescripcion = dr.GetOrdinal("Descripcion")
      iMonto = dr.GetOrdinal("Monto")
      iDescuento = dr.GetOrdinal("Descuento")
      detalles = New List(Of DetalleDocumentoIngreso)

      While dr.Read
        detalles.Add(New DetalleDocumentoIngreso)
        With detalles.Item(detalles.Count - 1)
          .Numero = dr.GetInt16(iNumero)
          .Descripcion = dr.GetString(iDescripcion)
          .Monto = dr.GetDecimal(iMonto)
          If dr.IsDBNull(iDescuento) = False Then
            .Obligacion = New Obligacion With {.Monto = dr.GetDecimal(iDescuento)}
          End If
        End With
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      dr = Nothing
    End Try

    Return detalles
  End Function

  'Lista los documentos con los que se pago el servicio indicado en el periodo solicitado
  Public Function ListarPagosPorServicio(ByVal wServicio As Servicio, ByVal wFechaIni As Date, ByVal wFechaFin As Date) As DataTable
    Dim pars As New List(Of CParametro)
    Dim dt As DataTable

    pars.AddRange(New CParametro() {New CParametro("@Servicio", wServicio.Codigo), _
                                     New CParametro("@FechaIni", wFechaIni), _
                                     New CParametro("@FechaFin", wFechaFin)})
    Try
      Me.Conectar(False)

      dt = Me.PedirDatatable("pr_liDocumentosPorServicio", pars)
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    End Try

    Return dt
  End Function

  'Asocia un pago realizado con un servicio programado
  Public Sub AsociarPago(ByVal wDetalle As DetalleDocumentoIngreso, ByVal wObligacion As Obligacion)
    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@CodigoDocumento", wDetalle.Documento.Codigo), _
                                     New CParametro("@NumeroDetalle", wDetalle.Numero), _
                                     New CParametro("@Obligacion", wObligacion.Codigo)})
    Try
      Me.Conectar(False)

      Me.EjecutarOrden("pr_aAsociarPago", pars)
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    End Try

  End Sub

  'Presenta los datos de la forma de pago realizada en un documento de Ingreso
  Public Function LeerFormaPago(ByVal wDocumento As DocumentoIngreso) As DocumentoIngreso
    Dim doc As DocumentoIngreso = Nothing
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader

    pars.Add(New CParametro("@Codigo", wDocumento.Codigo))

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_lFormaPagoDocumento", pars)
      If dr.Read Then
        doc = New DocumentoIngreso
        doc.FormaPago = dr.Item("FormaPago").ToString
        If dr.Item("FormaPago").ToString <> "E" Then
          doc.Voucher = New VoucherPago
          With doc.Voucher
            .NumOperacion = dr.Item("NumOperacion").ToString
            .Fecha = CDate(dr.Item("Fecha"))
            .Monto = CDbl(dr.Item("Monto"))
            .CuentaBancaria = New CuentaBancaria With {.Numero = dr.Item("NumeroCuenta").ToString}
            .CuentaBancaria.EntidadFinanciera = New EntidadFinanciera With {.Codigo = CInt(dr.Item("CodigoEntidad"))}
          End With
        End If
      End If

        Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw
    Finally
      pars.Clear()
      pars = Nothing
    End Try

    Return doc
  End Function

  'Presenta los pagos realizados en la cuenta y fecha solicitada
  Public Function ListarPagosCuenta(ByVal wCuenta As CuentaBancaria, ByVal wFecha As Date) As DataTable
    Dim pars As New List(Of CParametro)
    Dim dt As DataTable = Nothing

    pars.AddRange(New CParametro() {New CParametro("@Cuenta", wCuenta.Numero), _
                                    New CParametro("@Fecha", wFecha)})
    Try
      Me.Conectar(False)
      dt = Me.PedirDatatable("pr_liPagosRealizadosCuenta", pars)
      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars.Clear()
      pars = Nothing
    End Try

    Return dt
  End Function

End Class
