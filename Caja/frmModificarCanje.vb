Public Class frmModificarCanje

  Private mODetalles As List(Of VistaDetalleDocumentoIngreso)
  Private mODocumento As DocumentoIngreso

  Private mControlError As ErrorProvider

  Private Sub frmRegistrarPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    CargarIconos()
  End Sub

  Public Sub CargarIconos()
    Me.btnAceptar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnAgregar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\agregar.png")
  End Sub

  Public Sub Registrar(ByVal wDocumento As DocumentoIngreso)
    Me.PresentarDatos(wDocumento)
    Me.ShowDialog()
  End Sub

  Private Sub PresentarDatos(ByVal wDocumento As DocumentoIngreso)
    Me.mODocumento = wDocumento
    If String.Compare(wDocumento.Entidad, "I") = 0 Then
      Me.cboEntidad.SelectedIndex = 0
    Else
      Me.cboEntidad.SelectedIndex = 1
    End If
    Select Case wDocumento.TipoDocumento
      Case "R"
        Me.cboTipoDoc.SelectedIndex = 0
      Case "B"
        Me.cboTipoDoc.SelectedIndex = 1
      Case "F"
        Me.cboTipoDoc.SelectedIndex = 2
    End Select
    Me.txtSerie.Text = wDocumento.Serie.ToString
    Me.txtNumero.Text = wDocumento.Numero.ToString
    Me.dtpFecha.Value = wDocumento.Fecha
    Me.txtNombre.Text = wDocumento.Persona.NombreCompleto
    With DirectCast(wDocumento.Persona, Alumno)
      If String.IsNullOrEmpty(.CodigoRecaudacion) = False Then
        Me.txtCodigo.Text = CInt(.CodigoRecaudacion).ToString
      End If
    End With
    Me.txtMontoPagado.Text = wDocumento.Total.ToString("#.00")
    Me.CargarDatosMatricula(DirectCast(wDocumento.Persona, Alumno))
    Me.CargarPagosPendientes(wDocumento.Persona)

    Me.SeleccionarPagosPendientes(wDocumento)
  End Sub

  Private Sub SeleccionarPagosPendientes(ByVal wDocumento As DocumentoIngreso)
    Dim tot As Double = 0

    For Each dr In wDocumento.Detalles
      For Each drV In Me.mODetalles
        If dr.Obligacion IsNot Nothing Then
          If dr.Obligacion.Codigo > -1 AndAlso dr.Obligacion.Codigo = drV.Obligacion.Codigo Then

            drV.Seleccionado = True
            drV.Monto = dr.Monto
            tot += dr.Monto
            Exit For
          ElseIf dr.Obligacion.Codigo = -1 AndAlso drV.Obligacion.Codigo = -1 Then
            If dr.Obligacion.ObligacionPadre.Codigo = drV.Obligacion.ObligacionPadre.Codigo Then
              drV.Seleccionado = True
              drV.Monto = dr.Monto
              tot += dr.Monto

            End If
          End If
        End If
      Next
    Next

    Me.txtTotal.Text = tot.ToString("#.00")
  End Sub

  Private Sub CargarDatosMatricula(ByVal wAlumno As Alumno)
    Dim objmat As RNMatricula
    Dim matricula As Matricula

    objmat = New RNMatricula
    matricula = objmat.LeerMatriculaxGradoSeccion(wAlumno)
    objmat = Nothing
    If matricula IsNot Nothing Then
      Me.txtSeccion.Text = matricula.GradoSeccion
      matricula = Nothing
    End If
  End Sub

  Private Sub CargarPagosPendientes(ByVal wPersona As Persona)
    Dim rnPer As New RNPersona
    Dim tot As Double = 0

    Me.mODetalles = rnPer.ListarObligacionesPendientes(wPersona, cboEntidad.Text.Substring(0, 1))
    rnPer = Nothing
    If Me.mODetalles.Count > 0 Then
      dgvServicio.DataSource = Nothing
      dgvServicio.AutoGenerateColumns = False
      dgvServicio.DataSource = Me.mODetalles
      dgvServicio.Focus()
      For Each det In Me.mODetalles
        tot += det.Obligacion.Monto
      Next
      txtDeudaTotal.Text = tot.ToString("0.00")
    Else
      btnAgregar.Focus()
    End If
  End Sub

  Private Sub AgregarObligaciones(ByVal wPagos As List(Of Obligacion))
    For Each ob In wPagos
      Me.mODetalles.Add(New VistaDetalleDocumentoIngreso)
      With Me.mODetalles.Item(Me.mODetalles.Count - 1)
        .Descripcion = ob.Descripcion
        .Monto = ob.Monto
        .MontoOriginal = ob.Monto
        .Beneficio = New Beneficio
        .Obligacion = ob
        .Seleccionado = False
      End With
    Next
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Close()
    Me.Dispose()
  End Sub

  Public Function ExisteServicio(ByVal serv As Servicio) As Boolean

    For Each elm As DetalleDocumentoIngreso In Me.mODetalles
      If elm.Servicio.Codigo = serv.Codigo Then
        Return True
      End If
    Next

    Return False
  End Function

  Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
    Dim frm As New frmBuscarServicio
    Dim serv As Servicio

    serv = frm.Buscar(cboEntidad.Text.Substring(0, 1))
    frm.Dispose()
    If serv IsNot Nothing Then
      Me.AgregarServicio(serv)

      Me.ActualizarPagoRealizar()
      Me.dgvServicio.DataSource = Nothing
      Me.dgvServicio.AutoGenerateColumns = False
      Me.dgvServicio.DataSource = Me.mODetalles
    End If
  End Sub

  Private Sub AgregarServicio(ByVal wServicio As Servicio)
    Dim det As VistaDetalleDocumentoIngreso

    If Me.mODetalles Is Nothing Then
      Me.mODetalles = New List(Of VistaDetalleDocumentoIngreso)
    End If
    If ExisteServicio(wServicio) = False Then
      det = New VistaDetalleDocumentoIngreso
      det.Servicio = wServicio
      det.Descripcion = wServicio.Nombre

      det.Monto = wServicio.Monto
      det.MontoOriginal = wServicio.Monto

      det.Seleccionado = True
      Me.mODetalles.Insert(0, det)
    Else
      MessageBox.Show("El servicio ya ha sido agregado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If

  End Sub

  Private Sub dgvServicio_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvServicio.CellValueChanged
    If e.ColumnIndex = 0 AndAlso Me.dgvServicio.DataSource IsNot Nothing Then
      ActualizarPagoRealizar()
      If Me.mODetalles.Item(e.RowIndex).Obligacion IsNot Nothing Then
        If CBool(Me.dgvServicio.Rows.Item(e.RowIndex).Cells(e.ColumnIndex).Value) = True Then
          BuscarMora(Me.mODetalles.Item(e.RowIndex).Obligacion.Codigo, True)
        Else
          BuscarMora(Me.mODetalles.Item(e.RowIndex).Obligacion.Codigo, False)
        End If
      End If
      Me.dgvServicio.DataSource = Me.mODetalles
    End If
  End Sub

  Private Sub BuscarMora(ByVal wCodigoObligacion As Integer, ByVal wEstado As Boolean)
    Dim i As Integer = 0
    For Each det In Me.mODetalles
      If det.Obligacion IsNot Nothing AndAlso det.Obligacion.ObligacionPadre IsNot Nothing AndAlso _
            det.Obligacion.ObligacionPadre.Codigo = wCodigoObligacion Then
        Me.dgvServicio.Item(0, i).Value = wEstado

        Return
      End If
      i += 1
    Next
  End Sub

  Private Sub dgvServicio_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvServicio.CellContentClick
    If e.ColumnIndex = 0 Then
      dgvServicio.CurrentCell = Nothing
      dgvServicio.CurrentCell = Me.dgvServicio.Rows.Item(e.RowIndex).Cells(e.ColumnIndex)
    End If
  End Sub

  Private Sub ActualizarPagoRealizar()
    Dim tot As Double = 0
    Dim ob As Double = 0
    Dim mora As Double = 0

    If Me.mODetalles IsNot Nothing Then
      For Each det In Me.mODetalles
        If det.Seleccionado = True Then
          tot += det.Monto

          If det.Obligacion IsNot Nothing Then
            ob += det.Monto
          End If

          If det.Descripcion.ToUpper.IndexOf("MORA") >= 0 Then
            mora += det.Monto
          End If
        End If
      Next
      txtTotal.Text = tot.ToString("0.00")
      txtObligacionTotal.Text = ob.ToString("0.00")
      txtMoraTotal.Text = mora.ToString("0.00")
    End If
  End Sub

  Private Sub chkSeleccionarTodos_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSeleccionarTodos.CheckedChanged

    For Each det In Me.mODetalles
      det.Seleccionado = chkSeleccionarTodos.Checked
    Next

    Me.dgvServicio.DataSource = Nothing
    Me.dgvServicio.AutoGenerateColumns = False
    Me.dgvServicio.DataSource = Me.mODetalles
  End Sub

  Public Function verficarServiciosconCheck() As Boolean
    For i = 0 To dgvServicio.RowCount - 1
      If CBool(dgvServicio.Item("colItem", i).Value) = True Then
        Return True
      End If
    Next
    Return False
  End Function

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    Dim det As DetalleDocumentoIngreso
    Dim i As Integer = 0

    If Me.mODocumento.Total = CDbl(Me.txtTotal.Text) Then
      With Me.mODocumento
        .TipoDocumento = Me.cboTipoDoc.Text.Substring(0, 1)
        .Fecha = Me.dtpFecha.Value
        .Serie = CInt(Me.txtSerie.Text)
        .Numero = CInt(Me.txtNumero.Text)
        .Detalles.Clear()
        For Each dr In Me.mODetalles
          If dr.Seleccionado = True Then
            i += 1
            det = New DetalleDocumentoIngreso
            det.Item = i
            det.Servicio = dr.Servicio
            det.Obligacion = dr.Obligacion
            det.Descripcion = dr.Descripcion
            det.Monto = dr.Monto

            Me.mODocumento.Detalles.Add(det)
          End If
        Next
      End With
      Me.Close()
    Else
      MessageBox.Show("El monto a facturar y el monto pagado no coinciden", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub Validar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    Dim drwFila As DataGridViewCell = dgvServicio.CurrentCell()

    Try
      If dgvServicio.Columns(drwFila.ColumnIndex).Name = "colSubtotal" Then
        If Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 8) Or e.KeyChar = "." Then
          e.Handled = False
        Else
          e.Handled = True
        End If
      End If
    Catch ex As Exception
      MessageBox.Show("Debe ingresar un valor", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub txtNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerie.KeyPress, txtNumero.KeyPress
    If Char.IsDigit(e.KeyChar) = False AndAlso Char.IsNumber(e.KeyChar) = False _
            AndAlso Char.IsControl(e.KeyChar) = False Then
      e.Handled = True
    End If
  End Sub

  Public Sub MostrarRecibo()
    CargarIconos()
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Me.Dispose()
    Me.Close()
  End Sub

  Private Sub frmRegistrarPago_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
    txtCodigo.Focus()
  End Sub

  Private Sub dgvServicio_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dgvServicio.Validating
    If CDbl(txtTotal.Text) = 0 Then
      Me.mControlError.SetError(dgvServicio, "No se ha indicado los servicios a pagar")
      e.Cancel = True
    Else
      Me.mControlError.SetError(dgvServicio, "")
    End If
  End Sub

  Private Sub dgvServicio_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvServicio.CellEndEdit
    If Me.dgvServicio.Columns.Item(e.ColumnIndex).Name.ToString = "colSubtotal" Then
      Me.ActualizarPagoRealizar()
    End If
  End Sub

End Class
