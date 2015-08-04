Imports Microsoft.Office.Interop.Excel

Public Class frmExportarPlanLector
  Private m_excel As Microsoft.Office.Interop.Excel.Application = Nothing
  Private Const clave As String = "CETI"

  Private Sub frmExportarPlanLector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\excel.bmp")

    Me.txtAnio.Text = moAnioActual.Anio
    CargarSeccion()
    CargarPresentaciones()
  End Sub

  Private Function CargarSeccion() As Boolean
    Dim obj As New RNSeccion
    Dim ls As List(Of Seccion)
    ls = obj.ListarSeccionTutorPlanLectorExportar(New Seccion(moAnioActual, New Grado(), Nothing, New Docente(mOUsuario.Persona.Codigo)))
    If ls.Count > 0 Then
      cboSeccion.DisplayMember = "NivelNumeroLetra"
      cboSeccion.ValueMember = "NivelNumeroLetra"
      cboSeccion.DataSource = ls
      Return True
    Else
      MessageBox.Show("El Plan Lector sólo se aplica en el proyecto LASER!!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Return False
      'Me.Close()
    End If
  End Function

  Private Sub CargarPresentaciones()
    Dim obj As New RNPresentacion
    Dim lpres As List(Of Presentacion)

    If cboSeccion.SelectedIndex > -1 Then
      lpres = obj.ListarPresVigentes(moAnioActual.Anio)

      lpres.Insert(0, New Presentacion())

      cboPresentacion.DisplayMember = "NombrePresentacion"
      cboPresentacion.ValueMember = "Codigo"

      cboPresentacion.DataSource = lpres

      'Else
      '    btnListar.Enabled = False

    End If
  End Sub

  Public Sub Gestionar()

    If CargarSeccion() Then
      Me.ShowDialog()
    End If

  End Sub

  Private Sub txtAnio_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAnio.Enter
    Me.cboPresentacion.Focus()
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Dim lNot As List(Of NotaLectura) = Nothing
    Dim lpres As New List(Of Presentacion)
    Dim objSec As New RNSeccion
    Dim obj As RNPresentacion = Nothing
    Dim rnNL As New RNNotaLectura
    Dim sec As Seccion = Nothing
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet = Nothing
    Dim proc As Process()

    Dim k As Integer

    Dim pos As Integer
    Dim sw As Integer = 0
    Dim ruta As String = ""

    Dim cont As Integer = 0

    Try
      obj = New RNPresentacion

      m_excel = New Microsoft.Office.Interop.Excel.Application
      Libro = Nothing
      Hoja = Nothing

      If cboPresentacion.SelectedIndex = 0 Then
        lpres = obj.ListarPresVigentes(moAnioActual.anio)
      Else
        lpres.Insert(0, CType(cboPresentacion.SelectedItem, Presentacion))
      End If

      Me.sfdArchivos.Filter = "Archivos (*.xls)|*.xls"
      If Me.cboPresentacion.SelectedIndex = 0 Then
        Me.sfdArchivos.FileName = "Guardar Todos"
      Else
        Me.sfdArchivos.FileName = "Plan Lector_" & moAnioActual.anio.Trim & "_Pres " & cboPresentacion.Text & "_" & cboSeccion.Text & ".xls"
      End If

      If Me.sfdArchivos.ShowDialog = System.Windows.Forms.DialogResult.OK Then
        If Me.cboPresentacion.SelectedIndex = 0 Then
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

      If sw = 1 And cboSeccion.SelectedIndex > -1 Then
        Libro = m_excel.Workbooks.Add(AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Registro_PlanLector.xls")
        m_excel.ScreenUpdating = False
        m_excel.DisplayAlerts = False

        For Each p As Presentacion In lpres
          sec = CType(cboSeccion.SelectedItem, Seccion)
          lNot = rnNL.ListarAlumnosPresentacion(sec, p, moAnioActual.anio)

          If lNot.Count > 0 Then
            cont = 1
            Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
            Hoja.Select()
            Hoja.Copy(, Hoja)
            k = 10

            Hoja.Unprotect(clave)
            '''''''''''''Guardar Datos del docente y curso'''''''''''''
            Hoja.Range("B3").Value = "Plan Lector - " & moAnioActual.anio
            Hoja.Range("N1").Value = mOUsuario.Codigo
            Hoja.Range("N2").Value = p.Codigo
            Hoja.Range("N3").Value = moAnioActual.anio
            Hoja.Range("D5").Value = p.Numero
            Hoja.Range("H5").Value = FormatDateTime(p.Inicio, DateFormat.ShortDate)
            Hoja.Range("J5").Value = FormatDateTime(p.Fin, DateFormat.ShortDate)

            Hoja.Range("D6").Value = objSec.NombreTutor(sec, moAnioActual.anio)

            Hoja.Range("J6").Value = sec.Numero & "° " & sec.Letra & " " & sec.NombreNivel

            For Each N As NotaLectura In lNot
              ''Mostrar alumnos y notas de lectura
              Hoja.Range("B" & k).Value = N.NroOrden
              Hoja.Range("C" & k).Value = N.NombreCompleto
              Hoja.Range("I" & k).Value = N.Libro
              Hoja.Range("K" & k).Value = N.Nota
              Hoja.Range("M" & k).Value = N.Codigo

              Hoja.Range("N" & k).Value = N.Matricula.Numero
              Hoja.Range("O" & k).Value = N.ProgLectura.Codigo
              k += 1
            Next
            Hoja.Select()
            Hoja.Name = "Pres " & p.Numero
            m_excel.Run("OcultarFilaVacia")
            Me.pbAvance.Value += 5
            m_excel.ScreenUpdating = True
            Hoja.Protect(clave)
          End If

        Next

        'Eliminar la ultima hoja
        If cboPresentacion.Items.Count > 0 Then

          If cont = 1 Then

            Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
            Hoja.Select()
            Hoja.Delete()

            Hoja = CType(Libro.Worksheets(1), Worksheet)
            Hoja.Select()
            If Me.cboPresentacion.SelectedIndex > 0 Then
              m_excel.ActiveWorkbook.SaveAs(Me.sfdArchivos.FileName, _
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
            ElseIf Me.cboPresentacion.SelectedIndex = 0 Then
              m_excel.ActiveWorkbook.SaveAs(ruta & "Plan Lector_" & moAnioActual.anio.Trim & "_" & cboPresentacion.Text & "_" & cboSeccion.Text & ".xls", _
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
            End If

            Me.pbAvance.Value = Me.pbAvance.Maximum

            MessageBox.Show("Archivo exportado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          Else
            MessageBox.Show("La presentación no tiene alumnos asignados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
          End If

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

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

End Class