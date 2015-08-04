
Public Class frmGestionMatricula

  Private est As Boolean = False
  Private codigoEstado As Integer = 0
  Private matModif As New Matricula
  Private al As Alumno
  Private ap As New Parentesco
  Private par As New Parentesco
  Private exist As Boolean
  Private sw As Integer = 0

  Private Sub frmGestionarMatricula_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    If e.KeyCode = Keys.F5 Then
      Buscar()
      e.Handled = True
    ElseIf e.KeyCode = Keys.F6 Then
      Matriculados()
    ElseIf e.KeyCode = Keys.Enter Then
      Registrar()
    End If
  End Sub

  Private Sub frmGestionarMatricula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnBuscarAlumno.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Buscar.png")
    Me.btnNuevoApo.Enabled = False
    Me.cargarcbanio()
    Me.cargarcboNivelAcademico()
    Me.cargarcboSeccion()
    Me.cboSeccion.SelectedIndex = -1
    Me.cboNivel.SelectedIndex = -1
    Me.est = True
  End Sub

  Public Sub cargarcbanio()
    Dim ListAn As New List(Of AnioLectivo)
    Dim objAn As New RNAnioLectivo
    Dim ale As New AnioLectivo

    ale.vigencia = True
    ListAn = objAn.Leer(ale)
    cbanio.DisplayMember = "anio"
    cbanio.ValueMember = "anio"
    cbanio.DataSource = ListAn
    cbanio.SelectedIndex = ListAn.Count - 1
    ListAn = Nothing
  End Sub

  Public Sub cargarcboNivelAcademico()
    Dim ListNa As List(Of Nivel)
    Dim objNa As New RNNivel

    ListNa = objNa.Listar()
    cboNivel.DisplayMember = "nombre"
    cboNivel.ValueMember = "codigo"
    cboNivel.DataSource = ListNa
    ListNa = Nothing
  End Sub

  Public Sub cargarcboSeccion()
    Dim ListSec As List(Of Seccion) 'new 
    Dim objS As New RNSeccion

    If CType(Me.cboNivel.SelectedItem, Nivel) IsNot Nothing Then
      ListSec = objS.Leer_NivelAcad(CType(cbanio.SelectedItem, AnioLectivo), CType(cboNivel.SelectedItem, Nivel), 1)
      cboSeccion.DisplayMember = "numeroletra"
      cboSeccion.ValueMember = "codigoG"
      cboSeccion.DataSource = ListSec
      ListSec = Nothing
    End If
  End Sub

  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboNivel.SelectedIndexChanged
    If est = True Then
      Me.cargarcboSeccion()
    End If
  End Sub

  Private Sub cbanio_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbanio.SelectedIndexChanged
    If est = True Then
      Me.cargarcboSeccion()
    End If
  End Sub

  Private Sub btnBuscarAlumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarAlumno.Click
    Buscar()
  End Sub

  Private Sub Buscar()
    Dim frm As New frmBuscarAlumno
    Dim obj As RNMatriculaPosible
    Dim oMat As RNMatricula
    Dim auxal As New Alumno
    Dim mat As MatriculaPosible
    Dim matAct As Matricula

    auxal = frm.Buscar()
    frm.Dispose()
    frm = Nothing
    If auxal.Codigo <> 0 Then
      al = auxal
      oMat = New RNMatricula
      matAct = oMat.Leer(auxal, moAnioActual)
      oMat = Nothing
      If matAct Is Nothing Then
        Me.codigoEstado = 0
        Me.btnRegistrar.Text = "&Matricular"

        Me.txtAlumno.Text = al.NombreCompleto
        Me.LlenarDatosApoderado(al.Codigo)
        obj = New RNMatriculaPosible
        mat = obj.Leer(auxal, moAnioActual)
        obj = Nothing
        If mat IsNot Nothing Then
          Me.cboTipo.SelectedIndex = 1
          Me.cboNivel.SelectedValue = mat.Seccion.Grado.Nivel.Codigo
          Me.cboSeccion.Text = mat.Seccion.NumeroLetra
          Me.cboApoderado.SelectedValue = mat.Apoderado.CodigoApoderado
          Me.ap = DirectCast(Me.cboApoderado.SelectedItem, Parentesco)
          sw = 1
        Else
          If Me.cboApoderado.Items.Count > 0 Then
            ap = CType(Me.cboApoderado.SelectedItem, Parentesco)
          Else
            ap = Nothing
          End If
          Me.cboTipo.SelectedIndex = 0
          Me.cboNivel.SelectedIndex = -1
          Me.cboSeccion.SelectedIndex = -1
          MessageBox.Show("Debe indicar el nivel y sección en que se matriculará", Me.Text, MessageBoxButtons.OK)
          Me.cboNivel.Focus()
        End If
        Me.btnNuevoApo.Enabled = True
      Else
        If MessageBox.Show("El alumno ya ha sido matriculado" & vbNewLine & _
                        "¿Desea ver los datos de la matrícula?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

          Me.codigoEstado = 1
          Me.matModif = matAct
          Me.txtAlumno.Text = al.NombreCompleto
          Select Case matAct.TipoMatricula.Trim
            Case "I"
              cboTipo.SelectedIndex = 0
            Case "P"
              cboTipo.SelectedIndex = 1
            Case "R"
              cboTipo.SelectedIndex = 2
            Case "RE"
              cboTipo.SelectedIndex = 3
            Case "RI"
              cboTipo.SelectedIndex = 4
          End Select
          LlenarDatosApoderado(al.Codigo)
          Me.cboApoderado.SelectedValue = matAct.codigoApoderado.Codigo
          Me.ap = DirectCast(Me.cboApoderado.SelectedItem, Parentesco)
          Me.btnNuevoApo.Enabled = True

          cboNivel.SelectedValue = matAct.Grado.Nivel.Codigo
          cboSeccion.Text = matAct.Grado.Numero & " '" & matAct.Letra & "'"
          Me.btnRegistrar.Text = "&Actualizar"
        Else
          Me.btnRegistrar.Text = "&Matricular"
        End If
      End If
    Else
      Me.txtAlumno.Text = ""
    End If
  End Sub

  Public Sub LlenarDatosApoderado(ByVal codigo As Integer)
    Dim obj As New RNApoderado
    Dim P As New List(Of Parentesco)

    P = obj.ListarParentesco(codigo)
    cboApoderado.DisplayMember = "NombreCompleto"
    cboApoderado.ValueMember = "NombreCompleto"
    cboApoderado.DataSource = P
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Registrar()
  End Sub

  Private Sub Registrar()
    Dim objMat As RNMatricula
    Dim sec As Seccion
    Dim mat As Matricula

    If Me.ValidateChildren Then
      ap = CType(Me.cboApoderado.SelectedItem, Parentesco)
      Try
        If Me.txtAlumno.Text <> "" And Me.cboApoderado.Text <> "" Then
          objMat = New RNMatricula
          sec = CType(Me.cboSeccion.SelectedItem, Seccion)

          If Me.codigoEstado = 0 Then
            mat = New Matricula(DateAndTime.Now, sec.Grado, al, _
                                New Personal(mOUsuario.Persona.Codigo), _
                                sec.Anio, sec.Letra, True, 0, 0, 0, 0, al, _
                                ap, "IN")
            mat.TipoMatricula = CodigoTipoMatricula()

            objMat.Registrar(mat, ap)
            MessageBox.Show("La matrícula se registró exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          Else
            mat = New Matricula(matModif.Numero, DateAndTime.Now, sec.Grado, al, New Personal(mOUsuario.Persona.Codigo), sec.Anio, sec.Letra, True, 0.0, 0, 0, 0, al, ap)
            objMat.Modificar(mat)
            MessageBox.Show("La matrícula se modificó exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.codigoEstado = 0
          End If
          'actualizar()
          Limpiar()
        Else
          MessageBox.Show("Seleccione un alumno", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        objMat = Nothing
      End Try
    End If
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Limpiar()
    Me.gbMatricula.Enabled = True
  End Sub

  Public Sub Limpiar()
    Me.al = Nothing
    Me.txtAlumno.Text = ""
    Me.btnNuevoApo.Enabled = False
    Me.cboTipo.SelectedIndex = -1
    Me.cboNivel.SelectedIndex = -1
    Me.cboSeccion.SelectedIndex = -1
    Me.btnRegistrar.Text = "&Matricular"
    If Me.cboApoderado.DataSource IsNot Nothing Then
      Me.cboApoderado.DataSource = Nothing
    End If
    Me.btnBuscarAlumno.Visible = True
    Me.txtParentesco.Text = ""
    Me.codigoEstado = 0
    Me.cboSeccion.Text = ""
    Me.cboNivel.Text = ""
    sw = 0
    errMatricula.SetError(Me.cboNivel, Nothing)
    errMatricula.SetError(Me.cboSeccion, Nothing)
    errMatricula.SetError(Me.cboApoderado, Nothing)
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnMatriculados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMatriculados.Click
    Matriculados()
  End Sub

  Private Sub Matriculados()
    Dim objMat As New RNMatricula
    Dim frm As frmGestionMatriculaBuscar
    Dim Mat, Mat2 As Matricula
    Dim objApo As RNApoderado
    Dim objNiv As RNNivel

    If objMat.ListarMatriculas(moAnioActual) > 0 Then
      objApo = New RNApoderado
      frm = New frmGestionMatriculaBuscar
      Mat = frm.Buscar
      frm.Dispose()
      frm = Nothing

      If Mat IsNot Nothing Then
        objNiv = New RNNivel
        Me.matModif = Mat
        Me.txtAlumno.Text = Mat.NombreAlumno
        LlenarDatosApoderado(Mat.Alumno.Codigo)
        Me.cboApoderado.Text = objApo.LeerApoderadoNombre(New Apoderado(Mat.codigoApoderado.Codigo)).NombreCompleto
        Mat2 = objMat.LeerAnioGradoSeccion(New Matricula(Mat.Numero, New Alumno(), 0))
        Me.cbanio.Text = Mat2.Anio.anio
        Me.cboNivel.Text = Mat2.Grado.Nombre
        Me.cboSeccion.Text = CStr(Mat2.Grado.Numero) & " '" & Mat2.Letra & "'"
        Mat2 = Nothing

        Me.al = Mat.Alumno
        Me.btnNuevoApo.Enabled = True
        Me.btnRegistrar.Text = "&Actualizar"
        Me.btnBuscarAlumno.Visible = False
        codigoEstado = 1
      Else
        MessageBox.Show("Matricula anulada o cancelo la selección", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If

    Else
      MessageBox.Show("No existen alumnos matriculados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub cboApoderado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboApoderado.SelectedIndexChanged
    If Me.cboApoderado.SelectedIndex > -1 Then
      Me.txtParentesco.Text = CType(Me.cboApoderado.SelectedItem, Parentesco).Parentesco
    End If
  End Sub

  Private Sub btnNuevoApo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoApo.Click
    Dim frm As frmGestionApoderado
    Dim P As Apoderado

    If Me.txtAlumno.Text <> "" Then
      frm = New frmGestionApoderado
      frm.CodigoAlumno = al.Codigo
      P = frm.RegistrarNuevoApo(1)
      'ap = CType(P, Parentesco)
      LlenarDatosApoderado(al.Codigo)
      If P IsNot Nothing Then
        Me.cboApoderado.Text = P.ApellidoPaterno & " " & P.ApellidoMaterno & " " & P.Nombre
        P = Nothing
        ap = CType(Me.cboApoderado.SelectedItem, Parentesco)
      End If

    Else
      MessageBox.Show("Seleccione alumno", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub btnNuevoAlu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoAlu.Click
    Dim frm As New frmGestionAlumno
    Dim A As Alumno

    A = frm.RegistrarAlu(1)
    Me.codigoEstado = 0
    If A IsNot Nothing Then
      Me.txtAlumno.Text = A.NombreCompleto
      Me.cboTipo.SelectedIndex = 0
      Me.LlenarDatosApoderado(A.Codigo)
      Me.al = A
      If Me.cboApoderado.Items.Count > 0 Then
        Me.ap = CType(Me.cboApoderado.SelectedItem, Parentesco)
      Else
        Me.ap = Nothing
      End If
      Me.btnNuevoApo.Enabled = True
    Else
      Me.Limpiar()
      MessageBox.Show("Registro de alumno cancelado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Question)
    End If
  End Sub

  Private Sub cboNivel_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboNivel.Validating
    If Me.cboNivel.Text = "" Then
      e.Cancel = True
      errMatricula.SetError(Me.cboNivel, "Selecione grado a matricular")
    Else
      errMatricula.SetError(Me.cboNivel, Nothing)
    End If
  End Sub

  Private Sub cboSeccion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboSeccion.Validating
    If Me.cboSeccion.Text = "" Then
      e.Cancel = True
      errMatricula.SetError(Me.cboSeccion, "Seleccione grado y sección")
    Else
      errMatricula.SetError(Me.cboSeccion, Nothing)
    End If
  End Sub

  Private Sub cboApoderado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboApoderado.Validating
    If Me.cboApoderado.Text = "" Then
      e.Cancel = True
      errMatricula.SetError(Me.cboApoderado, "Seleccione grado y sección")
    Else
      errMatricula.SetError(Me.cboApoderado, Nothing)
    End If
  End Sub

  Private Function CodigoTipoMatricula() As String
    Select Case cboTipo.SelectedIndex
      Case 0
        Return "I"
      Case 1
        Return "P"
      Case 2
        Return "R"
      Case 3
        Return "RE"
      Case 4
        Return "RI"
    End Select

    Return ""
  End Function

  Private Sub btnActualizarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarDatos.Click
    Dim frm As frmGestionAlumno

    If al IsNot Nothing Then
      frm = New frmGestionAlumno
      frm.modificar(al)
    Else
      MessageBox.Show("Debe identificar al alumno", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If

  End Sub

End Class
