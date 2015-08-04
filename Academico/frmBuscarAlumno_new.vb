Public Class frmBuscarAlumno_new
  Private Alum As New Alumno

  Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click, BuscarAlumno1.DoubleClick
    BuscarAlumno()
  End Sub

  Private Sub BuscarAlumno()
    If BuscarAlumno1.dgvAlumnos.SelectedRows.Count > 0 Then
      Alum = CType(BuscarAlumno1.dgvAlumnos.SelectedRows.Item(0).DataBoundItem, Alumno)
      Me.Close()
    End If
  End Sub
  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    Me.Close()
  End Sub

  Private Sub frmBuscarAlumno_new_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    btnSeleccionar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes/seleccionar.png")
    btnCancelar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes/cancelar.png")
    Me.BuscarAlumno1.btnBuscar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes/Buscar.png")
    Me.BuscarAlumno1.txtNombreBuscar.Focus()

  End Sub
  Private Sub buAl_DobleClicGrid() Handles BuscarAlumno1.DobleClicGrid
    btnModificar_Click(Nothing, Nothing)
  End Sub

  Public Function Buscar() As Alumno
    Me.ShowDialog()
    If Alum.Nombre Is Nothing Then
      Return Nothing
    Else
      Return Alum
    End If
  End Function

End Class