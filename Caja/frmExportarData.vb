Imports System.IO

Public Class frmExportarData

  Private Lo As New List(Of Obligacion)
  Private cancelar As Boolean = False
  Private ctaBanc As CuentaBancaria = Nothing

  Private Sub frmExportarData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.btnVer.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\ver2.gif")
    Me.btnCerrar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Cerrar.png")
    Me.btnExportar.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "Imagenes\Guardar.png")
    If Me.cboEntidadFinanciera.Items.Count > 0 Then
      Me.cboEntidadFinanciera.SelectedIndex = 0
    End If
    Me.cargarCboEntidadFinanciera()
    Me.btnExportar.Select()
  End Sub

  Private Sub cboEntidadFinanciera_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboEntidadFinanciera.SelectedIndexChanged
    If Me.cboEntidadFinanciera.Items.Count > -1 Then
      ctaBanc = New CuentaBancaria
      If cboEntidadFinanciera.SelectedIndex = 0 Then

        btnExportarIntegrantesBIF.Visible = False
      Else

        btnExportarIntegrantesBIF.Visible = True
      End If
    Else
      MessageBox.Show("No existen cuentas bancarias", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Exit Sub
    End If
    Me.cboCuenta.SelectedIndex = -1
  End Sub

  Public Sub cargarCboEntidadFinanciera()
    Dim ListA As New List(Of EntidadFinanciera)
    Dim objE As New RNEntidadFinanciera

    ListA = objE.Listar
    If ListA.Count > 0 Then
      cboEntidadFinanciera.DisplayMember = "nombre"
      cboEntidadFinanciera.ValueMember = "codigoEntidad"
      cboEntidadFinanciera.DataSource = ListA
      cboEntidadFinanciera.SelectedIndex = 0
      ListA = Nothing
    End If
  End Sub

  Private Function retornaCuentaCtte() As CuentaBancaria
    Dim objRN As New RNEntidadFinanciera

    Return objRN.ListarCuentas(CType(Me.cboEntidadFinanciera.SelectedItem, EntidadFinanciera)).Item(0)
  End Function

  Public Function CambiarLetra(ByVal cad As String) As String
    cad = cad.Replace("Ñ", "N") _
          .Replace("Á", "A") _
          .Replace("É", "E") _
          .Replace("Í", "I") _
          .Replace("Ó", "O") _
          .Replace("Ú", "U") _
          .Replace("Ä", "A") _
          .Replace("Ë", "E") _
          .Replace("Ï", "I") _
          .Replace("Ö", "O") _
          .Replace("Ü", "U") _
          .Replace("'", "")
    Return cad
  End Function

  Public Function calcularTodo() As Double
    Dim total As Double
    For i = 0 To Lo.Count - 1
      total = total + Lo.ElementAt(i).Monto
    Next
    Return total
  End Function

  'Private Function codigoCuentaCtte() As CuentaBancaria
  '  Dim objRN As New RNEntidadFinanciera

  '  Return objRN.ListarCuentas(CType(Me.cboEntidadFinanciera.SelectedItem, EntidadFinanciera)).Item(0)
  'End Function

  Private Sub ExportarDataBCP()
    Dim objRnIns As New RNInstitucion
    Dim inst As Institucion
    Dim fic As String
    Dim cadena As String
    Dim cadenaCab As String
    Dim tipval As String
    Dim tipoRegD As String
    Dim tipoRegC As String
    Dim codSuc As String
    Dim codRec As Integer

    tipoRegD = "DD"
    tipoRegC = "CC"
    codSuc = "305"
    tipval = "C"

    Try
      Dim cadfecha As String = Me.dtpFecha.Value.ToString("yyyy-MM-dd")

      fic = "C:\BANCOS\BCP\EXPORTAR\DATA " + "BCP " + cadfecha + " .txt"
      inst = objRnIns.Listar
      If Not Directory.Exists("c:\BANCOS\BCP\EXPORTAR") Then
        Directory.CreateDirectory("c:\BANCOS\BCP\EXPORTAR")
      Else
        If File.Exists("C:\BANCOS\BCP\EXPORTAR\DATA " + "BCP " + cadfecha + " .txt") Then
          If MessageBox.Show("El arcivo ya existe, Dese eliminar y volver a crear el archivo?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            My.Computer.FileSystem.DeleteFile("C:\BANCOS\BCP\EXPORTAR\DATA " + "BCP " + cadfecha + " .txt", FileIO.UIOption.AllDialogs, _
            FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
          Else
            Exit Sub
          End If
        End If
      End If
      Randomize()
      Me.pbProgreso.Minimum = 0
      Me.pbProgreso.Maximum = Lo.Count
      Dim sw As New System.IO.StreamWriter(fic, True)

      cadenaCab = tipoRegC & codSuc & ctaBanc.NumeroMoneda.ToString & ctaBanc.Numero.Trim & tipval & _
                  CambiarLetra(inst.Nombre.ToUpper).PadRight(40).Substring(0, 40) & _
                  dtpFecha.Value.ToString("yyyyMMdd") & Lo.Count.ToString(New String("0"c, 9)) & _
                  (calcularTodo() * 100).ToString(New String("0"c, 15)) & " ".PadRight(114)
      sw.WriteLine(cadenaCab)
      'cuenta = "1600540"
      For i = 0 To Lo.Count - 1
        With Lo.ElementAt(i)
          cadena = tipoRegD & codSuc & ctaBanc.NumeroMoneda.ToString.Trim & ctaBanc.Numero.Trim
          If Integer.TryParse(.Matricula.Alumno.CodigoRecaudacion, codRec) = True Then
            cadena &= codRec.ToString(New String("0"c, 14))
          Else
            cadena &= .Matricula.Alumno.CodigoRecaudacion.PadLeft(14)
          End If
          cadena &= CambiarLetra(.Matricula.Alumno.NombreCompleto.ToUpper).PadRight(40).Substring(0, 40) & _
                   .Tipo_Pension.PadRight(7) & .Descripcion.PadRight(23).Substring(0, 23) & _
                   dtpFecha.Value.ToString("yyyyMMdd") & _
                   .FechaVencimiento.ToString("yyyyMMdd") & _
                   (.Monto * 100).ToString(New String("0"c, 15)) & _
                   0.ToString(New String("0"c, 15)) & _
                   0.ToString(New String("0"c, 57))
        End With
        sw.WriteLine(cadena)
        pbProgreso.Value = i + 1
      Next
      sw.Close()
      MessageBox.Show("El archivo fue creado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Lo.Clear()
      Lo = Nothing
      pbProgreso.Value = 0
    Catch ex As Exception
      MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub ExportarDataBIF() 'BANCO INTERAMERICANO DE FINANZAS
    Dim fic As String
    Dim cadena As String
    Dim cadAux As String
    Dim cod As String

    Try
      Dim cadfecha As String = String.Format("{00:yyyy-MM-dd}", Me.dtpFecha.Value)
      fic = "C:\BANCOS\BIF\EXPORTAR\DATA " + "BIF " + cadfecha + " .txt"
      If Not Directory.Exists("C:\BANCOS\BIF\EXPORTAR") Then
        Directory.CreateDirectory("C:\BANCOS\BIF\EXPORTAR")
      Else
        If File.Exists("C:\BANCOS\BIF\EXPORTAR\DATA " + "BIF " + cadfecha + " .txt") Then
          If MessageBox.Show("El archivo ya existe, ¿desea eliminar y volver a crear el archivo?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            My.Computer.FileSystem.DeleteFile("C:\BANCOS\BIF\EXPORTAR\DATA " + "BIF " + cadfecha + " .txt", FileIO.UIOption.AllDialogs, _
            FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
          Else
            Exit Sub
          End If
        End If
      End If
      Randomize()
      Me.pbProgreso.Minimum = 0
      Me.pbProgreso.Maximum = Lo.Count
      Dim sw As New System.IO.StreamWriter(fic, False, System.Text.Encoding.Default)
      cadAux = dtpFecha.Value.ToString("yMMddHH").Substring(1, 7)
      For i = 0 To Lo.Count - 1
        With Lo.ElementAt(i)
          'If .Matricula.Alumno.CodigoRecaudacion.IndexOf("A") = -1 Then
          '  cod = CInt(.Matricula.Alumno.CodigoRecaudacion).ToString(New String("0"c, 20))
          'Else
          '  cod = .Matricula.Alumno.CodigoRecaudacion.PadRight(20)
          'End If
          cod = .Matricula.Alumno.CodigoRecaudacion.PadLeft(20)
          cadena = cadAux & (i + 1).ToString(New String("0"c, 5)) & _
                cod & _
                New String("0"c, 8) & _
                .FechaVencimiento.ToString("yyyyMMdd") & _
                ctaBanc.DescripcionMoneda & _
                .Tipo_Pension.ToString.PadLeft(12) & _
                .Descripcion.PadRight(40).Substring(0, 40) & _
                New String(" "c, 60) & _
                "0" & _
                "01" & _
                (Lo.ElementAt(i).Monto * 100).ToString(New String("0"c, 10)) & _
                "00" & New String("0"c, 10) & _
                "00" & New String("0"c, 10) & _
                "00" & New String("0"c, 10) & _
                "00" & New String("0"c, 10) & _
                "00" & New String("0"c, 10)
        End With
        sw.WriteLine(cadena)
        pbProgreso.Value = i + 1
      Next
      sw.Close()
      MessageBox.Show("El archivo fue creado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      Lo.Clear()
      Lo = Nothing
      pbProgreso.Value = 0
    Catch ex As Exception
      MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
    Dim objRN As RNObligacion

    If Me.cboCuenta.SelectedIndex > -1 Then
      objRN = New RNObligacion
      Me.ctaBanc = DirectCast(Me.cboCuenta.SelectedItem, CuentaBancaria)
      Try
        Lo = objRN.ListarObligaciones(CInt(Me.nudMeses.Value))
        If Me.cboEntidadFinanciera.SelectedIndex = 0 Then
          Me.ExportarDataBCP()
        Else
          Me.ExportarDataBIF()
        End If
      Catch ex As Exception
        MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      End Try
    Else
      MessageBox.Show("Debe seleccionar una cuenta bancaria", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
    Me.Dispose()
    Me.Close()
  End Sub

  Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
    Try
      If cboEntidadFinanciera.SelectedIndex = 0 Then
        Shell("explorer.exe root = C:\BANCOS\BCP\EXPORTAR\", AppWinStyle.NormalFocus)
      Else
        Shell("explorer.exe root = C:\BANCOS\BIF\EXPORTAR\", AppWinStyle.NormalFocus)
      End If

    Catch ex As Exception
      MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub btnExportarIntegrantesBIF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportarIntegrantesBIF.Click
    Dim cadena As String
    Dim ListMat As New List(Of Matricula)
    Dim obj As New RNMatricula
    Dim cadfecha As String = Me.dtpFecha.Value.ToString("yyyy-MM-dd")
    Dim fic As String = "C:\BANCOS\BIF\ " + "BIF " + cadfecha + " .txt"
    Dim integrante As String

    Try
      ListMat = obj.ListarAlumnosEstructuraIntegrantes
      If File.Exists("C:\BANCOS\BIF\ " + "BIF " + cadfecha + " .txt") Then
        If MessageBox.Show("El archivo ya existe, desea eliminar y volver a crear el archivo?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
          My.Computer.FileSystem.DeleteFile("C:\BANCOS\BIF\ " + "BIF " + cadfecha + " .txt", FileIO.UIOption.AllDialogs, _
          FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
        Else
          Exit Sub
        End If
      End If
      Randomize()
      Me.pbProgreso.Minimum = 0
      Me.pbProgreso.Maximum = ListMat.Count
      Dim sw As New System.IO.StreamWriter(fic, False, System.Text.Encoding.Default)
      Dim i As Integer = 0

      For Each elem In ListMat
        integrante = elem.Seccion.Grado.Nivel.Orden.ToString("0000")
        With elem.Alumno
          cadena = .CodigoRecaudacion.ToString.PadRight(20) & _
                    .ApellidoPaterno.Trim.PadRight(20).Substring(0, 20) & _
                    .ApellidoMaterno.Trim.PadRight(20).Substring(0, 20) & _
                    .Nombre.PadRight(20).Substring(0, 20) & _
                    integrante & _
                    elem.Grado.Numero.ToString(New String("0"c, 2)) & _
                    elem.Letra.PadRight(2) & _
                    New String(" "c, 2) & _
                    "00"
        End With
        sw.WriteLine(cadena)
        pbProgreso.Value = i + 1
      Next
      sw.Close()
      MessageBox.Show("El archivo fue creado con éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
      ListMat.Clear()
      ListMat = Nothing
      pbProgreso.Value = 0
    Catch ex As Exception
      MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Try
  End Sub

  Private Sub cboCuenta_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCuenta.Enter
    Dim rn As RNEntidadFinanciera

    If Me.cboEntidadFinanciera.SelectedItem IsNot Nothing Then
      rn = New RNEntidadFinanciera
      Me.cboCuenta.DisplayMember = "Numero"
      Me.cboCuenta.ValueMember = "Numero"
      Me.cboCuenta.DataSource = rn.ListarCuentas(DirectCast(cboEntidadFinanciera.SelectedItem, EntidadFinanciera))
      If Me.cboCuenta.Items.Count = 1 Then
        Me.cboCuenta.SelectedIndex = 0
      End If
    Else
      MessageBox.Show("Debe seleccionar una entidad financiera", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

End Class