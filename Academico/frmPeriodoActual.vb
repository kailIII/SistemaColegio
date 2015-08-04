Public Class frmPeriodoActual

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Close()
  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    If Me.ValidateChildren Then
      mOInstitucion = CType(cboInstitucion.SelectedItem, Institucion)
      moAnioActual = CType(cboAnio.SelectedItem, AnioLectivo)
      mOPeriodoActual = CType(cboPeriodo.SelectedItem, PeriodoAcademico)

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

  Private Sub cboPeriodo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboPeriodo.Validating
    If cboPeriodo.SelectedIndex = -1 AndAlso cboPeriodo.Items.Count > 0 Then
      errPeriodoActual.SetError(cboPeriodo, "Debe seleccionar el periodo académico actual")
      e.Cancel = True
    Else
      errPeriodoActual.SetError(cboPeriodo, "")
    End If
  End Sub

#End Region

  Public Sub Configurar()
    CargarDatos()
    Me.ShowDialog()
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

    lA = rnA.ListarActivos(wInst)
    cboAnio.DisplayMember = "Anio"
    cboAnio.ValueMember = "Anio"
    cboAnio.DataSource = lA

    If lA.Count = 1 Then
      cboAnio.SelectedValue = lA.Item(0).anio
      CargarPeriodos(lA.Item(0))
      cboInstitucion.Tag = cboInstitucion.Text
    Else
      For Each a As AnioLectivo In lA
        If a.Estado = AnioLectivo.EstadoPeriodo.Abierto Then
          cboAnio.SelectedItem = a
          CargarPeriodos(a)
          cboInstitucion.Tag = cboInstitucion.Text
          Exit Sub
        End If
      Next
      cboAnio.Focus()
    End If
  End Sub

  Private Sub CargarPeriodos(ByVal wAnio As AnioLectivo)
    Dim rnA As New RNAnioLectivo
    Dim lPer As List(Of PeriodoAcademico)

    lPer = rnA.ListarPeriodos(wAnio)
    cboAnio.Tag = cboAnio.Text
    If lPer.Count > 0 Then
      cboPeriodo.DisplayMember = "Nombre"
      cboPeriodo.ValueMember = "Codigo"
      cboPeriodo.DataSource = lPer

      If lPer.Count = 1 Then
        cboPeriodo.Focus()
      Else
        For Each per As PeriodoAcademico In lPer
          If per.Cerrado = False Then
            cboPeriodo.SelectedValue = per.Codigo
            Exit For
          End If
        Next
      End If
    Else
      cboPeriodo.DataSource = Nothing
      cboPeriodo.SelectedIndex = -1
    End If
  End Sub

  Private Sub cboPeriodo_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriodo.Enter
    If cboAnio.SelectedIndex > -1 Then
      If cboAnio.Tag.ToString <> cboAnio.Text Then
        CargarPeriodos(DirectCast(cboAnio.SelectedItem, AnioLectivo))
        cboAnio.Tag = cboAnio.Text
      End If
    ElseIf cboAnio.Items.Count > 0 Then
      MessageBox.Show("Debe seleccionar el anio lectivo", "Periodo actual", MessageBoxButtons.OK, MessageBoxIcon.Information)
      cboPeriodo.DataSource = Nothing
      cboPeriodo.SelectedIndex = -1
      cboAnio.Focus()
    End If
  End Sub

  Private Sub frmPeriodoActual_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    If cboInstitucion.SelectedIndex = -1 Then
      cboInstitucion.Focus()
    ElseIf cboAnio.SelectedIndex = -1 Then
      cboAnio.Focus()
    ElseIf cboPeriodo.SelectedIndex = -1 Then
      cboPeriodo.Focus()
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

  Private Sub cboAnio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnio.SelectedIndexChanged
    Me.cboPeriodo.SelectedIndex = -1
  End Sub

End Class