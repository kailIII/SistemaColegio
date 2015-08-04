Imports Microsoft.Office.Interop.Excel

Public Class frmListadoPadresHijoMayor
  Implements iReporte

  Private Const CELDAINICIO As String = "B8"

  Private Padres As List(Of Pariente)

  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing

  Private mDialogoGuardar As SaveFileDialog

  Public WriteOnly Property DialogoGuardar() As SaveFileDialog
    Set(ByVal value As SaveFileDialog)
      Me.mDialogoGuardar = value
    End Set
  End Property

  Private Sub frmPadresPorTrabajo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    MostrarImagenes()
    txtAnio.Text = moAnioActual.Anio.ToString
  End Sub

  Private Sub MostrarImagenes()
    Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\excel.bmp")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
  End Sub

  Public Sub Presentar() Implements iReporte.Presentar
    Me.Show()
    Me.WindowState = FormWindowState.Maximized
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim rn As New RNAnioLectivo

    rn = New RNAnioLectivo

    Me.Padres = rn.ListarPadresHijoMayor(moAnioActual)
    dgvApoderados.AutoGenerateColumns = False
    dgvApoderados.DataSource = Me.Padres

  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    If Me.Padres IsNot Nothing Then
      Me.ExportarReporte()
    End If
  End Sub

  Private Sub ExportarReporte()
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing

    Try

      If Me.Padres IsNot Nothing AndAlso Me.Padres.Count > 0 Then
        Me.mDialogoGuardar.Filter = "Archivos (*.xls)|*.xls"
        Me.mDialogoGuardar.FileName = "Listado de padres"

        m_excel = CrearExcel()
        Libro = AbrirPlantilla(m_excel, Me.mDialogoGuardar, AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\ListadoPadres.xls")
        If Libro IsNot Nothing Then
          Hoja = DirectCast(Libro.Worksheets.Item("Datos"), Worksheet)

          Hoja.Range("B5").Value = "Listado de padres"
          Hoja.Range("C6").Value = DateAndTime.Now.ToShortDateString

          Me.ExportarDatos(Hoja.Range(CELDAINICIO).Offset(1, 0))

          Hoja.Range(Hoja.Range(CELDAINICIO).Offset(1, 0), Hoja.Range(CELDAINICIO).Offset(Me.Padres.Count, 7)).EntireColumn.AutoFit()
          BordesTodo(Hoja.Range(Hoja.Range(CELDAINICIO).Offset(1, 0), Hoja.Range(CELDAINICIO).Offset(Me.Padres.Count, 7)))

          m_excel.ActiveWorkbook.SaveAs(Me.mDialogoGuardar.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
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
      If Hoja IsNot Nothing Then
        System.Runtime.InteropServices.Marshal.ReleaseComObject(Hoja)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(Libro)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(m_excel)
      End If
      Hoja = Nothing
      Libro = Nothing
      m_excel = Nothing
    End Try
  End Sub

  Private Sub ExportarDatos(ByVal Celda As Range)
    Dim celdaIni As Range = Celda

    For Each item In Me.Padres
      Celda.Value = item.AlumnoMatriculado.NivelGradoSeccion
      Celda.Offset(0, 1).Value = item.AlumnoMatriculado.Alumno.ApellidoPaterno
      Celda.Offset(0, 2).Value = item.AlumnoMatriculado.Alumno.ApellidoMaterno
      Celda.Offset(0, 3).Value = item.AlumnoMatriculado.Alumno.Nombre
      Celda.Offset(0, 4).Value = item.ApellidoPaterno
      Celda.Offset(0, 5).Value = item.ApellidoMaterno
      Celda.Offset(0, 6).Value = item.Nombre
      Celda.Offset(0, 7).Value = item.DescripcionVive

      Celda = Celda.Offset(1, 0)
    Next

  End Sub

End Class