Public Class frmAsignacionLibroGrado

  Private codigo As Integer = 0

  Private Shared frm As frmAsignacionLibroGrado

  Private Sub New()

    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()

    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
  End Sub

  Private Sub frmAsignacionLibroGrado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnModificar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
    txtAnio.Text = moAnioActual.Anio

    Me.CargarNiveles()
    Me.ListarLibros()
    Me.CargarDocentes()
    Me.Limpiar()
  End Sub

  Public Sub CargarNiveles()
    Dim ListNa As List(Of Nivel)
    Dim objNa As New RNNivel

    ListNa = objNa.Listar()
    cboNivel.DisplayMember = "nombre"
    cboNivel.ValueMember = "codigo"
    cboNivel.DataSource = ListNa
    ListNa = Nothing
  End Sub

  Public Sub CargarDocentes()
    Dim ListD As New List(Of Docente)
    Dim objDoc As New RNDocente

    ListD = objDoc.Listar
    Me.cboDocente.DisplayMember = "NombreCompleto"
    Me.cboDocente.ValueMember = "codigo"
    Me.cboDocente.DataSource = ListD
    Me.cboDocente.SelectedIndex = -1

    ListD = Nothing
  End Sub

  Private Sub ListarGrados(ByVal cbo As ComboBox)
    Dim obj As New RNGrado
    Dim lg As List(Of Grado)

    lg = obj.Listar(DirectCast(Me.cboNivel.SelectedItem, Nivel))
    If lg.Count > 0 Then
      cbo.DisplayMember = "Nombre"
      cbo.ValueMember = "Codigo"
      cbo.DataSource = lg
      cbo.SelectedIndex = -1
    End If
  End Sub

  Private Sub ListarLibros()
    Dim obj As New RNLibro
    Dim la As List(Of Libro)

    la = obj.ListarLibros("")

    If la.Count > 0 Then
      Me.cboLibro.DisplayMember = "Titulo"
      Me.cboLibro.ValueMember = "Codigo"
      Me.cboLibro.DataSource = la
    Else
      Me.cboLibro.DataSource = Nothing
    End If
  End Sub

  Public Sub PresentarLibros()
    Dim obj As New RNLibro
    Dim la As List(Of GradoLibro)

    If Me.cboGradoBuscar.SelectedIndex > -1 Then
      la = obj.ListarLibros_Grado(CType(Me.cboGradoBuscar.SelectedItem, Grado), modPrincipal.moAnioActual)
      obj = Nothing
      Me.dgvLibros.AutoGenerateColumns = False
      Me.dgvLibros.DataSource = la
    Else
      Me.dgvLibros.DataSource = Nothing
    End If
  End Sub

  Private Sub Limpiar()
    Me.codigo = 0
    Me.cboLibro.SelectedIndex = -1
    Me.cboResponsable.SelectedIndex = -1
    Me.cboDocente.SelectedIndex = -1
    Me.btnRegistrar.Text = "&Registrar"

    Me.chkVigencia.Visible = False
    Me.ErrLibro.SetError(cboLibro, "")
    Me.ErrLibro.SetError(cboGrado, "")
  End Sub

  Private Sub txtAnio_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAnio.Enter
    Me.cboGrado.Focus()
  End Sub

  Public Shared Sub Gestionar(ByVal wPadre As Form)
    If frmAsignacionLibroGrado.frm Is Nothing Then
      frmAsignacionLibroGrado.frm = New frmAsignacionLibroGrado
      frmAsignacionLibroGrado.frm.MdiParent = wPadre
      frmAsignacionLibroGrado.frm.Show()
      frmAsignacionLibroGrado.frm.WindowState = FormWindowState.Maximized
    Else
      frmAsignacionLibroGrado.frm.Activate()
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim obj As RNLibro = Nothing
    Dim gl As GradoLibro

    If Me.ValidateChildren Then
      Try
        gl = New GradoLibro(0, CInt(cboGrado.SelectedValue), CType(Me.cboLibro.SelectedItem, Libro), moAnioActual.Anio, True)
        gl.Docente = DirectCast(Me.cboDocente.SelectedItem, Docente)
        gl.Responsable = Me.cboResponsable.Text.Substring(0, 1)
        obj = New RNLibro
        If codigo = 0 Then
          obj.RegistrarGrado_Libro(gl)
          MessageBox.Show("Asignación registrada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          gl.Codigo = codigo
          gl.Vigencia = chkVigencia.Checked
          obj.ActualizarGrado_Libro(gl)
          MessageBox.Show("Asignación actualizada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Me.Limpiar()
        Me.btnListar.PerformClick()
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        obj = Nothing
        codigo = 0
      End Try
    End If
  End Sub

  Private Sub cboGrado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboGrado.Validating, cboResponsable.Validating
    If cboGrado.SelectedIndex = -1 Then
      e.Cancel = True
      ErrLibro.SetError(cboGrado, "Debe indicar el grado")
    Else
      ErrLibro.SetError(cboGrado, "")
    End If
  End Sub

  Private Sub cboLibro_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboLibro.Validating
    If cboLibro.SelectedIndex = -1 Then
      e.Cancel = True
      ErrLibro.SetError(cboLibro, "Debe indicar el libro")
    Else
      ErrLibro.SetError(cboLibro, "")
    End If
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Limpiar()
  End Sub

  Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click, dgvLibros.DoubleClick
    Dim L As GradoLibro = Nothing

    If dgvLibros.SelectedRows.Count > 0 Then
      L = CType(Me.dgvLibros.CurrentRow.DataBoundItem, GradoLibro)

      If L IsNot Nothing Then
        Me.codigo = L.Codigo
        Me.cboGrado.SelectedValue = L.CodigoGrado
        Me.cboLibro.SelectedValue = L.Libro.Codigo
        Me.cboResponsable.SelectedIndex = -1
        If L.Responsable = "D" Then
          Me.cboResponsable.SelectedIndex = 0
          If L.Docente IsNot Nothing Then
            Me.cboDocente.SelectedValue = L.Docente.Codigo
          Else
            Me.cboDocente.SelectedIndex = -1
          End If
        Else
          Me.cboResponsable.SelectedIndex = 1
          Me.cboDocente.SelectedIndex = -1
        End If

        Me.chkVigencia.Checked = L.Vigencia
        Me.chkVigencia.Visible = True
        Me.btnRegistrar.Text = "&Actualizar"
      Else
        MessageBox.Show("No se pudo encontrar el libro solicitado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
      End If
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Me.PresentarLibros()
  End Sub

  Private Sub frmAsignacionLibroGrado_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmAsignacionLibroGrado.frm = Nothing
  End Sub

  Private Sub cboDocente_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboDocente.Validating
    If Me.cboResponsable.SelectedIndex = 0 Then
      If Me.cboDocente.SelectedIndex = -1 Then
        Me.ErrLibro.SetError(Me.cboDocente, "Debe seleccionar el docente responsable")
        e.Cancel = True
      Else
        Me.ErrLibro.SetError(Me.cboDocente, "")
      End If
    Else
      Me.ErrLibro.SetError(Me.cboDocente, "")
    End If
  End Sub

  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNivel.SelectedIndexChanged
    If Me.cboNivel.SelectedIndex > -1 Then
      Me.ListarGrados(Me.cboGrado)
      Me.ListarGrados(Me.cboGradoBuscar)
    Else
      Me.cboGrado.DataSource = Nothing
      Me.cboGradoBuscar.DataSource = Nothing
    End If
  End Sub

  Private Sub cboResponsable_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboResponsable.SelectedIndexChanged
    If Me.cboResponsable.SelectedIndex = 0 Then
      Me.lblDocente.Enabled = True
      Me.cboDocente.Enabled = True
    Else
      Me.lblDocente.Enabled = False
      Me.cboDocente.Enabled = False
    End If
  End Sub

    
End Class