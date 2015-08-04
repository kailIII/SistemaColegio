Imports Microsoft.Office.Interop.Excel

Public Class frmPromediosAreaSeccion

  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing
  Private Const clave As String = "CETI"

  Private dt As System.Data.DataTable

  Private Sub PresentarSecciones()
    Dim ListSec As List(Of Seccion)
    Dim objS As New RNSeccion

    ListSec = objS.Leer_NivelAcad(moAnioActual, moNivel, 1)
    cboSeccion.DisplayMember = "numeroletra"
    cboSeccion.ValueMember = "codigoG"
    cboSeccion.DataSource = ListSec
  End Sub

  Private Sub CargarPeriodos(ByVal wAnio As AnioLectivo)
    Dim rnA As New RNAnioLectivo
    Dim lPer As List(Of PeriodoAcademico)

    lPer = rnA.ListarPeriodos(wAnio)
    If lPer.Count > 0 Then
      cboPeriodo.DisplayMember = "Nombre"
      cboPeriodo.ValueMember = "Codigo"
      cboPeriodo.DataSource = lPer

      If lPer.Count = 1 Then
        cboPeriodo.Focus()
      Else
        For Each per As PeriodoAcademico In lPer
          If per.Cerrado = False Then
            cboPeriodo.SelectedValue = per.Codigo
            Exit For
          End If
        Next
      End If
    End If
  End Sub

  Public Sub Presentar()
    Me.PresentarSecciones()
    Me.CargarPeriodos(moAnioActual)
    Me.Show()
    Me.WindowState = FormWindowState.Maximized
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim rn As RNSeccion

    If cboSeccion.SelectedIndex > -1 Then
      rn = New RNSeccion
      dt = rn.ListarPromedioArea(DirectCast(cboSeccion.SelectedItem, Seccion))
      dgvAreas.Columns.Clear()
      dgvAreas.DataSource = dt
    Else
      dt = Nothing
      dgvAreas.DataSource = Nothing
      MessageBox.Show("Debe seleccionar la sección", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      cboSeccion.Focus()
      dgvAreas.DataSource = Nothing
    End If
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    If dt IsNot Nothing Then
      ExportarDatos(dt)
    Else
      MessageBox.Show("No se tienen datos que exportar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
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
      Me.sfdArchivos.FileName = "Reporte de promedios por area - " & moAnioActual.anio.Trim & "_" & cboSeccion.Text & ".xls"
      If Me.sfdArchivos.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
        Return
      End If

      Libro = m_excel.Workbooks.Open(AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Promedios de area por seccion.xls")

      m_excel.ScreenUpdating = False
      m_excel.DisplayAlerts = False

      Hoja = DirectCast(Libro.Worksheets.Item("Datos"), Worksheet)
      Hoja.Unprotect(clave)
      Hoja.Range("B5").Value = "Reporte de promedios por area - " & moNivel.Nombre & " " & moAnioActual.anio & "-" & moNivel.Nombre
      Hoja.Range("C6").Value = DateAndTime.Now.ToShortDateString

      pbAvance.Visible = True
      celda = DirectCast(Libro.ActiveSheet, Worksheet).Range("B9")
      If dt.rows.Count > 0 Then
        avance = 100 \ dt.rows.Count
        For Each dr As DataRow In dt.rows
          celda.Value = dr.Item("nombreAreaD").ToString
          celda.Offset(0, 1).Value = dr.Item("T1").ToString
          celda.Offset(0, 2).Value = dr.Item("T2").ToString
          celda.Offset(0, 3).Value = dr.Item("T3").ToString
          celda = celda.Offset(1, 0)
          Me.pbAvance.Value += avance
        Next
        'Hoja.ChartObjects("2 Gráfico")
      Else
        celda.Value = "No se han encontrado datos para exportar"
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