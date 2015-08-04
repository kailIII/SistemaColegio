
Public Class frmGenerarNumerosOrden

  Public Sub cargarcbanio()
    Dim ListAn As New List(Of AnioLectivo)
    Dim objAn As New RNAnioLectivo
    Dim al As New AnioLectivo

    al.vigencia = True
    ListAn = objAn.Leer(al)
    cbanio.DisplayMember = "anio"
    cbanio.ValueMember = "anio"
    cbanio.DataSource = ListAn
    cbanio.SelectedIndex = ListAn.Count - 1
    ListAn = Nothing
  End Sub
  Public Sub LlenarSecciones()
    Dim ListSec As New List(Of Seccion)
    Dim objS As New RNSeccion
    ListSec = objS.Leer_Anio(CType(Me.cbanio.SelectedItem, AnioLectivo))
    dgvSeccion.AutoGenerateColumns = False
    dgvSeccion.DataSource = ListSec
    ListSec = Nothing
  End Sub
  Public Sub IniciarFormulario()
    cargarcbanio()
    LlenarSecciones()
    cambiarcheck(True)
    Me.cboSeleccion.SelectedIndex = 0
    Me.Show()
  End Sub

  Private Sub frmGenerarNumerosOrden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    IniciarFormulario()
  End Sub

  Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    Me.Close()
  End Sub

  Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
    Dim frm As New frmListarAlumno
    Dim sec As New Seccion
    Dim objMat As New RNMatricula
    Dim ListMat As New List(Of Matricula)

    If Me.dgvSeccion.RowCount > 0 Then
      sec = CType(Me.dgvSeccion.Rows(Me.dgvSeccion.CurrentRow.Index).DataBoundItem, Seccion)
      sec.Anio = CType(Me.cbanio.SelectedItem, AnioLectivo)
      frm.txtseccion.Text = sec.NumeroLetra
      frm.txtnivel.Text = sec.Grado.Nivel.Nombre
      frm.dgvalumno.AutoGenerateColumns = False
      ListMat = objMat.ListarAlumno(sec)
      frm.dgvalumno.DataSource = ListMat
      ListMat = Nothing
      frm.ShowDialog()
    Else
      MessageBox.Show("No hay datos en la tabla", "Generar números de orden", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If

  End Sub
  Public Function verificarSeleccion() As Boolean
    For i = 0 To dgvSeccion.Rows.Count - 1
      If CBool(dgvSeccion.Rows(i).Cells("colgenerar").Value) = False Then
        Return False
      End If
    Next
    Return True
  End Function

  Public Sub GenerarSecciones()
    Dim objMat As New RNMatricula
    Dim sec As New Seccion
    Try
      For i = 0 To dgvSeccion.Rows.Count - 1
        Try
          If CBool(dgvSeccion.Rows(i).Cells("colgenerar").Value) = True Then
            sec.Anio = CType(Me.cbanio.SelectedItem, AnioLectivo)
            sec.Grado = CType(Me.dgvSeccion.Rows(i).Cells("colcodigoG").Value, Grado)
            sec.Letra = CChar(Me.dgvSeccion.Rows(i).Cells("colletra").Value)
            objMat.GenerarNumerodeOrden(sec)
            dgvSeccion.Rows(i).Cells("colimagen").Value = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "\Imagenes\exito.png")
            dgvSeccion.Rows(i).Cells("colresultado").Value = "Generacion Correcta..."
          End If
        Catch ex As Exception
          MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      Next
      MessageBox.Show("Los Numeros de Orden se generaron exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub
  Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
    If Me.dgvSeccion.RowCount > 0 Then
      GenerarSecciones()
    Else
      MessageBox.Show("No hay datos en la tabla", "Generar números de orden", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub
  Public Sub cambiarcheck(ByVal estado As Boolean)
    For i = 0 To dgvSeccion.Rows.Count - 1
      dgvSeccion.Rows(i).Cells("colgenerar").Value = estado
    Next
  End Sub

  Private Sub cbanio_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbanio.SelectedIndexChanged
    LlenarSecciones()
    cambiarcheck(True)
  End Sub
  Public Sub cambiarcheckGrado()
    Dim sec As New Seccion
    Dim secactual As New Seccion
    secactual = CType(Me.dgvSeccion.Rows(Me.dgvSeccion.CurrentRow.Index).DataBoundItem, Seccion)
    If Me.dgvSeccion.CurrentRow.Index > -1 Then
      For i = 0 To Me.dgvSeccion.Rows.Count - 1
        sec = CType(Me.dgvSeccion.Rows(i).DataBoundItem, Seccion)
        If sec.Grado.Numero = secactual.Grado.Numero Then
          Me.dgvSeccion.Rows(i).Cells("colgenerar").Value = True
        Else
          Me.dgvSeccion.Rows(i).Cells("colgenerar").Value = False
        End If
        sec = Nothing
      Next
    End If
  End Sub
  Public Sub cambiarcheckNivel()
    Dim sec As New Seccion
    Dim secactual As New Seccion
    secactual = CType(Me.dgvSeccion.Rows(Me.dgvSeccion.CurrentRow.Index).DataBoundItem, Seccion)
    If Me.dgvSeccion.CurrentRow.Index > -1 Then
      For i = 0 To Me.dgvSeccion.Rows.Count - 1
        sec = CType(Me.dgvSeccion.Rows(i).DataBoundItem, Seccion)
        If sec.NombreNivel = secactual.NombreNivel Then
          Me.dgvSeccion.Rows(i).Cells("colgenerar").Value = True
        Else
          Me.dgvSeccion.Rows(i).Cells("colgenerar").Value = False
        End If
        sec = Nothing
      Next
    End If
  End Sub

  Private Sub cboSeleccion_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSeleccion.SelectedValueChanged
    If dgvSeccion.RowCount > 0 Then
      Select Case Me.cboSeleccion.Text
        Case "Seleccionar Todos"
          cambiarcheck(True)
        Case "Seleccionar Ninguno"
          cambiarcheck(False)
        Case "Seleccionar mismo grado"
          cambiarcheckGrado()
        Case "Seleccionar mismo nivel"
          cambiarcheckNivel()
      End Select
    End If
  End Sub

End Class
