
Public Class frmCargaAcademica

  Private docentes As List(Of Docente)
  Private periodos As List(Of PeriodoAcademico)
  Private alumnos As List(Of Grupo)

  Private Shared frm As frmCargaAcademica
  Private cargasDocente As List(Of DocenteCarga)

  Private Sub New()
    ' This call is required by the designer.
    InitializeComponent()
  End Sub

  Public Shared Function Crear() As frmCargaAcademica
    If frmCargaAcademica.frm Is Nothing Then
      frmCargaAcademica.frm = New frmCargaAcademica
    End If

    Return frmCargaAcademica.frm
  End Function

  Private Sub frmCargaAcademica_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
    frmCargaAcademica.frm = Nothing
  End Sub

  Public Sub Gestionar()
    Me.Show
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Private Sub ListarComboSecciones()
    Dim objS As RNSeccion = New RNSeccion
    Dim ls As List(Of Seccion)

    ls = objS.LeerNivelNumSec(New Seccion(0, moAnioActual.Anio, "*"c))
    If ls.Count > 0 Then
      Me.cboSeccion.DisplayMember = "NivelNumeroLetra"
      Me.cboSeccion.ValueMember = "NivelNumeroLetra"
      Me.cboSeccion.DataSource = ls
    Else
      Me.Close()
      MessageBox.Show("Registre secciones", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub frmCargaAcademica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnNuevo.Visible = True
    Me.btnQuitar.Visible = False
    Me.cboSeleccionar.SelectedIndex = 0
    Me.txtNroAlu.Text = "0"
    Me.txtAnio.Text = moAnioActual.Anio
    Me.ListarComboSecciones()
    Me.ListarPeriodosDataGrid()
    Me.ListarDocentesDataGrid()
  End Sub

  Public Sub ListarPeriodosDataGrid()
    Dim rn As New RNPeriodoAcademico

    Me.periodos = rn.ListarCodPeriodos(moAnioActual)
    rn = Nothing

    With DirectCast(Me.dgvGrupos.Columns.Item("cdPeriodo"), DataGridViewComboBoxColumn)
      .DataSource = Me.periodos
      .ValueMember = "Codigo"
      .DisplayMember = "Nombre"
    End With
  End Sub

  Public Sub ListarDocentesDataGrid()
    Dim rn As New RNDocente

    Me.docentes = rn.Listar()
    rn = Nothing

    With DirectCast(Me.dgvGrupos.Columns.Item("cdDocente"), DataGridViewComboBoxColumn)
      .DataSource = Me.docentes
      .ValueMember = "Codigo"
      .DisplayMember = "NombreCompleto"
    End With
  End Sub

  Private Sub ListarCursos()
    Dim rn As RNCargaAcademica
    Dim pos As Integer = -1
    Dim cursos As List(Of CargaAcademica)

    Me.dgvCargas.DataSource = Nothing
    If Me.cboSeccion.SelectedIndex > -1 Then
      rn = New RNCargaAcademica
      cursos = rn.ListarCargaAsignadadSeccion(DirectCast(Me.cboSeccion.SelectedItem, Seccion))
      rn = Nothing
      Me.dgvCargas.DataSource = Nothing
      If cursos.Count > 0 Then
        Me.dgvCargas.AutoGenerateColumns = False
        Me.dgvCargas.DataSource = cursos
      End If
    End If
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Me.ListarCursos()
  End Sub

  Private Sub dgvCargas_CellContentClick(ByVal sender As System.Object, ByVal e As Object) Handles dgvCargas.CellContentClick, dgvCargas.DoubleClick
    Dim rn As RNDocenteCarga

    Me.cargasDocente = Nothing
    Me.dgvGrupos.DataSource = Nothing
    If Me.dgvCargas.CurrentRow IsNot Nothing Then
      rn = New RNDocenteCarga
      Me.cargasDocente = rn.ListarDocentesCarga(DirectCast(Me.dgvCargas.CurrentRow.DataBoundItem, CargaAcademica))
      rn = Nothing
      If Me.cargasDocente.Count > 0 Then
        Me.dgvGrupos.AutoGenerateColumns = False
        Me.dgvGrupos.DataSource = Me.cargasDocente
      End If
    Else
      MessageBox.Show("Debe seleccionar un curso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub btnAlumnos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlumnos.Click, dgvGrupos.DoubleClick
    Dim rn As RNDocenteCarga
    Dim docente As DocenteCarga = DirectCast(Me.dgvGrupos.CurrentRow.DataBoundItem, DocenteCarga)

    If Me.dgvGrupos.CurrentRow IsNot Nothing AndAlso Docente.Codigo > 0 Then
      rn = New RNDocenteCarga
      Me.alumnos = rn.ListarAlumnos(Docente)
      rn = Nothing

      Me.dgvAlumnos.AutoGenerateColumns = False
      Me.dgvAlumnos.DataSource = Me.alumnos
      Me.txtNroAlu.Text = Me.alumnos.Count.ToString
    Else
      Me.dgvAlumnos.DataSource = Nothing
    End If
  End Sub

  Private Sub dgAlumnos_RowPrePaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgvAlumnos.RowPrePaint
    With Me.dgvAlumnos.Rows.Item(e.RowIndex)
      If DirectCast(.DataBoundItem, Grupo).Asignado = True Then
        .DefaultCellStyle.BackColor = Color.Yellow
      End If
    End With
  End Sub

  Private Sub dgvAlumnos_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAlumnos.CellValueChanged
    If e.ColumnIndex = 2 AndAlso Me.dgvAlumnos.DataSource IsNot Nothing Then
      With Me.dgvAlumnos.Rows.Item(e.RowIndex)
        If CBool(.Cells.Item(e.ColumnIndex).Value) = True Then
          .DefaultCellStyle.BackColor = Color.Yellow
        Else
          .DefaultCellStyle.BackColor = Color.White
        End If
      End With
    End If
  End Sub

  Private Sub btnConfigurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfigurar.Click
    Dim rn As RNDocenteCarga
    Dim doc As DocenteCarga

    doc = DirectCast(Me.dgvGrupos.CurrentRow.DataBoundItem, DocenteCarga)
    rn = New RNDocenteCarga
    Try
      If doc.Codigo > -1 Then
        rn.RegistrarAlumnos(Me.alumnos)
      Else
        doc.Alumnos = Me.alumnos
        doc.Codigo = rn.RegistrarDocenteCarga(doc)
      End If
      MessageBox.Show("La asignación de alumnos se realizó exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      rn = Nothing
    End Try
  End Sub

  Private Sub dgvCargas_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCargas.SelectionChanged
    Me.cargasDocente = Nothing
    Me.dgvGrupos.DataSource = Nothing
    Me.dgvAlumnos.DataSource = Nothing
  End Sub

  Private Sub dgvGrupos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGrupos.CellContentClick
    Me.dgvAlumnos.DataSource = Nothing
  End Sub

  Private Sub cboSeleccionar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSeleccionar.SelectedIndexChanged
    Dim sexo As String

    If Me.alumnos IsNot Nothing AndAlso Me.cboSeleccionar.SelectedIndex > -1 Then
      sexo = DirectCast(Me.dgvAlumnos.CurrentRow.DataBoundItem, Grupo).Matricula.Alumno.Sexo
      Me.dgvAlumnos.DataSource = Nothing
      Select Case Me.cboSeleccionar.SelectedIndex
        Case 1
          For Each gr As Grupo In Me.alumnos
            gr.Asignado = False
          Next
        Case 2
          For Each gr As Grupo In Me.alumnos
            If sexo = gr.Matricula.Alumno.Sexo Then
              gr.Asignado = True
            Else
              gr.Asignado = False
            End If
          Next
        Case 3
          For Each gr As Grupo In Me.alumnos
            gr.Asignado = True
          Next
      End Select
      Me.dgvAlumnos.AutoGenerateColumns = False
      Me.dgvAlumnos.DataSource = Me.alumnos
    End If
  End Sub

  Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
    Dim doc As New DocenteCarga With {.Codigo = -1}
    Dim per As PeriodoAcademico
    Dim docente As Docente

    If Me.cargasDocente IsNot Nothing Then
      Me.dgvGrupos.DataSource = Nothing
      If Me.cargasDocente IsNot Nothing AndAlso Me.cargasDocente.Count > 0 Then
        With Me.cargasDocente.Item(Me.cargasDocente.Count - 1)
          per = .Periodo
          docente = .Docente
          doc.Periodo = New PeriodoAcademico With {.Codigo = per.Codigo, .Nombre = per.Nombre, .Anio = per.Nombre}
          doc.Docente = New Docente With {.Codigo = docente.Codigo, .Nombre = docente.Nombre,
                                          .ApellidoPaterno = docente.ApellidoPaterno, .ApellidoMaterno = docente.ApellidoMaterno}
          'doc.Carga = DirectCast(Me.dgvCargas.CurrentRow.DataBoundItem, CargaAcademica)
        End With
      Else
        doc.Periodo = Me.periodos.Item(0)
        doc.Docente = Me.docentes.Item(0)
      End If
      doc.Carga = DirectCast(Me.dgvCargas.CurrentRow.DataBoundItem, CargaAcademica)
      If doc.Carga.Curso.Grupo = False Then
        doc.Nombre = "UNICO"
      End If
      Me.cargarAlumnos(doc)
      Me.cargasDocente.Add(doc)
      Me.dgvGrupos.AutoGenerateColumns = False
      Me.dgvGrupos.DataSource = Me.cargasDocente
      Me.dgvGrupos.Rows.Item(Me.dgvGrupos.Rows.Count - 1).Selected = True
    Else
      MessageBox.Show("Debe seleccionar un curso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub cargarAlumnos(ByVal wDoc As DocenteCarga)
    Dim rn As New RNMatricula
    Dim matriculados As List(Of Matricula)

    Me.dgvAlumnos.DataSource = Nothing
    matriculados = rn.ListarAlumno(DirectCast(Me.cboSeccion.SelectedItem, Seccion))
    If Me.alumnos IsNot Nothing Then
      Me.alumnos.Clear()
    Else
      Me.alumnos = New List(Of Grupo)
    End If
    For Each mat As Matricula In matriculados
      Me.alumnos.Add(New Grupo With {.Matricula = mat,
                                     .Asignado = False,
                                     .DocenteCarga = wDoc})
    Next

    Me.dgvAlumnos.AutoGenerateColumns = False
    Me.dgvAlumnos.DataSource = Me.alumnos
  End Sub

  Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
    Dim docenteCarga As DocenteCarga
    Dim rn As RNDocenteCarga

    If Me.dgvGrupos.CurrentRow IsNot Nothing Then
      docenteCarga = DirectCast(Me.dgvGrupos.CurrentRow.DataBoundItem, DocenteCarga)
      rn = New RNDocenteCarga
      Try
        If docenteCarga.Codigo > 0 Then
          rn.Actualizar(docenteCarga)
          MessageBox.Show("Los datos se actualizaron con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
          rn.Registrar(docenteCarga)
          MessageBox.Show("Los datos se registraron con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        rn = Nothing
      End Try
    Else
      MessageBox.Show("Debe seleccionar un grupo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

End Class
