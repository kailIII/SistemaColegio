Public Class frmGestionBeneficioAlumno

  Private Beneficios As List(Of Beneficio)
  Private Alumno As Alumno

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim rb As RNBeneficio

    Me.dgvBeneficios.AutoGenerateColumns = False
    If Alumno IsNot Nothing And Me.cboAnio.SelectedIndex > -1 Then
      rb = New RNBeneficio
      Me.Beneficios = rb.ListarAlumno(DirectCast(Me.cboAnio.SelectedItem, AnioLectivo), Alumno)

      If Me.Beneficios.Count > 0 Then
        Me.dgvBeneficios.DataSource = Me.Beneficios
      Else
        MessageBox.Show("No se encontraron beneficios registrados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
    Else
      Me.dgvBeneficios.DataSource = Nothing
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
    Me.Dispose()
  End Sub

  Public Sub Presentar(ByVal wAlumno As Alumno)
    Me.cargarMotivos()
    Me.Alumno = wAlumno
    If Me.Alumno IsNot Nothing Then
      Me.txtNombre.Text = Me.Alumno.NombreCompleto
      Me.btnListar_Click(Nothing, Nothing)
    End If
    Me.ShowDialog()
  End Sub

  Private Sub frmGestionarBeneficioAlumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.CargarAnios(modPrincipal.mOInstitucion)
    Me.cboAnio.SelectedValue = mOAnioActual.Anio
  End Sub

  Private Sub CargarAnios(ByVal wInst As Institucion)
    Dim rnA As New RNAnioLectivo
    Dim lA As List(Of AnioLectivo)

    lA = rnA.Listar(wInst)
    cboAnio.DisplayMember = "Anio"
    cboAnio.ValueMember = "Anio"
    cboAnio.DataSource = lA
  End Sub

  Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click
    Dim rnb As RNBeneficio

    If Me.Alumno IsNot Nothing Then
      rnb = New RNBeneficio

      Try
        rnb.Actualizar(Me.Beneficios)
        MessageBox.Show("Los datos se actualizaron exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        rnb = Nothing
      End Try
    End If
  End Sub

  Private Sub cargarMotivos()
    Dim rn As New RNBeneficio
    Dim Motivos As List(Of String)

    Motivos = rn.ListarMotivos
    rn = Nothing

    With DirectCast(Me.dgvBeneficios.Columns.Item("cdMotivo"), DataGridViewComboBoxColumn)
      .DataSource = Motivos
    End With
  End Sub

  Private Sub cboAnio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnio.SelectedIndexChanged
    Me.dgvBeneficios.DataSource = Nothing
  End Sub

End Class