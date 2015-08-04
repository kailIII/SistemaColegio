Imports Microsoft.Office.Interop.Excel

Public Class frmImportarPromediosArea

  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing
  Private Const clave As String = "CETI"

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub frmImportarRegInd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    MostrarImagenes()
  End Sub

  Public Sub MostrarImagenes()
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnImportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\excel.bmp")
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
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing
    Dim proc As Process()
    Dim rn As RNMatricula
    Dim pr As PromedioAnioArea
    Dim ca As CargaAcademica
    Dim celdaMat As Range = Nothing
    Dim celdaCarga As Range = Nothing
    Dim celdaProm As Range = Nothing
    Dim matricula As Integer

    Try
      m_excel = New Microsoft.Office.Interop.Excel.Application
      Libro = m_excel.Workbooks.Open(Me.txtRuta.Text)
      Hoja = CType(Libro.Worksheets(1), Worksheet)
      Hoja.Select()

      m_excel.ScreenUpdating = False
      m_excel.DisplayAlerts = False
      celdaCarga = Hoja.Range("D9")

      rn = New RNMatricula
      pr = New PromedioAnioArea
      ca = New CargaAcademica

      pr.Matricula = New Matricula
      pr.Personal = New Personal(mOUsuario.Persona.Codigo)
      pr.Anio = moAnioActual
      pr.Vigencia = True
      While celdaCarga.Value IsNot Nothing AndAlso celdaCarga.Value.ToString.Length > 0
        If celdaCarga.Value.ToString = "Prom." Then
          ca.Codigo = CInt(celdaCarga.Offset(-2, 0).Value)
          celdaMat = Hoja.Range("A10")
          celdaProm = celdaCarga.Offset(1, 0)
          While celdaMat.Value IsNot Nothing AndAlso Integer.TryParse(celdaMat.Value.ToString, matricula) = True
            matricula = CInt(celdaMat.Value)
            If celdaProm.Value IsNot Nothing AndAlso celdaProm.Value.ToString.Length > 0 Then
              pr.Matricula.Numero = matricula
              pr.Letra = celdaProm.Value.ToString

              rn.RegistrarPromedioAreaAnio(pr, ca)
            End If
            celdaMat = celdaMat.Offset(1, 0)
            celdaProm = celdaProm.Offset(1, 0)
          End While
        End If
        celdaCarga = celdaCarga.Offset(0, 1)
      End While

      m_excel.ScreenUpdating = True
      Me.pbAvance.Value = Me.pbAvance.Maximum
      MessageBox.Show("Notas importadas con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
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


End Class