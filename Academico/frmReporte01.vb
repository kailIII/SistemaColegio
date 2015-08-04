Imports Microsoft.Office.Interop.Excel

Public Class frmReporte01
    Private Const CLAVE As String = "12345678"
    Private contH As Integer
    Private contM As Integer

    Public Sub Gestionar()
        Me.ShowDialog()
    End Sub

    Private Sub frmReporte01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MostrarImagenes()
        ListarAnios()
        ListarNiveles()
    End Sub

    Private Sub MostrarImagenes()
        Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
        Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\excel.bmp")
  End Sub

    Public Sub ListarAnios()
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
            Me.cboNivel.ValueMember = "Nombre"
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
            lg.Insert(0, New Grado(0, 0, "Seleccionar todos", 0)) '''''zsdgsd
            Me.cboGrado.DisplayMember = "Nombre"
            Me.cboGrado.ValueMember = "Nombre"
            Me.cboGrado.DataSource = lg
        End If

    End Sub

    Private Sub cboGrado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrado.SelectedIndexChanged
        Dim objGrado As Grado
        Dim objAnio As AnioLectivo

        If cboAnio.SelectedIndex > -1 Then
            objGrado = CType(Me.cboGrado.SelectedItem, Grado)
            objAnio = CType(Me.cboAnio.SelectedItem, AnioLectivo)
            ListarSecciones(objGrado.Codigo, objAnio.anio)
            If Me.cboGrado.SelectedIndex = 0 Then
                Me.cboSeccion.Enabled = False
            Else
                Me.cboSeccion.Enabled = True
            End If
        End If
    End Sub
    Public Sub ListarSecciones(ByVal wCodigoGrado As Integer, ByVal wAnio As String)
        Dim obj As New RNSeccion
        Dim ls As List(Of Seccion)

        ls = obj.Listar2(New Seccion(New Grado(wCodigoGrado), wAnio, CChar("a"), New Docente(), "", 0, 0)) 'wCodigoGrado, wAnio)
        If ls.Count > 0 Then
            ls.Insert(0, New Seccion(New AnioLectivo(), New Grado(), "S"))
            Me.cboSeccion.DisplayMember = "LetraCompleta"
            Me.cboSeccion.ValueMember = "Letra"
            Me.cboSeccion.DataSource = ls
        End If

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Dim objMat As New RNMatricula
        Dim objRNSec As New RNSeccion
        Dim objRNDRE As New RNDRE
        Dim objRNNivel As New RNNivel
        Dim objRNAnio As New RNAnioLectivo
        Dim objRNLocal As New RNLocal
        Dim objRNTraslado As New RNTraslado
        Dim objRNInst As New RNInstitucion

        Dim objSec As List(Of Seccion) = Nothing
        Dim objNivel As List(Of Nivel) = Nothing
        Dim objAlu As List(Of Traslado) = Nothing

        Dim objI As Institucion = Nothing
        Dim sec As Seccion = Nothing
        Dim nivel As Nivel = Nothing
        Dim objDRE As DRE = Nothing
        Dim objAnio As AnioLectivo = Nothing
        Dim objLocal As Local = Nothing


        Dim excel As Microsoft.Office.Interop.Excel.Application = Nothing
        Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
        Dim HojaAnt, hoja As Microsoft.Office.Interop.Excel.Worksheet
        Dim proc As Process()
        hoja = Nothing
        HojaAnt = Nothing

        Dim sw As Integer = 0
        Dim sw2 As Integer = 0 ''para saber si hay alumnos
        Dim NroSec As Integer
        Dim nameAnte(99) As String
        Dim grado As String = Nothing
        Dim letra As Char
        Dim cantidadAlu(99) As Integer
        Dim k As Integer = 0

        If objMat.ListarMatriculas(moAnioActual) > 0 Then
            Me.btnExportar.Enabled = False
            Try
                objDRE = objRNDRE.DatosDRE1()

                If objDRE IsNot Nothing Then
                    objNivel = objRNNivel.LeerNivelesInstitucion(New Nivel(CType(Me.cboNivel.SelectedItem, Nivel).Codigo, "", ""))
                    objAnio = objRNAnio.LeerAnioLectivo(New AnioLectivo(Me.cboAnio.Text.Trim))
                    objI = objRNInst.Listar()

                    If objI IsNot Nothing Then
                        objLocal = objRNLocal.LeerLocal()

                        excel = New Microsoft.Office.Interop.Excel.Application
                        Libro = excel.Workbooks.Add(AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Reporte01.xls")

                        HojaAnt = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
                        HojaAnt.Select()
                        excel.ScreenUpdating = False

                        If objLocal IsNot Nothing Then
                            If Me.cboNivel.SelectedIndex = 0 Then
                                grado = ""
                                CType(Me.cboNivel.SelectedItem, Nivel).Codigo = 0
                            Else
                                If Me.cboGrado.SelectedIndex = 0 Then
                                    grado = ""
                                Else
                                    grado = Me.cboGrado.Text.Trim
                                End If
                            End If
                            'k = 0

                            Me.pbAvance.Value = 1
                            For Each nivel In objNivel
                                If Me.cboSeccion.SelectedIndex = 0 Then
                                    NroSec = objRNSec.LeerNroSecciones(New Seccion(New Grado(0, 0, grado, New Nivel(nivel.Codigo, Me.cboNivel.Text.Trim, ""), "", "", "", ""), Me.cboAnio.Text.Trim, CChar("a"), New Docente(), "", 0, 0))
                                    letra = CChar("")
                                Else
                                    NroSec = 1
                                    letra = CChar(Me.cboSeccion.Text.Trim)
                                End If

                                objSec = objRNSec.LeerDatosSeccion(New Seccion(New Grado(0, 0, grado, New Nivel(nivel.Codigo, "", ""), "", "", "", ""), moAnioActual.anio, letra, New Docente(), "", 0, 0))

                                If NroSec > 0 Then
                                    For Each sec In objSec
                                        If sec.Grado.codigoNivel = nivel.Codigo Then
                                            contH = 0
                                            contM = 0
                                            objAlu = objRNTraslado.DatosAlumno(New Seccion(New Grado(0, sec.Grado.Numero, "", New Nivel(sec.Grado.codigoNivel, "", ""), "", "", "", ""), moAnioActual.anio, sec.Letra, New Docente(), "", 0, 0))
                                            If objAlu.Count > 0 Then
                                                If sw2 = 0 Then
                                                    sw2 = 1
                                                End If

                                                cantidadAlu(k) = objAlu.Count
                                                If sw = 1 Then
                                                    HojaAnt = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
                                                End If
                                                HojaAnt.Copy(, HojaAnt)
                                                sw = 1

                                                HojaAnt.Unprotect(CLAVE)
                                                HojaAnt.Range("B4").Value = Me.cboAnio.Text
                                                HojaAnt.Range("P4").Value = nivel.Nombre
                                                DatosSeccion(sec, HojaAnt)
                                                DatosInstitucion(objI, nivel, sec.Grado.Caracteristica, HojaAnt) ''''''''''' aqui cambios
                                                DatosAlumno(objAlu, HojaAnt, Libro)
                                                DatosResumen(HojaAnt)
                                                If Me.cboNivel.SelectedIndex = 0 Then
                                                    nameAnte(k) = sec.Grado.Numero & "º " & sec.Letra & " (" & nivel.Nombre.Chars(0) & nivel.Nombre.Chars(1) & nivel.Nombre.Chars(2) & ")"
                                                Else
                                                    nameAnte(k) = sec.Grado.Numero & "º " & sec.Letra
                                                End If

                                                HojaAnt.Protect(CLAVE)

                                                k += 1
                                            End If
                                        End If
                                        Me.pbAvance.Value += 1
                                    Next
                                End If
                            Next

                            Me.pbAvance.Value += 10
                            excel.DisplayAlerts = False
                            If sw2 = 1 Then
                                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                '*************** Borrando las dos primeras hojas ****************'
                                excel.DisplayAlerts = False
                                Dim hojaA As Microsoft.Office.Interop.Excel.Worksheet
                                hojaA = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
                                hojaA.Select()
                                If Libro.Worksheets.Count > 1 Then
                                    hojaA.Delete()
                                End If

                                hojaA = Nothing

                                Me.pbAvance.Value += 10
                                '------------------------------------------------------------------'

                                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                '*************** Agregar los nombres de las hojas ****************'

                                Dim count As Integer = Libro.Worksheets.Count

                                For k = 1 To count
                                    HojaAnt = CType(Libro.Worksheets(k), Worksheet)
                                    HojaAnt.Name = nameAnte(k - 1)
                                Next

                                Me.pbAvance.Value += 10
                                '------------------------------------------------------------------'

                                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                '************ Para eliminar las hojas que no tienen alumnos ****************'

                                excel.DisplayAlerts = False
                                Me.pbAvance.Value += 10
                                '------------------------------------------------------------------'

                                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                '*************** Para seleccionar la primera hoja ****************'       
                                hoja = CType(Libro.Worksheets(1), Worksheet)
                                hoja.Select()
                                '------------------------------------------------------------------'

                                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                                '******************* Para guardar las hojas  *********************'
                                '''''''''''' cambios
                                If Me.cboSeccion.SelectedIndex > 0 Then
                  excel.ActiveWorkbook.SaveAs("Códigos " & Me.cboAnio.Text & " - " & nivel.Nombre & " - " & sec.Grado.Numero & "-" & sec.Letra & ".xls", _
                                              Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
                                ElseIf cboGrado.SelectedIndex > 0 Then
                  excel.ActiveWorkbook.SaveAs("Códigos " & Me.cboAnio.Text & " - " & nivel.Nombre & " - " & sec.Grado.Numero & ".xls", _
                                              Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
                                ElseIf Me.cboNivel.SelectedIndex > 0 Then
                  excel.ActiveWorkbook.SaveAs("Códigos " & Me.cboAnio.Text & " - " & nivel.Nombre & ".xls", _
                                              Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
                                Else
                  excel.ActiveWorkbook.SaveAs("Códigos " & Me.cboAnio.Text & ".xls", _
                                              Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
                                End If
                                '------------------------------------------------------------------'
                                Me.pbAvance.Value = Me.pbAvance.Maximum
                                MessageBox.Show("Archivo exportado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.pbAvance.Value = 0
                            Else
                                MessageBox.Show("Exportación fallida", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                            excel.ScreenUpdating = True

                            objRNAnio = Nothing
                            objRNDRE = Nothing
                            objRNLocal = Nothing
                            objRNTraslado = Nothing
                            objRNNivel = Nothing
                            objRNSec = Nothing

                            Libro.Close()
                            excel.Quit()

                        Else
                            MessageBox.Show("Registre datos del local", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Registre datos de la institución", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Registre datos de la DRE", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                hoja = Nothing
                Libro = Nothing
                excel = Nothing
                MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.pbAvance.Value = 0
            Finally
                objRNAnio = Nothing
                objRNDRE = Nothing
                objRNLocal = Nothing
                objRNTraslado = Nothing
                objRNNivel = Nothing
                objRNSec = Nothing
                If hoja IsNot Nothing Then
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(hoja)
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(Libro)
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excel)
                End If

                hoja = Nothing
                Libro = Nothing
                excel = Nothing

                proc = Process.GetProcessesByName("EXCEL")
                For Each p As Process In proc
                    p.Kill()
                Next
                proc = Nothing
            End Try
            Limpiar()
        Else
            MessageBox.Show("No existen alumnos matriculados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Sub DatosSeccion(ByVal obj As Seccion, ByVal hoja As Worksheet)
        Dim Numero As Integer
        Dim objSec As New RNSeccion
        Numero = objSec.LeerNroSeccionesGrado(New Seccion(0, obj.Grado.Numero, obj.Grado.codigoNivel, "", CChar("a")), New AnioLectivo(moAnioActual.anio))
        If Numero > 1 Then
            hoja.Range("T4").Value = CStr(obj.Letra)
        Else
            hoja.Range("T4").Value = CStr("-")
        End If
        hoja.Range("R4").Value = CInt(obj.Grado.Numero)
    End Sub

    Public Sub DatosInstitucion(ByVal obj As Institucion, ByVal nivel As Nivel, ByVal caract As String, ByVal hoja As Worksheet)
        hoja.Range("A2").Value = obj.Nombre
    End Sub

    Public Sub DatosAlumno(ByVal objtras As List(Of Traslado), ByVal hoja As Worksheet, ByVal Libro As Workbook)
        Dim Alum As New Traslado
        Dim letra As String
        Dim k As Integer = 11
        Dim sw As Integer = 0
        Dim contador As Integer = 0

        For Each Alum In objtras
            hoja.Range("A" & k).Value = Alum.OMatricula.NroOrden
            With Alum.OMatricula.Alumno
                If .CodigoEducando.Chars(0) & .CodigoEducando.Chars(1) _
                       & .CodigoEducando.Chars(2) & .CodigoEducando.Chars(3) <> "0000" Then
                    hoja.Range("B" & k).Value = CStr(.CodigoEducando(0))
                    hoja.Range("C" & k).Value = CStr(.CodigoEducando(1))
                    hoja.Range("D" & k).Value = CStr(.CodigoEducando(2))
                    hoja.Range("E" & k).Value = CStr(.CodigoEducando(3))
                    hoja.Range("F" & k).Value = CStr(.CodigoEducando(4))
                    hoja.Range("G" & k).Value = CStr(.CodigoEducando(5))
                    hoja.Range("H" & k).Value = CStr(.CodigoEducando(6))
                    hoja.Range("I" & k).Value = CStr(.CodigoEducando(7))
                    hoja.Range("J" & k).Value = CStr(.CodigoEducando(8))
                    hoja.Range("K" & k).Value = CStr(.CodigoEducando(9))
                    hoja.Range("L" & k).Value = CStr(.CodigoEducando(10))
                    hoja.Range("M" & k).Value = CStr(.CodigoEducando(11))
                    hoja.Range("N" & k).Value = CStr(.CodigoEducando(12))
                    hoja.Range("O" & k).Value = CStr(.CodigoEducando(13))
                End If
                hoja.Range("P" & k).Value = .ApellidoPaterno & " " & .ApellidoMaterno _
                                          & ",  " & .Nombre

                If Alum.Sexo = "M" Then 'M masculino
                    letra = "H"  'H hombres
                    contH += 1
                Else
                    letra = "M"  'M mujeres
                    contM += 1
                End If
                hoja.Range("T" & k).Value = letra
                hoja.Range("U" & k).Value = CStr(.LugarNacimiento.Pais.Chars(0))

        If .Padre.Variable <> "" Then
          If .Padre.Variable = "True" Then
            letra = "Si"
          Else
            letra = "No"
          End If
        Else
          letra = ""
        End If
                hoja.Range("V" & k).Value = letra
        If .Madre.Variable <> "" Then
          If .Madre.Variable = "True" Then
            letra = "Si"
          Else
            letra = "No"
          End If
        Else
          letra = ""
        End If
                hoja.Range("W" & k).Value = letra
            End With
            k += 1
        Next
    End Sub

    Public Sub DatosResumen(ByVal hoja As Worksheet)
        hoja.Range("I63").Value = contH
        hoja.Range("I64").Value = contM
        hoja.Range("I65").Value = contH + contM
    End Sub

    Public Sub Limpiar()
        Me.pbAvance.Value = 0
        Me.btnExportar.Enabled = True
    End Sub

End Class