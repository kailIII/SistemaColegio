Imports Microsoft.Office.Interop.Word

Public Class frmCartaDeudores

  Private ListObligacionesVenc As New List(Of DetalleDocumentoIngreso)
  Private DetalleDeuda As New DetalleDocumentoIngreso
  Private meses(12) As String

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Dim Carta As Microsoft.Office.Interop.Word.Application = Nothing
    Dim ruta As String = AppDomain.CurrentDomain.BaseDirectory & "\Plantillas\Carta"
    Dim OVencidas As New RNDetalleDctoIngreso

    Dim W As New Word.Application()
    W.Visible = True
    W.Documents.Open(ruta & ".doc")

    ListObligacionesVenc = OVencidas.ListarObligacionesVencidasCartas(CStr(cbanio.SelectedValue), CInt(cboNivel.SelectedValue), cboSeccion.SelectedValue.ToString)

    For i = 0 To ListObligacionesVenc.Count - 1
      If ListObligacionesVenc.Count > 0 Then
        DetalleDeuda = CType(ListObligacionesVenc.Item(i), DetalleDocumentoIngreso)
        With W.ActiveDocument.Fields
          .Item(1).Result.Text = "Chiclayo, " & Now.Day & " de " & meses(Now.Month) & " de " & Now.Year
          .Item(2).Result.Text = DetalleDeuda.Obligacion.Matricula.Parentesco.Apoderado.NombreCompleto.ToString
          If DetalleDeuda.Item = 1 Then
            .Item(3).Result.Text = DetalleDeuda.Item & " mes"
          Else
            .Item(3).Result.Text = DetalleDeuda.Item & " meses"
          End If
          .Item(4).Result.Text = "S/. " & DetalleDeuda.Monto
        End With
        W.ActiveDocument.SaveAs(ruta & " " & Str(i + 1) & " " & DetalleDeuda.Obligacion.Matricula.Parentesco.Apoderado.NombreCompleto.ToString & ".doc")
        Me.pbAvance.Value += 1
      End If

    Next
    Me.pbAvance.Value = Me.pbAvance.Maximum

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

    ListAn = Nothing
  End Sub
  Public Sub cargarcboNivelAcademico()
    Dim ListNa As New List(Of Nivel)
    Dim objNa As New RNNivel
    ListNa = objNa.Listar()
    cboNivel.DisplayMember = "nombre"
    cboNivel.ValueMember = "codigoNivel"
    cboNivel.DataSource = ListNa
    ListNa = Nothing
  End Sub
  Public Sub cargarcboSeccion()
    Dim ListSec As New List(Of Seccion)
    Dim objS As New RNSeccion
    ListSec = objS.Leer_NivelAcad(CType(cbanio.SelectedItem, AnioLectivo), CType(cboNivel.SelectedItem, Nivel), 1)
    cboSeccion.DisplayMember = "numeroletra"
    cboSeccion.ValueMember = "CodigoLetra"
    cboSeccion.DataSource = ListSec
    ListSec = Nothing
  End Sub

  Public Sub LlenarMeses()
    meses(1) = "Enero"
    meses(2) = "Febrero"
    meses(3) = "Marzo"
    meses(4) = "Abril"
    meses(5) = "Mayo"
    meses(6) = "Junio"
    meses(7) = "Julio"
    meses(8) = "Agosto"
    meses(9) = "Septiembre"
    meses(10) = "Octubre"
    meses(11) = "Noviembre"
    meses(12) = "Diciembre"

  End Sub

  Private Sub frmCartaDeudores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    CargarImagenes()
    cargarcbanio()
    cargarcboNivelAcademico()
    cargarcboSeccion()
    LlenarMeses()
  End Sub
  Public Sub CargarImagenes()
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Exportar.png")
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Close()
  End Sub
  Private Sub cboNivel_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    cargarcboSeccion()
  End Sub
End Class