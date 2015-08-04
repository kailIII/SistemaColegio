
Public Class frmNotasSecundaria

  Private Shared frm As frmNotasSecundaria

  Private Const clave As String = "12345678"

  Private dialogoAbrir As OpenFileDialog

  Private notasFaltantes As Integer = 0

  Private capacidades As New List(Of Capacidad)
  Private dtNotas As DataTable
  Private boModificado As Boolean

  Private Sub New()
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
  End Sub

  Public Shared Function Crear() As frmNotasSecundaria
    If frmNotasSecundaria.frm Is Nothing Then
      frmNotasSecundaria.frm = New frmNotasSecundaria
    End If

    Return frmNotasSecundaria.frm
  End Function

  Public Sub Gestionar(ByVal wDialogoAbrir As OpenFileDialog)
    Me.dialogoAbrir = wDialogoAbrir

    If moAnioActual IsNot Nothing AndAlso mOPeriodoActual IsNot Nothing Then
      Me.Show()
      Me.WindowState = FormWindowState.Maximized
    ElseIf moAnioActual Is Nothing Then
      MessageBox.Show("No se ha seleccionado el año actual", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    Else
      MessageBox.Show("No se ha seleccionado el periodo actual", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub frmNotasSecundaria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.MostrarImagenes()
    Me.CargarDocentes()
    Me.cboCurso.SelectedIndex = -1
    Me.CargarPeriodos()
    Me.cboUnidades.SelectedIndex = -1
    Me.txtDescripcion.Text = ""
    Me.btnListar.Enabled = False
    Me.Text = Me.Text & ":  " & moAnioActual.Anio & "   -  " & mOPeriodoActual.Nombre
  End Sub

  Private Sub CargarPeriodos()
    Dim obj As New RNPeriodoAcademico
    Dim lpers As List(Of PeriodoAcademico)

    lpers = obj.ListarCodPeriodos(modPrincipal.moAnioActual)
    obj = Nothing
    Me.cboPeriodo.ValueMember = "Codigo"
    Me.cboPeriodo.DisplayMember = "Nombre"
    Me.cboPeriodo.DataSource = lpers
    Me.cboPeriodo.SelectedValue = modPrincipal.mOPeriodoActual.Codigo
  End Sub

  Private Sub CargarDocentes()
    Dim objRN As New RNDocente
    Dim docentes As List(Of Docente) = Nothing

    docentes = objRN.ListarDocentesSecundaria(mOPeriodoActual)
    If docentes.Count > 0 Then
      Me.cboDocente.DisplayMember = "NombreCompleto"
      Me.cboDocente.ValueMember = "Codigo"
      Me.cboDocente.DataSource = docentes
    Else
      Me.cboDocente.DataSource = Nothing
    End If
  End Sub

  Private Sub MostrarCursos()
    Dim objRN As New RNDocenteCarga
    Dim cursos As List(Of DocenteCarga)

    If Me.cboDocente.SelectedIndex > -1 AndAlso Me.cboPeriodo.SelectedIndex > -1 Then
      cursos = objRN.ListarCargaSeccion2(DirectCast(Me.cboPeriodo.SelectedItem, PeriodoAcademico),
              DirectCast(Me.cboDocente.SelectedItem, Docente)) 'mOUsuario.Persona.Codigo
      If cursos IsNot Nothing AndAlso cursos.Count > 0 Then
        Me.cboCurso.DisplayMember = "CursoSeccion"
        Me.cboCurso.ValueMember = "Codigo"
        Me.cboCurso.DataSource = cursos
        Me.cboCurso.SelectedIndex = -1
      Else
        Me.cboCurso.DataSource = Nothing
      End If
    ElseIf Me.cboPeriodo.SelectedIndex > -1 Then
      MessageBox.Show("Debe seleccionar el periodo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Me.cboPeriodo.Focus()
    ElseIf Me.cboDocente.SelectedIndex > -1 Then
      MessageBox.Show("Debe seleccionar el docente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Me.cboDocente.Focus()
    End If
  End Sub

  Private Sub MostrarImagenes()
    Me.btnAceptar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub MostrarNroUnidades()
    Dim obj As New RNUnidad
    Dim unidades As List(Of Unidad)

    unidades = obj.ListarUnidades(New Unidad(0, "", False, mOPeriodoActual, _
                    New DocenteCarga(CType(Me.cboCurso.SelectedItem, DocenteCarga).Codigo, "", Nothing, _
                                     New CargaAcademica(CType(Me.cboCurso.SelectedItem, DocenteCarga).Carga.Codigo), Nothing)))
    Me.cboUnidades.DataSource = Nothing
    Me.txtDescripcion.Text = ""
    Me.btnListar.Enabled = False
    If unidades.Count > 0 Then
      Me.cboUnidades.DisplayMember = "Numero"
      Me.cboUnidades.ValueMember = "Numero"
      Me.cboUnidades.DataSource = unidades
      Me.btnListar.Enabled = True
    End If
    Me.cboUnidades.SelectedIndex = -1
  End Sub

  Private Sub cboUnidades_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUnidades.SelectedIndexChanged
    If Me.cboUnidades.SelectedIndex > -1 Then
      Me.txtDescripcion.Text = DirectCast(Me.cboUnidades.SelectedItem, Unidad).Nombre
    Else
      Me.txtDescripcion.Text = ""
      Me.LimpiarNotas()
    End If
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Me.dgvNotas.CancelEdit()
    Me.btnListar.Enabled = False
    Me.txtDescripcion.Text = ""
    Me.cboCurso.SelectedIndex = -1
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim obj As RNUnidad

    If Me.cboUnidades.SelectedIndex > -1 Then
      Me.LimpiarNotas()

      obj = New RNUnidad
      dtNotas = obj.ListarNotas(DirectCast(cboUnidades.SelectedItem, Unidad), capacidades)
      obj = Nothing

      Me.PresentarNotas()
    Else
      MessageBox.Show("Debe seleccionar la unidad", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Me.cboUnidades.Focus()
    End If
  End Sub

  Private Sub PresentarNotas()
    Me.dgvNotas.DataSource = Me.dtNotas
    Me.dgvCapacidades.AutoGenerateColumns = False
    Me.dgvCapacidades.DataSource = Me.capacidades
    Me.FormatearColumnas()
  End Sub

  Private Sub LimpiarNotas()
    Me.dgvNotas.DataSource = Nothing
    Me.dgvNotas.Columns.Clear()
    Me.dgvCapacidades.DataSource = Nothing
    If Me.dtNotas IsNot Nothing Then
      Me.dtNotas.Rows.Clear()
      Me.capacidades.Clear()
    End If
  End Sub

  Private Sub FormatearColumnas()
    Dim i As Integer = 1

    Me.dgvNotas.Columns.Remove(Me.dgvNotas.Columns.Item("nroMatricula"))
    With Me.dgvNotas.Columns.Item("nroOrden")
      .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
      .Width = 50
      .HeaderText = "Num. Orden"
      .ReadOnly = True
    End With
    With Me.dgvNotas.Columns.Item("NombreCompleto")
      .Width = 280
      .HeaderText = "Alumno"
      .ReadOnly = True
    End With

    For Each cap As Capacidad In Me.capacidades
      With Me.dgvNotas.Columns.Item("Cap" & i.ToString("00"))
        .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        .DefaultCellStyle.Format = "00"
        .Width = 49
      End With
      i += 1
    Next
    With Me.dgvNotas.Columns.Item("Promedio")
      .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
      .DefaultCellStyle.Format = "N4"
      .Width = 60
      .ReadOnly = True
    End With
  End Sub

  Private Sub dgNotas_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvNotas.EditingControlShowing
    AddHandler e.Control.KeyPress, AddressOf ValidarIngreso
    'RemoveHandler e.Control.KeyPress, AddressOf ValidarIngreso
  End Sub

  Private Sub ValidarIngreso(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    Dim celda As DataGridViewCell = dgvNotas.CurrentCell()

    e.Handled = True
    If celda.ColumnIndex <> 0 And celda.ColumnIndex <> 1 Then
      If (Char.IsDigit(e.KeyChar) = True Or (e.KeyChar = ChrW(Keys.Back))) Then
        e.Handled = False
      Else
        'MessageBox.Show("Sólo puede ingresar: Números", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        e.Handled = True
      End If
    End If
  End Sub

  Private Sub frmNotasSecundaria_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    If Me.boModificado = True Then
      If MessageBox.Show("¿Está seguro que desea cerrar la ventana?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
        e.Cancel = True
      End If
    End If
  End Sub

  Private Sub dgNotas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvNotas.KeyDown
    If dgvNotas.CurrentCell.ColumnIndex > 1 AndAlso dgvNotas.CurrentCell.ColumnIndex < dgvNotas.ColumnCount - 1 Then
      If e.KeyCode = Keys.Delete AndAlso dgvNotas.CurrentCell.IsInEditMode = False Then
        Me.dgvNotas.CurrentCell.Value = DBNull.Value
      End If
    End If
  End Sub

  Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
    Dim m_excel As Microsoft.Office.Interop.Excel.Application = Nothing
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing

    Try
      m_excel = New Microsoft.Office.Interop.Excel.Application
      m_excel.ScreenUpdating = False
      m_excel.DisplayAlerts = False

      Me.dialogoAbrir.Filter = "Todos las hojas de cálculo|*.xls;*.xlsx|Hojas de cálculo MS Excel 2007(*.xlsx)|*.xlsx|Hojas de cálculo MS Excel 2003(*.xls)|*.xls"
      Libro = modExcel.AbrirLibro(m_excel, Me.dialogoAbrir)
      If Libro IsNot Nothing Then
        Me.notasFaltantes = 0
        For i As Integer = 1 To Libro.Worksheets.Count - 1
          Hoja = DirectCast(Libro.Worksheets.Item(i), Microsoft.Office.Interop.Excel.Worksheet)
          Me.CargarNotasUnidad(Hoja)
        Next
        If Me.notasFaltantes = 0 Then
          MessageBox.Show("Todas las notas se han registrado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          MessageBox.Show("Se han registrado las notas" & vbNewLine & Me.notasFaltantes.ToString("00") & " no se pudieron registrar", _
                          Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Hoja = Nothing
      Libro = Nothing
      If m_excel IsNot Nothing Then
        m_excel.ScreenUpdating = True
        m_excel.Quit()
      End If
      m_excel = Nothing
    End Try
  End Sub

  Private Sub CargarNotasUnidad(ByVal wHojaUnidad As Microsoft.Office.Interop.Excel.Worksheet)
    Dim cantAlumnos As Integer = CInt(wHojaUnidad.Range("I6").Value)
    Dim cantCapacidades As Integer = CInt(wHojaUnidad.Range("AC71").Value)
    Dim promedios As New List(Of NotaCapacidad)
    Dim uni As Unidad
    Dim mat As Matricula
    Dim per As New Personal With {.Codigo = mOUsuario.Persona.Codigo}
    Dim celdaMat As Microsoft.Office.Interop.Excel.Range = wHojaUnidad.Range("AC10")
    Dim celdaNota As Microsoft.Office.Interop.Excel.Range = wHojaUnidad.Range("H10")
    Dim capacidades(cantCapacidades - 1) As Capacidad
    Dim nota As Integer

    For j As Integer = 0 To cantCapacidades - 1
      capacidades(j) = New Capacidad With {.Codigo = CInt(wHojaUnidad.Range("H71").Offset(0, j).Value)}
    Next
    uni = New Unidad() With {.Numero = CInt(wHojaUnidad.Range("AC8").Value), _
                             .DocenteCarga = New DocenteCarga(CInt(wHojaUnidad.Range("AC2").Value)), _
                             .Periodo = mOPeriodoActual}

    For i As Integer = 1 To cantAlumnos
      mat = New Matricula With {.Numero = CInt(celdaMat.Value)}
      celdaNota = wHojaUnidad.Range("H" & celdaMat.Row)
      For j As Integer = 0 To cantCapacidades - 1
        If celdaNota.Offset(0, j).Value IsNot Nothing AndAlso _
          celdaNota.Offset(0, j).Value.ToString.Length > 0 Then

          nota = CInt(celdaNota.Offset(0, j).Value)
          If nota >= 6 AndAlso nota <= 20 Then
            promedios.Add(New NotaCapacidad)
            With promedios.Item(promedios.Count - 1)
              .Matricula = mat
              .Unidad = uni
              .Capacidad = capacidades(j)
              .Promedio = nota
              .Personal = per
            End With
          Else
            notasFaltantes += 1
          End If
        End If
      Next

      celdaMat = celdaMat.Offset(1, 0)
    Next

    If promedios.Count > 0 Then
      Me.RegistrarPromedios(promedios)
    End If
  End Sub

  Private Sub RegistrarPromedios(ByVal wPromedios As List(Of NotaCapacidad))
    Dim rn As New RNNotaCapacidad

    rn.RegistrarNotas(wPromedios)
    rn = Nothing
  End Sub

  Private Sub cboCurso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCurso.SelectedIndexChanged
    Me.cboUnidades.SelectedIndex = -1
    Me.cboUnidades.DataSource = Nothing
  End Sub

  Private Sub cboUnidades_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUnidades.Enter
    Dim obj As RNUnidad
    Dim unidades As List(Of Unidad)
    Dim uni As Unidad

    If Me.cboCurso.SelectedIndex > -1 Then
      uni = New Unidad With {.DocenteCarga = DirectCast(Me.cboCurso.SelectedItem, DocenteCarga), _
                             .Periodo = DirectCast(Me.cboPeriodo.SelectedItem, PeriodoAcademico)}
      obj = New RNUnidad
      unidades = obj.ListarUnidades(uni)
      obj = Nothing
      If unidades.Count > 0 Then
        Me.cboUnidades.DisplayMember = "Numero"
        Me.cboUnidades.ValueMember = "Numero"
        Me.cboUnidades.DataSource = unidades
        Me.cboUnidades.SelectedIndex = -1
        Me.btnListar.Enabled = True
      Else
        Me.txtDescripcion.Text = ""
        Me.btnListar.Enabled = False
      End If
    End If
  End Sub

  Private Sub dgvNotas_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvNotas.CellValidating
    If Me.dgvNotas.Columns.Item(e.ColumnIndex).Name.Substring(0, 3).ToUpper = "CAP" Then
      If e.FormattedValue.ToString.Length > 0 Then
        If CInt(e.FormattedValue) < 0 OrElse CInt(e.FormattedValue) > 20 Then
          MessageBox.Show("La nota no es correcta", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
          e.Cancel = True
        End If
      End If
    End If
  End Sub

  Private Sub dgvNotas_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvNotas.SelectionChanged
    If Me.dgvCapacidades.Rows.Count > 0 Then
      For Each dr As DataGridViewRow In Me.dgvCapacidades.Rows
        dr.Selected = False
      Next
      If Me.dgvNotas.Columns.Item(Me.dgvNotas.CurrentCell.ColumnIndex).Name.Substring(0, 3).ToUpper = "CAP" Then
        With Me.dgvCapacidades.Rows.Item(dgvNotas.CurrentCell.ColumnIndex - 2)
          .Selected = True
        End With
      End If

    End If
  End Sub

  Private Sub dgvNotas_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvNotas.CellBeginEdit
    Me.boModificado = True
  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    Dim promedios As New List(Of NotaCapacidad)
    Dim unidad As Unidad = DirectCast(Me.cboUnidades.SelectedItem, Unidad)
    Dim per As New Personal With {.Codigo = mOUsuario.Persona.Codigo}
    Dim i As Integer

    For Each dr As DataRow In Me.dtNotas.Rows
      i = 1
      For Each cap As Capacidad In Me.capacidades
        If dr.IsNull("Cap" & i.ToString("00")) = False Then
          promedios.Add(New NotaCapacidad With {.Unidad = unidad, .Personal = per, .Capacidad = cap, _
                                                .Matricula = New Matricula() With {.Numero = CInt(dr.Item("nroMatricula"))}, _
                                                .Promedio = CDbl(dr.Item("Cap" & i.ToString("00")))})
        End If
        i += 1
      Next
    Next
    Try
      Me.RegistrarPromedios(promedios)
      Me.boModificado = False
      MessageBox.Show("Las calificaciones fueron registradas exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      promedios.Clear()
      promedios = Nothing
      per = Nothing
      unidad = Nothing
    End Try
  End Sub

  Private Sub frmNotasSecundaria_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmNotasSecundaria.frm = Nothing
  End Sub

  Private Sub cboPeriodo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriodo.SelectedIndexChanged
    Me.cboCurso.SelectedIndex = -1
    Me.cboUnidades.DataSource = Nothing
    Me.cboUnidades.SelectedIndex = -1
    Me.cboUnidades.DataSource = Nothing
  End Sub

  Private Sub cboCurso_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCurso.Enter
    Me.MostrarCursos()
  End Sub

  Private Sub cboDocente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDocente.SelectedIndexChanged
    Me.cboCurso.SelectedIndex = -1
    Me.cboCurso.DataSource = Nothing
  End Sub

End Class