Public Class frmDatosPersonales

  '  Private padre As Apoderado
  '  Private madre As Apoderado
  '  Private paterno As String
  '  Private materno As String
  '  Private mcodigoAlumno As Integer
  '  Private codigo As Integer

  '  Private cod As String

  '  Public Property CodigoAlumno() As Integer
  '    Get
  '      Return mcodigoAlumno
  '    End Get
  '    Set(ByVal value As Integer)
  '      mcodigoAlumno = value
  '    End Set
  '  End Property

  '#Region "validacion"
  '  'Private Sub txttelefono_Validating1(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txttelefono.Validating
  '  '    If txttelefono.Text.Length = 0 Then
  '  '        e.Cancel = True
  '  '        ErrDP.SetError(txttelefono, "Debe indicar Telefono")
  '  '    Else
  '  '        ErrDP.SetError(txttelefono, "")
  '  '    End If
  '  'End Sub

  '  'Private Sub txtemail_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtemail.Validating
  '  '    If txtemail.Text.Length = 0 Then
  '  '        e.Cancel = True
  '  '        ErrDP.SetError(txtemail, "Debe indicar El Email")
  '  '    Else
  '  '        ErrDP.SetError(txtemail, "")
  '  '    End If
  '  'End Sub

  '  'Private Sub txtmedcontra_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtmedcontra.Validating
  '  '    If txtmedcontra.Text.Length = 0 Then
  '  '        e.Cancel = True
  '  '        ErrDP.SetError(txtmedcontra, "Debe Medicinas Contraindicadas")
  '  '    Else
  '  '        ErrDP.SetError(txtmedcontra, "")
  '  '    End If
  '  'End Sub
  '  'Private Sub txtcolegproced_Validating1(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtcolegproced.Validating
  '  '    If txtcolegproced.Text.Length = 0 Then
  '  '        e.Cancel = True
  '  '        ErrDP.SetError(txtcolegproced, "Debe Medicinas Contraindicadas")
  '  '    Else
  '  '        ErrDP.SetError(txtcolegproced, "")
  '  '    End If
  '  'End Sub
  '  Private Sub txtPadre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPadre.Validating
  '    If txtPadre.Text.Length = 0 Then
  '      e.Cancel = True
  '      ErrDP.SetError(txtPadre, "Debe indicar el Padre dela Alumno")
  '    Else
  '      ErrDP.SetError(txtPadre, "")
  '    End If
  '  End Sub


  '  Private Sub txtMadre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMadre.Validating
  '    If txtMadre.Text.Length = 0 Then
  '      e.Cancel = True
  '      ErrDP.SetError(txtMadre, "Debe indicar la Madre dela Alumno")
  '    Else
  '      ErrDP.SetError(txtMadre, "")
  '    End If
  '  End Sub

  '  Private Sub txtdireccion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtdireccion.Validating
  '    If txtdireccion.Text.Length = 0 Then
  '      e.Cancel = True
  '      ErrDP.SetError(txtdireccion, "Debe indicar La Dirección")
  '    Else
  '      ErrDP.SetError(txtdireccion, "")
  '    End If
  '  End Sub

  '  Private Sub cbonacionalidad_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbonacionalidad.Validating
  '    If cbonacionalidad.SelectedIndex = -1 Then
  '      e.Cancel = True
  '      ErrDP.SetError(cbonacionalidad, "Debe indicar Nacionalidad")
  '    Else
  '      ErrDP.SetError(cbonacionalidad, "")
  '    End If
  '  End Sub

  '  Private Sub cbogrupoSang_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbogrupoSang.Validating
  '    If cbogrupoSang.SelectedIndex = -1 Then
  '      e.Cancel = True
  '      ErrDP.SetError(cbogrupoSang, "Debe indicar el Grupo Sanguineo")
  '    Else
  '      ErrDP.SetError(cbogrupoSang, "")
  '    End If

  '  End Sub

  '  Private Sub cbolengmat_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbolengmat.Validating
  '    If cbolengmat.SelectedIndex = -1 Then
  '      e.Cancel = True
  '      ErrDP.SetError(cbolengmat, "Debe indicar Lengua Materna")
  '    Else
  '      ErrDP.SetError(cbolengmat, "")
  '    End If

  '  End Sub
  '  Private Sub txtcolegproced_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtcolegproced.Validating
  '    If txtcolegproced.Text.Length = 0 Then
  '      e.Cancel = True
  '      ErrDP.SetError(txtcolegproced, "Debe indicar el Colegio de Procedencia")
  '    Else
  '      ErrDP.SetError(txtcolegproced, "")
  '    End If
  '  End Sub

  '  Private Sub CLugarNac_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CLugarNac.Validating
  '    If CLugarNac.cbopais.Text.Length = 0 Then
  '      e.Cancel = True
  '      ErrDP.SetError(CLugarNac.cbopais, "Debe indicar el Pais ")
  '    Else
  '      ErrDP.SetError(CLugarNac.cbopais, "")
  '    End If

  '    If CLugarNac.cbodpto.Text.Length = 0 Then
  '      e.Cancel = True
  '      ErrDP.SetError(CLugarNac.cbodpto, "Debe indicar el Departamento ")
  '    Else
  '      ErrDP.SetError(CLugarNac.cbodpto, "")
  '    End If

  '    If CLugarNac.cbopPvcia.Text.Length = 0 Then
  '      e.Cancel = True
  '      ErrDP.SetError(CLugarNac.cbopPvcia, "Debe indicar la Provincia ")
  '    Else
  '      ErrDP.SetError(CLugarNac.cbopPvcia, "")
  '    End If

  '    If CLugarNac.cbodistrito.Text.Length = 0 Then
  '      e.Cancel = True
  '      ErrDP.SetError(CLugarNac.cbodistrito, "Debe indicar el Distrito ")
  '    Else
  '      ErrDP.SetError(CLugarNac.cbodistrito, "")
  '    End If
  '  End Sub
  '#End Region

  '#Region "Control de Teclas"
  '  Private Sub txtmedcontra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmedcontra.KeyPress
  '    If Char.IsLetter(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False And _
  '        Char.IsSeparator(e.KeyChar) = False AndAlso e.KeyChar <> "'"c AndAlso Char.IsDigit(e.KeyChar) = False Then
  '      e.Handled = True
  '    End If
  '  End Sub
  '  Private Sub txttelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefono.KeyPress
  '    If Char.IsDigit(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False Then
  '      e.Handled = True
  '    End If
  '  End Sub
  '#End Region

  '  Private Sub InicializarControles()
  '    Me.codigo = 0
  '    Me.txtAlumno.Text = ""
  '    Me.txtPadre.Text = ""
  '    Me.txtMadre.Text = ""
  '    Me.txtemail.Text = ""
  '    Me.txtdireccion.Text = ""
  '    Me.txttelefono.Text = ""
  '    Me.txtmedcontra.Text = ""
  '    Me.txtcolegproced.Text = ""

  '    Me.txtdireccion.CharacterCasing = CharacterCasing.Upper
  '    Me.txtmedcontra.CharacterCasing = CharacterCasing.Upper
  '    Me.txtcolegproced.CharacterCasing = CharacterCasing.Upper

  '    Me.cbonacionalidad.SelectedIndex = 0
  '    Me.cbolengmat.SelectedIndex = 0

  '    Me.cbogrupoSang.SelectedIndex = -1

  '    btnRegistrar.Text = "&Registrar"
  '    btnregPadre.Focus()
  '  End Sub

  '  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
  '    If Me.ValidateChildren() Then
  '      Dim objAlumno As New RNAlumno
  '      Try

  '        If codigo = 0 Then
  '          objAlumno.RegistrarDatosPers(New Alumno(CodigoAlumno, txtemail.Text.Trim, txtdireccion.Text.Trim, txttelefono.Text.Trim, _
  '                              cbonacionalidad.Text.Trim, cbogrupoSang.Text.Trim, cbolengmat.Text.Trim, txtmedcontra.Text, txtcolegproced.Text, New UbicacionGeografica(CLugarNac.cbodistrito.Text, CLugarNac.cbopPvcia.Text, _
  '                              CLugarNac.cbodpto.Text, CLugarNac.cbopais.Text)), New Parentesco(padre, "Padre"), New Parentesco(madre, "Madre"))

  '          MessageBox.Show("Los Datos Personales se registraron exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
  '        Else
  '          objAlumno.ModificarDatosPersonales(New Alumno(CodigoAlumno, txtemail.Text.Trim, txtdireccion.Text.Trim, txttelefono.Text.Trim, _
  '                              cbonacionalidad.Text.Trim, cbogrupoSang.Text.Trim, cbolengmat.Text.Trim, txtmedcontra.Text, txtcolegproced.Text, New UbicacionGeografica(CLugarNac.cbodistrito.Text, CLugarNac.cbopPvcia.Text, _
  '                              CLugarNac.cbodpto.Text, CLugarNac.cbopais.Text)), New Parentesco(padre, "Padre"), New Parentesco(madre, "Madre"))

  '          MessageBox.Show("Los datos se actualizaron exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
  '        End If
  '        Me.Close()
  '        InicializarControles()
  '      Catch ex As Exception
  '        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
  '      Finally
  '        objAlumno = Nothing
  '      End Try
  '    End If
  '  End Sub

  '  Private Sub LeerAlumno(ByVal codigoAlum As Integer)
  '    Dim obj As New RNAlumno
  '    Dim A As Alumno = Nothing
  '    If codigoAlum > 0 Then
  '      A = obj.Leer(New Alumno(codigoAlum))
  '      txtAlumno.Text = A.NombreCompleto
  '      paterno = A.ApellidoPaterno
  '      materno = A.ApellidoMaterno
  '    End If
  '  End Sub

  '  Public Sub Modificar(ByVal A As Alumno)
  '    Dim obj As RNAlumno = Nothing
  '    Dim objPadres As New RNApoderado
  '    Dim objmadres As New RNApoderado
  '    Dim P As Apoderado = Nothing
  '    Dim M As Apoderado = Nothing

  '    LeerAlumno(A.Codigo)
  '    codigo = A.Codigo

  '    P = objPadres.ListarPadres_Alumno(A.Codigo)
  '    M = objmadres.ListarMadres_Alumno(A.Codigo)

  '    padre = P
  '    madre = M
  '    txtPadre.Text = P.NombreCompleto
  '    txtMadre.Text = M.NombreCompleto

  '    txtemail.Text = A.Email
  '    txtdireccion.Text = A.Direccion
  '    txttelefono.Text = A.Telefono

  '    cbonacionalidad.Text = A.Nacionalidad
  '    cbogrupoSang.Text = A.GrupoSanguineo

  '    cbolengmat.Text = A.LenguaMaterna
  '    txtcolegproced.Text = A.ColegioProcedencia
  '    txtmedcontra.Text = A.MedicinasContraindicadas
  '    CLugarNac.cbopais.Text = A.LugarNacimiento.Pais
  '    CLugarNac.cbodpto.Text = A.LugarNacimiento.Departamento
  '    CLugarNac.cbopPvcia.Text = A.LugarNacimiento.Provincia
  '    CLugarNac.cbodistrito.Text = A.LugarNacimiento.Distrito
  '    btnRegistrar.Text = "&Actualizar"
  '    btnregPadre.Text = "&Cambiar"
  '    btnRegMadre.Text = "&Cambiar"
  '    txtemail.Focus()
  '  End Sub

  '  Private Sub btnregPadre_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregPadre.Click
  '    Dim frmApod As New frmApoderado
  '    Dim frmbuscarAPod As New frmBuscarApoderadoNew
  '    Dim ap As Apoderado

  '    If btnregPadre.Text = "&Cambiar" Then
  '      frmbuscarAPod.BuaP.txtNombreBuscar.Text = paterno
  '      frmBuscarApoderadoNew.ShowDialog()
  '    End If
  '    ap = frmApod.Registrar(1)
  '    frmApod.Dispose()
  '    frmApod = Nothing
  '    If ap IsNot Nothing Then
  '      padre = ap
  '      txtPadre.Text = padre.NombreCompleto
  '    End If
  '  End Sub

  '  Private Sub btnRegMadre_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegMadre.Click
  '    Dim frmApod As New frmApoderado
  '    Dim frmbuscarAPod As New frmBuscarApoderadoNew

  '    Dim ap As Apoderado

  '    If btnregPadre.Text = "&Cambiar" Then
  '      frmbuscarAPod.BuaP.txtNombreBuscar.Text = materno
  '      frmBuscarApoderadoNew.ShowDialog(Me)
  '      ap = frmbuscarAPod.BuscarApoderado
  '    End If
  '    ap = frmApod.Registrar(0)
  '    frmApod.Dispose()
  '    frmApod = Nothing
  '    If ap IsNot Nothing Then
  '      madre = ap
  '      txtMadre.Text = madre.NombreCompleto
  '    End If

  '  End Sub

  '  Private Sub frmDatosPersonales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
  '    LeerAlumno(CodigoAlumno)

  '    Me.txtdireccion.CharacterCasing = CharacterCasing.Upper
  '    Me.txtmedcontra.CharacterCasing = CharacterCasing.Upper
  '    Me.txtcolegproced.CharacterCasing = CharacterCasing.Upper
  '    Me.cbonacionalidad.SelectedIndex = 0
  '    Me.cbolengmat.SelectedIndex = 0
  '    Me.cbogrupoSang.SelectedIndex = 0
  '    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
  '    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
  '    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
  '    Me.btnregPadre.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Buscar.png")
  '    Me.btnRegMadre.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Buscar.png")

  '    Me.txtemail.Focus()
  '  End Sub


  '  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
  '    Me.Close()
  '  End Sub
End Class