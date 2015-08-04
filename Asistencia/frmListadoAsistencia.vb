Imports Microsoft.Office.Interop.Excel

Public Class frmListadoAsistencia

  Private mDialogoGuardar As SaveFileDialog
  Private Const CELDAINICIO As String = "B9"
  Private Shared frm As frmListadoAsistencia
  'Tania Incio
  Private dt As System.Data.DataTable
  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing
  Private Const clave As String = "CETI"

  Public WriteOnly Property DialogoGuardar As SaveFileDialog
    Set(ByVal value As SaveFileDialog)
      Me.mDialogoGuardar = value
    End Set
  End Property

  Private Sub New()
    ' This call is required by the designer.
    InitializeComponent()
  End Sub

  Public Shared Function Crear(ByVal pPadre As Form) As frmListadoAsistencia

    If frmListadoAsistencia.frm Is Nothing Then
      frmListadoAsistencia.frm = New frmListadoAsistencia
      frmListadoAsistencia.frm.MdiParent = pPadre
    End If

    Return frmListadoAsistencia.frm
  End Function

  Private Sub frmResumenAsistencia_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmListadoAsistencia.frm = Nothing
  End Sub

  Public Sub Presentar()
    Me.ListarNiveles()
    Me.PresentarTipoRegistro()
    Me.Show()
    Me.WindowState = FormWindowState.Maximized
  End Sub

  Public Sub ListarNiveles()
    Dim obj As New RNNivel
    Dim ln As List(Of Nivel)

    ln = obj.Listar
    If ln.Count > 0 Then
      Me.cboNivel.DisplayMember = "Nombre"
      Me.cboNivel.ValueMember = "Codigo"
      Me.cboNivel.DataSource = ln
      Me.cboNivel.SelectedIndex = -1
    End If
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim rn As RNSeccion
    Dim fechaIni = CDate(Me.dtpFechaIni.Value)
    Dim fechaFin = CDate(Me.dtpFechaFin.Value)
    Dim nivel As Nivel

    If Me.cboSeccion.SelectedIndex > -1 And (fechaIni <= fechaFin) Then
      nivel = DirectCast(Me.cboNivel.SelectedItem, Nivel)
      rn = New RNSeccion
      dt = rn.ListarAsistenciaxSeccion(nivel, DirectCast(cboSeccion.SelectedItem, Seccion), modPrincipal.mOPeriodoActual, fechaIni, fechaFin, Me.cboTipoRegistro.SelectedValue.ToString)
      Me.dgvAsistencias.AutoGenerateColumns = False
      Me.dgvAsistencias.DataSource = dt
    Else
      Me.dgvAsistencias.DataSource = Nothing
      dt = Nothing
      If cboSeccion.SelectedIndex = -1 Then
        MessageBox.Show("Debe seleccionar la sección", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        cboSeccion.Focus()
      End If
    End If
  End Sub

  'Tania Incio
  Private Sub PresentarSecciones()
    Dim ListSec As List(Of Seccion)
    Dim objS As New RNSeccion

    ListSec = objS.Leer_NivelAcad(moAnioActual, DirectCast(Me.cboNivel.SelectedItem, Nivel), 1, True)
    Me.cboSeccion.DisplayMember = "numeroletra"
    cboSeccion.ValueMember = "codigoG"
    cboSeccion.DataSource = ListSec
  End Sub

  Private Sub PresentarTipoRegistro()
    Dim ListTipo As List(Of Asistencia)
    Dim objS As New RNAsistencia

    ListTipo = objS.ListarTipoRegistro(mOPeriodoActual)
    Me.cboTipoRegistro.DisplayMember = "estado"
    Me.cboTipoRegistro.ValueMember = "estado"
    Me.cboTipoRegistro.DataSource = ListTipo
  End Sub

  'Tania Incio
  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    If dt IsNot Nothing Then
      Me.ExportarReporte()
    Else
      MessageBox.Show("No se tienen datos que exportar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  'Tania Incio
  Private Sub ExportarReporte()
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing

    Try

      If Me.dt IsNot Nothing AndAlso Me.dt.Rows.Count > 0 Then
        Me.mDialogoGuardar.Filter = "Archivos (*.xls)|*.xls"
        Me.mDialogoGuardar.FileName = "Listado de alumnos de " & Me.cboNivel.Text & " " & cboSeccion.Text
        m_excel = CrearExcel()
        Libro = AbrirPlantilla(m_excel, Me.mDialogoGuardar, AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Listado de Asistencia.xls")
        If Libro IsNot Nothing Then
          Hoja = DirectCast(Libro.Worksheets.Item("Datos"), Worksheet)

          Hoja.Range("B5").Value = "Listado de asistencia - " & moAnioActual.Anio & "-" & Me.cboNivel.Text & "-" & cboSeccion.Text
          Hoja.Range("C6").Value = Me.dtpFechaIni.Value.ToString("dd/MM/yyyy") + " - " + Me.dtpFechaFin.Value.ToString("dd/MM/yyyy")
          Me.ExportarDatos(Hoja.Range(CELDAINICIO).Offset(1, 0))
          Hoja.Range(Hoja.Range(CELDAINICIO).Offset(1, 0), Hoja.Range(CELDAINICIO).Offset(dt.Rows.Count, 6)).EntireColumn.AutoFit()
          BordesTodo(Hoja.Range(Hoja.Range(CELDAINICIO).Offset(1, 0), Hoja.Range(CELDAINICIO).Offset(dt.Rows.Count, 6)))
          Hoja.Protect(clave)
          m_excel.ActiveWorkbook.SaveAs(Me.mDialogoGuardar.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
          m_excel.ScreenUpdating = True
          Me.pbAvance.Value = Me.pbAvance.Maximum


          MessageBox.Show("Archivo exportado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      Else
        MessageBox.Show("No se encontraron datos que exportar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If

    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      Me.pbAvance.Value = 0
      Me.pbAvance.Visible = False
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

    If dt.Rows.Count > 0 Then
      Me.pbAvance.Maximum = dt.Rows.Count
      Me.pbAvance.Visible = True

      For Each dr As DataRow In dt.Rows
        Celda.Value = dr.Item("Fecha").ToString
        Celda.Offset(0, 1).Value = dr.Item("Seccion").ToString
        Celda.Offset(0, 2).Value = dr.Item("NombreCompleto").ToString
        Celda.Offset(0, 3).Value = dr.Item("Registro").ToString
        Celda.Offset(0, 4).Value = dr.Item("Motivo").ToString
        Celda.Offset(0, 5).Value = dr.Item("Apoderado").ToString
        Celda.Offset(0, 6).Value = dr.Item("Personal").ToString
        Celda.Offset(0, 7).Value = dr.Item("FechaJusticadaXApoderado").ToString
        Celda.Offset(0, 8).Value = dr.Item("FechaRegistro").ToString
        Celda.Offset(0, 9).Value = dr.Item("PersonalRegistrador").ToString
        Celda = Celda.Offset(1, 0)
        Me.pbAvance.Value += 1
      Next
    Else
      Celda.Value = "No se han encontrado datos para exportar"
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNivel.SelectedIndexChanged
    If Me.cboNivel.SelectedIndex > -1 Then
      Me.PresentarSecciones()
    Else
      Me.cboSeccion.DataSource = Nothing
      Me.cboSeccion.SelectedIndex = -1
    End If
  End Sub

End Class