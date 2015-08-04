Imports Microsoft.Office.Interop.Excel

Public Class frmListadoAlumnosBeneficiados

  Private Shared frm As frmListadoAlumnosBeneficiados

  Private Const CELDAINICIO As String = "B9"
  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing

  Private dtAlumnos As System.Data.DataTable

  Private mDialogoGuardar As SaveFileDialog

  Public WriteOnly Property DialogoGuardar() As SaveFileDialog
    Set(ByVal value As SaveFileDialog)
      Me.mDialogoGuardar = value
    End Set
  End Property

  Public Sub CargarImagenes()
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Excel.bmp")
  End Sub

  Public Shared Sub Presentar(ByVal frm As Form, ByVal wDialogoGuardar As SaveFileDialog)
    If frmListadoAlumnosBeneficiados.frm Is Nothing Then
      frmListadoAlumnosBeneficiados.frm = New frmListadoAlumnosBeneficiados
      With frmListadoAlumnosBeneficiados.frm
        .DialogoGuardar = wDialogoGuardar

        .MdiParent = frm
        .Show()
        .WindowState = FormWindowState.Maximized
      End With
    Else
      frmListadoAlumnosBeneficiados.frm.Activate()
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim rn As RNBeneficio

    If Me.cboAnio.SelectedIndex > -1 Then
      rn = New RNBeneficio
      Me.dtAlumnos = rn.ListarAlumnosBeneficiadosAnio(DirectCast(Me.cboAnio.SelectedItem, AnioLectivo))
      rn = Nothing
      'Me.dgvConsolidadoPagos.AutoGenerateColumns = False
      Me.dgvConsolidadoPagos.DataSource = dtAlumnos
    Else
      MessageBox.Show("Debe seleccionar el año", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Me.cboAnio.Focus()
    End If
  End Sub

  Private Sub frmConsolidadoPagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.CargarImagenes()
    Me.ListarComboAnios()
  End Sub

  Private Sub ListarComboAnios()
    Dim rnAnio As New RNAnioLectivo
    Dim anios As List(Of AnioLectivo)

    anios = rnAnio.ListarActivos(mOInstitucion)
    If anios.Count > 0 Then
      Me.cboAnio.DisplayMember = "Anio"
      Me.cboAnio.ValueMember = "Anio"
      Me.cboAnio.DataSource = anios
    Else
      Me.Close()
      MessageBox.Show("No se ha registrado años académicos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub frmConsolidadoPagos_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmListadoAlumnosBeneficiados.frm = Nothing
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Me.ExportarReporte()
  End Sub

  Private Sub ExportarReporte()
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing

    Try

      If Me.dtAlumnos IsNot Nothing AndAlso Me.dtAlumnos.Rows.Count > 0 Then
        Me.mDialogoGuardar.Filter = "Archivos (*.xls)|*.xls"
        Me.mDialogoGuardar.FileName = "Listado de alumnos beneficiados " & Me.cboAnio.Text

        m_excel = CrearExcel()
        Libro = AbrirPlantilla(m_excel, Me.mDialogoGuardar, AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\ListadoAlumnosBeneficiados.xls")
        If Libro IsNot Nothing Then
          Hoja = DirectCast(Libro.Worksheets.Item("Datos"), Worksheet)
          Hoja.Range("C7").Value = Me.cboAnio.Text

          Me.ExportarReporte(Hoja.Range(CELDAINICIO).Offset(1, 0))

          BordesTodo(Hoja.Range(Hoja.Range(CELDAINICIO).Offset(1, 0), Hoja.Range(CELDAINICIO).Offset(Me.dtAlumnos.Rows.Count, 5)))

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

  Private Sub ExportarReporte(ByVal Celda As Range)
    Dim celdaIni As Range = Celda
    Dim i As Integer = 1

    For Each dr As DataRow In Me.dtAlumnos.Rows
      Celda.Value = i
      Celda.Offset(0, 1).Value = dr.Item("Seccion")
      Celda.Offset(0, 2).Value = dr.Item("CodigoRecaudacion")
      Celda.Offset(0, 3).Value = dr.Item("Alumno")
      Celda.Offset(0, 4).Value = dr.Item("Motivo")
      Celda.Offset(0, 5).Value = dr.Item("Descuento")

      Celda = Celda.Offset(1, 0)
      i = i + 1
    Next
  End Sub

  Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
    Dim rep As New crpListadoAlumnosBeneficiados

    rep.SetDataSource(Me.dtAlumnos)
    With rep.Section1.ReportObjects
      DirectCast(.Item("txtAnio"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.cboAnio.Text
    End With

    With frmVisor.crvVisor
      .ShowPrintButton = True
      .ReportSource = rep
      .ShowPageNavigateButtons = True

      frmVisor.ShowDialog()

      .ReportSource = Nothing
      .ShowPrintButton = False
      .ShowPageNavigateButtons = False
    End With
  End Sub

End Class