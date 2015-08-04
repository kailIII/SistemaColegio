Public Class frmCompra
  Private codigoNuevo As Integer = 0
  Shared frm As Form
  Private listaDetalle As New List(Of DetalleCompra)
  Private indiceLista As Integer = -1
  'Private montoTotal As Double
  Private montoAnterior As Double
  Private beneficiario As Personal
  Private listaCompra As New List(Of Compra)
  Public Shared Sub Crear(ByVal pPadre As Form)
    If frmCompra.frm Is Nothing Then
      frmCompra.frm = New frmCompra
      frmCompra.frm.MdiParent = pPadre
      frmCompra.frm.Show()
      frmCompra.frm.WindowState = FormWindowState.Maximized
    Else
      frm.Activate()
    End If
  End Sub

  Private Sub frmCompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.LimpiarTodo()
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCerrarCompra.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnEditar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Editar.jpg")
    'Me.btnNuevoCompra.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\nuevo.png")
    Me.btnAgregar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\mas.png")
    Me.btnEliminar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\error.png")
    Me.btnModificar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\actualizar.png")
    Me.btnAnularCompra.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\eliminar.jpg")
    Me.btnNuevoCompra.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\mas.jpg")
    Me.btnBuscar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Buscar.png")
    Me.CargarTipoDocumento()
    Me.CargarConceptoCompra()
  End Sub

  Private Sub frmCompra_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmCompra.frm = Nothing
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Me.BuscarPersonal()
  End Sub

  Private Sub BuscarPersonal()
    beneficiario = frmBuscarPersonal.Buscar
    Me.txtPersonal.Text = beneficiario.NombreCompleto
  End Sub

  Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
    Dim codigoConcepto = 0
    If Validar() Then

      If CInt(Me.cboConceptoCompra.SelectedValue) > 0 Then
        codigoConcepto = CInt(Me.cboConceptoCompra.SelectedValue)
      End If

      If Me.indiceLista <> -1 Then
        Dim detalleC = New DetalleCompra(CInt(Me.nudCantidad.Value), CDbl(Me.nudMonto.Value), New Compra(),
                                           New ConceptoCompra(CInt(codigoConcepto), Me.cboConceptoCompra.Text, True, ""),
                                           Me.txtDescripcion.Text)

        Me.listaDetalle.RemoveAt(Me.indiceLista)
        Me.listaDetalle.Insert(Me.indiceLista, detalleC)
        Me.txtMontoTotal.Text = (CDbl(Me.txtMontoTotal.Text) + (CDbl(Me.nudMonto.Value) - Me.montoAnterior)).ToString
      Else
        listaDetalle.Add(New DetalleCompra(CInt(Me.nudCantidad.Value), CDbl(Me.nudMonto.Value), New Compra(),
                                           New ConceptoCompra(CInt(codigoConcepto), Me.cboConceptoCompra.Text, True, ""),
                                           Me.txtDescripcion.Text))        
        Me.txtMontoTotal.Text = (CDbl(Me.txtMontoTotal.Text) + CDbl(Me.nudMonto.Value)).ToString
      End If
      Me.dgvDetalleCompra.AutoGenerateColumns = False
      Me.dgvDetalleCompra.DataSource = Nothing
      Me.dgvDetalleCompra.DataSource = listaDetalle
      If Me.dgvDetalleCompra.RowCount > 0 Then
        Me.btnModificar.Enabled = True
        Me.btnEliminar.Enabled = True
      End If
      Me.indiceLista = -1
      Me.btnAgregar.Text = "&Agregar"
      Me.LimpiarDetalles()
    End If
  End Sub

  Private Sub cboTipoDocumento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoDocumento.SelectedIndexChanged
    If Me.cboTipoDocumento.Text = "RECIBO POR HONORARIOS" Then
      Me.txtDescripcion.Visible = True
      Me.lblDescripcion.Visible = True
    Else
      Me.txtDescripcion.Visible = False
      Me.lblDescripcion.Visible = False
    End If
  End Sub

  Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
    If Me.dgvDetalleCompra.SelectedRows.Count > 0 Then
      Me.txtMontoTotal.Text = (CDbl(Me.txtMontoTotal.Text) - CDbl(Me.dgvDetalleCompra.SelectedRows(0).Cells("cdMonto").Value)).ToString
      'Me.txtMontoTotal.Text = Me.montoTotal.ToString
      Me.listaDetalle.RemoveAt(Me.dgvDetalleCompra.CurrentRow.Index)
      Me.dgvDetalleCompra.DataSource = Nothing
      Me.dgvDetalleCompra.DataSource = listaDetalle

    End If
    If Me.dgvDetalleCompra.RowCount = 0 Then
      Me.btnModificar.Enabled = False
      Me.btnEliminar.Enabled = False
    End If
  End Sub

  Private Sub CargarTipoDocumento()
    Dim lista As New List(Of TipoDocumento)
    Dim rnTipoDocumento As New RNTipoDocumento
    Me.cboTipoDocumento.DataSource = rnTipoDocumento.listarTipoDocumento
    Me.cboTipoDocumento.ValueMember = "codigoTipoDocumento"
    Me.cboTipoDocumento.DisplayMember = "descripcion"
    Me.cboTipoDocumento.SelectedIndex = -1
  End Sub

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
    If Me.dgvDetalleCompra.SelectedRows.Count > 0 Then
      With DirectCast(Me.dgvDetalleCompra.CurrentRow.DataBoundItem, DetalleCompra)
        Me.cboConceptoCompra.SelectedValue = .ConceptoCompra.codigoConceptoCompra
        Me.nudCantidad.Value = .cantidad
        Me.nudMonto.Value = CDec(.precioTotal)
        Me.montoAnterior = CDec(.precioTotal)
        Me.btnAgregar.Text = "&Actualizar"
      End With
      Me.indiceLista = Me.dgvDetalleCompra.CurrentRow.Index
    End If
  End Sub

  Private Sub LimpiarTodo()
    Me.cboTipoDocumento.SelectedIndex = -1
    Me.txtSerie.Text = ""
    Me.txtNumero.Text = ""
    Me.txtPersonal.Text = ""

    Me.txtDescripcion.Text = ""
    Me.cboConceptoCompra.SelectedIndex = -1
    Me.cboConceptoCompra.Text = ""
    Me.nudCantidad.Value = 1
    Me.nudMonto.Value = 0
    Me.txtMontoTotal.Text = "0"
    Me.nudIGV.Value = 0
    'Me.dgvDetalleCompra.ClearSelection()
    Me.listaDetalle.Clear()
    Me.dgvDetalleCompra.AutoGenerateColumns = False
    Me.dgvDetalleCompra.DataSource = Nothing
    Me.dgvDetalleCompra.Refresh()
    Me.codigoNuevo = 0
    Me.btnRegistrar.Text = "&Registrar"
  End Sub
  Private Sub LimpiarDetalles()
    Me.txtDescripcion.Text = ""
    Me.cboConceptoCompra.SelectedIndex = -1
    Me.cboConceptoCompra.Text = ""
    Me.nudCantidad.Value = 1
    Me.nudMonto.Value = 0
  End Sub
  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim rnCompra As New RNCompra
    Dim row As Integer
    Try
      If ValidarTodo() Then
        If Me.codigoNuevo = 0 Then
          row = rnCompra.RegistrarCompraCajaChicaConcepto(New Compra(Me.txtNumero.Text,
                                                        New TipoDocumento(CInt(Me.cboTipoDocumento.SelectedValue), ""),
                                                        New Personal(Me.beneficiario.Codigo), Me.txtSerie.Text, Me.nudIGV.Value),
                                            CDbl(Me.txtMontoTotal.Text),
                                            Me.listaDetalle)
          If row > 0 Then
            MessageBox.Show("Se registró correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          Else
            MessageBox.Show("No se registró", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          End If
        Else
          row = rnCompra.ModificarCompraCajaChicaConcepto(New Compra(Me.txtNumero.Text,
                                                        New TipoDocumento(CInt(Me.cboTipoDocumento.SelectedValue), ""),
                                                        New Personal(Me.beneficiario.Codigo),
                                                        Me.txtSerie.Text, Me.nudIGV.Value) With {.codigoCompra = Me.codigoNuevo},
                                            CDbl(Me.txtMontoTotal.Text),
                                            Me.listaDetalle)

          If row > 0 Then
            MessageBox.Show("Se modificó correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          Else
            MessageBox.Show("No se modificó", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          End If
          Me.tbControl.SelectedTab = Me.tpCompras          
        End If
        Me.CargarConceptoCompra()
        Me.LimpiarTodo()
        Me.btnListarCompra.PerformClick()
        Dim saldo = rnCompra.ListarSaldo().ToString
        frmPrincipal.txtSaldoPrincipal.Text = saldo.Substring(0, saldo.Length - 2)
      End If
    Catch ex As Exception
      Throw ex
    End Try
  End Sub

  Private Function ValidarTodo() As Boolean
    Dim boleano = True
    If Me.cboTipoDocumento.SelectedIndex < 0 Then
      MessageBox.Show("Elija el tipo de documento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      boleano = False
    Else
      If Me.txtSerie.Text = "" Then
        MessageBox.Show("Ingrese serie del documento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        boleano = False
      Else
        If Me.txtNumero.Text = "" Then
          MessageBox.Show("Ingrese el numero de documento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          boleano = False
        Else
          If Me.txtPersonal.Text = "" Then
            MessageBox.Show("Elija al personal responsable de la compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            boleano = False
          Else
            If Me.listaDetalle.Count = 0 Then
              MessageBox.Show("Debe agregar productos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
              boleano = False
            End If
          End If

        End If
      End If
    End If

    Return boleano
  End Function

  Private Function Validar() As Boolean
    Dim boleano = True
    If Me.cboConceptoCompra.Text = "" Then
      MessageBox.Show("Elija o ingrese el producto o servicio", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      boleano = False
    Else
      If Me.nudCantidad.Value = 0 Then
        MessageBox.Show("Ingrese cantidad", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        boleano = False
      Else
        If Me.nudMonto.Value = 0 Then
          MessageBox.Show("Ingrese monto", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          boleano = False
        End If
      End If
    End If
    Return boleano
  End Function

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.LimpiarTodo()
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarCompra.Click
    Dim rnCompra As New RNCompra
    Dim fechaIni = CDate(Me.dtpFechaInicio.Value.ToString("dd-MM-yyyy"))
    Dim fechaFin = CDate(Me.dtpFechaFin.Value.ToString("dd-MM-yyyy"))
    If DateAndTime.DateDiff(DateInterval.Day, dtpFechaInicio.Value, dtpFechaFin.Value) >= 0 Then
      listaCompra = rnCompra.listarCompraCajaChica(fechaIni, fechaFin)
      Me.dgvCompra.AutoGenerateColumns = False
      Me.dgvCompra.DataSource = listaCompra
      Me.Habilitar(True)
    Else
      listaCompra.Clear()
      Me.dgvCompra.AutoGenerateColumns = False
      Me.dgvCompra.DataSource = listaCompra
      Me.dgvCompra.Refresh()
    End If
  End Sub

  Private Sub CargarConceptoCompra()

    Dim lista As New List(Of ConceptoCompra)
    Dim rnConcepto As New RNConceptoCompra
    Me.cboConceptoCompra.DataSource = rnConcepto.ListarConceptoCompra("CC")
    Me.cboConceptoCompra.ValueMember = "codigoConceptoCompra"
    Me.cboConceptoCompra.DisplayMember = "nombre"
    Me.cboConceptoCompra.SelectedIndex = -1
  End Sub

  Private Sub dgvDetalleCompra_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvDetalleCompra.DataError
    'MessageBox.Show(e.ThrowException.ToString, Me.Text)
  End Sub

  Private Sub btnCerrarCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarCompra.Click
    Me.Close()
  End Sub

  Private Sub Habilitar(ByVal wBoolean As Boolean)
    Me.btnEditar.Enabled = wBoolean
    Me.btnAnularCompra.Enabled = wBoolean
  End Sub

  Private Sub dgvCompra_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvCompra.DataError

  End Sub

  Private Sub btnNuevoCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoCompra.Click
    Me.tbControl.SelectedTab = Me.tpRegistroCompra
    Me.cboTipoDocumento.Focus()
    Me.codigoNuevo = 0
  End Sub

  Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
    If Me.dgvCompra.SelectedRows.Count > 0 Then
      Dim rnDetalles As New RNDetalleCompra
      With DirectCast(Me.dgvCompra.CurrentRow.DataBoundItem, Compra)
        Me.codigoNuevo = .codigoCompra
        Me.cboTipoDocumento.SelectedValue = .TipoDocumento.codigoTipoDocumento
        Me.txtNumero.Text = .numeroDocumento
        Me.txtSerie.Text = .serie
        Me.nudIGV.Value = CDec(.IGV)
        Me.txtMontoTotal.Text = .monto.ToString

        Me.txtPersonal.Text = .Beneficiario.NombreCompleto
        Me.beneficiario = .Beneficiario
      End With
      Me.listaDetalle.Clear()
      Me.listaDetalle = rnDetalles.listarDetalleCompraCajaChica(Me.codigoNuevo)
      Me.dgvDetalleCompra.AutoGenerateColumns = False
      Me.dgvDetalleCompra.DataSource = listaDetalle
      Me.btnModificar.Enabled = True
      Me.btnEliminar.Enabled = True
      Me.tbControl.SelectedTab = Me.tpRegistroCompra
      Me.btnRegistrar.Text = "&Actualizar"
    Else
      MessageBox.Show("Elija una compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub btnAnularCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnularCompra.Click
    If Me.dgvCompra.SelectedRows.Count > 0 Then
      Dim rnCompra As New RNCompra
      Dim compra = DirectCast(Me.dgvCompra.CurrentRow.DataBoundItem, Compra)
      If rnCompra.ModificarCompraCajaChicaVigencia(compra) > 0 Then
        'MessageBox.Show("Eliminación exitosa")        
        Dim saldo = rnCompra.ListarSaldo().ToString
        frmPrincipal.txtSaldoPrincipal.Text = saldo.Substring(0, saldo.Length - 2)
        Me.btnListarCompra.PerformClick()
      Else
        MessageBox.Show("No se eliminó")
      End If
    Else
      MessageBox.Show("Elija compra", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub txtSerie_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerie.KeyPress
    If ValidarSerieNumero(e.KeyChar) = False Or Me.txtSerie.TextLength = 3 Or
      e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Delete) Or e.KeyChar = ChrW(Keys.Clear) Then
      e.Handled = True
    Else
      e.Handled = False
    End If
  End Sub

  Private Function ValidarSerieNumero(ByVal wchar As Char) As Boolean
    If wchar = "0" Or wchar = "1" Or wchar = "2" Or wchar = "3" Or
      wchar = "4" Or wchar = "5" Or wchar = "6" Or wchar = "7" Or wchar = "8" Or wchar = "9" Then
      Return True
    Else
      Return False
    End If
  End Function

  Private Sub txtNumero_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
    If ValidarSerieNumero(e.KeyChar) = False Or Me.txtNumero.TextLength = 5 Then
      e.Handled = True
    Else
      e.Handled = False
    End If
  End Sub

End Class