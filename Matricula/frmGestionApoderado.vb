Public Class frmGestionApoderado

  Public mcodigoAlumno As Integer
  Private Apod As Apoderado
  Private Alum As Alumno
  Private relacion As Integer
  Private UnaVez As Boolean
  Private cadfinal As String
  Private Codigo As Integer
  Private cerrar As Integer

  Public Property CodigoAlumno() As Integer
    Get
      Return mcodigoAlumno
    End Get
    Set(ByVal value As Integer)
      mcodigoAlumno = value
    End Set
  End Property

#Region "Control de teclas"

  Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress, txtpat.KeyPress, txtmat.KeyPress
    If Char.IsLetter(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False And _
        Char.IsSeparator(e.KeyChar) = False AndAlso e.KeyChar <> "'"c Then
      e.Handled = True
    End If
  End Sub

  Private Sub txtcelular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcelular.KeyPress, txtTelefcasa.KeyPress, txtTelefTrabajo.KeyPress
    If Char.IsDigit(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False _
        AndAlso e.KeyChar <> "*"c AndAlso e.KeyChar <> "#"c AndAlso e.KeyChar <> "-"c Then

      e.Handled = True
    End If
  End Sub

  Private Sub txtNroDoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNroDoc.KeyPress
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

  Private Sub txtpat_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtpat.Validating
    If txtpat.Text.Length = 0 Then
      e.Cancel = True
      ErrorApoderado.SetError(txtpat, "Debe indicar el Apellido Paterno")
    Else
      ErrorApoderado.SetError(txtpat, "")
    End If
  End Sub

  Private Sub txtmat_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtmat.Validating
    If txtmat.Text.Length = 0 Then
      e.Cancel = True
      ErrorApoderado.SetError(txtmat, "Debe indicar Apellido Paterno")
    Else
      ErrorApoderado.SetError(txtmat, "")
    End If
  End Sub

  Private Sub cbosexo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboSexo.Validating
    If cboSexo.SelectedIndex = -1 Then
      e.Cancel = True
      ErrorApoderado.SetError(cboSexo, "Debe indicar el sexo del pariente")
    Else
      If cboSexo.Text = "FEMENINO" And cboTipoParentesco.Text = "PADRE" Then
        e.Cancel = True
        ErrorApoderado.SetError(cboSexo, "El sexo del pariente no corresponde con el parentesco" & _
                                vbNewLine & cboTipoParentesco.Text & " - " & cboSexo.Text)
      ElseIf cboSexo.Text = "MASCULINO" And cboTipoParentesco.Text = "MADRE" Then
        e.Cancel = True
        ErrorApoderado.SetError(cboSexo, "El sexo del pariente no corresponde con el parentesco" & _
                                vbNewLine & cboTipoParentesco.Text & " - " & cboSexo.Text)
      Else
        ErrorApoderado.SetError(cboSexo, "")
      End If
    End If
  End Sub

  Private Sub cbotipoDoc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbotipoDoc.Leave
    If cbotipoDoc.Text = "DNI" Then
      txtNroDoc.MaxLength = 8
    Else
      txtNroDoc.MaxLength = 11
    End If
  End Sub

  Private Sub cboTipoDoc_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbotipoDoc.Validating
    If cbotipoDoc.SelectedIndex = -1 Then
      e.Cancel = True
      ErrorApoderado.SetError(cbotipoDoc, "Debe indicar el tipo de Documento")
    Else
      ErrorApoderado.SetError(cbotipoDoc, "")
    End If
  End Sub

  Private Sub txtDNI_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNroDoc.Validating
    If txtNroDoc.Text.Length = 0 And txtNroDoc.Text.Length < 11 Then
      e.Cancel = True
      ErrorApoderado.SetError(txtNroDoc, "Debe indicar Nro de documento")
    Else
      ErrorApoderado.SetError(txtNroDoc, "")
    End If
  End Sub

  Private Sub cboEstadoCivil_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboEstadoCivil.Validating
    If cboEstadoCivil.SelectedIndex = -1 Then
      e.Cancel = True
      ErrorApoderado.SetError(cboEstadoCivil, "Debe indicar el estado Civil")
    Else
      ErrorApoderado.SetError(cboEstadoCivil, "")
    End If
  End Sub

  Private Sub cboTipoParentesco_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoParentesco.SelectedIndexChanged
    If cboTipoParentesco.SelectedIndex > -1 Then
      If cboTipoParentesco.Text = "MADRE" Then
        cboSexo.SelectedIndex = 0
      ElseIf cboTipoParentesco.Text = "PADRE" Then
        cboSexo.SelectedIndex = 1
      End If
    End If

  End Sub

  Private Sub cboTipoParentesco_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboTipoParentesco.Validating
    If cboTipoParentesco.Visible = True Then
      If cboTipoParentesco.Text.Length = 0 Then
        e.Cancel = True
        ErrorApoderado.SetError(cboTipoParentesco, "Debe indicar el parentesco")
      Else
        ErrorApoderado.SetError(cboTipoParentesco, "")
      End If
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

  Private Sub cboOcupacion_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboOcupacion.Leave
    cadfinal = Me.cboOcupacion.Text.Trim
    Me.cboOcupacion.Text = UCase(Me.cboOcupacion.Text.Trim)
  End Sub

  Private Sub cboOcupacion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboOcupacion.Validating
    If cboOcupacion.Text.Length = 0 Then
      If cboVive.SelectedIndex = 1 Then
        e.Cancel = True
        ErrorApoderado.SetError(cboOcupacion, "Debe indicar ocupación")
      End If
    Else
      ErrorApoderado.SetError(cboOcupacion, "")
    End If
  End Sub

  Private Sub cboProfesion_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProfesion.Leave

    cadfinal = Me.cboProfesion.Text.Trim
    Me.cboProfesion.Text = UCase(Me.cboProfesion.Text.Trim)

  End Sub

  Private Sub cboProfesion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboProfesion.Validating
    If cboProfesion.Text.Length = 0 Then
      If cboVive.SelectedIndex = 1 Then
        e.Cancel = True
        ErrorApoderado.SetError(cboProfesion, "Debe indicar Profesión")
      End If
    Else
      ErrorApoderado.SetError(cboProfesion, "")
    End If
  End Sub

  Private Sub CDireccionActual_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CDireccionActual.Validating
    If CDireccionActual.cbopais.Text.Length = 0 Then
      e.Cancel = True
      ErrorApoderado.SetError(CDireccionActual.cbopais, "Debe indicar el Pais ")
    Else
      ErrorApoderado.SetError(CDireccionActual.cbopais, "")
    End If

    If CDireccionActual.cbodpto.Text.Length = 0 Then
      e.Cancel = True
      ErrorApoderado.SetError(CDireccionActual.cbodpto, "Debe indicar el Departamento ")
    Else
      ErrorApoderado.SetError(CDireccionActual.cbodpto, "")
    End If

    If CDireccionActual.cbopPvcia.Text.Length = 0 Then
      e.Cancel = True
      ErrorApoderado.SetError(CDireccionActual.cbopPvcia, "Debe indicar la Provincia ")
    Else
      ErrorApoderado.SetError(CDireccionActual.cbopPvcia, "")
    End If

    If CDireccionActual.cbodistrito.Text.Length = 0 Then
      e.Cancel = True
      ErrorApoderado.SetError(CDireccionActual.cbodistrito, "Debe indicar el Distrito ")
    Else
      ErrorApoderado.SetError(CDireccionActual.cbodistrito, "")
    End If
  End Sub
#End Region

  Public Sub Gestionar()
    InicializarControles(1)
    btnBuscarAlumno.Visible = True
    btnNuevo.Visible = False
    btnCancelar.Visible = False
    btnEditar.Visible = False
    Me.ShowDialog()
  End Sub

  Public Sub DatosAlumno()
    Dim obj As New RNAlumno
    Dim a As Alumno

    If mcodigoAlumno > 0 Then
      a = obj.Leer(New Alumno(mcodigoAlumno))
      txtdireccion.Text = a.Direccion
      txtTelefcasa.Text = a.Telefono
    End If
  End Sub

  Public Sub ListarProfesiones()
    Dim obj As New RNProfesion
    Dim lp As List(Of Profesion)
    lp = obj.ListarProfesiones
    Me.cboProfesion.DisplayMember = "Nombre"
    Me.cboProfesion.DataSource = lp
  End Sub

  Public Sub ListarOcupaciones()
    Dim obj As New RNOcupacion
    Dim lo As List(Of Ocupacion)
    lo = obj.ListarOcupaciones
    Me.cboOcupacion.DisplayMember = "Nombre"
    Me.cboOcupacion.DataSource = lo
  End Sub

  Public Sub ListarPadre_Apoderado()
    Dim obj As New RNApoderado
    Dim lo As List(Of Parentesco)

    cboParentesco.Text = ""

    lo = obj.ListarParentesco(mcodigoAlumno)
    Me.cboParentesco.DisplayMember = "Parentesco"
    Me.cboParentesco.ValueMember = "codigoApoderado"
    Me.cboParentesco.DataSource = lo

    If Not lo.Count > 0 Then
      gbDP.Enabled = True
      gbLuganNac.Enabled = True
      btnRegistrar.Enabled = True
      cboTipoParentesco.Visible = False
    Else
      cboParentesco.Visible = True
      cboTipoParentesco.Visible = False
    End If
  End Sub

  Public Sub MostrarDatos()
    Dim Apod As Parentesco = Nothing
    Dim tipodoc As String = ""

    If cboParentesco.SelectedIndex > -1 Then
      Apod = CType(cboParentesco.SelectedItem, Parentesco)

      Codigo = Apod.Apoderado.Codigo

      txtnombre.Text = Apod.Apoderado.Nombre
      txtpat.Text = Apod.Apoderado.ApellidoPaterno
      txtmat.Text = Apod.Apoderado.ApellidoMaterno

      Select Case Apod.Apoderado.TipoDoc
        Case "DN"
          tipodoc = "DNI"
        Case "CE"
          tipodoc = "Carnet Extranjería"
        Case "LE"
          tipodoc = "Libreta Electoral"
        Case "LM"
          tipodoc = "Libreta Militar"
        Case "PA"
          tipodoc = "Pasaporte"
        Case "CP"
          tipodoc = "Carnet Policial"
      End Select

      cbotipoDoc.Text = tipodoc
      txtNroDoc.Text = Apod.Apoderado.NroDoc
      txtdireccion.Text = Apod.Apoderado.Direccion
      txtTelefcasa.Text = Apod.Apoderado.TelefonoCasa
      txtTelefTrabajo.Text = Apod.Apoderado.TelefonoTrabajo
      txtcelular.Text = Apod.Apoderado.Celular
      txtemail.Text = Apod.Apoderado.Email

      Select Case Apod.Apoderado.GradoInstruccion
        Case "P"
          cbogradoInst.Text = "PRIMARIA"
        Case "S"
          cbogradoInst.Text = "SECUNDARIA"
        Case "U"
          cbogradoInst.Text = "UNIVERSITARIA"
        Case "T"
          cbogradoInst.Text = "TECNICA"
        Case "N"
          cbogradoInst.Text = "NINGUNA"
      End Select

      Select Case Apod.Apoderado.EstadoCivil
        Case "S"
          cboEstadoCivil.Text = "SOLTERO(a)"
        Case "C"
          cboEstadoCivil.Text = "CASADO(a)"
        Case "V"
          cboEstadoCivil.Text = "VIUDO(a)"
        Case "D"
          cboEstadoCivil.Text = "DIVORCIADO(a)"
        Case "O"
          cboEstadoCivil.Text = "CONVIVIENTE"
        Case "E"
          cboEstadoCivil.Text = "SEPARADO(a)"
      End Select


      cboProfesion.Text = Apod.Apoderado.Profesion.Nombre
      cboOcupacion.Text = Apod.Apoderado.Ocupacion.Nombre
      If Apod.Apoderado.Sexo = "M" Then
        cboSexo.SelectedIndex = 1
      Else
        cboSexo.SelectedIndex = 0
      End If
      txtlugarTrabajo.Text = Apod.Apoderado.LugarTrabajo
      If Apod.Apoderado.Vive = True Then
        cboVive.SelectedIndex = 1
      Else
        cboVive.SelectedIndex = 0
      End If

      dtpFechaNac.Value = Apod.Apoderado.FechaNacimiento
      CDireccionActual.cbopais.Text = Apod.Apoderado.DireccionActual.Pais
      CDireccionActual.cbodpto.Text = Apod.Apoderado.DireccionActual.Departamento
      CDireccionActual.cbopPvcia.Text = Apod.Apoderado.DireccionActual.Provincia
      CDireccionActual.cbodistrito.Text = Apod.Apoderado.DireccionActual.Distrito

      btnRegistrar.Text = "&Actualizar"

      'txtnombre.Focus()
    End If
  End Sub

  Private Sub cboParentesco_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboParentesco.SelectedIndexChanged
    If cboParentesco.SelectedIndex > -1 Then
      MostrarDatos()
      MostrarTutor()
    Else
      Limpiar()
    End If
  End Sub

  Private Sub InicializarControles(ByVal wparentesco As Integer)
    Me.txtnombre.Text = ""
    Me.txtpat.Text = ""
    Me.txtmat.Text = ""
    Me.cboSexo.SelectedIndex = wparentesco
    Me.cboVive.SelectedIndex = 1
    Me.cbogradoInst.SelectedIndex = 1
    Me.cboVive.SelectedIndex = 1
    Me.cbotipoDoc.SelectedIndex = 0
    Me.cboEstadoCivil.SelectedIndex = 1
    Me.txtdireccion.Text = ""
    Me.txtemail.Text = ""
    Me.txtTelefcasa.Text = ""
    Me.txtNroDoc.Text = ""
    Me.CDireccionActual.CargarPaises()

    Me.txtTelefTrabajo.Text = ""
    Me.txtcelular.Text = ""
    If cboParentesco.Items.Count > 0 Then
      cboParentesco.SelectedIndex = 0
      MostrarDatos()
    Else
      Me.cboParentesco.SelectedIndex = -1
      Me.DatosAlumno()
      Me.Codigo = 0
      btnRegistrar.Text = "&Registrar"
    End If
  End Sub

  Public Sub Limpiar()
    Me.Codigo = 0

    Me.txtnombre.Text = ""
    Me.txtpat.Text = ""
    Me.txtmat.Text = ""
    Me.cboSexo.SelectedIndex = 1
    Me.cboVive.SelectedIndex = 1
    Me.cbogradoInst.SelectedIndex = 1
    Me.cboVive.SelectedIndex = 1
    Me.cbotipoDoc.SelectedIndex = 0
    Me.cboEstadoCivil.SelectedIndex = 1
    Me.cboParentesco.SelectedIndex = -1
    Me.txtNroDoc.Text = ""

    Me.txtdireccion.Text = ""
    Me.txtTelefcasa.Text = ""

    Me.txtemail.Text = ""
    Me.txtlugarTrabajo.Text = ""
    Me.txtTelefTrabajo.Text = ""
    Me.txtcelular.Text = ""

    Me.cboOcupacion.SelectedIndex = -1
    Me.cboProfesion.SelectedIndex = -1

    btnRegistrar.Text = "&Registrar"
    btnRegistrar.Enabled = True
    cboTipoParentesco.Focus()
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Dim s As String = cboParentesco.Text
    Limpiar()
    ErrorApoderado.SetError(txtnombre, "")
    ErrorApoderado.SetError(txtpat, "")
    ErrorApoderado.SetError(txtmat, "")
    ErrorApoderado.SetError(cboSexo, "")
    ErrorApoderado.SetError(cbotipoDoc, "")
    ErrorApoderado.SetError(txtNroDoc, "")
    ErrorApoderado.SetError(cboEstadoCivil, "")
    ErrorApoderado.SetError(cboTipoParentesco, "")
    ErrorApoderado.SetError(txtdireccion, "")
    ErrorApoderado.SetError(cboVive, "")
    ErrorApoderado.SetError(cboOcupacion, "")
    ErrorApoderado.SetError(cboProfesion, "")
    ErrorApoderado.SetError(CDireccionActual.cbopais, "")
    ErrorApoderado.SetError(CDireccionActual.cbodpto, "")
    ErrorApoderado.SetError(CDireccionActual.cbopPvcia, "")
    ErrorApoderado.SetError(CDireccionActual.cbodistrito, "")
    Codigo = 0
    cboParentesco.Text = s
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim objApoderado As New RNApoderado
    Dim objUG As New RNUbicacionGeografica
    Dim sexo As String
    Dim vive As Boolean
    Dim tipodoc As String = ""
    Dim gradoinst As String = ""
    Dim estcivil As String = ""

    If Me.cboVive.SelectedIndex = 0 Then
      txtdireccion.Text = "  "
      txtTelefcasa.Text = ""
      txtcelular.Text = ""
      txtlugarTrabajo.Text = ""
      txtemail.Text = ""
      txtTelefTrabajo.Text = ""
      cboOcupacion.Text = "NINGUNA"
    End If

    If Me.ValidateChildren() Then
      objApoderado = New RNApoderado
      objUG = New RNUbicacionGeografica

      Try
        If cboSexo.SelectedIndex = 0 Then
          sexo = "F"
        Else
          sexo = "M"
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

        Select Case cbogradoInst.Text
          Case "PRIMARIA"
            gradoinst = "P"
          Case "SECUNDARIA"
            gradoinst = "S"
          Case "UNIVERSITARIA"
            gradoinst = "U"
          Case "TECNICA"
            gradoinst = "T"
          Case "NINGUNA"
            gradoinst = "N"
        End Select

        Select Case cboEstadoCivil.Text
          Case "SOLTERO(a)"
            estcivil = "S"
          Case "CASADO(a)"
            estcivil = "C"
          Case "VIUDO(a)"
            estcivil = "V"
          Case "DIVORCIADO(a)"
            estcivil = "D"
          Case "CONVIVIENTE"
            estcivil = "O"
          Case "SEPARADO(a)"
            estcivil = "E"
        End Select

        If Codigo = 0 Then
          Codigo = objApoderado.Registrar(New Apoderado(txtnombre.Text, txtpat.Text.Trim, txtmat.Text.Trim, sexo, dtpFechaNac.Value, _
                                                  tipodoc, txtNroDoc.Text.Trim, estcivil, gradoinst, txtdireccion.Text, _
                                                  txtTelefcasa.Text.Trim, txtTelefTrabajo.Text.Trim, txtlugarTrabajo.Text, txtemail.Text.Trim, txtcelular.Text.Trim, vive, _
                                                  New Ocupacion(cboOcupacion.Text), New Profesion(cboProfesion.Text), New UbicacionGeografica(CDireccionActual.cbodistrito.Text, CDireccionActual.cbopPvcia.Text, _
                                                  CDireccionActual.cbodpto.Text, CDireccionActual.cbopais.Text)), New Parentesco(mcodigoAlumno, Nothing, cboTipoParentesco.Text))
          Apod = New Apoderado(Codigo, txtnombre.Text, txtpat.Text, txtmat.Text)
          MessageBox.Show(cboParentesco.Text + "  registrado exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

          If UnaVez = True Then
            Me.Close()
          End If
          If cerrar = 1 Then
            Me.Close()
          End If
        Else
          objApoderado.Modificar(New Apoderado(Me.Codigo, txtnombre.Text, txtpat.Text.Trim, txtmat.Text.Trim, sexo, dtpFechaNac.Value, _
                                                tipodoc, txtNroDoc.Text.Trim, estcivil, gradoinst, txtdireccion.Text, _
                                                txtTelefcasa.Text.Trim, txtTelefTrabajo.Text.Trim, txtlugarTrabajo.Text, txtemail.Text.Trim, txtcelular.Text.Trim, vive, _
                                                New Ocupacion(cboOcupacion.Text), New Profesion(cboProfesion.Text), New UbicacionGeografica(CDireccionActual.cbodistrito.Text, CDireccionActual.cbopPvcia.Text, _
                                                CDireccionActual.cbodpto.Text, CDireccionActual.cbopais.Text)))
          CambiarEstado(True, False)
          MessageBox.Show("Los datos se actualizaron exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Dim s As String = cboParentesco.Text
        ListarPadre_Apoderado()
        cboParentesco.Text = s
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        objApoderado = Nothing
      End Try
    End If
  End Sub

  Private Sub frmAPoderado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    'la propiedad KeyPreview del frm debe estar en True, 

    If e.KeyCode = Keys.F3 Then
      BuscarAlumnosTeclasRapidas()
      e.Handled = True
    ElseIf e.KeyCode = Keys.F5 Then
      If txtAlumno.Text.Length > 0 Then
        BuscarpadresTeclasRapidas()
      Else
        MessageBox.Show("Seleccione un alumno!!!")
      End If
    End If

  End Sub

  Private Sub frmAPoderado_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    LeerAlumno(mcodigoAlumno)

    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "/Imagenes/Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "/Imagenes/Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "/Imagenes/Cancelar.png")
    Me.btnBuscarPersonas.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "/Imagenes/Buscar.png")
    Me.btnNuevo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "/Imagenes/nuevo.png")
    Me.btnBuscarAlumno.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "/Imagenes/Buscar.png")
    Me.btnEditar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "/Imagenes/Editar.jpg")

    CDireccionActual.CargarPaises()
    Me.CDireccionActual.cbopais.Text = "PERU"
    Me.CDireccionActual.cbopais.Tag = "PERU"
    Me.CDireccionActual.ListarDepartamentos()
    Me.CDireccionActual.cbodpto.Text = "LAMBAYEQUE"
    Me.CDireccionActual.cbodpto.Tag = "LAMBAYEQUE"
    Me.CDireccionActual.ListarProvincias()
    Me.CDireccionActual.cbopPvcia.Text = "CHICLAYO"
    Me.CDireccionActual.cbopPvcia.Tag = "CHICLAYO"
    Me.CDireccionActual.ListarDistritos()
    Me.CDireccionActual.cbodistrito.Text = "CHICLAYO"
    Me.CDireccionActual.cbodistrito.Tag = "CHICLAYO"

    'Me.txtnombre.CharacterCasing = CharacterCasing.Upper
    Me.txtpat.CharacterCasing = CharacterCasing.Upper
    Me.txtmat.CharacterCasing = CharacterCasing.Upper
    Me.txtdireccion.CharacterCasing = CharacterCasing.Upper
    Me.txtlugarTrabajo.CharacterCasing = CharacterCasing.Upper

    Me.Codigo = 0
    Me.btnRegistrar.Enabled = False

    ListarProfesiones()
    ListarOcupaciones()
    InicializarControles(relacion)
    'cboTipoParentesco.SelectedIndex = 0
    ListarPadre_Apoderado()

    CambiarEstado(True, False)
    btnRegistrar.Enabled = False
  End Sub

  Private Sub LeerAlumno(ByVal codigoAlum As Integer)
    Dim obj As New RNAlumno
    Dim A As Alumno = Nothing
    If codigoAlum > 0 Then
      A = obj.Leer(New Alumno(codigoAlum))
      txtAlumno.Text = A.NombreCompleto
    End If
  End Sub

  Private Sub MostrarTutor()
    Dim obj As New RNApoderado
    Dim A As New Apoderado

    If mcodigoAlumno > 0 Then
      A = obj.MostrarTutor(mcodigoAlumno, moAnioActual)
      If Not A Is Nothing Then
        If A.Codigo = CType(cboParentesco.SelectedItem, Parentesco).Apoderado.Codigo Then
          cboxTutor.Checked = True
          cboxTutor.Visible = True
        Else
          cboxTutor.Visible = False
        End If
      Else
        A = Nothing
      End If
    End If
  End Sub

  Public Function RegistrarNuevoApo(ByVal estadoForm As Integer) As Apoderado
    cerrar = estadoForm
    CambiarEstado(True, False)
    Me.ShowDialog()
    Return Apod
  End Function

  Private Sub BuscarpadresTeclasRapidas()
    Dim obj As RNApoderado = Nothing
    Dim a As Apoderado = Nothing
    Dim frmbuscar As New frmBuscarApoderadoNew

    a = frmbuscar.Buscar

    frmbuscar.Dispose()
    frmbuscar = Nothing

    Limpiar()
    If a IsNot Nothing Then
      obj = New RNApoderado
      Apod = obj.LeerPersonas(New Apoderado(a.Codigo))
      If Apod IsNot Nothing Then
        cboParentesco.Text = ""
        cboParentesco.Focus()
        txtnombre.Text = Apod.Nombre
        txtpat.Text = Apod.ApellidoPaterno
        txtmat.Text = Apod.ApellidoMaterno
        If Apod.Sexo = "M" Then
          cboSexo.SelectedIndex = 1
        Else
          cboSexo.SelectedIndex = 0
        End If
        dtpFechaNac.Value = Apod.FechaNacimiento

        Select Case Apod.TipoDoc
          Case "DN"
            cbotipoDoc.Text = "DNI"
          Case "CE"
            cbotipoDoc.Text = "Carnet Extranjería"
          Case "LE"
            cbotipoDoc.Text = "Libreta Electoral"
          Case "LM"
            cbotipoDoc.Text = "Libreta Militar"
          Case "PA"
            cbotipoDoc.Text = "Pasaporte"
          Case "CP"
            cbotipoDoc.Text = "Carnet Policial"
        End Select

        Select Case Apod.GradoInstruccion
          Case "P"
            cbogradoInst.Text = "PRIMARIA"
          Case "S"
            cbogradoInst.Text = "SECUNDARIA"
          Case "U"
            cbogradoInst.Text = "UNIVERSITARIA"
          Case "T"
            cbogradoInst.Text = "TECNICA"
          Case "N"
            cbogradoInst.Text = "NINGUNA"
        End Select

        Select Case Apod.EstadoCivil
          Case "S"
            cboEstadoCivil.Text = "SOLTERO(a)"
          Case "C"
            cboEstadoCivil.Text = "CASADO(a)"
          Case "V"
            cboEstadoCivil.Text = "VIUDO(a)"
          Case "D"
            cboEstadoCivil.Text = "DIVORCIADO(a)"
          Case "O"
            cboEstadoCivil.Text = "CONVIVIENTE"
          Case "E"
            cboEstadoCivil.Text = "SEPARADO(a)"
        End Select

        txtNroDoc.Text = Apod.NroDoc

        txtdireccion.Text = Apod.Direccion
        txtTelefcasa.Text = Apod.TelefonoCasa
        txtTelefTrabajo.Text = Apod.TelefonoTrabajo
        txtcelular.Text = Apod.Celular
        cboProfesion.Text = Apod.Profesion.Nombre
        cboOcupacion.Text = Apod.Ocupacion.Nombre

        txtlugarTrabajo.Text = Apod.LugarTrabajo
        txtemail.Text = Apod.Email
        If Apod.Vive = True Then
          cboVive.SelectedIndex = 1
        Else
          cboVive.SelectedIndex = 0
        End If
        dtpFechaNac.Value = Apod.FechaNacimiento
        CDireccionActual.cbopais.Text = Apod.DireccionActual.Pais
        CDireccionActual.cbodpto.Text = Apod.DireccionActual.Departamento
        CDireccionActual.cbopPvcia.Text = Apod.DireccionActual.Provincia
        CDireccionActual.cbodistrito.Text = Apod.DireccionActual.Distrito
      End If
    End If

  End Sub

  Private Sub btnBuscarPersonas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPersonas.Click
    BuscarpadresTeclasRapidas()
  End Sub

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    ErrorApoderado.SetError(txtnombre, "")
    ErrorApoderado.SetError(txtpat, "")
    ErrorApoderado.SetError(txtmat, "")
    ErrorApoderado.SetError(cboSexo, "")
    ErrorApoderado.SetError(cbotipoDoc, "")
    ErrorApoderado.SetError(txtNroDoc, "")
    ErrorApoderado.SetError(cboEstadoCivil, "")
    ErrorApoderado.SetError(cboTipoParentesco, "")
    ErrorApoderado.SetError(txtdireccion, "")
    ErrorApoderado.SetError(cboVive, "")
    ErrorApoderado.SetError(cboOcupacion, "")
    ErrorApoderado.SetError(cboProfesion, "")
    ErrorApoderado.SetError(CDireccionActual.cbopais, "")
    ErrorApoderado.SetError(CDireccionActual.cbodpto, "")
    ErrorApoderado.SetError(CDireccionActual.cbopPvcia, "")
    ErrorApoderado.SetError(CDireccionActual.cbodistrito, "")

    Me.CDireccionActual.cbopais.Text = "PERU"
    Me.CDireccionActual.cbopais.Tag = "PERU"
    Me.CDireccionActual.ListarDepartamentos()
    Me.CDireccionActual.cbodpto.Text = "LAMBAYEQUE"
    Me.CDireccionActual.cbodpto.Tag = "LAMBAYEQUE"
    Me.CDireccionActual.ListarProvincias()
    Me.CDireccionActual.cbopPvcia.Text = "CHICLAYO"
    Me.CDireccionActual.cbopPvcia.Tag = "CHICLAYO"
    Me.CDireccionActual.ListarDistritos()
    Me.CDireccionActual.cbodistrito.Text = "CHICLAYO"
    Me.CDireccionActual.cbodistrito.Tag = "CHICLAYO"

    Limpiar()
    CambiarEstado(False, True)
    DatosAlumno()

    cboTipoParentesco.Visible = True
    cboParentesco.Visible = False
    cboxTutor.Visible = False
    cboTipoParentesco.SelectedIndex = 0

    cboTipoParentesco.Focus()
  End Sub

  Public Sub CambiarEstado(ByVal text As Boolean, ByVal combo As Boolean)
    Me.txtnombre.ReadOnly = text
    Me.txtpat.ReadOnly = text
    Me.txtmat.ReadOnly = text
    Me.txtdireccion.ReadOnly = text
    Me.txtTelefcasa.ReadOnly = text
    Me.txtTelefTrabajo.ReadOnly = text
    Me.txtcelular.ReadOnly = text
    Me.txtemail.ReadOnly = text
    Me.txtlugarTrabajo.ReadOnly = text
    Me.txtNroDoc.ReadOnly = text

    Me.btnBuscarPersonas.Enabled = combo

    Me.cboEstadoCivil.Enabled = combo
    Me.cbotipoDoc.Enabled = combo
    Me.CDireccionActual.Enabled = combo
    Me.dtpFechaNac.Enabled = combo
    Me.cboSexo.Enabled = combo
    Me.cboVive.Enabled = combo
    Me.cbogradoInst.Enabled = combo
    Me.cboProfesion.Enabled = combo
    Me.cboOcupacion.Enabled = combo
  End Sub

  Private Sub btnBuscarAlumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarAlumno.Click
    BuscarAlumnosTeclasRapidas()
  End Sub

  Private Sub BuscarAlumnosTeclasRapidas()
    Dim a As Alumno = Nothing
    Dim frmbuscar As New frmBuscarAlumno_new
    Dim obj As RNAlumno = Nothing
    a = frmbuscar.Buscar
    frmbuscar.Dispose()
    frmbuscar = Nothing

    If a IsNot Nothing Then

      cboParentesco.Visible = True

      obj = New RNAlumno
      a = obj.Leer(New Alumno(a.Codigo))

      Alum = a
      mcodigoAlumno = Alum.Codigo
      txtAlumno.Text = Alum.NombreCompleto

      ListarPadre_Apoderado()
      InicializarControles(1)
      cboParentesco.Focus()
      CambiarEstado(True, False)
      btnRegistrar.Enabled = False
      btnNuevo.Visible = True
      btnCancelar.Visible = True
      btnEditar.Visible = True
    End If
  End Sub

  Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
    If cboParentesco.SelectedIndex > -1 Then
      CambiarEstado(False, True)
      Me.txtnombre.Focus()
      btnRegistrar.Enabled = True
      'DatosAlumno()

      cboTipoParentesco.Visible = False
      cboParentesco.Visible = True
    Else
      MessageBox.Show("Debe seleccionar un pariente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      cboParentesco.Focus()
    End If
  End Sub

  Private Sub txtAlumno_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlumno.Enter
    AcceptButton = btnBuscarAlumno
  End Sub

  Private Sub txtAlumno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAlumno.Leave
    AcceptButton = btnBuscarPersonas
  End Sub

  Private Sub txtnombre_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnombre.Leave
    AcceptButton = btnRegistrar
  End Sub

  Private Sub txtnombre_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnombre.Enter
    AcceptButton = btnBuscarPersonas
  End Sub

End Class