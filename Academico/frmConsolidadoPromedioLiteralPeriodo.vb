Imports Microsoft.Office.Interop.Excel

Public Class frmConsolidadoPromedioLiteralPeriodo
  Implements iReporte

  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing
  Private Const CELDAINICIO As String = "A8"
  Private Const clave As String = "ceti"

  Private Shared frm As frmConsolidadoPromedioLiteralPeriodo
  Private mDialogoGuardar As SaveFileDialog

  Public WriteOnly Property DialogoGuardar As SaveFileDialog
    Set(ByVal value As SaveFileDialog)
      Me.mDialogoGuardar = value
    End Set
  End Property

  Public Shared Function Crear() As frmConsolidadoPromedioLiteralPeriodo
    If frmConsolidadoPromedioLiteralPeriodo.frm Is Nothing Then
      frmConsolidadoPromedioLiteralPeriodo.frm = New frmConsolidadoPromedioLiteralPeriodo
    End If

    Return frmConsolidadoPromedioLiteralPeriodo.frm
  End Function

  Private Sub frmConsolidadoPromedioLiteralPeriodo_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmConsolidadoPromedioLiteralPeriodo.frm = Nothing
  End Sub

  Public Sub Presentar() Implements iReporte.Presentar
    Me.Show()
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub frmConsolidadoPromedioLiteralPeriodo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.txtAnio.Text = moAnioActual.Anio
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\excel.bmp")

    Me.ListarNiveles()
  End Sub

  Public Sub ListarNiveles()
    Dim obj As New RNNivel
    Dim niveles As List(Of Nivel)

    niveles = obj.LeerNivelIndicadores
    If niveles.Count > 0 Then
      Me.cboNivel.DisplayMember = "Nombre"
      Me.cboNivel.ValueMember = "Codigo"
      Me.cboNivel.DataSource = niveles
      Me.cboNivel.SelectedIndex = -1
    End If
  End Sub

  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNivel.SelectedIndexChanged
    Me.cboGrado.DataSource = Nothing
    Me.cboGrado.SelectedIndex = -1
    Me.cboSeccion.DataSource = Nothing
    Me.cboSeccion.SelectedIndex = -1
  End Sub

  Private Sub cboGrado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrado.SelectedIndexChanged
    Me.cboSeccion.DataSource = Nothing
    Me.cboSeccion.SelectedIndex = -1
  End Sub

  Private Sub cboGrado_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrado.Enter
    Dim niv As Nivel = Nothing

    If Me.cboNivel.SelectedIndex > -1 Then
      niv = CType(Me.cboNivel.SelectedItem, Nivel)
      Me.ListarGrados(niv)
    End If
  End Sub

  Public Sub ListarGrados(ByVal niv As Nivel)
    Dim obj As New RNGrado
    Dim grados As List(Of Grado)

    grados = obj.Listar(niv)
    If grados.Count > 0 Then
      Me.cboGrado.DisplayMember = "Nombre"
      Me.cboGrado.ValueMember = "Nombre"
      Me.cboGrado.DataSource = grados
      Me.cboGrado.SelectedIndex = -1
    End If
  End Sub

  Private Sub cboSeccion_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSeccion.Enter
    If Me.cboGrado.SelectedIndex > -1 Then
      Me.ListarSecciones()
    End If
  End Sub

  Public Sub ListarSecciones()
    Dim obj As New RNSeccion
    Dim secciones As List(Of Seccion)

    secciones = obj.Listar2(New Seccion() With {.Grado = DirectCast(Me.cboGrado.SelectedItem, Grado),
                                        .Anio = modPrincipal.moAnioActual, .Letra = "a"c})
    If secciones.Count > 0 Then
      Me.cboSeccion.DisplayMember = "LetraCompleta"
      Me.cboSeccion.ValueMember = "Letra"
      Me.cboSeccion.DataSource = secciones
      Me.cboSeccion.SelectedIndex = -1
    End If
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Dim rn As RNSeccion
    Dim dt As Data.DataTable
    Dim cursos As List(Of Curso)
    Dim periodos As List(Of PeriodoAcademico)

    If Me.cboSeccion.SelectedIndex > -1 Then
      rn = New RNSeccion

      cursos = New List(Of Curso)
      periodos = New List(Of PeriodoAcademico)
      Try
        dt = rn.PresentarConsolidadoCursosAnio(periodos, cursos, DirectCast(Me.cboSeccion.SelectedItem, Seccion))
        Me.ExportarDatos(cursos, periodos, dt)
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK)
      Finally
        rn = Nothing
      End Try
    Else
      MessageBox.Show("Debe seleccionar el grado", Me.Text, MessageBoxButtons.OK)
      Me.cboSeccion.Focus()
    End If
  End Sub

  Private Sub ExportarDatos(ByVal cursos As List(Of Curso), ByVal periodos As List(Of PeriodoAcademico), ByVal dt As Data.DataTable)
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing

    Try
      If cursos IsNot Nothing AndAlso cursos.Count > 0 AndAlso
        periodos IsNot Nothing AndAlso periodos.Count > 0 AndAlso
        dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

        Me.mDialogoGuardar.Filter = "Archivos (*.xlsx)|*.xlsx"
        Me.mDialogoGuardar.FileName = "Resumen de promedios - " & Me.txtAnio.Text & " - " & Me.cboNivel.Text & " " & Me.cboGrado.Text & "-" & Me.cboSeccion.Text
        m_excel = CrearExcel()
        Libro = AbrirPlantilla(m_excel, Me.mDialogoGuardar, AppDomain.CurrentDomain.BaseDirectory & "Plantillas\ReportePromedioLiteralPeriodo.xlsx")
        If Libro IsNot Nothing Then
          Hoja = DirectCast(Libro.Worksheets.Item("Datos"), Worksheet)
          Hoja.Range("B5").Value = "Sección : " & Me.cboNivel.Text & " " & Me.cboGrado.Text & "-" & Me.cboSeccion.Text
          Hoja.Range("N5").Value = Me.txtAnio.Text

          Me.ExportarCalificaciones(Hoja.Range(CELDAINICIO).Offset(2, 0), dt, cursos, periodos)
          Me.CrearCabecera(Hoja.Range(CELDAINICIO), cursos, periodos)
          modExcel.BordesTodo(Hoja.Range(Hoja.Range(CELDAINICIO), Hoja.Range(CELDAINICIO).Offset(dt.Rows.Count, 2 + (periodos.Count + 1) * cursos.Count)))
          modExcel.CeldaFondo(Hoja.Range(Hoja.Range(CELDAINICIO).Address & ":" &
                                Hoja.Range(CELDAINICIO).Offset(0, 2 + (periodos.Count + 1) * cursos.Count).Address
                                         ), 15720111)

          m_excel.ActiveWorkbook.SaveAs(Me.mDialogoGuardar.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault)
          m_excel.ScreenUpdating = True
          MessageBox.Show("Archivo exportado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      Else
        MessageBox.Show("No se encontraron datos que exportar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      If m_excel IsNot Nothing Then
        m_excel.ScreenUpdating = True
        m_excel.Quit()
      End If
      Hoja = Nothing
      Libro = Nothing
      m_excel = Nothing
    End Try
  End Sub

  Private Sub ExportarCalificaciones(ByVal Celda As Range, ByVal dt As System.Data.DataTable, ByVal cursos As List(Of Curso), ByVal periodos As List(Of PeriodoAcademico))
    Dim celdaIni As Range = Celda
    Dim i As Integer

    For Each dr As DataRow In dt.Rows
      Celda.Value = dr.Item("NroOrden")
      Celda.Offset(0, 1).Value = dr.Item("Alumno")
      i = 0
      For Each cur In cursos
        For Each per In periodos
          With Celda.Offset(0, i + 2)
            .Value = dr.Item("C" & cur.Codigo & "P" & per.Codigo)
            .NumberFormat = "0"
            .HorizontalAlignment = XlHAlign.xlHAlignCenter
          End With
          i += 1
        Next
        With Celda.Offset(0, i + 2)
          .HorizontalAlignment = XlHAlign.xlHAlignCenter
          With .Validation
            .Add(Microsoft.Office.Interop.Excel.XlDVType.xlValidateList, Microsoft.Office.Interop.Excel.XlDVAlertStyle.xlValidAlertStop, 1, "AD,A,B,C")
            .ErrorMessage = "La calificación no es válida. (AD,A,B,C)"
          End With
        End With
        modExcel.CeldaFondo(Celda.Offset(0, i + 2), 15720111)
        i += 1
      Next
      i += 1
      With Celda.Offset(0, 1 + i)
        modExcel.CeldaFondo(Celda.Offset(0, i + 1), 15720111)
        .HorizontalAlignment = XlHAlign.xlHAlignCenter
      End With
      Celda = Celda.Offset(1, 0)
    Next
  End Sub

  Private Sub CrearCabecera(ByVal range As Range, ByVal cursos As List(Of Curso), ByVal periodos As List(Of PeriodoAcademico))
    Dim i As Integer

    i = 1
    For Each cur In cursos
      modExcel.CombinarCeldasNegrita(range.Offset(0, 1 + i), range.Offset(0, 1 + periodos.Count + i), cur.Nombre)
      For Each per In periodos
        With range.Offset(1, 1 + i)
          .Value = per.Siglas
          modExcel.CeldaFondo(range.Offset(1, 1 + i), 15720111)
          .ColumnWidth = 4.1
          .HorizontalAlignment = XlHAlign.xlHAlignCenter
        End With
        i += 1
      Next
      With range.Offset(1, 1 + i)
        .Value = "Prom."
        modExcel.CeldaFondo(range.Offset(1, 1 + i), 15720111)
        .ColumnWidth = 8
        .HorizontalAlignment = XlHAlign.xlHAlignCenter
      End With
      i += 1
    Next
    modExcel.CombinarCeldasNegrita(range.Offset(0, 1 + i), range.Offset(1, 1 + i), "Prom. Final")
    range.Offset(0, 1 + i).WrapText = True
    range.Offset(0, 1 + i).ColumnWidth = 7
    modExcel.CombinarCeldasNegrita(range.Offset(0, 1), range.Offset(1, 1), "Alumno")
    range.Offset(0, 1).ColumnWidth = 35
    modExcel.CombinarCeldasNegrita(range, range.Offset(1, 0), "N°")
    range.ColumnWidth = 3.9
  End Sub

End Class