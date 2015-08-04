Public Class frmGestionOpcion

  Private cod As Integer

  Private errManejador As ErrorProvider

  Public WriteOnly Property ManejadorError() As ErrorProvider
    Set(ByVal value As ErrorProvider)
      Me.errManejador = value
    End Set
  End Property

  Private Sub Opcion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.rbtvigente.Checked = True
    Me.btnnuevo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\nuevo.png")
    Me.btnregistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btncancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnseleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
    Me.btnsistema.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
    cargasistema()
    Me.cargatabla()
  End Sub

  Private Sub cargatabla()
    Dim x As Integer
    Dim obj As New RNOpcion
    Dim la As List(Of Opcion)

    x = CInt(Me.cbosistema.SelectedValue)
    la = obj.Leer(x)
    dgvopciones.AutoGenerateColumns = False
    dgvopciones.DataSource = la
    Me.dgvopciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
  End Sub

  Private Sub cargasistema()
    Dim obj As New RNSistema
    Dim la As List(Of Sistema)
    la = obj.LeerVigentes
    cbosistema.DisplayMember = "Nombre"
    cbosistema.ValueMember = "Codigo"
    cbosistema.DataSource = la
  End Sub

  Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
    Me.txtNumero.Focus()
    Me.limpiar()
    Me.btnregistrar.Text = "&Registrar"
  End Sub

  Private Sub limpiar()
    If cbosistema.Items.Count > 0 Then
      Me.cbosistema.SelectedIndex = 0
    Else
      Me.cbosistema.SelectedIndex = -1
    End If
    Me.txtnombre.Text = ""
    Me.txtdescripcion.Text = ""
    Me.rbtvigente.Checked = True
    Me.txtNumero.Text = ""
  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Dispose()
  End Sub

  Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
    Me.limpiar()
    Me.btnregistrar.Text = "&Registrar"
  End Sub

  Private Sub btnregistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregistrar.Click
    Dim regla As RNOpcion

    If Me.ValidateChildren Then

      Try
        regla = New RNOpcion
        If Me.btnregistrar.Text = "&Registrar" Then
          regla.registrar(New Opcion(CInt(Me.txtNumero.Text), DirectCast(Me.cbosistema.SelectedItem, Sistema), Me.txtnombre.Text, Me.txtdescripcion.Text, rbtvigente.Checked))
          MessageBox.Show("Opción del sistema registrado correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          regla.Modificar(New Opcion(cod, DirectCast(Me.cbosistema.SelectedItem, Sistema), Me.txtnombre.Text, Me.txtdescripcion.Text, rbtvigente.Checked), CInt(Me.txtNumero.Text))
          Me.btnregistrar.Text = "&Registrar"
          MessageBox.Show("Opción del sistema modificado correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.limpiar()
        Me.cargatabla()
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        regla = Nothing
      End Try
    Else
      MessageBox.Show("Ingrese Campos Correctamente", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub cbosistema_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosistema.SelectedIndexChanged
    Me.cargatabla()
  End Sub

  Private Sub btnseleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnseleccionar.Click
    Dim obj As RNOpcion = Nothing
    Dim L As Opcion = Nothing
    Dim count As Integer

    Me.txtNumero.Focus()
    Me.btnregistrar.Text = "&Modificar"
    count = Me.dgvopciones.Rows.Count

    If count > 0 Then
      obj = New RNOpcion
      L = CType(Me.dgvopciones.Rows(dgvopciones.CurrentRow.Index).DataBoundItem, Opcion)
      cod = L.Numero
      If L IsNot Nothing Then
        Me.txtNumero.Text = L.Numero.ToString
        Me.txtnombre.Text = L.Nombre
        Me.txtdescripcion.Text = L.Descripcion
        If L.Vigencia = False Then
          Me.rbtnovigente.Checked = True
        Else
          Me.rbtvigente.Checked = True
        End If
      Else
        MessageBox.Show("No se pudo encontrar la opción solicitada", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
    End If

  End Sub

  Private Sub btnsistema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsistema.Click
    Dim sist As New frmSistema
    sist.Show()
  End Sub

  Private Sub txtNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumero.KeyPress
    If Not (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) And Not (Asc(e.KeyChar) = 8) Then
      e.Handled = True
    End If
  End Sub

  Private Sub cbosistema_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbosistema.Validating
    If cbosistema.SelectedIndex = -1 Then
      Me.errManejador.SetError(cbosistema, "Debe seleccionar el sistema")
      e.Cancel = True
    Else
      Me.errManejador.SetError(cbosistema, "")
    End If
  End Sub

  Private Sub txtNumero_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNumero.Validating
    If Me.txtNumero.Text.Length = 0 Then
      Me.errManejador.SetError(txtNumero, "Debe indicar el número")
      e.Cancel = True
    Else
      Me.errManejador.SetError(txtNumero, "")
    End If
  End Sub

  Private Sub txtnombre_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtnombre.Validating
    If Me.txtnombre.Text.Length = 0 Then
      Me.errManejador.SetError(txtnombre, "Debe indicar el nombre")
      e.Cancel = True
    Else
      Me.errManejador.SetError(txtnombre, "")
    End If
  End Sub

End Class