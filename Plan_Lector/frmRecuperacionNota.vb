Public Class frmRecuperacionNota

  Private dao As New RNLibro()
  Private notaL As NotaLectura
  Private libro As Libro

  'Tania Incio
  'Elegir nota para recuperación
    Public Sub Gestionar(ByVal obj As NotaLectura, ByVal notaRec As String)
        If obj IsNot Nothing Then
            Me.notaL = obj
            libro = dao.LibroXcodProgLectura(notaL.ProgLectura.Codigo)
            Me.ListarLibros(notaL.ProgLectura.Codigo)
            Me.cboLibro.SelectedValue = libro.Codigo
            Me.txtNotaRecuperacion.Text = notaRec
            Me.ShowDialog()
        End If
    End Sub

  Private Sub ListarLibros(ByVal codigoP As Integer)
        Dim la As List(Of GradoLibro)
        Dim grado As Grado = (dao.GradoXcodProgLectura(codigoP))

        la = dao.ListarLibros_Grado(grado, modPrincipal.moAnioActual)

    If la.Count > 0 Then
            Me.cboLibro.DisplayMember = "NombreLibro"
            Me.cboLibro.ValueMember = "CodigoLibro"
            Me.cboLibro.DataSource = la

    Else
      Me.cboLibro.DataSource = Nothing
    End If
  End Sub

  Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    Dim notaR = Me.txtNotaRecuperacion.Text

        If validar(notaR.Trim) Then
            Dim gradoL = DirectCast(Me.cboLibro.SelectedItem, GradoLibro)
            Dim daoNL As New RNNotaLectura()
            notaL.NotaRecuperacion = notaR
            notaL.LibroRecuperacion = gradoL.Libro.Titulo
            Me.Close()
        End If
  End Sub

    Private Function validar(ByVal letra As String) As Boolean
        If Not (letra = "A" Or letra = "B" Or letra = "C" Or letra = "AD" Or letra = "NP") Then
            MessageBox.Show("Sólo puede ingresar: A,B,C,AD y NP", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If
    End Function

  Private Sub frmRecuperacionNota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnAceptar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Seleccionar.png")
        Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.txtNotaRecuperacion.Focus()
  End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class