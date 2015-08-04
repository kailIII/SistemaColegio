Imports System.IO

Public Class frmImportarData

  Private Const LIMITE As Integer = 4

  Private rnOb As RNObligacion
  Private rnPP As RNProgramacionPago
  Private rnAl As RNAlumno
  Private rnMat As RNMatricula

  Private SerieDocInstitucion As Integer
  Private NumeroDocInstitucion As Integer
  Private FechaDocInstitucion As DateTime
  Private DocumentosInstitucion As List(Of DocumentoIngreso)
  Private DocumentosImprimirInstitucion As List(Of DocumentoImprimir)

  Private SerieDocCOPAFA As Integer
  Private NumeroDocCOPAFA As Integer
  Private FechaDocCOPAFA As DateTime
  Private DocumentosCOPAFA As List(Of DocumentoIngreso)
  Private DocumentosImprimirCOPAFA As List(Of DocumentoImprimir)

  Private Vouchers As Hashtable

  Private MovimientoHistorico As MovimientoHistorico
  Private Ruta As String

  Private mDialogoAbrir As OpenFileDialog

  Private Shared frm As frmImportarData

  Private Sub New()
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
  End Sub

  Public Shared Function Crear() As frmImportarData
    If frmImportarData.frm Is Nothing Then
      frmImportarData.frm = New frmImportarData
    End If

    Return frmImportarData.frm
  End Function

  Private Sub frmImportarData_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    frmImportarData.frm = Nothing
  End Sub

  Private Sub frmImportarData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.CargarImagenes()
    Me.cboEntidadFinanciera.Select()
    Me.dtpFechaInstitucion.Value = DateAndTime.Now
    Me.cboTipoDocInstitucion.SelectedIndex = 0
    Me.txtSerieInstitucion.Text = "1"
    Me.txtSerieCOPAFA.Text = "1"
    Me.cboTipoDocCOPAFA.SelectedIndex = 0
    Me.ObtenerNumeracionInstitucion()
    Me.ObtenerNumeracionCOPAFA()
  End Sub

  Private Sub ObtenerNumeracionInstitucion()
    Dim rn As RNDocumentoIngreso
    Dim doc As DocumentoIngreso

    If Me.cboTipoDocInstitucion.SelectedIndex > -1 AndAlso String.IsNullOrEmpty(Me.txtSerieInstitucion.Text) = False Then
      rn = New RNDocumentoIngreso
      doc = rn.ObtenerNumeracion("I", Me.cboTipoDocInstitucion.Text.Substring(0, 1), CInt(Me.txtSerieInstitucion.Text))
      rn = Nothing
      Me.txtSerieInstitucion.Text = doc.Serie.ToString("000")
      Me.txtNumeroInstitucion.Text = doc.Numero.ToString("0000000")
      doc = Nothing
    End If
  End Sub

  Private Sub ObtenerNumeracionCOPAFA()
    Dim rn As RNDocumentoIngreso
    Dim doc As DocumentoIngreso

    If Me.cboTipoDocCOPAFA.SelectedIndex > -1 AndAlso String.IsNullOrEmpty(Me.txtSerieCOPAFA.Text) = False Then
      rn = New RNDocumentoIngreso
      doc = rn.ObtenerNumeracion("C", Me.cboTipoDocCOPAFA.Text.Substring(0, 1), CInt(Me.txtSerieCOPAFA.Text))
      rn = Nothing
      Me.txtSerieCOPAFA.Text = doc.Serie.ToString("000")
      Me.txtNumeroCOPAFA.Text = doc.Numero.ToString("0000000")
      doc = Nothing
    End If
  End Sub

  Private Sub CargarImagenes()
    Me.btnImportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnRegistrarInstitucion.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
  End Sub

  Public Sub CargarFormulario(ByVal wDialogoAbrir As OpenFileDialog)
    Me.mDialogoAbrir = wDialogoAbrir
    Me.CargarCboEntidadFinanciera()
    If Not Me.cboEntidadFinanciera.SelectedItem Is Nothing Then
      Me.cboEntidadFinanciera.SelectedIndex = 0
    End If
    Me.btnImportar.Select()
    Me.WindowState = FormWindowState.Maximized
    Me.Show()
  End Sub

  Public Sub CargarCboEntidadFinanciera()
    Dim ListA As New List(Of EntidadFinanciera)
    Dim objE As New RNEntidadFinanciera

    ListA = objE.Listar
    objE = Nothing
    If ListA.Count > 0 Then
      cboEntidadFinanciera.DisplayMember = "nombre"
      cboEntidadFinanciera.ValueMember = "codigoEntidad"
      cboEntidadFinanciera.DataSource = ListA
      cboEntidadFinanciera.SelectedIndex = ListA.Count - 1
      ListA = Nothing
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Public Function CargarRuta(ByVal wRuta As String) As String
    mDialogoAbrir.InitialDirectory = wRuta
    mDialogoAbrir.Filter = "Text Files (*.txt)|*.txt"
    mDialogoAbrir.FilterIndex = 2
    mDialogoAbrir.RestoreDirectory = True
    If mDialogoAbrir.ShowDialog() = Windows.Forms.DialogResult.OK Then
      Return mDialogoAbrir.FileName
    End If

    Return ""
  End Function

  Public Function ConvertirFechaHora(ByVal wfecha As String, ByVal whora As String) As DateTime
    Dim fecha As DateTime

    If whora = "" Then
      fecha = New DateTime(CInt(wfecha.Substring(0, 4)), CInt(wfecha.Substring(4, 2)), CInt(wfecha.Substring(6, 2)))
    Else
      fecha = New DateTime(CInt(wfecha.Substring(0, 4)), CInt(wfecha.Substring(4, 2)), CInt(wfecha.Substring(6, 2)), _
                           CInt(whora.Substring(0, 2)), CInt(whora.Substring(2, 2)), CInt(whora.Substring(4, 2)))
    End If

    Return fecha
  End Function

  Public Function ConvertirMoneda(ByVal wmonto As String) As Double
    Dim monto As Double
    Dim dec As Double

    dec = CDbl("0," & Mid(wmonto, 14, 2))
    monto = CDbl(Mid(wmonto, 1, 13))
    Return monto + dec
  End Function

  Public Function DevolverMovimientoHistorico(ByVal wlinea As String, ByVal wCtaBancaria As CuentaBancaria) As MovimientoHistorico
    Return New MovimientoHistorico(0, ConvertirMoneda(Mid(wlinea, 32, 15)), ConvertirFechaHora(wlinea.Substring(14, 8), ""), True, wCtaBancaria)
  End Function

  Public Sub ImportarDataBCP()
    Dim objleer As StreamReader = Nothing
    Dim linea As String = ""
    Dim NumPagos As Integer
    Dim monto As Double

    Ruta = CargarRuta("C:\BANCOS\BCP\IMPORTAR").ToString
    If Ruta = "" Then
      Exit Sub
    End If

    If Ruta IsNot Nothing Then
      Try
        objleer = New StreamReader(Ruta, True)
        linea = objleer.ReadLine

        Me.MovimientoHistorico = Nothing
        Me.MovimientoHistorico = New MovimientoHistorico
        Me.MovimientoHistorico.CuentaBancaria = New CuentaBancaria(linea.Substring(6, 7), DirectCast(cboEntidadFinanciera.SelectedItem, EntidadFinanciera))
        Me.MovimientoHistorico.fecha = ConvertirFechaHora(linea.Substring(14, 8), "")

        NumPagos = CInt(linea.Substring(22, 9))
        monto = CDbl(linea.Substring(31, 15)) / 100
        rnOb = New RNObligacion
        rnPP = New RNProgramacionPago
        rnAl = New RNAlumno
        For i As Integer = 1 To NumPagos
          Me.AgregarPagoBCP(objleer.ReadLine)
        Next

        Me.txtVouchers.Text = Me.DocumentosInstitucion.Count.ToString
        Me.txtTotal.Text = monto.ToString("0.00")
      Catch ex As Exception
        MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        If objleer IsNot Nothing Then
          objleer.Close()
        End If
        objleer = Nothing
        rnOb = Nothing
        rnAl = Nothing
      End Try
    End If
  End Sub

  Private Sub AgregarPagoBCP(ByVal wLinea As String)
    Dim fecha As DateTime
    Dim operacion As String
    Dim codigoAlumno As String
    Dim codigoObligacion As String
    Dim monto As Double, mora As Double

    With wLinea
      fecha = ConvertirFechaHora(.Substring(57, 8), .Substring(168, 8))
      operacion = .Substring(152, 4) & "-" & .Substring(124, 6)
      codigoAlumno = .Substring(13, 14)
      codigoObligacion = .Substring(27, 7)
      monto = CDbl(.Substring(73, 15)) / 100
      mora = CDbl(.Substring(88, 15)) / 100
      Me.GenerarDocumentoIngreso(codigoAlumno, fecha, operacion, codigoObligacion, monto, mora)
    End With
  End Sub

  Private Sub GenerarDocumentoIngreso(ByVal wCodigoAlumno As String, ByVal wFecha As DateTime, ByVal wOperacion As String, ByVal wObligacion As String, ByVal wMonto As Double, ByVal wMora As Double)
    Dim doc As DocumentoIngreso
    Dim det As DetalleDocumentoIngreso
    Dim detMora As DetalleDocumentoIngreso
    Dim ServMora As Servicio = Nothing
    Dim pp As ProgramacionPago
    Dim noEncontrado As Boolean = False

    det = New DetalleDocumentoIngreso
    det.Monto = wMonto
    If wObligacion.StartsWith("O") = True Then
      det.Obligacion = rnOb.LeerDetalles(CInt(wObligacion.Substring(1, wObligacion.Length - 1)), ServMora)

      If det.Obligacion IsNot Nothing Then
        det.Descripcion = det.Obligacion.Descripcion
        det.Servicio = det.Obligacion.Servicio
      Else
        det.Descripcion = "Pago"
        det.Monto = wMonto
        det.Servicio = New Servicio With {.entidad = "I"}
        If wMora > 0 Then
          det.Monto += wMora
          wMora = 0
        End If
        noEncontrado = True
      End If
    Else
      det.Obligacion = rnOb.LeerDeProgramacion(wCodigoAlumno, CInt(wObligacion.Substring(1, wObligacion.Length - 1)), ServMora)
      If det.Obligacion Is Nothing Then
        pp = rnPP.Leer(New ProgramacionPago() With {.codigo = CInt(wObligacion.Substring(1, wObligacion.Length - 1))})
        det.Descripcion = pp.Descripcion
        det.Obligacion = New Obligacion
        det.Servicio = pp.Servicio
        With det.Obligacion
          .Codigo = -2
          .Descripcion = det.Descripcion
          .Monto = pp.Monto
          .FechaVencimiento = pp.Vencimiento
          .Matricula = New Matricula
          With .Matricula
            .Numero = -1
            .Anio = pp.Anio
          End With
          .Servicio = pp.Servicio
          .Vigencia = True
        End With
      Else
        det.Descripcion = det.Obligacion.Descripcion
        det.Servicio = det.Obligacion.Servicio
      End If
    End If

    doc = Me.BuscarDocumento(wCodigoAlumno, wFecha, wOperacion, det.Servicio.entidad)
    If noEncontrado = True Then
      MessageBox.Show("No se pudo obtener información del pago realizado del alumno " & doc.Persona.NombreCompleto, _
                 Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
    det.Documento = doc
    If det.Obligacion IsNot Nothing AndAlso det.Obligacion.Codigo = -2 Then
      det.Obligacion.Matricula.Alumno = New Alumno(doc.Persona.Codigo)
    End If
    doc.Detalles.Add(det)
    '    doc.Voucher.Monto += det.Monto
    DirectCast(Me.Vouchers.Item("V" & doc.Voucher.NumOperacion), VoucherPago).Monto += det.Monto

    If wMora > 0 Then
      detMora = New DetalleDocumentoIngreso
      detMora.Documento = doc
      detMora.Servicio = ServMora
      detMora.Descripcion = "MORA - " & det.Descripcion
      If detMora.Descripcion.Length > 60 Then
        detMora.Descripcion = detMora.Descripcion.Substring(0, 60)
      End If
      detMora.Monto = wMora
      detMora.Obligacion = New Obligacion()
      With detMora.Obligacion
        .Codigo = -1
        .Descripcion = detMora.Descripcion
        .Monto = detMora.Monto
        .FechaVencimiento = doc.Fecha
        .Matricula = det.Obligacion.Matricula
        .Servicio = detMora.Servicio
        .ObligacionPadre = det.Obligacion
      End With

      doc.Detalles.Add(detMora)
      doc.Voucher.Monto += detMora.Monto
    End If
  End Sub

  Private Function Buscar(ByVal wFecha As DateTime, ByVal wOperacion As String, ByVal wEntidad As String) As DocumentoIngreso
    Dim pos As Integer = 0
    Dim nuevoDoc As DocumentoIngreso
    Dim docs As List(Of DocumentoIngreso)

    If wEntidad = "I" Then
      docs = Me.DocumentosInstitucion
    Else
      docs = Me.DocumentosCOPAFA
    End If

    For Each doc In docs
      If DateAndTime.DateDiff(DateInterval.Day, doc.Voucher.Fecha, wFecha) = 0 AndAlso _
          doc.Voucher.NumOperacion.Equals(wOperacion) = True AndAlso doc.Entidad.Equals(wEntidad) = True Then
        If doc.Detalles.Count < 4 Then
          Return doc
        Else
          If pos + 1 < Me.DocumentosInstitucion.Count Then
            With Me.DocumentosInstitucion.Item(pos + 1)
              If DateAndTime.DateDiff(DateInterval.Day, .Voucher.Fecha, wFecha) = 0 AndAlso _
                  .Voucher.NumOperacion.Equals(wOperacion) = True AndAlso .Entidad.Equals(wEntidad) = True Then

                Return Me.DocumentosInstitucion.Item(pos + 1)
              End If
            End With
          Else
            nuevoDoc = New DocumentoIngreso
            nuevoDoc.TipoDocumento = doc.TipoDocumento
            nuevoDoc.Serie = doc.Serie
            nuevoDoc.Numero = doc.Numero + 1
            Me.NumeroDocInstitucion += 1
            nuevoDoc.Fecha = doc.Fecha
            nuevoDoc.Persona = doc.Persona
            nuevoDoc.Entidad = doc.Entidad
            nuevoDoc.Vigencia = True
            nuevoDoc.FormaPago = "V"
            nuevoDoc.Voucher = doc.Voucher
            nuevoDoc.Detalles = New List(Of DetalleDocumentoIngreso)
            Me.DocumentosInstitucion.Add(nuevoDoc)

            Return nuevoDoc
          End If
        End If
      ElseIf DateAndTime.DateDiff(DateInterval.Second, doc.Voucher.Fecha, wFecha) < 0 Then
        Exit For
      End If
      pos += 1
    Next

    Return Nothing
  End Function

  Private Function BuscarDocumento(ByVal wAlumno As String, ByVal wFecha As DateTime, ByVal wOperacion As String, ByVal wEntidad As String) As DocumentoIngreso
    Dim doc As DocumentoIngreso
    Dim al As Alumno

    doc = Me.Buscar(wFecha, wOperacion, wEntidad)

    If doc Is Nothing Then
      rnAl = New RNAlumno
      If wAlumno.EndsWith("A") = False Then
        al = rnAl.LeerDatosAlumno_CodigoRecaudacion(wAlumno)
      Else
        al = rnAl.Leer(New Alumno(CInt(wAlumno.Substring(0, wAlumno.Length - 1))))
      End If

      doc = New DocumentoIngreso
      doc.Persona = al
      doc.Entidad = wEntidad
      If wEntidad = "I" Then
        doc.TipoDocumento = Me.cboTipoDocInstitucion.Text.Substring(0, 1)
        doc.Serie = Me.SerieDocInstitucion
        doc.Numero = Me.NumeroDocInstitucion
        Me.NumeroDocInstitucion += 1
      Else
        doc.TipoDocumento = Me.cboTipoDocCOPAFA.Text.Substring(0, 1)
        doc.Serie = Me.SerieDocCOPAFA
        doc.Numero = Me.NumeroDocCOPAFA
        Me.NumeroDocCOPAFA += 1
      End If
      doc.Fecha = Me.FechaDocInstitucion
      doc.Vigencia = True
      doc.FormaPago = "V"

      If Me.Vouchers.Item("V" & wOperacion) IsNot Nothing Then
        doc.Voucher = DirectCast(Me.Vouchers.Item("V" & wOperacion), VoucherPago)
      Else
        doc.Voucher = New VoucherPago(0, 0, wFecha, wOperacion, True, Nothing, Me.MovimientoHistorico.CuentaBancaria, Nothing)
        Me.Vouchers.Add("V" & doc.Voucher.NumOperacion, doc.Voucher)
      End If
      doc.Detalles = New List(Of DetalleDocumentoIngreso)
      If wEntidad = "I" Then
        Me.DocumentosInstitucion.Add(doc)
      Else
        Me.DocumentosCOPAFA.Add(doc)
      End If
    End If

    Return doc
  End Function

  Private Sub ImportarDataBIF()
    Dim objleer As StreamReader
    Dim monto As Double = 0

    Ruta = CargarRuta("C:\BANCOS\BIF\IMPORTAR").ToString
    If Ruta = "" Then
      Exit Sub
    End If
    If Ruta IsNot Nothing Then
      Try
        objleer = New StreamReader(Ruta, System.Text.Encoding.Default)
        Me.MovimientoHistorico = Nothing
        Me.MovimientoHistorico = New MovimientoHistorico
        Me.MovimientoHistorico.CuentaBancaria = DirectCast(cboCuenta.SelectedItem, CuentaBancaria)

        rnOb = New RNObligacion
        rnPP = New RNProgramacionPago
        rnAl = New RNAlumno
        While objleer.EndOfStream = False
          AgregarPagoBIF(objleer.ReadLine)
        End While
        objleer.Close()
        If DocumentosInstitucion.Count > 0 Then
          Me.MovimientoHistorico.fecha = DocumentosInstitucion.Item(0).Fecha
          For Each dc In Me.DocumentosInstitucion
            monto += dc.Total
          Next
        End If

        Me.txtVouchers.Text = Me.DocumentosInstitucion.Count.ToString
        Me.txtTotal.Text = monto.tostring
      Catch ex As Exception
        MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        objleer = Nothing
        rnOb = Nothing
        rnPP = Nothing
        rnAl = Nothing
      End Try
    End If
  End Sub

  Private Sub AgregarPagoBIF(ByVal wLinea As String)
    Dim fecha As DateTime
    Dim operacion As String
    Dim codigoAlumno As String
    Dim codigoObligacion As String
    Dim monto As Double, mora As Double

    With wLinea
      fecha = ConvertirFechaHora(.Substring(219, 4) & .Substring(216, 2) & .Substring(213, 2), "")
      operacion = .Substring(0, 12)
      codigoAlumno = .Substring(12, 20).Trim
      codigoObligacion = .Substring(223, 7).TrimEnd
      monto = CDbl(.Substring(147, 14))
      mora = CDbl(.Substring(185, 14))
      GenerarDocumentoIngreso(codigoAlumno, fecha, operacion, codigoObligacion, monto, mora)
    End With
  End Sub

  Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
    Dim objRNdoc As New RNDocumentoIngreso

    Me.dgvVouchersInstitucion.DataSource = Nothing
    Me.dgvVouchersCOPAFA.DataSource = Nothing

    Me.DocumentosCOPAFA = Nothing
    Me.DocumentosCOPAFA = New List(Of DocumentoIngreso)
    Me.SerieDocCOPAFA = CInt(txtSerieCOPAFA.Text)
    Me.NumeroDocCOPAFA = CInt(txtNumeroCOPAFA.Text)
    Me.FechaDocCOPAFA = Me.dtpFechaCOPAFA.Value

    Me.DocumentosInstitucion = Nothing
    Me.DocumentosInstitucion = New List(Of DocumentoIngreso)
    Me.SerieDocInstitucion = CInt(txtSerieInstitucion.Text)
    Me.NumeroDocInstitucion = CInt(txtNumeroInstitucion.Text)
    Me.FechaDocInstitucion = Me.dtpFechaInstitucion.Value

    Me.Vouchers = Nothing
    Me.Vouchers = New Hashtable
    If Me.cboEntidadFinanciera.SelectedIndex = 0 Then
      Me.ImportarDataBCP()
    Else
      Me.ImportarDataBIF()
    End If

    Me.PresentarDocumentos(Me.dgvVouchersInstitucion, Me.DocumentosInstitucion, "I")
    Me.PresentarDocumentos(Me.dgvVouchersCOPAFA, Me.DocumentosCOPAFA, "C")
  End Sub

  Private Sub PresentarDocumentos(ByVal wDataGrid As DataGridView, ByVal wDocumentos As List(Of DocumentoIngreso), ByVal wEntidad As String)
    Dim DocsImprimir As List(Of DocumentoImprimir)
    If wDocumentos IsNot Nothing Then
      If wEntidad = "I" Then
        Me.DocumentosImprimirInstitucion = New List(Of DocumentoImprimir)
        DocsImprimir = Me.DocumentosImprimirInstitucion
      Else
        Me.DocumentosImprimirCOPAFA = New List(Of DocumentoImprimir)
        DocsImprimir = Me.DocumentosImprimirCOPAFA
      End If

      For Each doc In wDocumentos
        DocsImprimir.Add(New DocumentoImprimir)
        With DocsImprimir.Item(DocsImprimir.Count - 1)
          .Documento = doc
        End With
      Next
      wDataGrid.AutoGenerateColumns = False
      wDataGrid.DataSource = DocsImprimir
    End If
  End Sub

  Private Sub btnRegistrarInstitucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarInstitucion.Click
    Dim rnMov As RNMovimientoHistorico = Nothing
    Dim rnDoc As RNDocumentoIngreso
    Dim adm As Administrativo
    Dim contImpresos As Integer = 0

    If Me.DocumentosInstitucion IsNot Nothing Then
      Try
        rnMov = New RNMovimientoHistorico
        Me.MovimientoHistorico = rnMov.Registrar(Me.MovimientoHistorico)
        rnMov = Nothing
        rnDoc = New RNDocumentoIngreso
        rnMat = New RNMatricula
        adm = New Administrativo() With {.Codigo = mOUsuario.Persona.Codigo}
        For Each doc In DocumentosImprimirInstitucion
          If doc.Imprimir = True Then
            doc.Documento.Voucher.MovimientoHistorico = Me.MovimientoHistorico
            doc.Documento.Voucher.Administrativo = adm
            doc.Documento.Administrativo = adm
            rnDoc.Registrar(doc.Documento)
            ImprimirDocumento(doc.Documento)
            Me.txtNumeroInstitucion.Text = (doc.Documento.Numero + 1).ToString

            contImpresos += 1
            If contImpresos = LIMITE Then
              If MessageBox.Show("¿Desea continuar?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                contImpresos = 0
              Else
                Exit For
              End If
            End If
          End If
        Next

        MessageBox.Show("La importación se realizó exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Catch ex As Exception
        MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        rnDoc = Nothing
        rnMov = Nothing
        rnMat = Nothing
      End Try
    Else
      MessageBox.Show("No hay depósitos que registrar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub ImprimirDocumento(ByVal wDocumento As DocumentoIngreso)
    Dim rnO As RNObligacion
    Dim dv As VistaDetalleDocumentoIngreso
    Dim detalles As New List(Of VistaDetalleDocumentoIngreso)
    Dim mat As Matricula

    rnO = New RNObligacion
    For Each det In wDocumento.Detalles
      dv = New VistaDetalleDocumentoIngreso
      dv.Seleccionado = True
      dv.Descripcion = det.Descripcion
      dv.Monto = det.Monto
      If det.Obligacion IsNot Nothing Then
        dv.Obligacion = det.Obligacion
        dv.Beneficio = rnO.CalcularBeneficio(dv.Obligacion)
      End If
      detalles.Add(dv)
    Next
    rnO = Nothing
    mat = Me.rnMat.LeerMatriculaxGradoSeccion(DirectCast(wDocumento.Persona, Alumno))

    modImprimirDocumento.ConfigurarReporte(wDocumento, mat, detalles)
    crpDocumento.PrintToPrinter(1, False, 1, 1)
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
    Me.Dispose()
  End Sub

  Private Sub cboCuenta_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuenta.Enter
    Dim rn As RNEntidadFinanciera

    If cboEntidadFinanciera.SelectedItem IsNot Nothing Then
      rn = New RNEntidadFinanciera
      cboCuenta.DisplayMember = "Numero"
      cboCuenta.ValueMember = "Numero"
      cboCuenta.DataSource = rn.ListarCuentas(DirectCast(cboEntidadFinanciera.SelectedItem, EntidadFinanciera))
    Else
      MessageBox.Show("Debe seleccionar una entidad financiera", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub dgVoucher_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvVouchersInstitucion.CellContentClick
    Dim frm As frmModificarCanje
    Dim doc As DocumentoIngreso
    Dim pos As Integer

    If Me.dgvVouchersInstitucion.Columns.Item(e.ColumnIndex).Name = "cdCanjear" Then
      If Me.dgvVouchersInstitucion.CurrentRow IsNot Nothing Then
        doc = DirectCast(Me.dgvVouchersInstitucion.CurrentRow.DataBoundItem, DocumentoImprimir).Documento
        frm = New frmModificarCanje
        frm.Registrar(doc)
        frm = Nothing

        pos = Me.dgvVouchersInstitucion.CurrentRow.Index
        Me.dgvVouchersInstitucion.DataSource = Nothing
        Me.dgvVouchersInstitucion.AutoGenerateColumns = False
        Me.dgvVouchersInstitucion.DataSource = Me.DocumentosImprimirInstitucion
      Else
        MessageBox.Show("Debe indicar los pagos a realizar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
    End If
  End Sub

  Private Sub cboTipoDocInstitucion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDocInstitucion.SelectedIndexChanged
    Me.ObtenerNumeracionInstitucion()
  End Sub

  Private Sub chkSeleccionarTodosInstitucion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSeleccionarTodosInstitucion.CheckedChanged
    Me.SeleccionarTodos(Me.dgvVouchersInstitucion, Me.DocumentosImprimirInstitucion, Me.chkSeleccionarTodosInstitucion.Checked)
  End Sub

  Private Sub btnVolverGenerarInstitucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverGenerarInstitucion.Click
    Me.GenerarNumeracion(Me.dgvVouchersInstitucion, Me.DocumentosImprimirInstitucion, CInt(Me.txtNumeroInstitucion.Text))
  End Sub

  Private Sub GenerarNumeracion(ByVal wDataGrid As DataGridView, ByVal wDocumentos As List(Of DocumentoImprimir), ByVal wNumero As Integer)

    wDataGrid.DataSource = Nothing
    For Each doc In wDocumentos
      If doc.Imprimir = True Then
        doc.Documento.Numero = wNumero
        wNumero += 1
      Else
        doc.Documento.Numero = 0
      End If
    Next

    wDataGrid.AutoGenerateColumns = False
    wDataGrid.DataSource = wDocumentos
  End Sub

  Private Sub txtSerieInstitucion_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerieInstitucion.Leave
    Me.ObtenerNumeracionInstitucion()
  End Sub

  Private Sub cboEntidadFinanciera_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEntidadFinanciera.SelectedIndexChanged
    Me.ObtenerNumeracionInstitucion()
  End Sub

  Private Sub btnVolverGenerarCOPAFA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverGenerarCOPAFA.Click
    Me.GenerarNumeracion(Me.dgvVouchersCOPAFA, Me.DocumentosImprimirCOPAFA, CInt(txtNumeroCOPAFA.Text))
  End Sub

  Private Sub cboTipoDocCOPAFA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDocCOPAFA.SelectedIndexChanged
    Me.ObtenerNumeracionCOPAFA()
  End Sub

  Private Sub SeleccionarTodos(ByVal wDataGrid As DataGridView, ByVal wDocumentosImprimir As List(Of DocumentoImprimir), ByVal wEstado As Boolean)
    If wDocumentosImprimir IsNot Nothing Then
      wDataGrid.DataSource = Nothing
      For Each doc In wDocumentosImprimir

        doc.Imprimir = wEstado
      Next
      wDataGrid.AutoGenerateColumns = False
      wDataGrid.DataSource = wDocumentosImprimir
    End If
  End Sub

  Private Sub chkSeleccionarTodosCOPAFA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSeleccionarTodosCOPAFA.CheckedChanged
    Me.SeleccionarTodos(Me.dgvVouchersCOPAFA, Me.DocumentosImprimirCOPAFA, Me.chkSeleccionarTodosCOPAFA.Checked)
  End Sub

  Private Sub btnRegistrarCOPAFA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarCOPAFA.Click
    Dim rnMov As RNMovimientoHistorico = Nothing
    Dim rnDoc As RNDocumentoIngreso
    Dim adm As Administrativo
    Dim contImpresos As Integer = 0

    If Me.DocumentosCOPAFA IsNot Nothing Then
      Try
        rnMov = New RNMovimientoHistorico
        Me.MovimientoHistorico = rnMov.Registrar(Me.MovimientoHistorico)
        rnMov = Nothing
        rnDoc = New RNDocumentoIngreso
        rnMat = New RNMatricula
        adm = New Administrativo() With {.Codigo = mOUsuario.Persona.Codigo}
        For Each doc In DocumentosImprimirCOPAFA
          If doc.Imprimir = True Then
            doc.Documento.Voucher.MovimientoHistorico = Me.MovimientoHistorico
            doc.Documento.Voucher.Administrativo = adm
            doc.Documento.Administrativo = adm
            rnDoc.Registrar(doc.Documento)
            ImprimirDocumento(doc.Documento)
            Me.txtNumeroCOPAFA.Text = (doc.Documento.Numero + 1).ToString

            contImpresos += 1
            If contImpresos = LIMITE Then
              If MessageBox.Show("¿Desea continuar?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                contImpresos = 0
              Else
                Exit For
              End If
            End If
          End If
        Next

        MessageBox.Show("La importación de pagos de COPAFA se realizó exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Catch ex As Exception
        MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        rnDoc = Nothing
        rnMov = Nothing
        rnMat = Nothing
      End Try
    Else
      MessageBox.Show("No hay depósitos que registrar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

End Class
