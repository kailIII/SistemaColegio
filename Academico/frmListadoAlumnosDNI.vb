Imports Microsoft.Office.Interop.Excel

Public Class frmListadoAlumnosDNI
  Implements iReporte

  Private Const clave As String = "CETI"
  Private Const CELDAINICIO As String = "A1"
  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing

  Private Shared frm As frmListadoAlumnosDNI
  Private mDialogoGuardar As SaveFileDialog

  Private matriculas As List(Of Matricula)

  Private Sub New()
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
  End Sub

  Public Shared Function Crear() As frmListadoAlumnosDNI
    If frmListadoAlumnosDNI.frm Is Nothing Then
      frmListadoAlumnosDNI.frm = New frmListadoAlumnosDNI
    End If

    Return frmListadoAlumnosDNI.frm
  End Function

  Public WriteOnly Property DialogoGuardar() As SaveFileDialog
    Set(ByVal value As SaveFileDialog)
      Me.mDialogoGuardar = value
    End Set
  End Property

  Public Sub Presentar() Implements iReporte.Presentar
    Me.Show()
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Dim rn As RNMatricula

    rn = New RNMatricula
    Me.matriculas = rn.ListarAlumnos(modPrincipal.moAnioActual)
    rn = Nothing
    Me.ExportarReporte()
  End Sub

  Private Sub ExportarReporte()
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing

    Try
      If Me.matriculas IsNot Nothing AndAlso Me.matriculas.Count > 0 Then
        Me.mDialogoGuardar.Filter = "Archivos (*.xlsx)|*.xlsx"
        Me.mDialogoGuardar.FileName = "Lista completo de alumnos"
        m_excel = CrearExcel()
        Libro = AbrirPlantilla(m_excel, Me.mDialogoGuardar, AppDomain.CurrentDomain.BaseDirectory & "Plantillas\ListadoAlumnosDNI.xlsx")
        If Libro IsNot Nothing Then
          Hoja = DirectCast(Libro.Worksheets.Item("Datos"), Worksheet)
          Me.ExportarAlumnos(Hoja.Range(CELDAINICIO).Offset(1, 0))
          modExcel.BordesTodo(Hoja.Range(Hoja.Range(CELDAINICIO), Hoja.Range(CELDAINICIO).Offset(Me.matriculas.Count, 6)))
          modExcel.CeldaFondo(Hoja.Range(Hoja.Range(CELDAINICIO), Hoja.Range(CELDAINICIO).Offset(0, 6)), 15720111)

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

  Private Sub ExportarAlumnos(ByVal Celda As Range)
    Dim celdaIni As Range = Celda

    For Each mat As Matricula In Me.matriculas
      Celda.Value = mat.NivelGradoSeccion
      Celda.Offset(0, 1).Value = mat.Alumno.ApellidoPaterno
      Celda.Offset(0, 2).Value = mat.Alumno.ApellidoMaterno
      Celda.Offset(0, 3).Value = mat.Alumno.Nombre
      Celda.Offset(0, 4).Value = mat.Alumno.FechaNacimiento
      Celda.Offset(0, 5).Value = mat.Alumno.DNI
      Celda.Offset(0, 6).Value = mat.Alumno.CodigoEducando

      Celda = Celda.Offset(1, 0)
    Next
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

End Class