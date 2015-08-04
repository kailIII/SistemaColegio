Public Class frmAsociarPago

  Private Alumno As Persona
  Private DetallePago As DetalleEstadoCuentaSeleccionar

  Public Sub AsociarPago(ByVal wAlumno As Persona, ByVal wSeccion As String, ByVal wDetallePago As DetalleEstadoCuentaSeleccionar)
    Me.txtNombre.Text = wAlumno.NombreCompleto
    Me.txtSeccion.Text = wSeccion
    If TypeOf wAlumno Is Alumno Then
      Me.txtCodigo.Text = DirectCast(wAlumno, Alumno).CodigoRecaudacion
    End If
    Me.DetallePago = wDetallePago
    Me.Alumno = wAlumno
    Me.MostrarPagosPendientes()

    Me.ShowDialog()
  End Sub

  Private Sub MostrarPagosPendientes()
    Dim rn As New RNPersona
    Dim detalles As List(Of VistaDetalleDocumentoIngreso)

    detalles = rn.ListarObligacionesPendientes(Me.Alumno, Me.DetallePago.DetallePago.Documento.Entidad)
    rn = Nothing

    Me.dgvPendientes.DataSource = detalles
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Close()
  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    Dim rn As RNDocumentoIngreso

    If Me.dgvPendientes.CurrentRow IsNot Nothing Then
      rn = New RNDocumentoIngreso
      Try
        rn.AsociarPago(Me.DetallePago.DetallePago, DirectCast(Me.dgvPendientes.CurrentRow.DataBoundItem, VistaDetalleDocumentoIngreso).Obligacion)

        Me.Close()
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        rn = Nothing
      End Try
    Else
      MessageBox.Show("Debe seleccionar un servicio", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

End Class