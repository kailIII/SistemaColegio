Imports Microsoft.Office.Interop.Excel

Public Class frmExportarRegistroSec
  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing
  Private Const clave As String = "12345678"
  Private lAlu As List(Of Matricula) = Nothing
  Private Ldc As List(Of DocenteCarga) = Nothing
  Private vectorAlu(70) As Integer

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Public Sub MostrarImagenes()
        Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
        Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\excel.bmp")
  End Sub

  Private Sub MostrarAnioPeriodo()
    Me.txtAnio.Text = moAnioActual.anio & "    -    " & mOPeriodoActual.Nombre
  End Sub

  Private Sub MostrarCursosSeccion()
    Dim objRN As New RNDocenteCarga

    Ldc = objRN.ListarCargaSeccion2(mOPeriodoActual, New Docente(mOUsuario.Persona.Codigo))
    If Ldc.Count > 0 Then
      Ldc.Insert(0, New DocenteCarga())
      cboCurso.DisplayMember = "CursoSeccion"
      cboCurso.ValueMember = "Codigo"
      cboCurso.DataSource = Ldc
    Else
      cboCurso.DataSource = Nothing
    End If
  End Sub

  Private Sub frmExportarRegistroSec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.MostrarImagenes()
    Me.MostrarAnioPeriodo()
    Me.MostrarCursosSeccion()
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Dim lDoc As New List(Of DocenteCarga)
    Dim lUni As List(Of Unidad) = Nothing
    Dim lCap As List(Of Capacidad) = Nothing
    Dim lNot As List(Of NotaCapacidad) = Nothing

    Dim rnD As New RNDocenteCarga
    Dim rnU As New RNUnidad
    Dim rnC As New RNCapacidad
    Dim rnN As New RNNotaCapacidad
    Dim rnM As New RNMatricula

    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing
    Dim proc As Process()

    Dim k, y, i As Integer
    Dim l As Integer = -1
    Dim pos As Integer
    Dim sw As Integer = 0
    Dim ruta As String = ""

    Dim resumen As String = ""
    Dim comilla As String = """"
    Dim promTri As String = ""
    Dim x, z As Integer
    x = 10
    z = 8

    Try
      m_excel = New Microsoft.Office.Interop.Excel.Application
      Libro = Nothing
      Hoja = Nothing

      If Me.cboCurso.SelectedIndex = 0 Then
        lDoc = rnD.ListarCargaSeccion2(mOPeriodoActual, New Docente(mOUsuario.Persona.Codigo))
      Else
        lDoc.Add(CType(Me.cboCurso.SelectedItem, DocenteCarga))
      End If

      Me.sfdArchivos.Filter = "Archivos (*.xls)|*.xls"
      If Me.cboCurso.SelectedIndex = 0 Then
        Me.sfdArchivos.FileName = "Guardar Todos"
      Else
        Me.sfdArchivos.FileName = moAnioActual.Anio.Trim & "_" & mOPeriodoActual.Siglas.Trim _
                        & "_" & lDoc(0).Carga.Curso.Nombre & "_" & mOUsuario.Persona.ApellidoPaterno & "_" & lDoc(0).Carga.GradoSeccion & ".xls"
      End If

      If Me.sfdArchivos.ShowDialog = System.Windows.Forms.DialogResult.OK Then
        If Me.cboCurso.SelectedIndex = 0 Then
          ruta = Me.sfdArchivos.FileName
          For g As Integer = 0 To ruta.Length - 1
            If ruta.Chars(g) = "\" Then
              pos = g
            End If
          Next
          ruta = Microsoft.VisualBasic.Left(ruta, pos + 1)
        End If
        sw = 1
      End If

      If sw = 1 Then
        For Each dc As DocenteCarga In lDoc
          lAlu = rnM.ListarAlumnosGradoSeccionExport(New Seccion(New AnioLectivo(moAnioActual.anio), _
                                      New Grado(dc.Carga.CodigoGrado), dc.Carga.Seccion.Letra), _
                                      dc)
          lUni = rnU.ListarUnidades(New DocenteCarga(dc.Codigo, Nothing, _
                                    New PeriodoAcademico(mOPeriodoActual.Codigo)))
          lCap = rnC.ListarCapacidadesCurso(New Curso(dc.Carga.Curso.Codigo))

          Libro = m_excel.Workbooks.Add(AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Registro_Secundaria.xls")
          m_excel.ScreenUpdating = False
          m_excel.DisplayAlerts = False

          For Each Uni As Unidad In lUni
            Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
            Hoja.Select()
            Hoja.Copy(, Hoja)
            k = 10
            y = 8
            i = 0
            Hoja.Unprotect(clave)
            '''''''''''''Guardar Datos del docente y curso'''''''''''''
            Hoja.Range("B3").Value = moAnioActual.anio & " - Trimestre " & RetornaPer(mOPeriodoActual.Siglas)
            Hoja.Range("AC1").Value = mOUsuario.Codigo
            Hoja.Range("AC2").Value = dc.Codigo
            Hoja.Range("AC5").Value = moAnioActual.anio
            Hoja.Range("AC6").Value = mOPeriodoActual.Codigo
            Hoja.Range("AC8").Value = Uni.Numero
            Hoja.Range("D5").Value = dc.Carga.Curso.Nombre
            Hoja.Range("D6").Value = mOUsuario.Persona.NombreCompleto
            Hoja.Range("I5").Value = dc.Carga.GradoSeccion
            Hoja.Range("H8").Value = "UNIDAD " & RetornaNum(Uni.Numero)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            InicializarVectorAlumnos()
            MostrarAlumnosCurso(lAlu, Hoja)
            Hoja.Range("AC71").Value = lCap.Count
            For Each cap As Capacidad In lCap
              Hoja.Range(Hoja.Cells(k, y), Hoja.Cells(k, y)).ColumnWidth = 7
              lNot = rnN.ListarNotasCurso(New NotaCapacidad(0, CDbl(0), Now, True, _
                      New Matricula(0, Now, New Grado(dc.Carga.CodigoGrado), _
                                    Nothing, Nothing, dc.Carga.Seccion.Letra _
                                    , 0, True), _
                      New PeriodoAcademico(mOPeriodoActual.Codigo), _
                      New Personal(), New Capacidad(cap.Codigo), New Unidad(Uni.Numero, "", True, _
                                                New PeriodoAcademico(), _
                                                New DocenteCarga(dc.Codigo))))

              For Each nota As NotaCapacidad In lNot
                Do
                  l += 1 'para avanzar el vector 
                  If vectorAlu(l) = nota.Matricula.NroOrden Then
                    Hoja.Range(Hoja.Cells(k, y), Hoja.Cells(k, y)).Value = nota.Promedio
                  End If
                  k += 1
                Loop Until (vectorAlu(l) = nota.Matricula.NroOrden)
              Next
              Hoja.Range(Hoja.Cells(71, 8 + i), Hoja.Cells(71, 8 + i)).Value = cap.Codigo
              l = -1
              i += 1
              y += 1
              k = 10
            Next
            Hoja.Name = "Unidad " & Uni.Numero

            'poner formula para calcular promedio
            'jimmy
            For k = 0 To lAlu.Count - 1
              comilla = """"
              promTri = ""
              resumen = ""
              z = 8
              For m As Integer = 1 To lCap.Count
                resumen = resumen & "'" & Hoja.Name & "'!" & Hoja.Range(Hoja.Cells(x + k, z), Hoja.Cells(x + k, z)).Address & "<>" & comilla & comilla & ","
                promTri = promTri & "'" & Hoja.Name & "'!" & Hoja.Range(Hoja.Cells(x + k, z), Hoja.Cells(x + k, z)).Address & ","
                z += 1
              Next
              resumen = resumen.Substring(0, resumen.Length - 1)
              promTri = promTri.Substring(0, promTri.Length - 1)
              Hoja.Range(Hoja.Cells(10 + k, 18), Hoja.Cells(10 + k, 18)).Formula = _
                   "=SI(Y(" & resumen & "),PROMEDIO(" & promTri & "),"""")"
            Next

            Hoja.Protect(clave)
          Next

          If lUni.Count > 0 Then
            Me.pbAvance.Value += 5
            m_excel.ScreenUpdating = True

            'Eliminar la ultima hoja
            Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
            Hoja.Select()
            Hoja.Delete()
            'Agregando la hoja resúmen            
            HojaResumen(lCap, lAlu, Libro, Hoja)
            'Seleccionar la primera hoja
            Hoja = CType(Libro.Worksheets(1), Worksheet)
            Hoja.Select()

            If Me.cboCurso.SelectedIndex > 0 Then
              m_excel.ActiveWorkbook.SaveAs(Me.sfdArchivos.FileName, _
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
            ElseIf Me.cboCurso.SelectedIndex = 0 Then
              m_excel.ActiveWorkbook.SaveAs(ruta & moAnioActual.Anio.Trim & "_" & mOPeriodoActual.Siglas.Trim _
                  & "_" & dc.Carga.Curso.Nombre & "_" & mOUsuario.Persona.ApellidoPaterno & "_" & dc.Carga.GradoSeccion & ".xls", _
                  Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
            End If
          End If

        Next

        If lUni.Count > 0 Then
          Me.pbAvance.Value = Me.pbAvance.Maximum
          MessageBox.Show("Archivo guardado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          MessageBox.Show("El curso no tiene unidades registradas", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Question)
        End If

      End If

      Me.pbAvance.Value = 0
    Catch ex As Exception
      Hoja = Nothing
      Libro = Nothing
      m_excel = Nothing
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Me.pbAvance.Value = 0
    Finally
      If Hoja IsNot Nothing Then
        System.Runtime.InteropServices.Marshal.ReleaseComObject(Hoja)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(Libro)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(m_excel)
      End If

      Hoja = Nothing
      Libro = Nothing
      m_excel = Nothing

      proc = Process.GetProcessesByName("EXCEL")
      For Each p As Process In proc
        p.Kill()
      Next
      proc = Nothing
    End Try

  End Sub

  Private Sub HojaResumen(ByVal lCap As List(Of Capacidad), ByVal listAlu As List(Of Matricula), ByVal libro As Workbook, ByVal hoja As Worksheet)
    Dim hojaRes(10) As Worksheet
    Dim nroAlu As Integer = listAlu.Count
    Dim nroCap As Integer = lCap.Count
    Dim a As Integer = 10
    Dim b As Integer = 8
    Dim prom As Double = 0.0
    Dim sum As Integer = 0
    Dim cadena As String = ""
    Dim cadena2 As String = ""
    Dim resumen As String = ""
    Dim comilla As String = """"
    Dim promTri As String = ""
    Dim x, y As Integer
    x = 10
    y = 8

    hoja = CType(libro.Worksheets(libro.Worksheets.Count), Worksheet)
    hoja.Select()
    hoja.Copy(, hoja)
    hoja = CType(libro.Worksheets(libro.Worksheets.Count), Worksheet)
    hoja.Select()
    hoja.Unprotect(clave)
    hoja.Range("H8").Value = "PROMEDIO"
    hoja.Range("R8").Value = "Prom. Trim."
    hoja.Name = "Resúmen"

    For i As Integer = 1 To libro.Worksheets.Count - 1
      hojaRes(i) = CType(libro.Worksheets(i), Worksheet)
      hojaRes(i).Select()
    Next

    For j As Integer = 1 To nroCap
      a = 10
      For k As Integer = 1 To nroAlu

        cadena = ""
        cadena2 = ""
        For i As Integer = 1 To libro.Worksheets.Count - 1
          cadena = cadena & "'" & hojaRes(i).Name & "'!" & hojaRes(i).Range(hojaRes(i).Cells(a, b), hojaRes(i).Cells(a, b)).Address & ","
          cadena2 = cadena2 & "'" & hojaRes(i).Name & "'!" & hojaRes(i).Range(hojaRes(i).Cells(a, b), hojaRes(i).Cells(a, b)).Address & "<>0,"
        Next
        cadena = cadena.Substring(0, cadena.Length - 1)
        cadena2 = cadena2.Substring(0, cadena2.Length - 1)
        hoja.Range(hoja.Cells(a, b), hoja.Cells(a, b)).NumberFormat = "00.00"

        hoja.Range(hoja.Cells(a, b), hoja.Cells(a, b)).Validation.Delete()
        hoja.Range(hoja.Cells(a, b), hoja.Cells(a, b)).Formula = _
        "=SI(ESERROR(SI((SI(Y(" & cadena2 & "),PROMEDIO(" & cadena & "),"""")),PROMEDIO(" & cadena & "),"""")),"""",PROMEDIO(" & cadena & "))"

        'no olvidar poner las 2 comillas dentro en los valores vacios

        hoja.Range(hoja.Cells(a, b), hoja.Cells(a, b)).Locked = True

        If j = 1 Then          
          hoja.Range(hoja.Cells(10 + sum, 12), hoja.Cells(10, 18 + sum)).NumberFormat = "##"
          sum += 1
        End If

        a += 1
      Next
      b += 1
    Next

    'Colocar formula del promedio de trimestre
    For k = 0 To nroAlu - 1
      comilla = """"
      promTri = ""
      resumen = ""
      y = 8
      For m As Integer = 1 To lCap.Count
        resumen = resumen & "'" & hoja.Name & "'!" & hoja.Range(hoja.Cells(x + k, y), hoja.Cells(x + k, y)).Address & "<>" & comilla & comilla & ","
        promTri = promTri & "'" & hoja.Name & "'!" & hoja.Range(hoja.Cells(x + k, y), hoja.Cells(x + k, y)).Address & ","
        y += 1
      Next
      resumen = resumen.Substring(0, resumen.Length - 1)
      promTri = promTri.Substring(0, promTri.Length - 1)
      hoja.Range(hoja.Cells(10 + k, 18), hoja.Cells(10 + k, 18)).Formula = _
           "=SI(Y(" & resumen & "),PROMEDIO(" & promTri & "),"""")"
    Next

    hoja.Protect(clave)
  End Sub

  Private Function RetornaNum(ByVal num As Integer) As String
    Dim str As String = ""

    Select Case num
      Case 1
        str = "I"
      Case 2
        str = "II"
      Case 3
        str = "III"
      Case 4
        str = "IV"
      Case 5
        str = "V"
      Case 6
        str = "VI"
      Case 7
        str = "VII"
      Case 8
        str = "VIII"
      Case 9
        str = "IX"
      Case 10
        str = "X"
    End Select

    Return str
  End Function

  Private Function RetornaPer(ByVal tri As String) As String
    Dim str As String = ""

    Select Case tri.Trim
      Case "T1"
        str = "I"
      Case "T2"
        str = "II"
      Case "T3"
        str = "III"
    End Select

    Return str
  End Function

  Private Sub MostrarAlumnosCurso(ByVal listAlu As List(Of Matricula), ByVal hoja As Worksheet)
    Dim j As Integer = 10
    Dim i As Integer = 0

    For Each a As Matricula In listAlu
      hoja.Range("B" & j).RowHeight = 15
      hoja.Range("B" & j).Value = a.NroOrden
      hoja.Range("C" & j).Value = a.Alumno.NombreCompleto
      hoja.Range("AC" & j).Value = a.Numero
      vectorAlu(i) = a.NroOrden
      j += 1
      i += 1
    Next
  End Sub

  Private Sub InicializarVectorAlumnos()
    For i As Integer = 0 To 70
      vectorAlu(i) = 0
    Next
  End Sub
End Class