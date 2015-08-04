Public Class frmGestionUnidades
  Private Ldc As List(Of DocenteCarga) = Nothing
  Dim ld As List(Of Unidad) = Nothing
  Private codigo As Integer = 0
  Private rows As Integer = 0
  Private Cod As Integer = 0

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub frmGestionUnidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.MostrarImagenes()
    Me.MostrarAnioPeriodo()
    Me.MostrarCursosSeccion()
    Me.Limpiar(0)
    Me.chkRegistrar.Visible = True
    'Me.btnGenerar.Enabled = True
    Me.btnAgregar.Visible = False
  End Sub

  Public Sub MostrarImagenes()
    Me.btnAceptar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
  End Sub

  Private Sub MostrarAnioPeriodo()
    Me.txtAnio.Text = moAnioActual.anio & "    -    " & mOPeriodoActual.Nombre
  End Sub

  Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
    If Me.nuUnidades.Value > 0 Then
      If Me.cboCurso.Text <> "" Then
        If Me.dgUnidades.RowCount > 0 Then
          Me.dgUnidades.Rows.Clear()
        End If
        AgregarFilas()
      Else
        MessageBox.Show("No a seleccionado nombre de curso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If
    Else
      MessageBox.Show("Ingrese nro. de unidades", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Public Sub AgregarFilas()
    For i As Integer = 0 To CInt(Me.nuUnidades.Value) - 1
      Me.dgUnidades.Rows.Add()
      Me.dgUnidades.Rows(i).Cells(0).Value = i + 1
      Me.dgUnidades.Rows(i).Cells(2).Value = True
    Next
  End Sub

  Private Sub MostrarCursosSeccion()
    Dim objRN As New RNDocenteCarga

    Ldc = objRN.ListarCargaSeccion2(mOPeriodoActual, New Docente(mOUsuario.Persona.Codigo))
    If Ldc.Count > 0 Then
      cboCurso.DisplayMember = "CursoSeccion"
      cboCurso.ValueMember = "Codigo"
      cboCurso.DataSource = Ldc
    Else
      cboCurso.DataSource = Nothing
    End If
  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    Dim k As Integer = 0

    If Me.dgUnidades.RowCount > 0 Then
      For i As Integer = 0 To Me.dgUnidades.RowCount - 1
        If Me.dgUnidades.Rows(i).Cells(1).EditedFormattedValue.ToString = "" Then
          k = 1
          Exit For
        End If
      Next
      If k = 0 Then
        Try
          Registrar()
        Catch ex As Exception
          MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
      Else
        MessageBox.Show("Ingrese el nombre de todas las unidades", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If
    Else
      MessageBox.Show("No ha ingresado unidades", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If

  End Sub

  Private Sub Registrar()
    Dim obj As New RNUnidad
    Dim dc As DocenteCarga = Nothing

    dc = CType(Me.cboCurso.SelectedItem, DocenteCarga)

    If codigo = 0 Then
      If Me.chkRegistrar.Checked Then
        RegistrarTodasSecciones(dc, obj)
      Else
        With Me.dgUnidades.Rows
          For i As Integer = 0 To Me.dgUnidades.RowCount - 1
            obj.Registrar(New Unidad(CInt(.Item(i).Cells(0).EditedFormattedValue), .Item(i).Cells(1).EditedFormattedValue.ToString, _
                                     CBool(.Item(i).Cells(2).EditedFormattedValue), _
                                     New PeriodoAcademico(dc.Periodo.Codigo), New DocenteCarga(dc.Codigo)))
          Next
        End With
      End If
      MessageBox.Show("Datos registrados con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    ElseIf codigo = 1 Then
      With Me.dgUnidades.Rows
        For i As Integer = 0 To rows - 1
          obj.Actualizar(New Unidad(CInt(.Item(i).Cells(0).EditedFormattedValue), .Item(i).Cells(1).EditedFormattedValue.ToString, _
                                    CBool(.Item(i).Cells(2).EditedFormattedValue), _
                                    New PeriodoAcademico(dc.Periodo.Codigo), New DocenteCarga(dc.Codigo)))
        Next
      End With

      If Me.dgUnidades.RowCount > rows Then
        For i As Integer = rows To Me.dgUnidades.RowCount - 1
          obj.Registrar(New Unidad(CInt(Me.dgUnidades.Rows(i).Cells(0).EditedFormattedValue), Me.dgUnidades.Rows(i).Cells(1).EditedFormattedValue.ToString, CBool(Me.dgUnidades.Rows(i).Cells(2).EditedFormattedValue), New PeriodoAcademico(dc.Periodo.Codigo), New DocenteCarga(dc.Codigo)))
        Next
      End If

      MessageBox.Show("Datos actualizados con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
    Limpiar(0)
    Me.cboCurso.Focus()
    Me.chkRegistrar.Visible = True
    Me.btnGenerar.Enabled = True
    Me.nuUnidades.Enabled = True
  End Sub

  Private Sub RegistrarTodasSecciones(ByVal dc As DocenteCarga, ByVal objD As RNUnidad)
    Dim obj As New RNDocenteCarga
    Dim ldc As List(Of DocenteCarga) = Nothing

    ldc = obj.ListarCodDocenteCarga(New DocenteCarga(0, dc.Nombre, New Docente(mOUsuario.Persona.Codigo), _
                                                     New CargaAcademica(0, New Curso(dc.Carga.Curso.Codigo), _
                                                     New Seccion(moAnioActual, _
                                                     New Grado(dc.Carga.Seccion.Grado.Codigo), "l"c)), _
                                                     New PeriodoAcademico(dc.Periodo.Codigo)))
    'Codigo docente

    For Each d As DocenteCarga In ldc
      For i As Integer = 0 To Me.dgUnidades.RowCount - 1
        objD.Registrar(New Unidad(CInt(Me.dgUnidades.Rows(i).Cells(0).EditedFormattedValue), _
                                  Me.dgUnidades.Rows(i).Cells(1).EditedFormattedValue.ToString, _
                                  CBool(Me.dgUnidades.Rows(i).Cells(2).EditedFormattedValue), _
                                  New PeriodoAcademico(dc.Periodo.Codigo), New DocenteCarga(d.Codigo)))
      Next
    Next

  End Sub

  Private Sub cboCurso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCurso.SelectedIndexChanged
    Dim obj As RNUnidad = Nothing    

    If Me.cboCurso.SelectedIndex > -1 Then
      obj = New RNUnidad
      ld = obj.ListarUnidades(CType(Me.cboCurso.SelectedItem, DocenteCarga))
      If ld.Count > 0 Then
        rows = ld.Count
        Me.dgUnidades.AutoGenerateColumns = False
        Me.dgUnidades.DataSource = ld
        Me.dgUnidades.Columns(0).DataPropertyName = "Numero"
        Me.dgUnidades.Columns(1).DataPropertyName = "Nombre"
        ListarVigencias(ld)
        Me.nuUnidades.Value = Me.dgUnidades.RowCount
        ModificarBoton()
      Else
        Limpiar(1)
        Me.btnGenerar.Enabled = True
        Me.nuUnidades.Enabled = True
      End If
    End If
  End Sub

  Public Sub ListarVigencias(ByVal ld As List(Of Unidad))
    Dim k As Integer = 0

    For Each un As Unidad In ld
      If un.Vigencia Then
        Me.dgUnidades.Rows(k).Cells(2).Value = True
      Else
        Me.dgUnidades.Rows(k).Cells(2).Value = False
      End If
      k += 1
    Next
  End Sub

  Public Sub ModificarBoton()
    Me.btnAceptar.Text = "&Actualizar"
    codigo = 1
    Me.chkRegistrar.Visible = False
    Me.btnGenerar.Enabled = False
    Me.nuUnidades.Enabled = False
    Me.btnAgregar.Visible = True
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Limpiar(0)
    Me.btnGenerar.Enabled = True
    Me.nuUnidades.Enabled = True
  End Sub

  Public Sub Limpiar(ByVal valor As Integer)
    Me.dgUnidades.DataSource = Nothing
    Me.dgUnidades.Rows.Clear()
    codigo = 0
    Me.btnAceptar.Text = "&Registrar"
    Me.nuUnidades.Value = 2
    If valor = 0 Then
      Me.cboCurso.SelectedIndex = -1
    End If
    Me.chkRegistrar.Checked = False
    Me.chkRegistrar.Visible = True
    Me.btnAgregar.Visible = False
  End Sub

  Private Sub dgUnidades_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgUnidades.KeyDown
    If e.KeyCode = Keys.Delete Then
      dgUnidades.CurrentRow.Cells.Item(1).Value = ""
    End If
  End Sub

  Private Sub dgUnidades_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgUnidades.KeyPress
    If Convert.ToInt16(e.KeyChar) = 22 Then
      dgUnidades.Rows.Item(dgUnidades.CurrentCell.RowIndex).Cells.Item(1).Value = Clipboard.GetText
    End If
  End Sub

  Private Sub btnAgregar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
    ld.Insert(Me.dgUnidades.RowCount, New Unidad(Me.dgUnidades.RowCount + 1, "", True, mOPeriodoActual, CType(Me.cboCurso.SelectedItem, DocenteCarga)))
    Me.dgUnidades.DataSource = Nothing

    Me.dgUnidades.AutoGenerateColumns = False
    Me.dgUnidades.DataSource = ld
    Me.dgUnidades.Columns(0).DataPropertyName = "Numero"
    Me.dgUnidades.Columns(1).DataPropertyName = "Nombre"
    ListarVigencias(ld)
  End Sub
End Class