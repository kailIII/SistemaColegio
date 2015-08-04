Imports Microsoft.Office.Interop.Excel

Public Class frmReporteNotasInvestigacionPlanLector

  Private Shared frm As frmReporteNotasInvestigacionPlanLector
  Private sfdDialogo As SaveFileDialog
  Private Const clave As String = "CETI"

  'Private mDialogoGuardar As SaveFileDialog

  Private Sub frmReporteNotasPlanLector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\excel.bmp")

    Me.txtAnio.Text = moAnioActual.Anio
    Me.CargarNiveles()
    Me.CargarCoordinadorProgLectura()

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

  Public Sub CargarCoordinadorProgLectura()
    Dim List As List(Of Persona)
    Dim rnCoordinadorPL As New RNProgramacionLectura

    List = rnCoordinadorPL.ListarCoordinadorProgLectura()
    Me.cboCoordinadorPL.DisplayMember = "NombreCompleto"
    Me.cboCoordinadorPL.ValueMember = "NombreCompleto"
    Me.cboCoordinadorPL.DataSource = List
    'Me.cboNivel.SelectedIndex = -1
    List = Nothing
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
    frmReporteNotasInvestigacionPlanLector.frm = New frmReporteNotasInvestigacionPlanLector
    frm.sfdDialogo = wDialogo
    frmReporteNotasInvestigacionPlanLector.frm.ShowDialog()
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Dim rnMat As New RNMatricula
    Dim lm As List(Of Matricula)
    Dim sec As Seccion = Nothing
    Dim Libro As Workbook = Nothing
    Dim Hoja As Worksheet = Nothing
    Dim excel As Application = Nothing
    Dim proc As Process()

    Dim ruta As String = "", pos As Integer, sw As Integer = 0

    Try
      If Me.Validar Then

        Me.sfdDialogo.Filter = "Hoja de cálculo 2007(*.xlsx)|*.xlsx"
        Me.sfdDialogo.FileName = "Libreta_Investigacion_PlanLector " & moAnioActual.Anio & "-" & Me.cboNivel.Text & " -  " & Me.cboSeccion.Text & ".xls"
        excel = New Application
        excel.ScreenUpdating = False
        excel.DisplayAlerts = False

        Libro = modExcel.AbrirPlantilla(excel, Me.sfdDialogo, AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Plantilla PL-Investigacion.xlsx")
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
            lm = rnMat.ListarConsolidado(sec, moAnioActual.Anio)

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

  Private Sub ExportarAlumnoInvestigacion(ByVal sec As Seccion, ByVal mat As Matricula, ByVal celda As Range)
    Dim rnNL As New RNNotaInvestigacion
    Dim lNot As List(Of NotaInvestigacion) = Nothing
    Dim ptjeTotal As Integer = 0
    'a29
    lNot = rnNL.ListarNotasNroMatricula(mat.Numero)

    celda.Value = "INVESTIGACIÓN - " & moAnioActual.Anio

        celda = celda.Offset(2, 0)
        Dim i = 1
        Dim trimestre = ""
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

  Private Sub ExportarAlumnoPlanLector(ByVal sec As Seccion, ByVal mat As Matricula, ByVal celda As Range)
    Dim rnNL As New RNNotaLectura
    Dim lNot As List(Of NotaLectura) = Nothing
    Dim ptjeTotal As Integer = 0, i As Integer, coment As String

    lNot = rnNL.ListarNotasLecturaNroMatricula(mat.Numero)
    celda.Offset(6, 0).Offset(0, -2).Value = "PLAN LECTOR - " & moAnioActual.Anio

    celda.Offset(3, 0).Value = mat.NombreAlumno
    celda.Offset(4, 0).Value = mat.NroOrden

    celda = celda.Offset(8, -2)
    i = 1
    For Each N As NotaLectura In lNot
      coment = ""
      celda.Offset(0, 1).Value = N.ProgLectura.Libro.Titulo
      celda.Offset(0, 0).Value = i
      celda.Offset(0, 8).Value = N.NotaRecuperacion

      If N.NotaRecuperacion = "" Then
        If N.Nota = "C" Then
          coment = "*"
        End If
        If N.Nota = "NP" Then
          coment = "**"
        End If
      End If

      celda.Offset(0, 7).Value = N.Nota & coment

      celda = celda.Offset(1, 0)
      i = i + 1
    Next
  End Sub


  Private Sub LlenarHojasExcel(ByVal lm As List(Of Matricula), ByVal Hoja As Worksheet,
                               ByVal Libro As Workbook, ByVal sec As Seccion)

    Dim nombreHoja As String = "", i As Integer=0, av As Integer
    Dim celda As Range
    Dim rnInv As New RNInvestigacion
    Dim rnSeccion As New RNSeccion, rnNivel As New RNNivel
    Dim coordinador = Me.cboCoordinadorPL.Text
    Dim responsableInv = rnInv.ListarResponsableInvestigacion(sec, moAnioActual.Anio)
    Dim tutor = rnSeccion.NombreTutor(sec, moAnioActual.Anio)
    Dim director = rnNivel.ListarDirectorNivel(CInt(Me.cboNivel.SelectedValue))

    For Each A As Matricula In lm
      If i = 0 Then

        Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
        Hoja.Select()
        Hoja.Copy(, Hoja)
        Hoja.Unprotect(clave)
        celda = Hoja.Range("C6")
        Hoja.Range("G37").Value = responsableInv
        Hoja.Range("H10").Value = Me.cboNivel.Text & " - " & sec.Numero & "° " & sec.Letra
        Hoja.Range("D43").Value = "Director de Proyecto " & sec.NombreNivel
        Hoja.Range("A37").Value = coordinador
        Hoja.Range("D42").Value = director.NombreCompleto
        celda.Value = tutor
        nombreHoja = A.NroOrden.ToString
        ExportarAlumnoPlanLector(sec, A, celda)

        celda = Hoja.Range("A29")
        ExportarAlumnoInvestigacion(sec, A, celda)
        i = 1
      Else
        i = 0

        celda = Hoja.Range("M6")
        celda.Value = tutor
        ExportarAlumnoPlanLector(sec, A, celda)
        celda = Hoja.Range("K29")
        ExportarAlumnoInvestigacion(sec, A, celda)
        nombreHoja &= " - " & A.NroOrden.ToString
        Hoja.Range("Q37").Value = responsableInv
        Hoja.Range("R10").Value = Me.cboNivel.Text & " - " & sec.Numero & "° " & sec.Letra
        Hoja.Range("K37").Value = coordinador
        Hoja.Range("N42").Value = director.NombreCompleto
        Hoja.Range("N43").Value = "Director de Proyecto " & sec.NombreNivel
      End If


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
    'If cont = 1 Then
    Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
    Hoja.Select()
    Hoja.Delete()

    Hoja = CType(Libro.Worksheets(1), Worksheet)
    Hoja.Select()

    If Me.cboSeccion.SelectedIndex > -1 Then
      excel.ActiveWorkbook.SaveAs(Me.sfdDialogo.FileName, _
            Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
    End If
    'End If
  End Sub
  '

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
        If Me.cboCoordinadorPL.SelectedIndex > -1 Then
        Else
          MessageBox.Show("Elija coordinador de plan lector", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          bool = False
        End If
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