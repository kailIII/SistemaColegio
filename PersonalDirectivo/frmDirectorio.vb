Imports Microsoft.Office.Interop.Excel

Public Class frmDirectorio

  Private Shared frm As frmDirectorio

  Private Const CELDAINICIO As String = "B9"

  Private alumnos As List(Of Matricula)

  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing

  Private errReporte As ErrorProvider
  Private mDialogoGuardar As SaveFileDialog

  Public WriteOnly Property ErrorReporte() As ErrorProvider
    Set(ByVal value As ErrorProvider)
      Me.errReporte = value
    End Set
  End Property

  Public WriteOnly Property DialogoGuardar() As SaveFileDialog
    Set(ByVal value As SaveFileDialog)
      Me.mDialogoGuardar = value
    End Set
  End Property

  Private Sub New()

    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
  End Sub

  Private Sub frmPadresPorTrabajo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    MostrarImagenes()
    txtAnio.Text = moAnioActual.Anio.ToString
    CargarSeccion()
  End Sub

  Private Sub CargarSeccion()
    Dim obj As New RNSeccion
    Dim ls As List(Of Seccion)

    ls = obj.LeerSeccion_Anio(moAnioActual)
    ls.Insert(0, New Seccion())
    With ls.Item(0)
      .Grado = Nothing
    End With
    cboSeccion.DisplayMember = "NivelNumeroLetra2"
    cboSeccion.ValueMember = "NivelNumeroLetra2"
    cboSeccion.DataSource = ls
  End Sub

  Private Sub MostrarImagenes()
    Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\excel.bmp")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
  End Sub

  Public Shared Sub Presentar(ByVal wPadre As Form, ByVal wDialogoGuardar As SaveFileDialog)
    If frmDirectorio.frm Is Nothing Then
      frmDirectorio.frm = New frmDirectorio
      With frmDirectorio.frm
        .MdiParent = wPadre
        .DialogoGuardar = wDialogoGuardar

        .Show()
        .WindowState = FormWindowState.Maximized
      End With
    Else
      frmDirectorio.frm.Activate()
    End If
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim rn As New RNMatricula

    If Validar() Then
      rn = New RNMatricula

      If cboSeccion.SelectedIndex > 0 Then
        Me.alumnos = rn.ListarDirectorio(DirectCast(cboSeccion.SelectedItem, Seccion))
        Me.dgvApoderados.Columns.Item("cdSeccion").Visible = True
      Else
        Me.alumnos = rn.ListarDirectorio(moAnioActual)
        Me.dgvApoderados.Columns.Item("cdSeccion").Visible = True
      End If
      dgvApoderados.AutoGenerateColumns = False
      dgvApoderados.DataSource = alumnos
    End If

  End Sub

  Private Function Validar() As Boolean

    If cboSeccion.SelectedIndex = -1 Then
      MessageBox.Show("Debe seleccionar una sección", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Return False
    End If

    Return True
  End Function

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    If cboSeccion.SelectedIndex > -1 Then
      Me.ExportarReporte()
    End If
  End Sub

  Private Sub ExportarReporte()
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing

    Try

      If Me.alumnos IsNot Nothing AndAlso Me.alumnos.Count > 0 Then
        Me.mDialogoGuardar.Filter = "Archivos (*.xls)|*.xls"
        Me.mDialogoGuardar.FileName = "DIRECTORIO " & cboSeccion.Text

        m_excel = CrearExcel()
        Libro = AbrirPlantilla(m_excel, Me.mDialogoGuardar, AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Directorio.xls")
        If Libro IsNot Nothing Then
          Hoja = DirectCast(Libro.Worksheets.Item("Datos"), Worksheet)

          Hoja.Range("B5").Value = "DIRECTORIO " & cboSeccion.Text
          Hoja.Range("C6").Value = DateAndTime.Now.ToShortDateString

          Me.ExportarDatosAnio(Hoja.Range(CELDAINICIO).Offset(1, 0))

          Hoja.Range(Hoja.Range(CELDAINICIO).Offset(1, 0), Hoja.Range(CELDAINICIO).Offset(alumnos.Count, 23)).EntireColumn.AutoFit()
          BordesTodo(Hoja.Range(Hoja.Range(CELDAINICIO).Offset(1, 0), Hoja.Range(CELDAINICIO).Offset(alumnos.Count, 29)))

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

  Private Sub ExportarDatosAnio(ByVal Celda As Range)
    Dim celdaIni As Range = Celda

    For Each mat As Matricula In Me.alumnos
      Celda.Value = mat.Seccion.NivelNumeroLetra
      If mat.Numero > 0 Then
        Celda.Offset(0, 1).Value = mat.NroOrden
      End If
      With mat.Alumno
        Celda.Offset(0, 2).Value = .NombreCompleto
        Celda.Offset(0, 3).Value = .Direccion
        Celda.Offset(0, 4).Value = .Telefono
        Celda.Offset(0, 5).Value = .Email
        If .Padre IsNot Nothing Then
          With .Padre
            Celda.Offset(0, 6).Value = .NombreCompleto
            Celda.Offset(0, 7).Value = .TelefonoCasa
            Celda.Offset(0, 8).Value = .TelefonoTrabajo
            Celda.Offset(0, 9).Value = .Celular
            Celda.Offset(0, 10).Value = .Email
            Celda.Offset(0, 11).Value = .DescripcionDocumento
            Celda.Offset(0, 12).Value = .NroDoc
            Celda.Offset(0, 13).Value = mat.DescripcionVivePadre
          End With
        End If
        If .Madre IsNot Nothing Then
          With .Madre
            Celda.Offset(0, 14).Value = .NombreCompleto
            Celda.Offset(0, 15).Value = .TelefonoCasa
            Celda.Offset(0, 16).Value = .TelefonoTrabajo
            Celda.Offset(0, 17).Value = .Celular
            Celda.Offset(0, 18).Value = .Email
            Celda.Offset(0, 19).Value = .DescripcionDocumento
            Celda.Offset(0, 20).Value = .NroDoc
            Celda.Offset(0, 21).Value = mat.DescripcionViveMadre
          End With
        End If
      End With
      If mat.Parentesco IsNot Nothing Then
        With mat.Parentesco.Apoderado
          Celda.Offset(0, 22).Value = .NombreCompleto
          Celda.Offset(0, 23).Value = .TelefonoCasa
          Celda.Offset(0, 24).Value = .TelefonoTrabajo
          Celda.Offset(0, 25).Value = .Celular
          Celda.Offset(0, 26).Value = .Email
          Celda.Offset(0, 27).Value = .DescripcionDocumento
          Celda.Offset(0, 28).Value = .NroDoc
          Celda.Offset(0, 29).Value = mat.NombreParentesco
        End With
      End If
      Celda = Celda.Offset(1, 0)
    Next
  End Sub

  Private Sub dgvApoderados_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvApoderados.DoubleClick
    Dim f As frmInformacionAlumno

    If Me.dgvApoderados.CurrentRow IsNot Nothing Then
      f = New frmInformacionAlumno
      f.Presentar(DirectCast(Me.dgvApoderados.CurrentRow.DataBoundItem, Matricula).Alumno)
      f.Dispose()
      f = Nothing
    End If
  End Sub

  Private Sub frmDirectorio_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmDirectorio.frm = Nothing
  End Sub

End Class