Public Class frmGestionProgLecturaAnt

  Private lm As New List(Of Matricula)
  Private lpres As New List(Of Presentacion)
  Private lpl As New List(Of ProgramacionLectura)
  Private Asig As Boolean = False
  Private codigoLibro As Integer = 0
  Private CL As Integer = 0

  Private Sub frmProgramacionLectura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    txtAnio.Text = moAnioActual.anio
    CargarSeccion()
    CargarPresentaciones()
  End Sub

  Private Sub CargarSeccion()
    Dim obj As New RNSeccion
    Dim ls As List(Of Seccion)

    ls = obj.ListarSeccionesSec(New Seccion(moAnioActual, New Grado(), Nothing, New Docente(mOUsuario.Persona.Codigo)))
    If ls.Count > 0 Then
      cboSeccion.DisplayMember = "NivelNumeroLetra"
      cboSeccion.ValueMember = "NivelNumeroLetra"
      cboSeccion.DataSource = ls
    Else
      MessageBox.Show("El Plan Lector sólo se aplica en el proyecto LASER!!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Me.Close()
    End If
  End Sub

  Private Sub CargarPresentaciones()
    Dim obj As New RNPresentacion

    If cboSeccion.SelectedIndex > -1 Then
      lpres = obj.ListarPresVigentes(moAnioActual.anio)
      dgvPresentacion.AutoGenerateColumns = False
      dgvPresentacion.DataSource = lpres
    Else
      btnRegistrar.Enabled = False
      GBGrupo.Enabled = False
    End If
  End Sub

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub ListarAlumnos()
    Dim obj As New RNMatricula
    Dim sec As New Seccion

    If cboSeccion.Items.Count > 0 Then
      sec = CType(cboSeccion.SelectedItem, Seccion)
      lm = obj.ListarConsolidado((New Seccion(New Grado(0, sec.Grado.Numero, "", New Nivel(sec.Grado.codigoNivel, "", ""), _
                                   "", "", "", ""), moAnioActual.anio, sec.Letra, New Docente(), "", 0, 0)), moAnioActual.anio)
      If lm.Count > 0 Then
        Me.dgvAlumnos.AutoGenerateColumns = False
        Me.dgvAlumnos.DataSource = lm
        Me.txtTotal.Text = lm.Count.ToString
        dgvAlumnos.Columns("cdAgregar").ReadOnly = True
      Else
        Me.txtTotal.Text = lm.Count.ToString
      End If
      cboSeleccionar.Enabled = False

    End If
  End Sub

  Private Sub cboSeleccionar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSeleccionar.SelectedIndexChanged
    If Me.cboSeleccionar.SelectedIndex > 0 Then
      If Me.dgvAlumnos.RowCount > 0 Then
        Select Case Me.cboSeleccionar.SelectedIndex
          Case 1
            SeleccionarMismoSexo()
          Case 2
            SeleccionarTodos()
          Case 3
            QuitarTodos()
        End Select
      End If
    End If
  End Sub

  Public Sub SeleccionarTodos()
    For i As Integer = 0 To Me.dgvAlumnos.RowCount - 1
      Me.dgvAlumnos.Rows(i).Cells("cdAgregar").Value = True
    Next
  End Sub

  Private Sub QuitarTodos()
    For i As Integer = 0 To Me.dgvAlumnos.RowCount - 1
      Me.dgvAlumnos.Rows(i).Cells("cdAgregar").Value = False
    Next
  End Sub

  Public Sub SeleccionarMismoSexo()
    Dim pos As Integer = Me.dgvAlumnos.Rows.IndexOf(Me.dgvAlumnos.CurrentRow)
    Dim sexo As String = Me.dgvAlumnos.Rows(pos).Cells("cdSexo").EditedFormattedValue.ToString

    For i As Integer = 0 To Me.dgvAlumnos.RowCount - 1
      If Me.dgvAlumnos.Rows(i).Cells("cdSexo").EditedFormattedValue.ToString = sexo Then
        Me.dgvAlumnos.Rows(i).Cells("cdAgregar").Value = True
      Else
        Me.dgvAlumnos.Rows(i).Cells("cdAgregar").Value = False
      End If
    Next
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub txtAnio_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAnio.Enter
    cboSeccion.Focus()
  End Sub

  Private Sub dgvPresentacion_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPresentacion.CellClick, dgvPresentacion.CellEnter
    If dgvPresentacion.RowCount > 0 Then
      AlumnosAsignados()
      ListarProgramaciones()
      QuitarSeleccionAlumnos()
      Habilitar()
      btnNuevo.Enabled = True
    End If
  End Sub

  Private Sub ListarProgramaciones()
    Dim obj As RNLibro = Nothing
    Dim listL As List(Of Libro) = Nothing
    Dim i As Integer = 0
    Dim sec As New Seccion
    Dim CodPres As Integer = 0

    Dim pos As Integer = Me.dgvPresentacion.Rows.IndexOf(Me.dgvPresentacion.CurrentRow)
    CodPres = CInt(Me.dgvPresentacion.Rows(pos).Cells("cdcodigoPres").Value)
    Try

      If dgvPresentacion.RowCount > 0 Then
        dgvGrupoLibro.Rows.Clear()
        sec = CType(cboSeccion.SelectedItem, Seccion)
        obj = New RNLibro

        listL = obj.ListarLibros_Grupo(New Seccion(New Grado(sec.Grado.Codigo, sec.Grado.Numero, "", New Nivel(sec.Grado.codigoNivel, "", ""), _
                                 "", "", "", ""), moAnioActual.anio, sec.Letra, New Docente(), "", 0, 0), moAnioActual.anio, CodPres)
        If listL.Count > 0 Then
          For Each L As Libro In listL
            dgvGrupoLibro.Rows.Add()

            With Me.dgvGrupoLibro
              LlenarColLibros()
              .Rows(.RowCount - 1).Cells("cdGrupo").Value = "Grupo " & CStr(.RowCount) & " -- " & cboSeccion.Text
              .Rows(.RowCount - 1).Cells("cdLibro").Value = L.Codigo
              .Rows(.RowCount - 1).Cells("cdCodigoLibro").Value = L.Codigo
              .Rows(.RowCount - 1).Cells("cdNroGrupo").Value = CInt(L.Descripcion)
              .Rows(.RowCount - 1).Cells("cdCodPre").Value = CodPres
              .Rows(.RowCount - 1).Cells("cdImg").Value = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\exito.png")
            End With
          Next
          btnQuitar.Enabled = True
        Else
          btnQuitar.Enabled = False
        End If

      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim obj As RNProgramacionLectura = Nothing
    Dim codLibro As Integer = 0
    Dim codPres As Integer = 0
    Dim codProgLect = 0
    Dim estado As Boolean = False
    Dim Matricula As Matricula = Nothing

    Dim list As List(Of ProgramacionLectura) = Nothing

    Dim sec As New Seccion
    Dim NroGrupo As Integer = 0

    Dim pos As Integer = Me.dgvGrupoLibro.Rows.IndexOf(Me.dgvGrupoLibro.CurrentRow)

    sec = CType(cboSeccion.SelectedItem, Seccion)

    Try
      obj = New RNProgramacionLectura
      If VerificarLibroPresentacion() > 0 Then
        If VerificarSeleccion() > 0 Then
          For a As Integer = 0 To dgvAlumnos.RowCount - 1
            estado = CBool(Me.dgvAlumnos.Rows(a).Cells("cdAgregar").Value)
            Matricula = CType(Me.dgvAlumnos.Rows(a).DataBoundItem, Matricula)

            list = obj.VerificarExistencia(CInt(Me.dgvAlumnos.Rows(a).Cells("cdCodigoPL").Value))

            If estado Then
              'seleccionado
              codPres = CInt(Me.dgvGrupoLibro.Rows(pos).Cells("cdCodPre").Value)
              NroGrupo = CInt(Me.dgvGrupoLibro.Rows(pos).Cells("cdNroGrupo").Value)
              codLibro = CInt(Me.dgvGrupoLibro.Rows(pos).Cells("cdLibro").Value)
              If list.Count > 0 Then
                'Existe
                'Actualizar!!!!
                codProgLect = CInt(Me.dgvAlumnos.Rows(a).Cells("cdCodigoPL").Value)
                obj.Actualizar(New ProgramacionLectura(codProgLect, "P", True, NroGrupo, codPres, New Libro(codLibro), Matricula, _
                    New Seccion(sec.Grado.Codigo, moAnioActual.Anio, sec.Letra)))
              Else
                'No existe
                obj.Registrar(New ProgramacionLectura(0, "P", True, NroGrupo, codPres, New Libro(codLibro), Matricula, _
                                    New Seccion(sec.Grado.Codigo, moAnioActual.Anio, sec.Letra)))

                dgvGrupoLibro.Rows(pos).Cells("cdImg").Value = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\exito.png")
                btnNuevo.Enabled = True
                btnQuitar.Enabled = True
                ListarProgramaciones()
              End If
            Else
              'No seleccionado
              If list.Count > 0 Then
                'Existe
                'Eliminar!!!!
                For Each X In list
                  If (dgvAlumnos.Rows.Item(a).DefaultCellStyle.BackColor = Color.DarkGreen) Then
                    If MessageBox.Show("Si anula la lectura programada a " & dgvAlumnos.Rows.Item(a).Cells(1).Value.ToString & _
                          ", podría anular las calificaciones registradas" & vbNewLine & "¿Está seguro que desea anular la lectura?", _
                          Me.Text, MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                      obj.Eliminar(New ProgramacionLectura(X.Codigo))
                    End If
                  End If
                Next
              Else
                'No Existe
                'NO hacemos Nada
              End If
            End If
          Next
          MessageBox.Show("La asignación se registró exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          dgvPresentacion.Focus()
        Else
          MessageBox.Show("No ha seleccionado alumnos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
      Else
        MessageBox.Show(" No ha seleccionado el libro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      obj = Nothing
      codLibro = 0
      codPres = 0
      estado = False
      Matricula = Nothing
      list = Nothing
      sec = Nothing
    End Try

  End Sub

  Private Function VerificarSeleccion() As Integer
    Dim m As Integer = 0

    For i As Integer = 0 To Me.dgvAlumnos.RowCount - 1
      If CBool(Me.dgvAlumnos.Rows(i).Cells("cdAgregar").Value) Then
        m = 1
        Exit For
      End If
    Next
    Return m

  End Function

  Private Function VerificarLibroPresentacion() As Integer
    Dim m As Integer = 0
    Dim CodPres As Integer = 0

    Dim pos As Integer = Me.dgvGrupoLibro.Rows.IndexOf(Me.dgvGrupoLibro.CurrentRow)

    If CInt(Me.dgvGrupoLibro.Rows(pos).Cells("cdLibro").Value) > 0 Then
      m = 1
    End If

    Return m

  End Function

  Private Sub dgvGrupoLibro_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGrupoLibro.CellClick
    Dim CodPres As Integer = 0

    Dim pos As Integer = Me.dgvGrupoLibro.Rows.IndexOf(Me.dgvGrupoLibro.CurrentRow)
    CodPres = CInt(Me.dgvGrupoLibro.Rows(pos).Cells("cdCodPre").Value)

    CL = CInt(dgvGrupoLibro.Rows(pos).Cells("cdCodigoLibro").Value)

    If dgvGrupoLibro.CurrentCell.ColumnIndex > -1 Then
      QuitarSeleccionAlumnos()
      btnRegistrar.Enabled = False
    End If

  End Sub

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    Dim CodPres As Integer = 0
    Dim pos As Integer = Me.dgvPresentacion.Rows.IndexOf(Me.dgvPresentacion.CurrentRow)
    CodPres = CInt(Me.dgvPresentacion.Rows(pos).Cells("cdcodigoPres").Value)


    Me.dgvGrupoLibro.Rows.Add()
    With Me.dgvGrupoLibro
      .Rows(.RowCount - 1).Cells("cdGrupo").Value = "Grupo " & CStr(.RowCount) & " -- " & cboSeccion.Text
      LlenarColLibros()
      .Rows(.RowCount - 1).Cells("cdCodigoLibro").Value = 0
      .Rows(.RowCount - 1).Cells("cdNroGrupo").Value = .RowCount
      .Rows(.RowCount - 1).Cells("cdCodPre").Value = CodPres
    End With

    QuitarSeleccionAlumnos()
    Me.btnNuevo.Enabled = False
    Me.btnRegistrar.Enabled = False
    Me.btnAlumnos.Enabled = True

    Me.dgvGrupoLibro.Rows(Me.dgvGrupoLibro.RowCount - 1).Selected = True
    Me.dgvGrupoLibro.Rows(Me.dgvGrupoLibro.RowCount - 1).Cells("cdLibro").Selected = True

  End Sub

  Public Sub LlenarColLibros()
    Dim col As DataGridViewComboBoxColumn = Nothing
    Dim obj As New RNLibro
    Dim ld As List(Of GradoLibro)

    col = DirectCast(Me.dgvGrupoLibro.Columns("cdLibro"), DataGridViewComboBoxColumn)

    ld = obj.ListarLibros_Grado(CType(cboSeccion.SelectedItem, Seccion).Grado, moAnioActual)


    If ld.Count > 0 Then
      With col
        .DisplayMember = "NombreLibro"
        .ValueMember = "CodigoLibro"
        .DataSource = ld
      End With
    End If
    col = Nothing
    ld = Nothing
    obj = Nothing
  End Sub

  Public Sub Habilitar()
    If dgvGrupoLibro.RowCount = 0 Then
      Me.btnRegistrar.Enabled = False
      Me.btnAlumnos.Enabled = False
    Else
      'Pintar()
      'Me.btnRegistrar.Enabled = True
      btnAlumnos.Enabled = True
    End If
  End Sub

  Private Sub btnAlumnos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlumnos.Click
    Dim pos As Integer = Me.dgvGrupoLibro.Rows.IndexOf(Me.dgvGrupoLibro.CurrentRow)

    If Me.dgvGrupoLibro.Rows(pos).Cells("cdImg").Value IsNot Nothing Then
      Seleccionar()
    Else
      txtTotal.Text = "0"
    End If
    cboSeleccionar.Enabled = True
    dgvAlumnos.Columns("cdAgregar").ReadOnly = False
    btnRegistrar.Enabled = True
  End Sub

  Private Sub Seleccionar()
    Dim obj As New RNProgramacionLectura
    Dim sec As New Seccion
    Dim cont As Integer = 0
    Dim CodPres As Integer = 0

    Dim pos As Integer = Me.dgvGrupoLibro.Rows.IndexOf(Me.dgvGrupoLibro.CurrentRow)
    CodPres = CInt(Me.dgvGrupoLibro.Rows(pos).Cells("cdCodPre").Value)

    sec = CType(cboSeccion.SelectedItem, Seccion)
    lpl = obj.ListarAlumnosProgramacion((New Seccion(New Grado(0, sec.Grado.Numero, "", New Nivel(sec.Grado.codigoNivel, "", ""), _
                                 "", "", "", ""), moAnioActual.anio, sec.Letra, New Docente(), "", 0, 0)), moAnioActual.anio, _
                                    CInt(Me.dgvGrupoLibro.Rows(pos).Cells("cdNroGrupo").Value))

    If lpl.Count > 0 Then
      'Asignamos el codigoProglect...
      For i As Integer = 0 To Me.dgvAlumnos.RowCount - 1
        For Each P In lpl
          If CType(Me.dgvAlumnos.Rows(i).DataBoundItem, Matricula).Numero = P.Matricula.Numero _
             And CodPres = P.CodigoPresentacion And CL = P.Libro.Codigo Then
            Me.dgvAlumnos.Rows(i).Cells("cdCodigoPL").Value = P.Codigo
            Asig = True
            Exit For
          Else
            Me.dgvAlumnos.Rows(i).Cells("cdCodigoPL").Value = 0
          End If
        Next
      Next
    End If

    If Asig Then
      Pintar()
    End If
    'Pintamos solo los alumnos asignados
  End Sub

  Private Sub Pintar()
    Dim cont As Integer = 0

    For i = 0 To Me.dgvAlumnos.RowCount - 1
      For Each P In lpl
        If CInt(Me.dgvAlumnos.Rows(i).Cells("cdCodigoPL").Value) = P.Codigo Then
          Me.dgvAlumnos.Rows(i).Cells("cdAgregar").Value = True
          Me.dgvAlumnos.Rows(i).DefaultCellStyle.BackColor = Color.DarkGreen
          Me.dgvAlumnos.Rows(i).DefaultCellStyle.ForeColor = Color.White
          cont += 1
          Exit For
        Else
          dgvAlumnos.Rows(i).Cells("cdAgregar").Value = False
          Me.dgvAlumnos.Rows(i).DefaultCellStyle.BackColor = Color.White
          Me.dgvAlumnos.Rows(i).DefaultCellStyle.ForeColor = Color.Black
        End If
      Next
    Next
    txtTotal.Text = cont.ToString
  End Sub

  Private Sub QuitarSeleccionAlumnos()
    If dgvAlumnos.RowCount > 0 Then
      For i As Integer = 0 To Me.dgvAlumnos.RowCount - 1
        dgvAlumnos.Rows(i).Cells("cdAgregar").Value = False
        Me.dgvAlumnos.Rows(i).DefaultCellStyle.BackColor = Color.White
        Me.dgvAlumnos.Rows(i).DefaultCellStyle.ForeColor = Color.Black
      Next
      txtTotal.Text = dgvAlumnos.RowCount.ToString
      dgvAlumnos.Columns("cdAgregar").ReadOnly = True
      cboSeleccionar.Enabled = False
    End If
  End Sub

  Private Sub cboSeccion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSeccion.SelectedIndexChanged
    If cboSeccion.SelectedIndex > -1 Then
      dgvAlumnos.DataSource = Nothing
      dgvGrupoLibro.Rows.Clear()
      ListarAlumnos()
      btnRegistrar.Enabled = False

      If dgvPresentacion.RowCount = 0 Then
        btnNuevo.Enabled = False
        btnAlumnos.Enabled = False
      Else
        btnNuevo.Enabled = True
      End If

    End If
  End Sub

  Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
    Dim pos As Integer = Me.dgvGrupoLibro.Rows.IndexOf(Me.dgvGrupoLibro.CurrentRow)
    Dim obj As RNProgramacionLectura = Nothing
    Dim List As List(Of ProgramacionLectura) = Nothing

    Try
      If Me.dgvGrupoLibro.Rows(pos).Cells("cdImg").Value IsNot Nothing Then

        Seleccionar()

        If MessageBox.Show("¿Está seguro que desea quitar el grupo?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
          obj = New RNProgramacionLectura
          For a As Integer = 0 To dgvAlumnos.RowCount - 1
            List = obj.VerificarExistencia(CInt(Me.dgvAlumnos.Rows(a).Cells("cdCodigoPL").Value))
            If List.Count > 0 Then
              For Each X In List
                obj.Eliminar(New ProgramacionLectura(X.Codigo))
              Next
            End If
          Next
          dgvPresentacion.Focus()
          ListarProgramaciones()
          QuitarSeleccionAlumnos()
          Habilitar()
          btnNuevo.Enabled = True
        End If

      Else
        MessageBox.Show("El Grupo no contiene Alumnos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      obj = Nothing
    End Try

  End Sub

  Private Sub AlumnosAsignados()
    Dim obj As New RNProgramacionLectura
    Dim sec As New Seccion
    Dim cont As Integer = 0
    Dim CodPres As Integer = 0

    Dim pos As Integer = Me.dgvPresentacion.Rows.IndexOf(Me.dgvPresentacion.CurrentRow)
    CodPres = CInt(Me.dgvPresentacion.Rows(pos).Cells("cdCodigoPres").Value)

    sec = CType(cboSeccion.SelectedItem, Seccion)
    lpl = obj.ListarAlumnosAsignados((New Seccion(New Grado(0, sec.Grado.Numero, "", New Nivel(sec.Grado.codigoNivel, "", ""), _
                                 "", "", "", ""), moAnioActual.anio, sec.Letra, New Docente(), "", 0, 0)), moAnioActual.anio, CodPres)

    LimpiarImgAsignados()
    If lpl.Count > 0 Then

      For i As Integer = 0 To Me.dgvAlumnos.RowCount - 1
        For Each P In lpl
          If CType(Me.dgvAlumnos.Rows(i).DataBoundItem, Matricula).Numero = P.Matricula.Numero _
             And CodPres = P.CodigoPresentacion Then
            Me.dgvAlumnos.Rows(i).Cells("cdAsig").Value = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\exito.png")
            Exit For
            'Else
            '   Me.dgvAlumnos.Rows(i).Cells("cdCodigoPL").Value = 0
          End If
        Next
      Next
    End If
  End Sub

  Private Sub LimpiarImgAsignados()
    If dgvAlumnos.RowCount > 0 Then
      For i As Integer = 0 To Me.dgvAlumnos.RowCount - 1
        dgvAlumnos.Rows(i).Cells("cdAsig").Value = Nothing
      Next
    End If
  End Sub

End Class