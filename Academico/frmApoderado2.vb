Public Class frmApoderado2
  Dim nuevoapod As Apoderado
  Dim ap As New Apoderado
  Dim al As New Alumno
  Dim par As Parentesco
  Dim p As New Parentesco
  Dim objAP As New RNApoderado
  Dim estado As Boolean = False
  Dim existe As Boolean
  Public Function IniciarFormulario(ByVal alum As Alumno, ByRef parentes As Parentesco, ByRef existePar As Boolean) As Apoderado
    al = alum
    txtNombreBuscar.Text = ""
    txtNombreBuscar.Focus()
    Me.btnSeleccionar.Enabled = False
    Me.gbbuscarparentesco.Visible = False
    Me.TabApoderado.TabPages.Remove(Me.TabPageRegistrar)
    Me.ShowDialog()
    parentes = par
    existePar = existe
    If estado = True Then
      Return nuevoapod
    End If
    Return ap
  End Function
#Region "BuscarApoderado"
  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Dim obj As New RNApoderado
    Dim la As List(Of Apoderado)
    la = obj.Listar(txtNombreBuscar.Text.Trim)
    dgvApoderado.AutoGenerateColumns = False
    dgvApoderado.DataSource = la
    If la.Count > 0 Then
      Me.btnSeleccionar.Enabled = True
    Else
      Me.btnSeleccionar.Enabled = False
    End If
  End Sub

  Private Sub txtNombreBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombreBuscar.KeyPress
    If Not (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90 Or Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) And Not (Asc(e.KeyChar) = 8) And Not (Asc(e.KeyChar) = 32) And Not (Asc(e.KeyChar) = 209) And Not (Asc(e.KeyChar) = 241) Then
      e.KeyChar = CChar("")
    End If
  End Sub

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    Me.TabApoderado.TabPages.Add(Me.TabPageRegistrar)
    TabApoderado.SelectedTab = TabApoderado.TabPages.Item(1)
    InicializarControles()
    habilitar()
    Me.gbparentesco.Enabled = True
    Me.estado = True
    Me.txtnombre.Focus()
    IniciarUbicacionGeog()
  End Sub
  Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
    ap = CType(Me.dgvApoderado.Rows(Me.dgvApoderado.CurrentRow.Index).DataBoundItem, Apoderado)
        '     ap = objAP.LeerApoderadoNombre(ap)
    estado = False
    buscarParentesco()
  End Sub
  Public Sub habilitar()
    Me.gbdatos.Enabled = True
    Me.gbUbicacion.Enabled = True
  End Sub
  Public Sub inhabilitar()
    Me.gbdatos.Enabled = False
    Me.gbUbicacion.Enabled = False
  End Sub
  Public Sub buscarParentesco()

    ' p = objAP.LeerParentesco(al, ap)
    If p Is Nothing Then
      Me.gbparentesco.Enabled = True
      cboParentesco.Text = ""
      existe = False
      Me.gbbuscarparentesco.Visible = True
      Me.cbparentescobuscar.Enabled = True
      Me.cbparentescobuscar.Text = ""
      Me.cbparentescobuscar.Focus()
    Else
      Me.cboParentesco.Text = p.Parentesco
      Me.gbparentesco.Enabled = False
      existe = True
      Me.gbbuscarparentesco.Visible = True
      Me.cbparentescobuscar.Text = p.Parentesco
      Me.cbparentescobuscar.Enabled = False
    End If
  End Sub
#End Region
#Region "Control de teclas"
  Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress, txtPat.KeyPress, txtMat.KeyPress
    If Char.IsLetter(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False And _
        Char.IsSeparator(e.KeyChar) = False AndAlso e.KeyChar <> "'"c Then
      e.Handled = True
    End If
  End Sub

  Private Sub txtcelular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcelular.KeyPress, txtTelefcasa.KeyPress, txtTelefTrabajo.KeyPress
    If Char.IsDigit(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False Then
      e.Handled = True
    End If
  End Sub
#End Region
#Region "Validacion"
  Private Sub txtnombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtnombre.Validating
    If txtnombre.Text.Length = 0 Then
      e.Cancel = True
      ErrorApoderado.SetError(txtnombre, "Debe indicar el Nombre del Alumno")
    Else
      ErrorApoderado.SetError(txtnombre, "")
    End If
  End Sub
  Private Sub txtpat_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPat.Validating
    If txtPat.Text.Length = 0 Then
      e.Cancel = True
      ErrorApoderado.SetError(txtPat, "Debe indicar el Apellido Paterno")
    Else
      ErrorApoderado.SetError(txtPat, "")
    End If
  End Sub
  Private Sub txtmat_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMat.Validating
    If txtMat.Text.Length = 0 Then
      e.Cancel = True
      ErrorApoderado.SetError(txtMat, "Debe indicar Apellido Paterno")
    Else
      ErrorApoderado.SetError(txtMat, "")
    End If
  End Sub
  Private Sub cbosexo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboSexo.Validating
    If cboSexo.SelectedIndex = -1 Then
      e.Cancel = True
      ErrorApoderado.SetError(cboSexo, "Debe indicar el Sexo del Alumno")
    Else
      ErrorApoderado.SetError(cboSexo, "")
    End If
  End Sub
  Private Sub cboParentesco_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboParentesco.Validating
    If cboParentesco.Text = "" Then
      e.Cancel = True
      ErrorApoderado.SetError(cboParentesco, "Debe indicar Parentesco")
    Else
      ErrorApoderado.SetError(cboParentesco, "")
    End If
  End Sub
  Private Sub cbogradoInst_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbogradoInst.Validating
    If cbogradoInst.SelectedIndex = -1 Then
      e.Cancel = True
      ErrorApoderado.SetError(cbogradoInst, "Debe indicar el Grado de Instrucción")
    Else
      ErrorApoderado.SetError(cbogradoInst, "")
    End If
  End Sub
  Private Sub cboOcupacion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboOcupacion.Validating
    If cboOcupacion.SelectedIndex = -1 Then
      e.Cancel = True
      ErrorApoderado.SetError(cboOcupacion, "Debe indicar Ocupación")
    Else
      ErrorApoderado.SetError(cboOcupacion, "")
    End If
  End Sub
  Private Sub txtdireccion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtdireccion.Validating
    If txtdireccion.Text.Length = 0 Then
      e.Cancel = True
      ErrorApoderado.SetError(txtdireccion, "Debe indicar la Dirección")
    Else
      ErrorApoderado.SetError(txtdireccion, "")
    End If
  End Sub
  Private Sub cboVive_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboVive.Validating
    If cboVive.SelectedIndex = -1 Then
      e.Cancel = True
      ErrorApoderado.SetError(cboVive, "Vive?")
    Else
      ErrorApoderado.SetError(cboVive, "")
    End If
  End Sub
#End Region
  Public Sub InicializarControles()
    Me.txtnombre.Text = ""
    Me.txtPat.Text = ""
    Me.txtMat.Text = ""
    Me.cboSexo.SelectedIndex = 1
    Me.cboVive.SelectedIndex = 1
    Me.cbogradoInst.SelectedIndex = 1
    Me.cboParentesco.Text = ""
    Me.cboVive.SelectedIndex = 1
    Me.cbotipoDoc.SelectedIndex = -1
    Me.txtNroDoc.Text = ""
    Me.txtdireccion.Text = ""
    Me.txtemail.Text = ""
    Me.txtTelefcasa.Text = ""
    Me.txtTelefTrabajo.Text = ""
    Me.txtcelular.Text = ""
    btnRegistrar.Text = "&Registrar"
    txtnombre.Focus()
  End Sub
  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    ap = Nothing
    par = Nothing
    Me.Close()
  End Sub
  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim objApoderado As New RNApoderado
    Dim objUG As New RNUbicacionGeografica
    Dim parentesco As String = ""
    Dim tipoDoc As String = ""
    Dim sexo As Boolean
    Dim vive As Boolean

    Try
      If cbparentescobuscar.Text <> "" Or cboParentesco.Text <> "" Then
        If cboSexo.SelectedIndex = 0 Then
          sexo = False
        Else
          sexo = True
        End If
        If cboVive.SelectedIndex = 0 Then
          vive = False
        Else
          vive = True
        End If
        Select Case cbotipoDoc.Text
          Case "DNI"
            tipodoc = "DN"
          Case "Carnet Extranjería"
            tipodoc = "CE"
          Case "Libreta Electoral"
            tipodoc = "LE"
          Case "Libreta Militar"
            tipodoc = "LM"
          Case "Pasaporte"
            tipodoc = "PA"
          Case "Carnet Policial"
            tipodoc = "CP"
        End Select

        If Me.cboParentesco.Text <> "" Then
          parentesco = Me.cboParentesco.Text
        ElseIf Me.cbparentescobuscar.Text <> "" Then
          parentesco = Me.cbparentescobuscar.Text
        End If
        If estado = True Then
          'nuevoapod = New Apoderado(txtnombre.Text, txtPat.Text, txtMat.Text, sexo, dtpFechaNac.Value, _
          '                          tipoDoc, txtNroDoc.Text, cbogradoInst.Text, cboOcupacion.Text, txtTelefTrabajo.Text, _
          '                          txtcelular.Text.Trim, vive, parentesco, txtemail.Text, txtdireccion.Text, txtTelefcasa.Text, _
          '                          New UbicacionGeografica(Me.cbodistrito.Text, Me.cbopPvcia.Text, Me.cbodpto.Text, Me.cbopais.Text))
        End If
        par = New Parentesco(al.Codigo, ap.Codigo, parentesco)
        MessageBox.Show("Registrado exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
      Else
        MessageBox.Show("Ingrese el parentesco", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      objApoderado = Nothing
    End Try

  End Sub

#Region "Ubicacion Geografica"
  Public Sub IniciarUbicacionGeog()
    Dim ug As New RNUbicacionGeografica
    Dim lug As New List(Of UbicacionGeografica)
    lug = ug.ListarPaises()
    ug = Nothing
    Me.cbopais.DataSource = lug
    Me.cbopais.DisplayMember = "pais"
    'Me.cbopais.SelectedIndex = -1
    Me.cbodpto.SelectedText = "Lambayeque"
    Me.cbopPvcia.SelectedText = "Chiclayo"
    Me.cbodistrito.SelectedText = "Chiclayo"
  End Sub
  Private Sub cbodpto_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbodpto.Enter
    Dim ug As RNUbicacionGeografica
    Dim lug As List(Of UbicacionGeografica)

    If cbopais.Text.Length > 0 Then
      ug = New RNUbicacionGeografica
      lug = ug.ListarDptos(cbopais.Text)
      ug = Nothing
      Me.cbodpto.DataSource = lug
      Me.cbodpto.DisplayMember = "departamento"
    Else
      Me.cbodpto.DataSource = Nothing
      Me.cbodpto.Text = ""
    End If
  End Sub

  Private Sub cbopPvcia_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbopPvcia.Enter
    Dim ug As RNUbicacionGeografica
    Dim lug As List(Of UbicacionGeografica)
    If cbodpto.Text.Length > 0 Then
      ug = New RNUbicacionGeografica
      lug = ug.ListarProvincias(cbopais.Text, cbodpto.Text)
      ug = Nothing
      Me.cbopPvcia.DataSource = lug
      Me.cbopPvcia.DisplayMember = "provincia"
    Else
      Me.cbopPvcia.DataSource = Nothing
      Me.cbopPvcia.Text = ""
    End If
  End Sub

  Private Sub cbodistrito_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbodistrito.Enter
    Dim ug As RNUbicacionGeografica
    Dim lug As List(Of UbicacionGeografica)

    If cbopPvcia.Text.Length > 0 Then
      ug = New RNUbicacionGeografica
      lug = ug.ListarDistritos(cbopais.Text, cbodpto.Text, cbopPvcia.Text)
      ug = Nothing
      Me.cbodistrito.DataSource = lug
      Me.cbodistrito.DisplayMember = "distrito"
    Else
      Me.cbodistrito.DataSource = Nothing
      Me.cbodistrito.Text = ""
    End If
  End Sub
#End Region


End Class