Imports Microsoft.Office.Interop.Excel

Public Class frmActaNotas

  Private Const PRIMERA_HOJA As Integer = 21
  Private Const CLAVE As String = "12345678"

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

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Dim rnA As RNAnioLectivo
    Dim rnAD As RNAreaDRE
    Dim rnN As RNNivel
    Dim rnS As RNSeccion
    Dim secs As List(Of Seccion)
    Dim s As Seccion

    rnAD = New RNAreaDRE
    If cboNivel.SelectedIndex = 0 Then
      rnA = New RNAnioLectivo
      secs = rnA.ListarSecciones(DirectCast(cboAnio.SelectedItem, AnioLectivo))
      For Each n As Nivel In DirectCast(cboNivel.DataSource, List(Of Nivel))
        If n.Codigo > 0 Then
          n.Areas = rnAD.Listar_Nivel(n)
        End If
      Next
    ElseIf cboGrado.SelectedIndex = 0 Then
      rnN = New RNNivel
      secs = rnN.ListarSecciones(DirectCast(cboAnio.SelectedItem, AnioLectivo), DirectCast(cboNivel.SelectedItem, Nivel))
      DirectCast(cboNivel.SelectedItem, Nivel).Areas = rnAD.Listar_Nivel(DirectCast(cboNivel.SelectedItem, Nivel))
    ElseIf cboSeccion.SelectedIndex = 0 Then
      s = DirectCast(cboSeccion.SelectedItem, Seccion)
      s.Anio = DirectCast(cboAnio.SelectedItem, AnioLectivo)
      s.Grado = DirectCast(cboGrado.SelectedItem, Grado)
      rnS = New RNSeccion()
      secs = rnS.Listar(s)
      DirectCast(cboNivel.SelectedItem, Nivel).Areas = rnAD.Listar_Nivel(DirectCast(cboNivel.SelectedItem, Nivel))
    Else
      secs = New List(Of Seccion)
      secs.Add(DirectCast(cboSeccion.SelectedItem, Seccion))
      DirectCast(cboNivel.SelectedItem, Nivel).Areas = rnAD.Listar_Nivel(DirectCast(cboNivel.SelectedItem, Nivel))
    End If

    CrearActas(secs)
  End Sub

  Private Sub CrearActas(ByVal secciones As List(Of Seccion))
    Dim excel As Microsoft.Office.Interop.Excel.Application = Nothing
    Dim Libro As Microsoft.Office.Interop.Excel.Workbook = Nothing
    Dim proc As Process()
    Dim av As Double
    Dim i As Integer = 0

    Try
      excel = New Microsoft.Office.Interop.Excel.Application
      excel.ScreenUpdating = False
      av = 100 / secciones.Count
      pbAvance.Value = 0
      For Each s As Seccion In secciones
        Libro = excel.Workbooks.Add(AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\ActaNotas.xls")
        ExportarSeccion(s, Libro)
        Libro.SaveAs("Acta " & s.Grado.Codigo.ToString & s.Letra)
        Libro.Close()
        Libro = Nothing
        i += 1
        pbAvance.Value = CInt(av * i)
      Next
      pbAvance.Value = 100
      MessageBox.Show("Generación de acta concluida con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      pbAvance.Value = 0
    Catch ex As Exception
      Libro = Nothing
      excel = Nothing
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Me.pbAvance.Value = 0
    Finally
      excel.ScreenUpdating = True
      If Libro IsNot Nothing Then
        System.Runtime.InteropServices.Marshal.ReleaseComObject(Libro)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(excel)
      End If

      excel.Quit()
      Libro = Nothing
      excel = Nothing

      proc = Process.GetProcessesByName("EXCEL")
      For Each p As Process In proc
        p.Kill()
      Next
      proc = Nothing
    End Try

  End Sub

  Private Sub ExportarSeccion(ByVal wSeccion As Seccion, ByVal wLibro As Workbook)
    Dim rns As New RNSeccion
    Dim dt As System.Data.DataTable
    Dim cant As Integer
    Dim hoja As Worksheet
    Dim celdaAlu As Range

    dt = rns.ListarAlumnosActa(wSeccion)

    If dt.Rows.Count > PRIMERA_HOJA Then
      cant = PRIMERA_HOJA
    Else
      cant = dt.Rows.Count - 1
    End If

    hoja = DirectCast(wLibro.Sheets(1), Worksheet)
    celdaAlu = hoja.Range("A2")
    For i = 0 To cant
      AgregarAlumnoMatricula(dt.Rows.Item(i), celdaAlu)
      celdaAlu = celdaAlu.Offset(1, 0)
    Next
    hoja.Protect(CLAVE)

    If dt.Rows.Count > PRIMERA_HOJA Then
      hoja = DirectCast(wLibro.Sheets(2), Worksheet)
      celdaAlu = hoja.Range("A2")
      For i = PRIMERA_HOJA + 1 To dt.Rows.Count - 1
        AgregarAlumnoMatricula(dt.Rows.Item(i), celdaAlu)
        celdaAlu = celdaAlu.Offset(1, 0)
      Next
      'hoja.Protect(CLAVE)
    End If
  End Sub

  Private Sub AgregarAlumnoMatricula(ByVal wAlumno As DataRow, ByVal CeldaAlu As Range)
    Dim iCol As Integer = 0

    With wAlumno
      CeldaAlu.Offset(0, iCol).Value = .Item("nroOrden")
      iCol += 1
      If .Item("codigoEducando").ToString.Substring(0, 4).Equals("0000") = False Then
        For Each c As Char In .Item("codigoEducando").ToString.ToArray
          CeldaAlu.Offset(0, iCol).Value = c.ToString
          iCol += 1
        Next
      Else
        iCol += 14
      End If

      CeldaAlu.Offset(0, iCol).Value = .Item("ApellidoPat").ToString & " " & .Item("ApellidoMat").ToString & ", " & .Item("Nombre").ToString
      iCol += 1
      CeldaAlu.Offset(0, iCol).Value = .Item("Edad")
      iCol += 1
      CeldaAlu.Offset(0, iCol).Value = .Item("Sexo")
      iCol += 1
      With CDate(.Item("FechaNac"))
        CeldaAlu.Offset(0, iCol).Value = .Day
        iCol += 1
        CeldaAlu.Offset(0, iCol).Value = .Month
        iCol += 1
        CeldaAlu.Offset(0, iCol).Value = .Year
        iCol += 1
      End With
      CeldaAlu.Offset(0, iCol).Value = .Item("Estado")
    End With

  End Sub

  Public Sub Limpiar()
    Me.pbAvance.Value = 0
    Me.btnExportar.Enabled = True
  End Sub

End Class