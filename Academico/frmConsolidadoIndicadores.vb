Imports Microsoft.Office.Interop.Excel

Public Class frmConsolidadoIndicadores

  Private Const CLAVE As String = "CETI"
  Private vector(60) As Integer
  Private NombreNivel As String = ""

#Region "Validación"
  Private Sub cboNivel_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboNivel.Validating
    If cboNivel.SelectedIndex = -1 Then
      e.Cancel = True
      ErrLibretra.SetError(cboNivel, "Debe indicar el nivel ")
    Else
      ErrLibretra.SetError(cboNivel, "")
    End If
  End Sub

  Private Sub cboGrado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboGrado.Validating
    If cboGrado.SelectedIndex = -1 Then
      e.Cancel = True
      ErrLibretra.SetError(cboGrado, "Debe indicar el grado ")
    Else
      ErrLibretra.SetError(cboGrado, "")
    End If
  End Sub

  Private Sub cboSeccion_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboSeccion.Validating
    If cboSeccion.SelectedIndex = -1 Then
      e.Cancel = True
      ErrLibretra.SetError(cboSeccion, "Debe indicar la sección ")
    Else
      ErrLibretra.SetError(cboSeccion, "")
    End If
  End Sub
#End Region

  Private Sub frmLibretasIndicadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    txtAnio.Text = moAnioActual.Anio & "    -    " & mOPeriodoActual.Nombre
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\excel.bmp")

    Me.ListarNiveles()
    Me.InicializarVector()
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
      'Me.cboGrado.SelectedIndex = 0
    End If
  End Sub

  Private Sub cboGrado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrado.SelectedIndexChanged
    Dim objGrado As Grado

    'If cboGrado.SelectedIndex > -1 Then
    objGrado = CType(Me.cboGrado.SelectedItem, Grado)
    ListarSecciones(objGrado.Codigo, moAnioActual.Anio)
    If Me.cboGrado.SelectedIndex = 0 Then
      Me.cboSeccion.Enabled = False
    Else
      Me.cboSeccion.Enabled = True
    End If
    'End If
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
      ' Me.cboSeccion.SelectedIndex = 0
    End If

  End Sub

  Private Sub txtAnio_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAnio.Enter
    cboNivel.Focus()
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Dim ListMat As New List(Of Matricula)
    Dim objM As New RNMatricula
    Dim objMat As New RNMatricula
    Dim objRNSec As New RNSeccion
    Dim objRNNivel As New RNNivel
    Dim objRNDocenteCaga As New RNDocenteCarga

    Dim objSec As List(Of Seccion) = Nothing
    Dim objNivel As List(Of Nivel) = Nothing
    Dim objAlu As List(Of Traslado) = Nothing
    Dim LPPC As List(Of PromedioPeriodoCurso) = Nothing
    Dim ListDocCarga As List(Of DocenteCarga) = Nothing
    Dim obj As New RNMatriculaIndicador
    Dim objProm As New RNPromedioPeriodoCurso

    Dim sec As Seccion = Nothing
    Dim nivel As Nivel = Nothing

    Dim grado As String = Nothing
    Dim letra As Char
    Dim NroSec As Integer
    Dim excel As Microsoft.Office.Interop.Excel.Application = Nothing
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim HojaAnt, HojaPost, hoja As Microsoft.Office.Interop.Excel.Worksheet
    hoja = Nothing
    HojaAnt = Nothing
    HojaPost = Nothing

    Dim sw As Integer = 0
    Dim sw2 As Integer = 0 ''para saber si hay alumnos

    Dim nameAnte(99) As String
    Dim namePost(99) As String
    Dim cantidadAlu(99) As Integer
    Dim k As Integer = 0


    If objMat.ListarMatriculas(moAnioActual) > 0 Then
      Me.btnExportar.Enabled = False

      Try
        excel = New Microsoft.Office.Interop.Excel.Application
        Libro = excel.Workbooks.Add(AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Consolidado_Primaria.xls")
        HojaAnt = CType(Libro.Worksheets(1), Worksheet)
        HojaAnt.Select()
        excel.ScreenUpdating = False

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

            objSec = objRNSec.LeerDatosSeccion(New Seccion(New Grado(0, nivel.Codigo, grado, New Nivel(nivel.Codigo, "", ""), "", "", _
                                                                     "", ""), moAnioActual.Anio, letra, New Docente(), "", 0, 0))

            If NroSec > 0 Then
              NombreNivel = nivel.Nombre
              For Each sec In objSec

                If sec.Grado.CodigoNivel = nivel.Codigo Then
                  ListMat = objM.ListarConsolidado((New Seccion(New Grado(0, sec.Grado.Numero, "", New Nivel(sec.Grado.CodigoNivel, "", ""), _
                                                                      "", "", "", ""), moAnioActual.Anio, sec.Letra, New Docente(), "", 0, 0)), moAnioActual.Anio)
                  If ListMat.Count > 0 Then

                    If sw2 = 0 Then
                      sw2 = 1
                    End If
                    cantidadAlu(k) = ListMat.Count


                    If sw = 1 Then
                      HojaAnt = CType(Libro.Worksheets(1), Worksheet)
                    End If

                    HojaAnt.Copy(HojaAnt)
                    sw = 1

                    HojaAnt.Unprotect(CLAVE)
                    HojaAnt.Range("C3").Value = txtAnio.Text
                    HojaAnt.Range("C4").Value = NombreNivel & sec.NivelNumeroLetra2
                    DatosAlumno(ListMat, HojaAnt, HojaPost, Libro)
                    ListDocCarga = objRNDocenteCaga.ListarCargaConsolidado(sec, mOPeriodoActual)
                    DatosCursos(ListDocCarga, HojaAnt, Libro)
                    If Me.cboNivel.SelectedIndex = 0 Then
                      nameAnte(k) = sec.Grado.Numero & "º " & sec.Letra & " (" & nivel.Nombre.Chars(0) & nivel.Nombre.Chars(1) & nivel.Nombre.Chars(2) & ")"
                    Else
                      nameAnte(k) = sec.Grado.Numero & "º " & sec.Letra
                    End If
                    k += 1
                  End If
                End If
                Me.pbAvance.Value += 1
              Next
              'If NroSec = 1 Then
              'Exit For
              'End If
            End If
          End If
        Next

        Me.pbAvance.Value += 5
        excel.DisplayAlerts = False

        If sw2 = 1 Then
          '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
          '*************** Borrando las dos primeras hojas ****************'
          excel.DisplayAlerts = False
          Dim hojaA, hojaP As Microsoft.Office.Interop.Excel.Worksheet
          hojaA = CType(Libro.Worksheets(1), Worksheet)
          hojaA.Select()
          If Libro.Worksheets.Count > 1 Then
            hojaA.Delete()
          End If
          hojaA = Nothing
          hojaP = Nothing
          Me.pbAvance.Value += 5
          '------------------------------------------------------------------'

          '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
          '*************** Agregar los nombres de las hojas ****************'
          Dim w As Integer = Libro.Worksheets.Count
          Dim count As Integer
          count = CInt((w))
          w = Libro.Worksheets.Count
          For k = 0 To count - 1
            HojaAnt = CType(Libro.Worksheets(w), Worksheet)
            HojaAnt.Name = nameAnte(k)
            hoja = CType(Libro.Worksheets(w), Worksheet)
            hoja.Select()
            excel.Run("OcultarFilaVacia")
            excel.Run("OcultarColumnaVacia")
            HojaAnt.Protect(CLAVE)

            w -= 1
          Next
          Me.pbAvance.Value += 5
          '************ Para eliminar las hojas que no tienen alumnos ****************'
          'Libro.Application.Visible = True
          excel.DisplayAlerts = False
          Me.pbAvance.Value += 5
          '------------------------------------------------------------------'
          '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
          '*************** Para seleccionar la primera hoja ****************'       
          hoja = CType(Libro.Worksheets(1), Worksheet)
          hoja.Select()
          '------------------------------------------------------------------'
          '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
          '******************* Para guardar las hojas  *********************'
          If Me.cboSeccion.SelectedIndex > 0 Then
            excel.ActiveWorkbook.SaveAs("Consolidado_" & moAnioActual.Anio & "_" & mOPeriodoActual.Siglas.ToString & "--" & NombreNivel & "_" & sec.Grado.Numero & "_" & sec.Letra & ".xls", _
                                        Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
          ElseIf cboGrado.SelectedIndex > 0 Then
            excel.ActiveWorkbook.SaveAs("Consolidado_" & moAnioActual.Anio & "_" & mOPeriodoActual.Siglas.ToString & "--" & NombreNivel & "_" & sec.Grado.Numero & ".xls", _
                                        Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
          ElseIf Me.cboNivel.SelectedIndex > 0 Then
            excel.ActiveWorkbook.SaveAs("Consolidado_" & moAnioActual.Anio & "_" & mOPeriodoActual.Siglas.ToString & "--" & NombreNivel & ".xls", _
                                        Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
          Else
            excel.ActiveWorkbook.SaveAs("Consolidado_" & moAnioActual.Anio & mOPeriodoActual.Siglas.ToString & "--" & ".xls", _
                                        Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
          End If
          '------------------------------------------------------------------'
          Me.pbAvance.Value = Me.pbAvance.Maximum

          MessageBox.Show("Archivo exportado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          MessageBox.Show("Exportación de nómina(s) fallida(s)", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        excel.ScreenUpdating = True


        objRNNivel = Nothing
        objRNSec = Nothing

        hoja = Nothing
        HojaAnt = Nothing
        HojaPost = Nothing

        Libro.Close()
        Libro = Nothing

        excel.Workbooks.Close()
        'excel.Quit()
        'excel = Nothing
      Catch ex As Exception
        If excel Is Nothing Then
          excel = New Microsoft.Office.Interop.Excel.Application
        End If
        If excel.ScreenUpdating = False Then
          excel.ScreenUpdating = True
        End If
        excel.ActiveWorkbook.Saved = True
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
  Public Sub DatosAlumno(ByVal objAlum As List(Of Matricula), ByVal hojaAnt As Worksheet, ByVal hojaPost As Worksheet, ByVal Libro As Workbook)
    Dim Alum As New Matricula

    Dim k As Integer = 10
    Dim j As Integer = 0
    Dim sw As Integer = 0
    Dim contador As Integer = 0
    Dim hoja As Worksheet

    hoja = hojaAnt
    InicializarVector()
    For Each Alum In objAlum
      If j = 38 Then
        k = 10
        hoja = hojaPost
      End If

      hoja.Range("A" & k).Value = Alum.NroOrden
      vector(sw) = Alum.NroOrden
      hoja.Range("B" & k).Value = Alum.Alumno.ApellidoPaterno & " " & Alum.Alumno.ApellidoMaterno & ",  " & Alum.Alumno.Nombre
      sw += 1
      k += 1
      j += 1
    Next

  End Sub
  Public Sub DatosCursos(ByVal objCurso As List(Of DocenteCarga), ByVal hojaAnt As Worksheet, ByVal Libro As Workbook)
    Dim Cur As New DocenteCarga
    Dim Prom As New PromedioPeriodoCurso
    Dim listProm As New List(Of PromedioPeriodoCurso)
    Dim objRNProm As New RNPromedioPeriodoCurso
    Dim k As Integer = 8

    Dim n As Integer = 10
    Dim m As Integer = 10
    Dim e As Integer = 0
    Dim pos As Integer = 10

    Dim j As Integer = 0
    Dim sw As Integer = 0
    Dim contador As Integer = 0
    Dim hoja As Worksheet
    Dim r As Range

    hoja = hojaAnt
    For Each Cur In objCurso
      'If j = 38 Then
      '  k = 8
      '  hoja = hojaPost
      'End If
      m = 0


      If Abreviaturas(Cur.NombreCurso) = "EFI" Then
        sw += 1
        If sw > 1 Then
          j = j - 2
          e = e - 2
        End If
      End If

      hoja.Cells(k, 10 + j) = Abreviaturas(Cur.NombreCurso)

      j += 2

      listProm = objRNProm.ListarPromIndConsolidado(New PromedioPeriodoCurso(Nothing, Cur.Codigo, Nothing, mOPeriodoActual.Codigo, Nothing, "", ""))

      r = hoja.Range(hoja.Cells(n, 10 + e), hoja.Cells(n, 10 + e))

      For Each P In listProm
        Dim posi As Integer = Array.IndexOf(vector, P.NroOrden)
        If posi > -1 Then
          r.Offset(posi, 0).Value = P.Letra
          r.Offset(posi, 1).Value = P.NivelEsfuerzo
        End If
      Next
      e += 2
    Next



    InicializarVector()
  End Sub

  Private Sub InicializarVector()
    For i As Integer = 0 To 60 - 1
      vector(i) = 0
    Next
  End Sub

  Private Function Abreviaturas(ByVal nombre As String) As String
    Dim Abr As String = ""
    Select Case nombre
      Case "Lógico Matemática"
        Abr = "LM"
      Case "Logico Matemática"
        Abr = "LM"
      Case "Matematica"
        Abr = "MAT"
      Case "Matemática"
        Abr = "MAT"
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
  Public Sub Limpiar()
    Me.pbAvance.Value = 0
    'Me.cboNivel.SelectedIndex = 0
    'Me.cboGrado.SelectedIndex = 0
    'Me.cboSeccion.SelectedIndex = 0
    Me.btnExportar.Enabled = True
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub
End Class