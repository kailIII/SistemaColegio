Public Class frmGestionNotasPlanLectorSeccion

  Private codigoEstado As Integer = 0

  Private Shared frm As frmGestionNotasPlanLectorSeccion

  Private Sub New()
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()

    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
  End Sub

  Private Sub frmGestionNotasPlanLector_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    If MessageBox.Show("¿Está seguro que desea cerrar la ventana?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
      e.Cancel = True
    End If
  End Sub

  Private Sub frmGestionNotasPlanLector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btncancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.txtAnio.Text = moAnioActual.Anio
    Me.CargarNiveles()
    Me.CargarPresentaciones()
  End Sub

  Public Sub CargarNiveles()
    Dim ListNa As List(Of Nivel)
    Dim objNa As New RNNivel

    ListNa = objNa.Listar()
    cboNivel.DisplayMember = "nombre"
    cboNivel.ValueMember = "codigo"
    cboNivel.DataSource = ListNa
    ListNa = Nothing
    Me.cboNivel.SelectedIndex = -1
  End Sub

  Private Sub CargarSeccion()
    Dim obj As RNSeccion
    Dim ls As List(Of Seccion)

    If Me.cboNivel.SelectedIndex > -1 Then
      obj = New RNSeccion
      ls = obj.Leer_NivelAcad(moAnioActual, CType(cboNivel.SelectedItem, Nivel), 1)
      If ls.Count > 0 Then
        Me.cboSeccion.DisplayMember = "NumeroLetra"
        Me.cboSeccion.ValueMember = "NumeroLetra"
        Me.cboSeccion.DataSource = ls
      End If
    Else
      Me.cboSeccion.DataSource = Nothing
    End If
    Me.cboSeccion.SelectedIndex = -1
  End Sub

  Private Sub CargarPresentaciones()
    Dim obj As New RNPresentacion
    Dim lpres As List(Of Presentacion)

    lpres = obj.ListarPresVigentes(moAnioActual.Anio)
    obj = Nothing

    cboPresentacion.DisplayMember = "Numero"
    cboPresentacion.ValueMember = "Codigo"

    cboPresentacion.DataSource = lpres
    Me.cboPresentacion.SelectedIndex = -1
  End Sub

  Public Shared Sub Gestionar(ByVal wPadre As Form)
    If frmGestionNotasPlanLectorSeccion.frm Is Nothing Then
      frmGestionNotasPlanLectorSeccion.frm = New frmGestionNotasPlanLectorSeccion
      frmGestionNotasPlanLectorSeccion.frm.MdiParent = wPadre
      frmGestionNotasPlanLectorSeccion.frm.Show()
      frmGestionNotasPlanLectorSeccion.frm.WindowState = FormWindowState.Maximized
    Else
      frmGestionNotasPlanLectorSeccion.frm.Activate()
    End If
  End Sub

  Private Sub cboPresentacion_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPresentacion.Leave
    btnListar.Focus()
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub cboPresentacion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPresentacion.SelectedIndexChanged
    If cboPresentacion.SelectedIndex > -1 Then
      Me.txtInicio.Text = DirectCast(cboPresentacion.SelectedItem, Presentacion).Inicio.ToShortDateString
      Me.txtFin.Text = DirectCast(cboPresentacion.SelectedItem, Presentacion).Fin.Date.ToShortDateString
      Me.LimpiarAlumnos()
      Me.codigoEstado = 0
    Else
      Me.txtInicio.Text = ""
      Me.txtFin.Text = ""
    End If
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Me.Listar()
  End Sub

  Private Sub Listar()
    If Me.cboPresentacion.SelectedIndex > -1 Then
      Me.LimpiarAlumnos()
      Me.MostrarAlumnosPresentacion()

      Me.dgvNotas.ClearSelection()
    End If

    Me.WindowState = FormWindowState.Maximized
  End Sub

  Private Sub MostrarAlumnosPresentacion()
    Dim obj As New RNNotaLectura
    Dim lm As List(Of NotaLectura)

    lm = obj.ListarAlumnosPresentacion(CType(cboSeccion.SelectedItem, Seccion), CType(cboPresentacion.SelectedItem, Presentacion), moAnioActual.Anio)
    If lm.Count > 0 Then
      Me.dgvNotas.AutoGenerateColumns = False
      Me.dgvNotas.DataSource = lm

      For Each N In lm
        If N.Nota <> "" Then
          codigoEstado = 1
          Exit For
        End If
      Next

      Me.txtTotal.Text = lm.Count.ToString
      btnRegistrar.Enabled = True
    Else
      Me.txtTotal.Text = lm.Count.ToString
      btnRegistrar.Enabled = False
    End If
    lm = Nothing

  End Sub

  Private Sub LimpiarAlumnos()
    Me.dgvNotas.ClearSelection()
    Try
      Me.dgvNotas.DataSource = Nothing
      Me.dgvNotas.Rows.Clear()

      Me.txtTotal.Text = ""
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try
  End Sub

  Private Sub Limpiar()
    Me.cboPresentacion.SelectedIndex = -1
    Me.LimpiarAlumnos()
    Me.codigoEstado = 0
    Me.txtInicio.Text = ""
    Me.txtFin.Text = ""
    Me.btnRegistrar.Text = "&Guardar"
    Me.btnRegistrar.Enabled = False
  End Sub

  Private Sub dgvNotas_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvNotas.CellValidating
    Dim letra As String = ""
    letra = e.FormattedValue.ToString().ToUpper

    If dgvNotas.CurrentCell.ColumnIndex = 2 Then
      If Not (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
        If Not (letra = "A" Or letra = "B" Or letra = "C" Or letra = "AD" Or letra = "NP") Then
          MessageBox.Show("Sólo puede ingresar: A,B,C,AD y NP", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
          e.Cancel = True
        End If
      End If
    End If
  End Sub

  Private Sub dgvNotas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvNotas.KeyDown
    If dgvNotas.CurrentCell IsNot Nothing Then
      With dgvNotas.CurrentCell
        If .ColumnIndex = 2 Then
          If e.KeyCode = Keys.Delete Then
            dgvNotas.CurrentCell.Value = Nothing
          End If
        End If
      End With
    End If
  End Sub

  Private Sub dgvAlumNotas_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvNotas.EditingControlShowing
    AddHandler e.Control.KeyPress, AddressOf Validar
    RemoveHandler e.Control.KeyPress, AddressOf Validar
  End Sub

  Private Sub Validar(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    'Validar Fila seleccionada
    Dim drwFila As DataGridViewCell = dgvNotas.CurrentCell()

    If drwFila.ColumnIndex = 2 Then
      e.KeyChar = UCase(e.KeyChar)
      If (e.KeyChar = ChrW(Keys.A)) Or (e.KeyChar = ChrW(Keys.B)) Or (e.KeyChar = ChrW(Keys.C)) Or (e.KeyChar = ChrW(Keys.D)) _
          Or (e.KeyChar = ChrW(Keys.N)) Or (e.KeyChar = ChrW(Keys.P)) Or (e.KeyChar = ChrW(Keys.Back)) Then
        e.Handled = False
      Else
        MessageBox.Show("Sólo puede ingresar: A,B,C,AD y NP", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        e.Handled = True
      End If
    End If
  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    If Me.dgvNotas.Rows.Count > 0 Then
      If codigoEstado = 0 Then
        RegistrarNota()
        MessageBox.Show("Las notas se registraron con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Limpiar()
        Listar()
      Else
        RegistrarNuevaNota()
        MessageBox.Show("Actualización realizada con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Limpiar()
        Listar()
      End If
    Else
      Limpiar()
      MessageBox.Show("No ha ingresado notas", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
  End Sub

  Private Sub RegistrarNota()
    Dim obj As RNNotaLectura = Nothing
    Dim letra As String = ""
    Dim coment As String = ""
    Dim nroMat As Integer = 0
    Dim codPL As Integer = 0


    Try
      obj = New RNNotaLectura

      For i As Integer = 0 To Me.dgvNotas.RowCount - 1

        nroMat = CType(Me.dgvNotas.Rows(i).DataBoundItem, NotaLectura).Matricula.Numero
        codPL = CType(Me.dgvNotas.Rows(i).DataBoundItem, NotaLectura).ProgLectura.Codigo

        If CStr(Me.dgvNotas.Rows(i).Cells("cdNota").EditedFormattedValue) <> "" Then
          letra = (Me.dgvNotas.Rows(i).Cells("cdNota").EditedFormattedValue).ToString.ToUpper
          Select Case letra
            Case "C"
              coment = "Requiere Recuperación"
            Case "NP"
              coment = "No se Presentó"
          End Select
          obj.Registrar(New NotaLectura(0, letra, coment, Now, True, New ProgramacionLectura(codPL), New Matricula(nroMat), mOUsuario.Persona.Codigo))
        End If

      Next
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    Finally
      obj = Nothing
    End Try

  End Sub

  Private Sub RegistrarNuevaNota()
    Dim obj As RNNotaLectura = Nothing
    Dim letra As String = ""
    Dim NotaLect As NotaLectura
    Dim coment As String = ""
    Dim nroMat As Integer = 0
    Dim codPL As Integer = 0

    Try
      obj = New RNNotaLectura

      For i As Integer = 0 To Me.dgvNotas.RowCount - 1

        nroMat = CType(Me.dgvNotas.Rows(i).DataBoundItem, NotaLectura).Matricula.Numero
        codPL = CType(Me.dgvNotas.Rows(i).DataBoundItem, NotaLectura).ProgLectura.Codigo

        If Me.dgvNotas.Rows(i).Cells("cdNota").EditedFormattedValue.ToString <> "" Then
          letra = (Me.dgvNotas.Rows(i).Cells("cdNota").EditedFormattedValue).ToString.ToUpper
          Select Case letra
            Case "C"
              coment = "Requiere Recuperación"
            Case "D"
              coment = "Requiere Recuperación"
            Case "NP"
              coment = "No se Presento"
          End Select

          NotaLect = obj.LeerNota(New NotaLectura(New Matricula(nroMat), "", "", New ProgramacionLectura(codPL)))
          If NotaLect Is Nothing Then
            obj.Registrar(New NotaLectura(0, letra, coment, Now, True, New ProgramacionLectura(codPL), _
                                          New Matricula(nroMat), mOUsuario.Persona.Codigo))
          Else
            If letra.Trim <> NotaLect.Nota.Trim Then
              obj.RegistrarNuevaNota(New NotaLectura(NotaLect.Codigo, letra, coment, Now, True, _
                                      New ProgramacionLectura(codPL), New Matricula(nroMat), mOUsuario.Persona.Codigo))
            End If
          End If
        End If

      Next
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try

  End Sub

  Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
    Me.Limpiar()
  End Sub

  Private Sub cboSeccion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSeccion.SelectedIndexChanged
    If cboSeccion.SelectedIndex > -1 Then
      Me.Limpiar()
    End If
  End Sub

  Private Sub frmGestionNotasPlanLectorSeccion_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmGestionNotasPlanLectorSeccion.frm = Nothing
  End Sub

  Private Sub cboSeccion_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSeccion.Enter
    Me.CargarSeccion()
  End Sub

End Class