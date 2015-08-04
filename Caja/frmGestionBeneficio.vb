
Public Class frmGestionBeneficio

  Private AlumnosSel As New List(Of AlumnoSeleccionar)

  Private Shared frm As frmGestionBeneficio

  Private Sub New()
    Me.InitializeComponent()
  End Sub

  Public Shared Function Crear() As frmGestionBeneficio
    If frmGestionBeneficio.frm Is Nothing Then
      frmGestionBeneficio.frm = New frmGestionBeneficio
    End If

    Return frmGestionBeneficio.frm
  End Function

  Private Sub frmGestionServicios_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    frmGestionBeneficio.frm = Nothing
  End Sub

  Public Sub Presentar(ByVal Padre As Form)
    Me.MdiParent = Padre
    Me.Show()
    Me.WindowState = FormWindowState.Maximized
    Me.CargarAnios(modPrincipal.mOInstitucion)
    Me.cboAnio.SelectedValue = mOAnioActual.Anio
    Me.CargarDatos()
  End Sub

  Private Sub CargarDatos()
    Me.ListarDirectivos()
    Me.listarMotivos()
    Me.dtpFecha.Value = DateAndTime.Now
  End Sub

  Private Sub ListarMotivos()
    Dim rn As New RNBeneficio
    Dim Motivos As List(Of String)

    Motivos = rn.ListarMotivos
    rn = Nothing

    cboMotivo.DataSource = Motivos
    cboMotivo.Text = ""
  End Sub

  Private Sub ListarDirectivos()
    Dim rn As New RNAdministrativo
    Dim lista As List(Of Administrativo)

    lista = rn.Listar
    rn = Nothing

    cboAutorizado.DisplayMember = "NombreCompleto"
    cboAutorizado.ValueMember = "Codigo"
    cboAutorizado.DataSource = lista
    cboAutorizado.SelectedIndex = -1
  End Sub

  Private Sub ListarMeses()
    Dim rn As New RNProgramacionPago
    Dim meses As List(Of ProgramacionPago)
    Dim mesesP As List(Of ProgramacionPagoSeleccionar)

    meses = rn.ListarMeses(DirectCast(Me.cboAnio.SelectedItem, AnioLectivo))
    rn = Nothing
    If meses.Count > 0 Then
      mesesP = New List(Of ProgramacionPagoSeleccionar)
      For Each pp In meses
        mesesP.Add(New ProgramacionPagoSeleccionar(pp))
      Next
      Me.chkSeleccionarTodosProgramacion.Checked = True
      Me.dgvMeses.AutoGenerateColumns = False
      Me.dgvMeses.DataSource = mesesP
    Else
      MessageBox.Show("No se encontró programación de pagos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub ListarComboGrados()
    Dim rnAnio As New RNAnioLectivo
    Dim ls As List(Of Grado)

    ls = rnAnio.ListarGrados(DirectCast(Me.cboAnio.SelectedItem, AnioLectivo))
    rnAnio = Nothing
    If ls.Count > 0 Then
      Me.cboGrado.DisplayMember = "NivelGrado"
      Me.cboGrado.ValueMember = "NivelGrado"
      Me.cboGrado.DataSource = ls
    Else
      MessageBox.Show("No se encontraron grados registrados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Me.Close()
    End If
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim rnA As RNMatricula
    Dim alumnos As List(Of Matricula)
    Dim sec As Seccion

    dgvAlumnos.DataSource = Nothing
    If cboGrado.SelectedItem IsNot Nothing Then
      chkSeleccionarTodos.Checked = True
      sec = New Seccion
      sec.Anio = DirectCast(Me.cboAnio.SelectedItem, AnioLectivo)
      sec.Grado = DirectCast(cboGrado.SelectedItem, Grado)

      rnA = New RNMatricula
      alumnos = rnA.ListarAlumnosGrado(sec)
      AlumnosSel.Clear()
      AlumnosSel = Nothing
      AlumnosSel = New List(Of AlumnoSeleccionar)
      For Each m As Matricula In alumnos
        AlumnosSel.Add(New AlumnoSeleccionar(m))
      Next
      dgvAlumnos.AutoGenerateColumns = False
      dgvAlumnos.DataSource = Me.AlumnosSel
    Else
      MessageBox.Show("Debe seleccionar la sección", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub chkSeleccionarTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSeleccionarTodos.CheckedChanged
    Dim sel As Boolean = chkSeleccionarTodos.Checked

    dgvAlumnos.DataSource = Nothing
    For Each ap As AlumnoSeleccionar In Me.AlumnosSel
      ap.Seleccionado = sel
    Next
    dgvAlumnos.AutoGenerateColumns = False
    dgvAlumnos.DataSource = Me.AlumnosSel
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Close()
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim rn As RNBeneficio
    Dim lpp As New List(Of ProgramacionPago)
    Dim lAl As New List(Of Matricula)
    Dim ben As Beneficio

    If ObtenerDatos(lpp, lAl) = True Then
      rn = New RNBeneficio
      ben = New Beneficio
      ben.Autorizador = DirectCast(cboAutorizado.SelectedItem, Administrativo)
      ben.Administrativo = New Administrativo(mOUsuario.Persona.Codigo)
      ben.Fecha = Me.dtpFecha.Value
      ben.Motivo = cboMotivo.Text
      ben.Descuento = nudDescuento.Value
      Try
        rn.Registrar(ben, lpp, lAl)
        MessageBox.Show("El registro de los beneficios se realizó exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        rn = Nothing
        lpp = Nothing
        lAl = Nothing
      End Try

    End If
  End Sub

  Private Function ObtenerDatos(ByVal wProgramaciones As List(Of ProgramacionPago), ByVal wAlumnos As List(Of Matricula)) As Boolean
    Dim boHayAlumnos As Boolean = False
    Dim boHayMeses As Boolean = False

    For Each pp In DirectCast(Me.dgvMeses.DataSource, List(Of ProgramacionPagoSeleccionar))
      If pp.Seleccionado = True Then
        wProgramaciones.Add(pp.ProgramacionPago)
        boHayMeses = True
      End If
    Next
    If boHayMeses = False Then
      MessageBox.Show("Debe seleccionar en que mes se aplicará el beneficio", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If

    For Each al In DirectCast(Me.dgvAlumnos.DataSource, List(Of AlumnoSeleccionar))
      If al.Seleccionado = True Then
        wAlumnos.Add(al.Matriculado)
        boHayAlumnos = True
      End If
    Next
    If boHayAlumnos = False Then
      MessageBox.Show("Debe seleccionar a quienes se aplicará el beneficio", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If

    Return boHayAlumnos AndAlso boHayMeses
  End Function

  Private Sub chkSeleccionarTodosProgramacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSeleccionarTodosProgramacion.CheckedChanged
    Dim meses As List(Of ProgramacionPagoSeleccionar)

    meses = DirectCast(Me.dgvMeses.DataSource, List(Of ProgramacionPagoSeleccionar))
    If meses IsNot Nothing Then
      Me.dgvMeses.DataSource = Nothing
      For Each prog As ProgramacionPagoSeleccionar In meses
        prog.Seleccionado = Me.chkSeleccionarTodosProgramacion.Checked
      Next
      Me.dgvMeses.DataSource = meses
    End If
  End Sub

  Private Sub CargarAnios(ByVal wInst As Institucion)
    Dim rnA As New RNAnioLectivo
    Dim lA As List(Of AnioLectivo)

    lA = rnA.Listar(wInst)
    cboAnio.DisplayMember = "Anio"
    cboAnio.ValueMember = "Anio"
    cboAnio.DataSource = lA
  End Sub

  Private Sub cboAnio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnio.SelectedIndexChanged
    Me.dgvMeses.DataSource = Nothing
    Me.cboGrado.SelectedIndex = -1
    Me.cboGrado.DataSource = Nothing
  End Sub

  Private Sub cboGrado_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrado.Enter
    If Me.cboAnio.SelectedIndex > -1 Then
      Me.ListarComboGrados()
    End If
  End Sub

  Private Sub cboGrado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrado.SelectedIndexChanged
    Me.dgvAlumnos.DataSource = Nothing
  End Sub

  Private Sub btnVerProgramacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerProgramacion.Click
    Me.ListarMeses()
  End Sub

End Class