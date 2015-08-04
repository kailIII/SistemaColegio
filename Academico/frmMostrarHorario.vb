Public Class frmMostrarHorario

  Private Sub MostrarHorario()
    Dim S As Seccion
    Dim i As Integer
    Dim dia As String
    Dim ListHorario As New List(Of Horario)
    Dim objH As New RNHorario
    Dim H As Horario
    Dim horas As Date
    Dim cadena As String = ""

    dgvHorario.Rows.Clear()
    horas = New Date(1, 1, 1, 7, 0, 0)
    dgvHorario.Columns("cdLunes").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    dgvHorario.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    For i = 0 To 9
      Me.dgvHorario.Rows.Add()
      With Me.dgvHorario
        .Rows(i).Cells("cdHora").Value = horas
        .Rows(i).Cells("cdLunes").Value = cadena
        .Rows(i).Cells("cdMartes").Value = cadena
        .Rows(i).Cells("cdMiercoles").Value = cadena
        .Rows(i).Cells("cdJueves").Value = cadena
        .Rows(i).Cells("cdViernes").Value = cadena
      End With
      horas = horas.AddMinutes(My.Settings.Hora)
    Next

    S = CType(cboSeccion.SelectedItem, Seccion)
    ListHorario = objH.ListarHorario_Seccion(S)
    i = 0
    For Each H In ListHorario
      If ConvertirDia(H.dia) = "Lunes" Then
        dia = "cdLunes"
        For i = 0 To dgvHorario.RowCount - 1
          If CType(dgvHorario.Rows(i).Cells("cdHora").Value, Date) = CDate(FormatDateTime(H.horaIni, DateFormat.ShortTime)) Or _
              CType(dgvHorario.Rows(i).Cells("cdHora").Value, Date) = CDate(FormatDateTime(H.horaFin, DateFormat.ShortTime)) Or _
              CDate(FormatDateTime(H.horaIni, DateFormat.ShortTime)) < CType(dgvHorario.Rows(i).Cells("cdHora").Value, Date) And _
              CDate(FormatDateTime(H.horaFin, DateFormat.ShortTime)) > CType(dgvHorario.Rows(i).Cells("cdHora").Value, Date) Then
            With Me.dgvHorario
              .Rows(i).Cells(dia).Value = H.Carga.CursoNombre ' & "-" & H.Aula.NombreCompletoAula
            End With
          End If
        Next
      ElseIf ConvertirDia(H.dia) = "Martes" Then
        dia = "cdMartes"
        For i = 0 To dgvHorario.RowCount - 1
          If CType(dgvHorario.Rows(i).Cells("cdHora").Value, Date) = CDate(FormatDateTime(H.horaIni, DateFormat.ShortTime)) Or _
              CType(dgvHorario.Rows(i).Cells("cdHora").Value, Date) = CDate(FormatDateTime(H.horaFin, DateFormat.ShortTime)) Or _
              CDate(FormatDateTime(H.horaIni, DateFormat.ShortTime)) < CType(dgvHorario.Rows(i).Cells("cdHora").Value, Date) And _
              CDate(FormatDateTime(H.horaFin, DateFormat.ShortTime)) > CType(dgvHorario.Rows(i).Cells("cdHora").Value, Date) Then
            With Me.dgvHorario
              .Rows(i).Cells(dia).Value = H.Carga.CursoNombre & "-" & H.Aula.NombreCompletoAula
            End With
          End If
        Next
      ElseIf ConvertirDia(H.dia) = "Miercoles" Then
        dia = "cdMiercoles"
        For i = 0 To dgvHorario.RowCount - 1
          If CType(dgvHorario.Rows(i).Cells("cdHora").Value, Date) = CDate(FormatDateTime(H.horaIni, DateFormat.ShortTime)) Or _
              CType(dgvHorario.Rows(i).Cells("cdHora").Value, Date) = CDate(FormatDateTime(H.horaFin, DateFormat.ShortTime)) Or _
              CDate(FormatDateTime(H.horaIni, DateFormat.ShortTime)) < CType(dgvHorario.Rows(i).Cells("cdHora").Value, Date) And _
              CDate(FormatDateTime(H.horaFin, DateFormat.ShortTime)) > CType(dgvHorario.Rows(i).Cells("cdHora").Value, Date) Then

            With Me.dgvHorario
              .Rows(i).Cells(dia).Value = H.Carga.CursoNombre & "-" & H.Aula.NombreCompletoAula
            End With
          End If
        Next
      ElseIf ConvertirDia(H.dia) = "Jueves" Then
        dia = "cdJueves"
        For i = 0 To dgvHorario.RowCount - 1
          If CType(dgvHorario.Rows(i).Cells("cdHora").Value, Date) = CDate(FormatDateTime(H.horaIni, DateFormat.ShortTime)) Or _
              CType(dgvHorario.Rows(i).Cells("cdHora").Value, Date) = CDate(FormatDateTime(H.horaFin, DateFormat.ShortTime)) Or _
              CDate(FormatDateTime(H.horaIni, DateFormat.ShortTime)) < CType(dgvHorario.Rows(i).Cells("cdHora").Value, Date) And _
              CDate(FormatDateTime(H.horaFin, DateFormat.ShortTime)) > CType(dgvHorario.Rows(i).Cells("cdHora").Value, Date) Then
            With Me.dgvHorario
              .Rows(i).Cells(dia).Value = H.Carga.CursoNombre & "-" & H.Aula.NombreCompletoAula
            End With
          End If
        Next
      ElseIf ConvertirDia(H.dia) = "Viernes" Then
        dia = "cdViernes"
        For i = 0 To dgvHorario.RowCount - 1
          If CType(dgvHorario.Rows(i).Cells("cdHora").Value, Date) = CDate(FormatDateTime(H.horaIni, DateFormat.ShortTime)) Or _
              CType(dgvHorario.Rows(i).Cells("cdHora").Value, Date) = CDate(FormatDateTime(H.horaFin, DateFormat.ShortTime)) Or _
              CDate(FormatDateTime(H.horaIni, DateFormat.ShortTime)) < CType(dgvHorario.Rows(i).Cells("cdHora").Value, Date) And _
              CDate(FormatDateTime(H.horaFin, DateFormat.ShortTime)) > CType(dgvHorario.Rows(i).Cells("cdHora").Value, Date) Then
            With Me.dgvHorario
              .Rows(i).Cells(dia).Value = H.Carga.CursoNombre & "-" & H.Aula.NombreCompletoAula
            End With
          End If
        Next
      End If
    Next

  End Sub

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    MostrarHorario()
  End Sub

  

  Private Sub DataGridView1_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgvHorario.CellPainting
    'por ejemplo, fusionar verticalmente las mismas células de la cuarta columna, 
    If e.ColumnIndex > 0 And e.ColumnIndex <= 5 AndAlso e.RowIndex <> -1 Then
      Using gridBrush As Brush = New SolidBrush(Me.dgvHorario.GridColor), backColorBrush As Brush = New SolidBrush(e.CellStyle.BackColor)
        Using gridLinePen As Pen = New Pen(gridBrush)
          ' Clear cell  
          e.Graphics.FillRectangle(backColorBrush, e.CellBounds)
          'Dibuja una línea (borde inferior y el borde derecho de la celda actual)  
          'Si la célula siguiente fila tiene un contenido diferente, sólo llamar la línea del borde inferior de la celda actual 
          If e.RowIndex < dgvHorario.Rows.Count - 1 AndAlso dgvHorario.Rows(e.RowIndex + 1).Cells(e.ColumnIndex).Value.ToString() <> e.Value.ToString() Then
            e.Graphics.DrawLine(Pens.Blue, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right - 1, e.CellBounds.Bottom - 1)
          End If
          'Dibujar la línea del borde derecho de la celda actual 
          e.Graphics.DrawLine(Pens.Blue, e.CellBounds.Right - 1, e.CellBounds.Top, e.CellBounds.Right - 1, e.CellBounds.Bottom)
          'Draw / llenar de contenido en la celda actual, y llenar una sola célula de múltiples mismas células
          If Not e.Value Is Nothing Then
            If e.RowIndex > 0 AndAlso dgvHorario.Rows(e.RowIndex - 1).Cells(e.ColumnIndex).Value.ToString() = e.Value.ToString() Then
              'Dim f As StringFormat

              'f = DirectCast(StringFormat.GenericDefault.Clone, StringFormat)
              'f.Alignment = StringAlignment.Center
              'e.Graphics.DrawString("Hola", e.CellStyle.Font, Brushes.Blue, e.CellBounds.X + 2, e.CellBounds.Y + 5, f)
            Else
              Dim f As StringFormat

              f = DirectCast(StringFormat.GenericDefault.Clone, StringFormat)
              f.Alignment = StringAlignment.Center

              e.Graphics.DrawString(CType(e.Value, String), e.CellStyle.Font, Brushes.Blue, e.CellBounds.X + 2, e.CellBounds.Y + 5, f)
            End If
          End If
          e.Handled = True
        End Using
      End Using
    End If

  End Sub

  Public Sub cargarcboNivelAcademico()
    Dim ListNa As New List(Of Nivel)
    Dim objNa As New RNNivel
    ListNa = objNa.Listar()
    If ListNa.Count > 0 Then
      cboNivel.DisplayMember = "nombre"
      cboNivel.ValueMember = "codigoModular"
      cboNivel.DataSource = ListNa
    Else
      ListNa = Nothing
    End If
  End Sub
  Public Sub cargarcboSeccion()
    Dim ListSec As New List(Of Seccion)
    Dim objS As New RNSeccion
    If cboNivel.SelectedIndex > -1 Then
      ListSec = objS.Leer_NivelAcad(moAnioActual, CType(cboNivel.SelectedItem, Nivel), 1)
      If ListSec.Count >= 0 Then
        cboSeccion.DisplayMember = "numeroletra"
        cboSeccion.ValueMember = "codigoGrado"
        cboSeccion.DataSource = ListSec
      Else
        ListSec = Nothing
      End If
    End If
  End Sub
  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboNivel.SelectedIndexChanged

    If cboNivel.SelectedIndex > -1 Then
      cargarcboSeccion()
    End If

  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Close()
  End Sub

  Function ConvertirDia(ByVal letra As String) As String
    Dim dia As String = ""
    Select Case letra
      Case "L"
        dia = "Lunes"
      Case "M"
        dia = "Martes"
      Case "I"
        dia = "Miercoles"
      Case "J"
        dia = "Jueves"
      Case "V"
        dia = "Viernes"
      Case "S"
        dia = "Sabado"
      Case "D"
        dia = "Domingo"
    End Select

    Return dia
  End Function

  Public Sub Mostrar(ByVal wnivel As Integer, ByVal wgrado As Integer)
    cargarcboNivelAcademico()
    cargarcboSeccion()
    If cboNivel.Items.Count > 0 Then
      Me.cboNivel.SelectedIndex = wnivel
      'Me.cboSeccion.SelectedIndex = wgrado
    End If
    If cboSeccion.Items.Count > 0 Then
      Me.cboSeccion.SelectedIndex = wgrado
      MostrarHorario()
    End If

    Me.ShowDialog()
  End Sub

End Class