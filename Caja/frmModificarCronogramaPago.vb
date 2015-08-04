Public Class frmModificarCronogramaPago

  Private fechaPagoActual As FechaPago

  Private Shared frm As frmModificarCronogramaPago

  Private Sub New()
    ' Llamada necesaria para el Diseñador de Windows Forms.
    InitializeComponent()
  End Sub

  Private Sub frmLiquidacionDia_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    frmModificarCronogramaPago.frm = Nothing
  End Sub

  Public Shared Function Crear(ByVal wPadre As Form) As frmModificarCronogramaPago

    If frmModificarCronogramaPago.frm Is Nothing Then
      frmModificarCronogramaPago.frm = New frmModificarCronogramaPago
      With frmModificarCronogramaPago.frm
        .MdiParent = wPadre
      End With
    End If

    Return frmModificarCronogramaPago.frm
  End Function

  Public Sub Presentar()
    Me.Show()
  End Sub

  Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
    Dim rn As New RNFechaPago

    Try
      rn.Modificar(Me.fechaPagoActual, New FechaPago With {.Descripcion = Me.txtDescripcion.Text.Trim, .Fecha = Me.dtpFecha.Value})
      Me.gbFecha.Enabled = False
      Me.btnActualizar.PerformClick()
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      rn = Nothing
    End Try
  End Sub

  Private Sub frmModificarCronogramaPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.CargarAnios(modPrincipal.mOInstitucion)
    Me.cboAnio.SelectedValue = modPrincipal.mOAnioActual.Anio
  End Sub

  Private Sub CargarAnios(ByVal wInst As Institucion)
    Dim rnA As New RNAnioLectivo
    Dim lA As List(Of AnioLectivo)

    lA = rnA.Listar(wInst)
    cboAnio.DisplayMember = "Anio"
    cboAnio.ValueMember = "Anio"
    cboAnio.DataSource = lA
  End Sub

  Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
    Dim rn As New RNFechaPago
    Dim fechas As List(Of FechaPago)

    Try
      fechas = rn.Listar(DirectCast(Me.cboAnio.SelectedItem, AnioLectivo))
      Me.dgvCronograma.DataSource = Nothing
      Me.dgvCronograma.AutoGenerateColumns = False
      Me.dgvCronograma.DataSource = fechas
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
      rn = Nothing
    End Try
  End Sub

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
    If Me.dgvCronograma.CurrentRow IsNot Nothing Then
      Me.fechaPagoActual = DirectCast(Me.dgvCronograma.CurrentRow.DataBoundItem, FechaPago)
      With Me.fechaPagoActual
        Me.txtDescripcion.Text = .Descripcion
        Me.dtpFecha.Value = .Fecha
        Me.gbFecha.Enabled = True
      End With
    Else
      MessageBox.Show("Debe seleccionar una fecha del cronograma", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End If
  End Sub

  Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.gbFecha.Enabled = False
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Dispose()
  End Sub

End Class