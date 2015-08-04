
Public Class frmRegistroNotasPeriodo
  Private mPeriodo As Integer
  Private mcodPeriodo As Integer
  Public Property Periodo() As Integer
    Get
      Return mPeriodo
    End Get
    Set(ByVal value As Integer)
      mPeriodo = value
    End Set
    End Property


  Private Sub cboNivel_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboNivel.Validating
    If cboNivel.SelectedIndex = -1 Then
      e.Cancel = True
      ErrListarNotas.SetError(cboNivel, "Debe indicar el Nivel")
    Else
      ErrListarNotas.SetError(cboNivel, "")
    End If
  End Sub

  Private Sub cboGrado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboGrado.Validating
    If cboGrado.SelectedIndex = -1 Then
      e.Cancel = True
      ErrListarNotas.SetError(cboGrado, "Debe indicar el Grado")
    Else
      ErrListarNotas.SetError(cboGrado, "")
    End If
  End Sub

  Private Sub cboSeccion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboSeccion.Validating
    If cboSeccion.SelectedIndex = -1 Then
      e.Cancel = True
      ErrListarNotas.SetError(cboSeccion, "Debe indicar la Sección")
    Else
      ErrListarNotas.SetError(cboSeccion, "")
    End If
  End Sub

  Private Sub cboCurso_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboCurso.Validating
    If cboCurso.SelectedIndex = -1 Then
      e.Cancel = True
      ErrListarNotas.SetError(cboCurso, "Debe indicar el Curso")
    Else
      ErrListarNotas.SetError(cboCurso, "")
    End If
  End Sub
  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub RegistroNotasPeriodo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ListarNiveles()
    MostrarPeriodo()
    btnRegistrar.Text = "&Registrar"
  End Sub

  Public Sub MostrarPeriodo()
    Dim obj As New RNPeriodoAcad
    Dim ln As PeriodoAcademico

    'ln = obj.MostrarPeriodo(Periodo)
        ln = obj.MostrarPeriodo(mOPeriodoActual.Codigo)
    txtperiodo.Text = ln.Nombre
    txtanio.Text = ln.Anio

  End Sub
  Public Sub ListarNiveles()
    Dim obj As New RNNivel
    Dim ln As List(Of Nivel)

    ln = obj.Listar
    Me.cboNivel.DisplayMember = "Nombre"
    Me.cboNivel.ValueMember = "Nombre"
    Me.cboNivel.DataSource = ln
  End Sub


  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboNivel.SelectedIndexChanged
    Dim objNivel As Nivel = Nothing
    Dim obj As New RNGrado
    Dim lg As List(Of Grado)

    objNivel = CType(Me.cboNivel.SelectedItem, Nivel)
    If cboNivel.SelectedIndex > -1 Then
      cboGrado.Text = ""
      Me.cboSeccion.Text = ""
      Me.cboCurso.Text = ""
      lg = obj.Listar(objNivel)
      Me.cboGrado.DisplayMember = "Nombre"
      Me.cboGrado.ValueMember = "codigo"
      Me.cboGrado.DataSource = lg
    Else
      cboGrado.DataSource = Nothing
      cboGrado.Text = ""
      Me.cboSeccion.Text = ""
      Me.cboCurso.Text = ""
    End If
  End Sub

  Private Sub cboGrado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboGrado.SelectedIndexChanged
    Dim objGrado As Grado = Nothing

    Dim obj As New RNSeccion
    Dim ls As List(Of Seccion)

    objGrado = CType(Me.cboGrado.SelectedItem, Grado)
    If cboGrado.SelectedIndex > -1 Then
      Me.cboSeccion.Text = ""
      Me.cboCurso.Text = ""
      Me.txtDocente.Text = ""
            ls = obj.Listar(New Seccion(objGrado.Codigo, moAnioActual.anio, Nothing))
      Me.cboSeccion.DisplayMember = "Letra"
      Me.cboSeccion.ValueMember = "Letra"
      Me.cboSeccion.DataSource = ls
    Else
      Me.cboSeccion.DataSource = Nothing
      Me.cboSeccion.Text = ""
      Me.cboCurso.Text = ""
    End If
  End Sub

  Private Sub cboCurso_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCurso.Enter
    Dim obj As New RNCargaAcademica
    Dim ls As List(Of CargaAcademica)
    If cboSeccion.SelectedIndex > -1 Then
      Me.cboCurso.Text = ""
      Me.txtDocente.Text = ""

            ls = obj.ListarCursosNivel_Grado_Seccion(New Seccion(CInt(cboGrado.SelectedValue), moAnioActual.anio, CChar(cboSeccion.SelectedValue)))
            Me.cboCurso.DisplayMember = "nombre_Curso"
            Me.cboCurso.ValueMember = "codigoCurso"
      Me.cboCurso.DataSource = ls
      btnListar.Enabled = True
    Else
      Me.cboCurso.DataSource = Nothing
      Me.cboCurso.Text = ""
      Me.txtDocente.Text = ""
    End If
  End Sub

  Private Sub cboCurso_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCurso.SelectedIndexChanged
    If cboSeccion.SelectedIndex > -1 Then
      If cboCurso.SelectedIndex > -1 Then
        Me.txtDocente.Text = CType(cboCurso.SelectedItem, CargaAcademica).Docente.NombreCompleto
      Else
        Me.txtDocente.Text = ""
      End If
    Else
      cboCurso.Text = ""
      txtDocente.Text = ""
    End If

  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim obj As New RNPromedioPeriodoCurso
    Dim la As List(Of PromedioPeriodoCurso)
    If Me.ValidateChildren() Then
            la = obj.ListarMatriculados_Seccion(New CargaAcademica(CType(cboCurso.SelectedItem, CargaAcademica).Codigo, _
                                                                    moAnioActual.anio, CInt(cboGrado.SelectedValue), CChar(cboSeccion.SelectedValue)))
      dgvAlumNotas.AutoGenerateColumns = False
            dgvAlumNotas.DataSource = la

            If la.Count > 0 Then
                btnRegistrar.Enabled = True
                'If CType(dgvAlumNotas.Item("cdCodigoProm", 1).Value, Integer) = 0 Then

                '    btnRegistrar.Text = "&Registrar"
                'Else
                '    btnRegistrar.Enabled = True
                '    btnRegistrar.Text = "&Actualizar"
                'End If
            Else
                btnRegistrar.Enabled = False
                MsgBox("No Existen Alumnos")
            End If
    Else
                    dgvAlumNotas.DataSource = Nothing
                    btnRegistrar.Enabled = False
        End If



    End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim obj As New RNPromedioPeriodoCurso
    Dim estado As Integer
    estado = 0
    Try
      If dgvAlumNotas.RowCount > 0 Then

        Dim Periodo As New PeriodoAcademico

        For i As Integer = 0 To dgvAlumNotas.RowCount - 1
                    Periodo.Codigo = mOPeriodoActual.Codigo
          If CType(dgvAlumNotas.Rows(i).Cells("cdCodigoProm").Value, Integer) = 0 Then
            estado = 0

            obj.Registrar(New PromedioPeriodoCurso(Nothing, Periodo.Codigo, CType(cboCurso.SelectedItem, CargaAcademica).Codigo, _
                                                CType(dgvAlumNotas.Rows(i).Cells("cdNroMatricula").Value, Integer), Nothing, _
                                                CType(dgvAlumNotas.Rows(i).Cells("cdNota").Value, Double)))
                    Else

                        obj.ModificarNotas(New PromedioPeriodoCurso(CType(dgvAlumNotas.Rows(i).Cells("cdCodigoProm").Value, Integer), _
                                                                 Nothing, Nothing, Nothing, Nothing, _
                                                                 CType(dgvAlumNotas.Rows(i).Cells("cdNota").Value, Double)))
                        estado = 1
          End If

        Next
        If estado = 0 Then
          MessageBox.Show("Notas Registradas exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          MessageBox.Show("Notas Actualizadas exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      obj = Nothing
    End Try

  End Sub

  
End Class

