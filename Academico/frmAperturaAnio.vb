
Public Class frmAperturaAnio

  Private numperiodo As Integer
  Private Siglas(3) As String
  Private contador As Integer = 0

  Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    Dim rnAnio As New RNAnioLectivo
    Dim lp As List(Of PeriodoAcademico)

    If Me.ValidateChildren Then
      rnAnio = New RNAnioLectivo

      Try
        ValidarSiglas()
        lp = New List(Of PeriodoAcademico)
        For i As Integer = 0 To dgvPeriodos.Rows.Count - 1
          lp.Add(New PeriodoAcademico(CInt(i + 1), CDate(Me.dgvPeriodos.Rows(i).Cells("cdFechaInicio").Value), CDate(Me.dgvPeriodos.Rows(i).Cells("cdFechaFinal").Value), CBool(1), CStr(Me.txtAnio.Text()), CStr(Me.dgvPeriodos.Rows(i).Cells("cdNombre").Value), Siglas(i).ToString))
        Next
        rnAnio.Registrar(New AnioLectivo(CStr(Me.txtAnio.Text()), CDate(Me.dtpFechaInicio.Value), CDate(Me.dtpFechaFinal.Value), CBool(1), "".ToString, mOInstitucion), lp)
        moAnioActual = New AnioLectivo(CStr(Me.txtAnio.Text), CDate(Me.dtpFechaInicio.Value), CDate(Me.dtpFechaFinal.Value), CBool(1), "".ToString, mOInstitucion)
        MessageBox.Show("Registrado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        rnAnio = Nothing
      End Try
    End If

  End Sub

  Private Sub dtpFechaInicio_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpFechaInicio.Validating
    ValidardtpFechaAnio(e, Me.dtpFechaInicio, Me.dtpFechaFinal, "fecha de inicio debe ser menor que fecha final")
  End Sub

  Private Sub dtpFechaInicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaInicio.ValueChanged
    Me.txtAnio.Text = dtpFechaInicio.Value.Year.ToString
    Me.dtpFechaInicio2.Value = Me.dtpFechaInicio.Value
  End Sub

  Private Sub dtpFechaFinal_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaFinal.ValueChanged
    Me.txtAnio.Text = dtpFechaFinal.Value.Year.ToString
  End Sub

  Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
    If DateAndTime.DateDiff(DateInterval.Day, dtpFechaInicio2.Value, dtpFechaFinal2.Value) >= 0 Then
      If cboNombre.Items.Count() - 1 >= dgvPeriodos.RowCount Then
        If DateAndTime.DateDiff(DateInterval.DayOfYear, dtpFechaFinal.Value, dtpFechaFinal2.Value) <= 0 Then
          errValida.SetError(dtpFechaFinal2, "")
          Me.dgvPeriodos.Rows.Add()
          numperiodo = dgvPeriodos.RowCount

          Me.cboNombre.SelectedIndex = numperiodo - 1
          With Me.dgvPeriodos
            .Rows(numperiodo - 1).Cells("cdNombre").Value = Me.cboNombre.Text
            .Rows(numperiodo - 1).Cells("cdFechaInicio").Value = Me.dtpFechaInicio2.Value
            .Rows(numperiodo - 1).Cells("cdFechaFinal").Value = Me.dtpFechaFinal2.Value
            contador += 1
          End With
          Me.dtpFechaInicio2.Value = Me.dtpFechaFinal2.Value.AddDays(+1)
          Me.dtpFechaFinal2.Value = Me.dtpFechaInicio2.Value.AddDays(+3)
          If Me.cboNombre.SelectedIndex < Me.cboNombre.Items.Count - 1 Then
            Me.cboNombre.SelectedIndex += 1
          End If
          Me.dtpFechaFinal2.Focus()
          If contador = Me.cboNombre.Items.Count Then
            Me.btnGuardar.Enabled = True
            contador = 0
          Else
            Me.btnGuardar.Enabled = False
          End If
        Else
          MessageBox.Show("La fecha final debe ser menor o igual que la fecha final del año lectivo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

          btnGuardar.Focus()
        End If
      Else
        MessageBox.Show("No puede agregar mas periodos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
    Else
      errValida.SetError(dtpFechaFinal2, "La fecha final debe ser mayor que la fecha de inicio")
      dtpFechaFinal2.Focus()
    End If

  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Close()
  End Sub

  Private Sub txtAnio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnio.KeyPress
    If Not (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) And Not (Asc(e.KeyChar) = 8) Then
      e.Handled = True
    End If
  End Sub

  Private Sub txtAnio_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAnio.Validating
    ValidarText(e, Me.txtAnio, "Debe indicar el año")
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
      Me.dgvPeriodos.Rows.RemoveAt(dgvPeriodos.CurrentRow.Index)
      contador = Me.cboNombre.Items.Count - 1
      Me.btnGuardar.Enabled = False
    Else
      MessageBox.Show("No hay Datos para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  'Private Sub dtpFechaInicio2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpFechaInicio2.Validating
  '  ValidardtpFechaPeriodo1(e, Me.dtpFechaInicio, Me.dtpFechaFinal, Me.dtpFechaInicio2, "Fecha no se encuentra en el año lectivo")
  'End Sub

  'Private Sub dtpFechaFinal2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpFechaFinal2.Validating
  '  ValidardtpFechaPeriodo2(e, Me.dtpFechaInicio2, Me.dtpFechaFinal, Me.dtpFechaFinal2, "Fecha no se encuentra en el año lectivo")
  'End Sub

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
    Me.cboNombre.SelectedIndex = 0
    Me.txtAnio.Text = CStr(Now.Year)
    Me.btnGuardar.Enabled = False
    If moAnioActual IsNot Nothing Then
      Me.dtpFechaInicio.Value = moAnioActual.fechaI.AddYears(1)
      Me.dtpFechaFinal.Value = moAnioActual.fechaF.AddYears(1)
    Else
      Me.dtpFechaInicio.Value = New Date(DateAndTime.Today.Year, 3, 1)
      Me.dtpFechaFinal.Value = New Date(DateAndTime.Today.Year, 12, 20)
    End If
    MostrarImagenes()
  End Sub

  Public Sub MostrarImagenes()
    Me.btnGuardar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
  End Sub

End Class
