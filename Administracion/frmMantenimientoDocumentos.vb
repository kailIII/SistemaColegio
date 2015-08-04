Public Class frmMantenimientoDocumentos

  Private mOPersona As Persona
  Private mOMatricula As Matricula
  Private mODocumentos As New List(Of DocumentoIngresoSeleccionar)

  Public Sub CargarIconos()
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
  End Sub

  Private Sub frmAnularRecibo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.CargarIconos()
  End Sub

  Public Sub cargarDatos()
    Me.cboEntidad.SelectedIndex = 0
    Me.IniciarFechas()
    Me.bloquardesbloquea(False)
    Me.Show()
  End Sub

  Public Sub IniciarFechas()
    Me.dtfechaMay.Value = CDate(Now.Day.ToString + "-" + Now.Month.ToString + "-" + Now.Year.ToString + " 23:59")
    Me.dtfechaMen.Value = CDate(Now.Day.ToString + "-" + Now.Month.ToString + "-" + Now.Year.ToString + " 00:00")
  End Sub

  Public Sub bloquardesbloquea(ByVal est As Boolean)
    For Each Control As Control In gbDetalleDoc.Controls
      Control.Enabled = est
    Next
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub

  Public Sub cargarDatosAlumno()
    Dim objmat As New RNMatricula
    Dim frm As New frmBuscarPersona

    Me.mOPersona = frm.Buscar()
    If Me.mOPersona IsNot Nothing Then

      mOPersona = Me.mOPersona
      Me.dgvRecibos.DataSource = Nothing
      mODocumentos.Clear()
      Me.txtNombre.Text = mOPersona.NombreCompleto
      mOMatricula = objmat.LeerMatriculaxGradoSeccion(New Alumno(Me.mOPersona.Codigo))
      If mOMatricula IsNot Nothing Then
        Me.txtGradoSec.Text = mOMatricula.GradoSeccion
      Else
        Me.txtGradoSec.Text = ""
      End If
      Me.txtNombre.Focus()

    End If
  End Sub

  Private Sub btnBuscarAlumno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarAlumno.Click
    cargarDatosAlumno()
    If Not mOPersona Is Nothing Then

    End If
  End Sub

  Public Sub Bloquear(ByVal gb As GroupBox, ByVal val As Boolean)
    For Each elem As Control In gb.Controls
      elem.Enabled = val
    Next
  End Sub

  Public Sub LimpiarControl()
    For Each elem As Control In gbAlumno.Controls
      If TypeOf elem Is TextBox Then
        elem.Text = ""
      End If
    Next
    Me.dtfechaMen.Value = Now
    Me.dtfechaMay.Value = Now
    Me.dgvRecibos.DataSource = Nothing
    Me.mODocumentos.Clear()
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim objRNDoc As New RNDocumentoIngreso
    Dim ent As String = ""
    Dim per As Persona = Nothing
    Dim documentos As List(Of DocumentoIngreso)

    If cboEntidad.SelectedIndex > 0 Then
      ent = cboEntidad.Text.Substring(0, 1)
    End If
    If chkAlumno.Checked = True AndAlso Me.mOPersona IsNot Nothing Then
      per = Me.mOPersona
    End If

    documentos = objRNDoc.Listar_PeriodoPersona(Me.dtfechaMen.Value, Me.dtfechaMay.Value, ent, per)
    objRNDoc = Nothing

    Me.dgvRecibos.DataSource = Nothing
    If documentos.Count > 0 Then
      Me.mODocumentos.Clear()
      For Each doc As DocumentoIngreso In documentos
        Me.mODocumentos.Add(New DocumentoIngresoSeleccionar With {.DocumentoIngreso = doc})
      Next
      Me.dgvRecibos.AutoGenerateColumns = False
      Me.dgvRecibos.DataSource = mODocumentos
      Me.bloquardesbloquea(True)
      Me.dgvRecibos.Focus()
    Else
      MessageBox.Show("No existen documentos de ingreso", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End If
  End Sub

  Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Me.CambiarEstado(False)
  End Sub

  Private Sub CambiarEstado(ByVal wEstado As Boolean)
    Dim rn As RNDocumentoIngreso
    Dim accion As String

    If wEstado = True Then
      accion = "activar"
    Else
      accion = "anular"
    End If
    If MessageBox.Show("¿Está seguro que desea " & accion & "?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
      rn = New RNDocumentoIngreso
      Try
        For Each sel As DocumentoIngresoSeleccionar In Me.mODocumentos
          If sel.Seleccionado = True Then
            sel.DocumentoIngreso.Vigencia = wEstado
            rn.AnularRecibo(sel.DocumentoIngreso)
          End If
        Next

        Me.btnListar.PerformClick()
        MessageBox.Show("La operación se realizó exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Catch ex As Exception
        MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        rn = Nothing
      End Try
    End If
  End Sub

  Private Sub chkAlumno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAlumno.CheckedChanged
    Me.gbAlumno.Enabled = chkAlumno.Checked
  End Sub

  'Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click, dgvRecibos.DoubleClick
  '  Dim doc As DocumentoIngreso
  '  Dim mat As Matricula
  '  Dim detalles As List(Of VistaDetalleDocumentoIngreso)

  '  If Me.dgvRecibos.CurrentRow IsNot Nothing Then
  '    doc = DirectCast(Me.dgvRecibos.CurrentRow.DataBoundItem, DocumentoIngresoSeleccionar).DocumentoIngreso

  '    Try
  '      detalles = Me.ObtenerDetalles(doc)
  '      mat = Me.ObtenerMatricula(doc.CodigoPersona, doc.Fecha.Year)

  '      If modImprimirDocumento.VerVistaPrevia(doc, mat, detalles) = True Then
  '        'crpDocumento.PrintToPrinter(1, False, 1, 1)'***********
  '      End If

  '    Catch ex As Exception
  '      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
  '    End Try
  '  Else
  '    MessageBox.Show("Debe seleccionar un documento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
  '  End If
  'End Sub

  Private Function ObtenerDetalles(ByVal wDocumento As DocumentoIngreso) As List(Of VistaDetalleDocumentoIngreso)
    Dim rn As RNDocumentoIngreso
    Dim dets As List(Of DetalleDocumentoIngreso)
    Dim vistaDets As List(Of VistaDetalleDocumentoIngreso)

    rn = New RNDocumentoIngreso
    dets = rn.ListarDetalles(wDocumento)
    rn = Nothing
    vistaDets = New List(Of VistaDetalleDocumentoIngreso)
    For Each d In dets
      vistaDets.Add(New VistaDetalleDocumentoIngreso)
      With vistaDets.Item(vistaDets.Count - 1)
        .Seleccionado = True
        .Numero = d.Numero
        .Descripcion = d.Descripcion
        .Monto = d.Monto
        If d.Obligacion IsNot Nothing Then
          .Beneficio = New Beneficio With {.Descuento = d.Obligacion.Monto}
        End If
      End With
    Next

    Return vistaDets
  End Function

  Private Function ObtenerMatricula(ByVal wPersona As Integer, ByVal wAnio As Integer) As Matricula
    Dim rn As New RNMatricula
    Dim mat As Matricula = Nothing

    mat = rn.Leer(New Alumno With {.Codigo = wPersona}, New AnioLectivo With {.Anio = wAnio.ToString})
    rn = Nothing

    Return mat
  End Function

  Private Sub btnActivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Me.CambiarEstado(True)
  End Sub

  Private Sub chkSeleccionarTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSeleccionarTodos.CheckedChanged
    Dim sel As Boolean = Me.chkSeleccionarTodos.Checked

    If Me.mODocumentos IsNot Nothing Then
      Me.dgvRecibos.DataSource = Nothing
      For Each doc As DocumentoIngresoSeleccionar In Me.mODocumentos
        doc.Seleccionado = sel
      Next
      Me.dgvRecibos.AutoGenerateColumns = False
      Me.dgvRecibos.DataSource = Me.mODocumentos
    End If
  End Sub

  Private Sub dgvRecibos_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRecibos.Leave
    Me.dgvRecibos.EndEdit()
  End Sub

End Class