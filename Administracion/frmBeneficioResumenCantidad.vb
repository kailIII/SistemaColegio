Imports Microsoft.Office.Interop.Excel

Public Class frmBeneficioResumenCantidad

  Private Shared frm As frmBeneficioResumenCantidad

  Private Const CELDAINICIO As String = "B8"
  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing

  Private Beneficios As List(Of BeneficioResumen)

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

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim rn As RNBeneficio

    If cboAnio.SelectedIndex > -1 Then
      rn = New RNBeneficio
      Try
        Me.Beneficios = rn.Resumen(DirectCast(cboAnio.SelectedItem, AnioLectivo))
        Me.dgvResumenBeneficios.AutoGenerateColumns = False
        Me.dgvResumenBeneficios.DataSource = Me.Beneficios
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        rn = Nothing
      End Try
    End If
  End Sub

  Private Sub frmBeneficioResumenCantidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.ListarComboAnios()
    Me.cboAnio.SelectedValue = mOAnioActual.Anio
    Me.CargarImagenes()
  End Sub

  Public Sub CargarImagenes()
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Excel.bmp")
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

  Public Shared Sub Presentar(ByVal frm As Form, ByVal wDialogoGuardar As SaveFileDialog)
    If frmBeneficioResumenCantidad.frm Is Nothing Then
      frmBeneficioResumenCantidad.frm = New frmBeneficioResumenCantidad
      With frmBeneficioResumenCantidad.frm
        .DialogoGuardar = wDialogoGuardar

        .MdiParent = frm
        .Show()
        .WindowState = FormWindowState.Maximized
      End With
    Else
      frmBeneficioResumenCantidad.frm.Activate()
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    If cboAnio.SelectedIndex > -1 Then
      Me.ExportarReporte()
    End If
  End Sub

  Private Sub ExportarReporte()
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing

    Try
      If Me.Beneficios IsNot Nothing AndAlso Me.Beneficios.Count > 0 Then
        Me.mDialogoGuardar.Filter = "Archivos (*.xls)|*.xls"
        Me.mDialogoGuardar.FileName = "Resumen de beneficios asignados - Año " & cboAnio.Text & ".xls"

        m_excel = CrearExcel()
        Libro = AbrirPlantilla(m_excel, Me.mDialogoGuardar, AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\ResumenBeneficios.xls")
        If Libro IsNot Nothing Then
          Hoja = DirectCast(Libro.Worksheets.Item("Datos"), Worksheet)

          Hoja.Range("B5").Value = "Resumen de beneficios asignados - Año " & cboAnio.Text
          Hoja.Range("C6").Value = DateAndTime.Now.ToShortDateString

          Me.ExportarDatos(Hoja.Range(CELDAINICIO).Offset(1, 0))

          'Hoja.Range(Hoja.Range(CELDAINICIO).Offset(1, 0), Hoja.Range(CELDAINICIO).Offset(Me.Beneficios.Count, 5)).EntireColumn.AutoFit()
          BordesTodo(Hoja.Range(Hoja.Range(CELDAINICIO).Offset(1, 0), Hoja.Range(CELDAINICIO).Offset(Me.Beneficios.Count, 4)))

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
    Dim i As Integer = 1

    For Each ben In Me.Beneficios
      Celda.Value = i

      With ben
        Celda.Offset(0, 1).Value = .Motivo
        Celda.Offset(0, 2).Value = .Descuento
        Celda.Offset(0, 3).Value = .NombreNivel
        Celda.Offset(0, 4).Value = .Cantidad
      End With

      i += 1
      Celda = Celda.Offset(1, 0)
    Next
  End Sub

  Private Sub frmBeneficioResumenCantidad_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    Me.Dispose()
    frmBeneficioResumenCantidad.frm = Nothing
  End Sub

End Class