Public Class frmGestionDocenteArea

  Private Shared frm As frmGestionDocenteArea
  'Tania Incio    
  Private ResponsableInv As List(Of ResponsableInvestigacion)
  Private docente As Docente
  Private modificar As Boolean
  Private seccion As Seccion
  Private codigoR As New Integer
  Private codigoD As New Integer
  Private codigoA As New Integer

  Public WriteOnly Property DialogoGuardar As SaveFileDialog
    Set(ByVal value As SaveFileDialog)
      'Me.mDialogoGuardar = value
    End Set
  End Property

  Private Sub New()
    ' This call is required by the designer.
    InitializeComponent()
  End Sub

  Public Shared Sub Crear(ByVal pPadre As Form)

    If frmGestionDocenteArea.frm Is Nothing Then
      frmGestionDocenteArea.frm = New frmGestionDocenteArea
      frmGestionDocenteArea.frm.MdiParent = pPadre
      frmGestionDocenteArea.frm.Show()
      frmGestionDocenteArea.frm.WindowState = FormWindowState.Maximized
    Else
      frmGestionDocenteArea.frm.Activate()
    End If
  End Sub


  Private Sub frmGestionDocenteArea_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmGestionDocenteArea.frm = Nothing
  End Sub

  Private Sub PresentarSecciones()
    Dim ListSec As List(Of Seccion)
    Dim objS As New RNSeccion

    If Me.cboNivel.SelectedIndex > -1 Then
            ListSec = objS.ListarSeccionInvestigacion(moAnioActual, CType(cboNivel.SelectedItem, Nivel), mOPeriodoActual.Codigo)
      If ListSec.Count > 0 Then
        Me.cboSeccion.DisplayMember = "NumeroLetra"
        Me.cboSeccion.ValueMember = "NumeroLetra"
        Me.cboSeccion.DataSource = ListSec
        Me.cboSeccion.SelectedIndex = -1

      End If
    Else
      Me.cboSeccion.DataSource = Nothing
      Me.cboSeccion.SelectedIndex = -1
    End If
  End Sub

  Public Sub PresentarNiveles()
    Dim ListNa As List(Of Nivel)
    Dim objNa As New RNNivel

    ListNa = objNa.Listar()    
    Me.cboNivel.DisplayMember = "Nombre"
    Me.cboNivel.ValueMember = "Codigo"
    Me.cboNivel.DataSource = ListNa
    ListNa = Nothing
    Me.cboNivel.SelectedIndex = -1
  End Sub


  Private Sub PresentarAreas()
    Dim ListSec As New List(Of AreaInvestigacion)
    Dim obj As New RNInvestigacion

    If Me.cboNivel.SelectedIndex > -1 Then
      ListSec = obj.ListarAreasInvestigacion(mOPeriodoActual.Codigo, DirectCast(Me.cboNivel.SelectedItem, Nivel).Codigo)
      Me.cboArea.DisplayMember = "nombre"
      cboArea.ValueMember = "nombre"
      If ListSec.Count > 0 Then
        cboArea.DataSource = ListSec
        Me.cboArea.SelectedIndex = -1
      Else
        cboArea.DataSource = Nothing
      End If
    Else
      Me.cboArea.DataSource = Nothing
      Me.cboArea.SelectedIndex = -1
    End If
    
  End Sub

  Private Sub cboSeccion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSeccion.SelectedIndexChanged
    Me.cboArea.Enabled = True
  End Sub

  Private Sub btnBuscarDocente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarDocente.Click
    Me.BuscarDocente()
  End Sub

  Private Sub BuscarDocente()
    Dim frm As New frmBuscarDocente
    Dim obj As RNDocente = Nothing
    docente = frm.Buscar()
    Me.txtDocente.Text = docente.NombreCompleto
    Me.codigoD = docente.Codigo
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim rn As RNInvestigacion = Nothing
    Dim rI As ResponsableInvestigacion = Nothing
    Dim aI As AreaInvestigacion = Nothing

    If Me.Validar() Then
      Dim objS = DirectCast(cboSeccion.SelectedItem, Seccion)
      If modificar = True Then
        objS = Me.seccion
      End If
      rn = New RNInvestigacion
      aI = New AreaInvestigacion(0, cboArea.Text, _
                                 New Grado(objS.Grado.Codigo), _
                                 New PeriodoAcademico(mOPeriodoActual.Codigo))

      rI = New ResponsableInvestigacion(docente, _
                                        New Seccion(objS.Grado.Codigo, moAnioActual.Anio, objS.Letra))
      Try

        If modificar = False Then
          rn.RegistrarAreaResponsableInvestigacion(aI, rI)
          Me.Limpiar()
          MessageBox.Show("Asignación registrada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

          rn.ModificarAreaResponsableInvestigacion(aI, Me.codigoD, Me.codigoR, Me.codigoA, objS.Grado.Codigo)
          MessageBox.Show("Actualización realizada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

          Me.modificar = False
          Me.btnRegistrar.Text = "&Registrar"

        End If

      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        Me.btnListar.PerformClick()
        rn = Nothing
        Me.Habilitar(False)
      End Try
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
    Me.Limpiar()
    Me.Habilitar(False)
  End Sub

  Private Sub Limpiar()
    Me.cboSeccion.SelectedIndex = -1
    Me.cboArea.SelectedIndex = -1
    Me.cboNivel.SelectedIndex = -1
    Me.txtDocente.Text = ""
    Me.txtSeccion.Text = ""
    Me.txtSeccion.Visible = False
    Me.cboSeccion.Visible = True
    Me.cboNivel.Enabled = True
    Me.cboSeccion.Enabled = True
  End Sub

  Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click

    If Me.dgvRespInvestigacion.SelectedRows.Count > 0 Then
      With CType(Me.dgvRespInvestigacion.SelectedRows.Item(0).DataBoundItem, ResponsableInvestigacion)
        Me.Habilitar(True)
        Me.seccion = New Seccion(.Seccion.Anio, .Seccion.Grado, .Seccion.Letra)
        Me.codigoR = .Codigo
        Me.codigoD = .Docente.Codigo
        Me.codigoA = .AreaInvestigacion.Codigo
        Me.txtDocente.Text = .Docente.NombreCompleto
        Me.cboNivel.SelectedValue = .Seccion.Grado.CodigoNivel

        Me.cboArea.SelectedValue = .AreaInvestigacion.Nombre
        Me.cboSeccion.Visible = False
        Me.txtSeccion.Enabled = False
        Me.cboNivel.Enabled = False
        Me.txtSeccion.Text = .Seccion.NumeroLetra
        Me.cboSeccion.Enabled = False
        Me.txtSeccion.Visible = True
        Me.btnRegistrar.Text = "&Actualizar"
        Me.modificar = True

        Me.cboArea.Focus()
      End With
    End If

  End Sub

  Private Sub frmGestionDocenteArea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.txtSeccion.Visible = False
    Me.Limpiar()
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btncancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnEditar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Editar.jpg")

    Me.PresentarNiveles()
    frmGestionDocenteArea.frm.WindowState = FormWindowState.Maximized
  End Sub

  Private Function Validar() As Boolean
    Dim o = Me.cboSeccion.SelectedValue
    If Me.modificar = False Then
      If Me.cboSeccion.SelectedIndex > -1 Then
      Else
        MessageBox.Show("Debe elegir una Sección", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return False
      End If
    End If

    If Me.cboArea.Text <> "" Then
      If Me.txtDocente.Text <> "" Then
        Return True
      Else
        MessageBox.Show("Debe elegir un Docente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return False
      End If
    Else
      MessageBox.Show("Debe elegir un Área", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Return False
    End If

  End Function

  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNivel.SelectedIndexChanged
    If Me.cboNivel.SelectedIndex > -1 Then
      Me.PresentarSecciones()
      Me.PresentarAreas()
    End If

  End Sub

  Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
    If Me.dgvRespInvestigacion.SelectedRows.Count > 0 Then
      Dim codigoRI As Integer
      Dim rnI As New RNInvestigacion
      With CType(Me.dgvRespInvestigacion.SelectedRows.Item(0).DataBoundItem, ResponsableInvestigacion)
        codigoRI = .Codigo        
      End With

      Try
        rnI.ModificarResponsableInvestigacion(codigoRI)
        Me.cboArea.Focus()
        MessageBox.Show("Eliminación exitosa", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.btnListar.PerformClick()
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Finally
        rnI = Nothing
      End Try
    End If
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim rn As New RNInvestigacion
    Dim lista As New List(Of ResponsableInvestigacion)
    lista = rn.ListarAreaInvestigacionXSeccion(mOPeriodoActual.Codigo)
    rn = Nothing
    Me.dgvRespInvestigacion.AutoGenerateColumns = False
    Me.dgvRespInvestigacion.DataSource = lista
    Me.Limpiar()
    Me.btnEditar.Enabled = True
    Me.btnAnular.Enabled = True
  End Sub

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    Me.Habilitar(True)
    Me.modificar = False
    Me.btnRegistrar.Text = "&Registrar"

  End Sub

  Private Sub Habilitar(ByVal wboolean As Boolean)
    Me.btnRegistrar.Enabled = wboolean
    Me.btncancelar.Enabled = wboolean
    Me.btnBuscarDocente.Enabled = wboolean
    Me.cboNivel.Enabled = wboolean
    Me.cboArea.Enabled = wboolean
    Me.cboSeccion.Enabled = wboolean
    Me.lblNivel.Enabled = wboolean
    Me.lblSeccion.Enabled = wboolean
    Me.lblArea.Enabled = wboolean
    Me.lblDocente.Enabled = wboolean
    Me.gbRespInvestigacion.Enabled = wboolean

    wboolean = Not wboolean    
    Me.btnListar.Enabled = wboolean
    Me.gbListaInv.Enabled = wboolean
    Me.btnNuevo.Enabled = wboolean
    Me.btnEditar.Enabled = wboolean
    Me.btnAnular.Enabled = wboolean
    Me.dgvRespInvestigacion.Enabled = wboolean
  End Sub
End Class