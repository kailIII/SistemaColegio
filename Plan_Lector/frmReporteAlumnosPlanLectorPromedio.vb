Imports Microsoft.Office.Interop.Excel

Public Class frmReporteAlumnosPlanLectorPromedio

  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing
  Private Const clave As String = "ceti"

  Private Sub frmReporteNotasPlanLector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\excel.bmp")

    Me.txtAnio.Text = moAnioActual.anio
    Me.CargarPresentaciones()
    Me.CargarNiveles()
  End Sub

  Public Sub CargarNiveles()
    Dim ListNa As List(Of Nivel)
    Dim objNa As New RNNivel

    ListNa = objNa.Listar()
    objNa = Nothing
    Me.cboNivel.DisplayMember = "nombre"
    Me.cboNivel.ValueMember = "codigo"
    Me.cboNivel.DataSource = ListNa
    ListNa = Nothing
    Me.cboSeccion.SelectedIndex = -1
  End Sub

  Private Sub cboNivel_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNivel.Leave
    Me.ListarSecciones()
  End Sub

  Public Sub ListarSecciones()
    Dim ListSec As List(Of Seccion)
    Dim objS As New RNSeccion

    If CType(Me.cboNivel.SelectedItem, Nivel) IsNot Nothing Then
      ListSec = objS.Leer_NivelAcad(moAnioActual, DirectCast(cboNivel.SelectedItem, Nivel), 1)
      ListSec.Insert(0, New Seccion)
      cboSeccion.DisplayMember = "numeroletra"
      cboSeccion.ValueMember = "codigoG"
      cboSeccion.DataSource = ListSec
      ListSec = Nothing
    Else
      Me.cboSeccion.DataSource = Nothing
      Me.cboSeccion.SelectedIndex = -1
    End If
  End Sub

  Private Sub CargarPresentaciones()
    Dim obj As New RNPresentacion
    Dim lpres As List(Of Presentacion)

    lpres = obj.ListarPresVigentes(moAnioActual.Anio)
    obj = Nothing
    Me.cboPresentacion.DisplayMember = "NombrePresentacion"
    Me.cboPresentacion.ValueMember = "Codigo"
    Me.cboPresentacion.DataSource = lpres
  End Sub

  Public Sub Gestionar()

    Me.ShowDialog()
    
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Dim rn As RNSeccion
    Dim ln As List(Of NotaLectura)
    Dim NotaCapacidad As String = ""

    If cboSeccion.SelectedItem IsNot Nothing AndAlso cboPresentacion.SelectedItem IsNot Nothing AndAlso cboCriterio.SelectedIndex > -1 Then
      Select Case cboCriterio.SelectedIndex
        Case 0
          NotaCapacidad = "T"
        Case 1
          NotaCapacidad = "AD"
        Case 2
          NotaCapacidad = "A"
        Case 3
          NotaCapacidad = "B"
        Case 4
          NotaCapacidad = "P"
        Case 5
          NotaCapacidad = "C"
        Case 6
          NotaCapacidad = "NP"
      End Select
      rn = New RNSeccion
      If cboSeccion.SelectedIndex > 0 Then
        ln = rn.ListarAlumnosPlanLectorPromedio(DirectCast(cboSeccion.SelectedItem, Seccion), DirectCast(cboPresentacion.SelectedItem, Presentacion), NotaCapacidad)
        Me.ExportarDatosSeccion(ln)
      Else
        ln = rn.ListarAlumnosPlanLectorPromedio(DirectCast(Me.cboNivel.SelectedItem, Nivel), DirectCast(cboPresentacion.SelectedItem, Presentacion), NotaCapacidad)
        Me.ExportarDatosTodos(ln)
      End If
    ElseIf cboSeccion.SelectedItem IsNot Nothing Then
      MessageBox.Show("Debe seleccionar la sección", Me.Text, MessageBoxButtons.OK)
      cboSeccion.Focus()
    ElseIf cboPresentacion.SelectedItem IsNot Nothing Then
      MessageBox.Show("Debe seleccionar el número de presentación", Me.Text, MessageBoxButtons.OK)
      cboPresentacion.Focus()
    ElseIf cboCriterio.SelectedIndex > -1 Then
      MessageBox.Show("¿Qué condición de alumnos quiere ver?", Me.Text, MessageBoxButtons.OK)
      cboCriterio.Focus()
    End If
  End Sub

  Private Sub ExportarDatosSeccion(ByVal ln As List(Of NotaLectura))
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing
    Dim proc As Process()
    Dim celda As Range
    Dim avance As Integer

    Try
      m_excel = New Microsoft.Office.Interop.Excel.Application
      Libro = Nothing
      Hoja = Nothing

      Me.sfdArchivos.Filter = "Archivos (*.xls)|*.xls"
      Me.sfdArchivos.FileName = "Listado Alumnos Promedio " & Me.cboCriterio.Text & " - " & moAnioActual.Anio.Trim & _
              " Presentacion " & Me.cboPresentacion.Text & "_" & Me.cboNivel.Text & "-" & cboSeccion.Text & ".xls"
      If Me.sfdArchivos.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
        Return
      End If

      Libro = m_excel.Workbooks.Open(AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Alumnos-PlanLector-Promedio.xls")

      m_excel.ScreenUpdating = False
      m_excel.DisplayAlerts = False

      Hoja = DirectCast(Libro.Worksheets.Item("PRESENTACION"), Worksheet)
      Hoja.Unprotect(clave)
      Hoja.Range("G3").Value = "Plan Lector - Listado de alumnos y promedios - " & moAnioActual.Anio
      Hoja.Range("D5").Value = DirectCast(cboPresentacion.SelectedItem, Presentacion).Numero

      Hoja.Range("J5").Value = DateAndTime.Now.ToShortDateString
      With DirectCast(cboSeccion.SelectedItem, Seccion)
        Hoja.Range("D6").Value = .Grado.Nivel.Siglas & " - " & .NumeroLetra
      End With
      celda = DirectCast(Libro.ActiveSheet, Worksheet).Range("B10")
      If ln.Count > 0 Then
        avance = 100 \ ln.Count
        For Each N As NotaLectura In ln
          celda.Value = N.NroOrden
          celda.Offset(0, 1).Value = N.Matricula.Alumno.NombreCompleto
          celda.Offset(0, 7).Value = N.Libro
          celda.Offset(0, 9).Value = N.Nota
          celda.Offset(0, 10).Value = N.NotaRecuperacion
          celda = celda.Offset(1, 0)
          Me.pbAvance.Value += avance
        Next
      Else
        celda.Value = "No se encontraron alumnos registrados"
      End If
      Me.pbAvance.Value = Me.pbAvance.Maximum
      Hoja.Protect(clave)

      m_excel.ActiveWorkbook.SaveAs(Me.sfdArchivos.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)

      MessageBox.Show("Archivo exportado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      m_excel.ScreenUpdating = True
      Me.pbAvance.Value = 0
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

  Private Sub ExportarDatosTodos(ByVal ln As List(Of NotaLectura))
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing
    Dim proc As Process()
    Dim celda As Range
    Dim avance As Integer

    Try
      m_excel = New Microsoft.Office.Interop.Excel.Application
      Libro = Nothing
      Hoja = Nothing

      Me.sfdArchivos.Filter = "Archivos (*.xls)|*.xls"
      Me.sfdArchivos.FileName = "Listado Alumnos Promedio " & Me.cboCriterio.Text & " " & moAnioActual.Anio.Trim & _
           " Presentacion " & Me.cboPresentacion.Text & "_" & Me.cboNivel.Text & "-" & cboSeccion.Text & ".xls"
      If Me.sfdArchivos.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
        Return
      End If

      Libro = m_excel.Workbooks.Open(AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Todos Alumnos-PlanLector-Promedio.xls")

      m_excel.ScreenUpdating = False
      m_excel.DisplayAlerts = False

      Hoja = DirectCast(Libro.Worksheets.Item("PRESENTACION"), Worksheet)
      Hoja.Unprotect(clave)
      Hoja.Range("G3").Value = "Plan Lector - Listado de alumnos de todas las secciones |y promedios - " & moAnioActual.Anio
      Hoja.Range("E5").Value = DirectCast(cboPresentacion.SelectedItem, Presentacion).Numero
      Hoja.Range("K5").Value = DateAndTime.Now.ToShortDateString

      With DirectCast(cboSeccion.SelectedItem, Seccion)
        If Me.cboSeccion.SelectedIndex > 0 Then
          Hoja.Range("D6").Value = .Grado.Nivel.Siglas & " - " & .NumeroLetra
        Else
          Hoja.Range("D6").Value = Me.cboNivel.Text & "-" & Me.cboSeccion.Text
        End If
      End With
      celda = DirectCast(Libro.ActiveSheet, Worksheet).Range("B9")
      If ln.Count > 0 Then
        avance = 100 \ ln.Count
        For Each N As NotaLectura In ln
          celda.Value = N.NroOrden
          celda.Offset(0, 1).Value = N.Matricula.Grado.Nivel.Siglas & " - " & N.Matricula.Grado.Numero & " " & N.Matricula.Letra
          celda.Offset(0, 2).Value = N.Matricula.Alumno.NombreCompleto
          celda.Offset(0, 8).Value = N.Libro
          celda.Offset(0, 10).Value = N.Nota
          celda.Offset(0, 11).Value = N.NotaRecuperacion
          celda = celda.Offset(1, 0)
          Me.pbAvance.Value += avance
        Next
      Else
        celda.Value = "No se encontraron alumnos registrados"
      End If
      Me.pbAvance.Value = Me.pbAvance.Maximum
      Hoja.Protect(clave)

      m_excel.ActiveWorkbook.SaveAs(Me.sfdArchivos.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)

      MessageBox.Show("Archivo exportado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      m_excel.ScreenUpdating = True
      Me.pbAvance.Value = 0
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

End Class