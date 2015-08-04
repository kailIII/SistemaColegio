Public Class frmAsignarObligaciones

  Private AlumnosSel As New List(Of AlumnoSeleccionar)
  Private ServiciosPagar As New List(Of ProgramacionPago)

  Private Shared frm As frmAsignarObligaciones

  Private Sub New()
    ' This call is required by the designer.
    InitializeComponent()
  End Sub

  Public Shared Function Crear() As frmAsignarObligaciones
    If frmAsignarObligaciones.frm Is Nothing Then
      frmAsignarObligaciones.frm = New frmAsignarObligaciones
    End If

    Return frmAsignarObligaciones.frm
  End Function

  Private Sub frmAsignarObligaciones_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmAsignarObligaciones.frm = Nothing
    Me.Dispose()
  End Sub

  Public Sub Registrar()
    Me.ListarComboAnios()
    Me.cboAnio.SelectedValue = mOAnioActual.Anio
    Me.Show()
    Me.WindowState = FormWindowState.Maximized
  End Sub

  Private Sub ListarComboAnios()
    Dim rnAnio As New RNAnioLectivo
    Dim ls As List(Of AnioLectivo)

    ls = rnAnio.ListarActivos(mOInstitucion)
    If ls.Count > 0 Then
      Me.cboAnio.DisplayMember = "Anio"
      Me.cboAnio.ValueMember = "Anio"
      Me.cboAnio.DataSource = ls
    Else
      Me.Close()
      MessageBox.Show("No se ha registrado años académicos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub ListarComboGrados()
    Dim objS As RNSeccion = New RNSeccion
    Dim ls As List(Of Seccion)

    ls = objS.LeerNivelNumSec(New Seccion(DirectCast(cboAnio.SelectedItem, AnioLectivo), Nothing, "A"c))
    If ls.Count > 0 Then
      Me.cboSeccion.DisplayMember = "NivelNumeroLetra"
      Me.cboSeccion.ValueMember = "NivelNumeroLetra"
      Me.cboSeccion.DataSource = ls
    Else
      Me.Close()
      MessageBox.Show("No se encontró seccciones registradas", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Close()
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim rnA As RNMatricula
    Dim alumnos As List(Of Matricula)

    Me.dgvAlumnos.DataSource = Nothing
    If cboSeccion.SelectedItem IsNot Nothing Then
      Me.chkSeleccionarTodos.Checked = True
      rnA = New RNMatricula
      alumnos = rnA.ListarAlumno(DirectCast(cboSeccion.SelectedItem, Seccion))
      Me.AlumnosSel.Clear()
      If alumnos.Count > 0 Then
        For Each m As Matricula In alumnos
          Me.AlumnosSel.Add(New AlumnoSeleccionar(m))
        Next
        Me.dgvAlumnos.AutoGenerateColumns = False
        Me.dgvAlumnos.DataSource = AlumnosSel
      End If
    Else
      MessageBox.Show("Debe seleccionar la sección", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub chkSeleccionarTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSeleccionarTodos.CheckedChanged
    Dim sel As Boolean = chkSeleccionarTodos.Checked

    If Me.AlumnosSel.Count > 0 Then
      dgvAlumnos.DataSource = Nothing
      For Each ap As AlumnoSeleccionar In AlumnosSel
        ap.Seleccionado = sel
      Next
      dgvAlumnos.AutoGenerateColumns = False
      dgvAlumnos.DataSource = AlumnosSel
    End If
  End Sub

  Private Sub cbServicio_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboServicio.Enter
    Dim rnSer As RNServicio
    Dim lser As List(Of Servicio)

    If cboEntidad.SelectedIndex > -1 Then
      rnSer = New RNServicio
      lser = rnSer.ListarServicio(New Servicio("", cboEntidad.Text.Substring(0, 1), True))
      rnSer = Nothing
      cboServicio.DataSource = lser
      cboServicio.DisplayMember = "NombreConNivel"
      cboServicio.ValueMember = "codigo"
      cboServicio.SelectedIndex = -1
    Else
      MessageBox.Show("Debe seleccionar una entidad", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub cbServicio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboServicio.SelectedIndexChanged
    Dim ser As Servicio

    ser = DirectCast(cboServicio.SelectedItem, Servicio)
    If ser IsNot Nothing Then
      txtDescripcion.Text = ser.Nombre
      txtMonto.Text = ser.Monto.ToString
    Else
      txtDescripcion.Text = ""
      txtMonto.Text = ""
    End If
  End Sub

  Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
    Dim pp As ProgramacionPago

    Me.dgvObligaciones.DataSource = Nothing
    'If VerificarDatosCobro() Then
    pp = New ProgramacionPago
    pp.Entidad = cboEntidad.Text.Substring(0, 1)
    pp.Descripcion = txtDescripcion.Text
    pp.Vencimiento = dtFecha.Value
    pp.Monto = CDbl(txtMonto.Text)
    pp.Servicio = DirectCast(cboServicio.SelectedItem, Servicio)

    ServiciosPagar.Add(pp)
    'End If
    Me.dgvObligaciones.AutoGenerateColumns = False
    Me.dgvObligaciones.DataSource = ServiciosPagar
  End Sub

  'Private Function VerificarDatosCobro() As Boolean
  '  Dim e As New System.ComponentModel.CancelEventArgs

  '  e.Cancel = False
  '  cbServicio_Validating(Nothing, e)
  '  If e.Cancel = True Then
  '    Return False
  '  End If
  '  txtDescripcion_Validating(Nothing, e)
  '  If e.Cancel = True Then
  '    Return False
  '  End If
  '  txtMonto_Validating(Nothing, e)
  '  If e.Cancel = True Then
  '    Return False
  '  End If

  '  Return True
  'End Function

  Private Sub cbServicio_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboServicio.Validating
    If cboServicio.SelectedIndex > -1 Then
      errAsignar.SetError(cboServicio, "")
    Else
      errAsignar.SetError(cboServicio, "Debe selecconar un servicio")
      e.Cancel = True
    End If
  End Sub

  Private Sub txtDescripcion_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDescripcion.Validating
    If txtDescripcion.Text.Length > 0 Then
      errAsignar.SetError(txtDescripcion, "")
    Else
      errAsignar.SetError(txtDescripcion, "Debe describir el cobro a realizar")
      e.Cancel = True
    End If
  End Sub

  Private Sub txtMonto_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMonto.Validating
    If txtDescripcion.Text.Length > 0 Then
      errAsignar.SetError(txtMonto, "")
    Else
      errAsignar.SetError(txtMonto, "Debe indicar el monto a cobrar")
      e.Cancel = True
    End If
  End Sub

  Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
    Dim pr As ProgramacionPago

    If dgvObligaciones.CurrentRow IsNot Nothing Then
      pr = DirectCast(dgvObligaciones.CurrentRow.DataBoundItem, ProgramacionPago)
      If pr IsNot Nothing Then
        ServiciosPagar.Remove(pr)
      Else
        MessageBox.Show("Debe seleccionar un servicio", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
    End If
    dgvObligaciones.DataSource = Nothing
    dgvObligaciones.DataSource = ServiciosPagar
  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    Dim rnProg As RNProgramacionPago
    Dim lAl As New List(Of Matricula)

    If ServiciosPagar.Count > 0 Then
      For Each pp As ProgramacionPago In Me.ServiciosPagar
        If pp.Servicio.NivelAcademico Is Nothing Then
          pp.Servicio.NivelAcademico = DirectCast(Me.cboSeccion.SelectedItem, Seccion).Grado.Nivel
        End If
      Next

      For Each mat As AlumnoSeleccionar In AlumnosSel
        If mat.Seleccionado = True Then
          lAl.Add(mat.Matriculado)
        End If
      Next
      If lAl.Count > 0 Then
        rnProg = New RNProgramacionPago
        Try
          rnProg.Asignar(mOAnioActual, ServiciosPagar, lAl)
          MessageBox.Show("Proceso de asignación terminado exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
          MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
          rnProg = Nothing
        End Try

      Else
        MessageBox.Show("Debe seleccionar al menos un alumno", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
    Else
      MessageBox.Show("Debe indicar al menos un servicio", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub cboSeccion_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSeccion.Enter
    If cboAnio.SelectedItem IsNot Nothing Then
      Me.ListarComboGrados()
    Else
      cboSeccion.DataSource = Nothing
      cboSeccion.SelectedIndex = -1
    End If
  End Sub

  Private Sub frmAsignarObligaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.dgvAlumnos.DataSource = Nothing
  End Sub

End Class