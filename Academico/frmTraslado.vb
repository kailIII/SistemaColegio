
Public Class frmTraslado
  Private ls As List(Of Seccion) = Nothing
  Private codigoEstado As Integer
  Private codigoAlu As Integer

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub frmTraslado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.txtPeriodo.Text = mOPeriodoActual.Anio & " - " & mOPeriodoActual.Nombre
    MostrarImagenes()
    ListarTraslados()
    ListarGrados()
    Me.cboGrado.SelectedIndex = -1
    Me.cboAlumno.SelectedIndex = -1
    Me.txtDescripcion.Text = "Trasladado(a) en el periodo " & Me.txtPeriodo.Text
  End Sub

  Private Sub MostrarImagenes()
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
  End Sub

  Private Sub ListarGrados()
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

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub cboTipoTras_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoTras.SelectedIndexChanged
    If Me.cboTipoTras.SelectedIndex > -1 Then
      If Me.cboTipoTras.SelectedIndex = 0 Then
        Me.btnCarga.Visible = True
      Else
        Me.btnCarga.Visible = False
      End If
    End If
  End Sub

  Private Sub cboGrado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrado.SelectedIndexChanged
    If Me.cboGrado.SelectedIndex > -1 Then
      ListarAlumnosGrado()
      Me.cboAlumno.Enabled = True
    Else
      Me.cboAlumno.Enabled = False
    End If
  End Sub

  Private Sub ListarAlumnosGrado()
    Dim obj As New RNMatricula
    Dim lm As List(Of Matricula) = Nothing

    CType(Me.cboGrado.SelectedItem, Seccion).Anio.anio = moAnioActual.anio
    lm = obj.ListarAlumnosGradoSeccion(CType(Me.cboGrado.SelectedItem, Seccion))
    If lm.Count > 0 Then
      Me.cboAlumno.DisplayMember = "NombreCompleto"
      Me.cboAlumno.ValueMember = "NombreCompleto"
      Me.cboAlumno.DataSource = lm
    End If
  End Sub

  Private Sub cboGrado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboGrado.Validating
    ValidarCombo(e, Me.cboGrado, "Seleccione el grado")
  End Sub

  Private Sub ValidarCombo(ByVal e As System.ComponentModel.CancelEventArgs, ByVal opcion As ComboBox, ByVal msj As String)
    If opcion.SelectedIndex = -1 Then
      e.Cancel = True
      errorTraslado.SetError(opcion, msj)
    Else
      errorTraslado.SetError(opcion, Nothing)
    End If
  End Sub

  Private Sub cboTipoTras_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboTipoTras.Validating
    ValidarCombo(e, Me.cboTipoTras, "Seleccione el tipo de traslado")
  End Sub

  Private Sub cboAlumno_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboAlumno.Validating
    ValidarCombo(e, Me.cboAlumno, "Seleccione el alumno")
  End Sub

  Private Sub ValidarText(ByVal e As System.ComponentModel.CancelEventArgs, ByVal cadena As System.Windows.Forms.TextBox, ByVal msj As String)
    If cadena.Text.Length = 0 Then
      e.Cancel = True
      errorTraslado.SetError(cadena, msj)
    Else
      errorTraslado.SetError(cadena, Nothing)
    End If
  End Sub

  Private Sub txtMotivo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMotivo.Validating
    ValidarText(e, Me.txtMotivo, "Debe indicar el motivo del traslado")
  End Sub

  Private Sub txtInstitucion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtInstitucion.Validating
    ValidarText(e, Me.txtInstitucion, "Debe indicar el nombre de la institución")
  End Sub

  Private Sub txtCodigoMod_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodigoMod.Validating
    ValidarText(e, Me.txtCodigoMod, "Debe indicar el codigo modular de la institución")
  End Sub

  Private Sub txtResolucion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtResolucion.Validating
    ValidarText(e, Me.txtResolucion, "Debe indicar la resolución")
  End Sub

  Private Sub txtDescripcion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDescripcion.Validating
    ValidarText(e, Me.txtDescripcion, "Debe indicar en que periodo se a dado el traslado")
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Limpiar()
  End Sub

  Private Sub Limpiar()
    Me.cboAlumno.SelectedIndex = -1
    Me.cboGrado.SelectedIndex = -1
    Me.cboTipoTras.SelectedIndex = -1
    Me.txtDescripcion.Text = "Trasladado(a) en el periodo " & Me.txtPeriodo.Text
    Me.txtCodigoMod.Text = ""
    Me.txtMotivo.Text = ""
    Me.txtInstitucion.Text = ""
    Me.txtResolucion.Text = ""
    codigoEstado = 0
    Me.btnCarga.Visible = False
    Me.btnRegistrar.Text = "&Registrar"

    errorTraslado.SetError(Me.cboAlumno, Nothing)
    errorTraslado.SetError(Me.cboGrado, Nothing)
    errorTraslado.SetError(Me.cboTipoTras, Nothing)
    errorTraslado.SetError(Me.txtDescripcion, Nothing)
    errorTraslado.SetError(Me.txtCodigoMod, Nothing)
    errorTraslado.SetError(Me.txtMotivo, Nothing)
    errorTraslado.SetError(Me.txtInstitucion, Nothing)
    errorTraslado.SetError(Me.txtResolucion, Nothing)
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    Dim obj As RNTraslado

    Try
      If Me.ValidateChildren Then
        obj = New RNTraslado
        If codigoEstado = 0 Then
          obj.Registrar(New Traslado(0, txtCodigoMod.Text.Trim, txtInstitucion.Text.Trim, _
                                      txtMotivo.Text.Trim, txtDescripcion.Text, dtpFechaTras.Value, _
                                       cboTipoTras.Text.Chars(0), txtResolucion.Text.Trim, _
                                     New Matricula(CType(Me.cboAlumno.SelectedItem, Matricula).Numero, _
                                                    Nothing, 0)))
          MessageBox.Show("Datos de traslado registrados con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          obj.Actualizar(New Traslado(codigoAlu, txtCodigoMod.Text.Trim, txtInstitucion.Text.Trim, _
                    txtMotivo.Text.Trim, txtDescripcion.Text, dtpFechaTras.Value, _
                    cboTipoTras.Text.Chars(0), txtResolucion.Text.Trim, _
                    New Matricula(CType(Me.cboAlumno.SelectedItem, Matricula).Numero, _
                                                    Nothing, 0)))
          MessageBox.Show("Datos de traslado actualizados con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      obj = Nothing
      ListarTraslados()
      Limpiar()
    End Try
    
  End Sub

  Private Sub ListarTraslados()
    Dim obj As New RNTraslado
    Dim lt As List(Of Traslado) = Nothing

    lt = obj.ListarTraslados(moAnioActual)
    If lt.Count > 0 Then
      dgTraslados.AutoGenerateColumns = False
      dgTraslados.DataSource = lt
      dgTraslados.Columns(0).DataPropertyName = "NombreCompleto"
      dgTraslados.Columns(1).DataPropertyName = "Grado"
      dgTraslados.Columns(2).DataPropertyName = "TipoTraslado"
    End If
    lt = Nothing
    dgTraslados.ClearSelection()
  End Sub

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click, dgTraslados.DoubleClick
    Dim obj As Traslado = Nothing
    Dim pos As Integer = -1

    If Me.dgTraslados.RowCount > 0 And Me.dgTraslados.SelectedRows.Count > 0 Then
      pos = Me.dgTraslados.CurrentRow.Index()
      codigoEstado = 1
      Me.btnRegistrar.Text = "&Actualizar"
      obj = CType(Me.dgTraslados.SelectedRows.Item(0).DataBoundItem, Traslado)

      Me.codigoAlu = obj.Codigo
      Me.dtpFechaTras.Value = obj.FechaTras
      Me.cboGrado.Text = Me.dgTraslados.Rows(pos).Cells("cdGrado").Value.ToString
      Me.cboAlumno.Text = Me.dgTraslados.Rows(pos).Cells("cdAlumno").Value.ToString
      Me.cboTipoTras.Text = Me.dgTraslados.Rows(pos).Cells("cdTipo").Value.ToString
      Me.txtMotivo.Text = obj.Motivo
      Me.txtInstitucion.Text = obj.NombreInst
      Me.txtCodigoMod.Text = obj.CodigoModularInst
      Me.txtDescripcion.Text = obj.DescripcionPeriodo
      Me.txtResolucion.Text = obj.NroResolucion
    Else
      MessageBox.Show("Seleccione un item por favor ......!!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
  End Sub

  Private Sub btnCarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarga.Click
    Dim frm As frmCargaAcademicaTraslado

    If Me.cboGrado.SelectedIndex > -1 And Me.cboAlumno.SelectedIndex > -1 Then
      frm = New frmCargaAcademicaTraslado
      frm.Seleccionar(Me.cboGrado.Text.Trim)
    Else
      MessageBox.Show("Seleccione grado y alumno por favor ....!!!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
  End Sub
End Class