Imports Microsoft.Office.Interop.Excel

Public Class frmReporteIngresoCalificacionesSecundaria
  Implements iReporte

  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing
  Private Const clave As String = "CETI"

  Private dt As System.Data.DataTable

  Private moNivel As New Nivel(3, "SECUNDARIA", "S")


  Private Sub ListarPeriodos()
    Dim obj As RNPeriodoAcademico = Nothing
    Dim lp As List(Of PeriodoAcademico) = Nothing

    obj = New RNPeriodoAcademico
    lp = obj.ListarCodPeriodos(moAnioActual)

    Me.cboPeriodo.DisplayMember = "Siglas"
    Me.cboPeriodo.ValueMember = "Codigo"
    Me.cboPeriodo.DataSource = lp
    If mOPeriodoActual IsNot Nothing Then
      Me.cboPeriodo.SelectedValue = mOPeriodoActual.Codigo
    End If
  End Sub

  Public Sub Presentar() Implements iReporte.Presentar
    Me.txtNivel.Text = moNivel.Nombre
    ListarPeriodos()
    Me.Show()
    Me.WindowState = FormWindowState.Maximized
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim rn As RNPeriodoAcademico

    If cboPeriodo.SelectedIndex > -1 Then
      rn = New RNPeriodoAcademico
      dt = rn.ListarAvanceRegistroNotas(moNivel, DirectCast(cboPeriodo.SelectedItem, PeriodoAcademico))
      rn = Nothing

      dt.Columns.Add("Docente", GetType(String), "ApellidoPat + ' ' + ApellidoMat + ' ' + Nombre")
      dt.Columns.Add("Seccion", GetType(String), "Numero + ' - ' + Letra")
      dt.Columns.Add("Unidades", GetType(String), "IIF( FaltaUnidades > 0, FaltaUnidades, 'SIN REGISTRAR')")
      dt.Columns.Add("CalificacionesRegistradas", GetType(Integer), "TotalNotas - Faltantes")
      If dt.Rows.Count > 0 Then
        dgvDocentes.AutoGenerateColumns = False
        dgvDocentes.DataSource = dt
      Else
        MessageBox.Show("Se han registrado todas las calificaciones", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
    Else
      MessageBox.Show("Debe seleccionar el periodo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      cboPeriodo.Focus()
      dgvDocentes.DataSource = Nothing
    End If
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    ExportarDatos(dt)
  End Sub

  Private Sub ExportarDatos(ByVal dt As System.Data.DataTable)
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing
    Dim proc As Process()
    Dim celda As Range
    Dim avance As Integer

    Try
      m_excel = New Microsoft.Office.Interop.Excel.Application
      Libro = Nothing
      Hoja = Nothing

      Me.sfdArchivos.Filter = "Archivos (*.xls)|*.xls"
      Me.sfdArchivos.FileName = "Avance de registro de calificaciones " & moAnioActual.Anio.Trim & "_" & cboPeriodo.Text & ".xls"
      If Me.sfdArchivos.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
        Return
      End If

      Libro = m_excel.Workbooks.Open(AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Avance registro de notas.xls")

      m_excel.ScreenUpdating = False
      m_excel.DisplayAlerts = False

      Hoja = DirectCast(Libro.Worksheets.Item("PRESENTACION"), Worksheet)
      Hoja.Unprotect(clave)
      Hoja.Range("B5").Value = "Avance de registro de calificaciones - " & txtNivel.Text & " " & moAnioActual.Anio & "-" & cboPeriodo.Text
      Hoja.Range("B6").Value = DateAndTime.Now.ToShortDateString

      pbAvance.Visible = True
      celda = DirectCast(Libro.ActiveSheet, Worksheet).Range("B10")
      If dt.Rows.Count > 0 Then
        avance = 100 \ dt.Rows.Count
        For Each dr As DataRow In dt.Rows
          celda.Value = dr.Item("Docente").ToString
          celda.Offset(0, 1).Value = dr.Item("Seccion").ToString
          celda.Offset(0, 2).Value = dr.Item("NombreCur").ToString
          celda.Offset(0, 3).Value = dr.Item("Unidades").ToString
          celda.Offset(0, 4).Value = dr.Item("TotalNotas").ToString
          celda.Offset(0, 5).Value = dr.Item("CalificacionesRegistradas").ToString
          celda.Offset(0, 6).Value = dr.Item("Faltantes").ToString
          celda = celda.Offset(1, 0)
          Me.pbAvance.Value += avance
        Next
        modExcel.BordesTodo(Hoja.Range(Hoja.Range("B10"), celda.Offset(0, 6)))
      Else
        celda.Value = "Se han registrado todas las calificaciones"
      End If
      Me.pbAvance.Value = Me.pbAvance.Maximum
      Hoja.Protect(clave)

      m_excel.ActiveWorkbook.SaveAs(Me.sfdArchivos.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)

      MessageBox.Show("Archivo exportado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      pbAvance.Visible = False
      m_excel.ScreenUpdating = True
      Me.pbAvance.Value = 0
      If Hoja IsNot Nothing Then
        System.Runtime.InteropServices.Marshal.ReleaseComObject(Hoja)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(Libro)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(m_excel)
      End If
      Hoja = Nothing
      Libro = Nothing
      m_excel = Nothing

      proc = Process.GetProcessesByName("EXCEL")
      For Each p As Process In proc
        p.Kill()
      Next
      proc = Nothing
    End Try

    Me.pbAvance.Value = 0
  End Sub

End Class