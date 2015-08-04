Public Class frmGestionUsuarios

  Private a As Persona = Nothing
  Private cod As Integer
  Private grupo As Integer

  Private Sub frmUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.rbtvigente.Checked = True
    Me.btnnuevo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\nuevo.png")
    Me.btnregistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btncancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnseleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
    Me.cargagrupo()
    Me.cbotipollenar()
    cargatabla()
  End Sub

  Private Sub cbotipollenar()
    Me.cboTipo.Items.Add("ADMINISTRADOR")
    Me.cboTipo.Items.Add("LIMITADO")
    Me.cboTipo.SelectedIndex = 1
  End Sub

  Private Sub limpiar()
    Me.cargagrupo()
    Me.txtUsuario.Text = ""
    Me.txtContraseña.Text = ""
    Me.txtConfirmar.Text = ""
    Me.txtpersona.Text = ""
    Me.rbtvigente.Checked = True
    If Me.cbogrupo.Items.Count > 0 Then
      Me.cbogrupo.SelectedIndex = 0
    End If
    Me.cboTipo.SelectedIndex = 1
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
    Me.limpiar()
    Me.btnregistrar.Text = "&Registrar"
  End Sub

  Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
    Me.limpiar()
    Me.btnregistrar.Text = "&Registrar"
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Dispose()
  End Sub

  Private Sub btnbuscapersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscapersona.Click
    Dim frmbuscar As New frmBuscaPersona
    Dim obj As RNPersona = Nothing

    a = frmbuscar.Buscar
    frmbuscar.Dispose()
    frmbuscar = Nothing
    If a IsNot Nothing Then
      Me.txtpersona.Text = a.NombreCompleto
    End If
  End Sub

  Private Sub btnregistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregistrar.Click
    Dim regla As RNUsuario
    Dim x As Boolean
    Dim t As Char

    Me.txtUsuario.Text = Me.txtUsuario.Text.Trim
    If a IsNot Nothing Then
      regla = New RNUsuario
      If Me.txtUsuario.Text.Length > 0 AndAlso Me.txtpersona.Text.Length > 0 AndAlso Me.txtContraseña.Text.Length > 0 _
          AndAlso Me.txtContraseña.Text = Me.txtConfirmar.Text Then

        If Me.rbtvigente.Checked Then
          x = True
        Else
          x = False
        End If
        t = CChar(Me.cboTipo.Text.Substring(0, 1))

        If Me.btnregistrar.Text = "&Registrar" Then
          If Me.cbogrupo.Items.Count > 0 Then
            Try
              Dim rpta As Usuario = Nothing
              rpta = regla.Verificar(Me.txtUsuario.Text)
              If rpta Is Nothing Then
                regla.Registrar(New Usuario(New Persona(a.Codigo), Me.txtUsuario.Text, Me.txtContraseña.Text, t, x))
                rpta = regla.Verificar(Me.txtUsuario.Text)
                regla.registrar2(rpta, New GrupoUsuario(CInt(Me.cbogrupo.SelectedValue)))
                MessageBox.Show("Usuario Ingresado Correctamente", "REPORTE", MessageBoxButtons.OK, MessageBoxIcon.Information)
              Else
                MessageBox.Show("Usuario Existente", "REPORTE", MessageBoxButtons.OK, MessageBoxIcon.Error)
              End If
            Catch ex As Exception
              MessageBox.Show("Error en el Registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
              Me.cargatabla()
              Me.limpiar()
            End Try
          Else
            MessageBox.Show("Grupos no Vigentes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
          End If
        Else
          Try
            regla.Modificar(New Usuario(cod, a, Me.txtUsuario.Text, Me.txtContraseña.Text, t, x))
            Me.btnregistrar.Text = "&Registrar"
            MessageBox.Show("Grupo Modificado Correctamente", "REPORTE", MessageBoxButtons.OK, MessageBoxIcon.Information)
          Catch ex As Exception
            MessageBox.Show("Error en la Modificacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
          Finally
            Me.cargatabla()
            Me.limpiar()
          End Try

        End If
      Else
        MessageBox.Show("Ingrese Campos Correctamente", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Me.limpiar()
      End If
    Else
      MessageBox.Show("Persona no encontrada", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Me.limpiar()
    End If
    Me.txtUsuario.Focus()
  End Sub

  Private Sub cargatabla()
    Dim obj As New RNUsuario
    Dim la As List(Of Usuario)

    la = obj.Leer(Me.txtUsuario.Text)
    dgvUsuarios.AutoGenerateColumns = False
    dgvUsuarios.DataSource = la
    Me.dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
  End Sub

  Private Sub btnseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnseleccionar.Click
    Dim obj As RNUsuario = Nothing
    Dim L As Usuario = Nothing
    Dim count As Integer

    Me.txtUsuario.Focus()
    Me.cbogrupo.DataSource = Nothing
    Me.cbogrupo.Enabled = False
    Me.btnregistrar.Text = "&Modificar"

    count = Me.dgvUsuarios.Rows.Count
    If count > 0 Then
      obj = New RNUsuario
      L = CType(Me.dgvUsuarios.Rows(dgvUsuarios.CurrentRow.Index).DataBoundItem, Usuario)
      cod = L.Codigo
      a = Nothing
      a = L.Persona
      If L IsNot Nothing Then
        Me.txtpersona.Text = L.NombrePersona
        Me.txtUsuario.Text = L.Nombre
        Me.txtContraseña.Text = ""
        If L.Tipo = "L" Then
          Me.cboTipo.SelectedIndex = 1
        Else
          Me.cboTipo.SelectedIndex = 0
        End If

        If L.Vigencia = False Then
          Me.rbtnovigente.Checked = True
        Else
          Me.rbtvigente.Checked = True
        End If
      Else
        MessageBox.Show("No se pudo encontrar el Sistema Seleccionado", "Gestión de Locales", MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
    End If
  End Sub

  Private Sub btnVerificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerificar.Click
    Me.cargatabla()
    If Me.dgvUsuarios.Rows.Count > 0 Then
      MessageBox.Show("Ya existe un usuario con ese nombre", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Me.txtUsuario.SelectAll()
      Me.txtUsuario.Focus()
    End If
  End Sub

End Class