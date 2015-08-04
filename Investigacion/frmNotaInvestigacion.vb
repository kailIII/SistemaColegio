Imports Microsoft.Office.Interop.Excel
Public Class frmNotaInvestigacion

  Private Shared frm As frmNotaInvestigacion
  Private sfdDialogo As SaveFileDialog
  Private ofdDialogo As OpenFileDialog
  Private codigoEstado As Integer = 0
  Private Const CELDA_INICIO As String = "A9"
  Private Const CLAVE As String = "CETI"
  Private dt As List(Of NotaInvestigacion)

  Public Sub PresentarNiveles()
    Dim ListNa As List(Of Nivel)
    Dim objNa As New RNNivel

    ListNa = objNa.Listar()
    cboNivel.DisplayMember = "Nombre"
    cboNivel.ValueMember = "Codigo"
    cboNivel.DataSource = ListNa
    ListNa = Nothing
    Me.cboNivel.SelectedIndex = -1
  End Sub

  Private Sub PresentarSecciones()
    Dim obj As New RNSeccion
    Dim ls As List(Of Seccion)

    If Me.cboNivel.SelectedIndex > -1 Then
      ls = obj.Leer_NivelAcad(moAnioActual, CType(cboNivel.SelectedItem, Nivel), 1)
      If ls.Count > 0 Then
        Me.cboSeccion.DisplayMember = "NumeroLetra"
        Me.cboSeccion.ValueMember = "NumeroLetra"
        Me.cboSeccion.DataSource = ls
      End If
    Else
      Me.cboSeccion.DataSource = Nothing
      Me.cboSeccion.SelectedIndex = -1
    End If
  End Sub

  Private Sub ListarNotas()
    If Me.cboNivel.SelectedIndex > -1 AndAlso Me.cboSeccion.SelectedIndex > -1 Then
      Dim rn As New RNNotaInvestigacion
      Me.dgvNotas.AutoGenerateColumns = False
            dt = rn.ListarNotas(CInt(moAnioActual.Anio), DirectCast(Me.cboSeccion.SelectedItem, Seccion).Grado.Codigo,
                                DirectCast(Me.cboSeccion.SelectedItem, Seccion).Letra, mOPeriodoActual.Codigo)
      Me.dgvNotas.DataSource = dt
      Me.txtTotal.Text = dt.Count.ToString

      For i As Integer = 0 To dt.Count - 1
        If Me.dgvNotas.Item(2, i).Value.ToString <> "" Then
          Me.codigoEstado = 1
        End If
      Next
    End If

  End Sub

  Public Shared Sub Crear(ByVal pPadre As Form, ByVal wDialogo As SaveFileDialog, ByVal wAbrir As OpenFileDialog)

    If frmNotaInvestigacion.frm Is Nothing Then
      frmNotaInvestigacion.frm = New frmNotaInvestigacion
      frmNotaInvestigacion.frm.sfdDialogo = wDialogo
      Dim sf = frmNotaInvestigacion.frm.sfdDialogo
      frmNotaInvestigacion.frm.ofdDialogo = wAbrir
      frmNotaInvestigacion.frm.MdiParent = pPadre
      frmNotaInvestigacion.frm.Show()
      frmNotaInvestigacion.frm.WindowState = FormWindowState.Maximized
    Else
      frmNotaInvestigacion.frm.Activate()
    End If
  End Sub

  Private Sub frmNotaInvestigacion_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmNotaInvestigacion.frm = Nothing
  End Sub

  Private Sub frmNotaInvestigacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnRegistrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    Me.btncancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.PresentarNiveles()
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Me.ListarNotas()
    Me.btnRegistrar.Enabled = True
    If CInt(Me.cboNivel.SelectedValue) > 2 Then
      Me.gbLeyenda.Visible = False
      Me.lblLeyenda1.Visible = False
      Me.lblLeyenda2.Visible = False
    Else
      Me.gbLeyenda.Visible = True
      Me.lblLeyenda1.Visible = True
      Me.lblLeyenda2.Visible = True
    End If

  End Sub

  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNivel.SelectedIndexChanged
    Me.PresentarSecciones()

  End Sub

  Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
    If Me.dgvNotas.Rows.Count > 0 Then
      Me.RegistrarNota()
      Me.ListarNotas()
    Else
      Limpiar()
      MessageBox.Show("No ha ingresado notas", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
  End Sub

  Private Sub RegistrarNota()
    Dim obj As RNNotaInvestigacion = Nothing
    Dim nota As String, coment As String = ""
    Dim Mat As Matricula
    Dim RespInv As ResponsableInvestigacion
    Dim codigo As Integer

    Try
      obj = New RNNotaInvestigacion
      For i As Integer = 0 To Me.dgvNotas.RowCount - 1
        With DirectCast(Me.dgvNotas.Rows(i).DataBoundItem, NotaInvestigacion)
          Mat = .Matricula
          RespInv = .RespInvestigacion
          codigo = .Codigo
          nota = Me.dgvNotas.Rows(i).Cells("cdNota").EditedFormattedValue.ToString.Trim
        End With

        If CInt(Me.cboNivel.SelectedValue) > 2 Then
          If nota <> "" Then
            Select Case CDbl(nota)
              Case Is < 11
                coment = "Requiere Recuperación"
            End Select

                        obj.RegistrarNotas(CDbl(nota), Mat, coment, RespInv, New Personal(mOUsuario.Persona.Codigo), codigo)
          End If
        Else
          If nota <> "" Then
            Select Case nota.ToUpper
              Case Is = "C"
                coment = "Requiere Recuperación"
              Case Is = "NP"
                coment = "No se Presentó"
            End Select
                        obj.RegistrarNotasLetra(nota.ToUpper, Mat, coment, RespInv, New Personal(mOUsuario.Persona.Codigo), codigo)
          End If
        End If
        coment = ""
      Next
      MessageBox.Show("Las notas se registraron con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    Finally
      obj = Nothing
    End Try
  End Sub

  Private Sub Limpiar()
    Me.cboNivel.SelectedIndex = -1
    Me.cboSeccion.SelectedIndex = -1
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Dim excel As Application = Nothing
    Dim libro As Workbook = Nothing

    Try
      Me.sfdDialogo.FileName = "Investigacion " & moAnioActual.Anio & "-" & Me.cboNivel.Text & " -  " & Me.cboSeccion.Text
      Me.sfdDialogo.Filter = "Hoja de cálculo 2007(*.xlsx)|*.xlsx"
      excel = New Application
      excel.ScreenUpdating = False
      excel.DisplayAlerts = False
      If CInt(Me.cboNivel.SelectedValue) > 2 Then
        libro = modExcel.AbrirPlantilla(excel, Me.sfdDialogo, AppDomain.CurrentDomain.BaseDirectory & "Plantillas\RegistroNotas.xlsx")
      Else
        libro = modExcel.AbrirPlantilla(excel, Me.sfdDialogo, AppDomain.CurrentDomain.BaseDirectory & "Plantillas\RegistroNotasLetras.xlsx")
      End If

      Me.ExportarExcelDocente(Me.cboNivel.Text, Me.cboSeccion.Text, Me.dt, libro, Me.sfdDialogo.FileName)

      MessageBox.Show("La exportación se realizó exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      If libro IsNot Nothing Then
        libro.Close()
      End If
      If excel IsNot Nothing Then
        excel.DisplayAlerts = True
        excel.ScreenUpdating = True
        excel.Quit()
      End If
      libro = Nothing
      excel = Nothing
    End Try
  End Sub

  Private Sub ExportarExcelDocente(ByVal wNivel As String, ByVal wSeccion As String, ByVal wAlumnosNotas As List(Of NotaInvestigacion), ByVal wLibro As Workbook, ByVal wArchivo As String)
    With DirectCast(wLibro.Worksheets.Item("Datos"), Worksheet)
      .Range("C6").Value = wNivel
      .Range("G6").Value = wSeccion

      Me.ExportarDatos(wAlumnosNotas, .Range(CELDA_INICIO).Offset(1, 0))
      modExcel.BordesTodo(.Range(.Range(CELDA_INICIO), .Range(CELDA_INICIO).Offset(wAlumnosNotas.Count, 6)))

      .Protect(CLAVE)
    End With

    wLibro.SaveAs(wArchivo)
  End Sub

  Private Sub ExportarDatos(ByVal wAlumnosNotas As List(Of NotaInvestigacion), ByVal wCelda As Range)
    Dim i As Integer = 1

    For Each Notas As NotaInvestigacion In wAlumnosNotas
      wCelda.Value = i
      wCelda.Offset(0, 1).Value = Notas.Matricula.Numero
      wCelda.Offset(0, 2).Value = Notas.AlumnoNivel
      wCelda.Offset(0, 3).Value = Notas.Nota
      wCelda.Offset(0, 4).Value = Notas.AreaInvestigacion.Nombre
      wCelda.Offset(0, 5).Value = Notas.RespInvestigacion.Codigo
      wCelda.Offset(0, 6).Value = Notas.RespInvestigacion.nombreCompleto
      wCelda.Offset(0, 7).Value = Notas.Codigo

      i += 1
      wCelda = wCelda.Offset(1, 0)
    Next
  End Sub

  Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
    Dim rn As New RNNotaInvestigacion
    Dim excel As Application = Nothing
    Dim libro As Workbook = Nothing
    Dim hojaNotas As Worksheet
    Dim Notas As List(Of NotaInvestigacion) = Nothing
    Dim celda As Range

    Me.ofdDialogo.FileName = ""
    Me.ofdDialogo.Filter = "Documentos de excel(*.xlsx)|*.xlsx"
    Me.ofdDialogo.ShowDialog()
    If Me.ofdDialogo.FileName.Length > 0 Then
      Try
        excel = New Application
        excel.ScreenUpdating = False
        excel.DisplayAlerts = False
        libro = excel.Workbooks.Open(Me.ofdDialogo.FileName)
        hojaNotas = DirectCast(libro.Worksheets.Item("Datos"), Worksheet)
        celda = hojaNotas.Range(CELDA_INICIO).Offset(1, 1)
        Notas = New List(Of NotaInvestigacion)
        While celda.Value IsNot Nothing
          If celda.Offset(0, 3).Value IsNot Nothing Then
            Notas.Add(New NotaInvestigacion)
            With Notas.Item(Notas.Count - 1)
              .Matricula = New Matricula With {.Numero = CInt(celda.Value)}
              .Nota = celda.Offset(0, 2).Value.ToString
              .RespInvestigacion = New ResponsableInvestigacion(CInt(celda.Offset(0, 4).Value), "")
              .Codigo = CInt(celda.Offset(0, 6).Value)
                            .Personal = New Personal(mOUsuario.Persona.Codigo)
                            .AreaInvestigacion = New AreaInvestigacion() With {.Periodo = New PeriodoAcademico(mOPeriodoActual.Codigo)}
                            .AreaInvestigacion = New AreaInvestigacion() With {.Periodo = New PeriodoAcademico(mOPeriodoActual.Codigo)}
            End With

          Else
            Notas.Clear()
            Throw New Exception("Una o mas calificaciones no se han registrado")
          End If
          celda = celda.Offset(1, 0)
        End While
        rn = New RNNotaInvestigacion
        If CInt(Me.cboNivel.SelectedValue) > 2 Then
          rn.RegistrarNotas(Notas)
        Else
          rn.RegistrarNotasLetras(Notas)
        End If


        MessageBox.Show("Se han importado todos las calificaciones exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        rn = Nothing
        If Notas IsNot Nothing Then
          Notas.Clear()
        End If
        Notas = Nothing
        If libro IsNot Nothing Then
          libro.Close()
        End If
        If excel IsNot Nothing Then
          excel.DisplayAlerts = True
          excel.ScreenUpdating = True
          excel.Quit()
        End If
        libro = Nothing
        excel = Nothing
      End Try
    End If
  End Sub

  Private Sub dgvNotas_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvNotas.CellValidating
    Dim letra As String = ""
    letra = e.FormattedValue.ToString().ToUpper.Trim

    If Me.dgvNotas.CurrentCell.ColumnIndex = 1 Then
      If Not (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
        If CInt(Me.cboNivel.SelectedValue) = 1 Or CInt(Me.cboNivel.SelectedValue) = 2 Then
          If Me.dt.Item(0).NombreNivel <> "3" AndAlso Me.dt.Item(0).AlumnoNivel = CStr(Me.dgvNotas.Rows(0).Cells(0).Value) Then
            If validarNotaLetra(letra) = False Then
              e.Cancel = True
            End If
          End If
        Else
          If Me.dt.Item(0).NombreNivel = "3" AndAlso Me.dt.Item(0).AlumnoNivel = CStr(Me.dgvNotas.Rows(0).Cells(0).Value) Then
            If validarNota(letra) = False Then
              e.Cancel = True
            End If
          End If
          
        End If
      End If
    End If
  End Sub

  Private Function validarNota(ByVal letra As String) As Boolean
    Dim notaV As Double
    Dim respuesta As Boolean

    If letra.Trim <> "" Then
      notaV = CDbl(letra)
      If notaV >= 0 AndAlso notaV <= 20 Then
        respuesta = True
      Else
        MessageBox.Show("Sólo puede ingresar notas entre 0 y 20", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        respuesta = False
      End If
    End If
    Return respuesta
  End Function

  Private Function validarNotaLetra(ByVal letra As String) As Boolean

    Dim respuesta As Boolean

    If letra.Trim <> "" Then

      If letra = "A" Or letra = "B" Or letra = "C" Or letra = "AD" Or letra = "NP" Then
        respuesta = True
      Else
        MessageBox.Show("Sólo puede ingresar los valores A, B, C, AD, NP", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        respuesta = False
      End If
    End If
    Return respuesta
  End Function

  Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
    Me.cboNivel.SelectedIndex = -1
    Me.cboSeccion.SelectedIndex = -1
    Me.LimpiarNotas()
  End Sub

  Private Sub LimpiarNotas()
    Me.dgvNotas.ClearSelection()
    Try
      Me.dgvNotas.DataSource = Nothing
      Me.dgvNotas.Rows.Clear()

      Me.txtTotal.Text = ""

    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Try
  End Sub
End Class