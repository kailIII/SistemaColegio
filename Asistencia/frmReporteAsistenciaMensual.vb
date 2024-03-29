﻿Imports Microsoft.Office.Interop.Excel

Public Class frmReporteAsistenciaMensual

  Private excel As Microsoft.Office.Interop.Excel.Application = Nothing
  Private Const clave As String = "CETI"
  Private NombreNivel As String = ""
  Private NombreHoja(99) As String

  Private Sub frmReporteAsistenciaMensual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\excel.bmp")

    Me.ListarAnios()
    Me.ListarNiveles()
    Me.LlenarMeses()
  End Sub

  Private Sub LlenarMeses()
    If cboAnio.SelectedIndex > -1 Then

      For i As Integer = 1 To 12
        cboMes.Items.Add(MonthName(i).ToUpper)
      Next
      cboMes.Text = MonthName(Now.Month)
    End If
  End Sub

  Private Sub ListarAnios()
    Dim obj As New RNAnioLectivo
    Dim la As List(Of AnioLectivo)

    la = obj.Listar
    If la.Count > 0 Then
      Me.cboAnio.DisplayMember = "anio"
      Me.cboAnio.ValueMember = "anio"
      Me.cboAnio.DataSource = la
    Else
      MessageBox.Show("Ingrese año lectivo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Me.Close()
    End If
  End Sub

  Public Sub ListarNiveles()
    Dim obj As New RNNivel
    Dim ln As List(Of Nivel)

    ln = obj.Listar
    If ln.Count > 0 Then
      ln.Insert(0, New Nivel(0, "Seleccionar todos", ""))
      Me.cboNivel.DisplayMember = "Nombre"
      Me.cboNivel.ValueMember = "Codigo"
      Me.cboNivel.DataSource = ln
    End If
  End Sub

  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboNivel.SelectedIndexChanged
    Dim objNivel As Nivel = Nothing

    If Me.cboNivel.SelectedIndex > -1 Then
      objNivel = CType(Me.cboNivel.SelectedItem, Nivel)
      ListarGrados(objNivel.Codigo)
      If Me.cboNivel.SelectedIndex = 0 Then
        Me.cboGrado.Enabled = False

        Me.cboGrado.DataSource = Nothing
        Me.cboSeccion.DataSource = Nothing
      Else
        Me.cboGrado.Enabled = True
      End If
      Me.cboSeccion.Enabled = False
    End If
  End Sub

  Public Sub ListarGrados(ByVal wCodigoModular As Integer)
    Dim obj As New RNGrado
    Dim lg As List(Of Grado)

    lg = obj.Listar(New Nivel(wCodigoModular, "", ""))
    If lg.Count > 0 Then
      lg.Insert(0, New Grado(0, 0, "Seleccionar todos", 0))
      Me.cboGrado.DisplayMember = "Nombre"
      Me.cboGrado.ValueMember = "Numero"
      Me.cboGrado.DataSource = lg
      Me.cboGrado.SelectedIndex = 0
    End If
  End Sub

  Private Sub cboGrado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrado.SelectedIndexChanged
    Dim objGrado As Grado

    If cboGrado.SelectedIndex > -1 Then
      objGrado = CType(Me.cboGrado.SelectedItem, Grado)
      ListarSecciones(objGrado.Codigo, CType(cboAnio.SelectedItem, AnioLectivo).Anio)
      If Me.cboGrado.SelectedIndex = 0 Then
        Me.cboSeccion.Enabled = False

        Me.cboSeccion.DataSource = Nothing
      Else
        Me.cboSeccion.Enabled = True
      End If
    End If
  End Sub
  Public Sub ListarSecciones(ByVal wCodigoGrado As Integer, ByVal wAnio As String)
    Dim obj As New RNSeccion
    Dim ls As List(Of Seccion)

    ls = obj.Listar2(New Seccion(New Grado(wCodigoGrado), wAnio, CChar("a"), New Docente(), "", 0, 0))
    If ls.Count > 0 Then
      ls.Insert(0, New Seccion(New AnioLectivo(), New Grado(), "S"))
      Me.cboSeccion.DisplayMember = "LetraCompleta"
      Me.cboSeccion.ValueMember = "Letra"
      Me.cboSeccion.DataSource = ls
      Me.cboSeccion.SelectedIndex = 0
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Dim lm As List(Of Asistencia) = Nothing

    Dim objMat As New RNMatricula
    Dim objRNSec As New RNSeccion
    Dim objRNNivel As New RNNivel

    Dim objAsist As New RNAsistencia
    Dim objSec As List(Of Seccion) = Nothing
    Dim objNivel As List(Of Nivel) = Nothing

    Dim S As Seccion = Nothing
    Dim nivel As Nivel = Nothing

    Dim grado As String = Nothing
    Dim letra As Char
    Dim NroSec As Integer

    Dim proc As Process()

    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim Hoja As Microsoft.Office.Interop.Excel.Worksheet
    Dim ruta As String = ""
    Dim pos As Integer
    Hoja = Nothing

    Dim sw As Integer = 0
    Dim sw2 As Integer = 0 ''para saber si hay alumnos

    Dim cont As Integer = 0
    Dim cantidadAlu(99) As Integer

    Dim x As Integer = 0
    Dim c As Integer
    Dim f As Integer
    Dim NroDias As Integer
    Dim fecha As Date
    Dim NombreDia As String = ""

    NroDias = Date.DaysInMonth(CInt(cboAnio.Text), cboMes.SelectedIndex + 1)
    If objMat.ListarMatriculas(CType(cboAnio.SelectedItem, AnioLectivo)) > 0 Then
      Me.btnExportar.Enabled = False
      Try

        objNivel = objRNNivel.Listar()
        excel = New Microsoft.Office.Interop.Excel.Application
        Libro = Nothing
        Hoja = Nothing

        If Me.cboNivel.SelectedIndex = 0 Then
          grado = ""
          letra = CChar("")
          CType(Me.cboNivel.SelectedItem, Nivel).Codigo = 0
        Else
          If Me.cboGrado.SelectedIndex = 0 Then
            grado = ""
          Else
            grado = Me.cboGrado.Text.Trim
          End If
        End If


        Me.sfdArchivos.Filter = "Archivos (*.xls)|*.xls"
        If Me.cboNivel.SelectedIndex = 0 Then
          Me.sfdArchivos.FileName = "Reporte Asistencia_" & cboAnio.Text & "-" & cboMes.Text & ".xls"
        ElseIf cboGrado.SelectedIndex = 0 Then
          Me.sfdArchivos.FileName = "Reporte Asistencia_" & cboAnio.Text & "-" & cboMes.Text & "_" & cboNivel.Text & ".xls"
        ElseIf cboSeccion.SelectedIndex = 0 Then
          Me.sfdArchivos.FileName = "Reporte Asistencia_" & cboAnio.Text & "-" & cboMes.Text & "_" & cboNivel.Text & "_" & cboGrado.SelectedValue.ToString & ".xls"
        ElseIf cboSeccion.SelectedIndex > 0 Then
          Me.sfdArchivos.FileName = "Reporte Asistencia_" & cboAnio.Text & "-" & cboMes.Text & "_" & cboNivel.Text & "_" & cboGrado.SelectedValue.ToString & "_" & cboSeccion.Text & ".xls"

        End If

        If Me.sfdArchivos.ShowDialog = System.Windows.Forms.DialogResult.OK Then
          ' If Me.cboNivel.SelectedIndex = 0 Then
          ruta = Me.sfdArchivos.FileName
          For g As Integer = 0 To ruta.Length - 1
            If ruta.Chars(g) = "\" Then
              pos = g
            End If
          Next
          ruta = Microsoft.VisualBasic.Left(ruta, pos + 1)
          'End If
          sw = 1
        End If
        If sw = 1 And cboNivel.SelectedIndex > -1 Then
          Me.pbAvance.Value = 5
          Libro = excel.Workbooks.Add(AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\ReporteAsistenciaMensual.xls")
          excel.ScreenUpdating = False
          excel.DisplayAlerts = False

          For Each nivel In objNivel

            If nivel.Codigo = CInt(cboNivel.SelectedValue) Or CInt(cboNivel.SelectedValue) = 0 Then
              If Me.cboSeccion.SelectedIndex = 0 Then
                NroSec = objRNSec.LeerNroSecciones(New Seccion(New Grado(0, 0, grado, New Nivel(nivel.Codigo, Me.cboNivel.Text.Trim, ""), "", "", "", ""), _
                                                               CType(cboAnio.SelectedItem, AnioLectivo).Anio, CChar(""), New Docente(), "", 0, 0))
                letra = CChar("")
              Else
                NroSec = 1
                letra = CChar(Me.cboSeccion.Text.Trim)
              End If
              objSec = objRNSec.LeerDatosSeccion(New Seccion(New Grado(0, 0, grado, New Nivel(nivel.Codigo, "", ""), "", "", _
                                                                      "", ""), CType(cboAnio.SelectedItem, AnioLectivo).Anio, letra, New Docente(), "", 0, 0))
              If NroSec > 0 Then
                NombreNivel = nivel.Nombre

                For Each S In objSec
                  c = 9
                  ' f = 11

                  If S.Grado.CodigoNivel = nivel.Codigo Then
                    cont = 1
                    Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
                    Hoja.Select()
                    Hoja.Copy(, Hoja)
                    Hoja.Unprotect(clave)


                    Hoja.Range("B3").Value = CType(cboAnio.SelectedItem, AnioLectivo).Anio
                    Hoja.Range("B6").Value = cboMes.Text

                    Hoja.Range("D7").Value = objRNSec.NombreTutor(S, CStr(cboAnio.SelectedValue))

                    Hoja.Range("H7").Value = nivel.Siglas & S.NivelNumeroLetra

                    x = 0
                    For dia As Integer = 1 To NroDias
                      f = 11

                      fecha = New Date(CInt(cboAnio.Text), cboMes.SelectedIndex + 1, dia)

                      NombreDia = InicialNombreDia(fecha.DayOfWeek)


                      lm = objAsist.Listar(New Seccion(CType(cboAnio.SelectedItem, AnioLectivo), New Grado(S.Grado.Codigo, S.Grado.Numero), S.Letra), _
                                           fecha)

                      If lm.Count > 0 Then

                        If NombreDia <> "XX" Then
                          Hoja.Cells(f - 1, c) = dia
                          Hoja.Cells(f - 2, c) = NombreDia

                          For Each N In lm
                            ''Mostrar alumnos y Asistencia
                            If x = 0 Then
                              Hoja.Range("B" & f).Value = N.NroOrden
                              Hoja.Range("C" & f).Value = N.NombreAlumno
                            End If

                            If N.Estado = "" Then
                              Hoja.Cells(f, c) = "A"
                            Else
                              Hoja.Cells(f, c) = N.Estado

                            End If

                            f += 1

                          Next
                          x = 1
                          c += 1

                        End If
                      End If

                    Next
                    Hoja.Select()
                    If Me.cboNivel.SelectedIndex = 0 Then
                      Hoja.Name = S.Grado.Numero & "º " & S.Letra & " (" & nivel.Nombre.Chars(0) & nivel.Nombre.Chars(1) & nivel.Nombre.Chars(2) & ")"
                    Else
                      Hoja.Name = S.Grado.Numero & "º " & S.Letra
                    End If
                    excel.Run("OcultarFilaVacia")
                    excel.Run("OcultarColumnaVacia")
                    excel.ScreenUpdating = True


                    Hoja.Protect(clave)

                  End If

                  Me.pbAvance.Value += 3

                Next

              End If
            End If
          Next

          If cont = 1 Then

            Hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
            Hoja.Select()
            Hoja.Delete()

            Hoja = CType(Libro.Worksheets(1), Worksheet)
            Hoja.Select()

            If Me.cboSeccion.SelectedIndex > 0 Then
              excel.ActiveWorkbook.SaveAs(ruta & "Reporte Asistencia- " & cboAnio.Text & "-" & cboMes.Text & "_" & NombreNivel & "_" & S.Grado.Numero & "_" & S.Letra & ".xls", _
                                     Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
            ElseIf cboGrado.SelectedIndex > 0 Then
              excel.ActiveWorkbook.SaveAs(ruta & "Reporte Asistencia- " & cboAnio.Text & "-" & cboMes.Text & "_" & NombreNivel & "_" & S.Grado.Numero & ".xls", _
                                     Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
            ElseIf Me.cboNivel.SelectedIndex > 0 Then
              excel.ActiveWorkbook.SaveAs(ruta & "Reporte Asistencia- " & cboAnio.Text & "-" & cboMes.Text & "_" & NombreNivel & ".xls", _
                                     Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
            Else
              excel.ActiveWorkbook.SaveAs(ruta & "Reporte Asistencia- " & cboAnio.Text & "-" & cboMes.Text & ".xls", _
                                     Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
            End If

            Me.pbAvance.Value = Me.pbAvance.Maximum

            MessageBox.Show("Archivo exportado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

          Else
            MessageBox.Show("Exportación fallida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
          End If

        End If

      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
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

      btnExportar.Enabled = True

    End If
  End Sub


  Private Function InicialNombreDia(ByVal nro As Integer) As String
    Dim cadena As String = "XX"

    Select Case nro
      Case 0
        cadena = "XX"
      Case 1
        cadena = "LU"
      Case 2

        cadena = "MA"
      Case 3

        cadena = "MI"
      Case 4

        cadena = "JU"
      Case 5

        cadena = "VI"
      Case 6
        cadena = "XX"

    End Select

    Return cadena
  End Function
End Class