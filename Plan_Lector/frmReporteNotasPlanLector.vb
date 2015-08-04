Imports Microsoft.Office.Interop.Excel

Public Class frmReporteNotasPlanLector

  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing
  Private Const clave As String = "CETI"

  Private mDialogoGuardar As SaveFileDialog

  Public WriteOnly Property DialogoGuardar() As SaveFileDialog
    Set(ByVal value As SaveFileDialog)
      Me.mDialogoGuardar = value
    End Set
  End Property

  Private Sub frmReporteNotasPlanLector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\excel.bmp")

    Me.txtAnio.Text = moAnioActual.Anio
    Me.CargarNiveles()
    Me.CargarPresentaciones()
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

  Private Sub CargarPresentaciones()
    Dim obj As New RNPresentacion
    Dim lpres As List(Of Presentacion)

    lpres = obj.ListarPresVigentes(moAnioActual.Anio)
    obj = Nothing
    Me.cboPresentacion.DisplayMember = "NombrePresentacion"
    Me.cboPresentacion.ValueMember = "Codigo"
    Me.cboPresentacion.DataSource = lpres
    Me.cboPresentacion.SelectedIndex = -1
  End Sub

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Dim objMat As New RNMatricula
    Dim lm As List(Of Matricula)

    Dim obj As RNPresentacion = Nothing
    Dim objSec As New RNSeccion
    Dim sec As Seccion = Nothing
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing

    Dim proc As Process()

    Dim pos As Integer
    Dim sw As Integer = 0
    Dim ruta As String = ""
    Dim tutor As String
    Dim coordinador As String
    Dim nombreHoja As String = ""

    Dim cont As Integer = 0
    Dim i As Integer
    Dim celda As Range
    Dim av As Integer

    Try
      obj = New RNPresentacion

      Me.mDialogoGuardar.Filter = "Archivos (*.xls)|*.xls"
      If Me.cboPresentacion.SelectedIndex > -1 Then
        Me.mDialogoGuardar.FileName = "Libreta PL_" & moAnioActual.Anio.Trim & "_" & _
              Me.cboNivel.Text & " - " & Me.cboSeccion.Text & ".xls"
      End If

      If Me.mDialogoGuardar.ShowDialog = System.Windows.Forms.DialogResult.OK Then
        ruta = Me.mDialogoGuardar.FileName
        For g As Integer = 0 To ruta.Length - 1
          If ruta.Chars(g) = "\" Then
            pos = g
          End If
        Next
        ruta = Microsoft.VisualBasic.Left(ruta, pos + 1)
        sw = 1
      End If

      If sw = 1 And Me.cboSeccion.SelectedIndex > -1 Then
        sec = CType(Me.cboSeccion.SelectedItem, Seccion)
        lm = objMat.ListarConsolidado(sec, moAnioActual.Anio)

        If lm.Count > 0 Then
          av = CInt(Math.Floor(100 / lm.Count))
          m_excel = New Microsoft.Office.Interop.Excel.Application
          Libro = Nothing
          Hoja = Nothing

          m_excel.ScreenUpdating = False
          m_excel.DisplayAlerts = False

          Select Case DirectCast(Me.cboNivel.SelectedItem, Nivel).Orden
            Case 2
              Libro = m_excel.Workbooks.Add(AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Libreta_Plan _Lector_Primaria.xls")
            Case 3
              Libro = m_excel.Workbooks.Add(AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Libreta_Plan _Lector_Secundaria.xls")
          End Select

          cont = 1
          tutor = objSec.NombreTutor(sec, moAnioActual.Anio)
          coordinador = mOUsuario.Persona.NombreCompleto
          For Each A As Matricula In lm
            If i = 0 Then
              Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
              Hoja.Select()
              Hoja.Copy(, Hoja)
              Hoja.Unprotect(clave)

              celda = Hoja.Range("A3")
              nombreHoja = A.NroOrden.ToString
              i = 1
            Else
              i = 0
              celda = Hoja.Range("K3")
              nombreHoja &= " - " & A.NroOrden.ToString
            End If
            ExportarAlumno(sec, A, celda, tutor, coordinador)

            Hoja.Select()
            If i = 0 Then
              Hoja.Name = nombreHoja
              Hoja.Protect(clave)
            End If
            Me.pbAvance.Value += av
          Next
          If i = 1 Then
            Hoja.Name = nombreHoja
            Hoja.Protect(clave)
          End If

          'Eliminar la ultima hoja
          If cont = 1 Then
            Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
            Hoja.Select()
            Hoja.Delete()

            Hoja = CType(Libro.Worksheets(1), Worksheet)
            Hoja.Select()
            If Me.cboSeccion.SelectedIndex > -1 Then
              m_excel.ActiveWorkbook.SaveAs(Me.mDialogoGuardar.FileName, _
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
            End If

            Me.pbAvance.Value = Me.pbAvance.Maximum

            MessageBox.Show("Archivo exportado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          End If

          m_excel.ScreenUpdating = True
        End If

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

    Me.pbAvance.Value = 0
  End Sub

  Private Sub ExportarAlumno(ByVal sec As Seccion, ByVal mat As Matricula, ByVal celda As Range, ByVal tutor As String, ByVal coordinador As String)
    Dim rnNL As New RNNotaLectura
    Dim lNot As List(Of NotaLectura) = Nothing
    Dim coment As String
    Dim ptjeTotal As Integer = 0
    Dim celdaCalif As Range
    Dim calif As String

    lNot = rnNL.ListarNotasLibros_NroMat(mat.Numero)

    celda.Value = "Plan Lector - " & moAnioActual.Anio
    celda.Offset(3, 0).Offset(0, 1).Value = tutor

    celda.Offset(6, 0).Offset(0, 1).Value = mat.NombreAlumno
    celda.Offset(7, 0).Offset(0, 1).Value = mat.NroOrden
    celda.Offset(7, 0).Offset(0, 1).Offset(0, 2).Value = Me.cboNivel.Text & " - " & sec.Numero & "° " & sec.Letra

    celda.Offset(33, 0).Value = coordinador

    celdaCalif = celda.Offset(26, 0).Offset(0, 6)
    celda = celda.Offset(10, 0)
    For Each N As NotaLectura In lNot
      coment = ""
      celda.Value = N.ProgLectura.Presentacion.Numero
      celda.Offset(0, 1).Value = N.Libro

      Select Case N.Nota
        Case "AD"
          ptjeTotal += 4
        Case "A"
          ptjeTotal += 3
        Case "B"
          ptjeTotal += 2
        Case "C"
          coment = "*"
          ptjeTotal += 1
        Case "D"
          coment = "*"
        Case "NP"
          coment = "**"
      End Select
      celda.Offset(0, 8).Value = N.Nota & coment
      celda = celda.Offset(1, 0)
    Next
    If ptjeTotal >= 28 Then
      calif = "EXCELENTE LECTOR"
    ElseIf ptjeTotal >= 19 Then
      calif = "BUEN LECTOR"
    ElseIf ptjeTotal >= 12 Then
      calif = "REGULAR LECTOR"
    ElseIf ptjeTotal >= 9 Then
      calif = "DEFICIENTE LECTOR"
    Else
      calif = "MUY DEFICIENTE LECTOR"
    End If
    celdaCalif.Value = calif
  End Sub

  Private Sub cboSeccion_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSeccion.Enter
    Me.CargarSeccion()
  End Sub

  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNivel.SelectedIndexChanged
    Me.cboSeccion.DataSource = Nothing
    Me.cboSeccion.SelectedIndex = -1
  End Sub

End Class