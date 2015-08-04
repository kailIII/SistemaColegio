Public Class frmGestionAlumno

  Private Codigo As Integer
  Private Alum As Alumno
  Private cerrar As Integer = 0

  Public Property Alumno() As Alumno
    Get
      Return Alum
    End Get
    Set(ByVal value As Alumno)
      Alum = value
    End Set
  End Property

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    InicializarControles()
    ErrAlumno.SetError(txtdireccion, "")
    ErrAlumno.SetError(cbonacionalidad, "")
    ErrAlumno.SetError(cbogrupoSang, "")
    ErrAlumno.SetError(cbolengmat, "")
    ErrAlumno.SetError(CDireccionActual.cbopais, "")
    ErrAlumno.SetError(CDireccionActual.cbodpto, "")
    ErrAlumno.SetError(CDireccionActual.cbopPvcia, "")
    ErrAlumno.SetError(CDireccionActual.cbodistrito, "")
    ErrAlumno.SetError(txtmat, "")
    ErrAlumno.SetError(cbosexo, "")
    ErrAlumno.SetError(txtnombre, "")
    ErrAlumno.SetError(txtpat, "")
    ErrAlumno.SetError(txtCodEducando, "")
    ErrAlumno.SetError(CLugarNac.cbopais, "")
    ErrAlumno.SetError(CLugarNac.cbodpto, "")
    ErrAlumno.SetError(CLugarNac.cbopPvcia, "")
    ErrAlumno.SetError(CLugarNac.cbodistrito, "")

    Me.btnpadres.Visible = False
  End Sub

#Region "Control de Teclas"
  Private Sub txtCodEducando_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodEducando.KeyPress
    If Char.IsDigit(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False Then

      e.Handled = True
    End If
  End Sub

  Private Sub txtnombre_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnombre.Enter
    AcceptButton = btnBuscar
  End Sub

  Private Sub txtmat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmat.KeyPress, txtpat.KeyPress, txtnombre.KeyPress
    If Char.IsLetter(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False And _
        Char.IsSeparator(e.KeyChar) = False AndAlso e.KeyChar <> "'"c Then
      e.Handled = True
    End If
  End Sub

#End Region

#Region "Validacion"
  Private Sub txtdireccion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtdireccion.Validating
    If txtdireccion.Text.Length = 0 Then
      e.Cancel = True
      ErrAlumno.SetError(txtdireccion, "Debe indicar La Dirección")
    Else
      ErrAlumno.SetError(txtdireccion, "")
    End If
  End Sub

  Private Sub cbonacionalidad_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbonacionalidad.Validating
    If cbonacionalidad.Text.Length = 0 Then
      e.Cancel = True
      ErrAlumno.SetError(cbonacionalidad, "Debe indicar Nacionalidad")
    Else
      ErrAlumno.SetError(cbonacionalidad, "")
    End If
  End Sub

  Private Sub cbogrupoSang_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbogrupoSang.Validating
    If cbogrupoSang.SelectedIndex = -1 Then
      e.Cancel = True
      ErrAlumno.SetError(cbogrupoSang, "Debe indicar el Grupo Sanguineo")
    Else
      ErrAlumno.SetError(cbogrupoSang, "")
    End If

  End Sub

  Private Sub cbolengmat_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbolengmat.Validating
    If cbolengmat.SelectedIndex = -1 Then
      e.Cancel = True
      ErrAlumno.SetError(cbolengmat, "Debe indicar Lengua Materna")
    Else
      ErrAlumno.SetError(cbolengmat, "")
    End If

  End Sub

  Private Sub CLugarNac_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CDireccionActual.Validating
    If CDireccionActual.cbopais.Text.Length = 0 Then
      e.Cancel = True
      ErrAlumno.SetError(CDireccionActual.cbopais, "Debe indicar el Pais ")
    Else
      ErrAlumno.SetError(CDireccionActual.cbopais, "")
    End If

    If CDireccionActual.cbodpto.Text.Length = 0 Then
      e.Cancel = True
      ErrAlumno.SetError(CDireccionActual.cbodpto, "Debe indicar el Departamento ")
    Else
      ErrAlumno.SetError(CDireccionActual.cbodpto, "")
    End If

    If CDireccionActual.cbopPvcia.Text.Length = 0 Then
      e.Cancel = True
      ErrAlumno.SetError(CDireccionActual.cbopPvcia, "Debe indicar la Provincia ")
    Else
      ErrAlumno.SetError(CDireccionActual.cbopPvcia, "")
    End If

    If CDireccionActual.cbodistrito.Text.Length = 0 Then
      e.Cancel = True
      ErrAlumno.SetError(CDireccionActual.cbodistrito, "Debe indicar el Distrito ")
    Else
      ErrAlumno.SetError(CDireccionActual.cbodistrito, "")
    End If
  End Sub

  Private Sub txtmat_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtmat.Validating
    If txtmat.Text.Length = 0 Then
      e.Cancel = True
      ErrAlumno.SetError(txtmat, "Debe indicar Apellido Paterno")
    Else
      ErrAlumno.SetError(txtmat, "")
    End If
  End Sub

  Private Sub cbosexo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbosexo.Validating
    If cbosexo.SelectedIndex = -1 Then
      e.Cancel = True
      ErrAlumno.SetError(cbosexo, "Debe indicar el Sexo del Alumno")
    Else
      ErrAlumno.SetError(cbosexo, "")
    End If
  End Sub

  Private Sub txtnombre_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnombre.Leave
    AcceptButton = btnRegistrar
  End Sub

  Private Sub txtnombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtnombre.Validating
    If txtnombre.Text.Length = 0 Then
      e.Cancel = True
      ErrAlumno.SetError(txtnombre, "Debe indicar el Nombre del Alumno")
    Else
      ErrAlumno.SetError(txtnombre, "")
    End If
  End Sub

  Private Sub txtpat_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtpat.Validating
    If txtpat.Text.Length = 0 Then
      e.Cancel = True
      ErrAlumno.SetError(txtpat, "Debe indicar el Apellido Paterno")
    Else
      ErrAlumno.SetError(txtpat, "")
    End If
  End Sub

  Private Sub txtCodEducando_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodEducando.Validating
    If txtCodEducando.Text.Trim.Length > 0 Then
      If txtCodEducando.Text.Trim.Length < 14 Then
        e.Cancel = True
        ErrAlumno.SetError(txtCodEducando, "Debe indicar Codigo Educando (14 digitos)")
      Else
        ErrAlumno.SetError(txtCodEducando, "")
      End If
    End If
  End Sub

  Private Sub ControlUbicacionGeografica1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CLugarNac.Validating

    If CLugarNac.cbopais.Text.Length = 0 Then
      e.Cancel = True
      ErrAlumno.SetError(CLugarNac.cbopais, "Debe indicar el Pais ")
    Else
      ErrAlumno.SetError(CLugarNac.cbopais, "")
    End If

    If CLugarNac.cbodpto.Text.Length = 0 Then
      e.Cancel = True
      ErrAlumno.SetError(CLugarNac.cbodpto, "Debe indicar el Departamento ")
    Else
      ErrAlumno.SetError(CLugarNac.cbodpto, "")
    End If

    If CLugarNac.cbopPvcia.Text.Length = 0 Then
      e.Cancel = True
      ErrAlumno.SetError(CLugarNac.cbopPvcia, "Debe indicar la Provincia ")
    Else
      ErrAlumno.SetError(CLugarNac.cbopPvcia, "")
    End If

    If CLugarNac.cbodistrito.Text.Length = 0 Then
      e.Cancel = True
      ErrAlumno.SetError(CLugarNac.cbodistrito, "Debe indicar el Distrito ")
    Else
      ErrAlumno.SetError(CLugarNac.cbodistrito, "")
    End If

  End Sub

#End Region

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim objAlumno As RNAlumno
    Dim al As Alumno
    Dim codigoAlu As Integer = 0
    Dim sexo As String

    If Me.ValidateChildren() Then
      objAlumno = New RNAlumno
      If cbosexo.SelectedIndex = 0 Then
        sexo = "F"
      Else
        sexo = "M"
      End If

      If txtCodEducando.Text.Trim.Length = 0 Then
        txtCodEducando.Text = "00000000000000"
      End If

      Try
        If Codigo = 0 Then
          al = New Alumno(txtnombre.Text.Trim, txtpat.Text.Trim, txtmat.Text.Trim, sexo, dtpfechaN.Value, txtCodEducando.Text.Trim, _
                                         New UbicacionGeografica(CLugarNac.cbodistrito.Text, CLugarNac.cbopPvcia.Text, _
                                        CLugarNac.cbodpto.Text, CLugarNac.cbopais.Text), txtemail.Text.Trim, txtdireccion.Text, txttelefono.Text, _
                                        cbonacionalidad.Text, IIf(cbogrupoSang.Text = "No Precisa", "NP", cbogrupoSang.Text).ToString, cbolengmat.Text, txtmedcontra.Text, txtcolegproced.Text, New UbicacionGeografica( _
                                        CDireccionActual.cbodistrito.Text, CDireccionActual.cbopPvcia.Text, CDireccionActual.cbodpto.Text, CDireccionActual.cbopais.Text))
          al.DNI = Me.txtDNI.Text.Trim
          codigoAlu = objAlumno.Registrar(al)
          MessageBox.Show("El alumno se registró exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          If cerrar = 1 Then
            Alum = New Alumno(codigoAlu, Me.txtnombre.Text.Trim, Me.txtpat.Text.Trim, Me.txtmat.Text.Trim)
            Me.Close()
          End If
        Else
          al = New Alumno(Me.Codigo, txtnombre.Text.Trim, txtpat.Text.Trim, txtmat.Text.Trim, sexo, dtpfechaN.Value, txtCodEducando.Text.Trim, _
                                         New UbicacionGeografica(CLugarNac.cbodistrito.Text, CLugarNac.cbopPvcia.Text, _
                                        CLugarNac.cbodpto.Text, CLugarNac.cbopais.Text), txtemail.Text.Trim, txtdireccion.Text, txttelefono.Text, _
                                        cbonacionalidad.Text, IIf(cbogrupoSang.Text = "No Precisa", "NP", cbogrupoSang.Text).ToString, cbolengmat.Text, txtmedcontra.Text, txtcolegproced.Text, New UbicacionGeografica( _
                                        CDireccionActual.cbodistrito.Text, CDireccionActual.cbopPvcia.Text, CDireccionActual.cbodpto.Text, CDireccionActual.cbopais.Text))
          al.DNI = Me.txtDNI.Text.Trim
          objAlumno.Modificar(al)

          MessageBox.Show("Los datos se actualizaron exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'InicializarControles()
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        objAlumno = Nothing
      End Try
    End If
  End Sub

  Private Sub InicializarControles()
    Me.Codigo = 0
    Me.txtnombre.Text = ""
    Me.txtpat.Text = ""
    Me.txtmat.Text = ""
    Me.txtDNI.Text = ""
    Me.txtCodEducando.Text = ""
    Me.cbosexo.SelectedIndex = 1
    Me.txtemail.Text = ""
    Me.txtdireccion.Text = ""
    Me.txttelefono.Text = ""
    Me.txtmedcontra.Text = ""
    Me.txtcolegproced.Text = ""

    Me.cbogrupoSang.SelectedIndex = 0
    Me.cbolengmat.SelectedIndex = 0

    Me.CLugarNac.CargarPaises()
    Me.CLugarNac.cbopais.Text = "PERU"
    Me.CLugarNac.cbopais.Tag = "PERU"
    Me.CLugarNac.ListarDepartamentos()
    Me.CLugarNac.cbodpto.Text = "LAMBAYEQUE"
    Me.CLugarNac.cbodpto.Tag = "LAMBAYEQUE"
    Me.CLugarNac.ListarProvincias()
    Me.CLugarNac.cbopPvcia.Text = "CHICLAYO"
    Me.CLugarNac.cbopPvcia.Tag = "CHICLAYO"
    Me.CLugarNac.ListarDistritos()
    Me.CLugarNac.cbodistrito.Text = "CHICLAYO"
    Me.CLugarNac.cbodistrito.Tag = "CHICLAYO"

    Me.CDireccionActual.CargarPaises()
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

    btnRegistrar.Text = "&Registrar"
    txtnombre.Focus()
  End Sub
  Private Sub CDireccionActual_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupBoxDP.Enter
    cbonacionalidad.Text = CLugarNac.cbopais.Text
  End Sub

  Private Sub frmAlumno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    If e.KeyCode = Keys.F3 Then
      BuscarAlumnosTeclasrapidas()
      e.Handled = True
    End If
  End Sub

  Private Sub frmAlumno_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    CLugarNac.CargarPaises()
    CDireccionActual.CargarPaises()
    'Me.txtnombre.CharacterCasing = CharacterCasing.Upper
    Me.txtpat.CharacterCasing = CharacterCasing.Upper
    Me.txtmat.CharacterCasing = CharacterCasing.Upper
    Me.txtdireccion.CharacterCasing = CharacterCasing.Upper
    Me.txtmedcontra.CharacterCasing = CharacterCasing.Upper
    Me.txtcolegproced.CharacterCasing = CharacterCasing.Upper
    'Me.txtCodEducando.Text = "00000000000000"
    Me.btnNuevo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Nuevo.png")
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    InicializarControles()
    Me.btnBuscar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Buscar.png")
    Me.btnpadres.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\padres.png")
    Me.cbonacionalidad.Text = CDireccionActual.cbopais.Text

    txtnombre.Focus()
    Codigo = 0
  End Sub

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    InicializarControles()
    Me.txtnombre.Focus()
  End Sub
  Private Sub BuscarAlumnosTeclasrapidas()
    Dim a As Alumno = Nothing
    Dim frmbuscar As New frmBuscarAlumno_new
    Dim obj As RNAlumno = Nothing

    a = frmbuscar.Buscar
    frmbuscar.Dispose()
    frmbuscar = Nothing

    InicializarControles()
    mostrarDatos(a)
  End Sub

  Private Sub mostrarDatos(ByVal wAlumno As Alumno)
    Dim obj As RNAlumno

    If wAlumno IsNot Nothing Then
      obj = New RNAlumno
      wAlumno = obj.Leer(wAlumno)
      obj = Nothing
      Alum = wAlumno
      Codigo = Alum.Codigo
      txtnombre.Text = Alum.Nombre
      txtpat.Text = Alum.ApellidoPaterno
      txtmat.Text = Alum.ApellidoMaterno
      Me.txtDNI.Text = Alum.DNI
      With Alum.CodigoEducando
        If .Chars(0) & .Chars(1) & .Chars(2) & .Chars(3) = "0000" Then
          Me.txtCodEducando.Text = ""
        Else
          Me.txtCodEducando.Text = Alum.CodigoEducando
        End If
      End With
      If Alum.Sexo = "M" Then
        cbosexo.SelectedIndex = 1
      Else
        cbosexo.SelectedIndex = 0
      End If
      Me.dtpfechaN.Value = Alum.FechaNacimiento
      Me.CLugarNac.cbopais.Text = Alum.LugarNacimiento.Pais
      Me.CLugarNac.cbodpto.Text = Alum.LugarNacimiento.Departamento
      Me.CLugarNac.cbopPvcia.Text = Alum.LugarNacimiento.Provincia
      Me.CLugarNac.cbodistrito.Text = Alum.LugarNacimiento.Distrito

      Me.txtemail.Text = Alum.Email
      Me.txtdireccion.Text = Alum.Direccion
      Me.txttelefono.Text = Alum.Telefono

      cbonacionalidad.Text = Alum.Nacionalidad
      If Alum.GrupoSanguineo = "NP" Then
        cbogrupoSang.SelectedIndex = 0
      Else
        cbogrupoSang.Text = Alum.GrupoSanguineo
      End If

      cbolengmat.Text = Alum.LenguaMaterna
      txtcolegproced.Text = Alum.ColegioProcedencia
      txtmedcontra.Text = Alum.MedicinasContraindicadas
      CDireccionActual.cbopais.Text = Alum.DireccionActual.Pais
      CDireccionActual.cbodpto.Text = Alum.DireccionActual.Departamento
      CDireccionActual.cbopPvcia.Text = Alum.DireccionActual.Provincia
      CDireccionActual.cbodistrito.Text = Alum.DireccionActual.Distrito

      Me.txtnombre.Focus()

      Me.btnRegistrar.Text = "&Actualizar"
      Me.btnpadres.Visible = True
    End If

  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Me.BuscarAlumnosTeclasrapidas()
  End Sub

  Private Sub btnpadres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpadres.Click
    Dim frmApod As New frmGestionApoderado

    frmApod.CodigoAlumno = Alum.Codigo
    frmApod.CambiarEstado(True, False)

    frmApod.ShowDialog(Me)
  End Sub

  Public Function RegistrarAlu(ByVal estado As Integer) As Alumno
    cerrar = estado
    Me.ShowDialog()
    Return Alum
  End Function

  Public Function modificar(ByVal wAlumno As Alumno) As Alumno
    cerrar = True

    Me.Show()
    InicializarControles()
    Me.mostrarDatos(wAlumno)

    Return Alum
  End Function


  Private Sub btnNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    InicializarControles()
  End Sub

  Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click

  End Sub

  Private Sub txttelefono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefono.KeyPress
    If Char.IsDigit(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False AndAlso _
       e.KeyChar <> "#"c AndAlso e.KeyChar <> "*"c AndAlso e.KeyChar <> "-"c Then

      e.Handled = True
    End If
  End Sub
End Class