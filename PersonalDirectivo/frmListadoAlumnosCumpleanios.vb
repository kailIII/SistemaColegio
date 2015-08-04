Imports Microsoft.Office.Interop.Excel

Public Class frmListadoAlumnosCumpleanios
  Implements iReporte

  Private Const CELDAINICIO As String = "B8"
  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing

  Private Shared frm As frmListadoAlumnosCumpleanios

  Private mCumpleanieros As List(Of Matricula)
  Private mDialogoGuardar As SaveFileDialog

  Public WriteOnly Property DialogoGuardar() As SaveFileDialog
    Set(ByVal value As SaveFileDialog)
      Me.mDialogoGuardar = value
    End Set
  End Property

  Private Sub New()
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
  End Sub

  Public Shared Function Crear() As frmListadoAlumnosCumpleanios
    If frmListadoAlumnosCumpleanios.frm Is Nothing Then
      frmListadoAlumnosCumpleanios.frm = New frmListadoAlumnosCumpleanios
    End If

    Return frmListadoAlumnosCumpleanios.frm
  End Function

  Private Sub frmListadoAlumnosCumpleanios_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    frmListadoAlumnosCumpleanios.frm = Nothing
  End Sub

  Private Sub frmPadresPorTrabajo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.MostrarImagenes()
    Me.txtAnio.Text = moAnioActual.Anio.ToString
    Me.cboMes.SelectedIndex = DateAndTime.Now.Month - 1
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

    Me.mCumpleanieros = rn.ListarCumpleanieros(moAnioActual, Me.cboMes.SelectedIndex + 1)
    dgvApoderados.AutoGenerateColumns = False
    dgvApoderados.DataSource = Me.mCumpleanieros
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    If Me.mCumpleanieros IsNot Nothing Then
      Me.ExportarReporte()
    End If
  End Sub

  Private Sub ExportarReporte()
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing

    Try

      If Me.mCumpleanieros IsNot Nothing AndAlso Me.mCumpleanieros.Count > 0 Then
        Me.mDialogoGuardar.Filter = "Archivos (*.xls)|*.xls"
        Me.mDialogoGuardar.FileName = "Listado de cumpleaños - " & Me.cboMes.Text

        m_excel = CrearExcel()
        Libro = AbrirPlantilla(m_excel, Me.mDialogoGuardar, AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\ListadoCumpleanios.xls")
        If Libro IsNot Nothing Then
          Hoja = DirectCast(Libro.Worksheets.Item("Datos"), Worksheet)

          Hoja.Range("B5").Value = "Listado de alumnos y su cumpleaños"
          Hoja.Range("C6").Value = DateAndTime.Now.ToShortDateString

          Me.ExportarDatos(Hoja.Range(CELDAINICIO).Offset(1, 0))

          Hoja.Range(Hoja.Range(CELDAINICIO).Offset(1, 0), Hoja.Range(CELDAINICIO).Offset(Me.mCumpleanieros.Count, 4)).EntireColumn.AutoFit()
          BordesTodo(Hoja.Range(Hoja.Range(CELDAINICIO).Offset(1, 0), Hoja.Range(CELDAINICIO).Offset(Me.mCumpleanieros.Count, 4)))

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

    For Each item In Me.mCumpleanieros
      With item.Alumno
        Celda.Value = .FechaNacimiento
        Celda.Offset(0, 1).Value = item.Alumno.Nombre
        Celda.Offset(0, 2).Value = .ApellidoPaterno
        Celda.Offset(0, 3).Value = .ApellidoMaterno
        Celda.Offset(0, 4).Value = item.NivelGradoSeccion
      End With
      Celda = Celda.Offset(1, 0)
    Next

  End Sub

End Class