Public Class frmGestionHorarios

  Private carga As New CargaAcademica
  Private H As New Horario
  Private numperiodo As Integer
  Private codigo As Integer
  Private ListHorario As New List(Of Horario)
  Private ListCarga As New List(Of CargaAcademica)

  Private Sub frmGestionHorarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnNuevo.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Nuevo.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnModificar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Editar.jpg")

    cargarcbanio()
    cargarcboNivelAcademico()
    cargarcboSeccion()
    cargarCboLocal()
    cargarHoras()
    cboDia.SelectedIndex = 0
    Me.btnNuevo.Enabled = False
    Me.btnModificar.Enabled = False
  End Sub
  Public Sub cargarHoras()
    For i As Integer = 0 To 12
      cboHoraIni.Items.Add(FormatDateTime(My.Settings.HoraIni.AddMinutes(My.Settings.HORA * i), DateFormat.ShortTime))
    Next
    cboHoraIni.SelectedIndex = 0
  End Sub
  Public Sub cargarcbanio()
    Dim ListAn As New List(Of AnioLectivo)
    Dim objAn As New RNAnioLectivo
    Dim al As New AnioLectivo
    al.vigencia = True
    ListAn = objAn.Leer(al)
    cbanio.DisplayMember = "anio"
    cbanio.ValueMember = "anio"
    cbanio.DataSource = ListAn
    
    ListAn = Nothing
  End Sub
  Public Sub cargarcboNivelAcademico()
    Dim ListNa As New List(Of Nivel)
    Dim objNa As New RNNivel
    ListNa = objNa.Listar()
    cboNivel.DisplayMember = "nombre"
    cboNivel.ValueMember = "codigoModular"
    cboNivel.DataSource = ListNa
    ListNa = Nothing
  End Sub
  Public Sub cargarcboSeccion()
    Dim ListSec As New List(Of Seccion)
    Dim objS As New RNSeccion
    ListSec = objS.Leer_NivelAcad(CType(cbanio.SelectedItem, AnioLectivo), CType(cboNivel.SelectedItem, Nivel), 1)
    cboSeccion.DisplayMember = "numeroletra"
    cboSeccion.ValueMember = "codigoGrado"
    cboSeccion.DataSource = ListSec
    ListSec = Nothing
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    'dgvCargaAcademica.DataSource = Nothing
    If cboSeccion.SelectedIndex > -1 Then
      dgvHorario.DataSource = Nothing
      Listar()
    Else
      dgvCargaAcademica.DataSource = Nothing
    End If
  End Sub
  Public Sub Listar()

    Dim objC As New RNCargaAcademica

    ListCarga = Nothing

    ListCarga = objC.Listar(CType(cboSeccion.SelectedItem, Seccion))

    If ListCarga.Count > 0 Then
      dgvCargaAcademica.DataSource = Nothing
      dgvCargaAcademica.AutoGenerateColumns = False
      dgvCargaAcademica.DataSource = ListCarga
      Me.btnNuevo.Enabled = True
      Me.btnModificar.Enabled = True
    Else
      Me.btnNuevo.Enabled = False
      Me.btnModificar.Enabled = False
      dgvCargaAcademica.DataSource = Nothing
      dgvHorario.DataSource = Nothing
    End If
    
  End Sub
  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboNivel.SelectedIndexChanged
    cargarcboSeccion()
  End Sub

  Public Sub cargarCboLocal()
    Dim ListL As New List(Of Local)
    Dim objLoc As New RNLocal

    ListL = objLoc.Leer()
    cboLocal.ValueMember = "codigoLocal"
    cboLocal.DisplayMember = "nombre"
    cboLocal.DataSource = ListL
    cboLocal.SelectedIndex = 0
    ListL = Nothing
  End Sub
  Private Sub cblocal_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLocal.SelectedIndexChanged
    Dim ListA As New List(Of Aula)
    Dim n As Integer = cboLocal.SelectedIndex
    Dim A As New Aula(CBool(1), "A")


    Dim objRNA As New RNAula
    cboAula.DataSource = Nothing
    ListA = objRNA.ListarAula(A, CType(cboLocal.SelectedItem, Local))
    If ListA.Count > 0 Then
      cboAula.DisplayMember = "NombreCompletoAula"
      cboAula.ValueMember = "codigo"
      cboAula.DataSource = ListA
    Else
      cboAula.DataSource = Nothing
    End If
    ListA = Nothing
    cboAula.SelectedIndex = 0
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim objCarga As RNCargaAcademica
    Dim objHorario As RNHorario
    Dim sec As Seccion

    Dim HF As Date = Nothing
    Dim TotalH As Integer
    Dim minutos As Integer
    Dim hor As Integer
    Dim i As Integer = 0
    Dim T As Integer = 0
    If Me.ValidateChildren Then

      Try
        objCarga = New RNCargaAcademica
        objHorario = New RNHorario
        HF = CDate(cboHoraIni.Text)

        sec = CType(Me.cboSeccion.SelectedItem, Seccion)

        Dim objH As New Horario
        If dgvHorario.RowCount > 0 Then

          For Each objH In ListHorario
            minutos = CInt(DateDiff(DateInterval.Minute, objH.horaIni, objH.horaFin))
            hor = CInt(minutos / CInt(My.Settings.HORA))
            TotalH += hor
          Next
          If codigo = 0 Then
            TotalH = CInt(nudhoras.Value) + TotalH
            'Else
            '  If (CInt(DateDiff(DateInterval.Minute, H.horaIni, H.horaFin) / CInt(My.Settings.HORA)) = 1) Then
            '    T = TotalH - (CInt(DateDiff(DateInterval.Minute, H.horaIni, H.horaFin) / CInt(My.Settings.HORA)))
            '  Else
            '    T = TotalH - (CInt(DateDiff(DateInterval.Minute, H.horaIni, H.horaFin) / CInt(My.Settings.HORA)) + 1)
            '  End If
            '  TotalH = T + CInt(nudhoras.Value)
            End If
        Else
            TotalH = CInt(nudhoras.Value)
        End If

        If TotalH <= carga.CursoHoras Then
          If codigo = 0 Then
            objHorario.Registrar(New Horario(0, carga, CType(Me.cboAula.SelectedItem, Aula), _
                                   CStr(Me.cboDia.SelectedItem), CDate(cboHoraIni.Text).Date, HF.AddMinutes(CInt(My.Settings.HORA * (nudhoras.Value)))))

            MessageBox.Show("El horario se registro exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          Else
            objHorario.Modificar(New Horario(CInt(codigo), carga, CType(Me.cboAula.SelectedItem, Aula), _
                                   CStr(Me.cboDia.SelectedItem), CDate(cboHoraIni.Text), HF.AddMinutes(CInt(My.Settings.HORA * (nudhoras.Value)))))
            MessageBox.Show("El horario se modifico exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          End If
          LLenarHorario()
          LimpiarDatos()
          gbHorario.Enabled = False
        Else
          MessageBox.Show("El número de horas excede a lo asignado!!!" & TotalH, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
          TotalH = 0
          minutos = 0
          hor = 0

        End If

      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    End If

  End Sub
  Public Sub LLenarHorario()

    Dim objH As New RNHorario

    If dgvCargaAcademica.Rows.Count > 0 Then
      carga = CType(Me.dgvCargaAcademica.SelectedRows.Item(0).DataBoundItem, CargaAcademica)

      ListHorario = objH.Listar(carga.Codigo)

      Me.dgvHorario.DataSource = Nothing
      dgvHorario.AutoGenerateColumns = False
      dgvHorario.DataSource = ListHorario

      If dgvHorario.RowCount > 0 Then
        H = CType(Me.dgvHorario.SelectedRows.Item(0).DataBoundItem, Horario)
      Else
        H = Nothing
      End If

      For i = 0 To Me.dgvHorario.RowCount - 1
        H = CType(Me.dgvHorario.Rows(i).DataBoundItem, Horario)
        Me.dgvHorario.Rows(i).Cells("cdDia").Value = ConvertirDia(H.dia)
        Me.dgvHorario.Rows(i).Cells("cdInicio").Value = H.horaIni
        Me.dgvHorario.Rows(i).Cells("cdFin").Value = H.horaFin
      Next
    End If
  End Sub

  Public Sub LimpiarDatos()
    Me.cboAula.SelectedIndex = 0
    Me.cboDia.SelectedIndex = 0

    nudhoras.Value = 2
    Me.btnRegistrar.Text = "&Registrar"
    codigo = 0
  End Sub
  Function ConvertirDia(ByVal letra As String) As String
    Dim dia As String = ""
    Select Case letra
      Case "L"
        dia = "Lunes"
      Case "M"
        dia = "Martes"
      Case "I"
        dia = "Miercoles"
      Case "J"
        dia = "Jueves"
      Case "V"
        dia = "Viernes"
      Case "S"
        dia = "Sabado"
      Case "D"
        dia = "Domingo"
    End Select

    Return dia
  End Function

  Private Sub ValidarCombo(ByVal e As System.ComponentModel.CancelEventArgs, ByVal opcion As ComboBox, ByVal msj As String)
    If opcion.SelectedIndex = -1 Then
      e.Cancel = True
      errValida.SetError(opcion, msj)
    Else
      errValida.SetError(opcion, "")
    End If
  End Sub

  Private Sub cboDia_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboDia.Validating
    ValidarCombo(e, Me.cboDia, "Debe indicar el dia")
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click, dgvHorario.DoubleClick
    gbHorario.Enabled = True

    Dim minutos As Integer
    Dim hor As Integer

    If dgvHorario.SelectedRows.Count > 0 Then
      With CType(dgvHorario.SelectedRows.Item(0).DataBoundItem, Horario)
        cboAula.SelectedValue = CInt(.Aula.Codigo)
        cboDia.SelectedItem = ConvertirDia(.dia)

        cboHoraIni.Text = FormatDateTime(.horaIni, DateFormat.ShortTime)

        minutos = CInt(DateDiff(DateInterval.Minute, .horaIni, .horaFin))
        
        hor = CInt(minutos / CInt(My.Settings.HORA))
        nudhoras.Value = hor
        codigo = .Codigo
      End With
      Me.btnRegistrar.Text = "&Actualizar"
    Else
      MessageBox.Show("Selecione horario a modificar", "Gestión de horarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If

  End Sub


  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    LimpiarDatos()
    gbHorario.Enabled = False
  End Sub

  Private Sub ValidardtpHora(ByVal e As System.ComponentModel.CancelEventArgs, ByVal cadena1 As DateTimePicker, ByVal cadena2 As DateTimePicker, ByVal msj As String)

    If cadena1.Value < cadena2.Value Then
      errValida.SetError(cadena1, "")
    Else
      e.Cancel = True
      errValida.SetError(cadena1, msj)
    End If
  End Sub


  Private Sub dgvCargaAcademica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvCargaAcademica.Click
    If dgvCargaAcademica.RowCount > 0 Then
      LLenarHorario()
      gbHorario.Enabled = False
    Else
      btnNuevo.Enabled = False
    End If
  End Sub

  Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
    Dim f As New frmMostrarHorario

    f.Mostrar(Me.cboNivel.SelectedIndex, Me.cboSeccion.SelectedIndex)
  End Sub

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    Me.gbHorario.Enabled = True
    LimpiarDatos()

  End Sub


End Class