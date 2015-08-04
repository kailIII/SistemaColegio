Imports Microsoft.Office.Interop.Excel

Public Class frmListadoAlumnos
  Implements iReporte

  Private Const clave As String = "CETI"
  Private Const CELDAINICIO As String = "B10"
  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing

  Private Shared frm As frmListadoAlumnos
  Private mDialogoGuardar As SaveFileDialog

  Private matriculas As List(Of Matricula)

  Private Sub New()
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
  End Sub

  Public Shared Function Crear() As frmListadoAlumnos
    If frmListadoAlumnos.frm Is Nothing Then
      frmListadoAlumnos.frm = New frmListadoAlumnos
    End If

    Return frmListadoAlumnos.frm
  End Function

  Public WriteOnly Property DialogoGuardar() As SaveFileDialog
    Set(ByVal value As SaveFileDialog)
      Me.mDialogoGuardar = value
    End Set
  End Property

  Public Sub Presentar() Implements iReporte.Presentar
    Me.Show()
  End Sub

  Private Sub frmListadoAsistencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.CargarNiveles()
  End Sub

  Public Sub CargarNiveles()
    Dim ListNa As List(Of Nivel)
    Dim objNa As New RNNivel

    ListNa = objNa.Listar()
    cboNivel.DisplayMember = "nombre"
    cboNivel.ValueMember = "codigo"
    cboNivel.DataSource = ListNa
    ListNa = Nothing
    Me.cboNivel.SelectedIndex = -1
  End Sub

  Private Sub cboSeccion_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSeccion.Enter
    Me.CargarSeccion()
  End Sub

  Private Sub CargarSeccion()
    Dim obj As RNSeccion
    Dim ls As List(Of Seccion)

    If Me.cboNivel.SelectedIndex > -1 Then
      obj = New RNSeccion
      ls = obj.Leer_NivelAcad(moAnioActual, CType(cboNivel.SelectedItem, Nivel), 1)
      If ls.Count > 0 Then
        Me.cboSeccion.DisplayMember = "NumeroLetra"
        Me.cboSeccion.ValueMember = "NumeroLetra"
        Me.cboSeccion.DataSource = ls
      End If
    Else
      Me.cboSeccion.DataSource = Nothing
    End If
    Me.cboSeccion.SelectedIndex = -1
  End Sub

  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNivel.SelectedIndexChanged
    Me.cboSeccion.SelectedIndex = -1
    Me.cboSeccion.DataSource = Nothing
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Dim rn As RNMatricula

    If Me.cboSeccion.SelectedIndex > -1 Then
      rn = New RNMatricula
      Me.matriculas = rn.ListarAlumno(DirectCast(Me.cboSeccion.SelectedItem, Seccion))
      rn = Nothing
      Me.ExportarReporte()
    End If
  End Sub

  Private Sub ExportarReporte()
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing

    Try
      If Me.matriculas IsNot Nothing AndAlso Me.matriculas.Count > 0 Then
        Me.mDialogoGuardar.Filter = "Archivos (*.xls)|*.xls"
        Me.mDialogoGuardar.FileName = "Lista de alumnos " & Me.cboSeccion.Text & " "

        m_excel = CrearExcel()
        Libro = AbrirPlantilla(m_excel, Me.mDialogoGuardar, AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\ListadoAlumnos.xls")
        If Libro IsNot Nothing Then
          Hoja = DirectCast(Libro.Worksheets.Item("Datos"), Worksheet)

          Hoja.Range("C6").Value = Me.cboNivel.Text & " - " & Me.cboSeccion.Text

          Me.ExportarAlumnos(Hoja.Range(CELDAINICIO))

          modExcel.BordesTodo(Hoja.Range(Hoja.Range(CELDAINICIO).Offset(-2, 0), Hoja.Range(CELDAINICIO).Offset(Me.matriculas.Count - 1, 2)))
          modExcel.CeldaFondo(Hoja.Range(Hoja.Range(CELDAINICIO).Offset(-2, 0), Hoja.Range(CELDAINICIO).Offset(-1, 2)), 15720111)

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
      Hoja = Nothing
      Libro = Nothing
      m_excel = Nothing
    End Try
  End Sub

  Private Sub ExportarAlumnos(ByVal Celda As Range)
    Dim celdaIni As Range = Celda

    For Each mat As Matricula In Me.matriculas
      Celda.Value = mat.NroOrden
      Celda.Offset(0, 1).Value = mat.NombreAlumno
      Celda.Offset(0, 2).Value = mat.Alumno.FechaNacimiento

      Celda = Celda.Offset(1, 0)
    Next
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

End Class