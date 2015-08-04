Module modImprimirDocumento

  Private Const CANTIDAD_DETALLES As Integer = 6

  Public Function VerVistaPrevia(ByVal wDocumento As DocumentoIngreso, ByVal wMatricula As Matricula, ByVal wDetalles As List(Of VistaDetalleDocumentoIngreso)) As Boolean
    If ConfigurarReporte(wDocumento, wMatricula, wDetalles) = True Then
      frmVisor.crvVisor.ReportSource = crpDocumento
      frmVisor.ShowDialog()

      Return frmVisor.Aceptado
    Else
      Return False
    End If
  End Function

  Public Function ConfigurarReporte(ByVal wDocumento As DocumentoIngreso, ByVal wMatricula As Matricula, ByVal wDetalles As List(Of VistaDetalleDocumentoIngreso)) As Boolean
    Dim dtDet As New DataTable
    Dim dr As DataRow
    Dim i As Integer = 1

    With dtDet.Columns
      .Add("Numero", GetType(Integer))
      .Add("Descripcion", GetType(String))
      .Add("Monto", GetType(Double))
      .Add("Motivo", GetType(String))
    End With
    For Each det In wDetalles
      If det.Seleccionado = True Then
        dr = dtDet.NewRow
        dr.Item("numero") = i
        dr.Item("Descripcion") = det.Descripcion
        dr.Item("Monto") = det.MontoInicial
        dtDet.Rows.Add(dr)
        i += 1
        If det.Beneficio IsNot Nothing AndAlso det.Beneficio.Descuento > 0 Then
          dr = dtDet.NewRow
          dr.Item("Numero") = i
          dr.Item("Descripcion") = "Descuento por beneficio"
          dr.Item("Monto") = -det.Beneficio.Descuento
          dtDet.Rows.Add(dr)
          i += 1
        End If
      End If
    Next

    If dtDet.Rows.Count <= CANTIDAD_DETALLES Then
      crpDocumento.SetDataSource(dtDet)
      With crpDocumento.Section1.ReportObjects
        DirectCast(.Item("txtNumero"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = wDocumento.TipoDocumento & " " & wDocumento.Serie.ToString("000") & "-" & wDocumento.Numero.ToString("0000000")
        DirectCast(.Item("txtNumero2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = DirectCast(.Item("txtNumero"), CrystalDecisions.CrystalReports.Engine.TextObject).Text
        DirectCast(.Item("txtFecha"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = wDocumento.Fecha.ToString("dd-MM-yyyy HH:mm")
        DirectCast(.Item("txtFecha2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = DirectCast(.Item("txtFecha"), CrystalDecisions.CrystalReports.Engine.TextObject).Text

        DirectCast(.Item("txtPersona"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = wDocumento.Persona.ApellidoPaterno & " " & wDocumento.Persona.ApellidoMaterno & ", " & wDocumento.Persona.Nombre
        DirectCast(.Item("txtPersona2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = DirectCast(.Item("txtPersona"), CrystalDecisions.CrystalReports.Engine.TextObject).Text
        If TypeOf wDocumento.Persona Is Alumno Then
          DirectCast(.Item("txtCodigo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = DirectCast(wDocumento.Persona, Alumno).CodigoRecaudacion.ToString
        Else
          DirectCast(.Item("txtCodigo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "VARIOS"
        End If
        DirectCast(.Item("txtCodigo2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = DirectCast(.Item("txtCodigo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text
        If wMatricula IsNot Nothing Then
          DirectCast(.Item("txtSeccion"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = wMatricula.Seccion.Grado.Nivel.Siglas & "-" & wMatricula.Seccion.Grado.Numero & "-" & wMatricula.Seccion.Letra
          DirectCast(.Item("txtGrado"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = wMatricula.Seccion.Grado.Numero.ToString("00")
        Else
          DirectCast(.Item("txtSeccion"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ""
          DirectCast(.Item("txtGrado"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ""
        End If
        DirectCast(.Item("txtSeccion2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = DirectCast(.Item("txtSeccion"), CrystalDecisions.CrystalReports.Engine.TextObject).Text
        DirectCast(.Item("txtGrado2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = DirectCast(.Item("txtGrado"), CrystalDecisions.CrystalReports.Engine.TextObject).Text
      End With
      With crpDocumento.Section5.ReportObjects
        DirectCast(.Item("txtUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = mOUsuario.NombrePersona
        DirectCast(.Item("txtUsuario2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = DirectCast(.Item("txtUsuario"), CrystalDecisions.CrystalReports.Engine.TextObject).Text
        DirectCast(.Item("txtLetras"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ConvertirLetras(wDocumento.Total)
        DirectCast(.Item("txtLetras2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = DirectCast(.Item("txtLetras"), CrystalDecisions.CrystalReports.Engine.TextObject).Text
        DirectCast(.Item("txtTotal"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = wDocumento.Total.ToString("0.00")
        DirectCast(.Item("txtTotal2"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = DirectCast(.Item("txtTotal"), CrystalDecisions.CrystalReports.Engine.TextObject).Text
      End With

      Return True
    Else
      MessageBox.Show("El documento no puede tener mas de 06 detalles", "Impresión", MessageBoxButtons.OK, MessageBoxIcon.Information)

      Return False
    End If
  End Function

End Module
