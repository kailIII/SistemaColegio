Imports Microsoft.Office.Interop.Excel

Module modExcel

  Public Function CrearExcel() As Microsoft.Office.Interop.Excel.Application
    Dim app As New Microsoft.Office.Interop.Excel.Application

    app.ScreenUpdating = False
    app.DisplayAlerts = False

    Return app
  End Function

  Public Function AbrirPlantilla(ByVal wExcel As Application, ByVal wDialogo As SaveFileDialog, ByVal wPlantilla As String) As Workbook
    Dim wb As Workbook = Nothing

    If wDialogo.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
      Return Nothing
    End If
    wb = wExcel.Workbooks.Open(wPlantilla)

    Return wb
  End Function

  Public Sub DestruirProcesoExcel()
    Dim proc As Process()

    proc = Process.GetProcessesByName("EXCEL")
    For Each p As Process In proc
      p.Kill()
    Next
    proc = Nothing

  End Sub

  Public Function CombinarCeldas(ByVal wIni As Range, ByVal wfin As Range, ByVal wValor As String) As Range
    Dim hoja As Worksheet = wIni.Worksheet

    With hoja.Range(wIni, wfin)
      .Merge()
      .VerticalAlignment = XlVAlign.xlVAlignCenter
      .HorizontalAlignment = XlHAlign.xlHAlignCenter
    End With
    wIni.Value = wValor

    Return wIni
  End Function

  Public Function CombinarCeldasNegrita(ByVal wIni As Range, ByVal wfin As Range, ByVal wValor As String) As Range

    With CombinarCeldas(wIni, wfin, wValor)
      .Font.Bold = True
    End With

    Return wIni
  End Function

  Public Sub BordesTodo(ByVal wCelda As Range)
    With wCelda
      With .Borders(XlBordersIndex.xlEdgeLeft)
        .LineStyle = XlLineStyle.xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = XlBorderWeight.xlThin
      End With
      With .Borders(XlBordersIndex.xlEdgeTop)
        .LineStyle = XlLineStyle.xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = XlBorderWeight.xlThin
      End With
      With .Borders(XlBordersIndex.xlEdgeBottom)
        .LineStyle = XlLineStyle.xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = XlBorderWeight.xlThin
      End With
      With .Borders(XlBordersIndex.xlEdgeRight)
        .LineStyle = XlLineStyle.xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = XlBorderWeight.xlThin
      End With
      With .Borders(XlBordersIndex.xlInsideVertical)
        .LineStyle = XlLineStyle.xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = XlBorderWeight.xlThin
      End With
      With .Borders(XlBordersIndex.xlInsideHorizontal)
        .LineStyle = XlLineStyle.xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = XlBorderWeight.xlThin
      End With
    End With
  End Sub

  Public Sub BordesCuadrado(ByVal wCelda As Range)
    With wCelda
      With .Borders(XlBordersIndex.xlEdgeLeft)
        .LineStyle = XlLineStyle.xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = XlBorderWeight.xlMedium
      End With
      With .Borders(XlBordersIndex.xlEdgeTop)
        .LineStyle = XlLineStyle.xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = XlBorderWeight.xlMedium
      End With
      With .Borders(XlBordersIndex.xlEdgeBottom)
        .LineStyle = XlLineStyle.xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = XlBorderWeight.xlMedium
      End With
      With .Borders(XlBordersIndex.xlEdgeRight)
        .LineStyle = XlLineStyle.xlContinuous
        .ColorIndex = 0
        .TintAndShade = 0
        .Weight = XlBorderWeight.xlMedium
      End With
    End With
  End Sub

  Public Sub FondoGris(ByVal wCelda As Range)
    With wCelda
      With .Interior
        .Pattern = XlPattern.xlPatternSolid
        .PatternColorIndex = XlPattern.xlPatternAutomatic
        '.ThemeColor = XlThemeColor.xlThemeColorDark1
        .TintAndShade = -0.149998474074526
        .PatternTintAndShade = 0
      End With
    End With
  End Sub

End Module
