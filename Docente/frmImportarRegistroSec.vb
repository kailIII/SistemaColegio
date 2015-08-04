Imports Microsoft.Office.Interop.Excel

Public Class frmImportarRegistroSec

  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing
  Private Const clave As String = "12345678"

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub frmImportarRegistroSec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
      '  .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments

      If Me.ofdArchivo.ShowDialog = System.Windows.Forms.DialogResult.OK Then
        txtRuta.Text = .FileName
      End If
    End With
  End Sub

  Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
    Dim obj As New RNNotaCapacidad
    Dim prom As Double
    Dim nro, j As Integer
    Dim a, b As Integer
    Dim nota As NotaCapacidad

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

      If CInt(Hoja.Range("AC1").Value) = mOUsuario.Codigo AndAlso _
         CStr(Hoja.Range("AC5").Value) = moAnioActual.Anio AndAlso _
         CInt(Hoja.Range("AC6").Value) = mOPeriodoActual.Codigo Then

        Me.pbAvance.Maximum = CInt(Hoja.Range("I6").Value) * (Libro.Worksheets.Count - 1)
        For k As Integer = 1 To Libro.Worksheets.Count - 1
          Hoja = CType(Libro.Worksheets(k), Worksheet)
          Hoja.Select()
          j = 10
          a = 10
          For i As Integer = 1 To CInt(Hoja.Range("I6").Value) 'alumnos
            Me.pbAvance.Value += 1
            nro = CInt(Hoja.Range("AC" & j).Value)
            b = 8
            For m As Integer = 0 To CInt(Hoja.Range("AC71").Value) - 1 'capacidades
              If CInt(Hoja.Range(Hoja.Cells(a, b), Hoja.Cells(a, b)).Value) > 0 Then
                prom = CDbl(Hoja.Range(Hoja.Cells(a, b), Hoja.Cells(a, b)).Value)
                nota = obj.LeerNota(New NotaCapacidad(New Unidad(CInt(Hoja.Range("AC8").Value), "", True, _
                      New PeriodoAcademico(mOPeriodoActual.Codigo), _
                      New DocenteCarga(CInt(Hoja.Range("AC2").Value))), _
                      New Capacidad(CInt(Hoja.Range(Hoja.Cells(71, b), Hoja.Cells(71, b)).Value)), _
                      New Matricula(nro)))
                If nota Is Nothing Then
                  If prom >= 6 And prom <= 20 Then
                    obj.Registrar(New NotaCapacidad(0, prom, Now, True, New Matricula(nro), _
                                New PeriodoAcademico(mOPeriodoActual.Codigo), _
                                New Personal(mOUsuario.Persona.Codigo), _
                                New Capacidad(CInt(Hoja.Range(Hoja.Cells(71, b), Hoja.Cells(71, b)).Value)), _
                                New Unidad(CInt(Hoja.Range("AC8").Value), "", False, Nothing, _
                                New DocenteCarga(CInt(Hoja.Range("AC2").Value)))))
                  End If
                Else
                  If prom <> nota.Promedio Then
                    If prom >= 6 And prom <= 20 Then
                      obj.RegistrarNuevaNota(New NotaCapacidad(nota.Codigo, prom, Now, _
                                 Nothing, Nothing, Nothing, _
                                New Personal(mOUsuario.Persona.Codigo), Nothing, Nothing), _
                                New Personal(mOUsuario.Persona.Codigo))
                    End If
                  End If
                End If
              End If
              b += 1
            Next
            a += 1
            j += 1
          Next
          'If Me.pbAvance.Value > 40 Then
          '  Me.pbAvance.Value -= 10
          'End If
        Next
        Me.pbAvance.Maximum = 100
        m_excel.ScreenUpdating = True
        Me.pbAvance.Value = Me.pbAvance.Maximum
        MessageBox.Show("Notas guardadas con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
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