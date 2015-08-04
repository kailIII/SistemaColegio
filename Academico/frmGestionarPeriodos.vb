
Public Class frmGestionarPeriodos

  Private Shared frm As frmGestionarPeriodos = Nothing

  Private periodos As New List(Of PeriodoAcademico)

  Private numperiodo As Integer
  Private Siglas(3) As String
  Private contador As Integer = 0

  Public Shared Function Crear(ByVal padre As Form) As frmGestionarPeriodos
    If frm Is Nothing Then
      frm = New frmGestionarPeriodos

      frm.MdiParent = padre
    End If

    Return frmGestionarPeriodos.frm
  End Function

  Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    Dim rnAnio As RNAnioLectivo

    If Me.ValidateChildren Then
      rnAnio = New RNAnioLectivo

      Try
        Me.ValidarSiglas()
        rnAnio.RegistrarPeriodos(Me.periodos)

        MessageBox.Show("Registrado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        rnAnio = Nothing
      End Try
    End If
  End Sub

  Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
    If DateAndTime.DateDiff(DateInterval.Day, dtpFechaIniPeriodo.Value, dtpFechaFinPeriodo.Value) >= 0 Then
      If cboNombre.Items.Count() - 1 >= dgvPeriodos.RowCount Then
        errValida.SetError(dtpFechaFinPeriodo, "")
        Me.dgvPeriodos.DataSource = Nothing
        With Me.dgvPeriodos
          Me.periodos.Add(New PeriodoAcademico() With {.Nombre = Me.cboNombre.Text,
                                                        .fechaIni = Me.dtpFechaIniPeriodo.Value,
                                                        .fechaFin = Me.dtpFechaFinPeriodo.Value,
                                                       .Anio = Me.cboAnio.Text,
                                                       .Siglas = Me.txtSiglas.Text,
                                                       .vigencia = True})
          contador += 1
        End With
        Me.dgvPeriodos.AutoGenerateColumns = False
        Me.dgvPeriodos.DataSource = Me.periodos

        numperiodo = Me.periodos.Count
        Me.cboNombre.SelectedIndex = numperiodo - 1
        Me.dtpFechaIniPeriodo.Value = Me.dtpFechaFinPeriodo.Value.AddDays(+1)
        Me.dtpFechaFinPeriodo.Value = Me.dtpFechaIniPeriodo.Value.AddDays(+3)
        If Me.cboNombre.SelectedIndex < Me.cboNombre.Items.Count - 1 Then
          Me.cboNombre.SelectedIndex += 1
        End If
        Me.dtpFechaFinPeriodo.Focus()
        If contador = Me.cboNombre.Items.Count Then
          Me.btnGuardar.Enabled = True
          contador = 0
        Else
          Me.btnGuardar.Enabled = False
        End If
      Else
        MessageBox.Show("No puede agregar mas periodos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
    Else
      errValida.SetError(dtpFechaFinPeriodo, "La fecha final debe ser mayor que la fecha de inicio")
      dtpFechaFinPeriodo.Focus()
    End If
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Close()
  End Sub

  Private Sub txtAnio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    If Not (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) And Not (Asc(e.KeyChar) = 8) Then
      e.Handled = True
    End If
  End Sub

  Private Sub ValidarText(ByVal e As System.ComponentModel.CancelEventArgs, ByVal cadena As TextBox, ByVal msj As String)
    If cadena.Text.Length = 0 Then
      e.Cancel = True
      errValida.SetError(cadena, msj)
    Else
      errValida.SetError(cadena, "")
    End If
  End Sub

  Private Sub ValidarCombo(ByVal e As System.ComponentModel.CancelEventArgs, ByVal opcion As ComboBox, ByVal msj As String)
    If opcion.SelectedIndex = -1 Then
      e.Cancel = True
      errValida.SetError(opcion, msj)
    Else
      errValida.SetError(opcion, "")
    End If
  End Sub

  Private Sub ValidardtpFechaAnio(ByVal e As System.ComponentModel.CancelEventArgs, ByVal cadena1 As DateTimePicker, ByVal cadena2 As DateTimePicker, ByVal msj As String)

    If cadena1.Value < cadena2.Value Then
      errValida.SetError(cadena1, "")
    Else
      e.Cancel = True
      errValida.SetError(cadena1, msj)
    End If
  End Sub

  Private Sub ValidardtpFechaPeriodo1(ByVal e As System.ComponentModel.CancelEventArgs, ByVal cadena1 As DateTimePicker, ByVal cadena2 As DateTimePicker, ByVal cadena3 As DateTimePicker, ByVal msj As String)

    If DateAndTime.DateDiff(DateInterval.Day, cadena1.Value, cadena3.Value) <= 0 And DateAndTime.DateDiff(DateInterval.Day, cadena3.Value, cadena2.Value) <= 0 Then
      errValida.SetError(cadena3, "")
    Else
      e.Cancel = True
      errValida.SetError(cadena3, msj)
    End If
  End Sub

  Private Sub ValidardtpFechaPeriodo2(ByVal e As System.ComponentModel.CancelEventArgs, ByVal cadena3 As DateTimePicker, ByVal cadena2 As DateTimePicker, ByVal cadena4 As DateTimePicker, ByVal msj As String)

    If cadena3.Value < cadena4.Value And cadena4.Value <= cadena2.Value Then
      errValida.SetError(cadena4, "")
    Else
      e.Cancel = True
      errValida.SetError(cadena4, msj)
    End If
  End Sub

  Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

    If dgvPeriodos.Rows.Count >= 1 Then
      Me.dgvPeriodos.DataSource = Nothing
      Me.periodos.Remove(DirectCast(Me.dgvPeriodos.CurrentRow.DataBoundItem, PeriodoAcademico))
      If Me.periodos.Count > 0 Then
        Me.dgvPeriodos.AutoGenerateColumns = False
        Me.dgvPeriodos.DataSource = Me.periodos
      End If
      contador = Me.cboNombre.Items.Count - 1
      Me.btnGuardar.Enabled = False
    Else
      MessageBox.Show("No hay datos para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub cboNombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboNombre.Validating
    ValidarCombo(e, Me.cboNombre, "Debe indicar el periodo")
  End Sub

  Private Sub optBimestre_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optBimestre.CheckedChanged
    Me.cboNombre.Items.Clear()

    Me.cboNombre.Items.Add("I   Bimestre")
    Me.cboNombre.Items.Add("II  Bimestre")
    Me.cboNombre.Items.Add("III Bimestre")
    Me.cboNombre.Items.Add("IV  Bimestre")

    cboNombre.SelectedIndex = 0
  End Sub

  Private Sub optTrimestre_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optTrimestre.CheckedChanged

    If Me.dgvPeriodos.Rows.Count <> 0 Then
      If MessageBox.Show("¿Necesitas eliminar los periodos ", "Eliminar Periodos", _
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        Me.dgvPeriodos.Rows.Clear()

      End If
    End If

    Me.cboNombre.Items.Clear()
    Me.cboNombre.Items.Add("I   Trimestre")
    Me.cboNombre.Items.Add("II  Trimestre")
    Me.cboNombre.Items.Add("III Trimestre")
    cboNombre.SelectedIndex = 0
  End Sub

  Private Sub ValidarSiglas()
    If optBimestre.Checked = True Then
      Siglas(0) = "I   B"
      Siglas(1) = "II  B"
      Siglas(2) = "III B"
      Siglas(3) = "IV  B"
    Else
      Siglas(0) = "I   T"
      Siglas(1) = "II  T"
      Siglas(2) = "III T"
    End If
  End Sub

  Private Sub frmAperturaAnio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.MostrarImagenes()
  End Sub

  Public Sub MostrarImagenes()
    Me.btnGuardar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
  End Sub

  Public Sub Presentar()
    Me.CargarAnios(modPrincipal.mOInstitucion)
    Me.Show()
  End Sub

  Private Sub CargarAnios(ByVal wInst As Institucion)
    Dim rnA As New RNAnioLectivo
    Dim lA As List(Of AnioLectivo)

    lA = rnA.ListarAbiertos(wInst)
    Me.cboAnio.DisplayMember = "Anio"
    Me.cboAnio.ValueMember = "Anio"
    Me.cboAnio.DataSource = lA
    Me.cboAnio.SelectedIndex = -1
  End Sub

  Private Sub frmGestionarPeriodos_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmGestionarPeriodos.frm = Nothing
  End Sub

End Class
