Public Class frmEstadoCuenta

  Private Persona As Persona
  Private Matricula As New Matricula
  Private EstadoCuenta As List(Of DetalleEstadoCuentaSeleccionar)

  Private mControlError As ErrorProvider

  Public WriteOnly Property ControlError() As ErrorProvider
    Set(ByVal value As ErrorProvider)
      Me.mControlError = value
    End Set
  End Property

  Private Sub frmEstadoCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.CargarImagenes()
  End Sub

  Public Sub Presentar()
    Me.Show()
  End Sub

  Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    Me.CargarDatosAlumno()
  End Sub

  Public Sub CargarDatosAlumno()
    Dim frm As New frmBuscarPersona

    frm.ControlError = Me.mControlError
    Me.Persona = frm.Buscar()
    If Me.Persona IsNot Nothing Then
      Me.txtNombre.Text = Persona.NombreCompleto
      If TypeOf Me.Persona Is Alumno Then
        Me.MostrarMatriculas()
        Me.txtCodigo.Text = DirectCast(Me.Persona, Alumno).CodigoRecaudacion.Trim
      Else
        Me.chkAnio.Enabled = False
        Me.cboMatriculas.Enabled = False
        Me.cboMatriculas.SelectedIndex = -1
        Me.lblSeccion.Enabled = False
        Me.txtSeccion.Enabled = False
        Me.txtCodigo.Text = ""
      End If
      Me.MostrarEstadoCuenta(Me.Persona)
    End If
  End Sub

  Private Sub MostrarEstadoCuenta(ByVal wPersona As Persona)
    Dim rnPer As New RNPersona
    Dim estado As List(Of DetalleEstadoCuenta)
    Dim deuda As Double = 0
    Dim total As Double = 0

    estado = rnPer.EstadoCuenta(Me.Persona)
    Me.EstadoCuenta = Nothing
    Me.EstadoCuenta = New List(Of DetalleEstadoCuentaSeleccionar)
    For Each det In estado
      Me.EstadoCuenta.Add(New DetalleEstadoCuentaSeleccionar())
      With Me.EstadoCuenta.Item(Me.EstadoCuenta.Count - 1)
        .Obligacion = det.Obligacion
        .DetallePago = det.DetallePago
        .Saldo = det.Saldo

        If .Obligacion IsNot Nothing AndAlso _
            DateAndTime.DateDiff(DateInterval.Day, DateAndTime.Now, .Obligacion.FechaVencimiento) <= 0 Then

          deuda += .Saldo
          Me.txtDeuda.Text = deuda.ToString("0.00")
        End If
        total += .Saldo
        Me.txtTotal.Text = total.ToString("0.00")
      End With
    Next

    Me.chkAnio.Checked = False
    Me.cboVer.SelectedIndex = 0
    Me.cboEntidad.SelectedIndex = 0

    Me.Filtrar("", cboVer.SelectedIndex, cboEntidad.SelectedIndex)
    Me.SeleccionarObligacionSinPagar()
  End Sub

  Private Sub SeleccionarObligacionSinPagar()
    Dim pos As Integer = -1

    If Me.dgvObligaciones.Rows.Count > 0 Then
      For Each fila As DataGridViewRow In Me.dgvObligaciones.Rows
        With DirectCast(fila.DataBoundItem, DetalleEstadoCuentaSeleccionar)
          If .Obligacion IsNot Nothing AndAlso .Obligacion.Vigencia = True AndAlso .DetallePago Is Nothing Then
            pos = fila.Index
            Exit For
          End If
        End With
      Next
      If pos > -1 Then
        Me.dgvObligaciones.CurrentCell = Me.dgvObligaciones.Rows.Item(pos).Cells(0)
      Else
        Me.dgvObligaciones.CurrentCell = Me.dgvObligaciones.Rows.Item(Me.dgvObligaciones.Rows.Count - 1).Cells(0)
      End If
    End If
    Me.dgvObligaciones.Focus()
  End Sub

  Private Sub MostrarMatriculas()
    Dim oMat As New RNMatricula
    Dim lm As List(Of Matricula)

    lm = oMat.Listar(DirectCast(Me.Persona, Alumno))
    oMat = Nothing
    If lm.Count > 0 Then
      With lm.Item(lm.Count - 1)
        txtSeccion.Text = .GradoSeccion
      End With
      chkAnio.Enabled = True
    Else
      txtSeccion.Text = ""
      chkAnio.Enabled = False
    End If

    cboMatriculas.DisplayMember = "VerAnio"
    cboMatriculas.ValueMember = "Numero"
    cboMatriculas.DataSource = lm

    chkAnio.Checked = False
    cboMatriculas.Enabled = False
    cboMatriculas.SelectedIndex = -1
  End Sub

  Public Sub CargarImagenes()
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnBuscar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Buscar.png")
    Me.btnImprimir.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\imprimir.png")
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
    Me.Dispose()
  End Sub

  Private Sub chkVerSolo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAnio.CheckedChanged

    If chkAnio.Checked = False Then
      cboMatriculas.Enabled = False
      Me.Filtrar("", cboVer.SelectedIndex, cboEntidad.SelectedIndex)
    Else
      cboMatriculas.Enabled = True
      cboMatriculas.SelectedIndex = -1
      cboMatriculas.Focus()
    End If
  End Sub

  Private Sub cboMatriculas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMatriculas.SelectedIndexChanged
    Dim anio As String = ""

    If chkAnio.Checked = True AndAlso cboMatriculas.SelectedIndex > -1 Then
      anio = DirectCast(cboMatriculas.SelectedItem, Matricula).Anio.Anio
    End If

    Me.Filtrar(anio, cboVer.SelectedIndex, cboEntidad.SelectedIndex)
  End Sub

  Private Sub Filtrar(ByVal wAnio As String, ByVal wOpcion As Integer, ByVal wEntidad As Integer)
    Dim lista As New List(Of DetalleEstadoCuentaSeleccionar)
    Dim aux As DetalleEstadoCuentaSeleccionar

    If Me.EstadoCuenta IsNot Nothing AndAlso Me.EstadoCuenta.Count > 0 Then
      For Each det As DetalleEstadoCuentaSeleccionar In Me.EstadoCuenta
        aux = det
        If wAnio.Length > 0 AndAlso det.Obligacion IsNot Nothing AndAlso det.Obligacion.Matricula.Anio.Anio <> wAnio Then
          aux = Nothing
        End If
        If aux IsNot Nothing AndAlso wAnio.Length > 0 AndAlso det.Obligacion Is Nothing AndAlso _
            det.DetallePago IsNot Nothing AndAlso det.DetallePago.Obligacion IsNot Nothing AndAlso _
            det.DetallePago.Obligacion.Matricula.Anio.Anio <> wAnio Then
          aux = Nothing
        End If
        If aux IsNot Nothing AndAlso wAnio.Length > 0 AndAlso det.Obligacion Is Nothing AndAlso det.DetallePago.Obligacion Is Nothing Then
          aux = Nothing
        End If
        If aux IsNot Nothing AndAlso (wOpcion = 1 AndAlso det.Saldo <= 0) Then
          aux = Nothing
        End If
        If aux IsNot Nothing AndAlso ((wEntidad = 1 And det.Entidad <> "I") OrElse _
                                       (wEntidad = 2 And det.Entidad <> "C")) Then
          aux = Nothing
        End If

        If aux IsNot Nothing Then
          lista.Add(aux)
        End If
      Next
      Me.dgvObligaciones.AutoGenerateColumns = False
      Me.dgvObligaciones.DataSource = lista
    Else
      Me.dgvObligaciones.DataSource = Nothing
    End If
  End Sub

  Private Sub cboVer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVer.SelectedIndexChanged, cboEntidad.SelectedIndexChanged
    Dim anio As String = ""

    If cboMatriculas.SelectedIndex > -1 Then
      anio = DirectCast(cboMatriculas.SelectedItem, Matricula).Anio.Anio
    End If

    Filtrar(anio, cboVer.SelectedIndex, cboEntidad.SelectedIndex)
  End Sub

  Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    CambiarEstado(False)
  End Sub

  Private Sub dgvObligaciones_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvObligaciones.CellFormatting
    With DirectCast(Me.dgvObligaciones.Rows(e.RowIndex).DataBoundItem, DetalleEstadoCuenta)
      If .Obligacion IsNot Nothing AndAlso .Obligacion.Vigencia = False Then
        e.CellStyle.ForeColor = Color.Red
        e.CellStyle.SelectionBackColor = Color.SkyBlue
        e.CellStyle.SelectionForeColor = Color.Red
      End If
    End With
  End Sub

  Private Sub txtCodigo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
    If Convert.ToInt32(e.KeyChar) = Keys.Enter AndAlso txtCodigo.Text.Length > 0 Then
      Me.BuscarAlumno(txtCodigo.Text)
    End If
  End Sub

  Private Sub BuscarAlumno(ByVal wCodigo As String)
    Dim rn As New RNAlumno

    Me.Persona = rn.LeerDatosAlumno_CodigoRecaudacion(wCodigo)

    If Me.Persona IsNot Nothing Then
      Me.txtNombre.Text = Persona.NombreCompleto
      Me.MostrarMatriculas()
      Me.MostrarEstadoCuenta(Me.Persona)
    Else
      MessageBox.Show("No se encontro alumno con el código ingresado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Me.txtNombre.Text = ""
      Me.txtSeccion.Text = ""
      Me.dgvObligaciones.DataSource = Nothing
      Me.cboMatriculas.DataSource = Nothing
    End If
  End Sub

  Private Sub btnActivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    CambiarEstado(True)
  End Sub

  Private Sub CambiarEstado(ByVal wEstado As Boolean)
    Dim rnOb As New RNObligacion
    Dim det As DetalleEstadoCuentaSeleccionar
    Dim ob As Obligacion

    Try
      If Me.dgvObligaciones.Rows.Count > 0 Then
        For Each fila As DataGridViewRow In Me.dgvObligaciones.Rows
          det = DirectCast(fila.DataBoundItem, DetalleEstadoCuentaSeleccionar)
          If det.Seleccionado = True AndAlso det.Obligacion IsNot Nothing Then
            ob = det.Obligacion
            ob.Vigencia = wEstado
            rnOb.CambiarVigencia(ob)
          End If
        Next
      End If
      MessageBox.Show("La operación se realizó exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Me.MostrarEstadoCuenta(Me.Persona)
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      rnOb = Nothing
      ob = Nothing
    End Try
  End Sub

  Private Sub frmEstadoCuenta_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
    txtCodigo.Focus()
  End Sub

  Private Sub btnContactar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContactar.Click
    Dim f As frmInformacionAlumno

    If Me.Persona IsNot Nothing AndAlso TypeOf Me.Persona Is Alumno Then
      f = New frmInformacionAlumno

      f.Presentar(DirectCast(Me.Persona, Alumno))
      f.Dispose()
      f = Nothing
    End If
  End Sub

  Private Sub txtCodigo_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.Enter
    txtCodigo.SelectAll()
  End Sub

  'Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
  '  Dim rep As New crpEstadoCuenta

  '  rep.SetDataSource(Me.ListarEstadoCuentaVigente())
  '  With rep.Section1.ReportObjects
  '    DirectCast(.Item("txtAlumno"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.txtNombre.Text
  '    DirectCast(.Item("txtCodigo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.txtCodigo.Text
  '    If Me.chkAnio.Checked = True Then
  '      DirectCast(.Item("txtPeriodo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = "Año " & Me.cboMatriculas.Text
  '    Else
  '      DirectCast(.Item("txtPeriodo"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = ""
  '    End If
  '  End With
  '  With rep.Section4.ReportObjects
  '    DirectCast(.Item("txtProgramado"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.txtTotal.Text
  '    DirectCast(.Item("txtVencido"), CrystalDecisions.CrystalReports.Engine.TextObject).Text = Me.txtDeuda.Text
  '  End With

  '  With frmVisor.crvVisor
  '    'rep.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
  '    'rep.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
  '    .ShowPrintButton = True
  '    .ReportSource = rep
  '    .ShowPageNavigateButtons = True

  '    frmVisor.ShowDialog()

  '    .ReportSource = Nothing
  '    .ShowPrintButton = False
  '    .ShowPageNavigateButtons = False
  '  End With
  'End Sub

  Private Function ListarEstadoCuentaVigente() As List(Of DetalleEstadoCuentaSeleccionar)
    Dim vigentes As New List(Of DetalleEstadoCuentaSeleccionar)
    Dim lista As List(Of DetalleEstadoCuentaSeleccionar)

    lista = DirectCast(Me.dgvObligaciones.DataSource, List(Of DetalleEstadoCuentaSeleccionar))
    For Each det In lista  'Me.EstadoCuenta
      If det.Obligacion Is Nothing OrElse det.Obligacion.Vigencia = True Then
        vigentes.Add(det)
      End If
    Next

    Return vigentes
  End Function

  Private Sub dgvObligaciones_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgvObligaciones.RowPostPaint
    Dim ob As Obligacion
    Dim bloquear As Boolean

    If Me.EstadoCuenta IsNot Nothing Then
      With DirectCast(Me.dgvObligaciones.Rows.Item(e.RowIndex).DataBoundItem, DetalleEstadoCuentaSeleccionar)
        ob = .Obligacion
        If ob Is Nothing Then
          bloquear = True
        ElseIf .DetallePago IsNot Nothing Then
          bloquear = True
        End If
      End With

      If bloquear = True Then
        With Me.dgvObligaciones.Rows.Item(e.RowIndex)
          .DefaultCellStyle.BackColor = Color.WhiteSmoke
          With DirectCast(.Cells(0), DataGridViewCheckBoxCell)
            .ReadOnly = True
          End With
        End With
      End If
    End If
  End Sub

  Private Sub btnDesasociar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Dim rn As RNObligacion

    If Me.dgvObligaciones.CurrentRow IsNot Nothing AndAlso _
        DirectCast(Me.dgvObligaciones.CurrentRow.DataBoundItem, DetalleEstadoCuentaSeleccionar).DetallePago IsNot Nothing Then
      rn = New RNObligacion
      Try
        rn.DesasociarPago(DirectCast(Me.dgvObligaciones.CurrentRow.DataBoundItem, DetalleEstadoCuentaSeleccionar).DetallePago)
        Me.MostrarEstadoCuenta(Me.Persona)
      Catch ex As Exception
        MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Finally
        rn = Nothing
      End Try
    End If
  End Sub

End Class