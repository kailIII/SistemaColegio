
Public Class frmCargaAcademicaAnt

#Region "Variables Globales"
  Private ls As List(Of Seccion) = Nothing  'datos de secion y nivel (S.codigoG)
  Private lc As List(Of Curso) = Nothing  'datos del curso
  Private lp As List(Of PeriodoAcademico) = Nothing
  Private lcc As List(Of DocenteCarga) = Nothing
  Private codigo As Integer = 0
  Private vectorPer(20) As Integer
  Private vectorDoc(20) As Integer
  Private vectorGru(20) As String
  Private vectorDocCar(20) As Integer
  Private vectorReg(20) As Integer
  Private vectorCarga(20) As Integer
  Private sw As Integer = 0
  Private sw2 As Integer = 0
  Private swElim As Integer = 0
  Private s As Seccion
  Private arrayAlumnos(100) As Boolean
  Private swRegistrar As Integer = 0
  Private swClick As Integer = 0
  Private swEntrada As Integer = 0
  Private seccion As Seccion
  Private varEstado As Integer = 0
  Private General As Integer = 0
#End Region

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub MostrarAnioActual()
    Me.txtAnio.Text = moAnioActual.anio
  End Sub

  Private Sub ListarComboGrados()
    Dim objS As RNSeccion = New RNSeccion
    ls = objS.LeerNivelNumSec(New Seccion(0, moAnioActual.anio, CChar("A")))
    If ls.Count > 0 Then
      Me.cboGrado.DisplayMember = "NivelNumeroLetra"
      Me.cboGrado.ValueMember = "NivelNumeroLetra"
      Me.cboGrado.DataSource = ls
    Else
      Me.Close()
      MessageBox.Show("Registre secciones", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub frmCargaAcademica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    MostrarAnioActual()
    ListarComboGrados()
    Me.btnNuevo.Visible = False
    Me.btnQuitar.Visible = False
    Me.cboSeleccionar.SelectedIndex = 0
    Me.txtNroAlu.Text = "0"
  End Sub

  Private Sub LimpiarCursos()
    Me.dgCursos.DataSource = Nothing
    Me.dgCursos.Rows.Clear()
  End Sub

  Private Sub ListarCursos()
    Dim obj As New RNGrado
    Dim pos As Integer = -1

    lc = obj.LeerCursosGrado(New Grado(seccion.Grado.Codigo))
    If ls.Count > 0 Then
      Me.dgCursos.AutoGenerateColumns = False
      Me.dgCursos.DataSource = lc
      Me.dgCursos.Columns(0).DataPropertyName = "Nombre"
      Me.dgCursos.Columns(1).DataPropertyName = "Grupos"
      CheckearCursoRotativo()
      VerificarCargaAsig()

      pos = Me.dgCursos.Rows.IndexOf(Me.dgCursos.CurrentRow)

    End If

    obj = Nothing
  End Sub

  Private Sub CheckearCursoRotativo()
    For i As Integer = 0 To Me.dgCursos.RowCount - 1
      If CType(Me.dgCursos.Rows(i).DataBoundItem, Curso).Rotativo Then
        Me.dgCursos.Rows(i).Cells(2).Value = True
      End If
    Next
  End Sub

  Private Sub VerificarCargaAsig()
    Dim obj As New RNCargaAcademica
    Dim lc As List(Of CargaAcademica) = Nothing
    Dim sec As Seccion = Nothing

    sec = seccion 'CType(Me.cboGrado.SelectedItem, Seccion)
    lc = obj.ListarCargasAcad(New CargaAcademica(0, New Curso(), New Seccion(moAnioActual, New Grado(sec.Grado.Codigo), sec.Letra)))
    If lc.Count > 0 Then
      For i As Integer = 0 To Me.dgCursos.RowCount - 1
        For Each carga As CargaAcademica In lc
          If CType(Me.dgCursos.Rows(i).DataBoundItem, Curso).Codigo = carga.Curso.Codigo Then
            Me.dgCursos.Rows(i).Cells(3).Value = "Asig."
          End If
        Next
      Next
    End If

    lc = Nothing
    sec = Nothing
    obj = Nothing
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    swEntrada = 0
    seccion = CType(Me.cboGrado.SelectedItem, Seccion)
    LimpiarCursos()
    ListarCursos()
    Me.dgCursos.Focus()
    Me.dgCursos.Rows(0).Selected = False
    LimpiarDataGrids()
  End Sub

  Private Sub LimpiarDataGrids()
    Me.dgGrupos.DataSource = Nothing
    Me.dgGrupos.Rows.Clear()
    Me.dgAlumnos.DataSource = Nothing
    Me.dgAlumnos.Rows.Clear()
    Me.btnNuevo.Visible = False
    Me.btnQuitar.Visible = False
  End Sub

  Private Sub dgCursos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCursos.SelectionChanged
    Dim pos As Integer = -1

    If Me.dgCursos.RowCount > 0 Then
      Cancelar()
      pos = Me.dgCursos.Rows.IndexOf(Me.dgCursos.CurrentRow)
      If CStr(Me.dgCursos.Rows(pos).Cells(3).EditedFormattedValue) <> Nothing Then
        If CStr(Me.dgCursos.Rows(pos).Cells(3).EditedFormattedValue) = "Asig." Then
          MostrarCargas()
        End If
      Else
        If CStr(Me.dgCursos.Rows(pos).Cells(3).EditedFormattedValue) = "" Then
          If swEntrada = 1 Then
            AsignarCargas()
          End If
          swEntrada = 1
        End If
      End If
    End If
  End Sub

  Private Sub InsertarPeriodo()
    Dim col As DataGridViewComboBoxColumn = Nothing
    Dim obj As RNPeriodoAcademico
    Dim k As Integer

    col = DirectCast(Me.dgGrupos.Columns("cdPeriodo"), DataGridViewComboBoxColumn)

    If codigo = 2 Or codigo = 4 Then
      obj = New RNPeriodoAcademico
      lp = obj.ListarCodPeriodos(moAnioActual)
      'k = lp.Count
    Else
      lp = New List(Of PeriodoAcademico)
      k = 0
      lp.Insert(k, New PeriodoAcademico(0, Now, Now, True, moAnioActual.anio, "", "Todos"))
    End If

    col.DisplayMember = "Siglas"
    col.ValueMember = "Siglas"
    col.DataSource = lp

    If codigo = 1 Or codigo = 3 Then
      With Me.dgGrupos
        .Rows(.RowCount - 1).Cells(0).Value = "Todos"
        .Rows(.RowCount - 1).Cells(1).Value = "Unico " & CStr(.RowCount)
      End With
    End If

  End Sub

  Public Sub LlenarColDocentes()
    Dim col As DataGridViewComboBoxColumn = Nothing
    Dim obj As New RNDocente
    Dim ld As List(Of Docente)

    col = DirectCast(Me.dgGrupos.Columns("cdDocente"), DataGridViewComboBoxColumn)

    ld = obj.Listar
    If ld.Count > 0 Then
      With col
        .DisplayMember = "NombreCompleto"
        .ValueMember = "NombreCompleto"
        .DataSource = ld
      End With
    End If
    col = Nothing
    ld = Nothing
    obj = Nothing
  End Sub

  Private Sub AsignarCargas()
    Dim pos As Integer = Me.dgCursos.Rows.IndexOf(Me.dgCursos.CurrentRow)

    Me.dgGrupos.Rows.Add()
    If CStr(Me.dgCursos.Rows(pos).Cells(1).Value) = "NO" And CBool(Me.dgCursos.Rows(pos).Cells(2).Value) = False Then
      codigo = 1
    ElseIf CStr(Me.dgCursos.Rows(pos).Cells(1).Value) = "NO" And CBool(Me.dgCursos.Rows(pos).Cells(2).Value) = True Then
      codigo = 2
    ElseIf CStr(Me.dgCursos.Rows(pos).Cells(1).Value) = "SI" And CBool(Me.dgCursos.Rows(pos).Cells(2).Value) = False Then
      codigo = 3
    ElseIf CStr(Me.dgCursos.Rows(pos).Cells(1).Value) = "SI" And CBool(Me.dgCursos.Rows(pos).Cells(2).Value) = True Then
      codigo = 4
    End If
    LlenarFilas()
  End Sub

  Private Sub LlenarFilas()
    InsertarPeriodo()
    LlenarColDocentes()
  End Sub

  Private Sub Cancelar()
    Me.gbSeleccione.Enabled = True
    Me.gbAnio.Enabled = True
    sw = 0
    Me.dgGrupos.Rows.Clear()

    If varEstado = 1 Then
      Me.btnNuevo.Enabled = True
      Me.btnNuevo.Visible = False
      Me.btnQuitar.Visible = False

      Me.dgAlumnos.DataSource = Nothing
      Me.dgAlumnos.Rows.Clear()

      Me.cboSeleccionar.SelectedIndex = 0
      Me.txtNroAlu.Text = "0"
    End If

    For i As Integer = 0 To 20
      vectorReg(i) = 0
      vectorDoc(i) = 0
      vectorDocCar(i) = 0
      vectorGru(i) = ""
      vectorPer(i) = 0
      vectorCarga(i) = 0
    Next

  End Sub

  Private Sub btnConfigurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurar.Click
    Dim pos As Integer
    Dim m As Integer = 0
    Dim obj As RNGrupo
    Dim objC As RNCargaAcademica
    Dim nombre As String
    Dim codPer As Integer
    Dim posCur As Integer = -1
    Dim swLocal As Integer = 0

    Try
      swRegistrar = 0
      pos = Me.dgGrupos.Rows.IndexOf(Me.dgGrupos.CurrentRow)
      If pos > -1 Then
        If vectorPer(pos) = 0 Then
          codPer = 1
        Else
          codPer = vectorPer(pos)
        End If

        If Me.dgGrupos.Rows(pos).Cells(0).EditedFormattedValue.ToString <> "" And Me.dgGrupos.Rows(pos).Cells(1).EditedFormattedValue.ToString <> "" And Me.dgGrupos.Rows(pos).Cells(2).EditedFormattedValue.ToString <> "" Then
          obj = New RNGrupo
          s = seccion 'CType(Me.cboGrado.SelectedItem, Seccion)
          nombre = Me.dgGrupos.Rows(pos).Cells(1).EditedFormattedValue.ToString

          For k As Integer = 0 To Me.dgGrupos.RowCount - 2
            For z As Integer = k + 1 To Me.dgGrupos.RowCount - 1
              With Me.dgGrupos
                If .Rows(k).Cells(1).EditedFormattedValue.ToString = .Rows(z).Cells(1).EditedFormattedValue.ToString Then
                  swLocal = 1
                End If
              End With
            Next
          Next

          If swLocal = 0 Then
            objC = New RNCargaAcademica

            If vectorReg(pos) = 0 Then
              'Registrar
              For i As Integer = 0 To Me.dgAlumnos.RowCount - 1
                If CBool(Me.dgAlumnos.Rows(i).Cells(2).Value) Then
                  m = 1
                  Exit For
                End If
              Next
              If m = 1 Then
                If codigo = 2 Or codigo = 4 Then
                  Registrar(pos)
                ElseIf codigo = 1 Or codigo = 3 Then
                  RegistrarPorPeriodo(pos)
                End If

                If swRegistrar = 1 Then
                  Me.dgGrupos.Rows(pos).Cells("cdBlanco").Value = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\exito.png")
                  Me.btnNuevo.Enabled = True

                  posCur = Me.dgCursos.Rows.IndexOf(Me.dgCursos.CurrentRow)
                  Me.dgCursos.Rows(posCur).Cells(3).Value = "Asig."
                  vectorReg(pos) = 1
                  vectorGru(pos) = Me.dgGrupos.Rows(pos).Cells(1).EditedFormattedValue.ToString
                  Me.btnNuevo.Visible = True
                  Me.btnQuitar.Visible = True
                  'MostrarCarga()
                  lcc = objC.MostrarCargasAcad4(New CargaAcademica(0, New Curso(CType(Me.dgCursos.CurrentRow.DataBoundItem, Curso).Codigo), New Seccion(CType(Me.dgCursos.CurrentRow.DataBoundItem, Curso).Grado.Codigo, moAnioActual.anio, seccion.Letra)))
                  If Me.dgGrupos.RowCount > 1 Then
                    vectorCarga(Me.dgGrupos.RowCount - 1) = vectorCarga(Me.dgGrupos.RowCount - 2)
                  End If
                  'LimpiarDataGrids()
                  'Cancelar()
                  Me.dgCursos.Focus()
                  'Me.dgCursos.ClearSelection()
                End If
              Else
                MessageBox.Show("seleccione alumnos para el grupo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
              End If

            Else
              'Actualizar
              If codigo = 1 Or codigo = 3 Then
                Actualizar()
                ActualizarAlumnos1()
              Else
                ActualizarPorPeriodos()
                ActualizarAlumnos2()
              End If

              If sw2 = 1 Then
                AgregarEstados()
                ContadorGrupo()
              End If
              GuardarEstadosAgregados()

              MessageBox.Show("Configuración actualizada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

              varEstado = 1
              Cancelar()
              varEstado = 0

              MostrarCargas()

              If sw2 = 0 Then
                MessageBox.Show("Para actualizar la lista de alumnos del grupo, click en 'Alumnos Grupo' modifique y click en 'Configuración'", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Question)
              End If
              Me.dgCursos.Focus()
            End If

            QuitarColor()

            Me.dgAlumnos.ClearSelection()
          Else
            MessageBox.Show("Todos los nombres de grupo deben ser diferentes", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
          End If
        Else
          MessageBox.Show("Ingrese todos los campos del grupo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    Finally
      obj = Nothing
      objC = Nothing
    End Try
  End Sub

  Private Sub Registrar(ByVal pos As Integer)
    Dim objC As New RNCargaAcademica
    Dim objDC As New RNDocenteCarga
    Dim objG As New RNGrupo

    Dim alu As Matricula
    Dim s As Seccion
    Dim codigoDocCarga As Integer
    Dim codigoCarga As Integer

    Try
      s = seccion 'CType(Me.cboGrado.SelectedItem, Seccion)

      codigoCarga = objC.Registrar(New CargaAcademica(0, New Curso(CType(Me.dgCursos.CurrentRow.DataBoundItem, Curso).Codigo), New Seccion(CType(Me.dgCursos.CurrentRow.DataBoundItem, Curso).Grado.Codigo, moAnioActual.anio, s.Letra)), moAnioActual)

      'Registrar Docente_carga del periodo
      codigoDocCarga = objDC.Registrar(New DocenteCarga(0, Me.dgGrupos.Rows(pos).Cells(1).Value.ToString, _
                                                        New Docente(vectorDoc(pos)), New CargaAcademica(codigoCarga), _
                                                        New PeriodoAcademico(vectorPer(pos))))
      vectorDocCar(pos) = codigoDocCarga

      For k As Integer = 0 To Me.dgAlumnos.RowCount - 1
        If CBool(Me.dgAlumnos.Rows(k).Cells(2).EditedFormattedValue) Then
          alu = CType(Me.dgAlumnos.Rows(k).DataBoundItem, Matricula)
          objG.Registrar(New Grupo(alu, New DocenteCarga(codigoDocCarga)))
        End If
      Next

      MessageBox.Show("Carga registrada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      swRegistrar = 1
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    Finally
      objC = Nothing
      objDC = Nothing
      objG = Nothing
    End Try
  End Sub

  Private Sub RegistrarPorPeriodo(ByVal pos As Integer)
    Dim objC As New RNCargaAcademica
    Dim objP As New RNPeriodoAcademico
    Dim objM As New RNMatricula
    Dim objDC As New RNDocenteCarga
    Dim objG As New RNGrupo
    Dim s As Seccion
    Dim alu As Matricula
    Dim ldc As List(Of DocenteCarga) = Nothing

    Dim la As List(Of Matricula) = Nothing
    Dim codigoCarga As Integer
    Dim codigoDocCarga As Integer

    Try
      'Registrar carga academica
      codigoCarga = objC.Registrar(New CargaAcademica(0, New Curso(CType(Me.dgCursos.CurrentRow.DataBoundItem, Curso).Codigo), _
                                                      New Seccion(CType(Me.dgCursos.CurrentRow.DataBoundItem, Curso).Grado.Codigo, _
                                                                  moAnioActual.anio, seccion.Letra)), moAnioActual)

      lp = objP.ListarCodPeriodos(moAnioActual)
      s = seccion 'CType(Me.cboGrado.SelectedItem, Seccion)

      For i As Integer = 0 To Me.dgAlumnos.RowCount - 1
        If CBool(Me.dgAlumnos.Rows(i).Cells(2).Value) Then
          ldc = objDC.CodigosDocenteCargaAlumno(New Grupo(New Matricula(CType(Me.dgAlumnos.Rows(i).DataBoundItem, Matricula).Numero), New DocenteCarga(0, "", New Docente(), New CargaAcademica(codigoCarga, New Curso(CType(Me.dgCursos.CurrentRow.DataBoundItem, Curso).Codigo), New Seccion()), New PeriodoAcademico())))
          If ldc.Count > 0 Then
            For Each dc In ldc
              objG.Eliminar(New Grupo(New Matricula(CType(Me.dgAlumnos.Rows(i).DataBoundItem, Matricula).Numero, New Alumno(), 0), New DocenteCarga(dc.Codigo)))
            Next
          End If
        End If
      Next

      For Each per As PeriodoAcademico In lp
        'Registrar Docente_carga por cada periodo
        codigoDocCarga = objDC.Registrar(New DocenteCarga(0, Me.dgGrupos.Rows(pos).Cells(1).Value.ToString, New Docente(vectorDoc(pos)), _
                                                          New CargaAcademica(codigoCarga), New PeriodoAcademico(per.Codigo)))
        vectorDocCar(pos) = codigoDocCarga


        'Registrar Grupo de alumnos en cada periodo
        For k As Integer = 0 To Me.dgAlumnos.RowCount - 1
          If CBool(Me.dgAlumnos.Rows(k).Cells(2).EditedFormattedValue) Then
            alu = CType(Me.dgAlumnos.Rows(k).DataBoundItem, Matricula)
            objG.Registrar(New Grupo(alu, New DocenteCarga(codigoDocCarga)))
          End If
        Next
      Next

      MessageBox.Show("Carga registrada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      swRegistrar = 1
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    Finally
      objC = Nothing
      objP = Nothing
      objM = Nothing
      objDC = Nothing
      objG = Nothing
      lp = Nothing
      la = Nothing
    End Try
  End Sub

  Private Sub Actualizar()
    Dim a As Integer = 0
    Dim m As Integer = 0
    Dim obj As New RNDocenteCarga
    Dim obj2 As New RNCargaAcademica

    Do
      For Each dc In lcc
        If dc.Nombre = vectorGru(a) Then 'And vectorCarga(a) = dc.Carga.Codigo Then
          If vectorDoc(a) < 1 Then
            vectorDoc(a) = dc.Docente.Codigo
          End If
          If dc.Nombre <> Me.dgGrupos.Rows(a).Cells(1).EditedFormattedValue.ToString Then
            dc.Nombre = Me.dgGrupos.Rows(a).Cells(1).EditedFormattedValue.ToString
          End If
          obj.Actualizar(New DocenteCarga(dc.Codigo, dc.Nombre, New Docente(vectorDoc(a)), New CargaAcademica(dc.Carga.Codigo), New PeriodoAcademico(dc.Periodo.Codigo)))
          sw = 1
          m += 1
        End If

        If m = 3 Then
          vectorGru(a) = dc.Nombre
          a += 1
          Exit For
        End If
      Next
      m = 0
    Loop Until (a = CInt((lcc.Count / 3)))
  End Sub

  Private Sub ActualizarPorPeriodos()
    Dim nombre As String
    Dim obj As New RNDocenteCarga
    Dim m As Integer = 0

    If Me.dgGrupos.RowCount > 0 Then
      For Each dc In lcc ' codigos docente carga cuando se mostraron
        For k As Integer = m To Me.dgGrupos.RowCount - 1
          'If Me.dgGrupos.Rows(k).Cells(0).EditedFormattedValue.ToString = dc.Periodo.Siglas Then
          If vectorDoc(k) < 1 Then
            vectorDoc(k) = dc.Docente.Codigo
          End If
          If vectorPer(k) < 1 Then
            vectorPer(k) = dc.Periodo.Codigo
          End If

          nombre = dc.Nombre
          If dc.Nombre <> Me.dgGrupos.Rows(k).Cells(1).EditedFormattedValue.ToString Then
            dc.Nombre = Me.dgGrupos.Rows(k).Cells(1).EditedFormattedValue.ToString
          End If
          obj.Actualizar2(New DocenteCarga(dc.Codigo, dc.Nombre, New Docente(vectorDoc(k)), New CargaAcademica(dc.Carga.Codigo), New PeriodoAcademico(dc.Periodo.Codigo)), nombre.Trim, New PeriodoAcademico(vectorPer(k)))
          sw = 1
          Exit For
          'End If
        Next
        m += 1
      Next

    End If
  End Sub

  Private Sub ActualizarAlumnos1()
    Dim obj As RNGrupo
    Dim dc As DocenteCarga
    Dim pos As Integer
    Dim objD As RNDocenteCarga
    Dim ldc As List(Of DocenteCarga) = Nothing

    If Me.dgAlumnos.RowCount > 0 Then
      obj = New RNGrupo
      objD = New RNDocenteCarga

      For j As Integer = 0 To Me.dgAlumnos.RowCount - 1
        If arrayAlumnos(j) = True Then
          sw2 = 1
          Exit For
        Else
          sw2 = 0
        End If
      Next

      If sw2 = 1 Or swClick = 1 Then
        If swClick = 1 Then
          sw2 = 1
        End If
        For i As Integer = 0 To Me.dgAlumnos.RowCount - 1
          If CBool(Me.dgAlumnos.Rows(i).Cells(2).EditedFormattedValue) <> arrayAlumnos(i) Then
            'AQUI AGREGUE CERRADO
            ldc = objD.CodigosDocenteCarga(New Grupo(CType(Me.dgAlumnos.Rows(i).DataBoundItem, Matricula), _
                                                      New DocenteCarga(0, "", Nothing, _
                                                                       New CargaAcademica(0, CType(Me.dgCursos.CurrentRow.DataBoundItem, Curso), Nothing), Nothing) _
                                                      ))
            If CBool(Me.dgAlumnos.Rows(i).Cells(2).EditedFormattedValue) Then
              'primero eliminar
              If ldc.Count > 0 Then
                For Each dc In ldc
                  If dc.Periodo.Cerrado = False Then
                    obj.Eliminar(New Grupo(DirectCast(Me.dgAlumnos.Rows(i).DataBoundItem, Matricula), dc))
                  End If
                Next
              End If
              'luego registrar
              pos = Me.dgGrupos.Rows.IndexOf(Me.dgGrupos.CurrentRow)
              'AQUI AGREGUE CERRADO
              ldc = objD.CodDocCarNombreGrupo(New DocenteCarga(0, Me.dgGrupos.Rows(pos).Cells(1).EditedFormattedValue.ToString, Nothing, New CargaAcademica(vectorCarga(pos)), Nothing))
              For Each dc In ldc
                If dc.Periodo.Cerrado = False Then
                  obj.Registrar(New Grupo(DirectCast(Me.dgAlumnos.Rows(i).DataBoundItem, Matricula), dc))
                End If
              Next
            Else
              'solo eliminar
              If ldc.Count > 0 Then
                For Each dc In ldc
                  If dc.Periodo.Cerrado = False Then
                    obj.Eliminar(New Grupo(CType(Me.dgAlumnos.Rows(i).DataBoundItem, Matricula), dc))
                  End If
                Next
              End If
            End If
          End If
        Next
      End If
      swClick = 0
    End If
  End Sub

  Private Sub ActualizarAlumnos2()
    Dim obj As RNGrupo
    Dim dc As DocenteCarga
    Dim pos As Integer
    Dim codigo As Integer

    If Me.dgAlumnos.RowCount > 0 Then
      obj = New RNGrupo

      For j As Integer = 0 To Me.dgAlumnos.RowCount - 1
        If arrayAlumnos(j) = True Then
          sw2 = 1
          Exit For
        Else
          sw2 = 0
        End If
      Next

      If sw2 = 1 Then
        pos = Me.dgGrupos.Rows.IndexOf(Me.dgGrupos.CurrentRow)

        For Each dc In lcc
          If dc.Codigo = vectorDocCar(pos) Then
            codigo = dc.Codigo
            Exit For
          Else
            codigo = vectorDocCar(pos)
          End If
        Next

        For i As Integer = 0 To Me.dgAlumnos.RowCount - 1
          If CBool(Me.dgAlumnos.Rows(i).Cells(2).EditedFormattedValue) <> arrayAlumnos(i) Then
            If CBool(Me.dgAlumnos.Rows(i).Cells(2).EditedFormattedValue) Then
              'REGISTRAR
              obj.Registrar(New Grupo(New Matricula(CType(Me.dgAlumnos.Rows(i).DataBoundItem, Matricula).Numero, New Alumno(), 0), New DocenteCarga(codigo)))
            Else
              'ELIMINAR
              obj.Eliminar(New Grupo(New Matricula(CType(Me.dgAlumnos.Rows(i).DataBoundItem, Matricula).Numero, New Alumno(), 0), New DocenteCarga(codigo)))
            End If
          End If
        Next
      End If
    End If
  End Sub

  Private Sub dgGrupos_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgGrupos.EditingControlShowing
    Dim combo As ComboBox
    Dim pos As Integer
    Dim cadena As String

    pos = Me.dgGrupos.Rows.IndexOf(Me.dgGrupos.CurrentRow)
    If Me.dgGrupos.Rows(pos).Cells(1).Value Is Nothing Then
      cadena = ""
    Else
      cadena = Me.dgGrupos.Rows(pos).Cells(1).Value.ToString
    End If
    If e.Control.Text <> cadena Then
      combo = CType(e.Control, ComboBox)

      If Not TypeOf e.Control Is DataGridViewComboBoxEditingControl Then Return

      If combo IsNot Nothing Then
        RemoveHandler combo.SelectedValueChanged, New EventHandler(AddressOf dgGrupos_SelectedValueChanged)
        AddHandler combo.SelectedValueChanged, New EventHandler(AddressOf dgGrupos_SelectedValueChanged)
      End If
    End If
  End Sub

  Private Sub dgGrupos_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
    Dim pos As Integer
    Dim obj As Object
    Dim combo As ComboBox = DirectCast(sender, ComboBox)

    pos = Me.dgGrupos.Rows.IndexOf(Me.dgGrupos.CurrentRow)

    If combo.SelectedIndex > -1 Then

      obj = combo.SelectedItem.GetType()
      If obj.ToString = "Colegio.Entidades.Docente" Then
        vectorDoc(pos) = CType(combo.SelectedItem, Docente).Codigo
      Else
        vectorPer(pos) = CType(combo.SelectedItem, PeriodoAcademico).Codigo
      End If
    End If

  End Sub

  Private Sub dgGrupos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgGrupos.KeyDown
    If (e.KeyCode = Keys.Return) Then
      e.Handled = True
      SendKeys.Send(Chr(Keys.Tab))
    End If
  End Sub

  Private Sub dgGrupos_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgGrupos.SelectionChanged
    Dim s As Seccion

    General = 0
    Try
      If Me.dgGrupos.RowCount > 0 Then
        s = seccion 'CType(Me.cboGrado.SelectedItem, Seccion)
        ListarAlumnosAula(s.Letra)
        GuardarEstadosAgregados()

        Me.lblNroAlu.Text = "Total"
        Me.txtNroAlu.Text = Me.dgAlumnos.RowCount.ToString
      End If

      Me.cboSeleccionar.SelectedIndex = 0
      Me.dgAlumnos.ClearSelection()
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Question)
    End Try
  End Sub

  Public Sub ListarAlumnosAula(ByVal letra As String)
    Dim obj As New RNGrupo
    Dim lm As List(Of Matricula)

    lm = obj.ListarAlumnosSeccion(New CargaAcademica(0, _
            New Curso(CType(Me.dgCursos.CurrentRow.DataBoundItem, Curso).Codigo), _
            New Seccion(CType(Me.dgCursos.CurrentRow.DataBoundItem, Curso).Grado.Codigo, _
            moAnioActual.anio, letra)))
    If lm.Count > 0 Then
      Me.dgAlumnos.AutoGenerateColumns = False
      Me.dgAlumnos.DataSource = lm
      Me.dgAlumnos.Columns(0).DataPropertyName = "NombreAlumno"
      Me.dgAlumnos.Columns(1).DataPropertyName = "LeerSexo2"
    End If
  End Sub

  Private Sub MostrarCargas()
    Dim pos As Integer = Me.dgCursos.Rows.IndexOf(Me.dgCursos.CurrentRow)

    If CStr(Me.dgCursos.Rows(pos).Cells(1).Value) = "NO" And CBool(Me.dgCursos.Rows(pos).Cells(2).Value) = False Then
      codigo = 1
    ElseIf CStr(Me.dgCursos.Rows(pos).Cells(1).Value) = "NO" And CBool(Me.dgCursos.Rows(pos).Cells(2).Value) = True Then
      codigo = 2
    ElseIf CStr(Me.dgCursos.Rows(pos).Cells(1).Value) = "SI" And CBool(Me.dgCursos.Rows(pos).Cells(2).Value) = False Then
      codigo = 3
    ElseIf CStr(Me.dgCursos.Rows(pos).Cells(1).Value) = "SI" And CBool(Me.dgCursos.Rows(pos).Cells(2).Value) = True Then
      codigo = 4
    End If
    MostrarCarga()
    Me.btnNuevo.Visible = True
    Me.btnQuitar.Visible = True
  End Sub

  Private Sub MostrarCarga()
    Dim dc As DocenteCarga
    Dim obj As New RNCargaAcademica
    Dim j As Integer = 0
    Dim pos As Integer
    Dim sw As Integer = 0

    lcc = obj.MostrarCargasAcad4(New CargaAcademica(0, New Curso(CType(Me.dgCursos.CurrentRow.DataBoundItem, Curso).Codigo), New Seccion(CType(Me.dgCursos.CurrentRow.DataBoundItem, Curso).Grado.Codigo, moAnioActual.anio, seccion.Letra)))
    If lcc.Count > 0 Then
      For Each dc In lcc
        For i As Integer = 0 To lcc.Count - 1
          If vectorGru(i) = dc.Nombre And vectorCarga(i) = dc.Carga.Codigo Then
            sw = 1
            Exit For
          End If
        Next

        If sw = 0 Then
          If swElim = 0 Then
            Me.dgGrupos.Rows.Add()
          End If
          With Me.dgGrupos.Rows(j)
            LlenarFilas()
            If codigo = 1 Or codigo = 3 Then
              dc.Periodo.Siglas = "Todos"
            End If
            .Cells(0).Value = dc.Periodo.Siglas
            .Cells(1).Value = dc.Nombre
            .Cells(2).Value = dc.Docente.NombreCompleto
            .Cells(3).Value = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\exito.png")
            vectorDocCar(j) = dc.Codigo
            vectorPer(j) = dc.Periodo.Codigo
            vectorReg(j) = 1
            vectorGru(j) = dc.Nombre
            vectorCarga(j) = dc.Carga.Codigo
            j += 1
          End With
        End If
        sw = 0
      Next
    Else
      pos = Me.dgCursos.Rows.IndexOf(Me.dgCursos.CurrentRow)
      Me.dgCursos.Rows(pos).Cells(3).Value = ""
    End If

  End Sub

  Private Sub cboSeleccionar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSeleccionar.SelectedIndexChanged
    If Me.cboSeleccionar.SelectedIndex > 0 Then
      If Me.dgAlumnos.RowCount > 0 Then
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
    For i As Integer = 0 To Me.dgAlumnos.RowCount - 1
      Me.dgAlumnos.Rows(i).Cells(2).Value = True
    Next
  End Sub

  Private Sub QuitarTodos()
    For i As Integer = 0 To Me.dgAlumnos.RowCount - 1
      Me.dgAlumnos.Rows(i).Cells(2).Value = False
    Next
  End Sub

  Public Sub SeleccionarMismoSexo()
    Dim pos As Integer = Me.dgAlumnos.Rows.IndexOf(Me.dgAlumnos.CurrentRow)
    Dim sexo As String = Me.dgAlumnos.Rows(pos).Cells(1).EditedFormattedValue.ToString

    For i As Integer = 0 To Me.dgAlumnos.RowCount - 1
      If Me.dgAlumnos.Rows(i).Cells(1).EditedFormattedValue.ToString = sexo Then
        Me.dgAlumnos.Rows(i).Cells(2).Value = True
      Else
        Me.dgAlumnos.Rows(i).Cells(2).Value = False
      End If
    Next
  End Sub

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    Me.dgGrupos.Rows.Add()
    LlenarFilas()
    Me.dgGrupos.Rows(Me.dgGrupos.RowCount - 1).Selected = True
    Me.dgGrupos.Rows(Me.dgGrupos.RowCount - 1).Cells(1).Selected = True
    Me.btnNuevo.Enabled = False
  End Sub

  Private Sub btnAlumnos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlumnos.Click
    If Me.dgGrupos.RowCount > 0 Then
      General = 1
      s = seccion 'CType(Me.cboGrado.SelectedItem, Seccion)
      ListarAlumnos(s.Letra)
      AgregarEstados()
      AlumnosSinGrupo()
      GuardarEstadosAgregados()
      swClick = 1
      If Me.dgAlumnos.RowCount > 0 Then
        ContadorGrupo()
      Else
        Me.txtNroAlu.Text = "0"
      End If
      Me.dgAlumnos.ClearSelection()
    End If
  End Sub

  Private Sub AlumnosSinGrupo()
    Dim pos As Integer = Me.dgCursos.Rows.IndexOf(Me.dgCursos.CurrentRow)
    Dim obj As RNGrupo = Nothing
    Dim lm As List(Of Matricula) = Nothing
    Dim cur As Curso = Nothing
    Dim sec As Seccion = Nothing
    Dim sw As Integer

    Try
      If CStr(Me.dgCursos.Rows(pos).Cells(1).Value) = "SI" And CBool(Me.dgCursos.Rows(pos).Cells(2).Value) = False Then
        obj = New RNGrupo
        cur = CType(Me.dgCursos.CurrentRow.DataBoundItem, Curso)
        sec = seccion
        lm = obj.AlumnosSinGrupo(New CargaAcademica(0, New Curso(cur.Codigo), _
                          New Seccion(moAnioActual, New Grado(sec.Grado.Codigo), sec.Letra)))
        If lm.Count > 0 Then
          For i As Integer = 0 To Me.dgAlumnos.RowCount - 1
            sw = 0
            For Each m As Matricula In lm
              If CType(Me.dgAlumnos.Rows(i).DataBoundItem, Matricula).Alumno.Codigo = m.Alumno.Codigo Then
                sw = 1
                Exit For
              End If
            Next
            If sw = 0 Then
              Me.dgAlumnos.Rows(i).Cells(2).Value = False
              Me.dgAlumnos.Rows(i).DefaultCellStyle.BackColor = Color.Yellow
              Me.dgAlumnos.Rows(i).DefaultCellStyle.ForeColor = Color.Black
            End If
          Next
        Else
          For i As Integer = 0 To Me.dgAlumnos.RowCount - 1
            Me.dgAlumnos.Rows(i).Cells(2).Value = False
            Me.dgAlumnos.Rows(i).DefaultCellStyle.BackColor = Color.Yellow
            Me.dgAlumnos.Rows(i).DefaultCellStyle.ForeColor = Color.Black
          Next
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      obj = Nothing
    End Try
  End Sub

  Private Sub QuitarColor()
    For i As Integer = 0 To Me.dgAlumnos.RowCount - 1
      Me.dgAlumnos.Rows(i).Cells(2).Value = False
      Me.dgAlumnos.Rows(i).DefaultCellStyle.BackColor = Color.White
      Me.dgAlumnos.Rows(i).DefaultCellStyle.ForeColor = Color.Black
    Next
  End Sub

  Private Sub ContadorGrupo()
    Dim cont As Integer = 0

    Me.lblNroAlu.Text = "Grupo"
    For i As Integer = 0 To Me.dgAlumnos.RowCount - 1
      If CBool(Me.dgAlumnos.Rows(i).Cells(2).Value) Then    'If CBool(arrayAlumnos(i)) Then
        cont += 1
      End If
    Next
    Me.txtNroAlu.Text = CStr(cont)
  End Sub

  Public Sub ListarAlumnos(ByVal letra As String)
    Dim obj As New RNGrupo
    Dim lm As List(Of Matricula)

    lm = obj.ListarAlumnosSeccion(New CargaAcademica(0, _
                                                     DirectCast(Me.dgCursos.CurrentRow.DataBoundItem, Curso), _
                                                     New Seccion(CType(Me.dgCursos.CurrentRow.DataBoundItem, Curso).Grado.Codigo, _
                                                                 moAnioActual.Anio, letra)))
    If lm.Count > 0 Then
      Me.dgAlumnos.AutoGenerateColumns = False
      Me.dgAlumnos.DataSource = lm
      Me.dgAlumnos.Columns(0).DataPropertyName = "NombreAlumno"
      Me.dgAlumnos.Columns(1).DataPropertyName = "LeerSexo2"
    End If
  End Sub

  Public Sub AgregarEstados()
    Dim obj As New RNGrupo
    Dim ldc As List(Of Matricula) = Nothing
    Dim cur As Curso
    Dim sec As Seccion
    Dim pos As Integer
    Dim k As Integer

    pos = Me.dgGrupos.Rows.IndexOf(Me.dgGrupos.CurrentRow)

    If pos > -1 Then
      cur = CType(Me.dgCursos.CurrentRow.DataBoundItem, Curso)
      sec = seccion 'CType(Me.cboGrado.SelectedItem, Seccion)
      sec.Anio = moAnioActual
      If codigo <> 3 Then
        ldc = obj.ListarAlumnosGrupo2(New DocenteCarga(vectorDocCar(pos), Me.dgGrupos.Rows(pos).Cells(1).EditedFormattedValue.ToString, Nothing, _
                                                        New CargaAcademica(0, cur, sec), New PeriodoAcademico(vectorPer(pos))), _
                                                        k)
      Else
        For Each dc As DocenteCarga In lcc
          If dc.Periodo.Cerrado = False And vectorGru(pos) = dc.Nombre Then
            ldc = obj.ListarAlumnosGrupoEdFis(New DocenteCarga(dc.Codigo, Nothing, New PeriodoAcademico(dc.Periodo.Codigo)))
            Exit For
          End If
        Next
      End If

      If ldc.Count > 0 Then
        For i As Integer = 0 To Me.dgAlumnos.RowCount - 1
          For Each m In ldc
            If CType(Me.dgAlumnos.Rows(i).DataBoundItem, Matricula).Alumno.Codigo = m.Alumno.Codigo Then
              Me.dgAlumnos.Rows(i).Cells(2).Value = True
              Me.dgAlumnos.Rows(i).DefaultCellStyle.BackColor = Color.DarkGreen
              Me.dgAlumnos.Rows(i).DefaultCellStyle.ForeColor = Color.White
              Exit For
            Else
              Me.dgAlumnos.Rows(i).Cells(2).Value = False
              Me.dgAlumnos.Rows(i).DefaultCellStyle.BackColor = Color.White
              Me.dgAlumnos.Rows(i).DefaultCellStyle.ForeColor = Color.Black
            End If
          Next
        Next
      Else
        'Me.dgAlumnos.DataSource = Nothing
        'Me.dgAlumnos.Rows.Clear()
      End If
    End If
  End Sub

  Public Sub GuardarEstadosAgregados()
    For i As Integer = 0 To Me.dgAlumnos.RowCount - 1
      arrayAlumnos(i) = CBool(Me.dgAlumnos.Rows(i).Cells(2).Value)
    Next
  End Sub

  Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
    Dim obj As RNGrupo = Nothing
    Dim objD As RNDocenteCarga = Nothing
    Dim nombre As String = ""
    Dim codigo As Integer
    Dim ldc As List(Of DocenteCarga) = Nothing
    Dim pos As Integer

    Try
      If Me.dgGrupos.RowCount > 1 Then
        pos = Me.dgGrupos.Rows.IndexOf(Me.dgGrupos.CurrentRow)
        nombre = Me.dgGrupos.Rows(pos).Cells(1).EditedFormattedValue.ToString
        s = seccion 'CType(Me.cboGrado.SelectedItem, Seccion)

        If MessageBox.Show("En verdad desea quitar el grupo", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
          obj = New RNGrupo
          codigo = obj.CodigoCarga(New DocenteCarga(0, nombre, Nothing, New CargaAcademica(0, New Curso(CType(Me.dgCursos.CurrentRow.DataBoundItem, Curso).Codigo), New Seccion(CType(Me.dgCursos.CurrentRow.DataBoundItem, Curso).Grado.Codigo, moAnioActual.Anio, s.Letra)), Nothing))
          If codigo > 0 Then

            objD = New RNDocenteCarga

            ldc = objD.CodigosDocenteCarga(New DocenteCarga(0, Me.dgGrupos.Rows(pos).Cells(1).EditedFormattedValue.ToString, _
                                                    Nothing, New CargaAcademica(codigo), Nothing))
            For Each dc As DocenteCarga In ldc
              obj.EliminarGrupo(New Grupo(Nothing, dc))
            Next
          End If

          Me.dgGrupos.Rows.RemoveAt(pos)
          For i As Integer = pos To 20 - 1
            vectorReg(i) = vectorReg(i + 1) ''para saber cuales son las filas registradas
            vectorDoc(i) = vectorDoc(i + 1)
            vectorDocCar(i) = vectorDocCar(i + 1)
            vectorGru(i) = vectorGru(i + 1)
            vectorPer(i) = vectorPer(i + 1)
            vectorCarga(i) = vectorCarga(i + 1)
          Next
          swElim = 1
          MostrarCarga()
          swElim = 0

        End If
        Me.btnNuevo.Enabled = True

      Else
        MessageBox.Show("Grupo no se puede quitar, debe existir uno como mínimo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    Finally
      obj = Nothing
      objD = Nothing
    End Try

  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Cancelar()
    Me.dgCursos.Focus()
  End Sub

End Class