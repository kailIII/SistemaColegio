Imports Microsoft.Office.Interop.Excel

Public Class frmNominaMatriculados
  Private Const CLAVE As String = "12345678"
  Private contH As Integer
  Private contM As Integer

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub frmActaMatriculado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\excel.bmp")

    ListarAnios()
    ListarNiveles()
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
      'Else
      '  If Me.cboNivel.SelectedIndex > 0 Then
      '    MessageBox.Show("Registre niveles", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      '    Me.Close()
      '  End If
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
      'Else
      '  If Me.cboGrado.SelectedIndex > 0 Then
      '    'Me.btnExportar.Enabled = False
      '    MessageBox.Show("Nivel no tiene grados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      '  End If      
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
    Dim HojaAnt, HojaPost, hoja As Microsoft.Office.Interop.Excel.Worksheet
    Dim proc As Process()
    hoja = Nothing
    HojaAnt = Nothing
    HojaPost = Nothing

    Dim sw As Integer = 0
    Dim sw2 As Integer = 0 ''para saber si hay alumnos
    Dim NroSec As Integer
    Dim nameAnte(99) As String
    Dim namePost(99) As String
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
            'excel = CType(CreateObject("Excel.Application"), Microsoft.Office.Interop.Excel.Application)
            Libro = excel.Workbooks.Add(AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Plantilla-Matricula.xls")

            HojaAnt = CType(Libro.Worksheets(1), Worksheet)
            HojaAnt.Select()
            HojaPost = CType(Libro.Worksheets(2), Worksheet)
            HojaPost.Select()
            excel.ScreenUpdating = False
            'Libro.Application.Visible = True
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

                'Me.pbAvance.Maximum = NroSec * 20 + 50
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
                          HojaAnt = CType(Libro.Worksheets(Libro.Worksheets.Count - 1), Worksheet)
                          HojaPost = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
                        End If

                        HojaAnt.Copy(, HojaAnt)
                        HojaPost.Copy(, HojaAnt)

                        If sw = 0 Then
                          HojaAnt = CType(Libro.Worksheets(1), Worksheet)
                          HojaPost = CType(Libro.Worksheets(2), Worksheet)
                        Else
                          HojaAnt = CType(Libro.Worksheets(Libro.Worksheets.Count - 3), Worksheet)
                          HojaPost = CType(Libro.Worksheets(Libro.Worksheets.Count - 2), Worksheet)
                        End If

                        sw = 1

                        HojaAnt.Unprotect(CLAVE)
                        HojaPost.Unprotect(CLAVE)
                        HojaAnt.Range("A1").Value = "NÓMINA DE MATRÍCULA " & Me.cboAnio.Text
                        DatosSeccion(sec, HojaAnt)
                        DatosDRE(objDRE, HojaAnt)
                        DatosInstitucion(objI, nivel, sec.Grado.Caracteristica, HojaAnt) ''''''''''' aqui cambios

                        DatosAnioLectivo(objAnio, HojaAnt)
                        DatosLocal(objLocal, HojaAnt)
                        DatosAlumno(objAlu, HojaAnt, HojaPost, Libro)
                        DatosResumen(HojaPost)
                        If Me.cboNivel.SelectedIndex = 0 Then
                          nameAnte(k) = sec.Grado.Numero & "º " & sec.Letra & " (" & nivel.Nombre.Chars(0) & nivel.Nombre.Chars(1) & nivel.Nombre.Chars(2) & ")"
                          namePost(k) = sec.Grado.Numero & "º " & sec.Letra & " (" & nivel.Nombre.Chars(0) & nivel.Nombre.Chars(1) & nivel.Nombre.Chars(2) & ")" & " - Posterior"
                        Else
                          nameAnte(k) = sec.Grado.Numero & "º " & sec.Letra
                          namePost(k) = sec.Grado.Numero & "º " & sec.Letra & " - Posterior"
                        End If

                        HojaAnt.Protect(CLAVE)
                        HojaPost.Protect(CLAVE)

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
                '*************** Borrando las dos ultimas hojas ****************'
                excel.DisplayAlerts = False
                Dim hojaA, hojaP As Microsoft.Office.Interop.Excel.Worksheet
                hojaA = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
                hojaA.Select()
                If Libro.Worksheets.Count > 1 Then
                  hojaA.Delete()
                End If
                hojaP = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
                hojaP.Select()
                If Libro.Worksheets.Count > 1 Then
                  hojaP.Delete()
                End If
                hojaA = Nothing
                hojaP = Nothing
                Me.pbAvance.Value += 10
                '------------------------------------------------------------------'

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '*************** Agregar los nombres de las hojas ****************'
                Dim w As Integer = 2
                Dim count As Integer
                count = CInt((Libro.Worksheets.Count / 2) - 1)
                For k = 0 To count
                  HojaPost = CType(Libro.Worksheets(w), Worksheet)
                  HojaPost.Name = namePost(k)
                  w += 2
                Next
                w = 1
                For k = 0 To count
                  HojaAnt = CType(Libro.Worksheets(w), Worksheet)
                  HojaAnt.Name = nameAnte(k)
                  w += 2
                Next
                Me.pbAvance.Value += 10
                '------------------------------------------------------------------'

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '************ Para eliminar las hojas que no tienen alumnos ****************'
                'Libro.Application.Visible = True

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
                  excel.ActiveWorkbook.SaveAs(Me.cboAnio.Text & " - " & nivel.Nombre & " - " & sec.Grado.Numero & "-" & sec.Letra & ".xls", _
                                              Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
                ElseIf cboGrado.SelectedIndex > 0 Then
                  excel.ActiveWorkbook.SaveAs(Me.cboAnio.Text & " - " & nivel.Nombre & " - " & sec.Grado.Numero & ".xls", _
                                              Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
                ElseIf Me.cboNivel.SelectedIndex > 0 Then
                  excel.ActiveWorkbook.SaveAs(Me.cboAnio.Text & " - " & nivel.Nombre & "  .xls", _
                                              Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
                Else
                  excel.ActiveWorkbook.SaveAs(Me.cboAnio.Text & ".xls", _
                                              Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
                End If
                '------------------------------------------------------------------'
                Me.pbAvance.Value = Me.pbAvance.Maximum
                MessageBox.Show("Archivo exportado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.pbAvance.Value = 0
              Else
                MessageBox.Show("Exportación de nómina(s) fallida(s)", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
              End If
              excel.ScreenUpdating = True

              objRNAnio = Nothing
              objRNDRE = Nothing
              objRNLocal = Nothing
              objRNTraslado = Nothing
              objRNNivel = Nothing
              objRNSec = Nothing

              hoja = Nothing
              HojaAnt = Nothing
              HojaPost = Nothing

              Libro.Close()
              excel.Quit()
              'excel = Nothing
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

  Public Sub Limpiar()
    Me.pbAvance.Value = 0
    'Me.cboNivel.SelectedIndex = 0
    'Me.cboGrado.SelectedIndex = 0
    'Me.cboSeccion.SelectedIndex = 0
    Me.btnExportar.Enabled = True
  End Sub

  Public Sub DatosAlumno(ByVal objtras As List(Of Traslado), ByVal hojaAnt As Worksheet, ByVal hojaPost As Worksheet, ByVal Libro As Workbook)
    Dim Alum As New Traslado
    Dim letra As String
    Dim k As Integer = 16
    Dim j As Integer = 0
    Dim sw As Integer = 0
    Dim contador As Integer = 0
    Dim hoja As Worksheet

    hoja = hojaAnt
    For Each Alum In objtras
      If j = 21 Then
        k = 10
        'hoja = CType(Libro.Worksheets(Libro.Worksheets.Count), Worksheet)
        hoja = hojaPost
        'hoja.Unprotect(CLAVE)
      End If
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
      End With

      hoja.Range("P" & k).Value = Alum.OMatricula.Alumno.ApellidoPaterno & " " & Alum.OMatricula.Alumno.ApellidoMaterno & ",  " & Alum.OMatricula.Alumno.Nombre
      hoja.Range("AB" & k).Value = Alum.OMatricula.Alumno.FechaNacimiento.Day
      hoja.Range("AC" & k).Value = Alum.OMatricula.Alumno.FechaNacimiento.Month
      hoja.Range("AD" & k).Value = Alum.OMatricula.Alumno.FechaNacimiento.Year
      If Alum.Sexo = "M" Then 'M masculino
        letra = "H"  'H hombres
        contH += 1
      Else
        letra = "M"  'M mujeres
        contM += 1
      End If
      hoja.Range("AF" & k).Value = letra
      hoja.Range("AH" & k).Value = CStr(Alum.OMatricula.Alumno.LugarNacimiento.Pais.Chars(0))

      If Alum.OMatricula.Alumno.Padre.Variable <> "" Then
        If Alum.OMatricula.Alumno.Padre.Variable = "True" Then
          letra = "Si"
        Else
          letra = "No"
        End If
      Else
        letra = ""
      End If
      hoja.Range("AI" & k).Value = letra
      If Alum.OMatricula.Alumno.Madre.Variable <> "" Then
        If Alum.OMatricula.Alumno.Madre.Variable = "True" Then
          letra = "Si"
        Else
          letra = "No"
        End If
      Else
        letra = ""
      End If
      hoja.Range("AJ" & k).Value = letra
      hoja.Range("AK" & k).Value = CStr(Alum.OMatricula.Alumno.LenguaMaterna.Chars(0))
      If Alum.OMatricula.Alumno.Madre.GradoInstruccion = "PRIMARIA" Then
        hoja.Range("AO" & k).Value = "P"
        sw = 1
      End If
      If Alum.OMatricula.Alumno.Madre.GradoInstruccion = "SECUNDARIA" Then
        hoja.Range("AO" & k).Value = "S"
        sw = 1
      End If
      If Alum.OMatricula.Alumno.Madre.GradoInstruccion = "SUPERIOR" Then
        hoja.Range("AO" & k).Value = "SP"
        sw = 1
      End If
      If sw = 0 Then
        hoja.Range("AO" & k).Value = "A"
      End If
      hoja.Range("AG" & k).Value = Alum.OMatricula.TipoMatricula
      hoja.Range("AL" & k).Value = "-"
      hoja.Range("AM" & k).Value = "No"
      hoja.Range("AN" & k).Value = "-"
      hoja.Range("AP" & k).Value = "Si"
      hoja.Range("AQ" & k).Value = "-"

      If Alum.CodigoModularInst <> "" Then
        hoja.Range("AR" & k).Value = CStr(Alum.CodigoModularInst.Chars(0))
        hoja.Range("AS" & k).Value = CStr(Alum.CodigoModularInst.Chars(1))
        hoja.Range("AT" & k).Value = CStr(Alum.CodigoModularInst.Chars(2))
        hoja.Range("AU" & k).Value = CStr(Alum.CodigoModularInst.Chars(3))
        hoja.Range("AV" & k).Value = CStr(Alum.CodigoModularInst.Chars(4))
        hoja.Range("AW" & k).Value = CStr(Alum.CodigoModularInst.Chars(5))
        hoja.Range("AX" & k).Value = CStr(Alum.CodigoModularInst.Chars(6))
        hoja.Range("AY" & k).Value = Alum.NombreInst
      End If

      k += 1
      j += 1
    Next
  End Sub

  Public Sub DatosResumen(ByVal hoja As Worksheet)
    hoja.Range("I41").Value = contH
    hoja.Range("I42").Value = contM
    hoja.Range("I43").Value = contH + contM
  End Sub

  Public Sub DatosDRE(ByVal obj As DRE, ByVal Hoja As Worksheet)
    Hoja.Range("D7").Value = CStr(obj.CodigoUGEL.Chars(0))
    Hoja.Range("F7").Value = CStr(obj.CodigoUGEL.Chars(1))
    Hoja.Range("H7").Value = CStr(obj.CodigoUGEL.Chars(2))
    Hoja.Range("J7").Value = CStr(obj.CodigoUGEL.Chars(3))
    Hoja.Range("L7").Value = CStr(obj.CodigoUGEL.Chars(4))
    Hoja.Range("N7").Value = CStr(obj.CodigoUGEL.Chars(5))
    Hoja.Range("D8").Value = obj.NombreDRE
  End Sub

  Public Sub DatosInstitucion(ByVal obj As Institucion, ByVal nivel As Nivel, ByVal caract As String, ByVal hoja As Worksheet)
    hoja.Range("R6").Value = obj.Nombre
    If obj.Gestion = "0" Then
      hoja.Range("AE6").Value = "P"
    Else
      hoja.Range("AE6").Value = "PR"
    End If
        hoja.Range("R7").Value = CStr(nivel.CodigoModular.Chars(0))
        hoja.Range("S7").Value = CStr(nivel.CodigoModular.Chars(1))
        hoja.Range("T7").Value = CStr(nivel.CodigoModular.Chars(2))
        hoja.Range("U7").Value = CStr(nivel.CodigoModular.Chars(3))
        hoja.Range("V7").Value = CStr(nivel.CodigoModular.Chars(4))
        hoja.Range("W7").Value = CStr(nivel.CodigoModular.Chars(5))
        If nivel.CodigoModular.Length = 7 Then
            hoja.Range("X7").Value = CStr(nivel.CodigoModular.Chars(6))
        End If

    hoja.Range("AA7").Value = caract
    hoja.Range("AA8").Value = "Esc"
    hoja.Range("AE7").Value = "-"
    hoja.Range("AE8").Value = "-"
    hoja.Range("R8").Value = obj.Resolucion
    hoja.Range("R9").Value = CStr(nivel.Nombre.Chars(0)) & CStr(nivel.Nombre.Chars(1)) & CStr(nivel.Nombre.Chars(2))
    hoja.Range("R10").Value = "EBR"
  End Sub

  Public Sub DatosAnioLectivo(ByVal obj As AnioLectivo, ByVal hoja As Worksheet)
    hoja.Range("AH6").Value = obj.fechaI
    hoja.Range("AN6").Value = obj.fechaF
  End Sub

  Public Sub DatosLocal(ByVal obj As Local, ByVal hoja As Worksheet)
    hoja.Range("AU6").Value = obj.Departamento
    hoja.Range("AU7").Value = obj.Provincia
    hoja.Range("AU8").Value = obj.Distrito
    hoja.Range("AR10").Value = obj.Distrito
  End Sub

  Public Sub DatosSeccion(ByVal obj As Seccion, ByVal hoja As Worksheet)
    Dim Numero As Integer
    Dim objSec As New RNSeccion
    Numero = objSec.LeerNroSeccionesGrado(New Seccion(0, obj.Grado.Numero, obj.Grado.codigoNivel, "", CChar("a")), New AnioLectivo(moAnioActual.anio))
    If Numero > 1 Then
      hoja.Range("AA9").Value = CStr(obj.Letra)
    Else
      hoja.Range("AA9").Value = CStr("-")
    End If
    hoja.Range("Y9").Value = CInt(obj.Grado.Numero)
    hoja.Range("AE9").Value = CStr(obj.Turno.Nombre.Chars(0))
  End Sub

End Class