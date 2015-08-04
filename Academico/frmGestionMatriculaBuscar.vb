
Public Class frmGestionMatriculaBuscar

  Private est As Boolean = False
  Private M As Matricula

  Private Sub frmGestionarMatriculaBuscar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    If e.KeyCode = Keys.F5 Then
      Me.BuscarMatriculados()
      e.Handled = True
    ElseIf e.KeyCode = Keys.Enter Then
      Seleccionar()
    End If
  End Sub

  Private Sub frmGestionarMatriculaBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cancelar.png")
    Me.btnBuscar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Buscar.png")
    Me.btnSeleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
    Me.dgvmatriculas.DataSource = Nothing
    cargarcbanio()
    cargarcboNivelAcademico()
    cargarcboSeccion()
    Me.btnSeleccionar.Enabled = False
    est = True
  End Sub

  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboNivel.SelectedIndexChanged
    If est = True Then
      cargarcboSeccion()
    End If
  End Sub

  Private Sub cbanio_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbanio.SelectedIndexChanged
    If est = True Then
      cargarcboSeccion()
    End If
  End Sub

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

  Public Sub cargarcboNivelAcademico()
    Dim ListNa As New List(Of Nivel)
    Dim objNa As New RNNivel

    ListNa = objNa.Listar()
    cboNivel.DisplayMember = "nombre"
    cboNivel.ValueMember = "codigoModular"
    cboNivel.DataSource = ListNa
    ListNa = Nothing
  End Sub

  Public Sub cargarcboSeccion()
    Dim ListSec As New List(Of Seccion)
    Dim objS As New RNSeccion

    ListSec = objS.Leer_NivelAcad(CType(cbanio.SelectedItem, AnioLectivo), CType(cboNivel.SelectedItem, Nivel), 1)
    cboSeccion.DisplayMember = "numeroletra"
    cboSeccion.ValueMember = "codigoG"
    cboSeccion.DataSource = ListSec
    ListSec = Nothing
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Me.BuscarMatriculados()
  End Sub

  Private Sub BuscarMatriculados()
    If cboSeccion.SelectedIndex > -1 Then
      Me.Actualizar()
      If Me.dgvmatriculas.RowCount > 0 Then
        Me.btnSeleccionar.Enabled = True
      Else
        Me.btnSeleccionar.Enabled = False
      End If
    Else
      dgvmatriculas.DataSource = Nothing
      Me.btnSeleccionar.Enabled = False
    End If
    Me.dgvmatriculas.Focus()
  End Sub

  Public Sub Actualizar()
    Dim ListMat As New List(Of Matricula)
    Dim objM As New RNMatricula
    Dim objRNmat As New RNMatricula
    Dim objApo As New RNApoderado

    ListMat = objM.Listar(CType(cboSeccion.SelectedItem, Seccion))
    Me.dgvmatriculas.DataSource = Nothing
    dgvmatriculas.AutoGenerateColumns = False
    dgvmatriculas.DataSource = ListMat
    For i = 0 To Me.dgvmatriculas.RowCount - 1
      Dim mat As New Matricula
      mat = CType(Me.dgvmatriculas.Rows(i).DataBoundItem, Matricula)
      Me.dgvmatriculas.Rows(i).Cells("cdalumno").Value = mat.Alumno.NombreCompleto
      Me.dgvmatriculas.Rows(i).Cells("cdApoderado").Value = objApo.LeerApoderadoNombre(New Apoderado(mat.codigoApoderado.Codigo)).NombreCompleto
      Me.dgvmatriculas.Rows(i).Cells("cdfechaMat").Value = mat.Fecha
      mat = Nothing
    Next

  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    M = Nothing
    Me.Close()
  End Sub

  Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
    Dim mat As New Matricula
    If Me.dgvmatriculas.RowCount > 0 Then
      Dim objMat As New RNMatricula
      mat = CType(Me.dgvmatriculas.Rows(Me.dgvmatriculas.CurrentRow.Index).DataBoundItem, Matricula)
      If mat.vigencia = True Then
        objMat.ModificarVigencia(mat.Numero, 0)
      Else
        objMat.ModificarVigencia(mat.Numero, 1)
      End If
      MessageBox.Show("La vigencia de la matrícula fue modificada", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Actualizar()
      mat = Nothing
    End If
  End Sub

  Public Function Buscar() As Matricula
    Me.ShowDialog()
    If M Is Nothing Then
      Return Nothing
    Else
      Return M
    End If
  End Function

  Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click, dgvmatriculas.DoubleClick
    Seleccionar()
  End Sub

  Private Sub Seleccionar()
    If dgvmatriculas.SelectedRows.Count > 0 Then
      Try
        If CType(Me.dgvmatriculas.Rows(Me.dgvmatriculas.CurrentRow.Index).DataBoundItem, Matricula).vigencia Then
          M = CType(Me.dgvmatriculas.Rows(Me.dgvmatriculas.CurrentRow.Index).DataBoundItem, Matricula)
        Else
          M = Nothing
        End If

        Me.Close()
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally

      End Try
    End If
  End Sub

  Private Sub dgvmatriculas_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvmatriculas.SelectionChanged
    Dim posSelect As Integer
    posSelect = Me.dgvmatriculas.Rows.IndexOf(Me.dgvmatriculas.CurrentRow)
    If Me.dgvmatriculas.Item(3, posSelect).Value Is "No" Then
      Me.btnAnular.Text = "Activar &Matricula"
    Else
      Me.btnAnular.Text = "Anular &Matricula"
    End If
  End Sub
End Class