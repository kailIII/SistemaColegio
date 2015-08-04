Imports Microsoft.Office.Interop.Excel

Public Class frmConsolidadoNotasPLSeccion

  Private Const clave As String = "CETI"
  Private Const CELDAINICIO As String = "A8"

  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing
  Private sfdGuardarArchivos As SaveFileDialog

  Private Shared frm As frmConsolidadoNotasPLSeccion

  Private Sub New()
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
  End Sub

  Public Shared Function Crear() As frmConsolidadoNotasPLSeccion
    If frmConsolidadoNotasPLSeccion.frm Is Nothing Then
      frmConsolidadoNotasPLSeccion.frm = New frmConsolidadoNotasPLSeccion
    End If

    Return frm
  End Function

  Public WriteOnly Property GuardarArchivos() As SaveFileDialog
    Set(ByVal value As SaveFileDialog)
      Me.sfdGuardarArchivos = value
    End Set
  End Property

  Public Sub Presentar()
    Me.txtAnio.Text = moAnioActual.Anio

    Me.Show()
  End Sub

  Private Sub frmConsolidadoNotasPLSeccion_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmConsolidadoNotasPLSeccion.frm = Nothing
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Dim sec As RNSeccion
    Dim libros As List(Of Libro)
    Dim notas As List(Of NotaLectura)

    If cboSeccion.SelectedIndex > -1 Then
      sec = New RNSeccion
      libros = New List(Of Libro)
      notas = New List(Of NotaLectura)
      sec.ListarConsolidadoNotasPL(DirectCast(cboSeccion.SelectedItem, Seccion), notas, libros)
      sec = Nothing
      Me.ExportarReporte(notas, libros)
    Else
      MessageBox.Show("No ha selccionado la sección", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub ExportarReporte(ByVal wNotas As List(Of NotaLectura), ByVal wLibros As List(Of Libro))
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing
    Dim htCeldas As Hashtable

    Try

      If wNotas.Count > 0 AndAlso wLibros.Count > 0 Then
        Me.sfdGuardarArchivos.Filter = "Archivos (*.xls)|*.xls"
        Me.sfdGuardarArchivos.FileName = "Consolidado de notas de plan lector para " & Me.cboNivel.Text & "-" & cboSeccion.Text

        m_excel = CrearExcel()
        Libro = AbrirPlantilla(m_excel, sfdGuardarArchivos, AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\ConsolidadoSeccion.xls")
        If Libro IsNot Nothing Then
          Hoja = DirectCast(Libro.Worksheets.Item("Datos"), Worksheet)

          Hoja.Range("B6").Value = Me.cboNivel.Text & "-" & Me.cboSeccion.Text
          Hoja.Range("G6").Value = DateAndTime.Now.ToShortDateString
          htCeldas = New Hashtable
          Me.CrearCabeceraReporte(Hoja.Range(CELDAINICIO), wLibros, htCeldas)
          Me.ExportarDatos(Hoja.Range(CELDAINICIO), wNotas, htCeldas)

          m_excel.ActiveWorkbook.SaveAs(Me.sfdGuardarArchivos.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
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
      End If
      If Hoja IsNot Nothing Then
        System.Runtime.InteropServices.Marshal.ReleaseComObject(Hoja)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(Libro)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(m_excel)
      End If
      Hoja = Nothing
      Libro = Nothing
      m_excel = Nothing

      DestruirProcesoExcel()
    End Try
  End Sub

  Private Sub CrearCabeceraReporte(ByVal wCelda As Range, ByVal wLibros As List(Of Libro), ByVal whtCeldas As Hashtable)
    Dim cel As Range
    Dim celAb As Range = wCelda.Offset(1, 0)
    Dim i As Integer = 5

    For Each l In wLibros
      cel = modExcel.CombinarCeldasNegrita(wCelda.Offset(0, i), wCelda.Offset(1, i), l.Titulo)
      whtCeldas.Add("L" & l.Codigo, i)
      i += 1
    Next
    cel = modExcel.CombinarCeldasNegrita(wCelda.Offset(0, 1), wCelda.Offset(1, 4), "Alumno")
    cel = modExcel.CombinarCeldasNegrita(wCelda, wCelda.Offset(1, 0), "Nro Orden")

    modExcel.BordesTodo(wCelda.Worksheet.Range(wCelda, celAb.Offset(0, i - 1)))
    modExcel.CeldaFondo(wCelda.Worksheet.Range(wCelda, celAb.Offset(0, i - 1)), 15720111)
    With wCelda.Worksheet.Range(wCelda, celAb.Offset(0, i - 1))
      .WrapText = True
    End With
  End Sub

  Private Sub ExportarDatos(ByVal wCelda As Range, ByVal wNotas As List(Of NotaLectura), ByVal whtCeldas As Hashtable)
    Dim cel As Range
    Dim nro As Integer = -1

    cel = wCelda
    For Each nl In wNotas
      If nro <> nl.Matricula.NroOrden Then
        cel = cel.Offset(1, 0)
        nro = nl.Matricula.NroOrden
        cel.Value = nro
        With modExcel.CombinarCeldas(cel.Offset(0, 1), cel.Offset(0, 4), nl.Matricula.Alumno.NombreCompleto)
          .VerticalAlignment = XlVAlign.xlVAlignCenter
          .HorizontalAlignment = XlHAlign.xlHAlignLeft
        End With
      End If
      cel.Offset(0, whtCeldas.Item("L" & nl.ProgLectura.Libro.Codigo)).Value = nl.Nota & "(" & nl.ProgLectura.Presentacion.Numero & ")"
      With cel.Offset(0, whtCeldas.Item("L" & nl.ProgLectura.Libro.Codigo))
        .VerticalAlignment = XlVAlign.xlVAlignCenter
        .HorizontalAlignment = XlHAlign.xlHAlignCenter
      End With
    Next
    modExcel.BordesTodo(wCelda.Worksheet.Range(wCelda, cel.Offset(0, 4 + whtCeldas.Count)))
  End Sub

  Private Sub frmConsolidadoNotasPLSeccion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\excel.bmp")
    Me.CargarNiveles()
  End Sub

  Public Sub CargarNiveles()
    Dim ListNa As List(Of Nivel)
    Dim objNa As New RNNivel

    ListNa = objNa.Listar()
    objNa = Nothing
    cboNivel.DisplayMember = "nombre"
    cboNivel.ValueMember = "codigo"
    cboNivel.DataSource = ListNa
    ListNa = Nothing
    Me.cboSeccion.SelectedIndex = -1
  End Sub

  Private Sub cboNivel_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNivel.Leave
    Me.ListarSecciones()
  End Sub

  Public Sub ListarSecciones()
    Dim ListSec As List(Of Seccion)
    Dim objS As New RNSeccion

    If CType(Me.cboNivel.SelectedItem, Nivel) IsNot Nothing Then
      ListSec = objS.Leer_NivelAcad(moAnioActual, DirectCast(cboNivel.SelectedItem, Nivel), 1)
      cboSeccion.DisplayMember = "numeroletra"
      cboSeccion.ValueMember = "codigoG"
      cboSeccion.DataSource = ListSec
      ListSec = Nothing
    Else
      Me.cboSeccion.DataSource = Nothing
      Me.cboSeccion.SelectedIndex = -1
    End If
  End Sub

End Class