Public Class frmBuscarServicio

  Private Servicio As New Servicio
  Private Entidad As String

  Private multiple As Boolean = False
  Private seleccionados As List(Of Servicio)

  Private Sub frmBuscarServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnSeleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes/seleccionar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes/cancelar.png")
    Me.btnBuscar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes/Buscar.png")
    Me.txtnombre.Focus()
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Dim ListServSel As New List(Of ServicioSeleccionar)
    Dim ListServ As List(Of Servicio)
    Dim objRNServ As New RNServicio

    ListServ = objRNServ.ListarServicio(New Servicio(0, Me.txtnombre.Text.Trim, 0, Entidad, "", True, Nothing, Nothing, Nothing))
    CopiarServicios(ListServSel, ListServ)
    objRNServ = Nothing
    If ListServSel.Count = 1 Then
      ListServSel.Item(0).Seleccionado = True
    End If
    Me.dgvServicio.AutoGenerateColumns = False
    Me.dgvServicio.DataSource = ListServSel
    If ListServSel.Count > 0 Then
      Me.dgvServicio.Focus()
    End If
  End Sub

  Private Sub dgvAlumnos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvServicio.KeyDown
    If e.KeyCode = Keys.Enter Then
      e.Handled = True
    End If
  End Sub

  Public Function Buscar(ByVal ent As String) As Servicio
    Me.Entidad = ent

    If Me.Entidad = "I" Then
      lblEntidad.Text = "COLEGIO"
    Else
      lblEntidad.Text = "COPAFA"
    End If

    Me.ShowDialog()
    Return Servicio
  End Function

  Public Function BuscarVarios(ByVal ent As String) As List(Of Servicio)
    Dim seleccionados As New List(Of Servicio)

    Me.Entidad = ent
    If Me.Entidad = "I" Then
      lblEntidad.Text = "COLEGIO"
    Else
      lblEntidad.Text = "COPAFA"
    End If
    Me.multiple = True

    Me.ShowDialog()

    Return Me.seleccionados
  End Function

  Private Sub BuscarServicio()
    If Me.dgvServicio.CurrentRow IsNot Nothing Then
      Servicio = DirectCast(Me.dgvServicio.CurrentRow.DataBoundItem, Servicio)
      Me.Close()
    Else
      MessageBox.Show("Debe seleccionar un servicio", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click, dgvServicio.DoubleClick
    If Me.multiple = False Then
      BuscarServicio()
    Else
      CopiarSeleccionados()
      If seleccionados.Count > 0 Then
        Me.Close()
      Else
        MessageBox.Show("Debe seleccionar al menos un servicio", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If
    End If
  End Sub

  Private Sub frmBuscarServicio_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
    If Convert.ToInt16(e.KeyChar) = Keys.Enter AndAlso TypeOf Me.ActiveControl Is DataGridView Then

      btnSeleccionar.PerformClick()
      e.Handled = True
    End If
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Servicio = Nothing
    Me.Close()
  End Sub

  Private Sub txtnombre_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.Enter
    Me.AcceptButton = Me.btnBuscar
  End Sub

  Private Sub dgvServicio_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvServicio.Enter
    Me.AcceptButton = Me.btnSeleccionar
  End Sub

  Private Sub CopiarServicios(ByVal wSeleccionados As List(Of ServicioSeleccionar), ByVal wServicios As List(Of Servicio))
    Dim sl As ServicioSeleccionar

    For Each ser In wServicios
      sl = New ServicioSeleccionar
      sl.Codigo = ser.Codigo
      sl.Nombre = ser.Nombre
      sl.Monto = ser.Monto
      sl.entidad = ser.entidad
      sl.Descripcion = ser.Descripcion
      sl.vigencia = ser.vigencia
      sl.NivelAcademico = ser.NivelAcademico
      sl.TipoServicio = ser.TipoServicio
      sl.CuentaContable = ser.CuentaContable

      wSeleccionados.Add(sl)
    Next
  End Sub

  Private Sub CopiarSeleccionados()
    Dim wServiciosSel As List(Of ServicioSeleccionar)
    Dim serv As Servicio

    Me.seleccionados = New List(Of Servicio)
    wServiciosSel = DirectCast(Me.dgvServicio.DataSource, List(Of ServicioSeleccionar))
    For Each sel In wServiciosSel
      If sel.Seleccionado = True Then
        serv = New Servicio
        serv.Codigo = sel.Codigo
        serv.Nombre = sel.Nombre
        serv.Monto = sel.Monto
        serv.entidad = sel.entidad
        serv.Descripcion = sel.Descripcion
        serv.vigencia = sel.vigencia
        serv.NivelAcademico = sel.NivelAcademico
        serv.TipoServicio = sel.TipoServicio
        serv.CuentaContable = sel.CuentaContable

        Me.seleccionados.Add(serv)
      End If
    Next
  End Sub

End Class