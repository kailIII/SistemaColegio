Public Class frmGestionUsuario

  Private per As Persona = Nothing
  Private cod As Integer
  Private grupo As Integer

  Private errManejador As ErrorProvider

  Public WriteOnly Property ManejadorError() As ErrorProvider
    Set(ByVal value As ErrorProvider)
      Me.errManejador = value
    End Set
  End Property

  Private Sub frmUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.rbtvigente.Checked = True
    Me.btnnuevo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\nuevo.png")
    Me.btnregistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btncancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnseleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
    Me.cargagrupo()
    Me.cbotipollenar()
  End Sub

  Private Sub cbotipollenar()
    Me.cboTipo.Items.Add("LIMITADO")
    Me.cboTipo.Items.Add("ADMINISTRADOR")
    Me.cboTipo.SelectedIndex = 0
  End Sub

  Private Sub Limpiar()
    Me.cargagrupo()
    Me.txtnombre.Text = ""
    Me.txtContraseña.Text = ""
    Me.txtVerificar.Text = ""
    Me.txtpersona.Text = ""
    Me.rbtvigente.Checked = True
    If Me.cbogrupo.Items.Count > 0 Then
      Me.cbogrupo.SelectedIndex = 0
    Else
      Me.cbogrupo.SelectedIndex = -1
    End If
    Me.cboTipo.SelectedIndex = 0
    Me.cbogrupo.Enabled = True
  End Sub

  Private Sub cargagrupo()
    Dim obj As New RNGrupoUsuario
    Dim la As List(Of GrupoUsuario)
    la = obj.LeerVigentes
    cbogrupo.DisplayMember = "Nombre"
    cbogrupo.ValueMember = "Codigo"
    cbogrupo.DataSource = la
  End Sub

  Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
    Me.Limpiar()
    Me.btnregistrar.Text = "&Registrar"
  End Sub

  Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
    Me.Limpiar()
    Me.btnregistrar.Text = "&Registrar"
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Dispose()
  End Sub

  Private Sub btnbuscapersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscapersona.Click
    Dim frmbuscar As New frmBuscaPersona
    Dim obj As RNPersona = Nothing
    per = frmbuscar.Buscar
    frmbuscar.Dispose()
    frmbuscar = Nothing
    If per IsNot Nothing Then
      Me.txtpersona.Text = per.NombreCompleto
    End If

  End Sub

  Private Sub btnregistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregistrar.Click
    Dim rpta As Usuario = Nothing
    Dim regla As RNUsuario
    Dim gr As GrupoUsuario = Nothing
    Dim tipo As Char

    If Me.ValidateChildren Then
      If txtContraseña.Text = txtVerificar.Text Then

        If Me.cboTipo.SelectedIndex = 0 Then tipo = "L"c Else tipo = "A"c

        If cbogrupo.SelectedItem IsNot Nothing Then
          gr = DirectCast(cbogrupo.SelectedItem, GrupoUsuario)
        End If
        regla = New RNUsuario
        Try
          If Me.btnregistrar.Text = "&Registrar" Then
            regla.Registrar(New Usuario(per, Me.txtnombre.Text, Me.txtContraseña.Text, tipo, rbtvigente.Checked) With {.Grupo = gr})
            MessageBox.Show("Usuario registrado correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          Else
            regla.Modificar(New Usuario(cod, per, Me.txtnombre.Text, Me.txtContraseña.Text, tipo, rbtvigente.Checked))
            Me.btnregistrar.Text = "&Registrar"
            MessageBox.Show("Usuario modificado correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          End If
          Limpiar()
          Me.txtnombre.Focus()
        Catch ex As Exception
          MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
          regla = Nothing
        End Try
      Else
        MessageBox.Show("La contraseña y la verificación no coinciden", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        txtContraseña.Text = ""
        txtVerificar.Text = ""
        txtContraseña.Focus()
      End If
    End If
  End Sub

  Private Sub cargatabla()
    Dim obj As New RNUsuario
    Dim la As List(Of Usuario)

    la = obj.Leer(txtUsuarioBuscar.Text)
    dvgusuario.AutoGenerateColumns = False
    dvgusuario.DataSource = la
    Me.dvgusuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect
  End Sub

  Private Sub btnseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnseleccionar.Click
    Dim obj As RNUsuario = Nothing
    Dim L As Usuario = Nothing
    Dim count As Integer

    Me.txtnombre.Focus()
    Me.cbogrupo.DataSource = Nothing
    Me.cbogrupo.Enabled = False
    Me.btnregistrar.Text = "&Modificar"
    count = Me.dvgusuario.Rows.Count
    If count > 0 Then
      obj = New RNUsuario
      L = DirectCast(Me.dvgusuario.Rows(dvgusuario.CurrentRow.Index).DataBoundItem, Usuario)
      cod = L.Codigo
      per = Nothing
      per = L.Persona
      If L IsNot Nothing Then
        Me.txtpersona.Text = L.NombrePersona
        Me.txtnombre.Text = L.Nombre
        Me.txtContraseña.Text = ""
        Me.txtVerificar.Text = ""
        If L.Tipo = "L" Then
          Me.cboTipo.SelectedIndex = 0
        Else
          Me.cboTipo.SelectedIndex = 1
        End If

        If L.Vigencia = False Then
          Me.rbtnovigente.Checked = True
        Else
          Me.rbtvigente.Checked = True
        End If
      Else
        MessageBox.Show("No se pudo encontrar el usuario seleccionado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
    End If
  End Sub

  Private Sub txtpersona_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtpersona.Validating
    If txtpersona.Text.Length = 0 Then
      Me.errManejador.SetError(btnbuscapersona, "Debe identificar una persona")
      e.Cancel = True
    Else
      Me.errManejador.SetError(btnbuscapersona, "")
    End If
  End Sub

  Private Sub txtnombre_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtnombre.Validating
    If txtnombre.Text.Length = 0 Then
      Me.errManejador.SetError(txtnombre, "Debe indicar el nombre de usuario")
      e.Cancel = True
    Else
      Me.errManejador.SetError(txtnombre, "")
    End If
  End Sub

  Private Sub txtContraseña_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtContraseña.Validating
    If txtContraseña.Text.Length = 0 Then
      Me.errManejador.SetError(txtContraseña, "Debe indicar la contraseña")
      e.Cancel = True
    Else
      Me.errManejador.SetError(txtContraseña, "")
    End If
  End Sub

  Private Sub txtVerificar_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtVerificar.Validating
    If txtVerificar.Text.Length = 0 Then
      Me.errManejador.SetError(txtVerificar, "Debe indicar la contraseña para confirmar")
      e.Cancel = True
    Else
      Me.errManejador.SetError(txtVerificar, "")
    End If
  End Sub

  Private Sub cboTipo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboTipo.Validating
    If cboTipo.Text.Length = 0 Then
      Me.errManejador.SetError(cboTipo, "Debe indicar el tipo de usuario")
      e.Cancel = True
    Else
      Me.errManejador.SetError(cboTipo, "")
    End If
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    cargatabla()
  End Sub

End Class