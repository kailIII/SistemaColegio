Public Class frmGestionAmbientes
  Private codigo As Integer
  Private wlocal As String = ""
  Public Property Local() As String
    Get
      Return wlocal
    End Get
    Set(ByVal value As String)
      wlocal = value
    End Set
  End Property

#Region "Control de teclas"
  Private Sub txtNumero_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPiso.KeyPress, txtCapacidad.KeyPress
    If Char.IsDigit(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False Then
      e.Handled = True
    End If
  End Sub
#End Region

#Region "Validacion"
  Private Sub cboLocal_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboLocal.Validating
    If cboLocal.SelectedIndex = -1 Then
      e.Cancel = True
      ErrAmbientes.SetError(cboLocal, "Debe indicar el Local")
    Else
      ErrAmbientes.SetError(cboLocal, "")
    End If
  End Sub
  Private Sub cboPabellon_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboPabellon.Validating
    If cboPabellon.SelectedIndex = -1 Then
      e.Cancel = True
      ErrAmbientes.SetError(cboPabellon, "Debe indicar el Pabellón")
    Else
      ErrAmbientes.SetError(cboPabellon, "")
    End If
  End Sub
  Private Sub cboTipo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboTipo.Validating
    If cboTipo.SelectedIndex = -1 Then
      e.Cancel = True
      ErrAmbientes.SetError(cboTipo, "Debe indicar el Tipo")
    Else
      ErrAmbientes.SetError(cboTipo, "")
    End If
  End Sub

  Private Sub txtPiso_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPiso.Validating
    If txtPiso.Text.Length = 0 Then
      e.Cancel = True
      ErrAmbientes.SetError(txtPiso, "Debe indicar el Piso")
    Else
      ErrAmbientes.SetError(txtPiso, "")
    End If
  End Sub

  Private Sub txtCapacidad_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCapacidad.Validating
    If txtCapacidad.Text.Length = 0 Then
      e.Cancel = True
      ErrAmbientes.SetError(txtCapacidad, "Debe indicar la Capacidad")
    Else
      ErrAmbientes.SetError(txtCapacidad, "")
    End If
  End Sub
#End Region

  Private Sub cboTipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipo.SelectedIndexChanged
    If cboTipo.SelectedIndex > -1 Then
      nudNumero.Value = 1
    End If
  End Sub
  Private Sub frmGestionAmbientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnModificar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
    
    CargarLocales(cboLocal)
    SeleccionarLocal(wlocal)
    cboTipo.SelectedIndex = 0
    cboPabellon.SelectedIndex = 0
    'If cboLocal.Items.Count > 0 Then
    '  cboTipo.SelectedIndex = 0
    'End If
    AgregarAula()
    Habilitar()
    Me.txtPiso.Focus()
  End Sub

  Private Sub CargarLocales(ByVal Local As ComboBox)
    Dim obj As New RNLocal
    Dim la As List(Of Local)
        la = obj.ListarLocales_Inst(mOInstitucion.CodigoInst)
    Local.DisplayMember = "Nombre"
    Local.ValueMember = "Codigo"
    Local.DataSource = la
  End Sub
  Private Sub InicializarControles()
    Me.codigo = 0
    Me.txtPiso.Text = ""
    cboTipo.SelectedIndex = 0
    Me.cboxVigenciaAmb.Visible = False
    Me.btnRegistrar.Text = "&Registrar"
    txtPiso.Focus()
  End Sub
  Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim tipo As String = Nothing
    If Me.ValidateChildren() Then
      Dim objAula As New RNAula
      Try
        Select Case cboTipo.Text
          Case "Aula"
            tipo = "A"
          Case "Patio"
            tipo = "P"
          Case "Laboratorio"
            tipo = "L"
        End Select

        If codigo = 0 Then
          objAula.Registrar(New Aula(Nothing, cboLocal.SelectedValue.ToString, CInt(nudNumero.Value), CInt(Me.txtCapacidad.Text), _
                                     Me.cboxVigenciaAmb.Checked, CInt(Me.txtPiso.Text), tipo, cboPabellon.SelectedIndex))

          MessageBox.Show("El Ambiente se registró exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          objAula.Modificar(New Aula(Me.codigo, cboLocal.SelectedValue.ToString, CInt(nudNumero.Value), CInt(Me.txtCapacidad.Text), _
                                     Me.cboxVigenciaAmb.Checked, CInt(Me.txtPiso.Text), tipo, cboPabellon.SelectedIndex))

          MessageBox.Show("Los datos se actualizaron exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        InicializarControles()

        nudNumero.Value += 1

        AgregarAula()
        Habilitar()
        txtPiso.Focus()
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        objAula = Nothing
      End Try
    End If
  End Sub



  Private Sub btbCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.InicializarControles()
    Me.cboTipo.SelectedIndex = 0
    Me.txtCapacidad.Text = ""
  End Sub

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub AgregarAula()
    Dim obj As New RNAula
    Dim la As List(Of Aula)

    la = obj.ListarTodasAulas
    dgvAmbientes.AutoGenerateColumns = False
    dgvAmbientes.DataSource = la
  End Sub

  Public Sub Habilitar()
    If dgvAmbientes.RowCount = 0 Then
      Me.btnModificar.Enabled = False
    Else
      Me.btnModificar.Enabled = True
    End If
  End Sub

  Public Sub SeleccionarLocal(ByVal wnombre As String)
    cboLocal.Text = wnombre
  End Sub

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click, dgvAmbientes.DoubleClick
    InicializarControles()
    Dim obj As RNAula = Nothing
    Dim A As Aula = Nothing
    Dim tipo As String = ""
    If dgvAmbientes.SelectedRows.Count > 0 Then
      With CType(dgvAmbientes.SelectedRows.Item(0).DataBoundItem, Aula)
        obj = New RNAula
        A = obj.Leer(New Aula(.Codigo))
        If A IsNot Nothing Then
          codigo = .Codigo
          cboLocal.Text = A.Local.Nombre
          Select Case A.Tipo
            Case "A"
              tipo = "Aula"
            Case "P"
              tipo = "Patio"
            Case "L"
              tipo = "Laboratorio"
          End Select
          cboTipo.Text = tipo

          txtPiso.Text = A.Piso.ToString
          txtCapacidad.Text = A.Capacidad.ToString
          nudNumero.Value = A.Numero

          If A.Pabellon = 0 Then
            cboPabellon.SelectedIndex = A.Pabellon
          ElseIf A.Pabellon = 1 Then
            cboPabellon.SelectedIndex = A.Pabellon
          ElseIf A.Pabellon = 2 Then
            cboPabellon.SelectedIndex = A.Pabellon
          End If
          cboxVigenciaAmb.Visible = True
          If A.Vigencia = True Then
            cboxVigenciaAmb.Checked = True
          Else
            cboxVigenciaAmb.Checked = False
          End If
          btnRegistrar.Text = "&Actualizar"
          cboTipo.Focus()
        Else
          MessageBox.Show("No se pudo encontrar al Local solicitado", "Gestión de Locales", MessageBoxButtons.OK, MessageBoxIcon.Information)
          InicializarControles()

        End If
      End With
    End If
  End Sub
End Class