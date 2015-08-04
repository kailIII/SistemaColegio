Public Class frmGestionIndicadores
  Private codigo As Integer
  Private NombreInd As String
  Private Ldc As New List(Of DocenteCarga)


  Private Sub frmGestionIndicadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btncancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnEditar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Editar.jpg")

    'Me.txtNombre.CharacterCasing = CharacterCasing.Upper

    codigo = 0
    Me.txtPeriodo.Text = moAnioActual.Anio & "    -    " & mOPeriodoActual.Nombre
    MostrarCursosSeccion()
    ListarIndicadores()
    Pintar()
  End Sub
  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub MostrarCursosSeccion()
    Dim objRN As New RNDocenteCarga

    Ldc = objRN.ListarCargaSeccion(mOPeriodoActual, New Docente(mOUsuario.Persona.Codigo))
    If Ldc.Count > 0 Then
      cboCursoSeccion.DisplayMember = "CursoSeccion"
      cboCursoSeccion.ValueMember = "Codigo"
      cboCursoSeccion.DataSource = Ldc
    Else
      cboCursoSeccion.DataSource = Nothing
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim Ind As Indicador = Nothing
    Dim Obj As RNIndicador = Nothing
    Dim Objdc As RNDocenteCarga = Nothing
    Dim dc As DocenteCarga = Nothing
    Dim ListaInd As List(Of Indicador) = Nothing
    Dim listdc As List(Of DocenteCarga) = Nothing
    Dim NRO As Integer = 0

    dc = CType(Me.cboCursoSeccion.SelectedItem, DocenteCarga)
    If Me.ValidateChildren Then
      Obj = New RNIndicador
      Objdc = New RNDocenteCarga
      Try
        NRO = dgvCriterios.RowCount + 1
        If dc.Carga.Curso.Grupo = True Or dc.Carga.Curso.Rotativo = True Then
          If codigo = 0 Then
            Obj.Registrar(New Indicador(Nothing, txtNombre.Text, True, mOPeriodoActual.Codigo, dc.Codigo, NRO))
            MessageBox.Show("Indicador registrado con éxito ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          Else
            Obj.Actualizar(New Indicador(codigo, txtNombre.Text, CheckVigencia.Checked, mOPeriodoActual.Codigo, dc.Codigo, NRO))
            MessageBox.Show("Indicador actualizado con éxito ", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          End If
        Else
          listdc = Objdc.ListarDocenteCargaIndicadores(New DocenteCarga(0, dc.Nombre, New Docente(mOUsuario.Persona.Codigo), _
                                                         New CargaAcademica(0, New Curso(dc.Carga.Curso.Codigo), _
                                                         New Seccion(moAnioActual, _
                                                         New Grado(dc.Carga.Seccion.Grado.Codigo), "l"c)), _
                                                         New PeriodoAcademico(dc.Periodo.Codigo)))
          If codigo = 0 Then
            For Each d As DocenteCarga In listdc
              Obj.Registrar(New Indicador(Nothing, txtNombre.Text, True, mOPeriodoActual.Codigo, d.Codigo, NRO))
            Next
            MessageBox.Show("Indicadores registrados con éxito en todas las secciones del mismo grado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          Else
            For Each d As DocenteCarga In listdc
              ListaInd = Obj.ListarIndicadoresMod(New DocenteCarga(d.Codigo, Nothing, _
                                                      mOPeriodoActual), NombreInd)
              For i As Integer = 0 To ListaInd.Count - 1
                Obj.Actualizar(New Indicador(ListaInd(i).Codigo, txtNombre.Text, CheckVigencia.Checked, mOPeriodoActual.Codigo, d.Codigo, NRO))
              Next
            Next
            MessageBox.Show("Indicadores actualizados con éxito en todas las secciones del mismo grado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          End If
        End If
        Limpiar()
        ListarIndicadores()
        Pintar()
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        Obj = Nothing
        Ind = Nothing

      End Try
    End If

  End Sub

  Private Sub cboCursoSeccion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCursoSeccion.SelectedIndexChanged
    If cboCursoSeccion.SelectedIndex > -1 Then
      Limpiar()
      ListarIndicadores()
      Pintar()
    End If
  End Sub

  Private Sub ListarIndicadores()
    Dim obj As New RNIndicador
    Dim LInd As New List(Of Indicador)

    LInd = obj.ListarIndicadores_Seccion(New DocenteCarga(CInt(cboCursoSeccion.SelectedValue), Nothing, _
                                                           mOPeriodoActual))

    If cboCursoSeccion.SelectedIndex > -1 Then
      If LInd.Count > 0 Then
        dgvCriterios.AutoGenerateColumns = False
        dgvCriterios.DataSource = LInd
        Ordenar()
      Else
        dgvCriterios.DataSource = Nothing
        dgvCriterios.Refresh()
      End If
    Else
      MessageBox.Show("No ha seleccionado un Curso", "Gestión de Indicadores", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub
  Public Sub Pintar()
    For i As Integer = 0 To dgvCriterios.Rows.Count - 1
      If CType(dgvCriterios.Rows(i).DataBoundItem, Indicador).Vigencia = False Then
        Me.dgvCriterios.Rows(i).DefaultCellStyle.BackColor = Color.Gray
        Me.dgvCriterios.Rows(i).DefaultCellStyle.ForeColor = Color.White
      End If
    Next
  End Sub
  Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click, dgvCriterios.DoubleClick
    Dim obj As RNIndicador = Nothing
    Dim Ind As Indicador = Nothing

    If dgvCriterios.SelectedRows.Count > 0 Then
      With CType(dgvCriterios.SelectedRows.Item(0).DataBoundItem, Indicador)
        obj = New RNIndicador
        Ind = obj.Leer(New Indicador(.Codigo))
        If Ind IsNot Nothing Then
          codigo = .Codigo
          txtNombre.Text = Ind.Nombre
          NombreInd = Ind.Nombre
          If Ind.Vigencia Then
            Me.CheckVigencia.Checked = True
          Else
            Me.CheckVigencia.Checked = False
          End If

          CheckVigencia.Visible = True
          Me.btnRegistrar.Text = "&Actualizar"


          Me.txtNombre.Focus()
        Else
          MessageBox.Show("No se pudo encontrar al indicador solicitado", "Gestión de Indicadores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      End With
    End If
  End Sub
  Private Sub Limpiar()
    Me.codigo = 0
    Me.txtNombre.Text = ""
    Me.CheckVigencia.Checked = False
    Me.CheckVigencia.Visible = False
    Me.btnRegistrar.Text = "&Registrar"
    Me.CheckVigencia.Checked = False
    Me.txtNombre.Focus()
  End Sub

  Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
    Limpiar()
    ErrIndicador.SetError(txtNombre, "")
    ErrIndicador.SetError(cboCursoSeccion, "")
  End Sub

  Private Sub txtNombre_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
    If txtNombre.Text.Length = 0 Then
      e.Cancel = True
      ErrIndicador.SetError(txtNombre, "Ingrese nombre del indicador")
    Else
      ErrIndicador.SetError(txtNombre, "")
    End If
  End Sub

  Private Sub txtPeriodo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPeriodo.Enter
    cboCursoSeccion.Focus()
  End Sub

  Private Sub cboCursoSeccion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboCursoSeccion.Validating
    If cboCursoSeccion.SelectedIndex = -1 Then
      e.Cancel = True
      ErrIndicador.SetError(cboCursoSeccion, "Seleccione el Curso")
    Else
      ErrIndicador.SetError(cboCursoSeccion, "")
    End If
  End Sub


  Private Sub btnSubir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubir.Click
    Dim Ind1 As String = ""
    Dim Ind2 As String = ""
    Dim pos As Integer = 0

    pos = dgvCriterios.CurrentCell.RowIndex
    If dgvCriterios.CurrentRow.Index > 0 Then

      Ind1 = dgvCriterios.Rows(pos).Cells("cdCriterio").Value.ToString
      Ind2 = dgvCriterios.Rows(pos - 1).Cells("cdCriterio").Value.ToString
      dgvCriterios.Rows(pos).Cells("cdCriterio").Value = Ind2
      dgvCriterios.Rows(pos - 1).Cells("cdCriterio").Value = Ind1

      dgvCriterios.Rows(pos - 1).Selected = True
      dgvCriterios.Rows(pos - 1).Cells("cdCriterio").Selected = True

    End If

  End Sub
  Private Sub btnbajar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbajar.Click
    Dim Ind1 As String = ""
    Dim Ind2 As String = ""
    Dim pos As Integer = 0

    pos = dgvCriterios.CurrentCell.RowIndex

    If pos < dgvCriterios.RowCount - 1 Then

      Ind1 = dgvCriterios.Rows(pos).Cells("cdCriterio").Value.ToString
      Ind2 = dgvCriterios.Rows(pos + 1).Cells("cdCriterio").Value.ToString
      dgvCriterios.Rows(pos).Cells("cdCriterio").Value = Ind2
      dgvCriterios.Rows(pos + 1).Cells("cdCriterio").Value = Ind1

      dgvCriterios.Rows(pos + 1).Selected = True
      dgvCriterios.Rows(pos + 1).Cells("cdCriterio").Selected = True

    End If

  End Sub

  Private Sub Ordenar()
    For i As Integer = 0 To dgvCriterios.RowCount - 1
      If CInt(dgvCriterios.Rows(i).Cells("cdNro").Value) = 0 And CBool(dgvCriterios.Rows(i).Cells("cdNro").Value) = True Then
        dgvCriterios.Rows(i).Cells("cdNro").Value = i + 1

      End If
    Next
  End Sub

  Private Sub btnOrdenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdenar.Click
    Dim Ind As Indicador = Nothing
    Dim Obj As RNIndicador = Nothing
    Dim Objdc As RNDocenteCarga = Nothing
    Dim dc As DocenteCarga = Nothing
    Dim ListaInd As List(Of Indicador) = Nothing
    Dim listdc As List(Of DocenteCarga) = Nothing

    dc = CType(Me.cboCursoSeccion.SelectedItem, DocenteCarga)
    Try
      Obj = New RNIndicador
      Objdc = New RNDocenteCarga

      If dc.Carga.Curso.Grupo = False Or dc.Carga.Curso.Rotativo = True Then
        For i As Integer = 0 To dgvCriterios.RowCount - 1
          Obj.OrdenarUno(New Indicador(CInt(dgvCriterios.Rows(i).Cells("cdCodigo").Value), _
                                      "", CInt(dgvCriterios.Rows(i).Cells("cdNro").Value), mOPeriodoActual.Codigo))
        Next
        MessageBox.Show("Criterios ordenados con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Else

        listdc = Objdc.ListarDocenteCargaIndicadores(New DocenteCarga(0, dc.Nombre, New Docente(mOUsuario.Persona.Codigo), _
                                                       New CargaAcademica(0, New Curso(dc.Carga.Curso.Codigo), _
                                                       New Seccion(moAnioActual, _
                                                       New Grado(dc.Carga.Seccion.Grado.Codigo), CChar("l"))), _
                                                       New PeriodoAcademico(dc.Periodo.Codigo)))
        If listdc.Count > 0 Then
          For Each d As DocenteCarga In listdc
            For i As Integer = 0 To dgvCriterios.RowCount - 1
              Obj.OrdenarTodos(New Indicador(d.Codigo, dgvCriterios.Rows(i).Cells("cdCriterio").Value.ToString, _
                                           CInt(dgvCriterios.Rows(i).Cells("cdNro").Value), mOPeriodoActual.Codigo))
            Next
          Next
          MessageBox.Show("Criterios Ordenados con éxito en todas las secciones del mismo grado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      End If
      Limpiar()
      ListarIndicadores()
      Pintar()
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Obj = Nothing
      Ind = Nothing

    End Try

  End Sub

End Class