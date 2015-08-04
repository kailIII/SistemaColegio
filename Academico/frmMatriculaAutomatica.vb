
Public Class frmMatriculaAutomatica

  Private indice As Integer = -1
  Private sw2 As Integer = 0

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub frmMatriculaAutomatica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    LeerAnioLectivo()
    'LeerAlumnos()
    MostarImagenes()
    'Me.dgProxMat.ClearSelection()
    'If Me.cboAnioAct.Items.Count > 0 AndAlso Me.cboAnioProx.Items.Count > 0 Then
    '  Me.btnIniciar.Enabled = False
    'End If
  End Sub

  Public Sub MostarImagenes()
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
  End Sub

  Public Sub LeerAnioLectivo()
    Dim obj As New RNAnioLectivo
    Dim la As List(Of AnioLectivo)

    la = obj.Listar
    If la.Count > 0 Then
      Me.cboAnioAct.DisplayMember = "anio"
      Me.cboAnioAct.ValueMember = "anio"
      Me.cboAnioAct.DataSource = la
      Me.cboAnioAct.Text = moAnioActual.anio.Trim
      'Me.cboAnioProx.Items.Add(CInt(Me.cboAnioAct.Text) + 1)
      la = Nothing
    End If

  End Sub

  Private Sub cboAnioAct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnioAct.SelectedIndexChanged
    If Me.cboAnioAct.SelectedIndex > -1 Then
      If indice <> Me.cboAnioAct.SelectedIndex Then
        'Me.txtAnioProx.Items.Clear()
        'Me.txtAnioProx.Items.Add(CInt(Me.cboAnioAct.Text) + 1)
        Me.txtAnioProx.Text = (CInt(Me.cboAnioAct.Text) + 1).ToString
        indice = Me.cboAnioAct.SelectedIndex
      End If
    End If
  End Sub

  'Public Sub LeerAlumnos()
  '  Dim obj As New RNMatricula
  '  Dim Mat As List(Of Matricula)

  '  If moAnioActual IsNot Nothing Then
  '    Mat = obj.ListarAlumnos(DirectCast(cboAnioAct.SelectedItem, AnioLectivo))
  '    Me.dgProxMat.AutoGenerateColumns = False
  '    Me.dgProxMat.DataSource = Mat
  '    Me.dgProxMat.Columns(0).DataPropertyName = "NombreCompleto"
  '    Me.dgProxMat.Columns(1).DataPropertyName = "LeerSituacion"
  '  End If
  'End Sub

  Private Sub cboAnioAct_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboAnioAct.Validating
    If moAnioActual IsNot Nothing Then
      If Me.cboAnioAct.Text <> moAnioActual.Anio Then
        e.Cancel = True
        errMatAuto.SetError(Me.cboAnioAct, "Seleccione año actual")
      Else
        errMatAuto.SetError(Me.cboAnioAct, Nothing)
      End If
    Else
      If Me.cboAnioAct.Text = "" Then
        e.Cancel = True
        errMatAuto.SetError(Me.cboAnioAct, "Registre año actual")
      Else
        errMatAuto.SetError(Me.cboAnioAct, Nothing)
      End If
    End If
  End Sub

  Private Sub cboAnioProx_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAnioProx.Validating
    If Me.txtAnioProx.Text.Length = 0 Then
      e.Cancel = True
      errMatAuto.SetError(Me.txtAnioProx, "Indique el año próximo a matricular")
    Else
      errMatAuto.SetError(Me.txtAnioProx, Nothing)
    End If
  End Sub

  'Private Sub btnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click
  '  'Dim sw As Integer = 0
  '  Dim obj As RNMatricula
  '  Dim objAp As RNApoderado
  '  Dim objNi As RNNivel
  '  Dim objSec As RNSeccion
  '  Dim m As Matricula = Nothing
  '  Dim lg As List(Of Nivel) = Nothing
  '  Dim nivel As Nivel = Nothing
  '  Dim lsec As List(Of Seccion) = Nothing
  '  Dim lsec2 As List(Of Seccion) = Nothing
  '  Dim sec As Seccion
  '  Dim situacion As String = ""
  '  Dim nro As Integer = -1
  '  Dim nro2 As Integer = -1
  '  Dim sw As Integer = 0
  '  Dim sw3 As Integer
  '  Dim sw4 As Integer = 0
  '  Dim lgra As List(Of Grado) = Nothing
  '  Dim gra As Grado
  '  Dim objGra As RNGrado
  '  Dim egresado As Integer
  '  Dim niv As String
  '  Dim grado As String

  '  If Me.ValidateChildren Then
  '    If Me.dgProxMat.RowCount > 0 And moAnioActual IsNot Nothing Then

  '      obj = New RNMatricula
  '      If obj.ListarAlumnos(New AnioLectivo(CStr(CInt(moAnioActual.anio) + 1))).Count = 0 Then
  '        objAp = New RNApoderado
  '        objNi = New RNNivel
  '        objSec = New RNSeccion
  '        objGra = New RNGrado
  '        situacion = CType(Me.dgProxMat.Rows(0).DataBoundItem, Matricula).SituacioFinal
  '        If situacion <> "IN" Then
  '          IniciarProximoAnio()
  '          Try
  '            For i = 0 To Me.dgProxMat.Rows.Count - 1
  '              niv = ""
  '              grado = ""
  '              Try
  '                'situacion = CStr(Me.dgProxMat.Rows(i).Cells("cdSituacion").Value)
  '                situacion = CType(Me.dgProxMat.Rows(i).DataBoundItem, Matricula).SituacioFinal
  '                m = CType(Me.dgProxMat.Rows(i).DataBoundItem, Matricula)
  '                m.Anio = New AnioLectivo(Me.txtAnioProx.Text.Trim)
  '                m.Fecha = Now
  '                m.Personal.Codigo = mOUsuario.Persona.Codigo
  '                m.vigencia = False
  '                'm.PromedioFinal = CDbl(0)
  '                'm.OrdenMeritoFinal = 0
  '                'm.NroOrden = 0
  '                'm.AcumuladoFinal = 0
  '                m.codigoAlumnoApoderado = New Alumno(m.Alumno.Codigo)
  '                m.codigoApoderado = objAp.MostrarTutor(m.Alumno.Codigo, DirectCast(cboAnioAct.SelectedItem, AnioLectivo))
  '                m.SituacioFinal = "IN"

  '                lg = objNi.Listar()
  '                'insertar secciones en el nuevo año pero ingresa una sola vez
  '                If sw2 = 0 Then
  '                  For Each nivel In lg
  '                    lgra = objGra.Listar(New Grado(0, nivel.Codigo, "", 0)) '''''zsdgsd
  '                    For Each gra In lgra
  '                      'lsec2 = objSec.Leer_Grado(New AnioLectivo(Me.cboAnioAct.Text.Trim), New Grado(gra.Codigo), 1)
  '                      lsec2 = objSec.Leer_Grado(DirectCast(cboAnioAct.SelectedItem, AnioLectivo), gra, 1)
  '                      For Each sec In lsec2
  '                        sec.Anio.anio = Me.txtAnioProx.Text.Trim
  '                        objSec.Registrar(sec)
  '                      Next
  '                    Next
  '                  Next
  '                  sw2 = 1
  '                End If

  '                niv = CType(Me.dgProxMat.Rows(i).DataBoundItem, Matricula).Grado.nombreNivel
  '                niv = niv(0) & niv(1) & niv(2)
  '                grado = CType(Me.dgProxMat.Rows(i).DataBoundItem, Matricula).Grado.Numero & " '" & CType(Me.dgProxMat.Rows(i).DataBoundItem, Matricula).Letra & "'"
  '                If situacion.Trim = "C" OrElse situacion.Trim = "P" OrElse situacion.Trim = "RR" OrElse situacion.Trim = "A" OrElse situacion.Trim = "PP" Then
  '                  nro = -1
  '                  nro2 = -1
  '                  egresado = 0
  '                  sw = 0

  '                  For Each nivel In lg
  '                    nro += 1
  '                    If m.Grado.Nivel.Nombre = nivel.Nombre Then
  '                      lsec = objSec.Leer_NivelAcad(New AnioLectivo(moAnioActual.anio), New Nivel(m.Grado.Nivel.Codigo, "", ""), 1)
  '                      Exit For
  '                    End If
  '                  Next

  '                  sw3 = 0
  '                  sw4 = 0
  '                  For Each sec In lsec
  '                    nro2 += 1
  '                    If sec.Grado.Numero = m.Grado.Numero + 1 Then
  '                      If CStr(sec.Grado.Numero).Trim & " '" & sec.Letra & "'" = CStr(m.Grado.Numero + 1).Trim & " '" & m.Letra.Trim & "'" Then
  '                        sw = 1
  '                        sw3 = 0
  '                        Exit For
  '                      Else
  '                        sw3 = 1
  '                      End If
  '                    Else
  '                      If sec.Grado.Numero < m.Grado.Numero + 1 Then
  '                        sw4 = 1
  '                      Else
  '                        sw4 = 2
  '                      End If
  '                    End If
  '                  Next

  '                  If sw3 = 1 Then
  '                    m.Letra = "A"
  '                    sw = 1
  '                  End If

  '                  If sw = 1 Then
  '                    Me.dgProxMat.Rows(i).Cells("cdNivel").Value = m.Grado.nombreNivel
  '                    Me.dgProxMat.Rows(i).Cells("cdGrado").Value = CStr(m.Grado.Numero + 1) & " '" & m.Letra & "'"
  '                    Me.dgProxMat.Rows(i).Cells("cdSituacion").Value = ""
  '                    m.Grado.Numero += 1
  '                  Else
  '                    nro += 1
  '                    If sw4 = 1 Or sw4 = 2 Then
  '                      m.Letra = "A"
  '                    End If
  '                    If nro < lg.Count Then
  '                      If sw4 = 2 Then
  '                        Me.dgProxMat.Rows(i).Cells("cdNivel").Value = lg(nro - 1).Nombre
  '                        Me.dgProxMat.Rows(i).Cells("cdGrado").Value = m.Grado.Numero + 1 & " '" & m.Letra & "'"
  '                      ElseIf sw4 = 1 Then
  '                        Me.dgProxMat.Rows(i).Cells("cdNivel").Value = lg(nro).Nombre
  '                        Me.dgProxMat.Rows(i).Cells("cdGrado").Value = CStr(1) & " '" & m.Letra & "'"
  '                      End If
  '                      nro2 += 1
  '                    ElseIf nro = lg.Count Then
  '                      If sw4 = 2 Then
  '                        Me.dgProxMat.Rows(i).Cells("cdNivel").Value = lg(nro - 1).Nombre
  '                        Me.dgProxMat.Rows(i).Cells("cdGrado").Value = m.Grado.Numero + 1 & " '" & m.Letra & "'"
  '                      ElseIf sw4 = 1 Then
  '                        Me.dgProxMat.Rows(i).DefaultCellStyle.BackColor = Color.Green
  '                        egresado = 1
  '                      End If
  '                      nro2 += 1
  '                    ElseIf nro > lg.Count Then
  '                      Me.dgProxMat.Rows(i).DefaultCellStyle.BackColor = Color.Green
  '                      egresado = 1
  '                    End If

  '                  End If

  '                  If egresado = 0 Then
  '                    If nro2 < lsec.Count Then
  '                      m.Grado.Codigo = lsec(nro2).Grado.Codigo
  '                    ElseIf nro2 = lsec.Count Then
  '                      m.Grado.Codigo = objGra.RetornaCG(New Seccion(0, 1, lg(nro - 1).Codigo, "", CChar("a")))
  '                    ElseIf nro2 > lsec.Count Then
  '                      m.Grado.Codigo = objGra.RetornaCG(New Seccion(0, 1, lg(nro).Codigo, "", CChar("a")))
  '                    End If

  '                    obj.Registrar(m, New Parentesco(m.codigoApoderado, ""))
  '                    Me.dgProxMat.Rows(i).DefaultCellStyle.BackColor = Color.White
  '                    Me.dgProxMat.Rows(i).Cells("cdGradoAnterior").Value = niv & " - " & grado
  '                    Me.dgProxMat.Rows(i).Cells("cdImagen").Value = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\exito.png")
  '                  End If

  '                Else
  '                  Me.dgProxMat.Rows(i).Cells("cdNivel").Value = m.Grado.nombreNivel
  '                  Me.dgProxMat.Rows(i).Cells("cdGrado").Value = m.Grado.Numero & " '" & m.Letra & "'"
  '                  Me.dgProxMat.Rows(i).Cells("cdSituacion").Value = ""
  '                  Me.dgProxMat.Rows(i).DefaultCellStyle.BackColor = Color.Red
  '                  m.Grado.Codigo = objGra.RetornaCG(New Seccion(0, m.Grado.Numero, m.Grado.Nivel.Codigo, "", CChar("A")))
  '                  'm.Letra = m.Letra
  '                  obj.Registrar(m, New Parentesco(m.codigoApoderado, ""))
  '                  Me.dgProxMat.Rows(i).Cells("cdGradoAnterior").Value = niv & " - " & grado
  '                  Me.dgProxMat.Rows(i).Cells("cdImagen").Value = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\exito.png")
  '                End If

  '                'Me.dgProxMat.Rows(i).Cells("cdImagen").Value = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\exito.png")
  '              Catch ex As Exception
  '                MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
  '              End Try
  '            Next
  '            Me.dgProxMat.ClearSelection()
  '            MessageBox.Show("Matrículas registradas con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

  '          Catch ex As Exception
  '            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
  '          Finally
  '            obj = Nothing
  '            objAp = Nothing
  '            'EliminarAnio()
  '          End Try
  '        Else
  '          MessageBox.Show("Para promover, todos los alumnos deben tener situación final", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
  '        End If
  '      Else
  '        MessageBox.Show("Matrículas ya registradas (solo registrara si selecciona año actual)", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
  '      End If
  '    Else
  '      MessageBox.Show("No existen alumnos matriculados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
  '    End If
  '  End If

  'End Sub

  'Public Sub EliminarAnio()
  '  Dim obj As New RNAnioLectivo
  '  obj.EliminarAnio(New AnioLectivo(Me.txtAnioProx.Text.Trim))
  'End Sub

  'Public Sub IniciarProximoAnio()
  '  Dim objAnio As New RNAnioLectivo
  '  Dim objIns As New RNInstitucion
  '  Dim lp As List(Of PeriodoAcademico) = Nothing
  '  Dim anio As String = Me.txtAnioProx.Text.Trim

  '  objAnio.RegistrarAnio(New AnioLectivo(anio, CDate(anio & "/03/01"), CDate(anio & "/12/20"), False, "", New Institucion(objIns.Listar.CodigoInst)))
  '  objAnio = Nothing
  'End Sub

  Private Sub dgProxMat_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgProxMat.SelectionChanged
    Me.dgProxMat.CurrentRow.DefaultCellStyle.SelectionBackColor = Me.dgProxMat.CurrentRow.DefaultCellStyle.BackColor

    If Me.dgProxMat.CurrentRow.DefaultCellStyle.SelectionBackColor = Color.White Then
      Me.dgProxMat.CurrentRow.DefaultCellStyle.SelectionForeColor = Color.Blue
    Else
      Me.dgProxMat.CurrentRow.DefaultCellStyle.SelectionForeColor = Me.dgProxMat.CurrentRow.DefaultCellStyle.ForeColor
    End If
  End Sub

  Private Sub btnListarAlumnos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarAlumnos.Click
    Dim rnM As New RNMatricula
    Dim dt As DataTable

    dt = rnM.ListarPosiblesMatriculas(DirectCast(cboAnioAct.SelectedItem, AnioLectivo))
    rnM = Nothing
    With dt.Columns
      .Add("NombreCompleto", GetType(String), "ApellidoPat + ' ' + apellidoMat + ' ' + Nombre")
      .Add("GradoActual", GetType(String), "nombreNivel + ' ' + numero + ' ' + ' - ' + letra")
      .Add("GradoSgte", GetType(String), "NivelS + ' ' + numeroS + ' - ' + letra")
    End With
    Me.dgProxMat.AutoGenerateColumns = False
    Me.dgProxMat.DataSource = dt
  End Sub

  Private Sub btnMatricular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMatricular.Click
    Dim rnMat As RNMatriculaPosible
    Dim rnAnio As RNAnioLectivo
    Dim mat As MatriculaPosible
    Dim dt As DataTable
    Dim img As Image
    Dim i As Integer = 0

    Try
      lblMsje.Text = "Importando secciones"
      rnAnio = New RNAnioLectivo
      rnAnio.ImportarAnio(DirectCast(cboAnioAct.SelectedItem, AnioLectivo), New AnioLectivo(Me.txtAnioProx.Text))
      rnAnio = Nothing

      mat = New MatriculaPosible
      mat.Seccion = New Seccion
      mat.Seccion.Anio = New AnioLectivo(txtAnioProx.Text)
      mat.Seccion.Grado = New Grado
      mat.Alumno = New Alumno
      mat.Apoderado = New Parentesco
      mat.Apoderado.Apoderado = New Apoderado

      img = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\exito.png")
      dt = DirectCast(Me.dgProxMat.DataSource, DataTable)
      rnMat = New RNMatriculaPosible
      For Each dr As DataRow In dt.Rows
        mat.Seccion.Grado.Codigo = CInt(dr.Item("GradoS"))
        mat.Seccion.Letra = CChar(dr.Item("letra"))
        mat.Alumno.Codigo = CInt(dr.Item("CodigoAlumno"))
        mat.Apoderado.Apoderado.Codigo = CInt(dr.Item("codigoApoderado"))

        rnMat.Registrar(mat)

        lblMsje.Text = "Registrando matricula de " & dr.Item("NombreCompleto").ToString
        Me.dgProxMat.Rows(i).Cells("cdImagen").Value = img
        i += 1
      Next
      MessageBox.Show("Se ha realizado la promoción de los alumnos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      rnMat = Nothing
      mat = Nothing
    End Try

  End Sub

End Class