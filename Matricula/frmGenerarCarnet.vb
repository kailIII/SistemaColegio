Imports Microsoft.Office.Interop.Excel

Public Class frmGenerarCarnet

  Private mDialogoGuardar As SaveFileDialog
  Private mError As ErrorProvider

  Public WriteOnly Property ComponenteError() As ErrorProvider
    Set(ByVal value As ErrorProvider)
      Me.mError = value
    End Set
  End Property

  Public WriteOnly Property DialogoGuardar() As SaveFileDialog
    Set(ByVal value As SaveFileDialog)
      Me.mDialogoGuardar = value
    End Set
  End Property

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

  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNivel.SelectedIndexChanged
    Dim objNivel As Nivel = Nothing

    If Me.cboNivel.SelectedIndex > 0 Then
      objNivel = CType(Me.cboNivel.SelectedItem, Nivel)
      Me.ListarGrados(objNivel)
      cboGrado.Enabled = True
    Else
      cboGrado.Enabled = False
    End If
  End Sub

  Public Sub ListarGrados(ByVal wNivel As Nivel)
    Dim obj As New RNGrado
    Dim lg As List(Of Grado)

    If cboNivel.SelectedIndex > 0 Then
      lg = obj.Listar(wNivel)
      If lg.Count > 0 Then
        lg.Insert(0, New Grado(0, 0, "Seleccionar todos", 0))
        Me.cboGrado.DisplayMember = "Nombre"
        Me.cboGrado.ValueMember = "Nombre"
        Me.cboGrado.DataSource = lg
        Me.cboGrado.SelectedIndex = 0
      Else
        MessageBox.Show("No se encontraron grados registrados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Me.cboGrado.DataSource = Nothing
        Me.cboGrado.Text = ""
        Me.cboGrado.SelectedIndex = -1
      End If
    Else
      cboGrado.DataSource = Nothing
      cboGrado.SelectedIndex = -1
    End If
  End Sub

  Private Sub frmGenerarCarnet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.txtAnio.Text = moAnioActual.anio.ToString
    Me.ListarNiveles()
    Me.cboNivel.SelectedIndex = 0
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Dim rn As RNGrado
    Dim datos As List(Of Matricula)
    Dim excel As Application = Nothing
    Dim libro As Workbook

    Dim posFrenteS As String() = {"B10", "E10", "B25", "E25", "B40", "E40", "B54", "E54"}
    Dim posPostS As String() = {"F1", "B1", "F14", "B14", "F27", "B27", "F39", "B39"}
    Dim posFrentePI As String() = {"B10", "E10", "B25", "E25", "B40", "E40", "B54", "E54"}
    Dim posPostPI As String() = {"F1", "B1", "F14", "B14", "F27", "B27", "F39", "B39"}

    If Me.ValidarDatos() Then
      rn = New RNGrado
      datos = rn.ListarAlumnosCarnet(New Seccion() With {.Grado = DirectCast(cboGrado.SelectedItem, Grado), .Anio = moAnioActual})
      rn = Nothing

      If datos IsNot Nothing AndAlso datos.Count > 0 Then
        Me.mDialogoGuardar.Filter = "Archivos (*.xlsx)|*.xlsx"
        Me.mDialogoGuardar.FileName = "Carnet - " & cboNivel.Text & " " & cboGrado.Text
        Try
          excel = CrearExcel()

          libro = AbrirPlantilla(excel, mDialogoGuardar, AppDomain.CurrentDomain.BaseDirectory & "Plantillas\carnet.xlsx")
          If libro IsNot Nothing Then
            Me.GenerarCarnets(libro, datos, 8, posFrenteS, posPostS)

            libro.SaveAs(Me.mDialogoGuardar.FileName)
            MessageBox.Show("La generación de carnet terminó exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
          End If
        Catch ex As Exception
          MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
          If excel IsNot Nothing Then
            excel.ScreenUpdating = True
            excel.Quit()
          End If
          excel = Nothing
        End Try
      Else
        MessageBox.Show("No hay datos que exportar", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      End If
    End If
  End Sub

  Private Sub GenerarCarnets(ByVal wLibro As Workbook, ByVal datos As List(Of Matricula), ByVal wNumCarnet As Integer, ByVal wposFrente As String(), ByVal wposPosterior As String())
    Dim Frente As Worksheet = Nothing
    Dim Posterior As Worksheet = Nothing

    For i = 0 To datos.Count - 1
      If i Mod wNumCarnet = 0 Then
        DirectCast(wLibro.Sheets.Item(1), Worksheet).Copy(, wLibro.Sheets.Item(wLibro.Sheets.Count))
        Frente = wLibro.Sheets.Item(wLibro.Sheets.Count)
        Frente.Name = "F - " & (i + 1)
        DirectCast(wLibro.Sheets.Item(2), Worksheet).Copy(, Frente)
        Posterior = wLibro.Sheets.Item(wLibro.Sheets.Count)
        Posterior.Name = "P - " & (i + 1)

        Frente.PageSetup.PrintArea = "$A$1:$E$60"
        Posterior.PageSetup.PrintArea = "$A$1:$H$45"
      End If
      Me.ImprimirCarnet(Frente.Range(wposFrente(i Mod wNumCarnet)), Posterior.Range(wposPosterior(i Mod wNumCarnet)), datos.Item(i))
    Next
    DirectCast(wLibro.Sheets.Item(1), Worksheet).Delete()
    DirectCast(wLibro.Sheets.Item(1), Worksheet).Delete()
  End Sub

  Private Sub ImprimirCarnet(ByVal wFrente As Range, ByVal wPosterior As Range, ByVal wAlumno As Matricula)
    Dim niv As String = ""
    With wAlumno.Alumno
      wFrente.Value = .ApellidoPaterno & " " & .ApellidoMaterno
      wFrente.Offset(2, 0).Value = .Nombre

      wPosterior.Offset(6, 2).Value = .Telefono
    End With
    wFrente.Offset(4, 0).Value = wAlumno.Grado.Numero & " - " & wAlumno.Letra
    'Select Case wAlumno.Grado.Nivel.Nombre
    '  Case "INICIAL"
    '    niv = "PROYECTO OPTIMIST"
    '  Case "PRIMARIA"
    '    niv = "PROYECTO SNIPE"
    '  Case "SECUNDARIA"
    '    niv = "PROYECTO LASER"
    'End Select
    wFrente.Offset(6, 0).Value = wAlumno.Seccion.Grado.Nivel.Nombre

    wPosterior.Value = wAlumno.codigoApoderado.NombreCompleto
    wPosterior.Offset(2, 0).Value = wAlumno.DireccionAlumno
    Select Case wAlumno.DireccionAlumno.Length
      Case Is < 30
        wPosterior.Offset(2, 0).Font.Size = 11
      Case Is < 40
        wPosterior.Offset(2, 0).Font.Size = 9.5
      Case Else
        wPosterior.Offset(2, 0).Font.Size = 8
    End Select

    With wAlumno.Alumno.DireccionActual
      wPosterior.Offset(4, 0).Value = .Departamento
      wPosterior.Offset(4, 2).Value = .Provincia
      wPosterior.Offset(6, 0).Value = .Distrito
    End With

    wPosterior.Worksheet.Range(wPosterior, wPosterior.Offset(0, 2)).Merge()
  End Sub

  Private Function ValidarDatos() As Boolean
    'If cboFormato.SelectedIndex = -1 Then
    '  Me.mError.SetError(cboFormato, "Debe especificar el formato de impresión")
    '  Return False
    'Else
    '  Me.mError.SetError(cboFormato, "")
    'End If

    Return True
  End Function

End Class