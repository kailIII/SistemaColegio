Imports Microsoft.Office.Interop.Excel

Public Class frmConsolidadoPagos

  Private Shared frm As frmConsolidadoPagos

  Private Const CELDAINICIO As String = "B9"
  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing

  Private dt As System.Data.DataTable

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
    If frmConsolidadoPagos.frm Is Nothing Then
      frmConsolidadoPagos.frm = New frmConsolidadoPagos
      With frmConsolidadoPagos.frm
        .DialogoGuardar = wDialogoGuardar

        .MdiParent = frm
        .Show()
        .WindowState = FormWindowState.Maximized
      End With
    Else
      frmConsolidadoPagos.frm.Activate()
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim rn As New RNObligacion

    Me.dgvConsolidadoPagos.DataSource = Nothing
    If Me.chkSoloDeudores.Checked = False Then
      If Me.chkSeccion.Checked = False Then
        Me.dt = rn.ListarConsolidadoPagos(CInt(DirectCast(Me.cboAnio.SelectedItem, AnioLectivo).Anio), Me.cboEntidad.Text.Substring(0, 1), Me.dtpFechaRef.Value)
      Else
        If Me.chkSoloSeccion.Checked = True Then
          If Me.cboSeccion.SelectedItem IsNot Nothing Then
            Me.dt = rn.ListarConsolidadoPagosSeccion(CInt(DirectCast(Me.cboAnio.SelectedItem, AnioLectivo).Anio), Me.cboEntidad.Text.Substring(0, 1), DirectCast(Me.cboSeccion.SelectedItem, Seccion), Me.dtpFechaRef.Value)
          Else
            MessageBox.Show("Debe seleccionar una sección", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          End If
        Else
          Me.dt = rn.ListarConsolidadoPagosNivel(CInt(DirectCast(Me.cboAnio.SelectedItem, AnioLectivo).Anio), Me.cboEntidad.Text.Substring(0, 1), DirectCast(Me.cboNivel.SelectedItem, Nivel), Me.dtpFechaRef.Value)
        End If
      End If
    Else
      Me.dt = rn.ListarConsolidadoPagosDeudores(CInt(DirectCast(Me.cboAnio.SelectedItem, AnioLectivo).Anio), Me.cboEntidad.Text.Substring(0, 1), Me.dtpFechaRef.Value)
    End If
    rn = Nothing
    Me.dgvConsolidadoPagos.DataSource = dt
  End Sub

  Private Sub frmConsolidadoPagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.CargarImagenes()
    Me.ListarComboAnios()
    Me.CargarComboNiveles()
    Me.cboEntidad.SelectedIndex = 0
  End Sub

  Public Sub CargarComboNiveles()
    Dim ListNa As List(Of Nivel)
    Dim objNa As New RNNivel

    ListNa = objNa.Listar()
    objNa = Nothing
    cboNivel.DisplayMember = "nombre"
    cboNivel.ValueMember = "codigo"
    cboNivel.DataSource = ListNa
    ListNa = Nothing
  End Sub

  Public Sub CargarComboSeccion()
    Dim ListSec As List(Of Seccion)
    Dim objS As RNSeccion

    If CType(Me.cboNivel.SelectedItem, Nivel) IsNot Nothing Then
      objS = New RNSeccion
      ListSec = objS.Leer_NivelAcad(CType(Me.cboAnio.SelectedItem, AnioLectivo), CType(Me.cboNivel.SelectedItem, Nivel), 1)
      objS = Nothing
      cboSeccion.DisplayMember = "numeroletra"
      cboSeccion.ValueMember = "codigoG"
      cboSeccion.DataSource = ListSec
      ListSec = Nothing
    End If
  End Sub

  Private Sub frmConsolidadoPagos_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmConsolidadoPagos.frm = Nothing
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Me.ExportarReporte()
  End Sub

  Private Sub ExportarReporte()
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing
    Dim titulo As String = ""

    Try

      If Me.dt IsNot Nothing AndAlso Me.dt.Rows.Count > 0 Then
        Me.mDialogoGuardar.Filter = "Archivos (*.xls)|*.xls"
        If Me.chkSoloDeudores.Checked = False AndAlso Me.chkSeccion.Checked = False Then
          titulo = "CONSOLIDADO DE PAGOS " & Me.cboAnio.Text & " " & Me.cboEntidad.Text
        ElseIf Me.chkSoloDeudores.Checked = False AndAlso Me.chkSeccion.Checked = True Then
          If Me.chkSoloSeccion.Checked = True Then
            titulo = "CONSOLIDADO DE PAGOS " & Me.cboAnio.Text & " " & Me.cboEntidad.Text & " " & Me.cboNivel.Text & "-" & Me.cboSeccion.Text
          Else
            titulo = "CONSOLIDADO DE PAGOS " & Me.cboAnio.Text & " " & Me.cboEntidad.Text & " " & Me.cboNivel.Text
          End If
        Else
          titulo = "CONSOLIDADO DE PAGOS DE ALUMNOS DEUDORES " & Me.cboAnio.Text & " " & Me.cboEntidad.Text
        End If
        Me.mDialogoGuardar.FileName = titulo

        m_excel = CrearExcel()
        Libro = AbrirPlantilla(m_excel, Me.mDialogoGuardar, AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\ConsolidadoPagos.xls")
        If Libro IsNot Nothing Then
          Hoja = DirectCast(Libro.Worksheets.Item("Datos"), Worksheet)

          Hoja.Range("B5").Value = titulo
          Hoja.Range("C7").Value = Me.cboAnio.Text
          Hoja.Range("G7").Value = Me.dtpFechaRef.Value

          Me.ConfigurarCabeceras(Hoja.Range(CELDAINICIO))
          Me.ExportarReporte(Hoja.Range(CELDAINICIO).Offset(1, 0))

          BordesTodo(Hoja.Range(Hoja.Range(CELDAINICIO), Hoja.Range(CELDAINICIO).Offset(Me.dt.Rows.Count, Me.dt.Columns.Count)))

          m_excel.ActiveWorkbook.SaveAs(Me.mDialogoGuardar.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
          m_excel.ScreenUpdating = True
          MessageBox.Show("Archivo exportado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          MessageBox.Show("No se pudo crear la hoja de calculo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
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

  Private Sub ConfigurarCabeceras(ByVal Celda As Range)
    Dim celdaIni As Range = Celda
    Dim i As Integer

    For i = 0 To Me.dt.Columns.Count - 2
      Celda.Value = Me.dt.Columns(i).ColumnName

      Celda = Celda.Offset(0, 1)
    Next
    Celda.Value = "TOTAL"
    Celda = Celda.Offset(0, 1)
    Celda.Value = Me.dt.Columns(i).ColumnName
    Celda.Worksheet.Range(celdaIni, Celda).Font.Bold = True
    modExcel.FondoGris(Celda.Worksheet.Range(celdaIni, Celda))
  End Sub

  Private Sub ExportarReporte(ByVal Celda As Range)
    Dim celdaIni As Range = Celda
    Dim cols As Integer = Me.dt.Columns.Count - 1
    Dim tot As Double
    Dim totMotivos(cols) As Double
    Dim monto As Double
    Dim i As Integer

    Me.pbAvance.Maximum = Me.dt.Rows.Count
    Me.pbAvance.Value = 0
    Me.pbAvance.Visible = True
    For Each dr As DataRow In Me.dt.Rows
      tot = 0
      For i = 0 To cols - 1
        Celda.Offset(0, i).Value = dr.Item(i)
        If i > 2 AndAlso Double.TryParse(dr.Item(i).ToString, monto) Then
          tot += monto
          totMotivos(i) += monto
        End If
      Next
      Celda.Offset(0, i).Value = tot
      Celda.Offset(0, i + 1).Value = dr.Item(i)

      Celda = Celda.Offset(1, 0)
      Me.pbAvance.Value += 1
    Next
    For i = 0 To cols
      If totMotivos(i) > 0 Then
        Celda.Offset(0, i).Value = totMotivos(i)
      End If
    Next

    Me.pbAvance.Visible = False
  End Sub

  Private Sub cboAnio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnio.SelectedIndexChanged
    Me.CargarComboSeccion()
  End Sub

  Private Sub chkSeccion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSeccion.CheckedChanged
    Me.panSeccion.Enabled = Me.chkSeccion.Checked

    If Me.chkSeccion.Checked = True Then
      Me.chkSoloDeudores.Checked = False
      Me.chkSoloSeccion.Checked = False
    End If
  End Sub

  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNivel.SelectedIndexChanged
    If Me.cboNivel.SelectedItem IsNot Nothing Then
      Me.CargarComboSeccion()
    Else
      Me.cboSeccion.DataSource = Nothing
    End If
  End Sub

  Private Sub chkSoloDeudores_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSoloDeudores.CheckedChanged
    If Me.chkSoloDeudores.Checked = True Then
      Me.chkSeccion.Checked = False
    End If
  End Sub

  Private Sub chkSoloSeccion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSoloSeccion.CheckedChanged
    Me.cboSeccion.Enabled = Me.chkSoloSeccion.Checked
  End Sub

End Class