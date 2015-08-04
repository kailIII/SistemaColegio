Imports Microsoft.Office.Interop.Excel

Public Class frmImportarRegInd
  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing
  Private Const clave As String = "CETI"

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub frmImportarRegInd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    MostrarAnioPeriodo()
    MostrarImagenes()
  End Sub

  Public Sub MostrarImagenes()
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnImportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\excel.bmp")
  End Sub

  Private Sub MostrarAnioPeriodo()
    Me.txtAnio.Text = moAnioActual.Anio & "    -    " & mOPeriodoActual.Nombre
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnExaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExaminar.Click
    With Me.ofdArchivo
      .Title = "Seleccione Archivo"
      .Filter = "Todos los Archivos (*.xls)|*.xls"
      .Multiselect = False
      '.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments

      If Me.ofdArchivo.ShowDialog = System.Windows.Forms.DialogResult.OK Then
        txtRuta.Text = .FileName
      End If
    End With
  End Sub

  Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
    Dim obj As New RNMatriculaIndicador
    Dim Letra As String
    Dim nro, j As Integer
    Dim a, b As Integer
    Dim nota As MatriculaIndicador
    Dim codInd As Integer

    Dim promTri As String = ""
    Dim NivelEsf As String = ""
    Dim objProm As New RNPromedioPeriodoCurso
    Dim NotaProm As PromedioPeriodoCurso
    Dim codDC As Integer

    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing
    Dim proc As Process()

    Try
      m_excel = New Microsoft.Office.Interop.Excel.Application
      Libro = Nothing
      Hoja = Nothing
      Libro = m_excel.Workbooks.Open(Me.txtRuta.Text)
      m_excel.ScreenUpdating = False
      m_excel.DisplayAlerts = False
      Hoja = CType(Libro.Worksheets(1), Worksheet)
      Hoja.Select()

      If CInt(Hoja.Range("A56").Value) = mOUsuario.Codigo And _
                  CStr(Hoja.Range("B56").Value) = moAnioActual.Anio And _
                           CInt(Hoja.Range("C56").Value) = mOPeriodoActual.Codigo Then

        For k As Integer = 1 To Libro.Worksheets.Count
          Hoja = CType(Libro.Worksheets(k), Worksheet)
          Hoja.Select()
          j = 10
          a = 10
          Me.pbAvance.Value += 8

          For i As Integer = 1 To CInt(Hoja.Range("B52").Value) 'alumnos
            nro = CInt(Hoja.Range("AN" & j).Value)
            codDC = CInt(Hoja.Range("D56").Value)
            b = 10

            For m As Integer = 0 To CInt(Hoja.Range("AJ6").Value) - 1
              'INDICADORES_notas
              If Hoja.Range(Hoja.Cells(a, b), Hoja.Cells(a, b)).Value IsNot Nothing AndAlso CStr(Hoja.Range(Hoja.Cells(a, b), Hoja.Cells(a, b)).Value) <> "" Then
                Letra = CStr(Hoja.Range(Hoja.Cells(a, b), Hoja.Cells(a, b)).Value).Trim
                codInd = CInt(Hoja.Range(Hoja.Cells(6, b), Hoja.Cells(6, b)).Value)
                nota = obj.LeerNota(New MatriculaIndicador(nro, codInd))

                If nota Is Nothing Then
                  obj.Registrar(New MatriculaIndicador(New Matricula(nro), 0, Letra, Now, True, codInd, _
                                mOUsuario.Persona.Codigo, 0, 0))
                Else
                  If Letra.Trim <> nota.Letra.Trim Then
                    obj.RegistrarNuevaNotaIndicador(New MatriculaIndicador(New Matricula(nro), nota.Numero, Letra, _
                                                                Now, True, codInd, mOUsuario.Persona.Codigo, 0, 0))
                  End If
                End If
              End If
              b += 1
            Next
            'Promedio y nivel de esfuerzo
            If Hoja.Range("AJ" & j).Value IsNot Nothing AndAlso Hoja.Range("AK" & j).Value IsNot Nothing AndAlso _
              Hoja.Range("AJ" & j).Value.ToString.Length > 0 AndAlso Hoja.Range("AK" & j).Value.ToString.Length > 0 Then

              promTri = CStr(Hoja.Range("AJ" & j).Value)
              NivelEsf = CStr(Hoja.Range("AK" & j).Value)
              NotaProm = objProm.LeerPromInd(New PromedioPeriodoCurso(CInt(Hoja.Range("AM" & j).Value), nro, mOPeriodoActual.Codigo, promTri, NivelEsf.Chars(0)))

              If NotaProm Is Nothing Then
                objProm.Registrar(New PromedioPeriodoCurso(Nothing, codDC, nro, mOPeriodoActual.Codigo, _
                                                       mOUsuario.Persona.Codigo, promTri, NivelEsf.Chars(0)))
              Else
                If promTri.Trim <> NotaProm.Letra.Trim Or NivelEsf <> NotaProm.NivelEsfuerzo Then
                  objProm.RegistrarNuevaPromInd(New PromedioPeriodoCurso(NotaProm.Codigo, codDC, Nothing, Nothing, mOUsuario.Persona.Codigo, _
                                                                     promTri, NivelEsf.Chars(0)))
                End If
              End If
              'ElseIf Hoja.Range("AJ" & j).Value Is Nothing OrElse Hoja.Range("AK" & j).Value Is Nothing Then
              '  MessageBox.Show("No se encontró el promedio o el nivel de esfuerzo" & vbCrLf & _
              '                  "Ambos datos son obligatorios", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            a += 1
            j += 1
          Next
          'If Me.pbAvance.Value > 40 Then
          '    Me.pbAvance.Value -= 10
          'End If
        Next

        m_excel.ScreenUpdating = True
        Me.pbAvance.Value = Me.pbAvance.Maximum
        MessageBox.Show("Notas importadas con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.pbAvance.Value = 0
      Else
        MessageBox.Show("Registro no válido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If
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


End Class