Imports Microsoft.Office.Interop.Excel

Public Class frmImportarPlanLector

  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing
  Private Const clave As String = "CETI"

  Private Sub frmImportarPlanLector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnImportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\excel.bmp")

    txtAnio.Text = moAnioActual.Anio
  End Sub

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnExaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExaminar.Click
    With Me.ofdArchivo
      .Title = "Seleccione Archivo"
      .Filter = "Todos los Archivos (*.xls)|*.xls"
      .Multiselect = False
      .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments

      If Me.ofdArchivo.ShowDialog = System.Windows.Forms.DialogResult.OK Then
        txtRuta.Text = .FileName
      End If
    End With
  End Sub

  Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
    Dim obj As New RNNotaLectura
    Dim Letra As String
    Dim nroMat, j As Integer
    Dim NotaLect As NotaLectura

    Dim coment As String = ""
    Dim codPL As Integer = 0

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

      If CInt(Hoja.Range("N1").Value) = mOUsuario.Codigo And _
                  CStr(Hoja.Range("N3").Value) = moAnioActual.Anio Then

        For k As Integer = 1 To Libro.Worksheets.Count
          Hoja = CType(Libro.Worksheets(k), Worksheet)
          Hoja.Select()

          j = 10
          Me.pbAvance.Value += 5
          For i As Integer = 1 To CInt(Hoja.Range("P10").Value) 'alumnos_mat

            nroMat = CInt(Hoja.Range("N" & j).Value)
            codPL = CInt(Hoja.Range("O" & j).Value)

            If CStr(Hoja.Range("K" & j).Value) <> "" Then
              Letra = CStr(Hoja.Range("K" & j).Value)

              coment = ""
              Select Case Letra
                Case "C"
                  coment = "Requiere Recuperación"
                Case "NP"
                  coment = "No se Presento"
              End Select

              NotaLect = obj.LeerNota(New NotaLectura(New Matricula(nroMat), "", "", New ProgramacionLectura(codPL)))

              If NotaLect Is Nothing Then
                obj.Registrar(New NotaLectura(0, Letra, coment, Now, True, New ProgramacionLectura(codPL), _
                                      New Matricula(nroMat), mOUsuario.Persona.Codigo))
              Else
                If Letra.Trim <> NotaLect.Nota.Trim Then
                  obj.RegistrarNuevaNota(New NotaLectura(NotaLect.Codigo, Letra, coment, Now, True, _
                                  New ProgramacionLectura(codPL), New Matricula(nroMat), mOUsuario.Persona.Codigo))
                End If
              End If
            End If

            j += 1
          Next
          If Me.pbAvance.Value > 40 Then
            Me.pbAvance.Value -= 10
          End If
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