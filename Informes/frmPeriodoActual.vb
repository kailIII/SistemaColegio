Public Class frmPeriodoActual

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Close()
  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    If Me.ValidateChildren Then
      mOInstitucion = CType(cboInstitucion.SelectedItem, Institucion)
      moAnioActual = CType(cboAnio.SelectedItem, AnioLectivo)

      Me.Close()
    End If
  End Sub

#Region "Validaciones"

  Private Sub cboInstitucion_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboInstitucion.Validating
    If cboInstitucion.SelectedIndex = -1 AndAlso cboInstitucion.Items.Count > 0 Then
      errPeriodoActual.SetError(cboInstitucion, "Debe seleccionar la institución educativa")
      e.Cancel = True
    Else
      errPeriodoActual.SetError(cboInstitucion, "")
    End If
  End Sub

  Private Sub cboAnio_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboAnio.Validating
    If cboAnio.SelectedIndex = -1 AndAlso cboAnio.Items.Count > 0 Then
      errPeriodoActual.SetError(cboAnio, "Debe seleccionar el año lectivo actual")
      e.Cancel = True
    Else
      errPeriodoActual.SetError(cboAnio, "")
    End If
  End Sub

#End Region

  Public Sub Configurar()
    CargarDatos()
    If moAnioActual Is Nothing Then
      Me.ShowDialog()
    End If
  End Sub

  Private Sub CargarDatos()
    CargarInstituciones()
  End Sub

  Private Sub CargarInstituciones()
    Dim rnI As New RNInstitucion
    Dim lI As List(Of Institucion)

    lI = rnI.ListarI()
    cboInstitucion.DisplayMember = "Nombre"
    cboInstitucion.ValueMember = "CodigoInst"
    cboInstitucion.DataSource = lI
    If lI.Count = 1 Then
      cboInstitucion.SelectedValue = lI.Item(0).CodigoInst
      CargarAnios(lI.Item(0))
    Else
      cboInstitucion.Focus()
    End If
  End Sub

  Private Sub CargarAnios(ByVal wInst As Institucion)
    Dim rnA As New RNAnioLectivo
    Dim lA As List(Of AnioLectivo)

    lA = rnA.ListarAbiertos(wInst)
    cboAnio.DisplayMember = "Anio"
    cboAnio.ValueMember = "Anio"
    cboAnio.DataSource = lA

    If lA.Count = 1 Then
      cboAnio.SelectedValue = lA.Item(0).anio
      cboInstitucion.Tag = cboInstitucion.Text
      mOInstitucion = DirectCast(cboInstitucion.SelectedItem, Institucion)
      moAnioActual = DirectCast(cboAnio.SelectedItem, AnioLectivo)
    Else
      For Each a As AnioLectivo In lA
        If a.Estado = AnioLectivo.EstadoPeriodo.Abierto Then
          cboAnio.SelectedItem = a
          cboInstitucion.Tag = cboInstitucion.Text
          Exit Sub
        End If
      Next
      cboAnio.Focus()
    End If

  End Sub

  Private Sub frmPeriodoActual_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    If cboInstitucion.SelectedIndex = -1 Then
      cboInstitucion.Focus()
    ElseIf cboAnio.SelectedIndex = -1 Then
      cboAnio.Focus()
    Else
      btnAceptar.Focus()
    End If
  End Sub

  Private Sub cboAnio_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnio.Enter
    If cboInstitucion.SelectedItem IsNot Nothing Then
      If cboInstitucion.Tag.ToString <> cboInstitucion.Text Then
        CargarAnios(DirectCast(cboInstitucion.SelectedItem, Institucion))
      End If
    Else
      MessageBox.Show("Debe seleccionar una institución educativa", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Me.cboAnio.DataSource = Nothing
      Me.cboAnio.SelectedIndex = -1
      cboInstitucion.Focus()
    End If
  End Sub

End Class