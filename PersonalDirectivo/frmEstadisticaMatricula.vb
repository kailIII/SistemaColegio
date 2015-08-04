Imports Microsoft.Office.Interop.Excel

Public Class frmEstadisticaMatricula

  Private Const clave As String = "CETI"
  Private Const CELDAINICIO As String = "B7"

  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing

  Private dt As System.Data.DataTable

  Private sfdArchivos As SaveFileDialog

  Public Sub Presentar()
    Configurar()
    Me.Show()
    Me.WindowState = FormWindowState.Maximized
  End Sub


  Public WriteOnly Property DialogoGuardar() As SaveFileDialog
    Set(ByVal value As SaveFileDialog)
      Me.sfdArchivos = value
    End Set
  End Property

  Private Sub Configurar()
    CargarAnios(mOInstitucion)
    cboAnio.SelectedValue = moAnioActual.anio
  End Sub

  Private Sub CargarAnios(ByVal wInst As Institucion)
    Dim rnA As New RNAnioLectivo
    Dim lA As List(Of AnioLectivo)

    lA = rnA.ListarActivos(wInst)
    cboAnio.DisplayMember = "Anio"
    cboAnio.ValueMember = "Anio"
    cboAnio.DataSource = lA
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim rnm As RNMatricula

    If cboAnio.SelectedIndex > -1 Then
      rnm = New RNMatricula
      dt = rnm.MatriculadosPorSeccion(DirectCast(cboAnio.SelectedItem, AnioLectivo))
      rnm = Nothing
      dt.Columns.Add("Seccion", GetType(String), "NombreNivel + ' ' + numero + '-' + letra")
      dgvResumenMatricula.AutoGenerateColumns = False
      dgvResumenMatricula.DataSource = dt
    ElseIf cboAnio.SelectedIndex = -1 Then
      MessageBox.Show("Debe seleccionar el año académico", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      cboAnio.Focus()
    End If
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    ExportarReporte(dt)
  End Sub

  Private Sub ExportarReporte(ByVal dt As System.Data.DataTable)
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing

    Try

      If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
        Me.sfdArchivos.Filter = "Archivos (*.xls)|*.xls"
        Me.sfdArchivos.FileName = "Resumen de matrículas - Año " & cboAnio.Text

        m_excel = CrearExcel()
        Libro = AbrirPlantilla(m_excel, sfdArchivos, AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\EstadisticaMatriculados.xls")
        If Libro IsNot Nothing Then
          Hoja = DirectCast(Libro.Worksheets.Item("Datos"), Worksheet)

          Hoja.Range("B5").Value = "Resumen de matrículas - Año " & cboAnio.Text
          Hoja.Range("N6").Value = DateAndTime.Now.ToShortDateString
          CrearCabeceraReporte(Hoja.Range(CELDAINICIO))
          Me.ExportarDatos(Hoja.Range(CELDAINICIO).Offset(1, 0))

          m_excel.ActiveWorkbook.SaveAs(Me.sfdArchivos.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
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

  Private Sub ExportarDatos(ByVal Celda As Range)
    Dim hoja As Worksheet
    Dim nivel As String, grado As String = ""
    Dim iNiv As Integer, iGrado As Integer
    Dim celdaIni As Range = Celda

    nivel = dt.Rows.Item(0).Item("NombreNivel").ToString
    grado = dt.Rows.Item(0).Item("Numero").ToString
    hoja = Celda.Worksheet
    For Each dr As DataRow In dt.Rows
      If nivel <> dr.Item("NombreNivel").ToString Then
        CombinarCeldasOrientacion(Celda.Offset(-iNiv, 0), Celda.Offset(-1, 0), nivel)
        ResumenNivel(Celda.Offset(-1, 0), iNiv - 1)
        iNiv = 1
        nivel = dr.Item("NombreNivel").ToString
      Else
        iNiv += 1
      End If
      If grado <> dr.Item("Numero").ToString Then
        CombinarCeldas(Celda.Offset(-iGrado, 1), Celda.Offset(-1, 1), grado)
        ResumenGrado(Celda.Offset(-1, 0), iGrado - 1)
        iGrado = 1
        grado = dr.Item("Numero").ToString
      Else
        iGrado += 1
      End If

      Celda.Offset(0, 1).Value = dr.Item("Numero").ToString
      Celda.Offset(0, 2).Value = dr.Item("Seccion").ToString
      Celda.Offset(0, 3).Value = dr.Item("Esperado").ToString
      Celda.Offset(0, 6).Value = dr.Item("Matriculados").ToString
      Celda.Offset(0, 9).Value = dr.Item("Nuevos").ToString
      Celda.Offset(0, 12).Formula = "=" & Celda.Offset(0, 3).Address & "-(" & Celda.Offset(0, 6).Address & "-" & Celda.Offset(0, 9).Address & ")"

      Celda = Celda.Offset(1, 0)
    Next
    CrearResumenGeneral(celdaIni, Celda)
    CombinarCeldasOrientacion(Celda.Offset(-iNiv, 0), Celda.Offset(-1, 0), nivel)
    ResumenNivel(Celda.Offset(-1, 0), iNiv - 1)

    CombinarCeldas(Celda.Offset(-iGrado, 1), Celda.Offset(-1, 1), grado)
    ResumenGrado(Celda.Offset(-1, 0), iGrado - 1)

    With hoja.Range(celdaIni, Celda.Offset(0, 14))
      .EntireColumn.AutoFit()
    End With
    BordesTodo(hoja.Range(celdaIni.Offset(-2, 0), Celda.Offset(-1, 14)))
    BordesCuadrado(hoja.Range(celdaIni.Offset(-2, 0), Celda.Offset(-1, 14)))
    BordesCuadrado(hoja.Range(celdaIni.Offset(0, 0), Celda.Offset(-1, 14)))
  End Sub

  Private Sub CrearResumenGeneral(ByVal CeldaIni As Range, ByVal CeldaFin As Range)
    Dim hoja As Worksheet

    hoja = CeldaIni.Worksheet
    CeldaFin.Offset(0, 5).Formula = "=SUMA( " & CeldaIni.Offset(0, 5).Address & ":" & CeldaFin.Offset(-1, 5).Address & ")"
    CeldaFin.Offset(0, 8).Formula = "=SUMA( " & CeldaIni.Offset(0, 6).Address & ":" & CeldaFin.Offset(-1, 6).Address & ")"
    CeldaFin.Offset(0, 11).Formula = "=SUMA( " & CeldaIni.Offset(0, 9).Address & ":" & CeldaFin.Offset(-1, 9).Address & ")"
    CeldaFin.Offset(0, 14).Formula = "=SUMA( " & CeldaIni.Offset(0, 12).Address & ":" & CeldaFin.Offset(-1, 12).Address & ")"

    With CeldaFin.Offset(1, 8)
      .Formula = "=(" & CeldaFin.Offset(0, 8).Address & "-" & CeldaFin.Offset(0, 11).Address & ")/" & CeldaFin.Offset(0, 5).Address
      .NumberFormat = "0.00%"
    End With
    With CeldaFin.Offset(1, 14)
      .Formula = "=1-" & CeldaFin.Offset(1, 8).Address
      .NumberFormat = "0.00%"
    End With

    CombinarCeldasNegrita(CeldaFin.Offset(2, 5), CeldaFin.Offset(2, 8), "ALUMNOS NUEVOS")
    CeldaFin.Offset(2, 9).Formula = "=" & CeldaFin.Offset(0, 11).Address
    CombinarCeldasNegrita(CeldaFin.Offset(3, 5), CeldaFin.Offset(3, 8), "ALUMNOS ESPERADOS")
    CeldaFin.Offset(3, 9).Formula = "=" & CeldaFin.Offset(0, 5).Address
    CombinarCeldasNegrita(CeldaFin.Offset(4, 5), CeldaFin.Offset(4, 8), "TOTAL ALUMNOS")
    CeldaFin.Offset(4, 9).Formula = "=" & CeldaFin.Offset(2, 9).Address & "+" & CeldaFin.Offset(3, 9).Address
    FondoGris(hoja.Range(CeldaFin.Offset(2, 5), CeldaFin.Offset(4, 9)))
    BordesCuadrado(hoja.Range(CeldaFin.Offset(2, 5), CeldaFin.Offset(4, 9)))

    FondoGris(hoja.Range(CeldaFin.Offset(0, 5), CeldaFin.Offset(1, 14)))
    BordesCuadrado(hoja.Range(CeldaFin.Offset(0, 5), CeldaFin.Offset(1, 14)))
  End Sub

  Private Sub ResumenNivel(ByVal Celda As Range, ByVal wCantCeldas As Integer)
    With CombinarCeldas(Celda.Offset(-wCantCeldas, 5), Celda.Offset(0, 5), "")
      .Formula = "=SUMA(" & Celda.Offset(-wCantCeldas, 3).Address & ":" & Celda.Offset(0, 3).Address & ")"
    End With
    With CombinarCeldas(Celda.Offset(-wCantCeldas, 8), Celda.Offset(-1, 8), "")
      .Formula = "=SUMA(" & Celda.Offset(-wCantCeldas, 6).Address & ":" & Celda.Offset(0, 6).Address & ")"
    End With
    If CInt(Celda.Offset(-wCantCeldas, 5).Value) > 0 Then
      Celda.Offset(0, 8).Formula = "=((" & Celda.Offset(-wCantCeldas, 8).Address & "-" & Celda.Offset(-wCantCeldas, 11).Address & ")/" & Celda.Offset(-wCantCeldas, 5).Address & ")"
      Celda.Offset(0, 8).NumberFormat = "0.00%"
    End If

    With CombinarCeldas(Celda.Offset(-wCantCeldas, 11), Celda.Offset(0, 11), "")
      .Formula = "=SUMA(" & Celda.Offset(-wCantCeldas, 9).Address & ":" & Celda.Offset(0, 9).Address & ")"
    End With
    With CombinarCeldas(Celda.Offset(-wCantCeldas, 14), Celda.Offset(-1, 14), "")
      .Formula = "=SUMA(" & Celda.Offset(-wCantCeldas, 12).Address & ":" & Celda.Offset(0, 12).Address & ")"
    End With
    If CInt(Celda.Offset(-wCantCeldas, 5).Value) > 0 Then
      Celda.Offset(0, 14).Formula = "=1-" & Celda.Offset(0, 8).Address
      Celda.Offset(0, 14).NumberFormat = "0.00%"
    End If
  End Sub

  Private Sub ResumenGrado(ByVal Celda As Range, ByVal wCantCeldas As Integer)
    With CombinarCeldas(Celda.Offset(-wCantCeldas, 4), Celda.Offset(0, 4), "")
      .Formula = "=SUMA(" & Celda.Offset(-wCantCeldas, 3).Address & ":" & Celda.Offset(0, 3).Address & ")"
    End With
    With CombinarCeldas(Celda.Offset(-wCantCeldas, 7), Celda.Offset(-1, 7), "")
      .Formula = "=SUMA(" & Celda.Offset(-wCantCeldas, 6).Address & ":" & Celda.Offset(0, 6).Address & ")"
    End With
    If CInt(Celda.Offset(-wCantCeldas, 4).Value) > 0 Then
      Celda.Offset(0, 7).Formula = "=((" & Celda.Offset(-wCantCeldas, 7).Address & "-" & Celda.Offset(-wCantCeldas, 10).Address & ")/" & Celda.Offset(-wCantCeldas, 4).Address & ")"
      Celda.Offset(0, 7).NumberFormat = "0.00%"
    End If

    With CombinarCeldas(Celda.Offset(-wCantCeldas, 10), Celda.Offset(0, 10), "")
      .Formula = "=SUMA(" & Celda.Offset(-wCantCeldas, 9).Address & ":" & Celda.Offset(0, 9).Address & ")"
    End With
    With CombinarCeldas(Celda.Offset(-wCantCeldas, 13), Celda.Offset(-1, 13), "")
      .Formula = "=SUMA(" & Celda.Offset(-wCantCeldas, 12).Address & ":" & Celda.Offset(0, 12).Address & ")"
    End With
    If CInt(Celda.Offset(-wCantCeldas, 4).Value) > 0 Then
      Celda.Offset(0, 13).Formula = "=1-" & Celda.Offset(0, 7).Address
      Celda.Offset(0, 13).NumberFormat = "0.00%"
    End If
  End Sub

  Private Sub CrearCabeceraReporte(ByVal wCelda As Range)
    Dim Hoja As Worksheet = wCelda.Worksheet
    Dim ini As Range = wCelda

    CombinarCeldasNegrita(wCelda, wCelda.Offset(1, 0), "NIVEL")
    wCelda = wCelda.Offset(0, 1)
    CombinarCeldasNegrita(wCelda, wCelda.Offset(1, 0), "GRADO")
    wCelda = wCelda.Offset(0, 1)
    CombinarCeldasNegrita(wCelda, wCelda.Offset(1, 0), "SECCIÓN")

    wCelda = wCelda.Offset(0, 1)
    CombinarCeldasNegrita(wCelda, wCelda.Offset(0, 2), "MAT. ESPERADAS")
    wCelda = wCelda.Offset(1, 0)
    With wCelda
      .Value = "Seccion"
      .Font.Bold = True
      .HorizontalAlignment = XlHAlign.xlHAlignCenter
    End With
    wCelda = wCelda.Offset(0, 1)
    With wCelda
      .Value = "Grado"
      .Font.Bold = True
      .HorizontalAlignment = XlHAlign.xlHAlignCenter
    End With
    wCelda = wCelda.Offset(0, 1)
    With wCelda
      .Value = "Nivel"
      .Font.Bold = True
      .HorizontalAlignment = XlHAlign.xlHAlignCenter
    End With

    wCelda = wCelda.Offset(-1, 1)
    CombinarCeldasNegrita(wCelda, wCelda.Offset(0, 2), "MAT. REALIZADAS")
    wCelda = wCelda.Offset(1, 0)
    With wCelda
      .Value = "Seccion"
      .Font.Bold = True
      .HorizontalAlignment = XlHAlign.xlHAlignCenter
    End With
    wCelda = wCelda.Offset(0, 1)
    With wCelda
      .Value = "Grado"
      .Font.Bold = True
      .HorizontalAlignment = XlHAlign.xlHAlignCenter
    End With
    wCelda = wCelda.Offset(0, 1)
    With wCelda
      .Value = "Nivel"
      .Font.Bold = True
      .HorizontalAlignment = XlHAlign.xlHAlignCenter
    End With

    wCelda = wCelda.Offset(-1, 1)
    CombinarCeldasNegrita(wCelda, wCelda.Offset(0, 2), "NUEVOS ALUMNOS")
    wCelda = wCelda.Offset(1, 0)
    With wCelda
      .Value = "Seccion"
      .Font.Bold = True
      .HorizontalAlignment = XlHAlign.xlHAlignCenter
    End With
    wCelda = wCelda.Offset(0, 1)
    With wCelda
      .Value = "Grado"
      .Font.Bold = True
      .HorizontalAlignment = XlHAlign.xlHAlignCenter
    End With
    wCelda = wCelda.Offset(0, 1)
    With wCelda
      .Value = "Nivel"
      .Font.Bold = True
      .HorizontalAlignment = XlHAlign.xlHAlignCenter
    End With

    wCelda = wCelda.Offset(-1, 1)
    CombinarCeldasNegrita(wCelda, wCelda.Offset(0, 2), "MAT. POR REALIZAR")
    wCelda = wCelda.Offset(1, 0)
    With wCelda
      .Value = "Seccion"
      .Font.Bold = True
      .HorizontalAlignment = XlHAlign.xlHAlignCenter
    End With
    wCelda = wCelda.Offset(0, 1)
    With wCelda
      .Value = "Grado"
      .Font.Bold = True
      .HorizontalAlignment = XlHAlign.xlHAlignCenter
    End With
    wCelda = wCelda.Offset(0, 1)
    With wCelda
      .Value = "Nivel"
      .Font.Bold = True
      .HorizontalAlignment = XlHAlign.xlHAlignCenter
    End With

    FondoGris(Hoja.Range(ini, wCelda))
  End Sub

  Public Sub CombinarCeldasOrientacion(ByVal wIni As Range, ByVal wFin As Range, ByVal wValor As String)
    With CombinarCeldasNegrita(wIni, wFin, wValor)
      .Orientation = XlOrientation.xlUpward
    End With
  End Sub

  Private Sub frmEstadisticaMatricula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.MostrarImagenes()
  End Sub

  Private Sub MostrarImagenes()
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\excel.bmp")
  End Sub

End Class