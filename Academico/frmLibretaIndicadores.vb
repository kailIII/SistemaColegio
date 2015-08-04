Imports Microsoft.Office.Interop.Excel

Public Class frmLibretaIndicadores

  Private Const CLAVE As String = "CETI"
  Private vector(10) As String
  Private nameAnte(99) As String

  Private j As Integer = 17
  Private row As Integer = 11
  Private n As Integer = 0
  Private contador As Integer = 0

  Private NombreNivel As String = ""

  Private Sub frmLibretaIndicadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    txtAnio.Text = moAnioActual.Anio & "    -    " & mOPeriodoActual.Nombre
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\excel.bmp")

    ListarNiveles()
    InicializarVector()
  End Sub

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Public Sub ListarNiveles()
    Dim obj As New RNNivel
    Dim ln As List(Of Nivel)

    ln = obj.LeerNivelIndicadores
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
      Me.cboGrado.SelectedIndex = 0
    End If

  End Sub

  Private Sub cboGrado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrado.SelectedIndexChanged
    Dim objGrado As Grado

    objGrado = CType(Me.cboGrado.SelectedItem, Grado)
    ListarSecciones(objGrado.Codigo, moAnioActual.Anio)
    If Me.cboGrado.SelectedIndex = 0 Then
      Me.cboSeccion.Enabled = False
    Else
      Me.cboSeccion.Enabled = True
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

  Private Sub txtAnio_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAnio.Enter
    cboNivel.Focus()
  End Sub

  Private Sub InicializarVector()
    For i As Integer = 0 To 9
      vector(i) = ""
    Next
  End Sub

  Private Sub InicializarVectorNombreHoja()
    For i As Integer = 0 To 98
      nameAnte(i) = ""
    Next
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Dim ListMat As New List(Of Matricula)
    Dim objM As New RNMatricula
    Dim objMat As New RNMatricula
    Dim objRNSec As New RNSeccion
    Dim objRNNivel As New RNNivel
    Dim objRNDocenteCaga As New RNDocenteCarga
    Dim obj As New RNMatriculaIndicador
    Dim objProm As New RNPromedioPeriodoCurso
    Dim objIND As New RNIndicador
    Dim objRNNotaComp As New RNNotaComportamiento

    Dim objSec As List(Of Seccion) = Nothing
    Dim objNivel As List(Of Nivel) = Nothing
    Dim objAlu As List(Of Traslado) = Nothing
    Dim LPPC As List(Of PromedioPeriodoCurso) = Nothing
    Dim ListDocCarga As List(Of DocenteCarga) = Nothing
    Dim LInd As List(Of Indicador) = Nothing
    Dim Listnotacomp As List(Of NotaComportamiento) = Nothing

    Dim Alum As Matricula = Nothing
    Dim sec As Seccion = Nothing
    Dim nivel As Nivel = Nothing
    Dim DC As DocenteCarga = Nothing
    Dim grado As String = Nothing
    Dim letra As Char
    Dim NroSec As Integer

    Dim excel As Microsoft.Office.Interop.Excel.Application = Nothing
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim HojaAnt, hoja As Microsoft.Office.Interop.Excel.Worksheet

    hoja = Nothing
    HojaAnt = Nothing

    Dim sw As Integer = 0
    Dim sw2 As Integer = 0 ''para saber si hay alumnos

    Dim cantidadAlu(99) As Integer
    Dim k As Integer = 0


    If objMat.ListarMatriculas(moAnioActual) > 0 Then
      Me.btnExportar.Enabled = False
      Try

        objNivel = objRNNivel.LeerNivelIndicadores
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
        Me.pbAvance.Value = 5

        For Each nivel In objNivel
          If nivel.Codigo = CInt(cboNivel.SelectedValue) Or CInt(cboNivel.SelectedValue) = 0 Then

            If Me.cboSeccion.SelectedIndex = 0 Then
              NroSec = objRNSec.LeerNroSecciones(New Seccion(New Grado(0, 0, grado, New Nivel(nivel.Codigo, Me.cboNivel.Text.Trim, ""), "", "", "", ""), _
                                                             moAnioActual.Anio, CChar(""), New Docente(), "", 0, 0))
              letra = CChar("")
            Else
              NroSec = 1
              letra = CChar(Me.cboSeccion.Text.Trim)
            End If
            objSec = objRNSec.LeerDatosSeccion(New Seccion(New Grado(0, 0, grado, New Nivel(nivel.Codigo, "", ""), "", "", _
                                                                    "", ""), moAnioActual.Anio, letra, New Docente(), "", 0, 0))
            If NroSec > 0 Then
              NombreNivel = nivel.Nombre
              Me.pbAvance.Value += 2

              For Each sec In objSec
                excel = New Microsoft.Office.Interop.Excel.Application
                If Me.cboNivel.SelectedIndex = 1 Then
                  Libro = excel.Workbooks.Add(AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Libreta_Inicial.xls")
                Else
                  Libro = excel.Workbooks.Add(AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Libreta_Primaria.xls")
                End If
                HojaAnt = CType(Libro.Worksheets(1), Worksheet)
                HojaAnt.Select()
                excel.ScreenUpdating = True
                k = 0
                InicializarVectorNombreHoja()
                If sec.Grado.CodigoNivel = nivel.Codigo Then
                  ListMat = objM.ListarConsolidado((New Seccion(New Grado(0, sec.Grado.Numero, "", New Nivel(sec.Grado.CodigoNivel, "", ""), _
                                                                      "", "", "", ""), moAnioActual.Anio, sec.Letra, New Docente(), "", 0, 0)), moAnioActual.Anio)
                  If ListMat.Count > 0 Then
                    For Each Alum In ListMat
                      j = 17
                      row = 11
                      n = 0
                      contador = 0
                      If sw2 = 0 Then
                        sw2 = 1
                      End If
                      If sw = 1 Then
                        HojaAnt = CType(Libro.Worksheets(1), Worksheet)
                      End If
                      HojaAnt.Copy(HojaAnt)
                      sw = 1
                      HojaAnt.Unprotect(CLAVE)

                      HojaAnt.Range("A3").Value = "INFORME DE PROGRESO  " & moAnioActual.Anio
                      HojaAnt.Range("A4").Value = mOPeriodoActual.Nombre.Trim  'CambiarTrim(mOPeriodoActual.Siglas.Chars(1)) & "  TRIMESTRE"
                      DatosAlumno(Alum, nivel, sec, HojaAnt, Libro)
                      ListDocCarga = objRNDocenteCaga.ListarCargaConsolidado(sec, mOPeriodoActual)
                      For Each DC In ListDocCarga
                        If objRNDocenteCaga.VerificarAlumnoGrupo(DC, Alum.Numero) > 0 Then
                          LInd = objIND.ListarIndicadoresGrupo(DC)
                          DatosIndCursos(LInd, DC, Alum, HojaAnt, Libro)
                        End If
                      Next
                      Listnotacomp = objRNNotaComp.ListarComportamientoTrimestral(New NotaComportamiento(mOPeriodoActual, Alum, Nothing))
                      MostrarComportamiento(Listnotacomp, sec, HojaAnt, Libro)
                      MostrarAsistencia(Alum, HojaAnt, Libro)
                      HojaAnt.Range("A451").Value = objRNSec.NombreTutor(sec, moAnioActual.Anio)
                      HojaAnt.Range("M451").Value = objRNSec.NombreDirector(sec)

                      nameAnte(k) = CStr(Alum.NroOrden)

                      k += 1
                    Next

                    Try
                      If sw2 = 1 Then
                        '*************** Borrando las dos primeras hojas ****************'
                        excel.DisplayAlerts = False
                        Dim hojaA As Microsoft.Office.Interop.Excel.Worksheet
                        hojaA = CType(Libro.Worksheets(1), Worksheet)
                        hojaA.Select()
                        If Libro.Worksheets.Count > 1 Then
                          hojaA.Delete()
                        End If
                        hojaA = Nothing

                        Me.pbAvance.Value += 1

                        '*************** Agregar los nombres de las hojas ****************'
                        Dim w As Integer = Libro.Worksheets.Count
                        Dim count As Integer
                        count = CInt((w))
                        w = Libro.Worksheets.Count '- 1
                        For k = 0 To count - 1
                          HojaAnt = CType(Libro.Worksheets(w), Worksheet)
                          HojaAnt.Name = nameAnte(k)
                          hoja = CType(Libro.Worksheets(w), Worksheet)
                          hoja.Select()
                          excel.Run("OcultarFilaVacia")
                          HojaAnt.Protect(CLAVE)
                          w -= 1
                        Next
                        excel.Run("OrdenarNro")
                        '************ Para eliminar las hojas que no tienen alumnos ****************'
                        excel.DisplayAlerts = False
                        Me.pbAvance.Value += 1
                        '*************** Para seleccionar la primera hoja ****************'       
                        hoja = CType(Libro.Worksheets(1), Worksheet)
                        hoja.Select()
                        hoja.Range("D5").Select()
                        excel.ActiveWorkbook.SaveAs("Libretas -" & moAnioActual.Anio & "_" & mOPeriodoActual.Siglas.ToString & "-" & NombreNivel & "_" & sec.Grado.Numero & "_" & sec.Letra & ".xls", _
                                                    Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
                      Else
                        MessageBox.Show("Exportación de libreta(s) fallida(s)", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                      End If

                      excel.DisplayAlerts = False
                      excel.ScreenUpdating = True
                      Libro.Close()
                      excel.Workbooks.Close()

                    Catch ex As Exception
                      If excel Is Nothing Then
                        excel = New Microsoft.Office.Interop.Excel.Application
                      End If
                      If excel.ScreenUpdating = False Then
                        excel.ScreenUpdating = True
                      End If
                      excel.ActiveWorkbook.Saved = True
                      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End Try
                  End If
                End If
                Me.pbAvance.Value += 1
              Next
            End If
          End If
        Next
        Me.pbAvance.Value += 1
        pbAvance.Value = pbAvance.Maximum
        MessageBox.Show("Archivo exportado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        excel.Quit()
        excel = Nothing
        objRNNivel = Nothing
        objRNSec = Nothing
      End Try
      Limpiar()
    End If

  End Sub

  Public Sub DatosAlumno(ByVal Alum As Matricula, ByVal wnivel As Nivel, ByVal wseccion As Seccion, ByVal hoja As Worksheet, ByVal Libro As Workbook)
    Dim k As Integer = 10
    Dim j As Integer = 0
    Dim sw As Integer = 0
    Dim contador As Integer = 0

    Me.InicializarVector()
    hoja.Range("D5").Value = Alum.Alumno.Nombre & " " & Alum.Alumno.ApellidoPaterno & " " & Alum.Alumno.ApellidoMaterno
    hoja.Range("D6").Value = wnivel.Nombre
    hoja.Range("D7").Value = Alum.NroOrden
    hoja.Range("K7").Value = wseccion.nombreGrado & " " & wseccion.Letra
    If wnivel.Nombre = "OPTIMIST" Then
      hoja.Range("M452").Value = "Directora Programa Optimist"
    Else
      hoja.Range("M452").Value = "Directora Programa Snipe"
    End If
    vector(sw) = Alum.NroOrden.ToString
  End Sub

  Public Sub DatosIndCursos(ByVal ListInd As List(Of Indicador), ByVal curso As DocenteCarga, ByVal Alum As Matricula, ByVal hojaAnt As Worksheet, ByVal Libro As Workbook)

    Dim Ind As New Indicador
    Dim Prom As New PromedioPeriodoCurso
    Dim objRNProm As New RNPromedioPeriodoCurso
    Dim Nota As New MatriculaIndicador
    Dim objRMI As New RNMatriculaIndicador
    Dim hoja As Worksheet


    Dim m As Integer = 10
    Dim e As Integer = 0
    Dim pos As Integer = 10
    Dim sw As Integer = 0


    hoja = hojaAnt

    If Abreviaturas(curso.NombreCurso) = "ART" Then
      hoja.Cells(row, 1) = curso.NombreCurso & " - " & curso.Nombre
    Else
      hoja.Cells(row, 1) = curso.NombreCurso
    End If

    row += 1
    contador += 1
    For Each Ind In ListInd
      Nota = objRMI.ListarNotasInd_Alumno(Ind, CInt(Alum.Numero))
      hoja.Cells(row, 2) = Ind.Nombre
      If Nota Is Nothing Then
        hoja.Cells(row, j) = ""
      Else
        hoja.Cells(row, j) = Nota.Letra
      End If
      row += 1
    Next
    n = 35
    row = 11 + (n * contador)

    Prom = objRNProm.ListarPromTrimAlumno(New PromedioPeriodoCurso(Nothing, curso.Codigo, Alum.Numero, _
                                                                          mOPeriodoActual.Codigo, Nothing, "", ""))
    If Prom Is Nothing Then
      hoja.Cells(row - 1, 2) = ""
      hoja.Cells(row - 1, j) = ""
    Else
      hoja.Cells(row - 1, 2) = " Nivel de Esfuerzo: " & Prom.NombreNivelEsfuerzo
      hoja.Cells(row - 1, j) = Prom.Letra
    End If

  End Sub

  Public Sub Limpiar()
    Me.pbAvance.Value = 0
    'Me.cboNivel.SelectedIndex = 0
    'Me.cboGrado.SelectedIndex = 0
    'Me.cboSeccion.SelectedIndex = 0
    Me.btnExportar.Enabled = True
  End Sub
  Private Function Abreviaturas(ByVal nombre As String) As String
    Dim Abr As String = ""
    Select Case nombre
      Case "Lógico Matemática"
        Abr = "LM"
      Case "Logico Matemática"
        Abr = "LM"
      Case "Lógica Matemática"
        Abr = "LM"
      Case "Comunicación"
        Abr = "COM"
      Case "Ingles"
        Abr = "ING"
      Case "Inglés"
        Abr = "ING"
      Case "Ciencia y Ambiente"
        Abr = "CA"
      Case "Personal Social"
        Abr = "PS"
      Case "Religión"
        Abr = "REL"
      Case "Educación Religiosa"
        Abr = "REL"
      Case "Educación Artistica"
        Abr = "ART"
      Case "Educación Artística"
        Abr = "ART"
      Case "Computación"
        Abr = "COMP"
      Case "Educación Física"
        Abr = "EFI"
    End Select

    Return Abr
  End Function

  Private Sub MostrarComportamiento(ByVal ListComp As List(Of NotaComportamiento), ByVal sec As Seccion, ByVal hoja As Worksheet, ByVal Libro As Workbook)
    Dim k As Integer = 434
    Dim j As Integer = 7
    Dim pos As Integer = 0
    Dim N As NotaComportamiento = Nothing
    Dim obj As New RNNotaComportamiento
    Dim Lv As List(Of Virtud) = Nothing
    Dim vector(3) As String

    InicializarVector()
    k = 434
    If ListComp.Count > 0 Then
      For Each N In ListComp
        hoja.Cells(k, 1) = N.Virtud.Nombre
        hoja.Cells(k, j) = N.Letra
        k += 1
      Next
    Else
      Lv = obj.ListarVirtudesTrimestral(sec, mOPeriodoActual.Codigo)
      For Each V In Lv
        hoja.Cells(k, 1) = V.Nombre
        k += 1
      Next
    End If
  End Sub

  Private Sub MostrarAsistencia(ByVal Alum As Matricula, ByVal hoja As Worksheet, ByVal libro As Workbook)
    Dim k As Integer = 434
    Dim j As Integer = 17
    Dim objRNAsist As New RNAsistencia

    hoja.Cells(k, j) = objRNAsist.FaltasJusticadas(New Asistencia(0, "FJ", Nothing, Alum, mOPeriodoActual.Codigo, Nothing))
    hoja.Cells(k + 1, j) = objRNAsist.FaltasJusticadas(New Asistencia(0, "F", Nothing, Alum, mOPeriodoActual.Codigo, Nothing))
    hoja.Cells(k + 2, j) = objRNAsist.FaltasJusticadas(New Asistencia(0, "TJ", Nothing, Alum, mOPeriodoActual.Codigo, Nothing))
    hoja.Cells(k + 3, j) = objRNAsist.FaltasJusticadas(New Asistencia(0, "T", Nothing, Alum, mOPeriodoActual.Codigo, Nothing))
  End Sub

  Private Function CambiarTrim(ByVal wpuntos As String) As String
    Dim text As String = ""

    Select Case wpuntos
      Case "1"
        text = "PRIMER"
      Case "2"
        text = "SEGUNDO"
      Case "3"
        text = "TERCER"
    End Select
    Return text
  End Function

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

End Class