Module modPrincipal

  Public mOInstitucion As Institucion
  Public moAnioActual As AnioLectivo
  Public mOPeriodoActual As PeriodoAcademico
  Public mOUsuario As Usuario
  Public mODocente As Docente

  Public Sub main()
    Dim f As New frmIdentificar
    Dim fPer As frmPeriodoActual

    Application.EnableVisualStyles()
    f.ShowDialog()
    If mOUsuario IsNot Nothing Then
      fPer = New frmPeriodoActual
      fPer.Configurar()
      'Application.Run(fPer)

      If mOInstitucion IsNot Nothing Then
        Application.Run(New frmPrincipal)
      End If
    End If
  End Sub

End Module
