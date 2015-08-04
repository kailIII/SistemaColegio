Imports Colegio.Reglas
Imports Colegio.Entidades

Public Class frmGestionCuentaContable

  Private nRoot As TreeNode
  Private nodo As TreeNode
  Private nodo1 As TreeNode

  Private A, A1() As String
  Private Codigo As String

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim obj As RNCuenta

    If Me.ValidateChildren Then
      obj = New RNCuenta
      Try
        Dim tipo As String
        If cboTipo.SelectedIndex = 0 Then
          tipo = "F"
        Else
          tipo = "I"
        End If
        If nudNivel.Value <> 1 Then
          A = txtCuentaPadre.Text
          A1 = A.Split(CChar(" "))
          A = A1(0)
        Else
          A = txtNumero.Text
        End If

        If Codigo.Equals("0") = True Then
          obj.Registrar(New CuentaContable(Me.txtNumero.Text.Trim, A, CStr(Me.txtNombre.Text.Trim), "".ToString, True, CInt(nudNivel.Value), tipo))
          CargarCuentas()
          MessageBox.Show("Cuenta Registrada exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          obj.Modificar(Codigo, New CuentaContable(Me.txtNumero.Text.Trim, A, Me.txtNombre.Text.Trim, "".ToString, True, CInt(nudNivel.Value), tipo))
          CargarCuentas()
          MessageBox.Show("Los datos de la cuenta fueron actualizados exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.txtNumero.Text = Nothing
        Me.txtNombre.Text = Nothing
        Me.btnRegistrar.Text = "&Registrar"
        Codigo = "0"
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        obj = Nothing
      End Try
    End If
  End Sub

  Public Sub LlenarTreeview()
    Dim tvn() As TreeNode = tveCuenta.Nodes.Find("CUENTA CONTABLE", True)

    If tveCuenta.Nodes.Count = 0 Then
      nRoot = New TreeNode
      nRoot = tveCuenta.Nodes.Add("CUENTA CONTABLE", "CUENTA CONTABLE")
    End If
    If nudNivel.Value = 1 Then
      If tvn IsNot Nothing AndAlso tvn.Length > 0 Then
        tveCuenta.SelectedNode = tvn(0)
      End If
      tveCuenta.SelectedNode.Nodes.Add(Me.txtNumero.Text + " " + Me.txtNombre.Text, Me.txtNumero.Text + " " + Me.txtNombre.Text)
    Else
      nodo1 = New TreeNode
      With nodo1
        .Text = Me.txtNumero.Text + " " + Me.txtNombre.Text
        .Name = Me.txtNumero.Text + " " + Me.txtNombre.Text

        If IsNothing(tveCuenta.SelectedNode) = False Then
          ' agrego un nuevo nodo secundario dentro del nodo seleccionado
          tveCuenta.SelectedNode.Nodes.Add(nodo1)
          tveCuenta.ExpandAll()
        Else
          MessageBox.Show("No hay una cuenta seleccionada para agregar una nueva subcuenta.", "Agregar SubCuenta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      End With
    End If
  End Sub

  Private Sub frmCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    With tveCuenta
      .Nodes.Clear()
      ' para ver la selección cuando pierde el foco   
      .HideSelection = False
    End With
    Me.txtNombre.CharacterCasing = CharacterCasing.Upper
    CargarCuentas()
    InicializarControles()
    CargarImagenes()
  End Sub

  Public Sub CargarCuentas()
    Dim ListCuenta As New List(Of CuentaContable)
    Dim objCuenta As New RNCuenta

    tveCuenta.Nodes.Clear()

    ListCuenta = objCuenta.Listar(True)
    nodo = tveCuenta.Nodes.Add("PLAN CONTABLE", "PLAN CONTABLE")

    For Each objC As CuentaContable In ListCuenta
      If objC.Nivel = CInt(1) Then
        nodo1 = nodo.Nodes.Add(objC.Codigo.ToString + " " + objC.Nombre.ToString, objC.Codigo.ToString + " " + objC.Nombre.ToString)
        nodo1.ExpandAll()
      End If
    Next
    CargarNiveles(ListCuenta)
  End Sub

  Public Sub CargarNiveles(ByVal List As List(Of CuentaContable))
    Dim sKey As String
    Dim cod As String

    For Each objC2 As CuentaContable In List
      sKey = objC2.Codigo.ToString + " " + objC2.Nombre.ToString
      cod = objC2.Codigo
      For Each objC3 As CuentaContable In List
        If cod = objC3.CodigoPadre And objC3.Nivel <> 1 Then
          'agrego el nodo en el segundo nivel
          Dim tvn() As TreeNode = tveCuenta.Nodes.Find(sKey, True)
          If tvn IsNot Nothing AndAlso tvn.Length > 0 Then
            tveCuenta.SelectedNode = tvn(0)
            tveCuenta.SelectedNode.Nodes.Add(objC3.Codigo.ToString + " " + objC3.Nombre.ToString, objC3.Codigo.ToString + " " + objC3.Nombre.ToString)
          End If
        End If
      Next
    Next
    tveCuenta.ExpandAll()
  End Sub

  Private Sub tveCuenta_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tveCuenta.AfterSelect
    Me.MostrarDatosCuentaSeleccionada(e.Node)
    'A = e.Node.Text
    'A1 = A.Split(CChar(" "))
    'A = A1(0)
    'nudNivel.Value = e.Node.Level

    'If nudNivel.Value = 1 Then
    '  Me.txtCuentaPadre.Text = ""
    'Else
    '  Me.txtCuentaPadre.Text = e.Node.Text
    '  Me.txtNumero.Text = A
    'End If
    'txtNombre.Text = ""
    'btnRegistrar.Text = "&Registrar"
  End Sub

  Private Sub tveCuenta_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tveCuenta.NodeMouseClick
    Me.MostrarDatosCuentaSeleccionada(e.Node)
  End Sub

  Private Sub MostrarDatosCuentaSeleccionada(ByVal nodoCuenta As TreeNode)
    If nodoCuenta.Level > 0 Then
      A = nodoCuenta.Text
      A1 = A.Split(CChar(" "))
      A = A1(0).Trim
      nudNivel.Value = nodoCuenta.Level

      'If nudNivel.Value = 1 Then
      '  Me.txtCuentaPadre.Text = ""
      '  Me.txtNumero.Text = ""
      'Else
      Me.txtCuentaPadre.Text = nodoCuenta.Text
      Me.txtNumero.Text = A
      'End If
    Else
      Me.nudNivel.Value = 1D
      Me.txtCuentaPadre.Text = ""
      Me.txtNumero.Text = ""
    End If
    Me.txtNombre.Text = ""
    Me.btnRegistrar.Text = "&Registrar"
  End Sub

#Region "Validacion"

  Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
    If Char.IsDigit(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False Then
      e.Handled = True
    End If
  End Sub
  Private Sub txtCodigo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNumero.Validating
    ValidarText(e, Me.txtNumero, "Debe ingresar codigo de la cuenta")
  End Sub

  Private Sub txtNombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
    ValidarText(e, Me.txtNombre, "Debe ingresar nombre de la cuenta")
  End Sub
  Private Sub ValidarText(ByVal e As System.ComponentModel.CancelEventArgs, ByVal cadena As TextBox, ByVal msj As String)
    If cadena.Text.Length = 0 Then
      e.Cancel = True
      ErrorCuenta.SetError(cadena, msj)
    Else
      ErrorCuenta.SetError(cadena, "")
    End If
  End Sub
#End Region

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    InicializarControles()
  End Sub

  Public Sub InicializarControles()
    Me.txtNombre.Text = Nothing
    Me.cboTipo.SelectedIndex = 0
    Me.txtNumero.Focus()
    Me.Codigo = "0"
    btnRegistrar.Text = "&Registrar"
  End Sub

  Public Sub CargarImagenes()
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnNuevo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\nuevo.png")
    Me.btnModificar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Editar.jpg")
    'Me.btnEliminar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Anular.png")
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
    Dim obj As RNCuenta = Nothing
    Dim c As CuentaContable = Nothing

    If tveCuenta.Nodes.Count > 0 Then
      obj = New RNCuenta
      If Me.txtNumero.Text <> "" Then
        c = obj.Leer(New CuentaContable(txtNumero.Text))
        If c IsNot Nothing Then
          Codigo = c.Codigo
          nudNivel.Value = c.Nivel
          txtCuentaPadre.Text = c.CodigoPadre.ToString
          If c.Tipo = "F" Then
            cboTipo.SelectedIndex = 0
          Else
            cboTipo.SelectedIndex = 1
          End If
          Me.txtNumero.Text = c.Codigo.ToString
          Me.txtNombre.Text = c.Nombre
          Me.btnRegistrar.Text = "&Actualizar"
        End If
      Else
        MessageBox.Show("Debe seleccionar una cuenta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
    Else
      MessageBox.Show("No se han registrado cuentas", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
  End Sub

  Private Sub btnEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
    If IsNothing(tveCuenta.SelectedNode) = False Then
      If MessageBox.Show("Deseas elimniar la cuenta", "Eliminar Cuentas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        tveCuenta.SelectedNode.Remove()
      End If
    Else
      MessageBox.Show("No hay una cuenta selecionada.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
  End Sub

  Private Sub btnNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    InicializarControles()
    Me.nudNivel.Value += 1
  End Sub

End Class