Imports Microsoft.Office.Interop.Excel

Public Class frmRegistroAuxSec
  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing
  Private Const clave As String = "12345678"
  Private Ldc As List(Of DocenteCarga) = Nothing
  Private lAlu As List(Of Matricula) = Nothing
  Private vectorAlu(70) As Integer

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub frmRegistroAuxSec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    MostrarImagenes()
    MostrarAnioPeriodo()
    MostrarCursosSeccion()
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
      Me.btnExportar.Enabled = False
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
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
    Dim rnCo As New RNCoordinadorAreaDre
    Dim co As CoordinadorAreaDre = Nothing

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
        Me.sfdArchivos.FileName = "Auxiliar_" & moAnioActual.Anio.Trim & "_" & mOPeriodoActual.Siglas.Trim _
                        & "_" & lDoc(0).Carga.Curso.Nombre & "_" & lDoc(0).Carga.GradoSeccion & ".xls"
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

          Libro = m_excel.Workbooks.Add(AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\RegistroAuxiliarSecundaria.xls")
          m_excel.ScreenUpdating = False
          m_excel.DisplayAlerts = False

          For Each Uni As Unidad In lUni
            Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
            Hoja.Select()
            Hoja.Copy(, Hoja)
            k = 10
            y = 6
            i = 0
            Hoja.Unprotect(clave)
            '''''''''''''Guardar Datos del docente y curso'''''''''''''
            Hoja.Range("B5").Value = moAnioActual.anio & " - Trimestre " & RetornaPer(mOPeriodoActual.Siglas) & " - Unidad " & RetornaNum(Uni.Numero)
            Hoja.Range("F7").Value = dc.Carga.Curso.Nombre
            Hoja.Range("C7").Value = mOUsuario.Persona.NombreCompleto
            Hoja.Range("U7").Value = dc.Carga.GradoSeccion
            'Mostrar el nombre del asesor(coordinador)
            co = rnCo.LeerAsesorArea(New Curso(dc.Carga.Curso.Codigo))
            If co IsNot Nothing Then
              Hoja.Range("C70").Value = co.NombreCompleto
            End If
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Me.InicializarVectorAlumnos()
            Me.MostrarAlumnosCurso(lAlu, Hoja)

            For Each cap As Capacidad In lCap
              Hoja.Range(Hoja.Cells(k - 1, y), Hoja.Cells(k - 1, y)).Value = cap.Nombre
              For m As Integer = 1 To 5
                Hoja.Range(Hoja.Cells(k, y), Hoja.Cells(k, y)).ColumnWidth = 3
                Hoja.Range(Hoja.Cells(k, y), Hoja.Cells(k, y)).RowHeight = 60
                y += 1
              Next
              Hoja.Range(Hoja.Cells(k, y), Hoja.Cells(k, y)).ColumnWidth = 4
              y += 1
            Next
            Hoja.Name = "Unidad " & Uni.Numero
            Hoja.Protect(clave)
          Next

          If lUni.Count > 0 Then
            Me.pbAvance.Value += 5
            m_excel.ScreenUpdating = True

            'Eliminar la ultima hoja
            Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
            Hoja.Select()
            Hoja.Delete()

            'Seleccionar la primera hoja
            Hoja = CType(Libro.Worksheets(1), Worksheet)
            Hoja.Select()

            If Me.cboCurso.SelectedIndex > 0 Then
              m_excel.ActiveWorkbook.SaveAs(Me.sfdArchivos.FileName, _
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
            ElseIf Me.cboCurso.SelectedIndex = 0 Then
              m_excel.ActiveWorkbook.SaveAs(ruta & "Auxiliar_" & moAnioActual.Anio.Trim & "_" & mOPeriodoActual.Siglas.Trim _
                  & "_" & dc.Carga.Curso.Nombre & "_" & dc.Carga.GradoSeccion & ".xls", _
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

  Private Sub InicializarVectorAlumnos()
    For i As Integer = 0 To 70
      vectorAlu(i) = 0
    Next
  End Sub

  Private Sub MostrarAlumnosCurso(ByVal listAlu As List(Of Matricula), ByVal hoja As Worksheet)
    Dim j As Integer = 16
    Dim i As Integer = 0
    
    For Each a As Matricula In listAlu
      hoja.Range("B" & j).RowHeight = 15
      hoja.Range("B" & j).Value = a.NroOrden
      hoja.Range("C" & j).Value = a.Alumno.NombreCompleto
      vectorAlu(i) = a.NroOrden
      j += 1
      i += 1
    Next
  End Sub

End Class