Imports Microsoft.Office.Interop.Excel

Public Class frmRegistroAuxiliar

  Private Const CLAVE As String = "CETI"
  Private vector(60) As Integer
  Private vectorNroMat(60) As Integer

  Private Sub frmRegistroAuxiliar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\excel.bmp")

    Me.txtPeriodo.Text = moAnioActual.anio & "    -    " & mOPeriodoActual.Nombre
    MostrarCursosSeccion()
  End Sub

  Private Sub MostrarCursosSeccion()
    Dim objRN As New RNDocenteCarga
    Dim Ldc As New List(Of DocenteCarga)
    Ldc = objRN.ListarCargaSeccion(mOPeriodoActual, New Docente(mOUsuario.Persona.Codigo))
    If Ldc.Count > 0 Then
      Ldc.Insert(0, New DocenteCarga(Nothing, New CargaAcademica(Nothing, New Curso(Nothing, "Seleccionar todos"), _
                                        New Seccion(Nothing, CInt("1"), Nothing, "Seleccionar todos", CChar(""))), Nothing))

      cboCursoSeccion.DisplayMember = "CursoSeccion"
      cboCursoSeccion.ValueMember = "Codigo"
      cboCursoSeccion.DataSource = Ldc

    Else
      cboCursoSeccion.DataSource = Nothing
    End If
  End Sub

  Public Sub Gestionar()
    Me.ShowDialog()
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub txtPeriodo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPeriodo.Enter
    cboCursoSeccion.Focus()
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Dim ListMat As New List(Of Matricula)
    Dim objM As New RNMatricula
    Dim objMat As New RNMatricula

    Dim objRN As New RNDocenteCarga
    Dim DC As New DocenteCarga
    Dim Ldc As New List(Of DocenteCarga)

    Dim objNivel As List(Of Nivel) = Nothing
    Dim objAlu As List(Of Traslado) = Nothing
    Dim LPPC As List(Of PromedioPeriodoCurso) = Nothing
    Dim ListDocCarga As List(Of DocenteCarga) = Nothing
    Dim obj As New RNIndicador
    Dim LInd As New List(Of Indicador)

    Dim codDocentecarga As Integer = 0
    Dim NroSec As Integer

    Dim excel As Microsoft.Office.Interop.Excel.Application = Nothing
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim HojaAnt, HojaPost, hoja As Microsoft.Office.Interop.Excel.Worksheet

    Dim sw As Integer = 0
    Dim sw2 As Integer = 0 ''para saber si hay alumnos
    Dim err As Integer = 0
    Dim nameAnte(99) As String
    Dim namePost(99) As String
    Dim cantidadAlu(99) As Integer
    Dim k As Integer = 0

    hoja = Nothing
    HojaAnt = Nothing
    HojaPost = Nothing

    Try
      excel = New Microsoft.Office.Interop.Excel.Application
      Libro = excel.Workbooks.Add(AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\RegistroAuxiliar.xls")

      HojaAnt = CType(Libro.Worksheets(1), Worksheet)
      HojaAnt.Select()
      excel.ScreenUpdating = False

      Me.pbAvance.Value = 1

      If Me.cboCursoSeccion.SelectedIndex = 0 Then
        Ldc = objRN.ListarCargaSeccion(mOPeriodoActual, New Docente(mOUsuario.Persona.Codigo))
        NroSec = Ldc.Count
      Else
        NroSec = 1
        Ldc = objRN.ListarCargaSeccionUnica(New DocenteCarga(CInt(cboCursoSeccion.SelectedValue)))
      End If

      If NroSec > 0 Then
        For Each DC In Ldc
          If DC.Codigo = CInt(cboCursoSeccion.SelectedValue) Or CInt(cboCursoSeccion.SelectedValue) = 0 Then
            ListMat = objMat.ListarAlumnosGrupo(New DocenteCarga(DC.Codigo))
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
              '''''''''''''Guardar Datos del docente y curso'''''''''''''
              HojaAnt.Range("A56").Value = mOUsuario.Codigo
              HojaAnt.Range("B56").Value = moAnioActual.Anio
              HojaAnt.Range("C56").Value = mOPeriodoActual.Codigo
              HojaAnt.Range("D56").Value = DC.Codigo

              HojaAnt.Range("B4").Value = txtPeriodo.Text
              HojaAnt.Range("B5").Value = DC.CursoSeccion

              HojaAnt.Range("AJ1").Value = mOPeriodoActual.Siglas.ToString
              DatosAlumno(ListMat, HojaAnt, HojaPost, Libro)
              LInd = obj.ListarIndicadoresGrupo(DC)
              If LInd.Count > 0 Then
                DatosIndCursos(LInd, HojaAnt, HojaPost, Libro)
                nameAnte(k) = DC.CursoSeccion
                k += 1
                err = 0
              Else
                MessageBox.Show("No ha ingresado indicadores", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                err = 1
              End If
            End If
          End If
          Me.pbAvance.Value += 1
        Next
      End If

      Me.pbAvance.Value += 10
      excel.DisplayAlerts = False
      If sw2 = 1 And err = 0 Then
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '*************** Borrando las dos primeras hojas ****************'
        excel.DisplayAlerts = False
        Dim hojaA, hojaP As Microsoft.Office.Interop.Excel.Worksheet
        hojaA = CType(Libro.Worksheets(1), Worksheet)
        hojaA.Select()
        If Libro.Worksheets.Count > 1 Then
          hojaA.Delete()
        End If
        'hojaP = CType(Libro.Worksheets(1), Worksheet)
        'hojaP.Select()
        If Libro.Worksheets.Count > 1 Then
          '  hojaP.Delete()
        End If
        hojaA = Nothing
        hojaP = Nothing
        Me.pbAvance.Value += 10
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
          excel.Run("OcultarColumnaVacia")
          HojaAnt.Protect(CLAVE)
          w -= 1
        Next
        Me.pbAvance.Value += 5

        excel.DisplayAlerts = False
        Me.pbAvance.Value += 5
        '*************** Para seleccionar la primera hoja ****************'       
        hoja = CType(Libro.Worksheets(1), Worksheet)
        hoja.Select()
        '******************* Para guardar las hojas  *********************'

        If Me.cboCursoSeccion.SelectedIndex > 0 Then
          excel.ActiveWorkbook.SaveAs(moAnioActual.Anio & " _ " & mOPeriodoActual.Siglas.ToString & " __ " & mOUsuario.Persona.NombreCompleto & " --" & DC.CursoSeccion & ".xls", _
                            Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
        Else
          excel.ActiveWorkbook.SaveAs(moAnioActual.Anio & " _ " & mOPeriodoActual.Siglas.ToString & " __ " & mOUsuario.Persona.NombreCompleto & ".xls", _
                  Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel8)
        End If
        '------------------------------------------------------------------'
        pbAvance.Value = pbAvance.Maximum
        MessageBox.Show("Archivo exportado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Else
        MessageBox.Show("Exportación de nómina(s) fallida(s)", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If

      excel.ScreenUpdating = True

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

    End Try
    Limpiar()

  End Sub

  Public Sub DatosAlumno(ByVal objAlum As List(Of Matricula), ByVal hojaAnt As Worksheet, ByVal hojaPost As Worksheet, ByVal Libro As Workbook)
    Dim Alum As New Matricula

    Dim k As Integer = 10
    Dim j As Integer = 0
    Dim sw As Integer = 0
    Dim contador As Integer = 0

    Dim hoja As Worksheet

    hoja = hojaAnt
    InicializarVector(vector)
    InicializarVector(vectorNroMat)
    For Each Alum In objAlum
      If j = 38 Then
        k = 10
        hoja = hojaPost
      End If

      hoja.Range("A" & k).Value = Alum.NroOrden
      hoja.Range("AN" & k).Value = Alum.Numero

      vector(sw) = Alum.NroOrden
      vectorNroMat(sw) = Alum.Numero
      hoja.Range("B" & k).Value = Alum.Alumno.ApellidoPaterno & " " & Alum.Alumno.ApellidoMaterno & ",  " & Alum.Alumno.Nombre
      sw += 1
      k += 1
      j += 1
    Next

  End Sub

  Private Sub InicializarVector(ByVal v() As Integer)
    For i As Integer = 0 To 60 - 1
      vector(i) = 0
    Next
  End Sub

  Public Sub Limpiar()
    Me.pbAvance.Value = 0
  End Sub

  Public Sub DatosIndCursos(ByVal ListInd As List(Of Indicador), ByVal hojaAnt As Worksheet, ByVal hojaPost As Worksheet, ByVal Libro As Workbook)
    Dim Ind As New Indicador
    'Dim Prom As New PromedioPeriodoCurso
    Dim listProm As New List(Of PromedioPeriodoCurso)
    Dim objRNProm As New RNPromedioPeriodoCurso
    Dim MI As New MatriculaIndicador
    Dim listMI As New List(Of MatriculaIndicador)
    Dim objRMI As New RNMatriculaIndicador

    Dim k As Integer = 9
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
    For Each Ind In ListInd
      If j = 38 Then
        k = 8
        hoja = hojaPost
      End If
      m = 0

      j += 1
      ' Cod. Indicador
      hoja.Cells(k - 3, 9 + j) = Ind.Codigo

      hoja.Cells(k, 9 + j) = "I" & j
      listMI = objRMI.ListarNotasIndicador(Ind)
      r = hoja.Range(hoja.Cells(n, 10 + e), hoja.Cells(n, 10 + e))
      For Each MI In listMI
        Dim posi As Integer = Array.IndexOf(vectorNroMat, MI.Matricula.Numero)
        If posi > -1 Then
          r.Offset(posi, 0).Value = MI.Letra
        End If
      Next
      e += 1
    Next

    hoja.Range("AJ6").Value = ListInd.Count

    listProm = objRNProm.ListarPromIndConsolidado(New PromedioPeriodoCurso(Nothing, Ind.DocenteCarga, Nothing, _
                                                        mOPeriodoActual.Codigo, Nothing, "", ""))
    r = hoja.Range(hoja.Cells(n, 36), hoja.Cells(n, 36))

    For Each P In listProm
      Dim posi As Integer = Array.IndexOf(vector, P.NroOrden)
      If posi > -1 Then
        r.Offset(posi, 0).Value = P.Letra
        r.Offset(posi, 1).Value = P.NivelEsfuerzo
        r.Offset(posi, 3).Value = P.Codigo
      End If
      sw += 1
    Next

  End Sub

End Class