
Public Class frmGestionDocente
  Private Codigo As Integer
  Private cadFinal As String

  Private Sub frmDocente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    If e.KeyCode = Keys.F5 Then
      Buscar()
      e.Handled = True
    End If
  End Sub

  Private Sub frmDocente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnGuardar.Text = "&Registrar"
    Me.txtDireccion.CharacterCasing = CharacterCasing.Upper
    Me.btnGuardar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnBuscar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Buscar.png")

    Me.LimpiarDatos()
  End Sub

  Public Sub IniciarCombo()
    Dim obj As New RNEspecialidad
    Dim le As List(Of Especialidad)
    le = obj.ListarEsp

    Me.cboEspecialidad.DisplayMember = "Nombre"
    Me.cboEspecialidad.ValueMember = "Especialidades"
    Me.cboEspecialidad.DataSource = le
  End Sub

  Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress, txtApePat.KeyPress, txtApeMat.KeyPress, cboEspecialidad.KeyPress
    If Char.IsLetter(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False And _
            Char.IsSeparator(e.KeyChar) = False AndAlso e.KeyChar <> "'"c Then
      e.Handled = True
    End If
  End Sub

  Private Sub txtCelular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCelular.KeyPress, txtNroDoc.KeyPress
    If Not (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) And Not (Asc(e.KeyChar) = 8) Then
      e.Handled = True
    End If
  End Sub

  Private Sub cboGrado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboGrado.Validating
    ValidarCombo(e, Me.cboGrado, "Debe indicar el grado del docente")
  End Sub

  Private Sub cboEspecialidad_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboEspecialidad.Validating
    If Me.cboEspecialidad.Text = "" Then
      e.Cancel = True
      errValida.SetError(Me.cboEspecialidad, "Debe indicar la especialidad del Docente")
    Else
      errValida.SetError(Me.cboEspecialidad, Nothing)
    End If
  End Sub

  Private Sub cbotipoDoc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoDoc.Leave
    If cboTipoDoc.Text = "DNI" Then
      txtNroDoc.MaxLength = 8
    Else
      txtNroDoc.MaxLength = 11
    End If
  End Sub

  Private Sub txtDNI_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNroDoc.Validating
    If txtNroDoc.Text.Length = 0 And txtNroDoc.Text.Length < 11 Then
      e.Cancel = True
      errValida.SetError(txtNroDoc, "Debe indicar Nro de documento")
    Else
      errValida.SetError(txtNroDoc, "")
    End If
  End Sub

  Private Sub txtNombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
    ValidarText(e, Me.txtNombre, "Debe indicar el nombre del Docente")
  End Sub

  Private Sub txtApePat_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtApePat.Validating
    ValidarText(e, Me.txtApePat, "Debe indicar el apellido paterno del Docente")
  End Sub

  Private Sub txtApeMat_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtApeMat.Validating
    ValidarText(e, Me.txtApeMat, "Debe indicar el apellido materno del Docente")
  End Sub

  Private Sub cboSexo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboSexo.Validating
    ValidarCombo(e, Me.cboSexo, "Debe indicar el sexo del Docente")
  End Sub

  Private Sub txtDireccion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDireccion.Validating
    ValidarText(e, Me.txtDireccion, "Debe indicar la dirección del Docente")
  End Sub

  Private Sub ValidarText(ByVal e As System.ComponentModel.CancelEventArgs, ByVal cadena As System.Windows.Forms.TextBox, ByVal msj As String)
    If cadena.Text.Length = 0 Then
      e.Cancel = True
      errValida.SetError(cadena, msj)
    Else
      errValida.SetError(cadena, Nothing)
    End If
  End Sub

  Private Sub ValidarCombo(ByVal e As System.ComponentModel.CancelEventArgs, ByVal opcion As ComboBox, ByVal msj As String)
    If opcion.SelectedIndex = -1 Then
      e.Cancel = True
      errValida.SetError(opcion, msj)
    Else
      errValida.SetError(opcion, Nothing)
    End If
  End Sub

  Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    Dim objD As RNDocente
    Dim objE As RNEspecialidad
    Dim tipoDoc As String = ""
    Dim sexo As String

    If Me.ValidateChildren Then
      objD = New RNDocente
      objE = New RNEspecialidad

      Try
        If cboSexo.SelectedIndex = 0 Then
          sexo = "F"
        Else
          sexo = "M"
        End If

        Select Case cboTipoDoc.Text
          Case "DNI"
            tipoDoc = "DN"
          Case "Carnet Extranjería"
            tipoDoc = "CE"
          Case "Libreta Electoral"
            tipoDoc = "LE"
          Case "Libreta Militar"
            tipoDoc = "LM"
          Case "Pasaporte"
            tipoDoc = "PA"
          Case "Carnet Policial"
            tipoDoc = "CP"
        End Select
        If Codigo = 0 Then
          objD.Registrar(New Docente(Me.txtNombre.Text.Trim, Me.txtApePat.Text.Trim, _
                                   Me.txtApeMat.Text.Trim, sexo, Me.dtpFechaNac.Value, tipoDoc, Me.txtNroDoc.Text.Trim, _
                                   Me.txtEmail.Text.Trim, Me.txtCelular.Text.Trim, 0, Me.cboGrado.Text.Trim, Me.txtDireccion.Text.Trim), New Especialidad(Nothing, cboEspecialidad.Text))
          MessageBox.Show("Docente registrado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

          'LimpiarDatos()
          Me.cboGrado.Focus()
        Else
          objD.Modificar(New Docente(Me.Codigo, Me.txtNombre.Text.Trim, Me.txtApePat.Text.Trim, Me.txtApeMat.Text.Trim, _
                                   sexo, Me.dtpFechaNac.Value, Me.txtEmail.Text.Trim, tipoDoc, Me.txtNroDoc.Text.Trim, Me.txtCelular.Text.Trim, _
                                   Me.cboGrado.Text, 0, cboEspecialidad.Text, Me.txtDireccion.Text.Trim))
          MessageBox.Show("Los datos del docente fueron actualizados exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

          Me.cboGrado.Focus()

        End If
        LimpiarDatos()
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        objD = Nothing
      End Try
    End If
  End Sub

  Public Sub LimpiarDatos()
    Dim fecha As New DateTime(1978, 5, 15)

    Me.txtNombre.Text = ""
    Me.cboGrado.SelectedIndex = 2
    Me.cboTipoDoc.SelectedIndex = 0
    Me.txtNroDoc.Text = ""
    Me.txtApePat.Text = ""
    Me.txtApeMat.Text = ""
    Me.dtpFechaNac.Value = fecha
    Me.cboSexo.SelectedIndex = 1
    Me.txtCelular.Text = ""
    Me.txtEmail.Text = ""
    Me.txtDireccion.Text = ""
    IniciarCombo()
    Me.cboEspecialidad.SelectedIndex = -1
    Me.btnGuardar.Text = "&Registrar"
    Me.Codigo = 0
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Buscar()
  End Sub

  Private Sub Buscar()
    Dim objDoc As New RNDocente
    Dim Doc, d As Docente
    Dim frm As frmBuscarDocente
    Dim objE As RNEspecialidad

    frm = New frmBuscarDocente
    d = frm.Buscar
    frm.Dispose()
    frm = Nothing

    If d IsNot Nothing Then
      Doc = objDoc.Leer(d)
      objE = New RNEspecialidad
      Codigo = Doc.Codigo
      txtNroDoc.Text = Doc.NumeroDocumento
      Select Case Doc.TipoDocumento
        Case "DN"
          cboTipoDoc.Text = "DNI"
        Case "CE"
          cboTipoDoc.Text = "Carnet Extranjería"
        Case "LE"
          cboTipoDoc.Text = "Libreta Electoral"
        Case "LM"
          cboTipoDoc.Text = "Libreta Militar"
        Case "PA"
          cboTipoDoc.Text = "Pasaporte"
        Case "CP"
          cboTipoDoc.Text = "Carnet Policial"
      End Select
      txtNombre.Text = Doc.Nombre
      txtApePat.Text = Doc.ApellidoPaterno
      txtApeMat.Text = Doc.ApellidoMaterno
      cboGrado.Text = Doc.Grado
      txtDireccion.Text = Doc.Direccion
      cboEspecialidad.Text = objE.RetornaNom(New Especialidad(Doc.Especialidad.Codigo, "")) 'enviar codigo para q me envie el nombre
      If Doc.Sexo = "M" Then
        cboSexo.SelectedIndex = 1
      Else
        cboSexo.SelectedIndex = 0
      End If
      dtpFechaNac.Value = Doc.FechaNacimiento
      txtCelular.Text = Doc.Celular
      txtEmail.Text = Doc.Email
      Me.btnGuardar.Text = "&Actualizar"
    End If
  End Sub

  Private Sub cboEspecialidad_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboEspecialidad.Leave
    cadFinal = Me.cboEspecialidad.Text.Trim
    Me.cboEspecialidad.Text = UCase(Me.cboEspecialidad.Text.Trim)
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    LimpiarDatos()

    Me.cboGrado.Focus()
    errValida.SetError(Me.cboEspecialidad, Nothing)
    errValida.SetError(Me.txtNroDoc, Nothing)
    errValida.SetError(Me.txtNombre, Nothing)
    errValida.SetError(Me.txtApePat, Nothing)
    errValida.SetError(Me.txtApeMat, Nothing)
    errValida.SetError(Me.txtDireccion, Nothing)
  End Sub

  'Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
  '  Dim objD As RNDocente
  '  Dim objE As RNEspecialidad
  '  Dim tipoDoc As String = ""
  '  Dim sexo As Boolean

  '  If Me.ValidateChildren Then
  '    objD = New RNDocente
  '    objE = New RNEspecialidad
  '    Try
  '      If cboSexo.SelectedIndex = 0 Then
  '        sexo = False
  '      Else
  '        sexo = True
  '      End If

  '      Select Case cboTipoDoc.Text
  '        Case "DNI"
  '          tipoDoc = "DN"
  '        Case "Carnet Extranjería"
  '          tipoDoc = "CE"
  '        Case "Libreta Electoral"
  '          tipoDoc = "LE"
  '        Case "Libreta Militar"
  '          tipoDoc = "LM"
  '        Case "Pasaporte"
  '          tipoDoc = "PA"
  '        Case "Carnet Policial"
  '          tipoDoc = "CP"
  '      End Select

  '      Dim especialidad As String = Me.cboEspecialidad.Text
  '      objD.Modificar(New Docente(Me.Codigo, Me.txtNombre.Text.Trim, Me.txtApePat.Text.Trim, Me.txtApeMat.Text.Trim, _
  '                                 sexo, Me.dtpFechaNac.Value, Me.txtEmail.Text.Trim, tipoDoc, Me.txtNroDoc.Text.Trim, Me.txtCelular.Text.Trim, _
  '                                 Me.cboGrado.Text, 0, especialidad, Me.txtDireccion.Text.Trim))
  '      MessageBox.Show("Los datos del Docente fueron actualizados exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
  '      LimpiarDatos()
  '      Me.cboGrado.Focus()
  '    Catch ex As Exception
  '      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
  '    Finally
  '      objD = Nothing
  '      objE = Nothing
  '    End Try
  '  End If
  'End Sub

End Class