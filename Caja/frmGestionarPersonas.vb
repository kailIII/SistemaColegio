Public Class frmGestionarPersonas

  Private personas As List(Of Persona)
  Private per As Persona

  Private perCorrecta As Persona
  Private perDuplicado As Persona

  Private Shared frm As frmGestionarPersonas

  Private Sub New()
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
  End Sub

  Public Shared Sub Presentar(ByVal wPadre As Form)
    If frmGestionarPersonas.frm Is Nothing Then
      frmGestionarPersonas.frm = New frmGestionarPersonas
      frm.MdiParent = wPadre
      frmGestionarPersonas.frm.Show()
      frmGestionarPersonas.frm.WindowState = FormWindowState.Maximized
    Else
      frmGestionarPersonas.frm.Activate()
    End If
  End Sub


  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim rn As New RNPersona

    personas = rn.Listar(Me.txtPersona.Text.Trim)
    rn = Nothing

    Me.ActualizarLista()
  End Sub

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

    If Me.dgvPersonas.CurrentRow IsNot Nothing Then
      per = DirectCast(Me.dgvPersonas.CurrentRow.DataBoundItem, Persona)
      Me.PresentarDatos()
    Else
      MessageBox.Show("Debe seleccionar una persona", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Me.dgvPersonas.Focus()
    End If
  End Sub

  Private Sub PresentarDatos()
    Dim rn As New RNPersona

    per = rn.leer(per)
    rn = Nothing
    If per IsNot Nothing Then
      Me.txtNombre.Text = per.Nombre
      Me.txtApellidoPaterno.Text = per.ApellidoPaterno
      Me.txtApellidoMaterno.Text = per.ApellidoMaterno
      Me.activarControles(True)
    Else
      MessageBox.Show("No se encontraron los datos solicitados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If

  End Sub

  Private Sub ActivarControles(ByVal wEstado As Boolean)
    Me.gbPersona.Enabled = wEstado
    Me.gbBuscar.Enabled = Not wEstado
    If wEstado = True Then
      Me.txtNombre.Focus()
    Else
      Me.txtPersona.Focus()
    End If
  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    Dim rn As RNPersona

    If Me.ValidateChildren Then
      rn = New RNPersona

      Try
        With Me.per
          .Nombre = Me.txtNombre.Text.Trim
          .ApellidoPaterno = Me.txtApellidoPaterno.Text.Trim
          .ApellidoMaterno = Me.txtApellidoMaterno.Text.Trim
        End With

        rn.Actualizar(Me.per)
        Me.ActivarControles(False)
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        rn = Nothing
      End Try
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub frmGestionarPersonas_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmGestionarPersonas.frm = Nothing
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.ActivarControles(False)
  End Sub

  Private Sub ActualizarLista()
    Me.dgvPersonas.DataSource = Nothing
    Me.dgvPersonas.AutoGenerateColumns = False
    Me.dgvPersonas.DataSource = Me.personas
    If Me.personas.Count > 0 Then
      Me.dgvPersonas.Focus()
    End If
  End Sub

  Private Sub btnEliminarDuplicado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarDuplicado.Click
    Me.gbBuscar.Enabled = False
    Me.gbEliminarDuplicado.Visible = True
    Me.txtNombreCorrecto.Text = ""
    Me.txtNombreDuplicado.Text = ""
    Me.btnBuscarCorrecto.Focus()
  End Sub

  Private Sub btnCancelarFusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarFusion.Click
    Me.gbBuscar.Enabled = True
    Me.gbEliminarDuplicado.Visible = False
    Me.txtPersona.Focus()
    Me.perCorrecta = Nothing
    Me.perDuplicado = Nothing
  End Sub

  Private Sub btnAceptarFusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptarFusion.Click
    Dim rn As RNPersona

    If Me.perCorrecta IsNot Nothing AndAlso Me.perDuplicado IsNot Nothing Then
      rn = New RNPersona
      Try
        rn.EliminarDuplicado(Me.perCorrecta, Me.perDuplicado)

        Me.perCorrecta = Nothing
        Me.perDuplicado = Nothing
        Me.gbBuscar.Enabled = True
        Me.gbEliminarDuplicado.Visible = False
        Me.txtPersona.Focus()
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        rn = Nothing
      End Try
    End If
  End Sub

  Private Sub btnBuscarCorrecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarCorrecto.Click
    Dim f As New frmBuscarPersona

    f.ControlError = Me.errPersona
    Me.perCorrecta = f.Buscar
    If Me.perCorrecta IsNot Nothing Then
      Me.txtNombreCorrecto.Text = Me.perCorrecta.NombreCompleto
    End If
  End Sub

  Private Sub btnBuscarDuplicado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarDuplicado.Click
    Dim f As New frmBuscarPersona

    f.ControlError = Me.errPersona
    Me.perDuplicado = f.Buscar
    If Me.perDuplicado IsNot Nothing Then
      Me.txtNombreDuplicado.Text = Me.perDuplicado.NombreCompleto
    End If
  End Sub

  Private Sub txtPersona_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPersona.Enter
    Me.AcceptButton = Me.btnListar
  End Sub

End Class