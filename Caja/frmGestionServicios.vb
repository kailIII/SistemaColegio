
Public Class frmGestionServicios

  Private nRoot As TreeNode
  Private nodo As TreeNode
  Private nodo1 As TreeNode
  Private A, A1() As String
  Private Codigo As Integer
  Private codigoEstado As Integer

  Private Shared frm As frmGestionServicios

  Private Sub New()
    Me.InitializeComponent()
  End Sub

  Public Shared Function Crear() As frmGestionServicios
    If frmGestionServicios.frm Is Nothing Then
      frmGestionServicios.frm = New frmGestionServicios
    End If

    Return frmGestionServicios.frm
  End Function

  Private Sub frmGestionServicios_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    frmGestionServicios.frm = Nothing
  End Sub

  Public Sub Presentar(ByVal Padre As Form)
    Me.MdiParent = Padre
    Me.Show()
    Me.WindowState = FormWindowState.Maximized
  End Sub

  Public Sub CargarCuentas()
    Dim ListCuenta As New List(Of CuentaContable)
    Dim objCuenta As New RNCuenta

    ListCuenta = objCuenta.Listar(True)
    Me.cboCuenta.DisplayMember = "NumeroNombreNivel"
    Me.cboCuenta.ValueMember = "Codigo"
    Me.cboCuenta.DataSource = ListCuenta
    Me.cboCuenta.SelectedIndex = -1
  End Sub

  Private Sub tveCuenta_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)
    A = e.Node.Text
    A1 = A.Split(CChar(" "))
  End Sub

  Public Sub cargarCboTipoServicio()
    Dim ListS As New List(Of TipoServicio)
    Dim objServ As New RNServicio
    ListS = objServ.ListarTipoServicio(New TipoServicio(0, "", True))
    If ListS.Count > 0 Then
      cbTipo.ValueMember = "codigo"
      cbTipo.DisplayMember = "nombre"
      cbTipo.DataSource = ListS
      cbTipo.SelectedIndex = 0
      ListS = Nothing
    End If
  End Sub

  Public Sub CargarFormulario()
    Me.txtNombre.CharacterCasing = CharacterCasing.Upper
    Me.txtDescripcion.CharacterCasing = CharacterCasing.Upper
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnModificar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnNuevo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\nuevo.png")
    Me.btnSeleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes/seleccionar.png")
    Me.cbentidad.SelectedIndex = 0
  End Sub

  Private Sub frmGestionServicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.CargarFormulario()
    Me.CargarNivel()
    Me.CargarCuentas()
    Me.cargarCboTipoServicio()
    Me.LlenarServicios()
    Me.dgvServicio.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    Me.dgvServicio.MultiSelect = False
    If Me.dgvServicio.RowCount > 0 Then
      Me.dgvServicio.Rows(0).Selected = True
    End If
    Me.dgvServicio.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    bloquearDesbloquear(False)
    Me.dgvServicio.ReadOnly = True
    Me.btnNuevo.Select()
  End Sub

  Public Sub LlenarServicios()
    Dim ls As List(Of Servicio)
    Dim objServ As New RNServicio

    ls = objServ.ListarServicioTodo()
    objServ = Nothing

    Me.dgvServicio.DataSource = Nothing
    Me.dgvServicio.AutoGenerateColumns = False
    Me.dgvServicio.DataSource = ls
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim objServ As New RNServicio
    Dim TipoServ As TipoServicio = Nothing
    Dim serv As Servicio
    Dim entidad As String
    Dim nivel As Nivel = Nothing

    Try
      entidad = Me.cbentidad.Text.Substring(0, 1)

      If Me.cboNivel.SelectedIndex > 0 Then
        nivel = DirectCast(cboNivel.SelectedItem, Nivel)
      End If
      TipoServ = CType(cbTipo.SelectedItem, TipoServicio)

      serv = New Servicio(0, Me.txtNombre.Text, CDbl(Me.txtMonto.Text), entidad, Me.txtDescripcion.Text, _
                                     chkVigencia.Checked, TipoServ, DirectCast(Me.cboCuenta.SelectedItem, CuentaContable), _
                                     nivel)
      serv.Caduca = Me.chkCaduca.Checked
      serv.PagoBanco = Me.chkPagoBanco.Checked
      If codigoEstado = 0 Then
        objServ.Registrar(serv)
        MessageBox.Show("Servicio registrado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Else
        serv.Codigo = DirectCast(dgvServicio.SelectedRows.Item(0).DataBoundItem, Servicio).Codigo
        objServ.Actualizar(serv)
        MessageBox.Show("Servicio actualizado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.btnRegistrar.Text = "&Registrar"
        codigoEstado = 0
      End If
      LlenarServicios()
      bloquearDesbloquear(False)
      limpiar()
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      objServ = Nothing
    End Try
  End Sub

  Private Sub limpiar()
    Me.txtDescripcion.Text = ""
    Me.txtMonto.Text = ""
    Me.txtNombre.Text = ""
    Me.cargarCboTipoServicio()
    Me.CargarCuentas()
    Me.chkCaduca.Checked = False
    Me.chkPagoBanco.Checked = False
    Me.cbentidad.SelectedIndex = 0
  End Sub

#Region "Validar"
  Private Sub ValidarText(ByVal e As System.ComponentModel.CancelEventArgs, ByVal cadena As System.Windows.Forms.TextBox, ByVal msj As String)
    If cadena.Text.Length = 0 Then
      e.Cancel = True
      errValida.SetError(cadena, msj)
    Else
      errValida.SetError(cadena, Nothing)
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
    If Char.IsDigit(e.KeyChar) = False AndAlso Char.IsNumber(e.KeyChar) = False AndAlso Char.IsPunctuation(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False Then
      e.Handled = True
    End If
  End Sub
#End Region

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
    limpiar()
    bloquearDesbloquear(False)
    Me.btnNuevo.Select()
  End Sub

  Private Function compararCuenta(ByVal nodo As String, ByVal codigo As String) As Boolean
    Dim resultado As String = ""
    For x = 0 To nodo.Length - 1
      If nodo.Chars(x) = " " Then
        Exit For
      Else
        resultado = resultado & nodo.Chars(x)
      End If
    Next
    If codigo = resultado Then
      'MsgBox(resultado)
      Return True
    End If
    Return False
  End Function

  Public Sub RecorrerTreeView(ByRef Nodos As TreeNodeCollection, ByVal codigo As String)
    Dim sw As Boolean
    For Each Nodo As TreeNode In Nodos
      If Nodo.IsExpanded = False Then
        sw = compararCuenta(Nodo.Text, codigo)
      Else
        sw = compararCuenta(Nodo.Text, codigo)
        RecorrerTreeView(Nodo.Nodes, codigo)
      End If
      If sw = True Then
        ' Nodo.Toggle()
        'Nodo.ForeColor = Color.Blue
        Nodo.EnsureVisible()
        Nodo.ForeColor = Color.Gray
        A = Nodo.Text
        A1 = A.Split(CChar(" "))
      End If
    Next
  End Sub

  Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Dim objRN As New RNServicio
    Dim serv As New Servicio
    If Me.dgvServicio.RowCount > 0 Then
      Try
        serv = CType(dgvServicio.SelectedRows.Item(0).DataBoundItem, Servicio)
        If CType(dgvServicio.SelectedRows.Item(0).DataBoundItem, Servicio).vigencia = False Then
          serv.vigencia = True
        Else
          serv.vigencia = False
        End If
        objRN.AnularServicio(serv)
        MessageBox.Show("El servicio a cambiado de estado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.dgvServicio.DataSource = Nothing
        Me.LlenarServicios()
      Catch ex As Exception
        MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    End If
  End Sub

  Private Sub dgvServicio_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvServicio.DoubleClick
    Me.btnSeleccionar_Click(Nothing, Nothing)
  End Sub

  Public Sub CargarNivel()
    Dim ListN As New List(Of Nivel)
    Dim objNivel As New RNNivel

    ListN = objNivel.Listar()
    ListN.Insert(0, New Nivel(0, "NINGUNO", ""))
    If ListN.Count > 0 Then
      cboNivel.DisplayMember = "nombre"
      cboNivel.ValueMember = "codigoNivel"
      cboNivel.DataSource = ListN
    End If
    Me.cboNivel.SelectedIndex = 0
  End Sub

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    Me.bloquearDesbloquear(True)
    Me.limpiar()
    Me.codigoEstado = 0
    Me.btnRegistrar.Text = "&Registrar"
    If Not Me.cboNivel.SelectedItem Is Nothing Then
      Me.cboNivel.SelectedIndex = 0
    End If
    If Not Me.cbTipo.SelectedItem Is Nothing Then
      Me.cbTipo.SelectedIndex = 0
    End If
    Me.txtNombre.Focus()
    Me.chkVigencia.Checked = True
  End Sub

  Public Sub bloquearDesbloquear(ByVal wEstado As Boolean)
    Me.gbServicio.Enabled = wEstado
    Me.gbBuscar.Enabled = Not wEstado

    If wEstado = True Then
      Me.txtNombre.Focus()
    Else
      Me.dgvServicio.Focus()
    End If
  End Sub

  Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
    If Me.dgvServicio.SelectedRows.Count > 0 Then
      Me.bloquearDesbloquear(True)
      Me.limpiar()
      With CType(dgvServicio.SelectedRows.Item(0).DataBoundItem, Servicio)
        Me.txtNombre.Text = .Nombre.Trim
        Me.txtDescripcion.Text = .Descripcion
        Me.txtMonto.Text = .Monto.ToString
        Me.cbTipo.Text = .TipoServicio.Nombre
        If .entidad = "I" Then
          Me.cbentidad.SelectedIndex = 0
        Else
          Me.cbentidad.SelectedIndex = 1
        End If
        If .NivelAcademico IsNot Nothing Then
          Me.cboNivel.Text = .NivelAcademico.Nombre
        Else
          Me.cboNivel.SelectedIndex = -1
        End If
        Me.cboCuenta.SelectedValue = .CuentaContable.Codigo
        Me.chkCaduca.Checked = .Caduca
        Me.chkPagoBanco.Checked = .PagoBanco
        Me.chkVigencia.Checked = .vigencia
      End With
      Me.txtNombre.Focus()
      Me.btnRegistrar.Text = "&Actualizar"
      Me.codigoEstado = 1
    End If
  End Sub

  Private Sub cbTipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbTipo.KeyPress
    e.KeyChar = Char.ToUpper(e.KeyChar)
  End Sub

End Class