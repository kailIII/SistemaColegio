Public Class frmGestionPresentacion

  Private Codigo As Integer = 0

  Private Sub frmGestionPresentacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnActualizar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")


    dtpFechaIni.Value = Now
    dtpFechaFin.Value = Now.AddMonths(1)

    txtAnio.Text = moAnioActual.Anio

    'Limpiar()
    AgregarPresentacion()
    Habilitar()
    dgvPresentacion.Focus()
  End Sub

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub txtAnio_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAnio.Enter
    Me.nudPresentacion.Focus()
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Limpiar()

  End Sub
  Private Sub Limpiar()
    Me.Codigo = 0
    nudPresentacion.Enabled = True
    dtpFechaIni.Focus()
    ErrValida.SetError(dtpFechaFin, "")
    chkVigencia.Visible = False
    btnRegistrar.Text = "&Registar"
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim obj As RNPresentacion = Nothing

    Try
      obj = New RNPresentacion

      If DateAndTime.DateDiff(DateInterval.Day, dtpFechaIni.Value, dtpFechaFin.Value) > 0 Then
        If Codigo = 0 Then
          obj.Registrar(New Presentacion(0, CInt(nudPresentacion.Value), dtpFechaIni.Value, dtpFechaFin.Value, moAnioActual.Anio, True))
          MessageBox.Show("Presentación registrada con exito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          obj.Actualizar(New Presentacion(Codigo, CInt(nudPresentacion.Value), dtpFechaIni.Value, dtpFechaFin.Value, moAnioActual.Anio, chkVigencia.Checked))
          MessageBox.Show("Presentación actualizada con exito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        nudPresentacion.Value = nudPresentacion.Value + 1

        Limpiar()
        AgregarPresentacion()
        Habilitar()
      Else
        ErrValida.SetError(dtpFechaFin, "La fecha final debe ser mayor que la fecha de inicio")
        Me.dtpFechaFin.Focus()
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      obj = Nothing
      Codigo = 0
    End Try

  End Sub
  Public Sub AgregarPresentacion()
    Dim obj As New RNPresentacion
    Dim la As List(Of Presentacion)
    la = obj.ListarPresentaciones(moAnioActual.Anio)
    dgvPresentacion.AutoGenerateColumns = False
    dgvPresentacion.DataSource = la

  End Sub
  Public Sub Habilitar()
    If dgvPresentacion.RowCount = 0 Then
      Me.btnActualizar.Enabled = False
    Else
      Pintar()
      Me.btnActualizar.Enabled = True
      nudPresentacion.Value = dgvPresentacion.RowCount
    End If
  End Sub

  Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click, dgvPresentacion.DoubleClick
    Dim obj As RNPresentacion = Nothing
    Dim P As Presentacion = Nothing

    If dgvPresentacion.SelectedRows.Count > 0 Then
      With CType(dgvPresentacion.SelectedRows.Item(0).DataBoundItem, Presentacion)
        obj = New RNPresentacion
        P = obj.LeerPresentacion_Codigo(New Presentacion(.Codigo))
        If P IsNot Nothing Then
          Codigo = .Codigo
          nudPresentacion.Value = P.Numero
          nudPresentacion.Enabled = False
          dtpFechaIni.Value = P.Inicio
          dtpFechaFin.Value = P.Fin
          chkVigencia.Checked = P.Vigencia
          chkVigencia.Visible = True
          btnRegistrar.Text = "&Actualizar"
          dtpFechaFin.Focus()
        Else
          MessageBox.Show("No se pudo encontrar la Presentación solicitada", "Gestión de Presentaciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      End With
    End If
  End Sub
  Public Sub Pintar()
    For i As Integer = 0 To dgvPresentacion.Rows.Count - 1
      If CType(dgvPresentacion.Rows(i).DataBoundItem, Presentacion).NombreVigencia = "NO" Then
        Me.dgvPresentacion.Rows(i).DefaultCellStyle.BackColor = Color.OrangeRed
      Else
        Me.dgvPresentacion.Rows(i).DefaultCellStyle.BackColor = Color.GreenYellow
      End If
    Next
  End Sub

  Private Sub dgvPresentacion_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvPresentacion.CellClick, dgvPresentacion.SelectionChanged
    Me.dgvPresentacion.CurrentRow.DefaultCellStyle.SelectionBackColor = Me.dgvPresentacion.CurrentRow.DefaultCellStyle.BackColor

    If Me.dgvPresentacion.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.White Then
      Me.dgvPresentacion.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Blue
    Else
      Me.dgvPresentacion.CurrentRow.DefaultCellStyle.SelectionForeColor = Me.dgvPresentacion.CurrentRow.DefaultCellStyle.ForeColor
    End If
  End Sub
End Class