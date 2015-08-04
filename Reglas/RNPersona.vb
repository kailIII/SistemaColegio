
Public Class RNPersona
  Inherits CADO

  Public Sub Registrar(ByVal wPersona As Persona)
    Dim cn As New SqlConnection(My.Settings.Conexion)
    Dim cmd As New SqlCommand("pr_iPersona", cn)

    cmd.CommandType = CommandType.StoredProcedure
    With cmd.Parameters
      .AddWithValue("@Nombre", wPersona.Nombre)
      .AddWithValue("@ApellidoPat", wPersona.ApellidoPaterno)
      .AddWithValue("@ApellidoMat", wPersona.ApellidoMaterno)
      .AddWithValue("@Sexo", wPersona.Sexo)
      .AddWithValue("@FechaNac", wPersona.FechaNacimiento)
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

  Public Function RetornaCodPersona() As Integer
    Dim cnR As New SqlConnection(My.Settings.Conexion)
    Dim cmdR As New SqlCommand("pr_RetornaCodPersona", cnR)

    cmdR.CommandType = CommandType.StoredProcedure
    Try
      cnR.Open()
      Return CInt(cmdR.ExecuteScalar())
    Catch ex As Exception
      Throw ex
    Finally
      cmdR.Dispose()
      cmdR = Nothing
      If cnR.State = ConnectionState.Open Then
        cnR.Close()
      End If
      cnR.Dispose()
      cnR = Nothing
    End Try
  End Function

  Public Function Listar(ByVal wNombre As String) As List(Of Persona)
    Dim la As List(Of Persona)
    Dim p As Persona
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim iNombre As Integer, iApPat As Integer, iApMat As Integer, iCodigo As Integer, iRecaudacion As Integer

    pars.AddRange(New CParametro() {New CParametro("@Nombre", wNombre)})
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liPersonas", pars)

      iNombre = dr.GetOrdinal("Nombre")
      iApPat = dr.GetOrdinal("ApellidoPat")
      iApMat = dr.GetOrdinal("ApellidoMat")
      iCodigo = dr.GetOrdinal("codigoPersona")
      iRecaudacion = dr.GetOrdinal("codigoRecaudacion")

      la = New List(Of Persona)
      While dr.Read
        If dr.IsDBNull(iRecaudacion) = False Then
          p = New Alumno() With {.CodigoRecaudacion = dr.GetString(iRecaudacion)}
        Else
          p = New Persona()
        End If
        p.Codigo = dr.GetInt32(iCodigo)
        p.Nombre = dr.GetString(iNombre)
        p.ApellidoPaterno = dr.GetString(iApPat)
        p.ApellidoMaterno = dr.GetString(iApMat)

        la.Add(p)
      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try

    Return la
  End Function

  Public Function EstadoCuenta(ByVal wPersona As Persona) As List(Of DetalleEstadoCuenta)
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim Detalles As List(Of DetalleEstadoCuenta) = Nothing
    Dim MontoPagar As Double
    Dim MontoPagado As Double
    Dim ob As Obligacion = Nothing
    Dim ObligAct As Integer = 0
    Dim iAnio As Integer, iObligacion As Integer, iDescripcion As Integer, iVencimiento As Integer
    Dim iMontoPagar As Integer, iEntidad As Integer, iDocumento As Integer, iSerie As Integer, iNumero As Integer, iFechaPago As Integer
    Dim iMontoPagado As Integer, iObligacionPadre As Integer, iVigencia As Integer
    Dim iCodigoDocumento, iNumeroDetalle As Integer

    pars.Add(New CParametro("@Persona", wPersona.Codigo))

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liEstadoCuenta", pars)

      iAnio = dr.GetOrdinal("Anio")
      iObligacion = dr.GetOrdinal("Obligacion")
      iDescripcion = dr.GetOrdinal("Descripcion")
      iVencimiento = dr.GetOrdinal("Vencimiento")
      iMontoPagar = dr.GetOrdinal("MontoPagar")
      iEntidad = dr.GetOrdinal("Entidad")
      iDocumento = dr.GetOrdinal("Documento")
      iSerie = dr.GetOrdinal("Serie")
      iNumero = dr.GetOrdinal("Numero")
      iFechaPago = dr.GetOrdinal("FechaPago")
      iMontoPagado = dr.GetOrdinal("MontoPagado")
      iObligacionPadre = dr.GetOrdinal("ObligacionPadre")
      iVigencia = dr.GetOrdinal("Vigencia")
      iCodigoDocumento = dr.GetOrdinal("CodigoDocumento")
      iNumeroDetalle = dr.GetOrdinal("NumeroDetalle")

      Detalles = New List(Of DetalleEstadoCuenta)
      While (dr.Read)
        MontoPagar = 0
        MontoPagado = 0
        ob = Nothing

        Detalles.Add(New DetalleEstadoCuenta)

        With Detalles.Item(Detalles.Count - 1)
          If dr.IsDBNull(iAnio) = False Then
            If dr.IsDBNull(iObligacion) = True OrElse ObligAct <> dr.GetInt32(iObligacion) Then
              .Obligacion = New Obligacion
              With .Obligacion
                If dr.IsDBNull(iObligacion) = False Then
                  .Codigo = dr.GetInt32(iObligacion)
                End If
                .Servicio = New Servicio With {.entidad = dr.GetString(iEntidad)}
                .Descripcion = dr.GetString(iDescripcion)
                .FechaVencimiento = dr.GetDateTime(iVencimiento)
                .Monto = dr.GetDecimal(iMontoPagar)
                .Vigencia = dr.GetBoolean(iVigencia)
                MontoPagar = .Monto
                .Matricula = New Matricula With {.Anio = New AnioLectivo(dr.GetInt16(iAnio).ToString)}
                If dr.IsDBNull(iObligacionPadre) = False Then
                  .ObligacionPadre = New Obligacion() With {.Codigo = dr.GetInt32(iObligacionPadre)}
                End If
                ObligAct = .Codigo
              End With
              ob = .Obligacion
            Else
              MontoPagar = Detalles.Item(Detalles.Count - 2).Saldo
              ob = Detalles.Item(Detalles.Count - 2).Obligacion
            End If
          End If

          If dr.IsDBNull(iMontoPagado) = False Then
            .DetallePago = New DetalleDocumentoIngreso
            With .DetallePago
              .Documento = New DocumentoIngreso
              With .Documento
                .Codigo = dr.GetInt32(iCodigoDocumento)
                .Entidad = dr.GetString(iEntidad)
                .TipoDocumento = dr.GetString(iDocumento)
                .Serie = dr.GetByte(iSerie)
                .Numero = dr.GetInt32(iNumero)
                .Fecha = dr.GetDateTime(iFechaPago)
                .Vigencia = True
              End With
              .Numero = dr.GetByte(iNumeroDetalle)
              .Obligacion = ob
              .Descripcion = dr.GetString(iDescripcion)
              .Monto = dr.GetDecimal(iMontoPagado)
              MontoPagado = .Monto
            End With
          End If
          If MontoPagar > 0 Then
            .Saldo = MontoPagar - MontoPagado
          Else
            .Saldo = 0
          End If
        End With

      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      dr = Nothing
      pars = Nothing
    End Try

    Return Detalles
  End Function

  Public Function ListarObligacionesPendientes(ByVal wPersona As Persona, ByVal wEntidad As String) As List(Of VistaDetalleDocumentoIngreso)
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim Detalles As List(Of VistaDetalleDocumentoIngreso) = Nothing
    Dim iMatricula, iServicio, iObligacion, iDescripcion, iVencimiento, iMotivo, iDescuento, iMontoPagar, iObligacionPadre As Integer

    pars.AddRange(New CParametro() {New CParametro("@Persona", wPersona.Codigo), _
                                    New CParametro("@Entidad", wEntidad)})

    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_liObligacionesPendientes", pars)

      iMatricula = dr.GetOrdinal("nroMatricula")
      iServicio = dr.GetOrdinal("Servicio")
      iObligacion = dr.GetOrdinal("Obligacion")
      iDescripcion = dr.GetOrdinal("Descripcion")
      iVencimiento = dr.GetOrdinal("Vencimiento")
      iMontoPagar = dr.GetOrdinal("MontoPagar")
      iMotivo = dr.GetOrdinal("Motivo")
      iDescuento = dr.GetOrdinal("Descuento")
      iObligacionPadre = dr.GetOrdinal("ObligacionPadre")

      Detalles = New List(Of VistaDetalleDocumentoIngreso)
      While (dr.Read)
        Detalles.Add(New VistaDetalleDocumentoIngreso)

        With Detalles.Item(Detalles.Count - 1)
          .Servicio = New Servicio With {.Codigo = dr.GetInt16(iServicio)}
          .Obligacion = New Obligacion
          .Obligacion.Servicio = .Servicio
          With .Obligacion
            If dr.IsDBNull(iObligacion) = False Then
              .Codigo = dr.GetInt32(iObligacion)
            End If
            .Descripcion = dr.GetString(iDescripcion)
            .FechaVencimiento = dr.GetDateTime(iVencimiento)
            .Monto = dr.GetDecimal(iMontoPagar)
            If dr.IsDBNull(iObligacionPadre) = False Then
              .ObligacionPadre = New Obligacion() With {.Codigo = dr.GetInt32(iObligacionPadre)}
            End If
            .Matricula = New Matricula(dr.GetInt16(iMatricula))
          End With
          .Beneficio = New Beneficio
          If dr.IsDBNull(iMotivo) = False Then
            With .Beneficio
              .Descuento = dr.GetDecimal(iDescuento)
              .Motivo = dr.GetString(iMotivo)
            End With
          End If
          .Descripcion = .Obligacion.Descripcion
          .Monto = .Obligacion.Monto
          .MontoOriginal = .Monto
        End With

      End While

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      dr = Nothing
      pars = Nothing
    End Try

    Return Detalles
  End Function

  Public Function Leer(ByVal wPersona As Persona) As Persona
    Dim p As Persona = Nothing
    Dim pars As New List(Of CParametro)
    Dim dr As SqlDataReader
    Dim iNombre As Integer, iApPat As Integer, iApMat As Integer

    pars.AddRange(New CParametro() {New CParametro("@Codigo", wPersona.Codigo)})
    Try
      Me.Conectar(False)
      dr = Me.PedirDataReader("pr_lPersona", pars)

      iNombre = dr.GetOrdinal("Nombre")
      iApPat = dr.GetOrdinal("ApellidoPat")
      iApMat = dr.GetOrdinal("ApellidoMat")

      If dr.Read = True Then
        
        p = New Persona()
        p.Codigo = wPersona.Codigo
        p.Nombre = dr.GetString(iNombre)
        p.ApellidoPaterno = dr.GetString(iApPat)
        p.ApellidoMaterno = dr.GetString(iApMat)
      End If

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try

    Return p
  End Function

  Public Sub Actualizar(ByVal wPersona As Persona)
    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@Codigo", wPersona.Codigo), _
                                    New CParametro("@Nombre", wPersona.Nombre), _
                                    New CParametro("@ApellidoPat", wPersona.ApellidoPaterno), _
                                    New CParametro("@ApellidoMat", wPersona.ApellidoMaterno)})
    Try
      Me.Conectar(False)
      Me.EjecutarOrden("pr_aPersona", pars)

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try
  End Sub

  Public Sub EliminarDuplicado(ByVal wPersonaCorrecta As Persona, ByVal wPersonaDuplicada As Persona)
    Dim pars As New List(Of CParametro)

    pars.AddRange(New CParametro() {New CParametro("@CodigoCorrecto", wPersonaCorrecta.Codigo), _
                                    New CParametro("@CodigoDuplicado", wPersonaDuplicada.Codigo)})
    Try
      Me.Conectar(False)
      Me.EjecutarOrden("pr_ePersonaDuplicada", pars)

      Me.Cerrar(True)
    Catch ex As Exception
      Me.Cerrar(False)
      Throw ex
    Finally
      pars = Nothing
    End Try
  End Sub

End Class
