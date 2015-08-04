Imports Microsoft.Office.Interop.Excel

Public Class frmReporteNotasInvestigacion

  Private Shared frm As frmReporteNotasInvestigacion
  Private sfdDialogo As SaveFileDialog
  Private Const clave As String = "CETI"

  Private Sub frmReporteNotasInvestigacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\excel.bmp")

    Me.txtAnio.Text = moAnioActual.Anio
    Me.CargarNiveles()

  End Sub

  Public Sub CargarNiveles()
    Dim ListNa As List(Of Nivel)
    Dim objNa As New RNNivel

    ListNa = objNa.Listar()
    Me.cboNivel.DisplayMember = "nombre"
    Me.cboNivel.ValueMember = "codigo"
    Me.cboNivel.DataSource = ListNa
    Me.cboNivel.SelectedIndex = -1
    ListNa = Nothing
  End Sub

  Private Sub CargarSeccion()
    Dim obj As RNSeccion
    Dim ls As List(Of Seccion)

    If Me.cboNivel.SelectedIndex > -1 Then
      obj = New RNSeccion
      ls = obj.Leer_NivelAcad(moAnioActual, CType(cboNivel.SelectedItem, Nivel), 1)
      If ls.Count > 0 Then
        Me.cboSeccion.DisplayMember = "NumeroLetra"
        Me.cboSeccion.ValueMember = "NumeroLetra"
        Me.cboSeccion.DataSource = ls
      End If
    Else
      Me.cboSeccion.DataSource = Nothing
    End If

    Me.cboSeccion.SelectedIndex = -1
  End Sub

  Public Shared Sub Gestionar(ByVal wDialogo As SaveFileDialog)
    frmReporteNotasInvestigacion.frm = New frmReporteNotasInvestigacion
    frmReporteNotasInvestigacion.frm.sfdDialogo = wDialogo
    frmReporteNotasInvestigacion.frm.ShowDialog()
    
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Dim objMat As New RNMatricula
    Dim lm As List(Of Matricula)
    Dim sec As Seccion = Nothing
    Dim Libro As Workbook = Nothing, Hoja As Worksheet = Nothing
    Dim excel As Application = Nothing, proc As Process()

    Dim ruta As String = ""
    Dim pos As Integer, sw As Integer = 0

    Try
      If Me.Validar Then

        Me.sfdDialogo.Filter = "Hoja de cálculo 2007(*.xlsx)|*.xlsx"
        Me.sfdDialogo.FileName = "Libreta_Investigacion " & moAnioActual.Anio & "-" & Me.cboNivel.Text & " -  " & Me.cboSeccion.Text & ".xls"
        excel = New Application
        excel.ScreenUpdating = False
        excel.DisplayAlerts = False

        Libro = modExcel.AbrirPlantilla(excel, Me.sfdDialogo, AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\LibretaNotasInvestigacion.xlsx")
        If Libro IsNot Nothing Then
          ruta = Me.sfdDialogo.FileName
          For g As Integer = 0 To ruta.Length - 1
            If ruta.Chars(g) = "\" Then
              pos = g
            End If
          Next
          ruta = Microsoft.VisualBasic.Left(ruta, pos + 1)
          sw = 1

          If sw = 1 And Me.cboSeccion.SelectedIndex > -1 Then
            sec = CType(Me.cboSeccion.SelectedItem, Seccion)
            lm = objMat.ListarConsolidado(sec, moAnioActual.Anio)

            If lm.Count > 0 Then
              Me.LlenarHojasExcel(lm, Hoja, Libro, sec)
              Me.EliminarHoja(Libro, excel, Hoja)
              Me.pbAvance.Value = Me.pbAvance.Maximum
              MessageBox.Show("Archivo exportado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
              excel.ScreenUpdating = True
            End If

          End If
        End If

      End If
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Me.pbAvance.Value = 0
    Finally
      If Hoja IsNot Nothing Then
        System.Runtime.InteropServices.Marshal.ReleaseComObject(Hoja)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(Libro)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(excel)
      End If

      Hoja = Nothing
      Libro = Nothing
      excel = Nothing

      proc = Process.GetProcessesByName("EXCEL")
      For Each p As Process In proc
        p.Kill()
      Next
      proc = Nothing
    End Try

    Me.pbAvance.Value = 0
  End Sub

  Private Sub ExportarAlumno(ByVal sec As Seccion, ByVal mat As Matricula, ByVal celda As Range, ByVal tutor As String, ByVal responsableInv As String)
    Dim rnNL As New RNNotaInvestigacion
    Dim lNot As List(Of NotaInvestigacion) = Nothing
    Dim ptjeTotal As Integer = 0

    lNot = rnNL.ListarNotasNroMatricula(mat.Numero)

    celda.Value = "Investigación - " & moAnioActual.Anio
    celda.Offset(2, 0).Offset(0, 1).Value = tutor

    celda.Offset(5, 0).Offset(0, 1).Value = mat.NombreAlumno
    celda.Offset(6, 0).Offset(0, 1).Value = mat.NroOrden
    celda.Offset(6, 0).Offset(0, 1).Offset(0, 3).Value = Me.cboNivel.Text & " - " & sec.Numero & "° " & sec.Letra

    celda.Offset(21, 0).Value = responsableInv

        celda = celda.Offset(10, 0)
        Dim trimestre = ""
        Dim i = 1
        For Each N As NotaInvestigacion In lNot
            If i = 1 Then
                trimestre = "I T"
            Else
                If i = 2 Then
                    trimestre = "II T"
                Else
                    trimestre = "III T"
                End If
            End If

            celda.Offset(0, 0).Value = trimestre
            celda.Offset(0, 1).Value = N.AreaInvestigacion.Nombre
            celda.Offset(0, 8).Value = N.Nota
            celda = celda.Offset(1, 0)
            i = i + 1
        Next
  End Sub

  Private Sub LlenarHojasExcel(ByVal lm As List(Of Matricula), ByVal Hoja As Worksheet,
                               ByVal Libro As Workbook, ByVal sec As Seccion)

    Dim nombreHoja As String = ""
    Dim i As Integer, av As Integer
    Dim celda As Range
    Dim rnInv As New RNInvestigacion
    Dim rnSeccion As New RNSeccion, rnNivel As New RNNivel

    Dim responsableInv = rnInv.ListarResponsableInvestigacion(sec, moAnioActual.Anio)
    Dim tutor = rnSeccion.NombreTutor(sec, moAnioActual.Anio)
    Dim director = rnNivel.ListarDirectorNivel(CInt(Me.cboNivel.SelectedValue))

    For Each A As Matricula In lm
      If i = 0 Then
        Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
        Hoja.Select()
        Hoja.Copy(, Hoja)
        Hoja.Unprotect(clave)
        celda = Hoja.Range("A4")
        Hoja.Range("H25").Value = director.NombreCompleto
        Hoja.Range("H26").Value = "Director de Proyecto " & sec.NombreNivel
        nombreHoja = A.NroOrden.ToString
        i = 1
      Else
        i = 0
        celda = Hoja.Range("K4")
        Hoja.Range("R25").Value = director.NombreCompleto
        Hoja.Range("R26").Value = "Director de Proyecto " & sec.NombreNivel
        nombreHoja &= " - " & A.NroOrden.ToString
      End If
      ExportarAlumno(sec, A, celda, tutor, responsableInv)

      Hoja.Select()
      If i = 0 Then
        Hoja.Name = nombreHoja
        Hoja.Protect(clave)
      End If
      av = CInt(Math.Floor(100 / lm.Count))
      Me.pbAvance.Value += av
    Next
    If i = 1 Then
      Hoja.Name = nombreHoja
      Hoja.Protect(clave)
    End If


  End Sub

  Private Sub EliminarHoja(ByVal Libro As Workbook, ByVal excel As Application, ByVal Hoja As Worksheet)

    'Dim cont As Integer
    ' If cont = 1 Then
    Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
    Hoja.Select()
    Hoja.Delete()

    Hoja = CType(Libro.Worksheets(1), Worksheet)
    Hoja.Select()

    If Me.cboSeccion.SelectedIndex > -1 Then
      excel.ActiveWorkbook.SaveAs(Me.sfdDialogo.FileName, _
            Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
    End If
    ' End If
  End Sub

  Private Sub cboSeccion_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSeccion.Enter
    Me.CargarSeccion()
  End Sub

  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNivel.SelectedIndexChanged
    Me.cboSeccion.DataSource = Nothing
    Me.cboSeccion.SelectedIndex = -1
  End Sub

  Private Function Validar() As Boolean
    Dim bool = True
    If Me.cboNivel.SelectedIndex > -1 Then
      If Me.cboSeccion.SelectedIndex > -1 Then        
      Else
        MessageBox.Show("Elija Sección", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        bool = False
      End If
    Else
      MessageBox.Show("Elija Nivel", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      bool = False
    End If
    Return bool
  End Function
End Class