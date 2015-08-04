Public Class frmGestionProgramacionPago

  Private ListaP As New List(Of ProgramacionPago)
  Private ListaPAux As New List(Of ProgramacionPago)
  Private Entidad As String = "I"

  Private Sub frmGestionProgramacionPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.txtDescripcion.CharacterCasing = CharacterCasing.Upper
    Me.btnAgregar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\agregar.png")
    Me.btnEliminar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\eliminar.png")
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnAceptar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.cbEntidad.SelectedIndex = 0
    Me.dtFecha.Value = Date.Today
    Me.CargarCboAnio()
    Me.CargarCboServicio()
    Me.ListarProgramacion()
    Me.CargarNiveles()
    Me.cbEntidad.Select()
    Me.cboAplica.SelectedIndex = 0
  End Sub

  Public Sub CargarNiveles()
    Dim ListN As New List(Of Nivel)
    Dim objNivel As New RNNivel

    ListN = objNivel.Listar()
    If ListN.Count > 0 Then
      Me.cboNivel.DisplayMember = "Nombre"
      Me.cboNivel.ValueMember = "Codigo"
      Me.cboNivel.DataSource = ListN
      Me.cboNivel.SelectedIndex = -1
    End If
  End Sub

  Public Sub ListarProgramacion()
    Dim objRNP As New RNProgramacionPago
    Dim objA As AnioLectivo
    If cbAnio.SelectedIndex > -1 Then
      ListaP = Nothing
      objA = New AnioLectivo
      objA = CType(Me.cbAnio.SelectedItem, AnioLectivo)
      ListaP = objRNP.ListarProgramacionPago(New ProgramacionPago(True), objA)
      dgvServicio.DataSource = Nothing
      If ListaP.Count > 0 Then
        dgvServicio.AutoGenerateColumns = False
        Me.dgvServicio.DataSource = ListaP
      End If
    End If
  End Sub

  Public Sub CargarCboAnio()
    Dim ListA As New List(Of AnioLectivo)
    Dim objAnio As New RNAnioLectivo

    ListA = objAnio.Leer(New AnioLectivo() With {.vigencia = True})
    If ListA.Count > 0 Then
      cbAnio.DisplayMember = "anio"
      cbAnio.ValueMember = "anio"
      cbAnio.DataSource = ListA
      cbAnio.SelectedIndex = ListA.Count - 1
      ListA = Nothing
    End If
  End Sub

  Public Sub CargarCboServicio()
    Dim ListS As New List(Of Servicio)
    Dim objServ As New RNServicio
    Dim serv As New Servicio("", Entidad, True)

    cbServicio.DataSource = Nothing
    ListS = objServ.ListarServicio(serv)
    If ListS.Count > 0 Then
      cbServicio.DisplayMember = "NombreConNivel"
      cbServicio.ValueMember = "codigo"
      cbServicio.DataSource = ListS
      ListS = Nothing
      Me.txtDescripcion.Text = CType(Me.cbServicio.SelectedItem, Servicio).Nombre
    End If
  End Sub

  Private Sub cbEntidad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbEntidad.SelectedIndexChanged
    If Me.cbEntidad.Text = "COPAFA" Then
      Entidad = "C"
    Else
      Entidad = "I"
    End If
    Me.CargarCboServicio()
  End Sub

  Private Sub cbAnio_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAnio.SelectedIndexChanged
    Me.ListarProgramacion()
    Me.ListaPAux = Nothing
  End Sub
  Private Sub cbAnio_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAnio.SelectedValueChanged
    ListarProgramacion()
    ListaPAux = Nothing
  End Sub

  Private Sub cbServicio_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbServicio.SelectedIndexChanged
    If Not Me.cbServicio.SelectedItem Is Nothing Then
      With CType(Me.cbServicio.SelectedItem, Servicio)
        Me.txtDescripcion.Text = .Nombre
        Me.txtMonto.Text = .Monto.ToString
        If .NivelAcademico IsNot Nothing Then
          Me.cboNivel.SelectedValue = .NivelAcademico.Codigo
        Else
          Me.cboNivel.SelectedIndex = -1
        End If
      End With
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    ListaP = Nothing
    ListaPAux = Nothing
    Me.Dispose()
    Me.Close()
  End Sub

  Public Function buscarProgramacion(ByVal prog As ProgramacionPago) As Integer
    For Each obj As ProgramacionPago In ListaP
      If obj.Descripcion = prog.Descripcion And obj.Servicio.Codigo = prog.Servicio.Codigo And obj.Nivel.Codigo = prog.Nivel.Codigo And obj.Anio.Anio = prog.Anio.Anio Then
        Return -1
      End If
    Next
    Return 0
  End Function

  Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
    Dim prog As ProgramacionPago

    If (Me.cbAnio.SelectedItem IsNot Nothing And Me.cbServicio.SelectedItem IsNot Nothing _
            And Me.txtMonto.Text <> "") Then
      dgvServicio.AutoGenerateColumns = False
      prog = New ProgramacionPago(0, CDbl(Me.txtMonto.Text), Me.txtDescripcion.Text, Entidad, True, Me.dtFecha.Value, _
                                    DirectCast(Me.cbServicio.SelectedItem, Servicio), _
                                    DirectCast(Me.cbAnio.SelectedItem, AnioLectivo), DirectCast(Me.cboNivel.SelectedItem, Nivel))
      prog.Aplica = Me.cboAplica.Text.Substring(0, 1)
      'If Me.buscarProgramacion(prog) = 0 Then
      Me.dgvServicio.DataSource = Nothing
      Me.ListaP.Insert(0, prog)
      Me.txtMonto.Text = ""
      Me.txtDescripcion.Text = ""
      prog = Nothing
      Me.dgvServicio.DataSource = ListaP
      Me.cbServicio_SelectedIndexChanged(Nothing, Nothing)
      Me.txtDescripcion.Focus()
      'Else
      ' MessageBox.Show("Ya ha sido agregado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      'End If
    Else
      MessageBox.Show("Faltan datos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If

  End Sub

  Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
    If dgvServicio.RowCount > 0 Then
      Dim prog As New ProgramacionPago
      prog = CType(Me.dgvServicio.Rows(Me.dgvServicio.CurrentRow.Index).DataBoundItem, ProgramacionPago)
      If prog.codigo <> 0 Then
        If ListaPAux Is Nothing Then
          ListaPAux = New List(Of ProgramacionPago)
        End If
        ListaPAux.Add(prog)
      End If
      ListaP.Remove(prog)
      Me.dgvServicio.DataSource = Nothing
      Me.dgvServicio.DataSource = ListaP
    End If
  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    Dim objRNP As New RNProgramacionPago

    Try
      ' If dgvServicio.RowCount > 0 Then
      If MessageBox.Show("¿Está seguro que guardar los cambios?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        For Each obj As ProgramacionPago In ListaP
          If obj.codigo = 0 Then
            objRNP.Registrar(obj)
          End If
        Next
        If ListaPAux IsNot Nothing Then
          For Each obj As ProgramacionPago In ListaPAux
            objRNP.Eliminar(obj)
          Next
        End If
        objRNP = Nothing
        ListaP = Nothing
        MessageBox.Show("Los cambios se guardaron con Exito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        'End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

#Region "Validar"
  Private Sub ValidarText(ByVal e As System.ComponentModel.CancelEventArgs, ByVal cadena As System.Windows.Forms.TextBox, ByVal msj As String)
    If cadena.Text.Length = 0 Then
      e.Cancel = True
      errValida.SetError(cadena, msj)
    Else
      errValida.SetError(cadena, Nothing)
    End If
  End Sub

  'Private Sub txtMonto_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMonto.Validating
  '    ValidarText(e, Me.txtMonto, "Debe indicar el monto del Servicio")
  'End Sub
  Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
    'If Char.IsLetter(e.KeyChar) = False AndAlso _
    '   Char.IsSeparator(e.KeyChar) = False AndAlso e.KeyChar <> "'"c _
    '   AndAlso Char.IsControl(e.KeyChar) = False Then
    '    e.Handled = True
    'End If
    If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
      Me.btnAgregar_Click(Nothing, Nothing)
    End If
  End Sub
  Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
    If Char.IsDigit(e.KeyChar) = False AndAlso Char.IsNumber(e.KeyChar) = False _
       AndAlso Char.IsPunctuation(e.KeyChar) = False AndAlso Char.IsControl(e.KeyChar) = False Then
      e.Handled = True
    End If
    If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
      Me.btnAgregar_Click(Nothing, Nothing)
    End If
  End Sub
#End Region

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    ListaP = Nothing
    ListaPAux = Nothing
    Me.Close()
  End Sub

End Class