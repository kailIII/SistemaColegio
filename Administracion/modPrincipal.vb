Module modPrincipal

  Public mOInstitucion As Institucion
  Public mOUsuario As Usuario

  Public mOAnioActual As AnioLectivo

  'Public frmVisor As New frmVisor
  'Public crpDocumento As New crpDocumentoIngreso

  Public Sub main()
    Dim f As New frmIdentificar
    Dim fPrin As frmPrincipal
    Dim fAnio As frmPeriodoActual

    Application.EnableVisualStyles()
    f.ShowDialog()

    If mOUsuario IsNot Nothing Then

      fAnio = New frmPeriodoActual
      fAnio.Configurar()
      If mOAnioActual IsNot Nothing AndAlso mOInstitucion IsNot Nothing Then
        fPrin = New frmPrincipal
        fPrin.tsslUsuario.Text = mOUsuario.Persona.NombreCompleto.ToUpper
        fPrin.tsslFecha.Text = Date.Now.ToLongDateString.ToUpper

        'frmVisor.crvVisor.ReportSource = crpDocumento
        ''frmVisor.crvVisor.InitReportViewer()
        'frmVisor.Show()
        'frmVisor.Hide()

        fPrin.ShowDialog()
      End If
    End If
  End Sub

End Module
