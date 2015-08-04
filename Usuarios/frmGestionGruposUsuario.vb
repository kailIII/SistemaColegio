Public Class frmGestionGruposUsuario

  Private codigo As Integer

  Private Sub btnregistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregistrar.Click
    Dim regla As New RNGrupoUsuario
    Dim estado As Boolean

    Me.txtnombre.Text = Me.txtnombre.Text.Trim
    Me.txtdescripcion.Text = Me.txtdescripcion.Text.Trim
    If Me.txtnombre.Text.Length > 0 Then
      If Me.rbtvigente.Checked Then
        estado = True
      Else
        estado = False
      End If
      regla = New RNGrupoUsuario
      If Me.btnregistrar.Text = "&Registrar" Then
        regla.registrar(New GrupoUsuario(Me.txtnombre.Text.ToUpper, Me.txtdescripcion.Text, estado))
        MessageBox.Show("Grupo Ingresado Correctamente", "REPORTE", MessageBoxButtons.OK, MessageBoxIcon.Information)
      Else
        regla.Modificar(New GrupoUsuario(codigo, Me.txtnombre.Text.ToUpper, Me.txtdescripcion.Text, estado))
        Me.btnregistrar.Text = "&Registrar"
        MessageBox.Show("Grupo Modificado Correctamente", "REPORTE", MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
      Me.CargarGrupos()
      Me.limpiar()
    Else
      MessageBox.Show("Ingrese Campos Correctamente", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Me.limpiar()
    End If
    Me.txtnombre.Focus()
  End Sub

  Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
    Me.limpiar()
    Me.txtnombre.Focus()
    Me.btnregistrar.Text = "&Registrar"
  End Sub

  Private Sub limpiar()
    Me.txtnombre.Text = ""
    Me.txtdescripcion.Text = ""
    Me.rbtvigente.Checked = True
  End Sub

  Private Sub frmGrupoUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.rbtvigente.Checked = True
    Me.btnnuevo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\nuevo.png")
    Me.btnregistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btncancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnseleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
    Me.CargarGrupos()
    Me.limpiar()
  End Sub

  Public Sub CargarGrupos()
    Dim obj As New RNGrupoUsuario
    Dim la As List(Of GrupoUsuario)

    la = obj.Leer
    Me.dvggrupo.AutoGenerateColumns = False
    Me.dvggrupo.DataSource = la
    Me.dvggrupo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
  End Sub

  Private Sub btnseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnseleccionar.Click
    Dim obj As RNGrupoUsuario = Nothing
    Dim L As GrupoUsuario = Nothing
    Dim count As Integer

    Me.txtnombre.Focus()
    Me.btnregistrar.Text = "&Modificar"

    count = Me.dvggrupo.Rows.Count
    If count > 0 Then
      obj = New RNGrupoUsuario
      L = CType(Me.dvggrupo.Rows(dvggrupo.CurrentRow.Index).DataBoundItem, GrupoUsuario)
      codigo = L.Codigo
      If L IsNot Nothing Then
        Me.txtnombre.Text = L.Nombre
        Me.txtdescripcion.Text = L.Descripcion
        If L.Vigencia = False Then
          Me.rbtnovigente.Checked = True
        Else
          Me.rbtvigente.Checked = True
        End If
      Else
        MessageBox.Show("No se pudo encontrar el grupo Solicitado", "Gestión de grupos de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
    End If
  End Sub

  Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
    Me.limpiar()
    Me.btnregistrar.Text = "&Registrar"
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

End Class